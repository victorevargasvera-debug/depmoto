using System;

namespace System.Data.SQLite
{
	// Token: 0x0200007A RID: 122
	public sealed class SQLiteIndexConstraintUsage
	{
		// Token: 0x060004F2 RID: 1266 RVA: 0x00021A04 File Offset: 0x00020E04
		internal SQLiteIndexConstraintUsage(global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_index_constraint_usage constraintUsage) : this(constraintUsage.argvIndex, constraintUsage.omit)
		{
		}

		// Token: 0x060004F3 RID: 1267 RVA: 0x00021A28 File Offset: 0x00020E28
		private SQLiteIndexConstraintUsage(int argvIndex, byte omit)
		{
			this.argvIndex = argvIndex;
			this.omit = omit;
		}

		// Token: 0x04000207 RID: 519
		public int argvIndex;

		// Token: 0x04000208 RID: 520
		public byte omit;
	}
}
