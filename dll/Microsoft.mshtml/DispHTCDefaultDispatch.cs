using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace mshtml
{
	// Token: 0x020000A2 RID: 162
	[global::System.Runtime.InteropServices.TypeLibType(4112)]
	[global::System.Runtime.InteropServices.InterfaceType(2)]
	[global::System.Runtime.InteropServices.Guid("3050F573-98B5-11CF-BB82-00AA00BDCE0B")]
	[global::System.Runtime.InteropServices.ComImport]
	public interface DispHTCDefaultDispatch
	{
		// Token: 0x1700073A RID: 1850
		// (get) Token: 0x06000D7B RID: 3451
		[global::System.Runtime.InteropServices.DispId(-2147412969)]
		global::mshtml.IHTMLElement element { [global::System.Runtime.InteropServices.DispId(-2147412969)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x06000D7C RID: 3452
		[global::System.Runtime.InteropServices.DispId(-2147412968)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		global::mshtml.IHTMLEventObj CreateEventObject();

		// Token: 0x1700073B RID: 1851
		// (get) Token: 0x06000D7D RID: 3453
		[global::System.Runtime.InteropServices.DispId(-2147412947)]
		object defaults { [global::System.Runtime.InteropServices.DispId(-2147412947)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] get; }

		// Token: 0x1700073C RID: 1852
		// (get) Token: 0x06000D7E RID: 3454
		[global::System.Runtime.InteropServices.DispId(-2147412970)]
		object document { [global::System.Runtime.InteropServices.DispId(-2147412970)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] get; }
	}
}
