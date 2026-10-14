using System;

namespace System.Data.SQLite
{
	// Token: 0x02000028 RID: 40
	public enum SQLiteConnectionEventType
	{
		// Token: 0x040000D9 RID: 217
		Invalid = -1,
		// Token: 0x040000DA RID: 218
		Unknown,
		// Token: 0x040000DB RID: 219
		Opening,
		// Token: 0x040000DC RID: 220
		ConnectionString,
		// Token: 0x040000DD RID: 221
		Opened,
		// Token: 0x040000DE RID: 222
		ChangeDatabase,
		// Token: 0x040000DF RID: 223
		NewTransaction,
		// Token: 0x040000E0 RID: 224
		EnlistTransaction,
		// Token: 0x040000E1 RID: 225
		NewCommand,
		// Token: 0x040000E2 RID: 226
		NewDataReader,
		// Token: 0x040000E3 RID: 227
		NewCriticalHandle,
		// Token: 0x040000E4 RID: 228
		Closing,
		// Token: 0x040000E5 RID: 229
		Closed
	}
}
