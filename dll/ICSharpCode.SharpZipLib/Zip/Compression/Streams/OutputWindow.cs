using System;

namespace ICSharpCode.SharpZipLib.Zip.Compression.Streams
{
	// Token: 0x02000038 RID: 56
	public class OutputWindow
	{
		// Token: 0x06000234 RID: 564 RVA: 0x0000BA24 File Offset: 0x0000AA24
		public void Write(int value)
		{
			if (this.windowFilled++ == 32768)
			{
				throw new global::System.InvalidOperationException("Window full");
			}
			this.window[this.windowEnd++] = (byte)value;
			this.windowEnd &= 32767;
		}

		// Token: 0x06000235 RID: 565 RVA: 0x0000BA80 File Offset: 0x0000AA80
		private void SlowRepeat(int repStart, int length, int distance)
		{
			while (length-- > 0)
			{
				this.window[this.windowEnd++] = this.window[repStart++];
				this.windowEnd &= 32767;
				repStart &= 32767;
			}
		}

		// Token: 0x06000236 RID: 566 RVA: 0x0000BAD8 File Offset: 0x0000AAD8
		public void Repeat(int length, int distance)
		{
			if ((this.windowFilled += length) > 32768)
			{
				throw new global::System.InvalidOperationException("Window full");
			}
			int num = this.windowEnd - distance & 32767;
			int num2 = 32768 - length;
			if (num > num2 || this.windowEnd >= num2)
			{
				this.SlowRepeat(num, length, distance);
				return;
			}
			if (length <= distance)
			{
				global::System.Array.Copy(this.window, num, this.window, this.windowEnd, length);
				this.windowEnd += length;
				return;
			}
			while (length-- > 0)
			{
				this.window[this.windowEnd++] = this.window[num++];
			}
		}

		// Token: 0x06000237 RID: 567 RVA: 0x0000BB90 File Offset: 0x0000AB90
		public int CopyStored(global::ICSharpCode.SharpZipLib.Zip.Compression.Streams.StreamManipulator input, int length)
		{
			length = global::System.Math.Min(global::System.Math.Min(length, 32768 - this.windowFilled), input.AvailableBytes);
			int num = 32768 - this.windowEnd;
			int num2;
			if (length > num)
			{
				num2 = input.CopyBytes(this.window, this.windowEnd, num);
				if (num2 == num)
				{
					num2 += input.CopyBytes(this.window, 0, length - num);
				}
			}
			else
			{
				num2 = input.CopyBytes(this.window, this.windowEnd, length);
			}
			this.windowEnd = (this.windowEnd + num2 & 32767);
			this.windowFilled += num2;
			return num2;
		}

		// Token: 0x06000238 RID: 568 RVA: 0x0000BC34 File Offset: 0x0000AC34
		public void CopyDict(byte[] dictionary, int offset, int length)
		{
			if (dictionary == null)
			{
				throw new global::System.ArgumentNullException("dictionary");
			}
			if (this.windowFilled > 0)
			{
				throw new global::System.InvalidOperationException();
			}
			if (length > 32768)
			{
				offset += length - 32768;
				length = 32768;
			}
			global::System.Array.Copy(dictionary, offset, this.window, 0, length);
			this.windowEnd = (length & 32767);
		}

		// Token: 0x06000239 RID: 569 RVA: 0x0000BC94 File Offset: 0x0000AC94
		public int GetFreeSpace()
		{
			return 32768 - this.windowFilled;
		}

		// Token: 0x0600023A RID: 570 RVA: 0x0000BCA2 File Offset: 0x0000ACA2
		public int GetAvailable()
		{
			return this.windowFilled;
		}

		// Token: 0x0600023B RID: 571 RVA: 0x0000BCAC File Offset: 0x0000ACAC
		public int CopyOutput(byte[] output, int offset, int len)
		{
			int num = this.windowEnd;
			if (len > this.windowFilled)
			{
				len = this.windowFilled;
			}
			else
			{
				num = (this.windowEnd - this.windowFilled + len & 32767);
			}
			int num2 = len;
			int num3 = len - num;
			if (num3 > 0)
			{
				global::System.Array.Copy(this.window, 32768 - num3, output, offset, num3);
				offset += num3;
				len = num;
			}
			global::System.Array.Copy(this.window, num - len, output, offset, len);
			this.windowFilled -= num2;
			if (this.windowFilled < 0)
			{
				throw new global::System.InvalidOperationException();
			}
			return num2;
		}

		// Token: 0x0600023C RID: 572 RVA: 0x0000BD40 File Offset: 0x0000AD40
		public void Reset()
		{
			this.windowFilled = (this.windowEnd = 0);
		}

		// Token: 0x04000117 RID: 279
		private const int WindowSize = 32768;

		// Token: 0x04000118 RID: 280
		private const int WindowMask = 32767;

		// Token: 0x04000119 RID: 281
		private byte[] window = new byte[32768];

		// Token: 0x0400011A RID: 282
		private int windowEnd;

		// Token: 0x0400011B RID: 283
		private int windowFilled;
	}
}
