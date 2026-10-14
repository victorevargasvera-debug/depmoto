using System;
using System.Runtime.InteropServices;

namespace ADODB
{
	// Token: 0x02000071 RID: 113
	// (Invoke) Token: 0x06000397 RID: 919
	[global::System.Runtime.InteropServices.ComVisible(false)]
	public delegate void RecordsetEvents_WillChangeRecordsetEventHandler([global::System.Runtime.InteropServices.In] global::ADODB.EventReasonEnum adReason, [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Out] ref global::ADODB.EventStatusEnum adStatus, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::ADODB.Recordset pRecordset);
}
