using System;
using System.Runtime.Serialization;

namespace SSLMangrComp.Packets
{
	// Token: 0x02000036 RID: 54
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Serializable]
	public enum SubscriptionType
	{
		// Token: 0x04000109 RID: 265
		[global::System.Runtime.Serialization.EnumMember]
		Secure,
		// Token: 0x0400010A RID: 266
		[global::System.Runtime.Serialization.EnumMember]
		Reliable,
		// Token: 0x0400010B RID: 267
		[global::System.Runtime.Serialization.EnumMember]
		Unreliable
	}
}
