using System;
using System.Collections.Generic;

namespace System.Data.SQLite
{
	// Token: 0x02000023 RID: 35
	public interface ISQLiteConnectionPool
	{
		// Token: 0x06000245 RID: 581
		void GetCounts(string fileName, ref global::System.Collections.Generic.Dictionary<string, int> counts, ref int openCount, ref int closeCount, ref int totalCount);

		// Token: 0x06000246 RID: 582
		void ClearPool(string fileName);

		// Token: 0x06000247 RID: 583
		void ClearAllPools();

		// Token: 0x06000248 RID: 584
		void Add(string fileName, object handle, int version);

		// Token: 0x06000249 RID: 585
		object Remove(string fileName, int maxPoolSize, out int version);
	}
}
