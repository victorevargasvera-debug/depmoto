using System;
using System.Runtime.Serialization;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x02000013 RID: 19
	[global::System.Runtime.Serialization.DataContract]
	public enum SwitchOverStatus
	{
		// Token: 0x04000099 RID: 153
		[global::System.Runtime.Serialization.EnumMember]
		Success,
		// Token: 0x0400009A RID: 154
		[global::System.Runtime.Serialization.EnumMember]
		InvalidSessionID = 600,
		// Token: 0x0400009B RID: 155
		[global::System.Runtime.Serialization.EnumMember]
		Failure,
		// Token: 0x0400009C RID: 156
		[global::System.Runtime.Serialization.EnumMember]
		Timeout
	}
}
