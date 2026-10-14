using System;
using System.Runtime.Serialization;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x02000048 RID: 72
	[global::System.Runtime.Serialization.DataContract]
	public enum FDTType
	{
		// Token: 0x04000213 RID: 531
		[global::System.Runtime.Serialization.EnumMember]
		FDT_FDT,
		// Token: 0x04000214 RID: 532
		[global::System.Runtime.Serialization.EnumMember]
		FDT_FLASHSTRAP,
		// Token: 0x04000215 RID: 533
		[global::System.Runtime.Serialization.EnumMember]
		FDT_FIRMWARE,
		// Token: 0x04000216 RID: 534
		[global::System.Runtime.Serialization.EnumMember]
		FDT_KEY,
		// Token: 0x04000217 RID: 535
		[global::System.Runtime.Serialization.EnumMember]
		FDT_CODEPLUG,
		// Token: 0x04000218 RID: 536
		[global::System.Runtime.Serialization.EnumMember]
		FDT_FLASHPACKS,
		// Token: 0x04000219 RID: 537
		[global::System.Runtime.Serialization.EnumMember]
		FDT_LOGGING_DATA,
		// Token: 0x0400021A RID: 538
		[global::System.Runtime.Serialization.EnumMember]
		FDT_RELEASE_INFO,
		// Token: 0x0400021B RID: 539
		[global::System.Runtime.Serialization.EnumMember]
		FDT_BAD_RECORD,
		// Token: 0x0400021C RID: 540
		[global::System.Runtime.Serialization.EnumMember]
		FDT_DUMMY
	}
}
