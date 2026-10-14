using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;

namespace System.Data.SQLite
{
	// Token: 0x02000008 RID: 8
	internal sealed class SQLite3_UTF16 : global::System.Data.SQLite.SQLite3
	{
		// Token: 0x06000120 RID: 288 RVA: 0x00011BB0 File Offset: 0x00010FB0
		internal SQLite3_UTF16(global::System.Data.SQLite.SQLiteDateFormats fmt, global::System.DateTimeKind kind, string fmtString, global::System.IntPtr db, string fileName, bool ownHandle) : base(fmt, kind, fmtString, db, fileName, ownHandle)
		{
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00011BCC File Offset: 0x00010FCC
		private void CheckDisposed()
		{
			if (this.disposed)
			{
				throw new global::System.ObjectDisposedException(typeof(global::System.Data.SQLite.SQLite3_UTF16).Name);
			}
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00011BF8 File Offset: 0x00010FF8
		protected override void Dispose(bool disposing)
		{
			try
			{
				bool flag = this.disposed;
			}
			finally
			{
				base.Dispose(disposing);
				this.disposed = true;
			}
		}

		// Token: 0x06000123 RID: 291 RVA: 0x00011C3C File Offset: 0x0001103C
		public override string ToString(global::System.IntPtr b, int nbytelen)
		{
			this.CheckDisposed();
			return global::System.Data.SQLite.SQLite3_UTF16.UTF16ToString(b, nbytelen);
		}

		// Token: 0x06000124 RID: 292 RVA: 0x00011C58 File Offset: 0x00011058
		public static string UTF16ToString(global::System.IntPtr b, int nbytelen)
		{
			if (nbytelen == 0 || b == global::System.IntPtr.Zero)
			{
				return "";
			}
			if (nbytelen == -1)
			{
				return global::System.Runtime.InteropServices.Marshal.PtrToStringUni(b);
			}
			return global::System.Runtime.InteropServices.Marshal.PtrToStringUni(b, nbytelen / 2);
		}

		// Token: 0x06000125 RID: 293 RVA: 0x00011C90 File Offset: 0x00011090
		internal override void Open(string strFilename, global::System.Data.SQLite.SQLiteConnectionFlags connectionFlags, global::System.Data.SQLite.SQLiteOpenFlagsEnum openFlags, int maxPoolSize, bool usePool)
		{
			if (this._sql != null)
			{
				this.Close(true);
			}
			if (this._sql != null)
			{
				throw new global::System.Data.SQLite.SQLiteException("connection handle is still active");
			}
			this._usePool = usePool;
			this._fileName = strFilename;
			if (usePool)
			{
				this._sql = global::System.Data.SQLite.SQLiteConnectionPool.Remove(strFilename, maxPoolSize, out this._poolVersion);
			}
			if (this._sql == null)
			{
				try
				{
				}
				finally
				{
					global::System.IntPtr db;
					global::System.Data.SQLite.SQLiteErrorCode sqliteErrorCode;
					if ((connectionFlags & global::System.Data.SQLite.SQLiteConnectionFlags.NoExtensionFunctions) != global::System.Data.SQLite.SQLiteConnectionFlags.NoExtensionFunctions)
					{
						sqliteErrorCode = global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_open16_interop(global::System.Data.SQLite.SQLiteConvert.ToUTF8(strFilename), openFlags, out db);
					}
					else
					{
						if ((openFlags & global::System.Data.SQLite.SQLiteOpenFlagsEnum.Create) != global::System.Data.SQLite.SQLiteOpenFlagsEnum.Create && !global::System.IO.File.Exists(strFilename))
						{
							throw new global::System.Data.SQLite.SQLiteException(global::System.Data.SQLite.SQLiteErrorCode.CantOpen, strFilename);
						}
						sqliteErrorCode = global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_open16(strFilename, out db);
					}
					if (sqliteErrorCode != global::System.Data.SQLite.SQLiteErrorCode.Ok)
					{
						throw new global::System.Data.SQLite.SQLiteException(sqliteErrorCode, null);
					}
					this._sql = new global::System.Data.SQLite.SQLiteConnectionHandle(db, true);
				}
				lock (this._sql)
				{
				}
				global::System.Data.SQLite.SQLiteConnection.OnChanged(null, new global::System.Data.SQLite.ConnectionEventArgs(global::System.Data.SQLite.SQLiteConnectionEventType.NewCriticalHandle, null, null, null, null, this._sql, strFilename, new object[]
				{
					strFilename,
					connectionFlags,
					openFlags,
					maxPoolSize,
					usePool
				}));
			}
			if ((connectionFlags & global::System.Data.SQLite.SQLiteConnectionFlags.NoBindFunctions) != global::System.Data.SQLite.SQLiteConnectionFlags.NoBindFunctions)
			{
				if (this._functions == null)
				{
					this._functions = new global::System.Collections.Generic.List<global::System.Data.SQLite.SQLiteFunction>();
				}
				this._functions.AddRange(new global::System.Collections.Generic.List<global::System.Data.SQLite.SQLiteFunction>(global::System.Data.SQLite.SQLiteFunction.BindFunctions(this, connectionFlags)));
			}
			this.SetTimeout(0);
			global::System.GC.KeepAlive(this._sql);
		}

		// Token: 0x06000126 RID: 294 RVA: 0x00011E2C File Offset: 0x0001122C
		internal override void Bind_DateTime(global::System.Data.SQLite.SQLiteStatement stmt, global::System.Data.SQLite.SQLiteConnectionFlags flags, int index, global::System.DateTime dt)
		{
			switch (this._datetimeFormat)
			{
			case global::System.Data.SQLite.SQLiteDateFormats.Ticks:
			case global::System.Data.SQLite.SQLiteDateFormats.JulianDay:
			case global::System.Data.SQLite.SQLiteDateFormats.UnixEpoch:
				base.Bind_DateTime(stmt, flags, index, dt);
				return;
			}
			if ((flags & global::System.Data.SQLite.SQLiteConnectionFlags.LogBind) == global::System.Data.SQLite.SQLiteConnectionFlags.LogBind)
			{
				global::System.Data.SQLite.SQLiteStatementHandle handle = (stmt != null) ? stmt._sqlite_stmt : null;
				global::System.Data.SQLite.SQLite3.LogBind(handle, index, dt);
			}
			this.Bind_Text(stmt, flags, index, base.ToString(dt));
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00011E94 File Offset: 0x00011294
		internal override void Bind_Text(global::System.Data.SQLite.SQLiteStatement stmt, global::System.Data.SQLite.SQLiteConnectionFlags flags, int index, string value)
		{
			global::System.Data.SQLite.SQLiteStatementHandle sqlite_stmt = stmt._sqlite_stmt;
			if ((flags & global::System.Data.SQLite.SQLiteConnectionFlags.LogBind) == global::System.Data.SQLite.SQLiteConnectionFlags.LogBind)
			{
				global::System.Data.SQLite.SQLite3.LogBind(sqlite_stmt, index, value);
			}
			global::System.Data.SQLite.SQLiteErrorCode sqliteErrorCode = global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_bind_text16(sqlite_stmt, index, value, value.Length * 2, (global::System.IntPtr)(-1));
			if (sqliteErrorCode != global::System.Data.SQLite.SQLiteErrorCode.Ok)
			{
				throw new global::System.Data.SQLite.SQLiteException(sqliteErrorCode, this.GetLastError());
			}
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00011EE8 File Offset: 0x000112E8
		internal override global::System.DateTime GetDateTime(global::System.Data.SQLite.SQLiteStatement stmt, int index)
		{
			if (this._datetimeFormat == global::System.Data.SQLite.SQLiteDateFormats.Ticks)
			{
				return global::System.Data.SQLite.SQLiteConvert.ToDateTime(this.GetInt64(stmt, index), this._datetimeKind);
			}
			if (this._datetimeFormat == global::System.Data.SQLite.SQLiteDateFormats.JulianDay)
			{
				return global::System.Data.SQLite.SQLiteConvert.ToDateTime(this.GetDouble(stmt, index), this._datetimeKind);
			}
			if (this._datetimeFormat == global::System.Data.SQLite.SQLiteDateFormats.UnixEpoch)
			{
				return global::System.Data.SQLite.SQLiteConvert.ToDateTime(this.GetInt32(stmt, index), this._datetimeKind);
			}
			return base.ToDateTime(this.GetText(stmt, index));
		}

		// Token: 0x06000129 RID: 297 RVA: 0x00011F5C File Offset: 0x0001135C
		internal override string ColumnName(global::System.Data.SQLite.SQLiteStatement stmt, int index)
		{
			int nbytelen;
			global::System.IntPtr intPtr = global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_column_name16_interop(stmt._sqlite_stmt, index, out nbytelen);
			if (intPtr == global::System.IntPtr.Zero)
			{
				throw new global::System.Data.SQLite.SQLiteException(global::System.Data.SQLite.SQLiteErrorCode.NoMem, this.GetLastError());
			}
			return global::System.Data.SQLite.SQLite3_UTF16.UTF16ToString(intPtr, nbytelen);
		}

		// Token: 0x0600012A RID: 298 RVA: 0x00011FA0 File Offset: 0x000113A0
		internal override string GetText(global::System.Data.SQLite.SQLiteStatement stmt, int index)
		{
			int nbytelen;
			return global::System.Data.SQLite.SQLite3_UTF16.UTF16ToString(global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_column_text16_interop(stmt._sqlite_stmt, index, out nbytelen), nbytelen);
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00011FC8 File Offset: 0x000113C8
		internal override string ColumnOriginalName(global::System.Data.SQLite.SQLiteStatement stmt, int index)
		{
			int nbytelen;
			return global::System.Data.SQLite.SQLite3_UTF16.UTF16ToString(global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_column_origin_name16_interop(stmt._sqlite_stmt, index, out nbytelen), nbytelen);
		}

		// Token: 0x0600012C RID: 300 RVA: 0x00011FF0 File Offset: 0x000113F0
		internal override string ColumnDatabaseName(global::System.Data.SQLite.SQLiteStatement stmt, int index)
		{
			int nbytelen;
			return global::System.Data.SQLite.SQLite3_UTF16.UTF16ToString(global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_column_database_name16_interop(stmt._sqlite_stmt, index, out nbytelen), nbytelen);
		}

		// Token: 0x0600012D RID: 301 RVA: 0x00012018 File Offset: 0x00011418
		internal override string ColumnTableName(global::System.Data.SQLite.SQLiteStatement stmt, int index)
		{
			int nbytelen;
			return global::System.Data.SQLite.SQLite3_UTF16.UTF16ToString(global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_column_table_name16_interop(stmt._sqlite_stmt, index, out nbytelen), nbytelen);
		}

		// Token: 0x0600012E RID: 302 RVA: 0x00012040 File Offset: 0x00011440
		internal override string GetParamValueText(global::System.IntPtr ptr)
		{
			int nbytelen;
			return global::System.Data.SQLite.SQLite3_UTF16.UTF16ToString(global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_value_text16_interop(ptr, out nbytelen), nbytelen);
		}

		// Token: 0x0600012F RID: 303 RVA: 0x0001205C File Offset: 0x0001145C
		internal override void ReturnError(global::System.IntPtr context, string value)
		{
			global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_result_error16(context, value, value.Length * 2);
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00012078 File Offset: 0x00011478
		internal override void ReturnText(global::System.IntPtr context, string value)
		{
			global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_result_text16(context, value, value.Length * 2, (global::System.IntPtr)(-1));
		}

		// Token: 0x04000024 RID: 36
		private bool disposed;
	}
}
