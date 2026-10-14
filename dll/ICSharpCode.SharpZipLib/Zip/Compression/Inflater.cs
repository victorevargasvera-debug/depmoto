using System;
using ICSharpCode.SharpZipLib.Checksums;
using ICSharpCode.SharpZipLib.Zip.Compression.Streams;

namespace ICSharpCode.SharpZipLib.Zip.Compression
{
	// Token: 0x02000042 RID: 66
	public class Inflater
	{
		// Token: 0x0600029A RID: 666 RVA: 0x0000E80A File Offset: 0x0000D80A
		public Inflater() : this(false)
		{
		}

		// Token: 0x0600029B RID: 667 RVA: 0x0000E813 File Offset: 0x0000D813
		public Inflater(bool noHeader)
		{
			this.noHeader = noHeader;
			this.adler = new global::ICSharpCode.SharpZipLib.Checksums.Adler32();
			this.input = new global::ICSharpCode.SharpZipLib.Zip.Compression.Streams.StreamManipulator();
			this.outputWindow = new global::ICSharpCode.SharpZipLib.Zip.Compression.Streams.OutputWindow();
			this.mode = (noHeader ? 2 : 0);
		}

		// Token: 0x0600029C RID: 668 RVA: 0x0000E850 File Offset: 0x0000D850
		public void Reset()
		{
			this.mode = (this.noHeader ? 2 : 0);
			this.totalIn = 0L;
			this.totalOut = 0L;
			this.input.Reset();
			this.outputWindow.Reset();
			this.dynHeader = null;
			this.litlenTree = null;
			this.distTree = null;
			this.isLastBlock = false;
			this.adler.Reset();
		}

		// Token: 0x0600029D RID: 669 RVA: 0x0000E8BC File Offset: 0x0000D8BC
		private bool DecodeHeader()
		{
			int num = this.input.PeekBits(16);
			if (num < 0)
			{
				return false;
			}
			this.input.DropBits(16);
			num = ((num << 8 | num >> 8) & 65535);
			if (num % 31 != 0)
			{
				throw new global::ICSharpCode.SharpZipLib.SharpZipBaseException("Header checksum illegal");
			}
			if ((num & 3840) != 2048)
			{
				throw new global::ICSharpCode.SharpZipLib.SharpZipBaseException("Compression Method unknown");
			}
			if ((num & 32) == 0)
			{
				this.mode = 2;
			}
			else
			{
				this.mode = 1;
				this.neededBits = 32;
			}
			return true;
		}

		// Token: 0x0600029E RID: 670 RVA: 0x0000E944 File Offset: 0x0000D944
		private bool DecodeDict()
		{
			while (this.neededBits > 0)
			{
				int num = this.input.PeekBits(8);
				if (num < 0)
				{
					return false;
				}
				this.input.DropBits(8);
				this.readAdler = (this.readAdler << 8 | num);
				this.neededBits -= 8;
			}
			return false;
		}

		// Token: 0x0600029F RID: 671 RVA: 0x0000E99C File Offset: 0x0000D99C
		private bool DecodeHuffman()
		{
			int i = this.outputWindow.GetFreeSpace();
			while (i >= 258)
			{
				int symbol;
				switch (this.mode)
				{
				case 7:
					while (((symbol = this.litlenTree.GetSymbol(this.input)) & -256) == 0)
					{
						this.outputWindow.Write(symbol);
						if (--i < 258)
						{
							return true;
						}
					}
					if (symbol >= 257)
					{
						try
						{
							this.repLength = global::ICSharpCode.SharpZipLib.Zip.Compression.Inflater.CPLENS[symbol - 257];
							this.neededBits = global::ICSharpCode.SharpZipLib.Zip.Compression.Inflater.CPLEXT[symbol - 257];
						}
						catch (global::System.Exception)
						{
							throw new global::ICSharpCode.SharpZipLib.SharpZipBaseException("Illegal rep length code");
						}
						goto IL_C5;
					}
					if (symbol < 0)
					{
						return false;
					}
					this.distTree = null;
					this.litlenTree = null;
					this.mode = 2;
					return true;
				case 8:
					goto IL_C5;
				case 9:
					goto IL_114;
				case 10:
					break;
				default:
					throw new global::ICSharpCode.SharpZipLib.SharpZipBaseException("Inflater unknown mode");
				}
				IL_154:
				if (this.neededBits > 0)
				{
					this.mode = 10;
					int num = this.input.PeekBits(this.neededBits);
					if (num < 0)
					{
						return false;
					}
					this.input.DropBits(this.neededBits);
					this.repDist += num;
				}
				this.outputWindow.Repeat(this.repLength, this.repDist);
				i -= this.repLength;
				this.mode = 7;
				continue;
				IL_114:
				symbol = this.distTree.GetSymbol(this.input);
				if (symbol < 0)
				{
					return false;
				}
				try
				{
					this.repDist = global::ICSharpCode.SharpZipLib.Zip.Compression.Inflater.CPDIST[symbol];
					this.neededBits = global::ICSharpCode.SharpZipLib.Zip.Compression.Inflater.CPDEXT[symbol];
				}
				catch (global::System.Exception)
				{
					throw new global::ICSharpCode.SharpZipLib.SharpZipBaseException("Illegal rep dist code");
				}
				goto IL_154;
				IL_C5:
				if (this.neededBits > 0)
				{
					this.mode = 8;
					int num2 = this.input.PeekBits(this.neededBits);
					if (num2 < 0)
					{
						return false;
					}
					this.input.DropBits(this.neededBits);
					this.repLength += num2;
				}
				this.mode = 9;
				goto IL_114;
			}
			return true;
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x0000EBA4 File Offset: 0x0000DBA4
		private bool DecodeChksum()
		{
			while (this.neededBits > 0)
			{
				int num = this.input.PeekBits(8);
				if (num < 0)
				{
					return false;
				}
				this.input.DropBits(8);
				this.readAdler = (this.readAdler << 8 | num);
				this.neededBits -= 8;
			}
			if ((int)this.adler.Value != this.readAdler)
			{
				throw new global::ICSharpCode.SharpZipLib.SharpZipBaseException(string.Concat(new object[]
				{
					"Adler chksum doesn't match: ",
					(int)this.adler.Value,
					" vs. ",
					this.readAdler
				}));
			}
			this.mode = 12;
			return false;
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x0000EC5C File Offset: 0x0000DC5C
		private bool Decode()
		{
			switch (this.mode)
			{
			case 0:
				return this.DecodeHeader();
			case 1:
				return this.DecodeDict();
			case 2:
				if (this.isLastBlock)
				{
					if (this.noHeader)
					{
						this.mode = 12;
						return false;
					}
					this.input.SkipToByteBoundary();
					this.neededBits = 32;
					this.mode = 11;
					return true;
				}
				else
				{
					int num = this.input.PeekBits(3);
					if (num < 0)
					{
						return false;
					}
					this.input.DropBits(3);
					if ((num & 1) != 0)
					{
						this.isLastBlock = true;
					}
					switch (num >> 1)
					{
					case 0:
						this.input.SkipToByteBoundary();
						this.mode = 3;
						break;
					case 1:
						this.litlenTree = global::ICSharpCode.SharpZipLib.Zip.Compression.InflaterHuffmanTree.defLitLenTree;
						this.distTree = global::ICSharpCode.SharpZipLib.Zip.Compression.InflaterHuffmanTree.defDistTree;
						this.mode = 7;
						break;
					case 2:
						this.dynHeader = new global::ICSharpCode.SharpZipLib.Zip.Compression.InflaterDynHeader();
						this.mode = 6;
						break;
					default:
						throw new global::ICSharpCode.SharpZipLib.SharpZipBaseException("Unknown block type " + num);
					}
					return true;
				}
				break;
			case 3:
				if ((this.uncomprLen = this.input.PeekBits(16)) < 0)
				{
					return false;
				}
				this.input.DropBits(16);
				this.mode = 4;
				break;
			case 4:
				break;
			case 5:
				goto IL_1A9;
			case 6:
				if (!this.dynHeader.Decode(this.input))
				{
					return false;
				}
				this.litlenTree = this.dynHeader.BuildLitLenTree();
				this.distTree = this.dynHeader.BuildDistTree();
				this.mode = 7;
				goto IL_22D;
			case 7:
			case 8:
			case 9:
			case 10:
				goto IL_22D;
			case 11:
				return this.DecodeChksum();
			case 12:
				return false;
			default:
				throw new global::ICSharpCode.SharpZipLib.SharpZipBaseException("Inflater.Decode unknown mode");
			}
			int num2 = this.input.PeekBits(16);
			if (num2 < 0)
			{
				return false;
			}
			this.input.DropBits(16);
			if (num2 != (this.uncomprLen ^ 65535))
			{
				throw new global::ICSharpCode.SharpZipLib.SharpZipBaseException("broken uncompressed block");
			}
			this.mode = 5;
			IL_1A9:
			int num3 = this.outputWindow.CopyStored(this.input, this.uncomprLen);
			this.uncomprLen -= num3;
			if (this.uncomprLen == 0)
			{
				this.mode = 2;
				return true;
			}
			return !this.input.IsNeedingInput;
			IL_22D:
			return this.DecodeHuffman();
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x0000EEA9 File Offset: 0x0000DEA9
		public void SetDictionary(byte[] buffer)
		{
			this.SetDictionary(buffer, 0, buffer.Length);
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x0000EEB8 File Offset: 0x0000DEB8
		public void SetDictionary(byte[] buffer, int index, int count)
		{
			if (buffer == null)
			{
				throw new global::System.ArgumentNullException("buffer");
			}
			if (index < 0)
			{
				throw new global::System.ArgumentOutOfRangeException("index");
			}
			if (count < 0)
			{
				throw new global::System.ArgumentOutOfRangeException("count");
			}
			if (!this.IsNeedingDictionary)
			{
				throw new global::System.InvalidOperationException("Dictionary is not needed");
			}
			this.adler.Update(buffer, index, count);
			if ((int)this.adler.Value != this.readAdler)
			{
				throw new global::ICSharpCode.SharpZipLib.SharpZipBaseException("Wrong adler checksum");
			}
			this.adler.Reset();
			this.outputWindow.CopyDict(buffer, index, count);
			this.mode = 2;
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x0000EF51 File Offset: 0x0000DF51
		public void SetInput(byte[] buffer)
		{
			this.SetInput(buffer, 0, buffer.Length);
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x0000EF5E File Offset: 0x0000DF5E
		public void SetInput(byte[] buffer, int index, int count)
		{
			this.input.SetInput(buffer, index, count);
			this.totalIn += (long)count;
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x0000EF7D File Offset: 0x0000DF7D
		public int Inflate(byte[] buffer)
		{
			if (buffer == null)
			{
				throw new global::System.ArgumentNullException("buffer");
			}
			return this.Inflate(buffer, 0, buffer.Length);
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x0000EF98 File Offset: 0x0000DF98
		public int Inflate(byte[] buffer, int offset, int count)
		{
			if (buffer == null)
			{
				throw new global::System.ArgumentNullException("buffer");
			}
			if (count < 0)
			{
				throw new global::System.ArgumentOutOfRangeException("count", "count cannot be negative");
			}
			if (offset < 0)
			{
				throw new global::System.ArgumentOutOfRangeException("offset", "offset cannot be negative");
			}
			if (offset + count > buffer.Length)
			{
				throw new global::System.ArgumentException("count exceeds buffer bounds");
			}
			if (count == 0)
			{
				if (!this.IsFinished)
				{
					this.Decode();
				}
				return 0;
			}
			int num = 0;
			for (;;)
			{
				if (this.mode != 11)
				{
					int num2 = this.outputWindow.CopyOutput(buffer, offset, count);
					if (num2 > 0)
					{
						this.adler.Update(buffer, offset, num2);
						offset += num2;
						num += num2;
						this.totalOut += (long)num2;
						count -= num2;
						if (count == 0)
						{
							break;
						}
					}
				}
				if (!this.Decode() && (this.outputWindow.GetAvailable() <= 0 || this.mode == 11))
				{
					return num;
				}
			}
			return num;
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x060002A8 RID: 680 RVA: 0x0000F072 File Offset: 0x0000E072
		public bool IsNeedingInput
		{
			get
			{
				return this.input.IsNeedingInput;
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x060002A9 RID: 681 RVA: 0x0000F07F File Offset: 0x0000E07F
		public bool IsNeedingDictionary
		{
			get
			{
				return this.mode == 1 && this.neededBits == 0;
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x060002AA RID: 682 RVA: 0x0000F095 File Offset: 0x0000E095
		public bool IsFinished
		{
			get
			{
				return this.mode == 12 && this.outputWindow.GetAvailable() == 0;
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x060002AB RID: 683 RVA: 0x0000F0B1 File Offset: 0x0000E0B1
		public int Adler
		{
			get
			{
				if (!this.IsNeedingDictionary)
				{
					return (int)this.adler.Value;
				}
				return this.readAdler;
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x060002AC RID: 684 RVA: 0x0000F0CE File Offset: 0x0000E0CE
		public long TotalOut
		{
			get
			{
				return this.totalOut;
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x060002AD RID: 685 RVA: 0x0000F0D6 File Offset: 0x0000E0D6
		public long TotalIn
		{
			get
			{
				return this.totalIn - (long)this.RemainingInput;
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x060002AE RID: 686 RVA: 0x0000F0E6 File Offset: 0x0000E0E6
		public int RemainingInput
		{
			get
			{
				return this.input.AvailableBytes;
			}
		}

		// Token: 0x04000190 RID: 400
		private const int DECODE_HEADER = 0;

		// Token: 0x04000191 RID: 401
		private const int DECODE_DICT = 1;

		// Token: 0x04000192 RID: 402
		private const int DECODE_BLOCKS = 2;

		// Token: 0x04000193 RID: 403
		private const int DECODE_STORED_LEN1 = 3;

		// Token: 0x04000194 RID: 404
		private const int DECODE_STORED_LEN2 = 4;

		// Token: 0x04000195 RID: 405
		private const int DECODE_STORED = 5;

		// Token: 0x04000196 RID: 406
		private const int DECODE_DYN_HEADER = 6;

		// Token: 0x04000197 RID: 407
		private const int DECODE_HUFFMAN = 7;

		// Token: 0x04000198 RID: 408
		private const int DECODE_HUFFMAN_LENBITS = 8;

		// Token: 0x04000199 RID: 409
		private const int DECODE_HUFFMAN_DIST = 9;

		// Token: 0x0400019A RID: 410
		private const int DECODE_HUFFMAN_DISTBITS = 10;

		// Token: 0x0400019B RID: 411
		private const int DECODE_CHKSUM = 11;

		// Token: 0x0400019C RID: 412
		private const int FINISHED = 12;

		// Token: 0x0400019D RID: 413
		private static readonly int[] CPLENS = new int[]
		{
			3,
			4,
			5,
			6,
			7,
			8,
			9,
			10,
			11,
			13,
			15,
			17,
			19,
			23,
			27,
			31,
			35,
			43,
			51,
			59,
			67,
			83,
			99,
			115,
			131,
			163,
			195,
			227,
			258
		};

		// Token: 0x0400019E RID: 414
		private static readonly int[] CPLEXT = new int[]
		{
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			1,
			1,
			1,
			1,
			2,
			2,
			2,
			2,
			3,
			3,
			3,
			3,
			4,
			4,
			4,
			4,
			5,
			5,
			5,
			5,
			0
		};

		// Token: 0x0400019F RID: 415
		private static readonly int[] CPDIST = new int[]
		{
			1,
			2,
			3,
			4,
			5,
			7,
			9,
			13,
			17,
			25,
			33,
			49,
			65,
			97,
			129,
			193,
			257,
			385,
			513,
			769,
			1025,
			1537,
			2049,
			3073,
			4097,
			6145,
			8193,
			12289,
			16385,
			24577
		};

		// Token: 0x040001A0 RID: 416
		private static readonly int[] CPDEXT = new int[]
		{
			0,
			0,
			0,
			0,
			1,
			1,
			2,
			2,
			3,
			3,
			4,
			4,
			5,
			5,
			6,
			6,
			7,
			7,
			8,
			8,
			9,
			9,
			10,
			10,
			11,
			11,
			12,
			12,
			13,
			13
		};

		// Token: 0x040001A1 RID: 417
		private int mode;

		// Token: 0x040001A2 RID: 418
		private int readAdler;

		// Token: 0x040001A3 RID: 419
		private int neededBits;

		// Token: 0x040001A4 RID: 420
		private int repLength;

		// Token: 0x040001A5 RID: 421
		private int repDist;

		// Token: 0x040001A6 RID: 422
		private int uncomprLen;

		// Token: 0x040001A7 RID: 423
		private bool isLastBlock;

		// Token: 0x040001A8 RID: 424
		private long totalOut;

		// Token: 0x040001A9 RID: 425
		private long totalIn;

		// Token: 0x040001AA RID: 426
		private bool noHeader;

		// Token: 0x040001AB RID: 427
		private global::ICSharpCode.SharpZipLib.Zip.Compression.Streams.StreamManipulator input;

		// Token: 0x040001AC RID: 428
		private global::ICSharpCode.SharpZipLib.Zip.Compression.Streams.OutputWindow outputWindow;

		// Token: 0x040001AD RID: 429
		private global::ICSharpCode.SharpZipLib.Zip.Compression.InflaterDynHeader dynHeader;

		// Token: 0x040001AE RID: 430
		private global::ICSharpCode.SharpZipLib.Zip.Compression.InflaterHuffmanTree litlenTree;

		// Token: 0x040001AF RID: 431
		private global::ICSharpCode.SharpZipLib.Zip.Compression.InflaterHuffmanTree distTree;

		// Token: 0x040001B0 RID: 432
		private global::ICSharpCode.SharpZipLib.Checksums.Adler32 adler;
	}
}
