using System;
using System.Runtime.InteropServices;

namespace System.Data.SQLite
{
	// Token: 0x02000014 RID: 20
	// (Invoke) Token: 0x06000219 RID: 537
	[global::System.Runtime.InteropServices.UnmanagedFunctionPointer(global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
	internal delegate global::System.Data.SQLite.SQLiteAuthorizerReturnCode SQLiteAuthorizerCallback(global::System.IntPtr pUserData, global::System.Data.SQLite.SQLiteAuthorizerActionCode actionCode, global::System.IntPtr pArgument1, global::System.IntPtr pArgument2, global::System.IntPtr pDatabase, global::System.IntPtr pAuthContext);
}
