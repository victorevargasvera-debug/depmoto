using System;
using System.Runtime.Serialization;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x02000057 RID: 87
	[global::System.Runtime.Serialization.DataContract]
	public enum FlashOperationType
	{
		// Token: 0x0400029B RID: 667
		[global::System.Runtime.Serialization.EnumMember]
		BACKUP,
		// Token: 0x0400029C RID: 668
		[global::System.Runtime.Serialization.EnumMember]
		RESTORE,
		// Token: 0x0400029D RID: 669
		[global::System.Runtime.Serialization.EnumMember]
		NONE
	}
}
