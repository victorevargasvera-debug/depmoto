using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace mshtml
{
	// Token: 0x02000097 RID: 151
	[global::System.Runtime.InteropServices.Guid("3050F6C9-98B5-11CF-BB82-00AA00BDCE0B")]
	[global::System.Runtime.InteropServices.TypeLibType(4160)]
	[global::System.Runtime.InteropServices.ComImport]
	public interface IHTMLElementDefaults
	{
		// Token: 0x17000708 RID: 1800
		// (get) Token: 0x06000D19 RID: 3353
		[global::System.Runtime.InteropServices.DispId(1001)]
		global::mshtml.IHTMLStyle style { [global::System.Runtime.InteropServices.TypeLibFunc(1024)] [global::System.Runtime.InteropServices.DispId(1001)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x17000709 RID: 1801
		// (get) Token: 0x06000D1B RID: 3355
		// (set) Token: 0x06000D1A RID: 3354
		[global::System.Runtime.InteropServices.DispId(1002)]
		bool tabStop { [global::System.Runtime.InteropServices.DispId(1002)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(1002)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700070A RID: 1802
		// (get) Token: 0x06000D1D RID: 3357
		// (set) Token: 0x06000D1C RID: 3356
		[global::System.Runtime.InteropServices.DispId(-2147412913)]
		bool viewInheritStyle { [global::System.Runtime.InteropServices.DispId(-2147412913)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(-2147412913)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700070B RID: 1803
		// (get) Token: 0x06000D1F RID: 3359
		// (set) Token: 0x06000D1E RID: 3358
		[global::System.Runtime.InteropServices.DispId(1006)]
		bool viewMasterTab { [global::System.Runtime.InteropServices.DispId(1006)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(1006)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700070C RID: 1804
		// (get) Token: 0x06000D21 RID: 3361
		// (set) Token: 0x06000D20 RID: 3360
		[global::System.Runtime.InteropServices.DispId(1003)]
		int scrollSegmentX { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(1003)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(1003)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700070D RID: 1805
		// (get) Token: 0x06000D23 RID: 3363
		// (set) Token: 0x06000D22 RID: 3362
		[global::System.Runtime.InteropServices.DispId(1004)]
		int scrollSegmentY { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(1004)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(1004)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700070E RID: 1806
		// (get) Token: 0x06000D25 RID: 3365
		// (set) Token: 0x06000D24 RID: 3364
		[global::System.Runtime.InteropServices.DispId(1008)]
		bool isMultiLine { [global::System.Runtime.InteropServices.DispId(1008)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(1008)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700070F RID: 1807
		// (get) Token: 0x06000D27 RID: 3367
		// (set) Token: 0x06000D26 RID: 3366
		[global::System.Runtime.InteropServices.DispId(-2147412950)]
		string contentEditable { [global::System.Runtime.InteropServices.DispId(-2147412950)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(-2147412950)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000710 RID: 1808
		// (get) Token: 0x06000D29 RID: 3369
		// (set) Token: 0x06000D28 RID: 3368
		[global::System.Runtime.InteropServices.DispId(1009)]
		bool canHaveHTML { [global::System.Runtime.InteropServices.DispId(1009)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(1009)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000711 RID: 1809
		// (get) Token: 0x06000D2B RID: 3371
		// (set) Token: 0x06000D2A RID: 3370
		[global::System.Runtime.InteropServices.DispId(1011)]
		global::mshtml.IHTMLDocument viewLink { [global::System.Runtime.InteropServices.DispId(1011)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; [global::System.Runtime.InteropServices.DispId(1011)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000712 RID: 1810
		// (get) Token: 0x06000D2D RID: 3373
		// (set) Token: 0x06000D2C RID: 3372
		[global::System.Runtime.InteropServices.DispId(-2147412914)]
		bool frozen { [global::System.Runtime.InteropServices.DispId(-2147412914)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(-2147412914)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }
	}
}
