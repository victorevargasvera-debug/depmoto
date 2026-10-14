using System;

namespace Motorola.Common.Communication.RUDP.States
{
	// Token: 0x02000024 RID: 36
	internal class RUDPCloseState : global::Motorola.Common.Communication.RUDP.States.RUDPStateBase
	{
		// Token: 0x0600019E RID: 414 RVA: 0x00006D7E File Offset: 0x00004F7E
		public static global::Motorola.Common.Communication.RUDP.States.IRUDPState Instance()
		{
			if (global::Motorola.Common.Communication.RUDP.States.RUDPCloseState._singleton == null)
			{
				global::Motorola.Common.Communication.RUDP.States.RUDPCloseState._singleton = new global::Motorola.Common.Communication.RUDP.States.RUDPCloseState();
			}
			return global::Motorola.Common.Communication.RUDP.States.RUDPCloseState._singleton;
		}

		// Token: 0x0600019F RID: 415 RVA: 0x00006D96 File Offset: 0x00004F96
		private RUDPCloseState()
		{
			base.SockState = global::Motorola.Common.Communication.RUDP.RUDPSockState.CLOSE;
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x00006DA8 File Offset: 0x00004FA8
		public override bool ActiveOpen(global::Motorola.Common.Communication.RUDP.RUDPConnection connection)
		{
			global::Motorola.Common.Communication.RUDP.RUDPPacket rudppacket = global::Motorola.Common.Communication.RUDP.RUDPPacketHelper.MakeSYNPacket(connection);
			int num = connection.SendWithBlockingMode(rudppacket);
			ushort packetLength = rudppacket.PacketLength;
			connection.LAST_SENT_TIME = 1;
			connection.LAST_SENT_SEQN = connection.INIT_SENT_SEQN;
			connection.ChangeState(global::Motorola.Common.Communication.RUDP.States.RUDPSynSentState.Instance());
			connection.BeginReceiveFrom();
			rudppacket.WaitACK();
			return rudppacket.IsACKed;
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x00006E03 File Offset: 0x00005003
		public override void PassiveOpen(global::Motorola.Common.Communication.RUDP.RUDPConnection connection)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x00006E0C File Offset: 0x0000500C
		public override int Send(global::Motorola.Common.Communication.RUDP.RUDPConnection connection, global::Motorola.Common.Communication.RUDP.RUDPPacket packet)
		{
			global::Motorola.Common.Communication.RUDP.RUDPACKFlags packetType = packet.PacketType;
			if (packetType == global::Motorola.Common.Communication.RUDP.RUDPACKFlags.SYN)
			{
				return connection.RUDPSendTo(packet);
			}
			packet.SetTransmissionFailed();
			return 0;
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x00006E33 File Offset: 0x00005033
		public override void Receive(global::Motorola.Common.Communication.RUDP.RUDPConnection connection, global::Motorola.Common.Communication.RUDP.RUDPPacket packet)
		{
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x00006E35 File Offset: 0x00005035
		public override void Close(global::Motorola.Common.Communication.RUDP.RUDPConnection connection)
		{
			connection.CloseAsyncResult.SetAsCompleted(global::Motorola.Common.Communication.RUDP.RUDPReplyResult.RUDPReply_Success);
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x00006E43 File Offset: 0x00005043
		public override void ChangeState(global::Motorola.Common.Communication.RUDP.RUDPConnection connection, global::Motorola.Common.Communication.RUDP.States.IRUDPState state)
		{
			if (state.SockState == global::Motorola.Common.Communication.RUDP.RUDPSockState.CLOSE_WAIT)
			{
				return;
			}
			base.ChangeState(connection, state);
		}

		// Token: 0x040000E3 RID: 227
		private static global::Motorola.Common.Communication.RUDP.States.IRUDPState _singleton;
	}
}
