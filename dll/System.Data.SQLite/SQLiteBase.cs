using System;
using System.Runtime.InteropServices;

namespace System.Data.SQLite
{
	// Token: 0x02000006 RID: 6
	internal abstract class SQLiteBase : global::System.Data.SQLite.SQLiteConvert, global::System.IDisposable
	{
		// Token: 0x06000029 RID: 41 RVA: 0x0000EE00 File Offset: 0x0000E200
		internal SQLiteBase(global::System.Data.SQLite.SQLiteDateFormats fmt, global::System.DateTimeKind kind, string fmtString) : base(fmt, kind, fmtString)
		{
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600002A RID: 42
		internal abstract string Version { get; }

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600002B RID: 43
		internal abstract int VersionNumber { get; }

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600002C RID: 44
		internal abstract long LastInsertRowId { get; }

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600002D RID: 45
		internal abstract int Changes { get; }

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600002E RID: 46
		internal abstract long MemoryUsed { get; }

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600002F RID: 47
		internal abstract long MemoryHighwater { get; }

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000030 RID: 48
		internal abstract bool OwnHandle { get; }

		// Token: 0x06000031 RID: 49
		internal abstract global::System.Data.SQLite.SQLiteErrorCode SetMemoryStatus(bool value);

		// Token: 0x06000032 RID: 50
		internal abstract global::System.Data.SQLite.SQLiteErrorCode Shutdown();

		// Token: 0x06000033 RID: 51
		internal abstract bool IsOpen();

		// Token: 0x06000034 RID: 52
		internal abstract void Open(string strFilename, global::System.Data.SQLite.SQLiteConnectionFlags connectionFlags, global::System.Data.SQLite.SQLiteOpenFlagsEnum openFlags, int maxPoolSize, bool usePool);

		// Token: 0x06000035 RID: 53
		internal abstract void Close(bool canThrow);

		// Token: 0x06000036 RID: 54
		internal abstract void SetTimeout(int nTimeoutMS);

		// Token: 0x06000037 RID: 55
		internal abstract string GetLastError();

		// Token: 0x06000038 RID: 56
		internal abstract void ClearPool();

		// Token: 0x06000039 RID: 57
		internal abstract int CountPool();

		// Token: 0x0600003A RID: 58
		internal abstract global::System.Data.SQLite.SQLiteStatement Prepare(global::System.Data.SQLite.SQLiteConnection cnn, string strSql, global::System.Data.SQLite.SQLiteStatement previous, uint timeoutMS, out string strRemain);

		// Token: 0x0600003B RID: 59
		internal abstract bool Step(global::System.Data.SQLite.SQLiteStatement stmt);

		// Token: 0x0600003C RID: 60
		internal abstract global::System.Data.SQLite.SQLiteErrorCode Reset(global::System.Data.SQLite.SQLiteStatement stmt);

		// Token: 0x0600003D RID: 61
		internal abstract void Cancel();

		// Token: 0x0600003E RID: 62
		internal abstract void BindFunction(global::System.Data.SQLite.SQLiteFunctionAttribute functionAttribute, global::System.Data.SQLite.SQLiteFunction function, global::System.Data.SQLite.SQLiteConnectionFlags flags);

		// Token: 0x0600003F RID: 63
		internal abstract void Bind_Double(global::System.Data.SQLite.SQLiteStatement stmt, global::System.Data.SQLite.SQLiteConnectionFlags flags, int index, double value);

		// Token: 0x06000040 RID: 64
		internal abstract void Bind_Int32(global::System.Data.SQLite.SQLiteStatement stmt, global::System.Data.SQLite.SQLiteConnectionFlags flags, int index, int value);

		// Token: 0x06000041 RID: 65
		internal abstract void Bind_UInt32(global::System.Data.SQLite.SQLiteStatement stmt, global::System.Data.SQLite.SQLiteConnectionFlags flags, int index, uint value);

		// Token: 0x06000042 RID: 66
		internal abstract void Bind_Int64(global::System.Data.SQLite.SQLiteStatement stmt, global::System.Data.SQLite.SQLiteConnectionFlags flags, int index, long value);

		// Token: 0x06000043 RID: 67
		internal abstract void Bind_UInt64(global::System.Data.SQLite.SQLiteStatement stmt, global::System.Data.SQLite.SQLiteConnectionFlags flags, int index, ulong value);

		// Token: 0x06000044 RID: 68
		internal abstract void Bind_Text(global::System.Data.SQLite.SQLiteStatement stmt, global::System.Data.SQLite.SQLiteConnectionFlags flags, int index, string value);

		// Token: 0x06000045 RID: 69
		internal abstract void Bind_Blob(global::System.Data.SQLite.SQLiteStatement stmt, global::System.Data.SQLite.SQLiteConnectionFlags flags, int index, byte[] blobData);

		// Token: 0x06000046 RID: 70
		internal abstract void Bind_DateTime(global::System.Data.SQLite.SQLiteStatement stmt, global::System.Data.SQLite.SQLiteConnectionFlags flags, int index, global::System.DateTime dt);

		// Token: 0x06000047 RID: 71
		internal abstract void Bind_Null(global::System.Data.SQLite.SQLiteStatement stmt, global::System.Data.SQLite.SQLiteConnectionFlags flags, int index);

		// Token: 0x06000048 RID: 72
		internal abstract int Bind_ParamCount(global::System.Data.SQLite.SQLiteStatement stmt, global::System.Data.SQLite.SQLiteConnectionFlags flags);

		// Token: 0x06000049 RID: 73
		internal abstract string Bind_ParamName(global::System.Data.SQLite.SQLiteStatement stmt, global::System.Data.SQLite.SQLiteConnectionFlags flags, int index);

		// Token: 0x0600004A RID: 74
		internal abstract int Bind_ParamIndex(global::System.Data.SQLite.SQLiteStatement stmt, global::System.Data.SQLite.SQLiteConnectionFlags flags, string paramName);

		// Token: 0x0600004B RID: 75
		internal abstract int ColumnCount(global::System.Data.SQLite.SQLiteStatement stmt);

		// Token: 0x0600004C RID: 76
		internal abstract string ColumnName(global::System.Data.SQLite.SQLiteStatement stmt, int index);

		// Token: 0x0600004D RID: 77
		internal abstract global::System.Data.SQLite.TypeAffinity ColumnAffinity(global::System.Data.SQLite.SQLiteStatement stmt, int index);

		// Token: 0x0600004E RID: 78
		internal abstract string ColumnType(global::System.Data.SQLite.SQLiteStatement stmt, int index, out global::System.Data.SQLite.TypeAffinity nAffinity);

		// Token: 0x0600004F RID: 79
		internal abstract int ColumnIndex(global::System.Data.SQLite.SQLiteStatement stmt, string columnName);

		// Token: 0x06000050 RID: 80
		internal abstract string ColumnOriginalName(global::System.Data.SQLite.SQLiteStatement stmt, int index);

		// Token: 0x06000051 RID: 81
		internal abstract string ColumnDatabaseName(global::System.Data.SQLite.SQLiteStatement stmt, int index);

		// Token: 0x06000052 RID: 82
		internal abstract string ColumnTableName(global::System.Data.SQLite.SQLiteStatement stmt, int index);

		// Token: 0x06000053 RID: 83
		internal abstract void ColumnMetaData(string dataBase, string table, string column, out string dataType, out string collateSequence, out bool notNull, out bool primaryKey, out bool autoIncrement);

		// Token: 0x06000054 RID: 84
		internal abstract void GetIndexColumnExtendedInfo(string database, string index, string column, out int sortMode, out int onError, out string collationSequence);

		// Token: 0x06000055 RID: 85
		internal abstract double GetDouble(global::System.Data.SQLite.SQLiteStatement stmt, int index);

		// Token: 0x06000056 RID: 86
		internal abstract sbyte GetSByte(global::System.Data.SQLite.SQLiteStatement stmt, int index);

		// Token: 0x06000057 RID: 87
		internal abstract byte GetByte(global::System.Data.SQLite.SQLiteStatement stmt, int index);

		// Token: 0x06000058 RID: 88
		internal abstract short GetInt16(global::System.Data.SQLite.SQLiteStatement stmt, int index);

		// Token: 0x06000059 RID: 89
		internal abstract ushort GetUInt16(global::System.Data.SQLite.SQLiteStatement stmt, int index);

		// Token: 0x0600005A RID: 90
		internal abstract int GetInt32(global::System.Data.SQLite.SQLiteStatement stmt, int index);

		// Token: 0x0600005B RID: 91
		internal abstract uint GetUInt32(global::System.Data.SQLite.SQLiteStatement stmt, int index);

		// Token: 0x0600005C RID: 92
		internal abstract long GetInt64(global::System.Data.SQLite.SQLiteStatement stmt, int index);

		// Token: 0x0600005D RID: 93
		internal abstract ulong GetUInt64(global::System.Data.SQLite.SQLiteStatement stmt, int index);

		// Token: 0x0600005E RID: 94
		internal abstract string GetText(global::System.Data.SQLite.SQLiteStatement stmt, int index);

		// Token: 0x0600005F RID: 95
		internal abstract long GetBytes(global::System.Data.SQLite.SQLiteStatement stmt, int index, int nDataoffset, byte[] bDest, int nStart, int nLength);

		// Token: 0x06000060 RID: 96
		internal abstract long GetChars(global::System.Data.SQLite.SQLiteStatement stmt, int index, int nDataoffset, char[] bDest, int nStart, int nLength);

		// Token: 0x06000061 RID: 97
		internal abstract global::System.DateTime GetDateTime(global::System.Data.SQLite.SQLiteStatement stmt, int index);

		// Token: 0x06000062 RID: 98
		internal abstract bool IsNull(global::System.Data.SQLite.SQLiteStatement stmt, int index);

		// Token: 0x06000063 RID: 99
		internal abstract void CreateCollation(string strCollation, global::System.Data.SQLite.SQLiteCollation func, global::System.Data.SQLite.SQLiteCollation func16);

		// Token: 0x06000064 RID: 100
		internal abstract void CreateFunction(string strFunction, int nArgs, bool needCollSeq, global::System.Data.SQLite.SQLiteCallback func, global::System.Data.SQLite.SQLiteCallback funcstep, global::System.Data.SQLite.SQLiteFinalCallback funcfinal);

		// Token: 0x06000065 RID: 101
		internal abstract global::System.Data.SQLite.CollationSequence GetCollationSequence(global::System.Data.SQLite.SQLiteFunction func, global::System.IntPtr context);

		// Token: 0x06000066 RID: 102
		internal abstract int ContextCollateCompare(global::System.Data.SQLite.CollationEncodingEnum enc, global::System.IntPtr context, string s1, string s2);

		// Token: 0x06000067 RID: 103
		internal abstract int ContextCollateCompare(global::System.Data.SQLite.CollationEncodingEnum enc, global::System.IntPtr context, char[] c1, char[] c2);

		// Token: 0x06000068 RID: 104
		internal abstract int AggregateCount(global::System.IntPtr context);

		// Token: 0x06000069 RID: 105
		internal abstract global::System.IntPtr AggregateContext(global::System.IntPtr context);

		// Token: 0x0600006A RID: 106
		internal abstract long GetParamValueBytes(global::System.IntPtr ptr, int nDataOffset, byte[] bDest, int nStart, int nLength);

		// Token: 0x0600006B RID: 107
		internal abstract double GetParamValueDouble(global::System.IntPtr ptr);

		// Token: 0x0600006C RID: 108
		internal abstract int GetParamValueInt32(global::System.IntPtr ptr);

		// Token: 0x0600006D RID: 109
		internal abstract long GetParamValueInt64(global::System.IntPtr ptr);

		// Token: 0x0600006E RID: 110
		internal abstract string GetParamValueText(global::System.IntPtr ptr);

		// Token: 0x0600006F RID: 111
		internal abstract global::System.Data.SQLite.TypeAffinity GetParamValueType(global::System.IntPtr ptr);

		// Token: 0x06000070 RID: 112
		internal abstract void ReturnBlob(global::System.IntPtr context, byte[] value);

		// Token: 0x06000071 RID: 113
		internal abstract void ReturnDouble(global::System.IntPtr context, double value);

		// Token: 0x06000072 RID: 114
		internal abstract void ReturnError(global::System.IntPtr context, string value);

		// Token: 0x06000073 RID: 115
		internal abstract void ReturnInt32(global::System.IntPtr context, int value);

		// Token: 0x06000074 RID: 116
		internal abstract void ReturnInt64(global::System.IntPtr context, long value);

		// Token: 0x06000075 RID: 117
		internal abstract void ReturnNull(global::System.IntPtr context);

		// Token: 0x06000076 RID: 118
		internal abstract void ReturnText(global::System.IntPtr context, string value);

		// Token: 0x06000077 RID: 119
		internal abstract void CreateModule(global::System.Data.SQLite.SQLiteModule module, global::System.Data.SQLite.SQLiteConnectionFlags flags);

		// Token: 0x06000078 RID: 120
		internal abstract void DisposeModule(global::System.Data.SQLite.SQLiteModule module, global::System.Data.SQLite.SQLiteConnectionFlags flags);

		// Token: 0x06000079 RID: 121
		internal abstract global::System.Data.SQLite.SQLiteErrorCode DeclareVirtualTable(global::System.Data.SQLite.SQLiteModule module, string strSql, ref string error);

		// Token: 0x0600007A RID: 122
		internal abstract global::System.Data.SQLite.SQLiteErrorCode DeclareVirtualFunction(global::System.Data.SQLite.SQLiteModule module, int argumentCount, string name, ref string error);

		// Token: 0x0600007B RID: 123
		internal abstract void SetLoadExtension(bool bOnOff);

		// Token: 0x0600007C RID: 124
		internal abstract void LoadExtension(string fileName, string procName);

		// Token: 0x0600007D RID: 125
		internal abstract void SetExtendedResultCodes(bool bOnOff);

		// Token: 0x0600007E RID: 126
		internal abstract global::System.Data.SQLite.SQLiteErrorCode ResultCode();

		// Token: 0x0600007F RID: 127
		internal abstract global::System.Data.SQLite.SQLiteErrorCode ExtendedResultCode();

		// Token: 0x06000080 RID: 128
		internal abstract void LogMessage(global::System.Data.SQLite.SQLiteErrorCode iErrCode, string zMessage);

		// Token: 0x06000081 RID: 129
		internal abstract void SetPassword(byte[] passwordBytes);

		// Token: 0x06000082 RID: 130
		internal abstract void ChangePassword(byte[] newPasswordBytes);

		// Token: 0x06000083 RID: 131
		internal abstract void SetAuthorizerHook(global::System.Data.SQLite.SQLiteAuthorizerCallback func);

		// Token: 0x06000084 RID: 132
		internal abstract void SetUpdateHook(global::System.Data.SQLite.SQLiteUpdateCallback func);

		// Token: 0x06000085 RID: 133
		internal abstract void SetCommitHook(global::System.Data.SQLite.SQLiteCommitCallback func);

		// Token: 0x06000086 RID: 134
		internal abstract void SetTraceCallback(global::System.Data.SQLite.SQLiteTraceCallback func);

		// Token: 0x06000087 RID: 135
		internal abstract void SetRollbackHook(global::System.Data.SQLite.SQLiteRollbackCallback func);

		// Token: 0x06000088 RID: 136
		internal abstract global::System.Data.SQLite.SQLiteErrorCode SetLogCallback(global::System.Data.SQLite.SQLiteLogCallback func);

		// Token: 0x06000089 RID: 137
		internal abstract bool IsInitialized();

		// Token: 0x0600008A RID: 138
		internal abstract int GetCursorForTable(global::System.Data.SQLite.SQLiteStatement stmt, int database, int rootPage);

		// Token: 0x0600008B RID: 139
		internal abstract long GetRowIdForCursor(global::System.Data.SQLite.SQLiteStatement stmt, int cursor);

		// Token: 0x0600008C RID: 140
		internal abstract object GetValue(global::System.Data.SQLite.SQLiteStatement stmt, global::System.Data.SQLite.SQLiteConnectionFlags flags, int index, global::System.Data.SQLite.SQLiteType typ);

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600008D RID: 141
		internal abstract bool AutoCommit { get; }

		// Token: 0x0600008E RID: 142
		internal abstract global::System.Data.SQLite.SQLiteErrorCode FileControl(string zDbName, int op, global::System.IntPtr pArg);

		// Token: 0x0600008F RID: 143
		internal abstract global::System.Data.SQLite.SQLiteBackup InitializeBackup(global::System.Data.SQLite.SQLiteConnection destCnn, string destName, string sourceName);

		// Token: 0x06000090 RID: 144
		internal abstract bool StepBackup(global::System.Data.SQLite.SQLiteBackup backup, int nPage, out bool retry);

		// Token: 0x06000091 RID: 145
		internal abstract int RemainingBackup(global::System.Data.SQLite.SQLiteBackup backup);

		// Token: 0x06000092 RID: 146
		internal abstract int PageCountBackup(global::System.Data.SQLite.SQLiteBackup backup);

		// Token: 0x06000093 RID: 147
		internal abstract void FinishBackup(global::System.Data.SQLite.SQLiteBackup backup);

		// Token: 0x06000094 RID: 148 RVA: 0x0000EE18 File Offset: 0x0000E218
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x06000095 RID: 149 RVA: 0x0000EE34 File Offset: 0x0000E234
		private void CheckDisposed()
		{
			if (this.disposed)
			{
				throw new global::System.ObjectDisposedException(typeof(global::System.Data.SQLite.SQLiteBase).Name);
			}
		}

		// Token: 0x06000096 RID: 150 RVA: 0x0000EE60 File Offset: 0x0000E260
		protected virtual void Dispose(bool disposing)
		{
			if (!this.disposed)
			{
				this.disposed = true;
			}
		}

		// Token: 0x06000097 RID: 151 RVA: 0x0000EE7C File Offset: 0x0000E27C
		~SQLiteBase()
		{
			this.Dispose(false);
		}

		// Token: 0x06000098 RID: 152 RVA: 0x0000EEB8 File Offset: 0x0000E2B8
		private static string FallbackGetErrorString(global::System.Data.SQLite.SQLiteErrorCode rc)
		{
			if (global::System.Data.SQLite.SQLiteBase._errorMessages == null)
			{
				return null;
			}
			int num = (int)rc;
			if (num < 0 || num >= global::System.Data.SQLite.SQLiteBase._errorMessages.Length)
			{
				num = 1;
			}
			return global::System.Data.SQLite.SQLiteBase._errorMessages[num];
		}

		// Token: 0x06000099 RID: 153 RVA: 0x0000EEE8 File Offset: 0x0000E2E8
		internal static string GetErrorString(global::System.Data.SQLite.SQLiteErrorCode rc)
		{
			try
			{
				global::System.IntPtr intPtr = global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_errstr(rc);
				if (intPtr != global::System.IntPtr.Zero)
				{
					return global::System.Runtime.InteropServices.Marshal.PtrToStringAnsi(intPtr);
				}
			}
			catch (global::System.EntryPointNotFoundException)
			{
			}
			return global::System.Data.SQLite.SQLiteBase.FallbackGetErrorString(rc);
		}

		// Token: 0x0600009A RID: 154 RVA: 0x0000EF3C File Offset: 0x0000E33C
		internal static string GetLastError(global::System.Data.SQLite.SQLiteConnectionHandle hdl, global::System.IntPtr db)
		{
			if (hdl == null || db == global::System.IntPtr.Zero)
			{
				return "null connection or database handle";
			}
			string result = null;
			try
			{
			}
			finally
			{
				lock (hdl)
				{
					if (!hdl.IsInvalid && !hdl.IsClosed)
					{
						int nativestringlen;
						result = global::System.Data.SQLite.SQLiteConvert.UTF8ToString(global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_errmsg_interop(db, out nativestringlen), nativestringlen);
					}
					else
					{
						result = "closed or invalid connection handle";
					}
				}
			}
			global::System.GC.KeepAlive(hdl);
			return result;
		}

		// Token: 0x0600009B RID: 155 RVA: 0x0000EFE0 File Offset: 0x0000E3E0
		internal static void FinishBackup(global::System.Data.SQLite.SQLiteConnectionHandle hdl, global::System.IntPtr backup)
		{
			if (hdl == null || backup == global::System.IntPtr.Zero)
			{
				return;
			}
			try
			{
			}
			finally
			{
				lock (hdl)
				{
					global::System.Data.SQLite.SQLiteErrorCode sqliteErrorCode = global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_backup_finish_interop(backup);
					if (sqliteErrorCode != global::System.Data.SQLite.SQLiteErrorCode.Ok)
					{
						throw new global::System.Data.SQLite.SQLiteException(sqliteErrorCode, null);
					}
				}
			}
		}

		// Token: 0x0600009C RID: 156 RVA: 0x0000F060 File Offset: 0x0000E460
		internal static void FinalizeStatement(global::System.Data.SQLite.SQLiteConnectionHandle hdl, global::System.IntPtr stmt)
		{
			if (hdl == null || stmt == global::System.IntPtr.Zero)
			{
				return;
			}
			try
			{
			}
			finally
			{
				lock (hdl)
				{
					global::System.Data.SQLite.SQLiteErrorCode sqliteErrorCode = global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_finalize_interop(stmt);
					if (sqliteErrorCode != global::System.Data.SQLite.SQLiteErrorCode.Ok)
					{
						throw new global::System.Data.SQLite.SQLiteException(sqliteErrorCode, null);
					}
				}
			}
		}

		// Token: 0x0600009D RID: 157 RVA: 0x0000F0E0 File Offset: 0x0000E4E0
		internal static void CloseConnection(global::System.Data.SQLite.SQLiteConnectionHandle hdl, global::System.IntPtr db)
		{
			if (hdl == null || db == global::System.IntPtr.Zero)
			{
				return;
			}
			try
			{
			}
			finally
			{
				lock (hdl)
				{
					global::System.Data.SQLite.SQLiteErrorCode sqliteErrorCode = global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_close_interop(db);
					if (sqliteErrorCode != global::System.Data.SQLite.SQLiteErrorCode.Ok)
					{
						throw new global::System.Data.SQLite.SQLiteException(sqliteErrorCode, global::System.Data.SQLite.SQLiteBase.GetLastError(hdl, db));
					}
				}
			}
		}

		// Token: 0x0600009E RID: 158 RVA: 0x0000F168 File Offset: 0x0000E568
		internal static void CloseConnectionV2(global::System.Data.SQLite.SQLiteConnectionHandle hdl, global::System.IntPtr db)
		{
			if (hdl == null || db == global::System.IntPtr.Zero)
			{
				return;
			}
			try
			{
			}
			finally
			{
				lock (hdl)
				{
					global::System.Data.SQLite.SQLiteErrorCode sqliteErrorCode = global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_close_interop(db);
					if (sqliteErrorCode != global::System.Data.SQLite.SQLiteErrorCode.Ok)
					{
						throw new global::System.Data.SQLite.SQLiteException(sqliteErrorCode, global::System.Data.SQLite.SQLiteBase.GetLastError(hdl, db));
					}
				}
			}
		}

		// Token: 0x0600009F RID: 159 RVA: 0x0000F1F0 File Offset: 0x0000E5F0
		internal static bool ResetConnection(global::System.Data.SQLite.SQLiteConnectionHandle hdl, global::System.IntPtr db, bool canThrow)
		{
			if (hdl == null || db == global::System.IntPtr.Zero)
			{
				return false;
			}
			bool result = false;
			try
			{
			}
			finally
			{
				lock (hdl)
				{
					if (canThrow && hdl.IsInvalid)
					{
						throw new global::System.InvalidOperationException("The connection handle is invalid.");
					}
					if (canThrow && hdl.IsClosed)
					{
						throw new global::System.InvalidOperationException("The connection handle is closed.");
					}
					if (!hdl.IsInvalid && !hdl.IsClosed)
					{
						global::System.IntPtr intPtr = global::System.IntPtr.Zero;
						do
						{
							intPtr = global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_next_stmt(db, intPtr);
							if (intPtr != global::System.IntPtr.Zero)
							{
								global::System.Data.SQLite.SQLiteErrorCode sqliteErrorCode = global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_reset_interop(intPtr);
							}
						}
						while (intPtr != global::System.IntPtr.Zero);
						if (global::System.Data.SQLite.SQLiteBase.IsAutocommit(hdl, db))
						{
							result = true;
						}
						else
						{
							global::System.Data.SQLite.SQLiteErrorCode sqliteErrorCode = global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_exec(db, global::System.Data.SQLite.SQLiteConvert.ToUTF8("ROLLBACK"), global::System.IntPtr.Zero, global::System.IntPtr.Zero, out intPtr);
							if (sqliteErrorCode == global::System.Data.SQLite.SQLiteErrorCode.Ok)
							{
								result = true;
							}
							else if (canThrow)
							{
								throw new global::System.Data.SQLite.SQLiteException(sqliteErrorCode, global::System.Data.SQLite.SQLiteBase.GetLastError(hdl, db));
							}
						}
					}
				}
			}
			global::System.GC.KeepAlive(hdl);
			return result;
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x0000F31C File Offset: 0x0000E71C
		internal static bool IsAutocommit(global::System.Data.SQLite.SQLiteConnectionHandle hdl, global::System.IntPtr db)
		{
			if (hdl == null || db == global::System.IntPtr.Zero)
			{
				return false;
			}
			bool result = false;
			try
			{
			}
			finally
			{
				lock (hdl)
				{
					if (!hdl.IsInvalid && !hdl.IsClosed)
					{
						result = (global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_get_autocommit(db) == 1);
					}
				}
			}
			global::System.GC.KeepAlive(hdl);
			return result;
		}

		// Token: 0x04000016 RID: 22
		internal const int COR_E_EXCEPTION = -2146233088;

		// Token: 0x04000017 RID: 23
		private bool disposed;

		// Token: 0x04000018 RID: 24
		private static string[] _errorMessages = new string[]
		{
			"not an error",
			"SQL logic error or missing database",
			"internal logic error",
			"access permission denied",
			"callback requested query abort",
			"database is locked",
			"database table is locked",
			"out of memory",
			"attempt to write a readonly database",
			"interrupted",
			"disk I/O error",
			"database disk image is malformed",
			"unknown operation",
			"database or disk is full",
			"unable to open database file",
			"locking protocol",
			"table contains no data",
			"database schema has changed",
			"string or blob too big",
			"constraint failed",
			"datatype mismatch",
			"library routine called out of sequence",
			"large file support is disabled",
			"authorization denied",
			"auxiliary database format error",
			"bind or column index out of range",
			"file is encrypted or is not a database"
		};
	}
}
