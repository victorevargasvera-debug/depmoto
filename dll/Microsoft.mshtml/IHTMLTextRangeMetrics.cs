using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace mshtml
{
	// Token: 0x020001DD RID: 477
	[global::System.Runtime.InteropServices.TypeLibType(4160)]
	[global::System.Runtime.InteropServices.Guid("3050F40B-98B5-11CF-BB82-00AA00BDCE0B")]
	[global::System.Runtime.InteropServices.ComImport]
	public interface IHTMLTextRangeMetrics
	{
		// Token: 0x17000AD0 RID: 2768
		// (get) Token: 0x06001B48 RID: 6984
		[global::System.Runtime.InteropServices.DispId(1035)]
		int offsetTop { [global::System.Runtime.InteropServices.DispId(1035)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000AD1 RID: 2769
		// (get) Token: 0x06001B49 RID: 6985
		[global::System.Runtime.InteropServices.DispId(1036)]
		int offsetLeft { [global::System.Runtime.InteropServices.DispId(1036)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000AD2 RID: 2770
		// (get) Token: 0x06001B4A RID: 6986
		[global::System.Runtime.InteropServices.DispId(1037)]
		int boundingTop { [global::System.Runtime.InteropServices.DispId(1037)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000AD3 RID: 2771
		// (get) Token: 0x06001B4B RID: 6987
		[global::System.Runtime.InteropServices.DispId(1038)]
		int boundingLeft { [global::System.Runtime.InteropServices.DispId(1038)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000AD4 RID: 2772
		// (get) Token: 0x06001B4C RID: 6988
		[global::System.Runtime.InteropServices.DispId(1039)]
		int boundingWidth { [global::System.Runtime.InteropServices.DispId(1039)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000AD5 RID: 2773
		// (get) Token: 0x06001B4D RID: 6989
		[global::System.Runtime.InteropServices.DispId(1040)]
		int boundingHeight { [global::System.Runtime.InteropServices.DispId(1040)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }
	}
}
