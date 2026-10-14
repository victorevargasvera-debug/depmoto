using System;
using Motorola.Common.Communication.CommonUtil;

namespace Motorola.Common.Communication
{
	// Token: 0x02000009 RID: 9
	internal static class XnlTrace
	{
		// Token: 0x06000036 RID: 54 RVA: 0x00002C93 File Offset: 0x00000E93
		public static void WriteLine(string msg)
		{
			if (global::Motorola.Common.Communication.XnlTrace.enableXnlTrace)
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("XNL -- " + msg, new object[0]);
			}
		}

		// Token: 0x04000014 RID: 20
		private static bool enableXnlTrace;
	}
}
