using System;

namespace System.Data.SQLite
{
	// Token: 0x02000027 RID: 39
	public enum TypeAffinity
	{
		// Token: 0x040000D0 RID: 208
		Uninitialized,
		// Token: 0x040000D1 RID: 209
		Int64,
		// Token: 0x040000D2 RID: 210
		Double,
		// Token: 0x040000D3 RID: 211
		Text,
		// Token: 0x040000D4 RID: 212
		Blob,
		// Token: 0x040000D5 RID: 213
		Null,
		// Token: 0x040000D6 RID: 214
		DateTime = 10,
		// Token: 0x040000D7 RID: 215
		None
	}
}
