using System;
using System.Runtime.InteropServices;

namespace ErrorLogging
{
	// Token: 0x02000005 RID: 5
	public interface ILogApplicationError
	{
		// Token: 0x06000008 RID: 8
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U4)]
		uint LogApplicationError(uint uiError, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] string strSource, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] string strMessage, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] string strStackTrace);
	}
}
