using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SHDocVw
{
	// Token: 0x02000005 RID: 5
	[global::System.Runtime.InteropServices.Guid("0002DF05-0000-0000-C000-000000000046")]
	[global::System.Runtime.InteropServices.TypeLibType(4176)]
	[global::System.Reflection.DefaultMember("Name")]
	[global::System.Runtime.InteropServices.ComImport]
	public interface IWebBrowserApp : global::SHDocVw.IWebBrowser
	{
		// Token: 0x0600002B RID: 43
		[global::System.Runtime.InteropServices.DispId(100)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void GoBack();

		// Token: 0x0600002C RID: 44
		[global::System.Runtime.InteropServices.DispId(101)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void GoForward();

		// Token: 0x0600002D RID: 45
		[global::System.Runtime.InteropServices.DispId(102)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void GoHome();

		// Token: 0x0600002E RID: 46
		[global::System.Runtime.InteropServices.DispId(103)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void GoSearch();

		// Token: 0x0600002F RID: 47
		[global::System.Runtime.InteropServices.DispId(104)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void Navigate([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string URL, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object Flags, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object TargetFrameName, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object PostData, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object Headers);

		// Token: 0x06000030 RID: 48
		[global::System.Runtime.InteropServices.DispId(-550)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void Refresh();

		// Token: 0x06000031 RID: 49
		[global::System.Runtime.InteropServices.DispId(105)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void Refresh2([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object Level);

		// Token: 0x06000032 RID: 50
		[global::System.Runtime.InteropServices.DispId(106)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void Stop();

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000033 RID: 51
		[global::System.Runtime.InteropServices.DispId(200)]
		object Application { [global::System.Runtime.InteropServices.DispId(200)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] get; }

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000034 RID: 52
		[global::System.Runtime.InteropServices.DispId(201)]
		object Parent { [global::System.Runtime.InteropServices.DispId(201)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] get; }

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000035 RID: 53
		[global::System.Runtime.InteropServices.DispId(202)]
		object Container { [global::System.Runtime.InteropServices.DispId(202)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] get; }

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000036 RID: 54
		[global::System.Runtime.InteropServices.DispId(203)]
		object Document { [global::System.Runtime.InteropServices.DispId(203)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] get; }

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000037 RID: 55
		[global::System.Runtime.InteropServices.DispId(204)]
		bool TopLevelContainer { [global::System.Runtime.InteropServices.DispId(204)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000038 RID: 56
		[global::System.Runtime.InteropServices.DispId(205)]
		string Type { [global::System.Runtime.InteropServices.DispId(205)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000039 RID: 57
		// (set) Token: 0x0600003A RID: 58
		[global::System.Runtime.InteropServices.DispId(206)]
		int Left { [global::System.Runtime.InteropServices.DispId(206)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(206)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600003B RID: 59
		// (set) Token: 0x0600003C RID: 60
		[global::System.Runtime.InteropServices.DispId(207)]
		int Top { [global::System.Runtime.InteropServices.DispId(207)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(207)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600003D RID: 61
		// (set) Token: 0x0600003E RID: 62
		[global::System.Runtime.InteropServices.DispId(208)]
		int Width { [global::System.Runtime.InteropServices.DispId(208)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(208)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600003F RID: 63
		// (set) Token: 0x06000040 RID: 64
		[global::System.Runtime.InteropServices.DispId(209)]
		int Height { [global::System.Runtime.InteropServices.DispId(209)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(209)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000041 RID: 65
		[global::System.Runtime.InteropServices.DispId(210)]
		string LocationName { [global::System.Runtime.InteropServices.DispId(210)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000042 RID: 66
		[global::System.Runtime.InteropServices.DispId(211)]
		string LocationURL { [global::System.Runtime.InteropServices.DispId(211)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000043 RID: 67
		[global::System.Runtime.InteropServices.DispId(212)]
		bool Busy { [global::System.Runtime.InteropServices.DispId(212)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x06000044 RID: 68
		[global::System.Runtime.InteropServices.DispId(300)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void Quit();

		// Token: 0x06000045 RID: 69
		[global::System.Runtime.InteropServices.DispId(301)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void ClientToWindow([global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Out] ref int pcx, [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Out] ref int pcy);

		// Token: 0x06000046 RID: 70
		[global::System.Runtime.InteropServices.DispId(302)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void PutProperty([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string Property, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] object vtValue);

		// Token: 0x06000047 RID: 71
		[global::System.Runtime.InteropServices.DispId(303)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)]
		object GetProperty([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string Property);

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000048 RID: 72
		[global::System.Runtime.InteropServices.DispId(0)]
		[global::System.Runtime.CompilerServices.IndexerName("Name")]
		string Name { [global::System.Runtime.InteropServices.DispId(0)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000049 RID: 73
		[global::System.Runtime.InteropServices.DispId(-515)]
		int HWND { [global::System.Runtime.InteropServices.DispId(-515)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600004A RID: 74
		[global::System.Runtime.InteropServices.DispId(400)]
		string FullName { [global::System.Runtime.InteropServices.DispId(400)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600004B RID: 75
		[global::System.Runtime.InteropServices.DispId(401)]
		string Path { [global::System.Runtime.InteropServices.DispId(401)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600004C RID: 76
		// (set) Token: 0x0600004D RID: 77
		[global::System.Runtime.InteropServices.DispId(402)]
		bool Visible { [global::System.Runtime.InteropServices.DispId(402)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(402)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600004E RID: 78
		// (set) Token: 0x0600004F RID: 79
		[global::System.Runtime.InteropServices.DispId(403)]
		bool StatusBar { [global::System.Runtime.InteropServices.DispId(403)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(403)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000050 RID: 80
		// (set) Token: 0x06000051 RID: 81
		[global::System.Runtime.InteropServices.DispId(404)]
		string StatusText { [global::System.Runtime.InteropServices.DispId(404)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(404)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000052 RID: 82
		// (set) Token: 0x06000053 RID: 83
		[global::System.Runtime.InteropServices.DispId(405)]
		int ToolBar { [global::System.Runtime.InteropServices.DispId(405)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(405)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000054 RID: 84
		// (set) Token: 0x06000055 RID: 85
		[global::System.Runtime.InteropServices.DispId(406)]
		bool MenuBar { [global::System.Runtime.InteropServices.DispId(406)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(406)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000056 RID: 86
		// (set) Token: 0x06000057 RID: 87
		[global::System.Runtime.InteropServices.DispId(407)]
		bool FullScreen { [global::System.Runtime.InteropServices.DispId(407)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(407)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }
	}
}
