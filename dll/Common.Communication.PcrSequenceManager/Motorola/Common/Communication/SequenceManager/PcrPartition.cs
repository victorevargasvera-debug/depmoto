using System;

namespace Motorola.Common.Communication.SequenceManager
{
	// Token: 0x0200003E RID: 62
	internal enum PcrPartition : byte
	{
		// Token: 0x04000123 RID: 291
		Application = 128,
		// Token: 0x04000124 RID: 292
		Security,
		// Token: 0x04000125 RID: 293
		Tune,
		// Token: 0x04000126 RID: 294
		Cfs = 135,
		// Token: 0x04000127 RID: 295
		Ucl = 147
	}
}
