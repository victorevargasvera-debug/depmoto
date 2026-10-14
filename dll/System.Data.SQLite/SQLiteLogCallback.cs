using System;
using System.Runtime.InteropServices;

namespace System.Data.SQLite
{
	// Token: 0x02000004 RID: 4
	// (Invoke) Token: 0x06000006 RID: 6
	[global::System.Runtime.InteropServices.UnmanagedFunctionPointer(global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
	internal delegate void SQLiteLogCallback(global::System.IntPtr pUserData, int errorCode, global::System.IntPtr pMessage);
}
