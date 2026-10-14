using System;
using System.Runtime.InteropServices;

namespace ADODB
{
	// Token: 0x0200001D RID: 29
	[global::System.Runtime.InteropServices.Guid("00000523-0000-0010-8000-00AA006D2EA4")]
	public enum IsolationLevelEnum
	{
		// Token: 0x040000D0 RID: 208
		adXactUnspecified = -1,
		// Token: 0x040000D1 RID: 209
		adXactChaos = 16,
		// Token: 0x040000D2 RID: 210
		adXactReadUncommitted = 256,
		// Token: 0x040000D3 RID: 211
		adXactBrowse = 256,
		// Token: 0x040000D4 RID: 212
		adXactCursorStability = 4096,
		// Token: 0x040000D5 RID: 213
		adXactReadCommitted = 4096,
		// Token: 0x040000D6 RID: 214
		adXactRepeatableRead = 65536,
		// Token: 0x040000D7 RID: 215
		adXactSerializable = 1048576,
		// Token: 0x040000D8 RID: 216
		adXactIsolated = 1048576
	}
}
