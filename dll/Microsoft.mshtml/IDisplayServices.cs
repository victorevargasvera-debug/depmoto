using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace mshtml
{
	// Token: 0x02000CB5 RID: 3253
	[global::System.Runtime.InteropServices.InterfaceType(1)]
	[global::System.Runtime.InteropServices.Guid("3050F69D-98B5-11CF-BB82-00AA00BDCE0B")]
	[global::System.Runtime.InteropServices.ComImport]
	public interface IDisplayServices
	{
		// Token: 0x0601628F RID: 90767
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void CreateDisplayPointer([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] out global::mshtml.IDisplayPointer ppDispPointer);

		// Token: 0x06016290 RID: 90768
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void TransformRect([global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Out] ref global::mshtml.tagRECT pRect, [global::System.Runtime.InteropServices.In] global::mshtml._COORD_SYSTEM eSource, [global::System.Runtime.InteropServices.In] global::mshtml._COORD_SYSTEM eDestination, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLElement pIElement);

		// Token: 0x06016291 RID: 90769
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void TransformPoint([global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Out] ref global::mshtml.tagPOINT pPoint, [global::System.Runtime.InteropServices.In] global::mshtml._COORD_SYSTEM eSource, [global::System.Runtime.InteropServices.In] global::mshtml._COORD_SYSTEM eDestination, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLElement pIElement);

		// Token: 0x06016292 RID: 90770
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void GetCaret([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] out global::mshtml.IHTMLCaret ppCaret);

		// Token: 0x06016293 RID: 90771
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void GetComputedStyle([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IMarkupPointer pPointer, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] out global::mshtml.IHTMLComputedStyle ppComputedStyle);

		// Token: 0x06016294 RID: 90772
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void ScrollRectIntoView([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLElement pIElement, [global::System.Runtime.InteropServices.In] global::mshtml.tagRECT rect);

		// Token: 0x06016295 RID: 90773
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void HasFlowLayout([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLElement pIElement, out int pfHasFlowLayout);
	}
}
