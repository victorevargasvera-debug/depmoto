using System;
using System.Runtime.Serialization;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x02000047 RID: 71
	[global::System.Runtime.Serialization.DataContract]
	public enum DeviceMode
	{
		// Token: 0x04000209 RID: 521
		[global::System.Runtime.Serialization.EnumMember]
		UNKNOWN = 7,
		// Token: 0x0400020A RID: 522
		[global::System.Runtime.Serialization.EnumMember]
		NORMAL = 0,
		// Token: 0x0400020B RID: 523
		[global::System.Runtime.Serialization.EnumMember]
		CHARGING,
		// Token: 0x0400020C RID: 524
		[global::System.Runtime.Serialization.EnumMember]
		KERNEL,
		// Token: 0x0400020D RID: 525
		[global::System.Runtime.Serialization.EnumMember]
		FLASHSTRAP = 8,
		// Token: 0x0400020E RID: 526
		[global::System.Runtime.Serialization.EnumMember]
		RP = 3,
		// Token: 0x0400020F RID: 527
		[global::System.Runtime.Serialization.EnumMember]
		FRODO_DATABOX = 9,
		// Token: 0x04000210 RID: 528
		[global::System.Runtime.Serialization.EnumMember]
		MASS_STORAGE,
		// Token: 0x04000211 RID: 529
		[global::System.Runtime.Serialization.EnumMember]
		DEVICE_OFF
	}
}
