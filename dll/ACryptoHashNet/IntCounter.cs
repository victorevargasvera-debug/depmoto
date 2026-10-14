using System;

namespace Home.Andir.Cryptography
{
	// Token: 0x0200000C RID: 12
	public sealed class IntCounter
	{
		// Token: 0x06000037 RID: 55 RVA: 0x000051AA File Offset: 0x000041AA
		public IntCounter(int count)
		{
			this.array = new uint[count];
		}

		// Token: 0x06000038 RID: 56 RVA: 0x000051BE File Offset: 0x000041BE
		public void Clear()
		{
			global::System.Array.Clear(this.array, 0, this.array.Length);
		}

		// Token: 0x06000039 RID: 57 RVA: 0x000051D4 File Offset: 0x000041D4
		public void Add(int value)
		{
			this.Add((uint)value);
		}

		// Token: 0x0600003A RID: 58 RVA: 0x000051DD File Offset: 0x000041DD
		public void Add(uint value)
		{
			this.Add(0, value);
		}

		// Token: 0x0600003B RID: 59 RVA: 0x000051E8 File Offset: 0x000041E8
		public void Add(long value)
		{
			this.Add(new uint[]
			{
				(uint)value,
				(uint)(value >> 32)
			});
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00005210 File Offset: 0x00004210
		private void Add(uint[] input)
		{
			int num = global::System.Math.Min(this.array.Length, input.Length);
			for (int i = 0; i < num; i++)
			{
				this.Add(i, input[i]);
			}
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00005244 File Offset: 0x00004244
		private void Add(int index, uint value)
		{
			if (value <= 4294967295U - this.array[index])
			{
				this.array[index] += value;
				return;
			}
			this.array[index] = uint.MaxValue - this.array[index];
			this.array[index] += 1U;
			this.array[index] = value - this.array[index];
			if (index + 1 >= this.array.Length)
			{
				throw new global::System.OverflowException("counter overflow!");
			}
			this.Add(index + 1, 1U);
		}

		// Token: 0x0600003E RID: 62 RVA: 0x000052D8 File Offset: 0x000042D8
		public byte[] GetBytes()
		{
			byte[] array = new byte[this.array.Length << 2];
			global::System.Buffer.BlockCopy(this.array, 0, array, 0, array.Length);
			return array;
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00005307 File Offset: 0x00004307
		public uint ToInt32()
		{
			return this.array[0];
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00005311 File Offset: 0x00004311
		public ulong ToULong()
		{
			return ((ulong)this.array[1] << 32) + (ulong)this.array[0];
		}

		// Token: 0x04000018 RID: 24
		private uint[] array;
	}
}
