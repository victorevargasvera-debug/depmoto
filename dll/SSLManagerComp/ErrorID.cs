using System;
using System.Runtime.InteropServices;

namespace SSLMangrComp
{
	// Token: 0x02000023 RID: 35
	[global::System.Runtime.InteropServices.ComVisible(true)]
	public enum ErrorID
	{
		// Token: 0x0400009F RID: 159
		Unknown = 101,
		// Token: 0x040000A0 RID: 160
		InvalidIP,
		// Token: 0x040000A1 RID: 161
		InvalidSubscriptionType,
		// Token: 0x040000A2 RID: 162
		UnhandledLinkMgrException,
		// Token: 0x040000A3 RID: 163
		ListenerThreadFailed,
		// Token: 0x040000A4 RID: 164
		TLSClientInternalFailure,
		// Token: 0x040000A5 RID: 165
		TLSServerThreadFailed,
		// Token: 0x040000A6 RID: 166
		TLSServerInternalfailure,
		// Token: 0x040000A7 RID: 167
		UDPPortOutOfRange,
		// Token: 0x040000A8 RID: 168
		TCPPortOutOfRange,
		// Token: 0x040000A9 RID: 169
		MessageCouldNotBeParsed,
		// Token: 0x040000AA RID: 170
		MessageInvalidFormat,
		// Token: 0x040000AB RID: 171
		IncompleteNotify,
		// Token: 0x040000AC RID: 172
		NotiyfyParametersOutOfRange,
		// Token: 0x040000AD RID: 173
		NativeError,
		// Token: 0x040000AE RID: 174
		CouldNotOpenFile,
		// Token: 0x040000AF RID: 175
		InvalidPathString,
		// Token: 0x040000B0 RID: 176
		UnableToOpenSocket = 201,
		// Token: 0x040000B1 RID: 177
		UDPArgumentException,
		// Token: 0x040000B2 RID: 178
		PNServerNotResponding,
		// Token: 0x040000B3 RID: 179
		Disconnected,
		// Token: 0x040000B4 RID: 180
		LinkShutdownFail,
		// Token: 0x040000B5 RID: 181
		TLSProtocolFailed = 301,
		// Token: 0x040000B6 RID: 182
		UDPDataSendFail,
		// Token: 0x040000B7 RID: 183
		UDPPackageError,
		// Token: 0x040000B8 RID: 184
		PackageTimeout,
		// Token: 0x040000B9 RID: 185
		MutualAuthenticationFail,
		// Token: 0x040000BA RID: 186
		CipherStrengthFail,
		// Token: 0x040000BB RID: 187
		AESCipherFail,
		// Token: 0x040000BC RID: 188
		InvalidHandshakeSequence,
		// Token: 0x040000BD RID: 189
		ConnectionTerminatedByServer,
		// Token: 0x040000BE RID: 190
		ConnectionTerminatedByClient,
		// Token: 0x040000BF RID: 191
		CertificateExpired = 401,
		// Token: 0x040000C0 RID: 192
		CertificateNotYetActive,
		// Token: 0x040000C1 RID: 193
		CertificateRevoked,
		// Token: 0x040000C2 RID: 194
		EncryptionFailed,
		// Token: 0x040000C3 RID: 195
		ClientCertificateRequestDenied,
		// Token: 0x040000C4 RID: 196
		InvalidPhrase,
		// Token: 0x040000C5 RID: 197
		PublicKeyError,
		// Token: 0x040000C6 RID: 198
		CertificateNotSigned,
		// Token: 0x040000C7 RID: 199
		DHNotFound,
		// Token: 0x040000C8 RID: 200
		PrivateKeyGenError
	}
}
