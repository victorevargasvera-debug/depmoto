using System;
using System.Runtime.Serialization;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x02000010 RID: 16
	[global::System.Flags]
	[global::System.Runtime.Serialization.DataContract]
	public enum RadioStorage
	{
		// Token: 0x04000089 RID: 137
		[global::System.Runtime.Serialization.EnumMember]
		Unknown = 0,
		// Token: 0x0400008A RID: 138
		[global::System.Runtime.Serialization.EnumMember]
		Raw = 1,
		// Token: 0x0400008B RID: 139
		[global::System.Runtime.Serialization.EnumMember]
		FileSystem = 2,
		// Token: 0x0400008C RID: 140
		[global::System.Runtime.Serialization.EnumMember]
		Any = 65535
	}
}
