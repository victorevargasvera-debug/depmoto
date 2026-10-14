using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace mshtml
{
	// Token: 0x020007C2 RID: 1986
	[global::System.Runtime.InteropServices.ClassInterface(0)]
	[global::System.Runtime.InteropServices.ComSourceInterfaces("mshtml.HTMLWindowEvents\0mshtml.HTMLWindowEvents2\0\0")]
	[global::System.Reflection.DefaultMember("item")]
	[global::System.Runtime.InteropServices.Guid("D48A6EC6-6A4A-11CF-94A7-444553540000")]
	[global::System.Runtime.InteropServices.TypeLibType(2)]
	[global::System.Runtime.InteropServices.ComImport]
	public class HTMLWindow2Class : global::mshtml.DispHTMLWindow2, global::mshtml.HTMLWindow2, global::mshtml.HTMLWindowEvents_Event, global::mshtml.IHTMLWindow2, global::mshtml.IHTMLWindow3, global::mshtml.IHTMLWindow4, global::mshtml.HTMLWindowEvents2_Event
	{
		// Token: 0x0600D7C5 RID: 55237
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public extern HTMLWindow2Class();

		// Token: 0x0600D7C6 RID: 55238
		[global::System.Runtime.InteropServices.DispId(0)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)]
		public virtual extern object item([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] ref object pvarIndex);

		// Token: 0x170047EF RID: 18415
		// (get) Token: 0x0600D7C7 RID: 55239
		[global::System.Runtime.InteropServices.DispId(1001)]
		public virtual extern int length { [global::System.Runtime.InteropServices.DispId(1001)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x170047F0 RID: 18416
		// (get) Token: 0x0600D7C8 RID: 55240
		[global::System.Runtime.InteropServices.DispId(1100)]
		public virtual extern global::mshtml.FramesCollection frames { [global::System.Runtime.InteropServices.DispId(1100)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x170047F1 RID: 18417
		// (get) Token: 0x0600D7CA RID: 55242
		// (set) Token: 0x0600D7C9 RID: 55241
		[global::System.Runtime.InteropServices.DispId(1101)]
		public virtual extern string defaultStatus { [global::System.Runtime.InteropServices.DispId(1101)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(1101)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] set; }

		// Token: 0x170047F2 RID: 18418
		// (get) Token: 0x0600D7CC RID: 55244
		// (set) Token: 0x0600D7CB RID: 55243
		[global::System.Runtime.InteropServices.DispId(1102)]
		public virtual extern string status { [global::System.Runtime.InteropServices.DispId(1102)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(1102)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] set; }

		// Token: 0x0600D7CD RID: 55245
		[global::System.Runtime.InteropServices.DispId(1104)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void clearTimeout([global::System.Runtime.InteropServices.In] int timerID);

		// Token: 0x0600D7CE RID: 55246
		[global::System.Runtime.InteropServices.DispId(1105)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void alert([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string message = "");

		// Token: 0x0600D7CF RID: 55247
		[global::System.Runtime.InteropServices.DispId(1110)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern bool confirm([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string message = "");

		// Token: 0x0600D7D0 RID: 55248
		[global::System.Runtime.InteropServices.DispId(1111)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)]
		public virtual extern object prompt([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string message = "", [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string defstr = "undefined");

		// Token: 0x170047F3 RID: 18419
		// (get) Token: 0x0600D7D1 RID: 55249
		[global::System.Runtime.InteropServices.DispId(1125)]
		public virtual extern global::mshtml.HTMLImageElementFactory Image { [global::System.Runtime.InteropServices.DispId(1125)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x170047F4 RID: 18420
		// (get) Token: 0x0600D7D2 RID: 55250
		[global::System.Runtime.InteropServices.DispId(14)]
		public virtual extern global::mshtml.HTMLLocation location { [global::System.Runtime.InteropServices.DispId(14)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x170047F5 RID: 18421
		// (get) Token: 0x0600D7D3 RID: 55251
		[global::System.Runtime.InteropServices.DispId(2)]
		public virtual extern global::mshtml.HTMLHistory history { [global::System.Runtime.InteropServices.DispId(2)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x0600D7D4 RID: 55252
		[global::System.Runtime.InteropServices.DispId(3)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void close();

		// Token: 0x170047F6 RID: 18422
		// (get) Token: 0x0600D7D6 RID: 55254
		// (set) Token: 0x0600D7D5 RID: 55253
		[global::System.Runtime.InteropServices.DispId(4)]
		public virtual extern object opener { [global::System.Runtime.InteropServices.DispId(4)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(4)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x170047F7 RID: 18423
		// (get) Token: 0x0600D7D7 RID: 55255
		[global::System.Runtime.InteropServices.DispId(5)]
		public virtual extern global::mshtml.HTMLNavigator navigator { [global::System.Runtime.InteropServices.DispId(5)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x170047F8 RID: 18424
		// (get) Token: 0x0600D7D9 RID: 55257
		// (set) Token: 0x0600D7D8 RID: 55256
		[global::System.Runtime.InteropServices.DispId(11)]
		public virtual extern string name { [global::System.Runtime.InteropServices.DispId(11)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(11)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] set; }

		// Token: 0x170047F9 RID: 18425
		// (get) Token: 0x0600D7DA RID: 55258
		[global::System.Runtime.InteropServices.DispId(12)]
		public virtual extern global::mshtml.IHTMLWindow2 parent { [global::System.Runtime.InteropServices.DispId(12)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x0600D7DB RID: 55259
		[global::System.Runtime.InteropServices.DispId(13)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		public virtual extern global::mshtml.IHTMLWindow2 open([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string url = "", [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string name = "", [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string features = "", [global::System.Runtime.InteropServices.In] bool replace = false);

		// Token: 0x170047FA RID: 18426
		// (get) Token: 0x0600D7DC RID: 55260
		[global::System.Runtime.InteropServices.DispId(20)]
		public virtual extern global::mshtml.IHTMLWindow2 self { [global::System.Runtime.InteropServices.DispId(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x170047FB RID: 18427
		// (get) Token: 0x0600D7DD RID: 55261
		[global::System.Runtime.InteropServices.DispId(21)]
		public virtual extern global::mshtml.IHTMLWindow2 top { [global::System.Runtime.InteropServices.DispId(21)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x170047FC RID: 18428
		// (get) Token: 0x0600D7DE RID: 55262
		[global::System.Runtime.InteropServices.DispId(22)]
		public virtual extern global::mshtml.IHTMLWindow2 window { [global::System.Runtime.InteropServices.DispId(22)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x0600D7DF RID: 55263
		[global::System.Runtime.InteropServices.DispId(25)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void navigate([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string url);

		// Token: 0x170047FD RID: 18429
		// (get) Token: 0x0600D7E1 RID: 55265
		// (set) Token: 0x0600D7E0 RID: 55264
		[global::System.Runtime.InteropServices.DispId(-2147412098)]
		public virtual extern object onfocus { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412098)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147412098)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x170047FE RID: 18430
		// (get) Token: 0x0600D7E3 RID: 55267
		// (set) Token: 0x0600D7E2 RID: 55266
		[global::System.Runtime.InteropServices.DispId(-2147412097)]
		public virtual extern object onblur { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412097)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147412097)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x170047FF RID: 18431
		// (get) Token: 0x0600D7E5 RID: 55269
		// (set) Token: 0x0600D7E4 RID: 55268
		[global::System.Runtime.InteropServices.DispId(-2147412080)]
		public virtual extern object onload { [global::System.Runtime.InteropServices.DispId(-2147412080)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147412080)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x17004800 RID: 18432
		// (get) Token: 0x0600D7E7 RID: 55271
		// (set) Token: 0x0600D7E6 RID: 55270
		[global::System.Runtime.InteropServices.DispId(-2147412073)]
		public virtual extern object onbeforeunload { [global::System.Runtime.InteropServices.DispId(-2147412073)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147412073)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x17004801 RID: 18433
		// (get) Token: 0x0600D7E9 RID: 55273
		// (set) Token: 0x0600D7E8 RID: 55272
		[global::System.Runtime.InteropServices.DispId(-2147412079)]
		public virtual extern object onunload { [global::System.Runtime.InteropServices.DispId(-2147412079)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412079)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x17004802 RID: 18434
		// (get) Token: 0x0600D7EB RID: 55275
		// (set) Token: 0x0600D7EA RID: 55274
		[global::System.Runtime.InteropServices.DispId(-2147412099)]
		public virtual extern object onhelp { [global::System.Runtime.InteropServices.DispId(-2147412099)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412099)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x17004803 RID: 18435
		// (get) Token: 0x0600D7ED RID: 55277
		// (set) Token: 0x0600D7EC RID: 55276
		[global::System.Runtime.InteropServices.DispId(-2147412083)]
		public virtual extern object onerror { [global::System.Runtime.InteropServices.DispId(-2147412083)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147412083)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x17004804 RID: 18436
		// (get) Token: 0x0600D7EF RID: 55279
		// (set) Token: 0x0600D7EE RID: 55278
		[global::System.Runtime.InteropServices.DispId(-2147412076)]
		public virtual extern object onresize { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412076)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147412076)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x17004805 RID: 18437
		// (get) Token: 0x0600D7F1 RID: 55281
		// (set) Token: 0x0600D7F0 RID: 55280
		[global::System.Runtime.InteropServices.DispId(-2147412081)]
		public virtual extern object onscroll { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412081)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147412081)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x17004806 RID: 18438
		// (get) Token: 0x0600D7F2 RID: 55282
		[global::System.Runtime.InteropServices.DispId(1151)]
		public virtual extern global::mshtml.IHTMLDocument2 document { [global::System.Runtime.InteropServices.DispId(1151)] [global::System.Runtime.InteropServices.TypeLibFunc(2)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x17004807 RID: 18439
		// (get) Token: 0x0600D7F3 RID: 55283
		[global::System.Runtime.InteropServices.DispId(1152)]
		public virtual extern global::mshtml.IHTMLEventObj @event { [global::System.Runtime.InteropServices.DispId(1152)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x17004808 RID: 18440
		// (get) Token: 0x0600D7F4 RID: 55284
		[global::System.Runtime.InteropServices.DispId(1153)]
		public virtual extern object _newEnum { [global::System.Runtime.InteropServices.DispId(1153)] [global::System.Runtime.InteropServices.TypeLibFunc(65)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IUnknown)] get; }

		// Token: 0x0600D7F5 RID: 55285
		[global::System.Runtime.InteropServices.DispId(1154)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)]
		public virtual extern object showModalDialog([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string dialog, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object varArgIn, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object varOptions);

		// Token: 0x0600D7F6 RID: 55286
		[global::System.Runtime.InteropServices.DispId(1155)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void showHelp([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string helpURL, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] object helpArg, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string features = "");

		// Token: 0x17004809 RID: 18441
		// (get) Token: 0x0600D7F7 RID: 55287
		[global::System.Runtime.InteropServices.DispId(1156)]
		public virtual extern global::mshtml.IHTMLScreen screen { [global::System.Runtime.InteropServices.DispId(1156)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x1700480A RID: 18442
		// (get) Token: 0x0600D7F8 RID: 55288
		[global::System.Runtime.InteropServices.DispId(1157)]
		public virtual extern global::mshtml.HTMLOptionElementFactory Option { [global::System.Runtime.InteropServices.DispId(1157)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x0600D7F9 RID: 55289
		[global::System.Runtime.InteropServices.DispId(1158)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void focus();

		// Token: 0x1700480B RID: 18443
		// (get) Token: 0x0600D7FA RID: 55290
		[global::System.Runtime.InteropServices.DispId(23)]
		public virtual extern bool closed { [global::System.Runtime.InteropServices.DispId(23)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x0600D7FB RID: 55291
		[global::System.Runtime.InteropServices.DispId(1159)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void blur();

		// Token: 0x0600D7FC RID: 55292
		[global::System.Runtime.InteropServices.DispId(1160)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void scroll([global::System.Runtime.InteropServices.In] int x, [global::System.Runtime.InteropServices.In] int y);

		// Token: 0x1700480C RID: 18444
		// (get) Token: 0x0600D7FD RID: 55293
		[global::System.Runtime.InteropServices.DispId(1161)]
		public virtual extern global::mshtml.HTMLNavigator clientInformation { [global::System.Runtime.InteropServices.DispId(1161)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x0600D7FE RID: 55294
		[global::System.Runtime.InteropServices.DispId(1163)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void clearInterval([global::System.Runtime.InteropServices.In] int timerID);

		// Token: 0x1700480D RID: 18445
		// (get) Token: 0x0600D800 RID: 55296
		// (set) Token: 0x0600D7FF RID: 55295
		[global::System.Runtime.InteropServices.DispId(1164)]
		public virtual extern object offscreenBuffering { [global::System.Runtime.InteropServices.DispId(1164)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(1164)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x0600D801 RID: 55297
		[global::System.Runtime.InteropServices.DispId(1165)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)]
		public virtual extern object execScript([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string code, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string language = "JScript");

		// Token: 0x0600D802 RID: 55298
		[global::System.Runtime.InteropServices.DispId(1166)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public virtual extern string toString();

		// Token: 0x0600D803 RID: 55299
		[global::System.Runtime.InteropServices.DispId(1167)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void scrollBy([global::System.Runtime.InteropServices.In] int x, [global::System.Runtime.InteropServices.In] int y);

		// Token: 0x0600D804 RID: 55300
		[global::System.Runtime.InteropServices.DispId(1168)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void scrollTo([global::System.Runtime.InteropServices.In] int x, [global::System.Runtime.InteropServices.In] int y);

		// Token: 0x0600D805 RID: 55301
		[global::System.Runtime.InteropServices.DispId(6)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void moveTo([global::System.Runtime.InteropServices.In] int x, [global::System.Runtime.InteropServices.In] int y);

		// Token: 0x0600D806 RID: 55302
		[global::System.Runtime.InteropServices.DispId(7)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void moveBy([global::System.Runtime.InteropServices.In] int x, [global::System.Runtime.InteropServices.In] int y);

		// Token: 0x0600D807 RID: 55303
		[global::System.Runtime.InteropServices.DispId(9)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void resizeTo([global::System.Runtime.InteropServices.In] int x, [global::System.Runtime.InteropServices.In] int y);

		// Token: 0x0600D808 RID: 55304
		[global::System.Runtime.InteropServices.DispId(8)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void resizeBy([global::System.Runtime.InteropServices.In] int x, [global::System.Runtime.InteropServices.In] int y);

		// Token: 0x1700480E RID: 18446
		// (get) Token: 0x0600D809 RID: 55305
		[global::System.Runtime.InteropServices.DispId(1169)]
		public virtual extern object external { [global::System.Runtime.InteropServices.DispId(1169)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] get; }

		// Token: 0x1700480F RID: 18447
		// (get) Token: 0x0600D80A RID: 55306
		[global::System.Runtime.InteropServices.DispId(1170)]
		public virtual extern int screenLeft { [global::System.Runtime.InteropServices.DispId(1170)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x17004810 RID: 18448
		// (get) Token: 0x0600D80B RID: 55307
		[global::System.Runtime.InteropServices.DispId(1171)]
		public virtual extern int screenTop { [global::System.Runtime.InteropServices.DispId(1171)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x0600D80C RID: 55308
		[global::System.Runtime.InteropServices.DispId(-2147417605)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern bool attachEvent([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string @event, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] [global::System.Runtime.InteropServices.In] object pdisp);

		// Token: 0x0600D80D RID: 55309
		[global::System.Runtime.InteropServices.DispId(-2147417604)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void detachEvent([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string @event, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] [global::System.Runtime.InteropServices.In] object pdisp);

		// Token: 0x0600D80E RID: 55310
		[global::System.Runtime.InteropServices.DispId(1103)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern int setTimeout([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] ref object expression, [global::System.Runtime.InteropServices.In] int msec, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object language);

		// Token: 0x0600D80F RID: 55311
		[global::System.Runtime.InteropServices.DispId(1162)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern int setInterval([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] ref object expression, [global::System.Runtime.InteropServices.In] int msec, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object language);

		// Token: 0x0600D810 RID: 55312
		[global::System.Runtime.InteropServices.DispId(1174)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void print();

		// Token: 0x17004811 RID: 18449
		// (get) Token: 0x0600D812 RID: 55314
		// (set) Token: 0x0600D811 RID: 55313
		[global::System.Runtime.InteropServices.DispId(-2147412046)]
		public virtual extern object onbeforeprint { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412046)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147412046)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x17004812 RID: 18450
		// (get) Token: 0x0600D814 RID: 55316
		// (set) Token: 0x0600D813 RID: 55315
		[global::System.Runtime.InteropServices.DispId(-2147412045)]
		public virtual extern object onafterprint { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412045)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147412045)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] set; }

		// Token: 0x17004813 RID: 18451
		// (get) Token: 0x0600D815 RID: 55317
		[global::System.Runtime.InteropServices.DispId(1175)]
		public virtual extern global::mshtml.IHTMLDataTransfer clipboardData { [global::System.Runtime.InteropServices.DispId(1175)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x0600D816 RID: 55318
		[global::System.Runtime.InteropServices.DispId(1176)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		public virtual extern global::mshtml.IHTMLWindow2 showModelessDialog([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string url = "", [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object varArgIn, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object options);

		// Token: 0x0600D817 RID: 55319
		[global::System.Runtime.InteropServices.DispId(1180)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)]
		public virtual extern object createPopup([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object varArgIn);

		// Token: 0x17004814 RID: 18452
		// (get) Token: 0x0600D818 RID: 55320
		[global::System.Runtime.InteropServices.DispId(1181)]
		public virtual extern global::mshtml.IHTMLFrameBase frameElement { [global::System.Runtime.InteropServices.DispId(1181)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x0600D819 RID: 55321
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)]
		public virtual extern object IHTMLWindow2_item([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] ref object pvarIndex);

		// Token: 0x17004815 RID: 18453
		// (get) Token: 0x0600D81A RID: 55322
		public virtual extern int IHTMLWindow2_length { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x17004816 RID: 18454
		// (get) Token: 0x0600D81B RID: 55323
		public virtual extern global::mshtml.FramesCollection IHTMLWindow2_frames { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x17004817 RID: 18455
		// (get) Token: 0x0600D81D RID: 55325
		// (set) Token: 0x0600D81C RID: 55324
		public virtual extern string IHTMLWindow2_defaultStatus { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17004818 RID: 18456
		// (get) Token: 0x0600D81F RID: 55327
		// (set) Token: 0x0600D81E RID: 55326
		public virtual extern string IHTMLWindow2_status { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x0600D820 RID: 55328
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern int setTimeout([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string expression, [global::System.Runtime.InteropServices.In] int msec, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object language);

		// Token: 0x0600D821 RID: 55329
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void IHTMLWindow2_clearTimeout([global::System.Runtime.InteropServices.In] int timerID);

		// Token: 0x0600D822 RID: 55330
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void IHTMLWindow2_alert([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string message = "");

		// Token: 0x0600D823 RID: 55331
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern bool IHTMLWindow2_confirm([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string message = "");

		// Token: 0x0600D824 RID: 55332
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)]
		public virtual extern object IHTMLWindow2_prompt([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string message = "", [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string defstr = "undefined");

		// Token: 0x17004819 RID: 18457
		// (get) Token: 0x0600D825 RID: 55333
		public virtual extern global::mshtml.HTMLImageElementFactory IHTMLWindow2_Image { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x1700481A RID: 18458
		// (get) Token: 0x0600D826 RID: 55334
		public virtual extern global::mshtml.HTMLLocation IHTMLWindow2_location { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x1700481B RID: 18459
		// (get) Token: 0x0600D827 RID: 55335
		public virtual extern global::mshtml.HTMLHistory IHTMLWindow2_history { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x0600D828 RID: 55336
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void IHTMLWindow2_close();

		// Token: 0x1700481C RID: 18460
		// (get) Token: 0x0600D82A RID: 55338
		// (set) Token: 0x0600D829 RID: 55337
		public virtual extern object IHTMLWindow2_opener { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700481D RID: 18461
		// (get) Token: 0x0600D82B RID: 55339
		public virtual extern global::mshtml.HTMLNavigator IHTMLWindow2_navigator { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x1700481E RID: 18462
		// (get) Token: 0x0600D82D RID: 55341
		// (set) Token: 0x0600D82C RID: 55340
		public virtual extern string IHTMLWindow2_name { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700481F RID: 18463
		// (get) Token: 0x0600D82E RID: 55342
		public virtual extern global::mshtml.IHTMLWindow2 IHTMLWindow2_parent { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x0600D82F RID: 55343
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		public virtual extern global::mshtml.IHTMLWindow2 IHTMLWindow2_open([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string url = "", [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string name = "", [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string features = "", [global::System.Runtime.InteropServices.In] bool replace = false);

		// Token: 0x17004820 RID: 18464
		// (get) Token: 0x0600D830 RID: 55344
		public virtual extern global::mshtml.IHTMLWindow2 IHTMLWindow2_self { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x17004821 RID: 18465
		// (get) Token: 0x0600D831 RID: 55345
		public virtual extern global::mshtml.IHTMLWindow2 IHTMLWindow2_top { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x17004822 RID: 18466
		// (get) Token: 0x0600D832 RID: 55346
		public virtual extern global::mshtml.IHTMLWindow2 IHTMLWindow2_window { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x0600D833 RID: 55347
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void IHTMLWindow2_navigate([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string url);

		// Token: 0x17004823 RID: 18467
		// (get) Token: 0x0600D835 RID: 55349
		// (set) Token: 0x0600D834 RID: 55348
		public virtual extern object IHTMLWindow2_onfocus { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17004824 RID: 18468
		// (get) Token: 0x0600D837 RID: 55351
		// (set) Token: 0x0600D836 RID: 55350
		public virtual extern object IHTMLWindow2_onblur { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17004825 RID: 18469
		// (get) Token: 0x0600D839 RID: 55353
		// (set) Token: 0x0600D838 RID: 55352
		public virtual extern object IHTMLWindow2_onload { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17004826 RID: 18470
		// (get) Token: 0x0600D83B RID: 55355
		// (set) Token: 0x0600D83A RID: 55354
		public virtual extern object IHTMLWindow2_onbeforeunload { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17004827 RID: 18471
		// (get) Token: 0x0600D83D RID: 55357
		// (set) Token: 0x0600D83C RID: 55356
		public virtual extern object IHTMLWindow2_onunload { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17004828 RID: 18472
		// (get) Token: 0x0600D83F RID: 55359
		// (set) Token: 0x0600D83E RID: 55358
		public virtual extern object IHTMLWindow2_onhelp { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17004829 RID: 18473
		// (get) Token: 0x0600D841 RID: 55361
		// (set) Token: 0x0600D840 RID: 55360
		public virtual extern object IHTMLWindow2_onerror { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700482A RID: 18474
		// (get) Token: 0x0600D843 RID: 55363
		// (set) Token: 0x0600D842 RID: 55362
		public virtual extern object IHTMLWindow2_onresize { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700482B RID: 18475
		// (get) Token: 0x0600D845 RID: 55365
		// (set) Token: 0x0600D844 RID: 55364
		public virtual extern object IHTMLWindow2_onscroll { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700482C RID: 18476
		// (get) Token: 0x0600D846 RID: 55366
		public virtual extern global::mshtml.IHTMLDocument2 IHTMLWindow2_document { [global::System.Runtime.InteropServices.TypeLibFunc(2)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x1700482D RID: 18477
		// (get) Token: 0x0600D847 RID: 55367
		public virtual extern global::mshtml.IHTMLEventObj IHTMLWindow2_event { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x1700482E RID: 18478
		// (get) Token: 0x0600D848 RID: 55368
		public virtual extern object IHTMLWindow2__newEnum { [global::System.Runtime.InteropServices.TypeLibFunc(65)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IUnknown)] get; }

		// Token: 0x0600D849 RID: 55369
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)]
		public virtual extern object IHTMLWindow2_showModalDialog([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string dialog, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object varArgIn, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object varOptions);

		// Token: 0x0600D84A RID: 55370
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void IHTMLWindow2_showHelp([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string helpURL, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] object helpArg, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string features = "");

		// Token: 0x1700482F RID: 18479
		// (get) Token: 0x0600D84B RID: 55371
		public virtual extern global::mshtml.IHTMLScreen IHTMLWindow2_screen { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x17004830 RID: 18480
		// (get) Token: 0x0600D84C RID: 55372
		public virtual extern global::mshtml.HTMLOptionElementFactory IHTMLWindow2_Option { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x0600D84D RID: 55373
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void IHTMLWindow2_focus();

		// Token: 0x17004831 RID: 18481
		// (get) Token: 0x0600D84E RID: 55374
		public virtual extern bool IHTMLWindow2_closed { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x0600D84F RID: 55375
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void IHTMLWindow2_blur();

		// Token: 0x0600D850 RID: 55376
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void IHTMLWindow2_scroll([global::System.Runtime.InteropServices.In] int x, [global::System.Runtime.InteropServices.In] int y);

		// Token: 0x17004832 RID: 18482
		// (get) Token: 0x0600D851 RID: 55377
		public virtual extern global::mshtml.HTMLNavigator IHTMLWindow2_clientInformation { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x0600D852 RID: 55378
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern int setInterval([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string expression, [global::System.Runtime.InteropServices.In] int msec, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object language);

		// Token: 0x0600D853 RID: 55379
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void IHTMLWindow2_clearInterval([global::System.Runtime.InteropServices.In] int timerID);

		// Token: 0x17004833 RID: 18483
		// (get) Token: 0x0600D855 RID: 55381
		// (set) Token: 0x0600D854 RID: 55380
		public virtual extern object IHTMLWindow2_offscreenBuffering { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x0600D856 RID: 55382
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)]
		public virtual extern object IHTMLWindow2_execScript([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string code, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string language = "JScript");

		// Token: 0x0600D857 RID: 55383
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public virtual extern string IHTMLWindow2_toString();

		// Token: 0x0600D858 RID: 55384
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void IHTMLWindow2_scrollBy([global::System.Runtime.InteropServices.In] int x, [global::System.Runtime.InteropServices.In] int y);

		// Token: 0x0600D859 RID: 55385
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void IHTMLWindow2_scrollTo([global::System.Runtime.InteropServices.In] int x, [global::System.Runtime.InteropServices.In] int y);

		// Token: 0x0600D85A RID: 55386
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void IHTMLWindow2_moveTo([global::System.Runtime.InteropServices.In] int x, [global::System.Runtime.InteropServices.In] int y);

		// Token: 0x0600D85B RID: 55387
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void IHTMLWindow2_moveBy([global::System.Runtime.InteropServices.In] int x, [global::System.Runtime.InteropServices.In] int y);

		// Token: 0x0600D85C RID: 55388
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void IHTMLWindow2_resizeTo([global::System.Runtime.InteropServices.In] int x, [global::System.Runtime.InteropServices.In] int y);

		// Token: 0x0600D85D RID: 55389
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void IHTMLWindow2_resizeBy([global::System.Runtime.InteropServices.In] int x, [global::System.Runtime.InteropServices.In] int y);

		// Token: 0x17004834 RID: 18484
		// (get) Token: 0x0600D85E RID: 55390
		public virtual extern object IHTMLWindow2_external { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] get; }

		// Token: 0x17004835 RID: 18485
		// (get) Token: 0x0600D85F RID: 55391
		public virtual extern int IHTMLWindow3_screenLeft { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x17004836 RID: 18486
		// (get) Token: 0x0600D860 RID: 55392
		public virtual extern int IHTMLWindow3_screenTop { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x0600D861 RID: 55393
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern bool IHTMLWindow3_attachEvent([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string @event, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] [global::System.Runtime.InteropServices.In] object pdisp);

		// Token: 0x0600D862 RID: 55394
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void IHTMLWindow3_detachEvent([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string @event, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] [global::System.Runtime.InteropServices.In] object pdisp);

		// Token: 0x0600D863 RID: 55395
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern int setTimeout([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] ref object expression, [global::System.Runtime.InteropServices.In] int msec, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object language);

		// Token: 0x0600D864 RID: 55396
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern int setInterval([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] ref object expression, [global::System.Runtime.InteropServices.In] int msec, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object language);

		// Token: 0x0600D865 RID: 55397
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void IHTMLWindow3_print();

		// Token: 0x17004837 RID: 18487
		// (get) Token: 0x0600D867 RID: 55399
		// (set) Token: 0x0600D866 RID: 55398
		public virtual extern object IHTMLWindow3_onbeforeprint { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17004838 RID: 18488
		// (get) Token: 0x0600D869 RID: 55401
		// (set) Token: 0x0600D868 RID: 55400
		public virtual extern object IHTMLWindow3_onafterprint { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17004839 RID: 18489
		// (get) Token: 0x0600D86A RID: 55402
		public virtual extern global::mshtml.IHTMLDataTransfer IHTMLWindow3_clipboardData { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x0600D86B RID: 55403
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		public virtual extern global::mshtml.IHTMLWindow2 IHTMLWindow3_showModelessDialog([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string url = "", [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object varArgIn, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object options);

		// Token: 0x0600D86C RID: 55404
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)]
		public virtual extern object IHTMLWindow4_createPopup([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object varArgIn);

		// Token: 0x1700483A RID: 18490
		// (get) Token: 0x0600D86D RID: 55405
		public virtual extern global::mshtml.IHTMLFrameBase IHTMLWindow4_frameElement { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x14001A1B RID: 6683
		// (add) Token: 0x0600D86E RID: 55406
		// (remove) Token: 0x0600D86F RID: 55407
		public virtual extern event global::mshtml.HTMLWindowEvents_onloadEventHandler HTMLWindowEvents_Event_onload;

		// Token: 0x14001A1C RID: 6684
		// (add) Token: 0x0600D870 RID: 55408
		// (remove) Token: 0x0600D871 RID: 55409
		public virtual extern event global::mshtml.HTMLWindowEvents_onunloadEventHandler HTMLWindowEvents_Event_onunload;

		// Token: 0x14001A1D RID: 6685
		// (add) Token: 0x0600D872 RID: 55410
		// (remove) Token: 0x0600D873 RID: 55411
		public virtual extern event global::mshtml.HTMLWindowEvents_onhelpEventHandler HTMLWindowEvents_Event_onhelp;

		// Token: 0x14001A1E RID: 6686
		// (add) Token: 0x0600D874 RID: 55412
		// (remove) Token: 0x0600D875 RID: 55413
		public virtual extern event global::mshtml.HTMLWindowEvents_onfocusEventHandler HTMLWindowEvents_Event_onfocus;

		// Token: 0x14001A1F RID: 6687
		// (add) Token: 0x0600D876 RID: 55414
		// (remove) Token: 0x0600D877 RID: 55415
		public virtual extern event global::mshtml.HTMLWindowEvents_onblurEventHandler HTMLWindowEvents_Event_onblur;

		// Token: 0x14001A20 RID: 6688
		// (add) Token: 0x0600D878 RID: 55416
		// (remove) Token: 0x0600D879 RID: 55417
		public virtual extern event global::mshtml.HTMLWindowEvents_onerrorEventHandler HTMLWindowEvents_Event_onerror;

		// Token: 0x14001A21 RID: 6689
		// (add) Token: 0x0600D87A RID: 55418
		// (remove) Token: 0x0600D87B RID: 55419
		public virtual extern event global::mshtml.HTMLWindowEvents_onresizeEventHandler HTMLWindowEvents_Event_onresize;

		// Token: 0x14001A22 RID: 6690
		// (add) Token: 0x0600D87C RID: 55420
		// (remove) Token: 0x0600D87D RID: 55421
		public virtual extern event global::mshtml.HTMLWindowEvents_onscrollEventHandler HTMLWindowEvents_Event_onscroll;

		// Token: 0x14001A23 RID: 6691
		// (add) Token: 0x0600D87E RID: 55422
		// (remove) Token: 0x0600D87F RID: 55423
		public virtual extern event global::mshtml.HTMLWindowEvents_onbeforeunloadEventHandler HTMLWindowEvents_Event_onbeforeunload;

		// Token: 0x14001A24 RID: 6692
		// (add) Token: 0x0600D880 RID: 55424
		// (remove) Token: 0x0600D881 RID: 55425
		public virtual extern event global::mshtml.HTMLWindowEvents_onbeforeprintEventHandler HTMLWindowEvents_Event_onbeforeprint;

		// Token: 0x14001A25 RID: 6693
		// (add) Token: 0x0600D882 RID: 55426
		// (remove) Token: 0x0600D883 RID: 55427
		public virtual extern event global::mshtml.HTMLWindowEvents_onafterprintEventHandler HTMLWindowEvents_Event_onafterprint;

		// Token: 0x14001A26 RID: 6694
		// (add) Token: 0x0600D884 RID: 55428
		// (remove) Token: 0x0600D885 RID: 55429
		public virtual extern event global::mshtml.HTMLWindowEvents2_onloadEventHandler HTMLWindowEvents2_Event_onload;

		// Token: 0x14001A27 RID: 6695
		// (add) Token: 0x0600D886 RID: 55430
		// (remove) Token: 0x0600D887 RID: 55431
		public virtual extern event global::mshtml.HTMLWindowEvents2_onunloadEventHandler HTMLWindowEvents2_Event_onunload;

		// Token: 0x14001A28 RID: 6696
		// (add) Token: 0x0600D888 RID: 55432
		// (remove) Token: 0x0600D889 RID: 55433
		public virtual extern event global::mshtml.HTMLWindowEvents2_onhelpEventHandler HTMLWindowEvents2_Event_onhelp;

		// Token: 0x14001A29 RID: 6697
		// (add) Token: 0x0600D88A RID: 55434
		// (remove) Token: 0x0600D88B RID: 55435
		public virtual extern event global::mshtml.HTMLWindowEvents2_onfocusEventHandler HTMLWindowEvents2_Event_onfocus;

		// Token: 0x14001A2A RID: 6698
		// (add) Token: 0x0600D88C RID: 55436
		// (remove) Token: 0x0600D88D RID: 55437
		public virtual extern event global::mshtml.HTMLWindowEvents2_onblurEventHandler HTMLWindowEvents2_Event_onblur;

		// Token: 0x14001A2B RID: 6699
		// (add) Token: 0x0600D88E RID: 55438
		// (remove) Token: 0x0600D88F RID: 55439
		public virtual extern event global::mshtml.HTMLWindowEvents2_onerrorEventHandler HTMLWindowEvents2_Event_onerror;

		// Token: 0x14001A2C RID: 6700
		// (add) Token: 0x0600D890 RID: 55440
		// (remove) Token: 0x0600D891 RID: 55441
		public virtual extern event global::mshtml.HTMLWindowEvents2_onresizeEventHandler HTMLWindowEvents2_Event_onresize;

		// Token: 0x14001A2D RID: 6701
		// (add) Token: 0x0600D892 RID: 55442
		// (remove) Token: 0x0600D893 RID: 55443
		public virtual extern event global::mshtml.HTMLWindowEvents2_onscrollEventHandler HTMLWindowEvents2_Event_onscroll;

		// Token: 0x14001A2E RID: 6702
		// (add) Token: 0x0600D894 RID: 55444
		// (remove) Token: 0x0600D895 RID: 55445
		public virtual extern event global::mshtml.HTMLWindowEvents2_onbeforeunloadEventHandler HTMLWindowEvents2_Event_onbeforeunload;

		// Token: 0x14001A2F RID: 6703
		// (add) Token: 0x0600D896 RID: 55446
		// (remove) Token: 0x0600D897 RID: 55447
		public virtual extern event global::mshtml.HTMLWindowEvents2_onbeforeprintEventHandler HTMLWindowEvents2_Event_onbeforeprint;

		// Token: 0x14001A30 RID: 6704
		// (add) Token: 0x0600D898 RID: 55448
		// (remove) Token: 0x0600D899 RID: 55449
		public virtual extern event global::mshtml.HTMLWindowEvents2_onafterprintEventHandler HTMLWindowEvents2_Event_onafterprint;
	}
}
