using System;

namespace System.Data.SQLite
{
	// Token: 0x0200002C RID: 44
	public enum SQLiteExecuteType
	{
		// Token: 0x040000FC RID: 252
		None,
		// Token: 0x040000FD RID: 253
		NonQuery,
		// Token: 0x040000FE RID: 254
		Scalar,
		// Token: 0x040000FF RID: 255
		Reader,
		// Token: 0x04000100 RID: 256
		Default = 1
	}
}
