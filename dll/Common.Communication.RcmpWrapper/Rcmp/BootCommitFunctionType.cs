using System;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x0200001F RID: 31
	public enum BootCommitFunctionType : byte
	{
		// Token: 0x04000096 RID: 150
		None,
		// Token: 0x04000097 RID: 151
		QueryStatus,
		// Token: 0x04000098 RID: 152
		CommitToFlash,
		// Token: 0x04000099 RID: 153
		CommitToControllerFPGA,
		// Token: 0x0400009A RID: 154
		CommitToWirelineFPGA
	}
}
