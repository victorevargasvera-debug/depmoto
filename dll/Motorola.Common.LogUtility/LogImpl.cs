using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;

namespace Motorola.Common.LogUtility
{
	// Token: 0x0200000F RID: 15
	public class LogImpl : global::Motorola.Common.LogUtility.ILog
	{
		// Token: 0x06000094 RID: 148 RVA: 0x00003EA0 File Offset: 0x000020A0
		public void Debug(string message)
		{
			this.DebugEx(string.Empty, message, null);
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00003EAF File Offset: 0x000020AF
		public void Debug(string format, params object[] message)
		{
			this.DebugEx(string.Empty, format, message);
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00003EC0 File Offset: 0x000020C0
		public void DebugEx(string logFileSuffix, string format, params object[] message)
		{
			if (this.level > global::Motorola.Common.LogUtility.LoggingLevel.Debug)
			{
				return;
			}
			try
			{
				string message2 = format;
				if (message != null && message.Length > 0)
				{
					message2 = string.Format(global::System.Globalization.CultureInfo.InvariantCulture, format, message);
				}
				global::Motorola.Common.LogUtility.LoggingEventArgs e = new global::Motorola.Common.LogUtility.LoggingEventArgs(global::Motorola.Common.LogUtility.LoggingLevel.Debug, global::System.DateTime.Now, message2)
				{
					FileNameSuffix = logFileSuffix
				};
				this.CallAppenders(e);
			}
			catch (global::System.Exception e2)
			{
				global::Motorola.Common.LogUtility.LoggerUtil.LogInnerException(e2);
			}
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00003F28 File Offset: 0x00002128
		public void Error(string message)
		{
			this.ErrorEx(string.Empty, message, null);
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00003F37 File Offset: 0x00002137
		public void Error(string format, params object[] message)
		{
			this.ErrorEx(string.Empty, format, message);
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00003F48 File Offset: 0x00002148
		public void ErrorEx(string logFileSuffix, string format, params object[] message)
		{
			if (this.level > global::Motorola.Common.LogUtility.LoggingLevel.Error)
			{
				return;
			}
			try
			{
				string message2 = format;
				if (message != null && message.Length > 0)
				{
					message2 = string.Format(global::System.Globalization.CultureInfo.InvariantCulture, format, message);
				}
				global::Motorola.Common.LogUtility.LoggingEventArgs e = new global::Motorola.Common.LogUtility.LoggingEventArgs(global::Motorola.Common.LogUtility.LoggingLevel.Error, global::System.DateTime.Now, message2)
				{
					FileNameSuffix = logFileSuffix
				};
				this.CallAppenders(e);
			}
			catch (global::System.Exception e2)
			{
				global::Motorola.Common.LogUtility.LoggerUtil.LogInnerException(e2);
			}
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00003FB4 File Offset: 0x000021B4
		public void Error(global::System.Exception e, string message)
		{
			this.ErrorEx(e, string.Empty, message, null);
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00003FC4 File Offset: 0x000021C4
		public void Error(global::System.Exception e, string format, params object[] message)
		{
			this.ErrorEx(e, string.Empty, format, message);
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00003FD4 File Offset: 0x000021D4
		public void ErrorEx(global::System.Exception e, string logFileSuffix, string format, params object[] message)
		{
			if (this.level > global::Motorola.Common.LogUtility.LoggingLevel.Error)
			{
				return;
			}
			try
			{
				string message2 = format;
				if (message != null && message.Length > 0)
				{
					message2 = string.Format(global::System.Globalization.CultureInfo.InvariantCulture, format, message);
				}
				global::Motorola.Common.LogUtility.LoggingEventArgs e2 = new global::Motorola.Common.LogUtility.LoggingEventArgs(global::Motorola.Common.LogUtility.LoggingLevel.Error, global::System.DateTime.Now, message2, e)
				{
					FileNameSuffix = logFileSuffix
				};
				this.CallAppenders(e2);
			}
			catch (global::System.Exception e3)
			{
				global::Motorola.Common.LogUtility.LoggerUtil.LogInnerException(e3);
			}
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00004044 File Offset: 0x00002244
		public void UserOperation(string message)
		{
			this.UserOperationEx(string.Empty, message, null);
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00004053 File Offset: 0x00002253
		public void UserOperation(string format, params object[] message)
		{
			this.UserOperationEx(string.Empty, format, message);
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00004064 File Offset: 0x00002264
		public void UserOperationEx(string logFileSuffix, string format, params object[] message)
		{
			try
			{
				if (this.level <= global::Motorola.Common.LogUtility.LoggingLevel.Debug)
				{
					string message2 = format;
					if (message != null && message.Length > 0)
					{
						message2 = string.Format(global::System.Globalization.CultureInfo.InvariantCulture, format, message);
					}
					global::Motorola.Common.LogUtility.LoggingEventArgs e = new global::Motorola.Common.LogUtility.LoggingEventArgs(global::Motorola.Common.LogUtility.LoggingLevel.UserOperation, global::System.DateTime.Now, message2)
					{
						FileNameSuffix = logFileSuffix
					};
					this.CallAppenders(e);
				}
			}
			catch (global::System.Exception e2)
			{
				global::Motorola.Common.LogUtility.LoggerUtil.LogInnerException(e2);
			}
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x000040CC File Offset: 0x000022CC
		public void SetTimeStampLabel(string labelName)
		{
			global::Motorola.Common.LogUtility.LoggerUtil.SetTimeStampLabel(labelName);
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x000040D4 File Offset: 0x000022D4
		public void Performance(string stampName, string message)
		{
			this.PerformanceEx(string.Empty, stampName, message, null);
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x000040E4 File Offset: 0x000022E4
		public void Performance(string stampName, string format, params object[] message)
		{
			this.PerformanceEx(string.Empty, stampName, format, message);
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x000040F4 File Offset: 0x000022F4
		public void PerformanceEx(string logFileSuffix, string stampName, string format, params object[] message)
		{
			try
			{
				if (this.level <= global::Motorola.Common.LogUtility.LoggingLevel.Debug)
				{
					string message2 = format;
					if (message != null && message.Length > 0)
					{
						message2 = string.Format(global::System.Globalization.CultureInfo.InvariantCulture, format, message);
					}
					global::Motorola.Common.LogUtility.LoggingEventArgs e = new global::Motorola.Common.LogUtility.LoggingEventArgs(global::Motorola.Common.LogUtility.LoggingLevel.Performance, global::System.DateTime.Now, message2, new global::System.Diagnostics.StackFrame(1, true), stampName)
					{
						FileNameSuffix = logFileSuffix
					};
					this.CallAppenders(e);
				}
			}
			catch (global::System.Exception e2)
			{
				global::Motorola.Common.LogUtility.LoggerUtil.LogInnerException(e2);
			}
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00004168 File Offset: 0x00002368
		public void EventLog(string message, global::Motorola.Common.LogUtility.LoggingLevel level)
		{
			try
			{
				global::Motorola.Common.LogUtility.LoggingEventArgs e = new global::Motorola.Common.LogUtility.LoggingEventArgs(level, global::System.DateTime.Now, message);
				this.CallAppenders(e);
			}
			catch (global::System.Exception e2)
			{
				global::Motorola.Common.LogUtility.LoggerUtil.LogInnerException(e2);
			}
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x000041A4 File Offset: 0x000023A4
		public void EventInfo(string message)
		{
			this.EventLog(message, global::Motorola.Common.LogUtility.LoggingLevel.EventInfo);
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x000041AE File Offset: 0x000023AE
		public void EventWarning(string message)
		{
			this.EventLog(message, global::Motorola.Common.LogUtility.LoggingLevel.EventWarning);
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x000041B8 File Offset: 0x000023B8
		public void EventError(string message)
		{
			this.EventLog(message, global::Motorola.Common.LogUtility.LoggingLevel.EventError);
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x000041C4 File Offset: 0x000023C4
		public void WriteEventEntry(string content, global::Motorola.Common.LogUtility.LoggingLevel level = global::Motorola.Common.LogUtility.LoggingLevel.EventInfo)
		{
			if (level > global::Motorola.Common.LogUtility.LoggingLevel.EventError || level < global::Motorola.Common.LogUtility.LoggingLevel.EventInfo)
			{
				level = global::Motorola.Common.LogUtility.LoggingLevel.EventInfo;
			}
			if (level == global::Motorola.Common.LogUtility.LoggingLevel.EventInfo)
			{
				this.EventInfo("<" + level.ToString() + "> " + content);
				return;
			}
			if (level == global::Motorola.Common.LogUtility.LoggingLevel.EventWarning)
			{
				this.EventWarning("<" + level.ToString() + "> " + content);
				return;
			}
			if (level >= global::Motorola.Common.LogUtility.LoggingLevel.EventError)
			{
				this.EventError("<" + level.ToString() + "> " + content);
			}
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00004250 File Offset: 0x00002450
		public void WriteEventEntry(global::System.Exception e, global::Motorola.Common.LogUtility.LoggingLevel level = global::Motorola.Common.LogUtility.LoggingLevel.EventInfo)
		{
			if (level > global::Motorola.Common.LogUtility.LoggingLevel.EventError || level < global::Motorola.Common.LogUtility.LoggingLevel.EventInfo)
			{
				level = global::Motorola.Common.LogUtility.LoggingLevel.EventInfo;
			}
			string content = (this.level > level) ? e.Message : e.ToString();
			this.WriteEventEntry(content, level);
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x060000AA RID: 170 RVA: 0x00004288 File Offset: 0x00002488
		// (set) Token: 0x060000AB RID: 171 RVA: 0x00004290 File Offset: 0x00002490
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

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060000AC RID: 172 RVA: 0x00004299 File Offset: 0x00002499
		// (set) Token: 0x060000AD RID: 173 RVA: 0x000042A1 File Offset: 0x000024A1
		public global::Motorola.Common.LogUtility.LoggingLevel Level
		{
			get
			{
				return this.level;
			}
			set
			{
				this.level = value;
			}
		}

		// Token: 0x060000AE RID: 174 RVA: 0x000042AA File Offset: 0x000024AA
		public void AddAppender(global::Motorola.Common.LogUtility.IAppender appender)
		{
			this.appenders.Add(appender);
		}

		// Token: 0x060000AF RID: 175 RVA: 0x000042B8 File Offset: 0x000024B8
		private void CallAppenders(global::Motorola.Common.LogUtility.LoggingEventArgs e)
		{
			foreach (global::Motorola.Common.LogUtility.IAppender appender in this.appenders)
			{
				appender.DoAppend(this, e);
			}
		}

		// Token: 0x04000046 RID: 70
		private global::System.Collections.Generic.List<global::Motorola.Common.LogUtility.IAppender> appenders = new global::System.Collections.Generic.List<global::Motorola.Common.LogUtility.IAppender>();

		// Token: 0x04000047 RID: 71
		private string name;

		// Token: 0x04000048 RID: 72
		private global::Motorola.Common.LogUtility.LoggingLevel level;
	}
}
