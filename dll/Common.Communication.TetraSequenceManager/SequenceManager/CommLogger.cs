using System;
using Motorola.Common.LogUtility;

namespace Motorola.Common.Communication.SequenceManager
{
	// Token: 0x02000002 RID: 2
	public class CommLogger : global::Motorola.Common.LogUtility.ILog
	{
		// Token: 0x06000001 RID: 1 RVA: 0x000020D0 File Offset: 0x000002D0
		public CommLogger(object caller, string loggerName)
		{
			this._caller = caller;
			this._loggerName = loggerName;
		}

		// Token: 0x06000002 RID: 2 RVA: 0x000020F1 File Offset: 0x000002F1
		public void Debug(string message)
		{
			global::Motorola.Common.LogUtility.LogManager.GetLogger(this._loggerName).Debug(string.Format("{0}{1}", this.CallerToString(this._caller), message));
		}

		// Token: 0x06000003 RID: 3 RVA: 0x0000211A File Offset: 0x0000031A
		public void Debug(string format, params object[] message)
		{
			global::Motorola.Common.LogUtility.LogManager.GetLogger(this._loggerName).Debug(string.Format("{0}{1}", this.CallerToString(this._caller), format), message);
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002144 File Offset: 0x00000344
		public void Error(string message)
		{
			global::Motorola.Common.LogUtility.LogManager.GetLogger(this._loggerName).Debug(string.Format("{0}{1}", this.CallerToString(this._caller), message));
		}

		// Token: 0x06000005 RID: 5 RVA: 0x0000216D File Offset: 0x0000036D
		public void Error(string format, params object[] message)
		{
			global::Motorola.Common.LogUtility.LogManager.GetLogger(this._loggerName).Error(string.Format("{0}{1}", this.CallerToString(this._caller), format), message);
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002197 File Offset: 0x00000397
		public void Error(global::System.Exception e, string message)
		{
			global::Motorola.Common.LogUtility.LogManager.GetLogger(this._loggerName).Error(e, string.Format("{0}{1}", this.CallerToString(this._caller), message));
		}

		// Token: 0x06000007 RID: 7 RVA: 0x000021C1 File Offset: 0x000003C1
		public void Error(global::System.Exception e, string format, params object[] message)
		{
			global::Motorola.Common.LogUtility.LogManager.GetLogger(this._loggerName).Error(e, string.Format("{0}{1}", this.CallerToString(this._caller), format), message);
		}

		// Token: 0x06000008 RID: 8 RVA: 0x000021EC File Offset: 0x000003EC
		public void UserOperation(string message)
		{
			global::Motorola.Common.LogUtility.LogManager.GetLogger(this._loggerName).UserOperation(string.Format("{0}{1}", this.CallerToString(this._caller), message));
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002215 File Offset: 0x00000415
		public void UserOperation(string format, params object[] message)
		{
			global::Motorola.Common.LogUtility.LogManager.GetLogger(this._loggerName).UserOperation(string.Format("{0}{1}", this.CallerToString(this._caller), format), message);
		}

		// Token: 0x0600000A RID: 10 RVA: 0x0000223F File Offset: 0x0000043F
		public void Performance(string stampName, string message)
		{
			global::Motorola.Common.LogUtility.LogManager.GetLogger(this._loggerName).Performance(stampName, string.Format("{0}{1}", this.CallerToString(this._caller), message));
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002269 File Offset: 0x00000469
		public void Performance(string stampName, string format, params object[] message)
		{
			global::Motorola.Common.LogUtility.LogManager.GetLogger(this._loggerName).Performance(stampName, string.Format("{0}{1}", this.CallerToString(this._caller), format), message);
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002294 File Offset: 0x00000494
		public void SetTimeStampLabel(string labelName)
		{
			global::Motorola.Common.LogUtility.LogManager.GetLogger(this._loggerName).SetTimeStampLabel(labelName);
		}

		// Token: 0x0600000D RID: 13 RVA: 0x000022A8 File Offset: 0x000004A8
		private string CallerToString(object caller)
		{
			if (caller != null)
			{
				string result = string.Empty;
				global::Motorola.Common.Communication.SequenceManager.TetraPhysicalAddressSeqMgr tetraPhysicalAddressSeqMgr = caller as global::Motorola.Common.Communication.SequenceManager.TetraPhysicalAddressSeqMgr;
				if (tetraPhysicalAddressSeqMgr != null)
				{
					result = "[Location:" + tetraPhysicalAddressSeqMgr.Profile.PhysicalLocation + "]\r\n";
				}
				else
				{
					result = "[Location:" + caller.ToString() + "]\r\n";
				}
				return result;
			}
			return "[Location:Unknown]\r\n";
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002302 File Offset: 0x00000502
		public void AddAppender(global::Motorola.Common.LogUtility.IAppender appender)
		{
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002304 File Offset: 0x00000504
		public void EventInfo(string message)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000010 RID: 16 RVA: 0x0000230B File Offset: 0x0000050B
		public void EventWarning(string message)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002312 File Offset: 0x00000512
		public void EventError(string message)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002319 File Offset: 0x00000519
		public void WriteEventEntry(string content, global::Motorola.Common.LogUtility.LoggingLevel level = global::Motorola.Common.LogUtility.LoggingLevel.EventInfo)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002320 File Offset: 0x00000520
		public void WriteEventEntry(global::System.Exception e, global::Motorola.Common.LogUtility.LoggingLevel level = global::Motorola.Common.LogUtility.LoggingLevel.EventInfo)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002327 File Offset: 0x00000527
		public void DebugEx(string logFileSuffix, string format, params object[] message)
		{
			global::Motorola.Common.LogUtility.LogManager.GetLogger(this._loggerName).DebugEx(logFileSuffix, format, message);
		}

		// Token: 0x06000015 RID: 21 RVA: 0x0000233C File Offset: 0x0000053C
		public void ErrorEx(global::System.Exception e, string logFileSuffix, string format, params object[] message)
		{
			global::Motorola.Common.LogUtility.LogManager.GetLogger(this._loggerName).ErrorEx(e, logFileSuffix, format, message);
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002353 File Offset: 0x00000553
		public void ErrorEx(string logFileSuffix, string format, params object[] message)
		{
			global::Motorola.Common.LogUtility.LogManager.GetLogger(this._loggerName).ErrorEx(logFileSuffix, format, message);
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002368 File Offset: 0x00000568
		public void PerformanceEx(string logFileSuffix, string stampName, string format, params object[] message)
		{
			global::Motorola.Common.LogUtility.LogManager.GetLogger(this._loggerName).PerformanceEx(logFileSuffix, stampName, format, message);
		}

		// Token: 0x06000018 RID: 24 RVA: 0x0000237F File Offset: 0x0000057F
		public void UserOperationEx(string logFileSuffix, string format, params object[] message)
		{
			global::Motorola.Common.LogUtility.LogManager.GetLogger(this._loggerName).UserOperationEx(logFileSuffix, format, message);
		}

		// Token: 0x04000001 RID: 1
		private object _caller;

		// Token: 0x04000002 RID: 2
		private string _loggerName = string.Empty;
	}
}
