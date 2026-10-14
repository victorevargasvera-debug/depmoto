using System;
using System.Diagnostics;

namespace Motorola.Common.LogUtility
{
	// Token: 0x0200000E RID: 14
	public class LoggingEventArgs : global::System.EventArgs
	{
		// Token: 0x06000083 RID: 131 RVA: 0x00003DBA File Offset: 0x00001FBA
		public LoggingEventArgs(global::Motorola.Common.LogUtility.LoggingLevel level, global::System.DateTime timeStamp, string message)
		{
			this.Level = level;
			this.TimeStamp = timeStamp;
			this.Message = message;
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00003DD7 File Offset: 0x00001FD7
		public LoggingEventArgs(global::Motorola.Common.LogUtility.LoggingLevel level, global::System.DateTime timeStamp, string message, global::System.Exception e)
		{
			this.Level = level;
			this.TimeStamp = timeStamp;
			this.Message = message;
			this.Exception = e;
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00003DFC File Offset: 0x00001FFC
		public LoggingEventArgs(global::Motorola.Common.LogUtility.LoggingLevel level, global::System.DateTime timeStamp, string message, global::System.Diagnostics.StackFrame stackFrame, string stampName)
		{
			this.Level = level;
			this.TimeStamp = timeStamp;
			this.Message = message;
			this.StackFrame = stackFrame;
			this.StampName = stampName;
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000086 RID: 134 RVA: 0x00003E29 File Offset: 0x00002029
		// (set) Token: 0x06000087 RID: 135 RVA: 0x00003E31 File Offset: 0x00002031
		public global::Motorola.Common.LogUtility.LoggingLevel Level { get; set; }

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000088 RID: 136 RVA: 0x00003E3A File Offset: 0x0000203A
		// (set) Token: 0x06000089 RID: 137 RVA: 0x00003E42 File Offset: 0x00002042
		public global::System.DateTime TimeStamp { get; set; }

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600008A RID: 138 RVA: 0x00003E4B File Offset: 0x0000204B
		// (set) Token: 0x0600008B RID: 139 RVA: 0x00003E53 File Offset: 0x00002053
		public string Message { get; set; }

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600008C RID: 140 RVA: 0x00003E5C File Offset: 0x0000205C
		// (set) Token: 0x0600008D RID: 141 RVA: 0x00003E64 File Offset: 0x00002064
		public global::System.Exception Exception { get; set; }

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600008E RID: 142 RVA: 0x00003E6D File Offset: 0x0000206D
		// (set) Token: 0x0600008F RID: 143 RVA: 0x00003E75 File Offset: 0x00002075
		public global::System.Diagnostics.StackFrame StackFrame { get; set; }

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000090 RID: 144 RVA: 0x00003E7E File Offset: 0x0000207E
		// (set) Token: 0x06000091 RID: 145 RVA: 0x00003E86 File Offset: 0x00002086
		public string StampName { get; set; }

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000092 RID: 146 RVA: 0x00003E8F File Offset: 0x0000208F
		// (set) Token: 0x06000093 RID: 147 RVA: 0x00003E97 File Offset: 0x00002097
		public string FileNameSuffix { get; set; }
	}
}
