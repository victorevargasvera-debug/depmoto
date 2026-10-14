using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace mshtml
{
	// Token: 0x02000CCB RID: 3275
	[global::System.Runtime.InteropServices.Guid("3050F662-98B5-11CF-BB82-00AA00BDCE0B")]
	[global::System.Runtime.InteropServices.InterfaceType(1)]
	[global::System.Runtime.InteropServices.ComImport]
	public interface IHTMLEditDesigner
	{
		// Token: 0x06016313 RID: 90899
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void PreHandleEvent([global::System.Runtime.InteropServices.In] int inEvtDispId, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLEventObj pIEventObj);

		// Token: 0x06016314 RID: 90900
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void PostHandleEvent([global::System.Runtime.InteropServices.In] int inEvtDispId, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLEventObj pIEventObj);

		// Token: 0x06016315 RID: 90901
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void TranslateAccelerator([global::System.Runtime.InteropServices.In] int inEvtDispId, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLEventObj pIEventObj);

		// Token: 0x06016316 RID: 90902
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void PostEditorEventNotify([global::System.Runtime.InteropServices.In] int inEvtDispId, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLEventObj pIEventObj);
	}
}
