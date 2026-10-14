using System;
using System.IO;

namespace SSLMangrComp.Packets
{
	// Token: 0x02000037 RID: 55
	public class UnreliableSubscriptionPacket : global::SSLMangrComp.Packets.SubscriptionPacket
	{
		// Token: 0x06000187 RID: 391 RVA: 0x00007AC2 File Offset: 0x00005CC2
		public UnreliableSubscriptionPacket(ushort dialogID, int Expiry, global::SSLMangrComp.Packets.EntitiesTypes entitiesType, string entitieValues, string events)
		{
			this.m_messageID = 1;
			this.m_dialogID = dialogID;
			this.m_expiry = Expiry;
			this.m_entitiesType = entitiesType;
			this.m_entitiesValue = entitieValues;
			this.m_eventsValue = events;
		}

		// Token: 0x06000188 RID: 392 RVA: 0x00007AF8 File Offset: 0x00005CF8
		public override byte[] getData()
		{
			global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream();
			memoryStream.WriteByte(this.m_messageID);
			memoryStream.Write(global::System.BitConverter.GetBytes(this.m_dialogID), 0, 2);
			if (this.m_expiry >= 0)
			{
				base.EncodeTLV(memoryStream, 1, global::System.BitConverter.GetBytes(this.m_expiry));
			}
			base.EncodeTLV(memoryStream, (byte)this.m_entitiesType, this.m_entitiesValue);
			base.EncodeTLV(memoryStream, 2, this.m_eventsValue);
			return memoryStream.ToArray();
		}

		// Token: 0x06000189 RID: 393 RVA: 0x00007B70 File Offset: 0x00005D70
		public override string getPacketDescription()
		{
			switch (this.m_subscriptionType)
			{
			case global::SSLMangrComp.Packets.SubscriptionPacket.SubscribtionType.Subscription:
				return "Unreliable Subscription Message";
			case global::SSLMangrComp.Packets.SubscriptionPacket.SubscribtionType.RefreshSubscription:
				return "Unreliable Refresh Subscription Message";
			case global::SSLMangrComp.Packets.SubscriptionPacket.SubscribtionType.CancelSubscription:
				return "Unreliable Cancel Subscription Message";
			case global::SSLMangrComp.Packets.SubscriptionPacket.SubscribtionType.OneTimeSubscription:
				return "Unreliable One-Time Subscription Message";
			default:
				return "Unknown";
			}
		}

		// Token: 0x0600018A RID: 394 RVA: 0x00007BBC File Offset: 0x00005DBC
		public override string[,] GetAllParameters()
		{
			string[,] array = new string[6, 2];
			array[0, 0] = "Message ID";
			array[0, 1] = this.m_messageID.ToString();
			array[1, 0] = "Dialog ID";
			array[1, 1] = this.m_dialogID.ToString();
			array[2, 0] = "Expiry (seconds)";
			array[2, 1] = this.m_expiry.ToString();
			array[3, 0] = "Entities type";
			switch (this.m_entitiesType)
			{
			case global::SSLMangrComp.Packets.EntitiesTypes.DeviceID:
				array[3, 1] = "Device ID";
				break;
			case global::SSLMangrComp.Packets.EntitiesTypes.DeviceName:
				array[3, 1] = "Device Name";
				break;
			case global::SSLMangrComp.Packets.EntitiesTypes.UserName:
				array[3, 1] = "User Name";
				break;
			case global::SSLMangrComp.Packets.EntitiesTypes.IPv4:
				array[3, 1] = "IPv4 Address";
				break;
			case global::SSLMangrComp.Packets.EntitiesTypes.TalkGroupID:
				array[3, 1] = "TalkGroup ID";
				break;
			}
			array[4, 0] = "Entities Values";
			array[4, 1] = this.m_entitiesValue;
			array[5, 0] = "Events";
			array[5, 1] = this.m_eventsValue;
			return array;
		}

		// Token: 0x0600018B RID: 395 RVA: 0x00007CE8 File Offset: 0x00005EE8
		public override global::SSLMangrComp.Packets.SubscriptionPacket CreateRefreshSubscription(int newExpiry)
		{
			return new global::SSLMangrComp.Packets.UnreliableSubscriptionPacket(this.m_dialogID, newExpiry, this.m_entitiesType, this.m_entitiesValue, this.m_entitiesValue)
			{
				Type = base.Type,
				m_subscriptionType = global::SSLMangrComp.Packets.SubscriptionPacket.SubscribtionType.RefreshSubscription
			};
		}

		// Token: 0x0600018C RID: 396 RVA: 0x00007D28 File Offset: 0x00005F28
		public override global::SSLMangrComp.Packets.SubscriptionPacket CreateCancelSubscription()
		{
			return new global::SSLMangrComp.Packets.UnreliableSubscriptionPacket(this.m_dialogID, 0, this.m_entitiesType, this.m_entitiesValue, this.m_entitiesValue)
			{
				Type = base.Type,
				m_subscriptionType = global::SSLMangrComp.Packets.SubscriptionPacket.SubscribtionType.CancelSubscription
			};
		}
	}
}
