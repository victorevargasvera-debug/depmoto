using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace mshtml
{
	// Token: 0x02000395 RID: 917
	[global::System.Runtime.InteropServices.Guid("3050F610-98B5-11CF-BB82-00AA00BDCE0B")]
	[global::System.Runtime.InteropServices.TypeLibType(4112)]
	[global::System.Runtime.InteropServices.InterfaceType(2)]
	[global::System.Runtime.InteropServices.ComImport]
	public interface HTMLAnchorEvents2
	{
		// Token: 0x06003A2A RID: 14890
		[global::System.Runtime.InteropServices.DispId(-2147418102)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		bool onhelp([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLEventObj pEvtObj);

		// Token: 0x06003A2B RID: 14891
		[global::System.Runtime.InteropServices.DispId(-600)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		bool onclick([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLEventObj pEvtObj);

		// Token: 0x06003A2C RID: 14892
		[global::System.Runtime.InteropServices.DispId(-601)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		bool ondblclick([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLEventObj pEvtObj);

		// Token: 0x06003A2D RID: 14893
		[global::System.Runtime.InteropServices.DispId(-603)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		bool onkeypress([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLEventObj pEvtObj);

		// Token: 0x06003A2E RID: 14894
		[global::System.Runtime.InteropServices.DispId(-602)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void onkeydown([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLEventObj pEvtObj);

		// Token: 0x06003A2F RID: 14895
		[global::System.Runtime.InteropServices.DispId(-604)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void onkeyup([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLEventObj pEvtObj);

		// Token: 0x06003A30 RID: 14896
		[global::System.Runtime.InteropServices.DispId(-2147418103)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void onmouseout([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLEventObj pEvtObj);

		// Token: 0x06003A31 RID: 14897
		[global::System.Runtime.InteropServices.DispId(-2147418104)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void onmouseover([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLEventObj pEvtObj);

		// Token: 0x06003A32 RID: 14898
		[global::System.Runtime.InteropServices.DispId(-606)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void onmousemove([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLEventObj pEvtObj);

		// Token: 0x06003A33 RID: 14899
		[global::System.Runtime.InteropServices.DispId(-605)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void onmousedown([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLEventObj pEvtObj);

		// Token: 0x06003A34 RID: 14900
		[global::System.Runtime.InteropServices.DispId(-607)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void onmouseup([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLEventObj pEvtObj);

		// Token: 0x06003A35 RID: 14901
		[global::System.Runtime.InteropServices.DispId(-2147418100)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		bool onselectstart([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLEventObj pEvtObj);

		// Token: 0x06003A36 RID: 14902
		[global::System.Runtime.InteropServices.DispId(-2147418095)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void onfilterchange([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLEventObj pEvtObj);

		// Token: 0x06003A37 RID: 14903
		[global::System.Runtime.InteropServices.DispId(-2147418101)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		bool ondragstart([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLEventObj pEvtObj);

		// Token: 0x06003A38 RID: 14904
		[global::System.Runtime.InteropServices.DispId(-2147418108)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		bool onbeforeupdate([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLEventObj pEvtObj);

		// Token: 0x06003A39 RID: 14905
		[global::System.Runtime.InteropServices.DispId(-2147418107)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void onafterupdate([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLEventObj pEvtObj);

		// Token: 0x06003A3A RID: 14906
		[global::System.Runtime.InteropServices.DispId(-2147418099)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		bool onerrorupdate([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLEventObj pEvtObj);

		// Token: 0x06003A3B RID: 14907
		[global::System.Runtime.InteropServices.DispId(-2147418106)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		bool onrowexit([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLEventObj pEvtObj);

		// Token: 0x06003A3C RID: 14908
		[global::System.Runtime.InteropServices.DispId(-2147418105)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void onrowenter([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLEventObj pEvtObj);

		// Token: 0x06003A3D RID: 14909
		[global::System.Runtime.InteropServices.DispId(-2147418098)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void ondatasetchanged([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLEventObj pEvtObj);

		// Token: 0x06003A3E RID: 14910
		[global::System.Runtime.InteropServices.DispId(-2147418097)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void ondataavailable([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLEventObj pEvtObj);

		// Token: 0x06003A3F RID: 14911
		[global::System.Runtime.InteropServices.DispId(-2147418096)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void ondatasetcomplete([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLEventObj pEvtObj);

		// Token: 0x06003A40 RID: 14912
		[global::System.Runtime.InteropServices.DispId(-2147418094)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void onlosecapture([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLEventObj pEvtObj);

		// Token: 0x06003A41 RID: 14913
		[global::System.Runtime.InteropServices.DispId(-2147418093)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void onpropertychange([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLEventObj pEvtObj);

		// Token: 0x06003A42 RID: 14914
		[global::System.Runtime.InteropServices.DispId(1014)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void onscroll([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLEventObj pEvtObj);

		// Token: 0x06003A43 RID: 14915
		[global::System.Runtime.InteropServices.DispId(-2147418111)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void onfocus([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLEventObj pEvtObj);

		// Token: 0x06003A44 RID: 14916
		[global::System.Runtime.InteropServices.DispId(-2147418112)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void onblur([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLEventObj pEvtObj);

		// Token: 0x06003A45 RID: 14917
		[global::System.Runtime.InteropServices.DispId(1016)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void onresize([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLEventObj pEvtObj);

		// Token: 0x06003A46 RID: 14918
		[global::System.Runtime.InteropServices.DispId(-2147418092)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		bool ondrag([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLEventObj pEvtObj);

		// Token: 0x06003A47 RID: 14919
		[global::System.Runtime.InteropServices.DispId(-2147418091)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void ondragend([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLEventObj pEvtObj);

		// Token: 0x06003A48 RID: 14920
		[global::System.Runtime.InteropServices.DispId(-2147418090)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		bool ondragenter([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLEventObj pEvtObj);

		// Token: 0x06003A49 RID: 14921
		[global::System.Runtime.InteropServices.DispId(-2147418089)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		bool ondragover([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLEventObj pEvtObj);

		// Token: 0x06003A4A RID: 14922
		[global::System.Runtime.InteropServices.DispId(-2147418088)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void ondragleave([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLEventObj pEvtObj);

		// Token: 0x06003A4B RID: 14923
		[global::System.Runtime.InteropServices.DispId(-2147418087)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		bool ondrop([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLEventObj pEvtObj);

		// Token: 0x06003A4C RID: 14924
		[global::System.Runtime.InteropServices.DispId(-2147418083)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		bool onbeforecut([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLEventObj pEvtObj);

		// Token: 0x06003A4D RID: 14925
		[global::System.Runtime.InteropServices.DispId(-2147418086)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		bool oncut([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLEventObj pEvtObj);

		// Token: 0x06003A4E RID: 14926
		[global::System.Runtime.InteropServices.DispId(-2147418082)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		bool onbeforecopy([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLEventObj pEvtObj);

		// Token: 0x06003A4F RID: 14927
		[global::System.Runtime.InteropServices.DispId(-2147418085)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		bool oncopy([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLEventObj pEvtObj);

		// Token: 0x06003A50 RID: 14928
		[global::System.Runtime.InteropServices.DispId(-2147418081)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		bool onbeforepaste([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLEventObj pEvtObj);

		// Token: 0x06003A51 RID: 14929
		[global::System.Runtime.InteropServices.DispId(-2147418084)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		bool onpaste([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLEventObj pEvtObj);

		// Token: 0x06003A52 RID: 14930
		[global::System.Runtime.InteropServices.DispId(1023)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		bool oncontextmenu([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLEventObj pEvtObj);

		// Token: 0x06003A53 RID: 14931
		[global::System.Runtime.InteropServices.DispId(-2147418080)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void onrowsdelete([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLEventObj pEvtObj);

		// Token: 0x06003A54 RID: 14932
		[global::System.Runtime.InteropServices.DispId(-2147418079)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void onrowsinserted([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLEventObj pEvtObj);

		// Token: 0x06003A55 RID: 14933
		[global::System.Runtime.InteropServices.DispId(-2147418078)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void oncellchange([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLEventObj pEvtObj);

		// Token: 0x06003A56 RID: 14934
		[global::System.Runtime.InteropServices.DispId(-609)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void onreadystatechange([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLEventObj pEvtObj);

		// Token: 0x06003A57 RID: 14935
		[global::System.Runtime.InteropServices.DispId(1030)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void onlayoutcomplete([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLEventObj pEvtObj);

		// Token: 0x06003A58 RID: 14936
		[global::System.Runtime.InteropServices.DispId(1031)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void onpage([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLEventObj pEvtObj);

		// Token: 0x06003A59 RID: 14937
		[global::System.Runtime.InteropServices.DispId(1042)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void onmouseenter([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLEventObj pEvtObj);

		// Token: 0x06003A5A RID: 14938
		[global::System.Runtime.InteropServices.DispId(1043)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void onmouseleave([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLEventObj pEvtObj);

		// Token: 0x06003A5B RID: 14939
		[global::System.Runtime.InteropServices.DispId(1044)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void onactivate([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLEventObj pEvtObj);

		// Token: 0x06003A5C RID: 14940
		[global::System.Runtime.InteropServices.DispId(1045)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void ondeactivate([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLEventObj pEvtObj);

		// Token: 0x06003A5D RID: 14941
		[global::System.Runtime.InteropServices.DispId(1034)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		bool onbeforedeactivate([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLEventObj pEvtObj);

		// Token: 0x06003A5E RID: 14942
		[global::System.Runtime.InteropServices.DispId(1047)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		bool onbeforeactivate([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLEventObj pEvtObj);

		// Token: 0x06003A5F RID: 14943
		[global::System.Runtime.InteropServices.DispId(1048)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void onfocusin([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLEventObj pEvtObj);

		// Token: 0x06003A60 RID: 14944
		[global::System.Runtime.InteropServices.DispId(1049)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void onfocusout([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLEventObj pEvtObj);

		// Token: 0x06003A61 RID: 14945
		[global::System.Runtime.InteropServices.DispId(1035)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void onmove([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLEventObj pEvtObj);

		// Token: 0x06003A62 RID: 14946
		[global::System.Runtime.InteropServices.DispId(1036)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		bool oncontrolselect([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLEventObj pEvtObj);

		// Token: 0x06003A63 RID: 14947
		[global::System.Runtime.InteropServices.DispId(1038)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		bool onmovestart([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLEventObj pEvtObj);

		// Token: 0x06003A64 RID: 14948
		[global::System.Runtime.InteropServices.DispId(1039)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void onmoveend([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLEventObj pEvtObj);

		// Token: 0x06003A65 RID: 14949
		[global::System.Runtime.InteropServices.DispId(1040)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		bool onresizestart([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLEventObj pEvtObj);

		// Token: 0x06003A66 RID: 14950
		[global::System.Runtime.InteropServices.DispId(1041)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void onresizeend([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLEventObj pEvtObj);

		// Token: 0x06003A67 RID: 14951
		[global::System.Runtime.InteropServices.DispId(1033)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		bool onmousewheel([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLEventObj pEvtObj);
	}
}
