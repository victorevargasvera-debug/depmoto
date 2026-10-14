using System;
using System.Runtime.InteropServices;

namespace SHDocVw
{
	// Token: 0x02000030 RID: 48
	// (Invoke) Token: 0x06000217 RID: 535
	[global::System.Runtime.InteropServices.TypeLibType(16)]
	[global::System.Runtime.InteropServices.ComVisible(false)]
	public delegate void DWebBrowserEvents_BeforeNavigateEventHandler([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string URL, int Flags, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] string TargetFrameName, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] ref object PostData, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] string Headers, [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Out] ref bool Cancel);
}
