using System;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.RUDP.States
{
	// Token: 0x02000029 RID: 41
	internal class RUDPSynSentState : global::Motorola.Common.Communication.RUDP.States.RUDPStateBase
	{
		// Token: 0x060001B2 RID: 434 RVA: 0x00007066 File Offset: 0x00005266
		public static global::Motorola.Common.Communication.RUDP.States.IRUDPState Instance()
		{
			if (global::Motorola.Common.Communication.RUDP.States.RUDPSynSentState._singleton == null)
			{
				global::Motorola.Common.Communication.RUDP.States.RUDPSynSentState._singleton = new global::Motorola.Common.Communication.RUDP.States.RUDPSynSentState();
			}
			return global::Motorola.Common.Communication.RUDP.States.RUDPSynSentState._singleton;
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x0000707E File Offset: 0x0000527E
		private RUDPSynSentState()
		{
			base.SockState = global::Motorola.Common.Communication.RUDP.RUDPSockState.SYN_SENT;
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x00007090 File Offset: 0x00005290
		public override void Receive(global::Motorola.Common.Communication.RUDP.RUDPConnection connection, global::Motorola.Common.Communication.RUDP.RUDPPacket packet)
		{
			try
			{
				global::Motorola.Common.Communication.RUDP.RUDPACKFlags packetType = packet.PacketType;
				if (packetType == global::Motorola.Common.Communication.RUDP.RUDPACKFlags.SYN_ACK && packet.Header.AcknowledgementNumber == connection.INIT_SENT_SEQN)
				{
					if (connection.LAST_SENT_TIME >= 1)
					{
						connection.LAST_SENT_TIME = -1;
					}
					connection.INIT_RCVD_SEQN = packet.Header.SequenceNumber;
					connection.LAST_RCVD_SEQN = packet.Header.SequenceNumber;
					global::Motorola.Common.Communication.RUDP.States.RUDPSynSentState.NegotiateSessionParamsForClient(connection, packet);
					this.Acknowledge(connection);
					packet.IsACKed = true;
				}
				else if (packetType == global::Motorola.Common.Communication.RUDP.RUDPACKFlags.RST_ACK)
				{
					if (packet.Header.AcknowledgementNumber != connection.INIT_SENT_SEQN)
					{
						global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("RUDP: Received RST packet for the unknown SN<{0}>!", new object[]
						{
							packet.Header.AcknowledgementNumber
						});
						throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RUDP_ResetByRemotePeer);
					}
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("Server refuse the connection!", new object[0]);
					connection.ChangeState(global::Motorola.Common.Communication.RUDP.States.RUDPCloseState.Instance());
					connection.ConnectAsyncResult.SetAsFailed(global::Motorola.Common.Communication.RUDP.RUDPReplyResult.RUDPReply_ServerRefusedConnection);
				}
				else
				{
					if (packetType != global::Motorola.Common.Communication.RUDP.RUDPACKFlags.ACK || packet.Header.AcknowledgementNumber == connection.INIT_SENT_SEQN)
					{
						global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("RUDP: Unknown packet!", new object[0]);
						throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RUDP_UnexpectedPacketReceived);
					}
					global::Motorola.Common.Communication.RUDP.RUDPPacket rudppacket = global::Motorola.Common.Communication.RUDP.RUDPPacketHelper.MakeRSTPacket(connection);
					rudppacket.Header.SequenceNumber = packet.Header.AcknowledgementNumber + 1;
					rudppacket.Header.AcknowledgementNumber = global::Motorola.Common.Communication.RUDP.RUDPConstants.DEFAULT_SEQ_ACK_NUM;
					int num = connection.Send(rudppacket);
					if (num != (int)rudppacket.PacketLength)
					{
						throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RUDP_SendIsNotCompleted);
					}
					connection.ChangeState(global::Motorola.Common.Communication.RUDP.States.RUDPCloseState.Instance());
					connection.ConnectAsyncResult.SetAsFailed(global::Motorola.Common.Communication.RUDP.RUDPReplyResult.RUDPReply_ConnectFail);
				}
			}
			catch (global::System.Exception)
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("RUDP: Connection failed!", new object[0]);
				try
				{
					connection.ChangeState(global::Motorola.Common.Communication.RUDP.States.RUDPCloseState.Instance());
					connection.ConnectAsyncResult.SetAsFailed(global::Motorola.Common.Communication.RUDP.RUDPReplyResult.RUDPReply_ConnectFail);
				}
				catch
				{
				}
				throw;
			}
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x0000728C File Offset: 0x0000548C
		public override void Acknowledge(global::Motorola.Common.Communication.RUDP.RUDPConnection connection)
		{
			global::Motorola.Common.Communication.RUDP.RUDPPacket rudppacket = global::Motorola.Common.Communication.RUDP.RUDPPacketHelper.MakeACKPacket(connection, null);
			int num = connection.Send(rudppacket);
			if (num != (int)rudppacket.PacketLength)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RUDP_SendIsNotCompleted);
			}
			connection.ChangeState(global::Motorola.Common.Communication.RUDP.States.RUDPOpenState.Instance());
			connection.ConnectAsyncResult.SetAsCompleted(global::Motorola.Common.Communication.RUDP.RUDPReplyResult.RUDPReply_Success);
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x000072D4 File Offset: 0x000054D4
		public override int Send(global::Motorola.Common.Communication.RUDP.RUDPConnection connection, global::Motorola.Common.Communication.RUDP.RUDPPacket packet)
		{
			if (packet.Header.ACK || packet.Header.RST)
			{
				return connection.RUDPSendTo(packet);
			}
			return 0;
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x000072F9 File Offset: 0x000054F9
		public override void Close(global::Motorola.Common.Communication.RUDP.RUDPConnection connection)
		{
			connection.ChangeState(global::Motorola.Common.Communication.RUDP.States.RUDPCloseState.Instance());
			connection.CloseAsyncResult.SetAsCompleted(global::Motorola.Common.Communication.RUDP.RUDPReplyResult.RUDPReply_Success);
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x00007314 File Offset: 0x00005514
		private static void NegotiateSessionParamsForClient(global::Motorola.Common.Communication.RUDP.RUDPConnection connection, global::Motorola.Common.Communication.RUDP.RUDPPacket packet)
		{
			if (packet.PayloadHandshake.SYN_SECTION != null)
			{
				int maximal_fragment_size = connection.ConfigParams.SynNegociateParameters.maximal_fragment_size;
				ushort mss = packet.PayloadHandshake.SYN_SECTION.MSS;
			}
			if (packet.PayloadHandshake.SESSION_PARAMS_SECTION != null)
			{
				if (connection.ConfigParams.NegotiationAlgorithm == 3)
				{
					if (connection.ConfigParams.MaxNumberofRetries < (int)packet.PayloadHandshake.SESSION_PARAMS_SECTION.Max_Number_of_Retries)
					{
						connection.ConfigParams.MaxNumberofRetries = (int)packet.PayloadHandshake.SESSION_PARAMS_SECTION.Max_Number_of_Retries;
					}
					if (connection.ConfigParams.TimeBetweenRetries < (int)packet.PayloadHandshake.SESSION_PARAMS_SECTION.Time_Between_Retries * global::Motorola.Common.Communication.RUDP.RUDPConstants.RUDP_TIMER_UNIT)
					{
						connection.ConfigParams.MaxTimeBetweenRetries = (int)packet.PayloadHandshake.SESSION_PARAMS_SECTION.Max_Time_Between_Retries * global::Motorola.Common.Communication.RUDP.RUDPConstants.RUDP_TIMER_UNIT;
						connection.ConfigParams.TimeBetweenRetries = (int)packet.PayloadHandshake.SESSION_PARAMS_SECTION.Time_Between_Retries * global::Motorola.Common.Communication.RUDP.RUDPConstants.RUDP_TIMER_UNIT;
					}
					if (connection.ConfigParams.InactivityTimeout < (int)packet.PayloadHandshake.SESSION_PARAMS_SECTION.Inactivity_Timeout * global::Motorola.Common.Communication.RUDP.RUDPConstants.RUDP_TIMER_UNIT)
					{
						connection.ConfigParams.InactivityTimeout = (int)packet.PayloadHandshake.SESSION_PARAMS_SECTION.Inactivity_Timeout * global::Motorola.Common.Communication.RUDP.RUDPConstants.RUDP_TIMER_UNIT;
					}
					if (connection.ConfigParams.CloseWaitTimeout < (int)packet.PayloadHandshake.SESSION_PARAMS_SECTION.Close_Wait_Timeout * global::Motorola.Common.Communication.RUDP.RUDPConstants.RUDP_TIMER_UNIT)
					{
						connection.ConfigParams.CloseWaitTimeout = (int)packet.PayloadHandshake.SESSION_PARAMS_SECTION.Close_Wait_Timeout * global::Motorola.Common.Communication.RUDP.RUDPConstants.RUDP_TIMER_UNIT;
						return;
					}
				}
				else if (connection.ConfigParams.NegotiationAlgorithm == 2)
				{
					connection.ConfigParams.MaxNumberofRetries = (int)packet.PayloadHandshake.SESSION_PARAMS_SECTION.Max_Number_of_Retries;
					connection.ConfigParams.MaxTimeBetweenRetries = (int)packet.PayloadHandshake.SESSION_PARAMS_SECTION.Max_Time_Between_Retries * global::Motorola.Common.Communication.RUDP.RUDPConstants.RUDP_TIMER_UNIT;
					connection.ConfigParams.TimeBetweenRetries = (int)packet.PayloadHandshake.SESSION_PARAMS_SECTION.Time_Between_Retries * global::Motorola.Common.Communication.RUDP.RUDPConstants.RUDP_TIMER_UNIT;
					connection.ConfigParams.InactivityTimeout = (int)packet.PayloadHandshake.SESSION_PARAMS_SECTION.Inactivity_Timeout * global::Motorola.Common.Communication.RUDP.RUDPConstants.RUDP_TIMER_UNIT;
					connection.ConfigParams.CloseWaitTimeout = (int)packet.PayloadHandshake.SESSION_PARAMS_SECTION.Close_Wait_Timeout * global::Motorola.Common.Communication.RUDP.RUDPConstants.RUDP_TIMER_UNIT;
					connection.ConfigParams.RetryCurveShape = (float)packet.PayloadHandshake.SESSION_PARAMS_SECTION.Retry_Curve_Shape;
				}
			}
		}

		// Token: 0x040000E7 RID: 231
		private static global::Motorola.Common.Communication.RUDP.States.IRUDPState _singleton;
	}
}
