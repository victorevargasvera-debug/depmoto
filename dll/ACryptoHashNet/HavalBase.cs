using System;

namespace Home.Andir.Cryptography
{
	// Token: 0x02000004 RID: 4
	public class HavalBase : global::Home.Andir.Cryptography.BlockHashAlgorithm
	{
		// Token: 0x0600000E RID: 14 RVA: 0x0000242C File Offset: 0x0000142C
		public HavalBase(global::Home.Andir.Cryptography.HavalHashSize havalHashSize, global::Home.Andir.Cryptography.HavalPassCount havalPassCount) : base(128)
		{
			this.havalHashSize = havalHashSize;
			this.havalPassCount = havalPassCount;
			this.HashSizeValue = (int)havalHashSize;
			this.signature[0] = (byte)((int)(havalHashSize & (global::Home.Andir.Cryptography.HavalHashSize)3) << 6 | (global::Home.Andir.Cryptography.HavalHashSize)((int)(havalPassCount & (global::Home.Andir.Cryptography.HavalPassCount)7) << 3) | (global::Home.Andir.Cryptography.HavalHashSize)1);
			this.signature[1] = (byte)(havalHashSize >> 2 & (global::Home.Andir.Cryptography.HavalHashSize)255);
			this.finalBlock = new byte[base.BlockSize];
			this.InitializeALL();
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000024D0 File Offset: 0x000014D0
		public void InitializeALL()
		{
			base.Initialize();
			this.counter.Clear();
			global::System.Array.Clear(this.finalBlock, 0, this.finalBlock.Length);
			this.InitializeState();
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002500 File Offset: 0x00001500
		private void InitializeState()
		{
			this.state[0] = 608135816U;
			this.state[1] = 2242054355U;
			this.state[2] = 320440878U;
			this.state[3] = 57701188U;
			this.state[4] = 2752067618U;
			this.state[5] = 698298832U;
			this.state[6] = 137296536U;
			this.state[7] = 3964562569U;
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002578 File Offset: 0x00001578
		protected override void ProcessBlock(byte[] array, int offset)
		{
			this.counter.Add(base.BlockSize << 3);
			global::System.Buffer.BlockCopy(array, offset, this.buffer, 0, base.BlockSize);
			for (int i = 32; i < this.buffer.Length; i++)
			{
				this.buffer[i] = this.buffer[(int)((global::System.UIntPtr)global::Home.Andir.Cryptography.HavalBase.wordOrders[i - 32])];
			}
			switch (this.havalPassCount)
			{
			case global::Home.Andir.Cryptography.HavalPassCount.Pass3:
				this.ProcessBlock3Pass();
				return;
			case global::Home.Andir.Cryptography.HavalPassCount.Pass4:
				this.ProcessBlock4Pass();
				return;
			case global::Home.Andir.Cryptography.HavalPassCount.Pass5:
				this.ProcessBlock5Pass();
				return;
			default:
				return;
			}
		}

		// Token: 0x06000012 RID: 18 RVA: 0x0000260C File Offset: 0x0000160C
		protected override void ProcessFinalBlock(byte[] array, int offset, int length)
		{
			if (length >= base.BlockSize || length > array.Length - offset)
			{
				throw new global::System.ArgumentOutOfRangeException("length");
			}
			this.counter.Add(length << 3);
			byte[] bytes = this.counter.GetBytes();
			global::System.Buffer.BlockCopy(array, offset, this.finalBlock, 0, length);
			this.finalBlock[length] = 1;
			int num = base.BlockSize - 10;
			if (length >= num)
			{
				this.ProcessBlock(this.finalBlock, 0);
				global::System.Array.Clear(this.finalBlock, 0, this.finalBlock.Length);
			}
			this.finalBlock[num] = this.signature[0];
			this.finalBlock[num + 1] = this.signature[1];
			num += 2;
			for (int i = 0; i < 8; i++)
			{
				this.finalBlock[num + i] = bytes[i];
			}
			this.ProcessBlock(this.finalBlock, 0);
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000013 RID: 19 RVA: 0x000026E4 File Offset: 0x000016E4
		protected override byte[] Result
		{
			get
			{
				global::Home.Andir.Cryptography.HavalHashSize havalHashSize = this.havalHashSize;
				if (havalHashSize <= global::Home.Andir.Cryptography.HavalHashSize.HashSize160)
				{
					if (havalHashSize != global::Home.Andir.Cryptography.HavalHashSize.HashSize128)
					{
						if (havalHashSize == global::Home.Andir.Cryptography.HavalHashSize.HashSize160)
						{
							this.TailorResult160();
						}
					}
					else
					{
						this.TailorResult128();
					}
				}
				else if (havalHashSize != global::Home.Andir.Cryptography.HavalHashSize.HashSize192)
				{
					if (havalHashSize != global::Home.Andir.Cryptography.HavalHashSize.HashSize224)
					{
						if (havalHashSize != global::Home.Andir.Cryptography.HavalHashSize.HashSize256)
						{
						}
					}
					else
					{
						this.TailorResult224();
					}
				}
				else
				{
					this.TailorResult192();
				}
				byte[] array = new byte[(int)(this.havalHashSize >> 3)];
				global::System.Buffer.BlockCopy(this.state, 0, array, 0, array.Length);
				return array;
			}
		}

		// Token: 0x06000014 RID: 20 RVA: 0x0000276C File Offset: 0x0000176C
		private void ProcessBlock3Pass()
		{
			uint num = this.state[0];
			uint num2 = this.state[1];
			uint num3 = this.state[2];
			uint num4 = this.state[3];
			uint num5 = this.state[4];
			uint num6 = this.state[5];
			uint num7 = this.state[6];
			uint num8 = this.state[7];
			for (int i = 0; i < 32; i += 8)
			{
				uint num9 = this.F1phi3(num7, num6, num5, num4, num3, num2, num);
				num8 = (num8 >> 11 | num8 << 21);
				num8 += (num9 >> 7 | num9 << 25);
				num8 += this.buffer[i];
				num9 = this.F1phi3(num6, num5, num4, num3, num2, num, num8);
				num7 = (num7 >> 11 | num7 << 21);
				num7 += (num9 >> 7 | num9 << 25);
				num7 += this.buffer[i + 1];
				num9 = this.F1phi3(num5, num4, num3, num2, num, num8, num7);
				num6 = (num6 >> 11 | num6 << 21);
				num6 += (num9 >> 7 | num9 << 25);
				num6 += this.buffer[i + 2];
				num9 = this.F1phi3(num4, num3, num2, num, num8, num7, num6);
				num5 = (num5 >> 11 | num5 << 21);
				num5 += (num9 >> 7 | num9 << 25);
				num5 += this.buffer[i + 3];
				num9 = this.F1phi3(num3, num2, num, num8, num7, num6, num5);
				num4 = (num4 >> 11 | num4 << 21);
				num4 += (num9 >> 7 | num9 << 25);
				num4 += this.buffer[i + 4];
				num9 = this.F1phi3(num2, num, num8, num7, num6, num5, num4);
				num3 = (num3 >> 11 | num3 << 21);
				num3 += (num9 >> 7 | num9 << 25);
				num3 += this.buffer[i + 5];
				num9 = this.F1phi3(num, num8, num7, num6, num5, num4, num3);
				num2 = (num2 >> 11 | num2 << 21);
				num2 += (num9 >> 7 | num9 << 25);
				num2 += this.buffer[i + 6];
				num9 = this.F1phi3(num8, num7, num6, num5, num4, num3, num2);
				num = (num >> 11 | num << 21);
				num += (num9 >> 7 | num9 << 25);
				num += this.buffer[i + 7];
			}
			for (int j = 32; j < 64; j += 8)
			{
				uint num9 = this.F2phi3(num7, num6, num5, num4, num3, num2, num);
				num8 = (num8 >> 11 | num8 << 21);
				num8 += (num9 >> 7 | num9 << 25);
				num8 += this.buffer[j] + global::Home.Andir.Cryptography.HavalBase.constants[j - 32];
				num9 = this.F2phi3(num6, num5, num4, num3, num2, num, num8);
				num7 = (num7 >> 11 | num7 << 21);
				num7 += (num9 >> 7 | num9 << 25);
				num7 += this.buffer[j + 1] + global::Home.Andir.Cryptography.HavalBase.constants[j + 1 - 32];
				num9 = this.F2phi3(num5, num4, num3, num2, num, num8, num7);
				num6 = (num6 >> 11 | num6 << 21);
				num6 += (num9 >> 7 | num9 << 25);
				num6 += this.buffer[j + 2] + global::Home.Andir.Cryptography.HavalBase.constants[j + 2 - 32];
				num9 = this.F2phi3(num4, num3, num2, num, num8, num7, num6);
				num5 = (num5 >> 11 | num5 << 21);
				num5 += (num9 >> 7 | num9 << 25);
				num5 += this.buffer[j + 3] + global::Home.Andir.Cryptography.HavalBase.constants[j + 3 - 32];
				num9 = this.F2phi3(num3, num2, num, num8, num7, num6, num5);
				num4 = (num4 >> 11 | num4 << 21);
				num4 += (num9 >> 7 | num9 << 25);
				num4 += this.buffer[j + 4] + global::Home.Andir.Cryptography.HavalBase.constants[j + 4 - 32];
				num9 = this.F2phi3(num2, num, num8, num7, num6, num5, num4);
				num3 = (num3 >> 11 | num3 << 21);
				num3 += (num9 >> 7 | num9 << 25);
				num3 += this.buffer[j + 5] + global::Home.Andir.Cryptography.HavalBase.constants[j + 5 - 32];
				num9 = this.F2phi3(num, num8, num7, num6, num5, num4, num3);
				num2 = (num2 >> 11 | num2 << 21);
				num2 += (num9 >> 7 | num9 << 25);
				num2 += this.buffer[j + 6] + global::Home.Andir.Cryptography.HavalBase.constants[j + 6 - 32];
				num9 = this.F2phi3(num8, num7, num6, num5, num4, num3, num2);
				num = (num >> 11 | num << 21);
				num += (num9 >> 7 | num9 << 25);
				num += this.buffer[j + 7] + global::Home.Andir.Cryptography.HavalBase.constants[j + 7 - 32];
			}
			for (int k = 64; k < 96; k += 8)
			{
				uint num9 = this.F3phi3(num7, num6, num5, num4, num3, num2, num);
				num8 = (num8 >> 11 | num8 << 21);
				num8 += (num9 >> 7 | num9 << 25);
				num8 += this.buffer[k] + global::Home.Andir.Cryptography.HavalBase.constants[k - 32];
				num9 = this.F3phi3(num6, num5, num4, num3, num2, num, num8);
				num7 = (num7 >> 11 | num7 << 21);
				num7 += (num9 >> 7 | num9 << 25);
				num7 += this.buffer[k + 1] + global::Home.Andir.Cryptography.HavalBase.constants[k + 1 - 32];
				num9 = this.F3phi3(num5, num4, num3, num2, num, num8, num7);
				num6 = (num6 >> 11 | num6 << 21);
				num6 += (num9 >> 7 | num9 << 25);
				num6 += this.buffer[k + 2] + global::Home.Andir.Cryptography.HavalBase.constants[k + 2 - 32];
				num9 = this.F3phi3(num4, num3, num2, num, num8, num7, num6);
				num5 = (num5 >> 11 | num5 << 21);
				num5 += (num9 >> 7 | num9 << 25);
				num5 += this.buffer[k + 3] + global::Home.Andir.Cryptography.HavalBase.constants[k + 3 - 32];
				num9 = this.F3phi3(num3, num2, num, num8, num7, num6, num5);
				num4 = (num4 >> 11 | num4 << 21);
				num4 += (num9 >> 7 | num9 << 25);
				num4 += this.buffer[k + 4] + global::Home.Andir.Cryptography.HavalBase.constants[k + 4 - 32];
				num9 = this.F3phi3(num2, num, num8, num7, num6, num5, num4);
				num3 = (num3 >> 11 | num3 << 21);
				num3 += (num9 >> 7 | num9 << 25);
				num3 += this.buffer[k + 5] + global::Home.Andir.Cryptography.HavalBase.constants[k + 5 - 32];
				num9 = this.F3phi3(num, num8, num7, num6, num5, num4, num3);
				num2 = (num2 >> 11 | num2 << 21);
				num2 += (num9 >> 7 | num9 << 25);
				num2 += this.buffer[k + 6] + global::Home.Andir.Cryptography.HavalBase.constants[k + 6 - 32];
				num9 = this.F3phi3(num8, num7, num6, num5, num4, num3, num2);
				num = (num >> 11 | num << 21);
				num += (num9 >> 7 | num9 << 25);
				num += this.buffer[k + 7] + global::Home.Andir.Cryptography.HavalBase.constants[k + 7 - 32];
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

		// Token: 0x06000015 RID: 21 RVA: 0x00002F3C File Offset: 0x00001F3C
		private void ProcessBlock4Pass()
		{
			uint num = this.state[0];
			uint num2 = this.state[1];
			uint num3 = this.state[2];
			uint num4 = this.state[3];
			uint num5 = this.state[4];
			uint num6 = this.state[5];
			uint num7 = this.state[6];
			uint num8 = this.state[7];
			for (int i = 0; i < 32; i += 8)
			{
				uint num9 = this.F1phi4(num7, num6, num5, num4, num3, num2, num);
				num8 = (num8 >> 11 | num8 << 21);
				num8 += (num9 >> 7 | num9 << 25);
				num8 += this.buffer[i];
				num9 = this.F1phi4(num6, num5, num4, num3, num2, num, num8);
				num7 = (num7 >> 11 | num7 << 21);
				num7 += (num9 >> 7 | num9 << 25);
				num7 += this.buffer[i + 1];
				num9 = this.F1phi4(num5, num4, num3, num2, num, num8, num7);
				num6 = (num6 >> 11 | num6 << 21);
				num6 += (num9 >> 7 | num9 << 25);
				num6 += this.buffer[i + 2];
				num9 = this.F1phi4(num4, num3, num2, num, num8, num7, num6);
				num5 = (num5 >> 11 | num5 << 21);
				num5 += (num9 >> 7 | num9 << 25);
				num5 += this.buffer[i + 3];
				num9 = this.F1phi4(num3, num2, num, num8, num7, num6, num5);
				num4 = (num4 >> 11 | num4 << 21);
				num4 += (num9 >> 7 | num9 << 25);
				num4 += this.buffer[i + 4];
				num9 = this.F1phi4(num2, num, num8, num7, num6, num5, num4);
				num3 = (num3 >> 11 | num3 << 21);
				num3 += (num9 >> 7 | num9 << 25);
				num3 += this.buffer[i + 5];
				num9 = this.F1phi4(num, num8, num7, num6, num5, num4, num3);
				num2 = (num2 >> 11 | num2 << 21);
				num2 += (num9 >> 7 | num9 << 25);
				num2 += this.buffer[i + 6];
				num9 = this.F1phi4(num8, num7, num6, num5, num4, num3, num2);
				num = (num >> 11 | num << 21);
				num += (num9 >> 7 | num9 << 25);
				num += this.buffer[i + 7];
			}
			for (int j = 32; j < 64; j += 8)
			{
				uint num9 = this.F2phi4(num7, num6, num5, num4, num3, num2, num);
				num8 = (num8 >> 11 | num8 << 21);
				num8 += (num9 >> 7 | num9 << 25);
				num8 += this.buffer[j] + global::Home.Andir.Cryptography.HavalBase.constants[j - 32];
				num9 = this.F2phi4(num6, num5, num4, num3, num2, num, num8);
				num7 = (num7 >> 11 | num7 << 21);
				num7 += (num9 >> 7 | num9 << 25);
				num7 += this.buffer[j + 1] + global::Home.Andir.Cryptography.HavalBase.constants[j + 1 - 32];
				num9 = this.F2phi4(num5, num4, num3, num2, num, num8, num7);
				num6 = (num6 >> 11 | num6 << 21);
				num6 += (num9 >> 7 | num9 << 25);
				num6 += this.buffer[j + 2] + global::Home.Andir.Cryptography.HavalBase.constants[j + 2 - 32];
				num9 = this.F2phi4(num4, num3, num2, num, num8, num7, num6);
				num5 = (num5 >> 11 | num5 << 21);
				num5 += (num9 >> 7 | num9 << 25);
				num5 += this.buffer[j + 3] + global::Home.Andir.Cryptography.HavalBase.constants[j + 3 - 32];
				num9 = this.F2phi4(num3, num2, num, num8, num7, num6, num5);
				num4 = (num4 >> 11 | num4 << 21);
				num4 += (num9 >> 7 | num9 << 25);
				num4 += this.buffer[j + 4] + global::Home.Andir.Cryptography.HavalBase.constants[j + 4 - 32];
				num9 = this.F2phi4(num2, num, num8, num7, num6, num5, num4);
				num3 = (num3 >> 11 | num3 << 21);
				num3 += (num9 >> 7 | num9 << 25);
				num3 += this.buffer[j + 5] + global::Home.Andir.Cryptography.HavalBase.constants[j + 5 - 32];
				num9 = this.F2phi4(num, num8, num7, num6, num5, num4, num3);
				num2 = (num2 >> 11 | num2 << 21);
				num2 += (num9 >> 7 | num9 << 25);
				num2 += this.buffer[j + 6] + global::Home.Andir.Cryptography.HavalBase.constants[j + 6 - 32];
				num9 = this.F2phi4(num8, num7, num6, num5, num4, num3, num2);
				num = (num >> 11 | num << 21);
				num += (num9 >> 7 | num9 << 25);
				num += this.buffer[j + 7] + global::Home.Andir.Cryptography.HavalBase.constants[j + 7 - 32];
			}
			for (int k = 64; k < 96; k += 8)
			{
				uint num9 = this.F3phi4(num7, num6, num5, num4, num3, num2, num);
				num8 = (num8 >> 11 | num8 << 21);
				num8 += (num9 >> 7 | num9 << 25);
				num8 += this.buffer[k] + global::Home.Andir.Cryptography.HavalBase.constants[k - 32];
				num9 = this.F3phi4(num6, num5, num4, num3, num2, num, num8);
				num7 = (num7 >> 11 | num7 << 21);
				num7 += (num9 >> 7 | num9 << 25);
				num7 += this.buffer[k + 1] + global::Home.Andir.Cryptography.HavalBase.constants[k + 1 - 32];
				num9 = this.F3phi4(num5, num4, num3, num2, num, num8, num7);
				num6 = (num6 >> 11 | num6 << 21);
				num6 += (num9 >> 7 | num9 << 25);
				num6 += this.buffer[k + 2] + global::Home.Andir.Cryptography.HavalBase.constants[k + 2 - 32];
				num9 = this.F3phi4(num4, num3, num2, num, num8, num7, num6);
				num5 = (num5 >> 11 | num5 << 21);
				num5 += (num9 >> 7 | num9 << 25);
				num5 += this.buffer[k + 3] + global::Home.Andir.Cryptography.HavalBase.constants[k + 3 - 32];
				num9 = this.F3phi4(num3, num2, num, num8, num7, num6, num5);
				num4 = (num4 >> 11 | num4 << 21);
				num4 += (num9 >> 7 | num9 << 25);
				num4 += this.buffer[k + 4] + global::Home.Andir.Cryptography.HavalBase.constants[k + 4 - 32];
				num9 = this.F3phi4(num2, num, num8, num7, num6, num5, num4);
				num3 = (num3 >> 11 | num3 << 21);
				num3 += (num9 >> 7 | num9 << 25);
				num3 += this.buffer[k + 5] + global::Home.Andir.Cryptography.HavalBase.constants[k + 5 - 32];
				num9 = this.F3phi4(num, num8, num7, num6, num5, num4, num3);
				num2 = (num2 >> 11 | num2 << 21);
				num2 += (num9 >> 7 | num9 << 25);
				num2 += this.buffer[k + 6] + global::Home.Andir.Cryptography.HavalBase.constants[k + 6 - 32];
				num9 = this.F3phi4(num8, num7, num6, num5, num4, num3, num2);
				num = (num >> 11 | num << 21);
				num += (num9 >> 7 | num9 << 25);
				num += this.buffer[k + 7] + global::Home.Andir.Cryptography.HavalBase.constants[k + 7 - 32];
			}
			for (int l = 96; l < 128; l += 8)
			{
				uint num9 = this.F4phi4(num7, num6, num5, num4, num3, num2, num);
				num8 = (num8 >> 11 | num8 << 21);
				num8 += (num9 >> 7 | num9 << 25);
				num8 += this.buffer[l] + global::Home.Andir.Cryptography.HavalBase.constants[l - 32];
				num9 = this.F4phi4(num6, num5, num4, num3, num2, num, num8);
				num7 = (num7 >> 11 | num7 << 21);
				num7 += (num9 >> 7 | num9 << 25);
				num7 += this.buffer[l + 1] + global::Home.Andir.Cryptography.HavalBase.constants[l + 1 - 32];
				num9 = this.F4phi4(num5, num4, num3, num2, num, num8, num7);
				num6 = (num6 >> 11 | num6 << 21);
				num6 += (num9 >> 7 | num9 << 25);
				num6 += this.buffer[l + 2] + global::Home.Andir.Cryptography.HavalBase.constants[l + 2 - 32];
				num9 = this.F4phi4(num4, num3, num2, num, num8, num7, num6);
				num5 = (num5 >> 11 | num5 << 21);
				num5 += (num9 >> 7 | num9 << 25);
				num5 += this.buffer[l + 3] + global::Home.Andir.Cryptography.HavalBase.constants[l + 3 - 32];
				num9 = this.F4phi4(num3, num2, num, num8, num7, num6, num5);
				num4 = (num4 >> 11 | num4 << 21);
				num4 += (num9 >> 7 | num9 << 25);
				num4 += this.buffer[l + 4] + global::Home.Andir.Cryptography.HavalBase.constants[l + 4 - 32];
				num9 = this.F4phi4(num2, num, num8, num7, num6, num5, num4);
				num3 = (num3 >> 11 | num3 << 21);
				num3 += (num9 >> 7 | num9 << 25);
				num3 += this.buffer[l + 5] + global::Home.Andir.Cryptography.HavalBase.constants[l + 5 - 32];
				num9 = this.F4phi4(num, num8, num7, num6, num5, num4, num3);
				num2 = (num2 >> 11 | num2 << 21);
				num2 += (num9 >> 7 | num9 << 25);
				num2 += this.buffer[l + 6] + global::Home.Andir.Cryptography.HavalBase.constants[l + 6 - 32];
				num9 = this.F4phi4(num8, num7, num6, num5, num4, num3, num2);
				num = (num >> 11 | num << 21);
				num += (num9 >> 7 | num9 << 25);
				num += this.buffer[l + 7] + global::Home.Andir.Cryptography.HavalBase.constants[l + 7 - 32];
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

		// Token: 0x06000016 RID: 22 RVA: 0x00003968 File Offset: 0x00002968
		private void ProcessBlock5Pass()
		{
			uint num = this.state[0];
			uint num2 = this.state[1];
			uint num3 = this.state[2];
			uint num4 = this.state[3];
			uint num5 = this.state[4];
			uint num6 = this.state[5];
			uint num7 = this.state[6];
			uint num8 = this.state[7];
			for (int i = 0; i < 32; i += 8)
			{
				uint num9 = this.F1phi5(num7, num6, num5, num4, num3, num2, num);
				num8 = (num8 >> 11 | num8 << 21);
				num8 += (num9 >> 7 | num9 << 25);
				num8 += this.buffer[i];
				num9 = this.F1phi5(num6, num5, num4, num3, num2, num, num8);
				num7 = (num7 >> 11 | num7 << 21);
				num7 += (num9 >> 7 | num9 << 25);
				num7 += this.buffer[i + 1];
				num9 = this.F1phi5(num5, num4, num3, num2, num, num8, num7);
				num6 = (num6 >> 11 | num6 << 21);
				num6 += (num9 >> 7 | num9 << 25);
				num6 += this.buffer[i + 2];
				num9 = this.F1phi5(num4, num3, num2, num, num8, num7, num6);
				num5 = (num5 >> 11 | num5 << 21);
				num5 += (num9 >> 7 | num9 << 25);
				num5 += this.buffer[i + 3];
				num9 = this.F1phi5(num3, num2, num, num8, num7, num6, num5);
				num4 = (num4 >> 11 | num4 << 21);
				num4 += (num9 >> 7 | num9 << 25);
				num4 += this.buffer[i + 4];
				num9 = this.F1phi5(num2, num, num8, num7, num6, num5, num4);
				num3 = (num3 >> 11 | num3 << 21);
				num3 += (num9 >> 7 | num9 << 25);
				num3 += this.buffer[i + 5];
				num9 = this.F1phi5(num, num8, num7, num6, num5, num4, num3);
				num2 = (num2 >> 11 | num2 << 21);
				num2 += (num9 >> 7 | num9 << 25);
				num2 += this.buffer[i + 6];
				num9 = this.F1phi5(num8, num7, num6, num5, num4, num3, num2);
				num = (num >> 11 | num << 21);
				num += (num9 >> 7 | num9 << 25);
				num += this.buffer[i + 7];
			}
			for (int j = 32; j < 64; j += 8)
			{
				uint num9 = this.F2phi5(num7, num6, num5, num4, num3, num2, num);
				num8 = (num8 >> 11 | num8 << 21);
				num8 += (num9 >> 7 | num9 << 25);
				num8 += this.buffer[j] + global::Home.Andir.Cryptography.HavalBase.constants[j - 32];
				num9 = this.F2phi5(num6, num5, num4, num3, num2, num, num8);
				num7 = (num7 >> 11 | num7 << 21);
				num7 += (num9 >> 7 | num9 << 25);
				num7 += this.buffer[j + 1] + global::Home.Andir.Cryptography.HavalBase.constants[j + 1 - 32];
				num9 = this.F2phi5(num5, num4, num3, num2, num, num8, num7);
				num6 = (num6 >> 11 | num6 << 21);
				num6 += (num9 >> 7 | num9 << 25);
				num6 += this.buffer[j + 2] + global::Home.Andir.Cryptography.HavalBase.constants[j + 2 - 32];
				num9 = this.F2phi5(num4, num3, num2, num, num8, num7, num6);
				num5 = (num5 >> 11 | num5 << 21);
				num5 += (num9 >> 7 | num9 << 25);
				num5 += this.buffer[j + 3] + global::Home.Andir.Cryptography.HavalBase.constants[j + 3 - 32];
				num9 = this.F2phi5(num3, num2, num, num8, num7, num6, num5);
				num4 = (num4 >> 11 | num4 << 21);
				num4 += (num9 >> 7 | num9 << 25);
				num4 += this.buffer[j + 4] + global::Home.Andir.Cryptography.HavalBase.constants[j + 4 - 32];
				num9 = this.F2phi5(num2, num, num8, num7, num6, num5, num4);
				num3 = (num3 >> 11 | num3 << 21);
				num3 += (num9 >> 7 | num9 << 25);
				num3 += this.buffer[j + 5] + global::Home.Andir.Cryptography.HavalBase.constants[j + 5 - 32];
				num9 = this.F2phi5(num, num8, num7, num6, num5, num4, num3);
				num2 = (num2 >> 11 | num2 << 21);
				num2 += (num9 >> 7 | num9 << 25);
				num2 += this.buffer[j + 6] + global::Home.Andir.Cryptography.HavalBase.constants[j + 6 - 32];
				num9 = this.F2phi5(num8, num7, num6, num5, num4, num3, num2);
				num = (num >> 11 | num << 21);
				num += (num9 >> 7 | num9 << 25);
				num += this.buffer[j + 7] + global::Home.Andir.Cryptography.HavalBase.constants[j + 7 - 32];
			}
			for (int k = 64; k < 96; k += 8)
			{
				uint num9 = this.F3phi5(num7, num6, num5, num4, num3, num2, num);
				num8 = (num8 >> 11 | num8 << 21);
				num8 += (num9 >> 7 | num9 << 25);
				num8 += this.buffer[k] + global::Home.Andir.Cryptography.HavalBase.constants[k - 32];
				num9 = this.F3phi5(num6, num5, num4, num3, num2, num, num8);
				num7 = (num7 >> 11 | num7 << 21);
				num7 += (num9 >> 7 | num9 << 25);
				num7 += this.buffer[k + 1] + global::Home.Andir.Cryptography.HavalBase.constants[k + 1 - 32];
				num9 = this.F3phi5(num5, num4, num3, num2, num, num8, num7);
				num6 = (num6 >> 11 | num6 << 21);
				num6 += (num9 >> 7 | num9 << 25);
				num6 += this.buffer[k + 2] + global::Home.Andir.Cryptography.HavalBase.constants[k + 2 - 32];
				num9 = this.F3phi5(num4, num3, num2, num, num8, num7, num6);
				num5 = (num5 >> 11 | num5 << 21);
				num5 += (num9 >> 7 | num9 << 25);
				num5 += this.buffer[k + 3] + global::Home.Andir.Cryptography.HavalBase.constants[k + 3 - 32];
				num9 = this.F3phi5(num3, num2, num, num8, num7, num6, num5);
				num4 = (num4 >> 11 | num4 << 21);
				num4 += (num9 >> 7 | num9 << 25);
				num4 += this.buffer[k + 4] + global::Home.Andir.Cryptography.HavalBase.constants[k + 4 - 32];
				num9 = this.F3phi5(num2, num, num8, num7, num6, num5, num4);
				num3 = (num3 >> 11 | num3 << 21);
				num3 += (num9 >> 7 | num9 << 25);
				num3 += this.buffer[k + 5] + global::Home.Andir.Cryptography.HavalBase.constants[k + 5 - 32];
				num9 = this.F3phi5(num, num8, num7, num6, num5, num4, num3);
				num2 = (num2 >> 11 | num2 << 21);
				num2 += (num9 >> 7 | num9 << 25);
				num2 += this.buffer[k + 6] + global::Home.Andir.Cryptography.HavalBase.constants[k + 6 - 32];
				num9 = this.F3phi5(num8, num7, num6, num5, num4, num3, num2);
				num = (num >> 11 | num << 21);
				num += (num9 >> 7 | num9 << 25);
				num += this.buffer[k + 7] + global::Home.Andir.Cryptography.HavalBase.constants[k + 7 - 32];
			}
			for (int l = 96; l < 128; l += 8)
			{
				uint num9 = this.F4phi5(num7, num6, num5, num4, num3, num2, num);
				num8 = (num8 >> 11 | num8 << 21);
				num8 += (num9 >> 7 | num9 << 25);
				num8 += this.buffer[l] + global::Home.Andir.Cryptography.HavalBase.constants[l - 32];
				num9 = this.F4phi5(num6, num5, num4, num3, num2, num, num8);
				num7 = (num7 >> 11 | num7 << 21);
				num7 += (num9 >> 7 | num9 << 25);
				num7 += this.buffer[l + 1] + global::Home.Andir.Cryptography.HavalBase.constants[l + 1 - 32];
				num9 = this.F4phi5(num5, num4, num3, num2, num, num8, num7);
				num6 = (num6 >> 11 | num6 << 21);
				num6 += (num9 >> 7 | num9 << 25);
				num6 += this.buffer[l + 2] + global::Home.Andir.Cryptography.HavalBase.constants[l + 2 - 32];
				num9 = this.F4phi5(num4, num3, num2, num, num8, num7, num6);
				num5 = (num5 >> 11 | num5 << 21);
				num5 += (num9 >> 7 | num9 << 25);
				num5 += this.buffer[l + 3] + global::Home.Andir.Cryptography.HavalBase.constants[l + 3 - 32];
				num9 = this.F4phi5(num3, num2, num, num8, num7, num6, num5);
				num4 = (num4 >> 11 | num4 << 21);
				num4 += (num9 >> 7 | num9 << 25);
				num4 += this.buffer[l + 4] + global::Home.Andir.Cryptography.HavalBase.constants[l + 4 - 32];
				num9 = this.F4phi5(num2, num, num8, num7, num6, num5, num4);
				num3 = (num3 >> 11 | num3 << 21);
				num3 += (num9 >> 7 | num9 << 25);
				num3 += this.buffer[l + 5] + global::Home.Andir.Cryptography.HavalBase.constants[l + 5 - 32];
				num9 = this.F4phi5(num, num8, num7, num6, num5, num4, num3);
				num2 = (num2 >> 11 | num2 << 21);
				num2 += (num9 >> 7 | num9 << 25);
				num2 += this.buffer[l + 6] + global::Home.Andir.Cryptography.HavalBase.constants[l + 6 - 32];
				num9 = this.F4phi5(num8, num7, num6, num5, num4, num3, num2);
				num = (num >> 11 | num << 21);
				num += (num9 >> 7 | num9 << 25);
				num += this.buffer[l + 7] + global::Home.Andir.Cryptography.HavalBase.constants[l + 7 - 32];
			}
			for (int m = 128; m < 160; m += 8)
			{
				uint num9 = this.F5phi5(num7, num6, num5, num4, num3, num2, num);
				num8 = (num8 >> 11 | num8 << 21);
				num8 += (num9 >> 7 | num9 << 25);
				num8 += this.buffer[m] + global::Home.Andir.Cryptography.HavalBase.constants[m - 32];
				num9 = this.F5phi5(num6, num5, num4, num3, num2, num, num8);
				num7 = (num7 >> 11 | num7 << 21);
				num7 += (num9 >> 7 | num9 << 25);
				num7 += this.buffer[m + 1] + global::Home.Andir.Cryptography.HavalBase.constants[m + 1 - 32];
				num9 = this.F5phi5(num5, num4, num3, num2, num, num8, num7);
				num6 = (num6 >> 11 | num6 << 21);
				num6 += (num9 >> 7 | num9 << 25);
				num6 += this.buffer[m + 2] + global::Home.Andir.Cryptography.HavalBase.constants[m + 2 - 32];
				num9 = this.F5phi5(num4, num3, num2, num, num8, num7, num6);
				num5 = (num5 >> 11 | num5 << 21);
				num5 += (num9 >> 7 | num9 << 25);
				num5 += this.buffer[m + 3] + global::Home.Andir.Cryptography.HavalBase.constants[m + 3 - 32];
				num9 = this.F5phi5(num3, num2, num, num8, num7, num6, num5);
				num4 = (num4 >> 11 | num4 << 21);
				num4 += (num9 >> 7 | num9 << 25);
				num4 += this.buffer[m + 4] + global::Home.Andir.Cryptography.HavalBase.constants[m + 4 - 32];
				num9 = this.F5phi5(num2, num, num8, num7, num6, num5, num4);
				num3 = (num3 >> 11 | num3 << 21);
				num3 += (num9 >> 7 | num9 << 25);
				num3 += this.buffer[m + 5] + global::Home.Andir.Cryptography.HavalBase.constants[m + 5 - 32];
				num9 = this.F5phi5(num, num8, num7, num6, num5, num4, num3);
				num2 = (num2 >> 11 | num2 << 21);
				num2 += (num9 >> 7 | num9 << 25);
				num2 += this.buffer[m + 6] + global::Home.Andir.Cryptography.HavalBase.constants[m + 6 - 32];
				num9 = this.F5phi5(num8, num7, num6, num5, num4, num3, num2);
				num = (num >> 11 | num << 21);
				num += (num9 >> 7 | num9 << 25);
				num += this.buffer[m + 7] + global::Home.Andir.Cryptography.HavalBase.constants[m + 7 - 32];
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

		// Token: 0x06000017 RID: 23 RVA: 0x000045F8 File Offset: 0x000035F8
		private void TailorResult128()
		{
			uint num = (this.state[7] & 255U) | (this.state[6] & 4278190080U) | (this.state[5] & 16711680U) | (this.state[4] & 65280U);
			this.state[0] += (num >> 8 | num << 24);
			num = ((this.state[7] & 65280U) | (this.state[6] & 255U) | (this.state[5] & 4278190080U) | (this.state[4] & 16711680U));
			this.state[1] += (num >> 16 | num << 16);
			num = ((this.state[7] & 16711680U) | (this.state[6] & 65280U) | (this.state[5] & 255U) | (this.state[4] & 4278190080U));
			this.state[2] += (num >> 24 | num << 8);
			num = ((this.state[7] & 4278190080U) | (this.state[6] & 16711680U) | (this.state[5] & 65280U) | (this.state[4] & 255U));
			this.state[3] += num;
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00004770 File Offset: 0x00003770
		private void TailorResult160()
		{
			uint num = (this.state[7] & 63U) | (this.state[6] & 4261412864U) | (this.state[5] & 33030144U);
			this.state[0] += (num >> 19 | num << 13);
			num = ((this.state[7] & 4032U) | (this.state[6] & 63U) | (this.state[5] & 4261412864U));
			this.state[1] += (num >> 25 | num << 7);
			num = ((this.state[7] & 520192U) | (this.state[6] & 4032U) | (this.state[5] & 63U));
			this.state[2] += num;
			num = ((this.state[7] & 33030144U) | (this.state[6] & 520192U) | (this.state[5] & 4032U));
			this.state[3] += num >> 6;
			num = ((this.state[7] & 4261412864U) | (this.state[6] & 33030144U) | (this.state[5] & 520192U));
			this.state[4] += num >> 12;
		}

		// Token: 0x06000019 RID: 25 RVA: 0x000048E8 File Offset: 0x000038E8
		private void TailorResult192()
		{
			uint num = (this.state[7] & 31U) | (this.state[6] & 4227858432U);
			this.state[0] += (num >> 26 | num << 6);
			num = ((this.state[7] & 992U) | (this.state[6] & 31U));
			this.state[1] += num;
			num = ((this.state[7] & 64512U) | (this.state[6] & 992U));
			this.state[2] += num >> 5;
			num = ((this.state[7] & 2031616U) | (this.state[6] & 64512U));
			this.state[3] += num >> 10;
			num = ((this.state[7] & 65011712U) | (this.state[6] & 2031616U));
			this.state[4] += num >> 16;
			num = ((this.state[7] & 4227858432U) | (this.state[6] & 65011712U));
			this.state[5] += num >> 21;
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00004A4C File Offset: 0x00003A4C
		private void TailorResult224()
		{
			this.state[0] += (this.state[7] >> 27 & 31U);
			this.state[1] += (this.state[7] >> 22 & 31U);
			this.state[2] += (this.state[7] >> 18 & 15U);
			this.state[3] += (this.state[7] >> 13 & 31U);
			this.state[4] += (this.state[7] >> 9 & 15U);
			this.state[5] += (this.state[7] >> 4 & 31U);
			this.state[6] += (this.state[7] & 15U);
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00004B5F File Offset: 0x00003B5F
		private uint F1phi3(uint x6, uint x5, uint x4, uint x3, uint x2, uint x1, uint x0)
		{
			return this.f1(x1, x0, x3, x5, x6, x2, x4);
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00004B72 File Offset: 0x00003B72
		private uint F2phi3(uint x6, uint x5, uint x4, uint x3, uint x2, uint x1, uint x0)
		{
			return this.f2(x4, x2, x1, x0, x5, x3, x6);
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00004B85 File Offset: 0x00003B85
		private uint F3phi3(uint x6, uint x5, uint x4, uint x3, uint x2, uint x1, uint x0)
		{
			return this.f3(x6, x1, x2, x3, x4, x5, x0);
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00004B98 File Offset: 0x00003B98
		private uint F1phi4(uint x6, uint x5, uint x4, uint x3, uint x2, uint x1, uint x0)
		{
			return this.f1(x2, x6, x1, x4, x5, x3, x0);
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00004BAB File Offset: 0x00003BAB
		private uint F2phi4(uint x6, uint x5, uint x4, uint x3, uint x2, uint x1, uint x0)
		{
			return this.f2(x3, x5, x2, x0, x1, x6, x4);
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00004BBE File Offset: 0x00003BBE
		private uint F3phi4(uint x6, uint x5, uint x4, uint x3, uint x2, uint x1, uint x0)
		{
			return this.f3(x1, x4, x3, x6, x0, x2, x5);
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00004BD1 File Offset: 0x00003BD1
		private uint F4phi4(uint x6, uint x5, uint x4, uint x3, uint x2, uint x1, uint x0)
		{
			return this.f4(x6, x4, x0, x5, x2, x1, x3);
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00004BE4 File Offset: 0x00003BE4
		private uint F1phi5(uint x6, uint x5, uint x4, uint x3, uint x2, uint x1, uint x0)
		{
			return this.f1(x3, x4, x1, x0, x5, x2, x6);
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00004BF7 File Offset: 0x00003BF7
		private uint F2phi5(uint x6, uint x5, uint x4, uint x3, uint x2, uint x1, uint x0)
		{
			return this.f2(x6, x2, x1, x0, x3, x4, x5);
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00004C0A File Offset: 0x00003C0A
		private uint F3phi5(uint x6, uint x5, uint x4, uint x3, uint x2, uint x1, uint x0)
		{
			return this.f3(x2, x6, x0, x4, x3, x1, x5);
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00004C1D File Offset: 0x00003C1D
		private uint F4phi5(uint x6, uint x5, uint x4, uint x3, uint x2, uint x1, uint x0)
		{
			return this.f4(x1, x5, x3, x2, x0, x4, x6);
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00004C30 File Offset: 0x00003C30
		private uint F5phi5(uint x6, uint x5, uint x4, uint x3, uint x2, uint x1, uint x0)
		{
			return this.f5(x2, x5, x0, x6, x4, x3, x1);
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00004C43 File Offset: 0x00003C43
		protected uint f1(uint x6, uint x5, uint x4, uint x3, uint x2, uint x1, uint x0)
		{
			return (x1 & (x0 ^ x4)) ^ (x2 & x5) ^ (x3 & x6) ^ x0;
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00004C59 File Offset: 0x00003C59
		protected uint f2(uint x6, uint x5, uint x4, uint x3, uint x2, uint x1, uint x0)
		{
			return (x2 & ((x1 & ~x3) ^ (x4 & x5) ^ x6 ^ x0)) ^ (x4 & (x1 ^ x5)) ^ (x3 & x5) ^ x0;
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00004C7C File Offset: 0x00003C7C
		protected uint f3(uint x6, uint x5, uint x4, uint x3, uint x2, uint x1, uint x0)
		{
			return (x3 & ((x1 & x2) ^ x6 ^ x0)) ^ (x1 & x4) ^ (x2 & x5) ^ x0;
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00004C98 File Offset: 0x00003C98
		protected uint f4(uint x6, uint x5, uint x4, uint x3, uint x2, uint x1, uint x0)
		{
			return (x4 & ((x5 & ~x2) ^ (x3 & ~x6) ^ x1 ^ x6 ^ x0)) ^ (x3 & ((x1 & x2) ^ x5 ^ x6)) ^ (x2 & x6) ^ x0;
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00004CC4 File Offset: 0x00003CC4
		protected uint f5(uint x6, uint x5, uint x4, uint x3, uint x2, uint x1, uint x0)
		{
			return (x0 & ((x1 & x2 & x3) ^ ~x5)) ^ (x1 & x4) ^ (x2 & x5) ^ (x3 & x6);
		}

		// Token: 0x04000004 RID: 4
		protected const uint havalVersion = 1U;

		// Token: 0x04000005 RID: 5
		private readonly global::Home.Andir.Cryptography.HavalHashSize havalHashSize;

		// Token: 0x04000006 RID: 6
		private readonly global::Home.Andir.Cryptography.HavalPassCount havalPassCount;

		// Token: 0x04000007 RID: 7
		private readonly global::Home.Andir.Cryptography.IntCounter counter = new global::Home.Andir.Cryptography.IntCounter(2);

		// Token: 0x04000008 RID: 8
		private readonly uint[] state = new uint[8];

		// Token: 0x04000009 RID: 9
		private readonly byte[] signature = new byte[2];

		// Token: 0x0400000A RID: 10
		private readonly byte[] finalBlock;

		// Token: 0x0400000B RID: 11
		private static readonly uint[] wordOrders = new uint[]
		{
			5U,
			14U,
			26U,
			18U,
			11U,
			28U,
			7U,
			16U,
			0U,
			23U,
			20U,
			22U,
			1U,
			10U,
			4U,
			8U,
			30U,
			3U,
			21U,
			9U,
			17U,
			24U,
			29U,
			6U,
			19U,
			12U,
			15U,
			13U,
			2U,
			25U,
			31U,
			27U,
			19U,
			9U,
			4U,
			20U,
			28U,
			17U,
			8U,
			22U,
			29U,
			14U,
			25U,
			12U,
			24U,
			30U,
			16U,
			26U,
			31U,
			15U,
			7U,
			3U,
			1U,
			0U,
			18U,
			27U,
			13U,
			6U,
			21U,
			10U,
			23U,
			11U,
			5U,
			2U,
			24U,
			4U,
			0U,
			14U,
			2U,
			7U,
			28U,
			23U,
			26U,
			6U,
			30U,
			20U,
			18U,
			25U,
			19U,
			3U,
			22U,
			11U,
			31U,
			21U,
			8U,
			27U,
			12U,
			9U,
			1U,
			29U,
			5U,
			15U,
			17U,
			10U,
			16U,
			13U,
			27U,
			3U,
			21U,
			26U,
			17U,
			11U,
			20U,
			29U,
			19U,
			0U,
			12U,
			7U,
			13U,
			8U,
			31U,
			10U,
			5U,
			9U,
			14U,
			30U,
			18U,
			6U,
			28U,
			24U,
			2U,
			23U,
			16U,
			22U,
			4U,
			1U,
			25U,
			15U
		};

		// Token: 0x0400000C RID: 12
		private static readonly uint[] constants = new uint[]
		{
			1160258022U,
			953160567U,
			3193202383U,
			887688300U,
			3232508343U,
			3380367581U,
			1065670069U,
			3041331479U,
			2450970073U,
			2306472731U,
			3509652390U,
			2564797868U,
			805139163U,
			3491422135U,
			3101798381U,
			1780907670U,
			3128725573U,
			4046225305U,
			614570311U,
			3012652279U,
			134345442U,
			2240740374U,
			1667834072U,
			1901547113U,
			2757295779U,
			4103290238U,
			227898511U,
			1921955416U,
			1904987480U,
			2182433518U,
			2069144605U,
			3260701109U,
			2620446009U,
			720527379U,
			3318853667U,
			677414384U,
			3393288472U,
			3101374703U,
			2390351024U,
			1614419982U,
			1822297739U,
			2954791486U,
			3608508353U,
			3174124327U,
			2024746970U,
			1432378464U,
			3864339955U,
			2857741204U,
			1464375394U,
			1676153920U,
			1439316330U,
			715854006U,
			3033291828U,
			289532110U,
			2706671279U,
			2087905683U,
			3018724369U,
			1668267050U,
			732546397U,
			1947742710U,
			3462151702U,
			2609353502U,
			2950085171U,
			1814351708U,
			2050118529U,
			680887927U,
			999245976U,
			1800124847U,
			3300911131U,
			1713906067U,
			1641548236U,
			4213287313U,
			1216130144U,
			1575780402U,
			4018429277U,
			3917837745U,
			3693486850U,
			3949271944U,
			596196993U,
			3549867205U,
			258830323U,
			2213823033U,
			772490370U,
			2760122372U,
			1774776394U,
			2652871518U,
			566650946U,
			4142492826U,
			1728879713U,
			2882767088U,
			1783734482U,
			3629395816U,
			2517608232U,
			2874225571U,
			1861159788U,
			326777828U,
			3124490320U,
			2130389656U,
			2716951837U,
			967770486U,
			1724537150U,
			2185432712U,
			2364442137U,
			1164943284U,
			2105845187U,
			998989502U,
			3765401048U,
			2244026483U,
			1075463327U,
			1455516326U,
			1322494562U,
			910128902U,
			469688178U,
			1117454909U,
			936433444U,
			3490320968U,
			3675253459U,
			1240580251U,
			122909385U,
			2157517691U,
			634681816U,
			4142456567U,
			3825094682U,
			3061402683U,
			2540495037U,
			79693498U,
			3249098678U,
			1084186820U
		};

		// Token: 0x0400000D RID: 13
		private readonly uint[] buffer = new uint[160];
	}
}
