using System;

namespace AxSHDocVw
{
	// Token: 0x02000030 RID: 48
	public class DWebBrowserEvents2_NewWindow2Event
	{
		// Token: 0x0600011C RID: 284 RVA: 0x00003F0C File Offset: 0x00002F0C
		public DWebBrowserEvents2_NewWindow2Event(object ppDisp, bool cancel)
		{
			this.ppDisp = ppDisp;
			this.cancel = cancel;
		}

		// Token: 0x04000044 RID: 68
		public object ppDisp;

		// Token: 0x04000045 RID: 69
		public bool cancel;
	}
}
