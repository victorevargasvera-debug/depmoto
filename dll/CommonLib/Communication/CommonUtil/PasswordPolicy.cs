using System;
using System.Runtime.Serialization;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x02000028 RID: 40
	[global::System.Runtime.Serialization.DataContract]
	public enum PasswordPolicy : sbyte
	{
		// Token: 0x0400011A RID: 282
		[global::System.Runtime.Serialization.EnumMember]
		NA = -1,
		// Token: 0x0400011B RID: 283
		[global::System.Runtime.Serialization.EnumMember]
		None,
		// Token: 0x0400011C RID: 284
		[global::System.Runtime.Serialization.EnumMember]
		Basic,
		// Token: 0x0400011D RID: 285
		[global::System.Runtime.Serialization.EnumMember]
		Enhanced
	}
}
