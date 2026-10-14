using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace mshtml
{
	// Token: 0x020000B9 RID: 185
	[global::System.Runtime.InteropServices.TypeLibType(2)]
	[global::System.Runtime.InteropServices.ClassInterface(0)]
	[global::System.Runtime.InteropServices.ComSourceInterfaces("mshtml.HTMLElementEvents\0mshtml.HTMLElementEvents2\0\0")]
	[global::System.Runtime.InteropServices.Guid("3050F4B8-98B5-11CF-BB82-00AA00BDCE0B")]
	[global::System.Runtime.InteropServices.ComImport]
	public class HTMLGenericElementClass : global::mshtml.DispHTMLGenericElement, global::mshtml.HTMLGenericElement, global::mshtml.HTMLElementEvents_Event, global::mshtml.IHTMLElement, global::mshtml.IHTMLElement2, global::mshtml.IHTMLElement3, global::mshtml.IHTMLElement4, global::mshtml.IHTMLUniqueName, global::mshtml.IHTMLDOMNode, global::mshtml.IHTMLDOMNode2, global::mshtml.IHTMLGenericElement, global::mshtml.HTMLElementEvents2_Event
	{
		// Token: 0x06000EB5 RID: 3765
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public extern HTMLGenericElementClass();

		// Token: 0x06000EB6 RID: 3766
		[global::System.Runtime.InteropServices.DispId(-2147417611)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void setAttribute([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string strAttributeName, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] object AttributeValue, [global::System.Runtime.InteropServices.In] int lFlags = 1);

		// Token: 0x06000EB7 RID: 3767
		[global::System.Runtime.InteropServices.DispId(-2147417610)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)]
		public virtual extern object getAttribute([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string strAttributeName, [global::System.Runtime.InteropServices.In] int lFlags = 0);

		// Token: 0x06000EB8 RID: 3768
		[global::System.Runtime.InteropServices.DispId(-2147417609)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern bool removeAttribute([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string strAttributeName, [global::System.Runtime.InteropServices.In] int lFlags = 1);

		// Token: 0x170007D1 RID: 2001
		// (get) Token: 0x06000EBA RID: 3770
		// (set) Token: 0x06000EB9 RID: 3769
		[global::System.Runtime.InteropServices.DispId(-2147417111)]
		public virtual extern string className { [global::System.Runtime.InteropServices.DispId(-2147417111)] [global::System.Runtime.InteropServices.TypeLibFunc(4)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.TypeLibFunc(4)] [global::System.Runtime.InteropServices.DispId(-2147417111)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] set; }

		// Token: 0x170007D2 RID: 2002
		// (get) Token: 0x06000EBC RID: 3772
		// (set) Token: 0x06000EBB RID: 3771
		[global::System.Runtime.InteropServices.DispId(-2147417110)]
		public virtual extern string id { [global::System.Runtime.InteropServices.TypeLibFunc(4)] [global::System.Runtime.InteropServices.DispId(-2147417110)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.TypeLibFunc(4)] [global::System.Runtime.InteropServices.DispId(-2147417110)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] set; }

		// Token: 0x170007D3 RID: 2003
		// (get) Token: 0x06000EBD RID: 3773
		[global::System.Runtime.InteropServices.DispId(-2147417108)]
		public virtual extern string tagName { [global::System.Runtime.InteropServices.DispId(-2147417108)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x170007D4 RID: 2004
		// (get) Token: 0x06000EBE RID: 3774
		[global::System.Runtime.InteropServices.DispId(-2147418104)]
		public virtual extern global::mshtml.IHTMLElement parentElement { [global::System.Runtime.InteropServices.DispId(-2147418104)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x170007D5 RID: 2005
		// (get) Token: 0x06000EBF RID: 3775
		[global::System.Runtime.InteropServices.DispId(-2147418038)]
		public virtual extern global::mshtml.IHTMLStyle style { [global::System.Runtime.InteropServices.DispId(-2147418038)] [global::System.Runtime.InteropServices.TypeLibFunc(1024)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x170007D6 RID: 2006
		// (get) Token: 0x06000EC1 RID: 3777
		// (set) Token: 0x06000EC0 RID: 3776
		[global::System.Runtime.InteropServices.DispId(-2147412099)]
		public virtual extern object onhelp { [global::System.Runtime.InteropServices.DispId(-2147412099)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147412099)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x170007D7 RID: 2007
		// (get) Token: 0x06000EC3 RID: 3779
		// (set) Token: 0x06000EC2 RID: 3778
		[global::System.Runtime.InteropServices.DispId(-2147412104)]
		public virtual extern object onclick { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412104)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412104)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x170007D8 RID: 2008
		// (get) Token: 0x06000EC5 RID: 3781
		// (set) Token: 0x06000EC4 RID: 3780
		[global::System.Runtime.InteropServices.DispId(-2147412103)]
		public virtual extern object ondblclick { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412103)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147412103)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x170007D9 RID: 2009
		// (get) Token: 0x06000EC7 RID: 3783
		// (set) Token: 0x06000EC6 RID: 3782
		[global::System.Runtime.InteropServices.DispId(-2147412107)]
		public virtual extern object onkeydown { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412107)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412107)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x170007DA RID: 2010
		// (get) Token: 0x06000EC9 RID: 3785
		// (set) Token: 0x06000EC8 RID: 3784
		[global::System.Runtime.InteropServices.DispId(-2147412106)]
		public virtual extern object onkeyup { [global::System.Runtime.InteropServices.DispId(-2147412106)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412106)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x170007DB RID: 2011
		// (get) Token: 0x06000ECB RID: 3787
		// (set) Token: 0x06000ECA RID: 3786
		[global::System.Runtime.InteropServices.DispId(-2147412105)]
		public virtual extern object onkeypress { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412105)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412105)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x170007DC RID: 2012
		// (get) Token: 0x06000ECD RID: 3789
		// (set) Token: 0x06000ECC RID: 3788
		[global::System.Runtime.InteropServices.DispId(-2147412111)]
		public virtual extern object onmouseout { [global::System.Runtime.InteropServices.DispId(-2147412111)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147412111)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x170007DD RID: 2013
		// (get) Token: 0x06000ECF RID: 3791
		// (set) Token: 0x06000ECE RID: 3790
		[global::System.Runtime.InteropServices.DispId(-2147412112)]
		public virtual extern object onmouseover { [global::System.Runtime.InteropServices.DispId(-2147412112)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147412112)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x170007DE RID: 2014
		// (get) Token: 0x06000ED1 RID: 3793
		// (set) Token: 0x06000ED0 RID: 3792
		[global::System.Runtime.InteropServices.DispId(-2147412108)]
		public virtual extern object onmousemove { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412108)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412108)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x170007DF RID: 2015
		// (get) Token: 0x06000ED3 RID: 3795
		// (set) Token: 0x06000ED2 RID: 3794
		[global::System.Runtime.InteropServices.DispId(-2147412110)]
		public virtual extern object onmousedown { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412110)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412110)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x170007E0 RID: 2016
		// (get) Token: 0x06000ED5 RID: 3797
		// (set) Token: 0x06000ED4 RID: 3796
		[global::System.Runtime.InteropServices.DispId(-2147412109)]
		public virtual extern object onmouseup { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412109)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147412109)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x170007E1 RID: 2017
		// (get) Token: 0x06000ED6 RID: 3798
		[global::System.Runtime.InteropServices.DispId(-2147417094)]
		public virtual extern object document { [global::System.Runtime.InteropServices.DispId(-2147417094)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] get; }

		// Token: 0x170007E2 RID: 2018
		// (get) Token: 0x06000ED8 RID: 3800
		// (set) Token: 0x06000ED7 RID: 3799
		[global::System.Runtime.InteropServices.DispId(-2147418043)]
		public virtual extern string title { [global::System.Runtime.InteropServices.DispId(-2147418043)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147418043)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] set; }

		// Token: 0x170007E3 RID: 2019
		// (get) Token: 0x06000EDA RID: 3802
		// (set) Token: 0x06000ED9 RID: 3801
		[global::System.Runtime.InteropServices.DispId(-2147413012)]
		public virtual extern string language { [global::System.Runtime.InteropServices.DispId(-2147413012)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(-2147413012)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] set; }

		// Token: 0x170007E4 RID: 2020
		// (get) Token: 0x06000EDC RID: 3804
		// (set) Token: 0x06000EDB RID: 3803
		[global::System.Runtime.InteropServices.DispId(-2147412075)]
		public virtual extern object onselectstart { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412075)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412075)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x06000EDD RID: 3805
		[global::System.Runtime.InteropServices.DispId(-2147417093)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void scrollIntoView([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] object varargStart);

		// Token: 0x06000EDE RID: 3806
		[global::System.Runtime.InteropServices.DispId(-2147417092)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern bool contains([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLElement pChild);

		// Token: 0x170007E5 RID: 2021
		// (get) Token: 0x06000EDF RID: 3807
		[global::System.Runtime.InteropServices.DispId(-2147417088)]
		public virtual extern int sourceIndex { [global::System.Runtime.InteropServices.TypeLibFunc(4)] [global::System.Runtime.InteropServices.DispId(-2147417088)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x170007E6 RID: 2022
		// (get) Token: 0x06000EE0 RID: 3808
		[global::System.Runtime.InteropServices.DispId(-2147417087)]
		public virtual extern object recordNumber { [global::System.Runtime.InteropServices.DispId(-2147417087)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; }

		// Token: 0x170007E7 RID: 2023
		// (get) Token: 0x06000EE2 RID: 3810
		// (set) Token: 0x06000EE1 RID: 3809
		[global::System.Runtime.InteropServices.DispId(-2147413103)]
		public virtual extern string lang { [global::System.Runtime.InteropServices.DispId(-2147413103)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(-2147413103)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] set; }

		// Token: 0x170007E8 RID: 2024
		// (get) Token: 0x06000EE3 RID: 3811
		[global::System.Runtime.InteropServices.DispId(-2147417104)]
		public virtual extern int offsetLeft { [global::System.Runtime.InteropServices.DispId(-2147417104)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x170007E9 RID: 2025
		// (get) Token: 0x06000EE4 RID: 3812
		[global::System.Runtime.InteropServices.DispId(-2147417103)]
		public virtual extern int offsetTop { [global::System.Runtime.InteropServices.DispId(-2147417103)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x170007EA RID: 2026
		// (get) Token: 0x06000EE5 RID: 3813
		[global::System.Runtime.InteropServices.DispId(-2147417102)]
		public virtual extern int offsetWidth { [global::System.Runtime.InteropServices.DispId(-2147417102)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x170007EB RID: 2027
		// (get) Token: 0x06000EE6 RID: 3814
		[global::System.Runtime.InteropServices.DispId(-2147417101)]
		public virtual extern int offsetHeight { [global::System.Runtime.InteropServices.DispId(-2147417101)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x170007EC RID: 2028
		// (get) Token: 0x06000EE7 RID: 3815
		[global::System.Runtime.InteropServices.DispId(-2147417100)]
		public virtual extern global::mshtml.IHTMLElement offsetParent { [global::System.Runtime.InteropServices.DispId(-2147417100)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x170007ED RID: 2029
		// (get) Token: 0x06000EE9 RID: 3817
		// (set) Token: 0x06000EE8 RID: 3816
		[global::System.Runtime.InteropServices.DispId(-2147417086)]
		public virtual extern string innerHTML { [global::System.Runtime.InteropServices.DispId(-2147417086)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(-2147417086)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] set; }

		// Token: 0x170007EE RID: 2030
		// (get) Token: 0x06000EEB RID: 3819
		// (set) Token: 0x06000EEA RID: 3818
		[global::System.Runtime.InteropServices.DispId(-2147417085)]
		public virtual extern string innerText { [global::System.Runtime.InteropServices.DispId(-2147417085)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(-2147417085)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] set; }

		// Token: 0x170007EF RID: 2031
		// (get) Token: 0x06000EED RID: 3821
		// (set) Token: 0x06000EEC RID: 3820
		[global::System.Runtime.InteropServices.DispId(-2147417084)]
		public virtual extern string outerHTML { [global::System.Runtime.InteropServices.DispId(-2147417084)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(-2147417084)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] set; }

		// Token: 0x170007F0 RID: 2032
		// (get) Token: 0x06000EEF RID: 3823
		// (set) Token: 0x06000EEE RID: 3822
		[global::System.Runtime.InteropServices.DispId(-2147417083)]
		public virtual extern string outerText { [global::System.Runtime.InteropServices.DispId(-2147417083)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(-2147417083)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] set; }

		// Token: 0x06000EF0 RID: 3824
		[global::System.Runtime.InteropServices.DispId(-2147417082)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void insertAdjacentHTML([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string where, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string html);

		// Token: 0x06000EF1 RID: 3825
		[global::System.Runtime.InteropServices.DispId(-2147417081)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void insertAdjacentText([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string where, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string text);

		// Token: 0x170007F1 RID: 2033
		// (get) Token: 0x06000EF2 RID: 3826
		[global::System.Runtime.InteropServices.DispId(-2147417080)]
		public virtual extern global::mshtml.IHTMLElement parentTextEdit { [global::System.Runtime.InteropServices.DispId(-2147417080)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x170007F2 RID: 2034
		// (get) Token: 0x06000EF3 RID: 3827
		[global::System.Runtime.InteropServices.DispId(-2147417078)]
		public virtual extern bool isTextEdit { [global::System.Runtime.InteropServices.DispId(-2147417078)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x06000EF4 RID: 3828
		[global::System.Runtime.InteropServices.DispId(-2147417079)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void click();

		// Token: 0x170007F3 RID: 2035
		// (get) Token: 0x06000EF5 RID: 3829
		[global::System.Runtime.InteropServices.DispId(-2147417077)]
		public virtual extern global::mshtml.IHTMLFiltersCollection filters { [global::System.Runtime.InteropServices.DispId(-2147417077)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x170007F4 RID: 2036
		// (get) Token: 0x06000EF7 RID: 3831
		// (set) Token: 0x06000EF6 RID: 3830
		[global::System.Runtime.InteropServices.DispId(-2147412077)]
		public virtual extern object ondragstart { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412077)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147412077)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x06000EF8 RID: 3832
		[global::System.Runtime.InteropServices.DispId(-2147417076)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public virtual extern string toString();

		// Token: 0x170007F5 RID: 2037
		// (get) Token: 0x06000EFA RID: 3834
		// (set) Token: 0x06000EF9 RID: 3833
		[global::System.Runtime.InteropServices.DispId(-2147412091)]
		public virtual extern object onbeforeupdate { [global::System.Runtime.InteropServices.DispId(-2147412091)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147412091)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x170007F6 RID: 2038
		// (get) Token: 0x06000EFC RID: 3836
		// (set) Token: 0x06000EFB RID: 3835
		[global::System.Runtime.InteropServices.DispId(-2147412090)]
		public virtual extern object onafterupdate { [global::System.Runtime.InteropServices.DispId(-2147412090)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147412090)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x170007F7 RID: 2039
		// (get) Token: 0x06000EFE RID: 3838
		// (set) Token: 0x06000EFD RID: 3837
		[global::System.Runtime.InteropServices.DispId(-2147412074)]
		public virtual extern object onerrorupdate { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412074)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412074)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x170007F8 RID: 2040
		// (get) Token: 0x06000F00 RID: 3840
		// (set) Token: 0x06000EFF RID: 3839
		[global::System.Runtime.InteropServices.DispId(-2147412094)]
		public virtual extern object onrowexit { [global::System.Runtime.InteropServices.DispId(-2147412094)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412094)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x170007F9 RID: 2041
		// (get) Token: 0x06000F02 RID: 3842
		// (set) Token: 0x06000F01 RID: 3841
		[global::System.Runtime.InteropServices.DispId(-2147412093)]
		public virtual extern object onrowenter { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412093)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147412093)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x170007FA RID: 2042
		// (get) Token: 0x06000F04 RID: 3844
		// (set) Token: 0x06000F03 RID: 3843
		[global::System.Runtime.InteropServices.DispId(-2147412072)]
		public virtual extern object ondatasetchanged { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412072)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412072)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x170007FB RID: 2043
		// (get) Token: 0x06000F06 RID: 3846
		// (set) Token: 0x06000F05 RID: 3845
		[global::System.Runtime.InteropServices.DispId(-2147412071)]
		public virtual extern object ondataavailable { [global::System.Runtime.InteropServices.DispId(-2147412071)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412071)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x170007FC RID: 2044
		// (get) Token: 0x06000F08 RID: 3848
		// (set) Token: 0x06000F07 RID: 3847
		[global::System.Runtime.InteropServices.DispId(-2147412070)]
		public virtual extern object ondatasetcomplete { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412070)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412070)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x170007FD RID: 2045
		// (get) Token: 0x06000F0A RID: 3850
		// (set) Token: 0x06000F09 RID: 3849
		[global::System.Runtime.InteropServices.DispId(-2147412069)]
		public virtual extern object onfilterchange { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412069)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147412069)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x170007FE RID: 2046
		// (get) Token: 0x06000F0B RID: 3851
		[global::System.Runtime.InteropServices.DispId(-2147417075)]
		public virtual extern object children { [global::System.Runtime.InteropServices.DispId(-2147417075)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] get; }

		// Token: 0x170007FF RID: 2047
		// (get) Token: 0x06000F0C RID: 3852
		[global::System.Runtime.InteropServices.DispId(-2147417074)]
		public virtual extern object all { [global::System.Runtime.InteropServices.DispId(-2147417074)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] get; }

		// Token: 0x17000800 RID: 2048
		// (get) Token: 0x06000F0D RID: 3853
		[global::System.Runtime.InteropServices.DispId(-2147417073)]
		public virtual extern string scopeName { [global::System.Runtime.InteropServices.DispId(-2147417073)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x06000F0E RID: 3854
		[global::System.Runtime.InteropServices.DispId(-2147417072)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void setCapture([global::System.Runtime.InteropServices.In] bool containerCapture = true);

		// Token: 0x06000F0F RID: 3855
		[global::System.Runtime.InteropServices.DispId(-2147417071)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void releaseCapture();

		// Token: 0x17000801 RID: 2049
		// (get) Token: 0x06000F11 RID: 3857
		// (set) Token: 0x06000F10 RID: 3856
		[global::System.Runtime.InteropServices.DispId(-2147412066)]
		public virtual extern object onlosecapture { [global::System.Runtime.InteropServices.DispId(-2147412066)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147412066)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x06000F12 RID: 3858
		[global::System.Runtime.InteropServices.DispId(-2147417070)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public virtual extern string componentFromPoint([global::System.Runtime.InteropServices.In] int x, [global::System.Runtime.InteropServices.In] int y);

		// Token: 0x06000F13 RID: 3859
		[global::System.Runtime.InteropServices.DispId(-2147417069)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void doScroll([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] object component);

		// Token: 0x17000802 RID: 2050
		// (get) Token: 0x06000F15 RID: 3861
		// (set) Token: 0x06000F14 RID: 3860
		[global::System.Runtime.InteropServices.DispId(-2147412081)]
		public virtual extern object onscroll { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412081)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412081)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x17000803 RID: 2051
		// (get) Token: 0x06000F17 RID: 3863
		// (set) Token: 0x06000F16 RID: 3862
		[global::System.Runtime.InteropServices.DispId(-2147412063)]
		public virtual extern object ondrag { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412063)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147412063)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x17000804 RID: 2052
		// (get) Token: 0x06000F19 RID: 3865
		// (set) Token: 0x06000F18 RID: 3864
		[global::System.Runtime.InteropServices.DispId(-2147412062)]
		public virtual extern object ondragend { [global::System.Runtime.InteropServices.DispId(-2147412062)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412062)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x17000805 RID: 2053
		// (get) Token: 0x06000F1B RID: 3867
		// (set) Token: 0x06000F1A RID: 3866
		[global::System.Runtime.InteropServices.DispId(-2147412061)]
		public virtual extern object ondragenter { [global::System.Runtime.InteropServices.DispId(-2147412061)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147412061)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x17000806 RID: 2054
		// (get) Token: 0x06000F1D RID: 3869
		// (set) Token: 0x06000F1C RID: 3868
		[global::System.Runtime.InteropServices.DispId(-2147412060)]
		public virtual extern object ondragover { [global::System.Runtime.InteropServices.DispId(-2147412060)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147412060)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x17000807 RID: 2055
		// (get) Token: 0x06000F1F RID: 3871
		// (set) Token: 0x06000F1E RID: 3870
		[global::System.Runtime.InteropServices.DispId(-2147412059)]
		public virtual extern object ondragleave { [global::System.Runtime.InteropServices.DispId(-2147412059)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412059)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x17000808 RID: 2056
		// (get) Token: 0x06000F21 RID: 3873
		// (set) Token: 0x06000F20 RID: 3872
		[global::System.Runtime.InteropServices.DispId(-2147412058)]
		public virtual extern object ondrop { [global::System.Runtime.InteropServices.DispId(-2147412058)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147412058)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x17000809 RID: 2057
		// (get) Token: 0x06000F23 RID: 3875
		// (set) Token: 0x06000F22 RID: 3874
		[global::System.Runtime.InteropServices.DispId(-2147412054)]
		public virtual extern object onbeforecut { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412054)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412054)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x1700080A RID: 2058
		// (get) Token: 0x06000F25 RID: 3877
		// (set) Token: 0x06000F24 RID: 3876
		[global::System.Runtime.InteropServices.DispId(-2147412057)]
		public virtual extern object oncut { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412057)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412057)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x1700080B RID: 2059
		// (get) Token: 0x06000F27 RID: 3879
		// (set) Token: 0x06000F26 RID: 3878
		[global::System.Runtime.InteropServices.DispId(-2147412053)]
		public virtual extern object onbeforecopy { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412053)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147412053)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x1700080C RID: 2060
		// (get) Token: 0x06000F29 RID: 3881
		// (set) Token: 0x06000F28 RID: 3880
		[global::System.Runtime.InteropServices.DispId(-2147412056)]
		public virtual extern object oncopy { [global::System.Runtime.InteropServices.DispId(-2147412056)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147412056)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x1700080D RID: 2061
		// (get) Token: 0x06000F2B RID: 3883
		// (set) Token: 0x06000F2A RID: 3882
		[global::System.Runtime.InteropServices.DispId(-2147412052)]
		public virtual extern object onbeforepaste { [global::System.Runtime.InteropServices.DispId(-2147412052)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412052)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x1700080E RID: 2062
		// (get) Token: 0x06000F2D RID: 3885
		// (set) Token: 0x06000F2C RID: 3884
		[global::System.Runtime.InteropServices.DispId(-2147412055)]
		public virtual extern object onpaste { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412055)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412055)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x1700080F RID: 2063
		// (get) Token: 0x06000F2E RID: 3886
		[global::System.Runtime.InteropServices.DispId(-2147417105)]
		public virtual extern global::mshtml.IHTMLCurrentStyle currentStyle { [global::System.Runtime.InteropServices.DispId(-2147417105)] [global::System.Runtime.InteropServices.TypeLibFunc(1024)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x17000810 RID: 2064
		// (get) Token: 0x06000F30 RID: 3888
		// (set) Token: 0x06000F2F RID: 3887
		[global::System.Runtime.InteropServices.DispId(-2147412065)]
		public virtual extern object onpropertychange { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412065)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147412065)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x06000F31 RID: 3889
		[global::System.Runtime.InteropServices.DispId(-2147417068)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		public virtual extern global::mshtml.IHTMLRectCollection getClientRects();

		// Token: 0x06000F32 RID: 3890
		[global::System.Runtime.InteropServices.DispId(-2147417067)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		public virtual extern global::mshtml.IHTMLRect getBoundingClientRect();

		// Token: 0x06000F33 RID: 3891
		[global::System.Runtime.InteropServices.DispId(-2147417608)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void setExpression([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string propname, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string expression, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string language = "");

		// Token: 0x06000F34 RID: 3892
		[global::System.Runtime.InteropServices.DispId(-2147417607)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)]
		public virtual extern object getExpression([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string propname);

		// Token: 0x06000F35 RID: 3893
		[global::System.Runtime.InteropServices.DispId(-2147417606)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern bool removeExpression([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string propname);

		// Token: 0x17000811 RID: 2065
		// (get) Token: 0x06000F37 RID: 3895
		// (set) Token: 0x06000F36 RID: 3894
		[global::System.Runtime.InteropServices.DispId(-2147418097)]
		public virtual extern short tabIndex { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147418097)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147418097)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] set; }

		// Token: 0x06000F38 RID: 3896
		[global::System.Runtime.InteropServices.DispId(-2147416112)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void focus();

		// Token: 0x17000812 RID: 2066
		// (get) Token: 0x06000F3A RID: 3898
		// (set) Token: 0x06000F39 RID: 3897
		[global::System.Runtime.InteropServices.DispId(-2147416107)]
		public virtual extern string accessKey { [global::System.Runtime.InteropServices.DispId(-2147416107)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147416107)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] set; }

		// Token: 0x17000813 RID: 2067
		// (get) Token: 0x06000F3C RID: 3900
		// (set) Token: 0x06000F3B RID: 3899
		[global::System.Runtime.InteropServices.DispId(-2147412097)]
		public virtual extern object onblur { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412097)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147412097)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x17000814 RID: 2068
		// (get) Token: 0x06000F3E RID: 3902
		// (set) Token: 0x06000F3D RID: 3901
		[global::System.Runtime.InteropServices.DispId(-2147412098)]
		public virtual extern object onfocus { [global::System.Runtime.InteropServices.DispId(-2147412098)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412098)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x17000815 RID: 2069
		// (get) Token: 0x06000F40 RID: 3904
		// (set) Token: 0x06000F3F RID: 3903
		[global::System.Runtime.InteropServices.DispId(-2147412076)]
		public virtual extern object onresize { [global::System.Runtime.InteropServices.DispId(-2147412076)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147412076)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x06000F41 RID: 3905
		[global::System.Runtime.InteropServices.DispId(-2147416110)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void blur();

		// Token: 0x06000F42 RID: 3906
		[global::System.Runtime.InteropServices.DispId(-2147416095)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void addFilter([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IUnknown)] [global::System.Runtime.InteropServices.In] object pUnk);

		// Token: 0x06000F43 RID: 3907
		[global::System.Runtime.InteropServices.DispId(-2147416094)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void removeFilter([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IUnknown)] [global::System.Runtime.InteropServices.In] object pUnk);

		// Token: 0x17000816 RID: 2070
		// (get) Token: 0x06000F44 RID: 3908
		[global::System.Runtime.InteropServices.DispId(-2147416093)]
		public virtual extern int clientHeight { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147416093)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000817 RID: 2071
		// (get) Token: 0x06000F45 RID: 3909
		[global::System.Runtime.InteropServices.DispId(-2147416092)]
		public virtual extern int clientWidth { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147416092)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000818 RID: 2072
		// (get) Token: 0x06000F46 RID: 3910
		[global::System.Runtime.InteropServices.DispId(-2147416091)]
		public virtual extern int clientTop { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147416091)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000819 RID: 2073
		// (get) Token: 0x06000F47 RID: 3911
		[global::System.Runtime.InteropServices.DispId(-2147416090)]
		public virtual extern int clientLeft { [global::System.Runtime.InteropServices.DispId(-2147416090)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x06000F48 RID: 3912
		[global::System.Runtime.InteropServices.DispId(-2147417605)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern bool attachEvent([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string @event, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] [global::System.Runtime.InteropServices.In] object pdisp);

		// Token: 0x06000F49 RID: 3913
		[global::System.Runtime.InteropServices.DispId(-2147417604)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void detachEvent([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string @event, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] [global::System.Runtime.InteropServices.In] object pdisp);

		// Token: 0x1700081A RID: 2074
		// (get) Token: 0x06000F4A RID: 3914
		[global::System.Runtime.InteropServices.DispId(-2147412996)]
		public virtual extern object readyState { [global::System.Runtime.InteropServices.DispId(-2147412996)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; }

		// Token: 0x1700081B RID: 2075
		// (get) Token: 0x06000F4C RID: 3916
		// (set) Token: 0x06000F4B RID: 3915
		[global::System.Runtime.InteropServices.DispId(-2147412087)]
		public virtual extern object onreadystatechange { [global::System.Runtime.InteropServices.DispId(-2147412087)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412087)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x1700081C RID: 2076
		// (get) Token: 0x06000F4E RID: 3918
		// (set) Token: 0x06000F4D RID: 3917
		[global::System.Runtime.InteropServices.DispId(-2147412050)]
		public virtual extern object onrowsdelete { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412050)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412050)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x1700081D RID: 2077
		// (get) Token: 0x06000F50 RID: 3920
		// (set) Token: 0x06000F4F RID: 3919
		[global::System.Runtime.InteropServices.DispId(-2147412049)]
		public virtual extern object onrowsinserted { [global::System.Runtime.InteropServices.DispId(-2147412049)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147412049)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x1700081E RID: 2078
		// (get) Token: 0x06000F52 RID: 3922
		// (set) Token: 0x06000F51 RID: 3921
		[global::System.Runtime.InteropServices.DispId(-2147412048)]
		public virtual extern object oncellchange { [global::System.Runtime.InteropServices.DispId(-2147412048)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147412048)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x1700081F RID: 2079
		// (get) Token: 0x06000F54 RID: 3924
		// (set) Token: 0x06000F53 RID: 3923
		[global::System.Runtime.InteropServices.DispId(-2147412995)]
		public virtual extern string dir { [global::System.Runtime.InteropServices.DispId(-2147412995)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412995)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] set; }

		// Token: 0x06000F55 RID: 3925
		[global::System.Runtime.InteropServices.DispId(-2147417056)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)]
		public virtual extern object createControlRange();

		// Token: 0x17000820 RID: 2080
		// (get) Token: 0x06000F56 RID: 3926
		[global::System.Runtime.InteropServices.DispId(-2147417055)]
		public virtual extern int scrollHeight { [global::System.Runtime.InteropServices.DispId(-2147417055)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000821 RID: 2081
		// (get) Token: 0x06000F57 RID: 3927
		[global::System.Runtime.InteropServices.DispId(-2147417054)]
		public virtual extern int scrollWidth { [global::System.Runtime.InteropServices.DispId(-2147417054)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000822 RID: 2082
		// (get) Token: 0x06000F59 RID: 3929
		// (set) Token: 0x06000F58 RID: 3928
		[global::System.Runtime.InteropServices.DispId(-2147417053)]
		public virtual extern int scrollTop { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147417053)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(-2147417053)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000823 RID: 2083
		// (get) Token: 0x06000F5B RID: 3931
		// (set) Token: 0x06000F5A RID: 3930
		[global::System.Runtime.InteropServices.DispId(-2147417052)]
		public virtual extern int scrollLeft { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147417052)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(-2147417052)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] set; }

		// Token: 0x06000F5C RID: 3932
		[global::System.Runtime.InteropServices.DispId(-2147417050)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void clearAttributes();

		// Token: 0x17000824 RID: 2084
		// (get) Token: 0x06000F5E RID: 3934
		// (set) Token: 0x06000F5D RID: 3933
		[global::System.Runtime.InteropServices.DispId(-2147412047)]
		public virtual extern object oncontextmenu { [global::System.Runtime.InteropServices.DispId(-2147412047)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147412047)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x06000F5F RID: 3935
		[global::System.Runtime.InteropServices.DispId(-2147417043)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		public virtual extern global::mshtml.IHTMLElement insertAdjacentElement([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string where, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLElement insertedElement);

		// Token: 0x06000F60 RID: 3936
		[global::System.Runtime.InteropServices.DispId(-2147417047)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		public virtual extern global::mshtml.IHTMLElement applyElement([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLElement apply, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string where);

		// Token: 0x06000F61 RID: 3937
		[global::System.Runtime.InteropServices.DispId(-2147417042)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public virtual extern string getAdjacentText([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string where);

		// Token: 0x06000F62 RID: 3938
		[global::System.Runtime.InteropServices.DispId(-2147417041)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public virtual extern string replaceAdjacentText([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string where, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string newText);

		// Token: 0x17000825 RID: 2085
		// (get) Token: 0x06000F63 RID: 3939
		[global::System.Runtime.InteropServices.DispId(-2147417040)]
		public virtual extern bool canHaveChildren { [global::System.Runtime.InteropServices.DispId(-2147417040)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x06000F64 RID: 3940
		[global::System.Runtime.InteropServices.DispId(-2147417032)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern int addBehavior([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string bstrUrl, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object pvarFactory);

		// Token: 0x06000F65 RID: 3941
		[global::System.Runtime.InteropServices.DispId(-2147417031)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern bool removeBehavior([global::System.Runtime.InteropServices.In] int cookie);

		// Token: 0x17000826 RID: 2086
		// (get) Token: 0x06000F66 RID: 3942
		[global::System.Runtime.InteropServices.DispId(-2147417048)]
		public virtual extern global::mshtml.IHTMLStyle runtimeStyle { [global::System.Runtime.InteropServices.TypeLibFunc(1024)] [global::System.Runtime.InteropServices.DispId(-2147417048)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x17000827 RID: 2087
		// (get) Token: 0x06000F67 RID: 3943
		[global::System.Runtime.InteropServices.DispId(-2147417030)]
		public virtual extern object behaviorUrns { [global::System.Runtime.InteropServices.DispId(-2147417030)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] get; }

		// Token: 0x17000828 RID: 2088
		// (get) Token: 0x06000F69 RID: 3945
		// (set) Token: 0x06000F68 RID: 3944
		[global::System.Runtime.InteropServices.DispId(-2147417029)]
		public virtual extern string tagUrn { [global::System.Runtime.InteropServices.DispId(-2147417029)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(-2147417029)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] set; }

		// Token: 0x17000829 RID: 2089
		// (get) Token: 0x06000F6B RID: 3947
		// (set) Token: 0x06000F6A RID: 3946
		[global::System.Runtime.InteropServices.DispId(-2147412043)]
		public virtual extern object onbeforeeditfocus { [global::System.Runtime.InteropServices.DispId(-2147412043)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147412043)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x1700082A RID: 2090
		// (get) Token: 0x06000F6C RID: 3948
		[global::System.Runtime.InteropServices.DispId(-2147417028)]
		public virtual extern int readyStateValue { [global::System.Runtime.InteropServices.TypeLibFunc(65)] [global::System.Runtime.InteropServices.DispId(-2147417028)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x06000F6D RID: 3949
		[global::System.Runtime.InteropServices.DispId(-2147417027)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		public virtual extern global::mshtml.IHTMLElementCollection getElementsByTagName([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string v);

		// Token: 0x06000F6E RID: 3950
		[global::System.Runtime.InteropServices.DispId(-2147417016)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void mergeAttributes([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLElement mergeThis, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object pvarFlags);

		// Token: 0x1700082B RID: 2091
		// (get) Token: 0x06000F6F RID: 3951
		[global::System.Runtime.InteropServices.DispId(-2147417015)]
		public virtual extern bool isMultiLine { [global::System.Runtime.InteropServices.DispId(-2147417015)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700082C RID: 2092
		// (get) Token: 0x06000F70 RID: 3952
		[global::System.Runtime.InteropServices.DispId(-2147417014)]
		public virtual extern bool canHaveHTML { [global::System.Runtime.InteropServices.DispId(-2147417014)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700082D RID: 2093
		// (get) Token: 0x06000F72 RID: 3954
		// (set) Token: 0x06000F71 RID: 3953
		[global::System.Runtime.InteropServices.DispId(-2147412039)]
		public virtual extern object onlayoutcomplete { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412039)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147412039)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x1700082E RID: 2094
		// (get) Token: 0x06000F74 RID: 3956
		// (set) Token: 0x06000F73 RID: 3955
		[global::System.Runtime.InteropServices.DispId(-2147412038)]
		public virtual extern object onpage { [global::System.Runtime.InteropServices.DispId(-2147412038)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412038)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x1700082F RID: 2095
		// (get) Token: 0x06000F76 RID: 3958
		// (set) Token: 0x06000F75 RID: 3957
		[global::System.Runtime.InteropServices.DispId(-2147417012)]
		public virtual extern bool inflateBlock { [global::System.Runtime.InteropServices.TypeLibFunc(1089)] [global::System.Runtime.InteropServices.DispId(-2147417012)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.TypeLibFunc(1089)] [global::System.Runtime.InteropServices.DispId(-2147417012)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000830 RID: 2096
		// (get) Token: 0x06000F78 RID: 3960
		// (set) Token: 0x06000F77 RID: 3959
		[global::System.Runtime.InteropServices.DispId(-2147412035)]
		public virtual extern object onbeforedeactivate { [global::System.Runtime.InteropServices.DispId(-2147412035)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147412035)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x06000F79 RID: 3961
		[global::System.Runtime.InteropServices.DispId(-2147417011)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void setActive();

		// Token: 0x17000831 RID: 2097
		// (get) Token: 0x06000F7B RID: 3963
		// (set) Token: 0x06000F7A RID: 3962
		[global::System.Runtime.InteropServices.DispId(-2147412950)]
		public virtual extern string contentEditable { [global::System.Runtime.InteropServices.DispId(-2147412950)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412950)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] set; }

		// Token: 0x17000832 RID: 2098
		// (get) Token: 0x06000F7C RID: 3964
		[global::System.Runtime.InteropServices.DispId(-2147417010)]
		public virtual extern bool isContentEditable { [global::System.Runtime.InteropServices.DispId(-2147417010)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000833 RID: 2099
		// (get) Token: 0x06000F7E RID: 3966
		// (set) Token: 0x06000F7D RID: 3965
		[global::System.Runtime.InteropServices.DispId(-2147412949)]
		public virtual extern bool hideFocus { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412949)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412949)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000834 RID: 2100
		// (get) Token: 0x06000F80 RID: 3968
		// (set) Token: 0x06000F7F RID: 3967
		[global::System.Runtime.InteropServices.DispId(-2147418036)]
		public virtual extern bool disabled { [global::System.Runtime.InteropServices.DispId(-2147418036)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147418036)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000835 RID: 2101
		// (get) Token: 0x06000F81 RID: 3969
		[global::System.Runtime.InteropServices.DispId(-2147417007)]
		public virtual extern bool isDisabled { [global::System.Runtime.InteropServices.DispId(-2147417007)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000836 RID: 2102
		// (get) Token: 0x06000F83 RID: 3971
		// (set) Token: 0x06000F82 RID: 3970
		[global::System.Runtime.InteropServices.DispId(-2147412034)]
		public virtual extern object onmove { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412034)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412034)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x17000837 RID: 2103
		// (get) Token: 0x06000F85 RID: 3973
		// (set) Token: 0x06000F84 RID: 3972
		[global::System.Runtime.InteropServices.DispId(-2147412033)]
		public virtual extern object oncontrolselect { [global::System.Runtime.InteropServices.DispId(-2147412033)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412033)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x06000F86 RID: 3974
		[global::System.Runtime.InteropServices.DispId(-2147417006)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern bool FireEvent([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string bstrEventName, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object pvarEventObject);

		// Token: 0x17000838 RID: 2104
		// (get) Token: 0x06000F88 RID: 3976
		// (set) Token: 0x06000F87 RID: 3975
		[global::System.Runtime.InteropServices.DispId(-2147412029)]
		public virtual extern object onresizestart { [global::System.Runtime.InteropServices.DispId(-2147412029)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412029)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x17000839 RID: 2105
		// (get) Token: 0x06000F8A RID: 3978
		// (set) Token: 0x06000F89 RID: 3977
		[global::System.Runtime.InteropServices.DispId(-2147412028)]
		public virtual extern object onresizeend { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412028)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412028)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x1700083A RID: 2106
		// (get) Token: 0x06000F8C RID: 3980
		// (set) Token: 0x06000F8B RID: 3979
		[global::System.Runtime.InteropServices.DispId(-2147412031)]
		public virtual extern object onmovestart { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412031)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147412031)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x1700083B RID: 2107
		// (get) Token: 0x06000F8E RID: 3982
		// (set) Token: 0x06000F8D RID: 3981
		[global::System.Runtime.InteropServices.DispId(-2147412030)]
		public virtual extern object onmoveend { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412030)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412030)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x1700083C RID: 2108
		// (get) Token: 0x06000F90 RID: 3984
		// (set) Token: 0x06000F8F RID: 3983
		[global::System.Runtime.InteropServices.DispId(-2147412027)]
		public virtual extern object onmouseenter { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412027)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147412027)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x1700083D RID: 2109
		// (get) Token: 0x06000F92 RID: 3986
		// (set) Token: 0x06000F91 RID: 3985
		[global::System.Runtime.InteropServices.DispId(-2147412026)]
		public virtual extern object onmouseleave { [global::System.Runtime.InteropServices.DispId(-2147412026)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147412026)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x1700083E RID: 2110
		// (get) Token: 0x06000F94 RID: 3988
		// (set) Token: 0x06000F93 RID: 3987
		[global::System.Runtime.InteropServices.DispId(-2147412025)]
		public virtual extern object onactivate { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412025)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412025)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x1700083F RID: 2111
		// (get) Token: 0x06000F96 RID: 3990
		// (set) Token: 0x06000F95 RID: 3989
		[global::System.Runtime.InteropServices.DispId(-2147412024)]
		public virtual extern object ondeactivate { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412024)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147412024)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x06000F97 RID: 3991
		[global::System.Runtime.InteropServices.DispId(-2147417005)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern bool dragDrop();

		// Token: 0x17000840 RID: 2112
		// (get) Token: 0x06000F98 RID: 3992
		[global::System.Runtime.InteropServices.DispId(-2147417004)]
		public virtual extern int glyphMode { [global::System.Runtime.InteropServices.DispId(-2147417004)] [global::System.Runtime.InteropServices.TypeLibFunc(1089)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000841 RID: 2113
		// (get) Token: 0x06000F9A RID: 3994
		// (set) Token: 0x06000F99 RID: 3993
		[global::System.Runtime.InteropServices.DispId(-2147412036)]
		public virtual extern object onmousewheel { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412036)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412036)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x06000F9B RID: 3995
		[global::System.Runtime.InteropServices.DispId(-2147417000)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void normalize();

		// Token: 0x06000F9C RID: 3996
		[global::System.Runtime.InteropServices.DispId(-2147417003)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		public virtual extern global::mshtml.IHTMLDOMAttribute getAttributeNode([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string bstrName);

		// Token: 0x06000F9D RID: 3997
		[global::System.Runtime.InteropServices.DispId(-2147417002)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		public virtual extern global::mshtml.IHTMLDOMAttribute setAttributeNode([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLDOMAttribute pattr);

		// Token: 0x06000F9E RID: 3998
		[global::System.Runtime.InteropServices.DispId(-2147417001)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		public virtual extern global::mshtml.IHTMLDOMAttribute removeAttributeNode([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLDOMAttribute pattr);

		// Token: 0x17000842 RID: 2114
		// (get) Token: 0x06000FA0 RID: 4000
		// (set) Token: 0x06000F9F RID: 3999
		[global::System.Runtime.InteropServices.DispId(-2147412022)]
		public virtual extern object onbeforeactivate { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412022)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412022)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x17000843 RID: 2115
		// (get) Token: 0x06000FA2 RID: 4002
		// (set) Token: 0x06000FA1 RID: 4001
		[global::System.Runtime.InteropServices.DispId(-2147412021)]
		public virtual extern object onfocusin { [global::System.Runtime.InteropServices.DispId(-2147412021)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412021)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x17000844 RID: 2116
		// (get) Token: 0x06000FA4 RID: 4004
		// (set) Token: 0x06000FA3 RID: 4003
		[global::System.Runtime.InteropServices.DispId(-2147412020)]
		public virtual extern object onfocusout { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412020)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412020)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x17000845 RID: 2117
		// (get) Token: 0x06000FA5 RID: 4005
		[global::System.Runtime.InteropServices.DispId(-2147417058)]
		public virtual extern int uniqueNumber { [global::System.Runtime.InteropServices.TypeLibFunc(64)] [global::System.Runtime.InteropServices.DispId(-2147417058)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000846 RID: 2118
		// (get) Token: 0x06000FA6 RID: 4006
		[global::System.Runtime.InteropServices.DispId(-2147417057)]
		public virtual extern string uniqueID { [global::System.Runtime.InteropServices.TypeLibFunc(64)] [global::System.Runtime.InteropServices.DispId(-2147417057)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x17000847 RID: 2119
		// (get) Token: 0x06000FA7 RID: 4007
		[global::System.Runtime.InteropServices.DispId(-2147417066)]
		public virtual extern int nodeType { [global::System.Runtime.InteropServices.DispId(-2147417066)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000848 RID: 2120
		// (get) Token: 0x06000FA8 RID: 4008
		[global::System.Runtime.InteropServices.DispId(-2147417065)]
		public virtual extern global::mshtml.IHTMLDOMNode parentNode { [global::System.Runtime.InteropServices.DispId(-2147417065)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x06000FA9 RID: 4009
		[global::System.Runtime.InteropServices.DispId(-2147417064)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern bool hasChildNodes();

		// Token: 0x17000849 RID: 2121
		// (get) Token: 0x06000FAA RID: 4010
		[global::System.Runtime.InteropServices.DispId(-2147417063)]
		public virtual extern object childNodes { [global::System.Runtime.InteropServices.DispId(-2147417063)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] get; }

		// Token: 0x1700084A RID: 2122
		// (get) Token: 0x06000FAB RID: 4011
		[global::System.Runtime.InteropServices.DispId(-2147417062)]
		public virtual extern object attributes { [global::System.Runtime.InteropServices.DispId(-2147417062)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] get; }

		// Token: 0x06000FAC RID: 4012
		[global::System.Runtime.InteropServices.DispId(-2147417061)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		public virtual extern global::mshtml.IHTMLDOMNode insertBefore([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLDOMNode newChild, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] object refChild);

		// Token: 0x06000FAD RID: 4013
		[global::System.Runtime.InteropServices.DispId(-2147417060)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		public virtual extern global::mshtml.IHTMLDOMNode removeChild([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLDOMNode oldChild);

		// Token: 0x06000FAE RID: 4014
		[global::System.Runtime.InteropServices.DispId(-2147417059)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		public virtual extern global::mshtml.IHTMLDOMNode replaceChild([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLDOMNode newChild, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLDOMNode oldChild);

		// Token: 0x06000FAF RID: 4015
		[global::System.Runtime.InteropServices.DispId(-2147417051)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		public virtual extern global::mshtml.IHTMLDOMNode cloneNode([global::System.Runtime.InteropServices.In] bool fDeep);

		// Token: 0x06000FB0 RID: 4016
		[global::System.Runtime.InteropServices.DispId(-2147417046)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		public virtual extern global::mshtml.IHTMLDOMNode removeNode([global::System.Runtime.InteropServices.In] bool fDeep = false);

		// Token: 0x06000FB1 RID: 4017
		[global::System.Runtime.InteropServices.DispId(-2147417044)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		public virtual extern global::mshtml.IHTMLDOMNode swapNode([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLDOMNode otherNode);

		// Token: 0x06000FB2 RID: 4018
		[global::System.Runtime.InteropServices.DispId(-2147417045)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		public virtual extern global::mshtml.IHTMLDOMNode replaceNode([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLDOMNode replacement);

		// Token: 0x06000FB3 RID: 4019
		[global::System.Runtime.InteropServices.DispId(-2147417039)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		public virtual extern global::mshtml.IHTMLDOMNode appendChild([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLDOMNode newChild);

		// Token: 0x1700084B RID: 2123
		// (get) Token: 0x06000FB4 RID: 4020
		[global::System.Runtime.InteropServices.DispId(-2147417038)]
		public virtual extern string nodeName { [global::System.Runtime.InteropServices.DispId(-2147417038)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x1700084C RID: 2124
		// (get) Token: 0x06000FB6 RID: 4022
		// (set) Token: 0x06000FB5 RID: 4021
		[global::System.Runtime.InteropServices.DispId(-2147417037)]
		public virtual extern object nodeValue { [global::System.Runtime.InteropServices.DispId(-2147417037)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147417037)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x1700084D RID: 2125
		// (get) Token: 0x06000FB7 RID: 4023
		[global::System.Runtime.InteropServices.DispId(-2147417036)]
		public virtual extern global::mshtml.IHTMLDOMNode firstChild { [global::System.Runtime.InteropServices.DispId(-2147417036)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x1700084E RID: 2126
		// (get) Token: 0x06000FB8 RID: 4024
		[global::System.Runtime.InteropServices.DispId(-2147417035)]
		public virtual extern global::mshtml.IHTMLDOMNode lastChild { [global::System.Runtime.InteropServices.DispId(-2147417035)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x1700084F RID: 2127
		// (get) Token: 0x06000FB9 RID: 4025
		[global::System.Runtime.InteropServices.DispId(-2147417034)]
		public virtual extern global::mshtml.IHTMLDOMNode previousSibling { [global::System.Runtime.InteropServices.DispId(-2147417034)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x17000850 RID: 2128
		// (get) Token: 0x06000FBA RID: 4026
		[global::System.Runtime.InteropServices.DispId(-2147417033)]
		public virtual extern global::mshtml.IHTMLDOMNode nextSibling { [global::System.Runtime.InteropServices.DispId(-2147417033)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x17000851 RID: 2129
		// (get) Token: 0x06000FBB RID: 4027
		[global::System.Runtime.InteropServices.DispId(-2147416999)]
		public virtual extern object ownerDocument { [global::System.Runtime.InteropServices.DispId(-2147416999)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] get; }

		// Token: 0x17000852 RID: 2130
		// (get) Token: 0x06000FBC RID: 4028
		[global::System.Runtime.InteropServices.DispId(1001)]
		public virtual extern object recordset { [global::System.Runtime.InteropServices.DispId(1001)] [global::System.Runtime.InteropServices.TypeLibFunc(64)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] get; }

		// Token: 0x06000FBD RID: 4029
		[global::System.Runtime.InteropServices.DispId(1002)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)]
		public virtual extern object namedRecordset([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string dataMember, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object hierarchy);

		// Token: 0x06000FBE RID: 4030
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void IHTMLElement_setAttribute([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string strAttributeName, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] object AttributeValue, [global::System.Runtime.InteropServices.In] int lFlags = 1);

		// Token: 0x06000FBF RID: 4031
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)]
		public virtual extern object IHTMLElement_getAttribute([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string strAttributeName, [global::System.Runtime.InteropServices.In] int lFlags = 0);

		// Token: 0x06000FC0 RID: 4032
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern bool IHTMLElement_removeAttribute([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string strAttributeName, [global::System.Runtime.InteropServices.In] int lFlags = 1);

		// Token: 0x17000853 RID: 2131
		// (get) Token: 0x06000FC2 RID: 4034
		// (set) Token: 0x06000FC1 RID: 4033
		public virtual extern string IHTMLElement_className { [global::System.Runtime.InteropServices.TypeLibFunc(4)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.TypeLibFunc(4)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000854 RID: 2132
		// (get) Token: 0x06000FC4 RID: 4036
		// (set) Token: 0x06000FC3 RID: 4035
		public virtual extern string IHTMLElement_id { [global::System.Runtime.InteropServices.TypeLibFunc(4)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.TypeLibFunc(4)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000855 RID: 2133
		// (get) Token: 0x06000FC5 RID: 4037
		public virtual extern string IHTMLElement_tagName { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x17000856 RID: 2134
		// (get) Token: 0x06000FC6 RID: 4038
		public virtual extern global::mshtml.IHTMLElement IHTMLElement_parentElement { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x17000857 RID: 2135
		// (get) Token: 0x06000FC7 RID: 4039
		public virtual extern global::mshtml.IHTMLStyle IHTMLElement_style { [global::System.Runtime.InteropServices.TypeLibFunc(1024)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x17000858 RID: 2136
		// (get) Token: 0x06000FC9 RID: 4041
		// (set) Token: 0x06000FC8 RID: 4040
		public virtual extern object IHTMLElement_onhelp { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000859 RID: 2137
		// (get) Token: 0x06000FCB RID: 4043
		// (set) Token: 0x06000FCA RID: 4042
		public virtual extern object IHTMLElement_onclick { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700085A RID: 2138
		// (get) Token: 0x06000FCD RID: 4045
		// (set) Token: 0x06000FCC RID: 4044
		public virtual extern object IHTMLElement_ondblclick { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700085B RID: 2139
		// (get) Token: 0x06000FCF RID: 4047
		// (set) Token: 0x06000FCE RID: 4046
		public virtual extern object IHTMLElement_onkeydown { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700085C RID: 2140
		// (get) Token: 0x06000FD1 RID: 4049
		// (set) Token: 0x06000FD0 RID: 4048
		public virtual extern object IHTMLElement_onkeyup { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700085D RID: 2141
		// (get) Token: 0x06000FD3 RID: 4051
		// (set) Token: 0x06000FD2 RID: 4050
		public virtual extern object IHTMLElement_onkeypress { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700085E RID: 2142
		// (get) Token: 0x06000FD5 RID: 4053
		// (set) Token: 0x06000FD4 RID: 4052
		public virtual extern object IHTMLElement_onmouseout { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700085F RID: 2143
		// (get) Token: 0x06000FD7 RID: 4055
		// (set) Token: 0x06000FD6 RID: 4054
		public virtual extern object IHTMLElement_onmouseover { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000860 RID: 2144
		// (get) Token: 0x06000FD9 RID: 4057
		// (set) Token: 0x06000FD8 RID: 4056
		public virtual extern object IHTMLElement_onmousemove { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000861 RID: 2145
		// (get) Token: 0x06000FDB RID: 4059
		// (set) Token: 0x06000FDA RID: 4058
		public virtual extern object IHTMLElement_onmousedown { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000862 RID: 2146
		// (get) Token: 0x06000FDD RID: 4061
		// (set) Token: 0x06000FDC RID: 4060
		public virtual extern object IHTMLElement_onmouseup { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000863 RID: 2147
		// (get) Token: 0x06000FDE RID: 4062
		public virtual extern object IHTMLElement_document { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] get; }

		// Token: 0x17000864 RID: 2148
		// (get) Token: 0x06000FE0 RID: 4064
		// (set) Token: 0x06000FDF RID: 4063
		public virtual extern string IHTMLElement_title { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000865 RID: 2149
		// (get) Token: 0x06000FE2 RID: 4066
		// (set) Token: 0x06000FE1 RID: 4065
		public virtual extern string IHTMLElement_language { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000866 RID: 2150
		// (get) Token: 0x06000FE4 RID: 4068
		// (set) Token: 0x06000FE3 RID: 4067
		public virtual extern object IHTMLElement_onselectstart { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x06000FE5 RID: 4069
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void IHTMLElement_scrollIntoView([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] object varargStart);

		// Token: 0x06000FE6 RID: 4070
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern bool IHTMLElement_contains([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLElement pChild);

		// Token: 0x17000867 RID: 2151
		// (get) Token: 0x06000FE7 RID: 4071
		public virtual extern int IHTMLElement_sourceIndex { [global::System.Runtime.InteropServices.TypeLibFunc(4)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000868 RID: 2152
		// (get) Token: 0x06000FE8 RID: 4072
		public virtual extern object IHTMLElement_recordNumber { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; }

		// Token: 0x17000869 RID: 2153
		// (get) Token: 0x06000FEA RID: 4074
		// (set) Token: 0x06000FE9 RID: 4073
		public virtual extern string IHTMLElement_lang { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700086A RID: 2154
		// (get) Token: 0x06000FEB RID: 4075
		public virtual extern int IHTMLElement_offsetLeft { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700086B RID: 2155
		// (get) Token: 0x06000FEC RID: 4076
		public virtual extern int IHTMLElement_offsetTop { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700086C RID: 2156
		// (get) Token: 0x06000FED RID: 4077
		public virtual extern int IHTMLElement_offsetWidth { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700086D RID: 2157
		// (get) Token: 0x06000FEE RID: 4078
		public virtual extern int IHTMLElement_offsetHeight { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700086E RID: 2158
		// (get) Token: 0x06000FEF RID: 4079
		public virtual extern global::mshtml.IHTMLElement IHTMLElement_offsetParent { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x1700086F RID: 2159
		// (get) Token: 0x06000FF1 RID: 4081
		// (set) Token: 0x06000FF0 RID: 4080
		public virtual extern string IHTMLElement_innerHTML { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000870 RID: 2160
		// (get) Token: 0x06000FF3 RID: 4083
		// (set) Token: 0x06000FF2 RID: 4082
		public virtual extern string IHTMLElement_innerText { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000871 RID: 2161
		// (get) Token: 0x06000FF5 RID: 4085
		// (set) Token: 0x06000FF4 RID: 4084
		public virtual extern string IHTMLElement_outerHTML { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000872 RID: 2162
		// (get) Token: 0x06000FF7 RID: 4087
		// (set) Token: 0x06000FF6 RID: 4086
		public virtual extern string IHTMLElement_outerText { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x06000FF8 RID: 4088
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void IHTMLElement_insertAdjacentHTML([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string where, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string html);

		// Token: 0x06000FF9 RID: 4089
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void IHTMLElement_insertAdjacentText([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string where, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string text);

		// Token: 0x17000873 RID: 2163
		// (get) Token: 0x06000FFA RID: 4090
		public virtual extern global::mshtml.IHTMLElement IHTMLElement_parentTextEdit { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x17000874 RID: 2164
		// (get) Token: 0x06000FFB RID: 4091
		public virtual extern bool IHTMLElement_isTextEdit { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x06000FFC RID: 4092
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void IHTMLElement_click();

		// Token: 0x17000875 RID: 2165
		// (get) Token: 0x06000FFD RID: 4093
		public virtual extern global::mshtml.IHTMLFiltersCollection IHTMLElement_filters { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x17000876 RID: 2166
		// (get) Token: 0x06000FFF RID: 4095
		// (set) Token: 0x06000FFE RID: 4094
		public virtual extern object IHTMLElement_ondragstart { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x06001000 RID: 4096
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public virtual extern string IHTMLElement_toString();

		// Token: 0x17000877 RID: 2167
		// (get) Token: 0x06001002 RID: 4098
		// (set) Token: 0x06001001 RID: 4097
		public virtual extern object IHTMLElement_onbeforeupdate { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000878 RID: 2168
		// (get) Token: 0x06001004 RID: 4100
		// (set) Token: 0x06001003 RID: 4099
		public virtual extern object IHTMLElement_onafterupdate { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000879 RID: 2169
		// (get) Token: 0x06001006 RID: 4102
		// (set) Token: 0x06001005 RID: 4101
		public virtual extern object IHTMLElement_onerrorupdate { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700087A RID: 2170
		// (get) Token: 0x06001008 RID: 4104
		// (set) Token: 0x06001007 RID: 4103
		public virtual extern object IHTMLElement_onrowexit { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700087B RID: 2171
		// (get) Token: 0x0600100A RID: 4106
		// (set) Token: 0x06001009 RID: 4105
		public virtual extern object IHTMLElement_onrowenter { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700087C RID: 2172
		// (get) Token: 0x0600100C RID: 4108
		// (set) Token: 0x0600100B RID: 4107
		public virtual extern object IHTMLElement_ondatasetchanged { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700087D RID: 2173
		// (get) Token: 0x0600100E RID: 4110
		// (set) Token: 0x0600100D RID: 4109
		public virtual extern object IHTMLElement_ondataavailable { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700087E RID: 2174
		// (get) Token: 0x06001010 RID: 4112
		// (set) Token: 0x0600100F RID: 4111
		public virtual extern object IHTMLElement_ondatasetcomplete { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700087F RID: 2175
		// (get) Token: 0x06001012 RID: 4114
		// (set) Token: 0x06001011 RID: 4113
		public virtual extern object IHTMLElement_onfilterchange { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000880 RID: 2176
		// (get) Token: 0x06001013 RID: 4115
		public virtual extern object IHTMLElement_children { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] get; }

		// Token: 0x17000881 RID: 2177
		// (get) Token: 0x06001014 RID: 4116
		public virtual extern object IHTMLElement_all { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] get; }

		// Token: 0x17000882 RID: 2178
		// (get) Token: 0x06001015 RID: 4117
		public virtual extern string IHTMLElement2_scopeName { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x06001016 RID: 4118
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void IHTMLElement2_setCapture([global::System.Runtime.InteropServices.In] bool containerCapture = true);

		// Token: 0x06001017 RID: 4119
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void IHTMLElement2_releaseCapture();

		// Token: 0x17000883 RID: 2179
		// (get) Token: 0x06001019 RID: 4121
		// (set) Token: 0x06001018 RID: 4120
		public virtual extern object IHTMLElement2_onlosecapture { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x0600101A RID: 4122
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public virtual extern string IHTMLElement2_componentFromPoint([global::System.Runtime.InteropServices.In] int x, [global::System.Runtime.InteropServices.In] int y);

		// Token: 0x0600101B RID: 4123
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void IHTMLElement2_doScroll([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] object component);

		// Token: 0x17000884 RID: 2180
		// (get) Token: 0x0600101D RID: 4125
		// (set) Token: 0x0600101C RID: 4124
		public virtual extern object IHTMLElement2_onscroll { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000885 RID: 2181
		// (get) Token: 0x0600101F RID: 4127
		// (set) Token: 0x0600101E RID: 4126
		public virtual extern object IHTMLElement2_ondrag { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000886 RID: 2182
		// (get) Token: 0x06001021 RID: 4129
		// (set) Token: 0x06001020 RID: 4128
		public virtual extern object IHTMLElement2_ondragend { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000887 RID: 2183
		// (get) Token: 0x06001023 RID: 4131
		// (set) Token: 0x06001022 RID: 4130
		public virtual extern object IHTMLElement2_ondragenter { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000888 RID: 2184
		// (get) Token: 0x06001025 RID: 4133
		// (set) Token: 0x06001024 RID: 4132
		public virtual extern object IHTMLElement2_ondragover { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000889 RID: 2185
		// (get) Token: 0x06001027 RID: 4135
		// (set) Token: 0x06001026 RID: 4134
		public virtual extern object IHTMLElement2_ondragleave { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700088A RID: 2186
		// (get) Token: 0x06001029 RID: 4137
		// (set) Token: 0x06001028 RID: 4136
		public virtual extern object IHTMLElement2_ondrop { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700088B RID: 2187
		// (get) Token: 0x0600102B RID: 4139
		// (set) Token: 0x0600102A RID: 4138
		public virtual extern object IHTMLElement2_onbeforecut { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700088C RID: 2188
		// (get) Token: 0x0600102D RID: 4141
		// (set) Token: 0x0600102C RID: 4140
		public virtual extern object IHTMLElement2_oncut { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700088D RID: 2189
		// (get) Token: 0x0600102F RID: 4143
		// (set) Token: 0x0600102E RID: 4142
		public virtual extern object IHTMLElement2_onbeforecopy { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700088E RID: 2190
		// (get) Token: 0x06001031 RID: 4145
		// (set) Token: 0x06001030 RID: 4144
		public virtual extern object IHTMLElement2_oncopy { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700088F RID: 2191
		// (get) Token: 0x06001033 RID: 4147
		// (set) Token: 0x06001032 RID: 4146
		public virtual extern object IHTMLElement2_onbeforepaste { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000890 RID: 2192
		// (get) Token: 0x06001035 RID: 4149
		// (set) Token: 0x06001034 RID: 4148
		public virtual extern object IHTMLElement2_onpaste { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000891 RID: 2193
		// (get) Token: 0x06001036 RID: 4150
		public virtual extern global::mshtml.IHTMLCurrentStyle IHTMLElement2_currentStyle { [global::System.Runtime.InteropServices.TypeLibFunc(1024)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x17000892 RID: 2194
		// (get) Token: 0x06001038 RID: 4152
		// (set) Token: 0x06001037 RID: 4151
		public virtual extern object IHTMLElement2_onpropertychange { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x06001039 RID: 4153
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		public virtual extern global::mshtml.IHTMLRectCollection IHTMLElement2_getClientRects();

		// Token: 0x0600103A RID: 4154
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		public virtual extern global::mshtml.IHTMLRect IHTMLElement2_getBoundingClientRect();

		// Token: 0x0600103B RID: 4155
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void IHTMLElement2_setExpression([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string propname, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string expression, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string language = "");

		// Token: 0x0600103C RID: 4156
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)]
		public virtual extern object IHTMLElement2_getExpression([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string propname);

		// Token: 0x0600103D RID: 4157
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern bool IHTMLElement2_removeExpression([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string propname);

		// Token: 0x17000893 RID: 2195
		// (get) Token: 0x0600103F RID: 4159
		// (set) Token: 0x0600103E RID: 4158
		public virtual extern short IHTMLElement2_tabIndex { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x06001040 RID: 4160
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void IHTMLElement2_focus();

		// Token: 0x17000894 RID: 2196
		// (get) Token: 0x06001042 RID: 4162
		// (set) Token: 0x06001041 RID: 4161
		public virtual extern string IHTMLElement2_accessKey { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000895 RID: 2197
		// (get) Token: 0x06001044 RID: 4164
		// (set) Token: 0x06001043 RID: 4163
		public virtual extern object IHTMLElement2_onblur { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000896 RID: 2198
		// (get) Token: 0x06001046 RID: 4166
		// (set) Token: 0x06001045 RID: 4165
		public virtual extern object IHTMLElement2_onfocus { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000897 RID: 2199
		// (get) Token: 0x06001048 RID: 4168
		// (set) Token: 0x06001047 RID: 4167
		public virtual extern object IHTMLElement2_onresize { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x06001049 RID: 4169
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void IHTMLElement2_blur();

		// Token: 0x0600104A RID: 4170
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void IHTMLElement2_addFilter([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IUnknown)] [global::System.Runtime.InteropServices.In] object pUnk);

		// Token: 0x0600104B RID: 4171
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void IHTMLElement2_removeFilter([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IUnknown)] [global::System.Runtime.InteropServices.In] object pUnk);

		// Token: 0x17000898 RID: 2200
		// (get) Token: 0x0600104C RID: 4172
		public virtual extern int IHTMLElement2_clientHeight { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000899 RID: 2201
		// (get) Token: 0x0600104D RID: 4173
		public virtual extern int IHTMLElement2_clientWidth { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700089A RID: 2202
		// (get) Token: 0x0600104E RID: 4174
		public virtual extern int IHTMLElement2_clientTop { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700089B RID: 2203
		// (get) Token: 0x0600104F RID: 4175
		public virtual extern int IHTMLElement2_clientLeft { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x06001050 RID: 4176
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern bool IHTMLElement2_attachEvent([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string @event, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] [global::System.Runtime.InteropServices.In] object pdisp);

		// Token: 0x06001051 RID: 4177
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void IHTMLElement2_detachEvent([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string @event, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] [global::System.Runtime.InteropServices.In] object pdisp);

		// Token: 0x1700089C RID: 2204
		// (get) Token: 0x06001052 RID: 4178
		public virtual extern object IHTMLElement2_readyState { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; }

		// Token: 0x1700089D RID: 2205
		// (get) Token: 0x06001054 RID: 4180
		// (set) Token: 0x06001053 RID: 4179
		public virtual extern object IHTMLElement2_onreadystatechange { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700089E RID: 2206
		// (get) Token: 0x06001056 RID: 4182
		// (set) Token: 0x06001055 RID: 4181
		public virtual extern object IHTMLElement2_onrowsdelete { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700089F RID: 2207
		// (get) Token: 0x06001058 RID: 4184
		// (set) Token: 0x06001057 RID: 4183
		public virtual extern object IHTMLElement2_onrowsinserted { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170008A0 RID: 2208
		// (get) Token: 0x0600105A RID: 4186
		// (set) Token: 0x06001059 RID: 4185
		public virtual extern object IHTMLElement2_oncellchange { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170008A1 RID: 2209
		// (get) Token: 0x0600105C RID: 4188
		// (set) Token: 0x0600105B RID: 4187
		public virtual extern string IHTMLElement2_dir { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x0600105D RID: 4189
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)]
		public virtual extern object IHTMLElement2_createControlRange();

		// Token: 0x170008A2 RID: 2210
		// (get) Token: 0x0600105E RID: 4190
		public virtual extern int IHTMLElement2_scrollHeight { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x170008A3 RID: 2211
		// (get) Token: 0x0600105F RID: 4191
		public virtual extern int IHTMLElement2_scrollWidth { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x170008A4 RID: 2212
		// (get) Token: 0x06001061 RID: 4193
		// (set) Token: 0x06001060 RID: 4192
		public virtual extern int IHTMLElement2_scrollTop { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170008A5 RID: 2213
		// (get) Token: 0x06001063 RID: 4195
		// (set) Token: 0x06001062 RID: 4194
		public virtual extern int IHTMLElement2_scrollLeft { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x06001064 RID: 4196
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void IHTMLElement2_clearAttributes();

		// Token: 0x06001065 RID: 4197
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void mergeAttributes([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLElement mergeThis);

		// Token: 0x170008A6 RID: 2214
		// (get) Token: 0x06001067 RID: 4199
		// (set) Token: 0x06001066 RID: 4198
		public virtual extern object IHTMLElement2_oncontextmenu { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x06001068 RID: 4200
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		public virtual extern global::mshtml.IHTMLElement IHTMLElement2_insertAdjacentElement([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string where, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLElement insertedElement);

		// Token: 0x06001069 RID: 4201
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		public virtual extern global::mshtml.IHTMLElement IHTMLElement2_applyElement([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLElement apply, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string where);

		// Token: 0x0600106A RID: 4202
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public virtual extern string IHTMLElement2_getAdjacentText([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string where);

		// Token: 0x0600106B RID: 4203
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public virtual extern string IHTMLElement2_replaceAdjacentText([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string where, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string newText);

		// Token: 0x170008A7 RID: 2215
		// (get) Token: 0x0600106C RID: 4204
		public virtual extern bool IHTMLElement2_canHaveChildren { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x0600106D RID: 4205
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern int IHTMLElement2_addBehavior([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string bstrUrl, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object pvarFactory);

		// Token: 0x0600106E RID: 4206
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern bool IHTMLElement2_removeBehavior([global::System.Runtime.InteropServices.In] int cookie);

		// Token: 0x170008A8 RID: 2216
		// (get) Token: 0x0600106F RID: 4207
		public virtual extern global::mshtml.IHTMLStyle IHTMLElement2_runtimeStyle { [global::System.Runtime.InteropServices.TypeLibFunc(1024)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x170008A9 RID: 2217
		// (get) Token: 0x06001070 RID: 4208
		public virtual extern object IHTMLElement2_behaviorUrns { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] get; }

		// Token: 0x170008AA RID: 2218
		// (get) Token: 0x06001072 RID: 4210
		// (set) Token: 0x06001071 RID: 4209
		public virtual extern string IHTMLElement2_tagUrn { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170008AB RID: 2219
		// (get) Token: 0x06001074 RID: 4212
		// (set) Token: 0x06001073 RID: 4211
		public virtual extern object IHTMLElement2_onbeforeeditfocus { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170008AC RID: 2220
		// (get) Token: 0x06001075 RID: 4213
		public virtual extern int IHTMLElement2_readyStateValue { [global::System.Runtime.InteropServices.TypeLibFunc(65)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x06001076 RID: 4214
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		public virtual extern global::mshtml.IHTMLElementCollection IHTMLElement2_getElementsByTagName([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string v);

		// Token: 0x06001077 RID: 4215
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void mergeAttributes([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLElement mergeThis, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object pvarFlags);

		// Token: 0x170008AD RID: 2221
		// (get) Token: 0x06001078 RID: 4216
		public virtual extern bool IHTMLElement3_isMultiLine { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x170008AE RID: 2222
		// (get) Token: 0x06001079 RID: 4217
		public virtual extern bool IHTMLElement3_canHaveHTML { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x170008AF RID: 2223
		// (get) Token: 0x0600107B RID: 4219
		// (set) Token: 0x0600107A RID: 4218
		public virtual extern object IHTMLElement3_onlayoutcomplete { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170008B0 RID: 2224
		// (get) Token: 0x0600107D RID: 4221
		// (set) Token: 0x0600107C RID: 4220
		public virtual extern object IHTMLElement3_onpage { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170008B1 RID: 2225
		// (get) Token: 0x0600107F RID: 4223
		// (set) Token: 0x0600107E RID: 4222
		public virtual extern bool IHTMLElement3_inflateBlock { [global::System.Runtime.InteropServices.TypeLibFunc(1089)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.TypeLibFunc(1089)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170008B2 RID: 2226
		// (get) Token: 0x06001081 RID: 4225
		// (set) Token: 0x06001080 RID: 4224
		public virtual extern object IHTMLElement3_onbeforedeactivate { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x06001082 RID: 4226
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void IHTMLElement3_setActive();

		// Token: 0x170008B3 RID: 2227
		// (get) Token: 0x06001084 RID: 4228
		// (set) Token: 0x06001083 RID: 4227
		public virtual extern string IHTMLElement3_contentEditable { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170008B4 RID: 2228
		// (get) Token: 0x06001085 RID: 4229
		public virtual extern bool IHTMLElement3_isContentEditable { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x170008B5 RID: 2229
		// (get) Token: 0x06001087 RID: 4231
		// (set) Token: 0x06001086 RID: 4230
		public virtual extern bool IHTMLElement3_hideFocus { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170008B6 RID: 2230
		// (get) Token: 0x06001089 RID: 4233
		// (set) Token: 0x06001088 RID: 4232
		public virtual extern bool IHTMLElement3_disabled { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170008B7 RID: 2231
		// (get) Token: 0x0600108A RID: 4234
		public virtual extern bool IHTMLElement3_isDisabled { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x170008B8 RID: 2232
		// (get) Token: 0x0600108C RID: 4236
		// (set) Token: 0x0600108B RID: 4235
		public virtual extern object IHTMLElement3_onmove { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170008B9 RID: 2233
		// (get) Token: 0x0600108E RID: 4238
		// (set) Token: 0x0600108D RID: 4237
		public virtual extern object IHTMLElement3_oncontrolselect { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x0600108F RID: 4239
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern bool IHTMLElement3_FireEvent([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string bstrEventName, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object pvarEventObject);

		// Token: 0x170008BA RID: 2234
		// (get) Token: 0x06001091 RID: 4241
		// (set) Token: 0x06001090 RID: 4240
		public virtual extern object IHTMLElement3_onresizestart { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170008BB RID: 2235
		// (get) Token: 0x06001093 RID: 4243
		// (set) Token: 0x06001092 RID: 4242
		public virtual extern object IHTMLElement3_onresizeend { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170008BC RID: 2236
		// (get) Token: 0x06001095 RID: 4245
		// (set) Token: 0x06001094 RID: 4244
		public virtual extern object IHTMLElement3_onmovestart { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170008BD RID: 2237
		// (get) Token: 0x06001097 RID: 4247
		// (set) Token: 0x06001096 RID: 4246
		public virtual extern object IHTMLElement3_onmoveend { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170008BE RID: 2238
		// (get) Token: 0x06001099 RID: 4249
		// (set) Token: 0x06001098 RID: 4248
		public virtual extern object IHTMLElement3_onmouseenter { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170008BF RID: 2239
		// (get) Token: 0x0600109B RID: 4251
		// (set) Token: 0x0600109A RID: 4250
		public virtual extern object IHTMLElement3_onmouseleave { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170008C0 RID: 2240
		// (get) Token: 0x0600109D RID: 4253
		// (set) Token: 0x0600109C RID: 4252
		public virtual extern object IHTMLElement3_onactivate { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170008C1 RID: 2241
		// (get) Token: 0x0600109F RID: 4255
		// (set) Token: 0x0600109E RID: 4254
		public virtual extern object IHTMLElement3_ondeactivate { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x060010A0 RID: 4256
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern bool IHTMLElement3_dragDrop();

		// Token: 0x170008C2 RID: 2242
		// (get) Token: 0x060010A1 RID: 4257
		public virtual extern int IHTMLElement3_glyphMode { [global::System.Runtime.InteropServices.TypeLibFunc(1089)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x170008C3 RID: 2243
		// (get) Token: 0x060010A3 RID: 4259
		// (set) Token: 0x060010A2 RID: 4258
		public virtual extern object IHTMLElement4_onmousewheel { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x060010A4 RID: 4260
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void IHTMLElement4_normalize();

		// Token: 0x060010A5 RID: 4261
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		public virtual extern global::mshtml.IHTMLDOMAttribute IHTMLElement4_getAttributeNode([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string bstrName);

		// Token: 0x060010A6 RID: 4262
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		public virtual extern global::mshtml.IHTMLDOMAttribute IHTMLElement4_setAttributeNode([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLDOMAttribute pattr);

		// Token: 0x060010A7 RID: 4263
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		public virtual extern global::mshtml.IHTMLDOMAttribute IHTMLElement4_removeAttributeNode([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLDOMAttribute pattr);

		// Token: 0x170008C4 RID: 2244
		// (get) Token: 0x060010A9 RID: 4265
		// (set) Token: 0x060010A8 RID: 4264
		public virtual extern object IHTMLElement4_onbeforeactivate { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170008C5 RID: 2245
		// (get) Token: 0x060010AB RID: 4267
		// (set) Token: 0x060010AA RID: 4266
		public virtual extern object IHTMLElement4_onfocusin { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170008C6 RID: 2246
		// (get) Token: 0x060010AD RID: 4269
		// (set) Token: 0x060010AC RID: 4268
		public virtual extern object IHTMLElement4_onfocusout { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170008C7 RID: 2247
		// (get) Token: 0x060010AE RID: 4270
		public virtual extern int IHTMLUniqueName_uniqueNumber { [global::System.Runtime.InteropServices.TypeLibFunc(64)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x170008C8 RID: 2248
		// (get) Token: 0x060010AF RID: 4271
		public virtual extern string IHTMLUniqueName_uniqueID { [global::System.Runtime.InteropServices.TypeLibFunc(64)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x170008C9 RID: 2249
		// (get) Token: 0x060010B0 RID: 4272
		public virtual extern int IHTMLDOMNode_nodeType { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x170008CA RID: 2250
		// (get) Token: 0x060010B1 RID: 4273
		public virtual extern global::mshtml.IHTMLDOMNode IHTMLDOMNode_parentNode { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x060010B2 RID: 4274
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern bool IHTMLDOMNode_hasChildNodes();

		// Token: 0x170008CB RID: 2251
		// (get) Token: 0x060010B3 RID: 4275
		public virtual extern object IHTMLDOMNode_childNodes { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] get; }

		// Token: 0x170008CC RID: 2252
		// (get) Token: 0x060010B4 RID: 4276
		public virtual extern object IHTMLDOMNode_attributes { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] get; }

		// Token: 0x060010B5 RID: 4277
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		public virtual extern global::mshtml.IHTMLDOMNode IHTMLDOMNode_insertBefore([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLDOMNode newChild, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] object refChild);

		// Token: 0x060010B6 RID: 4278
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		public virtual extern global::mshtml.IHTMLDOMNode IHTMLDOMNode_removeChild([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLDOMNode oldChild);

		// Token: 0x060010B7 RID: 4279
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		public virtual extern global::mshtml.IHTMLDOMNode IHTMLDOMNode_replaceChild([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLDOMNode newChild, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLDOMNode oldChild);

		// Token: 0x060010B8 RID: 4280
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		public virtual extern global::mshtml.IHTMLDOMNode IHTMLDOMNode_cloneNode([global::System.Runtime.InteropServices.In] bool fDeep);

		// Token: 0x060010B9 RID: 4281
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		public virtual extern global::mshtml.IHTMLDOMNode IHTMLDOMNode_removeNode([global::System.Runtime.InteropServices.In] bool fDeep = false);

		// Token: 0x060010BA RID: 4282
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		public virtual extern global::mshtml.IHTMLDOMNode IHTMLDOMNode_swapNode([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLDOMNode otherNode);

		// Token: 0x060010BB RID: 4283
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		public virtual extern global::mshtml.IHTMLDOMNode IHTMLDOMNode_replaceNode([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLDOMNode replacement);

		// Token: 0x060010BC RID: 4284
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		public virtual extern global::mshtml.IHTMLDOMNode IHTMLDOMNode_appendChild([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLDOMNode newChild);

		// Token: 0x170008CD RID: 2253
		// (get) Token: 0x060010BD RID: 4285
		public virtual extern string IHTMLDOMNode_nodeName { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x170008CE RID: 2254
		// (get) Token: 0x060010BF RID: 4287
		// (set) Token: 0x060010BE RID: 4286
		public virtual extern object IHTMLDOMNode_nodeValue { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170008CF RID: 2255
		// (get) Token: 0x060010C0 RID: 4288
		public virtual extern global::mshtml.IHTMLDOMNode IHTMLDOMNode_firstChild { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x170008D0 RID: 2256
		// (get) Token: 0x060010C1 RID: 4289
		public virtual extern global::mshtml.IHTMLDOMNode IHTMLDOMNode_lastChild { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x170008D1 RID: 2257
		// (get) Token: 0x060010C2 RID: 4290
		public virtual extern global::mshtml.IHTMLDOMNode IHTMLDOMNode_previousSibling { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x170008D2 RID: 2258
		// (get) Token: 0x060010C3 RID: 4291
		public virtual extern global::mshtml.IHTMLDOMNode IHTMLDOMNode_nextSibling { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x170008D3 RID: 2259
		// (get) Token: 0x060010C4 RID: 4292
		public virtual extern object IHTMLDOMNode2_ownerDocument { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] get; }

		// Token: 0x170008D4 RID: 2260
		// (get) Token: 0x060010C5 RID: 4293
		public virtual extern object IHTMLGenericElement_recordset { [global::System.Runtime.InteropServices.TypeLibFunc(64)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] get; }

		// Token: 0x060010C6 RID: 4294
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)]
		public virtual extern object IHTMLGenericElement_namedRecordset([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string dataMember, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object hierarchy);

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x060010C7 RID: 4295
		// (remove) Token: 0x060010C8 RID: 4296
		public virtual extern event global::mshtml.HTMLElementEvents_onhelpEventHandler HTMLElementEvents_Event_onhelp;

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x060010C9 RID: 4297
		// (remove) Token: 0x060010CA RID: 4298
		public virtual extern event global::mshtml.HTMLElementEvents_onclickEventHandler HTMLElementEvents_Event_onclick;

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x060010CB RID: 4299
		// (remove) Token: 0x060010CC RID: 4300
		public virtual extern event global::mshtml.HTMLElementEvents_ondblclickEventHandler HTMLElementEvents_Event_ondblclick;

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x060010CD RID: 4301
		// (remove) Token: 0x060010CE RID: 4302
		public virtual extern event global::mshtml.HTMLElementEvents_onkeypressEventHandler HTMLElementEvents_Event_onkeypress;

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x060010CF RID: 4303
		// (remove) Token: 0x060010D0 RID: 4304
		public virtual extern event global::mshtml.HTMLElementEvents_onkeydownEventHandler HTMLElementEvents_Event_onkeydown;

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x060010D1 RID: 4305
		// (remove) Token: 0x060010D2 RID: 4306
		public virtual extern event global::mshtml.HTMLElementEvents_onkeyupEventHandler HTMLElementEvents_Event_onkeyup;

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x060010D3 RID: 4307
		// (remove) Token: 0x060010D4 RID: 4308
		public virtual extern event global::mshtml.HTMLElementEvents_onmouseoutEventHandler HTMLElementEvents_Event_onmouseout;

		// Token: 0x14000008 RID: 8
		// (add) Token: 0x060010D5 RID: 4309
		// (remove) Token: 0x060010D6 RID: 4310
		public virtual extern event global::mshtml.HTMLElementEvents_onmouseoverEventHandler HTMLElementEvents_Event_onmouseover;

		// Token: 0x14000009 RID: 9
		// (add) Token: 0x060010D7 RID: 4311
		// (remove) Token: 0x060010D8 RID: 4312
		public virtual extern event global::mshtml.HTMLElementEvents_onmousemoveEventHandler HTMLElementEvents_Event_onmousemove;

		// Token: 0x1400000A RID: 10
		// (add) Token: 0x060010D9 RID: 4313
		// (remove) Token: 0x060010DA RID: 4314
		public virtual extern event global::mshtml.HTMLElementEvents_onmousedownEventHandler HTMLElementEvents_Event_onmousedown;

		// Token: 0x1400000B RID: 11
		// (add) Token: 0x060010DB RID: 4315
		// (remove) Token: 0x060010DC RID: 4316
		public virtual extern event global::mshtml.HTMLElementEvents_onmouseupEventHandler HTMLElementEvents_Event_onmouseup;

		// Token: 0x1400000C RID: 12
		// (add) Token: 0x060010DD RID: 4317
		// (remove) Token: 0x060010DE RID: 4318
		public virtual extern event global::mshtml.HTMLElementEvents_onselectstartEventHandler HTMLElementEvents_Event_onselectstart;

		// Token: 0x1400000D RID: 13
		// (add) Token: 0x060010DF RID: 4319
		// (remove) Token: 0x060010E0 RID: 4320
		public virtual extern event global::mshtml.HTMLElementEvents_onfilterchangeEventHandler HTMLElementEvents_Event_onfilterchange;

		// Token: 0x1400000E RID: 14
		// (add) Token: 0x060010E1 RID: 4321
		// (remove) Token: 0x060010E2 RID: 4322
		public virtual extern event global::mshtml.HTMLElementEvents_ondragstartEventHandler HTMLElementEvents_Event_ondragstart;

		// Token: 0x1400000F RID: 15
		// (add) Token: 0x060010E3 RID: 4323
		// (remove) Token: 0x060010E4 RID: 4324
		public virtual extern event global::mshtml.HTMLElementEvents_onbeforeupdateEventHandler HTMLElementEvents_Event_onbeforeupdate;

		// Token: 0x14000010 RID: 16
		// (add) Token: 0x060010E5 RID: 4325
		// (remove) Token: 0x060010E6 RID: 4326
		public virtual extern event global::mshtml.HTMLElementEvents_onafterupdateEventHandler HTMLElementEvents_Event_onafterupdate;

		// Token: 0x14000011 RID: 17
		// (add) Token: 0x060010E7 RID: 4327
		// (remove) Token: 0x060010E8 RID: 4328
		public virtual extern event global::mshtml.HTMLElementEvents_onerrorupdateEventHandler HTMLElementEvents_Event_onerrorupdate;

		// Token: 0x14000012 RID: 18
		// (add) Token: 0x060010E9 RID: 4329
		// (remove) Token: 0x060010EA RID: 4330
		public virtual extern event global::mshtml.HTMLElementEvents_onrowexitEventHandler HTMLElementEvents_Event_onrowexit;

		// Token: 0x14000013 RID: 19
		// (add) Token: 0x060010EB RID: 4331
		// (remove) Token: 0x060010EC RID: 4332
		public virtual extern event global::mshtml.HTMLElementEvents_onrowenterEventHandler HTMLElementEvents_Event_onrowenter;

		// Token: 0x14000014 RID: 20
		// (add) Token: 0x060010ED RID: 4333
		// (remove) Token: 0x060010EE RID: 4334
		public virtual extern event global::mshtml.HTMLElementEvents_ondatasetchangedEventHandler HTMLElementEvents_Event_ondatasetchanged;

		// Token: 0x14000015 RID: 21
		// (add) Token: 0x060010EF RID: 4335
		// (remove) Token: 0x060010F0 RID: 4336
		public virtual extern event global::mshtml.HTMLElementEvents_ondataavailableEventHandler HTMLElementEvents_Event_ondataavailable;

		// Token: 0x14000016 RID: 22
		// (add) Token: 0x060010F1 RID: 4337
		// (remove) Token: 0x060010F2 RID: 4338
		public virtual extern event global::mshtml.HTMLElementEvents_ondatasetcompleteEventHandler HTMLElementEvents_Event_ondatasetcomplete;

		// Token: 0x14000017 RID: 23
		// (add) Token: 0x060010F3 RID: 4339
		// (remove) Token: 0x060010F4 RID: 4340
		public virtual extern event global::mshtml.HTMLElementEvents_onlosecaptureEventHandler HTMLElementEvents_Event_onlosecapture;

		// Token: 0x14000018 RID: 24
		// (add) Token: 0x060010F5 RID: 4341
		// (remove) Token: 0x060010F6 RID: 4342
		public virtual extern event global::mshtml.HTMLElementEvents_onpropertychangeEventHandler HTMLElementEvents_Event_onpropertychange;

		// Token: 0x14000019 RID: 25
		// (add) Token: 0x060010F7 RID: 4343
		// (remove) Token: 0x060010F8 RID: 4344
		public virtual extern event global::mshtml.HTMLElementEvents_onscrollEventHandler HTMLElementEvents_Event_onscroll;

		// Token: 0x1400001A RID: 26
		// (add) Token: 0x060010F9 RID: 4345
		// (remove) Token: 0x060010FA RID: 4346
		public virtual extern event global::mshtml.HTMLElementEvents_onfocusEventHandler HTMLElementEvents_Event_onfocus;

		// Token: 0x1400001B RID: 27
		// (add) Token: 0x060010FB RID: 4347
		// (remove) Token: 0x060010FC RID: 4348
		public virtual extern event global::mshtml.HTMLElementEvents_onblurEventHandler HTMLElementEvents_Event_onblur;

		// Token: 0x1400001C RID: 28
		// (add) Token: 0x060010FD RID: 4349
		// (remove) Token: 0x060010FE RID: 4350
		public virtual extern event global::mshtml.HTMLElementEvents_onresizeEventHandler HTMLElementEvents_Event_onresize;

		// Token: 0x1400001D RID: 29
		// (add) Token: 0x060010FF RID: 4351
		// (remove) Token: 0x06001100 RID: 4352
		public virtual extern event global::mshtml.HTMLElementEvents_ondragEventHandler HTMLElementEvents_Event_ondrag;

		// Token: 0x1400001E RID: 30
		// (add) Token: 0x06001101 RID: 4353
		// (remove) Token: 0x06001102 RID: 4354
		public virtual extern event global::mshtml.HTMLElementEvents_ondragendEventHandler HTMLElementEvents_Event_ondragend;

		// Token: 0x1400001F RID: 31
		// (add) Token: 0x06001103 RID: 4355
		// (remove) Token: 0x06001104 RID: 4356
		public virtual extern event global::mshtml.HTMLElementEvents_ondragenterEventHandler HTMLElementEvents_Event_ondragenter;

		// Token: 0x14000020 RID: 32
		// (add) Token: 0x06001105 RID: 4357
		// (remove) Token: 0x06001106 RID: 4358
		public virtual extern event global::mshtml.HTMLElementEvents_ondragoverEventHandler HTMLElementEvents_Event_ondragover;

		// Token: 0x14000021 RID: 33
		// (add) Token: 0x06001107 RID: 4359
		// (remove) Token: 0x06001108 RID: 4360
		public virtual extern event global::mshtml.HTMLElementEvents_ondragleaveEventHandler HTMLElementEvents_Event_ondragleave;

		// Token: 0x14000022 RID: 34
		// (add) Token: 0x06001109 RID: 4361
		// (remove) Token: 0x0600110A RID: 4362
		public virtual extern event global::mshtml.HTMLElementEvents_ondropEventHandler HTMLElementEvents_Event_ondrop;

		// Token: 0x14000023 RID: 35
		// (add) Token: 0x0600110B RID: 4363
		// (remove) Token: 0x0600110C RID: 4364
		public virtual extern event global::mshtml.HTMLElementEvents_onbeforecutEventHandler HTMLElementEvents_Event_onbeforecut;

		// Token: 0x14000024 RID: 36
		// (add) Token: 0x0600110D RID: 4365
		// (remove) Token: 0x0600110E RID: 4366
		public virtual extern event global::mshtml.HTMLElementEvents_oncutEventHandler HTMLElementEvents_Event_oncut;

		// Token: 0x14000025 RID: 37
		// (add) Token: 0x0600110F RID: 4367
		// (remove) Token: 0x06001110 RID: 4368
		public virtual extern event global::mshtml.HTMLElementEvents_onbeforecopyEventHandler HTMLElementEvents_Event_onbeforecopy;

		// Token: 0x14000026 RID: 38
		// (add) Token: 0x06001111 RID: 4369
		// (remove) Token: 0x06001112 RID: 4370
		public virtual extern event global::mshtml.HTMLElementEvents_oncopyEventHandler HTMLElementEvents_Event_oncopy;

		// Token: 0x14000027 RID: 39
		// (add) Token: 0x06001113 RID: 4371
		// (remove) Token: 0x06001114 RID: 4372
		public virtual extern event global::mshtml.HTMLElementEvents_onbeforepasteEventHandler HTMLElementEvents_Event_onbeforepaste;

		// Token: 0x14000028 RID: 40
		// (add) Token: 0x06001115 RID: 4373
		// (remove) Token: 0x06001116 RID: 4374
		public virtual extern event global::mshtml.HTMLElementEvents_onpasteEventHandler HTMLElementEvents_Event_onpaste;

		// Token: 0x14000029 RID: 41
		// (add) Token: 0x06001117 RID: 4375
		// (remove) Token: 0x06001118 RID: 4376
		public virtual extern event global::mshtml.HTMLElementEvents_oncontextmenuEventHandler HTMLElementEvents_Event_oncontextmenu;

		// Token: 0x1400002A RID: 42
		// (add) Token: 0x06001119 RID: 4377
		// (remove) Token: 0x0600111A RID: 4378
		public virtual extern event global::mshtml.HTMLElementEvents_onrowsdeleteEventHandler HTMLElementEvents_Event_onrowsdelete;

		// Token: 0x1400002B RID: 43
		// (add) Token: 0x0600111B RID: 4379
		// (remove) Token: 0x0600111C RID: 4380
		public virtual extern event global::mshtml.HTMLElementEvents_onrowsinsertedEventHandler HTMLElementEvents_Event_onrowsinserted;

		// Token: 0x1400002C RID: 44
		// (add) Token: 0x0600111D RID: 4381
		// (remove) Token: 0x0600111E RID: 4382
		public virtual extern event global::mshtml.HTMLElementEvents_oncellchangeEventHandler HTMLElementEvents_Event_oncellchange;

		// Token: 0x1400002D RID: 45
		// (add) Token: 0x0600111F RID: 4383
		// (remove) Token: 0x06001120 RID: 4384
		public virtual extern event global::mshtml.HTMLElementEvents_onreadystatechangeEventHandler HTMLElementEvents_Event_onreadystatechange;

		// Token: 0x1400002E RID: 46
		// (add) Token: 0x06001121 RID: 4385
		// (remove) Token: 0x06001122 RID: 4386
		public virtual extern event global::mshtml.HTMLElementEvents_onbeforeeditfocusEventHandler HTMLElementEvents_Event_onbeforeeditfocus;

		// Token: 0x1400002F RID: 47
		// (add) Token: 0x06001123 RID: 4387
		// (remove) Token: 0x06001124 RID: 4388
		public virtual extern event global::mshtml.HTMLElementEvents_onlayoutcompleteEventHandler HTMLElementEvents_Event_onlayoutcomplete;

		// Token: 0x14000030 RID: 48
		// (add) Token: 0x06001125 RID: 4389
		// (remove) Token: 0x06001126 RID: 4390
		public virtual extern event global::mshtml.HTMLElementEvents_onpageEventHandler HTMLElementEvents_Event_onpage;

		// Token: 0x14000031 RID: 49
		// (add) Token: 0x06001127 RID: 4391
		// (remove) Token: 0x06001128 RID: 4392
		public virtual extern event global::mshtml.HTMLElementEvents_onbeforedeactivateEventHandler HTMLElementEvents_Event_onbeforedeactivate;

		// Token: 0x14000032 RID: 50
		// (add) Token: 0x06001129 RID: 4393
		// (remove) Token: 0x0600112A RID: 4394
		public virtual extern event global::mshtml.HTMLElementEvents_onbeforeactivateEventHandler HTMLElementEvents_Event_onbeforeactivate;

		// Token: 0x14000033 RID: 51
		// (add) Token: 0x0600112B RID: 4395
		// (remove) Token: 0x0600112C RID: 4396
		public virtual extern event global::mshtml.HTMLElementEvents_onmoveEventHandler HTMLElementEvents_Event_onmove;

		// Token: 0x14000034 RID: 52
		// (add) Token: 0x0600112D RID: 4397
		// (remove) Token: 0x0600112E RID: 4398
		public virtual extern event global::mshtml.HTMLElementEvents_oncontrolselectEventHandler HTMLElementEvents_Event_oncontrolselect;

		// Token: 0x14000035 RID: 53
		// (add) Token: 0x0600112F RID: 4399
		// (remove) Token: 0x06001130 RID: 4400
		public virtual extern event global::mshtml.HTMLElementEvents_onmovestartEventHandler HTMLElementEvents_Event_onmovestart;

		// Token: 0x14000036 RID: 54
		// (add) Token: 0x06001131 RID: 4401
		// (remove) Token: 0x06001132 RID: 4402
		public virtual extern event global::mshtml.HTMLElementEvents_onmoveendEventHandler HTMLElementEvents_Event_onmoveend;

		// Token: 0x14000037 RID: 55
		// (add) Token: 0x06001133 RID: 4403
		// (remove) Token: 0x06001134 RID: 4404
		public virtual extern event global::mshtml.HTMLElementEvents_onresizestartEventHandler HTMLElementEvents_Event_onresizestart;

		// Token: 0x14000038 RID: 56
		// (add) Token: 0x06001135 RID: 4405
		// (remove) Token: 0x06001136 RID: 4406
		public virtual extern event global::mshtml.HTMLElementEvents_onresizeendEventHandler HTMLElementEvents_Event_onresizeend;

		// Token: 0x14000039 RID: 57
		// (add) Token: 0x06001137 RID: 4407
		// (remove) Token: 0x06001138 RID: 4408
		public virtual extern event global::mshtml.HTMLElementEvents_onmouseenterEventHandler HTMLElementEvents_Event_onmouseenter;

		// Token: 0x1400003A RID: 58
		// (add) Token: 0x06001139 RID: 4409
		// (remove) Token: 0x0600113A RID: 4410
		public virtual extern event global::mshtml.HTMLElementEvents_onmouseleaveEventHandler HTMLElementEvents_Event_onmouseleave;

		// Token: 0x1400003B RID: 59
		// (add) Token: 0x0600113B RID: 4411
		// (remove) Token: 0x0600113C RID: 4412
		public virtual extern event global::mshtml.HTMLElementEvents_onmousewheelEventHandler HTMLElementEvents_Event_onmousewheel;

		// Token: 0x1400003C RID: 60
		// (add) Token: 0x0600113D RID: 4413
		// (remove) Token: 0x0600113E RID: 4414
		public virtual extern event global::mshtml.HTMLElementEvents_onactivateEventHandler HTMLElementEvents_Event_onactivate;

		// Token: 0x1400003D RID: 61
		// (add) Token: 0x0600113F RID: 4415
		// (remove) Token: 0x06001140 RID: 4416
		public virtual extern event global::mshtml.HTMLElementEvents_ondeactivateEventHandler HTMLElementEvents_Event_ondeactivate;

		// Token: 0x1400003E RID: 62
		// (add) Token: 0x06001141 RID: 4417
		// (remove) Token: 0x06001142 RID: 4418
		public virtual extern event global::mshtml.HTMLElementEvents_onfocusinEventHandler HTMLElementEvents_Event_onfocusin;

		// Token: 0x1400003F RID: 63
		// (add) Token: 0x06001143 RID: 4419
		// (remove) Token: 0x06001144 RID: 4420
		public virtual extern event global::mshtml.HTMLElementEvents_onfocusoutEventHandler HTMLElementEvents_Event_onfocusout;

		// Token: 0x14000040 RID: 64
		// (add) Token: 0x06001145 RID: 4421
		// (remove) Token: 0x06001146 RID: 4422
		public virtual extern event global::mshtml.HTMLElementEvents2_onhelpEventHandler HTMLElementEvents2_Event_onhelp;

		// Token: 0x14000041 RID: 65
		// (add) Token: 0x06001147 RID: 4423
		// (remove) Token: 0x06001148 RID: 4424
		public virtual extern event global::mshtml.HTMLElementEvents2_onclickEventHandler HTMLElementEvents2_Event_onclick;

		// Token: 0x14000042 RID: 66
		// (add) Token: 0x06001149 RID: 4425
		// (remove) Token: 0x0600114A RID: 4426
		public virtual extern event global::mshtml.HTMLElementEvents2_ondblclickEventHandler HTMLElementEvents2_Event_ondblclick;

		// Token: 0x14000043 RID: 67
		// (add) Token: 0x0600114B RID: 4427
		// (remove) Token: 0x0600114C RID: 4428
		public virtual extern event global::mshtml.HTMLElementEvents2_onkeypressEventHandler HTMLElementEvents2_Event_onkeypress;

		// Token: 0x14000044 RID: 68
		// (add) Token: 0x0600114D RID: 4429
		// (remove) Token: 0x0600114E RID: 4430
		public virtual extern event global::mshtml.HTMLElementEvents2_onkeydownEventHandler HTMLElementEvents2_Event_onkeydown;

		// Token: 0x14000045 RID: 69
		// (add) Token: 0x0600114F RID: 4431
		// (remove) Token: 0x06001150 RID: 4432
		public virtual extern event global::mshtml.HTMLElementEvents2_onkeyupEventHandler HTMLElementEvents2_Event_onkeyup;

		// Token: 0x14000046 RID: 70
		// (add) Token: 0x06001151 RID: 4433
		// (remove) Token: 0x06001152 RID: 4434
		public virtual extern event global::mshtml.HTMLElementEvents2_onmouseoutEventHandler HTMLElementEvents2_Event_onmouseout;

		// Token: 0x14000047 RID: 71
		// (add) Token: 0x06001153 RID: 4435
		// (remove) Token: 0x06001154 RID: 4436
		public virtual extern event global::mshtml.HTMLElementEvents2_onmouseoverEventHandler HTMLElementEvents2_Event_onmouseover;

		// Token: 0x14000048 RID: 72
		// (add) Token: 0x06001155 RID: 4437
		// (remove) Token: 0x06001156 RID: 4438
		public virtual extern event global::mshtml.HTMLElementEvents2_onmousemoveEventHandler HTMLElementEvents2_Event_onmousemove;

		// Token: 0x14000049 RID: 73
		// (add) Token: 0x06001157 RID: 4439
		// (remove) Token: 0x06001158 RID: 4440
		public virtual extern event global::mshtml.HTMLElementEvents2_onmousedownEventHandler HTMLElementEvents2_Event_onmousedown;

		// Token: 0x1400004A RID: 74
		// (add) Token: 0x06001159 RID: 4441
		// (remove) Token: 0x0600115A RID: 4442
		public virtual extern event global::mshtml.HTMLElementEvents2_onmouseupEventHandler HTMLElementEvents2_Event_onmouseup;

		// Token: 0x1400004B RID: 75
		// (add) Token: 0x0600115B RID: 4443
		// (remove) Token: 0x0600115C RID: 4444
		public virtual extern event global::mshtml.HTMLElementEvents2_onselectstartEventHandler HTMLElementEvents2_Event_onselectstart;

		// Token: 0x1400004C RID: 76
		// (add) Token: 0x0600115D RID: 4445
		// (remove) Token: 0x0600115E RID: 4446
		public virtual extern event global::mshtml.HTMLElementEvents2_onfilterchangeEventHandler HTMLElementEvents2_Event_onfilterchange;

		// Token: 0x1400004D RID: 77
		// (add) Token: 0x0600115F RID: 4447
		// (remove) Token: 0x06001160 RID: 4448
		public virtual extern event global::mshtml.HTMLElementEvents2_ondragstartEventHandler HTMLElementEvents2_Event_ondragstart;

		// Token: 0x1400004E RID: 78
		// (add) Token: 0x06001161 RID: 4449
		// (remove) Token: 0x06001162 RID: 4450
		public virtual extern event global::mshtml.HTMLElementEvents2_onbeforeupdateEventHandler HTMLElementEvents2_Event_onbeforeupdate;

		// Token: 0x1400004F RID: 79
		// (add) Token: 0x06001163 RID: 4451
		// (remove) Token: 0x06001164 RID: 4452
		public virtual extern event global::mshtml.HTMLElementEvents2_onafterupdateEventHandler HTMLElementEvents2_Event_onafterupdate;

		// Token: 0x14000050 RID: 80
		// (add) Token: 0x06001165 RID: 4453
		// (remove) Token: 0x06001166 RID: 4454
		public virtual extern event global::mshtml.HTMLElementEvents2_onerrorupdateEventHandler HTMLElementEvents2_Event_onerrorupdate;

		// Token: 0x14000051 RID: 81
		// (add) Token: 0x06001167 RID: 4455
		// (remove) Token: 0x06001168 RID: 4456
		public virtual extern event global::mshtml.HTMLElementEvents2_onrowexitEventHandler HTMLElementEvents2_Event_onrowexit;

		// Token: 0x14000052 RID: 82
		// (add) Token: 0x06001169 RID: 4457
		// (remove) Token: 0x0600116A RID: 4458
		public virtual extern event global::mshtml.HTMLElementEvents2_onrowenterEventHandler HTMLElementEvents2_Event_onrowenter;

		// Token: 0x14000053 RID: 83
		// (add) Token: 0x0600116B RID: 4459
		// (remove) Token: 0x0600116C RID: 4460
		public virtual extern event global::mshtml.HTMLElementEvents2_ondatasetchangedEventHandler HTMLElementEvents2_Event_ondatasetchanged;

		// Token: 0x14000054 RID: 84
		// (add) Token: 0x0600116D RID: 4461
		// (remove) Token: 0x0600116E RID: 4462
		public virtual extern event global::mshtml.HTMLElementEvents2_ondataavailableEventHandler HTMLElementEvents2_Event_ondataavailable;

		// Token: 0x14000055 RID: 85
		// (add) Token: 0x0600116F RID: 4463
		// (remove) Token: 0x06001170 RID: 4464
		public virtual extern event global::mshtml.HTMLElementEvents2_ondatasetcompleteEventHandler HTMLElementEvents2_Event_ondatasetcomplete;

		// Token: 0x14000056 RID: 86
		// (add) Token: 0x06001171 RID: 4465
		// (remove) Token: 0x06001172 RID: 4466
		public virtual extern event global::mshtml.HTMLElementEvents2_onlosecaptureEventHandler HTMLElementEvents2_Event_onlosecapture;

		// Token: 0x14000057 RID: 87
		// (add) Token: 0x06001173 RID: 4467
		// (remove) Token: 0x06001174 RID: 4468
		public virtual extern event global::mshtml.HTMLElementEvents2_onpropertychangeEventHandler HTMLElementEvents2_Event_onpropertychange;

		// Token: 0x14000058 RID: 88
		// (add) Token: 0x06001175 RID: 4469
		// (remove) Token: 0x06001176 RID: 4470
		public virtual extern event global::mshtml.HTMLElementEvents2_onscrollEventHandler HTMLElementEvents2_Event_onscroll;

		// Token: 0x14000059 RID: 89
		// (add) Token: 0x06001177 RID: 4471
		// (remove) Token: 0x06001178 RID: 4472
		public virtual extern event global::mshtml.HTMLElementEvents2_onfocusEventHandler HTMLElementEvents2_Event_onfocus;

		// Token: 0x1400005A RID: 90
		// (add) Token: 0x06001179 RID: 4473
		// (remove) Token: 0x0600117A RID: 4474
		public virtual extern event global::mshtml.HTMLElementEvents2_onblurEventHandler HTMLElementEvents2_Event_onblur;

		// Token: 0x1400005B RID: 91
		// (add) Token: 0x0600117B RID: 4475
		// (remove) Token: 0x0600117C RID: 4476
		public virtual extern event global::mshtml.HTMLElementEvents2_onresizeEventHandler HTMLElementEvents2_Event_onresize;

		// Token: 0x1400005C RID: 92
		// (add) Token: 0x0600117D RID: 4477
		// (remove) Token: 0x0600117E RID: 4478
		public virtual extern event global::mshtml.HTMLElementEvents2_ondragEventHandler HTMLElementEvents2_Event_ondrag;

		// Token: 0x1400005D RID: 93
		// (add) Token: 0x0600117F RID: 4479
		// (remove) Token: 0x06001180 RID: 4480
		public virtual extern event global::mshtml.HTMLElementEvents2_ondragendEventHandler HTMLElementEvents2_Event_ondragend;

		// Token: 0x1400005E RID: 94
		// (add) Token: 0x06001181 RID: 4481
		// (remove) Token: 0x06001182 RID: 4482
		public virtual extern event global::mshtml.HTMLElementEvents2_ondragenterEventHandler HTMLElementEvents2_Event_ondragenter;

		// Token: 0x1400005F RID: 95
		// (add) Token: 0x06001183 RID: 4483
		// (remove) Token: 0x06001184 RID: 4484
		public virtual extern event global::mshtml.HTMLElementEvents2_ondragoverEventHandler HTMLElementEvents2_Event_ondragover;

		// Token: 0x14000060 RID: 96
		// (add) Token: 0x06001185 RID: 4485
		// (remove) Token: 0x06001186 RID: 4486
		public virtual extern event global::mshtml.HTMLElementEvents2_ondragleaveEventHandler HTMLElementEvents2_Event_ondragleave;

		// Token: 0x14000061 RID: 97
		// (add) Token: 0x06001187 RID: 4487
		// (remove) Token: 0x06001188 RID: 4488
		public virtual extern event global::mshtml.HTMLElementEvents2_ondropEventHandler HTMLElementEvents2_Event_ondrop;

		// Token: 0x14000062 RID: 98
		// (add) Token: 0x06001189 RID: 4489
		// (remove) Token: 0x0600118A RID: 4490
		public virtual extern event global::mshtml.HTMLElementEvents2_onbeforecutEventHandler HTMLElementEvents2_Event_onbeforecut;

		// Token: 0x14000063 RID: 99
		// (add) Token: 0x0600118B RID: 4491
		// (remove) Token: 0x0600118C RID: 4492
		public virtual extern event global::mshtml.HTMLElementEvents2_oncutEventHandler HTMLElementEvents2_Event_oncut;

		// Token: 0x14000064 RID: 100
		// (add) Token: 0x0600118D RID: 4493
		// (remove) Token: 0x0600118E RID: 4494
		public virtual extern event global::mshtml.HTMLElementEvents2_onbeforecopyEventHandler HTMLElementEvents2_Event_onbeforecopy;

		// Token: 0x14000065 RID: 101
		// (add) Token: 0x0600118F RID: 4495
		// (remove) Token: 0x06001190 RID: 4496
		public virtual extern event global::mshtml.HTMLElementEvents2_oncopyEventHandler HTMLElementEvents2_Event_oncopy;

		// Token: 0x14000066 RID: 102
		// (add) Token: 0x06001191 RID: 4497
		// (remove) Token: 0x06001192 RID: 4498
		public virtual extern event global::mshtml.HTMLElementEvents2_onbeforepasteEventHandler HTMLElementEvents2_Event_onbeforepaste;

		// Token: 0x14000067 RID: 103
		// (add) Token: 0x06001193 RID: 4499
		// (remove) Token: 0x06001194 RID: 4500
		public virtual extern event global::mshtml.HTMLElementEvents2_onpasteEventHandler HTMLElementEvents2_Event_onpaste;

		// Token: 0x14000068 RID: 104
		// (add) Token: 0x06001195 RID: 4501
		// (remove) Token: 0x06001196 RID: 4502
		public virtual extern event global::mshtml.HTMLElementEvents2_oncontextmenuEventHandler HTMLElementEvents2_Event_oncontextmenu;

		// Token: 0x14000069 RID: 105
		// (add) Token: 0x06001197 RID: 4503
		// (remove) Token: 0x06001198 RID: 4504
		public virtual extern event global::mshtml.HTMLElementEvents2_onrowsdeleteEventHandler HTMLElementEvents2_Event_onrowsdelete;

		// Token: 0x1400006A RID: 106
		// (add) Token: 0x06001199 RID: 4505
		// (remove) Token: 0x0600119A RID: 4506
		public virtual extern event global::mshtml.HTMLElementEvents2_onrowsinsertedEventHandler HTMLElementEvents2_Event_onrowsinserted;

		// Token: 0x1400006B RID: 107
		// (add) Token: 0x0600119B RID: 4507
		// (remove) Token: 0x0600119C RID: 4508
		public virtual extern event global::mshtml.HTMLElementEvents2_oncellchangeEventHandler HTMLElementEvents2_Event_oncellchange;

		// Token: 0x1400006C RID: 108
		// (add) Token: 0x0600119D RID: 4509
		// (remove) Token: 0x0600119E RID: 4510
		public virtual extern event global::mshtml.HTMLElementEvents2_onreadystatechangeEventHandler HTMLElementEvents2_Event_onreadystatechange;

		// Token: 0x1400006D RID: 109
		// (add) Token: 0x0600119F RID: 4511
		// (remove) Token: 0x060011A0 RID: 4512
		public virtual extern event global::mshtml.HTMLElementEvents2_onlayoutcompleteEventHandler HTMLElementEvents2_Event_onlayoutcomplete;

		// Token: 0x1400006E RID: 110
		// (add) Token: 0x060011A1 RID: 4513
		// (remove) Token: 0x060011A2 RID: 4514
		public virtual extern event global::mshtml.HTMLElementEvents2_onpageEventHandler HTMLElementEvents2_Event_onpage;

		// Token: 0x1400006F RID: 111
		// (add) Token: 0x060011A3 RID: 4515
		// (remove) Token: 0x060011A4 RID: 4516
		public virtual extern event global::mshtml.HTMLElementEvents2_onmouseenterEventHandler HTMLElementEvents2_Event_onmouseenter;

		// Token: 0x14000070 RID: 112
		// (add) Token: 0x060011A5 RID: 4517
		// (remove) Token: 0x060011A6 RID: 4518
		public virtual extern event global::mshtml.HTMLElementEvents2_onmouseleaveEventHandler HTMLElementEvents2_Event_onmouseleave;

		// Token: 0x14000071 RID: 113
		// (add) Token: 0x060011A7 RID: 4519
		// (remove) Token: 0x060011A8 RID: 4520
		public virtual extern event global::mshtml.HTMLElementEvents2_onactivateEventHandler HTMLElementEvents2_Event_onactivate;

		// Token: 0x14000072 RID: 114
		// (add) Token: 0x060011A9 RID: 4521
		// (remove) Token: 0x060011AA RID: 4522
		public virtual extern event global::mshtml.HTMLElementEvents2_ondeactivateEventHandler HTMLElementEvents2_Event_ondeactivate;

		// Token: 0x14000073 RID: 115
		// (add) Token: 0x060011AB RID: 4523
		// (remove) Token: 0x060011AC RID: 4524
		public virtual extern event global::mshtml.HTMLElementEvents2_onbeforedeactivateEventHandler HTMLElementEvents2_Event_onbeforedeactivate;

		// Token: 0x14000074 RID: 116
		// (add) Token: 0x060011AD RID: 4525
		// (remove) Token: 0x060011AE RID: 4526
		public virtual extern event global::mshtml.HTMLElementEvents2_onbeforeactivateEventHandler HTMLElementEvents2_Event_onbeforeactivate;

		// Token: 0x14000075 RID: 117
		// (add) Token: 0x060011AF RID: 4527
		// (remove) Token: 0x060011B0 RID: 4528
		public virtual extern event global::mshtml.HTMLElementEvents2_onfocusinEventHandler HTMLElementEvents2_Event_onfocusin;

		// Token: 0x14000076 RID: 118
		// (add) Token: 0x060011B1 RID: 4529
		// (remove) Token: 0x060011B2 RID: 4530
		public virtual extern event global::mshtml.HTMLElementEvents2_onfocusoutEventHandler HTMLElementEvents2_Event_onfocusout;

		// Token: 0x14000077 RID: 119
		// (add) Token: 0x060011B3 RID: 4531
		// (remove) Token: 0x060011B4 RID: 4532
		public virtual extern event global::mshtml.HTMLElementEvents2_onmoveEventHandler HTMLElementEvents2_Event_onmove;

		// Token: 0x14000078 RID: 120
		// (add) Token: 0x060011B5 RID: 4533
		// (remove) Token: 0x060011B6 RID: 4534
		public virtual extern event global::mshtml.HTMLElementEvents2_oncontrolselectEventHandler HTMLElementEvents2_Event_oncontrolselect;

		// Token: 0x14000079 RID: 121
		// (add) Token: 0x060011B7 RID: 4535
		// (remove) Token: 0x060011B8 RID: 4536
		public virtual extern event global::mshtml.HTMLElementEvents2_onmovestartEventHandler HTMLElementEvents2_Event_onmovestart;

		// Token: 0x1400007A RID: 122
		// (add) Token: 0x060011B9 RID: 4537
		// (remove) Token: 0x060011BA RID: 4538
		public virtual extern event global::mshtml.HTMLElementEvents2_onmoveendEventHandler HTMLElementEvents2_Event_onmoveend;

		// Token: 0x1400007B RID: 123
		// (add) Token: 0x060011BB RID: 4539
		// (remove) Token: 0x060011BC RID: 4540
		public virtual extern event global::mshtml.HTMLElementEvents2_onresizestartEventHandler HTMLElementEvents2_Event_onresizestart;

		// Token: 0x1400007C RID: 124
		// (add) Token: 0x060011BD RID: 4541
		// (remove) Token: 0x060011BE RID: 4542
		public virtual extern event global::mshtml.HTMLElementEvents2_onresizeendEventHandler HTMLElementEvents2_Event_onresizeend;

		// Token: 0x1400007D RID: 125
		// (add) Token: 0x060011BF RID: 4543
		// (remove) Token: 0x060011C0 RID: 4544
		public virtual extern event global::mshtml.HTMLElementEvents2_onmousewheelEventHandler HTMLElementEvents2_Event_onmousewheel;
	}
}
