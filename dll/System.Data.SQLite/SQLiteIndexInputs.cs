using System;

namespace System.Data.SQLite
{
	// Token: 0x0200007B RID: 123
	public sealed class SQLiteIndexInputs
	{
		// Token: 0x060004F4 RID: 1268 RVA: 0x00021A4C File Offset: 0x00020E4C
		internal SQLiteIndexInputs(int nConstraint, int nOrderBy)
		{
			this.constraints = new global::System.Data.SQLite.SQLiteIndexConstraint[nConstraint];
			this.orderBys = new global::System.Data.SQLite.SQLiteIndexOrderBy[nOrderBy];
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x060004F5 RID: 1269 RVA: 0x00021A78 File Offset: 0x00020E78
		public global::System.Data.SQLite.SQLiteIndexConstraint[] Constraints
		{
			get
			{
				return this.constraints;
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x060004F6 RID: 1270 RVA: 0x00021A8C File Offset: 0x00020E8C
		public global::System.Data.SQLite.SQLiteIndexOrderBy[] OrderBys
		{
			get
			{
				return this.orderBys;
			}
		}

		// Token: 0x04000209 RID: 521
		private global::System.Data.SQLite.SQLiteIndexConstraint[] constraints;

		// Token: 0x0400020A RID: 522
		private global::System.Data.SQLite.SQLiteIndexOrderBy[] orderBys;
	}
}
