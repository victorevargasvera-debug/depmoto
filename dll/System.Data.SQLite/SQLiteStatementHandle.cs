using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace System.Data.SQLite
{
	// Token: 0x02000071 RID: 113
	internal sealed class SQLiteStatementHandle : global::System.Runtime.InteropServices.CriticalHandle
	{
		// Token: 0x060004BD RID: 1213 RVA: 0x00020EF8 File Offset: 0x000202F8
		public static implicit operator global::System.IntPtr(global::System.Data.SQLite.SQLiteStatementHandle stmt)
		{
			if (stmt != null)
			{
				return stmt.handle;
			}
			return global::System.IntPtr.Zero;
		}

		// Token: 0x060004BE RID: 1214 RVA: 0x00020F14 File Offset: 0x00020314
		internal SQLiteStatementHandle(global::System.Data.SQLite.SQLiteConnectionHandle cnn, global::System.IntPtr stmt) : this()
		{
			this.cnn = cnn;
			base.SetHandle(stmt);
		}

		// Token: 0x060004BF RID: 1215 RVA: 0x00020F38 File Offset: 0x00020338
		private SQLiteStatementHandle() : base(global::System.IntPtr.Zero)
		{
		}

		// Token: 0x060004C0 RID: 1216 RVA: 0x00020F50 File Offset: 0x00020350
		protected override bool ReleaseHandle()
		{
			try
			{
				global::System.IntPtr intPtr = global::System.Threading.Interlocked.Exchange(ref this.handle, global::System.IntPtr.Zero);
				if (intPtr != global::System.IntPtr.Zero)
				{
					global::System.Data.SQLite.SQLiteBase.FinalizeStatement(this.cnn, intPtr);
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

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x060004C1 RID: 1217 RVA: 0x00020FCC File Offset: 0x000203CC
		public override bool IsInvalid
		{
			get
			{
				return this.handle == global::System.IntPtr.Zero;
			}
		}

		// Token: 0x040001F0 RID: 496
		private global::System.Data.SQLite.SQLiteConnectionHandle cnn;
	}
}
