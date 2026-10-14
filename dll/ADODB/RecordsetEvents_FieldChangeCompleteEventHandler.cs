using System;
using System.Runtime.InteropServices;

namespace ADODB
{
	// Token: 0x0200006E RID: 110
	// (Invoke) Token: 0x06000391 RID: 913
	[global::System.Runtime.InteropServices.ComVisible(false)]
	public delegate void RecordsetEvents_FieldChangeCompleteEventHandler([global::System.Runtime.InteropServices.In] int cFields, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] object Fields, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::ADODB.Error pError, [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Out] ref global::ADODB.EventStatusEnum adStatus, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::ADODB.Recordset pRecordset);
}
