using System;
using System.Runtime.Serialization;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x02000011 RID: 17
	[global::System.Runtime.Serialization.DataContract]
	public enum InputParameterType
	{
		// Token: 0x0400008E RID: 142
		[global::System.Runtime.Serialization.EnumMember]
		None,
		// Token: 0x0400008F RID: 143
		[global::System.Runtime.Serialization.EnumMember]
		FlashStrapPath,
		// Token: 0x04000090 RID: 144
		[global::System.Runtime.Serialization.EnumMember]
		ModelNumber,
		// Token: 0x04000091 RID: 145
		[global::System.Runtime.Serialization.EnumMember]
		CPVersion,
		// Token: 0x04000092 RID: 146
		[global::System.Runtime.Serialization.EnumMember]
		SerialNumber,
		// Token: 0x04000093 RID: 147
		[global::System.Runtime.Serialization.EnumMember]
		FWPath
	}
}
