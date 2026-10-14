using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace mshtml
{
	// Token: 0x02000CE7 RID: 3303
	[global::System.Runtime.InteropServices.ComConversionLoss]
	[global::System.Runtime.InteropServices.Guid("3050F6A7-98B5-11CF-BB82-00AA00BDCE0B")]
	[global::System.Runtime.InteropServices.InterfaceType(1)]
	[global::System.Runtime.InteropServices.ComImport]
	public interface IHTMLPaintSite
	{
		// Token: 0x06016359 RID: 90969
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void InvalidatePainterInfo();

		// Token: 0x0601635A RID: 90970
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void InvalidateRect([global::System.Runtime.InteropServices.In] ref global::mshtml.tagRECT prcInvalid);

		// Token: 0x0601635B RID: 90971
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void InvalidateRegion([global::System.Runtime.InteropServices.In] global::System.IntPtr rgnInvalid);

		// Token: 0x0601635C RID: 90972
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void GetDrawInfo([global::System.Runtime.InteropServices.In] int lFlags, out global::mshtml._HTML_PAINT_DRAW_INFO pDrawInfo);

		// Token: 0x0601635D RID: 90973
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void TransformGlobalToLocal([global::System.Runtime.InteropServices.In] global::mshtml.tagPOINT ptGlobal, out global::mshtml.tagPOINT pptLocal);

		// Token: 0x0601635E RID: 90974
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void TransformLocalToGlobal([global::System.Runtime.InteropServices.In] global::mshtml.tagPOINT ptLocal, out global::mshtml.tagPOINT pptGlobal);

		// Token: 0x0601635F RID: 90975
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void GetHitTestCookie(out int plCookie);
	}
}
