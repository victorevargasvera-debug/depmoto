using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using <CppImplementationDetails>;
using std;

namespace FDISystem
{
	// Token: 0x02000008 RID: 8
	internal sealed class FDICore<FDISystem::FDI_TYPE_V5> : global::FDISystem.IFDI
	{
		// Token: 0x06000217 RID: 535 RVA: 0x00006AA4 File Offset: 0x00005EA4
		public unsafe FDICore<FDISystem::FDI_TYPE_V5>(uint nBlock, uint blockSize, uint granularity, global::FDISystem.ByteOrder byteOrder)
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

		// Token: 0x06000218 RID: 536 RVA: 0x00009DAC File Offset: 0x000091AC
		public unsafe FDICore<FDISystem::FDI_TYPE_V5>(byte[] fdiStream, global::FDISystem.ByteOrder byteOrder)
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

		// Token: 0x06000219 RID: 537 RVA: 0x000018C0 File Offset: 0x00000CC0
		private unsafe void ~FDICore<FDISystem::FDI_TYPE_V5>()
		{
			byte* pData = this.m_pData;
			if (pData != null)
			{
				global::<Module>.delete[]((void*)pData);
				this.m_pData = null;
			}
		}

		// Token: 0x0600021A RID: 538 RVA: 0x000018E4 File Offset: 0x00000CE4
		private unsafe void !FDICore<FDISystem::FDI_TYPE_V5>()
		{
			byte* pData = this.m_pData;
			if (pData != null)
			{
				global::<Module>.delete[]((void*)pData);
				this.m_pData = null;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600021B RID: 539 RVA: 0x0000175C File Offset: 0x00000B5C
		public int UnitGranularity
		{
			get
			{
				return (int)this.m_unitGranularity;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600021C RID: 540 RVA: 0x00001770 File Offset: 0x00000B70
		public global::FDISystem.FDIVersion Version
		{
			get
			{
				return global::FDISystem.FDIVersion.V5x;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600021D RID: 541 RVA: 0x00001780 File Offset: 0x00000B80
		public uint MaxBlocks
		{
			get
			{
				return (uint)this.m_maxBlocksNum;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600021E RID: 542 RVA: 0x00001794 File Offset: 0x00000B94
		public uint Blocks
		{
			get
			{
				return this.m_numOfBlocks;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600021F RID: 543 RVA: 0x000017A8 File Offset: 0x00000BA8
		public uint BlockSize
		{
			get
			{
				return this.m_blockSize;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000220 RID: 544 RVA: 0x000017BC File Offset: 0x00000BBC
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

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000221 RID: 545 RVA: 0x0000180C File Offset: 0x00000C0C
		public global::FDISystem.ByteOrder FDIByteOrder
		{
			get
			{
				return this.m_byteOrder;
			}
		}

		// Token: 0x06000222 RID: 546 RVA: 0x00009050 File Offset: 0x00008450
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

		// Token: 0x06000223 RID: 547 RVA: 0x0000BB44 File Offset: 0x0000AF44
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
					if (elemSize <= (unitGranularity - 7) / 3)
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

		// Token: 0x06000224 RID: 548 RVA: 0x0000BBA0 File Offset: 0x0000AFA0
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
					global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V5>* ptr = (global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V5>*)(this.m_pData + num3);
					int fdibyteOrder = (int)this.FDIByteOrder;
					byte b = *(byte*)(ptr + 8 / sizeof(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V5>)) & 15;
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
					if (b3 == 12)
					{
						this.FetchMultiInstance(num3, num, ref file_data);
					}
					else
					{
						int fdibyteOrder2 = (int)this.FDIByteOrder;
						byte b4 = *(byte*)(ptr + 8 / sizeof(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V5>)) & 15;
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
						if (b6 == 14)
						{
							this.FetchSingleInstance(num3, num, ref file_data);
						}
						else
						{
							int fdibyteOrder3 = (int)this.FDIByteOrder;
							byte b7 = *(byte*)(ptr + 8 / sizeof(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V5>)) & 15;
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
							if (b9 == 13)
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

		// Token: 0x06000225 RID: 549 RVA: 0x00009B98 File Offset: 0x00008F98
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

		// Token: 0x06000226 RID: 550 RVA: 0x000089BC File Offset: 0x00007DBC
		public unsafe global::System.Collections.Generic.List<uint> FindAllUsedIds(int type)
		{
			uint num = 0U;
			global::System.Collections.Generic.List<uint> list = new global::System.Collections.Generic.List<uint>();
			if (0U < this.m_numOfBlocks)
			{
				do
				{
					global::FDISystem.FDIBlockInfo<FDISystem::FDI_TYPE_V5>* ptr = (global::FDISystem.FDIBlockInfo<FDISystem::FDI_TYPE_V5>*)(this.m_pData + this.m_blockSize * (num + 1U) - 16);
					int fdibyteOrder = (int)this.FDIByteOrder;
					ushort num2 = *(ushort*)(ptr + 12 / sizeof(global::FDISystem.FDIBlockInfo<FDISystem::FDI_TYPE_V5>));
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
						byte b = *(byte*)(ptr + 14 / sizeof(global::FDISystem.FDIBlockInfo<FDISystem::FDI_TYPE_V5>));
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
						if (b3 == 0)
						{
							uint num5 = this.m_blockSize * num;
							global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V5>* ptr2 = (global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V5>*)(this.m_pData + num5);
							for (;;)
							{
								int fdibyteOrder3 = (int)this.FDIByteOrder;
								ushort num6 = *(ushort*)(ptr2 + 10 / sizeof(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V5>));
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
								if (num8 == 65535)
								{
									break;
								}
								int fdibyteOrder4 = (int)this.FDIByteOrder;
								byte b4 = (byte)((uint)(*(byte*)(ptr2 + 8 / sizeof(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V5>))) >> 4);
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
								if ((int)b6 == type)
								{
									int fdibyteOrder5 = (int)this.FDIByteOrder;
									ushort num9 = *(ushort*)(ptr2 + 10 / sizeof(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V5>));
									ushort num11;
									if (fdibyteOrder5 == 1)
									{
										ushort num10 = num9;
										num11 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,unsigned\u0020short>(num10, num10);
									}
									else
									{
										num11 = num9;
									}
									if (num11 == 65280)
									{
										int fdibyteOrder6 = (int)this.FDIByteOrder;
										ushort num12 = *(ushort*)ptr2;
										ushort item;
										if (fdibyteOrder6 == 1)
										{
											ushort num13 = num12;
											item = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,unsigned\u0020short>(num13, num13);
										}
										else
										{
											item = num12;
										}
										list.Add((uint)item);
									}
								}
								num5 += 12U;
								ptr2 = (global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V5>*)(this.m_pData + num5);
							}
						}
					}
					num += 1U;
				}
				while (num < this.m_numOfBlocks);
			}
			return list;
		}

		// Token: 0x06000227 RID: 551 RVA: 0x0000AB74 File Offset: 0x00009F74
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
			int num5 = (int)((this.m_blockSize - 40U) / 12U);
			num5 = ((num5 > 1024) ? 1024 : num5);
			int num6 = this.FindFirst(iType);
			if (num6 != -1)
			{
				global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V5>* ptr;
				do
				{
					ptr = (global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V5>*)(this.m_pData + num6);
					int fdibyteOrder = (int)this.FDIByteOrder;
					ushort num7 = *(ushort*)ptr;
					if (fdibyteOrder == 1)
					{
						ushort num8 = num7;
						global::<Module>.std.reverse<unsigned\u0020char\u0020*>((byte*)(&num8), ref num8 + 2);
						num7 = num8;
					}
					else
					{
						num7 = num7;
					}
					if ((int)num7 == iId)
					{
						int num9 = this.CalculateLocation(num6);
						if (global::<Module>.FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V5>.GetAttribute(ptr, this.FDIByteOrder) != 13U && global::<Module>.FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V5>.GetAttribute(ptr, this.FDIByteOrder) != 0U && global::<Module>.FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V5>.GetAttribute(ptr, this.FDIByteOrder) != 2U)
						{
							int fdibyteOrder2 = (int)this.FDIByteOrder;
							byte b = *(byte*)(ptr + 8 / sizeof(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V5>)) & 15;
							if (fdibyteOrder2 == 1)
							{
								byte b2 = b;
								b = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020char,unsigned\u0020char>(b2, b2);
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
									*(ref file_DATA_T + 102428) = num6;
									*(ref file_DATA_T + 102432) = num9;
									int fdibyteOrder3 = (int)this.FDIByteOrder;
									num7 = *(ushort*)(ptr + 4 / sizeof(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V5>));
									if (fdibyteOrder3 == 1)
									{
										ushort num10 = num7;
										num7 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,unsigned\u0020short>(num10, num10);
									}
									else
									{
										num7 = num7;
									}
									*(ref file_DATA_T + 102440) = (int)(this.m_unitGranularity * (uint)num7);
								}
								*(ref file_DATA_T + 102436) = *(ref file_DATA_T + 102436) + 1;
							}
							else
							{
								int fdibyteOrder4 = (int)this.FDIByteOrder;
								b = (*(byte*)(ptr + 8 / sizeof(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V5>)) & 15);
								if (fdibyteOrder4 == 1)
								{
									byte b3 = b;
									b = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020char,unsigned\u0020char>(b3, b3);
								}
								else
								{
									b = b;
								}
								if (b == 12)
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
										*(ref file_DATA_T + 102444) = num6;
										*(ref file_DATA_T + 102448) = num9;
										num9 = this.ValidateMultiInstance(num9, ref flag);
										if (num9 == -1)
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
											*(ref file_DATA_T + 102452) = num9;
											int fdibyteOrder5 = (int)this.FDIByteOrder;
											num7 = *(ushort*)(this.m_pData + *(ref file_DATA_T + 102448));
											if (fdibyteOrder5 == 1)
											{
												ushort num11 = num7;
												num7 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,unsigned\u0020short>(num11, num11);
											}
											else
											{
												num7 = num7;
											}
											*(ref file_DATA_T + 102460) = (int)num7;
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
							if (global::<Module>.FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V5>.GetAttribute(ptr, this.FDIByteOrder) == 13U)
							{
								if (*(ref file_DATA_T + 8) == 0)
								{
									*(ref file_DATA_T + 4) = num6;
									*(ref file_DATA_T + 8) = num9;
									int num12 = 0;
									int fdibyteOrder6 = (int)this.FDIByteOrder;
									num7 = *(ushort*)(ptr + 4 / sizeof(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V5>));
									if (fdibyteOrder6 == 1)
									{
										ushort num13 = num7;
										global::<Module>.std.reverse<unsigned\u0020char\u0020*>((byte*)(&num13), ref num13 + 2);
										num7 = num13;
									}
									else
									{
										num7 = num7;
									}
									int num14 = (int)(this.m_unitGranularity * (uint)num7 / 12U * 12U);
									global::FDISystem.FDIGroupSequenceTable<FDISystem::FDI_TYPE_V5>* ptr2 = (global::FDISystem.FDIGroupSequenceTable<FDISystem::FDI_TYPE_V5>*)(this.m_pData + num9);
									if (0 < num14)
									{
										while (!global::<Module>.FDISystem.FDIGroupSequenceTable<FDISystem::FDI_TYPE_V5>.GrpSeqStatusIsEmpty(ptr2, this.FDIByteOrder))
										{
											num12 += 12;
											*(ref file_DATA_T + 12) = *(ref file_DATA_T + 12) + 1;
											ptr2 = (global::FDISystem.FDIGroupSequenceTable<FDISystem::FDI_TYPE_V5>*)(this.m_pData + num12 + num9);
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
								byte b4 = *(byte*)(ptr + 8 / sizeof(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V5>)) & 15;
								if (fdibyteOrder7 == 1)
								{
									byte b5 = b4;
									b4 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020char,unsigned\u0020char>(b5, b5);
								}
								else
								{
									b4 = b4;
								}
								if (b4 == 0)
								{
									int fdibyteOrder8 = (int)this.FDIByteOrder;
									num7 = *(ushort*)(ptr + 4 / sizeof(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V5>));
									if (fdibyteOrder8 == 1)
									{
										ushort num15 = num7;
										num7 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,unsigned\u0020short>(num15, num15);
									}
									else
									{
										num7 = num7;
									}
									if (num7 != 1)
									{
										num++;
									}
									int fdibyteOrder9 = (int)this.FDIByteOrder;
									num7 = *(ushort*)(ptr + 4 / sizeof(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V5>));
									if (fdibyteOrder9 == 1)
									{
										ushort num16 = num7;
										num7 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,unsigned\u0020short>(num16, num16);
									}
									else
									{
										num7 = num7;
									}
									if (num7 >= 1)
									{
										uint blockSize = this.m_blockSize;
										int num17 = this.m_pData + (num6 / (int)blockSize + 1) * (int)blockSize - 16;
										global::FDISystem.ByteOrder fdibyteOrder10 = this.FDIByteOrder;
										num7 = *(num17 + 8);
										if (fdibyteOrder10 == global::FDISystem.ByteOrder.BigEndian)
										{
											ushort num18 = num7;
											num7 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,unsigned\u0020short>(num18, num18);
										}
										else
										{
											num7 = num7;
										}
										int num14 = (int)num7;
										int num12 = *(ref file_DATA_T + 20496);
										if (*(ref file_DATA_T + 20496) >= num5)
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
											*(num20 + (ref file_DATA_T + 16)) = num6;
											*(num22 + (ref file_DATA_T + 20)) = num9;
											*(num22 + (ref file_DATA_T + 24)) = num19 + 1;
											*(num22 + (ref file_DATA_T + 28)) = num14;
											*(num22 + (ref file_DATA_T + 32)) = 0;
											num19 = 0;
											global::FDISystem.FDIGroupSequenceTable<FDISystem::FDI_TYPE_V5>* ptr2 = (global::FDISystem.FDIGroupSequenceTable<FDISystem::FDI_TYPE_V5>*)(this.m_pData + num9);
											if (0U < this.m_unitGranularity / 12U * 12U)
											{
												do
												{
													int fdibyteOrder11 = (int)this.FDIByteOrder;
													b4 = *(byte*)(ptr2 + 10 / sizeof(global::FDISystem.FDIGroupSequenceTable<FDISystem::FDI_TYPE_V5>));
													if (fdibyteOrder11 == 1)
													{
														byte b6 = b4;
														b4 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020char,unsigned\u0020char>(b6, b6);
													}
													else
													{
														b4 = b4;
													}
													if (((b4 == 255) ? 1 : 0) != 0)
													{
														break;
													}
													num19 += 12;
													*(num22 + (ref file_DATA_T + 32)) = *(num22 + (ref file_DATA_T + 32)) + 1;
													ptr2 = (global::FDISystem.FDIGroupSequenceTable<FDISystem::FDI_TYPE_V5>*)(this.m_pData + num19 + num9);
												}
												while (num19 < (int)(this.m_unitGranularity / 12U * 12U));
											}
										}
										*(ref file_DATA_T + 20496) = *(ref file_DATA_T + 20496) + 1;
										*(ref file_DATA_T + 20500) = *(num12 * 20 + (ref file_DATA_T + 32)) + *(ref file_DATA_T + 20500);
									}
								}
								else
								{
									int fdibyteOrder12 = (int)this.FDIByteOrder;
									b4 = (*(byte*)(ptr + 8 / sizeof(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V5>)) & 15);
									if (fdibyteOrder12 == 1)
									{
										byte b7 = b4;
										b4 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020char,unsigned\u0020char>(b7, b7);
									}
									else
									{
										b4 = b4;
									}
									if (b4 == 2)
									{
										int fdibyteOrder13 = (int)this.FDIByteOrder;
										ushort num23 = *(ushort*)(ptr + 2 / sizeof(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V5>));
										if (fdibyteOrder13 == 1)
										{
											ushort num24 = num23;
											num23 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,unsigned\u0020short>(num24, num24);
										}
										else
										{
											num23 = num23;
										}
										int num19 = (int)num23;
										uint blockSize2 = this.m_blockSize;
										int num25 = this.m_pData + (num6 / (int)blockSize2 + 1) * (int)blockSize2 - 16;
										global::FDISystem.ByteOrder fdibyteOrder14 = this.FDIByteOrder;
										num23 = *(num25 + 8);
										if (fdibyteOrder14 == global::FDISystem.ByteOrder.BigEndian)
										{
											ushort num26 = num23;
											num23 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,unsigned\u0020short>(num26, num26);
										}
										else
										{
											num23 = num23;
										}
										int num27 = (int)num23;
										int num28 = 0;
										if (0 < *(ref file_DATA_T + 102424))
										{
											int num22 = ref file_DATA_T + 20516;
											int num29 = ref file_DATA_T + 20520;
											uint num30 = (uint)(*(ref file_DATA_T + 102424));
											do
											{
												if (*num29 == num27 && *num22 == num19)
												{
													num28++;
												}
												num29 += 20;
												num22 += 20;
												num30 -= 1U;
											}
											while (num30 > 0U);
										}
										if (*(ref file_DATA_T + 102424) < 4096)
										{
											int num29 = *(ref file_DATA_T + 102424) * 20;
											int num22 = num29;
											*(num29 + (ref file_DATA_T + 20504)) = num6;
											*(num22 + (ref file_DATA_T + 20508)) = num9;
											*(num22 + (ref file_DATA_T + 20512)) = num28 + 1;
											*(num22 + (ref file_DATA_T + 20520)) = num27;
											*(num22 + (ref file_DATA_T + 20516)) = num19;
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
					num6 = this.FindNext(iType, num6);
				}
				while (num6 != -1);
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
					int num27 = 0;
					if (0 < *(ref file_DATA_T + 12))
					{
						int num22 = 0;
						do
						{
							global::FDISystem.FDIGroupSequenceTable<FDISystem::FDI_TYPE_V5>* ptr2 = (global::FDISystem.FDIGroupSequenceTable<FDISystem::FDI_TYPE_V5>*)(this.m_pData + num22 + *(ref file_DATA_T + 8));
							int fdibyteOrder15 = (int)this.FDIByteOrder;
							global::FDISystem.FDIGroupSequenceTable<FDISystem::FDI_TYPE_V5>* ptr3 = ptr2 + 10 / sizeof(global::FDISystem.FDIGroupSequenceTable<FDISystem::FDI_TYPE_V5>);
							byte b8 = *(byte*)ptr3;
							if (fdibyteOrder15 == 1)
							{
								byte b9 = b8;
								b8 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020char,unsigned\u0020char>(b9, b9);
							}
							else
							{
								b8 = b8;
							}
							if (((b8 == 192) ? 1 : 0) != 0)
							{
								int num19 = 0;
								int num28 = -1;
								int num31 = 0;
								if (0 < *(ref file_DATA_T + 20496))
								{
									int num29 = ref file_DATA_T + 24;
									int num32 = ref file_DATA_T + 28;
									do
									{
										ptr2 = (global::FDISystem.FDIGroupSequenceTable<FDISystem::FDI_TYPE_V5>*)(this.m_pData + num22 + *(ref file_DATA_T + 8));
										int fdibyteOrder16 = (int)this.FDIByteOrder;
										ushort num33 = *(ushort*)ptr2;
										if (fdibyteOrder16 == 1)
										{
											ushort num34 = num33;
											num33 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,unsigned\u0020short>(num34, num34);
										}
										else
										{
											num33 = num33;
										}
										int num35 = (int)num33;
										int fdibyteOrder17 = (int)this.FDIByteOrder;
										num33 = *(ushort*)(ptr2 + 2 / sizeof(global::FDISystem.FDIGroupSequenceTable<FDISystem::FDI_TYPE_V5>));
										if (fdibyteOrder17 == 1)
										{
											ushort num36 = num33;
											num33 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,unsigned\u0020short>(num36, num36);
										}
										else
										{
											num33 = num33;
										}
										if (num35 == *num32 && (int)num33 == *num29)
										{
											num19++;
											num28 = num31;
										}
										num31++;
										num32 += 20;
										num29 += 20;
									}
									while (num31 < *(ref file_DATA_T + 20496));
									if (num19 == 1)
									{
										num32 = num28 * 20;
										num29 = *(num32 + (ref file_DATA_T + 32));
										if (0 < num29)
										{
											num32 = *(num32 + (ref file_DATA_T + 20));
											int num37 = 0;
											uint num38 = (uint)num29;
											do
											{
												ptr2 = (global::FDISystem.FDIGroupSequenceTable<FDISystem::FDI_TYPE_V5>*)(this.m_pData + num37 + num32);
												int fdibyteOrder18 = (int)this.FDIByteOrder;
												ptr3 = ptr2 + 10 / sizeof(global::FDISystem.FDIGroupSequenceTable<FDISystem::FDI_TYPE_V5>);
												b8 = *(byte*)ptr3;
												if (fdibyteOrder18 == 1)
												{
													byte b10 = b8;
													b8 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020char,unsigned\u0020char>(b10, b10);
												}
												else
												{
													b8 = b8;
												}
												if (((b8 == 192) ? 1 : 0) != 0)
												{
													int num39 = 0;
													if (0 < *(ref file_DATA_T + 102424))
													{
														num29 = ref file_DATA_T + 20516;
														int num40 = ref file_DATA_T + 20512;
														int num41 = ref file_DATA_T + 20520;
														uint num42 = (uint)(*(ref file_DATA_T + 102424));
														do
														{
															ptr2 = (global::FDISystem.FDIGroupSequenceTable<FDISystem::FDI_TYPE_V5>*)(this.m_pData + num37 + num32);
															int fdibyteOrder19 = (int)this.FDIByteOrder;
															ushort num33 = *(ushort*)ptr2;
															if (fdibyteOrder19 == 1)
															{
																ushort num43 = num33;
																num33 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,unsigned\u0020short>(num43, num43);
															}
															else
															{
																num33 = num33;
															}
															int num35 = (int)num33;
															int fdibyteOrder20 = (int)this.FDIByteOrder;
															num33 = *(ushort*)(ptr2 + 2 / sizeof(global::FDISystem.FDIGroupSequenceTable<FDISystem::FDI_TYPE_V5>));
															if (fdibyteOrder20 == 1)
															{
																ushort num44 = num33;
																num33 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,unsigned\u0020short>(num44, num44);
															}
															else
															{
																num33 = num33;
															}
															if (num35 == *num41 && (int)num33 == *num40 && num27 == *num29)
															{
																int fdibyteOrder21 = (int)this.FDIByteOrder;
																num33 = *(ushort*)(ptr2 + 8 / sizeof(global::FDISystem.FDIGroupSequenceTable<FDISystem::FDI_TYPE_V5>));
																if (fdibyteOrder21 == 1)
																{
																	ushort num45 = num33;
																	num33 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,unsigned\u0020short>(num45, num45);
																}
																else
																{
																	num33 = num33;
																}
																int fdibyteOrder22 = (int)this.FDIByteOrder;
																ushort num46 = *(ushort*)(ptr + 4 / sizeof(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V5>));
																if (fdibyteOrder22 == 1)
																{
																	ushort num47 = num46;
																	num46 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,unsigned\u0020short>(num47, num47);
																}
																else
																{
																	num46 = num46;
																}
																if (num33 != num46)
																{
																	num++;
																}
																else
																{
																	int fdibyteOrder23 = (int)this.FDIByteOrder;
																	num46 = *(ushort*)(ptr + 4 / sizeof(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V5>));
																	if (fdibyteOrder23 == 1)
																	{
																		ushort num48 = num46;
																		num46 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,unsigned\u0020short>(num48, num48);
																	}
																	else
																	{
																		num46 = num46;
																	}
																	*pMaxSize += (int)(this.m_unitGranularity * (uint)num46);
																}
																num39++;
															}
															num41 += 20;
															num40 += 20;
															num29 += 20;
															num42 -= 1U;
														}
														while (num42 > 0U);
														if (num39 == 1)
														{
															int fdibyteOrder24 = (int)this.FDIByteOrder;
															ushort num46 = *(ushort*)(ptr2 + 8 / sizeof(global::FDISystem.FDIGroupSequenceTable<FDISystem::FDI_TYPE_V5>));
															if (fdibyteOrder24 == 1)
															{
																ushort num49 = num46;
																global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,unsigned\u0020short>(num49, num49);
																goto IL_AD6;
															}
															goto IL_AD6;
														}
													}
													num++;
												}
												else
												{
													int fdibyteOrder25 = (int)this.FDIByteOrder;
													byte b11 = *(byte*)ptr3;
													if (fdibyteOrder25 == 1)
													{
														byte b12 = b11;
														b11 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020char,unsigned\u0020char>(b12, b12);
													}
													else
													{
														b11 = b11;
													}
													if (((b11 == 255) ? 1 : 0) == 0)
													{
														num++;
													}
												}
												IL_AD6:
												num37 += 12;
												num38 -= 1U;
											}
											while (num38 > 0U);
											goto IL_B21;
										}
										goto IL_B21;
									}
								}
								num++;
							}
							else
							{
								int fdibyteOrder26 = (int)this.FDIByteOrder;
								byte b11 = *(byte*)ptr3;
								if (fdibyteOrder26 == 1)
								{
									byte b13 = b11;
									b11 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020char,unsigned\u0020char>(b13, b13);
								}
								else
								{
									b11 = b11;
								}
								if (((b11 == 255) ? 1 : 0) == 0)
								{
									num++;
								}
							}
							IL_B21:
							num27++;
							num22 += 12;
						}
						while (num27 < *(ref file_DATA_T + 12));
					}
					if (0 < *(ref file_DATA_T + 20496))
					{
						int num50 = ref file_DATA_T + 24;
						int num51 = ref file_DATA_T + 28;
						uint num52 = (uint)(*(ref file_DATA_T + 20496));
						for (;;)
						{
							int num19 = 0;
							if (0 >= *(ref file_DATA_T + 12))
							{
								goto IL_C1B;
							}
							int num53 = 0;
							uint num54 = (uint)(*(ref file_DATA_T + 12));
							do
							{
								global::FDISystem.FDIGroupSequenceTable<FDISystem::FDI_TYPE_V5>* ptr2 = (global::FDISystem.FDIGroupSequenceTable<FDISystem::FDI_TYPE_V5>*)(this.m_pData + num53 + *(ref file_DATA_T + 8));
								int fdibyteOrder27 = (int)this.FDIByteOrder;
								byte b11 = *(byte*)(ptr2 + 10 / sizeof(global::FDISystem.FDIGroupSequenceTable<FDISystem::FDI_TYPE_V5>));
								if (fdibyteOrder27 == 1)
								{
									byte b14 = b11;
									b11 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020char,unsigned\u0020char>(b14, b14);
								}
								else
								{
									b11 = b11;
								}
								if (((b11 == 192) ? 1 : 0) != 0)
								{
									int fdibyteOrder28 = (int)this.FDIByteOrder;
									ushort num46 = *(ushort*)ptr2;
									if (fdibyteOrder28 == 1)
									{
										ushort num55 = num46;
										num46 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,unsigned\u0020short>(num55, num55);
									}
									else
									{
										num46 = num46;
									}
									int num56 = (int)num46;
									int fdibyteOrder29 = (int)this.FDIByteOrder;
									num46 = *(ushort*)(ptr2 + 2 / sizeof(global::FDISystem.FDIGroupSequenceTable<FDISystem::FDI_TYPE_V5>));
									if (fdibyteOrder29 == 1)
									{
										ushort num57 = num46;
										num46 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,unsigned\u0020short>(num57, num57);
									}
									else
									{
										num46 = num46;
									}
									if (num56 == *num51 && (int)num46 == *num50)
									{
										num19++;
									}
								}
								num53 += 12;
								num54 -= 1U;
							}
							while (num54 > 0U);
							if (num19 != 1)
							{
								goto IL_C1B;
							}
							IL_C1F:
							num51 += 20;
							num50 += 20;
							num52 -= 1U;
							if (num52 <= 0U)
							{
								break;
							}
							continue;
							IL_C1B:
							num++;
							goto IL_C1F;
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
					int num58 = this.m_pData + *(ref file_DATA_T + 102428);
					global::FDISystem.ByteOrder fdibyteOrder30 = this.FDIByteOrder;
					ushort num46 = *(num58 + 4);
					if (fdibyteOrder30 == global::FDISystem.ByteOrder.BigEndian)
					{
						ushort num59 = num46;
						num46 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,unsigned\u0020short>(num59, num59);
					}
					else
					{
						num46 = num46;
					}
					*pMaxSize = (int)(this.m_unitGranularity * (uint)num46);
					num2 = *(ref file_DATA_T + 102428);
				}
				else
				{
					num2 = ((file_DATA_T == 3) ? (*(ref file_DATA_T + 4)) : num2);
				}
			}
			return num2;
		}

		// Token: 0x06000228 RID: 552 RVA: 0x00008D58 File Offset: 0x00008158
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

		// Token: 0x06000229 RID: 553 RVA: 0x00006B40 File Offset: 0x00005F40
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
			byte b = blockHeaderBuffer[14];
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
			if (b3 != 0)
			{
				byte b4 = blockHeaderBuffer[14];
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
				if (b6 != 192)
				{
					byte b7 = blockHeaderBuffer[14];
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
					if (b9 != 240)
					{
						byte b10 = blockHeaderBuffer[14];
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
						if (b12 != 252)
						{
							goto IL_BF;
						}
					}
				}
			}
			ushort num = *(ushort*)(blockHeaderBuffer + 12);
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
				goto IL_C1;
			}
			IL_BF:
			num4 = 0;
			IL_C1:
			return (byte)num4 != 0;
		}

		// Token: 0x0600022A RID: 554 RVA: 0x00006EC0 File Offset: 0x000062C0
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
		private unsafe bool IsBlockHasEnoughFreeSpace(int blockNumber)
		{
			if (blockNumber >= 0 && blockNumber < (int)this.m_numOfBlocks)
			{
				uint blockSize = this.m_blockSize;
				byte* ptr = blockSize * (uint)blockNumber + this.m_pData;
				global::FDISystem.FDIBlockInfo<FDISystem::FDI_TYPE_V5>* ptr2 = (global::FDISystem.FDIBlockInfo<FDISystem::FDI_TYPE_V5>*)(ptr + blockSize - 16);
				int fdibyteOrder = (int)this.FDIByteOrder;
				ushort num = *(ushort*)(ptr2 + 12 / sizeof(global::FDISystem.FDIBlockInfo<FDISystem::FDI_TYPE_V5>));
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
					byte b = *(byte*)(ptr2 + 14 / sizeof(global::FDISystem.FDIBlockInfo<FDISystem::FDI_TYPE_V5>));
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
					if (b3 == 0)
					{
						int fdibyteOrder3 = (int)this.FDIByteOrder;
						ushort num4 = *(ushort*)(ptr + 10);
						ushort num6;
						if (fdibyteOrder3 == 1)
						{
							ushort num5 = num4;
							num6 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,unsigned\u0020short>(num5, num5);
						}
						else
						{
							num6 = num4;
						}
						if (num6 == 65535)
						{
							return true;
						}
						global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V5>* ptr3 = (global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V5>*)(ptr + 12);
						if (ptr3 < (global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V5>*)ptr2)
						{
							for (;;)
							{
								int fdibyteOrder4 = (int)this.FDIByteOrder;
								ushort num7 = *(ushort*)(ptr3 + 10 / sizeof(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V5>));
								ushort num9;
								if (fdibyteOrder4 == 1)
								{
									ushort num8 = num7;
									num9 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,unsigned\u0020short>(num8, num8);
								}
								else
								{
									num9 = num7;
								}
								if (num9 == 65535)
								{
									break;
								}
								ptr3 += 12 / sizeof(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V5>);
								if (ptr3 >= (global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V5>*)ptr2)
								{
									goto IL_EF;
								}
							}
							ptr3 -= 12 / sizeof(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V5>);
						}
						IL_EF:
						int fdibyteOrder5 = (int)this.FDIByteOrder;
						ushort num10 = *(ushort*)(ptr3 + 6 / sizeof(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V5>));
						ushort num12;
						if (fdibyteOrder5 == 1)
						{
							ushort num11 = num10;
							num12 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,unsigned\u0020short>(num11, num11);
						}
						else
						{
							num12 = num10;
						}
						if ((ptr2 - this.UnitGranularity * (int)num12 / sizeof(global::FDISystem.FDIBlockInfo<FDISystem::FDI_TYPE_V5>) - ptr3 - 12) * 100 / (global::System.IntPtr)this.m_blockSize < 40)
						{
							return false;
						}
					}
				}
				return true;
			}
			throw new global::System.ArgumentOutOfRangeException();
		}

		// Token: 0x0600022B RID: 555 RVA: 0x00009BE0 File Offset: 0x00008FE0
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
			if (num7 <= (int)((unitGranularity - 7U) / 3U) && num11 >= 3 && num11 <= (int)((unitGranularity - 4U) / (uint)(num7 + 1)) && (num7 + 1) * num11 + 4 <= (int)unitGranularity)
			{
				int num12 = 0;
				if (0 < num11)
				{
					do
					{
						byte b = (nOffset + (this.m_pData + num12))[4];
						if (b == 192)
						{
							if (num3 != -1)
							{
								num2 = 1;
							}
						}
						else if (b == 240)
						{
							if (num3 != -1)
							{
								num2 = 1;
							}
							else
							{
								num3 = num12;
								num = global::<Module>.FDISystem.FDI_TYPE_V5.GetMultiInstLoc((byte*)this.m_pData, nOffset, num12, this.FDIByteOrder);
							}
						}
						else if (this.MultiInstanceIsAllocating(nOffset, num12))
						{
							*bReclaiming = 1;
							num2 = 1;
						}
						else if ((((nOffset + (this.m_pData + num12))[4] == 255) ? 1 : 0) != 0)
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

		// Token: 0x0600022C RID: 556 RVA: 0x0000537C File Offset: 0x0000477C
		private unsafe void InitializeBlocksInfo()
		{
			int num = 0;
			if (0 < this.m_maxBlocksNum - 1)
			{
				do
				{
					global::FDISystem.FDIBlockInfo<FDISystem::FDI_TYPE_V5>* ptr = (global::FDISystem.FDIBlockInfo<FDISystem::FDI_TYPE_V5>*)(this.m_pData + this.m_blockSize * (uint)(num + 1) - 16);
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
					uint destVar2 = (uint)(*(int*)(ptr + 4 / sizeof(global::FDISystem.FDIBlockInfo<FDISystem::FDI_TYPE_V5>)));
					uint num3;
					if (this.m_byteOrder == global::FDISystem.ByteOrder.BigEndian)
					{
						num3 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020int,unsigned\u0020int>(destVar2, uint.MaxValue);
					}
					else
					{
						num3 = uint.MaxValue;
					}
					*(int*)(ptr + 4 / sizeof(global::FDISystem.FDIBlockInfo<FDISystem::FDI_TYPE_V5>)) = (int)num3;
					byte destVar3 = *(byte*)(ptr + 14 / sizeof(global::FDISystem.FDIBlockInfo<FDISystem::FDI_TYPE_V5>));
					byte b;
					if (this.m_byteOrder == global::FDISystem.ByteOrder.BigEndian)
					{
						b = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020char,unsigned\u0020int>(destVar3, 0U);
					}
					else
					{
						b = 0;
					}
					*(byte*)(ptr + 14 / sizeof(global::FDISystem.FDIBlockInfo<FDISystem::FDI_TYPE_V5>)) = b;
					ushort destVar4 = *(ushort*)(ptr + 8 / sizeof(global::FDISystem.FDIBlockInfo<FDISystem::FDI_TYPE_V5>));
					ushort num4;
					if (this.m_byteOrder == global::FDISystem.ByteOrder.BigEndian)
					{
						num4 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,unsigned\u0020int>(destVar4, (uint)num);
					}
					else
					{
						num4 = (ushort)num;
					}
					*(short*)(ptr + 8 / sizeof(global::FDISystem.FDIBlockInfo<FDISystem::FDI_TYPE_V5>)) = (short)num4;
					ushort destVar5 = *(ushort*)(ptr + 10 / sizeof(global::FDISystem.FDIBlockInfo<FDISystem::FDI_TYPE_V5>));
					ushort num5;
					if (this.m_byteOrder == global::FDISystem.ByteOrder.BigEndian)
					{
						num5 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,unsigned\u0020int>(destVar5, 1U);
					}
					else
					{
						num5 = 1;
					}
					*(short*)(ptr + 10 / sizeof(global::FDISystem.FDIBlockInfo<FDISystem::FDI_TYPE_V5>)) = (short)num5;
					ushort destVar6 = *(ushort*)(ptr + 12 / sizeof(global::FDISystem.FDIBlockInfo<FDISystem::FDI_TYPE_V5>));
					ushort num6;
					if (this.m_byteOrder == global::FDISystem.ByteOrder.BigEndian)
					{
						num6 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,unsigned\u0020int>(destVar6, 61680U);
					}
					else
					{
						num6 = 61680;
					}
					*(short*)(ptr + 12 / sizeof(global::FDISystem.FDIBlockInfo<FDISystem::FDI_TYPE_V5>)) = (short)num6;
					num++;
				}
				while (num < (int)(this.m_maxBlocksNum - 1));
			}
		}

		// Token: 0x0600022D RID: 557 RVA: 0x00001F24 File Offset: 0x00001324
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
						if (num3 != 0U)
						{
							uint num5 = num3;
							if (num5 - num5 / 12U * 12U == 0U)
							{
								return 1;
							}
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

		// Token: 0x0600022E RID: 558 RVA: 0x00007574 File Offset: 0x00006974
		private unsafe int CalculateGranularity(byte* byBuffer)
		{
			uint num = 0U;
			if (0 < this.m_maxBlocksNum)
			{
				do
				{
					int num2 = 0;
					global::FDISystem.FDIBlockInfo<FDISystem::FDI_TYPE_V5>* ptr = byBuffer + this.m_blockSize * (num + 1U) - 16;
					if (global::<Module>.FDISystem.FDIBlockInfo<FDISystem::FDI_TYPE_V5>.IsValid(ptr, this.m_byteOrder) && global::<Module>.FDISystem.FDIBlockInfo<FDISystem::FDI_TYPE_V5>.IsWrite(ptr, this.m_byteOrder))
					{
						int num3 = 0;
						bool flag = true;
						global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V5>* ptr2 = this.m_blockSize * num + byBuffer;
						for (;;)
						{
							ushort num4 = *(ushort*)(ptr2 + 10 / sizeof(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V5>));
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
							if (num6 == 65535)
							{
								break;
							}
							ushort num7 = *(ushort*)(ptr2 + 10 / sizeof(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V5>));
							ushort num9;
							if (this.m_byteOrder == global::FDISystem.ByteOrder.BigEndian)
							{
								ushort num8 = num7;
								num9 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,unsigned\u0020short>(num8, num8);
							}
							else
							{
								num9 = num7;
							}
							if (num9 != 61440)
							{
								flag = false;
								ushort num10 = *(ushort*)(ptr2 + 6 / sizeof(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V5>));
								ushort num12;
								if (this.m_byteOrder == global::FDISystem.ByteOrder.BigEndian)
								{
									ushort num11 = num10;
									num12 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,unsigned\u0020short>(num11, num11);
								}
								else
								{
									num12 = num10;
								}
								num3 = (int)num12;
							}
							else
							{
								flag = true;
							}
							num2 += 12;
							ptr2 = this.m_blockSize * num + (uint)num2 + byBuffer;
						}
						if (num3 >= 15 && !flag)
						{
							uint blockSize = this.m_blockSize;
							byte* ptr3 = byBuffer + (blockSize * num + (uint)num2) + 12;
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
							int num13 = (byBuffer / sizeof(byte) + (blockSize * (num + 1U) - ptr3) + 15 / sizeof(byte) & -32) / num3;
							if (num13 == 32)
							{
								goto IL_166;
							}
							if (num13 == 128)
							{
								goto IL_170;
							}
						}
					}
					num += 1U;
				}
				while (num < (uint)this.m_maxBlocksNum);
				goto IL_17B;
				IL_166:
				this.m_unitGranularity = 32U;
				goto IL_17B;
				IL_170:
				this.m_unitGranularity = 128U;
			}
			IL_17B:
			uint unitGranularity = this.m_unitGranularity;
			return (unitGranularity == 32U || unitGranularity == 128U) ? 1 : 0;
		}

		// Token: 0x0600022F RID: 559 RVA: 0x00007720 File Offset: 0x00006B20
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
							goto IL_175;
						}
						do
						{
							global::FDISystem.FDIBlockInfo<FDISystem::FDI_TYPE_V5>* ptr = byBuffer + this.m_blockSize * (uint)(num6 + 1) - 16;
							int fdibyteOrder = (int)this.FDIByteOrder;
							ushort num7 = *(ushort*)(ptr + 8 / sizeof(global::FDISystem.FDIBlockInfo<FDISystem::FDI_TYPE_V5>));
							ushort num9;
							if (fdibyteOrder == 1)
							{
								ushort num8 = num7;
								num9 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,unsigned\u0020short>(num8, num8);
							}
							else
							{
								num9 = num7;
							}
							if (num9 <= this.m_maxBlocksNum)
							{
								int fdibyteOrder2 = (int)this.FDIByteOrder;
								ushort num10 = *(ushort*)(ptr + 8 / sizeof(global::FDISystem.FDIBlockInfo<FDISystem::FDI_TYPE_V5>));
								ushort num12;
								if (fdibyteOrder2 == 1)
								{
									ushort num11 = num10;
									num12 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,unsigned\u0020short>(num11, num11);
								}
								else
								{
									num12 = num10;
								}
								if (*(num12 + auto_ptr<unsigned_u0020char>) != 0)
								{
									break;
								}
								int fdibyteOrder3 = (int)this.FDIByteOrder;
								ushort num13 = *(ushort*)(ptr + 8 / sizeof(global::FDISystem.FDIBlockInfo<FDISystem::FDI_TYPE_V5>));
								ushort num15;
								if (fdibyteOrder3 == 1)
								{
									ushort num14 = num13;
									num15 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,unsigned\u0020short>(num14, num14);
								}
								else
								{
									num15 = num13;
								}
								*(num15 + auto_ptr<unsigned_u0020char>) = 1;
							}
							else
							{
								int fdibyteOrder4 = (int)this.FDIByteOrder;
								ushort num16 = *(ushort*)(ptr + 8 / sizeof(global::FDISystem.FDIBlockInfo<FDISystem::FDI_TYPE_V5>));
								ushort num18;
								if (fdibyteOrder4 == 1)
								{
									ushort num17 = num16;
									num18 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,unsigned\u0020short>(num17, num17);
								}
								else
								{
									num18 = num16;
								}
								if (num18 != 65535)
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
							goto IL_175;
						}
						IL_1A0:
						num2++;
						if (num2 >= 2)
						{
							break;
						}
						continue;
						IL_175:
						maxBlocksNum = this.m_maxBlocksNum;
						if (num6 != (int)maxBlocksNum)
						{
							goto IL_1A0;
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
						goto IL_1A0;
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

		// Token: 0x06000230 RID: 560 RVA: 0x00007958 File Offset: 0x00006D58
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
						global::FDISystem.FDIBlockInfo<FDISystem::FDI_TYPE_V5>* ptr2 = (global::FDISystem.FDIBlockInfo<FDISystem::FDI_TYPE_V5>*)(ptr + blockSize / (uint)sizeof(byte) - 16 / sizeof(byte));
						if (num2 > 1)
						{
							return 0;
						}
						if (global::<Module>.FDISystem.FDIBlockInfo<FDISystem::FDI_TYPE_V5>.IsFreeBlock(ptr2, this.m_byteOrder))
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

		// Token: 0x06000231 RID: 561 RVA: 0x000061C4 File Offset: 0x000055C4
		private unsafe int CalculateLocation(int unit_header)
		{
			if (unit_header >= 0 && unit_header < (int)this.m_dataLength)
			{
				int num = this.m_pData + unit_header;
				global::FDISystem.ByteOrder fdibyteOrder = this.FDIByteOrder;
				ushort num2 = *(num + 6);
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

		// Token: 0x06000232 RID: 562 RVA: 0x0000B860 File Offset: 0x0000AC60
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

		// Token: 0x06000233 RID: 563 RVA: 0x000096E0 File Offset: 0x00008AE0
		private unsafe global::FDISystem.FDIErrorCodes InsertSingleInstanceOnCertainBlock(int blockIndex, int id, byte* instance_data, int instance_size, int type)
		{
			uint unitGranularity = this.m_unitGranularity;
			int num_units = (instance_size + (int)unitGranularity - 1) / (int)unitGranularity;
			int num2;
			int num = this.CreateUnitHeaderOnCertainBlock(blockIndex, id, 0, num_units, type, 14, &num2);
			if (num == 0)
			{
				return global::FDISystem.FDIErrorCodes.FlashFull;
			}
			cpblk(this.m_pData + num, instance_data, instance_size);
			return global::FDISystem.FDIErrorCodes.None;
		}

		// Token: 0x06000234 RID: 564 RVA: 0x00008230 File Offset: 0x00007630
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
					global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V5>* ptr = (global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V5>*)(this.m_pData + num);
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
					int fdibyteOrder2 = (int)this.FDIByteOrder;
					ushort destVar2 = *(ushort*)(ptr + 2 / sizeof(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V5>));
					ushort num5;
					if (fdibyteOrder2 == 1)
					{
						num5 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,unsigned\u0020int>(destVar2, (uint)table_number);
					}
					else
					{
						num5 = (ushort)table_number;
					}
					*(short*)(ptr + 2 / sizeof(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V5>)) = (short)num5;
					int fdibyteOrder3 = (int)this.FDIByteOrder;
					ushort destVar3 = *(ushort*)(ptr + 4 / sizeof(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V5>));
					ushort num6;
					if (fdibyteOrder3 == 1)
					{
						num6 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,unsigned\u0020int>(destVar3, (uint)num_units);
					}
					else
					{
						num6 = (ushort)num_units;
					}
					*(short*)(ptr + 4 / sizeof(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V5>)) = (short)num6;
					int fdibyteOrder4 = (int)this.FDIByteOrder;
					ushort destVar4 = *(ushort*)(ptr + 6 / sizeof(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V5>));
					ushort num7;
					if (fdibyteOrder4 == 1)
					{
						num7 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,unsigned\u0020int>(destVar4, (uint)num3);
					}
					else
					{
						num7 = (ushort)num3;
					}
					*(short*)(ptr + 6 / sizeof(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V5>)) = (short)num7;
					int fdibyteOrder5 = (int)this.FDIByteOrder;
					ushort destVar5 = *(ushort*)(ptr + 10 / sizeof(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V5>));
					ushort num8;
					if (fdibyteOrder5 == 1)
					{
						num8 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,unsigned\u0020int>(destVar5, 65280U);
					}
					else
					{
						num8 = 65280;
					}
					*(short*)(ptr + 10 / sizeof(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V5>)) = (short)num8;
					global::FDISystem.ByteOrder fdibyteOrder6 = this.FDIByteOrder;
					byte b = global::<Module>.FDISystem.FDIAdjustDataBytes<unsigned\u0020char,unsigned\u0020int>(*(byte*)(ptr + 8 / sizeof(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V5>)) & 15, (uint)attribute, fdibyteOrder6);
					*(byte*)(ptr + 8 / sizeof(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V5>)) = (((*(byte*)(ptr + 8 / sizeof(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V5>)) ^ b) & 15) ^ *(byte*)(ptr + 8 / sizeof(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V5>)));
					global::FDISystem.ByteOrder fdibyteOrder7 = this.FDIByteOrder;
					byte b2 = global::<Module>.FDISystem.FDIAdjustDataBytes<unsigned\u0020char,unsigned\u0020int>((byte)((uint)(*(byte*)(ptr + 8 / sizeof(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V5>))) >> 4), 0U, fdibyteOrder7);
					*(byte*)(ptr + 8 / sizeof(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V5>)) = (byte)((int)(*(byte*)(ptr + 8 / sizeof(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V5>)) & 15) | (int)b2 << 4);
					global::FDISystem.ByteOrder fdibyteOrder8 = this.FDIByteOrder;
					*(byte*)(ptr + 9 / sizeof(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V5>)) = global::<Module>.FDISystem.FDIAdjustDataBytes<unsigned\u0020char,int>(*(byte*)(ptr + 9 / sizeof(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V5>)), 0, fdibyteOrder8);
				}
			}
			return num2;
		}

		// Token: 0x06000235 RID: 565 RVA: 0x00006640 File Offset: 0x00005A40
		private unsafe void AllocateSpaceOnCertainBlock(int blockIndex, int* unit_header, int* unit_offset, int* data_space, int units, int* logicalBlock, int type)
		{
			if (type != 0)
			{
				throw new global::System.NotImplementedException();
			}
			if (blockIndex >= 0 && blockIndex < (int)this.m_numOfBlocks)
			{
				global::FDISystem.FDIBlockInfo<FDISystem::FDI_TYPE_V5>* ptr = (global::FDISystem.FDIBlockInfo<FDISystem::FDI_TYPE_V5>*)(this.m_pData + this.m_blockSize * (uint)(blockIndex + 1) - 16);
				if (global::<Module>.FDISystem.FDIBlockInfo<FDISystem::FDI_TYPE_V5>.IsValid(ptr, this.FDIByteOrder) && global::<Module>.FDISystem.FDIBlockInfo<FDISystem::FDI_TYPE_V5>.IsWrite(ptr, this.FDIByteOrder))
				{
					int num = (int)(this.m_blockSize * (uint)blockIndex);
					*unit_header = num;
					global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V5>* ptr2 = (global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V5>*)(this.m_pData + num);
					for (;;)
					{
						int fdibyteOrder = (int)this.FDIByteOrder;
						ushort num2 = *(ushort*)(ptr2 + 10 / sizeof(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V5>));
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
						if (num4 == 65535)
						{
							break;
						}
						*unit_header += 12;
						int num5 = *unit_header;
						ptr2 = (global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V5>*)(this.m_pData + num5);
					}
					int num6 = *unit_header;
					if (num6 == (int)(this.m_blockSize * (uint)blockIndex))
					{
						*unit_offset = units;
					}
					else
					{
						int num7 = this.m_pData + num6 - 12;
						global::FDISystem.ByteOrder fdibyteOrder2 = this.FDIByteOrder;
						ushort num8 = *(num7 + 6);
						ushort num10;
						if (fdibyteOrder2 == global::FDISystem.ByteOrder.BigEndian)
						{
							ushort num9 = num8;
							num10 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,unsigned\u0020short>(num9, num9);
						}
						else
						{
							num10 = num8;
						}
						*unit_offset = (int)num10 + units;
					}
					int num11 = (int)(this.m_blockSize * (uint)(blockIndex + 1) - this.m_unitGranularity * (uint)(*unit_offset) - 16U);
					*data_space = num11;
					int num12 = *unit_header;
					int num13 = num11 - num12 - 24;
					if (num13 >= 22282)
					{
						int fdibyteOrder3 = (int)this.FDIByteOrder;
						ushort num14 = *(ushort*)(ptr + 8 / sizeof(global::FDISystem.FDIBlockInfo<FDISystem::FDI_TYPE_V5>));
						ushort num16;
						if (fdibyteOrder3 == 1)
						{
							ushort num15 = num14;
							num16 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,unsigned\u0020short>(num15, num15);
						}
						else
						{
							num16 = num14;
						}
						*logicalBlock = (int)num16;
						return;
					}
					if (num13 >= 0)
					{
						int num17 = num12;
						int num18 = *unit_offset;
						int num19 = num11;
						int fdibyteOrder4 = (int)this.FDIByteOrder;
						ushort num20 = *(ushort*)(ptr + 8 / sizeof(global::FDISystem.FDIBlockInfo<FDISystem::FDI_TYPE_V5>));
						ushort num22;
						if (fdibyteOrder4 == 1)
						{
							ushort num21 = num20;
							num22 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,unsigned\u0020short>(num21, num21);
						}
						else
						{
							num22 = num20;
						}
						int num23 = (int)num22;
						if (num19 != 0)
						{
							*unit_header = num17;
							*unit_offset = num18;
							*data_space = num19;
							*logicalBlock = num23;
							return;
						}
					}
				}
				*data_space = 0;
				return;
			}
			throw new global::System.ArgumentOutOfRangeException("blockIndex");
		}

		// Token: 0x06000236 RID: 566 RVA: 0x000083A8 File Offset: 0x000077A8
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
					global::FDISystem.FDIBlockInfo<FDISystem::FDI_TYPE_V5>* ptr = (global::FDISystem.FDIBlockInfo<FDISystem::FDI_TYPE_V5>*)(this.m_pData + (num2 + 1) * (int)blockSize - 16);
					if (global::<Module>.FDISystem.FDIBlockInfo<FDISystem::FDI_TYPE_V5>.IsValid(ptr, this.FDIByteOrder) && global::<Module>.FDISystem.FDIBlockInfo<FDISystem::FDI_TYPE_V5>.IsWrite(ptr, this.FDIByteOrder))
					{
						global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V5>* ptr2 = (global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V5>*)(this.m_pData + num4);
						if (!global::<Module>.FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V5>.IsEmpty(ptr2, this.FDIByteOrder))
						{
							while (num4 + 24 - 12 < (int)(this.m_dataLength - 28U) && num3 == 0)
							{
								if (global::<Module>.FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V5>.IsValid(ptr2, this.FDIByteOrder) && (global::<Module>.FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V5>.GetType(ptr2, this.FDIByteOrder) == (uint)object_type || object_type == 22))
								{
									int fdibyteOrder = (int)this.FDIByteOrder;
									ushort num5 = *(ushort*)(ptr2 + 6 / sizeof(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V5>));
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
									ushort num9 = *(ushort*)(ptr2 + 4 / sizeof(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V5>));
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
										if (num8 <= (int)((this.m_blockSize - 40U) / unitGranularity) && num12 >= 1 && num13 >= num4 + 24)
										{
											num = ((unitGranularity * (uint)num12 + (uint)num13 <= this.m_dataLength) ? num4 : num);
										}
									}
									num3 = 1;
								}
								num4 += 12;
								ptr2 = (global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V5>*)(this.m_pData + num4);
								if (global::<Module>.FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V5>.IsEmpty(ptr2, this.FDIByteOrder))
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

		// Token: 0x06000237 RID: 567 RVA: 0x00008534 File Offset: 0x00007934
		private unsafe int FindNext(int object_type, int unit_header)
		{
			int result = -1;
			int num = 0;
			if (unit_header >= 0 && unit_header <= (int)this.m_dataLength)
			{
				unit_header += 12;
				uint blockSize = this.m_blockSize;
				int num2 = unit_header / (int)blockSize;
				if (num2 < (int)this.m_numOfBlocks)
				{
					int num3 = num2 + 1;
					while (num == 0)
					{
						global::FDISystem.FDIBlockInfo<FDISystem::FDI_TYPE_V5>* ptr = (global::FDISystem.FDIBlockInfo<FDISystem::FDI_TYPE_V5>*)(this.m_pData + num3 * (int)blockSize - 16);
						if (global::<Module>.FDISystem.FDIBlockInfo<FDISystem::FDI_TYPE_V5>.IsValid(ptr, this.FDIByteOrder) && global::<Module>.FDISystem.FDIBlockInfo<FDISystem::FDI_TYPE_V5>.IsWrite(ptr, this.FDIByteOrder))
						{
							global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V5>* ptr2 = (global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V5>*)(this.m_pData + unit_header);
							if (!global::<Module>.FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V5>.IsEmpty(ptr2, this.FDIByteOrder))
							{
								while (num == 0 && unit_header + 24 - 12 < (int)(this.m_dataLength - 28U))
								{
									if ((global::<Module>.FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V5>.GetType(ptr2, this.FDIByteOrder) == (uint)object_type || object_type == 22) && global::<Module>.FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V5>.IsValid(ptr2, this.FDIByteOrder))
									{
										int fdibyteOrder = (int)this.FDIByteOrder;
										ushort num4 = *(ushort*)(ptr2 + 6 / sizeof(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V5>));
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
										ushort num8 = *(ushort*)(ptr2 + 4 / sizeof(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V5>));
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
											if (num7 <= (int)((this.m_blockSize - 40U) / unitGranularity) && num11 >= 1 && num12 >= unit_header + 24 && unitGranularity * (uint)num11 + (uint)num12 <= this.m_dataLength)
											{
												num = 1;
												result = unit_header;
											}
										}
									}
									unit_header += 12;
									ptr2 = (global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V5>*)(this.m_pData + unit_header);
									if (global::<Module>.FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V5>.IsEmpty(ptr2, this.FDIByteOrder))
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

		// Token: 0x06000238 RID: 568 RVA: 0x0000621C File Offset: 0x0000561C
		private unsafe int FindLogicalBlock(int logical_block)
		{
			int result = -1;
			int num = 0;
			int num2 = 0;
			if (0U < this.m_numOfBlocks)
			{
				while (num2 == 0)
				{
					global::FDISystem.FDIBlockInfo<FDISystem::FDI_TYPE_V5>* ptr = (global::FDISystem.FDIBlockInfo<FDISystem::FDI_TYPE_V5>*)(this.m_pData + this.m_blockSize * (uint)(num + 1) - 16);
					int fdibyteOrder = (int)this.FDIByteOrder;
					ushort num3 = *(ushort*)(ptr + 12 / sizeof(global::FDISystem.FDIBlockInfo<FDISystem::FDI_TYPE_V5>));
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
						byte b = *(byte*)(ptr + 14 / sizeof(global::FDISystem.FDIBlockInfo<FDISystem::FDI_TYPE_V5>));
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
						if (b3 == 0)
						{
							int fdibyteOrder3 = (int)this.FDIByteOrder;
							ushort num6 = *(ushort*)(ptr + 8 / sizeof(global::FDISystem.FDIBlockInfo<FDISystem::FDI_TYPE_V5>));
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
							if ((int)num8 == logical_block)
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

		// Token: 0x06000239 RID: 569 RVA: 0x0000B8D0 File Offset: 0x0000ACD0
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

		// Token: 0x0600023A RID: 570 RVA: 0x00007A54 File Offset: 0x00006E54
		private unsafe global::FDISystem.FDIErrorCodes FetchSingleInstance(int hdr_loc, int iSize, byte* file_data)
		{
			global::FDISystem.FDIErrorCodes result = global::FDISystem.FDIErrorCodes.None;
			int num = this.m_pData + hdr_loc;
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

		// Token: 0x0600023B RID: 571 RVA: 0x00009724 File Offset: 0x00008B24
		private unsafe global::FDISystem.FDIErrorCodes FetchFragmented(int hdr_loc, int iSize, byte* file_data)
		{
			int num = 0;
			global::FDISystem.FDIErrorCodes fdierrorCodes = global::FDISystem.FDIErrorCodes.Failure;
			global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V5>* ptr = (global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V5>*)(this.m_pData + hdr_loc);
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
			byte b = (byte)((uint)(*(byte*)(ptr + 8 / sizeof(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V5>))) >> 4);
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
			ushort num6 = *(ushort*)(ptr + 4 / sizeof(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V5>));
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
			global::FDISystem.FDIGroupSequenceTable<FDISystem::FDI_TYPE_V5>* ptr2 = (global::FDISystem.FDIGroupSequenceTable<FDISystem::FDI_TYPE_V5>*)(this.m_pData + num5);
			for (;;)
			{
				int fdibyteOrder4 = (int)this.FDIByteOrder;
				byte b4 = *(byte*)(ptr2 + 10 / sizeof(global::FDISystem.FDIGroupSequenceTable<FDISystem::FDI_TYPE_V5>));
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
				if (((b6 == 255) ? 1 : 0) != 0 || num10 >= num9 / 12 * 12)
				{
					break;
				}
				int fdibyteOrder5 = (int)this.FDIByteOrder;
				ushort num12 = *(ushort*)ptr2;
				ushort num14;
				if (fdibyteOrder5 == 1)
				{
					ushort num13 = num12;
					global::<Module>.std.reverse<unsigned\u0020char\u0020*>((byte*)(&num13), ref num13 + 2);
					num14 = num13;
				}
				else
				{
					num14 = num12;
				}
				int logical_block = (int)num14;
				int fdibyteOrder6 = (int)this.FDIByteOrder;
				ushort num15 = *(ushort*)(ptr2 + 2 / sizeof(global::FDISystem.FDIGroupSequenceTable<FDISystem::FDI_TYPE_V5>));
				ushort obj_instance;
				if (fdibyteOrder6 == 1)
				{
					ushort num16 = num15;
					global::<Module>.std.reverse<unsigned\u0020char\u0020*>((byte*)(&num16), ref num16 + 2);
					obj_instance = num16;
				}
				else
				{
					obj_instance = num15;
				}
				int sector_start = this.FindLogicalBlock(logical_block);
				int num17;
				fdierrorCodes = this.FindTableInstance(sector_start, uid, iType, (int)obj_instance, 0, &num17);
				if (fdierrorCodes != global::FDISystem.FDIErrorCodes.None)
				{
					break;
				}
				global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V5>* ptr3 = (global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V5>*)(this.m_pData + num17);
				int num18 = this.CalculateLocation(num17);
				int fdibyteOrder7 = (int)this.FDIByteOrder;
				ushort num19 = *(ushort*)(ptr3 + 4 / sizeof(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V5>));
				ushort num21;
				if (fdibyteOrder7 == 1)
				{
					ushort num20 = num19;
					num21 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,unsigned\u0020short>(num20, num20);
				}
				else
				{
					num21 = num19;
				}
				int num22 = (int)(this.m_unitGranularity * (uint)num21);
				int num23 = 0;
				global::FDISystem.FDIGroupSequenceTable<FDISystem::FDI_TYPE_V5>* ptr4 = (global::FDISystem.FDIGroupSequenceTable<FDISystem::FDI_TYPE_V5>*)(this.m_pData + num18);
				for (;;)
				{
					int fdibyteOrder8 = (int)this.FDIByteOrder;
					byte b7 = *(byte*)(ptr4 + 10 / sizeof(global::FDISystem.FDIGroupSequenceTable<FDISystem::FDI_TYPE_V5>));
					byte b9;
					if (fdibyteOrder8 == 1)
					{
						byte b8 = b7;
						b9 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020char,unsigned\u0020char>(b8, b8);
					}
					else
					{
						b9 = b7;
					}
					if (((b9 == 255) ? 1 : 0) != 0 || num23 >= num22 / 12 * 12)
					{
						break;
					}
					int fdibyteOrder9 = (int)this.FDIByteOrder;
					ushort num24 = *(ushort*)ptr4;
					ushort num26;
					if (fdibyteOrder9 == 1)
					{
						ushort num25 = num24;
						num26 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,unsigned\u0020short>(num25, num25);
					}
					else
					{
						num26 = num24;
					}
					int logical_block2 = (int)num26;
					int fdibyteOrder10 = (int)this.FDIByteOrder;
					ushort num27 = *(ushort*)(ptr4 + 2 / sizeof(global::FDISystem.FDIGroupSequenceTable<FDISystem::FDI_TYPE_V5>));
					ushort obj_instance2;
					if (fdibyteOrder10 == 1)
					{
						ushort num28 = num27;
						obj_instance2 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,unsigned\u0020short>(num28, num28);
					}
					else
					{
						obj_instance2 = num27;
					}
					int sector_start2 = this.FindLogicalBlock(logical_block2);
					int num29;
					fdierrorCodes = this.FindFragmentInstance(sector_start2, uid, iType, (int)obj_instance2, num11, &num29);
					if (fdierrorCodes != global::FDISystem.FDIErrorCodes.None)
					{
						break;
					}
					int num30 = this.m_pData + num29;
					global::FDISystem.ByteOrder fdibyteOrder11 = this.FDIByteOrder;
					ushort num31 = *(num30 + 4);
					ushort num33;
					if (fdibyteOrder11 == global::FDISystem.ByteOrder.BigEndian)
					{
						ushort num32 = num31;
						num33 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,unsigned\u0020short>(num32, num32);
					}
					else
					{
						num33 = num31;
					}
					int num34 = (int)num33;
					int num35 = (int)(this.m_unitGranularity * (uint)num34);
					if (num35 + num <= iSize)
					{
						fdierrorCodes = this.FetchSingleInstance(num29, num35, file_data);
						if (fdierrorCodes != global::FDISystem.FDIErrorCodes.None)
						{
							break;
						}
						num35 = (int)(this.m_unitGranularity * (uint)num34);
						file_data = num35 + file_data;
						num = num35 + num;
					}
					else
					{
						int num36 = iSize - num;
						fdierrorCodes = this.FetchSingleInstance(num29, num36, file_data);
						if (fdierrorCodes != global::FDISystem.FDIErrorCodes.None)
						{
							break;
						}
						file_data = num36 + file_data;
					}
					num18 += 12;
					num23 += 12;
					ptr4 = (global::FDISystem.FDIGroupSequenceTable<FDISystem::FDI_TYPE_V5>*)(this.m_pData + num18);
				}
				num5 += 12;
				num10 += 12;
				ptr2 = (global::FDISystem.FDIGroupSequenceTable<FDISystem::FDI_TYPE_V5>*)(this.m_pData + num5);
				num11++;
			}
			return fdierrorCodes;
		}

		// Token: 0x0600023C RID: 572 RVA: 0x000086E8 File Offset: 0x00007AE8
		private unsafe global::FDISystem.FDIErrorCodes FindFragmentInstance(int sector_start, int uid, int iType, int obj_instance, int table_number, int* object_loc)
		{
			int num = sector_start;
			int num2 = 0;
			*object_loc = -1;
			if (sector_start >= 0 && sector_start <= (int)this.m_dataLength)
			{
				global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V5>* ptr = (global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V5>*)(this.m_pData + sector_start);
				for (;;)
				{
					int fdibyteOrder = (int)this.FDIByteOrder;
					ushort num3 = *(ushort*)(ptr + 10 / sizeof(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V5>));
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
					if (num5 == 65535)
					{
						break;
					}
					if (num2 == obj_instance)
					{
						goto IL_14C;
					}
					if (num >= (int)(this.m_blockSize + (uint)sector_start - 16U))
					{
						break;
					}
					int fdibyteOrder2 = (int)this.FDIByteOrder;
					byte b = (byte)((uint)(*(byte*)(ptr + 8 / sizeof(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V5>))) >> 4);
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
					if ((int)b3 == iType)
					{
						int fdibyteOrder3 = (int)this.FDIByteOrder;
						byte b4 = *(byte*)(ptr + 8 / sizeof(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V5>)) & 15;
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
						if (b6 == 2)
						{
							int fdibyteOrder4 = (int)this.FDIByteOrder;
							ushort num6 = *(ushort*)(ptr + 10 / sizeof(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V5>));
							ushort num8;
							if (fdibyteOrder4 == 1)
							{
								ushort num7 = num6;
								num8 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,unsigned\u0020short>(num7, num7);
							}
							else
							{
								num8 = num6;
							}
							if (num8 == 65280)
							{
								int fdibyteOrder5 = (int)this.FDIByteOrder;
								ushort num9 = *(ushort*)ptr;
								ushort num11;
								if (fdibyteOrder5 == 1)
								{
									ushort num10 = num9;
									num11 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,unsigned\u0020short>(num10, num10);
								}
								else
								{
									num11 = num9;
								}
								if ((int)num11 == uid)
								{
									int fdibyteOrder6 = (int)this.FDIByteOrder;
									ushort num12 = *(ushort*)(ptr + 2 / sizeof(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V5>));
									ushort num14;
									if (fdibyteOrder6 == 1)
									{
										ushort num13 = num12;
										num14 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,unsigned\u0020short>(num13, num13);
									}
									else
									{
										num14 = num12;
									}
									if ((int)num14 == table_number)
									{
										*object_loc = num;
										num2++;
									}
								}
							}
						}
					}
					num += 12;
					ptr = (global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V5>*)(this.m_pData + num);
				}
				if (num2 != obj_instance)
				{
					goto IL_156;
				}
				IL_14C:
				if (*object_loc != -1)
				{
					return global::FDISystem.FDIErrorCodes.None;
				}
				IL_156:
				return global::FDISystem.FDIErrorCodes.Failure;
			}
			return global::FDISystem.FDIErrorCodes.Failure;
		}

		// Token: 0x0600023D RID: 573 RVA: 0x00008850 File Offset: 0x00007C50
		private unsafe global::FDISystem.FDIErrorCodes FindTableInstance(int sector_start, int uid, int iType, int obj_instance, int entry_attr, int* object_loc)
		{
			int num = (int)(~(this.m_blockSize - 1U) & (uint)sector_start);
			int num2 = 0;
			*object_loc = -1;
			if (num >= 0 && num <= (int)this.m_dataLength)
			{
				global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V5>* ptr = (global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V5>*)(this.m_pData + num);
				for (;;)
				{
					int fdibyteOrder = (int)this.FDIByteOrder;
					ushort num3 = *(ushort*)(ptr + 10 / sizeof(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V5>));
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
					if (num5 == 65535)
					{
						break;
					}
					if (num2 == obj_instance)
					{
						goto IL_12F;
					}
					if (num >= (int)(this.m_blockSize + (uint)sector_start - 16U))
					{
						break;
					}
					int fdibyteOrder2 = (int)this.FDIByteOrder;
					byte b = (byte)((uint)(*(byte*)(ptr + 8 / sizeof(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V5>))) >> 4);
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
					if ((int)b3 == iType)
					{
						int fdibyteOrder3 = (int)this.FDIByteOrder;
						byte b4 = *(byte*)(ptr + 8 / sizeof(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V5>)) & 15;
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
						if ((int)b6 == entry_attr)
						{
							int fdibyteOrder4 = (int)this.FDIByteOrder;
							ushort num6 = *(ushort*)(ptr + 10 / sizeof(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V5>));
							ushort num8;
							if (fdibyteOrder4 == 1)
							{
								ushort num7 = num6;
								num8 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,unsigned\u0020short>(num7, num7);
							}
							else
							{
								num8 = num6;
							}
							if (num8 == 65280)
							{
								int fdibyteOrder5 = (int)this.FDIByteOrder;
								ushort num9 = *(ushort*)ptr;
								ushort num11;
								if (fdibyteOrder5 == 1)
								{
									ushort num10 = num9;
									num11 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,unsigned\u0020short>(num10, num10);
								}
								else
								{
									num11 = num9;
								}
								if ((int)num11 == uid)
								{
									*object_loc = num;
									num2++;
								}
							}
						}
					}
					num += 12;
					ptr = (global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V5>*)(this.m_pData + num);
				}
				if (num2 != obj_instance)
				{
					goto IL_139;
				}
				IL_12F:
				if (*object_loc != -1)
				{
					return global::FDISystem.FDIErrorCodes.None;
				}
				IL_139:
				return global::FDISystem.FDIErrorCodes.Failure;
			}
			return global::FDISystem.FDIErrorCodes.Failure;
		}

		// Token: 0x0600023E RID: 574 RVA: 0x00002380 File Offset: 0x00001780
		private uint GetMaxEntriesInGroupTable()
		{
			return (this.m_blockSize - 40U) / 12U;
		}

		// Token: 0x0600023F RID: 575 RVA: 0x00002250 File Offset: 0x00001650
		private int GetMaxSizeOfMultiInstance()
		{
			return (int)((this.m_unitGranularity - 7U) / 3U);
		}

		// Token: 0x06000240 RID: 576 RVA: 0x0000259C File Offset: 0x0000199C
		private unsafe int MultiInstanceIsInvalid(int data_loc, int instance)
		{
			return ((instance + (this.m_pData + data_loc))[4] == 192) ? 1 : 0;
		}

		// Token: 0x06000241 RID: 577 RVA: 0x000025C0 File Offset: 0x000019C0
		private unsafe int MultiInstanceIsValid(int data_loc, int instance)
		{
			return ((instance + (this.m_pData + data_loc))[4] == 240) ? 1 : 0;
		}

		// Token: 0x06000242 RID: 578 RVA: 0x00008B20 File Offset: 0x00007F20
		private unsafe int GetMultiInstLoc(int loc, int instance)
		{
			return global::<Module>.FDISystem.FDI_TYPE_V5.GetMultiInstLoc((byte*)this.m_pData, loc, instance, this.FDIByteOrder);
		}

		// Token: 0x06000243 RID: 579 RVA: 0x000025E4 File Offset: 0x000019E4
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
		private unsafe bool MultiInstanceIsAllocating(int data_loc, int instance)
		{
			return ((((uint)(data_loc + (this.m_pData + instance / 2))[4] >> (int)((byte)(4 - (instance % 2 << 2))) & 15U) == 7U) ? 1 : 0) != 0;
		}

		// Token: 0x06000244 RID: 580 RVA: 0x00002610 File Offset: 0x00001A10
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
		private unsafe bool MultiInstanceIsEmpty(int data_loc, int instance)
		{
			return (((instance + (this.m_pData + data_loc))[4] == byte.MaxValue) ? 1 : 0) != 0;
		}

		// Token: 0x06000245 RID: 581 RVA: 0x00003114 File Offset: 0x00002514
		private int GetMaxEntriesInSequenceTable()
		{
			return (int)(this.m_unitGranularity / 12U);
		}

		// Token: 0x06000246 RID: 582 RVA: 0x000028D8 File Offset: 0x00001CD8
		[global::System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		protected void Dispose([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)] bool A_0)
		{
			if (A_0)
			{
				this.~FDICore<FDISystem::FDI_TYPE_V5>();
			}
			else
			{
				try
				{
					this.!FDICore<FDISystem::FDI_TYPE_V5>();
				}
				finally
				{
					base.Finalize();
				}
			}
		}

		// Token: 0x06000247 RID: 583 RVA: 0x00003274 File Offset: 0x00002674
		public sealed void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x06000248 RID: 584 RVA: 0x0000291C File Offset: 0x00001D1C
		protected sealed override void Finalize()
		{
			this.Dispose(false);
		}

		// Token: 0x04000049 RID: 73
		private ushort m_maxBlocksNum;

		// Token: 0x0400004A RID: 74
		private uint m_blockSize;

		// Token: 0x0400004B RID: 75
		private uint m_numOfBlocks;

		// Token: 0x0400004C RID: 76
		private unsafe byte* m_pData;

		// Token: 0x0400004D RID: 77
		private uint m_dataLength;

		// Token: 0x0400004E RID: 78
		private bool m_bIsValidated;

		// Token: 0x0400004F RID: 79
		private uint m_unitGranularity;

		// Token: 0x04000050 RID: 80
		private global::FDISystem.ByteOrder m_byteOrder;
	}
}
