using System;
using System.Runtime.InteropServices;

namespace CDO
{
	// Token: 0x0200004B RID: 75
	[global::System.Runtime.InteropServices.TypeLibType(16)]
	[global::System.Runtime.InteropServices.ComEventInterface(typeof(global::CDO.INNTPOnPost\u0000), typeof(global::CDO.INNTPOnPost_EventProvider\u0000))]
	[global::System.Runtime.InteropServices.ComVisible(false)]
	public interface INNTPOnPost_Event
	{
		// Token: 0x14000006 RID: 6
		// (add) Token: 0x060000E1 RID: 225
		// (remove) Token: 0x060000E2 RID: 226
		event global::CDO.INNTPOnPost_OnPostEventHandler OnPost;
	}
}
