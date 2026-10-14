using System;

namespace AcpCryptoLib
{
	// Token: 0x0200000D RID: 13
	internal static class AcpCryptoDefs
	{
		// Token: 0x0400000C RID: 12
		internal const int ACP_AES_KEY_LENGTH = 256;

		// Token: 0x0400000D RID: 13
		internal const int ACP_AES_BLOCK_SIZE = 128;

		// Token: 0x0400000E RID: 14
		internal const int ACP_AES_IV_LENGTH = 16;

		// Token: 0x0400000F RID: 15
		internal const int ACP_MIN_SALT_LEN = 4;

		// Token: 0x04000010 RID: 16
		internal const int ACP_MAX_SALT_LEN = 128;

		// Token: 0x04000011 RID: 17
		internal const int ACP_START_ENCRYPT = 9;

		// Token: 0x04000012 RID: 18
		internal const int ACP_HDR_LEN_ADDR = 7;

		// Token: 0x04000013 RID: 19
		internal const int ACP_HDR_KEY1_ADDR = 5;

		// Token: 0x04000014 RID: 20
		internal const int ACP_HDR_KEY2_ADDR = 6;

		// Token: 0x04000015 RID: 21
		internal const int ACP_HDR_KEY3_ADDR = 8;

		// Token: 0x04000016 RID: 22
		internal const int ACP_RANDOM_GEN1 = 25173;

		// Token: 0x04000017 RID: 23
		internal const int ACP_RANDOM_GEN2 = 13849;

		// Token: 0x04000018 RID: 24
		internal const int ACP_RANDOM_MODULUS = 256;

		// Token: 0x04000019 RID: 25
		internal const int ACP_PASSWD_MODULUS = 1024;

		// Token: 0x0400001A RID: 26
		internal const int ACP_RANDOM_TIME_MODULUS = 65536;

		// Token: 0x0400001B RID: 27
		internal const int ACP_HASH_LENGTH = 20;

		// Token: 0x0400001C RID: 28
		internal static readonly int[] randomFactors = new int[]
		{
			47381,
			11,
			5443,
			11927,
			33289,
			3083,
			5443,
			21013,
			6373,
			997,
			36929,
			557,
			1231,
			10211,
			29587,
			8831,
			4133,
			16811,
			12713,
			21013
		};
	}
}
