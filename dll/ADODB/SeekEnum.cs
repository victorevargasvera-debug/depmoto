using System;
using System.Runtime.InteropServices;

namespace ADODB
{
	// Token: 0x02000028 RID: 40
	[global::System.Runtime.InteropServices.Guid("00000552-0000-0010-8000-00AA006D2EA4")]
	public enum SeekEnum
	{
		// Token: 0x0400019B RID: 411
		adSeekFirstEQ = 1,
		// Token: 0x0400019C RID: 412
		adSeekLastEQ,
		// Token: 0x0400019D RID: 413
		adSeekAfterEQ = 4,
		// Token: 0x0400019E RID: 414
		adSeekAfter = 8,
		// Token: 0x0400019F RID: 415
		adSeekBeforeEQ = 16,
		// Token: 0x040001A0 RID: 416
		adSeekBefore = 32
	}
}
