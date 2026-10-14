using System;
using System.Transactions;

namespace System.Data.SQLite
{
	// Token: 0x02000073 RID: 115
	internal sealed class SQLiteEnlistment : global::System.Transactions.IEnlistmentNotification, global::System.IDisposable
	{
		// Token: 0x060004C7 RID: 1223 RVA: 0x000210E0 File Offset: 0x000204E0
		internal SQLiteEnlistment(global::System.Data.SQLite.SQLiteConnection cnn, global::System.Transactions.Transaction scope)
		{
			this._transaction = cnn.BeginTransaction();
			this._scope = scope;
			this._scope.EnlistVolatile(this, global::System.Transactions.EnlistmentOptions.None);
		}

		// Token: 0x060004C8 RID: 1224 RVA: 0x00021114 File Offset: 0x00020514
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x060004C9 RID: 1225 RVA: 0x00021130 File Offset: 0x00020530
		private void CheckDisposed()
		{
			if (this.disposed)
			{
				throw new global::System.ObjectDisposedException(typeof(global::System.Data.SQLite.SQLiteEnlistment).Name);
			}
		}

		// Token: 0x060004CA RID: 1226 RVA: 0x0002115C File Offset: 0x0002055C
		private void Dispose(bool disposing)
		{
			if (!this.disposed)
			{
				if (disposing)
				{
					if (this._transaction != null)
					{
						this._transaction.Dispose();
						this._transaction = null;
					}
					if (this._scope != null)
					{
						this._scope = null;
					}
				}
				this.disposed = true;
			}
		}

		// Token: 0x060004CB RID: 1227 RVA: 0x000211AC File Offset: 0x000205AC
		~SQLiteEnlistment()
		{
			this.Dispose(false);
		}

		// Token: 0x060004CC RID: 1228 RVA: 0x000211E8 File Offset: 0x000205E8
		private void Cleanup(global::System.Data.SQLite.SQLiteConnection cnn)
		{
			if (this._disposeConnection)
			{
				cnn.Dispose();
			}
			this._transaction = null;
			this._scope = null;
		}

		// Token: 0x060004CD RID: 1229 RVA: 0x00021214 File Offset: 0x00020614
		public void Commit(global::System.Transactions.Enlistment enlistment)
		{
			this.CheckDisposed();
			global::System.Data.SQLite.SQLiteConnection connection = this._transaction.Connection;
			connection._enlistment = null;
			try
			{
				this._transaction.IsValid(true);
				this._transaction.Connection._transactionLevel = 1;
				this._transaction.Commit();
				enlistment.Done();
			}
			finally
			{
				this.Cleanup(connection);
			}
		}

		// Token: 0x060004CE RID: 1230 RVA: 0x00021290 File Offset: 0x00020690
		public void InDoubt(global::System.Transactions.Enlistment enlistment)
		{
			this.CheckDisposed();
			enlistment.Done();
		}

		// Token: 0x060004CF RID: 1231 RVA: 0x000212AC File Offset: 0x000206AC
		public void Prepare(global::System.Transactions.PreparingEnlistment preparingEnlistment)
		{
			this.CheckDisposed();
			if (!this._transaction.IsValid(false))
			{
				preparingEnlistment.ForceRollback();
				return;
			}
			preparingEnlistment.Prepared();
		}

		// Token: 0x060004D0 RID: 1232 RVA: 0x000212DC File Offset: 0x000206DC
		public void Rollback(global::System.Transactions.Enlistment enlistment)
		{
			this.CheckDisposed();
			global::System.Data.SQLite.SQLiteConnection connection = this._transaction.Connection;
			connection._enlistment = null;
			try
			{
				this._transaction.Rollback();
				enlistment.Done();
			}
			finally
			{
				this.Cleanup(connection);
			}
		}

		// Token: 0x040001F2 RID: 498
		internal global::System.Data.SQLite.SQLiteTransaction _transaction;

		// Token: 0x040001F3 RID: 499
		internal global::System.Transactions.Transaction _scope;

		// Token: 0x040001F4 RID: 500
		internal bool _disposeConnection;

		// Token: 0x040001F5 RID: 501
		private bool disposed;
	}
}
