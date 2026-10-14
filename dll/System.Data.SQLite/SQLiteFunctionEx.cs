using System;

namespace System.Data.SQLite
{
	// Token: 0x0200003D RID: 61
	public class SQLiteFunctionEx : global::System.Data.SQLite.SQLiteFunction
	{
		// Token: 0x06000319 RID: 793 RVA: 0x0001D788 File Offset: 0x0001CB88
		protected global::System.Data.SQLite.CollationSequence GetCollationSequence()
		{
			return this._base.GetCollationSequence(this, this._context);
		}

		// Token: 0x0600031A RID: 794 RVA: 0x0001D7A8 File Offset: 0x0001CBA8
		private void CheckDisposed()
		{
			if (this.disposed)
			{
				throw new global::System.ObjectDisposedException(typeof(global::System.Data.SQLite.SQLiteFunctionEx).Name);
			}
		}

		// Token: 0x0600031B RID: 795 RVA: 0x0001D7D4 File Offset: 0x0001CBD4
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

		// Token: 0x04000178 RID: 376
		private bool disposed;
	}
}
