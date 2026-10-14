using System;
using System.Collections.Generic;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.RUDP
{
	// Token: 0x0200000A RID: 10
	internal static class RUDPPacketHelper
	{
		// Token: 0x06000095 RID: 149 RVA: 0x00003A68 File Offset: 0x00001C68
		public static global::Motorola.Common.Communication.RUDP.RUDPPacket MakeSYNPacket(global::Motorola.Common.Communication.RUDP.RUDPConnection connection)
		{
			global::Motorola.Common.Communication.RUDP.RUDPConfigParams configParams = connection.ConfigParams;
			global::Motorola.Common.Communication.RUDP.RUDPPacket rudppacket = null;
			if (connection.LAST_SENT_PACKET == null)
			{
				rudppacket = new global::Motorola.Common.Communication.RUDP.RUDPPacket(true);
				connection.LAST_SENT_PACKET = rudppacket;
			}
			else
			{
				rudppacket = connection.LAST_SENT_PACKET;
			}
			rudppacket.IsSYNPacket = true;
			lock (connection.LAST_SENT_PACKET)
			{
				rudppacket.Header.SYN = true;
				rudppacket.Header.ACK = false;
				rudppacket.Header.EAK = false;
				rudppacket.Header.RST = false;
				rudppacket.Header.NUL = false;
				rudppacket.Header.FRG = false;
				rudppacket.Header.VER = global::Motorola.Common.Communication.RUDP.RUDPConstants.RUDP_HEADER_VER;
				rudppacket.Header.SequenceNumber = connection.INIT_SENT_SEQN;
				rudppacket.Header.AcknowledgementNumber = global::Motorola.Common.Communication.RUDP.RUDPConstants.DEFAULT_SEQ_ACK_NUM;
				rudppacket.PayloadHandshake.HSContent = global::Motorola.Common.Communication.RUDP.HandshakeContent.SYN_DATA;
				rudppacket.PayloadHandshake.SYN_SECTION.MUACK = (ushort)configParams.SynNegociateParameters.maximal_number_of_outstanding_unacknowledged_fragment;
				rudppacket.PayloadHandshake.SYN_SECTION.MSS = (ushort)configParams.SynNegociateParameters.maximal_fragment_size;
				rudppacket.PayloadHandshake.SYN_SECTION.SDM = (configParams.SynNegociateParameters.sequenced_delivery_mode == 1);
				rudppacket.Header.HeaderLength = (byte)(rudppacket.PacketLength / 2);
			}
			return rudppacket;
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00003BD0 File Offset: 0x00001DD0
		public static global::Motorola.Common.Communication.RUDP.RUDPPacket MakeACKPacket(global::Motorola.Common.Communication.RUDP.RUDPConnection connection, global::Motorola.Common.Communication.RUDP.RUDPPacket uackedPacket)
		{
			global::Motorola.Common.Communication.RUDP.RUDPPacket rudppacket = null;
			rudppacket = global::Motorola.Common.Communication.RUDP.RUDPPacketHelper.newRUDPPacket(true);
			lock (connection.LAST_SENT_PACKET)
			{
				rudppacket.Header.SYN = false;
				rudppacket.Header.ACK = true;
				rudppacket.Header.EAK = false;
				rudppacket.Header.RST = false;
				rudppacket.Header.NUL = false;
				rudppacket.Header.FRG = false;
				rudppacket.Header.VER = global::Motorola.Common.Communication.RUDP.RUDPConstants.RUDP_HEADER_VER;
				if (uackedPacket == null)
				{
					rudppacket.Header.SequenceNumber = connection.INIT_SENT_SEQN + 1;
					rudppacket.Header.AcknowledgementNumber = connection.LAST_RCVD_SEQN;
					rudppacket.IsSYNPacket = true;
					rudppacket.PayloadHandshake.HSContent = global::Motorola.Common.Communication.RUDP.HandshakeContent.SESSION_PARAMS;
					if (rudppacket.PayloadHandshake.SESSION_PARAMS_SECTION == null)
					{
						throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RUDP_HandshakePacketInitFailed);
					}
					rudppacket.PayloadHandshake.SESSION_PARAMS_SECTION.Max_Number_of_Retries = (byte)connection.ConfigParams.MaxNumberofRetries;
					rudppacket.PayloadHandshake.SESSION_PARAMS_SECTION.Max_Time_Between_Retries = (byte)(connection.ConfigParams.MaxTimeBetweenRetries / global::Motorola.Common.Communication.RUDP.RUDPConstants.RUDP_TIMER_UNIT);
					rudppacket.PayloadHandshake.SESSION_PARAMS_SECTION.Inactivity_Timeout = (byte)(connection.ConfigParams.InactivityTimeout / global::Motorola.Common.Communication.RUDP.RUDPConstants.RUDP_TIMER_UNIT);
					rudppacket.PayloadHandshake.SESSION_PARAMS_SECTION.Time_Between_Retries = (byte)(connection.ConfigParams.TimeBetweenRetries / global::Motorola.Common.Communication.RUDP.RUDPConstants.RUDP_TIMER_UNIT);
					rudppacket.PayloadHandshake.SESSION_PARAMS_SECTION.Retry_Curve_Shape = (byte)connection.ConfigParams.RetryCurveShape;
					rudppacket.PayloadHandshake.SESSION_PARAMS_SECTION.Close_Wait_Timeout = (byte)(connection.ConfigParams.CloseWaitTimeout / global::Motorola.Common.Communication.RUDP.RUDPConstants.RUDP_TIMER_UNIT);
				}
				else
				{
					rudppacket.ClearPayload();
					rudppacket.Header.SequenceNumber = connection.NEXT_SENT_SEQN;
					rudppacket.Header.AcknowledgementNumber = uackedPacket.Header.SequenceNumber;
					uackedPacket.IsACKed = true;
				}
				rudppacket.Header.HeaderLength = (byte)(rudppacket.PacketLength / 2);
			}
			return rudppacket;
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00003DDC File Offset: 0x00001FDC
		public static global::Motorola.Common.Communication.RUDP.RUDPPacket MakeRSTPacket(global::Motorola.Common.Communication.RUDP.RUDPConnection connection)
		{
			global::Motorola.Common.Communication.RUDP.RUDPPacket rudppacket = null;
			if (connection.LAST_SENT_PACKET == null)
			{
				rudppacket = global::Motorola.Common.Communication.RUDP.RUDPPacketHelper.newRUDPPacket(true);
			}
			else
			{
				rudppacket = connection.LAST_SENT_PACKET;
			}
			lock (connection.LAST_SENT_PACKET)
			{
				rudppacket.Header.SYN = false;
				rudppacket.Header.ACK = false;
				rudppacket.Header.EAK = false;
				rudppacket.Header.RST = true;
				rudppacket.Header.NUL = false;
				rudppacket.Header.FRG = false;
				rudppacket.Header.VER = global::Motorola.Common.Communication.RUDP.RUDPConstants.RUDP_HEADER_VER;
				rudppacket.Header.SequenceNumber = connection.NEXT_SENT_SEQN;
				rudppacket.Header.AcknowledgementNumber = connection.LAST_RCVD_SEQN;
				rudppacket.Header.HeaderLength = global::Motorola.Common.Communication.RUDP.RUDPConstants.RUDP_HEADER_LEN / 2;
				rudppacket.ClearPayload();
			}
			return rudppacket;
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00003EC4 File Offset: 0x000020C4
		public static global::System.Collections.Generic.List<global::Motorola.Common.Communication.RUDP.RUDPPacket> MakeDataPackets(global::Motorola.Common.Communication.RUDP.RUDPConnection connection, byte[] buf, int offset, int size)
		{
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.RUDP.RUDPPacket> list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.RUDP.RUDPPacket>();
			int num = offset;
			int num2 = offset + size;
			do
			{
				int num3;
				bool frag;
				if (num2 - num > connection.MAX_PACKET_DATA_SIZE)
				{
					num3 = connection.MAX_PACKET_DATA_SIZE;
					frag = true;
				}
				else
				{
					num3 = num2 - num;
					frag = false;
				}
				global::Motorola.Common.Communication.RUDP.RUDPPacket item = global::Motorola.Common.Communication.RUDP.RUDPPacketHelper.MakeDataPacket(connection, buf, num, num3, frag);
				list.Add(item);
				num += num3;
			}
			while (num < size);
			return list;
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00003F20 File Offset: 0x00002120
		private static global::Motorola.Common.Communication.RUDP.RUDPPacket MakeDataPacket(global::Motorola.Common.Communication.RUDP.RUDPConnection connection, byte[] buffer, int offset, int size, bool frag)
		{
			global::Motorola.Common.Communication.RUDP.RUDPPacket rudppacket = global::Motorola.Common.Communication.RUDP.RUDPPacketHelper.newRUDPPacket(false);
			rudppacket.Header.SYN = false;
			rudppacket.Header.ACK = true;
			rudppacket.Header.EAK = false;
			rudppacket.Header.RST = false;
			rudppacket.Header.NUL = false;
			rudppacket.Header.FRG = frag;
			rudppacket.Header.VER = global::Motorola.Common.Communication.RUDP.RUDPConstants.RUDP_HEADER_VER;
			rudppacket.Header.SequenceNumber = connection.NEXT_SENT_SEQN;
			rudppacket.Header.AcknowledgementNumber = connection.LAST_RCVD_SEQN;
			rudppacket.Header.HeaderLength = global::Motorola.Common.Communication.RUDP.RUDPConstants.RUDP_HEADER_LEN / 2;
			rudppacket.PayloadData.Data = new byte[size];
			global::System.Array.Copy(buffer, offset, rudppacket.PayloadData.Data, 0, size);
			return rudppacket;
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00003FE8 File Offset: 0x000021E8
		private static global::Motorola.Common.Communication.RUDP.RUDPPacket newRUDPPacket(bool syn)
		{
			return new global::Motorola.Common.Communication.RUDP.RUDPPacket(syn);
		}
	}
}
