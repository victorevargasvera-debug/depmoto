using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace ADODB
{
	// Token: 0x02000056 RID: 86
	// (Invoke) Token: 0x06000283 RID: 643
	[global::System.Reflection.DefaultMember("Invoke")]
	[global::System.Runtime.InteropServices.ComVisible(false)]
	public delegate void ConnectionEvents_InfoMessageEventHandler([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::ADODB.Error pError, [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Out] ref global::ADODB.EventStatusEnum adStatus, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::ADODB.Connection pConnection);
}
