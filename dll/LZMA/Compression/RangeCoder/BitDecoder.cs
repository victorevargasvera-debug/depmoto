using System;

namespace SevenZip.Compression.RangeCoder
{
	// Token: 0x02000020 RID: 32
	internal struct BitDecoder
	{
		// Token: 0x060000B1 RID: 177 RVA: 0x00006D7F File Offset: 0x00004F7F
		public void UpdateModel(int numMoveBits, uint symbol)
		{
			if (symbol == 0U)
			{
				this.Prob += 2048U - this.Prob >> numMoveBits;
				return;
			}
			this.Prob -= this.Prob >> numMoveBits;
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00006DBB File Offset: 0x00004FBB
		public void Init()
		{
			this.Prob = 1024U;
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00006DC8 File Offset: 0x00004FC8
		public uint Decode(global::SevenZip.Compression.RangeCoder.Decoder rangeDecoder)
		{
			uint num = (rangeDecoder.Range >> 11) * this.Prob;
			if (rangeDecoder.Code < num)
			{
				rangeDecoder.Range = num;
				this.Prob += 2048U - this.Prob >> 5;
				if (rangeDecoder.Range < 16777216U)
				{
					rangeDecoder.Code = (rangeDecoder.Code << 8 | (uint)((byte)rangeDecoder.Stream.ReadByte()));
					rangeDecoder.Range <<= 8;
				}
				return 0U;
			}
			rangeDecoder.Range -= num;
			rangeDecoder.Code -= num;
			this.Prob -= this.Prob >> 5;
			if (rangeDecoder.Range < 16777216U)
			{
				rangeDecoder.Code = (rangeDecoder.Code << 8 | (uint)((byte)rangeDecoder.Stream.ReadByte()));
				rangeDecoder.Range <<= 8;
			}
			return 1U;
		}

		// Token: 0x040000D9 RID: 217
		public const int kNumBitModelTotalBits = 11;

		// Token: 0x040000DA RID: 218
		public const uint kBitModelTotal = 2048U;

		// Token: 0x040000DB RID: 219
		private const int kNumMoveBits = 5;

		// Token: 0x040000DC RID: 220
		private uint Prob;
	}
}
