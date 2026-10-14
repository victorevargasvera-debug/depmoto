using System;
using System.Runtime.Serialization;

namespace Motorola.Common.CustomException
{
	// Token: 0x02000005 RID: 5
	[global::System.Runtime.Serialization.DataContract]
	public enum CommonErrorCode
	{
		// Token: 0x04000006 RID: 6
		[global::System.Runtime.Serialization.EnumMember]
		None,
		// Token: 0x04000007 RID: 7
		[global::System.Runtime.Serialization.EnumMember]
		GenericError,
		// Token: 0x04000008 RID: 8
		[global::System.Runtime.Serialization.EnumMember]
		ArgumentNull,
		// Token: 0x04000009 RID: 9
		[global::System.Runtime.Serialization.EnumMember]
		ArgumentOutOfRange,
		// Token: 0x0400000A RID: 10
		[global::System.Runtime.Serialization.EnumMember]
		InvalidArgument,
		// Token: 0x0400000B RID: 11
		[global::System.Runtime.Serialization.EnumMember]
		InvalidArgumentType,
		// Token: 0x0400000C RID: 12
		[global::System.Runtime.Serialization.EnumMember]
		InvalidProperty,
		// Token: 0x0400000D RID: 13
		[global::System.Runtime.Serialization.EnumMember]
		InvalidIPAddress,
		// Token: 0x0400000E RID: 14
		[global::System.Runtime.Serialization.EnumMember]
		NotImplemented,
		// Token: 0x0400000F RID: 15
		[global::System.Runtime.Serialization.EnumMember]
		AmbiguousMatch,
		// Token: 0x04000010 RID: 16
		[global::System.Runtime.Serialization.EnumMember]
		MethodNotFound,
		// Token: 0x04000011 RID: 17
		[global::System.Runtime.Serialization.EnumMember]
		ObjectDisposed,
		// Token: 0x04000012 RID: 18
		[global::System.Runtime.Serialization.EnumMember]
		KeyNotFoundException,
		// Token: 0x04000013 RID: 19
		[global::System.Runtime.Serialization.EnumMember]
		OperationIsCancelled,
		// Token: 0x04000014 RID: 20
		[global::System.Runtime.Serialization.EnumMember]
		FileIOAccessError,
		// Token: 0x04000015 RID: 21
		[global::System.Runtime.Serialization.EnumMember]
		CommunicationServiceNotAvailabe = 50,
		// Token: 0x04000016 RID: 22
		[global::System.Runtime.Serialization.EnumMember]
		CommunicationServiceTimeout,
		// Token: 0x04000017 RID: 23
		[global::System.Runtime.Serialization.EnumMember]
		CommunicationServiceCommunicationError,
		// Token: 0x04000018 RID: 24
		[global::System.Runtime.Serialization.EnumMember]
		CommunicationServiceDeviceDiscoveryParametersMismatched,
		// Token: 0x04000019 RID: 25
		[global::System.Runtime.Serialization.EnumMember]
		CommunicationServiceNotAllowedGetDiscoveryServiceTwice,
		// Token: 0x0400001A RID: 26
		[global::System.Runtime.Serialization.EnumMember]
		InsufficientMessageBuffer = 100,
		// Token: 0x0400001B RID: 27
		[global::System.Runtime.Serialization.EnumMember]
		InvalidRcmpReplySize,
		// Token: 0x0400001C RID: 28
		[global::System.Runtime.Serialization.EnumMember]
		InvalidReplyOpcode,
		// Token: 0x0400001D RID: 29
		[global::System.Runtime.Serialization.EnumMember]
		UnexpectedRequestOpcode,
		// Token: 0x0400001E RID: 30
		[global::System.Runtime.Serialization.EnumMember]
		UnexpectedEndOfMsg,
		// Token: 0x0400001F RID: 31
		[global::System.Runtime.Serialization.EnumMember]
		BuildRcmpFail,
		// Token: 0x04000020 RID: 32
		[global::System.Runtime.Serialization.EnumMember]
		SuperBundleNotSupported,
		// Token: 0x04000021 RID: 33
		[global::System.Runtime.Serialization.EnumMember]
		MessageCRC16CalculateOverflow,
		// Token: 0x04000022 RID: 34
		[global::System.Runtime.Serialization.EnumMember]
		InvalidRcmpBroadcastMsgSize,
		// Token: 0x04000023 RID: 35
		[global::System.Runtime.Serialization.EnumMember]
		InvalidRCMPParameter,
		// Token: 0x04000024 RID: 36
		[global::System.Runtime.Serialization.EnumMember]
		OpcodeNotSupported,
		// Token: 0x04000025 RID: 37
		[global::System.Runtime.Serialization.EnumMember]
		CCCSbepBuildBufferFail = 150,
		// Token: 0x04000026 RID: 38
		[global::System.Runtime.Serialization.EnumMember]
		CCCSbepDecodeReplyMsgOpcodeFail,
		// Token: 0x04000027 RID: 39
		[global::System.Runtime.Serialization.EnumMember]
		CCCSbepDecodeReplyMsgBodyFail,
		// Token: 0x04000028 RID: 40
		[global::System.Runtime.Serialization.EnumMember]
		CommunicationXnlNotInitialized = 200,
		// Token: 0x04000029 RID: 41
		[global::System.Runtime.Serialization.EnumMember]
		CommunicationXnlOSFailure,
		// Token: 0x0400002A RID: 42
		[global::System.Runtime.Serialization.EnumMember]
		CommunicationXnlReceiveMessageFailure,
		// Token: 0x0400002B RID: 43
		[global::Motorola.Common.CustomException.ErrorCodeAttributes(Retriable = true)]
		[global::System.Runtime.Serialization.EnumMember]
		CommunicationXnlReceiveMessageTimeout,
		// Token: 0x0400002C RID: 44
		[global::System.Runtime.Serialization.EnumMember]
		[global::Motorola.Common.CustomException.ErrorCodeAttributes(Retriable = true)]
		CommunicationDataMessageAckTimeout,
		// Token: 0x0400002D RID: 45
		[global::System.Runtime.Serialization.EnumMember]
		CommunicationXnlInvalidTransactionID,
		// Token: 0x0400002E RID: 46
		[global::Motorola.Common.CustomException.ErrorCodeAttributes(Retriable = true)]
		[global::System.Runtime.Serialization.EnumMember]
		CommunicationXnlConnectFailure,
		// Token: 0x0400002F RID: 47
		[global::System.Runtime.Serialization.EnumMember]
		CommunicationXnlAlreadyConnected,
		// Token: 0x04000030 RID: 48
		[global::System.Runtime.Serialization.EnumMember]
		CommunicationXnlNotConnected,
		// Token: 0x04000031 RID: 49
		[global::System.Runtime.Serialization.EnumMember]
		CommunicationXnlNotDualBoard,
		// Token: 0x04000032 RID: 50
		[global::System.Runtime.Serialization.EnumMember]
		CommunicationXnlInvalidArgument,
		// Token: 0x04000033 RID: 51
		[global::System.Runtime.Serialization.EnumMember]
		CommunicationXnlGenericFailure,
		// Token: 0x04000034 RID: 52
		[global::System.Runtime.Serialization.EnumMember]
		CommunicationXnlConnectionAbort,
		// Token: 0x04000035 RID: 53
		[global::System.Runtime.Serialization.EnumMember]
		[global::Motorola.Common.CustomException.ErrorCodeAttributes(Retriable = true)]
		CommunicationXnlNoMasterBroadcast,
		// Token: 0x04000036 RID: 54
		[global::Motorola.Common.CustomException.ErrorCodeAttributes(Retriable = true)]
		[global::System.Runtime.Serialization.EnumMember]
		CommunicationXnlAuthenticationRequestFailure,
		// Token: 0x04000037 RID: 55
		[global::System.Runtime.Serialization.EnumMember]
		[global::Motorola.Common.CustomException.ErrorCodeAttributes(Retriable = true)]
		CommunicationXnlConnectionRequestFailure,
		// Token: 0x04000038 RID: 56
		[global::Motorola.Common.CustomException.ErrorCodeAttributes(Retriable = true)]
		[global::System.Runtime.Serialization.EnumMember]
		CommunicationXnlConnectionInitFailure,
		// Token: 0x04000039 RID: 57
		[global::System.Runtime.Serialization.EnumMember]
		CommunicationXnlAuthenticationFailure,
		// Token: 0x0400003A RID: 58
		[global::System.Runtime.Serialization.EnumMember]
		CommunicationXnlNotSupportedCommand,
		// Token: 0x0400003B RID: 59
		[global::System.Runtime.Serialization.EnumMember]
		CommunicationNLPayloadHasBadData,
		// Token: 0x0400003C RID: 60
		[global::System.Runtime.Serialization.EnumMember]
		CommunicationPipeAlreadyOpened = 300,
		// Token: 0x0400003D RID: 61
		[global::System.Runtime.Serialization.EnumMember]
		CommunicationPipeNotOpened,
		// Token: 0x0400003E RID: 62
		[global::System.Runtime.Serialization.EnumMember]
		[global::Motorola.Common.CustomException.ErrorCodeAttributes(Retriable = true)]
		CommunicationPipeOpenFailure,
		// Token: 0x0400003F RID: 63
		[global::System.Runtime.Serialization.EnumMember]
		[global::Motorola.Common.CustomException.ErrorCodeAttributes(Retriable = true)]
		CommunicationPipeCloseFailure,
		// Token: 0x04000040 RID: 64
		[global::Motorola.Common.CustomException.ErrorCodeAttributes(Retriable = true)]
		[global::System.Runtime.Serialization.EnumMember]
		CommunicationPipeReadFailure,
		// Token: 0x04000041 RID: 65
		[global::System.Runtime.Serialization.EnumMember]
		[global::Motorola.Common.CustomException.ErrorCodeAttributes(Retriable = true)]
		CommunicationPipePeekFailure,
		// Token: 0x04000042 RID: 66
		[global::System.Runtime.Serialization.EnumMember]
		[global::Motorola.Common.CustomException.ErrorCodeAttributes(Retriable = true)]
		CommunicationPipeWriteFailure,
		// Token: 0x04000043 RID: 67
		[global::Motorola.Common.CustomException.ErrorCodeAttributes(Retriable = true)]
		[global::System.Runtime.Serialization.EnumMember]
		CommunicationPipeOpenTimeout,
		// Token: 0x04000044 RID: 68
		[global::Motorola.Common.CustomException.ErrorCodeAttributes(Retriable = true)]
		[global::System.Runtime.Serialization.EnumMember]
		CommunicationPipeReadTimeout,
		// Token: 0x04000045 RID: 69
		[global::Motorola.Common.CustomException.ErrorCodeAttributes(Retriable = true)]
		[global::System.Runtime.Serialization.EnumMember]
		CommunicationPipeWriteTimeout,
		// Token: 0x04000046 RID: 70
		[global::System.Runtime.Serialization.EnumMember]
		[global::Motorola.Common.CustomException.ErrorCodeAttributes(Retriable = true)]
		CommunicationPipeUnexpectedEndOfConnection,
		// Token: 0x04000047 RID: 71
		[global::System.Runtime.Serialization.EnumMember]
		CommunicationPipeReceivedDataLengthGreaterThanExpectedLength,
		// Token: 0x04000048 RID: 72
		[global::Motorola.Common.CustomException.ErrorCodeAttributes(Retriable = true)]
		[global::System.Runtime.Serialization.EnumMember]
		CommunicationPipeUnexpectedIncomingData,
		// Token: 0x04000049 RID: 73
		[global::System.Runtime.Serialization.EnumMember]
		CommunicationPipeBaudrateInitFail,
		// Token: 0x0400004A RID: 74
		[global::System.Runtime.Serialization.EnumMember]
		CommunicationPipeInvalidConnectorPosition,
		// Token: 0x0400004B RID: 75
		[global::System.Runtime.Serialization.EnumMember]
		CommunicationPipeInvalidFlowControl,
		// Token: 0x0400004C RID: 76
		[global::System.Runtime.Serialization.EnumMember]
		CommunicationPipeInvalidRadioReply,
		// Token: 0x0400004D RID: 77
		[global::System.Runtime.Serialization.EnumMember]
		CommunicationPipeInvalidPacketHeader,
		// Token: 0x0400004E RID: 78
		[global::Motorola.Common.CustomException.ErrorCodeAttributes(Retriable = true)]
		[global::System.Runtime.Serialization.EnumMember]
		CommunicationPipeOpenComPortFailure,
		// Token: 0x0400004F RID: 79
		[global::System.Runtime.Serialization.EnumMember]
		[global::Motorola.Common.CustomException.ErrorCodeAttributes(Retriable = true)]
		CommunicationPipeReceiveDataFailure,
		// Token: 0x04000050 RID: 80
		[global::System.Runtime.Serialization.EnumMember]
		CommunicationPipeReadDeviceInventoryFailed,
		// Token: 0x04000051 RID: 81
		[global::System.Runtime.Serialization.EnumMember]
		CommunicationPipeReadAppInventoryFailed,
		// Token: 0x04000052 RID: 82
		[global::System.Runtime.Serialization.EnumMember]
		CommunicationPipeReadLicenseInventoryFailed,
		// Token: 0x04000053 RID: 83
		[global::System.Runtime.Serialization.EnumMember]
		CommunicationPipePackageProvisioningFailed,
		// Token: 0x04000054 RID: 84
		[global::System.Runtime.Serialization.EnumMember]
		CommunicationPipeHomeSetFailed,
		// Token: 0x04000055 RID: 85
		[global::System.Runtime.Serialization.EnumMember]
		CommunicationPipeRemoveAppFailed,
		// Token: 0x04000056 RID: 86
		[global::System.Runtime.Serialization.EnumMember]
		CommunicationPipeInstallAppFailed,
		// Token: 0x04000057 RID: 87
		[global::System.Runtime.Serialization.EnumMember]
		CommunicationPipeUpdateLicenseFailed,
		// Token: 0x04000058 RID: 88
		[global::System.Runtime.Serialization.EnumMember]
		CommunicationPipeUpdateFirmwareFailed,
		// Token: 0x04000059 RID: 89
		[global::System.Runtime.Serialization.EnumMember]
		CommunicationPipeFactoryResetFailed,
		// Token: 0x0400005A RID: 90
		[global::System.Runtime.Serialization.EnumMember]
		CommunicationPipeReadUELogFailed,
		// Token: 0x0400005B RID: 91
		[global::System.Runtime.Serialization.EnumMember]
		CommunicationPipeReadLMRCodeplugFailed,
		// Token: 0x0400005C RID: 92
		[global::System.Runtime.Serialization.EnumMember]
		CommunicationPipeWriteLMRCodeplugFailed,
		// Token: 0x0400005D RID: 93
		[global::System.Runtime.Serialization.EnumMember]
		CommunicationPipeConfigurationFailed,
		// Token: 0x0400005E RID: 94
		[global::System.Runtime.Serialization.EnumMember]
		CommunicationPipeWiFiListFailed,
		// Token: 0x0400005F RID: 95
		[global::System.Runtime.Serialization.EnumMember]
		CommunicationPipeWhiteListFailed,
		// Token: 0x04000060 RID: 96
		[global::System.Runtime.Serialization.EnumMember]
		CommunicationPipeSimpleTouchFailed,
		// Token: 0x04000061 RID: 97
		[global::System.Runtime.Serialization.EnumMember]
		CommunicationPipeUninstallAllCertificateFailed,
		// Token: 0x04000062 RID: 98
		[global::System.Runtime.Serialization.EnumMember]
		CommunicationPipeInstallCertificateFailed,
		// Token: 0x04000063 RID: 99
		[global::System.Runtime.Serialization.EnumMember]
		CommunicationPipeEnableAllSysCertificateFailed,
		// Token: 0x04000064 RID: 100
		[global::System.Runtime.Serialization.EnumMember]
		CommunicationPipeDisableAllSysCertificateFailed,
		// Token: 0x04000065 RID: 101
		[global::System.Runtime.Serialization.EnumMember]
		Communication_NLWrapper_Invalid_Argument = 400,
		// Token: 0x04000066 RID: 102
		[global::System.Runtime.Serialization.EnumMember]
		[global::Motorola.Common.CustomException.ErrorCodeAttributes(Retriable = true)]
		Communication_NLWrapper_Open_Failed,
		// Token: 0x04000067 RID: 103
		[global::System.Runtime.Serialization.EnumMember]
		[global::Motorola.Common.CustomException.ErrorCodeAttributes(Retriable = true)]
		Communication_NLWrapper_Send_Fail,
		// Token: 0x04000068 RID: 104
		[global::System.Runtime.Serialization.EnumMember]
		Communication_NLWrapper_InValid_Option,
		// Token: 0x04000069 RID: 105
		[global::System.Runtime.Serialization.EnumMember]
		CommunicationManagerDeviceNotFound = 450,
		// Token: 0x0400006A RID: 106
		[global::System.Runtime.Serialization.EnumMember]
		CommunicationManagerDeviceNotReady,
		// Token: 0x0400006B RID: 107
		[global::System.Runtime.Serialization.EnumMember]
		CommunicationManagerTooManyMatchedInitializer,
		// Token: 0x0400006C RID: 108
		[global::System.Runtime.Serialization.EnumMember]
		CommunicationManagerNoMatchedInitializer,
		// Token: 0x0400006D RID: 109
		[global::System.Runtime.Serialization.EnumMember]
		CommunicationManagerCreateSequenceManagerFailure,
		// Token: 0x0400006E RID: 110
		[global::System.Runtime.Serialization.EnumMember]
		CommunicationManagerSequenceManagerNotCreated,
		// Token: 0x0400006F RID: 111
		[global::System.Runtime.Serialization.EnumMember]
		CommunicationManagerNotSupportForDevice,
		// Token: 0x04000070 RID: 112
		[global::System.Runtime.Serialization.EnumMember]
		CommunicationManagerNullDeviceInfo,
		// Token: 0x04000071 RID: 113
		[global::System.Runtime.Serialization.EnumMember]
		CommunicationManagerNullConnectionInfo,
		// Token: 0x04000072 RID: 114
		[global::System.Runtime.Serialization.EnumMember]
		CommunicationManagerUnsupportConnectionInfo,
		// Token: 0x04000073 RID: 115
		[global::System.Runtime.Serialization.EnumMember]
		CommunicationManagerInconsistentConnectionInfo,
		// Token: 0x04000074 RID: 116
		[global::System.Runtime.Serialization.EnumMember]
		CommunicationManagerDeviceDetectorStartFailure,
		// Token: 0x04000075 RID: 117
		[global::System.Runtime.Serialization.EnumMember]
		CommunicationManagerUnknownDeviceFamily,
		// Token: 0x04000076 RID: 118
		[global::System.Runtime.Serialization.EnumMember]
		CommunicationManagerSessionNotOpened,
		// Token: 0x04000077 RID: 119
		[global::System.Runtime.Serialization.EnumMember]
		CommunicationManagerSessionNotMatched,
		// Token: 0x04000078 RID: 120
		[global::System.Runtime.Serialization.EnumMember]
		CommunicationManagerGenerateNewUnqiueIDFailure,
		// Token: 0x04000079 RID: 121
		[global::System.Runtime.Serialization.EnumMember]
		CommunicationManagerReadBasicDeviceInfoFailure,
		// Token: 0x0400007A RID: 122
		[global::System.Runtime.Serialization.EnumMember]
		[global::Motorola.Common.CustomException.ErrorCodeAttributes(Retriable = true)]
		CommunicationManagerWireDeviceIdentityMismatched,
		// Token: 0x0400007B RID: 123
		[global::System.Runtime.Serialization.EnumMember]
		CommunicationManagerDeviceInvalid,
		// Token: 0x0400007C RID: 124
		[global::System.Runtime.Serialization.EnumMember]
		CommunicationManagerLocalPortConflict,
		// Token: 0x0400007D RID: 125
		[global::System.Runtime.Serialization.EnumMember]
		Communication_SequenceManager_InvalidUUID = 500,
		// Token: 0x0400007E RID: 126
		[global::System.Runtime.Serialization.EnumMember]
		Communication_SequenceManager_InvalidPSDT,
		// Token: 0x0400007F RID: 127
		[global::System.Runtime.Serialization.EnumMember]
		Communication_SequenceManager_Tetra_ReadImageFailure,
		// Token: 0x04000080 RID: 128
		[global::System.Runtime.Serialization.EnumMember]
		Communication_SequenceManager_Tetra_WriteImageFailure,
		// Token: 0x04000081 RID: 129
		[global::System.Runtime.Serialization.EnumMember]
		Communication_SequenceManager_Tetra_GetFDTUnitFailure,
		// Token: 0x04000082 RID: 130
		[global::System.Runtime.Serialization.EnumMember]
		Communication_SequenceManager_Pcr_BatteryLevelLow,
		// Token: 0x04000083 RID: 131
		[global::System.Runtime.Serialization.EnumMember]
		Communication_SequenceManager_Pcr_UnknownDeviceType,
		// Token: 0x04000084 RID: 132
		[global::System.Runtime.Serialization.EnumMember]
		Communication_SequenceManager_Pcr_DiffWriteNoChange,
		// Token: 0x04000085 RID: 133
		[global::System.Runtime.Serialization.EnumMember]
		Communication_SequenceManager_Pcr_EEPROM_CORRUPT,
		// Token: 0x04000086 RID: 134
		[global::System.Runtime.Serialization.EnumMember]
		Communication_SequenceManager_Astro_IshStatusBad,
		// Token: 0x04000087 RID: 135
		[global::System.Runtime.Serialization.EnumMember]
		[global::Motorola.Common.CustomException.ErrorCodeAttributes(Retriable = true)]
		Communication_SequenceManager_Astro_BackgroundEraseTimeout,
		// Token: 0x04000088 RID: 136
		[global::System.Runtime.Serialization.EnumMember]
		Communication_SequenceManager_Astro_UnlockRadioPartitionFailure,
		// Token: 0x04000089 RID: 137
		[global::System.Runtime.Serialization.EnumMember]
		Communication_SequenceManager_Astro_TooLongRadioKey,
		// Token: 0x0400008A RID: 138
		[global::System.Runtime.Serialization.EnumMember]
		Communication_SequenceManager_IshReorgFailure,
		// Token: 0x0400008B RID: 139
		[global::System.Runtime.Serialization.EnumMember]
		Communication_SequenceManager_Astro_MissingLangManifestFile,
		// Token: 0x0400008C RID: 140
		[global::System.Runtime.Serialization.EnumMember]
		Communication_SequenceManager_Astro_WriteValidationFailure,
		// Token: 0x0400008D RID: 141
		[global::System.Runtime.Serialization.EnumMember]
		Communication_SequenceManager_Astro_ModelNumberMismatch,
		// Token: 0x0400008E RID: 142
		[global::System.Runtime.Serialization.EnumMember]
		Communication_SequenceManager_Astro_CPVersionVerifyFailed,
		// Token: 0x0400008F RID: 143
		[global::System.Runtime.Serialization.EnumMember]
		Communication_SequenceManager_Astro_BatteryLevelLow,
		// Token: 0x04000090 RID: 144
		[global::Motorola.Common.CustomException.ErrorCodeAttributes(Retriable = true)]
		[global::System.Runtime.Serialization.EnumMember]
		Communication_SequenceManager_RadioIsBusy,
		// Token: 0x04000091 RID: 145
		[global::System.Runtime.Serialization.EnumMember]
		LanguagePack_Astro_One_or_more_files_in_the_RadioLanguagePacks_is_missing,
		// Token: 0x04000092 RID: 146
		[global::System.Runtime.Serialization.EnumMember]
		LanguagePack_Astro_InvalidData,
		// Token: 0x04000093 RID: 147
		[global::System.Runtime.Serialization.EnumMember]
		LanguagePack_Astro_Write_LangManifestFile_Failed,
		// Token: 0x04000094 RID: 148
		[global::System.Runtime.Serialization.EnumMember]
		LanguagePack_Astro_Missing_one_or_more_files_to_support_radio_language,
		// Token: 0x04000095 RID: 149
		[global::System.Runtime.Serialization.EnumMember]
		LanguagePack_Astro_Recommended_radio_language_is_available,
		// Token: 0x04000096 RID: 150
		[global::System.Runtime.Serialization.EnumMember]
		LanguagePack_Astro_LPK_update_is_not_support_via_POP25,
		// Token: 0x04000097 RID: 151
		[global::System.Runtime.Serialization.EnumMember]
		LanguagePack_Astro_Cannot_be_changed_via_POP25,
		// Token: 0x04000098 RID: 152
		[global::System.Runtime.Serialization.EnumMember]
		LanguagePack_Astro_Radio_does_not_have_enough_free_space,
		// Token: 0x04000099 RID: 153
		[global::System.Runtime.Serialization.EnumMember]
		LanguagePack_PCR_Radio_does_not_have_enough_free_space,
		// Token: 0x0400009A RID: 154
		[global::System.Runtime.Serialization.EnumMember]
		Communication_SequenceManager_Pcr_PasswordRetrievalFail,
		// Token: 0x0400009B RID: 155
		[global::System.Runtime.Serialization.EnumMember]
		Communication_SequenceManager_Astro_CloseSession_Fail,
		// Token: 0x0400009C RID: 156
		[global::System.Runtime.Serialization.EnumMember]
		Communication_SequenceManager_Astro_Encrypt_WiFi_Password_Fail,
		// Token: 0x0400009D RID: 157
		[global::System.Runtime.Serialization.EnumMember]
		Communication_SequenceManager_Astro_Decrypt_WiFi_Password_Fail,
		// Token: 0x0400009E RID: 158
		[global::System.Runtime.Serialization.EnumMember]
		Communication_SequenceManager_PcrDMR3Controller_ConfigVerionMismatch,
		// Token: 0x0400009F RID: 159
		[global::System.Runtime.Serialization.EnumMember]
		Communication_SequenceManager_Astro_Encrypt_External_Data_Modem_Password_Fail,
		// Token: 0x040000A0 RID: 160
		[global::System.Runtime.Serialization.EnumMember]
		Communication_SequenceManager_Astro_Decrypt_External_Data_Modem_Password_Fail,
		// Token: 0x040000A1 RID: 161
		[global::System.Runtime.Serialization.EnumMember]
		Communication_SequenceManager_Astro_Standalone_Not_Supported_LMR_OTAP,
		// Token: 0x040000A2 RID: 162
		[global::System.Runtime.Serialization.EnumMember]
		Communication_SequenceManager_Provisioning_WriteFailed,
		// Token: 0x040000A3 RID: 163
		[global::System.Runtime.Serialization.EnumMember]
		[global::Motorola.Common.CustomException.ErrorCodeAttributes(Retriable = true)]
		Communication_SequenceManager_Provisioning_CannotConnectToDevice,
		// Token: 0x040000A4 RID: 164
		[global::System.Runtime.Serialization.EnumMember]
		Communication_SequenceManager_Provisioning_CannotConnectToConfigurationService,
		// Token: 0x040000A5 RID: 165
		[global::System.Runtime.Serialization.EnumMember]
		Communication_SequenceManager_Provisioning_ReadFailed,
		// Token: 0x040000A6 RID: 166
		[global::System.Runtime.Serialization.EnumMember]
		Communication_SequenceManager_Provisioning_ReadInfoFailed,
		// Token: 0x040000A7 RID: 167
		[global::System.Runtime.Serialization.EnumMember]
		Communication_SequenceManager_Not_Supported_Radio_Firmware,
		// Token: 0x040000A8 RID: 168
		[global::System.Runtime.Serialization.EnumMember]
		Communication_SequenceManager_Device_Connnection_Info_Missing,
		// Token: 0x040000A9 RID: 169
		[global::System.Runtime.Serialization.EnumMember]
		Communication_SequenceManager_Provisioning_InvalidCFSHardwareID,
		// Token: 0x040000AA RID: 170
		[global::System.Runtime.Serialization.EnumMember]
		Communication_Astro_Firmware_Upgrade_Failed_Radio_Not_In_LTE_Network,
		// Token: 0x040000AB RID: 171
		[global::System.Runtime.Serialization.EnumMember]
		Communication_SequenceManager_Pcr_GetOBPackFilesFail,
		// Token: 0x040000AC RID: 172
		SwitchOverInvalidSessionID = 600,
		// Token: 0x040000AD RID: 173
		SwitchOverFailure,
		// Token: 0x040000AE RID: 174
		[global::Motorola.Common.CustomException.ErrorCodeAttributes(Retriable = true)]
		SwitchOverTimeout,
		// Token: 0x040000AF RID: 175
		[global::System.Runtime.Serialization.EnumMember]
		QueryVersionInfoFailure = 650,
		// Token: 0x040000B0 RID: 176
		[global::System.Runtime.Serialization.EnumMember]
		QueryRadioStatusFailure,
		// Token: 0x040000B1 RID: 177
		[global::System.Runtime.Serialization.EnumMember]
		QueryRadioStatusInvalidParameter,
		// Token: 0x040000B2 RID: 178
		[global::System.Runtime.Serialization.EnumMember]
		QueryRadioUUIDFailure,
		// Token: 0x040000B3 RID: 179
		[global::System.Runtime.Serialization.EnumMember]
		ReadLanguagePackInfoFailure,
		// Token: 0x040000B4 RID: 180
		[global::System.Runtime.Serialization.EnumMember]
		AddLanguagePackFailure,
		// Token: 0x040000B5 RID: 181
		[global::System.Runtime.Serialization.EnumMember]
		DeleteLanguagePackFailure,
		// Token: 0x040000B6 RID: 182
		[global::System.Runtime.Serialization.EnumMember]
		QueryRadioSerialNumberFailure,
		// Token: 0x040000B7 RID: 183
		[global::System.Runtime.Serialization.EnumMember]
		QueryRadioModelNumberFailure,
		// Token: 0x040000B8 RID: 184
		[global::System.Runtime.Serialization.EnumMember]
		QueryCodeplugAttributeFailure,
		// Token: 0x040000B9 RID: 185
		[global::System.Runtime.Serialization.EnumMember]
		InvalidProductFamilyMetadata,
		// Token: 0x040000BA RID: 186
		[global::System.Runtime.Serialization.EnumMember]
		EnterProgramModeFailure,
		// Token: 0x040000BB RID: 187
		[global::System.Runtime.Serialization.EnumMember]
		ExitProgramModeFailure,
		// Token: 0x040000BC RID: 188
		[global::System.Runtime.Serialization.EnumMember]
		[global::Motorola.Common.CustomException.ErrorCodeAttributes(Retriable = true)]
		ComponentReadFileFailure,
		// Token: 0x040000BD RID: 189
		[global::System.Runtime.Serialization.EnumMember]
		ComponentSessionFailure,
		// Token: 0x040000BE RID: 190
		[global::System.Runtime.Serialization.EnumMember]
		InvalidSessionID,
		// Token: 0x040000BF RID: 191
		[global::System.Runtime.Serialization.EnumMember]
		ComponentSessionDeployFailure,
		// Token: 0x040000C0 RID: 192
		[global::System.Runtime.Serialization.EnumMember]
		ComponentDeploySessionIdNotMatched,
		// Token: 0x040000C1 RID: 193
		[global::System.Runtime.Serialization.EnumMember]
		ComponentReadIshListFailure,
		// Token: 0x040000C2 RID: 194
		[global::System.Runtime.Serialization.EnumMember]
		FileAccessFailure,
		// Token: 0x040000C3 RID: 195
		[global::System.Runtime.Serialization.EnumMember]
		FileTransferDataFailure,
		// Token: 0x040000C4 RID: 196
		[global::System.Runtime.Serialization.EnumMember]
		FileReadFailure,
		// Token: 0x040000C5 RID: 197
		[global::System.Runtime.Serialization.EnumMember]
		ResetRadioFailure,
		// Token: 0x040000C6 RID: 198
		[global::System.Runtime.Serialization.EnumMember]
		TooLongOptionalData,
		// Token: 0x040000C7 RID: 199
		[global::System.Runtime.Serialization.EnumMember]
		FileDirectoryListFailure,
		// Token: 0x040000C8 RID: 200
		[global::System.Runtime.Serialization.EnumMember]
		ReadIshIdSetFailure,
		// Token: 0x040000C9 RID: 201
		[global::System.Runtime.Serialization.EnumMember]
		ReadIshTypeSetFailure,
		// Token: 0x040000CA RID: 202
		[global::System.Runtime.Serialization.EnumMember]
		ReadIshItemFailure,
		// Token: 0x040000CB RID: 203
		[global::System.Runtime.Serialization.EnumMember]
		BundleMessageFailure,
		// Token: 0x040000CC RID: 204
		[global::System.Runtime.Serialization.EnumMember]
		ValidateFieldsFailure,
		// Token: 0x040000CD RID: 205
		[global::System.Runtime.Serialization.EnumMember]
		ValidateInfosFailure,
		// Token: 0x040000CE RID: 206
		[global::System.Runtime.Serialization.EnumMember]
		ValidateInfosNotExist,
		// Token: 0x040000CF RID: 207
		[global::System.Runtime.Serialization.EnumMember]
		UpdateSerialNumberFailure,
		// Token: 0x040000D0 RID: 208
		[global::System.Runtime.Serialization.EnumMember]
		EraseFpgaFailure,
		// Token: 0x040000D1 RID: 209
		[global::System.Runtime.Serialization.EnumMember]
		ResetFpgaFailure,
		// Token: 0x040000D2 RID: 210
		[global::System.Runtime.Serialization.EnumMember]
		FailedToWriteFile,
		// Token: 0x040000D3 RID: 211
		[global::System.Runtime.Serialization.EnumMember]
		UpdateControlFailure,
		// Token: 0x040000D4 RID: 212
		[global::System.Runtime.Serialization.EnumMember]
		QueryPasswordPolicyFailure,
		// Token: 0x040000D5 RID: 213
		[global::System.Runtime.Serialization.EnumMember]
		ValidateLocalPasswordFailure,
		// Token: 0x040000D6 RID: 214
		[global::System.Runtime.Serialization.EnumMember]
		UpdateMACAddressFailure,
		// Token: 0x040000D7 RID: 215
		[global::System.Runtime.Serialization.EnumMember]
		UpdateDateCodeFailure,
		// Token: 0x040000D8 RID: 216
		[global::System.Runtime.Serialization.EnumMember]
		UpdateIMETypeFailure,
		// Token: 0x040000D9 RID: 217
		[global::System.Runtime.Serialization.EnumMember]
		ReadTTSLanguagePackInfoFailure,
		// Token: 0x040000DA RID: 218
		[global::System.Runtime.Serialization.EnumMember]
		AddTTSLanguagePackFailure,
		// Token: 0x040000DB RID: 219
		[global::System.Runtime.Serialization.EnumMember]
		DeleteTTSLanguagePackFailure,
		// Token: 0x040000DC RID: 220
		[global::System.Runtime.Serialization.EnumMember]
		QueryRadioPhysicalSerialNumberFailure,
		// Token: 0x040000DD RID: 221
		[global::System.Runtime.Serialization.EnumMember]
		UnkillRadioFailure,
		// Token: 0x040000DE RID: 222
		[global::System.Runtime.Serialization.EnumMember]
		ReadUnkillChallengeValueFailure,
		// Token: 0x040000DF RID: 223
		[global::System.Runtime.Serialization.EnumMember]
		InvalidModeUnkill,
		// Token: 0x040000E0 RID: 224
		[global::System.Runtime.Serialization.EnumMember]
		InvalidDerivedKey,
		// Token: 0x040000E1 RID: 225
		[global::System.Runtime.Serialization.EnumMember]
		CommonFileInvalidCrc32 = 850,
		// Token: 0x040000E2 RID: 226
		[global::System.Runtime.Serialization.EnumMember]
		CommonFileInvalidFileLength,
		// Token: 0x040000E3 RID: 227
		[global::System.Runtime.Serialization.EnumMember]
		CommonFileInvalidTypeLevelDataLength,
		// Token: 0x040000E4 RID: 228
		[global::System.Runtime.Serialization.EnumMember]
		CommonFileInvalidItemLevelDataLength,
		// Token: 0x040000E5 RID: 229
		[global::System.Runtime.Serialization.EnumMember]
		CommonFileInvalidCodeplugDataLength,
		// Token: 0x040000E6 RID: 230
		[global::System.Runtime.Serialization.EnumMember]
		CommonFileInvalidItemDataLength,
		// Token: 0x040000E7 RID: 231
		[global::System.Runtime.Serialization.EnumMember]
		CommonFileInvalidCommonFileVersion,
		// Token: 0x040000E8 RID: 232
		[global::System.Runtime.Serialization.EnumMember]
		[global::Motorola.Common.CustomException.ErrorCodeAttributes(Retriable = true)]
		RUDP_RawSocketCreationFailed = 900,
		// Token: 0x040000E9 RID: 233
		[global::System.Runtime.Serialization.EnumMember]
		RUDP_ConnectionIPPortInvalid,
		// Token: 0x040000EA RID: 234
		[global::System.Runtime.Serialization.EnumMember]
		[global::Motorola.Common.CustomException.ErrorCodeAttributes(Retriable = true)]
		RUDP_SendIsNotCompleted,
		// Token: 0x040000EB RID: 235
		[global::System.Runtime.Serialization.EnumMember]
		RUDP_PacketHeaderValidationFailed,
		// Token: 0x040000EC RID: 236
		[global::System.Runtime.Serialization.EnumMember]
		RUDP_HighAccurateTimerIsNotSupported,
		// Token: 0x040000ED RID: 237
		[global::System.Runtime.Serialization.EnumMember]
		RUDP_HighAccurateTimer_QueryPerformanceCounterFailed,
		// Token: 0x040000EE RID: 238
		[global::System.Runtime.Serialization.EnumMember]
		RUDP_InvalidConfigurationFile,
		// Token: 0x040000EF RID: 239
		[global::System.Runtime.Serialization.EnumMember]
		RUDP_InvalidTypeInConfigurationFile,
		// Token: 0x040000F0 RID: 240
		[global::System.Runtime.Serialization.EnumMember]
		RUDP_ReceiveSizeIsnotBigEnough,
		// Token: 0x040000F1 RID: 241
		[global::Motorola.Common.CustomException.ErrorCodeAttributes(Retriable = true)]
		[global::System.Runtime.Serialization.EnumMember]
		RUDP_ReceiveTimeout,
		// Token: 0x040000F2 RID: 242
		[global::System.Runtime.Serialization.EnumMember]
		RUDP_HandshakePacketInitFailed,
		// Token: 0x040000F3 RID: 243
		[global::System.Runtime.Serialization.EnumMember]
		[global::Motorola.Common.CustomException.ErrorCodeAttributes(Retriable = true)]
		RUDP_ResetByRemotePeer,
		// Token: 0x040000F4 RID: 244
		[global::System.Runtime.Serialization.EnumMember]
		[global::Motorola.Common.CustomException.ErrorCodeAttributes(Retriable = true)]
		RUDP_UnexpectedPacketReceived,
		// Token: 0x040000F5 RID: 245
		[global::Motorola.Common.CustomException.ErrorCodeAttributes(Retriable = true)]
		[global::System.Runtime.Serialization.EnumMember]
		Security_OpenSSL_Uninitialize = 950,
		// Token: 0x040000F6 RID: 246
		[global::Motorola.Common.CustomException.ErrorCodeAttributes(Retriable = true)]
		[global::System.Runtime.Serialization.EnumMember]
		Security_OpenSSL_Initialize_Failed,
		// Token: 0x040000F7 RID: 247
		[global::System.Runtime.Serialization.EnumMember]
		Security_OpenSSL_Handshake_Failed,
		// Token: 0x040000F8 RID: 248
		[global::System.Runtime.Serialization.EnumMember]
		[global::Motorola.Common.CustomException.ErrorCodeAttributes(Retriable = true)]
		Security_OpenSSL_Send_Failed,
		// Token: 0x040000F9 RID: 249
		[global::Motorola.Common.CustomException.ErrorCodeAttributes(Retriable = true)]
		[global::System.Runtime.Serialization.EnumMember]
		Security_OpenSSL_Receive_Failed,
		// Token: 0x040000FA RID: 250
		[global::System.Runtime.Serialization.EnumMember]
		Communication_Compression_LZMA_Compress_Failed = 1000,
		// Token: 0x040000FB RID: 251
		[global::System.Runtime.Serialization.EnumMember]
		Communication_Compression_LZMA_Decompress_Failed,
		// Token: 0x040000FC RID: 252
		[global::System.Runtime.Serialization.EnumMember]
		Communication_Compression_FASTLZ_Compress_Failed,
		// Token: 0x040000FD RID: 253
		[global::System.Runtime.Serialization.EnumMember]
		Communication_Compression_FASTLZ_Decompress_Failed,
		// Token: 0x040000FE RID: 254
		[global::System.Runtime.Serialization.EnumMember]
		SSL_Unknown = 1050,
		// Token: 0x040000FF RID: 255
		[global::System.Runtime.Serialization.EnumMember]
		SSL_InvalidIP,
		// Token: 0x04000100 RID: 256
		[global::System.Runtime.Serialization.EnumMember]
		SSL_InvalidSubscriptionType,
		// Token: 0x04000101 RID: 257
		[global::System.Runtime.Serialization.EnumMember]
		SSL_UnhandledLinkMgrException,
		// Token: 0x04000102 RID: 258
		[global::System.Runtime.Serialization.EnumMember]
		SSL_ListenerThreadFailed,
		// Token: 0x04000103 RID: 259
		[global::System.Runtime.Serialization.EnumMember]
		SSL_TLSClientInternalFailure,
		// Token: 0x04000104 RID: 260
		[global::System.Runtime.Serialization.EnumMember]
		SSL_TLSServerThreadFailed,
		// Token: 0x04000105 RID: 261
		[global::System.Runtime.Serialization.EnumMember]
		SSL_TLSServerInternalfailure,
		// Token: 0x04000106 RID: 262
		[global::System.Runtime.Serialization.EnumMember]
		SSL_UDPPortOutOfRange,
		// Token: 0x04000107 RID: 263
		[global::System.Runtime.Serialization.EnumMember]
		SSL_TCPPortOutOfRange,
		// Token: 0x04000108 RID: 264
		[global::System.Runtime.Serialization.EnumMember]
		SSL_MessageCouldNotBeParsed,
		// Token: 0x04000109 RID: 265
		[global::System.Runtime.Serialization.EnumMember]
		SSL_MessageInvalidFormat,
		// Token: 0x0400010A RID: 266
		[global::System.Runtime.Serialization.EnumMember]
		SSL_IncompleteNotify,
		// Token: 0x0400010B RID: 267
		[global::System.Runtime.Serialization.EnumMember]
		SSL_NotiyfyParametersOutOfRange,
		// Token: 0x0400010C RID: 268
		[global::System.Runtime.Serialization.EnumMember]
		SSL_NativeError,
		// Token: 0x0400010D RID: 269
		[global::System.Runtime.Serialization.EnumMember]
		SSL_LE_UnableToOpenSocket,
		// Token: 0x0400010E RID: 270
		[global::System.Runtime.Serialization.EnumMember]
		SSL_LE_UDPArgumentException,
		// Token: 0x0400010F RID: 271
		[global::System.Runtime.Serialization.EnumMember]
		SSL_LE_PNServerNotResponding,
		// Token: 0x04000110 RID: 272
		[global::System.Runtime.Serialization.EnumMember]
		SSL_LE_Disconnected,
		// Token: 0x04000111 RID: 273
		[global::System.Runtime.Serialization.EnumMember]
		SSL_LE_LinkShutdownFail,
		// Token: 0x04000112 RID: 274
		[global::System.Runtime.Serialization.EnumMember]
		SSL_PE_TLSProtocolFailed,
		// Token: 0x04000113 RID: 275
		[global::System.Runtime.Serialization.EnumMember]
		SSL_PE_UDPDataSendFail,
		// Token: 0x04000114 RID: 276
		[global::System.Runtime.Serialization.EnumMember]
		SSL_PE_UDPPackageError,
		// Token: 0x04000115 RID: 277
		[global::System.Runtime.Serialization.EnumMember]
		SSL_PE_PackageTimeout,
		// Token: 0x04000116 RID: 278
		[global::System.Runtime.Serialization.EnumMember]
		SSL_PE_MutualAuthenticationFail,
		// Token: 0x04000117 RID: 279
		[global::System.Runtime.Serialization.EnumMember]
		SSL_PE_CipherStrengthFail,
		// Token: 0x04000118 RID: 280
		[global::System.Runtime.Serialization.EnumMember]
		SSL_PE_AESCipherFail,
		// Token: 0x04000119 RID: 281
		[global::System.Runtime.Serialization.EnumMember]
		SSL_PE_InvalidHandshakeSequence,
		// Token: 0x0400011A RID: 282
		[global::System.Runtime.Serialization.EnumMember]
		SSL_PE_ConnectionTerminatedByServer,
		// Token: 0x0400011B RID: 283
		[global::System.Runtime.Serialization.EnumMember]
		SSL_PE_ConnectionTerminatedByClient,
		// Token: 0x0400011C RID: 284
		[global::System.Runtime.Serialization.EnumMember]
		SSL_CE_CertificateExpired,
		// Token: 0x0400011D RID: 285
		[global::System.Runtime.Serialization.EnumMember]
		SSL_CE_CertificateNotYetActive,
		// Token: 0x0400011E RID: 286
		[global::System.Runtime.Serialization.EnumMember]
		SSL_CE_CertificateRevoked,
		// Token: 0x0400011F RID: 287
		[global::System.Runtime.Serialization.EnumMember]
		SSL_CE_EncryptionFailed,
		// Token: 0x04000120 RID: 288
		[global::System.Runtime.Serialization.EnumMember]
		SSL_CE_ClientCertificateRequestDenied,
		// Token: 0x04000121 RID: 289
		[global::System.Runtime.Serialization.EnumMember]
		SSL_CE_InvalidPhrase,
		// Token: 0x04000122 RID: 290
		[global::System.Runtime.Serialization.EnumMember]
		SSL_CE_PublicKeyError,
		// Token: 0x04000123 RID: 291
		[global::System.Runtime.Serialization.EnumMember]
		SSL_CE_CertificateNotSigned,
		// Token: 0x04000124 RID: 292
		[global::System.Runtime.Serialization.EnumMember]
		SSL_CE_DHNotFound,
		// Token: 0x04000125 RID: 293
		[global::System.Runtime.Serialization.EnumMember]
		SSL_CE_PrivateKeyGenError,
		// Token: 0x04000126 RID: 294
		[global::Motorola.Common.CustomException.ErrorCodeAttributes(Retriable = true)]
		[global::System.Runtime.Serialization.EnumMember]
		PCR_RP_REMOTE_CONNECTION_FAILED = 1151,
		// Token: 0x04000127 RID: 295
		[global::System.Runtime.Serialization.EnumMember]
		PCR_RP_SEND_CONNECT_REQUEST_TO_MASTER_FAILED,
		// Token: 0x04000128 RID: 296
		[global::System.Runtime.Serialization.EnumMember]
		PCR_RP_REMOTE_COMMAND_NOT_SUPPORTED,
		// Token: 0x04000129 RID: 297
		[global::System.Runtime.Serialization.EnumMember]
		PCR_RP_REMOTE_SERVICE_NOT_SUPPORTED,
		// Token: 0x0400012A RID: 298
		[global::Motorola.Common.CustomException.ErrorCodeAttributes(Retriable = true)]
		[global::System.Runtime.Serialization.EnumMember]
		PCR_RP_REMOTE_OPERATION_BUSY,
		// Token: 0x0400012B RID: 299
		[global::System.Runtime.Serialization.EnumMember]
		[global::Motorola.Common.CustomException.ErrorCodeAttributes(Retriable = true)]
		PCR_RP_LE_OPEN_FAILED,
		// Token: 0x0400012C RID: 300
		[global::System.Runtime.Serialization.EnumMember]
		[global::Motorola.Common.CustomException.ErrorCodeAttributes(Retriable = true)]
		PCR_RP_LE_ISNOT_OPEN,
		// Token: 0x0400012D RID: 301
		[global::Motorola.Common.CustomException.ErrorCodeAttributes(Retriable = true)]
		[global::System.Runtime.Serialization.EnumMember]
		PCR_RP_LE_CLOSE_FAILED,
		// Token: 0x0400012E RID: 302
		[global::Motorola.Common.CustomException.ErrorCodeAttributes(Retriable = true)]
		[global::System.Runtime.Serialization.EnumMember]
		PCR_RP_LE_GET_PEER_MAP_FAILED,
		// Token: 0x0400012F RID: 303
		[global::System.Runtime.Serialization.EnumMember]
		[global::Motorola.Common.CustomException.ErrorCodeAttributes(Retriable = true)]
		PCR_RP_LE_DEREGISTRATION_FAILED,
		// Token: 0x04000130 RID: 304
		[global::Motorola.Common.CustomException.ErrorCodeAttributes(Retriable = true)]
		[global::System.Runtime.Serialization.EnumMember]
		PCR_RP_LE_SEND_PROXY_CONNECTION_REQUEST_FAILED,
		// Token: 0x04000131 RID: 305
		[global::Motorola.Common.CustomException.ErrorCodeAttributes(Retriable = true)]
		[global::System.Runtime.Serialization.EnumMember]
		PCR_RP_READ_MOMEORY_FAILED,
		// Token: 0x04000132 RID: 306
		[global::System.Runtime.Serialization.EnumMember]
		PCR_RP_WRITE_MOMEORY_FAILED,
		// Token: 0x04000133 RID: 307
		[global::System.Runtime.Serialization.EnumMember]
		PCR_RP_REMOTE_OPERATION_DISABLED,
		// Token: 0x04000134 RID: 308
		[global::System.Runtime.Serialization.EnumMember]
		UpdateDevice_Astro_CodeplugValidationFailed = 1200,
		// Token: 0x04000135 RID: 309
		[global::System.Runtime.Serialization.EnumMember]
		UpdateDevice_Astro_FirmwareValidationFailed,
		// Token: 0x04000136 RID: 310
		[global::System.Runtime.Serialization.EnumMember]
		UpdateDevice_Astro_EraseFlashFailed,
		// Token: 0x04000137 RID: 311
		[global::System.Runtime.Serialization.EnumMember]
		UpdateDevice_Astro_WriteMemoryFailed,
		// Token: 0x04000138 RID: 312
		[global::System.Runtime.Serialization.EnumMember]
		UpdateDevice_Astro_CopyPsdtFailed,
		// Token: 0x04000139 RID: 313
		[global::System.Runtime.Serialization.EnumMember]
		UpdateDevice_Astro_BackgroundEraserPollFailed,
		// Token: 0x0400013A RID: 314
		[global::System.Runtime.Serialization.EnumMember]
		UpdateDevice_Astro_GetActivePartitionFailed,
		// Token: 0x0400013B RID: 315
		[global::System.Runtime.Serialization.EnumMember]
		UpdateDevice_Astro_InvalidFlashData,
		// Token: 0x0400013C RID: 316
		[global::System.Runtime.Serialization.EnumMember]
		UpdateDevice_Astro_MissingFlashData,
		// Token: 0x0400013D RID: 317
		[global::System.Runtime.Serialization.EnumMember]
		UpdateDevice_Astro_MissingUncompressedData,
		// Token: 0x0400013E RID: 318
		[global::System.Runtime.Serialization.EnumMember]
		UpdateDevice_Astro_UnlockPsdtFlashSectionFailed,
		// Token: 0x0400013F RID: 319
		[global::System.Runtime.Serialization.EnumMember]
		UpdateDevice_Pcr_CheckSumFailure,
		// Token: 0x04000140 RID: 320
		[global::System.Runtime.Serialization.EnumMember]
		UpdateDevice_Pcr_SecurityMatchFailure,
		// Token: 0x04000141 RID: 321
		[global::System.Runtime.Serialization.EnumMember]
		UpdateDevice_Pcr_OutOfMemory,
		// Token: 0x04000142 RID: 322
		[global::System.Runtime.Serialization.EnumMember]
		UpdateDevice_Pcr_Missing_Update_File,
		// Token: 0x04000143 RID: 323
		[global::System.Runtime.Serialization.EnumMember]
		DataReceivedIsGreaterThanExpected = 1250,
		// Token: 0x04000144 RID: 324
		[global::System.Runtime.Serialization.EnumMember]
		ReadMemoryBlocksFailure,
		// Token: 0x04000145 RID: 325
		[global::System.Runtime.Serialization.EnumMember]
		IncompleteReadMemoryBlocksOperation,
		// Token: 0x04000146 RID: 326
		[global::System.Runtime.Serialization.EnumMember]
		ReadMemory64KFailure,
		// Token: 0x04000147 RID: 327
		[global::System.Runtime.Serialization.EnumMember]
		IncompleteReadMemory64KOperation,
		// Token: 0x04000148 RID: 328
		[global::System.Runtime.Serialization.EnumMember]
		WriteMemoryBlocksFailure,
		// Token: 0x04000149 RID: 329
		[global::System.Runtime.Serialization.EnumMember]
		IncompleteWriteMemoryBlocksOperation,
		// Token: 0x0400014A RID: 330
		[global::System.Runtime.Serialization.EnumMember]
		DataToBeSentIsGreaterThanExpected,
		// Token: 0x0400014B RID: 331
		[global::System.Runtime.Serialization.EnumMember]
		WriteMemory64KFailure,
		// Token: 0x0400014C RID: 332
		[global::System.Runtime.Serialization.EnumMember]
		IncompleteWriteMemory64KOperation,
		// Token: 0x0400014D RID: 333
		[global::System.Runtime.Serialization.EnumMember]
		IncompleteReadMemoryOperation,
		// Token: 0x0400014E RID: 334
		[global::System.Runtime.Serialization.EnumMember]
		ReadMemoryFailure,
		// Token: 0x0400014F RID: 335
		[global::System.Runtime.Serialization.EnumMember]
		InvalidSrecordData,
		// Token: 0x04000150 RID: 336
		[global::System.Runtime.Serialization.EnumMember]
		InvalidSrecordFile,
		// Token: 0x04000151 RID: 337
		[global::System.Runtime.Serialization.EnumMember]
		RamDownloaderWriteFailure,
		// Token: 0x04000152 RID: 338
		[global::System.Runtime.Serialization.EnumMember]
		RamDownloaderExecutionFailure,
		// Token: 0x04000153 RID: 339
		[global::System.Runtime.Serialization.EnumMember]
		EraseFlashFailure,
		// Token: 0x04000154 RID: 340
		[global::System.Runtime.Serialization.EnumMember]
		BootLoadFailure,
		// Token: 0x04000155 RID: 341
		[global::System.Runtime.Serialization.EnumMember]
		SecurityUnlockFailure,
		// Token: 0x04000156 RID: 342
		[global::System.Runtime.Serialization.EnumMember]
		ReadRadioKeyFailure,
		// Token: 0x04000157 RID: 343
		[global::System.Runtime.Serialization.EnumMember]
		BootJumpExecutionFailure,
		// Token: 0x04000158 RID: 344
		[global::System.Runtime.Serialization.EnumMember]
		BootCommitFailure,
		// Token: 0x04000159 RID: 345
		[global::System.Runtime.Serialization.EnumMember]
		RadioResetFailure,
		// Token: 0x0400015A RID: 346
		[global::System.Runtime.Serialization.EnumMember]
		EnterBootModeFailure,
		// Token: 0x0400015B RID: 347
		[global::System.Runtime.Serialization.EnumMember]
		RemoteDuplicateSetupFailure,
		// Token: 0x0400015C RID: 348
		[global::System.Runtime.Serialization.EnumMember]
		RemoteConnectFailure,
		// Token: 0x0400015D RID: 349
		[global::System.Runtime.Serialization.EnumMember]
		RemoteDisconnectFailure,
		// Token: 0x0400015E RID: 350
		[global::System.Runtime.Serialization.EnumMember]
		WriteRamDownloaderFailure,
		// Token: 0x0400015F RID: 351
		[global::System.Runtime.Serialization.EnumMember]
		FlashFilesToRamFailure,
		// Token: 0x04000160 RID: 352
		[global::System.Runtime.Serialization.EnumMember]
		PartitionAddressRetrievalFailure,
		// Token: 0x04000161 RID: 353
		[global::System.Runtime.Serialization.EnumMember]
		PsdtAccessFailure,
		// Token: 0x04000162 RID: 354
		[global::System.Runtime.Serialization.EnumMember]
		RemoteDeviceDiscoveryFailure,
		// Token: 0x04000163 RID: 355
		[global::System.Runtime.Serialization.EnumMember]
		ISHUnlockFailure,
		// Token: 0x04000164 RID: 356
		[global::System.Runtime.Serialization.EnumMember]
		EnterTestModeFailure,
		// Token: 0x04000165 RID: 357
		[global::System.Runtime.Serialization.EnumMember]
		FZI_FZAP_OPCODE_NOT_SUPPORTED,
		// Token: 0x04000166 RID: 358
		[global::System.Runtime.Serialization.EnumMember]
		EXCHANGE_DEVICE_NOT_SUPPORT = 1350,
		// Token: 0x04000167 RID: 359
		[global::System.Runtime.Serialization.EnumMember]
		EXCHANGE_COMM_NOT_OPEN,
		// Token: 0x04000168 RID: 360
		[global::System.Runtime.Serialization.EnumMember]
		EXCHANGE_INVALID_ARGUMENT,
		// Token: 0x04000169 RID: 361
		[global::System.Runtime.Serialization.EnumMember]
		EXCHANGE_NO_LCNS,
		// Token: 0x0400016A RID: 362
		[global::System.Runtime.Serialization.EnumMember]
		EXCHANGE_COMM_ERROR,
		// Token: 0x0400016B RID: 363
		[global::System.Runtime.Serialization.EnumMember]
		EXCHANGE_FSREQACK_ERROR,
		// Token: 0x0400016C RID: 364
		[global::System.Runtime.Serialization.EnumMember]
		EXCHANGE_INVALID_FEATURE,
		// Token: 0x0400016D RID: 365
		[global::System.Runtime.Serialization.EnumMember]
		EXCHANGE_FCACK_ERROR,
		// Token: 0x0400016E RID: 366
		[global::System.Runtime.Serialization.EnumMember]
		EXCHANGE_LULACK_ERROR,
		// Token: 0x0400016F RID: 367
		[global::System.Runtime.Serialization.EnumMember]
		EXCHANGE_FEATURE_FAILED,
		// Token: 0x04000170 RID: 368
		[global::Motorola.Common.CustomException.ErrorCodeAttributes(Retriable = true)]
		[global::System.Runtime.Serialization.EnumMember]
		EXCHANGE_DUP_MSG,
		// Token: 0x04000171 RID: 369
		[global::System.Runtime.Serialization.EnumMember]
		[global::Motorola.Common.CustomException.ErrorCodeAttributes(Retriable = true)]
		CCC_TIMEOUT,
		// Token: 0x04000172 RID: 370
		[global::System.Runtime.Serialization.EnumMember]
		[global::Motorola.Common.CustomException.ErrorCodeAttributes(Retriable = true)]
		EXCHANGE_COMM_FAILED,
		// Token: 0x04000173 RID: 371
		[global::System.Runtime.Serialization.EnumMember]
		EXCHANGE_DCACK_ERROR,
		// Token: 0x04000174 RID: 372
		[global::System.Runtime.Serialization.EnumMember]
		EXCHANGE_INVALID_XML_INPUT,
		// Token: 0x04000175 RID: 373
		[global::System.Runtime.Serialization.EnumMember]
		EXCHANGE_DS_COMM_ERROR,
		// Token: 0x04000176 RID: 374
		[global::System.Runtime.Serialization.EnumMember]
		EXCHANGE_TOMSG_ERROR,
		// Token: 0x04000177 RID: 375
		[global::System.Runtime.Serialization.EnumMember]
		EXCHANGE_ACKPRS_ERROR,
		// Token: 0x04000178 RID: 376
		[global::System.Runtime.Serialization.EnumMember]
		EXCHANGE_DE_ERROR,
		// Token: 0x04000179 RID: 377
		[global::System.Runtime.Serialization.EnumMember]
		EXCHANGE_EN_ERROR,
		// Token: 0x0400017A RID: 378
		[global::System.Runtime.Serialization.EnumMember]
		EXCHANGE_ACKDERAND_ERROR,
		// Token: 0x0400017B RID: 379
		[global::System.Runtime.Serialization.EnumMember]
		EXCHANGE_FEATURE_TIMEOUT,
		// Token: 0x0400017C RID: 380
		[global::System.Runtime.Serialization.EnumMember]
		COMMON_SECURITY_SERIAL_NUMBER_NULL = 1450,
		// Token: 0x0400017D RID: 381
		[global::System.Runtime.Serialization.EnumMember]
		HttpRequestTimeout = 1550,
		// Token: 0x0400017E RID: 382
		HttpReplyUnexpectedStatus,
		// Token: 0x0400017F RID: 383
		HttpProvConfigFileRejected,
		// Token: 0x04000180 RID: 384
		HttpProvConfigServiceBusy,
		// Token: 0x04000181 RID: 385
		Http_LICENSE_TC_FAILURE,
		// Token: 0x04000182 RID: 386
		Http_CONFIG_TC_FAILURE,
		// Token: 0x04000183 RID: 387
		Http_CONNECT_TC_FAILURE,
		// Token: 0x04000184 RID: 388
		Http_LICENSE_MNIS_FAILURE,
		// Token: 0x04000185 RID: 389
		Http_CONFIG_MNIS_FAILURE,
		// Token: 0x04000186 RID: 390
		Http_LICENSE_UEM_FAILURE,
		// Token: 0x04000187 RID: 391
		Http_CONFIG_UEM_FAILURE,
		// Token: 0x04000188 RID: 392
		Http_IP_CHANGE_FAILURE,
		// Token: 0x04000189 RID: 393
		Http_NTP_CHANGE_FAILURE,
		// Token: 0x0400018A RID: 394
		[global::System.Runtime.Serialization.EnumMember]
		X509ClientCertificateNotInstalled = 2000,
		// Token: 0x0400018B RID: 395
		[global::System.Runtime.Serialization.EnumMember]
		X509ClientCertificatePathNotFound,
		// Token: 0x0400018C RID: 396
		[global::System.Runtime.Serialization.EnumMember]
		X509ClientCertificateNameNotMatch,
		// Token: 0x0400018D RID: 397
		[global::System.Runtime.Serialization.EnumMember]
		X509ServiceCertificateNotInstalled,
		// Token: 0x0400018E RID: 398
		[global::System.Runtime.Serialization.EnumMember]
		ServiceNotCompatibleWithClientVersion,
		// Token: 0x0400018F RID: 399
		[global::System.Runtime.Serialization.EnumMember]
		CANNOT_CONNECT_TO_DISCOVERYSERVER,
		// Token: 0x04000190 RID: 400
		[global::System.Runtime.Serialization.EnumMember]
		TARGET_SERVER_NOT_AVAILABLE,
		// Token: 0x04000191 RID: 401
		[global::System.Runtime.Serialization.EnumMember]
		CANNOT_CONNECT_TO_TARGET_SERVER,
		// Token: 0x04000192 RID: 402
		[global::System.Runtime.Serialization.EnumMember]
		PASSWORD_CHANGE_NOT_SUPPORTED_FOR_USER,
		// Token: 0x04000193 RID: 403
		[global::System.Runtime.Serialization.EnumMember]
		PASSWORD_CHANGE_FAILED,
		// Token: 0x04000194 RID: 404
		[global::System.Runtime.Serialization.EnumMember]
		USER_ACTIVATION_FAILED,
		// Token: 0x04000195 RID: 405
		[global::System.Runtime.Serialization.EnumMember]
		USER_NOT_ACTIVATED,
		// Token: 0x04000196 RID: 406
		[global::System.Runtime.Serialization.EnumMember]
		MACHINE_NOT_ACTIVATED,
		// Token: 0x04000197 RID: 407
		[global::System.Runtime.Serialization.EnumMember]
		SECURITY_TOKEN_REQUEST_WAS_DENIED,
		// Token: 0x04000198 RID: 408
		[global::System.Runtime.Serialization.EnumMember]
		DISCOVERYCLIENT_SETTING_IS_INCORRECT,
		// Token: 0x04000199 RID: 409
		[global::System.Runtime.Serialization.EnumMember]
		DISCOVERY_LOGIN_FAILED,
		// Token: 0x0400019A RID: 410
		[global::System.Runtime.Serialization.EnumMember]
		TARGET_DISCOVERYSERVER_NOT_AVAILABLE,
		// Token: 0x0400019B RID: 411
		[global::System.Runtime.Serialization.EnumMember]
		RMC_Special_Display_Msg = 2049,
		// Token: 0x0400019C RID: 412
		[global::System.Runtime.Serialization.EnumMember]
		RMC_Generic_Error,
		// Token: 0x0400019D RID: 413
		[global::System.Runtime.Serialization.EnumMember]
		RMC_CPSGenaralError,
		// Token: 0x0400019E RID: 414
		[global::System.Runtime.Serialization.EnumMember]
		RMC_CreateServerClientFailed,
		// Token: 0x0400019F RID: 415
		[global::System.Runtime.Serialization.EnumMember]
		RMC_CallServiceError,
		// Token: 0x040001A0 RID: 416
		[global::System.Runtime.Serialization.EnumMember]
		RMC_SaveFailForEditTemplate,
		// Token: 0x040001A1 RID: 417
		[global::System.Runtime.Serialization.EnumMember]
		RMC_DeviceNoExistForEditTemplate,
		// Token: 0x040001A2 RID: 418
		[global::System.Runtime.Serialization.EnumMember]
		RMC_GroupNameLength_Error,
		// Token: 0x040001A3 RID: 419
		[global::System.Runtime.Serialization.EnumMember]
		RMC_GroupExist_Error,
		// Token: 0x040001A4 RID: 420
		[global::System.Runtime.Serialization.EnumMember]
		RMC_ImportCodeplug_SaveError,
		// Token: 0x040001A5 RID: 421
		[global::System.Runtime.Serialization.EnumMember]
		RMC_SaveDevice_Error,
		// Token: 0x040001A6 RID: 422
		[global::System.Runtime.Serialization.EnumMember]
		RMC_AddAgency_Error,
		// Token: 0x040001A7 RID: 423
		[global::System.Runtime.Serialization.EnumMember]
		RMC_AddSet_Error,
		// Token: 0x040001A8 RID: 424
		[global::System.Runtime.Serialization.EnumMember]
		RMC_AddSet_ReachForceloadRecordMaxNumber,
		// Token: 0x040001A9 RID: 425
		[global::System.Runtime.Serialization.EnumMember]
		RMC_RadioDetails_Error,
		// Token: 0x040001AA RID: 426
		[global::System.Runtime.Serialization.EnumMember]
		RMC_ImportCodeplug_Error,
		// Token: 0x040001AB RID: 427
		[global::System.Runtime.Serialization.EnumMember]
		RMC_DeleteDevices_Error,
		// Token: 0x040001AC RID: 428
		[global::System.Runtime.Serialization.EnumMember]
		RMC_ApplyCodeplug_Error,
		// Token: 0x040001AD RID: 429
		[global::System.Runtime.Serialization.EnumMember]
		RMC_DiscardCodeplug_Error,
		// Token: 0x040001AE RID: 430
		[global::System.Runtime.Serialization.EnumMember]
		RMC_JobSchedule_Error,
		// Token: 0x040001AF RID: 431
		[global::System.Runtime.Serialization.EnumMember]
		RMC_CancelJob_Error,
		// Token: 0x040001B0 RID: 432
		[global::System.Runtime.Serialization.EnumMember]
		RMC_ImportCSVFile_Error,
		// Token: 0x040001B1 RID: 433
		[global::System.Runtime.Serialization.EnumMember]
		RMC_RenameTemplate_Error,
		// Token: 0x040001B2 RID: 434
		[global::System.Runtime.Serialization.EnumMember]
		RMC_SetServer_Error,
		// Token: 0x040001B3 RID: 435
		[global::System.Runtime.Serialization.EnumMember]
		RMC_RefreshAgencies_Error,
		// Token: 0x040001B4 RID: 436
		[global::System.Runtime.Serialization.EnumMember]
		RMC_DeleteAgency_Error,
		// Token: 0x040001B5 RID: 437
		[global::System.Runtime.Serialization.EnumMember]
		RMC_RenameAgency_Error,
		// Token: 0x040001B6 RID: 438
		[global::System.Runtime.Serialization.EnumMember]
		RMC_SaveDeviceSystem_Error,
		// Token: 0x040001B7 RID: 439
		[global::System.Runtime.Serialization.EnumMember]
		RMC_LoadDevices_Error,
		// Token: 0x040001B8 RID: 440
		[global::System.Runtime.Serialization.EnumMember]
		RMC_CantConnectWebService,
		// Token: 0x040001B9 RID: 441
		[global::System.Runtime.Serialization.EnumMember]
		RMC_ClientCertificateNotFound,
		// Token: 0x040001BA RID: 442
		[global::System.Runtime.Serialization.EnumMember]
		RMC_ServerCertificateNotFound,
		// Token: 0x040001BB RID: 443
		[global::System.Runtime.Serialization.EnumMember]
		RMC_ValidateAstroCompatibility_Error,
		// Token: 0x040001BC RID: 444
		[global::System.Runtime.Serialization.EnumMember]
		RMC_InvalidDevice_Error,
		// Token: 0x040001BD RID: 445
		[global::System.Runtime.Serialization.EnumMember]
		RMC_ExportCodeplug_Error,
		// Token: 0x040001BE RID: 446
		[global::System.Runtime.Serialization.EnumMember]
		RMC_NewDevice_Error,
		// Token: 0x040001BF RID: 447
		[global::System.Runtime.Serialization.EnumMember]
		RMC_ExportFile_Error,
		// Token: 0x040001C0 RID: 448
		[global::System.Runtime.Serialization.EnumMember]
		RMC_Print_Error,
		// Token: 0x040001C1 RID: 449
		[global::System.Runtime.Serialization.EnumMember]
		RMC_PrintPreview_Error,
		// Token: 0x040001C2 RID: 450
		[global::System.Runtime.Serialization.EnumMember]
		RMC_EditCodeplug_DeviceRemoved,
		// Token: 0x040001C3 RID: 451
		[global::System.Runtime.Serialization.EnumMember]
		RMC_MoveDevice_Error,
		// Token: 0x040001C4 RID: 452
		[global::System.Runtime.Serialization.EnumMember]
		RMC_GeneralFaultException,
		// Token: 0x040001C5 RID: 453
		[global::System.Runtime.Serialization.EnumMember]
		RMC_UnableToWriteTheFollowingArchive,
		// Token: 0x040001C6 RID: 454
		[global::System.Runtime.Serialization.EnumMember]
		RMC_UnableToReadTheFollowingArchive,
		// Token: 0x040001C7 RID: 455
		[global::System.Runtime.Serialization.EnumMember]
		RMC_UnableToCloseRMCWithArchivesOpened,
		// Token: 0x040001C8 RID: 456
		[global::System.Runtime.Serialization.EnumMember]
		RMC_UnableToInitializeRMC,
		// Token: 0x040001C9 RID: 457
		[global::System.Runtime.Serialization.EnumMember]
		RMC_UnableToRecordToCSV,
		// Token: 0x040001CA RID: 458
		[global::System.Runtime.Serialization.EnumMember]
		RMC_HasCodeplugOpened,
		// Token: 0x040001CB RID: 459
		[global::System.Runtime.Serialization.EnumMember]
		RMC_HasCustomViewSelected,
		// Token: 0x040001CC RID: 460
		[global::System.Runtime.Serialization.EnumMember]
		RMC_RestoreDevice_Error,
		// Token: 0x040001CD RID: 461
		[global::System.Runtime.Serialization.EnumMember]
		RMC_CannotImportRepeater,
		// Token: 0x040001CE RID: 462
		[global::System.Runtime.Serialization.EnumMember]
		RMC_ImportedArchiveIsNotSupported,
		// Token: 0x040001CF RID: 463
		[global::System.Runtime.Serialization.EnumMember]
		RMC_ObsoleteView,
		// Token: 0x040001D0 RID: 464
		[global::System.Runtime.Serialization.EnumMember]
		RMC_Help_Error,
		// Token: 0x040001D1 RID: 465
		[global::System.Runtime.Serialization.EnumMember]
		RMC_CommunicationServerNotAvailabe,
		// Token: 0x040001D2 RID: 466
		[global::System.Runtime.Serialization.EnumMember]
		RMC_CommunicationServerCommunicationError,
		// Token: 0x040001D3 RID: 467
		[global::System.Runtime.Serialization.EnumMember]
		RMC_CommunicationServerTimeout,
		// Token: 0x040001D4 RID: 468
		[global::System.Runtime.Serialization.EnumMember]
		RMC_LoadingTooMuchDataRecords,
		// Token: 0x040001D5 RID: 469
		[global::System.Runtime.Serialization.EnumMember]
		RMC_FileContentMissing,
		// Token: 0x040001D6 RID: 470
		[global::System.Runtime.Serialization.EnumMember]
		RMC_Package_NotExist_Error,
		// Token: 0x040001D7 RID: 471
		[global::System.Runtime.Serialization.EnumMember]
		RMC_ServerPackageNotFound_Error,
		// Token: 0x040001D8 RID: 472
		[global::System.Runtime.Serialization.EnumMember]
		RMC_AddJob_Error,
		// Token: 0x040001D9 RID: 473
		[global::System.Runtime.Serialization.EnumMember]
		RMC_AddMultipleSets_Error,
		// Token: 0x040001DA RID: 474
		[global::System.Runtime.Serialization.EnumMember]
		RMC_Invalid_Data_Export,
		// Token: 0x040001DB RID: 475
		[global::System.Runtime.Serialization.EnumMember]
		RMC_Sfc_No_Features_On_Server,
		// Token: 0x040001DC RID: 476
		[global::System.Runtime.Serialization.EnumMember]
		RMC_CannotGetFileContentWhenSelectTemplate,
		// Token: 0x040001DD RID: 477
		[global::System.Runtime.Serialization.EnumMember]
		Radio_Already_Applied_This_Configuration,
		// Token: 0x040001DE RID: 478
		[global::System.Runtime.Serialization.EnumMember]
		RMC_MatrixKeyID_Error,
		// Token: 0x040001DF RID: 479
		[global::System.Runtime.Serialization.EnumMember]
		RMC_MatrixKeyID_NotExist,
		// Token: 0x040001E0 RID: 480
		[global::System.Runtime.Serialization.EnumMember]
		RMC_RadioNotExist,
		// Token: 0x040001E1 RID: 481
		[global::System.Runtime.Serialization.EnumMember]
		RMC_DeviceNotExist,
		// Token: 0x040001E2 RID: 482
		[global::System.Runtime.Serialization.EnumMember]
		RMC_TemplateNotExist,
		// Token: 0x040001E3 RID: 483
		[global::System.Runtime.Serialization.EnumMember]
		RMC_ConfigurationNotExist,
		// Token: 0x040001E4 RID: 484
		[global::System.Runtime.Serialization.EnumMember]
		RMC_RadioNotHaveConfiguration,
		// Token: 0x040001E5 RID: 485
		[global::System.Runtime.Serialization.EnumMember]
		RMC_Disable_Apply_ASK_Enabled_Configuraion_To_Non_ASK_Radio,
		// Token: 0x040001E6 RID: 486
		[global::System.Runtime.Serialization.EnumMember]
		RMC_SameSeriesNumberExist,
		// Token: 0x040001E7 RID: 487
		[global::System.Runtime.Serialization.EnumMember]
		RMC_InvalidDeviceUuid,
		// Token: 0x040001E8 RID: 488
		[global::System.Runtime.Serialization.EnumMember]
		RMC_CodeplugNotExist,
		// Token: 0x040001E9 RID: 489
		[global::System.Runtime.Serialization.EnumMember]
		RMC_GeneralLicensing_Error,
		// Token: 0x040001EA RID: 490
		[global::System.Runtime.Serialization.EnumMember]
		RMC_ImportTemplate_ReadError,
		// Token: 0x040001EB RID: 491
		[global::System.Runtime.Serialization.EnumMember]
		RMC_Restore_TemplateDeleted_Error,
		// Token: 0x040001EC RID: 492
		[global::System.Runtime.Serialization.EnumMember]
		RMC_Restore_ASTRO_ShallNotShutOffWriteProtected,
		// Token: 0x040001ED RID: 493
		[global::System.Runtime.Serialization.EnumMember]
		RMC_Restore_ASTRO_SecurityPartitionShallNotModified,
		// Token: 0x040001EE RID: 494
		[global::System.Runtime.Serialization.EnumMember]
		RMC_Restore_ASTRO_CPMajorShallNoLessThanFWMajor,
		// Token: 0x040001EF RID: 495
		[global::System.Runtime.Serialization.EnumMember]
		RMC_Restore_HistoryPbaNotExist,
		// Token: 0x040001F0 RID: 496
		[global::System.Runtime.Serialization.EnumMember]
		RMC_Template_Deleted_Error,
		// Token: 0x040001F1 RID: 497
		[global::System.Runtime.Serialization.EnumMember]
		RMC_ExportConfiguration_HasUnloadSet,
		// Token: 0x040001F2 RID: 498
		[global::System.Runtime.Serialization.EnumMember]
		RMC_ExportConfiguration_WriteArchiveFailed,
		// Token: 0x040001F3 RID: 499
		[global::System.Runtime.Serialization.EnumMember]
		RMC_ExportConfiguration_ConfigurationNotFound,
		// Token: 0x040001F4 RID: 500
		[global::System.Runtime.Serialization.EnumMember]
		RMC_ExportConfiguration_CorruptConfiguration,
		// Token: 0x040001F5 RID: 501
		[global::System.Runtime.Serialization.EnumMember]
		RMC_ImportConfiguration_ReadArchiveFailed,
		// Token: 0x040001F6 RID: 502
		[global::System.Runtime.Serialization.EnumMember]
		RMC_ImportConfiguration_InvaildFileFormat,
		// Token: 0x040001F7 RID: 503
		[global::System.Runtime.Serialization.EnumMember]
		RMC_ImportConfiguration_IncorrectPAC,
		// Token: 0x040001F8 RID: 504
		[global::System.Runtime.Serialization.EnumMember]
		RMC_ImportConfiguration_Error,
		// Token: 0x040001F9 RID: 505
		[global::System.Runtime.Serialization.EnumMember]
		RMC_LoadingGridView_Error,
		// Token: 0x040001FA RID: 506
		[global::System.Runtime.Serialization.EnumMember]
		RMC_AddSet_MaximumPoolNumberAreReached,
		// Token: 0x040001FB RID: 507
		[global::System.Runtime.Serialization.EnumMember]
		RMC_AddOneSetCopies_Error,
		// Token: 0x040001FC RID: 508
		[global::System.Runtime.Serialization.EnumMember]
		RMC_AddOneSetCopies_MaximumPoolNumberAreReached,
		// Token: 0x040001FD RID: 509
		[global::System.Runtime.Serialization.EnumMember]
		RMC_CopySet_Error,
		// Token: 0x040001FE RID: 510
		[global::System.Runtime.Serialization.EnumMember]
		RMC_CopySetFrom_Error,
		// Token: 0x040001FF RID: 511
		[global::System.Runtime.Serialization.EnumMember]
		RMC_CopySetFrom_AliasNameTrkSys_SystemKeyNotLoaded,
		// Token: 0x04000200 RID: 512
		[global::System.Runtime.Serialization.EnumMember]
		RMC_SaveAsSet_Error,
		// Token: 0x04000201 RID: 513
		[global::System.Runtime.Serialization.EnumMember]
		RMC_SetSave_Error,
		// Token: 0x04000202 RID: 514
		[global::System.Runtime.Serialization.EnumMember]
		RMC_AssignSet_Error,
		// Token: 0x04000203 RID: 515
		[global::System.Runtime.Serialization.EnumMember]
		RMC_SetEditorLocation_Error,
		// Token: 0x04000204 RID: 516
		[global::System.Runtime.Serialization.EnumMember]
		RMC_RemoveSet_Error,
		// Token: 0x04000205 RID: 517
		[global::System.Runtime.Serialization.EnumMember]
		RMC_LoadConfiguration_Error,
		// Token: 0x04000206 RID: 518
		[global::System.Runtime.Serialization.EnumMember]
		RMC_LoadConfiguration_CanNotFindRadio_Error,
		// Token: 0x04000207 RID: 519
		[global::System.Runtime.Serialization.EnumMember]
		RMC_LoadSet_Error,
		// Token: 0x04000208 RID: 520
		[global::System.Runtime.Serialization.EnumMember]
		RMC_SpellCheck_Error,
		// Token: 0x04000209 RID: 521
		[global::System.Runtime.Serialization.EnumMember]
		RMC_SpellCheck_Error_FailedToGetRadio,
		// Token: 0x0400020A RID: 522
		[global::System.Runtime.Serialization.EnumMember]
		RMC_SpellCheck_Error_FailedToGetConfiguration,
		// Token: 0x0400020B RID: 523
		[global::System.Runtime.Serialization.EnumMember]
		RMC_SpellCheck_Error_FailedToGetCodeplug,
		// Token: 0x0400020C RID: 524
		[global::System.Runtime.Serialization.EnumMember]
		RMC_SpellCheck_Error_FailedToResetField,
		// Token: 0x0400020D RID: 525
		[global::System.Runtime.Serialization.EnumMember]
		RMC_SpellCheck_Error_FailedToResetFieldDependOnOtherField,
		// Token: 0x0400020E RID: 526
		[global::System.Runtime.Serialization.EnumMember]
		RMC_SpellCheck_Error_OutOfDate,
		// Token: 0x0400020F RID: 527
		[global::System.Runtime.Serialization.EnumMember]
		RMC_MoveSet_Error,
		// Token: 0x04000210 RID: 528
		[global::System.Runtime.Serialization.EnumMember]
		RMC_UpdateSetName_Error,
		// Token: 0x04000211 RID: 529
		[global::System.Runtime.Serialization.EnumMember]
		RMC_SelectSet_Error,
		// Token: 0x04000212 RID: 530
		[global::System.Runtime.Serialization.EnumMember]
		RMC_SRO_Error_NoAvailableDevice,
		// Token: 0x04000213 RID: 531
		[global::System.Runtime.Serialization.EnumMember]
		RMC_SRO_Error_FailedToReadDevice,
		// Token: 0x04000214 RID: 532
		[global::System.Runtime.Serialization.EnumMember]
		RMC_SRO_Error_FailedToCorrectRadioIdentity,
		// Token: 0x04000215 RID: 533
		[global::System.Runtime.Serialization.EnumMember]
		RMC_SRO_Error_FailedToGetOpenedConfiguration,
		// Token: 0x04000216 RID: 534
		[global::System.Runtime.Serialization.EnumMember]
		RMC_UnableToFindVAFile,
		// Token: 0x04000217 RID: 535
		[global::System.Runtime.Serialization.EnumMember]
		RMC_InvalidVAFile,
		// Token: 0x04000218 RID: 536
		[global::System.Runtime.Serialization.EnumMember]
		RMC_InvalidTTSFile,
		// Token: 0x04000219 RID: 537
		[global::System.Runtime.Serialization.EnumMember]
		RMC_InvalidVAFile_FileNameOutOfRange,
		// Token: 0x0400021A RID: 538
		[global::System.Runtime.Serialization.EnumMember]
		RMC_ASTROInvalidVAFile_FileNameOutOfRange,
		// Token: 0x0400021B RID: 539
		[global::System.Runtime.Serialization.EnumMember]
		RMC_UnableToConvertVAFileToMVAFormat,
		// Token: 0x0400021C RID: 540
		[global::System.Runtime.Serialization.EnumMember]
		RMC_ReadingLanguagePack_Error,
		// Token: 0x0400021D RID: 541
		[global::System.Runtime.Serialization.EnumMember]
		RMC_PackageAndFileHasAlreadyExistedOnServer,
		// Token: 0x0400021E RID: 542
		[global::System.Runtime.Serialization.EnumMember]
		RMC_PM_ArgumentMismatch,
		// Token: 0x0400021F RID: 543
		[global::System.Runtime.Serialization.EnumMember]
		RMC_UnableToParseFWFile,
		// Token: 0x04000220 RID: 544
		[global::System.Runtime.Serialization.EnumMember]
		RMC_PM_CannotUploadEmptyFile,
		// Token: 0x04000221 RID: 545
		[global::System.Runtime.Serialization.EnumMember]
		RMC_PM_FileAccess_Error,
		// Token: 0x04000222 RID: 546
		[global::System.Runtime.Serialization.EnumMember]
		RMC_PM_NoPairsInGroup,
		// Token: 0x04000223 RID: 547
		[global::System.Runtime.Serialization.EnumMember]
		RMC_PM_UploadVAPackage_Error,
		// Token: 0x04000224 RID: 548
		[global::System.Runtime.Serialization.EnumMember]
		RMC_PM_UpgradeCodeplugFailed,
		// Token: 0x04000225 RID: 549
		[global::System.Runtime.Serialization.EnumMember]
		RMC_PM_UpdateCodeplugFailed,
		// Token: 0x04000226 RID: 550
		[global::System.Runtime.Serialization.EnumMember]
		RMC_PM_ConvertData_Error,
		// Token: 0x04000227 RID: 551
		[global::System.Runtime.Serialization.EnumMember]
		RMC_PM_CpsDidntReturnInfo,
		// Token: 0x04000228 RID: 552
		[global::System.Runtime.Serialization.EnumMember]
		RMC_PM_RMCDidntFindPackageToImport,
		// Token: 0x04000229 RID: 553
		[global::System.Runtime.Serialization.EnumMember]
		RMC_PM_FileNotFoundException,
		// Token: 0x0400022A RID: 554
		[global::System.Runtime.Serialization.EnumMember]
		RMC_PM_UploadingCanceled,
		// Token: 0x0400022B RID: 555
		[global::System.Runtime.Serialization.EnumMember]
		RMC_PM_AddFileToServer_Error,
		// Token: 0x0400022C RID: 556
		[global::System.Runtime.Serialization.EnumMember]
		RMC_PM_CommentsHadBeenAddedByOtherPerson,
		// Token: 0x0400022D RID: 557
		[global::System.Runtime.Serialization.EnumMember]
		CPSDidntReturnRegion,
		// Token: 0x0400022E RID: 558
		[global::System.Runtime.Serialization.EnumMember]
		RMC_ValidateCFSFailed,
		// Token: 0x0400022F RID: 559
		[global::System.Runtime.Serialization.EnumMember]
		RMC_ServerFirmwarePackageNotFound_Error,
		// Token: 0x04000230 RID: 560
		[global::System.Runtime.Serialization.EnumMember]
		RMC_AstroLanguagePackMismatch,
		// Token: 0x04000231 RID: 561
		[global::System.Runtime.Serialization.EnumMember]
		RMC_VA_Duration_Out_Of_Range,
		// Token: 0x04000232 RID: 562
		[global::System.Runtime.Serialization.EnumMember]
		RMC_ASTRO_LP_Package_Invalid,
		// Token: 0x04000233 RID: 563
		[global::System.Runtime.Serialization.EnumMember]
		RMC_DeviceHasIncorrectFWVersion,
		// Token: 0x04000234 RID: 564
		[global::System.Runtime.Serialization.EnumMember]
		RMC_PM_HasDuplicatePCRFWPackage,
		// Token: 0x04000235 RID: 565
		[global::System.Runtime.Serialization.EnumMember]
		Licenses_Error_No_FW,
		// Token: 0x04000236 RID: 566
		[global::System.Runtime.Serialization.EnumMember]
		RMC_License_Error_Empty_EID,
		// Token: 0x04000237 RID: 567
		[global::System.Runtime.Serialization.EnumMember]
		Licenses_Recover_Com_BackOfficeServer_NullError,
		// Token: 0x04000238 RID: 568
		[global::System.Runtime.Serialization.EnumMember]
		RMC_License_Error_Not_Supported,
		// Token: 0x04000239 RID: 569
		[global::System.Runtime.Serialization.EnumMember]
		RMC_License_Error_No_Count,
		// Token: 0x0400023A RID: 570
		[global::System.Runtime.Serialization.EnumMember]
		RMC_License_Error_Already_Registered,
		// Token: 0x0400023B RID: 571
		[global::System.Runtime.Serialization.EnumMember]
		RMC_License_Error_Connect_Timeout,
		// Token: 0x0400023C RID: 572
		[global::System.Runtime.Serialization.EnumMember]
		RMC_License_Error_Unknown,
		// Token: 0x0400023D RID: 573
		[global::System.Runtime.Serialization.EnumMember]
		RMC_License_Pcr_No_Upgrade_Ability,
		// Token: 0x0400023E RID: 574
		[global::System.Runtime.Serialization.EnumMember]
		RMC_License_Pcr_No_Upgrade_Packages,
		// Token: 0x0400023F RID: 575
		[global::System.Runtime.Serialization.EnumMember]
		RMC_License_FNP_Not_Supported,
		// Token: 0x04000240 RID: 576
		[global::System.Runtime.Serialization.EnumMember]
		RMC_Licenses_Submit_Err_Feature_Invalid,
		// Token: 0x04000241 RID: 577
		[global::System.Runtime.Serialization.EnumMember]
		RMC_Licenses_Warning_No_Feature_Changed,
		// Token: 0x04000242 RID: 578
		[global::System.Runtime.Serialization.EnumMember]
		RMC_SystemServer_Error_GetHostID,
		// Token: 0x04000243 RID: 579
		[global::System.Runtime.Serialization.EnumMember]
		RMC_Radio_Feature_Mismatched,
		// Token: 0x04000244 RID: 580
		[global::System.Runtime.Serialization.EnumMember]
		RMC_Local_Data_Outof_Date,
		// Token: 0x04000245 RID: 581
		[global::System.Runtime.Serialization.EnumMember]
		RMC_Exception_ImportCP_ExistedDevice,
		// Token: 0x04000246 RID: 582
		[global::System.Runtime.Serialization.EnumMember]
		RMC_ImportCodeplug_CFS_Dismatch,
		// Token: 0x04000247 RID: 583
		[global::System.Runtime.Serialization.EnumMember]
		RMC_ImportCodeplug_CPVersion_Dismatch,
		// Token: 0x04000248 RID: 584
		[global::System.Runtime.Serialization.EnumMember]
		RMC_ImportCodeplug_Override_Error,
		// Token: 0x04000249 RID: 585
		[global::System.Runtime.Serialization.EnumMember]
		RMC_ImportCodeplug_Warning_State,
		// Token: 0x0400024A RID: 586
		[global::System.Runtime.Serialization.EnumMember]
		RMC_RadioZFWChanged_NotSupport_WorkingCodeplugBeReplaced,
		// Token: 0x0400024B RID: 587
		[global::System.Runtime.Serialization.EnumMember]
		RMC_Warning_ImportCP_FlashCodeChanged_Override,
		// Token: 0x0400024C RID: 588
		[global::System.Runtime.Serialization.EnumMember]
		RMC_The_codeplug_contains_invalid_fields,
		// Token: 0x0400024D RID: 589
		[global::System.Runtime.Serialization.EnumMember]
		RMC_File_colon_Cannot_Open_Old_CP_NonEng,
		// Token: 0x0400024E RID: 590
		[global::System.Runtime.Serialization.EnumMember]
		RMC_File_colon_could_not_be_opened,
		// Token: 0x0400024F RID: 591
		[global::System.Runtime.Serialization.EnumMember]
		RMC_Invalid_Incorrect_Password,
		// Token: 0x04000250 RID: 592
		[global::System.Runtime.Serialization.EnumMember]
		RMC_AnaysisPackageFailed,
		// Token: 0x04000251 RID: 593
		[global::System.Runtime.Serialization.EnumMember]
		Failure_due_to_mismatch_of_Codeplug_Used_FLASHcode_and_Radio_FLASHcode,
		// Token: 0x04000252 RID: 594
		[global::System.Runtime.Serialization.EnumMember]
		InvalidRadiosPendingJobForJobScheduleTips,
		// Token: 0x04000253 RID: 595
		[global::System.Runtime.Serialization.EnumMember]
		InvalidRadiosForAstroWriteTips,
		// Token: 0x04000254 RID: 596
		[global::System.Runtime.Serialization.EnumMember]
		MustHaveConfigurationForWriteJob,
		// Token: 0x04000255 RID: 597
		[global::System.Runtime.Serialization.EnumMember]
		InvalidRadiosForSwitchoverTips,
		// Token: 0x04000256 RID: 598
		[global::System.Runtime.Serialization.EnumMember]
		InvalidRadiosForOTAP,
		// Token: 0x04000257 RID: 599
		[global::System.Runtime.Serialization.EnumMember]
		RMC_ScheduleJob_LimitOTAPforAstroFwLp,
		// Token: 0x04000258 RID: 600
		[global::System.Runtime.Serialization.EnumMember]
		RMC_ScheduleJob_LimitOTAPforAstroLicense,
		// Token: 0x04000259 RID: 601
		[global::System.Runtime.Serialization.EnumMember]
		RMC_CannotApplyTemplateWithLP_To_ImcompatibleDevice,
		// Token: 0x0400025A RID: 602
		[global::System.Runtime.Serialization.EnumMember]
		AstroPost7_12Radio_Need_TemplateContainLP,
		// Token: 0x0400025B RID: 603
		[global::System.Runtime.Serialization.EnumMember]
		RMC_LP_Not_Supported_By_this_radio,
		// Token: 0x0400025C RID: 604
		[global::System.Runtime.Serialization.EnumMember]
		RMC_Invalid_Field_Value,
		// Token: 0x0400025D RID: 605
		[global::System.Runtime.Serialization.EnumMember]
		Error_NoOTAPAuthorizationKey,
		// Token: 0x0400025E RID: 606
		[global::System.Runtime.Serialization.EnumMember]
		RMC_Write_Not_Supported_Codeplug_Version,
		// Token: 0x0400025F RID: 607
		[global::System.Runtime.Serialization.EnumMember]
		RMC_PM_Duplicate,
		// Token: 0x04000260 RID: 608
		[global::System.Runtime.Serialization.EnumMember]
		Invalid_RadioID_For_OTA,
		// Token: 0x04000261 RID: 609
		[global::System.Runtime.Serialization.EnumMember]
		Invalid_CAI_For_OTA,
		// Token: 0x04000262 RID: 610
		[global::System.Runtime.Serialization.EnumMember]
		RMC_Invalid_ProductFamily_For_OTA,
		// Token: 0x04000263 RID: 611
		[global::System.Runtime.Serialization.EnumMember]
		RMC_Invalid_RadioID_For_RRP,
		// Token: 0x04000264 RID: 612
		[global::System.Runtime.Serialization.EnumMember]
		RMC_Invalid_LinkType_For_RRP,
		// Token: 0x04000265 RID: 613
		[global::System.Runtime.Serialization.EnumMember]
		RMC_Invalid_MasterIP_For_RRP,
		// Token: 0x04000266 RID: 614
		[global::System.Runtime.Serialization.EnumMember]
		RMC_Invalid_MasterUDPPort_For_RRP,
		// Token: 0x04000267 RID: 615
		[global::System.Runtime.Serialization.EnumMember]
		RMC_Invalid_AuthenticationKey_For_RRP,
		// Token: 0x04000268 RID: 616
		[global::System.Runtime.Serialization.EnumMember]
		RMC_Invalid_ProductFamily_For_RRP,
		// Token: 0x04000269 RID: 617
		[global::System.Runtime.Serialization.EnumMember]
		RMC_Invalid_Error_FailedToResetField,
		// Token: 0x0400026A RID: 618
		[global::System.Runtime.Serialization.EnumMember]
		DoNotAllowOTAPIfFwChanged,
		// Token: 0x0400026B RID: 619
		[global::System.Runtime.Serialization.EnumMember]
		DeviceLinkedFirmwarePackageNotExistOnServer,
		// Token: 0x0400026C RID: 620
		[global::System.Runtime.Serialization.EnumMember]
		DeviceLinkedFirmwareFilesNotExistOnServer,
		// Token: 0x0400026D RID: 621
		[global::System.Runtime.Serialization.EnumMember]
		DeviceLinkedLanguagePackagesIsNull,
		// Token: 0x0400026E RID: 622
		[global::System.Runtime.Serialization.EnumMember]
		DeviceLinkedLanguagePackagesNotExistOnServer,
		// Token: 0x0400026F RID: 623
		[global::System.Runtime.Serialization.EnumMember]
		DeviceLinkedLanguageFilesNotExistOnServer,
		// Token: 0x04000270 RID: 624
		[global::System.Runtime.Serialization.EnumMember]
		DeviceLinkedVoicesPackagesIsNull,
		// Token: 0x04000271 RID: 625
		[global::System.Runtime.Serialization.EnumMember]
		DeviceLinkedTTSPackagesIsNull,
		// Token: 0x04000272 RID: 626
		[global::System.Runtime.Serialization.EnumMember]
		DeviceLinkedVoicePackagesNotExistOnServer,
		// Token: 0x04000273 RID: 627
		[global::System.Runtime.Serialization.EnumMember]
		DeviceLinkedTTSPackagesNotExistOnServer,
		// Token: 0x04000274 RID: 628
		[global::System.Runtime.Serialization.EnumMember]
		DeviceLinkedVoiceFilesNotExistOnServer,
		// Token: 0x04000275 RID: 629
		[global::System.Runtime.Serialization.EnumMember]
		DeviceLinkedTTSFilesNotExistOnServer,
		// Token: 0x04000276 RID: 630
		[global::System.Runtime.Serialization.EnumMember]
		RMC_ScheduleJob_LimitOTAPforPCRLicense,
		// Token: 0x04000277 RID: 631
		[global::System.Runtime.Serialization.EnumMember]
		RMC_ApplicationCFS_25HKZ_Validate_Error,
		// Token: 0x04000278 RID: 632
		[global::System.Runtime.Serialization.EnumMember]
		RMC_ApplicationCFS_SpainFreq_Validate_Error,
		// Token: 0x04000279 RID: 633
		[global::System.Runtime.Serialization.EnumMember]
		RMC_ApplicationCFS_NPSPAC_Validate_Error,
		// Token: 0x0400027A RID: 634
		[global::System.Runtime.Serialization.EnumMember]
		RMC_ApplicationCFS_NonSpainFreq_Validate_Error,
		// Token: 0x0400027B RID: 635
		[global::System.Runtime.Serialization.EnumMember]
		RMC_Firmware_NotExist,
		// Token: 0x0400027C RID: 636
		[global::System.Runtime.Serialization.EnumMember]
		RMC_FlashKey_ValidateFailed,
		// Token: 0x0400027D RID: 637
		[global::System.Runtime.Serialization.EnumMember]
		RMC_FlashKey_NotFound,
		// Token: 0x0400027E RID: 638
		[global::System.Runtime.Serialization.EnumMember]
		RMC_FlashKeyReminingCountNotEnough,
		// Token: 0x0400027F RID: 639
		[global::System.Runtime.Serialization.EnumMember]
		RMC_FlashKeyDecraseFailed,
		// Token: 0x04000280 RID: 640
		[global::System.Runtime.Serialization.EnumMember]
		RMC_NoItem_Selected,
		// Token: 0x04000281 RID: 641
		[global::System.Runtime.Serialization.EnumMember]
		RMC_WrongPACFile_ImportPBA,
		// Token: 0x04000282 RID: 642
		[global::System.Runtime.Serialization.EnumMember]
		RMC_DMR3_ImportPBA_NotSupport,
		// Token: 0x04000283 RID: 643
		[global::System.Runtime.Serialization.EnumMember]
		RMC_ImportPBA_ParseFileFail,
		// Token: 0x04000284 RID: 644
		[global::System.Runtime.Serialization.EnumMember]
		RMC_invalid_flashcode,
		// Token: 0x04000285 RID: 645
		[global::System.Runtime.Serialization.EnumMember]
		RMC_OpenFileFail,
		// Token: 0x04000286 RID: 646
		[global::System.Runtime.Serialization.EnumMember]
		RMC_RadioID_SystemKeyNotAllow,
		// Token: 0x04000287 RID: 647
		[global::System.Runtime.Serialization.EnumMember]
		RMC_RadioID_NotLoadSystemKey,
		// Token: 0x04000288 RID: 648
		[global::System.Runtime.Serialization.EnumMember]
		Error_RadioID_Contain_F,
		// Token: 0x04000289 RID: 649
		[global::System.Runtime.Serialization.EnumMember]
		Error_RadioID_Empty,
		// Token: 0x0400028A RID: 650
		[global::System.Runtime.Serialization.EnumMember]
		Error_RadioID_OutOfRange,
		// Token: 0x0400028B RID: 651
		[global::System.Runtime.Serialization.EnumMember]
		Error_RadioID_DupWithTgIDs,
		// Token: 0x0400028C RID: 652
		[global::System.Runtime.Serialization.EnumMember]
		RMC_EmptyFileName_Error,
		// Token: 0x0400028D RID: 653
		[global::System.Runtime.Serialization.EnumMember]
		RMC_ImportRadio_InvalidFields,
		// Token: 0x0400028E RID: 654
		[global::System.Runtime.Serialization.EnumMember]
		RMC_FilePathTooLong_Error,
		// Token: 0x0400028F RID: 655
		[global::System.Runtime.Serialization.EnumMember]
		RMC_ImportPBA_RegionMismatch,
		// Token: 0x04000290 RID: 656
		[global::System.Runtime.Serialization.EnumMember]
		RMC_ImportCSV_RegionMismatch,
		// Token: 0x04000291 RID: 657
		[global::System.Runtime.Serialization.EnumMember]
		RMC_ExportRadio_ConfigMismatch,
		// Token: 0x04000292 RID: 658
		[global::System.Runtime.Serialization.EnumMember]
		RMC_ScheduleJob_AppOptionMismatch_NPSPAC,
		// Token: 0x04000293 RID: 659
		[global::System.Runtime.Serialization.EnumMember]
		RMC_ScheduleJob_AppOptionMismatch_25KHZ,
		// Token: 0x04000294 RID: 660
		[global::System.Runtime.Serialization.EnumMember]
		RMC_ScheduleJob_AppOptionMismatch_RRP,
		// Token: 0x04000295 RID: 661
		[global::System.Runtime.Serialization.EnumMember]
		RMC_ScheduleJob_OnlyAllowRRPForMatrixRepeaterFWUpgrade,
		// Token: 0x04000296 RID: 662
		[global::System.Runtime.Serialization.EnumMember]
		RMC_ChangeRMUserPassword_PasswordNotSame,
		// Token: 0x04000297 RID: 663
		[global::System.Runtime.Serialization.EnumMember]
		RMC_ChangeRMUserPassword_ConnectionToDiscoveryFailed,
		// Token: 0x04000298 RID: 664
		[global::System.Runtime.Serialization.EnumMember]
		RMC_ChangeRMUserPassword_ChangePasswordFailed,
		// Token: 0x04000299 RID: 665
		[global::System.Runtime.Serialization.EnumMember]
		RMC_NoMoreSetToDelete,
		// Token: 0x0400029A RID: 666
		[global::System.Runtime.Serialization.EnumMember]
		RMC_CODEPLUGPASSWORD_GUID_IS_NULL,
		// Token: 0x0400029B RID: 667
		[global::System.Runtime.Serialization.EnumMember]
		RMC_CODEPLUGPASSWORD_RECORD_IS_NOT_EXIST,
		// Token: 0x0400029C RID: 668
		[global::System.Runtime.Serialization.EnumMember]
		RMC_NOTHING_TO_REGISTER,
		// Token: 0x0400029D RID: 669
		[global::System.Runtime.Serialization.EnumMember]
		RMC_DuplicateDeviceID_ParadiseMsg,
		// Token: 0x0400029E RID: 670
		[global::System.Runtime.Serialization.EnumMember]
		RMC_DuplicateDeviceID_RepeaterMsg,
		// Token: 0x0400029F RID: 671
		[global::System.Runtime.Serialization.EnumMember]
		RMC_DuplicateDeviceID_ControllerMsg,
		// Token: 0x040002A0 RID: 672
		[global::System.Runtime.Serialization.EnumMember]
		RMC_DuplicateDeviceID_OtherMsg,
		// Token: 0x040002A1 RID: 673
		[global::System.Runtime.Serialization.EnumMember]
		RMC_ImportCSV_WrongQuote,
		// Token: 0x040002A2 RID: 674
		[global::System.Runtime.Serialization.EnumMember]
		RMC_InvalidField_For_ImportCSV,
		// Token: 0x040002A3 RID: 675
		[global::System.Runtime.Serialization.EnumMember]
		RMC_CSVFileFormat_Error,
		// Token: 0x040002A4 RID: 676
		[global::System.Runtime.Serialization.EnumMember]
		RMC_ImportCsv_FileCantBeOpened,
		// Token: 0x040002A5 RID: 677
		[global::System.Runtime.Serialization.EnumMember]
		RMC_ImportCsv_OneOperation_Fail,
		// Token: 0x040002A6 RID: 678
		[global::System.Runtime.Serialization.EnumMember]
		RMC_CSVField_DelChar,
		// Token: 0x040002A7 RID: 679
		[global::System.Runtime.Serialization.EnumMember]
		RMC_GetMVO_Error,
		// Token: 0x040002A8 RID: 680
		[global::System.Runtime.Serialization.EnumMember]
		RMC_PBB_Fail_To_Open_FW_Package,
		// Token: 0x040002A9 RID: 681
		[global::System.Runtime.Serialization.EnumMember]
		RMC_PBB_Fail_To_Parse_FW_Package_Model,
		// Token: 0x040002AA RID: 682
		[global::System.Runtime.Serialization.EnumMember]
		RMC_PBB_No_Version_File,
		// Token: 0x040002AB RID: 683
		[global::System.Runtime.Serialization.EnumMember]
		RMC_PBB_No_Version_Segament,
		// Token: 0x040002AC RID: 684
		[global::System.Runtime.Serialization.EnumMember]
		RMC_PBB_Fail_To_Open_Version_File,
		// Token: 0x040002AD RID: 685
		[global::System.Runtime.Serialization.EnumMember]
		RMC_PBB_Fail_To_Open_Package,
		// Token: 0x040002AE RID: 686
		[global::System.Runtime.Serialization.EnumMember]
		RMC_PBB_Fail_To_Open_App_Package,
		// Token: 0x040002AF RID: 687
		[global::System.Runtime.Serialization.EnumMember]
		RMC_ImportCSV_RegionMismatchWithCopiedRadio,
		// Token: 0x040002B0 RID: 688
		[global::System.Runtime.Serialization.EnumMember]
		RMC_PBB_Fail_UE_File_Upload_Not_For_RM,
		// Token: 0x040002B1 RID: 689
		[global::System.Runtime.Serialization.EnumMember]
		RMC_PBB_Fail_UE_File_Upload_CanNot_Contains_LMRCodePlug,
		// Token: 0x040002B2 RID: 690
		[global::System.Runtime.Serialization.EnumMember]
		RMC_PBB_Fail_UE_File_Type_Format_is_Incorrect,
		// Token: 0x040002B3 RID: 691
		[global::System.Runtime.Serialization.EnumMember]
		RMC_ImportCSV_SAC_DuplicateDeviceIDExists,
		// Token: 0x040002B4 RID: 692
		[global::System.Runtime.Serialization.EnumMember]
		RMC_ImportCSV_TGSA_DuplicateTalkGroupIDExists,
		// Token: 0x040002B5 RID: 693
		[global::System.Runtime.Serialization.EnumMember]
		RMC_PBB_Fail_To_Parse_APK_Package,
		// Token: 0x040002B6 RID: 694
		[global::System.Runtime.Serialization.EnumMember]
		RMC_PBB_Fail_To_Add_APK_Already_Exist,
		// Token: 0x040002B7 RID: 695
		[global::System.Runtime.Serialization.EnumMember]
		RMC_PBB_Fail_To_Caculate_Hash_Code,
		// Token: 0x040002B8 RID: 696
		RMC_PBB_No_Widgets_In_APK,
		// Token: 0x040002B9 RID: 697
		[global::System.Runtime.Serialization.EnumMember]
		RMC_Unlimited_key_check_for_radio_owner_system_ID,
		// Token: 0x040002BA RID: 698
		[global::System.Runtime.Serialization.EnumMember]
		RMC_Cnv_check_for_owner_system_ID,
		// Token: 0x040002BB RID: 699
		[global::System.Runtime.Serialization.EnumMember]
		RMC_AddSet_NoOTAPAuthenticationKey,
		// Token: 0x040002BC RID: 700
		[global::System.Runtime.Serialization.EnumMember]
		RMC_AddSet_NoEnhancedPrivacyKey,
		// Token: 0x040002BD RID: 701
		[global::System.Runtime.Serialization.EnumMember]
		RMC_AddSet_NoSymmetricKey,
		// Token: 0x040002BE RID: 702
		[global::System.Runtime.Serialization.EnumMember]
		RMC_AddSet_NoRASKey,
		// Token: 0x040002BF RID: 703
		[global::System.Runtime.Serialization.EnumMember]
		RMC_Config_Editor_Operation_Cause_Mismatch,
		// Token: 0x040002C0 RID: 704
		[global::System.Runtime.Serialization.EnumMember]
		RMC_AddSet_SystemKeyNotLoaded,
		// Token: 0x040002C1 RID: 705
		[global::System.Runtime.Serialization.EnumMember]
		RMC_SelectSet_SystemKeyNotLoaded,
		// Token: 0x040002C2 RID: 706
		[global::System.Runtime.Serialization.EnumMember]
		RMC_AddSet_WACNKeyNotLoaded,
		// Token: 0x040002C3 RID: 707
		[global::System.Runtime.Serialization.EnumMember]
		RMC_AddSet_AddFNESetNotAllowed,
		// Token: 0x040002C4 RID: 708
		[global::System.Runtime.Serialization.EnumMember]
		RMC_FLASHcode_Error,
		// Token: 0x040002C5 RID: 709
		[global::System.Runtime.Serialization.EnumMember]
		RMC_ServerModeChangedNeedRestart,
		// Token: 0x040002C6 RID: 710
		RestoreJob_GenericError,
		// Token: 0x040002C7 RID: 711
		RestoreJob_NoLpPackage,
		// Token: 0x040002C8 RID: 712
		CannotFoundKeyOnServer,
		// Token: 0x040002C9 RID: 713
		RestoreJob_CrntCPHasNoXPBA,
		// Token: 0x040002CA RID: 714
		[global::System.Runtime.Serialization.EnumMember]
		RMC_Invalid_ProductFamily_For_Wired,
		// Token: 0x040002CB RID: 715
		[global::System.Runtime.Serialization.EnumMember]
		RMC_Invalid_JobType_For_DMR3Controller,
		// Token: 0x040002CC RID: 716
		[global::System.Runtime.Serialization.EnumMember]
		RMC_Create_DiscoveryChannel_Failed,
		// Token: 0x040002CD RID: 717
		[global::System.Runtime.Serialization.EnumMember]
		RMC_Not_Find_Help_File,
		// Token: 0x040002CE RID: 718
		[global::System.Runtime.Serialization.EnumMember]
		RMC_Not_Support_PhoenixRadio,
		// Token: 0x040002CF RID: 719
		[global::System.Runtime.Serialization.EnumMember]
		RMC_CFS_Not_Register_DependencyLicense,
		// Token: 0x040002D0 RID: 720
		[global::System.Runtime.Serialization.EnumMember]
		RMC_CFS_License_OutofDate,
		// Token: 0x040002D1 RID: 721
		[global::System.Runtime.Serialization.EnumMember]
		RMC_OpenCodeplug_Fail_HasOpened,
		// Token: 0x040002D2 RID: 722
		[global::System.Runtime.Serialization.EnumMember]
		Radio_Already_Applied_This_Template,
		// Token: 0x040002D3 RID: 723
		[global::System.Runtime.Serialization.EnumMember]
		RMC_Missing_System_For_DMR3_RRP,
		// Token: 0x040002D4 RID: 724
		RMC_Invalid_Controller_IP_For_DMR3_RRP,
		// Token: 0x040002D5 RID: 725
		RMC_Invalid_Controller_UDP_Port_For_DMR3_RRP,
		// Token: 0x040002D6 RID: 726
		RMC_Invalid_Network_ID_For_DMR3_RRP,
		// Token: 0x040002D7 RID: 727
		[global::System.Runtime.Serialization.EnumMember]
		RMC_ScheduleJob_LimitOTAPforAstroLPnoFW,
		// Token: 0x040002D8 RID: 728
		[global::System.Runtime.Serialization.EnumMember]
		RMC_Job_Not_InCurrentMode,
		// Token: 0x040002D9 RID: 729
		[global::System.Runtime.Serialization.EnumMember]
		RMC_SelectConfig_Multi_ProductLine,
		// Token: 0x040002DA RID: 730
		[global::System.Runtime.Serialization.EnumMember]
		RMC_SelectConfig_Multi_Portable,
		// Token: 0x040002DB RID: 731
		[global::System.Runtime.Serialization.EnumMember]
		RMC_SelectConfig_Multi_Mobile_ModelGroup,
		// Token: 0x040002DC RID: 732
		[global::System.Runtime.Serialization.EnumMember]
		RMC_SelectConfig_Multi_Mobile_PowerLevel,
		// Token: 0x040002DD RID: 733
		[global::System.Runtime.Serialization.EnumMember]
		RMC_SelectConfig_Band_MismatchedWithRadio,
		// Token: 0x040002DE RID: 734
		[global::System.Runtime.Serialization.EnumMember]
		RMC_SelectConfig_Unable_To_Apply_From_APX6000_To_APX6000XE_And_Viceversa,
		// Token: 0x040002DF RID: 735
		[global::System.Runtime.Serialization.EnumMember]
		RMC_SelectConfig_Unable_to_Apply_from_a_Motorcycle_radio,
		// Token: 0x040002E0 RID: 736
		[global::System.Runtime.Serialization.EnumMember]
		RMC_SelectConfig_Unable_to_Apply_from_non_APX_Lite_model_to_APX_Lite_model,
		// Token: 0x040002E1 RID: 737
		[global::System.Runtime.Serialization.EnumMember]
		RMC_SelectConfig_Unable_to_Apply_from_non_P25_Common_Air_radio_to_P25_Common_Air_radio,
		// Token: 0x040002E2 RID: 738
		[global::System.Runtime.Serialization.EnumMember]
		RMC_SelectConfig_Unable_to_Apply_from_Trunking,
		// Token: 0x040002E3 RID: 739
		[global::System.Runtime.Serialization.EnumMember]
		RMC_SelectConfig_Unable_to_Apply_from_Trunking_SmartZone,
		// Token: 0x040002E4 RID: 740
		[global::System.Runtime.Serialization.EnumMember]
		RMC_SelectConfig_Unable_to_Apply_due_to_G857_incompatibility,
		// Token: 0x040002E5 RID: 741
		[global::System.Runtime.Serialization.EnumMember]
		RMC_SelectConfig_Unable_to_Apply_from_a_model_3_5,
		// Token: 0x040002E6 RID: 742
		[global::System.Runtime.Serialization.EnumMember]
		RMC_SelectConfig_PCI_Compatibility_Error_Ultra_Low_Power_Capable,
		// Token: 0x040002E7 RID: 743
		[global::System.Runtime.Serialization.EnumMember]
		RMC_SelectConfig_PCI_Compatibility_Error_APX6000_P25_Radio,
		// Token: 0x040002E8 RID: 744
		[global::System.Runtime.Serialization.EnumMember]
		RMC_SelectConfig_PCI_Compatibility_Error_WWP_2_Knobs_Capable,
		// Token: 0x040002E9 RID: 745
		[global::System.Runtime.Serialization.EnumMember]
		RMC_SelectConfig_PCI_Compatibility_Error_ID_Mari_Time_Radio_Software,
		// Token: 0x040002EA RID: 746
		[global::System.Runtime.Serialization.EnumMember]
		RMC_SelectConfig_PCI_Compatibility_Error_Extended_UHF_R1_Capable,
		// Token: 0x040002EB RID: 747
		[global::System.Runtime.Serialization.EnumMember]
		RMC_SelectConfig_PCI_Compatibility_Error_SoldierMAC_FCC_And_RTTE,
		// Token: 0x040002EC RID: 748
		[global::System.Runtime.Serialization.EnumMember]
		RMC_IPProgramSystem_Required,
		// Token: 0x040002ED RID: 749
		[global::System.Runtime.Serialization.EnumMember]
		Configuration_Must_Selected_Schedule_Job,
		// Token: 0x040002EE RID: 750
		[global::System.Runtime.Serialization.EnumMember]
		RMC_Invalid_JobType_For_MNIS,
		// Token: 0x040002EF RID: 751
		[global::System.Runtime.Serialization.EnumMember]
		RMC_NO_Changed_Features,
		// Token: 0x040002F0 RID: 752
		[global::System.Runtime.Serialization.EnumMember]
		SAC_RECORD_NOT_FOUND,
		// Token: 0x040002F1 RID: 753
		[global::System.Runtime.Serialization.EnumMember]
		SAC_SITE_SELECTION_NOT_FOUND,
		// Token: 0x040002F2 RID: 754
		[global::System.Runtime.Serialization.EnumMember]
		SAC_SEL_SITE_NOT_FOUND,
		// Token: 0x040002F3 RID: 755
		[global::System.Runtime.Serialization.EnumMember]
		TGSA_RECORD_NOT_FOUND,
		// Token: 0x040002F4 RID: 756
		[global::System.Runtime.Serialization.EnumMember]
		TGSA_SITE_SELECTION_NOT_FOUND,
		// Token: 0x040002F5 RID: 757
		[global::System.Runtime.Serialization.EnumMember]
		TGSA_SEL_SITE_NOT_FOUND,
		// Token: 0x040002F6 RID: 758
		[global::System.Runtime.Serialization.EnumMember]
		RMC_DuplicateDeviceID_MNISMsg,
		// Token: 0x040002F7 RID: 759
		[global::System.Runtime.Serialization.EnumMember]
		RMC_SACTGSA_DEVICE_ID_DUPLICATE,
		// Token: 0x040002F8 RID: 760
		[global::System.Runtime.Serialization.EnumMember]
		RMC_ControllerHostID_Missing,
		// Token: 0x040002F9 RID: 761
		[global::System.Runtime.Serialization.EnumMember]
		DMR3Controller_Config_Generation_Not_Allowed,
		// Token: 0x040002FA RID: 762
		[global::System.Runtime.Serialization.EnumMember]
		RMC_SAC_EmptyPSN_DUPLICATE,
		// Token: 0x040002FB RID: 763
		[global::System.Runtime.Serialization.EnumMember]
		TGSA_RECORD_EXTEND_MAX_NUMBER,
		// Token: 0x040002FC RID: 764
		[global::System.Runtime.Serialization.EnumMember]
		RMC_IPProgramSystem_ProductFamilyNoCapMaxSupport,
		// Token: 0x040002FD RID: 765
		[global::System.Runtime.Serialization.EnumMember]
		RMC_IPProgramSystem_ProductFamilyNoLESupport,
		// Token: 0x040002FE RID: 766
		[global::System.Runtime.Serialization.EnumMember]
		RMC_IPProgramSystem_ProductFamilyNoCMSSSupport,
		// Token: 0x040002FF RID: 767
		[global::System.Runtime.Serialization.EnumMember]
		RMC_CopySetFrom_ConcurrentIssue,
		// Token: 0x04000300 RID: 768
		[global::System.Runtime.Serialization.EnumMember]
		ASTRO_RMC_UpdateRadioData_NoAttachedASK,
		// Token: 0x04000301 RID: 769
		[global::System.Runtime.Serialization.EnumMember]
		RMC_ScheduleJob_AppOptionMismatch_NonSpainFreq,
		// Token: 0x04000302 RID: 770
		[global::System.Runtime.Serialization.EnumMember]
		RMC_ImportCodeplug_Override_ModelNumber_Error,
		// Token: 0x04000303 RID: 771
		[global::System.Runtime.Serialization.EnumMember]
		RMC_ImportConfiguration_Version_NOT_Support_Error,
		// Token: 0x04000304 RID: 772
		[global::System.Runtime.Serialization.EnumMember]
		ASTRO_RMC_SAVECONFIGURATION_ERROR_ONGOINGJOB,
		// Token: 0x04000305 RID: 773
		[global::System.Runtime.Serialization.EnumMember]
		RMC_ScheduleJob_AppOptionMismatch_SpainFreq,
		// Token: 0x04000306 RID: 774
		[global::System.Runtime.Serialization.EnumMember]
		RMC_ImportConfiguration_FailUpgradeLegacyConfiguration,
		// Token: 0x04000307 RID: 775
		RMC_Import_Si500_FailedToReadXML,
		// Token: 0x04000308 RID: 776
		RMC_Import_Si500_InvalidXMLFormat,
		// Token: 0x04000309 RID: 777
		[global::System.Runtime.Serialization.EnumMember]
		RMC_WhiteList_FailedToReadXML,
		// Token: 0x0400030A RID: 778
		RMC_WhiteList_InvalidXMLFormat,
		// Token: 0x0400030B RID: 779
		RMC_WhiteList_InvalidXMLAttribute,
		// Token: 0x0400030C RID: 780
		[global::System.Runtime.Serialization.EnumMember]
		RMC_CANNOT_CONNECT_DPSERVICE,
		// Token: 0x0400030D RID: 781
		[global::System.Runtime.Serialization.EnumMember]
		RMC_SimpleTouch_FailedToReadXML,
		// Token: 0x0400030E RID: 782
		RMC_SimpleTouch_InvalidXMLFormat,
		// Token: 0x0400030F RID: 783
		RMC_SimpleTouch_InvalidXMLAttribute,
		// Token: 0x04000310 RID: 784
		RMC_SimpleTouch_InvalidAppLink,
		// Token: 0x04000311 RID: 785
		RMC_SimpleTouch_ExceedMaxRows,
		// Token: 0x04000312 RID: 786
		RMC_Shortcut_ClassNameNotExist,
		// Token: 0x04000313 RID: 787
		RMC_Shortcut_PackageNameNotExist,
		// Token: 0x04000314 RID: 788
		[global::System.Runtime.Serialization.EnumMember]
		RMC_ScheduleJob_UnsupportedModelForRRP,
		// Token: 0x04000315 RID: 789
		[global::System.Runtime.Serialization.EnumMember]
		RMC_Radio_InCompatible_With_Configuration,
		// Token: 0x04000316 RID: 790
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_SQL_GENERIC = 3900,
		// Token: 0x04000317 RID: 791
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_SQL_CONCURRENCY_ERROR,
		// Token: 0x04000318 RID: 792
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_SQL_DEADLOCK_ERROR,
		// Token: 0x04000319 RID: 793
		[global::Motorola.Common.CustomException.BatchOperationError(true)]
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_SQL_HAS_NO_DISK_SPACE,
		// Token: 0x0400031A RID: 794
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_JOB_EXPIRED = 4004,
		// Token: 0x0400031B RID: 795
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_JOB_CANCELLED,
		// Token: 0x0400031C RID: 796
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_JOB_STATUS_CHANGE_NOT_ALLOWED,
		// Token: 0x0400031D RID: 797
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_JOB_STATUS_CANCEL_NOT_ALLOWED,
		// Token: 0x0400031E RID: 798
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_JOB_NOT_FOUND,
		// Token: 0x0400031F RID: 799
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_JOB_CONTAINER_NOT_FOUND,
		// Token: 0x04000320 RID: 800
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_JOB_NOT_UTC_TIME,
		// Token: 0x04000321 RID: 801
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_JOB_SCHEDULE_TIME_INVALID,
		// Token: 0x04000322 RID: 802
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_JOB_INVALID_SWITCH_JOB,
		// Token: 0x04000323 RID: 803
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_JOB_CLIENT_TYPE_NOT_MATCH,
		// Token: 0x04000324 RID: 804
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_JOB_DEVICE_ALREADY_SCHEDULED_A_JOB,
		// Token: 0x04000325 RID: 805
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_CLIENT_NOT_ALLOWED_FOR_OPERATION,
		// Token: 0x04000326 RID: 806
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_CLIENT_RM_VERSION_INCOMPATIBLE,
		// Token: 0x04000327 RID: 807
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_CLIENT_CPS_VERSION_INCOMPATIBLE,
		// Token: 0x04000328 RID: 808
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_SESSIONID_NOT_FOUND,
		// Token: 0x04000329 RID: 809
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_SESSIONID_ALREADY_EXIST,
		// Token: 0x0400032A RID: 810
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_INVALID_GROUPNAME,
		// Token: 0x0400032B RID: 811
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_GROUP_NOT_FOUND,
		// Token: 0x0400032C RID: 812
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_GROUP_ALREADY_EXIST,
		// Token: 0x0400032D RID: 813
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_GROUP_CONTAIN_DEVICES,
		// Token: 0x0400032E RID: 814
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_GROUP_NOT_CONTAIN_DEVICE,
		// Token: 0x0400032F RID: 815
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_GROUP_ALREADY_CONTAIN_DEVICE,
		// Token: 0x04000330 RID: 816
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_RMFILE_NOT_FOUND,
		// Token: 0x04000331 RID: 817
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_PACKAGE_INVALID_PACKAGE_TYPE,
		// Token: 0x04000332 RID: 818
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_PACKAGE_INVALID_PAC_TYPE,
		// Token: 0x04000333 RID: 819
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_PACKAGE_INVALID_PACKAGESUMMARY,
		// Token: 0x04000334 RID: 820
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_PACKAGE_ALREADY_EXIST,
		// Token: 0x04000335 RID: 821
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_PACKAGE_NOT_FOUND,
		// Token: 0x04000336 RID: 822
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_PACKAGE_HAVE_REFERENCE,
		// Token: 0x04000337 RID: 823
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_ITEM_NOT_EXIST,
		// Token: 0x04000338 RID: 824
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_ITEM_HAS_EXIST,
		// Token: 0x04000339 RID: 825
		[global::System.Runtime.Serialization.EnumMember]
		RADIO_IN_INVALID_STATUS,
		// Token: 0x0400033A RID: 826
		[global::System.Runtime.Serialization.EnumMember]
		RADIO_HAS_EXISTS,
		// Token: 0x0400033B RID: 827
		[global::System.Runtime.Serialization.EnumMember]
		RADIO_EXISTS_IN_ANOTHERGROUP,
		// Token: 0x0400033C RID: 828
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_RADIO_IN_FW_STATUS,
		// Token: 0x0400033D RID: 829
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_NO_MATCH_PACKAGE,
		// Token: 0x0400033E RID: 830
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_RADIO_HAS_RUNNING_JOB,
		// Token: 0x0400033F RID: 831
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_DEVICE_NOT_FOUND = 6000,
		// Token: 0x04000340 RID: 832
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_DEVICE_ALREADY_EXIST,
		// Token: 0x04000341 RID: 833
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_DEVICE_UNKNOWN_REQUEST_TYPE,
		// Token: 0x04000342 RID: 834
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_DEVICE_CANCEL_JOB_BEFORE_DISCARD_CODEPLUG,
		// Token: 0x04000343 RID: 835
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_CODEPLUG_NOT_FOUND = 6300,
		// Token: 0x04000344 RID: 836
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_CODEPLUG_TEMPLATE_NULL,
		// Token: 0x04000345 RID: 837
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_CODEPLUG_DISALLOW_UPDATE_CURRENTCODEPLUG,
		// Token: 0x04000346 RID: 838
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_CODEPLUG_TEMPLATEUUID_TEMPLATE_MISMATCH,
		// Token: 0x04000347 RID: 839
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_CODEPLUG_APX_RADIOSYSTEM_NOT_FOUND,
		// Token: 0x04000348 RID: 840
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_CODEPLUG_APX_DATAPROFILE_NOT_FOUND,
		// Token: 0x04000349 RID: 841
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_CODEPLUG_CANNOT_UPDATE_CODEPLUG_IF_JOB_EXIST,
		// Token: 0x0400034A RID: 842
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_CODEPLUG_PCR_RADIOSYSTEM_NOT_FOUND,
		// Token: 0x0400034B RID: 843
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_TEMPLATE_NOT_FOUND = 6600,
		// Token: 0x0400034C RID: 844
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_TEMPLATE_NAME_DUPLICATE,
		// Token: 0x0400034D RID: 845
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_TEMPLATE_CANNOT_DELETE_REFERENCED_TEMPLATE,
		// Token: 0x0400034E RID: 846
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_CODEPLUG_FIRMWAREUUID_ASTROFIRMWARE_MISMATCH,
		// Token: 0x0400034F RID: 847
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_CODEPLUG_FIRMWARECODEPLUGPAIRUUID_PCRFIRMWARECODEPLUGPAIR_MISMATCH,
		// Token: 0x04000350 RID: 848
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_TEMPLATE_LANGUAGE_SAME,
		// Token: 0x04000351 RID: 849
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_MATRIX_KEY_NOT_FOUND = 6800,
		// Token: 0x04000352 RID: 850
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_MATRIX_PRIVACY_KEY_RANGE_INVALID,
		// Token: 0x04000353 RID: 851
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_MATRIX_OTAP_KEY_RANGE_INVALID,
		// Token: 0x04000354 RID: 852
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_MATRIX_RAS_KEY_RANGE_INVALID,
		// Token: 0x04000355 RID: 853
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_MATRIX_SYMMETRIC_KEY_RANGE_INVALID,
		// Token: 0x04000356 RID: 854
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_MATRIX_PRIVACY_KEY_ID_DUPLICATED,
		// Token: 0x04000357 RID: 855
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_MATRIX_OTAP_KEY_ID_DUPLICATED,
		// Token: 0x04000358 RID: 856
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_MATRIX_SYMMETRIC_KEY_ID_DUPLICATED,
		// Token: 0x04000359 RID: 857
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_MATRIX_KEY_CANNOT_BE_REMOVED,
		// Token: 0x0400035A RID: 858
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_MATRIX_RAS_KEY_ALIAS_NULL,
		// Token: 0x0400035B RID: 859
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_MATRIX_KEY_ALIAS_DUPLICATED,
		// Token: 0x0400035C RID: 860
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_IP_PROGRAM_SYSTEM_NOT_FOUND = 6950,
		// Token: 0x0400035D RID: 861
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_IP_PROGRAM_SYSTEM_CANNOT_BE_REMOVED,
		// Token: 0x0400035E RID: 862
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_IP_PROGRAM_SYSTEM_ALIAS_DUPLICATED,
		// Token: 0x0400035F RID: 863
		[global::System.Runtime.Serialization.EnumMember]
		FILE_INTEGRITY_VALIDATION_FAILED = 7000,
		// Token: 0x04000360 RID: 864
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_RADIOLICENSE_UPDATE_TO_DATE = 7103,
		// Token: 0x04000361 RID: 865
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_RADIOLICENSE_FEATURE_NOT_FOUND,
		// Token: 0x04000362 RID: 866
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_RADIOLICENSE_FEATURE_STATUS_WRONG,
		// Token: 0x04000363 RID: 867
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_RADIOLICENSE_FEATURE_OPERATION_NOT_ALLOWED,
		// Token: 0x04000364 RID: 868
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_RADIOLICENSE_FEATURE_INVALID_LICENSE_NAME,
		// Token: 0x04000365 RID: 869
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_DEVICECAPABILITY_LICENSE_NOT_FOUND = 7200,
		// Token: 0x04000366 RID: 870
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_DEVICECAPABILITY_HOST_ID_ALREADY_EXIST,
		// Token: 0x04000367 RID: 871
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_DEVICECAPABILITY_ID_NOT_FOUND,
		// Token: 0x04000368 RID: 872
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_APPLY_LOCK_FAILED = 7300,
		// Token: 0x04000369 RID: 873
		SERVER_CONFIGURATION_IS_UPDATING,
		// Token: 0x0400036A RID: 874
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_BATCHJOBCONTAINER_NOT_FOUND = 7400,
		// Token: 0x0400036B RID: 875
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_BATCHJOB_NOT_FOUND,
		// Token: 0x0400036C RID: 876
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_CONFIGURATION_NAME_DUPLICATE = 7500,
		// Token: 0x0400036D RID: 877
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_CONFIGURATION_CONCURRENCY_CONFLICT,
		// Token: 0x0400036E RID: 878
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_CONFIGURATION_SYNC_DATA_FAIL,
		// Token: 0x0400036F RID: 879
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_CONFIGURATION_NOT_FOUND,
		// Token: 0x04000370 RID: 880
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_JOB_SERVER_UNAVAILABLE,
		// Token: 0x04000371 RID: 881
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_CONFIGURATION_SET_NAME_DUPLICATE,
		// Token: 0x04000372 RID: 882
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_CONFIGURATION_SET_REFERED_BY_OTHER_SET_CANNOT_BE_DELETED,
		// Token: 0x04000373 RID: 883
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_CONFIGURATION_SET_NOT_FOUND,
		// Token: 0x04000374 RID: 884
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_CONFIGURATION_IMPORT_FAILURE,
		// Token: 0x04000375 RID: 885
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_CONFIGURATION_IS_READONLY_FOR_WRITE_JOB,
		// Token: 0x04000376 RID: 886
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_CONFIGURATION_CANNOT_APPLY_SET_TO_CONFIGURATION,
		// Token: 0x04000377 RID: 887
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_CONFIGURATION_SELECT_REF_TARGET_CANNOT_BE_FOUND,
		// Token: 0x04000378 RID: 888
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_MISMATCHED_RADIO_PAC,
		// Token: 0x04000379 RID: 889
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_CONFIGURATION_HAS_DUPLICATED_RS_DATA,
		// Token: 0x0400037A RID: 890
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_CONFIGURATION_HAS_DUPLICATED_DP_DATA,
		// Token: 0x0400037B RID: 891
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_NOT_ALLOW_TO_DELETE_JOB,
		// Token: 0x0400037C RID: 892
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_UPGRADE_LANGUAGE_ERROR,
		// Token: 0x0400037D RID: 893
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_CONFIGURATION_DATA_CHECKSUM_VALIDATE_ERROR,
		// Token: 0x0400037E RID: 894
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_NOT_ALLOW_TO_APPLY_MVO_TO_RADIO_HAS_ONGOING_JOB,
		// Token: 0x0400037F RID: 895
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_Discard_Modified_Configuration_Failed,
		// Token: 0x04000380 RID: 896
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_CnvRS_Exceed_RadioMax,
		// Token: 0x04000381 RID: 897
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_ASTRO25TrunkingSystem_Exceed_RadioMax,
		// Token: 0x04000382 RID: 898
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_CommonTypeIITrunkingSystem_Exceed_RadioMax,
		// Token: 0x04000383 RID: 899
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_TrunkingSystemPool_Exceed_RadioMax,
		// Token: 0x04000384 RID: 900
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_DataProfile_Exceed_RadioMax,
		// Token: 0x04000385 RID: 901
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_VIOLATION_OF_DB_UNIQUE_KEY_CONSTRAINT,
		// Token: 0x04000386 RID: 902
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_SCHEDULE_RESTORE_JOB_FAIL_DUE_TO_LP_NO_FILE,
		// Token: 0x04000387 RID: 903
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_SCHEDULE_RESTORE_JOB_FAIL_DUE_TO_VA_NO_FILE,
		// Token: 0x04000388 RID: 904
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_CONFIGURATION_CANNOT_BE_DELETED,
		// Token: 0x04000389 RID: 905
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_SCHEDULE_RESTORE_JOB_LIMIT_FOR_ASTRO_LP,
		// Token: 0x0400038A RID: 906
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_NOT_ALLOW_UPDATE_CODEPLUG_VERSION_DUE_TO_FW_CHANGE,
		// Token: 0x0400038B RID: 907
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_RADIO_ALREADY_EXIST_IN_ANOTHER_MODE,
		// Token: 0x0400038C RID: 908
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_NOT_SUPPORT_WORK_MODE,
		// Token: 0x0400038D RID: 909
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_FAILED_CREATE_RADIO_SUMMARY,
		// Token: 0x0400038E RID: 910
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_SCHEDULE_RESTORE_JOB_FAIL_DUE_TO_TTS_NO_FILE,
		// Token: 0x0400038F RID: 911
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_CONFIGURATION_RADIO_IS_OUT_OF_SYNC,
		// Token: 0x04000390 RID: 912
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_SQL_SERVER_OPERATION_TIME_OUT,
		// Token: 0x04000391 RID: 913
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_WIN32_EXCEPTION,
		// Token: 0x04000392 RID: 914
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_SQL_SERVER_WAIT_CONNECTION_POOL_TIME_OUT,
		// Token: 0x04000393 RID: 915
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_INVALID_OPERATION,
		// Token: 0x04000394 RID: 916
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_DATA_MINING_QUERYSUMMARY_NOT_FOUND,
		// Token: 0x04000395 RID: 917
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_DATA_MINING_GROUP_CONTAINS_QUERIES,
		// Token: 0x04000396 RID: 918
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_DATA_MINING_QUERY_NAME_DUPLICATE,
		// Token: 0x04000397 RID: 919
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_SACSITESELECTION_REFERED_BY_OHTER_SAC_CANNOT_BE_DELETE = 7550,
		// Token: 0x04000398 RID: 920
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_TGSASITESELECTION_REFERED_BY_OHTER_TGSA_CANNOT_BE_DELETE,
		// Token: 0x04000399 RID: 921
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_DISCVRY_SRVCE_AUTOUPDATE_XML_NOT_FOUND = 7600,
		// Token: 0x0400039A RID: 922
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_DISCVRY_SRVCE_INSTALL_PCKGE_NOT_FOUND,
		// Token: 0x0400039B RID: 923
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_DISCVRY_SRVCE_UNSUPPORTED_COMPONENT,
		// Token: 0x0400039C RID: 924
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_DISCVRY_SRVCE_ASK_ACCESSLEVEL_ERROR,
		// Token: 0x0400039D RID: 925
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_DISCVRY_SRVCE_ASK_UNSUPPORTED_KEYTYPE,
		// Token: 0x0400039E RID: 926
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_DISCVRY_SRVCE_ASK_USER_NOT_FOUND,
		// Token: 0x0400039F RID: 927
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_DISCVRY_SRVCE_ASK_ANONYMOUS_USER,
		// Token: 0x040003A0 RID: 928
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_DISCVRY_SRVCE_ASK_UNSUPPORTED_CLIENT_TYPE,
		// Token: 0x040003A1 RID: 929
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_DISCVRY_SRVCE_ASK_NO_PERMISSION_UPLOAD,
		// Token: 0x040003A2 RID: 930
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_DISCVRY_SRVCE_ASK_KEY_ALREADY_EXISTED,
		// Token: 0x040003A3 RID: 931
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_DISCVRY_SRVCE_ASK_KEY_ALREADY_ASSIGNED_TO_USER,
		// Token: 0x040003A4 RID: 932
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_DISCVRY_SRVCE_ASK_KEY_ALREADY_UPLOADED_BY_ANOTHER_USER,
		// Token: 0x040003A5 RID: 933
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_DISCVRY_SRVCE_ASK_KEY_INVALID_HARDWARE_KEY,
		// Token: 0x040003A6 RID: 934
		[global::System.Runtime.Serialization.EnumMember]
		ProxyUnknownException = 10000,
		// Token: 0x040003A7 RID: 935
		[global::System.Runtime.Serialization.EnumMember]
		ProxyValidationFailed,
		// Token: 0x040003A8 RID: 936
		[global::System.Runtime.Serialization.EnumMember]
		ProxyValidationSerialNumberFailed,
		// Token: 0x040003A9 RID: 937
		[global::System.Runtime.Serialization.EnumMember]
		ProxyValidationModelNumberFailed,
		// Token: 0x040003AA RID: 938
		[global::System.Runtime.Serialization.EnumMember]
		ProxyValidationRegionFailed,
		// Token: 0x040003AB RID: 939
		[global::System.Runtime.Serialization.EnumMember]
		ProxyReadDeviceFailed,
		// Token: 0x040003AC RID: 940
		[global::System.Runtime.Serialization.EnumMember]
		ProxyReadExtendInfoFailed,
		// Token: 0x040003AD RID: 941
		[global::System.Runtime.Serialization.EnumMember]
		ProxyWriteDeviceFailed,
		// Token: 0x040003AE RID: 942
		[global::System.Runtime.Serialization.EnumMember]
		ProxySwitchoverFailed,
		// Token: 0x040003AF RID: 943
		[global::System.Runtime.Serialization.EnumMember]
		ProxyRegisterRadioFailed,
		// Token: 0x040003B0 RID: 944
		[global::System.Runtime.Serialization.EnumMember]
		ProxyCantConnect2Server,
		// Token: 0x040003B1 RID: 945
		[global::System.Runtime.Serialization.EnumMember]
		ProxyCantUpdateStatus2Server,
		// Token: 0x040003B2 RID: 946
		[global::System.Runtime.Serialization.EnumMember]
		ProxyDownloadPackagesFailed,
		// Token: 0x040003B3 RID: 947
		[global::System.Runtime.Serialization.EnumMember]
		ProxyDecryptPackagesFailed,
		// Token: 0x040003B4 RID: 948
		[global::System.Runtime.Serialization.EnumMember]
		ProxyFailed2EnableCFSFeatures,
		// Token: 0x040003B5 RID: 949
		[global::System.Runtime.Serialization.EnumMember]
		ProxyFailed2JobHasBeenCanceled,
		// Token: 0x040003B6 RID: 950
		[global::System.Runtime.Serialization.EnumMember]
		ProxyUnsupporttedPac,
		// Token: 0x040003B7 RID: 951
		[global::System.Runtime.Serialization.EnumMember]
		ProxyDeviceNotFound,
		// Token: 0x040003B8 RID: 952
		[global::System.Runtime.Serialization.EnumMember]
		ProxyResetDeviceTimeout,
		// Token: 0x040003B9 RID: 953
		[global::System.Runtime.Serialization.EnumMember]
		ProxyResetDeviceException,
		// Token: 0x040003BA RID: 954
		[global::System.Runtime.Serialization.EnumMember]
		ProxyValidationFlashSizeMismatch,
		// Token: 0x040003BB RID: 955
		[global::System.Runtime.Serialization.EnumMember]
		ProxyValidationDigitalFWMismatch,
		// Token: 0x040003BC RID: 956
		[global::System.Runtime.Serialization.EnumMember]
		ProxyValidationDTPFwMismatch,
		// Token: 0x040003BD RID: 957
		[global::System.Runtime.Serialization.EnumMember]
		ProxyPartialEnabledCFSFeatures,
		// Token: 0x040003BE RID: 958
		[global::System.Runtime.Serialization.EnumMember]
		ProxyFailedtoUpdateProgrammingStatus,
		// Token: 0x040003BF RID: 959
		[global::System.Runtime.Serialization.EnumMember]
		[global::Motorola.Common.CustomException.ErrorCodeAttributes(Retriable = true)]
		ProxyOTAPRadioNotPresent,
		// Token: 0x040003C0 RID: 960
		[global::System.Runtime.Serialization.EnumMember]
		ProxyJobIsLockedByOtherDP,
		// Token: 0x040003C1 RID: 961
		[global::System.Runtime.Serialization.EnumMember]
		GuiItemUnknowException,
		// Token: 0x040003C2 RID: 962
		[global::System.Runtime.Serialization.EnumMember]
		GuiItemUpdateException,
		// Token: 0x040003C3 RID: 963
		[global::System.Runtime.Serialization.EnumMember]
		OffP_CannotConnectToDP,
		// Token: 0x040003C4 RID: 964
		[global::System.Runtime.Serialization.EnumMember]
		CruncherUnknownException = 20000,
		// Token: 0x040003C5 RID: 965
		[global::System.Runtime.Serialization.EnumMember]
		CruncherWorkObjectCreatedFailed,
		// Token: 0x040003C6 RID: 966
		[global::System.Runtime.Serialization.EnumMember]
		CruncherCpsWasDeleted,
		// Token: 0x040003C7 RID: 967
		[global::System.Runtime.Serialization.EnumMember]
		CruncherFolderWasDeleted,
		// Token: 0x040003C8 RID: 968
		[global::System.Runtime.Serialization.EnumMember]
		CruncherCpsCrashed,
		// Token: 0x040003C9 RID: 969
		[global::System.Runtime.Serialization.EnumMember]
		CruncherCodeplugWasDeleted,
		// Token: 0x040003CA RID: 970
		[global::System.Runtime.Serialization.EnumMember]
		CruncherCpDatCantGet,
		// Token: 0x040003CB RID: 971
		[global::System.Runtime.Serialization.EnumMember]
		CruncherCpsGenerateCpFailed,
		// Token: 0x040003CC RID: 972
		[global::System.Runtime.Serialization.EnumMember]
		CruncherFailedtoParseCPSResult,
		// Token: 0x040003CD RID: 973
		[global::System.Runtime.Serialization.EnumMember]
		CruncherCantConnect2Server,
		// Token: 0x040003CE RID: 974
		[global::System.Runtime.Serialization.EnumMember]
		CruncherDownloadedJobInvalid,
		// Token: 0x040003CF RID: 975
		[global::System.Runtime.Serialization.EnumMember]
		CruncherFailedtoProcessPackage,
		// Token: 0x040003D0 RID: 976
		[global::System.Runtime.Serialization.EnumMember]
		CruncherFailedtoSerializeData,
		// Token: 0x040003D1 RID: 977
		[global::System.Runtime.Serialization.EnumMember]
		CruncherFailedtoGetInternalUpgradePackage,
		// Token: 0x040003D2 RID: 978
		[global::System.Runtime.Serialization.EnumMember]
		CruncherInternalUpgradePackageIsNotSupported,
		// Token: 0x040003D3 RID: 979
		[global::System.Runtime.Serialization.EnumMember]
		CruncherJobNotSupported,
		// Token: 0x040003D4 RID: 980
		[global::System.Runtime.Serialization.EnumMember]
		CruncherDataDeserializeFailed,
		// Token: 0x040003D5 RID: 981
		[global::System.Runtime.Serialization.EnumMember]
		CruncherCMDCPSOutOfMemory,
		// Token: 0x040003D6 RID: 982
		[global::System.Runtime.Serialization.EnumMember]
		CruncherDownloadJobOutOfMemory,
		// Token: 0x040003D7 RID: 983
		[global::System.Runtime.Serialization.EnumMember]
		AstroCruncherSuccessful = 22000,
		// Token: 0x040003D8 RID: 984
		[global::System.Runtime.Serialization.EnumMember]
		AstroCruncherGenericError,
		// Token: 0x040003D9 RID: 985
		[global::System.Runtime.Serialization.EnumMember]
		AstroCruncherInputfileNotExisted,
		// Token: 0x040003DA RID: 986
		[global::System.Runtime.Serialization.EnumMember]
		AstroCruncherInputfileError,
		// Token: 0x040003DB RID: 987
		[global::System.Runtime.Serialization.EnumMember]
		AstroCruncherIncorrectArgument,
		// Token: 0x040003DC RID: 988
		[global::System.Runtime.Serialization.EnumMember]
		AstroCruncherWriteFail,
		// Token: 0x040003DD RID: 989
		[global::System.Runtime.Serialization.EnumMember]
		AstroCruncherReadFail,
		// Token: 0x040003DE RID: 990
		[global::System.Runtime.Serialization.EnumMember]
		AstroCruncherUpgradeFail,
		// Token: 0x040003DF RID: 991
		[global::System.Runtime.Serialization.EnumMember]
		AstroCruncherReadPopulationFails,
		// Token: 0x040003E0 RID: 992
		[global::System.Runtime.Serialization.EnumMember]
		AstroCruncherReadPbaFileFail,
		// Token: 0x040003E1 RID: 993
		[global::System.Runtime.Serialization.EnumMember]
		AstroCruncherWriteApplyFails,
		// Token: 0x040003E2 RID: 994
		[global::System.Runtime.Serialization.EnumMember]
		AstroCruncherJobParseFails,
		// Token: 0x040003E3 RID: 995
		[global::System.Runtime.Serialization.EnumMember]
		AstroCruncherOpenTemplateFails,
		// Token: 0x040003E4 RID: 996
		[global::System.Runtime.Serialization.EnumMember]
		AstroCruncherPasswordValidationFails,
		// Token: 0x040003E5 RID: 997
		[global::System.Runtime.Serialization.EnumMember]
		PasswordValidationFails,
		// Token: 0x040003E6 RID: 998
		[global::System.Runtime.Serialization.EnumMember]
		AstroCruncherPasswordValidationFailsRemainingAttempt,
		// Token: 0x040003E7 RID: 999
		[global::System.Runtime.Serialization.EnumMember]
		AstroCruncherPasswordValidationFailsRadioLocked,
		// Token: 0x040003E8 RID: 1000
		[global::System.Runtime.Serialization.EnumMember]
		AstroCruncherImportFail,
		// Token: 0x040003E9 RID: 1001
		[global::System.Runtime.Serialization.EnumMember]
		AstroCruncherImportFileCouldNotBeOpened,
		// Token: 0x040003EA RID: 1002
		[global::System.Runtime.Serialization.EnumMember]
		CMDCPS_CRUNCHER_RADIO_INHIBITED,
		// Token: 0x040003EB RID: 1003
		[global::System.Runtime.Serialization.EnumMember]
		CMDCPS_CRUNCHER_RADIO_KILLED,
		// Token: 0x040003EC RID: 1004
		[global::System.Runtime.Serialization.EnumMember]
		AstroCruncherRadioBeingReadIsINHIBITED,
		// Token: 0x040003ED RID: 1005
		[global::System.Runtime.Serialization.EnumMember]
		AstroCruncherRadioBeingReadIsKilled,
		// Token: 0x040003EE RID: 1006
		[global::System.Runtime.Serialization.EnumMember]
		CMDCPS_UNKNOWN_ERROR = 24000,
		// Token: 0x040003EF RID: 1007
		[global::System.Runtime.Serialization.EnumMember]
		CMDCPS_INVALID_ARGUMENTS,
		// Token: 0x040003F0 RID: 1008
		[global::System.Runtime.Serialization.EnumMember]
		CMDCPS_INVALID_PBAFILE,
		// Token: 0x040003F1 RID: 1009
		[global::System.Runtime.Serialization.EnumMember]
		CMDCPS_TEMPLATE_INVALID,
		// Token: 0x040003F2 RID: 1010
		[global::System.Runtime.Serialization.EnumMember]
		CMDCPS_CANNOT_READ_PBA,
		// Token: 0x040003F3 RID: 1011
		[global::System.Runtime.Serialization.EnumMember]
		CMDCPS_CANNOT_GET_FIELD_VALUE,
		// Token: 0x040003F4 RID: 1012
		[global::System.Runtime.Serialization.EnumMember]
		CMDCPS_CANNOT_SET_FIELD_VALUE,
		// Token: 0x040003F5 RID: 1013
		[global::System.Runtime.Serialization.EnumMember]
		CMDCPS_CANNOT_READ_ARCHIVE,
		// Token: 0x040003F6 RID: 1014
		[global::System.Runtime.Serialization.EnumMember]
		CMDCPS_ERROR_CLONE,
		// Token: 0x040003F7 RID: 1015
		[global::System.Runtime.Serialization.EnumMember]
		CMDCPS_CANNOT_GEN_WRITEVALID_FILED,
		// Token: 0x040003F8 RID: 1016
		[global::System.Runtime.Serialization.EnumMember]
		CMDCPS_ERROR_DIFFERENTIAL_WRITE,
		// Token: 0x040003F9 RID: 1017
		[global::System.Runtime.Serialization.EnumMember]
		CMDCPS_CONVERT_WRTIE_TO_FULL_PBA_FAILED,
		// Token: 0x040003FA RID: 1018
		[global::System.Runtime.Serialization.EnumMember]
		CMDCPS_DECODE_PBA_FAILED,
		// Token: 0x040003FB RID: 1019
		[global::System.Runtime.Serialization.EnumMember]
		CMDCPS_ENCODE_PBA_FAILED,
		// Token: 0x040003FC RID: 1020
		[global::System.Runtime.Serialization.EnumMember]
		CMDCPS_CLONE_FAILED,
		// Token: 0x040003FD RID: 1021
		[global::System.Runtime.Serialization.EnumMember]
		CMDCPS_READ_ARCHIVE_FAILED,
		// Token: 0x040003FE RID: 1022
		[global::System.Runtime.Serialization.EnumMember]
		CMDCPS_READ_PBA_FAILED,
		// Token: 0x040003FF RID: 1023
		[global::System.Runtime.Serialization.EnumMember]
		CMDCPS_SAVE_ARCHIVE_FAILED,
		// Token: 0x04000400 RID: 1024
		[global::System.Runtime.Serialization.EnumMember]
		CMDCPS_POPULATE_COLUMNS_FAILED,
		// Token: 0x04000401 RID: 1025
		[global::System.Runtime.Serialization.EnumMember]
		CMDCPS_INVALID_ENHPRVCY_KEYVALUE,
		// Token: 0x04000402 RID: 1026
		[global::System.Runtime.Serialization.EnumMember]
		CMDCPS_ERROR_UNSUPPORTEDMODEL,
		// Token: 0x04000403 RID: 1027
		[global::System.Runtime.Serialization.EnumMember]
		CMDCPS_INVALID_OTAP_VALUE,
		// Token: 0x04000404 RID: 1028
		[global::System.Runtime.Serialization.EnumMember]
		CMDCPS_ERROR_UPDATE_TEMPLATE_NO_FEATURES,
		// Token: 0x04000405 RID: 1029
		[global::System.Runtime.Serialization.EnumMember]
		CMDCPS_ERROR_UPDATE_TEMPLATE_FEATURES,
		// Token: 0x04000406 RID: 1030
		[global::System.Runtime.Serialization.EnumMember]
		CMDCPS_ERROR_INVALID_UPGRADE_FEATURE,
		// Token: 0x04000407 RID: 1031
		[global::System.Runtime.Serialization.EnumMember]
		CMDCPS_ERROR_INVALID_LICENCES,
		// Token: 0x04000408 RID: 1032
		[global::System.Runtime.Serialization.EnumMember]
		CMDCPS_GENERATE_FEATURE_DATA_FAILED,
		// Token: 0x04000409 RID: 1033
		[global::System.Runtime.Serialization.EnumMember]
		CMDCPS_UPDATE_PBA_FEATURE_FAILED,
		// Token: 0x0400040A RID: 1034
		[global::System.Runtime.Serialization.EnumMember]
		CMDCPS_RADIO_NEED_UPGRADE,
		// Token: 0x0400040B RID: 1035
		[global::System.Runtime.Serialization.EnumMember]
		CMDCPS_CRUNCHER_PASSWORD_VALIDATION_FAILS,
		// Token: 0x0400040C RID: 1036
		[global::System.Runtime.Serialization.EnumMember]
		CMDCPS_CRUNCHER_IMPORT_FAILED_INVALID_REGION,
		// Token: 0x0400040D RID: 1037
		[global::System.Runtime.Serialization.EnumMember]
		CMDCPS_CRUNCHER_READ_FAILED_CAPMAX_NOT_SUPPORTED,
		// Token: 0x0400040E RID: 1038
		[global::System.Runtime.Serialization.EnumMember]
		CMDCPS_CRUNCHER_IMPORT_FAILED_CPS_NOT_FOUND,
		// Token: 0x0400040F RID: 1039
		[global::System.Runtime.Serialization.EnumMember]
		CMDCPS_CRUNCHER_UPGRADE_FAILED,
		// Token: 0x04000410 RID: 1040
		[global::System.Runtime.Serialization.EnumMember]
		CMDCPS_CRUNCHER_UPGRADE_FAILED_INVALID_REGION,
		// Token: 0x04000411 RID: 1041
		[global::System.Runtime.Serialization.EnumMember]
		CMDCPS_CRUNCHER_UPGRADE_FAILED_NO_AVAILABLE_PACKAGE,
		// Token: 0x04000412 RID: 1042
		[global::System.Runtime.Serialization.EnumMember]
		INVALID_REGIONID,
		// Token: 0x04000413 RID: 1043
		[global::System.Runtime.Serialization.EnumMember]
		CMDCPS_CRUNCHER_IMPORT_ARCHIVE_CONFIGMODE_FAILED,
		// Token: 0x04000414 RID: 1044
		[global::System.Runtime.Serialization.EnumMember]
		CMDCPS_CRUNCHER_UPGRADE_FAILED_INVALID_TUNING_VERSION,
		// Token: 0x04000415 RID: 1045
		[global::System.Runtime.Serialization.EnumMember]
		SFC_LM_TS_BASE_ERROR = 26000,
		// Token: 0x04000416 RID: 1046
		[global::System.Runtime.Serialization.EnumMember]
		SFC_LM_TS_BADPARAM,
		// Token: 0x04000417 RID: 1047
		[global::System.Runtime.Serialization.EnumMember]
		SFC_LM_TS_CANTMALLOC,
		// Token: 0x04000418 RID: 1048
		[global::System.Runtime.Serialization.EnumMember]
		SFC_LM_TS_OPEN_ERROR,
		// Token: 0x04000419 RID: 1049
		[global::System.Runtime.Serialization.EnumMember]
		SFC_LM_TS_CLOSE_ERROR,
		// Token: 0x0400041A RID: 1050
		[global::System.Runtime.Serialization.EnumMember]
		SFC_LM_TS_INIT,
		// Token: 0x0400041B RID: 1051
		[global::System.Runtime.Serialization.EnumMember]
		SFC_LM_TS_ACT_GEN_REQ,
		// Token: 0x0400041C RID: 1052
		[global::System.Runtime.Serialization.EnumMember]
		SFC_LM_TS_RETURN_GEN_REQ,
		// Token: 0x0400041D RID: 1053
		[global::System.Runtime.Serialization.EnumMember]
		SFC_LM_TS_REPAIR_GEN_REQ,
		// Token: 0x0400041E RID: 1054
		[global::System.Runtime.Serialization.EnumMember]
		SFC_LM_TS_RESERVED_9,
		// Token: 0x0400041F RID: 1055
		[global::System.Runtime.Serialization.EnumMember]
		SFC_LM_TS_DELETE,
		// Token: 0x04000420 RID: 1056
		[global::System.Runtime.Serialization.EnumMember]
		SFC_LM_TS_CANT_FIND,
		// Token: 0x04000421 RID: 1057
		[global::System.Runtime.Serialization.EnumMember]
		SFC_LM_TS_INTERNAL_ERROR,
		// Token: 0x04000422 RID: 1058
		[global::System.Runtime.Serialization.EnumMember]
		SFC_LM_TS_RESERVED_13,
		// Token: 0x04000423 RID: 1059
		[global::System.Runtime.Serialization.EnumMember]
		SFC_LM_TS_INVALID_INDEX,
		// Token: 0x04000424 RID: 1060
		[global::System.Runtime.Serialization.EnumMember]
		SFC_LM_TS_RESERVED_15,
		// Token: 0x04000425 RID: 1061
		[global::System.Runtime.Serialization.EnumMember]
		SFC_LM_TS_NO_ASR_FOUND,
		// Token: 0x04000426 RID: 1062
		[global::System.Runtime.Serialization.EnumMember]
		SFC_LM_TS_UPDATING_TS,
		// Token: 0x04000427 RID: 1063
		[global::System.Runtime.Serialization.EnumMember]
		SFC_LM_TS_SEND_RECEIVE,
		// Token: 0x04000428 RID: 1064
		[global::System.Runtime.Serialization.EnumMember]
		SFC_LM_TS_PROCESS_RESP,
		// Token: 0x04000429 RID: 1065
		[global::System.Runtime.Serialization.EnumMember]
		SFC_LM_TS_UNKNOWN_RESP,
		// Token: 0x0400042A RID: 1066
		[global::System.Runtime.Serialization.EnumMember]
		SFC_LM_TS_ASR_LOAD_ONCE,
		// Token: 0x0400042B RID: 1067
		[global::System.Runtime.Serialization.EnumMember]
		SFC_LM_TS_RESERVED_22,
		// Token: 0x0400042C RID: 1068
		[global::System.Runtime.Serialization.EnumMember]
		SFC_LM_TS_SHORT_CODE_PENDING,
		// Token: 0x0400042D RID: 1069
		[global::System.Runtime.Serialization.EnumMember]
		SFC_LM_TS_SHORT_CODE_ACT_CREATE,
		// Token: 0x0400042E RID: 1070
		[global::System.Runtime.Serialization.EnumMember]
		SFC_LM_TS_SHORT_CODE_REPAIR_CREATE,
		// Token: 0x0400042F RID: 1071
		[global::System.Runtime.Serialization.EnumMember]
		SFC_LM_TS_SHORT_CODE_RETURN_CREATE,
		// Token: 0x04000430 RID: 1072
		[global::System.Runtime.Serialization.EnumMember]
		SFC_LM_TS_SHORT_CODE_CANCEL,
		// Token: 0x04000431 RID: 1073
		[global::System.Runtime.Serialization.EnumMember]
		SFC_LM_TS_SHORT_CODE_PROCESS,
		// Token: 0x04000432 RID: 1074
		[global::System.Runtime.Serialization.EnumMember]
		SFC_LM_TS_SHORT_CODE_UNSUPPORTED,
		// Token: 0x04000433 RID: 1075
		[global::System.Runtime.Serialization.EnumMember]
		SFC_LM_TS_LOAD,
		// Token: 0x04000434 RID: 1076
		[global::System.Runtime.Serialization.EnumMember]
		SFC_LM_TS_FR_DISABLE,
		// Token: 0x04000435 RID: 1077
		[global::System.Runtime.Serialization.EnumMember]
		SFC_LM_TS_TIMEDOUT,
		// Token: 0x04000436 RID: 1078
		[global::System.Runtime.Serialization.EnumMember]
		SFC_LM_TS_INSUFFICIENT_RESOURCE,
		// Token: 0x04000437 RID: 1079
		[global::System.Runtime.Serialization.EnumMember]
		SFC_LM_TS_INVALID_REQUEST_TYPE,
		// Token: 0x04000438 RID: 1080
		[global::System.Runtime.Serialization.EnumMember]
		SFC_LM_TS_NO_MATCHING_FULFILLMENT,
		// Token: 0x04000439 RID: 1081
		[global::System.Runtime.Serialization.EnumMember]
		SFC_LM_TS_INVALID_REQUEST,
		// Token: 0x0400043A RID: 1082
		[global::System.Runtime.Serialization.EnumMember]
		SFC_LM_TS_RETURN_OUT_OF_CHAIN,
		// Token: 0x0400043B RID: 1083
		[global::System.Runtime.Serialization.EnumMember]
		SFC_LM_TS_MAX_COUNT_EXCEEDED,
		// Token: 0x0400043C RID: 1084
		[global::System.Runtime.Serialization.EnumMember]
		SFC_LM_TS_INSUFFICIENT_REPAIR_COUNT,
		// Token: 0x0400043D RID: 1085
		[global::System.Runtime.Serialization.EnumMember]
		SFC_LM_TS_OPERATIONS,
		// Token: 0x0400043E RID: 1086
		[global::System.Runtime.Serialization.EnumMember]
		SFC_LM_TS_CONNECTION_FAILED,
		// Token: 0x0400043F RID: 1087
		[global::System.Runtime.Serialization.EnumMember]
		SFC_LM_TS_SSL_ERROR,
		// Token: 0x04000440 RID: 1088
		[global::System.Runtime.Serialization.EnumMember]
		SFC_LM_TS_RETURN_INCOMPLETE,
		// Token: 0x04000441 RID: 1089
		[global::System.Runtime.Serialization.EnumMember]
		SFC_LM_TS_LOCAL_REPAIR,
		// Token: 0x04000442 RID: 1090
		[global::System.Runtime.Serialization.EnumMember]
		SFC_LM_TS_UNSUPPORTED_REQUEST_VERSION,
		// Token: 0x04000443 RID: 1091
		[global::System.Runtime.Serialization.EnumMember]
		SFC_LM_TS_UNSUPPORTED,
		// Token: 0x04000444 RID: 1092
		[global::System.Runtime.Serialization.EnumMember]
		SFC_LM_TS_CONFIGURATION,
		// Token: 0x04000445 RID: 1093
		[global::System.Runtime.Serialization.EnumMember]
		SFC_LM_TS_NO_PRODUCT_SET,
		// Token: 0x04000446 RID: 1094
		[global::System.Runtime.Serialization.EnumMember]
		SFC_INTERNERROR_FAILED_CREATE_LICSPEC,
		// Token: 0x04000447 RID: 1095
		[global::System.Runtime.Serialization.EnumMember]
		SFC_INTERNERROR_FAILED_POPULATE_TS,
		// Token: 0x04000448 RID: 1096
		[global::System.Runtime.Serialization.EnumMember]
		SFC_INTERNERROR_INVALID_INDEX,
		// Token: 0x04000449 RID: 1097
		[global::System.Runtime.Serialization.EnumMember]
		SFC_INTERNERROR_NO_CALLBACK_HANDLER,
		// Token: 0x0400044A RID: 1098
		[global::System.Runtime.Serialization.EnumMember]
		SFC_FULFILLMENTS_QUERY_FAILED,
		// Token: 0x0400044B RID: 1099
		[global::System.Runtime.Serialization.EnumMember]
		SFC_NO_LICENSES_LEFT,
		// Token: 0x0400044C RID: 1100
		[global::System.Runtime.Serialization.EnumMember]
		SFC_EID_ALREADY_REGISTERED_TO_SERIAL_NUM,
		// Token: 0x0400044D RID: 1101
		[global::System.Runtime.Serialization.EnumMember]
		SFC_SERVER_FAIL_RESPONSE,
		// Token: 0x0400044E RID: 1102
		[global::System.Runtime.Serialization.EnumMember]
		SFC_ENTITLEMENTS_QUERY_FAILED,
		// Token: 0x0400044F RID: 1103
		[global::System.Runtime.Serialization.EnumMember]
		SFC_RM_MAXLIMIT_NOLICENSE,
		// Token: 0x04000450 RID: 1104
		[global::System.Runtime.Serialization.EnumMember]
		SFC_RM_MAXLIMIT_LICENSE,
		// Token: 0x04000451 RID: 1105
		[global::System.Runtime.Serialization.EnumMember]
		SFC_RM_NO_WEB_REQUEST_DATA_SUPPLIED,
		// Token: 0x04000452 RID: 1106
		[global::System.Runtime.Serialization.EnumMember]
		SFC_RM_ERROR_RESPSONSE_RECEIVED_FROM_SERVER,
		// Token: 0x04000453 RID: 1107
		[global::System.Runtime.Serialization.EnumMember]
		SFC_RM_NO_FEATURE_ON_SERVER,
		// Token: 0x04000454 RID: 1108
		[global::System.Runtime.Serialization.EnumMember]
		SFC_RM_INVALID_SERVER_ADDRESS,
		// Token: 0x04000455 RID: 1109
		[global::System.Runtime.Serialization.EnumMember]
		SFC_HAS_REGISTER_IN_TS,
		// Token: 0x04000456 RID: 1110
		[global::System.Runtime.Serialization.EnumMember]
		SFC_FAILED_GET_FEATURE,
		// Token: 0x04000457 RID: 1111
		[global::System.Runtime.Serialization.EnumMember]
		SFC_FAILED_GET_LICENSE,
		// Token: 0x04000458 RID: 1112
		[global::System.Runtime.Serialization.EnumMember]
		SFC_FAILED_CONNECT,
		// Token: 0x04000459 RID: 1113
		[global::System.Runtime.Serialization.EnumMember]
		SFC_FAILED_REGISTER,
		// Token: 0x0400045A RID: 1114
		[global::System.Runtime.Serialization.EnumMember]
		SFC_FAILED_RETURN,
		// Token: 0x0400045B RID: 1115
		[global::System.Runtime.Serialization.EnumMember]
		SFC_SERVER_TIMEOUT,
		// Token: 0x0400045C RID: 1116
		[global::System.Runtime.Serialization.EnumMember]
		FNE_FLXERR_BAD_PARAM = 28000,
		// Token: 0x0400045D RID: 1117
		[global::System.Runtime.Serialization.EnumMember]
		FNE_FLXERR_BUFFER_SIZE_INSUFFICIENT,
		// Token: 0x0400045E RID: 1118
		[global::System.Runtime.Serialization.EnumMember]
		FNE_FLXERR_CALLOUT_ERROR_DATA_MISSING,
		// Token: 0x0400045F RID: 1119
		[global::System.Runtime.Serialization.EnumMember]
		FNE_FLXERR_DATA_CORRUPTED,
		// Token: 0x04000460 RID: 1120
		[global::System.Runtime.Serialization.EnumMember]
		FNE_FLXERR_DATA_EXCEEDS_MAX_SIZE,
		// Token: 0x04000461 RID: 1121
		[global::System.Runtime.Serialization.EnumMember]
		FNE_FLXERR_DATA_INSUFFICIENT,
		// Token: 0x04000462 RID: 1122
		[global::System.Runtime.Serialization.EnumMember]
		FNE_FLXERR_DATE_INVALID,
		// Token: 0x04000463 RID: 1123
		[global::System.Runtime.Serialization.EnumMember]
		FNE_FLXERR_DICTIONARY_READ_ONLY,
		// Token: 0x04000464 RID: 1124
		[global::System.Runtime.Serialization.EnumMember]
		FNE_FLXERR_FEATURE_EXPIRED,
		// Token: 0x04000465 RID: 1125
		[global::System.Runtime.Serialization.EnumMember]
		FNE_FLXERR_FEATURE_HOST_ID_MISMATCH,
		// Token: 0x04000466 RID: 1126
		[global::System.Runtime.Serialization.EnumMember]
		FNE_FLXERR_FEATURE_NOT_FOUND,
		// Token: 0x04000467 RID: 1127
		[global::System.Runtime.Serialization.EnumMember]
		FNE_FLXERR_FEATURE_NOT_STARTED,
		// Token: 0x04000468 RID: 1128
		[global::System.Runtime.Serialization.EnumMember]
		FNE_FLXERR_FEATURE_VENDOR_NAME_INVALID,
		// Token: 0x04000469 RID: 1129
		[global::System.Runtime.Serialization.EnumMember]
		FNE_FLXERR_FEATURE_VERSION_NOT_FOUND,
		// Token: 0x0400046A RID: 1130
		[global::System.Runtime.Serialization.EnumMember]
		FNE_FLXERR_HOST_ID_UNSUPPORTED,
		// Token: 0x0400046B RID: 1131
		[global::System.Runtime.Serialization.EnumMember]
		FNE_FLXERR_IDENTITY_UNSUPPORTED_VERSION,
		// Token: 0x0400046C RID: 1132
		[global::System.Runtime.Serialization.EnumMember]
		FNE_FLXERR_ITEM_ALREADY_EXISTS,
		// Token: 0x0400046D RID: 1133
		[global::System.Runtime.Serialization.EnumMember]
		FNE_FLXERR_ITEM_NOT_FOUND,
		// Token: 0x0400046E RID: 1134
		[global::System.Runtime.Serialization.EnumMember]
		FNE_FLXERR_ITEM_TYPE_MISMATCH,
		// Token: 0x0400046F RID: 1135
		[global::System.Runtime.Serialization.EnumMember]
		FNE_FLXERR_INDEX_OUT_OF_BOUND,
		// Token: 0x04000470 RID: 1136
		[global::System.Runtime.Serialization.EnumMember]
		FNE_FLXERR_KEY_ALREADY_EXISTS,
		// Token: 0x04000471 RID: 1137
		[global::System.Runtime.Serialization.EnumMember]
		FNE_FLXERR_KEY_NOT_FOUND,
		// Token: 0x04000472 RID: 1138
		[global::System.Runtime.Serialization.EnumMember]
		FNE_FLXERR_LICENSE_NOT_FOUND,
		// Token: 0x04000473 RID: 1139
		[global::System.Runtime.Serialization.EnumMember]
		FNE_FLXERR_LICENSE_SOURCE_TYPE_INVALID,
		// Token: 0x04000474 RID: 1140
		[global::System.Runtime.Serialization.EnumMember]
		FNE_FLXERR_PRODUCT_TYPE_INVALID,
		// Token: 0x04000475 RID: 1141
		[global::System.Runtime.Serialization.EnumMember]
		FNE_FLXERR_RESPONSE_EXPIRED,
		// Token: 0x04000476 RID: 1142
		[global::System.Runtime.Serialization.EnumMember]
		FNE_FLXERR_RESPONSE_HOST_ID_MISMATCH,
		// Token: 0x04000477 RID: 1143
		[global::System.Runtime.Serialization.EnumMember]
		FNE_FLXERR_RESPONSE_SERVER_ERROR,
		// Token: 0x04000478 RID: 1144
		[global::System.Runtime.Serialization.EnumMember]
		FNE_FLXERR_RESPONSE_STALE,
		// Token: 0x04000479 RID: 1145
		[global::System.Runtime.Serialization.EnumMember]
		FNE_FLXERR_SIGNATURE_INVALID,
		// Token: 0x0400047A RID: 1146
		[global::System.Runtime.Serialization.EnumMember]
		FNE_FLXERR_SIGNATURE_TYPE_MISMATCH,
		// Token: 0x0400047B RID: 1147
		[global::System.Runtime.Serialization.EnumMember]
		FNE_FLXERR_TRIAL_ALREADY_LOADED,
		// Token: 0x0400047C RID: 1148
		[global::System.Runtime.Serialization.EnumMember]
		FNE_FLXERR_TRIAL_EXPIRED,
		// Token: 0x0400047D RID: 1149
		[global::System.Runtime.Serialization.EnumMember]
		FNE_FLXERR_TRIAL_INVALID_ID,
		// Token: 0x0400047E RID: 1150
		[global::System.Runtime.Serialization.EnumMember]
		FNE_FLXERR_TS_ANCHOR_BREAK,
		// Token: 0x0400047F RID: 1151
		[global::System.Runtime.Serialization.EnumMember]
		FNE_FLXERR_TS_BINDING_BREAK,
		// Token: 0x04000480 RID: 1152
		[global::System.Runtime.Serialization.EnumMember]
		FNE_FLXERR_TS_CORRUPTED,
		// Token: 0x04000481 RID: 1153
		[global::System.Runtime.Serialization.EnumMember]
		FNE_FLXERR_TS_INCONSISTENT_DATA,
		// Token: 0x04000482 RID: 1154
		[global::System.Runtime.Serialization.EnumMember]
		FNE_FLXERR_TS_UNSUPPORTED_VERSION,
		// Token: 0x04000483 RID: 1155
		[global::System.Runtime.Serialization.EnumMember]
		FNE_FLXERR_STORAGE_CLASS_INCOMPLETE,
		// Token: 0x04000484 RID: 1156
		[global::System.Runtime.Serialization.EnumMember]
		FNE_FLXERR_VENDOR_KEYS_EXPIRED,
		// Token: 0x04000485 RID: 1157
		[global::System.Runtime.Serialization.EnumMember]
		FNE_FLXERR_VENDOR_KEYS_INVALID,
		// Token: 0x04000486 RID: 1158
		[global::System.Runtime.Serialization.EnumMember]
		FNE_FLXERR_VENDOR_KEYS_NOT_ENABLED,
		// Token: 0x04000487 RID: 1159
		[global::System.Runtime.Serialization.EnumMember]
		FNE_FLXERR_IDENTITY_MISMATCH,
		// Token: 0x04000488 RID: 1160
		[global::System.Runtime.Serialization.EnumMember]
		FNE_FLXERR_WINDBACK_DETECTED,
		// Token: 0x04000489 RID: 1161
		[global::System.Runtime.Serialization.EnumMember]
		FNE_FLXERR_WINDBACK_NOT_ENABLED,
		// Token: 0x0400048A RID: 1162
		[global::System.Runtime.Serialization.EnumMember]
		FNE_FLXERR_DATA_UNSUPPORTED_VERSION,
		// Token: 0x0400048B RID: 1163
		[global::System.Runtime.Serialization.EnumMember]
		FNE_FLXERR_FEATURE_INSUFFICIENT_COUNT,
		// Token: 0x0400048C RID: 1164
		[global::System.Runtime.Serialization.EnumMember]
		FNE_FLXERR_OBJECT_READ_ONLY,
		// Token: 0x0400048D RID: 1165
		[global::System.Runtime.Serialization.EnumMember]
		FNE_FLXERR_VERSION_STRING_INVALID,
		// Token: 0x0400048E RID: 1166
		[global::System.Runtime.Serialization.EnumMember]
		FNE_FLXERR_KEY_REVISION_UNAVAILABLE,
		// Token: 0x0400048F RID: 1167
		[global::System.Runtime.Serialization.EnumMember]
		FNE_FLXERR_FEATURE_SERVER_HOST_ID_MISMATCH,
		// Token: 0x04000490 RID: 1168
		[global::System.Runtime.Serialization.EnumMember]
		FNE_FLXERR_NO_SERVER_DATA_FOUND,
		// Token: 0x04000491 RID: 1169
		[global::System.Runtime.Serialization.EnumMember]
		FNE_FLXERR_NO_SERVER_UPDATE_NEEDED,
		// Token: 0x04000492 RID: 1170
		[global::System.Runtime.Serialization.EnumMember]
		FNE_FLXERR_FEATURE_SERVER_NODE_LOCKED,
		// Token: 0x04000493 RID: 1171
		[global::System.Runtime.Serialization.EnumMember]
		FNE_FLXERR_FEATURE_SERVER_DUPLICATE,
		// Token: 0x04000494 RID: 1172
		[global::System.Runtime.Serialization.EnumMember]
		FNE_FLXERR_INPUT_TYPE_MISMATCH,
		// Token: 0x04000495 RID: 1173
		[global::System.Runtime.Serialization.EnumMember]
		FNE_FLXERR_NO_SERVER_RESPONDED,
		// Token: 0x04000496 RID: 1174
		[global::System.Runtime.Serialization.EnumMember]
		FNE_FLXERR_NO_NEW_SERVER_RESPONDED,
		// Token: 0x04000497 RID: 1175
		[global::System.Runtime.Serialization.EnumMember]
		FNE_FLXERR_CAPABILITY_RESPONSE_DATA_MISSING,
		// Token: 0x04000498 RID: 1176
		[global::System.Runtime.Serialization.EnumMember]
		FNE_FLXERR_SYNC_FROM_FNO_INCOMPLETE,
		// Token: 0x04000499 RID: 1177
		[global::System.Runtime.Serialization.EnumMember]
		FNE_FLXERR_IDENTITY_TYPE_INCORRECT,
		// Token: 0x0400049A RID: 1178
		[global::System.Runtime.Serialization.EnumMember]
		FNE_FLXERR_MACHINE_TYPE_MISMATCH,
		// Token: 0x0400049B RID: 1179
		[global::System.Runtime.Serialization.EnumMember]
		FNE_FLXERR_NO_UUID_FOUND,
		// Token: 0x0400049C RID: 1180
		[global::System.Runtime.Serialization.EnumMember]
		FNE_FLXERR_BAD_CALLOUT_ERROR_CODE,
		// Token: 0x0400049D RID: 1181
		[global::System.Runtime.Serialization.EnumMember]
		FNE_FLXERR_BAD_CALLOUT_UNIT_IDENTIFIER,
		// Token: 0x0400049E RID: 1182
		[global::System.Runtime.Serialization.EnumMember]
		FNE_FLXERR_UNSUPPORTED_TOLERANCE_SPECIFIER_VERSION,
		// Token: 0x0400049F RID: 1183
		[global::System.Runtime.Serialization.EnumMember]
		FNE_FLXERR_NON_CLIENT_TOLERANCE_SPECIFIER,
		// Token: 0x040004A0 RID: 1184
		[global::System.Runtime.Serialization.EnumMember]
		FNE_FLXERR_BADLY_FORMED_TOLERANCE_SPECIFIER,
		// Token: 0x040004A1 RID: 1185
		[global::System.Runtime.Serialization.EnumMember]
		FNE_FLXERR_TOLERANCE_SPECIFIER_REJECTED,
		// Token: 0x040004A2 RID: 1186
		[global::System.Runtime.Serialization.EnumMember]
		FNE_FLXERR_UNSUPPORTED_TOLERANCE_SPECIFIER_TYPE,
		// Token: 0x040004A3 RID: 1187
		[global::System.Runtime.Serialization.EnumMember]
		FNE_FLXERR_BAD_TOLERANCE_SPECIFIER_RATIO,
		// Token: 0x040004A4 RID: 1188
		[global::System.Runtime.Serialization.EnumMember]
		FNE_FLXERR_INFORMATION_MESSAGE_USAGE_TYPE_CONFLICT,
		// Token: 0x040004A5 RID: 1189
		[global::System.Runtime.Serialization.EnumMember]
		FNE_FAILED_TOCREATE_ERROR,
		// Token: 0x040004A6 RID: 1190
		[global::System.Runtime.Serialization.EnumMember]
		FNE_FAILED_INITIALIZE_LICENSING,
		// Token: 0x040004A7 RID: 1191
		[global::System.Runtime.Serialization.EnumMember]
		FNE_FAILED_DECODE_RESPONSE,
		// Token: 0x040004A8 RID: 1192
		[global::System.Runtime.Serialization.EnumMember]
		FNE_FAILED_UPDATE_FEATURECOLLECTION,
		// Token: 0x040004A9 RID: 1193
		[global::System.Runtime.Serialization.EnumMember]
		FNE_FAILED_NOREQUEST,
		// Token: 0x040004AA RID: 1194
		[global::System.Runtime.Serialization.EnumMember]
		FNE_FAILED_LICENSE_MISMATCH,
		// Token: 0x040004AB RID: 1195
		[global::System.Runtime.Serialization.EnumMember]
		FNE_FAILED_GETHOSTID,
		// Token: 0x040004AC RID: 1196
		[global::System.Runtime.Serialization.EnumMember]
		FNE_FAILED_GET_FEATURECOLLECTION,
		// Token: 0x040004AD RID: 1197
		[global::System.Runtime.Serialization.EnumMember]
		FNE_FAILED_GET_ENTITLEMENT_DETAILS,
		// Token: 0x040004AE RID: 1198
		[global::System.Runtime.Serialization.EnumMember]
		FNE_FAILED_GET_DEVICES_QUERY,
		// Token: 0x040004AF RID: 1199
		[global::System.Runtime.Serialization.EnumMember]
		FNE_FAILED_SEND_ACTIVATION_REQUEST,
		// Token: 0x040004B0 RID: 1200
		[global::System.Runtime.Serialization.EnumMember]
		FNE_FAILED_SEND_RECOVER_REQUEST,
		// Token: 0x040004B1 RID: 1201
		[global::System.Runtime.Serialization.EnumMember]
		FNE_FAILED_HOST_ID_MISMATCH,
		// Token: 0x040004B2 RID: 1202
		[global::System.Runtime.Serialization.EnumMember]
		FNE_FAILED_GETHOSTID_RM_SERVER_UNINSTALL,
		// Token: 0x040004B3 RID: 1203
		[global::System.Runtime.Serialization.EnumMember]
		FNE_FAILED_GETHOSTID_PCR_UNINSTALL,
		// Token: 0x040004B4 RID: 1204
		[global::System.Runtime.Serialization.EnumMember]
		FNE_FAILED_GETHOSTID_NEED_TO_REHOST,
		// Token: 0x040004B5 RID: 1205
		[global::System.Runtime.Serialization.EnumMember]
		FNE_LICENSING_NOT_INITIALIZED,
		// Token: 0x040004B6 RID: 1206
		[global::System.Runtime.Serialization.EnumMember]
		CLI_FAILED_GET_ENTITLEMENT_DETAILS = 29850,
		// Token: 0x040004B7 RID: 1207
		[global::System.Runtime.Serialization.EnumMember]
		CLI_FAILED_GET_DEVICE_QUERY,
		// Token: 0x040004B8 RID: 1208
		[global::System.Runtime.Serialization.EnumMember]
		CLI_FAILED_INITIALIZE_LICENSING,
		// Token: 0x040004B9 RID: 1209
		[global::System.Runtime.Serialization.EnumMember]
		CLI_NO_RESPONSE_FROM_SERVER,
		// Token: 0x040004BA RID: 1210
		[global::System.Runtime.Serialization.EnumMember]
		CLI_FAILED_SEND_REQUEST_TO_SERVER,
		// Token: 0x040004BB RID: 1211
		[global::System.Runtime.Serialization.EnumMember]
		CLI_FAILED_QUERY_FEATURES_FROM_TS,
		// Token: 0x040004BC RID: 1212
		[global::System.Runtime.Serialization.EnumMember]
		CLI_FAILED_SEND_RECOVER_REQUEST_TO_SERVER,
		// Token: 0x040004BD RID: 1213
		[global::System.Runtime.Serialization.EnumMember]
		CLI_FAILED_QUERY_FEATURES_FROM_RESPONSE,
		// Token: 0x040004BE RID: 1214
		[global::System.Runtime.Serialization.EnumMember]
		CLI_ERROR,
		// Token: 0x040004BF RID: 1215
		[global::System.Runtime.Serialization.EnumMember]
		PbaObjectIsIncomplete = 30000,
		// Token: 0x040004C0 RID: 1216
		[global::System.Runtime.Serialization.EnumMember]
		RMSU_Error_Adding_Item = 30050,
		// Token: 0x040004C1 RID: 1217
		[global::System.Runtime.Serialization.EnumMember]
		RMSU_Error_Admin_rights_needed,
		// Token: 0x040004C2 RID: 1218
		[global::System.Runtime.Serialization.EnumMember]
		RMSU_Error_Backup,
		// Token: 0x040004C3 RID: 1219
		[global::System.Runtime.Serialization.EnumMember]
		RMSU_Error_BackupMissingFiles,
		// Token: 0x040004C4 RID: 1220
		[global::System.Runtime.Serialization.EnumMember]
		RMSU_Error_Cannot_Connect_to_Server,
		// Token: 0x040004C5 RID: 1221
		[global::System.Runtime.Serialization.EnumMember]
		RMSU_Error_Cannot_Create_Backup_Folder,
		// Token: 0x040004C6 RID: 1222
		[global::System.Runtime.Serialization.EnumMember]
		RMSU_Error_Could_not_start_service,
		// Token: 0x040004C7 RID: 1223
		[global::System.Runtime.Serialization.EnumMember]
		RMSU_Error_Disconnect,
		// Token: 0x040004C8 RID: 1224
		[global::System.Runtime.Serialization.EnumMember]
		RMSU_Error_FileRepositoryMissing,
		// Token: 0x040004C9 RID: 1225
		[global::System.Runtime.Serialization.EnumMember]
		RMSU_Error_Invalid_Encryption_Inputs,
		// Token: 0x040004CA RID: 1226
		[global::System.Runtime.Serialization.EnumMember]
		RMSU_Error_invalid_move_location,
		// Token: 0x040004CB RID: 1227
		[global::System.Runtime.Serialization.EnumMember]
		RMSU_Error_Invalid_Source,
		// Token: 0x040004CC RID: 1228
		[global::System.Runtime.Serialization.EnumMember]
		RMSU_Error_Invalid_Source_Dest,
		// Token: 0x040004CD RID: 1229
		[global::System.Runtime.Serialization.EnumMember]
		RMSU_Error_InvalidBackupDest,
		// Token: 0x040004CE RID: 1230
		[global::System.Runtime.Serialization.EnumMember]
		RMSU_Error_Missing_Database_Restore,
		// Token: 0x040004CF RID: 1231
		[global::System.Runtime.Serialization.EnumMember]
		RMSU_Error_Missing_files,
		// Token: 0x040004D0 RID: 1232
		[global::System.Runtime.Serialization.EnumMember]
		RMSU_Error_occurred,
		// Token: 0x040004D1 RID: 1233
		[global::System.Runtime.Serialization.EnumMember]
		RMSU_Error_Restore_failure,
		// Token: 0x040004D2 RID: 1234
		[global::System.Runtime.Serialization.EnumMember]
		RMSU_Error_RMVersionMismatch,
		// Token: 0x040004D3 RID: 1235
		[global::System.Runtime.Serialization.EnumMember]
		RMSU_Error_Service_missing,
		// Token: 0x040004D4 RID: 1236
		[global::System.Runtime.Serialization.EnumMember]
		RMSU_Error_source_equals_dest,
		// Token: 0x040004D5 RID: 1237
		[global::System.Runtime.Serialization.EnumMember]
		RMSU_Error_Translating_UPN,
		// Token: 0x040004D6 RID: 1238
		[global::System.Runtime.Serialization.EnumMember]
		RMSU_Error_CreateConnectionString,
		// Token: 0x040004D7 RID: 1239
		[global::System.Runtime.Serialization.EnumMember]
		RMSU_Error_Backup_Generic,
		// Token: 0x040004D8 RID: 1240
		[global::System.Runtime.Serialization.EnumMember]
		RMSU_Error_CannotCreateTempFile,
		// Token: 0x040004D9 RID: 1241
		[global::System.Runtime.Serialization.EnumMember]
		RMSU_Error_Backup_SQLGeneric,
		// Token: 0x040004DA RID: 1242
		[global::System.Runtime.Serialization.EnumMember]
		RMSU_Error_Generic_File_Decryption,
		// Token: 0x040004DB RID: 1243
		[global::System.Runtime.Serialization.EnumMember]
		RMSU_Error_RetrievingRMVersionFromConfig,
		// Token: 0x040004DC RID: 1244
		[global::System.Runtime.Serialization.EnumMember]
		RMSU_Error_RetrievingRMVersionFromConfigAndDB,
		// Token: 0x040004DD RID: 1245
		[global::System.Runtime.Serialization.EnumMember]
		RMSU_Error_MissingBackupPropFile,
		// Token: 0x040004DE RID: 1246
		[global::System.Runtime.Serialization.EnumMember]
		RMSU_Error_RetrievingPassPhraseFromConfig,
		// Token: 0x040004DF RID: 1247
		[global::System.Runtime.Serialization.EnumMember]
		RMSU_Error_InvalidPassPhraseValue,
		// Token: 0x040004E0 RID: 1248
		[global::System.Runtime.Serialization.EnumMember]
		RMSU_Error_FileRepRestore_Generic,
		// Token: 0x040004E1 RID: 1249
		[global::System.Runtime.Serialization.EnumMember]
		RMSU_Error_Restore_SQLGeneric,
		// Token: 0x040004E2 RID: 1250
		[global::System.Runtime.Serialization.EnumMember]
		RMSU_Error_Restore_DBKeyGeneric,
		// Token: 0x040004E3 RID: 1251
		[global::System.Runtime.Serialization.EnumMember]
		RMSU_Error_Move_Generic,
		// Token: 0x040004E4 RID: 1252
		[global::System.Runtime.Serialization.EnumMember]
		RMSU_Error_RetreivingServiceStatus,
		// Token: 0x040004E5 RID: 1253
		[global::System.Runtime.Serialization.EnumMember]
		RMSU_Error_StoppingService,
		// Token: 0x040004E6 RID: 1254
		[global::System.Runtime.Serialization.EnumMember]
		RMSU_Error_RetrievingConfigValue,
		// Token: 0x040004E7 RID: 1255
		[global::System.Runtime.Serialization.EnumMember]
		RMSU_Error_WritingConfigValue,
		// Token: 0x040004E8 RID: 1256
		[global::System.Runtime.Serialization.EnumMember]
		RMSU_Error_Encryption_MissingFile,
		// Token: 0x040004E9 RID: 1257
		[global::System.Runtime.Serialization.EnumMember]
		RMSU_Error_EncryptFile,
		// Token: 0x040004EA RID: 1258
		[global::System.Runtime.Serialization.EnumMember]
		RMSU_Error_Invalid_Decryption_Inputs,
		// Token: 0x040004EB RID: 1259
		[global::System.Runtime.Serialization.EnumMember]
		RMSU_Error_Decryption_MissingFile,
		// Token: 0x040004EC RID: 1260
		[global::System.Runtime.Serialization.EnumMember]
		RMSU_Error_DecryptFile,
		// Token: 0x040004ED RID: 1261
		[global::System.Runtime.Serialization.EnumMember]
		RMSU_Error_DecryptBOM,
		// Token: 0x040004EE RID: 1262
		[global::System.Runtime.Serialization.EnumMember]
		RMSU_Missing_RM_Server_Files,
		// Token: 0x040004EF RID: 1263
		[global::System.Runtime.Serialization.EnumMember]
		RMSU_No_Objects_Found,
		// Token: 0x040004F0 RID: 1264
		[global::System.Runtime.Serialization.EnumMember]
		RMSU_Error_NotEnoughDiskSpace,
		// Token: 0x040004F1 RID: 1265
		[global::System.Runtime.Serialization.EnumMember]
		RMSU_Error_RetrievingPropertyValue,
		// Token: 0x040004F2 RID: 1266
		[global::System.Runtime.Serialization.EnumMember]
		RMSU_Error_KeyNotFoundInAppSetting,
		// Token: 0x040004F3 RID: 1267
		[global::System.Runtime.Serialization.EnumMember]
		RMSU_Error_DisplayingStatusPage,
		// Token: 0x040004F4 RID: 1268
		[global::System.Runtime.Serialization.EnumMember]
		RMSU_Error_UpdatingStatusPage,
		// Token: 0x040004F5 RID: 1269
		[global::System.Runtime.Serialization.EnumMember]
		RMSU_Error_InitializeStatusPage,
		// Token: 0x040004F6 RID: 1270
		[global::System.Runtime.Serialization.EnumMember]
		RMSU_Error_QueryServiceStatus,
		// Token: 0x040004F7 RID: 1271
		[global::System.Runtime.Serialization.EnumMember]
		RMSU_Error_UpdateServiceStatus,
		// Token: 0x040004F8 RID: 1272
		[global::System.Runtime.Serialization.EnumMember]
		RMSU_Error_ClearDBLock,
		// Token: 0x040004F9 RID: 1273
		[global::System.Runtime.Serialization.EnumMember]
		RMSU_Error_Refresh_Status,
		// Token: 0x040004FA RID: 1274
		[global::System.Runtime.Serialization.EnumMember]
		RMSU_Error_Duplicate_Username_Entry,
		// Token: 0x040004FB RID: 1275
		[global::System.Runtime.Serialization.EnumMember]
		RMSU_Error_Can_Not_Connect_To_DB,
		// Token: 0x040004FC RID: 1276
		[global::System.Runtime.Serialization.EnumMember]
		RMSU_Error_IO_ERROR,
		// Token: 0x040004FD RID: 1277
		[global::System.Runtime.Serialization.EnumMember]
		RMSU_Error_SMO_ERROR,
		// Token: 0x040004FE RID: 1278
		[global::System.Runtime.Serialization.EnumMember]
		RMSU_Invalid_File_Path,
		// Token: 0x040004FF RID: 1279
		[global::System.Runtime.Serialization.EnumMember]
		RMSU_FAILED_TO_SET_RESTORE_PATH,
		// Token: 0x04000500 RID: 1280
		[global::System.Runtime.Serialization.EnumMember]
		RMSU_ADD_ADMIN_ERROR,
		// Token: 0x04000501 RID: 1281
		[global::System.Runtime.Serialization.EnumMember]
		Constrain_BluetoothDUNPeerIP_NoSame_PeerIP,
		// Token: 0x04000502 RID: 1282
		[global::System.Runtime.Serialization.EnumMember]
		Constrain_BluetoothDUNPeerIP_NoSame_SubIP,
		// Token: 0x04000503 RID: 1283
		[global::System.Runtime.Serialization.EnumMember]
		Constrain_BluetoothDUNSubIP_NoSame_BDUNPeerIP,
		// Token: 0x04000504 RID: 1284
		[global::System.Runtime.Serialization.EnumMember]
		Constrain_BluetoothDUNSubIP_NoSame_PeerIP,
		// Token: 0x04000505 RID: 1285
		[global::System.Runtime.Serialization.EnumMember]
		Constrain_BluetoothDUNSubIP_NoSame_SubIP,
		// Token: 0x04000506 RID: 1286
		[global::System.Runtime.Serialization.EnumMember]
		Constrain_BluetoothName_Over14Chars,
		// Token: 0x04000507 RID: 1287
		[global::System.Runtime.Serialization.EnumMember]
		Constrain_InvalidOTARId,
		// Token: 0x04000508 RID: 1288
		[global::System.Runtime.Serialization.EnumMember]
		Constrain_InvalidRadioAlias,
		// Token: 0x04000509 RID: 1289
		[global::System.Runtime.Serialization.EnumMember]
		Constrain_IP_NoStartZero,
		// Token: 0x0400050A RID: 1290
		[global::System.Runtime.Serialization.EnumMember]
		Constrain_IP_NotProperFormat,
		// Token: 0x0400050B RID: 1291
		[global::System.Runtime.Serialization.EnumMember]
		Constrain_IPFirstPart_NotProperNumber,
		// Token: 0x0400050C RID: 1292
		[global::System.Runtime.Serialization.EnumMember]
		Constrain_IP_NotProperClassCFormat,
		// Token: 0x0400050D RID: 1293
		[global::System.Runtime.Serialization.EnumMember]
		Constrain_IP_NotProperClassBFormat,
		// Token: 0x0400050E RID: 1294
		[global::System.Runtime.Serialization.EnumMember]
		Constrain_IP_NotProperClassAFormat,
		// Token: 0x0400050F RID: 1295
		[global::System.Runtime.Serialization.EnumMember]
		Constrain_PeerIP_NoSame_AirInterfaceIP,
		// Token: 0x04000510 RID: 1296
		[global::System.Runtime.Serialization.EnumMember]
		Constrain_ProfileBluetoothDUNPeerIP_NoSame_ProfilePeerIP,
		// Token: 0x04000511 RID: 1297
		[global::System.Runtime.Serialization.EnumMember]
		Constrain_ProfileBluetoothDUNPeerIP_NoSame_ProfileSubIP,
		// Token: 0x04000512 RID: 1298
		[global::System.Runtime.Serialization.EnumMember]
		Constrain_ProfileBluetoothDUNSubIP_NoSame_ProfileBDUNPeerIP,
		// Token: 0x04000513 RID: 1299
		[global::System.Runtime.Serialization.EnumMember]
		Constrain_ProfileBluetoothDUNSubIP_NoSame_ProfilePeerIP,
		// Token: 0x04000514 RID: 1300
		[global::System.Runtime.Serialization.EnumMember]
		Constrain_ProfileBluetoothDUNSubIP_NoSame_ProfileSubIP,
		// Token: 0x04000515 RID: 1301
		[global::System.Runtime.Serialization.EnumMember]
		Constrain_ProfilePeerIP_NoSame_AirInterfaceIP,
		// Token: 0x04000516 RID: 1302
		[global::System.Runtime.Serialization.EnumMember]
		Constrain_ProfilePeerIP_Same_DataWidePeerIP,
		// Token: 0x04000517 RID: 1303
		[global::System.Runtime.Serialization.EnumMember]
		Constrain_ProfileSubscriberIP_Same_DataWideSubscriberIP,
		// Token: 0x04000518 RID: 1304
		[global::System.Runtime.Serialization.EnumMember]
		Constrain_ProfileBluetoothDUNPeerIP_Same_DataWideBluetoothDUNPeerIP,
		// Token: 0x04000519 RID: 1305
		[global::System.Runtime.Serialization.EnumMember]
		Constrain_ProfileBluetoothDUNSubIP_Same_DataWideBluetoothDUNSubIP,
		// Token: 0x0400051A RID: 1306
		[global::System.Runtime.Serialization.EnumMember]
		Constrain_ProfileSubIP_NoSame_AirInterfaceIP,
		// Token: 0x0400051B RID: 1307
		[global::System.Runtime.Serialization.EnumMember]
		Constrain_ProfileSubIP_NoSame_AutomaticRegistrationServerAddressIP,
		// Token: 0x0400051C RID: 1308
		[global::System.Runtime.Serialization.EnumMember]
		Constrain_ProfileSubIP_NoSame_ProfilePeerIP,
		// Token: 0x0400051D RID: 1309
		[global::System.Runtime.Serialization.EnumMember]
		Constrain_SubAirInterfaceIP_NoSame_AutomaticRegistrationServerAddressIP,
		// Token: 0x0400051E RID: 1310
		[global::System.Runtime.Serialization.EnumMember]
		Constrain_SubAirInterfaceIP_NoSame_BlueToothDUNPeerIP,
		// Token: 0x0400051F RID: 1311
		[global::System.Runtime.Serialization.EnumMember]
		Constrain_SubAirInterfaceIP_NoSame_BlueToothDUNSubIP,
		// Token: 0x04000520 RID: 1312
		[global::System.Runtime.Serialization.EnumMember]
		Constrain_SubAirInterfaceIP_NoSame_PeerIP,
		// Token: 0x04000521 RID: 1313
		[global::System.Runtime.Serialization.EnumMember]
		Constrain_SubAirInterfaceIP_NoSame_ProfileBlueToothDUNPeerIP,
		// Token: 0x04000522 RID: 1314
		[global::System.Runtime.Serialization.EnumMember]
		Constrain_SubAirInterfaceIP_NoSame_ProfileBlueToothDUNSubIP,
		// Token: 0x04000523 RID: 1315
		[global::System.Runtime.Serialization.EnumMember]
		Constrain_SubAirInterfaceIP_NoSame_ProfilePeerIP,
		// Token: 0x04000524 RID: 1316
		[global::System.Runtime.Serialization.EnumMember]
		Constrain_SubAirInterfaceIP_NoSame_ProfileSubIP,
		// Token: 0x04000525 RID: 1317
		[global::System.Runtime.Serialization.EnumMember]
		Constrain_SubAirInterfaceIP_NoSame_SubIP,
		// Token: 0x04000526 RID: 1318
		[global::System.Runtime.Serialization.EnumMember]
		Constrain_SubIP_NoSame_AutomaticRegistrationServerAddressIP,
		// Token: 0x04000527 RID: 1319
		[global::System.Runtime.Serialization.EnumMember]
		Constrain_SubIP_NoSame_LocationServerIPAddress,
		// Token: 0x04000528 RID: 1320
		[global::System.Runtime.Serialization.EnumMember]
		Constrain_ProfileSubIP_NoSame_LocationServerIPAddress,
		// Token: 0x04000529 RID: 1321
		[global::System.Runtime.Serialization.EnumMember]
		Constrain_ProfileBlueToothDunSubIP_NoSame_LocationServerIPAddress,
		// Token: 0x0400052A RID: 1322
		[global::System.Runtime.Serialization.EnumMember]
		Constrain_SubAirInterfaceIP_NoSame_LocationServerIPAddress,
		// Token: 0x0400052B RID: 1323
		[global::System.Runtime.Serialization.EnumMember]
		Constrain_BluetoothDUNSubIP_NoSame_LocationServerIPAddress,
		// Token: 0x0400052C RID: 1324
		[global::System.Runtime.Serialization.EnumMember]
		Constrain_SubIP_NoSame_PeerIP,
		// Token: 0x0400052D RID: 1325
		[global::System.Runtime.Serialization.EnumMember]
		Constrain_SubIP_NoSame_ProfilePeerIP,
		// Token: 0x0400052E RID: 1326
		[global::System.Runtime.Serialization.EnumMember]
		Constrain_UserLoginUnitID_CannotAllWhiteSpace,
		// Token: 0x0400052F RID: 1327
		[global::System.Runtime.Serialization.EnumMember]
		Constrain_UserLoginUnitID_Exceed_User_Login_UnitID_Text_Size,
		// Token: 0x04000530 RID: 1328
		[global::System.Runtime.Serialization.EnumMember]
		Constrain_UserLoginUnitID_FormatError,
		// Token: 0x04000531 RID: 1329
		[global::System.Runtime.Serialization.EnumMember]
		Constrain_UserName_InvalidChars,
		// Token: 0x04000532 RID: 1330
		[global::System.Runtime.Serialization.EnumMember]
		Constrain_UserName_OverChars,
		// Token: 0x04000533 RID: 1331
		[global::System.Runtime.Serialization.EnumMember]
		Constrain_UserPin_FormatError,
		// Token: 0x04000534 RID: 1332
		[global::System.Runtime.Serialization.EnumMember]
		Constrain_UserPin_OverChars,
		// Token: 0x04000535 RID: 1333
		[global::System.Runtime.Serialization.EnumMember]
		Constrain_PCRSubScriberIP_NotProperFormat,
		// Token: 0x04000536 RID: 1334
		[global::System.Runtime.Serialization.EnumMember]
		Constrain_SubnetMismatch,
		// Token: 0x04000537 RID: 1335
		[global::System.Runtime.Serialization.EnumMember]
		Constrain_SubIP_NoSame_SubIPLink2,
		// Token: 0x04000538 RID: 1336
		[global::System.Runtime.Serialization.EnumMember]
		Constrain_PeerIP_NoSame_SubIPLink2,
		// Token: 0x04000539 RID: 1337
		[global::System.Runtime.Serialization.EnumMember]
		Constrain_SubIP_NoSame_PeerIPLink2,
		// Token: 0x0400053A RID: 1338
		[global::System.Runtime.Serialization.EnumMember]
		Constrain_PeerIP_NoSame_PeerIPLink2,
		// Token: 0x0400053B RID: 1339
		[global::System.Runtime.Serialization.EnumMember]
		Constrain_BluetoothDUNPeerIP_NoSame_BluetoothPANNetworkBaseAddress,
		// Token: 0x0400053C RID: 1340
		[global::System.Runtime.Serialization.EnumMember]
		Constrain_BluetoothDUNSubIP_NoSame_BluetoothPANNetworkBaseAddress,
		// Token: 0x0400053D RID: 1341
		[global::System.Runtime.Serialization.EnumMember]
		Constrain_PeerIP_NoSame_BluetoothPANNetworkBaseAddress,
		// Token: 0x0400053E RID: 1342
		[global::System.Runtime.Serialization.EnumMember]
		Constrain_ProfileBluetoothDUNPeerIP_NoSame_BluetoothPANNetworkBaseAddress,
		// Token: 0x0400053F RID: 1343
		[global::System.Runtime.Serialization.EnumMember]
		Constrain_ProfileBluetoothDUNSubIP_NoSame_BluetoothPANNetworkBaseAddress,
		// Token: 0x04000540 RID: 1344
		[global::System.Runtime.Serialization.EnumMember]
		Constrain_ProfilePeerIP_NoSame_BluetoothPANNetworkBaseAddress,
		// Token: 0x04000541 RID: 1345
		[global::System.Runtime.Serialization.EnumMember]
		Constrain_SubAirInterfaceIP_NoSame_BluetoothPANNetworkBaseAddress,
		// Token: 0x04000542 RID: 1346
		[global::System.Runtime.Serialization.EnumMember]
		Constrain_SubscriberIP_NoSame_BluetoothPANNetworkBaseAddress,
		// Token: 0x04000543 RID: 1347
		[global::System.Runtime.Serialization.EnumMember]
		Constrain_ProfileSubIP_NoSame_BluetoothPANNetworkBaseAddress,
		// Token: 0x04000544 RID: 1348
		[global::System.Runtime.Serialization.EnumMember]
		Invalid_VersionNumber_Error = 31700,
		// Token: 0x04000545 RID: 1349
		[global::System.Runtime.Serialization.EnumMember]
		Generic_File_Does_NOT_Exist,
		// Token: 0x04000546 RID: 1350
		[global::System.Runtime.Serialization.EnumMember]
		No_Newer_Version_Found,
		// Token: 0x04000547 RID: 1351
		[global::System.Runtime.Serialization.EnumMember]
		Generic_Hash_Not_Mached,
		// Token: 0x04000548 RID: 1352
		[global::System.Runtime.Serialization.EnumMember]
		Generic_Hash_Calculate_Error,
		// Token: 0x04000549 RID: 1353
		[global::System.Runtime.Serialization.EnumMember]
		Connect_To_Server_Failed,
		// Token: 0x0400054A RID: 1354
		[global::System.Runtime.Serialization.EnumMember]
		Client_Server_Not_Compatible_But_Server_NotSupport_Autoupdate,
		// Token: 0x0400054B RID: 1355
		[global::System.Runtime.Serialization.EnumMember]
		Starting_Installation_Failed,
		// Token: 0x0400054C RID: 1356
		[global::System.Runtime.Serialization.EnumMember]
		AutoUpdate_NamedPipe_Unable_Connect_Server,
		// Token: 0x0400054D RID: 1357
		[global::System.Runtime.Serialization.EnumMember]
		AutoUpdate_Create_DownloadFolder_Error,
		// Token: 0x0400054E RID: 1358
		[global::System.Runtime.Serialization.EnumMember]
		AutoUpdate_DeleteExistingDownloadFile_Error,
		// Token: 0x0400054F RID: 1359
		[global::System.Runtime.Serialization.EnumMember]
		AutoUpdate_UnzipFile_Error,
		// Token: 0x04000550 RID: 1360
		[global::System.Runtime.Serialization.EnumMember]
		None_Customized_Error = 31999,
		// Token: 0x04000551 RID: 1361
		BLCore_GeneralError = 100100,
		// Token: 0x04000552 RID: 1362
		BLCore_Document_NodeChange_InternalStructureError,
		// Token: 0x04000553 RID: 1363
		BLCore_Document_DiposedBefore,
		// Token: 0x04000554 RID: 1364
		BLCore_Document_NodePath_Error,
		// Token: 0x04000555 RID: 1365
		BLCore_Element_GetProperty_GeneralError = 100200,
		// Token: 0x04000556 RID: 1366
		BLCore_Element_SetProperty_GeneralError,
		// Token: 0x04000557 RID: 1367
		BLCore_Element_SetChange_OutOfRange,
		// Token: 0x04000558 RID: 1368
		BLCore_RecSet_Operation_GeneralError = 100300,
		// Token: 0x04000559 RID: 1369
		BLCore_RecSet_Operation_DelRecord_ReferedByOthers,
		// Token: 0x0400055A RID: 1370
		BLCore_RecSet_Operation_DelRecord_MinLimitation,
		// Token: 0x0400055B RID: 1371
		BLCore_RecSet_Operation_AddRecord_MaxLimitation,
		// Token: 0x0400055C RID: 1372
		BLCore_RecSet_Operation_DelRecord_ConstraintsLogicLimitation,
		// Token: 0x0400055D RID: 1373
		BLCore_Checking_ConsManager_Error = 10800,
		// Token: 0x0400055E RID: 1374
		BLCore_Checking_Element_LogicError,
		// Token: 0x0400055F RID: 1375
		BLCore_Checking_Element_ValidateError,
		// Token: 0x04000560 RID: 1376
		BLCore_Checking_Cons_LogicError,
		// Token: 0x04000561 RID: 1377
		BLCore_Checking_Operation_LogicError,
		// Token: 0x04000562 RID: 1378
		BLCore_Operation_Mode_NodeChangeError = 100900,
		// Token: 0x04000563 RID: 1379
		BLCore_Operation_Mode_AccessError,
		// Token: 0x04000564 RID: 1380
		BLCore_Operation_Mode_CallError,
		// Token: 0x04000565 RID: 1381
		BLCore_Operation_Copy_ElementMismatch,
		// Token: 0x04000566 RID: 1382
		BLCore_Operation_Utility_ArgumementError,
		// Token: 0x04000567 RID: 1383
		BLCore_Operation_LockError,
		// Token: 0x04000568 RID: 1384
		BLCore_Operation_RestrictedEditError,
		// Token: 0x04000569 RID: 1385
		BLCore_Operation_Modify_DataError,
		// Token: 0x0400056A RID: 1386
		BLCompile_GeneralError = 101000,
		// Token: 0x0400056B RID: 1387
		BLCompile_CMDBLLError,
		// Token: 0x0400056C RID: 1388
		Unpacking_Codeplug_Image_FAILED_IN_COMPILE,
		// Token: 0x0400056D RID: 1389
		Packing_Codeplug_Image_FAILED_IN_COMPILE,
		// Token: 0x0400056E RID: 1390
		BLCompile_UnsupportedVersion_For_Packing,
		// Token: 0x0400056F RID: 1391
		BLCompile_UnsupportedVersion_For_Unpacking,
		// Token: 0x04000570 RID: 1392
		BLCompile_Metadata_GeneralError = 101100,
		// Token: 0x04000571 RID: 1393
		BLCompile_Metadata_InitializeError,
		// Token: 0x04000572 RID: 1394
		BLCompile_Converter_GeneralError = 101200,
		// Token: 0x04000573 RID: 1395
		BLCompile_Packing_Converter_GeneralError,
		// Token: 0x04000574 RID: 1396
		BLCompile_UnPacking_Converter_GeneralError,
		// Token: 0x04000575 RID: 1397
		BLCompile_Packing_Fix_GeneralError = 101300,
		// Token: 0x04000576 RID: 1398
		BLCompile_UnPacking_Fix_GeneralError,
		// Token: 0x04000577 RID: 1399
		BLCompile_UnPacking_Fix_InvalidDataInRadio,
		// Token: 0x04000578 RID: 1400
		SPELLCHECK_FAILED = 101900,
		// Token: 0x04000579 RID: 1401
		SPELLCHECK_FAILED_IN_COMPILE,
		// Token: 0x0400057A RID: 1402
		BLConstructor_OpenBLDocument_FAILED = 102000,
		// Token: 0x0400057B RID: 1403
		BLConstructor_FillMissedConfigurationRecords_FAILED,
		// Token: 0x0400057C RID: 1404
		BLConstructor_UpdateBLDocument_FAILED,
		// Token: 0x0400057D RID: 1405
		BLConstructor_GenerateDefaultConfiguration_FAILED,
		// Token: 0x0400057E RID: 1406
		BLConstructor_CreateDefStructureOfSet_FAILED,
		// Token: 0x0400057F RID: 1407
		BLConstructor_AppendVirtualRadionInfoStructure_FAILED,
		// Token: 0x04000580 RID: 1408
		BLConstructor_AppendDefaultRadioStructure2Configuration_FAILED,
		// Token: 0x04000581 RID: 1409
		BLConstructor_AppendDefaultRadioRecord2Configuration_FAILED,
		// Token: 0x04000582 RID: 1410
		BLConstructor_Metadata_GeneralError,
		// Token: 0x04000583 RID: 1411
		BLConstructor_GenerateDefaultConfigurationStructure_FAILED,
		// Token: 0x04000584 RID: 1412
		BLConstructor_Recset_NotFound,
		// Token: 0x04000585 RID: 1413
		ModelTiering_ApplyMVO_FAILED = 103000,
		// Token: 0x04000586 RID: 1414
		ModelTiering_Metadata_GeneralError,
		// Token: 0x04000587 RID: 1415
		ModelTiering_FillRecords_FAILED,
		// Token: 0x04000588 RID: 1416
		ModelTiering_GetMVOEntryFromBLDocument_FAILED,
		// Token: 0x04000589 RID: 1417
		ModelTiering_EvalutationMinimumOption_FAILED,
		// Token: 0x0400058A RID: 1418
		ModelTiering_GetFPSEnabledOptions_FAILED,
		// Token: 0x0400058B RID: 1419
		ModelTiering_ValidateModelNumberAndFlashcode_FAILED,
		// Token: 0x0400058C RID: 1420
		ModelTiering_InvalidModelNumber,
		// Token: 0x0400058D RID: 1421
		ModelTiering_InvalidFlashCode,
		// Token: 0x0400058E RID: 1422
		DataSync_General = 104000,
		// Token: 0x0400058F RID: 1423
		DataSync_AExpectedFieldNotPreserved,
		// Token: 0x04000590 RID: 1424
		DataSync_PreservedDataNotCompatibleWithDataModel,
		// Token: 0x04000591 RID: 1425
		DataSync_RadioSystemNotReferingAFNE,
		// Token: 0x04000592 RID: 1426
		DataSync_ACriticalDataMissedInDoc,
		// Token: 0x04000593 RID: 1427
		RadioCvt_NotSupportedCFSFieldValue,
		// Token: 0x04000594 RID: 1428
		ThereIsNoMaxNumDefForNameSet,
		// Token: 0x04000595 RID: 1429
		RecSetNotFound,
		// Token: 0x04000596 RID: 1430
		[global::System.Runtime.Serialization.EnumMember]
		BLOperation_General = 109000,
		// Token: 0x04000597 RID: 1431
		[global::System.Runtime.Serialization.EnumMember]
		BLLOP_ImportPBA_Failed,
		// Token: 0x04000598 RID: 1432
		[global::System.Runtime.Serialization.EnumMember]
		BLLOP_ExportPBA_Failed,
		// Token: 0x04000599 RID: 1433
		[global::System.Runtime.Serialization.EnumMember]
		BLLOP_ReadRadio_Failed,
		// Token: 0x0400059A RID: 1434
		[global::System.Runtime.Serialization.EnumMember]
		BLLOP_WriteRadio_Failed,
		// Token: 0x0400059B RID: 1435
		[global::System.Runtime.Serialization.EnumMember]
		BLLOP_SpellCheck_Failed,
		// Token: 0x0400059C RID: 1436
		[global::System.Runtime.Serialization.EnumMember]
		BLLOP_GetDynamicBlockSizeList_Failed,
		// Token: 0x0400059D RID: 1437
		[global::System.Runtime.Serialization.EnumMember]
		BLLOP_ExtractFieldValueFromPBA_Failed,
		// Token: 0x0400059E RID: 1438
		[global::System.Runtime.Serialization.EnumMember]
		BLLOP_PopulateValidationFields_Failed,
		// Token: 0x0400059F RID: 1439
		[global::System.Runtime.Serialization.EnumMember]
		BLLOP_Compile_Failed,
		// Token: 0x040005A0 RID: 1440
		[global::System.Runtime.Serialization.EnumMember]
		BLLOP_Decompile_Failed,
		// Token: 0x040005A1 RID: 1441
		[global::System.Runtime.Serialization.EnumMember]
		BLLOP_ModifyTargetPbaObject_forRestoreJob_Failed,
		// Token: 0x040005A2 RID: 1442
		[global::System.Runtime.Serialization.EnumMember]
		BLLOP_GetDataBlockTypeList_Failed,
		// Token: 0x040005A3 RID: 1443
		[global::System.Runtime.Serialization.EnumMember]
		BLLOP_ResetFieldByMVO_Failed,
		// Token: 0x040005A4 RID: 1444
		[global::System.Runtime.Serialization.EnumMember]
		BLLOP_CheckIsSupportedCPVersion_Failed,
		// Token: 0x040005A5 RID: 1445
		[global::System.Runtime.Serialization.EnumMember]
		BLLOP_GetBaselineCPVersion_Failed,
		// Token: 0x040005A6 RID: 1446
		[global::System.Runtime.Serialization.EnumMember]
		BLLOP_GetProductFamilyVersionsMap_Failed,
		// Token: 0x040005A7 RID: 1447
		[global::System.Runtime.Serialization.EnumMember]
		BLLOP_GetSupportedVersions_Failed,
		// Token: 0x040005A8 RID: 1448
		[global::System.Runtime.Serialization.EnumMember]
		BLLOP_GetProductIdentifierList_Failed,
		// Token: 0x040005A9 RID: 1449
		[global::System.Runtime.Serialization.EnumMember]
		BLLOP_GetModelNumberList_Failed,
		// Token: 0x040005AA RID: 1450
		[global::System.Runtime.Serialization.EnumMember]
		BLLOP_GetAvailableOptionsCollection_Failed,
		// Token: 0x040005AB RID: 1451
		[global::System.Runtime.Serialization.EnumMember]
		BLLOP_GetASTROOptionsCollection_Failed,
		// Token: 0x040005AC RID: 1452
		[global::System.Runtime.Serialization.EnumMember]
		BLLOP_EvalutationMinimumOptionPerRecord_Failed,
		// Token: 0x040005AD RID: 1453
		[global::System.Runtime.Serialization.EnumMember]
		BLLOP_GetMessageForMismatchedOptions_Failed,
		// Token: 0x040005AE RID: 1454
		[global::System.Runtime.Serialization.EnumMember]
		BLLOP_GetMVOEntryFromBLDocument_Failed,
		// Token: 0x040005AF RID: 1455
		[global::System.Runtime.Serialization.EnumMember]
		BLLOP_GetConfigurationOptions_Failed,
		// Token: 0x040005B0 RID: 1456
		[global::System.Runtime.Serialization.EnumMember]
		BLLOP_CaculateMismatch_Failed,
		// Token: 0x040005B1 RID: 1457
		[global::System.Runtime.Serialization.EnumMember]
		BLLOP_GenerateNewEMRadioByAnotherRadio_Failed,
		// Token: 0x040005B2 RID: 1458
		[global::System.Runtime.Serialization.EnumMember]
		BLLOP_GetFieldValueFromBlockData_Failed,
		// Token: 0x040005B3 RID: 1459
		[global::System.Runtime.Serialization.EnumMember]
		BLLOP_GenerateDefaultEMRadioByMVO_Failed,
		// Token: 0x040005B4 RID: 1460
		[global::System.Runtime.Serialization.EnumMember]
		BLLOP_GenerateMVOEntryFromPBA_Failed,
		// Token: 0x040005B5 RID: 1461
		[global::System.Runtime.Serialization.EnumMember]
		BLLOP_GetOptionsFieldName_Failed,
		// Token: 0x040005B6 RID: 1462
		[global::System.Runtime.Serialization.EnumMember]
		BLLOP_SetApplicationLicenses_Failed,
		// Token: 0x040005B7 RID: 1463
		[global::System.Runtime.Serialization.EnumMember]
		BLLOP_EMRadioToBLDocument_Failed,
		// Token: 0x040005B8 RID: 1464
		[global::System.Runtime.Serialization.EnumMember]
		BLLOP_BLDocumentToEMRadio_Failed,
		// Token: 0x040005B9 RID: 1465
		[global::System.Runtime.Serialization.EnumMember]
		BLLOP_GenerateDefaultRadioBLNodeRecSet_Failed,
		// Token: 0x040005BA RID: 1466
		[global::System.Runtime.Serialization.EnumMember]
		BLLOP_GetFPSFieldsName_Failed,
		// Token: 0x040005BB RID: 1467
		[global::System.Runtime.Serialization.EnumMember]
		BLLOP_GetFPSEnabledOptions_Failed,
		// Token: 0x040005BC RID: 1468
		[global::System.Runtime.Serialization.EnumMember]
		BLLOP_ConvertPCIFieldsToOptions_Failed,
		// Token: 0x040005BD RID: 1469
		[global::System.Runtime.Serialization.EnumMember]
		BLLOP_ValidateModelNumberAndFlashcode_Failed,
		// Token: 0x040005BE RID: 1470
		[global::System.Runtime.Serialization.EnumMember]
		BLLOP_ApplyMVO_Failed,
		// Token: 0x040005BF RID: 1471
		[global::System.Runtime.Serialization.EnumMember]
		BLLOP_SetVirtualRadioOptionsFields_PCI_Failed,
		// Token: 0x040005C0 RID: 1472
		[global::System.Runtime.Serialization.EnumMember]
		BLLOP_GetBusinessModelOfConfigurationFromRadio_Failed,
		// Token: 0x040005C1 RID: 1473
		[global::System.Runtime.Serialization.EnumMember]
		BLLOP_GetPCIFieldsByFirmware_Failed,
		// Token: 0x040005C2 RID: 1474
		[global::System.Runtime.Serialization.EnumMember]
		BLLOP_LoadRadioIntoDocument_Failed,
		// Token: 0x040005C3 RID: 1475
		[global::System.Runtime.Serialization.EnumMember]
		BLLOP_GetMTFData_Failed,
		// Token: 0x040005C4 RID: 1476
		[global::System.Runtime.Serialization.EnumMember]
		BLLOP_CreateDefaultFullDocument_Failed,
		// Token: 0x040005C5 RID: 1477
		[global::System.Runtime.Serialization.EnumMember]
		BLLOP_GetFullFilledDocument_Failed,
		// Token: 0x040005C6 RID: 1478
		[global::System.Runtime.Serialization.EnumMember]
		BLLOP_GetSyncDataOfConfiguration_Failed,
		// Token: 0x040005C7 RID: 1479
		[global::System.Runtime.Serialization.EnumMember]
		BLLOP_GetMVOEntryFromRadio_Failed,
		// Token: 0x040005C8 RID: 1480
		[global::System.Runtime.Serialization.EnumMember]
		BLLOP_FindAndcheckPCIFieldValue_Failed,
		// Token: 0x040005C9 RID: 1481
		[global::System.Runtime.Serialization.EnumMember]
		BLLOP_AnalysisPackageInfo_Failed,
		// Token: 0x040005CA RID: 1482
		[global::System.Runtime.Serialization.EnumMember]
		BLLOP_AnalysisListPackageInfo_Failed,
		// Token: 0x040005CB RID: 1483
		[global::System.Runtime.Serialization.EnumMember]
		BLLOP_IsSetTypeNeedSync_Failed,
		// Token: 0x040005CC RID: 1484
		[global::System.Runtime.Serialization.EnumMember]
		BLLOP_OpenConfiguration_Failed,
		// Token: 0x040005CD RID: 1485
		[global::System.Runtime.Serialization.EnumMember]
		BLLOP_ExportDBNodeFromDocument_Failed,
		// Token: 0x040005CE RID: 1486
		[global::System.Runtime.Serialization.EnumMember]
		BLLOP_ExportDBNodeFromBLNode_Failed,
		// Token: 0x040005CF RID: 1487
		[global::System.Runtime.Serialization.EnumMember]
		BLLOP_OpenConfigurationSet_Failed,
		// Token: 0x040005D0 RID: 1488
		[global::System.Runtime.Serialization.EnumMember]
		BLLOP_CreateDefaultConfigurationStructure_Failed,
		// Token: 0x040005D1 RID: 1489
		[global::System.Runtime.Serialization.EnumMember]
		BLLOP_UpdateTimeStampAndSetName_Failed,
		// Token: 0x040005D2 RID: 1490
		[global::System.Runtime.Serialization.EnumMember]
		BLLOP_RetreiveSetsList_Failed,
		// Token: 0x040005D3 RID: 1491
		[global::System.Runtime.Serialization.EnumMember]
		BLLOP_GetSetTypeByRecsetSetName_Failed,
		// Token: 0x040005D4 RID: 1492
		[global::System.Runtime.Serialization.EnumMember]
		BLLOP_GetSetNatureTypeByRecsetSetName_Failed,
		// Token: 0x040005D5 RID: 1493
		[global::System.Runtime.Serialization.EnumMember]
		BLLOP_GetEmbeddedSetNameList_Failed,
		// Token: 0x040005D6 RID: 1494
		[global::System.Runtime.Serialization.EnumMember]
		BLLOP_GetRefFieldOriginalRefSetPaths_Failed,
		// Token: 0x040005D7 RID: 1495
		[global::System.Runtime.Serialization.EnumMember]
		BLLOP_IsNewDocument_Failed,
		// Token: 0x040005D8 RID: 1496
		[global::System.Runtime.Serialization.EnumMember]
		BLLOP_IsNewRecord_Failed,
		// Token: 0x040005D9 RID: 1497
		[global::System.Runtime.Serialization.EnumMember]
		BLLOP_CanMakeCopyAndAppendSet_Failed,
		// Token: 0x040005DA RID: 1498
		[global::System.Runtime.Serialization.EnumMember]
		BLLOP_MakeCopyAndAppendEmbeddedSet_Failed,
		// Token: 0x040005DB RID: 1499
		[global::System.Runtime.Serialization.EnumMember]
		BLLOP_GetRecSetNoMvoMaxNumber_Failed,
		// Token: 0x040005DC RID: 1500
		[global::System.Runtime.Serialization.EnumMember]
		BLLOP_FillMissedConfigurationRecords_Failed,
		// Token: 0x040005DD RID: 1501
		[global::System.Runtime.Serialization.EnumMember]
		BLLOP_FindRecordBySetName_Failed,
		// Token: 0x040005DE RID: 1502
		[global::System.Runtime.Serialization.EnumMember]
		BLLOP_GetSetProductFamily_Failed,
		// Token: 0x040005DF RID: 1503
		[global::System.Runtime.Serialization.EnumMember]
		BLLOP_RetrieveMandantorySets_Failed,
		// Token: 0x040005E0 RID: 1504
		[global::System.Runtime.Serialization.EnumMember]
		BLLOP_GetDependentSetList_Failed,
		// Token: 0x040005E1 RID: 1505
		[global::System.Runtime.Serialization.EnumMember]
		BLLOP_LoadDepSetUponSetMode_Failed,
		// Token: 0x040005E2 RID: 1506
		[global::System.Runtime.Serialization.EnumMember]
		BLLOP_IsReferFieldNeedLoadSet_Failed,
		// Token: 0x040005E3 RID: 1507
		[global::System.Runtime.Serialization.EnumMember]
		BLLOP_CheckModelNumberInAliasMap_Failed,
		// Token: 0x040005E4 RID: 1508
		[global::System.Runtime.Serialization.EnumMember]
		BLLOP_GetOriginalRefset_Failed,
		// Token: 0x040005E5 RID: 1509
		[global::System.Runtime.Serialization.EnumMember]
		BLLOP_GetShareableTopSet_Failed,
		// Token: 0x040005E6 RID: 1510
		[global::System.Runtime.Serialization.EnumMember]
		BLLOP_NewOneTopRecordInSetMode_Failed,
		// Token: 0x040005E7 RID: 1511
		[global::System.Runtime.Serialization.EnumMember]
		BLLOP_NewOneTopRecordInSetModeWithInput_Failed,
		// Token: 0x040005E8 RID: 1512
		[global::System.Runtime.Serialization.EnumMember]
		BLLOP_CanSaveDoc_Failed,
		// Token: 0x040005E9 RID: 1513
		[global::System.Runtime.Serialization.EnumMember]
		BLLOP_GetSaveDataFromDoc_Failed,
		// Token: 0x040005EA RID: 1514
		[global::System.Runtime.Serialization.EnumMember]
		BLLOP_DeleteOneRecord_Failed,
		// Token: 0x040005EB RID: 1515
		[global::System.Runtime.Serialization.EnumMember]
		BLLOP_DeleteUnUsedGlobalRecords_Failed,
		// Token: 0x040005EC RID: 1516
		[global::System.Runtime.Serialization.EnumMember]
		BLLOP_CanDeleteOneRecord_Failed,
		// Token: 0x040005ED RID: 1517
		[global::System.Runtime.Serialization.EnumMember]
		BLLOP_AddOneRecord_Failed,
		// Token: 0x040005EE RID: 1518
		[global::System.Runtime.Serialization.EnumMember]
		BLLOP_AppendMultipleRecords_Failed,
		// Token: 0x040005EF RID: 1519
		[global::System.Runtime.Serialization.EnumMember]
		BLLOP_CanAddOneRecord_Failed,
		// Token: 0x040005F0 RID: 1520
		[global::System.Runtime.Serialization.EnumMember]
		BLLOP_GetNewNumThresOfRecSet_Failed,
		// Token: 0x040005F1 RID: 1521
		[global::System.Runtime.Serialization.EnumMember]
		BLLOP_AddOneRecordWithInputData_Failed,
		// Token: 0x040005F2 RID: 1522
		[global::System.Runtime.Serialization.EnumMember]
		BLLOP_CanAddOneRecordWithInputType_Failed,
		// Token: 0x040005F3 RID: 1523
		[global::System.Runtime.Serialization.EnumMember]
		BLLOP_IsWeakTypeSetForTopSetInSetMode_Failed,
		// Token: 0x040005F4 RID: 1524
		[global::System.Runtime.Serialization.EnumMember]
		BLLOP_GetTypesOfSet_Failed,
		// Token: 0x040005F5 RID: 1525
		[global::System.Runtime.Serialization.EnumMember]
		BLLOP_GetTypesOfTopSetInSetMode_Failed,
		// Token: 0x040005F6 RID: 1526
		[global::System.Runtime.Serialization.EnumMember]
		BLLOP_SelectRefRecordFromServerPool_Failed,
		// Token: 0x040005F7 RID: 1527
		[global::System.Runtime.Serialization.EnumMember]
		BLLOP_AssignRecordsFromServerPool_Failed,
		// Token: 0x040005F8 RID: 1528
		[global::System.Runtime.Serialization.EnumMember]
		BLLOP_CanAssignRecordsFromServerPool_Failed,
		// Token: 0x040005F9 RID: 1529
		[global::System.Runtime.Serialization.EnumMember]
		BLLOP_TrySetFieldValueByStringValue_Failed,
		// Token: 0x040005FA RID: 1530
		[global::System.Runtime.Serialization.EnumMember]
		BLLOP_BeginEditDocument_Failed,
		// Token: 0x040005FB RID: 1531
		[global::System.Runtime.Serialization.EnumMember]
		BLLOP_SetConstaintLevel_Failed,
		// Token: 0x040005FC RID: 1532
		[global::System.Runtime.Serialization.EnumMember]
		BLLOP_BeginConstructDocument_Failed,
		// Token: 0x040005FD RID: 1533
		[global::System.Runtime.Serialization.EnumMember]
		BLLOP_DisposeDocument_Failed,
		// Token: 0x040005FE RID: 1534
		[global::System.Runtime.Serialization.EnumMember]
		BLLOP_IsDocumentReadyForEdit_Failed,
		// Token: 0x040005FF RID: 1535
		[global::System.Runtime.Serialization.EnumMember]
		BLLOP_CopySetFromDBNode_Failed,
		// Token: 0x04000600 RID: 1536
		[global::System.Runtime.Serialization.EnumMember]
		BLLOP_EnterPartialValidationMode_Failed,
		// Token: 0x04000601 RID: 1537
		[global::System.Runtime.Serialization.EnumMember]
		BLLOP_ExitPartialValiationMode_Failed,
		// Token: 0x04000602 RID: 1538
		[global::System.Runtime.Serialization.EnumMember]
		BLLOP_HasImpactConfiguration_Failed,
		// Token: 0x04000603 RID: 1539
		[global::System.Runtime.Serialization.EnumMember]
		BLLOP_CheckFreonRadio_Failed,
		// Token: 0x04000604 RID: 1540
		[global::System.Runtime.Serialization.EnumMember]
		BLLOP_ExportGWCFG_Failed,
		// Token: 0x04000605 RID: 1541
		[global::System.Runtime.Serialization.EnumMember]
		BLLOP_SAC_Duplicated_Key,
		// Token: 0x04000606 RID: 1542
		[global::System.Runtime.Serialization.EnumMember]
		BLLOP_TGSA_Duplicated_Key,
		// Token: 0x04000607 RID: 1543
		[global::System.Runtime.Serialization.EnumMember]
		BLLOP_SAC_Valid_Sites_Empty,
		// Token: 0x04000608 RID: 1544
		[global::System.Runtime.Serialization.EnumMember]
		BLLOP_TGSA_Valid_Sites_Empty,
		// Token: 0x04000609 RID: 1545
		[global::System.Runtime.Serialization.EnumMember]
		BLLOP_ClearValueOfSetName_Failed,
		// Token: 0x0400060A RID: 1546
		[global::System.Runtime.Serialization.EnumMember]
		FAIL_TO_DECRYPT = 110000,
		// Token: 0x0400060B RID: 1547
		[global::System.Runtime.Serialization.EnumMember]
		FAIL_TO_DECRYPT_DECOMPRESS,
		// Token: 0x0400060C RID: 1548
		[global::System.Runtime.Serialization.EnumMember]
		FAIL_TO_ENCRYPT_COMPRESS,
		// Token: 0x0400060D RID: 1549
		[global::System.Runtime.Serialization.EnumMember]
		FAIL_TO_SIGN,
		// Token: 0x0400060E RID: 1550
		[global::System.Runtime.Serialization.EnumMember]
		NULL_REFERENCE_PASSED,
		// Token: 0x0400060F RID: 1551
		[global::System.Runtime.Serialization.EnumMember]
		FILE_DOES_NOT_EXSIST,
		// Token: 0x04000610 RID: 1552
		[global::System.Runtime.Serialization.EnumMember]
		INCORRECT_BOM_DETECTED,
		// Token: 0x04000611 RID: 1553
		[global::System.Runtime.Serialization.EnumMember]
		INVALIDPUBLICKEY,
		// Token: 0x04000612 RID: 1554
		[global::System.Runtime.Serialization.EnumMember]
		OUTOFMEMORY,
		// Token: 0x04000613 RID: 1555
		[global::System.Runtime.Serialization.EnumMember]
		SIGNATUREVERIFICATIONFAILED,
		// Token: 0x04000614 RID: 1556
		[global::System.Runtime.Serialization.EnumMember]
		RETRIEVEUPDATEINFOFAILED,
		// Token: 0x04000615 RID: 1557
		[global::System.Runtime.Serialization.EnumMember]
		SIGNATUREALREADYEXISTS,
		// Token: 0x04000616 RID: 1558
		[global::System.Runtime.Serialization.EnumMember]
		ANALYZE_PACKAGE_ERROR,
		// Token: 0x04000617 RID: 1559
		OpenFromRadio_General = 110100,
		// Token: 0x04000618 RID: 1560
		OpenFromRadio_AppendDefaultRadioRecord2ConfigurationFailed,
		// Token: 0x04000619 RID: 1561
		OpenFromRadio_ConfigDocShallHasNoRadioNode,
		// Token: 0x0400061A RID: 1562
		[global::System.Runtime.Serialization.EnumMember]
		PAK_FILE_CORRUPTED = 110150,
		// Token: 0x0400061B RID: 1563
		[global::System.Runtime.Serialization.EnumMember]
		CPFILEMISSING,
		// Token: 0x0400061C RID: 1564
		[global::System.Runtime.Serialization.EnumMember]
		STRUCTFILEMISSING,
		// Token: 0x0400061D RID: 1565
		[global::System.Runtime.Serialization.EnumMember]
		FIELDMOVEMISSING,
		// Token: 0x0400061E RID: 1566
		[global::System.Runtime.Serialization.EnumMember]
		RAMDLOADERMISSING,
		// Token: 0x0400061F RID: 1567
		[global::System.Runtime.Serialization.EnumMember]
		PSDTMISSING,
		// Token: 0x04000620 RID: 1568
		[global::System.Runtime.Serialization.EnumMember]
		BOOTLOADERMISSING,
		// Token: 0x04000621 RID: 1569
		[global::System.Runtime.Serialization.EnumMember]
		FWFILEMISSING,
		// Token: 0x04000622 RID: 1570
		[global::System.Runtime.Serialization.EnumMember]
		APP_UTILITIESMISSING,
		// Token: 0x04000623 RID: 1571
		[global::System.Runtime.Serialization.EnumMember]
		PARTITIONTABLEMISSING,
		// Token: 0x04000624 RID: 1572
		[global::System.Runtime.Serialization.EnumMember]
		RFSMISSING,
		// Token: 0x04000625 RID: 1573
		[global::System.Runtime.Serialization.EnumMember]
		KERNELMISSING,
		// Token: 0x04000626 RID: 1574
		[global::System.Runtime.Serialization.EnumMember]
		L3BOOTLOADERMISSING,
		// Token: 0x04000627 RID: 1575
		[global::System.Runtime.Serialization.EnumMember]
		CONFIGURATIONMISSING,
		// Token: 0x04000628 RID: 1576
		[global::System.Runtime.Serialization.EnumMember]
		DATAIMAGEMISSING,
		// Token: 0x04000629 RID: 1577
		[global::System.Runtime.Serialization.EnumMember]
		INVALID_MODELNUM,
		// Token: 0x0400062A RID: 1578
		[global::System.Runtime.Serialization.EnumMember]
		UPDATEDEVICEFAILED,
		// Token: 0x0400062B RID: 1579
		[global::System.Runtime.Serialization.EnumMember]
		DIFFERENTSERIAL,
		// Token: 0x0400062C RID: 1580
		[global::System.Runtime.Serialization.EnumMember]
		STRUCT_FILE_CORRUPT,
		// Token: 0x0400062D RID: 1581
		[global::System.Runtime.Serialization.EnumMember]
		UNABLETOREADSERIALNUMBER,
		// Token: 0x0400062E RID: 1582
		[global::System.Runtime.Serialization.EnumMember]
		PRESERVEPARTITIONFAILED,
		// Token: 0x0400062F RID: 1583
		[global::System.Runtime.Serialization.EnumMember]
		PRESERVECODEPLUGFAILED,
		// Token: 0x04000630 RID: 1584
		[global::System.Runtime.Serialization.EnumMember]
		UPDATECPSTRUCTFAILED,
		// Token: 0x04000631 RID: 1585
		[global::System.Runtime.Serialization.EnumMember]
		UPDATEBLOCKSTRUCTFAILED,
		// Token: 0x04000632 RID: 1586
		[global::System.Runtime.Serialization.EnumMember]
		UPDATEFIELDSTRUCTFAILED,
		// Token: 0x04000633 RID: 1587
		[global::System.Runtime.Serialization.EnumMember]
		WRITEXMLTOISHFAILED,
		// Token: 0x04000634 RID: 1588
		[global::System.Runtime.Serialization.EnumMember]
		DTPFILEITEMMISSING,
		// Token: 0x04000635 RID: 1589
		[global::System.Runtime.Serialization.EnumMember]
		SCRIPTFILECOUNTINCORRECT,
		// Token: 0x04000636 RID: 1590
		[global::System.Runtime.Serialization.EnumMember]
		SCRIPTFILECONTENTINCORRECT,
		// Token: 0x04000637 RID: 1591
		[global::System.Runtime.Serialization.EnumMember]
		CONTROLHEADMISSING,
		// Token: 0x04000638 RID: 1592
		[global::System.Runtime.Serialization.EnumMember]
		DualBoardImageMissing,
		// Token: 0x04000639 RID: 1593
		[global::System.Runtime.Serialization.EnumMember]
		PAKFILEMISSING,
		// Token: 0x0400063A RID: 1594
		[global::System.Runtime.Serialization.EnumMember]
		BLLDBUpgrade_NodeNotFound = 110300,
		// Token: 0x0400063B RID: 1595
		BLLDBUpgrade_InvalidFieldType,
		// Token: 0x0400063C RID: 1596
		BLLDBUpgrade_DuplicateFieldOfOtherType,
		// Token: 0x0400063D RID: 1597
		BLLDBUpgrade_ChildRecordNotFound,
		// Token: 0x0400063E RID: 1598
		BLLDBUpgrade_CannotCreateRecord,
		// Token: 0x0400063F RID: 1599
		CommandlineBLL_Generic_Error = 130000,
		// Token: 0x04000640 RID: 1600
		CommandlineBLL_Argument_Error,
		// Token: 0x04000641 RID: 1601
		CommandlineBLL_SerializeCruncherData_Failed,
		// Token: 0x04000642 RID: 1602
		CommandlineBLL_PCIValidtor_Extended_UHF_R1_Capable,
		// Token: 0x04000643 RID: 1603
		CommandlineBLL_PCIValidtor_Ultra_Low_Power_Capable,
		// Token: 0x04000644 RID: 1604
		CommandlineBLL_PCIValidtor_Expanded_MDC_ID_Capable,
		// Token: 0x04000645 RID: 1605
		CommandlineBLL_PCIValidtor_Disable_Emergency_Call_Indications_Capable,
		// Token: 0x04000646 RID: 1606
		CommandlineBLL_PCIValidtor_Emergency_Revert_Capable,
		// Token: 0x04000647 RID: 1607
		CommandlineBLL_PCIValidtor_ID_MANDOWNEMERGENCYPROFILECONFIGURABILITY,
		// Token: 0x04000648 RID: 1608
		CommandlineBLL_PCIValidtor_ID_AUDIBLEEMERGENCYBEACONROUTING,
		// Token: 0x04000649 RID: 1609
		CommandlineBLL_PCIValidtor_ID_MARITIMERADIOSOFTWARE,
		// Token: 0x0400064A RID: 1610
		CommandlineBLL_PCIValidtor_ID_MFKEMERGENCYACCESS,
		// Token: 0x0400064B RID: 1611
		CommandlineBLL_PCIValidtor_ID_DYNAMICZONESCANCAPABILITY,
		// Token: 0x0400064C RID: 1612
		CommandlineBLL_PCIValidtor_ID_MOSCADACE3600CAPABLE,
		// Token: 0x0400064D RID: 1613
		CommandlineBLL_PCIValidtor_DVRS_Trunking_Status_ID,
		// Token: 0x0400064E RID: 1614
		CommandlineBLL_PCIValidtor_ID_PERSONNEL_ACCOUNTABILITY_ALERT_CAPABILITY,
		// Token: 0x0400064F RID: 1615
		CommandlineBLL_PCIValidtor_ID_CONSOLIDATED_ACTIONS_ENHANCEMENT,
		// Token: 0x04000650 RID: 1616
		CommandlineBLL_PCIValidtor_ID_USER_SELECTABLE_PL_ENHANCEMENT,
		// Token: 0x04000651 RID: 1617
		CommandlineBLL_PCIValidtor_ID_LIMITED_ISSI_DVRS_OPERATION_CAPABLE,
		// Token: 0x04000652 RID: 1618
		CommandlineBLL_PCIValidtor_ID_ACTIVE_MIC_FOR_PTT_CAPABLE,
		// Token: 0x04000653 RID: 1619
		CommandlineBLL_PCIValidtor_ID_ENHANCED_ARS,
		// Token: 0x04000654 RID: 1620
		CommandlineBLL_PCIValidtor_ID_EMERGENCY_CALL_ONLY_WITH_HOT_MIC_CAPABLE,
		// Token: 0x04000655 RID: 1621
		CommandlineBLL_PCIValidtor_ID_APX_SINGLETONE_CAPABLE,
		// Token: 0x04000656 RID: 1622
		CommandlineBLL_PCIValidtor_ID_PASSALARMFILTERCAPABLE,
		// Token: 0x04000657 RID: 1623
		CommandlineBLL_PCIValidtor_ID_AUDIOENHANCEMENT,
		// Token: 0x04000658 RID: 1624
		CommandlineBLL_PCIValidtor_ID_EMERGENCYHOTAUXMICCONFIGURABILITY,
		// Token: 0x04000659 RID: 1625
		CommandlineBLL_PCIValidtor_ID_AUDIBLEEMERGENCYBEACON,
		// Token: 0x0400065A RID: 1626
		CommandlineBLL_PCR_Upgrade_Not_Support = 135000,
		// Token: 0x0400065B RID: 1627
		CommandlineBLL_PCR_Upgrade_Not_Auto_Correct,
		// Token: 0x0400065C RID: 1628
		CommandlineBLL_PCR_Insufficient_Memory,
		// Token: 0x0400065D RID: 1629
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_PBB_PASSWORD_NOT_FOUND = 140001,
		// Token: 0x0400065E RID: 1630
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_PBB_PASSWORD_ID_DUPLICATED,
		// Token: 0x0400065F RID: 1631
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_PBB_PASSWORD_ALIAS_DUPLICATED,
		// Token: 0x04000660 RID: 1632
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_UELOG_FOLDER_CAN_NOT_ACCESS,
		// Token: 0x04000661 RID: 1633
		[global::System.Runtime.Serialization.EnumMember]
		SERVER_HOMESET_DUPLICATED,
		// Token: 0x04000662 RID: 1634
		[global::System.Runtime.Serialization.EnumMember]
		DBMIGRATION_PROCESSING = 141001,
		// Token: 0x04000663 RID: 1635
		[global::System.Runtime.Serialization.EnumMember]
		DBMIGRATION_FILEMISSING,
		// Token: 0x04000664 RID: 1636
		[global::Motorola.Common.CustomException.DBMigrationError(true)]
		[global::System.Runtime.Serialization.EnumMember]
		DBMIGRATION_REPOSITORYPATHNOTEXIST,
		// Token: 0x04000665 RID: 1637
		[global::Motorola.Common.CustomException.DBMigrationError(true)]
		[global::System.Runtime.Serialization.EnumMember]
		DBMIGRATION_CREATEDIRECTORYEXCEPTION,
		// Token: 0x04000666 RID: 1638
		[global::System.Runtime.Serialization.EnumMember]
		DBMIGRATION_SQLSERVERACCESSERROR,
		// Token: 0x04000667 RID: 1639
		[global::System.Runtime.Serialization.EnumMember]
		[global::Motorola.Common.CustomException.DBMigrationError(true)]
		DBMIGRATION_SQLSERVERCONNECTERROR,
		// Token: 0x04000668 RID: 1640
		[global::System.Runtime.Serialization.EnumMember]
		[global::Motorola.Common.CustomException.DBMigrationError(true)]
		DBMIGRATION_SQLSERVERNETLAYERERROR,
		// Token: 0x04000669 RID: 1641
		[global::Motorola.Common.CustomException.DBMigrationError(true)]
		[global::System.Runtime.Serialization.EnumMember]
		DBMIGRATION_DISCEXCEPTION,
		// Token: 0x0400066A RID: 1642
		[global::Motorola.Common.CustomException.DBMigrationError(true)]
		[global::System.Runtime.Serialization.EnumMember]
		DBMIGRATION_DIRECTORYNOTFOUNDEXCEPTION,
		// Token: 0x0400066B RID: 1643
		[global::System.Runtime.Serialization.EnumMember]
		[global::Motorola.Common.CustomException.DBMigrationError(true)]
		DBMIGRATION_DRIVENOTFOUNDEXCEPTION,
		// Token: 0x0400066C RID: 1644
		[global::System.Runtime.Serialization.EnumMember]
		DBCONVERT_RADIOEXCEPTION,
		// Token: 0x0400066D RID: 1645
		[global::System.Runtime.Serialization.EnumMember]
		[global::Motorola.Common.CustomException.DBMigrationError(true)]
		DBMIGRATION_GENERIC_ERROR,
		// Token: 0x0400066E RID: 1646
		[global::System.Runtime.Serialization.EnumMember]
		DBMIGRATION_ARCHIVE_FILE_MISSING,
		// Token: 0x0400066F RID: 1647
		[global::System.Runtime.Serialization.EnumMember]
		DBMIGRATION_PBA_FILE_MISSING,
		// Token: 0x04000670 RID: 1648
		[global::System.Runtime.Serialization.EnumMember]
		CONFIGURATION_ALREADY_CONVERT_BEFORE,
		// Token: 0x04000671 RID: 1649
		[global::System.Runtime.Serialization.EnumMember]
		DBMIGRATION_DONWLOAD_FILE_ERROR,
		// Token: 0x04000672 RID: 1650
		[global::System.Runtime.Serialization.EnumMember]
		DBMIGRATION_TRANSFER_ARCHIVEFILE_ERROR,
		// Token: 0x04000673 RID: 1651
		[global::System.Runtime.Serialization.EnumMember]
		DBMIGRATION_RADIO_CONVERSION_INFO_MISSING,
		// Token: 0x04000674 RID: 1652
		[global::System.Runtime.Serialization.EnumMember]
		DBMIGRATION_TEMPLATE_CONVERSION_INFO_MISSING,
		// Token: 0x04000675 RID: 1653
		[global::System.Runtime.Serialization.EnumMember]
		DBMIGRATION_ASTRO_DATA_MIGRATION_NOT_COMPLETE,
		// Token: 0x04000676 RID: 1654
		[global::System.Runtime.Serialization.EnumMember]
		DBMIGRATION_PCR_DATA_MIGRATION_NOT_COMPLETE,
		// Token: 0x04000677 RID: 1655
		[global::System.Runtime.Serialization.EnumMember]
		DBMIGRATION_FAILED_CLEAR_TABLES,
		// Token: 0x04000678 RID: 1656
		[global::System.Runtime.Serialization.EnumMember]
		DBMIGRATION_DISALLOW_SCHEDULE_JOB_DUE_TO_LACK_OF_TEMPLATE,
		// Token: 0x04000679 RID: 1657
		[global::System.Runtime.Serialization.EnumMember]
		DBMIGRATION_SCHEDULE_MIGRATION_JOB_FAILED,
		// Token: 0x0400067A RID: 1658
		[global::System.Runtime.Serialization.EnumMember]
		DBMIGRATION_FAILED_RETREIVE_RS_DP_1XDB,
		// Token: 0x0400067B RID: 1659
		[global::System.Runtime.Serialization.EnumMember]
		DBMIGRATION_READWRITE_RADIO_TEMP_FILE,
		// Token: 0x0400067C RID: 1660
		[global::System.Runtime.Serialization.EnumMember]
		DBUPGRADE_PROCESSING,
		// Token: 0x0400067D RID: 1661
		[global::System.Runtime.Serialization.EnumMember]
		DBUPGRADE_PBB_RADIO_IS_NOT_MIGRATED,
		// Token: 0x0400067E RID: 1662
		[global::System.Runtime.Serialization.EnumMember]
		ReadIPAndPortFailure = 143001,
		// Token: 0x0400067F RID: 1663
		[global::System.Runtime.Serialization.EnumMember]
		RMC_UnableToImportMapFile,
		// Token: 0x04000680 RID: 1664
		[global::System.Runtime.Serialization.EnumMember]
		RMC_UnableToExportMapFile
	}
}
