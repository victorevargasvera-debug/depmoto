using System;

namespace Motorola.Common.LogUtility
{
	// Token: 0x02000009 RID: 9
	public interface ILog
	{
		// Token: 0x06000057 RID: 87
		void Debug(string message);

		// Token: 0x06000058 RID: 88
		void Debug(string format, params object[] message);

		// Token: 0x06000059 RID: 89
		void DebugEx(string logFileSuffix, string format, params object[] message);

		// Token: 0x0600005A RID: 90
		void Error(string message);

		// Token: 0x0600005B RID: 91
		void Error(string format, params object[] message);

		// Token: 0x0600005C RID: 92
		void ErrorEx(string logFileSuffix, string format, params object[] message);

		// Token: 0x0600005D RID: 93
		void Error(global::System.Exception e, string message);

		// Token: 0x0600005E RID: 94
		void Error(global::System.Exception e, string format, params object[] message);

		// Token: 0x0600005F RID: 95
		void ErrorEx(global::System.Exception e, string logFileSuffix, string format, params object[] message);

		// Token: 0x06000060 RID: 96
		void UserOperation(string message);

		// Token: 0x06000061 RID: 97
		void UserOperation(string format, params object[] message);

		// Token: 0x06000062 RID: 98
		void UserOperationEx(string logFileSuffix, string format, params object[] message);

		// Token: 0x06000063 RID: 99
		void SetTimeStampLabel(string labelName);

		// Token: 0x06000064 RID: 100
		void Performance(string stampName, string message);

		// Token: 0x06000065 RID: 101
		void Performance(string stampName, string format, params object[] message);

		// Token: 0x06000066 RID: 102
		void PerformanceEx(string logFileSuffix, string stampName, string format, params object[] message);

		// Token: 0x06000067 RID: 103
		void EventInfo(string message);

		// Token: 0x06000068 RID: 104
		void EventWarning(string message);

		// Token: 0x06000069 RID: 105
		void EventError(string message);

		// Token: 0x0600006A RID: 106
		void WriteEventEntry(string content, global::Motorola.Common.LogUtility.LoggingLevel level = global::Motorola.Common.LogUtility.LoggingLevel.EventInfo);

		// Token: 0x0600006B RID: 107
		void WriteEventEntry(global::System.Exception e, global::Motorola.Common.LogUtility.LoggingLevel level = global::Motorola.Common.LogUtility.LoggingLevel.EventInfo);

		// Token: 0x0600006C RID: 108
		void AddAppender(global::Motorola.Common.LogUtility.IAppender appender);
	}
}
