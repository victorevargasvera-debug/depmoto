using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace mshtml
{
	// Token: 0x02000BD2 RID: 3026
	[global::System.Runtime.InteropServices.Guid("3050F315-98B5-11CF-BB82-00AA00BDCE0B")]
	[global::System.Runtime.InteropServices.TypeLibType(4160)]
	[global::System.Runtime.InteropServices.ComImport]
	public interface IHTMLIFrameElement
	{
		// Token: 0x17006854 RID: 26708
		// (get) Token: 0x06013C83 RID: 81027
		// (set) Token: 0x06013C82 RID: 81026
		[global::System.Runtime.InteropServices.DispId(-2147414111)]
		int vspace { [global::System.Runtime.InteropServices.DispId(-2147414111)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(-2147414111)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17006855 RID: 26709
		// (get) Token: 0x06013C85 RID: 81029
		// (set) Token: 0x06013C84 RID: 81028
		[global::System.Runtime.InteropServices.DispId(-2147414110)]
		int hspace { [global::System.Runtime.InteropServices.DispId(-2147414110)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(-2147414110)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17006856 RID: 26710
		// (get) Token: 0x06013C87 RID: 81031
		// (set) Token: 0x06013C86 RID: 81030
		[global::System.Runtime.InteropServices.DispId(-2147418039)]
		string align { [global::System.Runtime.InteropServices.DispId(-2147418039)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(-2147418039)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }
	}
}
