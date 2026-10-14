using System;

namespace System.Data.SQLite
{
	// Token: 0x02000080 RID: 128
	public interface ISQLiteNativeModule
	{
		// Token: 0x06000528 RID: 1320
		global::System.Data.SQLite.SQLiteErrorCode xCreate(global::System.IntPtr pDb, global::System.IntPtr pAux, int argc, global::System.IntPtr argv, ref global::System.IntPtr pVtab, ref global::System.IntPtr pError);

		// Token: 0x06000529 RID: 1321
		global::System.Data.SQLite.SQLiteErrorCode xConnect(global::System.IntPtr pDb, global::System.IntPtr pAux, int argc, global::System.IntPtr argv, ref global::System.IntPtr pVtab, ref global::System.IntPtr pError);

		// Token: 0x0600052A RID: 1322
		global::System.Data.SQLite.SQLiteErrorCode xBestIndex(global::System.IntPtr pVtab, global::System.IntPtr pIndex);

		// Token: 0x0600052B RID: 1323
		global::System.Data.SQLite.SQLiteErrorCode xDisconnect(global::System.IntPtr pVtab);

		// Token: 0x0600052C RID: 1324
		global::System.Data.SQLite.SQLiteErrorCode xDestroy(global::System.IntPtr pVtab);

		// Token: 0x0600052D RID: 1325
		global::System.Data.SQLite.SQLiteErrorCode xOpen(global::System.IntPtr pVtab, ref global::System.IntPtr pCursor);

		// Token: 0x0600052E RID: 1326
		global::System.Data.SQLite.SQLiteErrorCode xClose(global::System.IntPtr pCursor);

		// Token: 0x0600052F RID: 1327
		global::System.Data.SQLite.SQLiteErrorCode xFilter(global::System.IntPtr pCursor, int idxNum, global::System.IntPtr idxStr, int argc, global::System.IntPtr argv);

		// Token: 0x06000530 RID: 1328
		global::System.Data.SQLite.SQLiteErrorCode xNext(global::System.IntPtr pCursor);

		// Token: 0x06000531 RID: 1329
		int xEof(global::System.IntPtr pCursor);

		// Token: 0x06000532 RID: 1330
		global::System.Data.SQLite.SQLiteErrorCode xColumn(global::System.IntPtr pCursor, global::System.IntPtr pContext, int index);

		// Token: 0x06000533 RID: 1331
		global::System.Data.SQLite.SQLiteErrorCode xRowId(global::System.IntPtr pCursor, ref long rowId);

		// Token: 0x06000534 RID: 1332
		global::System.Data.SQLite.SQLiteErrorCode xUpdate(global::System.IntPtr pVtab, int argc, global::System.IntPtr argv, ref long rowId);

		// Token: 0x06000535 RID: 1333
		global::System.Data.SQLite.SQLiteErrorCode xBegin(global::System.IntPtr pVtab);

		// Token: 0x06000536 RID: 1334
		global::System.Data.SQLite.SQLiteErrorCode xSync(global::System.IntPtr pVtab);

		// Token: 0x06000537 RID: 1335
		global::System.Data.SQLite.SQLiteErrorCode xCommit(global::System.IntPtr pVtab);

		// Token: 0x06000538 RID: 1336
		global::System.Data.SQLite.SQLiteErrorCode xRollback(global::System.IntPtr pVtab);

		// Token: 0x06000539 RID: 1337
		int xFindFunction(global::System.IntPtr pVtab, int nArg, global::System.IntPtr zName, ref global::System.Data.SQLite.SQLiteCallback callback, ref global::System.IntPtr pClientData);

		// Token: 0x0600053A RID: 1338
		global::System.Data.SQLite.SQLiteErrorCode xRename(global::System.IntPtr pVtab, global::System.IntPtr zNew);

		// Token: 0x0600053B RID: 1339
		global::System.Data.SQLite.SQLiteErrorCode xSavepoint(global::System.IntPtr pVtab, int iSavepoint);

		// Token: 0x0600053C RID: 1340
		global::System.Data.SQLite.SQLiteErrorCode xRelease(global::System.IntPtr pVtab, int iSavepoint);

		// Token: 0x0600053D RID: 1341
		global::System.Data.SQLite.SQLiteErrorCode xRollbackTo(global::System.IntPtr pVtab, int iSavepoint);
	}
}
