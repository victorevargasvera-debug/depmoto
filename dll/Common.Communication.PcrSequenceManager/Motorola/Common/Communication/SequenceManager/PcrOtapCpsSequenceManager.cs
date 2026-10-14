using System;
using System.Collections.Generic;
using System.Text;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.IshHandler;
using Motorola.Common.Communication.Pba;
using Motorola.Common.Communication.Rcmp;

namespace Motorola.Common.Communication.SequenceManager
{
	// Token: 0x02000037 RID: 55
	public class PcrOtapCpsSequenceManager : global::Motorola.Common.Communication.SequenceManager.PcrCpsSequenceManager, global::Motorola.Common.Communication.IshHandler.ICpsOtapDifferentialSequenceHelperCallback
	{
		// Token: 0x060001B3 RID: 435 RVA: 0x00010130 File Offset: 0x0000E330
		public PcrOtapCpsSequenceManager(global::Motorola.Common.Communication.IMessageExecutor messageExecutor, int maxPacketSize) : base(messageExecutor, maxPacketSize)
		{
			this.sequenceManagerHelper = new global::Motorola.Common.Communication.IshHandler.CpsOtapDifferentialSequenceHelper(base.IOController, this, global::Motorola.Common.Communication.SequenceManager.PcrConstants.OtapReadPartitions, global::Motorola.Common.Communication.SequenceManager.PcrConstants.OtapWritePartitions);
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x00010168 File Offset: 0x0000E368
		public override global::Motorola.Common.Communication.CommonUtil.DeviceInfo ReadDeviceInfo()
		{
			return this.BundleReadDeviceInfo();
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x00010180 File Offset: 0x0000E380
		public override global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo ReadExtendedDeviceInfo()
		{
			return this.BundleReadExtendedDeviceInfo();
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x00010198 File Offset: 0x0000E398
		public override global::Motorola.Common.Communication.Pba.PbaObject ReadDevice(global::Motorola.Common.Communication.Pba.PbaObject referencePba, ushort sessionID)
		{
			global::Motorola.Common.Communication.Pba.LanguagePackData deviceInfo = base.DeviceInfoFetcher.GetDeviceInfo<global::Motorola.Common.Communication.Pba.LanguagePackData>(global::Motorola.Common.Communication.SequenceManager.DeviceInfoField.LanguagePackData);
			global::Motorola.Common.Communication.Pba.LanguagePackData ttslanguagePackData = null;
			try
			{
				ttslanguagePackData = base.DeviceInfoFetcher.GetDeviceInfo<global::Motorola.Common.Communication.Pba.LanguagePackData>(global::Motorola.Common.Communication.SequenceManager.DeviceInfoField.TTSLanguagePackData);
			}
			catch (global::System.Exception)
			{
			}
			global::Motorola.Common.Communication.Pba.PbaObject pbaObject = this.sequenceManagerHelper.ReadDevice(referencePba, sessionID);
			pbaObject.LanguagePackData = deviceInfo;
			pbaObject.TTSLanguagePackData = ttslanguagePackData;
			return pbaObject;
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x00010200 File Offset: 0x0000E400
		public override global::Motorola.Common.Communication.Pba.PbaObject WriteDevice(global::Motorola.Common.Communication.Pba.PbaObject pbaObject, ushort sessionID, string pcrNewPassword)
		{
			global::Motorola.Common.Communication.Pba.PbaObject result = this.sequenceManagerHelper.WriteDevice(pbaObject, sessionID);
			base.IOController.CommitOtapSession(sessionID);
			return result;
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x00010230 File Offset: 0x0000E430
		protected global::Motorola.Common.Communication.Pba.PbaObject WriteDeviceInLegacyWay(global::Motorola.Common.Communication.Pba.PbaObject pbaObject, ushort sessionID)
		{
			return base.WriteDevice(pbaObject, sessionID, null);
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x0001024B File Offset: 0x0000E44B
		public override void OpenSession(ushort sessionID, global::Motorola.Common.Communication.CommonUtil.RadioOperation operation)
		{
			this.sequenceManagerHelper.OpenSession(sessionID, operation);
		}

		// Token: 0x060001BA RID: 442 RVA: 0x0001025C File Offset: 0x0000E45C
		public override void CloseSession(ushort sessionID, global::Motorola.Common.Communication.CommonUtil.RadioOperation operation, bool pendingDeploy)
		{
			this.DeviceInfoCache = null;
			this.sequenceManagerHelper.CloseSession(sessionID, operation, pendingDeploy);
		}

		// Token: 0x060001BB RID: 443 RVA: 0x00010278 File Offset: 0x0000E478
		public global::Motorola.Common.Communication.CommonUtil.DeviceInfo GetDeviceInfo()
		{
			return this.DeviceInfoCache.DeviceInfo;
		}

		// Token: 0x060001BC RID: 444 RVA: 0x00010298 File Offset: 0x0000E498
		public bool IsLowBattery()
		{
			return this.DeviceInfoCache.IsLowBattery;
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060001BD RID: 445 RVA: 0x000102B8 File Offset: 0x0000E4B8
		public global::Motorola.Common.Communication.IProgressIndicator Progress
		{
			get
			{
				return base.ProgressIndicator;
			}
		}

		// Token: 0x060001BE RID: 446 RVA: 0x000102D0 File Offset: 0x0000E4D0
		protected override void UpdateMaxDataTransferSize()
		{
		}

		// Token: 0x060001BF RID: 447 RVA: 0x000102D4 File Offset: 0x0000E4D4
		private global::Motorola.Common.Communication.CommonUtil.DeviceInfo BundleReadDeviceInfo()
		{
			global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo = new global::Motorola.Common.Communication.CommonUtil.DeviceInfo();
			global::System.Collections.Generic.Dictionary<string, global::Motorola.Common.Communication.RcmpBaseMessage> dictionary = new global::System.Collections.Generic.Dictionary<string, global::Motorola.Common.Communication.RcmpBaseMessage>();
			global::Motorola.Common.Communication.SequenceManager.PcrOtapCpsSequenceManager.FillBasicInfoQuery(dictionary);
			base.IOController.BundleQueryInfo(dictionary.Values);
			this.GetBasicInfo(dictionary, deviceInfo);
			base.CheckSecurityCapability(deviceInfo);
			deviceInfo.Family = base.ProductFamily.Family;
			deviceInfo.RadioState = global::Motorola.Common.Communication.CommonUtil.RadioState.Ready;
			return deviceInfo;
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x00010338 File Offset: 0x0000E538
		private global::Motorola.Common.Communication.CommonUtil.PCRDeviceInfo BundleReadExtendedDeviceInfo()
		{
			global::Motorola.Common.Communication.CommonUtil.PCRDeviceInfo pcrdeviceInfo = new global::Motorola.Common.Communication.CommonUtil.PCRDeviceInfo();
			global::System.Collections.Generic.Dictionary<string, global::Motorola.Common.Communication.RcmpBaseMessage> dictionary = new global::System.Collections.Generic.Dictionary<string, global::Motorola.Common.Communication.RcmpBaseMessage>();
			global::Motorola.Common.Communication.SequenceManager.PcrOtapCpsSequenceManager.FillBasicInfoQuery(dictionary);
			global::Motorola.Common.Communication.SequenceManager.PcrOtapCpsSequenceManager.FillExtendedInfoQuery(dictionary);
			base.IOController.BundleQueryInfo(dictionary.Values);
			pcrdeviceInfo.Family = base.ProductFamily.Family;
			this.GetBasicInfo(dictionary, pcrdeviceInfo);
			this.GetExtendedInfo(dictionary, pcrdeviceInfo);
			pcrdeviceInfo.RadioState = global::Motorola.Common.Communication.CommonUtil.RadioState.Ready;
			return pcrdeviceInfo;
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x000103A4 File Offset: 0x0000E5A4
		private static void FillBasicInfoQuery(global::System.Collections.Generic.Dictionary<string, global::Motorola.Common.Communication.RcmpBaseMessage> infoSet)
		{
			infoSet.Add("ModelNumber", new global::Motorola.Common.Communication.Rcmp.RcmpReadWriteModelNumber(0, null));
			infoSet.Add("SerialNumber", new global::Motorola.Common.Communication.Rcmp.RcmpReadWriteSerialNumber(global::Motorola.Common.Communication.Rcmp.SerialNumberOperationType.ReadRadioSerialNumber, null));
			infoSet.Add("CodeplugVersion", new global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation(global::Motorola.Common.Communication.Rcmp.VersionInfoType.CodeplugVersion));
			infoSet.Add("SoftwareVersion", new global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation(global::Motorola.Common.Communication.Rcmp.VersionInfoType.HostSoftwareVersion));
			infoSet.Add("UUID", new global::Motorola.Common.Communication.Rcmp.RcmpReadUUID());
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x00010410 File Offset: 0x0000E610
		private static void FillExtendedInfoQuery(global::System.Collections.Generic.Dictionary<string, global::Motorola.Common.Communication.RcmpBaseMessage> infoSet)
		{
			infoSet.Add("PsdtVersion", new global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation(global::Motorola.Common.Communication.Rcmp.VersionInfoType.PsdtVersion));
			infoSet.Add("Region", new global::Motorola.Common.Communication.Rcmp.XcmpCodeplugAttribute(global::Motorola.Common.Communication.Rcmp.CodeplugAttributeOperation.Read, global::Motorola.Common.Communication.Rcmp.CodeplugAttributeType.RegionalInformation, null));
			infoSet.Add("BootloaderVersion", new global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation(global::Motorola.Common.Communication.Rcmp.VersionInfoType.FlashBootAppVersion));
			infoSet.Add("L3BootloaderVersion", new global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation(global::Motorola.Common.Communication.Rcmp.VersionInfoType.L3BootloaderVersion));
			infoSet.Add("KernelVersion", new global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation(global::Motorola.Common.Communication.Rcmp.VersionInfoType.KernelVersion));
			infoSet.Add("ConfigurationVersion", new global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation(global::Motorola.Common.Communication.Rcmp.VersionInfoType.ConfigurationVersion));
			infoSet.Add("AvailableMemory", new global::Motorola.Common.Communication.Rcmp.XcmpCodeplugAttribute(global::Motorola.Common.Communication.Rcmp.CodeplugAttributeOperation.Read, global::Motorola.Common.Communication.Rcmp.CodeplugAttributeType.TotalAllowableMemory, null));
			infoSet.Add("IsLowBattery", new global::Motorola.Common.Communication.Rcmp.RcmpRadioStatus(global::Motorola.Common.Communication.Rcmp.RadioStatusCondition.LowBattery));
			infoSet.Add("PhysicalSerialNumber", new global::Motorola.Common.Communication.Rcmp.RcmpRadioStatus(global::Motorola.Common.Communication.Rcmp.RadioStatusCondition.PhysicalSerialNumber));
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x000104D8 File Offset: 0x0000E6D8
		private void GetBasicInfo(global::System.Collections.Generic.Dictionary<string, global::Motorola.Common.Communication.RcmpBaseMessage> infoSet, global::Motorola.Common.Communication.CommonUtil.DeviceInfo basic)
		{
			char[] trimChars = new char[]
			{
				'\0',
				' ',
				'\r',
				'\n'
			};
			basic.ModelNumber = ((global::Motorola.Common.Communication.Rcmp.RcmpReadWriteModelNumber)infoSet["ModelNumber"]).ModelNumber.Trim(trimChars);
			basic.SerialNumber = global::System.Text.Encoding.ASCII.GetString(((global::Motorola.Common.Communication.Rcmp.RcmpReadWriteSerialNumber)infoSet["SerialNumber"]).SerialRawBytes).TrimEnd(trimChars);
			basic.CodeplugVersion = ((global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation)infoSet["CodeplugVersion"]).VersionInformation.Trim(trimChars);
			basic.SoftwareVersion = ((global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation)infoSet["SoftwareVersion"]).VersionInformation.Trim(trimChars);
			if (this.productFamilyCache == null)
			{
				string uuid = global::System.BitConverter.ToString(((global::Motorola.Common.Communication.Rcmp.RcmpReadUUID)infoSet["UUID"]).UUID).Replace("-", string.Empty);
				this.productFamilyCache = global::Motorola.Common.Communication.SequenceManager.PcrProductFamily.GetPcrProductFamily(uuid);
			}
			if (this.deviceInfoFetcherCache == null)
			{
				this.deviceInfoFetcherCache = new global::Motorola.Common.Communication.SequenceManager.DeviceInfoFetcher(base.IOController, base.ProductFamily, basic.ModelNumber, basic.CodeplugVersion);
			}
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x00010610 File Offset: 0x0000E810
		private void GetExtendedInfo(global::System.Collections.Generic.Dictionary<string, global::Motorola.Common.Communication.RcmpBaseMessage> infoSet, global::Motorola.Common.Communication.CommonUtil.PCRDeviceInfo extended)
		{
			this.GetBasicInfo(infoSet, extended);
			extended.UUID = base.ProductFamily.UUID;
			char[] trimChars = new char[]
			{
				'\0',
				' ',
				'\r',
				'\n'
			};
			extended.PsdtVersion = ((global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation)infoSet["PsdtVersion"]).VersionInformation.Trim(trimChars);
			extended.Region = ((global::Motorola.Common.Communication.Rcmp.XcmpCodeplugAttribute)infoSet["Region"]).RegionalInformation;
			extended.BootloaderVersion = ((global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation)infoSet["BootloaderVersion"]).VersionInformation.Trim(trimChars);
			extended.L3BootloaderVersion = ((global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation)infoSet["L3BootloaderVersion"]).VersionInformation.Trim(trimChars);
			extended.KernelVersion = ((global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation)infoSet["KernelVersion"]).VersionInformation.Trim(trimChars);
			extended.ConfigurationVersion = ((global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation)infoSet["ConfigurationVersion"]).VersionInformation.Trim(trimChars);
			extended.AvailableMemory = (int)((global::Motorola.Common.Communication.Rcmp.XcmpCodeplugAttribute)infoSet["AvailableMemory"]).TotalAllowableMemory;
			global::Motorola.Common.Communication.Rcmp.RcmpRadioStatus rcmpRadioStatus = (global::Motorola.Common.Communication.Rcmp.RcmpRadioStatus)infoSet["PhysicalSerialNumber"];
			if (rcmpRadioStatus.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				extended.PhysicalSerialNumber = global::System.BitConverter.ToString(rcmpRadioStatus.Status).Replace("-", "");
			}
			this.DeviceInfoCache = new global::Motorola.Common.Communication.SequenceManager.DeviceInfoCache();
			this.DeviceInfoCache.DeviceInfo = extended;
			this.DeviceInfoCache.IsLowBattery = (infoSet["IsLowBattery"].ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success && ((global::Motorola.Common.Communication.Rcmp.RcmpRadioStatus)infoSet["IsLowBattery"]).Status[0] == 1);
			base.ReadPasswordStatus(extended);
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060001C5 RID: 453 RVA: 0x000107D0 File Offset: 0x0000E9D0
		// (set) Token: 0x060001C6 RID: 454 RVA: 0x00010801 File Offset: 0x0000EA01
		private global::Motorola.Common.Communication.SequenceManager.DeviceInfoCache DeviceInfoCache
		{
			get
			{
				if (this.deviceInfoCache == null)
				{
					this.ReadExtendedDeviceInfo();
				}
				return this.deviceInfoCache;
			}
			set
			{
				this.deviceInfoCache = value;
			}
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x0001080B File Offset: 0x0000EA0B
		public override void SwitchRadioMode(global::Motorola.Common.Communication.CommonUtil.DeviceMode mode)
		{
			base.SwitchRadioMode(mode);
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x00010816 File Offset: 0x0000EA16
		public override void SendFPGAErase(global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType fileType)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x0001081E File Offset: 0x0000EA1E
		public override void SendFPGAReset(global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType fileType)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x040000E1 RID: 225
		private global::Motorola.Common.Communication.SequenceManager.DeviceInfoCache deviceInfoCache = null;

		// Token: 0x040000E2 RID: 226
		protected global::Motorola.Common.Communication.ICpsSequenceManagerHelper sequenceManagerHelper = null;
	}
}
