using System;
using System.Runtime.Serialization;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x0200000F RID: 15
	[global::System.Flags]
	[global::System.Runtime.Serialization.DataContract]
	public enum RadioOperation : ulong
	{
		// Token: 0x0400007C RID: 124
		[global::System.Runtime.Serialization.EnumMember]
		None = 0UL,
		// Token: 0x0400007D RID: 125
		[global::System.Runtime.Serialization.EnumMember]
		Create = 1UL,
		// Token: 0x0400007E RID: 126
		[global::System.Runtime.Serialization.EnumMember]
		Read = 2UL,
		// Token: 0x0400007F RID: 127
		[global::System.Runtime.Serialization.EnumMember]
		Program = 4UL,
		// Token: 0x04000080 RID: 128
		[global::System.Runtime.Serialization.EnumMember]
		Flash = 8UL,
		// Token: 0x04000081 RID: 129
		[global::System.Runtime.Serialization.EnumMember]
		ChargingFeature = 16UL,
		// Token: 0x04000082 RID: 130
		[global::System.Runtime.Serialization.EnumMember]
		RemoteProgram = 32UL,
		// Token: 0x04000083 RID: 131
		[global::System.Runtime.Serialization.EnumMember]
		RemoteUpdate = 64UL,
		// Token: 0x04000084 RID: 132
		[global::System.Runtime.Serialization.EnumMember]
		CBIProgram = 128UL,
		// Token: 0x04000085 RID: 133
		[global::System.Runtime.Serialization.EnumMember]
		DepotFlash = 256UL,
		// Token: 0x04000086 RID: 134
		[global::System.Runtime.Serialization.EnumMember]
		SwitchOver = 512UL,
		// Token: 0x04000087 RID: 135
		[global::System.Runtime.Serialization.EnumMember]
		Any = 65535UL
	}
}
