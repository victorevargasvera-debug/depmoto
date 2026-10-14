using System;
using System.Runtime.InteropServices;

namespace System.Data.SQLite
{
	// Token: 0x0200003F RID: 63
	// (Invoke) Token: 0x0600031E RID: 798
	[global::System.Runtime.InteropServices.UnmanagedFunctionPointer(global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
	public delegate void SQLiteCallback(global::System.IntPtr context, int argc, global::System.IntPtr argv);
}
