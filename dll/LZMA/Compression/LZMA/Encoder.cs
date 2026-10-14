using System;
using System.IO;
using SevenZip.Compression.LZ;
using SevenZip.Compression.RangeCoder;

namespace SevenZip.Compression.LZMA
{
	// Token: 0x02000016 RID: 22
	public class Encoder : global::SevenZip.ICoder, global::SevenZip.ISetCoderProperties, global::SevenZip.IWriteCoderProperties
	{
		// Token: 0x0600005C RID: 92 RVA: 0x00003BFC File Offset: 0x00001DFC
		static Encoder()
		{
			int num = 2;
			global::SevenZip.Compression.LZMA.Encoder.g_FastPos[0] = 0;
			global::SevenZip.Compression.LZMA.Encoder.g_FastPos[1] = 1;
			for (byte b = 2; b < 22; b += 1)
			{
				uint num2 = 1U << (b >> 1) - 1;
				uint num3 = 0U;
				while (num3 < num2)
				{
					global::SevenZip.Compression.LZMA.Encoder.g_FastPos[num] = b;
					num3 += 1U;
					num++;
				}
			}
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00003C7C File Offset: 0x00001E7C
		private static uint GetPosSlot(uint pos)
		{
			if (pos < 2048U)
			{
				return (uint)global::SevenZip.Compression.LZMA.Encoder.g_FastPos[(int)((global::System.UIntPtr)pos)];
			}
			if (pos < 2097152U)
			{
				return (uint)(global::SevenZip.Compression.LZMA.Encoder.g_FastPos[(int)((global::System.UIntPtr)(pos >> 10))] + 20);
			}
			return (uint)(global::SevenZip.Compression.LZMA.Encoder.g_FastPos[(int)((global::System.UIntPtr)(pos >> 20))] + 40);
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00003CB4 File Offset: 0x00001EB4
		private static uint GetPosSlot2(uint pos)
		{
			if (pos < 131072U)
			{
				return (uint)(global::SevenZip.Compression.LZMA.Encoder.g_FastPos[(int)((global::System.UIntPtr)(pos >> 6))] + 12);
			}
			if (pos < 134217728U)
			{
				return (uint)(global::SevenZip.Compression.LZMA.Encoder.g_FastPos[(int)((global::System.UIntPtr)(pos >> 16))] + 32);
			}
			return (uint)(global::SevenZip.Compression.LZMA.Encoder.g_FastPos[(int)((global::System.UIntPtr)(pos >> 26))] + 52);
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00003CF4 File Offset: 0x00001EF4
		private void BaseInit()
		{
			this._state.Init();
			this._previousByte = 0;
			for (uint num = 0U; num < 4U; num += 1U)
			{
				this._repDistances[(int)((global::System.UIntPtr)num)] = 0U;
			}
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00003D2C File Offset: 0x00001F2C
		private void Create()
		{
			if (this._matchFinder == null)
			{
				global::SevenZip.Compression.LZ.BinTree binTree = new global::SevenZip.Compression.LZ.BinTree();
				int type = 4;
				if (this._matchFinderType == global::SevenZip.Compression.LZMA.Encoder.EMatchFinderType.BT2)
				{
					type = 2;
				}
				binTree.SetType(type);
				this._matchFinder = binTree;
			}
			this._literalEncoder.Create(this._numLiteralPosStateBits, this._numLiteralContextBits);
			if (this._dictionarySize == this._dictionarySizePrev && this._numFastBytesPrev == this._numFastBytes)
			{
				return;
			}
			this._matchFinder.Create(this._dictionarySize, 4096U, this._numFastBytes, 274U);
			this._dictionarySizePrev = this._dictionarySize;
			this._numFastBytesPrev = this._numFastBytes;
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00003DD0 File Offset: 0x00001FD0
		public Encoder()
		{
			int num = 0;
			while ((long)num < 4096L)
			{
				this._optimum[num] = new global::SevenZip.Compression.LZMA.Encoder.Optimal();
				num++;
			}
			int num2 = 0;
			while ((long)num2 < 4L)
			{
				this._posSlotEncoder[num2] = new global::SevenZip.Compression.RangeCoder.BitTreeEncoder(6);
				num2++;
			}
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00003FBA File Offset: 0x000021BA
		private void SetWriteEndMarkerMode(bool writeEndMarker)
		{
			this._writeEndMark = writeEndMarker;
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00003FC4 File Offset: 0x000021C4
		private void Init()
		{
			this.BaseInit();
			this._rangeEncoder.Init();
			for (uint num = 0U; num < 12U; num += 1U)
			{
				for (uint num2 = 0U; num2 <= this._posStateMask; num2 += 1U)
				{
					uint num3 = (num << 4) + num2;
					this._isMatch[(int)((global::System.UIntPtr)num3)].Init();
					this._isRep0Long[(int)((global::System.UIntPtr)num3)].Init();
				}
				this._isRep[(int)((global::System.UIntPtr)num)].Init();
				this._isRepG0[(int)((global::System.UIntPtr)num)].Init();
				this._isRepG1[(int)((global::System.UIntPtr)num)].Init();
				this._isRepG2[(int)((global::System.UIntPtr)num)].Init();
			}
			this._literalEncoder.Init();
			for (uint num = 0U; num < 4U; num += 1U)
			{
				this._posSlotEncoder[(int)((global::System.UIntPtr)num)].Init();
			}
			for (uint num = 0U; num < 114U; num += 1U)
			{
				this._posEncoders[(int)((global::System.UIntPtr)num)].Init();
			}
			this._lenEncoder.Init(1U << this._posStateBits);
			this._repMatchLenEncoder.Init(1U << this._posStateBits);
			this._posAlignEncoder.Init();
			this._longestMatchWasFound = false;
			this._optimumEndIndex = 0U;
			this._optimumCurrentIndex = 0U;
			this._additionalOffset = 0U;
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00004114 File Offset: 0x00002314
		private void ReadMatchDistances(out uint lenRes, out uint numDistancePairs)
		{
			lenRes = 0U;
			numDistancePairs = this._matchFinder.GetMatches(this._matchDistances);
			if (numDistancePairs > 0U)
			{
				lenRes = this._matchDistances[(int)((global::System.UIntPtr)(numDistancePairs - 2U))];
				if (lenRes == this._numFastBytes)
				{
					lenRes += this._matchFinder.GetMatchLen((int)(lenRes - 1U), this._matchDistances[(int)((global::System.UIntPtr)(numDistancePairs - 1U))], 273U - lenRes);
				}
			}
			this._additionalOffset += 1U;
		}

		// Token: 0x06000065 RID: 101 RVA: 0x0000418A File Offset: 0x0000238A
		private void MovePos(uint num)
		{
			if (num > 0U)
			{
				this._matchFinder.Skip(num);
				this._additionalOffset += num;
			}
		}

		// Token: 0x06000066 RID: 102 RVA: 0x000041AA File Offset: 0x000023AA
		private uint GetRepLen1Price(global::SevenZip.Compression.LZMA.Base.State state, uint posState)
		{
			return this._isRepG0[(int)((global::System.UIntPtr)state.Index)].GetPrice0() + this._isRep0Long[(int)((global::System.UIntPtr)((state.Index << 4) + posState))].GetPrice0();
		}

		// Token: 0x06000067 RID: 103 RVA: 0x000041E4 File Offset: 0x000023E4
		private uint GetPureRepPrice(uint repIndex, global::SevenZip.Compression.LZMA.Base.State state, uint posState)
		{
			uint num;
			if (repIndex == 0U)
			{
				num = this._isRepG0[(int)((global::System.UIntPtr)state.Index)].GetPrice0();
				num += this._isRep0Long[(int)((global::System.UIntPtr)((state.Index << 4) + posState))].GetPrice1();
			}
			else
			{
				num = this._isRepG0[(int)((global::System.UIntPtr)state.Index)].GetPrice1();
				if (repIndex == 1U)
				{
					num += this._isRepG1[(int)((global::System.UIntPtr)state.Index)].GetPrice0();
				}
				else
				{
					num += this._isRepG1[(int)((global::System.UIntPtr)state.Index)].GetPrice1();
					num += this._isRepG2[(int)((global::System.UIntPtr)state.Index)].GetPrice(repIndex - 2U);
				}
			}
			return num;
		}

		// Token: 0x06000068 RID: 104 RVA: 0x000042A4 File Offset: 0x000024A4
		private uint GetRepPrice(uint repIndex, uint len, global::SevenZip.Compression.LZMA.Base.State state, uint posState)
		{
			uint price = this._repMatchLenEncoder.GetPrice(len - 2U, posState);
			return price + this.GetPureRepPrice(repIndex, state, posState);
		}

		// Token: 0x06000069 RID: 105 RVA: 0x000042D0 File Offset: 0x000024D0
		private uint GetPosLenPrice(uint pos, uint len, uint posState)
		{
			uint lenToPosState = global::SevenZip.Compression.LZMA.Base.GetLenToPosState(len);
			uint num;
			if (pos < 128U)
			{
				num = this._distancesPrices[(int)((global::System.UIntPtr)(lenToPosState * 128U + pos))];
			}
			else
			{
				num = this._posSlotPrices[(int)((global::System.UIntPtr)((lenToPosState << 6) + global::SevenZip.Compression.LZMA.Encoder.GetPosSlot2(pos)))] + this._alignPrices[(int)((global::System.UIntPtr)(pos & 15U))];
			}
			return num + this._lenEncoder.GetPrice(len - 2U, posState);
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00004334 File Offset: 0x00002534
		private uint Backward(out uint backRes, uint cur)
		{
			this._optimumEndIndex = cur;
			uint posPrev = this._optimum[(int)((global::System.UIntPtr)cur)].PosPrev;
			uint backPrev = this._optimum[(int)((global::System.UIntPtr)cur)].BackPrev;
			do
			{
				if (this._optimum[(int)((global::System.UIntPtr)cur)].Prev1IsChar)
				{
					this._optimum[(int)((global::System.UIntPtr)posPrev)].MakeAsChar();
					this._optimum[(int)((global::System.UIntPtr)posPrev)].PosPrev = posPrev - 1U;
					if (this._optimum[(int)((global::System.UIntPtr)cur)].Prev2)
					{
						this._optimum[(int)((global::System.UIntPtr)(posPrev - 1U))].Prev1IsChar = false;
						this._optimum[(int)((global::System.UIntPtr)(posPrev - 1U))].PosPrev = this._optimum[(int)((global::System.UIntPtr)cur)].PosPrev2;
						this._optimum[(int)((global::System.UIntPtr)(posPrev - 1U))].BackPrev = this._optimum[(int)((global::System.UIntPtr)cur)].BackPrev2;
					}
				}
				uint num = posPrev;
				uint backPrev2 = backPrev;
				backPrev = this._optimum[(int)((global::System.UIntPtr)num)].BackPrev;
				posPrev = this._optimum[(int)((global::System.UIntPtr)num)].PosPrev;
				this._optimum[(int)((global::System.UIntPtr)num)].BackPrev = backPrev2;
				this._optimum[(int)((global::System.UIntPtr)num)].PosPrev = cur;
				cur = num;
			}
			while (cur > 0U);
			backRes = this._optimum[0].BackPrev;
			this._optimumCurrentIndex = this._optimum[0].PosPrev;
			return this._optimumCurrentIndex;
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00004464 File Offset: 0x00002664
		private uint GetOptimum(uint position, out uint backRes)
		{
			if (this._optimumEndIndex != this._optimumCurrentIndex)
			{
				uint result = this._optimum[(int)((global::System.UIntPtr)this._optimumCurrentIndex)].PosPrev - this._optimumCurrentIndex;
				backRes = this._optimum[(int)((global::System.UIntPtr)this._optimumCurrentIndex)].BackPrev;
				this._optimumCurrentIndex = this._optimum[(int)((global::System.UIntPtr)this._optimumCurrentIndex)].PosPrev;
				return result;
			}
			this._optimumCurrentIndex = (this._optimumEndIndex = 0U);
			uint longestMatchLength;
			uint num;
			if (!this._longestMatchWasFound)
			{
				this.ReadMatchDistances(out longestMatchLength, out num);
			}
			else
			{
				longestMatchLength = this._longestMatchLength;
				num = this._numDistancePairs;
				this._longestMatchWasFound = false;
			}
			uint num2 = this._matchFinder.GetNumAvailableBytes() + 1U;
			if (num2 < 2U)
			{
				backRes = uint.MaxValue;
				return 1U;
			}
			if (num2 > 273U)
			{
			}
			uint num3 = 0U;
			for (uint num4 = 0U; num4 < 4U; num4 += 1U)
			{
				this.reps[(int)((global::System.UIntPtr)num4)] = this._repDistances[(int)((global::System.UIntPtr)num4)];
				this.repLens[(int)((global::System.UIntPtr)num4)] = this._matchFinder.GetMatchLen(-1, this.reps[(int)((global::System.UIntPtr)num4)], 273U);
				if (this.repLens[(int)((global::System.UIntPtr)num4)] > this.repLens[(int)((global::System.UIntPtr)num3)])
				{
					num3 = num4;
				}
			}
			if (this.repLens[(int)((global::System.UIntPtr)num3)] >= this._numFastBytes)
			{
				backRes = num3;
				uint num5 = this.repLens[(int)((global::System.UIntPtr)num3)];
				this.MovePos(num5 - 1U);
				return num5;
			}
			if (longestMatchLength >= this._numFastBytes)
			{
				backRes = this._matchDistances[(int)((global::System.UIntPtr)(num - 1U))] + 4U;
				this.MovePos(longestMatchLength - 1U);
				return longestMatchLength;
			}
			byte indexByte = this._matchFinder.GetIndexByte(-1);
			byte indexByte2 = this._matchFinder.GetIndexByte((int)(0U - this._repDistances[0] - 1U - 1U));
			if (longestMatchLength < 2U && indexByte != indexByte2 && this.repLens[(int)((global::System.UIntPtr)num3)] < 2U)
			{
				backRes = uint.MaxValue;
				return 1U;
			}
			this._optimum[0].State = this._state;
			uint num6 = position & this._posStateMask;
			this._optimum[1].Price = this._isMatch[(int)((global::System.UIntPtr)((this._state.Index << 4) + num6))].GetPrice0() + this._literalEncoder.GetSubCoder(position, this._previousByte).GetPrice(!this._state.IsCharState(), indexByte2, indexByte);
			this._optimum[1].MakeAsChar();
			uint num7 = this._isMatch[(int)((global::System.UIntPtr)((this._state.Index << 4) + num6))].GetPrice1();
			uint num8 = num7 + this._isRep[(int)((global::System.UIntPtr)this._state.Index)].GetPrice1();
			if (indexByte2 == indexByte)
			{
				uint num9 = num8 + this.GetRepLen1Price(this._state, num6);
				if (num9 < this._optimum[1].Price)
				{
					this._optimum[1].Price = num9;
					this._optimum[1].MakeAsShortRep();
				}
			}
			uint num10 = (longestMatchLength >= this.repLens[(int)((global::System.UIntPtr)num3)]) ? longestMatchLength : this.repLens[(int)((global::System.UIntPtr)num3)];
			if (num10 < 2U)
			{
				backRes = this._optimum[1].BackPrev;
				return 1U;
			}
			this._optimum[1].PosPrev = 0U;
			this._optimum[0].Backs0 = this.reps[0];
			this._optimum[0].Backs1 = this.reps[1];
			this._optimum[0].Backs2 = this.reps[2];
			this._optimum[0].Backs3 = this.reps[3];
			uint num11 = num10;
			do
			{
				this._optimum[(int)((global::System.UIntPtr)(num11--))].Price = 268435455U;
			}
			while (num11 >= 2U);
			for (uint num4 = 0U; num4 < 4U; num4 += 1U)
			{
				uint num12 = this.repLens[(int)((global::System.UIntPtr)num4)];
				if (num12 >= 2U)
				{
					uint num13 = num8 + this.GetPureRepPrice(num4, this._state, num6);
					do
					{
						uint num14 = num13 + this._repMatchLenEncoder.GetPrice(num12 - 2U, num6);
						global::SevenZip.Compression.LZMA.Encoder.Optimal optimal = this._optimum[(int)((global::System.UIntPtr)num12)];
						if (num14 < optimal.Price)
						{
							optimal.Price = num14;
							optimal.PosPrev = 0U;
							optimal.BackPrev = num4;
							optimal.Prev1IsChar = false;
						}
					}
					while ((num12 -= 1U) >= 2U);
				}
			}
			uint num15 = num7 + this._isRep[(int)((global::System.UIntPtr)this._state.Index)].GetPrice0();
			num11 = ((this.repLens[0] >= 2U) ? (this.repLens[0] + 1U) : 2U);
			if (num11 <= longestMatchLength)
			{
				uint num16 = 0U;
				while (num11 > this._matchDistances[(int)((global::System.UIntPtr)num16)])
				{
					num16 += 2U;
				}
				for (;;)
				{
					uint num17 = this._matchDistances[(int)((global::System.UIntPtr)(num16 + 1U))];
					uint num18 = num15 + this.GetPosLenPrice(num17, num11, num6);
					global::SevenZip.Compression.LZMA.Encoder.Optimal optimal2 = this._optimum[(int)((global::System.UIntPtr)num11)];
					if (num18 < optimal2.Price)
					{
						optimal2.Price = num18;
						optimal2.PosPrev = 0U;
						optimal2.BackPrev = num17 + 4U;
						optimal2.Prev1IsChar = false;
					}
					if (num11 == this._matchDistances[(int)((global::System.UIntPtr)num16)])
					{
						num16 += 2U;
						if (num16 == num)
						{
							break;
						}
					}
					num11 += 1U;
				}
			}
			uint num19 = 0U;
			uint num20;
			for (;;)
			{
				num19 += 1U;
				if (num19 == num10)
				{
					break;
				}
				this.ReadMatchDistances(out num20, out num);
				if (num20 >= this._numFastBytes)
				{
					goto Block_24;
				}
				position += 1U;
				uint num21 = this._optimum[(int)((global::System.UIntPtr)num19)].PosPrev;
				global::SevenZip.Compression.LZMA.Base.State state;
				if (this._optimum[(int)((global::System.UIntPtr)num19)].Prev1IsChar)
				{
					num21 -= 1U;
					if (this._optimum[(int)((global::System.UIntPtr)num19)].Prev2)
					{
						state = this._optimum[(int)((global::System.UIntPtr)this._optimum[(int)((global::System.UIntPtr)num19)].PosPrev2)].State;
						if (this._optimum[(int)((global::System.UIntPtr)num19)].BackPrev2 < 4U)
						{
							state.UpdateRep();
						}
						else
						{
							state.UpdateMatch();
						}
					}
					else
					{
						state = this._optimum[(int)((global::System.UIntPtr)num21)].State;
					}
					state.UpdateChar();
				}
				else
				{
					state = this._optimum[(int)((global::System.UIntPtr)num21)].State;
				}
				if (num21 == num19 - 1U)
				{
					if (this._optimum[(int)((global::System.UIntPtr)num19)].IsShortRep())
					{
						state.UpdateShortRep();
					}
					else
					{
						state.UpdateChar();
					}
				}
				else
				{
					uint num22;
					if (this._optimum[(int)((global::System.UIntPtr)num19)].Prev1IsChar && this._optimum[(int)((global::System.UIntPtr)num19)].Prev2)
					{
						num21 = this._optimum[(int)((global::System.UIntPtr)num19)].PosPrev2;
						num22 = this._optimum[(int)((global::System.UIntPtr)num19)].BackPrev2;
						state.UpdateRep();
					}
					else
					{
						num22 = this._optimum[(int)((global::System.UIntPtr)num19)].BackPrev;
						if (num22 < 4U)
						{
							state.UpdateRep();
						}
						else
						{
							state.UpdateMatch();
						}
					}
					global::SevenZip.Compression.LZMA.Encoder.Optimal optimal3 = this._optimum[(int)((global::System.UIntPtr)num21)];
					if (num22 < 4U)
					{
						if (num22 == 0U)
						{
							this.reps[0] = optimal3.Backs0;
							this.reps[1] = optimal3.Backs1;
							this.reps[2] = optimal3.Backs2;
							this.reps[3] = optimal3.Backs3;
						}
						else if (num22 == 1U)
						{
							this.reps[0] = optimal3.Backs1;
							this.reps[1] = optimal3.Backs0;
							this.reps[2] = optimal3.Backs2;
							this.reps[3] = optimal3.Backs3;
						}
						else if (num22 == 2U)
						{
							this.reps[0] = optimal3.Backs2;
							this.reps[1] = optimal3.Backs0;
							this.reps[2] = optimal3.Backs1;
							this.reps[3] = optimal3.Backs3;
						}
						else
						{
							this.reps[0] = optimal3.Backs3;
							this.reps[1] = optimal3.Backs0;
							this.reps[2] = optimal3.Backs1;
							this.reps[3] = optimal3.Backs2;
						}
					}
					else
					{
						this.reps[0] = num22 - 4U;
						this.reps[1] = optimal3.Backs0;
						this.reps[2] = optimal3.Backs1;
						this.reps[3] = optimal3.Backs2;
					}
				}
				this._optimum[(int)((global::System.UIntPtr)num19)].State = state;
				this._optimum[(int)((global::System.UIntPtr)num19)].Backs0 = this.reps[0];
				this._optimum[(int)((global::System.UIntPtr)num19)].Backs1 = this.reps[1];
				this._optimum[(int)((global::System.UIntPtr)num19)].Backs2 = this.reps[2];
				this._optimum[(int)((global::System.UIntPtr)num19)].Backs3 = this.reps[3];
				uint price = this._optimum[(int)((global::System.UIntPtr)num19)].Price;
				indexByte = this._matchFinder.GetIndexByte(-1);
				indexByte2 = this._matchFinder.GetIndexByte((int)(0U - this.reps[0] - 1U - 1U));
				num6 = (position & this._posStateMask);
				uint num23 = price + this._isMatch[(int)((global::System.UIntPtr)((state.Index << 4) + num6))].GetPrice0() + this._literalEncoder.GetSubCoder(position, this._matchFinder.GetIndexByte(-2)).GetPrice(!state.IsCharState(), indexByte2, indexByte);
				global::SevenZip.Compression.LZMA.Encoder.Optimal optimal4 = this._optimum[(int)((global::System.UIntPtr)(num19 + 1U))];
				bool flag = false;
				if (num23 < optimal4.Price)
				{
					optimal4.Price = num23;
					optimal4.PosPrev = num19;
					optimal4.MakeAsChar();
					flag = true;
				}
				num7 = price + this._isMatch[(int)((global::System.UIntPtr)((state.Index << 4) + num6))].GetPrice1();
				num8 = num7 + this._isRep[(int)((global::System.UIntPtr)state.Index)].GetPrice1();
				if (indexByte2 == indexByte && (optimal4.PosPrev >= num19 || optimal4.BackPrev != 0U))
				{
					uint num24 = num8 + this.GetRepLen1Price(state, num6);
					if (num24 <= optimal4.Price)
					{
						optimal4.Price = num24;
						optimal4.PosPrev = num19;
						optimal4.MakeAsShortRep();
						flag = true;
					}
				}
				uint num25 = this._matchFinder.GetNumAvailableBytes() + 1U;
				num25 = global::System.Math.Min(4095U - num19, num25);
				num2 = num25;
				if (num2 >= 2U)
				{
					if (num2 > this._numFastBytes)
					{
						num2 = this._numFastBytes;
					}
					if (!flag && indexByte2 != indexByte)
					{
						uint limit = global::System.Math.Min(num25 - 1U, this._numFastBytes);
						uint matchLen = this._matchFinder.GetMatchLen(0, this.reps[0], limit);
						if (matchLen >= 2U)
						{
							global::SevenZip.Compression.LZMA.Base.State state2 = state;
							state2.UpdateChar();
							uint num26 = position + 1U & this._posStateMask;
							uint num27 = num23 + this._isMatch[(int)((global::System.UIntPtr)((state2.Index << 4) + num26))].GetPrice1() + this._isRep[(int)((global::System.UIntPtr)state2.Index)].GetPrice1();
							uint num28 = num19 + 1U + matchLen;
							while (num10 < num28)
							{
								this._optimum[(int)((global::System.UIntPtr)(num10 += 1U))].Price = 268435455U;
							}
							uint num29 = num27 + this.GetRepPrice(0U, matchLen, state2, num26);
							global::SevenZip.Compression.LZMA.Encoder.Optimal optimal5 = this._optimum[(int)((global::System.UIntPtr)num28)];
							if (num29 < optimal5.Price)
							{
								optimal5.Price = num29;
								optimal5.PosPrev = num19 + 1U;
								optimal5.BackPrev = 0U;
								optimal5.Prev1IsChar = true;
								optimal5.Prev2 = false;
							}
						}
					}
					uint num30 = 2U;
					for (uint num31 = 0U; num31 < 4U; num31 += 1U)
					{
						uint num32 = this._matchFinder.GetMatchLen(-1, this.reps[(int)((global::System.UIntPtr)num31)], num2);
						if (num32 >= 2U)
						{
							uint num33 = num32;
							for (;;)
							{
								if (num10 >= num19 + num32)
								{
									uint num34 = num8 + this.GetRepPrice(num31, num32, state, num6);
									global::SevenZip.Compression.LZMA.Encoder.Optimal optimal6 = this._optimum[(int)((global::System.UIntPtr)(num19 + num32))];
									if (num34 < optimal6.Price)
									{
										optimal6.Price = num34;
										optimal6.PosPrev = num19;
										optimal6.BackPrev = num31;
										optimal6.Prev1IsChar = false;
									}
									if ((num32 -= 1U) < 2U)
									{
										break;
									}
								}
								else
								{
									this._optimum[(int)((global::System.UIntPtr)(num10 += 1U))].Price = 268435455U;
								}
							}
							num32 = num33;
							if (num31 == 0U)
							{
								num30 = num32 + 1U;
							}
							if (num32 < num25)
							{
								uint limit2 = global::System.Math.Min(num25 - 1U - num32, this._numFastBytes);
								uint matchLen2 = this._matchFinder.GetMatchLen((int)num32, this.reps[(int)((global::System.UIntPtr)num31)], limit2);
								if (matchLen2 >= 2U)
								{
									global::SevenZip.Compression.LZMA.Base.State state3 = state;
									state3.UpdateRep();
									uint num35 = position + num32 & this._posStateMask;
									uint num36 = num8 + this.GetRepPrice(num31, num32, state, num6) + this._isMatch[(int)((global::System.UIntPtr)((state3.Index << 4) + num35))].GetPrice0() + this._literalEncoder.GetSubCoder(position + num32, this._matchFinder.GetIndexByte((int)(num32 - 1U - 1U))).GetPrice(true, this._matchFinder.GetIndexByte((int)(num32 - 1U - (this.reps[(int)((global::System.UIntPtr)num31)] + 1U))), this._matchFinder.GetIndexByte((int)(num32 - 1U)));
									state3.UpdateChar();
									num35 = (position + num32 + 1U & this._posStateMask);
									uint num37 = num36 + this._isMatch[(int)((global::System.UIntPtr)((state3.Index << 4) + num35))].GetPrice1();
									uint num38 = num37 + this._isRep[(int)((global::System.UIntPtr)state3.Index)].GetPrice1();
									uint num39 = num32 + 1U + matchLen2;
									while (num10 < num19 + num39)
									{
										this._optimum[(int)((global::System.UIntPtr)(num10 += 1U))].Price = 268435455U;
									}
									uint num40 = num38 + this.GetRepPrice(0U, matchLen2, state3, num35);
									global::SevenZip.Compression.LZMA.Encoder.Optimal optimal7 = this._optimum[(int)((global::System.UIntPtr)(num19 + num39))];
									if (num40 < optimal7.Price)
									{
										optimal7.Price = num40;
										optimal7.PosPrev = num19 + num32 + 1U;
										optimal7.BackPrev = 0U;
										optimal7.Prev1IsChar = true;
										optimal7.Prev2 = true;
										optimal7.PosPrev2 = num19;
										optimal7.BackPrev2 = num31;
									}
								}
							}
						}
					}
					if (num20 > num2)
					{
						num20 = num2;
						num = 0U;
						while (num20 > this._matchDistances[(int)((global::System.UIntPtr)num)])
						{
							num += 2U;
						}
						this._matchDistances[(int)((global::System.UIntPtr)num)] = num20;
						num += 2U;
					}
					if (num20 >= num30)
					{
						num15 = num7 + this._isRep[(int)((global::System.UIntPtr)state.Index)].GetPrice0();
						while (num10 < num19 + num20)
						{
							this._optimum[(int)((global::System.UIntPtr)(num10 += 1U))].Price = 268435455U;
						}
						uint num41 = 0U;
						while (num30 > this._matchDistances[(int)((global::System.UIntPtr)num41)])
						{
							num41 += 2U;
						}
						uint num42 = num30;
						for (;;)
						{
							uint num43 = this._matchDistances[(int)((global::System.UIntPtr)(num41 + 1U))];
							uint num44 = num15 + this.GetPosLenPrice(num43, num42, num6);
							global::SevenZip.Compression.LZMA.Encoder.Optimal optimal8 = this._optimum[(int)((global::System.UIntPtr)(num19 + num42))];
							if (num44 < optimal8.Price)
							{
								optimal8.Price = num44;
								optimal8.PosPrev = num19;
								optimal8.BackPrev = num43 + 4U;
								optimal8.Prev1IsChar = false;
							}
							if (num42 == this._matchDistances[(int)((global::System.UIntPtr)num41)])
							{
								if (num42 < num25)
								{
									uint limit3 = global::System.Math.Min(num25 - 1U - num42, this._numFastBytes);
									uint matchLen3 = this._matchFinder.GetMatchLen((int)num42, num43, limit3);
									if (matchLen3 >= 2U)
									{
										global::SevenZip.Compression.LZMA.Base.State state4 = state;
										state4.UpdateMatch();
										uint num45 = position + num42 & this._posStateMask;
										uint num46 = num44 + this._isMatch[(int)((global::System.UIntPtr)((state4.Index << 4) + num45))].GetPrice0() + this._literalEncoder.GetSubCoder(position + num42, this._matchFinder.GetIndexByte((int)(num42 - 1U - 1U))).GetPrice(true, this._matchFinder.GetIndexByte((int)(num42 - (num43 + 1U) - 1U)), this._matchFinder.GetIndexByte((int)(num42 - 1U)));
										state4.UpdateChar();
										num45 = (position + num42 + 1U & this._posStateMask);
										uint num47 = num46 + this._isMatch[(int)((global::System.UIntPtr)((state4.Index << 4) + num45))].GetPrice1();
										uint num48 = num47 + this._isRep[(int)((global::System.UIntPtr)state4.Index)].GetPrice1();
										uint num49 = num42 + 1U + matchLen3;
										while (num10 < num19 + num49)
										{
											this._optimum[(int)((global::System.UIntPtr)(num10 += 1U))].Price = 268435455U;
										}
										num44 = num48 + this.GetRepPrice(0U, matchLen3, state4, num45);
										optimal8 = this._optimum[(int)((global::System.UIntPtr)(num19 + num49))];
										if (num44 < optimal8.Price)
										{
											optimal8.Price = num44;
											optimal8.PosPrev = num19 + num42 + 1U;
											optimal8.BackPrev = 0U;
											optimal8.Prev1IsChar = true;
											optimal8.Prev2 = true;
											optimal8.PosPrev2 = num19;
											optimal8.BackPrev2 = num43 + 4U;
										}
									}
								}
								num41 += 2U;
								if (num41 == num)
								{
									break;
								}
							}
							num42 += 1U;
						}
					}
				}
			}
			return this.Backward(out backRes, num19);
			Block_24:
			this._numDistancePairs = num;
			this._longestMatchLength = num20;
			this._longestMatchWasFound = true;
			return this.Backward(out backRes, num19);
		}

		// Token: 0x0600006C RID: 108 RVA: 0x000054C8 File Offset: 0x000036C8
		private bool ChangePair(uint smallDist, uint bigDist)
		{
			return smallDist < 33554432U && bigDist >= smallDist << 7;
		}

		// Token: 0x0600006D RID: 109 RVA: 0x000054E0 File Offset: 0x000036E0
		private void WriteEndMarker(uint posState)
		{
			if (!this._writeEndMark)
			{
				return;
			}
			this._isMatch[(int)((global::System.UIntPtr)((this._state.Index << 4) + posState))].Encode(this._rangeEncoder, 1U);
			this._isRep[(int)((global::System.UIntPtr)this._state.Index)].Encode(this._rangeEncoder, 0U);
			this._state.UpdateMatch();
			uint num = 2U;
			this._lenEncoder.Encode(this._rangeEncoder, num - 2U, posState);
			uint symbol = 63U;
			uint lenToPosState = global::SevenZip.Compression.LZMA.Base.GetLenToPosState(num);
			this._posSlotEncoder[(int)((global::System.UIntPtr)lenToPosState)].Encode(this._rangeEncoder, symbol);
			int num2 = 30;
			uint num3 = (1U << num2) - 1U;
			this._rangeEncoder.EncodeDirectBits(num3 >> 4, num2 - 4);
			this._posAlignEncoder.ReverseEncode(this._rangeEncoder, num3 & 15U);
		}

		// Token: 0x0600006E RID: 110 RVA: 0x000055BA File Offset: 0x000037BA
		private void Flush(uint nowPos)
		{
			this.ReleaseMFStream();
			this.WriteEndMarker(nowPos & this._posStateMask);
			this._rangeEncoder.FlushData();
			this._rangeEncoder.FlushStream();
		}

		// Token: 0x0600006F RID: 111 RVA: 0x000055E8 File Offset: 0x000037E8
		public void CodeOneBlock(out long inSize, out long outSize, out bool finished)
		{
			inSize = 0L;
			outSize = 0L;
			finished = true;
			if (this._inStream != null)
			{
				this._matchFinder.SetStream(this._inStream);
				this._matchFinder.Init();
				this._needReleaseMFStream = true;
				this._inStream = null;
				if (this._trainSize > 0U)
				{
					this._matchFinder.Skip(this._trainSize);
				}
			}
			if (this._finished)
			{
				return;
			}
			this._finished = true;
			long num = this.nowPos64;
			if (this.nowPos64 == 0L)
			{
				if (this._matchFinder.GetNumAvailableBytes() == 0U)
				{
					this.Flush((uint)this.nowPos64);
					return;
				}
				uint num2;
				uint num3;
				this.ReadMatchDistances(out num2, out num3);
				uint num4 = (uint)this.nowPos64 & this._posStateMask;
				this._isMatch[(int)((global::System.UIntPtr)((this._state.Index << 4) + num4))].Encode(this._rangeEncoder, 0U);
				this._state.UpdateChar();
				byte indexByte = this._matchFinder.GetIndexByte((int)(0U - this._additionalOffset));
				this._literalEncoder.GetSubCoder((uint)this.nowPos64, this._previousByte).Encode(this._rangeEncoder, indexByte);
				this._previousByte = indexByte;
				this._additionalOffset -= 1U;
				this.nowPos64 += 1L;
			}
			if (this._matchFinder.GetNumAvailableBytes() == 0U)
			{
				this.Flush((uint)this.nowPos64);
				return;
			}
			for (;;)
			{
				uint num5;
				uint optimum = this.GetOptimum((uint)this.nowPos64, out num5);
				uint num6 = (uint)this.nowPos64 & this._posStateMask;
				uint num7 = (this._state.Index << 4) + num6;
				if (optimum == 1U && num5 == 4294967295U)
				{
					this._isMatch[(int)((global::System.UIntPtr)num7)].Encode(this._rangeEncoder, 0U);
					byte indexByte2 = this._matchFinder.GetIndexByte((int)(0U - this._additionalOffset));
					global::SevenZip.Compression.LZMA.Encoder.LiteralEncoder.Encoder2 subCoder = this._literalEncoder.GetSubCoder((uint)this.nowPos64, this._previousByte);
					if (!this._state.IsCharState())
					{
						byte indexByte3 = this._matchFinder.GetIndexByte((int)(0U - this._repDistances[0] - 1U - this._additionalOffset));
						subCoder.EncodeMatched(this._rangeEncoder, indexByte3, indexByte2);
					}
					else
					{
						subCoder.Encode(this._rangeEncoder, indexByte2);
					}
					this._previousByte = indexByte2;
					this._state.UpdateChar();
				}
				else
				{
					this._isMatch[(int)((global::System.UIntPtr)num7)].Encode(this._rangeEncoder, 1U);
					if (num5 < 4U)
					{
						this._isRep[(int)((global::System.UIntPtr)this._state.Index)].Encode(this._rangeEncoder, 1U);
						if (num5 == 0U)
						{
							this._isRepG0[(int)((global::System.UIntPtr)this._state.Index)].Encode(this._rangeEncoder, 0U);
							if (optimum == 1U)
							{
								this._isRep0Long[(int)((global::System.UIntPtr)num7)].Encode(this._rangeEncoder, 0U);
							}
							else
							{
								this._isRep0Long[(int)((global::System.UIntPtr)num7)].Encode(this._rangeEncoder, 1U);
							}
						}
						else
						{
							this._isRepG0[(int)((global::System.UIntPtr)this._state.Index)].Encode(this._rangeEncoder, 1U);
							if (num5 == 1U)
							{
								this._isRepG1[(int)((global::System.UIntPtr)this._state.Index)].Encode(this._rangeEncoder, 0U);
							}
							else
							{
								this._isRepG1[(int)((global::System.UIntPtr)this._state.Index)].Encode(this._rangeEncoder, 1U);
								this._isRepG2[(int)((global::System.UIntPtr)this._state.Index)].Encode(this._rangeEncoder, num5 - 2U);
							}
						}
						if (optimum == 1U)
						{
							this._state.UpdateShortRep();
						}
						else
						{
							this._repMatchLenEncoder.Encode(this._rangeEncoder, optimum - 2U, num6);
							this._state.UpdateRep();
						}
						uint num8 = this._repDistances[(int)((global::System.UIntPtr)num5)];
						if (num5 != 0U)
						{
							for (uint num9 = num5; num9 >= 1U; num9 -= 1U)
							{
								this._repDistances[(int)((global::System.UIntPtr)num9)] = this._repDistances[(int)((global::System.UIntPtr)(num9 - 1U))];
							}
							this._repDistances[0] = num8;
						}
					}
					else
					{
						this._isRep[(int)((global::System.UIntPtr)this._state.Index)].Encode(this._rangeEncoder, 0U);
						this._state.UpdateMatch();
						this._lenEncoder.Encode(this._rangeEncoder, optimum - 2U, num6);
						num5 -= 4U;
						uint posSlot = global::SevenZip.Compression.LZMA.Encoder.GetPosSlot(num5);
						uint lenToPosState = global::SevenZip.Compression.LZMA.Base.GetLenToPosState(optimum);
						this._posSlotEncoder[(int)((global::System.UIntPtr)lenToPosState)].Encode(this._rangeEncoder, posSlot);
						if (posSlot >= 4U)
						{
							int num10 = (int)((posSlot >> 1) - 1U);
							uint num11 = (2U | (posSlot & 1U)) << num10;
							uint num12 = num5 - num11;
							if (posSlot < 14U)
							{
								global::SevenZip.Compression.RangeCoder.BitTreeEncoder.ReverseEncode(this._posEncoders, num11 - posSlot - 1U, this._rangeEncoder, num10, num12);
							}
							else
							{
								this._rangeEncoder.EncodeDirectBits(num12 >> 4, num10 - 4);
								this._posAlignEncoder.ReverseEncode(this._rangeEncoder, num12 & 15U);
								this._alignPriceCount += 1U;
							}
						}
						uint num13 = num5;
						for (uint num14 = 3U; num14 >= 1U; num14 -= 1U)
						{
							this._repDistances[(int)((global::System.UIntPtr)num14)] = this._repDistances[(int)((global::System.UIntPtr)(num14 - 1U))];
						}
						this._repDistances[0] = num13;
						this._matchPriceCount += 1U;
					}
					this._previousByte = this._matchFinder.GetIndexByte((int)(optimum - 1U - this._additionalOffset));
				}
				this._additionalOffset -= optimum;
				this.nowPos64 += (long)((ulong)optimum);
				if (this._additionalOffset == 0U)
				{
					if (this._matchPriceCount >= 128U)
					{
						this.FillDistancesPrices();
					}
					if (this._alignPriceCount >= 16U)
					{
						this.FillAlignPrices();
					}
					inSize = this.nowPos64;
					outSize = this._rangeEncoder.GetProcessedSizeAdd();
					if (this._matchFinder.GetNumAvailableBytes() == 0U)
					{
						break;
					}
					if (this.nowPos64 - num >= 4096L)
					{
						goto Block_24;
					}
				}
			}
			this.Flush((uint)this.nowPos64);
			return;
			Block_24:
			this._finished = false;
			finished = false;
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00005BF6 File Offset: 0x00003DF6
		private void ReleaseMFStream()
		{
			if (this._matchFinder != null && this._needReleaseMFStream)
			{
				this._matchFinder.ReleaseStream();
				this._needReleaseMFStream = false;
			}
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00005C1A File Offset: 0x00003E1A
		private void SetOutStream(global::System.IO.Stream outStream)
		{
			this._rangeEncoder.SetStream(outStream);
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00005C28 File Offset: 0x00003E28
		private void ReleaseOutStream()
		{
			this._rangeEncoder.ReleaseStream();
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00005C35 File Offset: 0x00003E35
		private void ReleaseStreams()
		{
			this.ReleaseMFStream();
			this.ReleaseOutStream();
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00005C44 File Offset: 0x00003E44
		private void SetStreams(global::System.IO.Stream inStream, global::System.IO.Stream outStream, long inSize, long outSize)
		{
			this._inStream = inStream;
			this._finished = false;
			this.Create();
			this.SetOutStream(outStream);
			this.Init();
			this.FillDistancesPrices();
			this.FillAlignPrices();
			this._lenEncoder.SetTableSize(this._numFastBytes + 1U - 2U);
			this._lenEncoder.UpdateTables(1U << this._posStateBits);
			this._repMatchLenEncoder.SetTableSize(this._numFastBytes + 1U - 2U);
			this._repMatchLenEncoder.UpdateTables(1U << this._posStateBits);
			this.nowPos64 = 0L;
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00005CDC File Offset: 0x00003EDC
		public void Code(global::System.IO.Stream inStream, global::System.IO.Stream outStream, long inSize, long outSize, global::SevenZip.ICodeProgress progress)
		{
			this._needReleaseMFStream = false;
			try
			{
				this.SetStreams(inStream, outStream, inSize, outSize);
				for (;;)
				{
					long inSize2;
					long outSize2;
					bool flag;
					this.CodeOneBlock(out inSize2, out outSize2, out flag);
					if (flag)
					{
						break;
					}
					if (progress != null)
					{
						progress.SetProgress(inSize2, outSize2);
					}
				}
			}
			finally
			{
				this.ReleaseStreams();
			}
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00005D34 File Offset: 0x00003F34
		public void WriteCoderProperties(global::System.IO.Stream outStream)
		{
			this.properties[0] = (byte)((this._posStateBits * 5 + this._numLiteralPosStateBits) * 9 + this._numLiteralContextBits);
			for (int i = 0; i < 4; i++)
			{
				this.properties[1 + i] = (byte)(this._dictionarySize >> 8 * i & 255U);
			}
			outStream.Write(this.properties, 0, 5);
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00005D9C File Offset: 0x00003F9C
		private void FillDistancesPrices()
		{
			for (uint num = 4U; num < 128U; num += 1U)
			{
				uint posSlot = global::SevenZip.Compression.LZMA.Encoder.GetPosSlot(num);
				int num2 = (int)((posSlot >> 1) - 1U);
				uint num3 = (2U | (posSlot & 1U)) << num2;
				this.tempPrices[(int)((global::System.UIntPtr)num)] = global::SevenZip.Compression.RangeCoder.BitTreeEncoder.ReverseGetPrice(this._posEncoders, num3 - posSlot - 1U, num2, num - num3);
			}
			for (uint num4 = 0U; num4 < 4U; num4 += 1U)
			{
				global::SevenZip.Compression.RangeCoder.BitTreeEncoder bitTreeEncoder = this._posSlotEncoder[(int)((global::System.UIntPtr)num4)];
				uint num5 = num4 << 6;
				for (uint num6 = 0U; num6 < this._distTableSize; num6 += 1U)
				{
					this._posSlotPrices[(int)((global::System.UIntPtr)(num5 + num6))] = bitTreeEncoder.GetPrice(num6);
				}
				for (uint num6 = 14U; num6 < this._distTableSize; num6 += 1U)
				{
					this._posSlotPrices[(int)((global::System.UIntPtr)(num5 + num6))] += (num6 >> 1) - 1U - 4U << 6;
				}
				uint num7 = num4 * 128U;
				uint num8;
				for (num8 = 0U; num8 < 4U; num8 += 1U)
				{
					this._distancesPrices[(int)((global::System.UIntPtr)(num7 + num8))] = this._posSlotPrices[(int)((global::System.UIntPtr)(num5 + num8))];
				}
				while (num8 < 128U)
				{
					this._distancesPrices[(int)((global::System.UIntPtr)(num7 + num8))] = this._posSlotPrices[(int)((global::System.UIntPtr)(num5 + global::SevenZip.Compression.LZMA.Encoder.GetPosSlot(num8)))] + this.tempPrices[(int)((global::System.UIntPtr)num8)];
					num8 += 1U;
				}
			}
			this._matchPriceCount = 0U;
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00005F00 File Offset: 0x00004100
		private void FillAlignPrices()
		{
			for (uint num = 0U; num < 16U; num += 1U)
			{
				this._alignPrices[(int)((global::System.UIntPtr)num)] = this._posAlignEncoder.ReverseGetPrice(num);
			}
			this._alignPriceCount = 0U;
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00005F38 File Offset: 0x00004138
		private static int FindMatchFinder(string s)
		{
			for (int i = 0; i < global::SevenZip.Compression.LZMA.Encoder.kMatchFinderIDs.Length; i++)
			{
				if (s == global::SevenZip.Compression.LZMA.Encoder.kMatchFinderIDs[i])
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00005F6C File Offset: 0x0000416C
		public void SetCoderProperties(global::SevenZip.CoderPropID[] propIDs, object[] properties)
		{
			uint num = 0U;
			while ((ulong)num < (ulong)((long)properties.Length))
			{
				object obj = properties[(int)((global::System.UIntPtr)num)];
				switch (propIDs[(int)((global::System.UIntPtr)num)])
				{
				case global::SevenZip.CoderPropID.DictionarySize:
				{
					if (!(obj is int))
					{
						throw new global::SevenZip.InvalidParamException();
					}
					int num2 = (int)obj;
					if ((long)num2 < 1L || (long)num2 > 1073741824L)
					{
						throw new global::SevenZip.InvalidParamException();
					}
					this._dictionarySize = (uint)num2;
					int num3 = 0;
					while ((long)num3 < 30L && (long)num2 > (long)(1UL << (num3 & 31)))
					{
						num3++;
					}
					this._distTableSize = (uint)(num3 * 2);
					break;
				}
				case global::SevenZip.CoderPropID.UsedMemorySize:
				case global::SevenZip.CoderPropID.Order:
				case global::SevenZip.CoderPropID.BlockSize:
				case global::SevenZip.CoderPropID.MatchFinderCycles:
				case global::SevenZip.CoderPropID.NumPasses:
				case global::SevenZip.CoderPropID.NumThreads:
					goto IL_21E;
				case global::SevenZip.CoderPropID.PosStateBits:
				{
					if (!(obj is int))
					{
						throw new global::SevenZip.InvalidParamException();
					}
					int num4 = (int)obj;
					if (num4 < 0 || (long)num4 > 4L)
					{
						throw new global::SevenZip.InvalidParamException();
					}
					this._posStateBits = num4;
					this._posStateMask = (1U << this._posStateBits) - 1U;
					break;
				}
				case global::SevenZip.CoderPropID.LitContextBits:
				{
					if (!(obj is int))
					{
						throw new global::SevenZip.InvalidParamException();
					}
					int num5 = (int)obj;
					if (num5 < 0 || (long)num5 > 8L)
					{
						throw new global::SevenZip.InvalidParamException();
					}
					this._numLiteralContextBits = num5;
					break;
				}
				case global::SevenZip.CoderPropID.LitPosBits:
				{
					if (!(obj is int))
					{
						throw new global::SevenZip.InvalidParamException();
					}
					int num6 = (int)obj;
					if (num6 < 0 || (long)num6 > 4L)
					{
						throw new global::SevenZip.InvalidParamException();
					}
					this._numLiteralPosStateBits = num6;
					break;
				}
				case global::SevenZip.CoderPropID.NumFastBytes:
				{
					if (!(obj is int))
					{
						throw new global::SevenZip.InvalidParamException();
					}
					int num7 = (int)obj;
					if (num7 < 5 || (long)num7 > 273L)
					{
						throw new global::SevenZip.InvalidParamException();
					}
					this._numFastBytes = (uint)num7;
					break;
				}
				case global::SevenZip.CoderPropID.MatchFinder:
				{
					if (!(obj is string))
					{
						throw new global::SevenZip.InvalidParamException();
					}
					global::SevenZip.Compression.LZMA.Encoder.EMatchFinderType matchFinderType = this._matchFinderType;
					int num8 = global::SevenZip.Compression.LZMA.Encoder.FindMatchFinder(((string)obj).ToUpperInvariant());
					if (num8 < 0)
					{
						throw new global::SevenZip.InvalidParamException();
					}
					this._matchFinderType = (global::SevenZip.Compression.LZMA.Encoder.EMatchFinderType)num8;
					if (this._matchFinder != null && matchFinderType != this._matchFinderType)
					{
						this._dictionarySizePrev = uint.MaxValue;
						this._matchFinder = null;
					}
					break;
				}
				case global::SevenZip.CoderPropID.Algorithm:
					break;
				case global::SevenZip.CoderPropID.EndMarker:
					if (!(obj is bool))
					{
						throw new global::SevenZip.InvalidParamException();
					}
					this.SetWriteEndMarkerMode((bool)obj);
					break;
				default:
					goto IL_21E;
				}
				num += 1U;
				continue;
				IL_21E:
				throw new global::SevenZip.InvalidParamException();
			}
		}

		// Token: 0x0600007B RID: 123 RVA: 0x000061AC File Offset: 0x000043AC
		public void SetTrainSize(uint trainSize)
		{
			this._trainSize = trainSize;
		}

		// Token: 0x04000070 RID: 112
		private const uint kIfinityPrice = 268435455U;

		// Token: 0x04000071 RID: 113
		private const int kDefaultDictionaryLogSize = 22;

		// Token: 0x04000072 RID: 114
		private const uint kNumFastBytesDefault = 32U;

		// Token: 0x04000073 RID: 115
		private const uint kNumLenSpecSymbols = 16U;

		// Token: 0x04000074 RID: 116
		private const uint kNumOpts = 4096U;

		// Token: 0x04000075 RID: 117
		private const int kPropSize = 5;

		// Token: 0x04000076 RID: 118
		private static byte[] g_FastPos = new byte[2048];

		// Token: 0x04000077 RID: 119
		private global::SevenZip.Compression.LZMA.Base.State _state = default(global::SevenZip.Compression.LZMA.Base.State);

		// Token: 0x04000078 RID: 120
		private byte _previousByte;

		// Token: 0x04000079 RID: 121
		private uint[] _repDistances = new uint[4];

		// Token: 0x0400007A RID: 122
		private global::SevenZip.Compression.LZMA.Encoder.Optimal[] _optimum = new global::SevenZip.Compression.LZMA.Encoder.Optimal[4096];

		// Token: 0x0400007B RID: 123
		private global::SevenZip.Compression.LZ.IMatchFinder _matchFinder;

		// Token: 0x0400007C RID: 124
		private global::SevenZip.Compression.RangeCoder.Encoder _rangeEncoder = new global::SevenZip.Compression.RangeCoder.Encoder();

		// Token: 0x0400007D RID: 125
		private global::SevenZip.Compression.RangeCoder.BitEncoder[] _isMatch = new global::SevenZip.Compression.RangeCoder.BitEncoder[192];

		// Token: 0x0400007E RID: 126
		private global::SevenZip.Compression.RangeCoder.BitEncoder[] _isRep = new global::SevenZip.Compression.RangeCoder.BitEncoder[12];

		// Token: 0x0400007F RID: 127
		private global::SevenZip.Compression.RangeCoder.BitEncoder[] _isRepG0 = new global::SevenZip.Compression.RangeCoder.BitEncoder[12];

		// Token: 0x04000080 RID: 128
		private global::SevenZip.Compression.RangeCoder.BitEncoder[] _isRepG1 = new global::SevenZip.Compression.RangeCoder.BitEncoder[12];

		// Token: 0x04000081 RID: 129
		private global::SevenZip.Compression.RangeCoder.BitEncoder[] _isRepG2 = new global::SevenZip.Compression.RangeCoder.BitEncoder[12];

		// Token: 0x04000082 RID: 130
		private global::SevenZip.Compression.RangeCoder.BitEncoder[] _isRep0Long = new global::SevenZip.Compression.RangeCoder.BitEncoder[192];

		// Token: 0x04000083 RID: 131
		private global::SevenZip.Compression.RangeCoder.BitTreeEncoder[] _posSlotEncoder = new global::SevenZip.Compression.RangeCoder.BitTreeEncoder[4];

		// Token: 0x04000084 RID: 132
		private global::SevenZip.Compression.RangeCoder.BitEncoder[] _posEncoders = new global::SevenZip.Compression.RangeCoder.BitEncoder[114];

		// Token: 0x04000085 RID: 133
		private global::SevenZip.Compression.RangeCoder.BitTreeEncoder _posAlignEncoder = new global::SevenZip.Compression.RangeCoder.BitTreeEncoder(4);

		// Token: 0x04000086 RID: 134
		private global::SevenZip.Compression.LZMA.Encoder.LenPriceTableEncoder _lenEncoder = new global::SevenZip.Compression.LZMA.Encoder.LenPriceTableEncoder();

		// Token: 0x04000087 RID: 135
		private global::SevenZip.Compression.LZMA.Encoder.LenPriceTableEncoder _repMatchLenEncoder = new global::SevenZip.Compression.LZMA.Encoder.LenPriceTableEncoder();

		// Token: 0x04000088 RID: 136
		private global::SevenZip.Compression.LZMA.Encoder.LiteralEncoder _literalEncoder = new global::SevenZip.Compression.LZMA.Encoder.LiteralEncoder();

		// Token: 0x04000089 RID: 137
		private uint[] _matchDistances = new uint[548];

		// Token: 0x0400008A RID: 138
		private uint _numFastBytes = 32U;

		// Token: 0x0400008B RID: 139
		private uint _longestMatchLength;

		// Token: 0x0400008C RID: 140
		private uint _numDistancePairs;

		// Token: 0x0400008D RID: 141
		private uint _additionalOffset;

		// Token: 0x0400008E RID: 142
		private uint _optimumEndIndex;

		// Token: 0x0400008F RID: 143
		private uint _optimumCurrentIndex;

		// Token: 0x04000090 RID: 144
		private bool _longestMatchWasFound;

		// Token: 0x04000091 RID: 145
		private uint[] _posSlotPrices = new uint[256];

		// Token: 0x04000092 RID: 146
		private uint[] _distancesPrices = new uint[512];

		// Token: 0x04000093 RID: 147
		private uint[] _alignPrices = new uint[16];

		// Token: 0x04000094 RID: 148
		private uint _alignPriceCount;

		// Token: 0x04000095 RID: 149
		private uint _distTableSize = 44U;

		// Token: 0x04000096 RID: 150
		private int _posStateBits = 2;

		// Token: 0x04000097 RID: 151
		private uint _posStateMask = 3U;

		// Token: 0x04000098 RID: 152
		private int _numLiteralPosStateBits;

		// Token: 0x04000099 RID: 153
		private int _numLiteralContextBits = 3;

		// Token: 0x0400009A RID: 154
		private uint _dictionarySize = 4194304U;

		// Token: 0x0400009B RID: 155
		private uint _dictionarySizePrev = uint.MaxValue;

		// Token: 0x0400009C RID: 156
		private uint _numFastBytesPrev = uint.MaxValue;

		// Token: 0x0400009D RID: 157
		private long nowPos64;

		// Token: 0x0400009E RID: 158
		private bool _finished;

		// Token: 0x0400009F RID: 159
		private global::System.IO.Stream _inStream;

		// Token: 0x040000A0 RID: 160
		private global::SevenZip.Compression.LZMA.Encoder.EMatchFinderType _matchFinderType = global::SevenZip.Compression.LZMA.Encoder.EMatchFinderType.BT4;

		// Token: 0x040000A1 RID: 161
		private bool _writeEndMark;

		// Token: 0x040000A2 RID: 162
		private bool _needReleaseMFStream;

		// Token: 0x040000A3 RID: 163
		private uint[] reps = new uint[4];

		// Token: 0x040000A4 RID: 164
		private uint[] repLens = new uint[4];

		// Token: 0x040000A5 RID: 165
		private byte[] properties = new byte[5];

		// Token: 0x040000A6 RID: 166
		private uint[] tempPrices = new uint[128];

		// Token: 0x040000A7 RID: 167
		private uint _matchPriceCount;

		// Token: 0x040000A8 RID: 168
		private static string[] kMatchFinderIDs = new string[]
		{
			"BT2",
			"BT4"
		};

		// Token: 0x040000A9 RID: 169
		private uint _trainSize;

		// Token: 0x02000017 RID: 23
		private enum EMatchFinderType
		{
			// Token: 0x040000AB RID: 171
			BT2,
			// Token: 0x040000AC RID: 172
			BT4
		}

		// Token: 0x02000018 RID: 24
		private class LiteralEncoder
		{
			// Token: 0x0600007C RID: 124 RVA: 0x000061B8 File Offset: 0x000043B8
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
				this.m_Coders = new global::SevenZip.Compression.LZMA.Encoder.LiteralEncoder.Encoder2[num];
				for (uint num2 = 0U; num2 < num; num2 += 1U)
				{
					this.m_Coders[(int)((global::System.UIntPtr)num2)].Create();
				}
			}

			// Token: 0x0600007D RID: 125 RVA: 0x0000623C File Offset: 0x0000443C
			public void Init()
			{
				uint num = 1U << this.m_NumPrevBits + this.m_NumPosBits;
				for (uint num2 = 0U; num2 < num; num2 += 1U)
				{
					this.m_Coders[(int)((global::System.UIntPtr)num2)].Init();
				}
			}

			// Token: 0x0600007E RID: 126 RVA: 0x0000627A File Offset: 0x0000447A
			public global::SevenZip.Compression.LZMA.Encoder.LiteralEncoder.Encoder2 GetSubCoder(uint pos, byte prevByte)
			{
				return this.m_Coders[(int)((global::System.UIntPtr)(((pos & this.m_PosMask) << this.m_NumPrevBits) + (uint)(prevByte >> 8 - this.m_NumPrevBits)))];
			}

			// Token: 0x040000AD RID: 173
			private global::SevenZip.Compression.LZMA.Encoder.LiteralEncoder.Encoder2[] m_Coders;

			// Token: 0x040000AE RID: 174
			private int m_NumPrevBits;

			// Token: 0x040000AF RID: 175
			private int m_NumPosBits;

			// Token: 0x040000B0 RID: 176
			private uint m_PosMask;

			// Token: 0x02000019 RID: 25
			public struct Encoder2
			{
				// Token: 0x06000080 RID: 128 RVA: 0x000062B5 File Offset: 0x000044B5
				public void Create()
				{
					this.m_Encoders = new global::SevenZip.Compression.RangeCoder.BitEncoder[768];
				}

				// Token: 0x06000081 RID: 129 RVA: 0x000062C8 File Offset: 0x000044C8
				public void Init()
				{
					for (int i = 0; i < 768; i++)
					{
						this.m_Encoders[i].Init();
					}
				}

				// Token: 0x06000082 RID: 130 RVA: 0x000062F8 File Offset: 0x000044F8
				public void Encode(global::SevenZip.Compression.RangeCoder.Encoder rangeEncoder, byte symbol)
				{
					uint num = 1U;
					for (int i = 7; i >= 0; i--)
					{
						uint num2 = (uint)(symbol >> i & 1);
						this.m_Encoders[(int)((global::System.UIntPtr)num)].Encode(rangeEncoder, num2);
						num = (num << 1 | num2);
					}
				}

				// Token: 0x06000083 RID: 131 RVA: 0x00006338 File Offset: 0x00004538
				public void EncodeMatched(global::SevenZip.Compression.RangeCoder.Encoder rangeEncoder, byte matchByte, byte symbol)
				{
					uint num = 1U;
					bool flag = true;
					for (int i = 7; i >= 0; i--)
					{
						uint num2 = (uint)(symbol >> i & 1);
						uint num3 = num;
						if (flag)
						{
							uint num4 = (uint)(matchByte >> i & 1);
							num3 += 1U + num4 << 8;
							flag = (num4 == num2);
						}
						this.m_Encoders[(int)((global::System.UIntPtr)num3)].Encode(rangeEncoder, num2);
						num = (num << 1 | num2);
					}
				}

				// Token: 0x06000084 RID: 132 RVA: 0x0000639C File Offset: 0x0000459C
				public uint GetPrice(bool matchMode, byte matchByte, byte symbol)
				{
					uint num = 0U;
					uint num2 = 1U;
					int i = 7;
					if (matchMode)
					{
						while (i >= 0)
						{
							uint num3 = (uint)(matchByte >> i & 1);
							uint num4 = (uint)(symbol >> i & 1);
							num += this.m_Encoders[(int)((global::System.UIntPtr)((1U + num3 << 8) + num2))].GetPrice(num4);
							num2 = (num2 << 1 | num4);
							if (num3 != num4)
							{
								i--;
								break;
							}
							i--;
						}
					}
					while (i >= 0)
					{
						uint num5 = (uint)(symbol >> i & 1);
						num += this.m_Encoders[(int)((global::System.UIntPtr)num2)].GetPrice(num5);
						num2 = (num2 << 1 | num5);
						i--;
					}
					return num;
				}

				// Token: 0x040000B1 RID: 177
				private global::SevenZip.Compression.RangeCoder.BitEncoder[] m_Encoders;
			}
		}

		// Token: 0x0200001A RID: 26
		private class LenEncoder
		{
			// Token: 0x06000085 RID: 133 RVA: 0x00006434 File Offset: 0x00004634
			public LenEncoder()
			{
				for (uint num = 0U; num < 16U; num += 1U)
				{
					this._lowCoder[(int)((global::System.UIntPtr)num)] = new global::SevenZip.Compression.RangeCoder.BitTreeEncoder(3);
					this._midCoder[(int)((global::System.UIntPtr)num)] = new global::SevenZip.Compression.RangeCoder.BitTreeEncoder(3);
				}
			}

			// Token: 0x06000086 RID: 134 RVA: 0x000064C4 File Offset: 0x000046C4
			public void Init(uint numPosStates)
			{
				this._choice.Init();
				this._choice2.Init();
				for (uint num = 0U; num < numPosStates; num += 1U)
				{
					this._lowCoder[(int)((global::System.UIntPtr)num)].Init();
					this._midCoder[(int)((global::System.UIntPtr)num)].Init();
				}
				this._highCoder.Init();
			}

			// Token: 0x06000087 RID: 135 RVA: 0x00006524 File Offset: 0x00004724
			public void Encode(global::SevenZip.Compression.RangeCoder.Encoder rangeEncoder, uint symbol, uint posState)
			{
				if (symbol < 8U)
				{
					this._choice.Encode(rangeEncoder, 0U);
					this._lowCoder[(int)((global::System.UIntPtr)posState)].Encode(rangeEncoder, symbol);
					return;
				}
				symbol -= 8U;
				this._choice.Encode(rangeEncoder, 1U);
				if (symbol < 8U)
				{
					this._choice2.Encode(rangeEncoder, 0U);
					this._midCoder[(int)((global::System.UIntPtr)posState)].Encode(rangeEncoder, symbol);
					return;
				}
				this._choice2.Encode(rangeEncoder, 1U);
				this._highCoder.Encode(rangeEncoder, symbol - 8U);
			}

			// Token: 0x06000088 RID: 136 RVA: 0x000065AC File Offset: 0x000047AC
			public void SetPrices(uint posState, uint numSymbols, uint[] prices, uint st)
			{
				uint price = this._choice.GetPrice0();
				uint price2 = this._choice.GetPrice1();
				uint num = price2 + this._choice2.GetPrice0();
				uint num2 = price2 + this._choice2.GetPrice1();
				uint num3;
				for (num3 = 0U; num3 < 8U; num3 += 1U)
				{
					if (num3 >= numSymbols)
					{
						return;
					}
					prices[(int)((global::System.UIntPtr)(st + num3))] = price + this._lowCoder[(int)((global::System.UIntPtr)posState)].GetPrice(num3);
				}
				while (num3 < 16U)
				{
					if (num3 >= numSymbols)
					{
						return;
					}
					prices[(int)((global::System.UIntPtr)(st + num3))] = num + this._midCoder[(int)((global::System.UIntPtr)posState)].GetPrice(num3 - 8U);
					num3 += 1U;
				}
				while (num3 < numSymbols)
				{
					prices[(int)((global::System.UIntPtr)(st + num3))] = num2 + this._highCoder.GetPrice(num3 - 8U - 8U);
					num3 += 1U;
				}
			}

			// Token: 0x040000B2 RID: 178
			private global::SevenZip.Compression.RangeCoder.BitEncoder _choice = default(global::SevenZip.Compression.RangeCoder.BitEncoder);

			// Token: 0x040000B3 RID: 179
			private global::SevenZip.Compression.RangeCoder.BitEncoder _choice2 = default(global::SevenZip.Compression.RangeCoder.BitEncoder);

			// Token: 0x040000B4 RID: 180
			private global::SevenZip.Compression.RangeCoder.BitTreeEncoder[] _lowCoder = new global::SevenZip.Compression.RangeCoder.BitTreeEncoder[16];

			// Token: 0x040000B5 RID: 181
			private global::SevenZip.Compression.RangeCoder.BitTreeEncoder[] _midCoder = new global::SevenZip.Compression.RangeCoder.BitTreeEncoder[16];

			// Token: 0x040000B6 RID: 182
			private global::SevenZip.Compression.RangeCoder.BitTreeEncoder _highCoder = new global::SevenZip.Compression.RangeCoder.BitTreeEncoder(8);
		}

		// Token: 0x0200001B RID: 27
		private class LenPriceTableEncoder : global::SevenZip.Compression.LZMA.Encoder.LenEncoder
		{
			// Token: 0x06000089 RID: 137 RVA: 0x00006680 File Offset: 0x00004880
			public void SetTableSize(uint tableSize)
			{
				this._tableSize = tableSize;
			}

			// Token: 0x0600008A RID: 138 RVA: 0x00006689 File Offset: 0x00004889
			public uint GetPrice(uint symbol, uint posState)
			{
				return this._prices[(int)((global::System.UIntPtr)(posState * 272U + symbol))];
			}

			// Token: 0x0600008B RID: 139 RVA: 0x0000669C File Offset: 0x0000489C
			private void UpdateTable(uint posState)
			{
				base.SetPrices(posState, this._tableSize, this._prices, posState * 272U);
				this._counters[(int)((global::System.UIntPtr)posState)] = this._tableSize;
			}

			// Token: 0x0600008C RID: 140 RVA: 0x000066C8 File Offset: 0x000048C8
			public void UpdateTables(uint numPosStates)
			{
				for (uint num = 0U; num < numPosStates; num += 1U)
				{
					this.UpdateTable(num);
				}
			}

			// Token: 0x0600008D RID: 141 RVA: 0x000066E8 File Offset: 0x000048E8
			public new void Encode(global::SevenZip.Compression.RangeCoder.Encoder rangeEncoder, uint symbol, uint posState)
			{
				base.Encode(rangeEncoder, symbol, posState);
				if ((this._counters[(int)((global::System.UIntPtr)posState)] -= 1U) == 0U)
				{
					this.UpdateTable(posState);
				}
			}

			// Token: 0x040000B7 RID: 183
			private uint[] _prices = new uint[4352];

			// Token: 0x040000B8 RID: 184
			private uint _tableSize;

			// Token: 0x040000B9 RID: 185
			private uint[] _counters = new uint[16];
		}

		// Token: 0x0200001C RID: 28
		private class Optimal
		{
			// Token: 0x0600008F RID: 143 RVA: 0x0000674B File Offset: 0x0000494B
			public void MakeAsChar()
			{
				this.BackPrev = uint.MaxValue;
				this.Prev1IsChar = false;
			}

			// Token: 0x06000090 RID: 144 RVA: 0x0000675B File Offset: 0x0000495B
			public void MakeAsShortRep()
			{
				this.BackPrev = 0U;
				this.Prev1IsChar = false;
			}

			// Token: 0x06000091 RID: 145 RVA: 0x0000676B File Offset: 0x0000496B
			public bool IsShortRep()
			{
				return this.BackPrev == 0U;
			}

			// Token: 0x040000BA RID: 186
			public global::SevenZip.Compression.LZMA.Base.State State;

			// Token: 0x040000BB RID: 187
			public bool Prev1IsChar;

			// Token: 0x040000BC RID: 188
			public bool Prev2;

			// Token: 0x040000BD RID: 189
			public uint PosPrev2;

			// Token: 0x040000BE RID: 190
			public uint BackPrev2;

			// Token: 0x040000BF RID: 191
			public uint Price;

			// Token: 0x040000C0 RID: 192
			public uint PosPrev;

			// Token: 0x040000C1 RID: 193
			public uint BackPrev;

			// Token: 0x040000C2 RID: 194
			public uint Backs0;

			// Token: 0x040000C3 RID: 195
			public uint Backs1;

			// Token: 0x040000C4 RID: 196
			public uint Backs2;

			// Token: 0x040000C5 RID: 197
			public uint Backs3;
		}
	}
}
