using System;
using System.Runtime.Serialization;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x0200002D RID: 45
	[global::System.Runtime.Serialization.DataContract]
	public enum fp_pack_type_t
	{
		// Token: 0x0400014E RID: 334
		[global::System.Runtime.Serialization.EnumMember]
		NONE,
		// Token: 0x0400014F RID: 335
		[global::System.Runtime.Serialization.EnumMember]
		LANGUAGE_PACK,
		// Token: 0x04000150 RID: 336
		[global::System.Runtime.Serialization.EnumMember]
		FONT_PACK,
		// Token: 0x04000151 RID: 337
		[global::System.Runtime.Serialization.EnumMember]
		THEME_PACK,
		// Token: 0x04000152 RID: 338
		[global::System.Runtime.Serialization.EnumMember]
		ICON_PACK,
		// Token: 0x04000153 RID: 339
		[global::System.Runtime.Serialization.EnumMember]
		STATUSAREA_PACK,
		// Token: 0x04000154 RID: 340
		[global::System.Runtime.Serialization.EnumMember]
		PICTURE_PACK,
		// Token: 0x04000155 RID: 341
		[global::System.Runtime.Serialization.EnumMember]
		CONFIG_PACK,
		// Token: 0x04000156 RID: 342
		[global::System.Runtime.Serialization.EnumMember]
		PALETTE_PACK,
		// Token: 0x04000157 RID: 343
		[global::System.Runtime.Serialization.EnumMember]
		LLS_PACK = 100
	}
}
