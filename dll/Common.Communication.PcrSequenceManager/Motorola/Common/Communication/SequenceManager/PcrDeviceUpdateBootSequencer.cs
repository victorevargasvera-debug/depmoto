using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.Pba;
using Motorola.Common.Communication.Rcmp;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.SequenceManager
{
	// Token: 0x0200002E RID: 46
	public class PcrDeviceUpdateBootSequencer : global::Motorola.Common.Communication.SequenceManager.PcrCpsSequenceManager, global::Motorola.Common.Communication.IFlashSequenceManager
	{
		// Token: 0x06000181 RID: 385 RVA: 0x0000E664 File Offset: 0x0000C864
		public PcrDeviceUpdateBootSequencer(global::Motorola.Common.Communication.IMessageExecutor rcmpWrapper, int maxDataPayload) : base(rcmpWrapper, maxDataPayload)
		{
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(rcmpWrapper, global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
			if (maxDataPayload <= 0)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidArgument);
			}
			this.m_maxDataPayload = 9568256;
			this.BootOperations = new global::Motorola.Common.Communication.SequenceManager.PcrBootOperations(rcmpWrapper, this.m_maxDataPayload);
		}

		// Token: 0x06000182 RID: 386 RVA: 0x0000E6B8 File Offset: 0x0000C8B8
		public override void CloseSession(ushort sessionID, global::Motorola.Common.Communication.CommonUtil.RadioOperation operation, bool pendingDeploy)
		{
			if (!pendingDeploy)
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("Reset Radio on DeviceBootSequencer", new object[0]);
				base.IOController.ResetRadio();
			}
		}

		// Token: 0x06000183 RID: 387 RVA: 0x0000E6EF File Offset: 0x0000C8EF
		public void ValidateUpdate()
		{
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.NotImplemented);
		}

		// Token: 0x06000184 RID: 388 RVA: 0x0000E6F8 File Offset: 0x0000C8F8
		public virtual global::Motorola.Common.Communication.Pba.UpdateDeviceData ReadImage(global::Motorola.Common.Communication.Pba.UpdateDeviceData images)
		{
			if (images == null)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidArgument);
			}
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.RadioImage> memoryImages = images.MemoryImages;
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.RadioImage> list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.RadioImage>();
			int num = 0;
			foreach (global::Motorola.Common.Communication.Pba.RadioImage radioImage in memoryImages)
			{
				global::Motorola.Common.Communication.Pba.PcrMemoryImage pcrMemoryImage = (global::Motorola.Common.Communication.Pba.PcrMemoryImage)radioImage;
				if (pcrMemoryImage.ImageSize != 0)
				{
					pcrMemoryImage.ImageSize = pcrMemoryImage.EndAddress - pcrMemoryImage.StartAddress;
				}
				num += pcrMemoryImage.ImageSize;
			}
			int num2 = 100 / memoryImages.Count<global::Motorola.Common.Communication.Pba.RadioImage>();
			int num3 = 0;
			int num4 = num2;
			foreach (global::Motorola.Common.Communication.Pba.RadioImage radioImage2 in memoryImages)
			{
				global::Motorola.Common.Communication.Pba.PcrMemoryImage pcrMemoryImage = (global::Motorola.Common.Communication.Pba.PcrMemoryImage)radioImage2;
				if (pcrMemoryImage.FileType == global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.PSDT)
				{
					string filePath = pcrMemoryImage.FilePath;
					if (pcrMemoryImage.RemoteImage)
					{
						ushort deviceID = this.BootOperations.DiscoverRemoteDevice();
						this.BootOperations.RemoteConnect(deviceID);
					}
					if (base.ProgressIndicator != null)
					{
						base.ProgressIndicator.SetCurrentScope(num3, num4);
					}
					this.ReadPSDT(pcrMemoryImage);
					if (base.ProgressIndicator != null)
					{
						num3 += num2;
						num4 += num2;
					}
					if (pcrMemoryImage.RemoteImage)
					{
						this.BootOperations.RemoteDisconnect();
					}
				}
				else if (!pcrMemoryImage.RemoteImage)
				{
					int startAddress = pcrMemoryImage.StartAddress;
					int endAddress = pcrMemoryImage.EndAddress;
					string filePath = pcrMemoryImage.FilePath;
					if (base.ProgressIndicator != null)
					{
						base.ProgressIndicator.SetCurrentScope(num3, num4);
					}
					if (pcrMemoryImage.FileType == global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.SEC)
					{
						this.securityData = new global::Motorola.Common.Communication.SequenceManager.SecurityBootData(pcrMemoryImage);
						this.securityData.MD5CheckSum = this.ReadMemoryChecksum(null, startAddress, endAddress, filePath, base.ProgressIndicator);
					}
					else
					{
						this.ReadMemory(null, startAddress, endAddress, filePath, base.ProgressIndicator);
					}
					if (base.ProgressIndicator != null)
					{
						num3 += num2;
						num4 += num2;
					}
				}
				else
				{
					list.Add(pcrMemoryImage);
				}
			}
			if (list.Count != 0)
			{
				try
				{
					ushort deviceID = this.BootOperations.DiscoverRemoteDevice();
					this.BootOperations.RemoteConnect(deviceID);
					foreach (global::Motorola.Common.Communication.Pba.RadioImage radioImage3 in list)
					{
						global::Motorola.Common.Communication.Pba.PcrMemoryImage pcrMemoryImage2 = (global::Motorola.Common.Communication.Pba.PcrMemoryImage)radioImage3;
						int startAddress = pcrMemoryImage2.StartAddress;
						int endAddress = pcrMemoryImage2.EndAddress;
						string filePath = pcrMemoryImage2.FilePath;
						if (base.ProgressIndicator != null)
						{
							base.ProgressIndicator.SetCurrentScope(num3, num4);
						}
						this.ReadMemory(null, startAddress, endAddress, filePath, base.ProgressIndicator);
						if (base.ProgressIndicator != null)
						{
							num3 += num2;
							num4 += num2;
						}
					}
					this.BootOperations.RemoteDisconnect();
				}
				catch (global::Motorola.Common.CustomException.CommonException)
				{
					throw;
				}
			}
			if (base.ProgressIndicator != null)
			{
				base.ProgressIndicator.SetCurrentScope(0, 100);
				base.ProgressIndicator.UpdateProgress(1.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.ReadingBootDataDone);
			}
			return images;
		}

		// Token: 0x06000185 RID: 389 RVA: 0x0000EAF8 File Offset: 0x0000CCF8
		public bool WriteRamdownloader(string filepath)
		{
			if (string.IsNullOrEmpty(filepath))
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidArgument);
			}
			this.ramdownloaderFile = filepath;
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("Start to write Tx Ram Downloader.", new object[0]);
			this.BootOperations.WriteRamDownloader(this.ramdownloaderFile, null);
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("End to write Tx Ram Downloader.", new object[0]);
			ushort deviceID = 0;
			try
			{
				deviceID = this.BootOperations.DiscoverRemoteDevice();
				this.IsDualDevice = true;
			}
			catch (global::Motorola.Common.CustomException.CommonException ex)
			{
				if (ex.ErrorCode == global::Motorola.Common.CustomException.CommonErrorCode.RemoteDeviceDiscoveryFailure)
				{
					this.IsDualDevice = false;
				}
			}
			if (this.IsDualDevice)
			{
				this.BootOperations.RemoteConnect(deviceID);
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("Start to write Rx Remote Ram Downloader.", new object[0]);
				this.BootOperations.WriteRamDownloader(this.ramdownloaderFile, null);
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("End to write Rx Remote Ram Downloader.", new object[0]);
				this.BootOperations.RemoteDisconnect();
			}
			return this.IsDualDevice;
		}

		// Token: 0x06000186 RID: 390 RVA: 0x0000EC20 File Offset: 0x0000CE20
		public virtual void UpdateDevice(global::Motorola.Common.Communication.Pba.PbaObject pbaObject, ushort sessionID)
		{
			try
			{
				global::Motorola.Common.Communication.Pba.UpdateDeviceData updateData = pbaObject.UpdateData;
				if (updateData == null || updateData.MemoryImages.Count == 0 || updateData.MemoryImages == null)
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidArgument);
				}
				global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.RadioImage> memoryImages = updateData.MemoryImages;
				using (global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.RadioImage>.Enumerator enumerator = memoryImages.GetEnumerator())
				{
					if (enumerator.MoveNext())
					{
						global::Motorola.Common.Communication.Pba.PcrMemoryImage pcrMemoryImage = (global::Motorola.Common.Communication.Pba.PcrMemoryImage)enumerator.Current;
						if (pcrMemoryImage.FileType == global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.CONTROLLER_FPGA || pcrMemoryImage.FileType == global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.WIRELINE_FPGA)
						{
							this.UpgradeFPGA(pbaObject);
						}
						else
						{
							this.UpgradeFWCP(pbaObject);
						}
					}
				}
			}
			finally
			{
				global::System.GC.Collect();
			}
		}

		// Token: 0x06000187 RID: 391 RVA: 0x0000ED00 File Offset: 0x0000CF00
		protected virtual void UpgradeFWCP(global::Motorola.Common.Communication.Pba.PbaObject updateData)
		{
			global::Motorola.Common.Communication.Pba.UpdateDeviceData updateData2 = updateData.UpdateData;
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.RadioImage> memoryImages = updateData2.MemoryImages;
			global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
			global::System.Collections.Generic.List<string> list2 = new global::System.Collections.Generic.List<string>();
			global::System.Collections.Generic.List<string> list3 = new global::System.Collections.Generic.List<string>();
			global::System.Collections.Generic.List<string> list4 = new global::System.Collections.Generic.List<string>();
			global::System.Collections.ArrayList arrayList = new global::System.Collections.ArrayList();
			global::System.Collections.ArrayList arrayList2 = new global::System.Collections.ArrayList();
			global::System.Collections.ArrayList arrayList3 = new global::System.Collections.ArrayList();
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.SequenceManager.RamDataObjectInfo> list5 = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.SequenceManager.RamDataObjectInfo>();
			ushort deviceID = 0;
			int num = 0;
			global::Motorola.Common.Communication.SequenceManager.ProgressInfoObject progressInfoObject = new global::Motorola.Common.Communication.SequenceManager.ProgressInfoObject();
			progressInfoObject.percentPerOperation = 100 / memoryImages.Count<global::Motorola.Common.Communication.Pba.RadioImage>();
			foreach (global::Motorola.Common.Communication.Pba.RadioImage radioImage in memoryImages)
			{
				global::Motorola.Common.Communication.Pba.PcrMemoryImage pcrMemoryImage = (global::Motorola.Common.Communication.Pba.PcrMemoryImage)radioImage;
				if (!global::System.IO.File.Exists(pcrMemoryImage.FilePath))
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.UpdateDevice_Pcr_Missing_Update_File);
				}
				string filePath = pcrMemoryImage.FilePath;
				if (!this.IsDualDevice)
				{
					list.Add(filePath);
				}
				if (this.IsDualDevice)
				{
					if (pcrMemoryImage.FileType == global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.SEC || pcrMemoryImage.FileType == global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.TUNE || pcrMemoryImage.FileType == global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.UCL)
					{
						if (pcrMemoryImage.RemoteImage)
						{
							list3.Add(filePath);
						}
						else
						{
							list4.Add(filePath);
							num++;
						}
					}
					else
					{
						list2.Add(filePath);
					}
				}
			}
			if (this.IsDualDevice)
			{
				bool dualBrick = false;
				if (list3.Count != 0 && list4.Count != 0)
				{
					global::System.Collections.Generic.List<global::Motorola.Common.Communication.SequenceManager.RamDataObjectInfo> list6 = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.SequenceManager.RamDataObjectInfo>();
					global::System.Collections.Generic.List<global::Motorola.Common.Communication.SequenceManager.RamDataObjectInfo> collection = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.SequenceManager.RamDataObjectInfo>();
					global::System.Collections.ArrayList c = new global::System.Collections.ArrayList();
					global::System.Collections.ArrayList c2 = new global::System.Collections.ArrayList();
					global::System.Collections.ArrayList c3 = new global::System.Collections.ArrayList();
					global::System.Collections.ArrayList arrayList4 = new global::System.Collections.ArrayList();
					global::System.Collections.ArrayList arrayList5 = new global::System.Collections.ArrayList();
					global::System.Collections.ArrayList arrayList6 = new global::System.Collections.ArrayList();
					if (base.ProgressIndicator != null)
					{
						progressInfoObject.endScope += progressInfoObject.percentPerOperation * list4.Count<string>();
					}
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("Start to write Tx codeplug files(TUN, SEC, UCL).", new object[0]);
					this.BootOperations.WriteFiles(list4, ref c, ref c2, ref c3, ref collection, dualBrick, 0, progressInfoObject, base.ProgressIndicator);
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("End to write Tx codeplug files(TUN, SEC, UCL).", new object[0]);
					this.BootOperations.RemoteConnect(deviceID);
					if (base.ProgressIndicator != null)
					{
						progressInfoObject.startScope = progressInfoObject.endScope;
						progressInfoObject.endScope += progressInfoObject.percentPerOperation * list3.Count<string>();
					}
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("Start to write Rx(Remote) codeplug files(TUN, SEC, UCL).", new object[0]);
					this.BootOperations.WriteFiles(list3, ref arrayList4, ref arrayList5, ref arrayList6, ref list6, dualBrick, 0, progressInfoObject, base.ProgressIndicator);
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("End to write Rx(Remote) codeplug files(TUN, SEC, UCL).", new object[0]);
					this.BootOperations.RemoteDisconnect();
					list5.AddRange(collection);
					arrayList.AddRange(c);
					arrayList2.AddRange(c2);
					arrayList3.AddRange(c3);
				}
				if (list2.Count != 0)
				{
					global::System.Collections.ArrayList c4 = new global::System.Collections.ArrayList();
					global::System.Collections.ArrayList c5 = new global::System.Collections.ArrayList();
					global::System.Collections.ArrayList c6 = new global::System.Collections.ArrayList();
					this.BootOperations.BootDuplicateSetup();
					if (list3.Count != 0 || list4.Count != 0)
					{
						dualBrick = true;
					}
					if (base.ProgressIndicator != null)
					{
						progressInfoObject.startScope = progressInfoObject.endScope;
						progressInfoObject.endScope += progressInfoObject.percentPerOperation * list2.Count<string>();
					}
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("Start to write Common files.", new object[0]);
					this.BootOperations.WriteFiles(list2, ref c4, ref c5, ref c6, ref list5, dualBrick, num, progressInfoObject, base.ProgressIndicator);
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("End to write Common files.", new object[0]);
					arrayList.AddRange(c4);
					arrayList2.AddRange(c5);
					arrayList3.AddRange(c6);
					this.BootOperations.BootDuplicateDisable();
				}
			}
			if (!this.IsDualDevice)
			{
				global::System.Collections.Generic.List<global::Motorola.Common.Communication.SequenceManager.RamDataObjectInfo> list7 = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.SequenceManager.RamDataObjectInfo>();
				bool dualBrick = false;
				if (base.ProgressIndicator != null)
				{
					progressInfoObject.endScope += progressInfoObject.percentPerOperation * list.Count<string>();
				}
				this.BootOperations.WriteFiles(list, ref arrayList, ref arrayList2, ref arrayList3, ref list7, dualBrick, 0, progressInfoObject, base.ProgressIndicator);
			}
			if (base.ProgressIndicator != null)
			{
				base.ProgressIndicator.SetCurrentScope(0, 100);
				base.ProgressIndicator.UpdateProgress(1.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.WritingBootDataDone);
			}
			if (this.securityData != null)
			{
				string text = this.ReadGenerateChecksum(null, this.securityData.SecurityImage.StartAddress, this.securityData.SecurityImage.EndAddress, null);
				if (!string.Equals(text.ToUpper(global::System.Globalization.CultureInfo.InvariantCulture), this.securityData.MD5CheckSum.ToUpper(global::System.Globalization.CultureInfo.InvariantCulture), global::System.StringComparison.Ordinal))
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.UpdateDevice_Pcr_SecurityMatchFailure);
				}
			}
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("Boot Upgrade commint start.", new object[0]);
			uint[] ramAddressArray = global::Motorola.Common.Communication.SequenceManager.RamDataObjectInfo.ConvertToUintArray(arrayList);
			uint[] flashAddressArray = global::Motorola.Common.Communication.SequenceManager.RamDataObjectInfo.ConvertToUintArray(arrayList2);
			uint[] payloadSizeArray = global::Motorola.Common.Communication.SequenceManager.RamDataObjectInfo.ConvertToUintArray(arrayList3);
			if (!this.IsDualDevice)
			{
				this.BootOperations.BootCommit(ramAddressArray, flashAddressArray, payloadSizeArray, global::Motorola.Common.Communication.Rcmp.BootCommitFunctionType.CommitToFlash, base.ProgressIndicator);
			}
			else
			{
				this.BootOperations.BootDuplicateSetup();
				this.BootOperations.BootCommit(ramAddressArray, flashAddressArray, payloadSizeArray, global::Motorola.Common.Communication.Rcmp.BootCommitFunctionType.CommitToFlash, base.ProgressIndicator);
				this.BootOperations.BootDuplicateDisable();
			}
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("Boot Upgrade commint end.", new object[0]);
			if (base.ProgressIndicator != null)
			{
				base.ProgressIndicator.UpdateProgress(1.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.BootCommittingDone);
			}
			global::System.Threading.Thread.Sleep(2000);
		}

		// Token: 0x06000188 RID: 392 RVA: 0x0000F324 File Offset: 0x0000D524
		private void UpgradeFPGA(global::Motorola.Common.Communication.Pba.PbaObject updateData)
		{
			global::Motorola.Common.Communication.Pba.UpdateDeviceData updateData2 = updateData.UpdateData;
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.RadioImage> memoryImages = updateData2.MemoryImages;
			this.BootOperations.WriteFPGAImageFileToFlash(memoryImages, base.ProgressIndicator);
		}

		// Token: 0x06000189 RID: 393 RVA: 0x0000F354 File Offset: 0x0000D554
		protected virtual void ReadPSDT(global::Motorola.Common.Communication.Pba.PcrMemoryImage radioImage)
		{
			uint startAddress = 0U;
			uint endAddress = 0U;
			string text = "PSDX";
			try
			{
				this.GetPtnStartEndAddress(text, ref startAddress, ref endAddress);
			}
			catch (global::Motorola.Common.CustomException.CommonException ex)
			{
				if (ex.ErrorCode != global::Motorola.Common.CustomException.CommonErrorCode.FZI_FZAP_OPCODE_NOT_SUPPORTED)
				{
					throw;
				}
				startAddress = 201383936U;
				endAddress = 201392127U;
			}
			this.ReadMemory(text, (int)startAddress, (int)endAddress, radioImage.FilePath, base.ProgressIndicator);
		}

		// Token: 0x0600018A RID: 394 RVA: 0x0000F3D4 File Offset: 0x0000D5D4
		protected virtual void ReadMemory(string fileID, int startAddress, int endAddress, string filePath, global::Motorola.Common.Communication.IProgressIndicator ProgressIndicator)
		{
			this.BootOperations.ReadMemory(startAddress, endAddress, filePath, ProgressIndicator);
		}

		// Token: 0x0600018B RID: 395 RVA: 0x0000F3EC File Offset: 0x0000D5EC
		protected virtual string ReadGenerateChecksum(string fileID, int startAddress, int endAddress, global::Motorola.Common.Communication.IProgressIndicator ProgressIndicator)
		{
			return this.BootOperations.ReadGenerateChecksum(startAddress, endAddress, ProgressIndicator);
		}

		// Token: 0x0600018C RID: 396 RVA: 0x0000F410 File Offset: 0x0000D610
		protected virtual string ReadMemoryChecksum(string fileID, int startAddress, int endAddress, string filePath, global::Motorola.Common.Communication.IProgressIndicator ProgressIndicator)
		{
			return this.BootOperations.ReadMemoryChecksum(startAddress, endAddress, filePath, ProgressIndicator);
		}

		// Token: 0x0600018D RID: 397 RVA: 0x0000F434 File Offset: 0x0000D634
		protected void GetPtnStartEndAddress(string partitionName, ref uint startAddress, ref uint endAddress)
		{
			try
			{
				this.BootOperations.PsdtAccess(global::Motorola.Common.Communication.PsdtAccessAction.GetStartAddress, partitionName, null, ref startAddress);
				this.BootOperations.PsdtAccess(global::Motorola.Common.Communication.PsdtAccessAction.GetEndAddress, partitionName, null, ref endAddress);
				startAddress += 201326592U;
				endAddress += 201326592U;
			}
			catch (global::Motorola.Common.CustomException.CommonException ex)
			{
				if (ex.ErrorCode == global::Motorola.Common.CustomException.CommonErrorCode.FZI_FZAP_OPCODE_NOT_SUPPORTED)
				{
					throw;
				}
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.PartitionAddressRetrievalFailure);
			}
		}

		// Token: 0x040000B6 RID: 182
		protected int m_maxDataPayload;

		// Token: 0x040000B7 RID: 183
		protected global::Motorola.Common.Communication.SequenceManager.PcrBootOperations BootOperations;

		// Token: 0x040000B8 RID: 184
		private string ramdownloaderFile;

		// Token: 0x040000B9 RID: 185
		protected bool IsDualDevice;

		// Token: 0x040000BA RID: 186
		private global::Motorola.Common.Communication.SequenceManager.SecurityBootData securityData = null;
	}
}
