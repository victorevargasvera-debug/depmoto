using System;
using System.Runtime.InteropServices;

namespace ADODB
{
	// Token: 0x0200005C RID: 92
	// (Invoke) Token: 0x0600028F RID: 655
	[global::System.Runtime.InteropServices.ComVisible(false)]
	public delegate void ConnectionEvents_WillConnectEventHandler([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Out] ref string ConnectionString, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Out] ref string UserID, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Out] ref string Password, [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Out] ref int Options, [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Out] ref global::ADODB.EventStatusEnum adStatus, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::ADODB.Connection pConnection);
}
