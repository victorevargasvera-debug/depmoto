using System;

namespace Motorola.Common.LogUtility
{
	// Token: 0x02000004 RID: 4
	public class DbgViewAppender : global::Motorola.Common.LogUtility.IAppender
	{
		// Token: 0x0600000F RID: 15 RVA: 0x000021F8 File Offset: 0x000003F8
		public DbgViewAppender()
		{
			this.LoggingEvent += this.DbgViewAppender_LoggingEvent;
		}

		// Token: 0x06000010 RID: 16 RVA: 0x0000221D File Offset: 0x0000041D
		private void DbgViewAppender_LoggingEvent(object sender, global::Motorola.Common.LogUtility.LoggingEventArgs e)
		{
		}

		// Token: 0x06000011 RID: 17 RVA: 0x0000221F File Offset: 0x0000041F
		public void Close()
		{
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x06000012 RID: 18 RVA: 0x00002224 File Offset: 0x00000424
		// (remove) Token: 0x06000013 RID: 19 RVA: 0x0000225C File Offset: 0x0000045C
		public event global::System.EventHandler<global::Motorola.Common.LogUtility.LoggingEventArgs> LoggingEvent;

		// Token: 0x06000014 RID: 20 RVA: 0x00002294 File Offset: 0x00000494
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

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000015 RID: 21 RVA: 0x000022E4 File Offset: 0x000004E4
		// (set) Token: 0x06000016 RID: 22 RVA: 0x000022EC File Offset: 0x000004EC
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

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000017 RID: 23 RVA: 0x000022F5 File Offset: 0x000004F5
		public bool IsEnabled
		{
			get
			{
				return true;
			}
		}

		// Token: 0x04000004 RID: 4
		private object locker = new object();

		// Token: 0x04000006 RID: 6
		private string name;
	}
}
