using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace mshtml
{
	// Token: 0x02000148 RID: 328
	[global::System.Runtime.InteropServices.TypeLibType(4160)]
	[global::System.Runtime.InteropServices.Guid("3050F3D1-98B5-11CF-BB82-00AA00BDCE0B")]
	[global::System.Runtime.InteropServices.ComImport]
	public interface IHTMLStyleSheet2
	{
		// Token: 0x170008F0 RID: 2288
		// (get) Token: 0x060013E5 RID: 5093
		[global::System.Runtime.InteropServices.DispId(1016)]
		global::mshtml.HTMLStyleSheetPagesCollection pages { [global::System.Runtime.InteropServices.DispId(1016)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x060013E6 RID: 5094
		[global::System.Runtime.InteropServices.DispId(1017)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		int addPageRule([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string bstrSelector, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string bstrStyle, [global::System.Runtime.InteropServices.In] int lIndex = -1);
	}
}
