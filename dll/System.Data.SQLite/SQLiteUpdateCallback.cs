using System;
using System.Runtime.InteropServices;

namespace System.Data.SQLite
{
	// Token: 0x02000015 RID: 21
	// (Invoke) Token: 0x0600021D RID: 541
	[global::System.Runtime.InteropServices.UnmanagedFunctionPointer(global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
	internal delegate void SQLiteUpdateCallback(global::System.IntPtr puser, int type, global::System.IntPtr database, global::System.IntPtr table, long rowid);
}
