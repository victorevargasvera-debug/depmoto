using System;

namespace Home.Andir.Cryptography
{
	// Token: 0x02000003 RID: 3
	public static class BigEndianBuffer
	{
		// Token: 0x0600000A RID: 10 RVA: 0x000021F8 File Offset: 0x000011F8
		public static void BlockCopy(uint[] src, int srcOffset, byte[] dst, int dstOffset, int countBytes)
		{
			int num = countBytes >> 2;
			int num2 = countBytes & 3;
			for (int i = 0; i < num; i++)
			{
				for (int j = 0; j < 4; j++)
				{
					dst[dstOffset + (i << 2) + j] = (byte)(src[srcOffset + i] >> 24 - (j << 3));
				}
			}
			for (int k = 0; k < num2; k++)
			{
				dst[(num << 2) + k] = (byte)(src[srcOffset + num] >> 24 - (k << 3));
			}
		}

		// Token: 0x0600000B RID: 11 RVA: 0x0000226C File Offset: 0x0000126C
		public static void BlockCopy(byte[] src, int srcOffset, uint[] dst, int dstOffset, int countBytes)
		{
			int num = countBytes >> 2;
			int num2 = countBytes & 3;
			for (int i = 0; i < num; i++)
			{
				dst[dstOffset + i] = 0U;
				for (int j = 0; j < 4; j++)
				{
					dst[dstOffset + i] |= (uint)((uint)src[srcOffset + (i << 2) + j] << 24 - (j << 3));
				}
			}
			if (num2 > 0)
			{
				dst[dstOffset + num] = 0U;
				for (int k = 0; k < num2; k++)
				{
					dst[dstOffset + num] |= (uint)((uint)src[srcOffset + (num << 2) + k] << 24 - (k << 3));
				}
			}
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002310 File Offset: 0x00001310
		public static void BlockCopy(ulong[] src, int srcOffset, byte[] dst, int dstOffset, int countBytes)
		{
			int num = countBytes >> 3;
			int num2 = countBytes & 7;
			for (int i = 0; i < num; i++)
			{
				for (int j = 0; j < 8; j++)
				{
					dst[dstOffset + (i << 3) + j] = (byte)(src[srcOffset + i] >> 56 - (j << 3));
				}
			}
			for (int k = 0; k < num2; k++)
			{
				dst[(num << 3) + k] = (byte)(src[srcOffset + num] >> 56 - (k << 3));
			}
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002384 File Offset: 0x00001384
		public static void BlockCopy(byte[] src, int srcOffset, ulong[] dst, int dstOffset, int countBytes)
		{
			int num = countBytes >> 3;
			int num2 = countBytes & 7;
			for (int i = 0; i < num; i++)
			{
				dst[dstOffset + i] = 0UL;
				for (int j = 0; j < 8; j++)
				{
					dst[dstOffset + i] |= (ulong)src[srcOffset + (i << 3) + j] << 56 - (j << 3);
				}
			}
			if (num2 > 0)
			{
				dst[dstOffset + num] = 0UL;
				for (int k = 0; k < num2; k++)
				{
					dst[dstOffset + num] |= (ulong)src[srcOffset + (num << 3) + k] << 56 - (k << 3);
				}
			}
		}
	}
}
