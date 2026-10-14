using System;
using System.IO;

namespace SevenZip.Compression.RangeCoder
{
	// Token: 0x0200001D RID: 29
	internal class Encoder
	{
		// Token: 0x06000093 RID: 147 RVA: 0x0000677E File Offset: 0x0000497E
		public void SetStream(global::System.IO.Stream stream)
		{
			this.Stream = stream;
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00006787 File Offset: 0x00004987
		public void ReleaseStream()
		{
			this.Stream = null;
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00006790 File Offset: 0x00004990
		public void Init()
		{
			this.StartPosition = this.Stream.Position;
			this.Low = 0UL;
			this.Range = uint.MaxValue;
			this._cacheSize = 1U;
			this._cache = 0;
		}

		// Token: 0x06000096 RID: 150 RVA: 0x000067C0 File Offset: 0x000049C0
		public void FlushData()
		{
			for (int i = 0; i < 5; i++)
			{
				this.ShiftLow();
			}
		}

		// Token: 0x06000097 RID: 151 RVA: 0x000067DF File Offset: 0x000049DF
		public void FlushStream()
		{
			this.Stream.Flush();
		}

		// Token: 0x06000098 RID: 152 RVA: 0x000067EC File Offset: 0x000049EC
		public void CloseStream()
		{
			this.Stream.Close();
		}

		// Token: 0x06000099 RID: 153 RVA: 0x000067FC File Offset: 0x000049FC
		public void Encode(uint start, uint size, uint total)
		{
			this.Low += (ulong)(start * (this.Range /= total));
			this.Range *= size;
			while (this.Range < 16777216U)
			{
				this.Range <<= 8;
				this.ShiftLow();
			}
		}

		// Token: 0x0600009A RID: 154 RVA: 0x0000685C File Offset: 0x00004A5C
		public void ShiftLow()
		{
			if ((uint)this.Low < 4278190080U || (uint)(this.Low >> 32) == 1U)
			{
				byte b = this._cache;
				do
				{
					this.Stream.WriteByte((byte)((ulong)b + (this.Low >> 32)));
					b = byte.MaxValue;
				}
				while ((this._cacheSize -= 1U) != 0U);
				this._cache = (byte)((uint)this.Low >> 24);
			}
			this._cacheSize += 1U;
			this.Low = (ulong)((ulong)((uint)this.Low) << 8);
		}

		// Token: 0x0600009B RID: 155 RVA: 0x000068EC File Offset: 0x00004AEC
		public void EncodeDirectBits(uint v, int numTotalBits)
		{
			for (int i = numTotalBits - 1; i >= 0; i--)
			{
				this.Range >>= 1;
				if ((v >> i & 1U) == 1U)
				{
					this.Low += (ulong)this.Range;
				}
				if (this.Range < 16777216U)
				{
					this.Range <<= 8;
					this.ShiftLow();
				}
			}
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00006958 File Offset: 0x00004B58
		public void EncodeBit(uint size0, int numTotalBits, uint symbol)
		{
			uint num = (this.Range >> numTotalBits) * size0;
			if (symbol == 0U)
			{
				this.Range = num;
			}
			else
			{
				this.Low += (ulong)num;
				this.Range -= num;
			}
			while (this.Range < 16777216U)
			{
				this.Range <<= 8;
				this.ShiftLow();
			}
		}

		// Token: 0x0600009D RID: 157 RVA: 0x000069BF File Offset: 0x00004BBF
		public long GetProcessedSizeAdd()
		{
			return (long)((ulong)this._cacheSize + (ulong)this.Stream.Position - (ulong)this.StartPosition + 4UL);
		}

		// Token: 0x040000C6 RID: 198
		public const uint kTopValue = 16777216U;

		// Token: 0x040000C7 RID: 199
		private global::System.IO.Stream Stream;

		// Token: 0x040000C8 RID: 200
		public ulong Low;

		// Token: 0x040000C9 RID: 201
		public uint Range;

		// Token: 0x040000CA RID: 202
		private uint _cacheSize;

		// Token: 0x040000CB RID: 203
		private byte _cache;

		// Token: 0x040000CC RID: 204
		private long StartPosition;
	}
}
