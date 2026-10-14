using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace mshtml
{
	// Token: 0x020009F5 RID: 2549
	[global::System.Runtime.InteropServices.TypeLibType(4160)]
	[global::System.Runtime.InteropServices.Guid("3050F21E-98B5-11CF-BB82-00AA00BDCE0B")]
	[global::System.Runtime.InteropServices.ComImport]
	public interface IHTMLTable
	{
		// Token: 0x1700555C RID: 21852
		// (get) Token: 0x06010391 RID: 66449
		// (set) Token: 0x06010390 RID: 66448
		[global::System.Runtime.InteropServices.DispId(1001)]
		int cols { [global::System.Runtime.InteropServices.DispId(1001)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(1001)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700555D RID: 21853
		// (get) Token: 0x06010393 RID: 66451
		// (set) Token: 0x06010392 RID: 66450
		[global::System.Runtime.InteropServices.DispId(1002)]
		object border { [global::System.Runtime.InteropServices.DispId(1002)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(1002)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700555E RID: 21854
		// (get) Token: 0x06010395 RID: 66453
		// (set) Token: 0x06010394 RID: 66452
		[global::System.Runtime.InteropServices.DispId(1004)]
		string frame { [global::System.Runtime.InteropServices.DispId(1004)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(1004)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700555F RID: 21855
		// (get) Token: 0x06010397 RID: 66455
		// (set) Token: 0x06010396 RID: 66454
		[global::System.Runtime.InteropServices.DispId(1003)]
		string rules { [global::System.Runtime.InteropServices.DispId(1003)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(1003)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17005560 RID: 21856
		// (get) Token: 0x06010399 RID: 66457
		// (set) Token: 0x06010398 RID: 66456
		[global::System.Runtime.InteropServices.DispId(1005)]
		object cellSpacing { [global::System.Runtime.InteropServices.DispId(1005)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(1005)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17005561 RID: 21857
		// (get) Token: 0x0601039B RID: 66459
		// (set) Token: 0x0601039A RID: 66458
		[global::System.Runtime.InteropServices.DispId(1006)]
		object cellPadding { [global::System.Runtime.InteropServices.DispId(1006)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(1006)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17005562 RID: 21858
		// (get) Token: 0x0601039D RID: 66461
		// (set) Token: 0x0601039C RID: 66460
		[global::System.Runtime.InteropServices.DispId(-2147413111)]
		string background { [global::System.Runtime.InteropServices.DispId(-2147413111)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(-2147413111)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17005563 RID: 21859
		// (get) Token: 0x0601039F RID: 66463
		// (set) Token: 0x0601039E RID: 66462
		[global::System.Runtime.InteropServices.DispId(-501)]
		object bgColor { [global::System.Runtime.InteropServices.DispId(-501)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-501)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17005564 RID: 21860
		// (get) Token: 0x060103A1 RID: 66465
		// (set) Token: 0x060103A0 RID: 66464
		[global::System.Runtime.InteropServices.DispId(-2147413084)]
		object borderColor { [global::System.Runtime.InteropServices.DispId(-2147413084)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147413084)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17005565 RID: 21861
		// (get) Token: 0x060103A3 RID: 66467
		// (set) Token: 0x060103A2 RID: 66466
		[global::System.Runtime.InteropServices.DispId(-2147413083)]
		object borderColorLight { [global::System.Runtime.InteropServices.DispId(-2147413083)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147413083)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17005566 RID: 21862
		// (get) Token: 0x060103A5 RID: 66469
		// (set) Token: 0x060103A4 RID: 66468
		[global::System.Runtime.InteropServices.DispId(-2147413082)]
		object borderColorDark { [global::System.Runtime.InteropServices.DispId(-2147413082)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147413082)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17005567 RID: 21863
		// (get) Token: 0x060103A7 RID: 66471
		// (set) Token: 0x060103A6 RID: 66470
		[global::System.Runtime.InteropServices.DispId(-2147418039)]
		string align { [global::System.Runtime.InteropServices.DispId(-2147418039)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(-2147418039)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x060103A8 RID: 66472
		[global::System.Runtime.InteropServices.DispId(1015)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void refresh();

		// Token: 0x17005568 RID: 21864
		// (get) Token: 0x060103A9 RID: 66473
		[global::System.Runtime.InteropServices.DispId(1016)]
		global::mshtml.IHTMLElementCollection rows { [global::System.Runtime.InteropServices.DispId(1016)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x17005569 RID: 21865
		// (get) Token: 0x060103AB RID: 66475
		// (set) Token: 0x060103AA RID: 66474
		[global::System.Runtime.InteropServices.DispId(-2147418107)]
		object width { [global::System.Runtime.InteropServices.DispId(-2147418107)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147418107)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700556A RID: 21866
		// (get) Token: 0x060103AD RID: 66477
		// (set) Token: 0x060103AC RID: 66476
		[global::System.Runtime.InteropServices.DispId(-2147418106)]
		object height { [global::System.Runtime.InteropServices.DispId(-2147418106)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147418106)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700556B RID: 21867
		// (get) Token: 0x060103AF RID: 66479
		// (set) Token: 0x060103AE RID: 66478
		[global::System.Runtime.InteropServices.DispId(1017)]
		int dataPageSize { [global::System.Runtime.InteropServices.DispId(1017)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(1017)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x060103B0 RID: 66480
		[global::System.Runtime.InteropServices.DispId(1018)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void nextPage();

		// Token: 0x060103B1 RID: 66481
		[global::System.Runtime.InteropServices.DispId(1019)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void previousPage();

		// Token: 0x1700556C RID: 21868
		// (get) Token: 0x060103B2 RID: 66482
		[global::System.Runtime.InteropServices.DispId(1020)]
		global::mshtml.IHTMLTableSection tHead { [global::System.Runtime.InteropServices.DispId(1020)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x1700556D RID: 21869
		// (get) Token: 0x060103B3 RID: 66483
		[global::System.Runtime.InteropServices.DispId(1021)]
		global::mshtml.IHTMLTableSection tFoot { [global::System.Runtime.InteropServices.DispId(1021)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x1700556E RID: 21870
		// (get) Token: 0x060103B4 RID: 66484
		[global::System.Runtime.InteropServices.DispId(1024)]
		global::mshtml.IHTMLElementCollection tBodies { [global::System.Runtime.InteropServices.DispId(1024)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x1700556F RID: 21871
		// (get) Token: 0x060103B5 RID: 66485
		[global::System.Runtime.InteropServices.DispId(1025)]
		global::mshtml.IHTMLTableCaption caption { [global::System.Runtime.InteropServices.DispId(1025)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x060103B6 RID: 66486
		[global::System.Runtime.InteropServices.DispId(1026)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)]
		object createTHead();

		// Token: 0x060103B7 RID: 66487
		[global::System.Runtime.InteropServices.DispId(1027)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void deleteTHead();

		// Token: 0x060103B8 RID: 66488
		[global::System.Runtime.InteropServices.DispId(1028)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)]
		object createTFoot();

		// Token: 0x060103B9 RID: 66489
		[global::System.Runtime.InteropServices.DispId(1029)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void deleteTFoot();

		// Token: 0x060103BA RID: 66490
		[global::System.Runtime.InteropServices.DispId(1030)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		global::mshtml.IHTMLTableCaption createCaption();

		// Token: 0x060103BB RID: 66491
		[global::System.Runtime.InteropServices.DispId(1031)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void deleteCaption();

		// Token: 0x060103BC RID: 66492
		[global::System.Runtime.InteropServices.DispId(1032)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)]
		object insertRow([global::System.Runtime.InteropServices.In] int index = -1);

		// Token: 0x060103BD RID: 66493
		[global::System.Runtime.InteropServices.DispId(1033)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void deleteRow([global::System.Runtime.InteropServices.In] int index = -1);

		// Token: 0x17005570 RID: 21872
		// (get) Token: 0x060103BE RID: 66494
		[global::System.Runtime.InteropServices.DispId(-2147412996)]
		string readyState { [global::System.Runtime.InteropServices.DispId(-2147412996)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x17005571 RID: 21873
		// (get) Token: 0x060103C0 RID: 66496
		// (set) Token: 0x060103BF RID: 66495
		[global::System.Runtime.InteropServices.DispId(-2147412087)]
		object onreadystatechange { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412087)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412087)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }
	}
}
