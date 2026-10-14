using System;
using Motorola.Common.Communication.CommunicationPipe;

namespace Motorola.Common.Communication
{
	// Token: 0x02000011 RID: 17
	public class AstroWiFiRcmpMessageExecutor : global::Motorola.Common.Communication.AstroOtapRcmpMessageExecutor
	{
		// Token: 0x060000DF RID: 223 RVA: 0x0000812C File Offset: 0x0000632C
		public AstroWiFiRcmpMessageExecutor(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe commPipe, int inactivityTimeout) : base(commPipe, inactivityTimeout)
		{
			this.WifiReceiveTimeout = inactivityTimeout * 1000;
		}

		// Token: 0x0400003D RID: 61
		private int WifiReceiveTimeout = 60000;
	}
}
