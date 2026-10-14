using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace mshtml
{
	// Token: 0x02000002 RID: 2
	[global::System.Runtime.InteropServices.Guid("3050F32D-98B5-11CF-BB82-00AA00BDCE0B")]
	[global::System.Runtime.InteropServices.TypeLibType(4160)]
	[global::System.Runtime.InteropServices.ComImport]
	public interface IHTMLEventObj
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000001 RID: 1
		[global::System.Runtime.InteropServices.DispId(1001)]
		global::mshtml.IHTMLElement srcElement { [global::System.Runtime.InteropServices.DispId(1001)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000002 RID: 2
		[global::System.Runtime.InteropServices.DispId(1002)]
		bool altKey { [global::System.Runtime.InteropServices.DispId(1002)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000003 RID: 3
		[global::System.Runtime.InteropServices.DispId(1003)]
		bool ctrlKey { [global::System.Runtime.InteropServices.DispId(1003)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000004 RID: 4
		[global::System.Runtime.InteropServices.DispId(1004)]
		bool shiftKey { [global::System.Runtime.InteropServices.DispId(1004)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000006 RID: 6
		// (set) Token: 0x06000005 RID: 5
		[global::System.Runtime.InteropServices.DispId(1007)]
		object returnValue { [global::System.Runtime.InteropServices.DispId(1007)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(1007)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000008 RID: 8
		// (set) Token: 0x06000007 RID: 7
		[global::System.Runtime.InteropServices.DispId(1008)]
		bool cancelBubble { [global::System.Runtime.InteropServices.DispId(1008)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(1008)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000009 RID: 9
		[global::System.Runtime.InteropServices.DispId(1009)]
		global::mshtml.IHTMLElement fromElement { [global::System.Runtime.InteropServices.DispId(1009)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600000A RID: 10
		[global::System.Runtime.InteropServices.DispId(1010)]
		global::mshtml.IHTMLElement toElement { [global::System.Runtime.InteropServices.DispId(1010)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600000C RID: 12
		// (set) Token: 0x0600000B RID: 11
		[global::System.Runtime.InteropServices.DispId(1011)]
		int keyCode { [global::System.Runtime.InteropServices.DispId(1011)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(1011)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600000D RID: 13
		[global::System.Runtime.InteropServices.DispId(1012)]
		int button { [global::System.Runtime.InteropServices.DispId(1012)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600000E RID: 14
		[global::System.Runtime.InteropServices.DispId(1013)]
		string type { [global::System.Runtime.InteropServices.DispId(1013)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600000F RID: 15
		[global::System.Runtime.InteropServices.DispId(1014)]
		string qualifier { [global::System.Runtime.InteropServices.DispId(1014)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000010 RID: 16
		[global::System.Runtime.InteropServices.DispId(1015)]
		int reason { [global::System.Runtime.InteropServices.DispId(1015)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000011 RID: 17
		[global::System.Runtime.InteropServices.DispId(1005)]
		int x { [global::System.Runtime.InteropServices.DispId(1005)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000012 RID: 18
		[global::System.Runtime.InteropServices.DispId(1006)]
		int y { [global::System.Runtime.InteropServices.DispId(1006)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000013 RID: 19
		[global::System.Runtime.InteropServices.DispId(1020)]
		int clientX { [global::System.Runtime.InteropServices.DispId(1020)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000014 RID: 20
		[global::System.Runtime.InteropServices.DispId(1021)]
		int clientY { [global::System.Runtime.InteropServices.DispId(1021)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000015 RID: 21
		[global::System.Runtime.InteropServices.DispId(1022)]
		int offsetX { [global::System.Runtime.InteropServices.DispId(1022)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000016 RID: 22
		[global::System.Runtime.InteropServices.DispId(1023)]
		int offsetY { [global::System.Runtime.InteropServices.DispId(1023)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000017 RID: 23
		[global::System.Runtime.InteropServices.DispId(1024)]
		int screenX { [global::System.Runtime.InteropServices.DispId(1024)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000018 RID: 24
		[global::System.Runtime.InteropServices.DispId(1025)]
		int screenY { [global::System.Runtime.InteropServices.DispId(1025)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000019 RID: 25
		[global::System.Runtime.InteropServices.DispId(1026)]
		object srcFilter { [global::System.Runtime.InteropServices.DispId(1026)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] get; }
	}
}
