using System;
using System.Runtime.InteropServices;

namespace ADODB
{
	// Token: 0x0200000A RID: 10
	[global::System.Runtime.InteropServices.Guid("00000525-0000-0010-8000-00AA006D2EA4")]
	public enum FieldAttributeEnum
	{
		// Token: 0x0400005B RID: 91
		[global::System.Runtime.InteropServices.TypeLibVar(64)]
		adFldUnspecified = -1,
		// Token: 0x0400005C RID: 92
		adFldMayDefer = 2,
		// Token: 0x0400005D RID: 93
		adFldUpdatable = 4,
		// Token: 0x0400005E RID: 94
		adFldUnknownUpdatable = 8,
		// Token: 0x0400005F RID: 95
		adFldFixed = 16,
		// Token: 0x04000060 RID: 96
		adFldIsNullable = 32,
		// Token: 0x04000061 RID: 97
		adFldMayBeNull = 64,
		// Token: 0x04000062 RID: 98
		adFldLong = 128,
		// Token: 0x04000063 RID: 99
		adFldRowID = 256,
		// Token: 0x04000064 RID: 100
		adFldRowVersion = 512,
		// Token: 0x04000065 RID: 101
		adFldCacheDeferred = 4096,
		// Token: 0x04000066 RID: 102
		adFldIsChapter = 8192,
		// Token: 0x04000067 RID: 103
		adFldNegativeScale = 16384,
		// Token: 0x04000068 RID: 104
		adFldKeyColumn = 32768,
		// Token: 0x04000069 RID: 105
		adFldIsRowURL = 65536,
		// Token: 0x0400006A RID: 106
		adFldIsDefaultStream = 131072,
		// Token: 0x0400006B RID: 107
		adFldIsCollection = 262144
	}
}
