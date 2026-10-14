using System;
using System.Runtime.InteropServices;

namespace ADODB
{
	// Token: 0x02000074 RID: 116
	// (Invoke) Token: 0x0600039D RID: 925
	[global::System.Runtime.InteropServices.ComVisible(false)]
	public delegate void RecordsetEvents_MoveCompleteEventHandler([global::System.Runtime.InteropServices.In] global::ADODB.EventReasonEnum adReason, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::ADODB.Error pError, [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Out] ref global::ADODB.EventStatusEnum adStatus, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::ADODB.Recordset pRecordset);
}
