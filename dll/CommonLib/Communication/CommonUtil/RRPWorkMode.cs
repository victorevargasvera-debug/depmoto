using System;
using System.Runtime.Serialization;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x02000029 RID: 41
	[global::System.Runtime.Serialization.DataContract]
	public enum RRPWorkMode
	{
		// Token: 0x0400011F RID: 287
		[global::System.Runtime.Serialization.EnumMember]
		None,
		// Token: 0x04000120 RID: 288
		[global::System.Runtime.Serialization.EnumMember]
		NonDMR3,
		// Token: 0x04000121 RID: 289
		[global::System.Runtime.Serialization.EnumMember]
		DMR3
	}
}
