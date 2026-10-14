using System;
using System.Runtime.InteropServices;

namespace ADODB
{
	// Token: 0x0200001E RID: 30
	[global::System.Runtime.InteropServices.Guid("00000524-0000-0010-8000-00AA006D2EA4")]
	public enum XactAttributeEnum
	{
		// Token: 0x040000DA RID: 218
		adXactCommitRetaining = 131072,
		// Token: 0x040000DB RID: 219
		adXactAbortRetaining = 262144,
		// Token: 0x040000DC RID: 220
		[global::System.Runtime.InteropServices.TypeLibVar(64)]
		adXactAsyncPhaseOne = 524288,
		// Token: 0x040000DD RID: 221
		[global::System.Runtime.InteropServices.TypeLibVar(64)]
		adXactSyncPhaseOne = 1048576
	}
}
