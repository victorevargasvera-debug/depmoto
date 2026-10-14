using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace mshtml
{
	// Token: 0x02000DB8 RID: 3512
	[global::System.Runtime.InteropServices.InterfaceType(1)]
	[global::System.Runtime.InteropServices.Guid("3050F6BA-98B5-11CF-BB82-00AA00BDCE0B")]
	[global::System.Runtime.InteropServices.ComImport]
	public interface IElementBehaviorLayout
	{
		// Token: 0x060174C4 RID: 95428
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void GetSize([global::System.Runtime.InteropServices.In] int dwFlags, [global::System.Runtime.InteropServices.In] global::mshtml.tagSIZE sizeContent, [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Out] ref global::mshtml.tagPOINT pptTranslateBy, [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Out] ref global::mshtml.tagPOINT pptTopLeft, [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Out] ref global::mshtml.tagSIZE psizeProposed);

		// Token: 0x060174C5 RID: 95429
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		int GetLayoutInfo();

		// Token: 0x060174C6 RID: 95430
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void GetPosition([global::System.Runtime.InteropServices.In] int lFlags, [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Out] ref global::mshtml.tagPOINT pptTopLeft);

		// Token: 0x060174C7 RID: 95431
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void MapSize([global::System.Runtime.InteropServices.In] ref global::mshtml.tagSIZE psizeIn, out global::mshtml.tagRECT prcOut);
	}
}
