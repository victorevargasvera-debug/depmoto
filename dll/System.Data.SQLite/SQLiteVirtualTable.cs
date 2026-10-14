using System;

namespace System.Data.SQLite
{
	// Token: 0x0200007E RID: 126
	public class SQLiteVirtualTable : global::System.Data.SQLite.ISQLiteNativeHandle, global::System.IDisposable
	{
		// Token: 0x06000509 RID: 1289 RVA: 0x00021EB8 File Offset: 0x000212B8
		public SQLiteVirtualTable(string[] arguments)
		{
			this.arguments = arguments;
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x0600050A RID: 1290 RVA: 0x00021ED4 File Offset: 0x000212D4
		public virtual string[] Arguments
		{
			get
			{
				this.CheckDisposed();
				return this.arguments;
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x0600050B RID: 1291 RVA: 0x00021EF0 File Offset: 0x000212F0
		public virtual string ModuleName
		{
			get
			{
				this.CheckDisposed();
				string[] array = this.Arguments;
				if (array != null && array.Length > 0)
				{
					return array[0];
				}
				return null;
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x0600050C RID: 1292 RVA: 0x00021F18 File Offset: 0x00021318
		public virtual string DatabaseName
		{
			get
			{
				this.CheckDisposed();
				string[] array = this.Arguments;
				if (array != null && array.Length > 1)
				{
					return array[1];
				}
				return null;
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x0600050D RID: 1293 RVA: 0x00021F40 File Offset: 0x00021340
		public virtual string TableName
		{
			get
			{
				this.CheckDisposed();
				string[] array = this.Arguments;
				if (array != null && array.Length > 2)
				{
					return array[2];
				}
				return null;
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x0600050E RID: 1294 RVA: 0x00021F68 File Offset: 0x00021368
		public virtual global::System.Data.SQLite.SQLiteIndex Index
		{
			get
			{
				this.CheckDisposed();
				return this.index;
			}
		}

		// Token: 0x0600050F RID: 1295 RVA: 0x00021F84 File Offset: 0x00021384
		public virtual bool BestIndex(global::System.Data.SQLite.SQLiteIndex index)
		{
			this.CheckDisposed();
			this.index = index;
			return true;
		}

		// Token: 0x06000510 RID: 1296 RVA: 0x00021FA0 File Offset: 0x000213A0
		public virtual bool Rename(string name)
		{
			this.CheckDisposed();
			if (this.arguments != null && this.arguments.Length > 2)
			{
				this.arguments[2] = name;
				return true;
			}
			return false;
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x06000511 RID: 1297 RVA: 0x00021FD4 File Offset: 0x000213D4
		// (set) Token: 0x06000512 RID: 1298 RVA: 0x00021FF0 File Offset: 0x000213F0
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

		// Token: 0x06000513 RID: 1299 RVA: 0x00022004 File Offset: 0x00021404
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x06000514 RID: 1300 RVA: 0x00022020 File Offset: 0x00021420
		private void CheckDisposed()
		{
			if (this.disposed)
			{
				throw new global::System.ObjectDisposedException(typeof(global::System.Data.SQLite.SQLiteVirtualTable).Name);
			}
		}

		// Token: 0x06000515 RID: 1301 RVA: 0x0002204C File Offset: 0x0002144C
		protected virtual void Dispose(bool disposing)
		{
			if (!this.disposed)
			{
				this.disposed = true;
			}
		}

		// Token: 0x06000516 RID: 1302 RVA: 0x00022068 File Offset: 0x00021468
		~SQLiteVirtualTable()
		{
			this.Dispose(false);
		}

		// Token: 0x04000214 RID: 532
		private const int ModuleNameIndex = 0;

		// Token: 0x04000215 RID: 533
		private const int DatabaseNameIndex = 1;

		// Token: 0x04000216 RID: 534
		private const int TableNameIndex = 2;

		// Token: 0x04000217 RID: 535
		private string[] arguments;

		// Token: 0x04000218 RID: 536
		private global::System.Data.SQLite.SQLiteIndex index;

		// Token: 0x04000219 RID: 537
		private global::System.IntPtr nativeHandle;

		// Token: 0x0400021A RID: 538
		private bool disposed;
	}
}
