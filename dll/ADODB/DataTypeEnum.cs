using System;
using System.Runtime.InteropServices;

namespace ADODB
{
	// Token: 0x02000009 RID: 9
	[global::System.Runtime.InteropServices.Guid("0000051F-0000-0010-8000-00AA006D2EA4")]
	public enum DataTypeEnum
	{
		// Token: 0x04000032 RID: 50
		adEmpty,
		// Token: 0x04000033 RID: 51
		adTinyInt = 16,
		// Token: 0x04000034 RID: 52
		adSmallInt = 2,
		// Token: 0x04000035 RID: 53
		adInteger,
		// Token: 0x04000036 RID: 54
		adBigInt = 20,
		// Token: 0x04000037 RID: 55
		adUnsignedTinyInt = 17,
		// Token: 0x04000038 RID: 56
		adUnsignedSmallInt,
		// Token: 0x04000039 RID: 57
		adUnsignedInt,
		// Token: 0x0400003A RID: 58
		adUnsignedBigInt = 21,
		// Token: 0x0400003B RID: 59
		adSingle = 4,
		// Token: 0x0400003C RID: 60
		adDouble,
		// Token: 0x0400003D RID: 61
		adCurrency,
		// Token: 0x0400003E RID: 62
		adDecimal = 14,
		// Token: 0x0400003F RID: 63
		adNumeric = 131,
		// Token: 0x04000040 RID: 64
		adBoolean = 11,
		// Token: 0x04000041 RID: 65
		adError = 10,
		// Token: 0x04000042 RID: 66
		adUserDefined = 132,
		// Token: 0x04000043 RID: 67
		adVariant = 12,
		// Token: 0x04000044 RID: 68
		adIDispatch = 9,
		// Token: 0x04000045 RID: 69
		adIUnknown = 13,
		// Token: 0x04000046 RID: 70
		adGUID = 72,
		// Token: 0x04000047 RID: 71
		adDate = 7,
		// Token: 0x04000048 RID: 72
		adDBDate = 133,
		// Token: 0x04000049 RID: 73
		adDBTime,
		// Token: 0x0400004A RID: 74
		adDBTimeStamp,
		// Token: 0x0400004B RID: 75
		adBSTR = 8,
		// Token: 0x0400004C RID: 76
		adChar = 129,
		// Token: 0x0400004D RID: 77
		adVarChar = 200,
		// Token: 0x0400004E RID: 78
		adLongVarChar,
		// Token: 0x0400004F RID: 79
		adWChar = 130,
		// Token: 0x04000050 RID: 80
		adVarWChar = 202,
		// Token: 0x04000051 RID: 81
		adLongVarWChar,
		// Token: 0x04000052 RID: 82
		adBinary = 128,
		// Token: 0x04000053 RID: 83
		adVarBinary = 204,
		// Token: 0x04000054 RID: 84
		adLongVarBinary,
		// Token: 0x04000055 RID: 85
		adChapter = 136,
		// Token: 0x04000056 RID: 86
		adFileTime = 64,
		// Token: 0x04000057 RID: 87
		adPropVariant = 138,
		// Token: 0x04000058 RID: 88
		adVarNumeric,
		// Token: 0x04000059 RID: 89
		adArray = 8192
	}
}
