using System;
using System.Runtime.InteropServices;

namespace ADODB
{
	// Token: 0x0200005B RID: 91
	// (Invoke) Token: 0x0600028D RID: 653
	[global::System.Runtime.InteropServices.ComVisible(false)]
	public delegate void ConnectionEvents_ExecuteCompleteEventHandler([global::System.Runtime.InteropServices.In] int RecordsAffected, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::ADODB.Error pError, [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Out] ref global::ADODB.EventStatusEnum adStatus, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::ADODB.Command pCommand, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::ADODB.Recordset pRecordset, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::ADODB.Connection pConnection);
}
