using System;
using System.Runtime.InteropServices;

namespace ADODB
{
	// Token: 0x02000008 RID: 8
	[global::System.Runtime.InteropServices.Guid("0000052F-0000-0010-8000-00AA006D2EA4")]
	public enum CursorLocationEnum
	{
		// Token: 0x0400002D RID: 45
		[global::System.Runtime.InteropServices.TypeLibVar(64)]
		adUseNone = 1,
		// Token: 0x0400002E RID: 46
		adUseServer,
		// Token: 0x0400002F RID: 47
		adUseClient,
		// Token: 0x04000030 RID: 48
		[global::System.Runtime.InteropServices.TypeLibVar(64)]
		adUseClientBatch = 3
	}
}
