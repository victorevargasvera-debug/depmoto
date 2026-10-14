using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SHDocVw
{
	// Token: 0x02000006 RID: 6
	[global::System.Runtime.InteropServices.Guid("D30C1661-CDAF-11D0-8A3E-00C04FC9E26E")]
	[global::System.Runtime.InteropServices.TypeLibType(4176)]
	[global::System.Reflection.DefaultMember("Name")]
	[global::System.Runtime.InteropServices.ComImport]
	public interface IWebBrowser2 : global::SHDocVw.IWebBrowserApp
	{
		// Token: 0x06000058 RID: 88
		[global::System.Runtime.InteropServices.DispId(100)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void GoBack();

		// Token: 0x06000059 RID: 89
		[global::System.Runtime.InteropServices.DispId(101)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void GoForward();

		// Token: 0x0600005A RID: 90
		[global::System.Runtime.InteropServices.DispId(102)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void GoHome();

		// Token: 0x0600005B RID: 91
		[global::System.Runtime.InteropServices.DispId(103)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void GoSearch();

		// Token: 0x0600005C RID: 92
		[global::System.Runtime.InteropServices.DispId(104)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void Navigate([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string URL, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object Flags, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object TargetFrameName, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object PostData, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object Headers);

		// Token: 0x0600005D RID: 93
		[global::System.Runtime.InteropServices.DispId(-550)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void Refresh();

		// Token: 0x0600005E RID: 94
		[global::System.Runtime.InteropServices.DispId(105)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void Refresh2([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object Level);

		// Token: 0x0600005F RID: 95
		[global::System.Runtime.InteropServices.DispId(106)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void Stop();

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000060 RID: 96
		[global::System.Runtime.InteropServices.DispId(200)]
		object Application { [global::System.Runtime.InteropServices.DispId(200)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] get; }

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000061 RID: 97
		[global::System.Runtime.InteropServices.DispId(201)]
		object Parent { [global::System.Runtime.InteropServices.DispId(201)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] get; }

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000062 RID: 98
		[global::System.Runtime.InteropServices.DispId(202)]
		object Container { [global::System.Runtime.InteropServices.DispId(202)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] get; }

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000063 RID: 99
		[global::System.Runtime.InteropServices.DispId(203)]
		object Document { [global::System.Runtime.InteropServices.DispId(203)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] get; }

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000064 RID: 100
		[global::System.Runtime.InteropServices.DispId(204)]
		bool TopLevelContainer { [global::System.Runtime.InteropServices.DispId(204)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000065 RID: 101
		[global::System.Runtime.InteropServices.DispId(205)]
		string Type { [global::System.Runtime.InteropServices.DispId(205)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000066 RID: 102
		// (set) Token: 0x06000067 RID: 103
		[global::System.Runtime.InteropServices.DispId(206)]
		int Left { [global::System.Runtime.InteropServices.DispId(206)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(206)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000068 RID: 104
		// (set) Token: 0x06000069 RID: 105
		[global::System.Runtime.InteropServices.DispId(207)]
		int Top { [global::System.Runtime.InteropServices.DispId(207)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(207)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x0600006A RID: 106
		// (set) Token: 0x0600006B RID: 107
		[global::System.Runtime.InteropServices.DispId(208)]
		int Width { [global::System.Runtime.InteropServices.DispId(208)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(208)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x0600006C RID: 108
		// (set) Token: 0x0600006D RID: 109
		[global::System.Runtime.InteropServices.DispId(209)]
		int Height { [global::System.Runtime.InteropServices.DispId(209)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(209)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x0600006E RID: 110
		[global::System.Runtime.InteropServices.DispId(210)]
		string LocationName { [global::System.Runtime.InteropServices.DispId(210)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x0600006F RID: 111
		[global::System.Runtime.InteropServices.DispId(211)]
		string LocationURL { [global::System.Runtime.InteropServices.DispId(211)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000070 RID: 112
		[global::System.Runtime.InteropServices.DispId(212)]
		bool Busy { [global::System.Runtime.InteropServices.DispId(212)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x06000071 RID: 113
		[global::System.Runtime.InteropServices.DispId(300)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void Quit();

		// Token: 0x06000072 RID: 114
		[global::System.Runtime.InteropServices.DispId(301)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void ClientToWindow([global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Out] ref int pcx, [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Out] ref int pcy);

		// Token: 0x06000073 RID: 115
		[global::System.Runtime.InteropServices.DispId(302)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void PutProperty([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string Property, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] object vtValue);

		// Token: 0x06000074 RID: 116
		[global::System.Runtime.InteropServices.DispId(303)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)]
		object GetProperty([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string Property);

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x06000075 RID: 117
		[global::System.Runtime.InteropServices.DispId(0)]
		[global::System.Runtime.CompilerServices.IndexerName("Name")]
		string Name { [global::System.Runtime.InteropServices.DispId(0)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000076 RID: 118
		[global::System.Runtime.InteropServices.DispId(-515)]
		int HWND { [global::System.Runtime.InteropServices.DispId(-515)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000077 RID: 119
		[global::System.Runtime.InteropServices.DispId(400)]
		string FullName { [global::System.Runtime.InteropServices.DispId(400)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000078 RID: 120
		[global::System.Runtime.InteropServices.DispId(401)]
		string Path { [global::System.Runtime.InteropServices.DispId(401)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000079 RID: 121
		// (set) Token: 0x0600007A RID: 122
		[global::System.Runtime.InteropServices.DispId(402)]
		bool Visible { [global::System.Runtime.InteropServices.DispId(402)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(402)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x0600007B RID: 123
		// (set) Token: 0x0600007C RID: 124
		[global::System.Runtime.InteropServices.DispId(403)]
		bool StatusBar { [global::System.Runtime.InteropServices.DispId(403)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(403)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x0600007D RID: 125
		// (set) Token: 0x0600007E RID: 126
		[global::System.Runtime.InteropServices.DispId(404)]
		string StatusText { [global::System.Runtime.InteropServices.DispId(404)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(404)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x0600007F RID: 127
		// (set) Token: 0x06000080 RID: 128
		[global::System.Runtime.InteropServices.DispId(405)]
		int ToolBar { [global::System.Runtime.InteropServices.DispId(405)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(405)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000081 RID: 129
		// (set) Token: 0x06000082 RID: 130
		[global::System.Runtime.InteropServices.DispId(406)]
		bool MenuBar { [global::System.Runtime.InteropServices.DispId(406)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(406)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000083 RID: 131
		// (set) Token: 0x06000084 RID: 132
		[global::System.Runtime.InteropServices.DispId(407)]
		bool FullScreen { [global::System.Runtime.InteropServices.DispId(407)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(407)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x06000085 RID: 133
		[global::System.Runtime.InteropServices.DispId(500)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void Navigate2([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] ref object URL, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object Flags, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object TargetFrameName, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object PostData, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object Headers);

		// Token: 0x06000086 RID: 134
		[global::System.Runtime.InteropServices.DispId(501)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		global::SHDocVw.OLECMDF QueryStatusWB([global::System.Runtime.InteropServices.In] global::SHDocVw.OLECMDID cmdID);

		// Token: 0x06000087 RID: 135
		[global::System.Runtime.InteropServices.DispId(502)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void ExecWB([global::System.Runtime.InteropServices.In] global::SHDocVw.OLECMDID cmdID, [global::System.Runtime.InteropServices.In] global::SHDocVw.OLECMDEXECOPT cmdexecopt, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object pvaIn, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Out] [global::System.Runtime.InteropServices.Optional] ref object pvaOut);

		// Token: 0x06000088 RID: 136
		[global::System.Runtime.InteropServices.DispId(503)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void ShowBrowserBar([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] ref object pvaClsid, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object pvarShow, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object pvarSize);

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000089 RID: 137
		[global::System.Runtime.InteropServices.DispId(-525)]
		global::SHDocVw.tagREADYSTATE ReadyState { [global::System.Runtime.InteropServices.DispId(-525)] [global::System.Runtime.InteropServices.TypeLibFunc(4)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x0600008A RID: 138
		// (set) Token: 0x0600008B RID: 139
		[global::System.Runtime.InteropServices.DispId(550)]
		bool Offline { [global::System.Runtime.InteropServices.DispId(550)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(550)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x0600008C RID: 140
		// (set) Token: 0x0600008D RID: 141
		[global::System.Runtime.InteropServices.DispId(551)]
		bool Silent { [global::System.Runtime.InteropServices.DispId(551)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(551)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x0600008E RID: 142
		// (set) Token: 0x0600008F RID: 143
		[global::System.Runtime.InteropServices.DispId(552)]
		bool RegisterAsBrowser { [global::System.Runtime.InteropServices.DispId(552)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(552)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000090 RID: 144
		// (set) Token: 0x06000091 RID: 145
		[global::System.Runtime.InteropServices.DispId(553)]
		bool RegisterAsDropTarget { [global::System.Runtime.InteropServices.DispId(553)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(553)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000092 RID: 146
		// (set) Token: 0x06000093 RID: 147
		[global::System.Runtime.InteropServices.DispId(554)]
		bool TheaterMode { [global::System.Runtime.InteropServices.DispId(554)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(554)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000094 RID: 148
		// (set) Token: 0x06000095 RID: 149
		[global::System.Runtime.InteropServices.DispId(555)]
		bool AddressBar { [global::System.Runtime.InteropServices.DispId(555)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(555)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000096 RID: 150
		// (set) Token: 0x06000097 RID: 151
		[global::System.Runtime.InteropServices.DispId(556)]
		bool Resizable { [global::System.Runtime.InteropServices.DispId(556)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(556)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }
	}
}
