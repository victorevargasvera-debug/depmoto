using System;
using System.Runtime.InteropServices;

namespace mshtml
{
	// Token: 0x02000CD8 RID: 3288
	[global::System.Runtime.InteropServices.ComVisible(false)]
	[global::System.Runtime.InteropServices.ComEventInterface(typeof(global::mshtml.HTMLNamespaceEvents\u0000), typeof(global::mshtml.HTMLNamespaceEvents_EventProvider\u0000))]
	public interface HTMLNamespaceEvents_Event
	{
		// Token: 0x14002B07 RID: 11015
		// (add) Token: 0x0601634D RID: 90957
		// (remove) Token: 0x0601634E RID: 90958
		event global::mshtml.HTMLNamespaceEvents_onreadystatechangeEventHandler onreadystatechange;
	}
}
