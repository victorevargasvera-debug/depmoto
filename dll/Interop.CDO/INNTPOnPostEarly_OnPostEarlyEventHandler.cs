using System;
using System.Runtime.InteropServices;

namespace CDO
{
	// Token: 0x02000046 RID: 70
	// (Invoke) Token: 0x060000DC RID: 220
	[global::System.Runtime.InteropServices.TypeLibType(16)]
	[global::System.Runtime.InteropServices.ComVisible(false)]
	public delegate void INNTPOnPostEarly_OnPostEarlyEventHandler([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::CDO.IMessage Msg, [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Out] ref global::CDO.CdoEventStatus EventStatus);
}
