using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SHDocVw
{
	// Token: 0x02000044 RID: 68
	[global::System.Runtime.InteropServices.TypeLibType(2)]
	[global::System.Reflection.DefaultMember("Name")]
	[global::System.Runtime.InteropServices.Guid("0002DF01-0000-0000-C000-000000000046")]
	[global::System.Runtime.InteropServices.ComSourceInterfaces("SHDocVw.DWebBrowserEvents2\0SHDocVw.DWebBrowserEvents\0\0")]
	[global::System.Runtime.InteropServices.ClassInterface(0)]
	[global::System.Runtime.InteropServices.ComImport]
	public class InternetExplorerClass : global::SHDocVw.IWebBrowser2, global::SHDocVw.InternetExplorer, global::SHDocVw.DWebBrowserEvents2_Event, global::SHDocVw.IWebBrowserApp, global::SHDocVw.DWebBrowserEvents_Event
	{
		// Token: 0x060002F4 RID: 756
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public extern InternetExplorerClass();

		// Token: 0x060002F5 RID: 757
		[global::System.Runtime.InteropServices.DispId(100)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void GoBack();

		// Token: 0x060002F6 RID: 758
		[global::System.Runtime.InteropServices.DispId(101)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void GoForward();

		// Token: 0x060002F7 RID: 759
		[global::System.Runtime.InteropServices.DispId(102)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void GoHome();

		// Token: 0x060002F8 RID: 760
		[global::System.Runtime.InteropServices.DispId(103)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void GoSearch();

		// Token: 0x060002F9 RID: 761
		[global::System.Runtime.InteropServices.DispId(104)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void Navigate([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string URL, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object Flags, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object TargetFrameName, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object PostData, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object Headers);

		// Token: 0x060002FA RID: 762
		[global::System.Runtime.InteropServices.DispId(-550)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void Refresh();

		// Token: 0x060002FB RID: 763
		[global::System.Runtime.InteropServices.DispId(105)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void Refresh2([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object Level);

		// Token: 0x060002FC RID: 764
		[global::System.Runtime.InteropServices.DispId(106)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void Stop();

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x060002FD RID: 765
		[global::System.Runtime.InteropServices.DispId(200)]
		public virtual extern object Application { [global::System.Runtime.InteropServices.DispId(200)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] get; }

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x060002FE RID: 766
		[global::System.Runtime.InteropServices.DispId(201)]
		public virtual extern object Parent { [global::System.Runtime.InteropServices.DispId(201)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] get; }

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x060002FF RID: 767
		[global::System.Runtime.InteropServices.DispId(202)]
		public virtual extern object Container { [global::System.Runtime.InteropServices.DispId(202)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] get; }

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x06000300 RID: 768
		[global::System.Runtime.InteropServices.DispId(203)]
		public virtual extern object Document { [global::System.Runtime.InteropServices.DispId(203)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] get; }

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x06000301 RID: 769
		[global::System.Runtime.InteropServices.DispId(204)]
		public virtual extern bool TopLevelContainer { [global::System.Runtime.InteropServices.DispId(204)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x06000302 RID: 770
		[global::System.Runtime.InteropServices.DispId(205)]
		public virtual extern string Type { [global::System.Runtime.InteropServices.DispId(205)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x06000303 RID: 771
		// (set) Token: 0x06000304 RID: 772
		[global::System.Runtime.InteropServices.DispId(206)]
		public virtual extern int Left { [global::System.Runtime.InteropServices.DispId(206)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(206)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x06000305 RID: 773
		// (set) Token: 0x06000306 RID: 774
		[global::System.Runtime.InteropServices.DispId(207)]
		public virtual extern int Top { [global::System.Runtime.InteropServices.DispId(207)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(207)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x06000307 RID: 775
		// (set) Token: 0x06000308 RID: 776
		[global::System.Runtime.InteropServices.DispId(208)]
		public virtual extern int Width { [global::System.Runtime.InteropServices.DispId(208)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(208)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x06000309 RID: 777
		// (set) Token: 0x0600030A RID: 778
		[global::System.Runtime.InteropServices.DispId(209)]
		public virtual extern int Height { [global::System.Runtime.InteropServices.DispId(209)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(209)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x0600030B RID: 779
		[global::System.Runtime.InteropServices.DispId(210)]
		public virtual extern string LocationName { [global::System.Runtime.InteropServices.DispId(210)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x0600030C RID: 780
		[global::System.Runtime.InteropServices.DispId(211)]
		public virtual extern string LocationURL { [global::System.Runtime.InteropServices.DispId(211)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x0600030D RID: 781
		[global::System.Runtime.InteropServices.DispId(212)]
		public virtual extern bool Busy { [global::System.Runtime.InteropServices.DispId(212)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x0600030E RID: 782
		[global::System.Runtime.InteropServices.DispId(300)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void Quit();

		// Token: 0x0600030F RID: 783
		[global::System.Runtime.InteropServices.DispId(301)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void ClientToWindow([global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Out] ref int pcx, [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Out] ref int pcy);

		// Token: 0x06000310 RID: 784
		[global::System.Runtime.InteropServices.DispId(302)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void PutProperty([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string Property, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] object vtValue);

		// Token: 0x06000311 RID: 785
		[global::System.Runtime.InteropServices.DispId(303)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)]
		public virtual extern object GetProperty([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string Property);

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x06000312 RID: 786
		[global::System.Runtime.InteropServices.DispId(0)]
		[global::System.Runtime.CompilerServices.IndexerName("Name")]
		public virtual extern string Name { [global::System.Runtime.InteropServices.DispId(0)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x06000313 RID: 787
		[global::System.Runtime.InteropServices.DispId(-515)]
		public virtual extern int HWND { [global::System.Runtime.InteropServices.DispId(-515)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x06000314 RID: 788
		[global::System.Runtime.InteropServices.DispId(400)]
		public virtual extern string FullName { [global::System.Runtime.InteropServices.DispId(400)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x06000315 RID: 789
		[global::System.Runtime.InteropServices.DispId(401)]
		public virtual extern string Path { [global::System.Runtime.InteropServices.DispId(401)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x06000316 RID: 790
		// (set) Token: 0x06000317 RID: 791
		[global::System.Runtime.InteropServices.DispId(402)]
		public virtual extern bool Visible { [global::System.Runtime.InteropServices.DispId(402)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(402)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x06000318 RID: 792
		// (set) Token: 0x06000319 RID: 793
		[global::System.Runtime.InteropServices.DispId(403)]
		public virtual extern bool StatusBar { [global::System.Runtime.InteropServices.DispId(403)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(403)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x0600031A RID: 794
		// (set) Token: 0x0600031B RID: 795
		[global::System.Runtime.InteropServices.DispId(404)]
		public virtual extern string StatusText { [global::System.Runtime.InteropServices.DispId(404)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(404)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x0600031C RID: 796
		// (set) Token: 0x0600031D RID: 797
		[global::System.Runtime.InteropServices.DispId(405)]
		public virtual extern int ToolBar { [global::System.Runtime.InteropServices.DispId(405)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(405)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x0600031E RID: 798
		// (set) Token: 0x0600031F RID: 799
		[global::System.Runtime.InteropServices.DispId(406)]
		public virtual extern bool MenuBar { [global::System.Runtime.InteropServices.DispId(406)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(406)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x06000320 RID: 800
		// (set) Token: 0x06000321 RID: 801
		[global::System.Runtime.InteropServices.DispId(407)]
		public virtual extern bool FullScreen { [global::System.Runtime.InteropServices.DispId(407)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(407)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x06000322 RID: 802
		[global::System.Runtime.InteropServices.DispId(500)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void Navigate2([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] ref object URL, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object Flags, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object TargetFrameName, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object PostData, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object Headers);

		// Token: 0x06000323 RID: 803
		[global::System.Runtime.InteropServices.DispId(501)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern global::SHDocVw.OLECMDF QueryStatusWB([global::System.Runtime.InteropServices.In] global::SHDocVw.OLECMDID cmdID);

		// Token: 0x06000324 RID: 804
		[global::System.Runtime.InteropServices.DispId(502)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void ExecWB([global::System.Runtime.InteropServices.In] global::SHDocVw.OLECMDID cmdID, [global::System.Runtime.InteropServices.In] global::SHDocVw.OLECMDEXECOPT cmdexecopt, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object pvaIn, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Out] [global::System.Runtime.InteropServices.Optional] ref object pvaOut);

		// Token: 0x06000325 RID: 805
		[global::System.Runtime.InteropServices.DispId(503)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void ShowBrowserBar([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] ref object pvaClsid, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object pvarShow, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object pvarSize);

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x06000326 RID: 806
		[global::System.Runtime.InteropServices.DispId(-525)]
		public virtual extern global::SHDocVw.tagREADYSTATE ReadyState { [global::System.Runtime.InteropServices.DispId(-525)] [global::System.Runtime.InteropServices.TypeLibFunc(4)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x06000327 RID: 807
		// (set) Token: 0x06000328 RID: 808
		[global::System.Runtime.InteropServices.DispId(550)]
		public virtual extern bool Offline { [global::System.Runtime.InteropServices.DispId(550)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(550)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x06000329 RID: 809
		// (set) Token: 0x0600032A RID: 810
		[global::System.Runtime.InteropServices.DispId(551)]
		public virtual extern bool Silent { [global::System.Runtime.InteropServices.DispId(551)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(551)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x0600032B RID: 811
		// (set) Token: 0x0600032C RID: 812
		[global::System.Runtime.InteropServices.DispId(552)]
		public virtual extern bool RegisterAsBrowser { [global::System.Runtime.InteropServices.DispId(552)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(552)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x0600032D RID: 813
		// (set) Token: 0x0600032E RID: 814
		[global::System.Runtime.InteropServices.DispId(553)]
		public virtual extern bool RegisterAsDropTarget { [global::System.Runtime.InteropServices.DispId(553)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(553)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x0600032F RID: 815
		// (set) Token: 0x06000330 RID: 816
		[global::System.Runtime.InteropServices.DispId(554)]
		public virtual extern bool TheaterMode { [global::System.Runtime.InteropServices.DispId(554)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(554)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x06000331 RID: 817
		// (set) Token: 0x06000332 RID: 818
		[global::System.Runtime.InteropServices.DispId(555)]
		public virtual extern bool AddressBar { [global::System.Runtime.InteropServices.DispId(555)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(555)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x06000333 RID: 819
		// (set) Token: 0x06000334 RID: 820
		[global::System.Runtime.InteropServices.DispId(556)]
		public virtual extern bool Resizable { [global::System.Runtime.InteropServices.DispId(556)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(556)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x06000335 RID: 821
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void IWebBrowserApp_GoBack();

		// Token: 0x06000336 RID: 822
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void IWebBrowserApp_GoForward();

		// Token: 0x06000337 RID: 823
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void IWebBrowserApp_GoHome();

		// Token: 0x06000338 RID: 824
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void IWebBrowserApp_GoSearch();

		// Token: 0x06000339 RID: 825
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void IWebBrowserApp_Navigate([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string URL, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object Flags, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object TargetFrameName, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object PostData, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object Headers);

		// Token: 0x0600033A RID: 826
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void IWebBrowserApp_Refresh();

		// Token: 0x0600033B RID: 827
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void IWebBrowserApp_Refresh2([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object Level);

		// Token: 0x0600033C RID: 828
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void IWebBrowserApp_Stop();

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x0600033D RID: 829
		public virtual extern object IWebBrowserApp_Application { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] get; }

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x0600033E RID: 830
		public virtual extern object IWebBrowserApp_Parent { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] get; }

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x0600033F RID: 831
		public virtual extern object IWebBrowserApp_Container { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] get; }

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x06000340 RID: 832
		public virtual extern object IWebBrowserApp_Document { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] get; }

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x06000341 RID: 833
		public virtual extern bool IWebBrowserApp_TopLevelContainer { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x06000342 RID: 834
		public virtual extern string IWebBrowserApp_Type { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x06000343 RID: 835
		// (set) Token: 0x06000344 RID: 836
		public virtual extern int IWebBrowserApp_Left { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x06000345 RID: 837
		// (set) Token: 0x06000346 RID: 838
		public virtual extern int IWebBrowserApp_Top { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x06000347 RID: 839
		// (set) Token: 0x06000348 RID: 840
		public virtual extern int IWebBrowserApp_Width { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x06000349 RID: 841
		// (set) Token: 0x0600034A RID: 842
		public virtual extern int IWebBrowserApp_Height { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x0600034B RID: 843
		public virtual extern string IWebBrowserApp_LocationName { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x0600034C RID: 844
		public virtual extern string IWebBrowserApp_LocationURL { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x0600034D RID: 845
		public virtual extern bool IWebBrowserApp_Busy { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x0600034E RID: 846
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void IWebBrowserApp_Quit();

		// Token: 0x0600034F RID: 847
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void IWebBrowserApp_ClientToWindow([global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Out] ref int pcx, [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Out] ref int pcy);

		// Token: 0x06000350 RID: 848
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void IWebBrowserApp_PutProperty([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string Property, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] object vtValue);

		// Token: 0x06000351 RID: 849
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)]
		public virtual extern object IWebBrowserApp_GetProperty([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string Property);

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x06000352 RID: 850
		public virtual extern string IWebBrowserApp_Name { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x06000353 RID: 851
		public virtual extern int IWebBrowserApp_HWND { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x06000354 RID: 852
		public virtual extern string IWebBrowserApp_FullName { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x06000355 RID: 853
		public virtual extern string IWebBrowserApp_Path { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x06000356 RID: 854
		// (set) Token: 0x06000357 RID: 855
		public virtual extern bool IWebBrowserApp_Visible { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x06000358 RID: 856
		// (set) Token: 0x06000359 RID: 857
		public virtual extern bool IWebBrowserApp_StatusBar { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x0600035A RID: 858
		// (set) Token: 0x0600035B RID: 859
		public virtual extern string IWebBrowserApp_StatusText { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x0600035C RID: 860
		// (set) Token: 0x0600035D RID: 861
		public virtual extern int IWebBrowserApp_ToolBar { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x0600035E RID: 862
		// (set) Token: 0x0600035F RID: 863
		public virtual extern bool IWebBrowserApp_MenuBar { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x06000360 RID: 864
		// (set) Token: 0x06000361 RID: 865
		public virtual extern bool IWebBrowserApp_FullScreen { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x14000094 RID: 148
		// (add) Token: 0x06000362 RID: 866
		// (remove) Token: 0x06000363 RID: 867
		public virtual extern event global::SHDocVw.DWebBrowserEvents2_StatusTextChangeEventHandler StatusTextChange;

		// Token: 0x14000095 RID: 149
		// (add) Token: 0x06000364 RID: 868
		// (remove) Token: 0x06000365 RID: 869
		public virtual extern event global::SHDocVw.DWebBrowserEvents2_ProgressChangeEventHandler ProgressChange;

		// Token: 0x14000096 RID: 150
		// (add) Token: 0x06000366 RID: 870
		// (remove) Token: 0x06000367 RID: 871
		public virtual extern event global::SHDocVw.DWebBrowserEvents2_CommandStateChangeEventHandler CommandStateChange;

		// Token: 0x14000097 RID: 151
		// (add) Token: 0x06000368 RID: 872
		// (remove) Token: 0x06000369 RID: 873
		public virtual extern event global::SHDocVw.DWebBrowserEvents2_DownloadBeginEventHandler DownloadBegin;

		// Token: 0x14000098 RID: 152
		// (add) Token: 0x0600036A RID: 874
		// (remove) Token: 0x0600036B RID: 875
		public virtual extern event global::SHDocVw.DWebBrowserEvents2_DownloadCompleteEventHandler DownloadComplete;

		// Token: 0x14000099 RID: 153
		// (add) Token: 0x0600036C RID: 876
		// (remove) Token: 0x0600036D RID: 877
		public virtual extern event global::SHDocVw.DWebBrowserEvents2_TitleChangeEventHandler TitleChange;

		// Token: 0x1400009A RID: 154
		// (add) Token: 0x0600036E RID: 878
		// (remove) Token: 0x0600036F RID: 879
		public virtual extern event global::SHDocVw.DWebBrowserEvents2_PropertyChangeEventHandler PropertyChange;

		// Token: 0x1400009B RID: 155
		// (add) Token: 0x06000370 RID: 880
		// (remove) Token: 0x06000371 RID: 881
		public virtual extern event global::SHDocVw.DWebBrowserEvents2_BeforeNavigate2EventHandler BeforeNavigate2;

		// Token: 0x1400009C RID: 156
		// (add) Token: 0x06000372 RID: 882
		// (remove) Token: 0x06000373 RID: 883
		public virtual extern event global::SHDocVw.DWebBrowserEvents2_NewWindow2EventHandler NewWindow2;

		// Token: 0x1400009D RID: 157
		// (add) Token: 0x06000374 RID: 884
		// (remove) Token: 0x06000375 RID: 885
		public virtual extern event global::SHDocVw.DWebBrowserEvents2_NavigateComplete2EventHandler NavigateComplete2;

		// Token: 0x1400009E RID: 158
		// (add) Token: 0x06000376 RID: 886
		// (remove) Token: 0x06000377 RID: 887
		public virtual extern event global::SHDocVw.DWebBrowserEvents2_DocumentCompleteEventHandler DocumentComplete;

		// Token: 0x1400009F RID: 159
		// (add) Token: 0x06000378 RID: 888
		// (remove) Token: 0x06000379 RID: 889
		public virtual extern event global::SHDocVw.DWebBrowserEvents2_OnQuitEventHandler OnQuit;

		// Token: 0x140000A0 RID: 160
		// (add) Token: 0x0600037A RID: 890
		// (remove) Token: 0x0600037B RID: 891
		public virtual extern event global::SHDocVw.DWebBrowserEvents2_OnVisibleEventHandler OnVisible;

		// Token: 0x140000A1 RID: 161
		// (add) Token: 0x0600037C RID: 892
		// (remove) Token: 0x0600037D RID: 893
		public virtual extern event global::SHDocVw.DWebBrowserEvents2_OnToolBarEventHandler OnToolBar;

		// Token: 0x140000A2 RID: 162
		// (add) Token: 0x0600037E RID: 894
		// (remove) Token: 0x0600037F RID: 895
		public virtual extern event global::SHDocVw.DWebBrowserEvents2_OnMenuBarEventHandler OnMenuBar;

		// Token: 0x140000A3 RID: 163
		// (add) Token: 0x06000380 RID: 896
		// (remove) Token: 0x06000381 RID: 897
		public virtual extern event global::SHDocVw.DWebBrowserEvents2_OnStatusBarEventHandler OnStatusBar;

		// Token: 0x140000A4 RID: 164
		// (add) Token: 0x06000382 RID: 898
		// (remove) Token: 0x06000383 RID: 899
		public virtual extern event global::SHDocVw.DWebBrowserEvents2_OnFullScreenEventHandler OnFullScreen;

		// Token: 0x140000A5 RID: 165
		// (add) Token: 0x06000384 RID: 900
		// (remove) Token: 0x06000385 RID: 901
		public virtual extern event global::SHDocVw.DWebBrowserEvents2_OnTheaterModeEventHandler OnTheaterMode;

		// Token: 0x140000A6 RID: 166
		// (add) Token: 0x06000386 RID: 902
		// (remove) Token: 0x06000387 RID: 903
		public virtual extern event global::SHDocVw.DWebBrowserEvents2_WindowSetResizableEventHandler WindowSetResizable;

		// Token: 0x140000A7 RID: 167
		// (add) Token: 0x06000388 RID: 904
		// (remove) Token: 0x06000389 RID: 905
		public virtual extern event global::SHDocVw.DWebBrowserEvents2_WindowSetLeftEventHandler WindowSetLeft;

		// Token: 0x140000A8 RID: 168
		// (add) Token: 0x0600038A RID: 906
		// (remove) Token: 0x0600038B RID: 907
		public virtual extern event global::SHDocVw.DWebBrowserEvents2_WindowSetTopEventHandler WindowSetTop;

		// Token: 0x140000A9 RID: 169
		// (add) Token: 0x0600038C RID: 908
		// (remove) Token: 0x0600038D RID: 909
		public virtual extern event global::SHDocVw.DWebBrowserEvents2_WindowSetWidthEventHandler WindowSetWidth;

		// Token: 0x140000AA RID: 170
		// (add) Token: 0x0600038E RID: 910
		// (remove) Token: 0x0600038F RID: 911
		public virtual extern event global::SHDocVw.DWebBrowserEvents2_WindowSetHeightEventHandler WindowSetHeight;

		// Token: 0x140000AB RID: 171
		// (add) Token: 0x06000390 RID: 912
		// (remove) Token: 0x06000391 RID: 913
		public virtual extern event global::SHDocVw.DWebBrowserEvents2_WindowClosingEventHandler WindowClosing;

		// Token: 0x140000AC RID: 172
		// (add) Token: 0x06000392 RID: 914
		// (remove) Token: 0x06000393 RID: 915
		public virtual extern event global::SHDocVw.DWebBrowserEvents2_ClientToHostWindowEventHandler ClientToHostWindow;

		// Token: 0x140000AD RID: 173
		// (add) Token: 0x06000394 RID: 916
		// (remove) Token: 0x06000395 RID: 917
		public virtual extern event global::SHDocVw.DWebBrowserEvents2_SetSecureLockIconEventHandler SetSecureLockIcon;

		// Token: 0x140000AE RID: 174
		// (add) Token: 0x06000396 RID: 918
		// (remove) Token: 0x06000397 RID: 919
		public virtual extern event global::SHDocVw.DWebBrowserEvents2_FileDownloadEventHandler FileDownload;

		// Token: 0x140000AF RID: 175
		// (add) Token: 0x06000398 RID: 920
		// (remove) Token: 0x06000399 RID: 921
		public virtual extern event global::SHDocVw.DWebBrowserEvents2_NavigateErrorEventHandler NavigateError;

		// Token: 0x140000B0 RID: 176
		// (add) Token: 0x0600039A RID: 922
		// (remove) Token: 0x0600039B RID: 923
		public virtual extern event global::SHDocVw.DWebBrowserEvents2_PrintTemplateInstantiationEventHandler PrintTemplateInstantiation;

		// Token: 0x140000B1 RID: 177
		// (add) Token: 0x0600039C RID: 924
		// (remove) Token: 0x0600039D RID: 925
		public virtual extern event global::SHDocVw.DWebBrowserEvents2_PrintTemplateTeardownEventHandler PrintTemplateTeardown;

		// Token: 0x140000B2 RID: 178
		// (add) Token: 0x0600039E RID: 926
		// (remove) Token: 0x0600039F RID: 927
		public virtual extern event global::SHDocVw.DWebBrowserEvents2_UpdatePageStatusEventHandler UpdatePageStatus;

		// Token: 0x140000B3 RID: 179
		// (add) Token: 0x060003A0 RID: 928
		// (remove) Token: 0x060003A1 RID: 929
		public virtual extern event global::SHDocVw.DWebBrowserEvents2_PrivacyImpactedStateChangeEventHandler PrivacyImpactedStateChange;

		// Token: 0x140000B4 RID: 180
		// (add) Token: 0x060003A2 RID: 930
		// (remove) Token: 0x060003A3 RID: 931
		public virtual extern event global::SHDocVw.DWebBrowserEvents_BeforeNavigateEventHandler BeforeNavigate;

		// Token: 0x140000B5 RID: 181
		// (add) Token: 0x060003A4 RID: 932
		// (remove) Token: 0x060003A5 RID: 933
		public virtual extern event global::SHDocVw.DWebBrowserEvents_NavigateCompleteEventHandler NavigateComplete;

		// Token: 0x140000B6 RID: 182
		// (add) Token: 0x060003A6 RID: 934
		// (remove) Token: 0x060003A7 RID: 935
		public virtual extern event global::SHDocVw.DWebBrowserEvents_StatusTextChangeEventHandler DWebBrowserEvents_Event_StatusTextChange;

		// Token: 0x140000B7 RID: 183
		// (add) Token: 0x060003A8 RID: 936
		// (remove) Token: 0x060003A9 RID: 937
		public virtual extern event global::SHDocVw.DWebBrowserEvents_ProgressChangeEventHandler DWebBrowserEvents_Event_ProgressChange;

		// Token: 0x140000B8 RID: 184
		// (add) Token: 0x060003AA RID: 938
		// (remove) Token: 0x060003AB RID: 939
		public virtual extern event global::SHDocVw.DWebBrowserEvents_DownloadCompleteEventHandler DWebBrowserEvents_Event_DownloadComplete;

		// Token: 0x140000B9 RID: 185
		// (add) Token: 0x060003AC RID: 940
		// (remove) Token: 0x060003AD RID: 941
		public virtual extern event global::SHDocVw.DWebBrowserEvents_CommandStateChangeEventHandler DWebBrowserEvents_Event_CommandStateChange;

		// Token: 0x140000BA RID: 186
		// (add) Token: 0x060003AE RID: 942
		// (remove) Token: 0x060003AF RID: 943
		public virtual extern event global::SHDocVw.DWebBrowserEvents_DownloadBeginEventHandler DWebBrowserEvents_Event_DownloadBegin;

		// Token: 0x140000BB RID: 187
		// (add) Token: 0x060003B0 RID: 944
		// (remove) Token: 0x060003B1 RID: 945
		public virtual extern event global::SHDocVw.DWebBrowserEvents_NewWindowEventHandler NewWindow;

		// Token: 0x140000BC RID: 188
		// (add) Token: 0x060003B2 RID: 946
		// (remove) Token: 0x060003B3 RID: 947
		public virtual extern event global::SHDocVw.DWebBrowserEvents_TitleChangeEventHandler DWebBrowserEvents_Event_TitleChange;

		// Token: 0x140000BD RID: 189
		// (add) Token: 0x060003B4 RID: 948
		// (remove) Token: 0x060003B5 RID: 949
		public virtual extern event global::SHDocVw.DWebBrowserEvents_FrameBeforeNavigateEventHandler FrameBeforeNavigate;

		// Token: 0x140000BE RID: 190
		// (add) Token: 0x060003B6 RID: 950
		// (remove) Token: 0x060003B7 RID: 951
		public virtual extern event global::SHDocVw.DWebBrowserEvents_FrameNavigateCompleteEventHandler FrameNavigateComplete;

		// Token: 0x140000BF RID: 191
		// (add) Token: 0x060003B8 RID: 952
		// (remove) Token: 0x060003B9 RID: 953
		public virtual extern event global::SHDocVw.DWebBrowserEvents_FrameNewWindowEventHandler FrameNewWindow;

		// Token: 0x140000C0 RID: 192
		// (add) Token: 0x060003BA RID: 954
		// (remove) Token: 0x060003BB RID: 955
		public virtual extern event global::SHDocVw.DWebBrowserEvents_QuitEventHandler DWebBrowserEvents_Event_Quit;

		// Token: 0x140000C1 RID: 193
		// (add) Token: 0x060003BC RID: 956
		// (remove) Token: 0x060003BD RID: 957
		public virtual extern event global::SHDocVw.DWebBrowserEvents_WindowMoveEventHandler WindowMove;

		// Token: 0x140000C2 RID: 194
		// (add) Token: 0x060003BE RID: 958
		// (remove) Token: 0x060003BF RID: 959
		public virtual extern event global::SHDocVw.DWebBrowserEvents_WindowResizeEventHandler WindowResize;

		// Token: 0x140000C3 RID: 195
		// (add) Token: 0x060003C0 RID: 960
		// (remove) Token: 0x060003C1 RID: 961
		public virtual extern event global::SHDocVw.DWebBrowserEvents_WindowActivateEventHandler WindowActivate;

		// Token: 0x140000C4 RID: 196
		// (add) Token: 0x060003C2 RID: 962
		// (remove) Token: 0x060003C3 RID: 963
		public virtual extern event global::SHDocVw.DWebBrowserEvents_PropertyChangeEventHandler DWebBrowserEvents_Event_PropertyChange;
	}
}
