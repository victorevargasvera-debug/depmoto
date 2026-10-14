using System;
using System.Collections;
using System.Collections.Generic;
using System.ServiceModel;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.Pba;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.Service
{
	// Token: 0x02000006 RID: 6
	[global::System.ServiceModel.ServiceContract(CallbackContract = typeof(global::Motorola.Common.Communication.Service.IOperationServiceEvent), SessionMode = global::System.ServiceModel.SessionMode.Required)]
	public interface IDeviceOperation
	{
		// Token: 0x0600004A RID: 74
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		bool CancelOperation(string operationId);

		// Token: 0x0600004B RID: 75
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		[global::System.ServiceModel.OperationContract(AsyncPattern = true)]
		global::System.IAsyncResult BeginOpenSession(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.CommonUtil.RadioOperation operationType, global::Motorola.Common.Communication.CommonUtil.SessionParameter sessionParameter, string operationId, global::System.AsyncCallback callback, object state);

		// Token: 0x0600004C RID: 76
		ushort EndOpenSession(global::System.IAsyncResult asyncResult);

		// Token: 0x0600004D RID: 77
		ushort OpenSession(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.CommonUtil.RadioOperation operationType, global::Motorola.Common.Communication.CommonUtil.SessionParameter sessionParameter = null);

		// Token: 0x0600004E RID: 78
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		[global::System.ServiceModel.OperationContract(AsyncPattern = true)]
		global::System.IAsyncResult BeginCloseSession(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, bool pendingDeploy, string operationId, global::System.AsyncCallback callback, object state);

		// Token: 0x0600004F RID: 79
		void EndCloseSession(global::System.IAsyncResult asyncResult);

		// Token: 0x06000050 RID: 80
		void CloseSession(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, bool pendingDeploy);

		// Token: 0x06000051 RID: 81
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		[global::System.ServiceModel.OperationContract(AsyncPattern = true)]
		global::System.IAsyncResult BeginSwitchOver(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, ushort sessionID, uint delayTime, global::Motorola.Common.Communication.CommonUtil.SwitchOverOption option, string operationId, global::System.AsyncCallback callback, object asyncState);

		// Token: 0x06000052 RID: 82
		void EndSwitchOver(global::System.IAsyncResult result);

		// Token: 0x06000053 RID: 83
		void SwitchOver(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, ushort sessionID, uint delayTime, global::Motorola.Common.Communication.CommonUtil.SwitchOverOption option);

		// Token: 0x06000054 RID: 84
		[global::System.ServiceModel.OperationContract(AsyncPattern = true)]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		global::System.IAsyncResult BeginReadDeviceInfo(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, string operationId, global::System.AsyncCallback callback, object state);

		// Token: 0x06000055 RID: 85
		global::Motorola.Common.Communication.CommonUtil.DeviceInfo EndReadDeviceInfo(global::System.IAsyncResult asyncResult);

		// Token: 0x06000056 RID: 86
		global::Motorola.Common.Communication.CommonUtil.DeviceInfo ReadDeviceInfo(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo);

		// Token: 0x06000057 RID: 87
		[global::System.ServiceModel.OperationContract(AsyncPattern = true)]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		global::System.IAsyncResult BeginQueryRadioUpdateStatus(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, string operationId, global::System.AsyncCallback callback, object state);

		// Token: 0x06000058 RID: 88
		byte EndQueryRadioUpdateStatus(global::System.IAsyncResult asyncResult);

		// Token: 0x06000059 RID: 89
		byte QueryRadioUpdateStatus(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo);

		// Token: 0x0600005A RID: 90
		[global::System.ServiceModel.OperationContract(AsyncPattern = true)]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		global::System.IAsyncResult BeginReadExtendedDeviceInfo(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, string operationId, global::System.AsyncCallback callback, object state);

		// Token: 0x0600005B RID: 91
		global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo EndReadExtendedDeviceInfo(global::System.IAsyncResult asyncResult);

		// Token: 0x0600005C RID: 92
		global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo ReadExtendedDeviceInfo(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo);

		// Token: 0x0600005D RID: 93
		[global::System.ServiceModel.OperationContract(AsyncPattern = true)]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		global::System.IAsyncResult BeginReadDevice(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.PbaObject referencePba, string operationId, global::System.AsyncCallback callback, object state);

		// Token: 0x0600005E RID: 94
		global::Motorola.Common.Communication.Pba.PbaObject EndReadDevice(global::System.IAsyncResult asyncResult);

		// Token: 0x0600005F RID: 95
		global::Motorola.Common.Communication.Pba.PbaObject ReadDevice(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.PbaObject referencePba);

		// Token: 0x06000060 RID: 96
		[global::System.ServiceModel.ServiceKnownType(typeof(global::Motorola.Common.Communication.CommonUtil.IshHeader))]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		[global::System.ServiceModel.OperationContract(AsyncPattern = true)]
		global::System.IAsyncResult BeginReadBlocks(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::System.Collections.ICollection blockList, string operationId, global::System.AsyncCallback callback, object state);

		// Token: 0x06000061 RID: 97
		global::Motorola.Common.Communication.Pba.PbaObject EndReadBlocks(global::System.IAsyncResult asyncResult);

		// Token: 0x06000062 RID: 98
		global::Motorola.Common.Communication.Pba.PbaObject ReadBlocks(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::System.Collections.ICollection blockList);

		// Token: 0x06000063 RID: 99
		[global::System.ServiceModel.OperationContract(AsyncPattern = true)]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		global::System.IAsyncResult BeginWriteDevice(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.PbaObject pbaObject, string operationId, global::System.AsyncCallback callback, object state);

		// Token: 0x06000064 RID: 100
		global::Motorola.Common.Communication.Pba.PbaObject EndWriteDevice(global::System.IAsyncResult asyncResult);

		// Token: 0x06000065 RID: 101
		global::Motorola.Common.Communication.Pba.PbaObject WriteDevice(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.PbaObject pbaObject);

		// Token: 0x06000066 RID: 102
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		[global::System.ServiceModel.OperationContract(AsyncPattern = true)]
		global::System.IAsyncResult BeginTurnOffRadio(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, string operationId, global::System.AsyncCallback callback, object state);

		// Token: 0x06000067 RID: 103
		bool EndTurnOffRadio(global::System.IAsyncResult asyncResult);

		// Token: 0x06000068 RID: 104
		bool TurnOffRadio(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo);

		// Token: 0x06000069 RID: 105
		[global::System.ServiceModel.OperationContract(AsyncPattern = true)]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		global::System.IAsyncResult BeginLLPIsAvailable(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, string operationId, global::System.AsyncCallback callback, object state);

		// Token: 0x0600006A RID: 106
		bool EndLLPIsAvailable(global::System.IAsyncResult asyncResult);

		// Token: 0x0600006B RID: 107
		bool LLPIsAvailable(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo);

		// Token: 0x0600006C RID: 108
		[global::System.ServiceModel.OperationContract(AsyncPattern = true)]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		global::System.IAsyncResult BeginSwitchRadioMode(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.CommonUtil.DeviceMode mode, string operationId, global::System.AsyncCallback callback, object state);

		// Token: 0x0600006D RID: 109
		void EndSwitchRadioMode(global::System.IAsyncResult asyncResult);

		// Token: 0x0600006E RID: 110
		void SwitchRadioMode(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.CommonUtil.DeviceMode mode);

		// Token: 0x0600006F RID: 111
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		[global::System.ServiceModel.OperationContract(AsyncPattern = true)]
		global::System.IAsyncResult BeginUpdateRadioDisplay(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, string operationId, global::System.AsyncCallback callback, object state);

		// Token: 0x06000070 RID: 112
		void EndUpdateRadioDisplay(global::System.IAsyncResult asyncResult);

		// Token: 0x06000071 RID: 113
		void UpdateRadioDisplay(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo);

		// Token: 0x06000072 RID: 114
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		[global::System.ServiceModel.OperationContract(AsyncPattern = true)]
		global::System.IAsyncResult BeginWriteSoftware(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.PbaObject pbaObject, string operationId, global::System.AsyncCallback callback, object state);

		// Token: 0x06000073 RID: 115
		void EndWriteSoftware(global::System.IAsyncResult asyncResult);

		// Token: 0x06000074 RID: 116
		void WriteSoftware(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.PbaObject pbaObject);

		// Token: 0x06000075 RID: 117
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		[global::System.ServiceModel.OperationContract(AsyncPattern = true)]
		global::System.IAsyncResult BeginReadLanguagePacksInfo(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, string operationId, global::System.AsyncCallback callback, object state);

		// Token: 0x06000076 RID: 118
		global::Motorola.Common.Communication.Pba.LanguagePackData EndReadLanguagePacksInfo(global::System.IAsyncResult asyncResult);

		// Token: 0x06000077 RID: 119
		global::Motorola.Common.Communication.Pba.LanguagePackData ReadLanguagePacksInfo(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo);

		// Token: 0x06000078 RID: 120
		[global::System.ServiceModel.OperationContract(AsyncPattern = true)]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		global::System.IAsyncResult BeginWriteLanguagePacks(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.LanguagePackData languagePackData, string operationId, global::System.AsyncCallback callback, object state);

		// Token: 0x06000079 RID: 121
		void EndWriteLanguagePacks(global::System.IAsyncResult asyncResult);

		// Token: 0x0600007A RID: 122
		void WriteLanguagePacks(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.LanguagePackData languagePackData);

		// Token: 0x0600007B RID: 123
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		[global::System.ServiceModel.OperationContract(AsyncPattern = true)]
		global::System.IAsyncResult BeginDeleteLanguagePacks(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.LanguagePackData languagePackData, string operationId, global::System.AsyncCallback callback, object state);

		// Token: 0x0600007C RID: 124
		void EndDeleteLanguagePacks(global::System.IAsyncResult asyncResult);

		// Token: 0x0600007D RID: 125
		void DeleteLanguagePacks(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.LanguagePackData languagePackData);

		// Token: 0x0600007E RID: 126
		[global::System.ServiceModel.OperationContract(AsyncPattern = true)]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		global::System.IAsyncResult BeginReadTTSLanguagePacksInfo(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, string operationId, global::System.AsyncCallback callback, object state);

		// Token: 0x0600007F RID: 127
		global::Motorola.Common.Communication.Pba.LanguagePackData EndReadTTSLanguagePacksInfo(global::System.IAsyncResult asyncResult);

		// Token: 0x06000080 RID: 128
		global::Motorola.Common.Communication.Pba.LanguagePackData ReadTTSLanguagePacksInfo(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo);

		// Token: 0x06000081 RID: 129
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		[global::System.ServiceModel.OperationContract(AsyncPattern = true)]
		global::System.IAsyncResult BeginWriteTTSLanguagePacks(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.LanguagePackData languagePackData, string operationId, global::System.AsyncCallback callback, object state);

		// Token: 0x06000082 RID: 130
		void EndWriteTTSLanguagePacks(global::System.IAsyncResult asyncResult);

		// Token: 0x06000083 RID: 131
		void WriteTTSLanguagePacks(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.LanguagePackData languagePackData);

		// Token: 0x06000084 RID: 132
		[global::System.ServiceModel.OperationContract(AsyncPattern = true)]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		global::System.IAsyncResult BeginDeleteTTSLanguagePacks(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.LanguagePackData languagePackData, string operationId, global::System.AsyncCallback callback, object state);

		// Token: 0x06000085 RID: 133
		void EndDeleteTTSLanguagePacks(global::System.IAsyncResult asyncResult);

		// Token: 0x06000086 RID: 134
		void DeleteTTSLanguagePacks(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.LanguagePackData languagePackData);

		// Token: 0x06000087 RID: 135
		[global::System.ServiceModel.OperationContract(AsyncPattern = true)]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		global::System.IAsyncResult BeginReadRadioFirmwareDefinedFlashPacks(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, string operationId, global::System.AsyncCallback callback, object state);

		// Token: 0x06000088 RID: 136
		global::Motorola.Common.Communication.Pba.LanguagePackData EndReadRadioFirmwareDefinedFlashPacks(global::System.IAsyncResult asyncResult);

		// Token: 0x06000089 RID: 137
		global::Motorola.Common.Communication.Pba.LanguagePackData ReadRadioFirmwareDefinedFlashPacks(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo);

		// Token: 0x0600008A RID: 138
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		[global::System.ServiceModel.OperationContract(AsyncPattern = true)]
		global::System.IAsyncResult BeginReadFilesListInDir(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.FileItem dir, string operationId, global::System.AsyncCallback callback, object state);

		// Token: 0x0600008B RID: 139
		global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileItem> EndReadFilesListInDir(global::System.IAsyncResult asyncResult);

		// Token: 0x0600008C RID: 140
		global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileItem> ReadFilesListInDir(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.FileItem dir);

		// Token: 0x0600008D RID: 141
		[global::System.ServiceModel.OperationContract(AsyncPattern = true)]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		global::System.IAsyncResult BeginReadFile(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.FileItem file, string operationId, global::System.AsyncCallback callback, object state);

		// Token: 0x0600008E RID: 142
		global::Motorola.Common.Communication.Pba.FileItem EndReadFile(global::System.IAsyncResult asyncResult);

		// Token: 0x0600008F RID: 143
		global::Motorola.Common.Communication.Pba.FileItem ReadFile(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.FileItem file);

		// Token: 0x06000090 RID: 144
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		[global::System.ServiceModel.OperationContract(AsyncPattern = true)]
		global::System.IAsyncResult BeginWriteFile(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.FileItem file, string operationId, global::System.AsyncCallback callback, object state);

		// Token: 0x06000091 RID: 145
		void EndWriteFile(global::System.IAsyncResult asyncResult);

		// Token: 0x06000092 RID: 146
		void WriteFile(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.FileItem file);

		// Token: 0x06000093 RID: 147
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		[global::System.ServiceModel.OperationContract(AsyncPattern = true)]
		global::System.IAsyncResult BeginDeleteFile(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.FileItem file, string operationId, global::System.AsyncCallback callback, object state);

		// Token: 0x06000094 RID: 148
		void EndDeleteFile(global::System.IAsyncResult asyncResult);

		// Token: 0x06000095 RID: 149
		void DeleteFile(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.FileItem file);

		// Token: 0x06000096 RID: 150
		[global::System.ServiceModel.OperationContract(AsyncPattern = true)]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		global::System.IAsyncResult BeginGetFileOrDirSize(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.FileItem fileOrDir, string operationId, global::System.AsyncCallback callback, object state);

		// Token: 0x06000097 RID: 151
		long EndGetFileOrDirSize(global::System.IAsyncResult asyncResult);

		// Token: 0x06000098 RID: 152
		long GetFileOrDirSize(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.FileItem fileOrDir);

		// Token: 0x06000099 RID: 153
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		[global::System.ServiceModel.OperationContract(AsyncPattern = true)]
		global::System.IAsyncResult BeginUpgradeFlashStrap(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.PbaObject pbaObject, string operationId, global::System.AsyncCallback callback, object state);

		// Token: 0x0600009A RID: 154
		void EndUpgradeFlashStrap(global::System.IAsyncResult asyncResult);

		// Token: 0x0600009B RID: 155
		void UpgradeFlashStrap(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.PbaObject pbaObject);

		// Token: 0x0600009C RID: 156
		[global::System.ServiceModel.OperationContract(AsyncPattern = true)]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		global::System.IAsyncResult BeginUpgradeFDT(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, string destModel, string destCPVersion, string serialNumber, string operationId, global::System.AsyncCallback callback, object state);

		// Token: 0x0600009D RID: 157
		void EndUpgradeFDT(global::System.IAsyncResult asyncResult);

		// Token: 0x0600009E RID: 158
		void UpgradeFDT(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, string destModel, string destCPVersion, string serialNumber);

		// Token: 0x0600009F RID: 159
		[global::System.ServiceModel.OperationContract(AsyncPattern = true)]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		global::System.IAsyncResult BeginEraseRadio(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::System.Collections.Generic.List<string> sections, string operationId, global::System.AsyncCallback callback, object state);

		// Token: 0x060000A0 RID: 160
		void EndEraseRadio(global::System.IAsyncResult asyncResult);

		// Token: 0x060000A1 RID: 161
		void EraseRadio(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::System.Collections.Generic.List<string> sections);

		// Token: 0x060000A2 RID: 162
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		[global::System.ServiceModel.OperationContract(AsyncPattern = true)]
		global::System.IAsyncResult BeginEraseRadioFromTo(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, uint startAddress, uint size, string operationId, global::System.AsyncCallback callback, object state);

		// Token: 0x060000A3 RID: 163
		void EndEraseRadioFromTo(global::System.IAsyncResult asyncResult);

		// Token: 0x060000A4 RID: 164
		void EraseRadioFromTo(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, uint startAddress, uint size);

		// Token: 0x060000A5 RID: 165
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		[global::System.ServiceModel.OperationContract(AsyncPattern = true)]
		[global::System.ServiceModel.ServiceKnownType(typeof(global::Motorola.Common.Communication.CommonUtil.FlashMemoryUnit))]
		global::System.IAsyncResult BeginWriteImage(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.CommonUtil.MemoryImage image, string operationId, global::System.AsyncCallback callback, object state);

		// Token: 0x060000A6 RID: 166
		void EndWriteImage(global::System.IAsyncResult asyncResult);

		// Token: 0x060000A7 RID: 167
		void WriteImage(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.CommonUtil.MemoryImage image);

		// Token: 0x060000A8 RID: 168
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		[global::System.ServiceModel.OperationContract(AsyncPattern = true)]
		global::System.IAsyncResult BeginReadCPData(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, string blockID, uint offset, uint size, string operationId, global::System.AsyncCallback callback, object state);

		// Token: 0x060000A9 RID: 169
		byte[] EndReadCPData(global::System.IAsyncResult asyncResult);

		// Token: 0x060000AA RID: 170
		byte[] ReadCPData(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, string blockID, uint offset, uint size);

		// Token: 0x060000AB RID: 171
		bool UpdateProgrammingStatus(global::Motorola.Common.Communication.CommonUtil.DeviceInfo devInfo, global::Motorola.Common.Communication.CommonUtil.ProgrammingStatus status, ushort sessionID);

		// Token: 0x060000AC RID: 172
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		[global::System.ServiceModel.OperationContract(AsyncPattern = true)]
		global::System.IAsyncResult BeginUpdateDevice(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.PbaObject pbaObject, string operationId, global::System.AsyncCallback callback, object state);

		// Token: 0x060000AD RID: 173
		void EndUpdateDevice(global::System.IAsyncResult asyncResult);

		// Token: 0x060000AE RID: 174
		void UpdateDevice(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.PbaObject pbaObject);

		// Token: 0x060000AF RID: 175
		[global::System.ServiceModel.OperationContract(AsyncPattern = true)]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		global::System.IAsyncResult BeginWriteRamdownloader(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, string filePath, string operationId, global::System.AsyncCallback callback, object state);

		// Token: 0x060000B0 RID: 176
		bool EndWriteRamdownloader(global::System.IAsyncResult asyncResult);

		// Token: 0x060000B1 RID: 177
		bool WriteRamdownloader(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, string filePath);

		// Token: 0x060000B2 RID: 178
		[global::System.ServiceModel.OperationContract(AsyncPattern = true)]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		global::System.IAsyncResult BeginReadImage(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.UpdateDeviceData images, string operationId, global::System.AsyncCallback callback, object state);

		// Token: 0x060000B3 RID: 179
		global::Motorola.Common.Communication.Pba.UpdateDeviceData EndReadImage(global::System.IAsyncResult asyncResult);

		// Token: 0x060000B4 RID: 180
		global::Motorola.Common.Communication.Pba.UpdateDeviceData ReadImage(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.UpdateDeviceData images);

		// Token: 0x060000B5 RID: 181
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		[global::System.ServiceModel.OperationContract(AsyncPattern = true)]
		global::System.IAsyncResult BeginForceWriteDevice(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.PbaObject pbaObject, string operationId, global::System.AsyncCallback callback, object state);

		// Token: 0x060000B6 RID: 182
		void EndForceWriteDevice(global::System.IAsyncResult asyncResult);

		// Token: 0x060000B7 RID: 183
		void ForceWriteDevice(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.PbaObject pbaObject);

		// Token: 0x060000B8 RID: 184
		[global::System.ServiceModel.OperationContract(AsyncPattern = true)]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		global::System.IAsyncResult BeginUpdateSerialNumber(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, string serialNumber, string operationId, global::System.AsyncCallback callback, object state);

		// Token: 0x060000B9 RID: 185
		void EndUpdateSerialNumber(global::System.IAsyncResult asyncResult);

		// Token: 0x060000BA RID: 186
		void UpdateSerialNumber(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, string serialNumber);

		// Token: 0x060000BB RID: 187
		[global::System.ServiceModel.OperationContract(AsyncPattern = true)]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		global::System.IAsyncResult BeginUnkillRadio(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, byte[] authenticationValue, string operationId, global::System.AsyncCallback callback, object state);

		// Token: 0x060000BC RID: 188
		void EndUnkillRadio(global::System.IAsyncResult asyncResult);

		// Token: 0x060000BD RID: 189
		void UnkillRadio(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, byte[] authenticationValue);

		// Token: 0x060000BE RID: 190
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		[global::System.ServiceModel.OperationContract(AsyncPattern = true)]
		global::System.IAsyncResult BeginReadUnkillChallengeValue(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, string operationId, global::System.AsyncCallback callback, object state);

		// Token: 0x060000BF RID: 191
		byte[] EndReadUnkillChallengeValue(global::System.IAsyncResult asyncResult);

		// Token: 0x060000C0 RID: 192
		byte[] ReadUnkillChallengeValue(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo);

		// Token: 0x060000C1 RID: 193
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		[global::System.ServiceModel.OperationContract(AsyncPattern = true)]
		global::System.IAsyncResult BeginUpdateMACAddress(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, byte[] macAddress, string operationId, global::System.AsyncCallback callback, object state);

		// Token: 0x060000C2 RID: 194
		void EndUpdateMACAddress(global::System.IAsyncResult asyncResult);

		// Token: 0x060000C3 RID: 195
		void UpdateMACAddress(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, byte[] macAddress);

		// Token: 0x060000C4 RID: 196
		[global::System.ServiceModel.OperationContract(AsyncPattern = true)]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		global::System.IAsyncResult BeginSendUpdateIMEType(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, byte ime, string operationId, global::System.AsyncCallback callback, object state);

		// Token: 0x060000C5 RID: 197
		void EndSendUpdateIMEType(global::System.IAsyncResult asyncResult);

		// Token: 0x060000C6 RID: 198
		void SendUpdateIMEType(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, byte ime);

		// Token: 0x060000C7 RID: 199
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		[global::System.ServiceModel.OperationContract(AsyncPattern = true)]
		global::System.IAsyncResult BeginSendUpdateDateCode(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, byte[] dateCode, ushort source, string operationId, global::System.AsyncCallback callback, object state);

		// Token: 0x060000C8 RID: 200
		void EndSendUpdateDateCode(global::System.IAsyncResult asyncResult);

		// Token: 0x060000C9 RID: 201
		void SendUpdateDateCode(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, byte[] dateCode, ushort source);

		// Token: 0x060000CA RID: 202
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		[global::System.ServiceModel.OperationContract(AsyncPattern = true)]
		global::System.IAsyncResult BeginCBIProgramme(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, string operationId, global::System.AsyncCallback callback, object state);

		// Token: 0x060000CB RID: 203
		void EndCBIProgramme(global::System.IAsyncResult asyncResult);

		// Token: 0x060000CC RID: 204
		void CBIProgramme(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo);

		// Token: 0x060000CD RID: 205
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		[global::System.ServiceModel.OperationContract(AsyncPattern = true)]
		global::System.IAsyncResult BeginSendFPGAErase(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType fileType, string operationId, global::System.AsyncCallback callback, object state);

		// Token: 0x060000CE RID: 206
		void EndSendFPGAErase(global::System.IAsyncResult asyncResult);

		// Token: 0x060000CF RID: 207
		void SendFPGAErase(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType fileType);

		// Token: 0x060000D0 RID: 208
		[global::System.ServiceModel.OperationContract(AsyncPattern = true)]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		global::System.IAsyncResult BeginSendFPGAReset(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType fileType, string operationId, global::System.AsyncCallback callback, object state);

		// Token: 0x060000D1 RID: 209
		void EndSendFPGAReset(global::System.IAsyncResult asyncResult);

		// Token: 0x060000D2 RID: 210
		void SendFPGAReset(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType fileType);

		// Token: 0x060000D3 RID: 211
		[global::System.ServiceModel.OperationContract(AsyncPattern = true)]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		global::System.IAsyncResult BeginValidateRemotePassword(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, string username, string password, string operationId, global::System.AsyncCallback callback, object state);

		// Token: 0x060000D4 RID: 212
		bool EndValidateRemotePassword(global::System.IAsyncResult asyncResult);

		// Token: 0x060000D5 RID: 213
		bool ValidateRemotePassword(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, string username, string password);

		// Token: 0x060000D6 RID: 214
		[global::System.ServiceModel.OperationContract(AsyncPattern = true)]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		global::System.IAsyncResult BeginValidateLocalPassword(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, string password, string operationId, global::System.AsyncCallback callback, object state);

		// Token: 0x060000D7 RID: 215
		global::Motorola.Common.Communication.CommonUtil.PasswordStatus EndValidateLocalPassword(global::System.IAsyncResult asyncResult);

		// Token: 0x060000D8 RID: 216
		global::Motorola.Common.Communication.CommonUtil.PasswordStatus ValidateLocalPassword(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, string password);

		// Token: 0x060000D9 RID: 217
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		[global::System.ServiceModel.OperationContract(AsyncPattern = true)]
		global::System.IAsyncResult BeginGetFdtInfo(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.CommonUtil.FDTType fdtType, string operationId, global::System.AsyncCallback callback, object state);

		// Token: 0x060000DA RID: 218
		global::Motorola.Common.Communication.CommonUtil.FDTInfo EndGetFdtInfo(global::System.IAsyncResult asyncResult);

		// Token: 0x060000DB RID: 219
		global::Motorola.Common.Communication.CommonUtil.FDTInfo GetFdtInfo(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.CommonUtil.FDTType fdtType);

		// Token: 0x060000DC RID: 220
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		[global::System.ServiceModel.OperationContract(AsyncPattern = true)]
		global::System.IAsyncResult BeginEnableFxFeature(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, string xmlHashInput, global::System.Collections.Generic.List<byte[]> featureCodeIds, string operationId, global::System.AsyncCallback callback, object state);

		// Token: 0x060000DD RID: 221
		void EndEnableFxFeature(global::System.IAsyncResult asyncResult);

		// Token: 0x060000DE RID: 222
		void EnableFxFeature(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, string xmlHashInput, global::System.Collections.Generic.List<byte[]> featureCodeIds);

		// Token: 0x060000DF RID: 223
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		[global::System.ServiceModel.OperationContract(AsyncPattern = true)]
		global::System.IAsyncResult BeginReadHashInputAndValidate(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.PbaObject validatePba, global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DataBlockItem> blockList, string operationId, global::System.AsyncCallback callback, object state);

		// Token: 0x060000E0 RID: 224
		string EndReadHashInputAndValidate(global::System.IAsyncResult asyncResult);

		// Token: 0x060000E1 RID: 225
		string ReadHashInputAndValidate(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.PbaObject validatePba, global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DataBlockItem> blockList);

		// Token: 0x060000E2 RID: 226
		[global::System.ServiceModel.ServiceKnownType(typeof(global::Motorola.Common.Communication.CommonUtil.FlashMemoryUnit))]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		[global::System.ServiceModel.OperationContract(AsyncPattern = true)]
		global::System.IAsyncResult BeginReadImageByAddress(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, uint startAddress, uint size, string operationId, global::System.AsyncCallback callback, object state);

		// Token: 0x060000E3 RID: 227
		global::Motorola.Common.Communication.CommonUtil.MemoryImage EndReadImageByAddress(global::System.IAsyncResult asyncResult);

		// Token: 0x060000E4 RID: 228
		global::Motorola.Common.Communication.CommonUtil.MemoryImage ReadImageByAddress(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, uint startAddress, uint size);

		// Token: 0x060000E5 RID: 229
		[global::System.ServiceModel.OperationContract(AsyncPattern = true)]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		global::System.IAsyncResult BeginGeneralOperation(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.PbaObject pbaObject, string operationId, global::System.AsyncCallback callback, object state);

		// Token: 0x060000E6 RID: 230
		void EndGeneralOperation(global::System.IAsyncResult asyncResult);

		// Token: 0x060000E7 RID: 231
		void GeneralOperation(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.PbaObject pbaObject);

		// Token: 0x060000E8 RID: 232
		[global::System.ServiceModel.OperationContract(AsyncPattern = true)]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		global::System.IAsyncResult BeginRemoveRadio(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, string operationId, global::System.AsyncCallback callback, object state);

		// Token: 0x060000E9 RID: 233
		bool EndRemoveRadio(global::System.IAsyncResult asyncResult);

		// Token: 0x060000EA RID: 234
		bool RemoveRadio(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo);
	}
}
