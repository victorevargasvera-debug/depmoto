using System;
using System.Runtime.Serialization;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x02000050 RID: 80
	[global::System.Runtime.Serialization.DataContract]
	public enum MetaDataPathType
	{
		// Token: 0x04000249 RID: 585
		[global::System.Runtime.Serialization.EnumMember]
		Firmware,
		// Token: 0x0400024A RID: 586
		[global::System.Runtime.Serialization.EnumMember]
		Config,
		// Token: 0x0400024B RID: 587
		[global::System.Runtime.Serialization.EnumMember]
		Kenel,
		// Token: 0x0400024C RID: 588
		[global::System.Runtime.Serialization.EnumMember]
		Flashstrap,
		// Token: 0x0400024D RID: 589
		[global::System.Runtime.Serialization.EnumMember]
		ModelTable
	}
}
