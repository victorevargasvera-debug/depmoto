using System;

namespace Home.Andir.Cryptography
{
	// Token: 0x02000011 RID: 17
	public sealed class RIPEMD160 : global::Home.Andir.Cryptography.BlockHashAlgorithm
	{
		// Token: 0x0600005F RID: 95 RVA: 0x000078C8 File Offset: 0x000068C8
		public RIPEMD160() : base(64)
		{
			this.HashSizeValue = 160;
			this.finalBlock = new byte[base.BlockSize];
			this.Initialize();
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00007924 File Offset: 0x00006924
		public override void Initialize()
		{
			base.Initialize();
			this.counter.Clear();
			global::System.Array.Clear(this.finalBlock, 0, this.finalBlock.Length);
			this.InitializeState();
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00007954 File Offset: 0x00006954
		private void InitializeState()
		{
			this.state[0] = 1732584193U;
			this.state[1] = 4023233417U;
			this.state[2] = 2562383102U;
			this.state[3] = 271733878U;
			this.state[4] = 3285377520U;
		}

		// Token: 0x06000062 RID: 98 RVA: 0x000079A4 File Offset: 0x000069A4
		protected override void ProcessBlock(byte[] array, int offset)
		{
			if (array.Length < offset + base.BlockSize)
			{
				throw new global::System.ArgumentOutOfRangeException("Name: offset");
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
			uint num9 = this.state[4];
			uint num10 = this.state[4];
			this.MDTransform1(ref num, ref num3, ref num5, ref num7, ref num9);
			this.MDTransform2(ref num2, ref num4, ref num6, ref num8, ref num10);
			uint num11 = this.state[1] + num5 + num8;
			this.state[1] = this.state[2] + num7 + num10;
			this.state[2] = this.state[3] + num9 + num2;
			this.state[3] = this.state[4] + num + num4;
			this.state[4] = this.state[0] + num3 + num6;
			this.state[0] = num11;
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00007AE0 File Offset: 0x00006AE0
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

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000064 RID: 100 RVA: 0x00007BA0 File Offset: 0x00006BA0
		protected override byte[] Result
		{
			get
			{
				byte[] array = new byte[20];
				global::System.Buffer.BlockCopy(this.state, 0, array, 0, array.Length);
				return array;
			}
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00007BC8 File Offset: 0x00006BC8
		private void MDTransform1(ref uint a, ref uint b, ref uint c, ref uint d, ref uint e)
		{
			int i;
			for (i = 0; i < 15; i += 5)
			{
				a += (b ^ c ^ d);
				a += global::Home.Andir.Cryptography.RIPEMD160.constants1[0] + this.buffer[(int)((global::System.UIntPtr)global::Home.Andir.Cryptography.RIPEMD160.wordOrders1[i])];
				a = (a << global::Home.Andir.Cryptography.RIPEMD160.shifts1[i] | a >> 32 - global::Home.Andir.Cryptography.RIPEMD160.shifts1[i]);
				a += e;
				c = (c << 10 | c >> 22);
				e += (a ^ b ^ c);
				e += global::Home.Andir.Cryptography.RIPEMD160.constants1[0] + this.buffer[(int)((global::System.UIntPtr)global::Home.Andir.Cryptography.RIPEMD160.wordOrders1[i + 1])];
				e = (e << global::Home.Andir.Cryptography.RIPEMD160.shifts1[i + 1] | e >> 32 - global::Home.Andir.Cryptography.RIPEMD160.shifts1[i + 1]);
				e += d;
				b = (b << 10 | b >> 22);
				d += (e ^ a ^ b);
				d += global::Home.Andir.Cryptography.RIPEMD160.constants1[0] + this.buffer[(int)((global::System.UIntPtr)global::Home.Andir.Cryptography.RIPEMD160.wordOrders1[i + 2])];
				d = (d << global::Home.Andir.Cryptography.RIPEMD160.shifts1[i + 2] | d >> 32 - global::Home.Andir.Cryptography.RIPEMD160.shifts1[i + 2]);
				d += c;
				a = (a << 10 | a >> 22);
				c += (d ^ e ^ a);
				c += global::Home.Andir.Cryptography.RIPEMD160.constants1[0] + this.buffer[(int)((global::System.UIntPtr)global::Home.Andir.Cryptography.RIPEMD160.wordOrders1[i + 3])];
				c = (c << global::Home.Andir.Cryptography.RIPEMD160.shifts1[i + 3] | c >> 32 - global::Home.Andir.Cryptography.RIPEMD160.shifts1[i + 3]);
				c += b;
				e = (e << 10 | e >> 22);
				b += (c ^ d ^ e);
				b += global::Home.Andir.Cryptography.RIPEMD160.constants1[0] + this.buffer[(int)((global::System.UIntPtr)global::Home.Andir.Cryptography.RIPEMD160.wordOrders1[i + 4])];
				b = (b << global::Home.Andir.Cryptography.RIPEMD160.shifts1[i + 4] | b >> 32 - global::Home.Andir.Cryptography.RIPEMD160.shifts1[i + 4]);
				b += a;
				d = (d << 10 | d >> 22);
			}
			a += (b ^ c ^ d);
			a += global::Home.Andir.Cryptography.RIPEMD160.constants1[0] + this.buffer[(int)((global::System.UIntPtr)global::Home.Andir.Cryptography.RIPEMD160.wordOrders1[i])];
			a = (a << global::Home.Andir.Cryptography.RIPEMD160.shifts1[i] | a >> 32 - global::Home.Andir.Cryptography.RIPEMD160.shifts1[i]);
			a += e;
			c = (c << 10 | c >> 22);
			for (i = 16; i < 31; i += 5)
			{
				e += ((a & b) | (~a & c));
				e += global::Home.Andir.Cryptography.RIPEMD160.constants1[1] + this.buffer[(int)((global::System.UIntPtr)global::Home.Andir.Cryptography.RIPEMD160.wordOrders1[i])];
				e = (e << global::Home.Andir.Cryptography.RIPEMD160.shifts1[i] | e >> 32 - global::Home.Andir.Cryptography.RIPEMD160.shifts1[i]);
				e += d;
				b = (b << 10 | b >> 22);
				d += ((e & a) | (~e & b));
				d += global::Home.Andir.Cryptography.RIPEMD160.constants1[1] + this.buffer[(int)((global::System.UIntPtr)global::Home.Andir.Cryptography.RIPEMD160.wordOrders1[i + 1])];
				d = (d << global::Home.Andir.Cryptography.RIPEMD160.shifts1[i + 1] | d >> 32 - global::Home.Andir.Cryptography.RIPEMD160.shifts1[i + 1]);
				d += c;
				a = (a << 10 | a >> 22);
				c += ((d & e) | (~d & a));
				c += global::Home.Andir.Cryptography.RIPEMD160.constants1[1] + this.buffer[(int)((global::System.UIntPtr)global::Home.Andir.Cryptography.RIPEMD160.wordOrders1[i + 2])];
				c = (c << global::Home.Andir.Cryptography.RIPEMD160.shifts1[i + 2] | c >> 32 - global::Home.Andir.Cryptography.RIPEMD160.shifts1[i + 2]);
				c += b;
				e = (e << 10 | e >> 22);
				b += ((c & d) | (~c & e));
				b += global::Home.Andir.Cryptography.RIPEMD160.constants1[1] + this.buffer[(int)((global::System.UIntPtr)global::Home.Andir.Cryptography.RIPEMD160.wordOrders1[i + 3])];
				b = (b << global::Home.Andir.Cryptography.RIPEMD160.shifts1[i + 3] | b >> 32 - global::Home.Andir.Cryptography.RIPEMD160.shifts1[i + 3]);
				b += a;
				d = (d << 10 | d >> 22);
				a += ((b & c) | (~b & d));
				a += global::Home.Andir.Cryptography.RIPEMD160.constants1[1] + this.buffer[(int)((global::System.UIntPtr)global::Home.Andir.Cryptography.RIPEMD160.wordOrders1[i + 4])];
				a = (a << global::Home.Andir.Cryptography.RIPEMD160.shifts1[i + 4] | a >> 32 - global::Home.Andir.Cryptography.RIPEMD160.shifts1[i + 4]);
				a += e;
				c = (c << 10 | c >> 22);
			}
			e += ((a & b) | (~a & c));
			e += global::Home.Andir.Cryptography.RIPEMD160.constants1[1] + this.buffer[(int)((global::System.UIntPtr)global::Home.Andir.Cryptography.RIPEMD160.wordOrders1[i])];
			e = (e << global::Home.Andir.Cryptography.RIPEMD160.shifts1[i] | e >> 32 - global::Home.Andir.Cryptography.RIPEMD160.shifts1[i]);
			e += d;
			b = (b << 10 | b >> 22);
			for (i = 32; i < 47; i += 5)
			{
				d += ((e | ~a) ^ b);
				d += global::Home.Andir.Cryptography.RIPEMD160.constants1[2] + this.buffer[(int)((global::System.UIntPtr)global::Home.Andir.Cryptography.RIPEMD160.wordOrders1[i])];
				d = (d << global::Home.Andir.Cryptography.RIPEMD160.shifts1[i] | d >> 32 - global::Home.Andir.Cryptography.RIPEMD160.shifts1[i]);
				d += c;
				a = (a << 10 | a >> 22);
				c += ((d | ~e) ^ a);
				c += global::Home.Andir.Cryptography.RIPEMD160.constants1[2] + this.buffer[(int)((global::System.UIntPtr)global::Home.Andir.Cryptography.RIPEMD160.wordOrders1[i + 1])];
				c = (c << global::Home.Andir.Cryptography.RIPEMD160.shifts1[i + 1] | c >> 32 - global::Home.Andir.Cryptography.RIPEMD160.shifts1[i + 1]);
				c += b;
				e = (e << 10 | e >> 22);
				b += ((c | ~d) ^ e);
				b += global::Home.Andir.Cryptography.RIPEMD160.constants1[2] + this.buffer[(int)((global::System.UIntPtr)global::Home.Andir.Cryptography.RIPEMD160.wordOrders1[i + 2])];
				b = (b << global::Home.Andir.Cryptography.RIPEMD160.shifts1[i + 2] | b >> 32 - global::Home.Andir.Cryptography.RIPEMD160.shifts1[i + 2]);
				b += a;
				d = (d << 10 | d >> 22);
				a += ((b | ~c) ^ d);
				a += global::Home.Andir.Cryptography.RIPEMD160.constants1[2] + this.buffer[(int)((global::System.UIntPtr)global::Home.Andir.Cryptography.RIPEMD160.wordOrders1[i + 3])];
				a = (a << global::Home.Andir.Cryptography.RIPEMD160.shifts1[i + 3] | a >> 32 - global::Home.Andir.Cryptography.RIPEMD160.shifts1[i + 3]);
				a += e;
				c = (c << 10 | c >> 22);
				e += ((a | ~b) ^ c);
				e += global::Home.Andir.Cryptography.RIPEMD160.constants1[2] + this.buffer[(int)((global::System.UIntPtr)global::Home.Andir.Cryptography.RIPEMD160.wordOrders1[i + 4])];
				e = (e << global::Home.Andir.Cryptography.RIPEMD160.shifts1[i + 4] | e >> 32 - global::Home.Andir.Cryptography.RIPEMD160.shifts1[i + 4]);
				e += d;
				b = (b << 10 | b >> 22);
			}
			d += ((e | ~a) ^ b);
			d += global::Home.Andir.Cryptography.RIPEMD160.constants1[2] + this.buffer[(int)((global::System.UIntPtr)global::Home.Andir.Cryptography.RIPEMD160.wordOrders1[i])];
			d = (d << global::Home.Andir.Cryptography.RIPEMD160.shifts1[i] | d >> 32 - global::Home.Andir.Cryptography.RIPEMD160.shifts1[i]);
			d += c;
			a = (a << 10 | a >> 22);
			for (i = 48; i < 63; i += 5)
			{
				c += ((d & a) | (e & ~a));
				c += global::Home.Andir.Cryptography.RIPEMD160.constants1[3] + this.buffer[(int)((global::System.UIntPtr)global::Home.Andir.Cryptography.RIPEMD160.wordOrders1[i])];
				c = (c << global::Home.Andir.Cryptography.RIPEMD160.shifts1[i] | c >> 32 - global::Home.Andir.Cryptography.RIPEMD160.shifts1[i]);
				c += b;
				e = (e << 10 | e >> 22);
				b += ((c & e) | (d & ~e));
				b += global::Home.Andir.Cryptography.RIPEMD160.constants1[3] + this.buffer[(int)((global::System.UIntPtr)global::Home.Andir.Cryptography.RIPEMD160.wordOrders1[i + 1])];
				b = (b << global::Home.Andir.Cryptography.RIPEMD160.shifts1[i + 1] | b >> 32 - global::Home.Andir.Cryptography.RIPEMD160.shifts1[i + 1]);
				b += a;
				d = (d << 10 | d >> 22);
				a += ((b & d) | (c & ~d));
				a += global::Home.Andir.Cryptography.RIPEMD160.constants1[3] + this.buffer[(int)((global::System.UIntPtr)global::Home.Andir.Cryptography.RIPEMD160.wordOrders1[i + 2])];
				a = (a << global::Home.Andir.Cryptography.RIPEMD160.shifts1[i + 2] | a >> 32 - global::Home.Andir.Cryptography.RIPEMD160.shifts1[i + 2]);
				a += e;
				c = (c << 10 | c >> 22);
				e += ((a & c) | (b & ~c));
				e += global::Home.Andir.Cryptography.RIPEMD160.constants1[3] + this.buffer[(int)((global::System.UIntPtr)global::Home.Andir.Cryptography.RIPEMD160.wordOrders1[i + 3])];
				e = (e << global::Home.Andir.Cryptography.RIPEMD160.shifts1[i + 3] | e >> 32 - global::Home.Andir.Cryptography.RIPEMD160.shifts1[i + 3]);
				e += d;
				b = (b << 10 | b >> 22);
				d += ((e & b) | (a & ~b));
				d += global::Home.Andir.Cryptography.RIPEMD160.constants1[3] + this.buffer[(int)((global::System.UIntPtr)global::Home.Andir.Cryptography.RIPEMD160.wordOrders1[i + 4])];
				d = (d << global::Home.Andir.Cryptography.RIPEMD160.shifts1[i + 4] | d >> 32 - global::Home.Andir.Cryptography.RIPEMD160.shifts1[i + 4]);
				d += c;
				a = (a << 10 | a >> 22);
			}
			c += ((d & a) | (e & ~a));
			c += global::Home.Andir.Cryptography.RIPEMD160.constants1[3] + this.buffer[(int)((global::System.UIntPtr)global::Home.Andir.Cryptography.RIPEMD160.wordOrders1[i])];
			c = (c << global::Home.Andir.Cryptography.RIPEMD160.shifts1[i] | c >> 32 - global::Home.Andir.Cryptography.RIPEMD160.shifts1[i]);
			c += b;
			e = (e << 10 | e >> 22);
			for (i = 64; i < 79; i += 5)
			{
				b += (c ^ (d | ~e));
				b += global::Home.Andir.Cryptography.RIPEMD160.constants1[4] + this.buffer[(int)((global::System.UIntPtr)global::Home.Andir.Cryptography.RIPEMD160.wordOrders1[i])];
				b = (b << global::Home.Andir.Cryptography.RIPEMD160.shifts1[i] | b >> 32 - global::Home.Andir.Cryptography.RIPEMD160.shifts1[i]);
				b += a;
				d = (d << 10 | d >> 22);
				a += (b ^ (c | ~d));
				a += global::Home.Andir.Cryptography.RIPEMD160.constants1[4] + this.buffer[(int)((global::System.UIntPtr)global::Home.Andir.Cryptography.RIPEMD160.wordOrders1[i + 1])];
				a = (a << global::Home.Andir.Cryptography.RIPEMD160.shifts1[i + 1] | a >> 32 - global::Home.Andir.Cryptography.RIPEMD160.shifts1[i + 1]);
				a += e;
				c = (c << 10 | c >> 22);
				e += (a ^ (b | ~c));
				e += global::Home.Andir.Cryptography.RIPEMD160.constants1[4] + this.buffer[(int)((global::System.UIntPtr)global::Home.Andir.Cryptography.RIPEMD160.wordOrders1[i + 2])];
				e = (e << global::Home.Andir.Cryptography.RIPEMD160.shifts1[i + 2] | e >> 32 - global::Home.Andir.Cryptography.RIPEMD160.shifts1[i + 2]);
				e += d;
				b = (b << 10 | b >> 22);
				d += (e ^ (a | ~b));
				d += global::Home.Andir.Cryptography.RIPEMD160.constants1[4] + this.buffer[(int)((global::System.UIntPtr)global::Home.Andir.Cryptography.RIPEMD160.wordOrders1[i + 3])];
				d = (d << global::Home.Andir.Cryptography.RIPEMD160.shifts1[i + 3] | d >> 32 - global::Home.Andir.Cryptography.RIPEMD160.shifts1[i + 3]);
				d += c;
				a = (a << 10 | a >> 22);
				c += (d ^ (e | ~a));
				c += global::Home.Andir.Cryptography.RIPEMD160.constants1[4] + this.buffer[(int)((global::System.UIntPtr)global::Home.Andir.Cryptography.RIPEMD160.wordOrders1[i + 4])];
				c = (c << global::Home.Andir.Cryptography.RIPEMD160.shifts1[i + 4] | c >> 32 - global::Home.Andir.Cryptography.RIPEMD160.shifts1[i + 4]);
				c += b;
				e = (e << 10 | e >> 22);
			}
			b += (c ^ (d | ~e));
			b += global::Home.Andir.Cryptography.RIPEMD160.constants1[4] + this.buffer[(int)((global::System.UIntPtr)global::Home.Andir.Cryptography.RIPEMD160.wordOrders1[i])];
			b = (b << global::Home.Andir.Cryptography.RIPEMD160.shifts1[i] | b >> 32 - global::Home.Andir.Cryptography.RIPEMD160.shifts1[i]);
			b += a;
			d = (d << 10 | d >> 22);
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00008874 File Offset: 0x00007874
		private void MDTransform2(ref uint a, ref uint b, ref uint c, ref uint d, ref uint e)
		{
			int i;
			for (i = 0; i < 15; i += 5)
			{
				a += (b ^ (c | ~d));
				a += global::Home.Andir.Cryptography.RIPEMD160.constants2[0] + this.buffer[(int)((global::System.UIntPtr)global::Home.Andir.Cryptography.RIPEMD160.wordOrders2[i])];
				a = (a << global::Home.Andir.Cryptography.RIPEMD160.shifts2[i] | a >> 32 - global::Home.Andir.Cryptography.RIPEMD160.shifts2[i]);
				a += e;
				c = (c << 10 | c >> 22);
				e += (a ^ (b | ~c));
				e += global::Home.Andir.Cryptography.RIPEMD160.constants2[0] + this.buffer[(int)((global::System.UIntPtr)global::Home.Andir.Cryptography.RIPEMD160.wordOrders2[i + 1])];
				e = (e << global::Home.Andir.Cryptography.RIPEMD160.shifts2[i + 1] | e >> 32 - global::Home.Andir.Cryptography.RIPEMD160.shifts2[i + 1]);
				e += d;
				b = (b << 10 | b >> 22);
				d += (e ^ (a | ~b));
				d += global::Home.Andir.Cryptography.RIPEMD160.constants2[0] + this.buffer[(int)((global::System.UIntPtr)global::Home.Andir.Cryptography.RIPEMD160.wordOrders2[i + 2])];
				d = (d << global::Home.Andir.Cryptography.RIPEMD160.shifts2[i + 2] | d >> 32 - global::Home.Andir.Cryptography.RIPEMD160.shifts2[i + 2]);
				d += c;
				a = (a << 10 | a >> 22);
				c += (d ^ (e | ~a));
				c += global::Home.Andir.Cryptography.RIPEMD160.constants2[0] + this.buffer[(int)((global::System.UIntPtr)global::Home.Andir.Cryptography.RIPEMD160.wordOrders2[i + 3])];
				c = (c << global::Home.Andir.Cryptography.RIPEMD160.shifts2[i + 3] | c >> 32 - global::Home.Andir.Cryptography.RIPEMD160.shifts2[i + 3]);
				c += b;
				e = (e << 10 | e >> 22);
				b += (c ^ (d | ~e));
				b += global::Home.Andir.Cryptography.RIPEMD160.constants2[0] + this.buffer[(int)((global::System.UIntPtr)global::Home.Andir.Cryptography.RIPEMD160.wordOrders2[i + 4])];
				b = (b << global::Home.Andir.Cryptography.RIPEMD160.shifts2[i + 4] | b >> 32 - global::Home.Andir.Cryptography.RIPEMD160.shifts2[i + 4]);
				b += a;
				d = (d << 10 | d >> 22);
			}
			a += (b ^ (c | ~d));
			a += global::Home.Andir.Cryptography.RIPEMD160.constants2[0] + this.buffer[(int)((global::System.UIntPtr)global::Home.Andir.Cryptography.RIPEMD160.wordOrders2[i])];
			a = (a << global::Home.Andir.Cryptography.RIPEMD160.shifts2[i] | a >> 32 - global::Home.Andir.Cryptography.RIPEMD160.shifts2[i]);
			a += e;
			c = (c << 10 | c >> 22);
			for (i = 16; i < 31; i += 5)
			{
				e += ((a & c) | (b & ~c));
				e += global::Home.Andir.Cryptography.RIPEMD160.constants2[1] + this.buffer[(int)((global::System.UIntPtr)global::Home.Andir.Cryptography.RIPEMD160.wordOrders2[i])];
				e = (e << global::Home.Andir.Cryptography.RIPEMD160.shifts2[i] | e >> 32 - global::Home.Andir.Cryptography.RIPEMD160.shifts2[i]);
				e += d;
				b = (b << 10 | b >> 22);
				d += ((e & b) | (a & ~b));
				d += global::Home.Andir.Cryptography.RIPEMD160.constants2[1] + this.buffer[(int)((global::System.UIntPtr)global::Home.Andir.Cryptography.RIPEMD160.wordOrders2[i + 1])];
				d = (d << global::Home.Andir.Cryptography.RIPEMD160.shifts2[i + 1] | d >> 32 - global::Home.Andir.Cryptography.RIPEMD160.shifts2[i + 1]);
				d += c;
				a = (a << 10 | a >> 22);
				c += ((d & a) | (e & ~a));
				c += global::Home.Andir.Cryptography.RIPEMD160.constants2[1] + this.buffer[(int)((global::System.UIntPtr)global::Home.Andir.Cryptography.RIPEMD160.wordOrders2[i + 2])];
				c = (c << global::Home.Andir.Cryptography.RIPEMD160.shifts2[i + 2] | c >> 32 - global::Home.Andir.Cryptography.RIPEMD160.shifts2[i + 2]);
				c += b;
				e = (e << 10 | e >> 22);
				b += ((c & e) | (d & ~e));
				b += global::Home.Andir.Cryptography.RIPEMD160.constants2[1] + this.buffer[(int)((global::System.UIntPtr)global::Home.Andir.Cryptography.RIPEMD160.wordOrders2[i + 3])];
				b = (b << global::Home.Andir.Cryptography.RIPEMD160.shifts2[i + 3] | b >> 32 - global::Home.Andir.Cryptography.RIPEMD160.shifts2[i + 3]);
				b += a;
				d = (d << 10 | d >> 22);
				a += ((b & d) | (c & ~d));
				a += global::Home.Andir.Cryptography.RIPEMD160.constants2[1] + this.buffer[(int)((global::System.UIntPtr)global::Home.Andir.Cryptography.RIPEMD160.wordOrders2[i + 4])];
				a = (a << global::Home.Andir.Cryptography.RIPEMD160.shifts2[i + 4] | a >> 32 - global::Home.Andir.Cryptography.RIPEMD160.shifts2[i + 4]);
				a += e;
				c = (c << 10 | c >> 22);
			}
			e += ((a & c) | (b & ~c));
			e += global::Home.Andir.Cryptography.RIPEMD160.constants2[1] + this.buffer[(int)((global::System.UIntPtr)global::Home.Andir.Cryptography.RIPEMD160.wordOrders2[i])];
			e = (e << global::Home.Andir.Cryptography.RIPEMD160.shifts2[i] | e >> 32 - global::Home.Andir.Cryptography.RIPEMD160.shifts2[i]);
			e += d;
			b = (b << 10 | b >> 22);
			for (i = 32; i < 47; i += 5)
			{
				d += ((e | ~a) ^ b);
				d += global::Home.Andir.Cryptography.RIPEMD160.constants2[2] + this.buffer[(int)((global::System.UIntPtr)global::Home.Andir.Cryptography.RIPEMD160.wordOrders2[i])];
				d = (d << global::Home.Andir.Cryptography.RIPEMD160.shifts2[i] | d >> 32 - global::Home.Andir.Cryptography.RIPEMD160.shifts2[i]);
				d += c;
				a = (a << 10 | a >> 22);
				c += ((d | ~e) ^ a);
				c += global::Home.Andir.Cryptography.RIPEMD160.constants2[2] + this.buffer[(int)((global::System.UIntPtr)global::Home.Andir.Cryptography.RIPEMD160.wordOrders2[i + 1])];
				c = (c << global::Home.Andir.Cryptography.RIPEMD160.shifts2[i + 1] | c >> 32 - global::Home.Andir.Cryptography.RIPEMD160.shifts2[i + 1]);
				c += b;
				e = (e << 10 | e >> 22);
				b += ((c | ~d) ^ e);
				b += global::Home.Andir.Cryptography.RIPEMD160.constants2[2] + this.buffer[(int)((global::System.UIntPtr)global::Home.Andir.Cryptography.RIPEMD160.wordOrders2[i + 2])];
				b = (b << global::Home.Andir.Cryptography.RIPEMD160.shifts2[i + 2] | b >> 32 - global::Home.Andir.Cryptography.RIPEMD160.shifts2[i + 2]);
				b += a;
				d = (d << 10 | d >> 22);
				a += ((b | ~c) ^ d);
				a += global::Home.Andir.Cryptography.RIPEMD160.constants2[2] + this.buffer[(int)((global::System.UIntPtr)global::Home.Andir.Cryptography.RIPEMD160.wordOrders2[i + 3])];
				a = (a << global::Home.Andir.Cryptography.RIPEMD160.shifts2[i + 3] | a >> 32 - global::Home.Andir.Cryptography.RIPEMD160.shifts2[i + 3]);
				a += e;
				c = (c << 10 | c >> 22);
				e += ((a | ~b) ^ c);
				e += global::Home.Andir.Cryptography.RIPEMD160.constants2[2] + this.buffer[(int)((global::System.UIntPtr)global::Home.Andir.Cryptography.RIPEMD160.wordOrders2[i + 4])];
				e = (e << global::Home.Andir.Cryptography.RIPEMD160.shifts2[i + 4] | e >> 32 - global::Home.Andir.Cryptography.RIPEMD160.shifts2[i + 4]);
				e += d;
				b = (b << 10 | b >> 22);
			}
			d += ((e | ~a) ^ b);
			d += global::Home.Andir.Cryptography.RIPEMD160.constants2[2] + this.buffer[(int)((global::System.UIntPtr)global::Home.Andir.Cryptography.RIPEMD160.wordOrders2[i])];
			d = (d << global::Home.Andir.Cryptography.RIPEMD160.shifts2[i] | d >> 32 - global::Home.Andir.Cryptography.RIPEMD160.shifts2[i]);
			d += c;
			a = (a << 10 | a >> 22);
			for (i = 48; i < 63; i += 5)
			{
				c += ((d & e) | (~d & a));
				c += global::Home.Andir.Cryptography.RIPEMD160.constants2[3] + this.buffer[(int)((global::System.UIntPtr)global::Home.Andir.Cryptography.RIPEMD160.wordOrders2[i])];
				c = (c << global::Home.Andir.Cryptography.RIPEMD160.shifts2[i] | c >> 32 - global::Home.Andir.Cryptography.RIPEMD160.shifts2[i]);
				c += b;
				e = (e << 10 | e >> 22);
				b += ((c & d) | (~c & e));
				b += global::Home.Andir.Cryptography.RIPEMD160.constants2[3] + this.buffer[(int)((global::System.UIntPtr)global::Home.Andir.Cryptography.RIPEMD160.wordOrders2[i + 1])];
				b = (b << global::Home.Andir.Cryptography.RIPEMD160.shifts2[i + 1] | b >> 32 - global::Home.Andir.Cryptography.RIPEMD160.shifts2[i + 1]);
				b += a;
				d = (d << 10 | d >> 22);
				a += ((b & c) | (~b & d));
				a += global::Home.Andir.Cryptography.RIPEMD160.constants2[3] + this.buffer[(int)((global::System.UIntPtr)global::Home.Andir.Cryptography.RIPEMD160.wordOrders2[i + 2])];
				a = (a << global::Home.Andir.Cryptography.RIPEMD160.shifts2[i + 2] | a >> 32 - global::Home.Andir.Cryptography.RIPEMD160.shifts2[i + 2]);
				a += e;
				c = (c << 10 | c >> 22);
				e += ((a & b) | (~a & c));
				e += global::Home.Andir.Cryptography.RIPEMD160.constants2[3] + this.buffer[(int)((global::System.UIntPtr)global::Home.Andir.Cryptography.RIPEMD160.wordOrders2[i + 3])];
				e = (e << global::Home.Andir.Cryptography.RIPEMD160.shifts2[i + 3] | e >> 32 - global::Home.Andir.Cryptography.RIPEMD160.shifts2[i + 3]);
				e += d;
				b = (b << 10 | b >> 22);
				d += ((e & a) | (~e & b));
				d += global::Home.Andir.Cryptography.RIPEMD160.constants2[3] + this.buffer[(int)((global::System.UIntPtr)global::Home.Andir.Cryptography.RIPEMD160.wordOrders2[i + 4])];
				d = (d << global::Home.Andir.Cryptography.RIPEMD160.shifts2[i + 4] | d >> 32 - global::Home.Andir.Cryptography.RIPEMD160.shifts2[i + 4]);
				d += c;
				a = (a << 10 | a >> 22);
			}
			c += ((d & e) | (~d & a));
			c += global::Home.Andir.Cryptography.RIPEMD160.constants2[3] + this.buffer[(int)((global::System.UIntPtr)global::Home.Andir.Cryptography.RIPEMD160.wordOrders2[i])];
			c = (c << global::Home.Andir.Cryptography.RIPEMD160.shifts2[i] | c >> 32 - global::Home.Andir.Cryptography.RIPEMD160.shifts2[i]);
			c += b;
			e = (e << 10 | e >> 22);
			for (i = 64; i < 79; i += 5)
			{
				b += (c ^ d ^ e);
				b += global::Home.Andir.Cryptography.RIPEMD160.constants2[4] + this.buffer[(int)((global::System.UIntPtr)global::Home.Andir.Cryptography.RIPEMD160.wordOrders2[i])];
				b = (b << global::Home.Andir.Cryptography.RIPEMD160.shifts2[i] | b >> 32 - global::Home.Andir.Cryptography.RIPEMD160.shifts2[i]);
				b += a;
				d = (d << 10 | d >> 22);
				a += (b ^ c ^ d);
				a += global::Home.Andir.Cryptography.RIPEMD160.constants2[4] + this.buffer[(int)((global::System.UIntPtr)global::Home.Andir.Cryptography.RIPEMD160.wordOrders2[i + 1])];
				a = (a << global::Home.Andir.Cryptography.RIPEMD160.shifts2[i + 1] | a >> 32 - global::Home.Andir.Cryptography.RIPEMD160.shifts2[i + 1]);
				a += e;
				c = (c << 10 | c >> 22);
				e += (a ^ b ^ c);
				e += global::Home.Andir.Cryptography.RIPEMD160.constants2[4] + this.buffer[(int)((global::System.UIntPtr)global::Home.Andir.Cryptography.RIPEMD160.wordOrders2[i + 2])];
				e = (e << global::Home.Andir.Cryptography.RIPEMD160.shifts2[i + 2] | e >> 32 - global::Home.Andir.Cryptography.RIPEMD160.shifts2[i + 2]);
				e += d;
				b = (b << 10 | b >> 22);
				d += (e ^ a ^ b);
				d += global::Home.Andir.Cryptography.RIPEMD160.constants2[4] + this.buffer[(int)((global::System.UIntPtr)global::Home.Andir.Cryptography.RIPEMD160.wordOrders2[i + 3])];
				d = (d << global::Home.Andir.Cryptography.RIPEMD160.shifts2[i + 3] | d >> 32 - global::Home.Andir.Cryptography.RIPEMD160.shifts2[i + 3]);
				d += c;
				a = (a << 10 | a >> 22);
				c += (d ^ e ^ a);
				c += global::Home.Andir.Cryptography.RIPEMD160.constants2[4] + this.buffer[(int)((global::System.UIntPtr)global::Home.Andir.Cryptography.RIPEMD160.wordOrders2[i + 4])];
				c = (c << global::Home.Andir.Cryptography.RIPEMD160.shifts2[i + 4] | c >> 32 - global::Home.Andir.Cryptography.RIPEMD160.shifts2[i + 4]);
				c += b;
				e = (e << 10 | e >> 22);
			}
			b += (c ^ d ^ e);
			b += global::Home.Andir.Cryptography.RIPEMD160.constants2[4] + this.buffer[(int)((global::System.UIntPtr)global::Home.Andir.Cryptography.RIPEMD160.wordOrders2[i])];
			b = (b << global::Home.Andir.Cryptography.RIPEMD160.shifts2[i] | b >> 32 - global::Home.Andir.Cryptography.RIPEMD160.shifts2[i]);
			b += a;
			d = (d << 10 | d >> 22);
		}

		// Token: 0x04000034 RID: 52
		private readonly global::Home.Andir.Cryptography.IntCounter counter = new global::Home.Andir.Cryptography.IntCounter(2);

		// Token: 0x04000035 RID: 53
		private readonly uint[] state = new uint[5];

		// Token: 0x04000036 RID: 54
		private readonly byte[] finalBlock;

		// Token: 0x04000037 RID: 55
		private static readonly uint[] constants1 = new uint[]
		{
			0U,
			1518500249U,
			1859775393U,
			2400959708U,
			2840853838U
		};

		// Token: 0x04000038 RID: 56
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
			2U,
			4U,
			0U,
			5U,
			9U,
			7U,
			12U,
			2U,
			10U,
			14U,
			1U,
			3U,
			8U,
			11U,
			6U,
			15U,
			13U
		};

		// Token: 0x04000039 RID: 57
		private static readonly int[] shifts1 = new int[]
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
			12,
			9,
			15,
			5,
			11,
			6,
			8,
			13,
			12,
			5,
			12,
			13,
			14,
			11,
			8,
			5,
			6
		};

		// Token: 0x0400003A RID: 58
		private static readonly uint[] constants2 = new uint[]
		{
			1352829926U,
			1548603684U,
			1836072691U,
			2053994217U,
			0U
		};

		// Token: 0x0400003B RID: 59
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
			14U,
			12U,
			15U,
			10U,
			4U,
			1U,
			5U,
			8U,
			7U,
			6U,
			2U,
			13U,
			14U,
			0U,
			3U,
			9U,
			11U
		};

		// Token: 0x0400003C RID: 60
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
			8,
			8,
			5,
			12,
			9,
			12,
			5,
			14,
			6,
			8,
			13,
			6,
			5,
			15,
			13,
			11,
			11
		};

		// Token: 0x0400003D RID: 61
		private uint[] buffer = new uint[16];
	}
}
