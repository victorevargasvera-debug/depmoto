using System;

namespace SSLMangrComp.Connectors
{
	// Token: 0x02000008 RID: 8
	internal interface IClientWatcher
	{
		// Token: 0x06000035 RID: 53
		void Connect(global::SSLMangrComp.PNConnectionInfo connInfo);

		// Token: 0x06000036 RID: 54
		void ShutdownClient();

		// Token: 0x06000037 RID: 55
		void WriteData(byte[] dataToWrite);
	}
}
