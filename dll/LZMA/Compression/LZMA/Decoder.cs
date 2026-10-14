using System;
using System.IO;
using SevenZip.Compression.LZ;
using SevenZip.Compression.RangeCoder;

namespace SevenZip.Compression.LZMA
{
	// Token: 0x02000012 RID: 18
	public class Decoder : global::SevenZip.ICoder, global::SevenZip.ISetDecoderProperties
	{
		// Token: 0x06000046 RID: 70 RVA: 0x000031AC File Offset: 0x000013AC
		public Decoder()
		{
			this.m_DictionarySize = uint.MaxValue;
			int num = 0;
			while ((long)num < 4L)
			{
				this.m_PosSlotDecoder[num] = new global::SevenZip.Compression.RangeCoder.BitTreeDecoder(6);
				num++;
			}
		}

		// Token: 0x06000047 RID: 71 RVA: 0x000032A4 File Offset: 0x000014A4
		private void SetDictionarySize(uint dictionarySize)
		{
			if (this.m_DictionarySize != dictionarySize)
			{
				this.m_DictionarySize = dictionarySize;
				this.m_DictionarySizeCheck = global::System.Math.Max(this.m_DictionarySize, 1U);
				uint windowSize = global::System.Math.Max(this.m_DictionarySizeCheck, 4096U);
				this.m_OutWindow.Create(windowSize);
			}
		}

		// Token: 0x06000048 RID: 72 RVA: 0x000032F0 File Offset: 0x000014F0
		private void SetLiteralProperties(int lp, int lc)
		{
			if (lp > 8)
			{
				throw new global::SevenZip.InvalidParamException();
			}
			if (lc > 8)
			{
				throw new global::SevenZip.InvalidParamException();
			}
			this.m_LiteralDecoder.Create(lp, lc);
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00003314 File Offset: 0x00001514
		private void SetPosBitsProperties(int pb)
		{
			if (pb > 4)
			{
				throw new global::SevenZip.InvalidParamException();
			}
			uint num = 1U << pb;
			this.m_LenDecoder.Create(num);
			this.m_RepLenDecoder.Create(num);
			this.m_PosStateMask = num - 1U;
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00003354 File Offset: 0x00001554
		private void Init(global::System.IO.Stream inStream, global::System.IO.Stream outStream)
		{
			this.m_RangeDecoder.Init(inStream);
			this.m_OutWindow.Init(outStream, this._solid);
			for (uint num = 0U; num < 12U; num += 1U)
			{
				for (uint num2 = 0U; num2 <= this.m_PosStateMask; num2 += 1U)
				{
					uint num3 = (num << 4) + num2;
					this.m_IsMatchDecoders[(int)((global::System.UIntPtr)num3)].Init();
					this.m_IsRep0LongDecoders[(int)((global::System.UIntPtr)num3)].Init();
				}
				this.m_IsRepDecoders[(int)((global::System.UIntPtr)num)].Init();
				this.m_IsRepG0Decoders[(int)((global::System.UIntPtr)num)].Init();
				this.m_IsRepG1Decoders[(int)((global::System.UIntPtr)num)].Init();
				this.m_IsRepG2Decoders[(int)((global::System.UIntPtr)num)].Init();
			}
			this.m_LiteralDecoder.Init();
			for (uint num = 0U; num < 4U; num += 1U)
			{
				this.m_PosSlotDecoder[(int)((global::System.UIntPtr)num)].Init();
			}
			for (uint num = 0U; num < 114U; num += 1U)
			{
				this.m_PosDecoders[(int)((global::System.UIntPtr)num)].Init();
			}
			this.m_LenDecoder.Init();
			this.m_RepLenDecoder.Init();
			this.m_PosAlignDecoder.Init();
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00003480 File Offset: 0x00001680
		public void Code(global::System.IO.Stream inStream, global::System.IO.Stream outStream, long inSize, long outSize, global::SevenZip.ICodeProgress progress)
		{
			this.Init(inStream, outStream);
			global::SevenZip.Compression.LZMA.Base.State state = default(global::SevenZip.Compression.LZMA.Base.State);
			state.Init();
			uint num = 0U;
			uint num2 = 0U;
			uint num3 = 0U;
			uint num4 = 0U;
			ulong num5 = 0UL;
			if (num5 < (ulong)outSize)
			{
				if (this.m_IsMatchDecoders[(int)((global::System.UIntPtr)(state.Index << 4))].Decode(this.m_RangeDecoder) != 0U)
				{
					throw new global::SevenZip.DataErrorException();
				}
				state.UpdateChar();
				byte b = this.m_LiteralDecoder.DecodeNormal(this.m_RangeDecoder, 0U, 0);
				this.m_OutWindow.PutByte(b);
				num5 += 1UL;
			}
			while (num5 < (ulong)outSize)
			{
				uint num6 = (uint)num5 & this.m_PosStateMask;
				if (this.m_IsMatchDecoders[(int)((global::System.UIntPtr)((state.Index << 4) + num6))].Decode(this.m_RangeDecoder) == 0U)
				{
					byte @byte = this.m_OutWindow.GetByte(0U);
					byte b2;
					if (!state.IsCharState())
					{
						b2 = this.m_LiteralDecoder.DecodeWithMatchByte(this.m_RangeDecoder, (uint)num5, @byte, this.m_OutWindow.GetByte(num));
					}
					else
					{
						b2 = this.m_LiteralDecoder.DecodeNormal(this.m_RangeDecoder, (uint)num5, @byte);
					}
					this.m_OutWindow.PutByte(b2);
					state.UpdateChar();
					num5 += 1UL;
				}
				else
				{
					uint num8;
					if (this.m_IsRepDecoders[(int)((global::System.UIntPtr)state.Index)].Decode(this.m_RangeDecoder) == 1U)
					{
						if (this.m_IsRepG0Decoders[(int)((global::System.UIntPtr)state.Index)].Decode(this.m_RangeDecoder) == 0U)
						{
							if (this.m_IsRep0LongDecoders[(int)((global::System.UIntPtr)((state.Index << 4) + num6))].Decode(this.m_RangeDecoder) == 0U)
							{
								state.UpdateShortRep();
								this.m_OutWindow.PutByte(this.m_OutWindow.GetByte(num));
								num5 += 1UL;
								continue;
							}
						}
						else
						{
							uint num7;
							if (this.m_IsRepG1Decoders[(int)((global::System.UIntPtr)state.Index)].Decode(this.m_RangeDecoder) == 0U)
							{
								num7 = num2;
							}
							else
							{
								if (this.m_IsRepG2Decoders[(int)((global::System.UIntPtr)state.Index)].Decode(this.m_RangeDecoder) == 0U)
								{
									num7 = num3;
								}
								else
								{
									num7 = num4;
									num4 = num3;
								}
								num3 = num2;
							}
							num2 = num;
							num = num7;
						}
						num8 = this.m_RepLenDecoder.Decode(this.m_RangeDecoder, num6) + 2U;
						state.UpdateRep();
					}
					else
					{
						num4 = num3;
						num3 = num2;
						num2 = num;
						num8 = 2U + this.m_LenDecoder.Decode(this.m_RangeDecoder, num6);
						state.UpdateMatch();
						uint num9 = this.m_PosSlotDecoder[(int)((global::System.UIntPtr)global::SevenZip.Compression.LZMA.Base.GetLenToPosState(num8))].Decode(this.m_RangeDecoder);
						if (num9 >= 4U)
						{
							int num10 = (int)((num9 >> 1) - 1U);
							num = (2U | (num9 & 1U)) << num10;
							if (num9 < 14U)
							{
								num += global::SevenZip.Compression.RangeCoder.BitTreeDecoder.ReverseDecode(this.m_PosDecoders, num - num9 - 1U, this.m_RangeDecoder, num10);
							}
							else
							{
								num += this.m_RangeDecoder.DecodeDirectBits(num10 - 4) << 4;
								num += this.m_PosAlignDecoder.ReverseDecode(this.m_RangeDecoder);
							}
						}
						else
						{
							num = num9;
						}
					}
					if ((ulong)num >= (ulong)this.m_OutWindow.TrainSize + num5 || num >= this.m_DictionarySizeCheck)
					{
						if (num != 4294967295U)
						{
							throw new global::SevenZip.DataErrorException();
						}
						break;
					}
					else
					{
						this.m_OutWindow.CopyBlock(num, num8);
						num5 += (ulong)num8;
					}
				}
			}
			this.m_OutWindow.Flush();
			this.m_OutWindow.ReleaseStream();
			this.m_RangeDecoder.ReleaseStream();
		}

		// Token: 0x0600004C RID: 76 RVA: 0x000037E8 File Offset: 0x000019E8
		public void SetDecoderProperties(byte[] properties)
		{
			if (properties.Length < 5)
			{
				throw new global::SevenZip.InvalidParamException();
			}
			int lc = (int)(properties[0] % 9);
			int num = (int)(properties[0] / 9);
			int lp = num % 5;
			int num2 = num / 5;
			if (num2 > 4)
			{
				throw new global::SevenZip.InvalidParamException();
			}
			uint num3 = 0U;
			for (int i = 0; i < 4; i++)
			{
				num3 += (uint)((uint)properties[1 + i] << i * 8);
			}
			this.SetDictionarySize(num3);
			this.SetLiteralProperties(lp, lc);
			this.SetPosBitsProperties(num2);
		}

		// Token: 0x0600004D RID: 77 RVA: 0x0000385E File Offset: 0x00001A5E
		public bool Train(global::System.IO.Stream stream)
		{
			this._solid = true;
			return this.m_OutWindow.Train(stream);
		}

		// Token: 0x04000053 RID: 83
		private global::SevenZip.Compression.LZ.OutWindow m_OutWindow = new global::SevenZip.Compression.LZ.OutWindow();

		// Token: 0x04000054 RID: 84
		private global::SevenZip.Compression.RangeCoder.Decoder m_RangeDecoder = new global::SevenZip.Compression.RangeCoder.Decoder();

		// Token: 0x04000055 RID: 85
		private global::SevenZip.Compression.RangeCoder.BitDecoder[] m_IsMatchDecoders = new global::SevenZip.Compression.RangeCoder.BitDecoder[192];

		// Token: 0x04000056 RID: 86
		private global::SevenZip.Compression.RangeCoder.BitDecoder[] m_IsRepDecoders = new global::SevenZip.Compression.RangeCoder.BitDecoder[12];

		// Token: 0x04000057 RID: 87
		private global::SevenZip.Compression.RangeCoder.BitDecoder[] m_IsRepG0Decoders = new global::SevenZip.Compression.RangeCoder.BitDecoder[12];

		// Token: 0x04000058 RID: 88
		private global::SevenZip.Compression.RangeCoder.BitDecoder[] m_IsRepG1Decoders = new global::SevenZip.Compression.RangeCoder.BitDecoder[12];

		// Token: 0x04000059 RID: 89
		private global::SevenZip.Compression.RangeCoder.BitDecoder[] m_IsRepG2Decoders = new global::SevenZip.Compression.RangeCoder.BitDecoder[12];

		// Token: 0x0400005A RID: 90
		private global::SevenZip.Compression.RangeCoder.BitDecoder[] m_IsRep0LongDecoders = new global::SevenZip.Compression.RangeCoder.BitDecoder[192];

		// Token: 0x0400005B RID: 91
		private global::SevenZip.Compression.RangeCoder.BitTreeDecoder[] m_PosSlotDecoder = new global::SevenZip.Compression.RangeCoder.BitTreeDecoder[4];

		// Token: 0x0400005C RID: 92
		private global::SevenZip.Compression.RangeCoder.BitDecoder[] m_PosDecoders = new global::SevenZip.Compression.RangeCoder.BitDecoder[114];

		// Token: 0x0400005D RID: 93
		private global::SevenZip.Compression.RangeCoder.BitTreeDecoder m_PosAlignDecoder = new global::SevenZip.Compression.RangeCoder.BitTreeDecoder(4);

		// Token: 0x0400005E RID: 94
		private global::SevenZip.Compression.LZMA.Decoder.LenDecoder m_LenDecoder = new global::SevenZip.Compression.LZMA.Decoder.LenDecoder();

		// Token: 0x0400005F RID: 95
		private global::SevenZip.Compression.LZMA.Decoder.LenDecoder m_RepLenDecoder = new global::SevenZip.Compression.LZMA.Decoder.LenDecoder();

		// Token: 0x04000060 RID: 96
		private global::SevenZip.Compression.LZMA.Decoder.LiteralDecoder m_LiteralDecoder = new global::SevenZip.Compression.LZMA.Decoder.LiteralDecoder();

		// Token: 0x04000061 RID: 97
		private uint m_DictionarySize;

		// Token: 0x04000062 RID: 98
		private uint m_DictionarySizeCheck;

		// Token: 0x04000063 RID: 99
		private uint m_PosStateMask;

		// Token: 0x04000064 RID: 100
		private bool _solid;

		// Token: 0x02000013 RID: 19
		private class LenDecoder
		{
			// Token: 0x0600004E RID: 78 RVA: 0x00003874 File Offset: 0x00001A74
			public void Create(uint numPosStates)
			{
				for (uint num = this.m_NumPosStates; num < numPosStates; num += 1U)
				{
					this.m_LowCoder[(int)((global::System.UIntPtr)num)] = new global::SevenZip.Compression.RangeCoder.BitTreeDecoder(3);
					this.m_MidCoder[(int)((global::System.UIntPtr)num)] = new global::SevenZip.Compression.RangeCoder.BitTreeDecoder(3);
				}
				this.m_NumPosStates = numPosStates;
			}

			// Token: 0x0600004F RID: 79 RVA: 0x000038CC File Offset: 0x00001ACC
			public void Init()
			{
				this.m_Choice.Init();
				for (uint num = 0U; num < this.m_NumPosStates; num += 1U)
				{
					this.m_LowCoder[(int)((global::System.UIntPtr)num)].Init();
					this.m_MidCoder[(int)((global::System.UIntPtr)num)].Init();
				}
				this.m_Choice2.Init();
				this.m_HighCoder.Init();
			}

			// Token: 0x06000050 RID: 80 RVA: 0x00003930 File Offset: 0x00001B30
			public uint Decode(global::SevenZip.Compression.RangeCoder.Decoder rangeDecoder, uint posState)
			{
				if (this.m_Choice.Decode(rangeDecoder) == 0U)
				{
					return this.m_LowCoder[(int)((global::System.UIntPtr)posState)].Decode(rangeDecoder);
				}
				uint num = 8U;
				if (this.m_Choice2.Decode(rangeDecoder) == 0U)
				{
					num += this.m_MidCoder[(int)((global::System.UIntPtr)posState)].Decode(rangeDecoder);
				}
				else
				{
					num += 8U;
					num += this.m_HighCoder.Decode(rangeDecoder);
				}
				return num;
			}

			// Token: 0x04000065 RID: 101
			private global::SevenZip.Compression.RangeCoder.BitDecoder m_Choice = default(global::SevenZip.Compression.RangeCoder.BitDecoder);

			// Token: 0x04000066 RID: 102
			private global::SevenZip.Compression.RangeCoder.BitDecoder m_Choice2 = default(global::SevenZip.Compression.RangeCoder.BitDecoder);

			// Token: 0x04000067 RID: 103
			private global::SevenZip.Compression.RangeCoder.BitTreeDecoder[] m_LowCoder = new global::SevenZip.Compression.RangeCoder.BitTreeDecoder[16];

			// Token: 0x04000068 RID: 104
			private global::SevenZip.Compression.RangeCoder.BitTreeDecoder[] m_MidCoder = new global::SevenZip.Compression.RangeCoder.BitTreeDecoder[16];

			// Token: 0x04000069 RID: 105
			private global::SevenZip.Compression.RangeCoder.BitTreeDecoder m_HighCoder = new global::SevenZip.Compression.RangeCoder.BitTreeDecoder(8);

			// Token: 0x0400006A RID: 106
			private uint m_NumPosStates;
		}

		// Token: 0x02000014 RID: 20
		private class LiteralDecoder
		{
			// Token: 0x06000052 RID: 82 RVA: 0x000039F0 File Offset: 0x00001BF0
			public void Create(int numPosBits, int numPrevBits)
			{
				if (this.m_Coders != null && this.m_NumPrevBits == numPrevBits && this.m_NumPosBits == numPosBits)
				{
					return;
				}
				this.m_NumPosBits = numPosBits;
				this.m_PosMask = (1U << numPosBits) - 1U;
				this.m_NumPrevBits = numPrevBits;
				uint num = 1U << this.m_NumPrevBits + this.m_NumPosBits;
				this.m_Coders = new global::SevenZip.Compression.LZMA.Decoder.LiteralDecoder.Decoder2[num];
				for (uint num2 = 0U; num2 < num; num2 += 1U)
				{
					this.m_Coders[(int)((global::System.UIntPtr)num2)].Create();
				}
			}

			// Token: 0x06000053 RID: 83 RVA: 0x00003A74 File Offset: 0x00001C74
			public void Init()
			{
				uint num = 1U << this.m_NumPrevBits + this.m_NumPosBits;
				for (uint num2 = 0U; num2 < num; num2 += 1U)
				{
					this.m_Coders[(int)((global::System.UIntPtr)num2)].Init();
				}
			}

			// Token: 0x06000054 RID: 84 RVA: 0x00003AB2 File Offset: 0x00001CB2
			private uint GetState(uint pos, byte prevByte)
			{
				return ((pos & this.m_PosMask) << this.m_NumPrevBits) + (uint)(prevByte >> 8 - this.m_NumPrevBits);
			}

			// Token: 0x06000055 RID: 85 RVA: 0x00003AD4 File Offset: 0x00001CD4
			public byte DecodeNormal(global::SevenZip.Compression.RangeCoder.Decoder rangeDecoder, uint pos, byte prevByte)
			{
				return this.m_Coders[(int)((global::System.UIntPtr)this.GetState(pos, prevByte))].DecodeNormal(rangeDecoder);
			}

			// Token: 0x06000056 RID: 86 RVA: 0x00003AF0 File Offset: 0x00001CF0
			public byte DecodeWithMatchByte(global::SevenZip.Compression.RangeCoder.Decoder rangeDecoder, uint pos, byte prevByte, byte matchByte)
			{
				return this.m_Coders[(int)((global::System.UIntPtr)this.GetState(pos, prevByte))].DecodeWithMatchByte(rangeDecoder, matchByte);
			}

			// Token: 0x0400006B RID: 107
			private global::SevenZip.Compression.LZMA.Decoder.LiteralDecoder.Decoder2[] m_Coders;

			// Token: 0x0400006C RID: 108
			private int m_NumPrevBits;

			// Token: 0x0400006D RID: 109
			private int m_NumPosBits;

			// Token: 0x0400006E RID: 110
			private uint m_PosMask;

			// Token: 0x02000015 RID: 21
			private struct Decoder2
			{
				// Token: 0x06000058 RID: 88 RVA: 0x00003B16 File Offset: 0x00001D16
				public void Create()
				{
					this.m_Decoders = new global::SevenZip.Compression.RangeCoder.BitDecoder[768];
				}

				// Token: 0x06000059 RID: 89 RVA: 0x00003B28 File Offset: 0x00001D28
				public void Init()
				{
					for (int i = 0; i < 768; i++)
					{
						this.m_Decoders[i].Init();
					}
				}

				// Token: 0x0600005A RID: 90 RVA: 0x00003B58 File Offset: 0x00001D58
				public byte DecodeNormal(global::SevenZip.Compression.RangeCoder.Decoder rangeDecoder)
				{
					uint num = 1U;
					do
					{
						num = (num << 1 | this.m_Decoders[(int)((global::System.UIntPtr)num)].Decode(rangeDecoder));
					}
					while (num < 256U);
					return (byte)num;
				}

				// Token: 0x0600005B RID: 91 RVA: 0x00003B8C File Offset: 0x00001D8C
				public byte DecodeWithMatchByte(global::SevenZip.Compression.RangeCoder.Decoder rangeDecoder, byte matchByte)
				{
					uint num = 1U;
					for (;;)
					{
						uint num2 = (uint)(matchByte >> 7 & 1);
						matchByte = (byte)(matchByte << 1);
						uint num3 = this.m_Decoders[(int)((global::System.UIntPtr)((1U + num2 << 8) + num))].Decode(rangeDecoder);
						num = (num << 1 | num3);
						if (num2 != num3)
						{
							break;
						}
						if (num >= 256U)
						{
							goto IL_5E;
						}
					}
					while (num < 256U)
					{
						num = (num << 1 | this.m_Decoders[(int)((global::System.UIntPtr)num)].Decode(rangeDecoder));
					}
					IL_5E:
					return (byte)num;
				}

				// Token: 0x0400006F RID: 111
				private global::SevenZip.Compression.RangeCoder.BitDecoder[] m_Decoders;
			}
		}
	}
}
