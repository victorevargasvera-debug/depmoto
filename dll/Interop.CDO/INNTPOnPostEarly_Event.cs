using System;
using System.Runtime.InteropServices;

namespace CDO
{
	// Token: 0x02000045 RID: 69
	[global::System.Runtime.InteropServices.TypeLibType(16)]
	[global::System.Runtime.InteropServices.ComEventInterface(typeof(global::CDO.INNTPOnPostEarly\u0000), typeof(global::CDO.INNTPOnPostEarly_EventProvider\u0000))]
	[global::System.Runtime.InteropServices.ComVisible(false)]
	public interface INNTPOnPostEarly_Event
	{
		// Token: 0x14000004 RID: 4
		// (add) Token: 0x060000D9 RID: 217
		// (remove) Token: 0x060000DA RID: 218
		event global::CDO.INNTPOnPostEarly_OnPostEarlyEventHandler OnPostEarly;
	}
}
