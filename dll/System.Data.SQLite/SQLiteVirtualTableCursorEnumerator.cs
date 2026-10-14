using System;
using System.Collections;

namespace System.Data.SQLite
{
	// Token: 0x02000088 RID: 136
	public class SQLiteVirtualTableCursorEnumerator : global::System.Data.SQLite.SQLiteVirtualTableCursor, global::System.Collections.IEnumerator
	{
		// Token: 0x060005E7 RID: 1511 RVA: 0x0002473C File Offset: 0x00023B3C
		public SQLiteVirtualTableCursorEnumerator(global::System.Data.SQLite.SQLiteVirtualTable table, global::System.Collections.IEnumerator enumerator) : base(table)
		{
			this.enumerator = enumerator;
			this.endOfEnumerator = true;
		}

		// Token: 0x060005E8 RID: 1512 RVA: 0x00024760 File Offset: 0x00023B60
		public virtual bool MoveNext()
		{
			this.CheckDisposed();
			this.CheckClosed();
			if (this.enumerator == null)
			{
				return false;
			}
			this.endOfEnumerator = !this.enumerator.MoveNext();
			if (!this.endOfEnumerator)
			{
				this.NextRowIndex();
			}
			return !this.endOfEnumerator;
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x060005E9 RID: 1513 RVA: 0x000247B0 File Offset: 0x00023BB0
		public virtual object Current
		{
			get
			{
				this.CheckDisposed();
				this.CheckClosed();
				if (this.enumerator == null)
				{
					return null;
				}
				return this.enumerator.Current;
			}
		}

		// Token: 0x060005EA RID: 1514 RVA: 0x000247E0 File Offset: 0x00023BE0
		public virtual void Reset()
		{
			this.CheckDisposed();
			this.CheckClosed();
			if (this.enumerator == null)
			{
				return;
			}
			this.enumerator.Reset();
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x060005EB RID: 1515 RVA: 0x00024810 File Offset: 0x00023C10
		public virtual bool EndOfEnumerator
		{
			get
			{
				this.CheckDisposed();
				this.CheckClosed();
				return this.endOfEnumerator;
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x060005EC RID: 1516 RVA: 0x00024830 File Offset: 0x00023C30
		public virtual bool IsOpen
		{
			get
			{
				this.CheckDisposed();
				return this.enumerator != null;
			}
		}

		// Token: 0x060005ED RID: 1517 RVA: 0x00024850 File Offset: 0x00023C50
		public virtual void Close()
		{
			if (this.enumerator != null)
			{
				this.enumerator = null;
			}
		}

		// Token: 0x060005EE RID: 1518 RVA: 0x0002486C File Offset: 0x00023C6C
		public virtual void CheckClosed()
		{
			this.CheckDisposed();
			if (!this.IsOpen)
			{
				throw new global::System.InvalidOperationException("virtual table cursor is closed");
			}
		}

		// Token: 0x060005EF RID: 1519 RVA: 0x00024894 File Offset: 0x00023C94
		private void CheckDisposed()
		{
			if (this.disposed)
			{
				throw new global::System.ObjectDisposedException(typeof(global::System.Data.SQLite.SQLiteVirtualTableCursorEnumerator).Name);
			}
		}

		// Token: 0x060005F0 RID: 1520 RVA: 0x000248C0 File Offset: 0x00023CC0
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

		// Token: 0x04000235 RID: 565
		private global::System.Collections.IEnumerator enumerator;

		// Token: 0x04000236 RID: 566
		private bool endOfEnumerator;

		// Token: 0x04000237 RID: 567
		private bool disposed;
	}
}
