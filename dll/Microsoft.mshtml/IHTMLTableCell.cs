using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace mshtml
{
	// Token: 0x02000A00 RID: 2560
	[global::System.Runtime.InteropServices.TypeLibType(4160)]
	[global::System.Runtime.InteropServices.Guid("3050F23D-98B5-11CF-BB82-00AA00BDCE0B")]
	[global::System.Runtime.InteropServices.ComImport]
	public interface IHTMLTableCell
	{
		// Token: 0x1700558C RID: 21900
		// (get) Token: 0x060103F4 RID: 66548
		// (set) Token: 0x060103F3 RID: 66547
		[global::System.Runtime.InteropServices.DispId(2001)]
		int rowSpan { [global::System.Runtime.InteropServices.DispId(2001)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(2001)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700558D RID: 21901
		// (get) Token: 0x060103F6 RID: 66550
		// (set) Token: 0x060103F5 RID: 66549
		[global::System.Runtime.InteropServices.DispId(2002)]
		int colSpan { [global::System.Runtime.InteropServices.DispId(2002)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(2002)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700558E RID: 21902
		// (get) Token: 0x060103F8 RID: 66552
		// (set) Token: 0x060103F7 RID: 66551
		[global::System.Runtime.InteropServices.DispId(-2147418040)]
		string align { [global::System.Runtime.InteropServices.DispId(-2147418040)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(-2147418040)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700558F RID: 21903
		// (get) Token: 0x060103FA RID: 66554
		// (set) Token: 0x060103F9 RID: 66553
		[global::System.Runtime.InteropServices.DispId(-2147413081)]
		string vAlign { [global::System.Runtime.InteropServices.DispId(-2147413081)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(-2147413081)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17005590 RID: 21904
		// (get) Token: 0x060103FC RID: 66556
		// (set) Token: 0x060103FB RID: 66555
		[global::System.Runtime.InteropServices.DispId(-501)]
		object bgColor { [global::System.Runtime.InteropServices.DispId(-501)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-501)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17005591 RID: 21905
		// (get) Token: 0x060103FE RID: 66558
		// (set) Token: 0x060103FD RID: 66557
		[global::System.Runtime.InteropServices.DispId(-2147413107)]
		bool noWrap { [global::System.Runtime.InteropServices.DispId(-2147413107)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(-2147413107)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17005592 RID: 21906
		// (get) Token: 0x06010400 RID: 66560
		// (set) Token: 0x060103FF RID: 66559
		[global::System.Runtime.InteropServices.DispId(-2147413111)]
		string background { [global::System.Runtime.InteropServices.DispId(-2147413111)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(-2147413111)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17005593 RID: 21907
		// (get) Token: 0x06010402 RID: 66562
		// (set) Token: 0x06010401 RID: 66561
		[global::System.Runtime.InteropServices.DispId(-2147413084)]
		object borderColor { [global::System.Runtime.InteropServices.DispId(-2147413084)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147413084)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17005594 RID: 21908
		// (get) Token: 0x06010404 RID: 66564
		// (set) Token: 0x06010403 RID: 66563
		[global::System.Runtime.InteropServices.DispId(-2147413083)]
		object borderColorLight { [global::System.Runtime.InteropServices.DispId(-2147413083)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147413083)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17005595 RID: 21909
		// (get) Token: 0x06010406 RID: 66566
		// (set) Token: 0x06010405 RID: 66565
		[global::System.Runtime.InteropServices.DispId(-2147413082)]
		object borderColorDark { [global::System.Runtime.InteropServices.DispId(-2147413082)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147413082)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17005596 RID: 21910
		// (get) Token: 0x06010408 RID: 66568
		// (set) Token: 0x06010407 RID: 66567
		[global::System.Runtime.InteropServices.DispId(-2147418107)]
		object width { [global::System.Runtime.InteropServices.DispId(-2147418107)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147418107)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17005597 RID: 21911
		// (get) Token: 0x0601040A RID: 66570
		// (set) Token: 0x06010409 RID: 66569
		[global::System.Runtime.InteropServices.DispId(-2147418106)]
		object height { [global::System.Runtime.InteropServices.DispId(-2147418106)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147418106)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17005598 RID: 21912
		// (get) Token: 0x0601040B RID: 66571
		[global::System.Runtime.InteropServices.DispId(2003)]
		int cellIndex { [global::System.Runtime.InteropServices.DispId(2003)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }
	}
}
