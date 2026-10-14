using System;

namespace Home.Andir.Cryptography
{
	// Token: 0x0200000F RID: 15
	public sealed class MD5 : global::Home.Andir.Cryptography.BlockHashAlgorithm
	{
		// Token: 0x0600004F RID: 79 RVA: 0x00005F28 File Offset: 0x00004F28
		public MD5() : base(64)
		{
			this.HashSizeValue = 128;
			this.finalBlock = new byte[base.BlockSize];
			this.Initialize();
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00005F84 File Offset: 0x00004F84
		public override void Initialize()
		{
			base.Initialize();
			this.counter.Clear();
			global::System.Array.Clear(this.finalBlock, 0, this.finalBlock.Length);
			this.InitializeState();
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00005FB1 File Offset: 0x00004FB1
		private void InitializeState()
		{
			this.state[0] = 1732584193U;
			this.state[1] = 4023233417U;
			this.state[2] = 2562383102U;
			this.state[3] = 271733878U;
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00005FE8 File Offset: 0x00004FE8
		protected override void ProcessBlock(byte[] array, int offset)
		{
			if (array.Length < offset + base.BlockSize)
			{
				throw new global::System.ArgumentOutOfRangeException("offset");
			}
			this.counter.Add(base.BlockSize << 3);
			global::System.Buffer.BlockCopy(array, offset, this.buffer, 0, base.BlockSize);
			uint num = this.state[0];
			uint num2 = this.state[1];
			uint num3 = this.state[2];
			uint num4 = this.state[3];
			for (int i = 0; i < 16; i += 4)
			{
				num += this.buffer[i] + global::Home.Andir.Cryptography.MD5.constants[i];
				num += ((num2 & num3) | (~num2 & num4));
				num = (num << 7 | num >> 25);
				num += num2;
				num4 += this.buffer[i + 1] + global::Home.Andir.Cryptography.MD5.constants[i + 1];
				num4 += ((num & num2) | (~num & num3));
				num4 = (num4 << 12 | num4 >> 20);
				num4 += num;
				num3 += this.buffer[i + 2] + global::Home.Andir.Cryptography.MD5.constants[i + 2];
				num3 += ((num4 & num) | (~num4 & num2));
				num3 = (num3 << 17 | num3 >> 15);
				num3 += num4;
				num2 += this.buffer[i + 3] + global::Home.Andir.Cryptography.MD5.constants[i + 3];
				num2 += ((num3 & num4) | (~num3 & num));
				num2 = (num2 << 22 | num2 >> 10);
				num2 += num3;
			}
			for (int j = 16; j < 32; j += 4)
			{
				num += this.buffer[j * 5 + 1 & 15] + global::Home.Andir.Cryptography.MD5.constants[j];
				num += ((num2 & num4) | (num3 & ~num4));
				num = (num << 5 | num >> 27);
				num += num2;
				num4 += this.buffer[(j + 1) * 5 + 1 & 15] + global::Home.Andir.Cryptography.MD5.constants[j + 1];
				num4 += ((num & num3) | (num2 & ~num3));
				num4 = (num4 << 9 | num4 >> 23);
				num4 += num;
				num3 += this.buffer[(j + 2) * 5 + 1 & 15] + global::Home.Andir.Cryptography.MD5.constants[j + 2];
				num3 += ((num4 & num2) | (num & ~num2));
				num3 = (num3 << 14 | num3 >> 18);
				num3 += num4;
				num2 += this.buffer[(j + 3) * 5 + 1 & 15] + global::Home.Andir.Cryptography.MD5.constants[j + 3];
				num2 += ((num3 & num) | (num4 & ~num));
				num2 = (num2 << 20 | num2 >> 12);
				num2 += num3;
			}
			for (int k = 32; k < 48; k += 4)
			{
				num += this.buffer[k * 3 + 5 & 15] + global::Home.Andir.Cryptography.MD5.constants[k];
				num += (num2 ^ num3 ^ num4);
				num = (num << 4 | num >> 28);
				num += num2;
				num4 += this.buffer[(k + 1) * 3 + 5 & 15] + global::Home.Andir.Cryptography.MD5.constants[k + 1];
				num4 += (num ^ num2 ^ num3);
				num4 = (num4 << 11 | num4 >> 21);
				num4 += num;
				num3 += this.buffer[(k + 2) * 3 + 5 & 15] + global::Home.Andir.Cryptography.MD5.constants[k + 2];
				num3 += (num4 ^ num ^ num2);
				num3 = (num3 << 16 | num3 >> 16);
				num3 += num4;
				num2 += this.buffer[(k + 3) * 3 + 5 & 15] + global::Home.Andir.Cryptography.MD5.constants[k + 3];
				num2 += (num3 ^ num4 ^ num);
				num2 = (num2 << 23 | num2 >> 9);
				num2 += num3;
			}
			for (int l = 48; l < 64; l += 4)
			{
				num += this.buffer[l * 7 & 15] + global::Home.Andir.Cryptography.MD5.constants[l];
				num += (num3 ^ (num2 | ~num4));
				num = (num << 6 | num >> 26);
				num += num2;
				num4 += this.buffer[(l + 1) * 7 & 15] + global::Home.Andir.Cryptography.MD5.constants[l + 1];
				num4 += (num2 ^ (num | ~num3));
				num4 = (num4 << 10 | num4 >> 22);
				num4 += num;
				num3 += this.buffer[(l + 2) * 7 & 15] + global::Home.Andir.Cryptography.MD5.constants[l + 2];
				num3 += (num ^ (num4 | ~num2));
				num3 = (num3 << 15 | num3 >> 17);
				num3 += num4;
				num2 += this.buffer[(l + 3) * 7 & 15] + global::Home.Andir.Cryptography.MD5.constants[l + 3];
				num2 += (num4 ^ (num3 | ~num));
				num2 = (num2 << 21 | num2 >> 11);
				num2 += num3;
			}
			this.state[0] += num;
			this.state[1] += num2;
			this.state[2] += num3;
			this.state[3] += num4;
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00006460 File Offset: 0x00005460
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

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000054 RID: 84 RVA: 0x00006520 File Offset: 0x00005520
		protected override byte[] Result
		{
			get
			{
				byte[] array = new byte[16];
				global::System.Buffer.BlockCopy(this.state, 0, array, 0, array.Length);
				return array;
			}
		}

		// Token: 0x04000025 RID: 37
		private readonly global::Home.Andir.Cryptography.IntCounter counter = new global::Home.Andir.Cryptography.IntCounter(2);

		// Token: 0x04000026 RID: 38
		private readonly uint[] state = new uint[4];

		// Token: 0x04000027 RID: 39
		private readonly byte[] finalBlock;

		// Token: 0x04000028 RID: 40
		private static readonly uint[] constants = new uint[]
		{
			3614090360U,
			3905402710U,
			606105819U,
			3250441966U,
			4118548399U,
			1200080426U,
			2821735955U,
			4249261313U,
			1770035416U,
			2336552879U,
			4294925233U,
			2304563134U,
			1804603682U,
			4254626195U,
			2792965006U,
			1236535329U,
			4129170786U,
			3225465664U,
			643717713U,
			3921069994U,
			3593408605U,
			38016083U,
			3634488961U,
			3889429448U,
			568446438U,
			3275163606U,
			4107603335U,
			1163531501U,
			2850285829U,
			4243563512U,
			1735328473U,
			2368359562U,
			4294588738U,
			2272392833U,
			1839030562U,
			4259657740U,
			2763975236U,
			1272893353U,
			4139469664U,
			3200236656U,
			681279174U,
			3936430074U,
			3572445317U,
			76029189U,
			3654602809U,
			3873151461U,
			530742520U,
			3299628645U,
			4096336452U,
			1126891415U,
			2878612391U,
			4237533241U,
			1700485571U,
			2399980690U,
			4293915773U,
			2240044497U,
			1873313359U,
			4264355552U,
			2734768916U,
			1309151649U,
			4149444226U,
			3174756917U,
			718787259U,
			3951481745U
		};

		// Token: 0x04000029 RID: 41
		private uint[] buffer = new uint[16];
	}
}
