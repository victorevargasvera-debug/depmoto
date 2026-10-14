using System;

namespace ICSharpCode.SharpZipLib.Zip.Compression
{
	// Token: 0x0200003B RID: 59
	public class DeflaterConstants
	{
		// Token: 0x04000136 RID: 310
		public const bool DEBUGGING = false;

		// Token: 0x04000137 RID: 311
		public const int STORED_BLOCK = 0;

		// Token: 0x04000138 RID: 312
		public const int STATIC_TREES = 1;

		// Token: 0x04000139 RID: 313
		public const int DYN_TREES = 2;

		// Token: 0x0400013A RID: 314
		public const int PRESET_DICT = 32;

		// Token: 0x0400013B RID: 315
		public const int DEFAULT_MEM_LEVEL = 8;

		// Token: 0x0400013C RID: 316
		public const int MAX_MATCH = 258;

		// Token: 0x0400013D RID: 317
		public const int MIN_MATCH = 3;

		// Token: 0x0400013E RID: 318
		public const int MAX_WBITS = 15;

		// Token: 0x0400013F RID: 319
		public const int WSIZE = 32768;

		// Token: 0x04000140 RID: 320
		public const int WMASK = 32767;

		// Token: 0x04000141 RID: 321
		public const int HASH_BITS = 15;

		// Token: 0x04000142 RID: 322
		public const int HASH_SIZE = 32768;

		// Token: 0x04000143 RID: 323
		public const int HASH_MASK = 32767;

		// Token: 0x04000144 RID: 324
		public const int HASH_SHIFT = 5;

		// Token: 0x04000145 RID: 325
		public const int MIN_LOOKAHEAD = 262;

		// Token: 0x04000146 RID: 326
		public const int MAX_DIST = 32506;

		// Token: 0x04000147 RID: 327
		public const int PENDING_BUF_SIZE = 65536;

		// Token: 0x04000148 RID: 328
		public const int DEFLATE_STORED = 0;

		// Token: 0x04000149 RID: 329
		public const int DEFLATE_FAST = 1;

		// Token: 0x0400014A RID: 330
		public const int DEFLATE_SLOW = 2;

		// Token: 0x0400014B RID: 331
		public static int MAX_BLOCK_SIZE = global::System.Math.Min(65535, 65531);

		// Token: 0x0400014C RID: 332
		public static int[] GOOD_LENGTH = new int[]
		{
			0,
			4,
			4,
			4,
			4,
			8,
			8,
			8,
			32,
			32
		};

		// Token: 0x0400014D RID: 333
		public static int[] MAX_LAZY = new int[]
		{
			0,
			4,
			5,
			6,
			4,
			16,
			16,
			32,
			128,
			258
		};

		// Token: 0x0400014E RID: 334
		public static int[] NICE_LENGTH = new int[]
		{
			0,
			8,
			16,
			32,
			16,
			32,
			128,
			128,
			258,
			258
		};

		// Token: 0x0400014F RID: 335
		public static int[] MAX_CHAIN = new int[]
		{
			0,
			4,
			8,
			32,
			16,
			32,
			128,
			256,
			1024,
			4096
		};

		// Token: 0x04000150 RID: 336
		public static int[] COMPR_FUNC = new int[]
		{
			0,
			1,
			1,
			1,
			1,
			2,
			2,
			2,
			2,
			2
		};
	}
}
