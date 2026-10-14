using System;
using System.IO;

namespace SevenZip.Compression.LZ
{
	// Token: 0x02000006 RID: 6
	public class BinTree : global::SevenZip.Compression.LZ.InWindow, global::SevenZip.Compression.LZ.IMatchFinder, global::SevenZip.Compression.LZ.IInWindowStream
	{
		// Token: 0x0600001F RID: 31 RVA: 0x000024E8 File Offset: 0x000006E8
		public void SetType(int numHashBytes)
		{
			this.HASH_ARRAY = (numHashBytes > 2);
			if (this.HASH_ARRAY)
			{
				this.kNumHashDirectBytes = 0U;
				this.kMinMatchCheck = 4U;
				this.kFixHashSize = 66560U;
				return;
			}
			this.kNumHashDirectBytes = 2U;
			this.kMinMatchCheck = 3U;
			this.kFixHashSize = 0U;
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002536 File Offset: 0x00000736
		public new void SetStream(global::System.IO.Stream stream)
		{
			base.SetStream(stream);
		}

		// Token: 0x06000021 RID: 33 RVA: 0x0000253F File Offset: 0x0000073F
		public new void ReleaseStream()
		{
			base.ReleaseStream();
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002548 File Offset: 0x00000748
		public new void Init()
		{
			base.Init();
			for (uint num = 0U; num < this._hashSizeSum; num += 1U)
			{
				this._hash[(int)((global::System.UIntPtr)num)] = 0U;
			}
			this._cyclicBufferPos = 0U;
			base.ReduceOffsets(-1);
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002584 File Offset: 0x00000784
		public new void MovePos()
		{
			if ((this._cyclicBufferPos += 1U) >= this._cyclicBufferSize)
			{
				this._cyclicBufferPos = 0U;
			}
			base.MovePos();
			if (this._pos == 2147483647U)
			{
				this.Normalize();
			}
		}

		// Token: 0x06000024 RID: 36 RVA: 0x000025CA File Offset: 0x000007CA
		public new byte GetIndexByte(int index)
		{
			return base.GetIndexByte(index);
		}

		// Token: 0x06000025 RID: 37 RVA: 0x000025D3 File Offset: 0x000007D3
		public new uint GetMatchLen(int index, uint distance, uint limit)
		{
			return base.GetMatchLen(index, distance, limit);
		}

		// Token: 0x06000026 RID: 38 RVA: 0x000025DE File Offset: 0x000007DE
		public new uint GetNumAvailableBytes()
		{
			return base.GetNumAvailableBytes();
		}

		// Token: 0x06000027 RID: 39 RVA: 0x000025E8 File Offset: 0x000007E8
		public void Create(uint historySize, uint keepAddBufferBefore, uint matchMaxLen, uint keepAddBufferAfter)
		{
			if (historySize > 2147483391U)
			{
				throw new global::System.Exception();
			}
			this._cutValue = 16U + (matchMaxLen >> 1);
			uint keepSizeReserv = (historySize + keepAddBufferBefore + matchMaxLen + keepAddBufferAfter) / 2U + 256U;
			base.Create(historySize + keepAddBufferBefore, matchMaxLen + keepAddBufferAfter, keepSizeReserv);
			this._matchMaxLen = matchMaxLen;
			uint num = historySize + 1U;
			if (this._cyclicBufferSize != num)
			{
				this._son = new uint[(this._cyclicBufferSize = num) * 2U];
			}
			uint num2 = 65536U;
			if (this.HASH_ARRAY)
			{
				num2 = historySize - 1U;
				num2 |= num2 >> 1;
				num2 |= num2 >> 2;
				num2 |= num2 >> 4;
				num2 |= num2 >> 8;
				num2 >>= 1;
				num2 |= 65535U;
				if (num2 > 16777216U)
				{
					num2 >>= 1;
				}
				this._hashMask = num2;
				num2 += 1U;
				num2 += this.kFixHashSize;
			}
			if (num2 != this._hashSizeSum)
			{
				this._hash = new uint[this._hashSizeSum = num2];
			}
		}

		// Token: 0x06000028 RID: 40 RVA: 0x000026D4 File Offset: 0x000008D4
		public uint GetMatches(uint[] distances)
		{
			uint num;
			if (this._pos + this._matchMaxLen <= this._streamPos)
			{
				num = this._matchMaxLen;
			}
			else
			{
				num = this._streamPos - this._pos;
				if (num < this.kMinMatchCheck)
				{
					this.MovePos();
					return 0U;
				}
			}
			uint num2 = 0U;
			uint num3 = (this._pos > this._cyclicBufferSize) ? (this._pos - this._cyclicBufferSize) : 0U;
			uint num4 = this._bufferOffset + this._pos;
			uint num5 = 1U;
			uint num6 = 0U;
			uint num7 = 0U;
			uint num9;
			if (this.HASH_ARRAY)
			{
				uint num8 = global::SevenZip.CRC.Table[(int)this._bufferBase[(int)((global::System.UIntPtr)num4)]] ^ (uint)this._bufferBase[(int)((global::System.UIntPtr)(num4 + 1U))];
				num6 = (num8 & 1023U);
				num8 ^= (uint)((uint)this._bufferBase[(int)((global::System.UIntPtr)(num4 + 2U))] << 8);
				num7 = (num8 & 65535U);
				num9 = ((num8 ^ global::SevenZip.CRC.Table[(int)this._bufferBase[(int)((global::System.UIntPtr)(num4 + 3U))]] << 5) & this._hashMask);
			}
			else
			{
				num9 = (uint)((int)this._bufferBase[(int)((global::System.UIntPtr)num4)] ^ (int)this._bufferBase[(int)((global::System.UIntPtr)(num4 + 1U))] << 8);
			}
			uint num10 = this._hash[(int)((global::System.UIntPtr)(this.kFixHashSize + num9))];
			if (this.HASH_ARRAY)
			{
				uint num11 = this._hash[(int)((global::System.UIntPtr)num6)];
				uint num12 = this._hash[(int)((global::System.UIntPtr)(1024U + num7))];
				this._hash[(int)((global::System.UIntPtr)num6)] = this._pos;
				this._hash[(int)((global::System.UIntPtr)(1024U + num7))] = this._pos;
				if (num11 > num3 && this._bufferBase[(int)((global::System.UIntPtr)(this._bufferOffset + num11))] == this._bufferBase[(int)((global::System.UIntPtr)num4)])
				{
					num5 = (distances[(int)((global::System.UIntPtr)(num2++))] = 2U);
					distances[(int)((global::System.UIntPtr)(num2++))] = this._pos - num11 - 1U;
				}
				if (num12 > num3 && this._bufferBase[(int)((global::System.UIntPtr)(this._bufferOffset + num12))] == this._bufferBase[(int)((global::System.UIntPtr)num4)])
				{
					if (num12 == num11)
					{
						num2 -= 2U;
					}
					num5 = (distances[(int)((global::System.UIntPtr)(num2++))] = 3U);
					distances[(int)((global::System.UIntPtr)(num2++))] = this._pos - num12 - 1U;
					num11 = num12;
				}
				if (num2 != 0U && num11 == num10)
				{
					num2 -= 2U;
					num5 = 1U;
				}
			}
			this._hash[(int)((global::System.UIntPtr)(this.kFixHashSize + num9))] = this._pos;
			uint num13 = (this._cyclicBufferPos << 1) + 1U;
			uint num14 = this._cyclicBufferPos << 1;
			uint val2;
			uint val = val2 = this.kNumHashDirectBytes;
			if (this.kNumHashDirectBytes != 0U && num10 > num3 && this._bufferBase[(int)((global::System.UIntPtr)(this._bufferOffset + num10 + this.kNumHashDirectBytes))] != this._bufferBase[(int)((global::System.UIntPtr)(num4 + this.kNumHashDirectBytes))])
			{
				num5 = (distances[(int)((global::System.UIntPtr)(num2++))] = this.kNumHashDirectBytes);
				distances[(int)((global::System.UIntPtr)(num2++))] = this._pos - num10 - 1U;
			}
			uint cutValue = this._cutValue;
			while (num10 > num3 && cutValue-- != 0U)
			{
				uint num15 = this._pos - num10;
				uint num16 = ((num15 <= this._cyclicBufferPos) ? (this._cyclicBufferPos - num15) : (this._cyclicBufferPos - num15 + this._cyclicBufferSize)) << 1;
				uint num17 = this._bufferOffset + num10;
				uint num18 = global::System.Math.Min(val2, val);
				if (this._bufferBase[(int)((global::System.UIntPtr)(num17 + num18))] == this._bufferBase[(int)((global::System.UIntPtr)(num4 + num18))])
				{
					while ((num18 += 1U) != num && this._bufferBase[(int)((global::System.UIntPtr)(num17 + num18))] == this._bufferBase[(int)((global::System.UIntPtr)(num4 + num18))])
					{
					}
					if (num5 < num18)
					{
						num5 = (distances[(int)((global::System.UIntPtr)(num2++))] = num18);
						distances[(int)((global::System.UIntPtr)(num2++))] = num15 - 1U;
						if (num18 == num)
						{
							this._son[(int)((global::System.UIntPtr)num14)] = this._son[(int)((global::System.UIntPtr)num16)];
							this._son[(int)((global::System.UIntPtr)num13)] = this._son[(int)((global::System.UIntPtr)(num16 + 1U))];
							IL_405:
							this.MovePos();
							return num2;
						}
					}
				}
				if (this._bufferBase[(int)((global::System.UIntPtr)(num17 + num18))] < this._bufferBase[(int)((global::System.UIntPtr)(num4 + num18))])
				{
					this._son[(int)((global::System.UIntPtr)num14)] = num10;
					num14 = num16 + 1U;
					num10 = this._son[(int)((global::System.UIntPtr)num14)];
					val = num18;
				}
				else
				{
					this._son[(int)((global::System.UIntPtr)num13)] = num10;
					num13 = num16;
					num10 = this._son[(int)((global::System.UIntPtr)num13)];
					val2 = num18;
				}
			}
			this._son[(int)((global::System.UIntPtr)num13)] = (this._son[(int)((global::System.UIntPtr)num14)] = 0U);
			goto IL_405;
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002AF0 File Offset: 0x00000CF0
		public void Skip(uint num)
		{
			for (;;)
			{
				uint num2;
				if (this._pos + this._matchMaxLen <= this._streamPos)
				{
					num2 = this._matchMaxLen;
					goto IL_40;
				}
				num2 = this._streamPos - this._pos;
				if (num2 >= this.kMinMatchCheck)
				{
					goto IL_40;
				}
				this.MovePos();
				IL_2C1:
				if ((num -= 1U) == 0U)
				{
					break;
				}
				continue;
				IL_40:
				uint num3 = (this._pos > this._cyclicBufferSize) ? (this._pos - this._cyclicBufferSize) : 0U;
				uint num4 = this._bufferOffset + this._pos;
				uint num8;
				if (this.HASH_ARRAY)
				{
					uint num5 = global::SevenZip.CRC.Table[(int)this._bufferBase[(int)((global::System.UIntPtr)num4)]] ^ (uint)this._bufferBase[(int)((global::System.UIntPtr)(num4 + 1U))];
					uint num6 = num5 & 1023U;
					this._hash[(int)((global::System.UIntPtr)num6)] = this._pos;
					num5 ^= (uint)((uint)this._bufferBase[(int)((global::System.UIntPtr)(num4 + 2U))] << 8);
					uint num7 = num5 & 65535U;
					this._hash[(int)((global::System.UIntPtr)(1024U + num7))] = this._pos;
					num8 = ((num5 ^ global::SevenZip.CRC.Table[(int)this._bufferBase[(int)((global::System.UIntPtr)(num4 + 3U))]] << 5) & this._hashMask);
				}
				else
				{
					num8 = (uint)((int)this._bufferBase[(int)((global::System.UIntPtr)num4)] ^ (int)this._bufferBase[(int)((global::System.UIntPtr)(num4 + 1U))] << 8);
				}
				uint num9 = this._hash[(int)((global::System.UIntPtr)(this.kFixHashSize + num8))];
				this._hash[(int)((global::System.UIntPtr)(this.kFixHashSize + num8))] = this._pos;
				uint num10 = (this._cyclicBufferPos << 1) + 1U;
				uint num11 = this._cyclicBufferPos << 1;
				uint val2;
				uint val = val2 = this.kNumHashDirectBytes;
				uint cutValue = this._cutValue;
				while (num9 > num3 && cutValue-- != 0U)
				{
					uint num12 = this._pos - num9;
					uint num13 = ((num12 <= this._cyclicBufferPos) ? (this._cyclicBufferPos - num12) : (this._cyclicBufferPos - num12 + this._cyclicBufferSize)) << 1;
					uint num14 = this._bufferOffset + num9;
					uint num15 = global::System.Math.Min(val2, val);
					if (this._bufferBase[(int)((global::System.UIntPtr)(num14 + num15))] == this._bufferBase[(int)((global::System.UIntPtr)(num4 + num15))])
					{
						while ((num15 += 1U) != num2 && this._bufferBase[(int)((global::System.UIntPtr)(num14 + num15))] == this._bufferBase[(int)((global::System.UIntPtr)(num4 + num15))])
						{
						}
						if (num15 == num2)
						{
							this._son[(int)((global::System.UIntPtr)num11)] = this._son[(int)((global::System.UIntPtr)num13)];
							this._son[(int)((global::System.UIntPtr)num10)] = this._son[(int)((global::System.UIntPtr)(num13 + 1U))];
							IL_2BB:
							this.MovePos();
							goto IL_2C1;
						}
					}
					if (this._bufferBase[(int)((global::System.UIntPtr)(num14 + num15))] < this._bufferBase[(int)((global::System.UIntPtr)(num4 + num15))])
					{
						this._son[(int)((global::System.UIntPtr)num11)] = num9;
						num11 = num13 + 1U;
						num9 = this._son[(int)((global::System.UIntPtr)num11)];
						val = num15;
					}
					else
					{
						this._son[(int)((global::System.UIntPtr)num10)] = num9;
						num10 = num13;
						num9 = this._son[(int)((global::System.UIntPtr)num10)];
						val2 = num15;
					}
				}
				this._son[(int)((global::System.UIntPtr)num10)] = (this._son[(int)((global::System.UIntPtr)num11)] = 0U);
				goto IL_2BB;
			}
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002DCC File Offset: 0x00000FCC
		private void NormalizeLinks(uint[] items, uint numItems, uint subValue)
		{
			for (uint num = 0U; num < numItems; num += 1U)
			{
				uint num2 = items[(int)((global::System.UIntPtr)num)];
				if (num2 <= subValue)
				{
					num2 = 0U;
				}
				else
				{
					num2 -= subValue;
				}
				items[(int)((global::System.UIntPtr)num)] = num2;
			}
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002DFC File Offset: 0x00000FFC
		private void Normalize()
		{
			uint subValue = this._pos - this._cyclicBufferSize;
			this.NormalizeLinks(this._son, this._cyclicBufferSize * 2U, subValue);
			this.NormalizeLinks(this._hash, this._hashSizeSum, subValue);
			base.ReduceOffsets((int)subValue);
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002E46 File Offset: 0x00001046
		public void SetCutValue(uint cutValue)
		{
			this._cutValue = cutValue;
		}

		// Token: 0x0400000E RID: 14
		private const uint kHash2Size = 1024U;

		// Token: 0x0400000F RID: 15
		private const uint kHash3Size = 65536U;

		// Token: 0x04000010 RID: 16
		private const uint kBT2HashSize = 65536U;

		// Token: 0x04000011 RID: 17
		private const uint kStartMaxLen = 1U;

		// Token: 0x04000012 RID: 18
		private const uint kHash3Offset = 1024U;

		// Token: 0x04000013 RID: 19
		private const uint kEmptyHashValue = 0U;

		// Token: 0x04000014 RID: 20
		private const uint kMaxValForNormalize = 2147483647U;

		// Token: 0x04000015 RID: 21
		private uint _cyclicBufferPos;

		// Token: 0x04000016 RID: 22
		private uint _cyclicBufferSize;

		// Token: 0x04000017 RID: 23
		private uint _matchMaxLen;

		// Token: 0x04000018 RID: 24
		private uint[] _son;

		// Token: 0x04000019 RID: 25
		private uint[] _hash;

		// Token: 0x0400001A RID: 26
		private uint _cutValue = 255U;

		// Token: 0x0400001B RID: 27
		private uint _hashMask;

		// Token: 0x0400001C RID: 28
		private uint _hashSizeSum;

		// Token: 0x0400001D RID: 29
		private bool HASH_ARRAY = true;

		// Token: 0x0400001E RID: 30
		private uint kNumHashDirectBytes;

		// Token: 0x0400001F RID: 31
		private uint kMinMatchCheck = 4U;

		// Token: 0x04000020 RID: 32
		private uint kFixHashSize = 66560U;
	}
}
