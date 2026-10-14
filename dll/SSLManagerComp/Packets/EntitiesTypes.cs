using System;
using System.Runtime.Serialization;

namespace SSLMangrComp.Packets
{
	// Token: 0x0200002B RID: 43
	[global::System.Runtime.Serialization.DataContract]
	public enum EntitiesTypes
	{
		// Token: 0x040000E0 RID: 224
		[global::System.Runtime.Serialization.EnumMember]
		Unknown,
		// Token: 0x040000E1 RID: 225
		[global::System.Runtime.Serialization.EnumMember]
		DeviceID = 10,
		// Token: 0x040000E2 RID: 226
		[global::System.Runtime.Serialization.EnumMember]
		DeviceName,
		// Token: 0x040000E3 RID: 227
		[global::System.Runtime.Serialization.EnumMember]
		UserName,
		// Token: 0x040000E4 RID: 228
		[global::System.Runtime.Serialization.EnumMember]
		IPv4,
		// Token: 0x040000E5 RID: 229
		[global::System.Runtime.Serialization.EnumMember]
		TalkGroupID = 15
	}
}
