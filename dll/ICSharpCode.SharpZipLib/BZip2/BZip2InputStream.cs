using System;
using System.IO;
using ICSharpCode.SharpZipLib.Checksums;

namespace ICSharpCode.SharpZipLib.BZip2
{
	// Token: 0x02000006 RID: 6
	public class BZip2InputStream : global::System.IO.Stream
	{
		// Token: 0x0600000E RID: 14 RVA: 0x00002A50 File Offset: 0x00001A50
		public BZip2InputStream(global::System.IO.Stream stream)
		{
			for (int i = 0; i < 6; i++)
			{
				this.limit[i] = new int[258];
				this.baseArray[i] = new int[258];
				this.perm[i] = new int[258];
			}
			this.BsSetStream(stream);
			this.Initialize();
			this.InitBlock();
			this.SetupBlock();
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600000F RID: 15 RVA: 0x00002B6E File Offset: 0x00001B6E
		// (set) Token: 0x06000010 RID: 16 RVA: 0x00002B76 File Offset: 0x00001B76
		public bool IsStreamOwner
		{
			get
			{
				return this.isStreamOwner;
			}
			set
			{
				this.isStreamOwner = value;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000011 RID: 17 RVA: 0x00002B7F File Offset: 0x00001B7F
		public override bool CanRead
		{
			get
			{
				return this.baseStream.CanRead;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000012 RID: 18 RVA: 0x00002B8C File Offset: 0x00001B8C
		public override bool CanSeek
		{
			get
			{
				return this.baseStream.CanSeek;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000013 RID: 19 RVA: 0x00002B99 File Offset: 0x00001B99
		public override bool CanWrite
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000014 RID: 20 RVA: 0x00002B9C File Offset: 0x00001B9C
		public override long Length
		{
			get
			{
				return this.baseStream.Length;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000015 RID: 21 RVA: 0x00002BA9 File Offset: 0x00001BA9
		// (set) Token: 0x06000016 RID: 22 RVA: 0x00002BB6 File Offset: 0x00001BB6
		public override long Position
		{
			get
			{
				return this.baseStream.Position;
			}
			set
			{
				throw new global::System.NotSupportedException("BZip2InputStream position cannot be set");
			}
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002BC2 File Offset: 0x00001BC2
		public override void Flush()
		{
			if (this.baseStream != null)
			{
				this.baseStream.Flush();
			}
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002BD7 File Offset: 0x00001BD7
		public override long Seek(long offset, global::System.IO.SeekOrigin origin)
		{
			throw new global::System.NotSupportedException("BZip2InputStream Seek not supported");
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002BE3 File Offset: 0x00001BE3
		public override void SetLength(long value)
		{
			throw new global::System.NotSupportedException("BZip2InputStream SetLength not supported");
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002BEF File Offset: 0x00001BEF
		public override void Write(byte[] buffer, int offset, int count)
		{
			throw new global::System.NotSupportedException("BZip2InputStream Write not supported");
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002BFB File Offset: 0x00001BFB
		public override void WriteByte(byte value)
		{
			throw new global::System.NotSupportedException("BZip2InputStream WriteByte not supported");
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002C08 File Offset: 0x00001C08
		public override int Read(byte[] buffer, int offset, int count)
		{
			if (buffer == null)
			{
				throw new global::System.ArgumentNullException("buffer");
			}
			for (int i = 0; i < count; i++)
			{
				int num = this.ReadByte();
				if (num == -1)
				{
					return i;
				}
				buffer[offset + i] = (byte)num;
			}
			return count;
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002C44 File Offset: 0x00001C44
		public override void Close()
		{
			if (this.IsStreamOwner && this.baseStream != null)
			{
				this.baseStream.Close();
			}
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002C64 File Offset: 0x00001C64
		public override int ReadByte()
		{
			if (this.streamEnd)
			{
				return -1;
			}
			int result = this.currentChar;
			switch (this.currentState)
			{
			case 3:
				this.SetupRandPartB();
				break;
			case 4:
				this.SetupRandPartC();
				break;
			case 6:
				this.SetupNoRandPartB();
				break;
			case 7:
				this.SetupNoRandPartC();
				break;
			}
			return result;
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002CD0 File Offset: 0x00001CD0
		private void MakeMaps()
		{
			this.nInUse = 0;
			for (int i = 0; i < 256; i++)
			{
				if (this.inUse[i])
				{
					this.seqToUnseq[this.nInUse] = (byte)i;
					this.unseqToSeq[i] = (byte)this.nInUse;
					this.nInUse++;
				}
			}
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002D2C File Offset: 0x00001D2C
		private void Initialize()
		{
			char c = this.BsGetUChar();
			char c2 = this.BsGetUChar();
			char c3 = this.BsGetUChar();
			char c4 = this.BsGetUChar();
			if (c != 'B' || c2 != 'Z' || c3 != 'h' || c4 < '1' || c4 > '9')
			{
				this.streamEnd = true;
				return;
			}
			this.SetDecompressStructureSizes((int)(c4 - '0'));
			this.computedCombinedCRC = 0U;
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002D88 File Offset: 0x00001D88
		private void InitBlock()
		{
			char c = this.BsGetUChar();
			char c2 = this.BsGetUChar();
			char c3 = this.BsGetUChar();
			char c4 = this.BsGetUChar();
			char c5 = this.BsGetUChar();
			char c6 = this.BsGetUChar();
			if (c == '\u0017' && c2 == 'r' && c3 == 'E' && c4 == '8' && c5 == 'P' && c6 == '\u0090')
			{
				this.Complete();
				return;
			}
			if (c != '1' || c2 != 'A' || c3 != 'Y' || c4 != '&' || c5 != 'S' || c6 != 'Y')
			{
				global::ICSharpCode.SharpZipLib.BZip2.BZip2InputStream.BadBlockHeader();
				this.streamEnd = true;
				return;
			}
			this.storedBlockCRC = this.BsGetInt32();
			this.blockRandomised = (this.BsR(1) == 1);
			this.GetAndMoveToFrontDecode();
			this.mCrc.Reset();
			this.currentState = 1;
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002E4C File Offset: 0x00001E4C
		private void EndBlock()
		{
			this.computedBlockCRC = (int)this.mCrc.Value;
			if (this.storedBlockCRC != this.computedBlockCRC)
			{
				global::ICSharpCode.SharpZipLib.BZip2.BZip2InputStream.CrcError();
			}
			this.computedCombinedCRC = ((this.computedCombinedCRC << 1 & uint.MaxValue) | this.computedCombinedCRC >> 31);
			this.computedCombinedCRC ^= (uint)this.computedBlockCRC;
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002EAB File Offset: 0x00001EAB
		private void Complete()
		{
			this.storedCombinedCRC = this.BsGetInt32();
			if (this.storedCombinedCRC != (int)this.computedCombinedCRC)
			{
				global::ICSharpCode.SharpZipLib.BZip2.BZip2InputStream.CrcError();
			}
			this.streamEnd = true;
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002ED3 File Offset: 0x00001ED3
		private void BsSetStream(global::System.IO.Stream stream)
		{
			this.baseStream = stream;
			this.bsLive = 0;
			this.bsBuff = 0;
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002EEC File Offset: 0x00001EEC
		private void FillBuffer()
		{
			int num = 0;
			try
			{
				num = this.baseStream.ReadByte();
			}
			catch (global::System.Exception)
			{
				global::ICSharpCode.SharpZipLib.BZip2.BZip2InputStream.CompressedStreamEOF();
			}
			if (num == -1)
			{
				global::ICSharpCode.SharpZipLib.BZip2.BZip2InputStream.CompressedStreamEOF();
			}
			this.bsBuff = (this.bsBuff << 8 | (num & 255));
			this.bsLive += 8;
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002F50 File Offset: 0x00001F50
		private int BsR(int n)
		{
			while (this.bsLive < n)
			{
				this.FillBuffer();
			}
			int result = this.bsBuff >> this.bsLive - n & (1 << n) - 1;
			this.bsLive -= n;
			return result;
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002F99 File Offset: 0x00001F99
		private char BsGetUChar()
		{
			return (char)this.BsR(8);
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002FA3 File Offset: 0x00001FA3
		private int BsGetIntVS(int numBits)
		{
			return this.BsR(numBits);
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002FAC File Offset: 0x00001FAC
		private int BsGetInt32()
		{
			int num = this.BsR(8);
			num = (num << 8 | this.BsR(8));
			num = (num << 8 | this.BsR(8));
			return num << 8 | this.BsR(8);
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002FE8 File Offset: 0x00001FE8
		private void RecvDecodingTables()
		{
			char[][] array = new char[6][];
			for (int i = 0; i < 6; i++)
			{
				array[i] = new char[258];
			}
			bool[] array2 = new bool[16];
			for (int j = 0; j < 16; j++)
			{
				array2[j] = (this.BsR(1) == 1);
			}
			for (int k = 0; k < 16; k++)
			{
				if (array2[k])
				{
					for (int l = 0; l < 16; l++)
					{
						this.inUse[k * 16 + l] = (this.BsR(1) == 1);
					}
				}
				else
				{
					for (int m = 0; m < 16; m++)
					{
						this.inUse[k * 16 + m] = false;
					}
				}
			}
			this.MakeMaps();
			int num = this.nInUse + 2;
			int num2 = this.BsR(3);
			int num3 = this.BsR(15);
			for (int n = 0; n < num3; n++)
			{
				int num4 = 0;
				while (this.BsR(1) == 1)
				{
					num4++;
				}
				this.selectorMtf[n] = (byte)num4;
			}
			byte[] array3 = new byte[6];
			for (int num5 = 0; num5 < num2; num5++)
			{
				array3[num5] = (byte)num5;
			}
			for (int num6 = 0; num6 < num3; num6++)
			{
				int num7 = (int)this.selectorMtf[num6];
				byte b = array3[num7];
				while (num7 > 0)
				{
					array3[num7] = array3[num7 - 1];
					num7--;
				}
				array3[0] = b;
				this.selector[num6] = b;
			}
			for (int num8 = 0; num8 < num2; num8++)
			{
				int num9 = this.BsR(5);
				for (int num10 = 0; num10 < num; num10++)
				{
					while (this.BsR(1) == 1)
					{
						if (this.BsR(1) == 0)
						{
							num9++;
						}
						else
						{
							num9--;
						}
					}
					array[num8][num10] = (char)num9;
				}
			}
			for (int num11 = 0; num11 < num2; num11++)
			{
				int num12 = 32;
				int num13 = 0;
				for (int num14 = 0; num14 < num; num14++)
				{
					num13 = global::System.Math.Max(num13, (int)array[num11][num14]);
					num12 = global::System.Math.Min(num12, (int)array[num11][num14]);
				}
				global::ICSharpCode.SharpZipLib.BZip2.BZip2InputStream.HbCreateDecodeTables(this.limit[num11], this.baseArray[num11], this.perm[num11], array[num11], num12, num13, num);
				this.minLens[num11] = num12;
			}
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00003234 File Offset: 0x00002234
		private void GetAndMoveToFrontDecode()
		{
			byte[] array = new byte[256];
			int num = 100000 * this.blockSize100k;
			this.origPtr = this.BsGetIntVS(24);
			this.RecvDecodingTables();
			int num2 = this.nInUse + 1;
			int num3 = -1;
			int num4 = 0;
			for (int i = 0; i <= 255; i++)
			{
				this.unzftab[i] = 0;
			}
			for (int j = 0; j <= 255; j++)
			{
				array[j] = (byte)j;
			}
			this.last = -1;
			if (num4 == 0)
			{
				num3++;
				num4 = 50;
			}
			num4--;
			int num5 = (int)this.selector[num3];
			int num6 = this.minLens[num5];
			int k;
			int num7;
			for (k = this.BsR(num6); k > this.limit[num5][num6]; k = (k << 1 | num7))
			{
				if (num6 > 20)
				{
					throw new global::ICSharpCode.SharpZipLib.BZip2.BZip2Exception("Bzip data error");
				}
				num6++;
				while (this.bsLive < 1)
				{
					this.FillBuffer();
				}
				num7 = (this.bsBuff >> this.bsLive - 1 & 1);
				this.bsLive--;
			}
			if (k - this.baseArray[num5][num6] < 0 || k - this.baseArray[num5][num6] >= 258)
			{
				throw new global::ICSharpCode.SharpZipLib.BZip2.BZip2Exception("Bzip data error");
			}
			int num8 = this.perm[num5][k - this.baseArray[num5][num6]];
			while (num8 != num2)
			{
				if (num8 == 0 || num8 == 1)
				{
					int l = -1;
					int num9 = 1;
					do
					{
						if (num8 == 0)
						{
							l += num9;
						}
						else if (num8 == 1)
						{
							l += 2 * num9;
						}
						num9 <<= 1;
						if (num4 == 0)
						{
							num3++;
							num4 = 50;
						}
						num4--;
						num5 = (int)this.selector[num3];
						num6 = this.minLens[num5];
						for (k = this.BsR(num6); k > this.limit[num5][num6]; k = (k << 1 | num7))
						{
							num6++;
							while (this.bsLive < 1)
							{
								this.FillBuffer();
							}
							num7 = (this.bsBuff >> this.bsLive - 1 & 1);
							this.bsLive--;
						}
						num8 = this.perm[num5][k - this.baseArray[num5][num6]];
					}
					while (num8 == 0 || num8 == 1);
					l++;
					byte b = this.seqToUnseq[(int)array[0]];
					this.unzftab[(int)b] += l;
					while (l > 0)
					{
						this.last++;
						this.ll8[this.last] = b;
						l--;
					}
					if (this.last >= num)
					{
						global::ICSharpCode.SharpZipLib.BZip2.BZip2InputStream.BlockOverrun();
					}
				}
				else
				{
					this.last++;
					if (this.last >= num)
					{
						global::ICSharpCode.SharpZipLib.BZip2.BZip2InputStream.BlockOverrun();
					}
					byte b2 = array[num8 - 1];
					this.unzftab[(int)this.seqToUnseq[(int)b2]]++;
					this.ll8[this.last] = this.seqToUnseq[(int)b2];
					for (int m = num8 - 1; m > 0; m--)
					{
						array[m] = array[m - 1];
					}
					array[0] = b2;
					if (num4 == 0)
					{
						num3++;
						num4 = 50;
					}
					num4--;
					num5 = (int)this.selector[num3];
					num6 = this.minLens[num5];
					for (k = this.BsR(num6); k > this.limit[num5][num6]; k = (k << 1 | num7))
					{
						num6++;
						while (this.bsLive < 1)
						{
							this.FillBuffer();
						}
						num7 = (this.bsBuff >> this.bsLive - 1 & 1);
						this.bsLive--;
					}
					num8 = this.perm[num5][k - this.baseArray[num5][num6]];
				}
			}
		}

		// Token: 0x0600002C RID: 44 RVA: 0x0000361C File Offset: 0x0000261C
		private void SetupBlock()
		{
			int[] array = new int[257];
			array[0] = 0;
			global::System.Array.Copy(this.unzftab, 0, array, 1, 256);
			for (int i = 1; i <= 256; i++)
			{
				array[i] += array[i - 1];
			}
			for (int j = 0; j <= this.last; j++)
			{
				byte b = this.ll8[j];
				this.tt[array[(int)b]] = j;
				array[(int)b]++;
			}
			this.tPos = this.tt[this.origPtr];
			this.count = 0;
			this.i2 = 0;
			this.ch2 = 256;
			if (this.blockRandomised)
			{
				this.rNToGo = 0;
				this.rTPos = 0;
				this.SetupRandPartA();
				return;
			}
			this.SetupNoRandPartA();
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00003700 File Offset: 0x00002700
		private void SetupRandPartA()
		{
			if (this.i2 <= this.last)
			{
				this.chPrev = this.ch2;
				this.ch2 = (int)this.ll8[this.tPos];
				this.tPos = this.tt[this.tPos];
				if (this.rNToGo == 0)
				{
					this.rNToGo = global::ICSharpCode.SharpZipLib.BZip2.BZip2Constants.RandomNumbers[this.rTPos];
					this.rTPos++;
					if (this.rTPos == 512)
					{
						this.rTPos = 0;
					}
				}
				this.rNToGo--;
				this.ch2 ^= ((this.rNToGo == 1) ? 1 : 0);
				this.i2++;
				this.currentChar = this.ch2;
				this.currentState = 3;
				this.mCrc.Update(this.ch2);
				return;
			}
			this.EndBlock();
			this.InitBlock();
			this.SetupBlock();
		}

		// Token: 0x0600002E RID: 46 RVA: 0x000037FC File Offset: 0x000027FC
		private void SetupNoRandPartA()
		{
			if (this.i2 <= this.last)
			{
				this.chPrev = this.ch2;
				this.ch2 = (int)this.ll8[this.tPos];
				this.tPos = this.tt[this.tPos];
				this.i2++;
				this.currentChar = this.ch2;
				this.currentState = 6;
				this.mCrc.Update(this.ch2);
				return;
			}
			this.EndBlock();
			this.InitBlock();
			this.SetupBlock();
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00003890 File Offset: 0x00002890
		private void SetupRandPartB()
		{
			if (this.ch2 != this.chPrev)
			{
				this.currentState = 2;
				this.count = 1;
				this.SetupRandPartA();
				return;
			}
			this.count++;
			if (this.count >= 4)
			{
				this.z = this.ll8[this.tPos];
				this.tPos = this.tt[this.tPos];
				if (this.rNToGo == 0)
				{
					this.rNToGo = global::ICSharpCode.SharpZipLib.BZip2.BZip2Constants.RandomNumbers[this.rTPos];
					this.rTPos++;
					if (this.rTPos == 512)
					{
						this.rTPos = 0;
					}
				}
				this.rNToGo--;
				this.z ^= ((this.rNToGo == 1) ? 1 : 0);
				this.j2 = 0;
				this.currentState = 4;
				this.SetupRandPartC();
				return;
			}
			this.currentState = 2;
			this.SetupRandPartA();
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00003988 File Offset: 0x00002988
		private void SetupRandPartC()
		{
			if (this.j2 < (int)this.z)
			{
				this.currentChar = this.ch2;
				this.mCrc.Update(this.ch2);
				this.j2++;
				return;
			}
			this.currentState = 2;
			this.i2++;
			this.count = 0;
			this.SetupRandPartA();
		}

		// Token: 0x06000031 RID: 49 RVA: 0x000039F4 File Offset: 0x000029F4
		private void SetupNoRandPartB()
		{
			if (this.ch2 != this.chPrev)
			{
				this.currentState = 5;
				this.count = 1;
				this.SetupNoRandPartA();
				return;
			}
			this.count++;
			if (this.count >= 4)
			{
				this.z = this.ll8[this.tPos];
				this.tPos = this.tt[this.tPos];
				this.currentState = 7;
				this.j2 = 0;
				this.SetupNoRandPartC();
				return;
			}
			this.currentState = 5;
			this.SetupNoRandPartA();
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00003A84 File Offset: 0x00002A84
		private void SetupNoRandPartC()
		{
			if (this.j2 < (int)this.z)
			{
				this.currentChar = this.ch2;
				this.mCrc.Update(this.ch2);
				this.j2++;
				return;
			}
			this.currentState = 5;
			this.i2++;
			this.count = 0;
			this.SetupNoRandPartA();
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00003AF0 File Offset: 0x00002AF0
		private void SetDecompressStructureSizes(int newSize100k)
		{
			if (0 > newSize100k || newSize100k > 9 || 0 > this.blockSize100k || this.blockSize100k > 9)
			{
				throw new global::ICSharpCode.SharpZipLib.BZip2.BZip2Exception("Invalid block size");
			}
			this.blockSize100k = newSize100k;
			if (newSize100k == 0)
			{
				return;
			}
			int num = 100000 * newSize100k;
			this.ll8 = new byte[num];
			this.tt = new int[num];
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00003B4F File Offset: 0x00002B4F
		private static void CompressedStreamEOF()
		{
			throw new global::System.IO.EndOfStreamException("BZip2 input stream end of compressed stream");
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00003B5B File Offset: 0x00002B5B
		private static void BlockOverrun()
		{
			throw new global::ICSharpCode.SharpZipLib.BZip2.BZip2Exception("BZip2 input stream block overrun");
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00003B67 File Offset: 0x00002B67
		private static void BadBlockHeader()
		{
			throw new global::ICSharpCode.SharpZipLib.BZip2.BZip2Exception("BZip2 input stream bad block header");
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00003B73 File Offset: 0x00002B73
		private static void CrcError()
		{
			throw new global::ICSharpCode.SharpZipLib.BZip2.BZip2Exception("BZip2 input stream crc error");
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00003B80 File Offset: 0x00002B80
		private static void HbCreateDecodeTables(int[] limit, int[] baseArray, int[] perm, char[] length, int minLen, int maxLen, int alphaSize)
		{
			int num = 0;
			for (int i = minLen; i <= maxLen; i++)
			{
				for (int j = 0; j < alphaSize; j++)
				{
					if ((int)length[j] == i)
					{
						perm[num] = j;
						num++;
					}
				}
			}
			for (int k = 0; k < 23; k++)
			{
				baseArray[k] = 0;
			}
			for (int l = 0; l < alphaSize; l++)
			{
				baseArray[(int)(length[l] + '\u0001')]++;
			}
			for (int m = 1; m < 23; m++)
			{
				baseArray[m] += baseArray[m - 1];
			}
			for (int n = 0; n < 23; n++)
			{
				limit[n] = 0;
			}
			int num2 = 0;
			for (int num3 = minLen; num3 <= maxLen; num3++)
			{
				num2 += baseArray[num3 + 1] - baseArray[num3];
				limit[num3] = num2 - 1;
				num2 <<= 1;
			}
			for (int num4 = minLen + 1; num4 <= maxLen; num4++)
			{
				baseArray[num4] = (limit[num4 - 1] + 1 << 1) - baseArray[num4];
			}
		}

		// Token: 0x0400000C RID: 12
		private const int START_BLOCK_STATE = 1;

		// Token: 0x0400000D RID: 13
		private const int RAND_PART_A_STATE = 2;

		// Token: 0x0400000E RID: 14
		private const int RAND_PART_B_STATE = 3;

		// Token: 0x0400000F RID: 15
		private const int RAND_PART_C_STATE = 4;

		// Token: 0x04000010 RID: 16
		private const int NO_RAND_PART_A_STATE = 5;

		// Token: 0x04000011 RID: 17
		private const int NO_RAND_PART_B_STATE = 6;

		// Token: 0x04000012 RID: 18
		private const int NO_RAND_PART_C_STATE = 7;

		// Token: 0x04000013 RID: 19
		private int last;

		// Token: 0x04000014 RID: 20
		private int origPtr;

		// Token: 0x04000015 RID: 21
		private int blockSize100k;

		// Token: 0x04000016 RID: 22
		private bool blockRandomised;

		// Token: 0x04000017 RID: 23
		private int bsBuff;

		// Token: 0x04000018 RID: 24
		private int bsLive;

		// Token: 0x04000019 RID: 25
		private global::ICSharpCode.SharpZipLib.Checksums.IChecksum mCrc = new global::ICSharpCode.SharpZipLib.Checksums.StrangeCRC();

		// Token: 0x0400001A RID: 26
		private bool[] inUse = new bool[256];

		// Token: 0x0400001B RID: 27
		private int nInUse;

		// Token: 0x0400001C RID: 28
		private byte[] seqToUnseq = new byte[256];

		// Token: 0x0400001D RID: 29
		private byte[] unseqToSeq = new byte[256];

		// Token: 0x0400001E RID: 30
		private byte[] selector = new byte[18002];

		// Token: 0x0400001F RID: 31
		private byte[] selectorMtf = new byte[18002];

		// Token: 0x04000020 RID: 32
		private int[] tt;

		// Token: 0x04000021 RID: 33
		private byte[] ll8;

		// Token: 0x04000022 RID: 34
		private int[] unzftab = new int[256];

		// Token: 0x04000023 RID: 35
		private int[][] limit = new int[6][];

		// Token: 0x04000024 RID: 36
		private int[][] baseArray = new int[6][];

		// Token: 0x04000025 RID: 37
		private int[][] perm = new int[6][];

		// Token: 0x04000026 RID: 38
		private int[] minLens = new int[6];

		// Token: 0x04000027 RID: 39
		private global::System.IO.Stream baseStream;

		// Token: 0x04000028 RID: 40
		private bool streamEnd;

		// Token: 0x04000029 RID: 41
		private int currentChar = -1;

		// Token: 0x0400002A RID: 42
		private int currentState = 1;

		// Token: 0x0400002B RID: 43
		private int storedBlockCRC;

		// Token: 0x0400002C RID: 44
		private int storedCombinedCRC;

		// Token: 0x0400002D RID: 45
		private int computedBlockCRC;

		// Token: 0x0400002E RID: 46
		private uint computedCombinedCRC;

		// Token: 0x0400002F RID: 47
		private int count;

		// Token: 0x04000030 RID: 48
		private int chPrev;

		// Token: 0x04000031 RID: 49
		private int ch2;

		// Token: 0x04000032 RID: 50
		private int tPos;

		// Token: 0x04000033 RID: 51
		private int rNToGo;

		// Token: 0x04000034 RID: 52
		private int rTPos;

		// Token: 0x04000035 RID: 53
		private int i2;

		// Token: 0x04000036 RID: 54
		private int j2;

		// Token: 0x04000037 RID: 55
		private byte z;

		// Token: 0x04000038 RID: 56
		private bool isStreamOwner = true;
	}
}
