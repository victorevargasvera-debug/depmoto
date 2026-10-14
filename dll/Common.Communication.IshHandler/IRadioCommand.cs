using System;
using System.Collections.Generic;
using System.IO;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.Pba;
using Motorola.Common.Communication.Rcmp;

namespace Motorola.Common.Communication.IshHandler
{
	// Token: 0x02000009 RID: 9
	public interface IRadioCommand
	{
		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000046 RID: 70
		// (set) Token: 0x06000047 RID: 71
		int MaxDataTransferSize { get; set; }

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000048 RID: 72
		bool IsCommonFileCrcBigEndian { get; }

		// Token: 0x06000049 RID: 73
		byte[] QueryRadioSerialNumber();

		// Token: 0x0600004A RID: 74
		byte[] QueryProductSerialNumber();

		// Token: 0x0600004B RID: 75
		byte[] QueryRemoteSerialNumber();

		// Token: 0x0600004C RID: 76
		string QueryRadioModelNumber();

		// Token: 0x0600004D RID: 77
		byte[] QueryRadioUUID();

		// Token: 0x0600004E RID: 78
		byte[] QueryRadioPhysicalSerialNumber();

		// Token: 0x0600004F RID: 79
		byte QueryRadioUpdateStatus();

		// Token: 0x06000050 RID: 80
		uint QueryRadioAvailableMemory();

		// Token: 0x06000051 RID: 81
		bool IsLowBattery();

		// Token: 0x06000052 RID: 82
		bool IsDualBoard();

		// Token: 0x06000053 RID: 83
		bool Is32MPlatform();

		// Token: 0x06000054 RID: 84
		byte QueryRadioRegion();

		// Token: 0x06000055 RID: 85
		byte QueryRadioRegionByIsh(byte partition, ushort type, ushort id, ushort offset);

		// Token: 0x06000056 RID: 86
		bool UpdateProgrammingStatus(global::Motorola.Common.Communication.CommonUtil.ProgrammingStatus status, ushort sessionID);

		// Token: 0x06000057 RID: 87
		string QuerySoftwareVersion();

		// Token: 0x06000058 RID: 88
		string QueryPsdtVersion();

		// Token: 0x06000059 RID: 89
		string QueryBootloaderVersion();

		// Token: 0x0600005A RID: 90
		string QueryL3BootloaderVersion();

		// Token: 0x0600005B RID: 91
		string QueryConfigurationVersion();

		// Token: 0x0600005C RID: 92
		string QueryKernelVersion();

		// Token: 0x0600005D RID: 93
		string QuerySecurityVersion();

		// Token: 0x0600005E RID: 94
		string QueryRepeaterMacAddress();

		// Token: 0x0600005F RID: 95
		string GetWLANMacAddress(global::Motorola.Common.Communication.Rcmp.MacAddressPort port);

		// Token: 0x06000060 RID: 96
		string GetMacAddressByPort(global::Motorola.Common.Communication.Rcmp.MacAddressPort port);

		// Token: 0x06000061 RID: 97
		bool IsDspCapabilityEnabled();

		// Token: 0x06000062 RID: 98
		bool IsDTPCapabilityEnabled();

		// Token: 0x06000063 RID: 99
		global::Motorola.Common.Communication.CommonUtil.PasswordStatus QueryPasswordStatus();

		// Token: 0x06000064 RID: 100
		bool IsWirelineAvailable();

		// Token: 0x06000065 RID: 101
		global::Motorola.Common.Communication.CommonUtil.FPGAStatus QueryFPGAControllerStatus();

		// Token: 0x06000066 RID: 102
		global::Motorola.Common.Communication.CommonUtil.FPGAStatus QueryFPGAWirelineStatus();

		// Token: 0x06000067 RID: 103
		string QueryFPGAControllerAlternativeVersion();

		// Token: 0x06000068 RID: 104
		string QueryFPGAControllerFactoryVersion();

		// Token: 0x06000069 RID: 105
		string QueryFPGAControllerActiveVersion();

		// Token: 0x0600006A RID: 106
		string QueryFPGAWirelineAlternativeVersion();

		// Token: 0x0600006B RID: 107
		string QueryFPGAWirelineFactoryVersion();

		// Token: 0x0600006C RID: 108
		string QueryFPGAWirelineActiveVersion();

		// Token: 0x0600006D RID: 109
		void SendFPGAReset(global::Motorola.Common.Communication.Rcmp.FpgaOperationID fpgaID);

		// Token: 0x0600006E RID: 110
		void SendFPGAErase(global::Motorola.Common.Communication.Rcmp.FpgaOperationID fpgaID);

		// Token: 0x0600006F RID: 111
		void EnterProgramMode(byte entry, byte[] data = null);

		// Token: 0x06000070 RID: 112
		void ResetRadio();

		// Token: 0x06000071 RID: 113
		void EnterBootMode();

		// Token: 0x06000072 RID: 114
		void RadioUpdateControl(global::Motorola.Common.Communication.UpdateControlAction action);

		// Token: 0x06000073 RID: 115
		void UpdateMACAddress(byte[] macAddress);

		// Token: 0x06000074 RID: 116
		void UnlockISHPartition(byte partition);

		// Token: 0x06000075 RID: 117
		global::Motorola.Common.Communication.CommonUtil.PasswordStatus ValidateLocalPassword(string password);

		// Token: 0x06000076 RID: 118
		void BundleQueryInfo(global::System.Collections.Generic.ICollection<global::Motorola.Common.Communication.RcmpBaseMessage> rcmpMessages);

		// Token: 0x06000077 RID: 119
		global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileListItemStruct> ListDirectoryContents(ushort PartitionID, string directoryPath);

		// Token: 0x06000078 RID: 120
		long GetFileOrDirSize(ushort PartitionID, string fileOrDirectoryPath);

		// Token: 0x06000079 RID: 121
		global::System.IO.MemoryStream FileRead(ushort filePartition, string filePath, global::Motorola.Common.Communication.IProgressIndicator progressIndicator = null);

		// Token: 0x0600007A RID: 122
		void FileWrite(ushort FilePartition, string FileName, global::System.IO.Stream File, global::Motorola.Common.Communication.IProgressIndicator progressIndicator = null, bool isFileCompressed = false);

		// Token: 0x0600007B RID: 123
		void DeleteFilesOrDirectory(ushort PartitionID, global::System.Collections.Generic.List<string> filePaths);

		// Token: 0x0600007C RID: 124
		void NandWrite(ushort Partition_ID, global::System.IO.MemoryStream Data, uint OptionFlag, uint Start_ID, uint End_ID, global::Motorola.Common.Communication.IProgressIndicator progressIndicator = null);

		// Token: 0x0600007D RID: 125
		void FtlWrite(ushort Partition_ID, global::System.IO.MemoryStream Data, uint OptionFlag, uint Start_ID, uint End_ID, global::Motorola.Common.Communication.IProgressIndicator progressIndicator = null);

		// Token: 0x0600007E RID: 126
		uint GetAvailabeSpaceForLanguagePack();

		// Token: 0x0600007F RID: 127
		global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo> ReadLanguagePackInfo();

		// Token: 0x06000080 RID: 128
		global::Motorola.Common.Communication.Pba.LanguagePackData ReadLanguagePackData();

		// Token: 0x06000081 RID: 129
		void DeleteLanguagePack(string languagePackID, bool bigEndianForPackID);

		// Token: 0x06000082 RID: 130
		void WriteLanguagePack(global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo languagePack, int maxXcmpPacketSize, bool bigEndianForPackID, global::Motorola.Common.Communication.IProgressIndicator progressIndicator);

		// Token: 0x06000083 RID: 131
		global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.TTSLanguagePackInfo> ReadTTSLanguagePackInfo();

		// Token: 0x06000084 RID: 132
		global::Motorola.Common.Communication.Pba.LanguagePackData ReadTTSLanguagePackData();

		// Token: 0x06000085 RID: 133
		void DeleteTTSLanguagePack(string languagePackID, bool bigEndianForPackID);

		// Token: 0x06000086 RID: 134
		void WriteTTSLanguagePack(global::Motorola.Common.Communication.Pba.TTSLanguagePackInfo languagePack, int maxXcmpPacketSize, bool bigEndianForPackID, global::Motorola.Common.Communication.IProgressIndicator progressIndicator);

		// Token: 0x06000087 RID: 135
		void ComponentSession(ushort actions, ushort sessionID, out ushort performedActions, out ushort currentSessionId);

		// Token: 0x06000088 RID: 136
		global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.TypeLevelChangeDiscovery> TypeLevelChangeDiscoveryOfTypes(global::System.Collections.Generic.IEnumerable<ushort> ishTypes, out string radioFilePath, global::Motorola.Common.Communication.IProgressIndicator progressIndicator);

		// Token: 0x06000089 RID: 137
		global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.TypeLevelChangeDiscovery> TypeLevelChangeDiscoveryInPartitions(global::System.Collections.Generic.IEnumerable<ushort> ishPartitions, out string radioFilePath, global::Motorola.Common.Communication.IProgressIndicator progressIndicator);

		// Token: 0x0600008A RID: 138
		global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.ItemLevelChangeDiscovery> ItemLevelChangeDiscovery(global::System.Collections.Generic.IEnumerable<global::Motorola.Common.Communication.Rcmp.XcmpComponentTypeIdPair> typeIdPairs, out string radioFilePath, global::Motorola.Common.Communication.IProgressIndicator progressIndicator);

		// Token: 0x0600008B RID: 139
		global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.ItemLevelChangeDiscovery> ItemLevelChangeDiscoveryInPartitions(global::System.Collections.Generic.IEnumerable<ushort> ishPartitions, out string radioFilePath, global::Motorola.Common.Communication.IProgressIndicator progressIndicator);

		// Token: 0x0600008C RID: 140
		global::Motorola.Common.Communication.Pba.PbaObject ReadCodeplugItemsInPartitions(global::System.Collections.Generic.IEnumerable<ushort> partitions, global::Motorola.Common.Communication.IProgressIndicator progressIndicator);

		// Token: 0x0600008D RID: 141
		global::Motorola.Common.Communication.Pba.PbaObject ReadCodeplugItemsByTypes(global::System.Collections.Generic.IEnumerable<ushort> ishTypes, global::Motorola.Common.Communication.IProgressIndicator progressIndicator);

		// Token: 0x0600008E RID: 142
		global::Motorola.Common.Communication.Pba.PbaObject ReadCodeplugItems(global::System.Collections.Generic.IEnumerable<global::Motorola.Common.Communication.Rcmp.XcmpComponentTypeIdPair> items, out string radioFilePath, global::Motorola.Common.Communication.IProgressIndicator progressIndicator);

		// Token: 0x0600008F RID: 143
		global::Motorola.Common.Communication.CommonUtil.IshItemCollection ReadItemsByIshHeaders(global::System.Collections.Generic.IEnumerable<global::Motorola.Common.Communication.CommonUtil.IshHeader> ishHeaders, out string radioFilePath, global::Motorola.Common.Communication.IProgressIndicator progressIndicator = null);

		// Token: 0x06000090 RID: 144
		global::Motorola.Common.Communication.CommonUtil.IshItemCollection ReadDifferetialCodeplugInPartitions(global::System.Collections.Generic.IEnumerable<ushort> partitions, global::Motorola.Common.Communication.IProgressIndicator progressIndicator);

		// Token: 0x06000091 RID: 145
		global::Motorola.Common.Communication.CommonUtil.IshItemCollection ReadDifferetialCodeplugByIshTypes(global::System.Collections.Generic.IEnumerable<ushort> ishTypes, global::Motorola.Common.Communication.IProgressIndicator progressIndicator);

		// Token: 0x06000092 RID: 146
		bool StartOtapSession(ushort currentSessionID, ushort previousSessionID, bool isRead);

		// Token: 0x06000093 RID: 147
		void CommitOtapSession(ushort currentSessionID);

		// Token: 0x06000094 RID: 148
		void CommitWiFiSession(ushort currentSessionID);

		// Token: 0x06000095 RID: 149
		void CloseOtapSession(ushort currentSessionID, bool isNomal);

		// Token: 0x06000096 RID: 150
		void CreateArchiveSession(ushort currentSessionID);
	}
}
