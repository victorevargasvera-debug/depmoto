using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace mshtml
{
	// Token: 0x02000CE5 RID: 3301
	[global::System.Runtime.InteropServices.ComConversionLoss]
	[global::System.Runtime.InteropServices.Guid("3050F6A6-98B5-11CF-BB82-00AA00BDCE0B")]
	[global::System.Runtime.InteropServices.InterfaceType(1)]
	[global::System.Runtime.InteropServices.ComImport]
	public interface IHTMLPainter
	{
		// Token: 0x06016355 RID: 90965
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void Draw([global::System.Runtime.InteropServices.In] global::mshtml.tagRECT rcBounds, [global::System.Runtime.InteropServices.In] global::mshtml.tagRECT rcUpdate, [global::System.Runtime.InteropServices.In] int lDrawFlags, [global::System.Runtime.InteropServices.ComAliasName("mshtml.wireHDC")] [global::System.Runtime.InteropServices.In] ref global::mshtml._RemotableHandle hdc, [global::System.Runtime.InteropServices.In] global::System.IntPtr pvDrawObject);

		// Token: 0x06016356 RID: 90966
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void onresize([global::System.Runtime.InteropServices.In] global::mshtml.tagSIZE size);

		// Token: 0x06016357 RID: 90967
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void GetPainterInfo(out global::mshtml._HTML_PAINTER_INFO pInfo);

		// Token: 0x06016358 RID: 90968
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void HitTestPoint([global::System.Runtime.InteropServices.In] global::mshtml.tagPOINT pt, out int pbHit, out int plPartID);
	}
}
