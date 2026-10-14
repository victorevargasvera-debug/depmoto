using System;
using System.Collections.Generic;

namespace System.Data.SQLite.Generic
{
	// Token: 0x0200008C RID: 140
	public class SQLiteModuleEnumerable<T> : global::System.Data.SQLite.SQLiteModuleEnumerable
	{
		// Token: 0x0600062C RID: 1580 RVA: 0x000252A4 File Offset: 0x000246A4
		public SQLiteModuleEnumerable(string name, global::System.Collections.Generic.IEnumerable<T> enumerable) : base(name, enumerable)
		{
			this.enumerable = enumerable;
		}

		// Token: 0x0600062D RID: 1581 RVA: 0x000252C0 File Offset: 0x000246C0
		public override global::System.Data.SQLite.SQLiteErrorCode Open(global::System.Data.SQLite.SQLiteVirtualTable table, ref global::System.Data.SQLite.SQLiteVirtualTableCursor cursor)
		{
			this.CheckDisposed();
			cursor = new global::System.Data.SQLite.Generic.SQLiteVirtualTableCursorEnumerator<T>(table, this.enumerable.GetEnumerator());
			return global::System.Data.SQLite.SQLiteErrorCode.Ok;
		}

		// Token: 0x0600062E RID: 1582 RVA: 0x000252E8 File Offset: 0x000246E8
		public override global::System.Data.SQLite.SQLiteErrorCode Column(global::System.Data.SQLite.SQLiteVirtualTableCursor cursor, global::System.Data.SQLite.SQLiteContext context, int index)
		{
			this.CheckDisposed();
			global::System.Data.SQLite.Generic.SQLiteVirtualTableCursorEnumerator<T> sqliteVirtualTableCursorEnumerator = cursor as global::System.Data.SQLite.Generic.SQLiteVirtualTableCursorEnumerator<T>;
			if (sqliteVirtualTableCursorEnumerator == null)
			{
				return this.CursorTypeMismatchError(cursor);
			}
			if (sqliteVirtualTableCursorEnumerator.EndOfEnumerator)
			{
				return this.CursorEndOfEnumeratorError(cursor);
			}
			T t = ((global::System.Collections.Generic.IEnumerator<!0>)sqliteVirtualTableCursorEnumerator).Current;
			if (t != null)
			{
				context.SetString(this.GetStringFromObject(cursor, t));
			}
			else
			{
				context.SetNull();
			}
			return global::System.Data.SQLite.SQLiteErrorCode.Ok;
		}

		// Token: 0x0600062F RID: 1583 RVA: 0x00025348 File Offset: 0x00024748
		private void CheckDisposed()
		{
			if (this.disposed)
			{
				throw new global::System.ObjectDisposedException(typeof(global::System.Data.SQLite.Generic.SQLiteModuleEnumerable<T>).Name);
			}
		}

		// Token: 0x06000630 RID: 1584 RVA: 0x00025374 File Offset: 0x00024774
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

		// Token: 0x0400023F RID: 575
		private global::System.Collections.Generic.IEnumerable<T> enumerable;

		// Token: 0x04000240 RID: 576
		private bool disposed;
	}
}
