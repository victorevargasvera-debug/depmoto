using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace mshtml
{
	// Token: 0x020007B5 RID: 1973
	[global::System.Reflection.DefaultMember("item")]
	[global::System.Runtime.InteropServices.Guid("332C4426-26CB-11D0-B483-00C04FD90119")]
	[global::System.Runtime.InteropServices.TypeLibType(4160)]
	[global::System.Runtime.InteropServices.ComImport]
	public interface IHTMLFramesCollection2
	{
		// Token: 0x0600D6CD RID: 54989
		[global::System.Runtime.InteropServices.DispId(0)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)]
		object item([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] ref object pvarIndex);

		// Token: 0x17004768 RID: 18280
		// (get) Token: 0x0600D6CE RID: 54990
		[global::System.Runtime.InteropServices.DispId(1001)]
		int length { [global::System.Runtime.InteropServices.DispId(1001)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }
	}
}
