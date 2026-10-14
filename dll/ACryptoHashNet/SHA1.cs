using System;

namespace Home.Andir.Cryptography
{
	// Token: 0x02000013 RID: 19
	public sealed class SHA1 : global::Home.Andir.Cryptography.BlockHashAlgorithm
	{
		// Token: 0x0600006F RID: 111 RVA: 0x0000A2F8 File Offset: 0x000092F8
		public SHA1() : base(64)
		{
			this.HashSizeValue = 160;
			this.finalBlock = new byte[base.BlockSize];
			this.Initialize();
		}

		// Token: 0x06000070 RID: 112 RVA: 0x0000A354 File Offset: 0x00009354
		public override void Initialize()
		{
			base.Initialize();
			this.counter.Clear();
			global::System.Array.Clear(this.finalBlock, 0, this.finalBlock.Length);
			this.InitializeState();
		}

		// Token: 0x06000071 RID: 113 RVA: 0x0000A384 File Offset: 0x00009384
		private void InitializeState()
		{
			this.state[0] = 1732584193U;
			this.state[1] = 4023233417U;
			this.state[2] = 2562383102U;
			this.state[3] = 271733878U;
			this.state[4] = 3285377520U;
		}

		// Token: 0x06000072 RID: 114 RVA: 0x0000A3D4 File Offset: 0x000093D4
		protected override void ProcessBlock(byte[] array, int offset)
		{
			if (array.Length < offset + base.BlockSize)
			{
				throw new global::System.ArgumentOutOfRangeException("offset");
			}
			this.counter.Add(base.BlockSize << 3);
			global::Home.Andir.Cryptography.BigEndianBuffer.BlockCopy(array, offset, this.buffer, 0, base.BlockSize);
			for (int i = 16; i < 80; i++)
			{
				this.buffer[i] = (this.buffer[i - 3] ^ this.buffer[i - 8] ^ this.buffer[i - 14] ^ this.buffer[i - 16]);
				this.buffer[i] = (this.buffer[i] << 1 | this.buffer[i] >> 31);
			}
			uint num = this.state[0];
			uint num2 = this.state[1];
			uint num3 = this.state[2];
			uint num4 = this.state[3];
			uint num5 = this.state[4];
			for (int j = 0; j < 20; j += 5)
			{
				num5 += this.buffer[j] + global::Home.Andir.Cryptography.SHA1.constants[0];
				num5 += ((num2 & num3) ^ (~num2 & num4));
				num5 += (num << 5 | num >> 27);
				num2 = (num2 << 30 | num2 >> 2);
				num4 += this.buffer[j + 1] + global::Home.Andir.Cryptography.SHA1.constants[0];
				num4 += ((num & num2) ^ (~num & num3));
				num4 += (num5 << 5 | num5 >> 27);
				num = (num << 30 | num >> 2);
				num3 += this.buffer[j + 2] + global::Home.Andir.Cryptography.SHA1.constants[0];
				num3 += ((num5 & num) ^ (~num5 & num2));
				num3 += (num4 << 5 | num4 >> 27);
				num5 = (num5 << 30 | num5 >> 2);
				num2 += this.buffer[j + 3] + global::Home.Andir.Cryptography.SHA1.constants[0];
				num2 += ((num4 & num5) ^ (~num4 & num));
				num2 += (num3 << 5 | num3 >> 27);
				num4 = (num4 << 30 | num4 >> 2);
				num += this.buffer[j + 4] + global::Home.Andir.Cryptography.SHA1.constants[0];
				num += ((num3 & num4) ^ (~num3 & num5));
				num += (num2 << 5 | num2 >> 27);
				num3 = (num3 << 30 | num3 >> 2);
			}
			for (int k = 20; k < 40; k += 5)
			{
				num5 += this.buffer[k] + global::Home.Andir.Cryptography.SHA1.constants[1];
				num5 += (num2 ^ num3 ^ num4);
				num5 += (num << 5 | num >> 27);
				num2 = (num2 << 30 | num2 >> 2);
				num4 += this.buffer[k + 1] + global::Home.Andir.Cryptography.SHA1.constants[1];
				num4 += (num ^ num2 ^ num3);
				num4 += (num5 << 5 | num5 >> 27);
				num = (num << 30 | num >> 2);
				num3 += this.buffer[k + 2] + global::Home.Andir.Cryptography.SHA1.constants[1];
				num3 += (num5 ^ num ^ num2);
				num3 += (num4 << 5 | num4 >> 27);
				num5 = (num5 << 30 | num5 >> 2);
				num2 += this.buffer[k + 3] + global::Home.Andir.Cryptography.SHA1.constants[1];
				num2 += (num4 ^ num5 ^ num);
				num2 += (num3 << 5 | num3 >> 27);
				num4 = (num4 << 30 | num4 >> 2);
				num += this.buffer[k + 4] + global::Home.Andir.Cryptography.SHA1.constants[1];
				num += (num3 ^ num4 ^ num5);
				num += (num2 << 5 | num2 >> 27);
				num3 = (num3 << 30 | num3 >> 2);
			}
			for (int l = 40; l < 60; l += 5)
			{
				num5 += this.buffer[l] + global::Home.Andir.Cryptography.SHA1.constants[2];
				num5 += ((num2 & num3) ^ (num2 & num4) ^ (num3 & num4));
				num5 += (num << 5 | num >> 27);
				num2 = (num2 << 30 | num2 >> 2);
				num4 += this.buffer[l + 1] + global::Home.Andir.Cryptography.SHA1.constants[2];
				num4 += ((num & num2) ^ (num & num3) ^ (num2 & num3));
				num4 += (num5 << 5 | num5 >> 27);
				num = (num << 30 | num >> 2);
				num3 += this.buffer[l + 2] + global::Home.Andir.Cryptography.SHA1.constants[2];
				num3 += ((num5 & num) ^ (num5 & num2) ^ (num & num2));
				num3 += (num4 << 5 | num4 >> 27);
				num5 = (num5 << 30 | num5 >> 2);
				num2 += this.buffer[l + 3] + global::Home.Andir.Cryptography.SHA1.constants[2];
				num2 += ((num4 & num5) ^ (num4 & num) ^ (num5 & num));
				num2 += (num3 << 5 | num3 >> 27);
				num4 = (num4 << 30 | num4 >> 2);
				num += this.buffer[l + 4] + global::Home.Andir.Cryptography.SHA1.constants[2];
				num += ((num3 & num4) ^ (num3 & num5) ^ (num4 & num5));
				num += (num2 << 5 | num2 >> 27);
				num3 = (num3 << 30 | num3 >> 2);
			}
			for (int m = 60; m < 80; m += 5)
			{
				num5 += this.buffer[m] + global::Home.Andir.Cryptography.SHA1.constants[3];
				num5 += (num2 ^ num3 ^ num4);
				num5 += (num << 5 | num >> 27);
				num2 = (num2 << 30 | num2 >> 2);
				num4 += this.buffer[m + 1] + global::Home.Andir.Cryptography.SHA1.constants[3];
				num4 += (num ^ num2 ^ num3);
				num4 += (num5 << 5 | num5 >> 27);
				num = (num << 30 | num >> 2);
				num3 += this.buffer[m + 2] + global::Home.Andir.Cryptography.SHA1.constants[3];
				num3 += (num5 ^ num ^ num2);
				num3 += (num4 << 5 | num4 >> 27);
				num5 = (num5 << 30 | num5 >> 2);
				num2 += this.buffer[m + 3] + global::Home.Andir.Cryptography.SHA1.constants[3];
				num2 += (num4 ^ num5 ^ num);
				num2 += (num3 << 5 | num3 >> 27);
				num4 = (num4 << 30 | num4 >> 2);
				num += this.buffer[m + 4] + global::Home.Andir.Cryptography.SHA1.constants[3];
				num += (num3 ^ num4 ^ num5);
				num += (num2 << 5 | num2 >> 27);
				num3 = (num3 << 30 | num3 >> 2);
			}
			this.state[0] += num;
			this.state[1] += num2;
			this.state[2] += num3;
			this.state[3] += num4;
			this.state[4] += num5;
		}

		// Token: 0x06000073 RID: 115 RVA: 0x0000AA14 File Offset: 0x00009A14
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
				this.finalBlock[num + i] = bytes[7 - i];
			}
			this.ProcessBlock(this.finalBlock, 0);
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000074 RID: 116 RVA: 0x0000AAD4 File Offset: 0x00009AD4
		protected override byte[] Result
		{
			get
			{
				byte[] array = new byte[20];
				global::Home.Andir.Cryptography.BigEndianBuffer.BlockCopy(this.state, 0, array, 0, array.Length);
				return array;
			}
		}

		// Token: 0x04000043 RID: 67
		private readonly global::Home.Andir.Cryptography.IntCounter counter = new global::Home.Andir.Cryptography.IntCounter(2);

		// Token: 0x04000044 RID: 68
		private readonly uint[] state = new uint[5];

		// Token: 0x04000045 RID: 69
		private readonly byte[] finalBlock;

		// Token: 0x04000046 RID: 70
		private static readonly uint[] constants = new uint[]
		{
			1518500249U,
			1859775393U,
			2400959708U,
			3395469782U
		};

		// Token: 0x04000047 RID: 71
		private uint[] buffer = new uint[80];
	}
}
