using System;

namespace AxSHDocVw
{
	// Token: 0x0200000C RID: 12
	public class DWebBrowserEvents2_NavigateErrorEvent
	{
		// Token: 0x060000C2 RID: 194 RVA: 0x00003CD8 File Offset: 0x00002CD8
		public DWebBrowserEvents2_NavigateErrorEvent(object pDisp, object uRL, object frame, object statusCode, bool cancel)
		{
			this.pDisp = pDisp;
			this.uRL = uRL;
			this.frame = frame;
			this.statusCode = statusCode;
			this.cancel = cancel;
		}

		// Token: 0x0400002A RID: 42
		public object pDisp;

		// Token: 0x0400002B RID: 43
		public object uRL;

		// Token: 0x0400002C RID: 44
		public object frame;

		// Token: 0x0400002D RID: 45
		public object statusCode;

		// Token: 0x0400002E RID: 46
		public bool cancel;
	}
}
