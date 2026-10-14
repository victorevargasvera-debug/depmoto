using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using Motorola.Common.Communication.TetraUtility;
using std;

namespace FDISystem
{
	// Token: 0x02000007 RID: 7
	internal sealed class CodeplugFDIPack<FDISystem::CP_FORMAT_TYPE_V2> : global::FDISystem.ICodeplugFDIPack
	{
		// Token: 0x06000203 RID: 515 RVA: 0x0000187C File Offset: 0x00000C7C
		public CodeplugFDIPack<FDISystem::CP_FORMAT_TYPE_V2>(global::FDISystem.FDICore<FDISystem::FDI_TYPE_V2> fdiSystem)
		{
			this.fdi = fdiSystem;
		}

		// Token: 0x06000204 RID: 516 RVA: 0x00001898 File Offset: 0x00000C98
		private void !CodeplugFDIPack<FDISystem::CP_FORMAT_TYPE_V2>()
		{
			this.fdi = null;
		}

		// Token: 0x06000205 RID: 517 RVA: 0x000018AC File Offset: 0x00000CAC
		private void ~CodeplugFDIPack<FDISystem::CP_FORMAT_TYPE_V2>()
		{
			this.fdi = null;
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000206 RID: 518 RVA: 0x00001748 File Offset: 0x00000B48
		public global::FDISystem.IFDI FDI
		{
			get
			{
				return this.fdi;
			}
		}

		// Token: 0x06000207 RID: 519 RVA: 0x0000C048 File Offset: 0x0000B448
		public unsafe global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<ushort, byte[]>> GetCodeplugBlockDataSet()
		{
			global::std.vector<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T,std::allocator<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T>\u0020> vector<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T,std::allocator<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T>_u0020> = 0;
			*(ref vector<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T,std::allocator<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T>_u0020> + 4) = 0;
			*(ref vector<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T,std::allocator<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T>_u0020> + 8) = 0;
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
							bool flag = this.ParseCodeplugImage(codeplugMapBuffer, ref vector<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T,std::allocator<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T>_u0020>, ref vector<int,std::allocator<int>_u0020>);
							if (flag)
							{
								this.ExtractCodeplugUnits(ref vector<int,std::allocator<int>_u0020>, list);
								result = this.BuildCodeplugBlockData(list, ref vector<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T,std::allocator<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T>_u0020>, ref vector<int,std::allocator<int>_u0020>);
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
						global::<Module>.std.vector<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T,std::allocator<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T>\u0020>._Tidy(ref vector<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T,std::allocator<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T>_u0020>);
						return result2;
						IL_C2:
						global::<Module>.std.vector<int,std::allocator<int>\u0020>._Tidy(ref vector<int,std::allocator<int>_u0020>);
						b = 1;
						global::<Module>.std.vector<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T,std::allocator<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T>\u0020>._Tidy(ref vector<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T,std::allocator<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T>_u0020>);
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
					global::<Module>.___CxxCallUnwindDtor(ldftn(std.vector<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T,std::allocator<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T>\u0020>.{dtor}), (void*)(&vector<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T,std::allocator<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T>_u0020>));
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
					global::<Module>.___CxxCallUnwindDtor(ldftn(std.vector<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T,std::allocator<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T>\u0020>.{dtor}), (void*)(&vector<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T,std::allocator<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T>_u0020>));
				}
				throw;
			}
			global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<ushort, byte[]>> result3;
			return result3;
		}

		// Token: 0x06000208 RID: 520 RVA: 0x0000BCA4 File Offset: 0x0000B0A4
		public void WriteCodeplug(global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<ushort, byte[]>> cpBlocks, uint codeplugSize)
		{
			try
			{
				if (cpBlocks == null)
				{
					throw new global::System.ArgumentNullException("cpBlocks");
				}
				global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<ushort, global::System.Collections.Generic.List<byte[]>>> codeplugUnitList = global::FDISystem.CodeplugFDIPack<FDISystem::CP_FORMAT_TYPE_V2>.BreakdownCodeplugBlock(cpBlocks.ToArray());
				codeplugUnitList = global::FDISystem.CodeplugFDIPack<FDISystem::CP_FORMAT_TYPE_V2>.ArrangeCodeplugUnitList(codeplugUnitList);
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

		// Token: 0x06000209 RID: 521 RVA: 0x0000BD68 File Offset: 0x0000B168
		private byte[] GetCodeplugMapUnit()
		{
			return this.fdi.FetchElementData(0, 0);
		}

		// Token: 0x0600020A RID: 522 RVA: 0x00008E1C File Offset: 0x0000821C
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
		private unsafe bool ParseCodeplugImage(byte[] codeplugMapBuffer, global::std.vector<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T,std::allocator<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T>\u0020>* cpBlockMaps, global::std.vector<int,std::allocator<int>\u0020>* cpUnitSizes)
		{
			if (codeplugMapBuffer == null)
			{
				throw new global::System.ArgumentNullException("codeplugMapBuffer");
			}
			global::<Module>.std.vector<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T,std::allocator<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T>\u0020>.clear(cpBlockMaps);
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
				ushort num4 = *(ushort*)(ptr + num2 + 4);
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
					ushort num7 = *(ushort*)(ptr + num2 + 4);
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
					num2 = 8 - ((int)num9 << 3) + num2;
					if (num2 < 0)
					{
						return false;
					}
				}
				uint num10 = (uint)(i - num2 + 1) >> 3;
				byte* ptr2 = ref byte& + num2;
				if (*(cpBlockMaps + 8) - *cpBlockMaps >> 3 < (int)num10)
				{
					if (536870911U < num10)
					{
						global::<Module>.std._Xlength_error((sbyte*)(&global::<Module>.??_C@_0BD@OLBABOEK@vector?$DMT?$DO?5too?5long?$AA@));
					}
					global::<Module>.std.vector<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T,std::allocator<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T>\u0020>._Reallocate(cpBlockMaps, num10);
				}
				uint num11 = 0U;
				if (0U < num10)
				{
					do
					{
						global::<Module>.std.vector<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T,std::allocator<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T>\u0020>.push_back(cpBlockMaps, num11 * 8U + ptr2);
						num11 += 1U;
					}
					while (num11 < num10);
				}
				uint num12 = 0U;
				uint num13 = 0U;
				if (0U < num10)
				{
					do
					{
						global::FDISystem.IFDI ifdi = this.fdi;
						int num14 = (int)(num13 * 8U + (uint)(*cpBlockMaps));
						global::FDISystem.ByteOrder fdibyteOrder3 = ifdi.FDIByteOrder;
						byte b = *(num14 + 3);
						byte b3;
						if (fdibyteOrder3 == global::FDISystem.ByteOrder.BigEndian)
						{
							byte b2 = b;
							global::<Module>.std.reverse<unsigned\u0020char\u0020*>(&b2, ref b2 + 1);
							b3 = b2;
						}
						else
						{
							b3 = b;
						}
						num12 = (uint)b3 + num12;
						num13 += 1U;
					}
					while (num13 < num10);
				}
				num12 += 1U;
				byte condition = (num2 - 2 == (int)(num12 * 2U)) ? 1 : 0;
				global::System.Diagnostics.Debug.Assert(condition != 0);
				if (num2 - 2 == (int)(num12 * 2U))
				{
					if (*(cpUnitSizes + 8) - *cpUnitSizes >> 2 < (int)num12)
					{
						if (1073741823U < num12)
						{
							global::<Module>.std._Xlength_error((sbyte*)(&global::<Module>.??_C@_0BD@OLBABOEK@vector?$DMT?$DO?5too?5long?$AA@));
						}
						global::<Module>.std.vector<int,std::allocator<int>\u0020>._Reallocate(cpUnitSizes, num12);
					}
					ushort* ptr3 = ref byte&;
					uint num15 = 0U;
					if (0U < num12)
					{
						do
						{
							int fdibyteOrder4 = (int)this.fdi.FDIByteOrder;
							ushort num16 = num15[ptr3];
							ushort num18;
							if (fdibyteOrder4 == 1)
							{
								ushort num17 = num16;
								global::<Module>.std.reverse<unsigned\u0020char\u0020*>((byte*)(&num17), ref num17 + 2);
								num18 = num17;
							}
							else
							{
								num18 = num16;
							}
							int num19 = (int)num18;
							global::<Module>.std.vector<int,std::allocator<int>\u0020>.push_back(cpUnitSizes, ref num19);
							num15 += 1U;
						}
						while (num15 < num12);
					}
					return true;
				}
				return false;
			}
			return false;
		}

		// Token: 0x0600020B RID: 523 RVA: 0x0000BD84 File Offset: 0x0000B184
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
						if (!global::<Module>.FDISystem.CPFixedUnitHeader<FDISystem::CP_FORMAT_TYPE_V2>.IsFixUnitHeaderValid(ptr, ifdi.FDIByteOrder))
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

		// Token: 0x0600020C RID: 524 RVA: 0x00006D50 File Offset: 0x00006150
		private unsafe global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<ushort, byte[]>> BuildCodeplugBlockData(global::System.Collections.Generic.List<global::System.IntPtr> codeplugUnitDatas, global::std.vector<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T,std::allocator<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T>\u0020>* cpBlockMaps, global::std.vector<int,std::allocator<int>\u0020>* cpUnitSizes)
		{
			global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<ushort, byte[]>> list = new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<ushort, byte[]>>();
			uint num = 0U;
			int num2 = *cpBlockMaps;
			if (0 < *(cpBlockMaps + 4) - num2 >> 3)
			{
				do
				{
					global::FDISystem.IFDI ifdi = this.fdi;
					int num3 = (int)(num * 8U + (uint)num2);
					global::FDISystem.ByteOrder fdibyteOrder = ifdi.FDIByteOrder;
					ushort num4 = *(num3 + 4);
					ushort num6;
					if (fdibyteOrder == global::FDISystem.ByteOrder.BigEndian)
					{
						ushort num5 = num4;
						num6 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,unsigned\u0020short>(num5, num5);
					}
					else
					{
						num6 = num4;
					}
					uint num7 = (uint)num6;
					global::FDISystem.IFDI ifdi2 = this.fdi;
					int num8 = *cpBlockMaps + (int)(num * 8U);
					global::FDISystem.ByteOrder fdibyteOrder2 = ifdi2.FDIByteOrder;
					byte b = *(num8 + 3);
					byte b3;
					if (fdibyteOrder2 == global::FDISystem.ByteOrder.BigEndian)
					{
						byte b2 = b;
						b3 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020char,unsigned\u0020char>(b2, b2);
					}
					else
					{
						b3 = b;
					}
					uint num9 = (uint)b3;
					uint num10 = 0U;
					uint num11 = num7 + num9;
					if (num7 < num11)
					{
						int num12 = (int)(num7 * 4U + (uint)(*cpUnitSizes));
						uint num13 = num11 - num7;
						do
						{
							num10 = (uint)(*num12 + (int)num10);
							num12 += 4;
							num13 -= 1U;
						}
						while (num13 > 0U);
					}
					byte[] array = new byte[num10];
					ref byte byte& = ref array[0];
					try
					{
						byte* ptr = ref byte&;
						uint num14 = num7;
						if (num7 < num11)
						{
							do
							{
								global::System.IntPtr intPtr = codeplugUnitDatas[(int)(num14 - 1U)];
								int* ptr2 = num14 * 4U + (uint)(*cpUnitSizes);
								cpblk(ptr, (byte*)intPtr.ToPointer() + 8, *ptr2);
								ptr = *(num14 * 4U + (uint)(*cpUnitSizes)) + ptr;
								num14 += 1U;
							}
							while (num14 < num11);
						}
						global::System.Collections.Generic.KeyValuePair<ushort, byte[]> item = new global::System.Collections.Generic.KeyValuePair<ushort, byte[]>(*(*cpBlockMaps + (int)(num * 8U)), array);
						list.Add(item);
					}
					catch
					{
						throw;
					}
					num += 1U;
					num2 = *cpBlockMaps;
				}
				while (num < (uint)(*(cpBlockMaps + 4) - num2 >> 3));
			}
			return list;
		}

		// Token: 0x0600020D RID: 525 RVA: 0x00004E90 File Offset: 0x00004290
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
								global::FDISystem.CPFixedUnitHeader<FDISystem::CP_FORMAT_TYPE_V2>* ptr = ref byte&;
								global::FDISystem.ByteOrder fdibyteOrder = ((global::FDISystem.IFDI)this.fdi).FDIByteOrder;
								*(short*)ptr = (short)key;
								int fdibyteOrder2 = (int)((global::FDISystem.IFDI)this.fdi).FDIByteOrder;
								uint count = (uint)keyValuePair.Value.Count;
								byte destVar = *(byte*)(ptr + 4 / sizeof(global::FDISystem.CPFixedUnitHeader<FDISystem::CP_FORMAT_TYPE_V2>));
								byte b;
								if (fdibyteOrder2 == 1)
								{
									b = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020char,unsigned\u0020int>(destVar, count);
								}
								else
								{
									b = (byte)count;
								}
								*(byte*)(ptr + 4 / sizeof(global::FDISystem.CPFixedUnitHeader<FDISystem::CP_FORMAT_TYPE_V2>)) = b;
								byte b3;
								if (((global::FDISystem.IFDI)this.fdi).FDIByteOrder == global::FDISystem.ByteOrder.BigEndian)
								{
									byte b2 = (byte)num;
									global::<Module>.std.reverse<unsigned\u0020char\u0020*>(&b2, ref b2 + 1);
									b3 = b2;
								}
								else
								{
									b3 = (byte)num;
								}
								*(byte*)(ptr + 5 / sizeof(global::FDISystem.CPFixedUnitHeader<FDISystem::CP_FORMAT_TYPE_V2>)) = b3;
								int fdibyteOrder3 = (int)((global::FDISystem.IFDI)this.fdi).FDIByteOrder;
								uint num2 = (uint)(array.Length - 8);
								ushort num4;
								if (fdibyteOrder3 == 1)
								{
									ushort num3 = (ushort)num2;
									global::<Module>.std.reverse<unsigned\u0020char\u0020*>((byte*)(&num3), ref num3 + 2);
									num4 = num3;
								}
								else
								{
									num4 = (ushort)num2;
								}
								*(short*)(ptr + 2 / sizeof(global::FDISystem.CPFixedUnitHeader<FDISystem::CP_FORMAT_TYPE_V2>)) = (short)num4;
								ushort num5 = global::FDISystem.CodeplugFDIPack<FDISystem::CP_FORMAT_TYPE_V2>.CalcUnitDataCheckSum(ref byte& + 8, (uint)(array.Length - 8));
								int fdibyteOrder4 = (int)((global::FDISystem.IFDI)this.fdi).FDIByteOrder;
								uint num6 = (uint)num5;
								ushort destVar2 = *(ushort*)(ptr + 6 / sizeof(global::FDISystem.CPFixedUnitHeader<FDISystem::CP_FORMAT_TYPE_V2>));
								ushort num7;
								if (fdibyteOrder4 == 1)
								{
									num7 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,unsigned\u0020int>(destVar2, num6);
								}
								else
								{
									num7 = (ushort)num6;
								}
								*(short*)(ptr + 6 / sizeof(global::FDISystem.CPFixedUnitHeader<FDISystem::CP_FORMAT_TYPE_V2>)) = (short)num7;
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

		// Token: 0x0600020E RID: 526 RVA: 0x00002A64 File Offset: 0x00001E64
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
						byte condition2 = (codeplugUnites[i].Length - 8 != 0) ? 1 : 0;
						global::System.Diagnostics.Debug.Assert(condition2 != 0);
						num3 = (uint)(codeplugUnites[i].Length + (int)num3 - 8);
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
									goto IL_142;
								}
							}
							array[num5] = 1;
							array[num7]--;
						}
						IL_142:
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

		// Token: 0x0600020F RID: 527 RVA: 0x0000503C File Offset: 0x0000443C
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
			int num4 = nCPBlocks * 4 + count + 8 << 1;
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
						uint num7 = (uint)(array.Length - 8);
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
				global::FDISystem.CPBlockMap<FDISystem::CP_FORMAT_TYPE_V2>* ptr2 = (global::FDISystem.CPBlockMap<FDISystem::CP_FORMAT_TYPE_V2>*)(ptr + 1);
				int num10 = 0;
				int num11 = 0;
				int num12 = 0;
				if (0 < codeplugUnites.Count)
				{
					global::FDISystem.CPBlockMap<FDISystem::CP_FORMAT_TYPE_V2>* ptr3 = ptr2 + 4 / sizeof(global::FDISystem.CPBlockMap<FDISystem::CP_FORMAT_TYPE_V2>);
					global::FDISystem.CPBlockMap<FDISystem::CP_FORMAT_TYPE_V2>* ptr4 = -4 - ptr2;
					do
					{
						int num13 = 0;
						byte b = codeplugUnites[num10][0];
						byte b2 = codeplugUnites[num10][1];
						global::FDISystem.ByteOrder fdibyteOrder2 = ((global::FDISystem.IFDI)this.fdi).FDIByteOrder;
						*(byte*)(ptr3 - 4 / sizeof(global::FDISystem.CPBlockMap<FDISystem::CP_FORMAT_TYPE_V2>)) = (byte)((sbyte)b);
						*(byte*)(ptr3 - 3 / sizeof(global::FDISystem.CPBlockMap<FDISystem::CP_FORMAT_TYPE_V2>)) = (byte)((sbyte)b2);
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
						byte b4;
						if (((global::FDISystem.IFDI)this.fdi).FDIByteOrder == global::FDISystem.ByteOrder.BigEndian)
						{
							byte b3 = (byte)num13;
							global::<Module>.std.reverse<unsigned\u0020char\u0020*>(&b3, ref b3 + 1);
							b4 = b3;
						}
						else
						{
							b4 = (byte)num13;
						}
						*(byte*)(ptr3 - 1 / sizeof(global::FDISystem.CPBlockMap<FDISystem::CP_FORMAT_TYPE_V2>)) = b4;
						num3 = unitDistributionInfo.Length;
						if (num11 < num3)
						{
							do
							{
								int num18 = num12 + unitDistributionInfo[num11];
								if (num10 < num18)
								{
									break;
								}
								num12 = num18;
								num11++;
							}
							while (num11 < num3);
						}
						int fdibyteOrder4 = (int)((global::FDISystem.IFDI)this.fdi).FDIByteOrder;
						int num19 = num11 + 1;
						byte b6;
						if (fdibyteOrder4 == 1)
						{
							byte b5 = (byte)num19;
							global::<Module>.std.reverse<unsigned\u0020char\u0020*>(&b5, ref b5 + 1);
							b6 = b5;
						}
						else
						{
							b6 = (byte)num19;
						}
						*(byte*)(ptr3 - 2 / sizeof(global::FDISystem.CPBlockMap<FDISystem::CP_FORMAT_TYPE_V2>)) = b6;
						global::FDISystem.ByteOrder fdibyteOrder5 = ((global::FDISystem.IFDI)this.fdi).FDIByteOrder;
						initblk(ptr3 + 2 / sizeof(global::FDISystem.CPBlockMap<FDISystem::CP_FORMAT_TYPE_V2>), 0, 2);
						ptr3 += 8 / sizeof(global::FDISystem.CPBlockMap<FDISystem::CP_FORMAT_TYPE_V2>);
						byte condition3 = (ptr4 + ptr3 / sizeof(global::FDISystem.CPBlockMap<FDISystem::CP_FORMAT_TYPE_V2>) >> 3 <= nCPBlocks) ? 1 : 0;
						global::System.Diagnostics.Debug.Assert(condition3 != 0);
						num10 = num13 + num10;
					}
					while (num10 < codeplugUnites.Count);
				}
				array2 = new byte[num4];
				ref byte ptr5 = ref array2[0];
				int num20 = 0;
				if (0 < num4)
				{
					do
					{
						ptr5 = *(auto_ptr<unsigned_u0020char> + num20);
						ptr5 = ref ptr5 + 1;
						num20++;
					}
					while (num20 < num4);
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

		// Token: 0x06000210 RID: 528 RVA: 0x0000B9A0 File Offset: 0x0000ADA0
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

		// Token: 0x06000211 RID: 529 RVA: 0x00001A5C File Offset: 0x00000E5C
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

		// Token: 0x06000212 RID: 530 RVA: 0x00002BBC File Offset: 0x00001FBC
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
					if (num2 + 8 <= 1024)
					{
						byte[] array = new byte[num2 + 8];
						global::System.Array.Copy(keyValuePair.Value, 0, array, 8, num2);
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
								byte[] array2 = new byte[num5 + 8];
								global::System.Array.Copy(value, num3, array2, 8, num5);
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

		// Token: 0x06000213 RID: 531 RVA: 0x00001E64 File Offset: 0x00001264
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

		// Token: 0x06000214 RID: 532 RVA: 0x0000287C File Offset: 0x00001C7C
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

		// Token: 0x06000215 RID: 533 RVA: 0x00003258 File Offset: 0x00002658
		public sealed void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x06000216 RID: 534 RVA: 0x000028C4 File Offset: 0x00001CC4
		protected sealed override void Finalize()
		{
			this.Dispose(false);
		}

		// Token: 0x04000048 RID: 72
		private global::FDISystem.FDICore<FDISystem::FDI_TYPE_V2> fdi;
	}
}
