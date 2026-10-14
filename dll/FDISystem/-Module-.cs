using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;
using System.Threading;
using <CppImplementationDetails>;
using <CrtImplementationDetails>;
using FDISystem;
using std;

// Token: 0x02000001 RID: 1
internal class <Module>
{
	// Token: 0x06000001 RID: 1 RVA: 0x000010C0 File Offset: 0x000004C0
	internal static double hypot(double __unnamed000, double __unnamed001)
	{
		return global::<Module>._hypot(__unnamed000, __unnamed001);
	}

	// Token: 0x06000002 RID: 2 RVA: 0x000010DC File Offset: 0x000004DC
	internal unsafe static global::std.exception_ptr* {ctor}(global::std.exception_ptr* A_0, global::std.exception_ptr* _Rhs)
	{
		global::<Module>.__ExceptionPtrCopy(A_0, _Rhs);
		return A_0;
	}

	// Token: 0x06000003 RID: 3 RVA: 0x000010F8 File Offset: 0x000004F8
	internal unsafe static void* @new(uint __unnamed000, void* _Where)
	{
		return _Where;
	}

	// Token: 0x06000004 RID: 4 RVA: 0x00001108 File Offset: 0x00000508
	internal unsafe static void delete(void* A_0, void* A_1)
	{
	}

	// Token: 0x06000005 RID: 5 RVA: 0x0000320C File Offset: 0x0000260C
	internal unsafe static global::std._Iterator_base12* {ctor}(global::std._Iterator_base12* A_0, global::std._Iterator_base12* _Right)
	{
		*A_0 = 0;
		*(A_0 + 4) = 0;
		uint num = (uint)(*_Right);
		if (0U != num)
		{
			global::std._Container_base12* ptr = *num;
			if (ptr != null)
			{
				*A_0 = *(int*)ptr;
			}
		}
		return A_0;
	}

	// Token: 0x06000006 RID: 6 RVA: 0x0000275C File Offset: 0x00001B5C
	internal unsafe static global::std._Iterator_base12* =(global::std._Iterator_base12* A_0, global::std._Iterator_base12* _Right)
	{
		uint num = (uint)(*_Right);
		if (*A_0 != (int)num && num != 0U)
		{
			global::std._Container_base12* ptr = *num;
			if (ptr != null)
			{
				*A_0 = *(int*)ptr;
			}
		}
		return A_0;
	}

	// Token: 0x06000007 RID: 7 RVA: 0x00001118 File Offset: 0x00000518
	internal unsafe static void _Adopt(global::std._Iterator_base12* A_0, global::std._Container_base12* _Parent)
	{
		if (_Parent != null)
		{
			*A_0 = *(int*)_Parent;
		}
	}

	// Token: 0x06000008 RID: 8 RVA: 0x0000112C File Offset: 0x0000052C
	internal unsafe static global::std.allocator<void>* {ctor}(global::std.allocator<void>* A_0, global::std.allocator<void>* A_0)
	{
		return A_0;
	}

	// Token: 0x06000009 RID: 9 RVA: 0x00001140 File Offset: 0x00000540
	internal unsafe static global::std._Ignore* {ctor}(global::std._Ignore* A_0)
	{
		return A_0;
	}

	// Token: 0x0600000A RID: 10 RVA: 0x00001150 File Offset: 0x00000550
	internal unsafe static global::std.tuple<>* {ctor}(global::std.tuple<>* A_0, global::std.tuple<>* A_0)
	{
		return A_0;
	}

	// Token: 0x0600000B RID: 11 RVA: 0x00001164 File Offset: 0x00000564
	internal unsafe static void SetUnitHeaderTable(global::FDISystem.FDI_TYPE_V2.UNIT_HEADER* pUnitHeader, uint table, global::FDISystem.ByteOrder byteOrder)
	{
	}

	// Token: 0x0600000C RID: 12 RVA: 0x00001174 File Offset: 0x00000574
	internal static int GetMaxSizeOfMultiInstance(int unitGranularity)
	{
		return (unitGranularity - 6) / 3;
	}

	// Token: 0x0600000D RID: 13 RVA: 0x00001188 File Offset: 0x00000588
	[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
	internal unsafe static bool UnitHdrNotUsed(global::FDISystem.FDI_TYPE_V2.UNIT_HEADER* pUnitHeader)
	{
		return (*(byte*)(pUnitHeader + 6 / sizeof(global::FDISystem.FDI_TYPE_V2.UNIT_HEADER)) == 7) ? 1 : 0;
	}

	// Token: 0x0600000E RID: 14 RVA: 0x000011A0 File Offset: 0x000005A0
	internal static uint GetMaxEntriesInGroupTable(uint blockSize)
	{
		return 255;
	}

	// Token: 0x0600000F RID: 15 RVA: 0x000011B4 File Offset: 0x000005B4
	internal unsafe static int MultiInstanceIsInvalid(byte* dataBuffer, int data_loc, int instance)
	{
		return ((uint)(*(byte*)(data_loc / sizeof(byte) + (instance / 2 / sizeof(byte) + dataBuffer) + 4 / sizeof(byte))) >> (int)((byte)(4 - (instance % 2 << 2))) & 15U) == 1U;
	}

	// Token: 0x06000010 RID: 16 RVA: 0x000011DC File Offset: 0x000005DC
	internal unsafe static int MultiInstanceIsValid(byte* dataBuffer, int data_loc, int instance)
	{
		return ((uint)(*(byte*)(data_loc / sizeof(byte) + (instance / 2 / sizeof(byte) + dataBuffer) + 4 / sizeof(byte))) >> (int)((byte)(4 - (instance % 2 << 2))) & 15U) == 3U;
	}

	// Token: 0x06000011 RID: 17 RVA: 0x00001204 File Offset: 0x00000604
	[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
	internal unsafe static bool MultiInstanceIsAllocating(byte* dataBuffer, int data_loc, int instance)
	{
		return (*(byte*)(instance / sizeof(byte) + (dataBuffer + data_loc / sizeof(byte)) + 4 / sizeof(byte)) == 252) ? 1 : 0;
	}

	// Token: 0x06000012 RID: 18 RVA: 0x00001224 File Offset: 0x00000624
	[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
	internal unsafe static bool MultiInstanceIsEmpty(byte* dataBuffer, int data_loc, int instance)
	{
		return (((uint)(*(byte*)(data_loc / sizeof(byte) + (instance / 2 / sizeof(byte) + dataBuffer) + 4 / sizeof(byte))) >> (int)((byte)(4 - (instance % 2 << 2))) & 15U) == 15U) ? 1 : 0;
	}

	// Token: 0x06000013 RID: 19 RVA: 0x0000687C File Offset: 0x00005C7C
	internal unsafe static int GetMultiInstLoc(byte* dataBuffer, int loc, int instance, global::FDISystem.ByteOrder byteOrder)
	{
		ushort num = *(ushort*)(loc / sizeof(byte) + dataBuffer + 2 / sizeof(byte));
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
		int num4 = (int)num3;
		ushort num5 = *(ushort*)(loc / sizeof(byte) + dataBuffer);
		ushort num7;
		if (byteOrder == global::FDISystem.ByteOrder.BigEndian)
		{
			ushort num6 = num5;
			num7 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,unsigned\u0020short>(num6, num6);
		}
		else
		{
			num7 = num5;
		}
		return loc + (int)num7 * instance + (num4 + 1) / 2 + 4;
	}

	// Token: 0x06000014 RID: 20 RVA: 0x0000124C File Offset: 0x0000064C
	internal unsafe static void GetMultiInstInfo(int unitGranularity, int instanceSize, int nInstances, int* maxPossible, int* sum)
	{
		*maxPossible = (int)((double)((float)(unitGranularity - 4)) / ((double)instanceSize + 0.5));
		*sum = (int)(((double)((float)instanceSize) + 0.5) * (double)((float)nInstances) + 4.5);
	}

	// Token: 0x06000015 RID: 21 RVA: 0x00001290 File Offset: 0x00000690
	internal unsafe static uint GetUnitHeaderTable(global::FDISystem.FDI_TYPE_V2.UNIT_HEADER* unitHeader, global::FDISystem.ByteOrder byteOrder)
	{
		return 0U;
	}

	// Token: 0x06000016 RID: 22 RVA: 0x000012A0 File Offset: 0x000006A0
	internal unsafe static void SetUnitHeaderPad(global::FDISystem.FDI_TYPE_V2.UNIT_HEADER* unitHeader, global::FDISystem.ByteOrder byteOrder)
	{
	}

	// Token: 0x06000017 RID: 23 RVA: 0x00004BE8 File Offset: 0x00003FE8
	internal unsafe static void SetUnitHeaderTable(global::FDISystem.FDI_TYPE_V5.UNIT_HEADER* pUnitHeader, uint table, global::FDISystem.ByteOrder byteOrder)
	{
		ushort destVar = *(ushort*)(pUnitHeader + 2 / sizeof(global::FDISystem.FDI_TYPE_V5.UNIT_HEADER));
		ushort num;
		if (byteOrder == global::FDISystem.ByteOrder.BigEndian)
		{
			num = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,unsigned\u0020int>(destVar, table);
		}
		else
		{
			num = table;
		}
		*(short*)(pUnitHeader + 2 / sizeof(global::FDISystem.FDI_TYPE_V5.UNIT_HEADER)) = (short)num;
	}

	// Token: 0x06000018 RID: 24 RVA: 0x000012B0 File Offset: 0x000006B0
	internal static int GetMaxSizeOfMultiInstance(int unitGranularity)
	{
		return (unitGranularity - 7) / 3;
	}

	// Token: 0x06000019 RID: 25 RVA: 0x000012C4 File Offset: 0x000006C4
	[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
	internal unsafe static bool UnitHdrNotUsed(global::FDISystem.FDI_TYPE_V5.UNIT_HEADER* pUnitHeader)
	{
		return 0;
	}

	// Token: 0x0600001A RID: 26 RVA: 0x000012D4 File Offset: 0x000006D4
	internal static uint GetMaxEntriesInGroupTable(uint blockSize)
	{
		return (blockSize - 40U) / 12U;
	}

	// Token: 0x0600001B RID: 27 RVA: 0x000012E8 File Offset: 0x000006E8
	internal unsafe static int MultiInstanceIsInvalid(byte* dataBuffer, int data_loc, int instance)
	{
		return *(byte*)(instance / sizeof(byte) + (dataBuffer + data_loc / sizeof(byte)) + 4 / sizeof(byte)) == 192;
	}

	// Token: 0x0600001C RID: 28 RVA: 0x00001304 File Offset: 0x00000704
	internal unsafe static int MultiInstanceIsValid(byte* dataBuffer, int data_loc, int instance)
	{
		return *(byte*)(instance / sizeof(byte) + (dataBuffer + data_loc / sizeof(byte)) + 4 / sizeof(byte)) == 240;
	}

	// Token: 0x0600001D RID: 29 RVA: 0x00001320 File Offset: 0x00000720
	[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
	internal unsafe static bool MultiInstanceIsAllocating(byte* dataBuffer, int data_loc, int instance)
	{
		return (((uint)(*(byte*)(data_loc / sizeof(byte) + (instance / 2 / sizeof(byte) + dataBuffer) + 4 / sizeof(byte))) >> (int)((byte)(4 - (instance % 2 << 2))) & 15U) == 7U) ? 1 : 0;
	}

	// Token: 0x0600001E RID: 30 RVA: 0x00001348 File Offset: 0x00000748
	[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
	internal unsafe static bool MultiInstanceIsEmpty(byte* dataBuffer, int data_loc, int instance)
	{
		return (*(byte*)(instance / sizeof(byte) + (dataBuffer + data_loc / sizeof(byte)) + 4 / sizeof(byte)) == byte.MaxValue) ? 1 : 0;
	}

	// Token: 0x0600001F RID: 31 RVA: 0x000068C8 File Offset: 0x00005CC8
	internal unsafe static int GetMultiInstLoc(byte* dataBuffer, int loc, int instance, global::FDISystem.ByteOrder byteOrder)
	{
		ushort num = *(ushort*)(loc / sizeof(byte) + dataBuffer + 2 / sizeof(byte));
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
		int num4 = (int)num3;
		ushort num5 = *(ushort*)(loc / sizeof(byte) + dataBuffer);
		ushort num7;
		if (byteOrder == global::FDISystem.ByteOrder.BigEndian)
		{
			ushort num6 = num5;
			num7 = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,unsigned\u0020short>(num6, num6);
		}
		else
		{
			num7 = num5;
		}
		return loc + ((int)num7 * instance + num4) + 4;
	}

	// Token: 0x06000020 RID: 32 RVA: 0x00001368 File Offset: 0x00000768
	internal unsafe static void GetMultiInstInfo(int unitGranularity, int instanceSize, int nInstances, int* maxPossible, int* sum)
	{
		int num = instanceSize + 1;
		*maxPossible = (unitGranularity - 4) / num;
		*sum = num * nInstances + 4;
	}

	// Token: 0x06000021 RID: 33 RVA: 0x00006910 File Offset: 0x00005D10
	internal unsafe static uint GetUnitHeaderTable(global::FDISystem.FDI_TYPE_V5.UNIT_HEADER* unitHeader, global::FDISystem.ByteOrder byteOrder)
	{
		ushort num = *(unitHeader + 2);
		ushort result;
		if (byteOrder == global::FDISystem.ByteOrder.BigEndian)
		{
			ushort num2 = num;
			result = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,unsigned\u0020short>(num2, num2);
		}
		else
		{
			result = num;
		}
		return (uint)result;
	}

	// Token: 0x06000022 RID: 34 RVA: 0x00004C10 File Offset: 0x00004010
	internal unsafe static void SetUnitHeaderPad(global::FDISystem.FDI_TYPE_V5.UNIT_HEADER* unitHeader, global::FDISystem.ByteOrder byteOrder)
	{
		byte destVar = *(unitHeader + 9);
		byte b;
		if (byteOrder == global::FDISystem.ByteOrder.BigEndian)
		{
			b = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020char,int>(destVar, 0);
		}
		else
		{
			b = 0;
		}
		*(unitHeader + 9) = b;
	}

	// Token: 0x06000023 RID: 35 RVA: 0x00004C3C File Offset: 0x0000403C
	internal static ushort FDIAdjustDataBytes<unsigned\u0020short>(ushort var, global::FDISystem.ByteOrder byteOrder)
	{
		if (byteOrder == global::FDISystem.ByteOrder.BigEndian)
		{
			return global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,unsigned\u0020short>(var, var);
		}
		return var;
	}

	// Token: 0x06000024 RID: 36 RVA: 0x000040B8 File Offset: 0x000034B8
	internal static ushort FDIAdjustDataBytes<unsigned\u0020short,unsigned\u0020int>(ushort destVar, uint srcVar, global::FDISystem.ByteOrder byteOrder)
	{
		if (byteOrder == global::FDISystem.ByteOrder.BigEndian)
		{
			return global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,unsigned\u0020int>(destVar, srcVar);
		}
		return (ushort)srcVar;
	}

	// Token: 0x06000025 RID: 37 RVA: 0x000040D4 File Offset: 0x000034D4
	internal static byte FDIAdjustDataBytes<unsigned\u0020char,int>(byte destVar, int srcVar, global::FDISystem.ByteOrder byteOrder)
	{
		if (byteOrder == global::FDISystem.ByteOrder.BigEndian)
		{
			return global::<Module>.FDISystem.ReverseBytes<unsigned\u0020char,int>(destVar, srcVar);
		}
		return (byte)srcVar;
	}

	// Token: 0x06000026 RID: 38 RVA: 0x0000194C File Offset: 0x00000D4C
	internal static uint GetBlockInfoSize()
	{
		return 16;
	}

	// Token: 0x06000027 RID: 39 RVA: 0x0000195C File Offset: 0x00000D5C
	internal static uint GetBlockInfoSize()
	{
		return 16;
	}

	// Token: 0x06000028 RID: 40 RVA: 0x000032AC File Offset: 0x000026AC
	internal unsafe static global::std.vector<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T,std::allocator<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T>\u0020>* {ctor}(global::std.vector<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T,std::allocator<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T>\u0020>* A_0)
	{
		*A_0 = 0;
		*(A_0 + 4) = 0;
		*(A_0 + 8) = 0;
		return A_0;
	}

	// Token: 0x06000029 RID: 41 RVA: 0x00004C58 File Offset: 0x00004058
	internal unsafe static void {dtor}(global::std.vector<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T,std::allocator<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T>\u0020>* A_0)
	{
		global::<Module>.std.vector<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T,std::allocator<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T>\u0020>._Tidy(A_0);
	}

	// Token: 0x0600002A RID: 42 RVA: 0x000032C8 File Offset: 0x000026C8
	internal unsafe static global::std.vector<int,std::allocator<int>\u0020>* {ctor}(global::std.vector<int,std::allocator<int>\u0020>* A_0)
	{
		*A_0 = 0;
		*(A_0 + 4) = 0;
		*(A_0 + 8) = 0;
		return A_0;
	}

	// Token: 0x0600002B RID: 43 RVA: 0x0000397C File Offset: 0x00002D7C
	internal unsafe static void {dtor}(global::std.vector<int,std::allocator<int>\u0020>* A_0)
	{
		global::<Module>.std.vector<int,std::allocator<int>\u0020>._Tidy(A_0);
	}

	// Token: 0x0600002C RID: 44 RVA: 0x000032E4 File Offset: 0x000026E4
	internal unsafe static global::std.vector<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T,std::allocator<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T>\u0020>* {ctor}(global::std.vector<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T,std::allocator<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T>\u0020>* A_0)
	{
		*A_0 = 0;
		*(A_0 + 4) = 0;
		*(A_0 + 8) = 0;
		return A_0;
	}

	// Token: 0x0600002D RID: 45 RVA: 0x00004C6C File Offset: 0x0000406C
	internal unsafe static void {dtor}(global::std.vector<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T,std::allocator<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T>\u0020>* A_0)
	{
		global::<Module>.std.vector<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T,std::allocator<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T>\u0020>._Tidy(A_0);
	}

	// Token: 0x0600002E RID: 46 RVA: 0x000040F0 File Offset: 0x000034F0
	internal unsafe static void _Tidy(global::std.vector<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T,std::allocator<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T>\u0020>* A_0)
	{
		if (*A_0 != 0)
		{
			global::<Module>.std._Container_base0._Orphan_all(A_0);
			global::<Module>.delete(*A_0);
			*A_0 = 0;
			*(A_0 + 4) = 0;
			*(A_0 + 8) = 0;
		}
	}

	// Token: 0x0600002F RID: 47 RVA: 0x0000196C File Offset: 0x00000D6C
	internal unsafe static global::std.allocator<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T>* {ctor}(global::std.allocator<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T>* A_0)
	{
		return A_0;
	}

	// Token: 0x06000030 RID: 48 RVA: 0x000029A4 File Offset: 0x00001DA4
	internal unsafe static global::std._Vector_alloc<0,std::_Vec_base_types<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T,std::allocator<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T>\u0020>\u0020>* {ctor}(global::std._Vector_alloc<0,std::_Vec_base_types<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T,std::allocator<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T>\u0020>\u0020>* A_0, global::std.allocator<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T>* A_0)
	{
		*A_0 = 0;
		*(A_0 + 4) = 0;
		*(A_0 + 8) = 0;
		return A_0;
	}

	// Token: 0x06000031 RID: 49 RVA: 0x000035D4 File Offset: 0x000029D4
	internal unsafe static void _Tidy(global::std.vector<int,std::allocator<int>\u0020>* A_0)
	{
		if (*A_0 != 0)
		{
			global::<Module>.std._Container_base0._Orphan_all(A_0);
			global::<Module>.delete(*A_0);
			*A_0 = 0;
			*(A_0 + 4) = 0;
			*(A_0 + 8) = 0;
		}
	}

	// Token: 0x06000032 RID: 50 RVA: 0x0000197C File Offset: 0x00000D7C
	internal unsafe static global::std.allocator<int>* {ctor}(global::std.allocator<int>* A_0)
	{
		return A_0;
	}

	// Token: 0x06000033 RID: 51 RVA: 0x000029C0 File Offset: 0x00001DC0
	internal unsafe static global::std._Vector_alloc<0,std::_Vec_base_types<int,std::allocator<int>\u0020>\u0020>* {ctor}(global::std._Vector_alloc<0,std::_Vec_base_types<int,std::allocator<int>\u0020>\u0020>* A_0, global::std.allocator<int>* A_0)
	{
		*A_0 = 0;
		*(A_0 + 4) = 0;
		*(A_0 + 8) = 0;
		return A_0;
	}

	// Token: 0x06000034 RID: 52 RVA: 0x0000411C File Offset: 0x0000351C
	internal unsafe static void _Tidy(global::std.vector<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T,std::allocator<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T>\u0020>* A_0)
	{
		if (*A_0 != 0)
		{
			global::<Module>.std._Container_base0._Orphan_all(A_0);
			global::<Module>.delete(*A_0);
			*A_0 = 0;
			*(A_0 + 4) = 0;
			*(A_0 + 8) = 0;
		}
	}

	// Token: 0x06000035 RID: 53 RVA: 0x0000198C File Offset: 0x00000D8C
	internal unsafe static global::std.allocator<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T>* {ctor}(global::std.allocator<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T>* A_0)
	{
		return A_0;
	}

	// Token: 0x06000036 RID: 54 RVA: 0x000029DC File Offset: 0x00001DDC
	internal unsafe static global::std._Vector_alloc<0,std::_Vec_base_types<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T,std::allocator<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T>\u0020>\u0020>* {ctor}(global::std._Vector_alloc<0,std::_Vec_base_types<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T,std::allocator<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T>\u0020>\u0020>* A_0, global::std.allocator<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T>* A_0)
	{
		*A_0 = 0;
		*(A_0 + 4) = 0;
		*(A_0 + 8) = 0;
		return A_0;
	}

	// Token: 0x06000037 RID: 55 RVA: 0x00003CA0 File Offset: 0x000030A0
	internal unsafe static void _Destroy(global::std.vector<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T,std::allocator<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T>\u0020>* A_0, global::FDISystem.CP_FORMAT_TYPE_V2.CODEPLUG_MAP_T* _First, global::FDISystem.CP_FORMAT_TYPE_V2.CODEPLUG_MAP_T* _Last)
	{
	}

	// Token: 0x06000038 RID: 56 RVA: 0x000029F8 File Offset: 0x00001DF8
	internal unsafe static global::std._Wrap_alloc<std::allocator<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T>\u0020>* _Getal(global::std._Vector_alloc<0,std::_Vec_base_types<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T,std::allocator<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T>\u0020>\u0020>* A_0, global::std._Wrap_alloc<std::allocator<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T>\u0020>* A_1)
	{
		return A_1;
	}

	// Token: 0x06000039 RID: 57 RVA: 0x00002A08 File Offset: 0x00001E08
	internal unsafe static void deallocate(global::std._Wrap_alloc<std::allocator<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T>\u0020>* A_0, global::FDISystem.CP_FORMAT_TYPE_V2.CODEPLUG_MAP_T* _Ptr, uint _Count)
	{
		global::<Module>.delete((void*)_Ptr);
	}

	// Token: 0x0600003A RID: 58 RVA: 0x0000199C File Offset: 0x00000D9C
	internal unsafe static global::std._Vector_val<std::_Simple_types<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T>\u0020>* {ctor}(global::std._Vector_val<std::_Simple_types<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T>\u0020>* A_0)
	{
		*A_0 = 0;
		*(A_0 + 4) = 0;
		*(A_0 + 8) = 0;
		return A_0;
	}

	// Token: 0x0600003B RID: 59 RVA: 0x00003300 File Offset: 0x00002700
	internal unsafe static void _Destroy(global::std.vector<int,std::allocator<int>\u0020>* A_0, int* _First, int* _Last)
	{
	}

	// Token: 0x0600003C RID: 60 RVA: 0x00002A1C File Offset: 0x00001E1C
	internal unsafe static global::std._Wrap_alloc<std::allocator<int>\u0020>* _Getal(global::std._Vector_alloc<0,std::_Vec_base_types<int,std::allocator<int>\u0020>\u0020>* A_0, global::std._Wrap_alloc<std::allocator<int>\u0020>* A_1)
	{
		return A_1;
	}

	// Token: 0x0600003D RID: 61 RVA: 0x00002A2C File Offset: 0x00001E2C
	internal unsafe static void deallocate(global::std._Wrap_alloc<std::allocator<int>\u0020>* A_0, int* _Ptr, uint _Count)
	{
		global::<Module>.delete((void*)_Ptr);
	}

	// Token: 0x0600003E RID: 62 RVA: 0x000019B8 File Offset: 0x00000DB8
	internal unsafe static global::std._Vector_val<std::_Simple_types<int>\u0020>* {ctor}(global::std._Vector_val<std::_Simple_types<int>\u0020>* A_0)
	{
		*A_0 = 0;
		*(A_0 + 4) = 0;
		*(A_0 + 8) = 0;
		return A_0;
	}

	// Token: 0x0600003F RID: 63 RVA: 0x00003CB0 File Offset: 0x000030B0
	internal unsafe static void _Destroy(global::std.vector<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T,std::allocator<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T>\u0020>* A_0, global::FDISystem.CP_FORMAT_TYPE_V5.CODEPLUG_MAP_T* _First, global::FDISystem.CP_FORMAT_TYPE_V5.CODEPLUG_MAP_T* _Last)
	{
	}

	// Token: 0x06000040 RID: 64 RVA: 0x00002A40 File Offset: 0x00001E40
	internal unsafe static global::std._Wrap_alloc<std::allocator<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T>\u0020>* _Getal(global::std._Vector_alloc<0,std::_Vec_base_types<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T,std::allocator<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T>\u0020>\u0020>* A_0, global::std._Wrap_alloc<std::allocator<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T>\u0020>* A_1)
	{
		return A_1;
	}

	// Token: 0x06000041 RID: 65 RVA: 0x00002A50 File Offset: 0x00001E50
	internal unsafe static void deallocate(global::std._Wrap_alloc<std::allocator<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T>\u0020>* A_0, global::FDISystem.CP_FORMAT_TYPE_V5.CODEPLUG_MAP_T* _Ptr, uint _Count)
	{
		global::<Module>.delete((void*)_Ptr);
	}

	// Token: 0x06000042 RID: 66 RVA: 0x000019D4 File Offset: 0x00000DD4
	internal unsafe static global::std._Vector_val<std::_Simple_types<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T>\u0020>* {ctor}(global::std._Vector_val<std::_Simple_types<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T>\u0020>* A_0)
	{
		*A_0 = 0;
		*(A_0 + 4) = 0;
		*(A_0 + 8) = 0;
		return A_0;
	}

	// Token: 0x06000043 RID: 67 RVA: 0x000019F0 File Offset: 0x00000DF0
	internal unsafe static void deallocate(global::std.allocator<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T>* A_0, global::FDISystem.CP_FORMAT_TYPE_V2.CODEPLUG_MAP_T* _Ptr, uint __unnamed001)
	{
		global::<Module>.delete((void*)_Ptr);
	}

	// Token: 0x06000044 RID: 68 RVA: 0x00001A04 File Offset: 0x00000E04
	internal unsafe static global::std._Wrap_alloc<std::allocator<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T>\u0020>* {ctor}(global::std._Wrap_alloc<std::allocator<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T>\u0020>* A_0)
	{
		return A_0;
	}

	// Token: 0x06000045 RID: 69 RVA: 0x00001A14 File Offset: 0x00000E14
	internal unsafe static void deallocate(global::std.allocator<int>* A_0, int* _Ptr, uint __unnamed001)
	{
		global::<Module>.delete((void*)_Ptr);
	}

	// Token: 0x06000046 RID: 70 RVA: 0x00001A28 File Offset: 0x00000E28
	internal unsafe static global::std._Wrap_alloc<std::allocator<int>\u0020>* {ctor}(global::std._Wrap_alloc<std::allocator<int>\u0020>* A_0)
	{
		return A_0;
	}

	// Token: 0x06000047 RID: 71 RVA: 0x00001A38 File Offset: 0x00000E38
	internal unsafe static void deallocate(global::std.allocator<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T>* A_0, global::FDISystem.CP_FORMAT_TYPE_V5.CODEPLUG_MAP_T* _Ptr, uint __unnamed001)
	{
		global::<Module>.delete((void*)_Ptr);
	}

	// Token: 0x06000048 RID: 72 RVA: 0x00001A4C File Offset: 0x00000E4C
	internal unsafe static global::std._Wrap_alloc<std::allocator<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T>\u0020>* {ctor}(global::std._Wrap_alloc<std::allocator<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T>\u0020>* A_0)
	{
		return A_0;
	}

	// Token: 0x06000049 RID: 73 RVA: 0x00004148 File Offset: 0x00003548
	internal static ushort ReverseBytes<unsigned\u0020short>(ushort var)
	{
		return global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,unsigned\u0020short>(var, var);
	}

	// Token: 0x0600004A RID: 74 RVA: 0x00003CC0 File Offset: 0x000030C0
	internal unsafe static ushort ReverseBytes<unsigned\u0020short,unsigned\u0020int>(ushort destVar, uint srcVar)
	{
		ushort result = (ushort)srcVar;
		byte* ptr = ref result + 2;
		byte* ptr2 = (byte*)(&result);
		do
		{
			ptr--;
			if (ptr2 == ptr)
			{
				break;
			}
			byte b = *ptr2;
			*ptr2 = *ptr;
			*ptr = b;
			ptr2++;
		}
		while (ptr2 != ptr);
		return result;
	}

	// Token: 0x0600004B RID: 75 RVA: 0x00003CF4 File Offset: 0x000030F4
	internal unsafe static byte ReverseBytes<unsigned\u0020char,int>(byte destVar, int srcVar)
	{
		byte result = (byte)srcVar;
		byte* ptr = ref result + 1;
		byte* ptr2 = &result;
		do
		{
			ptr--;
			if (ptr2 == ptr)
			{
				break;
			}
			byte b = *ptr2;
			*ptr2 = *ptr;
			*ptr = b;
			ptr2++;
		}
		while (ptr2 != ptr);
		return result;
	}

	// Token: 0x0600004C RID: 76 RVA: 0x00004DB0 File Offset: 0x000041B0
	[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
	internal unsafe static bool IsValid(global::FDISystem.FDIBlockInfo<FDISystem::FDI_TYPE_V2>* A_0, global::FDISystem.ByteOrder byteOrder)
	{
		ushort num = *(A_0 + 14);
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
		return num3 == 61680;
	}

	// Token: 0x0600004D RID: 77 RVA: 0x00004DE0 File Offset: 0x000041E0
	[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
	internal unsafe static bool IsWrite(global::FDISystem.FDIBlockInfo<FDISystem::FDI_TYPE_V2>* A_0, global::FDISystem.ByteOrder byteOrder)
	{
		byte b = *(A_0 + 8);
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
		return b3 == 240;
	}

	// Token: 0x0600004E RID: 78 RVA: 0x00004E0C File Offset: 0x0000420C
	[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
	internal unsafe static bool IsUpdating(global::FDISystem.FDIBlockInfo<FDISystem::FDI_TYPE_V2>* A_0, global::FDISystem.ByteOrder byteOrder)
	{
		byte b = *(A_0 + 8);
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
		return b3 == 248;
	}

	// Token: 0x0600004F RID: 79 RVA: 0x00004E38 File Offset: 0x00004238
	[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
	internal unsafe static bool IsErasing(global::FDISystem.FDIBlockInfo<FDISystem::FDI_TYPE_V2>* A_0, global::FDISystem.ByteOrder byteOrder)
	{
		byte b = *(A_0 + 8);
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
		return b3 == 252;
	}

	// Token: 0x06000050 RID: 80 RVA: 0x00004E64 File Offset: 0x00004264
	[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
	internal unsafe static bool IsRecover(global::FDISystem.FDIBlockInfo<FDISystem::FDI_TYPE_V2>* A_0, global::FDISystem.ByteOrder byteOrder)
	{
		byte b = *(A_0 + 8);
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
		return b3 == 254;
	}

	// Token: 0x06000051 RID: 81 RVA: 0x000054A4 File Offset: 0x000048A4
	[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
	internal unsafe static bool IsValid(global::FDISystem.FDIBlockInfo<FDISystem::FDI_TYPE_V5>* A_0, global::FDISystem.ByteOrder byteOrder)
	{
		ushort num = *(A_0 + 12);
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
		return num3 == 61680;
	}

	// Token: 0x06000052 RID: 82 RVA: 0x000054D4 File Offset: 0x000048D4
	[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
	internal unsafe static bool IsWrite(global::FDISystem.FDIBlockInfo<FDISystem::FDI_TYPE_V5>* A_0, global::FDISystem.ByteOrder byteOrder)
	{
		byte b = *(A_0 + 14);
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
		return b3 == 0;
	}

	// Token: 0x06000053 RID: 83 RVA: 0x00005500 File Offset: 0x00004900
	[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
	internal unsafe static bool IsUpdating(global::FDISystem.FDIBlockInfo<FDISystem::FDI_TYPE_V5>* A_0, global::FDISystem.ByteOrder byteOrder)
	{
		byte b = *(A_0 + 14);
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
		return b3 == 192;
	}

	// Token: 0x06000054 RID: 84 RVA: 0x00005530 File Offset: 0x00004930
	[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
	internal unsafe static bool IsErasing(global::FDISystem.FDIBlockInfo<FDISystem::FDI_TYPE_V5>* A_0, global::FDISystem.ByteOrder byteOrder)
	{
		byte b = *(A_0 + 14);
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
		return b3 == 240;
	}

	// Token: 0x06000055 RID: 85 RVA: 0x00005560 File Offset: 0x00004960
	[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
	internal unsafe static bool IsRecover(global::FDISystem.FDIBlockInfo<FDISystem::FDI_TYPE_V5>* A_0, global::FDISystem.ByteOrder byteOrder)
	{
		byte b = *(A_0 + 14);
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
		return b3 == 252;
	}

	// Token: 0x06000056 RID: 86 RVA: 0x00003990 File Offset: 0x00002D90
	internal unsafe static void _Destroy_range<struct\u0020std::_Wrap_alloc<class\u0020std::allocator<struct\u0020FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T>\u0020>\u0020>(global::FDISystem.CP_FORMAT_TYPE_V2.CODEPLUG_MAP_T* _First, global::FDISystem.CP_FORMAT_TYPE_V2.CODEPLUG_MAP_T* _Last, global::std._Wrap_alloc<std::allocator<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T>\u0020>* _Al)
	{
	}

	// Token: 0x06000057 RID: 87 RVA: 0x00002F24 File Offset: 0x00002324
	internal unsafe static void _Destroy_range<struct\u0020std::_Wrap_alloc<class\u0020std::allocator<int>\u0020>\u0020>(int* _First, int* _Last, global::std._Wrap_alloc<std::allocator<int>\u0020>* _Al)
	{
	}

	// Token: 0x06000058 RID: 88 RVA: 0x000039A0 File Offset: 0x00002DA0
	internal unsafe static void _Destroy_range<struct\u0020std::_Wrap_alloc<class\u0020std::allocator<struct\u0020FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T>\u0020>\u0020>(global::FDISystem.CP_FORMAT_TYPE_V5.CODEPLUG_MAP_T* _First, global::FDISystem.CP_FORMAT_TYPE_V5.CODEPLUG_MAP_T* _Last, global::std._Wrap_alloc<std::allocator<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T>\u0020>* _Al)
	{
	}

	// Token: 0x06000059 RID: 89 RVA: 0x0000717C File Offset: 0x0000657C
	internal unsafe static void reserve(global::std.vector<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T,std::allocator<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T>\u0020>* A_0, uint _Count)
	{
		if (*(A_0 + 8) - *A_0 >> 3 < (int)_Count)
		{
			if (536870911U < _Count)
			{
				global::<Module>.std._Xlength_error((sbyte*)(&global::<Module>.??_C@_0BD@OLBABOEK@vector?$DMT?$DO?5too?5long?$AA@));
			}
			global::<Module>.std.vector<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T,std::allocator<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T>\u0020>._Reallocate(A_0, _Count);
		}
	}

	// Token: 0x0600005A RID: 90 RVA: 0x00001B5C File Offset: 0x00000F5C
	internal unsafe static uint size(global::std.vector<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T,std::allocator<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T>\u0020>* A_0)
	{
		return *(A_0 + 4) - *A_0 >> 3;
	}

	// Token: 0x0600005B RID: 91 RVA: 0x00001B74 File Offset: 0x00000F74
	internal unsafe static global::FDISystem.CP_FORMAT_TYPE_V2.CODEPLUG_MAP_T* [](global::std.vector<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T,std::allocator<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T>\u0020>* A_0, uint _Pos)
	{
		return _Pos * 8U + (uint)(*A_0);
	}

	// Token: 0x0600005C RID: 92 RVA: 0x000071B0 File Offset: 0x000065B0
	internal unsafe static void push_back(global::std.vector<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T,std::allocator<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T>\u0020>* A_0, global::FDISystem.CP_FORMAT_TYPE_V2.CODEPLUG_MAP_T* _Val)
	{
		uint num = (uint)(*(A_0 + 4));
		int num2;
		if (_Val < num && *A_0 <= _Val)
		{
			num2 = 1;
		}
		else
		{
			num2 = 0;
		}
		if ((byte)num2 != 0)
		{
			global::FDISystem.CP_FORMAT_TYPE_V2.CODEPLUG_MAP_T* ptr = _Val - *A_0 >> 3;
			if (num == (uint)(*(A_0 + 8)))
			{
				global::<Module>.std.vector<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T,std::allocator<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T>\u0020>._Reserve(A_0, 1U);
			}
			global::FDISystem.CP_FORMAT_TYPE_V2.CODEPLUG_MAP_T* ptr2 = ptr * 8 + *A_0;
			global::FDISystem.CP_FORMAT_TYPE_V2.CODEPLUG_MAP_T* ptr3 = *(A_0 + 4);
			global::FDISystem.CP_FORMAT_TYPE_V2.CODEPLUG_MAP_T* a_ = ptr3;
			try
			{
				if (ptr3 != null)
				{
					cpblk(ptr3, ptr2, 8);
				}
			}
			catch
			{
				global::<Module>.delete((void*)a_, (void*)ptr3);
				throw;
			}
			*(A_0 + 4) = *(A_0 + 4) + 8;
		}
		else
		{
			if (num == (uint)(*(A_0 + 8)))
			{
				global::<Module>.std.vector<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T,std::allocator<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T>\u0020>._Reserve(A_0, 1U);
			}
			global::FDISystem.CP_FORMAT_TYPE_V2.CODEPLUG_MAP_T* ptr4 = *(A_0 + 4);
			if (ptr4 != null)
			{
				cpblk(ptr4, _Val, 8);
			}
			*(A_0 + 4) = *(A_0 + 4) + 8;
		}
	}

	// Token: 0x0600005D RID: 93 RVA: 0x00003D28 File Offset: 0x00003128
	internal unsafe static void clear(global::std.vector<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T,std::allocator<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T>\u0020>* A_0)
	{
		global::<Module>.std._Container_base0._Orphan_all(A_0);
		*(A_0 + 4) = *A_0;
	}

	// Token: 0x0600005E RID: 94 RVA: 0x00003D44 File Offset: 0x00003144
	internal unsafe static void push_back(global::std.vector<int,std::allocator<int>\u0020>* A_0, int* _Val)
	{
		uint num = (uint)(*(A_0 + 4));
		int num2;
		if (_Val < num && *A_0 <= _Val)
		{
			num2 = 1;
		}
		else
		{
			num2 = 0;
		}
		if ((byte)num2 != 0)
		{
			int* ptr = _Val - *A_0 >> 2;
			if (num == (uint)(*(A_0 + 8)))
			{
				global::<Module>.std.vector<int,std::allocator<int>\u0020>._Reserve(A_0, 1U);
			}
			int* ptr2 = ptr * 4 + *A_0;
			int* ptr3 = *(A_0 + 4);
			int* a_ = ptr3;
			try
			{
				if (ptr3 != null)
				{
					*ptr3 = *ptr2;
				}
			}
			catch
			{
				global::<Module>.delete((void*)a_, (void*)ptr3);
				throw;
			}
			*(A_0 + 4) = *(A_0 + 4) + 4;
		}
		else
		{
			if (num == (uint)(*(A_0 + 8)))
			{
				global::<Module>.std.vector<int,std::allocator<int>\u0020>._Reserve(A_0, 1U);
			}
			int* ptr4 = *(A_0 + 4);
			int* a_2 = ptr4;
			try
			{
				if (ptr4 != null)
				{
					*ptr4 = *_Val;
				}
			}
			catch
			{
				global::<Module>.delete((void*)a_2, (void*)ptr4);
				throw;
			}
			*(A_0 + 4) = *(A_0 + 4) + 4;
		}
	}

	// Token: 0x0600005F RID: 95 RVA: 0x00003E18 File Offset: 0x00003218
	internal unsafe static void reserve(global::std.vector<int,std::allocator<int>\u0020>* A_0, uint _Count)
	{
		if (*(A_0 + 8) - *A_0 >> 2 < (int)_Count)
		{
			if (1073741823U < _Count)
			{
				global::<Module>.std._Xlength_error((sbyte*)(&global::<Module>.??_C@_0BD@OLBABOEK@vector?$DMT?$DO?5too?5long?$AA@));
			}
			global::<Module>.std.vector<int,std::allocator<int>\u0020>._Reallocate(A_0, _Count);
		}
	}

	// Token: 0x06000060 RID: 96 RVA: 0x00001B88 File Offset: 0x00000F88
	internal unsafe static uint size(global::std.vector<int,std::allocator<int>\u0020>* A_0)
	{
		return *(A_0 + 4) - *A_0 >> 2;
	}

	// Token: 0x06000061 RID: 97 RVA: 0x00001BA0 File Offset: 0x00000FA0
	internal unsafe static int* [](global::std.vector<int,std::allocator<int>\u0020>* A_0, uint _Pos)
	{
		return _Pos * 4U + (uint)(*A_0);
	}

	// Token: 0x06000062 RID: 98 RVA: 0x00003310 File Offset: 0x00002710
	internal unsafe static void clear(global::std.vector<int,std::allocator<int>\u0020>* A_0)
	{
		global::<Module>.std._Container_base0._Orphan_all(A_0);
		*(A_0 + 4) = *A_0;
	}

	// Token: 0x06000063 RID: 99 RVA: 0x00007264 File Offset: 0x00006664
	internal unsafe static void reserve(global::std.vector<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T,std::allocator<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T>\u0020>* A_0, uint _Count)
	{
		if ((*(A_0 + 8) - *A_0) / 12 < (int)_Count)
		{
			if (357913941U < _Count)
			{
				global::<Module>.std._Xlength_error((sbyte*)(&global::<Module>.??_C@_0BD@OLBABOEK@vector?$DMT?$DO?5too?5long?$AA@));
			}
			global::<Module>.std.vector<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T,std::allocator<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T>\u0020>._Reallocate(A_0, _Count);
		}
	}

	// Token: 0x06000064 RID: 100 RVA: 0x00001BB4 File Offset: 0x00000FB4
	internal unsafe static uint size(global::std.vector<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T,std::allocator<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T>\u0020>* A_0)
	{
		return (*(A_0 + 4) - *A_0) / 12;
	}

	// Token: 0x06000065 RID: 101 RVA: 0x00001BCC File Offset: 0x00000FCC
	internal unsafe static global::FDISystem.CP_FORMAT_TYPE_V5.CODEPLUG_MAP_T* [](global::std.vector<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T,std::allocator<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T>\u0020>* A_0, uint _Pos)
	{
		return _Pos * 12U + (uint)(*A_0);
	}

	// Token: 0x06000066 RID: 102 RVA: 0x00007298 File Offset: 0x00006698
	internal unsafe static void push_back(global::std.vector<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T,std::allocator<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T>\u0020>* A_0, global::FDISystem.CP_FORMAT_TYPE_V5.CODEPLUG_MAP_T* _Val)
	{
		uint num = (uint)(*(A_0 + 4));
		int num2;
		if (_Val < num && *A_0 <= _Val)
		{
			num2 = 1;
		}
		else
		{
			num2 = 0;
		}
		if ((byte)num2 != 0)
		{
			global::FDISystem.CP_FORMAT_TYPE_V5.CODEPLUG_MAP_T* ptr = (_Val - *A_0) / 12;
			if (num == (uint)(*(A_0 + 8)))
			{
				global::<Module>.std.vector<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T,std::allocator<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T>\u0020>._Reserve(A_0, 1U);
			}
			global::FDISystem.CP_FORMAT_TYPE_V5.CODEPLUG_MAP_T* ptr2 = ptr * 12 + *A_0;
			global::FDISystem.CP_FORMAT_TYPE_V5.CODEPLUG_MAP_T* ptr3 = *(A_0 + 4);
			global::FDISystem.CP_FORMAT_TYPE_V5.CODEPLUG_MAP_T* a_ = ptr3;
			try
			{
				if (ptr3 != null)
				{
					cpblk(ptr3, ptr2, 12);
				}
			}
			catch
			{
				global::<Module>.delete((void*)a_, (void*)ptr3);
				throw;
			}
			*(A_0 + 4) = *(A_0 + 4) + 12;
		}
		else
		{
			if (num == (uint)(*(A_0 + 8)))
			{
				global::<Module>.std.vector<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T,std::allocator<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T>\u0020>._Reserve(A_0, 1U);
			}
			global::FDISystem.CP_FORMAT_TYPE_V5.CODEPLUG_MAP_T* ptr4 = *(A_0 + 4);
			if (ptr4 != null)
			{
				cpblk(ptr4, _Val, 12);
			}
			*(A_0 + 4) = *(A_0 + 4) + 12;
		}
	}

	// Token: 0x06000067 RID: 103 RVA: 0x00003E4C File Offset: 0x0000324C
	internal unsafe static void clear(global::std.vector<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T,std::allocator<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T>\u0020>* A_0)
	{
		global::<Module>.std._Container_base0._Orphan_all(A_0);
		*(A_0 + 4) = *A_0;
	}

	// Token: 0x06000068 RID: 104 RVA: 0x00001BE0 File Offset: 0x00000FE0
	internal unsafe static global::std.auto_ptr<unsigned\u0020char>* {ctor}(global::std.auto_ptr<unsigned\u0020char>* A_0, byte* _Ptr)
	{
		*A_0 = _Ptr;
		return A_0;
	}

	// Token: 0x06000069 RID: 105 RVA: 0x00001BF4 File Offset: 0x00000FF4
	internal unsafe static void {dtor}(global::std.auto_ptr<unsigned\u0020char>* A_0)
	{
		global::<Module>.delete(*A_0);
	}

	// Token: 0x0600006A RID: 106 RVA: 0x00001C08 File Offset: 0x00001008
	internal unsafe static byte* get(global::std.auto_ptr<unsigned\u0020char>* A_0)
	{
		return *A_0;
	}

	// Token: 0x0600006B RID: 107 RVA: 0x00001C18 File Offset: 0x00001018
	internal unsafe static uint capacity(global::std.vector<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T,std::allocator<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T>\u0020>* A_0)
	{
		return *(A_0 + 8) - *A_0 >> 3;
	}

	// Token: 0x0600006C RID: 108 RVA: 0x00003600 File Offset: 0x00002A00
	internal unsafe static uint max_size(global::std.vector<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T,std::allocator<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T>\u0020>* A_0)
	{
		return 536870911;
	}

	// Token: 0x0600006D RID: 109 RVA: 0x00001C30 File Offset: 0x00001030
	[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
	internal unsafe static bool _Inside(global::std.vector<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T,std::allocator<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T>\u0020>* A_0, global::FDISystem.CP_FORMAT_TYPE_V2.CODEPLUG_MAP_T* _Ptr)
	{
		int num;
		if (_Ptr < *(A_0 + 4) && *A_0 <= _Ptr)
		{
			num = 1;
		}
		else
		{
			num = 0;
		}
		return (byte)num;
	}

	// Token: 0x0600006E RID: 110 RVA: 0x0000573C File Offset: 0x00004B3C
	internal unsafe static void _Reallocate(global::std.vector<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T,std::allocator<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T>\u0020>* A_0, uint _Count)
	{
		int num = (int)stackalloc byte[global::<Module>.__CxxQueryExceptionSize()];
		void* ptr = null;
		if (_Count != 0U)
		{
			if (536870911U >= _Count)
			{
				ptr = global::<Module>.@new(_Count << 3);
				if (ptr != null)
				{
					goto IL_27;
				}
			}
			global::<Module>.std._Xbad_alloc();
			return;
		}
		IL_27:
		uint exceptionCode;
		try
		{
			global::FDISystem.CP_FORMAT_TYPE_V2.CODEPLUG_MAP_T* last = *(A_0 + 4);
			global::FDISystem.CP_FORMAT_TYPE_V2.CODEPLUG_MAP_T* first = *A_0;
			global::std._Nonscalar_ptr_iterator_tag nonscalar_ptr_iterator_tag;
			global::std._Nonscalar_ptr_iterator_tag _unnamed = nonscalar_ptr_iterator_tag;
			global::std._Wrap_alloc<std::allocator<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T>\u0020> wrap_alloc<std::allocator<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T>_u0020>;
			global::FDISystem.CP_FORMAT_TYPE_V2.CODEPLUG_MAP_T* ptr2 = global::<Module>.std._Uninit_move<struct\u0020FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T\u0020*,struct\u0020FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T\u0020*,class\u0020std::allocator<struct\u0020FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T>,struct\u0020FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T>(first, last, (global::FDISystem.CP_FORMAT_TYPE_V2.CODEPLUG_MAP_T*)ptr, ref wrap_alloc<std::allocator<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T>_u0020>, null, _unnamed);
		}
		catch when (delegate
		{
			// Failed to create a 'catch-when' expression
			exceptionCode = (uint)global::System.Runtime.InteropServices.Marshal.GetExceptionCode();
			endfilter(global::<Module>.__CxxExceptionFilter(global::System.Runtime.InteropServices.Marshal.GetExceptionPointers(), null, 0, null) != null);
		})
		{
			uint num2 = 0U;
			global::<Module>.__CxxRegisterExceptionObject(global::System.Runtime.InteropServices.Marshal.GetExceptionPointers(), num);
			try
			{
				try
				{
					global::<Module>.delete(ptr);
					global::<Module>._CxxThrowException(null, null);
				}
				catch when (delegate
				{
					// Failed to create a 'catch-when' expression
					num2 = global::<Module>.__CxxDetectRethrow(global::System.Runtime.InteropServices.Marshal.GetExceptionPointers());
					endfilter(num2 != 0U);
				})
				{
				}
				if (num2 != 0U)
				{
					throw;
				}
			}
			finally
			{
				global::<Module>.__CxxUnregisterExceptionObject(num, (int)num2);
			}
		}
		int num3 = *A_0;
		uint num4 = (uint)(*(A_0 + 4) - num3 >> 3);
		if (num3 != 0)
		{
			global::<Module>.delete(num3);
		}
		global::<Module>.std._Container_base0._Orphan_all(A_0);
		*(A_0 + 8) = _Count * 8U + (byte*)ptr;
		*(A_0 + 4) = num4 * 8U + (byte*)ptr;
		*A_0 = ptr;
	}

	// Token: 0x0600006F RID: 111 RVA: 0x00005874 File Offset: 0x00004C74
	internal unsafe static void _Reserve(global::std.vector<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T,std::allocator<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T>\u0020>* A_0, uint _Count)
	{
		int num = *(A_0 + 8);
		int num2 = *(A_0 + 4);
		if (num - num2 >> 3 < (int)_Count)
		{
			int num3 = *A_0;
			int num4 = num2 - num3 >> 3;
			if (536870911 - num4 < (int)_Count)
			{
				global::<Module>.std._Xlength_error((sbyte*)(&global::<Module>.??_C@_0BD@OLBABOEK@vector?$DMT?$DO?5too?5long?$AA@));
			}
			uint num5 = (uint)(num4 + (int)_Count);
			uint num6 = (uint)(num - num3 >> 3);
			uint num7 = num6 >> 1;
			uint num8;
			if (536870911U - num7 < num6)
			{
				num8 = 0U;
			}
			else
			{
				num8 = num7 + num6;
			}
			uint num9 = num8;
			num9 = ((num8 < num5) ? num5 : num9);
			global::<Module>.std.vector<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T,std::allocator<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T>\u0020>._Reallocate(A_0, num9);
		}
	}

	// Token: 0x06000070 RID: 112 RVA: 0x00001C54 File Offset: 0x00001054
	internal unsafe static void _Xlen(global::std.vector<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T,std::allocator<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T>\u0020>* A_0)
	{
		global::<Module>.std._Xlength_error((sbyte*)(&global::<Module>.??_C@_0BD@OLBABOEK@vector?$DMT?$DO?5too?5long?$AA@));
	}

	// Token: 0x06000071 RID: 113 RVA: 0x00001C6C File Offset: 0x0000106C
	internal unsafe static void _Orphan_range(global::std.vector<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T,std::allocator<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T>\u0020>* A_0, global::FDISystem.CP_FORMAT_TYPE_V2.CODEPLUG_MAP_T* A_0, global::FDISystem.CP_FORMAT_TYPE_V2.CODEPLUG_MAP_T* A_1)
	{
	}

	// Token: 0x06000072 RID: 114 RVA: 0x00001C7C File Offset: 0x0000107C
	internal unsafe static uint capacity(global::std.vector<int,std::allocator<int>\u0020>* A_0)
	{
		return *(A_0 + 8) - *A_0 >> 2;
	}

	// Token: 0x06000073 RID: 115 RVA: 0x00003614 File Offset: 0x00002A14
	internal unsafe static uint max_size(global::std.vector<int,std::allocator<int>\u0020>* A_0)
	{
		return 1073741823;
	}

	// Token: 0x06000074 RID: 116 RVA: 0x00001C94 File Offset: 0x00001094
	[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
	internal unsafe static bool _Inside(global::std.vector<int,std::allocator<int>\u0020>* A_0, int* _Ptr)
	{
		int num;
		if (_Ptr < *(A_0 + 4) && *A_0 <= _Ptr)
		{
			num = 1;
		}
		else
		{
			num = 0;
		}
		return (byte)num;
	}

	// Token: 0x06000075 RID: 117 RVA: 0x000039B0 File Offset: 0x00002DB0
	internal unsafe static void _Reallocate(global::std.vector<int,std::allocator<int>\u0020>* A_0, uint _Count)
	{
		int num = (int)stackalloc byte[global::<Module>.__CxxQueryExceptionSize()];
		void* ptr = null;
		if (_Count != 0U)
		{
			if (1073741823U >= _Count)
			{
				ptr = global::<Module>.@new(_Count << 2);
				if (ptr != null)
				{
					goto IL_27;
				}
			}
			global::<Module>.std._Xbad_alloc();
			return;
		}
		IL_27:
		uint exceptionCode;
		try
		{
			int* last = *(A_0 + 4);
			int* first = *A_0;
			global::std._Scalar_ptr_iterator_tag scalar_ptr_iterator_tag;
			global::std._Scalar_ptr_iterator_tag _unnamed = scalar_ptr_iterator_tag;
			global::std._Wrap_alloc<std::allocator<int>\u0020> wrap_alloc<std::allocator<int>_u0020>;
			int* ptr2 = global::<Module>.std._Uninit_move<int,int,int>(first, last, (int*)ptr, ref wrap_alloc<std::allocator<int>_u0020>, null, _unnamed);
		}
		catch when (delegate
		{
			// Failed to create a 'catch-when' expression
			exceptionCode = (uint)global::System.Runtime.InteropServices.Marshal.GetExceptionCode();
			endfilter(global::<Module>.__CxxExceptionFilter(global::System.Runtime.InteropServices.Marshal.GetExceptionPointers(), null, 0, null) != null);
		})
		{
			uint num2 = 0U;
			global::<Module>.__CxxRegisterExceptionObject(global::System.Runtime.InteropServices.Marshal.GetExceptionPointers(), num);
			try
			{
				try
				{
					global::<Module>.delete(ptr);
					global::<Module>._CxxThrowException(null, null);
				}
				catch when (delegate
				{
					// Failed to create a 'catch-when' expression
					num2 = global::<Module>.__CxxDetectRethrow(global::System.Runtime.InteropServices.Marshal.GetExceptionPointers());
					endfilter(num2 != 0U);
				})
				{
				}
				if (num2 != 0U)
				{
					throw;
				}
			}
			finally
			{
				global::<Module>.__CxxUnregisterExceptionObject(num, (int)num2);
			}
		}
		int num3 = *A_0;
		uint num4 = (uint)(*(A_0 + 4) - num3 >> 2);
		if (num3 != 0)
		{
			global::<Module>.delete(num3);
		}
		global::<Module>.std._Container_base0._Orphan_all(A_0);
		*(A_0 + 8) = _Count * 4U + (byte*)ptr;
		*(A_0 + 4) = num4 * 4U + (byte*)ptr;
		*A_0 = ptr;
	}

	// Token: 0x06000076 RID: 118 RVA: 0x00003AE8 File Offset: 0x00002EE8
	internal unsafe static void _Reserve(global::std.vector<int,std::allocator<int>\u0020>* A_0, uint _Count)
	{
		int num = *(A_0 + 8);
		int num2 = *(A_0 + 4);
		if (num - num2 >> 2 < (int)_Count)
		{
			int num3 = *A_0;
			int num4 = num2 - num3 >> 2;
			if (1073741823 - num4 < (int)_Count)
			{
				global::<Module>.std._Xlength_error((sbyte*)(&global::<Module>.??_C@_0BD@OLBABOEK@vector?$DMT?$DO?5too?5long?$AA@));
			}
			uint num5 = (uint)(num4 + (int)_Count);
			uint num6 = (uint)(num - num3 >> 2);
			uint num7 = num6 >> 1;
			uint num8;
			if (1073741823U - num7 < num6)
			{
				num8 = 0U;
			}
			else
			{
				num8 = num7 + num6;
			}
			uint num9 = num8;
			num9 = ((num8 < num5) ? num5 : num9);
			global::<Module>.std.vector<int,std::allocator<int>\u0020>._Reallocate(A_0, num9);
		}
	}

	// Token: 0x06000077 RID: 119 RVA: 0x00001CB8 File Offset: 0x000010B8
	internal unsafe static void _Xlen(global::std.vector<int,std::allocator<int>\u0020>* A_0)
	{
		global::<Module>.std._Xlength_error((sbyte*)(&global::<Module>.??_C@_0BD@OLBABOEK@vector?$DMT?$DO?5too?5long?$AA@));
	}

	// Token: 0x06000078 RID: 120 RVA: 0x00001CD0 File Offset: 0x000010D0
	internal unsafe static void _Orphan_range(global::std.vector<int,std::allocator<int>\u0020>* A_0, int* A_0, int* A_1)
	{
	}

	// Token: 0x06000079 RID: 121 RVA: 0x00001CE0 File Offset: 0x000010E0
	internal unsafe static uint capacity(global::std.vector<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T,std::allocator<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T>\u0020>* A_0)
	{
		return (*(A_0 + 8) - *A_0) / 12;
	}

	// Token: 0x0600007A RID: 122 RVA: 0x00003628 File Offset: 0x00002A28
	internal unsafe static uint max_size(global::std.vector<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T,std::allocator<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T>\u0020>* A_0)
	{
		return 357913941;
	}

	// Token: 0x0600007B RID: 123 RVA: 0x00001CF8 File Offset: 0x000010F8
	[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
	internal unsafe static bool _Inside(global::std.vector<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T,std::allocator<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T>\u0020>* A_0, global::FDISystem.CP_FORMAT_TYPE_V5.CODEPLUG_MAP_T* _Ptr)
	{
		int num;
		if (_Ptr < *(A_0 + 4) && *A_0 <= _Ptr)
		{
			num = 1;
		}
		else
		{
			num = 0;
		}
		return (byte)num;
	}

	// Token: 0x0600007C RID: 124 RVA: 0x000058F4 File Offset: 0x00004CF4
	internal unsafe static void _Reallocate(global::std.vector<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T,std::allocator<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T>\u0020>* A_0, uint _Count)
	{
		int num = (int)stackalloc byte[global::<Module>.__CxxQueryExceptionSize()];
		void* ptr = null;
		if (_Count != 0U)
		{
			if (357913941U >= _Count)
			{
				ptr = global::<Module>.@new(_Count * 12U);
				if (ptr != null)
				{
					goto IL_28;
				}
			}
			global::<Module>.std._Xbad_alloc();
			return;
		}
		IL_28:
		uint exceptionCode;
		try
		{
			global::FDISystem.CP_FORMAT_TYPE_V5.CODEPLUG_MAP_T* last = *(A_0 + 4);
			global::FDISystem.CP_FORMAT_TYPE_V5.CODEPLUG_MAP_T* first = *A_0;
			global::std._Nonscalar_ptr_iterator_tag nonscalar_ptr_iterator_tag;
			global::std._Nonscalar_ptr_iterator_tag _unnamed = nonscalar_ptr_iterator_tag;
			global::std._Wrap_alloc<std::allocator<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T>\u0020> wrap_alloc<std::allocator<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T>_u0020>;
			global::FDISystem.CP_FORMAT_TYPE_V5.CODEPLUG_MAP_T* ptr2 = global::<Module>.std._Uninit_move<struct\u0020FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T\u0020*,struct\u0020FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T\u0020*,class\u0020std::allocator<struct\u0020FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T>,struct\u0020FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T>(first, last, (global::FDISystem.CP_FORMAT_TYPE_V5.CODEPLUG_MAP_T*)ptr, ref wrap_alloc<std::allocator<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T>_u0020>, null, _unnamed);
		}
		catch when (delegate
		{
			// Failed to create a 'catch-when' expression
			exceptionCode = (uint)global::System.Runtime.InteropServices.Marshal.GetExceptionCode();
			endfilter(global::<Module>.__CxxExceptionFilter(global::System.Runtime.InteropServices.Marshal.GetExceptionPointers(), null, 0, null) != null);
		})
		{
			uint num2 = 0U;
			global::<Module>.__CxxRegisterExceptionObject(global::System.Runtime.InteropServices.Marshal.GetExceptionPointers(), num);
			try
			{
				try
				{
					global::<Module>.delete(ptr);
					global::<Module>._CxxThrowException(null, null);
				}
				catch when (delegate
				{
					// Failed to create a 'catch-when' expression
					num2 = global::<Module>.__CxxDetectRethrow(global::System.Runtime.InteropServices.Marshal.GetExceptionPointers());
					endfilter(num2 != 0U);
				})
				{
				}
				if (num2 != 0U)
				{
					throw;
				}
			}
			finally
			{
				global::<Module>.__CxxUnregisterExceptionObject(num, (int)num2);
			}
		}
		int num3 = *A_0;
		uint num4 = (uint)((*(A_0 + 4) - num3) / 12);
		if (num3 != 0)
		{
			global::<Module>.delete(num3);
		}
		global::<Module>.std._Container_base0._Orphan_all(A_0);
		*(A_0 + 8) = _Count * 12U + (byte*)ptr;
		*(A_0 + 4) = num4 * 12U + (byte*)ptr;
		*A_0 = ptr;
	}

	// Token: 0x0600007D RID: 125 RVA: 0x00005A30 File Offset: 0x00004E30
	internal unsafe static void _Reserve(global::std.vector<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T,std::allocator<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T>\u0020>* A_0, uint _Count)
	{
		int num = *(A_0 + 8);
		int num2 = *(A_0 + 4);
		if ((num - num2) / 12 < (int)_Count)
		{
			int num3 = *A_0;
			int num4 = (num2 - num3) / 12;
			if (357913941 - num4 < (int)_Count)
			{
				global::<Module>.std._Xlength_error((sbyte*)(&global::<Module>.??_C@_0BD@OLBABOEK@vector?$DMT?$DO?5too?5long?$AA@));
			}
			uint num5 = (uint)(num4 + (int)_Count);
			uint num6 = (uint)((num - num3) / 12);
			uint num7 = num6 >> 1;
			uint num8;
			if (357913941U - num7 < num6)
			{
				num8 = 0U;
			}
			else
			{
				num8 = num7 + num6;
			}
			uint num9 = num8;
			num9 = ((num8 < num5) ? num5 : num9);
			global::<Module>.std.vector<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T,std::allocator<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T>\u0020>._Reallocate(A_0, num9);
		}
	}

	// Token: 0x0600007E RID: 126 RVA: 0x00001D1C File Offset: 0x0000111C
	internal unsafe static void _Xlen(global::std.vector<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T,std::allocator<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T>\u0020>* A_0)
	{
		global::<Module>.std._Xlength_error((sbyte*)(&global::<Module>.??_C@_0BD@OLBABOEK@vector?$DMT?$DO?5too?5long?$AA@));
	}

	// Token: 0x0600007F RID: 127 RVA: 0x00001D34 File Offset: 0x00001134
	internal unsafe static void _Orphan_range(global::std.vector<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T,std::allocator<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T>\u0020>* A_0, global::FDISystem.CP_FORMAT_TYPE_V5.CODEPLUG_MAP_T* A_0, global::FDISystem.CP_FORMAT_TYPE_V5.CODEPLUG_MAP_T* A_1)
	{
	}

	// Token: 0x06000080 RID: 128 RVA: 0x00001D44 File Offset: 0x00001144
	internal unsafe static uint _Unused_capacity(global::std.vector<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T,std::allocator<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T>\u0020>* A_0)
	{
		return *(A_0 + 8) - *(A_0 + 4) >> 3;
	}

	// Token: 0x06000081 RID: 129 RVA: 0x0000363C File Offset: 0x00002A3C
	internal unsafe static uint _Grow_to(global::std.vector<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T,std::allocator<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T>\u0020>* A_0, uint _Count)
	{
		uint num = (uint)(*(A_0 + 8) - *A_0 >> 3);
		uint num2 = num >> 1;
		uint num3;
		if (536870911U - num2 < num)
		{
			num3 = 0U;
		}
		else
		{
			num3 = num2 + num;
		}
		uint num4 = num3;
		return (num3 < _Count) ? _Count : num4;
	}

	// Token: 0x06000082 RID: 130 RVA: 0x0000332C File Offset: 0x0000272C
	internal unsafe static global::FDISystem.CP_FORMAT_TYPE_V2.CODEPLUG_MAP_T* allocate(global::std._Wrap_alloc<std::allocator<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T>\u0020>* A_0, uint _Count)
	{
		void* ptr = null;
		if (_Count != 0U)
		{
			if (536870911U >= _Count)
			{
				ptr = global::<Module>.@new(_Count << 3);
				if (ptr != null)
				{
					return ptr;
				}
			}
			global::<Module>.std._Xbad_alloc();
			return 0;
		}
		return ptr;
	}

	// Token: 0x06000083 RID: 131 RVA: 0x0000335C File Offset: 0x0000275C
	internal unsafe static uint max_size(global::std._Wrap_alloc<std::allocator<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T>\u0020>* A_0)
	{
		return 536870911;
	}

	// Token: 0x06000084 RID: 132 RVA: 0x00001D5C File Offset: 0x0000115C
	internal unsafe static uint _Unused_capacity(global::std.vector<int,std::allocator<int>\u0020>* A_0)
	{
		return *(A_0 + 8) - *(A_0 + 4) >> 2;
	}

	// Token: 0x06000085 RID: 133 RVA: 0x00003678 File Offset: 0x00002A78
	internal unsafe static uint _Grow_to(global::std.vector<int,std::allocator<int>\u0020>* A_0, uint _Count)
	{
		uint num = (uint)(*(A_0 + 8) - *A_0 >> 2);
		uint num2 = num >> 1;
		uint num3;
		if (1073741823U - num2 < num)
		{
			num3 = 0U;
		}
		else
		{
			num3 = num2 + num;
		}
		uint num4 = num3;
		return (num3 < _Count) ? _Count : num4;
	}

	// Token: 0x06000086 RID: 134 RVA: 0x00003370 File Offset: 0x00002770
	internal unsafe static int* allocate(global::std._Wrap_alloc<std::allocator<int>\u0020>* A_0, uint _Count)
	{
		void* ptr = null;
		if (_Count != 0U)
		{
			if (1073741823U >= _Count)
			{
				ptr = global::<Module>.@new(_Count << 2);
				if (ptr != null)
				{
					return ptr;
				}
			}
			global::<Module>.std._Xbad_alloc();
			return 0;
		}
		return ptr;
	}

	// Token: 0x06000087 RID: 135 RVA: 0x000033A0 File Offset: 0x000027A0
	internal unsafe static uint max_size(global::std._Wrap_alloc<std::allocator<int>\u0020>* A_0)
	{
		return 1073741823;
	}

	// Token: 0x06000088 RID: 136 RVA: 0x00001D74 File Offset: 0x00001174
	internal unsafe static uint _Unused_capacity(global::std.vector<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T,std::allocator<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T>\u0020>* A_0)
	{
		return (*(A_0 + 8) - *(A_0 + 4)) / 12;
	}

	// Token: 0x06000089 RID: 137 RVA: 0x000036B4 File Offset: 0x00002AB4
	internal unsafe static uint _Grow_to(global::std.vector<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T,std::allocator<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T>\u0020>* A_0, uint _Count)
	{
		uint num = (uint)((*(A_0 + 8) - *A_0) / 12);
		uint num2 = num >> 1;
		uint num3;
		if (357913941U - num2 < num)
		{
			num3 = 0U;
		}
		else
		{
			num3 = num2 + num;
		}
		uint num4 = num3;
		return (num3 < _Count) ? _Count : num4;
	}

	// Token: 0x0600008A RID: 138 RVA: 0x000033B4 File Offset: 0x000027B4
	internal unsafe static global::FDISystem.CP_FORMAT_TYPE_V5.CODEPLUG_MAP_T* allocate(global::std._Wrap_alloc<std::allocator<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T>\u0020>* A_0, uint _Count)
	{
		void* ptr = null;
		if (_Count != 0U)
		{
			if (357913941U >= _Count)
			{
				ptr = global::<Module>.@new(_Count * 12U);
				if (ptr != null)
				{
					return ptr;
				}
			}
			global::<Module>.std._Xbad_alloc();
			return 0;
		}
		return ptr;
	}

	// Token: 0x0600008B RID: 139 RVA: 0x000033E4 File Offset: 0x000027E4
	internal unsafe static uint max_size(global::std._Wrap_alloc<std::allocator<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T>\u0020>* A_0)
	{
		return 357913941;
	}

	// Token: 0x0600008C RID: 140 RVA: 0x00002F34 File Offset: 0x00002334
	internal unsafe static global::FDISystem.CP_FORMAT_TYPE_V2.CODEPLUG_MAP_T* allocate(global::std.allocator<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T>* A_0, uint _Count)
	{
		void* ptr = null;
		if (_Count != 0U)
		{
			if (536870911U >= _Count)
			{
				ptr = global::<Module>.@new(_Count << 3);
				if (ptr != null)
				{
					return ptr;
				}
			}
			global::<Module>.std._Xbad_alloc();
			return 0;
		}
		return ptr;
	}

	// Token: 0x0600008D RID: 141 RVA: 0x00002F64 File Offset: 0x00002364
	internal unsafe static uint max_size(global::std.allocator<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T>* _Al)
	{
		return 536870911;
	}

	// Token: 0x0600008E RID: 142 RVA: 0x00002F78 File Offset: 0x00002378
	internal unsafe static int* allocate(global::std.allocator<int>* A_0, uint _Count)
	{
		void* ptr = null;
		if (_Count != 0U)
		{
			if (1073741823U >= _Count)
			{
				ptr = global::<Module>.@new(_Count << 2);
				if (ptr != null)
				{
					return ptr;
				}
			}
			global::<Module>.std._Xbad_alloc();
			return 0;
		}
		return ptr;
	}

	// Token: 0x0600008F RID: 143 RVA: 0x00002FA8 File Offset: 0x000023A8
	internal unsafe static uint max_size(global::std.allocator<int>* _Al)
	{
		return 1073741823;
	}

	// Token: 0x06000090 RID: 144 RVA: 0x00002FBC File Offset: 0x000023BC
	internal unsafe static global::FDISystem.CP_FORMAT_TYPE_V5.CODEPLUG_MAP_T* allocate(global::std.allocator<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T>* A_0, uint _Count)
	{
		void* ptr = null;
		if (_Count != 0U)
		{
			if (357913941U >= _Count)
			{
				ptr = global::<Module>.@new(_Count * 12U);
				if (ptr != null)
				{
					return ptr;
				}
			}
			global::<Module>.std._Xbad_alloc();
			return 0;
		}
		return ptr;
	}

	// Token: 0x06000091 RID: 145 RVA: 0x00002FEC File Offset: 0x000023EC
	internal unsafe static uint max_size(global::std.allocator<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T>* _Al)
	{
		return 357913941;
	}

	// Token: 0x06000092 RID: 146 RVA: 0x00001D90 File Offset: 0x00001190
	internal unsafe static uint max_size(global::std.allocator<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T>* A_0)
	{
		return 536870911;
	}

	// Token: 0x06000093 RID: 147 RVA: 0x00001DA4 File Offset: 0x000011A4
	internal unsafe static uint max_size(global::std.allocator<int>* A_0)
	{
		return 1073741823;
	}

	// Token: 0x06000094 RID: 148 RVA: 0x00001DB8 File Offset: 0x000011B8
	internal unsafe static uint max_size(global::std.allocator<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T>* A_0)
	{
		return 357913941;
	}

	// Token: 0x06000095 RID: 149 RVA: 0x00003E68 File Offset: 0x00003268
	internal unsafe static ushort ReverseBytes<unsigned\u0020short,unsigned\u0020short>(ushort destVar, ushort srcVar)
	{
		ushort result = srcVar;
		byte* ptr = ref result + 2;
		byte* ptr2 = (byte*)(&result);
		do
		{
			ptr--;
			if (ptr2 == ptr)
			{
				break;
			}
			byte b = *ptr2;
			*ptr2 = *ptr;
			*ptr = b;
			ptr2++;
		}
		while (ptr2 != ptr);
		return result;
	}

	// Token: 0x06000096 RID: 150 RVA: 0x00003B68 File Offset: 0x00002F68
	internal unsafe static void reverse<unsigned\u0020char\u0020*>(byte* _First, byte* _Last)
	{
		byte* ptr = _Last;
		byte* ptr2 = _First;
		if (_First != _Last)
		{
			do
			{
				ptr--;
				if (ptr2 == ptr)
				{
					break;
				}
				byte b = *ptr2;
				*ptr2 = *ptr;
				*ptr = b;
				ptr2++;
			}
			while (ptr2 != ptr);
		}
	}

	// Token: 0x06000097 RID: 151 RVA: 0x000044A0 File Offset: 0x000038A0
	internal unsafe static void SetEraseCount(global::FDISystem.FDIBlockInfo<FDISystem::FDI_TYPE_V2>* A_0, uint nValue, global::FDISystem.ByteOrder byteOrder)
	{
		uint destVar = (uint)(*A_0);
		uint num;
		if (byteOrder == global::FDISystem.ByteOrder.BigEndian)
		{
			num = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020int,unsigned\u0020int>(destVar, nValue);
		}
		else
		{
			num = nValue;
		}
		*A_0 = (int)num;
	}

	// Token: 0x06000098 RID: 152 RVA: 0x000044C4 File Offset: 0x000038C4
	internal unsafe static void SetPhysicalEraseCount(global::FDISystem.FDIBlockInfo<FDISystem::FDI_TYPE_V2>* A_0, uint nValue, global::FDISystem.ByteOrder byteOrder)
	{
		uint destVar = (uint)(*(A_0 + 4));
		uint num;
		if (byteOrder == global::FDISystem.ByteOrder.BigEndian)
		{
			num = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020int,unsigned\u0020int>(destVar, nValue);
		}
		else
		{
			num = nValue;
		}
		*(A_0 + 4) = (int)num;
	}

	// Token: 0x06000099 RID: 153 RVA: 0x000044EC File Offset: 0x000038EC
	internal unsafe static void SetStatus(global::FDISystem.FDIBlockInfo<FDISystem::FDI_TYPE_V2>* A_0, uint nValue, global::FDISystem.ByteOrder byteOrder)
	{
		byte destVar = *(A_0 + 8);
		byte b;
		if (byteOrder == global::FDISystem.ByteOrder.BigEndian)
		{
			b = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020char,unsigned\u0020int>(destVar, nValue);
		}
		else
		{
			b = (byte)nValue;
		}
		*(A_0 + 8) = b;
	}

	// Token: 0x0600009A RID: 154 RVA: 0x00004514 File Offset: 0x00003914
	internal unsafe static void SetLogicalBlockNum(global::FDISystem.FDIBlockInfo<FDISystem::FDI_TYPE_V2>* A_0, uint nValue, global::FDISystem.ByteOrder byteOrder)
	{
		byte destVar = *(A_0 + 9);
		byte b;
		if (byteOrder == global::FDISystem.ByteOrder.BigEndian)
		{
			b = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020char,unsigned\u0020int>(destVar, nValue);
		}
		else
		{
			b = (byte)nValue;
		}
		*(A_0 + 9) = b;
	}

	// Token: 0x0600009B RID: 155 RVA: 0x00004540 File Offset: 0x00003940
	internal unsafe static void SetPhysicalCopy(global::FDISystem.FDIBlockInfo<FDISystem::FDI_TYPE_V2>* A_0, uint nValue, global::FDISystem.ByteOrder byteOrder)
	{
		byte destVar = *(A_0 + 10);
		byte b;
		if (byteOrder == global::FDISystem.ByteOrder.BigEndian)
		{
			b = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020char,unsigned\u0020int>(destVar, nValue);
		}
		else
		{
			b = (byte)nValue;
		}
		*(A_0 + 10) = b;
	}

	// Token: 0x0600009C RID: 156 RVA: 0x0000456C File Offset: 0x0000396C
	internal unsafe static void SetCurrentState(global::FDISystem.FDIBlockInfo<FDISystem::FDI_TYPE_V2>* A_0, uint nValue, global::FDISystem.ByteOrder byteOrder)
	{
		ushort destVar = *(A_0 + 14);
		ushort num;
		if (byteOrder == global::FDISystem.ByteOrder.BigEndian)
		{
			num = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,unsigned\u0020int>(destVar, nValue);
		}
		else
		{
			num = (ushort)nValue;
		}
		*(A_0 + 14) = (short)num;
	}

	// Token: 0x0600009D RID: 157 RVA: 0x00001E50 File Offset: 0x00001250
	internal static uint GetBlockStatusValueWrite()
	{
		return 240;
	}

	// Token: 0x0600009E RID: 158 RVA: 0x00005CEC File Offset: 0x000050EC
	internal unsafe static uint GetOffset(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V2>* A_0, global::FDISystem.ByteOrder byteOrder)
	{
		ushort num = *(A_0 + 4);
		ushort result;
		if (byteOrder == global::FDISystem.ByteOrder.BigEndian)
		{
			ushort num2 = num;
			result = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,unsigned\u0020short>(num2, num2);
		}
		else
		{
			result = num;
		}
		return (uint)result;
	}

	// Token: 0x0600009F RID: 159 RVA: 0x00005D10 File Offset: 0x00005110
	[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
	internal unsafe static bool IsEmpty(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V2>* A_0, global::FDISystem.ByteOrder byteOrder)
	{
		byte b = *(A_0 + 6);
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
		return b3 == byte.MaxValue;
	}

	// Token: 0x060000A0 RID: 160 RVA: 0x00004598 File Offset: 0x00003998
	internal static byte FDIAdjustDataBytes<unsigned\u0020char>(byte var, global::FDISystem.ByteOrder byteOrder)
	{
		if (byteOrder == global::FDISystem.ByteOrder.BigEndian)
		{
			return global::<Module>.FDISystem.ReverseBytes<unsigned\u0020char,unsigned\u0020char>(var, var);
		}
		return var;
	}

	// Token: 0x060000A1 RID: 161 RVA: 0x000045B4 File Offset: 0x000039B4
	internal unsafe static uint GetCodeplugMapStrNumOfUnits(global::FDISystem.CPBlockMap<FDISystem::CP_FORMAT_TYPE_V2>* A_0, global::FDISystem.ByteOrder byteOrder)
	{
		byte b = *(A_0 + 3);
		byte result;
		if (byteOrder == global::FDISystem.ByteOrder.BigEndian)
		{
			byte b2 = b;
			result = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020char,unsigned\u0020char>(b2, b2);
		}
		else
		{
			result = b;
		}
		return (uint)result;
	}

	// Token: 0x060000A2 RID: 162 RVA: 0x00005D3C File Offset: 0x0000513C
	internal unsafe static uint GetCodeplugMapStrUnit1Id(global::FDISystem.CPBlockMap<FDISystem::CP_FORMAT_TYPE_V2>* A_0, global::FDISystem.ByteOrder byteOrder)
	{
		ushort num = *(A_0 + 4);
		ushort result;
		if (byteOrder == global::FDISystem.ByteOrder.BigEndian)
		{
			ushort num2 = num;
			result = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,unsigned\u0020short>(num2, num2);
		}
		else
		{
			result = num;
		}
		return (uint)result;
	}

	// Token: 0x060000A3 RID: 163 RVA: 0x00001E98 File Offset: 0x00001298
	internal unsafe static void SetCodeplugMapId(global::FDISystem.CPBlockMap<FDISystem::CP_FORMAT_TYPE_V2>* A_0, byte idLowByte, byte idHighByte, global::FDISystem.ByteOrder byteOrder)
	{
		*A_0 = (byte)((sbyte)idLowByte);
		*(A_0 + 1) = (byte)((sbyte)idHighByte);
	}

	// Token: 0x060000A4 RID: 164 RVA: 0x000045D8 File Offset: 0x000039D8
	internal unsafe static void SetCodeplugMapNumOfUnits(global::FDISystem.CPBlockMap<FDISystem::CP_FORMAT_TYPE_V2>* A_0, int nUnitsPerCPBlock, global::FDISystem.ByteOrder byteOrder)
	{
		byte destVar = *(A_0 + 3);
		byte b;
		if (byteOrder == global::FDISystem.ByteOrder.BigEndian)
		{
			b = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020char,int>(destVar, nUnitsPerCPBlock);
		}
		else
		{
			b = (byte)nUnitsPerCPBlock;
		}
		*(A_0 + 3) = b;
	}

	// Token: 0x060000A5 RID: 165 RVA: 0x00004600 File Offset: 0x00003A00
	internal unsafe static void SetCodeplugMapUnit1Id(global::FDISystem.CPBlockMap<FDISystem::CP_FORMAT_TYPE_V2>* A_0, int firstUnitID, global::FDISystem.ByteOrder byteOrder)
	{
		ushort destVar = *(A_0 + 4);
		ushort num;
		if (byteOrder == global::FDISystem.ByteOrder.BigEndian)
		{
			num = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,int>(destVar, firstUnitID);
		}
		else
		{
			num = (ushort)firstUnitID;
		}
		*(A_0 + 4) = (short)num;
	}

	// Token: 0x060000A6 RID: 166 RVA: 0x00001EB0 File Offset: 0x000012B0
	internal unsafe static void SetCodeplugMapPad(global::FDISystem.CPBlockMap<FDISystem::CP_FORMAT_TYPE_V2>* A_0, byte padValue, global::FDISystem.ByteOrder byteOrder)
	{
		initblk(A_0 + 6, padValue, 2);
	}

	// Token: 0x060000A7 RID: 167 RVA: 0x00004628 File Offset: 0x00003A28
	internal unsafe static void SetCodeplugMapLogicBlockNumber(global::FDISystem.CPBlockMap<FDISystem::CP_FORMAT_TYPE_V2>* A_0, int logicBlockNumber, global::FDISystem.ByteOrder byteOrder)
	{
		byte destVar = *(A_0 + 2);
		byte b;
		if (byteOrder == global::FDISystem.ByteOrder.BigEndian)
		{
			b = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020char,int>(destVar, logicBlockNumber);
		}
		else
		{
			b = (byte)logicBlockNumber;
		}
		*(A_0 + 2) = b;
	}

	// Token: 0x060000A8 RID: 168 RVA: 0x00001EC4 File Offset: 0x000012C4
	internal static uint GetCodeplugMapStructureSize()
	{
		return 8;
	}

	// Token: 0x060000A9 RID: 169 RVA: 0x00001ED4 File Offset: 0x000012D4
	internal unsafe static void SetID(global::FDISystem.CPFixedUnitHeader<FDISystem::CP_FORMAT_TYPE_V2>* A_0, ushort id, global::FDISystem.ByteOrder byteOrder)
	{
		*A_0 = (short)id;
	}

	// Token: 0x060000AA RID: 170 RVA: 0x00004650 File Offset: 0x00003A50
	internal unsafe static void SetNumOfUnits(global::FDISystem.CPFixedUnitHeader<FDISystem::CP_FORMAT_TYPE_V2>* A_0, uint numOfUnits, global::FDISystem.ByteOrder byteOrder)
	{
		byte destVar = *(A_0 + 4);
		byte b;
		if (byteOrder == global::FDISystem.ByteOrder.BigEndian)
		{
			b = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020char,unsigned\u0020int>(destVar, numOfUnits);
		}
		else
		{
			b = (byte)numOfUnits;
		}
		*(A_0 + 4) = b;
	}

	// Token: 0x060000AB RID: 171 RVA: 0x00004678 File Offset: 0x00003A78
	internal unsafe static void SetIndexOfUnit(global::FDISystem.CPFixedUnitHeader<FDISystem::CP_FORMAT_TYPE_V2>* A_0, uint indexOfUnit, global::FDISystem.ByteOrder byteOrder)
	{
		byte destVar = *(A_0 + 5);
		byte b;
		if (byteOrder == global::FDISystem.ByteOrder.BigEndian)
		{
			b = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020char,unsigned\u0020int>(destVar, indexOfUnit);
		}
		else
		{
			b = (byte)indexOfUnit;
		}
		*(A_0 + 5) = b;
	}

	// Token: 0x060000AC RID: 172 RVA: 0x000046A0 File Offset: 0x00003AA0
	internal unsafe static void SetUnitDataSize(global::FDISystem.CPFixedUnitHeader<FDISystem::CP_FORMAT_TYPE_V2>* A_0, uint unitDataSize, global::FDISystem.ByteOrder byteOrder)
	{
		ushort destVar = *(A_0 + 2);
		ushort num;
		if (byteOrder == global::FDISystem.ByteOrder.BigEndian)
		{
			num = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,unsigned\u0020int>(destVar, unitDataSize);
		}
		else
		{
			num = (ushort)unitDataSize;
		}
		*(A_0 + 2) = (short)num;
	}

	// Token: 0x060000AD RID: 173 RVA: 0x000046C8 File Offset: 0x00003AC8
	internal unsafe static void SetChecksum(global::FDISystem.CPFixedUnitHeader<FDISystem::CP_FORMAT_TYPE_V2>* A_0, uint checksum, global::FDISystem.ByteOrder byteOrder)
	{
		ushort destVar = *(A_0 + 6);
		ushort num;
		if (byteOrder == global::FDISystem.ByteOrder.BigEndian)
		{
			num = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,unsigned\u0020int>(destVar, checksum);
		}
		else
		{
			num = (ushort)checksum;
		}
		*(A_0 + 6) = (short)num;
	}

	// Token: 0x060000AE RID: 174 RVA: 0x00001EE4 File Offset: 0x000012E4
	[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
	internal unsafe static bool IsFixUnitHeaderValid(global::FDISystem.CPFixedUnitHeader<FDISystem::CP_FORMAT_TYPE_V2>* A_0, global::FDISystem.ByteOrder byteOrder)
	{
		int num;
		if (char.IsLetter((char)((int)(*A_0))) && char.IsLetter((char)((int)(*(A_0 + 1)))))
		{
			num = 1;
		}
		else
		{
			num = 0;
		}
		return (byte)num != 0;
	}

	// Token: 0x060000AF RID: 175 RVA: 0x00001F14 File Offset: 0x00001314
	internal static uint GetFixedUnitHeaderSize()
	{
		return 8;
	}

	// Token: 0x060000B0 RID: 176 RVA: 0x00003E9C File Offset: 0x0000329C
	internal static ushort FDIAdjustDataBytes<unsigned\u0020short,int>(ushort destVar, int srcVar, global::FDISystem.ByteOrder byteOrder)
	{
		if (byteOrder == global::FDISystem.ByteOrder.BigEndian)
		{
			return global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,int>(destVar, srcVar);
		}
		return (ushort)srcVar;
	}

	// Token: 0x060000B1 RID: 177 RVA: 0x000046F0 File Offset: 0x00003AF0
	internal unsafe static void SetEraseCount(global::FDISystem.FDIBlockInfo<FDISystem::FDI_TYPE_V5>* A_0, uint nValue, global::FDISystem.ByteOrder byteOrder)
	{
		uint destVar = (uint)(*A_0);
		uint num;
		if (byteOrder == global::FDISystem.ByteOrder.BigEndian)
		{
			num = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020int,unsigned\u0020int>(destVar, nValue);
		}
		else
		{
			num = nValue;
		}
		*A_0 = (int)num;
	}

	// Token: 0x060000B2 RID: 178 RVA: 0x00004714 File Offset: 0x00003B14
	internal unsafe static void SetPhysicalEraseCount(global::FDISystem.FDIBlockInfo<FDISystem::FDI_TYPE_V5>* A_0, uint nValue, global::FDISystem.ByteOrder byteOrder)
	{
		uint destVar = (uint)(*(A_0 + 4));
		uint num;
		if (byteOrder == global::FDISystem.ByteOrder.BigEndian)
		{
			num = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020int,unsigned\u0020int>(destVar, nValue);
		}
		else
		{
			num = nValue;
		}
		*(A_0 + 4) = (int)num;
	}

	// Token: 0x060000B3 RID: 179 RVA: 0x0000473C File Offset: 0x00003B3C
	internal unsafe static void SetStatus(global::FDISystem.FDIBlockInfo<FDISystem::FDI_TYPE_V5>* A_0, uint nValue, global::FDISystem.ByteOrder byteOrder)
	{
		byte destVar = *(A_0 + 14);
		byte b;
		if (byteOrder == global::FDISystem.ByteOrder.BigEndian)
		{
			b = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020char,unsigned\u0020int>(destVar, nValue);
		}
		else
		{
			b = (byte)nValue;
		}
		*(A_0 + 14) = b;
	}

	// Token: 0x060000B4 RID: 180 RVA: 0x00004768 File Offset: 0x00003B68
	internal unsafe static void SetLogicalBlockNum(global::FDISystem.FDIBlockInfo<FDISystem::FDI_TYPE_V5>* A_0, uint nValue, global::FDISystem.ByteOrder byteOrder)
	{
		ushort destVar = *(A_0 + 8);
		ushort num;
		if (byteOrder == global::FDISystem.ByteOrder.BigEndian)
		{
			num = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,unsigned\u0020int>(destVar, nValue);
		}
		else
		{
			num = (ushort)nValue;
		}
		*(A_0 + 8) = (short)num;
	}

	// Token: 0x060000B5 RID: 181 RVA: 0x00004790 File Offset: 0x00003B90
	internal unsafe static void SetPhysicalCopy(global::FDISystem.FDIBlockInfo<FDISystem::FDI_TYPE_V5>* A_0, uint nValue, global::FDISystem.ByteOrder byteOrder)
	{
		ushort destVar = *(A_0 + 10);
		ushort num;
		if (byteOrder == global::FDISystem.ByteOrder.BigEndian)
		{
			num = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,unsigned\u0020int>(destVar, nValue);
		}
		else
		{
			num = (ushort)nValue;
		}
		*(A_0 + 10) = (short)num;
	}

	// Token: 0x060000B6 RID: 182 RVA: 0x000047BC File Offset: 0x00003BBC
	internal unsafe static void SetCurrentState(global::FDISystem.FDIBlockInfo<FDISystem::FDI_TYPE_V5>* A_0, uint nValue, global::FDISystem.ByteOrder byteOrder)
	{
		ushort destVar = *(A_0 + 12);
		ushort num;
		if (byteOrder == global::FDISystem.ByteOrder.BigEndian)
		{
			num = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,unsigned\u0020int>(destVar, nValue);
		}
		else
		{
			num = (ushort)nValue;
		}
		*(A_0 + 12) = (short)num;
	}

	// Token: 0x060000B7 RID: 183 RVA: 0x00001FB0 File Offset: 0x000013B0
	internal static uint GetBlockStatusValueWrite()
	{
		return 0;
	}

	// Token: 0x060000B8 RID: 184 RVA: 0x00005D60 File Offset: 0x00005160
	internal unsafe static uint GetOffset(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V5>* A_0, global::FDISystem.ByteOrder byteOrder)
	{
		ushort num = *(A_0 + 6);
		ushort result;
		if (byteOrder == global::FDISystem.ByteOrder.BigEndian)
		{
			ushort num2 = num;
			result = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,unsigned\u0020short>(num2, num2);
		}
		else
		{
			result = num;
		}
		return (uint)result;
	}

	// Token: 0x060000B9 RID: 185 RVA: 0x00005D84 File Offset: 0x00005184
	[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
	internal unsafe static bool IsEmpty(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V5>* A_0, global::FDISystem.ByteOrder byteOrder)
	{
		ushort num = *(A_0 + 10);
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
		return num3 == ushort.MaxValue;
	}

	// Token: 0x060000BA RID: 186 RVA: 0x00005DB4 File Offset: 0x000051B4
	internal unsafe static uint GetCodeplugMapStrNumOfUnits(global::FDISystem.CPBlockMap<FDISystem::CP_FORMAT_TYPE_V5>* A_0, global::FDISystem.ByteOrder byteOrder)
	{
		ushort num = *(A_0 + 4);
		ushort result;
		if (byteOrder == global::FDISystem.ByteOrder.BigEndian)
		{
			ushort num2 = num;
			result = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,unsigned\u0020short>(num2, num2);
		}
		else
		{
			result = num;
		}
		return (uint)result;
	}

	// Token: 0x060000BB RID: 187 RVA: 0x00005DD8 File Offset: 0x000051D8
	internal unsafe static uint GetCodeplugMapStrUnit1Id(global::FDISystem.CPBlockMap<FDISystem::CP_FORMAT_TYPE_V5>* A_0, global::FDISystem.ByteOrder byteOrder)
	{
		ushort num = *(A_0 + 6);
		ushort result;
		if (byteOrder == global::FDISystem.ByteOrder.BigEndian)
		{
			ushort num2 = num;
			result = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,unsigned\u0020short>(num2, num2);
		}
		else
		{
			result = num;
		}
		return (uint)result;
	}

	// Token: 0x060000BC RID: 188 RVA: 0x00001FF4 File Offset: 0x000013F4
	internal unsafe static void SetCodeplugMapId(global::FDISystem.CPBlockMap<FDISystem::CP_FORMAT_TYPE_V5>* A_0, byte idLowByte, byte idHighByte, global::FDISystem.ByteOrder byteOrder)
	{
		*A_0 = (byte)((sbyte)idLowByte);
		*(A_0 + 1) = (byte)((sbyte)idHighByte);
	}

	// Token: 0x060000BD RID: 189 RVA: 0x00003EB8 File Offset: 0x000032B8
	internal unsafe static void SetCodeplugMapNumOfUnits(global::FDISystem.CPBlockMap<FDISystem::CP_FORMAT_TYPE_V5>* A_0, int nUnitsPerCPBlock, global::FDISystem.ByteOrder byteOrder)
	{
		ushort destVar = *(A_0 + 4);
		ushort num;
		if (byteOrder == global::FDISystem.ByteOrder.BigEndian)
		{
			num = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,int>(destVar, nUnitsPerCPBlock);
		}
		else
		{
			num = (ushort)nUnitsPerCPBlock;
		}
		*(A_0 + 4) = (short)num;
	}

	// Token: 0x060000BE RID: 190 RVA: 0x00003EE0 File Offset: 0x000032E0
	internal unsafe static void SetCodeplugMapUnit1Id(global::FDISystem.CPBlockMap<FDISystem::CP_FORMAT_TYPE_V5>* A_0, int firstUnitID, global::FDISystem.ByteOrder byteOrder)
	{
		ushort destVar = *(A_0 + 6);
		ushort num;
		if (byteOrder == global::FDISystem.ByteOrder.BigEndian)
		{
			num = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,int>(destVar, firstUnitID);
		}
		else
		{
			num = (ushort)firstUnitID;
		}
		*(A_0 + 6) = (short)num;
	}

	// Token: 0x060000BF RID: 191 RVA: 0x0000200C File Offset: 0x0000140C
	internal unsafe static void SetCodeplugMapPad(global::FDISystem.CPBlockMap<FDISystem::CP_FORMAT_TYPE_V5>* A_0, byte padValue, global::FDISystem.ByteOrder byteOrder)
	{
		initblk(A_0 + 8, padValue, 4);
	}

	// Token: 0x060000C0 RID: 192 RVA: 0x00003F08 File Offset: 0x00003308
	internal unsafe static void SetCodeplugMapLogicBlockNumber(global::FDISystem.CPBlockMap<FDISystem::CP_FORMAT_TYPE_V5>* A_0, int logicBlockNumber, global::FDISystem.ByteOrder byteOrder)
	{
		ushort destVar = *(A_0 + 2);
		ushort num;
		if (byteOrder == global::FDISystem.ByteOrder.BigEndian)
		{
			num = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,int>(destVar, logicBlockNumber);
		}
		else
		{
			num = (ushort)logicBlockNumber;
		}
		*(A_0 + 2) = (short)num;
	}

	// Token: 0x060000C1 RID: 193 RVA: 0x00002020 File Offset: 0x00001420
	internal static uint GetCodeplugMapStructureSize()
	{
		return 12;
	}

	// Token: 0x060000C2 RID: 194 RVA: 0x00002030 File Offset: 0x00001430
	internal unsafe static void SetID(global::FDISystem.CPFixedUnitHeader<FDISystem::CP_FORMAT_TYPE_V5>* A_0, ushort id, global::FDISystem.ByteOrder byteOrder)
	{
		*A_0 = (short)id;
	}

	// Token: 0x060000C3 RID: 195 RVA: 0x000047E8 File Offset: 0x00003BE8
	internal unsafe static void SetNumOfUnits(global::FDISystem.CPFixedUnitHeader<FDISystem::CP_FORMAT_TYPE_V5>* A_0, uint numOfUnits, global::FDISystem.ByteOrder byteOrder)
	{
		ushort destVar = *(A_0 + 4);
		ushort num;
		if (byteOrder == global::FDISystem.ByteOrder.BigEndian)
		{
			num = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,unsigned\u0020int>(destVar, numOfUnits);
		}
		else
		{
			num = (ushort)numOfUnits;
		}
		*(A_0 + 4) = (short)num;
	}

	// Token: 0x060000C4 RID: 196 RVA: 0x00004810 File Offset: 0x00003C10
	internal unsafe static void SetIndexOfUnit(global::FDISystem.CPFixedUnitHeader<FDISystem::CP_FORMAT_TYPE_V5>* A_0, uint indexOfUnit, global::FDISystem.ByteOrder byteOrder)
	{
		ushort destVar = *(A_0 + 6);
		ushort num;
		if (byteOrder == global::FDISystem.ByteOrder.BigEndian)
		{
			num = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,unsigned\u0020int>(destVar, indexOfUnit);
		}
		else
		{
			num = (ushort)indexOfUnit;
		}
		*(A_0 + 6) = (short)num;
	}

	// Token: 0x060000C5 RID: 197 RVA: 0x00004838 File Offset: 0x00003C38
	internal unsafe static void SetUnitDataSize(global::FDISystem.CPFixedUnitHeader<FDISystem::CP_FORMAT_TYPE_V5>* A_0, uint unitDataSize, global::FDISystem.ByteOrder byteOrder)
	{
		ushort destVar = *(A_0 + 2);
		ushort num;
		if (byteOrder == global::FDISystem.ByteOrder.BigEndian)
		{
			num = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,unsigned\u0020int>(destVar, unitDataSize);
		}
		else
		{
			num = (ushort)unitDataSize;
		}
		*(A_0 + 2) = (short)num;
	}

	// Token: 0x060000C6 RID: 198 RVA: 0x00004860 File Offset: 0x00003C60
	internal unsafe static void SetChecksum(global::FDISystem.CPFixedUnitHeader<FDISystem::CP_FORMAT_TYPE_V5>* A_0, uint checksum, global::FDISystem.ByteOrder byteOrder)
	{
		ushort destVar = *(A_0 + 8);
		ushort num;
		if (byteOrder == global::FDISystem.ByteOrder.BigEndian)
		{
			num = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,unsigned\u0020int>(destVar, checksum);
		}
		else
		{
			num = (ushort)checksum;
		}
		*(A_0 + 8) = (short)num;
	}

	// Token: 0x060000C7 RID: 199 RVA: 0x00002040 File Offset: 0x00001440
	[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
	internal unsafe static bool IsFixUnitHeaderValid(global::FDISystem.CPFixedUnitHeader<FDISystem::CP_FORMAT_TYPE_V5>* A_0, global::FDISystem.ByteOrder byteOrder)
	{
		int num;
		if (char.IsLetter((char)((int)(*A_0))) && char.IsLetter((char)((int)(*(A_0 + 1)))))
		{
			num = 1;
		}
		else
		{
			num = 0;
		}
		return (byte)num != 0;
	}

	// Token: 0x060000C8 RID: 200 RVA: 0x00002070 File Offset: 0x00001470
	internal static uint GetFixedUnitHeaderSize()
	{
		return 12;
	}

	// Token: 0x060000C9 RID: 201 RVA: 0x00002080 File Offset: 0x00001480
	internal unsafe static global::std._Nonscalar_ptr_iterator_tag _Ptr_cat<struct\u0020FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T,struct\u0020FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T>(global::FDISystem.CP_FORMAT_TYPE_V2.CODEPLUG_MAP_T* A_0, global::FDISystem.CP_FORMAT_TYPE_V2.CODEPLUG_MAP_T* A_1)
	{
		global::std._Nonscalar_ptr_iterator_tag result;
		return result;
	}

	// Token: 0x060000CA RID: 202 RVA: 0x000036F0 File Offset: 0x00002AF0
	internal unsafe static void _Destroy_range<struct\u0020std::_Wrap_alloc<class\u0020std::allocator<struct\u0020FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T>\u0020>\u0020>(global::FDISystem.CP_FORMAT_TYPE_V2.CODEPLUG_MAP_T* _First, global::FDISystem.CP_FORMAT_TYPE_V2.CODEPLUG_MAP_T* _Last, global::std._Wrap_alloc<std::allocator<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T>\u0020>* _Al, global::std._Nonscalar_ptr_iterator_tag __unnamed003)
	{
	}

	// Token: 0x060000CB RID: 203 RVA: 0x00002090 File Offset: 0x00001490
	internal unsafe static global::std._Scalar_ptr_iterator_tag _Ptr_cat<int,int>(int* A_0, int* A_1)
	{
		global::std._Scalar_ptr_iterator_tag result;
		return result;
	}

	// Token: 0x060000CC RID: 204 RVA: 0x000020A0 File Offset: 0x000014A0
	internal unsafe static void _Destroy_range<struct\u0020std::_Wrap_alloc<class\u0020std::allocator<int>\u0020>\u0020>(int* _First, int* _Last, global::std._Wrap_alloc<std::allocator<int>\u0020>* _Al, global::std._Scalar_ptr_iterator_tag __unnamed003)
	{
	}

	// Token: 0x060000CD RID: 205 RVA: 0x000020B0 File Offset: 0x000014B0
	internal unsafe static global::std._Nonscalar_ptr_iterator_tag _Ptr_cat<struct\u0020FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T,struct\u0020FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T>(global::FDISystem.CP_FORMAT_TYPE_V5.CODEPLUG_MAP_T* A_0, global::FDISystem.CP_FORMAT_TYPE_V5.CODEPLUG_MAP_T* A_1)
	{
		global::std._Nonscalar_ptr_iterator_tag result;
		return result;
	}

	// Token: 0x060000CE RID: 206 RVA: 0x00003700 File Offset: 0x00002B00
	internal unsafe static void _Destroy_range<struct\u0020std::_Wrap_alloc<class\u0020std::allocator<struct\u0020FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T>\u0020>\u0020>(global::FDISystem.CP_FORMAT_TYPE_V5.CODEPLUG_MAP_T* _First, global::FDISystem.CP_FORMAT_TYPE_V5.CODEPLUG_MAP_T* _Last, global::std._Wrap_alloc<std::allocator<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T>\u0020>* _Al, global::std._Nonscalar_ptr_iterator_tag __unnamed003)
	{
	}

	// Token: 0x060000CF RID: 207 RVA: 0x000020C0 File Offset: 0x000014C0
	internal unsafe static global::FDISystem.CP_FORMAT_TYPE_V2.CODEPLUG_MAP_T* addressof<struct\u0020FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T\u0020const\u0020>(global::FDISystem.CP_FORMAT_TYPE_V2.CODEPLUG_MAP_T* _Val)
	{
		return _Val;
	}

	// Token: 0x060000D0 RID: 208 RVA: 0x000033F8 File Offset: 0x000027F8
	internal unsafe static void construct<struct\u0020FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T,struct\u0020FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T\u0020&>(global::std._Wrap_alloc<std::allocator<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T>\u0020>* A_0, global::FDISystem.CP_FORMAT_TYPE_V2.CODEPLUG_MAP_T* _Ptr, global::FDISystem.CP_FORMAT_TYPE_V2.CODEPLUG_MAP_T* <_Args_0>)
	{
		try
		{
			if (_Ptr != null)
			{
				cpblk(_Ptr, <_Args_0>, 8);
			}
		}
		catch
		{
			global::<Module>.delete((void*)_Ptr, (void*)_Ptr);
			throw;
		}
	}

	// Token: 0x060000D1 RID: 209 RVA: 0x0000343C File Offset: 0x0000283C
	internal unsafe static void construct<struct\u0020FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T,struct\u0020FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T\u0020const\u0020&>(global::std._Wrap_alloc<std::allocator<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T>\u0020>* A_0, global::FDISystem.CP_FORMAT_TYPE_V2.CODEPLUG_MAP_T* _Ptr, global::FDISystem.CP_FORMAT_TYPE_V2.CODEPLUG_MAP_T* <_Args_0>)
	{
		if (_Ptr != null)
		{
			cpblk(_Ptr, <_Args_0>, 8);
		}
	}

	// Token: 0x060000D2 RID: 210 RVA: 0x000020D0 File Offset: 0x000014D0
	internal unsafe static int* addressof<int>(int* _Val)
	{
		return _Val;
	}

	// Token: 0x060000D3 RID: 211 RVA: 0x000020E0 File Offset: 0x000014E0
	internal unsafe static int* forward<int>(int* _Arg)
	{
		return _Arg;
	}

	// Token: 0x060000D4 RID: 212 RVA: 0x00003454 File Offset: 0x00002854
	internal unsafe static void construct<int,int>(global::std._Wrap_alloc<std::allocator<int>\u0020>* A_0, int* _Ptr, int* <_Args_0>)
	{
		try
		{
			if (_Ptr != null)
			{
				*_Ptr = *<_Args_0>;
			}
		}
		catch
		{
			global::<Module>.delete((void*)_Ptr, (void*)_Ptr);
			throw;
		}
	}

	// Token: 0x060000D5 RID: 213 RVA: 0x000020F0 File Offset: 0x000014F0
	internal unsafe static global::FDISystem.CP_FORMAT_TYPE_V5.CODEPLUG_MAP_T* addressof<struct\u0020FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T\u0020const\u0020>(global::FDISystem.CP_FORMAT_TYPE_V5.CODEPLUG_MAP_T* _Val)
	{
		return _Val;
	}

	// Token: 0x060000D6 RID: 214 RVA: 0x00003494 File Offset: 0x00002894
	internal unsafe static void construct<struct\u0020FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T,struct\u0020FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T\u0020&>(global::std._Wrap_alloc<std::allocator<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T>\u0020>* A_0, global::FDISystem.CP_FORMAT_TYPE_V5.CODEPLUG_MAP_T* _Ptr, global::FDISystem.CP_FORMAT_TYPE_V5.CODEPLUG_MAP_T* <_Args_0>)
	{
		try
		{
			if (_Ptr != null)
			{
				cpblk(_Ptr, <_Args_0>, 12);
			}
		}
		catch
		{
			global::<Module>.delete((void*)_Ptr, (void*)_Ptr);
			throw;
		}
	}

	// Token: 0x060000D7 RID: 215 RVA: 0x000034D8 File Offset: 0x000028D8
	internal unsafe static void construct<struct\u0020FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T,struct\u0020FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T\u0020const\u0020&>(global::std._Wrap_alloc<std::allocator<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T>\u0020>* A_0, global::FDISystem.CP_FORMAT_TYPE_V5.CODEPLUG_MAP_T* _Ptr, global::FDISystem.CP_FORMAT_TYPE_V5.CODEPLUG_MAP_T* <_Args_0>)
	{
		if (_Ptr != null)
		{
			cpblk(_Ptr, <_Args_0>, 12);
		}
	}

	// Token: 0x060000D8 RID: 216 RVA: 0x00004888 File Offset: 0x00003C88
	internal unsafe static global::FDISystem.CP_FORMAT_TYPE_V2.CODEPLUG_MAP_T* _Umove<struct\u0020FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T\u0020*>(global::std.vector<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T,std::allocator<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T>\u0020>* A_0, global::FDISystem.CP_FORMAT_TYPE_V2.CODEPLUG_MAP_T* _First, global::FDISystem.CP_FORMAT_TYPE_V2.CODEPLUG_MAP_T* _Last, global::FDISystem.CP_FORMAT_TYPE_V2.CODEPLUG_MAP_T* _Ptr)
	{
		global::std._Nonscalar_ptr_iterator_tag nonscalar_ptr_iterator_tag;
		global::std._Nonscalar_ptr_iterator_tag _unnamed = nonscalar_ptr_iterator_tag;
		global::std._Wrap_alloc<std::allocator<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T>\u0020> wrap_alloc<std::allocator<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T>_u0020>;
		return global::<Module>.std._Uninit_move<struct\u0020FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T\u0020*,struct\u0020FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T\u0020*,class\u0020std::allocator<struct\u0020FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T>,struct\u0020FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T>(_First, _Last, _Ptr, ref wrap_alloc<std::allocator<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T>_u0020>, null, _unnamed);
	}

	// Token: 0x060000D9 RID: 217 RVA: 0x00003710 File Offset: 0x00002B10
	internal unsafe static int* _Umove<int\u0020*>(global::std.vector<int,std::allocator<int>\u0020>* A_0, int* _First, int* _Last, int* _Ptr)
	{
		uint num = (uint)((_Last - _First >> 2) * 4);
		return global::<Module>.memmove((void*)_Ptr, (void*)_First, num) + num;
	}

	// Token: 0x060000DA RID: 218 RVA: 0x000048A4 File Offset: 0x00003CA4
	internal unsafe static global::FDISystem.CP_FORMAT_TYPE_V5.CODEPLUG_MAP_T* _Umove<struct\u0020FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T\u0020*>(global::std.vector<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T,std::allocator<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T>\u0020>* A_0, global::FDISystem.CP_FORMAT_TYPE_V5.CODEPLUG_MAP_T* _First, global::FDISystem.CP_FORMAT_TYPE_V5.CODEPLUG_MAP_T* _Last, global::FDISystem.CP_FORMAT_TYPE_V5.CODEPLUG_MAP_T* _Ptr)
	{
		global::std._Nonscalar_ptr_iterator_tag nonscalar_ptr_iterator_tag;
		global::std._Nonscalar_ptr_iterator_tag _unnamed = nonscalar_ptr_iterator_tag;
		global::std._Wrap_alloc<std::allocator<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T>\u0020> wrap_alloc<std::allocator<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T>_u0020>;
		return global::<Module>.std._Uninit_move<struct\u0020FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T\u0020*,struct\u0020FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T\u0020*,class\u0020std::allocator<struct\u0020FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T>,struct\u0020FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T>(_First, _Last, _Ptr, ref wrap_alloc<std::allocator<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T>_u0020>, null, _unnamed);
	}

	// Token: 0x060000DB RID: 219 RVA: 0x00002100 File Offset: 0x00001500
	internal unsafe static global::FDISystem.CP_FORMAT_TYPE_V2.CODEPLUG_MAP_T* _Allocate<struct\u0020FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T>(uint _Count, global::FDISystem.CP_FORMAT_TYPE_V2.CODEPLUG_MAP_T* __unnamed001)
	{
		void* ptr = null;
		if (_Count != 0U)
		{
			if (536870911U >= _Count)
			{
				ptr = global::<Module>.@new(_Count << 3);
				if (ptr != null)
				{
					return ptr;
				}
			}
			global::<Module>.std._Xbad_alloc();
			return 0;
		}
		return ptr;
	}

	// Token: 0x060000DC RID: 220 RVA: 0x00002130 File Offset: 0x00001530
	internal unsafe static int* _Allocate<int>(uint _Count, int* __unnamed001)
	{
		void* ptr = null;
		if (_Count != 0U)
		{
			if (1073741823U >= _Count)
			{
				ptr = global::<Module>.@new(_Count << 2);
				if (ptr != null)
				{
					return ptr;
				}
			}
			global::<Module>.std._Xbad_alloc();
			return 0;
		}
		return ptr;
	}

	// Token: 0x060000DD RID: 221 RVA: 0x00002160 File Offset: 0x00001560
	internal unsafe static global::FDISystem.CP_FORMAT_TYPE_V5.CODEPLUG_MAP_T* _Allocate<struct\u0020FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T>(uint _Count, global::FDISystem.CP_FORMAT_TYPE_V5.CODEPLUG_MAP_T* __unnamed001)
	{
		void* ptr = null;
		if (_Count != 0U)
		{
			if (357913941U >= _Count)
			{
				ptr = global::<Module>.@new(_Count * 12U);
				if (ptr != null)
				{
					return ptr;
				}
			}
			global::<Module>.std._Xbad_alloc();
			return 0;
		}
		return ptr;
	}

	// Token: 0x060000DE RID: 222 RVA: 0x00002190 File Offset: 0x00001590
	internal static uint AttrMultiInstance()
	{
		return 14;
	}

	// Token: 0x060000DF RID: 223 RVA: 0x000021A0 File Offset: 0x000015A0
	internal static uint AttrSingleInstance()
	{
		return 8;
	}

	// Token: 0x060000E0 RID: 224 RVA: 0x000021B0 File Offset: 0x000015B0
	internal static uint AttrGroupTable()
	{
		return 10;
	}

	// Token: 0x060000E1 RID: 225 RVA: 0x000021C0 File Offset: 0x000015C0
	internal static uint AttrMultiInstance()
	{
		return 12;
	}

	// Token: 0x060000E2 RID: 226 RVA: 0x000021D0 File Offset: 0x000015D0
	internal static uint AttrSingleInstance()
	{
		return 14;
	}

	// Token: 0x060000E3 RID: 227 RVA: 0x000021E0 File Offset: 0x000015E0
	internal static uint AttrGroupTable()
	{
		return 13;
	}

	// Token: 0x060000E4 RID: 228 RVA: 0x000021F0 File Offset: 0x000015F0
	internal unsafe static byte* _Unchecked<unsigned\u0020char\u0020*>(byte* _Src)
	{
		return _Src;
	}

	// Token: 0x060000E5 RID: 229 RVA: 0x00002200 File Offset: 0x00001600
	internal unsafe static global::std.random_access_iterator_tag* _Iter_cat<unsigned\u0020char\u0020*>(global::std.random_access_iterator_tag* A_0, byte** A_0)
	{
		return A_0;
	}

	// Token: 0x060000E6 RID: 230 RVA: 0x00003730 File Offset: 0x00002B30
	internal unsafe static void _Reverse<unsigned\u0020char\u0020*>(byte* _First, byte* _Last, global::std.bidirectional_iterator_tag __unnamed002)
	{
		if (_First != _Last)
		{
			do
			{
				_Last--;
				if (_First == _Last)
				{
					break;
				}
				byte b = *_First;
				*_First = *_Last;
				*_Last = b;
				_First++;
			}
			while (_First != _Last);
		}
	}

	// Token: 0x060000E7 RID: 231 RVA: 0x000048C0 File Offset: 0x00003CC0
	internal unsafe static uint GetAttribute(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V2>* A_0, global::FDISystem.ByteOrder byteOrder)
	{
		byte b = *(A_0 + 7) & 15;
		byte result;
		if (byteOrder == global::FDISystem.ByteOrder.BigEndian)
		{
			byte b2 = b;
			result = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020char,unsigned\u0020char>(b2, b2);
		}
		else
		{
			result = b;
		}
		return (uint)result;
	}

	// Token: 0x060000E8 RID: 232 RVA: 0x00002228 File Offset: 0x00001628
	internal static uint GetSize()
	{
		return 8;
	}

	// Token: 0x060000E9 RID: 233 RVA: 0x00002238 File Offset: 0x00001638
	[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
	internal unsafe static bool IsNotUsed(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V2>* A_0, global::FDISystem.ByteOrder byteOrder)
	{
		return ((*(A_0 + 6) == 7) ? 1 : 0) != 0;
	}

	// Token: 0x060000EA RID: 234 RVA: 0x000048E8 File Offset: 0x00003CE8
	[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
	internal unsafe static bool IsInvalid(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V2>* A_0, global::FDISystem.ByteOrder byteOrder)
	{
		byte b = *(A_0 + 6);
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
		return b3 == 6;
	}

	// Token: 0x060000EB RID: 235 RVA: 0x00004910 File Offset: 0x00003D10
	internal unsafe static uint GetLogicalBlockNum(global::FDISystem.FDIBlockInfo<FDISystem::FDI_TYPE_V2>* A_0, global::FDISystem.ByteOrder byteOrder)
	{
		byte b = *(A_0 + 9);
		byte result;
		if (byteOrder == global::FDISystem.ByteOrder.BigEndian)
		{
			byte b2 = b;
			result = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020char,unsigned\u0020char>(b2, b2);
		}
		else
		{
			result = b;
		}
		return (uint)result;
	}

	// Token: 0x060000EC RID: 236 RVA: 0x00005DFC File Offset: 0x000051FC
	[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
	internal unsafe static bool IsFreeBlock(global::FDISystem.FDIBlockInfo<FDISystem::FDI_TYPE_V2>* A_0, global::FDISystem.ByteOrder byteOrder)
	{
		byte b = *(A_0 + 8);
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
			byte b4 = *(A_0 + 8);
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
				byte b7 = *(A_0 + 8);
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
					byte b10 = *(A_0 + 8);
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
						goto IL_AB;
					}
				}
			}
		}
		ushort num = *(A_0 + 14);
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
			num4 = 0;
			goto IL_AD;
		}
		IL_AB:
		num4 = 1;
		IL_AD:
		return (byte)num4 != 0;
	}

	// Token: 0x060000ED RID: 237 RVA: 0x00003F30 File Offset: 0x00003330
	internal static uint FDIAdjustDataBytes<unsigned\u0020int,unsigned\u0020int>(uint destVar, uint srcVar, global::FDISystem.ByteOrder byteOrder)
	{
		if (byteOrder == global::FDISystem.ByteOrder.BigEndian)
		{
			return global::<Module>.FDISystem.ReverseBytes<unsigned\u0020int,unsigned\u0020int>(destVar, srcVar);
		}
		return srcVar;
	}

	// Token: 0x060000EE RID: 238 RVA: 0x00003F4C File Offset: 0x0000334C
	internal static byte FDIAdjustDataBytes<unsigned\u0020char,unsigned\u0020int>(byte destVar, uint srcVar, global::FDISystem.ByteOrder byteOrder)
	{
		if (byteOrder == global::FDISystem.ByteOrder.BigEndian)
		{
			return global::<Module>.FDISystem.ReverseBytes<unsigned\u0020char,unsigned\u0020int>(destVar, srcVar);
		}
		return (byte)srcVar;
	}

	// Token: 0x060000EF RID: 239 RVA: 0x00003F68 File Offset: 0x00003368
	internal static byte ReverseBytes<unsigned\u0020char>(byte var)
	{
		return global::<Module>.FDISystem.ReverseBytes<unsigned\u0020char,unsigned\u0020char>(var, var);
	}

	// Token: 0x060000F0 RID: 240 RVA: 0x00003B98 File Offset: 0x00002F98
	internal unsafe static ushort ReverseBytes<unsigned\u0020short,int>(ushort destVar, int srcVar)
	{
		ushort result = (ushort)srcVar;
		byte* ptr = ref result + 2;
		byte* ptr2 = (byte*)(&result);
		do
		{
			ptr--;
			if (ptr2 == ptr)
			{
				break;
			}
			byte b = *ptr2;
			*ptr2 = *ptr;
			*ptr = b;
			ptr2++;
		}
		while (ptr2 != ptr);
		return result;
	}

	// Token: 0x060000F1 RID: 241 RVA: 0x00004934 File Offset: 0x00003D34
	internal unsafe static uint GetAttribute(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V5>* A_0, global::FDISystem.ByteOrder byteOrder)
	{
		byte b = *(A_0 + 8) & 15;
		byte result;
		if (byteOrder == global::FDISystem.ByteOrder.BigEndian)
		{
			byte b2 = b;
			result = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020char,unsigned\u0020char>(b2, b2);
		}
		else
		{
			result = b;
		}
		return (uint)result;
	}

	// Token: 0x060000F2 RID: 242 RVA: 0x00002268 File Offset: 0x00001668
	internal static uint GetSize()
	{
		return 12;
	}

	// Token: 0x060000F3 RID: 243 RVA: 0x00002278 File Offset: 0x00001678
	[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
	internal unsafe static bool IsNotUsed(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V5>* A_0, global::FDISystem.ByteOrder byteOrder)
	{
		return false;
	}

	// Token: 0x060000F4 RID: 244 RVA: 0x00005EB8 File Offset: 0x000052B8
	[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
	internal unsafe static bool IsInvalid(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V5>* A_0, global::FDISystem.ByteOrder byteOrder)
	{
		ushort num = *(A_0 + 10);
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
		return num3 == 61440;
	}

	// Token: 0x060000F5 RID: 245 RVA: 0x00005EE8 File Offset: 0x000052E8
	internal unsafe static uint GetLogicalBlockNum(global::FDISystem.FDIBlockInfo<FDISystem::FDI_TYPE_V5>* A_0, global::FDISystem.ByteOrder byteOrder)
	{
		ushort num = *(A_0 + 8);
		ushort result;
		if (byteOrder == global::FDISystem.ByteOrder.BigEndian)
		{
			ushort num2 = num;
			result = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,unsigned\u0020short>(num2, num2);
		}
		else
		{
			result = num;
		}
		return (uint)result;
	}

	// Token: 0x060000F6 RID: 246 RVA: 0x00005F0C File Offset: 0x0000530C
	[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
	internal unsafe static bool IsFreeBlock(global::FDISystem.FDIBlockInfo<FDISystem::FDI_TYPE_V5>* A_0, global::FDISystem.ByteOrder byteOrder)
	{
		byte b = *(A_0 + 14);
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
			byte b4 = *(A_0 + 14);
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
				byte b7 = *(A_0 + 14);
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
					byte b10 = *(A_0 + 14);
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
						goto IL_AA;
					}
				}
			}
		}
		ushort num = *(A_0 + 12);
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
			num4 = 0;
			goto IL_AC;
		}
		IL_AA:
		num4 = 1;
		IL_AC:
		return (byte)num4 != 0;
	}

	// Token: 0x060000F7 RID: 247 RVA: 0x000034F4 File Offset: 0x000028F4
	internal unsafe static void destroy<struct\u0020FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T>(global::std._Wrap_alloc<std::allocator<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T>\u0020>* A_0, global::FDISystem.CP_FORMAT_TYPE_V2.CODEPLUG_MAP_T* _Ptr)
	{
	}

	// Token: 0x060000F8 RID: 248 RVA: 0x00003504 File Offset: 0x00002904
	internal unsafe static void destroy<struct\u0020FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T>(global::std._Wrap_alloc<std::allocator<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T>\u0020>* A_0, global::FDISystem.CP_FORMAT_TYPE_V5.CODEPLUG_MAP_T* _Ptr)
	{
	}

	// Token: 0x060000F9 RID: 249 RVA: 0x00002288 File Offset: 0x00001688
	internal unsafe static global::FDISystem.CP_FORMAT_TYPE_V2.CODEPLUG_MAP_T* forward<struct\u0020FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T\u0020&>(global::FDISystem.CP_FORMAT_TYPE_V2.CODEPLUG_MAP_T* _Arg)
	{
		return _Arg;
	}

	// Token: 0x060000FA RID: 250 RVA: 0x00003000 File Offset: 0x00002400
	internal unsafe static void construct<struct\u0020FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T,struct\u0020FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T\u0020&>(global::std.allocator<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T>* _Al, global::FDISystem.CP_FORMAT_TYPE_V2.CODEPLUG_MAP_T* _Ptr, global::FDISystem.CP_FORMAT_TYPE_V2.CODEPLUG_MAP_T* <_Args_0>)
	{
		try
		{
			if (_Ptr != null)
			{
				cpblk(_Ptr, <_Args_0>, 8);
			}
		}
		catch
		{
			global::<Module>.delete((void*)_Ptr, (void*)_Ptr);
			throw;
		}
	}

	// Token: 0x060000FB RID: 251 RVA: 0x00002298 File Offset: 0x00001698
	internal unsafe static global::FDISystem.CP_FORMAT_TYPE_V2.CODEPLUG_MAP_T* forward<struct\u0020FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T\u0020const\u0020&>(global::FDISystem.CP_FORMAT_TYPE_V2.CODEPLUG_MAP_T* _Arg)
	{
		return _Arg;
	}

	// Token: 0x060000FC RID: 252 RVA: 0x00003044 File Offset: 0x00002444
	internal unsafe static void construct<struct\u0020FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T,struct\u0020FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T\u0020const\u0020&>(global::std.allocator<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T>* _Al, global::FDISystem.CP_FORMAT_TYPE_V2.CODEPLUG_MAP_T* _Ptr, global::FDISystem.CP_FORMAT_TYPE_V2.CODEPLUG_MAP_T* <_Args_0>)
	{
		if (_Ptr != null)
		{
			cpblk(_Ptr, <_Args_0>, 8);
		}
	}

	// Token: 0x060000FD RID: 253 RVA: 0x0000305C File Offset: 0x0000245C
	internal unsafe static void construct<int,int>(global::std.allocator<int>* _Al, int* _Ptr, int* <_Args_0>)
	{
		try
		{
			if (_Ptr != null)
			{
				*_Ptr = *<_Args_0>;
			}
		}
		catch
		{
			global::<Module>.delete((void*)_Ptr, (void*)_Ptr);
			throw;
		}
	}

	// Token: 0x060000FE RID: 254 RVA: 0x000022A8 File Offset: 0x000016A8
	internal unsafe static global::FDISystem.CP_FORMAT_TYPE_V5.CODEPLUG_MAP_T* forward<struct\u0020FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T\u0020&>(global::FDISystem.CP_FORMAT_TYPE_V5.CODEPLUG_MAP_T* _Arg)
	{
		return _Arg;
	}

	// Token: 0x060000FF RID: 255 RVA: 0x0000309C File Offset: 0x0000249C
	internal unsafe static void construct<struct\u0020FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T,struct\u0020FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T\u0020&>(global::std.allocator<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T>* _Al, global::FDISystem.CP_FORMAT_TYPE_V5.CODEPLUG_MAP_T* _Ptr, global::FDISystem.CP_FORMAT_TYPE_V5.CODEPLUG_MAP_T* <_Args_0>)
	{
		try
		{
			if (_Ptr != null)
			{
				cpblk(_Ptr, <_Args_0>, 12);
			}
		}
		catch
		{
			global::<Module>.delete((void*)_Ptr, (void*)_Ptr);
			throw;
		}
	}

	// Token: 0x06000100 RID: 256 RVA: 0x000022B8 File Offset: 0x000016B8
	internal unsafe static global::FDISystem.CP_FORMAT_TYPE_V5.CODEPLUG_MAP_T* forward<struct\u0020FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T\u0020const\u0020&>(global::FDISystem.CP_FORMAT_TYPE_V5.CODEPLUG_MAP_T* _Arg)
	{
		return _Arg;
	}

	// Token: 0x06000101 RID: 257 RVA: 0x000030E0 File Offset: 0x000024E0
	internal unsafe static void construct<struct\u0020FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T,struct\u0020FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T\u0020const\u0020&>(global::std.allocator<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T>* _Al, global::FDISystem.CP_FORMAT_TYPE_V5.CODEPLUG_MAP_T* _Ptr, global::FDISystem.CP_FORMAT_TYPE_V5.CODEPLUG_MAP_T* <_Args_0>)
	{
		if (_Ptr != null)
		{
			cpblk(_Ptr, <_Args_0>, 12);
		}
	}

	// Token: 0x06000102 RID: 258 RVA: 0x00003F7C File Offset: 0x0000337C
	internal unsafe static global::FDISystem.CP_FORMAT_TYPE_V2.CODEPLUG_MAP_T* _Uninitialized_move<struct\u0020FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T\u0020*,struct\u0020FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T\u0020*,struct\u0020std::_Wrap_alloc<class\u0020std::allocator<struct\u0020FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T>\u0020>\u0020>(global::FDISystem.CP_FORMAT_TYPE_V2.CODEPLUG_MAP_T* _First, global::FDISystem.CP_FORMAT_TYPE_V2.CODEPLUG_MAP_T* _Last, global::FDISystem.CP_FORMAT_TYPE_V2.CODEPLUG_MAP_T* _Dest, global::std._Wrap_alloc<std::allocator<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T>\u0020>* _Al)
	{
		global::std._Nonscalar_ptr_iterator_tag nonscalar_ptr_iterator_tag;
		global::std._Nonscalar_ptr_iterator_tag _unnamed = nonscalar_ptr_iterator_tag;
		return global::<Module>.std._Uninit_move<struct\u0020FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T\u0020*,struct\u0020FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T\u0020*,class\u0020std::allocator<struct\u0020FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T>,struct\u0020FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T>(_First, _Last, _Dest, _Al, null, _unnamed);
	}

	// Token: 0x06000103 RID: 259 RVA: 0x00003514 File Offset: 0x00002914
	internal unsafe static int* _Uninitialized_move<int\u0020*,int\u0020*,struct\u0020std::_Wrap_alloc<class\u0020std::allocator<int>\u0020>\u0020>(int* _First, int* _Last, int* _Dest, global::std._Wrap_alloc<std::allocator<int>\u0020>* _Al)
	{
		uint num = (uint)((_Last - _First >> 2) * 4);
		return global::<Module>.memmove((void*)_Dest, (void*)_First, num) + num;
	}

	// Token: 0x06000104 RID: 260 RVA: 0x00003F98 File Offset: 0x00003398
	internal unsafe static global::FDISystem.CP_FORMAT_TYPE_V5.CODEPLUG_MAP_T* _Uninitialized_move<struct\u0020FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T\u0020*,struct\u0020FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T\u0020*,struct\u0020std::_Wrap_alloc<class\u0020std::allocator<struct\u0020FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T>\u0020>\u0020>(global::FDISystem.CP_FORMAT_TYPE_V5.CODEPLUG_MAP_T* _First, global::FDISystem.CP_FORMAT_TYPE_V5.CODEPLUG_MAP_T* _Last, global::FDISystem.CP_FORMAT_TYPE_V5.CODEPLUG_MAP_T* _Dest, global::std._Wrap_alloc<std::allocator<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T>\u0020>* _Al)
	{
		global::std._Nonscalar_ptr_iterator_tag nonscalar_ptr_iterator_tag;
		global::std._Nonscalar_ptr_iterator_tag _unnamed = nonscalar_ptr_iterator_tag;
		return global::<Module>.std._Uninit_move<struct\u0020FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T\u0020*,struct\u0020FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T\u0020*,class\u0020std::allocator<struct\u0020FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T>,struct\u0020FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T>(_First, _Last, _Dest, _Al, null, _unnamed);
	}

	// Token: 0x06000105 RID: 261 RVA: 0x000022C8 File Offset: 0x000016C8
	internal unsafe static void construct(global::std.allocator<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T>* A_0, global::FDISystem.CP_FORMAT_TYPE_V2.CODEPLUG_MAP_T* _Ptr, global::FDISystem.CP_FORMAT_TYPE_V2.CODEPLUG_MAP_T* _Val)
	{
		if (_Ptr != null)
		{
			cpblk(_Ptr, _Val, 8);
		}
	}

	// Token: 0x06000106 RID: 262 RVA: 0x000022E0 File Offset: 0x000016E0
	internal unsafe static void construct(global::std.allocator<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T>* A_0, global::FDISystem.CP_FORMAT_TYPE_V5.CODEPLUG_MAP_T* _Ptr, global::FDISystem.CP_FORMAT_TYPE_V5.CODEPLUG_MAP_T* _Val)
	{
		if (_Ptr != null)
		{
			cpblk(_Ptr, _Val, 12);
		}
	}

	// Token: 0x06000107 RID: 263 RVA: 0x000022FC File Offset: 0x000016FC
	internal unsafe static uint GetTable(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V2>* A_0, global::FDISystem.ByteOrder byteOrder)
	{
		return 0U;
	}

	// Token: 0x06000108 RID: 264 RVA: 0x0000230C File Offset: 0x0000170C
	internal static uint AttrSequenceTable()
	{
		return 12;
	}

	// Token: 0x06000109 RID: 265 RVA: 0x0000231C File Offset: 0x0000171C
	internal static uint AttrDataFragment()
	{
		return 0;
	}

	// Token: 0x0600010A RID: 266 RVA: 0x00007ADC File Offset: 0x00006EDC
	internal unsafe static uint GetTable(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V5>* A_0, global::FDISystem.ByteOrder byteOrder)
	{
		ushort num = *(A_0 + 2);
		ushort result;
		if (byteOrder == global::FDISystem.ByteOrder.BigEndian)
		{
			ushort num2 = num;
			result = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,unsigned\u0020short>(num2, num2);
		}
		else
		{
			result = num;
		}
		return (uint)result;
	}

	// Token: 0x0600010B RID: 267 RVA: 0x0000232C File Offset: 0x0000172C
	internal static uint AttrSequenceTable()
	{
		return 0;
	}

	// Token: 0x0600010C RID: 268 RVA: 0x0000233C File Offset: 0x0000173C
	internal static uint AttrDataFragment()
	{
		return 2;
	}

	// Token: 0x0600010D RID: 269 RVA: 0x0000495C File Offset: 0x00003D5C
	internal unsafe static int GetGrpSeqLogBlk(global::FDISystem.FDIGroupSequenceTable<FDISystem::FDI_TYPE_V2>* A_0, global::FDISystem.ByteOrder byteOrder)
	{
		byte b = *A_0;
		byte result;
		if (byteOrder == global::FDISystem.ByteOrder.BigEndian)
		{
			byte b2 = b;
			result = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020char,unsigned\u0020char>(b2, b2);
		}
		else
		{
			result = b;
		}
		return (int)result;
	}

	// Token: 0x0600010E RID: 270 RVA: 0x00005FC8 File Offset: 0x000053C8
	internal unsafe static int GetGrpSeqInstance(global::FDISystem.FDIGroupSequenceTable<FDISystem::FDI_TYPE_V2>* A_0, global::FDISystem.ByteOrder byteOrder)
	{
		ushort num = *(A_0 + 2);
		ushort result;
		if (byteOrder == global::FDISystem.ByteOrder.BigEndian)
		{
			ushort num2 = num;
			result = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,unsigned\u0020short>(num2, num2);
		}
		else
		{
			result = num;
		}
		return (int)result;
	}

	// Token: 0x0600010F RID: 271 RVA: 0x00004980 File Offset: 0x00003D80
	internal unsafe static int GetGrpSeqSize(global::FDISystem.FDIGroupSequenceTable<FDISystem::FDI_TYPE_V2>* A_0, global::FDISystem.ByteOrder byteOrder)
	{
		byte b = *(A_0 + 4);
		byte result;
		if (byteOrder == global::FDISystem.ByteOrder.BigEndian)
		{
			byte b2 = b;
			result = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020char,unsigned\u0020char>(b2, b2);
		}
		else
		{
			result = b;
		}
		return (int)result;
	}

	// Token: 0x06000110 RID: 272 RVA: 0x000049A4 File Offset: 0x00003DA4
	[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
	internal unsafe static bool GrpSeqStatusIsEmpty(global::FDISystem.FDIGroupSequenceTable<FDISystem::FDI_TYPE_V2>* A_0, global::FDISystem.ByteOrder byteOrder)
	{
		byte b = *(A_0 + 1);
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
		return ((b3 == byte.MaxValue) ? 1 : 0) != 0;
	}

	// Token: 0x06000111 RID: 273 RVA: 0x000049D0 File Offset: 0x00003DD0
	[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
	internal unsafe static bool GrpSeqStatusIsValid(global::FDISystem.FDIGroupSequenceTable<FDISystem::FDI_TYPE_V2>* A_0, global::FDISystem.ByteOrder byteOrder)
	{
		byte b = *(A_0 + 1);
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
		return ((b3 == 31) ? 1 : 0) != 0;
	}

	// Token: 0x06000112 RID: 274 RVA: 0x0000234C File Offset: 0x0000174C
	internal static int GetTableEntrySize()
	{
		return 10;
	}

	// Token: 0x06000113 RID: 275 RVA: 0x00005FEC File Offset: 0x000053EC
	internal unsafe static int GetGrpSeqLogBlk(global::FDISystem.FDIGroupSequenceTable<FDISystem::FDI_TYPE_V5>* A_0, global::FDISystem.ByteOrder byteOrder)
	{
		ushort num = *A_0;
		ushort result;
		if (byteOrder == global::FDISystem.ByteOrder.BigEndian)
		{
			ushort num2 = num;
			result = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,unsigned\u0020short>(num2, num2);
		}
		else
		{
			result = num;
		}
		return (int)result;
	}

	// Token: 0x06000114 RID: 276 RVA: 0x00006010 File Offset: 0x00005410
	internal unsafe static int GetGrpSeqInstance(global::FDISystem.FDIGroupSequenceTable<FDISystem::FDI_TYPE_V5>* A_0, global::FDISystem.ByteOrder byteOrder)
	{
		ushort num = *(A_0 + 2);
		ushort result;
		if (byteOrder == global::FDISystem.ByteOrder.BigEndian)
		{
			ushort num2 = num;
			result = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,unsigned\u0020short>(num2, num2);
		}
		else
		{
			result = num;
		}
		return (int)result;
	}

	// Token: 0x06000115 RID: 277 RVA: 0x00006034 File Offset: 0x00005434
	internal unsafe static int GetGrpSeqSize(global::FDISystem.FDIGroupSequenceTable<FDISystem::FDI_TYPE_V5>* A_0, global::FDISystem.ByteOrder byteOrder)
	{
		ushort num = *(A_0 + 8);
		ushort result;
		if (byteOrder == global::FDISystem.ByteOrder.BigEndian)
		{
			ushort num2 = num;
			result = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,unsigned\u0020short>(num2, num2);
		}
		else
		{
			result = num;
		}
		return (int)result;
	}

	// Token: 0x06000116 RID: 278 RVA: 0x000049F8 File Offset: 0x00003DF8
	[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
	internal unsafe static bool GrpSeqStatusIsEmpty(global::FDISystem.FDIGroupSequenceTable<FDISystem::FDI_TYPE_V5>* A_0, global::FDISystem.ByteOrder byteOrder)
	{
		byte b = *(A_0 + 10);
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
		return ((b3 == byte.MaxValue) ? 1 : 0) != 0;
	}

	// Token: 0x06000117 RID: 279 RVA: 0x00004A24 File Offset: 0x00003E24
	[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
	internal unsafe static bool GrpSeqStatusIsValid(global::FDISystem.FDIGroupSequenceTable<FDISystem::FDI_TYPE_V5>* A_0, global::FDISystem.ByteOrder byteOrder)
	{
		byte b = *(A_0 + 10);
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
		return ((b3 == 192) ? 1 : 0) != 0;
	}

	// Token: 0x06000118 RID: 280 RVA: 0x0000235C File Offset: 0x0000175C
	internal static int GetTableEntrySize()
	{
		return 12;
	}

	// Token: 0x06000119 RID: 281 RVA: 0x00003534 File Offset: 0x00002934
	internal unsafe static void iter_swap<unsigned\u0020char\u0020*,unsigned\u0020char\u0020*>(byte* _Left, byte* _Right)
	{
		byte b = *_Left;
		*_Left = *_Right;
		*_Right = b;
	}

	// Token: 0x0600011A RID: 282 RVA: 0x0000617C File Offset: 0x0000557C
	internal unsafe static uint GetId(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V2>* A_0, global::FDISystem.ByteOrder byteOrder)
	{
		ushort num = *A_0;
		ushort result;
		if (byteOrder == global::FDISystem.ByteOrder.BigEndian)
		{
			ushort num2 = num;
			result = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,unsigned\u0020short>(num2, num2);
		}
		else
		{
			result = num;
		}
		return (uint)result;
	}

	// Token: 0x0600011B RID: 283 RVA: 0x00004A50 File Offset: 0x00003E50
	internal unsafe static uint GetType(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V2>* A_0, global::FDISystem.ByteOrder byteOrder)
	{
		byte b = (byte)((uint)(*(A_0 + 7)) >> 4);
		byte result;
		if (byteOrder == global::FDISystem.ByteOrder.BigEndian)
		{
			byte b2 = b;
			result = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020char,unsigned\u0020char>(b2, b2);
		}
		else
		{
			result = b;
		}
		return (uint)result;
	}

	// Token: 0x0600011C RID: 284 RVA: 0x000061A0 File Offset: 0x000055A0
	internal unsafe static uint GetSize(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V2>* A_0, global::FDISystem.ByteOrder byteOrder)
	{
		ushort num = *(A_0 + 2);
		ushort result;
		if (byteOrder == global::FDISystem.ByteOrder.BigEndian)
		{
			ushort num2 = num;
			result = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,unsigned\u0020short>(num2, num2);
		}
		else
		{
			result = num;
		}
		return (uint)result;
	}

	// Token: 0x0600011D RID: 285 RVA: 0x00003BCC File Offset: 0x00002FCC
	internal unsafe static uint ReverseBytes<unsigned\u0020int,unsigned\u0020int>(uint destVar, uint srcVar)
	{
		uint result = srcVar;
		byte* ptr = ref result + 4;
		byte* ptr2 = (byte*)(&result);
		do
		{
			ptr--;
			if (ptr2 == ptr)
			{
				break;
			}
			byte b = *ptr2;
			*ptr2 = *ptr;
			*ptr = b;
			ptr2++;
		}
		while (ptr2 != ptr);
		return result;
	}

	// Token: 0x0600011E RID: 286 RVA: 0x00003C00 File Offset: 0x00003000
	internal unsafe static byte ReverseBytes<unsigned\u0020char,unsigned\u0020int>(byte destVar, uint srcVar)
	{
		byte result = (byte)srcVar;
		byte* ptr = ref result + 1;
		byte* ptr2 = &result;
		do
		{
			ptr--;
			if (ptr2 == ptr)
			{
				break;
			}
			byte b = *ptr2;
			*ptr2 = *ptr;
			*ptr = b;
			ptr2++;
		}
		while (ptr2 != ptr);
		return result;
	}

	// Token: 0x0600011F RID: 287 RVA: 0x00003C34 File Offset: 0x00003034
	internal unsafe static byte ReverseBytes<unsigned\u0020char,unsigned\u0020char>(byte destVar, byte srcVar)
	{
		byte result = srcVar;
		byte* ptr = ref result + 1;
		byte* ptr2 = &result;
		do
		{
			ptr--;
			if (ptr2 == ptr)
			{
				break;
			}
			byte b = *ptr2;
			*ptr2 = *ptr;
			*ptr = b;
			ptr2++;
		}
		while (ptr2 != ptr);
		return result;
	}

	// Token: 0x06000120 RID: 288 RVA: 0x000062E4 File Offset: 0x000056E4
	internal unsafe static uint GetId(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V5>* A_0, global::FDISystem.ByteOrder byteOrder)
	{
		ushort num = *A_0;
		ushort result;
		if (byteOrder == global::FDISystem.ByteOrder.BigEndian)
		{
			ushort num2 = num;
			result = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,unsigned\u0020short>(num2, num2);
		}
		else
		{
			result = num;
		}
		return (uint)result;
	}

	// Token: 0x06000121 RID: 289 RVA: 0x00004A78 File Offset: 0x00003E78
	internal unsafe static uint GetType(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V5>* A_0, global::FDISystem.ByteOrder byteOrder)
	{
		byte b = (byte)((uint)(*(A_0 + 8)) >> 4);
		byte result;
		if (byteOrder == global::FDISystem.ByteOrder.BigEndian)
		{
			byte b2 = b;
			result = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020char,unsigned\u0020char>(b2, b2);
		}
		else
		{
			result = b;
		}
		return (uint)result;
	}

	// Token: 0x06000122 RID: 290 RVA: 0x00006308 File Offset: 0x00005708
	internal unsafe static uint GetSize(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V5>* A_0, global::FDISystem.ByteOrder byteOrder)
	{
		ushort num = *(A_0 + 4);
		ushort result;
		if (byteOrder == global::FDISystem.ByteOrder.BigEndian)
		{
			ushort num2 = num;
			result = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,unsigned\u0020short>(num2, num2);
		}
		else
		{
			result = num;
		}
		return (uint)result;
	}

	// Token: 0x06000123 RID: 291 RVA: 0x0000312C File Offset: 0x0000252C
	internal unsafe static void destroy<struct\u0020FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T>(global::std.allocator<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T>* _Al, global::FDISystem.CP_FORMAT_TYPE_V2.CODEPLUG_MAP_T* _Ptr)
	{
	}

	// Token: 0x06000124 RID: 292 RVA: 0x0000313C File Offset: 0x0000253C
	internal unsafe static void destroy<struct\u0020FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T>(global::std.allocator<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T>* _Al, global::FDISystem.CP_FORMAT_TYPE_V5.CODEPLUG_MAP_T* _Ptr)
	{
	}

	// Token: 0x06000125 RID: 293 RVA: 0x0000239C File Offset: 0x0000179C
	internal unsafe static void construct<struct\u0020FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T,struct\u0020FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T\u0020&>(global::std.allocator<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T>* A_0, global::FDISystem.CP_FORMAT_TYPE_V2.CODEPLUG_MAP_T* _Ptr, global::FDISystem.CP_FORMAT_TYPE_V2.CODEPLUG_MAP_T* <_Args_0>)
	{
		try
		{
			if (_Ptr != null)
			{
				cpblk(_Ptr, <_Args_0>, 8);
			}
		}
		catch
		{
			global::<Module>.delete((void*)_Ptr, (void*)_Ptr);
			throw;
		}
	}

	// Token: 0x06000126 RID: 294 RVA: 0x000023E0 File Offset: 0x000017E0
	internal unsafe static void construct<int,int>(global::std.allocator<int>* A_0, int* _Ptr, int* <_Args_0>)
	{
		try
		{
			if (_Ptr != null)
			{
				*_Ptr = *<_Args_0>;
			}
		}
		catch
		{
			global::<Module>.delete((void*)_Ptr, (void*)_Ptr);
			throw;
		}
	}

	// Token: 0x06000127 RID: 295 RVA: 0x00002420 File Offset: 0x00001820
	internal unsafe static void construct<struct\u0020FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T,struct\u0020FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T\u0020&>(global::std.allocator<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T>* A_0, global::FDISystem.CP_FORMAT_TYPE_V5.CODEPLUG_MAP_T* _Ptr, global::FDISystem.CP_FORMAT_TYPE_V5.CODEPLUG_MAP_T* <_Args_0>)
	{
		try
		{
			if (_Ptr != null)
			{
				cpblk(_Ptr, <_Args_0>, 12);
			}
		}
		catch
		{
			global::<Module>.delete((void*)_Ptr, (void*)_Ptr);
			throw;
		}
	}

	// Token: 0x06000128 RID: 296 RVA: 0x00002464 File Offset: 0x00001864
	internal unsafe static global::FDISystem.CP_FORMAT_TYPE_V2.CODEPLUG_MAP_T* _Unchecked<struct\u0020FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T\u0020*>(global::FDISystem.CP_FORMAT_TYPE_V2.CODEPLUG_MAP_T* _Src)
	{
		return _Src;
	}

	// Token: 0x06000129 RID: 297 RVA: 0x00003C68 File Offset: 0x00003068
	internal unsafe static global::FDISystem.CP_FORMAT_TYPE_V2.CODEPLUG_MAP_T* _Uninit_move<struct\u0020FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T\u0020*,struct\u0020FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T\u0020*,struct\u0020std::_Wrap_alloc<class\u0020std::allocator<struct\u0020FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T>\u0020>\u0020>(global::FDISystem.CP_FORMAT_TYPE_V2.CODEPLUG_MAP_T* _First, global::FDISystem.CP_FORMAT_TYPE_V2.CODEPLUG_MAP_T* _Last, global::FDISystem.CP_FORMAT_TYPE_V2.CODEPLUG_MAP_T* _Dest, global::std._Wrap_alloc<std::allocator<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T>\u0020>* _Al)
	{
		global::std._Nonscalar_ptr_iterator_tag nonscalar_ptr_iterator_tag;
		global::std._Nonscalar_ptr_iterator_tag _unnamed = nonscalar_ptr_iterator_tag;
		return global::<Module>.std._Uninit_move<struct\u0020FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T\u0020*,struct\u0020FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T\u0020*,class\u0020std::allocator<struct\u0020FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T>,struct\u0020FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T>(_First, _Last, _Dest, _Al, null, _unnamed);
	}

	// Token: 0x0600012A RID: 298 RVA: 0x00002474 File Offset: 0x00001874
	internal unsafe static global::FDISystem.CP_FORMAT_TYPE_V2.CODEPLUG_MAP_T** _Rechecked<struct\u0020FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T\u0020*,struct\u0020FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T\u0020*>(global::FDISystem.CP_FORMAT_TYPE_V2.CODEPLUG_MAP_T** _Dest, global::FDISystem.CP_FORMAT_TYPE_V2.CODEPLUG_MAP_T* _Src)
	{
		*_Dest = _Src;
		return _Dest;
	}

	// Token: 0x0600012B RID: 299 RVA: 0x00002488 File Offset: 0x00001888
	internal unsafe static int* _Unchecked<int\u0020*>(int* _Src)
	{
		return _Src;
	}

	// Token: 0x0600012C RID: 300 RVA: 0x0000314C File Offset: 0x0000254C
	internal unsafe static int* _Uninit_move<int\u0020*,int\u0020*,struct\u0020std::_Wrap_alloc<class\u0020std::allocator<int>\u0020>\u0020>(int* _First, int* _Last, int* _Dest, global::std._Wrap_alloc<std::allocator<int>\u0020>* _Al)
	{
		uint num = (uint)((_Last - _First >> 2) * 4);
		return global::<Module>.memmove((void*)_Dest, (void*)_First, num) + num;
	}

	// Token: 0x0600012D RID: 301 RVA: 0x00002498 File Offset: 0x00001898
	internal unsafe static int** _Rechecked<int\u0020*,int\u0020*>(int** _Dest, int* _Src)
	{
		*_Dest = _Src;
		return _Dest;
	}

	// Token: 0x0600012E RID: 302 RVA: 0x000024AC File Offset: 0x000018AC
	internal unsafe static global::FDISystem.CP_FORMAT_TYPE_V5.CODEPLUG_MAP_T* _Unchecked<struct\u0020FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T\u0020*>(global::FDISystem.CP_FORMAT_TYPE_V5.CODEPLUG_MAP_T* _Src)
	{
		return _Src;
	}

	// Token: 0x0600012F RID: 303 RVA: 0x00003C84 File Offset: 0x00003084
	internal unsafe static global::FDISystem.CP_FORMAT_TYPE_V5.CODEPLUG_MAP_T* _Uninit_move<struct\u0020FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T\u0020*,struct\u0020FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T\u0020*,struct\u0020std::_Wrap_alloc<class\u0020std::allocator<struct\u0020FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T>\u0020>\u0020>(global::FDISystem.CP_FORMAT_TYPE_V5.CODEPLUG_MAP_T* _First, global::FDISystem.CP_FORMAT_TYPE_V5.CODEPLUG_MAP_T* _Last, global::FDISystem.CP_FORMAT_TYPE_V5.CODEPLUG_MAP_T* _Dest, global::std._Wrap_alloc<std::allocator<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T>\u0020>* _Al)
	{
		global::std._Nonscalar_ptr_iterator_tag nonscalar_ptr_iterator_tag;
		global::std._Nonscalar_ptr_iterator_tag _unnamed = nonscalar_ptr_iterator_tag;
		return global::<Module>.std._Uninit_move<struct\u0020FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T\u0020*,struct\u0020FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T\u0020*,class\u0020std::allocator<struct\u0020FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T>,struct\u0020FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T>(_First, _Last, _Dest, _Al, null, _unnamed);
	}

	// Token: 0x06000130 RID: 304 RVA: 0x000024BC File Offset: 0x000018BC
	internal unsafe static global::FDISystem.CP_FORMAT_TYPE_V5.CODEPLUG_MAP_T** _Rechecked<struct\u0020FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T\u0020*,struct\u0020FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T\u0020*>(global::FDISystem.CP_FORMAT_TYPE_V5.CODEPLUG_MAP_T** _Dest, global::FDISystem.CP_FORMAT_TYPE_V5.CODEPLUG_MAP_T* _Src)
	{
		*_Dest = _Src;
		return _Dest;
	}

	// Token: 0x06000131 RID: 305 RVA: 0x0000316C File Offset: 0x0000256C
	internal unsafe static void swap<unsigned\u0020char>(byte* _Left, byte* _Right)
	{
		byte b = *_Left;
		*_Left = *_Right;
		*_Right = b;
	}

	// Token: 0x06000132 RID: 306 RVA: 0x00004AA0 File Offset: 0x00003EA0
	internal unsafe static void SetId(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V2>* A_0, uint nValue, global::FDISystem.ByteOrder byteOrder)
	{
		ushort destVar = *A_0;
		ushort num;
		if (byteOrder == global::FDISystem.ByteOrder.BigEndian)
		{
			num = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,unsigned\u0020int>(destVar, nValue);
		}
		else
		{
			num = (ushort)nValue;
		}
		*A_0 = (short)num;
	}

	// Token: 0x06000133 RID: 307 RVA: 0x00003FB4 File Offset: 0x000033B4
	internal unsafe static void SetStatusValid(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V2>* A_0, global::FDISystem.ByteOrder byteOrder)
	{
		byte destVar = *(A_0 + 6);
		byte b;
		if (byteOrder == global::FDISystem.ByteOrder.BigEndian)
		{
			b = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020char,unsigned\u0020int>(destVar, 30U);
		}
		else
		{
			b = 30;
		}
		*(A_0 + 6) = b;
	}

	// Token: 0x06000134 RID: 308 RVA: 0x00003FE0 File Offset: 0x000033E0
	internal unsafe static void SetType(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V2>* A_0, uint nValue, global::FDISystem.ByteOrder byteOrder)
	{
		byte destVar = (byte)((uint)(*(A_0 + 7)) >> 4);
		byte b;
		if (byteOrder == global::FDISystem.ByteOrder.BigEndian)
		{
			b = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020char,unsigned\u0020int>(destVar, nValue);
		}
		else
		{
			b = (byte)nValue;
		}
		*(A_0 + 7) = (byte)((int)b << 4 | (int)(*(A_0 + 7) & 15));
	}

	// Token: 0x06000135 RID: 309 RVA: 0x00004014 File Offset: 0x00003414
	internal unsafe static void SetAttribute(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V2>* A_0, uint nValue, global::FDISystem.ByteOrder byteOrder)
	{
		byte destVar = *(A_0 + 7) & 15;
		byte b;
		if (byteOrder == global::FDISystem.ByteOrder.BigEndian)
		{
			b = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020char,unsigned\u0020int>(destVar, nValue);
		}
		else
		{
			b = (byte)nValue;
		}
		*(A_0 + 7) = (((b ^ *(A_0 + 7)) & 15) ^ *(A_0 + 7));
	}

	// Token: 0x06000136 RID: 310 RVA: 0x00004AC4 File Offset: 0x00003EC4
	internal unsafe static void SetSize(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V2>* A_0, uint nValue, global::FDISystem.ByteOrder byteOrder)
	{
		ushort destVar = *(A_0 + 2);
		ushort num;
		if (byteOrder == global::FDISystem.ByteOrder.BigEndian)
		{
			num = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,unsigned\u0020int>(destVar, nValue);
		}
		else
		{
			num = (ushort)nValue;
		}
		*(A_0 + 2) = (short)num;
	}

	// Token: 0x06000137 RID: 311 RVA: 0x00004AEC File Offset: 0x00003EEC
	internal unsafe static void SetOffset(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V2>* A_0, uint nValue, global::FDISystem.ByteOrder byteOrder)
	{
		ushort destVar = *(A_0 + 4);
		ushort num;
		if (byteOrder == global::FDISystem.ByteOrder.BigEndian)
		{
			num = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,unsigned\u0020int>(destVar, nValue);
		}
		else
		{
			num = (ushort)nValue;
		}
		*(A_0 + 4) = (short)num;
	}

	// Token: 0x06000138 RID: 312 RVA: 0x0000257C File Offset: 0x0000197C
	internal unsafe static void SetTable(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V2>* A_0, uint table, global::FDISystem.ByteOrder byteOrder)
	{
	}

	// Token: 0x06000139 RID: 313 RVA: 0x0000258C File Offset: 0x0000198C
	internal unsafe static void SetPad(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V2>* A_0, global::FDISystem.ByteOrder byteOrder)
	{
	}

	// Token: 0x0600013A RID: 314 RVA: 0x00004B14 File Offset: 0x00003F14
	[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
	internal unsafe static bool IsValid(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V2>* A_0, global::FDISystem.ByteOrder byteOrder)
	{
		byte b = *(A_0 + 6);
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
		return b3 == 30;
	}

	// Token: 0x0600013B RID: 315 RVA: 0x00004B40 File Offset: 0x00003F40
	internal unsafe static void SetId(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V5>* A_0, uint nValue, global::FDISystem.ByteOrder byteOrder)
	{
		ushort destVar = *A_0;
		ushort num;
		if (byteOrder == global::FDISystem.ByteOrder.BigEndian)
		{
			num = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,unsigned\u0020int>(destVar, nValue);
		}
		else
		{
			num = (ushort)nValue;
		}
		*A_0 = (short)num;
	}

	// Token: 0x0600013C RID: 316 RVA: 0x00004B64 File Offset: 0x00003F64
	internal unsafe static void SetStatusValid(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V5>* A_0, global::FDISystem.ByteOrder byteOrder)
	{
		ushort destVar = *(A_0 + 10);
		ushort num;
		if (byteOrder == global::FDISystem.ByteOrder.BigEndian)
		{
			num = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,unsigned\u0020int>(destVar, 65280U);
		}
		else
		{
			num = 65280;
		}
		*(A_0 + 10) = (short)num;
	}

	// Token: 0x0600013D RID: 317 RVA: 0x0000404C File Offset: 0x0000344C
	internal unsafe static void SetType(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V5>* A_0, uint nValue, global::FDISystem.ByteOrder byteOrder)
	{
		byte destVar = (byte)((uint)(*(A_0 + 8)) >> 4);
		byte b;
		if (byteOrder == global::FDISystem.ByteOrder.BigEndian)
		{
			b = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020char,unsigned\u0020int>(destVar, nValue);
		}
		else
		{
			b = (byte)nValue;
		}
		*(A_0 + 8) = (byte)((int)b << 4 | (int)(*(A_0 + 8) & 15));
	}

	// Token: 0x0600013E RID: 318 RVA: 0x00004080 File Offset: 0x00003480
	internal unsafe static void SetAttribute(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V5>* A_0, uint nValue, global::FDISystem.ByteOrder byteOrder)
	{
		byte destVar = *(A_0 + 8) & 15;
		byte b;
		if (byteOrder == global::FDISystem.ByteOrder.BigEndian)
		{
			b = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020char,unsigned\u0020int>(destVar, nValue);
		}
		else
		{
			b = (byte)nValue;
		}
		*(A_0 + 8) = (((b ^ *(A_0 + 8)) & 15) ^ *(A_0 + 8));
	}

	// Token: 0x0600013F RID: 319 RVA: 0x00004B98 File Offset: 0x00003F98
	internal unsafe static void SetSize(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V5>* A_0, uint nValue, global::FDISystem.ByteOrder byteOrder)
	{
		ushort destVar = *(A_0 + 4);
		ushort num;
		if (byteOrder == global::FDISystem.ByteOrder.BigEndian)
		{
			num = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,unsigned\u0020int>(destVar, nValue);
		}
		else
		{
			num = (ushort)nValue;
		}
		*(A_0 + 4) = (short)num;
	}

	// Token: 0x06000140 RID: 320 RVA: 0x00004BC0 File Offset: 0x00003FC0
	internal unsafe static void SetOffset(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V5>* A_0, uint nValue, global::FDISystem.ByteOrder byteOrder)
	{
		ushort destVar = *(A_0 + 6);
		ushort num;
		if (byteOrder == global::FDISystem.ByteOrder.BigEndian)
		{
			num = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,unsigned\u0020int>(destVar, nValue);
		}
		else
		{
			num = (ushort)nValue;
		}
		*(A_0 + 6) = (short)num;
	}

	// Token: 0x06000141 RID: 321 RVA: 0x000067F8 File Offset: 0x00005BF8
	internal unsafe static void SetTable(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V5>* A_0, uint table, global::FDISystem.ByteOrder byteOrder)
	{
		ushort destVar = *(A_0 + 2);
		ushort num;
		if (byteOrder == global::FDISystem.ByteOrder.BigEndian)
		{
			num = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020short,unsigned\u0020int>(destVar, table);
		}
		else
		{
			num = (ushort)table;
		}
		*(A_0 + 2) = (short)num;
	}

	// Token: 0x06000142 RID: 322 RVA: 0x00006820 File Offset: 0x00005C20
	internal unsafe static void SetPad(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V5>* A_0, global::FDISystem.ByteOrder byteOrder)
	{
		byte destVar = *(A_0 + 9);
		byte b;
		if (byteOrder == global::FDISystem.ByteOrder.BigEndian)
		{
			b = global::<Module>.FDISystem.ReverseBytes<unsigned\u0020char,int>(destVar, 0);
		}
		else
		{
			b = 0;
		}
		*(A_0 + 9) = b;
	}

	// Token: 0x06000143 RID: 323 RVA: 0x0000684C File Offset: 0x00005C4C
	[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
	internal unsafe static bool IsValid(global::FDISystem.FDIUnitHeader<FDISystem::FDI_TYPE_V5>* A_0, global::FDISystem.ByteOrder byteOrder)
	{
		ushort num = *(A_0 + 10);
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
		return num3 == 65280;
	}

	// Token: 0x06000144 RID: 324 RVA: 0x00002634 File Offset: 0x00001A34
	internal unsafe static void destroy<struct\u0020FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T>(global::std.allocator<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T>* A_0, global::FDISystem.CP_FORMAT_TYPE_V2.CODEPLUG_MAP_T* _Ptr)
	{
	}

	// Token: 0x06000145 RID: 325 RVA: 0x00002644 File Offset: 0x00001A44
	internal unsafe static void destroy<struct\u0020FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T>(global::std.allocator<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T>* A_0, global::FDISystem.CP_FORMAT_TYPE_V5.CODEPLUG_MAP_T* _Ptr)
	{
	}

	// Token: 0x06000146 RID: 326 RVA: 0x00002654 File Offset: 0x00001A54
	internal unsafe static global::FDISystem.CP_FORMAT_TYPE_V2.CODEPLUG_MAP_T* _Val_type<struct\u0020FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T\u0020*>(global::FDISystem.CP_FORMAT_TYPE_V2.CODEPLUG_MAP_T* A_0)
	{
		return 0;
	}

	// Token: 0x06000147 RID: 327 RVA: 0x00003760 File Offset: 0x00002B60
	internal unsafe static global::FDISystem.CP_FORMAT_TYPE_V2.CODEPLUG_MAP_T* _Uninit_move<struct\u0020FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T\u0020*,struct\u0020FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T\u0020*,class\u0020std::allocator<struct\u0020FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T>,struct\u0020FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T>(global::FDISystem.CP_FORMAT_TYPE_V2.CODEPLUG_MAP_T* _First, global::FDISystem.CP_FORMAT_TYPE_V2.CODEPLUG_MAP_T* _Last, global::FDISystem.CP_FORMAT_TYPE_V2.CODEPLUG_MAP_T* _Dest, global::std._Wrap_alloc<std::allocator<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T>\u0020>* _Al, global::FDISystem.CP_FORMAT_TYPE_V2.CODEPLUG_MAP_T* __unnamed004, global::std._Nonscalar_ptr_iterator_tag __unnamed005)
	{
		int num = (int)stackalloc byte[global::<Module>.__CxxQueryExceptionSize()];
		global::FDISystem.CP_FORMAT_TYPE_V2.CODEPLUG_MAP_T* ptr = _Dest;
		uint exceptionCode;
		try
		{
			while (_First != _Last)
			{
				global::FDISystem.CP_FORMAT_TYPE_V2.CODEPLUG_MAP_T* a_ = _Dest;
				try
				{
					if (_Dest != null)
					{
						cpblk(_Dest, _First, 8);
					}
				}
				catch
				{
					global::<Module>.delete((void*)a_, (void*)_Dest);
					throw;
				}
				_Dest += 8 / sizeof(global::FDISystem.CP_FORMAT_TYPE_V2.CODEPLUG_MAP_T);
				_First += 8 / sizeof(global::FDISystem.CP_FORMAT_TYPE_V2.CODEPLUG_MAP_T);
			}
		}
		catch when (delegate
		{
			// Failed to create a 'catch-when' expression
			exceptionCode = (uint)global::System.Runtime.InteropServices.Marshal.GetExceptionCode();
			endfilter(global::<Module>.__CxxExceptionFilter(global::System.Runtime.InteropServices.Marshal.GetExceptionPointers(), null, 0, null) != null);
		})
		{
			uint num2 = 0U;
			global::<Module>.__CxxRegisterExceptionObject(global::System.Runtime.InteropServices.Marshal.GetExceptionPointers(), num);
			try
			{
				try
				{
					while (ptr != _Dest)
					{
						ptr += 8 / sizeof(global::FDISystem.CP_FORMAT_TYPE_V2.CODEPLUG_MAP_T);
					}
					global::<Module>._CxxThrowException(null, null);
				}
				catch when (delegate
				{
					// Failed to create a 'catch-when' expression
					num2 = global::<Module>.__CxxDetectRethrow(global::System.Runtime.InteropServices.Marshal.GetExceptionPointers());
					endfilter(num2 != 0U);
				})
				{
				}
				if (num2 != 0U)
				{
					throw;
				}
			}
			finally
			{
				global::<Module>.__CxxUnregisterExceptionObject(num, (int)num2);
			}
		}
		return _Dest;
	}

	// Token: 0x06000148 RID: 328 RVA: 0x00002664 File Offset: 0x00001A64
	internal unsafe static int* _Val_type<int\u0020*>(int* A_0)
	{
		return 0;
	}

	// Token: 0x06000149 RID: 329 RVA: 0x00002674 File Offset: 0x00001A74
	internal unsafe static int* _Uninit_move<int,int,int>(int* _First, int* _Last, int* _Dest, global::std._Wrap_alloc<std::allocator<int>\u0020>* __unnamed003, int* __unnamed004, global::std._Scalar_ptr_iterator_tag __unnamed005)
	{
		uint num = (uint)((_Last - _First >> 2) * 4);
		return global::<Module>.memmove((void*)_Dest, (void*)_First, num) + num;
	}

	// Token: 0x0600014A RID: 330 RVA: 0x00002694 File Offset: 0x00001A94
	internal unsafe static global::FDISystem.CP_FORMAT_TYPE_V5.CODEPLUG_MAP_T* _Val_type<struct\u0020FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T\u0020*>(global::FDISystem.CP_FORMAT_TYPE_V5.CODEPLUG_MAP_T* A_0)
	{
		return 0;
	}

	// Token: 0x0600014B RID: 331 RVA: 0x0000386C File Offset: 0x00002C6C
	internal unsafe static global::FDISystem.CP_FORMAT_TYPE_V5.CODEPLUG_MAP_T* _Uninit_move<struct\u0020FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T\u0020*,struct\u0020FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T\u0020*,class\u0020std::allocator<struct\u0020FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T>,struct\u0020FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T>(global::FDISystem.CP_FORMAT_TYPE_V5.CODEPLUG_MAP_T* _First, global::FDISystem.CP_FORMAT_TYPE_V5.CODEPLUG_MAP_T* _Last, global::FDISystem.CP_FORMAT_TYPE_V5.CODEPLUG_MAP_T* _Dest, global::std._Wrap_alloc<std::allocator<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T>\u0020>* _Al, global::FDISystem.CP_FORMAT_TYPE_V5.CODEPLUG_MAP_T* __unnamed004, global::std._Nonscalar_ptr_iterator_tag __unnamed005)
	{
		int num = (int)stackalloc byte[global::<Module>.__CxxQueryExceptionSize()];
		global::FDISystem.CP_FORMAT_TYPE_V5.CODEPLUG_MAP_T* ptr = _Dest;
		uint exceptionCode;
		try
		{
			while (_First != _Last)
			{
				global::FDISystem.CP_FORMAT_TYPE_V5.CODEPLUG_MAP_T* a_ = _Dest;
				try
				{
					if (_Dest != null)
					{
						cpblk(_Dest, _First, 12);
					}
				}
				catch
				{
					global::<Module>.delete((void*)a_, (void*)_Dest);
					throw;
				}
				_Dest += 12 / sizeof(global::FDISystem.CP_FORMAT_TYPE_V5.CODEPLUG_MAP_T);
				_First += 12 / sizeof(global::FDISystem.CP_FORMAT_TYPE_V5.CODEPLUG_MAP_T);
			}
		}
		catch when (delegate
		{
			// Failed to create a 'catch-when' expression
			exceptionCode = (uint)global::System.Runtime.InteropServices.Marshal.GetExceptionCode();
			endfilter(global::<Module>.__CxxExceptionFilter(global::System.Runtime.InteropServices.Marshal.GetExceptionPointers(), null, 0, null) != null);
		})
		{
			uint num2 = 0U;
			global::<Module>.__CxxRegisterExceptionObject(global::System.Runtime.InteropServices.Marshal.GetExceptionPointers(), num);
			try
			{
				try
				{
					while (ptr != _Dest)
					{
						ptr += 12 / sizeof(global::FDISystem.CP_FORMAT_TYPE_V5.CODEPLUG_MAP_T);
					}
					global::<Module>._CxxThrowException(null, null);
				}
				catch when (delegate
				{
					// Failed to create a 'catch-when' expression
					num2 = global::<Module>.__CxxDetectRethrow(global::System.Runtime.InteropServices.Marshal.GetExceptionPointers());
					endfilter(num2 != 0U);
				})
				{
				}
				if (num2 != 0U)
				{
					throw;
				}
			}
			finally
			{
				global::<Module>.__CxxUnregisterExceptionObject(num, (int)num2);
			}
		}
		return _Dest;
	}

	// Token: 0x0600014C RID: 332 RVA: 0x000026A4 File Offset: 0x00001AA4
	internal unsafe static byte* _Move<unsigned\u0020char\u0020&>(byte* _Arg)
	{
		return _Arg;
	}

	// Token: 0x0600014D RID: 333 RVA: 0x0000354C File Offset: 0x0000294C
	internal unsafe static void construct<struct\u0020FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T,struct\u0020FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T>(global::std._Wrap_alloc<std::allocator<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T>\u0020>* A_0, global::FDISystem.CP_FORMAT_TYPE_V2.CODEPLUG_MAP_T* _Ptr, global::FDISystem.CP_FORMAT_TYPE_V2.CODEPLUG_MAP_T* <_Args_0>)
	{
		try
		{
			if (_Ptr != null)
			{
				cpblk(_Ptr, <_Args_0>, 8);
			}
		}
		catch
		{
			global::<Module>.delete((void*)_Ptr, (void*)_Ptr);
			throw;
		}
	}

	// Token: 0x0600014E RID: 334 RVA: 0x00003590 File Offset: 0x00002990
	internal unsafe static void construct<struct\u0020FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T,struct\u0020FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T>(global::std._Wrap_alloc<std::allocator<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T>\u0020>* A_0, global::FDISystem.CP_FORMAT_TYPE_V5.CODEPLUG_MAP_T* _Ptr, global::FDISystem.CP_FORMAT_TYPE_V5.CODEPLUG_MAP_T* <_Args_0>)
	{
		try
		{
			if (_Ptr != null)
			{
				cpblk(_Ptr, <_Args_0>, 12);
			}
		}
		catch
		{
			global::<Module>.delete((void*)_Ptr, (void*)_Ptr);
			throw;
		}
	}

	// Token: 0x0600014F RID: 335 RVA: 0x000026B4 File Offset: 0x00001AB4
	internal unsafe static global::FDISystem.CP_FORMAT_TYPE_V2.CODEPLUG_MAP_T* forward<struct\u0020FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T>(global::FDISystem.CP_FORMAT_TYPE_V2.CODEPLUG_MAP_T* _Arg)
	{
		return _Arg;
	}

	// Token: 0x06000150 RID: 336 RVA: 0x00003184 File Offset: 0x00002584
	internal unsafe static void construct<struct\u0020FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T,struct\u0020FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T>(global::std.allocator<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T>* _Al, global::FDISystem.CP_FORMAT_TYPE_V2.CODEPLUG_MAP_T* _Ptr, global::FDISystem.CP_FORMAT_TYPE_V2.CODEPLUG_MAP_T* <_Args_0>)
	{
		try
		{
			if (_Ptr != null)
			{
				cpblk(_Ptr, <_Args_0>, 8);
			}
		}
		catch
		{
			global::<Module>.delete((void*)_Ptr, (void*)_Ptr);
			throw;
		}
	}

	// Token: 0x06000151 RID: 337 RVA: 0x000026C4 File Offset: 0x00001AC4
	internal unsafe static global::FDISystem.CP_FORMAT_TYPE_V5.CODEPLUG_MAP_T* forward<struct\u0020FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T>(global::FDISystem.CP_FORMAT_TYPE_V5.CODEPLUG_MAP_T* _Arg)
	{
		return _Arg;
	}

	// Token: 0x06000152 RID: 338 RVA: 0x000031C8 File Offset: 0x000025C8
	internal unsafe static void construct<struct\u0020FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T,struct\u0020FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T>(global::std.allocator<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T>* _Al, global::FDISystem.CP_FORMAT_TYPE_V5.CODEPLUG_MAP_T* _Ptr, global::FDISystem.CP_FORMAT_TYPE_V5.CODEPLUG_MAP_T* <_Args_0>)
	{
		try
		{
			if (_Ptr != null)
			{
				cpblk(_Ptr, <_Args_0>, 12);
			}
		}
		catch
		{
			global::<Module>.delete((void*)_Ptr, (void*)_Ptr);
			throw;
		}
	}

	// Token: 0x06000153 RID: 339 RVA: 0x000026D4 File Offset: 0x00001AD4
	internal unsafe static void construct<struct\u0020FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T,struct\u0020FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T>(global::std.allocator<FDISystem::CP_FORMAT_TYPE_V2::CODEPLUG_MAP_T>* A_0, global::FDISystem.CP_FORMAT_TYPE_V2.CODEPLUG_MAP_T* _Ptr, global::FDISystem.CP_FORMAT_TYPE_V2.CODEPLUG_MAP_T* <_Args_0>)
	{
		try
		{
			if (_Ptr != null)
			{
				cpblk(_Ptr, <_Args_0>, 8);
			}
		}
		catch
		{
			global::<Module>.delete((void*)_Ptr, (void*)_Ptr);
			throw;
		}
	}

	// Token: 0x06000154 RID: 340 RVA: 0x00002718 File Offset: 0x00001B18
	internal unsafe static void construct<struct\u0020FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T,struct\u0020FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T>(global::std.allocator<FDISystem::CP_FORMAT_TYPE_V5::CODEPLUG_MAP_T>* A_0, global::FDISystem.CP_FORMAT_TYPE_V5.CODEPLUG_MAP_T* _Ptr, global::FDISystem.CP_FORMAT_TYPE_V5.CODEPLUG_MAP_T* <_Args_0>)
	{
		try
		{
			if (_Ptr != null)
			{
				cpblk(_Ptr, <_Args_0>, 12);
			}
		}
		catch
		{
			global::<Module>.delete((void*)_Ptr, (void*)_Ptr);
			throw;
		}
	}

	// Token: 0x06000155 RID: 341 RVA: 0x0000D83C File Offset: 0x0000CC3C
	[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
	internal static bool <CrtImplementationDetails>.NativeDll.IsInDllMain()
	{
		return (global::<Module>.__native_dllmain_reason != uint.MaxValue) ? 1 : 0;
	}

	// Token: 0x06000156 RID: 342 RVA: 0x0000D858 File Offset: 0x0000CC58
	[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
	internal static bool <CrtImplementationDetails>.NativeDll.IsInProcessAttach()
	{
		return (global::<Module>.__native_dllmain_reason == 1U) ? 1 : 0;
	}

	// Token: 0x06000157 RID: 343 RVA: 0x0000D870 File Offset: 0x0000CC70
	[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
	internal static bool <CrtImplementationDetails>.NativeDll.IsInProcessDetach()
	{
		return (global::<Module>.__native_dllmain_reason == 0U) ? 1 : 0;
	}

	// Token: 0x06000158 RID: 344 RVA: 0x0000D888 File Offset: 0x0000CC88
	[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
	internal static bool <CrtImplementationDetails>.NativeDll.IsSafeForManagedCode()
	{
		if (((global::<Module>.__native_dllmain_reason != 4294967295U) ? 1 : 0) == 0)
		{
			return 1;
		}
		int num;
		if (((global::<Module>.__native_dllmain_reason == 1U) ? 1 : 0) == 0 && ((global::<Module>.__native_dllmain_reason == 0U) ? 1 : 0) == 0)
		{
			num = 1;
		}
		else
		{
			num = 0;
		}
		return (byte)num;
	}

	// Token: 0x06000159 RID: 345 RVA: 0x0000E0A0 File Offset: 0x0000D4A0
	internal static void <CrtImplementationDetails>.ThrowNestedModuleLoadException(global::System.Exception innerException, global::System.Exception nestedException)
	{
		throw new global::<CrtImplementationDetails>.ModuleLoadExceptionHandlerException("A nested exception occurred after the primary exception that caused the C++ module to fail to load.\n", innerException, nestedException);
	}

	// Token: 0x0600015A RID: 346 RVA: 0x0000DA88 File Offset: 0x0000CE88
	internal static void <CrtImplementationDetails>.ThrowModuleLoadException(string errorMessage)
	{
		throw new global::<CrtImplementationDetails>.ModuleLoadException(errorMessage);
	}

	// Token: 0x0600015B RID: 347 RVA: 0x0000DA9C File Offset: 0x0000CE9C
	internal static void <CrtImplementationDetails>.ThrowModuleLoadException(string errorMessage, global::System.Exception innerException)
	{
		throw new global::<CrtImplementationDetails>.ModuleLoadException(errorMessage, innerException);
	}

	// Token: 0x0600015C RID: 348 RVA: 0x0000DBB8 File Offset: 0x0000CFB8
	internal static void <CrtImplementationDetails>.RegisterModuleUninitializer(global::System.EventHandler handler)
	{
		global::<CrtImplementationDetails>.ModuleUninitializer._ModuleUninitializer.AddHandler(handler);
	}

	// Token: 0x0600015D RID: 349 RVA: 0x0000DBD0 File Offset: 0x0000CFD0
	[global::System.Security.SecuritySafeCritical]
	internal unsafe static global::System.Guid <CrtImplementationDetails>.FromGUID(global::_GUID* guid)
	{
		global::System.Guid result = new global::System.Guid((uint)(*guid), *(guid + 4), *(guid + 6), *(guid + 8), *(guid + 9), *(guid + 10), *(guid + 11), *(guid + 12), *(guid + 13), *(guid + 14), *(guid + 15));
		return result;
	}

	// Token: 0x0600015E RID: 350 RVA: 0x0000DC18 File Offset: 0x0000D018
	[global::System.Security.SecurityCritical]
	internal unsafe static int __get_default_appdomain(global::IUnknown** ppUnk)
	{
		global::ICorRuntimeHost* ptr = null;
		int num;
		try
		{
			global::System.Guid riid = global::<Module>.<CrtImplementationDetails>.FromGUID(ref global::<Module>._GUID_cb2f6722_ab3a_11d2_9c40_00c04fa30a3e);
			global::System.Guid clsid = global::<Module>.<CrtImplementationDetails>.FromGUID(ref global::<Module>._GUID_cb2f6723_ab3a_11d2_9c40_00c04fa30a3e);
			ptr = (global::ICorRuntimeHost*)global::System.Runtime.InteropServices.RuntimeEnvironment.GetRuntimeInterfaceAsIntPtr(clsid, riid).ToPointer();
			goto IL_3D;
		}
		catch (global::System.Exception e)
		{
			num = global::System.Runtime.InteropServices.Marshal.GetHRForException(e);
		}
		if (num < 0)
		{
			return num;
		}
		IL_3D:
		num = calli(System.Int32 modopt(System.Runtime.CompilerServices.IsLong) modopt(System.Runtime.CompilerServices.CallConvStdcall)(System.IntPtr,IUnknown**), ptr, ppUnk, *(*(int*)ptr + 52));
		global::ICorRuntimeHost* ptr2 = ptr;
		object obj = calli(System.UInt32 modopt(System.Runtime.CompilerServices.IsLong) modopt(System.Runtime.CompilerServices.CallConvStdcall)(System.IntPtr), ptr2, *(*(int*)ptr2 + 8));
		return num;
	}

	// Token: 0x0600015F RID: 351 RVA: 0x0000DC9C File Offset: 0x0000D09C
	internal unsafe static void __release_appdomain(global::IUnknown* ppUnk)
	{
		object obj = calli(System.UInt32 modopt(System.Runtime.CompilerServices.IsLong) modopt(System.Runtime.CompilerServices.CallConvStdcall)(System.IntPtr), ppUnk, *(*(int*)ppUnk + 8));
	}

	// Token: 0x06000160 RID: 352 RVA: 0x0000DCB8 File Offset: 0x0000D0B8
	[global::System.Security.SecurityCritical]
	internal unsafe static global::System.AppDomain <CrtImplementationDetails>.GetDefaultDomain()
	{
		global::IUnknown* ptr = null;
		int num = global::<Module>.__get_default_appdomain(&ptr);
		if (num >= 0)
		{
			try
			{
				global::System.IntPtr pUnk = new global::System.IntPtr((void*)ptr);
				return (global::System.AppDomain)global::System.Runtime.InteropServices.Marshal.GetObjectForIUnknown(pUnk);
			}
			finally
			{
				global::<Module>.__release_appdomain(ptr);
			}
		}
		global::System.Runtime.InteropServices.Marshal.ThrowExceptionForHR(num);
		return null;
	}

	// Token: 0x06000161 RID: 353 RVA: 0x0000DD18 File Offset: 0x0000D118
	[global::System.Security.SecurityCritical]
	internal unsafe static void <CrtImplementationDetails>.DoCallBackInDefaultDomain(global::method function, void* cookie)
	{
		global::System.Guid riid = global::<Module>.<CrtImplementationDetails>.FromGUID(ref global::<Module>._GUID_90f1a06c_7712_4762_86b5_7a5eba6bdb02);
		global::ICLRRuntimeHost* ptr = (global::ICLRRuntimeHost*)global::System.Runtime.InteropServices.RuntimeEnvironment.GetRuntimeInterfaceAsIntPtr(global::<Module>.<CrtImplementationDetails>.FromGUID(ref global::<Module>._GUID_90f1a06e_7712_4762_86b5_7a5eba6bdb02), riid).ToPointer();
		try
		{
			global::System.AppDomain appDomain = global::<Module>.<CrtImplementationDetails>.GetDefaultDomain();
			int num = calli(System.Int32 modopt(System.Runtime.CompilerServices.IsLong) modopt(System.Runtime.CompilerServices.CallConvStdcall)(System.IntPtr,System.UInt32 modopt(System.Runtime.CompilerServices.IsLong),System.Int32 modopt(System.Runtime.CompilerServices.IsLong) modopt(System.Runtime.CompilerServices.CallConvStdcall) (System.Void*),System.Void*), ptr, appDomain.Id, function, cookie, *(*(int*)ptr + 32));
			if (num < 0)
			{
				global::System.Runtime.InteropServices.Marshal.ThrowExceptionForHR(num);
			}
		}
		finally
		{
			global::ICLRRuntimeHost* ptr2 = ptr;
			object obj = calli(System.UInt32 modopt(System.Runtime.CompilerServices.IsLong) modopt(System.Runtime.CompilerServices.CallConvStdcall)(System.IntPtr), ptr2, *(*(int*)ptr2 + 8));
		}
	}

	// Token: 0x06000162 RID: 354 RVA: 0x0000DDD0 File Offset: 0x0000D1D0
	[global::System.Security.SecuritySafeCritical]
	internal unsafe static int <CrtImplementationDetails>.DefaultDomain.DoNothing(void* cookie)
	{
		global::System.GC.KeepAlive(int.MaxValue);
		return 0;
	}

	// Token: 0x06000163 RID: 355 RVA: 0x0000DDF0 File Offset: 0x0000D1F0
	[global::System.Security.SecuritySafeCritical]
	[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
	internal unsafe static bool <CrtImplementationDetails>.DefaultDomain.HasPerProcess()
	{
		if (global::<Module>.?hasPerProcess@DefaultDomain@<CrtImplementationDetails>@@0W4State@TriBool@2@A == (global::<CrtImplementationDetails>.TriBool.State)2)
		{
			void** ptr = (void**)(&global::<Module>.?A0xd2508fec.__xc_mp_a);
			if (ref global::<Module>.?A0xd2508fec.__xc_mp_a < ref global::<Module>.?A0xd2508fec.__xc_mp_z)
			{
				while (*(int*)ptr == 0)
				{
					ptr += 4 / sizeof(void*);
					if (ptr >= (void**)(&global::<Module>.?A0xd2508fec.__xc_mp_z))
					{
						goto IL_34;
					}
				}
				global::<Module>.?hasPerProcess@DefaultDomain@<CrtImplementationDetails>@@0W4State@TriBool@2@A = (global::<CrtImplementationDetails>.TriBool.State)(-1);
				return 1;
			}
			IL_34:
			global::<Module>.?hasPerProcess@DefaultDomain@<CrtImplementationDetails>@@0W4State@TriBool@2@A = (global::<CrtImplementationDetails>.TriBool.State)0;
			return 0;
		}
		return (global::<Module>.?hasPerProcess@DefaultDomain@<CrtImplementationDetails>@@0W4State@TriBool@2@A == (global::<CrtImplementationDetails>.TriBool.State)(-1)) ? 1 : 0;
	}

	// Token: 0x06000164 RID: 356 RVA: 0x0000DE44 File Offset: 0x0000D244
	[global::System.Security.SecuritySafeCritical]
	[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
	internal unsafe static bool <CrtImplementationDetails>.DefaultDomain.HasNative()
	{
		if (global::<Module>.?hasNative@DefaultDomain@<CrtImplementationDetails>@@0W4State@TriBool@2@A == (global::<CrtImplementationDetails>.TriBool.State)2)
		{
			void** ptr = (void**)(&global::<Module>.__xi_a);
			if (ref global::<Module>.__xi_a < ref global::<Module>.__xi_z)
			{
				while (*(int*)ptr == 0)
				{
					ptr += 4 / sizeof(void*);
					if (ptr >= (void**)(&global::<Module>.__xi_z))
					{
						goto IL_34;
					}
				}
				global::<Module>.?hasNative@DefaultDomain@<CrtImplementationDetails>@@0W4State@TriBool@2@A = (global::<CrtImplementationDetails>.TriBool.State)(-1);
				return 1;
			}
			IL_34:
			void** ptr2 = (void**)(&global::<Module>.__xc_a);
			if (ref global::<Module>.__xc_a < ref global::<Module>.__xc_z)
			{
				while (*(int*)ptr2 == 0)
				{
					ptr2 += 4 / sizeof(void*);
					if (ptr2 >= (void**)(&global::<Module>.__xc_z))
					{
						goto IL_60;
					}
				}
				global::<Module>.?hasNative@DefaultDomain@<CrtImplementationDetails>@@0W4State@TriBool@2@A = (global::<CrtImplementationDetails>.TriBool.State)(-1);
				return 1;
			}
			IL_60:
			global::<Module>.?hasNative@DefaultDomain@<CrtImplementationDetails>@@0W4State@TriBool@2@A = (global::<CrtImplementationDetails>.TriBool.State)0;
			return 0;
		}
		return (global::<Module>.?hasNative@DefaultDomain@<CrtImplementationDetails>@@0W4State@TriBool@2@A == (global::<CrtImplementationDetails>.TriBool.State)(-1)) ? 1 : 0;
	}

	// Token: 0x06000165 RID: 357 RVA: 0x0000DEC4 File Offset: 0x0000D2C4
	[global::System.Security.SecuritySafeCritical]
	[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
	internal static bool <CrtImplementationDetails>.DefaultDomain.NeedsInitialization()
	{
		int num;
		if ((global::<Module>.<CrtImplementationDetails>.DefaultDomain.HasPerProcess() != null && !global::<Module>.?InitializedPerProcess@DefaultDomain@<CrtImplementationDetails>@@2_NA) || (global::<Module>.<CrtImplementationDetails>.DefaultDomain.HasNative() != null && !global::<Module>.?InitializedNative@DefaultDomain@<CrtImplementationDetails>@@2_NA && global::<Module>.__native_startup_state == (global::__enative_startup_state)0))
		{
			num = 1;
		}
		else
		{
			num = 0;
		}
		return (byte)num;
	}

	// Token: 0x06000166 RID: 358 RVA: 0x0000DF00 File Offset: 0x0000D300
	[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
	internal static bool <CrtImplementationDetails>.DefaultDomain.NeedsUninitialization()
	{
		return global::<Module>.?Entered@DefaultDomain@<CrtImplementationDetails>@@2_NA;
	}

	// Token: 0x06000167 RID: 359 RVA: 0x0000DF14 File Offset: 0x0000D314
	[global::System.Security.SecurityCritical]
	internal static void <CrtImplementationDetails>.DefaultDomain.Initialize()
	{
		global::<Module>.<CrtImplementationDetails>.DoCallBackInDefaultDomain(global::<Module>.__unep@?DoNothing@DefaultDomain@<CrtImplementationDetails>@@$$FCGJPAX@Z, null);
	}

	// Token: 0x06000168 RID: 360 RVA: 0x00001000 File Offset: 0x00000400
	internal static void ??__E?Initialized@CurrentDomain@<CrtImplementationDetails>@@$$Q2HA@@YMXXZ()
	{
		global::<Module>.?Initialized@CurrentDomain@<CrtImplementationDetails>@@$$Q2HA = 0;
	}

	// Token: 0x06000169 RID: 361 RVA: 0x00001014 File Offset: 0x00000414
	internal static void ??__E?Uninitialized@CurrentDomain@<CrtImplementationDetails>@@$$Q2HA@@YMXXZ()
	{
		global::<Module>.?Uninitialized@CurrentDomain@<CrtImplementationDetails>@@$$Q2HA = 0;
	}

	// Token: 0x0600016A RID: 362 RVA: 0x00001028 File Offset: 0x00000428
	internal static void ??__E?IsDefaultDomain@CurrentDomain@<CrtImplementationDetails>@@$$Q2_NA@@YMXXZ()
	{
		global::<Module>.?IsDefaultDomain@CurrentDomain@<CrtImplementationDetails>@@$$Q2_NA = false;
	}

	// Token: 0x0600016B RID: 363 RVA: 0x0000103C File Offset: 0x0000043C
	internal static void ??__E?InitializedVtables@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A@@YMXXZ()
	{
		global::<Module>.?InitializedVtables@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A = (global::<CrtImplementationDetails>.Progress.State)0;
	}

	// Token: 0x0600016C RID: 364 RVA: 0x00001050 File Offset: 0x00000450
	internal static void ??__E?InitializedNative@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A@@YMXXZ()
	{
		global::<Module>.?InitializedNative@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A = (global::<CrtImplementationDetails>.Progress.State)0;
	}

	// Token: 0x0600016D RID: 365 RVA: 0x00001064 File Offset: 0x00000464
	internal static void ??__E?InitializedPerProcess@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A@@YMXXZ()
	{
		global::<Module>.?InitializedPerProcess@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A = (global::<CrtImplementationDetails>.Progress.State)0;
	}

	// Token: 0x0600016E RID: 366 RVA: 0x00001078 File Offset: 0x00000478
	internal static void ??__E?InitializedPerAppDomain@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A@@YMXXZ()
	{
		global::<Module>.?InitializedPerAppDomain@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A = (global::<CrtImplementationDetails>.Progress.State)0;
	}

	// Token: 0x0600016F RID: 367 RVA: 0x0000E0F4 File Offset: 0x0000D4F4
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.Security.SecurityCritical]
	internal unsafe static void <CrtImplementationDetails>.LanguageSupport.InitializeVtables(global::<CrtImplementationDetails>.LanguageSupport* A_0)
	{
		global::<Module>.gcroot<System::String\u0020^>.=(A_0, "The C++ module failed to load during vtable initialization.\n");
		global::<Module>.?InitializedVtables@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A = (global::<CrtImplementationDetails>.Progress.State)1;
		global::<Module>._initterm_m((global::method*)(&global::<Module>.?A0xd2508fec.__xi_vt_a), (global::method*)(&global::<Module>.?A0xd2508fec.__xi_vt_z));
		global::<Module>.?InitializedVtables@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A = (global::<CrtImplementationDetails>.Progress.State)2;
	}

	// Token: 0x06000170 RID: 368 RVA: 0x0000E128 File Offset: 0x0000D528
	[global::System.Security.SecurityCritical]
	internal unsafe static void <CrtImplementationDetails>.LanguageSupport.InitializeDefaultAppDomain(global::<CrtImplementationDetails>.LanguageSupport* A_0)
	{
		global::<Module>.gcroot<System::String\u0020^>.=(A_0, "The C++ module failed to load while attempting to initialize the default appdomain.\n");
		global::<Module>.<CrtImplementationDetails>.DefaultDomain.Initialize();
	}

	// Token: 0x06000171 RID: 369 RVA: 0x0000E148 File Offset: 0x0000D548
	[global::System.Security.SecurityCritical]
	[global::System.Diagnostics.DebuggerStepThrough]
	internal unsafe static void <CrtImplementationDetails>.LanguageSupport.InitializeNative(global::<CrtImplementationDetails>.LanguageSupport* A_0)
	{
		global::<Module>.gcroot<System::String\u0020^>.=(A_0, "The C++ module failed to load during native initialization.\n");
		global::<Module>.__security_init_cookie();
		global::<Module>.?InitializedNative@DefaultDomain@<CrtImplementationDetails>@@2_NA = true;
		if (global::<Module>.<CrtImplementationDetails>.NativeDll.IsSafeForManagedCode() == null)
		{
			global::<Module>._amsg_exit(33);
		}
		if (global::<Module>.__native_startup_state == (global::__enative_startup_state)1)
		{
			global::<Module>._amsg_exit(33);
		}
		else if (global::<Module>.__native_startup_state == (global::__enative_startup_state)0)
		{
			global::<Module>.?InitializedNative@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A = (global::<CrtImplementationDetails>.Progress.State)1;
			global::<Module>.__native_startup_state = (global::__enative_startup_state)1;
			if (global::<Module>._initterm_e((global::method*)(&global::<Module>.__xi_a), (global::method*)(&global::<Module>.__xi_z)) != 0)
			{
				global::<Module>.<CrtImplementationDetails>.ThrowModuleLoadException(global::<Module>.gcroot<System::String\u0020^>..P$AAVString@System@@(A_0));
			}
			global::<Module>._initterm((global::method*)(&global::<Module>.__xc_a), (global::method*)(&global::<Module>.__xc_z));
			global::<Module>.__native_startup_state = (global::__enative_startup_state)2;
			global::<Module>.?InitializedNativeFromCCTOR@DefaultDomain@<CrtImplementationDetails>@@2_NA = true;
			global::<Module>.?InitializedNative@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A = (global::<CrtImplementationDetails>.Progress.State)2;
		}
	}

	// Token: 0x06000172 RID: 370 RVA: 0x0000E1E4 File Offset: 0x0000D5E4
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.Security.SecurityCritical]
	internal unsafe static void <CrtImplementationDetails>.LanguageSupport.InitializePerProcess(global::<CrtImplementationDetails>.LanguageSupport* A_0)
	{
		global::<Module>.gcroot<System::String\u0020^>.=(A_0, "The C++ module failed to load during process initialization.\n");
		global::<Module>.?InitializedPerProcess@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A = (global::<CrtImplementationDetails>.Progress.State)1;
		global::<Module>._initatexit_m();
		global::<Module>._initterm_m((global::method*)(&global::<Module>.?A0xd2508fec.__xc_mp_a), (global::method*)(&global::<Module>.?A0xd2508fec.__xc_mp_z));
		global::<Module>.?InitializedPerProcess@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A = (global::<CrtImplementationDetails>.Progress.State)2;
		global::<Module>.?InitializedPerProcess@DefaultDomain@<CrtImplementationDetails>@@2_NA = true;
	}

	// Token: 0x06000173 RID: 371 RVA: 0x0000E224 File Offset: 0x0000D624
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.Security.SecurityCritical]
	internal unsafe static void <CrtImplementationDetails>.LanguageSupport.InitializePerAppDomain(global::<CrtImplementationDetails>.LanguageSupport* A_0)
	{
		global::<Module>.gcroot<System::String\u0020^>.=(A_0, "The C++ module failed to load during appdomain initialization.\n");
		global::<Module>.?InitializedPerAppDomain@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A = (global::<CrtImplementationDetails>.Progress.State)1;
		global::<Module>._initatexit_app_domain();
		global::<Module>._initterm_m((global::method*)(&global::<Module>.?A0xd2508fec.__xc_ma_a), (global::method*)(&global::<Module>.?A0xd2508fec.__xc_ma_z));
		global::<Module>.?InitializedPerAppDomain@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A = (global::<CrtImplementationDetails>.Progress.State)2;
	}

	// Token: 0x06000174 RID: 372 RVA: 0x0000E260 File Offset: 0x0000D660
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.Security.SecurityCritical]
	internal unsafe static void <CrtImplementationDetails>.LanguageSupport.InitializeUninitializer(global::<CrtImplementationDetails>.LanguageSupport* A_0)
	{
		global::<Module>.gcroot<System::String\u0020^>.=(A_0, "The C++ module failed to load during registration for the unload events.\n");
		global::<Module>.<CrtImplementationDetails>.RegisterModuleUninitializer(new global::System.EventHandler(global::<Module>.<CrtImplementationDetails>.LanguageSupport.DomainUnload));
	}

	// Token: 0x06000175 RID: 373 RVA: 0x0000E28C File Offset: 0x0000D68C
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.Security.SecurityCritical]
	[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.Success)]
	internal unsafe static void <CrtImplementationDetails>.LanguageSupport._Initialize(global::<CrtImplementationDetails>.LanguageSupport* A_0)
	{
		global::<Module>.?IsDefaultDomain@CurrentDomain@<CrtImplementationDetails>@@$$Q2_NA = global::System.AppDomain.CurrentDomain.IsDefaultAppDomain();
		if (global::<Module>.?IsDefaultDomain@CurrentDomain@<CrtImplementationDetails>@@$$Q2_NA)
		{
			global::<Module>.?Entered@DefaultDomain@<CrtImplementationDetails>@@2_NA = true;
		}
		void* ptr = global::<Module>._getFiberPtrId();
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		global::System.Runtime.CompilerServices.RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			while (num2 == 0)
			{
				try
				{
				}
				finally
				{
					global::System.IntPtr comparand = (global::System.IntPtr)0;
					global::System.IntPtr value = (global::System.IntPtr)ptr;
					global::System.IntPtr value2 = global::System.Threading.Interlocked.CompareExchange(ref global::<Module>.__native_startup_lock, value, comparand);
					void* ptr2 = (void*)value2;
					if (ptr2 == null)
					{
						num2 = 1;
					}
					else if (ptr2 == ptr)
					{
						num = 1;
						num2 = 1;
					}
				}
				if (num2 == 0)
				{
					global::<Module>.Sleep(1000);
				}
			}
			global::<Module>.<CrtImplementationDetails>.LanguageSupport.InitializeVtables(A_0);
			if (global::<Module>.?IsDefaultDomain@CurrentDomain@<CrtImplementationDetails>@@$$Q2_NA)
			{
				global::<Module>.<CrtImplementationDetails>.LanguageSupport.InitializeNative(A_0);
				global::<Module>.<CrtImplementationDetails>.LanguageSupport.InitializePerProcess(A_0);
			}
			else if (global::<Module>.<CrtImplementationDetails>.DefaultDomain.NeedsInitialization() != null)
			{
				num3 = 1;
			}
		}
		finally
		{
			if (num == 0)
			{
				global::System.IntPtr value3 = (global::System.IntPtr)0;
				global::System.Threading.Interlocked.Exchange(ref global::<Module>.__native_startup_lock, value3);
			}
		}
		if (num3 != 0)
		{
			global::<Module>.<CrtImplementationDetails>.LanguageSupport.InitializeDefaultAppDomain(A_0);
		}
		global::<Module>.<CrtImplementationDetails>.LanguageSupport.InitializePerAppDomain(A_0);
		global::<Module>.?Initialized@CurrentDomain@<CrtImplementationDetails>@@$$Q2HA = 1;
		global::<Module>.<CrtImplementationDetails>.LanguageSupport.InitializeUninitializer(A_0);
	}

	// Token: 0x06000176 RID: 374 RVA: 0x0000DF2C File Offset: 0x0000D32C
	[global::System.Security.SecurityCritical]
	internal static void <CrtImplementationDetails>.LanguageSupport.UninitializeAppDomain()
	{
		global::<Module>._app_exit_callback();
	}

	// Token: 0x06000177 RID: 375 RVA: 0x0000DF40 File Offset: 0x0000D340
	[global::System.Security.SecurityCritical]
	internal unsafe static int <CrtImplementationDetails>.LanguageSupport._UninitializeDefaultDomain(void* cookie)
	{
		global::<Module>._exit_callback();
		global::<Module>.?InitializedPerProcess@DefaultDomain@<CrtImplementationDetails>@@2_NA = false;
		if (global::<Module>.?InitializedNativeFromCCTOR@DefaultDomain@<CrtImplementationDetails>@@2_NA)
		{
			global::<Module>._cexit();
			global::<Module>.__native_startup_state = (global::__enative_startup_state)0;
			global::<Module>.?InitializedNativeFromCCTOR@DefaultDomain@<CrtImplementationDetails>@@2_NA = false;
		}
		global::<Module>.?InitializedNative@DefaultDomain@<CrtImplementationDetails>@@2_NA = false;
		return 0;
	}

	// Token: 0x06000178 RID: 376 RVA: 0x0000DF7C File Offset: 0x0000D37C
	[global::System.Security.SecurityCritical]
	internal static void <CrtImplementationDetails>.LanguageSupport.UninitializeDefaultDomain()
	{
		if (global::<Module>.<CrtImplementationDetails>.DefaultDomain.NeedsUninitialization() != null)
		{
			if (global::System.AppDomain.CurrentDomain.IsDefaultAppDomain())
			{
				global::<Module>.<CrtImplementationDetails>.LanguageSupport._UninitializeDefaultDomain(null);
			}
			else
			{
				global::<Module>.<CrtImplementationDetails>.DoCallBackInDefaultDomain(global::<Module>.__unep@?_UninitializeDefaultDomain@LanguageSupport@<CrtImplementationDetails>@@$$FCGJPAX@Z, null);
			}
		}
	}

	// Token: 0x06000179 RID: 377 RVA: 0x0000DFB0 File Offset: 0x0000D3B0
	[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.Success)]
	[global::System.Runtime.ConstrainedExecution.PrePrepareMethod]
	[global::System.Security.SecurityCritical]
	internal static void <CrtImplementationDetails>.LanguageSupport.DomainUnload(object source, global::System.EventArgs arguments)
	{
		if (global::<Module>.?Initialized@CurrentDomain@<CrtImplementationDetails>@@$$Q2HA != 0 && global::System.Threading.Interlocked.Exchange(ref global::<Module>.?Uninitialized@CurrentDomain@<CrtImplementationDetails>@@$$Q2HA, 1) == 0)
		{
			byte b = (global::System.Threading.Interlocked.Decrement(ref global::<Module>.?Count@AllDomains@<CrtImplementationDetails>@@2HA) == 0) ? 1 : 0;
			global::<Module>.<CrtImplementationDetails>.LanguageSupport.UninitializeAppDomain();
			if (b != 0)
			{
				global::<Module>.<CrtImplementationDetails>.LanguageSupport.UninitializeDefaultDomain();
			}
		}
	}

	// Token: 0x0600017A RID: 378 RVA: 0x0000E3B0 File Offset: 0x0000D7B0
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.Success)]
	[global::System.Security.SecurityCritical]
	internal unsafe static void <CrtImplementationDetails>.LanguageSupport.Cleanup(global::<CrtImplementationDetails>.LanguageSupport* A_0, global::System.Exception innerException)
	{
		try
		{
			bool flag = ((global::System.Threading.Interlocked.Decrement(ref global::<Module>.?Count@AllDomains@<CrtImplementationDetails>@@2HA) == 0) ? 1 : 0) != 0;
			global::<Module>.<CrtImplementationDetails>.LanguageSupport.UninitializeAppDomain();
			if (flag)
			{
				global::<Module>.<CrtImplementationDetails>.LanguageSupport.UninitializeDefaultDomain();
			}
		}
		catch (global::System.Exception nestedException)
		{
			global::<Module>.<CrtImplementationDetails>.ThrowNestedModuleLoadException(innerException, nestedException);
		}
		catch (object obj)
		{
			global::<Module>.<CrtImplementationDetails>.ThrowNestedModuleLoadException(innerException, null);
		}
	}

	// Token: 0x0600017B RID: 379 RVA: 0x0000E424 File Offset: 0x0000D824
	[global::System.Security.SecurityCritical]
	internal unsafe static global::<CrtImplementationDetails>.LanguageSupport* <CrtImplementationDetails>.LanguageSupport.{ctor}(global::<CrtImplementationDetails>.LanguageSupport* A_0)
	{
		global::<Module>.gcroot<System::String\u0020^>.{ctor}(A_0);
		return A_0;
	}

	// Token: 0x0600017C RID: 380 RVA: 0x0000E43C File Offset: 0x0000D83C
	[global::System.Security.SecurityCritical]
	internal unsafe static void <CrtImplementationDetails>.LanguageSupport.{dtor}(global::<CrtImplementationDetails>.LanguageSupport* A_0)
	{
		global::<Module>.gcroot<System::String\u0020^>.{dtor}(A_0);
	}

	// Token: 0x0600017D RID: 381 RVA: 0x0000E450 File Offset: 0x0000D850
	[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.Success)]
	[global::System.Security.SecurityCritical]
	[global::System.Diagnostics.DebuggerStepThrough]
	internal unsafe static void <CrtImplementationDetails>.LanguageSupport.Initialize(global::<CrtImplementationDetails>.LanguageSupport* A_0)
	{
		bool flag = false;
		global::System.Runtime.CompilerServices.RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			global::<Module>.gcroot<System::String\u0020^>.=(A_0, "The C++ module failed to load.\n");
			global::System.Runtime.CompilerServices.RuntimeHelpers.PrepareConstrainedRegions();
			try
			{
			}
			finally
			{
				global::System.Threading.Interlocked.Increment(ref global::<Module>.?Count@AllDomains@<CrtImplementationDetails>@@2HA);
				flag = true;
			}
			global::<Module>.<CrtImplementationDetails>.LanguageSupport._Initialize(A_0);
		}
		catch (global::System.Exception innerException)
		{
			if (flag)
			{
				global::<Module>.<CrtImplementationDetails>.LanguageSupport.Cleanup(A_0, innerException);
			}
			global::<Module>.<CrtImplementationDetails>.ThrowModuleLoadException(global::<Module>.gcroot<System::String\u0020^>..P$AAVString@System@@(A_0), innerException);
		}
		catch (object obj)
		{
			if (flag)
			{
				global::<Module>.<CrtImplementationDetails>.LanguageSupport.Cleanup(A_0, null);
			}
			global::<Module>.<CrtImplementationDetails>.ThrowModuleLoadException(global::<Module>.gcroot<System::String\u0020^>..P$AAVString@System@@(A_0), null);
		}
	}

	// Token: 0x0600017E RID: 382 RVA: 0x0000E50C File Offset: 0x0000D90C
	[global::System.Security.SecurityCritical]
	[global::System.Diagnostics.DebuggerStepThrough]
	static unsafe <Module>()
	{
		global::<CrtImplementationDetails>.LanguageSupport languageSupport;
		global::<Module>.<CrtImplementationDetails>.LanguageSupport.{ctor}(ref languageSupport);
		try
		{
			global::<Module>.<CrtImplementationDetails>.LanguageSupport.Initialize(ref languageSupport);
		}
		catch
		{
			global::<Module>.___CxxCallUnwindDtor(ldftn(<CrtImplementationDetails>.LanguageSupport.{dtor}), (void*)(&languageSupport));
			throw;
		}
		global::<Module>.<CrtImplementationDetails>.LanguageSupport.{dtor}(ref languageSupport);
	}

	// Token: 0x0600017F RID: 383 RVA: 0x0000DFEC File Offset: 0x0000D3EC
	[global::System.Security.SecuritySafeCritical]
	[global::System.Diagnostics.DebuggerStepThrough]
	internal unsafe static global::gcroot<System::String\u0020^>* {ctor}(global::gcroot<System::String\u0020^>* A_0)
	{
		*A_0 = ((global::System.IntPtr)global::System.Runtime.InteropServices.GCHandle.Alloc(null)).ToPointer();
		return A_0;
	}

	// Token: 0x06000180 RID: 384 RVA: 0x0000E010 File Offset: 0x0000D410
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.Security.SecurityCritical]
	internal unsafe static void {dtor}(global::gcroot<System::String\u0020^>* A_0)
	{
		global::System.IntPtr value = new global::System.IntPtr(*A_0);
		((global::System.Runtime.InteropServices.GCHandle)value).Free();
		*A_0 = 0;
	}

	// Token: 0x06000181 RID: 385 RVA: 0x0000E038 File Offset: 0x0000D438
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.Security.SecurityCritical]
	internal unsafe static global::gcroot<System::String\u0020^>* =(global::gcroot<System::String\u0020^>* A_0, string t)
	{
		global::System.IntPtr value = new global::System.IntPtr(*A_0);
		((global::System.Runtime.InteropServices.GCHandle)value).Target = t;
		return A_0;
	}

	// Token: 0x06000182 RID: 386 RVA: 0x0000E060 File Offset: 0x0000D460
	[global::System.Security.SecuritySafeCritical]
	internal unsafe static string P$AAVString@System@@(global::gcroot<System::String\u0020^>* A_0)
	{
		global::System.IntPtr value = new global::System.IntPtr(*A_0);
		return ((global::System.Runtime.InteropServices.GCHandle)value).Target;
	}

	// Token: 0x06000183 RID: 387 RVA: 0x0000E66C File Offset: 0x0000DA6C
	[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.Success)]
	[global::System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
	[global::System.Security.SecurityCritical]
	[global::System.Security.Permissions.SecurityPermission(global::System.Security.Permissions.SecurityAction.Assert, UnmanagedCode = true)]
	internal unsafe static void ___CxxCallUnwindDtor(global::method pDtor, void* pThis)
	{
		try
		{
			calli(System.Void(System.Void*), pThis, pDtor);
		}
		catch when (endfilter(global::<Module>.__FrameUnwindFilter(global::System.Runtime.InteropServices.Marshal.GetExceptionPointers()) != null))
		{
		}
	}

	// Token: 0x06000184 RID: 388 RVA: 0x0000E6B8 File Offset: 0x0000DAB8
	[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.Success)]
	[global::System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
	[global::System.Security.SecurityCritical]
	[global::System.Security.Permissions.SecurityPermission(global::System.Security.Permissions.SecurityAction.Assert, UnmanagedCode = true)]
	internal unsafe static void ___CxxCallUnwindDelDtor(global::method pDtor, void* pThis)
	{
		try
		{
			calli(System.Void(System.Void*), pThis, pDtor);
		}
		catch when (endfilter(global::<Module>.__FrameUnwindFilter(global::System.Runtime.InteropServices.Marshal.GetExceptionPointers()) != null))
		{
		}
	}

	// Token: 0x06000185 RID: 389 RVA: 0x0000E704 File Offset: 0x0000DB04
	[global::System.Security.SecurityCritical]
	[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.Success)]
	[global::System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
	[global::System.Security.Permissions.SecurityPermission(global::System.Security.Permissions.SecurityAction.Assert, UnmanagedCode = true)]
	internal unsafe static void ___CxxCallUnwindVecDtor(global::method pVecDtor, void* ptr, uint size, int count, global::method pDtor)
	{
		try
		{
			calli(System.Void(System.Void*,System.UInt32,System.Int32,System.Void (System.Void*)), ptr, size, count, pDtor, pVecDtor);
		}
		catch when (endfilter(global::<Module>.__FrameUnwindFilter(global::System.Runtime.InteropServices.Marshal.GetExceptionPointers()) != null))
		{
		}
	}

	// Token: 0x06000186 RID: 390 RVA: 0x0000E754 File Offset: 0x0000DB54
	[global::System.Security.SecurityCritical]
	[global::System.Diagnostics.DebuggerStepThrough]
	internal static global::System.ValueType <CrtImplementationDetails>.AtExitLock._handle()
	{
		if (global::<Module>.?_lock@AtExitLock@<CrtImplementationDetails>@@$$Q0PAXA != null)
		{
			global::System.IntPtr value = new global::System.IntPtr(global::<Module>.?_lock@AtExitLock@<CrtImplementationDetails>@@$$Q0PAXA);
			return global::System.Runtime.InteropServices.GCHandle.FromIntPtr(value);
		}
		return null;
	}

	// Token: 0x06000187 RID: 391 RVA: 0x0000EC58 File Offset: 0x0000E058
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.Security.SecurityCritical]
	internal static void <CrtImplementationDetails>.AtExitLock._lock_Construct(object value)
	{
		global::<Module>.?_lock@AtExitLock@<CrtImplementationDetails>@@$$Q0PAXA = null;
		global::<Module>.<CrtImplementationDetails>.AtExitLock._lock_Set(value);
	}

	// Token: 0x06000188 RID: 392 RVA: 0x0000E784 File Offset: 0x0000DB84
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.Security.SecurityCritical]
	internal static void <CrtImplementationDetails>.AtExitLock._lock_Set(object value)
	{
		global::System.ValueType valueType = global::<Module>.<CrtImplementationDetails>.AtExitLock._handle();
		if (valueType == null)
		{
			valueType = global::System.Runtime.InteropServices.GCHandle.Alloc(value);
			global::<Module>.?_lock@AtExitLock@<CrtImplementationDetails>@@$$Q0PAXA = global::System.Runtime.InteropServices.GCHandle.ToIntPtr((global::System.Runtime.InteropServices.GCHandle)valueType).ToPointer();
		}
		else
		{
			((global::System.Runtime.InteropServices.GCHandle)valueType).Target = value;
		}
	}

	// Token: 0x06000189 RID: 393 RVA: 0x0000E7D4 File Offset: 0x0000DBD4
	[global::System.Security.SecurityCritical]
	[global::System.Diagnostics.DebuggerStepThrough]
	internal static object <CrtImplementationDetails>.AtExitLock._lock_Get()
	{
		global::System.ValueType valueType = global::<Module>.<CrtImplementationDetails>.AtExitLock._handle();
		if (valueType != null)
		{
			return ((global::System.Runtime.InteropServices.GCHandle)valueType).Target;
		}
		return null;
	}

	// Token: 0x0600018A RID: 394 RVA: 0x0000E7F8 File Offset: 0x0000DBF8
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.Security.SecurityCritical]
	internal static void <CrtImplementationDetails>.AtExitLock._lock_Destruct()
	{
		global::System.ValueType valueType = global::<Module>.<CrtImplementationDetails>.AtExitLock._handle();
		if (valueType != null)
		{
			((global::System.Runtime.InteropServices.GCHandle)valueType).Free();
			global::<Module>.?_lock@AtExitLock@<CrtImplementationDetails>@@$$Q0PAXA = null;
		}
	}

	// Token: 0x0600018B RID: 395 RVA: 0x0000E820 File Offset: 0x0000DC20
	[global::System.Security.SecuritySafeCritical]
	[global::System.Diagnostics.DebuggerStepThrough]
	[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
	internal static bool <CrtImplementationDetails>.AtExitLock.IsInitialized()
	{
		return (global::<Module>.<CrtImplementationDetails>.AtExitLock._lock_Get() != null) ? 1 : 0;
	}

	// Token: 0x0600018C RID: 396 RVA: 0x0000EC74 File Offset: 0x0000E074
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.Security.SecurityCritical]
	internal static void <CrtImplementationDetails>.AtExitLock.AddRef()
	{
		if (global::<Module>.<CrtImplementationDetails>.AtExitLock.IsInitialized() == null)
		{
			global::<Module>.<CrtImplementationDetails>.AtExitLock._lock_Construct(new object());
			global::<Module>.?_ref_count@AtExitLock@<CrtImplementationDetails>@@$$Q0HA = 0;
		}
		global::<Module>.?_ref_count@AtExitLock@<CrtImplementationDetails>@@$$Q0HA++;
	}

	// Token: 0x0600018D RID: 397 RVA: 0x0000E83C File Offset: 0x0000DC3C
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.Security.SecurityCritical]
	internal static void <CrtImplementationDetails>.AtExitLock.RemoveRef()
	{
		global::<Module>.?_ref_count@AtExitLock@<CrtImplementationDetails>@@$$Q0HA--;
		if (global::<Module>.?_ref_count@AtExitLock@<CrtImplementationDetails>@@$$Q0HA == 0)
		{
			global::<Module>.<CrtImplementationDetails>.AtExitLock._lock_Destruct();
		}
	}

	// Token: 0x0600018E RID: 398 RVA: 0x0000E864 File Offset: 0x0000DC64
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.Security.SecurityCritical]
	internal static void <CrtImplementationDetails>.AtExitLock.Enter()
	{
		global::System.Threading.Monitor.Enter(global::<Module>.<CrtImplementationDetails>.AtExitLock._lock_Get());
	}

	// Token: 0x0600018F RID: 399 RVA: 0x0000E87C File Offset: 0x0000DC7C
	[global::System.Security.SecurityCritical]
	[global::System.Diagnostics.DebuggerStepThrough]
	internal static void <CrtImplementationDetails>.AtExitLock.Exit()
	{
		global::System.Threading.Monitor.Exit(global::<Module>.<CrtImplementationDetails>.AtExitLock._lock_Get());
	}

	// Token: 0x06000190 RID: 400 RVA: 0x0000E894 File Offset: 0x0000DC94
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.Security.SecurityCritical]
	[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
	internal static bool __global_lock()
	{
		bool result = false;
		if (global::<Module>.<CrtImplementationDetails>.AtExitLock.IsInitialized() != null)
		{
			global::<Module>.<CrtImplementationDetails>.AtExitLock.Enter();
			result = true;
		}
		return result;
	}

	// Token: 0x06000191 RID: 401 RVA: 0x0000E8B4 File Offset: 0x0000DCB4
	[global::System.Security.SecurityCritical]
	[global::System.Diagnostics.DebuggerStepThrough]
	[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
	internal static bool __global_unlock()
	{
		bool result = false;
		if (global::<Module>.<CrtImplementationDetails>.AtExitLock.IsInitialized() != null)
		{
			global::<Module>.<CrtImplementationDetails>.AtExitLock.Exit();
			result = true;
		}
		return result;
	}

	// Token: 0x06000192 RID: 402 RVA: 0x0000ECA4 File Offset: 0x0000E0A4
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.Security.SecurityCritical]
	[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
	internal static bool __alloc_global_lock()
	{
		global::<Module>.<CrtImplementationDetails>.AtExitLock.AddRef();
		return global::<Module>.<CrtImplementationDetails>.AtExitLock.IsInitialized();
	}

	// Token: 0x06000193 RID: 403 RVA: 0x0000E8D4 File Offset: 0x0000DCD4
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.Security.SecurityCritical]
	internal static void __dealloc_global_lock()
	{
		global::<Module>.<CrtImplementationDetails>.AtExitLock.RemoveRef();
	}

	// Token: 0x06000194 RID: 404 RVA: 0x0000E8E8 File Offset: 0x0000DCE8
	[global::System.Security.SecurityCritical]
	internal unsafe static int _atexit_helper(global::method func, uint* __pexit_list_size, global::method** __ponexitend_e, global::method** __ponexitbegin_e)
	{
		global::method system.Void_u0020() = 0;
		if (func == null)
		{
			return -1;
		}
		if (global::<Module>.?A0xe62d03cb.__global_lock() == 1)
		{
			try
			{
				global::method* ptr = (global::method*)global::<Module>.DecodePointer(*(int*)__ponexitbegin_e);
				global::method* ptr2 = (global::method*)global::<Module>.DecodePointer(*(int*)__ponexitend_e);
				int num = (int)(ptr2 - ptr);
				if (*__pexit_list_size - 1U < (uint)num >> 2)
				{
					try
					{
						uint num2 = *__pexit_list_size * 4U;
						uint num3;
						if (num2 < 2048U)
						{
							num3 = num2;
						}
						else
						{
							num3 = 2048U;
						}
						global::System.IntPtr cb = new global::System.IntPtr((int)(num2 + num3));
						global::System.IntPtr pv = new global::System.IntPtr((void*)ptr);
						global::System.IntPtr intPtr = global::System.Runtime.InteropServices.Marshal.ReAllocHGlobal(pv, cb);
						global::System.IntPtr intPtr2 = intPtr;
						ptr2 = (global::method*)((byte*)intPtr2.ToPointer() + num);
						ptr = (global::method*)intPtr2.ToPointer();
						uint num4 = *__pexit_list_size;
						uint num5;
						if (512U < num4)
						{
							num5 = 512U;
						}
						else
						{
							num5 = num4;
						}
						*__pexit_list_size = num4 + num5;
					}
					catch (global::System.OutOfMemoryException)
					{
						global::System.IntPtr cb2 = new global::System.IntPtr((int)(*__pexit_list_size * 4U + 8U));
						global::System.IntPtr pv2 = new global::System.IntPtr((void*)ptr);
						global::System.IntPtr intPtr3 = global::System.Runtime.InteropServices.Marshal.ReAllocHGlobal(pv2, cb2);
						global::System.IntPtr intPtr4 = intPtr3;
						ptr2 = (intPtr4.ToPointer() - ptr) / (global::System.IntPtr)sizeof(global::method) + ptr2;
						ptr = (global::method*)intPtr4.ToPointer();
						*__pexit_list_size += 4U;
					}
				}
				*(int*)ptr2 = func;
				ptr2 += 4 / sizeof(global::method);
				system.Void_u0020() = func;
				*(int*)__ponexitbegin_e = global::<Module>.EncodePointer((void*)ptr);
				*(int*)__ponexitend_e = global::<Module>.EncodePointer((void*)ptr2);
			}
			catch (global::System.OutOfMemoryException)
			{
			}
			finally
			{
				global::<Module>.?A0xe62d03cb.__global_unlock();
			}
			if (system.Void_u0020() != null)
			{
				return 0;
			}
		}
		return -1;
	}

	// Token: 0x06000195 RID: 405 RVA: 0x0000EA6C File Offset: 0x0000DE6C
	[global::System.Security.SecurityCritical]
	internal unsafe static void _exit_callback()
	{
		if (global::<Module>.?A0xe62d03cb.__exit_list_size != 0U)
		{
			global::method* ptr = (global::method*)global::<Module>.DecodePointer((void*)global::<Module>.?A0xe62d03cb.__onexitbegin_m);
			global::method* ptr2 = (global::method*)global::<Module>.DecodePointer((void*)global::<Module>.?A0xe62d03cb.__onexitend_m);
			if (ptr != -1 && ptr != null && ptr2 != null)
			{
				global::method* ptr3 = ptr;
				global::method* ptr4 = ptr2;
				for (;;)
				{
					ptr2 -= 4 / sizeof(global::method);
					if (ptr2 < ptr)
					{
						break;
					}
					if (*(int*)ptr2 != global::<Module>.EncodePointer(null))
					{
						void* ptr5 = global::<Module>.DecodePointer(*(int*)ptr2);
						*(int*)ptr2 = global::<Module>.EncodePointer(null);
						calli(System.Void(), ptr5);
						global::method* ptr6 = (global::method*)global::<Module>.DecodePointer((void*)global::<Module>.?A0xe62d03cb.__onexitbegin_m);
						global::method* ptr7 = (global::method*)global::<Module>.DecodePointer((void*)global::<Module>.?A0xe62d03cb.__onexitend_m);
						if (ptr3 != ptr6 || ptr4 != ptr7)
						{
							ptr3 = ptr6;
							ptr = ptr6;
							ptr4 = ptr7;
							ptr2 = ptr7;
						}
					}
				}
				global::System.IntPtr hglobal = new global::System.IntPtr((void*)ptr);
				global::System.Runtime.InteropServices.Marshal.FreeHGlobal(hglobal);
			}
			global::<Module>.?A0xe62d03cb.__dealloc_global_lock();
		}
	}

	// Token: 0x06000196 RID: 406 RVA: 0x0000ECBC File Offset: 0x0000E0BC
	[global::System.Security.SecurityCritical]
	[global::System.Diagnostics.DebuggerStepThrough]
	internal unsafe static int _initatexit_m()
	{
		int result = 0;
		if (global::<Module>.?A0xe62d03cb.__alloc_global_lock() == 1)
		{
			global::<Module>.?A0xe62d03cb.__onexitbegin_m = (global::method*)global::<Module>.EncodePointer(global::System.Runtime.InteropServices.Marshal.AllocHGlobal(128).ToPointer());
			global::<Module>.?A0xe62d03cb.__onexitend_m = global::<Module>.?A0xe62d03cb.__onexitbegin_m;
			global::<Module>.?A0xe62d03cb.__exit_list_size = 32U;
			result = 1;
		}
		return result;
	}

	// Token: 0x06000197 RID: 407 RVA: 0x0000ED08 File Offset: 0x0000E108
	internal static global::method _onexit_m(global::method _Function)
	{
		return (global::<Module>._atexit_m(_Function) == -1) ? 0 : _Function;
	}

	// Token: 0x06000198 RID: 408 RVA: 0x0000EB18 File Offset: 0x0000DF18
	[global::System.Security.SecurityCritical]
	internal unsafe static int _atexit_m(global::method func)
	{
		return global::<Module>._atexit_helper(global::<Module>.EncodePointer(func), &global::<Module>.?A0xe62d03cb.__exit_list_size, &global::<Module>.?A0xe62d03cb.__onexitend_m, &global::<Module>.?A0xe62d03cb.__onexitbegin_m);
	}

	// Token: 0x06000199 RID: 409 RVA: 0x0000ED28 File Offset: 0x0000E128
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.Security.SecurityCritical]
	internal unsafe static int _initatexit_app_domain()
	{
		if (global::<Module>.?A0xe62d03cb.__alloc_global_lock() == 1)
		{
			global::<Module>.__onexitbegin_app_domain = (global::method*)global::<Module>.EncodePointer(global::System.Runtime.InteropServices.Marshal.AllocHGlobal(128).ToPointer());
			global::<Module>.__onexitend_app_domain = global::<Module>.__onexitbegin_app_domain;
			global::<Module>.__exit_list_size_app_domain = 32U;
		}
		return 1;
	}

	// Token: 0x0600019A RID: 410 RVA: 0x0000EB48 File Offset: 0x0000DF48
	[global::System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
	[global::System.Security.SecurityCritical]
	internal unsafe static void _app_exit_callback()
	{
		if (global::<Module>.__exit_list_size_app_domain != 0U)
		{
			global::method* ptr = (global::method*)global::<Module>.DecodePointer((void*)global::<Module>.__onexitbegin_app_domain);
			global::method* ptr2 = (global::method*)global::<Module>.DecodePointer((void*)global::<Module>.__onexitend_app_domain);
			try
			{
				if (ptr != -1 && ptr != null && ptr2 != null)
				{
					global::method* ptr3 = ptr;
					global::method* ptr4 = ptr2;
					for (;;)
					{
						do
						{
							ptr2 -= 4 / sizeof(global::method);
						}
						while (ptr2 >= ptr && *(int*)ptr2 == global::<Module>.EncodePointer(null));
						if (ptr2 < ptr)
						{
							break;
						}
						global::method system.Void_u0020() = global::<Module>.DecodePointer(*(int*)ptr2);
						*(int*)ptr2 = global::<Module>.EncodePointer(null);
						calli(System.Void(), system.Void_u0020());
						global::method* ptr5 = (global::method*)global::<Module>.DecodePointer((void*)global::<Module>.__onexitbegin_app_domain);
						global::method* ptr6 = (global::method*)global::<Module>.DecodePointer((void*)global::<Module>.__onexitend_app_domain);
						if (ptr3 != ptr5 || ptr4 != ptr6)
						{
							ptr3 = ptr5;
							ptr = ptr5;
							ptr4 = ptr6;
							ptr2 = ptr6;
						}
					}
				}
			}
			finally
			{
				global::System.IntPtr hglobal = new global::System.IntPtr((void*)ptr);
				global::System.Runtime.InteropServices.Marshal.FreeHGlobal(hglobal);
				global::<Module>.?A0xe62d03cb.__dealloc_global_lock();
			}
		}
	}

	// Token: 0x0600019B RID: 411 RVA: 0x0000ED74 File Offset: 0x0000E174
	[global::System.Security.SecurityCritical]
	internal static global::method _onexit_m_appdomain(global::method _Function)
	{
		return (global::<Module>._atexit_m_appdomain(_Function) == -1) ? 0 : _Function;
	}

	// Token: 0x0600019C RID: 412 RVA: 0x0000EC28 File Offset: 0x0000E028
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.Security.SecurityCritical]
	internal unsafe static int _atexit_m_appdomain(global::method func)
	{
		return global::<Module>._atexit_helper(global::<Module>.EncodePointer(func), &global::<Module>.__exit_list_size_app_domain, &global::<Module>.__onexitend_app_domain, &global::<Module>.__onexitbegin_app_domain);
	}

	// Token: 0x0600019D RID: 413
	[global::System.Security.SecurityCritical]
	[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.Success)]
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("KERNEL32.dll")]
	public unsafe static extern void* DecodePointer(void* Ptr);

	// Token: 0x0600019E RID: 414
	[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.Success)]
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Security.SecurityCritical]
	[global::System.Runtime.InteropServices.DllImport("KERNEL32.dll")]
	public unsafe static extern void* EncodePointer(void* Ptr);

	// Token: 0x0600019F RID: 415 RVA: 0x0000EDE8 File Offset: 0x0000E1E8
	[global::System.Security.SecurityCritical]
	[global::System.Diagnostics.DebuggerStepThrough]
	internal unsafe static int _initterm_e(global::method* pfbegin, global::method* pfend)
	{
		int num = 0;
		if (pfbegin < pfend)
		{
			while (num == 0)
			{
				uint num2 = (uint)(*(int*)pfbegin);
				if (num2 != 0U)
				{
					num = calli(System.Int32 modopt(System.Runtime.CompilerServices.CallConvCdecl)(), num2);
				}
				pfbegin += 4 / sizeof(global::method);
				if (pfbegin >= pfend)
				{
					break;
				}
			}
		}
		return num;
	}

	// Token: 0x060001A0 RID: 416 RVA: 0x0000EE1C File Offset: 0x0000E21C
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.Security.SecurityCritical]
	internal unsafe static void _initterm(global::method* pfbegin, global::method* pfend)
	{
		if (pfbegin < pfend)
		{
			do
			{
				uint num = (uint)(*(int*)pfbegin);
				if (num != 0U)
				{
					calli(System.Void modopt(System.Runtime.CompilerServices.CallConvCdecl)(), num);
				}
				pfbegin += 4 / sizeof(global::method);
			}
			while (pfbegin < pfend);
		}
	}

	// Token: 0x060001A1 RID: 417 RVA: 0x0000EE48 File Offset: 0x0000E248
	[global::System.Diagnostics.DebuggerStepThrough]
	internal static global::System.ModuleHandle <CrtImplementationDetails>.ThisModule.Handle()
	{
		return typeof(global::<CrtImplementationDetails>.ThisModule).Module.ModuleHandle;
	}

	// Token: 0x060001A2 RID: 418 RVA: 0x0000EE98 File Offset: 0x0000E298
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.Security.SecurityCritical]
	[global::System.Security.Permissions.SecurityPermission(global::System.Security.Permissions.SecurityAction.Assert, UnmanagedCode = true)]
	internal unsafe static void _initterm_m(global::method* pfbegin, global::method* pfend)
	{
		if (pfbegin < pfend)
		{
			do
			{
				uint num = (uint)(*(int*)pfbegin);
				if (num != 0U)
				{
					object obj = calli(System.Void modopt(System.Runtime.CompilerServices.IsConst)*(), global::<Module>.<CrtImplementationDetails>.ThisModule.ResolveMethod<void\u0020const\u0020*\u0020__clrcall(void)>(num));
				}
				pfbegin += 4 / sizeof(global::method);
			}
			while (pfbegin < pfend);
		}
	}

	// Token: 0x060001A3 RID: 419 RVA: 0x0000EE6C File Offset: 0x0000E26C
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.Security.SecurityCritical]
	internal static global::method <CrtImplementationDetails>.ThisModule.ResolveMethod<void\u0020const\u0020*\u0020__clrcall(void)>(global::method methodToken)
	{
		return global::<Module>.<CrtImplementationDetails>.ThisModule.Handle().ResolveMethodHandle(methodToken).GetFunctionPointer().ToPointer();
	}

	// Token: 0x060001A4 RID: 420 RVA: 0x0000EF78 File Offset: 0x0000E378
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern void _Orphan_all(global::std._Container_base0*);

	// Token: 0x060001A5 RID: 421 RVA: 0x0000EF24 File Offset: 0x0000E324
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern void* @new(uint);

	// Token: 0x060001A6 RID: 422 RVA: 0x0000EF30 File Offset: 0x0000E330
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal static extern int __CxxQueryExceptionSize();

	// Token: 0x060001A7 RID: 423 RVA: 0x0000EF48 File Offset: 0x0000E348
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern int __CxxDetectRethrow(void*);

	// Token: 0x060001A8 RID: 424 RVA: 0x0000EF42 File Offset: 0x0000E342
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.StdCall, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern void _CxxThrowException(void*, global::_s__ThrowInfo*);

	// Token: 0x060001A9 RID: 425 RVA: 0x0000EF0C File Offset: 0x0000E30C
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal static extern double _hypot(double, double);

	// Token: 0x060001AA RID: 426 RVA: 0x0000EF5A File Offset: 0x0000E35A
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal static extern global::_ldiv_t ldiv(int, int);

	// Token: 0x060001AB RID: 427 RVA: 0x0000EF4E File Offset: 0x0000E34E
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern void __CxxUnregisterExceptionObject(void*, int);

	// Token: 0x060001AC RID: 428 RVA: 0x0000EF1E File Offset: 0x0000E31E
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern void delete(void*);

	// Token: 0x060001AD RID: 429 RVA: 0x0000EF36 File Offset: 0x0000E336
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern int __CxxExceptionFilter(void*, void*, int, void*);

	// Token: 0x060001AE RID: 430 RVA: 0x0000EF18 File Offset: 0x0000E318
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern void delete[](void*);

	// Token: 0x060001AF RID: 431 RVA: 0x0000EF3C File Offset: 0x0000E33C
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern int __CxxRegisterExceptionObject(void*, void*);

	// Token: 0x060001B0 RID: 432 RVA: 0x0000EF54 File Offset: 0x0000E354
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern void* new[](uint);

	// Token: 0x060001B1 RID: 433 RVA: 0x0000EF2A File Offset: 0x0000E32A
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern void* memmove(void*, void*, uint);

	// Token: 0x060001B2 RID: 434 RVA: 0x0000EF12 File Offset: 0x0000E312
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern void __ExceptionPtrCopy(void*, void*);

	// Token: 0x060001B3 RID: 435 RVA: 0x0000EF6C File Offset: 0x0000E36C
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern void _Xlength_error(sbyte*);

	// Token: 0x060001B4 RID: 436 RVA: 0x0000EF72 File Offset: 0x0000E372
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal static extern void _Xbad_alloc();

	// Token: 0x060001B5 RID: 437 RVA: 0x0000DDC5 File Offset: 0x0000D1C5
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged | global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]
	internal unsafe static extern void* _getFiberPtrId();

	// Token: 0x060001B6 RID: 438 RVA: 0x0000D0E6 File Offset: 0x0000C4E6
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal static extern void _amsg_exit(int);

	// Token: 0x060001B7 RID: 439 RVA: 0x0000D332 File Offset: 0x0000C732
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged | global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]
	internal static extern void __security_init_cookie();

	// Token: 0x060001B8 RID: 440 RVA: 0x0000EF7E File Offset: 0x0000E37E
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.StdCall, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal static extern void Sleep(uint);

	// Token: 0x060001B9 RID: 441 RVA: 0x0000EF60 File Offset: 0x0000E360
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal static extern void _cexit();

	// Token: 0x060001BA RID: 442 RVA: 0x0000EF66 File Offset: 0x0000E366
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern int __FrameUnwindFilter(global::_EXCEPTION_POINTERS*);

	// Token: 0x04000001 RID: 1 RVA: 0x0000F158 File Offset: 0x0000E558
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0BD@$$CBD ??_C@_0BD@OLBABOEK@vector?$DMT?$DO?5too?5long?$AA@;

	// Token: 0x04000002 RID: 2 RVA: 0x000299D3 File Offset: 0x000281D3
	internal static global::std.piecewise_construct_t piecewise_construct;

	// Token: 0x04000003 RID: 3 RVA: 0x000299D2 File Offset: 0x000281D2
	internal static global::std.allocator_arg_t allocator_arg;

	// Token: 0x04000004 RID: 4 RVA: 0x000299D1 File Offset: 0x000281D1
	internal static global::std._Ignore ignore;

	// Token: 0x04000005 RID: 5 RVA: 0x000299D0 File Offset: 0x000281D0
	internal static global::std._Tuple_alloc_t _Tuple_alloc;

	// Token: 0x04000006 RID: 6 RVA: 0x000299D4 File Offset: 0x000281D4
	internal static int __@@_PchSym_@00@UBDIUFAEUhlfixvhUxlnnlmPxkhPkozguinUrnkovnvmgzgrlmUinCOAUxlnnlmPxlnnfmrxzgrlmUxlwvUxlnnlmxlnnfmrxzgrlmUuwrhbhgvnUivovzhvUhgwzucOlyq@5155A87A9EDE2579;

	// Token: 0x04000007 RID: 7 RVA: 0x0000F190 File Offset: 0x0000E590
	internal static global::__s_GUID _GUID_90f1a06e_7712_4762_86b5_7a5eba6bdb02;

	// Token: 0x04000008 RID: 8 RVA: 0x0000F1C0 File Offset: 0x0000E5C0
	internal static global::__s_GUID _GUID_cb2f6722_ab3a_11d2_9c40_00c04fa30a3e;

	// Token: 0x04000009 RID: 9 RVA: 0x0000F108 File Offset: 0x0000E508
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY00Q6MPBXXZ __xc_mp_z;

	// Token: 0x0400000A RID: 10
	[global::System.Runtime.CompilerServices.FixedAddressValueType]
	internal static int ?Uninitialized@CurrentDomain@<CrtImplementationDetails>@@$$Q2HA;

	// Token: 0x0400000B RID: 11 RVA: 0x0000F0E8 File Offset: 0x0000E4E8
	internal static global::method ?Uninitialized$initializer$@CurrentDomain@<CrtImplementationDetails>@@$$Q2P6MXXZA;

	// Token: 0x0400000C RID: 12 RVA: 0x0000F10C File Offset: 0x0000E50C
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY00Q6MPBXXZ __xi_vt_a;

	// Token: 0x0400000D RID: 13
	[global::System.Runtime.CompilerServices.FixedAddressValueType]
	internal static global::<CrtImplementationDetails>.Progress.State ?InitializedPerAppDomain@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A;

	// Token: 0x0400000E RID: 14 RVA: 0x0000F0FC File Offset: 0x0000E4FC
	internal static global::method ?InitializedPerAppDomain$initializer$@CurrentDomain@<CrtImplementationDetails>@@$$Q2P6MXXZA;

	// Token: 0x0400000F RID: 15
	[global::System.Runtime.CompilerServices.FixedAddressValueType]
	internal static bool ?IsDefaultDomain@CurrentDomain@<CrtImplementationDetails>@@$$Q2_NA;

	// Token: 0x04000010 RID: 16 RVA: 0x0000F0EC File Offset: 0x0000E4EC
	internal static global::method ?IsDefaultDomain$initializer$@CurrentDomain@<CrtImplementationDetails>@@$$Q2P6MXXZA;

	// Token: 0x04000011 RID: 17 RVA: 0x0000F0E0 File Offset: 0x0000E4E0
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY00Q6MPBXXZ __xc_ma_a;

	// Token: 0x04000012 RID: 18
	[global::System.Runtime.CompilerServices.FixedAddressValueType]
	internal static global::<CrtImplementationDetails>.Progress.State ?InitializedNative@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A;

	// Token: 0x04000013 RID: 19 RVA: 0x0000F0F4 File Offset: 0x0000E4F4
	internal static global::method ?InitializedNative$initializer$@CurrentDomain@<CrtImplementationDetails>@@$$Q2P6MXXZA;

	// Token: 0x04000014 RID: 20
	[global::System.Runtime.CompilerServices.FixedAddressValueType]
	internal static int ?Initialized@CurrentDomain@<CrtImplementationDetails>@@$$Q2HA;

	// Token: 0x04000015 RID: 21 RVA: 0x0000F0E4 File Offset: 0x0000E4E4
	internal static global::method ?Initialized$initializer$@CurrentDomain@<CrtImplementationDetails>@@$$Q2P6MXXZA;

	// Token: 0x04000016 RID: 22 RVA: 0x0000F100 File Offset: 0x0000E500
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY00Q6MPBXXZ __xc_ma_z;

	// Token: 0x04000017 RID: 23
	[global::System.Runtime.CompilerServices.FixedAddressValueType]
	internal static global::<CrtImplementationDetails>.Progress.State ?InitializedVtables@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A;

	// Token: 0x04000018 RID: 24 RVA: 0x0000F0F0 File Offset: 0x0000E4F0
	internal static global::method ?InitializedVtables$initializer$@CurrentDomain@<CrtImplementationDetails>@@$$Q2P6MXXZA;

	// Token: 0x04000019 RID: 25 RVA: 0x0000F110 File Offset: 0x0000E510
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY00Q6MPBXXZ __xi_vt_z;

	// Token: 0x0400001A RID: 26 RVA: 0x0000F1B0 File Offset: 0x0000E5B0
	internal static global::__s_GUID _GUID_cb2f6723_ab3a_11d2_9c40_00c04fa30a3e;

	// Token: 0x0400001B RID: 27
	[global::System.Runtime.CompilerServices.FixedAddressValueType]
	internal static global::<CrtImplementationDetails>.Progress.State ?InitializedPerProcess@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A;

	// Token: 0x0400001C RID: 28 RVA: 0x0000F0F8 File Offset: 0x0000E4F8
	internal static global::method ?InitializedPerProcess$initializer$@CurrentDomain@<CrtImplementationDetails>@@$$Q2P6MXXZA;

	// Token: 0x0400001D RID: 29 RVA: 0x00029D0F File Offset: 0x0002850F
	internal static bool ?InitializedPerProcess@DefaultDomain@<CrtImplementationDetails>@@2_NA;

	// Token: 0x0400001E RID: 30 RVA: 0x00029D0C File Offset: 0x0002850C
	internal static bool ?Entered@DefaultDomain@<CrtImplementationDetails>@@2_NA;

	// Token: 0x0400001F RID: 31 RVA: 0x00029D0D File Offset: 0x0002850D
	internal static bool ?InitializedNative@DefaultDomain@<CrtImplementationDetails>@@2_NA;

	// Token: 0x04000020 RID: 32 RVA: 0x00029D08 File Offset: 0x00028508
	internal static int ?Count@AllDomains@<CrtImplementationDetails>@@2HA;

	// Token: 0x04000021 RID: 33 RVA: 0x0000F174 File Offset: 0x0000E574
	internal static uint ?ProcessAttach@NativeDll@<CrtImplementationDetails>@@0IB;

	// Token: 0x04000022 RID: 34 RVA: 0x0000F178 File Offset: 0x0000E578
	internal static uint ?ThreadAttach@NativeDll@<CrtImplementationDetails>@@0IB;

	// Token: 0x04000023 RID: 35 RVA: 0x00029560 File Offset: 0x00027D60
	internal static global::<CrtImplementationDetails>.TriBool.State ?hasNative@DefaultDomain@<CrtImplementationDetails>@@0W4State@TriBool@2@A;

	// Token: 0x04000024 RID: 36 RVA: 0x0000F170 File Offset: 0x0000E570
	internal static uint ?ProcessDetach@NativeDll@<CrtImplementationDetails>@@0IB;

	// Token: 0x04000025 RID: 37 RVA: 0x0000F17C File Offset: 0x0000E57C
	internal static uint ?ThreadDetach@NativeDll@<CrtImplementationDetails>@@0IB;

	// Token: 0x04000026 RID: 38 RVA: 0x0000F180 File Offset: 0x0000E580
	internal static uint ?ProcessVerifier@NativeDll@<CrtImplementationDetails>@@0IB;

	// Token: 0x04000027 RID: 39 RVA: 0x0002955C File Offset: 0x00027D5C
	internal static global::<CrtImplementationDetails>.TriBool.State ?hasPerProcess@DefaultDomain@<CrtImplementationDetails>@@0W4State@TriBool@2@A;

	// Token: 0x04000028 RID: 40 RVA: 0x00029D0E File Offset: 0x0002850E
	internal static bool ?InitializedNativeFromCCTOR@DefaultDomain@<CrtImplementationDetails>@@2_NA;

	// Token: 0x04000029 RID: 41 RVA: 0x0000F104 File Offset: 0x0000E504
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY00Q6MPBXXZ __xc_mp_a;

	// Token: 0x0400002A RID: 42 RVA: 0x0000F1A0 File Offset: 0x0000E5A0
	internal static global::__s_GUID _GUID_90f1a06c_7712_4762_86b5_7a5eba6bdb02;

	// Token: 0x0400002B RID: 43 RVA: 0x0000F1D0 File Offset: 0x0000E5D0
	public unsafe static int** __unep@?DoNothing@DefaultDomain@<CrtImplementationDetails>@@$$FCGJPAX@Z;

	// Token: 0x0400002C RID: 44 RVA: 0x0000F1D4 File Offset: 0x0000E5D4
	public unsafe static int** __unep@?_UninitializeDefaultDomain@LanguageSupport@<CrtImplementationDetails>@@$$FCGJPAX@Z;

	// Token: 0x0400002D RID: 45
	[global::System.Runtime.CompilerServices.FixedAddressValueType]
	internal static uint __exit_list_size_app_domain;

	// Token: 0x0400002E RID: 46
	[global::System.Runtime.CompilerServices.FixedAddressValueType]
	internal unsafe static global::method* __onexitbegin_app_domain;

	// Token: 0x0400002F RID: 47 RVA: 0x00029E1C File Offset: 0x0002861C
	internal static uint __exit_list_size;

	// Token: 0x04000030 RID: 48
	[global::System.Runtime.CompilerServices.FixedAddressValueType]
	internal unsafe static global::method* __onexitend_app_domain;

	// Token: 0x04000031 RID: 49 RVA: 0x00029E14 File Offset: 0x00028614
	internal unsafe static global::method* __onexitbegin_m;

	// Token: 0x04000032 RID: 50 RVA: 0x00029E18 File Offset: 0x00028618
	internal unsafe static global::method* __onexitend_m;

	// Token: 0x04000033 RID: 51
	[global::System.Runtime.CompilerServices.FixedAddressValueType]
	internal unsafe static void* ?_lock@AtExitLock@<CrtImplementationDetails>@@$$Q0PAXA;

	// Token: 0x04000034 RID: 52
	[global::System.Runtime.CompilerServices.FixedAddressValueType]
	internal static int ?_ref_count@AtExitLock@<CrtImplementationDetails>@@$$Q0HA;

	// Token: 0x04000035 RID: 53 RVA: 0x0000F0CC File Offset: 0x0000E4CC
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0A@P6AXXZ __xc_z;

	// Token: 0x04000036 RID: 54 RVA: 0x0000F0C8 File Offset: 0x0000E4C8
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0A@P6AXXZ __xc_a;

	// Token: 0x04000037 RID: 55 RVA: 0x0000F0D0 File Offset: 0x0000E4D0
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0A@P6AHXZ __xi_a;

	// Token: 0x04000038 RID: 56 RVA: 0x00029E50 File Offset: 0x00028650
	internal static volatile global::__enative_startup_state __native_startup_state;

	// Token: 0x04000039 RID: 57 RVA: 0x0000F0DC File Offset: 0x0000E4DC
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0A@P6AHXZ __xi_z;

	// Token: 0x0400003A RID: 58 RVA: 0x00029E4C File Offset: 0x0002864C
	internal unsafe static volatile void* __native_startup_lock;

	// Token: 0x0400003B RID: 59 RVA: 0x00029550 File Offset: 0x00027D50
	internal static volatile uint __native_dllmain_reason;
}
