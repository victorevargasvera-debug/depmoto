using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using Motorola.Common.Communication.CommonFile;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.Pba;
using Motorola.Common.Communication.Rcmp;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication
{
	// Token: 0x02000002 RID: 2
	public class AstroFileFlashSequenceManager : global::Motorola.Common.Communication.AstroFileSeqManager, global::Motorola.Common.Communication.IFlashSequenceManager
	{
		// Token: 0x06000001 RID: 1 RVA: 0x000020D0 File Offset: 0x000002D0
		public AstroFileFlashSequenceManager(global::Motorola.Common.Communication.IMessageExecutor rcmpWrapper, global::Motorola.Common.Communication.CommonUtil.SessionParameter sessionParameter) : base(rcmpWrapper, sessionParameter)
		{
			this._bFirmwareUpdated = false;
			this.currentStep = 1.0;
			this.m_MaxTransportPacketSize = 1368;
			this.IOControllerFlsh = new global::Motorola.Common.Communication.IOControllerFlash(rcmpWrapper, this.m_MaxTransportPacketSize);
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002110 File Offset: 0x00000310
		public override void OpenSession(ushort sessionID, global::Motorola.Common.Communication.CommonUtil.RadioOperation operation)
		{
			if (operation == global::Motorola.Common.Communication.CommonUtil.RadioOperation.Flash)
			{
				base.UnlockRadioPartition(0);
				base.EnterProgramMode();
				ushort num;
				ushort num2;
				base.IOController.ComponentSession(3, sessionID, out num, out num2);
			}
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002140 File Offset: 0x00000340
		public override void CloseSession(ushort sessionID, global::Motorola.Common.Communication.CommonUtil.RadioOperation operation, bool pendingDeploy)
		{
			if (operation == global::Motorola.Common.Communication.CommonUtil.RadioOperation.Flash)
			{
				if (!pendingDeploy)
				{
					ushort num;
					ushort num2;
					base.IOController.ComponentSession(32, sessionID, out num, out num2);
					this.ValidateUpdate();
				}
				base.ExitProgramMode();
			}
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002174 File Offset: 0x00000374
		public void ValidateUpdate()
		{
			byte b = 0;
			if (this._bFirmwareUpdated && this.IOControllerFlsh.RadioUpdateControl(5, ref b) != global::Motorola.Common.Communication.CommonUtil.SequenceManagerResult.Success)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.UpdateDevice_Astro_FirmwareValidationFailed);
			}
		}

		// Token: 0x06000005 RID: 5 RVA: 0x000021C4 File Offset: 0x000003C4
		public virtual void UpdateDevice(global::Motorola.Common.Communication.Pba.PbaObject pbaObject, ushort sessionID)
		{
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(pbaObject, global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
			global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo extendedDeviceInfo = base.ExtendedDeviceInfo;
			byte[] buffer = pbaObject.SerializeToBytes();
			global::Motorola.Common.Communication.Pba.PbaObject writePBA = global::Motorola.Common.Communication.Pba.PbaObject.DeserializeFromBytes(buffer, false);
			this.WriteDevice(writePBA, 0, null);
			if (base.ProgressIndicator != null)
			{
				base.ProgressIndicator.SetCurrentScope(8, 64);
				base.ProgressIndicator.UpdateProgress(0.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.UpgradeRadio);
			}
			if (pbaObject.UpdateData.MemoryImages.Count > 0)
			{
				if (pbaObject.UpdateData.MemoryImages.Any((global::Motorola.Common.Communication.Pba.RadioImage p) => p.FileType != global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.FLASHTOFILESYSTEM))
				{
					bool eraseFlash = false;
					if (!string.IsNullOrEmpty(extendedDeviceInfo.SoftwareVersion) && extendedDeviceInfo.SoftwareVersion.Substring(1, 2) == "01")
					{
						eraseFlash = true;
					}
					try
					{
						global::System.GC.WaitForPendingFinalizers();
						global::Motorola.Common.Communication.AutoReleasedSemaphore.addUpgradeJobSem.WaitOne(600000);
						this.upgradeFile = new global::Motorola.Common.Communication.FlashportUpgradeFile(pbaObject.UpdateData.MemoryImages[0].FilePath);
						if (this.upgradeFile.OpenUpgradeFile())
						{
							this.FlashRadioFileSystem(extendedDeviceInfo, pbaObject, eraseFlash);
							goto IL_1D4;
						}
						throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.UpdateDevice_Astro_InvalidFlashData);
					}
					finally
					{
						this.upgradeFile = null;
						global::System.GC.Collect();
						global::Motorola.Common.Communication.AutoReleasedSemaphore.addUpgradeJobSem.Release();
					}
				}
			}
			if (pbaObject.UpdateData.MemoryImages.Count > 0)
			{
				if (pbaObject.UpdateData.MemoryImages.Any((global::Motorola.Common.Communication.Pba.RadioImage p) => p.FileType == global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.FLASHTOFILESYSTEM))
				{
					global::Motorola.Common.Communication.Pba.RadioImage imageFromList = global::Motorola.Common.Communication.Pba.RadioImage.GetImageFromList(pbaObject.UpdateData.MemoryImages, global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.FLASHTOFILESYSTEM);
					this.upgradeFile = new global::Motorola.Common.Communication.FlashportUpgradeFile(imageFromList.FilePath);
					if (!global::System.IO.File.Exists(imageFromList.FilePath) || !this.upgradeFile.verifyChecksum())
					{
						throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.UpdateDevice_Astro_InvalidFlashData);
					}
					this.FlashRadioImageToFileSystem();
				}
			}
			IL_1D4:
			if (pbaObject.LanguagePackData != null && pbaObject.LanguagePackData.LanguagePacks.Count > 0)
			{
				base.ProgressIndicator.SetCurrentScope(65, 100);
				base.ProgressIndicator.UpdateProgress(0.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.WritingLanguages);
				(pbaObject.LanguagePackData.LanguagePacks[0] as global::Motorola.Common.Communication.Pba.AstroFilePackInfo).isFlashPortUpgradeLP = true;
				base.WriteLanguagePacks(pbaObject.LanguagePackData);
			}
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002420 File Offset: 0x00000620
		public bool WriteRamdownloader(string filepath)
		{
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.NotImplemented);
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002428 File Offset: 0x00000628
		public global::Motorola.Common.Communication.Pba.UpdateDeviceData ReadImage(global::Motorola.Common.Communication.Pba.UpdateDeviceData images)
		{
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.NotImplemented);
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002430 File Offset: 0x00000630
		public override global::Motorola.Common.Communication.Pba.PbaObject WriteDevice(global::Motorola.Common.Communication.Pba.PbaObject writePBA, ushort sessionID, string pcrNewPassword)
		{
			if (base.ProgressIndicator != null)
			{
				base.ProgressIndicator.SetCurrentScope(0, 7);
			}
			if (!base.DifferentialWriteCapableRadio)
			{
				base.WriteValidation(writePBA);
			}
			if (base.DifferentialWriteCapableRadio && writePBA.DifferetialCodeplugData != null)
			{
				this.WriteRadioCodeplug(new global::Motorola.Common.Communication.Pba.PbaObject
				{
					CodeplugData = writePBA.DifferetialCodeplugData
				}, true);
			}
			else
			{
				this.WriteRadioCodeplug(writePBA, true);
			}
			return writePBA;
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002498 File Offset: 0x00000698
		public void FlashRadioImageToFileSystem()
		{
			byte[] bbffileData = this.upgradeFile.GetBBFFileData();
			using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream())
			{
				memoryStream.Write(bbffileData, 0, bbffileData.Length);
				base.IOController.FileWrite(0, "update.bbf", memoryStream, base.ProgressIndicator, false);
			}
			if (base.ProgressIndicator != null)
			{
				base.ProgressIndicator.UpdateProgress(1.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.WriteSoftwareDone);
			}
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002518 File Offset: 0x00000718
		public override global::Motorola.Common.Communication.Pba.PbaObject ReadDevice(global::Motorola.Common.Communication.Pba.PbaObject referencePba, ushort sessionID)
		{
			if (base.ProgressIndicator != null)
			{
				base.ProgressIndicator.SetCurrentScope(0, 7);
				base.ProgressIndicator.UpdateProgress(0.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.ReadingCP);
			}
			string cpversion = base.IOController.QueryCodeplugVersion();
			ushort compInstance = 2;
			uint num;
			string text;
			base.IOController.ReadComponentFile(global::Motorola.Common.Communication.Rcmp.XcmpComponentRead.ComponentType.IshCodeplug, compInstance, out num, out text);
			string text2 = 1U.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + "_" + compInstance.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + "_1.cmp";
			string text3 = text;
			char[] trimChars = new char[1];
			text = text3.Trim(trimChars);
			string filePath = string.IsNullOrEmpty(text) ? text2 : ("/" + text2);
			ushort filePartition = 0;
			byte[] fileData = null;
			using (global::System.IO.MemoryStream memoryStream = base.IOController.FileRead(filePartition, filePath, null))
			{
				fileData = memoryStream.ToArray();
			}
			global::Motorola.Common.Communication.CommonFile.PartitionCommonFile partitionCommonFile = new global::Motorola.Common.Communication.CommonFile.PartitionCommonFile(true);
			global::Motorola.Common.Communication.Pba.PbaObject pbaObject = partitionCommonFile.Deserialize(fileData);
			pbaObject.CodeplugData.CPVersion = cpversion;
			if (base.ProgressIndicator != null)
			{
				base.ProgressIndicator.UpdateProgress(1.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.ReadCPDone);
			}
			return pbaObject;
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002758 File Offset: 0x00000958
		private void FlashRadioFileSystem(global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo currDeviceInfo, global::Motorola.Common.Communication.Pba.PbaObject pbaObject, bool eraseFlash)
		{
			this.totalStepOperations = pbaObject.UpdateData.MemoryImages.Count<global::Motorola.Common.Communication.Pba.RadioImage>() + 2;
			this.currentStep = 1.0;
			if (pbaObject == null || currDeviceInfo == null)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
			}
			this.IOControllerFlsh.PollBackgroundEraser(delegate(double progress)
			{
				if (base.ProgressIndicator != null)
				{
					base.ProgressIndicator.UpdateProgress(progress / 100.0 / (double)this.totalStepOperations, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.EraseFlash);
				}
			});
			byte activePartition = this.IOControllerFlsh.GetActivePartition(1);
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.RadioImage> memoryImages = pbaObject.UpdateData.MemoryImages;
			if (memoryImages.Any((global::Motorola.Common.Communication.Pba.RadioImage p) => p.FileType == global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.HOST))
			{
				bool compressed = true;
				global::Motorola.Common.Communication.Pba.AstroMemoryImage astroMemoryImage = (global::Motorola.Common.Communication.Pba.AstroMemoryImage)global::Motorola.Common.Communication.Pba.RadioImage.GetImageFromList(memoryImages, global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.HOST);
				string empty = string.Empty;
				if (string.IsNullOrEmpty(astroMemoryImage.ComponentName))
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.UpdateDevice_Astro_InvalidFlashData);
				}
				this._bFirmwareUpdated = true;
				if (eraseFlash)
				{
					compressed = false;
				}
				this.currentStep += 1.0;
				this.upgradeFile.GetComponentData(astroMemoryImage.ComponentName, out empty);
				this.IOControllerFlsh.FlashComponent(empty, compressed, this.m_MaxTransportPacketSize, delegate(double progress)
				{
					if (base.ProgressIndicator != null)
					{
						base.ProgressIndicator.UpdateProgress(progress / (double)this.totalStepOperations + this.currentStep / (double)this.totalStepOperations, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.UpgradeHost);
					}
				});
			}
			if (memoryImages.Any((global::Motorola.Common.Communication.Pba.RadioImage p) => p.FileType == global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.MACE))
			{
				bool compressed = false;
				global::Motorola.Common.Communication.Pba.AstroMemoryImage astroMemoryImage2 = (global::Motorola.Common.Communication.Pba.AstroMemoryImage)global::Motorola.Common.Communication.Pba.RadioImage.GetImageFromList(memoryImages, global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.MACE);
				string empty2 = string.Empty;
				if (string.IsNullOrEmpty(astroMemoryImage2.ComponentName))
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.UpdateDevice_Astro_InvalidFlashData);
				}
				this.currentStep += 1.0;
				this.upgradeFile.GetComponentData(astroMemoryImage2.ComponentName, out empty2);
				this.IOControllerFlsh.FlashComponent(empty2, compressed, this.m_MaxTransportPacketSize, delegate(double progress)
				{
					if (base.ProgressIndicator != null)
					{
						base.ProgressIndicator.UpdateProgress(progress / (double)this.totalStepOperations + this.currentStep / (double)this.totalStepOperations, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.UpgradeMace);
					}
				});
			}
			if (memoryImages.Any((global::Motorola.Common.Communication.Pba.RadioImage p) => p.FileType == global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.OPTION))
			{
				bool compressed = false;
				global::Motorola.Common.Communication.Pba.AstroMemoryImage astroMemoryImage3 = (global::Motorola.Common.Communication.Pba.AstroMemoryImage)global::Motorola.Common.Communication.Pba.RadioImage.GetImageFromList(memoryImages, global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.OPTION);
				string empty3 = string.Empty;
				if (string.IsNullOrEmpty(astroMemoryImage3.ComponentName))
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.UpdateDevice_Astro_InvalidFlashData);
				}
				this.currentStep += 1.0;
				this.upgradeFile.GetComponentData(astroMemoryImage3.ComponentName, out empty3);
				this.IOControllerFlsh.FlashComponent(empty3, compressed, this.m_MaxTransportPacketSize, delegate(double progress)
				{
					if (base.ProgressIndicator != null)
					{
						base.ProgressIndicator.UpdateProgress(progress / (double)this.totalStepOperations + this.currentStep / (double)this.totalStepOperations, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.UpgradeOptBrd);
					}
				});
			}
			if (memoryImages.Any((global::Motorola.Common.Communication.Pba.RadioImage p) => p.FileType == global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.ACCY))
			{
				bool compressed = false;
				global::Motorola.Common.Communication.Pba.AstroMemoryImage astroMemoryImage4 = (global::Motorola.Common.Communication.Pba.AstroMemoryImage)global::Motorola.Common.Communication.Pba.RadioImage.GetImageFromList(memoryImages, global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.ACCY);
				string empty4 = string.Empty;
				if (string.IsNullOrEmpty(astroMemoryImage4.ComponentName))
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.UpdateDevice_Astro_InvalidFlashData);
				}
				this.currentStep += 1.0;
				this.upgradeFile.GetComponentData(astroMemoryImage4.ComponentName, out empty4);
				this.IOControllerFlsh.FlashComponent(empty4, compressed, this.m_MaxTransportPacketSize, delegate(double progress)
				{
					if (base.ProgressIndicator != null)
					{
						base.ProgressIndicator.UpdateProgress(progress / (double)this.totalStepOperations + this.currentStep / (double)this.totalStepOperations, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.UpgradeAccBrd);
					}
				});
			}
			if (this._bFirmwareUpdated)
			{
				global::Motorola.Common.Communication.CommonUtil.SequenceManagerResult sequenceManagerResult = this.IOControllerFlsh.CopyActiveToInactive("PDTA", "PDTB", (uint)activePartition);
				if (sequenceManagerResult != global::Motorola.Common.Communication.CommonUtil.SequenceManagerResult.Success)
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.UpdateDevice_Astro_CopyPsdtFailed);
				}
			}
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002ABF File Offset: 0x00000CBF
		public override void WriteLanguagePacks(global::Motorola.Common.Communication.Pba.LanguagePackData langPackData)
		{
			if (base.ProgressIndicator != null)
			{
				base.ProgressIndicator.SetCurrentScope(0, 7);
			}
			base.WriteLanguagePacks(langPackData);
		}

		// Token: 0x04000001 RID: 1
		private double currentStep;

		// Token: 0x04000002 RID: 2
		private int totalStepOperations;

		// Token: 0x04000003 RID: 3
		private int m_MaxTransportPacketSize;

		// Token: 0x04000004 RID: 4
		private readonly global::Motorola.Common.Communication.IOControllerFlash IOControllerFlsh;

		// Token: 0x04000005 RID: 5
		private bool _bFirmwareUpdated;

		// Token: 0x04000006 RID: 6
		private global::Motorola.Common.Communication.FlashportUpgradeFile upgradeFile;
	}
}
