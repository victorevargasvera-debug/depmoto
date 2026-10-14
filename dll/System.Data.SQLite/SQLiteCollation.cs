using System;
using System.Runtime.InteropServices;

namespace System.Data.SQLite
{
	// Token: 0x02000041 RID: 65
	// (Invoke) Token: 0x06000326 RID: 806
	[global::System.Runtime.InteropServices.UnmanagedFunctionPointer(global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
	internal delegate int SQLiteCollation(global::System.IntPtr puser, int len1, global::System.IntPtr pv1, int len2, global::System.IntPtr pv2);
}
