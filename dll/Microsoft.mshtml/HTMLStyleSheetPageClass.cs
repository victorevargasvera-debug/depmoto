using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace mshtml
{
	// Token: 0x02000142 RID: 322
	[global::System.Runtime.InteropServices.TypeLibType(2)]
	[global::System.Runtime.InteropServices.ClassInterface(0)]
	[global::System.Runtime.InteropServices.Guid("3050F7EF-98B5-11CF-BB82-00AA00BDCE0B")]
	[global::System.Runtime.InteropServices.ComImport]
	public class HTMLStyleSheetPageClass : global::mshtml.IHTMLStyleSheetPage, global::mshtml.HTMLStyleSheetPage
	{
		// Token: 0x060013C7 RID: 5063
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public extern HTMLStyleSheetPageClass();

		// Token: 0x170008E0 RID: 2272
		// (get) Token: 0x060013C8 RID: 5064
		[global::System.Runtime.InteropServices.DispId(1001)]
		public virtual extern string selector { [global::System.Runtime.InteropServices.DispId(1001)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x170008E1 RID: 2273
		// (get) Token: 0x060013C9 RID: 5065
		[global::System.Runtime.InteropServices.DispId(1002)]
		public virtual extern string pseudoClass { [global::System.Runtime.InteropServices.DispId(1002)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }
	}
}
