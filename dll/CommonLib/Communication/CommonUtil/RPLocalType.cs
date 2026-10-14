using System;
using System.Runtime.Serialization;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x0200003B RID: 59
	[global::System.Runtime.Serialization.DataContract]
	public enum RPLocalType : byte
	{
		// Token: 0x040001A5 RID: 421
		[global::System.Runtime.Serialization.EnumMember]
		UNKNOWN,
		// Token: 0x040001A6 RID: 422
		[global::System.Runtime.Serialization.EnumMember]
		PASSIVE_PEER = 3
	}
}
