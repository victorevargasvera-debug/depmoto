using System;
using System.Collections.Generic;
using constants;
using ErrorLogging;
using Motorola.Common.Communication.CommonUtil;

namespace CommunicationController
{
	// Token: 0x0200000B RID: 11
	public interface IRadioCodeplugController
	{
		// Token: 0x06000027 RID: 39
		void EnableFeatures(string xmlHashInput, global::System.Collections.Generic.List<byte[]> FeatureCodeList, bool isLocalMode);

		// Token: 0x06000028 RID: 40
		void GetDeviceInstance(ref string instance);

		// Token: 0x06000029 RID: 41
		void AddWriteMaskField(byte[] data);

		// Token: 0x0600002A RID: 42
		uint GetSerialHandle();

		// Token: 0x0600002B RID: 43
		bool IsOpen();

		// Token: 0x0600002C RID: 44
		void SetPBar(global::constants.CCPTags.SetProgressBar pfSetProgressBar);

		// Token: 0x0600002D RID: 45
		void Open(global::CommunicationController.ISerialTransportController pSerialTransport, uint uiHandleToSerial, global::ErrorLogging.ILogApplicationError objLogAppErr, uint uiTargetDevice, bool isRemoteConnection, global::constants.CCPTags.SetProgressBar pfSetProgressBar);

		// Token: 0x0600002E RID: 46
		void Close();

		// Token: 0x0600002F RID: 47
		T IoControl<T>(string strCommand);

		// Token: 0x06000030 RID: 48
		void RefreshRadioCodeplug();

		// Token: 0x06000031 RID: 49
		void ReadPartition(byte btRegion, ref byte[] alDataList, ref uint pbarUpdates);

		// Token: 0x06000032 RID: 50
		void PSDTAccessCopy(byte region);

		// Token: 0x06000033 RID: 51
		void WritePartition(byte btRegion, ref byte[] alDataList, ref uint pbarUpdates);

		// Token: 0x06000034 RID: 52
		bool IsEmeraldBlockExists();

		// Token: 0x06000035 RID: 53
		void ReadISHType(byte btRegion, ushort usTypeID, ref byte[] alDataList);

		// Token: 0x06000036 RID: 54
		void ReadISHTypeIDPairSet(byte btRegion, ref byte[] alDataList);

		// Token: 0x06000037 RID: 55
		void WriteISHType(byte btRegion, ushort usTypeID, ref byte[] alDataList);

		// Token: 0x06000038 RID: 56
		void DeleteISHIDSet(byte partition, global::System.Collections.Generic.List<ushort> deletableTypeList, global::System.Collections.Generic.List<ushort> idDeletableTypeList);

		// Token: 0x06000039 RID: 57
		void ReadISHID(byte btRegion, ushort usTypeID, ushort usItemID, ref byte[] alDataList);

		// Token: 0x0600003A RID: 58
		void GetRadioLanguagePackInfo(ref byte[] alLangPackInfo);

		// Token: 0x0600003B RID: 59
		void GetRadioAvailMemorySize(string strCommand, ref byte[] alAvailMemorySize);

		// Token: 0x0600003C RID: 60
		void AddLanguagePack(ref byte[] alLangPack, ref uint pbarUpdates);

		// Token: 0x0600003D RID: 61
		void DeleteLanguagePack(ref byte[] alLangPackIDs, ref uint pbarUpdates);

		// Token: 0x0600003E RID: 62
		void GetRadioTTSLanguagePackInfo(out global::CommunicationController.TTSPacks langPackInfo);

		// Token: 0x0600003F RID: 63
		void AddTTSLanguagePack(global::CommunicationController.SingleTTSPack pack);

		// Token: 0x06000040 RID: 64
		void DeleteTTSLanguagePack();

		// Token: 0x06000041 RID: 65
		void UpdateRadioSerialNumber(string newSerialNumber, uint uiTargetSN);

		// Token: 0x06000042 RID: 66
		void UnkillRadio(byte[] strValue);

		// Token: 0x06000043 RID: 67
		byte[] ReadUnkillChallengeValue();

		// Token: 0x06000044 RID: 68
		void UpdateRadioMACAddress(byte[] newMacAddress, uint uiTargetMAC);

		// Token: 0x06000045 RID: 69
		void SendUpdateIMEType(byte ime);

		// Token: 0x06000046 RID: 70
		void SendEnterFZMode();

		// Token: 0x06000047 RID: 71
		void XNLIsDualBoard(ref bool bISDualBoard);

		// Token: 0x06000048 RID: 72
		long GetFileOrDirSize(ushort partitionID, byte[] pathBuffer);

		// Token: 0x06000049 RID: 73
		void UploadFile(ushort partitionID, byte[] filePathBuffer, byte[] fileContentBuffer);

		// Token: 0x0600004A RID: 74
		byte[] DownloadFile(ushort partitionID, byte[] filePathBuffer);

		// Token: 0x0600004B RID: 75
		void DeleteFile(ushort partitionID, byte[] filePathBuffer);

		// Token: 0x0600004C RID: 76
		global::System.Collections.Generic.Dictionary<string, uint> GetFilesListInDir(ushort partitionID, byte[] dirPathBuffer);

		// Token: 0x0600004D RID: 77
		void SendCommitUpdate();

		// Token: 0x0600004E RID: 78
		void SendUpdateControl(uint action, uint type);

		// Token: 0x0600004F RID: 79
		void getIsRemote(ref bool isRemote);

		// Token: 0x06000050 RID: 80
		void SendISHProgramMode(byte action);

		// Token: 0x06000051 RID: 81
		void SendRadioEnterProgramMode();

		// Token: 0x06000052 RID: 82
		void SendRadioExitProgramMode();

		// Token: 0x06000053 RID: 83
		void SendFPGAErase(string fpgaID);

		// Token: 0x06000054 RID: 84
		void SendFPGAReset(string fpgaID);

		// Token: 0x06000055 RID: 85
		void WriteCommit();

		// Token: 0x06000056 RID: 86
		global::Motorola.Common.Communication.CommonUtil.PasswordStatus ValidateLocalPassword(string password);

		// Token: 0x06000057 RID: 87
		void UpdateDateCode(ref byte[] dataArray, ushort source);

		// Token: 0x06000058 RID: 88
		void UpdateDateCode(global::System.DateTime dateTime, ushort source);

		// Token: 0x06000059 RID: 89
		void OpenProgrammingSession();
	}
}
