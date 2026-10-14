using System;

namespace AxSHDocVw
{
	// Token: 0x02000012 RID: 18
	public class DWebBrowserEvents2_ClientToHostWindowEvent
	{
		// Token: 0x060000D1 RID: 209 RVA: 0x00003D48 File Offset: 0x00002D48
		public DWebBrowserEvents2_ClientToHostWindowEvent(int cX, int cY)
		{
			this.cX = cX;
			this.cY = cY;
		}

		// Token: 0x04000031 RID: 49
		public int cX;

		// Token: 0x04000032 RID: 50
		public int cY;
	}
}
