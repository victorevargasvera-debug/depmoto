using System;
using System.Runtime.InteropServices;

namespace ADODB
{
	// Token: 0x02000077 RID: 119
	// (Invoke) Token: 0x060003A3 RID: 931
	[global::System.Runtime.InteropServices.ComVisible(false)]
	public delegate void RecordsetEvents_FetchCompleteEventHandler([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::ADODB.Error pError, [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Out] ref global::ADODB.EventStatusEnum adStatus, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::ADODB.Recordset pRecordset);
}
