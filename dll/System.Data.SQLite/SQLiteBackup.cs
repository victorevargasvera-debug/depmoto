using System;

namespace System.Data.SQLite
{
	// Token: 0x02000009 RID: 9
	internal sealed class SQLiteBackup : global::System.IDisposable
	{
		// Token: 0x06000131 RID: 305 RVA: 0x0001209C File Offset: 0x0001149C
		internal SQLiteBackup(global::System.Data.SQLite.SQLiteBase sqlbase, global::System.Data.SQLite.SQLiteBackupHandle backup, global::System.IntPtr destDb, byte[] zDestName, global::System.IntPtr sourceDb, byte[] zSourceName)
		{
			this._sql = sqlbase;
			this._sqlite_backup = backup;
			this._destDb = destDb;
			this._zDestName = zDestName;
			this._sourceDb = sourceDb;
			this._zSourceName = zSourceName;
		}

		// Token: 0x06000132 RID: 306 RVA: 0x000120DC File Offset: 0x000114DC
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x06000133 RID: 307 RVA: 0x000120F8 File Offset: 0x000114F8
		private void CheckDisposed()
		{
			if (this.disposed)
			{
				throw new global::System.ObjectDisposedException(typeof(global::System.Data.SQLite.SQLiteBackup).Name);
			}
		}

		// Token: 0x06000134 RID: 308 RVA: 0x00012124 File Offset: 0x00011524
		private void Dispose(bool disposing)
		{
			if (!this.disposed)
			{
				if (disposing)
				{
					if (this._sqlite_backup != null)
					{
						this._sqlite_backup.Dispose();
						this._sqlite_backup = null;
					}
					this._zSourceName = null;
					this._sourceDb = global::System.IntPtr.Zero;
					this._zDestName = null;
					this._destDb = global::System.IntPtr.Zero;
					this._sql = null;
				}
				this.disposed = true;
			}
		}

		// Token: 0x06000135 RID: 309 RVA: 0x00012188 File Offset: 0x00011588
		~SQLiteBackup()
		{
			this.Dispose(false);
		}

		// Token: 0x04000025 RID: 37
		internal global::System.Data.SQLite.SQLiteBase _sql;

		// Token: 0x04000026 RID: 38
		internal global::System.Data.SQLite.SQLiteBackupHandle _sqlite_backup;

		// Token: 0x04000027 RID: 39
		internal global::System.IntPtr _destDb;

		// Token: 0x04000028 RID: 40
		internal byte[] _zDestName;

		// Token: 0x04000029 RID: 41
		internal global::System.IntPtr _sourceDb;

		// Token: 0x0400002A RID: 42
		internal byte[] _zSourceName;

		// Token: 0x0400002B RID: 43
		internal global::System.Data.SQLite.SQLiteErrorCode _stepResult;

		// Token: 0x0400002C RID: 44
		private bool disposed;
	}
}
