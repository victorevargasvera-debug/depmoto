using System;
using System.Runtime.InteropServices;

namespace SHDocVw
{
	// Token: 0x0200004D RID: 77
	[global::System.Runtime.InteropServices.TypeLibType(16)]
	[global::System.Runtime.InteropServices.ComVisible(false)]
	[global::System.Runtime.InteropServices.ComEventInterface(typeof(global::SHDocVw.DShellWindowsEvents\u0000), typeof(global::SHDocVw.DShellWindowsEvents_EventProvider\u0000))]
	public interface DShellWindowsEvents_Event
	{
		// Token: 0x140000F8 RID: 248
		// (add) Token: 0x060004B1 RID: 1201
		// (remove) Token: 0x060004B2 RID: 1202
		event global::SHDocVw.DShellWindowsEvents_WindowRegisteredEventHandler WindowRegistered;

		// Token: 0x140000F9 RID: 249
		// (add) Token: 0x060004B3 RID: 1203
		// (remove) Token: 0x060004B4 RID: 1204
		event global::SHDocVw.DShellWindowsEvents_WindowRevokedEventHandler WindowRevoked;
	}
}
