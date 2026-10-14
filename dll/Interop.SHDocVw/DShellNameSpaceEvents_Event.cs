using System;
using System.Runtime.InteropServices;

namespace SHDocVw
{
	// Token: 0x02000058 RID: 88
	[global::System.Runtime.InteropServices.TypeLibType(16)]
	[global::System.Runtime.InteropServices.ComVisible(false)]
	[global::System.Runtime.InteropServices.ComEventInterface(typeof(global::SHDocVw.DShellNameSpaceEvents\u0000), typeof(global::SHDocVw.DShellNameSpaceEvents_EventProvider\u0000))]
	public interface DShellNameSpaceEvents_Event
	{
		// Token: 0x140000FE RID: 254
		// (add) Token: 0x06000532 RID: 1330
		// (remove) Token: 0x06000533 RID: 1331
		event global::SHDocVw.DShellNameSpaceEvents_FavoritesSelectionChangeEventHandler FavoritesSelectionChange;

		// Token: 0x140000FF RID: 255
		// (add) Token: 0x06000534 RID: 1332
		// (remove) Token: 0x06000535 RID: 1333
		event global::SHDocVw.DShellNameSpaceEvents_SelectionChangeEventHandler SelectionChange;

		// Token: 0x14000100 RID: 256
		// (add) Token: 0x06000536 RID: 1334
		// (remove) Token: 0x06000537 RID: 1335
		event global::SHDocVw.DShellNameSpaceEvents_DoubleClickEventHandler DoubleClick;

		// Token: 0x14000101 RID: 257
		// (add) Token: 0x06000538 RID: 1336
		// (remove) Token: 0x06000539 RID: 1337
		event global::SHDocVw.DShellNameSpaceEvents_InitializedEventHandler Initialized;
	}
}
