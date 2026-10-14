using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace System.Data.SQLite
{
	// Token: 0x02000072 RID: 114
	internal sealed class SQLiteBackupHandle : global::System.Runtime.InteropServices.CriticalHandle
	{
		// Token: 0x060004C2 RID: 1218 RVA: 0x00020FEC File Offset: 0x000203EC
		public static implicit operator global::System.IntPtr(global::System.Data.SQLite.SQLiteBackupHandle backup)
		{
			if (backup != null)
			{
				return backup.handle;
			}
			return global::System.IntPtr.Zero;
		}

		// Token: 0x060004C3 RID: 1219 RVA: 0x00021008 File Offset: 0x00020408
		internal SQLiteBackupHandle(global::System.Data.SQLite.SQLiteConnectionHandle cnn, global::System.IntPtr backup) : this()
		{
			this.cnn = cnn;
			base.SetHandle(backup);
		}

		// Token: 0x060004C4 RID: 1220 RVA: 0x0002102C File Offset: 0x0002042C
		private SQLiteBackupHandle() : base(global::System.IntPtr.Zero)
		{
		}

		// Token: 0x060004C5 RID: 1221 RVA: 0x00021044 File Offset: 0x00020444
		protected override bool ReleaseHandle()
		{
			try
			{
				global::System.IntPtr intPtr = global::System.Threading.Interlocked.Exchange(ref this.handle, global::System.IntPtr.Zero);
				if (intPtr != global::System.IntPtr.Zero)
				{
					global::System.Data.SQLite.SQLiteBase.FinishBackup(this.cnn, intPtr);
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

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x060004C6 RID: 1222 RVA: 0x000210C0 File Offset: 0x000204C0
		public override bool IsInvalid
		{
			get
			{
				return this.handle == global::System.IntPtr.Zero;
			}
		}

		// Token: 0x040001F1 RID: 497
		private global::System.Data.SQLite.SQLiteConnectionHandle cnn;
	}
}
