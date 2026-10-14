using System;
using System.Runtime.Serialization;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x02000046 RID: 70
	[global::System.Runtime.Serialization.DataContract]
	public enum HwConfigSectionType : byte
	{
		// Token: 0x04000202 RID: 514
		[global::System.Runtime.Serialization.EnumMember]
		Hardware_ID,
		// Token: 0x04000203 RID: 515
		[global::System.Runtime.Serialization.EnumMember]
		Flash_IC,
		// Token: 0x04000204 RID: 516
		[global::System.Runtime.Serialization.EnumMember]
		LCD,
		// Token: 0x04000205 RID: 517
		[global::System.Runtime.Serialization.EnumMember]
		HW_CONFIG_LINK_TYPE,
		// Token: 0x04000206 RID: 518
		[global::System.Runtime.Serialization.EnumMember]
		BLUETOOTH_CAPABILITY,
		// Token: 0x04000207 RID: 519
		[global::System.Runtime.Serialization.EnumMember]
		GNSS_CAPABILITY
	}
}
