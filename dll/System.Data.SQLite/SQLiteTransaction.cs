using System;
using System.Data.Common;
using System.Threading;

namespace System.Data.SQLite
{
	// Token: 0x02000050 RID: 80
	public sealed class SQLiteTransaction : global::System.Data.Common.DbTransaction
	{
		// Token: 0x060003C8 RID: 968 RVA: 0x000208C8 File Offset: 0x0001FCC8
		internal SQLiteTransaction(global::System.Data.SQLite.SQLiteConnection connection, bool deferredLock)
		{
			this._cnn = connection;
			this._version = this._cnn._version;
			this._level = (deferredLock ? global::System.Data.IsolationLevel.ReadCommitted : global::System.Data.IsolationLevel.Serializable);
			if (this._cnn._transactionLevel++ == 0)
			{
				try
				{
					using (global::System.Data.SQLite.SQLiteCommand sqliteCommand = this._cnn.CreateCommand())
					{
						if (!deferredLock)
						{
							sqliteCommand.CommandText = "BEGIN IMMEDIATE";
						}
						else
						{
							sqliteCommand.CommandText = "BEGIN";
						}
						sqliteCommand.ExecuteNonQuery();
					}
				}
				catch (global::System.Data.SQLite.SQLiteException)
				{
					this._cnn._transactionLevel--;
					this._cnn = null;
					throw;
				}
			}
		}

		// Token: 0x060003C9 RID: 969 RVA: 0x000209B0 File Offset: 0x0001FDB0
		private void CheckDisposed()
		{
			if (this.disposed)
			{
				throw new global::System.ObjectDisposedException(typeof(global::System.Data.SQLite.SQLiteTransaction).Name);
			}
		}

		// Token: 0x060003CA RID: 970 RVA: 0x000209DC File Offset: 0x0001FDDC
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (!this.disposed && disposing && this.IsValid(false))
				{
					this.IssueRollback(false);
				}
			}
			finally
			{
				base.Dispose(disposing);
				this.disposed = true;
			}
		}

		// Token: 0x060003CB RID: 971 RVA: 0x00020A34 File Offset: 0x0001FE34
		public override void Commit()
		{
			this.CheckDisposed();
			this.IsValid(true);
			if (this._cnn._transactionLevel - 1 == 0)
			{
				using (global::System.Data.SQLite.SQLiteCommand sqliteCommand = this._cnn.CreateCommand())
				{
					sqliteCommand.CommandText = "COMMIT";
					sqliteCommand.ExecuteNonQuery();
				}
			}
			this._cnn._transactionLevel--;
			this._cnn = null;
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x060003CC RID: 972 RVA: 0x00020AC0 File Offset: 0x0001FEC0
		public new global::System.Data.SQLite.SQLiteConnection Connection
		{
			get
			{
				this.CheckDisposed();
				return this._cnn;
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x060003CD RID: 973 RVA: 0x00020ADC File Offset: 0x0001FEDC
		protected override global::System.Data.Common.DbConnection DbConnection
		{
			get
			{
				return this.Connection;
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x060003CE RID: 974 RVA: 0x00020AF0 File Offset: 0x0001FEF0
		public override global::System.Data.IsolationLevel IsolationLevel
		{
			get
			{
				this.CheckDisposed();
				return this._level;
			}
		}

		// Token: 0x060003CF RID: 975 RVA: 0x00020B0C File Offset: 0x0001FF0C
		public override void Rollback()
		{
			this.CheckDisposed();
			this.IsValid(true);
			this.IssueRollback(true);
		}

		// Token: 0x060003D0 RID: 976 RVA: 0x00020B30 File Offset: 0x0001FF30
		internal void IssueRollback(bool throwError)
		{
			global::System.Data.SQLite.SQLiteConnection sqliteConnection = global::System.Threading.Interlocked.Exchange<global::System.Data.SQLite.SQLiteConnection>(ref this._cnn, null);
			if (sqliteConnection != null)
			{
				try
				{
					using (global::System.Data.SQLite.SQLiteCommand sqliteCommand = sqliteConnection.CreateCommand())
					{
						sqliteCommand.CommandText = "ROLLBACK";
						sqliteCommand.ExecuteNonQuery();
					}
				}
				catch
				{
					if (throwError)
					{
						throw;
					}
				}
				sqliteConnection._transactionLevel = 0;
			}
		}

		// Token: 0x060003D1 RID: 977 RVA: 0x00020BB8 File Offset: 0x0001FFB8
		internal bool IsValid(bool throwError)
		{
			if (this._cnn == null)
			{
				if (throwError)
				{
					throw new global::System.ArgumentNullException("No connection associated with this transaction");
				}
				return false;
			}
			else if (this._cnn._version != this._version)
			{
				if (throwError)
				{
					throw new global::System.Data.SQLite.SQLiteException("The connection was closed and re-opened, changes were already rolled back");
				}
				return false;
			}
			else if (this._cnn.State != global::System.Data.ConnectionState.Open)
			{
				if (throwError)
				{
					throw new global::System.Data.SQLite.SQLiteException("Connection was closed");
				}
				return false;
			}
			else
			{
				if (this._cnn._transactionLevel != 0 && !this._cnn._sql.AutoCommit)
				{
					return true;
				}
				this._cnn._transactionLevel = 0;
				if (throwError)
				{
					throw new global::System.Data.SQLite.SQLiteException("No transaction is active on this connection");
				}
				return false;
			}
		}

		// Token: 0x040001C5 RID: 453
		internal global::System.Data.SQLite.SQLiteConnection _cnn;

		// Token: 0x040001C6 RID: 454
		internal long _version;

		// Token: 0x040001C7 RID: 455
		private global::System.Data.IsolationLevel _level;

		// Token: 0x040001C8 RID: 456
		private bool disposed;
	}
}
