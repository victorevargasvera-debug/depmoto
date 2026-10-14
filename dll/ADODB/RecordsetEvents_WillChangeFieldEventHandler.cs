using System;
using System.Runtime.InteropServices;

namespace ADODB
{
	// Token: 0x0200006D RID: 109
	// (Invoke) Token: 0x0600038F RID: 911
	[global::System.Runtime.InteropServices.ComVisible(false)]
	public delegate void RecordsetEvents_WillChangeFieldEventHandler([global::System.Runtime.InteropServices.In] int cFields, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] object Fields, [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Out] ref global::ADODB.EventStatusEnum adStatus, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::ADODB.Recordset pRecordset);
}
