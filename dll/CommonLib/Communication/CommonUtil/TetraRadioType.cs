using System;
using System.Runtime.Serialization;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x02000042 RID: 66
	[global::System.Runtime.Serialization.DataContract]
	public enum TetraRadioType
	{
		// Token: 0x040001EF RID: 495
		[global::System.Runtime.Serialization.EnumMember]
		UNKNOWN,
		// Token: 0x040001F0 RID: 496
		[global::System.Runtime.Serialization.EnumMember]
		CONTROL_HEAD,
		// Token: 0x040001F1 RID: 497
		[global::System.Runtime.Serialization.EnumMember]
		TRANSCEIVER,
		// Token: 0x040001F2 RID: 498
		[global::System.Runtime.Serialization.EnumMember]
		NORMAL,
		// Token: 0x040001F3 RID: 499
		[global::System.Runtime.Serialization.EnumMember]
		DATABOX_PORT1,
		// Token: 0x040001F4 RID: 500
		[global::System.Runtime.Serialization.EnumMember]
		DATABOX_PORT2
	}
}
