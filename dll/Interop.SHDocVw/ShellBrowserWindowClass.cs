using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SHDocVw
{
	// Token: 0x02000046 RID: 70
	[global::System.Runtime.InteropServices.TypeLibType(18)]
	[global::System.Runtime.InteropServices.Guid("C08AFD90-F2A1-11D1-8455-00A0C91F3880")]
	[global::System.Runtime.InteropServices.ClassInterface(0)]
	[global::System.Reflection.DefaultMember("Name")]
	[global::System.Runtime.InteropServices.ComSourceInterfaces("SHDocVw.DWebBrowserEvents2\0SHDocVw.DWebBrowserEvents\0\0")]
	[global::System.Runtime.InteropServices.ComImport]
	public class ShellBrowserWindowClass : global::SHDocVw.IWebBrowser2, global::SHDocVw.ShellBrowserWindow, global::SHDocVw.DWebBrowserEvents2_Event, global::SHDocVw.IWebBrowserApp, global::SHDocVw.DWebBrowserEvents_Event
	{
		// Token: 0x060003C4 RID: 964
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public extern ShellBrowserWindowClass();

		// Token: 0x060003C5 RID: 965
		[global::System.Runtime.InteropServices.DispId(100)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void GoBack();

		// Token: 0x060003C6 RID: 966
		[global::System.Runtime.InteropServices.DispId(101)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void GoForward();

		// Token: 0x060003C7 RID: 967
		[global::System.Runtime.InteropServices.DispId(102)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void GoHome();

		// Token: 0x060003C8 RID: 968
		[global::System.Runtime.InteropServices.DispId(103)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void GoSearch();

		// Token: 0x060003C9 RID: 969
		[global::System.Runtime.InteropServices.DispId(104)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void Navigate([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string URL, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object Flags, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object TargetFrameName, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object PostData, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object Headers);

		// Token: 0x060003CA RID: 970
		[global::System.Runtime.InteropServices.DispId(-550)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void Refresh();

		// Token: 0x060003CB RID: 971
		[global::System.Runtime.InteropServices.DispId(105)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void Refresh2([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object Level);

		// Token: 0x060003CC RID: 972
		[global::System.Runtime.InteropServices.DispId(106)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void Stop();

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x060003CD RID: 973
		[global::System.Runtime.InteropServices.DispId(200)]
		public virtual extern object Application { [global::System.Runtime.InteropServices.DispId(200)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] get; }

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x060003CE RID: 974
		[global::System.Runtime.InteropServices.DispId(201)]
		public virtual extern object Parent { [global::System.Runtime.InteropServices.DispId(201)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] get; }

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x060003CF RID: 975
		[global::System.Runtime.InteropServices.DispId(202)]
		public virtual extern object Container { [global::System.Runtime.InteropServices.DispId(202)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] get; }

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x060003D0 RID: 976
		[global::System.Runtime.InteropServices.DispId(203)]
		public virtual extern object Document { [global::System.Runtime.InteropServices.DispId(203)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] get; }

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x060003D1 RID: 977
		[global::System.Runtime.InteropServices.DispId(204)]
		public virtual extern bool TopLevelContainer { [global::System.Runtime.InteropServices.DispId(204)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x060003D2 RID: 978
		[global::System.Runtime.InteropServices.DispId(205)]
		public virtual extern string Type { [global::System.Runtime.InteropServices.DispId(205)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x060003D3 RID: 979
		// (set) Token: 0x060003D4 RID: 980
		[global::System.Runtime.InteropServices.DispId(206)]
		public virtual extern int Left { [global::System.Runtime.InteropServices.DispId(206)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(206)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x060003D5 RID: 981
		// (set) Token: 0x060003D6 RID: 982
		[global::System.Runtime.InteropServices.DispId(207)]
		public virtual extern int Top { [global::System.Runtime.InteropServices.DispId(207)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(207)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x060003D7 RID: 983
		// (set) Token: 0x060003D8 RID: 984
		[global::System.Runtime.InteropServices.DispId(208)]
		public virtual extern int Width { [global::System.Runtime.InteropServices.DispId(208)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(208)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x060003D9 RID: 985
		// (set) Token: 0x060003DA RID: 986
		[global::System.Runtime.InteropServices.DispId(209)]
		public virtual extern int Height { [global::System.Runtime.InteropServices.DispId(209)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(209)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x060003DB RID: 987
		[global::System.Runtime.InteropServices.DispId(210)]
		public virtual extern string LocationName { [global::System.Runtime.InteropServices.DispId(210)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x060003DC RID: 988
		[global::System.Runtime.InteropServices.DispId(211)]
		public virtual extern string LocationURL { [global::System.Runtime.InteropServices.DispId(211)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x060003DD RID: 989
		[global::System.Runtime.InteropServices.DispId(212)]
		public virtual extern bool Busy { [global::System.Runtime.InteropServices.DispId(212)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x060003DE RID: 990
		[global::System.Runtime.InteropServices.DispId(300)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void Quit();

		// Token: 0x060003DF RID: 991
		[global::System.Runtime.InteropServices.DispId(301)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void ClientToWindow([global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Out] ref int pcx, [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Out] ref int pcy);

		// Token: 0x060003E0 RID: 992
		[global::System.Runtime.InteropServices.DispId(302)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void PutProperty([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string Property, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] object vtValue);

		// Token: 0x060003E1 RID: 993
		[global::System.Runtime.InteropServices.DispId(303)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)]
		public virtual extern object GetProperty([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string Property);

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x060003E2 RID: 994
		[global::System.Runtime.InteropServices.DispId(0)]
		[global::System.Runtime.CompilerServices.IndexerName("Name")]
		public virtual extern string Name { [global::System.Runtime.InteropServices.DispId(0)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x060003E3 RID: 995
		[global::System.Runtime.InteropServices.DispId(-515)]
		public virtual extern int HWND { [global::System.Runtime.InteropServices.DispId(-515)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x060003E4 RID: 996
		[global::System.Runtime.InteropServices.DispId(400)]
		public virtual extern string FullName { [global::System.Runtime.InteropServices.DispId(400)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x060003E5 RID: 997
		[global::System.Runtime.InteropServices.DispId(401)]
		public virtual extern string Path { [global::System.Runtime.InteropServices.DispId(401)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x060003E6 RID: 998
		// (set) Token: 0x060003E7 RID: 999
		[global::System.Runtime.InteropServices.DispId(402)]
		public virtual extern bool Visible { [global::System.Runtime.InteropServices.DispId(402)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(402)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x060003E8 RID: 1000
		// (set) Token: 0x060003E9 RID: 1001
		[global::System.Runtime.InteropServices.DispId(403)]
		public virtual extern bool StatusBar { [global::System.Runtime.InteropServices.DispId(403)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(403)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x060003EA RID: 1002
		// (set) Token: 0x060003EB RID: 1003
		[global::System.Runtime.InteropServices.DispId(404)]
		public virtual extern string StatusText { [global::System.Runtime.InteropServices.DispId(404)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(404)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x060003EC RID: 1004
		// (set) Token: 0x060003ED RID: 1005
		[global::System.Runtime.InteropServices.DispId(405)]
		public virtual extern int ToolBar { [global::System.Runtime.InteropServices.DispId(405)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(405)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x060003EE RID: 1006
		// (set) Token: 0x060003EF RID: 1007
		[global::System.Runtime.InteropServices.DispId(406)]
		public virtual extern bool MenuBar { [global::System.Runtime.InteropServices.DispId(406)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(406)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x060003F0 RID: 1008
		// (set) Token: 0x060003F1 RID: 1009
		[global::System.Runtime.InteropServices.DispId(407)]
		public virtual extern bool FullScreen { [global::System.Runtime.InteropServices.DispId(407)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(407)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x060003F2 RID: 1010
		[global::System.Runtime.InteropServices.DispId(500)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void Navigate2([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] ref object URL, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object Flags, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object TargetFrameName, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object PostData, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object Headers);

		// Token: 0x060003F3 RID: 1011
		[global::System.Runtime.InteropServices.DispId(501)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern global::SHDocVw.OLECMDF QueryStatusWB([global::System.Runtime.InteropServices.In] global::SHDocVw.OLECMDID cmdID);

		// Token: 0x060003F4 RID: 1012
		[global::System.Runtime.InteropServices.DispId(502)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void ExecWB([global::System.Runtime.InteropServices.In] global::SHDocVw.OLECMDID cmdID, [global::System.Runtime.InteropServices.In] global::SHDocVw.OLECMDEXECOPT cmdexecopt, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object pvaIn, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Out] [global::System.Runtime.InteropServices.Optional] ref object pvaOut);

		// Token: 0x060003F5 RID: 1013
		[global::System.Runtime.InteropServices.DispId(503)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void ShowBrowserBar([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] ref object pvaClsid, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object pvarShow, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object pvarSize);

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x060003F6 RID: 1014
		[global::System.Runtime.InteropServices.DispId(-525)]
		public virtual extern global::SHDocVw.tagREADYSTATE ReadyState { [global::System.Runtime.InteropServices.TypeLibFunc(4)] [global::System.Runtime.InteropServices.DispId(-525)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x060003F7 RID: 1015
		// (set) Token: 0x060003F8 RID: 1016
		[global::System.Runtime.InteropServices.DispId(550)]
		public virtual extern bool Offline { [global::System.Runtime.InteropServices.DispId(550)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(550)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x060003F9 RID: 1017
		// (set) Token: 0x060003FA RID: 1018
		[global::System.Runtime.InteropServices.DispId(551)]
		public virtual extern bool Silent { [global::System.Runtime.InteropServices.DispId(551)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(551)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x060003FB RID: 1019
		// (set) Token: 0x060003FC RID: 1020
		[global::System.Runtime.InteropServices.DispId(552)]
		public virtual extern bool RegisterAsBrowser { [global::System.Runtime.InteropServices.DispId(552)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(552)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x060003FD RID: 1021
		// (set) Token: 0x060003FE RID: 1022
		[global::System.Runtime.InteropServices.DispId(553)]
		public virtual extern bool RegisterAsDropTarget { [global::System.Runtime.InteropServices.DispId(553)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(553)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x060003FF RID: 1023
		// (set) Token: 0x06000400 RID: 1024
		[global::System.Runtime.InteropServices.DispId(554)]
		public virtual extern bool TheaterMode { [global::System.Runtime.InteropServices.DispId(554)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(554)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x06000401 RID: 1025
		// (set) Token: 0x06000402 RID: 1026
		[global::System.Runtime.InteropServices.DispId(555)]
		public virtual extern bool AddressBar { [global::System.Runtime.InteropServices.DispId(555)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(555)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x06000403 RID: 1027
		// (set) Token: 0x06000404 RID: 1028
		[global::System.Runtime.InteropServices.DispId(556)]
		public virtual extern bool Resizable { [global::System.Runtime.InteropServices.DispId(556)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(556)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x06000405 RID: 1029
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void IWebBrowserApp_GoBack();

		// Token: 0x06000406 RID: 1030
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void IWebBrowserApp_GoForward();

		// Token: 0x06000407 RID: 1031
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void IWebBrowserApp_GoHome();

		// Token: 0x06000408 RID: 1032
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void IWebBrowserApp_GoSearch();

		// Token: 0x06000409 RID: 1033
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void IWebBrowserApp_Navigate([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string URL, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object Flags, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object TargetFrameName, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object PostData, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object Headers);

		// Token: 0x0600040A RID: 1034
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void IWebBrowserApp_Refresh();

		// Token: 0x0600040B RID: 1035
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void IWebBrowserApp_Refresh2([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object Level);

		// Token: 0x0600040C RID: 1036
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void IWebBrowserApp_Stop();

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x0600040D RID: 1037
		public virtual extern object IWebBrowserApp_Application { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] get; }

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x0600040E RID: 1038
		public virtual extern object IWebBrowserApp_Parent { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] get; }

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x0600040F RID: 1039
		public virtual extern object IWebBrowserApp_Container { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] get; }

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x06000410 RID: 1040
		public virtual extern object IWebBrowserApp_Document { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] get; }

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x06000411 RID: 1041
		public virtual extern bool IWebBrowserApp_TopLevelContainer { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x06000412 RID: 1042
		public virtual extern string IWebBrowserApp_Type { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x06000413 RID: 1043
		// (set) Token: 0x06000414 RID: 1044
		public virtual extern int IWebBrowserApp_Left { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x06000415 RID: 1045
		// (set) Token: 0x06000416 RID: 1046
		public virtual extern int IWebBrowserApp_Top { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x06000417 RID: 1047
		// (set) Token: 0x06000418 RID: 1048
		public virtual extern int IWebBrowserApp_Width { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x06000419 RID: 1049
		// (set) Token: 0x0600041A RID: 1050
		public virtual extern int IWebBrowserApp_Height { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x0600041B RID: 1051
		public virtual extern string IWebBrowserApp_LocationName { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x0600041C RID: 1052
		public virtual extern string IWebBrowserApp_LocationURL { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x0600041D RID: 1053
		public virtual extern bool IWebBrowserApp_Busy { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x0600041E RID: 1054
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void IWebBrowserApp_Quit();

		// Token: 0x0600041F RID: 1055
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void IWebBrowserApp_ClientToWindow([global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Out] ref int pcx, [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Out] ref int pcy);

		// Token: 0x06000420 RID: 1056
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void IWebBrowserApp_PutProperty([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string Property, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] object vtValue);

		// Token: 0x06000421 RID: 1057
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)]
		public virtual extern object IWebBrowserApp_GetProperty([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string Property);

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x06000422 RID: 1058
		public virtual extern string IWebBrowserApp_Name { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x06000423 RID: 1059
		public virtual extern int IWebBrowserApp_HWND { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x06000424 RID: 1060
		public virtual extern string IWebBrowserApp_FullName { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x06000425 RID: 1061
		public virtual extern string IWebBrowserApp_Path { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x06000426 RID: 1062
		// (set) Token: 0x06000427 RID: 1063
		public virtual extern bool IWebBrowserApp_Visible { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x06000428 RID: 1064
		// (set) Token: 0x06000429 RID: 1065
		public virtual extern bool IWebBrowserApp_StatusBar { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x0600042A RID: 1066
		// (set) Token: 0x0600042B RID: 1067
		public virtual extern string IWebBrowserApp_StatusText { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x0600042C RID: 1068
		// (set) Token: 0x0600042D RID: 1069
		public virtual extern int IWebBrowserApp_ToolBar { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x0600042E RID: 1070
		// (set) Token: 0x0600042F RID: 1071
		public virtual extern bool IWebBrowserApp_MenuBar { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x06000430 RID: 1072
		// (set) Token: 0x06000431 RID: 1073
		public virtual extern bool IWebBrowserApp_FullScreen { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x140000C5 RID: 197
		// (add) Token: 0x06000432 RID: 1074
		// (remove) Token: 0x06000433 RID: 1075
		public virtual extern event global::SHDocVw.DWebBrowserEvents2_StatusTextChangeEventHandler StatusTextChange;

		// Token: 0x140000C6 RID: 198
		// (add) Token: 0x06000434 RID: 1076
		// (remove) Token: 0x06000435 RID: 1077
		public virtual extern event global::SHDocVw.DWebBrowserEvents2_ProgressChangeEventHandler ProgressChange;

		// Token: 0x140000C7 RID: 199
		// (add) Token: 0x06000436 RID: 1078
		// (remove) Token: 0x06000437 RID: 1079
		public virtual extern event global::SHDocVw.DWebBrowserEvents2_CommandStateChangeEventHandler CommandStateChange;

		// Token: 0x140000C8 RID: 200
		// (add) Token: 0x06000438 RID: 1080
		// (remove) Token: 0x06000439 RID: 1081
		public virtual extern event global::SHDocVw.DWebBrowserEvents2_DownloadBeginEventHandler DownloadBegin;

		// Token: 0x140000C9 RID: 201
		// (add) Token: 0x0600043A RID: 1082
		// (remove) Token: 0x0600043B RID: 1083
		public virtual extern event global::SHDocVw.DWebBrowserEvents2_DownloadCompleteEventHandler DownloadComplete;

		// Token: 0x140000CA RID: 202
		// (add) Token: 0x0600043C RID: 1084
		// (remove) Token: 0x0600043D RID: 1085
		public virtual extern event global::SHDocVw.DWebBrowserEvents2_TitleChangeEventHandler TitleChange;

		// Token: 0x140000CB RID: 203
		// (add) Token: 0x0600043E RID: 1086
		// (remove) Token: 0x0600043F RID: 1087
		public virtual extern event global::SHDocVw.DWebBrowserEvents2_PropertyChangeEventHandler PropertyChange;

		// Token: 0x140000CC RID: 204
		// (add) Token: 0x06000440 RID: 1088
		// (remove) Token: 0x06000441 RID: 1089
		public virtual extern event global::SHDocVw.DWebBrowserEvents2_BeforeNavigate2EventHandler BeforeNavigate2;

		// Token: 0x140000CD RID: 205
		// (add) Token: 0x06000442 RID: 1090
		// (remove) Token: 0x06000443 RID: 1091
		public virtual extern event global::SHDocVw.DWebBrowserEvents2_NewWindow2EventHandler NewWindow2;

		// Token: 0x140000CE RID: 206
		// (add) Token: 0x06000444 RID: 1092
		// (remove) Token: 0x06000445 RID: 1093
		public virtual extern event global::SHDocVw.DWebBrowserEvents2_NavigateComplete2EventHandler NavigateComplete2;

		// Token: 0x140000CF RID: 207
		// (add) Token: 0x06000446 RID: 1094
		// (remove) Token: 0x06000447 RID: 1095
		public virtual extern event global::SHDocVw.DWebBrowserEvents2_DocumentCompleteEventHandler DocumentComplete;

		// Token: 0x140000D0 RID: 208
		// (add) Token: 0x06000448 RID: 1096
		// (remove) Token: 0x06000449 RID: 1097
		public virtual extern event global::SHDocVw.DWebBrowserEvents2_OnQuitEventHandler OnQuit;

		// Token: 0x140000D1 RID: 209
		// (add) Token: 0x0600044A RID: 1098
		// (remove) Token: 0x0600044B RID: 1099
		public virtual extern event global::SHDocVw.DWebBrowserEvents2_OnVisibleEventHandler OnVisible;

		// Token: 0x140000D2 RID: 210
		// (add) Token: 0x0600044C RID: 1100
		// (remove) Token: 0x0600044D RID: 1101
		public virtual extern event global::SHDocVw.DWebBrowserEvents2_OnToolBarEventHandler OnToolBar;

		// Token: 0x140000D3 RID: 211
		// (add) Token: 0x0600044E RID: 1102
		// (remove) Token: 0x0600044F RID: 1103
		public virtual extern event global::SHDocVw.DWebBrowserEvents2_OnMenuBarEventHandler OnMenuBar;

		// Token: 0x140000D4 RID: 212
		// (add) Token: 0x06000450 RID: 1104
		// (remove) Token: 0x06000451 RID: 1105
		public virtual extern event global::SHDocVw.DWebBrowserEvents2_OnStatusBarEventHandler OnStatusBar;

		// Token: 0x140000D5 RID: 213
		// (add) Token: 0x06000452 RID: 1106
		// (remove) Token: 0x06000453 RID: 1107
		public virtual extern event global::SHDocVw.DWebBrowserEvents2_OnFullScreenEventHandler OnFullScreen;

		// Token: 0x140000D6 RID: 214
		// (add) Token: 0x06000454 RID: 1108
		// (remove) Token: 0x06000455 RID: 1109
		public virtual extern event global::SHDocVw.DWebBrowserEvents2_OnTheaterModeEventHandler OnTheaterMode;

		// Token: 0x140000D7 RID: 215
		// (add) Token: 0x06000456 RID: 1110
		// (remove) Token: 0x06000457 RID: 1111
		public virtual extern event global::SHDocVw.DWebBrowserEvents2_WindowSetResizableEventHandler WindowSetResizable;

		// Token: 0x140000D8 RID: 216
		// (add) Token: 0x06000458 RID: 1112
		// (remove) Token: 0x06000459 RID: 1113
		public virtual extern event global::SHDocVw.DWebBrowserEvents2_WindowSetLeftEventHandler WindowSetLeft;

		// Token: 0x140000D9 RID: 217
		// (add) Token: 0x0600045A RID: 1114
		// (remove) Token: 0x0600045B RID: 1115
		public virtual extern event global::SHDocVw.DWebBrowserEvents2_WindowSetTopEventHandler WindowSetTop;

		// Token: 0x140000DA RID: 218
		// (add) Token: 0x0600045C RID: 1116
		// (remove) Token: 0x0600045D RID: 1117
		public virtual extern event global::SHDocVw.DWebBrowserEvents2_WindowSetWidthEventHandler WindowSetWidth;

		// Token: 0x140000DB RID: 219
		// (add) Token: 0x0600045E RID: 1118
		// (remove) Token: 0x0600045F RID: 1119
		public virtual extern event global::SHDocVw.DWebBrowserEvents2_WindowSetHeightEventHandler WindowSetHeight;

		// Token: 0x140000DC RID: 220
		// (add) Token: 0x06000460 RID: 1120
		// (remove) Token: 0x06000461 RID: 1121
		public virtual extern event global::SHDocVw.DWebBrowserEvents2_WindowClosingEventHandler WindowClosing;

		// Token: 0x140000DD RID: 221
		// (add) Token: 0x06000462 RID: 1122
		// (remove) Token: 0x06000463 RID: 1123
		public virtual extern event global::SHDocVw.DWebBrowserEvents2_ClientToHostWindowEventHandler ClientToHostWindow;

		// Token: 0x140000DE RID: 222
		// (add) Token: 0x06000464 RID: 1124
		// (remove) Token: 0x06000465 RID: 1125
		public virtual extern event global::SHDocVw.DWebBrowserEvents2_SetSecureLockIconEventHandler SetSecureLockIcon;

		// Token: 0x140000DF RID: 223
		// (add) Token: 0x06000466 RID: 1126
		// (remove) Token: 0x06000467 RID: 1127
		public virtual extern event global::SHDocVw.DWebBrowserEvents2_FileDownloadEventHandler FileDownload;

		// Token: 0x140000E0 RID: 224
		// (add) Token: 0x06000468 RID: 1128
		// (remove) Token: 0x06000469 RID: 1129
		public virtual extern event global::SHDocVw.DWebBrowserEvents2_NavigateErrorEventHandler NavigateError;

		// Token: 0x140000E1 RID: 225
		// (add) Token: 0x0600046A RID: 1130
		// (remove) Token: 0x0600046B RID: 1131
		public virtual extern event global::SHDocVw.DWebBrowserEvents2_PrintTemplateInstantiationEventHandler PrintTemplateInstantiation;

		// Token: 0x140000E2 RID: 226
		// (add) Token: 0x0600046C RID: 1132
		// (remove) Token: 0x0600046D RID: 1133
		public virtual extern event global::SHDocVw.DWebBrowserEvents2_PrintTemplateTeardownEventHandler PrintTemplateTeardown;

		// Token: 0x140000E3 RID: 227
		// (add) Token: 0x0600046E RID: 1134
		// (remove) Token: 0x0600046F RID: 1135
		public virtual extern event global::SHDocVw.DWebBrowserEvents2_UpdatePageStatusEventHandler UpdatePageStatus;

		// Token: 0x140000E4 RID: 228
		// (add) Token: 0x06000470 RID: 1136
		// (remove) Token: 0x06000471 RID: 1137
		public virtual extern event global::SHDocVw.DWebBrowserEvents2_PrivacyImpactedStateChangeEventHandler PrivacyImpactedStateChange;

		// Token: 0x140000E5 RID: 229
		// (add) Token: 0x06000472 RID: 1138
		// (remove) Token: 0x06000473 RID: 1139
		public virtual extern event global::SHDocVw.DWebBrowserEvents_BeforeNavigateEventHandler BeforeNavigate;

		// Token: 0x140000E6 RID: 230
		// (add) Token: 0x06000474 RID: 1140
		// (remove) Token: 0x06000475 RID: 1141
		public virtual extern event global::SHDocVw.DWebBrowserEvents_NavigateCompleteEventHandler NavigateComplete;

		// Token: 0x140000E7 RID: 231
		// (add) Token: 0x06000476 RID: 1142
		// (remove) Token: 0x06000477 RID: 1143
		public virtual extern event global::SHDocVw.DWebBrowserEvents_StatusTextChangeEventHandler DWebBrowserEvents_Event_StatusTextChange;

		// Token: 0x140000E8 RID: 232
		// (add) Token: 0x06000478 RID: 1144
		// (remove) Token: 0x06000479 RID: 1145
		public virtual extern event global::SHDocVw.DWebBrowserEvents_ProgressChangeEventHandler DWebBrowserEvents_Event_ProgressChange;

		// Token: 0x140000E9 RID: 233
		// (add) Token: 0x0600047A RID: 1146
		// (remove) Token: 0x0600047B RID: 1147
		public virtual extern event global::SHDocVw.DWebBrowserEvents_DownloadCompleteEventHandler DWebBrowserEvents_Event_DownloadComplete;

		// Token: 0x140000EA RID: 234
		// (add) Token: 0x0600047C RID: 1148
		// (remove) Token: 0x0600047D RID: 1149
		public virtual extern event global::SHDocVw.DWebBrowserEvents_CommandStateChangeEventHandler DWebBrowserEvents_Event_CommandStateChange;

		// Token: 0x140000EB RID: 235
		// (add) Token: 0x0600047E RID: 1150
		// (remove) Token: 0x0600047F RID: 1151
		public virtual extern event global::SHDocVw.DWebBrowserEvents_DownloadBeginEventHandler DWebBrowserEvents_Event_DownloadBegin;

		// Token: 0x140000EC RID: 236
		// (add) Token: 0x06000480 RID: 1152
		// (remove) Token: 0x06000481 RID: 1153
		public virtual extern event global::SHDocVw.DWebBrowserEvents_NewWindowEventHandler NewWindow;

		// Token: 0x140000ED RID: 237
		// (add) Token: 0x06000482 RID: 1154
		// (remove) Token: 0x06000483 RID: 1155
		public virtual extern event global::SHDocVw.DWebBrowserEvents_TitleChangeEventHandler DWebBrowserEvents_Event_TitleChange;

		// Token: 0x140000EE RID: 238
		// (add) Token: 0x06000484 RID: 1156
		// (remove) Token: 0x06000485 RID: 1157
		public virtual extern event global::SHDocVw.DWebBrowserEvents_FrameBeforeNavigateEventHandler FrameBeforeNavigate;

		// Token: 0x140000EF RID: 239
		// (add) Token: 0x06000486 RID: 1158
		// (remove) Token: 0x06000487 RID: 1159
		public virtual extern event global::SHDocVw.DWebBrowserEvents_FrameNavigateCompleteEventHandler FrameNavigateComplete;

		// Token: 0x140000F0 RID: 240
		// (add) Token: 0x06000488 RID: 1160
		// (remove) Token: 0x06000489 RID: 1161
		public virtual extern event global::SHDocVw.DWebBrowserEvents_FrameNewWindowEventHandler FrameNewWindow;

		// Token: 0x140000F1 RID: 241
		// (add) Token: 0x0600048A RID: 1162
		// (remove) Token: 0x0600048B RID: 1163
		public virtual extern event global::SHDocVw.DWebBrowserEvents_QuitEventHandler DWebBrowserEvents_Event_Quit;

		// Token: 0x140000F2 RID: 242
		// (add) Token: 0x0600048C RID: 1164
		// (remove) Token: 0x0600048D RID: 1165
		public virtual extern event global::SHDocVw.DWebBrowserEvents_WindowMoveEventHandler WindowMove;

		// Token: 0x140000F3 RID: 243
		// (add) Token: 0x0600048E RID: 1166
		// (remove) Token: 0x0600048F RID: 1167
		public virtual extern event global::SHDocVw.DWebBrowserEvents_WindowResizeEventHandler WindowResize;

		// Token: 0x140000F4 RID: 244
		// (add) Token: 0x06000490 RID: 1168
		// (remove) Token: 0x06000491 RID: 1169
		public virtual extern event global::SHDocVw.DWebBrowserEvents_WindowActivateEventHandler WindowActivate;

		// Token: 0x140000F5 RID: 245
		// (add) Token: 0x06000492 RID: 1170
		// (remove) Token: 0x06000493 RID: 1171
		public virtual extern event global::SHDocVw.DWebBrowserEvents_PropertyChangeEventHandler DWebBrowserEvents_Event_PropertyChange;
	}
}
