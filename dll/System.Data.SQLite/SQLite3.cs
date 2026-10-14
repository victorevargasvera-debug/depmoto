using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace System.Data.SQLite
{
	// Token: 0x02000007 RID: 7
	internal class SQLite3 : global::System.Data.SQLite.SQLiteBase
	{
		// Token: 0x060000A2 RID: 162 RVA: 0x0000F4B8 File Offset: 0x0000E8B8
		internal SQLite3(global::System.Data.SQLite.SQLiteDateFormats fmt, global::System.DateTimeKind kind, string fmtString, global::System.IntPtr db, string fileName, bool ownHandle) : base(fmt, kind, fmtString)
		{
			if (db != global::System.IntPtr.Zero)
			{
				this._sql = new global::System.Data.SQLite.SQLiteConnectionHandle(db, ownHandle);
				this._fileName = fileName;
				global::System.Data.SQLite.SQLiteConnection.OnChanged(null, new global::System.Data.SQLite.ConnectionEventArgs(global::System.Data.SQLite.SQLiteConnectionEventType.NewCriticalHandle, null, null, null, null, this._sql, fileName, new object[]
				{
					fmt,
					kind,
					fmtString,
					db,
					fileName,
					ownHandle
				}));
			}
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x0000F544 File Offset: 0x0000E944
		private void CheckDisposed()
		{
			if (this.disposed)
			{
				throw new global::System.ObjectDisposedException(typeof(global::System.Data.SQLite.SQLite3).Name);
			}
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x0000F570 File Offset: 0x0000E970
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (!this.disposed)
				{
					this.DisposeModules();
					this.Close(false);
				}
			}
			finally
			{
				base.Dispose(disposing);
				this.disposed = true;
			}
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x0000F5C0 File Offset: 0x0000E9C0
		private void DisposeModules()
		{
			if (this._modules != null)
			{
				foreach (global::System.Collections.Generic.KeyValuePair<string, global::System.Data.SQLite.SQLiteModule> keyValuePair in this._modules)
				{
					global::System.Data.SQLite.SQLiteModule value = keyValuePair.Value;
					if (value != null)
					{
						value.Dispose();
					}
				}
				this._modules.Clear();
			}
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x0000F63C File Offset: 0x0000EA3C
		internal override void Close(bool canThrow)
		{
			if (this._sql != null)
			{
				if (!this._sql.OwnHandle)
				{
					this._sql = null;
					return;
				}
				if (this._usePool)
				{
					if (global::System.Data.SQLite.SQLiteBase.ResetConnection(this._sql, this._sql, canThrow))
					{
						this.DisposeModules();
						global::System.Data.SQLite.SQLiteConnectionPool.Add(this._fileName, this._sql, this._poolVersion);
					}
				}
				else
				{
					this._sql.Dispose();
				}
				this._sql = null;
			}
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x0000F6B8 File Offset: 0x0000EAB8
		internal override void Cancel()
		{
			global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_interrupt(this._sql);
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x0000F6D8 File Offset: 0x0000EAD8
		internal override void BindFunction(global::System.Data.SQLite.SQLiteFunctionAttribute functionAttribute, global::System.Data.SQLite.SQLiteFunction function, global::System.Data.SQLite.SQLiteConnectionFlags flags)
		{
			global::System.Data.SQLite.SQLiteFunction.BindFunction(this, functionAttribute, function, flags);
			if (this._functions == null)
			{
				this._functions = new global::System.Collections.Generic.List<global::System.Data.SQLite.SQLiteFunction>();
			}
			this._functions.Add(function);
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x060000A9 RID: 169 RVA: 0x0000F710 File Offset: 0x0000EB10
		internal override string Version
		{
			get
			{
				return global::System.Data.SQLite.SQLite3.SQLiteVersion;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x060000AA RID: 170 RVA: 0x0000F724 File Offset: 0x0000EB24
		internal override int VersionNumber
		{
			get
			{
				return global::System.Data.SQLite.SQLite3.SQLiteVersionNumber;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x060000AB RID: 171 RVA: 0x0000F738 File Offset: 0x0000EB38
		internal static string DefineConstants
		{
			get
			{
				global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
				global::System.Collections.Generic.IList<string> optionList = global::System.Data.SQLite.SQLiteDefineConstants.OptionList;
				if (optionList != null)
				{
					foreach (string text in optionList)
					{
						if (text != null)
						{
							if (stringBuilder.Length > 0)
							{
								stringBuilder.Append(' ');
							}
							stringBuilder.Append(text);
						}
					}
				}
				return stringBuilder.ToString();
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x060000AC RID: 172 RVA: 0x0000F7B8 File Offset: 0x0000EBB8
		internal static string SQLiteVersion
		{
			get
			{
				return global::System.Data.SQLite.SQLiteConvert.UTF8ToString(global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_libversion(), -1);
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x060000AD RID: 173 RVA: 0x0000F7D0 File Offset: 0x0000EBD0
		internal static int SQLiteVersionNumber
		{
			get
			{
				return global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_libversion_number();
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x060000AE RID: 174 RVA: 0x0000F7E4 File Offset: 0x0000EBE4
		internal static string SQLiteSourceId
		{
			get
			{
				return global::System.Data.SQLite.SQLiteConvert.UTF8ToString(global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_sourceid(), -1);
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x060000AF RID: 175 RVA: 0x0000F7FC File Offset: 0x0000EBFC
		internal static string InteropVersion
		{
			get
			{
				return global::System.Data.SQLite.SQLiteConvert.UTF8ToString(global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_libversion_interop(), -1);
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x060000B0 RID: 176 RVA: 0x0000F814 File Offset: 0x0000EC14
		internal static string InteropSourceId
		{
			get
			{
				return global::System.Data.SQLite.SQLiteConvert.UTF8ToString(global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_sourceid_interop(), -1);
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x060000B1 RID: 177 RVA: 0x0000F82C File Offset: 0x0000EC2C
		internal override bool AutoCommit
		{
			get
			{
				return global::System.Data.SQLite.SQLiteBase.IsAutocommit(this._sql, this._sql);
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x060000B2 RID: 178 RVA: 0x0000F850 File Offset: 0x0000EC50
		internal override long LastInsertRowId
		{
			get
			{
				return global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_last_insert_rowid(this._sql);
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x060000B3 RID: 179 RVA: 0x0000F870 File Offset: 0x0000EC70
		internal override int Changes
		{
			get
			{
				return global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_changes_interop(this._sql);
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x060000B4 RID: 180 RVA: 0x0000F890 File Offset: 0x0000EC90
		internal override long MemoryUsed
		{
			get
			{
				return global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_memory_used();
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x060000B5 RID: 181 RVA: 0x0000F8A4 File Offset: 0x0000ECA4
		internal override long MemoryHighwater
		{
			get
			{
				return global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_memory_highwater(0);
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x060000B6 RID: 182 RVA: 0x0000F8B8 File Offset: 0x0000ECB8
		internal override bool OwnHandle
		{
			get
			{
				if (this._sql == null)
				{
					throw new global::System.Data.SQLite.SQLiteException("no connection handle available");
				}
				return this._sql.OwnHandle;
			}
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x0000F8E4 File Offset: 0x0000ECE4
		internal override global::System.Data.SQLite.SQLiteErrorCode SetMemoryStatus(bool value)
		{
			return global::System.Data.SQLite.SQLite3.StaticSetMemoryStatus(value);
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x0000F8F8 File Offset: 0x0000ECF8
		internal static global::System.Data.SQLite.SQLiteErrorCode StaticSetMemoryStatus(bool value)
		{
			return global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_config_int(global::System.Data.SQLite.SQLiteConfigOpsEnum.SQLITE_CONFIG_MEMSTATUS, value ? 1 : 0);
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x0000F918 File Offset: 0x0000ED18
		internal override global::System.Data.SQLite.SQLiteErrorCode Shutdown()
		{
			return global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_shutdown();
		}

		// Token: 0x060000BA RID: 186 RVA: 0x0000F92C File Offset: 0x0000ED2C
		internal override bool IsOpen()
		{
			return this._sql != null && !this._sql.IsInvalid && !this._sql.IsClosed;
		}

		// Token: 0x060000BB RID: 187 RVA: 0x0000F960 File Offset: 0x0000ED60
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
						sqliteErrorCode = global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_open_interop(global::System.Data.SQLite.SQLiteConvert.ToUTF8(strFilename), openFlags, out db);
					}
					else
					{
						sqliteErrorCode = global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_open_v2(global::System.Data.SQLite.SQLiteConvert.ToUTF8(strFilename), out db, openFlags, global::System.IntPtr.Zero);
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

		// Token: 0x060000BC RID: 188 RVA: 0x0000FAF0 File Offset: 0x0000EEF0
		internal override void ClearPool()
		{
			global::System.Data.SQLite.SQLiteConnectionPool.ClearPool(this._fileName);
		}

		// Token: 0x060000BD RID: 189 RVA: 0x0000FB08 File Offset: 0x0000EF08
		internal override int CountPool()
		{
			global::System.Collections.Generic.Dictionary<string, int> dictionary = null;
			int num = 0;
			int num2 = 0;
			int result = 0;
			global::System.Data.SQLite.SQLiteConnectionPool.GetCounts(this._fileName, ref dictionary, ref num, ref num2, ref result);
			return result;
		}

		// Token: 0x060000BE RID: 190 RVA: 0x0000FB34 File Offset: 0x0000EF34
		internal override void SetTimeout(int nTimeoutMS)
		{
			global::System.IntPtr intPtr = this._sql;
			if (intPtr == global::System.IntPtr.Zero)
			{
				throw new global::System.Data.SQLite.SQLiteException("no connection handle available");
			}
			global::System.Data.SQLite.SQLiteErrorCode sqliteErrorCode = global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_busy_timeout(intPtr, nTimeoutMS);
			if (sqliteErrorCode != global::System.Data.SQLite.SQLiteErrorCode.Ok)
			{
				throw new global::System.Data.SQLite.SQLiteException(sqliteErrorCode, this.GetLastError());
			}
		}

		// Token: 0x060000BF RID: 191 RVA: 0x0000FB80 File Offset: 0x0000EF80
		internal override bool Step(global::System.Data.SQLite.SQLiteStatement stmt)
		{
			global::System.Random random = null;
			uint tickCount = (uint)global::System.Environment.TickCount;
			uint num = (uint)(stmt._command._commandTimeout * 1000);
			global::System.Data.SQLite.SQLiteErrorCode sqliteErrorCode;
			global::System.Data.SQLite.SQLiteErrorCode sqliteErrorCode2;
			for (;;)
			{
				sqliteErrorCode = global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_step(stmt._sqlite_stmt);
				if (sqliteErrorCode == global::System.Data.SQLite.SQLiteErrorCode.Row)
				{
					break;
				}
				if (sqliteErrorCode == global::System.Data.SQLite.SQLiteErrorCode.Done)
				{
					return false;
				}
				if (sqliteErrorCode != global::System.Data.SQLite.SQLiteErrorCode.Ok)
				{
					sqliteErrorCode2 = this.Reset(stmt);
					if (sqliteErrorCode2 == global::System.Data.SQLite.SQLiteErrorCode.Ok)
					{
						goto Block_4;
					}
					if ((sqliteErrorCode2 == global::System.Data.SQLite.SQLiteErrorCode.Locked || sqliteErrorCode2 == global::System.Data.SQLite.SQLiteErrorCode.Busy) && stmt._command != null)
					{
						if (random == null)
						{
							random = new global::System.Random();
						}
						if (global::System.Environment.TickCount - (int)tickCount > (int)num)
						{
							goto Block_8;
						}
						global::System.Threading.Thread.Sleep(random.Next(1, 150));
					}
				}
			}
			return true;
			Block_4:
			throw new global::System.Data.SQLite.SQLiteException(sqliteErrorCode, this.GetLastError());
			Block_8:
			throw new global::System.Data.SQLite.SQLiteException(sqliteErrorCode2, this.GetLastError());
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x0000FC28 File Offset: 0x0000F028
		internal override global::System.Data.SQLite.SQLiteErrorCode Reset(global::System.Data.SQLite.SQLiteStatement stmt)
		{
			global::System.Data.SQLite.SQLiteErrorCode sqliteErrorCode = global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_reset_interop(stmt._sqlite_stmt);
			if (sqliteErrorCode == global::System.Data.SQLite.SQLiteErrorCode.Schema)
			{
				string text;
				using (global::System.Data.SQLite.SQLiteStatement sqliteStatement = this.Prepare(null, stmt._sqlStatement, null, (uint)(stmt._command._commandTimeout * 1000), out text))
				{
					stmt._sqlite_stmt.Dispose();
					stmt._sqlite_stmt = sqliteStatement._sqlite_stmt;
					sqliteStatement._sqlite_stmt = null;
					stmt.BindParameters();
				}
				return global::System.Data.SQLite.SQLiteErrorCode.Unknown;
			}
			if (sqliteErrorCode == global::System.Data.SQLite.SQLiteErrorCode.Locked || sqliteErrorCode == global::System.Data.SQLite.SQLiteErrorCode.Busy)
			{
				return sqliteErrorCode;
			}
			if (sqliteErrorCode != global::System.Data.SQLite.SQLiteErrorCode.Ok)
			{
				throw new global::System.Data.SQLite.SQLiteException(sqliteErrorCode, this.GetLastError());
			}
			return sqliteErrorCode;
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x0000FCD8 File Offset: 0x0000F0D8
		internal override string GetLastError()
		{
			return global::System.Data.SQLite.SQLiteBase.GetLastError(this._sql, this._sql);
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x0000FCFC File Offset: 0x0000F0FC
		internal override global::System.Data.SQLite.SQLiteStatement Prepare(global::System.Data.SQLite.SQLiteConnection cnn, string strSql, global::System.Data.SQLite.SQLiteStatement previous, uint timeoutMS, out string strRemain)
		{
			if (!string.IsNullOrEmpty(strSql))
			{
				string text = (cnn != null) ? cnn._baseSchemaName : null;
				if (!string.IsNullOrEmpty(text))
				{
					strSql = strSql.Replace(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "[{0}].", new object[]
					{
						text
					}), string.Empty);
					strSql = strSql.Replace(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "{0}.", new object[]
					{
						text
					}), string.Empty);
				}
			}
			global::System.Data.SQLite.SQLiteConnectionFlags sqliteConnectionFlags = (cnn != null) ? cnn.Flags : global::System.Data.SQLite.SQLiteConnectionFlags.Default;
			if ((sqliteConnectionFlags & global::System.Data.SQLite.SQLiteConnectionFlags.LogPrepare) == global::System.Data.SQLite.SQLiteConnectionFlags.LogPrepare)
			{
				if (strSql == null || strSql.Length == 0 || strSql.Trim().Length == 0)
				{
					global::System.Data.SQLite.SQLiteLog.LogMessage("Preparing {<nothing>}...");
				}
				else
				{
					global::System.Data.SQLite.SQLiteLog.LogMessage(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, "Preparing {{{0}}}...", new object[]
					{
						strSql
					}));
				}
			}
			global::System.IntPtr zero = global::System.IntPtr.Zero;
			global::System.IntPtr zero2 = global::System.IntPtr.Zero;
			int nativestringlen = 0;
			global::System.Data.SQLite.SQLiteErrorCode sqliteErrorCode = global::System.Data.SQLite.SQLiteErrorCode.Schema;
			int num = 0;
			byte[] array = global::System.Data.SQLite.SQLiteConvert.ToUTF8(strSql);
			global::System.Data.SQLite.SQLiteStatement sqliteStatement = null;
			global::System.Random random = null;
			uint tickCount = (uint)global::System.Environment.TickCount;
			global::System.Runtime.InteropServices.GCHandle gchandle = global::System.Runtime.InteropServices.GCHandle.Alloc(array, global::System.Runtime.InteropServices.GCHandleType.Pinned);
			global::System.IntPtr pSql = gchandle.AddrOfPinnedObject();
			global::System.Data.SQLite.SQLiteStatementHandle sqliteStatementHandle = null;
			global::System.Data.SQLite.SQLiteStatement result;
			try
			{
				while ((sqliteErrorCode == global::System.Data.SQLite.SQLiteErrorCode.Schema || sqliteErrorCode == global::System.Data.SQLite.SQLiteErrorCode.Locked || sqliteErrorCode == global::System.Data.SQLite.SQLiteErrorCode.Busy) && num < 3)
				{
					try
					{
					}
					finally
					{
						sqliteErrorCode = global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_prepare_interop(this._sql, pSql, array.Length - 1, out zero, out zero2, out nativestringlen);
						if (sqliteErrorCode == global::System.Data.SQLite.SQLiteErrorCode.Ok && zero != global::System.IntPtr.Zero)
						{
							if (sqliteStatementHandle != null)
							{
								sqliteStatementHandle.Dispose();
							}
							sqliteStatementHandle = new global::System.Data.SQLite.SQLiteStatementHandle(this._sql, zero);
						}
					}
					if (sqliteStatementHandle != null)
					{
						global::System.Data.SQLite.SQLiteConnection.OnChanged(null, new global::System.Data.SQLite.ConnectionEventArgs(global::System.Data.SQLite.SQLiteConnectionEventType.NewCriticalHandle, null, null, null, null, sqliteStatementHandle, strSql, new object[]
						{
							cnn,
							strSql,
							previous,
							timeoutMS
						}));
					}
					if (sqliteErrorCode == global::System.Data.SQLite.SQLiteErrorCode.Schema)
					{
						num++;
					}
					else
					{
						if (sqliteErrorCode == global::System.Data.SQLite.SQLiteErrorCode.Error)
						{
							if (string.Compare(this.GetLastError(), "near \"TYPES\": syntax error", global::System.StringComparison.OrdinalIgnoreCase) == 0)
							{
								int num2 = strSql.IndexOf(';');
								if (num2 == -1)
								{
									num2 = strSql.Length - 1;
								}
								string types = strSql.Substring(0, num2 + 1);
								strSql = strSql.Substring(num2 + 1);
								strRemain = "";
								while (sqliteStatement == null && strSql.Length > 0)
								{
									sqliteStatement = this.Prepare(cnn, strSql, previous, timeoutMS, out strRemain);
									strSql = strRemain;
								}
								if (sqliteStatement != null)
								{
									sqliteStatement.SetTypes(types);
								}
								return sqliteStatement;
							}
							if (this._buildingSchema || string.Compare(this.GetLastError(), 0, "no such table: TEMP.SCHEMA", 0, 26, global::System.StringComparison.OrdinalIgnoreCase) != 0)
							{
								continue;
							}
							strRemain = "";
							this._buildingSchema = true;
							try
							{
								global::System.Data.SQLite.ISQLiteSchemaExtensions isqliteSchemaExtensions = ((global::System.IServiceProvider)global::System.Data.SQLite.SQLiteFactory.Instance).GetService(typeof(global::System.Data.SQLite.ISQLiteSchemaExtensions)) as global::System.Data.SQLite.ISQLiteSchemaExtensions;
								if (isqliteSchemaExtensions != null)
								{
									isqliteSchemaExtensions.BuildTempSchema(cnn);
								}
								while (sqliteStatement == null && strSql.Length > 0)
								{
									sqliteStatement = this.Prepare(cnn, strSql, previous, timeoutMS, out strRemain);
									strSql = strRemain;
								}
								return sqliteStatement;
							}
							finally
							{
								this._buildingSchema = false;
							}
						}
						if (sqliteErrorCode == global::System.Data.SQLite.SQLiteErrorCode.Locked || sqliteErrorCode == global::System.Data.SQLite.SQLiteErrorCode.Busy)
						{
							if (random == null)
							{
								random = new global::System.Random();
							}
							if (global::System.Environment.TickCount - (int)tickCount > (int)timeoutMS)
							{
								throw new global::System.Data.SQLite.SQLiteException(sqliteErrorCode, this.GetLastError());
							}
							global::System.Threading.Thread.Sleep(random.Next(1, 150));
						}
					}
				}
				if (sqliteErrorCode != global::System.Data.SQLite.SQLiteErrorCode.Ok)
				{
					throw new global::System.Data.SQLite.SQLiteException(sqliteErrorCode, this.GetLastError());
				}
				strRemain = global::System.Data.SQLite.SQLiteConvert.UTF8ToString(zero2, nativestringlen);
				if (sqliteStatementHandle != null)
				{
					sqliteStatement = new global::System.Data.SQLite.SQLiteStatement(this, sqliteConnectionFlags, sqliteStatementHandle, strSql.Substring(0, strSql.Length - strRemain.Length), previous);
				}
				result = sqliteStatement;
			}
			finally
			{
				gchandle.Free();
			}
			return result;
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x000100BC File Offset: 0x0000F4BC
		protected static void LogBind(global::System.Data.SQLite.SQLiteStatementHandle handle, int index)
		{
			global::System.IntPtr intPtr = handle;
			global::System.Data.SQLite.SQLiteLog.LogMessage(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, "Binding statement {0} paramter #{1} as NULL...", new object[]
			{
				intPtr,
				index
			}));
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00010100 File Offset: 0x0000F500
		protected static void LogBind(global::System.Data.SQLite.SQLiteStatementHandle handle, int index, global::System.ValueType value)
		{
			global::System.IntPtr intPtr = handle;
			global::System.Data.SQLite.SQLiteLog.LogMessage(string.Format("Binding statement {0} paramter #{1} as type {2} with value {{{3}}}...", new object[]
			{
				intPtr,
				index,
				value.GetType(),
				value
			}));
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x0001014C File Offset: 0x0000F54C
		private static string FormatDateTime(global::System.DateTime value)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append(value.ToString("yyyy-MM-ddTHH:mm:ss.FFFFFFFK"));
			stringBuilder.Append(' ');
			stringBuilder.Append(value.Kind);
			stringBuilder.Append(' ');
			stringBuilder.Append(value.Ticks);
			return stringBuilder.ToString();
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x000101AC File Offset: 0x0000F5AC
		protected static void LogBind(global::System.Data.SQLite.SQLiteStatementHandle handle, int index, global::System.DateTime value)
		{
			global::System.IntPtr intPtr = handle;
			global::System.Data.SQLite.SQLiteLog.LogMessage(string.Format("Binding statement {0} paramter #{1} as type {2} with value {{{3}}}...", new object[]
			{
				intPtr,
				index,
				typeof(global::System.DateTime),
				global::System.Data.SQLite.SQLite3.FormatDateTime(value)
			}));
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00010200 File Offset: 0x0000F600
		protected static void LogBind(global::System.Data.SQLite.SQLiteStatementHandle handle, int index, string value)
		{
			global::System.IntPtr intPtr = handle;
			global::System.Data.SQLite.SQLiteLog.LogMessage(string.Format("Binding statement {0} paramter #{1} as type {2} with value {{{3}}}...", new object[]
			{
				intPtr,
				index,
				typeof(string),
				(value != null) ? value : "<null>"
			}));
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00010258 File Offset: 0x0000F658
		private static string ToHexadecimalString(byte[] array)
		{
			if (array == null)
			{
				return null;
			}
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(array.Length * 2);
			int num = array.Length;
			for (int i = 0; i < num; i++)
			{
				stringBuilder.Append(array[i].ToString("x2"));
			}
			return stringBuilder.ToString();
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x000102A4 File Offset: 0x0000F6A4
		protected static void LogBind(global::System.Data.SQLite.SQLiteStatementHandle handle, int index, byte[] value)
		{
			global::System.IntPtr intPtr = handle;
			global::System.Data.SQLite.SQLiteLog.LogMessage(string.Format("Binding statement {0} paramter #{1} as type {2} with value {{{3}}}...", new object[]
			{
				intPtr,
				index,
				typeof(byte[]),
				(value != null) ? global::System.Data.SQLite.SQLite3.ToHexadecimalString(value) : "<null>"
			}));
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00010304 File Offset: 0x0000F704
		internal override void Bind_Double(global::System.Data.SQLite.SQLiteStatement stmt, global::System.Data.SQLite.SQLiteConnectionFlags flags, int index, double value)
		{
			global::System.Data.SQLite.SQLiteStatementHandle sqlite_stmt = stmt._sqlite_stmt;
			if ((flags & global::System.Data.SQLite.SQLiteConnectionFlags.LogBind) == global::System.Data.SQLite.SQLiteConnectionFlags.LogBind)
			{
				global::System.Data.SQLite.SQLite3.LogBind(sqlite_stmt, index, value);
			}
			global::System.Data.SQLite.SQLiteErrorCode sqliteErrorCode = global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_bind_double(sqlite_stmt, index, value);
			if (sqliteErrorCode != global::System.Data.SQLite.SQLiteErrorCode.Ok)
			{
				throw new global::System.Data.SQLite.SQLiteException(sqliteErrorCode, this.GetLastError());
			}
		}

		// Token: 0x060000CB RID: 203 RVA: 0x0001034C File Offset: 0x0000F74C
		internal override void Bind_Int32(global::System.Data.SQLite.SQLiteStatement stmt, global::System.Data.SQLite.SQLiteConnectionFlags flags, int index, int value)
		{
			global::System.Data.SQLite.SQLiteStatementHandle sqlite_stmt = stmt._sqlite_stmt;
			if ((flags & global::System.Data.SQLite.SQLiteConnectionFlags.LogBind) == global::System.Data.SQLite.SQLiteConnectionFlags.LogBind)
			{
				global::System.Data.SQLite.SQLite3.LogBind(sqlite_stmt, index, value);
			}
			global::System.Data.SQLite.SQLiteErrorCode sqliteErrorCode = global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_bind_int(sqlite_stmt, index, value);
			if (sqliteErrorCode != global::System.Data.SQLite.SQLiteErrorCode.Ok)
			{
				throw new global::System.Data.SQLite.SQLiteException(sqliteErrorCode, this.GetLastError());
			}
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00010394 File Offset: 0x0000F794
		internal override void Bind_UInt32(global::System.Data.SQLite.SQLiteStatement stmt, global::System.Data.SQLite.SQLiteConnectionFlags flags, int index, uint value)
		{
			global::System.Data.SQLite.SQLiteStatementHandle sqlite_stmt = stmt._sqlite_stmt;
			if ((flags & global::System.Data.SQLite.SQLiteConnectionFlags.LogBind) == global::System.Data.SQLite.SQLiteConnectionFlags.LogBind)
			{
				global::System.Data.SQLite.SQLite3.LogBind(sqlite_stmt, index, value);
			}
			global::System.Data.SQLite.SQLiteErrorCode sqliteErrorCode;
			if ((flags & global::System.Data.SQLite.SQLiteConnectionFlags.BindUInt32AsInt64) == global::System.Data.SQLite.SQLiteConnectionFlags.BindUInt32AsInt64)
			{
				long value2 = (long)((ulong)value);
				sqliteErrorCode = global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_bind_int64(sqlite_stmt, index, value2);
			}
			else
			{
				sqliteErrorCode = global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_bind_uint(sqlite_stmt, index, value);
			}
			if (sqliteErrorCode != global::System.Data.SQLite.SQLiteErrorCode.Ok)
			{
				throw new global::System.Data.SQLite.SQLiteException(sqliteErrorCode, this.GetLastError());
			}
		}

		// Token: 0x060000CD RID: 205 RVA: 0x000103F8 File Offset: 0x0000F7F8
		internal override void Bind_Int64(global::System.Data.SQLite.SQLiteStatement stmt, global::System.Data.SQLite.SQLiteConnectionFlags flags, int index, long value)
		{
			global::System.Data.SQLite.SQLiteStatementHandle sqlite_stmt = stmt._sqlite_stmt;
			if ((flags & global::System.Data.SQLite.SQLiteConnectionFlags.LogBind) == global::System.Data.SQLite.SQLiteConnectionFlags.LogBind)
			{
				global::System.Data.SQLite.SQLite3.LogBind(sqlite_stmt, index, value);
			}
			global::System.Data.SQLite.SQLiteErrorCode sqliteErrorCode = global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_bind_int64(sqlite_stmt, index, value);
			if (sqliteErrorCode != global::System.Data.SQLite.SQLiteErrorCode.Ok)
			{
				throw new global::System.Data.SQLite.SQLiteException(sqliteErrorCode, this.GetLastError());
			}
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00010440 File Offset: 0x0000F840
		internal override void Bind_UInt64(global::System.Data.SQLite.SQLiteStatement stmt, global::System.Data.SQLite.SQLiteConnectionFlags flags, int index, ulong value)
		{
			global::System.Data.SQLite.SQLiteStatementHandle sqlite_stmt = stmt._sqlite_stmt;
			if ((flags & global::System.Data.SQLite.SQLiteConnectionFlags.LogBind) == global::System.Data.SQLite.SQLiteConnectionFlags.LogBind)
			{
				global::System.Data.SQLite.SQLite3.LogBind(sqlite_stmt, index, value);
			}
			global::System.Data.SQLite.SQLiteErrorCode sqliteErrorCode = global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_bind_uint64(sqlite_stmt, index, value);
			if (sqliteErrorCode != global::System.Data.SQLite.SQLiteErrorCode.Ok)
			{
				throw new global::System.Data.SQLite.SQLiteException(sqliteErrorCode, this.GetLastError());
			}
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00010488 File Offset: 0x0000F888
		internal override void Bind_Text(global::System.Data.SQLite.SQLiteStatement stmt, global::System.Data.SQLite.SQLiteConnectionFlags flags, int index, string value)
		{
			global::System.Data.SQLite.SQLiteStatementHandle sqlite_stmt = stmt._sqlite_stmt;
			if ((flags & global::System.Data.SQLite.SQLiteConnectionFlags.LogBind) == global::System.Data.SQLite.SQLiteConnectionFlags.LogBind)
			{
				global::System.Data.SQLite.SQLite3.LogBind(sqlite_stmt, index, value);
			}
			byte[] array = global::System.Data.SQLite.SQLiteConvert.ToUTF8(value);
			if ((flags & global::System.Data.SQLite.SQLiteConnectionFlags.LogBind) == global::System.Data.SQLite.SQLiteConnectionFlags.LogBind)
			{
				global::System.Data.SQLite.SQLite3.LogBind(sqlite_stmt, index, array);
			}
			global::System.Data.SQLite.SQLiteErrorCode sqliteErrorCode = global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_bind_text(sqlite_stmt, index, array, array.Length - 1, (global::System.IntPtr)(-1));
			if (sqliteErrorCode != global::System.Data.SQLite.SQLiteErrorCode.Ok)
			{
				throw new global::System.Data.SQLite.SQLiteException(sqliteErrorCode, this.GetLastError());
			}
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x000104EC File Offset: 0x0000F8EC
		internal override void Bind_DateTime(global::System.Data.SQLite.SQLiteStatement stmt, global::System.Data.SQLite.SQLiteConnectionFlags flags, int index, global::System.DateTime dt)
		{
			global::System.Data.SQLite.SQLiteStatementHandle sqlite_stmt = stmt._sqlite_stmt;
			if ((flags & global::System.Data.SQLite.SQLiteConnectionFlags.LogBind) == global::System.Data.SQLite.SQLiteConnectionFlags.LogBind)
			{
				global::System.Data.SQLite.SQLite3.LogBind(sqlite_stmt, index, dt);
			}
			switch (this._datetimeFormat)
			{
			case global::System.Data.SQLite.SQLiteDateFormats.Ticks:
			{
				long ticks = dt.Ticks;
				if ((flags & global::System.Data.SQLite.SQLiteConnectionFlags.LogBind) == global::System.Data.SQLite.SQLiteConnectionFlags.LogBind)
				{
					global::System.Data.SQLite.SQLite3.LogBind(sqlite_stmt, index, ticks);
				}
				global::System.Data.SQLite.SQLiteErrorCode sqliteErrorCode = global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_bind_int64(sqlite_stmt, index, ticks);
				if (sqliteErrorCode != global::System.Data.SQLite.SQLiteErrorCode.Ok)
				{
					throw new global::System.Data.SQLite.SQLiteException(sqliteErrorCode, this.GetLastError());
				}
				return;
			}
			case global::System.Data.SQLite.SQLiteDateFormats.JulianDay:
			{
				double num = global::System.Data.SQLite.SQLiteConvert.ToJulianDay(dt);
				if ((flags & global::System.Data.SQLite.SQLiteConnectionFlags.LogBind) == global::System.Data.SQLite.SQLiteConnectionFlags.LogBind)
				{
					global::System.Data.SQLite.SQLite3.LogBind(sqlite_stmt, index, num);
				}
				global::System.Data.SQLite.SQLiteErrorCode sqliteErrorCode2 = global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_bind_double(sqlite_stmt, index, num);
				if (sqliteErrorCode2 != global::System.Data.SQLite.SQLiteErrorCode.Ok)
				{
					throw new global::System.Data.SQLite.SQLiteException(sqliteErrorCode2, this.GetLastError());
				}
				return;
			}
			case global::System.Data.SQLite.SQLiteDateFormats.UnixEpoch:
			{
				long num2 = global::System.Convert.ToInt64(dt.Subtract(global::System.Data.SQLite.SQLiteConvert.UnixEpoch).TotalSeconds);
				if ((flags & global::System.Data.SQLite.SQLiteConnectionFlags.LogBind) == global::System.Data.SQLite.SQLiteConnectionFlags.LogBind)
				{
					global::System.Data.SQLite.SQLite3.LogBind(sqlite_stmt, index, num2);
				}
				global::System.Data.SQLite.SQLiteErrorCode sqliteErrorCode3 = global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_bind_int64(sqlite_stmt, index, num2);
				if (sqliteErrorCode3 != global::System.Data.SQLite.SQLiteErrorCode.Ok)
				{
					throw new global::System.Data.SQLite.SQLiteException(sqliteErrorCode3, this.GetLastError());
				}
				return;
			}
			}
			byte[] array = base.ToUTF8(dt);
			if ((flags & global::System.Data.SQLite.SQLiteConnectionFlags.LogBind) == global::System.Data.SQLite.SQLiteConnectionFlags.LogBind)
			{
				global::System.Data.SQLite.SQLite3.LogBind(sqlite_stmt, index, array);
			}
			global::System.Data.SQLite.SQLiteErrorCode sqliteErrorCode4 = global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_bind_text(sqlite_stmt, index, array, array.Length - 1, (global::System.IntPtr)(-1));
			if (sqliteErrorCode4 != global::System.Data.SQLite.SQLiteErrorCode.Ok)
			{
				throw new global::System.Data.SQLite.SQLiteException(sqliteErrorCode4, this.GetLastError());
			}
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00010648 File Offset: 0x0000FA48
		internal override void Bind_Blob(global::System.Data.SQLite.SQLiteStatement stmt, global::System.Data.SQLite.SQLiteConnectionFlags flags, int index, byte[] blobData)
		{
			global::System.Data.SQLite.SQLiteStatementHandle sqlite_stmt = stmt._sqlite_stmt;
			if ((flags & global::System.Data.SQLite.SQLiteConnectionFlags.LogBind) == global::System.Data.SQLite.SQLiteConnectionFlags.LogBind)
			{
				global::System.Data.SQLite.SQLite3.LogBind(sqlite_stmt, index, blobData);
			}
			global::System.Data.SQLite.SQLiteErrorCode sqliteErrorCode = global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_bind_blob(sqlite_stmt, index, blobData, blobData.Length, (global::System.IntPtr)(-1));
			if (sqliteErrorCode != global::System.Data.SQLite.SQLiteErrorCode.Ok)
			{
				throw new global::System.Data.SQLite.SQLiteException(sqliteErrorCode, this.GetLastError());
			}
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00010694 File Offset: 0x0000FA94
		internal override void Bind_Null(global::System.Data.SQLite.SQLiteStatement stmt, global::System.Data.SQLite.SQLiteConnectionFlags flags, int index)
		{
			global::System.Data.SQLite.SQLiteStatementHandle sqlite_stmt = stmt._sqlite_stmt;
			if ((flags & global::System.Data.SQLite.SQLiteConnectionFlags.LogBind) == global::System.Data.SQLite.SQLiteConnectionFlags.LogBind)
			{
				global::System.Data.SQLite.SQLite3.LogBind(sqlite_stmt, index);
			}
			global::System.Data.SQLite.SQLiteErrorCode sqliteErrorCode = global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_bind_null(sqlite_stmt, index);
			if (sqliteErrorCode != global::System.Data.SQLite.SQLiteErrorCode.Ok)
			{
				throw new global::System.Data.SQLite.SQLiteException(sqliteErrorCode, this.GetLastError());
			}
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x000106D4 File Offset: 0x0000FAD4
		internal override int Bind_ParamCount(global::System.Data.SQLite.SQLiteStatement stmt, global::System.Data.SQLite.SQLiteConnectionFlags flags)
		{
			global::System.Data.SQLite.SQLiteStatementHandle sqlite_stmt = stmt._sqlite_stmt;
			int num = global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_bind_parameter_count(sqlite_stmt);
			if ((flags & global::System.Data.SQLite.SQLiteConnectionFlags.LogBind) == global::System.Data.SQLite.SQLiteConnectionFlags.LogBind)
			{
				global::System.IntPtr intPtr = sqlite_stmt;
				global::System.Data.SQLite.SQLiteLog.LogMessage(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, "Statement {0} paramter count is {1}.", new object[]
				{
					intPtr,
					num
				}));
			}
			return num;
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00010730 File Offset: 0x0000FB30
		internal override string Bind_ParamName(global::System.Data.SQLite.SQLiteStatement stmt, global::System.Data.SQLite.SQLiteConnectionFlags flags, int index)
		{
			global::System.Data.SQLite.SQLiteStatementHandle sqlite_stmt = stmt._sqlite_stmt;
			int nativestringlen;
			string text = global::System.Data.SQLite.SQLiteConvert.UTF8ToString(global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_bind_parameter_name_interop(sqlite_stmt, index, out nativestringlen), nativestringlen);
			if ((flags & global::System.Data.SQLite.SQLiteConnectionFlags.LogBind) == global::System.Data.SQLite.SQLiteConnectionFlags.LogBind)
			{
				global::System.IntPtr intPtr = sqlite_stmt;
				global::System.Data.SQLite.SQLiteLog.LogMessage(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, "Statement {0} paramter #{1} name is {{{2}}}.", new object[]
				{
					intPtr,
					index,
					text
				}));
			}
			return text;
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x0001079C File Offset: 0x0000FB9C
		internal override int Bind_ParamIndex(global::System.Data.SQLite.SQLiteStatement stmt, global::System.Data.SQLite.SQLiteConnectionFlags flags, string paramName)
		{
			global::System.Data.SQLite.SQLiteStatementHandle sqlite_stmt = stmt._sqlite_stmt;
			int num = global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_bind_parameter_index(sqlite_stmt, global::System.Data.SQLite.SQLiteConvert.ToUTF8(paramName));
			if ((flags & global::System.Data.SQLite.SQLiteConnectionFlags.LogBind) == global::System.Data.SQLite.SQLiteConnectionFlags.LogBind)
			{
				global::System.IntPtr intPtr = sqlite_stmt;
				global::System.Data.SQLite.SQLiteLog.LogMessage(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, "Statement {0} paramter index of name {{{1}}} is #{2}.", new object[]
				{
					intPtr,
					paramName,
					num
				}));
			}
			return num;
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00010804 File Offset: 0x0000FC04
		internal override int ColumnCount(global::System.Data.SQLite.SQLiteStatement stmt)
		{
			return global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_column_count(stmt._sqlite_stmt);
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00010824 File Offset: 0x0000FC24
		internal override string ColumnName(global::System.Data.SQLite.SQLiteStatement stmt, int index)
		{
			int nativestringlen;
			global::System.IntPtr intPtr = global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_column_name_interop(stmt._sqlite_stmt, index, out nativestringlen);
			if (intPtr == global::System.IntPtr.Zero)
			{
				throw new global::System.Data.SQLite.SQLiteException(global::System.Data.SQLite.SQLiteErrorCode.NoMem, this.GetLastError());
			}
			return global::System.Data.SQLite.SQLiteConvert.UTF8ToString(intPtr, nativestringlen);
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00010868 File Offset: 0x0000FC68
		internal override global::System.Data.SQLite.TypeAffinity ColumnAffinity(global::System.Data.SQLite.SQLiteStatement stmt, int index)
		{
			return global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_column_type(stmt._sqlite_stmt, index);
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00010888 File Offset: 0x0000FC88
		internal override string ColumnType(global::System.Data.SQLite.SQLiteStatement stmt, int index, out global::System.Data.SQLite.TypeAffinity nAffinity)
		{
			int nativestringlen;
			global::System.IntPtr intPtr = global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_column_decltype_interop(stmt._sqlite_stmt, index, out nativestringlen);
			nAffinity = this.ColumnAffinity(stmt, index);
			if (intPtr != global::System.IntPtr.Zero)
			{
				return global::System.Data.SQLite.SQLiteConvert.UTF8ToString(intPtr, nativestringlen);
			}
			string[] typeDefinitions = stmt.TypeDefinitions;
			if (typeDefinitions != null && index < typeDefinitions.Length && typeDefinitions[index] != null)
			{
				return typeDefinitions[index];
			}
			return string.Empty;
		}

		// Token: 0x060000DA RID: 218 RVA: 0x000108E8 File Offset: 0x0000FCE8
		internal override int ColumnIndex(global::System.Data.SQLite.SQLiteStatement stmt, string columnName)
		{
			int num = this.ColumnCount(stmt);
			for (int i = 0; i < num; i++)
			{
				if (string.Compare(columnName, this.ColumnName(stmt, i), global::System.StringComparison.OrdinalIgnoreCase) == 0)
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00010920 File Offset: 0x0000FD20
		internal override string ColumnOriginalName(global::System.Data.SQLite.SQLiteStatement stmt, int index)
		{
			int nativestringlen;
			return global::System.Data.SQLite.SQLiteConvert.UTF8ToString(global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_column_origin_name_interop(stmt._sqlite_stmt, index, out nativestringlen), nativestringlen);
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00010948 File Offset: 0x0000FD48
		internal override string ColumnDatabaseName(global::System.Data.SQLite.SQLiteStatement stmt, int index)
		{
			int nativestringlen;
			return global::System.Data.SQLite.SQLiteConvert.UTF8ToString(global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_column_database_name_interop(stmt._sqlite_stmt, index, out nativestringlen), nativestringlen);
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00010970 File Offset: 0x0000FD70
		internal override string ColumnTableName(global::System.Data.SQLite.SQLiteStatement stmt, int index)
		{
			int nativestringlen;
			return global::System.Data.SQLite.SQLiteConvert.UTF8ToString(global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_column_table_name_interop(stmt._sqlite_stmt, index, out nativestringlen), nativestringlen);
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00010998 File Offset: 0x0000FD98
		internal override void ColumnMetaData(string dataBase, string table, string column, out string dataType, out string collateSequence, out bool notNull, out bool primaryKey, out bool autoIncrement)
		{
			global::System.IntPtr nativestring;
			global::System.IntPtr nativestring2;
			int num;
			int num2;
			int num3;
			int nativestringlen;
			int nativestringlen2;
			global::System.Data.SQLite.SQLiteErrorCode sqliteErrorCode = global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_table_column_metadata_interop(this._sql, global::System.Data.SQLite.SQLiteConvert.ToUTF8(dataBase), global::System.Data.SQLite.SQLiteConvert.ToUTF8(table), global::System.Data.SQLite.SQLiteConvert.ToUTF8(column), out nativestring, out nativestring2, out num, out num2, out num3, out nativestringlen, out nativestringlen2);
			if (sqliteErrorCode != global::System.Data.SQLite.SQLiteErrorCode.Ok)
			{
				throw new global::System.Data.SQLite.SQLiteException(sqliteErrorCode, this.GetLastError());
			}
			dataType = global::System.Data.SQLite.SQLiteConvert.UTF8ToString(nativestring, nativestringlen);
			collateSequence = global::System.Data.SQLite.SQLiteConvert.UTF8ToString(nativestring2, nativestringlen2);
			notNull = (num == 1);
			primaryKey = (num2 == 1);
			autoIncrement = (num3 == 1);
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00010A14 File Offset: 0x0000FE14
		internal override double GetDouble(global::System.Data.SQLite.SQLiteStatement stmt, int index)
		{
			return global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_column_double(stmt._sqlite_stmt, index);
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00010A34 File Offset: 0x0000FE34
		internal override sbyte GetSByte(global::System.Data.SQLite.SQLiteStatement stmt, int index)
		{
			return (sbyte)(this.GetInt32(stmt, index) & 255);
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00010A50 File Offset: 0x0000FE50
		internal override byte GetByte(global::System.Data.SQLite.SQLiteStatement stmt, int index)
		{
			return (byte)(this.GetInt32(stmt, index) & 255);
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00010A6C File Offset: 0x0000FE6C
		internal override short GetInt16(global::System.Data.SQLite.SQLiteStatement stmt, int index)
		{
			return (short)(this.GetInt32(stmt, index) & 65535);
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00010A88 File Offset: 0x0000FE88
		internal override ushort GetUInt16(global::System.Data.SQLite.SQLiteStatement stmt, int index)
		{
			return (ushort)(this.GetInt32(stmt, index) & 65535);
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00010AA4 File Offset: 0x0000FEA4
		internal override int GetInt32(global::System.Data.SQLite.SQLiteStatement stmt, int index)
		{
			return global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_column_int(stmt._sqlite_stmt, index);
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00010AC4 File Offset: 0x0000FEC4
		internal override uint GetUInt32(global::System.Data.SQLite.SQLiteStatement stmt, int index)
		{
			return (uint)this.GetInt32(stmt, index);
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00010ADC File Offset: 0x0000FEDC
		internal override long GetInt64(global::System.Data.SQLite.SQLiteStatement stmt, int index)
		{
			return global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_column_int64(stmt._sqlite_stmt, index);
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00010AFC File Offset: 0x0000FEFC
		internal override ulong GetUInt64(global::System.Data.SQLite.SQLiteStatement stmt, int index)
		{
			return (ulong)this.GetInt64(stmt, index);
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00010B14 File Offset: 0x0000FF14
		internal override string GetText(global::System.Data.SQLite.SQLiteStatement stmt, int index)
		{
			int nativestringlen;
			return global::System.Data.SQLite.SQLiteConvert.UTF8ToString(global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_column_text_interop(stmt._sqlite_stmt, index, out nativestringlen), nativestringlen);
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00010B3C File Offset: 0x0000FF3C
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
			int len;
			return base.ToDateTime(global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_column_text_interop(stmt._sqlite_stmt, index, out len), len);
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00010BBC File Offset: 0x0000FFBC
		internal override long GetBytes(global::System.Data.SQLite.SQLiteStatement stmt, int index, int nDataOffset, byte[] bDest, int nStart, int nLength)
		{
			int num = global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_column_bytes(stmt._sqlite_stmt, index);
			if (bDest == null)
			{
				return (long)num;
			}
			int num2 = nLength;
			if (num2 + nStart > bDest.Length)
			{
				num2 = bDest.Length - nStart;
			}
			if (num2 + nDataOffset > num)
			{
				num2 = num - nDataOffset;
			}
			if (num2 > 0)
			{
				global::System.Runtime.InteropServices.Marshal.Copy((global::System.IntPtr)(global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_column_blob(stmt._sqlite_stmt, index).ToInt64() + (long)nDataOffset), bDest, nStart, num2);
			}
			else
			{
				num2 = 0;
			}
			return (long)num2;
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00010C38 File Offset: 0x00010038
		internal override long GetChars(global::System.Data.SQLite.SQLiteStatement stmt, int index, int nDataOffset, char[] bDest, int nStart, int nLength)
		{
			int num = nLength;
			string text = this.GetText(stmt, index);
			int length = text.Length;
			if (bDest == null)
			{
				return (long)length;
			}
			if (num + nStart > bDest.Length)
			{
				num = bDest.Length - nStart;
			}
			if (num + nDataOffset > length)
			{
				num = length - nDataOffset;
			}
			if (num > 0)
			{
				text.CopyTo(nDataOffset, bDest, nStart, num);
			}
			else
			{
				num = 0;
			}
			return (long)num;
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00010C94 File Offset: 0x00010094
		internal override bool IsNull(global::System.Data.SQLite.SQLiteStatement stmt, int index)
		{
			return this.ColumnAffinity(stmt, index) == global::System.Data.SQLite.TypeAffinity.Null;
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00010CAC File Offset: 0x000100AC
		internal override int AggregateCount(global::System.IntPtr context)
		{
			return global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_aggregate_count(context);
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00010CC0 File Offset: 0x000100C0
		internal override void CreateFunction(string strFunction, int nArgs, bool needCollSeq, global::System.Data.SQLite.SQLiteCallback func, global::System.Data.SQLite.SQLiteCallback funcstep, global::System.Data.SQLite.SQLiteFinalCallback funcfinal)
		{
			global::System.Data.SQLite.SQLiteErrorCode sqliteErrorCode = global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_create_function_interop(this._sql, global::System.Data.SQLite.SQLiteConvert.ToUTF8(strFunction), nArgs, 4, global::System.IntPtr.Zero, func, funcstep, funcfinal, needCollSeq ? 1 : 0);
			if (sqliteErrorCode == global::System.Data.SQLite.SQLiteErrorCode.Ok)
			{
				sqliteErrorCode = global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_create_function_interop(this._sql, global::System.Data.SQLite.SQLiteConvert.ToUTF8(strFunction), nArgs, 1, global::System.IntPtr.Zero, func, funcstep, funcfinal, needCollSeq ? 1 : 0);
			}
			if (sqliteErrorCode != global::System.Data.SQLite.SQLiteErrorCode.Ok)
			{
				throw new global::System.Data.SQLite.SQLiteException(sqliteErrorCode, this.GetLastError());
			}
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00010D38 File Offset: 0x00010138
		internal override void CreateCollation(string strCollation, global::System.Data.SQLite.SQLiteCollation func, global::System.Data.SQLite.SQLiteCollation func16)
		{
			global::System.Data.SQLite.SQLiteErrorCode sqliteErrorCode = global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_create_collation(this._sql, global::System.Data.SQLite.SQLiteConvert.ToUTF8(strCollation), 2, global::System.IntPtr.Zero, func16);
			if (sqliteErrorCode == global::System.Data.SQLite.SQLiteErrorCode.Ok)
			{
				sqliteErrorCode = global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_create_collation(this._sql, global::System.Data.SQLite.SQLiteConvert.ToUTF8(strCollation), 1, global::System.IntPtr.Zero, func);
			}
			if (sqliteErrorCode != global::System.Data.SQLite.SQLiteErrorCode.Ok)
			{
				throw new global::System.Data.SQLite.SQLiteException(sqliteErrorCode, this.GetLastError());
			}
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00010D94 File Offset: 0x00010194
		internal override int ContextCollateCompare(global::System.Data.SQLite.CollationEncodingEnum enc, global::System.IntPtr context, string s1, string s2)
		{
			global::System.Text.Encoding encoding = null;
			switch (enc)
			{
			case global::System.Data.SQLite.CollationEncodingEnum.UTF8:
				encoding = global::System.Text.Encoding.UTF8;
				break;
			case global::System.Data.SQLite.CollationEncodingEnum.UTF16LE:
				encoding = global::System.Text.Encoding.Unicode;
				break;
			case global::System.Data.SQLite.CollationEncodingEnum.UTF16BE:
				encoding = global::System.Text.Encoding.BigEndianUnicode;
				break;
			}
			byte[] bytes = encoding.GetBytes(s1);
			byte[] bytes2 = encoding.GetBytes(s2);
			return global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_context_collcompare_interop(context, bytes, bytes.Length, bytes2, bytes2.Length);
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00010DF0 File Offset: 0x000101F0
		internal override int ContextCollateCompare(global::System.Data.SQLite.CollationEncodingEnum enc, global::System.IntPtr context, char[] c1, char[] c2)
		{
			global::System.Text.Encoding encoding = null;
			switch (enc)
			{
			case global::System.Data.SQLite.CollationEncodingEnum.UTF8:
				encoding = global::System.Text.Encoding.UTF8;
				break;
			case global::System.Data.SQLite.CollationEncodingEnum.UTF16LE:
				encoding = global::System.Text.Encoding.Unicode;
				break;
			case global::System.Data.SQLite.CollationEncodingEnum.UTF16BE:
				encoding = global::System.Text.Encoding.BigEndianUnicode;
				break;
			}
			byte[] bytes = encoding.GetBytes(c1);
			byte[] bytes2 = encoding.GetBytes(c2);
			return global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_context_collcompare_interop(context, bytes, bytes.Length, bytes2, bytes2.Length);
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00010E4C File Offset: 0x0001024C
		internal override global::System.Data.SQLite.CollationSequence GetCollationSequence(global::System.Data.SQLite.SQLiteFunction func, global::System.IntPtr context)
		{
			global::System.Data.SQLite.CollationSequence result = default(global::System.Data.SQLite.CollationSequence);
			int type;
			int encoding;
			int nativestringlen;
			global::System.IntPtr nativestring = global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_context_collseq_interop(context, out type, out encoding, out nativestringlen);
			result.Name = global::System.Data.SQLite.SQLiteConvert.UTF8ToString(nativestring, nativestringlen);
			result.Type = (global::System.Data.SQLite.CollationTypeEnum)type;
			result._func = func;
			result.Encoding = (global::System.Data.SQLite.CollationEncodingEnum)encoding;
			return result;
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00010E98 File Offset: 0x00010298
		internal override long GetParamValueBytes(global::System.IntPtr p, int nDataOffset, byte[] bDest, int nStart, int nLength)
		{
			int num = global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_value_bytes(p);
			if (bDest == null)
			{
				return (long)num;
			}
			int num2 = nLength;
			if (num2 + nStart > bDest.Length)
			{
				num2 = bDest.Length - nStart;
			}
			if (num2 + nDataOffset > num)
			{
				num2 = num - nDataOffset;
			}
			if (num2 > 0)
			{
				global::System.Runtime.InteropServices.Marshal.Copy((global::System.IntPtr)(global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_value_blob(p).ToInt64() + (long)nDataOffset), bDest, nStart, num2);
			}
			else
			{
				num2 = 0;
			}
			return (long)num2;
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x00010EF8 File Offset: 0x000102F8
		internal override double GetParamValueDouble(global::System.IntPtr ptr)
		{
			return global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_value_double(ptr);
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00010F10 File Offset: 0x00010310
		internal override int GetParamValueInt32(global::System.IntPtr ptr)
		{
			return global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_value_int(ptr);
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00010F24 File Offset: 0x00010324
		internal override long GetParamValueInt64(global::System.IntPtr ptr)
		{
			return global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_value_int64(ptr);
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00010F3C File Offset: 0x0001033C
		internal override string GetParamValueText(global::System.IntPtr ptr)
		{
			int nativestringlen;
			return global::System.Data.SQLite.SQLiteConvert.UTF8ToString(global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_value_text_interop(ptr, out nativestringlen), nativestringlen);
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00010F58 File Offset: 0x00010358
		internal override global::System.Data.SQLite.TypeAffinity GetParamValueType(global::System.IntPtr ptr)
		{
			return global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_value_type(ptr);
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00010F6C File Offset: 0x0001036C
		internal override void ReturnBlob(global::System.IntPtr context, byte[] value)
		{
			global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_result_blob(context, value, value.Length, (global::System.IntPtr)(-1));
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00010F8C File Offset: 0x0001038C
		internal override void ReturnDouble(global::System.IntPtr context, double value)
		{
			global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_result_double(context, value);
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00010FA0 File Offset: 0x000103A0
		internal override void ReturnError(global::System.IntPtr context, string value)
		{
			global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_result_error(context, global::System.Data.SQLite.SQLiteConvert.ToUTF8(value), value.Length);
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00010FC0 File Offset: 0x000103C0
		internal override void ReturnInt32(global::System.IntPtr context, int value)
		{
			global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_result_int(context, value);
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00010FD4 File Offset: 0x000103D4
		internal override void ReturnInt64(global::System.IntPtr context, long value)
		{
			global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_result_int64(context, value);
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00010FE8 File Offset: 0x000103E8
		internal override void ReturnNull(global::System.IntPtr context)
		{
			global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_result_null(context);
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00010FFC File Offset: 0x000103FC
		internal override void ReturnText(global::System.IntPtr context, string value)
		{
			byte[] array = global::System.Data.SQLite.SQLiteConvert.ToUTF8(value);
			global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_result_text(context, global::System.Data.SQLite.SQLiteConvert.ToUTF8(value), array.Length - 1, (global::System.IntPtr)(-1));
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00011028 File Offset: 0x00010428
		internal override void CreateModule(global::System.Data.SQLite.SQLiteModule module, global::System.Data.SQLite.SQLiteConnectionFlags flags)
		{
			if (module == null)
			{
				throw new global::System.ArgumentNullException("module");
			}
			if ((flags & global::System.Data.SQLite.SQLiteConnectionFlags.NoLogModule) != global::System.Data.SQLite.SQLiteConnectionFlags.NoLogModule)
			{
				module.LogErrors = ((flags & global::System.Data.SQLite.SQLiteConnectionFlags.LogModuleError) == global::System.Data.SQLite.SQLiteConnectionFlags.LogModuleError);
				module.LogExceptions = ((flags & global::System.Data.SQLite.SQLiteConnectionFlags.LogModuleException) == global::System.Data.SQLite.SQLiteConnectionFlags.LogModuleException);
			}
			if (this._sql == null)
			{
				throw new global::System.Data.SQLite.SQLiteException("connection has an invalid handle");
			}
			this.SetLoadExtension(true);
			this.LoadExtension("System.Data.SQLite.dll", "sqlite3_vtshim_init");
			if (!module.CreateDisposableModule(this._sql))
			{
				throw new global::System.Data.SQLite.SQLiteException(this.GetLastError());
			}
			if (this._modules == null)
			{
				this._modules = new global::System.Collections.Generic.Dictionary<string, global::System.Data.SQLite.SQLiteModule>();
			}
			this._modules.Add(module.Name, module);
			if (this._usePool)
			{
				this._usePool = false;
				return;
			}
		}

		// Token: 0x06000101 RID: 257 RVA: 0x000110F8 File Offset: 0x000104F8
		internal override void DisposeModule(global::System.Data.SQLite.SQLiteModule module, global::System.Data.SQLite.SQLiteConnectionFlags flags)
		{
			if (module == null)
			{
				throw new global::System.ArgumentNullException("module");
			}
			module.Dispose();
		}

		// Token: 0x06000102 RID: 258 RVA: 0x0001111C File Offset: 0x0001051C
		internal override global::System.IntPtr AggregateContext(global::System.IntPtr context)
		{
			return global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_aggregate_context(context, 1);
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00011130 File Offset: 0x00010530
		internal override global::System.Data.SQLite.SQLiteErrorCode DeclareVirtualTable(global::System.Data.SQLite.SQLiteModule module, string strSql, ref string error)
		{
			if (this._sql == null)
			{
				error = "connection has an invalid handle";
				return global::System.Data.SQLite.SQLiteErrorCode.Error;
			}
			global::System.IntPtr intPtr = global::System.IntPtr.Zero;
			global::System.Data.SQLite.SQLiteErrorCode result;
			try
			{
				intPtr = global::System.Data.SQLite.SQLiteString.Utf8IntPtrFromString(strSql);
				global::System.Data.SQLite.SQLiteErrorCode sqliteErrorCode = global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_declare_vtab(this._sql, intPtr);
				if (sqliteErrorCode == global::System.Data.SQLite.SQLiteErrorCode.Ok && module != null)
				{
					module.Declared = true;
				}
				if (sqliteErrorCode != global::System.Data.SQLite.SQLiteErrorCode.Ok)
				{
					error = this.GetLastError();
				}
				result = sqliteErrorCode;
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

		// Token: 0x06000104 RID: 260 RVA: 0x000111C0 File Offset: 0x000105C0
		internal override global::System.Data.SQLite.SQLiteErrorCode DeclareVirtualFunction(global::System.Data.SQLite.SQLiteModule module, int argumentCount, string name, ref string error)
		{
			if (this._sql == null)
			{
				error = "connection has an invalid handle";
				return global::System.Data.SQLite.SQLiteErrorCode.Error;
			}
			global::System.IntPtr intPtr = global::System.IntPtr.Zero;
			global::System.Data.SQLite.SQLiteErrorCode result;
			try
			{
				intPtr = global::System.Data.SQLite.SQLiteString.Utf8IntPtrFromString(name);
				global::System.Data.SQLite.SQLiteErrorCode sqliteErrorCode = global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_overload_function(this._sql, intPtr, argumentCount);
				if (sqliteErrorCode != global::System.Data.SQLite.SQLiteErrorCode.Ok)
				{
					error = this.GetLastError();
				}
				result = sqliteErrorCode;
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

		// Token: 0x06000105 RID: 261 RVA: 0x00011248 File Offset: 0x00010648
		internal override void SetLoadExtension(bool bOnOff)
		{
			global::System.Data.SQLite.SQLiteErrorCode sqliteErrorCode = global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_enable_load_extension(this._sql, bOnOff ? -1 : 0);
			if (sqliteErrorCode != global::System.Data.SQLite.SQLiteErrorCode.Ok)
			{
				throw new global::System.Data.SQLite.SQLiteException(sqliteErrorCode, this.GetLastError());
			}
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00011280 File Offset: 0x00010680
		internal override void LoadExtension(string fileName, string procName)
		{
			if (fileName == null)
			{
				throw new global::System.ArgumentNullException("fileName");
			}
			global::System.IntPtr zero = global::System.IntPtr.Zero;
			try
			{
				byte[] bytes = global::System.Text.Encoding.UTF8.GetBytes(fileName + '\0');
				byte[] procName2 = null;
				if (procName != null)
				{
					procName2 = global::System.Text.Encoding.UTF8.GetBytes(procName + '\0');
				}
				global::System.Data.SQLite.SQLiteErrorCode sqliteErrorCode = global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_load_extension(this._sql, bytes, procName2, ref zero);
				if (sqliteErrorCode != global::System.Data.SQLite.SQLiteErrorCode.Ok)
				{
					throw new global::System.Data.SQLite.SQLiteException(sqliteErrorCode, global::System.Data.SQLite.SQLiteConvert.UTF8ToString(zero, -1));
				}
			}
			finally
			{
				if (zero != global::System.IntPtr.Zero)
				{
					global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_free(zero);
					zero = global::System.IntPtr.Zero;
				}
			}
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00011334 File Offset: 0x00010734
		internal override void SetExtendedResultCodes(bool bOnOff)
		{
			global::System.Data.SQLite.SQLiteErrorCode sqliteErrorCode = global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_extended_result_codes(this._sql, bOnOff ? -1 : 0);
			if (sqliteErrorCode != global::System.Data.SQLite.SQLiteErrorCode.Ok)
			{
				throw new global::System.Data.SQLite.SQLiteException(sqliteErrorCode, this.GetLastError());
			}
		}

		// Token: 0x06000108 RID: 264 RVA: 0x0001136C File Offset: 0x0001076C
		internal override global::System.Data.SQLite.SQLiteErrorCode ResultCode()
		{
			return global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_errcode(this._sql);
		}

		// Token: 0x06000109 RID: 265 RVA: 0x0001138C File Offset: 0x0001078C
		internal override global::System.Data.SQLite.SQLiteErrorCode ExtendedResultCode()
		{
			return global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_extended_errcode(this._sql);
		}

		// Token: 0x0600010A RID: 266 RVA: 0x000113AC File Offset: 0x000107AC
		internal override void LogMessage(global::System.Data.SQLite.SQLiteErrorCode iErrCode, string zMessage)
		{
			global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_log(iErrCode, global::System.Data.SQLite.SQLiteConvert.ToUTF8(zMessage));
		}

		// Token: 0x0600010B RID: 267 RVA: 0x000113C8 File Offset: 0x000107C8
		internal override void SetPassword(byte[] passwordBytes)
		{
			global::System.Data.SQLite.SQLiteErrorCode sqliteErrorCode = global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_key(this._sql, passwordBytes, passwordBytes.Length);
			if (sqliteErrorCode != global::System.Data.SQLite.SQLiteErrorCode.Ok)
			{
				throw new global::System.Data.SQLite.SQLiteException(sqliteErrorCode, this.GetLastError());
			}
		}

		// Token: 0x0600010C RID: 268 RVA: 0x000113FC File Offset: 0x000107FC
		internal override void ChangePassword(byte[] newPasswordBytes)
		{
			global::System.Data.SQLite.SQLiteErrorCode sqliteErrorCode = global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_rekey(this._sql, newPasswordBytes, (newPasswordBytes == null) ? 0 : newPasswordBytes.Length);
			if (sqliteErrorCode != global::System.Data.SQLite.SQLiteErrorCode.Ok)
			{
				throw new global::System.Data.SQLite.SQLiteException(sqliteErrorCode, this.GetLastError());
			}
		}

		// Token: 0x0600010D RID: 269 RVA: 0x00011434 File Offset: 0x00010834
		internal override void SetAuthorizerHook(global::System.Data.SQLite.SQLiteAuthorizerCallback func)
		{
			global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_set_authorizer(this._sql, func, global::System.IntPtr.Zero);
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00011458 File Offset: 0x00010858
		internal override void SetUpdateHook(global::System.Data.SQLite.SQLiteUpdateCallback func)
		{
			global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_update_hook(this._sql, func, global::System.IntPtr.Zero);
		}

		// Token: 0x0600010F RID: 271 RVA: 0x0001147C File Offset: 0x0001087C
		internal override void SetCommitHook(global::System.Data.SQLite.SQLiteCommitCallback func)
		{
			global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_commit_hook(this._sql, func, global::System.IntPtr.Zero);
		}

		// Token: 0x06000110 RID: 272 RVA: 0x000114A0 File Offset: 0x000108A0
		internal override void SetTraceCallback(global::System.Data.SQLite.SQLiteTraceCallback func)
		{
			global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_trace(this._sql, func, global::System.IntPtr.Zero);
		}

		// Token: 0x06000111 RID: 273 RVA: 0x000114C4 File Offset: 0x000108C4
		internal override void SetRollbackHook(global::System.Data.SQLite.SQLiteRollbackCallback func)
		{
			global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_rollback_hook(this._sql, func, global::System.IntPtr.Zero);
		}

		// Token: 0x06000112 RID: 274 RVA: 0x000114E8 File Offset: 0x000108E8
		internal override global::System.Data.SQLite.SQLiteErrorCode SetLogCallback(global::System.Data.SQLite.SQLiteLogCallback func)
		{
			return global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_config_log(global::System.Data.SQLite.SQLiteConfigOpsEnum.SQLITE_CONFIG_LOG, func, global::System.IntPtr.Zero);
		}

		// Token: 0x06000113 RID: 275 RVA: 0x00011504 File Offset: 0x00010904
		internal override global::System.Data.SQLite.SQLiteBackup InitializeBackup(global::System.Data.SQLite.SQLiteConnection destCnn, string destName, string sourceName)
		{
			if (destCnn == null)
			{
				throw new global::System.ArgumentNullException("destCnn");
			}
			if (destName == null)
			{
				throw new global::System.ArgumentNullException("destName");
			}
			if (sourceName == null)
			{
				throw new global::System.ArgumentNullException("sourceName");
			}
			global::System.Data.SQLite.SQLite3 sqlite = destCnn._sql as global::System.Data.SQLite.SQLite3;
			if (sqlite == null)
			{
				throw new global::System.ArgumentException("Destination connection has no wrapper.", "destCnn");
			}
			global::System.Data.SQLite.SQLiteConnectionHandle sql = sqlite._sql;
			if (sql == null)
			{
				throw new global::System.ArgumentException("Destination connection has an invalid handle.", "destCnn");
			}
			global::System.Data.SQLite.SQLiteConnectionHandle sql2 = this._sql;
			if (sql2 == null)
			{
				throw new global::System.InvalidOperationException("Source connection has an invalid handle.");
			}
			byte[] zDestName = global::System.Data.SQLite.SQLiteConvert.ToUTF8(destName);
			byte[] zSourceName = global::System.Data.SQLite.SQLiteConvert.ToUTF8(sourceName);
			global::System.Data.SQLite.SQLiteBackupHandle sqliteBackupHandle = null;
			try
			{
			}
			finally
			{
				global::System.IntPtr intPtr = global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_backup_init(sql, zDestName, sql2, zSourceName);
				if (intPtr == global::System.IntPtr.Zero)
				{
					global::System.Data.SQLite.SQLiteErrorCode sqliteErrorCode = this.ResultCode();
					if (sqliteErrorCode != global::System.Data.SQLite.SQLiteErrorCode.Ok)
					{
						throw new global::System.Data.SQLite.SQLiteException(sqliteErrorCode, this.GetLastError());
					}
					throw new global::System.Data.SQLite.SQLiteException("failed to initialize backup");
				}
				else
				{
					sqliteBackupHandle = new global::System.Data.SQLite.SQLiteBackupHandle(sql, intPtr);
				}
			}
			global::System.Data.SQLite.SQLiteConnection.OnChanged(null, new global::System.Data.SQLite.ConnectionEventArgs(global::System.Data.SQLite.SQLiteConnectionEventType.NewCriticalHandle, null, null, null, null, sqliteBackupHandle, null, new object[]
			{
				destCnn,
				destName,
				sourceName
			}));
			return new global::System.Data.SQLite.SQLiteBackup(this, sqliteBackupHandle, sql, zDestName, sql2, zSourceName);
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00011650 File Offset: 0x00010A50
		internal override bool StepBackup(global::System.Data.SQLite.SQLiteBackup backup, int nPage, out bool retry)
		{
			retry = false;
			if (backup == null)
			{
				throw new global::System.ArgumentNullException("backup");
			}
			global::System.Data.SQLite.SQLiteBackupHandle sqlite_backup = backup._sqlite_backup;
			if (sqlite_backup == null)
			{
				throw new global::System.InvalidOperationException("Backup object has an invalid handle.");
			}
			global::System.IntPtr intPtr = sqlite_backup;
			if (intPtr == global::System.IntPtr.Zero)
			{
				throw new global::System.InvalidOperationException("Backup object has an invalid handle pointer.");
			}
			global::System.Data.SQLite.SQLiteErrorCode sqliteErrorCode = global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_backup_step(intPtr, nPage);
			backup._stepResult = sqliteErrorCode;
			if (sqliteErrorCode == global::System.Data.SQLite.SQLiteErrorCode.Ok)
			{
				return true;
			}
			if (sqliteErrorCode == global::System.Data.SQLite.SQLiteErrorCode.Busy)
			{
				retry = true;
				return true;
			}
			if (sqliteErrorCode == global::System.Data.SQLite.SQLiteErrorCode.Locked)
			{
				retry = true;
				return true;
			}
			if (sqliteErrorCode == global::System.Data.SQLite.SQLiteErrorCode.Done)
			{
				return false;
			}
			throw new global::System.Data.SQLite.SQLiteException(sqliteErrorCode, this.GetLastError());
		}

		// Token: 0x06000115 RID: 277 RVA: 0x000116DC File Offset: 0x00010ADC
		internal override int RemainingBackup(global::System.Data.SQLite.SQLiteBackup backup)
		{
			if (backup == null)
			{
				throw new global::System.ArgumentNullException("backup");
			}
			global::System.Data.SQLite.SQLiteBackupHandle sqlite_backup = backup._sqlite_backup;
			if (sqlite_backup == null)
			{
				throw new global::System.InvalidOperationException("Backup object has an invalid handle.");
			}
			global::System.IntPtr intPtr = sqlite_backup;
			if (intPtr == global::System.IntPtr.Zero)
			{
				throw new global::System.InvalidOperationException("Backup object has an invalid handle pointer.");
			}
			return global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_backup_remaining(intPtr);
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00011734 File Offset: 0x00010B34
		internal override int PageCountBackup(global::System.Data.SQLite.SQLiteBackup backup)
		{
			if (backup == null)
			{
				throw new global::System.ArgumentNullException("backup");
			}
			global::System.Data.SQLite.SQLiteBackupHandle sqlite_backup = backup._sqlite_backup;
			if (sqlite_backup == null)
			{
				throw new global::System.InvalidOperationException("Backup object has an invalid handle.");
			}
			global::System.IntPtr intPtr = sqlite_backup;
			if (intPtr == global::System.IntPtr.Zero)
			{
				throw new global::System.InvalidOperationException("Backup object has an invalid handle pointer.");
			}
			return global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_backup_pagecount(intPtr);
		}

		// Token: 0x06000117 RID: 279 RVA: 0x0001178C File Offset: 0x00010B8C
		internal override void FinishBackup(global::System.Data.SQLite.SQLiteBackup backup)
		{
			if (backup == null)
			{
				throw new global::System.ArgumentNullException("backup");
			}
			global::System.Data.SQLite.SQLiteBackupHandle sqlite_backup = backup._sqlite_backup;
			if (sqlite_backup == null)
			{
				throw new global::System.InvalidOperationException("Backup object has an invalid handle.");
			}
			global::System.IntPtr intPtr = sqlite_backup;
			if (intPtr == global::System.IntPtr.Zero)
			{
				throw new global::System.InvalidOperationException("Backup object has an invalid handle pointer.");
			}
			global::System.Data.SQLite.SQLiteErrorCode sqliteErrorCode = global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_backup_finish_interop(intPtr);
			sqlite_backup.SetHandleAsInvalid();
			if (sqliteErrorCode != global::System.Data.SQLite.SQLiteErrorCode.Ok && sqliteErrorCode != backup._stepResult)
			{
				throw new global::System.Data.SQLite.SQLiteException(sqliteErrorCode, this.GetLastError());
			}
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00011804 File Offset: 0x00010C04
		internal override bool IsInitialized()
		{
			return global::System.Data.SQLite.SQLite3.StaticIsInitialized();
		}

		// Token: 0x06000119 RID: 281 RVA: 0x00011818 File Offset: 0x00010C18
		internal static bool StaticIsInitialized()
		{
			bool result;
			lock (global::System.Data.SQLite.SQLite3.syncRoot)
			{
				bool enabled = global::System.Data.SQLite.SQLiteLog.Enabled;
				global::System.Data.SQLite.SQLiteLog.Enabled = false;
				try
				{
					global::System.Data.SQLite.SQLiteErrorCode sqliteErrorCode = global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_config_none(global::System.Data.SQLite.SQLiteConfigOpsEnum.SQLITE_CONFIG_NONE);
					result = (sqliteErrorCode == global::System.Data.SQLite.SQLiteErrorCode.Misuse);
				}
				finally
				{
					global::System.Data.SQLite.SQLiteLog.Enabled = enabled;
				}
			}
			return result;
		}

		// Token: 0x0600011A RID: 282 RVA: 0x0001189C File Offset: 0x00010C9C
		internal override object GetValue(global::System.Data.SQLite.SQLiteStatement stmt, global::System.Data.SQLite.SQLiteConnectionFlags flags, int index, global::System.Data.SQLite.SQLiteType typ)
		{
			if (this.IsNull(stmt, index))
			{
				return global::System.DBNull.Value;
			}
			global::System.Data.SQLite.TypeAffinity typeAffinity = typ.Affinity;
			global::System.Type type = null;
			if (typ.Type != global::System.Data.DbType.Object)
			{
				type = global::System.Data.SQLite.SQLiteConvert.SQLiteTypeToType(typ);
				typeAffinity = global::System.Data.SQLite.SQLiteConvert.TypeToAffinity(type);
			}
			if ((flags & global::System.Data.SQLite.SQLiteConnectionFlags.GetAllAsText) == global::System.Data.SQLite.SQLiteConnectionFlags.GetAllAsText)
			{
				return this.GetText(stmt, index);
			}
			global::System.Data.SQLite.TypeAffinity typeAffinity2 = typeAffinity;
			switch (typeAffinity2)
			{
			case global::System.Data.SQLite.TypeAffinity.Int64:
				if (type == null)
				{
					return this.GetInt64(stmt, index);
				}
				if (type == typeof(sbyte))
				{
					return this.GetSByte(stmt, index);
				}
				if (type == typeof(byte))
				{
					return this.GetByte(stmt, index);
				}
				if (type == typeof(short))
				{
					return this.GetInt16(stmt, index);
				}
				if (type == typeof(ushort))
				{
					return this.GetUInt16(stmt, index);
				}
				if (type == typeof(int))
				{
					return this.GetInt32(stmt, index);
				}
				if (type == typeof(uint))
				{
					return this.GetUInt32(stmt, index);
				}
				if (type == typeof(ulong))
				{
					return this.GetUInt64(stmt, index);
				}
				return global::System.Convert.ChangeType(this.GetInt64(stmt, index), type, null);
			case global::System.Data.SQLite.TypeAffinity.Double:
				if (type == null)
				{
					return this.GetDouble(stmt, index);
				}
				return global::System.Convert.ChangeType(this.GetDouble(stmt, index), type, null);
			case global::System.Data.SQLite.TypeAffinity.Text:
				break;
			case global::System.Data.SQLite.TypeAffinity.Blob:
			{
				if (typ.Type == global::System.Data.DbType.Guid && typ.Affinity == global::System.Data.SQLite.TypeAffinity.Text)
				{
					return new global::System.Guid(this.GetText(stmt, index));
				}
				int num = (int)this.GetBytes(stmt, index, 0, null, 0, 0);
				byte[] array = new byte[num];
				this.GetBytes(stmt, index, 0, array, 0, num);
				if (typ.Type == global::System.Data.DbType.Guid && num == 16)
				{
					return new global::System.Guid(array);
				}
				return array;
			}
			default:
				if (typeAffinity2 == global::System.Data.SQLite.TypeAffinity.DateTime)
				{
					return this.GetDateTime(stmt, index);
				}
				break;
			}
			return this.GetText(stmt, index);
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00011AD4 File Offset: 0x00010ED4
		internal override int GetCursorForTable(global::System.Data.SQLite.SQLiteStatement stmt, int db, int rootPage)
		{
			return global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_table_cursor_interop(stmt._sqlite_stmt, db, rootPage);
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00011AF4 File Offset: 0x00010EF4
		internal override long GetRowIdForCursor(global::System.Data.SQLite.SQLiteStatement stmt, int cursor)
		{
			long result;
			if (global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_cursor_rowid_interop(stmt._sqlite_stmt, cursor, out result) == global::System.Data.SQLite.SQLiteErrorCode.Ok)
			{
				return result;
			}
			return 0L;
		}

		// Token: 0x0600011D RID: 285 RVA: 0x00011B1C File Offset: 0x00010F1C
		internal override void GetIndexColumnExtendedInfo(string database, string index, string column, out int sortMode, out int onError, out string collationSequence)
		{
			global::System.IntPtr nativestring;
			int nativestringlen;
			global::System.Data.SQLite.SQLiteErrorCode sqliteErrorCode = global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_index_column_info_interop(this._sql, global::System.Data.SQLite.SQLiteConvert.ToUTF8(database), global::System.Data.SQLite.SQLiteConvert.ToUTF8(index), global::System.Data.SQLite.SQLiteConvert.ToUTF8(column), out sortMode, out onError, out nativestring, out nativestringlen);
			if (sqliteErrorCode != global::System.Data.SQLite.SQLiteErrorCode.Ok)
			{
				throw new global::System.Data.SQLite.SQLiteException(sqliteErrorCode, null);
			}
			collationSequence = global::System.Data.SQLite.SQLiteConvert.UTF8ToString(nativestring, nativestringlen);
		}

		// Token: 0x0600011E RID: 286 RVA: 0x00011B6C File Offset: 0x00010F6C
		internal override global::System.Data.SQLite.SQLiteErrorCode FileControl(string zDbName, int op, global::System.IntPtr pArg)
		{
			return global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_file_control(this._sql, (zDbName != null) ? global::System.Data.SQLite.SQLiteConvert.ToUTF8(zDbName) : null, op, pArg);
		}

		// Token: 0x04000019 RID: 25
		internal const string PublicKey = "002400000480000094000000060200000024000052534131000400000100010005a288de5687c4e1b621ddff5d844727418956997f475eb829429e411aff3e93f97b70de698b972640925bdd44280df0a25a843266973704137cbb0e7441c1fe7cae4e2440ae91ab8cde3933febcb1ac48dd33b40e13c421d8215c18a4349a436dd499e3c385cc683015f886f6c10bd90115eb2bd61b67750839e3a19941dc9c";

		// Token: 0x0400001A RID: 26
		internal const string DesignerVersion = "1.0.89.0";

		// Token: 0x0400001B RID: 27
		private static object syncRoot = new object();

		// Token: 0x0400001C RID: 28
		protected internal global::System.Data.SQLite.SQLiteConnectionHandle _sql;

		// Token: 0x0400001D RID: 29
		protected string _fileName;

		// Token: 0x0400001E RID: 30
		protected bool _usePool;

		// Token: 0x0400001F RID: 31
		protected int _poolVersion;

		// Token: 0x04000020 RID: 32
		private bool _buildingSchema;

		// Token: 0x04000021 RID: 33
		protected global::System.Collections.Generic.List<global::System.Data.SQLite.SQLiteFunction> _functions;

		// Token: 0x04000022 RID: 34
		protected global::System.Collections.Generic.Dictionary<string, global::System.Data.SQLite.SQLiteModule> _modules;

		// Token: 0x04000023 RID: 35
		private bool disposed;
	}
}
