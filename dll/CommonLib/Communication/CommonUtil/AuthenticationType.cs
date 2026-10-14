using System;
using System.Runtime.Serialization;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x02000002 RID: 2
	[global::System.Runtime.Serialization.DataContract]
	public enum AuthenticationType : short
	{
		// Token: 0x04000002 RID: 2
		[global::System.Runtime.Serialization.EnumMember]
		None = -1,
		// Token: 0x04000003 RID: 3
		[global::System.Runtime.Serialization.EnumMember]
		PreSharedKey,
		// Token: 0x04000004 RID: 4
		[global::System.Runtime.Serialization.EnumMember]
		Certificate,
		// Token: 0x04000005 RID: 5
		[global::System.Runtime.Serialization.EnumMember]
		PasswordIndex
	}
}
