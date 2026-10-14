using System;

namespace Motorola.Common.Communication
{
	// Token: 0x0200000D RID: 13
	internal enum LPUpdateType
	{
		// Token: 0x04000023 RID: 35
		NoLPUpdate,
		// Token: 0x04000024 RID: 36
		OnlyWriteNoDeleteLP,
		// Token: 0x04000025 RID: 37
		WriteThenDeletLP,
		// Token: 0x04000026 RID: 38
		DeleteThenWriteLP,
		// Token: 0x04000027 RID: 39
		DeleteAllLP,
		// Token: 0x04000028 RID: 40
		NewLPWrite
	}
}
