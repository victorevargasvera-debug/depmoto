using System;

namespace SSLMangrComp.Packets
{
	// Token: 0x02000032 RID: 50
	public abstract class SubscriptionPacket : global::SSLMangrComp.Packets.PacketBase
	{
		// Token: 0x17000034 RID: 52
		// (get) Token: 0x0600017D RID: 381 RVA: 0x0000779C File Offset: 0x0000599C
		public string EntityValue
		{
			get
			{
				return this.m_entitiesValue;
			}
		}

		// Token: 0x0600017E RID: 382
		public abstract global::SSLMangrComp.Packets.SubscriptionPacket CreateRefreshSubscription(int newExpiry);

		// Token: 0x0600017F RID: 383
		public abstract global::SSLMangrComp.Packets.SubscriptionPacket CreateCancelSubscription();

		// Token: 0x040000F8 RID: 248
		protected global::SSLMangrComp.Packets.SubscriptionPacket.SubscribtionType m_subscriptionType;

		// Token: 0x040000F9 RID: 249
		protected int m_expiry = -1;

		// Token: 0x040000FA RID: 250
		protected global::SSLMangrComp.Packets.EntitiesTypes m_entitiesType;

		// Token: 0x040000FB RID: 251
		protected string m_entitiesValue;

		// Token: 0x040000FC RID: 252
		protected string m_eventsValue;

		// Token: 0x02000033 RID: 51
		protected enum SubscribtionType
		{
			// Token: 0x040000FE RID: 254
			Subscription,
			// Token: 0x040000FF RID: 255
			RefreshSubscription,
			// Token: 0x04000100 RID: 256
			CancelSubscription,
			// Token: 0x04000101 RID: 257
			OneTimeSubscription
		}
	}
}
