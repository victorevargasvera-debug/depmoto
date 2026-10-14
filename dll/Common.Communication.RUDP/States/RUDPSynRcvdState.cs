using System;

namespace Motorola.Common.Communication.RUDP.States
{
	// Token: 0x02000028 RID: 40
	internal class RUDPSynRcvdState : global::Motorola.Common.Communication.RUDP.States.RUDPStateBase
	{
		// Token: 0x060001B1 RID: 433 RVA: 0x00007057 File Offset: 0x00005257
		public RUDPSynRcvdState()
		{
			base.SockState = global::Motorola.Common.Communication.RUDP.RUDPSockState.SYN_RCVD;
		}
	}
}
