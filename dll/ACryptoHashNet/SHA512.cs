using System;

namespace Home.Andir.Cryptography
{
	// Token: 0x02000016 RID: 22
	public sealed class SHA512 : global::Home.Andir.Cryptography.BlockHashAlgorithm
	{
		// Token: 0x0600008C RID: 140 RVA: 0x0000BCEC File Offset: 0x0000ACEC
		public SHA512() : base(128)
		{
			this.HashSizeValue = 512;
			this.finalBlock = new byte[base.BlockSize];
			this.Initialize();
		}

		// Token: 0x0600008D RID: 141 RVA: 0x0000BD4B File Offset: 0x0000AD4B
		public override void Initialize()
		{
			base.Initialize();
			this.counter.Clear();
			global::System.Array.Clear(this.finalBlock, 0, this.finalBlock.Length);
			this.InitializeState();
		}

		// Token: 0x0600008E RID: 142 RVA: 0x0000BD78 File Offset: 0x0000AD78
		private void InitializeState()
		{
			this.state[0] = 7640891576956012808UL;
			this.state[1] = 13503953896175478587UL;
			this.state[2] = 4354685564936845355UL;
			this.state[3] = 11912009170470909681UL;
			this.state[4] = 5840696475078001361UL;
			this.state[5] = 11170449401992604703UL;
			this.state[6] = 2270897969802886507UL;
			this.state[7] = 6620516959819538809UL;
		}

		// Token: 0x0600008F RID: 143 RVA: 0x0000BE10 File Offset: 0x0000AE10
		protected override void ProcessBlock(byte[] array, int offset)
		{
			if (array.LongLength < (long)base.BlockSize + (long)offset)
			{
				throw new global::System.ArgumentOutOfRangeException("offset");
			}
			this.counter.Add(base.BlockSize << 3);
			global::Home.Andir.Cryptography.BigEndianBuffer.BlockCopy(array, offset, this.buffer, 0, base.BlockSize);
			for (int i = 16; i < 80; i++)
			{
				this.buffer[i] = this.Ro1(this.buffer[i - 2]) + this.buffer[i - 7] + this.Ro0(this.buffer[i - 15]) + this.buffer[i - 16];
			}
			ulong num = this.state[0];
			ulong num2 = this.state[1];
			ulong num3 = this.state[2];
			ulong num4 = this.state[3];
			ulong num5 = this.state[4];
			ulong num6 = this.state[5];
			ulong num7 = this.state[6];
			ulong num8 = this.state[7];
			for (int j = 0; j < this.buffer.Length; j += 8)
			{
				num8 += global::Home.Andir.Cryptography.SHA512.constants[j] + this.buffer[j];
				num8 += ((num5 & num6) ^ (~num5 & num7));
				num8 += this.Sig1(num5);
				num4 += num8;
				num8 += ((num & num2) ^ (num & num3) ^ (num2 & num3));
				num8 += this.Sig0(num);
				num7 += global::Home.Andir.Cryptography.SHA512.constants[j + 1] + this.buffer[j + 1];
				num7 += ((num4 & num5) ^ (~num4 & num6));
				num7 += this.Sig1(num4);
				num3 += num7;
				num7 += ((num8 & num) ^ (num8 & num2) ^ (num & num2));
				num7 += this.Sig0(num8);
				num6 += global::Home.Andir.Cryptography.SHA512.constants[j + 2] + this.buffer[j + 2];
				num6 += ((num3 & num4) ^ (~num3 & num5));
				num6 += this.Sig1(num3);
				num2 += num6;
				num6 += ((num7 & num8) ^ (num7 & num) ^ (num8 & num));
				num6 += this.Sig0(num7);
				num5 += global::Home.Andir.Cryptography.SHA512.constants[j + 3] + this.buffer[j + 3];
				num5 += ((num2 & num3) ^ (~num2 & num4));
				num5 += this.Sig1(num2);
				num += num5;
				num5 += ((num6 & num7) ^ (num6 & num8) ^ (num7 & num8));
				num5 += this.Sig0(num6);
				num4 += global::Home.Andir.Cryptography.SHA512.constants[j + 4] + this.buffer[j + 4];
				num4 += ((num & num2) ^ (~num & num3));
				num4 += this.Sig1(num);
				num8 += num4;
				num4 += ((num5 & num6) ^ (num5 & num7) ^ (num6 & num7));
				num4 += this.Sig0(num5);
				num3 += global::Home.Andir.Cryptography.SHA512.constants[j + 5] + this.buffer[j + 5];
				num3 += ((num8 & num) ^ (~num8 & num2));
				num3 += this.Sig1(num8);
				num7 += num3;
				num3 += ((num4 & num5) ^ (num4 & num6) ^ (num5 & num6));
				num3 += this.Sig0(num4);
				num2 += global::Home.Andir.Cryptography.SHA512.constants[j + 6] + this.buffer[j + 6];
				num2 += ((num7 & num8) ^ (~num7 & num));
				num2 += this.Sig1(num7);
				num6 += num2;
				num2 += ((num3 & num4) ^ (num3 & num5) ^ (num4 & num5));
				num2 += this.Sig0(num3);
				num += global::Home.Andir.Cryptography.SHA512.constants[j + 7] + this.buffer[j + 7];
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

		// Token: 0x06000090 RID: 144 RVA: 0x0000C2B0 File Offset: 0x0000B2B0
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
			int num = base.BlockSize - 16;
			if (length >= num)
			{
				this.ProcessBlock(this.finalBlock, 0);
				global::System.Array.Clear(this.finalBlock, 0, this.finalBlock.Length);
			}
			for (int i = 0; i < 16; i++)
			{
				this.finalBlock[num + i] = bytes[15 - i];
			}
			this.ProcessBlock(this.finalBlock, 0);
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000091 RID: 145 RVA: 0x0000C374 File Offset: 0x0000B374
		protected override byte[] Result
		{
			get
			{
				byte[] array = new byte[64];
				global::Home.Andir.Cryptography.BigEndianBuffer.BlockCopy(this.state, 0, array, 0, array.Length);
				return array;
			}
		}

		// Token: 0x06000092 RID: 146 RVA: 0x0000C39B File Offset: 0x0000B39B
		private ulong Ro0(ulong x)
		{
			return (x >> 1 | x << 63) ^ (x >> 8 | x << 56) ^ x >> 7;
		}

		// Token: 0x06000093 RID: 147 RVA: 0x0000C3B2 File Offset: 0x0000B3B2
		private ulong Ro1(ulong x)
		{
			return (x >> 19 | x << 45) ^ (x >> 61 | x << 3) ^ x >> 6;
		}

		// Token: 0x06000094 RID: 148 RVA: 0x0000C3CA File Offset: 0x0000B3CA
		private ulong Sig0(ulong x)
		{
			return (x >> 28 | x << 36) ^ (x >> 34 | x << 30) ^ (x >> 39 | x << 25);
		}

		// Token: 0x06000095 RID: 149 RVA: 0x0000C3E9 File Offset: 0x0000B3E9
		private ulong Sig1(ulong x)
		{
			return (x >> 14 | x << 50) ^ (x >> 18 | x << 46) ^ (x >> 41 | x << 23);
		}

		// Token: 0x04000052 RID: 82
		private readonly global::Home.Andir.Cryptography.IntCounter counter = new global::Home.Andir.Cryptography.IntCounter(4);

		// Token: 0x04000053 RID: 83
		private readonly ulong[] state = new ulong[8];

		// Token: 0x04000054 RID: 84
		private readonly byte[] finalBlock;

		// Token: 0x04000055 RID: 85
		private static readonly ulong[] constants = new ulong[]
		{
			4794697086780616226UL,
			8158064640168781261UL,
			13096744586834688815UL,
			16840607885511220156UL,
			4131703408338449720UL,
			6480981068601479193UL,
			10538285296894168987UL,
			12329834152419229976UL,
			15566598209576043074UL,
			1334009975649890238UL,
			2608012711638119052UL,
			6128411473006802146UL,
			8268148722764581231UL,
			9286055187155687089UL,
			11230858885718282805UL,
			13951009754708518548UL,
			16472876342353939154UL,
			17275323862435702243UL,
			1135362057144423861UL,
			2597628984639134821UL,
			3308224258029322869UL,
			5365058923640841347UL,
			6679025012923562964UL,
			8573033837759648693UL,
			10970295158949994411UL,
			12119686244451234320UL,
			12683024718118986047UL,
			13788192230050041572UL,
			14330467153632333762UL,
			15395433587784984357UL,
			489312712824947311UL,
			1452737877330783856UL,
			2861767655752347644UL,
			3322285676063803686UL,
			5560940570517711597UL,
			5996557281743188959UL,
			7280758554555802590UL,
			8532644243296465576UL,
			9350256976987008742UL,
			10552545826968843579UL,
			11727347734174303076UL,
			12113106623233404929UL,
			14000437183269869457UL,
			14369950271660146224UL,
			15101387698204529176UL,
			15463397548674623760UL,
			17586052441742319658UL,
			1182934255886127544UL,
			1847814050463011016UL,
			2177327727835720531UL,
			2830643537854262169UL,
			3796741975233480872UL,
			4115178125766777443UL,
			5681478168544905931UL,
			6601373596472566643UL,
			7507060721942968483UL,
			8399075790359081724UL,
			8693463985226723168UL,
			9568029438360202098UL,
			10144078919501101548UL,
			10430055236837252648UL,
			11840083180663258601UL,
			13761210420658862357UL,
			14299343276471374635UL,
			14566680578165727644UL,
			15097957966210449927UL,
			16922976911328602910UL,
			17689382322260857208UL,
			500013540394364858UL,
			748580250866718886UL,
			1242879168328830382UL,
			1977374033974150939UL,
			2944078676154940804UL,
			3659926193048069267UL,
			4368137639120453308UL,
			4836135668995329356UL,
			5532061633213252278UL,
			6448918945643986474UL,
			6902733635092675308UL,
			7801388544844847127UL
		};

		// Token: 0x04000056 RID: 86
		private ulong[] buffer = new ulong[80];
	}
}
