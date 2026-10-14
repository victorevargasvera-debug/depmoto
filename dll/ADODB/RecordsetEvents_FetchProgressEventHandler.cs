using System;
using System.Runtime.InteropServices;

namespace ADODB
{
	// Token: 0x02000076 RID: 118
	// (Invoke) Token: 0x060003A1 RID: 929
	[global::System.Runtime.InteropServices.ComVisible(false)]
	public delegate void RecordsetEvents_FetchProgressEventHandler([global::System.Runtime.InteropServices.In] int Progress, [global::System.Runtime.InteropServices.In] int MaxProgress, [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Out] ref global::ADODB.EventStatusEnum adStatus, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::ADODB.Recordset pRecordset);
}
