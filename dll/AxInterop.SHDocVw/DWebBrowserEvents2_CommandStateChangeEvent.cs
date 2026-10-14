using System;

namespace AxSHDocVw
{
	// Token: 0x02000038 RID: 56
	public class DWebBrowserEvents2_CommandStateChangeEvent
	{
		// Token: 0x06000130 RID: 304 RVA: 0x00003FB0 File Offset: 0x00002FB0
		public DWebBrowserEvents2_CommandStateChangeEvent(int command, bool enable)
		{
			this.command = command;
			this.enable = enable;
		}

		// Token: 0x0400004F RID: 79
		public int command;

		// Token: 0x04000050 RID: 80
		public bool enable;
	}
}
