using System;
using System.Runtime.InteropServices;

namespace CDO
{
	// Token: 0x02000040 RID: 64
	// (Invoke) Token: 0x060000D4 RID: 212
	[global::System.Runtime.InteropServices.TypeLibType(16)]
	[global::System.Runtime.InteropServices.ComVisible(false)]
	public delegate void ISMTPOnArrival_OnArrivalEventHandler([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::CDO.IMessage Msg, [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Out] ref global::CDO.CdoEventStatus EventStatus);
}
