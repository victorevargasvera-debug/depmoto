using System;
using System.Runtime.InteropServices;

namespace CDO
{
	// Token: 0x0200004C RID: 76
	// (Invoke) Token: 0x060000E4 RID: 228
	[global::System.Runtime.InteropServices.TypeLibType(16)]
	[global::System.Runtime.InteropServices.ComVisible(false)]
	public delegate void INNTPOnPost_OnPostEventHandler([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::CDO.IMessage Msg, [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Out] ref global::CDO.CdoEventStatus EventStatus);
}
