using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace CDO
{
	// Token: 0x02000043 RID: 67
	[global::System.Runtime.InteropServices.TypeLibType(4288)]
	[global::System.Runtime.InteropServices.Guid("CD000026-8B95-11D1-82DB-00C04FB1625D")]
	[global::System.Runtime.InteropServices.ComImport]
	public interface ISMTPOnArrival
	{
		// Token: 0x060000D5 RID: 213
		[global::System.Runtime.InteropServices.DispId(256)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void OnArrival([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::CDO.IMessage Msg, [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Out] ref global::CDO.CdoEventStatus EventStatus);
	}
}
