using System;
using System.Runtime.Serialization;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x02000016 RID: 22
	[global::System.Runtime.Serialization.DataContract]
	public enum ProgrammingStatus
	{
		// Token: 0x040000A5 RID: 165
		[global::System.Runtime.Serialization.EnumMember]
		Connect,
		// Token: 0x040000A6 RID: 166
		[global::System.Runtime.Serialization.EnumMember]
		Pending,
		// Token: 0x040000A7 RID: 167
		[global::System.Runtime.Serialization.EnumMember]
		Idle,
		// Token: 0x040000A8 RID: 168
		[global::System.Runtime.Serialization.EnumMember]
		StartingJob,
		// Token: 0x040000A9 RID: 169
		[global::System.Runtime.Serialization.EnumMember]
		JobSuccess,
		// Token: 0x040000AA RID: 170
		[global::System.Runtime.Serialization.EnumMember]
		JobFailure
	}
}
