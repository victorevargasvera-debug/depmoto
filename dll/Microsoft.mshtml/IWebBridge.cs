using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace mshtml
{
	// Token: 0x02000837 RID: 2103
	[global::System.Runtime.InteropServices.Guid("AE24FDAD-03C6-11D1-8B76-0080C744F389")]
	[global::System.Runtime.InteropServices.TypeLibType(4160)]
	[global::System.Runtime.InteropServices.ComImport]
	public interface IWebBridge
	{
		// Token: 0x17004A04 RID: 18948
		// (get) Token: 0x0600DEE6 RID: 57062
		// (set) Token: 0x0600DEE5 RID: 57061
		[global::System.Runtime.InteropServices.DispId(1)]
		string url { [global::System.Runtime.InteropServices.DispId(1)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(1)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17004A05 RID: 18949
		// (get) Token: 0x0600DEE8 RID: 57064
		// (set) Token: 0x0600DEE7 RID: 57063
		[global::System.Runtime.InteropServices.DispId(2)]
		bool Scrollbar { [global::System.Runtime.InteropServices.DispId(2)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(2)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17004A06 RID: 18950
		// (get) Token: 0x0600DEEA RID: 57066
		// (set) Token: 0x0600DEE9 RID: 57065
		[global::System.Runtime.InteropServices.DispId(3)]
		bool embed { [global::System.Runtime.InteropServices.DispId(3)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(3)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17004A07 RID: 18951
		// (get) Token: 0x0600DEEB RID: 57067
		[global::System.Runtime.InteropServices.DispId(1152)]
		object @event { [global::System.Runtime.InteropServices.DispId(1152)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] get; }

		// Token: 0x17004A08 RID: 18952
		// (get) Token: 0x0600DEEC RID: 57068
		[global::System.Runtime.InteropServices.DispId(-525)]
		int readyState { [global::System.Runtime.InteropServices.DispId(-525)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x0600DEED RID: 57069
		[global::System.Runtime.InteropServices.DispId(-552)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void AboutBox();
	}
}
