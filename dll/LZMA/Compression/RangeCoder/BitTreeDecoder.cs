using System;

namespace SevenZip.Compression.RangeCoder
{
	// Token: 0x02000022 RID: 34
	internal struct BitTreeDecoder
	{
		// Token: 0x060000BC RID: 188 RVA: 0x0000709D File Offset: 0x0000529D
		public BitTreeDecoder(int numBitLevels)
		{
			this.NumBitLevels = numBitLevels;
			this.Models = new global::SevenZip.Compression.RangeCoder.BitDecoder[1 << numBitLevels];
		}

		// Token: 0x060000BD RID: 189 RVA: 0x000070B8 File Offset: 0x000052B8
		public void Init()
		{
			uint num = 1U;
			while ((ulong)num < (ulong)(1L << (this.NumBitLevels & 31)))
			{
				this.Models[(int)((global::System.UIntPtr)num)].Init();
				num += 1U;
			}
		}

		// Token: 0x060000BE RID: 190 RVA: 0x000070F0 File Offset: 0x000052F0
		public uint Decode(global::SevenZip.Compression.RangeCoder.Decoder rangeDecoder)
		{
			uint num = 1U;
			for (int i = this.NumBitLevels; i > 0; i--)
			{
				num = (num << 1) + this.Models[(int)((global::System.UIntPtr)num)].Decode(rangeDecoder);
			}
			return num - (1U << this.NumBitLevels);
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00007138 File Offset: 0x00005338
		public uint ReverseDecode(global::SevenZip.Compression.RangeCoder.Decoder rangeDecoder)
		{
			uint num = 1U;
			uint num2 = 0U;
			for (int i = 0; i < this.NumBitLevels; i++)
			{
				uint num3 = this.Models[(int)((global::System.UIntPtr)num)].Decode(rangeDecoder);
				num <<= 1;
				num += num3;
				num2 |= num3 << i;
			}
			return num2;
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00007180 File Offset: 0x00005380
		public static uint ReverseDecode(global::SevenZip.Compression.RangeCoder.BitDecoder[] Models, uint startIndex, global::SevenZip.Compression.RangeCoder.Decoder rangeDecoder, int NumBitLevels)
		{
			uint num = 1U;
			uint num2 = 0U;
			for (int i = 0; i < NumBitLevels; i++)
			{
				uint num3 = Models[(int)((global::System.UIntPtr)(startIndex + num))].Decode(rangeDecoder);
				num <<= 1;
				num += num3;
				num2 |= num3 << i;
			}
			return num2;
		}

		// Token: 0x040000DF RID: 223
		private global::SevenZip.Compression.RangeCoder.BitDecoder[] Models;

		// Token: 0x040000E0 RID: 224
		private int NumBitLevels;
	}
}
