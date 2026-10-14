using System;
using System.Runtime.InteropServices;

namespace ADODB
{
	// Token: 0x02000073 RID: 115
	// (Invoke) Token: 0x0600039B RID: 923
	[global::System.Runtime.InteropServices.ComVisible(false)]
	public delegate void RecordsetEvents_WillMoveEventHandler([global::System.Runtime.InteropServices.In] global::ADODB.EventReasonEnum adReason, [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Out] ref global::ADODB.EventStatusEnum adStatus, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::ADODB.Recordset pRecordset);
}
