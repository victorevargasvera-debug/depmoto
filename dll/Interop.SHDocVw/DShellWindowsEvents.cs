using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SHDocVw
{
	// Token: 0x0200004A RID: 74
	[global::System.Runtime.InteropServices.TypeLibType(4096)]
	[global::System.Runtime.InteropServices.InterfaceType(2)]
	[global::System.Runtime.InteropServices.Guid("FE4106E0-399A-11D0-A48C-00A0C90A8F39")]
	[global::System.Runtime.InteropServices.ComImport]
	public interface DShellWindowsEvents
	{
		// Token: 0x06000494 RID: 1172
		[global::System.Runtime.InteropServices.DispId(200)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void WindowRegistered([global::System.Runtime.InteropServices.In] int lCookie);

		// Token: 0x06000495 RID: 1173
		[global::System.Runtime.InteropServices.DispId(201)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void WindowRevoked([global::System.Runtime.InteropServices.In] int lCookie);
	}
}
