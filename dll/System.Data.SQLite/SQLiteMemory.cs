using System;

namespace System.Data.SQLite
{
	// Token: 0x02000082 RID: 130
	internal static class SQLiteMemory
	{
		// Token: 0x06000556 RID: 1366 RVA: 0x000222DC File Offset: 0x000216DC
		public static global::System.IntPtr Allocate(int size)
		{
			return global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_malloc(size);
		}

		// Token: 0x06000557 RID: 1367 RVA: 0x000222F4 File Offset: 0x000216F4
		public static int Size(global::System.IntPtr pMemory)
		{
			return global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_malloc_size_interop(pMemory);
		}

		// Token: 0x06000558 RID: 1368 RVA: 0x00022308 File Offset: 0x00021708
		public static void Free(global::System.IntPtr pMemory)
		{
			global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_free(pMemory);
		}
	}
}
