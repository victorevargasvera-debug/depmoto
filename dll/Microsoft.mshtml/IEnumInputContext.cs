using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace mshtml
{
	// Token: 0x02000CAB RID: 3243
	[global::System.Runtime.InteropServices.InterfaceType(1)]
	[global::System.Runtime.InteropServices.Guid("09B5EAB0-F997-11D1-93D4-0060B067B86E")]
	[global::System.Runtime.InteropServices.ComImport]
	public interface IEnumInputContext
	{
		// Token: 0x06016257 RID: 90711
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void Clone([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] out global::mshtml.IEnumInputContext ppEnum);

		// Token: 0x06016258 RID: 90712
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void Next([global::System.Runtime.InteropServices.In] uint ulCount, out uint rgInputContext, out uint pcFetched);

		// Token: 0x06016259 RID: 90713
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void reset();

		// Token: 0x0601625A RID: 90714
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void Skip([global::System.Runtime.InteropServices.In] uint ulCount);
	}
}
