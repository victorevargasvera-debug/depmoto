using System;

namespace System.Data.SQLite
{
	// Token: 0x0200000B RID: 11
	[global::System.Flags]
	internal enum SQLiteOpenFlagsEnum
	{
		// Token: 0x0400002E RID: 46
		None = 0,
		// Token: 0x0400002F RID: 47
		ReadOnly = 1,
		// Token: 0x04000030 RID: 48
		ReadWrite = 2,
		// Token: 0x04000031 RID: 49
		Create = 4,
		// Token: 0x04000032 RID: 50
		Uri = 64,
		// Token: 0x04000033 RID: 51
		SharedCache = 16777216,
		// Token: 0x04000034 RID: 52
		Default = 6
	}
}
