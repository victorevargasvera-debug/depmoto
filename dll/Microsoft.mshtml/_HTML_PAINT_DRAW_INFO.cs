using System;
using System.Runtime.InteropServices;

namespace mshtml
{
	// Token: 0x02000CE4 RID: 3300
	[global::System.Runtime.InteropServices.ComConversionLoss]
	[global::System.Runtime.InteropServices.StructLayout(global::System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 4)]
	public struct _HTML_PAINT_DRAW_INFO
	{
		// Token: 0x04000428 RID: 1064
		public global::mshtml.tagRECT rcViewport;

		// Token: 0x04000429 RID: 1065
		[global::System.Runtime.InteropServices.ComConversionLoss]
		public global::System.IntPtr hrgnUpdate;

		// Token: 0x0400042A RID: 1066
		public global::mshtml._HTML_PAINT_XFORM xform;
	}
}
