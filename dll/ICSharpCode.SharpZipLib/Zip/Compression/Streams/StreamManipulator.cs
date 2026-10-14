using System;

namespace ICSharpCode.SharpZipLib.Zip.Compression.Streams
{
	// Token: 0x02000039 RID: 57
	public class StreamManipulator
	{
		// Token: 0x0600023F RID: 575 RVA: 0x0000BD80 File Offset: 0x0000AD80
		public int PeekBits(int bitCount)
		{
			if (this.bitsInBuffer_ < bitCount)
			{
				if (this.windowStart_ == this.windowEnd_)
				{
					return -1;
				}
				this.buffer_ |= (uint)((uint)((int)(this.window_[this.windowStart_++] & byte.MaxValue) | (int)(this.window_[this.windowStart_++] & byte.MaxValue) << 8) << this.bitsInBuffer_);
				this.bitsInBuffer_ += 16;
			}
			return (int)((ulong)this.buffer_ & (ulong)((long)((1 << bitCount) - 1)));
		}

		// Token: 0x06000240 RID: 576 RVA: 0x0000BE1D File Offset: 0x0000AE1D
		public void DropBits(int bitCount)
		{
			this.buffer_ >>= bitCount;
			this.bitsInBuffer_ -= bitCount;
		}

		// Token: 0x06000241 RID: 577 RVA: 0x0000BE40 File Offset: 0x0000AE40
		public int GetBits(int bitCount)
		{
			int num = this.PeekBits(bitCount);
			if (num >= 0)
			{
				this.DropBits(bitCount);
			}
			return num;
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x06000242 RID: 578 RVA: 0x0000BE61 File Offset: 0x0000AE61
		public int AvailableBits
		{
			get
			{
				return this.bitsInBuffer_;
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x06000243 RID: 579 RVA: 0x0000BE69 File Offset: 0x0000AE69
		public int AvailableBytes
		{
			get
			{
				return this.windowEnd_ - this.windowStart_ + (this.bitsInBuffer_ >> 3);
			}
		}

		// Token: 0x06000244 RID: 580 RVA: 0x0000BE81 File Offset: 0x0000AE81
		public void SkipToByteBoundary()
		{
			this.buffer_ >>= (this.bitsInBuffer_ & 7);
			this.bitsInBuffer_ &= -8;
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x06000245 RID: 581 RVA: 0x0000BEAA File Offset: 0x0000AEAA
		public bool IsNeedingInput
		{
			get
			{
				return this.windowStart_ == this.windowEnd_;
			}
		}

		// Token: 0x06000246 RID: 582 RVA: 0x0000BEBC File Offset: 0x0000AEBC
		public int CopyBytes(byte[] output, int offset, int length)
		{
			if (length < 0)
			{
				throw new global::System.ArgumentOutOfRangeException("length");
			}
			if ((this.bitsInBuffer_ & 7) != 0)
			{
				throw new global::System.InvalidOperationException("Bit buffer is not byte aligned!");
			}
			int num = 0;
			while (this.bitsInBuffer_ > 0 && length > 0)
			{
				output[offset++] = (byte)this.buffer_;
				this.buffer_ >>= 8;
				this.bitsInBuffer_ -= 8;
				length--;
				num++;
			}
			if (length == 0)
			{
				return num;
			}
			int num2 = this.windowEnd_ - this.windowStart_;
			if (length > num2)
			{
				length = num2;
			}
			global::System.Array.Copy(this.window_, this.windowStart_, output, offset, length);
			this.windowStart_ += length;
			if ((this.windowStart_ - this.windowEnd_ & 1) != 0)
			{
				this.buffer_ = (uint)(this.window_[this.windowStart_++] & byte.MaxValue);
				this.bitsInBuffer_ = 8;
			}
			return num + length;
		}

		// Token: 0x06000247 RID: 583 RVA: 0x0000BFB0 File Offset: 0x0000AFB0
		public void Reset()
		{
			this.buffer_ = 0U;
			this.windowStart_ = (this.windowEnd_ = (this.bitsInBuffer_ = 0));
		}

		// Token: 0x06000248 RID: 584 RVA: 0x0000BFE0 File Offset: 0x0000AFE0
		public void SetInput(byte[] buffer, int offset, int count)
		{
			if (buffer == null)
			{
				throw new global::System.ArgumentNullException("buffer");
			}
			if (offset < 0)
			{
				throw new global::System.ArgumentOutOfRangeException("offset", "Cannot be negative");
			}
			if (count < 0)
			{
				throw new global::System.ArgumentOutOfRangeException("count", "Cannot be negative");
			}
			if (this.windowStart_ < this.windowEnd_)
			{
				throw new global::System.InvalidOperationException("Old input was not completely processed");
			}
			int num = offset + count;
			if (offset > num || num > buffer.Length)
			{
				throw new global::System.ArgumentOutOfRangeException("count");
			}
			if ((count & 1) != 0)
			{
				this.buffer_ |= (uint)((uint)(buffer[offset++] & byte.MaxValue) << this.bitsInBuffer_);
				this.bitsInBuffer_ += 8;
			}
			this.window_ = buffer;
			this.windowStart_ = offset;
			this.windowEnd_ = num;
		}

		// Token: 0x0400011C RID: 284
		private byte[] window_;

		// Token: 0x0400011D RID: 285
		private int windowStart_;

		// Token: 0x0400011E RID: 286
		private int windowEnd_;

		// Token: 0x0400011F RID: 287
		private uint buffer_;

		// Token: 0x04000120 RID: 288
		private int bitsInBuffer_;
	}
}
