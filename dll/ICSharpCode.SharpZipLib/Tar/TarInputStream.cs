using System;
using System.IO;
using System.Text;

namespace ICSharpCode.SharpZipLib.Tar
{
	// Token: 0x02000033 RID: 51
	public class TarInputStream : global::System.IO.Stream
	{
		// Token: 0x060001E9 RID: 489 RVA: 0x0000AB67 File Offset: 0x00009B67
		public TarInputStream(global::System.IO.Stream inputStream) : this(inputStream, 20)
		{
		}

		// Token: 0x060001EA RID: 490 RVA: 0x0000AB72 File Offset: 0x00009B72
		public TarInputStream(global::System.IO.Stream inputStream, int blockFactor)
		{
			this.inputStream = inputStream;
			this.buffer = global::ICSharpCode.SharpZipLib.Tar.TarBuffer.CreateInputTarBuffer(inputStream, blockFactor);
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x060001EB RID: 491 RVA: 0x0000AB8E File Offset: 0x00009B8E
		public override bool CanRead
		{
			get
			{
				return this.inputStream.CanRead;
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x060001EC RID: 492 RVA: 0x0000AB9B File Offset: 0x00009B9B
		public override bool CanSeek
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x060001ED RID: 493 RVA: 0x0000AB9E File Offset: 0x00009B9E
		public override bool CanWrite
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x060001EE RID: 494 RVA: 0x0000ABA1 File Offset: 0x00009BA1
		public override long Length
		{
			get
			{
				return this.inputStream.Length;
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x060001EF RID: 495 RVA: 0x0000ABAE File Offset: 0x00009BAE
		// (set) Token: 0x060001F0 RID: 496 RVA: 0x0000ABBB File Offset: 0x00009BBB
		public override long Position
		{
			get
			{
				return this.inputStream.Position;
			}
			set
			{
				throw new global::System.NotSupportedException("TarInputStream Seek not supported");
			}
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x0000ABC7 File Offset: 0x00009BC7
		public override void Flush()
		{
			this.inputStream.Flush();
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x0000ABD4 File Offset: 0x00009BD4
		public override long Seek(long offset, global::System.IO.SeekOrigin origin)
		{
			throw new global::System.NotSupportedException("TarInputStream Seek not supported");
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x0000ABE0 File Offset: 0x00009BE0
		public override void SetLength(long value)
		{
			throw new global::System.NotSupportedException("TarInputStream SetLength not supported");
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x0000ABEC File Offset: 0x00009BEC
		public override void Write(byte[] buffer, int offset, int count)
		{
			throw new global::System.NotSupportedException("TarInputStream Write not supported");
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x0000ABF8 File Offset: 0x00009BF8
		public override void WriteByte(byte value)
		{
			throw new global::System.NotSupportedException("TarInputStream WriteByte not supported");
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x0000AC04 File Offset: 0x00009C04
		public override int ReadByte()
		{
			byte[] array = new byte[1];
			int num = this.Read(array, 0, 1);
			if (num <= 0)
			{
				return -1;
			}
			return (int)array[0];
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x0000AC2C File Offset: 0x00009C2C
		public override int Read(byte[] buffer, int offset, int count)
		{
			if (buffer == null)
			{
				throw new global::System.ArgumentNullException("buffer");
			}
			int num = 0;
			if (this.entryOffset >= this.entrySize)
			{
				return 0;
			}
			long num2 = (long)count;
			if (num2 + this.entryOffset > this.entrySize)
			{
				num2 = this.entrySize - this.entryOffset;
			}
			if (this.readBuffer != null)
			{
				int num3 = (num2 > (long)this.readBuffer.Length) ? this.readBuffer.Length : ((int)num2);
				global::System.Array.Copy(this.readBuffer, 0, buffer, offset, num3);
				if (num3 >= this.readBuffer.Length)
				{
					this.readBuffer = null;
				}
				else
				{
					int num4 = this.readBuffer.Length - num3;
					byte[] destinationArray = new byte[num4];
					global::System.Array.Copy(this.readBuffer, num3, destinationArray, 0, num4);
					this.readBuffer = destinationArray;
				}
				num += num3;
				num2 -= (long)num3;
				offset += num3;
			}
			while (num2 > 0L)
			{
				byte[] array = this.buffer.ReadBlock();
				if (array == null)
				{
					throw new global::ICSharpCode.SharpZipLib.Tar.TarException("unexpected EOF with " + num2 + " bytes unread");
				}
				int num5 = (int)num2;
				int num6 = array.Length;
				if (num6 > num5)
				{
					global::System.Array.Copy(array, 0, buffer, offset, num5);
					this.readBuffer = new byte[num6 - num5];
					global::System.Array.Copy(array, num5, this.readBuffer, 0, num6 - num5);
				}
				else
				{
					num5 = num6;
					global::System.Array.Copy(array, 0, buffer, offset, num6);
				}
				num += num5;
				num2 -= (long)num5;
				offset += num5;
			}
			this.entryOffset += (long)num;
			return num;
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x0000ADA7 File Offset: 0x00009DA7
		public override void Close()
		{
			this.buffer.Close();
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x0000ADB4 File Offset: 0x00009DB4
		public void SetEntryFactory(global::ICSharpCode.SharpZipLib.Tar.TarInputStream.IEntryFactory factory)
		{
			this.entryFactory = factory;
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x060001FA RID: 506 RVA: 0x0000ADBD File Offset: 0x00009DBD
		public int RecordSize
		{
			get
			{
				return this.buffer.RecordSize;
			}
		}

		// Token: 0x060001FB RID: 507 RVA: 0x0000ADCA File Offset: 0x00009DCA
		[global::System.Obsolete("Use RecordSize property instead")]
		public int GetRecordSize()
		{
			return this.buffer.RecordSize;
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x060001FC RID: 508 RVA: 0x0000ADD7 File Offset: 0x00009DD7
		public long Available
		{
			get
			{
				return this.entrySize - this.entryOffset;
			}
		}

		// Token: 0x060001FD RID: 509 RVA: 0x0000ADE8 File Offset: 0x00009DE8
		public void Skip(long skipCount)
		{
			byte[] array = new byte[8192];
			int num2;
			for (long num = skipCount; num > 0L; num -= (long)num2)
			{
				int count = (num > (long)array.Length) ? array.Length : ((int)num);
				num2 = this.Read(array, 0, count);
				if (num2 == -1)
				{
					return;
				}
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x060001FE RID: 510 RVA: 0x0000AE2C File Offset: 0x00009E2C
		public bool IsMarkSupported
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060001FF RID: 511 RVA: 0x0000AE2F File Offset: 0x00009E2F
		public void Mark(int markLimit)
		{
		}

		// Token: 0x06000200 RID: 512 RVA: 0x0000AE31 File Offset: 0x00009E31
		public void Reset()
		{
		}

		// Token: 0x06000201 RID: 513 RVA: 0x0000AE34 File Offset: 0x00009E34
		public global::ICSharpCode.SharpZipLib.Tar.TarEntry GetNextEntry()
		{
			if (this.hasHitEOF)
			{
				return null;
			}
			if (this.currentEntry != null)
			{
				this.SkipToNextEntry();
			}
			byte[] array = this.buffer.ReadBlock();
			if (array == null)
			{
				this.hasHitEOF = true;
			}
			else if (global::ICSharpCode.SharpZipLib.Tar.TarBuffer.IsEndOfArchiveBlock(array))
			{
				this.hasHitEOF = true;
			}
			if (this.hasHitEOF)
			{
				this.currentEntry = null;
			}
			else
			{
				try
				{
					global::ICSharpCode.SharpZipLib.Tar.TarHeader tarHeader = new global::ICSharpCode.SharpZipLib.Tar.TarHeader();
					tarHeader.ParseBuffer(array);
					if (!tarHeader.IsChecksumValid)
					{
						throw new global::ICSharpCode.SharpZipLib.Tar.TarException("Header checksum is invalid");
					}
					this.entryOffset = 0L;
					this.entrySize = tarHeader.Size;
					global::System.Text.StringBuilder stringBuilder = null;
					if (tarHeader.TypeFlag == 76)
					{
						byte[] array2 = new byte[512];
						long num = this.entrySize;
						stringBuilder = new global::System.Text.StringBuilder();
						while (num > 0L)
						{
							int num2 = this.Read(array2, 0, (num > (long)array2.Length) ? array2.Length : ((int)num));
							if (num2 == -1)
							{
								throw new global::ICSharpCode.SharpZipLib.Tar.InvalidHeaderException("Failed to read long name entry");
							}
							stringBuilder.Append(global::ICSharpCode.SharpZipLib.Tar.TarHeader.ParseName(array2, 0, num2).ToString());
							num -= (long)num2;
						}
						this.SkipToNextEntry();
						array = this.buffer.ReadBlock();
					}
					else if (tarHeader.TypeFlag == 103)
					{
						this.SkipToNextEntry();
						array = this.buffer.ReadBlock();
					}
					else if (tarHeader.TypeFlag == 120)
					{
						this.SkipToNextEntry();
						array = this.buffer.ReadBlock();
					}
					else if (tarHeader.TypeFlag == 86)
					{
						this.SkipToNextEntry();
						array = this.buffer.ReadBlock();
					}
					else if (tarHeader.TypeFlag != 48 && tarHeader.TypeFlag != 0 && tarHeader.TypeFlag != 53)
					{
						this.SkipToNextEntry();
						array = this.buffer.ReadBlock();
					}
					if (this.entryFactory == null)
					{
						this.currentEntry = new global::ICSharpCode.SharpZipLib.Tar.TarEntry(array);
						if (stringBuilder != null)
						{
							this.currentEntry.Name = stringBuilder.ToString();
						}
					}
					else
					{
						this.currentEntry = this.entryFactory.CreateEntry(array);
					}
					this.entryOffset = 0L;
					this.entrySize = this.currentEntry.Size;
				}
				catch (global::ICSharpCode.SharpZipLib.Tar.InvalidHeaderException ex)
				{
					this.entrySize = 0L;
					this.entryOffset = 0L;
					this.currentEntry = null;
					string message = string.Format("Bad header in record {0} block {1} {2}", this.buffer.CurrentRecord, this.buffer.CurrentBlock, ex.Message);
					throw new global::ICSharpCode.SharpZipLib.Tar.InvalidHeaderException(message);
				}
			}
			return this.currentEntry;
		}

		// Token: 0x06000202 RID: 514 RVA: 0x0000B0A8 File Offset: 0x0000A0A8
		public void CopyEntryContents(global::System.IO.Stream outputStream)
		{
			byte[] array = new byte[32768];
			for (;;)
			{
				int num = this.Read(array, 0, array.Length);
				if (num <= 0)
				{
					break;
				}
				outputStream.Write(array, 0, num);
			}
		}

		// Token: 0x06000203 RID: 515 RVA: 0x0000B0DC File Offset: 0x0000A0DC
		private void SkipToNextEntry()
		{
			long num = this.entrySize - this.entryOffset;
			if (num > 0L)
			{
				this.Skip(num);
			}
			this.readBuffer = null;
		}

		// Token: 0x040000FF RID: 255
		protected bool hasHitEOF;

		// Token: 0x04000100 RID: 256
		protected long entrySize;

		// Token: 0x04000101 RID: 257
		protected long entryOffset;

		// Token: 0x04000102 RID: 258
		protected byte[] readBuffer;

		// Token: 0x04000103 RID: 259
		protected global::ICSharpCode.SharpZipLib.Tar.TarBuffer buffer;

		// Token: 0x04000104 RID: 260
		private global::ICSharpCode.SharpZipLib.Tar.TarEntry currentEntry;

		// Token: 0x04000105 RID: 261
		protected global::ICSharpCode.SharpZipLib.Tar.TarInputStream.IEntryFactory entryFactory;

		// Token: 0x04000106 RID: 262
		private global::System.IO.Stream inputStream;

		// Token: 0x02000034 RID: 52
		public interface IEntryFactory
		{
			// Token: 0x06000204 RID: 516
			global::ICSharpCode.SharpZipLib.Tar.TarEntry CreateEntry(string name);

			// Token: 0x06000205 RID: 517
			global::ICSharpCode.SharpZipLib.Tar.TarEntry CreateEntryFromFile(string fileName);

			// Token: 0x06000206 RID: 518
			global::ICSharpCode.SharpZipLib.Tar.TarEntry CreateEntry(byte[] headerBuffer);
		}

		// Token: 0x02000035 RID: 53
		public class EntryFactoryAdapter : global::ICSharpCode.SharpZipLib.Tar.TarInputStream.IEntryFactory
		{
			// Token: 0x06000207 RID: 519 RVA: 0x0000B10A File Offset: 0x0000A10A
			public global::ICSharpCode.SharpZipLib.Tar.TarEntry CreateEntry(string name)
			{
				return global::ICSharpCode.SharpZipLib.Tar.TarEntry.CreateTarEntry(name);
			}

			// Token: 0x06000208 RID: 520 RVA: 0x0000B112 File Offset: 0x0000A112
			public global::ICSharpCode.SharpZipLib.Tar.TarEntry CreateEntryFromFile(string fileName)
			{
				return global::ICSharpCode.SharpZipLib.Tar.TarEntry.CreateEntryFromFile(fileName);
			}

			// Token: 0x06000209 RID: 521 RVA: 0x0000B11A File Offset: 0x0000A11A
			public global::ICSharpCode.SharpZipLib.Tar.TarEntry CreateEntry(byte[] headerBuffer)
			{
				return new global::ICSharpCode.SharpZipLib.Tar.TarEntry(headerBuffer);
			}
		}
	}
}
