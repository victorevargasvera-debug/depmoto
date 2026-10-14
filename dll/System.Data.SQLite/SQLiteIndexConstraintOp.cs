using System;

namespace System.Data.SQLite
{
	// Token: 0x02000077 RID: 119
	public enum SQLiteIndexConstraintOp : byte
	{
		// Token: 0x040001FB RID: 507
		EqualTo = 2,
		// Token: 0x040001FC RID: 508
		GreaterThan = 4,
		// Token: 0x040001FD RID: 509
		LessThanOrEqualTo = 8,
		// Token: 0x040001FE RID: 510
		LessThan = 16,
		// Token: 0x040001FF RID: 511
		GreaterThanOrEqualTo = 32,
		// Token: 0x04000200 RID: 512
		Match = 64
	}
}
