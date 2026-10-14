using System;

namespace Motorola.Common.Communication.SequenceManager
{
	// Token: 0x02000003 RID: 3
	public static class CommLoggerManager
	{
		// Token: 0x06000019 RID: 25 RVA: 0x00002394 File Offset: 0x00000594
		public static global::Motorola.Common.Communication.SequenceManager.CommLogger GetLogger(object caller, string loggerName)
		{
			return new global::Motorola.Common.Communication.SequenceManager.CommLogger(caller, loggerName);
		}

		// Token: 0x0600001A RID: 26 RVA: 0x0000239D File Offset: 0x0000059D
		public static global::Motorola.Common.Communication.SequenceManager.CommLogger GetLogger(string loggerName)
		{
			return new global::Motorola.Common.Communication.SequenceManager.CommLogger(string.Empty, loggerName);
		}
	}
}
