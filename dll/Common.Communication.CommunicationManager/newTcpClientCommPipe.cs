using System;
using System.Net;
using Motorola.Common.Communication.CommunicationPipe;

namespace Motorola.Common.Communication.CommunicationManager
{
	// Token: 0x02000006 RID: 6
	internal class newTcpClientCommPipe
	{
		// Token: 0x0600000C RID: 12 RVA: 0x000021FC File Offset: 0x000003FC
		public static global::Motorola.Common.Communication.CommunicationPipe.TcpClientCommPipe newTCCommPipe(global::System.Net.IPAddress ipAddress, int portNumber, bool noDelay)
		{
			return new global::Motorola.Common.Communication.CommunicationPipe.TcpClientCommPipe(ipAddress, portNumber, noDelay);
		}
	}
}
