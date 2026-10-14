using System;
using System.Runtime.InteropServices;

namespace ADODB
{
	// Token: 0x02000057 RID: 87
	// (Invoke) Token: 0x06000285 RID: 645
	[global::System.Runtime.InteropServices.ComVisible(false)]
	public delegate void ConnectionEvents_BeginTransCompleteEventHandler([global::System.Runtime.InteropServices.In] int TransactionLevel, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::ADODB.Error pError, [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Out] ref global::ADODB.EventStatusEnum adStatus, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::ADODB.Connection pConnection);
}
