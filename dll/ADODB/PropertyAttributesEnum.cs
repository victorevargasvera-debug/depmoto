using System;
using System.Runtime.InteropServices;

namespace ADODB
{
	// Token: 0x0200001F RID: 31
	[global::System.Runtime.InteropServices.Guid("00000529-0000-0010-8000-00AA006D2EA4")]
	public enum PropertyAttributesEnum
	{
		// Token: 0x040000DF RID: 223
		adPropNotSupported,
		// Token: 0x040000E0 RID: 224
		adPropRequired,
		// Token: 0x040000E1 RID: 225
		adPropOptional,
		// Token: 0x040000E2 RID: 226
		adPropRead = 512,
		// Token: 0x040000E3 RID: 227
		adPropWrite = 1024
	}
}
