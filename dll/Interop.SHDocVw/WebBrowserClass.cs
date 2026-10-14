using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SHDocVw
{
	// Token: 0x02000042 RID: 66
	[global::System.Runtime.InteropServices.Guid("8856F961-340A-11D0-A96B-00C04FD705A2")]
	[global::System.Runtime.InteropServices.ComSourceInterfaces("SHDocVw.DWebBrowserEvents2\0SHDocVw.DWebBrowserEvents\0\0")]
	[global::System.Reflection.DefaultMember("Name")]
	[global::System.Runtime.InteropServices.ClassInterface(0)]
	[global::System.Runtime.InteropServices.TypeLibType(34)]
	[global::System.Runtime.InteropServices.ComImport]
	public class WebBrowserClass : global::SHDocVw.IWebBrowser2, global::SHDocVw.WebBrowser, global::SHDocVw.DWebBrowserEvents2_Event, global::SHDocVw.IWebBrowser, global::SHDocVw.DWebBrowserEvents_Event
	{
		// Token: 0x06000238 RID: 568
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public extern WebBrowserClass();

		// Token: 0x06000239 RID: 569
		[global::System.Runtime.InteropServices.DispId(100)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void GoBack();

		// Token: 0x0600023A RID: 570
		[global::System.Runtime.InteropServices.DispId(101)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void GoForward();

		// Token: 0x0600023B RID: 571
		[global::System.Runtime.InteropServices.DispId(102)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void GoHome();

		// Token: 0x0600023C RID: 572
		[global::System.Runtime.InteropServices.DispId(103)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void GoSearch();

		// Token: 0x0600023D RID: 573
		[global::System.Runtime.InteropServices.DispId(104)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void Navigate([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string URL, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object Flags, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object TargetFrameName, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object PostData, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object Headers);

		// Token: 0x0600023E RID: 574
		[global::System.Runtime.InteropServices.DispId(-550)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void Refresh();

		// Token: 0x0600023F RID: 575
		[global::System.Runtime.InteropServices.DispId(105)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void Refresh2([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object Level);

		// Token: 0x06000240 RID: 576
		[global::System.Runtime.InteropServices.DispId(106)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void Stop();

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000241 RID: 577
		[global::System.Runtime.InteropServices.DispId(200)]
		public virtual extern object Application { [global::System.Runtime.InteropServices.DispId(200)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] get; }

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06000242 RID: 578
		[global::System.Runtime.InteropServices.DispId(201)]
		public virtual extern object Parent { [global::System.Runtime.InteropServices.DispId(201)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] get; }

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x06000243 RID: 579
		[global::System.Runtime.InteropServices.DispId(202)]
		public virtual extern object Container { [global::System.Runtime.InteropServices.DispId(202)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] get; }

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x06000244 RID: 580
		[global::System.Runtime.InteropServices.DispId(203)]
		public virtual extern object Document { [global::System.Runtime.InteropServices.DispId(203)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] get; }

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x06000245 RID: 581
		[global::System.Runtime.InteropServices.DispId(204)]
		public virtual extern bool TopLevelContainer { [global::System.Runtime.InteropServices.DispId(204)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x06000246 RID: 582
		[global::System.Runtime.InteropServices.DispId(205)]
		public virtual extern string Type { [global::System.Runtime.InteropServices.DispId(205)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x06000247 RID: 583
		// (set) Token: 0x06000248 RID: 584
		[global::System.Runtime.InteropServices.DispId(206)]
		public virtual extern int Left { [global::System.Runtime.InteropServices.DispId(206)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(206)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x06000249 RID: 585
		// (set) Token: 0x0600024A RID: 586
		[global::System.Runtime.InteropServices.DispId(207)]
		public virtual extern int Top { [global::System.Runtime.InteropServices.DispId(207)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(207)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x0600024B RID: 587
		// (set) Token: 0x0600024C RID: 588
		[global::System.Runtime.InteropServices.DispId(208)]
		public virtual extern int Width { [global::System.Runtime.InteropServices.DispId(208)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(208)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x0600024D RID: 589
		// (set) Token: 0x0600024E RID: 590
		[global::System.Runtime.InteropServices.DispId(209)]
		public virtual extern int Height { [global::System.Runtime.InteropServices.DispId(209)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(209)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x0600024F RID: 591
		[global::System.Runtime.InteropServices.DispId(210)]
		public virtual extern string LocationName { [global::System.Runtime.InteropServices.DispId(210)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x06000250 RID: 592
		[global::System.Runtime.InteropServices.DispId(211)]
		public virtual extern string LocationURL { [global::System.Runtime.InteropServices.DispId(211)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x06000251 RID: 593
		[global::System.Runtime.InteropServices.DispId(212)]
		public virtual extern bool Busy { [global::System.Runtime.InteropServices.DispId(212)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x06000252 RID: 594
		[global::System.Runtime.InteropServices.DispId(300)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void Quit();

		// Token: 0x06000253 RID: 595
		[global::System.Runtime.InteropServices.DispId(301)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void ClientToWindow([global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Out] ref int pcx, [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Out] ref int pcy);

		// Token: 0x06000254 RID: 596
		[global::System.Runtime.InteropServices.DispId(302)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void PutProperty([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string Property, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] object vtValue);

		// Token: 0x06000255 RID: 597
		[global::System.Runtime.InteropServices.DispId(303)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)]
		public virtual extern object GetProperty([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string Property);

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x06000256 RID: 598
		[global::System.Runtime.InteropServices.DispId(0)]
		[global::System.Runtime.CompilerServices.IndexerName("Name")]
		public virtual extern string Name { [global::System.Runtime.InteropServices.DispId(0)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x06000257 RID: 599
		[global::System.Runtime.InteropServices.DispId(-515)]
		public virtual extern int HWND { [global::System.Runtime.InteropServices.DispId(-515)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x06000258 RID: 600
		[global::System.Runtime.InteropServices.DispId(400)]
		public virtual extern string FullName { [global::System.Runtime.InteropServices.DispId(400)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x06000259 RID: 601
		[global::System.Runtime.InteropServices.DispId(401)]
		public virtual extern string Path { [global::System.Runtime.InteropServices.DispId(401)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x0600025A RID: 602
		// (set) Token: 0x0600025B RID: 603
		[global::System.Runtime.InteropServices.DispId(402)]
		public virtual extern bool Visible { [global::System.Runtime.InteropServices.DispId(402)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(402)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x0600025C RID: 604
		// (set) Token: 0x0600025D RID: 605
		[global::System.Runtime.InteropServices.DispId(403)]
		public virtual extern bool StatusBar { [global::System.Runtime.InteropServices.DispId(403)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(403)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x0600025E RID: 606
		// (set) Token: 0x0600025F RID: 607
		[global::System.Runtime.InteropServices.DispId(404)]
		public virtual extern string StatusText { [global::System.Runtime.InteropServices.DispId(404)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(404)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x06000260 RID: 608
		// (set) Token: 0x06000261 RID: 609
		[global::System.Runtime.InteropServices.DispId(405)]
		public virtual extern int ToolBar { [global::System.Runtime.InteropServices.DispId(405)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(405)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000262 RID: 610
		// (set) Token: 0x06000263 RID: 611
		[global::System.Runtime.InteropServices.DispId(406)]
		public virtual extern bool MenuBar { [global::System.Runtime.InteropServices.DispId(406)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(406)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000264 RID: 612
		// (set) Token: 0x06000265 RID: 613
		[global::System.Runtime.InteropServices.DispId(407)]
		public virtual extern bool FullScreen { [global::System.Runtime.InteropServices.DispId(407)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(407)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x06000266 RID: 614
		[global::System.Runtime.InteropServices.DispId(500)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void Navigate2([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] ref object URL, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object Flags, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object TargetFrameName, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object PostData, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object Headers);

		// Token: 0x06000267 RID: 615
		[global::System.Runtime.InteropServices.DispId(501)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern global::SHDocVw.OLECMDF QueryStatusWB([global::System.Runtime.InteropServices.In] global::SHDocVw.OLECMDID cmdID);

		// Token: 0x06000268 RID: 616
		[global::System.Runtime.InteropServices.DispId(502)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void ExecWB([global::System.Runtime.InteropServices.In] global::SHDocVw.OLECMDID cmdID, [global::System.Runtime.InteropServices.In] global::SHDocVw.OLECMDEXECOPT cmdexecopt, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object pvaIn, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Out] [global::System.Runtime.InteropServices.Optional] ref object pvaOut);

		// Token: 0x06000269 RID: 617
		[global::System.Runtime.InteropServices.DispId(503)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void ShowBrowserBar([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] ref object pvaClsid, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object pvarShow, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object pvarSize);

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x0600026A RID: 618
		[global::System.Runtime.InteropServices.DispId(-525)]
		public virtual extern global::SHDocVw.tagREADYSTATE ReadyState { [global::System.Runtime.InteropServices.DispId(-525)] [global::System.Runtime.InteropServices.TypeLibFunc(4)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x0600026B RID: 619
		// (set) Token: 0x0600026C RID: 620
		[global::System.Runtime.InteropServices.DispId(550)]
		public virtual extern bool Offline { [global::System.Runtime.InteropServices.DispId(550)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(550)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x0600026D RID: 621
		// (set) Token: 0x0600026E RID: 622
		[global::System.Runtime.InteropServices.DispId(551)]
		public virtual extern bool Silent { [global::System.Runtime.InteropServices.DispId(551)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(551)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x0600026F RID: 623
		// (set) Token: 0x06000270 RID: 624
		[global::System.Runtime.InteropServices.DispId(552)]
		public virtual extern bool RegisterAsBrowser { [global::System.Runtime.InteropServices.DispId(552)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(552)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000271 RID: 625
		// (set) Token: 0x06000272 RID: 626
		[global::System.Runtime.InteropServices.DispId(553)]
		public virtual extern bool RegisterAsDropTarget { [global::System.Runtime.InteropServices.DispId(553)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(553)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000273 RID: 627
		// (set) Token: 0x06000274 RID: 628
		[global::System.Runtime.InteropServices.DispId(554)]
		public virtual extern bool TheaterMode { [global::System.Runtime.InteropServices.DispId(554)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(554)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000275 RID: 629
		// (set) Token: 0x06000276 RID: 630
		[global::System.Runtime.InteropServices.DispId(555)]
		public virtual extern bool AddressBar { [global::System.Runtime.InteropServices.DispId(555)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(555)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x06000277 RID: 631
		// (set) Token: 0x06000278 RID: 632
		[global::System.Runtime.InteropServices.DispId(556)]
		public virtual extern bool Resizable { [global::System.Runtime.InteropServices.DispId(556)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(556)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x06000279 RID: 633
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void IWebBrowser_GoBack();

		// Token: 0x0600027A RID: 634
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void IWebBrowser_GoForward();

		// Token: 0x0600027B RID: 635
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void IWebBrowser_GoHome();

		// Token: 0x0600027C RID: 636
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void IWebBrowser_GoSearch();

		// Token: 0x0600027D RID: 637
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void IWebBrowser_Navigate([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string URL, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object Flags, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object TargetFrameName, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object PostData, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object Headers);

		// Token: 0x0600027E RID: 638
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void IWebBrowser_Refresh();

		// Token: 0x0600027F RID: 639
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void IWebBrowser_Refresh2([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object Level);

		// Token: 0x06000280 RID: 640
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void IWebBrowser_Stop();

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x06000281 RID: 641
		public virtual extern object IWebBrowser_Application { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] get; }

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x06000282 RID: 642
		public virtual extern object IWebBrowser_Parent { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] get; }

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x06000283 RID: 643
		public virtual extern object IWebBrowser_Container { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] get; }

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x06000284 RID: 644
		public virtual extern object IWebBrowser_Document { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] get; }

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x06000285 RID: 645
		public virtual extern bool IWebBrowser_TopLevelContainer { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x06000286 RID: 646
		public virtual extern string IWebBrowser_Type { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x06000287 RID: 647
		// (set) Token: 0x06000288 RID: 648
		public virtual extern int IWebBrowser_Left { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x06000289 RID: 649
		// (set) Token: 0x0600028A RID: 650
		public virtual extern int IWebBrowser_Top { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x0600028B RID: 651
		// (set) Token: 0x0600028C RID: 652
		public virtual extern int IWebBrowser_Width { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x0600028D RID: 653
		// (set) Token: 0x0600028E RID: 654
		public virtual extern int IWebBrowser_Height { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x0600028F RID: 655
		public virtual extern string IWebBrowser_LocationName { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x06000290 RID: 656
		public virtual extern string IWebBrowser_LocationURL { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x06000291 RID: 657
		public virtual extern bool IWebBrowser_Busy { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x14000063 RID: 99
		// (add) Token: 0x06000292 RID: 658
		// (remove) Token: 0x06000293 RID: 659
		public virtual extern event global::SHDocVw.DWebBrowserEvents2_StatusTextChangeEventHandler StatusTextChange;

		// Token: 0x14000064 RID: 100
		// (add) Token: 0x06000294 RID: 660
		// (remove) Token: 0x06000295 RID: 661
		public virtual extern event global::SHDocVw.DWebBrowserEvents2_ProgressChangeEventHandler ProgressChange;

		// Token: 0x14000065 RID: 101
		// (add) Token: 0x06000296 RID: 662
		// (remove) Token: 0x06000297 RID: 663
		public virtual extern event global::SHDocVw.DWebBrowserEvents2_CommandStateChangeEventHandler CommandStateChange;

		// Token: 0x14000066 RID: 102
		// (add) Token: 0x06000298 RID: 664
		// (remove) Token: 0x06000299 RID: 665
		public virtual extern event global::SHDocVw.DWebBrowserEvents2_DownloadBeginEventHandler DownloadBegin;

		// Token: 0x14000067 RID: 103
		// (add) Token: 0x0600029A RID: 666
		// (remove) Token: 0x0600029B RID: 667
		public virtual extern event global::SHDocVw.DWebBrowserEvents2_DownloadCompleteEventHandler DownloadComplete;

		// Token: 0x14000068 RID: 104
		// (add) Token: 0x0600029C RID: 668
		// (remove) Token: 0x0600029D RID: 669
		public virtual extern event global::SHDocVw.DWebBrowserEvents2_TitleChangeEventHandler TitleChange;

		// Token: 0x14000069 RID: 105
		// (add) Token: 0x0600029E RID: 670
		// (remove) Token: 0x0600029F RID: 671
		public virtual extern event global::SHDocVw.DWebBrowserEvents2_PropertyChangeEventHandler PropertyChange;

		// Token: 0x1400006A RID: 106
		// (add) Token: 0x060002A0 RID: 672
		// (remove) Token: 0x060002A1 RID: 673
		public virtual extern event global::SHDocVw.DWebBrowserEvents2_BeforeNavigate2EventHandler BeforeNavigate2;

		// Token: 0x1400006B RID: 107
		// (add) Token: 0x060002A2 RID: 674
		// (remove) Token: 0x060002A3 RID: 675
		public virtual extern event global::SHDocVw.DWebBrowserEvents2_NewWindow2EventHandler NewWindow2;

		// Token: 0x1400006C RID: 108
		// (add) Token: 0x060002A4 RID: 676
		// (remove) Token: 0x060002A5 RID: 677
		public virtual extern event global::SHDocVw.DWebBrowserEvents2_NavigateComplete2EventHandler NavigateComplete2;

		// Token: 0x1400006D RID: 109
		// (add) Token: 0x060002A6 RID: 678
		// (remove) Token: 0x060002A7 RID: 679
		public virtual extern event global::SHDocVw.DWebBrowserEvents2_DocumentCompleteEventHandler DocumentComplete;

		// Token: 0x1400006E RID: 110
		// (add) Token: 0x060002A8 RID: 680
		// (remove) Token: 0x060002A9 RID: 681
		public virtual extern event global::SHDocVw.DWebBrowserEvents2_OnQuitEventHandler OnQuit;

		// Token: 0x1400006F RID: 111
		// (add) Token: 0x060002AA RID: 682
		// (remove) Token: 0x060002AB RID: 683
		public virtual extern event global::SHDocVw.DWebBrowserEvents2_OnVisibleEventHandler OnVisible;

		// Token: 0x14000070 RID: 112
		// (add) Token: 0x060002AC RID: 684
		// (remove) Token: 0x060002AD RID: 685
		public virtual extern event global::SHDocVw.DWebBrowserEvents2_OnToolBarEventHandler OnToolBar;

		// Token: 0x14000071 RID: 113
		// (add) Token: 0x060002AE RID: 686
		// (remove) Token: 0x060002AF RID: 687
		public virtual extern event global::SHDocVw.DWebBrowserEvents2_OnMenuBarEventHandler OnMenuBar;

		// Token: 0x14000072 RID: 114
		// (add) Token: 0x060002B0 RID: 688
		// (remove) Token: 0x060002B1 RID: 689
		public virtual extern event global::SHDocVw.DWebBrowserEvents2_OnStatusBarEventHandler OnStatusBar;

		// Token: 0x14000073 RID: 115
		// (add) Token: 0x060002B2 RID: 690
		// (remove) Token: 0x060002B3 RID: 691
		public virtual extern event global::SHDocVw.DWebBrowserEvents2_OnFullScreenEventHandler OnFullScreen;

		// Token: 0x14000074 RID: 116
		// (add) Token: 0x060002B4 RID: 692
		// (remove) Token: 0x060002B5 RID: 693
		public virtual extern event global::SHDocVw.DWebBrowserEvents2_OnTheaterModeEventHandler OnTheaterMode;

		// Token: 0x14000075 RID: 117
		// (add) Token: 0x060002B6 RID: 694
		// (remove) Token: 0x060002B7 RID: 695
		public virtual extern event global::SHDocVw.DWebBrowserEvents2_WindowSetResizableEventHandler WindowSetResizable;

		// Token: 0x14000076 RID: 118
		// (add) Token: 0x060002B8 RID: 696
		// (remove) Token: 0x060002B9 RID: 697
		public virtual extern event global::SHDocVw.DWebBrowserEvents2_WindowSetLeftEventHandler WindowSetLeft;

		// Token: 0x14000077 RID: 119
		// (add) Token: 0x060002BA RID: 698
		// (remove) Token: 0x060002BB RID: 699
		public virtual extern event global::SHDocVw.DWebBrowserEvents2_WindowSetTopEventHandler WindowSetTop;

		// Token: 0x14000078 RID: 120
		// (add) Token: 0x060002BC RID: 700
		// (remove) Token: 0x060002BD RID: 701
		public virtual extern event global::SHDocVw.DWebBrowserEvents2_WindowSetWidthEventHandler WindowSetWidth;

		// Token: 0x14000079 RID: 121
		// (add) Token: 0x060002BE RID: 702
		// (remove) Token: 0x060002BF RID: 703
		public virtual extern event global::SHDocVw.DWebBrowserEvents2_WindowSetHeightEventHandler WindowSetHeight;

		// Token: 0x1400007A RID: 122
		// (add) Token: 0x060002C0 RID: 704
		// (remove) Token: 0x060002C1 RID: 705
		public virtual extern event global::SHDocVw.DWebBrowserEvents2_WindowClosingEventHandler WindowClosing;

		// Token: 0x1400007B RID: 123
		// (add) Token: 0x060002C2 RID: 706
		// (remove) Token: 0x060002C3 RID: 707
		public virtual extern event global::SHDocVw.DWebBrowserEvents2_ClientToHostWindowEventHandler ClientToHostWindow;

		// Token: 0x1400007C RID: 124
		// (add) Token: 0x060002C4 RID: 708
		// (remove) Token: 0x060002C5 RID: 709
		public virtual extern event global::SHDocVw.DWebBrowserEvents2_SetSecureLockIconEventHandler SetSecureLockIcon;

		// Token: 0x1400007D RID: 125
		// (add) Token: 0x060002C6 RID: 710
		// (remove) Token: 0x060002C7 RID: 711
		public virtual extern event global::SHDocVw.DWebBrowserEvents2_FileDownloadEventHandler FileDownload;

		// Token: 0x1400007E RID: 126
		// (add) Token: 0x060002C8 RID: 712
		// (remove) Token: 0x060002C9 RID: 713
		public virtual extern event global::SHDocVw.DWebBrowserEvents2_NavigateErrorEventHandler NavigateError;

		// Token: 0x1400007F RID: 127
		// (add) Token: 0x060002CA RID: 714
		// (remove) Token: 0x060002CB RID: 715
		public virtual extern event global::SHDocVw.DWebBrowserEvents2_PrintTemplateInstantiationEventHandler PrintTemplateInstantiation;

		// Token: 0x14000080 RID: 128
		// (add) Token: 0x060002CC RID: 716
		// (remove) Token: 0x060002CD RID: 717
		public virtual extern event global::SHDocVw.DWebBrowserEvents2_PrintTemplateTeardownEventHandler PrintTemplateTeardown;

		// Token: 0x14000081 RID: 129
		// (add) Token: 0x060002CE RID: 718
		// (remove) Token: 0x060002CF RID: 719
		public virtual extern event global::SHDocVw.DWebBrowserEvents2_UpdatePageStatusEventHandler UpdatePageStatus;

		// Token: 0x14000082 RID: 130
		// (add) Token: 0x060002D0 RID: 720
		// (remove) Token: 0x060002D1 RID: 721
		public virtual extern event global::SHDocVw.DWebBrowserEvents2_PrivacyImpactedStateChangeEventHandler PrivacyImpactedStateChange;

		// Token: 0x14000083 RID: 131
		// (add) Token: 0x060002D2 RID: 722
		// (remove) Token: 0x060002D3 RID: 723
		public virtual extern event global::SHDocVw.DWebBrowserEvents_BeforeNavigateEventHandler BeforeNavigate;

		// Token: 0x14000084 RID: 132
		// (add) Token: 0x060002D4 RID: 724
		// (remove) Token: 0x060002D5 RID: 725
		public virtual extern event global::SHDocVw.DWebBrowserEvents_NavigateCompleteEventHandler NavigateComplete;

		// Token: 0x14000085 RID: 133
		// (add) Token: 0x060002D6 RID: 726
		// (remove) Token: 0x060002D7 RID: 727
		public virtual extern event global::SHDocVw.DWebBrowserEvents_StatusTextChangeEventHandler DWebBrowserEvents_Event_StatusTextChange;

		// Token: 0x14000086 RID: 134
		// (add) Token: 0x060002D8 RID: 728
		// (remove) Token: 0x060002D9 RID: 729
		public virtual extern event global::SHDocVw.DWebBrowserEvents_ProgressChangeEventHandler DWebBrowserEvents_Event_ProgressChange;

		// Token: 0x14000087 RID: 135
		// (add) Token: 0x060002DA RID: 730
		// (remove) Token: 0x060002DB RID: 731
		public virtual extern event global::SHDocVw.DWebBrowserEvents_DownloadCompleteEventHandler DWebBrowserEvents_Event_DownloadComplete;

		// Token: 0x14000088 RID: 136
		// (add) Token: 0x060002DC RID: 732
		// (remove) Token: 0x060002DD RID: 733
		public virtual extern event global::SHDocVw.DWebBrowserEvents_CommandStateChangeEventHandler DWebBrowserEvents_Event_CommandStateChange;

		// Token: 0x14000089 RID: 137
		// (add) Token: 0x060002DE RID: 734
		// (remove) Token: 0x060002DF RID: 735
		public virtual extern event global::SHDocVw.DWebBrowserEvents_DownloadBeginEventHandler DWebBrowserEvents_Event_DownloadBegin;

		// Token: 0x1400008A RID: 138
		// (add) Token: 0x060002E0 RID: 736
		// (remove) Token: 0x060002E1 RID: 737
		public virtual extern event global::SHDocVw.DWebBrowserEvents_NewWindowEventHandler NewWindow;

		// Token: 0x1400008B RID: 139
		// (add) Token: 0x060002E2 RID: 738
		// (remove) Token: 0x060002E3 RID: 739
		public virtual extern event global::SHDocVw.DWebBrowserEvents_TitleChangeEventHandler DWebBrowserEvents_Event_TitleChange;

		// Token: 0x1400008C RID: 140
		// (add) Token: 0x060002E4 RID: 740
		// (remove) Token: 0x060002E5 RID: 741
		public virtual extern event global::SHDocVw.DWebBrowserEvents_FrameBeforeNavigateEventHandler FrameBeforeNavigate;

		// Token: 0x1400008D RID: 141
		// (add) Token: 0x060002E6 RID: 742
		// (remove) Token: 0x060002E7 RID: 743
		public virtual extern event global::SHDocVw.DWebBrowserEvents_FrameNavigateCompleteEventHandler FrameNavigateComplete;

		// Token: 0x1400008E RID: 142
		// (add) Token: 0x060002E8 RID: 744
		// (remove) Token: 0x060002E9 RID: 745
		public virtual extern event global::SHDocVw.DWebBrowserEvents_FrameNewWindowEventHandler FrameNewWindow;

		// Token: 0x1400008F RID: 143
		// (add) Token: 0x060002EA RID: 746
		// (remove) Token: 0x060002EB RID: 747
		public virtual extern event global::SHDocVw.DWebBrowserEvents_QuitEventHandler DWebBrowserEvents_Event_Quit;

		// Token: 0x14000090 RID: 144
		// (add) Token: 0x060002EC RID: 748
		// (remove) Token: 0x060002ED RID: 749
		public virtual extern event global::SHDocVw.DWebBrowserEvents_WindowMoveEventHandler WindowMove;

		// Token: 0x14000091 RID: 145
		// (add) Token: 0x060002EE RID: 750
		// (remove) Token: 0x060002EF RID: 751
		public virtual extern event global::SHDocVw.DWebBrowserEvents_WindowResizeEventHandler WindowResize;

		// Token: 0x14000092 RID: 146
		// (add) Token: 0x060002F0 RID: 752
		// (remove) Token: 0x060002F1 RID: 753
		public virtual extern event global::SHDocVw.DWebBrowserEvents_WindowActivateEventHandler WindowActivate;

		// Token: 0x14000093 RID: 147
		// (add) Token: 0x060002F2 RID: 754
		// (remove) Token: 0x060002F3 RID: 755
		public virtual extern event global::SHDocVw.DWebBrowserEvents_PropertyChangeEventHandler DWebBrowserEvents_Event_PropertyChange;
	}
}
