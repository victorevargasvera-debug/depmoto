using System;
using System.Runtime.Serialization;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x02000043 RID: 67
	[global::System.Runtime.Serialization.DataContract]
	public enum ActiveTransRadioType
	{
		// Token: 0x040001F6 RID: 502
		[global::System.Runtime.Serialization.EnumMember]
		UNKNOWN,
		// Token: 0x040001F7 RID: 503
		[global::System.Runtime.Serialization.EnumMember]
		LegacyRadio,
		// Token: 0x040001F8 RID: 504
		[global::System.Runtime.Serialization.EnumMember]
		FrodoRadio,
		// Token: 0x040001F9 RID: 505
		NotAvailble
	}
}
