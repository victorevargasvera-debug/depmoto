using System;
using System.Runtime.Serialization;

namespace SSLMangrComp
{
	// Token: 0x0200003A RID: 58
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Serializable]
	public enum PresenceState
	{
		// Token: 0x04000118 RID: 280
		[global::System.Runtime.Serialization.EnumMember]
		Unknown,
		// Token: 0x04000119 RID: 281
		[global::System.Runtime.Serialization.EnumMember]
		Present,
		// Token: 0x0400011A RID: 282
		[global::System.Runtime.Serialization.EnumMember]
		Absent
	}
}
