using System;
using System.Runtime.InteropServices;

namespace ADODB
{
	// Token: 0x02000070 RID: 112
	// (Invoke) Token: 0x06000395 RID: 917
	[global::System.Runtime.InteropServices.ComVisible(false)]
	public delegate void RecordsetEvents_RecordChangeCompleteEventHandler([global::System.Runtime.InteropServices.In] global::ADODB.EventReasonEnum adReason, [global::System.Runtime.InteropServices.In] int cRecords, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::ADODB.Error pError, [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Out] ref global::ADODB.EventStatusEnum adStatus, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::ADODB.Recordset pRecordset);
}
