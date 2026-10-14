using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace CDO
{
	// Token: 0x02000049 RID: 73
	[global::System.Runtime.InteropServices.TypeLibType(4288)]
	[global::System.Runtime.InteropServices.Guid("CD000033-8B95-11D1-82DB-00C04FB1625D")]
	[global::System.Runtime.InteropServices.ComImport]
	public interface INNTPOnPostEarly
	{
		// Token: 0x060000DD RID: 221
		[global::System.Runtime.InteropServices.DispId(256)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void OnPostEarly([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::CDO.IMessage Msg, [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Out] ref global::CDO.CdoEventStatus EventStatus);
	}
}
