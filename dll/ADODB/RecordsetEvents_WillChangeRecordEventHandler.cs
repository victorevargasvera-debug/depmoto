using System;
using System.Runtime.InteropServices;

namespace ADODB
{
	// Token: 0x0200006F RID: 111
	// (Invoke) Token: 0x06000393 RID: 915
	[global::System.Runtime.InteropServices.ComVisible(false)]
	public delegate void RecordsetEvents_WillChangeRecordEventHandler([global::System.Runtime.InteropServices.In] global::ADODB.EventReasonEnum adReason, [global::System.Runtime.InteropServices.In] int cRecords, [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Out] ref global::ADODB.EventStatusEnum adStatus, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::ADODB.Recordset pRecordset);
}
