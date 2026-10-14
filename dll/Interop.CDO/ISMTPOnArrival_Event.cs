using System;
using System.Runtime.InteropServices;

namespace CDO
{
	// Token: 0x0200003F RID: 63
	[global::System.Runtime.InteropServices.TypeLibType(16)]
	[global::System.Runtime.InteropServices.ComVisible(false)]
	[global::System.Runtime.InteropServices.ComEventInterface(typeof(global::CDO.ISMTPOnArrival\u0000), typeof(global::CDO.ISMTPOnArrival_EventProvider\u0000))]
	public interface ISMTPOnArrival_Event
	{
		// Token: 0x14000002 RID: 2
		// (add) Token: 0x060000D1 RID: 209
		// (remove) Token: 0x060000D2 RID: 210
		event global::CDO.ISMTPOnArrival_OnArrivalEventHandler OnArrival;
	}
}
