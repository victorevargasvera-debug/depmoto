using System;

namespace AxSHDocVw
{
	// Token: 0x02000006 RID: 6
	public class DWebBrowserEvents2_UpdatePageStatusEvent
	{
		// Token: 0x060000B3 RID: 179 RVA: 0x00003C78 File Offset: 0x00002C78
		public DWebBrowserEvents2_UpdatePageStatusEvent(object pDisp, object nPage, object fDone)
		{
			this.pDisp = pDisp;
			this.nPage = nPage;
			this.fDone = fDone;
		}

		// Token: 0x04000025 RID: 37
		public object pDisp;

		// Token: 0x04000026 RID: 38
		public object nPage;

		// Token: 0x04000027 RID: 39
		public object fDone;
	}
}
