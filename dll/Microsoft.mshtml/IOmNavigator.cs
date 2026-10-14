using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace mshtml
{
	// Token: 0x02000799 RID: 1945
	[global::System.Runtime.InteropServices.Guid("FECEAAA5-8405-11CF-8BA1-00AA00476DA6")]
	[global::System.Runtime.InteropServices.TypeLibType(4160)]
	[global::System.Runtime.InteropServices.ComImport]
	public interface IOmNavigator
	{
		// Token: 0x17004634 RID: 17972
		// (get) Token: 0x0600D490 RID: 54416
		[global::System.Runtime.InteropServices.DispId(1)]
		string appCodeName { [global::System.Runtime.InteropServices.DispId(1)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x17004635 RID: 17973
		// (get) Token: 0x0600D491 RID: 54417
		[global::System.Runtime.InteropServices.DispId(2)]
		string appName { [global::System.Runtime.InteropServices.DispId(2)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x17004636 RID: 17974
		// (get) Token: 0x0600D492 RID: 54418
		[global::System.Runtime.InteropServices.DispId(3)]
		string appVersion { [global::System.Runtime.InteropServices.DispId(3)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x17004637 RID: 17975
		// (get) Token: 0x0600D493 RID: 54419
		[global::System.Runtime.InteropServices.DispId(4)]
		string userAgent { [global::System.Runtime.InteropServices.DispId(4)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x0600D494 RID: 54420
		[global::System.Runtime.InteropServices.DispId(5)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		bool javaEnabled();

		// Token: 0x0600D495 RID: 54421
		[global::System.Runtime.InteropServices.DispId(6)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		bool taintEnabled();

		// Token: 0x17004638 RID: 17976
		// (get) Token: 0x0600D496 RID: 54422
		[global::System.Runtime.InteropServices.DispId(7)]
		global::mshtml.CMimeTypes mimeTypes { [global::System.Runtime.InteropServices.DispId(7)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x17004639 RID: 17977
		// (get) Token: 0x0600D497 RID: 54423
		[global::System.Runtime.InteropServices.DispId(8)]
		global::mshtml.CPlugins plugins { [global::System.Runtime.InteropServices.DispId(8)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x1700463A RID: 17978
		// (get) Token: 0x0600D498 RID: 54424
		[global::System.Runtime.InteropServices.DispId(9)]
		bool cookieEnabled { [global::System.Runtime.InteropServices.DispId(9)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700463B RID: 17979
		// (get) Token: 0x0600D499 RID: 54425
		[global::System.Runtime.InteropServices.DispId(10)]
		global::mshtml.COpsProfile opsProfile { [global::System.Runtime.InteropServices.DispId(10)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x0600D49A RID: 54426
		[global::System.Runtime.InteropServices.DispId(11)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		string toString();

		// Token: 0x1700463C RID: 17980
		// (get) Token: 0x0600D49B RID: 54427
		[global::System.Runtime.InteropServices.DispId(12)]
		string cpuClass { [global::System.Runtime.InteropServices.DispId(12)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x1700463D RID: 17981
		// (get) Token: 0x0600D49C RID: 54428
		[global::System.Runtime.InteropServices.DispId(13)]
		string systemLanguage { [global::System.Runtime.InteropServices.DispId(13)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x1700463E RID: 17982
		// (get) Token: 0x0600D49D RID: 54429
		[global::System.Runtime.InteropServices.DispId(14)]
		string browserLanguage { [global::System.Runtime.InteropServices.DispId(14)] [global::System.Runtime.InteropServices.TypeLibFunc(64)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x1700463F RID: 17983
		// (get) Token: 0x0600D49E RID: 54430
		[global::System.Runtime.InteropServices.DispId(15)]
		string userLanguage { [global::System.Runtime.InteropServices.DispId(15)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x17004640 RID: 17984
		// (get) Token: 0x0600D49F RID: 54431
		[global::System.Runtime.InteropServices.DispId(16)]
		string platform { [global::System.Runtime.InteropServices.DispId(16)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x17004641 RID: 17985
		// (get) Token: 0x0600D4A0 RID: 54432
		[global::System.Runtime.InteropServices.DispId(17)]
		string appMinorVersion { [global::System.Runtime.InteropServices.DispId(17)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x17004642 RID: 17986
		// (get) Token: 0x0600D4A1 RID: 54433
		[global::System.Runtime.InteropServices.DispId(18)]
		int connectionSpeed { [global::System.Runtime.InteropServices.DispId(18)] [global::System.Runtime.InteropServices.TypeLibFunc(64)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x17004643 RID: 17987
		// (get) Token: 0x0600D4A2 RID: 54434
		[global::System.Runtime.InteropServices.DispId(19)]
		bool onLine { [global::System.Runtime.InteropServices.DispId(19)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x17004644 RID: 17988
		// (get) Token: 0x0600D4A3 RID: 54435
		[global::System.Runtime.InteropServices.DispId(20)]
		global::mshtml.COpsProfile userProfile { [global::System.Runtime.InteropServices.DispId(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }
	}
}
