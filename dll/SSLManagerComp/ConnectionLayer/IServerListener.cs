using System;
using System.Net;
using SSLMangrComp.Packets;

namespace SSLMangrComp.ConnectionLayer
{
	// Token: 0x02000004 RID: 4
	internal interface IServerListener
	{
		// Token: 0x06000008 RID: 8
		void StartListner(global::System.Net.IPAddress pnIPAddress, global::SSLMangrComp.SecureServerConfiguration secureServerConfiguration, global::SSLMangrComp.Packets.SubscriptionType LMode);

		// Token: 0x06000009 RID: 9
		void StartListner(int port);

		// Token: 0x0600000A RID: 10
		void ShutdownServer();

		// Token: 0x0600000B RID: 11
		bool IsServerRunning();

		// Token: 0x0600000C RID: 12
		int getPortNumber();

		// Token: 0x0600000D RID: 13
		void RegisterIncomingPacketHandler(global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle hdl);

		// Token: 0x0600000E RID: 14
		void RegisterIncomingErrorHandler(global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle hdl);
	}
}
