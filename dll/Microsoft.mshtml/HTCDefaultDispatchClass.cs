using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace mshtml
{
	// Token: 0x020000A3 RID: 163
	[global::System.Runtime.InteropServices.TypeLibType(2)]
	[global::System.Runtime.InteropServices.ClassInterface(0)]
	[global::System.Runtime.InteropServices.Guid("3050F4FC-98B5-11CF-BB82-00AA00BDCE0B")]
	[global::System.Runtime.InteropServices.ComImport]
	public class HTCDefaultDispatchClass : global::mshtml.DispHTCDefaultDispatch, global::mshtml.HTCDefaultDispatch, global::mshtml.IHTCDefaultDispatch
	{
		// Token: 0x06000D7F RID: 3455
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public extern HTCDefaultDispatchClass();

		// Token: 0x1700073D RID: 1853
		// (get) Token: 0x06000D80 RID: 3456
		[global::System.Runtime.InteropServices.DispId(-2147412969)]
		public virtual extern global::mshtml.IHTMLElement element { [global::System.Runtime.InteropServices.DispId(-2147412969)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x06000D81 RID: 3457
		[global::System.Runtime.InteropServices.DispId(-2147412968)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		public virtual extern global::mshtml.IHTMLEventObj CreateEventObject();

		// Token: 0x1700073E RID: 1854
		// (get) Token: 0x06000D82 RID: 3458
		[global::System.Runtime.InteropServices.DispId(-2147412947)]
		public virtual extern object defaults { [global::System.Runtime.InteropServices.DispId(-2147412947)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] get; }

		// Token: 0x1700073F RID: 1855
		// (get) Token: 0x06000D83 RID: 3459
		[global::System.Runtime.InteropServices.DispId(-2147412970)]
		public virtual extern object document { [global::System.Runtime.InteropServices.DispId(-2147412970)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] get; }

		// Token: 0x17000740 RID: 1856
		// (get) Token: 0x06000D84 RID: 3460
		public virtual extern global::mshtml.IHTMLElement IHTCDefaultDispatch_element { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x06000D85 RID: 3461
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		public virtual extern global::mshtml.IHTMLEventObj IHTCDefaultDispatch_CreateEventObject();

		// Token: 0x17000741 RID: 1857
		// (get) Token: 0x06000D86 RID: 3462
		public virtual extern object IHTCDefaultDispatch_defaults { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] get; }

		// Token: 0x17000742 RID: 1858
		// (get) Token: 0x06000D87 RID: 3463
		public virtual extern object IHTCDefaultDispatch_document { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] get; }
	}
}
