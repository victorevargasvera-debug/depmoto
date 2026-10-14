using System;
using System.Runtime.Serialization;

namespace SSLMangrComp
{
	// Token: 0x02000038 RID: 56
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Serializable]
	public class PresenceNotification
	{
		// Token: 0x0600018D RID: 397 RVA: 0x00007D68 File Offset: 0x00005F68
		public PresenceNotification()
		{
			this.SubscriptionState = string.Empty;
			this.EntityType = string.Empty;
			this.DeviceId = string.Empty;
			this.IPAddr = string.Empty;
			this.EventValue = global::SSLMangrComp.RequestEvent.Unknown;
			this.PresenceState = global::SSLMangrComp.PresenceState.Unknown;
		}

		// Token: 0x0400010C RID: 268
		[global::System.Runtime.Serialization.DataMember]
		public string SubscriptionState;

		// Token: 0x0400010D RID: 269
		[global::System.Runtime.Serialization.DataMember]
		public string EntityType;

		// Token: 0x0400010E RID: 270
		[global::System.Runtime.Serialization.DataMember]
		public string DeviceId;

		// Token: 0x0400010F RID: 271
		[global::System.Runtime.Serialization.DataMember]
		public string IPAddr;

		// Token: 0x04000110 RID: 272
		[global::System.Runtime.Serialization.DataMember]
		public global::SSLMangrComp.RequestEvent EventValue;

		// Token: 0x04000111 RID: 273
		[global::System.Runtime.Serialization.DataMember]
		public global::SSLMangrComp.PresenceState PresenceState;
	}
}
