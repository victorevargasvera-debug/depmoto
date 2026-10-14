using System;

namespace ICSharpCode.SharpZipLib.Zip.Compression
{
	// Token: 0x02000040 RID: 64
	public class PendingBuffer
	{
		// Token: 0x0600028B RID: 651 RVA: 0x0000E441 File Offset: 0x0000D441
		public PendingBuffer() : this(4096)
		{
		}

		// Token: 0x0600028C RID: 652 RVA: 0x0000E44E File Offset: 0x0000D44E
		public PendingBuffer(int bufferSize)
		{
			this.buffer_ = new byte[bufferSize];
		}

		// Token: 0x0600028D RID: 653 RVA: 0x0000E464 File Offset: 0x0000D464
		public void Reset()
		{
			this.start = (this.end = (this.bitCount = 0));
		}

		// Token: 0x0600028E RID: 654 RVA: 0x0000E48C File Offset: 0x0000D48C
		public void WriteByte(int value)
		{
			this.buffer_[this.end++] = (byte)value;
		}

		// Token: 0x0600028F RID: 655 RVA: 0x0000E4B4 File Offset: 0x0000D4B4
		public void WriteShort(int value)
		{
			this.buffer_[this.end++] = (byte)value;
			this.buffer_[this.end++] = (byte)(value >> 8);
		}

		// Token: 0x06000290 RID: 656 RVA: 0x0000E4F8 File Offset: 0x0000D4F8
		public void WriteInt(int value)
		{
			this.buffer_[this.end++] = (byte)value;
			this.buffer_[this.end++] = (byte)(value >> 8);
			this.buffer_[this.end++] = (byte)(value >> 16);
			this.buffer_[this.end++] = (byte)(value >> 24);
		}

		// Token: 0x06000291 RID: 657 RVA: 0x0000E575 File Offset: 0x0000D575
		public void WriteBlock(byte[] block, int offset, int length)
		{
			global::System.Array.Copy(block, offset, this.buffer_, this.end, length);
			this.end += length;
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000292 RID: 658 RVA: 0x0000E599 File Offset: 0x0000D599
		public int BitCount
		{
			get
			{
				return this.bitCount;
			}
		}

		// Token: 0x06000293 RID: 659 RVA: 0x0000E5A4 File Offset: 0x0000D5A4
		public void AlignToByte()
		{
			if (this.bitCount > 0)
			{
				this.buffer_[this.end++] = (byte)this.bits;
				if (this.bitCount > 8)
				{
					this.buffer_[this.end++] = (byte)(this.bits >> 8);
				}
			}
			this.bits = 0U;
			this.bitCount = 0;
		}

		// Token: 0x06000294 RID: 660 RVA: 0x0000E614 File Offset: 0x0000D614
		public void WriteBits(int b, int count)
		{
			this.bits |= (uint)((uint)b << this.bitCount);
			this.bitCount += count;
			if (this.bitCount >= 16)
			{
				this.buffer_[this.end++] = (byte)this.bits;
				this.buffer_[this.end++] = (byte)(this.bits >> 8);
				this.bits >>= 16;
				this.bitCount -= 16;
			}
		}

		// Token: 0x06000295 RID: 661 RVA: 0x0000E6B0 File Offset: 0x0000D6B0
		public void WriteShortMSB(int s)
		{
			this.buffer_[this.end++] = (byte)(s >> 8);
			this.buffer_[this.end++] = (byte)s;
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000296 RID: 662 RVA: 0x0000E6F3 File Offset: 0x0000D6F3
		public bool IsFlushed
		{
			get
			{
				return this.end == 0;
			}
		}

		// Token: 0x06000297 RID: 663 RVA: 0x0000E700 File Offset: 0x0000D700
		public int Flush(byte[] output, int offset, int length)
		{
			if (this.bitCount >= 8)
			{
				this.buffer_[this.end++] = (byte)this.bits;
				this.bits >>= 8;
				this.bitCount -= 8;
			}
			if (length > this.end - this.start)
			{
				length = this.end - this.start;
				global::System.Array.Copy(this.buffer_, this.start, output, offset, length);
				this.start = 0;
				this.end = 0;
			}
			else
			{
				global::System.Array.Copy(this.buffer_, this.start, output, offset, length);
				this.start += length;
			}
			return length;
		}

		// Token: 0x06000298 RID: 664 RVA: 0x0000E7B8 File Offset: 0x0000D7B8
		public byte[] ToByteArray()
		{
			byte[] array = new byte[this.end - this.start];
			global::System.Array.Copy(this.buffer_, this.start, array, 0, array.Length);
			this.start = 0;
			this.end = 0;
			return array;
		}

		// Token: 0x0400018B RID: 395
		private byte[] buffer_;

		// Token: 0x0400018C RID: 396
		private int start;

		// Token: 0x0400018D RID: 397
		private int end;

		// Token: 0x0400018E RID: 398
		private uint bits;

		// Token: 0x0400018F RID: 399
		private int bitCount;
	}
}
