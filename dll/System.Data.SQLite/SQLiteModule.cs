using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;

namespace System.Data.SQLite
{
	// Token: 0x02000086 RID: 134
	public abstract class SQLiteModule : global::System.Data.SQLite.ISQLiteManagedModule, global::System.IDisposable
	{
		// Token: 0x0600056D RID: 1389 RVA: 0x00022670 File Offset: 0x00021A70
		public SQLiteModule(string name)
		{
			if (name == null)
			{
				throw new global::System.ArgumentNullException("name");
			}
			this.name = name;
			this.tables = new global::System.Collections.Generic.Dictionary<global::System.IntPtr, global::System.Data.SQLite.SQLiteVirtualTable>();
			this.cursors = new global::System.Collections.Generic.Dictionary<global::System.IntPtr, global::System.Data.SQLite.SQLiteVirtualTableCursor>();
			this.functions = new global::System.Collections.Generic.Dictionary<string, global::System.Data.SQLite.SQLiteFunction>();
		}

		// Token: 0x0600056E RID: 1390 RVA: 0x000226BC File Offset: 0x00021ABC
		internal bool CreateDisposableModule(global::System.IntPtr pDb)
		{
			if (this.disposableModule != global::System.IntPtr.Zero)
			{
				return true;
			}
			global::System.IntPtr intPtr = global::System.IntPtr.Zero;
			bool result;
			try
			{
				intPtr = global::System.Data.SQLite.SQLiteString.Utf8IntPtrFromString(this.name);
				global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_module sqlite3_module = this.AllocateNativeModule();
				this.destroyModule = new global::System.Data.SQLite.UnsafeNativeMethods.xDestroyModule(this.xDestroyModule);
				this.disposableModule = global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_create_disposable_module(pDb, intPtr, ref sqlite3_module, global::System.IntPtr.Zero, this.destroyModule);
				result = (this.disposableModule != global::System.IntPtr.Zero);
			}
			finally
			{
				if (intPtr != global::System.IntPtr.Zero)
				{
					global::System.Data.SQLite.SQLiteMemory.Free(intPtr);
					intPtr = global::System.IntPtr.Zero;
				}
			}
			return result;
		}

		// Token: 0x0600056F RID: 1391 RVA: 0x0002276C File Offset: 0x00021B6C
		private void xDestroyModule(global::System.IntPtr pClientData)
		{
			this.disposableModule = global::System.IntPtr.Zero;
		}

		// Token: 0x06000570 RID: 1392 RVA: 0x00022784 File Offset: 0x00021B84
		private global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_module AllocateNativeModule()
		{
			return this.AllocateNativeModule(this.GetNativeModuleImpl());
		}

		// Token: 0x06000571 RID: 1393 RVA: 0x000227A0 File Offset: 0x00021BA0
		private global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_module AllocateNativeModule(global::System.Data.SQLite.ISQLiteNativeModule module)
		{
			this.nativeModule = default(global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_module);
			this.nativeModule.iVersion = global::System.Data.SQLite.SQLiteModule.DefaultModuleVersion;
			if (module != null)
			{
				this.nativeModule.xCreate = new global::System.Data.SQLite.UnsafeNativeMethods.xCreate(module.xCreate);
				this.nativeModule.xConnect = new global::System.Data.SQLite.UnsafeNativeMethods.xConnect(module.xConnect);
				this.nativeModule.xBestIndex = new global::System.Data.SQLite.UnsafeNativeMethods.xBestIndex(module.xBestIndex);
				this.nativeModule.xDisconnect = new global::System.Data.SQLite.UnsafeNativeMethods.xDisconnect(module.xDisconnect);
				this.nativeModule.xDestroy = new global::System.Data.SQLite.UnsafeNativeMethods.xDestroy(module.xDestroy);
				this.nativeModule.xOpen = new global::System.Data.SQLite.UnsafeNativeMethods.xOpen(module.xOpen);
				this.nativeModule.xClose = new global::System.Data.SQLite.UnsafeNativeMethods.xClose(module.xClose);
				this.nativeModule.xFilter = new global::System.Data.SQLite.UnsafeNativeMethods.xFilter(module.xFilter);
				this.nativeModule.xNext = new global::System.Data.SQLite.UnsafeNativeMethods.xNext(module.xNext);
				this.nativeModule.xEof = new global::System.Data.SQLite.UnsafeNativeMethods.xEof(module.xEof);
				this.nativeModule.xColumn = new global::System.Data.SQLite.UnsafeNativeMethods.xColumn(module.xColumn);
				this.nativeModule.xRowId = new global::System.Data.SQLite.UnsafeNativeMethods.xRowId(module.xRowId);
				this.nativeModule.xUpdate = new global::System.Data.SQLite.UnsafeNativeMethods.xUpdate(module.xUpdate);
				this.nativeModule.xBegin = new global::System.Data.SQLite.UnsafeNativeMethods.xBegin(module.xBegin);
				this.nativeModule.xSync = new global::System.Data.SQLite.UnsafeNativeMethods.xSync(module.xSync);
				this.nativeModule.xCommit = new global::System.Data.SQLite.UnsafeNativeMethods.xCommit(module.xCommit);
				this.nativeModule.xRollback = new global::System.Data.SQLite.UnsafeNativeMethods.xRollback(module.xRollback);
				this.nativeModule.xFindFunction = new global::System.Data.SQLite.UnsafeNativeMethods.xFindFunction(module.xFindFunction);
				this.nativeModule.xRename = new global::System.Data.SQLite.UnsafeNativeMethods.xRename(module.xRename);
				this.nativeModule.xSavepoint = new global::System.Data.SQLite.UnsafeNativeMethods.xSavepoint(module.xSavepoint);
				this.nativeModule.xRelease = new global::System.Data.SQLite.UnsafeNativeMethods.xRelease(module.xRelease);
				this.nativeModule.xRollbackTo = new global::System.Data.SQLite.UnsafeNativeMethods.xRollbackTo(module.xRollbackTo);
			}
			else
			{
				this.nativeModule.xCreate = new global::System.Data.SQLite.UnsafeNativeMethods.xCreate(this.xCreate);
				this.nativeModule.xConnect = new global::System.Data.SQLite.UnsafeNativeMethods.xConnect(this.xConnect);
				this.nativeModule.xBestIndex = new global::System.Data.SQLite.UnsafeNativeMethods.xBestIndex(this.xBestIndex);
				this.nativeModule.xDisconnect = new global::System.Data.SQLite.UnsafeNativeMethods.xDisconnect(this.xDisconnect);
				this.nativeModule.xDestroy = new global::System.Data.SQLite.UnsafeNativeMethods.xDestroy(this.xDestroy);
				this.nativeModule.xOpen = new global::System.Data.SQLite.UnsafeNativeMethods.xOpen(this.xOpen);
				this.nativeModule.xClose = new global::System.Data.SQLite.UnsafeNativeMethods.xClose(this.xClose);
				this.nativeModule.xFilter = new global::System.Data.SQLite.UnsafeNativeMethods.xFilter(this.xFilter);
				this.nativeModule.xNext = new global::System.Data.SQLite.UnsafeNativeMethods.xNext(this.xNext);
				this.nativeModule.xEof = new global::System.Data.SQLite.UnsafeNativeMethods.xEof(this.xEof);
				this.nativeModule.xColumn = new global::System.Data.SQLite.UnsafeNativeMethods.xColumn(this.xColumn);
				this.nativeModule.xRowId = new global::System.Data.SQLite.UnsafeNativeMethods.xRowId(this.xRowId);
				this.nativeModule.xUpdate = new global::System.Data.SQLite.UnsafeNativeMethods.xUpdate(this.xUpdate);
				this.nativeModule.xBegin = new global::System.Data.SQLite.UnsafeNativeMethods.xBegin(this.xBegin);
				this.nativeModule.xSync = new global::System.Data.SQLite.UnsafeNativeMethods.xSync(this.xSync);
				this.nativeModule.xCommit = new global::System.Data.SQLite.UnsafeNativeMethods.xCommit(this.xCommit);
				this.nativeModule.xRollback = new global::System.Data.SQLite.UnsafeNativeMethods.xRollback(this.xRollback);
				this.nativeModule.xFindFunction = new global::System.Data.SQLite.UnsafeNativeMethods.xFindFunction(this.xFindFunction);
				this.nativeModule.xRename = new global::System.Data.SQLite.UnsafeNativeMethods.xRename(this.xRename);
				this.nativeModule.xSavepoint = new global::System.Data.SQLite.UnsafeNativeMethods.xSavepoint(this.xSavepoint);
				this.nativeModule.xRelease = new global::System.Data.SQLite.UnsafeNativeMethods.xRelease(this.xRelease);
				this.nativeModule.xRollbackTo = new global::System.Data.SQLite.UnsafeNativeMethods.xRollbackTo(this.xRollbackTo);
			}
			return this.nativeModule;
		}

		// Token: 0x06000572 RID: 1394 RVA: 0x00022BE4 File Offset: 0x00021FE4
		private global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_module CopyNativeModule(global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_module module)
		{
			return new global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_module
			{
				iVersion = module.iVersion,
				xCreate = new global::System.Data.SQLite.UnsafeNativeMethods.xCreate(((module.xCreate != null) ? module.xCreate : new global::System.Data.SQLite.UnsafeNativeMethods.xCreate(this, ldftn(xCreate))).Invoke),
				xConnect = new global::System.Data.SQLite.UnsafeNativeMethods.xConnect(((module.xConnect != null) ? module.xConnect : new global::System.Data.SQLite.UnsafeNativeMethods.xConnect(this, ldftn(xConnect))).Invoke),
				xBestIndex = new global::System.Data.SQLite.UnsafeNativeMethods.xBestIndex(((module.xBestIndex != null) ? module.xBestIndex : new global::System.Data.SQLite.UnsafeNativeMethods.xBestIndex(this, ldftn(xBestIndex))).Invoke),
				xDisconnect = new global::System.Data.SQLite.UnsafeNativeMethods.xDisconnect(((module.xDisconnect != null) ? module.xDisconnect : new global::System.Data.SQLite.UnsafeNativeMethods.xDisconnect(this, ldftn(xDisconnect))).Invoke),
				xDestroy = new global::System.Data.SQLite.UnsafeNativeMethods.xDestroy(((module.xDestroy != null) ? module.xDestroy : new global::System.Data.SQLite.UnsafeNativeMethods.xDestroy(this, ldftn(xDestroy))).Invoke),
				xOpen = new global::System.Data.SQLite.UnsafeNativeMethods.xOpen(((module.xOpen != null) ? module.xOpen : new global::System.Data.SQLite.UnsafeNativeMethods.xOpen(this, ldftn(xOpen))).Invoke),
				xClose = new global::System.Data.SQLite.UnsafeNativeMethods.xClose(((module.xClose != null) ? module.xClose : new global::System.Data.SQLite.UnsafeNativeMethods.xClose(this, ldftn(xClose))).Invoke),
				xFilter = new global::System.Data.SQLite.UnsafeNativeMethods.xFilter(((module.xFilter != null) ? module.xFilter : new global::System.Data.SQLite.UnsafeNativeMethods.xFilter(this, ldftn(xFilter))).Invoke),
				xNext = new global::System.Data.SQLite.UnsafeNativeMethods.xNext(((module.xNext != null) ? module.xNext : new global::System.Data.SQLite.UnsafeNativeMethods.xNext(this, ldftn(xNext))).Invoke),
				xEof = new global::System.Data.SQLite.UnsafeNativeMethods.xEof(((module.xEof != null) ? module.xEof : new global::System.Data.SQLite.UnsafeNativeMethods.xEof(this, ldftn(xEof))).Invoke),
				xColumn = new global::System.Data.SQLite.UnsafeNativeMethods.xColumn(((module.xColumn != null) ? module.xColumn : new global::System.Data.SQLite.UnsafeNativeMethods.xColumn(this, ldftn(xColumn))).Invoke),
				xRowId = new global::System.Data.SQLite.UnsafeNativeMethods.xRowId(((module.xRowId != null) ? module.xRowId : new global::System.Data.SQLite.UnsafeNativeMethods.xRowId(this, ldftn(xRowId))).Invoke),
				xUpdate = new global::System.Data.SQLite.UnsafeNativeMethods.xUpdate(((module.xUpdate != null) ? module.xUpdate : new global::System.Data.SQLite.UnsafeNativeMethods.xUpdate(this, ldftn(xUpdate))).Invoke),
				xBegin = new global::System.Data.SQLite.UnsafeNativeMethods.xBegin(((module.xBegin != null) ? module.xBegin : new global::System.Data.SQLite.UnsafeNativeMethods.xBegin(this, ldftn(xBegin))).Invoke),
				xSync = new global::System.Data.SQLite.UnsafeNativeMethods.xSync(((module.xSync != null) ? module.xSync : new global::System.Data.SQLite.UnsafeNativeMethods.xSync(this, ldftn(xSync))).Invoke),
				xCommit = new global::System.Data.SQLite.UnsafeNativeMethods.xCommit(((module.xCommit != null) ? module.xCommit : new global::System.Data.SQLite.UnsafeNativeMethods.xCommit(this, ldftn(xCommit))).Invoke),
				xRollback = new global::System.Data.SQLite.UnsafeNativeMethods.xRollback(((module.xRollback != null) ? module.xRollback : new global::System.Data.SQLite.UnsafeNativeMethods.xRollback(this, ldftn(xRollback))).Invoke),
				xFindFunction = new global::System.Data.SQLite.UnsafeNativeMethods.xFindFunction(((module.xFindFunction != null) ? module.xFindFunction : new global::System.Data.SQLite.UnsafeNativeMethods.xFindFunction(this, ldftn(xFindFunction))).Invoke),
				xRename = new global::System.Data.SQLite.UnsafeNativeMethods.xRename(((module.xRename != null) ? module.xRename : new global::System.Data.SQLite.UnsafeNativeMethods.xRename(this, ldftn(xRename))).Invoke),
				xSavepoint = new global::System.Data.SQLite.UnsafeNativeMethods.xSavepoint(((module.xSavepoint != null) ? module.xSavepoint : new global::System.Data.SQLite.UnsafeNativeMethods.xSavepoint(this, ldftn(xSavepoint))).Invoke),
				xRelease = new global::System.Data.SQLite.UnsafeNativeMethods.xRelease(((module.xRelease != null) ? module.xRelease : new global::System.Data.SQLite.UnsafeNativeMethods.xRelease(this, ldftn(xRelease))).Invoke),
				xRollbackTo = new global::System.Data.SQLite.UnsafeNativeMethods.xRollbackTo(((module.xRollbackTo != null) ? module.xRollbackTo : new global::System.Data.SQLite.UnsafeNativeMethods.xRollbackTo(this, ldftn(xRollbackTo))).Invoke)
			};
		}

		// Token: 0x06000573 RID: 1395 RVA: 0x00023028 File Offset: 0x00022428
		private global::System.Data.SQLite.SQLiteErrorCode CreateOrConnect(bool create, global::System.IntPtr pDb, global::System.IntPtr pAux, int argc, global::System.IntPtr argv, ref global::System.IntPtr pVtab, ref global::System.IntPtr pError)
		{
			try
			{
				string fileName = global::System.Data.SQLite.SQLiteString.StringFromUtf8IntPtr(global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_db_filename(pDb, global::System.IntPtr.Zero));
				using (global::System.Data.SQLite.SQLiteConnection sqliteConnection = new global::System.Data.SQLite.SQLiteConnection(pDb, fileName, false))
				{
					global::System.Data.SQLite.SQLiteVirtualTable sqliteVirtualTable = null;
					string value = null;
					if ((create && this.Create(sqliteConnection, pAux, global::System.Data.SQLite.SQLiteString.StringArrayFromUtf8SizeAndIntPtr(argc, argv), ref sqliteVirtualTable, ref value) == global::System.Data.SQLite.SQLiteErrorCode.Ok) || (!create && this.Connect(sqliteConnection, pAux, global::System.Data.SQLite.SQLiteString.StringArrayFromUtf8SizeAndIntPtr(argc, argv), ref sqliteVirtualTable, ref value) == global::System.Data.SQLite.SQLiteErrorCode.Ok))
					{
						if (sqliteVirtualTable != null)
						{
							pVtab = this.TableToIntPtr(sqliteVirtualTable);
							return global::System.Data.SQLite.SQLiteErrorCode.Ok;
						}
						pError = global::System.Data.SQLite.SQLiteString.Utf8IntPtrFromString("no table was created");
					}
					else
					{
						pError = global::System.Data.SQLite.SQLiteString.Utf8IntPtrFromString(value);
					}
				}
			}
			catch (global::System.Exception ex)
			{
				pError = global::System.Data.SQLite.SQLiteString.Utf8IntPtrFromString(ex.ToString());
			}
			return global::System.Data.SQLite.SQLiteErrorCode.Error;
		}

		// Token: 0x06000574 RID: 1396 RVA: 0x0002311C File Offset: 0x0002251C
		private global::System.Data.SQLite.SQLiteErrorCode DestroyOrDisconnect(bool destroy, global::System.IntPtr pVtab)
		{
			try
			{
				global::System.Data.SQLite.SQLiteVirtualTable sqliteVirtualTable = this.TableFromIntPtr(pVtab);
				if (sqliteVirtualTable != null && ((destroy && this.Destroy(sqliteVirtualTable) == global::System.Data.SQLite.SQLiteErrorCode.Ok) || (!destroy && this.Disconnect(sqliteVirtualTable) == global::System.Data.SQLite.SQLiteErrorCode.Ok)))
				{
					if (this.tables != null)
					{
						this.tables.Remove(pVtab);
					}
					return global::System.Data.SQLite.SQLiteErrorCode.Ok;
				}
			}
			catch (global::System.Exception ex)
			{
				try
				{
					if (this.LogExceptionsNoThrow)
					{
						global::System.Data.SQLite.SQLiteLog.LogMessage(-2146233088, string.Format(global::System.Globalization.CultureInfo.CurrentCulture, "Caught exception in \"{0}\" method: {1}", new object[]
						{
							destroy ? "xDestroy" : "xDisconnect",
							ex
						}));
					}
				}
				catch
				{
				}
			}
			finally
			{
				this.FreeTable(pVtab);
			}
			return global::System.Data.SQLite.SQLiteErrorCode.Error;
		}

		// Token: 0x06000575 RID: 1397 RVA: 0x00023208 File Offset: 0x00022608
		private static bool SetTableError(global::System.Data.SQLite.SQLiteModule module, global::System.IntPtr pVtab, bool logErrors, string error)
		{
			try
			{
				if (logErrors)
				{
					global::System.Data.SQLite.SQLiteLog.LogMessage(global::System.Data.SQLite.SQLiteErrorCode.Error, string.Format(global::System.Globalization.CultureInfo.CurrentCulture, "Virtual table error: {0}", new object[]
					{
						error
					}));
				}
			}
			catch
			{
			}
			if (pVtab == global::System.IntPtr.Zero)
			{
				return false;
			}
			int offset = 0;
			offset = global::System.Data.SQLite.SQLiteMarshal.NextOffsetOf(offset, global::System.IntPtr.Size, 4);
			offset = global::System.Data.SQLite.SQLiteMarshal.NextOffsetOf(offset, 4, global::System.IntPtr.Size);
			global::System.IntPtr intPtr = global::System.Data.SQLite.SQLiteMarshal.ReadIntPtr(pVtab, offset);
			if (intPtr != global::System.IntPtr.Zero)
			{
				global::System.Data.SQLite.SQLiteMemory.Free(intPtr);
				intPtr = global::System.IntPtr.Zero;
				global::System.Data.SQLite.SQLiteMarshal.WriteIntPtr(pVtab, offset, intPtr);
			}
			if (error == null)
			{
				return true;
			}
			bool flag = false;
			try
			{
				intPtr = global::System.Data.SQLite.SQLiteString.Utf8IntPtrFromString(error);
				global::System.Data.SQLite.SQLiteMarshal.WriteIntPtr(pVtab, offset, intPtr);
				flag = true;
			}
			finally
			{
				if (!flag && intPtr != global::System.IntPtr.Zero)
				{
					global::System.Data.SQLite.SQLiteMemory.Free(intPtr);
					intPtr = global::System.IntPtr.Zero;
				}
			}
			return flag;
		}

		// Token: 0x06000576 RID: 1398 RVA: 0x00023300 File Offset: 0x00022700
		private static bool SetTableError(global::System.Data.SQLite.SQLiteModule module, global::System.Data.SQLite.SQLiteVirtualTable table, bool logErrors, string error)
		{
			if (table == null)
			{
				return false;
			}
			global::System.IntPtr nativeHandle = table.NativeHandle;
			return !(nativeHandle == global::System.IntPtr.Zero) && global::System.Data.SQLite.SQLiteModule.SetTableError(module, nativeHandle, logErrors, error);
		}

		// Token: 0x06000577 RID: 1399 RVA: 0x00023334 File Offset: 0x00022734
		private static bool SetCursorError(global::System.Data.SQLite.SQLiteModule module, global::System.IntPtr pCursor, bool logErrors, string error)
		{
			if (pCursor == global::System.IntPtr.Zero)
			{
				return false;
			}
			global::System.IntPtr intPtr = global::System.Data.SQLite.SQLiteModule.TableFromCursor(module, pCursor);
			return !(intPtr == global::System.IntPtr.Zero) && global::System.Data.SQLite.SQLiteModule.SetTableError(module, intPtr, logErrors, error);
		}

		// Token: 0x06000578 RID: 1400 RVA: 0x00023370 File Offset: 0x00022770
		private static bool SetCursorError(global::System.Data.SQLite.SQLiteModule module, global::System.Data.SQLite.SQLiteVirtualTableCursor cursor, bool logErrors, string error)
		{
			if (cursor == null)
			{
				return false;
			}
			global::System.IntPtr nativeHandle = cursor.NativeHandle;
			return !(nativeHandle == global::System.IntPtr.Zero) && global::System.Data.SQLite.SQLiteModule.SetCursorError(module, nativeHandle, logErrors, error);
		}

		// Token: 0x06000579 RID: 1401 RVA: 0x000233A4 File Offset: 0x000227A4
		protected virtual global::System.Data.SQLite.ISQLiteNativeModule GetNativeModuleImpl()
		{
			return null;
		}

		// Token: 0x0600057A RID: 1402 RVA: 0x000233B4 File Offset: 0x000227B4
		protected virtual global::System.Data.SQLite.ISQLiteNativeModule CreateNativeModuleImpl()
		{
			return new global::System.Data.SQLite.SQLiteModule.SQLiteNativeModule(this);
		}

		// Token: 0x0600057B RID: 1403 RVA: 0x000233C8 File Offset: 0x000227C8
		protected virtual global::System.IntPtr AllocateTable()
		{
			int size = global::System.Runtime.InteropServices.Marshal.SizeOf(typeof(global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_vtab));
			return global::System.Data.SQLite.SQLiteMemory.Allocate(size);
		}

		// Token: 0x0600057C RID: 1404 RVA: 0x000233EC File Offset: 0x000227EC
		protected virtual void ZeroTable(global::System.IntPtr pVtab)
		{
			if (pVtab == global::System.IntPtr.Zero)
			{
				return;
			}
			int offset = 0;
			global::System.Data.SQLite.SQLiteMarshal.WriteIntPtr(pVtab, offset, global::System.IntPtr.Zero);
			offset = global::System.Data.SQLite.SQLiteMarshal.NextOffsetOf(offset, global::System.IntPtr.Size, 4);
			global::System.Data.SQLite.SQLiteMarshal.WriteInt32(pVtab, offset, 0);
			offset = global::System.Data.SQLite.SQLiteMarshal.NextOffsetOf(offset, 4, global::System.IntPtr.Size);
			global::System.Data.SQLite.SQLiteMarshal.WriteIntPtr(pVtab, offset, global::System.IntPtr.Zero);
		}

		// Token: 0x0600057D RID: 1405 RVA: 0x00023444 File Offset: 0x00022844
		protected virtual void FreeTable(global::System.IntPtr pVtab)
		{
			this.SetTableError(pVtab, null);
			global::System.Data.SQLite.SQLiteMemory.Free(pVtab);
		}

		// Token: 0x0600057E RID: 1406 RVA: 0x00023460 File Offset: 0x00022860
		protected virtual global::System.IntPtr AllocateCursor()
		{
			int size = global::System.Runtime.InteropServices.Marshal.SizeOf(typeof(global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_vtab_cursor));
			return global::System.Data.SQLite.SQLiteMemory.Allocate(size);
		}

		// Token: 0x0600057F RID: 1407 RVA: 0x00023484 File Offset: 0x00022884
		protected virtual void FreeCursor(global::System.IntPtr pCursor)
		{
			global::System.Data.SQLite.SQLiteMemory.Free(pCursor);
		}

		// Token: 0x06000580 RID: 1408 RVA: 0x00023498 File Offset: 0x00022898
		private static global::System.IntPtr TableFromCursor(global::System.Data.SQLite.SQLiteModule module, global::System.IntPtr pCursor)
		{
			if (pCursor == global::System.IntPtr.Zero)
			{
				return global::System.IntPtr.Zero;
			}
			return global::System.Runtime.InteropServices.Marshal.ReadIntPtr(pCursor);
		}

		// Token: 0x06000581 RID: 1409 RVA: 0x000234C0 File Offset: 0x000228C0
		protected virtual global::System.IntPtr TableFromCursor(global::System.IntPtr pCursor)
		{
			return global::System.Data.SQLite.SQLiteModule.TableFromCursor(this, pCursor);
		}

		// Token: 0x06000582 RID: 1410 RVA: 0x000234D4 File Offset: 0x000228D4
		protected virtual global::System.Data.SQLite.SQLiteVirtualTable TableFromIntPtr(global::System.IntPtr pVtab)
		{
			if (pVtab == global::System.IntPtr.Zero)
			{
				this.SetTableError(pVtab, "invalid native table");
				return null;
			}
			global::System.Data.SQLite.SQLiteVirtualTable result;
			if (this.tables != null && this.tables.TryGetValue(pVtab, out result))
			{
				return result;
			}
			this.SetTableError(pVtab, string.Format(global::System.Globalization.CultureInfo.CurrentCulture, "managed table for {0} not found", new object[]
			{
				pVtab
			}));
			return null;
		}

		// Token: 0x06000583 RID: 1411 RVA: 0x00023540 File Offset: 0x00022940
		protected virtual global::System.IntPtr TableToIntPtr(global::System.Data.SQLite.SQLiteVirtualTable table)
		{
			if (table == null || this.tables == null)
			{
				return global::System.IntPtr.Zero;
			}
			global::System.IntPtr intPtr = global::System.IntPtr.Zero;
			bool flag = false;
			try
			{
				intPtr = this.AllocateTable();
				if (intPtr != global::System.IntPtr.Zero)
				{
					this.ZeroTable(intPtr);
					table.NativeHandle = intPtr;
					this.tables.Add(intPtr, table);
					flag = true;
				}
			}
			finally
			{
				if (!flag && intPtr != global::System.IntPtr.Zero)
				{
					this.FreeTable(intPtr);
					intPtr = global::System.IntPtr.Zero;
				}
			}
			return intPtr;
		}

		// Token: 0x06000584 RID: 1412 RVA: 0x000235D4 File Offset: 0x000229D4
		protected virtual global::System.Data.SQLite.SQLiteVirtualTableCursor CursorFromIntPtr(global::System.IntPtr pVtab, global::System.IntPtr pCursor)
		{
			if (pCursor == global::System.IntPtr.Zero)
			{
				this.SetTableError(pVtab, "invalid native cursor");
				return null;
			}
			global::System.Data.SQLite.SQLiteVirtualTableCursor result;
			if (this.cursors != null && this.cursors.TryGetValue(pCursor, out result))
			{
				return result;
			}
			this.SetTableError(pVtab, string.Format(global::System.Globalization.CultureInfo.CurrentCulture, "managed cursor for {0} not found", new object[]
			{
				pCursor
			}));
			return null;
		}

		// Token: 0x06000585 RID: 1413 RVA: 0x00023640 File Offset: 0x00022A40
		protected virtual global::System.IntPtr CursorToIntPtr(global::System.Data.SQLite.SQLiteVirtualTableCursor cursor)
		{
			if (cursor == null || this.cursors == null)
			{
				return global::System.IntPtr.Zero;
			}
			global::System.IntPtr intPtr = global::System.IntPtr.Zero;
			bool flag = false;
			try
			{
				intPtr = this.AllocateCursor();
				if (intPtr != global::System.IntPtr.Zero)
				{
					cursor.NativeHandle = intPtr;
					this.cursors.Add(intPtr, cursor);
					flag = true;
				}
			}
			finally
			{
				if (!flag && intPtr != global::System.IntPtr.Zero)
				{
					this.FreeCursor(intPtr);
					intPtr = global::System.IntPtr.Zero;
				}
			}
			return intPtr;
		}

		// Token: 0x06000586 RID: 1414 RVA: 0x000236D0 File Offset: 0x00022AD0
		protected virtual string GetFunctionKey(int argumentCount, string name, global::System.Data.SQLite.SQLiteFunction function)
		{
			return string.Format("{0}:{1}", argumentCount, name);
		}

		// Token: 0x06000587 RID: 1415 RVA: 0x000236F0 File Offset: 0x00022AF0
		protected virtual global::System.Data.SQLite.SQLiteErrorCode DeclareTable(global::System.Data.SQLite.SQLiteConnection connection, string sql, ref string error)
		{
			if (connection == null)
			{
				error = "invalid connection";
				return global::System.Data.SQLite.SQLiteErrorCode.Error;
			}
			global::System.Data.SQLite.SQLiteBase sql2 = connection._sql;
			if (sql2 == null)
			{
				error = "connection has invalid handle";
				return global::System.Data.SQLite.SQLiteErrorCode.Error;
			}
			if (sql == null)
			{
				error = "invalid SQL statement";
				return global::System.Data.SQLite.SQLiteErrorCode.Error;
			}
			return sql2.DeclareVirtualTable(this, sql, ref error);
		}

		// Token: 0x06000588 RID: 1416 RVA: 0x00023734 File Offset: 0x00022B34
		protected virtual global::System.Data.SQLite.SQLiteErrorCode DeclareFunction(global::System.Data.SQLite.SQLiteConnection connection, int argumentCount, string name, ref string error)
		{
			if (connection == null)
			{
				error = "invalid connection";
				return global::System.Data.SQLite.SQLiteErrorCode.Error;
			}
			global::System.Data.SQLite.SQLiteBase sql = connection._sql;
			if (sql == null)
			{
				error = "connection has invalid handle";
				return global::System.Data.SQLite.SQLiteErrorCode.Error;
			}
			return sql.DeclareVirtualFunction(this, argumentCount, name, ref error);
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x06000589 RID: 1417 RVA: 0x00023770 File Offset: 0x00022B70
		// (set) Token: 0x0600058A RID: 1418 RVA: 0x00023784 File Offset: 0x00022B84
		protected virtual bool LogErrorsNoThrow
		{
			get
			{
				return this.logErrors;
			}
			set
			{
				this.logErrors = value;
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x0600058B RID: 1419 RVA: 0x00023798 File Offset: 0x00022B98
		// (set) Token: 0x0600058C RID: 1420 RVA: 0x000237AC File Offset: 0x00022BAC
		protected virtual bool LogExceptionsNoThrow
		{
			get
			{
				return this.logExceptions;
			}
			set
			{
				this.logExceptions = value;
			}
		}

		// Token: 0x0600058D RID: 1421 RVA: 0x000237C0 File Offset: 0x00022BC0
		protected virtual bool SetTableError(global::System.IntPtr pVtab, string error)
		{
			return global::System.Data.SQLite.SQLiteModule.SetTableError(this, pVtab, this.LogErrorsNoThrow, error);
		}

		// Token: 0x0600058E RID: 1422 RVA: 0x000237DC File Offset: 0x00022BDC
		protected virtual bool SetTableError(global::System.Data.SQLite.SQLiteVirtualTable table, string error)
		{
			return global::System.Data.SQLite.SQLiteModule.SetTableError(this, table, this.LogErrorsNoThrow, error);
		}

		// Token: 0x0600058F RID: 1423 RVA: 0x000237F8 File Offset: 0x00022BF8
		protected virtual bool SetCursorError(global::System.Data.SQLite.SQLiteVirtualTableCursor cursor, string error)
		{
			return global::System.Data.SQLite.SQLiteModule.SetCursorError(this, cursor, this.LogErrorsNoThrow, error);
		}

		// Token: 0x06000590 RID: 1424 RVA: 0x00023814 File Offset: 0x00022C14
		protected virtual bool SetEstimatedCost(global::System.Data.SQLite.SQLiteIndex index, double estimatedCost)
		{
			if (index == null || index.Outputs == null)
			{
				return false;
			}
			index.Outputs.EstimatedCost = new double?(estimatedCost);
			return true;
		}

		// Token: 0x06000591 RID: 1425 RVA: 0x00023840 File Offset: 0x00022C40
		protected virtual bool SetEstimatedCost(global::System.Data.SQLite.SQLiteIndex index)
		{
			return this.SetEstimatedCost(index, global::System.Data.SQLite.SQLiteIndex.DefaultEstimatedCost);
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x06000592 RID: 1426 RVA: 0x0002385C File Offset: 0x00022C5C
		// (set) Token: 0x06000593 RID: 1427 RVA: 0x00023878 File Offset: 0x00022C78
		public virtual bool LogErrors
		{
			get
			{
				this.CheckDisposed();
				return this.LogErrorsNoThrow;
			}
			set
			{
				this.CheckDisposed();
				this.LogErrorsNoThrow = value;
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x06000594 RID: 1428 RVA: 0x00023894 File Offset: 0x00022C94
		// (set) Token: 0x06000595 RID: 1429 RVA: 0x000238B0 File Offset: 0x00022CB0
		public virtual bool LogExceptions
		{
			get
			{
				this.CheckDisposed();
				return this.LogExceptionsNoThrow;
			}
			set
			{
				this.CheckDisposed();
				this.LogExceptionsNoThrow = value;
			}
		}

		// Token: 0x06000596 RID: 1430 RVA: 0x000238CC File Offset: 0x00022CCC
		private global::System.Data.SQLite.SQLiteErrorCode xCreate(global::System.IntPtr pDb, global::System.IntPtr pAux, int argc, global::System.IntPtr argv, ref global::System.IntPtr pVtab, ref global::System.IntPtr pError)
		{
			return this.CreateOrConnect(true, pDb, pAux, argc, argv, ref pVtab, ref pError);
		}

		// Token: 0x06000597 RID: 1431 RVA: 0x000238EC File Offset: 0x00022CEC
		private global::System.Data.SQLite.SQLiteErrorCode xConnect(global::System.IntPtr pDb, global::System.IntPtr pAux, int argc, global::System.IntPtr argv, ref global::System.IntPtr pVtab, ref global::System.IntPtr pError)
		{
			return this.CreateOrConnect(false, pDb, pAux, argc, argv, ref pVtab, ref pError);
		}

		// Token: 0x06000598 RID: 1432 RVA: 0x0002390C File Offset: 0x00022D0C
		private global::System.Data.SQLite.SQLiteErrorCode xBestIndex(global::System.IntPtr pVtab, global::System.IntPtr pIndex)
		{
			try
			{
				global::System.Data.SQLite.SQLiteVirtualTable sqliteVirtualTable = this.TableFromIntPtr(pVtab);
				if (sqliteVirtualTable != null)
				{
					global::System.Data.SQLite.SQLiteIndex index = null;
					global::System.Data.SQLite.SQLiteIndex.FromIntPtr(pIndex, ref index);
					if (this.BestIndex(sqliteVirtualTable, index) == global::System.Data.SQLite.SQLiteErrorCode.Ok)
					{
						global::System.Data.SQLite.SQLiteIndex.ToIntPtr(index, pIndex);
						return global::System.Data.SQLite.SQLiteErrorCode.Ok;
					}
				}
			}
			catch (global::System.Exception ex)
			{
				this.SetTableError(pVtab, ex.ToString());
			}
			return global::System.Data.SQLite.SQLiteErrorCode.Error;
		}

		// Token: 0x06000599 RID: 1433 RVA: 0x00023978 File Offset: 0x00022D78
		private global::System.Data.SQLite.SQLiteErrorCode xDisconnect(global::System.IntPtr pVtab)
		{
			return this.DestroyOrDisconnect(false, pVtab);
		}

		// Token: 0x0600059A RID: 1434 RVA: 0x00023990 File Offset: 0x00022D90
		private global::System.Data.SQLite.SQLiteErrorCode xDestroy(global::System.IntPtr pVtab)
		{
			return this.DestroyOrDisconnect(true, pVtab);
		}

		// Token: 0x0600059B RID: 1435 RVA: 0x000239A8 File Offset: 0x00022DA8
		private global::System.Data.SQLite.SQLiteErrorCode xOpen(global::System.IntPtr pVtab, ref global::System.IntPtr pCursor)
		{
			try
			{
				global::System.Data.SQLite.SQLiteVirtualTable sqliteVirtualTable = this.TableFromIntPtr(pVtab);
				if (sqliteVirtualTable != null)
				{
					global::System.Data.SQLite.SQLiteVirtualTableCursor sqliteVirtualTableCursor = null;
					if (this.Open(sqliteVirtualTable, ref sqliteVirtualTableCursor) == global::System.Data.SQLite.SQLiteErrorCode.Ok)
					{
						if (sqliteVirtualTableCursor != null)
						{
							pCursor = this.CursorToIntPtr(sqliteVirtualTableCursor);
							if (pCursor != global::System.IntPtr.Zero)
							{
								return global::System.Data.SQLite.SQLiteErrorCode.Ok;
							}
							this.SetTableError(pVtab, "no native cursor was created");
						}
						else
						{
							this.SetTableError(pVtab, "no managed cursor was created");
						}
					}
				}
			}
			catch (global::System.Exception ex)
			{
				this.SetTableError(pVtab, ex.ToString());
			}
			return global::System.Data.SQLite.SQLiteErrorCode.Error;
		}

		// Token: 0x0600059C RID: 1436 RVA: 0x00023A44 File Offset: 0x00022E44
		private global::System.Data.SQLite.SQLiteErrorCode xClose(global::System.IntPtr pCursor)
		{
			global::System.IntPtr pVtab = global::System.IntPtr.Zero;
			try
			{
				pVtab = this.TableFromCursor(pCursor);
				global::System.Data.SQLite.SQLiteVirtualTableCursor sqliteVirtualTableCursor = this.CursorFromIntPtr(pVtab, pCursor);
				if (sqliteVirtualTableCursor != null && this.Close(sqliteVirtualTableCursor) == global::System.Data.SQLite.SQLiteErrorCode.Ok)
				{
					if (this.cursors != null)
					{
						this.cursors.Remove(pCursor);
					}
					return global::System.Data.SQLite.SQLiteErrorCode.Ok;
				}
			}
			catch (global::System.Exception ex)
			{
				this.SetTableError(pVtab, ex.ToString());
			}
			finally
			{
				this.FreeCursor(pCursor);
			}
			return global::System.Data.SQLite.SQLiteErrorCode.Error;
		}

		// Token: 0x0600059D RID: 1437 RVA: 0x00023AE4 File Offset: 0x00022EE4
		private global::System.Data.SQLite.SQLiteErrorCode xFilter(global::System.IntPtr pCursor, int idxNum, global::System.IntPtr idxStr, int argc, global::System.IntPtr argv)
		{
			global::System.IntPtr pVtab = global::System.IntPtr.Zero;
			try
			{
				pVtab = this.TableFromCursor(pCursor);
				global::System.Data.SQLite.SQLiteVirtualTableCursor sqliteVirtualTableCursor = this.CursorFromIntPtr(pVtab, pCursor);
				if (sqliteVirtualTableCursor != null && this.Filter(sqliteVirtualTableCursor, idxNum, global::System.Data.SQLite.SQLiteString.StringFromUtf8IntPtr(idxStr), global::System.Data.SQLite.SQLiteValue.ArrayFromSizeAndIntPtr(argc, argv)) == global::System.Data.SQLite.SQLiteErrorCode.Ok)
				{
					return global::System.Data.SQLite.SQLiteErrorCode.Ok;
				}
			}
			catch (global::System.Exception ex)
			{
				this.SetTableError(pVtab, ex.ToString());
			}
			return global::System.Data.SQLite.SQLiteErrorCode.Error;
		}

		// Token: 0x0600059E RID: 1438 RVA: 0x00023B5C File Offset: 0x00022F5C
		private global::System.Data.SQLite.SQLiteErrorCode xNext(global::System.IntPtr pCursor)
		{
			global::System.IntPtr pVtab = global::System.IntPtr.Zero;
			try
			{
				pVtab = this.TableFromCursor(pCursor);
				global::System.Data.SQLite.SQLiteVirtualTableCursor sqliteVirtualTableCursor = this.CursorFromIntPtr(pVtab, pCursor);
				if (sqliteVirtualTableCursor != null && this.Next(sqliteVirtualTableCursor) == global::System.Data.SQLite.SQLiteErrorCode.Ok)
				{
					return global::System.Data.SQLite.SQLiteErrorCode.Ok;
				}
			}
			catch (global::System.Exception ex)
			{
				this.SetTableError(pVtab, ex.ToString());
			}
			return global::System.Data.SQLite.SQLiteErrorCode.Error;
		}

		// Token: 0x0600059F RID: 1439 RVA: 0x00023BC4 File Offset: 0x00022FC4
		private int xEof(global::System.IntPtr pCursor)
		{
			global::System.IntPtr pVtab = global::System.IntPtr.Zero;
			try
			{
				pVtab = this.TableFromCursor(pCursor);
				global::System.Data.SQLite.SQLiteVirtualTableCursor sqliteVirtualTableCursor = this.CursorFromIntPtr(pVtab, pCursor);
				if (sqliteVirtualTableCursor != null)
				{
					return this.Eof(sqliteVirtualTableCursor) ? 1 : 0;
				}
			}
			catch (global::System.Exception ex)
			{
				this.SetTableError(pVtab, ex.ToString());
			}
			return 1;
		}

		// Token: 0x060005A0 RID: 1440 RVA: 0x00023C30 File Offset: 0x00023030
		private global::System.Data.SQLite.SQLiteErrorCode xColumn(global::System.IntPtr pCursor, global::System.IntPtr pContext, int index)
		{
			global::System.IntPtr pVtab = global::System.IntPtr.Zero;
			try
			{
				pVtab = this.TableFromCursor(pCursor);
				global::System.Data.SQLite.SQLiteVirtualTableCursor sqliteVirtualTableCursor = this.CursorFromIntPtr(pVtab, pCursor);
				if (sqliteVirtualTableCursor != null)
				{
					global::System.Data.SQLite.SQLiteContext context = new global::System.Data.SQLite.SQLiteContext(pContext);
					return this.Column(sqliteVirtualTableCursor, context, index);
				}
			}
			catch (global::System.Exception ex)
			{
				this.SetTableError(pVtab, ex.ToString());
			}
			return global::System.Data.SQLite.SQLiteErrorCode.Error;
		}

		// Token: 0x060005A1 RID: 1441 RVA: 0x00023CA0 File Offset: 0x000230A0
		private global::System.Data.SQLite.SQLiteErrorCode xRowId(global::System.IntPtr pCursor, ref long rowId)
		{
			global::System.IntPtr pVtab = global::System.IntPtr.Zero;
			try
			{
				pVtab = this.TableFromCursor(pCursor);
				global::System.Data.SQLite.SQLiteVirtualTableCursor sqliteVirtualTableCursor = this.CursorFromIntPtr(pVtab, pCursor);
				if (sqliteVirtualTableCursor != null)
				{
					return this.RowId(sqliteVirtualTableCursor, ref rowId);
				}
			}
			catch (global::System.Exception ex)
			{
				this.SetTableError(pVtab, ex.ToString());
			}
			return global::System.Data.SQLite.SQLiteErrorCode.Error;
		}

		// Token: 0x060005A2 RID: 1442 RVA: 0x00023D04 File Offset: 0x00023104
		private global::System.Data.SQLite.SQLiteErrorCode xUpdate(global::System.IntPtr pVtab, int argc, global::System.IntPtr argv, ref long rowId)
		{
			try
			{
				global::System.Data.SQLite.SQLiteVirtualTable sqliteVirtualTable = this.TableFromIntPtr(pVtab);
				if (sqliteVirtualTable != null)
				{
					return this.Update(sqliteVirtualTable, global::System.Data.SQLite.SQLiteValue.ArrayFromSizeAndIntPtr(argc, argv), ref rowId);
				}
			}
			catch (global::System.Exception ex)
			{
				this.SetTableError(pVtab, ex.ToString());
			}
			return global::System.Data.SQLite.SQLiteErrorCode.Error;
		}

		// Token: 0x060005A3 RID: 1443 RVA: 0x00023D64 File Offset: 0x00023164
		private global::System.Data.SQLite.SQLiteErrorCode xBegin(global::System.IntPtr pVtab)
		{
			try
			{
				global::System.Data.SQLite.SQLiteVirtualTable sqliteVirtualTable = this.TableFromIntPtr(pVtab);
				if (sqliteVirtualTable != null)
				{
					return this.Begin(sqliteVirtualTable);
				}
			}
			catch (global::System.Exception ex)
			{
				this.SetTableError(pVtab, ex.ToString());
			}
			return global::System.Data.SQLite.SQLiteErrorCode.Error;
		}

		// Token: 0x060005A4 RID: 1444 RVA: 0x00023DB8 File Offset: 0x000231B8
		private global::System.Data.SQLite.SQLiteErrorCode xSync(global::System.IntPtr pVtab)
		{
			try
			{
				global::System.Data.SQLite.SQLiteVirtualTable sqliteVirtualTable = this.TableFromIntPtr(pVtab);
				if (sqliteVirtualTable != null)
				{
					return this.Sync(sqliteVirtualTable);
				}
			}
			catch (global::System.Exception ex)
			{
				this.SetTableError(pVtab, ex.ToString());
			}
			return global::System.Data.SQLite.SQLiteErrorCode.Error;
		}

		// Token: 0x060005A5 RID: 1445 RVA: 0x00023E0C File Offset: 0x0002320C
		private global::System.Data.SQLite.SQLiteErrorCode xCommit(global::System.IntPtr pVtab)
		{
			try
			{
				global::System.Data.SQLite.SQLiteVirtualTable sqliteVirtualTable = this.TableFromIntPtr(pVtab);
				if (sqliteVirtualTable != null)
				{
					return this.Commit(sqliteVirtualTable);
				}
			}
			catch (global::System.Exception ex)
			{
				this.SetTableError(pVtab, ex.ToString());
			}
			return global::System.Data.SQLite.SQLiteErrorCode.Error;
		}

		// Token: 0x060005A6 RID: 1446 RVA: 0x00023E60 File Offset: 0x00023260
		private global::System.Data.SQLite.SQLiteErrorCode xRollback(global::System.IntPtr pVtab)
		{
			try
			{
				global::System.Data.SQLite.SQLiteVirtualTable sqliteVirtualTable = this.TableFromIntPtr(pVtab);
				if (sqliteVirtualTable != null)
				{
					return this.Rollback(sqliteVirtualTable);
				}
			}
			catch (global::System.Exception ex)
			{
				this.SetTableError(pVtab, ex.ToString());
			}
			return global::System.Data.SQLite.SQLiteErrorCode.Error;
		}

		// Token: 0x060005A7 RID: 1447 RVA: 0x00023EB4 File Offset: 0x000232B4
		private int xFindFunction(global::System.IntPtr pVtab, int nArg, global::System.IntPtr zName, ref global::System.Data.SQLite.SQLiteCallback callback, ref global::System.IntPtr pClientData)
		{
			try
			{
				global::System.Data.SQLite.SQLiteVirtualTable sqliteVirtualTable = this.TableFromIntPtr(pVtab);
				if (sqliteVirtualTable != null)
				{
					string text = global::System.Data.SQLite.SQLiteString.StringFromUtf8IntPtr(zName);
					global::System.Data.SQLite.SQLiteFunction sqliteFunction = null;
					if (this.FindFunction(sqliteVirtualTable, nArg, text, ref sqliteFunction, ref pClientData))
					{
						if (sqliteFunction != null)
						{
							string functionKey = this.GetFunctionKey(nArg, text, sqliteFunction);
							this.functions[functionKey] = sqliteFunction;
							callback = new global::System.Data.SQLite.SQLiteCallback(sqliteFunction.ScalarCallback);
							return 1;
						}
						this.SetTableError(pVtab, "no function was created");
					}
				}
			}
			catch (global::System.Exception ex)
			{
				this.SetTableError(pVtab, ex.ToString());
			}
			return 0;
		}

		// Token: 0x060005A8 RID: 1448 RVA: 0x00023F54 File Offset: 0x00023354
		private global::System.Data.SQLite.SQLiteErrorCode xRename(global::System.IntPtr pVtab, global::System.IntPtr zNew)
		{
			try
			{
				global::System.Data.SQLite.SQLiteVirtualTable sqliteVirtualTable = this.TableFromIntPtr(pVtab);
				if (sqliteVirtualTable != null)
				{
					return this.Rename(sqliteVirtualTable, global::System.Data.SQLite.SQLiteString.StringFromUtf8IntPtr(zNew));
				}
			}
			catch (global::System.Exception ex)
			{
				this.SetTableError(pVtab, ex.ToString());
			}
			return global::System.Data.SQLite.SQLiteErrorCode.Error;
		}

		// Token: 0x060005A9 RID: 1449 RVA: 0x00023FB0 File Offset: 0x000233B0
		private global::System.Data.SQLite.SQLiteErrorCode xSavepoint(global::System.IntPtr pVtab, int iSavepoint)
		{
			try
			{
				global::System.Data.SQLite.SQLiteVirtualTable sqliteVirtualTable = this.TableFromIntPtr(pVtab);
				if (sqliteVirtualTable != null)
				{
					return this.Savepoint(sqliteVirtualTable, iSavepoint);
				}
			}
			catch (global::System.Exception ex)
			{
				this.SetTableError(pVtab, ex.ToString());
			}
			return global::System.Data.SQLite.SQLiteErrorCode.Error;
		}

		// Token: 0x060005AA RID: 1450 RVA: 0x00024008 File Offset: 0x00023408
		private global::System.Data.SQLite.SQLiteErrorCode xRelease(global::System.IntPtr pVtab, int iSavepoint)
		{
			try
			{
				global::System.Data.SQLite.SQLiteVirtualTable sqliteVirtualTable = this.TableFromIntPtr(pVtab);
				if (sqliteVirtualTable != null)
				{
					return this.Release(sqliteVirtualTable, iSavepoint);
				}
			}
			catch (global::System.Exception ex)
			{
				this.SetTableError(pVtab, ex.ToString());
			}
			return global::System.Data.SQLite.SQLiteErrorCode.Error;
		}

		// Token: 0x060005AB RID: 1451 RVA: 0x00024060 File Offset: 0x00023460
		private global::System.Data.SQLite.SQLiteErrorCode xRollbackTo(global::System.IntPtr pVtab, int iSavepoint)
		{
			try
			{
				global::System.Data.SQLite.SQLiteVirtualTable sqliteVirtualTable = this.TableFromIntPtr(pVtab);
				if (sqliteVirtualTable != null)
				{
					return this.RollbackTo(sqliteVirtualTable, iSavepoint);
				}
			}
			catch (global::System.Exception ex)
			{
				this.SetTableError(pVtab, ex.ToString());
			}
			return global::System.Data.SQLite.SQLiteErrorCode.Error;
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x060005AC RID: 1452 RVA: 0x000240B8 File Offset: 0x000234B8
		// (set) Token: 0x060005AD RID: 1453 RVA: 0x000240D4 File Offset: 0x000234D4
		public virtual bool Declared
		{
			get
			{
				this.CheckDisposed();
				return this.declared;
			}
			internal set
			{
				this.declared = value;
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x060005AE RID: 1454 RVA: 0x000240E8 File Offset: 0x000234E8
		public virtual string Name
		{
			get
			{
				this.CheckDisposed();
				return this.name;
			}
		}

		// Token: 0x060005AF RID: 1455
		public abstract global::System.Data.SQLite.SQLiteErrorCode Create(global::System.Data.SQLite.SQLiteConnection connection, global::System.IntPtr pClientData, string[] arguments, ref global::System.Data.SQLite.SQLiteVirtualTable table, ref string error);

		// Token: 0x060005B0 RID: 1456
		public abstract global::System.Data.SQLite.SQLiteErrorCode Connect(global::System.Data.SQLite.SQLiteConnection connection, global::System.IntPtr pClientData, string[] arguments, ref global::System.Data.SQLite.SQLiteVirtualTable table, ref string error);

		// Token: 0x060005B1 RID: 1457
		public abstract global::System.Data.SQLite.SQLiteErrorCode BestIndex(global::System.Data.SQLite.SQLiteVirtualTable table, global::System.Data.SQLite.SQLiteIndex index);

		// Token: 0x060005B2 RID: 1458
		public abstract global::System.Data.SQLite.SQLiteErrorCode Disconnect(global::System.Data.SQLite.SQLiteVirtualTable table);

		// Token: 0x060005B3 RID: 1459
		public abstract global::System.Data.SQLite.SQLiteErrorCode Destroy(global::System.Data.SQLite.SQLiteVirtualTable table);

		// Token: 0x060005B4 RID: 1460
		public abstract global::System.Data.SQLite.SQLiteErrorCode Open(global::System.Data.SQLite.SQLiteVirtualTable table, ref global::System.Data.SQLite.SQLiteVirtualTableCursor cursor);

		// Token: 0x060005B5 RID: 1461
		public abstract global::System.Data.SQLite.SQLiteErrorCode Close(global::System.Data.SQLite.SQLiteVirtualTableCursor cursor);

		// Token: 0x060005B6 RID: 1462
		public abstract global::System.Data.SQLite.SQLiteErrorCode Filter(global::System.Data.SQLite.SQLiteVirtualTableCursor cursor, int indexNumber, string indexString, global::System.Data.SQLite.SQLiteValue[] values);

		// Token: 0x060005B7 RID: 1463
		public abstract global::System.Data.SQLite.SQLiteErrorCode Next(global::System.Data.SQLite.SQLiteVirtualTableCursor cursor);

		// Token: 0x060005B8 RID: 1464
		public abstract bool Eof(global::System.Data.SQLite.SQLiteVirtualTableCursor cursor);

		// Token: 0x060005B9 RID: 1465
		public abstract global::System.Data.SQLite.SQLiteErrorCode Column(global::System.Data.SQLite.SQLiteVirtualTableCursor cursor, global::System.Data.SQLite.SQLiteContext context, int index);

		// Token: 0x060005BA RID: 1466
		public abstract global::System.Data.SQLite.SQLiteErrorCode RowId(global::System.Data.SQLite.SQLiteVirtualTableCursor cursor, ref long rowId);

		// Token: 0x060005BB RID: 1467
		public abstract global::System.Data.SQLite.SQLiteErrorCode Update(global::System.Data.SQLite.SQLiteVirtualTable table, global::System.Data.SQLite.SQLiteValue[] values, ref long rowId);

		// Token: 0x060005BC RID: 1468
		public abstract global::System.Data.SQLite.SQLiteErrorCode Begin(global::System.Data.SQLite.SQLiteVirtualTable table);

		// Token: 0x060005BD RID: 1469
		public abstract global::System.Data.SQLite.SQLiteErrorCode Sync(global::System.Data.SQLite.SQLiteVirtualTable table);

		// Token: 0x060005BE RID: 1470
		public abstract global::System.Data.SQLite.SQLiteErrorCode Commit(global::System.Data.SQLite.SQLiteVirtualTable table);

		// Token: 0x060005BF RID: 1471
		public abstract global::System.Data.SQLite.SQLiteErrorCode Rollback(global::System.Data.SQLite.SQLiteVirtualTable table);

		// Token: 0x060005C0 RID: 1472
		public abstract bool FindFunction(global::System.Data.SQLite.SQLiteVirtualTable table, int argumentCount, string name, ref global::System.Data.SQLite.SQLiteFunction function, ref global::System.IntPtr pClientData);

		// Token: 0x060005C1 RID: 1473
		public abstract global::System.Data.SQLite.SQLiteErrorCode Rename(global::System.Data.SQLite.SQLiteVirtualTable table, string newName);

		// Token: 0x060005C2 RID: 1474
		public abstract global::System.Data.SQLite.SQLiteErrorCode Savepoint(global::System.Data.SQLite.SQLiteVirtualTable table, int savepoint);

		// Token: 0x060005C3 RID: 1475
		public abstract global::System.Data.SQLite.SQLiteErrorCode Release(global::System.Data.SQLite.SQLiteVirtualTable table, int savepoint);

		// Token: 0x060005C4 RID: 1476
		public abstract global::System.Data.SQLite.SQLiteErrorCode RollbackTo(global::System.Data.SQLite.SQLiteVirtualTable table, int savepoint);

		// Token: 0x060005C5 RID: 1477 RVA: 0x00024104 File Offset: 0x00023504
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x060005C6 RID: 1478 RVA: 0x00024120 File Offset: 0x00023520
		private void CheckDisposed()
		{
			if (this.disposed)
			{
				throw new global::System.ObjectDisposedException(typeof(global::System.Data.SQLite.SQLiteModule).Name);
			}
		}

		// Token: 0x060005C7 RID: 1479 RVA: 0x0002414C File Offset: 0x0002354C
		protected virtual void Dispose(bool disposing)
		{
			if (!this.disposed)
			{
				if (disposing && this.functions != null)
				{
					this.functions.Clear();
				}
				try
				{
					if (this.disposableModule != global::System.IntPtr.Zero)
					{
						global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_dispose_module(this.disposableModule);
						this.disposableModule = global::System.IntPtr.Zero;
					}
				}
				catch (global::System.Exception ex)
				{
					try
					{
						if (this.LogExceptionsNoThrow)
						{
							global::System.Data.SQLite.SQLiteLog.LogMessage(-2146233088, string.Format(global::System.Globalization.CultureInfo.CurrentCulture, "Caught exception in \"Dispose\" method: {0}", new object[]
							{
								ex
							}));
						}
					}
					catch
					{
					}
				}
				this.disposed = true;
			}
		}

		// Token: 0x060005C8 RID: 1480 RVA: 0x00024218 File Offset: 0x00023618
		~SQLiteModule()
		{
			this.Dispose(false);
		}

		// Token: 0x04000225 RID: 549
		private static readonly int DefaultModuleVersion = 2;

		// Token: 0x04000226 RID: 550
		private global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_module nativeModule;

		// Token: 0x04000227 RID: 551
		private global::System.Data.SQLite.UnsafeNativeMethods.xDestroyModule destroyModule;

		// Token: 0x04000228 RID: 552
		private global::System.IntPtr disposableModule;

		// Token: 0x04000229 RID: 553
		private global::System.Collections.Generic.Dictionary<global::System.IntPtr, global::System.Data.SQLite.SQLiteVirtualTable> tables;

		// Token: 0x0400022A RID: 554
		private global::System.Collections.Generic.Dictionary<global::System.IntPtr, global::System.Data.SQLite.SQLiteVirtualTableCursor> cursors;

		// Token: 0x0400022B RID: 555
		private global::System.Collections.Generic.Dictionary<string, global::System.Data.SQLite.SQLiteFunction> functions;

		// Token: 0x0400022C RID: 556
		private bool logErrors;

		// Token: 0x0400022D RID: 557
		private bool logExceptions;

		// Token: 0x0400022E RID: 558
		private bool declared;

		// Token: 0x0400022F RID: 559
		private string name;

		// Token: 0x04000230 RID: 560
		private bool disposed;

		// Token: 0x02000087 RID: 135
		private sealed class SQLiteNativeModule : global::System.Data.SQLite.ISQLiteNativeModule, global::System.IDisposable
		{
			// Token: 0x060005CA RID: 1482 RVA: 0x00024268 File Offset: 0x00023668
			public SQLiteNativeModule(global::System.Data.SQLite.SQLiteModule module)
			{
				this.module = module;
			}

			// Token: 0x060005CB RID: 1483 RVA: 0x00024284 File Offset: 0x00023684
			private static global::System.Data.SQLite.SQLiteErrorCode ModuleNotAvailableTableError(global::System.IntPtr pVtab)
			{
				global::System.Data.SQLite.SQLiteModule.SetTableError(null, pVtab, true, "native module implementation not available");
				return global::System.Data.SQLite.SQLiteErrorCode.Error;
			}

			// Token: 0x060005CC RID: 1484 RVA: 0x000242A0 File Offset: 0x000236A0
			private static global::System.Data.SQLite.SQLiteErrorCode ModuleNotAvailableCursorError(global::System.IntPtr pCursor)
			{
				global::System.Data.SQLite.SQLiteModule.SetCursorError(null, pCursor, true, "native module implementation not available");
				return global::System.Data.SQLite.SQLiteErrorCode.Error;
			}

			// Token: 0x060005CD RID: 1485 RVA: 0x000242BC File Offset: 0x000236BC
			public global::System.Data.SQLite.SQLiteErrorCode xCreate(global::System.IntPtr pDb, global::System.IntPtr pAux, int argc, global::System.IntPtr argv, ref global::System.IntPtr pVtab, ref global::System.IntPtr pError)
			{
				if (this.module == null)
				{
					pError = global::System.Data.SQLite.SQLiteString.Utf8IntPtrFromString("native module implementation not available");
					return global::System.Data.SQLite.SQLiteErrorCode.Error;
				}
				return this.module.xCreate(pDb, pAux, argc, argv, ref pVtab, ref pError);
			}

			// Token: 0x060005CE RID: 1486 RVA: 0x000242F8 File Offset: 0x000236F8
			public global::System.Data.SQLite.SQLiteErrorCode xConnect(global::System.IntPtr pDb, global::System.IntPtr pAux, int argc, global::System.IntPtr argv, ref global::System.IntPtr pVtab, ref global::System.IntPtr pError)
			{
				if (this.module == null)
				{
					pError = global::System.Data.SQLite.SQLiteString.Utf8IntPtrFromString("native module implementation not available");
					return global::System.Data.SQLite.SQLiteErrorCode.Error;
				}
				return this.module.xConnect(pDb, pAux, argc, argv, ref pVtab, ref pError);
			}

			// Token: 0x060005CF RID: 1487 RVA: 0x00024334 File Offset: 0x00023734
			public global::System.Data.SQLite.SQLiteErrorCode xBestIndex(global::System.IntPtr pVtab, global::System.IntPtr pIndex)
			{
				if (this.module == null)
				{
					return global::System.Data.SQLite.SQLiteModule.SQLiteNativeModule.ModuleNotAvailableTableError(pVtab);
				}
				return this.module.xBestIndex(pVtab, pIndex);
			}

			// Token: 0x060005D0 RID: 1488 RVA: 0x00024360 File Offset: 0x00023760
			public global::System.Data.SQLite.SQLiteErrorCode xDisconnect(global::System.IntPtr pVtab)
			{
				if (this.module == null)
				{
					return global::System.Data.SQLite.SQLiteModule.SQLiteNativeModule.ModuleNotAvailableTableError(pVtab);
				}
				return this.module.xDisconnect(pVtab);
			}

			// Token: 0x060005D1 RID: 1489 RVA: 0x00024388 File Offset: 0x00023788
			public global::System.Data.SQLite.SQLiteErrorCode xDestroy(global::System.IntPtr pVtab)
			{
				if (this.module == null)
				{
					return global::System.Data.SQLite.SQLiteModule.SQLiteNativeModule.ModuleNotAvailableTableError(pVtab);
				}
				return this.module.xDestroy(pVtab);
			}

			// Token: 0x060005D2 RID: 1490 RVA: 0x000243B0 File Offset: 0x000237B0
			public global::System.Data.SQLite.SQLiteErrorCode xOpen(global::System.IntPtr pVtab, ref global::System.IntPtr pCursor)
			{
				if (this.module == null)
				{
					return global::System.Data.SQLite.SQLiteModule.SQLiteNativeModule.ModuleNotAvailableTableError(pVtab);
				}
				return this.module.xOpen(pVtab, ref pCursor);
			}

			// Token: 0x060005D3 RID: 1491 RVA: 0x000243DC File Offset: 0x000237DC
			public global::System.Data.SQLite.SQLiteErrorCode xClose(global::System.IntPtr pCursor)
			{
				if (this.module == null)
				{
					return global::System.Data.SQLite.SQLiteModule.SQLiteNativeModule.ModuleNotAvailableCursorError(pCursor);
				}
				return this.module.xClose(pCursor);
			}

			// Token: 0x060005D4 RID: 1492 RVA: 0x00024404 File Offset: 0x00023804
			public global::System.Data.SQLite.SQLiteErrorCode xFilter(global::System.IntPtr pCursor, int idxNum, global::System.IntPtr idxStr, int argc, global::System.IntPtr argv)
			{
				if (this.module == null)
				{
					return global::System.Data.SQLite.SQLiteModule.SQLiteNativeModule.ModuleNotAvailableCursorError(pCursor);
				}
				return this.module.xFilter(pCursor, idxNum, idxStr, argc, argv);
			}

			// Token: 0x060005D5 RID: 1493 RVA: 0x00024434 File Offset: 0x00023834
			public global::System.Data.SQLite.SQLiteErrorCode xNext(global::System.IntPtr pCursor)
			{
				if (this.module == null)
				{
					return global::System.Data.SQLite.SQLiteModule.SQLiteNativeModule.ModuleNotAvailableCursorError(pCursor);
				}
				return this.module.xNext(pCursor);
			}

			// Token: 0x060005D6 RID: 1494 RVA: 0x0002445C File Offset: 0x0002385C
			public int xEof(global::System.IntPtr pCursor)
			{
				if (this.module == null)
				{
					global::System.Data.SQLite.SQLiteModule.SQLiteNativeModule.ModuleNotAvailableCursorError(pCursor);
					return 1;
				}
				return this.module.xEof(pCursor);
			}

			// Token: 0x060005D7 RID: 1495 RVA: 0x00024488 File Offset: 0x00023888
			public global::System.Data.SQLite.SQLiteErrorCode xColumn(global::System.IntPtr pCursor, global::System.IntPtr pContext, int index)
			{
				if (this.module == null)
				{
					return global::System.Data.SQLite.SQLiteModule.SQLiteNativeModule.ModuleNotAvailableCursorError(pCursor);
				}
				return this.module.xColumn(pCursor, pContext, index);
			}

			// Token: 0x060005D8 RID: 1496 RVA: 0x000244B4 File Offset: 0x000238B4
			public global::System.Data.SQLite.SQLiteErrorCode xRowId(global::System.IntPtr pCursor, ref long rowId)
			{
				if (this.module == null)
				{
					return global::System.Data.SQLite.SQLiteModule.SQLiteNativeModule.ModuleNotAvailableCursorError(pCursor);
				}
				return this.module.xRowId(pCursor, ref rowId);
			}

			// Token: 0x060005D9 RID: 1497 RVA: 0x000244E0 File Offset: 0x000238E0
			public global::System.Data.SQLite.SQLiteErrorCode xUpdate(global::System.IntPtr pVtab, int argc, global::System.IntPtr argv, ref long rowId)
			{
				if (this.module == null)
				{
					return global::System.Data.SQLite.SQLiteModule.SQLiteNativeModule.ModuleNotAvailableTableError(pVtab);
				}
				return this.module.xUpdate(pVtab, argc, argv, ref rowId);
			}

			// Token: 0x060005DA RID: 1498 RVA: 0x0002450C File Offset: 0x0002390C
			public global::System.Data.SQLite.SQLiteErrorCode xBegin(global::System.IntPtr pVtab)
			{
				if (this.module == null)
				{
					return global::System.Data.SQLite.SQLiteModule.SQLiteNativeModule.ModuleNotAvailableTableError(pVtab);
				}
				return this.module.xBegin(pVtab);
			}

			// Token: 0x060005DB RID: 1499 RVA: 0x00024534 File Offset: 0x00023934
			public global::System.Data.SQLite.SQLiteErrorCode xSync(global::System.IntPtr pVtab)
			{
				if (this.module == null)
				{
					return global::System.Data.SQLite.SQLiteModule.SQLiteNativeModule.ModuleNotAvailableTableError(pVtab);
				}
				return this.module.xSync(pVtab);
			}

			// Token: 0x060005DC RID: 1500 RVA: 0x0002455C File Offset: 0x0002395C
			public global::System.Data.SQLite.SQLiteErrorCode xCommit(global::System.IntPtr pVtab)
			{
				if (this.module == null)
				{
					return global::System.Data.SQLite.SQLiteModule.SQLiteNativeModule.ModuleNotAvailableTableError(pVtab);
				}
				return this.module.xCommit(pVtab);
			}

			// Token: 0x060005DD RID: 1501 RVA: 0x00024584 File Offset: 0x00023984
			public global::System.Data.SQLite.SQLiteErrorCode xRollback(global::System.IntPtr pVtab)
			{
				if (this.module == null)
				{
					return global::System.Data.SQLite.SQLiteModule.SQLiteNativeModule.ModuleNotAvailableTableError(pVtab);
				}
				return this.module.xRollback(pVtab);
			}

			// Token: 0x060005DE RID: 1502 RVA: 0x000245AC File Offset: 0x000239AC
			public int xFindFunction(global::System.IntPtr pVtab, int nArg, global::System.IntPtr zName, ref global::System.Data.SQLite.SQLiteCallback callback, ref global::System.IntPtr pClientData)
			{
				if (this.module == null)
				{
					global::System.Data.SQLite.SQLiteModule.SQLiteNativeModule.ModuleNotAvailableTableError(pVtab);
					return 0;
				}
				return this.module.xFindFunction(pVtab, nArg, zName, ref callback, ref pClientData);
			}

			// Token: 0x060005DF RID: 1503 RVA: 0x000245DC File Offset: 0x000239DC
			public global::System.Data.SQLite.SQLiteErrorCode xRename(global::System.IntPtr pVtab, global::System.IntPtr zNew)
			{
				if (this.module == null)
				{
					return global::System.Data.SQLite.SQLiteModule.SQLiteNativeModule.ModuleNotAvailableTableError(pVtab);
				}
				return this.module.xRename(pVtab, zNew);
			}

			// Token: 0x060005E0 RID: 1504 RVA: 0x00024608 File Offset: 0x00023A08
			public global::System.Data.SQLite.SQLiteErrorCode xSavepoint(global::System.IntPtr pVtab, int iSavepoint)
			{
				if (this.module == null)
				{
					return global::System.Data.SQLite.SQLiteModule.SQLiteNativeModule.ModuleNotAvailableTableError(pVtab);
				}
				return this.module.xSavepoint(pVtab, iSavepoint);
			}

			// Token: 0x060005E1 RID: 1505 RVA: 0x00024634 File Offset: 0x00023A34
			public global::System.Data.SQLite.SQLiteErrorCode xRelease(global::System.IntPtr pVtab, int iSavepoint)
			{
				if (this.module == null)
				{
					return global::System.Data.SQLite.SQLiteModule.SQLiteNativeModule.ModuleNotAvailableTableError(pVtab);
				}
				return this.module.xRelease(pVtab, iSavepoint);
			}

			// Token: 0x060005E2 RID: 1506 RVA: 0x00024660 File Offset: 0x00023A60
			public global::System.Data.SQLite.SQLiteErrorCode xRollbackTo(global::System.IntPtr pVtab, int iSavepoint)
			{
				if (this.module == null)
				{
					return global::System.Data.SQLite.SQLiteModule.SQLiteNativeModule.ModuleNotAvailableTableError(pVtab);
				}
				return this.module.xRollbackTo(pVtab, iSavepoint);
			}

			// Token: 0x060005E3 RID: 1507 RVA: 0x0002468C File Offset: 0x00023A8C
			public void Dispose()
			{
				this.Dispose(true);
				global::System.GC.SuppressFinalize(this);
			}

			// Token: 0x060005E4 RID: 1508 RVA: 0x000246A8 File Offset: 0x00023AA8
			private void CheckDisposed()
			{
				if (this.disposed)
				{
					throw new global::System.ObjectDisposedException(typeof(global::System.Data.SQLite.SQLiteModule.SQLiteNativeModule).Name);
				}
			}

			// Token: 0x060005E5 RID: 1509 RVA: 0x000246D4 File Offset: 0x00023AD4
			private void Dispose(bool disposing)
			{
				if (!this.disposed)
				{
					if (this.module != null)
					{
						this.module = null;
					}
					this.disposed = true;
				}
			}

			// Token: 0x060005E6 RID: 1510 RVA: 0x00024700 File Offset: 0x00023B00
			~SQLiteNativeModule()
			{
				this.Dispose(false);
			}

			// Token: 0x04000231 RID: 561
			private const bool DefaultLogErrors = true;

			// Token: 0x04000232 RID: 562
			private const string ModuleNotAvailableErrorMessage = "native module implementation not available";

			// Token: 0x04000233 RID: 563
			private global::System.Data.SQLite.SQLiteModule module;

			// Token: 0x04000234 RID: 564
			private bool disposed;
		}
	}
}
