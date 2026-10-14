using System;

namespace Home.Andir.Cryptography
{
	// Token: 0x02000014 RID: 20
	public sealed class SHA256 : global::Home.Andir.Cryptography.BlockHashAlgorithm
	{
		// Token: 0x06000076 RID: 118 RVA: 0x0000AB28 File Offset: 0x00009B28
		public SHA256() : base(64)
		{
			this.HashSizeValue = 256;
			this.finalBlock = new byte[base.BlockSize];
			this.Initialize();
		}

		// Token: 0x06000077 RID: 119 RVA: 0x0000AB84 File Offset: 0x00009B84
		public override void Initialize()
		{
			base.Initialize();
			this.counter.Clear();
			global::System.Array.Clear(this.finalBlock, 0, this.finalBlock.Length);
			this.InitializeState();
		}

		// Token: 0x06000078 RID: 120 RVA: 0x0000ABB4 File Offset: 0x00009BB4
		private void InitializeState()
		{
			this.state[0] = 1779033703U;
			this.state[1] = 3144134277U;
			this.state[2] = 1013904242U;
			this.state[3] = 2773480762U;
			this.state[4] = 1359893119U;
			this.state[5] = 2600822924U;
			this.state[6] = 528734635U;
			this.state[7] = 1541459225U;
		}

		// Token: 0x06000079 RID: 121 RVA: 0x0000AC2C File Offset: 0x00009C2C
		protected override void ProcessBlock(byte[] array, int offset)
		{
			if (array.Length < offset + base.BlockSize)
			{
				throw new global::System.ArgumentOutOfRangeException("offset");
			}
			this.counter.Add(base.BlockSize << 3);
			global::Home.Andir.Cryptography.BigEndianBuffer.BlockCopy(array, offset, this.buffer, 0, base.BlockSize);
			for (int i = 16; i < 64; i++)
			{
				this.buffer[i] = this.Ro1(this.buffer[i - 2]) + this.buffer[i - 7] + this.Ro0(this.buffer[i - 15]) + this.buffer[i - 16];
			}
			uint num = this.state[0];
			uint num2 = this.state[1];
			uint num3 = this.state[2];
			uint num4 = this.state[3];
			uint num5 = this.state[4];
			uint num6 = this.state[5];
			uint num7 = this.state[6];
			uint num8 = this.state[7];
			for (int j = 0; j < this.buffer.Length; j += 8)
			{
				num8 += global::Home.Andir.Cryptography.SHA256.constants[j] + this.buffer[j];
				num8 += ((num5 & num6) ^ (~num5 & num7));
				num8 += this.Sig1(num5);
				num4 += num8;
				num8 += ((num & num2) ^ (num & num3) ^ (num2 & num3));
				num8 += this.Sig0(num);
				num7 += global::Home.Andir.Cryptography.SHA256.constants[j + 1] + this.buffer[j + 1];
				num7 += ((num4 & num5) ^ (~num4 & num6));
				num7 += this.Sig1(num4);
				num3 += num7;
				num7 += ((num8 & num) ^ (num8 & num2) ^ (num & num2));
				num7 += this.Sig0(num8);
				num6 += global::Home.Andir.Cryptography.SHA256.constants[j + 2] + this.buffer[j + 2];
				num6 += ((num3 & num4) ^ (~num3 & num5));
				num6 += this.Sig1(num3);
				num2 += num6;
				num6 += ((num7 & num8) ^ (num7 & num) ^ (num8 & num));
				num6 += this.Sig0(num7);
				num5 += global::Home.Andir.Cryptography.SHA256.constants[j + 3] + this.buffer[j + 3];
				num5 += ((num2 & num3) ^ (~num2 & num4));
				num5 += this.Sig1(num2);
				num += num5;
				num5 += ((num6 & num7) ^ (num6 & num8) ^ (num7 & num8));
				num5 += this.Sig0(num6);
				num4 += global::Home.Andir.Cryptography.SHA256.constants[j + 4] + this.buffer[j + 4];
				num4 += ((num & num2) ^ (~num & num3));
				num4 += this.Sig1(num);
				num8 += num4;
				num4 += ((num5 & num6) ^ (num5 & num7) ^ (num6 & num7));
				num4 += this.Sig0(num5);
				num3 += global::Home.Andir.Cryptography.SHA256.constants[j + 5] + this.buffer[j + 5];
				num3 += ((num8 & num) ^ (~num8 & num2));
				num3 += this.Sig1(num8);
				num7 += num3;
				num3 += ((num4 & num5) ^ (num4 & num6) ^ (num5 & num6));
				num3 += this.Sig0(num4);
				num2 += global::Home.Andir.Cryptography.SHA256.constants[j + 6] + this.buffer[j + 6];
				num2 += ((num7 & num8) ^ (~num7 & num));
				num2 += this.Sig1(num7);
				num6 += num2;
				num2 += ((num3 & num4) ^ (num3 & num5) ^ (num4 & num5));
				num2 += this.Sig0(num3);
				num += global::Home.Andir.Cryptography.SHA256.constants[j + 7] + this.buffer[j + 7];
				num += ((num6 & num7) ^ (~num6 & num8));
				num += this.Sig1(num6);
				num5 += num;
				num += ((num2 & num3) ^ (num2 & num4) ^ (num3 & num4));
				num += this.Sig0(num2);
			}
			this.state[0] += num;
			this.state[1] += num2;
			this.state[2] += num3;
			this.state[3] += num4;
			this.state[4] += num5;
			this.state[5] += num6;
			this.state[6] += num7;
			this.state[7] += num8;
		}

		// Token: 0x0600007A RID: 122 RVA: 0x0000B0C8 File Offset: 0x0000A0C8
		protected override void ProcessFinalBlock(byte[] array, int offset, int length)
		{
			if (length >= base.BlockSize || length > array.Length - offset)
			{
				throw new global::System.ArgumentOutOfRangeException("length");
			}
			this.counter.Add(length << 3);
			byte[] bytes = this.counter.GetBytes();
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

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600007B RID: 123 RVA: 0x0000B180 File Offset: 0x0000A180
		protected override byte[] Result
		{
			get
			{
				byte[] array = new byte[32];
				global::Home.Andir.Cryptography.BigEndianBuffer.BlockCopy(this.state, 0, array, 0, array.Length);
				return array;
			}
		}

		// Token: 0x0600007C RID: 124 RVA: 0x0000B1A7 File Offset: 0x0000A1A7
		private uint Ro0(uint x)
		{
			return (x >> 7 | x << 25) ^ (x >> 18 | x << 14) ^ x >> 3;
		}

		// Token: 0x0600007D RID: 125 RVA: 0x0000B1BF File Offset: 0x0000A1BF
		private uint Ro1(uint x)
		{
			return (x >> 17 | x << 15) ^ (x >> 19 | x << 13) ^ x >> 10;
		}

		// Token: 0x0600007E RID: 126 RVA: 0x0000B1D9 File Offset: 0x0000A1D9
		private uint Sig0(uint x)
		{
			return (x >> 2 | x << 30) ^ (x >> 13 | x << 19) ^ (x >> 22 | x << 10);
		}

		// Token: 0x0600007F RID: 127 RVA: 0x0000B1F7 File Offset: 0x0000A1F7
		private uint Sig1(uint x)
		{
			return (x >> 6 | x << 26) ^ (x >> 11 | x << 21) ^ (x >> 25 | x << 7);
		}

		// Token: 0x04000048 RID: 72
		private readonly global::Home.Andir.Cryptography.IntCounter counter = new global::Home.Andir.Cryptography.IntCounter(2);

		// Token: 0x04000049 RID: 73
		private readonly uint[] state = new uint[8];

		// Token: 0x0400004A RID: 74
		private readonly byte[] finalBlock;

		// Token: 0x0400004B RID: 75
		private static readonly uint[] constants = new uint[]
		{
			1116352408U,
			1899447441U,
			3049323471U,
			3921009573U,
			961987163U,
			1508970993U,
			2453635748U,
			2870763221U,
			3624381080U,
			310598401U,
			607225278U,
			1426881987U,
			1925078388U,
			2162078206U,
			2614888103U,
			3248222580U,
			3835390401U,
			4022224774U,
			264347078U,
			604807628U,
			770255983U,
			1249150122U,
			1555081692U,
			1996064986U,
			2554220882U,
			2821834349U,
			2952996808U,
			3210313671U,
			3336571891U,
			3584528711U,
			113926993U,
			338241895U,
			666307205U,
			773529912U,
			1294757372U,
			1396182291U,
			1695183700U,
			1986661051U,
			2177026350U,
			2456956037U,
			2730485921U,
			2820302411U,
			3259730800U,
			3345764771U,
			3516065817U,
			3600352804U,
			4094571909U,
			275423344U,
			430227734U,
			506948616U,
			659060556U,
			883997877U,
			958139571U,
			1322822218U,
			1537002063U,
			1747873779U,
			1955562222U,
			2024104815U,
			2227730452U,
			2361852424U,
			2428436474U,
			2756734187U,
			3204031479U,
			3329325298U
		};

		// Token: 0x0400004C RID: 76
		private uint[] buffer = new uint[64];
	}
}
