using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace mshtml
{
	// Token: 0x020009FC RID: 2556
	[global::System.Runtime.InteropServices.TypeLibType(4160)]
	[global::System.Runtime.InteropServices.Guid("3050F23C-98B5-11CF-BB82-00AA00BDCE0B")]
	[global::System.Runtime.InteropServices.ComImport]
	public interface IHTMLTableRow
	{
		// Token: 0x1700557C RID: 21884
		// (get) Token: 0x060103D9 RID: 66521
		// (set) Token: 0x060103D8 RID: 66520
		[global::System.Runtime.InteropServices.DispId(-2147418040)]
		string align { [global::System.Runtime.InteropServices.DispId(-2147418040)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(-2147418040)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700557D RID: 21885
		// (get) Token: 0x060103DB RID: 66523
		// (set) Token: 0x060103DA RID: 66522
		[global::System.Runtime.InteropServices.DispId(-2147413081)]
		string vAlign { [global::System.Runtime.InteropServices.DispId(-2147413081)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(-2147413081)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700557E RID: 21886
		// (get) Token: 0x060103DD RID: 66525
		// (set) Token: 0x060103DC RID: 66524
		[global::System.Runtime.InteropServices.DispId(-501)]
		object bgColor { [global::System.Runtime.InteropServices.DispId(-501)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-501)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700557F RID: 21887
		// (get) Token: 0x060103DF RID: 66527
		// (set) Token: 0x060103DE RID: 66526
		[global::System.Runtime.InteropServices.DispId(-2147413084)]
		object borderColor { [global::System.Runtime.InteropServices.DispId(-2147413084)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147413084)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17005580 RID: 21888
		// (get) Token: 0x060103E1 RID: 66529
		// (set) Token: 0x060103E0 RID: 66528
		[global::System.Runtime.InteropServices.DispId(-2147413083)]
		object borderColorLight { [global::System.Runtime.InteropServices.DispId(-2147413083)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147413083)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17005581 RID: 21889
		// (get) Token: 0x060103E3 RID: 66531
		// (set) Token: 0x060103E2 RID: 66530
		[global::System.Runtime.InteropServices.DispId(-2147413082)]
		object borderColorDark { [global::System.Runtime.InteropServices.DispId(-2147413082)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147413082)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17005582 RID: 21890
		// (get) Token: 0x060103E4 RID: 66532
		[global::System.Runtime.InteropServices.DispId(1000)]
		int rowIndex { [global::System.Runtime.InteropServices.DispId(1000)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x17005583 RID: 21891
		// (get) Token: 0x060103E5 RID: 66533
		[global::System.Runtime.InteropServices.DispId(1001)]
		int sectionRowIndex { [global::System.Runtime.InteropServices.DispId(1001)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x17005584 RID: 21892
		// (get) Token: 0x060103E6 RID: 66534
		[global::System.Runtime.InteropServices.DispId(1002)]
		global::mshtml.IHTMLElementCollection cells { [global::System.Runtime.InteropServices.DispId(1002)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x060103E7 RID: 66535
		[global::System.Runtime.InteropServices.DispId(1003)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)]
		object insertCell([global::System.Runtime.InteropServices.In] int index = -1);

		// Token: 0x060103E8 RID: 66536
		[global::System.Runtime.InteropServices.DispId(1004)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void deleteCell([global::System.Runtime.InteropServices.In] int index = -1);
	}
}
