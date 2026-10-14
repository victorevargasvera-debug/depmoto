using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace mshtml
{
	// Token: 0x020000A0 RID: 160
	[global::System.Runtime.InteropServices.TypeLibType(4160)]
	[global::System.Reflection.DefaultMember("FireEvent")]
	[global::System.Runtime.InteropServices.Guid("3050F7EB-98B5-11CF-BB82-00AA00BDCE0B")]
	[global::System.Runtime.InteropServices.ComImport]
	public interface IHTCAttachBehavior2
	{
		// Token: 0x06000D78 RID: 3448
		[global::System.Runtime.InteropServices.DispId(0)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void FireEvent([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] object evt);
	}
}
