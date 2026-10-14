using System;
using System.Runtime.InteropServices;

namespace ADODB
{
	// Token: 0x02000007 RID: 7
	[global::System.Runtime.InteropServices.Guid("00000532-0000-0010-8000-00AA006D2EA4")]
	public enum ObjectStateEnum
	{
		// Token: 0x04000027 RID: 39
		adStateClosed,
		// Token: 0x04000028 RID: 40
		adStateOpen,
		// Token: 0x04000029 RID: 41
		adStateConnecting,
		// Token: 0x0400002A RID: 42
		adStateExecuting = 4,
		// Token: 0x0400002B RID: 43
		adStateFetching = 8
	}
}
