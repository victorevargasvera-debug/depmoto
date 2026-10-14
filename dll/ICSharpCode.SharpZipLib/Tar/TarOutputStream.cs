using System;
using System.IO;

namespace ICSharpCode.SharpZipLib.Tar
{
	// Token: 0x02000036 RID: 54
	public class TarOutputStream : global::System.IO.Stream
	{
		// Token: 0x0600020B RID: 523 RVA: 0x0000B12A File Offset: 0x0000A12A
		public TarOutputStream(global::System.IO.Stream outputStream) : this(outputStream, 20)
		{
		}

		// Token: 0x0600020C RID: 524 RVA: 0x0000B138 File Offset: 0x0000A138
		public TarOutputStream(global::System.IO.Stream outputStream, int blockFactor)
		{
			if (outputStream == null)
			{
				throw new global::System.ArgumentNullException("outputStream");
			}
			this.outputStream = outputStream;
			this.buffer = global::ICSharpCode.SharpZipLib.Tar.TarBuffer.CreateOutputTarBuffer(outputStream, blockFactor);
			this.assemblyBuffer = new byte[512];
			this.blockBuffer = new byte[512];
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x0600020D RID: 525 RVA: 0x0000B18D File Offset: 0x0000A18D
		public override bool CanRead
		{
			get
			{
				return this.outputStream.CanRead;
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x0600020E RID: 526 RVA: 0x0000B19A File Offset: 0x0000A19A
		public override bool CanSeek
		{
			get
			{
				return this.outputStream.CanSeek;
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x0600020F RID: 527 RVA: 0x0000B1A7 File Offset: 0x0000A1A7
		public override bool CanWrite
		{
			get
			{
				return this.outputStream.CanWrite;
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000210 RID: 528 RVA: 0x0000B1B4 File Offset: 0x0000A1B4
		public override long Length
		{
			get
			{
				return this.outputStream.Length;
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06000211 RID: 529 RVA: 0x0000B1C1 File Offset: 0x0000A1C1
		// (set) Token: 0x06000212 RID: 530 RVA: 0x0000B1CE File Offset: 0x0000A1CE
		public override long Position
		{
			get
			{
				return this.outputStream.Position;
			}
			set
			{
				this.outputStream.Position = value;
			}
		}

		// Token: 0x06000213 RID: 531 RVA: 0x0000B1DC File Offset: 0x0000A1DC
		public override long Seek(long offset, global::System.IO.SeekOrigin origin)
		{
			return this.outputStream.Seek(offset, origin);
		}

		// Token: 0x06000214 RID: 532 RVA: 0x0000B1EB File Offset: 0x0000A1EB
		public override void SetLength(long value)
		{
			this.outputStream.SetLength(value);
		}

		// Token: 0x06000215 RID: 533 RVA: 0x0000B1F9 File Offset: 0x0000A1F9
		public override int ReadByte()
		{
			return this.outputStream.ReadByte();
		}

		// Token: 0x06000216 RID: 534 RVA: 0x0000B206 File Offset: 0x0000A206
		public override int Read(byte[] buffer, int offset, int count)
		{
			return this.outputStream.Read(buffer, offset, count);
		}

		// Token: 0x06000217 RID: 535 RVA: 0x0000B216 File Offset: 0x0000A216
		public override void Flush()
		{
			this.outputStream.Flush();
		}

		// Token: 0x06000218 RID: 536 RVA: 0x0000B223 File Offset: 0x0000A223
		public void Finish()
		{
			if (this.IsEntryOpen)
			{
				this.CloseEntry();
			}
			this.WriteEofBlock();
		}

		// Token: 0x06000219 RID: 537 RVA: 0x0000B239 File Offset: 0x0000A239
		public override void Close()
		{
			if (!this.isClosed)
			{
				this.isClosed = true;
				this.Finish();
				this.buffer.Close();
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x0600021A RID: 538 RVA: 0x0000B25B File Offset: 0x0000A25B
		public int RecordSize
		{
			get
			{
				return this.buffer.RecordSize;
			}
		}

		// Token: 0x0600021B RID: 539 RVA: 0x0000B268 File Offset: 0x0000A268
		[global::System.Obsolete("Use RecordSize property instead")]
		public int GetRecordSize()
		{
			return this.buffer.RecordSize;
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x0600021C RID: 540 RVA: 0x0000B275 File Offset: 0x0000A275
		private bool IsEntryOpen
		{
			get
			{
				return this.currBytes < this.currSize;
			}
		}

		// Token: 0x0600021D RID: 541 RVA: 0x0000B288 File Offset: 0x0000A288
		public void PutNextEntry(global::ICSharpCode.SharpZipLib.Tar.TarEntry entry)
		{
			if (entry == null)
			{
				throw new global::System.ArgumentNullException("entry");
			}
			if (entry.TarHeader.Name.Length >= 100)
			{
				global::ICSharpCode.SharpZipLib.Tar.TarHeader tarHeader = new global::ICSharpCode.SharpZipLib.Tar.TarHeader();
				tarHeader.TypeFlag = 76;
				tarHeader.Name += "././@LongLink";
				tarHeader.UserId = 0;
				tarHeader.GroupId = 0;
				tarHeader.GroupName = "";
				tarHeader.UserName = "";
				tarHeader.LinkName = "";
				tarHeader.Size = (long)entry.TarHeader.Name.Length;
				tarHeader.WriteHeader(this.blockBuffer);
				this.buffer.WriteBlock(this.blockBuffer);
				int i = 0;
				while (i < entry.TarHeader.Name.Length)
				{
					global::System.Array.Clear(this.blockBuffer, 0, this.blockBuffer.Length);
					global::ICSharpCode.SharpZipLib.Tar.TarHeader.GetAsciiBytes(entry.TarHeader.Name, i, this.blockBuffer, 0, 512);
					i += 512;
					this.buffer.WriteBlock(this.blockBuffer);
				}
			}
			entry.WriteEntryHeader(this.blockBuffer);
			this.buffer.WriteBlock(this.blockBuffer);
			this.currBytes = 0L;
			this.currSize = (entry.IsDirectory ? 0L : entry.Size);
		}

		// Token: 0x0600021E RID: 542 RVA: 0x0000B3E0 File Offset: 0x0000A3E0
		public void CloseEntry()
		{
			if (this.assemblyBufferLength > 0)
			{
				global::System.Array.Clear(this.assemblyBuffer, this.assemblyBufferLength, this.assemblyBuffer.Length - this.assemblyBufferLength);
				this.buffer.WriteBlock(this.assemblyBuffer);
				this.currBytes += (long)this.assemblyBufferLength;
				this.assemblyBufferLength = 0;
			}
			if (this.currBytes < this.currSize)
			{
				string message = string.Format("Entry closed at '{0}' before the '{1}' bytes specified in the header were written", this.currBytes, this.currSize);
				throw new global::ICSharpCode.SharpZipLib.Tar.TarException(message);
			}
		}

		// Token: 0x0600021F RID: 543 RVA: 0x0000B478 File Offset: 0x0000A478
		public override void WriteByte(byte value)
		{
			this.Write(new byte[]
			{
				value
			}, 0, 1);
		}

		// Token: 0x06000220 RID: 544 RVA: 0x0000B49C File Offset: 0x0000A49C
		public override void Write(byte[] buffer, int offset, int count)
		{
			if (buffer == null)
			{
				throw new global::System.ArgumentNullException("buffer");
			}
			if (offset < 0)
			{
				throw new global::System.ArgumentOutOfRangeException("offset", "Cannot be negative");
			}
			if (buffer.Length - offset < count)
			{
				throw new global::System.ArgumentException("offset and count combination is invalid");
			}
			if (count < 0)
			{
				throw new global::System.ArgumentOutOfRangeException("count", "Cannot be negative");
			}
			if (this.currBytes + (long)count > this.currSize)
			{
				string message = string.Format("request to write '{0}' bytes exceeds size in header of '{1}' bytes", count, this.currSize);
				throw new global::System.ArgumentOutOfRangeException("count", message);
			}
			if (this.assemblyBufferLength > 0)
			{
				if (this.assemblyBufferLength + count >= this.blockBuffer.Length)
				{
					int num = this.blockBuffer.Length - this.assemblyBufferLength;
					global::System.Array.Copy(this.assemblyBuffer, 0, this.blockBuffer, 0, this.assemblyBufferLength);
					global::System.Array.Copy(buffer, offset, this.blockBuffer, this.assemblyBufferLength, num);
					this.buffer.WriteBlock(this.blockBuffer);
					this.currBytes += (long)this.blockBuffer.Length;
					offset += num;
					count -= num;
					this.assemblyBufferLength = 0;
				}
				else
				{
					global::System.Array.Copy(buffer, offset, this.assemblyBuffer, this.assemblyBufferLength, count);
					offset += count;
					this.assemblyBufferLength += count;
					count -= count;
				}
			}
			while (count > 0)
			{
				if (count < this.blockBuffer.Length)
				{
					global::System.Array.Copy(buffer, offset, this.assemblyBuffer, this.assemblyBufferLength, count);
					this.assemblyBufferLength += count;
					return;
				}
				this.buffer.WriteBlock(buffer, offset);
				int num2 = this.blockBuffer.Length;
				this.currBytes += (long)num2;
				count -= num2;
				offset += num2;
			}
		}

		// Token: 0x06000221 RID: 545 RVA: 0x0000B652 File Offset: 0x0000A652
		private void WriteEofBlock()
		{
			global::System.Array.Clear(this.blockBuffer, 0, this.blockBuffer.Length);
			this.buffer.WriteBlock(this.blockBuffer);
		}

		// Token: 0x04000107 RID: 263
		private long currBytes;

		// Token: 0x04000108 RID: 264
		private int assemblyBufferLength;

		// Token: 0x04000109 RID: 265
		private bool isClosed;

		// Token: 0x0400010A RID: 266
		protected long currSize;

		// Token: 0x0400010B RID: 267
		protected byte[] blockBuffer;

		// Token: 0x0400010C RID: 268
		protected byte[] assemblyBuffer;

		// Token: 0x0400010D RID: 269
		protected global::ICSharpCode.SharpZipLib.Tar.TarBuffer buffer;

		// Token: 0x0400010E RID: 270
		protected global::System.IO.Stream outputStream;
	}
}
