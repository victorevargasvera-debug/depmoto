using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ADODB
{
	// Token: 0x02000052 RID: 82
	[global::System.Runtime.InteropServices.TypeLibType(512)]
	[global::System.Runtime.InteropServices.InterfaceType(1)]
	[global::System.Runtime.InteropServices.Guid("00000516-0000-0010-8000-00AA006D2EA4")]
	[global::System.Runtime.InteropServices.ComImport]
	public interface ADOConnectionConstruction15
	{
		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x06000239 RID: 569
		[global::System.Runtime.InteropServices.DispId(1610678272)]
		object DSO { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IUnknown)] get; }

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x0600023A RID: 570
		[global::System.Runtime.InteropServices.DispId(1610678273)]
		object Session { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IUnknown)] get; }

		// Token: 0x0600023B RID: 571
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void WrapDSOandSession([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IUnknown)] [global::System.Runtime.InteropServices.In] object pDSO, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IUnknown)] [global::System.Runtime.InteropServices.In] object pSession);
	}
}
