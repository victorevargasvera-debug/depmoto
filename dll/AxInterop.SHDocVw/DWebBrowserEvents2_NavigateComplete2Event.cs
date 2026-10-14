using System;

namespace AxSHDocVw
{
	// Token: 0x0200002E RID: 46
	public class DWebBrowserEvents2_NavigateComplete2Event
	{
		// Token: 0x06000117 RID: 279 RVA: 0x00003EE8 File Offset: 0x00002EE8
		public DWebBrowserEvents2_NavigateComplete2Event(object pDisp, object uRL)
		{
			this.pDisp = pDisp;
			this.uRL = uRL;
		}

		// Token: 0x04000042 RID: 66
		public object pDisp;

		// Token: 0x04000043 RID: 67
		public object uRL;
	}
}
