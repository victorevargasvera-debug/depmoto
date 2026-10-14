using System;

namespace System.Data.SQLite
{
	// Token: 0x0200001D RID: 29
	// (Invoke) Token: 0x0600023D RID: 573
	public delegate bool SQLiteBackupCallback(global::System.Data.SQLite.SQLiteConnection source, string sourceName, global::System.Data.SQLite.SQLiteConnection destination, string destinationName, int pages, int remainingPages, int totalPages, bool retry);
}
