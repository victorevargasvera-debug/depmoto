using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace mshtml
{
	// Token: 0x02000147 RID: 327
	[global::System.Runtime.InteropServices.Guid("3050F2E3-98B5-11CF-BB82-00AA00BDCE0B")]
	[global::System.Runtime.InteropServices.TypeLibType(4160)]
	[global::System.Runtime.InteropServices.ComImport]
	public interface IHTMLStyleSheet
	{
		// Token: 0x170008E4 RID: 2276
		// (get) Token: 0x060013D1 RID: 5073
		// (set) Token: 0x060013D0 RID: 5072
		[global::System.Runtime.InteropServices.DispId(1001)]
		string title { [global::System.Runtime.InteropServices.DispId(1001)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(1001)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170008E5 RID: 2277
		// (get) Token: 0x060013D2 RID: 5074
		[global::System.Runtime.InteropServices.DispId(1002)]
		global::mshtml.IHTMLStyleSheet parentStyleSheet { [global::System.Runtime.InteropServices.DispId(1002)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x170008E6 RID: 2278
		// (get) Token: 0x060013D3 RID: 5075
		[global::System.Runtime.InteropServices.DispId(1003)]
		global::mshtml.IHTMLElement owningElement { [global::System.Runtime.InteropServices.DispId(1003)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x170008E7 RID: 2279
		// (get) Token: 0x060013D5 RID: 5077
		// (set) Token: 0x060013D4 RID: 5076
		[global::System.Runtime.InteropServices.DispId(-2147418036)]
		bool disabled { [global::System.Runtime.InteropServices.DispId(-2147418036)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(-2147418036)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170008E8 RID: 2280
		// (get) Token: 0x060013D6 RID: 5078
		[global::System.Runtime.InteropServices.DispId(1004)]
		bool readOnly { [global::System.Runtime.InteropServices.DispId(1004)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x170008E9 RID: 2281
		// (get) Token: 0x060013D7 RID: 5079
		[global::System.Runtime.InteropServices.DispId(1005)]
		global::mshtml.HTMLStyleSheetsCollection imports { [global::System.Runtime.InteropServices.DispId(1005)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x170008EA RID: 2282
		// (get) Token: 0x060013D9 RID: 5081
		// (set) Token: 0x060013D8 RID: 5080
		[global::System.Runtime.InteropServices.DispId(1006)]
		string href { [global::System.Runtime.InteropServices.DispId(1006)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(1006)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170008EB RID: 2283
		// (get) Token: 0x060013DA RID: 5082
		[global::System.Runtime.InteropServices.DispId(1007)]
		string type { [global::System.Runtime.InteropServices.DispId(1007)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x170008EC RID: 2284
		// (get) Token: 0x060013DB RID: 5083
		[global::System.Runtime.InteropServices.DispId(1008)]
		string id { [global::System.Runtime.InteropServices.DispId(1008)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x060013DC RID: 5084
		[global::System.Runtime.InteropServices.DispId(1009)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		int addImport([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string bstrUrl, [global::System.Runtime.InteropServices.In] int lIndex = -1);

		// Token: 0x060013DD RID: 5085
		[global::System.Runtime.InteropServices.DispId(1010)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		int addRule([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string bstrSelector, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string bstrStyle, [global::System.Runtime.InteropServices.In] int lIndex = -1);

		// Token: 0x060013DE RID: 5086
		[global::System.Runtime.InteropServices.DispId(1011)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void removeImport([global::System.Runtime.InteropServices.In] int lIndex);

		// Token: 0x060013DF RID: 5087
		[global::System.Runtime.InteropServices.DispId(1012)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void removeRule([global::System.Runtime.InteropServices.In] int lIndex);

		// Token: 0x170008ED RID: 2285
		// (get) Token: 0x060013E1 RID: 5089
		// (set) Token: 0x060013E0 RID: 5088
		[global::System.Runtime.InteropServices.DispId(1013)]
		string media { [global::System.Runtime.InteropServices.DispId(1013)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(1013)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170008EE RID: 2286
		// (get) Token: 0x060013E3 RID: 5091
		// (set) Token: 0x060013E2 RID: 5090
		[global::System.Runtime.InteropServices.DispId(1014)]
		string cssText { [global::System.Runtime.InteropServices.DispId(1014)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(1014)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170008EF RID: 2287
		// (get) Token: 0x060013E4 RID: 5092
		[global::System.Runtime.InteropServices.DispId(1015)]
		global::mshtml.HTMLStyleSheetRulesCollection rules { [global::System.Runtime.InteropServices.DispId(1015)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }
	}
}
