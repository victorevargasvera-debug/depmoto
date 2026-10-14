using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace mshtml
{
	// Token: 0x02000DB5 RID: 3509
	[global::System.Runtime.InteropServices.InterfaceType(1)]
	[global::System.Runtime.InteropServices.Guid("00000100-0000-0000-C000-000000000046")]
	[global::System.Runtime.InteropServices.ComImport]
	public interface IEnumUnknown
	{
		// Token: 0x060174BD RID: 95421
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void RemoteNext([global::System.Runtime.InteropServices.In] uint celt, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IUnknown)] out object rgelt, out uint pceltFetched);

		// Token: 0x060174BE RID: 95422
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void Skip([global::System.Runtime.InteropServices.In] uint celt);

		// Token: 0x060174BF RID: 95423
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void reset();

		// Token: 0x060174C0 RID: 95424
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void Clone([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] out global::mshtml.IEnumUnknown ppEnum);
	}
}
