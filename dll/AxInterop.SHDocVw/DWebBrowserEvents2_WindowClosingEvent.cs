using System;

namespace AxSHDocVw
{
	// Token: 0x02000014 RID: 20
	public class DWebBrowserEvents2_WindowClosingEvent
	{
		// Token: 0x060000D6 RID: 214 RVA: 0x00003D6C File Offset: 0x00002D6C
		public DWebBrowserEvents2_WindowClosingEvent(bool isChildWindow, bool cancel)
		{
			this.isChildWindow = isChildWindow;
			this.cancel = cancel;
		}

		// Token: 0x04000033 RID: 51
		public bool isChildWindow;

		// Token: 0x04000034 RID: 52
		public bool cancel;
	}
}
