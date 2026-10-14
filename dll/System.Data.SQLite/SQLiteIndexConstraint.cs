using System;

namespace System.Data.SQLite
{
	// Token: 0x02000078 RID: 120
	public sealed class SQLiteIndexConstraint
	{
		// Token: 0x060004EE RID: 1262 RVA: 0x0002195C File Offset: 0x00020D5C
		internal SQLiteIndexConstraint(global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_index_constraint constraint) : this(constraint.iColumn, constraint.op, constraint.usable, constraint.iTermOffset)
		{
		}

		// Token: 0x060004EF RID: 1263 RVA: 0x0002198C File Offset: 0x00020D8C
		private SQLiteIndexConstraint(int iColumn, global::System.Data.SQLite.SQLiteIndexConstraintOp op, byte usable, int iTermOffset)
		{
			this.iColumn = iColumn;
			this.op = op;
			this.usable = usable;
			this.iTermOffset = iTermOffset;
		}

		// Token: 0x04000201 RID: 513
		public int iColumn;

		// Token: 0x04000202 RID: 514
		public global::System.Data.SQLite.SQLiteIndexConstraintOp op;

		// Token: 0x04000203 RID: 515
		public byte usable;

		// Token: 0x04000204 RID: 516
		public int iTermOffset;
	}
}
