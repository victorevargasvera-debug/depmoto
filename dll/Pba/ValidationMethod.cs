using System;
using System.Runtime.Serialization;

namespace Motorola.Common.Communication.Pba
{
	// Token: 0x02000029 RID: 41
	[global::System.Runtime.Serialization.DataContract]
	public enum ValidationMethod
	{
		// Token: 0x04000116 RID: 278
		[global::System.Runtime.Serialization.EnumMember]
		Equal,
		// Token: 0x04000117 RID: 279
		[global::System.Runtime.Serialization.EnumMember]
		Greater,
		// Token: 0x04000118 RID: 280
		[global::System.Runtime.Serialization.EnumMember]
		NotGreater,
		// Token: 0x04000119 RID: 281
		[global::System.Runtime.Serialization.EnumMember]
		Less,
		// Token: 0x0400011A RID: 282
		[global::System.Runtime.Serialization.EnumMember]
		NotLess
	}
}
