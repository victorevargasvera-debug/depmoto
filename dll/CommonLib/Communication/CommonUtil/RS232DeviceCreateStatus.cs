using System;
using System.Runtime.Serialization;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x0200005A RID: 90
	[global::System.Runtime.Serialization.DataContract]
	public enum RS232DeviceCreateStatus
	{
		// Token: 0x0400032B RID: 811
		[global::System.Runtime.Serialization.EnumMember]
		NOT_START,
		// Token: 0x0400032C RID: 812
		[global::System.Runtime.Serialization.EnumMember]
		CREATING,
		// Token: 0x0400032D RID: 813
		[global::System.Runtime.Serialization.EnumMember]
		CREATED,
		// Token: 0x0400032E RID: 814
		[global::System.Runtime.Serialization.EnumMember]
		FORCE_CANCELLED,
		// Token: 0x0400032F RID: 815
		[global::System.Runtime.Serialization.EnumMember]
		UN_DEFINED
	}
}
