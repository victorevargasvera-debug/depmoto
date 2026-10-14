using System;
using System.Runtime.Serialization;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x02000053 RID: 83
	[global::System.Runtime.Serialization.DataContract]
	public enum RPTerminalStatus
	{
		// Token: 0x04000278 RID: 632
		[global::System.Runtime.Serialization.EnumMember]
		RP_RESET_MODE_NORMAL,
		// Token: 0x04000279 RID: 633
		[global::System.Runtime.Serialization.EnumMember]
		RP_RESET_MODE_CHARGING,
		// Token: 0x0400027A RID: 634
		[global::System.Runtime.Serialization.EnumMember]
		RP_RESET_MODE_PROGRAMMING,
		// Token: 0x0400027B RID: 635
		[global::System.Runtime.Serialization.EnumMember]
		RP_RESET_MODE_RP,
		// Token: 0x0400027C RID: 636
		[global::System.Runtime.Serialization.EnumMember]
		RP_STATUS_UNKNOWN
	}
}
