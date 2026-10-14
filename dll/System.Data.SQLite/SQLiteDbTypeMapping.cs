using System;

namespace System.Data.SQLite
{
	// Token: 0x02000031 RID: 49
	internal sealed class SQLiteDbTypeMapping
	{
		// Token: 0x06000297 RID: 663 RVA: 0x0001A534 File Offset: 0x00019934
		internal SQLiteDbTypeMapping(string newTypeName, global::System.Data.DbType newDataType, bool newPrimary)
		{
			this.typeName = newTypeName;
			this.dataType = newDataType;
			this.primary = newPrimary;
		}

		// Token: 0x0400012B RID: 299
		internal string typeName;

		// Token: 0x0400012C RID: 300
		internal global::System.Data.DbType dataType;

		// Token: 0x0400012D RID: 301
		internal bool primary;
	}
}
