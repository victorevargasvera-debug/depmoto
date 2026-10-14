using System;

namespace Home.Andir.Cryptography
{
	// Token: 0x02000010 RID: 16
	public sealed class RIPEMD128 : global::Home.Andir.Cryptography.BlockHashAlgorithm
	{
		// Token: 0x06000056 RID: 86 RVA: 0x00006664 File Offset: 0x00005664
		public RIPEMD128() : base(64)
		{
			this.HashSizeValue = 128;
			this.finalBlock = new byte[base.BlockSize];
			this.Initialize();
		}

		// Token: 0x06000057 RID: 87 RVA: 0x000066C0 File Offset: 0x000056C0
		public override void Initialize()
		{
			base.Initialize();
			this.counter.Clear();
			global::System.Array.Clear(this.finalBlock, 0, this.finalBlock.Length);
			this.InitializeState();
		}

		// Token: 0x06000058 RID: 88 RVA: 0x000066ED File Offset: 0x000056ED
		private void InitializeState()
		{
			this.state[0] = 1732584193U;
			this.state[1] = 4023233417U;
			this.state[2] = 2562383102U;
			this.state[3] = 271733878U;
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00006724 File Offset: 0x00005724
		protected override void ProcessBlock(byte[] array, int offset)
		{
			if (array.Length < offset + base.BlockSize)
			{
				throw new global::System.ArgumentOutOfRangeException("offset");
			}
			this.counter.Add(base.BlockSize << 3);
			global::System.Buffer.BlockCopy(array, offset, this.buffer, 0, base.BlockSize);
			uint num = this.state[0];
			uint num2 = this.state[0];
			uint num3 = this.state[1];
			uint num4 = this.state[1];
			uint num5 = this.state[2];
			uint num6 = this.state[2];
			uint num7 = this.state[3];
			uint num8 = this.state[3];
			this.MDTransform1(ref num, ref num3, ref num5, ref num7);
			this.MDTransform2(ref num2, ref num4, ref num6, ref num8);
			uint num9 = this.state[1] + num5 + num8;
			this.state[1] = this.state[2] + num7 + num2;
			this.state[2] = this.state[3] + num + num4;
			this.state[3] = this.state[0] + num3 + num6;
			this.state[0] = num9;
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00006830 File Offset: 0x00005830
		protected override void ProcessFinalBlock(byte[] array, int offset, int length)
		{
			if (length >= base.BlockSize || length > array.Length - offset)
			{
				throw new global::System.ArgumentOutOfRangeException("length");
			}
			this.counter.Add(length << 3);
			byte[] bytes = this.counter.GetBytes();
			this.counter.Clear();
			global::System.Buffer.BlockCopy(array, offset, this.finalBlock, 0, length);
			this.finalBlock[length] = 128;
			int num = base.BlockSize - 8;
			if (length >= num)
			{
				this.ProcessBlock(this.finalBlock, 0);
				global::System.Array.Clear(this.finalBlock, 0, this.finalBlock.Length);
			}
			for (int i = 0; i < 8; i++)
			{
				this.finalBlock[num + i] = bytes[i];
			}
			this.ProcessBlock(this.finalBlock, 0);
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600005B RID: 91 RVA: 0x000068F0 File Offset: 0x000058F0
		protected override byte[] Result
		{
			get
			{
				byte[] array = new byte[16];
				global::System.Buffer.BlockCopy(this.state, 0, array, 0, array.Length);
				return array;
			}
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00006918 File Offset: 0x00005918
		private void MDTransform1(ref uint a, ref uint b, ref uint c, ref uint d)
		{
			for (int i = 0; i < 16; i += 4)
			{
				a += (b ^ c ^ d);
				a += global::Home.Andir.Cryptography.RIPEMD128.constants1[0] + this.buffer[(int)((global::System.UIntPtr)global::Home.Andir.Cryptography.RIPEMD128.wordOrders1[i])];
				a = (a << global::Home.Andir.Cryptography.RIPEMD128._shifts1[i] | a >> 32 - global::Home.Andir.Cryptography.RIPEMD128._shifts1[i]);
				d += (a ^ b ^ c);
				d += global::Home.Andir.Cryptography.RIPEMD128.constants1[0] + this.buffer[(int)((global::System.UIntPtr)global::Home.Andir.Cryptography.RIPEMD128.wordOrders1[i + 1])];
				d = (d << global::Home.Andir.Cryptography.RIPEMD128._shifts1[i + 1] | d >> 32 - global::Home.Andir.Cryptography.RIPEMD128._shifts1[i + 1]);
				c += (d ^ a ^ b);
				c += global::Home.Andir.Cryptography.RIPEMD128.constants1[0] + this.buffer[(int)((global::System.UIntPtr)global::Home.Andir.Cryptography.RIPEMD128.wordOrders1[i + 2])];
				c = (c << global::Home.Andir.Cryptography.RIPEMD128._shifts1[i + 2] | c >> 32 - global::Home.Andir.Cryptography.RIPEMD128._shifts1[i + 2]);
				b += (c ^ d ^ a);
				b += global::Home.Andir.Cryptography.RIPEMD128.constants1[0] + this.buffer[(int)((global::System.UIntPtr)global::Home.Andir.Cryptography.RIPEMD128.wordOrders1[i + 3])];
				b = (b << global::Home.Andir.Cryptography.RIPEMD128._shifts1[i + 3] | b >> 32 - global::Home.Andir.Cryptography.RIPEMD128._shifts1[i + 3]);
			}
			for (int j = 16; j < 32; j += 4)
			{
				a += ((b & c) | (~b & d));
				a += global::Home.Andir.Cryptography.RIPEMD128.constants1[1] + this.buffer[(int)((global::System.UIntPtr)global::Home.Andir.Cryptography.RIPEMD128.wordOrders1[j])];
				a = (a << global::Home.Andir.Cryptography.RIPEMD128._shifts1[j] | a >> 32 - global::Home.Andir.Cryptography.RIPEMD128._shifts1[j]);
				d += ((a & b) | (~a & c));
				d += global::Home.Andir.Cryptography.RIPEMD128.constants1[1] + this.buffer[(int)((global::System.UIntPtr)global::Home.Andir.Cryptography.RIPEMD128.wordOrders1[j + 1])];
				d = (d << global::Home.Andir.Cryptography.RIPEMD128._shifts1[j + 1] | d >> 32 - global::Home.Andir.Cryptography.RIPEMD128._shifts1[j + 1]);
				c += ((d & a) | (~d & b));
				c += global::Home.Andir.Cryptography.RIPEMD128.constants1[1] + this.buffer[(int)((global::System.UIntPtr)global::Home.Andir.Cryptography.RIPEMD128.wordOrders1[j + 2])];
				c = (c << global::Home.Andir.Cryptography.RIPEMD128._shifts1[j + 2] | c >> 32 - global::Home.Andir.Cryptography.RIPEMD128._shifts1[j + 2]);
				b += ((c & d) | (~c & a));
				b += global::Home.Andir.Cryptography.RIPEMD128.constants1[1] + this.buffer[(int)((global::System.UIntPtr)global::Home.Andir.Cryptography.RIPEMD128.wordOrders1[j + 3])];
				b = (b << global::Home.Andir.Cryptography.RIPEMD128._shifts1[j + 3] | b >> 32 - global::Home.Andir.Cryptography.RIPEMD128._shifts1[j + 3]);
			}
			for (int k = 32; k < 48; k += 4)
			{
				a += ((b | ~c) ^ d);
				a += global::Home.Andir.Cryptography.RIPEMD128.constants1[2] + this.buffer[(int)((global::System.UIntPtr)global::Home.Andir.Cryptography.RIPEMD128.wordOrders1[k])];
				a = (a << global::Home.Andir.Cryptography.RIPEMD128._shifts1[k] | a >> 32 - global::Home.Andir.Cryptography.RIPEMD128._shifts1[k]);
				d += ((a | ~b) ^ c);
				d += global::Home.Andir.Cryptography.RIPEMD128.constants1[2] + this.buffer[(int)((global::System.UIntPtr)global::Home.Andir.Cryptography.RIPEMD128.wordOrders1[k + 1])];
				d = (d << global::Home.Andir.Cryptography.RIPEMD128._shifts1[k + 1] | d >> 32 - global::Home.Andir.Cryptography.RIPEMD128._shifts1[k + 1]);
				c += ((d | ~a) ^ b);
				c += global::Home.Andir.Cryptography.RIPEMD128.constants1[2] + this.buffer[(int)((global::System.UIntPtr)global::Home.Andir.Cryptography.RIPEMD128.wordOrders1[k + 2])];
				c = (c << global::Home.Andir.Cryptography.RIPEMD128._shifts1[k + 2] | c >> 32 - global::Home.Andir.Cryptography.RIPEMD128._shifts1[k + 2]);
				b += ((c | ~d) ^ a);
				b += global::Home.Andir.Cryptography.RIPEMD128.constants1[2] + this.buffer[(int)((global::System.UIntPtr)global::Home.Andir.Cryptography.RIPEMD128.wordOrders1[k + 3])];
				b = (b << global::Home.Andir.Cryptography.RIPEMD128._shifts1[k + 3] | b >> 32 - global::Home.Andir.Cryptography.RIPEMD128._shifts1[k + 3]);
			}
			for (int l = 48; l < 64; l += 4)
			{
				a += ((b & d) | (c & ~d));
				a += global::Home.Andir.Cryptography.RIPEMD128.constants1[3] + this.buffer[(int)((global::System.UIntPtr)global::Home.Andir.Cryptography.RIPEMD128.wordOrders1[l])];
				a = (a << global::Home.Andir.Cryptography.RIPEMD128._shifts1[l] | a >> 32 - global::Home.Andir.Cryptography.RIPEMD128._shifts1[l]);
				d += ((a & c) | (b & ~c));
				d += global::Home.Andir.Cryptography.RIPEMD128.constants1[3] + this.buffer[(int)((global::System.UIntPtr)global::Home.Andir.Cryptography.RIPEMD128.wordOrders1[l + 1])];
				d = (d << global::Home.Andir.Cryptography.RIPEMD128._shifts1[l + 1] | d >> 32 - global::Home.Andir.Cryptography.RIPEMD128._shifts1[l + 1]);
				c += ((d & b) | (a & ~b));
				c += global::Home.Andir.Cryptography.RIPEMD128.constants1[3] + this.buffer[(int)((global::System.UIntPtr)global::Home.Andir.Cryptography.RIPEMD128.wordOrders1[l + 2])];
				c = (c << global::Home.Andir.Cryptography.RIPEMD128._shifts1[l + 2] | c >> 32 - global::Home.Andir.Cryptography.RIPEMD128._shifts1[l + 2]);
				b += ((c & a) | (d & ~a));
				b += global::Home.Andir.Cryptography.RIPEMD128.constants1[3] + this.buffer[(int)((global::System.UIntPtr)global::Home.Andir.Cryptography.RIPEMD128.wordOrders1[l + 3])];
				b = (b << global::Home.Andir.Cryptography.RIPEMD128._shifts1[l + 3] | b >> 32 - global::Home.Andir.Cryptography.RIPEMD128._shifts1[l + 3]);
			}
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00006E94 File Offset: 0x00005E94
		private void MDTransform2(ref uint a, ref uint b, ref uint c, ref uint d)
		{
			for (int i = 0; i < 16; i += 4)
			{
				a += ((b & d) | (c & ~d));
				a += global::Home.Andir.Cryptography.RIPEMD128.constants2[0] + this.buffer[(int)((global::System.UIntPtr)global::Home.Andir.Cryptography.RIPEMD128.wordOrders2[i])];
				a = (a << global::Home.Andir.Cryptography.RIPEMD128.shifts2[i] | a >> 32 - global::Home.Andir.Cryptography.RIPEMD128.shifts2[i]);
				d += ((a & c) | (b & ~c));
				d += global::Home.Andir.Cryptography.RIPEMD128.constants2[0] + this.buffer[(int)((global::System.UIntPtr)global::Home.Andir.Cryptography.RIPEMD128.wordOrders2[i + 1])];
				d = (d << global::Home.Andir.Cryptography.RIPEMD128.shifts2[i + 1] | d >> 32 - global::Home.Andir.Cryptography.RIPEMD128.shifts2[i + 1]);
				c += ((d & b) | (a & ~b));
				c += global::Home.Andir.Cryptography.RIPEMD128.constants2[0] + this.buffer[(int)((global::System.UIntPtr)global::Home.Andir.Cryptography.RIPEMD128.wordOrders2[i + 2])];
				c = (c << global::Home.Andir.Cryptography.RIPEMD128.shifts2[i + 2] | c >> 32 - global::Home.Andir.Cryptography.RIPEMD128.shifts2[i + 2]);
				b += ((c & a) | (d & ~a));
				b += global::Home.Andir.Cryptography.RIPEMD128.constants2[0] + this.buffer[(int)((global::System.UIntPtr)global::Home.Andir.Cryptography.RIPEMD128.wordOrders2[i + 3])];
				b = (b << global::Home.Andir.Cryptography.RIPEMD128.shifts2[i + 3] | b >> 32 - global::Home.Andir.Cryptography.RIPEMD128.shifts2[i + 3]);
			}
			for (int j = 16; j < 32; j += 4)
			{
				a += ((b | ~c) ^ d);
				a += global::Home.Andir.Cryptography.RIPEMD128.constants2[1] + this.buffer[(int)((global::System.UIntPtr)global::Home.Andir.Cryptography.RIPEMD128.wordOrders2[j])];
				a = (a << global::Home.Andir.Cryptography.RIPEMD128.shifts2[j] | a >> 32 - global::Home.Andir.Cryptography.RIPEMD128.shifts2[j]);
				d += ((a | ~b) ^ c);
				d += global::Home.Andir.Cryptography.RIPEMD128.constants2[1] + this.buffer[(int)((global::System.UIntPtr)global::Home.Andir.Cryptography.RIPEMD128.wordOrders2[j + 1])];
				d = (d << global::Home.Andir.Cryptography.RIPEMD128.shifts2[j + 1] | d >> 32 - global::Home.Andir.Cryptography.RIPEMD128.shifts2[j + 1]);
				c += ((d | ~a) ^ b);
				c += global::Home.Andir.Cryptography.RIPEMD128.constants2[1] + this.buffer[(int)((global::System.UIntPtr)global::Home.Andir.Cryptography.RIPEMD128.wordOrders2[j + 2])];
				c = (c << global::Home.Andir.Cryptography.RIPEMD128.shifts2[j + 2] | c >> 32 - global::Home.Andir.Cryptography.RIPEMD128.shifts2[j + 2]);
				b += ((c | ~d) ^ a);
				b += global::Home.Andir.Cryptography.RIPEMD128.constants2[1] + this.buffer[(int)((global::System.UIntPtr)global::Home.Andir.Cryptography.RIPEMD128.wordOrders2[j + 3])];
				b = (b << global::Home.Andir.Cryptography.RIPEMD128.shifts2[j + 3] | b >> 32 - global::Home.Andir.Cryptography.RIPEMD128.shifts2[j + 3]);
			}
			for (int k = 32; k < 48; k += 4)
			{
				a += ((b & c) | (~b & d));
				a += global::Home.Andir.Cryptography.RIPEMD128.constants2[2] + this.buffer[(int)((global::System.UIntPtr)global::Home.Andir.Cryptography.RIPEMD128.wordOrders2[k])];
				a = (a << global::Home.Andir.Cryptography.RIPEMD128.shifts2[k] | a >> 32 - global::Home.Andir.Cryptography.RIPEMD128.shifts2[k]);
				d += ((a & b) | (~a & c));
				d += global::Home.Andir.Cryptography.RIPEMD128.constants2[2] + this.buffer[(int)((global::System.UIntPtr)global::Home.Andir.Cryptography.RIPEMD128.wordOrders2[k + 1])];
				d = (d << global::Home.Andir.Cryptography.RIPEMD128.shifts2[k + 1] | d >> 32 - global::Home.Andir.Cryptography.RIPEMD128.shifts2[k + 1]);
				c += ((d & a) | (~d & b));
				c += global::Home.Andir.Cryptography.RIPEMD128.constants2[2] + this.buffer[(int)((global::System.UIntPtr)global::Home.Andir.Cryptography.RIPEMD128.wordOrders2[k + 2])];
				c = (c << global::Home.Andir.Cryptography.RIPEMD128.shifts2[k + 2] | c >> 32 - global::Home.Andir.Cryptography.RIPEMD128.shifts2[k + 2]);
				b += ((c & d) | (~c & a));
				b += global::Home.Andir.Cryptography.RIPEMD128.constants2[2] + this.buffer[(int)((global::System.UIntPtr)global::Home.Andir.Cryptography.RIPEMD128.wordOrders2[k + 3])];
				b = (b << global::Home.Andir.Cryptography.RIPEMD128.shifts2[k + 3] | b >> 32 - global::Home.Andir.Cryptography.RIPEMD128.shifts2[k + 3]);
			}
			for (int l = 48; l < 64; l += 4)
			{
				a += (b ^ c ^ d);
				a += global::Home.Andir.Cryptography.RIPEMD128.constants2[3] + this.buffer[(int)((global::System.UIntPtr)global::Home.Andir.Cryptography.RIPEMD128.wordOrders2[l])];
				a = (a << global::Home.Andir.Cryptography.RIPEMD128.shifts2[l] | a >> 32 - global::Home.Andir.Cryptography.RIPEMD128.shifts2[l]);
				d += (a ^ b ^ c);
				d += global::Home.Andir.Cryptography.RIPEMD128.constants2[3] + this.buffer[(int)((global::System.UIntPtr)global::Home.Andir.Cryptography.RIPEMD128.wordOrders2[l + 1])];
				d = (d << global::Home.Andir.Cryptography.RIPEMD128.shifts2[l + 1] | d >> 32 - global::Home.Andir.Cryptography.RIPEMD128.shifts2[l + 1]);
				c += (d ^ a ^ b);
				c += global::Home.Andir.Cryptography.RIPEMD128.constants2[3] + this.buffer[(int)((global::System.UIntPtr)global::Home.Andir.Cryptography.RIPEMD128.wordOrders2[l + 2])];
				c = (c << global::Home.Andir.Cryptography.RIPEMD128.shifts2[l + 2] | c >> 32 - global::Home.Andir.Cryptography.RIPEMD128.shifts2[l + 2]);
				b += (c ^ d ^ a);
				b += global::Home.Andir.Cryptography.RIPEMD128.constants2[3] + this.buffer[(int)((global::System.UIntPtr)global::Home.Andir.Cryptography.RIPEMD128.wordOrders2[l + 3])];
				b = (b << global::Home.Andir.Cryptography.RIPEMD128.shifts2[l + 3] | b >> 32 - global::Home.Andir.Cryptography.RIPEMD128.shifts2[l + 3]);
			}
		}

		// Token: 0x0400002A RID: 42
		private readonly global::Home.Andir.Cryptography.IntCounter counter = new global::Home.Andir.Cryptography.IntCounter(2);

		// Token: 0x0400002B RID: 43
		private readonly uint[] state = new uint[5];

		// Token: 0x0400002C RID: 44
		private readonly byte[] finalBlock;

		// Token: 0x0400002D RID: 45
		private static readonly uint[] constants1 = new uint[]
		{
			0U,
			1518500249U,
			1859775393U,
			2400959708U
		};

		// Token: 0x0400002E RID: 46
		private static readonly uint[] wordOrders1 = new uint[]
		{
			0U,
			1U,
			2U,
			3U,
			4U,
			5U,
			6U,
			7U,
			8U,
			9U,
			10U,
			11U,
			12U,
			13U,
			14U,
			15U,
			7U,
			4U,
			13U,
			1U,
			10U,
			6U,
			15U,
			3U,
			12U,
			0U,
			9U,
			5U,
			2U,
			14U,
			11U,
			8U,
			3U,
			10U,
			14U,
			4U,
			9U,
			15U,
			8U,
			1U,
			2U,
			7U,
			0U,
			6U,
			13U,
			11U,
			5U,
			12U,
			1U,
			9U,
			11U,
			10U,
			0U,
			8U,
			12U,
			4U,
			13U,
			3U,
			7U,
			15U,
			14U,
			5U,
			6U,
			2U
		};

		// Token: 0x0400002F RID: 47
		private static readonly int[] _shifts1 = new int[]
		{
			11,
			14,
			15,
			12,
			5,
			8,
			7,
			9,
			11,
			13,
			14,
			15,
			6,
			7,
			9,
			8,
			7,
			6,
			8,
			13,
			11,
			9,
			7,
			15,
			7,
			12,
			15,
			9,
			11,
			7,
			13,
			12,
			11,
			13,
			6,
			7,
			14,
			9,
			13,
			15,
			14,
			8,
			13,
			6,
			5,
			12,
			7,
			5,
			11,
			12,
			14,
			15,
			14,
			15,
			9,
			8,
			9,
			14,
			5,
			6,
			8,
			6,
			5,
			12
		};

		// Token: 0x04000030 RID: 48
		private static readonly uint[] constants2 = new uint[]
		{
			1352829926U,
			1548603684U,
			1836072691U,
			0U
		};

		// Token: 0x04000031 RID: 49
		private static readonly uint[] wordOrders2 = new uint[]
		{
			5U,
			14U,
			7U,
			0U,
			9U,
			2U,
			11U,
			4U,
			13U,
			6U,
			15U,
			8U,
			1U,
			10U,
			3U,
			12U,
			6U,
			11U,
			3U,
			7U,
			0U,
			13U,
			5U,
			10U,
			14U,
			15U,
			8U,
			12U,
			4U,
			9U,
			1U,
			2U,
			15U,
			5U,
			1U,
			3U,
			7U,
			14U,
			6U,
			9U,
			11U,
			8U,
			12U,
			2U,
			10U,
			0U,
			4U,
			13U,
			8U,
			6U,
			4U,
			1U,
			3U,
			11U,
			15U,
			0U,
			5U,
			12U,
			2U,
			13U,
			9U,
			7U,
			10U,
			14U
		};

		// Token: 0x04000032 RID: 50
		private static readonly int[] shifts2 = new int[]
		{
			8,
			9,
			9,
			11,
			13,
			15,
			15,
			5,
			7,
			7,
			8,
			11,
			14,
			14,
			12,
			6,
			9,
			13,
			15,
			7,
			12,
			8,
			9,
			11,
			7,
			7,
			12,
			7,
			6,
			15,
			13,
			11,
			9,
			7,
			15,
			11,
			8,
			6,
			6,
			14,
			12,
			13,
			5,
			14,
			13,
			13,
			7,
			5,
			15,
			5,
			8,
			11,
			14,
			14,
			6,
			14,
			6,
			9,
			12,
			9,
			12,
			5,
			15,
			8
		};

		// Token: 0x04000033 RID: 51
		private uint[] buffer = new uint[16];
	}
}
