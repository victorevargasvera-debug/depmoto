using System;
using System.Runtime.Serialization;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x0200004E RID: 78
	[global::System.Runtime.Serialization.DataContract]
	public enum FDT_CMD
	{
		// Token: 0x0400023F RID: 575
		[global::System.Runtime.Serialization.EnumMember]
		Read_FDT,
		// Token: 0x04000240 RID: 576
		[global::System.Runtime.Serialization.EnumMember]
		Write_Updated_State,
		// Token: 0x04000241 RID: 577
		[global::System.Runtime.Serialization.EnumMember]
		Write_Ready_State,
		// Token: 0x04000242 RID: 578
		[global::System.Runtime.Serialization.EnumMember]
		Initialize_FDT
	}
}
