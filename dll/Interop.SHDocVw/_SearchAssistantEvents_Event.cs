using System;
using System.Runtime.InteropServices;

namespace SHDocVw
{
	// Token: 0x02000068 RID: 104
	[global::System.Runtime.InteropServices.TypeLibType(16)]
	[global::System.Runtime.InteropServices.ComEventInterface(typeof(global::SHDocVw._SearchAssistantEvents\u0000), typeof(global::SHDocVw._SearchAssistantEvents_EventProvider\u0000))]
	[global::System.Runtime.InteropServices.ComVisible(false)]
	public interface _SearchAssistantEvents_Event
	{
		// Token: 0x14000104 RID: 260
		// (add) Token: 0x060005E2 RID: 1506
		// (remove) Token: 0x060005E3 RID: 1507
		event global::SHDocVw._SearchAssistantEvents_OnNextMenuSelectEventHandler OnNextMenuSelect;

		// Token: 0x14000105 RID: 261
		// (add) Token: 0x060005E4 RID: 1508
		// (remove) Token: 0x060005E5 RID: 1509
		event global::SHDocVw._SearchAssistantEvents_OnNewSearchEventHandler OnNewSearch;
	}
}
