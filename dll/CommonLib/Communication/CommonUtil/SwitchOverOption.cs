using System;
using System.Runtime.Serialization;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x02000012 RID: 18
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Flags]
	public enum SwitchOverOption : ushort
	{
		// Token: 0x04000095 RID: 149
		[global::System.Runtime.Serialization.EnumMember]
		None = 0,
		// Token: 0x04000096 RID: 150
		[global::System.Runtime.Serialization.EnumMember]
		DelayTOD = 64,
		// Token: 0x04000097 RID: 151
		[global::System.Runtime.Serialization.EnumMember]
		SuppressPN = 128
	}
}
