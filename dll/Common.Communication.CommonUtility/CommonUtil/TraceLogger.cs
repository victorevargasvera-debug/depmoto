using System;
using System.Diagnostics;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x02000016 RID: 22
	public abstract class TraceLogger
	{
		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000058 RID: 88 RVA: 0x00003640 File Offset: 0x00001840
		public static global::Motorola.Common.Communication.CommonUtil.TraceLogger Instance
		{
			get
			{
				return global::Motorola.Common.Communication.CommonUtil.TraceLogger.m_Instance;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000059 RID: 89
		public abstract global::System.Diagnostics.TraceLevel Level { get; }

		// Token: 0x0600005B RID: 91
		public abstract void WriteError(string format, params object[] args);

		// Token: 0x0600005C RID: 92
		public abstract void WriteWarning(string format, params object[] args);

		// Token: 0x0600005D RID: 93
		[global::System.Diagnostics.Conditional("TRACE")]
		public abstract void WriteInfo(string format, params object[] args);

		// Token: 0x0600005E RID: 94
		[global::System.Diagnostics.Conditional("TRACE")]
		public abstract void WriteVerbose(global::Motorola.Common.Communication.CommonUtil.TraceLogger.TraceLoggerStringBuilder errorBuilder);

		// Token: 0x0600005F RID: 95
		[global::System.Diagnostics.Conditional("TRACE")]
		public abstract void WriteVerbose(string format, params object[] args);

		// Token: 0x06000060 RID: 96
		[global::System.Diagnostics.Conditional("DEBUG")]
		public abstract void WriteSensitive(string format, params object[] args);

		// Token: 0x06000061 RID: 97 RVA: 0x00003668 File Offset: 0x00001868
		private static global::Motorola.Common.Communication.CommonUtil.TraceLoggerPC newTraceLoggerPC()
		{
			return new global::Motorola.Common.Communication.CommonUtil.TraceLoggerPC();
		}

		// Token: 0x04000048 RID: 72
		private static global::Motorola.Common.Communication.CommonUtil.TraceLogger m_Instance = global::Motorola.Common.Communication.CommonUtil.TraceLogger.newTraceLoggerPC();

		// Token: 0x02000017 RID: 23
		// (Invoke) Token: 0x06000064 RID: 100
		public delegate string TraceLoggerStringBuilder();
	}
}
