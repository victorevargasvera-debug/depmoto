using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.Pba;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication
{
	// Token: 0x02000003 RID: 3
	public class AstroFlashSequenceManager : global::Motorola.Common.Communication.AstroCpsSequenceManager, global::Motorola.Common.Communication.IFlashSequenceManager
	{
		// Token: 0x06000018 RID: 24 RVA: 0x00002ADD File Offset: 0x00000CDD
		public AstroFlashSequenceManager(global::Motorola.Common.Communication.IMessageExecutor rcmpWrapper, global::Motorola.Common.Communication.CommonUtil.SessionParameter sessionParam) : base(rcmpWrapper, sessionParam)
		{
			this._bFirmwareUpdated = false;
			this.currentStep = 1.0;
			this.m_MaxTransportPacketSize = 1368;
			this.IOControllerFlsh = new global::Motorola.Common.Communication.IOControllerFlash(rcmpWrapper, this.m_MaxTransportPacketSize);
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002B1A File Offset: 0x00000D1A
		public override void OpenSession(ushort sessionID, global::Motorola.Common.Communication.CommonUtil.RadioOperation operation)
		{
			if (operation == global::Motorola.Common.Communication.CommonUtil.RadioOperation.Flash)
			{
				base.UnlockRadioPartition(0);
				base.EnterProgramMode();
			}
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002B2E File Offset: 0x00000D2E
		public override void CloseSession(ushort sessionID, global::Motorola.Common.Communication.CommonUtil.RadioOperation operation, bool pendingDeploy)
		{
			if (operation == global::Motorola.Common.Communication.CommonUtil.RadioOperation.Flash)
			{
				if (!pendingDeploy)
				{
					this.ValidateUpdate();
				}
				base.ExitProgramMode();
			}
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002B44 File Offset: 0x00000D44
		public void ValidateUpdate()
		{
			byte b = 0;
			if (this.IOControllerFlsh.RadioUpdateControl(6, ref b) != global::Motorola.Common.Communication.CommonUtil.SequenceManagerResult.Success)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.UpdateDevice_Astro_CodeplugValidationFailed);
			}
			b = 0;
			if (this._bFirmwareUpdated && this.IOControllerFlsh.RadioUpdateControl(5, ref b) != global::Motorola.Common.Communication.CommonUtil.SequenceManagerResult.Success)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.UpdateDevice_Astro_FirmwareValidationFailed);
			}
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002B94 File Offset: 0x00000D94
		public void UpdateDevice(global::Motorola.Common.Communication.Pba.PbaObject pbaObject, ushort sessionID)
		{
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(pbaObject, global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
			base.WriteValidation(pbaObject);
			global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo extendedDeviceInfo = base.ExtendedDeviceInfo;
			this.WriteDevice(pbaObject, 0, null);
			if (base.ProgressIndicator != null)
			{
				base.ProgressIndicator.SetCurrentScope(8, 64);
				base.ProgressIndicator.UpdateProgress(0.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.UpgradeRadio);
			}
			if (pbaObject.UpdateData.MemoryImages.Count <= 0)
			{
				return;
			}
			this.upgradeFile = new global::Motorola.Common.Communication.FlashportUpgradeFile(pbaObject.UpdateData.MemoryImages[0].FilePath);
			if (!this.upgradeFile.OpenUpgradeFile())
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.UpdateDevice_Astro_InvalidFlashData);
			}
			bool flag = this.ToFileStorage(pbaObject);
			if (flag)
			{
				bool eraseFlash = false;
				if (!string.IsNullOrEmpty(extendedDeviceInfo.SoftwareVersion) && extendedDeviceInfo.SoftwareVersion.Substring(1, 2) == "01")
				{
					eraseFlash = true;
				}
				this.FlashRadioFileSystem(extendedDeviceInfo, pbaObject, eraseFlash);
				return;
			}
			this.FlashRadio(extendedDeviceInfo, pbaObject);
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002C83 File Offset: 0x00000E83
		public bool WriteRamdownloader(string filepath)
		{
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.NotImplemented);
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002C8B File Offset: 0x00000E8B
		public global::Motorola.Common.Communication.Pba.UpdateDeviceData ReadImage(global::Motorola.Common.Communication.Pba.UpdateDeviceData images)
		{
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.NotImplemented);
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002C93 File Offset: 0x00000E93
		public override global::Motorola.Common.Communication.Pba.PbaObject WriteDevice(global::Motorola.Common.Communication.Pba.PbaObject writePBA, ushort sessionID, string pcrNewPassword)
		{
			if (base.ProgressIndicator != null)
			{
				base.ProgressIndicator.SetCurrentScope(0, 7);
			}
			this.WriteRadioCodeplug(writePBA, true);
			return writePBA;
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002CB4 File Offset: 0x00000EB4
		public override global::Motorola.Common.Communication.Pba.PbaObject ReadDevice(global::Motorola.Common.Communication.Pba.PbaObject referencePba, ushort sessionID)
		{
			global::Motorola.Common.Communication.CommonUtil.IshItemCollection codeplug = new global::Motorola.Common.Communication.CommonUtil.IshItemCollection();
			global::Motorola.Common.Communication.Pba.PbaObject pbaObject = new global::Motorola.Common.Communication.Pba.PbaObject();
			global::Motorola.Common.Communication.RadioParams radioParams = new global::Motorola.Common.Communication.RadioParams();
			if (base.ProgressIndicator != null)
			{
				base.ProgressIndicator.SetCurrentScope(0, 14);
				base.ProgressIndicator.UpdateProgress(0.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.ReadingCP);
			}
			codeplug = base.ReadRadioCodeplug();
			pbaObject.SetCodeplug(codeplug);
			pbaObject.CodeplugData.CPVersion = radioParams.CodeplugVersion;
			if (base.ProgressIndicator != null)
			{
				base.ProgressIndicator.UpdateProgress(1.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.ReadCPDone);
			}
			return pbaObject;
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002D48 File Offset: 0x00000F48
		private bool ToFileStorage(global::Motorola.Common.Communication.Pba.PbaObject pbaObject)
		{
			bool result = false;
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.RadioImage> memoryImages = pbaObject.UpdateData.MemoryImages;
			if (memoryImages.Any((global::Motorola.Common.Communication.Pba.RadioImage p) => p.FileType == global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.HOST))
			{
				global::Motorola.Common.Communication.Pba.AstroMemoryImage astroMemoryImage = (global::Motorola.Common.Communication.Pba.AstroMemoryImage)global::Motorola.Common.Communication.Pba.RadioImage.GetImageFromList(memoryImages, global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.HOST);
				string empty = string.Empty;
				if (string.IsNullOrEmpty(astroMemoryImage.ComponentName) || !global::System.IO.File.Exists(astroMemoryImage.FilePath))
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.UpdateDevice_Astro_InvalidFlashData);
				}
				this.upgradeFile.GetComponentData(astroMemoryImage.ComponentName, out empty);
				string text = global::Motorola.Common.Communication.Srecord.LoadSignatureFromSrecord(empty);
				if (!string.IsNullOrEmpty(text) && text.Contains("HFWS"))
				{
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002F48 File Offset: 0x00001148
		private void FlashRadioFileSystem(global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo currDeviceInfo, global::Motorola.Common.Communication.Pba.PbaObject pbaObject, bool eraseFlash)
		{
			if (pbaObject == null || currDeviceInfo == null)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
			}
			this.totalStepOperations = pbaObject.UpdateData.MemoryImages.Count<global::Motorola.Common.Communication.Pba.RadioImage>() + 2;
			this.currentStep = 1.0;
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
				if (string.IsNullOrEmpty(astroMemoryImage.ComponentName) || !global::System.IO.File.Exists(astroMemoryImage.FilePath))
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.UpdateDevice_Astro_InvalidFlashData);
				}
				this._bFirmwareUpdated = true;
				this.upgradeFile.GetComponentData(astroMemoryImage.ComponentName, out empty);
				global::Motorola.Common.Communication.CommonUtil.SequenceManagerResult sequenceManagerResult = this.IOControllerFlsh.UnlockSection("HFWA", "HFWB", (uint)activePartition);
				if (sequenceManagerResult != global::Motorola.Common.Communication.CommonUtil.SequenceManagerResult.Success)
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.UpdateDevice_Astro_UnlockPsdtFlashSectionFailed);
				}
				if (eraseFlash)
				{
					compressed = false;
				}
				this.currentStep += 1.0;
				this.IOControllerFlsh.FlashComponent(empty, compressed, this.m_MaxTransportPacketSize, delegate(double progress)
				{
					if (base.ProgressIndicator != null)
					{
						base.ProgressIndicator.UpdateProgress(progress / (double)this.totalStepOperations + this.currentStep / (double)this.totalStepOperations, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.UpgradeHost);
					}
				});
			}
			if (memoryImages.Any((global::Motorola.Common.Communication.Pba.RadioImage p) => p.FileType == global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.DSP))
			{
				bool compressed = true;
				global::Motorola.Common.Communication.Pba.AstroMemoryImage astroMemoryImage2 = (global::Motorola.Common.Communication.Pba.AstroMemoryImage)global::Motorola.Common.Communication.Pba.RadioImage.GetImageFromList(memoryImages, global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.DSP);
				string empty2 = string.Empty;
				if (string.IsNullOrEmpty(astroMemoryImage2.ComponentName))
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.UpdateDevice_Astro_InvalidFlashData);
				}
				this.upgradeFile.GetComponentData(astroMemoryImage2.ComponentName, out empty2);
				global::Motorola.Common.Communication.CommonUtil.SequenceManagerResult sequenceManagerResult = this.IOControllerFlsh.UnlockSection("DFWA", "DFWB", (uint)activePartition);
				if (sequenceManagerResult != global::Motorola.Common.Communication.CommonUtil.SequenceManagerResult.Success)
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.UpdateDevice_Astro_UnlockPsdtFlashSectionFailed);
				}
				this.currentStep += 1.0;
				this.IOControllerFlsh.FlashComponent(empty2, compressed, this.m_MaxTransportPacketSize, delegate(double progress)
				{
					if (base.ProgressIndicator != null)
					{
						base.ProgressIndicator.UpdateProgress(progress / (double)this.totalStepOperations + this.currentStep / (double)this.totalStepOperations, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.UpgradeDsp);
					}
				});
			}
			if (memoryImages.Any((global::Motorola.Common.Communication.Pba.RadioImage p) => p.FileType == global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.MACE))
			{
				bool compressed = false;
				global::Motorola.Common.Communication.Pba.AstroMemoryImage astroMemoryImage3 = (global::Motorola.Common.Communication.Pba.AstroMemoryImage)global::Motorola.Common.Communication.Pba.RadioImage.GetImageFromList(memoryImages, global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.MACE);
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
						base.ProgressIndicator.UpdateProgress(progress / (double)this.totalStepOperations + this.currentStep / (double)this.totalStepOperations, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.UpgradeMace);
					}
				});
			}
			if (memoryImages.Any((global::Motorola.Common.Communication.Pba.RadioImage p) => p.FileType == global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.OPTION))
			{
				bool compressed = false;
				global::Motorola.Common.Communication.Pba.AstroMemoryImage astroMemoryImage4 = (global::Motorola.Common.Communication.Pba.AstroMemoryImage)global::Motorola.Common.Communication.Pba.RadioImage.GetImageFromList(memoryImages, global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.OPTION);
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
						base.ProgressIndicator.UpdateProgress(progress / (double)this.totalStepOperations + this.currentStep / (double)this.totalStepOperations, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.UpgradeOptBrd);
					}
				});
			}
			if (memoryImages.Any((global::Motorola.Common.Communication.Pba.RadioImage p) => p.FileType == global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.ACCY))
			{
				bool compressed = false;
				global::Motorola.Common.Communication.Pba.AstroMemoryImage astroMemoryImage5 = (global::Motorola.Common.Communication.Pba.AstroMemoryImage)global::Motorola.Common.Communication.Pba.RadioImage.GetImageFromList(memoryImages, global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.ACCY);
				string empty5 = string.Empty;
				if (string.IsNullOrEmpty(astroMemoryImage5.ComponentName))
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.UpdateDevice_Astro_InvalidFlashData);
				}
				this.currentStep += 1.0;
				this.upgradeFile.GetComponentData(astroMemoryImage5.ComponentName, out empty5);
				this.IOControllerFlsh.FlashComponent(empty5, compressed, this.m_MaxTransportPacketSize, delegate(double progress)
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

		// Token: 0x06000023 RID: 35 RVA: 0x0000354C File Offset: 0x0000174C
		private void FlashRadio(global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo currDeviceInfo, global::Motorola.Common.Communication.Pba.PbaObject pbaObject)
		{
			if (pbaObject == null || currDeviceInfo == null)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
			}
			if (pbaObject.UpdateData.MemoryImages.Count <= 0)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.UpdateDevice_Astro_MissingFlashData);
			}
			this.totalStepOperations = pbaObject.UpdateData.MemoryImages.Count<global::Motorola.Common.Communication.Pba.RadioImage>() + 2;
			this.currentStep = 1.0;
			this.IOControllerFlsh.PollBackgroundEraser(delegate(double progress)
			{
				if (base.ProgressIndicator != null)
				{
					base.ProgressIndicator.UpdateProgress(progress / 100.0 / (double)this.totalStepOperations, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.EraseFlash);
				}
			});
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.RadioImage> memoryImages = pbaObject.UpdateData.MemoryImages;
			if (memoryImages.Any((global::Motorola.Common.Communication.Pba.RadioImage p) => p.FileType == global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.HOST))
			{
				bool flag = true;
				global::Motorola.Common.Communication.Pba.AstroMemoryImage astroMemoryImage = (global::Motorola.Common.Communication.Pba.AstroMemoryImage)global::Motorola.Common.Communication.Pba.RadioImage.GetImageFromList(memoryImages, global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.HOST);
				string empty = string.Empty;
				if (string.IsNullOrEmpty(astroMemoryImage.ComponentName) || !global::System.IO.File.Exists(astroMemoryImage.FilePath))
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.UpdateDevice_Astro_InvalidFlashData);
				}
				this.upgradeFile.GetComponentData(astroMemoryImage.ComponentName, out empty);
				string text = global::Motorola.Common.Communication.Srecord.LoadSignatureFromSrecord(empty);
				if (string.IsNullOrEmpty(text))
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.UpdateDevice_Astro_InvalidFlashData);
				}
				if (text.Contains("HFWA"))
				{
					flag = false;
				}
				if (flag)
				{
					global::Motorola.Common.Communication.CommonUtil.SequenceManagerResult sequenceManagerResult = this.IOControllerFlsh.StartDecompression();
					if (sequenceManagerResult != global::Motorola.Common.Communication.CommonUtil.SequenceManagerResult.Success)
					{
						throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.UpdateDevice_Astro_MissingUncompressedData);
					}
				}
				this._bFirmwareUpdated = true;
				this.currentStep += 1.0;
				this.IOControllerFlsh.FlashComponent(empty, flag, this.m_MaxTransportPacketSize, delegate(double progress)
				{
					if (base.ProgressIndicator != null)
					{
						base.ProgressIndicator.UpdateProgress(progress / (double)this.totalStepOperations + this.currentStep / (double)this.totalStepOperations, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.UpgradeHost);
					}
				});
			}
			if (memoryImages.Any((global::Motorola.Common.Communication.Pba.RadioImage p) => p.FileType == global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.DSP))
			{
				bool flag = true;
				global::Motorola.Common.Communication.Pba.AstroMemoryImage astroMemoryImage2 = (global::Motorola.Common.Communication.Pba.AstroMemoryImage)global::Motorola.Common.Communication.Pba.RadioImage.GetImageFromList(memoryImages, global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.DSP);
				string empty2 = string.Empty;
				if (string.IsNullOrEmpty(astroMemoryImage2.ComponentName))
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.UpdateDevice_Astro_InvalidFlashData);
				}
				this.upgradeFile.GetComponentData(astroMemoryImage2.ComponentName, out empty2);
				string text2 = global::Motorola.Common.Communication.Srecord.LoadSignatureFromSrecord(empty2);
				if (string.IsNullOrEmpty(text2))
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.UpdateDevice_Astro_InvalidFlashData);
				}
				if (text2.Contains("DFWA"))
				{
					flag = false;
				}
				if (flag)
				{
					global::Motorola.Common.Communication.CommonUtil.SequenceManagerResult sequenceManagerResult = this.IOControllerFlsh.StartDecompression();
					if (sequenceManagerResult != global::Motorola.Common.Communication.CommonUtil.SequenceManagerResult.Success)
					{
						throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.UpdateDevice_Astro_MissingUncompressedData);
					}
				}
				this.currentStep += 1.0;
				this.IOControllerFlsh.FlashComponent(empty2, flag, this.m_MaxTransportPacketSize, delegate(double progress)
				{
					if (base.ProgressIndicator != null)
					{
						base.ProgressIndicator.UpdateProgress(progress / (double)this.totalStepOperations + this.currentStep / (double)this.totalStepOperations, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.UpgradeDsp);
					}
				});
			}
			if (memoryImages.Any((global::Motorola.Common.Communication.Pba.RadioImage p) => p.FileType == global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.MACE))
			{
				global::Motorola.Common.Communication.Pba.AstroMemoryImage astroMemoryImage3 = (global::Motorola.Common.Communication.Pba.AstroMemoryImage)global::Motorola.Common.Communication.Pba.RadioImage.GetImageFromList(memoryImages, global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.MACE);
				string empty3 = string.Empty;
				if (string.IsNullOrEmpty(astroMemoryImage3.ComponentName))
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.UpdateDevice_Astro_InvalidFlashData);
				}
				this.currentStep += 1.0;
				this.upgradeFile.GetComponentData(astroMemoryImage3.ComponentName, out empty3);
				this.IOControllerFlsh.FlashComponent(empty3, false, this.m_MaxTransportPacketSize, delegate(double progress)
				{
					if (base.ProgressIndicator != null)
					{
						base.ProgressIndicator.UpdateProgress(progress / (double)this.totalStepOperations + this.currentStep / (double)this.totalStepOperations, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.UpgradeMace);
					}
				});
			}
			if (memoryImages.Any((global::Motorola.Common.Communication.Pba.RadioImage p) => p.FileType == global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.OPTION))
			{
				global::Motorola.Common.Communication.Pba.AstroMemoryImage astroMemoryImage4 = (global::Motorola.Common.Communication.Pba.AstroMemoryImage)global::Motorola.Common.Communication.Pba.RadioImage.GetImageFromList(memoryImages, global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.OPTION);
				string empty4 = string.Empty;
				if (string.IsNullOrEmpty(astroMemoryImage4.ComponentName))
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.UpdateDevice_Astro_InvalidFlashData);
				}
				this.currentStep += 1.0;
				this.upgradeFile.GetComponentData(astroMemoryImage4.ComponentName, out empty4);
				this.IOControllerFlsh.FlashComponent(empty4, false, this.m_MaxTransportPacketSize, delegate(double progress)
				{
					if (base.ProgressIndicator != null)
					{
						base.ProgressIndicator.UpdateProgress(progress / (double)this.totalStepOperations + this.currentStep / (double)this.totalStepOperations, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.UpgradeOptBrd);
					}
				});
			}
			if (memoryImages.Any((global::Motorola.Common.Communication.Pba.RadioImage p) => p.FileType == global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.ACCY))
			{
				global::Motorola.Common.Communication.Pba.AstroMemoryImage astroMemoryImage5 = (global::Motorola.Common.Communication.Pba.AstroMemoryImage)global::Motorola.Common.Communication.Pba.RadioImage.GetImageFromList(memoryImages, global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.ACCY);
				string empty5 = string.Empty;
				if (string.IsNullOrEmpty(astroMemoryImage5.ComponentName))
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.UpdateDevice_Astro_InvalidFlashData);
				}
				this.currentStep += 1.0;
				this.upgradeFile.GetComponentData(astroMemoryImage5.ComponentName, out empty5);
				this.IOControllerFlsh.FlashComponent(empty5, false, this.m_MaxTransportPacketSize, delegate(double progress)
				{
					if (base.ProgressIndicator != null)
					{
						base.ProgressIndicator.UpdateProgress(progress / (double)this.totalStepOperations + this.currentStep / (double)this.totalStepOperations, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.UpgradeAccBrd);
					}
				});
			}
			if (!memoryImages.Any((global::Motorola.Common.Communication.Pba.RadioImage p) => p.FileType == global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.PSDT))
			{
				return;
			}
			global::Motorola.Common.Communication.Pba.AstroMemoryImage astroMemoryImage6 = (global::Motorola.Common.Communication.Pba.AstroMemoryImage)global::Motorola.Common.Communication.Pba.RadioImage.GetImageFromList(memoryImages, global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.PSDT);
			string empty6 = string.Empty;
			if (!string.IsNullOrEmpty(astroMemoryImage6.ComponentName))
			{
				this.currentStep += 1.0;
				this.upgradeFile.GetComponentData(astroMemoryImage6.ComponentName, out empty6);
				this.IOControllerFlsh.FlashComponent(empty6, false, this.m_MaxTransportPacketSize, delegate(double progress)
				{
					if (base.ProgressIndicator != null)
					{
						base.ProgressIndicator.UpdateProgress(progress / (double)this.totalStepOperations + this.currentStep / (double)this.totalStepOperations, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.UpgradePsdt);
					}
				});
				return;
			}
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.UpdateDevice_Astro_InvalidFlashData);
		}

		// Token: 0x0400000D RID: 13
		private double currentStep;

		// Token: 0x0400000E RID: 14
		private int totalStepOperations;

		// Token: 0x0400000F RID: 15
		private int m_MaxTransportPacketSize;

		// Token: 0x04000010 RID: 16
		private readonly global::Motorola.Common.Communication.IOControllerFlash IOControllerFlsh;

		// Token: 0x04000011 RID: 17
		private bool _bFirmwareUpdated;

		// Token: 0x04000012 RID: 18
		private global::Motorola.Common.Communication.FlashportUpgradeFile upgradeFile;
	}
}
