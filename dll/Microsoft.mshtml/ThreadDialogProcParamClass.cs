using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace mshtml
{
	// Token: 0x02000CF4 RID: 3316
	[global::System.Runtime.InteropServices.ClassInterface(0)]
	[global::System.Runtime.InteropServices.Guid("3050F5EB-98B5-11CF-BB82-00AA00BDCE0B")]
	[global::System.Runtime.InteropServices.TypeLibType(2)]
	[global::System.Runtime.InteropServices.ComImport]
	public class ThreadDialogProcParamClass : global::mshtml.IHTMLModelessInit, global::mshtml.ThreadDialogProcParam
	{
		// Token: 0x06016386 RID: 91014
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public extern ThreadDialogProcParamClass();

		// Token: 0x170075D5 RID: 30165
		// (get) Token: 0x06016387 RID: 91015
		[global::System.Runtime.InteropServices.DispId(25000)]
		public virtual extern object parameters { [global::System.Runtime.InteropServices.DispId(25000)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; }

		// Token: 0x170075D6 RID: 30166
		// (get) Token: 0x06016388 RID: 91016
		[global::System.Runtime.InteropServices.DispId(25001)]
		public virtual extern object optionString { [global::System.Runtime.InteropServices.DispId(25001)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; }

		// Token: 0x170075D7 RID: 30167
		// (get) Token: 0x06016389 RID: 91017
		[global::System.Runtime.InteropServices.DispId(25006)]
		public virtual extern object moniker { [global::System.Runtime.InteropServices.DispId(25006)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IUnknown)] get; }

		// Token: 0x170075D8 RID: 30168
		// (get) Token: 0x0601638A RID: 91018
		[global::System.Runtime.InteropServices.DispId(25007)]
		public virtual extern object document { [global::System.Runtime.InteropServices.DispId(25007)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IUnknown)] get; }
	}
}
