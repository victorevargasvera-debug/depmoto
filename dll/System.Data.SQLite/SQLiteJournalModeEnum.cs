using System;

namespace System.Data.SQLite
{
	// Token: 0x0200002A RID: 42
	public enum SQLiteJournalModeEnum
	{
		// Token: 0x040000EF RID: 239
		Default = -1,
		// Token: 0x040000F0 RID: 240
		Delete,
		// Token: 0x040000F1 RID: 241
		Persist,
		// Token: 0x040000F2 RID: 242
		Off,
		// Token: 0x040000F3 RID: 243
		Truncate,
		// Token: 0x040000F4 RID: 244
		Memory,
		// Token: 0x040000F5 RID: 245
		Wal
	}
}
