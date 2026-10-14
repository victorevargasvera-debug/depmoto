using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace mshtml
{
	// Token: 0x02000CF6 RID: 3318
	[global::System.Runtime.InteropServices.TypeLibType(2)]
	[global::System.Runtime.InteropServices.ClassInterface(0)]
	[global::System.Runtime.InteropServices.Guid("3050F28A-98B5-11CF-BB82-00AA00BDCE0B")]
	[global::System.Runtime.InteropServices.ComImport]
	public class HTMLDialogClass : global::mshtml.IHTMLDialog, global::mshtml.HTMLDialog
	{
		// Token: 0x0601638B RID: 91019
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public extern HTMLDialogClass();

		// Token: 0x170075D9 RID: 30169
		// (get) Token: 0x0601638D RID: 91021
		// (set) Token: 0x0601638C RID: 91020
		[global::System.Runtime.InteropServices.DispId(-2147418108)]
		public virtual extern object dialogTop { [global::System.Runtime.InteropServices.TypeLibFunc(4)] [global::System.Runtime.InteropServices.DispId(-2147418108)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(4)] [global::System.Runtime.InteropServices.DispId(-2147418108)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170075DA RID: 30170
		// (get) Token: 0x0601638F RID: 91023
		// (set) Token: 0x0601638E RID: 91022
		[global::System.Runtime.InteropServices.DispId(-2147418109)]
		public virtual extern object dialogLeft { [global::System.Runtime.InteropServices.TypeLibFunc(4)] [global::System.Runtime.InteropServices.DispId(-2147418109)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147418109)] [global::System.Runtime.InteropServices.TypeLibFunc(4)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170075DB RID: 30171
		// (get) Token: 0x06016391 RID: 91025
		// (set) Token: 0x06016390 RID: 91024
		[global::System.Runtime.InteropServices.DispId(-2147418107)]
		public virtual extern object dialogWidth { [global::System.Runtime.InteropServices.TypeLibFunc(4)] [global::System.Runtime.InteropServices.DispId(-2147418107)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147418107)] [global::System.Runtime.InteropServices.TypeLibFunc(4)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170075DC RID: 30172
		// (get) Token: 0x06016393 RID: 91027
		// (set) Token: 0x06016392 RID: 91026
		[global::System.Runtime.InteropServices.DispId(-2147418106)]
		public virtual extern object dialogHeight { [global::System.Runtime.InteropServices.DispId(-2147418106)] [global::System.Runtime.InteropServices.TypeLibFunc(4)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147418106)] [global::System.Runtime.InteropServices.TypeLibFunc(4)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170075DD RID: 30173
		// (get) Token: 0x06016394 RID: 91028
		[global::System.Runtime.InteropServices.DispId(25000)]
		public virtual extern object dialogArguments { [global::System.Runtime.InteropServices.DispId(25000)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; }

		// Token: 0x170075DE RID: 30174
		// (get) Token: 0x06016395 RID: 91029
		[global::System.Runtime.InteropServices.DispId(25013)]
		public virtual extern object menuArguments { [global::System.Runtime.InteropServices.DispId(25013)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; }

		// Token: 0x170075DF RID: 30175
		// (get) Token: 0x06016397 RID: 91031
		// (set) Token: 0x06016396 RID: 91030
		[global::System.Runtime.InteropServices.DispId(25001)]
		public virtual extern object returnValue { [global::System.Runtime.InteropServices.DispId(25001)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(25001)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x06016398 RID: 91032
		[global::System.Runtime.InteropServices.DispId(25011)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void close();

		// Token: 0x06016399 RID: 91033
		[global::System.Runtime.InteropServices.DispId(25012)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public virtual extern string toString();
	}
}
