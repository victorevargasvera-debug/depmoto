using System;

namespace fxpcommunication
{
	// Token: 0x02000007 RID: 7
	internal sealed class FxpConstants
	{
		// Token: 0x04000012 RID: 18
		public const uint FXPTimeout = 1000U;

		// Token: 0x04000013 RID: 19
		public const int MaxCommRetryTimes = 3;

		// Token: 0x04000014 RID: 20
		public const int MaxDupMsgRetryTimes = 5;

		// Token: 0x04000015 RID: 21
		public const int MaxReceiveSize = 1024;

		// Token: 0x04000016 RID: 22
		private const int Protocol_UDP = 1;

		// Token: 0x04000017 RID: 23
		public const int FXPLengthSize = 2;

		// Token: 0x04000018 RID: 24
		public const int RandomizationSize = 2;

		// Token: 0x04000019 RID: 25
		public const int ProtocolVersionSize = 2;

		// Token: 0x0400001A RID: 26
		public const int SequenceNumberSize = 2;

		// Token: 0x0400001B RID: 27
		public const int OperationSize = 2;

		// Token: 0x0400001C RID: 28
		public const int EncryptLengthSize = 2;

		// Token: 0x0400001D RID: 29
		public const int MinFxpMessageSize = 10;

		// Token: 0x0400001E RID: 30
		public const int HashXmlStringByteWidth = 2;

		// Token: 0x0400001F RID: 31
		public const int HashInputSize = 128;

		// Token: 0x04000020 RID: 32
		public const byte HashInputPaddingByte = 165;

		// Token: 0x04000021 RID: 33
		public const int CryptoBlockSize = 128;

		// Token: 0x04000022 RID: 34
		public const int CryptoKeySize = 256;

		// Token: 0x04000023 RID: 35
		public const int ByteBitsWidth = 8;

		// Token: 0x04000024 RID: 36
		public const int AckStatusSize = 1;

		// Token: 0x04000025 RID: 37
		public const int FeatureCodeKeyPositionSize = 1;

		// Token: 0x04000026 RID: 38
		public const int PCIndentifierSize = 128;

		// Token: 0x04000027 RID: 39
		public const byte MinFeaureCodeKeyPosition = 0;

		// Token: 0x04000028 RID: 40
		public const byte MaxFeaureCodeKeyPosition = 6;

		// Token: 0x04000029 RID: 41
		public const int MinFeaureCodeTransferMessages = 1;

		// Token: 0x0400002A RID: 42
		public const int MaxFeaureCodeTransferMessages = 9;

		// Token: 0x0400002B RID: 43
		public const int MinNumberDiscardMessages = 0;

		// Token: 0x0400002C RID: 44
		public const int MaxNumberDiscardMessages = 2;

		// Token: 0x0400002D RID: 45
		public const int RandomizationInterval_0 = 0;

		// Token: 0x0400002E RID: 46
		public const int RandomizationInterval_1 = 1;

		// Token: 0x0400002F RID: 47
		public const int RandomizationInterval_2 = 2;

		// Token: 0x04000030 RID: 48
		public const int RandomizationInterval_3 = 3;

		// Token: 0x04000031 RID: 49
		public const int RandomizationInterval_128 = 128;

		// Token: 0x04000032 RID: 50
		private const string DevFWVersionInitial = "D";

		// Token: 0x04000033 RID: 51
		public const string FactoryFWVersionInitial = "R";

		// Token: 0x04000034 RID: 52
		public const uint InvalidRecvSeqNum = 4294967295U;

		// Token: 0x04000035 RID: 53
		public const byte FxpDataType = 4;

		// Token: 0x04000036 RID: 54
		public const string UPDATES = "UPDATES";
	}
}
