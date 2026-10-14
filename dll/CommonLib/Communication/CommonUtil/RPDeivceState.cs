using System;
using System.Runtime.Serialization;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x0200004A RID: 74
	[global::System.Runtime.Serialization.DataContract]
	public enum RPDeivceState
	{
		// Token: 0x04000222 RID: 546
		[global::System.Runtime.Serialization.EnumMember]
		NORMAL_NO_RP,
		// Token: 0x04000223 RID: 547
		[global::System.Runtime.Serialization.EnumMember]
		GREEN_NO_UPDATE,
		// Token: 0x04000224 RID: 548
		[global::System.Runtime.Serialization.EnumMember]
		WHITE_CHARGING_BATTERY,
		// Token: 0x04000225 RID: 549
		[global::System.Runtime.Serialization.EnumMember]
		RED_PROGRAMMING_FAILED,
		// Token: 0x04000226 RID: 550
		[global::System.Runtime.Serialization.EnumMember]
		ORANGE_SYNCHRONIZING
	}
}
