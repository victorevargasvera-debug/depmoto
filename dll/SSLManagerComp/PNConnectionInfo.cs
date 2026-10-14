using System;

namespace SSLMangrComp
{
	// Token: 0x02000019 RID: 25
	[global::System.Serializable]
	public class PNConnectionInfo
	{
		// Token: 0x0400006E RID: 110
		public global::SSLMangrComp.ConnectionConfig PNConnectionConfig;

		// Token: 0x0400006F RID: 111
		public global::SSLMangrComp.SecureClientConfiguration TLSClientConfig;

		// Token: 0x04000070 RID: 112
		public global::SSLMangrComp.SecureServerConfiguration TLSServerConfig;
	}
}
