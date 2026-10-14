using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using <CppImplementationDetails>;
using std;

namespace FDISystem
{
	// Token: 0x02000006 RID: 6
	internal sealed class FDICore<FDISystem::FDI_TYPE_V2> : global::FDISystem.IFDI
	{
		// Token: 0x060001D1 RID: 465 RVA: 0x00006934 File Offset: 0x00005D34
		public unsafe FDICore<FDISystem::FDI_TYPE_V2>(uint nBlock, uint blockSize, uint granularity, global::FDISystem.ByteOrder byteOrder)
		{
			this.m_unitGranularity = granularity;
			this.m_maxBlocksNum = (ushort)nBlock;
			this.m_blockSize = blockSize;
			this.m_numOfBlocks = nBlock;
			this.m_bIsValidated = false;
			this.m_byteOrder = byteOrder;
			uint num = nBlock * blockSize;
			this.m_dataLength = num;
			if (num == 0U)
			{
				this.m_pData = null;
			}
			byte* ptr = global::<Module>.new[](num);
			this.m_pData = ptr;
			byte condition = (ptr != null) ? 1 : 0;
			global::System.Diagnostics.Debug.Assert(condition != 0);
			byte* pData = this.m_pData;
			if (pData == null)
			{
				throw new global::FDISystem.FDIException(global::FDISystem.FDIErrorCodes.OutOfRam);
			}
			initblk(pData, 255, this.m_dataLength);
			this.InitializeBlocksInfo();
			this.m_bIsValidated = true;
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x00009D20 File Offset: 0x00009120
		public unsafe FDICore<FDISystem::FDI_TYPE_V2>(byte[] fdiStream, global::FDISystem.ByteOrder byteOrder)
		{
			this.m_unitGranularity = 32U;
			this.m_blockSize = 65536U;
			this.m_byteOrder = byteOrder;
			int num = fdiStream.Length;
			this.m_dataLength = (uint)num;
			if (num == 0)
			{
				this.m_pData = null;
			}
			byte* pData = global::<Module>.new[](this.m_dataLength);
			this.m_pData = pData;
			ref byte byte& = ref fdiStream[0];
			byte* ptr = ref byte&;
			cpblk(this.m_pData, ptr, fdiStream.Length);
			if (!this.Validate(this.m_pData, this.m_dataLength))
			{
				throw new global::FDISystem.FDIException(global::FDISystem.FDIErrorCodes.FDIFailure);
			}
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x00001834 File Offset: 0x00000C34
		private unsafe void ~FDICore<FDISystem::FDI_TYPE_V2>()
		{
			byte* pData = this.m_pData;
			if (pData != null)
			{
				global::<Module>.delete[]((void*)pData);
				this.m_pData = null;
			}
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x00001858 File Offset: 0x00000C58
		private unsafe void !FDICore<FDISystem::FDI_TYPE_V2>()
		{
			byte* pData = this.m_pData;
			if (pData != null)
			{
				global::<Module>.delete[]((void*)pData);
				this.m_pData = null;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x060001D5 RID: 469 RVA: 0x00001684 File Offset: 0x00000A84
		public int UnitGranularity
		{
			get
			{
				return (int)this.m_unitGranularity;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x060001D6 RID: 470 RVA: 0x00001698 File Offset: 0x00000A98
		public global::FDISystem.FDIVersion Version
		{
			get
			{
				return global::FDISystem.FDIVersion.V2x;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x060001D7 RID: 471 RVA: 0x000016A8 File Offset: 0x00000AA8
		public uint MaxBlocks
		{
			get
			{
				return (uint)this.m_maxBlocksNum;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x060001D8 RID: 472 RVA: 0x000016BC File Offset: 0x00000ABC
		public uint Blocks
		{
			get
			{
				return this.m_numOfBlocks;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x060001D9 RID: 473 RVA: 0x000016D0 File Offset: 0x00000AD0
		public uint BlockSize
		{
			get
			{
				return this.m_blockSize;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x060001DA RID: 474 RVA: 0x000016E4 File Offset: 0x00000AE4
		public unsafe byte[] FDIRawStream
		{
			get
			{
				ushort maxBlocksNum = this.m_maxBlocksNum;
				uint blockSize = this.m_blockSize;
				byte[] array = new byte[(uint)maxBlocksNum * blockSize];
				uint num = 0U;
				if (0U < (uint)maxBlocksNum * blockSize)
				{
					do
					{
						array[(int)num] = this.m_pData[num];
						num += 1U;
					}
					while (num < (uint)this.m_maxBlocksNum * this.m_blockSize);
				}
				return array;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x060001DB RID: 475 RVA: 0x00001734 File Offset: 0x00000B34
		public global::FDISystem.ByteOrder FDIByteOrder
		{
			get
			{
				return this.m_byteOrder;
			}
		}

		// Token: 0x060001DC RID: 476 RVA: 0x00008D8C File Offset: 0x0000818C
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
		public unsafe bool Validate(byte* byBuffer, uint nBufferLength)
		{
			if (byBuffer == null)
			{
				return this.m_bIsValidated;
			}
			if (!this.m_bIsValidated)
			{
				byte b = this.CalculateSectorSize(byBuffer, nBufferLength) ? 1 : 0;
				this.m_bIsValidated = (b != 0);
				int num;
				if (b != 0 && this.CalculateVersion(byBuffer) != 0)
				{
					num = 1;
				}
				else
				{
					num = 0;
				}
				byte b2 = (byte)num;
				this.m_bIsValidated = (b2 != 0);
				int num2;
				if (b2 != 0 && this.CheckFdiCorrectness(byBuffer, nBufferLength) != 0)
				{
					num2 = 1;
				}
				else
				{
					num2 = 0;
				}
				byte b3 = (byte)num2;
				this.m_bIsValidated = (b3 != 0);
				int bIsValidated;
				if (b3 != 0 && this.CalculateGranularity(byBuffer) != 0)
				{
					bIsValidated = 1;
				}
				else
				{
					bIsValidated = 0;
				}
				this.m_bIsValidated = (bIsValidated != 0);
			}
			return this.m_bIsValidated;
		}

		// Token: 0x060001DD RID: 477 RVA: 0x00009E38 File Offset: 0x00009238
		public unsafe global::FDISystem.FDIErrorCodes InsertElementOnCertainBlock(int blockIndex, byte* data, int elemSize, int type, int id)
		{
			global::FDISystem.FDIErrorCodes result;
			if (this.m_pData != null && elemSize != 0 && data != null)
			{
				if (id == -1)
				{
					id = this.FindFirstAvailableId(type);
				}
				if (type != 0)
				{
					int unitGranularity = (int)this.m_unitGranularity;
					if (elemSize <= (unitGranularity - 6) / 3)
					{
						throw new global::System.NotImplementedException();
					}
					throw new global::System.NotImplementedException();
				}
				else
				{
					result = this.InsertSingleInstanceOnCertainBlock(blockIndex, id, data, elemSize, 0);
				}
			}
			else
			{
				result = global::FDISystem.FDIErrorCodes.Failure;
			}
			return result;
		}

		// Token: 0x060001DE RID: 478 RVA: 0x0000BA40 File Offset: 0x0000AE40
		public unsafe byte[] FetchElementData(int id, int type)
		{
			int num = -1;
			int num2 = 0;
			int num3 = this.ValidateElement(id, type, &num, &num2);
			byte[] array = null;
			if (num3 != -1)
			{
				array = new byte[num];
				ref byte file_data = ref array[0];
				try
				{
					global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V2>* ptr = (global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V2>*)(this.m_pData + num3);
					int fdibyteOrder = (int)this.FDIByteOrder;
					byte b = *(byte*)(ptr + 7 / sizeof(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V2>)) & 15;
					byte b3;
					if (fdibyteOrder == 1)
					{
						byte b2 = b;
						b3 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020char,unsigned\u0020char>(b2, b2);
					}
					else
					{
						b3 = b;
					}
					if (b3 == 14)
					{
						this.FetchMultiInstance(num3, num, ref file_data);
					}
					else
					{
						int fdibyteOrder2 = (int)this.FDIByteOrder;
						byte b4 = *(byte*)(ptr + 7 / sizeof(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V2>)) & 15;
						byte b6;
						if (fdibyteOrder2 == 1)
						{
							byte b5 = b4;
							b6 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020char,unsigned\u0020char>(b5, b5);
						}
						else
						{
							b6 = b4;
						}
						if (b6 == 8)
						{
							this.FetchSingleInstance(num3, num, ref file_data);
						}
						else
						{
							int fdibyteOrder3 = (int)this.FDIByteOrder;
							byte b7 = *(byte*)(ptr + 7 / sizeof(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V2>)) & 15;
							byte b9;
							if (fdibyteOrder3 == 1)
							{
								byte b8 = b7;
								b9 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020char,unsigned\u0020char>(b8, b8);
							}
							else
							{
								b9 = b7;
							}
							if (b9 == 10)
							{
								this.FetchFragmented(num3, num, ref file_data);
							}
						}
					}
				}
				catch
				{
					throw;
				}
			}
			return array;
		}

		// Token: 0x060001DF RID: 479 RVA: 0x00007B00 File Offset: 0x00006F00
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
		public unsafe bool FindAllUsedIds(byte* unit_ids, int type)
		{
			global::System.Collections.Generic.List<uint>.Enumerator enumerator = this.FindAllUsedIds(type).GetEnumerator();
			if (enumerator.MoveNext())
			{
				do
				{
					byte b = (byte)enumerator.Current;
					byte* ptr = unit_ids + ((uint)b >> 3);
					*ptr = (byte)(1 << (int)(b % 8) | (int)(*ptr));
				}
				while (enumerator.MoveNext());
			}
			return true;
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x0000632C File Offset: 0x0000572C
		public unsafe global::System.Collections.Generic.List<uint> FindAllUsedIds(int type)
		{
			uint num = 0U;
			global::System.Collections.Generic.List<uint> list = new global::System.Collections.Generic.List<uint>();
			if (0U < this.m_numOfBlocks)
			{
				do
				{
					global::FDISystem.FDIBlockInfo<FDISystem::FDI_TYPE_V2>* ptr = (global::FDISystem.FDIBlockInfo<FDISystem::FDI_TYPE_V2>*)(this.m_pData + this.m_blockSize * (num + 1U) - 16);
					int fdibyteOrder = (int)this.FDIByteOrder;
					ushort num2 = *(ushort*)(ptr + 14 / sizeof(global::FDISystem.FDIBlockInfo<FDISystem::FDI_TYPE_V2>));
					ushort num4;
					if (fdibyteOrder == 1)
					{
						ushort num3 = num2;
						num4 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,unsigned\u0020short>(num3, num3);
					}
					else
					{
						num4 = num2;
					}
					if (num4 == 61680)
					{
						int fdibyteOrder2 = (int)this.FDIByteOrder;
						byte b = *(byte*)(ptr + 8 / sizeof(global::FDISystem.FDIBlockInfo<FDISystem::FDI_TYPE_V2>));
						byte b3;
						if (fdibyteOrder2 == 1)
						{
							byte b2 = b;
							b3 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020char,unsigned\u0020char>(b2, b2);
						}
						else
						{
							b3 = b;
						}
						if (b3 == 240)
						{
							uint num5 = this.m_blockSize * num;
							global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V2>* ptr2 = (global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V2>*)(this.m_pData + num5);
							for (;;)
							{
								int fdibyteOrder3 = (int)this.FDIByteOrder;
								byte b4 = *(byte*)(ptr2 + 6 / sizeof(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V2>));
								byte b6;
								if (fdibyteOrder3 == 1)
								{
									byte b5 = b4;
									b6 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020char,unsigned\u0020char>(b5, b5);
								}
								else
								{
									b6 = b4;
								}
								if (b6 == 255)
								{
									break;
								}
								int fdibyteOrder4 = (int)this.FDIByteOrder;
								byte b7 = (byte)((uint)(*(byte*)(ptr2 + 7 / sizeof(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V2>))) >> 4);
								byte b9;
								if (fdibyteOrder4 == 1)
								{
									byte b8 = b7;
									b9 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020char,unsigned\u0020char>(b8, b8);
								}
								else
								{
									b9 = b7;
								}
								if ((int)b9 == type)
								{
									int fdibyteOrder5 = (int)this.FDIByteOrder;
									byte b10 = *(byte*)(ptr2 + 6 / sizeof(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V2>));
									byte b12;
									if (fdibyteOrder5 == 1)
									{
										byte b11 = b10;
										b12 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020char,unsigned\u0020char>(b11, b11);
									}
									else
									{
										b12 = b10;
									}
									if (b12 == 30)
									{
										int fdibyteOrder6 = (int)this.FDIByteOrder;
										ushort num6 = *(ushort*)ptr2;
										ushort item;
										if (fdibyteOrder6 == 1)
										{
											ushort num7 = num6;
											item = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,unsigned\u0020short>(num7, num7);
										}
										else
										{
											item = num6;
										}
										list.Add((uint)item);
									}
								}
								num5 += 8U;
								ptr2 = (global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V2>*)(this.m_pData + num5);
							}
						}
					}
					num += 1U;
				}
				while (num < this.m_numOfBlocks);
			}
			return list;
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x00009E94 File Offset: 0x00009294
		public unsafe int ValidateElement(int iId, int iType, int* pMaxSize, int* reclaiming)
		{
			int num = 0;
			bool flag = false;
			int num2 = -1;
			int num3 = 0;
			pMaxSize = (ref (pMaxSize == null) ? ref num3 : ref *pMaxSize);
			int num4 = 0;
			reclaiming = (ref (reclaiming == null) ? ref num4 : ref *reclaiming);
			*reclaiming = 0;
			global::FDISystem.FILE_DATA_T file_DATA_T = 0;
			*(ref file_DATA_T + 8) = 0;
			*(ref file_DATA_T + 4) = 0;
			*(ref file_DATA_T + 12) = 0;
			*(ref file_DATA_T + 20496) = 0;
			*(ref file_DATA_T + 20500) = 0;
			*(ref file_DATA_T + 102424) = 0;
			*(ref file_DATA_T + 102428) = 0;
			*(ref file_DATA_T + 102432) = 0;
			*(ref file_DATA_T + 102436) = 0;
			*(ref file_DATA_T + 102444) = 0;
			*(ref file_DATA_T + 102452) = 0;
			*(ref file_DATA_T + 102448) = 0;
			*(ref file_DATA_T + 102456) = 0;
			int num5 = this.FindFirst(iType);
			if (num5 != -1)
			{
				global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V2>* ptr;
				do
				{
					ptr = (global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V2>*)(this.m_pData + num5);
					int fdibyteOrder = (int)this.FDIByteOrder;
					ushort num6 = *(ushort*)ptr;
					if (fdibyteOrder == 1)
					{
						ushort num7 = num6;
						global::<Module>.std.reverse<unsigned\u0020char\u0020*>((byte*)(&num7), ref num7 + 2);
						num6 = num7;
					}
					else
					{
						num6 = num6;
					}
					if ((int)num6 == iId)
					{
						int num8 = this.CalculateLocation(num5);
						if (global::<Module>.FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V2>.GetAttribute(ptr, this.FDIByteOrder) != 10U && global::<Module>.FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V2>.GetAttribute(ptr, this.FDIByteOrder) != 12U && global::<Module>.FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V2>.GetAttribute(ptr, this.FDIByteOrder) != 0U)
						{
							int fdibyteOrder2 = (int)this.FDIByteOrder;
							byte b = *(byte*)(ptr + 7 / sizeof(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V2>)) & 15;
							if (fdibyteOrder2 == 1)
							{
								byte b2 = b;
								b = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020char,unsigned\u0020char>(b2, b2);
							}
							else
							{
								b = b;
							}
							if (b == 8)
							{
								if (*(ref file_DATA_T + 8) != 0)
								{
									num++;
								}
								else if (*(ref file_DATA_T + 20496) != 0)
								{
									num++;
								}
								else if (*(ref file_DATA_T + 20500) != 0)
								{
									num++;
								}
								else if (*(ref file_DATA_T + 102456) != 0)
								{
									num++;
								}
								else
								{
									file_DATA_T = 2;
								}
								if (*(ref file_DATA_T + 102436) != 0)
								{
									num++;
								}
								else
								{
									*(ref file_DATA_T + 102428) = num5;
									*(ref file_DATA_T + 102432) = num8;
									int fdibyteOrder3 = (int)this.FDIByteOrder;
									num6 = *(ushort*)(ptr + 2 / sizeof(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V2>));
									if (fdibyteOrder3 == 1)
									{
										ushort num9 = num6;
										num6 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,unsigned\u0020short>(num9, num9);
									}
									else
									{
										num6 = num6;
									}
									*(ref file_DATA_T + 102440) = (int)(this.m_unitGranularity * (uint)num6);
								}
								*(ref file_DATA_T + 102436) = *(ref file_DATA_T + 102436) + 1;
							}
							else
							{
								int fdibyteOrder4 = (int)this.FDIByteOrder;
								b = (*(byte*)(ptr + 7 / sizeof(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V2>)) & 15);
								if (fdibyteOrder4 == 1)
								{
									byte b3 = b;
									b = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020char,unsigned\u0020char>(b3, b3);
								}
								else
								{
									b = b;
								}
								if (b == 14)
								{
									if (*(ref file_DATA_T + 8) != 0)
									{
										num++;
									}
									else if (*(ref file_DATA_T + 20496) != 0)
									{
										num++;
									}
									else if (*(ref file_DATA_T + 20500) != 0)
									{
										num++;
									}
									else if (*(ref file_DATA_T + 102436) != 0)
									{
										num++;
									}
									else
									{
										file_DATA_T = 1;
									}
									if (*(ref file_DATA_T + 102456) != 0)
									{
										num++;
									}
									else
									{
										*(ref file_DATA_T + 102444) = num5;
										*(ref file_DATA_T + 102448) = num8;
										num8 = this.ValidateMultiInstance(num8, ref flag);
										if (num8 == -1)
										{
											if (flag)
											{
												reclaiming++;
											}
											else
											{
												num++;
												*(ref file_DATA_T + 102452) = 0;
											}
										}
										else
										{
											*(ref file_DATA_T + 102452) = num8;
											int fdibyteOrder5 = (int)this.FDIByteOrder;
											ushort num10 = *(ushort*)(this.m_pData + *(ref file_DATA_T + 102448));
											if (fdibyteOrder5 == 1)
											{
												ushort num11 = num10;
												num10 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,unsigned\u0020short>(num11, num11);
											}
											else
											{
												num10 = num10;
											}
											*(ref file_DATA_T + 102460) = (int)num10;
										}
									}
									*(ref file_DATA_T + 102456) = *(ref file_DATA_T + 102456) + 1;
								}
							}
						}
						else
						{
							if (*(ref file_DATA_T + 102436) != 0)
							{
								num++;
							}
							else if (*(ref file_DATA_T + 102456) != 0)
							{
								num++;
							}
							else
							{
								file_DATA_T = 3;
							}
							if (global::<Module>.FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V2>.GetAttribute(ptr, this.FDIByteOrder) == 10U)
							{
								if (*(ref file_DATA_T + 8) == 0)
								{
									*(ref file_DATA_T + 4) = num5;
									*(ref file_DATA_T + 8) = num8;
									int num12 = 0;
									int fdibyteOrder6 = (int)this.FDIByteOrder;
									ushort num10 = *(ushort*)(ptr + 2 / sizeof(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V2>));
									if (fdibyteOrder6 == 1)
									{
										ushort num13 = num10;
										global::<Module>.std.reverse<unsigned\u0020char\u0020*>((byte*)(&num13), ref num13 + 2);
										num10 = num13;
									}
									else
									{
										num10 = num10;
									}
									int num14 = (int)(this.m_unitGranularity * (uint)num10 / 10U * 10U);
									global::FDISystem.FDIGroupSequenceTable<FDISystem::FDI_TYPE_V2>* ptr2 = (global::FDISystem.FDIGroupSequenceTable<FDISystem::FDI_TYPE_V2>*)(this.m_pData + num8);
									if (0 < num14)
									{
										while (!global::<Module>.FDISystem.FDIGroupSequenceTable<FDISystem::FDI_TYPE_V2>.GrpSeqStatusIsEmpty(ptr2, this.FDIByteOrder))
										{
											num12 += 10;
											*(ref file_DATA_T + 12) = *(ref file_DATA_T + 12) + 1;
											ptr2 = (global::FDISystem.FDIGroupSequenceTable<FDISystem::FDI_TYPE_V2>*)(this.m_pData + num12 + num8);
											if (num12 >= num14)
											{
												break;
											}
										}
									}
								}
								else
								{
									num++;
								}
							}
							else
							{
								int fdibyteOrder7 = (int)this.FDIByteOrder;
								byte b4 = *(byte*)(ptr + 7 / sizeof(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V2>)) & 15;
								if (fdibyteOrder7 == 1)
								{
									byte b5 = b4;
									b4 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020char,unsigned\u0020char>(b5, b5);
								}
								else
								{
									b4 = b4;
								}
								if (b4 == 12)
								{
									int fdibyteOrder8 = (int)this.FDIByteOrder;
									ushort num10 = *(ushort*)(ptr + 2 / sizeof(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V2>));
									if (fdibyteOrder8 == 1)
									{
										ushort num15 = num10;
										num10 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,unsigned\u0020short>(num15, num15);
									}
									else
									{
										num10 = num10;
									}
									if (num10 != 1)
									{
										num++;
									}
									int fdibyteOrder9 = (int)this.FDIByteOrder;
									num10 = *(ushort*)(ptr + 2 / sizeof(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V2>));
									if (fdibyteOrder9 == 1)
									{
										ushort num16 = num10;
										num10 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,unsigned\u0020short>(num16, num16);
									}
									else
									{
										num10 = num10;
									}
									if (num10 >= 1)
									{
										uint blockSize = this.m_blockSize;
										int num17 = this.m_pData + (num5 / (int)blockSize + 1) * (int)blockSize - 16;
										global::FDISystem.ByteOrder fdibyteOrder10 = this.FDIByteOrder;
										b4 = *(num17 + 9);
										if (fdibyteOrder10 == global::FDISystem.ByteOrder.BigEndian)
										{
											byte b6 = b4;
											b4 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020char,unsigned\u0020char>(b6, b6);
										}
										else
										{
											b4 = b4;
										}
										int num14 = (int)b4;
										int num18 = *(ref file_DATA_T + 20496);
										if (*(ref file_DATA_T + 20496) >= 255)
										{
											num++;
										}
										else
										{
											int num19 = 0;
											int num20;
											if (0 < *(ref file_DATA_T + 20496))
											{
												num20 = ref file_DATA_T + 28;
												uint num21 = (uint)(*(ref file_DATA_T + 20496));
												do
												{
													if (*num20 == num14)
													{
														num19++;
													}
													num20 += 20;
													num21 -= 1U;
												}
												while (num21 > 0U);
											}
											num20 = *(ref file_DATA_T + 20496) * 20;
											int num22 = num20;
											*(num20 + (ref file_DATA_T + 16)) = num5;
											*(num22 + (ref file_DATA_T + 20)) = num8;
											*(num22 + (ref file_DATA_T + 24)) = num19 + 1;
											*(num22 + (ref file_DATA_T + 28)) = num14;
											*(num22 + (ref file_DATA_T + 32)) = 0;
											num19 = 0;
											global::FDISystem.FDIGroupSequenceTable<FDISystem::FDI_TYPE_V2>* ptr2 = (global::FDISystem.FDIGroupSequenceTable<FDISystem::FDI_TYPE_V2>*)(this.m_pData + num8);
											if (0U < this.m_unitGranularity / 10U * 10U)
											{
												do
												{
													int fdibyteOrder11 = (int)this.FDIByteOrder;
													b4 = *(byte*)(ptr2 + 1 / sizeof(global::FDISystem.FDIGroupSequenceTable<FDISystem::FDI_TYPE_V2>));
													if (fdibyteOrder11 == 1)
													{
														byte b7 = b4;
														b4 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020char,unsigned\u0020char>(b7, b7);
													}
													else
													{
														b4 = b4;
													}
													if (((b4 == 255) ? 1 : 0) != 0)
													{
														break;
													}
													num19 += 10;
													*(num22 + (ref file_DATA_T + 32)) = *(num22 + (ref file_DATA_T + 32)) + 1;
													ptr2 = (global::FDISystem.FDIGroupSequenceTable<FDISystem::FDI_TYPE_V2>*)(this.m_pData + num19 + num8);
												}
												while (num19 < (int)(this.m_unitGranularity / 10U * 10U));
											}
										}
										*(ref file_DATA_T + 20496) = *(ref file_DATA_T + 20496) + 1;
										*(ref file_DATA_T + 20500) = *(num18 * 20 + (ref file_DATA_T + 32)) + *(ref file_DATA_T + 20500);
									}
								}
								else
								{
									int fdibyteOrder12 = (int)this.FDIByteOrder;
									b4 = (*(byte*)(ptr + 7 / sizeof(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V2>)) & 15);
									if (fdibyteOrder12 == 1)
									{
										byte b8 = b4;
										b4 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020char,unsigned\u0020char>(b8, b8);
									}
									else
									{
										b4 = b4;
									}
									if (b4 == 0)
									{
										global::FDISystem.ByteOrder fdibyteOrder13 = this.FDIByteOrder;
										uint blockSize2 = this.m_blockSize;
										int num23 = this.m_pData + (num5 / (int)blockSize2 + 1) * (int)blockSize2 - 16;
										global::FDISystem.ByteOrder fdibyteOrder14 = this.FDIByteOrder;
										b4 = *(num23 + 9);
										if (fdibyteOrder14 == global::FDISystem.ByteOrder.BigEndian)
										{
											byte b9 = b4;
											b4 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020char,unsigned\u0020char>(b9, b9);
										}
										else
										{
											b4 = b4;
										}
										int num19 = (int)b4;
										int num24 = 0;
										if (0 < *(ref file_DATA_T + 102424))
										{
											int num25 = ref file_DATA_T + 20516;
											int num26 = ref file_DATA_T + 20520;
											uint num27 = (uint)(*(ref file_DATA_T + 102424));
											do
											{
												if (*num26 == num19 && *num25 == 0)
												{
													num24++;
												}
												num26 += 20;
												num25 += 20;
												num27 -= 1U;
											}
											while (num27 > 0U);
										}
										if (*(ref file_DATA_T + 102424) < 4096)
										{
											int num26 = *(ref file_DATA_T + 102424) * 20;
											int num22 = num26;
											*(num26 + (ref file_DATA_T + 20504)) = num5;
											*(num22 + (ref file_DATA_T + 20508)) = num8;
											*(num22 + (ref file_DATA_T + 20512)) = num24 + 1;
											*(num22 + (ref file_DATA_T + 20520)) = num19;
											*(num22 + (ref file_DATA_T + 20516)) = 0;
											*(ref file_DATA_T + 102424) = *(ref file_DATA_T + 102424) + 1;
										}
										else
										{
											num++;
										}
									}
								}
							}
						}
					}
					num5 = this.FindNext(iType, num5);
				}
				while (num5 != -1);
				if (num != 0)
				{
					return num2;
				}
				if (file_DATA_T == 3)
				{
					*pMaxSize = 0;
					if (*(ref file_DATA_T + 12) != *(ref file_DATA_T + 20496))
					{
						return num2;
					}
					int num24 = 0;
					if (0 < *(ref file_DATA_T + 12))
					{
						int num25 = 0;
						do
						{
							global::FDISystem.FDIGroupSequenceTable<FDISystem::FDI_TYPE_V2>* ptr2 = (global::FDISystem.FDIGroupSequenceTable<FDISystem::FDI_TYPE_V2>*)(this.m_pData + num25 + *(ref file_DATA_T + 8));
							int fdibyteOrder15 = (int)this.FDIByteOrder;
							global::FDISystem.FDIGroupSequenceTable<FDISystem::FDI_TYPE_V2>* ptr3 = ptr2 + 1 / sizeof(global::FDISystem.FDIGroupSequenceTable<FDISystem::FDI_TYPE_V2>);
							byte b10 = *(byte*)ptr3;
							if (fdibyteOrder15 == 1)
							{
								byte b11 = b10;
								b10 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020char,unsigned\u0020char>(b11, b11);
							}
							else
							{
								b10 = b10;
							}
							if (((b10 == 31) ? 1 : 0) != 0)
							{
								int num19 = 0;
								int num28 = -1;
								int num29 = 0;
								if (0 < *(ref file_DATA_T + 20496))
								{
									int num26 = ref file_DATA_T + 24;
									int num30 = ref file_DATA_T + 28;
									do
									{
										ptr2 = (global::FDISystem.FDIGroupSequenceTable<FDISystem::FDI_TYPE_V2>*)(this.m_pData + num25 + *(ref file_DATA_T + 8));
										int fdibyteOrder16 = (int)this.FDIByteOrder;
										b10 = *(byte*)ptr2;
										if (fdibyteOrder16 == 1)
										{
											byte b12 = b10;
											b10 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020char,unsigned\u0020char>(b12, b12);
										}
										else
										{
											b10 = b10;
										}
										int num31 = (int)b10;
										int fdibyteOrder17 = (int)this.FDIByteOrder;
										ushort num32 = *(ushort*)(ptr2 + 2 / sizeof(global::FDISystem.FDIGroupSequenceTable<FDISystem::FDI_TYPE_V2>));
										if (fdibyteOrder17 == 1)
										{
											ushort num33 = num32;
											num32 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,unsigned\u0020short>(num33, num33);
										}
										else
										{
											num32 = num32;
										}
										if (num31 == *num30 && (int)num32 == *num26)
										{
											num19++;
											num28 = num29;
										}
										num29++;
										num30 += 20;
										num26 += 20;
									}
									while (num29 < *(ref file_DATA_T + 20496));
									if (num19 == 1)
									{
										num30 = num28 * 20;
										num26 = *(num30 + (ref file_DATA_T + 32));
										if (0 < num26)
										{
											num30 = *(num30 + (ref file_DATA_T + 20));
											int num34 = 0;
											uint num35 = (uint)num26;
											do
											{
												ptr2 = (global::FDISystem.FDIGroupSequenceTable<FDISystem::FDI_TYPE_V2>*)(this.m_pData + num30 + num34);
												int fdibyteOrder18 = (int)this.FDIByteOrder;
												ptr3 = ptr2 + 1 / sizeof(global::FDISystem.FDIGroupSequenceTable<FDISystem::FDI_TYPE_V2>);
												b10 = *(byte*)ptr3;
												if (fdibyteOrder18 == 1)
												{
													byte b13 = b10;
													b10 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020char,unsigned\u0020char>(b13, b13);
												}
												else
												{
													b10 = b10;
												}
												if (((b10 == 31) ? 1 : 0) != 0)
												{
													int num36 = 0;
													if (0 < *(ref file_DATA_T + 102424))
													{
														num26 = ref file_DATA_T + 20516;
														int num37 = ref file_DATA_T + 20512;
														int num38 = ref file_DATA_T + 20520;
														uint num39 = (uint)(*(ref file_DATA_T + 102424));
														do
														{
															ptr2 = (global::FDISystem.FDIGroupSequenceTable<FDISystem::FDI_TYPE_V2>*)(this.m_pData + num30 + num34);
															int fdibyteOrder19 = (int)this.FDIByteOrder;
															b10 = *(byte*)ptr2;
															if (fdibyteOrder19 == 1)
															{
																byte b14 = b10;
																b10 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020char,unsigned\u0020char>(b14, b14);
															}
															else
															{
																b10 = b10;
															}
															int num31 = (int)b10;
															int fdibyteOrder20 = (int)this.FDIByteOrder;
															ushort num32 = *(ushort*)(ptr2 + 2 / sizeof(global::FDISystem.FDIGroupSequenceTable<FDISystem::FDI_TYPE_V2>));
															if (fdibyteOrder20 == 1)
															{
																ushort num40 = num32;
																num32 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,unsigned\u0020short>(num40, num40);
															}
															else
															{
																num32 = num32;
															}
															if (num31 == *num38 && (int)num32 == *num37 && num24 == *num26)
															{
																int fdibyteOrder21 = (int)this.FDIByteOrder;
																b10 = *(byte*)(ptr2 + 4 / sizeof(global::FDISystem.FDIGroupSequenceTable<FDISystem::FDI_TYPE_V2>));
																if (fdibyteOrder21 == 1)
																{
																	byte b15 = b10;
																	b10 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020char,unsigned\u0020char>(b15, b15);
																}
																else
																{
																	b10 = b10;
																}
																int fdibyteOrder22 = (int)this.FDIByteOrder;
																num32 = *(ushort*)(ptr + 2 / sizeof(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V2>));
																if (fdibyteOrder22 == 1)
																{
																	ushort num41 = num32;
																	num32 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,unsigned\u0020short>(num41, num41);
																}
																else
																{
																	num32 = num32;
																}
																if ((ushort)b10 != num32)
																{
																	num++;
																}
																else
																{
																	int fdibyteOrder23 = (int)this.FDIByteOrder;
																	num32 = *(ushort*)(ptr + 2 / sizeof(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V2>));
																	if (fdibyteOrder23 == 1)
																	{
																		ushort num42 = num32;
																		num32 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,unsigned\u0020short>(num42, num42);
																	}
																	else
																	{
																		num32 = num32;
																	}
																	*pMaxSize += (int)(this.m_unitGranularity * (uint)num32);
																}
																num36++;
															}
															num38 += 20;
															num37 += 20;
															num26 += 20;
															num39 -= 1U;
														}
														while (num39 > 0U);
														if (num36 == 1)
														{
															int fdibyteOrder24 = (int)this.FDIByteOrder;
															b10 = *(byte*)(ptr2 + 4 / sizeof(global::FDISystem.FDIGroupSequenceTable<FDISystem::FDI_TYPE_V2>));
															if (fdibyteOrder24 == 1)
															{
																byte b16 = b10;
																global::<Module>.FDISystem.ReverseBytes<unsigned\u0020char,unsigned\u0020char>(b16, b16);
																goto IL_A92;
															}
															goto IL_A92;
														}
													}
													num++;
												}
												else
												{
													int fdibyteOrder25 = (int)this.FDIByteOrder;
													b10 = *(byte*)ptr3;
													if (fdibyteOrder25 == 1)
													{
														byte b17 = b10;
														b10 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020char,unsigned\u0020char>(b17, b17);
													}
													else
													{
														b10 = b10;
													}
													if (((b10 == 255) ? 1 : 0) == 0)
													{
														num++;
													}
												}
												IL_A92:
												num34 += 10;
												num35 -= 1U;
											}
											while (num35 > 0U);
											goto IL_AD7;
										}
										goto IL_AD7;
									}
								}
								num++;
							}
							else
							{
								int fdibyteOrder26 = (int)this.FDIByteOrder;
								b10 = *(byte*)ptr3;
								if (fdibyteOrder26 == 1)
								{
									byte b18 = b10;
									b10 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020char,unsigned\u0020char>(b18, b18);
								}
								else
								{
									b10 = b10;
								}
								if (((b10 == 255) ? 1 : 0) == 0)
								{
									num++;
								}
							}
							IL_AD7:
							num24++;
							num25 += 10;
						}
						while (num24 < *(ref file_DATA_T + 12));
					}
					if (0 < *(ref file_DATA_T + 20496))
					{
						int num43 = ref file_DATA_T + 24;
						int num44 = ref file_DATA_T + 28;
						uint num45 = (uint)(*(ref file_DATA_T + 20496));
						for (;;)
						{
							int num19 = 0;
							if (0 >= *(ref file_DATA_T + 12))
							{
								goto IL_BCD;
							}
							int num46 = 0;
							uint num47 = (uint)(*(ref file_DATA_T + 12));
							do
							{
								global::FDISystem.FDIGroupSequenceTable<FDISystem::FDI_TYPE_V2>* ptr2 = (global::FDISystem.FDIGroupSequenceTable<FDISystem::FDI_TYPE_V2>*)(this.m_pData + num46 + *(ref file_DATA_T + 8));
								int fdibyteOrder27 = (int)this.FDIByteOrder;
								byte b10 = *(byte*)(ptr2 + 1 / sizeof(global::FDISystem.FDIGroupSequenceTable<FDISystem::FDI_TYPE_V2>));
								if (fdibyteOrder27 == 1)
								{
									byte b19 = b10;
									b10 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020char,unsigned\u0020char>(b19, b19);
								}
								else
								{
									b10 = b10;
								}
								if (((b10 == 31) ? 1 : 0) != 0)
								{
									int fdibyteOrder28 = (int)this.FDIByteOrder;
									b10 = *(byte*)ptr2;
									if (fdibyteOrder28 == 1)
									{
										byte b20 = b10;
										b10 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020char,unsigned\u0020char>(b20, b20);
									}
									else
									{
										b10 = b10;
									}
									int num48 = (int)b10;
									int fdibyteOrder29 = (int)this.FDIByteOrder;
									ushort num49 = *(ushort*)(ptr2 + 2 / sizeof(global::FDISystem.FDIGroupSequenceTable<FDISystem::FDI_TYPE_V2>));
									if (fdibyteOrder29 == 1)
									{
										ushort num50 = num49;
										num49 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,unsigned\u0020short>(num50, num50);
									}
									else
									{
										num49 = num49;
									}
									if (num48 == *num44 && (int)num49 == *num43)
									{
										num19++;
									}
								}
								num46 += 10;
								num47 -= 1U;
							}
							while (num47 > 0U);
							if (num19 != 1)
							{
								goto IL_BCD;
							}
							IL_BD1:
							num44 += 20;
							num43 += 20;
							num45 -= 1U;
							if (num45 <= 0U)
							{
								break;
							}
							continue;
							IL_BCD:
							num++;
							goto IL_BD1;
						}
					}
					if (*(ref file_DATA_T + 20500) != *(ref file_DATA_T + 102424))
					{
						num++;
					}
					if (num != 0)
					{
						return num2;
					}
				}
			}
			if (*reclaiming == 0)
			{
				if (file_DATA_T == 1)
				{
					*pMaxSize = *(ref file_DATA_T + 102460);
					num2 = *(ref file_DATA_T + 102444);
				}
				else if (file_DATA_T == 2)
				{
					int num51 = this.m_pData + *(ref file_DATA_T + 102428);
					global::FDISystem.ByteOrder fdibyteOrder30 = this.FDIByteOrder;
					ushort num49 = *(num51 + 2);
					if (fdibyteOrder30 == global::FDISystem.ByteOrder.BigEndian)
					{
						ushort num52 = num49;
						num49 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,unsigned\u0020short>(num52, num52);
					}
					else
					{
						num49 = num49;
					}
					*pMaxSize = (int)(this.m_unitGranularity * (uint)num49);
					num2 = *(ref file_DATA_T + 102428);
				}
				else
				{
					num2 = ((file_DATA_T == 3) ? (*(ref file_DATA_T + 4)) : num2);
				}
			}
			return num2;
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x00008D24 File Offset: 0x00008124
		public int ValidateFreeSpace()
		{
			int num = 0;
			if (0U < this.m_numOfBlocks)
			{
				while (this.IsBlockHasEnoughFreeSpace(num))
				{
					num++;
					if (num >= (int)this.m_numOfBlocks)
					{
						return -1;
					}
				}
				return num;
			}
			return -1;
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x000069D0 File Offset: 0x00005DD0
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
		public unsafe static bool IsDataBlock(byte* blockHeaderBuffer, uint size, global::FDISystem.ByteOrder byteOrder)
		{
			if (blockHeaderBuffer == null)
			{
				throw new global::System.ArgumentNullException("pBlockHeaderBuffer");
			}
			if (size != 16U)
			{
				return false;
			}
			byte b = blockHeaderBuffer[8];
			byte b3;
			if (byteOrder == global::FDISystem.ByteOrder.BigEndian)
			{
				byte b2 = b;
				b3 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020char,unsigned\u0020char>(b2, b2);
			}
			else
			{
				b3 = b;
			}
			if (b3 != 240)
			{
				byte b4 = blockHeaderBuffer[8];
				byte b6;
				if (byteOrder == global::FDISystem.ByteOrder.BigEndian)
				{
					byte b5 = b4;
					b6 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020char,unsigned\u0020char>(b5, b5);
				}
				else
				{
					b6 = b4;
				}
				if (b6 != 248)
				{
					byte b7 = blockHeaderBuffer[8];
					byte b9;
					if (byteOrder == global::FDISystem.ByteOrder.BigEndian)
					{
						byte b8 = b7;
						b9 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020char,unsigned\u0020char>(b8, b8);
					}
					else
					{
						b9 = b7;
					}
					if (b9 != 252)
					{
						byte b10 = blockHeaderBuffer[8];
						byte b12;
						if (byteOrder == global::FDISystem.ByteOrder.BigEndian)
						{
							byte b11 = b10;
							b12 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020char,unsigned\u0020char>(b11, b11);
						}
						else
						{
							b12 = b10;
						}
						if (b12 != 254)
						{
							goto IL_C0;
						}
					}
				}
			}
			ushort num = *(ushort*)(blockHeaderBuffer + 14);
			ushort num3;
			if (byteOrder == global::FDISystem.ByteOrder.BigEndian)
			{
				ushort num2 = num;
				num3 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,unsigned\u0020short>(num2, num2);
			}
			else
			{
				num3 = num;
			}
			int num4;
			if (num3 == 61680)
			{
				num4 = 1;
				goto IL_C2;
			}
			IL_C0:
			num4 = 0;
			IL_C2:
			return (byte)num4 != 0;
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x00006C10 File Offset: 0x00006010
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
		private unsafe bool IsBlockHasEnoughFreeSpace(int blockNumber)
		{
			if (blockNumber >= 0 && blockNumber < (int)this.m_numOfBlocks)
			{
				uint blockSize = this.m_blockSize;
				byte* ptr = blockSize * (uint)blockNumber + this.m_pData;
				global::FDISystem.FDIBlockInfo<FDISystem::FDI_TYPE_V2>* ptr2 = (global::FDISystem.FDIBlockInfo<FDISystem::FDI_TYPE_V2>*)(ptr + blockSize - 16);
				int fdibyteOrder = (int)this.FDIByteOrder;
				ushort num = *(ushort*)(ptr2 + 14 / sizeof(global::FDISystem.FDIBlockInfo<FDISystem::FDI_TYPE_V2>));
				ushort num3;
				if (fdibyteOrder == 1)
				{
					ushort num2 = num;
					num3 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,unsigned\u0020short>(num2, num2);
				}
				else
				{
					num3 = num;
				}
				if (num3 == 61680)
				{
					int fdibyteOrder2 = (int)this.FDIByteOrder;
					byte b = *(byte*)(ptr2 + 8 / sizeof(global::FDISystem.FDIBlockInfo<FDISystem::FDI_TYPE_V2>));
					byte b3;
					if (fdibyteOrder2 == 1)
					{
						byte b2 = b;
						b3 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020char,unsigned\u0020char>(b2, b2);
					}
					else
					{
						b3 = b;
					}
					if (b3 == 240)
					{
						int fdibyteOrder3 = (int)this.FDIByteOrder;
						byte b4 = ptr[6];
						byte b6;
						if (fdibyteOrder3 == 1)
						{
							byte b5 = b4;
							b6 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020char,unsigned\u0020char>(b5, b5);
						}
						else
						{
							b6 = b4;
						}
						if (b6 == 255)
						{
							return true;
						}
						global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V2>* ptr3 = (global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V2>*)(ptr + 8);
						if (ptr3 < (global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V2>*)ptr2)
						{
							for (;;)
							{
								int fdibyteOrder4 = (int)this.FDIByteOrder;
								byte b7 = *(byte*)(ptr3 + 6 / sizeof(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V2>));
								byte b9;
								if (fdibyteOrder4 == 1)
								{
									byte b8 = b7;
									b9 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020char,unsigned\u0020char>(b8, b8);
								}
								else
								{
									b9 = b7;
								}
								if (b9 == 255)
								{
									break;
								}
								ptr3 += 8 / sizeof(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V2>);
								if (ptr3 >= (global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V2>*)ptr2)
								{
									goto IL_EE;
								}
							}
							ptr3 -= 8 / sizeof(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V2>);
						}
						IL_EE:
						int fdibyteOrder5 = (int)this.FDIByteOrder;
						ushort num4 = *(ushort*)(ptr3 + 4 / sizeof(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V2>));
						ushort num6;
						if (fdibyteOrder5 == 1)
						{
							ushort num5 = num4;
							num6 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,unsigned\u0020short>(num5, num5);
						}
						else
						{
							num6 = num4;
						}
						if ((ptr2 - this.UnitGranularity * (int)num6 / sizeof(global::FDISystem.FDIBlockInfo<FDISystem::FDI_TYPE_V2>) - ptr3 - 8) * 100 / (global::System.IntPtr)this.m_blockSize < 40)
						{
							return false;
						}
					}
				}
				return true;
			}
			throw new global::System.ArgumentOutOfRangeException();
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x00009A30 File Offset: 0x00008E30
		private unsafe int ValidateMultiInstance(int nOffset, bool* bReclaiming)
		{
			int num = -1;
			int num2 = 0;
			int num3 = -1;
			*bReclaiming = 0;
			int fdibyteOrder = (int)this.FDIByteOrder;
			ushort num4 = *(ushort*)(this.m_pData + nOffset);
			ushort num6;
			if (fdibyteOrder == 1)
			{
				ushort num5 = num4;
				num6 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,unsigned\u0020short>(num5, num5);
			}
			else
			{
				num6 = num4;
			}
			int num7 = (int)num6;
			int fdibyteOrder2 = (int)this.FDIByteOrder;
			ushort num8 = *(ushort*)(nOffset + this.m_pData + 2);
			ushort num10;
			if (fdibyteOrder2 == 1)
			{
				ushort num9 = num8;
				num10 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,unsigned\u0020short>(num9, num9);
			}
			else
			{
				num10 = num8;
			}
			int num11 = (int)num10;
			uint unitGranularity = this.m_unitGranularity;
			if (num7 <= (int)((unitGranularity - 6U) / 3U) && num11 >= 3 && num11 <= (int)((double)((float)(unitGranularity - 4U)) / ((double)num7 + 0.5)) && (int)(((double)((float)num7) + 0.5) * (double)((float)num11) + 4.5) <= (int)unitGranularity)
			{
				int num12 = 0;
				if (0 < num11)
				{
					do
					{
						byte* pData = this.m_pData;
						byte b = (byte)((uint)(nOffset + (((uint)num12 >> 1) + pData))[4] >> (int)((byte)(4 - ((num12 & 1) << 2))) & 15U);
						if (b == 1)
						{
							if (num3 != -1)
							{
								num2 = 1;
							}
						}
						else if (b == 3)
						{
							if (num3 != -1)
							{
								num2 = 1;
							}
							else
							{
								num3 = num12;
								num = global::<Module>.FDISystem.FDI_TYPE_V2.GetMultiInstLoc((byte*)this.m_pData, nOffset, num12, this.FDIByteOrder);
							}
						}
						else if ((((nOffset + (pData + num12))[4] == 252) ? 1 : 0) != 0)
						{
							*bReclaiming = 1;
							num2 = 1;
						}
						else if (this.MultiInstanceIsEmpty(nOffset, num12))
						{
							if (num3 == -1)
							{
								num2 = 1;
							}
						}
						else
						{
							num2 = 1;
						}
						num12++;
					}
					while (num12 < num11);
					num = ((num2 == 1) ? -1 : num);
				}
			}
			return num;
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x00004C80 File Offset: 0x00004080
		private unsafe void InitializeBlocksInfo()
		{
			int num = 0;
			if (0 < this.m_maxBlocksNum - 1)
			{
				do
				{
					global::FDISystem.FDIBlockInfo<FDISystem::FDI_TYPE_V2>* ptr = (global::FDISystem.FDIBlockInfo<FDISystem::FDI_TYPE_V2>*)(this.m_pData + this.m_blockSize * (uint)(num + 1) - 16);
					initblk(ptr, 0, 16);
					uint destVar = (uint)(*(int*)ptr);
					uint num2;
					if (this.m_byteOrder == global::FDISystem.ByteOrder.BigEndian)
					{
						num2 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020int,unsigned\u0020int>(destVar, uint.MaxValue);
					}
					else
					{
						num2 = uint.MaxValue;
					}
					*(int*)ptr = (int)num2;
					uint destVar2 = (uint)(*(int*)(ptr + 4 / sizeof(global::FDISystem.FDIBlockInfo<FDISystem::FDI_TYPE_V2>)));
					uint num3;
					if (this.m_byteOrder == global::FDISystem.ByteOrder.BigEndian)
					{
						num3 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020int,unsigned\u0020int>(destVar2, uint.MaxValue);
					}
					else
					{
						num3 = uint.MaxValue;
					}
					*(int*)(ptr + 4 / sizeof(global::FDISystem.FDIBlockInfo<FDISystem::FDI_TYPE_V2>)) = (int)num3;
					byte destVar3 = *(byte*)(ptr + 8 / sizeof(global::FDISystem.FDIBlockInfo<FDISystem::FDI_TYPE_V2>));
					byte b;
					if (this.m_byteOrder == global::FDISystem.ByteOrder.BigEndian)
					{
						b = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020char,unsigned\u0020int>(destVar3, 240U);
					}
					else
					{
						b = 240;
					}
					*(byte*)(ptr + 8 / sizeof(global::FDISystem.FDIBlockInfo<FDISystem::FDI_TYPE_V2>)) = b;
					byte destVar4 = *(byte*)(ptr + 9 / sizeof(global::FDISystem.FDIBlockInfo<FDISystem::FDI_TYPE_V2>));
					byte b2;
					if (this.m_byteOrder == global::FDISystem.ByteOrder.BigEndian)
					{
						b2 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020char,unsigned\u0020int>(destVar4, (uint)num);
					}
					else
					{
						b2 = (byte)num;
					}
					*(byte*)(ptr + 9 / sizeof(global::FDISystem.FDIBlockInfo<FDISystem::FDI_TYPE_V2>)) = b2;
					byte destVar5 = *(byte*)(ptr + 10 / sizeof(global::FDISystem.FDIBlockInfo<FDISystem::FDI_TYPE_V2>));
					byte b3;
					if (this.m_byteOrder == global::FDISystem.ByteOrder.BigEndian)
					{
						b3 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020char,unsigned\u0020int>(destVar5, 1U);
					}
					else
					{
						b3 = 1;
					}
					*(byte*)(ptr + 10 / sizeof(global::FDISystem.FDIBlockInfo<FDISystem::FDI_TYPE_V2>)) = b3;
					ushort destVar6 = *(ushort*)(ptr + 14 / sizeof(global::FDISystem.FDIBlockInfo<FDISystem::FDI_TYPE_V2>));
					ushort num4;
					if (this.m_byteOrder == global::FDISystem.ByteOrder.BigEndian)
					{
						num4 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,unsigned\u0020int>(destVar6, 61680U);
					}
					else
					{
						num4 = 61680;
					}
					*(short*)(ptr + 14 / sizeof(global::FDISystem.FDIBlockInfo<FDISystem::FDI_TYPE_V2>)) = (short)num4;
					num++;
				}
				while (num < (int)(this.m_maxBlocksNum - 1));
			}
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x00001DCC File Offset: 0x000011CC
		private unsafe int CalculateVersion(byte* byBuffer)
		{
			uint num = 0U;
			uint maxBlocksNum = (uint)this.m_maxBlocksNum;
			if (0U < maxBlocksNum)
			{
				uint blockSize = this.m_blockSize;
				uint num2 = blockSize - 16U;
				byte* ptr = byBuffer;
				do
				{
					uint num3 = 0U;
					if (0U < num2)
					{
						byte* ptr2 = ptr;
						do
						{
							uint num4 = 0U;
							byte* ptr3 = ptr2;
							while (*ptr3 == 255)
							{
								num4 += 1U;
								ptr3++;
								if (num4 >= 4U)
								{
									break;
								}
							}
							if (num4 == 4U)
							{
								break;
							}
							num3 += 4U;
							ptr2 += 4;
						}
						while (num3 < num2);
						if (num3 != 0U && (num3 & 7U) == 0U)
						{
							return 1;
						}
					}
					num += 1U;
					ptr = blockSize + ptr;
				}
				while (num < maxBlocksNum);
				return 0;
			}
			return 0;
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x00007350 File Offset: 0x00006750
		private unsafe int CalculateGranularity(byte* byBuffer)
		{
			uint num = 0U;
			if (0 < this.m_maxBlocksNum)
			{
				do
				{
					int num2 = 0;
					global::FDISystem.FDIBlockInfo<FDISystem::FDI_TYPE_V2>* ptr = byBuffer + this.m_blockSize * (num + 1U) - 16;
					if (global::<Module>.FDISystem.FDIBlockInfo<FDISystem::FDI_TYPE_V2>.IsValid(ptr, this.m_byteOrder) && global::<Module>.FDISystem.FDIBlockInfo<FDISystem::FDI_TYPE_V2>.IsWrite(ptr, this.m_byteOrder))
					{
						int num3 = 0;
						bool flag = true;
						global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V2>* ptr2 = this.m_blockSize * num + byBuffer;
						for (;;)
						{
							byte b = *(byte*)(ptr2 + 6 / sizeof(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V2>));
							byte b3;
							if (this.m_byteOrder == global::FDISystem.ByteOrder.BigEndian)
							{
								byte b2 = b;
								b3 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020char,unsigned\u0020char>(b2, b2);
							}
							else
							{
								b3 = b;
							}
							if (b3 != 255)
							{
								byte b4 = *(byte*)(ptr2 + 6 / sizeof(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V2>));
								if (((b4 == 7) ? 1 : 0) != 0)
								{
									goto IL_D6;
								}
								byte b5 = b4;
								byte b7;
								if (this.m_byteOrder == global::FDISystem.ByteOrder.BigEndian)
								{
									byte b6 = b5;
									b7 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020char,unsigned\u0020char>(b6, b6);
								}
								else
								{
									b7 = b5;
								}
								if (b7 == 6)
								{
									goto IL_D6;
								}
								flag = false;
								ushort num4 = *(ushort*)(ptr2 + 4 / sizeof(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V2>));
								ushort num6;
								if (this.m_byteOrder == global::FDISystem.ByteOrder.BigEndian)
								{
									ushort num5 = num4;
									num6 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,unsigned\u0020short>(num5, num5);
								}
								else
								{
									num6 = num4;
								}
								num3 = (int)num6;
								IL_D9:
								num2 += 8;
								ptr2 = this.m_blockSize * num + (uint)num2 + byBuffer;
								continue;
								IL_D6:
								flag = true;
								goto IL_D9;
							}
							break;
						}
						if (num3 >= 15 && !flag)
						{
							uint blockSize = this.m_blockSize;
							byte* ptr3 = byBuffer + (blockSize * num + (uint)num2) + 8;
							if (*(byte*)ptr3 == 255)
							{
								byte* ptr4 = byBuffer + blockSize * (num + 1U) - 16;
								while (ptr3 < ptr4)
								{
									ptr3 += 1 / sizeof(byte);
									if (*(byte*)ptr3 != 255)
									{
										break;
									}
								}
							}
							int num7 = (byBuffer / sizeof(byte) + (blockSize * (num + 1U) - ptr3) + 15 / sizeof(byte) & -32) / num3;
							if (num7 == 32)
							{
								goto IL_16A;
							}
							if (num7 == 128)
							{
								goto IL_174;
							}
						}
					}
					num += 1U;
				}
				while (num < (uint)this.m_maxBlocksNum);
				goto IL_17F;
				IL_16A:
				this.m_unitGranularity = 32U;
				goto IL_17F;
				IL_174:
				this.m_unitGranularity = 128U;
			}
			IL_17F:
			uint unitGranularity = this.m_unitGranularity;
			return (unitGranularity == 32U || unitGranularity == 128U) ? 1 : 0;
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x00005AB0 File Offset: 0x00004EB0
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
		private unsafe bool CalculateSectorSize(byte* byBuffer, uint nBufferLength)
		{
			ushort maxBlocksNum;
			if (nBufferLength != null)
			{
				global::_ldiv_t ldiv_t = global::<Module>.ldiv(nBufferLength, this.m_blockSize);
				if (*(ref ldiv_t + 4) != 0)
				{
					return false;
				}
				ushort num = ldiv_t;
				this.m_maxBlocksNum = num;
				global::<CppImplementationDetails>.$ArrayType$$$BY01I $ArrayType$$$BY01I = 65536;
				*(ref $ArrayType$$$BY01I + 4) = 131072;
				global::std.auto_ptr<unsigned\u0020char> auto_ptr<unsigned_u0020char> = global::<Module>.new[]((uint)num);
				try
				{
					if (auto_ptr<unsigned_u0020char> == null)
					{
						throw new global::FDISystem.FDIException(global::FDISystem.FDIErrorCodes.OutOfRam);
					}
					int num2 = 0;
					for (;;)
					{
						initblk(auto_ptr<unsigned_u0020char>, 0, this.m_maxBlocksNum);
						int num3 = 0;
						this.m_maxBlocksNum = 0;
						uint num4 = (uint)(*(num2 * 4 + ref $ArrayType$$$BY01I));
						this.m_blockSize = num4;
						global::_ldiv_t ldiv_t2 = global::<Module>.ldiv(nBufferLength, num4);
						if (*(ref ldiv_t2 + 4) != 0)
						{
							break;
						}
						ushort num5 = ldiv_t2;
						this.m_maxBlocksNum = num5;
						int num6 = 0;
						if (0 >= num5)
						{
							goto IL_17A;
						}
						do
						{
							global::FDISystem.FDIBlockInfo<FDISystem::FDI_TYPE_V2>* ptr = byBuffer + this.m_blockSize * (uint)(num6 + 1) - 16;
							int fdibyteOrder = (int)this.FDIByteOrder;
							byte b = *(byte*)(ptr + 9 / sizeof(global::FDISystem.FDIBlockInfo<FDISystem::FDI_TYPE_V2>));
							byte b3;
							if (fdibyteOrder == 1)
							{
								byte b2 = b;
								b3 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020char,unsigned\u0020char>(b2, b2);
							}
							else
							{
								b3 = b;
							}
							if ((ushort)b3 <= this.m_maxBlocksNum)
							{
								int fdibyteOrder2 = (int)this.FDIByteOrder;
								byte b4 = *(byte*)(ptr + 9 / sizeof(global::FDISystem.FDIBlockInfo<FDISystem::FDI_TYPE_V2>));
								byte b6;
								if (fdibyteOrder2 == 1)
								{
									byte b5 = b4;
									b6 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020char,unsigned\u0020char>(b5, b5);
								}
								else
								{
									b6 = b4;
								}
								if (*(b6 + auto_ptr<unsigned_u0020char>) != 0)
								{
									break;
								}
								int fdibyteOrder3 = (int)this.FDIByteOrder;
								byte b7 = *(byte*)(ptr + 9 / sizeof(global::FDISystem.FDIBlockInfo<FDISystem::FDI_TYPE_V2>));
								byte b9;
								if (fdibyteOrder3 == 1)
								{
									byte b8 = b7;
									b9 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020char,unsigned\u0020char>(b8, b8);
								}
								else
								{
									b9 = b7;
								}
								*(b9 + auto_ptr<unsigned_u0020char>) = 1;
							}
							else
							{
								int fdibyteOrder4 = (int)this.FDIByteOrder;
								byte b10 = *(byte*)(ptr + 9 / sizeof(global::FDISystem.FDIBlockInfo<FDISystem::FDI_TYPE_V2>));
								byte b12;
								if (fdibyteOrder4 == 1)
								{
									byte b11 = b10;
									b12 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020char,unsigned\u0020char>(b11, b11);
								}
								else
								{
									b12 = b10;
								}
								if (b12 != 255)
								{
									break;
								}
								num3++;
							}
							num6++;
						}
						while (num6 < (int)this.m_maxBlocksNum);
						if (num3 <= 1)
						{
							goto IL_17A;
						}
						IL_1A5:
						num2++;
						if (num2 >= 2)
						{
							break;
						}
						continue;
						IL_17A:
						maxBlocksNum = this.m_maxBlocksNum;
						if (num6 != (int)maxBlocksNum)
						{
							goto IL_1A5;
						}
						num6 = 0;
						if (0 < maxBlocksNum)
						{
							do
							{
								if (*(auto_ptr<unsigned_u0020char> + num6) != 0)
								{
									num3++;
								}
								num6++;
							}
							while (num6 < (int)maxBlocksNum);
						}
						if (num3 == (int)maxBlocksNum)
						{
							break;
						}
						goto IL_1A5;
					}
				}
				catch
				{
					global::<Module>.___CxxCallUnwindDtor(ldftn(std.auto_ptr<unsigned\u0020char>.{dtor}), (void*)(&auto_ptr<unsigned_u0020char>));
					throw;
				}
				global::<Module>.delete(auto_ptr<unsigned_u0020char>);
			}
			maxBlocksNum = this.m_maxBlocksNum;
			this.m_numOfBlocks = (uint)maxBlocksNum;
			return maxBlocksNum != 0;
			try
			{
			}
			catch
			{
				global::std.auto_ptr<unsigned\u0020char> auto_ptr<unsigned_u0020char>;
				global::<Module>.___CxxCallUnwindDtor(ldftn(std.auto_ptr<unsigned\u0020char>.{dtor}), (void*)(&auto_ptr<unsigned_u0020char>));
				throw;
			}
		}

		// Token: 0x060001EA RID: 490 RVA: 0x00007500 File Offset: 0x00006900
		private unsafe int CheckFdiCorrectness(byte* byBuffer, uint nBufferLength)
		{
			if (nBufferLength != null)
			{
				byte* ptr = byBuffer;
				int num = 0;
				int num2 = 0;
				uint blockSize = this.m_blockSize;
				if (blockSize <= nBufferLength)
				{
					do
					{
						global::FDISystem.FDIBlockInfo<FDISystem::FDI_TYPE_V2>* ptr2 = (global::FDISystem.FDIBlockInfo<FDISystem::FDI_TYPE_V2>*)(ptr + blockSize / (uint)sizeof(byte) - 16 / sizeof(byte));
						if (num2 > 1)
						{
							return 0;
						}
						if (global::<Module>.FDISystem.FDIBlockInfo<FDISystem::FDI_TYPE_V2>.IsFreeBlock(ptr2, this.m_byteOrder))
						{
							num2++;
						}
						blockSize = this.m_blockSize;
						ptr = blockSize / (uint)sizeof(byte) + ptr;
						num++;
					}
					while ((blockSize - byBuffer) / sizeof(byte) + ptr == nBufferLength);
				}
				this.m_maxBlocksNum = (ushort)num;
			}
			return (this.m_maxBlocksNum != 0) ? 1 : 0;
		}

		// Token: 0x060001EB RID: 491 RVA: 0x00006058 File Offset: 0x00005458
		private unsafe int CalculateLocation(int unit_header)
		{
			if (unit_header >= 0 && unit_header < (int)this.m_dataLength)
			{
				int num = this.m_pData + unit_header;
				global::FDISystem.ByteOrder fdibyteOrder = this.FDIByteOrder;
				ushort num2 = *(num + 4);
				ushort num4;
				if (fdibyteOrder == global::FDISystem.ByteOrder.BigEndian)
				{
					ushort num3 = num2;
					num4 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,unsigned\u0020short>(num3, num3);
				}
				else
				{
					num4 = num2;
				}
				uint blockSize = this.m_blockSize;
				return (int)(blockSize + ((~(blockSize - 1U) & (uint)unit_header) - this.m_unitGranularity * (uint)num4) - 16U);
			}
			return -1;
		}

		// Token: 0x060001EC RID: 492 RVA: 0x00009328 File Offset: 0x00008728
		private unsafe int FindFirstAvailableId(int type)
		{
			int num = 65535;
			global::<CppImplementationDetails>.$ArrayType$$$BY0CAAA@E $ArrayType$$$BY0CAAA@E;
			initblk(ref $ArrayType$$$BY0CAAA@E, 0, 8192);
			this.FindAllUsedIds(ref $ArrayType$$$BY0CAAA@E, type);
			int num2 = 0;
			do
			{
				byte b = *(num2 + ref $ArrayType$$$BY0CAAA@E);
				if (b != 255)
				{
					num = 0;
					if ((b & 1) != 0)
					{
						byte b2 = b;
						do
						{
							b2 = (byte)((uint)b2 >> 1);
							num++;
						}
						while ((b2 & 1) != 0);
						*(num2 + ref $ArrayType$$$BY0CAAA@E) = b2;
					}
					num = num2 * 8 + num;
					num2 = 8192;
				}
				num2++;
			}
			while (num2 < 8192);
			return num;
		}

		// Token: 0x060001ED RID: 493 RVA: 0x00009398 File Offset: 0x00008798
		private unsafe global::FDISystem.FDIErrorCodes InsertSingleInstanceOnCertainBlock(int blockIndex, int id, byte* instance_data, int instance_size, int type)
		{
			uint unitGranularity = this.m_unitGranularity;
			int num_units = (instance_size + (int)unitGranularity - 1) / (int)unitGranularity;
			int num2;
			int num = this.CreateUnitHeaderOnCertainBlock(blockIndex, id, 0, num_units, type, 8, &num2);
			if (num == 0)
			{
				return global::FDISystem.FDIErrorCodes.FlashFull;
			}
			cpblk(this.m_pData + num, instance_data, instance_size);
			return global::FDISystem.FDIErrorCodes.None;
		}

		// Token: 0x060001EE RID: 494 RVA: 0x00007B48 File Offset: 0x00006F48
		private unsafe int CreateUnitHeaderOnCertainBlock(int blockIndex, int id, int table_number, int num_units, int type, int attribute, int* logical_block)
		{
			if (type != 0)
			{
				throw new global::System.NotImplementedException();
			}
			int num = -1;
			int num2 = 0;
			int num3 = -1;
			if (num_units > 0)
			{
				this.AllocateSpaceOnCertainBlock(blockIndex, &num, &num3, &num2, num_units, logical_block, 0);
				if (num2 != 0)
				{
					global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V2>* ptr = (global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V2>*)(this.m_pData + num);
					int fdibyteOrder = (int)this.FDIByteOrder;
					ushort destVar = *(ushort*)ptr;
					ushort num4;
					if (fdibyteOrder == 1)
					{
						num4 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,unsigned\u0020int>(destVar, (uint)id);
					}
					else
					{
						num4 = (ushort)id;
					}
					*(short*)ptr = (short)num4;
					global::FDISystem.ByteOrder fdibyteOrder2 = this.FDIByteOrder;
					int fdibyteOrder3 = (int)this.FDIByteOrder;
					ushort destVar2 = *(ushort*)(ptr + 2 / sizeof(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V2>));
					ushort num5;
					if (fdibyteOrder3 == 1)
					{
						num5 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,unsigned\u0020int>(destVar2, (uint)num_units);
					}
					else
					{
						num5 = (ushort)num_units;
					}
					*(short*)(ptr + 2 / sizeof(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V2>)) = (short)num5;
					int fdibyteOrder4 = (int)this.FDIByteOrder;
					ushort destVar3 = *(ushort*)(ptr + 4 / sizeof(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V2>));
					ushort num6;
					if (fdibyteOrder4 == 1)
					{
						num6 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,unsigned\u0020int>(destVar3, (uint)num3);
					}
					else
					{
						num6 = (ushort)num3;
					}
					*(short*)(ptr + 4 / sizeof(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V2>)) = (short)num6;
					int fdibyteOrder5 = (int)this.FDIByteOrder;
					byte destVar4 = *(byte*)(ptr + 6 / sizeof(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V2>));
					byte b;
					if (fdibyteOrder5 == 1)
					{
						b = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020char,unsigned\u0020int>(destVar4, 30U);
					}
					else
					{
						b = 30;
					}
					*(byte*)(ptr + 6 / sizeof(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V2>)) = b;
					global::<Module>.FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V2>.SetAttribute(ptr, (uint)attribute, this.FDIByteOrder);
					global::FDISystem.ByteOrder fdibyteOrder6 = this.FDIByteOrder;
					byte b2 = global::<Module>.FDISystem.FDIAdjustDataBytes<unsigned\u0020char,unsigned\u0020int>((byte)((uint)(*(byte*)(ptr + 7 / sizeof(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V2>))) >> 4), 0U, fdibyteOrder6);
					*(byte*)(ptr + 7 / sizeof(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V2>)) = (byte)((int)(*(byte*)(ptr + 7 / sizeof(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V2>)) & 15) | (int)b2 << 4);
					global::FDISystem.ByteOrder fdibyteOrder7 = this.FDIByteOrder;
				}
			}
			return num2;
		}

		// Token: 0x060001EF RID: 495 RVA: 0x0000648C File Offset: 0x0000588C
		private unsafe void AllocateSpaceOnCertainBlock(int blockIndex, int* unit_header, int* unit_offset, int* data_space, int units, int* logicalBlock, int type)
		{
			if (type != 0)
			{
				throw new global::System.NotImplementedException();
			}
			if (blockIndex >= 0 && blockIndex < (int)this.m_numOfBlocks)
			{
				global::FDISystem.FDIBlockInfo<FDISystem::FDI_TYPE_V2>* ptr = (global::FDISystem.FDIBlockInfo<FDISystem::FDI_TYPE_V2>*)(this.m_pData + this.m_blockSize * (uint)(blockIndex + 1) - 16);
				if (global::<Module>.FDISystem.FDIBlockInfo<FDISystem::FDI_TYPE_V2>.IsValid(ptr, this.FDIByteOrder) && global::<Module>.FDISystem.FDIBlockInfo<FDISystem::FDI_TYPE_V2>.IsWrite(ptr, this.FDIByteOrder))
				{
					int num = (int)(this.m_blockSize * (uint)blockIndex);
					*unit_header = num;
					global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V2>* ptr2 = (global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V2>*)(this.m_pData + num);
					for (;;)
					{
						int fdibyteOrder = (int)this.FDIByteOrder;
						byte b = *(byte*)(ptr2 + 6 / sizeof(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V2>));
						byte b3;
						if (fdibyteOrder == 1)
						{
							byte b2 = b;
							b3 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020char,unsigned\u0020char>(b2, b2);
						}
						else
						{
							b3 = b;
						}
						if (b3 == 255)
						{
							break;
						}
						*unit_header += 8;
						int num2 = *unit_header;
						ptr2 = (global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V2>*)(this.m_pData + num2);
					}
					int num3 = *unit_header;
					if (num3 == (int)(this.m_blockSize * (uint)blockIndex))
					{
						*unit_offset = units;
					}
					else
					{
						int num4 = this.m_pData + num3 - 8;
						global::FDISystem.ByteOrder fdibyteOrder2 = this.FDIByteOrder;
						ushort num5 = *(num4 + 4);
						ushort num7;
						if (fdibyteOrder2 == global::FDISystem.ByteOrder.BigEndian)
						{
							ushort num6 = num5;
							num7 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,unsigned\u0020short>(num6, num6);
						}
						else
						{
							num7 = num5;
						}
						*unit_offset = (int)num7 + units;
					}
					int num8 = (int)(this.m_blockSize * (uint)(blockIndex + 1) - this.m_unitGranularity * (uint)(*unit_offset) - 16U);
					*data_space = num8;
					int num9 = *unit_header;
					int num10 = num8 - num9 - 16;
					if (num10 >= 22282)
					{
						int fdibyteOrder3 = (int)this.FDIByteOrder;
						byte b4 = *(byte*)(ptr + 9 / sizeof(global::FDISystem.FDIBlockInfo<FDISystem::FDI_TYPE_V2>));
						byte b6;
						if (fdibyteOrder3 == 1)
						{
							byte b5 = b4;
							b6 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020char,unsigned\u0020char>(b5, b5);
						}
						else
						{
							b6 = b4;
						}
						*logicalBlock = (int)b6;
						return;
					}
					if (num10 >= 0)
					{
						int num11 = num9;
						int num12 = *unit_offset;
						int num13 = num8;
						int fdibyteOrder4 = (int)this.FDIByteOrder;
						byte b7 = *(byte*)(ptr + 9 / sizeof(global::FDISystem.FDIBlockInfo<FDISystem::FDI_TYPE_V2>));
						byte b9;
						if (fdibyteOrder4 == 1)
						{
							byte b8 = b7;
							b9 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020char,unsigned\u0020char>(b8, b8);
						}
						else
						{
							b9 = b7;
						}
						int num14 = (int)b9;
						if (num13 != 0)
						{
							*unit_header = num11;
							*unit_offset = num12;
							*data_space = num13;
							*logicalBlock = num14;
							return;
						}
					}
				}
				*data_space = 0;
				return;
			}
			throw new global::System.ArgumentOutOfRangeException("blockIndex");
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x00007C68 File Offset: 0x00007068
		private unsafe int FindFirst(int object_type)
		{
			int num = -1;
			int num2 = 0;
			int num3 = 0;
			if (0U < this.m_numOfBlocks)
			{
				while (num3 == 0)
				{
					uint blockSize = this.m_blockSize;
					int num4 = (int)(blockSize * (uint)num2);
					global::FDISystem.FDIBlockInfo<FDISystem::FDI_TYPE_V2>* ptr = (global::FDISystem.FDIBlockInfo<FDISystem::FDI_TYPE_V2>*)(this.m_pData + (num2 + 1) * (int)blockSize - 16);
					if (global::<Module>.FDISystem.FDIBlockInfo<FDISystem::FDI_TYPE_V2>.IsValid(ptr, this.FDIByteOrder) && global::<Module>.FDISystem.FDIBlockInfo<FDISystem::FDI_TYPE_V2>.IsWrite(ptr, this.FDIByteOrder))
					{
						global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V2>* ptr2 = (global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V2>*)(this.m_pData + num4);
						if (!global::<Module>.FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V2>.IsEmpty(ptr2, this.FDIByteOrder))
						{
							while (num4 + 16 - 8 < (int)(this.m_dataLength - 24U) && num3 == 0)
							{
								if (global::<Module>.FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V2>.IsValid(ptr2, this.FDIByteOrder) && (global::<Module>.FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V2>.GetType(ptr2, this.FDIByteOrder) == (uint)object_type || object_type == 22))
								{
									int fdibyteOrder = (int)this.FDIByteOrder;
									ushort num5 = *(ushort*)(ptr2 + 4 / sizeof(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V2>));
									ushort num7;
									if (fdibyteOrder == 1)
									{
										ushort num6 = num5;
										num7 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,unsigned\u0020short>(num6, num6);
									}
									else
									{
										num7 = num5;
									}
									int num8 = (int)num7;
									int fdibyteOrder2 = (int)this.FDIByteOrder;
									ushort num9 = *(ushort*)(ptr2 + 2 / sizeof(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V2>));
									ushort num11;
									if (fdibyteOrder2 == 1)
									{
										ushort num10 = num9;
										num11 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,unsigned\u0020short>(num10, num10);
									}
									else
									{
										num11 = num9;
									}
									int num12 = (int)num11;
									int num13 = this.CalculateLocation(num4);
									if (num8 >= 1)
									{
										uint unitGranularity = this.m_unitGranularity;
										if (num8 <= (int)((this.m_blockSize - 32U) / unitGranularity) && num12 >= 1 && num13 >= num4 + 16)
										{
											num = ((unitGranularity * (uint)num12 + (uint)num13 <= this.m_dataLength) ? num4 : num);
										}
									}
									num3 = 1;
								}
								num4 += 8;
								ptr2 = (global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V2>*)(this.m_pData + num4);
								if (global::<Module>.FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V2>.IsEmpty(ptr2, this.FDIByteOrder))
								{
									break;
								}
							}
						}
					}
					num2++;
					if (num2 >= (int)this.m_numOfBlocks)
					{
						break;
					}
				}
			}
			return num;
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x00007DF0 File Offset: 0x000071F0
		private unsafe int FindNext(int object_type, int unit_header)
		{
			int result = -1;
			int num = 0;
			if (unit_header >= 0 && unit_header <= (int)this.m_dataLength)
			{
				unit_header += 8;
				uint blockSize = this.m_blockSize;
				int num2 = unit_header / (int)blockSize;
				if (num2 < (int)this.m_numOfBlocks)
				{
					int num3 = num2 + 1;
					while (num == 0)
					{
						global::FDISystem.FDIBlockInfo<FDISystem::FDI_TYPE_V2>* ptr = (global::FDISystem.FDIBlockInfo<FDISystem::FDI_TYPE_V2>*)(this.m_pData + num3 * (int)blockSize - 16);
						if (global::<Module>.FDISystem.FDIBlockInfo<FDISystem::FDI_TYPE_V2>.IsValid(ptr, this.FDIByteOrder) && global::<Module>.FDISystem.FDIBlockInfo<FDISystem::FDI_TYPE_V2>.IsWrite(ptr, this.FDIByteOrder))
						{
							global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V2>* ptr2 = (global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V2>*)(this.m_pData + unit_header);
							if (!global::<Module>.FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V2>.IsEmpty(ptr2, this.FDIByteOrder))
							{
								while (num == 0 && unit_header + 16 - 8 < (int)(this.m_dataLength - 24U))
								{
									if ((global::<Module>.FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V2>.GetType(ptr2, this.FDIByteOrder) == (uint)object_type || object_type == 22) && global::<Module>.FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V2>.IsValid(ptr2, this.FDIByteOrder))
									{
										int fdibyteOrder = (int)this.FDIByteOrder;
										ushort num4 = *(ushort*)(ptr2 + 4 / sizeof(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V2>));
										ushort num6;
										if (fdibyteOrder == 1)
										{
											ushort num5 = num4;
											num6 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,unsigned\u0020short>(num5, num5);
										}
										else
										{
											num6 = num4;
										}
										int num7 = (int)num6;
										int fdibyteOrder2 = (int)this.FDIByteOrder;
										ushort num8 = *(ushort*)(ptr2 + 2 / sizeof(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V2>));
										ushort num10;
										if (fdibyteOrder2 == 1)
										{
											ushort num9 = num8;
											num10 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,unsigned\u0020short>(num9, num9);
										}
										else
										{
											num10 = num8;
										}
										int num11 = (int)num10;
										int num12 = this.CalculateLocation(unit_header);
										if (num7 >= 1)
										{
											uint unitGranularity = this.m_unitGranularity;
											if (num7 <= (int)((this.m_blockSize - 32U) / unitGranularity) && num11 >= 1 && num12 >= unit_header + 16 && unitGranularity * (uint)num11 + (uint)num12 <= this.m_dataLength)
											{
												num = 1;
												result = unit_header;
											}
										}
									}
									unit_header += 8;
									ptr2 = (global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V2>*)(this.m_pData + unit_header);
									if (global::<Module>.FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V2>.IsEmpty(ptr2, this.FDIByteOrder))
									{
										break;
									}
								}
							}
						}
						num2++;
						num3++;
						blockSize = this.m_blockSize;
						unit_header = (int)(blockSize * (uint)num2);
						if (num2 >= (int)this.m_numOfBlocks)
						{
							break;
						}
					}
				}
				return result;
			}
			return -1;
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x000060B0 File Offset: 0x000054B0
		private unsafe int FindLogicalBlock(int logical_block)
		{
			int result = -1;
			int num = 0;
			int num2 = 0;
			if (0U < this.m_numOfBlocks)
			{
				while (num2 == 0)
				{
					global::FDISystem.FDIBlockInfo<FDISystem::FDI_TYPE_V2>* ptr = (global::FDISystem.FDIBlockInfo<FDISystem::FDI_TYPE_V2>*)(this.m_pData + this.m_blockSize * (uint)(num + 1) - 16);
					int fdibyteOrder = (int)this.FDIByteOrder;
					ushort num3 = *(ushort*)(ptr + 14 / sizeof(global::FDISystem.FDIBlockInfo<FDISystem::FDI_TYPE_V2>));
					ushort num5;
					if (fdibyteOrder == 1)
					{
						ushort num4 = num3;
						num5 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,unsigned\u0020short>(num4, num4);
					}
					else
					{
						num5 = num3;
					}
					if (num5 == 61680)
					{
						int fdibyteOrder2 = (int)this.FDIByteOrder;
						byte b = *(byte*)(ptr + 8 / sizeof(global::FDISystem.FDIBlockInfo<FDISystem::FDI_TYPE_V2>));
						byte b3;
						if (fdibyteOrder2 == 1)
						{
							byte b2 = b;
							b3 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020char,unsigned\u0020char>(b2, b2);
						}
						else
						{
							b3 = b;
						}
						if (b3 == 240)
						{
							int fdibyteOrder3 = (int)this.FDIByteOrder;
							byte b4 = *(byte*)(ptr + 9 / sizeof(global::FDISystem.FDIBlockInfo<FDISystem::FDI_TYPE_V2>));
							byte b6;
							if (fdibyteOrder3 == 1)
							{
								byte b5 = b4;
								b6 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020char,unsigned\u0020char>(b5, b5);
							}
							else
							{
								b6 = b4;
							}
							if ((int)b6 == logical_block)
							{
								result = (int)(this.m_blockSize * (uint)num);
								num2 = 1;
							}
						}
					}
					num++;
					if (num >= (int)this.m_numOfBlocks)
					{
						break;
					}
				}
			}
			return result;
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x0000AB38 File Offset: 0x00009F38
		private unsafe global::FDISystem.FDIErrorCodes FetchMultiInstance(int hdr_loc, int iSize, byte* file_data)
		{
			bool flag = false;
			int num = this.CalculateLocation(hdr_loc);
			if (this.ValidateMultiInstance(num, ref flag) != -1 && num + iSize <= (int)this.m_dataLength)
			{
				cpblk(file_data, this.m_pData + num, iSize);
			}
			return global::FDISystem.FDIErrorCodes.Failure;
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x000079CC File Offset: 0x00006DCC
		private unsafe global::FDISystem.FDIErrorCodes FetchSingleInstance(int hdr_loc, int iSize, byte* file_data)
		{
			global::FDISystem.FDIErrorCodes result = global::FDISystem.FDIErrorCodes.None;
			int num = this.m_pData + hdr_loc;
			global::FDISystem.ByteOrder fdibyteOrder = this.FDIByteOrder;
			ushort num2 = *(num + 2);
			ushort num4;
			if (fdibyteOrder == global::FDISystem.ByteOrder.BigEndian)
			{
				ushort num3 = num2;
				num4 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,unsigned\u0020short>(num3, num3);
			}
			else
			{
				num4 = num2;
			}
			int num5 = (int)(this.m_unitGranularity * (uint)num4);
			int num6 = this.CalculateLocation(hdr_loc);
			if (iSize > num5)
			{
				if (num5 + num6 <= (int)this.m_dataLength)
				{
					cpblk(file_data, this.m_pData + num6, num5);
					result = global::FDISystem.FDIErrorCodes.Failure;
				}
				else
				{
					result = global::FDISystem.FDIErrorCodes.Failure;
				}
			}
			else if (num6 + iSize <= (int)this.m_dataLength)
			{
				cpblk(file_data, this.m_pData + num6, iSize);
			}
			else
			{
				result = global::FDISystem.FDIErrorCodes.Failure;
			}
			return result;
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x000093D8 File Offset: 0x000087D8
		private unsafe global::FDISystem.FDIErrorCodes FetchFragmented(int hdr_loc, int iSize, byte* file_data)
		{
			int num = 0;
			global::FDISystem.FDIErrorCodes fdierrorCodes = global::FDISystem.FDIErrorCodes.Failure;
			global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V2>* ptr = (global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V2>*)(this.m_pData + hdr_loc);
			int fdibyteOrder = (int)this.FDIByteOrder;
			ushort num2 = *(ushort*)ptr;
			ushort num4;
			if (fdibyteOrder == 1)
			{
				ushort num3 = num2;
				num4 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,unsigned\u0020short>(num3, num3);
			}
			else
			{
				num4 = num2;
			}
			int uid = (int)num4;
			int fdibyteOrder2 = (int)this.FDIByteOrder;
			byte b = (byte)((uint)(*(byte*)(ptr + 7 / sizeof(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V2>))) >> 4);
			byte b3;
			if (fdibyteOrder2 == 1)
			{
				byte b2 = b;
				b3 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020char,unsigned\u0020char>(b2, b2);
			}
			else
			{
				b3 = b;
			}
			int iType = (int)b3;
			int num5 = this.CalculateLocation(hdr_loc);
			int fdibyteOrder3 = (int)this.FDIByteOrder;
			ushort num6 = *(ushort*)(ptr + 2 / sizeof(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V2>));
			ushort num8;
			if (fdibyteOrder3 == 1)
			{
				ushort num7 = num6;
				num8 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,unsigned\u0020short>(num7, num7);
			}
			else
			{
				num8 = num6;
			}
			int num9 = (int)(this.m_unitGranularity * (uint)num8);
			int num10 = 0;
			int num11 = 0;
			global::FDISystem.FDIGroupSequenceTable<FDISystem::FDI_TYPE_V2>* ptr2 = (global::FDISystem.FDIGroupSequenceTable<FDISystem::FDI_TYPE_V2>*)(this.m_pData + num5);
			for (;;)
			{
				int fdibyteOrder4 = (int)this.FDIByteOrder;
				byte b4 = *(byte*)(ptr2 + 1 / sizeof(global::FDISystem.FDIGroupSequenceTable<FDISystem::FDI_TYPE_V2>));
				byte b6;
				if (fdibyteOrder4 == 1)
				{
					byte b5 = b4;
					b6 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020char,unsigned\u0020char>(b5, b5);
				}
				else
				{
					b6 = b4;
				}
				if (((b6 == 255) ? 1 : 0) != 0 || num10 >= num9 / 10 * 10)
				{
					break;
				}
				int fdibyteOrder5 = (int)this.FDIByteOrder;
				byte b7 = *(byte*)ptr2;
				byte b9;
				if (fdibyteOrder5 == 1)
				{
					byte b8 = b7;
					global::<Module>.std.reverse<unsigned\u0020char\u0020*>(&b8, ref b8 + 1);
					b9 = b8;
				}
				else
				{
					b9 = b7;
				}
				int logical_block = (int)b9;
				int fdibyteOrder6 = (int)this.FDIByteOrder;
				ushort num12 = *(ushort*)(ptr2 + 2 / sizeof(global::FDISystem.FDIGroupSequenceTable<FDISystem::FDI_TYPE_V2>));
				ushort obj_instance;
				if (fdibyteOrder6 == 1)
				{
					ushort num13 = num12;
					global::<Module>.std.reverse<unsigned\u0020char\u0020*>((byte*)(&num13), ref num13 + 2);
					obj_instance = num13;
				}
				else
				{
					obj_instance = num12;
				}
				int sector_start = this.FindLogicalBlock(logical_block);
				int num14;
				fdierrorCodes = this.FindTableInstance(sector_start, uid, iType, (int)obj_instance, 12, &num14);
				if (fdierrorCodes != global::FDISystem.FDIErrorCodes.None)
				{
					break;
				}
				global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V2>* ptr3 = (global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V2>*)(this.m_pData + num14);
				int num15 = this.CalculateLocation(num14);
				int fdibyteOrder7 = (int)this.FDIByteOrder;
				ushort num16 = *(ushort*)(ptr3 + 2 / sizeof(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V2>));
				ushort num18;
				if (fdibyteOrder7 == 1)
				{
					ushort num17 = num16;
					num18 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,unsigned\u0020short>(num17, num17);
				}
				else
				{
					num18 = num16;
				}
				int num19 = (int)(this.m_unitGranularity * (uint)num18);
				int num20 = 0;
				global::FDISystem.FDIGroupSequenceTable<FDISystem::FDI_TYPE_V2>* ptr4 = (global::FDISystem.FDIGroupSequenceTable<FDISystem::FDI_TYPE_V2>*)(this.m_pData + num15);
				for (;;)
				{
					int fdibyteOrder8 = (int)this.FDIByteOrder;
					byte b10 = *(byte*)(ptr4 + 1 / sizeof(global::FDISystem.FDIGroupSequenceTable<FDISystem::FDI_TYPE_V2>));
					byte b12;
					if (fdibyteOrder8 == 1)
					{
						byte b11 = b10;
						b12 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020char,unsigned\u0020char>(b11, b11);
					}
					else
					{
						b12 = b10;
					}
					if (((b12 == 255) ? 1 : 0) != 0 || num20 >= num19 / 10 * 10)
					{
						break;
					}
					int fdibyteOrder9 = (int)this.FDIByteOrder;
					byte b13 = *(byte*)ptr4;
					byte b15;
					if (fdibyteOrder9 == 1)
					{
						byte b14 = b13;
						b15 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020char,unsigned\u0020char>(b14, b14);
					}
					else
					{
						b15 = b13;
					}
					int logical_block2 = (int)b15;
					int fdibyteOrder10 = (int)this.FDIByteOrder;
					ushort num21 = *(ushort*)(ptr4 + 2 / sizeof(global::FDISystem.FDIGroupSequenceTable<FDISystem::FDI_TYPE_V2>));
					ushort obj_instance2;
					if (fdibyteOrder10 == 1)
					{
						ushort num22 = num21;
						obj_instance2 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,unsigned\u0020short>(num22, num22);
					}
					else
					{
						obj_instance2 = num21;
					}
					int sector_start2 = this.FindLogicalBlock(logical_block2);
					int num23;
					fdierrorCodes = this.FindFragmentInstance(sector_start2, uid, iType, (int)obj_instance2, num11, &num23);
					if (fdierrorCodes != global::FDISystem.FDIErrorCodes.None)
					{
						break;
					}
					int num24 = this.m_pData + num23;
					global::FDISystem.ByteOrder fdibyteOrder11 = this.FDIByteOrder;
					ushort num25 = *(num24 + 2);
					ushort num27;
					if (fdibyteOrder11 == global::FDISystem.ByteOrder.BigEndian)
					{
						ushort num26 = num25;
						num27 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,unsigned\u0020short>(num26, num26);
					}
					else
					{
						num27 = num25;
					}
					int num28 = (int)num27;
					int num29 = (int)(this.m_unitGranularity * (uint)num28);
					if (num29 + num <= iSize)
					{
						fdierrorCodes = this.FetchSingleInstance(num23, num29, file_data);
						if (fdierrorCodes != global::FDISystem.FDIErrorCodes.None)
						{
							break;
						}
						num29 = (int)(this.m_unitGranularity * (uint)num28);
						file_data = num29 + file_data;
						num = num29 + num;
					}
					else
					{
						int num30 = iSize - num;
						fdierrorCodes = this.FetchSingleInstance(num23, num30, file_data);
						if (fdierrorCodes != global::FDISystem.FDIErrorCodes.None)
						{
							break;
						}
						file_data = num30 + file_data;
					}
					num15 += 10;
					num20 += 10;
					ptr4 = (global::FDISystem.FDIGroupSequenceTable<FDISystem::FDI_TYPE_V2>*)(this.m_pData + num15);
				}
				num5 += 10;
				num10 += 10;
				ptr2 = (global::FDISystem.FDIGroupSequenceTable<FDISystem::FDI_TYPE_V2>*)(this.m_pData + num5);
				num11++;
			}
			return fdierrorCodes;
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x00007FA0 File Offset: 0x000073A0
		private unsafe global::FDISystem.FDIErrorCodes FindFragmentInstance(int sector_start, int uid, int iType, int obj_instance, int table_number, int* object_loc)
		{
			int num = sector_start;
			int num2 = 0;
			*object_loc = -1;
			if (sector_start >= 0 && sector_start <= (int)this.m_dataLength)
			{
				global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V2>* ptr = (global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V2>*)(this.m_pData + sector_start);
				for (;;)
				{
					int fdibyteOrder = (int)this.FDIByteOrder;
					byte b = *(byte*)(ptr + 6 / sizeof(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V2>));
					byte b3;
					if (fdibyteOrder == 1)
					{
						byte b2 = b;
						b3 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020char,unsigned\u0020char>(b2, b2);
					}
					else
					{
						b3 = b;
					}
					if (b3 == 255)
					{
						break;
					}
					if (num2 == obj_instance)
					{
						goto IL_129;
					}
					if (num >= (int)(this.m_blockSize + (uint)sector_start - 16U))
					{
						break;
					}
					int fdibyteOrder2 = (int)this.FDIByteOrder;
					byte b4 = (byte)((uint)(*(byte*)(ptr + 7 / sizeof(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V2>))) >> 4);
					byte b6;
					if (fdibyteOrder2 == 1)
					{
						byte b5 = b4;
						b6 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020char,unsigned\u0020char>(b5, b5);
					}
					else
					{
						b6 = b4;
					}
					if ((int)b6 == iType)
					{
						int fdibyteOrder3 = (int)this.FDIByteOrder;
						byte b7 = *(byte*)(ptr + 7 / sizeof(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V2>)) & 15;
						byte b9;
						if (fdibyteOrder3 == 1)
						{
							byte b8 = b7;
							b9 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020char,unsigned\u0020char>(b8, b8);
						}
						else
						{
							b9 = b7;
						}
						if (b9 == 0)
						{
							int fdibyteOrder4 = (int)this.FDIByteOrder;
							byte b10 = *(byte*)(ptr + 6 / sizeof(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V2>));
							byte b12;
							if (fdibyteOrder4 == 1)
							{
								byte b11 = b10;
								b12 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020char,unsigned\u0020char>(b11, b11);
							}
							else
							{
								b12 = b10;
							}
							if (b12 == 30)
							{
								int fdibyteOrder5 = (int)this.FDIByteOrder;
								ushort num3 = *(ushort*)ptr;
								ushort num5;
								if (fdibyteOrder5 == 1)
								{
									ushort num4 = num3;
									num5 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,unsigned\u0020short>(num4, num4);
								}
								else
								{
									num5 = num3;
								}
								if ((int)num5 == uid)
								{
									global::FDISystem.ByteOrder fdibyteOrder6 = this.FDIByteOrder;
									if (0 == table_number)
									{
										*object_loc = num;
										num2++;
									}
								}
							}
						}
					}
					num += 8;
					ptr = (global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V2>*)(this.m_pData + num);
				}
				if (num2 != obj_instance)
				{
					goto IL_133;
				}
				IL_129:
				if (*object_loc != -1)
				{
					return global::FDISystem.FDIErrorCodes.None;
				}
				IL_133:
				return global::FDISystem.FDIErrorCodes.Failure;
			}
			return global::FDISystem.FDIErrorCodes.Failure;
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x000080E8 File Offset: 0x000074E8
		private unsafe global::FDISystem.FDIErrorCodes FindTableInstance(int sector_start, int uid, int iType, int obj_instance, int entry_attr, int* object_loc)
		{
			int num = (int)(~(this.m_blockSize - 1U) & (uint)sector_start);
			int num2 = 0;
			*object_loc = -1;
			if (num >= 0 && num <= (int)this.m_dataLength)
			{
				global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V2>* ptr = (global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V2>*)(this.m_pData + num);
				for (;;)
				{
					int fdibyteOrder = (int)this.FDIByteOrder;
					byte b = *(byte*)(ptr + 6 / sizeof(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V2>));
					byte b3;
					if (fdibyteOrder == 1)
					{
						byte b2 = b;
						b3 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020char,unsigned\u0020char>(b2, b2);
					}
					else
					{
						b3 = b;
					}
					if (b3 == 255)
					{
						break;
					}
					if (num2 == obj_instance)
					{
						goto IL_129;
					}
					if (num >= (int)(this.m_blockSize + (uint)sector_start - 16U))
					{
						break;
					}
					int fdibyteOrder2 = (int)this.FDIByteOrder;
					byte b4 = (byte)((uint)(*(byte*)(ptr + 7 / sizeof(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V2>))) >> 4);
					byte b6;
					if (fdibyteOrder2 == 1)
					{
						byte b5 = b4;
						b6 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020char,unsigned\u0020char>(b5, b5);
					}
					else
					{
						b6 = b4;
					}
					if ((int)b6 == iType)
					{
						int fdibyteOrder3 = (int)this.FDIByteOrder;
						byte b7 = *(byte*)(ptr + 7 / sizeof(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V2>)) & 15;
						byte b9;
						if (fdibyteOrder3 == 1)
						{
							byte b8 = b7;
							b9 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020char,unsigned\u0020char>(b8, b8);
						}
						else
						{
							b9 = b7;
						}
						if ((int)b9 == entry_attr)
						{
							int fdibyteOrder4 = (int)this.FDIByteOrder;
							byte b10 = *(byte*)(ptr + 6 / sizeof(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V2>));
							byte b12;
							if (fdibyteOrder4 == 1)
							{
								byte b11 = b10;
								b12 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020char,unsigned\u0020char>(b11, b11);
							}
							else
							{
								b12 = b10;
							}
							if (b12 == 30)
							{
								int fdibyteOrder5 = (int)this.FDIByteOrder;
								ushort num3 = *(ushort*)ptr;
								ushort num5;
								if (fdibyteOrder5 == 1)
								{
									ushort num4 = num3;
									num5 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,unsigned\u0020short>(num4, num4);
								}
								else
								{
									num5 = num3;
								}
								if ((int)num5 == uid)
								{
									*object_loc = num;
									num2++;
								}
							}
						}
					}
					num += 8;
					ptr = (global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V2>*)(this.m_pData + num);
				}
				if (num2 != obj_instance)
				{
					goto IL_133;
				}
				IL_129:
				if (*object_loc != -1)
				{
					return global::FDISystem.FDIErrorCodes.None;
				}
				IL_133:
				return global::FDISystem.FDIErrorCodes.Failure;
			}
			return global::FDISystem.FDIErrorCodes.Failure;
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x0000236C File Offset: 0x0000176C
		private uint GetMaxEntriesInGroupTable()
		{
			return 255U;
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x00002210 File Offset: 0x00001610
		private int GetMaxSizeOfMultiInstance()
		{
			return (int)((this.m_unitGranularity - 6U) / 3U);
		}

		// Token: 0x060001FA RID: 506 RVA: 0x000024D0 File Offset: 0x000018D0
		private unsafe int MultiInstanceIsInvalid(int data_loc, int instance)
		{
			return (((uint)(data_loc + (this.m_pData + instance / 2))[4] >> (int)((byte)(4 - (instance % 2 << 2))) & 15U) == 1U) ? 1 : 0;
		}

		// Token: 0x060001FB RID: 507 RVA: 0x000024FC File Offset: 0x000018FC
		private unsafe int MultiInstanceIsValid(int data_loc, int instance)
		{
			return (((uint)(data_loc + (this.m_pData + instance / 2))[4] >> (int)((byte)(4 - (instance % 2 << 2))) & 15U) == 3U) ? 1 : 0;
		}

		// Token: 0x060001FC RID: 508 RVA: 0x0000899C File Offset: 0x00007D9C
		private unsafe int GetMultiInstLoc(int loc, int instance)
		{
			return global::<Module>.FDISystem.FDI_TYPE_V2.GetMultiInstLoc((byte*)this.m_pData, loc, instance, this.FDIByteOrder);
		}

		// Token: 0x060001FD RID: 509 RVA: 0x00002528 File Offset: 0x00001928
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
		private unsafe bool MultiInstanceIsAllocating(int data_loc, int instance)
		{
			return (((instance + (this.m_pData + data_loc))[4] == 252) ? 1 : 0) != 0;
		}

		// Token: 0x060001FE RID: 510 RVA: 0x0000254C File Offset: 0x0000194C
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
		private unsafe bool MultiInstanceIsEmpty(int data_loc, int instance)
		{
			return ((((uint)(data_loc + (this.m_pData + instance / 2))[4] >> (int)((byte)(4 - (instance % 2 << 2))) & 15U) == 15U) ? 1 : 0) != 0;
		}

		// Token: 0x060001FF RID: 511 RVA: 0x000030FC File Offset: 0x000024FC
		private int GetMaxEntriesInSequenceTable()
		{
			return (int)(this.m_unitGranularity / 10U);
		}

		// Token: 0x06000200 RID: 512 RVA: 0x00002824 File Offset: 0x00001C24
		[global::System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		protected void Dispose([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)] bool A_0)
		{
			if (A_0)
			{
				this.~FDICore<FDISystem::FDI_TYPE_V2>();
			}
			else
			{
				try
				{
					this.!FDICore<FDISystem::FDI_TYPE_V2>();
				}
				finally
				{
					base.Finalize();
				}
			}
		}

		// Token: 0x06000201 RID: 513 RVA: 0x0000323C File Offset: 0x0000263C
		public sealed void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x06000202 RID: 514 RVA: 0x00002868 File Offset: 0x00001C68
		protected sealed override void Finalize()
		{
			this.Dispose(false);
		}

		// Token: 0x04000040 RID: 64
		private ushort m_maxBlocksNum;

		// Token: 0x04000041 RID: 65
		private uint m_blockSize;

		// Token: 0x04000042 RID: 66
		private uint m_numOfBlocks;

		// Token: 0x04000043 RID: 67
		private unsafe byte* m_pData;

		// Token: 0x04000044 RID: 68
		private uint m_dataLength;

		// Token: 0x04000045 RID: 69
		private bool m_bIsValidated;

		// Token: 0x04000046 RID: 70
		private uint m_unitGranularity;

		// Token: 0x04000047 RID: 71
		private global::FDISystem.ByteOrder m_byteOrder;
	}
}
