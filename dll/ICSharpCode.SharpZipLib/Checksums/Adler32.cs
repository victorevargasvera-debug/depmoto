using System;

namespace ICSharpCode.SharpZipLib.Checksums
{
	// Token: 0x0200000A RID: 10
	public sealed class Adler32 : global::ICSharpCode.SharpZipLib.Checksums.IChecksum
	{
		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600006E RID: 110 RVA: 0x000060E9 File Offset: 0x000050E9
		public long Value
		{
			get
			{
				return (long)((ulong)this.checksum);
			}
		}

		// Token: 0x0600006F RID: 111 RVA: 0x000060F2 File Offset: 0x000050F2
		public Adler32()
		{
			this.Reset();
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00006100 File Offset: 0x00005100
		public void Reset()
		{
			this.checksum = 1U;
		}

		// Token: 0x06000071 RID: 113 RVA: 0x0000610C File Offset: 0x0000510C
		public void Update(int value)
		{
			uint num = this.checksum & 65535U;
			uint num2 = this.checksum >> 16;
			num = (num + (uint)(value & 255)) % 65521U;
			num2 = (num + num2) % 65521U;
			this.checksum = (num2 << 16) + num;
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00006156 File Offset: 0x00005156
		public void Update(byte[] buffer)
		{
			if (buffer == null)
			{
				throw new global::System.ArgumentNullException("buffer");
			}
			this.Update(buffer, 0, buffer.Length);
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00006174 File Offset: 0x00005174
		public void Update(byte[] buffer, int offset, int count)
		{
			if (buffer == null)
			{
				throw new global::System.ArgumentNullException("buffer");
			}
			if (offset < 0)
			{
				throw new global::System.ArgumentOutOfRangeException("offset", "cannot be negative");
			}
			if (count < 0)
			{
				throw new global::System.ArgumentOutOfRangeException("count", "cannot be negative");
			}
			if (offset >= buffer.Length)
			{
				throw new global::System.ArgumentOutOfRangeException("offset", "not a valid index into buffer");
			}
			if (offset + count > buffer.Length)
			{
				throw new global::System.ArgumentOutOfRangeException("count", "exceeds buffer size");
			}
			uint num = this.checksum & 65535U;
			uint num2 = this.checksum >> 16;
			while (count > 0)
			{
				int num3 = 3800;
				if (num3 > count)
				{
					num3 = count;
				}
				count -= num3;
				while (--num3 >= 0)
				{
					num += (uint)(buffer[offset++] & byte.MaxValue);
					num2 += num;
				}
				num %= 65521U;
				num2 %= 65521U;
			}
			this.checksum = (num2 << 16 | num);
		}

		// Token: 0x04000066 RID: 102
		private const uint BASE = 65521U;

		// Token: 0x04000067 RID: 103
		private uint checksum;
	}
}
