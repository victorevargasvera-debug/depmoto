using System;
using System.Runtime.InteropServices;

namespace CDO
{
	// Token: 0x02000051 RID: 81
	[global::System.Runtime.InteropServices.ComVisible(false)]
	[global::System.Runtime.InteropServices.TypeLibType(16)]
	[global::System.Runtime.InteropServices.ComEventInterface(typeof(global::CDO.INNTPOnPostFinal\u0000), typeof(global::CDO.INNTPOnPostFinal_EventProvider\u0000))]
	public interface INNTPOnPostFinal_Event
	{
		// Token: 0x14000008 RID: 8
		// (add) Token: 0x060000E9 RID: 233
		// (remove) Token: 0x060000EA RID: 234
		event global::CDO.INNTPOnPostFinal_OnPostFinalEventHandler OnPostFinal;
	}
}
