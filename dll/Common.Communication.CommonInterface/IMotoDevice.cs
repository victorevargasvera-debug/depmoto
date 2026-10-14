using System;
using System.Collections.Generic;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.Pba;

namespace Motorola.Common.Communication
{
	// Token: 0x0200000E RID: 14
	public interface IMotoDevice : global::Motorola.Common.Communication.CommonUtil.IObservable
	{
		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600006E RID: 110
		// (set) Token: 0x0600006F RID: 111
		global::Motorola.Common.Communication.CommonUtil.DeviceInfo DeviceInfo { get; set; }

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000070 RID: 112
		// (set) Token: 0x06000071 RID: 113
		global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo ExtendedDeviceInfo { get; set; }

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000072 RID: 114
		// (set) Token: 0x06000073 RID: 115
		bool DifferentialWriteCapableRadio { get; set; }

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000074 RID: 116
		// (set) Token: 0x06000075 RID: 117
		bool Active { get; set; }

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000076 RID: 118
		// (set) Token: 0x06000077 RID: 119
		global::Motorola.Common.Communication.CommonUtil.RadioState radioState { get; set; }

		// Token: 0x06000078 RID: 120
		ushort OpenSession(global::Motorola.Common.Communication.CommonUtil.RadioOperation operationType, global::Motorola.Common.Communication.CommonUtil.SessionParameter sessionParameter);

		// Token: 0x06000079 RID: 121
		void CloseSession(bool pendingDeploy);

		// Token: 0x0600007A RID: 122
		void FreeDeviceStatuse(bool closeConnectWithError);

		// Token: 0x0600007B RID: 123
		void Prefetch();

		// Token: 0x0600007C RID: 124
		bool WaitForReady(int timeout);

		// Token: 0x0600007D RID: 125
		void Init(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.CommonUtil.RadioOperation operation, global::Motorola.Common.Communication.IProgressIndicator progressIndicator);

		// Token: 0x0600007E RID: 126
		global::Motorola.Common.Communication.CommonUtil.DeviceInfo ReadDeviceInfo();

		// Token: 0x0600007F RID: 127
		bool UpdateProgrammingStatus(global::Motorola.Common.Communication.CommonUtil.ProgrammingStatus status, ushort sessionID);

		// Token: 0x06000080 RID: 128
		global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo ReadExtendedDeviceInfo();

		// Token: 0x06000081 RID: 129
		global::Motorola.Common.Communication.Pba.PbaObject ReadDevice(global::Motorola.Common.Communication.Pba.PbaObject referencePba);

		// Token: 0x06000082 RID: 130
		global::Motorola.Common.Communication.Pba.PbaObject ReadBlocks<T>(global::System.Collections.Generic.ICollection<T> blockList);

		// Token: 0x06000083 RID: 131
		global::Motorola.Common.Communication.Pba.PbaObject WriteDevice(global::Motorola.Common.Communication.Pba.PbaObject writePBA, string pcrNewPassword);

		// Token: 0x06000084 RID: 132
		void ForceWriteDevice(global::Motorola.Common.Communication.Pba.PbaObject writePBA);

		// Token: 0x06000085 RID: 133
		void UpdateSerialNumber(string serialNumber);

		// Token: 0x06000086 RID: 134
		byte[] ReadUnkillChallengeValue();

		// Token: 0x06000087 RID: 135
		void UnkillRadio(byte[] authenticationValue);

		// Token: 0x06000088 RID: 136
		void SendUpdateIMEType(byte ime);

		// Token: 0x06000089 RID: 137
		void SendUpdateDateCode(byte[] datecode, ushort source);

		// Token: 0x0600008A RID: 138
		void CBIProgramme();

		// Token: 0x0600008B RID: 139
		void DeviceControl(global::Motorola.Common.Communication.CommonUtil.DeviceControlInputParams inputParams, ref global::Motorola.Common.Communication.CommonUtil.DeviceControlOutputParams outputParams);

		// Token: 0x0600008C RID: 140
		void InitDeviceParams();

		// Token: 0x0600008D RID: 141
		global::Motorola.Common.Communication.Pba.LanguagePackData ReadLanguagePacksInfo();

		// Token: 0x0600008E RID: 142
		global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileItem> ReadFilesListInDir(global::Motorola.Common.Communication.Pba.FileItem dir);

		// Token: 0x0600008F RID: 143
		global::Motorola.Common.Communication.Pba.FileItem ReadFile(global::Motorola.Common.Communication.Pba.FileItem file);

		// Token: 0x06000090 RID: 144
		void WriteFile(global::Motorola.Common.Communication.Pba.FileItem file);

		// Token: 0x06000091 RID: 145
		void DeleteFile(global::Motorola.Common.Communication.Pba.FileItem file);

		// Token: 0x06000092 RID: 146
		long GetFileOrDirSize(global::Motorola.Common.Communication.Pba.FileItem fileOrDir);

		// Token: 0x06000093 RID: 147
		void WriteLanguagePacks(global::Motorola.Common.Communication.Pba.LanguagePackData languagePackData);

		// Token: 0x06000094 RID: 148
		void DeleteLanguagePacks(global::Motorola.Common.Communication.Pba.LanguagePackData languagePackData);

		// Token: 0x06000095 RID: 149
		global::Motorola.Common.Communication.Pba.LanguagePackData ReadTTSLanguagePacksInfo();

		// Token: 0x06000096 RID: 150
		void WriteTTSLanguagePacks(global::Motorola.Common.Communication.Pba.LanguagePackData languagePackData);

		// Token: 0x06000097 RID: 151
		void DeleteTTSLanguagePacks(global::Motorola.Common.Communication.Pba.LanguagePackData languagePackData);

		// Token: 0x06000098 RID: 152
		void UpgradeFlashStrap(global::Motorola.Common.Communication.Pba.PbaObject pbaObject);

		// Token: 0x06000099 RID: 153
		void EraseRadio(global::System.Collections.Generic.List<string> sections);

		// Token: 0x0600009A RID: 154
		void EraseRadioFromTo(uint startAddress, uint size);

		// Token: 0x0600009B RID: 155
		void UpgradeFDT(string destModel, string destCPVersion, string serialNumber);

		// Token: 0x0600009C RID: 156
		global::Motorola.Common.Communication.Pba.UpdateDeviceData ReadImage(global::Motorola.Common.Communication.Pba.UpdateDeviceData updateData);

		// Token: 0x0600009D RID: 157
		global::Motorola.Common.Communication.CommonUtil.MemoryImage ReadImageByAddress(uint startAddress, uint size);

		// Token: 0x0600009E RID: 158
		void WriteImage(global::Motorola.Common.Communication.CommonUtil.MemoryImage image);

		// Token: 0x0600009F RID: 159
		void SwitchRadioMode(global::Motorola.Common.Communication.CommonUtil.DeviceMode mode);

		// Token: 0x060000A0 RID: 160
		void UpdateRadioDisplay();

		// Token: 0x060000A1 RID: 161
		void UpdateDevice(global::Motorola.Common.Communication.Pba.PbaObject updatePBA);

		// Token: 0x060000A2 RID: 162
		bool WriteRamdownloader(string filePath);

		// Token: 0x060000A3 RID: 163
		void SendFPGAErase(global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType fileType);

		// Token: 0x060000A4 RID: 164
		void SendFPGAReset(global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType fileType);

		// Token: 0x060000A5 RID: 165
		global::Motorola.Common.Communication.CommonUtil.FDTInfo GetFdtInfo(global::Motorola.Common.Communication.CommonUtil.FDTType fdtType);

		// Token: 0x060000A6 RID: 166
		void EnableFeature(string fwVersion, string serialNumber, string xmlHashInput, global::System.Collections.Generic.List<byte[]> featureCodeIDs);

		// Token: 0x060000A7 RID: 167
		string ReadHashInputAndValidate(global::Motorola.Common.Communication.Pba.PbaObject pbaObject, global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DataBlockItem> blockList);

		// Token: 0x060000A8 RID: 168
		void WaitForCancelReading();

		// Token: 0x060000A9 RID: 169
		global::Motorola.Common.Communication.CommonUtil.PasswordStatus ValidateLocalPassword(string password);

		// Token: 0x060000AA RID: 170
		void UpdateMACAddress(byte[] macAddress);

		// Token: 0x060000AB RID: 171
		void SynPrepareDevice();

		// Token: 0x060000AC RID: 172
		byte QueryRadioUpdateStatus();
	}
}
