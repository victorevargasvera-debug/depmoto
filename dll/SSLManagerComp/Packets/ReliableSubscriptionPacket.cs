using System;
using System.IO;

namespace SSLMangrComp.Packets
{
	// Token: 0x02000034 RID: 52
	internal class ReliableSubscriptionPacket : global::SSLMangrComp.Packets.SubscriptionPacket
	{
		// Token: 0x06000181 RID: 385 RVA: 0x000077B4 File Offset: 0x000059B4
		public ReliableSubscriptionPacket(ushort dialogID, int TcpPort, int Expiry, global::SSLMangrComp.Packets.EntitiesTypes entitiesType, string entitieValues, string events)
		{
			this.m_messageID = 3;
			this.m_dialogID = dialogID;
			this.m_tcpPort = TcpPort;
			this.m_expiry = Expiry;
			this.m_entitiesType = entitiesType;
			this.m_entitiesValue = entitieValues;
			this.m_eventsValue = events;
			if (Expiry <= 0)
			{
				this.m_subscriptionType = global::SSLMangrComp.Packets.SubscriptionPacket.SubscribtionType.OneTimeSubscription;
				return;
			}
			this.m_subscriptionType = global::SSLMangrComp.Packets.SubscriptionPacket.SubscribtionType.Subscription;
		}

		// Token: 0x06000182 RID: 386 RVA: 0x00007810 File Offset: 0x00005A10
		public override byte[] getData()
		{
			global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream();
			memoryStream.WriteByte(this.m_messageID);
			memoryStream.Write(global::System.BitConverter.GetBytes(this.m_dialogID), 0, 2);
			if (this.m_expiry >= 0)
			{
				base.EncodeTLV(memoryStream, 1, global::System.BitConverter.GetBytes(this.m_expiry));
			}
			base.EncodeTLV(memoryStream, 6, global::System.BitConverter.GetBytes(this.m_tcpPort));
			base.EncodeTLV(memoryStream, (byte)this.m_entitiesType, this.m_entitiesValue);
			base.EncodeTLV(memoryStream, 2, this.m_eventsValue);
			return memoryStream.ToArray();
		}

		// Token: 0x06000183 RID: 387 RVA: 0x0000789C File Offset: 0x00005A9C
		public override string getPacketDescription()
		{
			switch (this.m_subscriptionType)
			{
			case global::SSLMangrComp.Packets.SubscriptionPacket.SubscribtionType.Subscription:
				return "Reliable Subscription Message";
			case global::SSLMangrComp.Packets.SubscriptionPacket.SubscribtionType.RefreshSubscription:
				return "Reliable Refresh Subscription Message";
			case global::SSLMangrComp.Packets.SubscriptionPacket.SubscribtionType.CancelSubscription:
				return "Reliable Cancel Subscription Message";
			case global::SSLMangrComp.Packets.SubscriptionPacket.SubscribtionType.OneTimeSubscription:
				return "Reliable One-Time Subscription Message";
			default:
				return "Unknown";
			}
		}

		// Token: 0x06000184 RID: 388 RVA: 0x000078E8 File Offset: 0x00005AE8
		public override string[,] GetAllParameters()
		{
			string[,] array = new string[7, 2];
			array[0, 0] = "Message ID";
			array[0, 1] = this.m_messageID.ToString();
			array[1, 0] = "Dialog ID";
			array[1, 1] = this.m_dialogID.ToString();
			array[2, 0] = "TCP Port Number";
			array[2, 1] = this.m_tcpPort.ToString();
			array[3, 0] = "Expiry (seconds)";
			array[3, 1] = this.m_expiry.ToString();
			array[4, 0] = "Entities type";
			switch (this.m_entitiesType)
			{
			case global::SSLMangrComp.Packets.EntitiesTypes.DeviceID:
				array[4, 1] = "Device ID";
				break;
			case global::SSLMangrComp.Packets.EntitiesTypes.DeviceName:
				array[4, 1] = "Device Name";
				break;
			case global::SSLMangrComp.Packets.EntitiesTypes.UserName:
				array[4, 1] = "User Name";
				break;
			case global::SSLMangrComp.Packets.EntitiesTypes.IPv4:
				array[4, 1] = "IPv4 Address";
				break;
			case global::SSLMangrComp.Packets.EntitiesTypes.TalkGroupID:
				array[4, 1] = "TalkGroup ID";
				break;
			}
			array[5, 0] = "Entities Values";
			array[5, 1] = this.m_entitiesValue;
			array[6, 0] = "Events";
			array[6, 1] = this.m_eventsValue;
			return array;
		}

		// Token: 0x06000185 RID: 389 RVA: 0x00007A34 File Offset: 0x00005C34
		public override global::SSLMangrComp.Packets.SubscriptionPacket CreateRefreshSubscription(int newExpiry)
		{
			return new global::SSLMangrComp.Packets.ReliableSubscriptionPacket(this.m_dialogID, this.m_tcpPort, newExpiry, this.m_entitiesType, this.m_entitiesValue, this.m_entitiesValue)
			{
				Type = base.Type,
				m_subscriptionType = global::SSLMangrComp.Packets.SubscriptionPacket.SubscribtionType.RefreshSubscription
			};
		}

		// Token: 0x06000186 RID: 390 RVA: 0x00007A7C File Offset: 0x00005C7C
		public override global::SSLMangrComp.Packets.SubscriptionPacket CreateCancelSubscription()
		{
			return new global::SSLMangrComp.Packets.ReliableSubscriptionPacket(this.m_dialogID, this.m_tcpPort, 0, this.m_entitiesType, this.m_entitiesValue, this.m_eventsValue)
			{
				Type = base.Type,
				m_subscriptionType = global::SSLMangrComp.Packets.SubscriptionPacket.SubscribtionType.CancelSubscription
			};
		}

		// Token: 0x04000102 RID: 258
		private int m_tcpPort;
	}
}
