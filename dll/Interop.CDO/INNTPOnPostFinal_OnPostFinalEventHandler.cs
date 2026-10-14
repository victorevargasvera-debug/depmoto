using System;
using System.Runtime.InteropServices;

namespace CDO
{
	// Token: 0x02000052 RID: 82
	// (Invoke) Token: 0x060000EC RID: 236
	[global::System.Runtime.InteropServices.TypeLibType(16)]
	[global::System.Runtime.InteropServices.ComVisible(false)]
	public delegate void INNTPOnPostFinal_OnPostFinalEventHandler([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::CDO.IMessage Msg, [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Out] ref global::CDO.CdoEventStatus EventStatus);
}
