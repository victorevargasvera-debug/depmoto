using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace mshtml
{
	// Token: 0x02000CE9 RID: 3305
	[global::System.Runtime.InteropServices.Guid("3050F7E3-98B5-11CF-BB82-00AA00BDCE0B")]
	[global::System.Runtime.InteropServices.InterfaceType(1)]
	[global::System.Runtime.InteropServices.ComImport]
	public interface IHTMLPainterOverlay
	{
		// Token: 0x06016364 RID: 90980
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void onmove([global::System.Runtime.InteropServices.In] global::mshtml.tagRECT rcDevice);
	}
}
