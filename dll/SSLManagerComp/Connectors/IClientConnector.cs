using System;
using System.Net;

namespace SSLMangrComp.Connectors
{
	// Token: 0x02000003 RID: 3
	internal interface IClientConnector
	{
		// Token: 0x06000004 RID: 4
		void Connect(global::System.Net.IPAddress pnIPAddress, int portNumber, global::SSLMangrComp.SecureClientConfiguration clientConfig);

		// Token: 0x06000005 RID: 5
		void Connect(global::System.Net.IPAddress pnIPAddress, int portNumber);

		// Token: 0x06000006 RID: 6
		void ShutdownClient();

		// Token: 0x06000007 RID: 7
		void WriteData(byte[] dataToWrite);
	}
}
