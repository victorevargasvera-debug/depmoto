using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using Motorola.Common.Communication.TetraUtility;
using std;

namespace FDISystem
{
	// Token: 0x02000009 RID: 9
	internal sealed class CodeplugFDIPack<FDISystem::CP_FORMAT_TYPE_V5> : global::FDISystem.ICodeplugFDIPack
	{
		// Token: 0x06000249 RID: 585 RVA: 0x00001908 File Offset: 0x00000D08
		public CodeplugFDIPack<FDISystem::CP_FORMAT_TYPE_V5>(global::FDISystem.FDICore<FDISystem::FDI_TYPE_V5> fdiSystem)
		{
			this.fdi = fdiSystem;
		}

		// Token: 0x0600024A RID: 586 RVA: 0x00001924 File Offset: 0x00000D24
		private void !CodeplugFDIPack<FDISystem::CP_FORMAT_TYPE_V5>()
		{
			this.fdi = null;
		}

		// Token: 0x0600024B RID: 587 RVA: 0x00001938 File Offset: 0x00000D38
		private void ~CodeplugFDIPack<FDISystem::CP_FORMAT_TYPE_V5>()
		{
			this.fdi = null;
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600024C RID: 588 RVA: 0x00001820 File Offset: 0x00000C20
		public global::FDISystem.IFDI FDI
		{
			get
			{
				return this.fdi;
			}
		}

		// Token: 0x0600024D RID: 589 RVA: 0x0000C274 File Offset: 0x0000B674
		public unsafe global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<ushort, byte[]>> GetCodeplugBlockDataSet()
		{
			global::std.vector<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T,std::allocator<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T>\u0020> vector<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T,std::allocator<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T>_u0020> = 0;
			*(ref vector<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T,std::allocator<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T>_u0020> + 4) = 0;
			*(ref vector<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T,std::allocator<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T>_u0020> + 8) = 0;
			byte b = 0;
			global::std.vector<int,std::allocator<int>\u0020> vector<int,std::allocator<int>_u0020>;
			byte b2;
			try
			{
				vector<int,std::allocator<int>_u0020> = 0;
				*(ref vector<int,std::allocator<int>_u0020> + 4) = 0;
				*(ref vector<int,std::allocator<int>_u0020> + 8) = 0;
				b2 = 0;
				try
				{
					global::System.Collections.Generic.List<global::System.IntPtr> list = new global::System.Collections.Generic.List<global::System.IntPtr>();
					try
					{
						global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<ushort, byte[]>> result;
						global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<ushort, byte[]>> result2;
						try
						{
							byte[] codeplugMapBuffer = this.fdi.FetchElementData(0, 0);
							bool flag = this.ParseCodeplugImage(codeplugMapBuffer, ref vector<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T,std::allocator<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T>_u0020>, ref vector<int,std::allocator<int>_u0020>);
							if (flag)
							{
								this.ExtractCodeplugUnits(ref vector<int,std::allocator<int>_u0020>, list);
								result = this.BuildCodeplugBlockData(list, ref vector<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T,std::allocator<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T>_u0020>, ref vector<int,std::allocator<int>_u0020>);
								goto IL_C2;
							}
							result2 = new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<ushort, byte[]>>();
						}
						catch (global::FDISystem.FDIException ex)
						{
							throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::FDISystem.FDIException.GetCustomErrorCode(ex.ErrorCode), ex.Message, ex);
						}
						catch (global::System.Exception ex2)
						{
							throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::FDISystem.FDIException.DotFXExceptionCode, ex2.Message, ex2);
						}
						global::<Module>.std.vector<int,std::allocator<int>\u0020>._Tidy(ref vector<int,std::allocator<int>_u0020>);
						b = 1;
						global::<Module>.std.vector<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T,std::allocator<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T>\u0020>._Tidy(ref vector<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T,std::allocator<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T>_u0020>);
						return result2;
						IL_C2:
						global::<Module>.std.vector<int,std::allocator<int>\u0020>._Tidy(ref vector<int,std::allocator<int>_u0020>);
						b = 1;
						global::<Module>.std.vector<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T,std::allocator<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T>\u0020>._Tidy(ref vector<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T,std::allocator<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T>_u0020>);
						return result;
					}
					finally
					{
						int num = 0;
						if (0 < list.Count)
						{
							do
							{
								global::<Module>.delete[](list[num].ToPointer());
								num++;
							}
							while (num < list.Count);
						}
					}
				}
				catch
				{
					if (b2 == 0)
					{
						global::<Module>.___CxxCallUnwindDtor(ldftn(std.vector<int,std::allocator<int>\u0020>.{dtor}), (void*)(&vector<int,std::allocator<int>_u0020>));
					}
					throw;
				}
			}
			catch
			{
				if (b == 0)
				{
					global::<Module>.___CxxCallUnwindDtor(ldftn(std.vector<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T,std::allocator<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T>\u0020>.{dtor}), (void*)(&vector<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T,std::allocator<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T>_u0020>));
				}
				throw;
			}
			try
			{
				try
				{
				}
				catch
				{
					if (b2 == 0)
					{
						global::<Module>.___CxxCallUnwindDtor(ldftn(std.vector<int,std::allocator<int>\u0020>.{dtor}), (void*)(&vector<int,std::allocator<int>_u0020>));
					}
					throw;
				}
			}
			catch
			{
				if (b == 0)
				{
					global::<Module>.___CxxCallUnwindDtor(ldftn(std.vector<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T,std::allocator<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T>\u0020>.{dtor}), (void*)(&vector<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T,std::allocator<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T>_u0020>));
				}
				throw;
			}
			global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<ushort, byte[]>> result3;
			return result3;
		}

		// Token: 0x0600024E RID: 590 RVA: 0x0000C4A0 File Offset: 0x0000B8A0
		public void WriteCodeplug(global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<ushort, byte[]>> cpBlocks, uint codeplugSize)
		{
			try
			{
				if (cpBlocks == null)
				{
					throw new global::System.ArgumentNullException("cpBlocks");
				}
				global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<ushort, global::System.Collections.Generic.List<byte[]>>> codeplugUnitList = global::FDISystem.CodeplugFDIPack<FDISystem::CP_FORMAT_TYPE_V5>.BreakdownCodeplugBlock(cpBlocks.ToArray());
				codeplugUnitList = global::FDISystem.CodeplugFDIPack<FDISystem::CP_FORMAT_TYPE_V5>.ArrangeCodeplugUnitList(codeplugUnitList);
				global::System.Collections.Generic.List<byte[]> codeplugUnites = this.FlatCodeplugUnitList(codeplugUnitList);
				int[] array = this.DistributeUnites(codeplugUnites, codeplugSize);
				byte[] codeplugMapInfoData = this.GenerateCodeplugMapUnit(codeplugUnites, array, cpBlocks.Count);
				this.WriteToFDI(codeplugMapInfoData, codeplugUnites, array);
			}
			catch (global::FDISystem.FDIException ex)
			{
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::FDISystem.FDIException.GetCustomErrorCode(ex.ErrorCode), ex.Message, ex);
			}
			catch (global::System.Exception ex2)
			{
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::FDISystem.FDIException.DotFXExceptionCode, ex2.Message, ex2);
			}
		}

		// Token: 0x0600024F RID: 591 RVA: 0x0000BE88 File Offset: 0x0000B288
		private byte[] GetCodeplugMapUnit()
		{
			return this.fdi.FetchElementData(0, 0);
		}

		// Token: 0x06000250 RID: 592 RVA: 0x000090E0 File Offset: 0x000084E0
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
		private unsafe bool ParseCodeplugImage(byte[] codeplugMapBuffer, global::std.vector<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T,std::allocator<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T>\u0020>* cpBlockMaps, global::std.vector<int,std::allocator<int>\u0020>* cpUnitSizes)
		{
			if (codeplugMapBuffer == null)
			{
				throw new global::System.ArgumentNullException("codeplugMapBuffer");
			}
			global::<Module>.std.vector<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T,std::allocator<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T>\u0020>.clear(cpBlockMaps);
			global::<Module>.std.vector<int,std::allocator<int>\u0020>.clear(cpUnitSizes);
			int num = codeplugMapBuffer.Length - 1;
			int i = num;
			int num2 = 0;
			int num3 = num;
			if (0 < num3)
			{
				for (;;)
				{
					num2++;
					if (codeplugMapBuffer[num2] == 82 && codeplugMapBuffer[num2 + 1] == 84)
					{
						break;
					}
					if (num2 >= num3)
					{
						return false;
					}
				}
				if (codeplugMapBuffer[i] == 255)
				{
					while (i > num2)
					{
						i--;
						if (codeplugMapBuffer[i] != 255)
						{
							break;
						}
					}
				}
				ref byte byte& = ref codeplugMapBuffer[0];
				byte* ptr = ref byte&;
				int fdibyteOrder = (int)((global::FDISystem.IFDI)this.fdi).FDIByteOrder;
				ushort num4 = *(ushort*)(ptr + num2 + 6);
				ushort num6;
				if (fdibyteOrder == 1)
				{
					ushort num5 = num4;
					global::<Module>.std.reverse<unsigned\u0020char\u0020*>((byte*)(&num5), ref num5 + 2);
					num6 = num5;
				}
				else
				{
					num6 = num4;
				}
				if (num6 != 1)
				{
					int fdibyteOrder2 = (int)((global::FDISystem.IFDI)this.fdi).FDIByteOrder;
					ushort num7 = *(ushort*)(ptr + num2 + 6);
					ushort num9;
					if (fdibyteOrder2 == 1)
					{
						ushort num8 = num7;
						global::<Module>.std.reverse<unsigned\u0020char\u0020*>((byte*)(&num8), ref num8 + 2);
						num9 = num8;
					}
					else
					{
						num9 = num7;
					}
					num2 = (int)(12 - num9 * 12) + num2;
					if (num2 < 0)
					{
						return false;
					}
				}
				uint num10 = (uint)((i - num2 + 1) / 12);
				byte* ptr2 = ref byte& + num2;
				if ((*(cpBlockMaps + 8) - *cpBlockMaps) / 12 < (int)num10)
				{
					if (357913941U < num10)
					{
						global::<Module>.std._Xlength_error((sbyte*)(&global::<Module>.??_C@_0BD@OLBABOEK@vector?$DMT?$DO?5too?5long?$AA@));
					}
					global::<Module>.std.vector<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T,std::allocator<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T>\u0020>._Reallocate(cpBlockMaps, num10);
				}
				if (0U < num10)
				{
					int num11 = 0;
					uint num12 = num10;
					do
					{
						global::<Module>.std.vector<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T,std::allocator<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T>\u0020>.push_back(cpBlockMaps, num11 + ptr2);
						num11 += 12;
						num12 -= 1U;
					}
					while (num12 > 0U);
				}
				uint num13 = 0U;
				if (0U < num10)
				{
					int num14 = 0;
					uint num15 = num10;
					do
					{
						global::FDISystem.IFDI ifdi = this.fdi;
						int num16 = num14 + *cpBlockMaps;
						global::FDISystem.ByteOrder fdibyteOrder3 = ifdi.FDIByteOrder;
						ushort num17 = *(num16 + 4);
						ushort num19;
						if (fdibyteOrder3 == global::FDISystem.ByteOrder.BigEndian)
						{
							ushort num18 = num17;
							global::<Module>.std.reverse<unsigned\u0020char\u0020*>((byte*)(&num18), ref num18 + 2);
							num19 = num18;
						}
						else
						{
							num19 = num17;
						}
						num13 = (uint)num19 + num13;
						num14 += 12;
						num15 -= 1U;
					}
					while (num15 > 0U);
				}
				num13 += 1U;
				byte condition = (num2 - 2 == (int)(num13 * 2U)) ? 1 : 0;
				global::System.Diagnostics.Debug.Assert(condition != 0);
				if (num2 - 2 == (int)(num13 * 2U))
				{
					if (*(cpUnitSizes + 8) - *cpUnitSizes >> 2 < (int)num13)
					{
						if (1073741823U < num13)
						{
							global::<Module>.std._Xlength_error((sbyte*)(&global::<Module>.??_C@_0BD@OLBABOEK@vector?$DMT?$DO?5too?5long?$AA@));
						}
						global::<Module>.std.vector<int,std::allocator<int>\u0020>._Reallocate(cpUnitSizes, num13);
					}
					ushort* ptr3 = ref byte&;
					uint num20 = 0U;
					if (0U < num13)
					{
						do
						{
							int fdibyteOrder4 = (int)this.fdi.FDIByteOrder;
							ushort num21 = num20[ptr3];
							ushort num23;
							if (fdibyteOrder4 == 1)
							{
								ushort num22 = num21;
								global::<Module>.std.reverse<unsigned\u0020char\u0020*>((byte*)(&num22), ref num22 + 2);
								num23 = num22;
							}
							else
							{
								num23 = num21;
							}
							int num24 = (int)num23;
							global::<Module>.std.vector<int,std::allocator<int>\u0020>.push_back(cpUnitSizes, ref num24);
							num20 += 1U;
						}
						while (num20 < num13);
					}
					return true;
				}
				return false;
			}
			return false;
		}

		// Token: 0x06000251 RID: 593 RVA: 0x0000BEA4 File Offset: 0x0000B2A4
		private unsafe void ExtractCodeplugUnits(global::std.vector<int,std::allocator<int>\u0020>* cpUnitSizes, global::System.Collections.Generic.List<global::System.IntPtr> codeplugUnitDatas)
		{
			int num = 0;
			if (0 < codeplugUnitDatas.Count)
			{
				do
				{
					global::<Module>.delete[](codeplugUnitDatas[num].ToPointer());
					num++;
				}
				while (num < codeplugUnitDatas.Count);
			}
			codeplugUnitDatas.Clear();
			if (*(cpUnitSizes + 4) - *cpUnitSizes >> 2 <= 1)
			{
				throw new global::FDISystem.FDIException(global::FDISystem.FDIErrorCodes.CodeplugFailure);
			}
			global::System.Diagnostics.Debug.Assert(true);
			uint num2 = 1U;
			if (1 < *(cpUnitSizes + 4) - *cpUnitSizes >> 2)
			{
				do
				{
					byte[] array = this.fdi.FetchElementData((int)num2, 0);
					byte* ptr = global::<Module>.new[]((uint)array.Length);
					if (ptr == null)
					{
						goto IL_D4;
					}
					ref byte byte& = ref array[0];
					try
					{
						cpblk(ptr, ref byte&, array.Length);
						global::System.IntPtr item = new global::System.IntPtr((void*)ptr);
						codeplugUnitDatas.Add(item);
						global::FDISystem.IFDI ifdi = this.fdi;
						if (!global::<Module>.FDISystem.CPFixedUnitHeader<FDISystem::CP_FORMAT_TYPE_V5>.IsFixUnitHeaderValid(ptr, ifdi.FDIByteOrder))
						{
							global::System.Diagnostics.Debug.Assert(false);
						}
					}
					catch
					{
						throw;
					}
					num2 += 1U;
				}
				while (num2 < (uint)(*(cpUnitSizes + 4) - *cpUnitSizes >> 2));
				return;
				IL_D4:
				throw new global::FDISystem.FDIException(global::FDISystem.FDIErrorCodes.OutOfRam);
			}
		}

		// Token: 0x06000252 RID: 594 RVA: 0x00007004 File Offset: 0x00006404
		private unsafe global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<ushort, byte[]>> BuildCodeplugBlockData(global::System.Collections.Generic.List<global::System.IntPtr> codeplugUnitDatas, global::std.vector<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T,std::allocator<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T>\u0020>* cpBlockMaps, global::std.vector<int,std::allocator<int>\u0020>* cpUnitSizes)
		{
			global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<ushort, byte[]>> list = new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<ushort, byte[]>>();
			uint num = 0U;
			int num2 = *cpBlockMaps;
			if (0 < (*(cpBlockMaps + 4) - num2) / 12)
			{
				int num3 = 0;
				do
				{
					global::FDISystem.IFDI ifdi = this.fdi;
					int num4 = num3 + num2;
					global::FDISystem.ByteOrder fdibyteOrder = ifdi.FDIByteOrder;
					ushort num5 = *(num4 + 6);
					ushort num7;
					if (fdibyteOrder == global::FDISystem.ByteOrder.BigEndian)
					{
						ushort num6 = num5;
						num7 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,unsigned\u0020short>(num6, num6);
					}
					else
					{
						num7 = num5;
					}
					uint num8 = (uint)num7;
					global::FDISystem.IFDI ifdi2 = this.fdi;
					int num9 = num3 + *cpBlockMaps;
					global::FDISystem.ByteOrder fdibyteOrder2 = ifdi2.FDIByteOrder;
					ushort num10 = *(num9 + 4);
					ushort num12;
					if (fdibyteOrder2 == global::FDISystem.ByteOrder.BigEndian)
					{
						ushort num11 = num10;
						num12 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,unsigned\u0020short>(num11, num11);
					}
					else
					{
						num12 = num10;
					}
					uint num13 = (uint)num12;
					uint num14 = 0U;
					uint num15 = num8 + num13;
					if (num8 < num15)
					{
						int num16 = (int)(num8 * 4U + (uint)(*cpUnitSizes));
						uint num17 = num15 - num8;
						do
						{
							num14 = (uint)(*num16 + (int)num14);
							num16 += 4;
							num17 -= 1U;
						}
						while (num17 > 0U);
					}
					byte[] array = new byte[num14];
					ref byte byte& = ref array[0];
					try
					{
						byte* ptr = ref byte&;
						uint num18 = num8;
						if (num8 < num15)
						{
							do
							{
								global::System.IntPtr intPtr = codeplugUnitDatas[(int)(num18 - 1U)];
								int* ptr2 = num18 * 4U + (uint)(*cpUnitSizes);
								cpblk(ptr, (byte*)intPtr.ToPointer() + 12, *ptr2);
								ptr = *(num18 * 4U + (uint)(*cpUnitSizes)) + ptr;
								num18 += 1U;
							}
							while (num18 < num15);
						}
						global::System.Collections.Generic.KeyValuePair<ushort, byte[]> item = new global::System.Collections.Generic.KeyValuePair<ushort, byte[]>(*(num3 + *cpBlockMaps), array);
						list.Add(item);
					}
					catch
					{
						throw;
					}
					num += 1U;
					num3 += 12;
					num2 = *cpBlockMaps;
				}
				while (num < (uint)((*(cpBlockMaps + 4) - num2) / 12));
			}
			return list;
		}

		// Token: 0x06000253 RID: 595 RVA: 0x00005590 File Offset: 0x00004990
		private unsafe global::System.Collections.Generic.List<byte[]> FlatCodeplugUnitList(global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<ushort, global::System.Collections.Generic.List<byte[]>>> codeplugUnitList)
		{
			if (codeplugUnitList == null)
			{
				throw new global::System.ArgumentNullException("codeplugUnitList");
			}
			global::System.Collections.Generic.List<byte[]> list = new global::System.Collections.Generic.List<byte[]>();
			global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<ushort, global::System.Collections.Generic.List<byte[]>>>.Enumerator enumerator = codeplugUnitList.GetEnumerator();
			if (enumerator.MoveNext())
			{
				do
				{
					global::System.Collections.Generic.KeyValuePair<ushort, global::System.Collections.Generic.List<byte[]>> keyValuePair = enumerator.Current;
					ushort key = keyValuePair.Key;
					int num = 1;
					global::System.Collections.Generic.List<byte[]>.Enumerator enumerator2 = keyValuePair.Value.GetEnumerator();
					if (enumerator2.MoveNext())
					{
						do
						{
							byte[] array = enumerator2.Current;
							ref byte byte& = ref array[0];
							try
							{
								global::FDISystem.CPFixedUnitHeader<FDISystem::CP_FORMAT_TYPE_V5>* ptr = ref byte&;
								global::FDISystem.ByteOrder fdibyteOrder = ((global::FDISystem.IFDI)this.fdi).FDIByteOrder;
								*(short*)ptr = (short)key;
								int fdibyteOrder2 = (int)((global::FDISystem.IFDI)this.fdi).FDIByteOrder;
								uint count = (uint)keyValuePair.Value.Count;
								ushort destVar = *(ushort*)(ptr + 4 / sizeof(global::FDISystem.CPFixedUnitHeader<FDISystem::CP_FORMAT_TYPE_V5>));
								ushort num2;
								if (fdibyteOrder2 == 1)
								{
									num2 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,unsigned\u0020int>(destVar, count);
								}
								else
								{
									num2 = (ushort)count;
								}
								*(short*)(ptr + 4 / sizeof(global::FDISystem.CPFixedUnitHeader<FDISystem::CP_FORMAT_TYPE_V5>)) = (short)num2;
								ushort num4;
								if (((global::FDISystem.IFDI)this.fdi).FDIByteOrder == global::FDISystem.ByteOrder.BigEndian)
								{
									ushort num3 = (ushort)num;
									global::<Module>.std.reverse<unsigned\u0020char\u0020*>((byte*)(&num3), ref num3 + 2);
									num4 = num3;
								}
								else
								{
									num4 = (ushort)num;
								}
								*(short*)(ptr + 6 / sizeof(global::FDISystem.CPFixedUnitHeader<FDISystem::CP_FORMAT_TYPE_V5>)) = (short)num4;
								int fdibyteOrder3 = (int)((global::FDISystem.IFDI)this.fdi).FDIByteOrder;
								uint num5 = (uint)(array.Length - 12);
								ushort num7;
								if (fdibyteOrder3 == 1)
								{
									ushort num6 = (ushort)num5;
									global::<Module>.std.reverse<unsigned\u0020char\u0020*>((byte*)(&num6), ref num6 + 2);
									num7 = num6;
								}
								else
								{
									num7 = (ushort)num5;
								}
								*(short*)(ptr + 2 / sizeof(global::FDISystem.CPFixedUnitHeader<FDISystem::CP_FORMAT_TYPE_V5>)) = (short)num7;
								ushort num8 = global::FDISystem.CodeplugFDIPack<FDISystem::CP_FORMAT_TYPE_V5>.CalcUnitDataCheckSum(ref byte& + 12, (uint)(array.Length - 12));
								int fdibyteOrder4 = (int)((global::FDISystem.IFDI)this.fdi).FDIByteOrder;
								uint num9 = (uint)num8;
								ushort destVar2 = *(ushort*)(ptr + 8 / sizeof(global::FDISystem.CPFixedUnitHeader<FDISystem::CP_FORMAT_TYPE_V5>));
								ushort num10;
								if (fdibyteOrder4 == 1)
								{
									num10 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,unsigned\u0020int>(destVar2, num9);
								}
								else
								{
									num10 = (ushort)num9;
								}
								*(short*)(ptr + 8 / sizeof(global::FDISystem.CPFixedUnitHeader<FDISystem::CP_FORMAT_TYPE_V5>)) = (short)num10;
								num++;
								list.Add(array);
							}
							catch
							{
								throw;
							}
						}
						while (enumerator2.MoveNext());
					}
				}
				while (enumerator.MoveNext());
			}
			return list;
		}

		// Token: 0x06000254 RID: 596 RVA: 0x00002CC0 File Offset: 0x000020C0
		private int[] DistributeUnites(global::System.Collections.Generic.List<byte[]> codeplugUnites, uint codeplugSize)
		{
			uint num = codeplugSize / (this.fdi.MaxBlocks - 1U);
			byte condition = (num < this.fdi.BlockSize) ? 1 : 0;
			global::System.Diagnostics.Debug.Assert(condition != 0);
			if (num >= this.fdi.BlockSize)
			{
				throw new global::FDISystem.FDIException(global::FDISystem.FDIErrorCodes.CodeplugExceedBlockSize);
			}
			int[] array = new int[this.fdi.MaxBlocks];
			int i = 0;
			uint num2 = 0U;
			if (0U < this.fdi.MaxBlocks - 1U)
			{
				while (i < codeplugUnites.Count)
				{
					array[(int)num2] = 0;
					uint num3 = 0U;
					while (i < codeplugUnites.Count)
					{
						array[(int)num2] = array[(int)num2] + 1;
						byte condition2 = (codeplugUnites[i].Length - 12 != 0) ? 1 : 0;
						global::System.Diagnostics.Debug.Assert(condition2 != 0);
						num3 = (uint)(codeplugUnites[i].Length + (int)num3 - 12);
						i++;
						if (num3 > num)
						{
							break;
						}
					}
					num2 += 1U;
					if (num2 >= this.fdi.MaxBlocks - 1U)
					{
						break;
					}
				}
			}
			int num4 = (int)(num2 - 1U);
			if (i < codeplugUnites.Count - 1)
			{
				do
				{
					array[num4]++;
				}
				while (i < codeplugUnites.Count - 1);
			}
			if (num2 > 0U && array[(int)(num2 - 1U)] == 0)
			{
				int num5 = (int)(this.fdi.MaxBlocks - 2U);
				if (num5 >= 0)
				{
					while (array[num5] == 0)
					{
						int num6 = num5 - 1;
						int num7 = num6;
						if (num5 >= 1)
						{
							while (array[num7] <= 0)
							{
								num7--;
								if (num7 < 0)
								{
									goto IL_144;
								}
							}
							array[num5] = 1;
							array[num7]--;
						}
						IL_144:
						num5 = num6;
						if (num5 < 0)
						{
							break;
						}
					}
				}
			}
			return array;
		}

		// Token: 0x06000255 RID: 597 RVA: 0x0000415C File Offset: 0x0000355C
		private unsafe byte[] GenerateCodeplugMapUnit(global::System.Collections.Generic.List<byte[]> codeplugUnites, int[] unitDistributionInfo, int nCPBlocks)
		{
			int count = codeplugUnites.Count;
			uint num = 0U;
			int num2 = 0;
			int num3 = unitDistributionInfo.Length;
			if (0 < num3)
			{
				do
				{
					num = (uint)(unitDistributionInfo[num2] + (int)num);
					num2++;
				}
				while (num2 < num3);
			}
			byte condition = (count == (int)num) ? 1 : 0;
			global::System.Diagnostics.Debug.Assert(condition != 0);
			int num4 = (nCPBlocks * 6 + count) * 2 + 16;
			global::std.auto_ptr<unsigned\u0020char> auto_ptr<unsigned_u0020char> = global::<Module>.new[]((uint)num4);
			byte[] array2;
			try
			{
				byte condition2 = (auto_ptr<unsigned_u0020char> != 0) ? 1 : 0;
				global::System.Diagnostics.Debug.Assert(condition2 != 0);
				if (auto_ptr<unsigned_u0020char> == null)
				{
					throw new global::FDISystem.FDIException(global::FDISystem.FDIErrorCodes.OutOfRam);
				}
				initblk(auto_ptr<unsigned_u0020char>, 255, num4);
				ushort num6;
				if (this.fdi.FDIByteOrder == global::FDISystem.ByteOrder.BigEndian)
				{
					ushort num5 = (ushort)num4;
					global::<Module>.std.reverse<unsigned\u0020char\u0020*>((byte*)(&num5), ref num5 + 2);
					num6 = num5;
				}
				else
				{
					num6 = (ushort)num4;
				}
				*auto_ptr<unsigned_u0020char> = (short)num6;
				ushort* ptr = auto_ptr<unsigned_u0020char> + 2;
				global::System.Collections.Generic.List<byte[]>.Enumerator enumerator = codeplugUnites.GetEnumerator();
				if (enumerator.MoveNext())
				{
					do
					{
						byte[] array = enumerator.Current;
						global::FDISystem.ByteOrder fdibyteOrder = this.fdi.FDIByteOrder;
						uint num7 = (uint)(array.Length - 12);
						ushort num9;
						if (fdibyteOrder == global::FDISystem.ByteOrder.BigEndian)
						{
							ushort num8 = (ushort)num7;
							global::<Module>.std.reverse<unsigned\u0020char\u0020*>((byte*)(&num8), ref num8 + 2);
							num9 = num8;
						}
						else
						{
							num9 = (ushort)num7;
						}
						*ptr = num9;
						ptr++;
					}
					while (enumerator.MoveNext());
				}
				global::FDISystem.CPBlockMap<FDISystem::CP_FORMAT_TYPE_V5>* ptr2 = (global::FDISystem.CPBlockMap<FDISystem::CP_FORMAT_TYPE_V5>*)(ptr + 1);
				int num10 = 0;
				int num11 = 0;
				int num12 = 0;
				if (0 < codeplugUnites.Count)
				{
					global::FDISystem.CPBlockMap<FDISystem::CP_FORMAT_TYPE_V5>* ptr3 = ptr2 + 6 / sizeof(global::FDISystem.CPBlockMap<FDISystem::CP_FORMAT_TYPE_V5>);
					global::FDISystem.CPBlockMap<FDISystem::CP_FORMAT_TYPE_V5>* ptr4 = -6 - ptr2;
					do
					{
						int num13 = 0;
						byte b = codeplugUnites[num10][0];
						byte b2 = codeplugUnites[num10][1];
						global::FDISystem.ByteOrder fdibyteOrder2 = ((global::FDISystem.IFDI)this.fdi).FDIByteOrder;
						*(byte*)(ptr3 - 6 / sizeof(global::FDISystem.CPBlockMap<FDISystem::CP_FORMAT_TYPE_V5>)) = (byte)((sbyte)b);
						*(byte*)(ptr3 - 5 / sizeof(global::FDISystem.CPBlockMap<FDISystem::CP_FORMAT_TYPE_V5>)) = (byte)((sbyte)b2);
						int fdibyteOrder3 = (int)((global::FDISystem.IFDI)this.fdi).FDIByteOrder;
						int num14 = num10 + 1;
						ushort num16;
						if (fdibyteOrder3 == 1)
						{
							ushort num15 = (ushort)num14;
							global::<Module>.std.reverse<unsigned\u0020char\u0020*>((byte*)(&num15), ref num15 + 2);
							num16 = num15;
						}
						else
						{
							num16 = (ushort)num14;
						}
						*(short*)ptr3 = (short)num16;
						if (num10 < codeplugUnites.Count)
						{
							int num17 = num10;
							while (codeplugUnites[num17][0] == b && codeplugUnites[num17][1] == b2)
							{
								num13++;
								num17++;
								if (num17 >= codeplugUnites.Count)
								{
									break;
								}
							}
						}
						ushort num19;
						if (((global::FDISystem.IFDI)this.fdi).FDIByteOrder == global::FDISystem.ByteOrder.BigEndian)
						{
							ushort num18 = (ushort)num13;
							global::<Module>.std.reverse<unsigned\u0020char\u0020*>((byte*)(&num18), ref num18 + 2);
							num19 = num18;
						}
						else
						{
							num19 = (ushort)num13;
						}
						*(short*)(ptr3 - 2 / sizeof(global::FDISystem.CPBlockMap<FDISystem::CP_FORMAT_TYPE_V5>)) = (short)num19;
						num3 = unitDistributionInfo.Length;
						if (num11 < num3)
						{
							do
							{
								int num20 = num12 + unitDistributionInfo[num11];
								if (num10 < num20)
								{
									break;
								}
								num12 = num20;
								num11++;
							}
							while (num11 < num3);
						}
						int fdibyteOrder4 = (int)((global::FDISystem.IFDI)this.fdi).FDIByteOrder;
						int num21 = num11 + 1;
						ushort num23;
						if (fdibyteOrder4 == 1)
						{
							ushort num22 = (ushort)num21;
							global::<Module>.std.reverse<unsigned\u0020char\u0020*>((byte*)(&num22), ref num22 + 2);
							num23 = num22;
						}
						else
						{
							num23 = (ushort)num21;
						}
						*(short*)(ptr3 - 4 / sizeof(global::FDISystem.CPBlockMap<FDISystem::CP_FORMAT_TYPE_V5>)) = (short)num23;
						global::FDISystem.ByteOrder fdibyteOrder5 = ((global::FDISystem.IFDI)this.fdi).FDIByteOrder;
						initblk(ptr3 + 2 / sizeof(global::FDISystem.CPBlockMap<FDISystem::CP_FORMAT_TYPE_V5>), 0, 4);
						ptr3 += 12 / sizeof(global::FDISystem.CPBlockMap<FDISystem::CP_FORMAT_TYPE_V5>);
						byte condition3 = ((ptr4 + ptr3 / sizeof(global::FDISystem.CPBlockMap<FDISystem::CP_FORMAT_TYPE_V5>)) / 12 <= nCPBlocks) ? 1 : 0;
						global::System.Diagnostics.Debug.Assert(condition3 != 0);
						num10 = num13 + num10;
					}
					while (num10 < codeplugUnites.Count);
				}
				array2 = new byte[num4];
				ref byte ptr5 = ref array2[0];
				int num24 = 0;
				if (0 < num4)
				{
					do
					{
						ptr5 = *(auto_ptr<unsigned_u0020char> + num24);
						ptr5 = ref ptr5 + 1;
						num24++;
					}
					while (num24 < num4);
				}
			}
			catch
			{
				global::<Module>.___CxxCallUnwindDtor(ldftn(std.auto_ptr<unsigned\u0020char>.{dtor}), (void*)(&auto_ptr<unsigned_u0020char>));
				throw;
			}
			global::<Module>.delete(auto_ptr<unsigned_u0020char>);
			return array2;
			try
			{
			}
			catch
			{
				global::<Module>.___CxxCallUnwindDtor(ldftn(std.auto_ptr<unsigned\u0020char>.{dtor}), (void*)(&auto_ptr<unsigned_u0020char>));
				throw;
			}
		}

		// Token: 0x06000256 RID: 598 RVA: 0x0000BFA8 File Offset: 0x0000B3A8
		private void WriteToFDI(byte[] codeplugMapInfoData, global::System.Collections.Generic.List<byte[]> codeplugUnites, int[] distributeInfo)
		{
			int num = 0;
			distributeInfo[0] = distributeInfo[0] + 1;
			ref byte data = ref codeplugMapInfoData[0];
			this.fdi.InsertElementOnCertainBlock(0, ref data, codeplugMapInfoData.Length, 0, 0);
			int i = 1;
			int num2 = 1;
			global::System.Collections.Generic.List<byte[]>.Enumerator enumerator = codeplugUnites.GetEnumerator();
			if (enumerator.MoveNext())
			{
				do
				{
					byte[] array = enumerator.Current;
					int num3 = distributeInfo.Length;
					int num4 = num3;
					if (num < num4)
					{
						while (i >= distributeInfo[num])
						{
							i = 0;
							num++;
							if (num >= num4)
							{
								break;
							}
						}
					}
					if (num < num3)
					{
						data = ref array[0];
						this.fdi.InsertElementOnCertainBlock(num, ref data, array.Length, 0, num2);
						i++;
						num2++;
					}
				}
				while (enumerator.MoveNext());
			}
		}

		// Token: 0x06000257 RID: 599 RVA: 0x00001ADC File Offset: 0x00000EDC
		private static global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<ushort, global::System.Collections.Generic.List<byte[]>>> ArrangeCodeplugUnitList(global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<ushort, global::System.Collections.Generic.List<byte[]>>> codeplugUnitList)
		{
			if (codeplugUnitList == null)
			{
				throw new global::System.ArgumentNullException("codeplugUnitList");
			}
			global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<ushort, global::System.Collections.Generic.List<byte[]>>> list = new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<ushort, global::System.Collections.Generic.List<byte[]>>>();
			global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<ushort, global::System.Collections.Generic.List<byte[]>>> list2 = new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<ushort, global::System.Collections.Generic.List<byte[]>>>();
			global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<ushort, global::System.Collections.Generic.List<byte[]>>> list3 = new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<ushort, global::System.Collections.Generic.List<byte[]>>>();
			global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<ushort, global::System.Collections.Generic.List<byte[]>>>.Enumerator enumerator = codeplugUnitList.GetEnumerator();
			if (enumerator.MoveNext())
			{
				do
				{
					global::System.Collections.Generic.KeyValuePair<ushort, global::System.Collections.Generic.List<byte[]>> item = enumerator.Current;
					if (item.Value.Count > 1)
					{
						list3.Add(item);
					}
					else
					{
						list2.Add(item);
					}
				}
				while (enumerator.MoveNext());
			}
			list.AddRange(list2);
			list.AddRange(list3);
			return list;
		}

		// Token: 0x06000258 RID: 600 RVA: 0x00002E1C File Offset: 0x0000221C
		private static global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<ushort, global::System.Collections.Generic.List<byte[]>>> BreakdownCodeplugBlock(global::System.Collections.Generic.KeyValuePair<ushort, byte[]>[] cpDataBlocks)
		{
			if (cpDataBlocks == null)
			{
				throw new global::System.ArgumentNullException("cpDataBlocks");
			}
			global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<ushort, global::System.Collections.Generic.List<byte[]>>> list = new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<ushort, global::System.Collections.Generic.List<byte[]>>>();
			int num = 0;
			if (0 < cpDataBlocks.Length)
			{
				do
				{
					global::System.Collections.Generic.KeyValuePair<ushort, byte[]> keyValuePair = cpDataBlocks[num];
					int num2 = keyValuePair.Value.Length;
					byte condition = (num2 > 0) ? 1 : 0;
					global::System.Diagnostics.Debug.Assert(condition != 0);
					global::System.Collections.Generic.List<byte[]> list2 = new global::System.Collections.Generic.List<byte[]>();
					if (num2 + 12 <= 1024)
					{
						byte[] array = new byte[num2 + 12];
						global::System.Array.Copy(keyValuePair.Value, 0, array, 12, num2);
						list2.Add(array);
					}
					else
					{
						byte[] value = keyValuePair.Value;
						int num3 = 0;
						int num4 = value.Length;
						if (num4 > 0)
						{
							do
							{
								int num5 = (num4 < 856) ? num4 : 856;
								byte[] array2 = new byte[num5 + 12];
								global::System.Array.Copy(value, num3, array2, 12, num5);
								num3 = num5 + num3;
								num4 -= num5;
								list2.Add(array2);
							}
							while (num4 > 0);
						}
					}
					global::System.Collections.Generic.KeyValuePair<ushort, global::System.Collections.Generic.List<byte[]>> item = new global::System.Collections.Generic.KeyValuePair<ushort, global::System.Collections.Generic.List<byte[]>>(keyValuePair.Key, list2);
					list.Add(item);
					num++;
				}
				while (num < cpDataBlocks.Length);
			}
			return list;
		}

		// Token: 0x06000259 RID: 601 RVA: 0x00001FC0 File Offset: 0x000013C0
		private unsafe static ushort CalcUnitDataCheckSum(byte* pData, uint nSize)
		{
			ushort num = 0;
			byte* ptr = pData;
			uint num2 = nSize / (uint)sizeof(byte) + pData;
			if (pData < num2)
			{
				do
				{
					byte b = *(byte*)ptr;
					if (b != 0)
					{
						num = (ushort)b + num;
					}
					ptr += 1 / sizeof(byte);
				}
				while (ptr < num2);
			}
			return num + 43691;
		}

		// Token: 0x0600025A RID: 602 RVA: 0x00002930 File Offset: 0x00001D30
		[global::System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		protected void Dispose([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)] bool A_0)
		{
			if (A_0)
			{
				this.fdi = null;
			}
			else
			{
				try
				{
					this.fdi = null;
				}
				finally
				{
					base.Finalize();
				}
			}
		}

		// Token: 0x0600025B RID: 603 RVA: 0x00003290 File Offset: 0x00002690
		public sealed void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x0600025C RID: 604 RVA: 0x00002978 File Offset: 0x00001D78
		protected sealed override void Finalize()
		{
			this.Dispose(false);
		}

		// Token: 0x04000051 RID: 81
		private global::FDISystem.FDICore<FDISystem::FDI_TYPE_V5> fdi;
	}
}
