using System;

namespace Motorola.Common.Communication.RUDP.States
{
	// Token: 0x02000025 RID: 37
	internal class RUDPCloseWaitState : global::Motorola.Common.Communication.RUDP.States.RUDPStateBase
	{
		// Token: 0x060001A6 RID: 422 RVA: 0x00006E57 File Offset: 0x00005057
		public static global::Motorola.Common.Communication.RUDP.States.IRUDPState Instance()
		{
			if (global::Motorola.Common.Communication.RUDP.States.RUDPCloseWaitState._singleton == null)
			{
				global::Motorola.Common.Communication.RUDP.States.RUDPCloseWaitState._singleton = new global::Motorola.Common.Communication.RUDP.States.RUDPCloseWaitState();
			}
			return global::Motorola.Common.Communication.RUDP.States.RUDPCloseWaitState._singleton;
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00006E6F File Offset: 0x0000506F
		private RUDPCloseWaitState()
		{
			base.SockState = global::Motorola.Common.Communication.RUDP.RUDPSockState.CLOSE_WAIT;
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x00006E80 File Offset: 0x00005080
		public override void Receive(global::Motorola.Common.Communication.RUDP.RUDPConnection connection, global::Motorola.Common.Communication.RUDP.RUDPPacket packet)
		{
			global::Motorola.Common.Communication.RUDP.RUDPACKFlags packetType = packet.PacketType;
			if (packetType == global::Motorola.Common.Communication.RUDP.RUDPACKFlags.RST_ACK)
			{
				ushort acknowledgementNumber = packet.Header.AcknowledgementNumber;
				ushort last_SENT_SEQN = connection.LAST_SENT_SEQN;
			}
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x00006EAB File Offset: 0x000050AB
		public override void Close(global::Motorola.Common.Communication.RUDP.RUDPConnection connection)
		{
		}

		// Token: 0x040000E4 RID: 228
		private static global::Motorola.Common.Communication.RUDP.States.IRUDPState _singleton;
	}
}
