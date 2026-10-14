using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace mshtml
{
	// Token: 0x020006E3 RID: 1763
	[global::System.Runtime.InteropServices.TypeLibType(4112)]
	[global::System.Runtime.InteropServices.Guid("3050F527-98B5-11CF-BB82-00AA00BDCE0B")]
	[global::System.Runtime.InteropServices.InterfaceType(2)]
	[global::System.Runtime.InteropServices.ComImport]
	public interface DispHTMLMarqueeElement
	{
		// Token: 0x0600A8B1 RID: 43185
		[global::System.Runtime.InteropServices.DispId(-2147417611)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void setAttribute([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string strAttributeName, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] object AttributeValue, [global::System.Runtime.InteropServices.In] int lFlags = 1);

		// Token: 0x0600A8B2 RID: 43186
		[global::System.Runtime.InteropServices.DispId(-2147417610)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)]
		object getAttribute([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string strAttributeName, [global::System.Runtime.InteropServices.In] int lFlags = 0);

		// Token: 0x0600A8B3 RID: 43187
		[global::System.Runtime.InteropServices.DispId(-2147417609)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		bool removeAttribute([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string strAttributeName, [global::System.Runtime.InteropServices.In] int lFlags = 1);

		// Token: 0x1700368A RID: 13962
		// (get) Token: 0x0600A8B5 RID: 43189
		// (set) Token: 0x0600A8B4 RID: 43188
		[global::System.Runtime.InteropServices.DispId(-2147417111)]
		string className { [global::System.Runtime.InteropServices.TypeLibFunc(4)] [global::System.Runtime.InteropServices.DispId(-2147417111)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(-2147417111)] [global::System.Runtime.InteropServices.TypeLibFunc(4)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] set; }

		// Token: 0x1700368B RID: 13963
		// (get) Token: 0x0600A8B7 RID: 43191
		// (set) Token: 0x0600A8B6 RID: 43190
		[global::System.Runtime.InteropServices.DispId(-2147417110)]
		string id { [global::System.Runtime.InteropServices.DispId(-2147417110)] [global::System.Runtime.InteropServices.TypeLibFunc(4)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(-2147417110)] [global::System.Runtime.InteropServices.TypeLibFunc(4)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] set; }

		// Token: 0x1700368C RID: 13964
		// (get) Token: 0x0600A8B8 RID: 43192
		[global::System.Runtime.InteropServices.DispId(-2147417108)]
		string tagName { [global::System.Runtime.InteropServices.DispId(-2147417108)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x1700368D RID: 13965
		// (get) Token: 0x0600A8B9 RID: 43193
		[global::System.Runtime.InteropServices.DispId(-2147418104)]
		global::mshtml.IHTMLElement parentElement { [global::System.Runtime.InteropServices.DispId(-2147418104)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x1700368E RID: 13966
		// (get) Token: 0x0600A8BA RID: 43194
		[global::System.Runtime.InteropServices.DispId(-2147418038)]
		global::mshtml.IHTMLStyle style { [global::System.Runtime.InteropServices.DispId(-2147418038)] [global::System.Runtime.InteropServices.TypeLibFunc(1024)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x1700368F RID: 13967
		// (get) Token: 0x0600A8BC RID: 43196
		// (set) Token: 0x0600A8BB RID: 43195
		[global::System.Runtime.InteropServices.DispId(-2147412099)]
		object onhelp { [global::System.Runtime.InteropServices.DispId(-2147412099)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412099)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x17003690 RID: 13968
		// (get) Token: 0x0600A8BE RID: 43198
		// (set) Token: 0x0600A8BD RID: 43197
		[global::System.Runtime.InteropServices.DispId(-2147412104)]
		object onclick { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412104)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412104)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x17003691 RID: 13969
		// (get) Token: 0x0600A8C0 RID: 43200
		// (set) Token: 0x0600A8BF RID: 43199
		[global::System.Runtime.InteropServices.DispId(-2147412103)]
		object ondblclick { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412103)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147412103)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x17003692 RID: 13970
		// (get) Token: 0x0600A8C2 RID: 43202
		// (set) Token: 0x0600A8C1 RID: 43201
		[global::System.Runtime.InteropServices.DispId(-2147412107)]
		object onkeydown { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412107)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412107)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x17003693 RID: 13971
		// (get) Token: 0x0600A8C4 RID: 43204
		// (set) Token: 0x0600A8C3 RID: 43203
		[global::System.Runtime.InteropServices.DispId(-2147412106)]
		object onkeyup { [global::System.Runtime.InteropServices.DispId(-2147412106)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147412106)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x17003694 RID: 13972
		// (get) Token: 0x0600A8C6 RID: 43206
		// (set) Token: 0x0600A8C5 RID: 43205
		[global::System.Runtime.InteropServices.DispId(-2147412105)]
		object onkeypress { [global::System.Runtime.InteropServices.DispId(-2147412105)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412105)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x17003695 RID: 13973
		// (get) Token: 0x0600A8C8 RID: 43208
		// (set) Token: 0x0600A8C7 RID: 43207
		[global::System.Runtime.InteropServices.DispId(-2147412111)]
		object onmouseout { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412111)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412111)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x17003696 RID: 13974
		// (get) Token: 0x0600A8CA RID: 43210
		// (set) Token: 0x0600A8C9 RID: 43209
		[global::System.Runtime.InteropServices.DispId(-2147412112)]
		object onmouseover { [global::System.Runtime.InteropServices.DispId(-2147412112)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412112)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x17003697 RID: 13975
		// (get) Token: 0x0600A8CC RID: 43212
		// (set) Token: 0x0600A8CB RID: 43211
		[global::System.Runtime.InteropServices.DispId(-2147412108)]
		object onmousemove { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412108)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147412108)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x17003698 RID: 13976
		// (get) Token: 0x0600A8CE RID: 43214
		// (set) Token: 0x0600A8CD RID: 43213
		[global::System.Runtime.InteropServices.DispId(-2147412110)]
		object onmousedown { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412110)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412110)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x17003699 RID: 13977
		// (get) Token: 0x0600A8D0 RID: 43216
		// (set) Token: 0x0600A8CF RID: 43215
		[global::System.Runtime.InteropServices.DispId(-2147412109)]
		object onmouseup { [global::System.Runtime.InteropServices.DispId(-2147412109)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147412109)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x1700369A RID: 13978
		// (get) Token: 0x0600A8D1 RID: 43217
		[global::System.Runtime.InteropServices.DispId(-2147417094)]
		object document { [global::System.Runtime.InteropServices.DispId(-2147417094)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] get; }

		// Token: 0x1700369B RID: 13979
		// (get) Token: 0x0600A8D3 RID: 43219
		// (set) Token: 0x0600A8D2 RID: 43218
		[global::System.Runtime.InteropServices.DispId(-2147418043)]
		string title { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147418043)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147418043)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] set; }

		// Token: 0x1700369C RID: 13980
		// (get) Token: 0x0600A8D5 RID: 43221
		// (set) Token: 0x0600A8D4 RID: 43220
		[global::System.Runtime.InteropServices.DispId(-2147413012)]
		string language { [global::System.Runtime.InteropServices.DispId(-2147413012)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(-2147413012)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] set; }

		// Token: 0x1700369D RID: 13981
		// (get) Token: 0x0600A8D7 RID: 43223
		// (set) Token: 0x0600A8D6 RID: 43222
		[global::System.Runtime.InteropServices.DispId(-2147412075)]
		object onselectstart { [global::System.Runtime.InteropServices.DispId(-2147412075)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147412075)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x0600A8D8 RID: 43224
		[global::System.Runtime.InteropServices.DispId(-2147417093)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void scrollIntoView([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] object varargStart);

		// Token: 0x0600A8D9 RID: 43225
		[global::System.Runtime.InteropServices.DispId(-2147417092)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		bool contains([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLElement pChild);

		// Token: 0x1700369E RID: 13982
		// (get) Token: 0x0600A8DA RID: 43226
		[global::System.Runtime.InteropServices.DispId(-2147417088)]
		int sourceIndex { [global::System.Runtime.InteropServices.TypeLibFunc(4)] [global::System.Runtime.InteropServices.DispId(-2147417088)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700369F RID: 13983
		// (get) Token: 0x0600A8DB RID: 43227
		[global::System.Runtime.InteropServices.DispId(-2147417087)]
		object recordNumber { [global::System.Runtime.InteropServices.DispId(-2147417087)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; }

		// Token: 0x170036A0 RID: 13984
		// (get) Token: 0x0600A8DD RID: 43229
		// (set) Token: 0x0600A8DC RID: 43228
		[global::System.Runtime.InteropServices.DispId(-2147413103)]
		string lang { [global::System.Runtime.InteropServices.DispId(-2147413103)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(-2147413103)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] set; }

		// Token: 0x170036A1 RID: 13985
		// (get) Token: 0x0600A8DE RID: 43230
		[global::System.Runtime.InteropServices.DispId(-2147417104)]
		int offsetLeft { [global::System.Runtime.InteropServices.DispId(-2147417104)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x170036A2 RID: 13986
		// (get) Token: 0x0600A8DF RID: 43231
		[global::System.Runtime.InteropServices.DispId(-2147417103)]
		int offsetTop { [global::System.Runtime.InteropServices.DispId(-2147417103)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x170036A3 RID: 13987
		// (get) Token: 0x0600A8E0 RID: 43232
		[global::System.Runtime.InteropServices.DispId(-2147417102)]
		int offsetWidth { [global::System.Runtime.InteropServices.DispId(-2147417102)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x170036A4 RID: 13988
		// (get) Token: 0x0600A8E1 RID: 43233
		[global::System.Runtime.InteropServices.DispId(-2147417101)]
		int offsetHeight { [global::System.Runtime.InteropServices.DispId(-2147417101)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x170036A5 RID: 13989
		// (get) Token: 0x0600A8E2 RID: 43234
		[global::System.Runtime.InteropServices.DispId(-2147417100)]
		global::mshtml.IHTMLElement offsetParent { [global::System.Runtime.InteropServices.DispId(-2147417100)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x170036A6 RID: 13990
		// (get) Token: 0x0600A8E4 RID: 43236
		// (set) Token: 0x0600A8E3 RID: 43235
		[global::System.Runtime.InteropServices.DispId(-2147417086)]
		string innerHTML { [global::System.Runtime.InteropServices.DispId(-2147417086)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(-2147417086)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] set; }

		// Token: 0x170036A7 RID: 13991
		// (get) Token: 0x0600A8E6 RID: 43238
		// (set) Token: 0x0600A8E5 RID: 43237
		[global::System.Runtime.InteropServices.DispId(-2147417085)]
		string innerText { [global::System.Runtime.InteropServices.DispId(-2147417085)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(-2147417085)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] set; }

		// Token: 0x170036A8 RID: 13992
		// (get) Token: 0x0600A8E8 RID: 43240
		// (set) Token: 0x0600A8E7 RID: 43239
		[global::System.Runtime.InteropServices.DispId(-2147417084)]
		string outerHTML { [global::System.Runtime.InteropServices.DispId(-2147417084)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(-2147417084)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] set; }

		// Token: 0x170036A9 RID: 13993
		// (get) Token: 0x0600A8EA RID: 43242
		// (set) Token: 0x0600A8E9 RID: 43241
		[global::System.Runtime.InteropServices.DispId(-2147417083)]
		string outerText { [global::System.Runtime.InteropServices.DispId(-2147417083)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(-2147417083)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] set; }

		// Token: 0x0600A8EB RID: 43243
		[global::System.Runtime.InteropServices.DispId(-2147417082)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void insertAdjacentHTML([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string where, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string html);

		// Token: 0x0600A8EC RID: 43244
		[global::System.Runtime.InteropServices.DispId(-2147417081)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void insertAdjacentText([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string where, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string text);

		// Token: 0x170036AA RID: 13994
		// (get) Token: 0x0600A8ED RID: 43245
		[global::System.Runtime.InteropServices.DispId(-2147417080)]
		global::mshtml.IHTMLElement parentTextEdit { [global::System.Runtime.InteropServices.DispId(-2147417080)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x170036AB RID: 13995
		// (get) Token: 0x0600A8EE RID: 43246
		[global::System.Runtime.InteropServices.DispId(-2147417078)]
		bool isTextEdit { [global::System.Runtime.InteropServices.DispId(-2147417078)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x0600A8EF RID: 43247
		[global::System.Runtime.InteropServices.DispId(-2147417079)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void click();

		// Token: 0x170036AC RID: 13996
		// (get) Token: 0x0600A8F0 RID: 43248
		[global::System.Runtime.InteropServices.DispId(-2147417077)]
		global::mshtml.IHTMLFiltersCollection filters { [global::System.Runtime.InteropServices.DispId(-2147417077)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x170036AD RID: 13997
		// (get) Token: 0x0600A8F2 RID: 43250
		// (set) Token: 0x0600A8F1 RID: 43249
		[global::System.Runtime.InteropServices.DispId(-2147412077)]
		object ondragstart { [global::System.Runtime.InteropServices.DispId(-2147412077)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147412077)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x0600A8F3 RID: 43251
		[global::System.Runtime.InteropServices.DispId(-2147417076)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		string toString();

		// Token: 0x170036AE RID: 13998
		// (get) Token: 0x0600A8F5 RID: 43253
		// (set) Token: 0x0600A8F4 RID: 43252
		[global::System.Runtime.InteropServices.DispId(-2147412091)]
		object onbeforeupdate { [global::System.Runtime.InteropServices.DispId(-2147412091)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412091)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x170036AF RID: 13999
		// (get) Token: 0x0600A8F7 RID: 43255
		// (set) Token: 0x0600A8F6 RID: 43254
		[global::System.Runtime.InteropServices.DispId(-2147412090)]
		object onafterupdate { [global::System.Runtime.InteropServices.DispId(-2147412090)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412090)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x170036B0 RID: 14000
		// (get) Token: 0x0600A8F9 RID: 43257
		// (set) Token: 0x0600A8F8 RID: 43256
		[global::System.Runtime.InteropServices.DispId(-2147412074)]
		object onerrorupdate { [global::System.Runtime.InteropServices.DispId(-2147412074)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147412074)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x170036B1 RID: 14001
		// (get) Token: 0x0600A8FB RID: 43259
		// (set) Token: 0x0600A8FA RID: 43258
		[global::System.Runtime.InteropServices.DispId(-2147412094)]
		object onrowexit { [global::System.Runtime.InteropServices.DispId(-2147412094)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412094)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x170036B2 RID: 14002
		// (get) Token: 0x0600A8FD RID: 43261
		// (set) Token: 0x0600A8FC RID: 43260
		[global::System.Runtime.InteropServices.DispId(-2147412093)]
		object onrowenter { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412093)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412093)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x170036B3 RID: 14003
		// (get) Token: 0x0600A8FF RID: 43263
		// (set) Token: 0x0600A8FE RID: 43262
		[global::System.Runtime.InteropServices.DispId(-2147412072)]
		object ondatasetchanged { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412072)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147412072)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x170036B4 RID: 14004
		// (get) Token: 0x0600A901 RID: 43265
		// (set) Token: 0x0600A900 RID: 43264
		[global::System.Runtime.InteropServices.DispId(-2147412071)]
		object ondataavailable { [global::System.Runtime.InteropServices.DispId(-2147412071)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412071)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x170036B5 RID: 14005
		// (get) Token: 0x0600A903 RID: 43267
		// (set) Token: 0x0600A902 RID: 43266
		[global::System.Runtime.InteropServices.DispId(-2147412070)]
		object ondatasetcomplete { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412070)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412070)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x170036B6 RID: 14006
		// (get) Token: 0x0600A905 RID: 43269
		// (set) Token: 0x0600A904 RID: 43268
		[global::System.Runtime.InteropServices.DispId(-2147412069)]
		object onfilterchange { [global::System.Runtime.InteropServices.DispId(-2147412069)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147412069)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x170036B7 RID: 14007
		// (get) Token: 0x0600A906 RID: 43270
		[global::System.Runtime.InteropServices.DispId(-2147417075)]
		object children { [global::System.Runtime.InteropServices.DispId(-2147417075)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] get; }

		// Token: 0x170036B8 RID: 14008
		// (get) Token: 0x0600A907 RID: 43271
		[global::System.Runtime.InteropServices.DispId(-2147417074)]
		object all { [global::System.Runtime.InteropServices.DispId(-2147417074)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] get; }

		// Token: 0x170036B9 RID: 14009
		// (get) Token: 0x0600A908 RID: 43272
		[global::System.Runtime.InteropServices.DispId(-2147417073)]
		string scopeName { [global::System.Runtime.InteropServices.DispId(-2147417073)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x0600A909 RID: 43273
		[global::System.Runtime.InteropServices.DispId(-2147417072)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void setCapture([global::System.Runtime.InteropServices.In] bool containerCapture = true);

		// Token: 0x0600A90A RID: 43274
		[global::System.Runtime.InteropServices.DispId(-2147417071)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void releaseCapture();

		// Token: 0x170036BA RID: 14010
		// (get) Token: 0x0600A90C RID: 43276
		// (set) Token: 0x0600A90B RID: 43275
		[global::System.Runtime.InteropServices.DispId(-2147412066)]
		object onlosecapture { [global::System.Runtime.InteropServices.DispId(-2147412066)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147412066)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x0600A90D RID: 43277
		[global::System.Runtime.InteropServices.DispId(-2147417070)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		string componentFromPoint([global::System.Runtime.InteropServices.In] int x, [global::System.Runtime.InteropServices.In] int y);

		// Token: 0x0600A90E RID: 43278
		[global::System.Runtime.InteropServices.DispId(-2147417069)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void doScroll([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] object component);

		// Token: 0x170036BB RID: 14011
		// (get) Token: 0x0600A910 RID: 43280
		// (set) Token: 0x0600A90F RID: 43279
		[global::System.Runtime.InteropServices.DispId(-2147412081)]
		object onscroll { [global::System.Runtime.InteropServices.DispId(-2147412081)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412081)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x170036BC RID: 14012
		// (get) Token: 0x0600A912 RID: 43282
		// (set) Token: 0x0600A911 RID: 43281
		[global::System.Runtime.InteropServices.DispId(-2147412063)]
		object ondrag { [global::System.Runtime.InteropServices.DispId(-2147412063)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412063)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x170036BD RID: 14013
		// (get) Token: 0x0600A914 RID: 43284
		// (set) Token: 0x0600A913 RID: 43283
		[global::System.Runtime.InteropServices.DispId(-2147412062)]
		object ondragend { [global::System.Runtime.InteropServices.DispId(-2147412062)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412062)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x170036BE RID: 14014
		// (get) Token: 0x0600A916 RID: 43286
		// (set) Token: 0x0600A915 RID: 43285
		[global::System.Runtime.InteropServices.DispId(-2147412061)]
		object ondragenter { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412061)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412061)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x170036BF RID: 14015
		// (get) Token: 0x0600A918 RID: 43288
		// (set) Token: 0x0600A917 RID: 43287
		[global::System.Runtime.InteropServices.DispId(-2147412060)]
		object ondragover { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412060)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147412060)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x170036C0 RID: 14016
		// (get) Token: 0x0600A91A RID: 43290
		// (set) Token: 0x0600A919 RID: 43289
		[global::System.Runtime.InteropServices.DispId(-2147412059)]
		object ondragleave { [global::System.Runtime.InteropServices.DispId(-2147412059)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412059)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x170036C1 RID: 14017
		// (get) Token: 0x0600A91C RID: 43292
		// (set) Token: 0x0600A91B RID: 43291
		[global::System.Runtime.InteropServices.DispId(-2147412058)]
		object ondrop { [global::System.Runtime.InteropServices.DispId(-2147412058)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412058)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x170036C2 RID: 14018
		// (get) Token: 0x0600A91E RID: 43294
		// (set) Token: 0x0600A91D RID: 43293
		[global::System.Runtime.InteropServices.DispId(-2147412054)]
		object onbeforecut { [global::System.Runtime.InteropServices.DispId(-2147412054)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412054)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x170036C3 RID: 14019
		// (get) Token: 0x0600A920 RID: 43296
		// (set) Token: 0x0600A91F RID: 43295
		[global::System.Runtime.InteropServices.DispId(-2147412057)]
		object oncut { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412057)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147412057)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x170036C4 RID: 14020
		// (get) Token: 0x0600A922 RID: 43298
		// (set) Token: 0x0600A921 RID: 43297
		[global::System.Runtime.InteropServices.DispId(-2147412053)]
		object onbeforecopy { [global::System.Runtime.InteropServices.DispId(-2147412053)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412053)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x170036C5 RID: 14021
		// (get) Token: 0x0600A924 RID: 43300
		// (set) Token: 0x0600A923 RID: 43299
		[global::System.Runtime.InteropServices.DispId(-2147412056)]
		object oncopy { [global::System.Runtime.InteropServices.DispId(-2147412056)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147412056)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x170036C6 RID: 14022
		// (get) Token: 0x0600A926 RID: 43302
		// (set) Token: 0x0600A925 RID: 43301
		[global::System.Runtime.InteropServices.DispId(-2147412052)]
		object onbeforepaste { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412052)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412052)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x170036C7 RID: 14023
		// (get) Token: 0x0600A928 RID: 43304
		// (set) Token: 0x0600A927 RID: 43303
		[global::System.Runtime.InteropServices.DispId(-2147412055)]
		object onpaste { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412055)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147412055)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x170036C8 RID: 14024
		// (get) Token: 0x0600A929 RID: 43305
		[global::System.Runtime.InteropServices.DispId(-2147417105)]
		global::mshtml.IHTMLCurrentStyle currentStyle { [global::System.Runtime.InteropServices.TypeLibFunc(1024)] [global::System.Runtime.InteropServices.DispId(-2147417105)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x170036C9 RID: 14025
		// (get) Token: 0x0600A92B RID: 43307
		// (set) Token: 0x0600A92A RID: 43306
		[global::System.Runtime.InteropServices.DispId(-2147412065)]
		object onpropertychange { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412065)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412065)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x0600A92C RID: 43308
		[global::System.Runtime.InteropServices.DispId(-2147417068)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		global::mshtml.IHTMLRectCollection getClientRects();

		// Token: 0x0600A92D RID: 43309
		[global::System.Runtime.InteropServices.DispId(-2147417067)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		global::mshtml.IHTMLRect getBoundingClientRect();

		// Token: 0x0600A92E RID: 43310
		[global::System.Runtime.InteropServices.DispId(-2147417608)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void setExpression([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string propname, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string expression, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string language = "");

		// Token: 0x0600A92F RID: 43311
		[global::System.Runtime.InteropServices.DispId(-2147417607)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)]
		object getExpression([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string propname);

		// Token: 0x0600A930 RID: 43312
		[global::System.Runtime.InteropServices.DispId(-2147417606)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		bool removeExpression([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string propname);

		// Token: 0x170036CA RID: 14026
		// (get) Token: 0x0600A932 RID: 43314
		// (set) Token: 0x0600A931 RID: 43313
		[global::System.Runtime.InteropServices.DispId(-2147418097)]
		short tabIndex { [global::System.Runtime.InteropServices.DispId(-2147418097)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147418097)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] set; }

		// Token: 0x0600A933 RID: 43315
		[global::System.Runtime.InteropServices.DispId(-2147416112)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void focus();

		// Token: 0x170036CB RID: 14027
		// (get) Token: 0x0600A935 RID: 43317
		// (set) Token: 0x0600A934 RID: 43316
		[global::System.Runtime.InteropServices.DispId(-2147416107)]
		string accessKey { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147416107)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147416107)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] set; }

		// Token: 0x170036CC RID: 14028
		// (get) Token: 0x0600A937 RID: 43319
		// (set) Token: 0x0600A936 RID: 43318
		[global::System.Runtime.InteropServices.DispId(-2147412097)]
		object onblur { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412097)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147412097)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x170036CD RID: 14029
		// (get) Token: 0x0600A939 RID: 43321
		// (set) Token: 0x0600A938 RID: 43320
		[global::System.Runtime.InteropServices.DispId(-2147412098)]
		object onfocus { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412098)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147412098)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x170036CE RID: 14030
		// (get) Token: 0x0600A93B RID: 43323
		// (set) Token: 0x0600A93A RID: 43322
		[global::System.Runtime.InteropServices.DispId(-2147412076)]
		object onresize { [global::System.Runtime.InteropServices.DispId(-2147412076)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412076)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x0600A93C RID: 43324
		[global::System.Runtime.InteropServices.DispId(-2147416110)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void blur();

		// Token: 0x0600A93D RID: 43325
		[global::System.Runtime.InteropServices.DispId(-2147416095)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void addFilter([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IUnknown)] [global::System.Runtime.InteropServices.In] object pUnk);

		// Token: 0x0600A93E RID: 43326
		[global::System.Runtime.InteropServices.DispId(-2147416094)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void removeFilter([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IUnknown)] [global::System.Runtime.InteropServices.In] object pUnk);

		// Token: 0x170036CF RID: 14031
		// (get) Token: 0x0600A93F RID: 43327
		[global::System.Runtime.InteropServices.DispId(-2147416093)]
		int clientHeight { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147416093)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x170036D0 RID: 14032
		// (get) Token: 0x0600A940 RID: 43328
		[global::System.Runtime.InteropServices.DispId(-2147416092)]
		int clientWidth { [global::System.Runtime.InteropServices.DispId(-2147416092)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x170036D1 RID: 14033
		// (get) Token: 0x0600A941 RID: 43329
		[global::System.Runtime.InteropServices.DispId(-2147416091)]
		int clientTop { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147416091)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x170036D2 RID: 14034
		// (get) Token: 0x0600A942 RID: 43330
		[global::System.Runtime.InteropServices.DispId(-2147416090)]
		int clientLeft { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147416090)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x0600A943 RID: 43331
		[global::System.Runtime.InteropServices.DispId(-2147417605)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		bool attachEvent([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string @event, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] [global::System.Runtime.InteropServices.In] object pdisp);

		// Token: 0x0600A944 RID: 43332
		[global::System.Runtime.InteropServices.DispId(-2147417604)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void detachEvent([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string @event, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] [global::System.Runtime.InteropServices.In] object pdisp);

		// Token: 0x170036D3 RID: 14035
		// (get) Token: 0x0600A945 RID: 43333
		[global::System.Runtime.InteropServices.DispId(-2147412996)]
		object readyState { [global::System.Runtime.InteropServices.DispId(-2147412996)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; }

		// Token: 0x170036D4 RID: 14036
		// (get) Token: 0x0600A947 RID: 43335
		// (set) Token: 0x0600A946 RID: 43334
		[global::System.Runtime.InteropServices.DispId(-2147412087)]
		object onreadystatechange { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412087)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147412087)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x170036D5 RID: 14037
		// (get) Token: 0x0600A949 RID: 43337
		// (set) Token: 0x0600A948 RID: 43336
		[global::System.Runtime.InteropServices.DispId(-2147412050)]
		object onrowsdelete { [global::System.Runtime.InteropServices.DispId(-2147412050)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147412050)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x170036D6 RID: 14038
		// (get) Token: 0x0600A94B RID: 43339
		// (set) Token: 0x0600A94A RID: 43338
		[global::System.Runtime.InteropServices.DispId(-2147412049)]
		object onrowsinserted { [global::System.Runtime.InteropServices.DispId(-2147412049)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412049)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x170036D7 RID: 14039
		// (get) Token: 0x0600A94D RID: 43341
		// (set) Token: 0x0600A94C RID: 43340
		[global::System.Runtime.InteropServices.DispId(-2147412048)]
		object oncellchange { [global::System.Runtime.InteropServices.DispId(-2147412048)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412048)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x170036D8 RID: 14040
		// (get) Token: 0x0600A94F RID: 43343
		// (set) Token: 0x0600A94E RID: 43342
		[global::System.Runtime.InteropServices.DispId(-2147412995)]
		string dir { [global::System.Runtime.InteropServices.DispId(-2147412995)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412995)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] set; }

		// Token: 0x0600A950 RID: 43344
		[global::System.Runtime.InteropServices.DispId(-2147417056)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)]
		object createControlRange();

		// Token: 0x170036D9 RID: 14041
		// (get) Token: 0x0600A951 RID: 43345
		[global::System.Runtime.InteropServices.DispId(-2147417055)]
		int scrollHeight { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147417055)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x170036DA RID: 14042
		// (get) Token: 0x0600A952 RID: 43346
		[global::System.Runtime.InteropServices.DispId(-2147417054)]
		int scrollWidth { [global::System.Runtime.InteropServices.DispId(-2147417054)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x170036DB RID: 14043
		// (get) Token: 0x0600A954 RID: 43348
		// (set) Token: 0x0600A953 RID: 43347
		[global::System.Runtime.InteropServices.DispId(-2147417053)]
		int scrollTop { [global::System.Runtime.InteropServices.DispId(-2147417053)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147417053)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] set; }

		// Token: 0x170036DC RID: 14044
		// (get) Token: 0x0600A956 RID: 43350
		// (set) Token: 0x0600A955 RID: 43349
		[global::System.Runtime.InteropServices.DispId(-2147417052)]
		int scrollLeft { [global::System.Runtime.InteropServices.DispId(-2147417052)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147417052)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] set; }

		// Token: 0x0600A957 RID: 43351
		[global::System.Runtime.InteropServices.DispId(-2147417050)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void clearAttributes();

		// Token: 0x170036DD RID: 14045
		// (get) Token: 0x0600A959 RID: 43353
		// (set) Token: 0x0600A958 RID: 43352
		[global::System.Runtime.InteropServices.DispId(-2147412047)]
		object oncontextmenu { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412047)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412047)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x0600A95A RID: 43354
		[global::System.Runtime.InteropServices.DispId(-2147417043)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		global::mshtml.IHTMLElement insertAdjacentElement([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string where, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLElement insertedElement);

		// Token: 0x0600A95B RID: 43355
		[global::System.Runtime.InteropServices.DispId(-2147417047)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		global::mshtml.IHTMLElement applyElement([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLElement apply, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string where);

		// Token: 0x0600A95C RID: 43356
		[global::System.Runtime.InteropServices.DispId(-2147417042)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		string getAdjacentText([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string where);

		// Token: 0x0600A95D RID: 43357
		[global::System.Runtime.InteropServices.DispId(-2147417041)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		string replaceAdjacentText([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string where, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string newText);

		// Token: 0x170036DE RID: 14046
		// (get) Token: 0x0600A95E RID: 43358
		[global::System.Runtime.InteropServices.DispId(-2147417040)]
		bool canHaveChildren { [global::System.Runtime.InteropServices.DispId(-2147417040)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x0600A95F RID: 43359
		[global::System.Runtime.InteropServices.DispId(-2147417032)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		int addBehavior([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string bstrUrl, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object pvarFactory);

		// Token: 0x0600A960 RID: 43360
		[global::System.Runtime.InteropServices.DispId(-2147417031)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		bool removeBehavior([global::System.Runtime.InteropServices.In] int cookie);

		// Token: 0x170036DF RID: 14047
		// (get) Token: 0x0600A961 RID: 43361
		[global::System.Runtime.InteropServices.DispId(-2147417048)]
		global::mshtml.IHTMLStyle runtimeStyle { [global::System.Runtime.InteropServices.DispId(-2147417048)] [global::System.Runtime.InteropServices.TypeLibFunc(1024)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x170036E0 RID: 14048
		// (get) Token: 0x0600A962 RID: 43362
		[global::System.Runtime.InteropServices.DispId(-2147417030)]
		object behaviorUrns { [global::System.Runtime.InteropServices.DispId(-2147417030)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] get; }

		// Token: 0x170036E1 RID: 14049
		// (get) Token: 0x0600A964 RID: 43364
		// (set) Token: 0x0600A963 RID: 43363
		[global::System.Runtime.InteropServices.DispId(-2147417029)]
		string tagUrn { [global::System.Runtime.InteropServices.DispId(-2147417029)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(-2147417029)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] set; }

		// Token: 0x170036E2 RID: 14050
		// (get) Token: 0x0600A966 RID: 43366
		// (set) Token: 0x0600A965 RID: 43365
		[global::System.Runtime.InteropServices.DispId(-2147412043)]
		object onbeforeeditfocus { [global::System.Runtime.InteropServices.DispId(-2147412043)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412043)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x170036E3 RID: 14051
		// (get) Token: 0x0600A967 RID: 43367
		[global::System.Runtime.InteropServices.DispId(-2147417028)]
		int readyStateValue { [global::System.Runtime.InteropServices.DispId(-2147417028)] [global::System.Runtime.InteropServices.TypeLibFunc(65)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x0600A968 RID: 43368
		[global::System.Runtime.InteropServices.DispId(-2147417027)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		global::mshtml.IHTMLElementCollection getElementsByTagName([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string v);

		// Token: 0x0600A969 RID: 43369
		[global::System.Runtime.InteropServices.DispId(-2147417016)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void mergeAttributes([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLElement mergeThis, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object pvarFlags);

		// Token: 0x170036E4 RID: 14052
		// (get) Token: 0x0600A96A RID: 43370
		[global::System.Runtime.InteropServices.DispId(-2147417015)]
		bool isMultiLine { [global::System.Runtime.InteropServices.DispId(-2147417015)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x170036E5 RID: 14053
		// (get) Token: 0x0600A96B RID: 43371
		[global::System.Runtime.InteropServices.DispId(-2147417014)]
		bool canHaveHTML { [global::System.Runtime.InteropServices.DispId(-2147417014)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x170036E6 RID: 14054
		// (get) Token: 0x0600A96D RID: 43373
		// (set) Token: 0x0600A96C RID: 43372
		[global::System.Runtime.InteropServices.DispId(-2147412039)]
		object onlayoutcomplete { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412039)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412039)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x170036E7 RID: 14055
		// (get) Token: 0x0600A96F RID: 43375
		// (set) Token: 0x0600A96E RID: 43374
		[global::System.Runtime.InteropServices.DispId(-2147412038)]
		object onpage { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412038)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147412038)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x170036E8 RID: 14056
		// (get) Token: 0x0600A971 RID: 43377
		// (set) Token: 0x0600A970 RID: 43376
		[global::System.Runtime.InteropServices.DispId(-2147417012)]
		bool inflateBlock { [global::System.Runtime.InteropServices.DispId(-2147417012)] [global::System.Runtime.InteropServices.TypeLibFunc(1089)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(-2147417012)] [global::System.Runtime.InteropServices.TypeLibFunc(1089)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] set; }

		// Token: 0x170036E9 RID: 14057
		// (get) Token: 0x0600A973 RID: 43379
		// (set) Token: 0x0600A972 RID: 43378
		[global::System.Runtime.InteropServices.DispId(-2147412035)]
		object onbeforedeactivate { [global::System.Runtime.InteropServices.DispId(-2147412035)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147412035)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x0600A974 RID: 43380
		[global::System.Runtime.InteropServices.DispId(-2147417011)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void setActive();

		// Token: 0x170036EA RID: 14058
		// (get) Token: 0x0600A976 RID: 43382
		// (set) Token: 0x0600A975 RID: 43381
		[global::System.Runtime.InteropServices.DispId(-2147412950)]
		string contentEditable { [global::System.Runtime.InteropServices.DispId(-2147412950)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(-2147412950)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] set; }

		// Token: 0x170036EB RID: 14059
		// (get) Token: 0x0600A977 RID: 43383
		[global::System.Runtime.InteropServices.DispId(-2147417010)]
		bool isContentEditable { [global::System.Runtime.InteropServices.DispId(-2147417010)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x170036EC RID: 14060
		// (get) Token: 0x0600A979 RID: 43385
		// (set) Token: 0x0600A978 RID: 43384
		[global::System.Runtime.InteropServices.DispId(-2147412949)]
		bool hideFocus { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412949)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412949)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] set; }

		// Token: 0x170036ED RID: 14061
		// (get) Token: 0x0600A97B RID: 43387
		// (set) Token: 0x0600A97A RID: 43386
		[global::System.Runtime.InteropServices.DispId(-2147418036)]
		bool disabled { [global::System.Runtime.InteropServices.DispId(-2147418036)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(-2147418036)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] set; }

		// Token: 0x170036EE RID: 14062
		// (get) Token: 0x0600A97C RID: 43388
		[global::System.Runtime.InteropServices.DispId(-2147417007)]
		bool isDisabled { [global::System.Runtime.InteropServices.DispId(-2147417007)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x170036EF RID: 14063
		// (get) Token: 0x0600A97E RID: 43390
		// (set) Token: 0x0600A97D RID: 43389
		[global::System.Runtime.InteropServices.DispId(-2147412034)]
		object onmove { [global::System.Runtime.InteropServices.DispId(-2147412034)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147412034)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x170036F0 RID: 14064
		// (get) Token: 0x0600A980 RID: 43392
		// (set) Token: 0x0600A97F RID: 43391
		[global::System.Runtime.InteropServices.DispId(-2147412033)]
		object oncontrolselect { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412033)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412033)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x0600A981 RID: 43393
		[global::System.Runtime.InteropServices.DispId(-2147417006)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		bool FireEvent([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string bstrEventName, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object pvarEventObject);

		// Token: 0x170036F1 RID: 14065
		// (get) Token: 0x0600A983 RID: 43395
		// (set) Token: 0x0600A982 RID: 43394
		[global::System.Runtime.InteropServices.DispId(-2147412029)]
		object onresizestart { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412029)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412029)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x170036F2 RID: 14066
		// (get) Token: 0x0600A985 RID: 43397
		// (set) Token: 0x0600A984 RID: 43396
		[global::System.Runtime.InteropServices.DispId(-2147412028)]
		object onresizeend { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412028)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147412028)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x170036F3 RID: 14067
		// (get) Token: 0x0600A987 RID: 43399
		// (set) Token: 0x0600A986 RID: 43398
		[global::System.Runtime.InteropServices.DispId(-2147412031)]
		object onmovestart { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412031)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412031)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x170036F4 RID: 14068
		// (get) Token: 0x0600A989 RID: 43401
		// (set) Token: 0x0600A988 RID: 43400
		[global::System.Runtime.InteropServices.DispId(-2147412030)]
		object onmoveend { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412030)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147412030)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x170036F5 RID: 14069
		// (get) Token: 0x0600A98B RID: 43403
		// (set) Token: 0x0600A98A RID: 43402
		[global::System.Runtime.InteropServices.DispId(-2147412027)]
		object onmouseenter { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412027)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147412027)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x170036F6 RID: 14070
		// (get) Token: 0x0600A98D RID: 43405
		// (set) Token: 0x0600A98C RID: 43404
		[global::System.Runtime.InteropServices.DispId(-2147412026)]
		object onmouseleave { [global::System.Runtime.InteropServices.DispId(-2147412026)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147412026)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x170036F7 RID: 14071
		// (get) Token: 0x0600A98F RID: 43407
		// (set) Token: 0x0600A98E RID: 43406
		[global::System.Runtime.InteropServices.DispId(-2147412025)]
		object onactivate { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412025)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412025)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x170036F8 RID: 14072
		// (get) Token: 0x0600A991 RID: 43409
		// (set) Token: 0x0600A990 RID: 43408
		[global::System.Runtime.InteropServices.DispId(-2147412024)]
		object ondeactivate { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412024)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412024)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x0600A992 RID: 43410
		[global::System.Runtime.InteropServices.DispId(-2147417005)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		bool dragDrop();

		// Token: 0x170036F9 RID: 14073
		// (get) Token: 0x0600A993 RID: 43411
		[global::System.Runtime.InteropServices.DispId(-2147417004)]
		int glyphMode { [global::System.Runtime.InteropServices.DispId(-2147417004)] [global::System.Runtime.InteropServices.TypeLibFunc(1089)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x170036FA RID: 14074
		// (get) Token: 0x0600A995 RID: 43413
		// (set) Token: 0x0600A994 RID: 43412
		[global::System.Runtime.InteropServices.DispId(-2147412036)]
		object onmousewheel { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412036)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147412036)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x0600A996 RID: 43414
		[global::System.Runtime.InteropServices.DispId(-2147417000)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void normalize();

		// Token: 0x0600A997 RID: 43415
		[global::System.Runtime.InteropServices.DispId(-2147417003)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		global::mshtml.IHTMLDOMAttribute getAttributeNode([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string bstrName);

		// Token: 0x0600A998 RID: 43416
		[global::System.Runtime.InteropServices.DispId(-2147417002)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		global::mshtml.IHTMLDOMAttribute setAttributeNode([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLDOMAttribute pattr);

		// Token: 0x0600A999 RID: 43417
		[global::System.Runtime.InteropServices.DispId(-2147417001)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		global::mshtml.IHTMLDOMAttribute removeAttributeNode([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLDOMAttribute pattr);

		// Token: 0x170036FB RID: 14075
		// (get) Token: 0x0600A99B RID: 43419
		// (set) Token: 0x0600A99A RID: 43418
		[global::System.Runtime.InteropServices.DispId(-2147412022)]
		object onbeforeactivate { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412022)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412022)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x170036FC RID: 14076
		// (get) Token: 0x0600A99D RID: 43421
		// (set) Token: 0x0600A99C RID: 43420
		[global::System.Runtime.InteropServices.DispId(-2147412021)]
		object onfocusin { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412021)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147412021)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x170036FD RID: 14077
		// (get) Token: 0x0600A99F RID: 43423
		// (set) Token: 0x0600A99E RID: 43422
		[global::System.Runtime.InteropServices.DispId(-2147412020)]
		object onfocusout { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412020)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412020)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x170036FE RID: 14078
		// (get) Token: 0x0600A9A0 RID: 43424
		[global::System.Runtime.InteropServices.DispId(-2147417058)]
		int uniqueNumber { [global::System.Runtime.InteropServices.TypeLibFunc(64)] [global::System.Runtime.InteropServices.DispId(-2147417058)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x170036FF RID: 14079
		// (get) Token: 0x0600A9A1 RID: 43425
		[global::System.Runtime.InteropServices.DispId(-2147417057)]
		string uniqueID { [global::System.Runtime.InteropServices.TypeLibFunc(64)] [global::System.Runtime.InteropServices.DispId(-2147417057)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x17003700 RID: 14080
		// (get) Token: 0x0600A9A2 RID: 43426
		[global::System.Runtime.InteropServices.DispId(-2147417066)]
		int nodeType { [global::System.Runtime.InteropServices.DispId(-2147417066)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x17003701 RID: 14081
		// (get) Token: 0x0600A9A3 RID: 43427
		[global::System.Runtime.InteropServices.DispId(-2147417065)]
		global::mshtml.IHTMLDOMNode parentNode { [global::System.Runtime.InteropServices.DispId(-2147417065)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x0600A9A4 RID: 43428
		[global::System.Runtime.InteropServices.DispId(-2147417064)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		bool hasChildNodes();

		// Token: 0x17003702 RID: 14082
		// (get) Token: 0x0600A9A5 RID: 43429
		[global::System.Runtime.InteropServices.DispId(-2147417063)]
		object childNodes { [global::System.Runtime.InteropServices.DispId(-2147417063)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] get; }

		// Token: 0x17003703 RID: 14083
		// (get) Token: 0x0600A9A6 RID: 43430
		[global::System.Runtime.InteropServices.DispId(-2147417062)]
		object attributes { [global::System.Runtime.InteropServices.DispId(-2147417062)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] get; }

		// Token: 0x0600A9A7 RID: 43431
		[global::System.Runtime.InteropServices.DispId(-2147417061)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		global::mshtml.IHTMLDOMNode insertBefore([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLDOMNode newChild, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] object refChild);

		// Token: 0x0600A9A8 RID: 43432
		[global::System.Runtime.InteropServices.DispId(-2147417060)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		global::mshtml.IHTMLDOMNode removeChild([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLDOMNode oldChild);

		// Token: 0x0600A9A9 RID: 43433
		[global::System.Runtime.InteropServices.DispId(-2147417059)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		global::mshtml.IHTMLDOMNode replaceChild([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLDOMNode newChild, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLDOMNode oldChild);

		// Token: 0x0600A9AA RID: 43434
		[global::System.Runtime.InteropServices.DispId(-2147417051)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		global::mshtml.IHTMLDOMNode cloneNode([global::System.Runtime.InteropServices.In] bool fDeep);

		// Token: 0x0600A9AB RID: 43435
		[global::System.Runtime.InteropServices.DispId(-2147417046)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		global::mshtml.IHTMLDOMNode removeNode([global::System.Runtime.InteropServices.In] bool fDeep = false);

		// Token: 0x0600A9AC RID: 43436
		[global::System.Runtime.InteropServices.DispId(-2147417044)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		global::mshtml.IHTMLDOMNode swapNode([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLDOMNode otherNode);

		// Token: 0x0600A9AD RID: 43437
		[global::System.Runtime.InteropServices.DispId(-2147417045)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		global::mshtml.IHTMLDOMNode replaceNode([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLDOMNode replacement);

		// Token: 0x0600A9AE RID: 43438
		[global::System.Runtime.InteropServices.DispId(-2147417039)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		global::mshtml.IHTMLDOMNode appendChild([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLDOMNode newChild);

		// Token: 0x17003704 RID: 14084
		// (get) Token: 0x0600A9AF RID: 43439
		[global::System.Runtime.InteropServices.DispId(-2147417038)]
		string nodeName { [global::System.Runtime.InteropServices.DispId(-2147417038)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x17003705 RID: 14085
		// (get) Token: 0x0600A9B1 RID: 43441
		// (set) Token: 0x0600A9B0 RID: 43440
		[global::System.Runtime.InteropServices.DispId(-2147417037)]
		object nodeValue { [global::System.Runtime.InteropServices.DispId(-2147417037)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147417037)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x17003706 RID: 14086
		// (get) Token: 0x0600A9B2 RID: 43442
		[global::System.Runtime.InteropServices.DispId(-2147417036)]
		global::mshtml.IHTMLDOMNode firstChild { [global::System.Runtime.InteropServices.DispId(-2147417036)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x17003707 RID: 14087
		// (get) Token: 0x0600A9B3 RID: 43443
		[global::System.Runtime.InteropServices.DispId(-2147417035)]
		global::mshtml.IHTMLDOMNode lastChild { [global::System.Runtime.InteropServices.DispId(-2147417035)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x17003708 RID: 14088
		// (get) Token: 0x0600A9B4 RID: 43444
		[global::System.Runtime.InteropServices.DispId(-2147417034)]
		global::mshtml.IHTMLDOMNode previousSibling { [global::System.Runtime.InteropServices.DispId(-2147417034)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x17003709 RID: 14089
		// (get) Token: 0x0600A9B5 RID: 43445
		[global::System.Runtime.InteropServices.DispId(-2147417033)]
		global::mshtml.IHTMLDOMNode nextSibling { [global::System.Runtime.InteropServices.DispId(-2147417033)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x1700370A RID: 14090
		// (get) Token: 0x0600A9B6 RID: 43446
		[global::System.Runtime.InteropServices.DispId(-2147416999)]
		object ownerDocument { [global::System.Runtime.InteropServices.DispId(-2147416999)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] get; }

		// Token: 0x1700370B RID: 14091
		// (get) Token: 0x0600A9B8 RID: 43448
		// (set) Token: 0x0600A9B7 RID: 43447
		[global::System.Runtime.InteropServices.DispId(-2147417091)]
		string dataFld { [global::System.Runtime.InteropServices.DispId(-2147417091)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(-2147417091)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] set; }

		// Token: 0x1700370C RID: 14092
		// (get) Token: 0x0600A9BA RID: 43450
		// (set) Token: 0x0600A9B9 RID: 43449
		[global::System.Runtime.InteropServices.DispId(-2147417090)]
		string dataSrc { [global::System.Runtime.InteropServices.DispId(-2147417090)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(-2147417090)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] set; }

		// Token: 0x1700370D RID: 14093
		// (get) Token: 0x0600A9BC RID: 43452
		// (set) Token: 0x0600A9BB RID: 43451
		[global::System.Runtime.InteropServices.DispId(-2147417089)]
		string dataFormatAs { [global::System.Runtime.InteropServices.DispId(-2147417089)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(-2147417089)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] set; }

		// Token: 0x1700370E RID: 14094
		// (get) Token: 0x0600A9BE RID: 43454
		// (set) Token: 0x0600A9BD RID: 43453
		[global::System.Runtime.InteropServices.DispId(-501)]
		object bgColor { [global::System.Runtime.InteropServices.DispId(-501)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-501)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x1700370F RID: 14095
		// (get) Token: 0x0600A9C0 RID: 43456
		// (set) Token: 0x0600A9BF RID: 43455
		[global::System.Runtime.InteropServices.DispId(6000)]
		int scrollDelay { [global::System.Runtime.InteropServices.DispId(6000)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(6000)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] set; }

		// Token: 0x17003710 RID: 14096
		// (get) Token: 0x0600A9C2 RID: 43458
		// (set) Token: 0x0600A9C1 RID: 43457
		[global::System.Runtime.InteropServices.DispId(6001)]
		string direction { [global::System.Runtime.InteropServices.DispId(6001)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(6001)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] set; }

		// Token: 0x17003711 RID: 14097
		// (get) Token: 0x0600A9C4 RID: 43460
		// (set) Token: 0x0600A9C3 RID: 43459
		[global::System.Runtime.InteropServices.DispId(6002)]
		string behavior { [global::System.Runtime.InteropServices.DispId(6002)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(6002)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] set; }

		// Token: 0x17003712 RID: 14098
		// (get) Token: 0x0600A9C6 RID: 43462
		// (set) Token: 0x0600A9C5 RID: 43461
		[global::System.Runtime.InteropServices.DispId(6003)]
		int scrollAmount { [global::System.Runtime.InteropServices.DispId(6003)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(6003)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] set; }

		// Token: 0x17003713 RID: 14099
		// (get) Token: 0x0600A9C8 RID: 43464
		// (set) Token: 0x0600A9C7 RID: 43463
		[global::System.Runtime.InteropServices.DispId(6004)]
		int loop { [global::System.Runtime.InteropServices.DispId(6004)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(6004)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] set; }

		// Token: 0x17003714 RID: 14100
		// (get) Token: 0x0600A9CA RID: 43466
		// (set) Token: 0x0600A9C9 RID: 43465
		[global::System.Runtime.InteropServices.DispId(6005)]
		int vspace { [global::System.Runtime.InteropServices.DispId(6005)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(6005)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] set; }

		// Token: 0x17003715 RID: 14101
		// (get) Token: 0x0600A9CC RID: 43468
		// (set) Token: 0x0600A9CB RID: 43467
		[global::System.Runtime.InteropServices.DispId(6006)]
		int hspace { [global::System.Runtime.InteropServices.DispId(6006)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(6006)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] set; }

		// Token: 0x17003716 RID: 14102
		// (get) Token: 0x0600A9CE RID: 43470
		// (set) Token: 0x0600A9CD RID: 43469
		[global::System.Runtime.InteropServices.DispId(-2147412086)]
		object onfinish { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412086)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147412086)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x17003717 RID: 14103
		// (get) Token: 0x0600A9D0 RID: 43472
		// (set) Token: 0x0600A9CF RID: 43471
		[global::System.Runtime.InteropServices.DispId(-2147412085)]
		object onstart { [global::System.Runtime.InteropServices.DispId(-2147412085)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147412085)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x17003718 RID: 14104
		// (get) Token: 0x0600A9D2 RID: 43474
		// (set) Token: 0x0600A9D1 RID: 43473
		[global::System.Runtime.InteropServices.DispId(-2147412092)]
		object onbounce { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412092)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412092)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x17003719 RID: 14105
		// (get) Token: 0x0600A9D4 RID: 43476
		// (set) Token: 0x0600A9D3 RID: 43475
		[global::System.Runtime.InteropServices.DispId(-2147418107)]
		object width { [global::System.Runtime.InteropServices.DispId(-2147418107)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147418107)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x1700371A RID: 14106
		// (get) Token: 0x0600A9D6 RID: 43478
		// (set) Token: 0x0600A9D5 RID: 43477
		[global::System.Runtime.InteropServices.DispId(-2147418106)]
		object height { [global::System.Runtime.InteropServices.DispId(-2147418106)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147418106)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x1700371B RID: 14107
		// (get) Token: 0x0600A9D8 RID: 43480
		// (set) Token: 0x0600A9D7 RID: 43479
		[global::System.Runtime.InteropServices.DispId(6007)]
		bool trueSpeed { [global::System.Runtime.InteropServices.DispId(6007)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(6007)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] set; }

		// Token: 0x0600A9D9 RID: 43481
		[global::System.Runtime.InteropServices.DispId(6010)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void Start();

		// Token: 0x0600A9DA RID: 43482
		[global::System.Runtime.InteropServices.DispId(6011)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void stop();
	}
}
