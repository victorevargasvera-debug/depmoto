using System;

namespace SSLMangrComp.ConnectionLayer
{
	// Token: 0x02000009 RID: 9
	internal interface IServerWatcher
	{
		// Token: 0x06000038 RID: 56
		void StartListener(int port);

		// Token: 0x06000039 RID: 57
		void StartListener(global::SSLMangrComp.PNConnectionInfo connInfo);

		// Token: 0x0600003A RID: 58
		void ShutdownServer();

		// Token: 0x0600003B RID: 59
		void SignalCloseStream();

		// Token: 0x0600003C RID: 60
		bool IsServerRunning();

		// Token: 0x0600003D RID: 61
		int getPortNumber();

		// Token: 0x0600003E RID: 62
		void RegisterIncomingPacketHandler(global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle hdl);

		// Token: 0x0600003F RID: 63
		void RegisterIncomingErrorHandler(global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle hdl);
	}
}
