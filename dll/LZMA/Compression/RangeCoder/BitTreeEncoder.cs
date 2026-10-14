using System;

namespace SevenZip.Compression.RangeCoder
{
	// Token: 0x02000021 RID: 33
	internal struct BitTreeEncoder
	{
		// Token: 0x060000B4 RID: 180 RVA: 0x00006EB1 File Offset: 0x000050B1
		public BitTreeEncoder(int numBitLevels)
		{
			this.NumBitLevels = numBitLevels;
			this.Models = new global::SevenZip.Compression.RangeCoder.BitEncoder[1 << numBitLevels];
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00006ECC File Offset: 0x000050CC
		public void Init()
		{
			uint num = 1U;
			while ((ulong)num < (ulong)(1L << (this.NumBitLevels & 31)))
			{
				this.Models[(int)((global::System.UIntPtr)num)].Init();
				num += 1U;
			}
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00006F04 File Offset: 0x00005104
		public void Encode(global::SevenZip.Compression.RangeCoder.Encoder rangeEncoder, uint symbol)
		{
			uint num = 1U;
			int i = this.NumBitLevels;
			while (i > 0)
			{
				i--;
				uint num2 = symbol >> i & 1U;
				this.Models[(int)((global::System.UIntPtr)num)].Encode(rangeEncoder, num2);
				num = (num << 1 | num2);
			}
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00006F48 File Offset: 0x00005148
		public void ReverseEncode(global::SevenZip.Compression.RangeCoder.Encoder rangeEncoder, uint symbol)
		{
			uint num = 1U;
			uint num2 = 0U;
			while ((ulong)num2 < (ulong)((long)this.NumBitLevels))
			{
				uint num3 = symbol & 1U;
				this.Models[(int)((global::System.UIntPtr)num)].Encode(rangeEncoder, num3);
				num = (num << 1 | num3);
				symbol >>= 1;
				num2 += 1U;
			}
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00006F90 File Offset: 0x00005190
		public uint GetPrice(uint symbol)
		{
			uint num = 0U;
			uint num2 = 1U;
			int i = this.NumBitLevels;
			while (i > 0)
			{
				i--;
				uint num3 = symbol >> i & 1U;
				num += this.Models[(int)((global::System.UIntPtr)num2)].GetPrice(num3);
				num2 = (num2 << 1) + num3;
			}
			return num;
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00006FD8 File Offset: 0x000051D8
		public uint ReverseGetPrice(uint symbol)
		{
			uint num = 0U;
			uint num2 = 1U;
			for (int i = this.NumBitLevels; i > 0; i--)
			{
				uint num3 = symbol & 1U;
				symbol >>= 1;
				num += this.Models[(int)((global::System.UIntPtr)num2)].GetPrice(num3);
				num2 = (num2 << 1 | num3);
			}
			return num;
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00007020 File Offset: 0x00005220
		public static uint ReverseGetPrice(global::SevenZip.Compression.RangeCoder.BitEncoder[] Models, uint startIndex, int NumBitLevels, uint symbol)
		{
			uint num = 0U;
			uint num2 = 1U;
			for (int i = NumBitLevels; i > 0; i--)
			{
				uint num3 = symbol & 1U;
				symbol >>= 1;
				num += Models[(int)((global::System.UIntPtr)(startIndex + num2))].GetPrice(num3);
				num2 = (num2 << 1 | num3);
			}
			return num;
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00007060 File Offset: 0x00005260
		public static void ReverseEncode(global::SevenZip.Compression.RangeCoder.BitEncoder[] Models, uint startIndex, global::SevenZip.Compression.RangeCoder.Encoder rangeEncoder, int NumBitLevels, uint symbol)
		{
			uint num = 1U;
			for (int i = 0; i < NumBitLevels; i++)
			{
				uint num2 = symbol & 1U;
				Models[(int)((global::System.UIntPtr)(startIndex + num))].Encode(rangeEncoder, num2);
				num = (num << 1 | num2);
				symbol >>= 1;
			}
		}

		// Token: 0x040000DD RID: 221
		private global::SevenZip.Compression.RangeCoder.BitEncoder[] Models;

		// Token: 0x040000DE RID: 222
		private int NumBitLevels;
	}
}
