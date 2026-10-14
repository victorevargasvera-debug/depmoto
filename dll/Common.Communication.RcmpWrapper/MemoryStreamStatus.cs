using System;

namespace Motorola.Common.Communication
{
	// Token: 0x02000004 RID: 4
	public enum MemoryStreamStatus : byte
	{
		// Token: 0x04000009 RID: 9
		Success,
		// Token: 0x0400000A RID: 10
		Transfer_failed,
		// Token: 0x0400000B RID: 11
		Flash_failed,
		// Token: 0x0400000C RID: 12
		Transfer_in_progress,
		// Token: 0x0400000D RID: 13
		Flash_in_progress
	}
}
