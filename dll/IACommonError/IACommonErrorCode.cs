using System;
using System.Runtime.Serialization;

namespace IACustomException
{
	// Token: 0x02000003 RID: 3
	[global::System.Runtime.Serialization.DataContract]
	public enum IACommonErrorCode
	{
		// Token: 0x04000004 RID: 4
		[global::System.Runtime.Serialization.EnumMember]
		GenericError = 1,
		// Token: 0x04000005 RID: 5
		[global::System.Runtime.Serialization.EnumMember]
		SSL_Unknown = 1050,
		// Token: 0x04000006 RID: 6
		[global::System.Runtime.Serialization.EnumMember]
		SSL_InvalidIP,
		// Token: 0x04000007 RID: 7
		[global::System.Runtime.Serialization.EnumMember]
		SSL_InvalidSubscriptionType,
		// Token: 0x04000008 RID: 8
		[global::System.Runtime.Serialization.EnumMember]
		SSL_UnhandledLinkMgrException,
		// Token: 0x04000009 RID: 9
		[global::System.Runtime.Serialization.EnumMember]
		SSL_ListenerThreadFailed,
		// Token: 0x0400000A RID: 10
		[global::System.Runtime.Serialization.EnumMember]
		SSL_TLSClientInternalFailure,
		// Token: 0x0400000B RID: 11
		[global::System.Runtime.Serialization.EnumMember]
		SSL_TLSServerThreadFailed,
		// Token: 0x0400000C RID: 12
		[global::System.Runtime.Serialization.EnumMember]
		SSL_TLSServerInternalfailure,
		// Token: 0x0400000D RID: 13
		[global::System.Runtime.Serialization.EnumMember]
		SSL_UDPPortOutOfRange,
		// Token: 0x0400000E RID: 14
		[global::System.Runtime.Serialization.EnumMember]
		SSL_TCPPortOutOfRange,
		// Token: 0x0400000F RID: 15
		[global::System.Runtime.Serialization.EnumMember]
		SSL_MessageCouldNotBeParsed,
		// Token: 0x04000010 RID: 16
		[global::System.Runtime.Serialization.EnumMember]
		SSL_MessageInvalidFormat,
		// Token: 0x04000011 RID: 17
		[global::System.Runtime.Serialization.EnumMember]
		SSL_IncompleteNotify,
		// Token: 0x04000012 RID: 18
		[global::System.Runtime.Serialization.EnumMember]
		SSL_NotiyfyParametersOutOfRange,
		// Token: 0x04000013 RID: 19
		[global::System.Runtime.Serialization.EnumMember]
		SSL_NativeError,
		// Token: 0x04000014 RID: 20
		[global::System.Runtime.Serialization.EnumMember]
		SSL_LE_UnableToOpenSocket,
		// Token: 0x04000015 RID: 21
		[global::System.Runtime.Serialization.EnumMember]
		SSL_LE_UDPArgumentException,
		// Token: 0x04000016 RID: 22
		[global::System.Runtime.Serialization.EnumMember]
		SSL_LE_PNServerNotResponding,
		// Token: 0x04000017 RID: 23
		[global::System.Runtime.Serialization.EnumMember]
		SSL_LE_Disconnected,
		// Token: 0x04000018 RID: 24
		[global::System.Runtime.Serialization.EnumMember]
		SSL_LE_LinkShutdownFail,
		// Token: 0x04000019 RID: 25
		[global::System.Runtime.Serialization.EnumMember]
		SSL_PE_TLSProtocolFailed,
		// Token: 0x0400001A RID: 26
		[global::System.Runtime.Serialization.EnumMember]
		SSL_PE_UDPDataSendFail,
		// Token: 0x0400001B RID: 27
		[global::System.Runtime.Serialization.EnumMember]
		SSL_PE_UDPPackageError,
		// Token: 0x0400001C RID: 28
		[global::System.Runtime.Serialization.EnumMember]
		SSL_PE_PackageTimeout,
		// Token: 0x0400001D RID: 29
		[global::System.Runtime.Serialization.EnumMember]
		SSL_PE_MutualAuthenticationFail,
		// Token: 0x0400001E RID: 30
		[global::System.Runtime.Serialization.EnumMember]
		SSL_PE_CipherStrengthFail,
		// Token: 0x0400001F RID: 31
		[global::System.Runtime.Serialization.EnumMember]
		SSL_PE_AESCipherFail,
		// Token: 0x04000020 RID: 32
		[global::System.Runtime.Serialization.EnumMember]
		SSL_PE_InvalidHandshakeSequence,
		// Token: 0x04000021 RID: 33
		[global::System.Runtime.Serialization.EnumMember]
		SSL_PE_ConnectionTerminatedByServer,
		// Token: 0x04000022 RID: 34
		[global::System.Runtime.Serialization.EnumMember]
		SSL_PE_ConnectionTerminatedByClient,
		// Token: 0x04000023 RID: 35
		[global::System.Runtime.Serialization.EnumMember]
		SSL_CE_CertificateExpired,
		// Token: 0x04000024 RID: 36
		[global::System.Runtime.Serialization.EnumMember]
		SSL_CE_CertificateNotYetActive,
		// Token: 0x04000025 RID: 37
		[global::System.Runtime.Serialization.EnumMember]
		SSL_CE_CertificateRevoked,
		// Token: 0x04000026 RID: 38
		[global::System.Runtime.Serialization.EnumMember]
		SSL_CE_EncryptionFailed,
		// Token: 0x04000027 RID: 39
		[global::System.Runtime.Serialization.EnumMember]
		SSL_CE_ClientCertificateRequestDenied,
		// Token: 0x04000028 RID: 40
		[global::System.Runtime.Serialization.EnumMember]
		SSL_CE_InvalidPhrase,
		// Token: 0x04000029 RID: 41
		[global::System.Runtime.Serialization.EnumMember]
		SSL_CE_PublicKeyError,
		// Token: 0x0400002A RID: 42
		[global::System.Runtime.Serialization.EnumMember]
		SSL_CE_CertificateNotSigned,
		// Token: 0x0400002B RID: 43
		[global::System.Runtime.Serialization.EnumMember]
		SSL_CE_DHNotFound,
		// Token: 0x0400002C RID: 44
		[global::System.Runtime.Serialization.EnumMember]
		SSL_CE_PrivateKeyGenError
	}
}
