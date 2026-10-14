using System;
using System.Threading;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.RUDP.States
{
	// Token: 0x02000027 RID: 39
	internal class RUDPOpenState : global::Motorola.Common.Communication.RUDP.States.RUDPStateBase
	{
		// Token: 0x060001AC RID: 428 RVA: 0x00006ED4 File Offset: 0x000050D4
		public static global::Motorola.Common.Communication.RUDP.States.IRUDPState Instance()
		{
			if (global::Motorola.Common.Communication.RUDP.States.RUDPOpenState._singleton == null)
			{
				global::Motorola.Common.Communication.RUDP.States.RUDPOpenState._singleton = new global::Motorola.Common.Communication.RUDP.States.RUDPOpenState();
			}
			return global::Motorola.Common.Communication.RUDP.States.RUDPOpenState._singleton;
		}

		// Token: 0x060001AD RID: 429 RVA: 0x00006EEC File Offset: 0x000050EC
		private RUDPOpenState()
		{
			base.SockState = global::Motorola.Common.Communication.RUDP.RUDPSockState.OPEN;
		}

		// Token: 0x060001AE RID: 430 RVA: 0x00006EFC File Offset: 0x000050FC
		public override void Close(global::Motorola.Common.Communication.RUDP.RUDPConnection connection)
		{
			global::System.Threading.Thread.Sleep(1000);
			global::Motorola.Common.Communication.RUDP.RUDPPacket rudppacket = global::Motorola.Common.Communication.RUDP.RUDPPacketHelper.MakeRSTPacket(connection);
			int num = connection.RUDPSendTo(rudppacket);
			if (num != (int)rudppacket.PacketLength)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RUDP_SendIsNotCompleted);
			}
			connection.ChangeState(global::Motorola.Common.Communication.RUDP.States.RUDPCloseWaitState.Instance());
		}

		// Token: 0x060001AF RID: 431 RVA: 0x00006F44 File Offset: 0x00005144
		public override int Send(global::Motorola.Common.Communication.RUDP.RUDPConnection connection, global::Motorola.Common.Communication.RUDP.RUDPPacket packet)
		{
			if (packet.PacketType == global::Motorola.Common.Communication.RUDP.RUDPACKFlags.DATA)
			{
				packet.Header.SequenceNumber = connection.NEXT_SENT_SEQN;
				packet.Header.AcknowledgementNumber = connection.LAST_RCVD_SEQN;
				connection.NEXT_SENT_SEQN += 1;
			}
			return connection.RUDPSendTo(packet);
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x00006F94 File Offset: 0x00005194
		public override void Receive(global::Motorola.Common.Communication.RUDP.RUDPConnection connection, global::Motorola.Common.Communication.RUDP.RUDPPacket packet)
		{
			global::Motorola.Common.Communication.RUDP.RUDPACKFlags packetType = packet.PacketType;
			if (packetType == global::Motorola.Common.Communication.RUDP.RUDPACKFlags.ACK || packetType == global::Motorola.Common.Communication.RUDP.RUDPACKFlags.DATA || packetType == global::Motorola.Common.Communication.RUDP.RUDPACKFlags.RST || packetType == global::Motorola.Common.Communication.RUDP.RUDPACKFlags.RST_ACK || packetType == global::Motorola.Common.Communication.RUDP.RUDPACKFlags.NUL || packetType == global::Motorola.Common.Communication.RUDP.RUDPACKFlags.NUL_ACK)
			{
				if (packetType == global::Motorola.Common.Communication.RUDP.RUDPACKFlags.RST || packetType == global::Motorola.Common.Communication.RUDP.RUDPACKFlags.RST_ACK)
				{
					connection.ChangeState(global::Motorola.Common.Communication.RUDP.States.RUDPCloseWaitState.Instance());
					connection.SetCloseWaitTimer();
					return;
				}
				if (packetType == global::Motorola.Common.Communication.RUDP.RUDPACKFlags.DATA)
				{
					if (packet.Header.SequenceNumber <= connection.LAST_RCVD_SEQN)
					{
						connection.SendACK(packet);
						connection.Benchmark.RUDP_TOTAL_REACK_TIMES++;
						return;
					}
					connection.LAST_RCVD_SEQN = packet.Header.SequenceNumber;
					connection.AddIncomingPacket(packet);
					global::Motorola.Common.Communication.RUDP.RUDPConnection.InstallDelayACKTimers(packet);
				}
				if (packetType == global::Motorola.Common.Communication.RUDP.RUDPACKFlags.DATA || packetType == global::Motorola.Common.Communication.RUDP.RUDPACKFlags.RST || packetType == global::Motorola.Common.Communication.RUDP.RUDPACKFlags.RST_ACK || packetType == global::Motorola.Common.Communication.RUDP.RUDPACKFlags.NUL || packetType == global::Motorola.Common.Communication.RUDP.RUDPACKFlags.NUL_ACK)
				{
					connection.CheckForIntegratedUserData();
				}
				if (packetType == global::Motorola.Common.Communication.RUDP.RUDPACKFlags.ACK)
				{
					return;
				}
			}
			else if (packetType == global::Motorola.Common.Communication.RUDP.RUDPACKFlags.SYN_ACK)
			{
				return;
			}
		}

		// Token: 0x040000E6 RID: 230
		private static global::Motorola.Common.Communication.RUDP.States.IRUDPState _singleton;
	}
}
