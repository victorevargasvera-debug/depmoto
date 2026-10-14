using System;
using System.Runtime.Serialization;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x02000027 RID: 39
	[global::System.Runtime.Serialization.DataContract]
	public enum FPGAStatus : byte
	{
		// Token: 0x04000115 RID: 277
		None,
		// Token: 0x04000116 RID: 278
		[global::System.Runtime.Serialization.EnumMember]
		Empty,
		// Token: 0x04000117 RID: 279
		[global::System.Runtime.Serialization.EnumMember]
		Inactive,
		// Token: 0x04000118 RID: 280
		[global::System.Runtime.Serialization.EnumMember]
		Active
	}
}
