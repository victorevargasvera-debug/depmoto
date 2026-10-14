using System;
using System.Runtime.Serialization;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x0200000D RID: 13
	[global::System.Runtime.Serialization.DataContract]
	public enum RadioState
	{
		// Token: 0x04000050 RID: 80
		[global::System.Runtime.Serialization.EnumMember]
		None,
		// Token: 0x04000051 RID: 81
		[global::System.Runtime.Serialization.EnumMember]
		Attached,
		// Token: 0x04000052 RID: 82
		[global::System.Runtime.Serialization.EnumMember]
		InitializingDevice,
		// Token: 0x04000053 RID: 83
		[global::System.Runtime.Serialization.EnumMember]
		Connecting,
		// Token: 0x04000054 RID: 84
		[global::System.Runtime.Serialization.EnumMember]
		Ready,
		// Token: 0x04000055 RID: 85
		[global::System.Runtime.Serialization.EnumMember]
		Busy,
		// Token: 0x04000056 RID: 86
		[global::System.Runtime.Serialization.EnumMember]
		Removing,
		// Token: 0x04000057 RID: 87
		[global::System.Runtime.Serialization.EnumMember]
		Detached
	}
}
