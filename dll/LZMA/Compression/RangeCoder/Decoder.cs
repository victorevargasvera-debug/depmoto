using System;
using System.IO;

namespace SevenZip.Compression.RangeCoder
{
	// Token: 0x0200001E RID: 30
	internal class Decoder
	{
		// Token: 0x0600009F RID: 159 RVA: 0x000069E8 File Offset: 0x00004BE8
		public void Init(global::System.IO.Stream stream)
		{
			this.Stream = stream;
			this.Code = 0U;
			this.Range = uint.MaxValue;
			for (int i = 0; i < 5; i++)
			{
				this.Code = (this.Code << 8 | (uint)((byte)this.Stream.ReadByte()));
			}
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00006A31 File Offset: 0x00004C31
		public void ReleaseStream()
		{
			this.Stream = null;
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00006A3A File Offset: 0x00004C3A
		public void CloseStream()
		{
			this.Stream.Close();
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00006A47 File Offset: 0x00004C47
		public void Normalize()
		{
			while (this.Range < 16777216U)
			{
				this.Code = (this.Code << 8 | (uint)((byte)this.Stream.ReadByte()));
				this.Range <<= 8;
			}
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00006A81 File Offset: 0x00004C81
		public void Normalize2()
		{
			if (this.Range < 16777216U)
			{
				this.Code = (this.Code << 8 | (uint)((byte)this.Stream.ReadByte()));
				this.Range <<= 8;
			}
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00006ABC File Offset: 0x00004CBC
		public uint GetThreshold(uint total)
		{
			return this.Code / (this.Range /= total);
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00006AE1 File Offset: 0x00004CE1
		public void Decode(uint start, uint size, uint total)
		{
			this.Code -= start * this.Range;
			this.Range *= size;
			this.Normalize();
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00006B0C File Offset: 0x00004D0C
		public uint DecodeDirectBits(int numTotalBits)
		{
			uint num = this.Range;
			uint num2 = this.Code;
			uint num3 = 0U;
			for (int i = numTotalBits; i > 0; i--)
			{
				num >>= 1;
				uint num4 = num2 - num >> 31;
				num2 -= (num & num4 - 1U);
				num3 = (num3 << 1 | 1U - num4);
				if (num < 16777216U)
				{
					num2 = (num2 << 8 | (uint)((byte)this.Stream.ReadByte()));
					num <<= 8;
				}
			}
			this.Range = num;
			this.Code = num2;
			return num3;
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00006B80 File Offset: 0x00004D80
		public uint DecodeBit(uint size0, int numTotalBits)
		{
			uint num = (this.Range >> numTotalBits) * size0;
			uint result;
			if (this.Code < num)
			{
				result = 0U;
				this.Range = num;
			}
			else
			{
				result = 1U;
				this.Code -= num;
				this.Range -= num;
			}
			this.Normalize();
			return result;
		}

		// Token: 0x040000CD RID: 205
		public const uint kTopValue = 16777216U;

		// Token: 0x040000CE RID: 206
		public uint Range;

		// Token: 0x040000CF RID: 207
		public uint Code;

		// Token: 0x040000D0 RID: 208
		public global::System.IO.Stream Stream;
	}
}
