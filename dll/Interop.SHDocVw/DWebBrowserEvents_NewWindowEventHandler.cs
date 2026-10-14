using System;
using System.Runtime.InteropServices;

namespace SHDocVw
{
	// Token: 0x02000037 RID: 55
	// (Invoke) Token: 0x06000225 RID: 549
	[global::System.Runtime.InteropServices.TypeLibType(16)]
	[global::System.Runtime.InteropServices.ComVisible(false)]
	public delegate void DWebBrowserEvents_NewWindowEventHandler([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string URL, [global::System.Runtime.InteropServices.In] int Flags, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string TargetFrameName, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] ref object PostData, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string Headers, [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Out] ref bool Processed);
}
