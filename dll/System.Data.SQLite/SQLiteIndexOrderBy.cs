using System;

namespace System.Data.SQLite
{
	// Token: 0x02000079 RID: 121
	public sealed class SQLiteIndexOrderBy
	{
		// Token: 0x060004F0 RID: 1264 RVA: 0x000219BC File Offset: 0x00020DBC
		internal SQLiteIndexOrderBy(global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_index_orderby orderBy) : this(orderBy.iColumn, orderBy.desc)
		{
		}

		// Token: 0x060004F1 RID: 1265 RVA: 0x000219E0 File Offset: 0x00020DE0
		private SQLiteIndexOrderBy(int iColumn, byte desc)
		{
			this.iColumn = iColumn;
			this.desc = desc;
		}

		// Token: 0x04000205 RID: 517
		public int iColumn;

		// Token: 0x04000206 RID: 518
		public byte desc;
	}
}
