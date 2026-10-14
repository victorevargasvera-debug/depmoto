using System;
using System.Collections.Generic;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.Pba;

namespace Motorola.Common.Communication
{
	// Token: 0x0200000A RID: 10
	public interface ICpsSequenceManager
	{
		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000040 RID: 64
		// (set) Token: 0x06000041 RID: 65
		global::Motorola.Common.Communication.IProgressIndicator ProgressIndicator { get; set; }

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000042 RID: 66
		// (set) Token: 0x06000043 RID: 67
		global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo ExtendedDeviceInfo { get; set; }

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000044 RID: 68
		// (set) Token: 0x06000045 RID: 69
		bool DifferentialWriteCapableRadio { get; set; }

		// Token: 0x06000046 RID: 70
		bool DifferentialWriteSupported(ushort sessionID, global::Motorola.Common.Communication.CommonUtil.RadioOperation operation);

		// Token: 0x06000047 RID: 71
		void OpenSession(ushort sessionID, global::Motorola.Common.Communication.CommonUtil.RadioOperation operation);

		// Token: 0x06000048 RID: 72
		void CloseSession(ushort sessionID, global::Motorola.Common.Communication.CommonUtil.RadioOperation operation, bool pendingDeploy);

		// Token: 0x06000049 RID: 73
		global::Motorola.Common.Communication.Pba.PbaObject ReadDevice(global::Motorola.Common.Communication.Pba.PbaObject referencePba, ushort sessionID);

		// Token: 0x0600004A RID: 74
		global::Motorola.Common.Communication.Pba.PbaObject WriteDevice(global::Motorola.Common.Communication.Pba.PbaObject pbaObject, ushort sessionID, string pcrNewPassword);

		// Token: 0x0600004B RID: 75
		global::Motorola.Common.Communication.CommonUtil.DeviceInfo ReadDeviceInfo();

		// Token: 0x0600004C RID: 76
		global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo ReadExtendedDeviceInfo();

		// Token: 0x0600004D RID: 77
		global::Motorola.Common.Communication.Pba.PbaObject ReadBlocks<T>(global::System.Collections.Generic.ICollection<T> blockList);

		// Token: 0x0600004E RID: 78
		global::Motorola.Common.Communication.Pba.LanguagePackData ReadLanguagePacksInfo();

		// Token: 0x0600004F RID: 79
		void WriteLanguagePacks(global::Motorola.Common.Communication.Pba.LanguagePackData langPackData);

		// Token: 0x06000050 RID: 80
		void DeleteLanguagePacks(global::Motorola.Common.Communication.Pba.LanguagePackData langPackData);

		// Token: 0x06000051 RID: 81
		global::Motorola.Common.Communication.Pba.LanguagePackData ReadTTSLanguagePacksInfo();

		// Token: 0x06000052 RID: 82
		void WriteTTSLanguagePacks(global::Motorola.Common.Communication.Pba.LanguagePackData langPackData);

		// Token: 0x06000053 RID: 83
		void DeleteTTSLanguagePacks(global::Motorola.Common.Communication.Pba.LanguagePackData langPackData);

		// Token: 0x06000054 RID: 84
		void SwitchRadioMode(global::Motorola.Common.Communication.CommonUtil.DeviceMode mode);

		// Token: 0x06000055 RID: 85
		void SendFPGAErase(global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType fileType);

		// Token: 0x06000056 RID: 86
		void SendFPGAReset(global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType fileType);

		// Token: 0x06000057 RID: 87
		global::Motorola.Common.Communication.CommonUtil.PasswordStatus ValidateLocalPassword(string password);

		// Token: 0x06000058 RID: 88
		void EnableFeature(string fwVersion, string serialNumber, string xmlHashInput, global::System.Collections.Generic.List<byte[]> featureCodeIDs);

		// Token: 0x06000059 RID: 89
		string ReadHashInputAndValidate(global::Motorola.Common.Communication.Pba.PbaObject validatePba, global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DataBlockItem> blockList);

		// Token: 0x0600005A RID: 90
		void UpdateMACAddress(byte[] macAddress);

		// Token: 0x0600005B RID: 91
		bool UpdateProgrammingStatus(global::Motorola.Common.Communication.CommonUtil.ProgrammingStatus status, ushort sessionID);

		// Token: 0x0600005C RID: 92
		byte QueryRadioUpdateStatus();
	}
}
