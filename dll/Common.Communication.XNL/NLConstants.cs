using System;

namespace Motorola.Common.Communication
{
	// Token: 0x0200000A RID: 10
	internal static class NLConstants
	{
		// Token: 0x04000015 RID: 21
		private const int MasterWaitTimeout = 200;

		// Token: 0x04000016 RID: 22
		public const int DeviceInitStatusTimeout = 1000;

		// Token: 0x04000017 RID: 23
		public const int ConnectWaitTimeout = 500;

		// Token: 0x04000018 RID: 24
		public const int XnlRetries = 3;

		// Token: 0x04000019 RID: 25
		public const int InfiniteTimeOut = -1;

		// Token: 0x0400001A RID: 26
		public const int XnlSucess = 1;

		// Token: 0x0400001B RID: 27
		private const int XnlFailure = 0;

		// Token: 0x0400001C RID: 28
		public const int XnlHeaderSize = 12;

		// Token: 0x0400001D RID: 29
		public const int XnlConnectReplyPayloadSize = 14;

		// Token: 0x0400001E RID: 30
		public const int XnlDeviceInitStatusBroadcastPayloadSize = 7;

		// Token: 0x0400001F RID: 31
		public const int XnlOpenPortTimeout = 2000;

		// Token: 0x04000020 RID: 32
		public const int XnlDisconnectTimeout = 5000;

		// Token: 0x04000021 RID: 33
		public const int RnlHeaderSize = 5;

		// Token: 0x04000022 RID: 34
		public const ushort RnlTransactionID = 65535;

		// Token: 0x04000023 RID: 35
		public const ushort RnlBcstTransactionID = 65534;

		// Token: 0x04000024 RID: 36
		public static byte ConnectionRequestNeedAckXnlFlags = 8;

		// Token: 0x04000025 RID: 37
		public static int DefaultTimeout = 100;

		// Token: 0x04000026 RID: 38
		public static int AdditionalAckTimeout = 400;

		// Token: 0x04000027 RID: 39
		public static int BroadcastPollPeriod = 50;

		// Token: 0x04000028 RID: 40
		public static int BroadcastPollWaitTimeout = 5;
	}
}
