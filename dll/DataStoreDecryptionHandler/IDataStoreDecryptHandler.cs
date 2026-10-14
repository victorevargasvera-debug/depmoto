using System;
using System.Runtime.InteropServices;

namespace SSLAdminTool
{
	// Token: 0x02000002 RID: 2
	[global::System.Runtime.InteropServices.InterfaceType(global::System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIUnknown)]
	[global::System.Runtime.InteropServices.Guid("8678ff6f-57a6-37a1-90e6-b1653866980c")]
	[global::System.Runtime.InteropServices.ComVisible(true)]
	public interface IDataStoreDecryptHandler
	{
		// Token: 0x06000001 RID: 1
		string PatDataStoreRead();

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000002 RID: 2
		bool XStoreAvailable { get; }

		// Token: 0x06000003 RID: 3
		void dhUpdateEventThread();

		// Token: 0x06000004 RID: 4
		bool isDHkeyExpired();
	}
}
