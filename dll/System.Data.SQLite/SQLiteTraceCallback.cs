using System;
using System.Runtime.InteropServices;

namespace System.Data.SQLite
{
	// Token: 0x02000017 RID: 23
	// (Invoke) Token: 0x06000225 RID: 549
	[global::System.Runtime.InteropServices.UnmanagedFunctionPointer(global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
	internal delegate void SQLiteTraceCallback(global::System.IntPtr puser, global::System.IntPtr statement);
}
