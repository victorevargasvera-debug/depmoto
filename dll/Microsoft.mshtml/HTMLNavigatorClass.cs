using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace mshtml
{
	// Token: 0x020007A3 RID: 1955
	[global::System.Runtime.InteropServices.ClassInterface(0)]
	[global::System.Runtime.InteropServices.Guid("FECEAAA6-8405-11CF-8BA1-00AA00476DA6")]
	[global::System.Runtime.InteropServices.TypeLibType(2)]
	[global::System.Runtime.InteropServices.ComImport]
	public class HTMLNavigatorClass : global::mshtml.IOmNavigator, global::mshtml.HTMLNavigator
	{
		// Token: 0x0600D4CC RID: 54476
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public extern HTMLNavigatorClass();

		// Token: 0x17004650 RID: 18000
		// (get) Token: 0x0600D4CD RID: 54477
		[global::System.Runtime.InteropServices.DispId(1)]
		public virtual extern string appCodeName { [global::System.Runtime.InteropServices.DispId(1)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x17004651 RID: 18001
		// (get) Token: 0x0600D4CE RID: 54478
		[global::System.Runtime.InteropServices.DispId(2)]
		public virtual extern string appName { [global::System.Runtime.InteropServices.DispId(2)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x17004652 RID: 18002
		// (get) Token: 0x0600D4CF RID: 54479
		[global::System.Runtime.InteropServices.DispId(3)]
		public virtual extern string appVersion { [global::System.Runtime.InteropServices.DispId(3)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x17004653 RID: 18003
		// (get) Token: 0x0600D4D0 RID: 54480
		[global::System.Runtime.InteropServices.DispId(4)]
		public virtual extern string userAgent { [global::System.Runtime.InteropServices.DispId(4)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x0600D4D1 RID: 54481
		[global::System.Runtime.InteropServices.DispId(5)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern bool javaEnabled();

		// Token: 0x0600D4D2 RID: 54482
		[global::System.Runtime.InteropServices.DispId(6)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern bool taintEnabled();

		// Token: 0x17004654 RID: 18004
		// (get) Token: 0x0600D4D3 RID: 54483
		[global::System.Runtime.InteropServices.DispId(7)]
		public virtual extern global::mshtml.CMimeTypes mimeTypes { [global::System.Runtime.InteropServices.DispId(7)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x17004655 RID: 18005
		// (get) Token: 0x0600D4D4 RID: 54484
		[global::System.Runtime.InteropServices.DispId(8)]
		public virtual extern global::mshtml.CPlugins plugins { [global::System.Runtime.InteropServices.DispId(8)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x17004656 RID: 18006
		// (get) Token: 0x0600D4D5 RID: 54485
		[global::System.Runtime.InteropServices.DispId(9)]
		public virtual extern bool cookieEnabled { [global::System.Runtime.InteropServices.DispId(9)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x17004657 RID: 18007
		// (get) Token: 0x0600D4D6 RID: 54486
		[global::System.Runtime.InteropServices.DispId(10)]
		public virtual extern global::mshtml.COpsProfile opsProfile { [global::System.Runtime.InteropServices.DispId(10)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x0600D4D7 RID: 54487
		[global::System.Runtime.InteropServices.DispId(11)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public virtual extern string toString();

		// Token: 0x17004658 RID: 18008
		// (get) Token: 0x0600D4D8 RID: 54488
		[global::System.Runtime.InteropServices.DispId(12)]
		public virtual extern string cpuClass { [global::System.Runtime.InteropServices.DispId(12)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x17004659 RID: 18009
		// (get) Token: 0x0600D4D9 RID: 54489
		[global::System.Runtime.InteropServices.DispId(13)]
		public virtual extern string systemLanguage { [global::System.Runtime.InteropServices.DispId(13)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x1700465A RID: 18010
		// (get) Token: 0x0600D4DA RID: 54490
		[global::System.Runtime.InteropServices.DispId(14)]
		public virtual extern string browserLanguage { [global::System.Runtime.InteropServices.DispId(14)] [global::System.Runtime.InteropServices.TypeLibFunc(64)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x1700465B RID: 18011
		// (get) Token: 0x0600D4DB RID: 54491
		[global::System.Runtime.InteropServices.DispId(15)]
		public virtual extern string userLanguage { [global::System.Runtime.InteropServices.DispId(15)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x1700465C RID: 18012
		// (get) Token: 0x0600D4DC RID: 54492
		[global::System.Runtime.InteropServices.DispId(16)]
		public virtual extern string platform { [global::System.Runtime.InteropServices.DispId(16)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x1700465D RID: 18013
		// (get) Token: 0x0600D4DD RID: 54493
		[global::System.Runtime.InteropServices.DispId(17)]
		public virtual extern string appMinorVersion { [global::System.Runtime.InteropServices.DispId(17)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x1700465E RID: 18014
		// (get) Token: 0x0600D4DE RID: 54494
		[global::System.Runtime.InteropServices.DispId(18)]
		public virtual extern int connectionSpeed { [global::System.Runtime.InteropServices.TypeLibFunc(64)] [global::System.Runtime.InteropServices.DispId(18)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700465F RID: 18015
		// (get) Token: 0x0600D4DF RID: 54495
		[global::System.Runtime.InteropServices.DispId(19)]
		public virtual extern bool onLine { [global::System.Runtime.InteropServices.DispId(19)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x17004660 RID: 18016
		// (get) Token: 0x0600D4E0 RID: 54496
		[global::System.Runtime.InteropServices.DispId(20)]
		public virtual extern global::mshtml.COpsProfile userProfile { [global::System.Runtime.InteropServices.DispId(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }
	}
}
