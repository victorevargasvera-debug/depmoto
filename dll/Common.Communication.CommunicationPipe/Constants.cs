using System;

namespace Motorola.Common.Communication.CommunicationPipe
{
	// Token: 0x02000003 RID: 3
	public static class Constants
	{
		// Token: 0x04000004 RID: 4
		internal const int DefaultReceiveTimeout = 2000;

		// Token: 0x04000005 RID: 5
		internal const int DefaultOpenTimeout = 5000;

		// Token: 0x04000006 RID: 6
		public const byte NO_ENCRYPT = 0;

		// Token: 0x04000007 RID: 7
		public const byte ENCRYPT = 1;

		// Token: 0x04000008 RID: 8
		public const byte TLS_1_2_VID = 2;

		// Token: 0x04000009 RID: 9
		public const int MaxRetries = 3;

		// Token: 0x0400000A RID: 10
		internal const int BRDCAST_TIMEOUT = 100;

		// Token: 0x0400000B RID: 11
		internal const int DEFAULT_TIMEOUT = 100;

		// Token: 0x0400000C RID: 12
		internal const int ADDITIONAL_ACK_TIMEOUT = 400;

		// Token: 0x0400000D RID: 13
		internal const int BRDCAST_POLL_TIMER = 50;

		// Token: 0x02000004 RID: 4
		public enum NLOptions
		{
			// Token: 0x0400000F RID: 15
			None,
			// Token: 0x04000010 RID: 16
			XNL_TRANSPORT,
			// Token: 0x04000011 RID: 17
			RNL_TRANSPORT
		}
	}
}
