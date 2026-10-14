using System;
using System.Runtime.InteropServices;

namespace ADODB
{
	// Token: 0x02000075 RID: 117
	// (Invoke) Token: 0x0600039F RID: 927
	[global::System.Runtime.InteropServices.ComVisible(false)]
	public delegate void RecordsetEvents_EndOfRecordsetEventHandler([global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Out] ref bool fMoreData, [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Out] ref global::ADODB.EventStatusEnum adStatus, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::ADODB.Recordset pRecordset);
}
