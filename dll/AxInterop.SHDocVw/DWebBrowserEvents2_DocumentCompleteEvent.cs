using System;

namespace AxSHDocVw
{
	// Token: 0x0200002C RID: 44
	public class DWebBrowserEvents2_DocumentCompleteEvent
	{
		// Token: 0x06000112 RID: 274 RVA: 0x00003EC4 File Offset: 0x00002EC4
		public DWebBrowserEvents2_DocumentCompleteEvent(object pDisp, object uRL)
		{
			this.pDisp = pDisp;
			this.uRL = uRL;
		}

		// Token: 0x04000040 RID: 64
		public object pDisp;

		// Token: 0x04000041 RID: 65
		public object uRL;
	}
}
