using System;
using System.Runtime.Serialization;

namespace SSLMangrComp
{
	// Token: 0x02000039 RID: 57
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Serializable]
	public enum RequestEvent
	{
		// Token: 0x04000113 RID: 275
		[global::System.Runtime.Serialization.EnumMember]
		Ack,
		// Token: 0x04000114 RID: 276
		[global::System.Runtime.Serialization.EnumMember]
		Presence,
		// Token: 0x04000115 RID: 277
		[global::System.Runtime.Serialization.EnumMember]
		Absence,
		// Token: 0x04000116 RID: 278
		[global::System.Runtime.Serialization.EnumMember]
		Unknown
	}
}
