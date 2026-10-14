using System;
using ICSharpCode.SharpZipLib.Zip.Compression.Streams;

namespace ICSharpCode.SharpZipLib.Zip.Compression
{
	// Token: 0x02000043 RID: 67
	internal class InflaterDynHeader
	{
		// Token: 0x060002B1 RID: 689 RVA: 0x0000F34C File Offset: 0x0000E34C
		public bool Decode(global::ICSharpCode.SharpZipLib.Zip.Compression.Streams.StreamManipulator input)
		{
			for (;;)
			{
				switch (this.mode)
				{
				case 0:
					this.lnum = input.PeekBits(5);
					if (this.lnum < 0)
					{
						return false;
					}
					this.lnum += 257;
					input.DropBits(5);
					this.mode = 1;
					goto IL_61;
				case 1:
					goto IL_61;
				case 2:
					goto IL_B9;
				case 3:
					break;
				case 4:
					goto IL_1A8;
				case 5:
					goto IL_1EE;
				default:
					continue;
				}
				IL_13B:
				while (this.ptr < this.blnum)
				{
					int num = input.PeekBits(3);
					if (num < 0)
					{
						return false;
					}
					input.DropBits(3);
					this.blLens[global::ICSharpCode.SharpZipLib.Zip.Compression.InflaterDynHeader.BL_ORDER[this.ptr]] = (byte)num;
					this.ptr++;
				}
				this.blTree = new global::ICSharpCode.SharpZipLib.Zip.Compression.InflaterHuffmanTree(this.blLens);
				this.blLens = null;
				this.ptr = 0;
				this.mode = 4;
				IL_1A8:
				int symbol;
				while (((symbol = this.blTree.GetSymbol(input)) & -16) == 0)
				{
					this.litdistLens[this.ptr++] = (this.lastLen = (byte)symbol);
					if (this.ptr == this.num)
					{
						return true;
					}
				}
				if (symbol < 0)
				{
					return false;
				}
				if (symbol >= 17)
				{
					this.lastLen = 0;
				}
				else if (this.ptr == 0)
				{
					goto Block_10;
				}
				this.repSymbol = symbol - 16;
				this.mode = 5;
				IL_1EE:
				int bitCount = global::ICSharpCode.SharpZipLib.Zip.Compression.InflaterDynHeader.repBits[this.repSymbol];
				int num2 = input.PeekBits(bitCount);
				if (num2 < 0)
				{
					return false;
				}
				input.DropBits(bitCount);
				num2 += global::ICSharpCode.SharpZipLib.Zip.Compression.InflaterDynHeader.repMin[this.repSymbol];
				if (this.ptr + num2 > this.num)
				{
					goto Block_12;
				}
				while (num2-- > 0)
				{
					this.litdistLens[this.ptr++] = this.lastLen;
				}
				if (this.ptr == this.num)
				{
					return true;
				}
				this.mode = 4;
				continue;
				IL_B9:
				this.blnum = input.PeekBits(4);
				if (this.blnum < 0)
				{
					return false;
				}
				this.blnum += 4;
				input.DropBits(4);
				this.blLens = new byte[19];
				this.ptr = 0;
				this.mode = 3;
				goto IL_13B;
				IL_61:
				this.dnum = input.PeekBits(5);
				if (this.dnum < 0)
				{
					return false;
				}
				this.dnum++;
				input.DropBits(5);
				this.num = this.lnum + this.dnum;
				this.litdistLens = new byte[this.num];
				this.mode = 2;
				goto IL_B9;
			}
			return false;
			Block_10:
			throw new global::ICSharpCode.SharpZipLib.SharpZipBaseException();
			Block_12:
			throw new global::ICSharpCode.SharpZipLib.SharpZipBaseException();
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x0000F5D4 File Offset: 0x0000E5D4
		public global::ICSharpCode.SharpZipLib.Zip.Compression.InflaterHuffmanTree BuildLitLenTree()
		{
			byte[] array = new byte[this.lnum];
			global::System.Array.Copy(this.litdistLens, 0, array, 0, this.lnum);
			return new global::ICSharpCode.SharpZipLib.Zip.Compression.InflaterHuffmanTree(array);
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x0000F608 File Offset: 0x0000E608
		public global::ICSharpCode.SharpZipLib.Zip.Compression.InflaterHuffmanTree BuildDistTree()
		{
			byte[] array = new byte[this.dnum];
			global::System.Array.Copy(this.litdistLens, this.lnum, array, 0, this.dnum);
			return new global::ICSharpCode.SharpZipLib.Zip.Compression.InflaterHuffmanTree(array);
		}

		// Token: 0x040001B1 RID: 433
		private const int LNUM = 0;

		// Token: 0x040001B2 RID: 434
		private const int DNUM = 1;

		// Token: 0x040001B3 RID: 435
		private const int BLNUM = 2;

		// Token: 0x040001B4 RID: 436
		private const int BLLENS = 3;

		// Token: 0x040001B5 RID: 437
		private const int LENS = 4;

		// Token: 0x040001B6 RID: 438
		private const int REPS = 5;

		// Token: 0x040001B7 RID: 439
		private static readonly int[] repMin = new int[]
		{
			3,
			3,
			11
		};

		// Token: 0x040001B8 RID: 440
		private static readonly int[] repBits = new int[]
		{
			2,
			3,
			7
		};

		// Token: 0x040001B9 RID: 441
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

		// Token: 0x040001BA RID: 442
		private byte[] blLens;

		// Token: 0x040001BB RID: 443
		private byte[] litdistLens;

		// Token: 0x040001BC RID: 444
		private global::ICSharpCode.SharpZipLib.Zip.Compression.InflaterHuffmanTree blTree;

		// Token: 0x040001BD RID: 445
		private int mode;

		// Token: 0x040001BE RID: 446
		private int lnum;

		// Token: 0x040001BF RID: 447
		private int dnum;

		// Token: 0x040001C0 RID: 448
		private int blnum;

		// Token: 0x040001C1 RID: 449
		private int num;

		// Token: 0x040001C2 RID: 450
		private int repSymbol;

		// Token: 0x040001C3 RID: 451
		private byte lastLen;

		// Token: 0x040001C4 RID: 452
		private int ptr;
	}
}
