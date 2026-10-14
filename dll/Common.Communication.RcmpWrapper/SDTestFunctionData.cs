using System;

namespace Motorola.Common.Communication
{
	// Token: 0x0200000F RID: 15
	public enum SDTestFunctionData : byte
	{
		// Token: 0x04000045 RID: 69
		SDCardPresent = 1,
		// Token: 0x04000046 RID: 70
		SDCardLoopbackTestStart,
		// Token: 0x04000047 RID: 71
		SDCardLoopbackTestStOP,
		// Token: 0x04000048 RID: 72
		SDCardLoopbackresultQuery
	}
}
