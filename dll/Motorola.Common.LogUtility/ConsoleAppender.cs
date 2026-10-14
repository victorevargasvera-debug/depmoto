using System;

namespace Motorola.Common.LogUtility
{
	// Token: 0x02000003 RID: 3
	public class ConsoleAppender : global::Motorola.Common.LogUtility.IAppender
	{
		// Token: 0x06000006 RID: 6 RVA: 0x000020D0 File Offset: 0x000002D0
		public ConsoleAppender()
		{
			this.LoggingEvent += this.ConsoleAppender_LoggingEvent;
		}

		// Token: 0x06000007 RID: 7 RVA: 0x000020F5 File Offset: 0x000002F5
		private void ConsoleAppender_LoggingEvent(object sender, global::Motorola.Common.LogUtility.LoggingEventArgs e)
		{
			global::System.Console.WriteLine(global::Motorola.Common.LogUtility.LoggerUtil.LogTitle(((global::Motorola.Common.LogUtility.LogImpl)sender).Name, e));
			global::System.Console.WriteLine(global::Motorola.Common.LogUtility.LoggerUtil.LogBody(e));
			global::System.Console.WriteLine("----------------------------------------");
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002122 File Offset: 0x00000322
		public void Close()
		{
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000009 RID: 9 RVA: 0x00002124 File Offset: 0x00000324
		// (remove) Token: 0x0600000A RID: 10 RVA: 0x0000215C File Offset: 0x0000035C
		public event global::System.EventHandler<global::Motorola.Common.LogUtility.LoggingEventArgs> LoggingEvent;

		// Token: 0x0600000B RID: 11 RVA: 0x00002194 File Offset: 0x00000394
		public void DoAppend(object sender, global::Motorola.Common.LogUtility.LoggingEventArgs e)
		{
			if (this.LoggingEvent != null)
			{
				lock (this.locker)
				{
					this.LoggingEvent(sender, e);
				}
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600000C RID: 12 RVA: 0x000021E4 File Offset: 0x000003E4
		// (set) Token: 0x0600000D RID: 13 RVA: 0x000021EC File Offset: 0x000003EC
		public string Name
		{
			get
			{
				return this.name;
			}
			set
			{
				this.name = value;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600000E RID: 14 RVA: 0x000021F5 File Offset: 0x000003F5
		public bool IsEnabled
		{
			get
			{
				return true;
			}
		}

		// Token: 0x04000001 RID: 1
		private object locker = new object();

		// Token: 0x04000003 RID: 3
		private string name;
	}
}
