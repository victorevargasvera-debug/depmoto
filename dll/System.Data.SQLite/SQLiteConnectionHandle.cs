using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace System.Data.SQLite
{
	// Token: 0x02000070 RID: 112
	internal sealed class SQLiteConnectionHandle : global::System.Runtime.InteropServices.CriticalHandle
	{
		// Token: 0x060004B7 RID: 1207 RVA: 0x00020DEC File Offset: 0x000201EC
		public static implicit operator global::System.IntPtr(global::System.Data.SQLite.SQLiteConnectionHandle db)
		{
			if (db != null)
			{
				return db.handle;
			}
			return global::System.IntPtr.Zero;
		}

		// Token: 0x060004B8 RID: 1208 RVA: 0x00020E08 File Offset: 0x00020208
		internal SQLiteConnectionHandle(global::System.IntPtr db, bool ownHandle) : this(ownHandle)
		{
			this.ownHandle = ownHandle;
			base.SetHandle(db);
		}

		// Token: 0x060004B9 RID: 1209 RVA: 0x00020E2C File Offset: 0x0002022C
		private SQLiteConnectionHandle(bool ownHandle) : base(global::System.IntPtr.Zero)
		{
		}

		// Token: 0x060004BA RID: 1210 RVA: 0x00020E44 File Offset: 0x00020244
		protected override bool ReleaseHandle()
		{
			if (!this.ownHandle)
			{
				return true;
			}
			try
			{
				global::System.IntPtr intPtr = global::System.Threading.Interlocked.Exchange(ref this.handle, global::System.IntPtr.Zero);
				if (intPtr != global::System.IntPtr.Zero)
				{
					global::System.Data.SQLite.SQLiteBase.CloseConnection(this, intPtr);
				}
			}
			catch (global::System.Data.SQLite.SQLiteException)
			{
			}
			finally
			{
				base.SetHandleAsInvalid();
			}
			return true;
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x060004BB RID: 1211 RVA: 0x00020EC4 File Offset: 0x000202C4
		public bool OwnHandle
		{
			get
			{
				return this.ownHandle;
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x060004BC RID: 1212 RVA: 0x00020ED8 File Offset: 0x000202D8
		public override bool IsInvalid
		{
			get
			{
				return this.handle == global::System.IntPtr.Zero;
			}
		}

		// Token: 0x040001EF RID: 495
		private bool ownHandle;
	}
}
