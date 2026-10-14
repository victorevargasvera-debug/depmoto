using System;
using System.Runtime.InteropServices;

namespace ADODB
{
	// Token: 0x02000005 RID: 5
	[global::System.Runtime.InteropServices.Guid("0000051E-0000-0010-8000-00AA006D2EA4")]
	public enum ExecuteOptionEnum
	{
		// Token: 0x0400001C RID: 28
		[global::System.Runtime.InteropServices.TypeLibVar(64)]
		adOptionUnspecified = -1,
		// Token: 0x0400001D RID: 29
		adAsyncExecute = 16,
		// Token: 0x0400001E RID: 30
		adAsyncFetch = 32,
		// Token: 0x0400001F RID: 31
		adAsyncFetchNonBlocking = 64,
		// Token: 0x04000020 RID: 32
		adExecuteNoRecords = 128,
		// Token: 0x04000021 RID: 33
		adExecuteStream = 1024,
		// Token: 0x04000022 RID: 34
		[global::System.Runtime.InteropServices.TypeLibVar(64)]
		adExecuteRecord = 2048
	}
}
