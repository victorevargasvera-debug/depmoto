using System;
using System.Diagnostics;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x02000007 RID: 7
	public class EventLogger : global::System.IDisposable
	{
		// Token: 0x0600000C RID: 12 RVA: 0x000021E4 File Offset: 0x000003E4
		public EventLogger(string name = "Motorola Device Communication")
		{
			this.m_EventSourceName = name;
			this.CreateEventLog();
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002204 File Offset: 0x00000404
		public void CreateEventLog()
		{
			try
			{
				if (!global::System.Diagnostics.EventLog.SourceExists(this.m_EventSourceName))
				{
					global::System.Diagnostics.EventLog.CreateEventSource(this.m_EventSourceName, "Application");
				}
				this.m_EvLog = new global::System.Diagnostics.EventLog();
				this.m_EvLog.Source = this.m_EventSourceName;
				this.m_EvLog.Log = "Application";
			}
			catch (global::System.Exception)
			{
				this.m_EvLog = null;
			}
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002284 File Offset: 0x00000484
		public void WriteError(string message)
		{
			if (this.m_EvLog == null)
			{
				this.CreateEventLog();
			}
			if (this.m_EvLog != null)
			{
				try
				{
					this.m_EvLog.WriteEntry(message, global::System.Diagnostics.EventLogEntryType.Error);
				}
				catch
				{
				}
			}
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000022E4 File Offset: 0x000004E4
		public void WriteWarning(string message)
		{
			if (this.m_EvLog == null)
			{
				this.CreateEventLog();
			}
			if (this.m_EvLog != null)
			{
				try
				{
					this.m_EvLog.WriteEntry(message, global::System.Diagnostics.EventLogEntryType.Warning);
				}
				catch
				{
				}
			}
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002344 File Offset: 0x00000544
		public void WriteInfo(string message)
		{
			if (this.m_EvLog == null)
			{
				this.CreateEventLog();
			}
			if (this.m_EvLog != null)
			{
				try
				{
					this.m_EvLog.WriteEntry(message, global::System.Diagnostics.EventLogEntryType.Information);
				}
				catch
				{
				}
			}
		}

		// Token: 0x06000011 RID: 17 RVA: 0x000023A4 File Offset: 0x000005A4
		protected virtual void Dispose(bool disposing)
		{
			if (!this.m_IsDisposed)
			{
				if (disposing)
				{
					if (this.m_EvLog != null)
					{
						this.m_EvLog.Close();
						this.m_EvLog.Dispose();
					}
				}
				this.m_IsDisposed = true;
			}
		}

		// Token: 0x06000012 RID: 18 RVA: 0x000023F6 File Offset: 0x000005F6
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x0400000E RID: 14
		private global::System.Diagnostics.EventLog m_EvLog = null;

		// Token: 0x0400000F RID: 15
		private string m_EventSourceName;

		// Token: 0x04000010 RID: 16
		private bool m_IsDisposed;
	}
}
