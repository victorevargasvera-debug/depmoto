using System;

namespace AxSHDocVw
{
	// Token: 0x02000032 RID: 50
	public class DWebBrowserEvents2_BeforeNavigate2Event
	{
		// Token: 0x06000121 RID: 289 RVA: 0x00003F30 File Offset: 0x00002F30
		public DWebBrowserEvents2_BeforeNavigate2Event(object pDisp, object uRL, object flags, object targetFrameName, object postData, object headers, bool cancel)
		{
			this.pDisp = pDisp;
			this.uRL = uRL;
			this.flags = flags;
			this.targetFrameName = targetFrameName;
			this.postData = postData;
			this.headers = headers;
			this.cancel = cancel;
		}

		// Token: 0x04000046 RID: 70
		public object pDisp;

		// Token: 0x04000047 RID: 71
		public object uRL;

		// Token: 0x04000048 RID: 72
		public object flags;

		// Token: 0x04000049 RID: 73
		public object targetFrameName;

		// Token: 0x0400004A RID: 74
		public object postData;

		// Token: 0x0400004B RID: 75
		public object headers;

		// Token: 0x0400004C RID: 76
		public bool cancel;
	}
}
