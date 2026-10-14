using System;

namespace AxSHDocVw
{
	// Token: 0x0200003A RID: 58
	public class DWebBrowserEvents2_ProgressChangeEvent
	{
		// Token: 0x06000135 RID: 309 RVA: 0x00003FD4 File Offset: 0x00002FD4
		public DWebBrowserEvents2_ProgressChangeEvent(int progress, int progressMax)
		{
			this.progress = progress;
			this.progressMax = progressMax;
		}

		// Token: 0x04000051 RID: 81
		public int progress;

		// Token: 0x04000052 RID: 82
		public int progressMax;
	}
}
