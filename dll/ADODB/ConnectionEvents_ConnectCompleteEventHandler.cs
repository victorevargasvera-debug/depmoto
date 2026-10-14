using System;
using System.Runtime.InteropServices;

namespace ADODB
{
	// Token: 0x0200005D RID: 93
	// (Invoke) Token: 0x06000291 RID: 657
	[global::System.Runtime.InteropServices.ComVisible(false)]
	public delegate void ConnectionEvents_ConnectCompleteEventHandler([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::ADODB.Error pError, [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Out] ref global::ADODB.EventStatusEnum adStatus, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::ADODB.Connection pConnection);
}
