using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace mshtml
{
	// Token: 0x020007BC RID: 1980
	[global::System.Reflection.DefaultMember("item")]
	[global::System.Runtime.InteropServices.Guid("3050F7F6-98B5-11CF-BB82-00AA00BDCE0B")]
	[global::System.Runtime.InteropServices.TypeLibType(2)]
	[global::System.Runtime.InteropServices.ClassInterface(0)]
	[global::System.Runtime.InteropServices.ComImport]
	public class FramesCollectionClass : global::mshtml.IHTMLFramesCollection2, global::mshtml.FramesCollection
	{
		// Token: 0x0600D744 RID: 55108
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public extern FramesCollectionClass();

		// Token: 0x0600D745 RID: 55109
		[global::System.Runtime.InteropServices.DispId(0)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)]
		public virtual extern object item([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] ref object pvarIndex);

		// Token: 0x170047A4 RID: 18340
		// (get) Token: 0x0600D746 RID: 55110
		[global::System.Runtime.InteropServices.DispId(1001)]
		public virtual extern int length { [global::System.Runtime.InteropServices.DispId(1001)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }
	}
}
