using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace mshtml
{
	// Token: 0x020004A6 RID: 1190
	[global::System.Runtime.InteropServices.TypeLibType(4160)]
	[global::System.Runtime.InteropServices.Guid("3050F1DD-98B5-11CF-BB82-00AA00BDCE0B")]
	[global::System.Runtime.InteropServices.ComImport]
	public interface IHTMLUListElement
	{
		// Token: 0x17001896 RID: 6294
		// (get) Token: 0x06004C2B RID: 19499
		// (set) Token: 0x06004C2A RID: 19498
		[global::System.Runtime.InteropServices.DispId(1001)]
		bool compact { [global::System.Runtime.InteropServices.DispId(1001)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(1001)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17001897 RID: 6295
		// (get) Token: 0x06004C2D RID: 19501
		// (set) Token: 0x06004C2C RID: 19500
		[global::System.Runtime.InteropServices.DispId(-2147413095)]
		string type { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147413095)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(-2147413095)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }
	}
}
