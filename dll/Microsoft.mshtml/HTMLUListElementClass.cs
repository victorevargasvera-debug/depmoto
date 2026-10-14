using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace mshtml
{
	// Token: 0x020004A8 RID: 1192
	[global::System.Runtime.InteropServices.TypeLibType(2)]
	[global::System.Runtime.InteropServices.ComSourceInterfaces("mshtml.HTMLElementEvents\0mshtml.HTMLElementEvents2\0\0")]
	[global::System.Runtime.InteropServices.Guid("3050F269-98B5-11CF-BB82-00AA00BDCE0B")]
	[global::System.Runtime.InteropServices.ClassInterface(0)]
	[global::System.Runtime.InteropServices.ComImport]
	public class HTMLUListElementClass : global::mshtml.DispHTMLUListElement, global::mshtml.HTMLUListElement, global::mshtml.HTMLElementEvents_Event, global::mshtml.IHTMLElement, global::mshtml.IHTMLElement2, global::mshtml.IHTMLElement3, global::mshtml.IHTMLElement4, global::mshtml.IHTMLUniqueName, global::mshtml.IHTMLDOMNode, global::mshtml.IHTMLDOMNode2, global::mshtml.IHTMLListElement, global::mshtml.IHTMLListElement2, global::mshtml.IHTMLUListElement, global::mshtml.HTMLElementEvents2_Event
	{
		// Token: 0x06004D38 RID: 19768
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public extern HTMLUListElementClass();

		// Token: 0x06004D39 RID: 19769
		[global::System.Runtime.InteropServices.DispId(-2147417611)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void setAttribute([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string strAttributeName, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] object AttributeValue, [global::System.Runtime.InteropServices.In] int lFlags = 1);

		// Token: 0x06004D3A RID: 19770
		[global::System.Runtime.InteropServices.DispId(-2147417610)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)]
		public virtual extern object getAttribute([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string strAttributeName, [global::System.Runtime.InteropServices.In] int lFlags = 0);

		// Token: 0x06004D3B RID: 19771
		[global::System.Runtime.InteropServices.DispId(-2147417609)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern bool removeAttribute([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string strAttributeName, [global::System.Runtime.InteropServices.In] int lFlags = 1);

		// Token: 0x1700191B RID: 6427
		// (get) Token: 0x06004D3D RID: 19773
		// (set) Token: 0x06004D3C RID: 19772
		[global::System.Runtime.InteropServices.DispId(-2147417111)]
		public virtual extern string className { [global::System.Runtime.InteropServices.DispId(-2147417111)] [global::System.Runtime.InteropServices.TypeLibFunc(4)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(-2147417111)] [global::System.Runtime.InteropServices.TypeLibFunc(4)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] set; }

		// Token: 0x1700191C RID: 6428
		// (get) Token: 0x06004D3F RID: 19775
		// (set) Token: 0x06004D3E RID: 19774
		[global::System.Runtime.InteropServices.DispId(-2147417110)]
		public virtual extern string id { [global::System.Runtime.InteropServices.DispId(-2147417110)] [global::System.Runtime.InteropServices.TypeLibFunc(4)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(-2147417110)] [global::System.Runtime.InteropServices.TypeLibFunc(4)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] set; }

		// Token: 0x1700191D RID: 6429
		// (get) Token: 0x06004D40 RID: 19776
		[global::System.Runtime.InteropServices.DispId(-2147417108)]
		public virtual extern string tagName { [global::System.Runtime.InteropServices.DispId(-2147417108)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x1700191E RID: 6430
		// (get) Token: 0x06004D41 RID: 19777
		[global::System.Runtime.InteropServices.DispId(-2147418104)]
		public virtual extern global::mshtml.IHTMLElement parentElement { [global::System.Runtime.InteropServices.DispId(-2147418104)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x1700191F RID: 6431
		// (get) Token: 0x06004D42 RID: 19778
		[global::System.Runtime.InteropServices.DispId(-2147418038)]
		public virtual extern global::mshtml.IHTMLStyle style { [global::System.Runtime.InteropServices.TypeLibFunc(1024)] [global::System.Runtime.InteropServices.DispId(-2147418038)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x17001920 RID: 6432
		// (get) Token: 0x06004D44 RID: 19780
		// (set) Token: 0x06004D43 RID: 19779
		[global::System.Runtime.InteropServices.DispId(-2147412099)]
		public virtual extern object onhelp { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412099)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147412099)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x17001921 RID: 6433
		// (get) Token: 0x06004D46 RID: 19782
		// (set) Token: 0x06004D45 RID: 19781
		[global::System.Runtime.InteropServices.DispId(-2147412104)]
		public virtual extern object onclick { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412104)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412104)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x17001922 RID: 6434
		// (get) Token: 0x06004D48 RID: 19784
		// (set) Token: 0x06004D47 RID: 19783
		[global::System.Runtime.InteropServices.DispId(-2147412103)]
		public virtual extern object ondblclick { [global::System.Runtime.InteropServices.DispId(-2147412103)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412103)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x17001923 RID: 6435
		// (get) Token: 0x06004D4A RID: 19786
		// (set) Token: 0x06004D49 RID: 19785
		[global::System.Runtime.InteropServices.DispId(-2147412107)]
		public virtual extern object onkeydown { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412107)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412107)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x17001924 RID: 6436
		// (get) Token: 0x06004D4C RID: 19788
		// (set) Token: 0x06004D4B RID: 19787
		[global::System.Runtime.InteropServices.DispId(-2147412106)]
		public virtual extern object onkeyup { [global::System.Runtime.InteropServices.DispId(-2147412106)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412106)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x17001925 RID: 6437
		// (get) Token: 0x06004D4E RID: 19790
		// (set) Token: 0x06004D4D RID: 19789
		[global::System.Runtime.InteropServices.DispId(-2147412105)]
		public virtual extern object onkeypress { [global::System.Runtime.InteropServices.DispId(-2147412105)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412105)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x17001926 RID: 6438
		// (get) Token: 0x06004D50 RID: 19792
		// (set) Token: 0x06004D4F RID: 19791
		[global::System.Runtime.InteropServices.DispId(-2147412111)]
		public virtual extern object onmouseout { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412111)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147412111)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x17001927 RID: 6439
		// (get) Token: 0x06004D52 RID: 19794
		// (set) Token: 0x06004D51 RID: 19793
		[global::System.Runtime.InteropServices.DispId(-2147412112)]
		public virtual extern object onmouseover { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412112)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412112)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x17001928 RID: 6440
		// (get) Token: 0x06004D54 RID: 19796
		// (set) Token: 0x06004D53 RID: 19795
		[global::System.Runtime.InteropServices.DispId(-2147412108)]
		public virtual extern object onmousemove { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412108)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147412108)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x17001929 RID: 6441
		// (get) Token: 0x06004D56 RID: 19798
		// (set) Token: 0x06004D55 RID: 19797
		[global::System.Runtime.InteropServices.DispId(-2147412110)]
		public virtual extern object onmousedown { [global::System.Runtime.InteropServices.DispId(-2147412110)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412110)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x1700192A RID: 6442
		// (get) Token: 0x06004D58 RID: 19800
		// (set) Token: 0x06004D57 RID: 19799
		[global::System.Runtime.InteropServices.DispId(-2147412109)]
		public virtual extern object onmouseup { [global::System.Runtime.InteropServices.DispId(-2147412109)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147412109)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x1700192B RID: 6443
		// (get) Token: 0x06004D59 RID: 19801
		[global::System.Runtime.InteropServices.DispId(-2147417094)]
		public virtual extern object document { [global::System.Runtime.InteropServices.DispId(-2147417094)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] get; }

		// Token: 0x1700192C RID: 6444
		// (get) Token: 0x06004D5B RID: 19803
		// (set) Token: 0x06004D5A RID: 19802
		[global::System.Runtime.InteropServices.DispId(-2147418043)]
		public virtual extern string title { [global::System.Runtime.InteropServices.DispId(-2147418043)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147418043)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] set; }

		// Token: 0x1700192D RID: 6445
		// (get) Token: 0x06004D5D RID: 19805
		// (set) Token: 0x06004D5C RID: 19804
		[global::System.Runtime.InteropServices.DispId(-2147413012)]
		public virtual extern string language { [global::System.Runtime.InteropServices.DispId(-2147413012)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147413012)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] set; }

		// Token: 0x1700192E RID: 6446
		// (get) Token: 0x06004D5F RID: 19807
		// (set) Token: 0x06004D5E RID: 19806
		[global::System.Runtime.InteropServices.DispId(-2147412075)]
		public virtual extern object onselectstart { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412075)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412075)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x06004D60 RID: 19808
		[global::System.Runtime.InteropServices.DispId(-2147417093)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void scrollIntoView([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] object varargStart);

		// Token: 0x06004D61 RID: 19809
		[global::System.Runtime.InteropServices.DispId(-2147417092)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern bool contains([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLElement pChild);

		// Token: 0x1700192F RID: 6447
		// (get) Token: 0x06004D62 RID: 19810
		[global::System.Runtime.InteropServices.DispId(-2147417088)]
		public virtual extern int sourceIndex { [global::System.Runtime.InteropServices.TypeLibFunc(4)] [global::System.Runtime.InteropServices.DispId(-2147417088)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001930 RID: 6448
		// (get) Token: 0x06004D63 RID: 19811
		[global::System.Runtime.InteropServices.DispId(-2147417087)]
		public virtual extern object recordNumber { [global::System.Runtime.InteropServices.DispId(-2147417087)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; }

		// Token: 0x17001931 RID: 6449
		// (get) Token: 0x06004D65 RID: 19813
		// (set) Token: 0x06004D64 RID: 19812
		[global::System.Runtime.InteropServices.DispId(-2147413103)]
		public virtual extern string lang { [global::System.Runtime.InteropServices.DispId(-2147413103)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(-2147413103)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] set; }

		// Token: 0x17001932 RID: 6450
		// (get) Token: 0x06004D66 RID: 19814
		[global::System.Runtime.InteropServices.DispId(-2147417104)]
		public virtual extern int offsetLeft { [global::System.Runtime.InteropServices.DispId(-2147417104)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001933 RID: 6451
		// (get) Token: 0x06004D67 RID: 19815
		[global::System.Runtime.InteropServices.DispId(-2147417103)]
		public virtual extern int offsetTop { [global::System.Runtime.InteropServices.DispId(-2147417103)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001934 RID: 6452
		// (get) Token: 0x06004D68 RID: 19816
		[global::System.Runtime.InteropServices.DispId(-2147417102)]
		public virtual extern int offsetWidth { [global::System.Runtime.InteropServices.DispId(-2147417102)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001935 RID: 6453
		// (get) Token: 0x06004D69 RID: 19817
		[global::System.Runtime.InteropServices.DispId(-2147417101)]
		public virtual extern int offsetHeight { [global::System.Runtime.InteropServices.DispId(-2147417101)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001936 RID: 6454
		// (get) Token: 0x06004D6A RID: 19818
		[global::System.Runtime.InteropServices.DispId(-2147417100)]
		public virtual extern global::mshtml.IHTMLElement offsetParent { [global::System.Runtime.InteropServices.DispId(-2147417100)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x17001937 RID: 6455
		// (get) Token: 0x06004D6C RID: 19820
		// (set) Token: 0x06004D6B RID: 19819
		[global::System.Runtime.InteropServices.DispId(-2147417086)]
		public virtual extern string innerHTML { [global::System.Runtime.InteropServices.DispId(-2147417086)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(-2147417086)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] set; }

		// Token: 0x17001938 RID: 6456
		// (get) Token: 0x06004D6E RID: 19822
		// (set) Token: 0x06004D6D RID: 19821
		[global::System.Runtime.InteropServices.DispId(-2147417085)]
		public virtual extern string innerText { [global::System.Runtime.InteropServices.DispId(-2147417085)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(-2147417085)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] set; }

		// Token: 0x17001939 RID: 6457
		// (get) Token: 0x06004D70 RID: 19824
		// (set) Token: 0x06004D6F RID: 19823
		[global::System.Runtime.InteropServices.DispId(-2147417084)]
		public virtual extern string outerHTML { [global::System.Runtime.InteropServices.DispId(-2147417084)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(-2147417084)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] set; }

		// Token: 0x1700193A RID: 6458
		// (get) Token: 0x06004D72 RID: 19826
		// (set) Token: 0x06004D71 RID: 19825
		[global::System.Runtime.InteropServices.DispId(-2147417083)]
		public virtual extern string outerText { [global::System.Runtime.InteropServices.DispId(-2147417083)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(-2147417083)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] set; }

		// Token: 0x06004D73 RID: 19827
		[global::System.Runtime.InteropServices.DispId(-2147417082)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void insertAdjacentHTML([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string where, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string html);

		// Token: 0x06004D74 RID: 19828
		[global::System.Runtime.InteropServices.DispId(-2147417081)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void insertAdjacentText([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string where, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string text);

		// Token: 0x1700193B RID: 6459
		// (get) Token: 0x06004D75 RID: 19829
		[global::System.Runtime.InteropServices.DispId(-2147417080)]
		public virtual extern global::mshtml.IHTMLElement parentTextEdit { [global::System.Runtime.InteropServices.DispId(-2147417080)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x1700193C RID: 6460
		// (get) Token: 0x06004D76 RID: 19830
		[global::System.Runtime.InteropServices.DispId(-2147417078)]
		public virtual extern bool isTextEdit { [global::System.Runtime.InteropServices.DispId(-2147417078)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x06004D77 RID: 19831
		[global::System.Runtime.InteropServices.DispId(-2147417079)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void click();

		// Token: 0x1700193D RID: 6461
		// (get) Token: 0x06004D78 RID: 19832
		[global::System.Runtime.InteropServices.DispId(-2147417077)]
		public virtual extern global::mshtml.IHTMLFiltersCollection filters { [global::System.Runtime.InteropServices.DispId(-2147417077)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x1700193E RID: 6462
		// (get) Token: 0x06004D7A RID: 19834
		// (set) Token: 0x06004D79 RID: 19833
		[global::System.Runtime.InteropServices.DispId(-2147412077)]
		public virtual extern object ondragstart { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412077)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147412077)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x06004D7B RID: 19835
		[global::System.Runtime.InteropServices.DispId(-2147417076)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public virtual extern string toString();

		// Token: 0x1700193F RID: 6463
		// (get) Token: 0x06004D7D RID: 19837
		// (set) Token: 0x06004D7C RID: 19836
		[global::System.Runtime.InteropServices.DispId(-2147412091)]
		public virtual extern object onbeforeupdate { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412091)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412091)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x17001940 RID: 6464
		// (get) Token: 0x06004D7F RID: 19839
		// (set) Token: 0x06004D7E RID: 19838
		[global::System.Runtime.InteropServices.DispId(-2147412090)]
		public virtual extern object onafterupdate { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412090)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412090)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x17001941 RID: 6465
		// (get) Token: 0x06004D81 RID: 19841
		// (set) Token: 0x06004D80 RID: 19840
		[global::System.Runtime.InteropServices.DispId(-2147412074)]
		public virtual extern object onerrorupdate { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412074)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147412074)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x17001942 RID: 6466
		// (get) Token: 0x06004D83 RID: 19843
		// (set) Token: 0x06004D82 RID: 19842
		[global::System.Runtime.InteropServices.DispId(-2147412094)]
		public virtual extern object onrowexit { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412094)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412094)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x17001943 RID: 6467
		// (get) Token: 0x06004D85 RID: 19845
		// (set) Token: 0x06004D84 RID: 19844
		[global::System.Runtime.InteropServices.DispId(-2147412093)]
		public virtual extern object onrowenter { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412093)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147412093)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x17001944 RID: 6468
		// (get) Token: 0x06004D87 RID: 19847
		// (set) Token: 0x06004D86 RID: 19846
		[global::System.Runtime.InteropServices.DispId(-2147412072)]
		public virtual extern object ondatasetchanged { [global::System.Runtime.InteropServices.DispId(-2147412072)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147412072)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x17001945 RID: 6469
		// (get) Token: 0x06004D89 RID: 19849
		// (set) Token: 0x06004D88 RID: 19848
		[global::System.Runtime.InteropServices.DispId(-2147412071)]
		public virtual extern object ondataavailable { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412071)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147412071)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x17001946 RID: 6470
		// (get) Token: 0x06004D8B RID: 19851
		// (set) Token: 0x06004D8A RID: 19850
		[global::System.Runtime.InteropServices.DispId(-2147412070)]
		public virtual extern object ondatasetcomplete { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412070)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412070)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x17001947 RID: 6471
		// (get) Token: 0x06004D8D RID: 19853
		// (set) Token: 0x06004D8C RID: 19852
		[global::System.Runtime.InteropServices.DispId(-2147412069)]
		public virtual extern object onfilterchange { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412069)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147412069)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x17001948 RID: 6472
		// (get) Token: 0x06004D8E RID: 19854
		[global::System.Runtime.InteropServices.DispId(-2147417075)]
		public virtual extern object children { [global::System.Runtime.InteropServices.DispId(-2147417075)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] get; }

		// Token: 0x17001949 RID: 6473
		// (get) Token: 0x06004D8F RID: 19855
		[global::System.Runtime.InteropServices.DispId(-2147417074)]
		public virtual extern object all { [global::System.Runtime.InteropServices.DispId(-2147417074)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] get; }

		// Token: 0x1700194A RID: 6474
		// (get) Token: 0x06004D90 RID: 19856
		[global::System.Runtime.InteropServices.DispId(-2147417073)]
		public virtual extern string scopeName { [global::System.Runtime.InteropServices.DispId(-2147417073)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x06004D91 RID: 19857
		[global::System.Runtime.InteropServices.DispId(-2147417072)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void setCapture([global::System.Runtime.InteropServices.In] bool containerCapture = true);

		// Token: 0x06004D92 RID: 19858
		[global::System.Runtime.InteropServices.DispId(-2147417071)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void releaseCapture();

		// Token: 0x1700194B RID: 6475
		// (get) Token: 0x06004D94 RID: 19860
		// (set) Token: 0x06004D93 RID: 19859
		[global::System.Runtime.InteropServices.DispId(-2147412066)]
		public virtual extern object onlosecapture { [global::System.Runtime.InteropServices.DispId(-2147412066)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147412066)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x06004D95 RID: 19861
		[global::System.Runtime.InteropServices.DispId(-2147417070)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public virtual extern string componentFromPoint([global::System.Runtime.InteropServices.In] int x, [global::System.Runtime.InteropServices.In] int y);

		// Token: 0x06004D96 RID: 19862
		[global::System.Runtime.InteropServices.DispId(-2147417069)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void doScroll([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] object component);

		// Token: 0x1700194C RID: 6476
		// (get) Token: 0x06004D98 RID: 19864
		// (set) Token: 0x06004D97 RID: 19863
		[global::System.Runtime.InteropServices.DispId(-2147412081)]
		public virtual extern object onscroll { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412081)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147412081)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x1700194D RID: 6477
		// (get) Token: 0x06004D9A RID: 19866
		// (set) Token: 0x06004D99 RID: 19865
		[global::System.Runtime.InteropServices.DispId(-2147412063)]
		public virtual extern object ondrag { [global::System.Runtime.InteropServices.DispId(-2147412063)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412063)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x1700194E RID: 6478
		// (get) Token: 0x06004D9C RID: 19868
		// (set) Token: 0x06004D9B RID: 19867
		[global::System.Runtime.InteropServices.DispId(-2147412062)]
		public virtual extern object ondragend { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412062)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147412062)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x1700194F RID: 6479
		// (get) Token: 0x06004D9E RID: 19870
		// (set) Token: 0x06004D9D RID: 19869
		[global::System.Runtime.InteropServices.DispId(-2147412061)]
		public virtual extern object ondragenter { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412061)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412061)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x17001950 RID: 6480
		// (get) Token: 0x06004DA0 RID: 19872
		// (set) Token: 0x06004D9F RID: 19871
		[global::System.Runtime.InteropServices.DispId(-2147412060)]
		public virtual extern object ondragover { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412060)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412060)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x17001951 RID: 6481
		// (get) Token: 0x06004DA2 RID: 19874
		// (set) Token: 0x06004DA1 RID: 19873
		[global::System.Runtime.InteropServices.DispId(-2147412059)]
		public virtual extern object ondragleave { [global::System.Runtime.InteropServices.DispId(-2147412059)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147412059)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x17001952 RID: 6482
		// (get) Token: 0x06004DA4 RID: 19876
		// (set) Token: 0x06004DA3 RID: 19875
		[global::System.Runtime.InteropServices.DispId(-2147412058)]
		public virtual extern object ondrop { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412058)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147412058)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x17001953 RID: 6483
		// (get) Token: 0x06004DA6 RID: 19878
		// (set) Token: 0x06004DA5 RID: 19877
		[global::System.Runtime.InteropServices.DispId(-2147412054)]
		public virtual extern object onbeforecut { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412054)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147412054)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x17001954 RID: 6484
		// (get) Token: 0x06004DA8 RID: 19880
		// (set) Token: 0x06004DA7 RID: 19879
		[global::System.Runtime.InteropServices.DispId(-2147412057)]
		public virtual extern object oncut { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412057)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412057)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x17001955 RID: 6485
		// (get) Token: 0x06004DAA RID: 19882
		// (set) Token: 0x06004DA9 RID: 19881
		[global::System.Runtime.InteropServices.DispId(-2147412053)]
		public virtual extern object onbeforecopy { [global::System.Runtime.InteropServices.DispId(-2147412053)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147412053)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x17001956 RID: 6486
		// (get) Token: 0x06004DAC RID: 19884
		// (set) Token: 0x06004DAB RID: 19883
		[global::System.Runtime.InteropServices.DispId(-2147412056)]
		public virtual extern object oncopy { [global::System.Runtime.InteropServices.DispId(-2147412056)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412056)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x17001957 RID: 6487
		// (get) Token: 0x06004DAE RID: 19886
		// (set) Token: 0x06004DAD RID: 19885
		[global::System.Runtime.InteropServices.DispId(-2147412052)]
		public virtual extern object onbeforepaste { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412052)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412052)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x17001958 RID: 6488
		// (get) Token: 0x06004DB0 RID: 19888
		// (set) Token: 0x06004DAF RID: 19887
		[global::System.Runtime.InteropServices.DispId(-2147412055)]
		public virtual extern object onpaste { [global::System.Runtime.InteropServices.DispId(-2147412055)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147412055)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x17001959 RID: 6489
		// (get) Token: 0x06004DB1 RID: 19889
		[global::System.Runtime.InteropServices.DispId(-2147417105)]
		public virtual extern global::mshtml.IHTMLCurrentStyle currentStyle { [global::System.Runtime.InteropServices.TypeLibFunc(1024)] [global::System.Runtime.InteropServices.DispId(-2147417105)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x1700195A RID: 6490
		// (get) Token: 0x06004DB3 RID: 19891
		// (set) Token: 0x06004DB2 RID: 19890
		[global::System.Runtime.InteropServices.DispId(-2147412065)]
		public virtual extern object onpropertychange { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412065)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412065)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x06004DB4 RID: 19892
		[global::System.Runtime.InteropServices.DispId(-2147417068)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		public virtual extern global::mshtml.IHTMLRectCollection getClientRects();

		// Token: 0x06004DB5 RID: 19893
		[global::System.Runtime.InteropServices.DispId(-2147417067)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		public virtual extern global::mshtml.IHTMLRect getBoundingClientRect();

		// Token: 0x06004DB6 RID: 19894
		[global::System.Runtime.InteropServices.DispId(-2147417608)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void setExpression([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string propname, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string expression, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string language = "");

		// Token: 0x06004DB7 RID: 19895
		[global::System.Runtime.InteropServices.DispId(-2147417607)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)]
		public virtual extern object getExpression([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string propname);

		// Token: 0x06004DB8 RID: 19896
		[global::System.Runtime.InteropServices.DispId(-2147417606)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern bool removeExpression([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string propname);

		// Token: 0x1700195B RID: 6491
		// (get) Token: 0x06004DBA RID: 19898
		// (set) Token: 0x06004DB9 RID: 19897
		[global::System.Runtime.InteropServices.DispId(-2147418097)]
		public virtual extern short tabIndex { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147418097)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(-2147418097)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] set; }

		// Token: 0x06004DBB RID: 19899
		[global::System.Runtime.InteropServices.DispId(-2147416112)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void focus();

		// Token: 0x1700195C RID: 6492
		// (get) Token: 0x06004DBD RID: 19901
		// (set) Token: 0x06004DBC RID: 19900
		[global::System.Runtime.InteropServices.DispId(-2147416107)]
		public virtual extern string accessKey { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147416107)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(-2147416107)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] set; }

		// Token: 0x1700195D RID: 6493
		// (get) Token: 0x06004DBF RID: 19903
		// (set) Token: 0x06004DBE RID: 19902
		[global::System.Runtime.InteropServices.DispId(-2147412097)]
		public virtual extern object onblur { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412097)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412097)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x1700195E RID: 6494
		// (get) Token: 0x06004DC1 RID: 19905
		// (set) Token: 0x06004DC0 RID: 19904
		[global::System.Runtime.InteropServices.DispId(-2147412098)]
		public virtual extern object onfocus { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412098)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147412098)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x1700195F RID: 6495
		// (get) Token: 0x06004DC3 RID: 19907
		// (set) Token: 0x06004DC2 RID: 19906
		[global::System.Runtime.InteropServices.DispId(-2147412076)]
		public virtual extern object onresize { [global::System.Runtime.InteropServices.DispId(-2147412076)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147412076)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x06004DC4 RID: 19908
		[global::System.Runtime.InteropServices.DispId(-2147416110)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void blur();

		// Token: 0x06004DC5 RID: 19909
		[global::System.Runtime.InteropServices.DispId(-2147416095)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void addFilter([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IUnknown)] [global::System.Runtime.InteropServices.In] object pUnk);

		// Token: 0x06004DC6 RID: 19910
		[global::System.Runtime.InteropServices.DispId(-2147416094)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void removeFilter([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IUnknown)] [global::System.Runtime.InteropServices.In] object pUnk);

		// Token: 0x17001960 RID: 6496
		// (get) Token: 0x06004DC7 RID: 19911
		[global::System.Runtime.InteropServices.DispId(-2147416093)]
		public virtual extern int clientHeight { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147416093)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001961 RID: 6497
		// (get) Token: 0x06004DC8 RID: 19912
		[global::System.Runtime.InteropServices.DispId(-2147416092)]
		public virtual extern int clientWidth { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147416092)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001962 RID: 6498
		// (get) Token: 0x06004DC9 RID: 19913
		[global::System.Runtime.InteropServices.DispId(-2147416091)]
		public virtual extern int clientTop { [global::System.Runtime.InteropServices.DispId(-2147416091)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001963 RID: 6499
		// (get) Token: 0x06004DCA RID: 19914
		[global::System.Runtime.InteropServices.DispId(-2147416090)]
		public virtual extern int clientLeft { [global::System.Runtime.InteropServices.DispId(-2147416090)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x06004DCB RID: 19915
		[global::System.Runtime.InteropServices.DispId(-2147417605)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern bool attachEvent([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string @event, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] [global::System.Runtime.InteropServices.In] object pdisp);

		// Token: 0x06004DCC RID: 19916
		[global::System.Runtime.InteropServices.DispId(-2147417604)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void detachEvent([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string @event, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] [global::System.Runtime.InteropServices.In] object pdisp);

		// Token: 0x17001964 RID: 6500
		// (get) Token: 0x06004DCD RID: 19917
		[global::System.Runtime.InteropServices.DispId(-2147412996)]
		public virtual extern object readyState { [global::System.Runtime.InteropServices.DispId(-2147412996)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; }

		// Token: 0x17001965 RID: 6501
		// (get) Token: 0x06004DCF RID: 19919
		// (set) Token: 0x06004DCE RID: 19918
		[global::System.Runtime.InteropServices.DispId(-2147412087)]
		public virtual extern object onreadystatechange { [global::System.Runtime.InteropServices.DispId(-2147412087)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412087)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x17001966 RID: 6502
		// (get) Token: 0x06004DD1 RID: 19921
		// (set) Token: 0x06004DD0 RID: 19920
		[global::System.Runtime.InteropServices.DispId(-2147412050)]
		public virtual extern object onrowsdelete { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412050)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412050)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x17001967 RID: 6503
		// (get) Token: 0x06004DD3 RID: 19923
		// (set) Token: 0x06004DD2 RID: 19922
		[global::System.Runtime.InteropServices.DispId(-2147412049)]
		public virtual extern object onrowsinserted { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412049)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147412049)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x17001968 RID: 6504
		// (get) Token: 0x06004DD5 RID: 19925
		// (set) Token: 0x06004DD4 RID: 19924
		[global::System.Runtime.InteropServices.DispId(-2147412048)]
		public virtual extern object oncellchange { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412048)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147412048)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x17001969 RID: 6505
		// (get) Token: 0x06004DD7 RID: 19927
		// (set) Token: 0x06004DD6 RID: 19926
		[global::System.Runtime.InteropServices.DispId(-2147412995)]
		public virtual extern string dir { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412995)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(-2147412995)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] set; }

		// Token: 0x06004DD8 RID: 19928
		[global::System.Runtime.InteropServices.DispId(-2147417056)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)]
		public virtual extern object createControlRange();

		// Token: 0x1700196A RID: 6506
		// (get) Token: 0x06004DD9 RID: 19929
		[global::System.Runtime.InteropServices.DispId(-2147417055)]
		public virtual extern int scrollHeight { [global::System.Runtime.InteropServices.DispId(-2147417055)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700196B RID: 6507
		// (get) Token: 0x06004DDA RID: 19930
		[global::System.Runtime.InteropServices.DispId(-2147417054)]
		public virtual extern int scrollWidth { [global::System.Runtime.InteropServices.DispId(-2147417054)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700196C RID: 6508
		// (get) Token: 0x06004DDC RID: 19932
		// (set) Token: 0x06004DDB RID: 19931
		[global::System.Runtime.InteropServices.DispId(-2147417053)]
		public virtual extern int scrollTop { [global::System.Runtime.InteropServices.DispId(-2147417053)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147417053)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700196D RID: 6509
		// (get) Token: 0x06004DDE RID: 19934
		// (set) Token: 0x06004DDD RID: 19933
		[global::System.Runtime.InteropServices.DispId(-2147417052)]
		public virtual extern int scrollLeft { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147417052)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147417052)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] set; }

		// Token: 0x06004DDF RID: 19935
		[global::System.Runtime.InteropServices.DispId(-2147417050)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void clearAttributes();

		// Token: 0x1700196E RID: 6510
		// (get) Token: 0x06004DE1 RID: 19937
		// (set) Token: 0x06004DE0 RID: 19936
		[global::System.Runtime.InteropServices.DispId(-2147412047)]
		public virtual extern object oncontextmenu { [global::System.Runtime.InteropServices.DispId(-2147412047)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412047)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x06004DE2 RID: 19938
		[global::System.Runtime.InteropServices.DispId(-2147417043)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		public virtual extern global::mshtml.IHTMLElement insertAdjacentElement([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string where, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLElement insertedElement);

		// Token: 0x06004DE3 RID: 19939
		[global::System.Runtime.InteropServices.DispId(-2147417047)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		public virtual extern global::mshtml.IHTMLElement applyElement([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLElement apply, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string where);

		// Token: 0x06004DE4 RID: 19940
		[global::System.Runtime.InteropServices.DispId(-2147417042)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public virtual extern string getAdjacentText([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string where);

		// Token: 0x06004DE5 RID: 19941
		[global::System.Runtime.InteropServices.DispId(-2147417041)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public virtual extern string replaceAdjacentText([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string where, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string newText);

		// Token: 0x1700196F RID: 6511
		// (get) Token: 0x06004DE6 RID: 19942
		[global::System.Runtime.InteropServices.DispId(-2147417040)]
		public virtual extern bool canHaveChildren { [global::System.Runtime.InteropServices.DispId(-2147417040)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x06004DE7 RID: 19943
		[global::System.Runtime.InteropServices.DispId(-2147417032)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern int addBehavior([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string bstrUrl, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object pvarFactory);

		// Token: 0x06004DE8 RID: 19944
		[global::System.Runtime.InteropServices.DispId(-2147417031)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern bool removeBehavior([global::System.Runtime.InteropServices.In] int cookie);

		// Token: 0x17001970 RID: 6512
		// (get) Token: 0x06004DE9 RID: 19945
		[global::System.Runtime.InteropServices.DispId(-2147417048)]
		public virtual extern global::mshtml.IHTMLStyle runtimeStyle { [global::System.Runtime.InteropServices.TypeLibFunc(1024)] [global::System.Runtime.InteropServices.DispId(-2147417048)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x17001971 RID: 6513
		// (get) Token: 0x06004DEA RID: 19946
		[global::System.Runtime.InteropServices.DispId(-2147417030)]
		public virtual extern object behaviorUrns { [global::System.Runtime.InteropServices.DispId(-2147417030)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] get; }

		// Token: 0x17001972 RID: 6514
		// (get) Token: 0x06004DEC RID: 19948
		// (set) Token: 0x06004DEB RID: 19947
		[global::System.Runtime.InteropServices.DispId(-2147417029)]
		public virtual extern string tagUrn { [global::System.Runtime.InteropServices.DispId(-2147417029)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(-2147417029)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] set; }

		// Token: 0x17001973 RID: 6515
		// (get) Token: 0x06004DEE RID: 19950
		// (set) Token: 0x06004DED RID: 19949
		[global::System.Runtime.InteropServices.DispId(-2147412043)]
		public virtual extern object onbeforeeditfocus { [global::System.Runtime.InteropServices.DispId(-2147412043)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147412043)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x17001974 RID: 6516
		// (get) Token: 0x06004DEF RID: 19951
		[global::System.Runtime.InteropServices.DispId(-2147417028)]
		public virtual extern int readyStateValue { [global::System.Runtime.InteropServices.TypeLibFunc(65)] [global::System.Runtime.InteropServices.DispId(-2147417028)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x06004DF0 RID: 19952
		[global::System.Runtime.InteropServices.DispId(-2147417027)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		public virtual extern global::mshtml.IHTMLElementCollection getElementsByTagName([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string v);

		// Token: 0x06004DF1 RID: 19953
		[global::System.Runtime.InteropServices.DispId(-2147417016)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void mergeAttributes([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLElement mergeThis, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object pvarFlags);

		// Token: 0x17001975 RID: 6517
		// (get) Token: 0x06004DF2 RID: 19954
		[global::System.Runtime.InteropServices.DispId(-2147417015)]
		public virtual extern bool isMultiLine { [global::System.Runtime.InteropServices.DispId(-2147417015)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001976 RID: 6518
		// (get) Token: 0x06004DF3 RID: 19955
		[global::System.Runtime.InteropServices.DispId(-2147417014)]
		public virtual extern bool canHaveHTML { [global::System.Runtime.InteropServices.DispId(-2147417014)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001977 RID: 6519
		// (get) Token: 0x06004DF5 RID: 19957
		// (set) Token: 0x06004DF4 RID: 19956
		[global::System.Runtime.InteropServices.DispId(-2147412039)]
		public virtual extern object onlayoutcomplete { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412039)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412039)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x17001978 RID: 6520
		// (get) Token: 0x06004DF7 RID: 19959
		// (set) Token: 0x06004DF6 RID: 19958
		[global::System.Runtime.InteropServices.DispId(-2147412038)]
		public virtual extern object onpage { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412038)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412038)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x17001979 RID: 6521
		// (get) Token: 0x06004DF9 RID: 19961
		// (set) Token: 0x06004DF8 RID: 19960
		[global::System.Runtime.InteropServices.DispId(-2147417012)]
		public virtual extern bool inflateBlock { [global::System.Runtime.InteropServices.TypeLibFunc(1089)] [global::System.Runtime.InteropServices.DispId(-2147417012)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.TypeLibFunc(1089)] [global::System.Runtime.InteropServices.DispId(-2147417012)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700197A RID: 6522
		// (get) Token: 0x06004DFB RID: 19963
		// (set) Token: 0x06004DFA RID: 19962
		[global::System.Runtime.InteropServices.DispId(-2147412035)]
		public virtual extern object onbeforedeactivate { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412035)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412035)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x06004DFC RID: 19964
		[global::System.Runtime.InteropServices.DispId(-2147417011)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void setActive();

		// Token: 0x1700197B RID: 6523
		// (get) Token: 0x06004DFE RID: 19966
		// (set) Token: 0x06004DFD RID: 19965
		[global::System.Runtime.InteropServices.DispId(-2147412950)]
		public virtual extern string contentEditable { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412950)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(-2147412950)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] set; }

		// Token: 0x1700197C RID: 6524
		// (get) Token: 0x06004DFF RID: 19967
		[global::System.Runtime.InteropServices.DispId(-2147417010)]
		public virtual extern bool isContentEditable { [global::System.Runtime.InteropServices.DispId(-2147417010)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700197D RID: 6525
		// (get) Token: 0x06004E01 RID: 19969
		// (set) Token: 0x06004E00 RID: 19968
		[global::System.Runtime.InteropServices.DispId(-2147412949)]
		public virtual extern bool hideFocus { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412949)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412949)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700197E RID: 6526
		// (get) Token: 0x06004E03 RID: 19971
		// (set) Token: 0x06004E02 RID: 19970
		[global::System.Runtime.InteropServices.DispId(-2147418036)]
		public virtual extern bool disabled { [global::System.Runtime.InteropServices.DispId(-2147418036)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(-2147418036)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700197F RID: 6527
		// (get) Token: 0x06004E04 RID: 19972
		[global::System.Runtime.InteropServices.DispId(-2147417007)]
		public virtual extern bool isDisabled { [global::System.Runtime.InteropServices.DispId(-2147417007)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001980 RID: 6528
		// (get) Token: 0x06004E06 RID: 19974
		// (set) Token: 0x06004E05 RID: 19973
		[global::System.Runtime.InteropServices.DispId(-2147412034)]
		public virtual extern object onmove { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412034)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147412034)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x17001981 RID: 6529
		// (get) Token: 0x06004E08 RID: 19976
		// (set) Token: 0x06004E07 RID: 19975
		[global::System.Runtime.InteropServices.DispId(-2147412033)]
		public virtual extern object oncontrolselect { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412033)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412033)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x06004E09 RID: 19977
		[global::System.Runtime.InteropServices.DispId(-2147417006)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern bool FireEvent([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string bstrEventName, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object pvarEventObject);

		// Token: 0x17001982 RID: 6530
		// (get) Token: 0x06004E0B RID: 19979
		// (set) Token: 0x06004E0A RID: 19978
		[global::System.Runtime.InteropServices.DispId(-2147412029)]
		public virtual extern object onresizestart { [global::System.Runtime.InteropServices.DispId(-2147412029)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147412029)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x17001983 RID: 6531
		// (get) Token: 0x06004E0D RID: 19981
		// (set) Token: 0x06004E0C RID: 19980
		[global::System.Runtime.InteropServices.DispId(-2147412028)]
		public virtual extern object onresizeend { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412028)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412028)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x17001984 RID: 6532
		// (get) Token: 0x06004E0F RID: 19983
		// (set) Token: 0x06004E0E RID: 19982
		[global::System.Runtime.InteropServices.DispId(-2147412031)]
		public virtual extern object onmovestart { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412031)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147412031)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x17001985 RID: 6533
		// (get) Token: 0x06004E11 RID: 19985
		// (set) Token: 0x06004E10 RID: 19984
		[global::System.Runtime.InteropServices.DispId(-2147412030)]
		public virtual extern object onmoveend { [global::System.Runtime.InteropServices.DispId(-2147412030)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412030)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x17001986 RID: 6534
		// (get) Token: 0x06004E13 RID: 19987
		// (set) Token: 0x06004E12 RID: 19986
		[global::System.Runtime.InteropServices.DispId(-2147412027)]
		public virtual extern object onmouseenter { [global::System.Runtime.InteropServices.DispId(-2147412027)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147412027)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x17001987 RID: 6535
		// (get) Token: 0x06004E15 RID: 19989
		// (set) Token: 0x06004E14 RID: 19988
		[global::System.Runtime.InteropServices.DispId(-2147412026)]
		public virtual extern object onmouseleave { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412026)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147412026)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x17001988 RID: 6536
		// (get) Token: 0x06004E17 RID: 19991
		// (set) Token: 0x06004E16 RID: 19990
		[global::System.Runtime.InteropServices.DispId(-2147412025)]
		public virtual extern object onactivate { [global::System.Runtime.InteropServices.DispId(-2147412025)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412025)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x17001989 RID: 6537
		// (get) Token: 0x06004E19 RID: 19993
		// (set) Token: 0x06004E18 RID: 19992
		[global::System.Runtime.InteropServices.DispId(-2147412024)]
		public virtual extern object ondeactivate { [global::System.Runtime.InteropServices.DispId(-2147412024)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147412024)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x06004E1A RID: 19994
		[global::System.Runtime.InteropServices.DispId(-2147417005)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern bool dragDrop();

		// Token: 0x1700198A RID: 6538
		// (get) Token: 0x06004E1B RID: 19995
		[global::System.Runtime.InteropServices.DispId(-2147417004)]
		public virtual extern int glyphMode { [global::System.Runtime.InteropServices.TypeLibFunc(1089)] [global::System.Runtime.InteropServices.DispId(-2147417004)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700198B RID: 6539
		// (get) Token: 0x06004E1D RID: 19997
		// (set) Token: 0x06004E1C RID: 19996
		[global::System.Runtime.InteropServices.DispId(-2147412036)]
		public virtual extern object onmousewheel { [global::System.Runtime.InteropServices.DispId(-2147412036)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147412036)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x06004E1E RID: 19998
		[global::System.Runtime.InteropServices.DispId(-2147417000)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void normalize();

		// Token: 0x06004E1F RID: 19999
		[global::System.Runtime.InteropServices.DispId(-2147417003)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		public virtual extern global::mshtml.IHTMLDOMAttribute getAttributeNode([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string bstrName);

		// Token: 0x06004E20 RID: 20000
		[global::System.Runtime.InteropServices.DispId(-2147417002)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		public virtual extern global::mshtml.IHTMLDOMAttribute setAttributeNode([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLDOMAttribute pattr);

		// Token: 0x06004E21 RID: 20001
		[global::System.Runtime.InteropServices.DispId(-2147417001)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		public virtual extern global::mshtml.IHTMLDOMAttribute removeAttributeNode([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLDOMAttribute pattr);

		// Token: 0x1700198C RID: 6540
		// (get) Token: 0x06004E23 RID: 20003
		// (set) Token: 0x06004E22 RID: 20002
		[global::System.Runtime.InteropServices.DispId(-2147412022)]
		public virtual extern object onbeforeactivate { [global::System.Runtime.InteropServices.DispId(-2147412022)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412022)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x1700198D RID: 6541
		// (get) Token: 0x06004E25 RID: 20005
		// (set) Token: 0x06004E24 RID: 20004
		[global::System.Runtime.InteropServices.DispId(-2147412021)]
		public virtual extern object onfocusin { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412021)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147412021)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x1700198E RID: 6542
		// (get) Token: 0x06004E27 RID: 20007
		// (set) Token: 0x06004E26 RID: 20006
		[global::System.Runtime.InteropServices.DispId(-2147412020)]
		public virtual extern object onfocusout { [global::System.Runtime.InteropServices.DispId(-2147412020)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412020)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x1700198F RID: 6543
		// (get) Token: 0x06004E28 RID: 20008
		[global::System.Runtime.InteropServices.DispId(-2147417058)]
		public virtual extern int uniqueNumber { [global::System.Runtime.InteropServices.DispId(-2147417058)] [global::System.Runtime.InteropServices.TypeLibFunc(64)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001990 RID: 6544
		// (get) Token: 0x06004E29 RID: 20009
		[global::System.Runtime.InteropServices.DispId(-2147417057)]
		public virtual extern string uniqueID { [global::System.Runtime.InteropServices.DispId(-2147417057)] [global::System.Runtime.InteropServices.TypeLibFunc(64)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x17001991 RID: 6545
		// (get) Token: 0x06004E2A RID: 20010
		[global::System.Runtime.InteropServices.DispId(-2147417066)]
		public virtual extern int nodeType { [global::System.Runtime.InteropServices.DispId(-2147417066)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001992 RID: 6546
		// (get) Token: 0x06004E2B RID: 20011
		[global::System.Runtime.InteropServices.DispId(-2147417065)]
		public virtual extern global::mshtml.IHTMLDOMNode parentNode { [global::System.Runtime.InteropServices.DispId(-2147417065)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x06004E2C RID: 20012
		[global::System.Runtime.InteropServices.DispId(-2147417064)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern bool hasChildNodes();

		// Token: 0x17001993 RID: 6547
		// (get) Token: 0x06004E2D RID: 20013
		[global::System.Runtime.InteropServices.DispId(-2147417063)]
		public virtual extern object childNodes { [global::System.Runtime.InteropServices.DispId(-2147417063)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] get; }

		// Token: 0x17001994 RID: 6548
		// (get) Token: 0x06004E2E RID: 20014
		[global::System.Runtime.InteropServices.DispId(-2147417062)]
		public virtual extern object attributes { [global::System.Runtime.InteropServices.DispId(-2147417062)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] get; }

		// Token: 0x06004E2F RID: 20015
		[global::System.Runtime.InteropServices.DispId(-2147417061)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		public virtual extern global::mshtml.IHTMLDOMNode insertBefore([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLDOMNode newChild, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] object refChild);

		// Token: 0x06004E30 RID: 20016
		[global::System.Runtime.InteropServices.DispId(-2147417060)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		public virtual extern global::mshtml.IHTMLDOMNode removeChild([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLDOMNode oldChild);

		// Token: 0x06004E31 RID: 20017
		[global::System.Runtime.InteropServices.DispId(-2147417059)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		public virtual extern global::mshtml.IHTMLDOMNode replaceChild([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLDOMNode newChild, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLDOMNode oldChild);

		// Token: 0x06004E32 RID: 20018
		[global::System.Runtime.InteropServices.DispId(-2147417051)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		public virtual extern global::mshtml.IHTMLDOMNode cloneNode([global::System.Runtime.InteropServices.In] bool fDeep);

		// Token: 0x06004E33 RID: 20019
		[global::System.Runtime.InteropServices.DispId(-2147417046)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		public virtual extern global::mshtml.IHTMLDOMNode removeNode([global::System.Runtime.InteropServices.In] bool fDeep = false);

		// Token: 0x06004E34 RID: 20020
		[global::System.Runtime.InteropServices.DispId(-2147417044)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		public virtual extern global::mshtml.IHTMLDOMNode swapNode([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLDOMNode otherNode);

		// Token: 0x06004E35 RID: 20021
		[global::System.Runtime.InteropServices.DispId(-2147417045)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		public virtual extern global::mshtml.IHTMLDOMNode replaceNode([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLDOMNode replacement);

		// Token: 0x06004E36 RID: 20022
		[global::System.Runtime.InteropServices.DispId(-2147417039)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		public virtual extern global::mshtml.IHTMLDOMNode appendChild([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLDOMNode newChild);

		// Token: 0x17001995 RID: 6549
		// (get) Token: 0x06004E37 RID: 20023
		[global::System.Runtime.InteropServices.DispId(-2147417038)]
		public virtual extern string nodeName { [global::System.Runtime.InteropServices.DispId(-2147417038)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x17001996 RID: 6550
		// (get) Token: 0x06004E39 RID: 20025
		// (set) Token: 0x06004E38 RID: 20024
		[global::System.Runtime.InteropServices.DispId(-2147417037)]
		public virtual extern object nodeValue { [global::System.Runtime.InteropServices.DispId(-2147417037)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147417037)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x17001997 RID: 6551
		// (get) Token: 0x06004E3A RID: 20026
		[global::System.Runtime.InteropServices.DispId(-2147417036)]
		public virtual extern global::mshtml.IHTMLDOMNode firstChild { [global::System.Runtime.InteropServices.DispId(-2147417036)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x17001998 RID: 6552
		// (get) Token: 0x06004E3B RID: 20027
		[global::System.Runtime.InteropServices.DispId(-2147417035)]
		public virtual extern global::mshtml.IHTMLDOMNode lastChild { [global::System.Runtime.InteropServices.DispId(-2147417035)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x17001999 RID: 6553
		// (get) Token: 0x06004E3C RID: 20028
		[global::System.Runtime.InteropServices.DispId(-2147417034)]
		public virtual extern global::mshtml.IHTMLDOMNode previousSibling { [global::System.Runtime.InteropServices.DispId(-2147417034)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x1700199A RID: 6554
		// (get) Token: 0x06004E3D RID: 20029
		[global::System.Runtime.InteropServices.DispId(-2147417033)]
		public virtual extern global::mshtml.IHTMLDOMNode nextSibling { [global::System.Runtime.InteropServices.DispId(-2147417033)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x1700199B RID: 6555
		// (get) Token: 0x06004E3E RID: 20030
		[global::System.Runtime.InteropServices.DispId(-2147416999)]
		public virtual extern object ownerDocument { [global::System.Runtime.InteropServices.DispId(-2147416999)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] get; }

		// Token: 0x1700199C RID: 6556
		// (get) Token: 0x06004E40 RID: 20032
		// (set) Token: 0x06004E3F RID: 20031
		[global::System.Runtime.InteropServices.DispId(1001)]
		public virtual extern bool compact { [global::System.Runtime.InteropServices.DispId(1001)] [global::System.Runtime.InteropServices.TypeLibFunc(4)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(1001)] [global::System.Runtime.InteropServices.TypeLibFunc(4)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700199D RID: 6557
		// (get) Token: 0x06004E42 RID: 20034
		// (set) Token: 0x06004E41 RID: 20033
		[global::System.Runtime.InteropServices.DispId(-2147413095)]
		public virtual extern string type { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147413095)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147413095)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] set; }

		// Token: 0x06004E43 RID: 20035
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void IHTMLElement_setAttribute([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string strAttributeName, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] object AttributeValue, [global::System.Runtime.InteropServices.In] int lFlags = 1);

		// Token: 0x06004E44 RID: 20036
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)]
		public virtual extern object IHTMLElement_getAttribute([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string strAttributeName, [global::System.Runtime.InteropServices.In] int lFlags = 0);

		// Token: 0x06004E45 RID: 20037
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern bool IHTMLElement_removeAttribute([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string strAttributeName, [global::System.Runtime.InteropServices.In] int lFlags = 1);

		// Token: 0x1700199E RID: 6558
		// (get) Token: 0x06004E47 RID: 20039
		// (set) Token: 0x06004E46 RID: 20038
		public virtual extern string IHTMLElement_className { [global::System.Runtime.InteropServices.TypeLibFunc(4)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.TypeLibFunc(4)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700199F RID: 6559
		// (get) Token: 0x06004E49 RID: 20041
		// (set) Token: 0x06004E48 RID: 20040
		public virtual extern string IHTMLElement_id { [global::System.Runtime.InteropServices.TypeLibFunc(4)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.TypeLibFunc(4)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170019A0 RID: 6560
		// (get) Token: 0x06004E4A RID: 20042
		public virtual extern string IHTMLElement_tagName { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x170019A1 RID: 6561
		// (get) Token: 0x06004E4B RID: 20043
		public virtual extern global::mshtml.IHTMLElement IHTMLElement_parentElement { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x170019A2 RID: 6562
		// (get) Token: 0x06004E4C RID: 20044
		public virtual extern global::mshtml.IHTMLStyle IHTMLElement_style { [global::System.Runtime.InteropServices.TypeLibFunc(1024)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x170019A3 RID: 6563
		// (get) Token: 0x06004E4E RID: 20046
		// (set) Token: 0x06004E4D RID: 20045
		public virtual extern object IHTMLElement_onhelp { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170019A4 RID: 6564
		// (get) Token: 0x06004E50 RID: 20048
		// (set) Token: 0x06004E4F RID: 20047
		public virtual extern object IHTMLElement_onclick { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170019A5 RID: 6565
		// (get) Token: 0x06004E52 RID: 20050
		// (set) Token: 0x06004E51 RID: 20049
		public virtual extern object IHTMLElement_ondblclick { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170019A6 RID: 6566
		// (get) Token: 0x06004E54 RID: 20052
		// (set) Token: 0x06004E53 RID: 20051
		public virtual extern object IHTMLElement_onkeydown { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170019A7 RID: 6567
		// (get) Token: 0x06004E56 RID: 20054
		// (set) Token: 0x06004E55 RID: 20053
		public virtual extern object IHTMLElement_onkeyup { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170019A8 RID: 6568
		// (get) Token: 0x06004E58 RID: 20056
		// (set) Token: 0x06004E57 RID: 20055
		public virtual extern object IHTMLElement_onkeypress { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170019A9 RID: 6569
		// (get) Token: 0x06004E5A RID: 20058
		// (set) Token: 0x06004E59 RID: 20057
		public virtual extern object IHTMLElement_onmouseout { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170019AA RID: 6570
		// (get) Token: 0x06004E5C RID: 20060
		// (set) Token: 0x06004E5B RID: 20059
		public virtual extern object IHTMLElement_onmouseover { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170019AB RID: 6571
		// (get) Token: 0x06004E5E RID: 20062
		// (set) Token: 0x06004E5D RID: 20061
		public virtual extern object IHTMLElement_onmousemove { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170019AC RID: 6572
		// (get) Token: 0x06004E60 RID: 20064
		// (set) Token: 0x06004E5F RID: 20063
		public virtual extern object IHTMLElement_onmousedown { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170019AD RID: 6573
		// (get) Token: 0x06004E62 RID: 20066
		// (set) Token: 0x06004E61 RID: 20065
		public virtual extern object IHTMLElement_onmouseup { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170019AE RID: 6574
		// (get) Token: 0x06004E63 RID: 20067
		public virtual extern object IHTMLElement_document { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] get; }

		// Token: 0x170019AF RID: 6575
		// (get) Token: 0x06004E65 RID: 20069
		// (set) Token: 0x06004E64 RID: 20068
		public virtual extern string IHTMLElement_title { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170019B0 RID: 6576
		// (get) Token: 0x06004E67 RID: 20071
		// (set) Token: 0x06004E66 RID: 20070
		public virtual extern string IHTMLElement_language { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170019B1 RID: 6577
		// (get) Token: 0x06004E69 RID: 20073
		// (set) Token: 0x06004E68 RID: 20072
		public virtual extern object IHTMLElement_onselectstart { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x06004E6A RID: 20074
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void IHTMLElement_scrollIntoView([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] object varargStart);

		// Token: 0x06004E6B RID: 20075
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern bool IHTMLElement_contains([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLElement pChild);

		// Token: 0x170019B2 RID: 6578
		// (get) Token: 0x06004E6C RID: 20076
		public virtual extern int IHTMLElement_sourceIndex { [global::System.Runtime.InteropServices.TypeLibFunc(4)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x170019B3 RID: 6579
		// (get) Token: 0x06004E6D RID: 20077
		public virtual extern object IHTMLElement_recordNumber { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; }

		// Token: 0x170019B4 RID: 6580
		// (get) Token: 0x06004E6F RID: 20079
		// (set) Token: 0x06004E6E RID: 20078
		public virtual extern string IHTMLElement_lang { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170019B5 RID: 6581
		// (get) Token: 0x06004E70 RID: 20080
		public virtual extern int IHTMLElement_offsetLeft { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x170019B6 RID: 6582
		// (get) Token: 0x06004E71 RID: 20081
		public virtual extern int IHTMLElement_offsetTop { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x170019B7 RID: 6583
		// (get) Token: 0x06004E72 RID: 20082
		public virtual extern int IHTMLElement_offsetWidth { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x170019B8 RID: 6584
		// (get) Token: 0x06004E73 RID: 20083
		public virtual extern int IHTMLElement_offsetHeight { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x170019B9 RID: 6585
		// (get) Token: 0x06004E74 RID: 20084
		public virtual extern global::mshtml.IHTMLElement IHTMLElement_offsetParent { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x170019BA RID: 6586
		// (get) Token: 0x06004E76 RID: 20086
		// (set) Token: 0x06004E75 RID: 20085
		public virtual extern string IHTMLElement_innerHTML { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170019BB RID: 6587
		// (get) Token: 0x06004E78 RID: 20088
		// (set) Token: 0x06004E77 RID: 20087
		public virtual extern string IHTMLElement_innerText { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170019BC RID: 6588
		// (get) Token: 0x06004E7A RID: 20090
		// (set) Token: 0x06004E79 RID: 20089
		public virtual extern string IHTMLElement_outerHTML { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170019BD RID: 6589
		// (get) Token: 0x06004E7C RID: 20092
		// (set) Token: 0x06004E7B RID: 20091
		public virtual extern string IHTMLElement_outerText { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x06004E7D RID: 20093
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void IHTMLElement_insertAdjacentHTML([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string where, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string html);

		// Token: 0x06004E7E RID: 20094
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void IHTMLElement_insertAdjacentText([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string where, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string text);

		// Token: 0x170019BE RID: 6590
		// (get) Token: 0x06004E7F RID: 20095
		public virtual extern global::mshtml.IHTMLElement IHTMLElement_parentTextEdit { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x170019BF RID: 6591
		// (get) Token: 0x06004E80 RID: 20096
		public virtual extern bool IHTMLElement_isTextEdit { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x06004E81 RID: 20097
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void IHTMLElement_click();

		// Token: 0x170019C0 RID: 6592
		// (get) Token: 0x06004E82 RID: 20098
		public virtual extern global::mshtml.IHTMLFiltersCollection IHTMLElement_filters { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x170019C1 RID: 6593
		// (get) Token: 0x06004E84 RID: 20100
		// (set) Token: 0x06004E83 RID: 20099
		public virtual extern object IHTMLElement_ondragstart { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x06004E85 RID: 20101
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public virtual extern string IHTMLElement_toString();

		// Token: 0x170019C2 RID: 6594
		// (get) Token: 0x06004E87 RID: 20103
		// (set) Token: 0x06004E86 RID: 20102
		public virtual extern object IHTMLElement_onbeforeupdate { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170019C3 RID: 6595
		// (get) Token: 0x06004E89 RID: 20105
		// (set) Token: 0x06004E88 RID: 20104
		public virtual extern object IHTMLElement_onafterupdate { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170019C4 RID: 6596
		// (get) Token: 0x06004E8B RID: 20107
		// (set) Token: 0x06004E8A RID: 20106
		public virtual extern object IHTMLElement_onerrorupdate { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170019C5 RID: 6597
		// (get) Token: 0x06004E8D RID: 20109
		// (set) Token: 0x06004E8C RID: 20108
		public virtual extern object IHTMLElement_onrowexit { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170019C6 RID: 6598
		// (get) Token: 0x06004E8F RID: 20111
		// (set) Token: 0x06004E8E RID: 20110
		public virtual extern object IHTMLElement_onrowenter { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170019C7 RID: 6599
		// (get) Token: 0x06004E91 RID: 20113
		// (set) Token: 0x06004E90 RID: 20112
		public virtual extern object IHTMLElement_ondatasetchanged { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170019C8 RID: 6600
		// (get) Token: 0x06004E93 RID: 20115
		// (set) Token: 0x06004E92 RID: 20114
		public virtual extern object IHTMLElement_ondataavailable { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170019C9 RID: 6601
		// (get) Token: 0x06004E95 RID: 20117
		// (set) Token: 0x06004E94 RID: 20116
		public virtual extern object IHTMLElement_ondatasetcomplete { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170019CA RID: 6602
		// (get) Token: 0x06004E97 RID: 20119
		// (set) Token: 0x06004E96 RID: 20118
		public virtual extern object IHTMLElement_onfilterchange { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170019CB RID: 6603
		// (get) Token: 0x06004E98 RID: 20120
		public virtual extern object IHTMLElement_children { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] get; }

		// Token: 0x170019CC RID: 6604
		// (get) Token: 0x06004E99 RID: 20121
		public virtual extern object IHTMLElement_all { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] get; }

		// Token: 0x170019CD RID: 6605
		// (get) Token: 0x06004E9A RID: 20122
		public virtual extern string IHTMLElement2_scopeName { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x06004E9B RID: 20123
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void IHTMLElement2_setCapture([global::System.Runtime.InteropServices.In] bool containerCapture = true);

		// Token: 0x06004E9C RID: 20124
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void IHTMLElement2_releaseCapture();

		// Token: 0x170019CE RID: 6606
		// (get) Token: 0x06004E9E RID: 20126
		// (set) Token: 0x06004E9D RID: 20125
		public virtual extern object IHTMLElement2_onlosecapture { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x06004E9F RID: 20127
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public virtual extern string IHTMLElement2_componentFromPoint([global::System.Runtime.InteropServices.In] int x, [global::System.Runtime.InteropServices.In] int y);

		// Token: 0x06004EA0 RID: 20128
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void IHTMLElement2_doScroll([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] object component);

		// Token: 0x170019CF RID: 6607
		// (get) Token: 0x06004EA2 RID: 20130
		// (set) Token: 0x06004EA1 RID: 20129
		public virtual extern object IHTMLElement2_onscroll { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170019D0 RID: 6608
		// (get) Token: 0x06004EA4 RID: 20132
		// (set) Token: 0x06004EA3 RID: 20131
		public virtual extern object IHTMLElement2_ondrag { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170019D1 RID: 6609
		// (get) Token: 0x06004EA6 RID: 20134
		// (set) Token: 0x06004EA5 RID: 20133
		public virtual extern object IHTMLElement2_ondragend { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170019D2 RID: 6610
		// (get) Token: 0x06004EA8 RID: 20136
		// (set) Token: 0x06004EA7 RID: 20135
		public virtual extern object IHTMLElement2_ondragenter { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170019D3 RID: 6611
		// (get) Token: 0x06004EAA RID: 20138
		// (set) Token: 0x06004EA9 RID: 20137
		public virtual extern object IHTMLElement2_ondragover { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170019D4 RID: 6612
		// (get) Token: 0x06004EAC RID: 20140
		// (set) Token: 0x06004EAB RID: 20139
		public virtual extern object IHTMLElement2_ondragleave { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170019D5 RID: 6613
		// (get) Token: 0x06004EAE RID: 20142
		// (set) Token: 0x06004EAD RID: 20141
		public virtual extern object IHTMLElement2_ondrop { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170019D6 RID: 6614
		// (get) Token: 0x06004EB0 RID: 20144
		// (set) Token: 0x06004EAF RID: 20143
		public virtual extern object IHTMLElement2_onbeforecut { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170019D7 RID: 6615
		// (get) Token: 0x06004EB2 RID: 20146
		// (set) Token: 0x06004EB1 RID: 20145
		public virtual extern object IHTMLElement2_oncut { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170019D8 RID: 6616
		// (get) Token: 0x06004EB4 RID: 20148
		// (set) Token: 0x06004EB3 RID: 20147
		public virtual extern object IHTMLElement2_onbeforecopy { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170019D9 RID: 6617
		// (get) Token: 0x06004EB6 RID: 20150
		// (set) Token: 0x06004EB5 RID: 20149
		public virtual extern object IHTMLElement2_oncopy { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170019DA RID: 6618
		// (get) Token: 0x06004EB8 RID: 20152
		// (set) Token: 0x06004EB7 RID: 20151
		public virtual extern object IHTMLElement2_onbeforepaste { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170019DB RID: 6619
		// (get) Token: 0x06004EBA RID: 20154
		// (set) Token: 0x06004EB9 RID: 20153
		public virtual extern object IHTMLElement2_onpaste { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170019DC RID: 6620
		// (get) Token: 0x06004EBB RID: 20155
		public virtual extern global::mshtml.IHTMLCurrentStyle IHTMLElement2_currentStyle { [global::System.Runtime.InteropServices.TypeLibFunc(1024)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x170019DD RID: 6621
		// (get) Token: 0x06004EBD RID: 20157
		// (set) Token: 0x06004EBC RID: 20156
		public virtual extern object IHTMLElement2_onpropertychange { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x06004EBE RID: 20158
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		public virtual extern global::mshtml.IHTMLRectCollection IHTMLElement2_getClientRects();

		// Token: 0x06004EBF RID: 20159
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		public virtual extern global::mshtml.IHTMLRect IHTMLElement2_getBoundingClientRect();

		// Token: 0x06004EC0 RID: 20160
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void IHTMLElement2_setExpression([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string propname, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string expression, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string language = "");

		// Token: 0x06004EC1 RID: 20161
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)]
		public virtual extern object IHTMLElement2_getExpression([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string propname);

		// Token: 0x06004EC2 RID: 20162
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern bool IHTMLElement2_removeExpression([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string propname);

		// Token: 0x170019DE RID: 6622
		// (get) Token: 0x06004EC4 RID: 20164
		// (set) Token: 0x06004EC3 RID: 20163
		public virtual extern short IHTMLElement2_tabIndex { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x06004EC5 RID: 20165
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void IHTMLElement2_focus();

		// Token: 0x170019DF RID: 6623
		// (get) Token: 0x06004EC7 RID: 20167
		// (set) Token: 0x06004EC6 RID: 20166
		public virtual extern string IHTMLElement2_accessKey { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170019E0 RID: 6624
		// (get) Token: 0x06004EC9 RID: 20169
		// (set) Token: 0x06004EC8 RID: 20168
		public virtual extern object IHTMLElement2_onblur { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170019E1 RID: 6625
		// (get) Token: 0x06004ECB RID: 20171
		// (set) Token: 0x06004ECA RID: 20170
		public virtual extern object IHTMLElement2_onfocus { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170019E2 RID: 6626
		// (get) Token: 0x06004ECD RID: 20173
		// (set) Token: 0x06004ECC RID: 20172
		public virtual extern object IHTMLElement2_onresize { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x06004ECE RID: 20174
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void IHTMLElement2_blur();

		// Token: 0x06004ECF RID: 20175
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void IHTMLElement2_addFilter([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IUnknown)] [global::System.Runtime.InteropServices.In] object pUnk);

		// Token: 0x06004ED0 RID: 20176
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void IHTMLElement2_removeFilter([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IUnknown)] [global::System.Runtime.InteropServices.In] object pUnk);

		// Token: 0x170019E3 RID: 6627
		// (get) Token: 0x06004ED1 RID: 20177
		public virtual extern int IHTMLElement2_clientHeight { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x170019E4 RID: 6628
		// (get) Token: 0x06004ED2 RID: 20178
		public virtual extern int IHTMLElement2_clientWidth { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x170019E5 RID: 6629
		// (get) Token: 0x06004ED3 RID: 20179
		public virtual extern int IHTMLElement2_clientTop { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x170019E6 RID: 6630
		// (get) Token: 0x06004ED4 RID: 20180
		public virtual extern int IHTMLElement2_clientLeft { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x06004ED5 RID: 20181
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern bool IHTMLElement2_attachEvent([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string @event, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] [global::System.Runtime.InteropServices.In] object pdisp);

		// Token: 0x06004ED6 RID: 20182
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void IHTMLElement2_detachEvent([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string @event, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] [global::System.Runtime.InteropServices.In] object pdisp);

		// Token: 0x170019E7 RID: 6631
		// (get) Token: 0x06004ED7 RID: 20183
		public virtual extern object IHTMLElement2_readyState { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; }

		// Token: 0x170019E8 RID: 6632
		// (get) Token: 0x06004ED9 RID: 20185
		// (set) Token: 0x06004ED8 RID: 20184
		public virtual extern object IHTMLElement2_onreadystatechange { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170019E9 RID: 6633
		// (get) Token: 0x06004EDB RID: 20187
		// (set) Token: 0x06004EDA RID: 20186
		public virtual extern object IHTMLElement2_onrowsdelete { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170019EA RID: 6634
		// (get) Token: 0x06004EDD RID: 20189
		// (set) Token: 0x06004EDC RID: 20188
		public virtual extern object IHTMLElement2_onrowsinserted { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170019EB RID: 6635
		// (get) Token: 0x06004EDF RID: 20191
		// (set) Token: 0x06004EDE RID: 20190
		public virtual extern object IHTMLElement2_oncellchange { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170019EC RID: 6636
		// (get) Token: 0x06004EE1 RID: 20193
		// (set) Token: 0x06004EE0 RID: 20192
		public virtual extern string IHTMLElement2_dir { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x06004EE2 RID: 20194
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)]
		public virtual extern object IHTMLElement2_createControlRange();

		// Token: 0x170019ED RID: 6637
		// (get) Token: 0x06004EE3 RID: 20195
		public virtual extern int IHTMLElement2_scrollHeight { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x170019EE RID: 6638
		// (get) Token: 0x06004EE4 RID: 20196
		public virtual extern int IHTMLElement2_scrollWidth { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x170019EF RID: 6639
		// (get) Token: 0x06004EE6 RID: 20198
		// (set) Token: 0x06004EE5 RID: 20197
		public virtual extern int IHTMLElement2_scrollTop { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170019F0 RID: 6640
		// (get) Token: 0x06004EE8 RID: 20200
		// (set) Token: 0x06004EE7 RID: 20199
		public virtual extern int IHTMLElement2_scrollLeft { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x06004EE9 RID: 20201
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void IHTMLElement2_clearAttributes();

		// Token: 0x06004EEA RID: 20202
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void mergeAttributes([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLElement mergeThis);

		// Token: 0x170019F1 RID: 6641
		// (get) Token: 0x06004EEC RID: 20204
		// (set) Token: 0x06004EEB RID: 20203
		public virtual extern object IHTMLElement2_oncontextmenu { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x06004EED RID: 20205
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		public virtual extern global::mshtml.IHTMLElement IHTMLElement2_insertAdjacentElement([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string where, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLElement insertedElement);

		// Token: 0x06004EEE RID: 20206
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		public virtual extern global::mshtml.IHTMLElement IHTMLElement2_applyElement([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLElement apply, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string where);

		// Token: 0x06004EEF RID: 20207
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public virtual extern string IHTMLElement2_getAdjacentText([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string where);

		// Token: 0x06004EF0 RID: 20208
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public virtual extern string IHTMLElement2_replaceAdjacentText([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string where, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string newText);

		// Token: 0x170019F2 RID: 6642
		// (get) Token: 0x06004EF1 RID: 20209
		public virtual extern bool IHTMLElement2_canHaveChildren { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x06004EF2 RID: 20210
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern int IHTMLElement2_addBehavior([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string bstrUrl, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object pvarFactory);

		// Token: 0x06004EF3 RID: 20211
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern bool IHTMLElement2_removeBehavior([global::System.Runtime.InteropServices.In] int cookie);

		// Token: 0x170019F3 RID: 6643
		// (get) Token: 0x06004EF4 RID: 20212
		public virtual extern global::mshtml.IHTMLStyle IHTMLElement2_runtimeStyle { [global::System.Runtime.InteropServices.TypeLibFunc(1024)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x170019F4 RID: 6644
		// (get) Token: 0x06004EF5 RID: 20213
		public virtual extern object IHTMLElement2_behaviorUrns { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] get; }

		// Token: 0x170019F5 RID: 6645
		// (get) Token: 0x06004EF7 RID: 20215
		// (set) Token: 0x06004EF6 RID: 20214
		public virtual extern string IHTMLElement2_tagUrn { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170019F6 RID: 6646
		// (get) Token: 0x06004EF9 RID: 20217
		// (set) Token: 0x06004EF8 RID: 20216
		public virtual extern object IHTMLElement2_onbeforeeditfocus { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170019F7 RID: 6647
		// (get) Token: 0x06004EFA RID: 20218
		public virtual extern int IHTMLElement2_readyStateValue { [global::System.Runtime.InteropServices.TypeLibFunc(65)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x06004EFB RID: 20219
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		public virtual extern global::mshtml.IHTMLElementCollection IHTMLElement2_getElementsByTagName([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string v);

		// Token: 0x06004EFC RID: 20220
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void mergeAttributes([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLElement mergeThis, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object pvarFlags);

		// Token: 0x170019F8 RID: 6648
		// (get) Token: 0x06004EFD RID: 20221
		public virtual extern bool IHTMLElement3_isMultiLine { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x170019F9 RID: 6649
		// (get) Token: 0x06004EFE RID: 20222
		public virtual extern bool IHTMLElement3_canHaveHTML { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x170019FA RID: 6650
		// (get) Token: 0x06004F00 RID: 20224
		// (set) Token: 0x06004EFF RID: 20223
		public virtual extern object IHTMLElement3_onlayoutcomplete { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170019FB RID: 6651
		// (get) Token: 0x06004F02 RID: 20226
		// (set) Token: 0x06004F01 RID: 20225
		public virtual extern object IHTMLElement3_onpage { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170019FC RID: 6652
		// (get) Token: 0x06004F04 RID: 20228
		// (set) Token: 0x06004F03 RID: 20227
		public virtual extern bool IHTMLElement3_inflateBlock { [global::System.Runtime.InteropServices.TypeLibFunc(1089)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.TypeLibFunc(1089)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170019FD RID: 6653
		// (get) Token: 0x06004F06 RID: 20230
		// (set) Token: 0x06004F05 RID: 20229
		public virtual extern object IHTMLElement3_onbeforedeactivate { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x06004F07 RID: 20231
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void IHTMLElement3_setActive();

		// Token: 0x170019FE RID: 6654
		// (get) Token: 0x06004F09 RID: 20233
		// (set) Token: 0x06004F08 RID: 20232
		public virtual extern string IHTMLElement3_contentEditable { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170019FF RID: 6655
		// (get) Token: 0x06004F0A RID: 20234
		public virtual extern bool IHTMLElement3_isContentEditable { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001A00 RID: 6656
		// (get) Token: 0x06004F0C RID: 20236
		// (set) Token: 0x06004F0B RID: 20235
		public virtual extern bool IHTMLElement3_hideFocus { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17001A01 RID: 6657
		// (get) Token: 0x06004F0E RID: 20238
		// (set) Token: 0x06004F0D RID: 20237
		public virtual extern bool IHTMLElement3_disabled { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17001A02 RID: 6658
		// (get) Token: 0x06004F0F RID: 20239
		public virtual extern bool IHTMLElement3_isDisabled { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001A03 RID: 6659
		// (get) Token: 0x06004F11 RID: 20241
		// (set) Token: 0x06004F10 RID: 20240
		public virtual extern object IHTMLElement3_onmove { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17001A04 RID: 6660
		// (get) Token: 0x06004F13 RID: 20243
		// (set) Token: 0x06004F12 RID: 20242
		public virtual extern object IHTMLElement3_oncontrolselect { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x06004F14 RID: 20244
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern bool IHTMLElement3_FireEvent([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string bstrEventName, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object pvarEventObject);

		// Token: 0x17001A05 RID: 6661
		// (get) Token: 0x06004F16 RID: 20246
		// (set) Token: 0x06004F15 RID: 20245
		public virtual extern object IHTMLElement3_onresizestart { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17001A06 RID: 6662
		// (get) Token: 0x06004F18 RID: 20248
		// (set) Token: 0x06004F17 RID: 20247
		public virtual extern object IHTMLElement3_onresizeend { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17001A07 RID: 6663
		// (get) Token: 0x06004F1A RID: 20250
		// (set) Token: 0x06004F19 RID: 20249
		public virtual extern object IHTMLElement3_onmovestart { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17001A08 RID: 6664
		// (get) Token: 0x06004F1C RID: 20252
		// (set) Token: 0x06004F1B RID: 20251
		public virtual extern object IHTMLElement3_onmoveend { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17001A09 RID: 6665
		// (get) Token: 0x06004F1E RID: 20254
		// (set) Token: 0x06004F1D RID: 20253
		public virtual extern object IHTMLElement3_onmouseenter { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17001A0A RID: 6666
		// (get) Token: 0x06004F20 RID: 20256
		// (set) Token: 0x06004F1F RID: 20255
		public virtual extern object IHTMLElement3_onmouseleave { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17001A0B RID: 6667
		// (get) Token: 0x06004F22 RID: 20258
		// (set) Token: 0x06004F21 RID: 20257
		public virtual extern object IHTMLElement3_onactivate { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17001A0C RID: 6668
		// (get) Token: 0x06004F24 RID: 20260
		// (set) Token: 0x06004F23 RID: 20259
		public virtual extern object IHTMLElement3_ondeactivate { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x06004F25 RID: 20261
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern bool IHTMLElement3_dragDrop();

		// Token: 0x17001A0D RID: 6669
		// (get) Token: 0x06004F26 RID: 20262
		public virtual extern int IHTMLElement3_glyphMode { [global::System.Runtime.InteropServices.TypeLibFunc(1089)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001A0E RID: 6670
		// (get) Token: 0x06004F28 RID: 20264
		// (set) Token: 0x06004F27 RID: 20263
		public virtual extern object IHTMLElement4_onmousewheel { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x06004F29 RID: 20265
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void IHTMLElement4_normalize();

		// Token: 0x06004F2A RID: 20266
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		public virtual extern global::mshtml.IHTMLDOMAttribute IHTMLElement4_getAttributeNode([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string bstrName);

		// Token: 0x06004F2B RID: 20267
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		public virtual extern global::mshtml.IHTMLDOMAttribute IHTMLElement4_setAttributeNode([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLDOMAttribute pattr);

		// Token: 0x06004F2C RID: 20268
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		public virtual extern global::mshtml.IHTMLDOMAttribute IHTMLElement4_removeAttributeNode([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLDOMAttribute pattr);

		// Token: 0x17001A0F RID: 6671
		// (get) Token: 0x06004F2E RID: 20270
		// (set) Token: 0x06004F2D RID: 20269
		public virtual extern object IHTMLElement4_onbeforeactivate { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17001A10 RID: 6672
		// (get) Token: 0x06004F30 RID: 20272
		// (set) Token: 0x06004F2F RID: 20271
		public virtual extern object IHTMLElement4_onfocusin { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17001A11 RID: 6673
		// (get) Token: 0x06004F32 RID: 20274
		// (set) Token: 0x06004F31 RID: 20273
		public virtual extern object IHTMLElement4_onfocusout { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17001A12 RID: 6674
		// (get) Token: 0x06004F33 RID: 20275
		public virtual extern int IHTMLUniqueName_uniqueNumber { [global::System.Runtime.InteropServices.TypeLibFunc(64)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001A13 RID: 6675
		// (get) Token: 0x06004F34 RID: 20276
		public virtual extern string IHTMLUniqueName_uniqueID { [global::System.Runtime.InteropServices.TypeLibFunc(64)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x17001A14 RID: 6676
		// (get) Token: 0x06004F35 RID: 20277
		public virtual extern int IHTMLDOMNode_nodeType { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x17001A15 RID: 6677
		// (get) Token: 0x06004F36 RID: 20278
		public virtual extern global::mshtml.IHTMLDOMNode IHTMLDOMNode_parentNode { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x06004F37 RID: 20279
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern bool IHTMLDOMNode_hasChildNodes();

		// Token: 0x17001A16 RID: 6678
		// (get) Token: 0x06004F38 RID: 20280
		public virtual extern object IHTMLDOMNode_childNodes { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] get; }

		// Token: 0x17001A17 RID: 6679
		// (get) Token: 0x06004F39 RID: 20281
		public virtual extern object IHTMLDOMNode_attributes { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] get; }

		// Token: 0x06004F3A RID: 20282
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		public virtual extern global::mshtml.IHTMLDOMNode IHTMLDOMNode_insertBefore([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLDOMNode newChild, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] object refChild);

		// Token: 0x06004F3B RID: 20283
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		public virtual extern global::mshtml.IHTMLDOMNode IHTMLDOMNode_removeChild([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLDOMNode oldChild);

		// Token: 0x06004F3C RID: 20284
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		public virtual extern global::mshtml.IHTMLDOMNode IHTMLDOMNode_replaceChild([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLDOMNode newChild, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLDOMNode oldChild);

		// Token: 0x06004F3D RID: 20285
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		public virtual extern global::mshtml.IHTMLDOMNode IHTMLDOMNode_cloneNode([global::System.Runtime.InteropServices.In] bool fDeep);

		// Token: 0x06004F3E RID: 20286
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		public virtual extern global::mshtml.IHTMLDOMNode IHTMLDOMNode_removeNode([global::System.Runtime.InteropServices.In] bool fDeep = false);

		// Token: 0x06004F3F RID: 20287
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		public virtual extern global::mshtml.IHTMLDOMNode IHTMLDOMNode_swapNode([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLDOMNode otherNode);

		// Token: 0x06004F40 RID: 20288
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		public virtual extern global::mshtml.IHTMLDOMNode IHTMLDOMNode_replaceNode([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLDOMNode replacement);

		// Token: 0x06004F41 RID: 20289
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		public virtual extern global::mshtml.IHTMLDOMNode IHTMLDOMNode_appendChild([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLDOMNode newChild);

		// Token: 0x17001A18 RID: 6680
		// (get) Token: 0x06004F42 RID: 20290
		public virtual extern string IHTMLDOMNode_nodeName { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x17001A19 RID: 6681
		// (get) Token: 0x06004F44 RID: 20292
		// (set) Token: 0x06004F43 RID: 20291
		public virtual extern object IHTMLDOMNode_nodeValue { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17001A1A RID: 6682
		// (get) Token: 0x06004F45 RID: 20293
		public virtual extern global::mshtml.IHTMLDOMNode IHTMLDOMNode_firstChild { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x17001A1B RID: 6683
		// (get) Token: 0x06004F46 RID: 20294
		public virtual extern global::mshtml.IHTMLDOMNode IHTMLDOMNode_lastChild { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x17001A1C RID: 6684
		// (get) Token: 0x06004F47 RID: 20295
		public virtual extern global::mshtml.IHTMLDOMNode IHTMLDOMNode_previousSibling { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x17001A1D RID: 6685
		// (get) Token: 0x06004F48 RID: 20296
		public virtual extern global::mshtml.IHTMLDOMNode IHTMLDOMNode_nextSibling { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x17001A1E RID: 6686
		// (get) Token: 0x06004F49 RID: 20297
		public virtual extern object IHTMLDOMNode2_ownerDocument { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] get; }

		// Token: 0x17001A1F RID: 6687
		// (get) Token: 0x06004F4B RID: 20299
		// (set) Token: 0x06004F4A RID: 20298
		public virtual extern bool IHTMLListElement2_compact { [global::System.Runtime.InteropServices.TypeLibFunc(4)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.TypeLibFunc(4)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17001A20 RID: 6688
		// (get) Token: 0x06004F4D RID: 20301
		// (set) Token: 0x06004F4C RID: 20300
		public virtual extern bool IHTMLUListElement_compact { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17001A21 RID: 6689
		// (get) Token: 0x06004F4F RID: 20303
		// (set) Token: 0x06004F4E RID: 20302
		public virtual extern string IHTMLUListElement_type { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x14000872 RID: 2162
		// (add) Token: 0x06004F50 RID: 20304
		// (remove) Token: 0x06004F51 RID: 20305
		public virtual extern event global::mshtml.HTMLElementEvents_onhelpEventHandler HTMLElementEvents_Event_onhelp;

		// Token: 0x14000873 RID: 2163
		// (add) Token: 0x06004F52 RID: 20306
		// (remove) Token: 0x06004F53 RID: 20307
		public virtual extern event global::mshtml.HTMLElementEvents_onclickEventHandler HTMLElementEvents_Event_onclick;

		// Token: 0x14000874 RID: 2164
		// (add) Token: 0x06004F54 RID: 20308
		// (remove) Token: 0x06004F55 RID: 20309
		public virtual extern event global::mshtml.HTMLElementEvents_ondblclickEventHandler HTMLElementEvents_Event_ondblclick;

		// Token: 0x14000875 RID: 2165
		// (add) Token: 0x06004F56 RID: 20310
		// (remove) Token: 0x06004F57 RID: 20311
		public virtual extern event global::mshtml.HTMLElementEvents_onkeypressEventHandler HTMLElementEvents_Event_onkeypress;

		// Token: 0x14000876 RID: 2166
		// (add) Token: 0x06004F58 RID: 20312
		// (remove) Token: 0x06004F59 RID: 20313
		public virtual extern event global::mshtml.HTMLElementEvents_onkeydownEventHandler HTMLElementEvents_Event_onkeydown;

		// Token: 0x14000877 RID: 2167
		// (add) Token: 0x06004F5A RID: 20314
		// (remove) Token: 0x06004F5B RID: 20315
		public virtual extern event global::mshtml.HTMLElementEvents_onkeyupEventHandler HTMLElementEvents_Event_onkeyup;

		// Token: 0x14000878 RID: 2168
		// (add) Token: 0x06004F5C RID: 20316
		// (remove) Token: 0x06004F5D RID: 20317
		public virtual extern event global::mshtml.HTMLElementEvents_onmouseoutEventHandler HTMLElementEvents_Event_onmouseout;

		// Token: 0x14000879 RID: 2169
		// (add) Token: 0x06004F5E RID: 20318
		// (remove) Token: 0x06004F5F RID: 20319
		public virtual extern event global::mshtml.HTMLElementEvents_onmouseoverEventHandler HTMLElementEvents_Event_onmouseover;

		// Token: 0x1400087A RID: 2170
		// (add) Token: 0x06004F60 RID: 20320
		// (remove) Token: 0x06004F61 RID: 20321
		public virtual extern event global::mshtml.HTMLElementEvents_onmousemoveEventHandler HTMLElementEvents_Event_onmousemove;

		// Token: 0x1400087B RID: 2171
		// (add) Token: 0x06004F62 RID: 20322
		// (remove) Token: 0x06004F63 RID: 20323
		public virtual extern event global::mshtml.HTMLElementEvents_onmousedownEventHandler HTMLElementEvents_Event_onmousedown;

		// Token: 0x1400087C RID: 2172
		// (add) Token: 0x06004F64 RID: 20324
		// (remove) Token: 0x06004F65 RID: 20325
		public virtual extern event global::mshtml.HTMLElementEvents_onmouseupEventHandler HTMLElementEvents_Event_onmouseup;

		// Token: 0x1400087D RID: 2173
		// (add) Token: 0x06004F66 RID: 20326
		// (remove) Token: 0x06004F67 RID: 20327
		public virtual extern event global::mshtml.HTMLElementEvents_onselectstartEventHandler HTMLElementEvents_Event_onselectstart;

		// Token: 0x1400087E RID: 2174
		// (add) Token: 0x06004F68 RID: 20328
		// (remove) Token: 0x06004F69 RID: 20329
		public virtual extern event global::mshtml.HTMLElementEvents_onfilterchangeEventHandler HTMLElementEvents_Event_onfilterchange;

		// Token: 0x1400087F RID: 2175
		// (add) Token: 0x06004F6A RID: 20330
		// (remove) Token: 0x06004F6B RID: 20331
		public virtual extern event global::mshtml.HTMLElementEvents_ondragstartEventHandler HTMLElementEvents_Event_ondragstart;

		// Token: 0x14000880 RID: 2176
		// (add) Token: 0x06004F6C RID: 20332
		// (remove) Token: 0x06004F6D RID: 20333
		public virtual extern event global::mshtml.HTMLElementEvents_onbeforeupdateEventHandler HTMLElementEvents_Event_onbeforeupdate;

		// Token: 0x14000881 RID: 2177
		// (add) Token: 0x06004F6E RID: 20334
		// (remove) Token: 0x06004F6F RID: 20335
		public virtual extern event global::mshtml.HTMLElementEvents_onafterupdateEventHandler HTMLElementEvents_Event_onafterupdate;

		// Token: 0x14000882 RID: 2178
		// (add) Token: 0x06004F70 RID: 20336
		// (remove) Token: 0x06004F71 RID: 20337
		public virtual extern event global::mshtml.HTMLElementEvents_onerrorupdateEventHandler HTMLElementEvents_Event_onerrorupdate;

		// Token: 0x14000883 RID: 2179
		// (add) Token: 0x06004F72 RID: 20338
		// (remove) Token: 0x06004F73 RID: 20339
		public virtual extern event global::mshtml.HTMLElementEvents_onrowexitEventHandler HTMLElementEvents_Event_onrowexit;

		// Token: 0x14000884 RID: 2180
		// (add) Token: 0x06004F74 RID: 20340
		// (remove) Token: 0x06004F75 RID: 20341
		public virtual extern event global::mshtml.HTMLElementEvents_onrowenterEventHandler HTMLElementEvents_Event_onrowenter;

		// Token: 0x14000885 RID: 2181
		// (add) Token: 0x06004F76 RID: 20342
		// (remove) Token: 0x06004F77 RID: 20343
		public virtual extern event global::mshtml.HTMLElementEvents_ondatasetchangedEventHandler HTMLElementEvents_Event_ondatasetchanged;

		// Token: 0x14000886 RID: 2182
		// (add) Token: 0x06004F78 RID: 20344
		// (remove) Token: 0x06004F79 RID: 20345
		public virtual extern event global::mshtml.HTMLElementEvents_ondataavailableEventHandler HTMLElementEvents_Event_ondataavailable;

		// Token: 0x14000887 RID: 2183
		// (add) Token: 0x06004F7A RID: 20346
		// (remove) Token: 0x06004F7B RID: 20347
		public virtual extern event global::mshtml.HTMLElementEvents_ondatasetcompleteEventHandler HTMLElementEvents_Event_ondatasetcomplete;

		// Token: 0x14000888 RID: 2184
		// (add) Token: 0x06004F7C RID: 20348
		// (remove) Token: 0x06004F7D RID: 20349
		public virtual extern event global::mshtml.HTMLElementEvents_onlosecaptureEventHandler HTMLElementEvents_Event_onlosecapture;

		// Token: 0x14000889 RID: 2185
		// (add) Token: 0x06004F7E RID: 20350
		// (remove) Token: 0x06004F7F RID: 20351
		public virtual extern event global::mshtml.HTMLElementEvents_onpropertychangeEventHandler HTMLElementEvents_Event_onpropertychange;

		// Token: 0x1400088A RID: 2186
		// (add) Token: 0x06004F80 RID: 20352
		// (remove) Token: 0x06004F81 RID: 20353
		public virtual extern event global::mshtml.HTMLElementEvents_onscrollEventHandler HTMLElementEvents_Event_onscroll;

		// Token: 0x1400088B RID: 2187
		// (add) Token: 0x06004F82 RID: 20354
		// (remove) Token: 0x06004F83 RID: 20355
		public virtual extern event global::mshtml.HTMLElementEvents_onfocusEventHandler HTMLElementEvents_Event_onfocus;

		// Token: 0x1400088C RID: 2188
		// (add) Token: 0x06004F84 RID: 20356
		// (remove) Token: 0x06004F85 RID: 20357
		public virtual extern event global::mshtml.HTMLElementEvents_onblurEventHandler HTMLElementEvents_Event_onblur;

		// Token: 0x1400088D RID: 2189
		// (add) Token: 0x06004F86 RID: 20358
		// (remove) Token: 0x06004F87 RID: 20359
		public virtual extern event global::mshtml.HTMLElementEvents_onresizeEventHandler HTMLElementEvents_Event_onresize;

		// Token: 0x1400088E RID: 2190
		// (add) Token: 0x06004F88 RID: 20360
		// (remove) Token: 0x06004F89 RID: 20361
		public virtual extern event global::mshtml.HTMLElementEvents_ondragEventHandler HTMLElementEvents_Event_ondrag;

		// Token: 0x1400088F RID: 2191
		// (add) Token: 0x06004F8A RID: 20362
		// (remove) Token: 0x06004F8B RID: 20363
		public virtual extern event global::mshtml.HTMLElementEvents_ondragendEventHandler HTMLElementEvents_Event_ondragend;

		// Token: 0x14000890 RID: 2192
		// (add) Token: 0x06004F8C RID: 20364
		// (remove) Token: 0x06004F8D RID: 20365
		public virtual extern event global::mshtml.HTMLElementEvents_ondragenterEventHandler HTMLElementEvents_Event_ondragenter;

		// Token: 0x14000891 RID: 2193
		// (add) Token: 0x06004F8E RID: 20366
		// (remove) Token: 0x06004F8F RID: 20367
		public virtual extern event global::mshtml.HTMLElementEvents_ondragoverEventHandler HTMLElementEvents_Event_ondragover;

		// Token: 0x14000892 RID: 2194
		// (add) Token: 0x06004F90 RID: 20368
		// (remove) Token: 0x06004F91 RID: 20369
		public virtual extern event global::mshtml.HTMLElementEvents_ondragleaveEventHandler HTMLElementEvents_Event_ondragleave;

		// Token: 0x14000893 RID: 2195
		// (add) Token: 0x06004F92 RID: 20370
		// (remove) Token: 0x06004F93 RID: 20371
		public virtual extern event global::mshtml.HTMLElementEvents_ondropEventHandler HTMLElementEvents_Event_ondrop;

		// Token: 0x14000894 RID: 2196
		// (add) Token: 0x06004F94 RID: 20372
		// (remove) Token: 0x06004F95 RID: 20373
		public virtual extern event global::mshtml.HTMLElementEvents_onbeforecutEventHandler HTMLElementEvents_Event_onbeforecut;

		// Token: 0x14000895 RID: 2197
		// (add) Token: 0x06004F96 RID: 20374
		// (remove) Token: 0x06004F97 RID: 20375
		public virtual extern event global::mshtml.HTMLElementEvents_oncutEventHandler HTMLElementEvents_Event_oncut;

		// Token: 0x14000896 RID: 2198
		// (add) Token: 0x06004F98 RID: 20376
		// (remove) Token: 0x06004F99 RID: 20377
		public virtual extern event global::mshtml.HTMLElementEvents_onbeforecopyEventHandler HTMLElementEvents_Event_onbeforecopy;

		// Token: 0x14000897 RID: 2199
		// (add) Token: 0x06004F9A RID: 20378
		// (remove) Token: 0x06004F9B RID: 20379
		public virtual extern event global::mshtml.HTMLElementEvents_oncopyEventHandler HTMLElementEvents_Event_oncopy;

		// Token: 0x14000898 RID: 2200
		// (add) Token: 0x06004F9C RID: 20380
		// (remove) Token: 0x06004F9D RID: 20381
		public virtual extern event global::mshtml.HTMLElementEvents_onbeforepasteEventHandler HTMLElementEvents_Event_onbeforepaste;

		// Token: 0x14000899 RID: 2201
		// (add) Token: 0x06004F9E RID: 20382
		// (remove) Token: 0x06004F9F RID: 20383
		public virtual extern event global::mshtml.HTMLElementEvents_onpasteEventHandler HTMLElementEvents_Event_onpaste;

		// Token: 0x1400089A RID: 2202
		// (add) Token: 0x06004FA0 RID: 20384
		// (remove) Token: 0x06004FA1 RID: 20385
		public virtual extern event global::mshtml.HTMLElementEvents_oncontextmenuEventHandler HTMLElementEvents_Event_oncontextmenu;

		// Token: 0x1400089B RID: 2203
		// (add) Token: 0x06004FA2 RID: 20386
		// (remove) Token: 0x06004FA3 RID: 20387
		public virtual extern event global::mshtml.HTMLElementEvents_onrowsdeleteEventHandler HTMLElementEvents_Event_onrowsdelete;

		// Token: 0x1400089C RID: 2204
		// (add) Token: 0x06004FA4 RID: 20388
		// (remove) Token: 0x06004FA5 RID: 20389
		public virtual extern event global::mshtml.HTMLElementEvents_onrowsinsertedEventHandler HTMLElementEvents_Event_onrowsinserted;

		// Token: 0x1400089D RID: 2205
		// (add) Token: 0x06004FA6 RID: 20390
		// (remove) Token: 0x06004FA7 RID: 20391
		public virtual extern event global::mshtml.HTMLElementEvents_oncellchangeEventHandler HTMLElementEvents_Event_oncellchange;

		// Token: 0x1400089E RID: 2206
		// (add) Token: 0x06004FA8 RID: 20392
		// (remove) Token: 0x06004FA9 RID: 20393
		public virtual extern event global::mshtml.HTMLElementEvents_onreadystatechangeEventHandler HTMLElementEvents_Event_onreadystatechange;

		// Token: 0x1400089F RID: 2207
		// (add) Token: 0x06004FAA RID: 20394
		// (remove) Token: 0x06004FAB RID: 20395
		public virtual extern event global::mshtml.HTMLElementEvents_onbeforeeditfocusEventHandler HTMLElementEvents_Event_onbeforeeditfocus;

		// Token: 0x140008A0 RID: 2208
		// (add) Token: 0x06004FAC RID: 20396
		// (remove) Token: 0x06004FAD RID: 20397
		public virtual extern event global::mshtml.HTMLElementEvents_onlayoutcompleteEventHandler HTMLElementEvents_Event_onlayoutcomplete;

		// Token: 0x140008A1 RID: 2209
		// (add) Token: 0x06004FAE RID: 20398
		// (remove) Token: 0x06004FAF RID: 20399
		public virtual extern event global::mshtml.HTMLElementEvents_onpageEventHandler HTMLElementEvents_Event_onpage;

		// Token: 0x140008A2 RID: 2210
		// (add) Token: 0x06004FB0 RID: 20400
		// (remove) Token: 0x06004FB1 RID: 20401
		public virtual extern event global::mshtml.HTMLElementEvents_onbeforedeactivateEventHandler HTMLElementEvents_Event_onbeforedeactivate;

		// Token: 0x140008A3 RID: 2211
		// (add) Token: 0x06004FB2 RID: 20402
		// (remove) Token: 0x06004FB3 RID: 20403
		public virtual extern event global::mshtml.HTMLElementEvents_onbeforeactivateEventHandler HTMLElementEvents_Event_onbeforeactivate;

		// Token: 0x140008A4 RID: 2212
		// (add) Token: 0x06004FB4 RID: 20404
		// (remove) Token: 0x06004FB5 RID: 20405
		public virtual extern event global::mshtml.HTMLElementEvents_onmoveEventHandler HTMLElementEvents_Event_onmove;

		// Token: 0x140008A5 RID: 2213
		// (add) Token: 0x06004FB6 RID: 20406
		// (remove) Token: 0x06004FB7 RID: 20407
		public virtual extern event global::mshtml.HTMLElementEvents_oncontrolselectEventHandler HTMLElementEvents_Event_oncontrolselect;

		// Token: 0x140008A6 RID: 2214
		// (add) Token: 0x06004FB8 RID: 20408
		// (remove) Token: 0x06004FB9 RID: 20409
		public virtual extern event global::mshtml.HTMLElementEvents_onmovestartEventHandler HTMLElementEvents_Event_onmovestart;

		// Token: 0x140008A7 RID: 2215
		// (add) Token: 0x06004FBA RID: 20410
		// (remove) Token: 0x06004FBB RID: 20411
		public virtual extern event global::mshtml.HTMLElementEvents_onmoveendEventHandler HTMLElementEvents_Event_onmoveend;

		// Token: 0x140008A8 RID: 2216
		// (add) Token: 0x06004FBC RID: 20412
		// (remove) Token: 0x06004FBD RID: 20413
		public virtual extern event global::mshtml.HTMLElementEvents_onresizestartEventHandler HTMLElementEvents_Event_onresizestart;

		// Token: 0x140008A9 RID: 2217
		// (add) Token: 0x06004FBE RID: 20414
		// (remove) Token: 0x06004FBF RID: 20415
		public virtual extern event global::mshtml.HTMLElementEvents_onresizeendEventHandler HTMLElementEvents_Event_onresizeend;

		// Token: 0x140008AA RID: 2218
		// (add) Token: 0x06004FC0 RID: 20416
		// (remove) Token: 0x06004FC1 RID: 20417
		public virtual extern event global::mshtml.HTMLElementEvents_onmouseenterEventHandler HTMLElementEvents_Event_onmouseenter;

		// Token: 0x140008AB RID: 2219
		// (add) Token: 0x06004FC2 RID: 20418
		// (remove) Token: 0x06004FC3 RID: 20419
		public virtual extern event global::mshtml.HTMLElementEvents_onmouseleaveEventHandler HTMLElementEvents_Event_onmouseleave;

		// Token: 0x140008AC RID: 2220
		// (add) Token: 0x06004FC4 RID: 20420
		// (remove) Token: 0x06004FC5 RID: 20421
		public virtual extern event global::mshtml.HTMLElementEvents_onmousewheelEventHandler HTMLElementEvents_Event_onmousewheel;

		// Token: 0x140008AD RID: 2221
		// (add) Token: 0x06004FC6 RID: 20422
		// (remove) Token: 0x06004FC7 RID: 20423
		public virtual extern event global::mshtml.HTMLElementEvents_onactivateEventHandler HTMLElementEvents_Event_onactivate;

		// Token: 0x140008AE RID: 2222
		// (add) Token: 0x06004FC8 RID: 20424
		// (remove) Token: 0x06004FC9 RID: 20425
		public virtual extern event global::mshtml.HTMLElementEvents_ondeactivateEventHandler HTMLElementEvents_Event_ondeactivate;

		// Token: 0x140008AF RID: 2223
		// (add) Token: 0x06004FCA RID: 20426
		// (remove) Token: 0x06004FCB RID: 20427
		public virtual extern event global::mshtml.HTMLElementEvents_onfocusinEventHandler HTMLElementEvents_Event_onfocusin;

		// Token: 0x140008B0 RID: 2224
		// (add) Token: 0x06004FCC RID: 20428
		// (remove) Token: 0x06004FCD RID: 20429
		public virtual extern event global::mshtml.HTMLElementEvents_onfocusoutEventHandler HTMLElementEvents_Event_onfocusout;

		// Token: 0x140008B1 RID: 2225
		// (add) Token: 0x06004FCE RID: 20430
		// (remove) Token: 0x06004FCF RID: 20431
		public virtual extern event global::mshtml.HTMLElementEvents2_onhelpEventHandler HTMLElementEvents2_Event_onhelp;

		// Token: 0x140008B2 RID: 2226
		// (add) Token: 0x06004FD0 RID: 20432
		// (remove) Token: 0x06004FD1 RID: 20433
		public virtual extern event global::mshtml.HTMLElementEvents2_onclickEventHandler HTMLElementEvents2_Event_onclick;

		// Token: 0x140008B3 RID: 2227
		// (add) Token: 0x06004FD2 RID: 20434
		// (remove) Token: 0x06004FD3 RID: 20435
		public virtual extern event global::mshtml.HTMLElementEvents2_ondblclickEventHandler HTMLElementEvents2_Event_ondblclick;

		// Token: 0x140008B4 RID: 2228
		// (add) Token: 0x06004FD4 RID: 20436
		// (remove) Token: 0x06004FD5 RID: 20437
		public virtual extern event global::mshtml.HTMLElementEvents2_onkeypressEventHandler HTMLElementEvents2_Event_onkeypress;

		// Token: 0x140008B5 RID: 2229
		// (add) Token: 0x06004FD6 RID: 20438
		// (remove) Token: 0x06004FD7 RID: 20439
		public virtual extern event global::mshtml.HTMLElementEvents2_onkeydownEventHandler HTMLElementEvents2_Event_onkeydown;

		// Token: 0x140008B6 RID: 2230
		// (add) Token: 0x06004FD8 RID: 20440
		// (remove) Token: 0x06004FD9 RID: 20441
		public virtual extern event global::mshtml.HTMLElementEvents2_onkeyupEventHandler HTMLElementEvents2_Event_onkeyup;

		// Token: 0x140008B7 RID: 2231
		// (add) Token: 0x06004FDA RID: 20442
		// (remove) Token: 0x06004FDB RID: 20443
		public virtual extern event global::mshtml.HTMLElementEvents2_onmouseoutEventHandler HTMLElementEvents2_Event_onmouseout;

		// Token: 0x140008B8 RID: 2232
		// (add) Token: 0x06004FDC RID: 20444
		// (remove) Token: 0x06004FDD RID: 20445
		public virtual extern event global::mshtml.HTMLElementEvents2_onmouseoverEventHandler HTMLElementEvents2_Event_onmouseover;

		// Token: 0x140008B9 RID: 2233
		// (add) Token: 0x06004FDE RID: 20446
		// (remove) Token: 0x06004FDF RID: 20447
		public virtual extern event global::mshtml.HTMLElementEvents2_onmousemoveEventHandler HTMLElementEvents2_Event_onmousemove;

		// Token: 0x140008BA RID: 2234
		// (add) Token: 0x06004FE0 RID: 20448
		// (remove) Token: 0x06004FE1 RID: 20449
		public virtual extern event global::mshtml.HTMLElementEvents2_onmousedownEventHandler HTMLElementEvents2_Event_onmousedown;

		// Token: 0x140008BB RID: 2235
		// (add) Token: 0x06004FE2 RID: 20450
		// (remove) Token: 0x06004FE3 RID: 20451
		public virtual extern event global::mshtml.HTMLElementEvents2_onmouseupEventHandler HTMLElementEvents2_Event_onmouseup;

		// Token: 0x140008BC RID: 2236
		// (add) Token: 0x06004FE4 RID: 20452
		// (remove) Token: 0x06004FE5 RID: 20453
		public virtual extern event global::mshtml.HTMLElementEvents2_onselectstartEventHandler HTMLElementEvents2_Event_onselectstart;

		// Token: 0x140008BD RID: 2237
		// (add) Token: 0x06004FE6 RID: 20454
		// (remove) Token: 0x06004FE7 RID: 20455
		public virtual extern event global::mshtml.HTMLElementEvents2_onfilterchangeEventHandler HTMLElementEvents2_Event_onfilterchange;

		// Token: 0x140008BE RID: 2238
		// (add) Token: 0x06004FE8 RID: 20456
		// (remove) Token: 0x06004FE9 RID: 20457
		public virtual extern event global::mshtml.HTMLElementEvents2_ondragstartEventHandler HTMLElementEvents2_Event_ondragstart;

		// Token: 0x140008BF RID: 2239
		// (add) Token: 0x06004FEA RID: 20458
		// (remove) Token: 0x06004FEB RID: 20459
		public virtual extern event global::mshtml.HTMLElementEvents2_onbeforeupdateEventHandler HTMLElementEvents2_Event_onbeforeupdate;

		// Token: 0x140008C0 RID: 2240
		// (add) Token: 0x06004FEC RID: 20460
		// (remove) Token: 0x06004FED RID: 20461
		public virtual extern event global::mshtml.HTMLElementEvents2_onafterupdateEventHandler HTMLElementEvents2_Event_onafterupdate;

		// Token: 0x140008C1 RID: 2241
		// (add) Token: 0x06004FEE RID: 20462
		// (remove) Token: 0x06004FEF RID: 20463
		public virtual extern event global::mshtml.HTMLElementEvents2_onerrorupdateEventHandler HTMLElementEvents2_Event_onerrorupdate;

		// Token: 0x140008C2 RID: 2242
		// (add) Token: 0x06004FF0 RID: 20464
		// (remove) Token: 0x06004FF1 RID: 20465
		public virtual extern event global::mshtml.HTMLElementEvents2_onrowexitEventHandler HTMLElementEvents2_Event_onrowexit;

		// Token: 0x140008C3 RID: 2243
		// (add) Token: 0x06004FF2 RID: 20466
		// (remove) Token: 0x06004FF3 RID: 20467
		public virtual extern event global::mshtml.HTMLElementEvents2_onrowenterEventHandler HTMLElementEvents2_Event_onrowenter;

		// Token: 0x140008C4 RID: 2244
		// (add) Token: 0x06004FF4 RID: 20468
		// (remove) Token: 0x06004FF5 RID: 20469
		public virtual extern event global::mshtml.HTMLElementEvents2_ondatasetchangedEventHandler HTMLElementEvents2_Event_ondatasetchanged;

		// Token: 0x140008C5 RID: 2245
		// (add) Token: 0x06004FF6 RID: 20470
		// (remove) Token: 0x06004FF7 RID: 20471
		public virtual extern event global::mshtml.HTMLElementEvents2_ondataavailableEventHandler HTMLElementEvents2_Event_ondataavailable;

		// Token: 0x140008C6 RID: 2246
		// (add) Token: 0x06004FF8 RID: 20472
		// (remove) Token: 0x06004FF9 RID: 20473
		public virtual extern event global::mshtml.HTMLElementEvents2_ondatasetcompleteEventHandler HTMLElementEvents2_Event_ondatasetcomplete;

		// Token: 0x140008C7 RID: 2247
		// (add) Token: 0x06004FFA RID: 20474
		// (remove) Token: 0x06004FFB RID: 20475
		public virtual extern event global::mshtml.HTMLElementEvents2_onlosecaptureEventHandler HTMLElementEvents2_Event_onlosecapture;

		// Token: 0x140008C8 RID: 2248
		// (add) Token: 0x06004FFC RID: 20476
		// (remove) Token: 0x06004FFD RID: 20477
		public virtual extern event global::mshtml.HTMLElementEvents2_onpropertychangeEventHandler HTMLElementEvents2_Event_onpropertychange;

		// Token: 0x140008C9 RID: 2249
		// (add) Token: 0x06004FFE RID: 20478
		// (remove) Token: 0x06004FFF RID: 20479
		public virtual extern event global::mshtml.HTMLElementEvents2_onscrollEventHandler HTMLElementEvents2_Event_onscroll;

		// Token: 0x140008CA RID: 2250
		// (add) Token: 0x06005000 RID: 20480
		// (remove) Token: 0x06005001 RID: 20481
		public virtual extern event global::mshtml.HTMLElementEvents2_onfocusEventHandler HTMLElementEvents2_Event_onfocus;

		// Token: 0x140008CB RID: 2251
		// (add) Token: 0x06005002 RID: 20482
		// (remove) Token: 0x06005003 RID: 20483
		public virtual extern event global::mshtml.HTMLElementEvents2_onblurEventHandler HTMLElementEvents2_Event_onblur;

		// Token: 0x140008CC RID: 2252
		// (add) Token: 0x06005004 RID: 20484
		// (remove) Token: 0x06005005 RID: 20485
		public virtual extern event global::mshtml.HTMLElementEvents2_onresizeEventHandler HTMLElementEvents2_Event_onresize;

		// Token: 0x140008CD RID: 2253
		// (add) Token: 0x06005006 RID: 20486
		// (remove) Token: 0x06005007 RID: 20487
		public virtual extern event global::mshtml.HTMLElementEvents2_ondragEventHandler HTMLElementEvents2_Event_ondrag;

		// Token: 0x140008CE RID: 2254
		// (add) Token: 0x06005008 RID: 20488
		// (remove) Token: 0x06005009 RID: 20489
		public virtual extern event global::mshtml.HTMLElementEvents2_ondragendEventHandler HTMLElementEvents2_Event_ondragend;

		// Token: 0x140008CF RID: 2255
		// (add) Token: 0x0600500A RID: 20490
		// (remove) Token: 0x0600500B RID: 20491
		public virtual extern event global::mshtml.HTMLElementEvents2_ondragenterEventHandler HTMLElementEvents2_Event_ondragenter;

		// Token: 0x140008D0 RID: 2256
		// (add) Token: 0x0600500C RID: 20492
		// (remove) Token: 0x0600500D RID: 20493
		public virtual extern event global::mshtml.HTMLElementEvents2_ondragoverEventHandler HTMLElementEvents2_Event_ondragover;

		// Token: 0x140008D1 RID: 2257
		// (add) Token: 0x0600500E RID: 20494
		// (remove) Token: 0x0600500F RID: 20495
		public virtual extern event global::mshtml.HTMLElementEvents2_ondragleaveEventHandler HTMLElementEvents2_Event_ondragleave;

		// Token: 0x140008D2 RID: 2258
		// (add) Token: 0x06005010 RID: 20496
		// (remove) Token: 0x06005011 RID: 20497
		public virtual extern event global::mshtml.HTMLElementEvents2_ondropEventHandler HTMLElementEvents2_Event_ondrop;

		// Token: 0x140008D3 RID: 2259
		// (add) Token: 0x06005012 RID: 20498
		// (remove) Token: 0x06005013 RID: 20499
		public virtual extern event global::mshtml.HTMLElementEvents2_onbeforecutEventHandler HTMLElementEvents2_Event_onbeforecut;

		// Token: 0x140008D4 RID: 2260
		// (add) Token: 0x06005014 RID: 20500
		// (remove) Token: 0x06005015 RID: 20501
		public virtual extern event global::mshtml.HTMLElementEvents2_oncutEventHandler HTMLElementEvents2_Event_oncut;

		// Token: 0x140008D5 RID: 2261
		// (add) Token: 0x06005016 RID: 20502
		// (remove) Token: 0x06005017 RID: 20503
		public virtual extern event global::mshtml.HTMLElementEvents2_onbeforecopyEventHandler HTMLElementEvents2_Event_onbeforecopy;

		// Token: 0x140008D6 RID: 2262
		// (add) Token: 0x06005018 RID: 20504
		// (remove) Token: 0x06005019 RID: 20505
		public virtual extern event global::mshtml.HTMLElementEvents2_oncopyEventHandler HTMLElementEvents2_Event_oncopy;

		// Token: 0x140008D7 RID: 2263
		// (add) Token: 0x0600501A RID: 20506
		// (remove) Token: 0x0600501B RID: 20507
		public virtual extern event global::mshtml.HTMLElementEvents2_onbeforepasteEventHandler HTMLElementEvents2_Event_onbeforepaste;

		// Token: 0x140008D8 RID: 2264
		// (add) Token: 0x0600501C RID: 20508
		// (remove) Token: 0x0600501D RID: 20509
		public virtual extern event global::mshtml.HTMLElementEvents2_onpasteEventHandler HTMLElementEvents2_Event_onpaste;

		// Token: 0x140008D9 RID: 2265
		// (add) Token: 0x0600501E RID: 20510
		// (remove) Token: 0x0600501F RID: 20511
		public virtual extern event global::mshtml.HTMLElementEvents2_oncontextmenuEventHandler HTMLElementEvents2_Event_oncontextmenu;

		// Token: 0x140008DA RID: 2266
		// (add) Token: 0x06005020 RID: 20512
		// (remove) Token: 0x06005021 RID: 20513
		public virtual extern event global::mshtml.HTMLElementEvents2_onrowsdeleteEventHandler HTMLElementEvents2_Event_onrowsdelete;

		// Token: 0x140008DB RID: 2267
		// (add) Token: 0x06005022 RID: 20514
		// (remove) Token: 0x06005023 RID: 20515
		public virtual extern event global::mshtml.HTMLElementEvents2_onrowsinsertedEventHandler HTMLElementEvents2_Event_onrowsinserted;

		// Token: 0x140008DC RID: 2268
		// (add) Token: 0x06005024 RID: 20516
		// (remove) Token: 0x06005025 RID: 20517
		public virtual extern event global::mshtml.HTMLElementEvents2_oncellchangeEventHandler HTMLElementEvents2_Event_oncellchange;

		// Token: 0x140008DD RID: 2269
		// (add) Token: 0x06005026 RID: 20518
		// (remove) Token: 0x06005027 RID: 20519
		public virtual extern event global::mshtml.HTMLElementEvents2_onreadystatechangeEventHandler HTMLElementEvents2_Event_onreadystatechange;

		// Token: 0x140008DE RID: 2270
		// (add) Token: 0x06005028 RID: 20520
		// (remove) Token: 0x06005029 RID: 20521
		public virtual extern event global::mshtml.HTMLElementEvents2_onlayoutcompleteEventHandler HTMLElementEvents2_Event_onlayoutcomplete;

		// Token: 0x140008DF RID: 2271
		// (add) Token: 0x0600502A RID: 20522
		// (remove) Token: 0x0600502B RID: 20523
		public virtual extern event global::mshtml.HTMLElementEvents2_onpageEventHandler HTMLElementEvents2_Event_onpage;

		// Token: 0x140008E0 RID: 2272
		// (add) Token: 0x0600502C RID: 20524
		// (remove) Token: 0x0600502D RID: 20525
		public virtual extern event global::mshtml.HTMLElementEvents2_onmouseenterEventHandler HTMLElementEvents2_Event_onmouseenter;

		// Token: 0x140008E1 RID: 2273
		// (add) Token: 0x0600502E RID: 20526
		// (remove) Token: 0x0600502F RID: 20527
		public virtual extern event global::mshtml.HTMLElementEvents2_onmouseleaveEventHandler HTMLElementEvents2_Event_onmouseleave;

		// Token: 0x140008E2 RID: 2274
		// (add) Token: 0x06005030 RID: 20528
		// (remove) Token: 0x06005031 RID: 20529
		public virtual extern event global::mshtml.HTMLElementEvents2_onactivateEventHandler HTMLElementEvents2_Event_onactivate;

		// Token: 0x140008E3 RID: 2275
		// (add) Token: 0x06005032 RID: 20530
		// (remove) Token: 0x06005033 RID: 20531
		public virtual extern event global::mshtml.HTMLElementEvents2_ondeactivateEventHandler HTMLElementEvents2_Event_ondeactivate;

		// Token: 0x140008E4 RID: 2276
		// (add) Token: 0x06005034 RID: 20532
		// (remove) Token: 0x06005035 RID: 20533
		public virtual extern event global::mshtml.HTMLElementEvents2_onbeforedeactivateEventHandler HTMLElementEvents2_Event_onbeforedeactivate;

		// Token: 0x140008E5 RID: 2277
		// (add) Token: 0x06005036 RID: 20534
		// (remove) Token: 0x06005037 RID: 20535
		public virtual extern event global::mshtml.HTMLElementEvents2_onbeforeactivateEventHandler HTMLElementEvents2_Event_onbeforeactivate;

		// Token: 0x140008E6 RID: 2278
		// (add) Token: 0x06005038 RID: 20536
		// (remove) Token: 0x06005039 RID: 20537
		public virtual extern event global::mshtml.HTMLElementEvents2_onfocusinEventHandler HTMLElementEvents2_Event_onfocusin;

		// Token: 0x140008E7 RID: 2279
		// (add) Token: 0x0600503A RID: 20538
		// (remove) Token: 0x0600503B RID: 20539
		public virtual extern event global::mshtml.HTMLElementEvents2_onfocusoutEventHandler HTMLElementEvents2_Event_onfocusout;

		// Token: 0x140008E8 RID: 2280
		// (add) Token: 0x0600503C RID: 20540
		// (remove) Token: 0x0600503D RID: 20541
		public virtual extern event global::mshtml.HTMLElementEvents2_onmoveEventHandler HTMLElementEvents2_Event_onmove;

		// Token: 0x140008E9 RID: 2281
		// (add) Token: 0x0600503E RID: 20542
		// (remove) Token: 0x0600503F RID: 20543
		public virtual extern event global::mshtml.HTMLElementEvents2_oncontrolselectEventHandler HTMLElementEvents2_Event_oncontrolselect;

		// Token: 0x140008EA RID: 2282
		// (add) Token: 0x06005040 RID: 20544
		// (remove) Token: 0x06005041 RID: 20545
		public virtual extern event global::mshtml.HTMLElementEvents2_onmovestartEventHandler HTMLElementEvents2_Event_onmovestart;

		// Token: 0x140008EB RID: 2283
		// (add) Token: 0x06005042 RID: 20546
		// (remove) Token: 0x06005043 RID: 20547
		public virtual extern event global::mshtml.HTMLElementEvents2_onmoveendEventHandler HTMLElementEvents2_Event_onmoveend;

		// Token: 0x140008EC RID: 2284
		// (add) Token: 0x06005044 RID: 20548
		// (remove) Token: 0x06005045 RID: 20549
		public virtual extern event global::mshtml.HTMLElementEvents2_onresizestartEventHandler HTMLElementEvents2_Event_onresizestart;

		// Token: 0x140008ED RID: 2285
		// (add) Token: 0x06005046 RID: 20550
		// (remove) Token: 0x06005047 RID: 20551
		public virtual extern event global::mshtml.HTMLElementEvents2_onresizeendEventHandler HTMLElementEvents2_Event_onresizeend;

		// Token: 0x140008EE RID: 2286
		// (add) Token: 0x06005048 RID: 20552
		// (remove) Token: 0x06005049 RID: 20553
		public virtual extern event global::mshtml.HTMLElementEvents2_onmousewheelEventHandler HTMLElementEvents2_Event_onmousewheel;
	}
}
