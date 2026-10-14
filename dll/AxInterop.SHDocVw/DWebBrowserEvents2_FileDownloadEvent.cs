using System;

namespace AxSHDocVw
{
	// Token: 0x0200000E RID: 14
	public class DWebBrowserEvents2_FileDownloadEvent
	{
		// Token: 0x060000C7 RID: 199 RVA: 0x00003D10 File Offset: 0x00002D10
		public DWebBrowserEvents2_FileDownloadEvent(bool cancel)
		{
			this.cancel = cancel;
		}

		// Token: 0x0400002F RID: 47
		public bool cancel;
	}
}
