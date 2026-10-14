using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace mshtml
{
	// Token: 0x0200009F RID: 159
	[global::System.Reflection.DefaultMember("FireEvent")]
	[global::System.Runtime.InteropServices.Guid("3050F5F4-98B5-11CF-BB82-00AA00BDCE0B")]
	[global::System.Runtime.InteropServices.TypeLibType(4160)]
	[global::System.Runtime.InteropServices.ComImport]
	public interface IHTCAttachBehavior
	{
		// Token: 0x06000D76 RID: 3446
		[global::System.Runtime.InteropServices.DispId(0)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void FireEvent([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] [global::System.Runtime.InteropServices.In] object evt);

		// Token: 0x06000D77 RID: 3447
		[global::System.Runtime.InteropServices.DispId(-2147417612)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void detachEvent();
	}
}
