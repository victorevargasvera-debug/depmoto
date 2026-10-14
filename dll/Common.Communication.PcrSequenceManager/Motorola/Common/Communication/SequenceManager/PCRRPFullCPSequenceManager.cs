using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.Pba;

namespace Motorola.Common.Communication.SequenceManager
{
	// Token: 0x02000046 RID: 70
	public class PCRRPFullCPSequenceManager : global::Motorola.Common.Communication.SequenceManager.PCRRPSequenceManager
	{
		// Token: 0x06000229 RID: 553 RVA: 0x000134F1 File Offset: 0x000116F1
		public PCRRPFullCPSequenceManager(global::Motorola.Common.Communication.SequenceManager.PCRRPRcmpMessageExecutor messageExecutor, int maxDataPayload) : base(messageExecutor, maxDataPayload)
		{
		}

		// Token: 0x0600022A RID: 554 RVA: 0x00013514 File Offset: 0x00011714
		public override global::Motorola.Common.Communication.Pba.PbaObject ReadDevice(global::Motorola.Common.Communication.Pba.PbaObject referencePba, ushort sessionID)
		{
			global::Motorola.Common.Communication.Pba.PbaObject pbaObject = new global::Motorola.Common.Communication.Pba.PbaObject();
			pbaObject = base.ReadDevice(referencePba, sessionID);
			global::Motorola.Common.Communication.Pba.UpdateDeviceData cppartitionsImage = this.GetCPPartitionsImage();
			pbaObject.UpdateData = cppartitionsImage;
			return pbaObject;
		}

		// Token: 0x0600022B RID: 555 RVA: 0x00013594 File Offset: 0x00011794
		private global::Motorola.Common.Communication.Pba.PackedRadioData SyncCodeplug(global::Motorola.Common.Communication.Pba.PbaObject writePba)
		{
			global::Motorola.Common.Communication.CommonUtil.IshItemCollection radioIshItems = new global::Motorola.Common.Communication.CommonUtil.IshItemCollection();
			base.IshHandler.ReadIshPartions(radioIshItems, base.ProductFamily.ReadPartitions.ToArray(), base.ProgressIndicator, null);
			global::Motorola.Common.Communication.CommonUtil.IshItemCollection codeplugInIshItemCollection = writePba.GetCodeplugInIshItemCollection();
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IshHeader> ishTypeIDPariSetInRadio = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IshHeader>();
			radioIshItems.Headers.ToList<global::Motorola.Common.Communication.CommonUtil.IshHeader>().ForEach(delegate(global::Motorola.Common.Communication.CommonUtil.IshHeader header)
			{
				if (header.PartitionNumber == 128)
				{
					ishTypeIDPariSetInRadio.Add(header);
				}
			});
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IshHeader> ishItemsToDelete = base.GetIshItemsToDelete(writePba, ishTypeIDPariSetInRadio);
			ishItemsToDelete.ForEach(delegate(global::Motorola.Common.Communication.CommonUtil.IshHeader s)
			{
				radioIshItems.Remove(s);
			});
			foreach (global::Motorola.Common.Communication.CommonUtil.IshHeader ishHeader in codeplugInIshItemCollection.Headers)
			{
				if (ishHeader.PartitionNumber == 128)
				{
					global::Motorola.Common.Communication.CommonUtil.IshItem item = codeplugInIshItemCollection[ishHeader];
					if (radioIshItems.ContainsHeader(ishHeader))
					{
						radioIshItems.Update(ishHeader, item);
					}
					else
					{
						radioIshItems.Add(ishHeader, item);
					}
				}
			}
			global::Motorola.Common.Communication.Pba.PackedRadioData packedRadioData = new global::Motorola.Common.Communication.Pba.PackedRadioData();
			packedRadioData.Initialize(radioIshItems);
			packedRadioData.CPVersion = base.DeviceInfoFetcher.CodeplugVersion;
			return packedRadioData;
		}

		// Token: 0x0600022C RID: 556 RVA: 0x00013714 File Offset: 0x00011914
		public override void UpdateDevice(global::Motorola.Common.Communication.Pba.PbaObject pbaObject, ushort sessionID)
		{
			base.WriteValidation(pbaObject);
			base.UpdateDevice(pbaObject, sessionID);
		}

		// Token: 0x0600022D RID: 557 RVA: 0x00013728 File Offset: 0x00011928
		public override global::Motorola.Common.Communication.Pba.PbaObject WriteDevice(global::Motorola.Common.Communication.Pba.PbaObject writePBA, ushort sessionID, string pcrNewPassword)
		{
			if (base.ProgressIndicator != null)
			{
				base.ProgressIndicator.SetCurrentScope(0, 40);
			}
			global::Motorola.Common.Communication.Pba.PackedRadioData packedRadioData = this.SyncCodeplug(writePBA);
			if (base.ProgressIndicator != null)
			{
				base.ProgressIndicator.SetCurrentScope(41, 100);
			}
			global::Motorola.Common.Communication.Pba.PbaObject pbaObject = base.WriteDevice(writePBA, sessionID, null);
			global::Motorola.Common.Communication.Pba.UpdateDeviceData cppartitionsImage = this.GetCPPartitionsImage(true, pcrNewPassword);
			pbaObject.UpdateData = cppartitionsImage;
			if (packedRadioData != null)
			{
				pbaObject.CodeplugData = packedRadioData;
			}
			return pbaObject;
		}

		// Token: 0x0600022E RID: 558 RVA: 0x000137B8 File Offset: 0x000119B8
		private global::Motorola.Common.Communication.Pba.UpdateDeviceData GetCPPartitionsImage()
		{
			return this.GetCPPartitionsImage(false, null);
		}

		// Token: 0x0600022F RID: 559 RVA: 0x000137D4 File Offset: 0x000119D4
		private global::Motorola.Common.Communication.Pba.UpdateDeviceData GetCPPartitionsImage(bool CheckNewPassword, string pcrNewPassword)
		{
			global::Motorola.Common.Communication.Pba.UpdateDeviceData updateDeviceData = new global::Motorola.Common.Communication.Pba.UpdateDeviceData();
			double num = 1.0;
			if (base.ProgressIndicator != null)
			{
				base.ProgressIndicator.UpdateProgress(0.05, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.ReadImage);
				num -= 0.05;
			}
			try
			{
				base.SwitchRemoteDeviceToRPMode(CheckNewPassword, pcrNewPassword);
				global::Motorola.Common.Communication.Pba.PcrMemoryImage item = this.CreatePcrMemoryImageObject(global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.PSDT, false);
				updateDeviceData.MemoryImages.Add(item);
				item = this.CreatePcrMemoryImageObject(global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.SEC, false);
				updateDeviceData.MemoryImages.Add(item);
				item = this.CreatePcrMemoryImageObject(global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.TUNE, false);
				updateDeviceData.MemoryImages.Add(item);
				if (base.ProgressIndicator != null)
				{
					base.ProgressIndicator.IncreaseProcess(0.25);
					num -= 0.25;
				}
				if (this.IsDualDevice)
				{
					this.BootOperations.RemoteConnect(this.rxBrickAddr);
					item = this.CreatePcrMemoryImageObject(global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.PSDT, true);
					updateDeviceData.MemoryImages.Add(item);
					item = this.CreatePcrMemoryImageObject(global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.SEC, true);
					updateDeviceData.MemoryImages.Add(item);
					item = this.CreatePcrMemoryImageObject(global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.TUNE, true);
					updateDeviceData.MemoryImages.Add(item);
					this.BootOperations.RemoteDisconnect();
				}
				if (base.ProgressIndicator != null)
				{
					base.ProgressIndicator.IncreaseProcess(0.2);
					num -= 0.2;
				}
			}
			catch (global::System.Exception)
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("RP: Issue for getting codeplug partition address.", new object[0]);
				throw;
			}
			this.ReadImage(updateDeviceData);
			if (base.ProgressIndicator != null)
			{
				base.ProgressIndicator.IncreaseProcess(0.3);
				num -= 0.3;
			}
			foreach (global::Motorola.Common.Communication.Pba.RadioImage radioImage in updateDeviceData.MemoryImages)
			{
				global::Motorola.Common.Communication.Pba.PcrMemoryImage pcrMemoryImage = (global::Motorola.Common.Communication.Pba.PcrMemoryImage)radioImage;
				global::System.IO.FileInfo fileInfo = new global::System.IO.FileInfo(pcrMemoryImage.FilePath);
				pcrMemoryImage.ImageSize = (int)fileInfo.Length;
				pcrMemoryImage.fileData = new byte[pcrMemoryImage.ImageSize];
				global::System.IO.FileStream fileStream = fileInfo.OpenRead();
				fileStream.Read(pcrMemoryImage.fileData, 0, pcrMemoryImage.ImageSize);
				fileStream.Close();
				global::System.IO.File.Delete(pcrMemoryImage.FilePath);
				pcrMemoryImage.FilePath = string.Empty;
			}
			if (base.ProgressIndicator != null)
			{
				base.ProgressIndicator.UpdateProgress(1.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.ReadImage);
			}
			return updateDeviceData;
		}

		// Token: 0x06000230 RID: 560 RVA: 0x00013AB4 File Offset: 0x00011CB4
		private global::Motorola.Common.Communication.Pba.PcrMemoryImage CreatePcrMemoryImageObject(global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType filetype, bool isRemoteBrick)
		{
			global::Motorola.Common.Communication.Pba.PcrMemoryImage pcrMemoryImage = new global::Motorola.Common.Communication.Pba.PcrMemoryImage();
			uint startAddress = 0U;
			uint endAddress = 0U;
			string tempPath = global::System.IO.Path.GetTempPath();
			if (!global::System.IO.Directory.Exists(tempPath))
			{
				global::System.IO.Directory.CreateDirectory(tempPath);
			}
			pcrMemoryImage.FileType = filetype;
			base.GetPtnStartEndAddress(global::Motorola.Common.Communication.SequenceManager.PCRRPSequenceManager.GetPartitionIDFromImage(pcrMemoryImage), ref startAddress, ref endAddress);
			pcrMemoryImage.StartAddress = (int)startAddress;
			pcrMemoryImage.EndAddress = (int)endAddress;
			pcrMemoryImage.RemoteImage = isRemoteBrick;
			pcrMemoryImage.FilePath = tempPath + global::System.Guid.NewGuid().ToString("D");
			return pcrMemoryImage;
		}

		// Token: 0x04000172 RID: 370
		private global::System.IntPtr ish = global::System.IntPtr.Zero;

		// Token: 0x04000173 RID: 371
		private global::System.IntPtr ishMemory = global::System.IntPtr.Zero;
	}
}
