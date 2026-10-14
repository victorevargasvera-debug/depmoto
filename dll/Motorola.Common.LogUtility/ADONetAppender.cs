using System;

namespace Motorola.Common.LogUtility
{
	// Token: 0x02000007 RID: 7
	public class ADONetAppender : global::Motorola.Common.LogUtility.IAppender
	{
		// Token: 0x0600003F RID: 63 RVA: 0x00002A9F File Offset: 0x00000C9F
		public ADONetAppender()
		{
			this.LoggingEvent += this.AccessAppender_LoggingEvent;
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00002AB9 File Offset: 0x00000CB9
		private void AccessAppender_LoggingEvent(object sender, global::Motorola.Common.LogUtility.LoggingEventArgs e)
		{
			throw new global::System.NotImplementedException("The method or operation is not implemented.");
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00002AC5 File Offset: 0x00000CC5
		public void Close()
		{
		}

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x06000042 RID: 66 RVA: 0x00002AC8 File Offset: 0x00000CC8
		// (remove) Token: 0x06000043 RID: 67 RVA: 0x00002B00 File Offset: 0x00000D00
		public event global::System.EventHandler<global::Motorola.Common.LogUtility.LoggingEventArgs> LoggingEvent;

		// Token: 0x06000044 RID: 68 RVA: 0x00002B35 File Offset: 0x00000D35
		public void DoAppend(object sender, global::Motorola.Common.LogUtility.LoggingEventArgs e)
		{
			if (this.LoggingEvent != null)
			{
				this.LoggingEvent(sender, e);
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000045 RID: 69 RVA: 0x00002B4C File Offset: 0x00000D4C
		// (set) Token: 0x06000046 RID: 70 RVA: 0x00002B53 File Offset: 0x00000D53
		public string Name
		{
			get
			{
				return string.Empty;
			}
			set
			{
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000047 RID: 71 RVA: 0x00002B55 File Offset: 0x00000D55
		public bool IsEnabled
		{
			get
			{
				return true;
			}
		}

		// Token: 0x04000013 RID: 19
		private static object locker = new object();
	}
}
