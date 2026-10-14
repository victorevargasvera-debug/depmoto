using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace mshtml
{
	// Token: 0x020009FF RID: 2559
	[global::System.Runtime.InteropServices.Guid("3050F413-98B5-11CF-BB82-00AA00BDCE0B")]
	[global::System.Runtime.InteropServices.TypeLibType(4160)]
	[global::System.Runtime.InteropServices.ComImport]
	public interface IHTMLTableRowMetrics
	{
		// Token: 0x17005588 RID: 21896
		// (get) Token: 0x060103EF RID: 66543
		[global::System.Runtime.InteropServices.DispId(-2147416093)]
		int clientHeight { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147416093)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x17005589 RID: 21897
		// (get) Token: 0x060103F0 RID: 66544
		[global::System.Runtime.InteropServices.DispId(-2147416092)]
		int clientWidth { [global::System.Runtime.InteropServices.DispId(-2147416092)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700558A RID: 21898
		// (get) Token: 0x060103F1 RID: 66545
		[global::System.Runtime.InteropServices.DispId(-2147416091)]
		int clientTop { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147416091)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700558B RID: 21899
		// (get) Token: 0x060103F2 RID: 66546
		[global::System.Runtime.InteropServices.DispId(-2147416090)]
		int clientLeft { [global::System.Runtime.InteropServices.DispId(-2147416090)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }
	}
}
