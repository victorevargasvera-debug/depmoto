using System;
using ICSharpCode.SharpZipLib.Checksums;

namespace ICSharpCode.SharpZipLib.Zip.Compression
{
	// Token: 0x0200003D RID: 61
	public class DeflaterEngine : global::ICSharpCode.SharpZipLib.Zip.Compression.DeflaterConstants
	{
		// Token: 0x0600025F RID: 607 RVA: 0x0000C5D4 File Offset: 0x0000B5D4
		public DeflaterEngine(global::ICSharpCode.SharpZipLib.Zip.Compression.DeflaterPending pending)
		{
			this.pending = pending;
			this.huffman = new global::ICSharpCode.SharpZipLib.Zip.Compression.DeflaterHuffman(pending);
			this.adler = new global::ICSharpCode.SharpZipLib.Checksums.Adler32();
			this.window = new byte[65536];
			this.head = new short[32768];
			this.prev = new short[32768];
			this.blockStart = (this.strstart = 1);
		}

		// Token: 0x06000260 RID: 608 RVA: 0x0000C648 File Offset: 0x0000B648
		public bool Deflate(bool flush, bool finish)
		{
			for (;;)
			{
				this.FillWindow();
				bool flush2 = flush && this.inputOff == this.inputEnd;
				bool flag;
				switch (this.compressionFunction)
				{
				case 0:
					flag = this.DeflateStored(flush2, finish);
					goto IL_62;
				case 1:
					flag = this.DeflateFast(flush2, finish);
					goto IL_62;
				case 2:
					flag = this.DeflateSlow(flush2, finish);
					goto IL_62;
				}
				break;
				IL_62:
				if (!this.pending.IsFlushed || !flag)
				{
					return flag;
				}
			}
			throw new global::System.InvalidOperationException("unknown compressionFunction");
		}

		// Token: 0x06000261 RID: 609 RVA: 0x0000C6C8 File Offset: 0x0000B6C8
		public void SetInput(byte[] buffer, int offset, int count)
		{
			if (buffer == null)
			{
				throw new global::System.ArgumentNullException("buffer");
			}
			if (offset < 0)
			{
				throw new global::System.ArgumentOutOfRangeException("offset");
			}
			if (count < 0)
			{
				throw new global::System.ArgumentOutOfRangeException("count");
			}
			if (this.inputOff < this.inputEnd)
			{
				throw new global::System.InvalidOperationException("Old input was not completely processed");
			}
			int num = offset + count;
			if (offset > num || num > buffer.Length)
			{
				throw new global::System.ArgumentOutOfRangeException("count");
			}
			this.inputBuf = buffer;
			this.inputOff = offset;
			this.inputEnd = num;
		}

		// Token: 0x06000262 RID: 610 RVA: 0x0000C748 File Offset: 0x0000B748
		public bool NeedsInput()
		{
			return this.inputEnd == this.inputOff;
		}

		// Token: 0x06000263 RID: 611 RVA: 0x0000C758 File Offset: 0x0000B758
		public void SetDictionary(byte[] buffer, int offset, int length)
		{
			this.adler.Update(buffer, offset, length);
			if (length < 3)
			{
				return;
			}
			if (length > 32506)
			{
				offset += length - 32506;
				length = 32506;
			}
			global::System.Array.Copy(buffer, offset, this.window, this.strstart, length);
			this.UpdateHash();
			length--;
			while (--length > 0)
			{
				this.InsertString();
				this.strstart++;
			}
			this.strstart += 2;
			this.blockStart = this.strstart;
		}

		// Token: 0x06000264 RID: 612 RVA: 0x0000C7EC File Offset: 0x0000B7EC
		public void Reset()
		{
			this.huffman.Reset();
			this.adler.Reset();
			this.blockStart = (this.strstart = 1);
			this.lookahead = 0;
			this.totalIn = 0L;
			this.prevAvailable = false;
			this.matchLen = 2;
			for (int i = 0; i < 32768; i++)
			{
				this.head[i] = 0;
			}
			for (int j = 0; j < 32768; j++)
			{
				this.prev[j] = 0;
			}
		}

		// Token: 0x06000265 RID: 613 RVA: 0x0000C86E File Offset: 0x0000B86E
		public void ResetAdler()
		{
			this.adler.Reset();
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x06000266 RID: 614 RVA: 0x0000C87B File Offset: 0x0000B87B
		public int Adler
		{
			get
			{
				return (int)this.adler.Value;
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x06000267 RID: 615 RVA: 0x0000C889 File Offset: 0x0000B889
		public long TotalIn
		{
			get
			{
				return this.totalIn;
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x06000268 RID: 616 RVA: 0x0000C891 File Offset: 0x0000B891
		// (set) Token: 0x06000269 RID: 617 RVA: 0x0000C899 File Offset: 0x0000B899
		public global::ICSharpCode.SharpZipLib.Zip.Compression.DeflateStrategy Strategy
		{
			get
			{
				return this.strategy;
			}
			set
			{
				this.strategy = value;
			}
		}

		// Token: 0x0600026A RID: 618 RVA: 0x0000C8A4 File Offset: 0x0000B8A4
		public void SetLevel(int level)
		{
			if (level < 0 || level > 9)
			{
				throw new global::System.ArgumentOutOfRangeException("level");
			}
			this.goodLength = global::ICSharpCode.SharpZipLib.Zip.Compression.DeflaterConstants.GOOD_LENGTH[level];
			this.max_lazy = global::ICSharpCode.SharpZipLib.Zip.Compression.DeflaterConstants.MAX_LAZY[level];
			this.niceLength = global::ICSharpCode.SharpZipLib.Zip.Compression.DeflaterConstants.NICE_LENGTH[level];
			this.max_chain = global::ICSharpCode.SharpZipLib.Zip.Compression.DeflaterConstants.MAX_CHAIN[level];
			if (global::ICSharpCode.SharpZipLib.Zip.Compression.DeflaterConstants.COMPR_FUNC[level] != this.compressionFunction)
			{
				switch (this.compressionFunction)
				{
				case 0:
					if (this.strstart > this.blockStart)
					{
						this.huffman.FlushStoredBlock(this.window, this.blockStart, this.strstart - this.blockStart, false);
						this.blockStart = this.strstart;
					}
					this.UpdateHash();
					break;
				case 1:
					if (this.strstart > this.blockStart)
					{
						this.huffman.FlushBlock(this.window, this.blockStart, this.strstart - this.blockStart, false);
						this.blockStart = this.strstart;
					}
					break;
				case 2:
					if (this.prevAvailable)
					{
						this.huffman.TallyLit((int)(this.window[this.strstart - 1] & byte.MaxValue));
					}
					if (this.strstart > this.blockStart)
					{
						this.huffman.FlushBlock(this.window, this.blockStart, this.strstart - this.blockStart, false);
						this.blockStart = this.strstart;
					}
					this.prevAvailable = false;
					this.matchLen = 2;
					break;
				}
				this.compressionFunction = global::ICSharpCode.SharpZipLib.Zip.Compression.DeflaterConstants.COMPR_FUNC[level];
			}
		}

		// Token: 0x0600026B RID: 619 RVA: 0x0000CA3C File Offset: 0x0000BA3C
		public void FillWindow()
		{
			if (this.strstart >= 65274)
			{
				this.SlideWindow();
			}
			while (this.lookahead < 262 && this.inputOff < this.inputEnd)
			{
				int num = 65536 - this.lookahead - this.strstart;
				if (num > this.inputEnd - this.inputOff)
				{
					num = this.inputEnd - this.inputOff;
				}
				global::System.Array.Copy(this.inputBuf, this.inputOff, this.window, this.strstart + this.lookahead, num);
				this.adler.Update(this.inputBuf, this.inputOff, num);
				this.inputOff += num;
				this.totalIn += (long)num;
				this.lookahead += num;
			}
			if (this.lookahead >= 3)
			{
				this.UpdateHash();
			}
		}

		// Token: 0x0600026C RID: 620 RVA: 0x0000CB2B File Offset: 0x0000BB2B
		private void UpdateHash()
		{
			this.ins_h = ((int)this.window[this.strstart] << 5 ^ (int)this.window[this.strstart + 1]);
		}

		// Token: 0x0600026D RID: 621 RVA: 0x0000CB54 File Offset: 0x0000BB54
		private int InsertString()
		{
			int num = (this.ins_h << 5 ^ (int)this.window[this.strstart + 2]) & 32767;
			short num2 = this.prev[this.strstart & 32767] = this.head[num];
			this.head[num] = (short)this.strstart;
			this.ins_h = num;
			return (int)num2 & 65535;
		}

		// Token: 0x0600026E RID: 622 RVA: 0x0000CBBC File Offset: 0x0000BBBC
		private void SlideWindow()
		{
			global::System.Array.Copy(this.window, 32768, this.window, 0, 32768);
			this.matchStart -= 32768;
			this.strstart -= 32768;
			this.blockStart -= 32768;
			for (int i = 0; i < 32768; i++)
			{
				int num = (int)this.head[i] & 65535;
				this.head[i] = (short)((num >= 32768) ? (num - 32768) : 0);
			}
			for (int j = 0; j < 32768; j++)
			{
				int num2 = (int)this.prev[j] & 65535;
				this.prev[j] = (short)((num2 >= 32768) ? (num2 - 32768) : 0);
			}
		}

		// Token: 0x0600026F RID: 623 RVA: 0x0000CC90 File Offset: 0x0000BC90
		private bool FindLongestMatch(int curMatch)
		{
			int num = this.max_chain;
			int num2 = this.niceLength;
			short[] array = this.prev;
			int num3 = this.strstart;
			int num4 = this.strstart + this.matchLen;
			int num5 = global::System.Math.Max(this.matchLen, 2);
			int num6 = global::System.Math.Max(this.strstart - 32506, 0);
			int num7 = this.strstart + 258 - 1;
			byte b = this.window[num4 - 1];
			byte b2 = this.window[num4];
			if (num5 >= this.goodLength)
			{
				num >>= 2;
			}
			if (num2 > this.lookahead)
			{
				num2 = this.lookahead;
			}
			do
			{
				if (this.window[curMatch + num5] == b2 && this.window[curMatch + num5 - 1] == b && this.window[curMatch] == this.window[num3] && this.window[curMatch + 1] == this.window[num3 + 1])
				{
					int num8 = curMatch + 2;
					num3 += 2;
					while (this.window[++num3] == this.window[++num8] && this.window[++num3] == this.window[++num8] && this.window[++num3] == this.window[++num8] && this.window[++num3] == this.window[++num8] && this.window[++num3] == this.window[++num8] && this.window[++num3] == this.window[++num8] && this.window[++num3] == this.window[++num8] && this.window[++num3] == this.window[++num8] && num3 < num7)
					{
					}
					if (num3 > num4)
					{
						this.matchStart = curMatch;
						num4 = num3;
						num5 = num3 - this.strstart;
						if (num5 >= num2)
						{
							break;
						}
						b = this.window[num4 - 1];
						b2 = this.window[num4];
					}
					num3 = this.strstart;
				}
			}
			while ((curMatch = ((int)array[curMatch & 32767] & 65535)) > num6 && --num != 0);
			this.matchLen = global::System.Math.Min(num5, this.lookahead);
			return this.matchLen >= 3;
		}

		// Token: 0x06000270 RID: 624 RVA: 0x0000CEFC File Offset: 0x0000BEFC
		private bool DeflateStored(bool flush, bool finish)
		{
			if (!flush && this.lookahead == 0)
			{
				return false;
			}
			this.strstart += this.lookahead;
			this.lookahead = 0;
			int num = this.strstart - this.blockStart;
			if (num >= global::ICSharpCode.SharpZipLib.Zip.Compression.DeflaterConstants.MAX_BLOCK_SIZE || (this.blockStart < 32768 && num >= 32506) || flush)
			{
				bool flag = finish;
				if (num > global::ICSharpCode.SharpZipLib.Zip.Compression.DeflaterConstants.MAX_BLOCK_SIZE)
				{
					num = global::ICSharpCode.SharpZipLib.Zip.Compression.DeflaterConstants.MAX_BLOCK_SIZE;
					flag = false;
				}
				this.huffman.FlushStoredBlock(this.window, this.blockStart, num, flag);
				this.blockStart += num;
				return !flag;
			}
			return true;
		}

		// Token: 0x06000271 RID: 625 RVA: 0x0000CFA0 File Offset: 0x0000BFA0
		private bool DeflateFast(bool flush, bool finish)
		{
			if (this.lookahead < 262 && !flush)
			{
				return false;
			}
			while (this.lookahead >= 262 || flush)
			{
				if (this.lookahead == 0)
				{
					this.huffman.FlushBlock(this.window, this.blockStart, this.strstart - this.blockStart, finish);
					this.blockStart = this.strstart;
					return false;
				}
				if (this.strstart > 65274)
				{
					this.SlideWindow();
				}
				int num;
				if (this.lookahead >= 3 && (num = this.InsertString()) != 0 && this.strategy != global::ICSharpCode.SharpZipLib.Zip.Compression.DeflateStrategy.HuffmanOnly && this.strstart - num <= 32506 && this.FindLongestMatch(num))
				{
					bool flag = this.huffman.TallyDist(this.strstart - this.matchStart, this.matchLen);
					this.lookahead -= this.matchLen;
					if (this.matchLen <= this.max_lazy && this.lookahead >= 3)
					{
						while (--this.matchLen > 0)
						{
							this.strstart++;
							this.InsertString();
						}
						this.strstart++;
					}
					else
					{
						this.strstart += this.matchLen;
						if (this.lookahead >= 2)
						{
							this.UpdateHash();
						}
					}
					this.matchLen = 2;
					if (!flag)
					{
						continue;
					}
				}
				else
				{
					this.huffman.TallyLit((int)(this.window[this.strstart] & byte.MaxValue));
					this.strstart++;
					this.lookahead--;
				}
				if (this.huffman.IsFull())
				{
					bool flag2 = finish && this.lookahead == 0;
					this.huffman.FlushBlock(this.window, this.blockStart, this.strstart - this.blockStart, flag2);
					this.blockStart = this.strstart;
					return !flag2;
				}
			}
			return true;
		}

		// Token: 0x06000272 RID: 626 RVA: 0x0000D1B0 File Offset: 0x0000C1B0
		private bool DeflateSlow(bool flush, bool finish)
		{
			if (this.lookahead < 262 && !flush)
			{
				return false;
			}
			while (this.lookahead >= 262 || flush)
			{
				if (this.lookahead == 0)
				{
					if (this.prevAvailable)
					{
						this.huffman.TallyLit((int)(this.window[this.strstart - 1] & byte.MaxValue));
					}
					this.prevAvailable = false;
					this.huffman.FlushBlock(this.window, this.blockStart, this.strstart - this.blockStart, finish);
					this.blockStart = this.strstart;
					return false;
				}
				if (this.strstart >= 65274)
				{
					this.SlideWindow();
				}
				int num = this.matchStart;
				int num2 = this.matchLen;
				if (this.lookahead >= 3)
				{
					int num3 = this.InsertString();
					if (this.strategy != global::ICSharpCode.SharpZipLib.Zip.Compression.DeflateStrategy.HuffmanOnly && num3 != 0 && this.strstart - num3 <= 32506 && this.FindLongestMatch(num3) && this.matchLen <= 5 && (this.strategy == global::ICSharpCode.SharpZipLib.Zip.Compression.DeflateStrategy.Filtered || (this.matchLen == 3 && this.strstart - this.matchStart > 4096)))
					{
						this.matchLen = 2;
					}
				}
				if (num2 >= 3 && this.matchLen <= num2)
				{
					this.huffman.TallyDist(this.strstart - 1 - num, num2);
					num2 -= 2;
					do
					{
						this.strstart++;
						this.lookahead--;
						if (this.lookahead >= 3)
						{
							this.InsertString();
						}
					}
					while (--num2 > 0);
					this.strstart++;
					this.lookahead--;
					this.prevAvailable = false;
					this.matchLen = 2;
				}
				else
				{
					if (this.prevAvailable)
					{
						this.huffman.TallyLit((int)(this.window[this.strstart - 1] & byte.MaxValue));
					}
					this.prevAvailable = true;
					this.strstart++;
					this.lookahead--;
				}
				if (this.huffman.IsFull())
				{
					int num4 = this.strstart - this.blockStart;
					if (this.prevAvailable)
					{
						num4--;
					}
					bool flag = finish && this.lookahead == 0 && !this.prevAvailable;
					this.huffman.FlushBlock(this.window, this.blockStart, num4, flag);
					this.blockStart += num4;
					return !flag;
				}
			}
			return true;
		}

		// Token: 0x04000155 RID: 341
		private const int TooFar = 4096;

		// Token: 0x04000156 RID: 342
		private int ins_h;

		// Token: 0x04000157 RID: 343
		private short[] head;

		// Token: 0x04000158 RID: 344
		private short[] prev;

		// Token: 0x04000159 RID: 345
		private int matchStart;

		// Token: 0x0400015A RID: 346
		private int matchLen;

		// Token: 0x0400015B RID: 347
		private bool prevAvailable;

		// Token: 0x0400015C RID: 348
		private int blockStart;

		// Token: 0x0400015D RID: 349
		private int strstart;

		// Token: 0x0400015E RID: 350
		private int lookahead;

		// Token: 0x0400015F RID: 351
		private byte[] window;

		// Token: 0x04000160 RID: 352
		private global::ICSharpCode.SharpZipLib.Zip.Compression.DeflateStrategy strategy;

		// Token: 0x04000161 RID: 353
		private int max_chain;

		// Token: 0x04000162 RID: 354
		private int max_lazy;

		// Token: 0x04000163 RID: 355
		private int niceLength;

		// Token: 0x04000164 RID: 356
		private int goodLength;

		// Token: 0x04000165 RID: 357
		private int compressionFunction;

		// Token: 0x04000166 RID: 358
		private byte[] inputBuf;

		// Token: 0x04000167 RID: 359
		private long totalIn;

		// Token: 0x04000168 RID: 360
		private int inputOff;

		// Token: 0x04000169 RID: 361
		private int inputEnd;

		// Token: 0x0400016A RID: 362
		private global::ICSharpCode.SharpZipLib.Zip.Compression.DeflaterPending pending;

		// Token: 0x0400016B RID: 363
		private global::ICSharpCode.SharpZipLib.Zip.Compression.DeflaterHuffman huffman;

		// Token: 0x0400016C RID: 364
		private global::ICSharpCode.SharpZipLib.Checksums.Adler32 adler;
	}
}
