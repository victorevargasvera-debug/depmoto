using System;

namespace SevenZip.Compression.LZMA
{
	// Token: 0x02000010 RID: 16
	internal abstract class Base
	{
		// Token: 0x0600003E RID: 62 RVA: 0x00003105 File Offset: 0x00001305
		public static uint GetLenToPosState(uint len)
		{
			len -= 2U;
			if (len < 4U)
			{
				return len;
			}
			return 3U;
		}

		// Token: 0x04000037 RID: 55
		public const uint kNumRepDistances = 4U;

		// Token: 0x04000038 RID: 56
		public const uint kNumStates = 12U;

		// Token: 0x04000039 RID: 57
		public const int kNumPosSlotBits = 6;

		// Token: 0x0400003A RID: 58
		public const int kDicLogSizeMin = 0;

		// Token: 0x0400003B RID: 59
		public const int kNumLenToPosStatesBits = 2;

		// Token: 0x0400003C RID: 60
		public const uint kNumLenToPosStates = 4U;

		// Token: 0x0400003D RID: 61
		public const uint kMatchMinLen = 2U;

		// Token: 0x0400003E RID: 62
		public const int kNumAlignBits = 4;

		// Token: 0x0400003F RID: 63
		public const uint kAlignTableSize = 16U;

		// Token: 0x04000040 RID: 64
		public const uint kAlignMask = 15U;

		// Token: 0x04000041 RID: 65
		public const uint kStartPosModelIndex = 4U;

		// Token: 0x04000042 RID: 66
		public const uint kEndPosModelIndex = 14U;

		// Token: 0x04000043 RID: 67
		public const uint kNumPosModels = 10U;

		// Token: 0x04000044 RID: 68
		public const uint kNumFullDistances = 128U;

		// Token: 0x04000045 RID: 69
		public const uint kNumLitPosStatesBitsEncodingMax = 4U;

		// Token: 0x04000046 RID: 70
		public const uint kNumLitContextBitsMax = 8U;

		// Token: 0x04000047 RID: 71
		public const int kNumPosStatesBitsMax = 4;

		// Token: 0x04000048 RID: 72
		public const uint kNumPosStatesMax = 16U;

		// Token: 0x04000049 RID: 73
		public const int kNumPosStatesBitsEncodingMax = 4;

		// Token: 0x0400004A RID: 74
		public const uint kNumPosStatesEncodingMax = 16U;

		// Token: 0x0400004B RID: 75
		public const int kNumLowLenBits = 3;

		// Token: 0x0400004C RID: 76
		public const int kNumMidLenBits = 3;

		// Token: 0x0400004D RID: 77
		public const int kNumHighLenBits = 8;

		// Token: 0x0400004E RID: 78
		public const uint kNumLowLenSymbols = 8U;

		// Token: 0x0400004F RID: 79
		public const uint kNumMidLenSymbols = 8U;

		// Token: 0x04000050 RID: 80
		public const uint kNumLenSymbols = 272U;

		// Token: 0x04000051 RID: 81
		public const uint kMatchMaxLen = 273U;

		// Token: 0x02000011 RID: 17
		public struct State
		{
			// Token: 0x06000040 RID: 64 RVA: 0x0000311B File Offset: 0x0000131B
			public void Init()
			{
				this.Index = 0U;
			}

			// Token: 0x06000041 RID: 65 RVA: 0x00003124 File Offset: 0x00001324
			public void UpdateChar()
			{
				if (this.Index < 4U)
				{
					this.Index = 0U;
					return;
				}
				if (this.Index < 10U)
				{
					this.Index -= 3U;
					return;
				}
				this.Index -= 6U;
			}

			// Token: 0x06000042 RID: 66 RVA: 0x0000315E File Offset: 0x0000135E
			public void UpdateMatch()
			{
				this.Index = ((this.Index < 7U) ? 7U : 10U);
			}

			// Token: 0x06000043 RID: 67 RVA: 0x00003174 File Offset: 0x00001374
			public void UpdateRep()
			{
				this.Index = ((this.Index < 7U) ? 8U : 11U);
			}

			// Token: 0x06000044 RID: 68 RVA: 0x0000318A File Offset: 0x0000138A
			public void UpdateShortRep()
			{
				this.Index = ((this.Index < 7U) ? 9U : 11U);
			}

			// Token: 0x06000045 RID: 69 RVA: 0x000031A1 File Offset: 0x000013A1
			public bool IsCharState()
			{
				return this.Index < 7U;
			}

			// Token: 0x04000052 RID: 82
			public uint Index;
		}
	}
}
