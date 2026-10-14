using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SHDocVw
{
	// Token: 0x02000002 RID: 2
	[global::System.Runtime.InteropServices.TypeLibType(4176)]
	[global::System.Runtime.InteropServices.Guid("EAB22AC1-30C1-11CF-A7EB-0000C05BAE0B")]
	[global::System.Runtime.InteropServices.ComImport]
	public interface IWebBrowser
	{
		// Token: 0x06000001 RID: 1
		[global::System.Runtime.InteropServices.DispId(100)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void GoBack();

		// Token: 0x06000002 RID: 2
		[global::System.Runtime.InteropServices.DispId(101)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void GoForward();

		// Token: 0x06000003 RID: 3
		[global::System.Runtime.InteropServices.DispId(102)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void GoHome();

		// Token: 0x06000004 RID: 4
		[global::System.Runtime.InteropServices.DispId(103)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void GoSearch();

		// Token: 0x06000005 RID: 5
		[global::System.Runtime.InteropServices.DispId(104)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void Navigate([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string URL, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object Flags, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object TargetFrameName, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object PostData, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object Headers);

		// Token: 0x06000006 RID: 6
		[global::System.Runtime.InteropServices.DispId(-550)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void Refresh();

		// Token: 0x06000007 RID: 7
		[global::System.Runtime.InteropServices.DispId(105)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void Refresh2([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object Level);

		// Token: 0x06000008 RID: 8
		[global::System.Runtime.InteropServices.DispId(106)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void Stop();

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000009 RID: 9
		[global::System.Runtime.InteropServices.DispId(200)]
		object Application { [global::System.Runtime.InteropServices.DispId(200)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] get; }

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600000A RID: 10
		[global::System.Runtime.InteropServices.DispId(201)]
		object Parent { [global::System.Runtime.InteropServices.DispId(201)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] get; }

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600000B RID: 11
		[global::System.Runtime.InteropServices.DispId(202)]
		object Container { [global::System.Runtime.InteropServices.DispId(202)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] get; }

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600000C RID: 12
		[global::System.Runtime.InteropServices.DispId(203)]
		object Document { [global::System.Runtime.InteropServices.DispId(203)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] get; }

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600000D RID: 13
		[global::System.Runtime.InteropServices.DispId(204)]
		bool TopLevelContainer { [global::System.Runtime.InteropServices.DispId(204)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600000E RID: 14
		[global::System.Runtime.InteropServices.DispId(205)]
		string Type { [global::System.Runtime.InteropServices.DispId(205)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600000F RID: 15
		// (set) Token: 0x06000010 RID: 16
		[global::System.Runtime.InteropServices.DispId(206)]
		int Left { [global::System.Runtime.InteropServices.DispId(206)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(206)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000011 RID: 17
		// (set) Token: 0x06000012 RID: 18
		[global::System.Runtime.InteropServices.DispId(207)]
		int Top { [global::System.Runtime.InteropServices.DispId(207)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(207)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000013 RID: 19
		// (set) Token: 0x06000014 RID: 20
		[global::System.Runtime.InteropServices.DispId(208)]
		int Width { [global::System.Runtime.InteropServices.DispId(208)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(208)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000015 RID: 21
		// (set) Token: 0x06000016 RID: 22
		[global::System.Runtime.InteropServices.DispId(209)]
		int Height { [global::System.Runtime.InteropServices.DispId(209)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(209)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000017 RID: 23
		[global::System.Runtime.InteropServices.DispId(210)]
		string LocationName { [global::System.Runtime.InteropServices.DispId(210)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000018 RID: 24
		[global::System.Runtime.InteropServices.DispId(211)]
		string LocationURL { [global::System.Runtime.InteropServices.DispId(211)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000019 RID: 25
		[global::System.Runtime.InteropServices.DispId(212)]
		bool Busy { [global::System.Runtime.InteropServices.DispId(212)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }
	}
}
