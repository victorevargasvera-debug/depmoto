using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace mshtml
{
	// Token: 0x02000B4A RID: 2890
	[global::System.Runtime.InteropServices.ClassInterface(0)]
	[global::System.Runtime.InteropServices.ComSourceInterfaces("mshtml.HTMLControlElementEvents\0mshtml.HTMLControlElementEvents2\0mshtml.HTMLFrameSiteEvents\0mshtml.HTMLFrameSiteEvents2\0\0")]
	[global::System.Runtime.InteropServices.Guid("3050F312-98B5-11CF-BB82-00AA00BDCE0B")]
	[global::System.Runtime.InteropServices.TypeLibType(2)]
	[global::System.Runtime.InteropServices.ComImport]
	public class HTMLFrameBaseClass : global::mshtml.DispHTMLFrameBase, global::mshtml.HTMLFrameBase, global::mshtml.HTMLControlElementEvents_Event, global::mshtml.IHTMLElement, global::mshtml.IHTMLElement2, global::mshtml.IHTMLElement3, global::mshtml.IHTMLElement4, global::mshtml.IHTMLUniqueName, global::mshtml.IHTMLDOMNode, global::mshtml.IHTMLDOMNode2, global::mshtml.IHTMLControlElement, global::mshtml.IHTMLFrameBase, global::mshtml.IHTMLFrameBase2, global::mshtml.IHTMLFrameBase3, global::mshtml.HTMLControlElementEvents2_Event, global::mshtml.HTMLFrameSiteEvents_Event, global::mshtml.HTMLFrameSiteEvents2_Event
	{
		// Token: 0x060131A1 RID: 78241
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public extern HTMLFrameBaseClass();

		// Token: 0x060131A2 RID: 78242
		[global::System.Runtime.InteropServices.DispId(-2147417611)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void setAttribute([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string strAttributeName, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] object AttributeValue, [global::System.Runtime.InteropServices.In] int lFlags = 1);

		// Token: 0x060131A3 RID: 78243
		[global::System.Runtime.InteropServices.DispId(-2147417610)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)]
		public virtual extern object getAttribute([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string strAttributeName, [global::System.Runtime.InteropServices.In] int lFlags = 0);

		// Token: 0x060131A4 RID: 78244
		[global::System.Runtime.InteropServices.DispId(-2147417609)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern bool removeAttribute([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string strAttributeName, [global::System.Runtime.InteropServices.In] int lFlags = 1);

		// Token: 0x17006563 RID: 25955
		// (get) Token: 0x060131A6 RID: 78246
		// (set) Token: 0x060131A5 RID: 78245
		[global::System.Runtime.InteropServices.DispId(-2147417111)]
		public virtual extern string className { [global::System.Runtime.InteropServices.TypeLibFunc(4)] [global::System.Runtime.InteropServices.DispId(-2147417111)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.TypeLibFunc(4)] [global::System.Runtime.InteropServices.DispId(-2147417111)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] set; }

		// Token: 0x17006564 RID: 25956
		// (get) Token: 0x060131A8 RID: 78248
		// (set) Token: 0x060131A7 RID: 78247
		[global::System.Runtime.InteropServices.DispId(-2147417110)]
		public virtual extern string id { [global::System.Runtime.InteropServices.TypeLibFunc(4)] [global::System.Runtime.InteropServices.DispId(-2147417110)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(-2147417110)] [global::System.Runtime.InteropServices.TypeLibFunc(4)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] set; }

		// Token: 0x17006565 RID: 25957
		// (get) Token: 0x060131A9 RID: 78249
		[global::System.Runtime.InteropServices.DispId(-2147417108)]
		public virtual extern string tagName { [global::System.Runtime.InteropServices.DispId(-2147417108)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x17006566 RID: 25958
		// (get) Token: 0x060131AA RID: 78250
		[global::System.Runtime.InteropServices.DispId(-2147418104)]
		public virtual extern global::mshtml.IHTMLElement parentElement { [global::System.Runtime.InteropServices.DispId(-2147418104)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x17006567 RID: 25959
		// (get) Token: 0x060131AB RID: 78251
		[global::System.Runtime.InteropServices.DispId(-2147418038)]
		public virtual extern global::mshtml.IHTMLStyle style { [global::System.Runtime.InteropServices.DispId(-2147418038)] [global::System.Runtime.InteropServices.TypeLibFunc(1024)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x17006568 RID: 25960
		// (get) Token: 0x060131AD RID: 78253
		// (set) Token: 0x060131AC RID: 78252
		[global::System.Runtime.InteropServices.DispId(-2147412099)]
		public virtual extern object onhelp { [global::System.Runtime.InteropServices.DispId(-2147412099)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412099)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x17006569 RID: 25961
		// (get) Token: 0x060131AF RID: 78255
		// (set) Token: 0x060131AE RID: 78254
		[global::System.Runtime.InteropServices.DispId(-2147412104)]
		public virtual extern object onclick { [global::System.Runtime.InteropServices.DispId(-2147412104)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412104)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x1700656A RID: 25962
		// (get) Token: 0x060131B1 RID: 78257
		// (set) Token: 0x060131B0 RID: 78256
		[global::System.Runtime.InteropServices.DispId(-2147412103)]
		public virtual extern object ondblclick { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412103)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412103)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x1700656B RID: 25963
		// (get) Token: 0x060131B3 RID: 78259
		// (set) Token: 0x060131B2 RID: 78258
		[global::System.Runtime.InteropServices.DispId(-2147412107)]
		public virtual extern object onkeydown { [global::System.Runtime.InteropServices.DispId(-2147412107)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412107)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x1700656C RID: 25964
		// (get) Token: 0x060131B5 RID: 78261
		// (set) Token: 0x060131B4 RID: 78260
		[global::System.Runtime.InteropServices.DispId(-2147412106)]
		public virtual extern object onkeyup { [global::System.Runtime.InteropServices.DispId(-2147412106)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412106)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x1700656D RID: 25965
		// (get) Token: 0x060131B7 RID: 78263
		// (set) Token: 0x060131B6 RID: 78262
		[global::System.Runtime.InteropServices.DispId(-2147412105)]
		public virtual extern object onkeypress { [global::System.Runtime.InteropServices.DispId(-2147412105)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147412105)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x1700656E RID: 25966
		// (get) Token: 0x060131B9 RID: 78265
		// (set) Token: 0x060131B8 RID: 78264
		[global::System.Runtime.InteropServices.DispId(-2147412111)]
		public virtual extern object onmouseout { [global::System.Runtime.InteropServices.DispId(-2147412111)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147412111)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x1700656F RID: 25967
		// (get) Token: 0x060131BB RID: 78267
		// (set) Token: 0x060131BA RID: 78266
		[global::System.Runtime.InteropServices.DispId(-2147412112)]
		public virtual extern object onmouseover { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412112)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412112)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x17006570 RID: 25968
		// (get) Token: 0x060131BD RID: 78269
		// (set) Token: 0x060131BC RID: 78268
		[global::System.Runtime.InteropServices.DispId(-2147412108)]
		public virtual extern object onmousemove { [global::System.Runtime.InteropServices.DispId(-2147412108)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147412108)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x17006571 RID: 25969
		// (get) Token: 0x060131BF RID: 78271
		// (set) Token: 0x060131BE RID: 78270
		[global::System.Runtime.InteropServices.DispId(-2147412110)]
		public virtual extern object onmousedown { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412110)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147412110)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x17006572 RID: 25970
		// (get) Token: 0x060131C1 RID: 78273
		// (set) Token: 0x060131C0 RID: 78272
		[global::System.Runtime.InteropServices.DispId(-2147412109)]
		public virtual extern object onmouseup { [global::System.Runtime.InteropServices.DispId(-2147412109)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147412109)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x17006573 RID: 25971
		// (get) Token: 0x060131C2 RID: 78274
		[global::System.Runtime.InteropServices.DispId(-2147417094)]
		public virtual extern object document { [global::System.Runtime.InteropServices.DispId(-2147417094)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] get; }

		// Token: 0x17006574 RID: 25972
		// (get) Token: 0x060131C4 RID: 78276
		// (set) Token: 0x060131C3 RID: 78275
		[global::System.Runtime.InteropServices.DispId(-2147418043)]
		public virtual extern string title { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147418043)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(-2147418043)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] set; }

		// Token: 0x17006575 RID: 25973
		// (get) Token: 0x060131C6 RID: 78278
		// (set) Token: 0x060131C5 RID: 78277
		[global::System.Runtime.InteropServices.DispId(-2147413012)]
		public virtual extern string language { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147413012)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(-2147413012)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] set; }

		// Token: 0x17006576 RID: 25974
		// (get) Token: 0x060131C8 RID: 78280
		// (set) Token: 0x060131C7 RID: 78279
		[global::System.Runtime.InteropServices.DispId(-2147412075)]
		public virtual extern object onselectstart { [global::System.Runtime.InteropServices.DispId(-2147412075)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147412075)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x060131C9 RID: 78281
		[global::System.Runtime.InteropServices.DispId(-2147417093)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void scrollIntoView([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] object varargStart);

		// Token: 0x060131CA RID: 78282
		[global::System.Runtime.InteropServices.DispId(-2147417092)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern bool contains([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLElement pChild);

		// Token: 0x17006577 RID: 25975
		// (get) Token: 0x060131CB RID: 78283
		[global::System.Runtime.InteropServices.DispId(-2147417088)]
		public virtual extern int sourceIndex { [global::System.Runtime.InteropServices.DispId(-2147417088)] [global::System.Runtime.InteropServices.TypeLibFunc(4)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x17006578 RID: 25976
		// (get) Token: 0x060131CC RID: 78284
		[global::System.Runtime.InteropServices.DispId(-2147417087)]
		public virtual extern object recordNumber { [global::System.Runtime.InteropServices.DispId(-2147417087)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; }

		// Token: 0x17006579 RID: 25977
		// (get) Token: 0x060131CE RID: 78286
		// (set) Token: 0x060131CD RID: 78285
		[global::System.Runtime.InteropServices.DispId(-2147413103)]
		public virtual extern string lang { [global::System.Runtime.InteropServices.DispId(-2147413103)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(-2147413103)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] set; }

		// Token: 0x1700657A RID: 25978
		// (get) Token: 0x060131CF RID: 78287
		[global::System.Runtime.InteropServices.DispId(-2147417104)]
		public virtual extern int offsetLeft { [global::System.Runtime.InteropServices.DispId(-2147417104)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700657B RID: 25979
		// (get) Token: 0x060131D0 RID: 78288
		[global::System.Runtime.InteropServices.DispId(-2147417103)]
		public virtual extern int offsetTop { [global::System.Runtime.InteropServices.DispId(-2147417103)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700657C RID: 25980
		// (get) Token: 0x060131D1 RID: 78289
		[global::System.Runtime.InteropServices.DispId(-2147417102)]
		public virtual extern int offsetWidth { [global::System.Runtime.InteropServices.DispId(-2147417102)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700657D RID: 25981
		// (get) Token: 0x060131D2 RID: 78290
		[global::System.Runtime.InteropServices.DispId(-2147417101)]
		public virtual extern int offsetHeight { [global::System.Runtime.InteropServices.DispId(-2147417101)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700657E RID: 25982
		// (get) Token: 0x060131D3 RID: 78291
		[global::System.Runtime.InteropServices.DispId(-2147417100)]
		public virtual extern global::mshtml.IHTMLElement offsetParent { [global::System.Runtime.InteropServices.DispId(-2147417100)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x1700657F RID: 25983
		// (get) Token: 0x060131D5 RID: 78293
		// (set) Token: 0x060131D4 RID: 78292
		[global::System.Runtime.InteropServices.DispId(-2147417086)]
		public virtual extern string innerHTML { [global::System.Runtime.InteropServices.DispId(-2147417086)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(-2147417086)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] set; }

		// Token: 0x17006580 RID: 25984
		// (get) Token: 0x060131D7 RID: 78295
		// (set) Token: 0x060131D6 RID: 78294
		[global::System.Runtime.InteropServices.DispId(-2147417085)]
		public virtual extern string innerText { [global::System.Runtime.InteropServices.DispId(-2147417085)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(-2147417085)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] set; }

		// Token: 0x17006581 RID: 25985
		// (get) Token: 0x060131D9 RID: 78297
		// (set) Token: 0x060131D8 RID: 78296
		[global::System.Runtime.InteropServices.DispId(-2147417084)]
		public virtual extern string outerHTML { [global::System.Runtime.InteropServices.DispId(-2147417084)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(-2147417084)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] set; }

		// Token: 0x17006582 RID: 25986
		// (get) Token: 0x060131DB RID: 78299
		// (set) Token: 0x060131DA RID: 78298
		[global::System.Runtime.InteropServices.DispId(-2147417083)]
		public virtual extern string outerText { [global::System.Runtime.InteropServices.DispId(-2147417083)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(-2147417083)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] set; }

		// Token: 0x060131DC RID: 78300
		[global::System.Runtime.InteropServices.DispId(-2147417082)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void insertAdjacentHTML([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string where, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string html);

		// Token: 0x060131DD RID: 78301
		[global::System.Runtime.InteropServices.DispId(-2147417081)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void insertAdjacentText([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string where, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string text);

		// Token: 0x17006583 RID: 25987
		// (get) Token: 0x060131DE RID: 78302
		[global::System.Runtime.InteropServices.DispId(-2147417080)]
		public virtual extern global::mshtml.IHTMLElement parentTextEdit { [global::System.Runtime.InteropServices.DispId(-2147417080)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x17006584 RID: 25988
		// (get) Token: 0x060131DF RID: 78303
		[global::System.Runtime.InteropServices.DispId(-2147417078)]
		public virtual extern bool isTextEdit { [global::System.Runtime.InteropServices.DispId(-2147417078)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x060131E0 RID: 78304
		[global::System.Runtime.InteropServices.DispId(-2147417079)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void click();

		// Token: 0x17006585 RID: 25989
		// (get) Token: 0x060131E1 RID: 78305
		[global::System.Runtime.InteropServices.DispId(-2147417077)]
		public virtual extern global::mshtml.IHTMLFiltersCollection filters { [global::System.Runtime.InteropServices.DispId(-2147417077)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x17006586 RID: 25990
		// (get) Token: 0x060131E3 RID: 78307
		// (set) Token: 0x060131E2 RID: 78306
		[global::System.Runtime.InteropServices.DispId(-2147412077)]
		public virtual extern object ondragstart { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412077)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412077)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x060131E4 RID: 78308
		[global::System.Runtime.InteropServices.DispId(-2147417076)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public virtual extern string toString();

		// Token: 0x17006587 RID: 25991
		// (get) Token: 0x060131E6 RID: 78310
		// (set) Token: 0x060131E5 RID: 78309
		[global::System.Runtime.InteropServices.DispId(-2147412091)]
		public virtual extern object onbeforeupdate { [global::System.Runtime.InteropServices.DispId(-2147412091)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412091)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x17006588 RID: 25992
		// (get) Token: 0x060131E8 RID: 78312
		// (set) Token: 0x060131E7 RID: 78311
		[global::System.Runtime.InteropServices.DispId(-2147412090)]
		public virtual extern object onafterupdate { [global::System.Runtime.InteropServices.DispId(-2147412090)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147412090)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x17006589 RID: 25993
		// (get) Token: 0x060131EA RID: 78314
		// (set) Token: 0x060131E9 RID: 78313
		[global::System.Runtime.InteropServices.DispId(-2147412074)]
		public virtual extern object onerrorupdate { [global::System.Runtime.InteropServices.DispId(-2147412074)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412074)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x1700658A RID: 25994
		// (get) Token: 0x060131EC RID: 78316
		// (set) Token: 0x060131EB RID: 78315
		[global::System.Runtime.InteropServices.DispId(-2147412094)]
		public virtual extern object onrowexit { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412094)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412094)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x1700658B RID: 25995
		// (get) Token: 0x060131EE RID: 78318
		// (set) Token: 0x060131ED RID: 78317
		[global::System.Runtime.InteropServices.DispId(-2147412093)]
		public virtual extern object onrowenter { [global::System.Runtime.InteropServices.DispId(-2147412093)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412093)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x1700658C RID: 25996
		// (get) Token: 0x060131F0 RID: 78320
		// (set) Token: 0x060131EF RID: 78319
		[global::System.Runtime.InteropServices.DispId(-2147412072)]
		public virtual extern object ondatasetchanged { [global::System.Runtime.InteropServices.DispId(-2147412072)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412072)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x1700658D RID: 25997
		// (get) Token: 0x060131F2 RID: 78322
		// (set) Token: 0x060131F1 RID: 78321
		[global::System.Runtime.InteropServices.DispId(-2147412071)]
		public virtual extern object ondataavailable { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412071)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147412071)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x1700658E RID: 25998
		// (get) Token: 0x060131F4 RID: 78324
		// (set) Token: 0x060131F3 RID: 78323
		[global::System.Runtime.InteropServices.DispId(-2147412070)]
		public virtual extern object ondatasetcomplete { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412070)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147412070)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x1700658F RID: 25999
		// (get) Token: 0x060131F6 RID: 78326
		// (set) Token: 0x060131F5 RID: 78325
		[global::System.Runtime.InteropServices.DispId(-2147412069)]
		public virtual extern object onfilterchange { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412069)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147412069)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x17006590 RID: 26000
		// (get) Token: 0x060131F7 RID: 78327
		[global::System.Runtime.InteropServices.DispId(-2147417075)]
		public virtual extern object children { [global::System.Runtime.InteropServices.DispId(-2147417075)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] get; }

		// Token: 0x17006591 RID: 26001
		// (get) Token: 0x060131F8 RID: 78328
		[global::System.Runtime.InteropServices.DispId(-2147417074)]
		public virtual extern object all { [global::System.Runtime.InteropServices.DispId(-2147417074)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] get; }

		// Token: 0x17006592 RID: 26002
		// (get) Token: 0x060131F9 RID: 78329
		[global::System.Runtime.InteropServices.DispId(-2147417073)]
		public virtual extern string scopeName { [global::System.Runtime.InteropServices.DispId(-2147417073)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x060131FA RID: 78330
		[global::System.Runtime.InteropServices.DispId(-2147417072)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void setCapture([global::System.Runtime.InteropServices.In] bool containerCapture = true);

		// Token: 0x060131FB RID: 78331
		[global::System.Runtime.InteropServices.DispId(-2147417071)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void releaseCapture();

		// Token: 0x17006593 RID: 26003
		// (get) Token: 0x060131FD RID: 78333
		// (set) Token: 0x060131FC RID: 78332
		[global::System.Runtime.InteropServices.DispId(-2147412066)]
		public virtual extern object onlosecapture { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412066)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147412066)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x060131FE RID: 78334
		[global::System.Runtime.InteropServices.DispId(-2147417070)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public virtual extern string componentFromPoint([global::System.Runtime.InteropServices.In] int x, [global::System.Runtime.InteropServices.In] int y);

		// Token: 0x060131FF RID: 78335
		[global::System.Runtime.InteropServices.DispId(-2147417069)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void doScroll([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] object component);

		// Token: 0x17006594 RID: 26004
		// (get) Token: 0x06013201 RID: 78337
		// (set) Token: 0x06013200 RID: 78336
		[global::System.Runtime.InteropServices.DispId(-2147412081)]
		public virtual extern object onscroll { [global::System.Runtime.InteropServices.DispId(-2147412081)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412081)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x17006595 RID: 26005
		// (get) Token: 0x06013203 RID: 78339
		// (set) Token: 0x06013202 RID: 78338
		[global::System.Runtime.InteropServices.DispId(-2147412063)]
		public virtual extern object ondrag { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412063)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147412063)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x17006596 RID: 26006
		// (get) Token: 0x06013205 RID: 78341
		// (set) Token: 0x06013204 RID: 78340
		[global::System.Runtime.InteropServices.DispId(-2147412062)]
		public virtual extern object ondragend { [global::System.Runtime.InteropServices.DispId(-2147412062)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412062)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x17006597 RID: 26007
		// (get) Token: 0x06013207 RID: 78343
		// (set) Token: 0x06013206 RID: 78342
		[global::System.Runtime.InteropServices.DispId(-2147412061)]
		public virtual extern object ondragenter { [global::System.Runtime.InteropServices.DispId(-2147412061)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147412061)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x17006598 RID: 26008
		// (get) Token: 0x06013209 RID: 78345
		// (set) Token: 0x06013208 RID: 78344
		[global::System.Runtime.InteropServices.DispId(-2147412060)]
		public virtual extern object ondragover { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412060)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412060)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x17006599 RID: 26009
		// (get) Token: 0x0601320B RID: 78347
		// (set) Token: 0x0601320A RID: 78346
		[global::System.Runtime.InteropServices.DispId(-2147412059)]
		public virtual extern object ondragleave { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412059)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412059)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x1700659A RID: 26010
		// (get) Token: 0x0601320D RID: 78349
		// (set) Token: 0x0601320C RID: 78348
		[global::System.Runtime.InteropServices.DispId(-2147412058)]
		public virtual extern object ondrop { [global::System.Runtime.InteropServices.DispId(-2147412058)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412058)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x1700659B RID: 26011
		// (get) Token: 0x0601320F RID: 78351
		// (set) Token: 0x0601320E RID: 78350
		[global::System.Runtime.InteropServices.DispId(-2147412054)]
		public virtual extern object onbeforecut { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412054)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412054)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x1700659C RID: 26012
		// (get) Token: 0x06013211 RID: 78353
		// (set) Token: 0x06013210 RID: 78352
		[global::System.Runtime.InteropServices.DispId(-2147412057)]
		public virtual extern object oncut { [global::System.Runtime.InteropServices.DispId(-2147412057)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412057)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x1700659D RID: 26013
		// (get) Token: 0x06013213 RID: 78355
		// (set) Token: 0x06013212 RID: 78354
		[global::System.Runtime.InteropServices.DispId(-2147412053)]
		public virtual extern object onbeforecopy { [global::System.Runtime.InteropServices.DispId(-2147412053)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412053)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x1700659E RID: 26014
		// (get) Token: 0x06013215 RID: 78357
		// (set) Token: 0x06013214 RID: 78356
		[global::System.Runtime.InteropServices.DispId(-2147412056)]
		public virtual extern object oncopy { [global::System.Runtime.InteropServices.DispId(-2147412056)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147412056)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x1700659F RID: 26015
		// (get) Token: 0x06013217 RID: 78359
		// (set) Token: 0x06013216 RID: 78358
		[global::System.Runtime.InteropServices.DispId(-2147412052)]
		public virtual extern object onbeforepaste { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412052)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412052)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x170065A0 RID: 26016
		// (get) Token: 0x06013219 RID: 78361
		// (set) Token: 0x06013218 RID: 78360
		[global::System.Runtime.InteropServices.DispId(-2147412055)]
		public virtual extern object onpaste { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412055)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147412055)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x170065A1 RID: 26017
		// (get) Token: 0x0601321A RID: 78362
		[global::System.Runtime.InteropServices.DispId(-2147417105)]
		public virtual extern global::mshtml.IHTMLCurrentStyle currentStyle { [global::System.Runtime.InteropServices.DispId(-2147417105)] [global::System.Runtime.InteropServices.TypeLibFunc(1024)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x170065A2 RID: 26018
		// (get) Token: 0x0601321C RID: 78364
		// (set) Token: 0x0601321B RID: 78363
		[global::System.Runtime.InteropServices.DispId(-2147412065)]
		public virtual extern object onpropertychange { [global::System.Runtime.InteropServices.DispId(-2147412065)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412065)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x0601321D RID: 78365
		[global::System.Runtime.InteropServices.DispId(-2147417068)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		public virtual extern global::mshtml.IHTMLRectCollection getClientRects();

		// Token: 0x0601321E RID: 78366
		[global::System.Runtime.InteropServices.DispId(-2147417067)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		public virtual extern global::mshtml.IHTMLRect getBoundingClientRect();

		// Token: 0x0601321F RID: 78367
		[global::System.Runtime.InteropServices.DispId(-2147417608)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void setExpression([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string propname, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string expression, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string language = "");

		// Token: 0x06013220 RID: 78368
		[global::System.Runtime.InteropServices.DispId(-2147417607)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)]
		public virtual extern object getExpression([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string propname);

		// Token: 0x06013221 RID: 78369
		[global::System.Runtime.InteropServices.DispId(-2147417606)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern bool removeExpression([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string propname);

		// Token: 0x170065A3 RID: 26019
		// (get) Token: 0x06013223 RID: 78371
		// (set) Token: 0x06013222 RID: 78370
		[global::System.Runtime.InteropServices.DispId(-2147418097)]
		public virtual extern short tabIndex { [global::System.Runtime.InteropServices.DispId(-2147418097)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(-2147418097)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] set; }

		// Token: 0x06013224 RID: 78372
		[global::System.Runtime.InteropServices.DispId(-2147416112)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void focus();

		// Token: 0x170065A4 RID: 26020
		// (get) Token: 0x06013226 RID: 78374
		// (set) Token: 0x06013225 RID: 78373
		[global::System.Runtime.InteropServices.DispId(-2147416107)]
		public virtual extern string accessKey { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147416107)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(-2147416107)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] set; }

		// Token: 0x170065A5 RID: 26021
		// (get) Token: 0x06013228 RID: 78376
		// (set) Token: 0x06013227 RID: 78375
		[global::System.Runtime.InteropServices.DispId(-2147412097)]
		public virtual extern object onblur { [global::System.Runtime.InteropServices.DispId(-2147412097)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147412097)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x170065A6 RID: 26022
		// (get) Token: 0x0601322A RID: 78378
		// (set) Token: 0x06013229 RID: 78377
		[global::System.Runtime.InteropServices.DispId(-2147412098)]
		public virtual extern object onfocus { [global::System.Runtime.InteropServices.DispId(-2147412098)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412098)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x170065A7 RID: 26023
		// (get) Token: 0x0601322C RID: 78380
		// (set) Token: 0x0601322B RID: 78379
		[global::System.Runtime.InteropServices.DispId(-2147412076)]
		public virtual extern object onresize { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412076)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412076)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x0601322D RID: 78381
		[global::System.Runtime.InteropServices.DispId(-2147416110)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void blur();

		// Token: 0x0601322E RID: 78382
		[global::System.Runtime.InteropServices.DispId(-2147416095)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void addFilter([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IUnknown)] [global::System.Runtime.InteropServices.In] object pUnk);

		// Token: 0x0601322F RID: 78383
		[global::System.Runtime.InteropServices.DispId(-2147416094)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void removeFilter([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IUnknown)] [global::System.Runtime.InteropServices.In] object pUnk);

		// Token: 0x170065A8 RID: 26024
		// (get) Token: 0x06013230 RID: 78384
		[global::System.Runtime.InteropServices.DispId(-2147416093)]
		public virtual extern int clientHeight { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147416093)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x170065A9 RID: 26025
		// (get) Token: 0x06013231 RID: 78385
		[global::System.Runtime.InteropServices.DispId(-2147416092)]
		public virtual extern int clientWidth { [global::System.Runtime.InteropServices.DispId(-2147416092)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x170065AA RID: 26026
		// (get) Token: 0x06013232 RID: 78386
		[global::System.Runtime.InteropServices.DispId(-2147416091)]
		public virtual extern int clientTop { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147416091)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x170065AB RID: 26027
		// (get) Token: 0x06013233 RID: 78387
		[global::System.Runtime.InteropServices.DispId(-2147416090)]
		public virtual extern int clientLeft { [global::System.Runtime.InteropServices.DispId(-2147416090)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x06013234 RID: 78388
		[global::System.Runtime.InteropServices.DispId(-2147417605)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern bool attachEvent([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string @event, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] [global::System.Runtime.InteropServices.In] object pdisp);

		// Token: 0x06013235 RID: 78389
		[global::System.Runtime.InteropServices.DispId(-2147417604)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void detachEvent([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string @event, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] [global::System.Runtime.InteropServices.In] object pdisp);

		// Token: 0x170065AC RID: 26028
		// (get) Token: 0x06013236 RID: 78390
		[global::System.Runtime.InteropServices.DispId(-2147412996)]
		public virtual extern object readyState { [global::System.Runtime.InteropServices.DispId(-2147412996)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; }

		// Token: 0x170065AD RID: 26029
		// (get) Token: 0x06013238 RID: 78392
		// (set) Token: 0x06013237 RID: 78391
		[global::System.Runtime.InteropServices.DispId(-2147412087)]
		public virtual extern object onreadystatechange { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412087)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147412087)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x170065AE RID: 26030
		// (get) Token: 0x0601323A RID: 78394
		// (set) Token: 0x06013239 RID: 78393
		[global::System.Runtime.InteropServices.DispId(-2147412050)]
		public virtual extern object onrowsdelete { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412050)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147412050)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x170065AF RID: 26031
		// (get) Token: 0x0601323C RID: 78396
		// (set) Token: 0x0601323B RID: 78395
		[global::System.Runtime.InteropServices.DispId(-2147412049)]
		public virtual extern object onrowsinserted { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412049)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412049)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x170065B0 RID: 26032
		// (get) Token: 0x0601323E RID: 78398
		// (set) Token: 0x0601323D RID: 78397
		[global::System.Runtime.InteropServices.DispId(-2147412048)]
		public virtual extern object oncellchange { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412048)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147412048)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x170065B1 RID: 26033
		// (get) Token: 0x06013240 RID: 78400
		// (set) Token: 0x0601323F RID: 78399
		[global::System.Runtime.InteropServices.DispId(-2147412995)]
		public virtual extern string dir { [global::System.Runtime.InteropServices.DispId(-2147412995)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412995)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] set; }

		// Token: 0x06013241 RID: 78401
		[global::System.Runtime.InteropServices.DispId(-2147417056)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)]
		public virtual extern object createControlRange();

		// Token: 0x170065B2 RID: 26034
		// (get) Token: 0x06013242 RID: 78402
		[global::System.Runtime.InteropServices.DispId(-2147417055)]
		public virtual extern int scrollHeight { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147417055)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x170065B3 RID: 26035
		// (get) Token: 0x06013243 RID: 78403
		[global::System.Runtime.InteropServices.DispId(-2147417054)]
		public virtual extern int scrollWidth { [global::System.Runtime.InteropServices.DispId(-2147417054)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x170065B4 RID: 26036
		// (get) Token: 0x06013245 RID: 78405
		// (set) Token: 0x06013244 RID: 78404
		[global::System.Runtime.InteropServices.DispId(-2147417053)]
		public virtual extern int scrollTop { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147417053)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147417053)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] set; }

		// Token: 0x170065B5 RID: 26037
		// (get) Token: 0x06013247 RID: 78407
		// (set) Token: 0x06013246 RID: 78406
		[global::System.Runtime.InteropServices.DispId(-2147417052)]
		public virtual extern int scrollLeft { [global::System.Runtime.InteropServices.DispId(-2147417052)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147417052)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] set; }

		// Token: 0x06013248 RID: 78408
		[global::System.Runtime.InteropServices.DispId(-2147417050)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void clearAttributes();

		// Token: 0x170065B6 RID: 26038
		// (get) Token: 0x0601324A RID: 78410
		// (set) Token: 0x06013249 RID: 78409
		[global::System.Runtime.InteropServices.DispId(-2147412047)]
		public virtual extern object oncontextmenu { [global::System.Runtime.InteropServices.DispId(-2147412047)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147412047)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x0601324B RID: 78411
		[global::System.Runtime.InteropServices.DispId(-2147417043)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		public virtual extern global::mshtml.IHTMLElement insertAdjacentElement([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string where, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLElement insertedElement);

		// Token: 0x0601324C RID: 78412
		[global::System.Runtime.InteropServices.DispId(-2147417047)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		public virtual extern global::mshtml.IHTMLElement applyElement([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLElement apply, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string where);

		// Token: 0x0601324D RID: 78413
		[global::System.Runtime.InteropServices.DispId(-2147417042)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public virtual extern string getAdjacentText([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string where);

		// Token: 0x0601324E RID: 78414
		[global::System.Runtime.InteropServices.DispId(-2147417041)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public virtual extern string replaceAdjacentText([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string where, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string newText);

		// Token: 0x170065B7 RID: 26039
		// (get) Token: 0x0601324F RID: 78415
		[global::System.Runtime.InteropServices.DispId(-2147417040)]
		public virtual extern bool canHaveChildren { [global::System.Runtime.InteropServices.DispId(-2147417040)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x06013250 RID: 78416
		[global::System.Runtime.InteropServices.DispId(-2147417032)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern int addBehavior([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string bstrUrl, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object pvarFactory);

		// Token: 0x06013251 RID: 78417
		[global::System.Runtime.InteropServices.DispId(-2147417031)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern bool removeBehavior([global::System.Runtime.InteropServices.In] int cookie);

		// Token: 0x170065B8 RID: 26040
		// (get) Token: 0x06013252 RID: 78418
		[global::System.Runtime.InteropServices.DispId(-2147417048)]
		public virtual extern global::mshtml.IHTMLStyle runtimeStyle { [global::System.Runtime.InteropServices.TypeLibFunc(1024)] [global::System.Runtime.InteropServices.DispId(-2147417048)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x170065B9 RID: 26041
		// (get) Token: 0x06013253 RID: 78419
		[global::System.Runtime.InteropServices.DispId(-2147417030)]
		public virtual extern object behaviorUrns { [global::System.Runtime.InteropServices.DispId(-2147417030)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] get; }

		// Token: 0x170065BA RID: 26042
		// (get) Token: 0x06013255 RID: 78421
		// (set) Token: 0x06013254 RID: 78420
		[global::System.Runtime.InteropServices.DispId(-2147417029)]
		public virtual extern string tagUrn { [global::System.Runtime.InteropServices.DispId(-2147417029)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(-2147417029)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] set; }

		// Token: 0x170065BB RID: 26043
		// (get) Token: 0x06013257 RID: 78423
		// (set) Token: 0x06013256 RID: 78422
		[global::System.Runtime.InteropServices.DispId(-2147412043)]
		public virtual extern object onbeforeeditfocus { [global::System.Runtime.InteropServices.DispId(-2147412043)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412043)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x170065BC RID: 26044
		// (get) Token: 0x06013258 RID: 78424
		[global::System.Runtime.InteropServices.DispId(-2147417028)]
		public virtual extern int readyStateValue { [global::System.Runtime.InteropServices.DispId(-2147417028)] [global::System.Runtime.InteropServices.TypeLibFunc(65)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x06013259 RID: 78425
		[global::System.Runtime.InteropServices.DispId(-2147417027)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		public virtual extern global::mshtml.IHTMLElementCollection getElementsByTagName([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string v);

		// Token: 0x0601325A RID: 78426
		[global::System.Runtime.InteropServices.DispId(-2147417016)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void mergeAttributes([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLElement mergeThis, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object pvarFlags);

		// Token: 0x170065BD RID: 26045
		// (get) Token: 0x0601325B RID: 78427
		[global::System.Runtime.InteropServices.DispId(-2147417015)]
		public virtual extern bool isMultiLine { [global::System.Runtime.InteropServices.DispId(-2147417015)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x170065BE RID: 26046
		// (get) Token: 0x0601325C RID: 78428
		[global::System.Runtime.InteropServices.DispId(-2147417014)]
		public virtual extern bool canHaveHTML { [global::System.Runtime.InteropServices.DispId(-2147417014)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x170065BF RID: 26047
		// (get) Token: 0x0601325E RID: 78430
		// (set) Token: 0x0601325D RID: 78429
		[global::System.Runtime.InteropServices.DispId(-2147412039)]
		public virtual extern object onlayoutcomplete { [global::System.Runtime.InteropServices.DispId(-2147412039)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412039)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x170065C0 RID: 26048
		// (get) Token: 0x06013260 RID: 78432
		// (set) Token: 0x0601325F RID: 78431
		[global::System.Runtime.InteropServices.DispId(-2147412038)]
		public virtual extern object onpage { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412038)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412038)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x170065C1 RID: 26049
		// (get) Token: 0x06013262 RID: 78434
		// (set) Token: 0x06013261 RID: 78433
		[global::System.Runtime.InteropServices.DispId(-2147417012)]
		public virtual extern bool inflateBlock { [global::System.Runtime.InteropServices.TypeLibFunc(1089)] [global::System.Runtime.InteropServices.DispId(-2147417012)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.TypeLibFunc(1089)] [global::System.Runtime.InteropServices.DispId(-2147417012)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] set; }

		// Token: 0x170065C2 RID: 26050
		// (get) Token: 0x06013264 RID: 78436
		// (set) Token: 0x06013263 RID: 78435
		[global::System.Runtime.InteropServices.DispId(-2147412035)]
		public virtual extern object onbeforedeactivate { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412035)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412035)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x06013265 RID: 78437
		[global::System.Runtime.InteropServices.DispId(-2147417011)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void setActive();

		// Token: 0x170065C3 RID: 26051
		// (get) Token: 0x06013267 RID: 78439
		// (set) Token: 0x06013266 RID: 78438
		[global::System.Runtime.InteropServices.DispId(-2147412950)]
		public virtual extern string contentEditable { [global::System.Runtime.InteropServices.DispId(-2147412950)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(-2147412950)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] set; }

		// Token: 0x170065C4 RID: 26052
		// (get) Token: 0x06013268 RID: 78440
		[global::System.Runtime.InteropServices.DispId(-2147417010)]
		public virtual extern bool isContentEditable { [global::System.Runtime.InteropServices.DispId(-2147417010)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x170065C5 RID: 26053
		// (get) Token: 0x0601326A RID: 78442
		// (set) Token: 0x06013269 RID: 78441
		[global::System.Runtime.InteropServices.DispId(-2147412949)]
		public virtual extern bool hideFocus { [global::System.Runtime.InteropServices.DispId(-2147412949)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(-2147412949)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] set; }

		// Token: 0x170065C6 RID: 26054
		// (get) Token: 0x0601326C RID: 78444
		// (set) Token: 0x0601326B RID: 78443
		[global::System.Runtime.InteropServices.DispId(-2147418036)]
		public virtual extern bool disabled { [global::System.Runtime.InteropServices.DispId(-2147418036)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(-2147418036)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] set; }

		// Token: 0x170065C7 RID: 26055
		// (get) Token: 0x0601326D RID: 78445
		[global::System.Runtime.InteropServices.DispId(-2147417007)]
		public virtual extern bool isDisabled { [global::System.Runtime.InteropServices.DispId(-2147417007)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x170065C8 RID: 26056
		// (get) Token: 0x0601326F RID: 78447
		// (set) Token: 0x0601326E RID: 78446
		[global::System.Runtime.InteropServices.DispId(-2147412034)]
		public virtual extern object onmove { [global::System.Runtime.InteropServices.DispId(-2147412034)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412034)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x170065C9 RID: 26057
		// (get) Token: 0x06013271 RID: 78449
		// (set) Token: 0x06013270 RID: 78448
		[global::System.Runtime.InteropServices.DispId(-2147412033)]
		public virtual extern object oncontrolselect { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412033)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147412033)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x06013272 RID: 78450
		[global::System.Runtime.InteropServices.DispId(-2147417006)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern bool FireEvent([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string bstrEventName, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object pvarEventObject);

		// Token: 0x170065CA RID: 26058
		// (get) Token: 0x06013274 RID: 78452
		// (set) Token: 0x06013273 RID: 78451
		[global::System.Runtime.InteropServices.DispId(-2147412029)]
		public virtual extern object onresizestart { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412029)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412029)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x170065CB RID: 26059
		// (get) Token: 0x06013276 RID: 78454
		// (set) Token: 0x06013275 RID: 78453
		[global::System.Runtime.InteropServices.DispId(-2147412028)]
		public virtual extern object onresizeend { [global::System.Runtime.InteropServices.DispId(-2147412028)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412028)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x170065CC RID: 26060
		// (get) Token: 0x06013278 RID: 78456
		// (set) Token: 0x06013277 RID: 78455
		[global::System.Runtime.InteropServices.DispId(-2147412031)]
		public virtual extern object onmovestart { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412031)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412031)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x170065CD RID: 26061
		// (get) Token: 0x0601327A RID: 78458
		// (set) Token: 0x06013279 RID: 78457
		[global::System.Runtime.InteropServices.DispId(-2147412030)]
		public virtual extern object onmoveend { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412030)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412030)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x170065CE RID: 26062
		// (get) Token: 0x0601327C RID: 78460
		// (set) Token: 0x0601327B RID: 78459
		[global::System.Runtime.InteropServices.DispId(-2147412027)]
		public virtual extern object onmouseenter { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412027)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147412027)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x170065CF RID: 26063
		// (get) Token: 0x0601327E RID: 78462
		// (set) Token: 0x0601327D RID: 78461
		[global::System.Runtime.InteropServices.DispId(-2147412026)]
		public virtual extern object onmouseleave { [global::System.Runtime.InteropServices.DispId(-2147412026)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147412026)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x170065D0 RID: 26064
		// (get) Token: 0x06013280 RID: 78464
		// (set) Token: 0x0601327F RID: 78463
		[global::System.Runtime.InteropServices.DispId(-2147412025)]
		public virtual extern object onactivate { [global::System.Runtime.InteropServices.DispId(-2147412025)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412025)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x170065D1 RID: 26065
		// (get) Token: 0x06013282 RID: 78466
		// (set) Token: 0x06013281 RID: 78465
		[global::System.Runtime.InteropServices.DispId(-2147412024)]
		public virtual extern object ondeactivate { [global::System.Runtime.InteropServices.DispId(-2147412024)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412024)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x06013283 RID: 78467
		[global::System.Runtime.InteropServices.DispId(-2147417005)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern bool dragDrop();

		// Token: 0x170065D2 RID: 26066
		// (get) Token: 0x06013284 RID: 78468
		[global::System.Runtime.InteropServices.DispId(-2147417004)]
		public virtual extern int glyphMode { [global::System.Runtime.InteropServices.TypeLibFunc(1089)] [global::System.Runtime.InteropServices.DispId(-2147417004)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x170065D3 RID: 26067
		// (get) Token: 0x06013286 RID: 78470
		// (set) Token: 0x06013285 RID: 78469
		[global::System.Runtime.InteropServices.DispId(-2147412036)]
		public virtual extern object onmousewheel { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412036)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412036)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x06013287 RID: 78471
		[global::System.Runtime.InteropServices.DispId(-2147417000)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void normalize();

		// Token: 0x06013288 RID: 78472
		[global::System.Runtime.InteropServices.DispId(-2147417003)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		public virtual extern global::mshtml.IHTMLDOMAttribute getAttributeNode([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string bstrName);

		// Token: 0x06013289 RID: 78473
		[global::System.Runtime.InteropServices.DispId(-2147417002)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		public virtual extern global::mshtml.IHTMLDOMAttribute setAttributeNode([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLDOMAttribute pattr);

		// Token: 0x0601328A RID: 78474
		[global::System.Runtime.InteropServices.DispId(-2147417001)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		public virtual extern global::mshtml.IHTMLDOMAttribute removeAttributeNode([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLDOMAttribute pattr);

		// Token: 0x170065D4 RID: 26068
		// (get) Token: 0x0601328C RID: 78476
		// (set) Token: 0x0601328B RID: 78475
		[global::System.Runtime.InteropServices.DispId(-2147412022)]
		public virtual extern object onbeforeactivate { [global::System.Runtime.InteropServices.DispId(-2147412022)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147412022)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x170065D5 RID: 26069
		// (get) Token: 0x0601328E RID: 78478
		// (set) Token: 0x0601328D RID: 78477
		[global::System.Runtime.InteropServices.DispId(-2147412021)]
		public virtual extern object onfocusin { [global::System.Runtime.InteropServices.DispId(-2147412021)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147412021)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x170065D6 RID: 26070
		// (get) Token: 0x06013290 RID: 78480
		// (set) Token: 0x0601328F RID: 78479
		[global::System.Runtime.InteropServices.DispId(-2147412020)]
		public virtual extern object onfocusout { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412020)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147412020)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x170065D7 RID: 26071
		// (get) Token: 0x06013291 RID: 78481
		[global::System.Runtime.InteropServices.DispId(-2147417058)]
		public virtual extern int uniqueNumber { [global::System.Runtime.InteropServices.TypeLibFunc(64)] [global::System.Runtime.InteropServices.DispId(-2147417058)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x170065D8 RID: 26072
		// (get) Token: 0x06013292 RID: 78482
		[global::System.Runtime.InteropServices.DispId(-2147417057)]
		public virtual extern string uniqueID { [global::System.Runtime.InteropServices.DispId(-2147417057)] [global::System.Runtime.InteropServices.TypeLibFunc(64)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x170065D9 RID: 26073
		// (get) Token: 0x06013293 RID: 78483
		[global::System.Runtime.InteropServices.DispId(-2147417066)]
		public virtual extern int nodeType { [global::System.Runtime.InteropServices.DispId(-2147417066)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x170065DA RID: 26074
		// (get) Token: 0x06013294 RID: 78484
		[global::System.Runtime.InteropServices.DispId(-2147417065)]
		public virtual extern global::mshtml.IHTMLDOMNode parentNode { [global::System.Runtime.InteropServices.DispId(-2147417065)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x06013295 RID: 78485
		[global::System.Runtime.InteropServices.DispId(-2147417064)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern bool hasChildNodes();

		// Token: 0x170065DB RID: 26075
		// (get) Token: 0x06013296 RID: 78486
		[global::System.Runtime.InteropServices.DispId(-2147417063)]
		public virtual extern object childNodes { [global::System.Runtime.InteropServices.DispId(-2147417063)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] get; }

		// Token: 0x170065DC RID: 26076
		// (get) Token: 0x06013297 RID: 78487
		[global::System.Runtime.InteropServices.DispId(-2147417062)]
		public virtual extern object attributes { [global::System.Runtime.InteropServices.DispId(-2147417062)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] get; }

		// Token: 0x06013298 RID: 78488
		[global::System.Runtime.InteropServices.DispId(-2147417061)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		public virtual extern global::mshtml.IHTMLDOMNode insertBefore([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLDOMNode newChild, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] object refChild);

		// Token: 0x06013299 RID: 78489
		[global::System.Runtime.InteropServices.DispId(-2147417060)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		public virtual extern global::mshtml.IHTMLDOMNode removeChild([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLDOMNode oldChild);

		// Token: 0x0601329A RID: 78490
		[global::System.Runtime.InteropServices.DispId(-2147417059)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		public virtual extern global::mshtml.IHTMLDOMNode replaceChild([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLDOMNode newChild, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLDOMNode oldChild);

		// Token: 0x0601329B RID: 78491
		[global::System.Runtime.InteropServices.DispId(-2147417051)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		public virtual extern global::mshtml.IHTMLDOMNode cloneNode([global::System.Runtime.InteropServices.In] bool fDeep);

		// Token: 0x0601329C RID: 78492
		[global::System.Runtime.InteropServices.DispId(-2147417046)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		public virtual extern global::mshtml.IHTMLDOMNode removeNode([global::System.Runtime.InteropServices.In] bool fDeep = false);

		// Token: 0x0601329D RID: 78493
		[global::System.Runtime.InteropServices.DispId(-2147417044)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		public virtual extern global::mshtml.IHTMLDOMNode swapNode([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLDOMNode otherNode);

		// Token: 0x0601329E RID: 78494
		[global::System.Runtime.InteropServices.DispId(-2147417045)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		public virtual extern global::mshtml.IHTMLDOMNode replaceNode([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLDOMNode replacement);

		// Token: 0x0601329F RID: 78495
		[global::System.Runtime.InteropServices.DispId(-2147417039)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		public virtual extern global::mshtml.IHTMLDOMNode appendChild([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLDOMNode newChild);

		// Token: 0x170065DD RID: 26077
		// (get) Token: 0x060132A0 RID: 78496
		[global::System.Runtime.InteropServices.DispId(-2147417038)]
		public virtual extern string nodeName { [global::System.Runtime.InteropServices.DispId(-2147417038)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x170065DE RID: 26078
		// (get) Token: 0x060132A2 RID: 78498
		// (set) Token: 0x060132A1 RID: 78497
		[global::System.Runtime.InteropServices.DispId(-2147417037)]
		public virtual extern object nodeValue { [global::System.Runtime.InteropServices.DispId(-2147417037)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147417037)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x170065DF RID: 26079
		// (get) Token: 0x060132A3 RID: 78499
		[global::System.Runtime.InteropServices.DispId(-2147417036)]
		public virtual extern global::mshtml.IHTMLDOMNode firstChild { [global::System.Runtime.InteropServices.DispId(-2147417036)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x170065E0 RID: 26080
		// (get) Token: 0x060132A4 RID: 78500
		[global::System.Runtime.InteropServices.DispId(-2147417035)]
		public virtual extern global::mshtml.IHTMLDOMNode lastChild { [global::System.Runtime.InteropServices.DispId(-2147417035)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x170065E1 RID: 26081
		// (get) Token: 0x060132A5 RID: 78501
		[global::System.Runtime.InteropServices.DispId(-2147417034)]
		public virtual extern global::mshtml.IHTMLDOMNode previousSibling { [global::System.Runtime.InteropServices.DispId(-2147417034)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x170065E2 RID: 26082
		// (get) Token: 0x060132A6 RID: 78502
		[global::System.Runtime.InteropServices.DispId(-2147417033)]
		public virtual extern global::mshtml.IHTMLDOMNode nextSibling { [global::System.Runtime.InteropServices.DispId(-2147417033)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x170065E3 RID: 26083
		// (get) Token: 0x060132A7 RID: 78503
		[global::System.Runtime.InteropServices.DispId(-2147416999)]
		public virtual extern object ownerDocument { [global::System.Runtime.InteropServices.DispId(-2147416999)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] get; }

		// Token: 0x170065E4 RID: 26084
		// (get) Token: 0x060132A9 RID: 78505
		// (set) Token: 0x060132A8 RID: 78504
		[global::System.Runtime.InteropServices.DispId(-2147415112)]
		public virtual extern string src { [global::System.Runtime.InteropServices.DispId(-2147415112)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(-2147415112)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] set; }

		// Token: 0x170065E5 RID: 26085
		// (get) Token: 0x060132AB RID: 78507
		// (set) Token: 0x060132AA RID: 78506
		[global::System.Runtime.InteropServices.DispId(-2147418112)]
		public virtual extern string name { [global::System.Runtime.InteropServices.DispId(-2147418112)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(-2147418112)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] set; }

		// Token: 0x170065E6 RID: 26086
		// (get) Token: 0x060132AD RID: 78509
		// (set) Token: 0x060132AC RID: 78508
		[global::System.Runtime.InteropServices.DispId(-2147415110)]
		public virtual extern object border { [global::System.Runtime.InteropServices.DispId(-2147415110)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147415110)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x170065E7 RID: 26087
		// (get) Token: 0x060132AF RID: 78511
		// (set) Token: 0x060132AE RID: 78510
		[global::System.Runtime.InteropServices.DispId(-2147415109)]
		public virtual extern string frameBorder { [global::System.Runtime.InteropServices.DispId(-2147415109)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(-2147415109)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] set; }

		// Token: 0x170065E8 RID: 26088
		// (get) Token: 0x060132B1 RID: 78513
		// (set) Token: 0x060132B0 RID: 78512
		[global::System.Runtime.InteropServices.DispId(-2147415108)]
		public virtual extern object frameSpacing { [global::System.Runtime.InteropServices.DispId(-2147415108)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147415108)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x170065E9 RID: 26089
		// (get) Token: 0x060132B3 RID: 78515
		// (set) Token: 0x060132B2 RID: 78514
		[global::System.Runtime.InteropServices.DispId(-2147415107)]
		public virtual extern object marginWidth { [global::System.Runtime.InteropServices.DispId(-2147415107)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147415107)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x170065EA RID: 26090
		// (get) Token: 0x060132B5 RID: 78517
		// (set) Token: 0x060132B4 RID: 78516
		[global::System.Runtime.InteropServices.DispId(-2147415106)]
		public virtual extern object marginHeight { [global::System.Runtime.InteropServices.DispId(-2147415106)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147415106)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x170065EB RID: 26091
		// (get) Token: 0x060132B7 RID: 78519
		// (set) Token: 0x060132B6 RID: 78518
		[global::System.Runtime.InteropServices.DispId(-2147415105)]
		public virtual extern bool noResize { [global::System.Runtime.InteropServices.DispId(-2147415105)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(-2147415105)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] set; }

		// Token: 0x170065EC RID: 26092
		// (get) Token: 0x060132B9 RID: 78521
		// (set) Token: 0x060132B8 RID: 78520
		[global::System.Runtime.InteropServices.DispId(-2147415104)]
		public virtual extern string scrolling { [global::System.Runtime.InteropServices.DispId(-2147415104)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(-2147415104)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] set; }

		// Token: 0x170065ED RID: 26093
		// (get) Token: 0x060132BA RID: 78522
		[global::System.Runtime.InteropServices.DispId(-2147415103)]
		public virtual extern global::mshtml.IHTMLWindow2 contentWindow { [global::System.Runtime.InteropServices.DispId(-2147415103)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x170065EE RID: 26094
		// (get) Token: 0x060132BC RID: 78524
		// (set) Token: 0x060132BB RID: 78523
		[global::System.Runtime.InteropServices.DispId(-2147412080)]
		public virtual extern object onload { [global::System.Runtime.InteropServices.DispId(-2147412080)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412080)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x170065EF RID: 26095
		// (get) Token: 0x060132BE RID: 78526
		// (set) Token: 0x060132BD RID: 78525
		[global::System.Runtime.InteropServices.DispId(-2147412906)]
		public virtual extern bool allowTransparency { [global::System.Runtime.InteropServices.DispId(-2147412906)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(-2147412906)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] set; }

		// Token: 0x170065F0 RID: 26096
		// (get) Token: 0x060132C0 RID: 78528
		// (set) Token: 0x060132BF RID: 78527
		[global::System.Runtime.InteropServices.DispId(-2147415102)]
		public virtual extern string longDesc { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147415102)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(-2147415102)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] set; }

		// Token: 0x060132C1 RID: 78529
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void IHTMLElement_setAttribute([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string strAttributeName, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] object AttributeValue, [global::System.Runtime.InteropServices.In] int lFlags = 1);

		// Token: 0x060132C2 RID: 78530
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)]
		public virtual extern object IHTMLElement_getAttribute([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string strAttributeName, [global::System.Runtime.InteropServices.In] int lFlags = 0);

		// Token: 0x060132C3 RID: 78531
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern bool IHTMLElement_removeAttribute([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string strAttributeName, [global::System.Runtime.InteropServices.In] int lFlags = 1);

		// Token: 0x170065F1 RID: 26097
		// (get) Token: 0x060132C5 RID: 78533
		// (set) Token: 0x060132C4 RID: 78532
		public virtual extern string IHTMLElement_className { [global::System.Runtime.InteropServices.TypeLibFunc(4)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.TypeLibFunc(4)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170065F2 RID: 26098
		// (get) Token: 0x060132C7 RID: 78535
		// (set) Token: 0x060132C6 RID: 78534
		public virtual extern string IHTMLElement_id { [global::System.Runtime.InteropServices.TypeLibFunc(4)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.TypeLibFunc(4)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170065F3 RID: 26099
		// (get) Token: 0x060132C8 RID: 78536
		public virtual extern string IHTMLElement_tagName { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x170065F4 RID: 26100
		// (get) Token: 0x060132C9 RID: 78537
		public virtual extern global::mshtml.IHTMLElement IHTMLElement_parentElement { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x170065F5 RID: 26101
		// (get) Token: 0x060132CA RID: 78538
		public virtual extern global::mshtml.IHTMLStyle IHTMLElement_style { [global::System.Runtime.InteropServices.TypeLibFunc(1024)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x170065F6 RID: 26102
		// (get) Token: 0x060132CC RID: 78540
		// (set) Token: 0x060132CB RID: 78539
		public virtual extern object IHTMLElement_onhelp { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170065F7 RID: 26103
		// (get) Token: 0x060132CE RID: 78542
		// (set) Token: 0x060132CD RID: 78541
		public virtual extern object IHTMLElement_onclick { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170065F8 RID: 26104
		// (get) Token: 0x060132D0 RID: 78544
		// (set) Token: 0x060132CF RID: 78543
		public virtual extern object IHTMLElement_ondblclick { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170065F9 RID: 26105
		// (get) Token: 0x060132D2 RID: 78546
		// (set) Token: 0x060132D1 RID: 78545
		public virtual extern object IHTMLElement_onkeydown { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170065FA RID: 26106
		// (get) Token: 0x060132D4 RID: 78548
		// (set) Token: 0x060132D3 RID: 78547
		public virtual extern object IHTMLElement_onkeyup { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170065FB RID: 26107
		// (get) Token: 0x060132D6 RID: 78550
		// (set) Token: 0x060132D5 RID: 78549
		public virtual extern object IHTMLElement_onkeypress { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170065FC RID: 26108
		// (get) Token: 0x060132D8 RID: 78552
		// (set) Token: 0x060132D7 RID: 78551
		public virtual extern object IHTMLElement_onmouseout { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170065FD RID: 26109
		// (get) Token: 0x060132DA RID: 78554
		// (set) Token: 0x060132D9 RID: 78553
		public virtual extern object IHTMLElement_onmouseover { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170065FE RID: 26110
		// (get) Token: 0x060132DC RID: 78556
		// (set) Token: 0x060132DB RID: 78555
		public virtual extern object IHTMLElement_onmousemove { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170065FF RID: 26111
		// (get) Token: 0x060132DE RID: 78558
		// (set) Token: 0x060132DD RID: 78557
		public virtual extern object IHTMLElement_onmousedown { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17006600 RID: 26112
		// (get) Token: 0x060132E0 RID: 78560
		// (set) Token: 0x060132DF RID: 78559
		public virtual extern object IHTMLElement_onmouseup { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17006601 RID: 26113
		// (get) Token: 0x060132E1 RID: 78561
		public virtual extern object IHTMLElement_document { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] get; }

		// Token: 0x17006602 RID: 26114
		// (get) Token: 0x060132E3 RID: 78563
		// (set) Token: 0x060132E2 RID: 78562
		public virtual extern string IHTMLElement_title { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17006603 RID: 26115
		// (get) Token: 0x060132E5 RID: 78565
		// (set) Token: 0x060132E4 RID: 78564
		public virtual extern string IHTMLElement_language { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17006604 RID: 26116
		// (get) Token: 0x060132E7 RID: 78567
		// (set) Token: 0x060132E6 RID: 78566
		public virtual extern object IHTMLElement_onselectstart { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x060132E8 RID: 78568
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void IHTMLElement_scrollIntoView([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] object varargStart);

		// Token: 0x060132E9 RID: 78569
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern bool IHTMLElement_contains([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLElement pChild);

		// Token: 0x17006605 RID: 26117
		// (get) Token: 0x060132EA RID: 78570
		public virtual extern int IHTMLElement_sourceIndex { [global::System.Runtime.InteropServices.TypeLibFunc(4)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x17006606 RID: 26118
		// (get) Token: 0x060132EB RID: 78571
		public virtual extern object IHTMLElement_recordNumber { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; }

		// Token: 0x17006607 RID: 26119
		// (get) Token: 0x060132ED RID: 78573
		// (set) Token: 0x060132EC RID: 78572
		public virtual extern string IHTMLElement_lang { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17006608 RID: 26120
		// (get) Token: 0x060132EE RID: 78574
		public virtual extern int IHTMLElement_offsetLeft { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x17006609 RID: 26121
		// (get) Token: 0x060132EF RID: 78575
		public virtual extern int IHTMLElement_offsetTop { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700660A RID: 26122
		// (get) Token: 0x060132F0 RID: 78576
		public virtual extern int IHTMLElement_offsetWidth { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700660B RID: 26123
		// (get) Token: 0x060132F1 RID: 78577
		public virtual extern int IHTMLElement_offsetHeight { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700660C RID: 26124
		// (get) Token: 0x060132F2 RID: 78578
		public virtual extern global::mshtml.IHTMLElement IHTMLElement_offsetParent { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x1700660D RID: 26125
		// (get) Token: 0x060132F4 RID: 78580
		// (set) Token: 0x060132F3 RID: 78579
		public virtual extern string IHTMLElement_innerHTML { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700660E RID: 26126
		// (get) Token: 0x060132F6 RID: 78582
		// (set) Token: 0x060132F5 RID: 78581
		public virtual extern string IHTMLElement_innerText { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700660F RID: 26127
		// (get) Token: 0x060132F8 RID: 78584
		// (set) Token: 0x060132F7 RID: 78583
		public virtual extern string IHTMLElement_outerHTML { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17006610 RID: 26128
		// (get) Token: 0x060132FA RID: 78586
		// (set) Token: 0x060132F9 RID: 78585
		public virtual extern string IHTMLElement_outerText { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x060132FB RID: 78587
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void IHTMLElement_insertAdjacentHTML([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string where, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string html);

		// Token: 0x060132FC RID: 78588
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void IHTMLElement_insertAdjacentText([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string where, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string text);

		// Token: 0x17006611 RID: 26129
		// (get) Token: 0x060132FD RID: 78589
		public virtual extern global::mshtml.IHTMLElement IHTMLElement_parentTextEdit { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x17006612 RID: 26130
		// (get) Token: 0x060132FE RID: 78590
		public virtual extern bool IHTMLElement_isTextEdit { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x060132FF RID: 78591
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void IHTMLElement_click();

		// Token: 0x17006613 RID: 26131
		// (get) Token: 0x06013300 RID: 78592
		public virtual extern global::mshtml.IHTMLFiltersCollection IHTMLElement_filters { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x17006614 RID: 26132
		// (get) Token: 0x06013302 RID: 78594
		// (set) Token: 0x06013301 RID: 78593
		public virtual extern object IHTMLElement_ondragstart { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x06013303 RID: 78595
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public virtual extern string IHTMLElement_toString();

		// Token: 0x17006615 RID: 26133
		// (get) Token: 0x06013305 RID: 78597
		// (set) Token: 0x06013304 RID: 78596
		public virtual extern object IHTMLElement_onbeforeupdate { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17006616 RID: 26134
		// (get) Token: 0x06013307 RID: 78599
		// (set) Token: 0x06013306 RID: 78598
		public virtual extern object IHTMLElement_onafterupdate { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17006617 RID: 26135
		// (get) Token: 0x06013309 RID: 78601
		// (set) Token: 0x06013308 RID: 78600
		public virtual extern object IHTMLElement_onerrorupdate { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17006618 RID: 26136
		// (get) Token: 0x0601330B RID: 78603
		// (set) Token: 0x0601330A RID: 78602
		public virtual extern object IHTMLElement_onrowexit { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17006619 RID: 26137
		// (get) Token: 0x0601330D RID: 78605
		// (set) Token: 0x0601330C RID: 78604
		public virtual extern object IHTMLElement_onrowenter { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700661A RID: 26138
		// (get) Token: 0x0601330F RID: 78607
		// (set) Token: 0x0601330E RID: 78606
		public virtual extern object IHTMLElement_ondatasetchanged { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700661B RID: 26139
		// (get) Token: 0x06013311 RID: 78609
		// (set) Token: 0x06013310 RID: 78608
		public virtual extern object IHTMLElement_ondataavailable { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700661C RID: 26140
		// (get) Token: 0x06013313 RID: 78611
		// (set) Token: 0x06013312 RID: 78610
		public virtual extern object IHTMLElement_ondatasetcomplete { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700661D RID: 26141
		// (get) Token: 0x06013315 RID: 78613
		// (set) Token: 0x06013314 RID: 78612
		public virtual extern object IHTMLElement_onfilterchange { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700661E RID: 26142
		// (get) Token: 0x06013316 RID: 78614
		public virtual extern object IHTMLElement_children { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] get; }

		// Token: 0x1700661F RID: 26143
		// (get) Token: 0x06013317 RID: 78615
		public virtual extern object IHTMLElement_all { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] get; }

		// Token: 0x17006620 RID: 26144
		// (get) Token: 0x06013318 RID: 78616
		public virtual extern string IHTMLElement2_scopeName { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x06013319 RID: 78617
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void IHTMLElement2_setCapture([global::System.Runtime.InteropServices.In] bool containerCapture = true);

		// Token: 0x0601331A RID: 78618
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void IHTMLElement2_releaseCapture();

		// Token: 0x17006621 RID: 26145
		// (get) Token: 0x0601331C RID: 78620
		// (set) Token: 0x0601331B RID: 78619
		public virtual extern object IHTMLElement2_onlosecapture { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x0601331D RID: 78621
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public virtual extern string IHTMLElement2_componentFromPoint([global::System.Runtime.InteropServices.In] int x, [global::System.Runtime.InteropServices.In] int y);

		// Token: 0x0601331E RID: 78622
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void IHTMLElement2_doScroll([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] object component);

		// Token: 0x17006622 RID: 26146
		// (get) Token: 0x06013320 RID: 78624
		// (set) Token: 0x0601331F RID: 78623
		public virtual extern object IHTMLElement2_onscroll { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17006623 RID: 26147
		// (get) Token: 0x06013322 RID: 78626
		// (set) Token: 0x06013321 RID: 78625
		public virtual extern object IHTMLElement2_ondrag { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17006624 RID: 26148
		// (get) Token: 0x06013324 RID: 78628
		// (set) Token: 0x06013323 RID: 78627
		public virtual extern object IHTMLElement2_ondragend { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17006625 RID: 26149
		// (get) Token: 0x06013326 RID: 78630
		// (set) Token: 0x06013325 RID: 78629
		public virtual extern object IHTMLElement2_ondragenter { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17006626 RID: 26150
		// (get) Token: 0x06013328 RID: 78632
		// (set) Token: 0x06013327 RID: 78631
		public virtual extern object IHTMLElement2_ondragover { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17006627 RID: 26151
		// (get) Token: 0x0601332A RID: 78634
		// (set) Token: 0x06013329 RID: 78633
		public virtual extern object IHTMLElement2_ondragleave { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17006628 RID: 26152
		// (get) Token: 0x0601332C RID: 78636
		// (set) Token: 0x0601332B RID: 78635
		public virtual extern object IHTMLElement2_ondrop { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17006629 RID: 26153
		// (get) Token: 0x0601332E RID: 78638
		// (set) Token: 0x0601332D RID: 78637
		public virtual extern object IHTMLElement2_onbeforecut { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700662A RID: 26154
		// (get) Token: 0x06013330 RID: 78640
		// (set) Token: 0x0601332F RID: 78639
		public virtual extern object IHTMLElement2_oncut { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700662B RID: 26155
		// (get) Token: 0x06013332 RID: 78642
		// (set) Token: 0x06013331 RID: 78641
		public virtual extern object IHTMLElement2_onbeforecopy { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700662C RID: 26156
		// (get) Token: 0x06013334 RID: 78644
		// (set) Token: 0x06013333 RID: 78643
		public virtual extern object IHTMLElement2_oncopy { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700662D RID: 26157
		// (get) Token: 0x06013336 RID: 78646
		// (set) Token: 0x06013335 RID: 78645
		public virtual extern object IHTMLElement2_onbeforepaste { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700662E RID: 26158
		// (get) Token: 0x06013338 RID: 78648
		// (set) Token: 0x06013337 RID: 78647
		public virtual extern object IHTMLElement2_onpaste { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700662F RID: 26159
		// (get) Token: 0x06013339 RID: 78649
		public virtual extern global::mshtml.IHTMLCurrentStyle IHTMLElement2_currentStyle { [global::System.Runtime.InteropServices.TypeLibFunc(1024)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x17006630 RID: 26160
		// (get) Token: 0x0601333B RID: 78651
		// (set) Token: 0x0601333A RID: 78650
		public virtual extern object IHTMLElement2_onpropertychange { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x0601333C RID: 78652
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		public virtual extern global::mshtml.IHTMLRectCollection IHTMLElement2_getClientRects();

		// Token: 0x0601333D RID: 78653
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		public virtual extern global::mshtml.IHTMLRect IHTMLElement2_getBoundingClientRect();

		// Token: 0x0601333E RID: 78654
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void IHTMLElement2_setExpression([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string propname, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string expression, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string language = "");

		// Token: 0x0601333F RID: 78655
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)]
		public virtual extern object IHTMLElement2_getExpression([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string propname);

		// Token: 0x06013340 RID: 78656
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern bool IHTMLElement2_removeExpression([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string propname);

		// Token: 0x17006631 RID: 26161
		// (get) Token: 0x06013342 RID: 78658
		// (set) Token: 0x06013341 RID: 78657
		public virtual extern short IHTMLElement2_tabIndex { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x06013343 RID: 78659
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void IHTMLElement2_focus();

		// Token: 0x17006632 RID: 26162
		// (get) Token: 0x06013345 RID: 78661
		// (set) Token: 0x06013344 RID: 78660
		public virtual extern string IHTMLElement2_accessKey { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17006633 RID: 26163
		// (get) Token: 0x06013347 RID: 78663
		// (set) Token: 0x06013346 RID: 78662
		public virtual extern object IHTMLElement2_onblur { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17006634 RID: 26164
		// (get) Token: 0x06013349 RID: 78665
		// (set) Token: 0x06013348 RID: 78664
		public virtual extern object IHTMLElement2_onfocus { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17006635 RID: 26165
		// (get) Token: 0x0601334B RID: 78667
		// (set) Token: 0x0601334A RID: 78666
		public virtual extern object IHTMLElement2_onresize { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x0601334C RID: 78668
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void IHTMLElement2_blur();

		// Token: 0x0601334D RID: 78669
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void IHTMLElement2_addFilter([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IUnknown)] [global::System.Runtime.InteropServices.In] object pUnk);

		// Token: 0x0601334E RID: 78670
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void IHTMLElement2_removeFilter([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IUnknown)] [global::System.Runtime.InteropServices.In] object pUnk);

		// Token: 0x17006636 RID: 26166
		// (get) Token: 0x0601334F RID: 78671
		public virtual extern int IHTMLElement2_clientHeight { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x17006637 RID: 26167
		// (get) Token: 0x06013350 RID: 78672
		public virtual extern int IHTMLElement2_clientWidth { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x17006638 RID: 26168
		// (get) Token: 0x06013351 RID: 78673
		public virtual extern int IHTMLElement2_clientTop { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x17006639 RID: 26169
		// (get) Token: 0x06013352 RID: 78674
		public virtual extern int IHTMLElement2_clientLeft { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x06013353 RID: 78675
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern bool IHTMLElement2_attachEvent([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string @event, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] [global::System.Runtime.InteropServices.In] object pdisp);

		// Token: 0x06013354 RID: 78676
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void IHTMLElement2_detachEvent([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string @event, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] [global::System.Runtime.InteropServices.In] object pdisp);

		// Token: 0x1700663A RID: 26170
		// (get) Token: 0x06013355 RID: 78677
		public virtual extern object IHTMLElement2_readyState { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; }

		// Token: 0x1700663B RID: 26171
		// (get) Token: 0x06013357 RID: 78679
		// (set) Token: 0x06013356 RID: 78678
		public virtual extern object IHTMLElement2_onreadystatechange { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700663C RID: 26172
		// (get) Token: 0x06013359 RID: 78681
		// (set) Token: 0x06013358 RID: 78680
		public virtual extern object IHTMLElement2_onrowsdelete { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700663D RID: 26173
		// (get) Token: 0x0601335B RID: 78683
		// (set) Token: 0x0601335A RID: 78682
		public virtual extern object IHTMLElement2_onrowsinserted { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700663E RID: 26174
		// (get) Token: 0x0601335D RID: 78685
		// (set) Token: 0x0601335C RID: 78684
		public virtual extern object IHTMLElement2_oncellchange { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700663F RID: 26175
		// (get) Token: 0x0601335F RID: 78687
		// (set) Token: 0x0601335E RID: 78686
		public virtual extern string IHTMLElement2_dir { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x06013360 RID: 78688
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)]
		public virtual extern object IHTMLElement2_createControlRange();

		// Token: 0x17006640 RID: 26176
		// (get) Token: 0x06013361 RID: 78689
		public virtual extern int IHTMLElement2_scrollHeight { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x17006641 RID: 26177
		// (get) Token: 0x06013362 RID: 78690
		public virtual extern int IHTMLElement2_scrollWidth { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x17006642 RID: 26178
		// (get) Token: 0x06013364 RID: 78692
		// (set) Token: 0x06013363 RID: 78691
		public virtual extern int IHTMLElement2_scrollTop { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17006643 RID: 26179
		// (get) Token: 0x06013366 RID: 78694
		// (set) Token: 0x06013365 RID: 78693
		public virtual extern int IHTMLElement2_scrollLeft { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x06013367 RID: 78695
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void IHTMLElement2_clearAttributes();

		// Token: 0x06013368 RID: 78696
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void mergeAttributes([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLElement mergeThis);

		// Token: 0x17006644 RID: 26180
		// (get) Token: 0x0601336A RID: 78698
		// (set) Token: 0x06013369 RID: 78697
		public virtual extern object IHTMLElement2_oncontextmenu { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x0601336B RID: 78699
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		public virtual extern global::mshtml.IHTMLElement IHTMLElement2_insertAdjacentElement([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string where, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLElement insertedElement);

		// Token: 0x0601336C RID: 78700
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		public virtual extern global::mshtml.IHTMLElement IHTMLElement2_applyElement([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLElement apply, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string where);

		// Token: 0x0601336D RID: 78701
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public virtual extern string IHTMLElement2_getAdjacentText([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string where);

		// Token: 0x0601336E RID: 78702
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public virtual extern string IHTMLElement2_replaceAdjacentText([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string where, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string newText);

		// Token: 0x17006645 RID: 26181
		// (get) Token: 0x0601336F RID: 78703
		public virtual extern bool IHTMLElement2_canHaveChildren { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x06013370 RID: 78704
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern int IHTMLElement2_addBehavior([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string bstrUrl, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object pvarFactory);

		// Token: 0x06013371 RID: 78705
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern bool IHTMLElement2_removeBehavior([global::System.Runtime.InteropServices.In] int cookie);

		// Token: 0x17006646 RID: 26182
		// (get) Token: 0x06013372 RID: 78706
		public virtual extern global::mshtml.IHTMLStyle IHTMLElement2_runtimeStyle { [global::System.Runtime.InteropServices.TypeLibFunc(1024)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x17006647 RID: 26183
		// (get) Token: 0x06013373 RID: 78707
		public virtual extern object IHTMLElement2_behaviorUrns { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] get; }

		// Token: 0x17006648 RID: 26184
		// (get) Token: 0x06013375 RID: 78709
		// (set) Token: 0x06013374 RID: 78708
		public virtual extern string IHTMLElement2_tagUrn { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17006649 RID: 26185
		// (get) Token: 0x06013377 RID: 78711
		// (set) Token: 0x06013376 RID: 78710
		public virtual extern object IHTMLElement2_onbeforeeditfocus { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700664A RID: 26186
		// (get) Token: 0x06013378 RID: 78712
		public virtual extern int IHTMLElement2_readyStateValue { [global::System.Runtime.InteropServices.TypeLibFunc(65)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x06013379 RID: 78713
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		public virtual extern global::mshtml.IHTMLElementCollection IHTMLElement2_getElementsByTagName([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string v);

		// Token: 0x0601337A RID: 78714
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void mergeAttributes([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLElement mergeThis, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object pvarFlags);

		// Token: 0x1700664B RID: 26187
		// (get) Token: 0x0601337B RID: 78715
		public virtual extern bool IHTMLElement3_isMultiLine { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700664C RID: 26188
		// (get) Token: 0x0601337C RID: 78716
		public virtual extern bool IHTMLElement3_canHaveHTML { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700664D RID: 26189
		// (get) Token: 0x0601337E RID: 78718
		// (set) Token: 0x0601337D RID: 78717
		public virtual extern object IHTMLElement3_onlayoutcomplete { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700664E RID: 26190
		// (get) Token: 0x06013380 RID: 78720
		// (set) Token: 0x0601337F RID: 78719
		public virtual extern object IHTMLElement3_onpage { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700664F RID: 26191
		// (get) Token: 0x06013382 RID: 78722
		// (set) Token: 0x06013381 RID: 78721
		public virtual extern bool IHTMLElement3_inflateBlock { [global::System.Runtime.InteropServices.TypeLibFunc(1089)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.TypeLibFunc(1089)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17006650 RID: 26192
		// (get) Token: 0x06013384 RID: 78724
		// (set) Token: 0x06013383 RID: 78723
		public virtual extern object IHTMLElement3_onbeforedeactivate { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x06013385 RID: 78725
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void IHTMLElement3_setActive();

		// Token: 0x17006651 RID: 26193
		// (get) Token: 0x06013387 RID: 78727
		// (set) Token: 0x06013386 RID: 78726
		public virtual extern string IHTMLElement3_contentEditable { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17006652 RID: 26194
		// (get) Token: 0x06013388 RID: 78728
		public virtual extern bool IHTMLElement3_isContentEditable { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x17006653 RID: 26195
		// (get) Token: 0x0601338A RID: 78730
		// (set) Token: 0x06013389 RID: 78729
		public virtual extern bool IHTMLElement3_hideFocus { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17006654 RID: 26196
		// (get) Token: 0x0601338C RID: 78732
		// (set) Token: 0x0601338B RID: 78731
		public virtual extern bool IHTMLElement3_disabled { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17006655 RID: 26197
		// (get) Token: 0x0601338D RID: 78733
		public virtual extern bool IHTMLElement3_isDisabled { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x17006656 RID: 26198
		// (get) Token: 0x0601338F RID: 78735
		// (set) Token: 0x0601338E RID: 78734
		public virtual extern object IHTMLElement3_onmove { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17006657 RID: 26199
		// (get) Token: 0x06013391 RID: 78737
		// (set) Token: 0x06013390 RID: 78736
		public virtual extern object IHTMLElement3_oncontrolselect { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x06013392 RID: 78738
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern bool IHTMLElement3_FireEvent([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string bstrEventName, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object pvarEventObject);

		// Token: 0x17006658 RID: 26200
		// (get) Token: 0x06013394 RID: 78740
		// (set) Token: 0x06013393 RID: 78739
		public virtual extern object IHTMLElement3_onresizestart { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17006659 RID: 26201
		// (get) Token: 0x06013396 RID: 78742
		// (set) Token: 0x06013395 RID: 78741
		public virtual extern object IHTMLElement3_onresizeend { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700665A RID: 26202
		// (get) Token: 0x06013398 RID: 78744
		// (set) Token: 0x06013397 RID: 78743
		public virtual extern object IHTMLElement3_onmovestart { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700665B RID: 26203
		// (get) Token: 0x0601339A RID: 78746
		// (set) Token: 0x06013399 RID: 78745
		public virtual extern object IHTMLElement3_onmoveend { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700665C RID: 26204
		// (get) Token: 0x0601339C RID: 78748
		// (set) Token: 0x0601339B RID: 78747
		public virtual extern object IHTMLElement3_onmouseenter { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700665D RID: 26205
		// (get) Token: 0x0601339E RID: 78750
		// (set) Token: 0x0601339D RID: 78749
		public virtual extern object IHTMLElement3_onmouseleave { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700665E RID: 26206
		// (get) Token: 0x060133A0 RID: 78752
		// (set) Token: 0x0601339F RID: 78751
		public virtual extern object IHTMLElement3_onactivate { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700665F RID: 26207
		// (get) Token: 0x060133A2 RID: 78754
		// (set) Token: 0x060133A1 RID: 78753
		public virtual extern object IHTMLElement3_ondeactivate { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x060133A3 RID: 78755
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern bool IHTMLElement3_dragDrop();

		// Token: 0x17006660 RID: 26208
		// (get) Token: 0x060133A4 RID: 78756
		public virtual extern int IHTMLElement3_glyphMode { [global::System.Runtime.InteropServices.TypeLibFunc(1089)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x17006661 RID: 26209
		// (get) Token: 0x060133A6 RID: 78758
		// (set) Token: 0x060133A5 RID: 78757
		public virtual extern object IHTMLElement4_onmousewheel { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x060133A7 RID: 78759
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void IHTMLElement4_normalize();

		// Token: 0x060133A8 RID: 78760
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		public virtual extern global::mshtml.IHTMLDOMAttribute IHTMLElement4_getAttributeNode([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string bstrName);

		// Token: 0x060133A9 RID: 78761
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		public virtual extern global::mshtml.IHTMLDOMAttribute IHTMLElement4_setAttributeNode([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLDOMAttribute pattr);

		// Token: 0x060133AA RID: 78762
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		public virtual extern global::mshtml.IHTMLDOMAttribute IHTMLElement4_removeAttributeNode([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLDOMAttribute pattr);

		// Token: 0x17006662 RID: 26210
		// (get) Token: 0x060133AC RID: 78764
		// (set) Token: 0x060133AB RID: 78763
		public virtual extern object IHTMLElement4_onbeforeactivate { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17006663 RID: 26211
		// (get) Token: 0x060133AE RID: 78766
		// (set) Token: 0x060133AD RID: 78765
		public virtual extern object IHTMLElement4_onfocusin { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17006664 RID: 26212
		// (get) Token: 0x060133B0 RID: 78768
		// (set) Token: 0x060133AF RID: 78767
		public virtual extern object IHTMLElement4_onfocusout { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17006665 RID: 26213
		// (get) Token: 0x060133B1 RID: 78769
		public virtual extern int IHTMLUniqueName_uniqueNumber { [global::System.Runtime.InteropServices.TypeLibFunc(64)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x17006666 RID: 26214
		// (get) Token: 0x060133B2 RID: 78770
		public virtual extern string IHTMLUniqueName_uniqueID { [global::System.Runtime.InteropServices.TypeLibFunc(64)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x17006667 RID: 26215
		// (get) Token: 0x060133B3 RID: 78771
		public virtual extern int IHTMLDOMNode_nodeType { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x17006668 RID: 26216
		// (get) Token: 0x060133B4 RID: 78772
		public virtual extern global::mshtml.IHTMLDOMNode IHTMLDOMNode_parentNode { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x060133B5 RID: 78773
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern bool IHTMLDOMNode_hasChildNodes();

		// Token: 0x17006669 RID: 26217
		// (get) Token: 0x060133B6 RID: 78774
		public virtual extern object IHTMLDOMNode_childNodes { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] get; }

		// Token: 0x1700666A RID: 26218
		// (get) Token: 0x060133B7 RID: 78775
		public virtual extern object IHTMLDOMNode_attributes { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] get; }

		// Token: 0x060133B8 RID: 78776
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		public virtual extern global::mshtml.IHTMLDOMNode IHTMLDOMNode_insertBefore([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLDOMNode newChild, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] object refChild);

		// Token: 0x060133B9 RID: 78777
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		public virtual extern global::mshtml.IHTMLDOMNode IHTMLDOMNode_removeChild([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLDOMNode oldChild);

		// Token: 0x060133BA RID: 78778
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		public virtual extern global::mshtml.IHTMLDOMNode IHTMLDOMNode_replaceChild([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLDOMNode newChild, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLDOMNode oldChild);

		// Token: 0x060133BB RID: 78779
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		public virtual extern global::mshtml.IHTMLDOMNode IHTMLDOMNode_cloneNode([global::System.Runtime.InteropServices.In] bool fDeep);

		// Token: 0x060133BC RID: 78780
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		public virtual extern global::mshtml.IHTMLDOMNode IHTMLDOMNode_removeNode([global::System.Runtime.InteropServices.In] bool fDeep = false);

		// Token: 0x060133BD RID: 78781
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		public virtual extern global::mshtml.IHTMLDOMNode IHTMLDOMNode_swapNode([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLDOMNode otherNode);

		// Token: 0x060133BE RID: 78782
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		public virtual extern global::mshtml.IHTMLDOMNode IHTMLDOMNode_replaceNode([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLDOMNode replacement);

		// Token: 0x060133BF RID: 78783
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		public virtual extern global::mshtml.IHTMLDOMNode IHTMLDOMNode_appendChild([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLDOMNode newChild);

		// Token: 0x1700666B RID: 26219
		// (get) Token: 0x060133C0 RID: 78784
		public virtual extern string IHTMLDOMNode_nodeName { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x1700666C RID: 26220
		// (get) Token: 0x060133C2 RID: 78786
		// (set) Token: 0x060133C1 RID: 78785
		public virtual extern object IHTMLDOMNode_nodeValue { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700666D RID: 26221
		// (get) Token: 0x060133C3 RID: 78787
		public virtual extern global::mshtml.IHTMLDOMNode IHTMLDOMNode_firstChild { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x1700666E RID: 26222
		// (get) Token: 0x060133C4 RID: 78788
		public virtual extern global::mshtml.IHTMLDOMNode IHTMLDOMNode_lastChild { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x1700666F RID: 26223
		// (get) Token: 0x060133C5 RID: 78789
		public virtual extern global::mshtml.IHTMLDOMNode IHTMLDOMNode_previousSibling { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x17006670 RID: 26224
		// (get) Token: 0x060133C6 RID: 78790
		public virtual extern global::mshtml.IHTMLDOMNode IHTMLDOMNode_nextSibling { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x17006671 RID: 26225
		// (get) Token: 0x060133C7 RID: 78791
		public virtual extern object IHTMLDOMNode2_ownerDocument { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] get; }

		// Token: 0x17006672 RID: 26226
		// (get) Token: 0x060133C9 RID: 78793
		// (set) Token: 0x060133C8 RID: 78792
		public virtual extern short IHTMLControlElement_tabIndex { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x060133CA RID: 78794
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void IHTMLControlElement_focus();

		// Token: 0x17006673 RID: 26227
		// (get) Token: 0x060133CC RID: 78796
		// (set) Token: 0x060133CB RID: 78795
		public virtual extern string IHTMLControlElement_accessKey { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17006674 RID: 26228
		// (get) Token: 0x060133CE RID: 78798
		// (set) Token: 0x060133CD RID: 78797
		public virtual extern object IHTMLControlElement_onblur { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17006675 RID: 26229
		// (get) Token: 0x060133D0 RID: 78800
		// (set) Token: 0x060133CF RID: 78799
		public virtual extern object IHTMLControlElement_onfocus { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17006676 RID: 26230
		// (get) Token: 0x060133D2 RID: 78802
		// (set) Token: 0x060133D1 RID: 78801
		public virtual extern object IHTMLControlElement_onresize { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x060133D3 RID: 78803
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void IHTMLControlElement_blur();

		// Token: 0x060133D4 RID: 78804
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void IHTMLControlElement_addFilter([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IUnknown)] [global::System.Runtime.InteropServices.In] object pUnk);

		// Token: 0x060133D5 RID: 78805
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void IHTMLControlElement_removeFilter([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IUnknown)] [global::System.Runtime.InteropServices.In] object pUnk);

		// Token: 0x17006677 RID: 26231
		// (get) Token: 0x060133D6 RID: 78806
		public virtual extern int IHTMLControlElement_clientHeight { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x17006678 RID: 26232
		// (get) Token: 0x060133D7 RID: 78807
		public virtual extern int IHTMLControlElement_clientWidth { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x17006679 RID: 26233
		// (get) Token: 0x060133D8 RID: 78808
		public virtual extern int IHTMLControlElement_clientTop { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700667A RID: 26234
		// (get) Token: 0x060133D9 RID: 78809
		public virtual extern int IHTMLControlElement_clientLeft { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700667B RID: 26235
		// (get) Token: 0x060133DB RID: 78811
		// (set) Token: 0x060133DA RID: 78810
		public virtual extern string IHTMLFrameBase_src { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700667C RID: 26236
		// (get) Token: 0x060133DD RID: 78813
		// (set) Token: 0x060133DC RID: 78812
		public virtual extern string IHTMLFrameBase_name { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700667D RID: 26237
		// (get) Token: 0x060133DF RID: 78815
		// (set) Token: 0x060133DE RID: 78814
		public virtual extern object IHTMLFrameBase_border { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700667E RID: 26238
		// (get) Token: 0x060133E1 RID: 78817
		// (set) Token: 0x060133E0 RID: 78816
		public virtual extern string IHTMLFrameBase_frameBorder { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700667F RID: 26239
		// (get) Token: 0x060133E3 RID: 78819
		// (set) Token: 0x060133E2 RID: 78818
		public virtual extern object IHTMLFrameBase_frameSpacing { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17006680 RID: 26240
		// (get) Token: 0x060133E5 RID: 78821
		// (set) Token: 0x060133E4 RID: 78820
		public virtual extern object IHTMLFrameBase_marginWidth { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17006681 RID: 26241
		// (get) Token: 0x060133E7 RID: 78823
		// (set) Token: 0x060133E6 RID: 78822
		public virtual extern object IHTMLFrameBase_marginHeight { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17006682 RID: 26242
		// (get) Token: 0x060133E9 RID: 78825
		// (set) Token: 0x060133E8 RID: 78824
		public virtual extern bool IHTMLFrameBase_noResize { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17006683 RID: 26243
		// (get) Token: 0x060133EB RID: 78827
		// (set) Token: 0x060133EA RID: 78826
		public virtual extern string IHTMLFrameBase_scrolling { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17006684 RID: 26244
		// (get) Token: 0x060133EC RID: 78828
		public virtual extern global::mshtml.IHTMLWindow2 IHTMLFrameBase2_contentWindow { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x17006685 RID: 26245
		// (get) Token: 0x060133EE RID: 78830
		// (set) Token: 0x060133ED RID: 78829
		public virtual extern object IHTMLFrameBase2_onload { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17006686 RID: 26246
		// (get) Token: 0x060133F0 RID: 78832
		// (set) Token: 0x060133EF RID: 78831
		public virtual extern object IHTMLFrameBase2_onreadystatechange { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17006687 RID: 26247
		// (get) Token: 0x060133F1 RID: 78833
		public virtual extern string IHTMLFrameBase2_readyState { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x17006688 RID: 26248
		// (get) Token: 0x060133F3 RID: 78835
		// (set) Token: 0x060133F2 RID: 78834
		public virtual extern bool IHTMLFrameBase2_allowTransparency { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17006689 RID: 26249
		// (get) Token: 0x060133F5 RID: 78837
		// (set) Token: 0x060133F4 RID: 78836
		public virtual extern string IHTMLFrameBase3_longDesc { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x14002491 RID: 9361
		// (add) Token: 0x060133F6 RID: 78838
		// (remove) Token: 0x060133F7 RID: 78839
		public virtual extern event global::mshtml.HTMLControlElementEvents_onhelpEventHandler HTMLControlElementEvents_Event_onhelp;

		// Token: 0x14002492 RID: 9362
		// (add) Token: 0x060133F8 RID: 78840
		// (remove) Token: 0x060133F9 RID: 78841
		public virtual extern event global::mshtml.HTMLControlElementEvents_onclickEventHandler HTMLControlElementEvents_Event_onclick;

		// Token: 0x14002493 RID: 9363
		// (add) Token: 0x060133FA RID: 78842
		// (remove) Token: 0x060133FB RID: 78843
		public virtual extern event global::mshtml.HTMLControlElementEvents_ondblclickEventHandler HTMLControlElementEvents_Event_ondblclick;

		// Token: 0x14002494 RID: 9364
		// (add) Token: 0x060133FC RID: 78844
		// (remove) Token: 0x060133FD RID: 78845
		public virtual extern event global::mshtml.HTMLControlElementEvents_onkeypressEventHandler HTMLControlElementEvents_Event_onkeypress;

		// Token: 0x14002495 RID: 9365
		// (add) Token: 0x060133FE RID: 78846
		// (remove) Token: 0x060133FF RID: 78847
		public virtual extern event global::mshtml.HTMLControlElementEvents_onkeydownEventHandler HTMLControlElementEvents_Event_onkeydown;

		// Token: 0x14002496 RID: 9366
		// (add) Token: 0x06013400 RID: 78848
		// (remove) Token: 0x06013401 RID: 78849
		public virtual extern event global::mshtml.HTMLControlElementEvents_onkeyupEventHandler HTMLControlElementEvents_Event_onkeyup;

		// Token: 0x14002497 RID: 9367
		// (add) Token: 0x06013402 RID: 78850
		// (remove) Token: 0x06013403 RID: 78851
		public virtual extern event global::mshtml.HTMLControlElementEvents_onmouseoutEventHandler HTMLControlElementEvents_Event_onmouseout;

		// Token: 0x14002498 RID: 9368
		// (add) Token: 0x06013404 RID: 78852
		// (remove) Token: 0x06013405 RID: 78853
		public virtual extern event global::mshtml.HTMLControlElementEvents_onmouseoverEventHandler HTMLControlElementEvents_Event_onmouseover;

		// Token: 0x14002499 RID: 9369
		// (add) Token: 0x06013406 RID: 78854
		// (remove) Token: 0x06013407 RID: 78855
		public virtual extern event global::mshtml.HTMLControlElementEvents_onmousemoveEventHandler HTMLControlElementEvents_Event_onmousemove;

		// Token: 0x1400249A RID: 9370
		// (add) Token: 0x06013408 RID: 78856
		// (remove) Token: 0x06013409 RID: 78857
		public virtual extern event global::mshtml.HTMLControlElementEvents_onmousedownEventHandler HTMLControlElementEvents_Event_onmousedown;

		// Token: 0x1400249B RID: 9371
		// (add) Token: 0x0601340A RID: 78858
		// (remove) Token: 0x0601340B RID: 78859
		public virtual extern event global::mshtml.HTMLControlElementEvents_onmouseupEventHandler HTMLControlElementEvents_Event_onmouseup;

		// Token: 0x1400249C RID: 9372
		// (add) Token: 0x0601340C RID: 78860
		// (remove) Token: 0x0601340D RID: 78861
		public virtual extern event global::mshtml.HTMLControlElementEvents_onselectstartEventHandler HTMLControlElementEvents_Event_onselectstart;

		// Token: 0x1400249D RID: 9373
		// (add) Token: 0x0601340E RID: 78862
		// (remove) Token: 0x0601340F RID: 78863
		public virtual extern event global::mshtml.HTMLControlElementEvents_onfilterchangeEventHandler HTMLControlElementEvents_Event_onfilterchange;

		// Token: 0x1400249E RID: 9374
		// (add) Token: 0x06013410 RID: 78864
		// (remove) Token: 0x06013411 RID: 78865
		public virtual extern event global::mshtml.HTMLControlElementEvents_ondragstartEventHandler HTMLControlElementEvents_Event_ondragstart;

		// Token: 0x1400249F RID: 9375
		// (add) Token: 0x06013412 RID: 78866
		// (remove) Token: 0x06013413 RID: 78867
		public virtual extern event global::mshtml.HTMLControlElementEvents_onbeforeupdateEventHandler HTMLControlElementEvents_Event_onbeforeupdate;

		// Token: 0x140024A0 RID: 9376
		// (add) Token: 0x06013414 RID: 78868
		// (remove) Token: 0x06013415 RID: 78869
		public virtual extern event global::mshtml.HTMLControlElementEvents_onafterupdateEventHandler HTMLControlElementEvents_Event_onafterupdate;

		// Token: 0x140024A1 RID: 9377
		// (add) Token: 0x06013416 RID: 78870
		// (remove) Token: 0x06013417 RID: 78871
		public virtual extern event global::mshtml.HTMLControlElementEvents_onerrorupdateEventHandler HTMLControlElementEvents_Event_onerrorupdate;

		// Token: 0x140024A2 RID: 9378
		// (add) Token: 0x06013418 RID: 78872
		// (remove) Token: 0x06013419 RID: 78873
		public virtual extern event global::mshtml.HTMLControlElementEvents_onrowexitEventHandler HTMLControlElementEvents_Event_onrowexit;

		// Token: 0x140024A3 RID: 9379
		// (add) Token: 0x0601341A RID: 78874
		// (remove) Token: 0x0601341B RID: 78875
		public virtual extern event global::mshtml.HTMLControlElementEvents_onrowenterEventHandler HTMLControlElementEvents_Event_onrowenter;

		// Token: 0x140024A4 RID: 9380
		// (add) Token: 0x0601341C RID: 78876
		// (remove) Token: 0x0601341D RID: 78877
		public virtual extern event global::mshtml.HTMLControlElementEvents_ondatasetchangedEventHandler HTMLControlElementEvents_Event_ondatasetchanged;

		// Token: 0x140024A5 RID: 9381
		// (add) Token: 0x0601341E RID: 78878
		// (remove) Token: 0x0601341F RID: 78879
		public virtual extern event global::mshtml.HTMLControlElementEvents_ondataavailableEventHandler HTMLControlElementEvents_Event_ondataavailable;

		// Token: 0x140024A6 RID: 9382
		// (add) Token: 0x06013420 RID: 78880
		// (remove) Token: 0x06013421 RID: 78881
		public virtual extern event global::mshtml.HTMLControlElementEvents_ondatasetcompleteEventHandler HTMLControlElementEvents_Event_ondatasetcomplete;

		// Token: 0x140024A7 RID: 9383
		// (add) Token: 0x06013422 RID: 78882
		// (remove) Token: 0x06013423 RID: 78883
		public virtual extern event global::mshtml.HTMLControlElementEvents_onlosecaptureEventHandler HTMLControlElementEvents_Event_onlosecapture;

		// Token: 0x140024A8 RID: 9384
		// (add) Token: 0x06013424 RID: 78884
		// (remove) Token: 0x06013425 RID: 78885
		public virtual extern event global::mshtml.HTMLControlElementEvents_onpropertychangeEventHandler HTMLControlElementEvents_Event_onpropertychange;

		// Token: 0x140024A9 RID: 9385
		// (add) Token: 0x06013426 RID: 78886
		// (remove) Token: 0x06013427 RID: 78887
		public virtual extern event global::mshtml.HTMLControlElementEvents_onscrollEventHandler HTMLControlElementEvents_Event_onscroll;

		// Token: 0x140024AA RID: 9386
		// (add) Token: 0x06013428 RID: 78888
		// (remove) Token: 0x06013429 RID: 78889
		public virtual extern event global::mshtml.HTMLControlElementEvents_onfocusEventHandler HTMLControlElementEvents_Event_onfocus;

		// Token: 0x140024AB RID: 9387
		// (add) Token: 0x0601342A RID: 78890
		// (remove) Token: 0x0601342B RID: 78891
		public virtual extern event global::mshtml.HTMLControlElementEvents_onblurEventHandler HTMLControlElementEvents_Event_onblur;

		// Token: 0x140024AC RID: 9388
		// (add) Token: 0x0601342C RID: 78892
		// (remove) Token: 0x0601342D RID: 78893
		public virtual extern event global::mshtml.HTMLControlElementEvents_onresizeEventHandler HTMLControlElementEvents_Event_onresize;

		// Token: 0x140024AD RID: 9389
		// (add) Token: 0x0601342E RID: 78894
		// (remove) Token: 0x0601342F RID: 78895
		public virtual extern event global::mshtml.HTMLControlElementEvents_ondragEventHandler HTMLControlElementEvents_Event_ondrag;

		// Token: 0x140024AE RID: 9390
		// (add) Token: 0x06013430 RID: 78896
		// (remove) Token: 0x06013431 RID: 78897
		public virtual extern event global::mshtml.HTMLControlElementEvents_ondragendEventHandler HTMLControlElementEvents_Event_ondragend;

		// Token: 0x140024AF RID: 9391
		// (add) Token: 0x06013432 RID: 78898
		// (remove) Token: 0x06013433 RID: 78899
		public virtual extern event global::mshtml.HTMLControlElementEvents_ondragenterEventHandler HTMLControlElementEvents_Event_ondragenter;

		// Token: 0x140024B0 RID: 9392
		// (add) Token: 0x06013434 RID: 78900
		// (remove) Token: 0x06013435 RID: 78901
		public virtual extern event global::mshtml.HTMLControlElementEvents_ondragoverEventHandler HTMLControlElementEvents_Event_ondragover;

		// Token: 0x140024B1 RID: 9393
		// (add) Token: 0x06013436 RID: 78902
		// (remove) Token: 0x06013437 RID: 78903
		public virtual extern event global::mshtml.HTMLControlElementEvents_ondragleaveEventHandler HTMLControlElementEvents_Event_ondragleave;

		// Token: 0x140024B2 RID: 9394
		// (add) Token: 0x06013438 RID: 78904
		// (remove) Token: 0x06013439 RID: 78905
		public virtual extern event global::mshtml.HTMLControlElementEvents_ondropEventHandler HTMLControlElementEvents_Event_ondrop;

		// Token: 0x140024B3 RID: 9395
		// (add) Token: 0x0601343A RID: 78906
		// (remove) Token: 0x0601343B RID: 78907
		public virtual extern event global::mshtml.HTMLControlElementEvents_onbeforecutEventHandler HTMLControlElementEvents_Event_onbeforecut;

		// Token: 0x140024B4 RID: 9396
		// (add) Token: 0x0601343C RID: 78908
		// (remove) Token: 0x0601343D RID: 78909
		public virtual extern event global::mshtml.HTMLControlElementEvents_oncutEventHandler HTMLControlElementEvents_Event_oncut;

		// Token: 0x140024B5 RID: 9397
		// (add) Token: 0x0601343E RID: 78910
		// (remove) Token: 0x0601343F RID: 78911
		public virtual extern event global::mshtml.HTMLControlElementEvents_onbeforecopyEventHandler HTMLControlElementEvents_Event_onbeforecopy;

		// Token: 0x140024B6 RID: 9398
		// (add) Token: 0x06013440 RID: 78912
		// (remove) Token: 0x06013441 RID: 78913
		public virtual extern event global::mshtml.HTMLControlElementEvents_oncopyEventHandler HTMLControlElementEvents_Event_oncopy;

		// Token: 0x140024B7 RID: 9399
		// (add) Token: 0x06013442 RID: 78914
		// (remove) Token: 0x06013443 RID: 78915
		public virtual extern event global::mshtml.HTMLControlElementEvents_onbeforepasteEventHandler HTMLControlElementEvents_Event_onbeforepaste;

		// Token: 0x140024B8 RID: 9400
		// (add) Token: 0x06013444 RID: 78916
		// (remove) Token: 0x06013445 RID: 78917
		public virtual extern event global::mshtml.HTMLControlElementEvents_onpasteEventHandler HTMLControlElementEvents_Event_onpaste;

		// Token: 0x140024B9 RID: 9401
		// (add) Token: 0x06013446 RID: 78918
		// (remove) Token: 0x06013447 RID: 78919
		public virtual extern event global::mshtml.HTMLControlElementEvents_oncontextmenuEventHandler HTMLControlElementEvents_Event_oncontextmenu;

		// Token: 0x140024BA RID: 9402
		// (add) Token: 0x06013448 RID: 78920
		// (remove) Token: 0x06013449 RID: 78921
		public virtual extern event global::mshtml.HTMLControlElementEvents_onrowsdeleteEventHandler HTMLControlElementEvents_Event_onrowsdelete;

		// Token: 0x140024BB RID: 9403
		// (add) Token: 0x0601344A RID: 78922
		// (remove) Token: 0x0601344B RID: 78923
		public virtual extern event global::mshtml.HTMLControlElementEvents_onrowsinsertedEventHandler HTMLControlElementEvents_Event_onrowsinserted;

		// Token: 0x140024BC RID: 9404
		// (add) Token: 0x0601344C RID: 78924
		// (remove) Token: 0x0601344D RID: 78925
		public virtual extern event global::mshtml.HTMLControlElementEvents_oncellchangeEventHandler HTMLControlElementEvents_Event_oncellchange;

		// Token: 0x140024BD RID: 9405
		// (add) Token: 0x0601344E RID: 78926
		// (remove) Token: 0x0601344F RID: 78927
		public virtual extern event global::mshtml.HTMLControlElementEvents_onreadystatechangeEventHandler HTMLControlElementEvents_Event_onreadystatechange;

		// Token: 0x140024BE RID: 9406
		// (add) Token: 0x06013450 RID: 78928
		// (remove) Token: 0x06013451 RID: 78929
		public virtual extern event global::mshtml.HTMLControlElementEvents_onbeforeeditfocusEventHandler HTMLControlElementEvents_Event_onbeforeeditfocus;

		// Token: 0x140024BF RID: 9407
		// (add) Token: 0x06013452 RID: 78930
		// (remove) Token: 0x06013453 RID: 78931
		public virtual extern event global::mshtml.HTMLControlElementEvents_onlayoutcompleteEventHandler HTMLControlElementEvents_Event_onlayoutcomplete;

		// Token: 0x140024C0 RID: 9408
		// (add) Token: 0x06013454 RID: 78932
		// (remove) Token: 0x06013455 RID: 78933
		public virtual extern event global::mshtml.HTMLControlElementEvents_onpageEventHandler HTMLControlElementEvents_Event_onpage;

		// Token: 0x140024C1 RID: 9409
		// (add) Token: 0x06013456 RID: 78934
		// (remove) Token: 0x06013457 RID: 78935
		public virtual extern event global::mshtml.HTMLControlElementEvents_onbeforedeactivateEventHandler HTMLControlElementEvents_Event_onbeforedeactivate;

		// Token: 0x140024C2 RID: 9410
		// (add) Token: 0x06013458 RID: 78936
		// (remove) Token: 0x06013459 RID: 78937
		public virtual extern event global::mshtml.HTMLControlElementEvents_onbeforeactivateEventHandler HTMLControlElementEvents_Event_onbeforeactivate;

		// Token: 0x140024C3 RID: 9411
		// (add) Token: 0x0601345A RID: 78938
		// (remove) Token: 0x0601345B RID: 78939
		public virtual extern event global::mshtml.HTMLControlElementEvents_onmoveEventHandler HTMLControlElementEvents_Event_onmove;

		// Token: 0x140024C4 RID: 9412
		// (add) Token: 0x0601345C RID: 78940
		// (remove) Token: 0x0601345D RID: 78941
		public virtual extern event global::mshtml.HTMLControlElementEvents_oncontrolselectEventHandler HTMLControlElementEvents_Event_oncontrolselect;

		// Token: 0x140024C5 RID: 9413
		// (add) Token: 0x0601345E RID: 78942
		// (remove) Token: 0x0601345F RID: 78943
		public virtual extern event global::mshtml.HTMLControlElementEvents_onmovestartEventHandler HTMLControlElementEvents_Event_onmovestart;

		// Token: 0x140024C6 RID: 9414
		// (add) Token: 0x06013460 RID: 78944
		// (remove) Token: 0x06013461 RID: 78945
		public virtual extern event global::mshtml.HTMLControlElementEvents_onmoveendEventHandler HTMLControlElementEvents_Event_onmoveend;

		// Token: 0x140024C7 RID: 9415
		// (add) Token: 0x06013462 RID: 78946
		// (remove) Token: 0x06013463 RID: 78947
		public virtual extern event global::mshtml.HTMLControlElementEvents_onresizestartEventHandler HTMLControlElementEvents_Event_onresizestart;

		// Token: 0x140024C8 RID: 9416
		// (add) Token: 0x06013464 RID: 78948
		// (remove) Token: 0x06013465 RID: 78949
		public virtual extern event global::mshtml.HTMLControlElementEvents_onresizeendEventHandler HTMLControlElementEvents_Event_onresizeend;

		// Token: 0x140024C9 RID: 9417
		// (add) Token: 0x06013466 RID: 78950
		// (remove) Token: 0x06013467 RID: 78951
		public virtual extern event global::mshtml.HTMLControlElementEvents_onmouseenterEventHandler HTMLControlElementEvents_Event_onmouseenter;

		// Token: 0x140024CA RID: 9418
		// (add) Token: 0x06013468 RID: 78952
		// (remove) Token: 0x06013469 RID: 78953
		public virtual extern event global::mshtml.HTMLControlElementEvents_onmouseleaveEventHandler HTMLControlElementEvents_Event_onmouseleave;

		// Token: 0x140024CB RID: 9419
		// (add) Token: 0x0601346A RID: 78954
		// (remove) Token: 0x0601346B RID: 78955
		public virtual extern event global::mshtml.HTMLControlElementEvents_onmousewheelEventHandler HTMLControlElementEvents_Event_onmousewheel;

		// Token: 0x140024CC RID: 9420
		// (add) Token: 0x0601346C RID: 78956
		// (remove) Token: 0x0601346D RID: 78957
		public virtual extern event global::mshtml.HTMLControlElementEvents_onactivateEventHandler HTMLControlElementEvents_Event_onactivate;

		// Token: 0x140024CD RID: 9421
		// (add) Token: 0x0601346E RID: 78958
		// (remove) Token: 0x0601346F RID: 78959
		public virtual extern event global::mshtml.HTMLControlElementEvents_ondeactivateEventHandler HTMLControlElementEvents_Event_ondeactivate;

		// Token: 0x140024CE RID: 9422
		// (add) Token: 0x06013470 RID: 78960
		// (remove) Token: 0x06013471 RID: 78961
		public virtual extern event global::mshtml.HTMLControlElementEvents_onfocusinEventHandler HTMLControlElementEvents_Event_onfocusin;

		// Token: 0x140024CF RID: 9423
		// (add) Token: 0x06013472 RID: 78962
		// (remove) Token: 0x06013473 RID: 78963
		public virtual extern event global::mshtml.HTMLControlElementEvents_onfocusoutEventHandler HTMLControlElementEvents_Event_onfocusout;

		// Token: 0x140024D0 RID: 9424
		// (add) Token: 0x06013474 RID: 78964
		// (remove) Token: 0x06013475 RID: 78965
		public virtual extern event global::mshtml.HTMLControlElementEvents2_onhelpEventHandler HTMLControlElementEvents2_Event_onhelp;

		// Token: 0x140024D1 RID: 9425
		// (add) Token: 0x06013476 RID: 78966
		// (remove) Token: 0x06013477 RID: 78967
		public virtual extern event global::mshtml.HTMLControlElementEvents2_onclickEventHandler HTMLControlElementEvents2_Event_onclick;

		// Token: 0x140024D2 RID: 9426
		// (add) Token: 0x06013478 RID: 78968
		// (remove) Token: 0x06013479 RID: 78969
		public virtual extern event global::mshtml.HTMLControlElementEvents2_ondblclickEventHandler HTMLControlElementEvents2_Event_ondblclick;

		// Token: 0x140024D3 RID: 9427
		// (add) Token: 0x0601347A RID: 78970
		// (remove) Token: 0x0601347B RID: 78971
		public virtual extern event global::mshtml.HTMLControlElementEvents2_onkeypressEventHandler HTMLControlElementEvents2_Event_onkeypress;

		// Token: 0x140024D4 RID: 9428
		// (add) Token: 0x0601347C RID: 78972
		// (remove) Token: 0x0601347D RID: 78973
		public virtual extern event global::mshtml.HTMLControlElementEvents2_onkeydownEventHandler HTMLControlElementEvents2_Event_onkeydown;

		// Token: 0x140024D5 RID: 9429
		// (add) Token: 0x0601347E RID: 78974
		// (remove) Token: 0x0601347F RID: 78975
		public virtual extern event global::mshtml.HTMLControlElementEvents2_onkeyupEventHandler HTMLControlElementEvents2_Event_onkeyup;

		// Token: 0x140024D6 RID: 9430
		// (add) Token: 0x06013480 RID: 78976
		// (remove) Token: 0x06013481 RID: 78977
		public virtual extern event global::mshtml.HTMLControlElementEvents2_onmouseoutEventHandler HTMLControlElementEvents2_Event_onmouseout;

		// Token: 0x140024D7 RID: 9431
		// (add) Token: 0x06013482 RID: 78978
		// (remove) Token: 0x06013483 RID: 78979
		public virtual extern event global::mshtml.HTMLControlElementEvents2_onmouseoverEventHandler HTMLControlElementEvents2_Event_onmouseover;

		// Token: 0x140024D8 RID: 9432
		// (add) Token: 0x06013484 RID: 78980
		// (remove) Token: 0x06013485 RID: 78981
		public virtual extern event global::mshtml.HTMLControlElementEvents2_onmousemoveEventHandler HTMLControlElementEvents2_Event_onmousemove;

		// Token: 0x140024D9 RID: 9433
		// (add) Token: 0x06013486 RID: 78982
		// (remove) Token: 0x06013487 RID: 78983
		public virtual extern event global::mshtml.HTMLControlElementEvents2_onmousedownEventHandler HTMLControlElementEvents2_Event_onmousedown;

		// Token: 0x140024DA RID: 9434
		// (add) Token: 0x06013488 RID: 78984
		// (remove) Token: 0x06013489 RID: 78985
		public virtual extern event global::mshtml.HTMLControlElementEvents2_onmouseupEventHandler HTMLControlElementEvents2_Event_onmouseup;

		// Token: 0x140024DB RID: 9435
		// (add) Token: 0x0601348A RID: 78986
		// (remove) Token: 0x0601348B RID: 78987
		public virtual extern event global::mshtml.HTMLControlElementEvents2_onselectstartEventHandler HTMLControlElementEvents2_Event_onselectstart;

		// Token: 0x140024DC RID: 9436
		// (add) Token: 0x0601348C RID: 78988
		// (remove) Token: 0x0601348D RID: 78989
		public virtual extern event global::mshtml.HTMLControlElementEvents2_onfilterchangeEventHandler HTMLControlElementEvents2_Event_onfilterchange;

		// Token: 0x140024DD RID: 9437
		// (add) Token: 0x0601348E RID: 78990
		// (remove) Token: 0x0601348F RID: 78991
		public virtual extern event global::mshtml.HTMLControlElementEvents2_ondragstartEventHandler HTMLControlElementEvents2_Event_ondragstart;

		// Token: 0x140024DE RID: 9438
		// (add) Token: 0x06013490 RID: 78992
		// (remove) Token: 0x06013491 RID: 78993
		public virtual extern event global::mshtml.HTMLControlElementEvents2_onbeforeupdateEventHandler HTMLControlElementEvents2_Event_onbeforeupdate;

		// Token: 0x140024DF RID: 9439
		// (add) Token: 0x06013492 RID: 78994
		// (remove) Token: 0x06013493 RID: 78995
		public virtual extern event global::mshtml.HTMLControlElementEvents2_onafterupdateEventHandler HTMLControlElementEvents2_Event_onafterupdate;

		// Token: 0x140024E0 RID: 9440
		// (add) Token: 0x06013494 RID: 78996
		// (remove) Token: 0x06013495 RID: 78997
		public virtual extern event global::mshtml.HTMLControlElementEvents2_onerrorupdateEventHandler HTMLControlElementEvents2_Event_onerrorupdate;

		// Token: 0x140024E1 RID: 9441
		// (add) Token: 0x06013496 RID: 78998
		// (remove) Token: 0x06013497 RID: 78999
		public virtual extern event global::mshtml.HTMLControlElementEvents2_onrowexitEventHandler HTMLControlElementEvents2_Event_onrowexit;

		// Token: 0x140024E2 RID: 9442
		// (add) Token: 0x06013498 RID: 79000
		// (remove) Token: 0x06013499 RID: 79001
		public virtual extern event global::mshtml.HTMLControlElementEvents2_onrowenterEventHandler HTMLControlElementEvents2_Event_onrowenter;

		// Token: 0x140024E3 RID: 9443
		// (add) Token: 0x0601349A RID: 79002
		// (remove) Token: 0x0601349B RID: 79003
		public virtual extern event global::mshtml.HTMLControlElementEvents2_ondatasetchangedEventHandler HTMLControlElementEvents2_Event_ondatasetchanged;

		// Token: 0x140024E4 RID: 9444
		// (add) Token: 0x0601349C RID: 79004
		// (remove) Token: 0x0601349D RID: 79005
		public virtual extern event global::mshtml.HTMLControlElementEvents2_ondataavailableEventHandler HTMLControlElementEvents2_Event_ondataavailable;

		// Token: 0x140024E5 RID: 9445
		// (add) Token: 0x0601349E RID: 79006
		// (remove) Token: 0x0601349F RID: 79007
		public virtual extern event global::mshtml.HTMLControlElementEvents2_ondatasetcompleteEventHandler HTMLControlElementEvents2_Event_ondatasetcomplete;

		// Token: 0x140024E6 RID: 9446
		// (add) Token: 0x060134A0 RID: 79008
		// (remove) Token: 0x060134A1 RID: 79009
		public virtual extern event global::mshtml.HTMLControlElementEvents2_onlosecaptureEventHandler HTMLControlElementEvents2_Event_onlosecapture;

		// Token: 0x140024E7 RID: 9447
		// (add) Token: 0x060134A2 RID: 79010
		// (remove) Token: 0x060134A3 RID: 79011
		public virtual extern event global::mshtml.HTMLControlElementEvents2_onpropertychangeEventHandler HTMLControlElementEvents2_Event_onpropertychange;

		// Token: 0x140024E8 RID: 9448
		// (add) Token: 0x060134A4 RID: 79012
		// (remove) Token: 0x060134A5 RID: 79013
		public virtual extern event global::mshtml.HTMLControlElementEvents2_onscrollEventHandler HTMLControlElementEvents2_Event_onscroll;

		// Token: 0x140024E9 RID: 9449
		// (add) Token: 0x060134A6 RID: 79014
		// (remove) Token: 0x060134A7 RID: 79015
		public virtual extern event global::mshtml.HTMLControlElementEvents2_onfocusEventHandler HTMLControlElementEvents2_Event_onfocus;

		// Token: 0x140024EA RID: 9450
		// (add) Token: 0x060134A8 RID: 79016
		// (remove) Token: 0x060134A9 RID: 79017
		public virtual extern event global::mshtml.HTMLControlElementEvents2_onblurEventHandler HTMLControlElementEvents2_Event_onblur;

		// Token: 0x140024EB RID: 9451
		// (add) Token: 0x060134AA RID: 79018
		// (remove) Token: 0x060134AB RID: 79019
		public virtual extern event global::mshtml.HTMLControlElementEvents2_onresizeEventHandler HTMLControlElementEvents2_Event_onresize;

		// Token: 0x140024EC RID: 9452
		// (add) Token: 0x060134AC RID: 79020
		// (remove) Token: 0x060134AD RID: 79021
		public virtual extern event global::mshtml.HTMLControlElementEvents2_ondragEventHandler HTMLControlElementEvents2_Event_ondrag;

		// Token: 0x140024ED RID: 9453
		// (add) Token: 0x060134AE RID: 79022
		// (remove) Token: 0x060134AF RID: 79023
		public virtual extern event global::mshtml.HTMLControlElementEvents2_ondragendEventHandler HTMLControlElementEvents2_Event_ondragend;

		// Token: 0x140024EE RID: 9454
		// (add) Token: 0x060134B0 RID: 79024
		// (remove) Token: 0x060134B1 RID: 79025
		public virtual extern event global::mshtml.HTMLControlElementEvents2_ondragenterEventHandler HTMLControlElementEvents2_Event_ondragenter;

		// Token: 0x140024EF RID: 9455
		// (add) Token: 0x060134B2 RID: 79026
		// (remove) Token: 0x060134B3 RID: 79027
		public virtual extern event global::mshtml.HTMLControlElementEvents2_ondragoverEventHandler HTMLControlElementEvents2_Event_ondragover;

		// Token: 0x140024F0 RID: 9456
		// (add) Token: 0x060134B4 RID: 79028
		// (remove) Token: 0x060134B5 RID: 79029
		public virtual extern event global::mshtml.HTMLControlElementEvents2_ondragleaveEventHandler HTMLControlElementEvents2_Event_ondragleave;

		// Token: 0x140024F1 RID: 9457
		// (add) Token: 0x060134B6 RID: 79030
		// (remove) Token: 0x060134B7 RID: 79031
		public virtual extern event global::mshtml.HTMLControlElementEvents2_ondropEventHandler HTMLControlElementEvents2_Event_ondrop;

		// Token: 0x140024F2 RID: 9458
		// (add) Token: 0x060134B8 RID: 79032
		// (remove) Token: 0x060134B9 RID: 79033
		public virtual extern event global::mshtml.HTMLControlElementEvents2_onbeforecutEventHandler HTMLControlElementEvents2_Event_onbeforecut;

		// Token: 0x140024F3 RID: 9459
		// (add) Token: 0x060134BA RID: 79034
		// (remove) Token: 0x060134BB RID: 79035
		public virtual extern event global::mshtml.HTMLControlElementEvents2_oncutEventHandler HTMLControlElementEvents2_Event_oncut;

		// Token: 0x140024F4 RID: 9460
		// (add) Token: 0x060134BC RID: 79036
		// (remove) Token: 0x060134BD RID: 79037
		public virtual extern event global::mshtml.HTMLControlElementEvents2_onbeforecopyEventHandler HTMLControlElementEvents2_Event_onbeforecopy;

		// Token: 0x140024F5 RID: 9461
		// (add) Token: 0x060134BE RID: 79038
		// (remove) Token: 0x060134BF RID: 79039
		public virtual extern event global::mshtml.HTMLControlElementEvents2_oncopyEventHandler HTMLControlElementEvents2_Event_oncopy;

		// Token: 0x140024F6 RID: 9462
		// (add) Token: 0x060134C0 RID: 79040
		// (remove) Token: 0x060134C1 RID: 79041
		public virtual extern event global::mshtml.HTMLControlElementEvents2_onbeforepasteEventHandler HTMLControlElementEvents2_Event_onbeforepaste;

		// Token: 0x140024F7 RID: 9463
		// (add) Token: 0x060134C2 RID: 79042
		// (remove) Token: 0x060134C3 RID: 79043
		public virtual extern event global::mshtml.HTMLControlElementEvents2_onpasteEventHandler HTMLControlElementEvents2_Event_onpaste;

		// Token: 0x140024F8 RID: 9464
		// (add) Token: 0x060134C4 RID: 79044
		// (remove) Token: 0x060134C5 RID: 79045
		public virtual extern event global::mshtml.HTMLControlElementEvents2_oncontextmenuEventHandler HTMLControlElementEvents2_Event_oncontextmenu;

		// Token: 0x140024F9 RID: 9465
		// (add) Token: 0x060134C6 RID: 79046
		// (remove) Token: 0x060134C7 RID: 79047
		public virtual extern event global::mshtml.HTMLControlElementEvents2_onrowsdeleteEventHandler HTMLControlElementEvents2_Event_onrowsdelete;

		// Token: 0x140024FA RID: 9466
		// (add) Token: 0x060134C8 RID: 79048
		// (remove) Token: 0x060134C9 RID: 79049
		public virtual extern event global::mshtml.HTMLControlElementEvents2_onrowsinsertedEventHandler HTMLControlElementEvents2_Event_onrowsinserted;

		// Token: 0x140024FB RID: 9467
		// (add) Token: 0x060134CA RID: 79050
		// (remove) Token: 0x060134CB RID: 79051
		public virtual extern event global::mshtml.HTMLControlElementEvents2_oncellchangeEventHandler HTMLControlElementEvents2_Event_oncellchange;

		// Token: 0x140024FC RID: 9468
		// (add) Token: 0x060134CC RID: 79052
		// (remove) Token: 0x060134CD RID: 79053
		public virtual extern event global::mshtml.HTMLControlElementEvents2_onreadystatechangeEventHandler HTMLControlElementEvents2_Event_onreadystatechange;

		// Token: 0x140024FD RID: 9469
		// (add) Token: 0x060134CE RID: 79054
		// (remove) Token: 0x060134CF RID: 79055
		public virtual extern event global::mshtml.HTMLControlElementEvents2_onlayoutcompleteEventHandler HTMLControlElementEvents2_Event_onlayoutcomplete;

		// Token: 0x140024FE RID: 9470
		// (add) Token: 0x060134D0 RID: 79056
		// (remove) Token: 0x060134D1 RID: 79057
		public virtual extern event global::mshtml.HTMLControlElementEvents2_onpageEventHandler HTMLControlElementEvents2_Event_onpage;

		// Token: 0x140024FF RID: 9471
		// (add) Token: 0x060134D2 RID: 79058
		// (remove) Token: 0x060134D3 RID: 79059
		public virtual extern event global::mshtml.HTMLControlElementEvents2_onmouseenterEventHandler HTMLControlElementEvents2_Event_onmouseenter;

		// Token: 0x14002500 RID: 9472
		// (add) Token: 0x060134D4 RID: 79060
		// (remove) Token: 0x060134D5 RID: 79061
		public virtual extern event global::mshtml.HTMLControlElementEvents2_onmouseleaveEventHandler HTMLControlElementEvents2_Event_onmouseleave;

		// Token: 0x14002501 RID: 9473
		// (add) Token: 0x060134D6 RID: 79062
		// (remove) Token: 0x060134D7 RID: 79063
		public virtual extern event global::mshtml.HTMLControlElementEvents2_onactivateEventHandler HTMLControlElementEvents2_Event_onactivate;

		// Token: 0x14002502 RID: 9474
		// (add) Token: 0x060134D8 RID: 79064
		// (remove) Token: 0x060134D9 RID: 79065
		public virtual extern event global::mshtml.HTMLControlElementEvents2_ondeactivateEventHandler HTMLControlElementEvents2_Event_ondeactivate;

		// Token: 0x14002503 RID: 9475
		// (add) Token: 0x060134DA RID: 79066
		// (remove) Token: 0x060134DB RID: 79067
		public virtual extern event global::mshtml.HTMLControlElementEvents2_onbeforedeactivateEventHandler HTMLControlElementEvents2_Event_onbeforedeactivate;

		// Token: 0x14002504 RID: 9476
		// (add) Token: 0x060134DC RID: 79068
		// (remove) Token: 0x060134DD RID: 79069
		public virtual extern event global::mshtml.HTMLControlElementEvents2_onbeforeactivateEventHandler HTMLControlElementEvents2_Event_onbeforeactivate;

		// Token: 0x14002505 RID: 9477
		// (add) Token: 0x060134DE RID: 79070
		// (remove) Token: 0x060134DF RID: 79071
		public virtual extern event global::mshtml.HTMLControlElementEvents2_onfocusinEventHandler HTMLControlElementEvents2_Event_onfocusin;

		// Token: 0x14002506 RID: 9478
		// (add) Token: 0x060134E0 RID: 79072
		// (remove) Token: 0x060134E1 RID: 79073
		public virtual extern event global::mshtml.HTMLControlElementEvents2_onfocusoutEventHandler HTMLControlElementEvents2_Event_onfocusout;

		// Token: 0x14002507 RID: 9479
		// (add) Token: 0x060134E2 RID: 79074
		// (remove) Token: 0x060134E3 RID: 79075
		public virtual extern event global::mshtml.HTMLControlElementEvents2_onmoveEventHandler HTMLControlElementEvents2_Event_onmove;

		// Token: 0x14002508 RID: 9480
		// (add) Token: 0x060134E4 RID: 79076
		// (remove) Token: 0x060134E5 RID: 79077
		public virtual extern event global::mshtml.HTMLControlElementEvents2_oncontrolselectEventHandler HTMLControlElementEvents2_Event_oncontrolselect;

		// Token: 0x14002509 RID: 9481
		// (add) Token: 0x060134E6 RID: 79078
		// (remove) Token: 0x060134E7 RID: 79079
		public virtual extern event global::mshtml.HTMLControlElementEvents2_onmovestartEventHandler HTMLControlElementEvents2_Event_onmovestart;

		// Token: 0x1400250A RID: 9482
		// (add) Token: 0x060134E8 RID: 79080
		// (remove) Token: 0x060134E9 RID: 79081
		public virtual extern event global::mshtml.HTMLControlElementEvents2_onmoveendEventHandler HTMLControlElementEvents2_Event_onmoveend;

		// Token: 0x1400250B RID: 9483
		// (add) Token: 0x060134EA RID: 79082
		// (remove) Token: 0x060134EB RID: 79083
		public virtual extern event global::mshtml.HTMLControlElementEvents2_onresizestartEventHandler HTMLControlElementEvents2_Event_onresizestart;

		// Token: 0x1400250C RID: 9484
		// (add) Token: 0x060134EC RID: 79084
		// (remove) Token: 0x060134ED RID: 79085
		public virtual extern event global::mshtml.HTMLControlElementEvents2_onresizeendEventHandler HTMLControlElementEvents2_Event_onresizeend;

		// Token: 0x1400250D RID: 9485
		// (add) Token: 0x060134EE RID: 79086
		// (remove) Token: 0x060134EF RID: 79087
		public virtual extern event global::mshtml.HTMLControlElementEvents2_onmousewheelEventHandler HTMLControlElementEvents2_Event_onmousewheel;

		// Token: 0x1400250E RID: 9486
		// (add) Token: 0x060134F0 RID: 79088
		// (remove) Token: 0x060134F1 RID: 79089
		public virtual extern event global::mshtml.HTMLFrameSiteEvents_onhelpEventHandler HTMLFrameSiteEvents_Event_onhelp;

		// Token: 0x1400250F RID: 9487
		// (add) Token: 0x060134F2 RID: 79090
		// (remove) Token: 0x060134F3 RID: 79091
		public virtual extern event global::mshtml.HTMLFrameSiteEvents_onclickEventHandler HTMLFrameSiteEvents_Event_onclick;

		// Token: 0x14002510 RID: 9488
		// (add) Token: 0x060134F4 RID: 79092
		// (remove) Token: 0x060134F5 RID: 79093
		public virtual extern event global::mshtml.HTMLFrameSiteEvents_ondblclickEventHandler HTMLFrameSiteEvents_Event_ondblclick;

		// Token: 0x14002511 RID: 9489
		// (add) Token: 0x060134F6 RID: 79094
		// (remove) Token: 0x060134F7 RID: 79095
		public virtual extern event global::mshtml.HTMLFrameSiteEvents_onkeypressEventHandler HTMLFrameSiteEvents_Event_onkeypress;

		// Token: 0x14002512 RID: 9490
		// (add) Token: 0x060134F8 RID: 79096
		// (remove) Token: 0x060134F9 RID: 79097
		public virtual extern event global::mshtml.HTMLFrameSiteEvents_onkeydownEventHandler HTMLFrameSiteEvents_Event_onkeydown;

		// Token: 0x14002513 RID: 9491
		// (add) Token: 0x060134FA RID: 79098
		// (remove) Token: 0x060134FB RID: 79099
		public virtual extern event global::mshtml.HTMLFrameSiteEvents_onkeyupEventHandler HTMLFrameSiteEvents_Event_onkeyup;

		// Token: 0x14002514 RID: 9492
		// (add) Token: 0x060134FC RID: 79100
		// (remove) Token: 0x060134FD RID: 79101
		public virtual extern event global::mshtml.HTMLFrameSiteEvents_onmouseoutEventHandler HTMLFrameSiteEvents_Event_onmouseout;

		// Token: 0x14002515 RID: 9493
		// (add) Token: 0x060134FE RID: 79102
		// (remove) Token: 0x060134FF RID: 79103
		public virtual extern event global::mshtml.HTMLFrameSiteEvents_onmouseoverEventHandler HTMLFrameSiteEvents_Event_onmouseover;

		// Token: 0x14002516 RID: 9494
		// (add) Token: 0x06013500 RID: 79104
		// (remove) Token: 0x06013501 RID: 79105
		public virtual extern event global::mshtml.HTMLFrameSiteEvents_onmousemoveEventHandler HTMLFrameSiteEvents_Event_onmousemove;

		// Token: 0x14002517 RID: 9495
		// (add) Token: 0x06013502 RID: 79106
		// (remove) Token: 0x06013503 RID: 79107
		public virtual extern event global::mshtml.HTMLFrameSiteEvents_onmousedownEventHandler HTMLFrameSiteEvents_Event_onmousedown;

		// Token: 0x14002518 RID: 9496
		// (add) Token: 0x06013504 RID: 79108
		// (remove) Token: 0x06013505 RID: 79109
		public virtual extern event global::mshtml.HTMLFrameSiteEvents_onmouseupEventHandler HTMLFrameSiteEvents_Event_onmouseup;

		// Token: 0x14002519 RID: 9497
		// (add) Token: 0x06013506 RID: 79110
		// (remove) Token: 0x06013507 RID: 79111
		public virtual extern event global::mshtml.HTMLFrameSiteEvents_onselectstartEventHandler HTMLFrameSiteEvents_Event_onselectstart;

		// Token: 0x1400251A RID: 9498
		// (add) Token: 0x06013508 RID: 79112
		// (remove) Token: 0x06013509 RID: 79113
		public virtual extern event global::mshtml.HTMLFrameSiteEvents_onfilterchangeEventHandler HTMLFrameSiteEvents_Event_onfilterchange;

		// Token: 0x1400251B RID: 9499
		// (add) Token: 0x0601350A RID: 79114
		// (remove) Token: 0x0601350B RID: 79115
		public virtual extern event global::mshtml.HTMLFrameSiteEvents_ondragstartEventHandler HTMLFrameSiteEvents_Event_ondragstart;

		// Token: 0x1400251C RID: 9500
		// (add) Token: 0x0601350C RID: 79116
		// (remove) Token: 0x0601350D RID: 79117
		public virtual extern event global::mshtml.HTMLFrameSiteEvents_onbeforeupdateEventHandler HTMLFrameSiteEvents_Event_onbeforeupdate;

		// Token: 0x1400251D RID: 9501
		// (add) Token: 0x0601350E RID: 79118
		// (remove) Token: 0x0601350F RID: 79119
		public virtual extern event global::mshtml.HTMLFrameSiteEvents_onafterupdateEventHandler HTMLFrameSiteEvents_Event_onafterupdate;

		// Token: 0x1400251E RID: 9502
		// (add) Token: 0x06013510 RID: 79120
		// (remove) Token: 0x06013511 RID: 79121
		public virtual extern event global::mshtml.HTMLFrameSiteEvents_onerrorupdateEventHandler HTMLFrameSiteEvents_Event_onerrorupdate;

		// Token: 0x1400251F RID: 9503
		// (add) Token: 0x06013512 RID: 79122
		// (remove) Token: 0x06013513 RID: 79123
		public virtual extern event global::mshtml.HTMLFrameSiteEvents_onrowexitEventHandler HTMLFrameSiteEvents_Event_onrowexit;

		// Token: 0x14002520 RID: 9504
		// (add) Token: 0x06013514 RID: 79124
		// (remove) Token: 0x06013515 RID: 79125
		public virtual extern event global::mshtml.HTMLFrameSiteEvents_onrowenterEventHandler HTMLFrameSiteEvents_Event_onrowenter;

		// Token: 0x14002521 RID: 9505
		// (add) Token: 0x06013516 RID: 79126
		// (remove) Token: 0x06013517 RID: 79127
		public virtual extern event global::mshtml.HTMLFrameSiteEvents_ondatasetchangedEventHandler HTMLFrameSiteEvents_Event_ondatasetchanged;

		// Token: 0x14002522 RID: 9506
		// (add) Token: 0x06013518 RID: 79128
		// (remove) Token: 0x06013519 RID: 79129
		public virtual extern event global::mshtml.HTMLFrameSiteEvents_ondataavailableEventHandler HTMLFrameSiteEvents_Event_ondataavailable;

		// Token: 0x14002523 RID: 9507
		// (add) Token: 0x0601351A RID: 79130
		// (remove) Token: 0x0601351B RID: 79131
		public virtual extern event global::mshtml.HTMLFrameSiteEvents_ondatasetcompleteEventHandler HTMLFrameSiteEvents_Event_ondatasetcomplete;

		// Token: 0x14002524 RID: 9508
		// (add) Token: 0x0601351C RID: 79132
		// (remove) Token: 0x0601351D RID: 79133
		public virtual extern event global::mshtml.HTMLFrameSiteEvents_onlosecaptureEventHandler HTMLFrameSiteEvents_Event_onlosecapture;

		// Token: 0x14002525 RID: 9509
		// (add) Token: 0x0601351E RID: 79134
		// (remove) Token: 0x0601351F RID: 79135
		public virtual extern event global::mshtml.HTMLFrameSiteEvents_onpropertychangeEventHandler HTMLFrameSiteEvents_Event_onpropertychange;

		// Token: 0x14002526 RID: 9510
		// (add) Token: 0x06013520 RID: 79136
		// (remove) Token: 0x06013521 RID: 79137
		public virtual extern event global::mshtml.HTMLFrameSiteEvents_onscrollEventHandler HTMLFrameSiteEvents_Event_onscroll;

		// Token: 0x14002527 RID: 9511
		// (add) Token: 0x06013522 RID: 79138
		// (remove) Token: 0x06013523 RID: 79139
		public virtual extern event global::mshtml.HTMLFrameSiteEvents_onfocusEventHandler HTMLFrameSiteEvents_Event_onfocus;

		// Token: 0x14002528 RID: 9512
		// (add) Token: 0x06013524 RID: 79140
		// (remove) Token: 0x06013525 RID: 79141
		public virtual extern event global::mshtml.HTMLFrameSiteEvents_onblurEventHandler HTMLFrameSiteEvents_Event_onblur;

		// Token: 0x14002529 RID: 9513
		// (add) Token: 0x06013526 RID: 79142
		// (remove) Token: 0x06013527 RID: 79143
		public virtual extern event global::mshtml.HTMLFrameSiteEvents_onresizeEventHandler HTMLFrameSiteEvents_Event_onresize;

		// Token: 0x1400252A RID: 9514
		// (add) Token: 0x06013528 RID: 79144
		// (remove) Token: 0x06013529 RID: 79145
		public virtual extern event global::mshtml.HTMLFrameSiteEvents_ondragEventHandler HTMLFrameSiteEvents_Event_ondrag;

		// Token: 0x1400252B RID: 9515
		// (add) Token: 0x0601352A RID: 79146
		// (remove) Token: 0x0601352B RID: 79147
		public virtual extern event global::mshtml.HTMLFrameSiteEvents_ondragendEventHandler HTMLFrameSiteEvents_Event_ondragend;

		// Token: 0x1400252C RID: 9516
		// (add) Token: 0x0601352C RID: 79148
		// (remove) Token: 0x0601352D RID: 79149
		public virtual extern event global::mshtml.HTMLFrameSiteEvents_ondragenterEventHandler HTMLFrameSiteEvents_Event_ondragenter;

		// Token: 0x1400252D RID: 9517
		// (add) Token: 0x0601352E RID: 79150
		// (remove) Token: 0x0601352F RID: 79151
		public virtual extern event global::mshtml.HTMLFrameSiteEvents_ondragoverEventHandler HTMLFrameSiteEvents_Event_ondragover;

		// Token: 0x1400252E RID: 9518
		// (add) Token: 0x06013530 RID: 79152
		// (remove) Token: 0x06013531 RID: 79153
		public virtual extern event global::mshtml.HTMLFrameSiteEvents_ondragleaveEventHandler HTMLFrameSiteEvents_Event_ondragleave;

		// Token: 0x1400252F RID: 9519
		// (add) Token: 0x06013532 RID: 79154
		// (remove) Token: 0x06013533 RID: 79155
		public virtual extern event global::mshtml.HTMLFrameSiteEvents_ondropEventHandler HTMLFrameSiteEvents_Event_ondrop;

		// Token: 0x14002530 RID: 9520
		// (add) Token: 0x06013534 RID: 79156
		// (remove) Token: 0x06013535 RID: 79157
		public virtual extern event global::mshtml.HTMLFrameSiteEvents_onbeforecutEventHandler HTMLFrameSiteEvents_Event_onbeforecut;

		// Token: 0x14002531 RID: 9521
		// (add) Token: 0x06013536 RID: 79158
		// (remove) Token: 0x06013537 RID: 79159
		public virtual extern event global::mshtml.HTMLFrameSiteEvents_oncutEventHandler HTMLFrameSiteEvents_Event_oncut;

		// Token: 0x14002532 RID: 9522
		// (add) Token: 0x06013538 RID: 79160
		// (remove) Token: 0x06013539 RID: 79161
		public virtual extern event global::mshtml.HTMLFrameSiteEvents_onbeforecopyEventHandler HTMLFrameSiteEvents_Event_onbeforecopy;

		// Token: 0x14002533 RID: 9523
		// (add) Token: 0x0601353A RID: 79162
		// (remove) Token: 0x0601353B RID: 79163
		public virtual extern event global::mshtml.HTMLFrameSiteEvents_oncopyEventHandler HTMLFrameSiteEvents_Event_oncopy;

		// Token: 0x14002534 RID: 9524
		// (add) Token: 0x0601353C RID: 79164
		// (remove) Token: 0x0601353D RID: 79165
		public virtual extern event global::mshtml.HTMLFrameSiteEvents_onbeforepasteEventHandler HTMLFrameSiteEvents_Event_onbeforepaste;

		// Token: 0x14002535 RID: 9525
		// (add) Token: 0x0601353E RID: 79166
		// (remove) Token: 0x0601353F RID: 79167
		public virtual extern event global::mshtml.HTMLFrameSiteEvents_onpasteEventHandler HTMLFrameSiteEvents_Event_onpaste;

		// Token: 0x14002536 RID: 9526
		// (add) Token: 0x06013540 RID: 79168
		// (remove) Token: 0x06013541 RID: 79169
		public virtual extern event global::mshtml.HTMLFrameSiteEvents_oncontextmenuEventHandler HTMLFrameSiteEvents_Event_oncontextmenu;

		// Token: 0x14002537 RID: 9527
		// (add) Token: 0x06013542 RID: 79170
		// (remove) Token: 0x06013543 RID: 79171
		public virtual extern event global::mshtml.HTMLFrameSiteEvents_onrowsdeleteEventHandler HTMLFrameSiteEvents_Event_onrowsdelete;

		// Token: 0x14002538 RID: 9528
		// (add) Token: 0x06013544 RID: 79172
		// (remove) Token: 0x06013545 RID: 79173
		public virtual extern event global::mshtml.HTMLFrameSiteEvents_onrowsinsertedEventHandler HTMLFrameSiteEvents_Event_onrowsinserted;

		// Token: 0x14002539 RID: 9529
		// (add) Token: 0x06013546 RID: 79174
		// (remove) Token: 0x06013547 RID: 79175
		public virtual extern event global::mshtml.HTMLFrameSiteEvents_oncellchangeEventHandler HTMLFrameSiteEvents_Event_oncellchange;

		// Token: 0x1400253A RID: 9530
		// (add) Token: 0x06013548 RID: 79176
		// (remove) Token: 0x06013549 RID: 79177
		public virtual extern event global::mshtml.HTMLFrameSiteEvents_onreadystatechangeEventHandler HTMLFrameSiteEvents_Event_onreadystatechange;

		// Token: 0x1400253B RID: 9531
		// (add) Token: 0x0601354A RID: 79178
		// (remove) Token: 0x0601354B RID: 79179
		public virtual extern event global::mshtml.HTMLFrameSiteEvents_onbeforeeditfocusEventHandler HTMLFrameSiteEvents_Event_onbeforeeditfocus;

		// Token: 0x1400253C RID: 9532
		// (add) Token: 0x0601354C RID: 79180
		// (remove) Token: 0x0601354D RID: 79181
		public virtual extern event global::mshtml.HTMLFrameSiteEvents_onlayoutcompleteEventHandler HTMLFrameSiteEvents_Event_onlayoutcomplete;

		// Token: 0x1400253D RID: 9533
		// (add) Token: 0x0601354E RID: 79182
		// (remove) Token: 0x0601354F RID: 79183
		public virtual extern event global::mshtml.HTMLFrameSiteEvents_onpageEventHandler HTMLFrameSiteEvents_Event_onpage;

		// Token: 0x1400253E RID: 9534
		// (add) Token: 0x06013550 RID: 79184
		// (remove) Token: 0x06013551 RID: 79185
		public virtual extern event global::mshtml.HTMLFrameSiteEvents_onbeforedeactivateEventHandler HTMLFrameSiteEvents_Event_onbeforedeactivate;

		// Token: 0x1400253F RID: 9535
		// (add) Token: 0x06013552 RID: 79186
		// (remove) Token: 0x06013553 RID: 79187
		public virtual extern event global::mshtml.HTMLFrameSiteEvents_onbeforeactivateEventHandler HTMLFrameSiteEvents_Event_onbeforeactivate;

		// Token: 0x14002540 RID: 9536
		// (add) Token: 0x06013554 RID: 79188
		// (remove) Token: 0x06013555 RID: 79189
		public virtual extern event global::mshtml.HTMLFrameSiteEvents_onmoveEventHandler HTMLFrameSiteEvents_Event_onmove;

		// Token: 0x14002541 RID: 9537
		// (add) Token: 0x06013556 RID: 79190
		// (remove) Token: 0x06013557 RID: 79191
		public virtual extern event global::mshtml.HTMLFrameSiteEvents_oncontrolselectEventHandler HTMLFrameSiteEvents_Event_oncontrolselect;

		// Token: 0x14002542 RID: 9538
		// (add) Token: 0x06013558 RID: 79192
		// (remove) Token: 0x06013559 RID: 79193
		public virtual extern event global::mshtml.HTMLFrameSiteEvents_onmovestartEventHandler HTMLFrameSiteEvents_Event_onmovestart;

		// Token: 0x14002543 RID: 9539
		// (add) Token: 0x0601355A RID: 79194
		// (remove) Token: 0x0601355B RID: 79195
		public virtual extern event global::mshtml.HTMLFrameSiteEvents_onmoveendEventHandler HTMLFrameSiteEvents_Event_onmoveend;

		// Token: 0x14002544 RID: 9540
		// (add) Token: 0x0601355C RID: 79196
		// (remove) Token: 0x0601355D RID: 79197
		public virtual extern event global::mshtml.HTMLFrameSiteEvents_onresizestartEventHandler HTMLFrameSiteEvents_Event_onresizestart;

		// Token: 0x14002545 RID: 9541
		// (add) Token: 0x0601355E RID: 79198
		// (remove) Token: 0x0601355F RID: 79199
		public virtual extern event global::mshtml.HTMLFrameSiteEvents_onresizeendEventHandler HTMLFrameSiteEvents_Event_onresizeend;

		// Token: 0x14002546 RID: 9542
		// (add) Token: 0x06013560 RID: 79200
		// (remove) Token: 0x06013561 RID: 79201
		public virtual extern event global::mshtml.HTMLFrameSiteEvents_onmouseenterEventHandler HTMLFrameSiteEvents_Event_onmouseenter;

		// Token: 0x14002547 RID: 9543
		// (add) Token: 0x06013562 RID: 79202
		// (remove) Token: 0x06013563 RID: 79203
		public virtual extern event global::mshtml.HTMLFrameSiteEvents_onmouseleaveEventHandler HTMLFrameSiteEvents_Event_onmouseleave;

		// Token: 0x14002548 RID: 9544
		// (add) Token: 0x06013564 RID: 79204
		// (remove) Token: 0x06013565 RID: 79205
		public virtual extern event global::mshtml.HTMLFrameSiteEvents_onmousewheelEventHandler HTMLFrameSiteEvents_Event_onmousewheel;

		// Token: 0x14002549 RID: 9545
		// (add) Token: 0x06013566 RID: 79206
		// (remove) Token: 0x06013567 RID: 79207
		public virtual extern event global::mshtml.HTMLFrameSiteEvents_onactivateEventHandler HTMLFrameSiteEvents_Event_onactivate;

		// Token: 0x1400254A RID: 9546
		// (add) Token: 0x06013568 RID: 79208
		// (remove) Token: 0x06013569 RID: 79209
		public virtual extern event global::mshtml.HTMLFrameSiteEvents_ondeactivateEventHandler HTMLFrameSiteEvents_Event_ondeactivate;

		// Token: 0x1400254B RID: 9547
		// (add) Token: 0x0601356A RID: 79210
		// (remove) Token: 0x0601356B RID: 79211
		public virtual extern event global::mshtml.HTMLFrameSiteEvents_onfocusinEventHandler HTMLFrameSiteEvents_Event_onfocusin;

		// Token: 0x1400254C RID: 9548
		// (add) Token: 0x0601356C RID: 79212
		// (remove) Token: 0x0601356D RID: 79213
		public virtual extern event global::mshtml.HTMLFrameSiteEvents_onfocusoutEventHandler HTMLFrameSiteEvents_Event_onfocusout;

		// Token: 0x1400254D RID: 9549
		// (add) Token: 0x0601356E RID: 79214
		// (remove) Token: 0x0601356F RID: 79215
		public virtual extern event global::mshtml.HTMLFrameSiteEvents_onloadEventHandler HTMLFrameSiteEvents_Event_onload;

		// Token: 0x1400254E RID: 9550
		// (add) Token: 0x06013570 RID: 79216
		// (remove) Token: 0x06013571 RID: 79217
		public virtual extern event global::mshtml.HTMLFrameSiteEvents2_onhelpEventHandler HTMLFrameSiteEvents2_Event_onhelp;

		// Token: 0x1400254F RID: 9551
		// (add) Token: 0x06013572 RID: 79218
		// (remove) Token: 0x06013573 RID: 79219
		public virtual extern event global::mshtml.HTMLFrameSiteEvents2_onclickEventHandler HTMLFrameSiteEvents2_Event_onclick;

		// Token: 0x14002550 RID: 9552
		// (add) Token: 0x06013574 RID: 79220
		// (remove) Token: 0x06013575 RID: 79221
		public virtual extern event global::mshtml.HTMLFrameSiteEvents2_ondblclickEventHandler HTMLFrameSiteEvents2_Event_ondblclick;

		// Token: 0x14002551 RID: 9553
		// (add) Token: 0x06013576 RID: 79222
		// (remove) Token: 0x06013577 RID: 79223
		public virtual extern event global::mshtml.HTMLFrameSiteEvents2_onkeypressEventHandler HTMLFrameSiteEvents2_Event_onkeypress;

		// Token: 0x14002552 RID: 9554
		// (add) Token: 0x06013578 RID: 79224
		// (remove) Token: 0x06013579 RID: 79225
		public virtual extern event global::mshtml.HTMLFrameSiteEvents2_onkeydownEventHandler HTMLFrameSiteEvents2_Event_onkeydown;

		// Token: 0x14002553 RID: 9555
		// (add) Token: 0x0601357A RID: 79226
		// (remove) Token: 0x0601357B RID: 79227
		public virtual extern event global::mshtml.HTMLFrameSiteEvents2_onkeyupEventHandler HTMLFrameSiteEvents2_Event_onkeyup;

		// Token: 0x14002554 RID: 9556
		// (add) Token: 0x0601357C RID: 79228
		// (remove) Token: 0x0601357D RID: 79229
		public virtual extern event global::mshtml.HTMLFrameSiteEvents2_onmouseoutEventHandler HTMLFrameSiteEvents2_Event_onmouseout;

		// Token: 0x14002555 RID: 9557
		// (add) Token: 0x0601357E RID: 79230
		// (remove) Token: 0x0601357F RID: 79231
		public virtual extern event global::mshtml.HTMLFrameSiteEvents2_onmouseoverEventHandler HTMLFrameSiteEvents2_Event_onmouseover;

		// Token: 0x14002556 RID: 9558
		// (add) Token: 0x06013580 RID: 79232
		// (remove) Token: 0x06013581 RID: 79233
		public virtual extern event global::mshtml.HTMLFrameSiteEvents2_onmousemoveEventHandler HTMLFrameSiteEvents2_Event_onmousemove;

		// Token: 0x14002557 RID: 9559
		// (add) Token: 0x06013582 RID: 79234
		// (remove) Token: 0x06013583 RID: 79235
		public virtual extern event global::mshtml.HTMLFrameSiteEvents2_onmousedownEventHandler HTMLFrameSiteEvents2_Event_onmousedown;

		// Token: 0x14002558 RID: 9560
		// (add) Token: 0x06013584 RID: 79236
		// (remove) Token: 0x06013585 RID: 79237
		public virtual extern event global::mshtml.HTMLFrameSiteEvents2_onmouseupEventHandler HTMLFrameSiteEvents2_Event_onmouseup;

		// Token: 0x14002559 RID: 9561
		// (add) Token: 0x06013586 RID: 79238
		// (remove) Token: 0x06013587 RID: 79239
		public virtual extern event global::mshtml.HTMLFrameSiteEvents2_onselectstartEventHandler HTMLFrameSiteEvents2_Event_onselectstart;

		// Token: 0x1400255A RID: 9562
		// (add) Token: 0x06013588 RID: 79240
		// (remove) Token: 0x06013589 RID: 79241
		public virtual extern event global::mshtml.HTMLFrameSiteEvents2_onfilterchangeEventHandler HTMLFrameSiteEvents2_Event_onfilterchange;

		// Token: 0x1400255B RID: 9563
		// (add) Token: 0x0601358A RID: 79242
		// (remove) Token: 0x0601358B RID: 79243
		public virtual extern event global::mshtml.HTMLFrameSiteEvents2_ondragstartEventHandler HTMLFrameSiteEvents2_Event_ondragstart;

		// Token: 0x1400255C RID: 9564
		// (add) Token: 0x0601358C RID: 79244
		// (remove) Token: 0x0601358D RID: 79245
		public virtual extern event global::mshtml.HTMLFrameSiteEvents2_onbeforeupdateEventHandler HTMLFrameSiteEvents2_Event_onbeforeupdate;

		// Token: 0x1400255D RID: 9565
		// (add) Token: 0x0601358E RID: 79246
		// (remove) Token: 0x0601358F RID: 79247
		public virtual extern event global::mshtml.HTMLFrameSiteEvents2_onafterupdateEventHandler HTMLFrameSiteEvents2_Event_onafterupdate;

		// Token: 0x1400255E RID: 9566
		// (add) Token: 0x06013590 RID: 79248
		// (remove) Token: 0x06013591 RID: 79249
		public virtual extern event global::mshtml.HTMLFrameSiteEvents2_onerrorupdateEventHandler HTMLFrameSiteEvents2_Event_onerrorupdate;

		// Token: 0x1400255F RID: 9567
		// (add) Token: 0x06013592 RID: 79250
		// (remove) Token: 0x06013593 RID: 79251
		public virtual extern event global::mshtml.HTMLFrameSiteEvents2_onrowexitEventHandler HTMLFrameSiteEvents2_Event_onrowexit;

		// Token: 0x14002560 RID: 9568
		// (add) Token: 0x06013594 RID: 79252
		// (remove) Token: 0x06013595 RID: 79253
		public virtual extern event global::mshtml.HTMLFrameSiteEvents2_onrowenterEventHandler HTMLFrameSiteEvents2_Event_onrowenter;

		// Token: 0x14002561 RID: 9569
		// (add) Token: 0x06013596 RID: 79254
		// (remove) Token: 0x06013597 RID: 79255
		public virtual extern event global::mshtml.HTMLFrameSiteEvents2_ondatasetchangedEventHandler HTMLFrameSiteEvents2_Event_ondatasetchanged;

		// Token: 0x14002562 RID: 9570
		// (add) Token: 0x06013598 RID: 79256
		// (remove) Token: 0x06013599 RID: 79257
		public virtual extern event global::mshtml.HTMLFrameSiteEvents2_ondataavailableEventHandler HTMLFrameSiteEvents2_Event_ondataavailable;

		// Token: 0x14002563 RID: 9571
		// (add) Token: 0x0601359A RID: 79258
		// (remove) Token: 0x0601359B RID: 79259
		public virtual extern event global::mshtml.HTMLFrameSiteEvents2_ondatasetcompleteEventHandler HTMLFrameSiteEvents2_Event_ondatasetcomplete;

		// Token: 0x14002564 RID: 9572
		// (add) Token: 0x0601359C RID: 79260
		// (remove) Token: 0x0601359D RID: 79261
		public virtual extern event global::mshtml.HTMLFrameSiteEvents2_onlosecaptureEventHandler HTMLFrameSiteEvents2_Event_onlosecapture;

		// Token: 0x14002565 RID: 9573
		// (add) Token: 0x0601359E RID: 79262
		// (remove) Token: 0x0601359F RID: 79263
		public virtual extern event global::mshtml.HTMLFrameSiteEvents2_onpropertychangeEventHandler HTMLFrameSiteEvents2_Event_onpropertychange;

		// Token: 0x14002566 RID: 9574
		// (add) Token: 0x060135A0 RID: 79264
		// (remove) Token: 0x060135A1 RID: 79265
		public virtual extern event global::mshtml.HTMLFrameSiteEvents2_onscrollEventHandler HTMLFrameSiteEvents2_Event_onscroll;

		// Token: 0x14002567 RID: 9575
		// (add) Token: 0x060135A2 RID: 79266
		// (remove) Token: 0x060135A3 RID: 79267
		public virtual extern event global::mshtml.HTMLFrameSiteEvents2_onfocusEventHandler HTMLFrameSiteEvents2_Event_onfocus;

		// Token: 0x14002568 RID: 9576
		// (add) Token: 0x060135A4 RID: 79268
		// (remove) Token: 0x060135A5 RID: 79269
		public virtual extern event global::mshtml.HTMLFrameSiteEvents2_onblurEventHandler HTMLFrameSiteEvents2_Event_onblur;

		// Token: 0x14002569 RID: 9577
		// (add) Token: 0x060135A6 RID: 79270
		// (remove) Token: 0x060135A7 RID: 79271
		public virtual extern event global::mshtml.HTMLFrameSiteEvents2_onresizeEventHandler HTMLFrameSiteEvents2_Event_onresize;

		// Token: 0x1400256A RID: 9578
		// (add) Token: 0x060135A8 RID: 79272
		// (remove) Token: 0x060135A9 RID: 79273
		public virtual extern event global::mshtml.HTMLFrameSiteEvents2_ondragEventHandler HTMLFrameSiteEvents2_Event_ondrag;

		// Token: 0x1400256B RID: 9579
		// (add) Token: 0x060135AA RID: 79274
		// (remove) Token: 0x060135AB RID: 79275
		public virtual extern event global::mshtml.HTMLFrameSiteEvents2_ondragendEventHandler HTMLFrameSiteEvents2_Event_ondragend;

		// Token: 0x1400256C RID: 9580
		// (add) Token: 0x060135AC RID: 79276
		// (remove) Token: 0x060135AD RID: 79277
		public virtual extern event global::mshtml.HTMLFrameSiteEvents2_ondragenterEventHandler HTMLFrameSiteEvents2_Event_ondragenter;

		// Token: 0x1400256D RID: 9581
		// (add) Token: 0x060135AE RID: 79278
		// (remove) Token: 0x060135AF RID: 79279
		public virtual extern event global::mshtml.HTMLFrameSiteEvents2_ondragoverEventHandler HTMLFrameSiteEvents2_Event_ondragover;

		// Token: 0x1400256E RID: 9582
		// (add) Token: 0x060135B0 RID: 79280
		// (remove) Token: 0x060135B1 RID: 79281
		public virtual extern event global::mshtml.HTMLFrameSiteEvents2_ondragleaveEventHandler HTMLFrameSiteEvents2_Event_ondragleave;

		// Token: 0x1400256F RID: 9583
		// (add) Token: 0x060135B2 RID: 79282
		// (remove) Token: 0x060135B3 RID: 79283
		public virtual extern event global::mshtml.HTMLFrameSiteEvents2_ondropEventHandler HTMLFrameSiteEvents2_Event_ondrop;

		// Token: 0x14002570 RID: 9584
		// (add) Token: 0x060135B4 RID: 79284
		// (remove) Token: 0x060135B5 RID: 79285
		public virtual extern event global::mshtml.HTMLFrameSiteEvents2_onbeforecutEventHandler HTMLFrameSiteEvents2_Event_onbeforecut;

		// Token: 0x14002571 RID: 9585
		// (add) Token: 0x060135B6 RID: 79286
		// (remove) Token: 0x060135B7 RID: 79287
		public virtual extern event global::mshtml.HTMLFrameSiteEvents2_oncutEventHandler HTMLFrameSiteEvents2_Event_oncut;

		// Token: 0x14002572 RID: 9586
		// (add) Token: 0x060135B8 RID: 79288
		// (remove) Token: 0x060135B9 RID: 79289
		public virtual extern event global::mshtml.HTMLFrameSiteEvents2_onbeforecopyEventHandler HTMLFrameSiteEvents2_Event_onbeforecopy;

		// Token: 0x14002573 RID: 9587
		// (add) Token: 0x060135BA RID: 79290
		// (remove) Token: 0x060135BB RID: 79291
		public virtual extern event global::mshtml.HTMLFrameSiteEvents2_oncopyEventHandler HTMLFrameSiteEvents2_Event_oncopy;

		// Token: 0x14002574 RID: 9588
		// (add) Token: 0x060135BC RID: 79292
		// (remove) Token: 0x060135BD RID: 79293
		public virtual extern event global::mshtml.HTMLFrameSiteEvents2_onbeforepasteEventHandler HTMLFrameSiteEvents2_Event_onbeforepaste;

		// Token: 0x14002575 RID: 9589
		// (add) Token: 0x060135BE RID: 79294
		// (remove) Token: 0x060135BF RID: 79295
		public virtual extern event global::mshtml.HTMLFrameSiteEvents2_onpasteEventHandler HTMLFrameSiteEvents2_Event_onpaste;

		// Token: 0x14002576 RID: 9590
		// (add) Token: 0x060135C0 RID: 79296
		// (remove) Token: 0x060135C1 RID: 79297
		public virtual extern event global::mshtml.HTMLFrameSiteEvents2_oncontextmenuEventHandler HTMLFrameSiteEvents2_Event_oncontextmenu;

		// Token: 0x14002577 RID: 9591
		// (add) Token: 0x060135C2 RID: 79298
		// (remove) Token: 0x060135C3 RID: 79299
		public virtual extern event global::mshtml.HTMLFrameSiteEvents2_onrowsdeleteEventHandler HTMLFrameSiteEvents2_Event_onrowsdelete;

		// Token: 0x14002578 RID: 9592
		// (add) Token: 0x060135C4 RID: 79300
		// (remove) Token: 0x060135C5 RID: 79301
		public virtual extern event global::mshtml.HTMLFrameSiteEvents2_onrowsinsertedEventHandler HTMLFrameSiteEvents2_Event_onrowsinserted;

		// Token: 0x14002579 RID: 9593
		// (add) Token: 0x060135C6 RID: 79302
		// (remove) Token: 0x060135C7 RID: 79303
		public virtual extern event global::mshtml.HTMLFrameSiteEvents2_oncellchangeEventHandler HTMLFrameSiteEvents2_Event_oncellchange;

		// Token: 0x1400257A RID: 9594
		// (add) Token: 0x060135C8 RID: 79304
		// (remove) Token: 0x060135C9 RID: 79305
		public virtual extern event global::mshtml.HTMLFrameSiteEvents2_onreadystatechangeEventHandler HTMLFrameSiteEvents2_Event_onreadystatechange;

		// Token: 0x1400257B RID: 9595
		// (add) Token: 0x060135CA RID: 79306
		// (remove) Token: 0x060135CB RID: 79307
		public virtual extern event global::mshtml.HTMLFrameSiteEvents2_onlayoutcompleteEventHandler HTMLFrameSiteEvents2_Event_onlayoutcomplete;

		// Token: 0x1400257C RID: 9596
		// (add) Token: 0x060135CC RID: 79308
		// (remove) Token: 0x060135CD RID: 79309
		public virtual extern event global::mshtml.HTMLFrameSiteEvents2_onpageEventHandler HTMLFrameSiteEvents2_Event_onpage;

		// Token: 0x1400257D RID: 9597
		// (add) Token: 0x060135CE RID: 79310
		// (remove) Token: 0x060135CF RID: 79311
		public virtual extern event global::mshtml.HTMLFrameSiteEvents2_onmouseenterEventHandler HTMLFrameSiteEvents2_Event_onmouseenter;

		// Token: 0x1400257E RID: 9598
		// (add) Token: 0x060135D0 RID: 79312
		// (remove) Token: 0x060135D1 RID: 79313
		public virtual extern event global::mshtml.HTMLFrameSiteEvents2_onmouseleaveEventHandler HTMLFrameSiteEvents2_Event_onmouseleave;

		// Token: 0x1400257F RID: 9599
		// (add) Token: 0x060135D2 RID: 79314
		// (remove) Token: 0x060135D3 RID: 79315
		public virtual extern event global::mshtml.HTMLFrameSiteEvents2_onactivateEventHandler HTMLFrameSiteEvents2_Event_onactivate;

		// Token: 0x14002580 RID: 9600
		// (add) Token: 0x060135D4 RID: 79316
		// (remove) Token: 0x060135D5 RID: 79317
		public virtual extern event global::mshtml.HTMLFrameSiteEvents2_ondeactivateEventHandler HTMLFrameSiteEvents2_Event_ondeactivate;

		// Token: 0x14002581 RID: 9601
		// (add) Token: 0x060135D6 RID: 79318
		// (remove) Token: 0x060135D7 RID: 79319
		public virtual extern event global::mshtml.HTMLFrameSiteEvents2_onbeforedeactivateEventHandler HTMLFrameSiteEvents2_Event_onbeforedeactivate;

		// Token: 0x14002582 RID: 9602
		// (add) Token: 0x060135D8 RID: 79320
		// (remove) Token: 0x060135D9 RID: 79321
		public virtual extern event global::mshtml.HTMLFrameSiteEvents2_onbeforeactivateEventHandler HTMLFrameSiteEvents2_Event_onbeforeactivate;

		// Token: 0x14002583 RID: 9603
		// (add) Token: 0x060135DA RID: 79322
		// (remove) Token: 0x060135DB RID: 79323
		public virtual extern event global::mshtml.HTMLFrameSiteEvents2_onfocusinEventHandler HTMLFrameSiteEvents2_Event_onfocusin;

		// Token: 0x14002584 RID: 9604
		// (add) Token: 0x060135DC RID: 79324
		// (remove) Token: 0x060135DD RID: 79325
		public virtual extern event global::mshtml.HTMLFrameSiteEvents2_onfocusoutEventHandler HTMLFrameSiteEvents2_Event_onfocusout;

		// Token: 0x14002585 RID: 9605
		// (add) Token: 0x060135DE RID: 79326
		// (remove) Token: 0x060135DF RID: 79327
		public virtual extern event global::mshtml.HTMLFrameSiteEvents2_onmoveEventHandler HTMLFrameSiteEvents2_Event_onmove;

		// Token: 0x14002586 RID: 9606
		// (add) Token: 0x060135E0 RID: 79328
		// (remove) Token: 0x060135E1 RID: 79329
		public virtual extern event global::mshtml.HTMLFrameSiteEvents2_oncontrolselectEventHandler HTMLFrameSiteEvents2_Event_oncontrolselect;

		// Token: 0x14002587 RID: 9607
		// (add) Token: 0x060135E2 RID: 79330
		// (remove) Token: 0x060135E3 RID: 79331
		public virtual extern event global::mshtml.HTMLFrameSiteEvents2_onmovestartEventHandler HTMLFrameSiteEvents2_Event_onmovestart;

		// Token: 0x14002588 RID: 9608
		// (add) Token: 0x060135E4 RID: 79332
		// (remove) Token: 0x060135E5 RID: 79333
		public virtual extern event global::mshtml.HTMLFrameSiteEvents2_onmoveendEventHandler HTMLFrameSiteEvents2_Event_onmoveend;

		// Token: 0x14002589 RID: 9609
		// (add) Token: 0x060135E6 RID: 79334
		// (remove) Token: 0x060135E7 RID: 79335
		public virtual extern event global::mshtml.HTMLFrameSiteEvents2_onresizestartEventHandler HTMLFrameSiteEvents2_Event_onresizestart;

		// Token: 0x1400258A RID: 9610
		// (add) Token: 0x060135E8 RID: 79336
		// (remove) Token: 0x060135E9 RID: 79337
		public virtual extern event global::mshtml.HTMLFrameSiteEvents2_onresizeendEventHandler HTMLFrameSiteEvents2_Event_onresizeend;

		// Token: 0x1400258B RID: 9611
		// (add) Token: 0x060135EA RID: 79338
		// (remove) Token: 0x060135EB RID: 79339
		public virtual extern event global::mshtml.HTMLFrameSiteEvents2_onmousewheelEventHandler HTMLFrameSiteEvents2_Event_onmousewheel;

		// Token: 0x1400258C RID: 9612
		// (add) Token: 0x060135EC RID: 79340
		// (remove) Token: 0x060135ED RID: 79341
		public virtual extern event global::mshtml.HTMLFrameSiteEvents2_onloadEventHandler HTMLFrameSiteEvents2_Event_onload;
	}
}
