using System;

namespace Home.Andir.Cryptography
{
	// Token: 0x0200000E RID: 14
	public sealed class MD4 : global::Home.Andir.Cryptography.BlockHashAlgorithm
	{
		// Token: 0x06000048 RID: 72 RVA: 0x00005A1C File Offset: 0x00004A1C
		public MD4() : base(64)
		{
			this.HashSizeValue = 128;
			this.finalBlock = new byte[base.BlockSize];
			this.Initialize();
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00005A78 File Offset: 0x00004A78
		public override void Initialize()
		{
			base.Initialize();
			this.counter.Clear();
			global::System.Array.Clear(this.finalBlock, 0, this.finalBlock.Length);
			this.InitializeState();
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00005AA5 File Offset: 0x00004AA5
		private void InitializeState()
		{
			this.state[0] = 1732584193U;
			this.state[1] = 4023233417U;
			this.state[2] = 2562383102U;
			this.state[3] = 271733878U;
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00005ADC File Offset: 0x00004ADC
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
				num += this.buffer[i] + global::Home.Andir.Cryptography.MD4.constants[0];
				num += ((num2 & num3) | (~num2 & num4));
				num = (num << 3 | num >> 29);
				num4 += this.buffer[i + 1] + global::Home.Andir.Cryptography.MD4.constants[0];
				num4 += ((num & num2) | (~num & num3));
				num4 = (num4 << 7 | num4 >> 25);
				num3 += this.buffer[i + 2] + global::Home.Andir.Cryptography.MD4.constants[0];
				num3 += ((num4 & num) | (~num4 & num2));
				num3 = (num3 << 11 | num3 >> 21);
				num2 += this.buffer[i + 3] + global::Home.Andir.Cryptography.MD4.constants[0];
				num2 += ((num3 & num4) | (~num3 & num));
				num2 = (num2 << 19 | num2 >> 13);
			}
			int j = 16;
			int num5 = 0;
			while (j < 32)
			{
				num += this.buffer[num5] + global::Home.Andir.Cryptography.MD4.constants[1];
				num += ((num2 & num3) | (num2 & num4) | (num3 & num4));
				num = (num << 3 | num >> 29);
				num4 += this.buffer[num5 + 4] + global::Home.Andir.Cryptography.MD4.constants[1];
				num4 += ((num & num2) | (num & num3) | (num2 & num3));
				num4 = (num4 << 5 | num4 >> 27);
				num3 += this.buffer[num5 + 8] + global::Home.Andir.Cryptography.MD4.constants[1];
				num3 += ((num4 & num) | (num4 & num2) | (num & num2));
				num3 = (num3 << 9 | num3 >> 23);
				num2 += this.buffer[num5 + 12] + global::Home.Andir.Cryptography.MD4.constants[1];
				num2 += ((num3 & num4) | (num3 & num) | (num4 & num));
				num2 = (num2 << 13 | num2 >> 19);
				j += 4;
				num5++;
			}
			int k = 32;
			int num6 = 0;
			while (k < 48)
			{
				int num7 = (num6 << 1) + -3 * (num6 >> 1);
				num += this.buffer[num7] + global::Home.Andir.Cryptography.MD4.constants[2];
				num += (num2 ^ num3 ^ num4);
				num = (num << 3 | num >> 29);
				num4 += this.buffer[num7 + 8] + global::Home.Andir.Cryptography.MD4.constants[2];
				num4 += (num ^ num2 ^ num3);
				num4 = (num4 << 9 | num4 >> 23);
				num3 += this.buffer[num7 + 4] + global::Home.Andir.Cryptography.MD4.constants[2];
				num3 += (num4 ^ num ^ num2);
				num3 = (num3 << 11 | num3 >> 21);
				num2 += this.buffer[num7 + 12] + global::Home.Andir.Cryptography.MD4.constants[2];
				num2 += (num3 ^ num4 ^ num);
				num2 = (num2 << 15 | num2 >> 17);
				k += 4;
				num6++;
			}
			this.state[0] += num;
			this.state[1] += num2;
			this.state[2] += num3;
			this.state[3] += num4;
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00005E14 File Offset: 0x00004E14
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

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600004D RID: 77 RVA: 0x00005ED4 File Offset: 0x00004ED4
		protected override byte[] Result
		{
			get
			{
				byte[] array = new byte[16];
				global::System.Buffer.BlockCopy(this.state, 0, array, 0, array.Length);
				return array;
			}
		}

		// Token: 0x04000020 RID: 32
		private global::Home.Andir.Cryptography.IntCounter counter = new global::Home.Andir.Cryptography.IntCounter(2);

		// Token: 0x04000021 RID: 33
		private readonly uint[] state = new uint[4];

		// Token: 0x04000022 RID: 34
		private readonly byte[] finalBlock;

		// Token: 0x04000023 RID: 35
		private static readonly uint[] constants = new uint[]
		{
			0U,
			1518500249U,
			1859775393U
		};

		// Token: 0x04000024 RID: 36
		private uint[] buffer = new uint[16];
	}
}
