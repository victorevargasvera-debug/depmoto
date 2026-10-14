using System;

namespace Home.Andir.Cryptography
{
	// Token: 0x0200000D RID: 13
	public sealed class MD2 : global::Home.Andir.Cryptography.BlockHashAlgorithm
	{
		// Token: 0x06000041 RID: 65 RVA: 0x0000532C File Offset: 0x0000432C
		public MD2() : base(16)
		{
			this.HashSizeValue = 128;
			this.finalBlock = new byte[base.BlockSize];
			this.checkSum = new byte[base.BlockSize];
			this.Initialize();
		}

		// Token: 0x06000042 RID: 66 RVA: 0x0000538E File Offset: 0x0000438E
		public override void Initialize()
		{
			base.Initialize();
			this.processedLength = 0;
			global::System.Array.Clear(this.finalBlock, 0, this.finalBlock.Length);
			global::System.Array.Clear(this.checkSum, 0, this.checkSum.Length);
			this.InitializeState();
		}

		// Token: 0x06000043 RID: 67 RVA: 0x000053CB File Offset: 0x000043CB
		private void InitializeState()
		{
			global::System.Array.Clear(this.state, 0, this.state.Length);
		}

		// Token: 0x06000044 RID: 68 RVA: 0x000053E4 File Offset: 0x000043E4
		protected override void ProcessBlock(byte[] array, int offset)
		{
			if (array.Length < offset + base.BlockSize)
			{
				throw new global::System.ArgumentOutOfRangeException("offset");
			}
			this.processedLength += base.BlockSize;
			global::System.Buffer.BlockCopy(this.state, 0, this.buffer, 0, 16);
			global::System.Buffer.BlockCopy(array, offset, this.buffer, 16, 16);
			for (int i = 0; i < 16; i++)
			{
				this.buffer[i + 32] = (this.state[i] ^ array[offset + i]);
			}
			uint num = 0U;
			for (int j = 0; j < 18; j++)
			{
				for (int k = 0; k < this.buffer.Length; k++)
				{
					num = (uint)(this.buffer[k] = (byte)((uint)this.buffer[k] ^ global::Home.Andir.Cryptography.MD2.pi[(int)((global::System.UIntPtr)num)]));
				}
				num = (uint)((ulong)num + (ulong)((long)j) & 255UL);
			}
			global::System.Buffer.BlockCopy(this.buffer, 0, this.state, 0, 16);
			num = (uint)this.checkSum[15];
			for (int l = 0; l < this.checkSum.Length; l++)
			{
				num = (uint)(this.checkSum[l] = (byte)((uint)this.checkSum[l] ^ global::Home.Andir.Cryptography.MD2.pi[(int)((global::System.UIntPtr)((uint)array[offset + l] ^ num))]));
			}
			global::System.Array.Clear(this.buffer, 0, this.buffer.Length);
		}

		// Token: 0x06000045 RID: 69 RVA: 0x0000552C File Offset: 0x0000452C
		protected override void ProcessFinalBlock(byte[] array, int offset, int length)
		{
			if (length >= base.BlockSize || length > array.Length - offset)
			{
				throw new global::System.ArgumentOutOfRangeException("length");
			}
			int num = this.processedLength + length;
			global::System.Buffer.BlockCopy(array, offset, this.finalBlock, 0, length);
			for (int i = offset + length; i < base.BlockSize; i++)
			{
				this.finalBlock[i] = (byte)(16 - (num & 15));
			}
			this.ProcessBlock(this.finalBlock, 0);
			this.ProcessBlock(this.checkSum, 0);
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000046 RID: 70 RVA: 0x000055AC File Offset: 0x000045AC
		protected override byte[] Result
		{
			get
			{
				byte[] array = new byte[16];
				global::System.Buffer.BlockCopy(this.state, 0, array, 0, array.Length);
				return array;
			}
		}

		// Token: 0x04000019 RID: 25
		private int processedLength;

		// Token: 0x0400001A RID: 26
		private readonly byte[] state = new byte[16];

		// Token: 0x0400001B RID: 27
		private readonly byte[] finalBlock;

		// Token: 0x0400001C RID: 28
		private readonly byte[] checkSum;

		// Token: 0x0400001D RID: 29
		private static readonly uint[] pi = new uint[]
		{
			41U,
			46U,
			67U,
			201U,
			162U,
			216U,
			124U,
			1U,
			61U,
			54U,
			84U,
			161U,
			236U,
			240U,
			6U,
			19U,
			98U,
			167U,
			5U,
			243U,
			192U,
			199U,
			115U,
			140U,
			152U,
			147U,
			43U,
			217U,
			188U,
			76U,
			130U,
			202U,
			30U,
			155U,
			87U,
			60U,
			253U,
			212U,
			224U,
			22U,
			103U,
			66U,
			111U,
			24U,
			138U,
			23U,
			229U,
			18U,
			190U,
			78U,
			196U,
			214U,
			218U,
			158U,
			222U,
			73U,
			160U,
			251U,
			245U,
			142U,
			187U,
			47U,
			238U,
			122U,
			169U,
			104U,
			121U,
			145U,
			21U,
			178U,
			7U,
			63U,
			148U,
			194U,
			16U,
			137U,
			11U,
			34U,
			95U,
			33U,
			128U,
			127U,
			93U,
			154U,
			90U,
			144U,
			50U,
			39U,
			53U,
			62U,
			204U,
			231U,
			191U,
			247U,
			151U,
			3U,
			255U,
			25U,
			48U,
			179U,
			72U,
			165U,
			181U,
			209U,
			215U,
			94U,
			146U,
			42U,
			172U,
			86U,
			170U,
			198U,
			79U,
			184U,
			56U,
			210U,
			150U,
			164U,
			125U,
			182U,
			118U,
			252U,
			107U,
			226U,
			156U,
			116U,
			4U,
			241U,
			69U,
			157U,
			112U,
			89U,
			100U,
			113U,
			135U,
			32U,
			134U,
			91U,
			207U,
			101U,
			230U,
			45U,
			168U,
			2U,
			27U,
			96U,
			37U,
			173U,
			174U,
			176U,
			185U,
			246U,
			28U,
			70U,
			97U,
			105U,
			52U,
			64U,
			126U,
			15U,
			85U,
			71U,
			163U,
			35U,
			221U,
			81U,
			175U,
			58U,
			195U,
			92U,
			249U,
			206U,
			186U,
			197U,
			234U,
			38U,
			44U,
			83U,
			13U,
			110U,
			133U,
			40U,
			132U,
			9U,
			211U,
			223U,
			205U,
			244U,
			65U,
			129U,
			77U,
			82U,
			106U,
			220U,
			55U,
			200U,
			108U,
			193U,
			171U,
			250U,
			36U,
			225U,
			123U,
			8U,
			12U,
			189U,
			177U,
			74U,
			120U,
			136U,
			149U,
			139U,
			227U,
			99U,
			232U,
			109U,
			233U,
			203U,
			213U,
			254U,
			59U,
			0U,
			29U,
			57U,
			242U,
			239U,
			183U,
			14U,
			102U,
			88U,
			208U,
			228U,
			166U,
			119U,
			114U,
			248U,
			235U,
			117U,
			75U,
			10U,
			49U,
			68U,
			80U,
			180U,
			143U,
			237U,
			31U,
			26U,
			219U,
			153U,
			141U,
			51U,
			159U,
			17U,
			131U,
			20U
		};

		// Token: 0x0400001E RID: 30
		private static readonly uint[] constants = new uint[]
		{
			0U,
			1518500249U,
			1859775393U
		};

		// Token: 0x0400001F RID: 31
		private readonly byte[] buffer = new byte[48];
	}
}
