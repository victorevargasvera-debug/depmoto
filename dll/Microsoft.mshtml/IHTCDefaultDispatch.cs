using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace mshtml
{
	// Token: 0x0200009B RID: 155
	[global::System.Runtime.InteropServices.Guid("3050F4FD-98B5-11CF-BB82-00AA00BDCE0B")]
	[global::System.Runtime.InteropServices.TypeLibType(4160)]
	[global::System.Runtime.InteropServices.ComImport]
	public interface IHTCDefaultDispatch
	{
		// Token: 0x17000734 RID: 1844
		// (get) Token: 0x06000D6E RID: 3438
		[global::System.Runtime.InteropServices.DispId(-2147412969)]
		global::mshtml.IHTMLElement element { [global::System.Runtime.InteropServices.DispId(-2147412969)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x06000D6F RID: 3439
		[global::System.Runtime.InteropServices.DispId(-2147412968)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		global::mshtml.IHTMLEventObj CreateEventObject();

		// Token: 0x17000735 RID: 1845
		// (get) Token: 0x06000D70 RID: 3440
		[global::System.Runtime.InteropServices.DispId(-2147412947)]
		object defaults { [global::System.Runtime.InteropServices.DispId(-2147412947)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] get; }

		// Token: 0x17000736 RID: 1846
		// (get) Token: 0x06000D71 RID: 3441
		[global::System.Runtime.InteropServices.DispId(-2147412970)]
		object document { [global::System.Runtime.InteropServices.DispId(-2147412970)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] get; }
	}
}
