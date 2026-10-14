using System;

namespace System.Data.SQLite
{
	// Token: 0x02000081 RID: 129
	public interface ISQLiteManagedModule
	{
		// Token: 0x170000AB RID: 171
		// (get) Token: 0x0600053E RID: 1342
		bool Declared { get; }

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x0600053F RID: 1343
		string Name { get; }

		// Token: 0x06000540 RID: 1344
		global::System.Data.SQLite.SQLiteErrorCode Create(global::System.Data.SQLite.SQLiteConnection connection, global::System.IntPtr pClientData, string[] arguments, ref global::System.Data.SQLite.SQLiteVirtualTable table, ref string error);

		// Token: 0x06000541 RID: 1345
		global::System.Data.SQLite.SQLiteErrorCode Connect(global::System.Data.SQLite.SQLiteConnection connection, global::System.IntPtr pClientData, string[] arguments, ref global::System.Data.SQLite.SQLiteVirtualTable table, ref string error);

		// Token: 0x06000542 RID: 1346
		global::System.Data.SQLite.SQLiteErrorCode BestIndex(global::System.Data.SQLite.SQLiteVirtualTable table, global::System.Data.SQLite.SQLiteIndex index);

		// Token: 0x06000543 RID: 1347
		global::System.Data.SQLite.SQLiteErrorCode Disconnect(global::System.Data.SQLite.SQLiteVirtualTable table);

		// Token: 0x06000544 RID: 1348
		global::System.Data.SQLite.SQLiteErrorCode Destroy(global::System.Data.SQLite.SQLiteVirtualTable table);

		// Token: 0x06000545 RID: 1349
		global::System.Data.SQLite.SQLiteErrorCode Open(global::System.Data.SQLite.SQLiteVirtualTable table, ref global::System.Data.SQLite.SQLiteVirtualTableCursor cursor);

		// Token: 0x06000546 RID: 1350
		global::System.Data.SQLite.SQLiteErrorCode Close(global::System.Data.SQLite.SQLiteVirtualTableCursor cursor);

		// Token: 0x06000547 RID: 1351
		global::System.Data.SQLite.SQLiteErrorCode Filter(global::System.Data.SQLite.SQLiteVirtualTableCursor cursor, int indexNumber, string indexString, global::System.Data.SQLite.SQLiteValue[] values);

		// Token: 0x06000548 RID: 1352
		global::System.Data.SQLite.SQLiteErrorCode Next(global::System.Data.SQLite.SQLiteVirtualTableCursor cursor);

		// Token: 0x06000549 RID: 1353
		bool Eof(global::System.Data.SQLite.SQLiteVirtualTableCursor cursor);

		// Token: 0x0600054A RID: 1354
		global::System.Data.SQLite.SQLiteErrorCode Column(global::System.Data.SQLite.SQLiteVirtualTableCursor cursor, global::System.Data.SQLite.SQLiteContext context, int index);

		// Token: 0x0600054B RID: 1355
		global::System.Data.SQLite.SQLiteErrorCode RowId(global::System.Data.SQLite.SQLiteVirtualTableCursor cursor, ref long rowId);

		// Token: 0x0600054C RID: 1356
		global::System.Data.SQLite.SQLiteErrorCode Update(global::System.Data.SQLite.SQLiteVirtualTable table, global::System.Data.SQLite.SQLiteValue[] values, ref long rowId);

		// Token: 0x0600054D RID: 1357
		global::System.Data.SQLite.SQLiteErrorCode Begin(global::System.Data.SQLite.SQLiteVirtualTable table);

		// Token: 0x0600054E RID: 1358
		global::System.Data.SQLite.SQLiteErrorCode Sync(global::System.Data.SQLite.SQLiteVirtualTable table);

		// Token: 0x0600054F RID: 1359
		global::System.Data.SQLite.SQLiteErrorCode Commit(global::System.Data.SQLite.SQLiteVirtualTable table);

		// Token: 0x06000550 RID: 1360
		global::System.Data.SQLite.SQLiteErrorCode Rollback(global::System.Data.SQLite.SQLiteVirtualTable table);

		// Token: 0x06000551 RID: 1361
		bool FindFunction(global::System.Data.SQLite.SQLiteVirtualTable table, int argumentCount, string name, ref global::System.Data.SQLite.SQLiteFunction function, ref global::System.IntPtr pClientData);

		// Token: 0x06000552 RID: 1362
		global::System.Data.SQLite.SQLiteErrorCode Rename(global::System.Data.SQLite.SQLiteVirtualTable table, string newName);

		// Token: 0x06000553 RID: 1363
		global::System.Data.SQLite.SQLiteErrorCode Savepoint(global::System.Data.SQLite.SQLiteVirtualTable table, int savepoint);

		// Token: 0x06000554 RID: 1364
		global::System.Data.SQLite.SQLiteErrorCode Release(global::System.Data.SQLite.SQLiteVirtualTable table, int savepoint);

		// Token: 0x06000555 RID: 1365
		global::System.Data.SQLite.SQLiteErrorCode RollbackTo(global::System.Data.SQLite.SQLiteVirtualTable table, int savepoint);
	}
}
