using System;
using System.Runtime.InteropServices;

namespace ADODB
{
	// Token: 0x02000003 RID: 3
	[global::System.Runtime.InteropServices.Guid("0000051C-0000-0010-8000-00AA006D2EA4")]
	public enum CursorOptionEnum
	{
		// Token: 0x04000008 RID: 8
		adHoldRecords = 256,
		// Token: 0x04000009 RID: 9
		adMovePrevious = 512,
		// Token: 0x0400000A RID: 10
		adAddNew = 16778240,
		// Token: 0x0400000B RID: 11
		adDelete = 16779264,
		// Token: 0x0400000C RID: 12
		adUpdate = 16809984,
		// Token: 0x0400000D RID: 13
		adBookmark = 8192,
		// Token: 0x0400000E RID: 14
		adApproxPosition = 16384,
		// Token: 0x0400000F RID: 15
		adUpdateBatch = 65536,
		// Token: 0x04000010 RID: 16
		adResync = 131072,
		// Token: 0x04000011 RID: 17
		adNotify = 262144,
		// Token: 0x04000012 RID: 18
		adFind = 524288,
		// Token: 0x04000013 RID: 19
		adSeek = 4194304,
		// Token: 0x04000014 RID: 20
		adIndex = 8388608
	}
}
