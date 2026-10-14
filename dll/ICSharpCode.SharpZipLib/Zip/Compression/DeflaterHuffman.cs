using System;

namespace ICSharpCode.SharpZipLib.Zip.Compression
{
	// Token: 0x0200003E RID: 62
	public class DeflaterHuffman
	{
		// Token: 0x06000273 RID: 627 RVA: 0x0000D488 File Offset: 0x0000C488
		static DeflaterHuffman()
		{
			int i = 0;
			while (i < 144)
			{
				global::ICSharpCode.SharpZipLib.Zip.Compression.DeflaterHuffman.staticLCodes[i] = global::ICSharpCode.SharpZipLib.Zip.Compression.DeflaterHuffman.BitReverse(48 + i << 8);
				global::ICSharpCode.SharpZipLib.Zip.Compression.DeflaterHuffman.staticLLength[i++] = 8;
			}
			while (i < 256)
			{
				global::ICSharpCode.SharpZipLib.Zip.Compression.DeflaterHuffman.staticLCodes[i] = global::ICSharpCode.SharpZipLib.Zip.Compression.DeflaterHuffman.BitReverse(256 + i << 7);
				global::ICSharpCode.SharpZipLib.Zip.Compression.DeflaterHuffman.staticLLength[i++] = 9;
			}
			while (i < 280)
			{
				global::ICSharpCode.SharpZipLib.Zip.Compression.DeflaterHuffman.staticLCodes[i] = global::ICSharpCode.SharpZipLib.Zip.Compression.DeflaterHuffman.BitReverse(-256 + i << 9);
				global::ICSharpCode.SharpZipLib.Zip.Compression.DeflaterHuffman.staticLLength[i++] = 7;
			}
			while (i < 286)
			{
				global::ICSharpCode.SharpZipLib.Zip.Compression.DeflaterHuffman.staticLCodes[i] = global::ICSharpCode.SharpZipLib.Zip.Compression.DeflaterHuffman.BitReverse(-88 + i << 8);
				global::ICSharpCode.SharpZipLib.Zip.Compression.DeflaterHuffman.staticLLength[i++] = 8;
			}
			global::ICSharpCode.SharpZipLib.Zip.Compression.DeflaterHuffman.staticDCodes = new short[30];
			global::ICSharpCode.SharpZipLib.Zip.Compression.DeflaterHuffman.staticDLength = new byte[30];
			for (i = 0; i < 30; i++)
			{
				global::ICSharpCode.SharpZipLib.Zip.Compression.DeflaterHuffman.staticDCodes[i] = global::ICSharpCode.SharpZipLib.Zip.Compression.DeflaterHuffman.BitReverse(i << 11);
				global::ICSharpCode.SharpZipLib.Zip.Compression.DeflaterHuffman.staticDLength[i] = 5;
			}
		}

		// Token: 0x06000274 RID: 628 RVA: 0x0000D5C8 File Offset: 0x0000C5C8
		public DeflaterHuffman(global::ICSharpCode.SharpZipLib.Zip.Compression.DeflaterPending pending)
		{
			this.pending = pending;
			this.literalTree = new global::ICSharpCode.SharpZipLib.Zip.Compression.DeflaterHuffman.Tree(this, 286, 257, 15);
			this.distTree = new global::ICSharpCode.SharpZipLib.Zip.Compression.DeflaterHuffman.Tree(this, 30, 1, 15);
			this.blTree = new global::ICSharpCode.SharpZipLib.Zip.Compression.DeflaterHuffman.Tree(this, 19, 4, 7);
			this.d_buf = new short[16384];
			this.l_buf = new byte[16384];
		}

		// Token: 0x06000275 RID: 629 RVA: 0x0000D63B File Offset: 0x0000C63B
		public void Reset()
		{
			this.last_lit = 0;
			this.extra_bits = 0;
			this.literalTree.Reset();
			this.distTree.Reset();
			this.blTree.Reset();
		}

		// Token: 0x06000276 RID: 630 RVA: 0x0000D66C File Offset: 0x0000C66C
		public void SendAllTrees(int blTreeCodes)
		{
			this.blTree.BuildCodes();
			this.literalTree.BuildCodes();
			this.distTree.BuildCodes();
			this.pending.WriteBits(this.literalTree.numCodes - 257, 5);
			this.pending.WriteBits(this.distTree.numCodes - 1, 5);
			this.pending.WriteBits(blTreeCodes - 4, 4);
			for (int i = 0; i < blTreeCodes; i++)
			{
				this.pending.WriteBits((int)this.blTree.length[global::ICSharpCode.SharpZipLib.Zip.Compression.DeflaterHuffman.BL_ORDER[i]], 3);
			}
			this.literalTree.WriteTree(this.blTree);
			this.distTree.WriteTree(this.blTree);
		}

		// Token: 0x06000277 RID: 631 RVA: 0x0000D72C File Offset: 0x0000C72C
		public void CompressBlock()
		{
			for (int i = 0; i < this.last_lit; i++)
			{
				int num = (int)(this.l_buf[i] & byte.MaxValue);
				int num2 = (int)this.d_buf[i];
				if (num2-- != 0)
				{
					int num3 = global::ICSharpCode.SharpZipLib.Zip.Compression.DeflaterHuffman.Lcode(num);
					this.literalTree.WriteSymbol(num3);
					int num4 = (num3 - 261) / 4;
					if (num4 > 0 && num4 <= 5)
					{
						this.pending.WriteBits(num & (1 << num4) - 1, num4);
					}
					int num5 = global::ICSharpCode.SharpZipLib.Zip.Compression.DeflaterHuffman.Dcode(num2);
					this.distTree.WriteSymbol(num5);
					num4 = num5 / 2 - 1;
					if (num4 > 0)
					{
						this.pending.WriteBits(num2 & (1 << num4) - 1, num4);
					}
				}
				else
				{
					this.literalTree.WriteSymbol(num);
				}
			}
			this.literalTree.WriteSymbol(256);
		}

		// Token: 0x06000278 RID: 632 RVA: 0x0000D808 File Offset: 0x0000C808
		public void FlushStoredBlock(byte[] stored, int storedOffset, int storedLength, bool lastBlock)
		{
			this.pending.WriteBits(lastBlock ? 1 : 0, 3);
			this.pending.AlignToByte();
			this.pending.WriteShort(storedLength);
			this.pending.WriteShort(~storedLength);
			this.pending.WriteBlock(stored, storedOffset, storedLength);
			this.Reset();
		}

		// Token: 0x06000279 RID: 633 RVA: 0x0000D864 File Offset: 0x0000C864
		public void FlushBlock(byte[] stored, int storedOffset, int storedLength, bool lastBlock)
		{
			short[] freqs = this.literalTree.freqs;
			int num = 256;
			freqs[num] += 1;
			this.literalTree.BuildTree();
			this.distTree.BuildTree();
			this.literalTree.CalcBLFreq(this.blTree);
			this.distTree.CalcBLFreq(this.blTree);
			this.blTree.BuildTree();
			int num2 = 4;
			for (int i = 18; i > num2; i--)
			{
				if (this.blTree.length[global::ICSharpCode.SharpZipLib.Zip.Compression.DeflaterHuffman.BL_ORDER[i]] > 0)
				{
					num2 = i + 1;
				}
			}
			int num3 = 14 + num2 * 3 + this.blTree.GetEncodedLength() + this.literalTree.GetEncodedLength() + this.distTree.GetEncodedLength() + this.extra_bits;
			int num4 = this.extra_bits;
			for (int j = 0; j < 286; j++)
			{
				num4 += (int)(this.literalTree.freqs[j] * (short)global::ICSharpCode.SharpZipLib.Zip.Compression.DeflaterHuffman.staticLLength[j]);
			}
			for (int k = 0; k < 30; k++)
			{
				num4 += (int)(this.distTree.freqs[k] * (short)global::ICSharpCode.SharpZipLib.Zip.Compression.DeflaterHuffman.staticDLength[k]);
			}
			if (num3 >= num4)
			{
				num3 = num4;
			}
			if (storedOffset >= 0 && storedLength + 4 < num3 >> 3)
			{
				this.FlushStoredBlock(stored, storedOffset, storedLength, lastBlock);
				return;
			}
			if (num3 == num4)
			{
				this.pending.WriteBits(2 + (lastBlock ? 1 : 0), 3);
				this.literalTree.SetStaticCodes(global::ICSharpCode.SharpZipLib.Zip.Compression.DeflaterHuffman.staticLCodes, global::ICSharpCode.SharpZipLib.Zip.Compression.DeflaterHuffman.staticLLength);
				this.distTree.SetStaticCodes(global::ICSharpCode.SharpZipLib.Zip.Compression.DeflaterHuffman.staticDCodes, global::ICSharpCode.SharpZipLib.Zip.Compression.DeflaterHuffman.staticDLength);
				this.CompressBlock();
				this.Reset();
				return;
			}
			this.pending.WriteBits(4 + (lastBlock ? 1 : 0), 3);
			this.SendAllTrees(num2);
			this.CompressBlock();
			this.Reset();
		}

		// Token: 0x0600027A RID: 634 RVA: 0x0000DA2A File Offset: 0x0000CA2A
		public bool IsFull()
		{
			return this.last_lit >= 16384;
		}

		// Token: 0x0600027B RID: 635 RVA: 0x0000DA3C File Offset: 0x0000CA3C
		public bool TallyLit(int literal)
		{
			this.d_buf[this.last_lit] = 0;
			this.l_buf[this.last_lit++] = (byte)literal;
			short[] freqs = this.literalTree.freqs;
			freqs[literal] += 1;
			return this.IsFull();
		}

		// Token: 0x0600027C RID: 636 RVA: 0x0000DA98 File Offset: 0x0000CA98
		public bool TallyDist(int distance, int length)
		{
			this.d_buf[this.last_lit] = (short)distance;
			this.l_buf[this.last_lit++] = (byte)(length - 3);
			int num = global::ICSharpCode.SharpZipLib.Zip.Compression.DeflaterHuffman.Lcode(length - 3);
			short[] freqs = this.literalTree.freqs;
			int num2 = num;
			freqs[num2] += 1;
			if (num >= 265 && num < 285)
			{
				this.extra_bits += (num - 261) / 4;
			}
			int num3 = global::ICSharpCode.SharpZipLib.Zip.Compression.DeflaterHuffman.Dcode(distance - 1);
			short[] freqs2 = this.distTree.freqs;
			int num4 = num3;
			freqs2[num4] += 1;
			if (num3 >= 4)
			{
				this.extra_bits += num3 / 2 - 1;
			}
			return this.IsFull();
		}

		// Token: 0x0600027D RID: 637 RVA: 0x0000DB62 File Offset: 0x0000CB62
		public static short BitReverse(int toReverse)
		{
			return (short)((int)global::ICSharpCode.SharpZipLib.Zip.Compression.DeflaterHuffman.bit4Reverse[toReverse & 15] << 12 | (int)global::ICSharpCode.SharpZipLib.Zip.Compression.DeflaterHuffman.bit4Reverse[toReverse >> 4 & 15] << 8 | (int)global::ICSharpCode.SharpZipLib.Zip.Compression.DeflaterHuffman.bit4Reverse[toReverse >> 8 & 15] << 4 | (int)global::ICSharpCode.SharpZipLib.Zip.Compression.DeflaterHuffman.bit4Reverse[toReverse >> 12]);
		}

		// Token: 0x0600027E RID: 638 RVA: 0x0000DB9C File Offset: 0x0000CB9C
		private static int Lcode(int length)
		{
			if (length == 255)
			{
				return 285;
			}
			int num = 257;
			while (length >= 8)
			{
				num += 4;
				length >>= 1;
			}
			return num + length;
		}

		// Token: 0x0600027F RID: 639 RVA: 0x0000DBD0 File Offset: 0x0000CBD0
		private static int Dcode(int distance)
		{
			int num = 0;
			while (distance >= 4)
			{
				num += 2;
				distance >>= 1;
			}
			return num + distance;
		}

		// Token: 0x0400016D RID: 365
		private const int BUFSIZE = 16384;

		// Token: 0x0400016E RID: 366
		private const int LITERAL_NUM = 286;

		// Token: 0x0400016F RID: 367
		private const int DIST_NUM = 30;

		// Token: 0x04000170 RID: 368
		private const int BITLEN_NUM = 19;

		// Token: 0x04000171 RID: 369
		private const int REP_3_6 = 16;

		// Token: 0x04000172 RID: 370
		private const int REP_3_10 = 17;

		// Token: 0x04000173 RID: 371
		private const int REP_11_138 = 18;

		// Token: 0x04000174 RID: 372
		private const int EOF_SYMBOL = 256;

		// Token: 0x04000175 RID: 373
		private static readonly int[] BL_ORDER = new int[]
		{
			16,
			17,
			18,
			0,
			8,
			7,
			9,
			6,
			10,
			5,
			11,
			4,
			12,
			3,
			13,
			2,
			14,
			1,
			15
		};

		// Token: 0x04000176 RID: 374
		private static readonly byte[] bit4Reverse = new byte[]
		{
			0,
			8,
			4,
			12,
			2,
			10,
			6,
			14,
			1,
			9,
			5,
			13,
			3,
			11,
			7,
			15
		};

		// Token: 0x04000177 RID: 375
		private static short[] staticLCodes = new short[286];

		// Token: 0x04000178 RID: 376
		private static byte[] staticLLength = new byte[286];

		// Token: 0x04000179 RID: 377
		private static short[] staticDCodes;

		// Token: 0x0400017A RID: 378
		private static byte[] staticDLength;

		// Token: 0x0400017B RID: 379
		public global::ICSharpCode.SharpZipLib.Zip.Compression.DeflaterPending pending;

		// Token: 0x0400017C RID: 380
		private global::ICSharpCode.SharpZipLib.Zip.Compression.DeflaterHuffman.Tree literalTree;

		// Token: 0x0400017D RID: 381
		private global::ICSharpCode.SharpZipLib.Zip.Compression.DeflaterHuffman.Tree distTree;

		// Token: 0x0400017E RID: 382
		private global::ICSharpCode.SharpZipLib.Zip.Compression.DeflaterHuffman.Tree blTree;

		// Token: 0x0400017F RID: 383
		private short[] d_buf;

		// Token: 0x04000180 RID: 384
		private byte[] l_buf;

		// Token: 0x04000181 RID: 385
		private int last_lit;

		// Token: 0x04000182 RID: 386
		private int extra_bits;

		// Token: 0x0200003F RID: 63
		private class Tree
		{
			// Token: 0x06000280 RID: 640 RVA: 0x0000DBF1 File Offset: 0x0000CBF1
			public Tree(global::ICSharpCode.SharpZipLib.Zip.Compression.DeflaterHuffman dh, int elems, int minCodes, int maxLength)
			{
				this.dh = dh;
				this.minNumCodes = minCodes;
				this.maxLength = maxLength;
				this.freqs = new short[elems];
				this.bl_counts = new int[maxLength];
			}

			// Token: 0x06000281 RID: 641 RVA: 0x0000DC28 File Offset: 0x0000CC28
			public void Reset()
			{
				for (int i = 0; i < this.freqs.Length; i++)
				{
					this.freqs[i] = 0;
				}
				this.codes = null;
				this.length = null;
			}

			// Token: 0x06000282 RID: 642 RVA: 0x0000DC5F File Offset: 0x0000CC5F
			public void WriteSymbol(int code)
			{
				this.dh.pending.WriteBits((int)this.codes[code] & 65535, (int)this.length[code]);
			}

			// Token: 0x06000283 RID: 643 RVA: 0x0000DC88 File Offset: 0x0000CC88
			public void CheckEmpty()
			{
				bool flag = true;
				for (int i = 0; i < this.freqs.Length; i++)
				{
					if (this.freqs[i] != 0)
					{
						flag = false;
					}
				}
				if (!flag)
				{
					throw new global::ICSharpCode.SharpZipLib.SharpZipBaseException("!Empty");
				}
			}

			// Token: 0x06000284 RID: 644 RVA: 0x0000DCC4 File Offset: 0x0000CCC4
			public void SetStaticCodes(short[] staticCodes, byte[] staticLengths)
			{
				this.codes = staticCodes;
				this.length = staticLengths;
			}

			// Token: 0x06000285 RID: 645 RVA: 0x0000DCD4 File Offset: 0x0000CCD4
			public void BuildCodes()
			{
				int num = this.freqs.Length;
				int[] array = new int[this.maxLength];
				int num2 = 0;
				this.codes = new short[this.freqs.Length];
				for (int i = 0; i < this.maxLength; i++)
				{
					array[i] = num2;
					num2 += this.bl_counts[i] << 15 - i;
				}
				for (int j = 0; j < this.numCodes; j++)
				{
					int num3 = (int)this.length[j];
					if (num3 > 0)
					{
						this.codes[j] = global::ICSharpCode.SharpZipLib.Zip.Compression.DeflaterHuffman.BitReverse(array[num3 - 1]);
						array[num3 - 1] += 1 << 16 - num3;
					}
				}
			}

			// Token: 0x06000286 RID: 646 RVA: 0x0000DD88 File Offset: 0x0000CD88
			public void BuildTree()
			{
				int num = this.freqs.Length;
				int[] array = new int[num];
				int i = 0;
				int num2 = 0;
				for (int j = 0; j < num; j++)
				{
					int num3 = (int)this.freqs[j];
					if (num3 != 0)
					{
						int num4 = i++;
						int num5;
						while (num4 > 0 && (int)this.freqs[array[num5 = (num4 - 1) / 2]] > num3)
						{
							array[num4] = array[num5];
							num4 = num5;
						}
						array[num4] = j;
						num2 = j;
					}
				}
				while (i < 2)
				{
					int num6 = (num2 < 2) ? (++num2) : 0;
					array[i++] = num6;
				}
				this.numCodes = global::System.Math.Max(num2 + 1, this.minNumCodes);
				int num7 = i;
				int[] array2 = new int[4 * i - 2];
				int[] array3 = new int[2 * i - 1];
				int num8 = num7;
				for (int k = 0; k < i; k++)
				{
					int num9 = array[k];
					array2[2 * k] = num9;
					array2[2 * k + 1] = -1;
					array3[k] = (int)this.freqs[num9] << 8;
					array[k] = k;
				}
				do
				{
					int num10 = array[0];
					int num11 = array[--i];
					int num12 = 0;
					int l;
					for (l = 1; l < i; l = l * 2 + 1)
					{
						if (l + 1 < i && array3[array[l]] > array3[array[l + 1]])
						{
							l++;
						}
						array[num12] = array[l];
						num12 = l;
					}
					int num13 = array3[num11];
					while ((l = num12) > 0 && array3[array[num12 = (l - 1) / 2]] > num13)
					{
						array[l] = array[num12];
					}
					array[l] = num11;
					int num14 = array[0];
					num11 = num8++;
					array2[2 * num11] = num10;
					array2[2 * num11 + 1] = num14;
					int num15 = global::System.Math.Min(array3[num10] & 255, array3[num14] & 255);
					num13 = (array3[num11] = array3[num10] + array3[num14] - num15 + 1);
					num12 = 0;
					for (l = 1; l < i; l = num12 * 2 + 1)
					{
						if (l + 1 < i && array3[array[l]] > array3[array[l + 1]])
						{
							l++;
						}
						array[num12] = array[l];
						num12 = l;
					}
					while ((l = num12) > 0 && array3[array[num12 = (l - 1) / 2]] > num13)
					{
						array[l] = array[num12];
					}
					array[l] = num11;
				}
				while (i > 1);
				if (array[0] != array2.Length / 2 - 1)
				{
					throw new global::ICSharpCode.SharpZipLib.SharpZipBaseException("Heap invariant violated");
				}
				this.BuildLength(array2);
			}

			// Token: 0x06000287 RID: 647 RVA: 0x0000DFF8 File Offset: 0x0000CFF8
			public int GetEncodedLength()
			{
				int num = 0;
				for (int i = 0; i < this.freqs.Length; i++)
				{
					num += (int)(this.freqs[i] * (short)this.length[i]);
				}
				return num;
			}

			// Token: 0x06000288 RID: 648 RVA: 0x0000E030 File Offset: 0x0000D030
			public void CalcBLFreq(global::ICSharpCode.SharpZipLib.Zip.Compression.DeflaterHuffman.Tree blTree)
			{
				int num = -1;
				int i = 0;
				while (i < this.numCodes)
				{
					int num2 = 1;
					int num3 = (int)this.length[i];
					int num4;
					int num5;
					if (num3 == 0)
					{
						num4 = 138;
						num5 = 3;
					}
					else
					{
						num4 = 6;
						num5 = 3;
						if (num != num3)
						{
							short[] array = blTree.freqs;
							int num6 = num3;
							array[num6] += 1;
							num2 = 0;
						}
					}
					num = num3;
					i++;
					while (i < this.numCodes && num == (int)this.length[i])
					{
						i++;
						if (++num2 >= num4)
						{
							break;
						}
					}
					if (num2 < num5)
					{
						short[] array2 = blTree.freqs;
						int num7 = num;
						array2[num7] += (short)num2;
					}
					else if (num != 0)
					{
						short[] array3 = blTree.freqs;
						int num8 = 16;
						array3[num8] += 1;
					}
					else if (num2 <= 10)
					{
						short[] array4 = blTree.freqs;
						int num9 = 17;
						array4[num9] += 1;
					}
					else
					{
						short[] array5 = blTree.freqs;
						int num10 = 18;
						array5[num10] += 1;
					}
				}
			}

			// Token: 0x06000289 RID: 649 RVA: 0x0000E144 File Offset: 0x0000D144
			public void WriteTree(global::ICSharpCode.SharpZipLib.Zip.Compression.DeflaterHuffman.Tree blTree)
			{
				int num = -1;
				int i = 0;
				while (i < this.numCodes)
				{
					int num2 = 1;
					int num3 = (int)this.length[i];
					int num4;
					int num5;
					if (num3 == 0)
					{
						num4 = 138;
						num5 = 3;
					}
					else
					{
						num4 = 6;
						num5 = 3;
						if (num != num3)
						{
							blTree.WriteSymbol(num3);
							num2 = 0;
						}
					}
					num = num3;
					i++;
					while (i < this.numCodes && num == (int)this.length[i])
					{
						i++;
						if (++num2 >= num4)
						{
							break;
						}
					}
					if (num2 < num5)
					{
						while (num2-- > 0)
						{
							blTree.WriteSymbol(num);
						}
					}
					else if (num != 0)
					{
						blTree.WriteSymbol(16);
						this.dh.pending.WriteBits(num2 - 3, 2);
					}
					else if (num2 <= 10)
					{
						blTree.WriteSymbol(17);
						this.dh.pending.WriteBits(num2 - 3, 3);
					}
					else
					{
						blTree.WriteSymbol(18);
						this.dh.pending.WriteBits(num2 - 11, 7);
					}
				}
			}

			// Token: 0x0600028A RID: 650 RVA: 0x0000E240 File Offset: 0x0000D240
			private void BuildLength(int[] childs)
			{
				this.length = new byte[this.freqs.Length];
				int num = childs.Length / 2;
				int num2 = (num + 1) / 2;
				int num3 = 0;
				for (int i = 0; i < this.maxLength; i++)
				{
					this.bl_counts[i] = 0;
				}
				int[] array = new int[num];
				array[num - 1] = 0;
				for (int j = num - 1; j >= 0; j--)
				{
					if (childs[2 * j + 1] != -1)
					{
						int num4 = array[j] + 1;
						if (num4 > this.maxLength)
						{
							num4 = this.maxLength;
							num3++;
						}
						array[childs[2 * j]] = (array[childs[2 * j + 1]] = num4);
					}
					else
					{
						int num5 = array[j];
						this.bl_counts[num5 - 1]++;
						this.length[childs[2 * j]] = (byte)array[j];
					}
				}
				if (num3 == 0)
				{
					return;
				}
				int num6 = this.maxLength - 1;
				for (;;)
				{
					if (this.bl_counts[--num6] != 0)
					{
						do
						{
							this.bl_counts[num6]--;
							this.bl_counts[++num6]++;
							num3 -= 1 << this.maxLength - 1 - num6;
						}
						while (num3 > 0 && num6 < this.maxLength - 1);
						if (num3 <= 0)
						{
							break;
						}
					}
				}
				this.bl_counts[this.maxLength - 1] += num3;
				this.bl_counts[this.maxLength - 2] -= num3;
				int num7 = 2 * num2;
				for (int num8 = this.maxLength; num8 != 0; num8--)
				{
					int k = this.bl_counts[num8 - 1];
					while (k > 0)
					{
						int num9 = 2 * childs[num7++];
						if (childs[num9 + 1] == -1)
						{
							this.length[childs[num9]] = (byte)num8;
							k--;
						}
					}
				}
			}

			// Token: 0x04000183 RID: 387
			public short[] freqs;

			// Token: 0x04000184 RID: 388
			public byte[] length;

			// Token: 0x04000185 RID: 389
			public int minNumCodes;

			// Token: 0x04000186 RID: 390
			public int numCodes;

			// Token: 0x04000187 RID: 391
			private short[] codes;

			// Token: 0x04000188 RID: 392
			private int[] bl_counts;

			// Token: 0x04000189 RID: 393
			private int maxLength;

			// Token: 0x0400018A RID: 394
			private global::ICSharpCode.SharpZipLib.Zip.Compression.DeflaterHuffman dh;
		}
	}
}
