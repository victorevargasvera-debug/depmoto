using System;
using System.Collections;
using System.Collections.Generic;

namespace System.Data.SQLite.Generic
{
	// Token: 0x0200008B RID: 139
	public class SQLiteVirtualTableCursorEnumerator<T> : global::System.Data.SQLite.SQLiteVirtualTableCursorEnumerator, global::System.Collections.Generic.IEnumerator<T>, global::System.IDisposable, global::System.Collections.IEnumerator
	{
		// Token: 0x06000627 RID: 1575 RVA: 0x000251B8 File Offset: 0x000245B8
		public SQLiteVirtualTableCursorEnumerator(global::System.Data.SQLite.SQLiteVirtualTable table, global::System.Collections.Generic.IEnumerator<T> enumerator) : base(table, enumerator)
		{
			this.enumerator = enumerator;
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x06000628 RID: 1576 RVA: 0x000251D4 File Offset: 0x000245D4
		T global::System.Collections.Generic.IEnumerator<!0>.Current
		{
			get
			{
				this.CheckDisposed();
				this.CheckClosed();
				if (this.enumerator == null)
				{
					return default(T);
				}
				return this.enumerator.Current;
			}
		}

		// Token: 0x06000629 RID: 1577 RVA: 0x0002520C File Offset: 0x0002460C
		public override void Close()
		{
			if (this.enumerator != null)
			{
				this.enumerator = null;
			}
			base.Close();
		}

		// Token: 0x0600062A RID: 1578 RVA: 0x00025230 File Offset: 0x00024630
		private void CheckDisposed()
		{
			if (this.disposed)
			{
				throw new global::System.ObjectDisposedException(typeof(global::System.Data.SQLite.Generic.SQLiteVirtualTableCursorEnumerator<T>).Name);
			}
		}

		// Token: 0x0600062B RID: 1579 RVA: 0x0002525C File Offset: 0x0002465C
		protected override void Dispose(bool disposing)
		{
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

		// Token: 0x0400023D RID: 573
		private global::System.Collections.Generic.IEnumerator<T> enumerator;

		// Token: 0x0400023E RID: 574
		private bool disposed;
	}
}
