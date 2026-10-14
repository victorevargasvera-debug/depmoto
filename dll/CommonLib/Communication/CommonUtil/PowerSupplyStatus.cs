using System;
using System.Runtime.Serialization;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x02000058 RID: 88
	[global::System.Runtime.Serialization.DataContract]
	public enum PowerSupplyStatus
	{
		// Token: 0x0400029F RID: 671
		[global::System.Runtime.Serialization.EnumMember]
		POWERED_BY_BATTERY_AND_NO_CHARGER,
		// Token: 0x040002A0 RID: 672
		[global::System.Runtime.Serialization.EnumMember]
		POWERED_BY_DC_AND_BATTERY_IS_CHARGING,
		// Token: 0x040002A1 RID: 673
		[global::System.Runtime.Serialization.EnumMember]
		POWERED_BY_DC_ONLY_AND_NO_BATTERY,
		// Token: 0x040002A2 RID: 674
		[global::System.Runtime.Serialization.EnumMember]
		RECOGNIZE_FAILED,
		// Token: 0x040002A3 RID: 675
		[global::System.Runtime.Serialization.EnumMember]
		UN_DEFINED
	}
}
