using System;

namespace System.Data.SQLite
{
	// Token: 0x02000044 RID: 68
	public struct CollationSequence
	{
		// Token: 0x06000329 RID: 809 RVA: 0x0001D82C File Offset: 0x0001CC2C
		public int Compare(string s1, string s2)
		{
			return this._func._base.ContextCollateCompare(this.Encoding, this._func._context, s1, s2);
		}

		// Token: 0x0600032A RID: 810 RVA: 0x0001D85C File Offset: 0x0001CC5C
		public int Compare(char[] c1, char[] c2)
		{
			return this._func._base.ContextCollateCompare(this.Encoding, this._func._context, c1, c2);
		}

		// Token: 0x04000186 RID: 390
		public string Name;

		// Token: 0x04000187 RID: 391
		public global::System.Data.SQLite.CollationTypeEnum Type;

		// Token: 0x04000188 RID: 392
		public global::System.Data.SQLite.CollationEncodingEnum Encoding;

		// Token: 0x04000189 RID: 393
		internal global::System.Data.SQLite.SQLiteFunction _func;
	}
}
