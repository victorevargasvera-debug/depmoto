using System;

namespace SevenZip.Compression.RangeCoder
{
	// Token: 0x0200001F RID: 31
	internal struct BitEncoder
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x060000A9 RID: 169 RVA: 0x00006BDC File Offset: 0x00004DDC
		private static uint[] ProbPrices
		{
			get
			{
				if (!global::SevenZip.Compression.RangeCoder.BitEncoder.isInitialize)
				{
					for (int i = 8; i >= 0; i--)
					{
						uint num = 1U << 9 - i - 1;
						uint num2 = 1U << 9 - i;
						for (uint num3 = num; num3 < num2; num3 += 1U)
						{
							global::SevenZip.Compression.RangeCoder.BitEncoder._ProbPrices[(int)((global::System.UIntPtr)num3)] = (uint)((i << 6) + (int)(num2 - num3 << 6 >> 9 - i - 1));
						}
					}
					global::SevenZip.Compression.RangeCoder.BitEncoder.isInitialize = true;
				}
				return global::SevenZip.Compression.RangeCoder.BitEncoder._ProbPrices;
			}
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00006C44 File Offset: 0x00004E44
		public void Init()
		{
			this.Prob = 1024U;
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00006C51 File Offset: 0x00004E51
		public void UpdateModel(uint symbol)
		{
			if (symbol == 0U)
			{
				this.Prob += 2048U - this.Prob >> 5;
				return;
			}
			this.Prob -= this.Prob >> 5;
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00006C88 File Offset: 0x00004E88
		public void Encode(global::SevenZip.Compression.RangeCoder.Encoder encoder, uint symbol)
		{
			uint num = (encoder.Range >> 11) * this.Prob;
			if (symbol == 0U)
			{
				encoder.Range = num;
				this.Prob += 2048U - this.Prob >> 5;
			}
			else
			{
				encoder.Low += (ulong)num;
				encoder.Range -= num;
				this.Prob -= this.Prob >> 5;
			}
			if (encoder.Range < 16777216U)
			{
				encoder.Range <<= 8;
				encoder.ShiftLow();
			}
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00006D20 File Offset: 0x00004F20
		public uint GetPrice(uint symbol)
		{
			return global::SevenZip.Compression.RangeCoder.BitEncoder.ProbPrices[(int)(checked((global::System.IntPtr)((unchecked((ulong)(this.Prob - symbol) ^ (ulong)((long)(-(long)symbol))) & 2047UL) >> 2)))];
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00006D3F File Offset: 0x00004F3F
		public uint GetPrice0()
		{
			return global::SevenZip.Compression.RangeCoder.BitEncoder.ProbPrices[(int)((global::System.UIntPtr)(this.Prob >> 2))];
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00006D50 File Offset: 0x00004F50
		public uint GetPrice1()
		{
			return global::SevenZip.Compression.RangeCoder.BitEncoder.ProbPrices[(int)((global::System.UIntPtr)(2048U - this.Prob >> 2))];
		}

		// Token: 0x040000D1 RID: 209
		public const int kNumBitModelTotalBits = 11;

		// Token: 0x040000D2 RID: 210
		public const uint kBitModelTotal = 2048U;

		// Token: 0x040000D3 RID: 211
		private const int kNumMoveBits = 5;

		// Token: 0x040000D4 RID: 212
		private const int kNumMoveReducingBits = 2;

		// Token: 0x040000D5 RID: 213
		public const int kNumBitPriceShiftBits = 6;

		// Token: 0x040000D6 RID: 214
		private static bool isInitialize = false;

		// Token: 0x040000D7 RID: 215
		private uint Prob;

		// Token: 0x040000D8 RID: 216
		private static uint[] _ProbPrices = new uint[512];
	}
}
