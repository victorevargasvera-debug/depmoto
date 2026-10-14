using System;

namespace System.Data.SQLite
{
	// Token: 0x0200007F RID: 127
	public class SQLiteVirtualTableCursor : global::System.Data.SQLite.ISQLiteNativeHandle, global::System.IDisposable
	{
		// Token: 0x06000517 RID: 1303 RVA: 0x000220A4 File Offset: 0x000214A4
		public SQLiteVirtualTableCursor(global::System.Data.SQLite.SQLiteVirtualTable table) : this()
		{
			this.table = table;
		}

		// Token: 0x06000518 RID: 1304 RVA: 0x000220C0 File Offset: 0x000214C0
		private SQLiteVirtualTableCursor()
		{
			this.rowIndex = global::System.Data.SQLite.SQLiteVirtualTableCursor.InvalidRowIndex;
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x06000519 RID: 1305 RVA: 0x000220E0 File Offset: 0x000214E0
		public virtual global::System.Data.SQLite.SQLiteVirtualTable Table
		{
			get
			{
				this.CheckDisposed();
				return this.table;
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x0600051A RID: 1306 RVA: 0x000220FC File Offset: 0x000214FC
		public virtual int IndexNumber
		{
			get
			{
				this.CheckDisposed();
				return this.indexNumber;
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x0600051B RID: 1307 RVA: 0x00022118 File Offset: 0x00021518
		public virtual string IndexString
		{
			get
			{
				this.CheckDisposed();
				return this.indexString;
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x0600051C RID: 1308 RVA: 0x00022134 File Offset: 0x00021534
		public virtual global::System.Data.SQLite.SQLiteValue[] Values
		{
			get
			{
				this.CheckDisposed();
				return this.values;
			}
		}

		// Token: 0x0600051D RID: 1309 RVA: 0x00022150 File Offset: 0x00021550
		protected virtual int TryPersistValues(global::System.Data.SQLite.SQLiteValue[] values)
		{
			int num = 0;
			if (values != null)
			{
				foreach (global::System.Data.SQLite.SQLiteValue sqliteValue in values)
				{
					if (sqliteValue != null && sqliteValue.Persist())
					{
						num++;
					}
				}
			}
			return num;
		}

		// Token: 0x0600051E RID: 1310 RVA: 0x00022188 File Offset: 0x00021588
		public virtual void Filter(int indexNumber, string indexString, global::System.Data.SQLite.SQLiteValue[] values)
		{
			this.CheckDisposed();
			if (values != null && this.TryPersistValues(values) != values.Length)
			{
				throw new global::System.Data.SQLite.SQLiteException("failed to persist one or more values");
			}
			this.indexNumber = indexNumber;
			this.indexString = indexString;
			this.values = values;
		}

		// Token: 0x0600051F RID: 1311 RVA: 0x000221CC File Offset: 0x000215CC
		public virtual int GetRowIndex()
		{
			return this.rowIndex;
		}

		// Token: 0x06000520 RID: 1312 RVA: 0x000221E0 File Offset: 0x000215E0
		public virtual void NextRowIndex()
		{
			this.rowIndex++;
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x06000521 RID: 1313 RVA: 0x000221FC File Offset: 0x000215FC
		// (set) Token: 0x06000522 RID: 1314 RVA: 0x00022218 File Offset: 0x00021618
		public virtual global::System.IntPtr NativeHandle
		{
			get
			{
				this.CheckDisposed();
				return this.nativeHandle;
			}
			internal set
			{
				this.nativeHandle = value;
			}
		}

		// Token: 0x06000523 RID: 1315 RVA: 0x0002222C File Offset: 0x0002162C
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x06000524 RID: 1316 RVA: 0x00022248 File Offset: 0x00021648
		private void CheckDisposed()
		{
			if (this.disposed)
			{
				throw new global::System.ObjectDisposedException(typeof(global::System.Data.SQLite.SQLiteVirtualTableCursor).Name);
			}
		}

		// Token: 0x06000525 RID: 1317 RVA: 0x00022274 File Offset: 0x00021674
		protected virtual void Dispose(bool disposing)
		{
			if (!this.disposed)
			{
				this.disposed = true;
			}
		}

		// Token: 0x06000526 RID: 1318 RVA: 0x00022290 File Offset: 0x00021690
		~SQLiteVirtualTableCursor()
		{
			this.Dispose(false);
		}

		// Token: 0x0400021B RID: 539
		protected static readonly int InvalidRowIndex;

		// Token: 0x0400021C RID: 540
		private int rowIndex;

		// Token: 0x0400021D RID: 541
		private global::System.Data.SQLite.SQLiteVirtualTable table;

		// Token: 0x0400021E RID: 542
		private int indexNumber;

		// Token: 0x0400021F RID: 543
		private string indexString;

		// Token: 0x04000220 RID: 544
		private global::System.Data.SQLite.SQLiteValue[] values;

		// Token: 0x04000221 RID: 545
		private global::System.IntPtr nativeHandle;

		// Token: 0x04000222 RID: 546
		private bool disposed;
	}
}
