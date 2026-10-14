using System;

namespace Motorola.Common.Communication.RUDP.States
{
	// Token: 0x02000026 RID: 38
	internal class RUDPListenState : global::Motorola.Common.Communication.RUDP.States.RUDPStateBase
	{
		// Token: 0x060001AA RID: 426 RVA: 0x00006EAD File Offset: 0x000050AD
		public static global::Motorola.Common.Communication.RUDP.States.IRUDPState Instance()
		{
			if (global::Motorola.Common.Communication.RUDP.States.RUDPListenState._singleton == null)
			{
				global::Motorola.Common.Communication.RUDP.States.RUDPListenState._singleton = new global::Motorola.Common.Communication.RUDP.States.RUDPListenState();
			}
			return global::Motorola.Common.Communication.RUDP.States.RUDPListenState._singleton;
		}

		// Token: 0x060001AB RID: 427 RVA: 0x00006EC5 File Offset: 0x000050C5
		public RUDPListenState()
		{
			base.SockState = global::Motorola.Common.Communication.RUDP.RUDPSockState.LISTEN;
		}

		// Token: 0x040000E5 RID: 229
		private static global::Motorola.Common.Communication.RUDP.States.IRUDPState _singleton;
	}
}
