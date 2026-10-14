using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Transactions;

namespace System.Data.SQLite
{
	// Token: 0x02000012 RID: 18
	public sealed class SQLiteConnection : global::System.Data.Common.DbConnection, global::System.ICloneable
	{
		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000190 RID: 400 RVA: 0x00013418 File Offset: 0x00012818
		// (remove) Token: 0x06000191 RID: 401 RVA: 0x0001344C File Offset: 0x0001284C
		private static event global::System.Data.SQLite.SQLiteConnectionEventHandler _handlers;

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x06000192 RID: 402 RVA: 0x00013480 File Offset: 0x00012880
		// (remove) Token: 0x06000193 RID: 403 RVA: 0x000134B8 File Offset: 0x000128B8
		private event global::System.Data.SQLite.SQLiteAuthorizerEventHandler _authorizerHandler;

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x06000194 RID: 404 RVA: 0x000134F0 File Offset: 0x000128F0
		// (remove) Token: 0x06000195 RID: 405 RVA: 0x00013528 File Offset: 0x00012928
		private event global::System.Data.SQLite.SQLiteUpdateEventHandler _updateHandler;

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x06000196 RID: 406 RVA: 0x00013560 File Offset: 0x00012960
		// (remove) Token: 0x06000197 RID: 407 RVA: 0x00013598 File Offset: 0x00012998
		private event global::System.Data.SQLite.SQLiteCommitHandler _commitHandler;

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x06000198 RID: 408 RVA: 0x000135D0 File Offset: 0x000129D0
		// (remove) Token: 0x06000199 RID: 409 RVA: 0x00013608 File Offset: 0x00012A08
		private event global::System.Data.SQLite.SQLiteTraceEventHandler _traceHandler;

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x0600019A RID: 410 RVA: 0x00013640 File Offset: 0x00012A40
		// (remove) Token: 0x0600019B RID: 411 RVA: 0x00013678 File Offset: 0x00012A78
		private event global::System.EventHandler _rollbackHandler;

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x0600019C RID: 412 RVA: 0x000136B0 File Offset: 0x00012AB0
		// (remove) Token: 0x0600019D RID: 413 RVA: 0x000136E8 File Offset: 0x00012AE8
		public override event global::System.Data.StateChangeEventHandler StateChange;

		// Token: 0x0600019E RID: 414 RVA: 0x00013720 File Offset: 0x00012B20
		public SQLiteConnection() : this(null)
		{
		}

		// Token: 0x0600019F RID: 415 RVA: 0x00013734 File Offset: 0x00012B34
		public SQLiteConnection(string connectionString) : this(connectionString, false)
		{
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x0001374C File Offset: 0x00012B4C
		internal SQLiteConnection(global::System.IntPtr db, string fileName, bool ownHandle) : this()
		{
			this._sql = new global::System.Data.SQLite.SQLite3(global::System.Data.SQLite.SQLiteDateFormats.ISO8601, global::System.DateTimeKind.Unspecified, null, db, fileName, ownHandle);
			this._flags = global::System.Data.SQLite.SQLiteConnectionFlags.None;
			this._connectionState = ((db != global::System.IntPtr.Zero) ? global::System.Data.ConnectionState.Open : global::System.Data.ConnectionState.Closed);
			this._connectionString = null;
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x00013798 File Offset: 0x00012B98
		public SQLiteConnection(string connectionString, bool parseViaFramework)
		{
			global::System.Data.SQLite.SQLiteLog.Initialize();
			this._parseViaFramework = parseViaFramework;
			this._flags = global::System.Data.SQLite.SQLiteConnectionFlags.Default;
			this._connectionState = global::System.Data.ConnectionState.Closed;
			this._connectionString = null;
			if (connectionString != null)
			{
				this.ConnectionString = connectionString;
			}
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x000137E4 File Offset: 0x00012BE4
		public SQLiteConnection(global::System.Data.SQLite.SQLiteConnection connection) : this(connection.ConnectionString, connection.ParseViaFramework)
		{
			if (connection.State == global::System.Data.ConnectionState.Open)
			{
				this.Open();
				using (global::System.Data.DataTable schema = connection.GetSchema("Catalogs"))
				{
					foreach (object obj in schema.Rows)
					{
						global::System.Data.DataRow dataRow = (global::System.Data.DataRow)obj;
						string strA = dataRow[0].ToString();
						if (string.Compare(strA, "main", global::System.StringComparison.OrdinalIgnoreCase) != 0 && string.Compare(strA, "temp", global::System.StringComparison.OrdinalIgnoreCase) != 0)
						{
							using (global::System.Data.SQLite.SQLiteCommand sqliteCommand = this.CreateCommand())
							{
								sqliteCommand.CommandText = string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "ATTACH DATABASE '{0}' AS [{1}]", new object[]
								{
									dataRow[1],
									dataRow[0]
								});
								sqliteCommand.ExecuteNonQuery();
							}
						}
					}
				}
			}
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x00013934 File Offset: 0x00012D34
		internal static void OnChanged(global::System.Data.SQLite.SQLiteConnection connection, global::System.Data.SQLite.ConnectionEventArgs e)
		{
			if (connection != null && !connection.CanRaiseEvents)
			{
				return;
			}
			global::System.Data.SQLite.SQLiteConnectionEventHandler sqliteConnectionEventHandler;
			lock (global::System.Data.SQLite.SQLiteConnection._syncRoot)
			{
				if (global::System.Data.SQLite.SQLiteConnection._handlers != null)
				{
					sqliteConnectionEventHandler = (global::System.Data.SQLite.SQLiteConnection._handlers.Clone() as global::System.Data.SQLite.SQLiteConnectionEventHandler);
				}
				else
				{
					sqliteConnectionEventHandler = null;
				}
			}
			if (sqliteConnectionEventHandler != null)
			{
				sqliteConnectionEventHandler(connection, e);
			}
		}

		// Token: 0x14000008 RID: 8
		// (add) Token: 0x060001A4 RID: 420 RVA: 0x000139AC File Offset: 0x00012DAC
		// (remove) Token: 0x060001A5 RID: 421 RVA: 0x00013A00 File Offset: 0x00012E00
		public static event global::System.Data.SQLite.SQLiteConnectionEventHandler Changed
		{
			add
			{
				lock (global::System.Data.SQLite.SQLiteConnection._syncRoot)
				{
					global::System.Data.SQLite.SQLiteConnection._handlers -= value;
					global::System.Data.SQLite.SQLiteConnection._handlers += value;
				}
			}
			remove
			{
				lock (global::System.Data.SQLite.SQLiteConnection._syncRoot)
				{
					global::System.Data.SQLite.SQLiteConnection._handlers -= value;
				}
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060001A6 RID: 422 RVA: 0x00013A4C File Offset: 0x00012E4C
		// (set) Token: 0x060001A7 RID: 423 RVA: 0x00013A60 File Offset: 0x00012E60
		public static global::System.Data.SQLite.ISQLiteConnectionPool ConnectionPool
		{
			get
			{
				return global::System.Data.SQLite.SQLiteConnectionPool.GetConnectionPool();
			}
			set
			{
				global::System.Data.SQLite.SQLiteConnectionPool.SetConnectionPool(value);
			}
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x00013A74 File Offset: 0x00012E74
		public static object CreateHandle(global::System.IntPtr nativeHandle)
		{
			global::System.Data.SQLite.SQLiteConnectionHandle sqliteConnectionHandle;
			try
			{
			}
			finally
			{
				sqliteConnectionHandle = ((nativeHandle != global::System.IntPtr.Zero) ? new global::System.Data.SQLite.SQLiteConnectionHandle(nativeHandle, true) : null);
			}
			if (sqliteConnectionHandle != null)
			{
				global::System.Data.SQLite.SQLiteConnection.OnChanged(null, new global::System.Data.SQLite.ConnectionEventArgs(global::System.Data.SQLite.SQLiteConnectionEventType.NewCriticalHandle, null, null, null, null, sqliteConnectionHandle, null, new object[]
				{
					nativeHandle
				}));
			}
			return sqliteConnectionHandle;
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x00013AE0 File Offset: 0x00012EE0
		public void BackupDatabase(global::System.Data.SQLite.SQLiteConnection destination, string destinationName, string sourceName, int pages, global::System.Data.SQLite.SQLiteBackupCallback callback, int retryMilliseconds)
		{
			this.CheckDisposed();
			if (this._connectionState != global::System.Data.ConnectionState.Open)
			{
				throw new global::System.InvalidOperationException("Source database is not open.");
			}
			if (destination == null)
			{
				throw new global::System.ArgumentNullException("destination");
			}
			if (destination._connectionState != global::System.Data.ConnectionState.Open)
			{
				throw new global::System.ArgumentException("Destination database is not open.", "destination");
			}
			if (destinationName == null)
			{
				throw new global::System.ArgumentNullException("destinationName");
			}
			if (sourceName == null)
			{
				throw new global::System.ArgumentNullException("sourceName");
			}
			global::System.Data.SQLite.SQLiteBase sql = this._sql;
			if (sql == null)
			{
				throw new global::System.InvalidOperationException("Connection object has an invalid handle.");
			}
			global::System.Data.SQLite.SQLiteBackup sqliteBackup = null;
			try
			{
				sqliteBackup = sql.InitializeBackup(destination, destinationName, sourceName);
				bool flag;
				while (sql.StepBackup(sqliteBackup, pages, out flag) && (callback == null || callback(this, sourceName, destination, destinationName, pages, sql.RemainingBackup(sqliteBackup), sql.PageCountBackup(sqliteBackup), flag)))
				{
					if (flag && retryMilliseconds >= 0)
					{
						global::System.Threading.Thread.Sleep(retryMilliseconds);
					}
					if (pages == 0)
					{
						break;
					}
				}
			}
			catch (global::System.Exception ex)
			{
				if ((this._flags & global::System.Data.SQLite.SQLiteConnectionFlags.LogBackup) == global::System.Data.SQLite.SQLiteConnectionFlags.LogBackup)
				{
					global::System.Data.SQLite.SQLiteLog.LogMessage(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, "Caught exception while backing up database: {0}", new object[]
					{
						ex
					}));
				}
				throw;
			}
			finally
			{
				if (sqliteBackup != null)
				{
					sql.FinishBackup(sqliteBackup);
				}
			}
		}

		// Token: 0x060001AA RID: 426 RVA: 0x00013C28 File Offset: 0x00013028
		public void BindFunction(global::System.Data.SQLite.SQLiteFunctionAttribute functionAttribute, global::System.Data.SQLite.SQLiteFunction function)
		{
			this.CheckDisposed();
			if (this._sql == null)
			{
				throw new global::System.InvalidOperationException("Database connection not valid for binding functions.");
			}
			this._sql.BindFunction(functionAttribute, function, this._flags);
		}

		// Token: 0x060001AB RID: 427 RVA: 0x00013C64 File Offset: 0x00013064
		[global::System.Diagnostics.Conditional("CHECK_STATE")]
		internal static void Check(global::System.Data.SQLite.SQLiteConnection connection)
		{
			if (connection == null)
			{
				throw new global::System.ArgumentNullException("connection");
			}
			connection.CheckDisposed();
			if (connection._connectionState != global::System.Data.ConnectionState.Open)
			{
				throw new global::System.InvalidOperationException("The connection is not open.");
			}
			global::System.Data.SQLite.SQLite3 sqlite = connection._sql as global::System.Data.SQLite.SQLite3;
			if (sqlite == null)
			{
				throw new global::System.InvalidOperationException("The connection handle wrapper is null.");
			}
			global::System.Data.SQLite.SQLiteConnectionHandle sql = sqlite._sql;
			if (sql == null)
			{
				throw new global::System.InvalidOperationException("The connection handle is null.");
			}
			if (sql.IsInvalid)
			{
				throw new global::System.InvalidOperationException("The connection handle is invalid.");
			}
			if (sql.IsClosed)
			{
				throw new global::System.InvalidOperationException("The connection handle is closed.");
			}
		}

		// Token: 0x060001AC RID: 428 RVA: 0x00013CF0 File Offset: 0x000130F0
		private static global::System.Collections.Generic.SortedList<string, string> ParseConnectionString(string connectionString, bool parseViaFramework)
		{
			if (!parseViaFramework)
			{
				return global::System.Data.SQLite.SQLiteConnection.ParseConnectionString(connectionString);
			}
			return global::System.Data.SQLite.SQLiteConnection.ParseConnectionStringViaFramework(connectionString, false);
		}

		// Token: 0x060001AD RID: 429 RVA: 0x00013D10 File Offset: 0x00013110
		private void SetupSQLiteBase(global::System.Collections.Generic.SortedList<string, string> opts)
		{
			object obj = global::System.Data.SQLite.SQLiteConnection.TryParseEnum(typeof(global::System.Data.SQLite.SQLiteDateFormats), global::System.Data.SQLite.SQLiteConnection.FindKey(opts, "DateTimeFormat", global::System.Data.SQLite.SQLiteDateFormats.ISO8601.ToString()), true);
			global::System.Data.SQLite.SQLiteDateFormats fmt = (obj is global::System.Data.SQLite.SQLiteDateFormats) ? ((global::System.Data.SQLite.SQLiteDateFormats)obj) : global::System.Data.SQLite.SQLiteDateFormats.ISO8601;
			obj = global::System.Data.SQLite.SQLiteConnection.TryParseEnum(typeof(global::System.DateTimeKind), global::System.Data.SQLite.SQLiteConnection.FindKey(opts, "DateTimeKind", global::System.DateTimeKind.Unspecified.ToString()), true);
			global::System.DateTimeKind kind = (obj is global::System.DateTimeKind) ? ((global::System.DateTimeKind)obj) : global::System.DateTimeKind.Unspecified;
			string fmtString = global::System.Data.SQLite.SQLiteConnection.FindKey(opts, "DateTimeFormatString", null);
			if (global::System.Data.SQLite.SQLiteConvert.ToBoolean(global::System.Data.SQLite.SQLiteConnection.FindKey(opts, "UseUTF16Encoding", false.ToString())))
			{
				this._sql = new global::System.Data.SQLite.SQLite3_UTF16(fmt, kind, fmtString, global::System.IntPtr.Zero, null, false);
				return;
			}
			this._sql = new global::System.Data.SQLite.SQLite3(fmt, kind, fmtString, global::System.IntPtr.Zero, null, false);
		}

		// Token: 0x060001AE RID: 430 RVA: 0x00013DE4 File Offset: 0x000131E4
		private void CheckDisposed()
		{
			if (this.disposed)
			{
				throw new global::System.ObjectDisposedException(typeof(global::System.Data.SQLite.SQLiteConnection).Name);
			}
		}

		// Token: 0x060001AF RID: 431 RVA: 0x00013E10 File Offset: 0x00013210
		protected override void Dispose(bool disposing)
		{
			this._disposing = true;
			try
			{
				if (!this.disposed)
				{
					this.Close();
				}
			}
			finally
			{
				base.Dispose(disposing);
				this.disposed = true;
			}
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x00013E60 File Offset: 0x00013260
		public object Clone()
		{
			this.CheckDisposed();
			return new global::System.Data.SQLite.SQLiteConnection(this);
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x00013E7C File Offset: 0x0001327C
		public static void CreateFile(string databaseFileName)
		{
			global::System.IO.FileStream fileStream = global::System.IO.File.Create(databaseFileName);
			fileStream.Close();
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x00013E98 File Offset: 0x00013298
		internal void OnStateChange(global::System.Data.ConnectionState newState, ref global::System.Data.StateChangeEventArgs eventArgs)
		{
			global::System.Data.ConnectionState connectionState = this._connectionState;
			this._connectionState = newState;
			if (this.StateChange != null && newState != connectionState)
			{
				global::System.Data.StateChangeEventArgs stateChangeEventArgs = new global::System.Data.StateChangeEventArgs(connectionState, newState);
				this.StateChange(this, stateChangeEventArgs);
				eventArgs = stateChangeEventArgs;
			}
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x00013ED8 File Offset: 0x000132D8
		[global::System.Obsolete("Use one of the standard BeginTransaction methods, this one will be removed soon")]
		public global::System.Data.SQLite.SQLiteTransaction BeginTransaction(global::System.Data.IsolationLevel isolationLevel, bool deferredLock)
		{
			this.CheckDisposed();
			return (global::System.Data.SQLite.SQLiteTransaction)this.BeginDbTransaction((!deferredLock) ? global::System.Data.IsolationLevel.Serializable : global::System.Data.IsolationLevel.ReadCommitted);
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x00013F08 File Offset: 0x00013308
		[global::System.Obsolete("Use one of the standard BeginTransaction methods, this one will be removed soon")]
		public global::System.Data.SQLite.SQLiteTransaction BeginTransaction(bool deferredLock)
		{
			this.CheckDisposed();
			return (global::System.Data.SQLite.SQLiteTransaction)this.BeginDbTransaction((!deferredLock) ? global::System.Data.IsolationLevel.Serializable : global::System.Data.IsolationLevel.ReadCommitted);
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x00013F38 File Offset: 0x00013338
		public new global::System.Data.SQLite.SQLiteTransaction BeginTransaction(global::System.Data.IsolationLevel isolationLevel)
		{
			this.CheckDisposed();
			return (global::System.Data.SQLite.SQLiteTransaction)this.BeginDbTransaction(isolationLevel);
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x00013F58 File Offset: 0x00013358
		public new global::System.Data.SQLite.SQLiteTransaction BeginTransaction()
		{
			this.CheckDisposed();
			return (global::System.Data.SQLite.SQLiteTransaction)this.BeginDbTransaction(this._defaultIsolation);
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x00013F7C File Offset: 0x0001337C
		protected override global::System.Data.Common.DbTransaction BeginDbTransaction(global::System.Data.IsolationLevel isolationLevel)
		{
			if (this._connectionState != global::System.Data.ConnectionState.Open)
			{
				throw new global::System.InvalidOperationException();
			}
			if (isolationLevel == global::System.Data.IsolationLevel.Unspecified)
			{
				isolationLevel = this._defaultIsolation;
			}
			if (isolationLevel != global::System.Data.IsolationLevel.Serializable && isolationLevel != global::System.Data.IsolationLevel.ReadCommitted)
			{
				throw new global::System.ArgumentException("isolationLevel");
			}
			global::System.Data.SQLite.SQLiteTransaction sqliteTransaction = new global::System.Data.SQLite.SQLiteTransaction(this, isolationLevel != global::System.Data.IsolationLevel.Serializable);
			global::System.Data.SQLite.SQLiteConnection.OnChanged(this, new global::System.Data.SQLite.ConnectionEventArgs(global::System.Data.SQLite.SQLiteConnectionEventType.NewTransaction, null, sqliteTransaction, null, null, null, null, null));
			return sqliteTransaction;
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x00013FE8 File Offset: 0x000133E8
		public override void ChangeDatabase(string databaseName)
		{
			this.CheckDisposed();
			global::System.Data.SQLite.SQLiteConnection.OnChanged(this, new global::System.Data.SQLite.ConnectionEventArgs(global::System.Data.SQLite.SQLiteConnectionEventType.ChangeDatabase, null, null, null, null, null, databaseName, null));
			throw new global::System.NotImplementedException();
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x00014014 File Offset: 0x00013414
		public override void Close()
		{
			this.CheckDisposed();
			global::System.Data.SQLite.SQLiteConnection.OnChanged(this, new global::System.Data.SQLite.ConnectionEventArgs(global::System.Data.SQLite.SQLiteConnectionEventType.Closing, null, null, null, null, null, null, null));
			if (this._sql != null)
			{
				if (this._enlistment != null)
				{
					global::System.Data.SQLite.SQLiteConnection sqliteConnection = new global::System.Data.SQLite.SQLiteConnection();
					sqliteConnection._sql = this._sql;
					sqliteConnection._transactionLevel = this._transactionLevel;
					sqliteConnection._enlistment = this._enlistment;
					sqliteConnection._connectionState = this._connectionState;
					sqliteConnection._version = this._version;
					sqliteConnection._enlistment._transaction._cnn = sqliteConnection;
					sqliteConnection._enlistment._disposeConnection = true;
					this._sql = null;
					this._enlistment = null;
				}
				if (this._sql != null)
				{
					this._sql.Close(!this._disposing);
					this._sql = null;
				}
				this._transactionLevel = 0;
			}
			global::System.Data.StateChangeEventArgs eventArgs = null;
			this.OnStateChange(global::System.Data.ConnectionState.Closed, ref eventArgs);
			global::System.Data.SQLite.SQLiteConnection.OnChanged(this, new global::System.Data.SQLite.ConnectionEventArgs(global::System.Data.SQLite.SQLiteConnectionEventType.Closed, eventArgs, null, null, null, null, null, null));
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060001BA RID: 442 RVA: 0x00014104 File Offset: 0x00013504
		public int PoolCount
		{
			get
			{
				if (this._sql == null)
				{
					return 0;
				}
				return this._sql.CountPool();
			}
		}

		// Token: 0x060001BB RID: 443 RVA: 0x00014128 File Offset: 0x00013528
		public static void ClearPool(global::System.Data.SQLite.SQLiteConnection connection)
		{
			if (connection._sql == null)
			{
				return;
			}
			connection._sql.ClearPool();
		}

		// Token: 0x060001BC RID: 444 RVA: 0x0001414C File Offset: 0x0001354C
		public static void ClearAllPools()
		{
			global::System.Data.SQLite.SQLiteConnectionPool.ClearAllPools();
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060001BD RID: 445 RVA: 0x00014160 File Offset: 0x00013560
		// (set) Token: 0x060001BE RID: 446 RVA: 0x0001417C File Offset: 0x0001357C
		[global::System.ComponentModel.RefreshProperties(global::System.ComponentModel.RefreshProperties.All)]
		[global::System.ComponentModel.DefaultValue("")]
		[global::System.ComponentModel.Editor("SQLite.Designer.SQLiteConnectionStringEditor, SQLite.Designer, Version=1.0.89.0, Culture=neutral, PublicKeyToken=db937bc2d44ff139", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
		public override string ConnectionString
		{
			get
			{
				this.CheckDisposed();
				return this._connectionString;
			}
			set
			{
				this.CheckDisposed();
				if (value == null)
				{
					throw new global::System.ArgumentNullException();
				}
				if (this._connectionState != global::System.Data.ConnectionState.Closed)
				{
					throw new global::System.InvalidOperationException();
				}
				this._connectionString = value;
			}
		}

		// Token: 0x060001BF RID: 447 RVA: 0x000141B0 File Offset: 0x000135B0
		public new global::System.Data.SQLite.SQLiteCommand CreateCommand()
		{
			this.CheckDisposed();
			return new global::System.Data.SQLite.SQLiteCommand(this);
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x000141CC File Offset: 0x000135CC
		protected override global::System.Data.Common.DbCommand CreateDbCommand()
		{
			return this.CreateCommand();
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060001C1 RID: 449 RVA: 0x000141E0 File Offset: 0x000135E0
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public override string DataSource
		{
			get
			{
				this.CheckDisposed();
				return this._dataSource;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060001C2 RID: 450 RVA: 0x000141FC File Offset: 0x000135FC
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public override string Database
		{
			get
			{
				this.CheckDisposed();
				return "main";
			}
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x00014214 File Offset: 0x00013614
		internal static string MapUriPath(string path)
		{
			if (path.StartsWith("file://", global::System.StringComparison.OrdinalIgnoreCase))
			{
				return path.Substring(7);
			}
			if (path.StartsWith("file:", global::System.StringComparison.OrdinalIgnoreCase))
			{
				return path.Substring(5);
			}
			if (path.StartsWith("/", global::System.StringComparison.OrdinalIgnoreCase))
			{
				return path;
			}
			throw new global::System.InvalidOperationException("Invalid connection string: invalid URI");
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x00014268 File Offset: 0x00013668
		internal static global::System.Collections.Generic.SortedList<string, string> ParseConnectionString(string connectionString)
		{
			global::System.Collections.Generic.SortedList<string, string> sortedList = new global::System.Collections.Generic.SortedList<string, string>(global::System.StringComparer.OrdinalIgnoreCase);
			string text = null;
			string[] array;
			if (global::System.Environment.GetEnvironmentVariable("No_SQLiteConnectionNewParser") != null)
			{
				array = global::System.Data.SQLite.SQLiteConvert.Split(connectionString, ';');
			}
			else
			{
				array = global::System.Data.SQLite.SQLiteConvert.NewSplit(connectionString, ';', true, ref text);
			}
			if (array == null)
			{
				throw new global::System.ArgumentException(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, "Invalid ConnectionString format, cannot parse: {0}", new object[]
				{
					(text != null) ? text : "could not split connection string into properties"
				}));
			}
			int num = (array != null) ? array.Length : 0;
			for (int i = 0; i < num; i++)
			{
				if (array[i] != null)
				{
					array[i] = array[i].Trim();
					if (array[i].Length != 0)
					{
						int num2 = array[i].IndexOf('=');
						if (num2 == -1)
						{
							throw new global::System.ArgumentException(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, "Invalid ConnectionString format for part \"{0}\", no equal sign found", new object[]
							{
								array[i]
							}));
						}
						sortedList.Add(global::System.Data.SQLite.SQLiteConnection.UnwrapString(array[i].Substring(0, num2).Trim()), global::System.Data.SQLite.SQLiteConnection.UnwrapString(array[i].Substring(num2 + 1).Trim()));
					}
				}
			}
			return sortedList;
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x00014380 File Offset: 0x00013780
		internal static global::System.Collections.Generic.SortedList<string, string> ParseConnectionStringViaFramework(string connectionString, bool strict)
		{
			global::System.Data.Common.DbConnectionStringBuilder dbConnectionStringBuilder = new global::System.Data.Common.DbConnectionStringBuilder();
			dbConnectionStringBuilder.ConnectionString = connectionString;
			global::System.Collections.Generic.SortedList<string, string> sortedList = new global::System.Collections.Generic.SortedList<string, string>(global::System.StringComparer.OrdinalIgnoreCase);
			foreach (object obj in dbConnectionStringBuilder.Keys)
			{
				string text = (string)obj;
				object obj2 = dbConnectionStringBuilder[text];
				string value = null;
				if (obj2 is string)
				{
					value = (string)obj2;
				}
				else
				{
					if (strict)
					{
						throw new global::System.ArgumentException("connection property value is not a string", text);
					}
					if (obj2 != null)
					{
						value = obj2.ToString();
					}
				}
				sortedList.Add(text, value);
			}
			return sortedList;
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x00014440 File Offset: 0x00013840
		public override void EnlistTransaction(global::System.Transactions.Transaction transaction)
		{
			this.CheckDisposed();
			if (this._enlistment != null && transaction == this._enlistment._scope)
			{
				return;
			}
			if (this._enlistment != null)
			{
				throw new global::System.ArgumentException("Already enlisted in a transaction");
			}
			if (this._transactionLevel > 0 && transaction != null)
			{
				throw new global::System.ArgumentException("Unable to enlist in transaction, a local transaction already exists");
			}
			if (transaction == null)
			{
				throw new global::System.ArgumentNullException("Unable to enlist in transaction, it is null");
			}
			this._enlistment = new global::System.Data.SQLite.SQLiteEnlistment(this, transaction);
			global::System.Data.SQLite.SQLiteConnection.OnChanged(this, new global::System.Data.SQLite.ConnectionEventArgs(global::System.Data.SQLite.SQLiteConnectionEventType.EnlistTransaction, null, null, null, null, null, null, new object[]
			{
				this._enlistment
			}));
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x000144E4 File Offset: 0x000138E4
		internal static string FindKey(global::System.Collections.Generic.SortedList<string, string> items, string key, string defValue)
		{
			string result;
			if (items.TryGetValue(key, out result))
			{
				return result;
			}
			return defValue;
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x00014500 File Offset: 0x00013900
		private static object TryParseEnum(global::System.Type type, string value, bool ignoreCase)
		{
			try
			{
				return global::System.Enum.Parse(type, value, ignoreCase);
			}
			catch
			{
			}
			return null;
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x0001453C File Offset: 0x0001393C
		private static bool TryParseByte(string value, global::System.Globalization.NumberStyles style, out byte result)
		{
			return byte.TryParse(value, style, null, out result);
		}

		// Token: 0x060001CA RID: 458 RVA: 0x00014554 File Offset: 0x00013954
		public void EnableExtensions(bool enable)
		{
			this.CheckDisposed();
			if (this._sql == null)
			{
				throw new global::System.InvalidOperationException(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, "Database connection not valid for {0} extensions.", new object[]
				{
					enable ? "enabling" : "disabling"
				}));
			}
			if ((this._flags & global::System.Data.SQLite.SQLiteConnectionFlags.NoLoadExtension) == global::System.Data.SQLite.SQLiteConnectionFlags.NoLoadExtension)
			{
				throw new global::System.Data.SQLite.SQLiteException("Loading extensions is disabled for this database connection.");
			}
			this._sql.SetLoadExtension(enable);
		}

		// Token: 0x060001CB RID: 459 RVA: 0x000145C8 File Offset: 0x000139C8
		public void LoadExtension(string fileName)
		{
			this.CheckDisposed();
			this.LoadExtension(fileName, null);
		}

		// Token: 0x060001CC RID: 460 RVA: 0x000145E4 File Offset: 0x000139E4
		public void LoadExtension(string fileName, string procName)
		{
			this.CheckDisposed();
			if (this._sql == null)
			{
				throw new global::System.InvalidOperationException("Database connection not valid for loading extensions.");
			}
			if ((this._flags & global::System.Data.SQLite.SQLiteConnectionFlags.NoLoadExtension) == global::System.Data.SQLite.SQLiteConnectionFlags.NoLoadExtension)
			{
				throw new global::System.Data.SQLite.SQLiteException("Loading extensions is disabled for this database connection.");
			}
			this._sql.LoadExtension(fileName, procName);
		}

		// Token: 0x060001CD RID: 461 RVA: 0x00014638 File Offset: 0x00013A38
		public void CreateModule(global::System.Data.SQLite.SQLiteModule module)
		{
			this.CheckDisposed();
			if (this._sql == null)
			{
				throw new global::System.InvalidOperationException("Database connection not valid for creating modules.");
			}
			if ((this._flags & global::System.Data.SQLite.SQLiteConnectionFlags.NoCreateModule) == global::System.Data.SQLite.SQLiteConnectionFlags.NoCreateModule)
			{
				throw new global::System.Data.SQLite.SQLiteException("Creating modules is disabled for this database connection.");
			}
			this._sql.CreateModule(module, this._flags);
		}

		// Token: 0x060001CE RID: 462 RVA: 0x00014690 File Offset: 0x00013A90
		internal static byte[] FromHexString(string text)
		{
			string text2 = null;
			return global::System.Data.SQLite.SQLiteConnection.FromHexString(text, ref text2);
		}

		// Token: 0x060001CF RID: 463 RVA: 0x000146A8 File Offset: 0x00013AA8
		internal static string ToHexString(byte[] array)
		{
			if (array == null)
			{
				return null;
			}
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			int num = array.Length;
			for (int i = 0; i < num; i++)
			{
				stringBuilder.AppendFormat("{0:x2}", array[i]);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x000146EC File Offset: 0x00013AEC
		private static byte[] FromHexString(string text, ref string error)
		{
			if (string.IsNullOrEmpty(text))
			{
				error = "string is null or empty";
				return null;
			}
			if (text.Length % 2 != 0)
			{
				error = "string contains an odd number of characters";
				return null;
			}
			byte[] array = new byte[text.Length / 2];
			for (int i = 0; i < text.Length; i += 2)
			{
				string text2 = text.Substring(i, 2);
				if (!global::System.Data.SQLite.SQLiteConnection.TryParseByte(text2, global::System.Globalization.NumberStyles.HexNumber, out array[i / 2]))
				{
					error = string.Format(global::System.Globalization.CultureInfo.CurrentCulture, "string contains \"{0}\", which cannot be converted to a byte value", new object[]
					{
						text2
					});
					return null;
				}
			}
			return array;
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x0001477C File Offset: 0x00013B7C
		public override void Open()
		{
			this.CheckDisposed();
			global::System.Data.SQLite.SQLiteConnection.OnChanged(this, new global::System.Data.SQLite.ConnectionEventArgs(global::System.Data.SQLite.SQLiteConnectionEventType.Opening, null, null, null, null, null, null, null));
			if (this._connectionState != global::System.Data.ConnectionState.Closed)
			{
				throw new global::System.InvalidOperationException();
			}
			this.Close();
			global::System.Collections.Generic.SortedList<string, string> sortedList = global::System.Data.SQLite.SQLiteConnection.ParseConnectionString(this._connectionString, this._parseViaFramework);
			global::System.Data.SQLite.SQLiteConnection.OnChanged(this, new global::System.Data.SQLite.ConnectionEventArgs(global::System.Data.SQLite.SQLiteConnectionEventType.ConnectionString, null, null, null, null, null, this._connectionString, new object[]
			{
				sortedList
			}));
			object obj = global::System.Data.SQLite.SQLiteConnection.TryParseEnum(typeof(global::System.Data.SQLite.SQLiteConnectionFlags), global::System.Data.SQLite.SQLiteConnection.FindKey(sortedList, "Flags", global::System.Data.SQLite.SQLiteConnectionFlags.Default.ToString()), true);
			this._flags = ((obj is global::System.Data.SQLite.SQLiteConnectionFlags) ? ((global::System.Data.SQLite.SQLiteConnectionFlags)obj) : global::System.Data.SQLite.SQLiteConnectionFlags.Default);
			bool flag = false;
			if (global::System.Convert.ToInt32(global::System.Data.SQLite.SQLiteConnection.FindKey(sortedList, "Version", 3.ToString()), global::System.Globalization.CultureInfo.InvariantCulture) != 3)
			{
				throw new global::System.NotSupportedException(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, "Only SQLite Version {0} is supported at this time", new object[]
				{
					3
				}));
			}
			string text = global::System.Data.SQLite.SQLiteConnection.FindKey(sortedList, "Data Source", null);
			if (string.IsNullOrEmpty(text))
			{
				text = global::System.Data.SQLite.SQLiteConnection.FindKey(sortedList, "Uri", null);
				if (string.IsNullOrEmpty(text))
				{
					text = global::System.Data.SQLite.SQLiteConnection.FindKey(sortedList, "FullUri", null);
					if (string.IsNullOrEmpty(text))
					{
						throw new global::System.ArgumentException(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, "Data Source cannot be empty.  Use {0} to open an in-memory database", new object[]
						{
							":memory:"
						}));
					}
					flag = true;
				}
				else
				{
					text = global::System.Data.SQLite.SQLiteConnection.MapUriPath(text);
				}
			}
			bool flag2 = string.Compare(text, ":memory:", global::System.StringComparison.OrdinalIgnoreCase) == 0;
			if (!flag)
			{
				if (flag2)
				{
					text = ":memory:";
				}
				else
				{
					bool toFullPath = global::System.Data.SQLite.SQLiteConvert.ToBoolean(global::System.Data.SQLite.SQLiteConnection.FindKey(sortedList, "ToFullPath", true.ToString()));
					text = this.ExpandFileName(text, toFullPath);
				}
			}
			try
			{
				bool usePool = global::System.Data.SQLite.SQLiteConvert.ToBoolean(global::System.Data.SQLite.SQLiteConnection.FindKey(sortedList, "Pooling", false.ToString()));
				int maxPoolSize = global::System.Convert.ToInt32(global::System.Data.SQLite.SQLiteConnection.FindKey(sortedList, "Max Pool Size", 100.ToString()), global::System.Globalization.CultureInfo.InvariantCulture);
				this._defaultTimeout = global::System.Convert.ToInt32(global::System.Data.SQLite.SQLiteConnection.FindKey(sortedList, "Default Timeout", 30.ToString()), global::System.Globalization.CultureInfo.InvariantCulture);
				obj = global::System.Data.SQLite.SQLiteConnection.TryParseEnum(typeof(global::System.Data.IsolationLevel), global::System.Data.SQLite.SQLiteConnection.FindKey(sortedList, "Default IsolationLevel", global::System.Data.IsolationLevel.Serializable.ToString()), true);
				this._defaultIsolation = ((obj is global::System.Data.IsolationLevel) ? ((global::System.Data.IsolationLevel)obj) : global::System.Data.IsolationLevel.Serializable);
				if (this._defaultIsolation != global::System.Data.IsolationLevel.Serializable && this._defaultIsolation != global::System.Data.IsolationLevel.ReadCommitted)
				{
					throw new global::System.NotSupportedException("Invalid Default IsolationLevel specified");
				}
				this._baseSchemaName = global::System.Data.SQLite.SQLiteConnection.FindKey(sortedList, "BaseSchemaName", "sqlite_default_schema");
				if (this._sql == null)
				{
					this.SetupSQLiteBase(sortedList);
				}
				global::System.Data.SQLite.SQLiteOpenFlagsEnum sqliteOpenFlagsEnum = global::System.Data.SQLite.SQLiteOpenFlagsEnum.None;
				if (!global::System.Data.SQLite.SQLiteConvert.ToBoolean(global::System.Data.SQLite.SQLiteConnection.FindKey(sortedList, "FailIfMissing", false.ToString())))
				{
					sqliteOpenFlagsEnum |= global::System.Data.SQLite.SQLiteOpenFlagsEnum.Create;
				}
				if (global::System.Data.SQLite.SQLiteConvert.ToBoolean(global::System.Data.SQLite.SQLiteConnection.FindKey(sortedList, "Read Only", false.ToString())))
				{
					sqliteOpenFlagsEnum |= global::System.Data.SQLite.SQLiteOpenFlagsEnum.ReadOnly;
					sqliteOpenFlagsEnum &= ~global::System.Data.SQLite.SQLiteOpenFlagsEnum.Create;
				}
				else
				{
					sqliteOpenFlagsEnum |= global::System.Data.SQLite.SQLiteOpenFlagsEnum.ReadWrite;
				}
				if (flag)
				{
					sqliteOpenFlagsEnum |= global::System.Data.SQLite.SQLiteOpenFlagsEnum.Uri;
				}
				this._sql.Open(text, this._flags, sqliteOpenFlagsEnum, maxPoolSize, usePool);
				this._binaryGuid = global::System.Data.SQLite.SQLiteConvert.ToBoolean(global::System.Data.SQLite.SQLiteConnection.FindKey(sortedList, "BinaryGUID", true.ToString()));
				string text2 = global::System.Data.SQLite.SQLiteConnection.FindKey(sortedList, "HexPassword", null);
				if (!string.IsNullOrEmpty(text2))
				{
					string text3 = null;
					byte[] array = global::System.Data.SQLite.SQLiteConnection.FromHexString(text2, ref text3);
					if (array == null)
					{
						throw new global::System.FormatException(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, "Cannot parse 'HexPassword' property value into byte values: {0}", new object[]
						{
							text3
						}));
					}
					this._sql.SetPassword(array);
				}
				else
				{
					string text4 = global::System.Data.SQLite.SQLiteConnection.FindKey(sortedList, "Password", null);
					if (!string.IsNullOrEmpty(text4))
					{
						this._sql.SetPassword(global::System.Text.Encoding.UTF8.GetBytes(text4));
					}
					else if (this._password != null)
					{
						this._sql.SetPassword(this._password);
					}
				}
				this._password = null;
				if (!flag)
				{
					this._dataSource = global::System.IO.Path.GetFileNameWithoutExtension(text);
				}
				else
				{
					this._dataSource = text;
				}
				this._version += 1L;
				global::System.Data.ConnectionState connectionState = this._connectionState;
				this._connectionState = global::System.Data.ConnectionState.Open;
				try
				{
					string text5 = global::System.Data.SQLite.SQLiteConnection.FindKey(sortedList, "SetDefaults", true.ToString());
					bool flag3 = global::System.Data.SQLite.SQLiteConvert.ToBoolean(text5);
					if (flag3)
					{
						using (global::System.Data.SQLite.SQLiteCommand sqliteCommand = this.CreateCommand())
						{
							int num;
							if (!flag && !flag2)
							{
								text5 = global::System.Data.SQLite.SQLiteConnection.FindKey(sortedList, "Page Size", 1024.ToString());
								num = global::System.Convert.ToInt32(text5, global::System.Globalization.CultureInfo.InvariantCulture);
								if (num != 1024)
								{
									sqliteCommand.CommandText = string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "PRAGMA page_size={0}", new object[]
									{
										num
									});
									sqliteCommand.ExecuteNonQuery();
								}
							}
							text5 = global::System.Data.SQLite.SQLiteConnection.FindKey(sortedList, "Max Page Count", 0.ToString());
							num = global::System.Convert.ToInt32(text5, global::System.Globalization.CultureInfo.InvariantCulture);
							if (num != 0)
							{
								sqliteCommand.CommandText = string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "PRAGMA max_page_count={0}", new object[]
								{
									num
								});
								sqliteCommand.ExecuteNonQuery();
							}
							text5 = global::System.Data.SQLite.SQLiteConnection.FindKey(sortedList, "Legacy Format", false.ToString());
							flag3 = global::System.Data.SQLite.SQLiteConvert.ToBoolean(text5);
							if (flag3)
							{
								sqliteCommand.CommandText = string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "PRAGMA legacy_file_format={0}", new object[]
								{
									flag3 ? "ON" : "OFF"
								});
								sqliteCommand.ExecuteNonQuery();
							}
							text5 = global::System.Data.SQLite.SQLiteConnection.FindKey(sortedList, "Synchronous", global::System.Data.SQLite.SQLiteSynchronousEnum.Default.ToString());
							obj = global::System.Data.SQLite.SQLiteConnection.TryParseEnum(typeof(global::System.Data.SQLite.SQLiteSynchronousEnum), text5, true);
							if (!(obj is global::System.Data.SQLite.SQLiteSynchronousEnum) || (global::System.Data.SQLite.SQLiteSynchronousEnum)obj != global::System.Data.SQLite.SQLiteSynchronousEnum.Default)
							{
								sqliteCommand.CommandText = string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "PRAGMA synchronous={0}", new object[]
								{
									text5
								});
								sqliteCommand.ExecuteNonQuery();
							}
							text5 = global::System.Data.SQLite.SQLiteConnection.FindKey(sortedList, "Cache Size", 2000.ToString());
							num = global::System.Convert.ToInt32(text5, global::System.Globalization.CultureInfo.InvariantCulture);
							if (num != 2000)
							{
								sqliteCommand.CommandText = string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "PRAGMA cache_size={0}", new object[]
								{
									num
								});
								sqliteCommand.ExecuteNonQuery();
							}
							text5 = global::System.Data.SQLite.SQLiteConnection.FindKey(sortedList, "Journal Mode", global::System.Data.SQLite.SQLiteJournalModeEnum.Default.ToString());
							obj = global::System.Data.SQLite.SQLiteConnection.TryParseEnum(typeof(global::System.Data.SQLite.SQLiteJournalModeEnum), text5, true);
							if (!(obj is global::System.Data.SQLite.SQLiteJournalModeEnum) || (global::System.Data.SQLite.SQLiteJournalModeEnum)obj != global::System.Data.SQLite.SQLiteJournalModeEnum.Default)
							{
								sqliteCommand.CommandText = string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "PRAGMA journal_mode={0}", new object[]
								{
									text5
								});
								sqliteCommand.ExecuteNonQuery();
							}
							text5 = global::System.Data.SQLite.SQLiteConnection.FindKey(sortedList, "Foreign Keys", false.ToString());
							flag3 = global::System.Convert.ToBoolean(text5, global::System.Globalization.CultureInfo.InvariantCulture);
							if (flag3)
							{
								sqliteCommand.CommandText = string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "PRAGMA foreign_keys={0}", new object[]
								{
									flag3 ? "ON" : "OFF"
								});
								sqliteCommand.ExecuteNonQuery();
							}
						}
					}
					if (this._authorizerHandler != null)
					{
						this._sql.SetAuthorizerHook(this._authorizerCallback);
					}
					if (this._commitHandler != null)
					{
						this._sql.SetCommitHook(this._commitCallback);
					}
					if (this._updateHandler != null)
					{
						this._sql.SetUpdateHook(this._updateCallback);
					}
					if (this._rollbackHandler != null)
					{
						this._sql.SetRollbackHook(this._rollbackCallback);
					}
					global::System.Transactions.Transaction transaction = global::System.Transactions.Transaction.Current;
					if (transaction != null && global::System.Data.SQLite.SQLiteConvert.ToBoolean(global::System.Data.SQLite.SQLiteConnection.FindKey(sortedList, "Enlist", true.ToString())))
					{
						this.EnlistTransaction(transaction);
					}
					this._connectionState = connectionState;
					global::System.Data.StateChangeEventArgs eventArgs = null;
					this.OnStateChange(global::System.Data.ConnectionState.Open, ref eventArgs);
					global::System.Data.SQLite.SQLiteConnection.OnChanged(this, new global::System.Data.SQLite.ConnectionEventArgs(global::System.Data.SQLite.SQLiteConnectionEventType.Opened, eventArgs, null, null, null, null, null, null));
				}
				catch
				{
					this._connectionState = connectionState;
					throw;
				}
			}
			catch (global::System.Data.SQLite.SQLiteException)
			{
				this.Close();
				throw;
			}
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x00014FC4 File Offset: 0x000143C4
		public global::System.Data.SQLite.SQLiteConnection OpenAndReturn()
		{
			this.CheckDisposed();
			this.Open();
			return this;
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060001D3 RID: 467 RVA: 0x00014FE0 File Offset: 0x000143E0
		// (set) Token: 0x060001D4 RID: 468 RVA: 0x00014FFC File Offset: 0x000143FC
		public int DefaultTimeout
		{
			get
			{
				this.CheckDisposed();
				return this._defaultTimeout;
			}
			set
			{
				this.CheckDisposed();
				this._defaultTimeout = value;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060001D5 RID: 469 RVA: 0x00015018 File Offset: 0x00014418
		// (set) Token: 0x060001D6 RID: 470 RVA: 0x00015034 File Offset: 0x00014434
		public bool ParseViaFramework
		{
			get
			{
				this.CheckDisposed();
				return this._parseViaFramework;
			}
			set
			{
				this.CheckDisposed();
				this._parseViaFramework = value;
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060001D7 RID: 471 RVA: 0x00015050 File Offset: 0x00014450
		// (set) Token: 0x060001D8 RID: 472 RVA: 0x0001506C File Offset: 0x0001446C
		public global::System.Data.SQLite.SQLiteConnectionFlags Flags
		{
			get
			{
				this.CheckDisposed();
				return this._flags;
			}
			set
			{
				this.CheckDisposed();
				this._flags = value;
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060001D9 RID: 473 RVA: 0x00015088 File Offset: 0x00014488
		public bool OwnHandle
		{
			get
			{
				this.CheckDisposed();
				if (this._sql == null)
				{
					throw new global::System.InvalidOperationException("Database connection not valid for checking handle.");
				}
				return this._sql.OwnHandle;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060001DA RID: 474 RVA: 0x000150BC File Offset: 0x000144BC
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		public override string ServerVersion
		{
			get
			{
				this.CheckDisposed();
				return global::System.Data.SQLite.SQLiteConnection.SQLiteVersion;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060001DB RID: 475 RVA: 0x000150D4 File Offset: 0x000144D4
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		public long LastInsertRowId
		{
			get
			{
				this.CheckDisposed();
				if (this._sql == null)
				{
					throw new global::System.InvalidOperationException("Database connection not valid for getting last insert rowid.");
				}
				return this._sql.LastInsertRowId;
			}
		}

		// Token: 0x060001DC RID: 476 RVA: 0x00015108 File Offset: 0x00014508
		public void Cancel()
		{
			this.CheckDisposed();
			if (this._sql == null)
			{
				throw new global::System.InvalidOperationException("Database connection not valid for query cancellation.");
			}
			this._sql.Cancel();
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060001DD RID: 477 RVA: 0x0001513C File Offset: 0x0001453C
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public int Changes
		{
			get
			{
				this.CheckDisposed();
				if (this._sql == null)
				{
					throw new global::System.InvalidOperationException("Database connection not valid for getting number of changes.");
				}
				return this._sql.Changes;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060001DE RID: 478 RVA: 0x00015170 File Offset: 0x00014570
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		public bool AutoCommit
		{
			get
			{
				this.CheckDisposed();
				if (this._sql == null)
				{
					throw new global::System.InvalidOperationException("Database connection not valid for getting autocommit mode.");
				}
				return this._sql.AutoCommit;
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060001DF RID: 479 RVA: 0x000151A4 File Offset: 0x000145A4
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public long MemoryUsed
		{
			get
			{
				this.CheckDisposed();
				if (this._sql == null)
				{
					throw new global::System.InvalidOperationException("Database connection not valid for getting memory used.");
				}
				return this._sql.MemoryUsed;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060001E0 RID: 480 RVA: 0x000151D8 File Offset: 0x000145D8
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		public long MemoryHighwater
		{
			get
			{
				this.CheckDisposed();
				if (this._sql == null)
				{
					throw new global::System.InvalidOperationException("Database connection not valid for getting maximum memory used.");
				}
				return this._sql.MemoryHighwater;
			}
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x0001520C File Offset: 0x0001460C
		public static global::System.Data.SQLite.SQLiteErrorCode SetMemoryStatus(bool value)
		{
			return global::System.Data.SQLite.SQLite3.StaticSetMemoryStatus(value);
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060001E2 RID: 482 RVA: 0x00015220 File Offset: 0x00014620
		public static string DefineConstants
		{
			get
			{
				return global::System.Data.SQLite.SQLite3.DefineConstants;
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060001E3 RID: 483 RVA: 0x00015234 File Offset: 0x00014634
		public static string SQLiteVersion
		{
			get
			{
				return global::System.Data.SQLite.SQLite3.SQLiteVersion;
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060001E4 RID: 484 RVA: 0x00015248 File Offset: 0x00014648
		public static string SQLiteSourceId
		{
			get
			{
				return global::System.Data.SQLite.SQLite3.SQLiteSourceId;
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060001E5 RID: 485 RVA: 0x0001525C File Offset: 0x0001465C
		public static string InteropVersion
		{
			get
			{
				return global::System.Data.SQLite.SQLite3.InteropVersion;
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060001E6 RID: 486 RVA: 0x00015270 File Offset: 0x00014670
		public static string InteropSourceId
		{
			get
			{
				return global::System.Data.SQLite.SQLite3.InteropSourceId;
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060001E7 RID: 487 RVA: 0x00015284 File Offset: 0x00014684
		public static string ProviderVersion
		{
			get
			{
				if (!(global::System.Data.SQLite.SQLiteConnection._assembly != null))
				{
					return null;
				}
				return global::System.Data.SQLite.SQLiteConnection._assembly.GetName().Version.ToString();
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060001E8 RID: 488 RVA: 0x000152B4 File Offset: 0x000146B4
		public static string ProviderSourceId
		{
			get
			{
				if (global::System.Data.SQLite.SQLiteConnection._assembly == null)
				{
					return null;
				}
				string text = null;
				if (global::System.Data.SQLite.SQLiteConnection._assembly.IsDefined(typeof(global::System.Data.SQLite.AssemblySourceIdAttribute), false))
				{
					global::System.Data.SQLite.AssemblySourceIdAttribute assemblySourceIdAttribute = (global::System.Data.SQLite.AssemblySourceIdAttribute)global::System.Data.SQLite.SQLiteConnection._assembly.GetCustomAttributes(typeof(global::System.Data.SQLite.AssemblySourceIdAttribute), false)[0];
					text = assemblySourceIdAttribute.SourceId;
				}
				string text2 = null;
				if (global::System.Data.SQLite.SQLiteConnection._assembly.IsDefined(typeof(global::System.Data.SQLite.AssemblySourceTimeStampAttribute), false))
				{
					global::System.Data.SQLite.AssemblySourceTimeStampAttribute assemblySourceTimeStampAttribute = (global::System.Data.SQLite.AssemblySourceTimeStampAttribute)global::System.Data.SQLite.SQLiteConnection._assembly.GetCustomAttributes(typeof(global::System.Data.SQLite.AssemblySourceTimeStampAttribute), false)[0];
					text2 = assemblySourceTimeStampAttribute.SourceTimeStamp;
				}
				if (text != null || text2 != null)
				{
					if (text == null)
					{
						text = "0000000000000000000000000000000000000000";
					}
					if (text2 == null)
					{
						text2 = "0000-00-00 00:00:00 UTC";
					}
					return string.Format("{0} {1}", text, text2);
				}
				return null;
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060001E9 RID: 489 RVA: 0x00015370 File Offset: 0x00014770
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		public override global::System.Data.ConnectionState State
		{
			get
			{
				this.CheckDisposed();
				return this._connectionState;
			}
		}

		// Token: 0x060001EA RID: 490 RVA: 0x0001538C File Offset: 0x0001478C
		public global::System.Data.SQLite.SQLiteErrorCode Shutdown()
		{
			this.CheckDisposed();
			if (this._sql == null)
			{
				global::System.Collections.Generic.SortedList<string, string> opts = global::System.Data.SQLite.SQLiteConnection.ParseConnectionString(this._connectionString, this._parseViaFramework);
				this.SetupSQLiteBase(opts);
			}
			if (this._sql != null)
			{
				return this._sql.Shutdown();
			}
			throw new global::System.InvalidOperationException("Database connection not active.");
		}

		// Token: 0x060001EB RID: 491 RVA: 0x000153E0 File Offset: 0x000147E0
		public void SetExtendedResultCodes(bool bOnOff)
		{
			this.CheckDisposed();
			if (this._sql != null)
			{
				this._sql.SetExtendedResultCodes(bOnOff);
			}
		}

		// Token: 0x060001EC RID: 492 RVA: 0x00015408 File Offset: 0x00014808
		public global::System.Data.SQLite.SQLiteErrorCode ResultCode()
		{
			this.CheckDisposed();
			if (this._sql == null)
			{
				throw new global::System.InvalidOperationException("Database connection not valid for getting result code.");
			}
			return this._sql.ResultCode();
		}

		// Token: 0x060001ED RID: 493 RVA: 0x0001543C File Offset: 0x0001483C
		public global::System.Data.SQLite.SQLiteErrorCode ExtendedResultCode()
		{
			this.CheckDisposed();
			if (this._sql == null)
			{
				throw new global::System.InvalidOperationException("Database connection not valid for getting extended result code.");
			}
			return this._sql.ExtendedResultCode();
		}

		// Token: 0x060001EE RID: 494 RVA: 0x00015470 File Offset: 0x00014870
		public void LogMessage(global::System.Data.SQLite.SQLiteErrorCode iErrCode, string zMessage)
		{
			this.CheckDisposed();
			if (this._sql == null)
			{
				throw new global::System.InvalidOperationException("Database connection not valid for logging message.");
			}
			this._sql.LogMessage(iErrCode, zMessage);
		}

		// Token: 0x060001EF RID: 495 RVA: 0x000154A4 File Offset: 0x000148A4
		public void LogMessage(int iErrCode, string zMessage)
		{
			this.CheckDisposed();
			if (this._sql == null)
			{
				throw new global::System.InvalidOperationException("Database connection not valid for logging message.");
			}
			this._sql.LogMessage((global::System.Data.SQLite.SQLiteErrorCode)iErrCode, zMessage);
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x000154D8 File Offset: 0x000148D8
		public void ChangePassword(string newPassword)
		{
			this.CheckDisposed();
			this.ChangePassword(string.IsNullOrEmpty(newPassword) ? null : global::System.Text.Encoding.UTF8.GetBytes(newPassword));
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x00015508 File Offset: 0x00014908
		public void ChangePassword(byte[] newPassword)
		{
			this.CheckDisposed();
			if (this._connectionState != global::System.Data.ConnectionState.Open)
			{
				throw new global::System.InvalidOperationException("Database must be opened before changing the password.");
			}
			this._sql.ChangePassword(newPassword);
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x0001553C File Offset: 0x0001493C
		public void SetPassword(string databasePassword)
		{
			this.CheckDisposed();
			this.SetPassword(string.IsNullOrEmpty(databasePassword) ? null : global::System.Text.Encoding.UTF8.GetBytes(databasePassword));
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x0001556C File Offset: 0x0001496C
		public void SetPassword(byte[] databasePassword)
		{
			this.CheckDisposed();
			if (this._connectionState != global::System.Data.ConnectionState.Closed)
			{
				throw new global::System.InvalidOperationException("Password can only be set before the database is opened.");
			}
			if (databasePassword != null && databasePassword.Length == 0)
			{
				databasePassword = null;
			}
			this._password = databasePassword;
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x000155A4 File Offset: 0x000149A4
		public global::System.Data.SQLite.SQLiteErrorCode SetAvRetry(ref int count, ref int interval)
		{
			this.CheckDisposed();
			if (this._connectionState != global::System.Data.ConnectionState.Open)
			{
				throw new global::System.InvalidOperationException("Database must be opened before changing the AV retry parameters.");
			}
			global::System.IntPtr intPtr = global::System.IntPtr.Zero;
			global::System.Data.SQLite.SQLiteErrorCode sqliteErrorCode;
			try
			{
				intPtr = global::System.Runtime.InteropServices.Marshal.AllocHGlobal(8);
				global::System.Runtime.InteropServices.Marshal.WriteInt32(intPtr, 0, count);
				global::System.Runtime.InteropServices.Marshal.WriteInt32(intPtr, 4, interval);
				sqliteErrorCode = this._sql.FileControl(null, 9, intPtr);
				if (sqliteErrorCode == global::System.Data.SQLite.SQLiteErrorCode.Ok)
				{
					count = global::System.Runtime.InteropServices.Marshal.ReadInt32(intPtr, 0);
					interval = global::System.Runtime.InteropServices.Marshal.ReadInt32(intPtr, 4);
				}
			}
			finally
			{
				if (intPtr != global::System.IntPtr.Zero)
				{
					global::System.Runtime.InteropServices.Marshal.FreeHGlobal(intPtr);
				}
			}
			return sqliteErrorCode;
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x00015644 File Offset: 0x00014A44
		private static string UnwrapString(string value)
		{
			if (string.IsNullOrEmpty(value))
			{
				return value;
			}
			int length = value.Length;
			if ((value[0] == '\'' && value[length - 1] == '\'') || (value[0] == '"' && value[length - 1] == '"'))
			{
				return value.Substring(1, length - 2);
			}
			return value;
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x000156A0 File Offset: 0x00014AA0
		private string ExpandFileName(string sourceFile, bool toFullPath)
		{
			if (string.IsNullOrEmpty(sourceFile))
			{
				return sourceFile;
			}
			if (sourceFile.StartsWith("|DataDirectory|", global::System.StringComparison.OrdinalIgnoreCase))
			{
				string text = global::System.AppDomain.CurrentDomain.GetData("DataDirectory") as string;
				if (string.IsNullOrEmpty(text))
				{
					text = global::System.AppDomain.CurrentDomain.BaseDirectory;
				}
				if (sourceFile.Length > "|DataDirectory|".Length && (sourceFile["|DataDirectory|".Length] == global::System.IO.Path.DirectorySeparatorChar || sourceFile["|DataDirectory|".Length] == global::System.IO.Path.AltDirectorySeparatorChar))
				{
					sourceFile = sourceFile.Remove("|DataDirectory|".Length, 1);
				}
				sourceFile = global::System.IO.Path.Combine(text, sourceFile.Substring("|DataDirectory|".Length));
			}
			if (toFullPath)
			{
				sourceFile = global::System.IO.Path.GetFullPath(sourceFile);
			}
			return sourceFile;
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x00015768 File Offset: 0x00014B68
		public override global::System.Data.DataTable GetSchema()
		{
			this.CheckDisposed();
			return this.GetSchema("MetaDataCollections", null);
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x00015788 File Offset: 0x00014B88
		public override global::System.Data.DataTable GetSchema(string collectionName)
		{
			this.CheckDisposed();
			return this.GetSchema(collectionName, new string[0]);
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x000157A8 File Offset: 0x00014BA8
		public override global::System.Data.DataTable GetSchema(string collectionName, string[] restrictionValues)
		{
			this.CheckDisposed();
			if (this._connectionState != global::System.Data.ConnectionState.Open)
			{
				throw new global::System.InvalidOperationException();
			}
			string[] array = new string[5];
			if (restrictionValues == null)
			{
				restrictionValues = new string[0];
			}
			restrictionValues.CopyTo(array, 0);
			string key;
			switch (key = collectionName.ToUpper(global::System.Globalization.CultureInfo.InvariantCulture))
			{
			case "METADATACOLLECTIONS":
				return global::System.Data.SQLite.SQLiteConnection.Schema_MetaDataCollections();
			case "DATASOURCEINFORMATION":
				return this.Schema_DataSourceInformation();
			case "DATATYPES":
				return this.Schema_DataTypes();
			case "COLUMNS":
			case "TABLECOLUMNS":
				return this.Schema_Columns(array[0], array[2], array[3]);
			case "INDEXES":
				return this.Schema_Indexes(array[0], array[2], array[3]);
			case "TRIGGERS":
				return this.Schema_Triggers(array[0], array[2], array[3]);
			case "INDEXCOLUMNS":
				return this.Schema_IndexColumns(array[0], array[2], array[3], array[4]);
			case "TABLES":
				return this.Schema_Tables(array[0], array[2], array[3]);
			case "VIEWS":
				return this.Schema_Views(array[0], array[2]);
			case "VIEWCOLUMNS":
				return this.Schema_ViewColumns(array[0], array[2], array[3]);
			case "FOREIGNKEYS":
				return this.Schema_ForeignKeys(array[0], array[2], array[3]);
			case "CATALOGS":
				return this.Schema_Catalogs(array[0]);
			case "RESERVEDWORDS":
				return global::System.Data.SQLite.SQLiteConnection.Schema_ReservedWords();
			}
			throw new global::System.NotSupportedException();
		}

		// Token: 0x060001FA RID: 506 RVA: 0x000159C0 File Offset: 0x00014DC0
		private static global::System.Data.DataTable Schema_ReservedWords()
		{
			global::System.Data.DataTable dataTable = new global::System.Data.DataTable("ReservedWords");
			dataTable.Locale = global::System.Globalization.CultureInfo.InvariantCulture;
			dataTable.Columns.Add("ReservedWord", typeof(string));
			dataTable.Columns.Add("MaximumVersion", typeof(string));
			dataTable.Columns.Add("MinimumVersion", typeof(string));
			dataTable.BeginLoadData();
			foreach (string value in global::System.Data.SQLite.SR.Keywords.Split(new char[]
			{
				','
			}))
			{
				global::System.Data.DataRow dataRow = dataTable.NewRow();
				dataRow[0] = value;
				dataTable.Rows.Add(dataRow);
			}
			dataTable.AcceptChanges();
			dataTable.EndLoadData();
			return dataTable;
		}

		// Token: 0x060001FB RID: 507 RVA: 0x00015A94 File Offset: 0x00014E94
		private static global::System.Data.DataTable Schema_MetaDataCollections()
		{
			global::System.Data.DataTable dataTable = new global::System.Data.DataTable("MetaDataCollections");
			dataTable.Locale = global::System.Globalization.CultureInfo.InvariantCulture;
			dataTable.Columns.Add("CollectionName", typeof(string));
			dataTable.Columns.Add("NumberOfRestrictions", typeof(int));
			dataTable.Columns.Add("NumberOfIdentifierParts", typeof(int));
			dataTable.BeginLoadData();
			global::System.IO.StringReader stringReader = new global::System.IO.StringReader(global::System.Data.SQLite.SR.MetaDataCollections);
			dataTable.ReadXml(stringReader);
			stringReader.Close();
			dataTable.AcceptChanges();
			dataTable.EndLoadData();
			return dataTable;
		}

		// Token: 0x060001FC RID: 508 RVA: 0x00015B34 File Offset: 0x00014F34
		private global::System.Data.DataTable Schema_DataSourceInformation()
		{
			global::System.Data.DataTable dataTable = new global::System.Data.DataTable("DataSourceInformation");
			dataTable.Locale = global::System.Globalization.CultureInfo.InvariantCulture;
			dataTable.Columns.Add(global::System.Data.Common.DbMetaDataColumnNames.CompositeIdentifierSeparatorPattern, typeof(string));
			dataTable.Columns.Add(global::System.Data.Common.DbMetaDataColumnNames.DataSourceProductName, typeof(string));
			dataTable.Columns.Add(global::System.Data.Common.DbMetaDataColumnNames.DataSourceProductVersion, typeof(string));
			dataTable.Columns.Add(global::System.Data.Common.DbMetaDataColumnNames.DataSourceProductVersionNormalized, typeof(string));
			dataTable.Columns.Add(global::System.Data.Common.DbMetaDataColumnNames.GroupByBehavior, typeof(int));
			dataTable.Columns.Add(global::System.Data.Common.DbMetaDataColumnNames.IdentifierPattern, typeof(string));
			dataTable.Columns.Add(global::System.Data.Common.DbMetaDataColumnNames.IdentifierCase, typeof(int));
			dataTable.Columns.Add(global::System.Data.Common.DbMetaDataColumnNames.OrderByColumnsInSelect, typeof(bool));
			dataTable.Columns.Add(global::System.Data.Common.DbMetaDataColumnNames.ParameterMarkerFormat, typeof(string));
			dataTable.Columns.Add(global::System.Data.Common.DbMetaDataColumnNames.ParameterMarkerPattern, typeof(string));
			dataTable.Columns.Add(global::System.Data.Common.DbMetaDataColumnNames.ParameterNameMaxLength, typeof(int));
			dataTable.Columns.Add(global::System.Data.Common.DbMetaDataColumnNames.ParameterNamePattern, typeof(string));
			dataTable.Columns.Add(global::System.Data.Common.DbMetaDataColumnNames.QuotedIdentifierPattern, typeof(string));
			dataTable.Columns.Add(global::System.Data.Common.DbMetaDataColumnNames.QuotedIdentifierCase, typeof(int));
			dataTable.Columns.Add(global::System.Data.Common.DbMetaDataColumnNames.StatementSeparatorPattern, typeof(string));
			dataTable.Columns.Add(global::System.Data.Common.DbMetaDataColumnNames.StringLiteralPattern, typeof(string));
			dataTable.Columns.Add(global::System.Data.Common.DbMetaDataColumnNames.SupportedJoinOperators, typeof(int));
			dataTable.BeginLoadData();
			global::System.Data.DataRow dataRow = dataTable.NewRow();
			dataRow.ItemArray = new object[]
			{
				null,
				"SQLite",
				this._sql.Version,
				this._sql.Version,
				3,
				"(^\\[\\p{Lo}\\p{Lu}\\p{Ll}_@#][\\p{Lo}\\p{Lu}\\p{Ll}\\p{Nd}@$#_]*$)|(^\\[[^\\]\\0]|\\]\\]+\\]$)|(^\\\"[^\\\"\\0]|\\\"\\\"+\\\"$)",
				1,
				false,
				"{0}",
				"@[\\p{Lo}\\p{Lu}\\p{Ll}\\p{Lm}_@#][\\p{Lo}\\p{Lu}\\p{Ll}\\p{Lm}\\p{Nd}\\uff3f_@#\\$]*(?=\\s+|$)",
				255,
				"^[\\p{Lo}\\p{Lu}\\p{Ll}\\p{Lm}_@#][\\p{Lo}\\p{Lu}\\p{Ll}\\p{Lm}\\p{Nd}\\uff3f_@#\\$]*(?=\\s+|$)",
				"(([^\\[]|\\]\\])*)",
				1,
				";",
				"'(([^']|'')*)'",
				15
			};
			dataTable.Rows.Add(dataRow);
			dataTable.AcceptChanges();
			dataTable.EndLoadData();
			return dataTable;
		}

		// Token: 0x060001FD RID: 509 RVA: 0x00015DF8 File Offset: 0x000151F8
		private global::System.Data.DataTable Schema_Columns(string strCatalog, string strTable, string strColumn)
		{
			global::System.Data.DataTable dataTable = new global::System.Data.DataTable("Columns");
			dataTable.Locale = global::System.Globalization.CultureInfo.InvariantCulture;
			dataTable.Columns.Add("TABLE_CATALOG", typeof(string));
			dataTable.Columns.Add("TABLE_SCHEMA", typeof(string));
			dataTable.Columns.Add("TABLE_NAME", typeof(string));
			dataTable.Columns.Add("COLUMN_NAME", typeof(string));
			dataTable.Columns.Add("COLUMN_GUID", typeof(global::System.Guid));
			dataTable.Columns.Add("COLUMN_PROPID", typeof(long));
			dataTable.Columns.Add("ORDINAL_POSITION", typeof(int));
			dataTable.Columns.Add("COLUMN_HASDEFAULT", typeof(bool));
			dataTable.Columns.Add("COLUMN_DEFAULT", typeof(string));
			dataTable.Columns.Add("COLUMN_FLAGS", typeof(long));
			dataTable.Columns.Add("IS_NULLABLE", typeof(bool));
			dataTable.Columns.Add("DATA_TYPE", typeof(string));
			dataTable.Columns.Add("TYPE_GUID", typeof(global::System.Guid));
			dataTable.Columns.Add("CHARACTER_MAXIMUM_LENGTH", typeof(int));
			dataTable.Columns.Add("CHARACTER_OCTET_LENGTH", typeof(int));
			dataTable.Columns.Add("NUMERIC_PRECISION", typeof(int));
			dataTable.Columns.Add("NUMERIC_SCALE", typeof(int));
			dataTable.Columns.Add("DATETIME_PRECISION", typeof(long));
			dataTable.Columns.Add("CHARACTER_SET_CATALOG", typeof(string));
			dataTable.Columns.Add("CHARACTER_SET_SCHEMA", typeof(string));
			dataTable.Columns.Add("CHARACTER_SET_NAME", typeof(string));
			dataTable.Columns.Add("COLLATION_CATALOG", typeof(string));
			dataTable.Columns.Add("COLLATION_SCHEMA", typeof(string));
			dataTable.Columns.Add("COLLATION_NAME", typeof(string));
			dataTable.Columns.Add("DOMAIN_CATALOG", typeof(string));
			dataTable.Columns.Add("DOMAIN_NAME", typeof(string));
			dataTable.Columns.Add("DESCRIPTION", typeof(string));
			dataTable.Columns.Add("PRIMARY_KEY", typeof(bool));
			dataTable.Columns.Add("EDM_TYPE", typeof(string));
			dataTable.Columns.Add("AUTOINCREMENT", typeof(bool));
			dataTable.Columns.Add("UNIQUE", typeof(bool));
			dataTable.BeginLoadData();
			if (string.IsNullOrEmpty(strCatalog))
			{
				strCatalog = "main";
			}
			string text = (string.Compare(strCatalog, "temp", global::System.StringComparison.OrdinalIgnoreCase) == 0) ? "sqlite_temp_master" : "sqlite_master";
			using (global::System.Data.SQLite.SQLiteCommand sqliteCommand = new global::System.Data.SQLite.SQLiteCommand(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "SELECT * FROM [{0}].[{1}] WHERE [type] LIKE 'table' OR [type] LIKE 'view'", new object[]
			{
				strCatalog,
				text
			}), this))
			{
				using (global::System.Data.SQLite.SQLiteDataReader sqliteDataReader = sqliteCommand.ExecuteReader())
				{
					while (sqliteDataReader.Read())
					{
						if (string.IsNullOrEmpty(strTable) || string.Compare(strTable, sqliteDataReader.GetString(2), global::System.StringComparison.OrdinalIgnoreCase) == 0)
						{
							try
							{
								using (global::System.Data.SQLite.SQLiteCommand sqliteCommand2 = new global::System.Data.SQLite.SQLiteCommand(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "SELECT * FROM [{0}].[{1}]", new object[]
								{
									strCatalog,
									sqliteDataReader.GetString(2)
								}), this))
								{
									using (global::System.Data.SQLite.SQLiteDataReader sqliteDataReader2 = sqliteCommand2.ExecuteReader(global::System.Data.CommandBehavior.SchemaOnly))
									{
										using (global::System.Data.DataTable schemaTable = sqliteDataReader2.GetSchemaTable(true, true))
										{
											foreach (object obj in schemaTable.Rows)
											{
												global::System.Data.DataRow dataRow = (global::System.Data.DataRow)obj;
												if (string.Compare(dataRow[global::System.Data.Common.SchemaTableColumn.ColumnName].ToString(), strColumn, global::System.StringComparison.OrdinalIgnoreCase) == 0 || strColumn == null)
												{
													global::System.Data.DataRow dataRow2 = dataTable.NewRow();
													dataRow2["NUMERIC_PRECISION"] = dataRow[global::System.Data.Common.SchemaTableColumn.NumericPrecision];
													dataRow2["NUMERIC_SCALE"] = dataRow[global::System.Data.Common.SchemaTableColumn.NumericScale];
													dataRow2["TABLE_NAME"] = sqliteDataReader.GetString(2);
													dataRow2["COLUMN_NAME"] = dataRow[global::System.Data.Common.SchemaTableColumn.ColumnName];
													dataRow2["TABLE_CATALOG"] = strCatalog;
													dataRow2["ORDINAL_POSITION"] = dataRow[global::System.Data.Common.SchemaTableColumn.ColumnOrdinal];
													dataRow2["COLUMN_HASDEFAULT"] = (dataRow[global::System.Data.Common.SchemaTableOptionalColumn.DefaultValue] != global::System.DBNull.Value);
													dataRow2["COLUMN_DEFAULT"] = dataRow[global::System.Data.Common.SchemaTableOptionalColumn.DefaultValue];
													dataRow2["IS_NULLABLE"] = dataRow[global::System.Data.Common.SchemaTableColumn.AllowDBNull];
													dataRow2["DATA_TYPE"] = dataRow["DataTypeName"].ToString().ToLower(global::System.Globalization.CultureInfo.InvariantCulture);
													dataRow2["EDM_TYPE"] = global::System.Data.SQLite.SQLiteConvert.DbTypeToTypeName((global::System.Data.DbType)dataRow[global::System.Data.Common.SchemaTableColumn.ProviderType]).ToString().ToLower(global::System.Globalization.CultureInfo.InvariantCulture);
													dataRow2["CHARACTER_MAXIMUM_LENGTH"] = dataRow[global::System.Data.Common.SchemaTableColumn.ColumnSize];
													dataRow2["TABLE_SCHEMA"] = dataRow[global::System.Data.Common.SchemaTableColumn.BaseSchemaName];
													dataRow2["PRIMARY_KEY"] = dataRow[global::System.Data.Common.SchemaTableColumn.IsKey];
													dataRow2["AUTOINCREMENT"] = dataRow[global::System.Data.Common.SchemaTableOptionalColumn.IsAutoIncrement];
													dataRow2["COLLATION_NAME"] = dataRow["CollationType"];
													dataRow2["UNIQUE"] = dataRow[global::System.Data.Common.SchemaTableColumn.IsUnique];
													dataTable.Rows.Add(dataRow2);
												}
											}
										}
									}
								}
							}
							catch (global::System.Data.SQLite.SQLiteException)
							{
							}
						}
					}
				}
			}
			dataTable.AcceptChanges();
			dataTable.EndLoadData();
			return dataTable;
		}

		// Token: 0x060001FE RID: 510 RVA: 0x00016550 File Offset: 0x00015950
		private global::System.Data.DataTable Schema_Indexes(string strCatalog, string strTable, string strIndex)
		{
			global::System.Data.DataTable dataTable = new global::System.Data.DataTable("Indexes");
			global::System.Collections.Generic.List<int> list = new global::System.Collections.Generic.List<int>();
			dataTable.Locale = global::System.Globalization.CultureInfo.InvariantCulture;
			dataTable.Columns.Add("TABLE_CATALOG", typeof(string));
			dataTable.Columns.Add("TABLE_SCHEMA", typeof(string));
			dataTable.Columns.Add("TABLE_NAME", typeof(string));
			dataTable.Columns.Add("INDEX_CATALOG", typeof(string));
			dataTable.Columns.Add("INDEX_SCHEMA", typeof(string));
			dataTable.Columns.Add("INDEX_NAME", typeof(string));
			dataTable.Columns.Add("PRIMARY_KEY", typeof(bool));
			dataTable.Columns.Add("UNIQUE", typeof(bool));
			dataTable.Columns.Add("CLUSTERED", typeof(bool));
			dataTable.Columns.Add("TYPE", typeof(int));
			dataTable.Columns.Add("FILL_FACTOR", typeof(int));
			dataTable.Columns.Add("INITIAL_SIZE", typeof(int));
			dataTable.Columns.Add("NULLS", typeof(int));
			dataTable.Columns.Add("SORT_BOOKMARKS", typeof(bool));
			dataTable.Columns.Add("AUTO_UPDATE", typeof(bool));
			dataTable.Columns.Add("NULL_COLLATION", typeof(int));
			dataTable.Columns.Add("ORDINAL_POSITION", typeof(int));
			dataTable.Columns.Add("COLUMN_NAME", typeof(string));
			dataTable.Columns.Add("COLUMN_GUID", typeof(global::System.Guid));
			dataTable.Columns.Add("COLUMN_PROPID", typeof(long));
			dataTable.Columns.Add("COLLATION", typeof(short));
			dataTable.Columns.Add("CARDINALITY", typeof(decimal));
			dataTable.Columns.Add("PAGES", typeof(int));
			dataTable.Columns.Add("FILTER_CONDITION", typeof(string));
			dataTable.Columns.Add("INTEGRATED", typeof(bool));
			dataTable.Columns.Add("INDEX_DEFINITION", typeof(string));
			dataTable.BeginLoadData();
			if (string.IsNullOrEmpty(strCatalog))
			{
				strCatalog = "main";
			}
			string text = (string.Compare(strCatalog, "temp", global::System.StringComparison.OrdinalIgnoreCase) == 0) ? "sqlite_temp_master" : "sqlite_master";
			using (global::System.Data.SQLite.SQLiteCommand sqliteCommand = new global::System.Data.SQLite.SQLiteCommand(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "SELECT * FROM [{0}].[{1}] WHERE [type] LIKE 'table'", new object[]
			{
				strCatalog,
				text
			}), this))
			{
				using (global::System.Data.SQLite.SQLiteDataReader sqliteDataReader = sqliteCommand.ExecuteReader())
				{
					while (sqliteDataReader.Read())
					{
						bool flag = false;
						list.Clear();
						if (string.IsNullOrEmpty(strTable) || string.Compare(sqliteDataReader.GetString(2), strTable, global::System.StringComparison.OrdinalIgnoreCase) == 0)
						{
							try
							{
								using (global::System.Data.SQLite.SQLiteCommand sqliteCommand2 = new global::System.Data.SQLite.SQLiteCommand(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "PRAGMA [{0}].table_info([{1}])", new object[]
								{
									strCatalog,
									sqliteDataReader.GetString(2)
								}), this))
								{
									using (global::System.Data.SQLite.SQLiteDataReader sqliteDataReader2 = sqliteCommand2.ExecuteReader())
									{
										while (sqliteDataReader2.Read())
										{
											if (sqliteDataReader2.GetInt32(5) != 0)
											{
												list.Add(sqliteDataReader2.GetInt32(0));
												if (string.Compare(sqliteDataReader2.GetString(2), "INTEGER", global::System.StringComparison.OrdinalIgnoreCase) == 0)
												{
													flag = true;
												}
											}
										}
									}
								}
							}
							catch (global::System.Data.SQLite.SQLiteException)
							{
							}
							if (list.Count == 1 && flag)
							{
								global::System.Data.DataRow dataRow = dataTable.NewRow();
								dataRow["TABLE_CATALOG"] = strCatalog;
								dataRow["TABLE_NAME"] = sqliteDataReader.GetString(2);
								dataRow["INDEX_CATALOG"] = strCatalog;
								dataRow["PRIMARY_KEY"] = true;
								dataRow["INDEX_NAME"] = string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "{1}_PK_{0}", new object[]
								{
									sqliteDataReader.GetString(2),
									text
								});
								dataRow["UNIQUE"] = true;
								if (string.Compare((string)dataRow["INDEX_NAME"], strIndex, global::System.StringComparison.OrdinalIgnoreCase) == 0 || strIndex == null)
								{
									dataTable.Rows.Add(dataRow);
								}
								list.Clear();
							}
							try
							{
								using (global::System.Data.SQLite.SQLiteCommand sqliteCommand3 = new global::System.Data.SQLite.SQLiteCommand(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "PRAGMA [{0}].index_list([{1}])", new object[]
								{
									strCatalog,
									sqliteDataReader.GetString(2)
								}), this))
								{
									using (global::System.Data.SQLite.SQLiteDataReader sqliteDataReader3 = sqliteCommand3.ExecuteReader())
									{
										while (sqliteDataReader3.Read())
										{
											if (string.Compare(sqliteDataReader3.GetString(1), strIndex, global::System.StringComparison.OrdinalIgnoreCase) == 0 || strIndex == null)
											{
												global::System.Data.DataRow dataRow = dataTable.NewRow();
												dataRow["TABLE_CATALOG"] = strCatalog;
												dataRow["TABLE_NAME"] = sqliteDataReader.GetString(2);
												dataRow["INDEX_CATALOG"] = strCatalog;
												dataRow["INDEX_NAME"] = sqliteDataReader3.GetString(1);
												dataRow["UNIQUE"] = sqliteDataReader3.GetBoolean(2);
												dataRow["PRIMARY_KEY"] = false;
												using (global::System.Data.SQLite.SQLiteCommand sqliteCommand4 = new global::System.Data.SQLite.SQLiteCommand(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "SELECT * FROM [{0}].[{2}] WHERE [type] LIKE 'index' AND [name] LIKE '{1}'", new object[]
												{
													strCatalog,
													sqliteDataReader3.GetString(1).Replace("'", "''"),
													text
												}), this))
												{
													using (global::System.Data.SQLite.SQLiteDataReader sqliteDataReader4 = sqliteCommand4.ExecuteReader())
													{
														if (sqliteDataReader4.Read() && !sqliteDataReader4.IsDBNull(4))
														{
															dataRow["INDEX_DEFINITION"] = sqliteDataReader4.GetString(4);
														}
													}
												}
												if (list.Count > 0 && sqliteDataReader3.GetString(1).StartsWith("sqlite_autoindex_" + sqliteDataReader.GetString(2), global::System.StringComparison.InvariantCultureIgnoreCase))
												{
													using (global::System.Data.SQLite.SQLiteCommand sqliteCommand5 = new global::System.Data.SQLite.SQLiteCommand(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "PRAGMA [{0}].index_info([{1}])", new object[]
													{
														strCatalog,
														sqliteDataReader3.GetString(1)
													}), this))
													{
														using (global::System.Data.SQLite.SQLiteDataReader sqliteDataReader5 = sqliteCommand5.ExecuteReader())
														{
															int num = 0;
															while (sqliteDataReader5.Read())
															{
																if (!list.Contains(sqliteDataReader5.GetInt32(1)))
																{
																	num = 0;
																	break;
																}
																num++;
															}
															if (num == list.Count)
															{
																dataRow["PRIMARY_KEY"] = true;
																list.Clear();
															}
														}
													}
												}
												dataTable.Rows.Add(dataRow);
											}
										}
									}
								}
							}
							catch (global::System.Data.SQLite.SQLiteException)
							{
							}
						}
					}
				}
			}
			dataTable.AcceptChanges();
			dataTable.EndLoadData();
			return dataTable;
		}

		// Token: 0x060001FF RID: 511 RVA: 0x00016DE0 File Offset: 0x000161E0
		private global::System.Data.DataTable Schema_Triggers(string catalog, string table, string triggerName)
		{
			global::System.Data.DataTable dataTable = new global::System.Data.DataTable("Triggers");
			dataTable.Locale = global::System.Globalization.CultureInfo.InvariantCulture;
			dataTable.Columns.Add("TABLE_CATALOG", typeof(string));
			dataTable.Columns.Add("TABLE_SCHEMA", typeof(string));
			dataTable.Columns.Add("TABLE_NAME", typeof(string));
			dataTable.Columns.Add("TRIGGER_NAME", typeof(string));
			dataTable.Columns.Add("TRIGGER_DEFINITION", typeof(string));
			dataTable.BeginLoadData();
			if (string.IsNullOrEmpty(table))
			{
				table = null;
			}
			if (string.IsNullOrEmpty(catalog))
			{
				catalog = "main";
			}
			string text = (string.Compare(catalog, "temp", global::System.StringComparison.OrdinalIgnoreCase) == 0) ? "sqlite_temp_master" : "sqlite_master";
			using (global::System.Data.SQLite.SQLiteCommand sqliteCommand = new global::System.Data.SQLite.SQLiteCommand(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "SELECT [type], [name], [tbl_name], [rootpage], [sql], [rowid] FROM [{0}].[{1}] WHERE [type] LIKE 'trigger'", new object[]
			{
				catalog,
				text
			}), this))
			{
				using (global::System.Data.SQLite.SQLiteDataReader sqliteDataReader = sqliteCommand.ExecuteReader())
				{
					while (sqliteDataReader.Read())
					{
						if ((string.Compare(sqliteDataReader.GetString(1), triggerName, global::System.StringComparison.OrdinalIgnoreCase) == 0 || triggerName == null) && (table == null || string.Compare(table, sqliteDataReader.GetString(2), global::System.StringComparison.OrdinalIgnoreCase) == 0))
						{
							global::System.Data.DataRow dataRow = dataTable.NewRow();
							dataRow["TABLE_CATALOG"] = catalog;
							dataRow["TABLE_NAME"] = sqliteDataReader.GetString(2);
							dataRow["TRIGGER_NAME"] = sqliteDataReader.GetString(1);
							dataRow["TRIGGER_DEFINITION"] = sqliteDataReader.GetString(4);
							dataTable.Rows.Add(dataRow);
						}
					}
				}
			}
			dataTable.AcceptChanges();
			dataTable.EndLoadData();
			return dataTable;
		}

		// Token: 0x06000200 RID: 512 RVA: 0x00016FDC File Offset: 0x000163DC
		private global::System.Data.DataTable Schema_Tables(string strCatalog, string strTable, string strType)
		{
			global::System.Data.DataTable dataTable = new global::System.Data.DataTable("Tables");
			dataTable.Locale = global::System.Globalization.CultureInfo.InvariantCulture;
			dataTable.Columns.Add("TABLE_CATALOG", typeof(string));
			dataTable.Columns.Add("TABLE_SCHEMA", typeof(string));
			dataTable.Columns.Add("TABLE_NAME", typeof(string));
			dataTable.Columns.Add("TABLE_TYPE", typeof(string));
			dataTable.Columns.Add("TABLE_ID", typeof(long));
			dataTable.Columns.Add("TABLE_ROOTPAGE", typeof(int));
			dataTable.Columns.Add("TABLE_DEFINITION", typeof(string));
			dataTable.BeginLoadData();
			if (string.IsNullOrEmpty(strCatalog))
			{
				strCatalog = "main";
			}
			string text = (string.Compare(strCatalog, "temp", global::System.StringComparison.OrdinalIgnoreCase) == 0) ? "sqlite_temp_master" : "sqlite_master";
			using (global::System.Data.SQLite.SQLiteCommand sqliteCommand = new global::System.Data.SQLite.SQLiteCommand(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "SELECT [type], [name], [tbl_name], [rootpage], [sql], [rowid] FROM [{0}].[{1}] WHERE [type] LIKE 'table'", new object[]
			{
				strCatalog,
				text
			}), this))
			{
				using (global::System.Data.SQLite.SQLiteDataReader sqliteDataReader = sqliteCommand.ExecuteReader())
				{
					while (sqliteDataReader.Read())
					{
						string text2 = sqliteDataReader.GetString(0);
						if (string.Compare(sqliteDataReader.GetString(2), 0, "SQLITE_", 0, 7, global::System.StringComparison.OrdinalIgnoreCase) == 0)
						{
							text2 = "SYSTEM_TABLE";
						}
						if ((string.Compare(strType, text2, global::System.StringComparison.OrdinalIgnoreCase) == 0 || strType == null) && (string.Compare(sqliteDataReader.GetString(2), strTable, global::System.StringComparison.OrdinalIgnoreCase) == 0 || strTable == null))
						{
							global::System.Data.DataRow dataRow = dataTable.NewRow();
							dataRow["TABLE_CATALOG"] = strCatalog;
							dataRow["TABLE_NAME"] = sqliteDataReader.GetString(2);
							dataRow["TABLE_TYPE"] = text2;
							dataRow["TABLE_ID"] = sqliteDataReader.GetInt64(5);
							dataRow["TABLE_ROOTPAGE"] = sqliteDataReader.GetInt32(3);
							dataRow["TABLE_DEFINITION"] = sqliteDataReader.GetString(4);
							dataTable.Rows.Add(dataRow);
						}
					}
				}
			}
			dataTable.AcceptChanges();
			dataTable.EndLoadData();
			return dataTable;
		}

		// Token: 0x06000201 RID: 513 RVA: 0x00017254 File Offset: 0x00016654
		private global::System.Data.DataTable Schema_Views(string strCatalog, string strView)
		{
			global::System.Data.DataTable dataTable = new global::System.Data.DataTable("Views");
			dataTable.Locale = global::System.Globalization.CultureInfo.InvariantCulture;
			dataTable.Columns.Add("TABLE_CATALOG", typeof(string));
			dataTable.Columns.Add("TABLE_SCHEMA", typeof(string));
			dataTable.Columns.Add("TABLE_NAME", typeof(string));
			dataTable.Columns.Add("VIEW_DEFINITION", typeof(string));
			dataTable.Columns.Add("CHECK_OPTION", typeof(bool));
			dataTable.Columns.Add("IS_UPDATABLE", typeof(bool));
			dataTable.Columns.Add("DESCRIPTION", typeof(string));
			dataTable.Columns.Add("DATE_CREATED", typeof(global::System.DateTime));
			dataTable.Columns.Add("DATE_MODIFIED", typeof(global::System.DateTime));
			dataTable.BeginLoadData();
			if (string.IsNullOrEmpty(strCatalog))
			{
				strCatalog = "main";
			}
			string text = (string.Compare(strCatalog, "temp", global::System.StringComparison.OrdinalIgnoreCase) == 0) ? "sqlite_temp_master" : "sqlite_master";
			using (global::System.Data.SQLite.SQLiteCommand sqliteCommand = new global::System.Data.SQLite.SQLiteCommand(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "SELECT * FROM [{0}].[{1}] WHERE [type] LIKE 'view'", new object[]
			{
				strCatalog,
				text
			}), this))
			{
				using (global::System.Data.SQLite.SQLiteDataReader sqliteDataReader = sqliteCommand.ExecuteReader())
				{
					while (sqliteDataReader.Read())
					{
						if (string.Compare(sqliteDataReader.GetString(1), strView, global::System.StringComparison.OrdinalIgnoreCase) == 0 || string.IsNullOrEmpty(strView))
						{
							string text2 = sqliteDataReader.GetString(4).Replace('\r', ' ').Replace('\n', ' ').Replace('\t', ' ');
							int num = global::System.Globalization.CultureInfo.InvariantCulture.CompareInfo.IndexOf(text2, " AS ", global::System.Globalization.CompareOptions.IgnoreCase);
							if (num > -1)
							{
								text2 = text2.Substring(num + 4).Trim();
								global::System.Data.DataRow dataRow = dataTable.NewRow();
								dataRow["TABLE_CATALOG"] = strCatalog;
								dataRow["TABLE_NAME"] = sqliteDataReader.GetString(2);
								dataRow["IS_UPDATABLE"] = false;
								dataRow["VIEW_DEFINITION"] = text2;
								dataTable.Rows.Add(dataRow);
							}
						}
					}
				}
			}
			dataTable.AcceptChanges();
			dataTable.EndLoadData();
			return dataTable;
		}

		// Token: 0x06000202 RID: 514 RVA: 0x000174F4 File Offset: 0x000168F4
		private global::System.Data.DataTable Schema_Catalogs(string strCatalog)
		{
			global::System.Data.DataTable dataTable = new global::System.Data.DataTable("Catalogs");
			dataTable.Locale = global::System.Globalization.CultureInfo.InvariantCulture;
			dataTable.Columns.Add("CATALOG_NAME", typeof(string));
			dataTable.Columns.Add("DESCRIPTION", typeof(string));
			dataTable.Columns.Add("ID", typeof(long));
			dataTable.BeginLoadData();
			using (global::System.Data.SQLite.SQLiteCommand sqliteCommand = new global::System.Data.SQLite.SQLiteCommand("PRAGMA database_list", this))
			{
				using (global::System.Data.SQLite.SQLiteDataReader sqliteDataReader = sqliteCommand.ExecuteReader())
				{
					while (sqliteDataReader.Read())
					{
						if (string.Compare(sqliteDataReader.GetString(1), strCatalog, global::System.StringComparison.OrdinalIgnoreCase) == 0 || strCatalog == null)
						{
							global::System.Data.DataRow dataRow = dataTable.NewRow();
							dataRow["CATALOG_NAME"] = sqliteDataReader.GetString(1);
							dataRow["DESCRIPTION"] = sqliteDataReader.GetString(2);
							dataRow["ID"] = sqliteDataReader.GetInt64(0);
							dataTable.Rows.Add(dataRow);
						}
					}
				}
			}
			dataTable.AcceptChanges();
			dataTable.EndLoadData();
			return dataTable;
		}

		// Token: 0x06000203 RID: 515 RVA: 0x00017648 File Offset: 0x00016A48
		private global::System.Data.DataTable Schema_DataTypes()
		{
			global::System.Data.DataTable dataTable = new global::System.Data.DataTable("DataTypes");
			dataTable.Locale = global::System.Globalization.CultureInfo.InvariantCulture;
			dataTable.Columns.Add("TypeName", typeof(string));
			dataTable.Columns.Add("ProviderDbType", typeof(int));
			dataTable.Columns.Add("ColumnSize", typeof(long));
			dataTable.Columns.Add("CreateFormat", typeof(string));
			dataTable.Columns.Add("CreateParameters", typeof(string));
			dataTable.Columns.Add("DataType", typeof(string));
			dataTable.Columns.Add("IsAutoIncrementable", typeof(bool));
			dataTable.Columns.Add("IsBestMatch", typeof(bool));
			dataTable.Columns.Add("IsCaseSensitive", typeof(bool));
			dataTable.Columns.Add("IsFixedLength", typeof(bool));
			dataTable.Columns.Add("IsFixedPrecisionScale", typeof(bool));
			dataTable.Columns.Add("IsLong", typeof(bool));
			dataTable.Columns.Add("IsNullable", typeof(bool));
			dataTable.Columns.Add("IsSearchable", typeof(bool));
			dataTable.Columns.Add("IsSearchableWithLike", typeof(bool));
			dataTable.Columns.Add("IsLiteralSupported", typeof(bool));
			dataTable.Columns.Add("LiteralPrefix", typeof(string));
			dataTable.Columns.Add("LiteralSuffix", typeof(string));
			dataTable.Columns.Add("IsUnsigned", typeof(bool));
			dataTable.Columns.Add("MaximumScale", typeof(short));
			dataTable.Columns.Add("MinimumScale", typeof(short));
			dataTable.Columns.Add("IsConcurrencyType", typeof(bool));
			dataTable.BeginLoadData();
			global::System.IO.StringReader stringReader = new global::System.IO.StringReader(global::System.Data.SQLite.SR.DataTypes);
			dataTable.ReadXml(stringReader);
			stringReader.Close();
			dataTable.AcceptChanges();
			dataTable.EndLoadData();
			return dataTable;
		}

		// Token: 0x06000204 RID: 516 RVA: 0x000178EC File Offset: 0x00016CEC
		private global::System.Data.DataTable Schema_IndexColumns(string strCatalog, string strTable, string strIndex, string strColumn)
		{
			global::System.Data.DataTable dataTable = new global::System.Data.DataTable("IndexColumns");
			global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<int, string>> list = new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<int, string>>();
			dataTable.Locale = global::System.Globalization.CultureInfo.InvariantCulture;
			dataTable.Columns.Add("CONSTRAINT_CATALOG", typeof(string));
			dataTable.Columns.Add("CONSTRAINT_SCHEMA", typeof(string));
			dataTable.Columns.Add("CONSTRAINT_NAME", typeof(string));
			dataTable.Columns.Add("TABLE_CATALOG", typeof(string));
			dataTable.Columns.Add("TABLE_SCHEMA", typeof(string));
			dataTable.Columns.Add("TABLE_NAME", typeof(string));
			dataTable.Columns.Add("COLUMN_NAME", typeof(string));
			dataTable.Columns.Add("ORDINAL_POSITION", typeof(int));
			dataTable.Columns.Add("INDEX_NAME", typeof(string));
			dataTable.Columns.Add("COLLATION_NAME", typeof(string));
			dataTable.Columns.Add("SORT_MODE", typeof(string));
			dataTable.Columns.Add("CONFLICT_OPTION", typeof(int));
			if (string.IsNullOrEmpty(strCatalog))
			{
				strCatalog = "main";
			}
			string text = (string.Compare(strCatalog, "temp", global::System.StringComparison.OrdinalIgnoreCase) == 0) ? "sqlite_temp_master" : "sqlite_master";
			dataTable.BeginLoadData();
			using (global::System.Data.SQLite.SQLiteCommand sqliteCommand = new global::System.Data.SQLite.SQLiteCommand(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "SELECT * FROM [{0}].[{1}] WHERE [type] LIKE 'table'", new object[]
			{
				strCatalog,
				text
			}), this))
			{
				using (global::System.Data.SQLite.SQLiteDataReader sqliteDataReader = sqliteCommand.ExecuteReader())
				{
					while (sqliteDataReader.Read())
					{
						bool flag = false;
						list.Clear();
						if (string.IsNullOrEmpty(strTable) || string.Compare(sqliteDataReader.GetString(2), strTable, global::System.StringComparison.OrdinalIgnoreCase) == 0)
						{
							try
							{
								using (global::System.Data.SQLite.SQLiteCommand sqliteCommand2 = new global::System.Data.SQLite.SQLiteCommand(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "PRAGMA [{0}].table_info([{1}])", new object[]
								{
									strCatalog,
									sqliteDataReader.GetString(2)
								}), this))
								{
									using (global::System.Data.SQLite.SQLiteDataReader sqliteDataReader2 = sqliteCommand2.ExecuteReader())
									{
										while (sqliteDataReader2.Read())
										{
											if (sqliteDataReader2.GetInt32(5) == 1)
											{
												list.Add(new global::System.Collections.Generic.KeyValuePair<int, string>(sqliteDataReader2.GetInt32(0), sqliteDataReader2.GetString(1)));
												if (string.Compare(sqliteDataReader2.GetString(2), "INTEGER", global::System.StringComparison.OrdinalIgnoreCase) == 0)
												{
													flag = true;
												}
											}
										}
									}
								}
							}
							catch (global::System.Data.SQLite.SQLiteException)
							{
							}
							if (list.Count == 1 && flag)
							{
								global::System.Data.DataRow dataRow = dataTable.NewRow();
								dataRow["CONSTRAINT_CATALOG"] = strCatalog;
								dataRow["CONSTRAINT_NAME"] = string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "{1}_PK_{0}", new object[]
								{
									sqliteDataReader.GetString(2),
									text
								});
								dataRow["TABLE_CATALOG"] = strCatalog;
								dataRow["TABLE_NAME"] = sqliteDataReader.GetString(2);
								dataRow["COLUMN_NAME"] = list[0].Value;
								dataRow["INDEX_NAME"] = dataRow["CONSTRAINT_NAME"];
								dataRow["ORDINAL_POSITION"] = 0;
								dataRow["COLLATION_NAME"] = "BINARY";
								dataRow["SORT_MODE"] = "ASC";
								dataRow["CONFLICT_OPTION"] = 2;
								if (string.IsNullOrEmpty(strIndex) || string.Compare(strIndex, (string)dataRow["INDEX_NAME"], global::System.StringComparison.OrdinalIgnoreCase) == 0)
								{
									dataTable.Rows.Add(dataRow);
								}
							}
							using (global::System.Data.SQLite.SQLiteCommand sqliteCommand3 = new global::System.Data.SQLite.SQLiteCommand(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "SELECT * FROM [{0}].[{2}] WHERE [type] LIKE 'index' AND [tbl_name] LIKE '{1}'", new object[]
							{
								strCatalog,
								sqliteDataReader.GetString(2).Replace("'", "''"),
								text
							}), this))
							{
								using (global::System.Data.SQLite.SQLiteDataReader sqliteDataReader3 = sqliteCommand3.ExecuteReader())
								{
									while (sqliteDataReader3.Read())
									{
										int num = 0;
										if (string.IsNullOrEmpty(strIndex) || string.Compare(strIndex, sqliteDataReader3.GetString(1), global::System.StringComparison.OrdinalIgnoreCase) == 0)
										{
											try
											{
												using (global::System.Data.SQLite.SQLiteCommand sqliteCommand4 = new global::System.Data.SQLite.SQLiteCommand(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "PRAGMA [{0}].index_info([{1}])", new object[]
												{
													strCatalog,
													sqliteDataReader3.GetString(1)
												}), this))
												{
													using (global::System.Data.SQLite.SQLiteDataReader sqliteDataReader4 = sqliteCommand4.ExecuteReader())
													{
														while (sqliteDataReader4.Read())
														{
															global::System.Data.DataRow dataRow = dataTable.NewRow();
															dataRow["CONSTRAINT_CATALOG"] = strCatalog;
															dataRow["CONSTRAINT_NAME"] = sqliteDataReader3.GetString(1);
															dataRow["TABLE_CATALOG"] = strCatalog;
															dataRow["TABLE_NAME"] = sqliteDataReader3.GetString(2);
															dataRow["COLUMN_NAME"] = sqliteDataReader4.GetString(2);
															dataRow["INDEX_NAME"] = sqliteDataReader3.GetString(1);
															dataRow["ORDINAL_POSITION"] = num;
															int num2;
															int num3;
															string value;
															this._sql.GetIndexColumnExtendedInfo(strCatalog, sqliteDataReader3.GetString(1), sqliteDataReader4.GetString(2), out num2, out num3, out value);
															if (!string.IsNullOrEmpty(value))
															{
																dataRow["COLLATION_NAME"] = value;
															}
															dataRow["SORT_MODE"] = ((num2 == 0) ? "ASC" : "DESC");
															dataRow["CONFLICT_OPTION"] = num3;
															num++;
															if (string.IsNullOrEmpty(strColumn) || string.Compare(strColumn, dataRow["COLUMN_NAME"].ToString(), global::System.StringComparison.OrdinalIgnoreCase) == 0)
															{
																dataTable.Rows.Add(dataRow);
															}
														}
													}
												}
											}
											catch (global::System.Data.SQLite.SQLiteException)
											{
											}
										}
									}
								}
							}
						}
					}
				}
			}
			dataTable.EndLoadData();
			dataTable.AcceptChanges();
			return dataTable;
		}

		// Token: 0x06000205 RID: 517 RVA: 0x00017FE8 File Offset: 0x000173E8
		private global::System.Data.DataTable Schema_ViewColumns(string strCatalog, string strView, string strColumn)
		{
			global::System.Data.DataTable dataTable = new global::System.Data.DataTable("ViewColumns");
			dataTable.Locale = global::System.Globalization.CultureInfo.InvariantCulture;
			dataTable.Columns.Add("VIEW_CATALOG", typeof(string));
			dataTable.Columns.Add("VIEW_SCHEMA", typeof(string));
			dataTable.Columns.Add("VIEW_NAME", typeof(string));
			dataTable.Columns.Add("VIEW_COLUMN_NAME", typeof(string));
			dataTable.Columns.Add("TABLE_CATALOG", typeof(string));
			dataTable.Columns.Add("TABLE_SCHEMA", typeof(string));
			dataTable.Columns.Add("TABLE_NAME", typeof(string));
			dataTable.Columns.Add("COLUMN_NAME", typeof(string));
			dataTable.Columns.Add("ORDINAL_POSITION", typeof(int));
			dataTable.Columns.Add("COLUMN_HASDEFAULT", typeof(bool));
			dataTable.Columns.Add("COLUMN_DEFAULT", typeof(string));
			dataTable.Columns.Add("COLUMN_FLAGS", typeof(long));
			dataTable.Columns.Add("IS_NULLABLE", typeof(bool));
			dataTable.Columns.Add("DATA_TYPE", typeof(string));
			dataTable.Columns.Add("CHARACTER_MAXIMUM_LENGTH", typeof(int));
			dataTable.Columns.Add("NUMERIC_PRECISION", typeof(int));
			dataTable.Columns.Add("NUMERIC_SCALE", typeof(int));
			dataTable.Columns.Add("DATETIME_PRECISION", typeof(long));
			dataTable.Columns.Add("CHARACTER_SET_CATALOG", typeof(string));
			dataTable.Columns.Add("CHARACTER_SET_SCHEMA", typeof(string));
			dataTable.Columns.Add("CHARACTER_SET_NAME", typeof(string));
			dataTable.Columns.Add("COLLATION_CATALOG", typeof(string));
			dataTable.Columns.Add("COLLATION_SCHEMA", typeof(string));
			dataTable.Columns.Add("COLLATION_NAME", typeof(string));
			dataTable.Columns.Add("PRIMARY_KEY", typeof(bool));
			dataTable.Columns.Add("EDM_TYPE", typeof(string));
			dataTable.Columns.Add("AUTOINCREMENT", typeof(bool));
			dataTable.Columns.Add("UNIQUE", typeof(bool));
			if (string.IsNullOrEmpty(strCatalog))
			{
				strCatalog = "main";
			}
			string text = (string.Compare(strCatalog, "temp", global::System.StringComparison.OrdinalIgnoreCase) == 0) ? "sqlite_temp_master" : "sqlite_master";
			dataTable.BeginLoadData();
			using (global::System.Data.SQLite.SQLiteCommand sqliteCommand = new global::System.Data.SQLite.SQLiteCommand(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "SELECT * FROM [{0}].[{1}] WHERE [type] LIKE 'view'", new object[]
			{
				strCatalog,
				text
			}), this))
			{
				using (global::System.Data.SQLite.SQLiteDataReader sqliteDataReader = sqliteCommand.ExecuteReader())
				{
					while (sqliteDataReader.Read())
					{
						if (string.IsNullOrEmpty(strView) || string.Compare(strView, sqliteDataReader.GetString(2), global::System.StringComparison.OrdinalIgnoreCase) == 0)
						{
							using (global::System.Data.SQLite.SQLiteCommand sqliteCommand2 = new global::System.Data.SQLite.SQLiteCommand(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "SELECT * FROM [{0}].[{1}]", new object[]
							{
								strCatalog,
								sqliteDataReader.GetString(2)
							}), this))
							{
								string text2 = sqliteDataReader.GetString(4).Replace('\r', ' ').Replace('\n', ' ').Replace('\t', ' ');
								int i = global::System.Globalization.CultureInfo.InvariantCulture.CompareInfo.IndexOf(text2, " AS ", global::System.Globalization.CompareOptions.IgnoreCase);
								if (i >= 0)
								{
									text2 = text2.Substring(i + 4);
									using (global::System.Data.SQLite.SQLiteCommand sqliteCommand3 = new global::System.Data.SQLite.SQLiteCommand(text2, this))
									{
										using (global::System.Data.SQLite.SQLiteDataReader sqliteDataReader2 = sqliteCommand2.ExecuteReader(global::System.Data.CommandBehavior.SchemaOnly))
										{
											using (global::System.Data.SQLite.SQLiteDataReader sqliteDataReader3 = sqliteCommand3.ExecuteReader(global::System.Data.CommandBehavior.SchemaOnly))
											{
												using (global::System.Data.DataTable schemaTable = sqliteDataReader2.GetSchemaTable(false, false))
												{
													using (global::System.Data.DataTable schemaTable2 = sqliteDataReader3.GetSchemaTable(false, false))
													{
														for (i = 0; i < schemaTable2.Rows.Count; i++)
														{
															global::System.Data.DataRow dataRow = schemaTable.Rows[i];
															global::System.Data.DataRow dataRow2 = schemaTable2.Rows[i];
															if (string.Compare(dataRow[global::System.Data.Common.SchemaTableColumn.ColumnName].ToString(), strColumn, global::System.StringComparison.OrdinalIgnoreCase) == 0 || strColumn == null)
															{
																global::System.Data.DataRow dataRow3 = dataTable.NewRow();
																dataRow3["VIEW_CATALOG"] = strCatalog;
																dataRow3["VIEW_NAME"] = sqliteDataReader.GetString(2);
																dataRow3["TABLE_CATALOG"] = strCatalog;
																dataRow3["TABLE_SCHEMA"] = dataRow2[global::System.Data.Common.SchemaTableColumn.BaseSchemaName];
																dataRow3["TABLE_NAME"] = dataRow2[global::System.Data.Common.SchemaTableColumn.BaseTableName];
																dataRow3["COLUMN_NAME"] = dataRow2[global::System.Data.Common.SchemaTableColumn.BaseColumnName];
																dataRow3["VIEW_COLUMN_NAME"] = dataRow[global::System.Data.Common.SchemaTableColumn.ColumnName];
																dataRow3["COLUMN_HASDEFAULT"] = (dataRow[global::System.Data.Common.SchemaTableOptionalColumn.DefaultValue] != global::System.DBNull.Value);
																dataRow3["COLUMN_DEFAULT"] = dataRow[global::System.Data.Common.SchemaTableOptionalColumn.DefaultValue];
																dataRow3["ORDINAL_POSITION"] = dataRow[global::System.Data.Common.SchemaTableColumn.ColumnOrdinal];
																dataRow3["IS_NULLABLE"] = dataRow[global::System.Data.Common.SchemaTableColumn.AllowDBNull];
																dataRow3["DATA_TYPE"] = dataRow["DataTypeName"];
																dataRow3["EDM_TYPE"] = global::System.Data.SQLite.SQLiteConvert.DbTypeToTypeName((global::System.Data.DbType)dataRow[global::System.Data.Common.SchemaTableColumn.ProviderType]).ToString().ToLower(global::System.Globalization.CultureInfo.InvariantCulture);
																dataRow3["CHARACTER_MAXIMUM_LENGTH"] = dataRow[global::System.Data.Common.SchemaTableColumn.ColumnSize];
																dataRow3["TABLE_SCHEMA"] = dataRow[global::System.Data.Common.SchemaTableColumn.BaseSchemaName];
																dataRow3["PRIMARY_KEY"] = dataRow[global::System.Data.Common.SchemaTableColumn.IsKey];
																dataRow3["AUTOINCREMENT"] = dataRow[global::System.Data.Common.SchemaTableOptionalColumn.IsAutoIncrement];
																dataRow3["COLLATION_NAME"] = dataRow["CollationType"];
																dataRow3["UNIQUE"] = dataRow[global::System.Data.Common.SchemaTableColumn.IsUnique];
																dataTable.Rows.Add(dataRow3);
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			dataTable.EndLoadData();
			dataTable.AcceptChanges();
			return dataTable;
		}

		// Token: 0x06000206 RID: 518 RVA: 0x000187B0 File Offset: 0x00017BB0
		private global::System.Data.DataTable Schema_ForeignKeys(string strCatalog, string strTable, string strKeyName)
		{
			global::System.Data.DataTable dataTable = new global::System.Data.DataTable("ForeignKeys");
			dataTable.Locale = global::System.Globalization.CultureInfo.InvariantCulture;
			dataTable.Columns.Add("CONSTRAINT_CATALOG", typeof(string));
			dataTable.Columns.Add("CONSTRAINT_SCHEMA", typeof(string));
			dataTable.Columns.Add("CONSTRAINT_NAME", typeof(string));
			dataTable.Columns.Add("TABLE_CATALOG", typeof(string));
			dataTable.Columns.Add("TABLE_SCHEMA", typeof(string));
			dataTable.Columns.Add("TABLE_NAME", typeof(string));
			dataTable.Columns.Add("CONSTRAINT_TYPE", typeof(string));
			dataTable.Columns.Add("IS_DEFERRABLE", typeof(bool));
			dataTable.Columns.Add("INITIALLY_DEFERRED", typeof(bool));
			dataTable.Columns.Add("FKEY_ID", typeof(int));
			dataTable.Columns.Add("FKEY_FROM_COLUMN", typeof(string));
			dataTable.Columns.Add("FKEY_FROM_ORDINAL_POSITION", typeof(int));
			dataTable.Columns.Add("FKEY_TO_CATALOG", typeof(string));
			dataTable.Columns.Add("FKEY_TO_SCHEMA", typeof(string));
			dataTable.Columns.Add("FKEY_TO_TABLE", typeof(string));
			dataTable.Columns.Add("FKEY_TO_COLUMN", typeof(string));
			dataTable.Columns.Add("FKEY_ON_UPDATE", typeof(string));
			dataTable.Columns.Add("FKEY_ON_DELETE", typeof(string));
			dataTable.Columns.Add("FKEY_MATCH", typeof(string));
			if (string.IsNullOrEmpty(strCatalog))
			{
				strCatalog = "main";
			}
			string text = (string.Compare(strCatalog, "temp", global::System.StringComparison.OrdinalIgnoreCase) == 0) ? "sqlite_temp_master" : "sqlite_master";
			dataTable.BeginLoadData();
			using (global::System.Data.SQLite.SQLiteCommand sqliteCommand = new global::System.Data.SQLite.SQLiteCommand(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "SELECT * FROM [{0}].[{1}] WHERE [type] LIKE 'table'", new object[]
			{
				strCatalog,
				text
			}), this))
			{
				using (global::System.Data.SQLite.SQLiteDataReader sqliteDataReader = sqliteCommand.ExecuteReader())
				{
					while (sqliteDataReader.Read())
					{
						if (string.IsNullOrEmpty(strTable) || string.Compare(strTable, sqliteDataReader.GetString(2), global::System.StringComparison.OrdinalIgnoreCase) == 0)
						{
							try
							{
								using (global::System.Data.SQLite.SQLiteCommandBuilder sqliteCommandBuilder = new global::System.Data.SQLite.SQLiteCommandBuilder())
								{
									using (global::System.Data.SQLite.SQLiteCommand sqliteCommand2 = new global::System.Data.SQLite.SQLiteCommand(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "PRAGMA [{0}].foreign_key_list([{1}])", new object[]
									{
										strCatalog,
										sqliteDataReader.GetString(2)
									}), this))
									{
										using (global::System.Data.SQLite.SQLiteDataReader sqliteDataReader2 = sqliteCommand2.ExecuteReader())
										{
											while (sqliteDataReader2.Read())
											{
												global::System.Data.DataRow dataRow = dataTable.NewRow();
												dataRow["CONSTRAINT_CATALOG"] = strCatalog;
												dataRow["CONSTRAINT_NAME"] = string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "FK_{0}_{1}_{2}", new object[]
												{
													sqliteDataReader[2],
													sqliteDataReader2.GetInt32(0),
													sqliteDataReader2.GetInt32(1)
												});
												dataRow["TABLE_CATALOG"] = strCatalog;
												dataRow["TABLE_NAME"] = sqliteCommandBuilder.UnquoteIdentifier(sqliteDataReader.GetString(2));
												dataRow["CONSTRAINT_TYPE"] = "FOREIGN KEY";
												dataRow["IS_DEFERRABLE"] = false;
												dataRow["INITIALLY_DEFERRED"] = false;
												dataRow["FKEY_ID"] = sqliteDataReader2[0];
												dataRow["FKEY_FROM_COLUMN"] = sqliteCommandBuilder.UnquoteIdentifier(sqliteDataReader2[3].ToString());
												dataRow["FKEY_TO_CATALOG"] = strCatalog;
												dataRow["FKEY_TO_TABLE"] = sqliteCommandBuilder.UnquoteIdentifier(sqliteDataReader2[2].ToString());
												dataRow["FKEY_TO_COLUMN"] = sqliteCommandBuilder.UnquoteIdentifier(sqliteDataReader2[4].ToString());
												dataRow["FKEY_FROM_ORDINAL_POSITION"] = sqliteDataReader2[1];
												dataRow["FKEY_ON_UPDATE"] = ((sqliteDataReader2.FieldCount > 5) ? sqliteDataReader2[5] : string.Empty);
												dataRow["FKEY_ON_DELETE"] = ((sqliteDataReader2.FieldCount > 6) ? sqliteDataReader2[6] : string.Empty);
												dataRow["FKEY_MATCH"] = ((sqliteDataReader2.FieldCount > 7) ? sqliteDataReader2[7] : string.Empty);
												if (string.IsNullOrEmpty(strKeyName) || string.Compare(strKeyName, dataRow["CONSTRAINT_NAME"].ToString(), global::System.StringComparison.OrdinalIgnoreCase) == 0)
												{
													dataTable.Rows.Add(dataRow);
												}
											}
										}
									}
								}
							}
							catch (global::System.Data.SQLite.SQLiteException)
							{
							}
						}
					}
				}
			}
			dataTable.EndLoadData();
			dataTable.AcceptChanges();
			return dataTable;
		}

		// Token: 0x14000009 RID: 9
		// (add) Token: 0x06000207 RID: 519 RVA: 0x00018D74 File Offset: 0x00018174
		// (remove) Token: 0x06000208 RID: 520 RVA: 0x00018DC4 File Offset: 0x000181C4
		public event global::System.Data.SQLite.SQLiteAuthorizerEventHandler Authorize
		{
			add
			{
				this.CheckDisposed();
				if (this._authorizerHandler == null)
				{
					this._authorizerCallback = new global::System.Data.SQLite.SQLiteAuthorizerCallback(this.AuthorizerCallback);
					if (this._sql != null)
					{
						this._sql.SetAuthorizerHook(this._authorizerCallback);
					}
				}
				this._authorizerHandler += value;
			}
			remove
			{
				this.CheckDisposed();
				this._authorizerHandler -= value;
				if (this._authorizerHandler == null)
				{
					if (this._sql != null)
					{
						this._sql.SetAuthorizerHook(null);
					}
					this._authorizerCallback = null;
				}
			}
		}

		// Token: 0x1400000A RID: 10
		// (add) Token: 0x06000209 RID: 521 RVA: 0x00018E04 File Offset: 0x00018204
		// (remove) Token: 0x0600020A RID: 522 RVA: 0x00018E54 File Offset: 0x00018254
		public event global::System.Data.SQLite.SQLiteUpdateEventHandler Update
		{
			add
			{
				this.CheckDisposed();
				if (this._updateHandler == null)
				{
					this._updateCallback = new global::System.Data.SQLite.SQLiteUpdateCallback(this.UpdateCallback);
					if (this._sql != null)
					{
						this._sql.SetUpdateHook(this._updateCallback);
					}
				}
				this._updateHandler += value;
			}
			remove
			{
				this.CheckDisposed();
				this._updateHandler -= value;
				if (this._updateHandler == null)
				{
					if (this._sql != null)
					{
						this._sql.SetUpdateHook(null);
					}
					this._updateCallback = null;
				}
			}
		}

		// Token: 0x0600020B RID: 523 RVA: 0x00018E94 File Offset: 0x00018294
		private global::System.Data.SQLite.SQLiteAuthorizerReturnCode AuthorizerCallback(global::System.IntPtr pUserData, global::System.Data.SQLite.SQLiteAuthorizerActionCode actionCode, global::System.IntPtr pArgument1, global::System.IntPtr pArgument2, global::System.IntPtr pDatabase, global::System.IntPtr pAuthContext)
		{
			global::System.Data.SQLite.AuthorizerEventArgs authorizerEventArgs = new global::System.Data.SQLite.AuthorizerEventArgs(pUserData, actionCode, global::System.Data.SQLite.SQLiteConvert.UTF8ToString(pArgument1, -1), global::System.Data.SQLite.SQLiteConvert.UTF8ToString(pArgument2, -1), global::System.Data.SQLite.SQLiteConvert.UTF8ToString(pDatabase, -1), global::System.Data.SQLite.SQLiteConvert.UTF8ToString(pAuthContext, -1), global::System.Data.SQLite.SQLiteAuthorizerReturnCode.Ok);
			if (this._authorizerHandler != null)
			{
				this._authorizerHandler(this, authorizerEventArgs);
			}
			return authorizerEventArgs.ReturnCode;
		}

		// Token: 0x0600020C RID: 524 RVA: 0x00018EE4 File Offset: 0x000182E4
		private void UpdateCallback(global::System.IntPtr puser, int type, global::System.IntPtr database, global::System.IntPtr table, long rowid)
		{
			this._updateHandler(this, new global::System.Data.SQLite.UpdateEventArgs(global::System.Data.SQLite.SQLiteConvert.UTF8ToString(database, -1), global::System.Data.SQLite.SQLiteConvert.UTF8ToString(table, -1), (global::System.Data.SQLite.UpdateEventType)type, rowid));
		}

		// Token: 0x1400000B RID: 11
		// (add) Token: 0x0600020D RID: 525 RVA: 0x00018F14 File Offset: 0x00018314
		// (remove) Token: 0x0600020E RID: 526 RVA: 0x00018F64 File Offset: 0x00018364
		public event global::System.Data.SQLite.SQLiteCommitHandler Commit
		{
			add
			{
				this.CheckDisposed();
				if (this._commitHandler == null)
				{
					this._commitCallback = new global::System.Data.SQLite.SQLiteCommitCallback(this.CommitCallback);
					if (this._sql != null)
					{
						this._sql.SetCommitHook(this._commitCallback);
					}
				}
				this._commitHandler += value;
			}
			remove
			{
				this.CheckDisposed();
				this._commitHandler -= value;
				if (this._commitHandler == null)
				{
					if (this._sql != null)
					{
						this._sql.SetCommitHook(null);
					}
					this._commitCallback = null;
				}
			}
		}

		// Token: 0x1400000C RID: 12
		// (add) Token: 0x0600020F RID: 527 RVA: 0x00018FA4 File Offset: 0x000183A4
		// (remove) Token: 0x06000210 RID: 528 RVA: 0x00018FF4 File Offset: 0x000183F4
		public event global::System.Data.SQLite.SQLiteTraceEventHandler Trace
		{
			add
			{
				this.CheckDisposed();
				if (this._traceHandler == null)
				{
					this._traceCallback = new global::System.Data.SQLite.SQLiteTraceCallback(this.TraceCallback);
					if (this._sql != null)
					{
						this._sql.SetTraceCallback(this._traceCallback);
					}
				}
				this._traceHandler += value;
			}
			remove
			{
				this.CheckDisposed();
				this._traceHandler -= value;
				if (this._traceHandler == null)
				{
					if (this._sql != null)
					{
						this._sql.SetTraceCallback(null);
					}
					this._traceCallback = null;
				}
			}
		}

		// Token: 0x06000211 RID: 529 RVA: 0x00019034 File Offset: 0x00018434
		private void TraceCallback(global::System.IntPtr puser, global::System.IntPtr statement)
		{
			this._traceHandler(this, new global::System.Data.SQLite.TraceEventArgs(global::System.Data.SQLite.SQLiteConvert.UTF8ToString(statement, -1)));
		}

		// Token: 0x1400000D RID: 13
		// (add) Token: 0x06000212 RID: 530 RVA: 0x0001905C File Offset: 0x0001845C
		// (remove) Token: 0x06000213 RID: 531 RVA: 0x000190AC File Offset: 0x000184AC
		public event global::System.EventHandler RollBack
		{
			add
			{
				this.CheckDisposed();
				if (this._rollbackHandler == null)
				{
					this._rollbackCallback = new global::System.Data.SQLite.SQLiteRollbackCallback(this.RollbackCallback);
					if (this._sql != null)
					{
						this._sql.SetRollbackHook(this._rollbackCallback);
					}
				}
				this._rollbackHandler += value;
			}
			remove
			{
				this.CheckDisposed();
				this._rollbackHandler -= value;
				if (this._rollbackHandler == null)
				{
					if (this._sql != null)
					{
						this._sql.SetRollbackHook(null);
					}
					this._rollbackCallback = null;
				}
			}
		}

		// Token: 0x06000214 RID: 532 RVA: 0x000190EC File Offset: 0x000184EC
		private int CommitCallback(global::System.IntPtr parg)
		{
			global::System.Data.SQLite.CommitEventArgs commitEventArgs = new global::System.Data.SQLite.CommitEventArgs();
			this._commitHandler(this, commitEventArgs);
			if (!commitEventArgs.AbortTransaction)
			{
				return 0;
			}
			return 1;
		}

		// Token: 0x06000215 RID: 533 RVA: 0x00019118 File Offset: 0x00018518
		private void RollbackCallback(global::System.IntPtr parg)
		{
			this._rollbackHandler(this, global::System.EventArgs.Empty);
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000216 RID: 534 RVA: 0x00019138 File Offset: 0x00018538
		protected override global::System.Data.Common.DbProviderFactory DbProviderFactory
		{
			get
			{
				return global::System.Data.SQLite.SQLiteFactory.Instance;
			}
		}

		// Token: 0x04000070 RID: 112
		internal const string DefaultBaseSchemaName = "sqlite_default_schema";

		// Token: 0x04000071 RID: 113
		private const string MemoryFileName = ":memory:";

		// Token: 0x04000072 RID: 114
		private const global::System.Data.SQLite.SQLiteConnectionFlags DefaultFlags = global::System.Data.SQLite.SQLiteConnectionFlags.Default;

		// Token: 0x04000073 RID: 115
		private const global::System.Data.SQLite.SQLiteSynchronousEnum DefaultSynchronous = global::System.Data.SQLite.SQLiteSynchronousEnum.Default;

		// Token: 0x04000074 RID: 116
		private const global::System.Data.SQLite.SQLiteJournalModeEnum DefaultJournalMode = global::System.Data.SQLite.SQLiteJournalModeEnum.Default;

		// Token: 0x04000075 RID: 117
		private const global::System.Data.IsolationLevel DefaultIsolationLevel = global::System.Data.IsolationLevel.Serializable;

		// Token: 0x04000076 RID: 118
		private const global::System.Data.SQLite.SQLiteDateFormats DefaultDateTimeFormat = global::System.Data.SQLite.SQLiteDateFormats.ISO8601;

		// Token: 0x04000077 RID: 119
		private const global::System.DateTimeKind DefaultDateTimeKind = global::System.DateTimeKind.Unspecified;

		// Token: 0x04000078 RID: 120
		private const string DefaultDateTimeFormatString = null;

		// Token: 0x04000079 RID: 121
		private const string DefaultDataSource = null;

		// Token: 0x0400007A RID: 122
		private const string DefaultUri = null;

		// Token: 0x0400007B RID: 123
		private const string DefaultFullUri = null;

		// Token: 0x0400007C RID: 124
		private const string DefaultHexPassword = null;

		// Token: 0x0400007D RID: 125
		private const string DefaultPassword = null;

		// Token: 0x0400007E RID: 126
		private const int DefaultVersion = 3;

		// Token: 0x0400007F RID: 127
		private const int DefaultPageSize = 1024;

		// Token: 0x04000080 RID: 128
		private const int DefaultMaxPageCount = 0;

		// Token: 0x04000081 RID: 129
		private const int DefaultCacheSize = 2000;

		// Token: 0x04000082 RID: 130
		private const int DefaultMaxPoolSize = 100;

		// Token: 0x04000083 RID: 131
		private const int DefaultConnectionTimeout = 30;

		// Token: 0x04000084 RID: 132
		private const bool DefaultFailIfMissing = false;

		// Token: 0x04000085 RID: 133
		private const bool DefaultReadOnly = false;

		// Token: 0x04000086 RID: 134
		private const bool DefaultBinaryGUID = true;

		// Token: 0x04000087 RID: 135
		private const bool DefaultUseUTF16Encoding = false;

		// Token: 0x04000088 RID: 136
		private const bool DefaultToFullPath = true;

		// Token: 0x04000089 RID: 137
		private const bool DefaultPooling = false;

		// Token: 0x0400008A RID: 138
		private const bool DefaultLegacyFormat = false;

		// Token: 0x0400008B RID: 139
		private const bool DefaultForeignKeys = false;

		// Token: 0x0400008C RID: 140
		private const bool DefaultEnlist = true;

		// Token: 0x0400008D RID: 141
		private const bool DefaultSetDefaults = true;

		// Token: 0x0400008E RID: 142
		private const int SQLITE_FCNTL_WIN32_AV_RETRY = 9;

		// Token: 0x0400008F RID: 143
		private const string _dataDirectory = "|DataDirectory|";

		// Token: 0x04000090 RID: 144
		private const string _masterdb = "sqlite_master";

		// Token: 0x04000091 RID: 145
		private const string _tempmasterdb = "sqlite_temp_master";

		// Token: 0x04000092 RID: 146
		private static readonly global::System.Reflection.Assembly _assembly = typeof(global::System.Data.SQLite.SQLiteConnection).Assembly;

		// Token: 0x04000093 RID: 147
		private static readonly object _syncRoot = new object();

		// Token: 0x04000095 RID: 149
		private global::System.Data.ConnectionState _connectionState;

		// Token: 0x04000096 RID: 150
		private string _connectionString;

		// Token: 0x04000097 RID: 151
		internal int _transactionLevel;

		// Token: 0x04000098 RID: 152
		private bool _disposing;

		// Token: 0x04000099 RID: 153
		private global::System.Data.IsolationLevel _defaultIsolation;

		// Token: 0x0400009A RID: 154
		internal global::System.Data.SQLite.SQLiteEnlistment _enlistment;

		// Token: 0x0400009B RID: 155
		internal global::System.Data.SQLite.SQLiteBase _sql;

		// Token: 0x0400009C RID: 156
		private string _dataSource;

		// Token: 0x0400009D RID: 157
		private byte[] _password;

		// Token: 0x0400009E RID: 158
		internal string _baseSchemaName;

		// Token: 0x0400009F RID: 159
		private global::System.Data.SQLite.SQLiteConnectionFlags _flags;

		// Token: 0x040000A0 RID: 160
		private int _defaultTimeout = 30;

		// Token: 0x040000A1 RID: 161
		private bool _parseViaFramework;

		// Token: 0x040000A2 RID: 162
		internal bool _binaryGuid;

		// Token: 0x040000A3 RID: 163
		internal long _version;

		// Token: 0x040000A9 RID: 169
		private global::System.Data.SQLite.SQLiteAuthorizerCallback _authorizerCallback;

		// Token: 0x040000AA RID: 170
		private global::System.Data.SQLite.SQLiteUpdateCallback _updateCallback;

		// Token: 0x040000AB RID: 171
		private global::System.Data.SQLite.SQLiteCommitCallback _commitCallback;

		// Token: 0x040000AC RID: 172
		private global::System.Data.SQLite.SQLiteTraceCallback _traceCallback;

		// Token: 0x040000AD RID: 173
		private global::System.Data.SQLite.SQLiteRollbackCallback _rollbackCallback;

		// Token: 0x040000AF RID: 175
		private bool disposed;
	}
}
