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
using ATL;
using ATL.<AtlImplementationDetails>;
using flex_licensing;
using std;

// Token: 0x02000001 RID: 1
internal class <Module>
{
	// Token: 0x06000001 RID: 1 RVA: 0x00002110 File Offset: 0x00001510
	internal static int HRESULT_FROM_WIN32(uint x)
	{
		return (x > 0) ? ((x & 65535) | 458752 | int.MinValue) : x;
	}

	// Token: 0x06000002 RID: 2 RVA: 0x0000213C File Offset: 0x0000153C
	internal static double hypot(double __unnamed000, double __unnamed001)
	{
		return global::<Module>._hypot(__unnamed000, __unnamed001);
	}

	// Token: 0x06000003 RID: 3 RVA: 0x00002158 File Offset: 0x00001558
	internal unsafe static global::std.exception_ptr* {ctor}(global::std.exception_ptr* A_0, global::std.exception_ptr* _Rhs)
	{
		global::<Module>.__ExceptionPtrCopy(A_0, _Rhs);
		return A_0;
	}

	// Token: 0x06000004 RID: 4 RVA: 0x00002174 File Offset: 0x00001574
	internal unsafe static void* @new(uint __unnamed000, void* _Where)
	{
		return _Where;
	}

	// Token: 0x06000005 RID: 5 RVA: 0x00002184 File Offset: 0x00001584
	internal unsafe static void delete(void* A_0, void* A_1)
	{
	}

	// Token: 0x06000006 RID: 6 RVA: 0x00002194 File Offset: 0x00001594
	internal unsafe static uint length(sbyte* _First)
	{
		return (*(sbyte*)_First != 0) ? global::<Module>.strlen(_First) : 0;
	}

	// Token: 0x06000007 RID: 7 RVA: 0x000021B0 File Offset: 0x000015B0
	internal unsafe static sbyte* copy(sbyte* _First1, sbyte* _First2, uint _Count)
	{
		return (_Count != 0U) ? global::<Module>.memcpy((void*)_First1, (void*)_First2, _Count) : _First1;
	}

	// Token: 0x06000008 RID: 8 RVA: 0x000021D0 File Offset: 0x000015D0
	internal unsafe static sbyte* move(sbyte* _First1, sbyte* _First2, uint _Count)
	{
		return (_Count != 0U) ? global::<Module>.memmove((void*)_First1, (void*)_First2, _Count) : _First1;
	}

	// Token: 0x06000009 RID: 9 RVA: 0x000021F0 File Offset: 0x000015F0
	internal unsafe static void assign(sbyte* _Left, sbyte* _Right)
	{
		*_Left = (byte)(*_Right);
	}

	// Token: 0x0600000A RID: 10 RVA: 0x00001000 File Offset: 0x00000400
	internal static void ??__E?A0xacbfdcdf@piecewise_construct@std@@YMXXZ()
	{
		global::std.piecewise_construct_t piecewise_construct_t;
		initblk(ref piecewise_construct_t, 0, 1);
	}

	// Token: 0x0600000B RID: 11 RVA: 0x00003640 File Offset: 0x00002A40
	internal unsafe static global::std._Iterator_base12* {ctor}(global::std._Iterator_base12* A_0, global::std._Iterator_base12* _Right)
	{
		*A_0 = 0;
		*(A_0 + 4) = 0;
		global::<Module>.std._Iterator_base12.=(A_0, _Right);
		return A_0;
	}

	// Token: 0x0600000C RID: 12 RVA: 0x00003134 File Offset: 0x00002534
	internal unsafe static global::std._Iterator_base12* =(global::std._Iterator_base12* A_0, global::std._Iterator_base12* _Right)
	{
		if (*A_0 != *_Right)
		{
			if (*_Right != 0)
			{
				global::<Module>.std._Iterator_base12._Adopt(A_0, *(*_Right));
			}
		}
		return A_0;
	}

	// Token: 0x0600000D RID: 13 RVA: 0x00002204 File Offset: 0x00001604
	internal unsafe static void _Adopt(global::std._Iterator_base12* A_0, global::std._Container_base12* _Parent)
	{
		if (_Parent != null)
		{
			global::std._Container_proxy* ptr = *(int*)_Parent;
			*A_0 = ptr;
		}
	}

	// Token: 0x0600000E RID: 14 RVA: 0x00001014 File Offset: 0x00000414
	internal static void ??__E?A0xacbfdcdf@allocator_arg@std@@YMXXZ()
	{
		global::std.allocator_arg_t allocator_arg_t;
		initblk(ref allocator_arg_t, 0, 1);
	}

	// Token: 0x0600000F RID: 15 RVA: 0x0000221C File Offset: 0x0000161C
	internal unsafe static global::std.allocator<void>* {ctor}(global::std.allocator<void>* A_0, global::std.allocator<void>* A_0)
	{
		return A_0;
	}

	// Token: 0x06000010 RID: 16 RVA: 0x00004A0C File Offset: 0x00003E0C
	internal unsafe static void* __vecDelDtor(global::std.runtime_error* A_0, uint A_0)
	{
		void* result;
		if ((A_0 & 2U) != 0U)
		{
			global::<Module>.__ehvec_dtor(A_0, 12U, *(A_0 - 4), ldftn(std.runtime_error.{dtor}));
			if ((A_0 & 1U) != 0U)
			{
				global::<Module>.delete[](A_0 - 4);
			}
			result = A_0 - 4;
		}
		else
		{
			global::<Module>.std.runtime_error.{dtor}(A_0);
			if ((A_0 & 1U) != 0U)
			{
				global::<Module>.delete(A_0);
			}
			result = A_0;
		}
		return result;
	}

	// Token: 0x06000011 RID: 17 RVA: 0x00002230 File Offset: 0x00001630
	internal unsafe static void {dtor}(global::std.runtime_error* A_0)
	{
		global::<Module>.std.exception.{dtor}(A_0);
	}

	// Token: 0x06000012 RID: 18 RVA: 0x00004798 File Offset: 0x00003B98
	internal unsafe static int AtlMultiply<unsigned\u0020int>(uint* piResult, uint iLeft, uint iRight)
	{
		ulong num = (ulong)iLeft * (ulong)iRight;
		int result;
		if (num > 4294967295UL)
		{
			result = global::<Module>.HRESULT_FROM_WIN32(534);
		}
		else
		{
			*piResult = (uint)num;
			result = 0;
		}
		return result;
	}

	// Token: 0x06000013 RID: 19 RVA: 0x000048FC File Offset: 0x00003CFC
	internal unsafe static int AtlMultiply<unsigned\u0020long>(uint* piResult, uint iLeft, uint iRight)
	{
		ulong num = iLeft * iRight;
		int result;
		if (num > 4294967295UL)
		{
			result = global::<Module>.HRESULT_FROM_WIN32(534);
		}
		else
		{
			*(int*)piResult = (int)((uint)num);
			result = 0;
		}
		return result;
	}

	// Token: 0x06000014 RID: 20 RVA: 0x00001028 File Offset: 0x00000428
	internal unsafe static void ??__EatlTraceGeneral@ATL@@YMXXZ()
	{
		global::<Module>.ATL.CTraceCategoryEx<1,0>.{ctor}(ref global::<Module>.ATL.atlTraceGeneral, (ushort*)(&global::<Module>.?A0xacbfdcdf.unnamed-global-20));
	}

	// Token: 0x06000015 RID: 21 RVA: 0x00001048 File Offset: 0x00000448
	internal unsafe static void ??__EatlTraceCOM@ATL@@YMXXZ()
	{
		global::<Module>.ATL.CTraceCategoryEx<2,0>.{ctor}(ref global::<Module>.ATL.atlTraceCOM, (ushort*)(&global::<Module>.?A0xacbfdcdf.unnamed-global-21));
	}

	// Token: 0x06000016 RID: 22 RVA: 0x00001068 File Offset: 0x00000468
	internal unsafe static void ??__EatlTraceQI@ATL@@YMXXZ()
	{
		global::<Module>.ATL.CTraceCategoryEx<4,0>.{ctor}(ref global::<Module>.ATL.atlTraceQI, (ushort*)(&global::<Module>.?A0xacbfdcdf.unnamed-global-22));
	}

	// Token: 0x06000017 RID: 23 RVA: 0x00001088 File Offset: 0x00000488
	internal unsafe static void ??__EatlTraceRegistrar@ATL@@YMXXZ()
	{
		global::<Module>.ATL.CTraceCategoryEx<8,0>.{ctor}(ref global::<Module>.ATL.atlTraceRegistrar, (ushort*)(&global::<Module>.?A0xacbfdcdf.unnamed-global-23));
	}

	// Token: 0x06000018 RID: 24 RVA: 0x000010A8 File Offset: 0x000004A8
	internal unsafe static void ??__EatlTraceRefcount@ATL@@YMXXZ()
	{
		global::<Module>.ATL.CTraceCategoryEx<16,0>.{ctor}(ref global::<Module>.ATL.atlTraceRefcount, (ushort*)(&global::<Module>.?A0xacbfdcdf.unnamed-global-24));
	}

	// Token: 0x06000019 RID: 25 RVA: 0x000010C8 File Offset: 0x000004C8
	internal unsafe static void ??__EatlTraceWindowing@ATL@@YMXXZ()
	{
		global::<Module>.ATL.CTraceCategoryEx<32,0>.{ctor}(ref global::<Module>.ATL.atlTraceWindowing, (ushort*)(&global::<Module>.?A0xacbfdcdf.unnamed-global-25));
	}

	// Token: 0x0600001A RID: 26 RVA: 0x000010E8 File Offset: 0x000004E8
	internal unsafe static void ??__EatlTraceControls@ATL@@YMXXZ()
	{
		global::<Module>.ATL.CTraceCategoryEx<64,0>.{ctor}(ref global::<Module>.ATL.atlTraceControls, (ushort*)(&global::<Module>.?A0xacbfdcdf.unnamed-global-26));
	}

	// Token: 0x0600001B RID: 27 RVA: 0x00001108 File Offset: 0x00000508
	internal unsafe static void ??__EatlTraceHosting@ATL@@YMXXZ()
	{
		global::<Module>.ATL.CTraceCategoryEx<128,0>.{ctor}(ref global::<Module>.ATL.atlTraceHosting, (ushort*)(&global::<Module>.?A0xacbfdcdf.unnamed-global-27));
	}

	// Token: 0x0600001C RID: 28 RVA: 0x00001128 File Offset: 0x00000528
	internal unsafe static void ??__EatlTraceDBClient@ATL@@YMXXZ()
	{
		global::<Module>.ATL.CTraceCategoryEx<256,0>.{ctor}(ref global::<Module>.ATL.atlTraceDBClient, (ushort*)(&global::<Module>.?A0xacbfdcdf.unnamed-global-28));
	}

	// Token: 0x0600001D RID: 29 RVA: 0x00001148 File Offset: 0x00000548
	internal unsafe static void ??__EatlTraceDBProvider@ATL@@YMXXZ()
	{
		global::<Module>.ATL.CTraceCategoryEx<512,0>.{ctor}(ref global::<Module>.ATL.atlTraceDBProvider, (ushort*)(&global::<Module>.?A0xacbfdcdf.unnamed-global-29));
	}

	// Token: 0x0600001E RID: 30 RVA: 0x00001168 File Offset: 0x00000568
	internal unsafe static void ??__EatlTraceSnapin@ATL@@YMXXZ()
	{
		global::<Module>.ATL.CTraceCategoryEx<1024,0>.{ctor}(ref global::<Module>.ATL.atlTraceSnapin, (ushort*)(&global::<Module>.?A0xacbfdcdf.unnamed-global-30));
	}

	// Token: 0x0600001F RID: 31 RVA: 0x00001188 File Offset: 0x00000588
	internal unsafe static void ??__EatlTraceNotImpl@ATL@@YMXXZ()
	{
		global::<Module>.ATL.CTraceCategoryEx<2048,0>.{ctor}(ref global::<Module>.ATL.atlTraceNotImpl, (ushort*)(&global::<Module>.?A0xacbfdcdf.unnamed-global-31));
	}

	// Token: 0x06000020 RID: 32 RVA: 0x000011A8 File Offset: 0x000005A8
	internal unsafe static void ??__EatlTraceAllocation@ATL@@YMXXZ()
	{
		global::<Module>.ATL.CTraceCategoryEx<4096,0>.{ctor}(ref global::<Module>.ATL.atlTraceAllocation, (ushort*)(&global::<Module>.?A0xacbfdcdf.unnamed-global-32));
	}

	// Token: 0x06000021 RID: 33 RVA: 0x000011C8 File Offset: 0x000005C8
	internal unsafe static void ??__EatlTraceException@ATL@@YMXXZ()
	{
		global::<Module>.ATL.CTraceCategoryEx<8192,0>.{ctor}(ref global::<Module>.ATL.atlTraceException, (ushort*)(&global::<Module>.?A0xacbfdcdf.unnamed-global-33));
	}

	// Token: 0x06000022 RID: 34 RVA: 0x000011E8 File Offset: 0x000005E8
	internal unsafe static void ??__EatlTraceTime@ATL@@YMXXZ()
	{
		global::<Module>.ATL.CTraceCategoryEx<16384,0>.{ctor}(ref global::<Module>.ATL.atlTraceTime, (ushort*)(&global::<Module>.?A0xacbfdcdf.unnamed-global-34));
	}

	// Token: 0x06000023 RID: 35 RVA: 0x00001208 File Offset: 0x00000608
	internal unsafe static void ??__EatlTraceCache@ATL@@YMXXZ()
	{
		global::<Module>.ATL.CTraceCategoryEx<32768,0>.{ctor}(ref global::<Module>.ATL.atlTraceCache, (ushort*)(&global::<Module>.?A0xacbfdcdf.unnamed-global-35));
	}

	// Token: 0x06000024 RID: 36 RVA: 0x00001228 File Offset: 0x00000628
	internal unsafe static void ??__EatlTraceStencil@ATL@@YMXXZ()
	{
		global::<Module>.ATL.CTraceCategoryEx<65536,0>.{ctor}(ref global::<Module>.ATL.atlTraceStencil, (ushort*)(&global::<Module>.?A0xacbfdcdf.unnamed-global-36));
	}

	// Token: 0x06000025 RID: 37 RVA: 0x00001248 File Offset: 0x00000648
	internal unsafe static void ??__EatlTraceString@ATL@@YMXXZ()
	{
		global::<Module>.ATL.CTraceCategoryEx<131072,0>.{ctor}(ref global::<Module>.ATL.atlTraceString, (ushort*)(&global::<Module>.?A0xacbfdcdf.unnamed-global-37));
	}

	// Token: 0x06000026 RID: 38 RVA: 0x00001268 File Offset: 0x00000668
	internal unsafe static void ??__EatlTraceMap@ATL@@YMXXZ()
	{
		global::<Module>.ATL.CTraceCategoryEx<262144,0>.{ctor}(ref global::<Module>.ATL.atlTraceMap, (ushort*)(&global::<Module>.?A0xacbfdcdf.unnamed-global-38));
	}

	// Token: 0x06000027 RID: 39 RVA: 0x00001288 File Offset: 0x00000688
	internal unsafe static void ??__EatlTraceUtil@ATL@@YMXXZ()
	{
		global::<Module>.ATL.CTraceCategoryEx<524288,0>.{ctor}(ref global::<Module>.ATL.atlTraceUtil, (ushort*)(&global::<Module>.?A0xacbfdcdf.unnamed-global-39));
	}

	// Token: 0x06000028 RID: 40 RVA: 0x000012A8 File Offset: 0x000006A8
	internal unsafe static void ??__EatlTraceSecurity@ATL@@YMXXZ()
	{
		global::<Module>.ATL.CTraceCategoryEx<1048576,0>.{ctor}(ref global::<Module>.ATL.atlTraceSecurity, (ushort*)(&global::<Module>.?A0xacbfdcdf.unnamed-global-40));
	}

	// Token: 0x06000029 RID: 41 RVA: 0x000012C8 File Offset: 0x000006C8
	internal unsafe static void ??__EatlTraceSync@ATL@@YMXXZ()
	{
		global::<Module>.ATL.CTraceCategoryEx<2097152,0>.{ctor}(ref global::<Module>.ATL.atlTraceSync, (ushort*)(&global::<Module>.?A0xacbfdcdf.unnamed-global-41));
	}

	// Token: 0x0600002A RID: 42 RVA: 0x000012E8 File Offset: 0x000006E8
	internal unsafe static void ??__EatlTraceISAPI@ATL@@YMXXZ()
	{
		global::<Module>.ATL.CTraceCategoryEx<4194304,0>.{ctor}(ref global::<Module>.ATL.atlTraceISAPI, (ushort*)(&global::<Module>.?A0xacbfdcdf.unnamed-global-42));
	}

	// Token: 0x0600002B RID: 43 RVA: 0x00002244 File Offset: 0x00001644
	internal static void _AtlRaiseException(uint dwExceptionCode, uint dwExceptionFlags)
	{
		global::<Module>.RaiseException(dwExceptionCode, dwExceptionFlags, 0, null);
	}

	// Token: 0x0600002C RID: 44 RVA: 0x0000225C File Offset: 0x0000165C
	internal unsafe static global::ATL.CAtlException* {ctor}(global::ATL.CAtlException* A_0, int hr)
	{
		*A_0 = hr;
		return A_0;
	}

	// Token: 0x0600002D RID: 45 RVA: 0x00002270 File Offset: 0x00001670
	internal unsafe static void AtlThrowImpl(int hr)
	{
		global::ATL.CAtlException ex;
		global::ATL.CAtlException ex2;
		cpblk(ref ex, global::<Module>.ATL.CAtlException.{ctor}(ref ex2, hr), 4);
		global::<Module>._CxxThrowException((void*)(&ex), (global::_s__ThrowInfo*)(&global::<Module>._TI1?AVCAtlException@ATL@@));
	}

	// Token: 0x0600002E RID: 46 RVA: 0x000022B4 File Offset: 0x000016B4
	internal unsafe static global::ATL.CComCriticalSection* {ctor}(global::ATL.CComCriticalSection* A_0)
	{
		global::<Module>.memset(A_0, 0, 24U);
		return A_0;
	}

	// Token: 0x0600002F RID: 47 RVA: 0x000022CC File Offset: 0x000016CC
	internal unsafe static void {dtor}(global::ATL.CComCriticalSection* A_0)
	{
	}

	// Token: 0x06000030 RID: 48 RVA: 0x000022DC File Offset: 0x000016DC
	internal unsafe static int Init(global::ATL.CComCriticalSection* A_0)
	{
		int result = 0;
		if (global::<Module>.ATL._AtlInitializeCriticalSectionEx(A_0, 0, 0) == null)
		{
			result = global::<Module>.HRESULT_FROM_WIN32(global::<Module>.GetLastError());
		}
		return result;
	}

	// Token: 0x06000031 RID: 49 RVA: 0x00002304 File Offset: 0x00001704
	internal unsafe static int Term(global::ATL.CComCriticalSection* A_0)
	{
		global::<Module>.DeleteCriticalSection(A_0);
		return 0;
	}

	// Token: 0x06000032 RID: 50 RVA: 0x0000231C File Offset: 0x0000171C
	internal unsafe static global::HINSTANCE__* GetModuleInstance(global::ATL.CAtlBaseModule* A_0)
	{
		return *(A_0 + 4);
	}

	// Token: 0x06000033 RID: 51 RVA: 0x0000315C File Offset: 0x0000255C
	internal unsafe static global::ATL.CComPtr<IDispatch>* {ctor}(global::ATL.CComPtr<IDispatch>* A_0, global::ATL.CComPtr<IDispatch>* lp)
	{
		global::<Module>.ATL.CComPtrBase<IDispatch>.{ctor}(A_0, *lp);
		return A_0;
	}

	// Token: 0x06000034 RID: 52 RVA: 0x00003664 File Offset: 0x00002A64
	internal unsafe static global::ATL.CComQIPtr<IUnknown,&IID_IUnknown>* {ctor}(global::ATL.CComQIPtr<IUnknown,&IID_IUnknown>* A_0, global::ATL.CComQIPtr<IUnknown,&IID_IUnknown>* lp)
	{
		global::<Module>.ATL.CComPtr<IUnknown>.{ctor}(A_0, *lp);
		return A_0;
	}

	// Token: 0x06000035 RID: 53 RVA: 0x0000317C File Offset: 0x0000257C
	internal unsafe static void {dtor}(global::ATL.CComPtr<IUnknown>* A_0)
	{
		global::<Module>.ATL.CComPtrBase<IUnknown>.{dtor}(A_0);
	}

	// Token: 0x06000036 RID: 54 RVA: 0x00003684 File Offset: 0x00002A84
	internal unsafe static global::ATL.CComBSTR* {ctor}(global::ATL.CComBSTR* A_0, global::ATL.CComBSTR* src)
	{
		*A_0 = global::<Module>.ATL.CComBSTR.Copy(src);
		if (global::<Module>.ATL.CComBSTR.!(src) == null && global::<Module>.ATL.CComBSTR.!(A_0) != null)
		{
			global::<Module>.ATL.AtlThrowImpl(-2147024882);
		}
		return A_0;
	}

	// Token: 0x06000037 RID: 55 RVA: 0x00003190 File Offset: 0x00002590
	internal unsafe static ushort* Copy(global::ATL.CComBSTR* A_0)
	{
		ushort* result;
		if (global::<Module>.ATL.CComBSTR.!(A_0) != null)
		{
			result = null;
		}
		else if (*A_0 != 0)
		{
			result = global::<Module>.SysAllocStringByteLen(*A_0, global::<Module>.SysStringByteLen(*A_0));
		}
		else
		{
			result = global::<Module>.SysAllocStringByteLen(null, 0U);
		}
		return result;
	}

	// Token: 0x06000038 RID: 56 RVA: 0x00002330 File Offset: 0x00001730
	[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
	internal unsafe static bool !(global::ATL.CComBSTR* A_0)
	{
		return (*A_0 != 0) ? 0 : 1;
	}

	// Token: 0x06000039 RID: 57 RVA: 0x00001308 File Offset: 0x00000708
	internal static void ??__E?pmField@?$CVarTypeInfo@D@ATL@@2QQtagVARIANT@@DQ3@@@YMXXZ()
	{
		global::<CppImplementationDetails>.$PTMType$PQtagVARIANT@@D $PTMType$PQtagVARIANT@@D = 8;
		global::<Module>.?pmField@?$CVarTypeInfo@D@ATL@@2QQtagVARIANT@@DQ3@ = $PTMType$PQtagVARIANT@@D;
	}

	// Token: 0x0600003A RID: 58 RVA: 0x00001320 File Offset: 0x00000720
	internal static void ??__E?pmField@?$CVarTypeInfo@E@ATL@@2QQtagVARIANT@@EQ3@@@YMXXZ()
	{
		global::<CppImplementationDetails>.$PTMType$PQtagVARIANT@@E $PTMType$PQtagVARIANT@@E = 8;
		global::<Module>.?pmField@?$CVarTypeInfo@E@ATL@@2QQtagVARIANT@@EQ3@ = $PTMType$PQtagVARIANT@@E;
	}

	// Token: 0x0600003B RID: 59 RVA: 0x00001338 File Offset: 0x00000738
	internal static void ??__E?pmField@?$CVarTypeInfo@PAD@ATL@@2QQtagVARIANT@@PADQ3@@@YMXXZ()
	{
		global::<CppImplementationDetails>.$PTMType$PQtagVARIANT@@PAD $PTMType$PQtagVARIANT@@PAD = 8;
		global::<Module>.?pmField@?$CVarTypeInfo@PAD@ATL@@2QQtagVARIANT@@PADQ3@ = $PTMType$PQtagVARIANT@@PAD;
	}

	// Token: 0x0600003C RID: 60 RVA: 0x00001350 File Offset: 0x00000750
	internal static void ??__E?pmField@?$CVarTypeInfo@PAE@ATL@@2QQtagVARIANT@@PAEQ3@@@YMXXZ()
	{
		global::<CppImplementationDetails>.$PTMType$PQtagVARIANT@@PAE $PTMType$PQtagVARIANT@@PAE = 8;
		global::<Module>.?pmField@?$CVarTypeInfo@PAE@ATL@@2QQtagVARIANT@@PAEQ3@ = $PTMType$PQtagVARIANT@@PAE;
	}

	// Token: 0x0600003D RID: 61 RVA: 0x00001368 File Offset: 0x00000768
	internal static void ??__E?pmField@?$CVarTypeInfo@F@ATL@@2QQtagVARIANT@@FQ3@@@YMXXZ()
	{
		global::<CppImplementationDetails>.$PTMType$PQtagVARIANT@@F $PTMType$PQtagVARIANT@@F = 8;
		global::<Module>.?pmField@?$CVarTypeInfo@F@ATL@@2QQtagVARIANT@@FQ3@ = $PTMType$PQtagVARIANT@@F;
	}

	// Token: 0x0600003E RID: 62 RVA: 0x00001380 File Offset: 0x00000780
	internal static void ??__E?pmField@?$CVarTypeInfo@PAF@ATL@@2QQtagVARIANT@@PAFQ3@@@YMXXZ()
	{
		global::<CppImplementationDetails>.$PTMType$PQtagVARIANT@@PAF $PTMType$PQtagVARIANT@@PAF = 8;
		global::<Module>.?pmField@?$CVarTypeInfo@PAF@ATL@@2QQtagVARIANT@@PAFQ3@ = $PTMType$PQtagVARIANT@@PAF;
	}

	// Token: 0x0600003F RID: 63 RVA: 0x00001398 File Offset: 0x00000798
	internal static void ??__E?pmField@?$CVarTypeInfo@G@ATL@@2QQtagVARIANT@@GQ3@@@YMXXZ()
	{
		global::<CppImplementationDetails>.$PTMType$PQtagVARIANT@@G $PTMType$PQtagVARIANT@@G = 8;
		global::<Module>.?pmField@?$CVarTypeInfo@G@ATL@@2QQtagVARIANT@@GQ3@ = $PTMType$PQtagVARIANT@@G;
	}

	// Token: 0x06000040 RID: 64 RVA: 0x000013B0 File Offset: 0x000007B0
	internal static void ??__E?pmField@?$CVarTypeInfo@H@ATL@@2QQtagVARIANT@@HQ3@@@YMXXZ()
	{
		global::<CppImplementationDetails>.$PTMType$PQtagVARIANT@@H $PTMType$PQtagVARIANT@@H = 8;
		global::<Module>.?pmField@?$CVarTypeInfo@H@ATL@@2QQtagVARIANT@@HQ3@ = $PTMType$PQtagVARIANT@@H;
	}

	// Token: 0x06000041 RID: 65 RVA: 0x000013C8 File Offset: 0x000007C8
	internal static void ??__E?pmField@?$CVarTypeInfo@PAH@ATL@@2QQtagVARIANT@@PAHQ3@@@YMXXZ()
	{
		global::<CppImplementationDetails>.$PTMType$PQtagVARIANT@@PAH $PTMType$PQtagVARIANT@@PAH = 8;
		global::<Module>.?pmField@?$CVarTypeInfo@PAH@ATL@@2QQtagVARIANT@@PAHQ3@ = $PTMType$PQtagVARIANT@@PAH;
	}

	// Token: 0x06000042 RID: 66 RVA: 0x000013E0 File Offset: 0x000007E0
	internal static void ??__E?pmField@?$CVarTypeInfo@I@ATL@@2QQtagVARIANT@@IQ3@@@YMXXZ()
	{
		global::<CppImplementationDetails>.$PTMType$PQtagVARIANT@@I $PTMType$PQtagVARIANT@@I = 8;
		global::<Module>.?pmField@?$CVarTypeInfo@I@ATL@@2QQtagVARIANT@@IQ3@ = $PTMType$PQtagVARIANT@@I;
	}

	// Token: 0x06000043 RID: 67 RVA: 0x000013F8 File Offset: 0x000007F8
	internal static void ??__E?pmField@?$CVarTypeInfo@PAI@ATL@@2QQtagVARIANT@@PAIQ3@@@YMXXZ()
	{
		global::<CppImplementationDetails>.$PTMType$PQtagVARIANT@@PAI $PTMType$PQtagVARIANT@@PAI = 8;
		global::<Module>.?pmField@?$CVarTypeInfo@PAI@ATL@@2QQtagVARIANT@@PAIQ3@ = $PTMType$PQtagVARIANT@@PAI;
	}

	// Token: 0x06000044 RID: 68 RVA: 0x00001410 File Offset: 0x00000810
	internal static void ??__E?pmField@?$CVarTypeInfo@J@ATL@@2QQtagVARIANT@@JQ3@@@YMXXZ()
	{
		global::<CppImplementationDetails>.$PTMType$PQtagVARIANT@@J $PTMType$PQtagVARIANT@@J = 8;
		global::<Module>.?pmField@?$CVarTypeInfo@J@ATL@@2QQtagVARIANT@@JQ3@ = $PTMType$PQtagVARIANT@@J;
	}

	// Token: 0x06000045 RID: 69 RVA: 0x00001428 File Offset: 0x00000828
	internal static void ??__E?pmField@?$CVarTypeInfo@PAJ@ATL@@2QQtagVARIANT@@PAJQ3@@@YMXXZ()
	{
		global::<CppImplementationDetails>.$PTMType$PQtagVARIANT@@PAJ $PTMType$PQtagVARIANT@@PAJ = 8;
		global::<Module>.?pmField@?$CVarTypeInfo@PAJ@ATL@@2QQtagVARIANT@@PAJQ3@ = $PTMType$PQtagVARIANT@@PAJ;
	}

	// Token: 0x06000046 RID: 70 RVA: 0x00001440 File Offset: 0x00000840
	internal static void ??__E?pmField@?$CVarTypeInfo@K@ATL@@2QQtagVARIANT@@KQ3@@@YMXXZ()
	{
		global::<CppImplementationDetails>.$PTMType$PQtagVARIANT@@K $PTMType$PQtagVARIANT@@K = 8;
		global::<Module>.?pmField@?$CVarTypeInfo@K@ATL@@2QQtagVARIANT@@KQ3@ = $PTMType$PQtagVARIANT@@K;
	}

	// Token: 0x06000047 RID: 71 RVA: 0x00001458 File Offset: 0x00000858
	internal static void ??__E?pmField@?$CVarTypeInfo@PAK@ATL@@2QQtagVARIANT@@PAKQ3@@@YMXXZ()
	{
		global::<CppImplementationDetails>.$PTMType$PQtagVARIANT@@PAK $PTMType$PQtagVARIANT@@PAK = 8;
		global::<Module>.?pmField@?$CVarTypeInfo@PAK@ATL@@2QQtagVARIANT@@PAKQ3@ = $PTMType$PQtagVARIANT@@PAK;
	}

	// Token: 0x06000048 RID: 72 RVA: 0x00001470 File Offset: 0x00000870
	internal static void ??__E?pmField@?$CVarTypeInfo@_J@ATL@@2QQtagVARIANT@@_JQ3@@@YMXXZ()
	{
		global::<CppImplementationDetails>.$PTMType$PQtagVARIANT@@_J $PTMType$PQtagVARIANT@@_J = 8;
		global::<Module>.?pmField@?$CVarTypeInfo@_J@ATL@@2QQtagVARIANT@@_JQ3@ = $PTMType$PQtagVARIANT@@_J;
	}

	// Token: 0x06000049 RID: 73 RVA: 0x00001488 File Offset: 0x00000888
	internal static void ??__E?pmField@?$CVarTypeInfo@PA_J@ATL@@2QQtagVARIANT@@PA_JQ3@@@YMXXZ()
	{
		global::<CppImplementationDetails>.$PTMType$PQtagVARIANT@@PA_J $PTMType$PQtagVARIANT@@PA_J = 8;
		global::<Module>.?pmField@?$CVarTypeInfo@PA_J@ATL@@2QQtagVARIANT@@PA_JQ3@ = $PTMType$PQtagVARIANT@@PA_J;
	}

	// Token: 0x0600004A RID: 74 RVA: 0x000014A0 File Offset: 0x000008A0
	internal static void ??__E?pmField@?$CVarTypeInfo@_K@ATL@@2QQtagVARIANT@@_KQ3@@@YMXXZ()
	{
		global::<CppImplementationDetails>.$PTMType$PQtagVARIANT@@_K $PTMType$PQtagVARIANT@@_K = 8;
		global::<Module>.?pmField@?$CVarTypeInfo@_K@ATL@@2QQtagVARIANT@@_KQ3@ = $PTMType$PQtagVARIANT@@_K;
	}

	// Token: 0x0600004B RID: 75 RVA: 0x000014B8 File Offset: 0x000008B8
	internal static void ??__E?pmField@?$CVarTypeInfo@PA_K@ATL@@2QQtagVARIANT@@PA_KQ3@@@YMXXZ()
	{
		global::<CppImplementationDetails>.$PTMType$PQtagVARIANT@@PA_K $PTMType$PQtagVARIANT@@PA_K = 8;
		global::<Module>.?pmField@?$CVarTypeInfo@PA_K@ATL@@2QQtagVARIANT@@PA_KQ3@ = $PTMType$PQtagVARIANT@@PA_K;
	}

	// Token: 0x0600004C RID: 76 RVA: 0x000014D0 File Offset: 0x000008D0
	internal static void ??__E?pmField@?$CVarTypeInfo@M@ATL@@2QQtagVARIANT@@MQ3@@@YMXXZ()
	{
		global::<CppImplementationDetails>.$PTMType$PQtagVARIANT@@M $PTMType$PQtagVARIANT@@M = 8;
		global::<Module>.?pmField@?$CVarTypeInfo@M@ATL@@2QQtagVARIANT@@MQ3@ = $PTMType$PQtagVARIANT@@M;
	}

	// Token: 0x0600004D RID: 77 RVA: 0x000014E8 File Offset: 0x000008E8
	internal static void ??__E?pmField@?$CVarTypeInfo@PAM@ATL@@2QQtagVARIANT@@PAMQ3@@@YMXXZ()
	{
		global::<CppImplementationDetails>.$PTMType$PQtagVARIANT@@PAM $PTMType$PQtagVARIANT@@PAM = 8;
		global::<Module>.?pmField@?$CVarTypeInfo@PAM@ATL@@2QQtagVARIANT@@PAMQ3@ = $PTMType$PQtagVARIANT@@PAM;
	}

	// Token: 0x0600004E RID: 78 RVA: 0x00001500 File Offset: 0x00000900
	internal static void ??__E?pmField@?$CVarTypeInfo@N@ATL@@2QQtagVARIANT@@NQ3@@@YMXXZ()
	{
		global::<CppImplementationDetails>.$PTMType$PQtagVARIANT@@N $PTMType$PQtagVARIANT@@N = 8;
		global::<Module>.?pmField@?$CVarTypeInfo@N@ATL@@2QQtagVARIANT@@NQ3@ = $PTMType$PQtagVARIANT@@N;
	}

	// Token: 0x0600004F RID: 79 RVA: 0x00001518 File Offset: 0x00000918
	internal static void ??__E?pmField@?$CVarTypeInfo@PAN@ATL@@2QQtagVARIANT@@PANQ3@@@YMXXZ()
	{
		global::<CppImplementationDetails>.$PTMType$PQtagVARIANT@@PAN $PTMType$PQtagVARIANT@@PAN = 8;
		global::<Module>.?pmField@?$CVarTypeInfo@PAN@ATL@@2QQtagVARIANT@@PANQ3@ = $PTMType$PQtagVARIANT@@PAN;
	}

	// Token: 0x06000050 RID: 80 RVA: 0x00001530 File Offset: 0x00000930
	internal static void ??__E?pmField@?$CVarTypeInfo@PAG@ATL@@2QQtagVARIANT@@PAGQ3@@@YMXXZ()
	{
		global::<CppImplementationDetails>.$PTMType$PQtagVARIANT@@PAG $PTMType$PQtagVARIANT@@PAG = 8;
		global::<Module>.?pmField@?$CVarTypeInfo@PAG@ATL@@2QQtagVARIANT@@PAGQ3@ = $PTMType$PQtagVARIANT@@PAG;
	}

	// Token: 0x06000051 RID: 81 RVA: 0x00001548 File Offset: 0x00000948
	internal static void ??__E?pmField@?$CVarTypeInfo@PAPAG@ATL@@2QQtagVARIANT@@PAPAGQ3@@@YMXXZ()
	{
		global::<CppImplementationDetails>.$PTMType$PQtagVARIANT@@PAPAG $PTMType$PQtagVARIANT@@PAPAG = 8;
		global::<Module>.?pmField@?$CVarTypeInfo@PAPAG@ATL@@2QQtagVARIANT@@PAPAGQ3@ = $PTMType$PQtagVARIANT@@PAPAG;
	}

	// Token: 0x06000052 RID: 82 RVA: 0x00001560 File Offset: 0x00000960
	internal static void ??__E?pmField@?$CVarTypeInfo@PAUIUnknown@@@ATL@@2QQtagVARIANT@@PAUIUnknown@@Q3@@@YMXXZ()
	{
		global::<CppImplementationDetails>.$PTMType$PQtagVARIANT@@PAUIUnknown@@ $PTMType$PQtagVARIANT@@PAUIUnknown@@ = 8;
		global::<Module>.?pmField@?$CVarTypeInfo@PAUIUnknown@@@ATL@@2QQtagVARIANT@@PAUIUnknown@@Q3@ = $PTMType$PQtagVARIANT@@PAUIUnknown@@;
	}

	// Token: 0x06000053 RID: 83 RVA: 0x00001578 File Offset: 0x00000978
	internal static void ??__E?pmField@?$CVarTypeInfo@PAPAUIUnknown@@@ATL@@2QQtagVARIANT@@PAPAUIUnknown@@Q3@@@YMXXZ()
	{
		global::<CppImplementationDetails>.$PTMType$PQtagVARIANT@@PAPAUIUnknown@@ $PTMType$PQtagVARIANT@@PAPAUIUnknown@@ = 8;
		global::<Module>.?pmField@?$CVarTypeInfo@PAPAUIUnknown@@@ATL@@2QQtagVARIANT@@PAPAUIUnknown@@Q3@ = $PTMType$PQtagVARIANT@@PAPAUIUnknown@@;
	}

	// Token: 0x06000054 RID: 84 RVA: 0x00001590 File Offset: 0x00000990
	internal static void ??__E?pmField@?$CVarTypeInfo@PAUIDispatch@@@ATL@@2QQtagVARIANT@@PAUIDispatch@@Q3@@@YMXXZ()
	{
		global::<CppImplementationDetails>.$PTMType$PQtagVARIANT@@PAUIDispatch@@ $PTMType$PQtagVARIANT@@PAUIDispatch@@ = 8;
		global::<Module>.?pmField@?$CVarTypeInfo@PAUIDispatch@@@ATL@@2QQtagVARIANT@@PAUIDispatch@@Q3@ = $PTMType$PQtagVARIANT@@PAUIDispatch@@;
	}

	// Token: 0x06000055 RID: 85 RVA: 0x000015A8 File Offset: 0x000009A8
	internal static void ??__E?pmField@?$CVarTypeInfo@PAPAUIDispatch@@@ATL@@2QQtagVARIANT@@PAPAUIDispatch@@Q3@@@YMXXZ()
	{
		global::<CppImplementationDetails>.$PTMType$PQtagVARIANT@@PAPAUIDispatch@@ $PTMType$PQtagVARIANT@@PAPAUIDispatch@@ = 8;
		global::<Module>.?pmField@?$CVarTypeInfo@PAPAUIDispatch@@@ATL@@2QQtagVARIANT@@PAPAUIDispatch@@Q3@ = $PTMType$PQtagVARIANT@@PAPAUIDispatch@@;
	}

	// Token: 0x06000056 RID: 86 RVA: 0x000015C0 File Offset: 0x000009C0
	internal static void ??__E?pmField@?$CVarTypeInfo@TtagCY@@@ATL@@2QQtagVARIANT@@TtagCY@@Q3@@@YMXXZ()
	{
		global::<CppImplementationDetails>.$PTMType$PQtagVARIANT@@TtagCY@@ $PTMType$PQtagVARIANT@@TtagCY@@ = 8;
		global::<Module>.?pmField@?$CVarTypeInfo@TtagCY@@@ATL@@2QQtagVARIANT@@TtagCY@@Q3@ = $PTMType$PQtagVARIANT@@TtagCY@@;
	}

	// Token: 0x06000057 RID: 87 RVA: 0x000015D8 File Offset: 0x000009D8
	internal static void ??__E?pmField@?$CVarTypeInfo@PATtagCY@@@ATL@@2QQtagVARIANT@@PATtagCY@@Q3@@@YMXXZ()
	{
		global::<CppImplementationDetails>.$PTMType$PQtagVARIANT@@PATtagCY@@ $PTMType$PQtagVARIANT@@PATtagCY@@ = 8;
		global::<Module>.?pmField@?$CVarTypeInfo@PATtagCY@@@ATL@@2QQtagVARIANT@@PATtagCY@@Q3@ = $PTMType$PQtagVARIANT@@PATtagCY@@;
	}

	// Token: 0x06000058 RID: 88 RVA: 0x000031C8 File Offset: 0x000025C8
	internal unsafe static global::ATL.CComVariant* {ctor}(global::ATL.CComVariant* A_0, global::ATL.CComVariant* varSrc)
	{
		*A_0 = 0;
		global::<Module>.ATL.CComVariant.InternalCopy(A_0, varSrc);
		return A_0;
	}

	// Token: 0x06000059 RID: 89 RVA: 0x00002348 File Offset: 0x00001748
	internal unsafe static int Copy(global::ATL.CComVariant* A_0, global::tagVARIANT* pSrc)
	{
		return global::<Module>.VariantCopy(A_0, pSrc);
	}

	// Token: 0x0600005A RID: 90 RVA: 0x00002360 File Offset: 0x00001760
	internal unsafe static void InternalCopy(global::ATL.CComVariant* A_0, global::tagVARIANT* pSrc)
	{
		int num = global::<Module>.ATL.CComVariant.Copy(A_0, pSrc);
		if (num < 0)
		{
			*A_0 = 10;
			*(A_0 + 8) = num;
			global::<Module>.ATL.AtlThrowImpl(num);
		}
	}

	// Token: 0x0600005B RID: 91 RVA: 0x000031E8 File Offset: 0x000025E8
	internal unsafe static global::ATL.CHandle* {ctor}(global::ATL.CHandle* A_0, global::ATL.CHandle* h)
	{
		*A_0 = 0;
		global::<Module>.ATL.CHandle.Attach(A_0, global::<Module>.ATL.CHandle.Detach(h));
		return A_0;
	}

	// Token: 0x0600005C RID: 92 RVA: 0x00002388 File Offset: 0x00001788
	internal unsafe static void Attach(global::ATL.CHandle* A_0, void* h)
	{
		while (false)
		{
		}
		*A_0 = h;
	}

	// Token: 0x0600005D RID: 93 RVA: 0x0000239C File Offset: 0x0000179C
	internal unsafe static void* Detach(global::ATL.CHandle* A_0)
	{
		void* result = *A_0;
		*A_0 = 0;
		return result;
	}

	// Token: 0x0600005E RID: 94 RVA: 0x000015F0 File Offset: 0x000009F0
	internal static void ??__E_AtlComModule@ATL@@YMXXZ()
	{
		global::<Module>.ATL.CAtlComModule.{ctor}(ref global::<Module>.ATL._AtlComModule);
		global::<Module>._atexit_m(ldftn(?A0xacbfdcdf.??__F_AtlComModule@ATL@@YMXXZ));
	}

	// Token: 0x0600005F RID: 95 RVA: 0x00008634 File Offset: 0x00007A34
	internal static void ??__F_AtlComModule@ATL@@YMXXZ()
	{
		global::<Module>.ATL.CAtlComModule.{dtor}(ref global::<Module>.ATL._AtlComModule);
	}

	// Token: 0x06000060 RID: 96 RVA: 0x000036BC File Offset: 0x00002ABC
	internal unsafe static global::ATL.CAtlWinModule* {ctor}(global::ATL.CAtlWinModule* A_0)
	{
		global::<Module>.ATL._ATL_WIN_MODULE70.{ctor}(A_0);
		try
		{
			*A_0 = 44;
			int num = global::<Module>.ATL.AtlWinModuleInit(A_0);
			if (num < 0)
			{
				global::<Module>.?m_bInitFailed@CAtlBaseModule@ATL@@2_NA = true;
				*A_0 = 0;
			}
		}
		catch
		{
			global::<Module>.___CxxCallUnwindDtor(ldftn(ATL._ATL_WIN_MODULE70.{dtor}), A_0);
			throw;
		}
		return A_0;
	}

	// Token: 0x06000061 RID: 97 RVA: 0x000038B8 File Offset: 0x00002CB8
	internal unsafe static void {dtor}(global::ATL.CAtlWinModule* A_0)
	{
		try
		{
			global::<Module>.ATL.CAtlWinModule.Term(A_0);
		}
		catch
		{
			global::<Module>.___CxxCallUnwindDtor(ldftn(ATL._ATL_WIN_MODULE70.{dtor}), A_0);
			throw;
		}
		global::<Module>.ATL._ATL_WIN_MODULE70.{dtor}(A_0);
	}

	// Token: 0x06000062 RID: 98 RVA: 0x00003718 File Offset: 0x00002B18
	internal unsafe static void Term(global::ATL.CAtlWinModule* A_0)
	{
		global::<Module>.ATL.AtlWinModuleTerm(A_0, global::<Module>.ATL.CAtlBaseModule.GetModuleInstance(ref global::<Module>.ATL._AtlBaseModule));
	}

	// Token: 0x06000063 RID: 99 RVA: 0x0000320C File Offset: 0x0000260C
	internal unsafe static global::ATL._ATL_WIN_MODULE70* {ctor}(global::ATL._ATL_WIN_MODULE70* A_0)
	{
		global::<Module>.ATL.CComCriticalSection.{ctor}(A_0 + 4);
		try
		{
			global::<Module>.ATL.CSimpleArray<unsigned\u0020short,ATL::CSimpleArrayEqualHelper<unsigned\u0020short>\u0020>.{ctor}(A_0 + 32);
		}
		catch
		{
			global::<Module>.___CxxCallUnwindDtor(ldftn(ATL.CComCriticalSection.{dtor}), A_0 + 4);
			throw;
		}
		return A_0;
	}

	// Token: 0x06000064 RID: 100 RVA: 0x0000325C File Offset: 0x0000265C
	internal unsafe static void {dtor}(global::ATL._ATL_WIN_MODULE70* A_0)
	{
		try
		{
			global::<Module>.ATL.CSimpleArray<unsigned\u0020short,ATL::CSimpleArrayEqualHelper<unsigned\u0020short>\u0020>.{dtor}(A_0 + 32);
		}
		catch
		{
			global::<Module>.___CxxCallUnwindDtor(ldftn(ATL.CComCriticalSection.{dtor}), A_0 + 4);
			throw;
		}
		global::<Module>.ATL.CComCriticalSection.{dtor}(A_0 + 4);
	}

	// Token: 0x06000065 RID: 101 RVA: 0x00001614 File Offset: 0x00000A14
	internal static void ??__E_AtlWinModule@ATL@@YMXXZ()
	{
		global::<Module>.ATL.CAtlWinModule.{ctor}(ref global::<Module>.ATL._AtlWinModule);
		global::<Module>._atexit_m(ldftn(?A0xacbfdcdf.??__F_AtlWinModule@ATL@@YMXXZ));
	}

	// Token: 0x06000066 RID: 102 RVA: 0x00008714 File Offset: 0x00007B14
	internal static void ??__F_AtlWinModule@ATL@@YMXXZ()
	{
		global::<Module>.ATL.CAtlWinModule.{dtor}(ref global::<Module>.ATL._AtlWinModule);
	}

	// Token: 0x06000067 RID: 103 RVA: 0x000023B4 File Offset: 0x000017B4
	internal unsafe static global::ATL.CAtlReleaseManagedClassFactories* {ctor}(global::ATL.CAtlReleaseManagedClassFactories* A_0)
	{
		return A_0;
	}

	// Token: 0x06000068 RID: 104 RVA: 0x000023C4 File Offset: 0x000017C4
	internal unsafe static void {dtor}(global::ATL.CAtlReleaseManagedClassFactories* A_0)
	{
		global::<Module>.ATL.CAtlComModule.Term(ref global::<Module>.ATL._AtlComModule);
	}

	// Token: 0x06000069 RID: 105 RVA: 0x00001638 File Offset: 0x00000A38
	internal static void ??__E_AtlReleaseManagedClassFactories@ATL@@YMXXZ()
	{
		global::<Module>.ATL.CAtlReleaseManagedClassFactories.{ctor}(ref global::<Module>.ATL._AtlReleaseManagedClassFactories);
		global::<Module>._atexit_m(ldftn(?A0xacbfdcdf.??__F_AtlReleaseManagedClassFactories@ATL@@YMXXZ));
	}

	// Token: 0x0600006A RID: 106 RVA: 0x00008654 File Offset: 0x00007A54
	internal static void ??__F_AtlReleaseManagedClassFactories@ATL@@YMXXZ()
	{
		global::<Module>.ATL.CAtlReleaseManagedClassFactories.{dtor}(ref global::<Module>.ATL._AtlReleaseManagedClassFactories);
	}

	// Token: 0x0600006B RID: 107 RVA: 0x000032A8 File Offset: 0x000026A8
	internal unsafe static global::ATL.CRegKey* {ctor}(global::ATL.CRegKey* A_0, global::ATL.CRegKey* key)
	{
		*A_0 = 0;
		uint num = *(key + 4);
		global::ATL.CAtlTransactionManager* ptr = *(key + 8);
		global::<Module>.ATL.CRegKey.Attach(A_0, global::<Module>.ATL.CRegKey.Detach(key));
		*(A_0 + 4) = num;
		*(A_0 + 8) = ptr;
		return A_0;
	}

	// Token: 0x0600006C RID: 108 RVA: 0x000023DC File Offset: 0x000017DC
	internal unsafe static global::HKEY__* Detach(global::ATL.CRegKey* A_0)
	{
		global::HKEY__* result = *A_0;
		*A_0 = 0;
		*(A_0 + 4) = 0;
		*(A_0 + 8) = 0;
		return result;
	}

	// Token: 0x0600006D RID: 109 RVA: 0x000023FC File Offset: 0x000017FC
	internal unsafe static void Attach(global::ATL.CRegKey* A_0, global::HKEY__* hKey)
	{
		while (false)
		{
		}
		*A_0 = hKey;
		*(A_0 + 4) = 0;
		*(A_0 + 8) = 0;
	}

	// Token: 0x0600006E RID: 110 RVA: 0x000032E0 File Offset: 0x000026E0
	internal unsafe static int AtlWinModuleTerm(global::ATL._ATL_WIN_MODULE70* pWinModule, global::HINSTANCE__* hInst)
	{
		int result;
		if (pWinModule == null)
		{
			result = -2147024809;
		}
		else if (*(int*)pWinModule == 0)
		{
			result = 0;
		}
		else if (*(int*)pWinModule != 44)
		{
			result = -2147024809;
		}
		else
		{
			for (int i = 0; i < global::<Module>.ATL.CSimpleArray<unsigned\u0020short,ATL::CSimpleArrayEqualHelper<unsigned\u0020short>\u0020>.GetSize(pWinModule + 32 / sizeof(global::ATL._ATL_WIN_MODULE70)); i++)
			{
				global::<Module>.UnregisterClassW(*global::<Module>.ATL.CSimpleArray<unsigned\u0020short,ATL::CSimpleArrayEqualHelper<unsigned\u0020short>\u0020>.[](pWinModule + 32 / sizeof(global::ATL._ATL_WIN_MODULE70), i), hInst);
			}
			global::<Module>.ATL.CSimpleArray<unsigned\u0020short,ATL::CSimpleArrayEqualHelper<unsigned\u0020short>\u0020>.RemoveAll(pWinModule + 32 / sizeof(global::ATL._ATL_WIN_MODULE70));
			global::<Module>.ATL.CComCriticalSection.Term(pWinModule + 4 / sizeof(global::ATL._ATL_WIN_MODULE70));
			*(int*)pWinModule = 0;
			result = 0;
		}
		return result;
	}

	// Token: 0x0600006F RID: 111 RVA: 0x0000241C File Offset: 0x0000181C
	internal unsafe static int AtlWinModuleInit(global::ATL._ATL_WIN_MODULE70* pWinModule)
	{
		int result;
		if (pWinModule == null)
		{
			result = -2147024809;
		}
		else if (*(int*)pWinModule != 44)
		{
			result = -2147024809;
		}
		else
		{
			*(int*)(pWinModule + 28 / sizeof(global::ATL._ATL_WIN_MODULE70)) = 0;
			int num = global::<Module>.ATL.CComCriticalSection.Init(pWinModule + 4 / sizeof(global::ATL._ATL_WIN_MODULE70));
			result = num;
		}
		return result;
	}

	// Token: 0x06000070 RID: 112 RVA: 0x00002454 File Offset: 0x00001854
	internal unsafe static global::ATL.CWin32Heap* {ctor}(global::ATL.CWin32Heap* A_0, void* hHeap)
	{
		*A_0 = ref global::<Module>.??_7CWin32Heap@ATL@@6B@;
		*(A_0 + 4) = hHeap;
		*(A_0 + 8) = 0;
		return A_0;
	}

	// Token: 0x06000071 RID: 113 RVA: 0x00002474 File Offset: 0x00001874
	internal unsafe static void {dtor}(global::ATL.CWin32Heap* A_0)
	{
		*A_0 = ref global::<Module>.??_7CWin32Heap@ATL@@6B@;
		if (*(A_0 + 8) != 0 && *(A_0 + 4) != 0)
		{
			int num = global::<Module>.HeapDestroy(*(A_0 + 4));
		}
	}

	// Token: 0x06000072 RID: 114 RVA: 0x000045E4 File Offset: 0x000039E4
	internal unsafe static void* Allocate(global::ATL.CWin32Heap* A_0, uint nBytes)
	{
		return global::<Module>.HeapAlloc(*(A_0 + 4), 0, nBytes);
	}

	// Token: 0x06000073 RID: 115 RVA: 0x00004604 File Offset: 0x00003A04
	internal unsafe static void Free(global::ATL.CWin32Heap* A_0, void* p)
	{
		if (p != null)
		{
			int num = global::<Module>.HeapFree(*(A_0 + 4), 0, p);
		}
	}

	// Token: 0x06000074 RID: 116 RVA: 0x00004628 File Offset: 0x00003A28
	internal unsafe static void* Reallocate(global::ATL.CWin32Heap* A_0, void* p, uint nBytes)
	{
		void* result;
		if (p == null)
		{
			result = calli(System.Void* modopt(System.Runtime.CompilerServices.CallConvThiscall)(System.IntPtr,System.UInt32), A_0, nBytes, *(*A_0));
		}
		else if (nBytes == 0U)
		{
			calli(System.Void modopt(System.Runtime.CompilerServices.CallConvThiscall)(System.IntPtr,System.Void*), A_0, p, *(*A_0 + 4));
			result = null;
		}
		else
		{
			result = global::<Module>.HeapReAlloc(*(A_0 + 4), 0, p, nBytes);
		}
		return result;
	}

	// Token: 0x06000075 RID: 117 RVA: 0x0000466C File Offset: 0x00003A6C
	internal unsafe static uint GetSize(global::ATL.CWin32Heap* A_0, void* p)
	{
		return global::<Module>.HeapSize(*(A_0 + 4), 0, (void*)p);
	}

	// Token: 0x06000076 RID: 118 RVA: 0x0000468C File Offset: 0x00003A8C
	internal unsafe static void* __vecDelDtor(global::ATL.CWin32Heap* A_0, uint A_0)
	{
		void* result;
		if ((A_0 & 2U) != 0U)
		{
			global::<Module>.__ehvec_dtor(A_0, 12U, *(A_0 - 4), ldftn(ATL.CWin32Heap.{dtor}));
			if ((A_0 & 1U) != 0U)
			{
				global::<Module>.delete[](A_0 - 4);
			}
			result = A_0 - 4;
		}
		else
		{
			global::<Module>.ATL.CWin32Heap.{dtor}(A_0);
			if ((A_0 & 1U) != 0U)
			{
				global::<Module>.delete(A_0);
			}
			result = A_0;
		}
		return result;
	}

	// Token: 0x06000077 RID: 119 RVA: 0x0000497C File Offset: 0x00003D7C
	internal unsafe static void AddRef(global::ATL.CStringData* A_0)
	{
		global::System.Threading.Interlocked.Increment(A_0 + 12);
	}

	// Token: 0x06000078 RID: 120 RVA: 0x000024A0 File Offset: 0x000018A0
	internal unsafe static global::ATL.CNilStringData* {ctor}(global::ATL.CNilStringData* A_0)
	{
		*A_0 = 0;
		*(A_0 + 12) = 2;
		*(A_0 + 4) = 0;
		*(A_0 + 8) = 0;
		*(A_0 + 16 + 2 * 0) = 0;
		*(A_0 + 18) = 0;
		return A_0;
	}

	// Token: 0x06000079 RID: 121 RVA: 0x000024D4 File Offset: 0x000018D4
	internal unsafe static void SetManager(global::ATL.CNilStringData* A_0, global::ATL.IAtlStringMgr* pMgr)
	{
		*A_0 = pMgr;
	}

	// Token: 0x0600007A RID: 122 RVA: 0x000024E4 File Offset: 0x000018E4
	internal unsafe static global::ATL.CAtlStringMgr* {ctor}(global::ATL.CAtlStringMgr* A_0, global::ATL.IAtlMemMgr* pMemMgr)
	{
		*A_0 = ref global::<Module>.??_7CAtlStringMgr@ATL@@6B@;
		*(A_0 + 4) = pMemMgr;
		global::<Module>.ATL.CNilStringData.{ctor}(A_0 + 8);
		global::<Module>.ATL.CNilStringData.SetManager(A_0 + 8, A_0);
		return A_0;
	}

	// Token: 0x0600007B RID: 123 RVA: 0x00002510 File Offset: 0x00001910
	internal unsafe static void {dtor}(global::ATL.CAtlStringMgr* A_0)
	{
		*A_0 = ref global::<Module>.??_7CAtlStringMgr@ATL@@6B@;
		global::<Module>.?isInitialized@CAtlStringMgr@ATL@@0_NA = false;
	}

	// Token: 0x0600007C RID: 124 RVA: 0x00003350 File Offset: 0x00002750
	internal unsafe static global::ATL.IAtlStringMgr* GetInstance()
	{
		if ((global::<Module>.??_B?1??GetInstance@CAtlStringMgr@ATL@@SAPAUIAtlStringMgr@2@XZ@51 & 1U) == 0U)
		{
			global::<Module>.??_B?1??GetInstance@CAtlStringMgr@ATL@@SAPAUIAtlStringMgr@2@XZ@51 |= 1U;
			try
			{
				global::<Module>.ATL.CWin32Heap.{ctor}(ref global::<Module>.?strHeap@?1??GetInstance@CAtlStringMgr@ATL@@SAPAUIAtlStringMgr@3@XZ@4VCWin32Heap@3@A, global::<Module>.GetProcessHeap());
				global::<Module>._atexit_m(ldftn(??__FstrHeap@?1??GetInstance@CAtlStringMgr@ATL@@SAPAUIAtlStringMgr@2@XZ@YMXXZ));
			}
			catch
			{
				global::<Module>.??_B?1??GetInstance@CAtlStringMgr@ATL@@SAPAUIAtlStringMgr@2@XZ@51 &= 4294967294U;
				throw;
			}
		}
		if ((global::<Module>.??_B?1??GetInstance@CAtlStringMgr@ATL@@SAPAUIAtlStringMgr@2@XZ@51 & 2U) == 0U)
		{
			global::<Module>.??_B?1??GetInstance@CAtlStringMgr@ATL@@SAPAUIAtlStringMgr@2@XZ@51 |= 2U;
			try
			{
				global::<Module>.ATL.CAtlStringMgr.{ctor}(ref global::<Module>.?strMgr@?1??GetInstance@CAtlStringMgr@ATL@@SAPAUIAtlStringMgr@3@XZ@4V23@A, (global::ATL.IAtlMemMgr*)(&global::<Module>.?strHeap@?1??GetInstance@CAtlStringMgr@ATL@@SAPAUIAtlStringMgr@3@XZ@4VCWin32Heap@3@A));
				global::<Module>._atexit_m(ldftn(??__FstrMgr@?1??GetInstance@CAtlStringMgr@ATL@@SAPAUIAtlStringMgr@2@XZ@YMXXZ));
			}
			catch
			{
				global::<Module>.??_B?1??GetInstance@CAtlStringMgr@ATL@@SAPAUIAtlStringMgr@2@XZ@51 &= 4294967293U;
				throw;
			}
		}
		return ref global::<Module>.?strMgr@?1??GetInstance@CAtlStringMgr@ATL@@SAPAUIAtlStringMgr@3@XZ@4V23@A;
	}

	// Token: 0x0600007D RID: 125 RVA: 0x000046F8 File Offset: 0x00003AF8
	internal unsafe static global::ATL.CStringData* Allocate(global::ATL.CAtlStringMgr* A_0, int nChars, int nCharSize)
	{
		while (nChars >= 0)
		{
			if (!false)
			{
				global::ATL.CStringData* result;
				if (global::<Module>.ATL.AtlAdd<int>(&nChars, nChars, 1) < 0)
				{
					result = null;
				}
				else
				{
					int num = global::<Module>.ATL.AtlAlignUp<int>(nChars, 8);
					while (nChars <= num)
					{
						if (!false)
						{
							uint tRight;
							uint num2;
							if (global::<Module>.ATL.AtlMultiply<unsigned\u0020int>(&tRight, (uint)num, (uint)nCharSize) < 0 || global::<Module>.ATL.AtlAdd<unsigned\u0020int>(&num2, 16U, tRight) < 0)
							{
								return 0;
							}
							global::ATL.CStringData* ptr = calli(System.Void* modopt(System.Runtime.CompilerServices.CallConvThiscall)(System.IntPtr,System.UInt32), *(A_0 + 4), num2, *(*(*(A_0 + 4))));
							if (ptr == null)
							{
								return 0;
							}
							*(int*)ptr = A_0;
							*(int*)(ptr + 12 / sizeof(global::ATL.CStringData)) = 1;
							*(int*)(ptr + 8 / sizeof(global::ATL.CStringData)) = num - 1;
							*(int*)(ptr + 4 / sizeof(global::ATL.CStringData)) = 0;
							return ptr;
						}
					}
					result = null;
				}
				return result;
			}
		}
		return 0;
	}

	// Token: 0x0600007E RID: 126 RVA: 0x00004840 File Offset: 0x00003C40
	internal unsafe static void Free(global::ATL.CAtlStringMgr* A_0, global::ATL.CStringData* pData)
	{
		while (false)
		{
		}
		calli(System.Void modopt(System.Runtime.CompilerServices.CallConvThiscall)(System.IntPtr,System.Void*), *(A_0 + 4), pData, *(*(*(A_0 + 4)) + 4));
	}

	// Token: 0x0600007F RID: 127 RVA: 0x00004868 File Offset: 0x00003C68
	internal unsafe static global::ATL.CStringData* Reallocate(global::ATL.CAtlStringMgr* A_0, global::ATL.CStringData* pData, int nChars, int nCharSize)
	{
		while (nChars >= 0)
		{
			if (!false)
			{
				global::ATL.CStringData* result;
				if (global::<Module>.ATL.AtlAdd<int>(&nChars, nChars, 1) < 0)
				{
					result = null;
				}
				else
				{
					int num = global::<Module>.ATL.AtlAlignUp<int>(nChars, 8);
					while (nChars <= num)
					{
						if (!false)
						{
							uint tRight;
							uint num2;
							if (global::<Module>.ATL.AtlMultiply<unsigned\u0020long>(&tRight, num, nCharSize) < 0 || global::<Module>.ATL.AtlAdd<unsigned\u0020long>(&num2, 16, tRight) < 0)
							{
								return 0;
							}
							global::ATL.CStringData* ptr = calli(System.Void* modopt(System.Runtime.CompilerServices.CallConvThiscall)(System.IntPtr,System.Void*,System.UInt32), *(A_0 + 4), pData, num2, *(*(*(A_0 + 4)) + 8));
							if (ptr == null)
							{
								return 0;
							}
							*(int*)(ptr + 8 / sizeof(global::ATL.CStringData)) = num - 1;
							return ptr;
						}
					}
					result = null;
				}
				return result;
			}
		}
		return 0;
	}

	// Token: 0x06000080 RID: 128 RVA: 0x00004960 File Offset: 0x00003D60
	internal unsafe static global::ATL.CStringData* GetNilString(global::ATL.CAtlStringMgr* A_0)
	{
		global::<Module>.ATL.CStringData.AddRef(A_0 + 8);
		return A_0 + 8;
	}

	// Token: 0x06000081 RID: 129 RVA: 0x0000499C File Offset: 0x00003D9C
	internal unsafe static global::ATL.IAtlStringMgr* Clone(global::ATL.CAtlStringMgr* A_0)
	{
		return A_0;
	}

	// Token: 0x06000082 RID: 130 RVA: 0x0000341C File Offset: 0x0000281C
	[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
	internal static bool StaticInitialize()
	{
		global::<Module>.ATL.CAtlStringMgr.GetInstance();
		return 1;
	}

	// Token: 0x06000083 RID: 131 RVA: 0x00008674 File Offset: 0x00007A74
	internal static void ??__FstrMgr@?1??GetInstance@CAtlStringMgr@ATL@@SAPAUIAtlStringMgr@2@XZ@YMXXZ()
	{
		global::<Module>.ATL.CAtlStringMgr.{dtor}(ref global::<Module>.?strMgr@?1??GetInstance@CAtlStringMgr@ATL@@SAPAUIAtlStringMgr@3@XZ@4V23@A);
	}

	// Token: 0x06000084 RID: 132 RVA: 0x00008694 File Offset: 0x00007A94
	internal static void ??__FstrHeap@?1??GetInstance@CAtlStringMgr@ATL@@SAPAUIAtlStringMgr@2@XZ@YMXXZ()
	{
		global::<Module>.ATL.CWin32Heap.{dtor}(ref global::<Module>.?strHeap@?1??GetInstance@CAtlStringMgr@ATL@@SAPAUIAtlStringMgr@3@XZ@4VCWin32Heap@3@A);
	}

	// Token: 0x06000085 RID: 133 RVA: 0x000049B4 File Offset: 0x00003DB4
	internal unsafe static void* __vecDelDtor(global::ATL.CAtlStringMgr* A_0, uint A_0)
	{
		void* result;
		if ((A_0 & 2U) != 0U)
		{
			global::<Module>.__ehvec_dtor(A_0, 28U, *(A_0 - 4), ldftn(ATL.CAtlStringMgr.{dtor}));
			if ((A_0 & 1U) != 0U)
			{
				global::<Module>.delete[](A_0 - 4);
			}
			result = A_0 - 4;
		}
		else
		{
			global::<Module>.ATL.CAtlStringMgr.{dtor}(A_0);
			if ((A_0 & 1U) != 0U)
			{
				global::<Module>.delete(A_0);
			}
			result = A_0;
		}
		return result;
	}

	// Token: 0x06000086 RID: 134 RVA: 0x0000165C File Offset: 0x00000A5C
	internal static void ??__E?isInitialized@CAtlStringMgr@ATL@@0_NA@@YMXXZ()
	{
		global::<Module>.?isInitialized@CAtlStringMgr@ATL@@0_NA = (global::<Module>.ATL.CAtlStringMgr.StaticInitialize() != null);
	}

	// Token: 0x06000087 RID: 135 RVA: 0x0000252C File Offset: 0x0000192C
	internal unsafe static global::std.runtime_error* {ctor}(global::std.runtime_error* A_0, global::std.runtime_error* A_0)
	{
		global::<Module>.std.exception.{ctor}(A_0, A_0);
		try
		{
			*A_0 = ref global::<Module>.??_7runtime_error@std@@6B@;
		}
		catch
		{
			global::<Module>.___CxxCallUnwindDtor(ldftn(std.exception.{dtor}), A_0);
			throw;
		}
		return A_0;
	}

	// Token: 0x06000088 RID: 136 RVA: 0x0000257C File Offset: 0x0000197C
	internal unsafe static global::std.locale* {ctor}(global::std.locale* A_0, global::std.locale* _Right)
	{
		*A_0 = *_Right;
		calli(System.Void modopt(System.Runtime.CompilerServices.CallConvThiscall)(System.IntPtr), *A_0, *(*(*A_0) + 4));
		return A_0;
	}

	// Token: 0x06000089 RID: 137 RVA: 0x000025A4 File Offset: 0x000019A4
	internal unsafe static global::std.error_category* {ctor}(global::std.error_category* A_0)
	{
		*A_0 = ref global::<Module>.??_7error_category@std@@6B@;
		return A_0;
	}

	// Token: 0x0600008A RID: 138 RVA: 0x000025BC File Offset: 0x000019BC
	internal unsafe static void {dtor}(global::std.error_category* A_0)
	{
		*A_0 = ref global::<Module>.??_7error_category@std@@6B@;
	}

	// Token: 0x0600008B RID: 139 RVA: 0x00004B1C File Offset: 0x00003F1C
	[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
	internal unsafe static bool ==(global::std.error_category* A_0, global::std.error_category* _Right)
	{
		return (A_0 != _Right) ? 0 : 1;
	}

	// Token: 0x0600008C RID: 140 RVA: 0x00004A64 File Offset: 0x00003E64
	internal unsafe static void* __vecDelDtor(global::std.error_category* A_0, uint A_0)
	{
		void* result;
		if ((A_0 & 2U) != 0U)
		{
			global::<Module>.__ehvec_dtor(A_0, 4U, *(A_0 - 4), ldftn(std.error_category.{dtor}));
			if ((A_0 & 1U) != 0U)
			{
				global::<Module>.delete[](A_0 - 4);
			}
			result = A_0 - 4;
		}
		else
		{
			global::<Module>.std.error_category.{dtor}(A_0);
			if ((A_0 & 1U) != 0U)
			{
				global::<Module>.delete(A_0);
			}
			result = A_0;
		}
		return result;
	}

	// Token: 0x0600008D RID: 141 RVA: 0x00004B34 File Offset: 0x00003F34
	internal unsafe static int value(global::std.error_code* A_0)
	{
		return *A_0;
	}

	// Token: 0x0600008E RID: 142 RVA: 0x00004B48 File Offset: 0x00003F48
	internal unsafe static global::std.error_category* category(global::std.error_code* A_0)
	{
		return *(A_0 + 4);
	}

	// Token: 0x0600008F RID: 143 RVA: 0x00004AD0 File Offset: 0x00003ED0
	internal unsafe static global::std.error_condition* {ctor}(global::std.error_condition* A_0, int _Val, global::std.error_category* _Cat)
	{
		*A_0 = _Val;
		*(A_0 + 4) = _Cat;
		return A_0;
	}

	// Token: 0x06000090 RID: 144 RVA: 0x00004BC0 File Offset: 0x00003FC0
	internal unsafe static int value(global::std.error_condition* A_0)
	{
		return *A_0;
	}

	// Token: 0x06000091 RID: 145 RVA: 0x00004BD4 File Offset: 0x00003FD4
	internal unsafe static global::std.error_category* category(global::std.error_condition* A_0)
	{
		return *(A_0 + 4);
	}

	// Token: 0x06000092 RID: 146 RVA: 0x00004B88 File Offset: 0x00003F88
	[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
	internal unsafe static bool ==(global::std.error_condition* A_0, global::std.error_condition* _Right)
	{
		int result;
		if (global::<Module>.std.error_category.==(global::<Module>.std.error_condition.category(A_0), global::<Module>.std.error_condition.category(_Right)) != null && global::<Module>.std.error_condition.value(A_0) == global::<Module>.std.error_condition.value(_Right))
		{
			result = 1;
		}
		else
		{
			result = 0;
		}
		return result;
	}

	// Token: 0x06000093 RID: 147 RVA: 0x00004AB4 File Offset: 0x00003EB4
	internal unsafe static global::std.error_condition* default_error_condition(global::std.error_category* A_0, global::std.error_condition* A_1, int _Errval)
	{
		global::<Module>.std.error_condition.{ctor}(A_1, _Errval, A_0);
		return A_1;
	}

	// Token: 0x06000094 RID: 148 RVA: 0x00004B64 File Offset: 0x00003F64
	[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
	internal unsafe static bool equivalent(global::std.error_category* A_0, int _Errval, global::std.error_condition* _Cond)
	{
		global::std.error_condition error_condition;
		return global::<Module>.std.error_condition.==(calli(std.error_condition* modreq(System.Runtime.CompilerServices.IsUdtReturn) modopt(System.Runtime.CompilerServices.CallConvThiscall)(System.IntPtr,std.error_condition*,System.Int32), A_0, ref error_condition, _Errval, *(*A_0 + 12)), _Cond);
	}

	// Token: 0x06000095 RID: 149 RVA: 0x00004AEC File Offset: 0x00003EEC
	[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
	internal unsafe static bool equivalent(global::std.error_category* A_0, global::std.error_code* _Code, int _Errval)
	{
		int result;
		if (global::<Module>.std.error_category.==(A_0, global::<Module>.std.error_code.category(_Code)) != null && global::<Module>.std.error_code.value(_Code) == _Errval)
		{
			result = 1;
		}
		else
		{
			result = 0;
		}
		return result;
	}

	// Token: 0x06000096 RID: 150 RVA: 0x00004F94 File Offset: 0x00004394
	internal unsafe static void* __vecDelDtor(global::std._System_error* A_0, uint A_0)
	{
		void* result;
		if ((A_0 & 2U) != 0U)
		{
			global::<Module>.__ehvec_dtor(A_0, 20U, *(A_0 - 4), ldftn(std._System_error.{dtor}));
			if ((A_0 & 1U) != 0U)
			{
				global::<Module>.delete[](A_0 - 4);
			}
			result = A_0 - 4;
		}
		else
		{
			global::<Module>.std._System_error.{dtor}(A_0);
			if ((A_0 & 1U) != 0U)
			{
				global::<Module>.delete(A_0);
			}
			result = A_0;
		}
		return result;
	}

	// Token: 0x06000097 RID: 151 RVA: 0x000025D0 File Offset: 0x000019D0
	internal unsafe static void {dtor}(global::std._System_error* A_0)
	{
		global::<Module>.std.runtime_error.{dtor}(A_0);
	}

	// Token: 0x06000098 RID: 152 RVA: 0x00005198 File Offset: 0x00004598
	internal unsafe static void* __vecDelDtor(global::std.system_error* A_0, uint A_0)
	{
		void* result;
		if ((A_0 & 2U) != 0U)
		{
			global::<Module>.__ehvec_dtor(A_0, 20U, *(A_0 - 4), ldftn(std.system_error.{dtor}));
			if ((A_0 & 1U) != 0U)
			{
				global::<Module>.delete[](A_0 - 4);
			}
			result = A_0 - 4;
		}
		else
		{
			global::<Module>.std.system_error.{dtor}(A_0);
			if ((A_0 & 1U) != 0U)
			{
				global::<Module>.delete(A_0);
			}
			result = A_0;
		}
		return result;
	}

	// Token: 0x06000099 RID: 153 RVA: 0x000025E4 File Offset: 0x000019E4
	internal unsafe static void {dtor}(global::std.system_error* A_0)
	{
		global::<Module>.std._System_error.{dtor}(A_0);
	}

	// Token: 0x0600009A RID: 154 RVA: 0x000025F8 File Offset: 0x000019F8
	internal unsafe static global::std._Generic_error_category* {ctor}(global::std._Generic_error_category* A_0)
	{
		global::<Module>.std.error_category.{ctor}(A_0);
		try
		{
			*A_0 = ref global::<Module>.??_7_Generic_error_category@std@@6B@;
		}
		catch
		{
			global::<Module>.___CxxCallUnwindDtor(ldftn(std.error_category.{dtor}), A_0);
			throw;
		}
		return A_0;
	}

	// Token: 0x0600009B RID: 155 RVA: 0x00004C58 File Offset: 0x00004058
	internal unsafe static sbyte* name(global::std._Generic_error_category* A_0)
	{
		return ref global::<Module>.??_C@_07DCLBNMLN@generic?$AA@;
	}

	// Token: 0x0600009C RID: 156 RVA: 0x00004C74 File Offset: 0x00004074
	internal unsafe static global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* message(global::std._Generic_error_category* A_0, global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* A_1, int _Errcode)
	{
		uint num = 0U;
		sbyte* ptr = global::<Module>.std._Syserror_map(_Errcode);
		sbyte* ptr2;
		if (ptr != null)
		{
			ptr2 = ptr;
		}
		else
		{
			ptr2 = (sbyte*)(&global::<Module>.??_C@_0O@BFJCFAAK@unknown?5error?$AA@);
		}
		global::<Module>.std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>.{ctor}(A_1, ptr2);
		try
		{
			num |= 1U;
		}
		catch
		{
			if ((num & 1U) != 0U)
			{
				num &= 4294967294U;
				global::<Module>.___CxxCallUnwindDtor(ldftn(std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>.{dtor}), (void*)A_1);
			}
			throw;
		}
		return A_1;
	}

	// Token: 0x0600009D RID: 157 RVA: 0x00004C08 File Offset: 0x00004008
	internal unsafe static void* __vecDelDtor(global::std._Generic_error_category* A_0, uint A_0)
	{
		void* result;
		if ((A_0 & 2U) != 0U)
		{
			global::<Module>.__ehvec_dtor(A_0, 4U, *(A_0 - 4), ldftn(std._Generic_error_category.{dtor}));
			if ((A_0 & 1U) != 0U)
			{
				global::<Module>.delete[](A_0 - 4);
			}
			result = A_0 - 4;
		}
		else
		{
			global::<Module>.std._Generic_error_category.{dtor}(A_0);
			if ((A_0 & 1U) != 0U)
			{
				global::<Module>.delete(A_0);
			}
			result = A_0;
		}
		return result;
	}

	// Token: 0x0600009E RID: 158 RVA: 0x00002640 File Offset: 0x00001A40
	internal unsafe static void {dtor}(global::std._Generic_error_category* A_0)
	{
		global::<Module>.std.error_category.{dtor}(A_0);
	}

	// Token: 0x0600009F RID: 159 RVA: 0x00002654 File Offset: 0x00001A54
	internal unsafe static global::std._Iostream_error_category* {ctor}(global::std._Iostream_error_category* A_0)
	{
		global::<Module>.std._Generic_error_category.{ctor}(A_0);
		try
		{
			*A_0 = ref global::<Module>.??_7_Iostream_error_category@std@@6B@;
		}
		catch
		{
			global::<Module>.___CxxCallUnwindDtor(ldftn(std._Generic_error_category.{dtor}), A_0);
			throw;
		}
		return A_0;
	}

	// Token: 0x060000A0 RID: 160 RVA: 0x00004D44 File Offset: 0x00004144
	internal unsafe static sbyte* name(global::std._Iostream_error_category* A_0)
	{
		return ref global::<Module>.??_C@_08LLGCOLLL@iostream?$AA@;
	}

	// Token: 0x060000A1 RID: 161 RVA: 0x00004D60 File Offset: 0x00004160
	internal unsafe static global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* message(global::std._Iostream_error_category* A_0, global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* A_1, int _Errcode)
	{
		uint num = 0U;
		global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* ptr;
		if (_Errcode == 1)
		{
			global::<Module>.std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>.{ctor}(A_1, (sbyte*)(&global::<Module>.??_C@_0BG@PADBLCHM@iostream?5stream?5error?$AA@));
			try
			{
				num |= 1U;
				ptr = A_1;
				goto IL_5B;
			}
			catch
			{
				if ((num & 1U) != 0U)
				{
					num &= 4294967294U;
					global::<Module>.___CxxCallUnwindDtor(ldftn(std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>.{dtor}), (void*)A_1);
				}
				throw;
			}
		}
		global::<Module>.std._Generic_error_category.message(A_0, A_1, _Errcode);
		try
		{
			num |= 1U;
			ptr = A_1;
		}
		catch
		{
			if ((num & 1U) != 0U)
			{
				num &= 4294967294U;
				global::<Module>.___CxxCallUnwindDtor(ldftn(std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>.{dtor}), (void*)A_1);
			}
			throw;
		}
		IL_5B:
		global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* result;
		try
		{
			result = ptr;
		}
		catch
		{
			if ((num & 1U) != 0U)
			{
				num &= 4294967294U;
				global::<Module>.___CxxCallUnwindDtor(ldftn(std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>.{dtor}), (void*)A_1);
			}
			throw;
		}
		return result;
	}

	// Token: 0x060000A2 RID: 162 RVA: 0x00004CF4 File Offset: 0x000040F4
	internal unsafe static void* __vecDelDtor(global::std._Iostream_error_category* A_0, uint A_0)
	{
		void* result;
		if ((A_0 & 2U) != 0U)
		{
			global::<Module>.__ehvec_dtor(A_0, 4U, *(A_0 - 4), ldftn(std._Iostream_error_category.{dtor}));
			if ((A_0 & 1U) != 0U)
			{
				global::<Module>.delete[](A_0 - 4);
			}
			result = A_0 - 4;
		}
		else
		{
			global::<Module>.std._Iostream_error_category.{dtor}(A_0);
			if ((A_0 & 1U) != 0U)
			{
				global::<Module>.delete(A_0);
			}
			result = A_0;
		}
		return result;
	}

	// Token: 0x060000A3 RID: 163 RVA: 0x0000269C File Offset: 0x00001A9C
	internal unsafe static void {dtor}(global::std._Iostream_error_category* A_0)
	{
		global::<Module>.std._Generic_error_category.{dtor}(A_0);
	}

	// Token: 0x060000A4 RID: 164 RVA: 0x000026B0 File Offset: 0x00001AB0
	internal unsafe static global::std._System_error_category* {ctor}(global::std._System_error_category* A_0)
	{
		global::<Module>.std._Generic_error_category.{ctor}(A_0);
		try
		{
			*A_0 = ref global::<Module>.??_7_System_error_category@std@@6B@;
		}
		catch
		{
			global::<Module>.___CxxCallUnwindDtor(ldftn(std._Generic_error_category.{dtor}), A_0);
			throw;
		}
		return A_0;
	}

	// Token: 0x060000A5 RID: 165 RVA: 0x00004E98 File Offset: 0x00004298
	internal unsafe static sbyte* name(global::std._System_error_category* A_0)
	{
		return ref global::<Module>.??_C@_06FHFOAHML@system?$AA@;
	}

	// Token: 0x060000A6 RID: 166 RVA: 0x00004EB4 File Offset: 0x000042B4
	internal unsafe static global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* message(global::std._System_error_category* A_0, global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* A_1, int _Errcode)
	{
		uint num = 0U;
		sbyte* ptr = global::<Module>.std._Winerror_map(_Errcode);
		sbyte* ptr2;
		if (ptr != null)
		{
			ptr2 = ptr;
		}
		else
		{
			ptr2 = (sbyte*)(&global::<Module>.??_C@_0O@BFJCFAAK@unknown?5error?$AA@);
		}
		global::<Module>.std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>.{ctor}(A_1, ptr2);
		try
		{
			num |= 1U;
		}
		catch
		{
			if ((num & 1U) != 0U)
			{
				num &= 4294967294U;
				global::<Module>.___CxxCallUnwindDtor(ldftn(std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>.{dtor}), (void*)A_1);
			}
			throw;
		}
		return A_1;
	}

	// Token: 0x060000A7 RID: 167 RVA: 0x00004F28 File Offset: 0x00004328
	internal unsafe static global::std.error_condition* default_error_condition(global::std._System_error_category* A_0, global::std.error_condition* A_1, int _Errval)
	{
		global::std.error_condition* result;
		if (global::<Module>.std._Syserror_map(_Errval) != null)
		{
			global::<Module>.std.error_condition.{ctor}(A_1, _Errval, global::<Module>.std.generic_category());
			result = A_1;
		}
		else
		{
			global::<Module>.std.error_condition.{ctor}(A_1, _Errval, global::<Module>.std.system_category());
			result = A_1;
		}
		return result;
	}

	// Token: 0x060000A8 RID: 168 RVA: 0x00004E48 File Offset: 0x00004248
	internal unsafe static void* __vecDelDtor(global::std._System_error_category* A_0, uint A_0)
	{
		void* result;
		if ((A_0 & 2U) != 0U)
		{
			global::<Module>.__ehvec_dtor(A_0, 4U, *(A_0 - 4), ldftn(std._System_error_category.{dtor}));
			if ((A_0 & 1U) != 0U)
			{
				global::<Module>.delete[](A_0 - 4);
			}
			result = A_0 - 4;
		}
		else
		{
			global::<Module>.std._System_error_category.{dtor}(A_0);
			if ((A_0 & 1U) != 0U)
			{
				global::<Module>.delete(A_0);
			}
			result = A_0;
		}
		return result;
	}

	// Token: 0x060000A9 RID: 169 RVA: 0x000026F8 File Offset: 0x00001AF8
	internal unsafe static void {dtor}(global::std._System_error_category* A_0)
	{
		global::<Module>.std._Generic_error_category.{dtor}(A_0);
	}

	// Token: 0x060000AA RID: 170 RVA: 0x00004F60 File Offset: 0x00004360
	internal unsafe static global::std.error_category* generic_category()
	{
		return ref global::<Module>.?_Generic_object@?$_Error_objects@H@std@@2V_Generic_error_category@2@A;
	}

	// Token: 0x060000AB RID: 171 RVA: 0x00004F74 File Offset: 0x00004374
	internal unsafe static global::std.error_category* system_category()
	{
		return ref global::<Module>.?_System_object@?$_Error_objects@H@std@@2V_System_error_category@2@A;
	}

	// Token: 0x060000AC RID: 172 RVA: 0x0000525C File Offset: 0x0000465C
	internal unsafe static void* __vecDelDtor(global::std.ios_base.failure* A_0, uint A_0)
	{
		void* result;
		if ((A_0 & 2U) != 0U)
		{
			global::<Module>.__ehvec_dtor(A_0, 20U, *(A_0 - 4), ldftn(std.ios_base.failure.{dtor}));
			if ((A_0 & 1U) != 0U)
			{
				global::<Module>.delete[](A_0 - 4);
			}
			result = A_0 - 4;
		}
		else
		{
			global::<Module>.std.ios_base.failure.{dtor}(A_0);
			if ((A_0 & 1U) != 0U)
			{
				global::<Module>.delete(A_0);
			}
			result = A_0;
		}
		return result;
	}

	// Token: 0x060000AD RID: 173 RVA: 0x000052A8 File Offset: 0x000046A8
	internal unsafe static void {dtor}(global::std.ios_base.failure* A_0)
	{
		global::<Module>.std.system_error.{dtor}(A_0);
	}

	// Token: 0x060000AE RID: 174 RVA: 0x00003738 File Offset: 0x00002B38
	internal unsafe static global::std.ios_base.failure* {ctor}(global::std.ios_base.failure* A_0, global::std.ios_base.failure* A_0)
	{
		global::<Module>.std.system_error.{ctor}(A_0, A_0);
		try
		{
			*A_0 = ref global::<Module>.??_7failure@ios_base@std@@6B@;
		}
		catch
		{
			global::<Module>.___CxxCallUnwindDtor(ldftn(std.system_error.{dtor}), A_0);
			throw;
		}
		return A_0;
	}

	// Token: 0x060000AF RID: 175 RVA: 0x00003434 File Offset: 0x00002834
	internal unsafe static global::std.system_error* {ctor}(global::std.system_error* A_0, global::std.system_error* A_0)
	{
		global::<Module>.std._System_error.{ctor}(A_0, A_0);
		try
		{
			*A_0 = ref global::<Module>.??_7system_error@std@@6B@;
		}
		catch
		{
			global::<Module>.___CxxCallUnwindDtor(ldftn(std._System_error.{dtor}), A_0);
			throw;
		}
		return A_0;
	}

	// Token: 0x060000B0 RID: 176 RVA: 0x0000270C File Offset: 0x00001B0C
	internal unsafe static global::std._System_error* {ctor}(global::std._System_error* A_0, global::std._System_error* A_0)
	{
		global::<Module>.std.runtime_error.{ctor}(A_0, A_0);
		try
		{
			*A_0 = ref global::<Module>.??_7_System_error@std@@6B@;
			cpblk(A_0 + 12, A_0 + 12, 8);
		}
		catch
		{
			global::<Module>.___CxxCallUnwindDtor(ldftn(std.runtime_error.{dtor}), A_0);
			throw;
		}
		return A_0;
	}

	// Token: 0x060000B1 RID: 177 RVA: 0x00002A04 File Offset: 0x00001E04
	internal unsafe static global::flex_licensing.CFlexLicenseManager* {ctor}(global::flex_licensing.CFlexLicenseManager* A_0)
	{
		*A_0 = ref global::<Module>.??_7CFlexLicenseManager@flex_licensing@@6B@;
		global::<Module>.std.vector<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>,std::allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>\u0020>\u0020>.{ctor}(A_0 + 4);
		try
		{
			*(A_0 + 24) = 0;
		}
		catch
		{
			global::<Module>.___CxxCallUnwindDtor(ldftn(std.vector<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>,std::allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>\u0020>\u0020>.{dtor}), A_0 + 4);
			throw;
		}
		return A_0;
	}

	// Token: 0x060000B2 RID: 178 RVA: 0x000053D8 File Offset: 0x000047D8
	internal unsafe static void* __vecDelDtor(global::flex_licensing.CFlexLicenseManager* A_0, uint A_0)
	{
		void* result;
		if ((A_0 & 2U) != 0U)
		{
			global::<Module>.__ehvec_dtor(A_0, 664U, *(A_0 - 4), ldftn(flex_licensing.CFlexLicenseManager.{dtor}));
			if ((A_0 & 1U) != 0U)
			{
				global::<Module>.delete[](A_0 - 4);
			}
			result = A_0 - 4;
		}
		else
		{
			global::<Module>.flex_licensing.CFlexLicenseManager.{dtor}(A_0);
			if ((A_0 & 1U) != 0U)
			{
				global::<Module>.delete(A_0);
			}
			result = A_0;
		}
		return result;
	}

	// Token: 0x060000B3 RID: 179 RVA: 0x000029B8 File Offset: 0x00001DB8
	internal unsafe static int ValidateFeature(global::flex_licensing.CFlexLicenseManager* A_0, int featureID)
	{
		sbyte* ptr = global::<Module>.flex_licensing.CFlexLicenseManager.GetFeatureFromID(A_0, featureID);
		int result;
		if (ptr != null)
		{
			int num = global::<Module>.flex_licensing.CFlexLicenseManager.NewJob(A_0);
			if (num == 0)
			{
				num = global::<Module>.flex_licensing.CFlexLicenseManager.Checkout(A_0, ptr);
				if (num == 0)
				{
					num = global::<Module>.flex_licensing.CFlexLicenseManager.Checkin(A_0, ptr);
				}
			}
			global::<Module>.flex_licensing.CFlexLicenseManager.Cleanup(A_0);
			result = num;
		}
		else
		{
			result = -600;
		}
		return result;
	}

	// Token: 0x060000B4 RID: 180 RVA: 0x00002A58 File Offset: 0x00001E58
	internal unsafe static void {dtor}(global::flex_licensing.CFlexLicenseManager* A_0)
	{
		*A_0 = ref global::<Module>.??_7CFlexLicenseManager@flex_licensing@@6B@;
		try
		{
			if (*(A_0 + 16) != 0)
			{
				global::<Module>.delete(*(A_0 + 16));
			}
		}
		catch
		{
			global::<Module>.___CxxCallUnwindDtor(ldftn(std.vector<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>,std::allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>\u0020>\u0020>.{dtor}), A_0 + 4);
			throw;
		}
		global::<Module>.std.vector<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>,std::allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>\u0020>\u0020>.{dtor}(A_0 + 4);
	}

	// Token: 0x060000B5 RID: 181 RVA: 0x000028C8 File Offset: 0x00001CC8
	internal unsafe static int NewJob(global::flex_licensing.CFlexLicenseManager* A_0)
	{
		global::lm_handle* ptr;
		int result;
		if (global::<Module>.lc_new_job(null, 0, A_0 + 28, &ptr) != null)
		{
			global::lm_err_info* ptr2 = global::<Module>.lc_err_info(ptr);
			int num = *(int*)ptr2;
			result = num;
		}
		else
		{
			*(A_0 + 24) = ptr;
			result = global::<Module>.flex_licensing.CFlexLicenseManager.InitHost(A_0);
		}
		return result;
	}

	// Token: 0x060000B6 RID: 182 RVA: 0x00002768 File Offset: 0x00001B68
	internal unsafe static void Cleanup(global::flex_licensing.CFlexLicenseManager* A_0)
	{
		if (0 != *(A_0 + 24))
		{
			global::<Module>.lc_free_job(*(A_0 + 24));
			*(A_0 + 24) = 0;
		}
	}

	// Token: 0x060000B7 RID: 183 RVA: 0x00002790 File Offset: 0x00001B90
	internal unsafe static int Checkout(global::flex_licensing.CFlexLicenseManager* A_0, sbyte* feature)
	{
		int num = 0;
		if (0 != *(A_0 + 24))
		{
			num = global::<Module>.lc_set_attr(*(A_0 + 24), 56, *(A_0 + 20));
			num = global::<Module>.lc_set_attr(*(A_0 + 24), 71, null);
			if (num == 0)
			{
				num = global::<Module>.lc_set_attr(*(A_0 + 24), 64, 1);
				if (num == 0 && global::<Module>.lc_checkout(*(A_0 + 24), feature, *(A_0 + 16), 1, 0, A_0 + 28, 16384) != null)
				{
					global::lm_err_info* ptr = global::<Module>.lc_err_info(*(A_0 + 24));
					num = *(int*)ptr;
					global::<Module>.flex_licensing.CFlexLicenseManager.Cleanup(A_0);
				}
			}
		}
		return num;
	}

	// Token: 0x060000B8 RID: 184 RVA: 0x00002810 File Offset: 0x00001C10
	internal unsafe static int Checkin(global::flex_licensing.CFlexLicenseManager* A_0, sbyte* feature)
	{
		if (0 != *(A_0 + 24))
		{
			global::<Module>.lc_checkin(*(A_0 + 24), feature, 0);
		}
		return 0;
	}

	// Token: 0x060000B9 RID: 185 RVA: 0x00002904 File Offset: 0x00001D04
	internal unsafe static int GetAuthCode(global::flex_licensing.CFlexLicenseManager* A_0, sbyte* hostID, int* size)
	{
		int num = 0;
		global::<CppImplementationDetails>.$ArrayType$$$BY0N@D $ArrayType$$$BY0N@D;
		cpblk(ref $ArrayType$$$BY0N@D, ref global::<Module>.?A0xacbfdcdf.unnamed-global-43, 13);
		if (0 == *(A_0 + 24))
		{
			num = global::<Module>.flex_licensing.CFlexLicenseManager.NewJob(A_0);
		}
		if (num == 0)
		{
			global::<CppImplementationDetails>.$ArrayType$$$BY0BAAA@D $ArrayType$$$BY0BAAA@D;
			num = global::<Module>.lc_hostid(*(A_0 + 24), 31, (sbyte*)(&$ArrayType$$$BY0BAAA@D));
			global::<CppImplementationDetails>.$ArrayType$$$BY0N@D $ArrayType$$$BY0N@D2;
			int num2 = global::<Module>.sscanf((sbyte*)(&$ArrayType$$$BY0BAAA@D), (sbyte*)(&$ArrayType$$$BY0N@D), ref $ArrayType$$$BY0N@D2);
			if (num2 > 0)
			{
				global::<Module>.strcpy(hostID, (sbyte*)(&$ArrayType$$$BY0N@D2));
				*size = 13;
			}
			else
			{
				global::<Module>.strcpy(hostID, (sbyte*)(&$ArrayType$$$BY0BAAA@D));
				*size = 4096;
				num = -601;
			}
		}
		global::<Module>.flex_licensing.CFlexLicenseManager.Cleanup(A_0);
		return num;
	}

	// Token: 0x060000BA RID: 186 RVA: 0x00002834 File Offset: 0x00001C34
	internal unsafe static int InitHost(global::flex_licensing.CFlexLicenseManager* A_0)
	{
		global::<CppImplementationDetails>.$ArrayType$$$BY00H $ArrayType$$$BY00H = 11;
		int num = 1;
		int num2 = global::<Module>.lc_init_simple_composite(*(A_0 + 24), (int*)(&$ArrayType$$$BY00H), num);
		if (num2 != 0)
		{
			num2 = global::<Module>.lc_get_errno(*(A_0 + 24));
			global::<Module>.flex_licensing.CFlexLicenseManager.Cleanup(A_0);
		}
		return num2;
	}

	// Token: 0x060000BB RID: 187 RVA: 0x00002ACC File Offset: 0x00001ECC
	internal unsafe static void AddFeature(global::flex_licensing.CFlexLicenseManager* A_0, sbyte* featureValue)
	{
		uint num = global::<Module>.strlen((sbyte*)featureValue);
		sbyte* ptr = global::<Module>.new[](num + 1U);
		global::<Module>.strcpy(ptr, (sbyte*)featureValue);
		global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020> basic_string<char,std::char_traits<char>,std::allocator<char>_u0020>;
		global::<Module>.std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>.{ctor}(ref basic_string<char,std::char_traits<char>,std::allocator<char>_u0020>, (sbyte*)ptr);
		try
		{
			global::<Module>.std.vector<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>,std::allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>\u0020>\u0020>.push_back(A_0 + 4, ref basic_string<char,std::char_traits<char>,std::allocator<char>_u0020>);
		}
		catch
		{
			global::<Module>.___CxxCallUnwindDtor(ldftn(std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>.{dtor}), (void*)(&basic_string<char,std::char_traits<char>,std::allocator<char>_u0020>));
			throw;
		}
		global::<Module>.std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>.{dtor}(ref basic_string<char,std::char_traits<char>,std::allocator<char>_u0020>);
	}

	// Token: 0x060000BC RID: 188 RVA: 0x00002AB4 File Offset: 0x00001EB4
	internal unsafe static void ClearFeatures(global::flex_licensing.CFlexLicenseManager* A_0)
	{
		global::<Module>.std.vector<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>,std::allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>\u0020>\u0020>.clear(A_0 + 4);
	}

	// Token: 0x060000BD RID: 189 RVA: 0x00002870 File Offset: 0x00001C70
	internal unsafe static void SetLicenseDir(global::flex_licensing.CFlexLicenseManager* A_0, sbyte* directory)
	{
		uint num = global::<Module>.strlen((sbyte*)directory);
		sbyte* ptr = global::<Module>.new[](num + 1U);
		global::<Module>.strcpy(ptr, (sbyte*)directory);
		*(A_0 + 20) = ptr;
	}

	// Token: 0x060000BE RID: 190 RVA: 0x0000289C File Offset: 0x00001C9C
	internal unsafe static void SetVersion(global::flex_licensing.CFlexLicenseManager* A_0, sbyte* versionValue)
	{
		uint num = global::<Module>.strlen((sbyte*)versionValue);
		sbyte* ptr = global::<Module>.new[](num + 1U);
		global::<Module>.strcpy(ptr, (sbyte*)versionValue);
		*(A_0 + 16) = ptr;
	}

	// Token: 0x060000BF RID: 191 RVA: 0x00002980 File Offset: 0x00001D80
	internal unsafe static sbyte* GetFeatureFromID(global::flex_licensing.CFlexLicenseManager* A_0, int featureID)
	{
		sbyte* result;
		if (featureID > global::<Module>.std.vector<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>,std::allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>\u0020>\u0020>.size(A_0 + 4) || global::<Module>.std.vector<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>,std::allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>\u0020>\u0020>.size(A_0 + 4) == null)
		{
			result = null;
		}
		else
		{
			result = global::<Module>.std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>.c_str(global::<Module>.std.vector<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>,std::allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>\u0020>\u0020>.[](A_0 + 4, (uint)featureID));
		}
		return result;
	}

	// Token: 0x060000C0 RID: 192 RVA: 0x00003F10 File Offset: 0x00003310
	internal unsafe static global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* {ctor}(global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* A_0, global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* _Right)
	{
		global::std._Wrap_alloc<std::allocator<char>\u0020> wrap_alloc<std::allocator<char>_u0020>;
		global::std._Wrap_alloc<std::allocator<char>\u0020> wrap_alloc<std::allocator<char>_u0020>2;
		global::<Module>.std._String_alloc<0,std::_String_base_types<char,std::allocator<char>\u0020>\u0020>.{ctor}(A_0, global::<Module>.std._Wrap_alloc<std::allocator<char>\u0020>.select_on_container_copy_construction(global::<Module>.std._String_alloc<0,std::_String_base_types<char,std::allocator<char>\u0020>\u0020>._Getal(_Right, &wrap_alloc<std::allocator<char>_u0020>), &wrap_alloc<std::allocator<char>_u0020>2));
		global::<Module>.std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>._Tidy(A_0, false, 0U);
		global::<Module>.std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>.assign(A_0, _Right, 0U, global::<Module>.?npos@?$basic_string@DU?$char_traits@D@std@@V?$allocator@D@2@@std@@2IB);
		return A_0;
	}

	// Token: 0x060000C1 RID: 193 RVA: 0x00003FB8 File Offset: 0x000033B8
	internal unsafe static global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* {ctor}(global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* A_0, sbyte* _Ptr)
	{
		global::std.allocator<char> allocator<char>;
		global::<Module>.std._String_alloc<0,std::_String_base_types<char,std::allocator<char>\u0020>\u0020>.{ctor}(A_0, global::<Module>.std.allocator<char>.{ctor}(ref allocator<char>));
		global::<Module>.std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>._Tidy(A_0, false, 0U);
		global::<Module>.std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>.assign(A_0, _Ptr);
		return A_0;
	}

	// Token: 0x060000C2 RID: 194 RVA: 0x00003DB8 File Offset: 0x000031B8
	internal unsafe static global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* {ctor}(global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* A_0, global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* _Right)
	{
		global::std._Wrap_alloc<std::allocator<char>\u0020> wrap_alloc<std::allocator<char>_u0020>;
		global::<Module>.std._String_alloc<0,std::_String_base_types<char,std::allocator<char>\u0020>\u0020>.{ctor}(A_0, global::<Module>.std._String_alloc<0,std::_String_base_types<char,std::allocator<char>\u0020>\u0020>._Getal(_Right, &wrap_alloc<std::allocator<char>_u0020>));
		global::<Module>.std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>._Tidy(A_0, false, 0U);
		global::<Module>.std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>._Assign_rv(A_0, global::<Module>.std.forward<class\u0020std::basic_string<char,struct\u0020std::char_traits<char>,class\u0020std::allocator<char>\u0020>\u0020>(_Right));
		return A_0;
	}

	// Token: 0x060000C3 RID: 195 RVA: 0x00003C9C File Offset: 0x0000309C
	internal unsafe static void {dtor}(global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* A_0)
	{
		global::<Module>.std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>._Tidy(A_0, true, 0U);
	}

	// Token: 0x060000C4 RID: 196 RVA: 0x00003788 File Offset: 0x00002B88
	internal unsafe static sbyte* c_str(global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* A_0)
	{
		return global::<Module>.std._String_val<std::_Simple_types<char>\u0020>._Myptr(A_0);
	}

	// Token: 0x060000C5 RID: 197 RVA: 0x00002B5C File Offset: 0x00001F5C
	internal unsafe static global::ATL.CComPtrBase<IDispatch>* {ctor}(global::ATL.CComPtrBase<IDispatch>* A_0, global::IDispatch* lp)
	{
		*A_0 = lp;
		if (*A_0 != 0)
		{
			object obj = calli(System.UInt32 modopt(System.Runtime.CompilerServices.IsLong) modopt(System.Runtime.CompilerServices.CallConvStdcall)(System.IntPtr), *A_0, *(*(*A_0) + 4));
		}
		return A_0;
	}

	// Token: 0x060000C6 RID: 198 RVA: 0x00002B80 File Offset: 0x00001F80
	internal unsafe static void {dtor}(global::ATL.CComPtrBase<IDispatch>* A_0)
	{
		if (*A_0 != 0)
		{
			object obj = calli(System.UInt32 modopt(System.Runtime.CompilerServices.IsLong) modopt(System.Runtime.CompilerServices.CallConvStdcall)(System.IntPtr), *A_0, *(*(*A_0) + 8));
		}
	}

	// Token: 0x060000C7 RID: 199 RVA: 0x00003490 File Offset: 0x00002890
	internal unsafe static global::ATL.CComPtr<IUnknown>* {ctor}(global::ATL.CComPtr<IUnknown>* A_0, global::IUnknown* lp)
	{
		global::<Module>.ATL.CComPtrBase<IUnknown>.{ctor}(A_0, lp);
		return A_0;
	}

	// Token: 0x060000C8 RID: 200 RVA: 0x00002BA0 File Offset: 0x00001FA0
	internal unsafe static void {dtor}(global::ATL.CComPtrBase<IUnknown>* A_0)
	{
		if (*A_0 != 0)
		{
			object obj = calli(System.UInt32 modopt(System.Runtime.CompilerServices.IsLong) modopt(System.Runtime.CompilerServices.CallConvStdcall)(System.IntPtr), *A_0, *(*(*A_0) + 8));
		}
	}

	// Token: 0x060000C9 RID: 201 RVA: 0x00002BC0 File Offset: 0x00001FC0
	internal unsafe static global::ATL.CSimpleArray<unsigned\u0020short,ATL::CSimpleArrayEqualHelper<unsigned\u0020short>\u0020>* {ctor}(global::ATL.CSimpleArray<unsigned\u0020short,ATL::CSimpleArrayEqualHelper<unsigned\u0020short>\u0020>* A_0)
	{
		*A_0 = 0;
		*(A_0 + 4) = 0;
		*(A_0 + 8) = 0;
		return A_0;
	}

	// Token: 0x060000CA RID: 202 RVA: 0x00002BDC File Offset: 0x00001FDC
	internal unsafe static int GetSize(global::ATL.CSimpleArray<unsigned\u0020short,ATL::CSimpleArrayEqualHelper<unsigned\u0020short>\u0020>* A_0)
	{
		return *(A_0 + 4);
	}

	// Token: 0x060000CB RID: 203 RVA: 0x00002BF0 File Offset: 0x00001FF0
	internal unsafe static void RemoveAll(global::ATL.CSimpleArray<unsigned\u0020short,ATL::CSimpleArrayEqualHelper<unsigned\u0020short>\u0020>* A_0)
	{
		if (*A_0 != 0)
		{
			for (int i = 0; i < *(A_0 + 4); i++)
			{
			}
			global::<Module>.free(*A_0);
			*A_0 = 0;
		}
		*(A_0 + 4) = 0;
		*(A_0 + 8) = 0;
	}

	// Token: 0x060000CC RID: 204 RVA: 0x00002C28 File Offset: 0x00002028
	internal unsafe static ushort* [](global::ATL.CSimpleArray<unsigned\u0020short,ATL::CSimpleArrayEqualHelper<unsigned\u0020short>\u0020>* A_0, int nIndex)
	{
		if (nIndex < 0 || nIndex >= *(A_0 + 4))
		{
			global::<Module>.ATL._AtlRaiseException(-1073741684, 1);
		}
		return *A_0 + nIndex * 2;
	}

	// Token: 0x060000CD RID: 205 RVA: 0x000037A0 File Offset: 0x00002BA0
	internal unsafe static global::std.vector<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>,std::allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>\u0020>\u0020>* {ctor}(global::std.vector<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>,std::allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>\u0020>\u0020>* A_0)
	{
		global::std.allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>\u0020> allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>_u0020>_u0020>;
		global::<Module>.std._Vector_alloc<0,std::_Vec_base_types<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>,std::allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>\u0020>\u0020>\u0020>.{ctor}(A_0, global::<Module>.std.allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>\u0020>.{ctor}(ref allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>_u0020>_u0020>));
		return A_0;
	}

	// Token: 0x060000CE RID: 206 RVA: 0x000043F4 File Offset: 0x000037F4
	internal unsafe static void push_back(global::std.vector<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>,std::allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>\u0020>\u0020>* A_0, global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* _Val)
	{
		if (global::<Module>.std.vector<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>,std::allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>\u0020>\u0020>._Inside(A_0, global::<Module>.std.addressof<class\u0020std::basic_string<char,struct\u0020std::char_traits<char>,class\u0020std::allocator<char>\u0020>\u0020>(_Val)) != null)
		{
			uint num = (global::<Module>.std.addressof<class\u0020std::basic_string<char,struct\u0020std::char_traits<char>,class\u0020std::allocator<char>\u0020>\u0020>(_Val) - *A_0) / 24;
			if (*(A_0 + 4) == *(A_0 + 8))
			{
				global::<Module>.std.vector<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>,std::allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>\u0020>\u0020>._Reserve(A_0, 1U);
			}
			global::<Module>.std.vector<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>,std::allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>\u0020>\u0020>._Orphan_range(A_0, *(A_0 + 4), *(A_0 + 4));
			global::std._Wrap_alloc<std::allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>\u0020>\u0020> wrap_alloc<std::allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>_u0020>_u0020>_u0020>;
			global::<Module>.std._Wrap_alloc<std::allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>\u0020>\u0020>.construct<class\u0020std::basic_string<char,struct\u0020std::char_traits<char>,class\u0020std::allocator<char>\u0020>,class\u0020std::basic_string<char,struct\u0020std::char_traits<char>,class\u0020std::allocator<char>\u0020>\u0020>(global::<Module>.std._Vector_alloc<0,std::_Vec_base_types<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>,std::allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>\u0020>\u0020>\u0020>._Getal(A_0, &wrap_alloc<std::allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>_u0020>_u0020>_u0020>), *(A_0 + 4), global::<Module>.std.forward<class\u0020std::basic_string<char,struct\u0020std::char_traits<char>,class\u0020std::allocator<char>\u0020>\u0020>(*A_0 + (int)(num * 24U)));
			*(A_0 + 4) = *(A_0 + 4) + 24;
		}
		else
		{
			if (*(A_0 + 4) == *(A_0 + 8))
			{
				global::<Module>.std.vector<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>,std::allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>\u0020>\u0020>._Reserve(A_0, 1U);
			}
			global::<Module>.std.vector<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>,std::allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>\u0020>\u0020>._Orphan_range(A_0, *(A_0 + 4), *(A_0 + 4));
			global::std._Wrap_alloc<std::allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>\u0020>\u0020> wrap_alloc<std::allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>_u0020>_u0020>_u0020>2;
			global::<Module>.std._Wrap_alloc<std::allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>\u0020>\u0020>.construct<class\u0020std::basic_string<char,struct\u0020std::char_traits<char>,class\u0020std::allocator<char>\u0020>,class\u0020std::basic_string<char,struct\u0020std::char_traits<char>,class\u0020std::allocator<char>\u0020>\u0020>(global::<Module>.std._Vector_alloc<0,std::_Vec_base_types<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>,std::allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>\u0020>\u0020>\u0020>._Getal(A_0, &wrap_alloc<std::allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>_u0020>_u0020>_u0020>2), *(A_0 + 4), global::<Module>.std.forward<class\u0020std::basic_string<char,struct\u0020std::char_traits<char>,class\u0020std::allocator<char>\u0020>\u0020>(_Val));
			*(A_0 + 4) = *(A_0 + 4) + 24;
		}
	}

	// Token: 0x060000CF RID: 207 RVA: 0x00004230 File Offset: 0x00003630
	internal unsafe static void {dtor}(global::std.vector<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>,std::allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>\u0020>\u0020>* A_0)
	{
		global::<Module>.std.vector<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>,std::allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>\u0020>\u0020>._Tidy(A_0);
	}

	// Token: 0x060000D0 RID: 208 RVA: 0x00002C54 File Offset: 0x00002054
	internal unsafe static uint size(global::std.vector<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>,std::allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>\u0020>\u0020>* A_0)
	{
		return (*(A_0 + 4) - *A_0) / 24;
	}

	// Token: 0x060000D1 RID: 209 RVA: 0x00002C70 File Offset: 0x00002070
	internal unsafe static global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* [](global::std.vector<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>,std::allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>\u0020>\u0020>* A_0, uint _Pos)
	{
		return *A_0 + (int)(_Pos * 24U);
	}

	// Token: 0x060000D2 RID: 210 RVA: 0x00004244 File Offset: 0x00003644
	internal unsafe static void clear(global::std.vector<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>,std::allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>\u0020>\u0020>* A_0)
	{
		global::<Module>.std._Container_base0._Orphan_all(A_0);
		global::<Module>.std.vector<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>,std::allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>\u0020>\u0020>._Destroy(A_0, *A_0, *(A_0 + 4));
		*(A_0 + 4) = *A_0;
	}

	// Token: 0x060000D3 RID: 211 RVA: 0x00003CB4 File Offset: 0x000030B4
	internal unsafe static void _Assign_rv(global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* A_0, global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* _Right)
	{
		if (*(_Right + 20) < 16)
		{
			global::<Module>.std.char_traits<char>.move(A_0, _Right, (uint)(*(_Right + 16) + 1));
		}
		else
		{
			global::std._Wrap_alloc<std::allocator<char>\u0020> wrap_alloc<std::allocator<char>_u0020>;
			global::<Module>.std._Wrap_alloc<std::allocator<char>\u0020>.construct<char\u0020*,char\u0020*\u0020&>(global::<Module>.std._String_alloc<0,std::_String_base_types<char,std::allocator<char>\u0020>\u0020>._Getal(A_0, &wrap_alloc<std::allocator<char>_u0020>), A_0, _Right);
			*_Right = 0;
		}
		*(A_0 + 16) = *(_Right + 16);
		*(A_0 + 20) = *(_Right + 20);
		global::<Module>.std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>._Tidy(_Right, false, 0U);
	}

	// Token: 0x060000D4 RID: 212 RVA: 0x00003DEC File Offset: 0x000031EC
	internal unsafe static global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* assign(global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* A_0, global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* _Right, uint _Roff, uint _Count)
	{
		if (global::<Module>.std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>.size(_Right) < _Roff)
		{
			global::<Module>.std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>._Xran(A_0);
		}
		uint num = global::<Module>.std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>.size(_Right) - _Roff;
		if (_Count < num)
		{
			num = _Count;
		}
		if (A_0 == _Right)
		{
			global::<Module>.std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>.erase(A_0, _Roff + num);
			global::<Module>.std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>.erase(A_0, 0U, _Roff);
		}
		else if (global::<Module>.std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>._Grow(A_0, num, false) != null)
		{
			global::<Module>.std.char_traits<char>.copy(global::<Module>.std._String_val<std::_Simple_types<char>\u0020>._Myptr(A_0), global::<Module>.std._String_val<std::_Simple_types<char>\u0020>._Myptr(_Right) + _Roff, num);
			global::<Module>.std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>._Eos(A_0, num);
		}
		return A_0;
	}

	// Token: 0x060000D5 RID: 213 RVA: 0x00003F50 File Offset: 0x00003350
	internal unsafe static global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* assign(global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* A_0, sbyte* _Ptr)
	{
		return global::<Module>.std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>.assign(A_0, _Ptr, global::<Module>.std.char_traits<char>.length(_Ptr));
	}

	// Token: 0x060000D6 RID: 214 RVA: 0x00002C88 File Offset: 0x00002088
	internal unsafe static uint size(global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* A_0)
	{
		return *(A_0 + 16);
	}

	// Token: 0x060000D7 RID: 215 RVA: 0x00003904 File Offset: 0x00002D04
	internal unsafe static void _Tidy(global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* A_0, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)] bool _Built, uint _Newsize)
	{
		if (_Built)
		{
			if (16 <= *(A_0 + 20))
			{
				sbyte* ptr = *A_0;
				global::std._Wrap_alloc<std::allocator<char>\u0020> wrap_alloc<std::allocator<char>_u0020>;
				global::<Module>.std._Wrap_alloc<std::allocator<char>\u0020>.destroy<char\u0020*>(global::<Module>.std._String_alloc<0,std::_String_base_types<char,std::allocator<char>\u0020>\u0020>._Getal(A_0, &wrap_alloc<std::allocator<char>_u0020>), A_0);
				if (0U < _Newsize)
				{
					global::<Module>.std.char_traits<char>.copy(A_0, global::<Module>.std.addressof<char>(ptr), _Newsize);
				}
				global::std._Wrap_alloc<std::allocator<char>\u0020> wrap_alloc<std::allocator<char>_u0020>2;
				global::<Module>.std._Wrap_alloc<std::allocator<char>\u0020>.deallocate(global::<Module>.std._String_alloc<0,std::_String_base_types<char,std::allocator<char>\u0020>\u0020>._Getal(A_0, &wrap_alloc<std::allocator<char>_u0020>2), ptr, (uint)(*(A_0 + 20) + 1));
			}
		}
		*(A_0 + 20) = 15;
		global::<Module>.std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>._Eos(A_0, _Newsize);
	}

	// Token: 0x060000D8 RID: 216 RVA: 0x00002C9C File Offset: 0x0000209C
	internal unsafe static global::std.allocator<char>* {ctor}(global::std.allocator<char>* A_0)
	{
		return A_0;
	}

	// Token: 0x060000D9 RID: 217 RVA: 0x000034A8 File Offset: 0x000028A8
	internal unsafe static global::std._String_alloc<0,std::_String_base_types<char,std::allocator<char>\u0020>\u0020>* {ctor}(global::std._String_alloc<0,std::_String_base_types<char,std::allocator<char>\u0020>\u0020>* A_0, global::std.allocator<char>* A_0)
	{
		global::<Module>.std._String_val<std::_Simple_types<char>\u0020>.{ctor}(A_0);
		return A_0;
	}

	// Token: 0x060000DA RID: 218 RVA: 0x000034C0 File Offset: 0x000028C0
	internal unsafe static global::std._Wrap_alloc<std::allocator<char>\u0020>* _Getal(global::std._String_alloc<0,std::_String_base_types<char,std::allocator<char>\u0020>\u0020>* A_0, global::std._Wrap_alloc<std::allocator<char>\u0020>* A_1)
	{
		global::<Module>.std._Wrap_alloc<std::allocator<char>\u0020>.{ctor}(A_1);
		return A_1;
	}

	// Token: 0x060000DB RID: 219 RVA: 0x00003968 File Offset: 0x00002D68
	internal unsafe static global::std._Wrap_alloc<std::allocator<char>\u0020>* select_on_container_copy_construction(global::std._Wrap_alloc<std::allocator<char>\u0020>* A_0, global::std._Wrap_alloc<std::allocator<char>\u0020>* A_1)
	{
		global::std.allocator<char> allocator<char>;
		global::<Module>.std._Wrap_alloc<std::allocator<char>\u0020>.{ctor}(A_1, global::<Module>.std.allocator_traits<std::allocator<char>\u0020>.select_on_container_copy_construction(&allocator<char>, A_0));
		return A_1;
	}

	// Token: 0x060000DC RID: 220 RVA: 0x000034D8 File Offset: 0x000028D8
	internal unsafe static sbyte* _Myptr(global::std._String_val<std::_Simple_types<char>\u0020>* A_0)
	{
		return (16 > *(A_0 + 20)) ? A_0 : global::<Module>.std.addressof<char>(*A_0);
	}

	// Token: 0x060000DD RID: 221 RVA: 0x00002CAC File Offset: 0x000020AC
	internal unsafe static global::ATL.CComPtrBase<IUnknown>* {ctor}(global::ATL.CComPtrBase<IUnknown>* A_0, global::IUnknown* lp)
	{
		*A_0 = lp;
		if (*A_0 != 0)
		{
			object obj = calli(System.UInt32 modopt(System.Runtime.CompilerServices.IsLong) modopt(System.Runtime.CompilerServices.CallConvStdcall)(System.IntPtr), *A_0, *(*(*A_0) + 4));
		}
		return A_0;
	}

	// Token: 0x060000DE RID: 222 RVA: 0x000041A0 File Offset: 0x000035A0
	internal unsafe static void _Destroy(global::std.vector<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>,std::allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>\u0020>\u0020>* A_0, global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* _First, global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* _Last)
	{
		global::std._Wrap_alloc<std::allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>\u0020>\u0020> wrap_alloc<std::allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>_u0020>_u0020>_u0020>;
		global::<Module>.std._Vector_alloc<0,std::_Vec_base_types<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>,std::allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>\u0020>\u0020>\u0020>._Getal(A_0, &wrap_alloc<std::allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>_u0020>_u0020>_u0020>);
		global::<Module>.std._Destroy_range<struct\u0020std::_Wrap_alloc<class\u0020std::allocator<class\u0020std::basic_string<char,struct\u0020std::char_traits<char>,class\u0020std::allocator<char>\u0020>\u0020>\u0020>\u0020>(_First, _Last, ref wrap_alloc<std::allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>_u0020>_u0020>_u0020>);
	}

	// Token: 0x060000DF RID: 223 RVA: 0x00002CD0 File Offset: 0x000020D0
	[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
	internal unsafe static bool _Inside(global::std.vector<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>,std::allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>\u0020>\u0020>* A_0, global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* _Ptr)
	{
		int result;
		if (_Ptr < *(A_0 + 4) && *A_0 <= _Ptr)
		{
			result = 1;
		}
		else
		{
			result = 0;
		}
		return result;
	}

	// Token: 0x060000E0 RID: 224 RVA: 0x000043B4 File Offset: 0x000037B4
	internal unsafe static void _Reserve(global::std.vector<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>,std::allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>\u0020>\u0020>* A_0, uint _Count)
	{
		if (global::<Module>.std.vector<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>,std::allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>\u0020>\u0020>._Unused_capacity(A_0) < _Count)
		{
			if (global::<Module>.std.vector<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>,std::allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>\u0020>\u0020>.max_size(A_0) - global::<Module>.std.vector<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>,std::allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>\u0020>\u0020>.size(A_0) < _Count)
			{
				global::<Module>.std.vector<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>,std::allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>\u0020>\u0020>._Xlen(A_0);
			}
			global::<Module>.std.vector<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>,std::allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>\u0020>\u0020>._Reallocate(A_0, global::<Module>.std.vector<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>,std::allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>\u0020>\u0020>._Grow_to(A_0, global::<Module>.std.vector<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>,std::allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>\u0020>\u0020>.size(A_0) + _Count));
		}
	}

	// Token: 0x060000E1 RID: 225 RVA: 0x000041C0 File Offset: 0x000035C0
	internal unsafe static void _Tidy(global::std.vector<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>,std::allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>\u0020>\u0020>* A_0)
	{
		if (*A_0 != 0)
		{
			global::<Module>.std._Container_base0._Orphan_all(A_0);
			global::<Module>.std.vector<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>,std::allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>\u0020>\u0020>._Destroy(A_0, *A_0, *(A_0 + 4));
			global::std._Wrap_alloc<std::allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>\u0020>\u0020> wrap_alloc<std::allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>_u0020>_u0020>_u0020>;
			global::<Module>.std._Wrap_alloc<std::allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>\u0020>\u0020>.deallocate(global::<Module>.std._Vector_alloc<0,std::_Vec_base_types<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>,std::allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>\u0020>\u0020>\u0020>._Getal(A_0, &wrap_alloc<std::allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>_u0020>_u0020>_u0020>), *A_0, (uint)((*(A_0 + 8) - *A_0) / 24));
			*A_0 = 0;
			*(A_0 + 4) = 0;
			*(A_0 + 8) = 0;
		}
	}

	// Token: 0x060000E2 RID: 226 RVA: 0x00002CF4 File Offset: 0x000020F4
	internal unsafe static void _Orphan_range(global::std.vector<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>,std::allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>\u0020>\u0020>* A_0, global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* A_0, global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* A_1)
	{
	}

	// Token: 0x060000E3 RID: 227 RVA: 0x00002D04 File Offset: 0x00002104
	internal unsafe static global::std.allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>\u0020>* {ctor}(global::std.allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>\u0020>* A_0)
	{
		return A_0;
	}

	// Token: 0x060000E4 RID: 228 RVA: 0x000034FC File Offset: 0x000028FC
	internal unsafe static global::std._Vector_alloc<0,std::_Vec_base_types<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>,std::allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>\u0020>\u0020>\u0020>* {ctor}(global::std._Vector_alloc<0,std::_Vec_base_types<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>,std::allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>\u0020>\u0020>\u0020>* A_0, global::std.allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>\u0020>* A_0)
	{
		global::<Module>.std._Vector_val<std::_Simple_types<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>\u0020>\u0020>.{ctor}(A_0);
		return A_0;
	}

	// Token: 0x060000E5 RID: 229 RVA: 0x00003514 File Offset: 0x00002914
	internal unsafe static global::std._Wrap_alloc<std::allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>\u0020>\u0020>* _Getal(global::std._Vector_alloc<0,std::_Vec_base_types<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>,std::allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>\u0020>\u0020>\u0020>* A_0, global::std._Wrap_alloc<std::allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>\u0020>\u0020>* A_1)
	{
		global::<Module>.std._Wrap_alloc<std::allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>\u0020>\u0020>.{ctor}(A_1);
		return A_1;
	}

	// Token: 0x060000E6 RID: 230 RVA: 0x00003E5C File Offset: 0x0000325C
	internal unsafe static global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* assign(global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* A_0, sbyte* _Ptr, uint _Count)
	{
		global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* result;
		if (global::<Module>.std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>._Inside(A_0, _Ptr) != null)
		{
			result = global::<Module>.std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>.assign(A_0, A_0, _Ptr - global::<Module>.std._String_val<std::_Simple_types<char>\u0020>._Myptr(A_0) / sizeof(sbyte), _Count);
		}
		else
		{
			if (global::<Module>.std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>._Grow(A_0, _Count, false) != null)
			{
				global::<Module>.std.char_traits<char>.copy(global::<Module>.std._String_val<std::_Simple_types<char>\u0020>._Myptr(A_0), _Ptr, _Count);
				global::<Module>.std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>._Eos(A_0, _Count);
			}
			result = A_0;
		}
		return result;
	}

	// Token: 0x060000E7 RID: 231 RVA: 0x00003988 File Offset: 0x00002D88
	internal unsafe static global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* erase(global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* A_0, uint _Off)
	{
		if (*(A_0 + 16) < (int)_Off)
		{
			global::<Module>.std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>._Xran(A_0);
		}
		global::<Module>.std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>._Eos(A_0, _Off);
		return A_0;
	}

	// Token: 0x060000E8 RID: 232 RVA: 0x000039B0 File Offset: 0x00002DB0
	internal unsafe static global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* erase(global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* A_0, uint _Off, uint _Count)
	{
		if (*(A_0 + 16) < (int)_Off)
		{
			global::<Module>.std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>._Xran(A_0);
		}
		if (*(A_0 + 16) - (int)_Off <= (int)_Count)
		{
			global::<Module>.std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>._Eos(A_0, _Off);
		}
		else if (0U < _Count)
		{
			sbyte* ptr = global::<Module>.std._String_val<std::_Simple_types<char>\u0020>._Myptr(A_0) + _Off;
			uint num = (uint)(*(A_0 + 16) - (int)_Count);
			sbyte* ptr2 = ptr;
			global::<Module>.std.char_traits<char>.move(ptr2, (sbyte*)(ptr2 + _Count / (uint)sizeof(sbyte)), num - _Off);
			global::<Module>.std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>._Eos(A_0, num);
		}
		return A_0;
	}

	// Token: 0x060000E9 RID: 233 RVA: 0x000037BC File Offset: 0x00002BBC
	internal unsafe static void _Eos(global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* A_0, uint _Newsize)
	{
		sbyte b = 0;
		*(A_0 + 16) = (int)_Newsize;
		global::<Module>.std.char_traits<char>.assign(global::<Module>.std._String_val<std::_Simple_types<char>\u0020>._Myptr(A_0) + _Newsize, ref b);
	}

	// Token: 0x060000EA RID: 234 RVA: 0x00003D0C File Offset: 0x0000310C
	[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
	internal unsafe static bool _Grow(global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* A_0, uint _Newsize, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)] bool _Trim)
	{
		if (global::<Module>.std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>.max_size(A_0) < _Newsize)
		{
			global::<Module>.std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>._Xlen(A_0);
		}
		if (*(A_0 + 20) < (int)_Newsize)
		{
			global::<Module>.std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>._Copy(A_0, _Newsize, (uint)(*(A_0 + 16)));
		}
		else if (_Trim && _Newsize < 16U)
		{
			uint newsize;
			if (_Newsize < (uint)(*(A_0 + 16)))
			{
				newsize = _Newsize;
			}
			else
			{
				newsize = (uint)(*(A_0 + 16));
			}
			global::<Module>.std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>._Tidy(A_0, true, newsize);
		}
		else if (_Newsize == 0U)
		{
			global::<Module>.std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>._Eos(A_0, 0U);
		}
		return (0U >= _Newsize) ? 0 : 1;
	}

	// Token: 0x060000EB RID: 235 RVA: 0x000037E0 File Offset: 0x00002BE0
	[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
	internal unsafe static bool _Inside(global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* A_0, sbyte* _Ptr)
	{
		return _Ptr != null && _Ptr >= global::<Module>.std._String_val<std::_Simple_types<char>\u0020>._Myptr(A_0) && global::<Module>.std._String_val<std::_Simple_types<char>\u0020>._Myptr(A_0) + *(A_0 + 16) != _Ptr;
	}

	// Token: 0x060000EC RID: 236 RVA: 0x00002D14 File Offset: 0x00002114
	internal unsafe static void _Xlen(global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* A_0)
	{
		global::<Module>.std._Xlength_error((sbyte*)(&global::<Module>.??_C@_0BA@JFNIOLAK@string?5too?5long?$AA@));
	}

	// Token: 0x060000ED RID: 237 RVA: 0x00002D2C File Offset: 0x0000212C
	internal unsafe static void _Xran(global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* A_0)
	{
		global::<Module>.std._Xout_of_range((sbyte*)(&global::<Module>.??_C@_0BI@CFPLBAOH@invalid?5string?5position?$AA@));
	}

	// Token: 0x060000EE RID: 238 RVA: 0x00002D44 File Offset: 0x00002144
	internal unsafe static global::std._Wrap_alloc<std::allocator<char>\u0020>* {ctor}(global::std._Wrap_alloc<std::allocator<char>\u0020>* A_0)
	{
		global::<Module>.std.allocator<char>.{ctor}(A_0);
		return A_0;
	}

	// Token: 0x060000EF RID: 239 RVA: 0x0000352C File Offset: 0x0000292C
	internal unsafe static global::std._Wrap_alloc<std::allocator<char>\u0020>* {ctor}(global::std._Wrap_alloc<std::allocator<char>\u0020>* A_0, global::std.allocator<char>* _Right)
	{
		global::<Module>.std.allocator<char>.{ctor}(A_0, _Right);
		return A_0;
	}

	// Token: 0x060000F0 RID: 240 RVA: 0x00003544 File Offset: 0x00002944
	internal unsafe static void deallocate(global::std._Wrap_alloc<std::allocator<char>\u0020>* A_0, sbyte* _Ptr, uint _Count)
	{
		global::<Module>.std.allocator<char>.deallocate(A_0, _Ptr, _Count);
	}

	// Token: 0x060000F1 RID: 241 RVA: 0x00003810 File Offset: 0x00002C10
	internal unsafe static global::std.allocator<char>* select_on_container_copy_construction(global::std.allocator<char>* A_0, global::std.allocator<char>* _Al)
	{
		global::<Module>.std.allocator<char>.select_on_container_copy_construction(_Al, A_0);
		return A_0;
	}

	// Token: 0x060000F2 RID: 242 RVA: 0x00002D5C File Offset: 0x0000215C
	internal unsafe static global::std._String_val<std::_Simple_types<char>\u0020>* {ctor}(global::std._String_val<std::_Simple_types<char>\u0020>* A_0)
	{
		*(A_0 + 16) = 0;
		*(A_0 + 20) = 0;
		return A_0;
	}

	// Token: 0x060000F3 RID: 243 RVA: 0x0000355C File Offset: 0x0000295C
	internal unsafe static sbyte* _Myptr(global::std._String_val<std::_Simple_types<char>\u0020>* A_0)
	{
		return (16 > *(A_0 + 20)) ? A_0 : global::<Module>.std.addressof<char>(*A_0);
	}

	// Token: 0x060000F4 RID: 244 RVA: 0x00002D78 File Offset: 0x00002178
	internal unsafe static uint _Unused_capacity(global::std.vector<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>,std::allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>\u0020>\u0020>* A_0)
	{
		return (*(A_0 + 8) - *(A_0 + 4)) / 24;
	}

	// Token: 0x060000F5 RID: 245 RVA: 0x00003A0C File Offset: 0x00002E0C
	internal unsafe static uint max_size(global::std.vector<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>,std::allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>\u0020>\u0020>* A_0)
	{
		global::std._Wrap_alloc<std::allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>\u0020>\u0020> wrap_alloc<std::allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>_u0020>_u0020>_u0020>;
		return global::<Module>.std._Wrap_alloc<std::allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>\u0020>\u0020>.max_size(global::<Module>.std._Vector_alloc<0,std::_Vec_base_types<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>,std::allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>\u0020>\u0020>\u0020>._Getal(A_0, &wrap_alloc<std::allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>_u0020>_u0020>_u0020>));
	}

	// Token: 0x060000F6 RID: 246 RVA: 0x00003A28 File Offset: 0x00002E28
	internal unsafe static uint _Grow_to(global::std.vector<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>,std::allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>\u0020>\u0020>* A_0, uint _Count)
	{
		uint num = global::<Module>.std.vector<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>,std::allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>\u0020>\u0020>.capacity(A_0);
		uint num2;
		if (global::<Module>.std.vector<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>,std::allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>\u0020>\u0020>.max_size(A_0) - num / 2U < num)
		{
			num2 = 0U;
		}
		else
		{
			uint num3 = num;
			num2 = num3 + num3 / 2U;
		}
		num = num2;
		if (num < _Count)
		{
			num = _Count;
		}
		return num;
	}

	// Token: 0x060000F7 RID: 247 RVA: 0x0000426C File Offset: 0x0000366C
	internal unsafe static void _Reallocate(global::std.vector<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>,std::allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>\u0020>\u0020>* A_0, uint _Count)
	{
		int num = (int)stackalloc byte[global::<Module>.__CxxQueryExceptionSize() * 1];
		global::std._Wrap_alloc<std::allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>\u0020>\u0020> wrap_alloc<std::allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>_u0020>_u0020>_u0020>;
		global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* ptr = global::<Module>.std._Wrap_alloc<std::allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>\u0020>\u0020>.allocate(global::<Module>.std._Vector_alloc<0,std::_Vec_base_types<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>,std::allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>\u0020>\u0020>\u0020>._Getal(A_0, &wrap_alloc<std::allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>_u0020>_u0020>_u0020>), _Count);
		uint exceptionCode;
		try
		{
			global::<Module>.std.vector<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>,std::allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>\u0020>\u0020>._Umove<class\u0020std::basic_string<char,struct\u0020std::char_traits<char>,class\u0020std::allocator<char>\u0020>\u0020*>(A_0, *A_0, *(A_0 + 4), ptr);
		}
		catch when (delegate
		{
			// Failed to create a 'catch-when' expression
			exceptionCode = (uint)global::System.Runtime.InteropServices.Marshal.GetExceptionCode();
			endfilter(global::<Module>.__CxxExceptionFilter(global::System.Runtime.InteropServices.Marshal.GetExceptionPointers(), null, 0, null) != null);
		})
		{
			uint num2 = 0U;
			int num3 = global::<Module>.__CxxRegisterExceptionObject(global::System.Runtime.InteropServices.Marshal.GetExceptionPointers(), num);
			try
			{
				try
				{
					global::std._Wrap_alloc<std::allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>\u0020>\u0020> wrap_alloc<std::allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>_u0020>_u0020>_u0020>2;
					global::<Module>.std._Wrap_alloc<std::allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>\u0020>\u0020>.deallocate(global::<Module>.std._Vector_alloc<0,std::_Vec_base_types<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>,std::allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>\u0020>\u0020>\u0020>._Getal(A_0, &wrap_alloc<std::allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>_u0020>_u0020>_u0020>2), ptr, _Count);
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
		uint num4 = global::<Module>.std.vector<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>,std::allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>\u0020>\u0020>.size(A_0);
		if (*A_0 != 0)
		{
			global::<Module>.std.vector<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>,std::allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>\u0020>\u0020>._Destroy(A_0, *A_0, *(A_0 + 4));
			global::std._Wrap_alloc<std::allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>\u0020>\u0020> wrap_alloc<std::allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>_u0020>_u0020>_u0020>3;
			global::<Module>.std._Wrap_alloc<std::allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>\u0020>\u0020>.deallocate(global::<Module>.std._Vector_alloc<0,std::_Vec_base_types<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>,std::allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>\u0020>\u0020>\u0020>._Getal(A_0, &wrap_alloc<std::allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>_u0020>_u0020>_u0020>3), *A_0, (uint)((*(A_0 + 8) - *A_0) / 24));
		}
		global::<Module>.std._Container_base0._Orphan_all(A_0);
		*(A_0 + 8) = ptr + _Count * 24U / (uint)sizeof(global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>);
		*(A_0 + 4) = ptr + num4 * 24U / (uint)sizeof(global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>);
		*A_0 = ptr;
	}

	// Token: 0x060000F8 RID: 248 RVA: 0x00002D94 File Offset: 0x00002194
	internal unsafe static void _Xlen(global::std.vector<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>,std::allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>\u0020>\u0020>* A_0)
	{
		global::<Module>.std._Xlength_error((sbyte*)(&global::<Module>.??_C@_0BD@OLBABOEK@vector?$DMT?$DO?5too?5long?$AA@));
	}

	// Token: 0x060000F9 RID: 249 RVA: 0x00002DAC File Offset: 0x000021AC
	internal unsafe static global::std._Wrap_alloc<std::allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>\u0020>\u0020>* {ctor}(global::std._Wrap_alloc<std::allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>\u0020>\u0020>* A_0)
	{
		global::<Module>.std.allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>\u0020>.{ctor}(A_0);
		return A_0;
	}

	// Token: 0x060000FA RID: 250 RVA: 0x00003580 File Offset: 0x00002980
	internal unsafe static void deallocate(global::std._Wrap_alloc<std::allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>\u0020>\u0020>* A_0, global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* _Ptr, uint _Count)
	{
		global::<Module>.std.allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>\u0020>.deallocate(A_0, _Ptr, _Count);
	}

	// Token: 0x060000FB RID: 251 RVA: 0x00002DC4 File Offset: 0x000021C4
	internal unsafe static global::std._Vector_val<std::_Simple_types<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>\u0020>\u0020>* {ctor}(global::std._Vector_val<std::_Simple_types<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>\u0020>\u0020>* A_0)
	{
		*A_0 = 0;
		*(A_0 + 4) = 0;
		*(A_0 + 8) = 0;
		return A_0;
	}

	// Token: 0x060000FC RID: 252 RVA: 0x00003A5C File Offset: 0x00002E5C
	internal unsafe static uint max_size(global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* A_0)
	{
		global::std._Wrap_alloc<std::allocator<char>\u0020> wrap_alloc<std::allocator<char>_u0020>;
		uint num = global::<Module>.std._Wrap_alloc<std::allocator<char>\u0020>.max_size(global::<Module>.std._String_alloc<0,std::_String_base_types<char,std::allocator<char>\u0020>\u0020>._Getal(A_0, &wrap_alloc<std::allocator<char>_u0020>));
		return (num > 1U) ? (num - 1U) : 1U;
	}

	// Token: 0x060000FD RID: 253 RVA: 0x00003A84 File Offset: 0x00002E84
	internal unsafe static void _Copy(global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* A_0, uint _Newsize, uint _Oldlen)
	{
		uint num = global::<Module>.__CxxQueryExceptionSize();
		int num2 = (int)stackalloc byte[num * 2U];
		uint num3 = _Newsize | 15U;
		if (global::<Module>.std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>.max_size(A_0) < num3)
		{
			num3 = _Newsize;
		}
		else if (*(A_0 + 20) / 2 > (int)(num3 / 3U))
		{
			if (*(A_0 + 20) <= global::<Module>.std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>.max_size(A_0) - *(A_0 + 20) / 2)
			{
				num3 = (uint)(*(A_0 + 20) + *(A_0 + 20) / 2);
			}
			else
			{
				num3 = global::<Module>.std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>.max_size(A_0);
			}
		}
		sbyte* first;
		uint exceptionCode;
		try
		{
			int num4 = num2 + (int)num;
			global::std._Wrap_alloc<std::allocator<char>\u0020> wrap_alloc<std::allocator<char>_u0020>;
			first = global::<Module>.std._Wrap_alloc<std::allocator<char>\u0020>.allocate(global::<Module>.std._String_alloc<0,std::_String_base_types<char,std::allocator<char>\u0020>\u0020>._Getal(A_0, &wrap_alloc<std::allocator<char>_u0020>), num3 + 1U);
		}
		catch when (delegate
		{
			// Failed to create a 'catch-when' expression
			exceptionCode = (uint)global::System.Runtime.InteropServices.Marshal.GetExceptionCode();
			endfilter(global::<Module>.__CxxExceptionFilter(global::System.Runtime.InteropServices.Marshal.GetExceptionPointers(), null, 0, null) != null);
		})
		{
			uint num5 = 0U;
			int num4;
			int num6 = global::<Module>.__CxxRegisterExceptionObject(global::System.Runtime.InteropServices.Marshal.GetExceptionPointers(), num4);
			try
			{
				try
				{
					num3 = _Newsize;
					uint exceptionCode2;
					try
					{
						global::std._Wrap_alloc<std::allocator<char>\u0020> wrap_alloc<std::allocator<char>_u0020>2;
						first = global::<Module>.std._Wrap_alloc<std::allocator<char>\u0020>.allocate(global::<Module>.std._String_alloc<0,std::_String_base_types<char,std::allocator<char>\u0020>\u0020>._Getal(A_0, &wrap_alloc<std::allocator<char>_u0020>2), num3 + 1U);
					}
					catch when (delegate
					{
						// Failed to create a 'catch-when' expression
						exceptionCode2 = (uint)global::System.Runtime.InteropServices.Marshal.GetExceptionCode();
						endfilter(global::<Module>.__CxxExceptionFilter(global::System.Runtime.InteropServices.Marshal.GetExceptionPointers(), null, 0, null) != null);
					})
					{
						uint num7 = 0U;
						int num8 = global::<Module>.__CxxRegisterExceptionObject(global::System.Runtime.InteropServices.Marshal.GetExceptionPointers(), num2);
						try
						{
							try
							{
								global::<Module>.std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>._Tidy(A_0, true, 0U);
								global::<Module>._CxxThrowException(null, null);
							}
							catch when (delegate
							{
								// Failed to create a 'catch-when' expression
								num7 = global::<Module>.__CxxDetectRethrow(global::System.Runtime.InteropServices.Marshal.GetExceptionPointers());
								endfilter(num7 != 0U);
							})
							{
							}
							if (num7 != 0U)
							{
								throw;
							}
						}
						finally
						{
							global::<Module>.__CxxUnregisterExceptionObject(num2, (int)num7);
						}
					}
					goto IL_137;
				}
				catch when (delegate
				{
					// Failed to create a 'catch-when' expression
					num5 = global::<Module>.__CxxDetectRethrow(global::System.Runtime.InteropServices.Marshal.GetExceptionPointers());
					endfilter(num5 != 0U);
				})
				{
				}
				if (num5 != 0U)
				{
					throw;
				}
			}
			finally
			{
				global::<Module>.__CxxUnregisterExceptionObject(num4, (int)num5);
			}
		}
		IL_137:
		if (0U < _Oldlen)
		{
			global::<Module>.std.char_traits<char>.copy(first, global::<Module>.std._String_val<std::_Simple_types<char>\u0020>._Myptr(A_0), _Oldlen);
		}
		global::<Module>.std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>._Tidy(A_0, true, 0U);
		global::std._Wrap_alloc<std::allocator<char>\u0020> wrap_alloc<std::allocator<char>_u0020>3;
		global::<Module>.std._Wrap_alloc<std::allocator<char>\u0020>.construct<char\u0020*,char\u0020*\u0020&>(global::<Module>.std._String_alloc<0,std::_String_base_types<char,std::allocator<char>\u0020>\u0020>._Getal(A_0, &wrap_alloc<std::allocator<char>_u0020>3), A_0, ref first);
		*(A_0 + 20) = (int)num3;
		global::<Module>.std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>._Eos(A_0, _Oldlen);
	}

	// Token: 0x060000FE RID: 254 RVA: 0x00003598 File Offset: 0x00002998
	internal unsafe static global::std.allocator<char>* select_on_container_copy_construction(global::std.allocator<char>* A_0, global::std.allocator<char>* A_1)
	{
		global::<Module>.std.allocator<char>.{ctor}(A_1, A_0);
		return A_1;
	}

	// Token: 0x060000FF RID: 255 RVA: 0x00002DE0 File Offset: 0x000021E0
	internal unsafe static global::std.allocator<char>* {ctor}(global::std.allocator<char>* A_0, global::std.allocator<char>* A_0)
	{
		return A_0;
	}

	// Token: 0x06000100 RID: 256 RVA: 0x00002DF4 File Offset: 0x000021F4
	internal unsafe static void deallocate(global::std.allocator<char>* A_0, sbyte* _Ptr, uint __unnamed001)
	{
		global::<Module>.delete((void*)_Ptr);
	}

	// Token: 0x06000101 RID: 257 RVA: 0x00002E08 File Offset: 0x00002208
	internal unsafe static uint capacity(global::std.vector<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>,std::allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>\u0020>\u0020>* A_0)
	{
		return (*(A_0 + 8) - *A_0) / 24;
	}

	// Token: 0x06000102 RID: 258 RVA: 0x00002E24 File Offset: 0x00002224
	internal unsafe static void deallocate(global::std.allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>\u0020>* A_0, global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* _Ptr, uint __unnamed001)
	{
		global::<Module>.delete((void*)_Ptr);
	}

	// Token: 0x06000103 RID: 259 RVA: 0x00003828 File Offset: 0x00002C28
	internal unsafe static global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* allocate(global::std._Wrap_alloc<std::allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>\u0020>\u0020>* A_0, uint _Count)
	{
		return global::<Module>.std.allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>\u0020>.allocate(A_0, _Count);
	}

	// Token: 0x06000104 RID: 260 RVA: 0x00003840 File Offset: 0x00002C40
	internal unsafe static uint max_size(global::std._Wrap_alloc<std::allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>\u0020>\u0020>* A_0)
	{
		return global::<Module>.std.allocator_traits<std::allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>\u0020>\u0020>.max_size(A_0);
	}

	// Token: 0x06000105 RID: 261 RVA: 0x00002E38 File Offset: 0x00002238
	internal unsafe static global::std.allocator<unsigned\u0020short>* {ctor}(global::std.allocator<unsigned\u0020short>* A_0, global::std.allocator<unsigned\u0020short>* A_0)
	{
		return A_0;
	}

	// Token: 0x06000106 RID: 262 RVA: 0x00003858 File Offset: 0x00002C58
	internal unsafe static sbyte* allocate(global::std._Wrap_alloc<std::allocator<char>\u0020>* A_0, uint _Count)
	{
		return global::<Module>.std.allocator<char>.allocate(A_0, _Count);
	}

	// Token: 0x06000107 RID: 263 RVA: 0x00003870 File Offset: 0x00002C70
	internal unsafe static uint max_size(global::std._Wrap_alloc<std::allocator<char>\u0020>* A_0)
	{
		return global::<Module>.std.allocator_traits<std::allocator<char>\u0020>.max_size(A_0);
	}

	// Token: 0x06000108 RID: 264 RVA: 0x000035B0 File Offset: 0x000029B0
	internal unsafe static global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* allocate(global::std.allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>\u0020>* A_0, uint _Count)
	{
		return global::<Module>.std._Allocate<class\u0020std::basic_string<char,struct\u0020std::char_traits<char>,class\u0020std::allocator<char>\u0020>\u0020>(_Count, null);
	}

	// Token: 0x06000109 RID: 265 RVA: 0x000035C8 File Offset: 0x000029C8
	internal unsafe static uint max_size(global::std.allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>\u0020>* _Al)
	{
		return global::<Module>.std.allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>\u0020>.max_size(_Al);
	}

	// Token: 0x0600010A RID: 266 RVA: 0x000035E0 File Offset: 0x000029E0
	internal unsafe static sbyte* allocate(global::std.allocator<char>* A_0, uint _Count)
	{
		return global::<Module>.std._Allocate<char>(_Count, null);
	}

	// Token: 0x0600010B RID: 267 RVA: 0x000035F8 File Offset: 0x000029F8
	internal unsafe static uint max_size(global::std.allocator<char>* _Al)
	{
		return global::<Module>.std.allocator<char>.max_size(_Al);
	}

	// Token: 0x0600010C RID: 268 RVA: 0x00002E4C File Offset: 0x0000224C
	internal unsafe static uint max_size(global::std.allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>\u0020>* A_0)
	{
		return 178956970;
	}

	// Token: 0x0600010D RID: 269 RVA: 0x00002E60 File Offset: 0x00002260
	internal unsafe static uint max_size(global::std.allocator<char>* A_0)
	{
		return -1;
	}

	// Token: 0x0600010E RID: 270 RVA: 0x00004930 File Offset: 0x00003D30
	internal unsafe static int AtlAdd<unsigned\u0020long>(uint* ptResult, uint tLeft, uint tRight)
	{
		int result;
		if (-1 - tLeft < tRight)
		{
			result = global::<Module>.HRESULT_FROM_WIN32(534);
		}
		else
		{
			*(int*)ptResult = tLeft + tRight;
			result = 0;
		}
		return result;
	}

	// Token: 0x0600010F RID: 271 RVA: 0x00002E70 File Offset: 0x00002270
	internal unsafe static global::ATL.CTraceCategoryEx<524288,0>* {ctor}(global::ATL.CTraceCategoryEx<524288,0>* A_0, ushort* pszCategoryName)
	{
		return A_0;
	}

	// Token: 0x06000110 RID: 272 RVA: 0x00002E80 File Offset: 0x00002280
	internal unsafe static global::ATL.CTraceCategoryEx<1,0>* {ctor}(global::ATL.CTraceCategoryEx<1,0>* A_0, ushort* pszCategoryName)
	{
		return A_0;
	}

	// Token: 0x06000111 RID: 273 RVA: 0x00002E90 File Offset: 0x00002290
	internal unsafe static global::ATL.CTraceCategoryEx<2,0>* {ctor}(global::ATL.CTraceCategoryEx<2,0>* A_0, ushort* pszCategoryName)
	{
		return A_0;
	}

	// Token: 0x06000112 RID: 274 RVA: 0x00002EA0 File Offset: 0x000022A0
	internal unsafe static global::ATL.CTraceCategoryEx<4,0>* {ctor}(global::ATL.CTraceCategoryEx<4,0>* A_0, ushort* pszCategoryName)
	{
		return A_0;
	}

	// Token: 0x06000113 RID: 275 RVA: 0x00002EB0 File Offset: 0x000022B0
	internal unsafe static global::ATL.CTraceCategoryEx<8,0>* {ctor}(global::ATL.CTraceCategoryEx<8,0>* A_0, ushort* pszCategoryName)
	{
		return A_0;
	}

	// Token: 0x06000114 RID: 276 RVA: 0x00002EC0 File Offset: 0x000022C0
	internal unsafe static global::ATL.CTraceCategoryEx<16,0>* {ctor}(global::ATL.CTraceCategoryEx<16,0>* A_0, ushort* pszCategoryName)
	{
		return A_0;
	}

	// Token: 0x06000115 RID: 277 RVA: 0x00002ED0 File Offset: 0x000022D0
	internal unsafe static global::ATL.CTraceCategoryEx<32,0>* {ctor}(global::ATL.CTraceCategoryEx<32,0>* A_0, ushort* pszCategoryName)
	{
		return A_0;
	}

	// Token: 0x06000116 RID: 278 RVA: 0x00002EE0 File Offset: 0x000022E0
	internal unsafe static global::ATL.CTraceCategoryEx<64,0>* {ctor}(global::ATL.CTraceCategoryEx<64,0>* A_0, ushort* pszCategoryName)
	{
		return A_0;
	}

	// Token: 0x06000117 RID: 279 RVA: 0x00002EF0 File Offset: 0x000022F0
	internal unsafe static global::ATL.CTraceCategoryEx<128,0>* {ctor}(global::ATL.CTraceCategoryEx<128,0>* A_0, ushort* pszCategoryName)
	{
		return A_0;
	}

	// Token: 0x06000118 RID: 280 RVA: 0x00002F00 File Offset: 0x00002300
	internal unsafe static global::ATL.CTraceCategoryEx<256,0>* {ctor}(global::ATL.CTraceCategoryEx<256,0>* A_0, ushort* pszCategoryName)
	{
		return A_0;
	}

	// Token: 0x06000119 RID: 281 RVA: 0x00002F10 File Offset: 0x00002310
	internal unsafe static global::ATL.CTraceCategoryEx<512,0>* {ctor}(global::ATL.CTraceCategoryEx<512,0>* A_0, ushort* pszCategoryName)
	{
		return A_0;
	}

	// Token: 0x0600011A RID: 282 RVA: 0x00002F20 File Offset: 0x00002320
	internal unsafe static global::ATL.CTraceCategoryEx<1024,0>* {ctor}(global::ATL.CTraceCategoryEx<1024,0>* A_0, ushort* pszCategoryName)
	{
		return A_0;
	}

	// Token: 0x0600011B RID: 283 RVA: 0x00002F30 File Offset: 0x00002330
	internal unsafe static global::ATL.CTraceCategoryEx<2048,0>* {ctor}(global::ATL.CTraceCategoryEx<2048,0>* A_0, ushort* pszCategoryName)
	{
		return A_0;
	}

	// Token: 0x0600011C RID: 284 RVA: 0x00002F40 File Offset: 0x00002340
	internal unsafe static global::ATL.CTraceCategoryEx<4096,0>* {ctor}(global::ATL.CTraceCategoryEx<4096,0>* A_0, ushort* pszCategoryName)
	{
		return A_0;
	}

	// Token: 0x0600011D RID: 285 RVA: 0x00002F50 File Offset: 0x00002350
	internal unsafe static global::ATL.CTraceCategoryEx<8192,0>* {ctor}(global::ATL.CTraceCategoryEx<8192,0>* A_0, ushort* pszCategoryName)
	{
		return A_0;
	}

	// Token: 0x0600011E RID: 286 RVA: 0x00002F60 File Offset: 0x00002360
	internal unsafe static global::ATL.CTraceCategoryEx<16384,0>* {ctor}(global::ATL.CTraceCategoryEx<16384,0>* A_0, ushort* pszCategoryName)
	{
		return A_0;
	}

	// Token: 0x0600011F RID: 287 RVA: 0x00002F70 File Offset: 0x00002370
	internal unsafe static global::ATL.CTraceCategoryEx<32768,0>* {ctor}(global::ATL.CTraceCategoryEx<32768,0>* A_0, ushort* pszCategoryName)
	{
		return A_0;
	}

	// Token: 0x06000120 RID: 288 RVA: 0x00002F80 File Offset: 0x00002380
	internal unsafe static global::ATL.CTraceCategoryEx<65536,0>* {ctor}(global::ATL.CTraceCategoryEx<65536,0>* A_0, ushort* pszCategoryName)
	{
		return A_0;
	}

	// Token: 0x06000121 RID: 289 RVA: 0x00002F90 File Offset: 0x00002390
	internal unsafe static global::ATL.CTraceCategoryEx<131072,0>* {ctor}(global::ATL.CTraceCategoryEx<131072,0>* A_0, ushort* pszCategoryName)
	{
		return A_0;
	}

	// Token: 0x06000122 RID: 290 RVA: 0x00002FA0 File Offset: 0x000023A0
	internal unsafe static global::ATL.CTraceCategoryEx<262144,0>* {ctor}(global::ATL.CTraceCategoryEx<262144,0>* A_0, ushort* pszCategoryName)
	{
		return A_0;
	}

	// Token: 0x06000123 RID: 291 RVA: 0x00002FB0 File Offset: 0x000023B0
	internal unsafe static global::ATL.CTraceCategoryEx<1048576,0>* {ctor}(global::ATL.CTraceCategoryEx<1048576,0>* A_0, ushort* pszCategoryName)
	{
		return A_0;
	}

	// Token: 0x06000124 RID: 292 RVA: 0x00002FC0 File Offset: 0x000023C0
	internal unsafe static global::ATL.CTraceCategoryEx<2097152,0>* {ctor}(global::ATL.CTraceCategoryEx<2097152,0>* A_0, ushort* pszCategoryName)
	{
		return A_0;
	}

	// Token: 0x06000125 RID: 293 RVA: 0x00002FD0 File Offset: 0x000023D0
	internal unsafe static global::ATL.CTraceCategoryEx<4194304,0>* {ctor}(global::ATL.CTraceCategoryEx<4194304,0>* A_0, ushort* pszCategoryName)
	{
		return A_0;
	}

	// Token: 0x06000126 RID: 294 RVA: 0x000047CC File Offset: 0x00003BCC
	internal unsafe static int AtlAdd<unsigned\u0020int>(uint* ptResult, uint tLeft, uint tRight)
	{
		int result;
		if (4294967295U - tLeft < tRight)
		{
			result = global::<Module>.HRESULT_FROM_WIN32(534);
		}
		else
		{
			*ptResult = tLeft + tRight;
			result = 0;
		}
		return result;
	}

	// Token: 0x06000127 RID: 295 RVA: 0x00002FE0 File Offset: 0x000023E0
	internal unsafe static void {dtor}(global::ATL.CSimpleArray<unsigned\u0020short,ATL::CSimpleArrayEqualHelper<unsigned\u0020short>\u0020>* A_0)
	{
		global::<Module>.ATL.CSimpleArray<unsigned\u0020short,ATL::CSimpleArrayEqualHelper<unsigned\u0020short>\u0020>.RemoveAll(A_0);
	}

	// Token: 0x06000128 RID: 296 RVA: 0x000047F4 File Offset: 0x00003BF4
	internal unsafe static int AtlAdd<int>(int* ptResult, int tLeft, int tRight)
	{
		int result;
		if (2147483647 - tLeft < tRight)
		{
			result = global::<Module>.HRESULT_FROM_WIN32(534);
		}
		else
		{
			*ptResult = tLeft + tRight;
			result = 0;
		}
		return result;
	}

	// Token: 0x06000129 RID: 297 RVA: 0x00004820 File Offset: 0x00003C20
	internal static int AtlAlignUp<int>(int n, uint nAlign)
	{
		return n + (nAlign - 1) & ~(nAlign - 1);
	}

	// Token: 0x0600012A RID: 298 RVA: 0x00001674 File Offset: 0x00000A74
	internal static void ??__E?_Generic_object@?$_Error_objects@H@std@@2V_Generic_error_category@2@A@@YMXXZ()
	{
		global::<Module>.std._Generic_error_category.{ctor}(ref global::<Module>.?_Generic_object@?$_Error_objects@H@std@@2V_Generic_error_category@2@A);
		global::<Module>._atexit_m(ldftn(?A0xacbfdcdf.??__F?_Generic_object@?$_Error_objects@H@std@@2V_Generic_error_category@2@A@@YMXXZ));
	}

	// Token: 0x0600012B RID: 299 RVA: 0x00001698 File Offset: 0x00000A98
	internal static void ??__E?_Iostream_object@?$_Error_objects@H@std@@2V_Iostream_error_category@2@A@@YMXXZ()
	{
		global::<Module>.std._Iostream_error_category.{ctor}(ref global::<Module>.?_Iostream_object@?$_Error_objects@H@std@@2V_Iostream_error_category@2@A);
		global::<Module>._atexit_m(ldftn(?A0xacbfdcdf.??__F?_Iostream_object@?$_Error_objects@H@std@@2V_Iostream_error_category@2@A@@YMXXZ));
	}

	// Token: 0x0600012C RID: 300 RVA: 0x000016BC File Offset: 0x00000ABC
	internal static void ??__E?_System_object@?$_Error_objects@H@std@@2V_System_error_category@2@A@@YMXXZ()
	{
		global::<Module>.std._System_error_category.{ctor}(ref global::<Module>.?_System_object@?$_Error_objects@H@std@@2V_System_error_category@2@A);
		global::<Module>._atexit_m(ldftn(?A0xacbfdcdf.??__F?_System_object@?$_Error_objects@H@std@@2V_System_error_category@2@A@@YMXXZ));
	}

	// Token: 0x0600012D RID: 301 RVA: 0x00002FF4 File Offset: 0x000023F4
	internal unsafe static global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* forward<class\u0020std::basic_string<char,struct\u0020std::char_traits<char>,class\u0020std::allocator<char>\u0020>\u0020>(global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* _Arg)
	{
		return _Arg;
	}

	// Token: 0x0600012E RID: 302 RVA: 0x00003004 File Offset: 0x00002404
	internal unsafe static global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* addressof<class\u0020std::basic_string<char,struct\u0020std::char_traits<char>,class\u0020std::allocator<char>\u0020>\u0020>(global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* _Val)
	{
		return _Val;
	}

	// Token: 0x0600012F RID: 303 RVA: 0x00003FE4 File Offset: 0x000033E4
	internal unsafe static void construct<class\u0020std::basic_string<char,struct\u0020std::char_traits<char>,class\u0020std::allocator<char>\u0020>,class\u0020std::basic_string<char,struct\u0020std::char_traits<char>,class\u0020std::allocator<char>\u0020>\u0020>(global::std._Wrap_alloc<std::allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>\u0020>\u0020>* A_0, global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* _Ptr, global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* <_Args_0>)
	{
		global::<Module>.std.allocator_traits<std::allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>\u0020>\u0020>.construct<class\u0020std::basic_string<char,struct\u0020std::char_traits<char>,class\u0020std::allocator<char>\u0020>,class\u0020std::basic_string<char,struct\u0020std::char_traits<char>,class\u0020std::allocator<char>\u0020>\u0020>(A_0, _Ptr, global::<Module>.std.forward<class\u0020std::basic_string<char,struct\u0020std::char_traits<char>,class\u0020std::allocator<char>\u0020>\u0020>(<_Args_0>));
	}

	// Token: 0x06000130 RID: 304 RVA: 0x00003888 File Offset: 0x00002C88
	internal unsafe static void construct<char\u0020*,char\u0020*\u0020&>(global::std._Wrap_alloc<std::allocator<char>\u0020>* A_0, sbyte** _Ptr, sbyte** <_Args_0>)
	{
		global::<Module>.std.allocator_traits<std::allocator<char>\u0020>.construct<char\u0020*,char\u0020*\u0020&>(A_0, _Ptr, global::<Module>.std.forward<char\u0020*\u0020&>(<_Args_0>));
	}

	// Token: 0x06000131 RID: 305 RVA: 0x000038A4 File Offset: 0x00002CA4
	internal unsafe static void destroy<char\u0020*>(global::std._Wrap_alloc<std::allocator<char>\u0020>* A_0, sbyte** _Ptr)
	{
		global::<Module>.std.allocator_traits<std::allocator<char>\u0020>.destroy<char\u0020*>(A_0, _Ptr);
	}

	// Token: 0x06000132 RID: 306 RVA: 0x00003014 File Offset: 0x00002414
	internal unsafe static sbyte* addressof<char>(sbyte* _Val)
	{
		return _Val;
	}

	// Token: 0x06000133 RID: 307 RVA: 0x00004150 File Offset: 0x00003550
	internal unsafe static void _Destroy_range<struct\u0020std::_Wrap_alloc<class\u0020std::allocator<class\u0020std::basic_string<char,struct\u0020std::char_traits<char>,class\u0020std::allocator<char>\u0020>\u0020>\u0020>\u0020>(global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* _First, global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* _Last, global::std._Wrap_alloc<std::allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>\u0020>\u0020>* _Al)
	{
		global::std._Nonscalar_ptr_iterator_tag _unnamed = global::<Module>.std._Ptr_cat<class\u0020std::basic_string<char,struct\u0020std::char_traits<char>,class\u0020std::allocator<char>\u0020>,class\u0020std::basic_string<char,struct\u0020std::char_traits<char>,class\u0020std::allocator<char>\u0020>\u0020>(_First, _Last);
		global::<Module>.std._Destroy_range<struct\u0020std::_Wrap_alloc<class\u0020std::allocator<class\u0020std::basic_string<char,struct\u0020std::char_traits<char>,class\u0020std::allocator<char>\u0020>\u0020>\u0020>\u0020>(_First, _Last, _Al, _unnamed);
	}

	// Token: 0x06000134 RID: 308 RVA: 0x0000420C File Offset: 0x0000360C
	internal unsafe static global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* _Umove<class\u0020std::basic_string<char,struct\u0020std::char_traits<char>,class\u0020std::allocator<char>\u0020>\u0020*>(global::std.vector<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>,std::allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>\u0020>\u0020>* A_0, global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* _First, global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* _Last, global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* _Ptr)
	{
		global::std._Wrap_alloc<std::allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>\u0020>\u0020> wrap_alloc<std::allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>_u0020>_u0020>_u0020>;
		global::<Module>.std._Vector_alloc<0,std::_Vec_base_types<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>,std::allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>\u0020>\u0020>\u0020>._Getal(A_0, &wrap_alloc<std::allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>_u0020>_u0020>_u0020>);
		return global::<Module>.std._Uninitialized_move<class\u0020std::basic_string<char,struct\u0020std::char_traits<char>,class\u0020std::allocator<char>\u0020>\u0020*,class\u0020std::basic_string<char,struct\u0020std::char_traits<char>,class\u0020std::allocator<char>\u0020>\u0020*,struct\u0020std::_Wrap_alloc<class\u0020std::allocator<class\u0020std::basic_string<char,struct\u0020std::char_traits<char>,class\u0020std::allocator<char>\u0020>\u0020>\u0020>\u0020>(_First, _Last, _Ptr, ref wrap_alloc<std::allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>_u0020>_u0020>_u0020>);
	}

	// Token: 0x06000135 RID: 309 RVA: 0x00003024 File Offset: 0x00002424
	internal unsafe static global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* _Allocate<class\u0020std::basic_string<char,struct\u0020std::char_traits<char>,class\u0020std::allocator<char>\u0020>\u0020>(uint _Count, global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* __unnamed001)
	{
		void* ptr = null;
		if (_Count != 0U)
		{
			if (178956970U >= _Count)
			{
				ptr = global::<Module>.@new(_Count * 24U);
				if (ptr != null)
				{
					return ptr;
				}
			}
			global::<Module>.std._Xbad_alloc();
		}
		return ptr;
	}

	// Token: 0x06000136 RID: 310 RVA: 0x00003058 File Offset: 0x00002458
	internal unsafe static sbyte* _Allocate<char>(uint _Count, sbyte* __unnamed001)
	{
		void* ptr = null;
		if (_Count != 0U)
		{
			if (4294967295U >= _Count)
			{
				ptr = global::<Module>.@new(_Count);
				if (ptr != null)
				{
					return ptr;
				}
			}
			global::<Module>.std._Xbad_alloc();
		}
		return ptr;
	}

	// Token: 0x06000137 RID: 311 RVA: 0x000086B4 File Offset: 0x00007AB4
	internal static void ??__F?_System_object@?$_Error_objects@H@std@@2V_System_error_category@2@A@@YMXXZ()
	{
		global::<Module>.std._System_error_category.{dtor}(ref global::<Module>.?_System_object@?$_Error_objects@H@std@@2V_System_error_category@2@A);
	}

	// Token: 0x06000138 RID: 312 RVA: 0x000086D4 File Offset: 0x00007AD4
	internal static void ??__F?_Iostream_object@?$_Error_objects@H@std@@2V_Iostream_error_category@2@A@@YMXXZ()
	{
		global::<Module>.std._Iostream_error_category.{dtor}(ref global::<Module>.?_Iostream_object@?$_Error_objects@H@std@@2V_Iostream_error_category@2@A);
	}

	// Token: 0x06000139 RID: 313 RVA: 0x000086F4 File Offset: 0x00007AF4
	internal static void ??__F?_Generic_object@?$_Error_objects@H@std@@2V_Generic_error_category@2@A@@YMXXZ()
	{
		global::<Module>.std._Generic_error_category.{dtor}(ref global::<Module>.?_Generic_object@?$_Error_objects@H@std@@2V_Generic_error_category@2@A);
	}

	// Token: 0x0600013A RID: 314 RVA: 0x00003F6C File Offset: 0x0000336C
	internal unsafe static void construct<class\u0020std::basic_string<char,struct\u0020std::char_traits<char>,class\u0020std::allocator<char>\u0020>,class\u0020std::basic_string<char,struct\u0020std::char_traits<char>,class\u0020std::allocator<char>\u0020>\u0020>(global::std.allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>\u0020>* _Al, global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* _Ptr, global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* <_Args_0>)
	{
		global::<Module>.std.allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>\u0020>.construct<class\u0020std::basic_string<char,struct\u0020std::char_traits<char>,class\u0020std::allocator<char>\u0020>,class\u0020std::basic_string<char,struct\u0020std::char_traits<char>,class\u0020std::allocator<char>\u0020>\u0020>(_Al, _Ptr, global::<Module>.std.forward<class\u0020std::basic_string<char,struct\u0020std::char_traits<char>,class\u0020std::allocator<char>\u0020>\u0020>(<_Args_0>));
	}

	// Token: 0x0600013B RID: 315 RVA: 0x00003084 File Offset: 0x00002484
	internal unsafe static sbyte** forward<char\u0020*\u0020&>(sbyte** _Arg)
	{
		return _Arg;
	}

	// Token: 0x0600013C RID: 316 RVA: 0x00003610 File Offset: 0x00002A10
	internal unsafe static void construct<char\u0020*,char\u0020*\u0020&>(global::std.allocator<char>* _Al, sbyte** _Ptr, sbyte** <_Args_0>)
	{
		global::<Module>.std.allocator<char>.construct<char\u0020*,char\u0020*\u0020&>(_Al, _Ptr, global::<Module>.std.forward<char\u0020*\u0020&>(<_Args_0>));
	}

	// Token: 0x0600013D RID: 317 RVA: 0x0000362C File Offset: 0x00002A2C
	internal unsafe static void destroy<char\u0020*>(global::std.allocator<char>* _Al, sbyte** _Ptr)
	{
		global::<Module>.std.allocator<char>.destroy<char\u0020*>(_Al, _Ptr);
	}

	// Token: 0x0600013E RID: 318 RVA: 0x00003094 File Offset: 0x00002494
	internal unsafe static global::std._Nonscalar_ptr_iterator_tag _Ptr_cat<class\u0020std::basic_string<char,struct\u0020std::char_traits<char>,class\u0020std::allocator<char>\u0020>,class\u0020std::basic_string<char,struct\u0020std::char_traits<char>,class\u0020std::allocator<char>\u0020>\u0020>(global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* A_0, global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* A_1)
	{
		global::std._Nonscalar_ptr_iterator_tag result;
		return result;
	}

	// Token: 0x0600013F RID: 319 RVA: 0x00004104 File Offset: 0x00003504
	internal unsafe static void _Destroy_range<struct\u0020std::_Wrap_alloc<class\u0020std::allocator<class\u0020std::basic_string<char,struct\u0020std::char_traits<char>,class\u0020std::allocator<char>\u0020>\u0020>\u0020>\u0020>(global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* _First, global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* _Last, global::std._Wrap_alloc<std::allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>\u0020>\u0020>* _Al, global::std._Nonscalar_ptr_iterator_tag __unnamed003)
	{
		while (_First != _Last)
		{
			global::<Module>.std._Wrap_alloc<std::allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>\u0020>\u0020>.destroy<class\u0020std::basic_string<char,struct\u0020std::char_traits<char>,class\u0020std::allocator<char>\u0020>\u0020>(_Al, _First);
			_First += 24 / sizeof(global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>);
		}
	}

	// Token: 0x06000140 RID: 320 RVA: 0x00004170 File Offset: 0x00003570
	internal unsafe static global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* _Uninitialized_move<class\u0020std::basic_string<char,struct\u0020std::char_traits<char>,class\u0020std::allocator<char>\u0020>\u0020*,class\u0020std::basic_string<char,struct\u0020std::char_traits<char>,class\u0020std::allocator<char>\u0020>\u0020*,struct\u0020std::_Wrap_alloc<class\u0020std::allocator<class\u0020std::basic_string<char,struct\u0020std::char_traits<char>,class\u0020std::allocator<char>\u0020>\u0020>\u0020>\u0020>(global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* _First, global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* _Last, global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* _Dest, global::std._Wrap_alloc<std::allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>\u0020>\u0020>* _Al)
	{
		return *global::<Module>.std._Rechecked<class\u0020std::basic_string<char,struct\u0020std::char_traits<char>,class\u0020std::allocator<char>\u0020>\u0020*,class\u0020std::basic_string<char,struct\u0020std::char_traits<char>,class\u0020std::allocator<char>\u0020>\u0020*>(ref _Dest, global::<Module>.std._Uninit_move<class\u0020std::basic_string<char,struct\u0020std::char_traits<char>,class\u0020std::allocator<char>\u0020>\u0020*,class\u0020std::basic_string<char,struct\u0020std::char_traits<char>,class\u0020std::allocator<char>\u0020>\u0020*,struct\u0020std::_Wrap_alloc<class\u0020std::allocator<class\u0020std::basic_string<char,struct\u0020std::char_traits<char>,class\u0020std::allocator<char>\u0020>\u0020>\u0020>\u0020>(global::<Module>.std._Unchecked<class\u0020std::basic_string<char,struct\u0020std::char_traits<char>,class\u0020std::allocator<char>\u0020>\u0020*>(_First), global::<Module>.std._Unchecked<class\u0020std::basic_string<char,struct\u0020std::char_traits<char>,class\u0020std::allocator<char>\u0020>\u0020*>(_Last), global::<Module>.std._Unchecked<class\u0020std::basic_string<char,struct\u0020std::char_traits<char>,class\u0020std::allocator<char>\u0020>\u0020*>(_Dest), _Al));
	}

	// Token: 0x06000141 RID: 321 RVA: 0x00003EA8 File Offset: 0x000032A8
	internal unsafe static void construct<class\u0020std::basic_string<char,struct\u0020std::char_traits<char>,class\u0020std::allocator<char>\u0020>,class\u0020std::basic_string<char,struct\u0020std::char_traits<char>,class\u0020std::allocator<char>\u0020>\u0020>(global::std.allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>\u0020>* A_0, global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* _Ptr, global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* <_Args_0>)
	{
		global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* ptr = global::<Module>.@new(24U, (void*)_Ptr);
		try
		{
			global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* ptr2 = (ptr == null) ? 0 : global::<Module>.std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>.{ctor}(ptr, global::<Module>.std.forward<class\u0020std::basic_string<char,struct\u0020std::char_traits<char>,class\u0020std::allocator<char>\u0020>\u0020>(<_Args_0>));
		}
		catch
		{
			global::<Module>.delete((void*)ptr, (void*)_Ptr);
			throw;
		}
	}

	// Token: 0x06000142 RID: 322 RVA: 0x000030A4 File Offset: 0x000024A4
	internal unsafe static void construct<char\u0020*,char\u0020*\u0020&>(global::std.allocator<char>* A_0, sbyte** _Ptr, sbyte** <_Args_0>)
	{
		sbyte** ptr = global::<Module>.@new(4U, (void*)_Ptr);
		try
		{
			if (ptr != null)
			{
				*(int*)ptr = *global::<Module>.std.forward<char\u0020*\u0020&>(<_Args_0>);
			}
		}
		catch
		{
			global::<Module>.delete((void*)ptr, (void*)_Ptr);
			throw;
		}
	}

	// Token: 0x06000143 RID: 323 RVA: 0x000030F0 File Offset: 0x000024F0
	internal unsafe static void destroy<char\u0020*>(global::std.allocator<char>* A_0, sbyte** _Ptr)
	{
	}

	// Token: 0x06000144 RID: 324 RVA: 0x00004000 File Offset: 0x00003400
	internal unsafe static void destroy<class\u0020std::basic_string<char,struct\u0020std::char_traits<char>,class\u0020std::allocator<char>\u0020>\u0020>(global::std._Wrap_alloc<std::allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>\u0020>\u0020>* A_0, global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* _Ptr)
	{
		global::<Module>.std.allocator_traits<std::allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>\u0020>\u0020>.destroy<class\u0020std::basic_string<char,struct\u0020std::char_traits<char>,class\u0020std::allocator<char>\u0020>\u0020>(A_0, _Ptr);
	}

	// Token: 0x06000145 RID: 325 RVA: 0x00003100 File Offset: 0x00002500
	internal unsafe static global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* _Unchecked<class\u0020std::basic_string<char,struct\u0020std::char_traits<char>,class\u0020std::allocator<char>\u0020>\u0020*>(global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* _Src)
	{
		return _Src;
	}

	// Token: 0x06000146 RID: 326 RVA: 0x00004128 File Offset: 0x00003528
	internal unsafe static global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* _Uninit_move<class\u0020std::basic_string<char,struct\u0020std::char_traits<char>,class\u0020std::allocator<char>\u0020>\u0020*,class\u0020std::basic_string<char,struct\u0020std::char_traits<char>,class\u0020std::allocator<char>\u0020>\u0020*,struct\u0020std::_Wrap_alloc<class\u0020std::allocator<class\u0020std::basic_string<char,struct\u0020std::char_traits<char>,class\u0020std::allocator<char>\u0020>\u0020>\u0020>\u0020>(global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* _First, global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* _Last, global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* _Dest, global::std._Wrap_alloc<std::allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>\u0020>\u0020>* _Al)
	{
		global::std._Nonscalar_ptr_iterator_tag _unnamed = global::<Module>.std._Ptr_cat<class\u0020std::basic_string<char,struct\u0020std::char_traits<char>,class\u0020std::allocator<char>\u0020>,class\u0020std::basic_string<char,struct\u0020std::char_traits<char>,class\u0020std::allocator<char>\u0020>\u0020>(_First, _Dest);
		return global::<Module>.std._Uninit_move<class\u0020std::basic_string<char,struct\u0020std::char_traits<char>,class\u0020std::allocator<char>\u0020>\u0020*,class\u0020std::basic_string<char,struct\u0020std::char_traits<char>,class\u0020std::allocator<char>\u0020>\u0020*,class\u0020std::allocator<class\u0020std::basic_string<char,struct\u0020std::char_traits<char>,class\u0020std::allocator<char>\u0020>\u0020>,class\u0020std::basic_string<char,struct\u0020std::char_traits<char>,class\u0020std::allocator<char>\u0020>\u0020>(_First, _Last, _Dest, _Al, global::<Module>.std._Val_type<class\u0020std::basic_string<char,struct\u0020std::char_traits<char>,class\u0020std::allocator<char>\u0020>\u0020*>(_First), _unnamed);
	}

	// Token: 0x06000147 RID: 327 RVA: 0x00003110 File Offset: 0x00002510
	internal unsafe static global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>** _Rechecked<class\u0020std::basic_string<char,struct\u0020std::char_traits<char>,class\u0020std::allocator<char>\u0020>\u0020*,class\u0020std::basic_string<char,struct\u0020std::char_traits<char>,class\u0020std::allocator<char>\u0020>\u0020*>(global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>** _Dest, global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* _Src)
	{
		*_Dest = _Src;
		return _Dest;
	}

	// Token: 0x06000148 RID: 328 RVA: 0x00003F88 File Offset: 0x00003388
	internal unsafe static void destroy<class\u0020std::basic_string<char,struct\u0020std::char_traits<char>,class\u0020std::allocator<char>\u0020>\u0020>(global::std.allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>\u0020>* _Al, global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* _Ptr)
	{
		global::<Module>.std.allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>\u0020>.destroy<class\u0020std::basic_string<char,struct\u0020std::char_traits<char>,class\u0020std::allocator<char>\u0020>\u0020>(_Al, _Ptr);
	}

	// Token: 0x06000149 RID: 329 RVA: 0x00003124 File Offset: 0x00002524
	internal unsafe static global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* _Val_type<class\u0020std::basic_string<char,struct\u0020std::char_traits<char>,class\u0020std::allocator<char>\u0020>\u0020*>(global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* A_0)
	{
		return 0;
	}

	// Token: 0x0600014A RID: 330 RVA: 0x00004014 File Offset: 0x00003414
	internal unsafe static global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* _Uninit_move<class\u0020std::basic_string<char,struct\u0020std::char_traits<char>,class\u0020std::allocator<char>\u0020>\u0020*,class\u0020std::basic_string<char,struct\u0020std::char_traits<char>,class\u0020std::allocator<char>\u0020>\u0020*,class\u0020std::allocator<class\u0020std::basic_string<char,struct\u0020std::char_traits<char>,class\u0020std::allocator<char>\u0020>\u0020>,class\u0020std::basic_string<char,struct\u0020std::char_traits<char>,class\u0020std::allocator<char>\u0020>\u0020>(global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* _First, global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* _Last, global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* _Dest, global::std._Wrap_alloc<std::allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>\u0020>\u0020>* _Al, global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* __unnamed004, global::std._Nonscalar_ptr_iterator_tag __unnamed005)
	{
		int num = (int)stackalloc byte[global::<Module>.__CxxQueryExceptionSize() * 1];
		global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* ptr = _Dest;
		uint exceptionCode;
		try
		{
			while (_First != _Last)
			{
				global::<Module>.std._Wrap_alloc<std::allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>\u0020>\u0020>.construct<class\u0020std::basic_string<char,struct\u0020std::char_traits<char>,class\u0020std::allocator<char>\u0020>,class\u0020std::basic_string<char,struct\u0020std::char_traits<char>,class\u0020std::allocator<char>\u0020>\u0020>(_Al, _Dest, _First);
				_Dest += 24 / sizeof(global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>);
				_First += 24 / sizeof(global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>);
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
			int num3 = global::<Module>.__CxxRegisterExceptionObject(global::System.Runtime.InteropServices.Marshal.GetExceptionPointers(), num);
			try
			{
				try
				{
					while (ptr != _Dest)
					{
						global::<Module>.std._Wrap_alloc<std::allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>\u0020>\u0020>.destroy<class\u0020std::basic_string<char,struct\u0020std::char_traits<char>,class\u0020std::allocator<char>\u0020>\u0020>(_Al, ptr);
						ptr += 24 / sizeof(global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>);
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

	// Token: 0x0600014B RID: 331 RVA: 0x00003EF8 File Offset: 0x000032F8
	internal unsafe static void destroy<class\u0020std::basic_string<char,struct\u0020std::char_traits<char>,class\u0020std::allocator<char>\u0020>\u0020>(global::std.allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>\u0020>* A_0, global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* _Ptr)
	{
		global::<Module>.std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>.__delDtor(_Ptr, 0U);
	}

	// Token: 0x0600014C RID: 332 RVA: 0x00003D78 File Offset: 0x00003178
	internal unsafe static void* __delDtor(global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* A_0, uint A_0)
	{
		global::<Module>.std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>.{dtor}(A_0);
		if ((A_0 & 1U) != 0U)
		{
			global::<Module>.delete(A_0);
		}
		return A_0;
	}

	// Token: 0x0600014D RID: 333 RVA: 0x00005644 File Offset: 0x00004A44
	internal static ref char PtrToStringChars(string s)
	{
		ref byte ptr = s;
		if (ref ptr != null)
		{
			uint offsetToStringData = (uint)global::System.Runtime.CompilerServices.RuntimeHelpers.OffsetToStringData;
			ptr = ref ptr + offsetToStringData;
		}
		return ref ptr;
	}

	// Token: 0x0600014E RID: 334 RVA: 0x0000185C File Offset: 0x00000C5C
	internal static void ??__E?A0xaef22b49@piecewise_construct@std@@YMXXZ()
	{
		global::std.piecewise_construct_t piecewise_construct_t;
		initblk(ref piecewise_construct_t, 0, 1);
	}

	// Token: 0x0600014F RID: 335 RVA: 0x00001870 File Offset: 0x00000C70
	internal static void ??__E?A0xaef22b49@allocator_arg@std@@YMXXZ()
	{
		global::std.allocator_arg_t allocator_arg_t;
		initblk(ref allocator_arg_t, 0, 1);
	}

	// Token: 0x06000150 RID: 336 RVA: 0x00001884 File Offset: 0x00000C84
	internal unsafe static void ??__EatlTraceGeneral@ATL@@YMXXZ()
	{
		global::<Module>.ATL.CTraceCategoryEx<1,0>.{ctor}(ref global::<Module>.ATL.atlTraceGeneral, (ushort*)(&global::<Module>.?A0xaef22b49.unnamed-global-20));
	}

	// Token: 0x06000151 RID: 337 RVA: 0x000018A4 File Offset: 0x00000CA4
	internal unsafe static void ??__EatlTraceCOM@ATL@@YMXXZ()
	{
		global::<Module>.ATL.CTraceCategoryEx<2,0>.{ctor}(ref global::<Module>.ATL.atlTraceCOM, (ushort*)(&global::<Module>.?A0xaef22b49.unnamed-global-21));
	}

	// Token: 0x06000152 RID: 338 RVA: 0x000018C4 File Offset: 0x00000CC4
	internal unsafe static void ??__EatlTraceQI@ATL@@YMXXZ()
	{
		global::<Module>.ATL.CTraceCategoryEx<4,0>.{ctor}(ref global::<Module>.ATL.atlTraceQI, (ushort*)(&global::<Module>.?A0xaef22b49.unnamed-global-22));
	}

	// Token: 0x06000153 RID: 339 RVA: 0x000018E4 File Offset: 0x00000CE4
	internal unsafe static void ??__EatlTraceRegistrar@ATL@@YMXXZ()
	{
		global::<Module>.ATL.CTraceCategoryEx<8,0>.{ctor}(ref global::<Module>.ATL.atlTraceRegistrar, (ushort*)(&global::<Module>.?A0xaef22b49.unnamed-global-23));
	}

	// Token: 0x06000154 RID: 340 RVA: 0x00001904 File Offset: 0x00000D04
	internal unsafe static void ??__EatlTraceRefcount@ATL@@YMXXZ()
	{
		global::<Module>.ATL.CTraceCategoryEx<16,0>.{ctor}(ref global::<Module>.ATL.atlTraceRefcount, (ushort*)(&global::<Module>.?A0xaef22b49.unnamed-global-24));
	}

	// Token: 0x06000155 RID: 341 RVA: 0x00001924 File Offset: 0x00000D24
	internal unsafe static void ??__EatlTraceWindowing@ATL@@YMXXZ()
	{
		global::<Module>.ATL.CTraceCategoryEx<32,0>.{ctor}(ref global::<Module>.ATL.atlTraceWindowing, (ushort*)(&global::<Module>.?A0xaef22b49.unnamed-global-25));
	}

	// Token: 0x06000156 RID: 342 RVA: 0x00001944 File Offset: 0x00000D44
	internal unsafe static void ??__EatlTraceControls@ATL@@YMXXZ()
	{
		global::<Module>.ATL.CTraceCategoryEx<64,0>.{ctor}(ref global::<Module>.ATL.atlTraceControls, (ushort*)(&global::<Module>.?A0xaef22b49.unnamed-global-26));
	}

	// Token: 0x06000157 RID: 343 RVA: 0x00001964 File Offset: 0x00000D64
	internal unsafe static void ??__EatlTraceHosting@ATL@@YMXXZ()
	{
		global::<Module>.ATL.CTraceCategoryEx<128,0>.{ctor}(ref global::<Module>.ATL.atlTraceHosting, (ushort*)(&global::<Module>.?A0xaef22b49.unnamed-global-27));
	}

	// Token: 0x06000158 RID: 344 RVA: 0x00001984 File Offset: 0x00000D84
	internal unsafe static void ??__EatlTraceDBClient@ATL@@YMXXZ()
	{
		global::<Module>.ATL.CTraceCategoryEx<256,0>.{ctor}(ref global::<Module>.ATL.atlTraceDBClient, (ushort*)(&global::<Module>.?A0xaef22b49.unnamed-global-28));
	}

	// Token: 0x06000159 RID: 345 RVA: 0x000019A4 File Offset: 0x00000DA4
	internal unsafe static void ??__EatlTraceDBProvider@ATL@@YMXXZ()
	{
		global::<Module>.ATL.CTraceCategoryEx<512,0>.{ctor}(ref global::<Module>.ATL.atlTraceDBProvider, (ushort*)(&global::<Module>.?A0xaef22b49.unnamed-global-29));
	}

	// Token: 0x0600015A RID: 346 RVA: 0x000019C4 File Offset: 0x00000DC4
	internal unsafe static void ??__EatlTraceSnapin@ATL@@YMXXZ()
	{
		global::<Module>.ATL.CTraceCategoryEx<1024,0>.{ctor}(ref global::<Module>.ATL.atlTraceSnapin, (ushort*)(&global::<Module>.?A0xaef22b49.unnamed-global-30));
	}

	// Token: 0x0600015B RID: 347 RVA: 0x000019E4 File Offset: 0x00000DE4
	internal unsafe static void ??__EatlTraceNotImpl@ATL@@YMXXZ()
	{
		global::<Module>.ATL.CTraceCategoryEx<2048,0>.{ctor}(ref global::<Module>.ATL.atlTraceNotImpl, (ushort*)(&global::<Module>.?A0xaef22b49.unnamed-global-31));
	}

	// Token: 0x0600015C RID: 348 RVA: 0x00001A04 File Offset: 0x00000E04
	internal unsafe static void ??__EatlTraceAllocation@ATL@@YMXXZ()
	{
		global::<Module>.ATL.CTraceCategoryEx<4096,0>.{ctor}(ref global::<Module>.ATL.atlTraceAllocation, (ushort*)(&global::<Module>.?A0xaef22b49.unnamed-global-32));
	}

	// Token: 0x0600015D RID: 349 RVA: 0x00001A24 File Offset: 0x00000E24
	internal unsafe static void ??__EatlTraceException@ATL@@YMXXZ()
	{
		global::<Module>.ATL.CTraceCategoryEx<8192,0>.{ctor}(ref global::<Module>.ATL.atlTraceException, (ushort*)(&global::<Module>.?A0xaef22b49.unnamed-global-33));
	}

	// Token: 0x0600015E RID: 350 RVA: 0x00001A44 File Offset: 0x00000E44
	internal unsafe static void ??__EatlTraceTime@ATL@@YMXXZ()
	{
		global::<Module>.ATL.CTraceCategoryEx<16384,0>.{ctor}(ref global::<Module>.ATL.atlTraceTime, (ushort*)(&global::<Module>.?A0xaef22b49.unnamed-global-34));
	}

	// Token: 0x0600015F RID: 351 RVA: 0x00001A64 File Offset: 0x00000E64
	internal unsafe static void ??__EatlTraceCache@ATL@@YMXXZ()
	{
		global::<Module>.ATL.CTraceCategoryEx<32768,0>.{ctor}(ref global::<Module>.ATL.atlTraceCache, (ushort*)(&global::<Module>.?A0xaef22b49.unnamed-global-35));
	}

	// Token: 0x06000160 RID: 352 RVA: 0x00001A84 File Offset: 0x00000E84
	internal unsafe static void ??__EatlTraceStencil@ATL@@YMXXZ()
	{
		global::<Module>.ATL.CTraceCategoryEx<65536,0>.{ctor}(ref global::<Module>.ATL.atlTraceStencil, (ushort*)(&global::<Module>.?A0xaef22b49.unnamed-global-36));
	}

	// Token: 0x06000161 RID: 353 RVA: 0x00001AA4 File Offset: 0x00000EA4
	internal unsafe static void ??__EatlTraceString@ATL@@YMXXZ()
	{
		global::<Module>.ATL.CTraceCategoryEx<131072,0>.{ctor}(ref global::<Module>.ATL.atlTraceString, (ushort*)(&global::<Module>.?A0xaef22b49.unnamed-global-37));
	}

	// Token: 0x06000162 RID: 354 RVA: 0x00001AC4 File Offset: 0x00000EC4
	internal unsafe static void ??__EatlTraceMap@ATL@@YMXXZ()
	{
		global::<Module>.ATL.CTraceCategoryEx<262144,0>.{ctor}(ref global::<Module>.ATL.atlTraceMap, (ushort*)(&global::<Module>.?A0xaef22b49.unnamed-global-38));
	}

	// Token: 0x06000163 RID: 355 RVA: 0x00001AE4 File Offset: 0x00000EE4
	internal unsafe static void ??__EatlTraceUtil@ATL@@YMXXZ()
	{
		global::<Module>.ATL.CTraceCategoryEx<524288,0>.{ctor}(ref global::<Module>.ATL.atlTraceUtil, (ushort*)(&global::<Module>.?A0xaef22b49.unnamed-global-39));
	}

	// Token: 0x06000164 RID: 356 RVA: 0x00001B04 File Offset: 0x00000F04
	internal unsafe static void ??__EatlTraceSecurity@ATL@@YMXXZ()
	{
		global::<Module>.ATL.CTraceCategoryEx<1048576,0>.{ctor}(ref global::<Module>.ATL.atlTraceSecurity, (ushort*)(&global::<Module>.?A0xaef22b49.unnamed-global-40));
	}

	// Token: 0x06000165 RID: 357 RVA: 0x00001B24 File Offset: 0x00000F24
	internal unsafe static void ??__EatlTraceSync@ATL@@YMXXZ()
	{
		global::<Module>.ATL.CTraceCategoryEx<2097152,0>.{ctor}(ref global::<Module>.ATL.atlTraceSync, (ushort*)(&global::<Module>.?A0xaef22b49.unnamed-global-41));
	}

	// Token: 0x06000166 RID: 358 RVA: 0x00001B44 File Offset: 0x00000F44
	internal unsafe static void ??__EatlTraceISAPI@ATL@@YMXXZ()
	{
		global::<Module>.ATL.CTraceCategoryEx<4194304,0>.{ctor}(ref global::<Module>.ATL.atlTraceISAPI, (ushort*)(&global::<Module>.?A0xaef22b49.unnamed-global-42));
	}

	// Token: 0x06000167 RID: 359 RVA: 0x00001B64 File Offset: 0x00000F64
	internal static void ??__E?pmField@?$CVarTypeInfo@D@ATL@@2QQtagVARIANT@@DQ3@@@YMXXZ()
	{
		global::<CppImplementationDetails>.$PTMType$PQtagVARIANT@@D $PTMType$PQtagVARIANT@@D = 8;
		global::<Module>.?pmField@?$CVarTypeInfo@D@ATL@@2QQtagVARIANT@@DQ3@ = $PTMType$PQtagVARIANT@@D;
	}

	// Token: 0x06000168 RID: 360 RVA: 0x00001B7C File Offset: 0x00000F7C
	internal static void ??__E?pmField@?$CVarTypeInfo@E@ATL@@2QQtagVARIANT@@EQ3@@@YMXXZ()
	{
		global::<CppImplementationDetails>.$PTMType$PQtagVARIANT@@E $PTMType$PQtagVARIANT@@E = 8;
		global::<Module>.?pmField@?$CVarTypeInfo@E@ATL@@2QQtagVARIANT@@EQ3@ = $PTMType$PQtagVARIANT@@E;
	}

	// Token: 0x06000169 RID: 361 RVA: 0x00001B94 File Offset: 0x00000F94
	internal static void ??__E?pmField@?$CVarTypeInfo@PAD@ATL@@2QQtagVARIANT@@PADQ3@@@YMXXZ()
	{
		global::<CppImplementationDetails>.$PTMType$PQtagVARIANT@@PAD $PTMType$PQtagVARIANT@@PAD = 8;
		global::<Module>.?pmField@?$CVarTypeInfo@PAD@ATL@@2QQtagVARIANT@@PADQ3@ = $PTMType$PQtagVARIANT@@PAD;
	}

	// Token: 0x0600016A RID: 362 RVA: 0x00001BAC File Offset: 0x00000FAC
	internal static void ??__E?pmField@?$CVarTypeInfo@PAE@ATL@@2QQtagVARIANT@@PAEQ3@@@YMXXZ()
	{
		global::<CppImplementationDetails>.$PTMType$PQtagVARIANT@@PAE $PTMType$PQtagVARIANT@@PAE = 8;
		global::<Module>.?pmField@?$CVarTypeInfo@PAE@ATL@@2QQtagVARIANT@@PAEQ3@ = $PTMType$PQtagVARIANT@@PAE;
	}

	// Token: 0x0600016B RID: 363 RVA: 0x00001BC4 File Offset: 0x00000FC4
	internal static void ??__E?pmField@?$CVarTypeInfo@F@ATL@@2QQtagVARIANT@@FQ3@@@YMXXZ()
	{
		global::<CppImplementationDetails>.$PTMType$PQtagVARIANT@@F $PTMType$PQtagVARIANT@@F = 8;
		global::<Module>.?pmField@?$CVarTypeInfo@F@ATL@@2QQtagVARIANT@@FQ3@ = $PTMType$PQtagVARIANT@@F;
	}

	// Token: 0x0600016C RID: 364 RVA: 0x00001BDC File Offset: 0x00000FDC
	internal static void ??__E?pmField@?$CVarTypeInfo@PAF@ATL@@2QQtagVARIANT@@PAFQ3@@@YMXXZ()
	{
		global::<CppImplementationDetails>.$PTMType$PQtagVARIANT@@PAF $PTMType$PQtagVARIANT@@PAF = 8;
		global::<Module>.?pmField@?$CVarTypeInfo@PAF@ATL@@2QQtagVARIANT@@PAFQ3@ = $PTMType$PQtagVARIANT@@PAF;
	}

	// Token: 0x0600016D RID: 365 RVA: 0x00001BF4 File Offset: 0x00000FF4
	internal static void ??__E?pmField@?$CVarTypeInfo@G@ATL@@2QQtagVARIANT@@GQ3@@@YMXXZ()
	{
		global::<CppImplementationDetails>.$PTMType$PQtagVARIANT@@G $PTMType$PQtagVARIANT@@G = 8;
		global::<Module>.?pmField@?$CVarTypeInfo@G@ATL@@2QQtagVARIANT@@GQ3@ = $PTMType$PQtagVARIANT@@G;
	}

	// Token: 0x0600016E RID: 366 RVA: 0x00001C0C File Offset: 0x0000100C
	internal static void ??__E?pmField@?$CVarTypeInfo@H@ATL@@2QQtagVARIANT@@HQ3@@@YMXXZ()
	{
		global::<CppImplementationDetails>.$PTMType$PQtagVARIANT@@H $PTMType$PQtagVARIANT@@H = 8;
		global::<Module>.?pmField@?$CVarTypeInfo@H@ATL@@2QQtagVARIANT@@HQ3@ = $PTMType$PQtagVARIANT@@H;
	}

	// Token: 0x0600016F RID: 367 RVA: 0x00001C24 File Offset: 0x00001024
	internal static void ??__E?pmField@?$CVarTypeInfo@PAH@ATL@@2QQtagVARIANT@@PAHQ3@@@YMXXZ()
	{
		global::<CppImplementationDetails>.$PTMType$PQtagVARIANT@@PAH $PTMType$PQtagVARIANT@@PAH = 8;
		global::<Module>.?pmField@?$CVarTypeInfo@PAH@ATL@@2QQtagVARIANT@@PAHQ3@ = $PTMType$PQtagVARIANT@@PAH;
	}

	// Token: 0x06000170 RID: 368 RVA: 0x00001C3C File Offset: 0x0000103C
	internal static void ??__E?pmField@?$CVarTypeInfo@I@ATL@@2QQtagVARIANT@@IQ3@@@YMXXZ()
	{
		global::<CppImplementationDetails>.$PTMType$PQtagVARIANT@@I $PTMType$PQtagVARIANT@@I = 8;
		global::<Module>.?pmField@?$CVarTypeInfo@I@ATL@@2QQtagVARIANT@@IQ3@ = $PTMType$PQtagVARIANT@@I;
	}

	// Token: 0x06000171 RID: 369 RVA: 0x00001C54 File Offset: 0x00001054
	internal static void ??__E?pmField@?$CVarTypeInfo@PAI@ATL@@2QQtagVARIANT@@PAIQ3@@@YMXXZ()
	{
		global::<CppImplementationDetails>.$PTMType$PQtagVARIANT@@PAI $PTMType$PQtagVARIANT@@PAI = 8;
		global::<Module>.?pmField@?$CVarTypeInfo@PAI@ATL@@2QQtagVARIANT@@PAIQ3@ = $PTMType$PQtagVARIANT@@PAI;
	}

	// Token: 0x06000172 RID: 370 RVA: 0x00001C6C File Offset: 0x0000106C
	internal static void ??__E?pmField@?$CVarTypeInfo@J@ATL@@2QQtagVARIANT@@JQ3@@@YMXXZ()
	{
		global::<CppImplementationDetails>.$PTMType$PQtagVARIANT@@J $PTMType$PQtagVARIANT@@J = 8;
		global::<Module>.?pmField@?$CVarTypeInfo@J@ATL@@2QQtagVARIANT@@JQ3@ = $PTMType$PQtagVARIANT@@J;
	}

	// Token: 0x06000173 RID: 371 RVA: 0x00001C84 File Offset: 0x00001084
	internal static void ??__E?pmField@?$CVarTypeInfo@PAJ@ATL@@2QQtagVARIANT@@PAJQ3@@@YMXXZ()
	{
		global::<CppImplementationDetails>.$PTMType$PQtagVARIANT@@PAJ $PTMType$PQtagVARIANT@@PAJ = 8;
		global::<Module>.?pmField@?$CVarTypeInfo@PAJ@ATL@@2QQtagVARIANT@@PAJQ3@ = $PTMType$PQtagVARIANT@@PAJ;
	}

	// Token: 0x06000174 RID: 372 RVA: 0x00001C9C File Offset: 0x0000109C
	internal static void ??__E?pmField@?$CVarTypeInfo@K@ATL@@2QQtagVARIANT@@KQ3@@@YMXXZ()
	{
		global::<CppImplementationDetails>.$PTMType$PQtagVARIANT@@K $PTMType$PQtagVARIANT@@K = 8;
		global::<Module>.?pmField@?$CVarTypeInfo@K@ATL@@2QQtagVARIANT@@KQ3@ = $PTMType$PQtagVARIANT@@K;
	}

	// Token: 0x06000175 RID: 373 RVA: 0x00001CB4 File Offset: 0x000010B4
	internal static void ??__E?pmField@?$CVarTypeInfo@PAK@ATL@@2QQtagVARIANT@@PAKQ3@@@YMXXZ()
	{
		global::<CppImplementationDetails>.$PTMType$PQtagVARIANT@@PAK $PTMType$PQtagVARIANT@@PAK = 8;
		global::<Module>.?pmField@?$CVarTypeInfo@PAK@ATL@@2QQtagVARIANT@@PAKQ3@ = $PTMType$PQtagVARIANT@@PAK;
	}

	// Token: 0x06000176 RID: 374 RVA: 0x00001CCC File Offset: 0x000010CC
	internal static void ??__E?pmField@?$CVarTypeInfo@_J@ATL@@2QQtagVARIANT@@_JQ3@@@YMXXZ()
	{
		global::<CppImplementationDetails>.$PTMType$PQtagVARIANT@@_J $PTMType$PQtagVARIANT@@_J = 8;
		global::<Module>.?pmField@?$CVarTypeInfo@_J@ATL@@2QQtagVARIANT@@_JQ3@ = $PTMType$PQtagVARIANT@@_J;
	}

	// Token: 0x06000177 RID: 375 RVA: 0x00001CE4 File Offset: 0x000010E4
	internal static void ??__E?pmField@?$CVarTypeInfo@PA_J@ATL@@2QQtagVARIANT@@PA_JQ3@@@YMXXZ()
	{
		global::<CppImplementationDetails>.$PTMType$PQtagVARIANT@@PA_J $PTMType$PQtagVARIANT@@PA_J = 8;
		global::<Module>.?pmField@?$CVarTypeInfo@PA_J@ATL@@2QQtagVARIANT@@PA_JQ3@ = $PTMType$PQtagVARIANT@@PA_J;
	}

	// Token: 0x06000178 RID: 376 RVA: 0x00001CFC File Offset: 0x000010FC
	internal static void ??__E?pmField@?$CVarTypeInfo@_K@ATL@@2QQtagVARIANT@@_KQ3@@@YMXXZ()
	{
		global::<CppImplementationDetails>.$PTMType$PQtagVARIANT@@_K $PTMType$PQtagVARIANT@@_K = 8;
		global::<Module>.?pmField@?$CVarTypeInfo@_K@ATL@@2QQtagVARIANT@@_KQ3@ = $PTMType$PQtagVARIANT@@_K;
	}

	// Token: 0x06000179 RID: 377 RVA: 0x00001D14 File Offset: 0x00001114
	internal static void ??__E?pmField@?$CVarTypeInfo@PA_K@ATL@@2QQtagVARIANT@@PA_KQ3@@@YMXXZ()
	{
		global::<CppImplementationDetails>.$PTMType$PQtagVARIANT@@PA_K $PTMType$PQtagVARIANT@@PA_K = 8;
		global::<Module>.?pmField@?$CVarTypeInfo@PA_K@ATL@@2QQtagVARIANT@@PA_KQ3@ = $PTMType$PQtagVARIANT@@PA_K;
	}

	// Token: 0x0600017A RID: 378 RVA: 0x00001D2C File Offset: 0x0000112C
	internal static void ??__E?pmField@?$CVarTypeInfo@M@ATL@@2QQtagVARIANT@@MQ3@@@YMXXZ()
	{
		global::<CppImplementationDetails>.$PTMType$PQtagVARIANT@@M $PTMType$PQtagVARIANT@@M = 8;
		global::<Module>.?pmField@?$CVarTypeInfo@M@ATL@@2QQtagVARIANT@@MQ3@ = $PTMType$PQtagVARIANT@@M;
	}

	// Token: 0x0600017B RID: 379 RVA: 0x00001D44 File Offset: 0x00001144
	internal static void ??__E?pmField@?$CVarTypeInfo@PAM@ATL@@2QQtagVARIANT@@PAMQ3@@@YMXXZ()
	{
		global::<CppImplementationDetails>.$PTMType$PQtagVARIANT@@PAM $PTMType$PQtagVARIANT@@PAM = 8;
		global::<Module>.?pmField@?$CVarTypeInfo@PAM@ATL@@2QQtagVARIANT@@PAMQ3@ = $PTMType$PQtagVARIANT@@PAM;
	}

	// Token: 0x0600017C RID: 380 RVA: 0x00001D5C File Offset: 0x0000115C
	internal static void ??__E?pmField@?$CVarTypeInfo@N@ATL@@2QQtagVARIANT@@NQ3@@@YMXXZ()
	{
		global::<CppImplementationDetails>.$PTMType$PQtagVARIANT@@N $PTMType$PQtagVARIANT@@N = 8;
		global::<Module>.?pmField@?$CVarTypeInfo@N@ATL@@2QQtagVARIANT@@NQ3@ = $PTMType$PQtagVARIANT@@N;
	}

	// Token: 0x0600017D RID: 381 RVA: 0x00001D74 File Offset: 0x00001174
	internal static void ??__E?pmField@?$CVarTypeInfo@PAN@ATL@@2QQtagVARIANT@@PANQ3@@@YMXXZ()
	{
		global::<CppImplementationDetails>.$PTMType$PQtagVARIANT@@PAN $PTMType$PQtagVARIANT@@PAN = 8;
		global::<Module>.?pmField@?$CVarTypeInfo@PAN@ATL@@2QQtagVARIANT@@PANQ3@ = $PTMType$PQtagVARIANT@@PAN;
	}

	// Token: 0x0600017E RID: 382 RVA: 0x00001D8C File Offset: 0x0000118C
	internal static void ??__E?pmField@?$CVarTypeInfo@PAG@ATL@@2QQtagVARIANT@@PAGQ3@@@YMXXZ()
	{
		global::<CppImplementationDetails>.$PTMType$PQtagVARIANT@@PAG $PTMType$PQtagVARIANT@@PAG = 8;
		global::<Module>.?pmField@?$CVarTypeInfo@PAG@ATL@@2QQtagVARIANT@@PAGQ3@ = $PTMType$PQtagVARIANT@@PAG;
	}

	// Token: 0x0600017F RID: 383 RVA: 0x00001DA4 File Offset: 0x000011A4
	internal static void ??__E?pmField@?$CVarTypeInfo@PAPAG@ATL@@2QQtagVARIANT@@PAPAGQ3@@@YMXXZ()
	{
		global::<CppImplementationDetails>.$PTMType$PQtagVARIANT@@PAPAG $PTMType$PQtagVARIANT@@PAPAG = 8;
		global::<Module>.?pmField@?$CVarTypeInfo@PAPAG@ATL@@2QQtagVARIANT@@PAPAGQ3@ = $PTMType$PQtagVARIANT@@PAPAG;
	}

	// Token: 0x06000180 RID: 384 RVA: 0x00001DBC File Offset: 0x000011BC
	internal static void ??__E?pmField@?$CVarTypeInfo@PAUIUnknown@@@ATL@@2QQtagVARIANT@@PAUIUnknown@@Q3@@@YMXXZ()
	{
		global::<CppImplementationDetails>.$PTMType$PQtagVARIANT@@PAUIUnknown@@ $PTMType$PQtagVARIANT@@PAUIUnknown@@ = 8;
		global::<Module>.?pmField@?$CVarTypeInfo@PAUIUnknown@@@ATL@@2QQtagVARIANT@@PAUIUnknown@@Q3@ = $PTMType$PQtagVARIANT@@PAUIUnknown@@;
	}

	// Token: 0x06000181 RID: 385 RVA: 0x00001DD4 File Offset: 0x000011D4
	internal static void ??__E?pmField@?$CVarTypeInfo@PAPAUIUnknown@@@ATL@@2QQtagVARIANT@@PAPAUIUnknown@@Q3@@@YMXXZ()
	{
		global::<CppImplementationDetails>.$PTMType$PQtagVARIANT@@PAPAUIUnknown@@ $PTMType$PQtagVARIANT@@PAPAUIUnknown@@ = 8;
		global::<Module>.?pmField@?$CVarTypeInfo@PAPAUIUnknown@@@ATL@@2QQtagVARIANT@@PAPAUIUnknown@@Q3@ = $PTMType$PQtagVARIANT@@PAPAUIUnknown@@;
	}

	// Token: 0x06000182 RID: 386 RVA: 0x00001DEC File Offset: 0x000011EC
	internal static void ??__E?pmField@?$CVarTypeInfo@PAUIDispatch@@@ATL@@2QQtagVARIANT@@PAUIDispatch@@Q3@@@YMXXZ()
	{
		global::<CppImplementationDetails>.$PTMType$PQtagVARIANT@@PAUIDispatch@@ $PTMType$PQtagVARIANT@@PAUIDispatch@@ = 8;
		global::<Module>.?pmField@?$CVarTypeInfo@PAUIDispatch@@@ATL@@2QQtagVARIANT@@PAUIDispatch@@Q3@ = $PTMType$PQtagVARIANT@@PAUIDispatch@@;
	}

	// Token: 0x06000183 RID: 387 RVA: 0x00001E04 File Offset: 0x00001204
	internal static void ??__E?pmField@?$CVarTypeInfo@PAPAUIDispatch@@@ATL@@2QQtagVARIANT@@PAPAUIDispatch@@Q3@@@YMXXZ()
	{
		global::<CppImplementationDetails>.$PTMType$PQtagVARIANT@@PAPAUIDispatch@@ $PTMType$PQtagVARIANT@@PAPAUIDispatch@@ = 8;
		global::<Module>.?pmField@?$CVarTypeInfo@PAPAUIDispatch@@@ATL@@2QQtagVARIANT@@PAPAUIDispatch@@Q3@ = $PTMType$PQtagVARIANT@@PAPAUIDispatch@@;
	}

	// Token: 0x06000184 RID: 388 RVA: 0x00001E1C File Offset: 0x0000121C
	internal static void ??__E?pmField@?$CVarTypeInfo@TtagCY@@@ATL@@2QQtagVARIANT@@TtagCY@@Q3@@@YMXXZ()
	{
		global::<CppImplementationDetails>.$PTMType$PQtagVARIANT@@TtagCY@@ $PTMType$PQtagVARIANT@@TtagCY@@ = 8;
		global::<Module>.?pmField@?$CVarTypeInfo@TtagCY@@@ATL@@2QQtagVARIANT@@TtagCY@@Q3@ = $PTMType$PQtagVARIANT@@TtagCY@@;
	}

	// Token: 0x06000185 RID: 389 RVA: 0x00001E34 File Offset: 0x00001234
	internal static void ??__E?pmField@?$CVarTypeInfo@PATtagCY@@@ATL@@2QQtagVARIANT@@PATtagCY@@Q3@@@YMXXZ()
	{
		global::<CppImplementationDetails>.$PTMType$PQtagVARIANT@@PATtagCY@@ $PTMType$PQtagVARIANT@@PATtagCY@@ = 8;
		global::<Module>.?pmField@?$CVarTypeInfo@PATtagCY@@@ATL@@2QQtagVARIANT@@PATtagCY@@Q3@ = $PTMType$PQtagVARIANT@@PATtagCY@@;
	}

	// Token: 0x06000186 RID: 390 RVA: 0x00001E4C File Offset: 0x0000124C
	internal static void ??__E_AtlComModule@ATL@@YMXXZ()
	{
		global::<Module>.ATL.CAtlComModule.{ctor}(ref global::<Module>.ATL._AtlComModule);
		global::<Module>._atexit_m(ldftn(?A0xaef22b49.??__F_AtlComModule@ATL@@YMXXZ));
	}

	// Token: 0x06000187 RID: 391 RVA: 0x00008734 File Offset: 0x00007B34
	internal static void ??__F_AtlComModule@ATL@@YMXXZ()
	{
		global::<Module>.ATL.CAtlComModule.{dtor}(ref global::<Module>.ATL._AtlComModule);
	}

	// Token: 0x06000188 RID: 392 RVA: 0x00001E70 File Offset: 0x00001270
	internal static void ??__E_AtlWinModule@ATL@@YMXXZ()
	{
		global::<Module>.ATL.CAtlWinModule.{ctor}(ref global::<Module>.ATL._AtlWinModule);
		global::<Module>._atexit_m(ldftn(?A0xaef22b49.??__F_AtlWinModule@ATL@@YMXXZ));
	}

	// Token: 0x06000189 RID: 393 RVA: 0x00008774 File Offset: 0x00007B74
	internal static void ??__F_AtlWinModule@ATL@@YMXXZ()
	{
		global::<Module>.ATL.CAtlWinModule.{dtor}(ref global::<Module>.ATL._AtlWinModule);
	}

	// Token: 0x0600018A RID: 394 RVA: 0x00001E94 File Offset: 0x00001294
	internal static void ??__E_AtlReleaseManagedClassFactories@ATL@@YMXXZ()
	{
		global::<Module>.ATL.CAtlReleaseManagedClassFactories.{ctor}(ref global::<Module>.ATL._AtlReleaseManagedClassFactories);
		global::<Module>._atexit_m(ldftn(?A0xaef22b49.??__F_AtlReleaseManagedClassFactories@ATL@@YMXXZ));
	}

	// Token: 0x0600018B RID: 395 RVA: 0x00008754 File Offset: 0x00007B54
	internal static void ??__F_AtlReleaseManagedClassFactories@ATL@@YMXXZ()
	{
		global::<Module>.ATL.CAtlReleaseManagedClassFactories.{dtor}(ref global::<Module>.ATL._AtlReleaseManagedClassFactories);
	}

	// Token: 0x0600018C RID: 396 RVA: 0x00001EB8 File Offset: 0x000012B8
	internal static void ??__E?isInitialized@CAtlStringMgr@ATL@@0_NA@@YMXXZ()
	{
		global::<Module>.?isInitialized@CAtlStringMgr@ATL@@0_NA = (global::<Module>.ATL.CAtlStringMgr.StaticInitialize() != null);
	}

	// Token: 0x0600018D RID: 397 RVA: 0x000056A0 File Offset: 0x00004AA0
	internal unsafe static int DllMain(global::HINSTANCE__* hModule, uint dwReason, void* lpvReserved)
	{
		return 1;
	}

	// Token: 0x0600018E RID: 398 RVA: 0x00006C9C File Offset: 0x0000609C
	[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
	internal static bool <CrtImplementationDetails>.NativeDll.IsInDllMain()
	{
		return (global::<Module>.__native_dllmain_reason != uint.MaxValue) ? 1 : 0;
	}

	// Token: 0x0600018F RID: 399 RVA: 0x00006CB8 File Offset: 0x000060B8
	[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
	internal static bool <CrtImplementationDetails>.NativeDll.IsInProcessAttach()
	{
		return (global::<Module>.__native_dllmain_reason == 1U) ? 1 : 0;
	}

	// Token: 0x06000190 RID: 400 RVA: 0x00006CD0 File Offset: 0x000060D0
	[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
	internal static bool <CrtImplementationDetails>.NativeDll.IsInProcessDetach()
	{
		return (global::<Module>.__native_dllmain_reason == 0U) ? 1 : 0;
	}

	// Token: 0x06000191 RID: 401 RVA: 0x00006CE8 File Offset: 0x000060E8
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

	// Token: 0x06000192 RID: 402 RVA: 0x00007500 File Offset: 0x00006900
	internal static void <CrtImplementationDetails>.ThrowNestedModuleLoadException(global::System.Exception innerException, global::System.Exception nestedException)
	{
		throw new global::<CrtImplementationDetails>.ModuleLoadExceptionHandlerException("A nested exception occurred after the primary exception that caused the C++ module to fail to load.\n", innerException, nestedException);
	}

	// Token: 0x06000193 RID: 403 RVA: 0x00006EE8 File Offset: 0x000062E8
	internal static void <CrtImplementationDetails>.ThrowModuleLoadException(string errorMessage)
	{
		throw new global::<CrtImplementationDetails>.ModuleLoadException(errorMessage);
	}

	// Token: 0x06000194 RID: 404 RVA: 0x00006EFC File Offset: 0x000062FC
	internal static void <CrtImplementationDetails>.ThrowModuleLoadException(string errorMessage, global::System.Exception innerException)
	{
		throw new global::<CrtImplementationDetails>.ModuleLoadException(errorMessage, innerException);
	}

	// Token: 0x06000195 RID: 405 RVA: 0x00007018 File Offset: 0x00006418
	internal static void <CrtImplementationDetails>.RegisterModuleUninitializer(global::System.EventHandler handler)
	{
		global::<CrtImplementationDetails>.ModuleUninitializer._ModuleUninitializer.AddHandler(handler);
	}

	// Token: 0x06000196 RID: 406 RVA: 0x00007030 File Offset: 0x00006430
	[global::System.Security.SecuritySafeCritical]
	internal unsafe static global::System.Guid <CrtImplementationDetails>.FromGUID(global::_GUID* guid)
	{
		global::System.Guid result = new global::System.Guid((uint)(*guid), *(guid + 4), *(guid + 6), *(guid + 8), *(guid + 9), *(guid + 10), *(guid + 11), *(guid + 12), *(guid + 13), *(guid + 14), *(guid + 15));
		return result;
	}

	// Token: 0x06000197 RID: 407 RVA: 0x00007078 File Offset: 0x00006478
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

	// Token: 0x06000198 RID: 408 RVA: 0x000070FC File Offset: 0x000064FC
	internal unsafe static void __release_appdomain(global::IUnknown* ppUnk)
	{
		object obj = calli(System.UInt32 modopt(System.Runtime.CompilerServices.IsLong) modopt(System.Runtime.CompilerServices.CallConvStdcall)(System.IntPtr), ppUnk, *(*(int*)ppUnk + 8));
	}

	// Token: 0x06000199 RID: 409 RVA: 0x00007118 File Offset: 0x00006518
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

	// Token: 0x0600019A RID: 410 RVA: 0x00007178 File Offset: 0x00006578
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

	// Token: 0x0600019B RID: 411 RVA: 0x00007230 File Offset: 0x00006630
	[global::System.Security.SecuritySafeCritical]
	internal unsafe static int <CrtImplementationDetails>.DefaultDomain.DoNothing(void* cookie)
	{
		global::System.GC.KeepAlive(int.MaxValue);
		return 0;
	}

	// Token: 0x0600019C RID: 412 RVA: 0x00007250 File Offset: 0x00006650
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

	// Token: 0x0600019D RID: 413 RVA: 0x000072A4 File Offset: 0x000066A4
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

	// Token: 0x0600019E RID: 414 RVA: 0x00007324 File Offset: 0x00006724
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

	// Token: 0x0600019F RID: 415 RVA: 0x00007360 File Offset: 0x00006760
	[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
	internal static bool <CrtImplementationDetails>.DefaultDomain.NeedsUninitialization()
	{
		return global::<Module>.?Entered@DefaultDomain@<CrtImplementationDetails>@@2_NA;
	}

	// Token: 0x060001A0 RID: 416 RVA: 0x00007374 File Offset: 0x00006774
	[global::System.Security.SecurityCritical]
	internal static void <CrtImplementationDetails>.DefaultDomain.Initialize()
	{
		global::<Module>.<CrtImplementationDetails>.DoCallBackInDefaultDomain(global::<Module>.__unep@?DoNothing@DefaultDomain@<CrtImplementationDetails>@@$$FCGJPAX@Z, null);
	}

	// Token: 0x060001A1 RID: 417 RVA: 0x00002050 File Offset: 0x00001450
	internal static void ??__E?Initialized@CurrentDomain@<CrtImplementationDetails>@@$$Q2HA@@YMXXZ()
	{
		global::<Module>.?Initialized@CurrentDomain@<CrtImplementationDetails>@@$$Q2HA = 0;
	}

	// Token: 0x060001A2 RID: 418 RVA: 0x00002064 File Offset: 0x00001464
	internal static void ??__E?Uninitialized@CurrentDomain@<CrtImplementationDetails>@@$$Q2HA@@YMXXZ()
	{
		global::<Module>.?Uninitialized@CurrentDomain@<CrtImplementationDetails>@@$$Q2HA = 0;
	}

	// Token: 0x060001A3 RID: 419 RVA: 0x00002078 File Offset: 0x00001478
	internal static void ??__E?IsDefaultDomain@CurrentDomain@<CrtImplementationDetails>@@$$Q2_NA@@YMXXZ()
	{
		global::<Module>.?IsDefaultDomain@CurrentDomain@<CrtImplementationDetails>@@$$Q2_NA = false;
	}

	// Token: 0x060001A4 RID: 420 RVA: 0x0000208C File Offset: 0x0000148C
	internal static void ??__E?InitializedVtables@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A@@YMXXZ()
	{
		global::<Module>.?InitializedVtables@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A = (global::<CrtImplementationDetails>.Progress.State)0;
	}

	// Token: 0x060001A5 RID: 421 RVA: 0x000020A0 File Offset: 0x000014A0
	internal static void ??__E?InitializedNative@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A@@YMXXZ()
	{
		global::<Module>.?InitializedNative@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A = (global::<CrtImplementationDetails>.Progress.State)0;
	}

	// Token: 0x060001A6 RID: 422 RVA: 0x000020B4 File Offset: 0x000014B4
	internal static void ??__E?InitializedPerProcess@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A@@YMXXZ()
	{
		global::<Module>.?InitializedPerProcess@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A = (global::<CrtImplementationDetails>.Progress.State)0;
	}

	// Token: 0x060001A7 RID: 423 RVA: 0x000020C8 File Offset: 0x000014C8
	internal static void ??__E?InitializedPerAppDomain@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A@@YMXXZ()
	{
		global::<Module>.?InitializedPerAppDomain@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A = (global::<CrtImplementationDetails>.Progress.State)0;
	}

	// Token: 0x060001A8 RID: 424 RVA: 0x00007554 File Offset: 0x00006954
	[global::System.Security.SecurityCritical]
	[global::System.Diagnostics.DebuggerStepThrough]
	internal unsafe static void <CrtImplementationDetails>.LanguageSupport.InitializeVtables(global::<CrtImplementationDetails>.LanguageSupport* A_0)
	{
		global::<Module>.gcroot<System::String\u0020^>.=(A_0, "The C++ module failed to load during vtable initialization.\n");
		global::<Module>.?InitializedVtables@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A = (global::<CrtImplementationDetails>.Progress.State)1;
		global::<Module>._initterm_m((global::method*)(&global::<Module>.?A0xd2508fec.__xi_vt_a), (global::method*)(&global::<Module>.?A0xd2508fec.__xi_vt_z));
		global::<Module>.?InitializedVtables@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A = (global::<CrtImplementationDetails>.Progress.State)2;
	}

	// Token: 0x060001A9 RID: 425 RVA: 0x00007588 File Offset: 0x00006988
	[global::System.Security.SecurityCritical]
	internal unsafe static void <CrtImplementationDetails>.LanguageSupport.InitializeDefaultAppDomain(global::<CrtImplementationDetails>.LanguageSupport* A_0)
	{
		global::<Module>.gcroot<System::String\u0020^>.=(A_0, "The C++ module failed to load while attempting to initialize the default appdomain.\n");
		global::<Module>.<CrtImplementationDetails>.DefaultDomain.Initialize();
	}

	// Token: 0x060001AA RID: 426 RVA: 0x000075A8 File Offset: 0x000069A8
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.Security.SecurityCritical]
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

	// Token: 0x060001AB RID: 427 RVA: 0x00007644 File Offset: 0x00006A44
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

	// Token: 0x060001AC RID: 428 RVA: 0x00007684 File Offset: 0x00006A84
	[global::System.Security.SecurityCritical]
	[global::System.Diagnostics.DebuggerStepThrough]
	internal unsafe static void <CrtImplementationDetails>.LanguageSupport.InitializePerAppDomain(global::<CrtImplementationDetails>.LanguageSupport* A_0)
	{
		global::<Module>.gcroot<System::String\u0020^>.=(A_0, "The C++ module failed to load during appdomain initialization.\n");
		global::<Module>.?InitializedPerAppDomain@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A = (global::<CrtImplementationDetails>.Progress.State)1;
		global::<Module>._initatexit_app_domain();
		global::<Module>._initterm_m((global::method*)(&global::<Module>.?A0xd2508fec.__xc_ma_a), (global::method*)(&global::<Module>.?A0xd2508fec.__xc_ma_z));
		global::<Module>.?InitializedPerAppDomain@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A = (global::<CrtImplementationDetails>.Progress.State)2;
	}

	// Token: 0x060001AD RID: 429 RVA: 0x000076C0 File Offset: 0x00006AC0
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.Security.SecurityCritical]
	internal unsafe static void <CrtImplementationDetails>.LanguageSupport.InitializeUninitializer(global::<CrtImplementationDetails>.LanguageSupport* A_0)
	{
		global::<Module>.gcroot<System::String\u0020^>.=(A_0, "The C++ module failed to load during registration for the unload events.\n");
		global::<Module>.<CrtImplementationDetails>.RegisterModuleUninitializer(new global::System.EventHandler(global::<Module>.<CrtImplementationDetails>.LanguageSupport.DomainUnload));
	}

	// Token: 0x060001AE RID: 430 RVA: 0x000076EC File Offset: 0x00006AEC
	[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.Success)]
	[global::System.Security.SecurityCritical]
	[global::System.Diagnostics.DebuggerStepThrough]
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

	// Token: 0x060001AF RID: 431 RVA: 0x0000738C File Offset: 0x0000678C
	[global::System.Security.SecurityCritical]
	internal static void <CrtImplementationDetails>.LanguageSupport.UninitializeAppDomain()
	{
		global::<Module>._app_exit_callback();
	}

	// Token: 0x060001B0 RID: 432 RVA: 0x000073A0 File Offset: 0x000067A0
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

	// Token: 0x060001B1 RID: 433 RVA: 0x000073DC File Offset: 0x000067DC
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

	// Token: 0x060001B2 RID: 434 RVA: 0x00007410 File Offset: 0x00006810
	[global::System.Security.SecurityCritical]
	[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.Success)]
	[global::System.Runtime.ConstrainedExecution.PrePrepareMethod]
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

	// Token: 0x060001B3 RID: 435 RVA: 0x00007810 File Offset: 0x00006C10
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

	// Token: 0x060001B4 RID: 436 RVA: 0x00007884 File Offset: 0x00006C84
	[global::System.Security.SecurityCritical]
	internal unsafe static global::<CrtImplementationDetails>.LanguageSupport* <CrtImplementationDetails>.LanguageSupport.{ctor}(global::<CrtImplementationDetails>.LanguageSupport* A_0)
	{
		global::<Module>.gcroot<System::String\u0020^>.{ctor}(A_0);
		return A_0;
	}

	// Token: 0x060001B5 RID: 437 RVA: 0x0000789C File Offset: 0x00006C9C
	[global::System.Security.SecurityCritical]
	internal unsafe static void <CrtImplementationDetails>.LanguageSupport.{dtor}(global::<CrtImplementationDetails>.LanguageSupport* A_0)
	{
		global::<Module>.gcroot<System::String\u0020^>.{dtor}(A_0);
	}

	// Token: 0x060001B6 RID: 438 RVA: 0x000078B0 File Offset: 0x00006CB0
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

	// Token: 0x060001B7 RID: 439 RVA: 0x0000796C File Offset: 0x00006D6C
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.Security.SecurityCritical]
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

	// Token: 0x060001B8 RID: 440 RVA: 0x0000744C File Offset: 0x0000684C
	[global::System.Security.SecuritySafeCritical]
	[global::System.Diagnostics.DebuggerStepThrough]
	internal unsafe static global::gcroot<System::String\u0020^>* {ctor}(global::gcroot<System::String\u0020^>* A_0)
	{
		*A_0 = ((global::System.IntPtr)global::System.Runtime.InteropServices.GCHandle.Alloc(null)).ToPointer();
		return A_0;
	}

	// Token: 0x060001B9 RID: 441 RVA: 0x00007470 File Offset: 0x00006870
	[global::System.Security.SecurityCritical]
	[global::System.Diagnostics.DebuggerStepThrough]
	internal unsafe static void {dtor}(global::gcroot<System::String\u0020^>* A_0)
	{
		global::System.IntPtr value = new global::System.IntPtr(*A_0);
		((global::System.Runtime.InteropServices.GCHandle)value).Free();
		*A_0 = 0;
	}

	// Token: 0x060001BA RID: 442 RVA: 0x00007498 File Offset: 0x00006898
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.Security.SecurityCritical]
	internal unsafe static global::gcroot<System::String\u0020^>* =(global::gcroot<System::String\u0020^>* A_0, string t)
	{
		global::System.IntPtr value = new global::System.IntPtr(*A_0);
		((global::System.Runtime.InteropServices.GCHandle)value).Target = t;
		return A_0;
	}

	// Token: 0x060001BB RID: 443 RVA: 0x000074C0 File Offset: 0x000068C0
	[global::System.Security.SecuritySafeCritical]
	internal unsafe static string P$AAVString@System@@(global::gcroot<System::String\u0020^>* A_0)
	{
		global::System.IntPtr value = new global::System.IntPtr(*A_0);
		return ((global::System.Runtime.InteropServices.GCHandle)value).Target;
	}

	// Token: 0x060001BC RID: 444 RVA: 0x00007ACC File Offset: 0x00006ECC
	[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.Success)]
	[global::System.Security.SecurityCritical]
	[global::System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
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

	// Token: 0x060001BD RID: 445 RVA: 0x00007B18 File Offset: 0x00006F18
	[global::System.Security.SecurityCritical]
	[global::System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
	[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.Success)]
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

	// Token: 0x060001BE RID: 446 RVA: 0x00007B64 File Offset: 0x00006F64
	[global::System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
	[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.Success)]
	[global::System.Security.SecurityCritical]
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

	// Token: 0x060001BF RID: 447 RVA: 0x00007BB4 File Offset: 0x00006FB4
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

	// Token: 0x060001C0 RID: 448 RVA: 0x000080B8 File Offset: 0x000074B8
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.Security.SecurityCritical]
	internal static void <CrtImplementationDetails>.AtExitLock._lock_Construct(object value)
	{
		global::<Module>.?_lock@AtExitLock@<CrtImplementationDetails>@@$$Q0PAXA = null;
		global::<Module>.<CrtImplementationDetails>.AtExitLock._lock_Set(value);
	}

	// Token: 0x060001C1 RID: 449 RVA: 0x00007BE4 File Offset: 0x00006FE4
	[global::System.Security.SecurityCritical]
	[global::System.Diagnostics.DebuggerStepThrough]
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

	// Token: 0x060001C2 RID: 450 RVA: 0x00007C34 File Offset: 0x00007034
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.Security.SecurityCritical]
	internal static object <CrtImplementationDetails>.AtExitLock._lock_Get()
	{
		global::System.ValueType valueType = global::<Module>.<CrtImplementationDetails>.AtExitLock._handle();
		if (valueType != null)
		{
			return ((global::System.Runtime.InteropServices.GCHandle)valueType).Target;
		}
		return null;
	}

	// Token: 0x060001C3 RID: 451 RVA: 0x00007C58 File Offset: 0x00007058
	[global::System.Security.SecurityCritical]
	[global::System.Diagnostics.DebuggerStepThrough]
	internal static void <CrtImplementationDetails>.AtExitLock._lock_Destruct()
	{
		global::System.ValueType valueType = global::<Module>.<CrtImplementationDetails>.AtExitLock._handle();
		if (valueType != null)
		{
			((global::System.Runtime.InteropServices.GCHandle)valueType).Free();
			global::<Module>.?_lock@AtExitLock@<CrtImplementationDetails>@@$$Q0PAXA = null;
		}
	}

	// Token: 0x060001C4 RID: 452 RVA: 0x00007C80 File Offset: 0x00007080
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.Security.SecuritySafeCritical]
	[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
	internal static bool <CrtImplementationDetails>.AtExitLock.IsInitialized()
	{
		return (global::<Module>.<CrtImplementationDetails>.AtExitLock._lock_Get() != null) ? 1 : 0;
	}

	// Token: 0x060001C5 RID: 453 RVA: 0x000080D4 File Offset: 0x000074D4
	[global::System.Security.SecurityCritical]
	[global::System.Diagnostics.DebuggerStepThrough]
	internal static void <CrtImplementationDetails>.AtExitLock.AddRef()
	{
		if (global::<Module>.<CrtImplementationDetails>.AtExitLock.IsInitialized() == null)
		{
			global::<Module>.<CrtImplementationDetails>.AtExitLock._lock_Construct(new object());
			global::<Module>.?_ref_count@AtExitLock@<CrtImplementationDetails>@@$$Q0HA = 0;
		}
		global::<Module>.?_ref_count@AtExitLock@<CrtImplementationDetails>@@$$Q0HA++;
	}

	// Token: 0x060001C6 RID: 454 RVA: 0x00007C9C File Offset: 0x0000709C
	[global::System.Security.SecurityCritical]
	[global::System.Diagnostics.DebuggerStepThrough]
	internal static void <CrtImplementationDetails>.AtExitLock.RemoveRef()
	{
		global::<Module>.?_ref_count@AtExitLock@<CrtImplementationDetails>@@$$Q0HA--;
		if (global::<Module>.?_ref_count@AtExitLock@<CrtImplementationDetails>@@$$Q0HA == 0)
		{
			global::<Module>.<CrtImplementationDetails>.AtExitLock._lock_Destruct();
		}
	}

	// Token: 0x060001C7 RID: 455 RVA: 0x00007CC4 File Offset: 0x000070C4
	[global::System.Security.SecurityCritical]
	[global::System.Diagnostics.DebuggerStepThrough]
	internal static void <CrtImplementationDetails>.AtExitLock.Enter()
	{
		global::System.Threading.Monitor.Enter(global::<Module>.<CrtImplementationDetails>.AtExitLock._lock_Get());
	}

	// Token: 0x060001C8 RID: 456 RVA: 0x00007CDC File Offset: 0x000070DC
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.Security.SecurityCritical]
	internal static void <CrtImplementationDetails>.AtExitLock.Exit()
	{
		global::System.Threading.Monitor.Exit(global::<Module>.<CrtImplementationDetails>.AtExitLock._lock_Get());
	}

	// Token: 0x060001C9 RID: 457 RVA: 0x00007CF4 File Offset: 0x000070F4
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

	// Token: 0x060001CA RID: 458 RVA: 0x00007D14 File Offset: 0x00007114
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.Security.SecurityCritical]
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

	// Token: 0x060001CB RID: 459 RVA: 0x00008104 File Offset: 0x00007504
	[global::System.Security.SecurityCritical]
	[global::System.Diagnostics.DebuggerStepThrough]
	[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
	internal static bool __alloc_global_lock()
	{
		global::<Module>.<CrtImplementationDetails>.AtExitLock.AddRef();
		return global::<Module>.<CrtImplementationDetails>.AtExitLock.IsInitialized();
	}

	// Token: 0x060001CC RID: 460 RVA: 0x00007D34 File Offset: 0x00007134
	[global::System.Security.SecurityCritical]
	[global::System.Diagnostics.DebuggerStepThrough]
	internal static void __dealloc_global_lock()
	{
		global::<Module>.<CrtImplementationDetails>.AtExitLock.RemoveRef();
	}

	// Token: 0x060001CD RID: 461 RVA: 0x00007D48 File Offset: 0x00007148
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

	// Token: 0x060001CE RID: 462 RVA: 0x00007ECC File Offset: 0x000072CC
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

	// Token: 0x060001CF RID: 463 RVA: 0x0000811C File Offset: 0x0000751C
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

	// Token: 0x060001D0 RID: 464 RVA: 0x00008168 File Offset: 0x00007568
	internal static global::method _onexit_m(global::method _Function)
	{
		return (global::<Module>._atexit_m(_Function) == -1) ? 0 : _Function;
	}

	// Token: 0x060001D1 RID: 465 RVA: 0x00007F78 File Offset: 0x00007378
	[global::System.Security.SecurityCritical]
	internal unsafe static int _atexit_m(global::method func)
	{
		return global::<Module>._atexit_helper(global::<Module>.EncodePointer(func), &global::<Module>.?A0xe62d03cb.__exit_list_size, &global::<Module>.?A0xe62d03cb.__onexitend_m, &global::<Module>.?A0xe62d03cb.__onexitbegin_m);
	}

	// Token: 0x060001D2 RID: 466 RVA: 0x00008188 File Offset: 0x00007588
	[global::System.Security.SecurityCritical]
	[global::System.Diagnostics.DebuggerStepThrough]
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

	// Token: 0x060001D3 RID: 467 RVA: 0x00007FA8 File Offset: 0x000073A8
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

	// Token: 0x060001D4 RID: 468 RVA: 0x000081D4 File Offset: 0x000075D4
	[global::System.Security.SecurityCritical]
	internal static global::method _onexit_m_appdomain(global::method _Function)
	{
		return (global::<Module>._atexit_m_appdomain(_Function) == -1) ? 0 : _Function;
	}

	// Token: 0x060001D5 RID: 469 RVA: 0x00008088 File Offset: 0x00007488
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.Security.SecurityCritical]
	internal unsafe static int _atexit_m_appdomain(global::method func)
	{
		return global::<Module>._atexit_helper(global::<Module>.EncodePointer(func), &global::<Module>.__exit_list_size_app_domain, &global::<Module>.__onexitend_app_domain, &global::<Module>.__onexitbegin_app_domain);
	}

	// Token: 0x060001D6 RID: 470
	[global::System.Security.SecurityCritical]
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.Success)]
	[global::System.Runtime.InteropServices.DllImport("KERNEL32.dll")]
	public unsafe static extern void* DecodePointer(void* Ptr);

	// Token: 0x060001D7 RID: 471
	[global::System.Security.SecurityCritical]
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.Success)]
	[global::System.Runtime.InteropServices.DllImport("KERNEL32.dll")]
	public unsafe static extern void* EncodePointer(void* Ptr);

	// Token: 0x060001D8 RID: 472 RVA: 0x000082C4 File Offset: 0x000076C4
	[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.Success)]
	[global::System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
	[global::System.Security.SecurityCritical]
	internal unsafe static void __ehvec_dtor(void* ptr, uint size, int count, global::method pDtor)
	{
		int num = 0;
		ptr = (void*)(size * (uint)count + (byte*)ptr);
		try
		{
			for (;;)
			{
				count--;
				if (count < 0)
				{
					break;
				}
				ptr = (void*)((byte*)ptr - size);
				calli(System.Void(System.Void*), ptr, pDtor);
			}
			num = 1;
		}
		finally
		{
			if (num == 0)
			{
				global::<Module>.__ArrayUnwind(ptr, size, count, pDtor);
			}
		}
	}

	// Token: 0x060001D9 RID: 473 RVA: 0x00008248 File Offset: 0x00007648
	[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.Success)]
	[global::System.Security.SecurityCritical]
	[global::System.Security.Permissions.SecurityPermission(global::System.Security.Permissions.SecurityAction.Assert, UnmanagedCode = true)]
	internal unsafe static int ArrayUnwindFilter(global::_EXCEPTION_POINTERS* pExPtrs)
	{
		if (*(*(int*)pExPtrs) != -529697949)
		{
			return 0;
		}
		global::<Module>.terminate();
		return 0;
	}

	// Token: 0x060001DA RID: 474 RVA: 0x00008268 File Offset: 0x00007668
	[global::System.Security.SecurityCritical]
	[global::System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
	[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.Success)]
	internal unsafe static void __ArrayUnwind(void* ptr, uint size, int count, global::method pDtor)
	{
		try
		{
			for (;;)
			{
				count--;
				if (count < 0)
				{
					break;
				}
				ptr = (void*)((byte*)ptr - size);
				calli(System.Void(System.Void*), ptr, pDtor);
			}
		}
		catch when (endfilter(global::<Module>.?A0x57cabd3d.ArrayUnwindFilter(global::System.Runtime.InteropServices.Marshal.GetExceptionPointers()) != null))
		{
		}
	}

	// Token: 0x060001DB RID: 475 RVA: 0x0000832C File Offset: 0x0000772C
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

	// Token: 0x060001DC RID: 476 RVA: 0x00008360 File Offset: 0x00007760
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

	// Token: 0x060001DD RID: 477 RVA: 0x0000838C File Offset: 0x0000778C
	[global::System.Diagnostics.DebuggerStepThrough]
	internal static global::System.ModuleHandle <CrtImplementationDetails>.ThisModule.Handle()
	{
		return typeof(global::<CrtImplementationDetails>.ThisModule).Module.ModuleHandle;
	}

	// Token: 0x060001DE RID: 478 RVA: 0x000083DC File Offset: 0x000077DC
	[global::System.Security.SecurityCritical]
	[global::System.Diagnostics.DebuggerStepThrough]
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

	// Token: 0x060001DF RID: 479 RVA: 0x000083B0 File Offset: 0x000077B0
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.Security.SecurityCritical]
	internal static global::method <CrtImplementationDetails>.ThisModule.ResolveMethod<void\u0020const\u0020*\u0020__clrcall(void)>(global::method methodToken)
	{
		return global::<Module>.<CrtImplementationDetails>.ThisModule.Handle().ResolveMethodHandle(methodToken).GetFunctionPointer().ToPointer();
	}

	// Token: 0x060001E0 RID: 480 RVA: 0x0000855E File Offset: 0x0000795E
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern void _Orphan_all(global::std._Container_base0*);

	// Token: 0x060001E1 RID: 481 RVA: 0x000022A0 File Offset: 0x000016A0
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged | global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]
	internal unsafe static extern int _AtlInitializeCriticalSectionEx(global::_RTL_CRITICAL_SECTION*, uint, uint);

	// Token: 0x060001E2 RID: 482 RVA: 0x000054A0 File Offset: 0x000048A0
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged | global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]
	internal unsafe static extern global::ATL.CAtlComModule* {ctor}(global::ATL.CAtlComModule*);

	// Token: 0x060001E3 RID: 483 RVA: 0x000055F0 File Offset: 0x000049F0
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged | global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]
	internal unsafe static extern void {dtor}(global::ATL.CAtlComModule*);

	// Token: 0x060001E4 RID: 484 RVA: 0x00004540 File Offset: 0x00003940
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged | global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]
	internal unsafe static extern void Term(global::ATL.CAtlComModule*);

	// Token: 0x060001E5 RID: 485 RVA: 0x0000848C File Offset: 0x0000788C
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern void* @new(uint);

	// Token: 0x060001E6 RID: 486 RVA: 0x00008498 File Offset: 0x00007898
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal static extern int __CxxQueryExceptionSize();

	// Token: 0x060001E7 RID: 487 RVA: 0x000084AA File Offset: 0x000078AA
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern int __CxxDetectRethrow(void*);

	// Token: 0x060001E8 RID: 488 RVA: 0x000084F2 File Offset: 0x000078F2
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern int lc_get_errno(global::lm_handle*);

	// Token: 0x060001E9 RID: 489 RVA: 0x0000844A File Offset: 0x0000784A
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.StdCall, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern void DeleteCriticalSection(global::_RTL_CRITICAL_SECTION*);

	// Token: 0x060001EA RID: 490 RVA: 0x00008492 File Offset: 0x00007892
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern int sscanf(sbyte*, sbyte*, __arglist);

	// Token: 0x060001EB RID: 491 RVA: 0x00008540 File Offset: 0x00007940
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.StdCall, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern uint SysStringByteLen(ushort*);

	// Token: 0x060001EC RID: 492 RVA: 0x00008474 File Offset: 0x00007874
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.StdCall, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern void _CxxThrowException(void*, global::_s__ThrowInfo*);

	// Token: 0x060001ED RID: 493 RVA: 0x00008534 File Offset: 0x00007934
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.StdCall, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern int UnregisterClassW(ushort*, global::HINSTANCE__*);

	// Token: 0x060001EE RID: 494 RVA: 0x00008450 File Offset: 0x00007850
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal static extern double _hypot(double, double);

	// Token: 0x060001EF RID: 495 RVA: 0x000084E6 File Offset: 0x000078E6
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern void lc_checkin(global::lm_handle*, sbyte*, int);

	// Token: 0x060001F0 RID: 496 RVA: 0x000084FE File Offset: 0x000078FE
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern int lc_hostid(global::lm_handle*, int, sbyte*);

	// Token: 0x060001F1 RID: 497 RVA: 0x000084B0 File Offset: 0x000078B0
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern void __CxxUnregisterExceptionObject(void*, int);

	// Token: 0x060001F2 RID: 498 RVA: 0x00006432 File Offset: 0x00005832
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern void delete(void*);

	// Token: 0x060001F3 RID: 499 RVA: 0x00008522 File Offset: 0x00007922
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.StdCall, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern uint HeapSize(void*, uint, void*);

	// Token: 0x060001F4 RID: 500 RVA: 0x00008438 File Offset: 0x00007838
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.StdCall, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal static extern uint GetLastError();

	// Token: 0x060001F5 RID: 501 RVA: 0x00008432 File Offset: 0x00007832
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.StdCall, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern void RaiseException(uint, uint, uint, uint*);

	// Token: 0x060001F6 RID: 502 RVA: 0x000084F8 File Offset: 0x000078F8
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern int lc_new_job(global::lm_handle*, global::method, global::vendorcode7*, global::lm_handle**);

	// Token: 0x060001F7 RID: 503 RVA: 0x0000849E File Offset: 0x0000789E
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern int __CxxExceptionFilter(void*, void*, int, void*);

	// Token: 0x060001F8 RID: 504 RVA: 0x000084CE File Offset: 0x000078CE
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern void lc_free_job(global::lm_handle*);

	// Token: 0x060001F9 RID: 505 RVA: 0x000084B6 File Offset: 0x000078B6
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern void delete[](void*);

	// Token: 0x060001FA RID: 506 RVA: 0x00008420 File Offset: 0x00007820
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern void* memset(void*, int, uint);

	// Token: 0x060001FB RID: 507 RVA: 0x000084DA File Offset: 0x000078DA
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern int lc_checkout(global::lm_handle*, sbyte*, sbyte*, int, int, global::vendorcode7*, int);

	// Token: 0x060001FC RID: 508 RVA: 0x00008504 File Offset: 0x00007904
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.StdCall, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern int HeapDestroy(void*);

	// Token: 0x060001FD RID: 509 RVA: 0x000084E0 File Offset: 0x000078E0
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern global::lm_err_info* lc_err_info(global::lm_handle*);

	// Token: 0x060001FE RID: 510 RVA: 0x00008546 File Offset: 0x00007946
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.StdCall, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern ushort* SysAllocStringByteLen(sbyte*, uint);

	// Token: 0x060001FF RID: 511 RVA: 0x0000850A File Offset: 0x0000790A
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.StdCall, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern void* GetProcessHeap();

	// Token: 0x06000200 RID: 512 RVA: 0x000084A4 File Offset: 0x000078A4
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern int __CxxRegisterExceptionObject(void*, void*);

	// Token: 0x06000201 RID: 513 RVA: 0x0000853A File Offset: 0x0000793A
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.StdCall, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern int VariantCopy(global::tagVARIANT*, global::tagVARIANT*);

	// Token: 0x06000202 RID: 514 RVA: 0x00008486 File Offset: 0x00007886
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern sbyte* strcpy(sbyte*, sbyte*);

	// Token: 0x06000203 RID: 515 RVA: 0x0000845C File Offset: 0x0000785C
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern uint strlen(sbyte*);

	// Token: 0x06000204 RID: 516 RVA: 0x00008516 File Offset: 0x00007916
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.StdCall, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern int HeapFree(void*, uint, void*);

	// Token: 0x06000205 RID: 517 RVA: 0x000061AC File Offset: 0x000055AC
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern void free(void*);

	// Token: 0x06000206 RID: 518 RVA: 0x00008510 File Offset: 0x00007910
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.StdCall, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern void* HeapAlloc(void*, uint, uint);

	// Token: 0x06000207 RID: 519 RVA: 0x00008480 File Offset: 0x00007880
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern void* new[](uint);

	// Token: 0x06000208 RID: 520 RVA: 0x000084D4 File Offset: 0x000078D4
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern int lc_set_attr(global::lm_handle*, int, sbyte*);

	// Token: 0x06000209 RID: 521 RVA: 0x00008468 File Offset: 0x00007868
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern void* memmove(void*, void*, uint);

	// Token: 0x0600020A RID: 522 RVA: 0x00008456 File Offset: 0x00007856
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern void __ExceptionPtrCopy(void*, void*);

	// Token: 0x0600020B RID: 523 RVA: 0x0000854C File Offset: 0x0000794C
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern void _Xlength_error(sbyte*);

	// Token: 0x0600020C RID: 524 RVA: 0x00008552 File Offset: 0x00007952
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern void _Xout_of_range(sbyte*);

	// Token: 0x0600020D RID: 525 RVA: 0x0000847A File Offset: 0x0000787A
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern global::std.exception* {ctor}(global::std.exception*, global::std.exception*);

	// Token: 0x0600020E RID: 526 RVA: 0x0000846E File Offset: 0x0000786E
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern void {dtor}(global::std.exception*);

	// Token: 0x0600020F RID: 527 RVA: 0x00008558 File Offset: 0x00007958
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal static extern void _Xbad_alloc();

	// Token: 0x06000210 RID: 528 RVA: 0x00008564 File Offset: 0x00007964
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern sbyte* _Syserror_map(int);

	// Token: 0x06000211 RID: 529 RVA: 0x0000856A File Offset: 0x0000796A
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern sbyte* _Winerror_map(int);

	// Token: 0x06000212 RID: 530 RVA: 0x0000851C File Offset: 0x0000791C
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.StdCall, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern void* HeapReAlloc(void*, uint, void*, uint);

	// Token: 0x06000213 RID: 531 RVA: 0x000084EC File Offset: 0x000078EC
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern int lc_init_simple_composite(global::lm_handle*, int*, int);

	// Token: 0x06000214 RID: 532 RVA: 0x00008462 File Offset: 0x00007862
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern void* memcpy(void*, void*, uint);

	// Token: 0x06000215 RID: 533 RVA: 0x000084BC File Offset: 0x000078BC
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern uint wcslen(ushort*);

	// Token: 0x06000216 RID: 534 RVA: 0x00008528 File Offset: 0x00007928
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.StdCall, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern int WideCharToMultiByte(uint, uint, ushort*, int, sbyte*, int, sbyte*, int*);

	// Token: 0x06000217 RID: 535 RVA: 0x00007225 File Offset: 0x00006625
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged | global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]
	internal unsafe static extern void* _getFiberPtrId();

	// Token: 0x06000218 RID: 536 RVA: 0x00005F62 File Offset: 0x00005362
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal static extern void _amsg_exit(int);

	// Token: 0x06000219 RID: 537 RVA: 0x000061B2 File Offset: 0x000055B2
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged | global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]
	internal static extern void __security_init_cookie();

	// Token: 0x0600021A RID: 538 RVA: 0x0000852E File Offset: 0x0000792E
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.StdCall, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal static extern void Sleep(uint);

	// Token: 0x0600021B RID: 539 RVA: 0x000084C2 File Offset: 0x000078C2
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal static extern void _cexit();

	// Token: 0x0600021C RID: 540 RVA: 0x000084C8 File Offset: 0x000078C8
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern int __FrameUnwindFilter(global::_EXCEPTION_POINTERS*);

	// Token: 0x0600021D RID: 541 RVA: 0x0000678C File Offset: 0x00005B8C
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal static extern void terminate();

	// Token: 0x04000001 RID: 1 RVA: 0x000094D4 File Offset: 0x000080D4
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY01$$CBG unnamed-global-0;

	// Token: 0x04000002 RID: 2 RVA: 0x000094E8 File Offset: 0x000080E8
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY01$$CBG unnamed-global-1;

	// Token: 0x04000003 RID: 3 RVA: 0x000094EC File Offset: 0x000080EC
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY01$$CBG unnamed-global-2;

	// Token: 0x04000004 RID: 4 RVA: 0x000094F0 File Offset: 0x000080F0
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY01$$CBG unnamed-global-3;

	// Token: 0x04000005 RID: 5 RVA: 0x000094F4 File Offset: 0x000080F4
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY03$$CBG unnamed-global-4;

	// Token: 0x04000006 RID: 6 RVA: 0x000094FC File Offset: 0x000080FC
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0M@$$CBG unnamed-global-5;

	// Token: 0x04000007 RID: 7 RVA: 0x00009514 File Offset: 0x00008114
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY08$$CBG unnamed-global-6;

	// Token: 0x04000008 RID: 8 RVA: 0x00009528 File Offset: 0x00008128
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY06$$CBG unnamed-global-7;

	// Token: 0x04000009 RID: 9 RVA: 0x00009328 File Offset: 0x00007F28
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY05$$CBG unnamed-global-8;

	// Token: 0x0400000A RID: 10 RVA: 0x00009334 File Offset: 0x00007F34
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY05$$CBG unnamed-global-9;

	// Token: 0x0400000B RID: 11 RVA: 0x00009340 File Offset: 0x00007F40
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0BF@$$CBG unnamed-global-10;

	// Token: 0x0400000C RID: 12 RVA: 0x0000936C File Offset: 0x00007F6C
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY08$$CBG unnamed-global-11;

	// Token: 0x0400000D RID: 13 RVA: 0x00009380 File Offset: 0x00007F80
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY09$$CBG unnamed-global-12;

	// Token: 0x0400000E RID: 14 RVA: 0x000093B4 File Offset: 0x00007FB4
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY08$$CBG unnamed-global-13;

	// Token: 0x0400000F RID: 15 RVA: 0x000093C8 File Offset: 0x00007FC8
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY04$$CBG unnamed-global-14;

	// Token: 0x04000010 RID: 16 RVA: 0x000093D4 File Offset: 0x00007FD4
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY03$$CBG unnamed-global-15;

	// Token: 0x04000011 RID: 17 RVA: 0x000093DC File Offset: 0x00007FDC
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY08$$CBG unnamed-global-16;

	// Token: 0x04000012 RID: 18 RVA: 0x000093F0 File Offset: 0x00007FF0
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY06$$CBG unnamed-global-17;

	// Token: 0x04000013 RID: 19 RVA: 0x00009400 File Offset: 0x00008000
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY08$$CBG unnamed-global-18;

	// Token: 0x04000014 RID: 20 RVA: 0x00009414 File Offset: 0x00008014
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY07$$CBG unnamed-global-19;

	// Token: 0x04000015 RID: 21 RVA: 0x00009538 File Offset: 0x00008138
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0BA@$$CBG unnamed-global-20;

	// Token: 0x04000016 RID: 22 RVA: 0x00009558 File Offset: 0x00008158
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0M@$$CBG unnamed-global-21;

	// Token: 0x04000017 RID: 23 RVA: 0x00009570 File Offset: 0x00008170
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0L@$$CBG unnamed-global-22;

	// Token: 0x04000018 RID: 24 RVA: 0x00009588 File Offset: 0x00008188
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0BC@$$CBG unnamed-global-23;

	// Token: 0x04000019 RID: 25 RVA: 0x000095AC File Offset: 0x000081AC
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0BB@$$CBG unnamed-global-24;

	// Token: 0x0400001A RID: 26 RVA: 0x000095D0 File Offset: 0x000081D0
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0BC@$$CBG unnamed-global-25;

	// Token: 0x0400001B RID: 27 RVA: 0x000095F4 File Offset: 0x000081F4
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0BB@$$CBG unnamed-global-26;

	// Token: 0x0400001C RID: 28 RVA: 0x00009618 File Offset: 0x00008218
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0BA@$$CBG unnamed-global-27;

	// Token: 0x0400001D RID: 29 RVA: 0x00009638 File Offset: 0x00008238
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0BB@$$CBG unnamed-global-28;

	// Token: 0x0400001E RID: 30 RVA: 0x0000965C File Offset: 0x0000825C
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0BD@$$CBG unnamed-global-29;

	// Token: 0x0400001F RID: 31 RVA: 0x00009684 File Offset: 0x00008284
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0P@$$CBG unnamed-global-30;

	// Token: 0x04000020 RID: 32 RVA: 0x000096A4 File Offset: 0x000082A4
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0BA@$$CBG unnamed-global-31;

	// Token: 0x04000021 RID: 33 RVA: 0x000096C4 File Offset: 0x000082C4
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0BD@$$CBG unnamed-global-32;

	// Token: 0x04000022 RID: 34 RVA: 0x000096EC File Offset: 0x000082EC
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0BC@$$CBG unnamed-global-33;

	// Token: 0x04000023 RID: 35 RVA: 0x000092F0 File Offset: 0x00007EF0
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0N@$$CBG unnamed-global-34;

	// Token: 0x04000024 RID: 36 RVA: 0x0000930C File Offset: 0x00007F0C
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0O@$$CBG unnamed-global-35;

	// Token: 0x04000025 RID: 37 RVA: 0x00009394 File Offset: 0x00007F94
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0BA@$$CBG unnamed-global-36;

	// Token: 0x04000026 RID: 38 RVA: 0x00009424 File Offset: 0x00008024
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0P@$$CBG unnamed-global-37;

	// Token: 0x04000027 RID: 39 RVA: 0x00009444 File Offset: 0x00008044
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0M@$$CBG unnamed-global-38;

	// Token: 0x04000028 RID: 40 RVA: 0x0000945C File Offset: 0x0000805C
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0N@$$CBG unnamed-global-39;

	// Token: 0x04000029 RID: 41 RVA: 0x00009478 File Offset: 0x00008078
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0BB@$$CBG unnamed-global-40;

	// Token: 0x0400002A RID: 42 RVA: 0x0000949C File Offset: 0x0000809C
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0N@$$CBG unnamed-global-41;

	// Token: 0x0400002B RID: 43 RVA: 0x000094B8 File Offset: 0x000080B8
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0O@$$CBG unnamed-global-42;

	// Token: 0x0400002C RID: 44 RVA: 0x00009838 File Offset: 0x00008438
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY07$$CBD ??_C@_07DCLBNMLN@generic?$AA@;

	// Token: 0x0400002D RID: 45 RVA: 0x00009840 File Offset: 0x00008440
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0O@$$CBD ??_C@_0O@BFJCFAAK@unknown?5error?$AA@;

	// Token: 0x0400002E RID: 46 RVA: 0x00009850 File Offset: 0x00008450
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY08$$CBD ??_C@_08LLGCOLLL@iostream?$AA@;

	// Token: 0x0400002F RID: 47 RVA: 0x0000985C File Offset: 0x0000845C
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0BG@$$CBD ??_C@_0BG@PADBLCHM@iostream?5stream?5error?$AA@;

	// Token: 0x04000030 RID: 48 RVA: 0x00009874 File Offset: 0x00008474
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY06$$CBD ??_C@_06FHFOAHML@system?$AA@;

	// Token: 0x04000031 RID: 49 RVA: 0x000094D8 File Offset: 0x000080D8
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0N@$$CBD unnamed-global-43;

	// Token: 0x04000032 RID: 50 RVA: 0x000097F8 File Offset: 0x000083F8
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0BA@$$CBD ??_C@_0BA@JFNIOLAK@string?5too?5long?$AA@;

	// Token: 0x04000033 RID: 51 RVA: 0x00009808 File Offset: 0x00008408
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0BI@$$CBD ??_C@_0BI@CFPLBAOH@invalid?5string?5position?$AA@;

	// Token: 0x04000034 RID: 52 RVA: 0x00009820 File Offset: 0x00008420
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0BD@$$CBD ??_C@_0BD@OLBABOEK@vector?$DMT?$DO?5too?5long?$AA@;

	// Token: 0x04000035 RID: 53 RVA: 0x0002FA00 File Offset: 0x0002D800
	internal static global::$_TypeDescriptor$_extraBytes_24 ??_R0?AV_System_error@std@@@8;

	// Token: 0x04000036 RID: 54 RVA: 0x0002F154 File Offset: 0x0002CF54
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY01Q6AXXZ ??_7CFlexLicenseManager@flex_licensing@@6B@;

	// Token: 0x04000037 RID: 55 RVA: 0x0002D198 File Offset: 0x0002BD98
	internal static global::$_s__RTTIBaseClassArray$_extraBytes_4 ??_R2IAtlMemMgr@ATL@@8;

	// Token: 0x04000038 RID: 56 RVA: 0x0002FA20 File Offset: 0x0002D820
	internal static global::$_TypeDescriptor$_extraBytes_23 ??_R0?AVsystem_error@std@@@8;

	// Token: 0x04000039 RID: 57 RVA: 0x0002D430 File Offset: 0x0002C030
	internal static global::_s__RTTIBaseClassDescriptor2 ??_R1A@?0A@EA@_System_error@std@@8;

	// Token: 0x0400003A RID: 58 RVA: 0x0002FC80 File Offset: 0x0002DA80
	internal static global::<CppImplementationDetails>.$PTMType$QQtagVARIANT@@PAN ?pmField@?$CVarTypeInfo@PAN@ATL@@2QQtagVARIANT@@PANQ3@;

	// Token: 0x0400003B RID: 59 RVA: 0x00009284 File Offset: 0x00007E84
	internal static global::method ?pmField$initializer$@?$CVarTypeInfo@PAN@ATL@@2P6MXXZA;

	// Token: 0x0400003C RID: 60 RVA: 0x0002F89C File Offset: 0x0002D69C
	internal static global::$_TypeDescriptor$_extraBytes_21 ??_R0?AVCWin32Heap@ATL@@@8;

	// Token: 0x0400003D RID: 61 RVA: 0x0002FC7C File Offset: 0x0002DA7C
	internal static global::ATL.CTraceCategoryEx<1048576,0> atlTraceSecurity;

	// Token: 0x0400003E RID: 62 RVA: 0x00009220 File Offset: 0x00007E20
	internal static global::method atlTraceSecurity$initializer$;

	// Token: 0x0400003F RID: 63 RVA: 0x0002D550 File Offset: 0x0002C150
	internal static global::_s__RTTIClassHierarchyDescriptor ??_R3CFlexLicenseManager@flex_licensing@@8;

	// Token: 0x04000040 RID: 64 RVA: 0x0002D258 File Offset: 0x0002BE58
	internal static global::_s__RTTIClassHierarchyDescriptor ??_R3CAtlStringMgr@ATL@@8;

	// Token: 0x04000041 RID: 65 RVA: 0x0002FC78 File Offset: 0x0002DA78
	internal static global::<CppImplementationDetails>.$PTMType$QQtagVARIANT@@PAPAG ?pmField@?$CVarTypeInfo@PAPAG@ATL@@2QQtagVARIANT@@PAPAGQ3@;

	// Token: 0x04000042 RID: 66 RVA: 0x0000928C File Offset: 0x00007E8C
	internal static global::method ?pmField$initializer$@?$CVarTypeInfo@PAPAG@ATL@@2P6MXXZA;

	// Token: 0x04000043 RID: 67 RVA: 0x0002D52C File Offset: 0x0002C12C
	internal static global::_s__RTTIBaseClassDescriptor2 ??_R1A@?0A@EA@CFlexLicenseManager@flex_licensing@@8;

	// Token: 0x04000044 RID: 68 RVA: 0x0002FC74 File Offset: 0x0002DA74
	internal static global::ATL.CTraceCategoryEx<131072,0> atlTraceString;

	// Token: 0x04000045 RID: 69 RVA: 0x00009214 File Offset: 0x00007E14
	internal static global::method atlTraceString$initializer$;

	// Token: 0x04000046 RID: 70 RVA: 0x0002F048 File Offset: 0x0002CE48
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY02Q6AXXZ ??_7runtime_error@std@@6B@;

	// Token: 0x04000047 RID: 71 RVA: 0x0002D17C File Offset: 0x0002BD7C
	internal static global::_s__RTTIBaseClassDescriptor2 ??_R1A@?0A@EA@CWin32Heap@ATL@@8;

	// Token: 0x04000048 RID: 72 RVA: 0x0002FC48 File Offset: 0x0002DA48
	internal static global::ATL.CAtlWinModule _AtlWinModule;

	// Token: 0x04000049 RID: 73 RVA: 0x000092AC File Offset: 0x00007EAC
	internal static global::method _AtlWinModule$initializer$;

	// Token: 0x0400004A RID: 74 RVA: 0x0002D320 File Offset: 0x0002BF20
	internal static global::_s__RTTIClassHierarchyDescriptor ??_R3error_category@std@@8;

	// Token: 0x0400004B RID: 75 RVA: 0x0002D4B0 File Offset: 0x0002C0B0
	internal static global::_s__RTTIClassHierarchyDescriptor ??_R3system_error@std@@8;

	// Token: 0x0400004C RID: 76 RVA: 0x0002FC44 File Offset: 0x0002DA44
	internal static global::<CppImplementationDetails>.$PTMType$QQtagVARIANT@@PA_K ?pmField@?$CVarTypeInfo@PA_K@ATL@@2QQtagVARIANT@@PA_KQ3@;

	// Token: 0x0400004D RID: 77 RVA: 0x00009274 File Offset: 0x00007E74
	internal static global::method ?pmField$initializer$@?$CVarTypeInfo@PA_K@ATL@@2P6MXXZA;

	// Token: 0x0400004E RID: 78 RVA: 0x0002FC40 File Offset: 0x0002DA40
	internal static global::<CppImplementationDetails>.$PTMType$QQtagVARIANT@@PATtagCY@@ ?pmField@?$CVarTypeInfo@PATtagCY@@@ATL@@2QQtagVARIANT@@PATtagCY@@Q3@;

	// Token: 0x0400004F RID: 79 RVA: 0x000092A4 File Offset: 0x00007EA4
	internal static global::method ?pmField$initializer$@?$CVarTypeInfo@PATtagCY@@@ATL@@2P6MXXZA;

	// Token: 0x04000050 RID: 80 RVA: 0x0002FC3C File Offset: 0x0002DA3C
	internal static global::ATL.CTraceCategoryEx<256,0> atlTraceDBClient;

	// Token: 0x04000051 RID: 81 RVA: 0x000091F0 File Offset: 0x00007DF0
	internal static global::method atlTraceDBClient$initializer$;

	// Token: 0x04000052 RID: 82 RVA: 0x0002FC38 File Offset: 0x0002DA38
	internal static global::<CppImplementationDetails>.$PTMType$QQtagVARIANT@@PAK ?pmField@?$CVarTypeInfo@PAK@ATL@@2QQtagVARIANT@@PAKQ3@;

	// Token: 0x04000053 RID: 83 RVA: 0x00009264 File Offset: 0x00007E64
	internal static global::method ?pmField$initializer$@?$CVarTypeInfo@PAK@ATL@@2P6MXXZA;

	// Token: 0x04000054 RID: 84 RVA: 0x0002FC34 File Offset: 0x0002DA34
	internal static global::<CppImplementationDetails>.$PTMType$QQtagVARIANT@@PA_J ?pmField@?$CVarTypeInfo@PA_J@ATL@@2QQtagVARIANT@@PA_JQ3@;

	// Token: 0x04000055 RID: 85 RVA: 0x0000926C File Offset: 0x00007E6C
	internal static global::method ?pmField$initializer$@?$CVarTypeInfo@PA_J@ATL@@2P6MXXZA;

	// Token: 0x04000056 RID: 86 RVA: 0x0002D2B0 File Offset: 0x0002BEB0
	internal static global::_s__RTTIBaseClassDescriptor2 ??_R1A@?0A@EA@exception@std@@8;

	// Token: 0x04000057 RID: 87 RVA: 0x0002D2CC File Offset: 0x0002BECC
	internal static global::$_s__RTTIBaseClassArray$_extraBytes_8 ??_R2runtime_error@std@@8;

	// Token: 0x04000058 RID: 88 RVA: 0x0002D2FC File Offset: 0x0002BEFC
	internal static global::_s__RTTIBaseClassDescriptor2 ??_R1A@?0A@EA@error_category@std@@8;

	// Token: 0x04000059 RID: 89 RVA: 0x0002FC30 File Offset: 0x0002DA30
	internal static global::<CppImplementationDetails>.$PTMType$QQtagVARIANT@@PAPAUIUnknown@@ ?pmField@?$CVarTypeInfo@PAPAUIUnknown@@@ATL@@2QQtagVARIANT@@PAPAUIUnknown@@Q3@;

	// Token: 0x0400005A RID: 90 RVA: 0x00009294 File Offset: 0x00007E94
	internal static global::method ?pmField$initializer$@?$CVarTypeInfo@PAPAUIUnknown@@@ATL@@2P6MXXZA;

	// Token: 0x0400005B RID: 91 RVA: 0x0002D40C File Offset: 0x0002C00C
	internal static global::_s__RTTIClassHierarchyDescriptor ??_R3_System_error_category@std@@8;

	// Token: 0x0400005C RID: 92 RVA: 0x0002FC2C File Offset: 0x0002DA2C
	internal static global::<CppImplementationDetails>.$PTMType$QQtagVARIANT@@PAF ?pmField@?$CVarTypeInfo@PAF@ATL@@2QQtagVARIANT@@PAFQ3@;

	// Token: 0x0400005D RID: 93 RVA: 0x00009240 File Offset: 0x00007E40
	internal static global::method ?pmField$initializer$@?$CVarTypeInfo@PAF@ATL@@2P6MXXZA;

	// Token: 0x0400005E RID: 94 RVA: 0x0002FC28 File Offset: 0x0002DA28
	internal static global::<CppImplementationDetails>.$PTMType$QQtagVARIANT@@E ?pmField@?$CVarTypeInfo@E@ATL@@2QQtagVARIANT@@EQ3@;

	// Token: 0x0400005F RID: 95 RVA: 0x00009230 File Offset: 0x00007E30
	internal static global::method ?pmField$initializer$@?$CVarTypeInfo@E@ATL@@2P6MXXZA;

	// Token: 0x04000060 RID: 96 RVA: 0x0002F130 File Offset: 0x0002CF30
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY02Q6AXXZ ??_7failure@ios_base@std@@6B@;

	// Token: 0x04000061 RID: 97 RVA: 0x0002FC24 File Offset: 0x0002DA24
	internal static global::ATL.CTraceCategoryEx<16,0> atlTraceRefcount;

	// Token: 0x04000062 RID: 98 RVA: 0x000091E0 File Offset: 0x00007DE0
	internal static global::method atlTraceRefcount$initializer$;

	// Token: 0x04000063 RID: 99 RVA: 0x0002FC20 File Offset: 0x0002DA20
	internal static global::ATL.CTraceCategoryEx<4,0> atlTraceQI;

	// Token: 0x04000064 RID: 100 RVA: 0x000091D8 File Offset: 0x00007DD8
	internal static global::method atlTraceQI$initializer$;

	// Token: 0x04000065 RID: 101 RVA: 0x0002D220 File Offset: 0x0002BE20
	internal static global::_s__RTTIClassHierarchyDescriptor ??_R3IAtlStringMgr@ATL@@8;

	// Token: 0x04000066 RID: 102 RVA: 0x0002D4F0 File Offset: 0x0002C0F0
	internal static global::$_s__RTTIBaseClassArray$_extraBytes_20 ??_R2failure@ios_base@std@@8;

	// Token: 0x04000067 RID: 103 RVA: 0x0002FC1C File Offset: 0x0002DA1C
	internal static global::<CppImplementationDetails>.$PTMType$QQtagVARIANT@@PAM ?pmField@?$CVarTypeInfo@PAM@ATL@@2QQtagVARIANT@@PAMQ3@;

	// Token: 0x04000068 RID: 104 RVA: 0x0000927C File Offset: 0x00007E7C
	internal static global::method ?pmField$initializer$@?$CVarTypeInfo@PAM@ATL@@2P6MXXZA;

	// Token: 0x04000069 RID: 105 RVA: 0x0002D3FC File Offset: 0x0002BFFC
	internal static global::$_s__RTTIBaseClassArray$_extraBytes_12 ??_R2_System_error_category@std@@8;

	// Token: 0x0400006A RID: 106 RVA: 0x0002F078 File Offset: 0x0002CE78
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY06Q6AXXZ ??_7_Generic_error_category@std@@6B@;

	// Token: 0x0400006B RID: 107 RVA: 0x0002FC18 File Offset: 0x0002DA18
	internal static global::std._Iostream_error_category ?_Iostream_object@?$_Error_objects@H@std@@2V_Iostream_error_category@2@A;

	// Token: 0x0400006C RID: 108 RVA: 0x000092BC File Offset: 0x00007EBC
	internal static global::method ?_Iostream_object$initializer$@?$_Error_objects@H@std@@2P6MXXZA;

	// Token: 0x0400006D RID: 109 RVA: 0x0002F93C File Offset: 0x0002D73C
	internal static global::$_TypeDescriptor$_extraBytes_20 ??_R0?AVexception@std@@@8;

	// Token: 0x0400006E RID: 110 RVA: 0x0002FAF4 File Offset: 0x0002D8F4
	internal static uint ??_B?1??GetInstance@CAtlStringMgr@ATL@@SAPAUIAtlStringMgr@2@XZ@51;

	// Token: 0x0400006F RID: 111 RVA: 0x0002FBF0 File Offset: 0x0002D9F0
	internal static global::ATL.CAtlComModule _AtlComModule;

	// Token: 0x04000070 RID: 112 RVA: 0x000092A8 File Offset: 0x00007EA8
	internal static global::method _AtlComModule$initializer$;

	// Token: 0x04000071 RID: 113 RVA: 0x0002D1B0 File Offset: 0x0002BDB0
	internal static global::_s__RTTIBaseClassDescriptor2 ??_R1A@?0A@EA@IAtlMemMgr@ATL@@8;

	// Token: 0x04000072 RID: 114 RVA: 0x0002F014 File Offset: 0x0002CE14
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY05Q6AXXZ ??_7CWin32Heap@ATL@@6B@;

	// Token: 0x04000073 RID: 115 RVA: 0x0002FBCD File Offset: 0x0002D9CD
	internal static global::std.piecewise_construct_t piecewise_construct;

	// Token: 0x04000074 RID: 116 RVA: 0x000091C8 File Offset: 0x00007DC8
	internal static global::method piecewise_construct$initializer$;

	// Token: 0x04000075 RID: 117 RVA: 0x0002D37C File Offset: 0x0002BF7C
	internal static global::_s__RTTICompleteObjectLocator ??_R4_Generic_error_category@std@@6B@;

	// Token: 0x04000076 RID: 118 RVA: 0x0002D44C File Offset: 0x0002C04C
	internal static global::$_s__RTTIBaseClassArray$_extraBytes_12 ??_R2_System_error@std@@8;

	// Token: 0x04000077 RID: 119 RVA: 0x0002D1FC File Offset: 0x0002BDFC
	internal static global::_s__RTTIBaseClassDescriptor2 ??_R1A@?0A@EA@CAtlStringMgr@ATL@@8;

	// Token: 0x04000078 RID: 120 RVA: 0x0002F8BC File Offset: 0x0002D6BC
	internal static global::$_TypeDescriptor$_extraBytes_21 ??_R0?AUIAtlMemMgr@ATL@@@8;

	// Token: 0x04000079 RID: 121 RVA: 0x0002FBEC File Offset: 0x0002D9EC
	internal static global::ATL.CTraceCategoryEx<64,0> atlTraceControls;

	// Token: 0x0400007A RID: 122 RVA: 0x000091E8 File Offset: 0x00007DE8
	internal static global::method atlTraceControls$initializer$;

	// Token: 0x0400007B RID: 123 RVA: 0x0002F9A8 File Offset: 0x0002D7A8
	internal static global::$_TypeDescriptor$_extraBytes_35 ??_R0?AV_Iostream_error_category@std@@@8;

	// Token: 0x0400007C RID: 124 RVA: 0x0002D1D8 File Offset: 0x0002BDD8
	internal static global::_s__RTTIClassHierarchyDescriptor ??_R3CWin32Heap@ATL@@8;

	// Token: 0x0400007D RID: 125 RVA: 0x0002D344 File Offset: 0x0002BF44
	internal static global::_s__RTTIBaseClassDescriptor2 ??_R1A@?0A@EA@_Generic_error_category@std@@8;

	// Token: 0x0400007E RID: 126 RVA: 0x0002D480 File Offset: 0x0002C080
	internal static global::_s__RTTIBaseClassDescriptor2 ??_R1A@?0A@EA@system_error@std@@8;

	// Token: 0x0400007F RID: 127 RVA: 0x0002FBE8 File Offset: 0x0002D9E8
	internal static global::ATL.CTraceCategoryEx<4096,0> atlTraceAllocation;

	// Token: 0x04000080 RID: 128 RVA: 0x00009200 File Offset: 0x00007E00
	internal static global::method atlTraceAllocation$initializer$;

	// Token: 0x04000081 RID: 129 RVA: 0x0002FBE4 File Offset: 0x0002D9E4
	internal static global::<CppImplementationDetails>.$PTMType$QQtagVARIANT@@M ?pmField@?$CVarTypeInfo@M@ATL@@2QQtagVARIANT@@MQ3@;

	// Token: 0x04000082 RID: 130 RVA: 0x00009278 File Offset: 0x00007E78
	internal static global::method ?pmField$initializer$@?$CVarTypeInfo@M@ATL@@2P6MXXZA;

	// Token: 0x04000083 RID: 131 RVA: 0x0002D390 File Offset: 0x0002BF90
	internal static global::_s__RTTIBaseClassDescriptor2 ??_R1A@?0A@EA@_Iostream_error_category@std@@8;

	// Token: 0x04000084 RID: 132 RVA: 0x0002FA40 File Offset: 0x0002D840
	internal static global::$_TypeDescriptor$_extraBytes_27 ??_R0?AVfailure@ios_base@std@@@8;

	// Token: 0x04000085 RID: 133 RVA: 0x0002FBE0 File Offset: 0x0002D9E0
	internal static global::ATL.CTraceCategoryEx<262144,0> atlTraceMap;

	// Token: 0x04000086 RID: 134 RVA: 0x00009218 File Offset: 0x00007E18
	internal static global::method atlTraceMap$initializer$;

	// Token: 0x04000087 RID: 135 RVA: 0x0002F02C File Offset: 0x0002CE2C
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY06Q6AXXZ ??_7CAtlStringMgr@ATL@@6B@;

	// Token: 0x04000088 RID: 136 RVA: 0x000097D8 File Offset: 0x000083D8
	internal static global::_GUID IID_IAxWinHostWindow;

	// Token: 0x04000089 RID: 137 RVA: 0x0002D330 File Offset: 0x0002BF30
	internal static global::_s__RTTICompleteObjectLocator ??_R4error_category@std@@6B@;

	// Token: 0x0400008A RID: 138 RVA: 0x0002F91C File Offset: 0x0002D71C
	internal static global::$_TypeDescriptor$_extraBytes_24 ??_R0?AVruntime_error@std@@@8;

	// Token: 0x0400008B RID: 139 RVA: 0x0002D3CC File Offset: 0x0002BFCC
	internal static global::_s__RTTICompleteObjectLocator ??_R4_Iostream_error_category@std@@6B@;

	// Token: 0x0400008C RID: 140 RVA: 0x0002D2D8 File Offset: 0x0002BED8
	internal static global::_s__RTTIClassHierarchyDescriptor ??_R3runtime_error@std@@8;

	// Token: 0x0400008D RID: 141 RVA: 0x0002FBDC File Offset: 0x0002D9DC
	internal static global::ATL.CTraceCategoryEx<1,0> atlTraceGeneral;

	// Token: 0x0400008E RID: 142 RVA: 0x000091D0 File Offset: 0x00007DD0
	internal static global::method atlTraceGeneral$initializer$;

	// Token: 0x0400008F RID: 143 RVA: 0x000097E8 File Offset: 0x000083E8
	internal static global::_GUID IID_IAxWinHostWindowLic;

	// Token: 0x04000090 RID: 144 RVA: 0x0002D230 File Offset: 0x0002BE30
	internal static global::_s__RTTIBaseClassDescriptor2 ??_R1A@?0A@EA@IAtlStringMgr@ATL@@8;

	// Token: 0x04000091 RID: 145 RVA: 0x0002FBD8 File Offset: 0x0002D9D8
	internal static global::<CppImplementationDetails>.$PTMType$QQtagVARIANT@@PAUIUnknown@@ ?pmField@?$CVarTypeInfo@PAUIUnknown@@@ATL@@2QQtagVARIANT@@PAUIUnknown@@Q3@;

	// Token: 0x04000092 RID: 146 RVA: 0x00009290 File Offset: 0x00007E90
	internal static global::method ?pmField$initializer$@?$CVarTypeInfo@PAUIUnknown@@@ATL@@2P6MXXZA;

	// Token: 0x04000093 RID: 147 RVA: 0x0002FBD4 File Offset: 0x0002D9D4
	internal static global::ATL.CTraceCategoryEx<512,0> atlTraceDBProvider;

	// Token: 0x04000094 RID: 148 RVA: 0x000091F4 File Offset: 0x00007DF4
	internal static global::method atlTraceDBProvider$initializer$;

	// Token: 0x04000095 RID: 149 RVA: 0x00009764 File Offset: 0x00008364
	internal static global::_GUID CLSID_Registrar;

	// Token: 0x04000096 RID: 150 RVA: 0x0002D24C File Offset: 0x0002BE4C
	internal static global::$_s__RTTIBaseClassArray$_extraBytes_8 ??_R2CAtlStringMgr@ATL@@8;

	// Token: 0x04000097 RID: 151 RVA: 0x0002FBD0 File Offset: 0x0002D9D0
	internal static global::ATL.CTraceCategoryEx<32768,0> atlTraceCache;

	// Token: 0x04000098 RID: 152 RVA: 0x0000920C File Offset: 0x00007E0C
	internal static global::method atlTraceCache$initializer$;

	// Token: 0x04000099 RID: 153 RVA: 0x0002FBCC File Offset: 0x0002D9CC
	internal static global::std.allocator_arg_t allocator_arg;

	// Token: 0x0400009A RID: 154 RVA: 0x000091CC File Offset: 0x00007DCC
	internal static global::method allocator_arg$initializer$;

	// Token: 0x0400009B RID: 155 RVA: 0x0002D1E8 File Offset: 0x0002BDE8
	internal static global::_s__RTTICompleteObjectLocator ??_R4CWin32Heap@ATL@@6B@;

	// Token: 0x0400009C RID: 156 RVA: 0x0002F9D4 File Offset: 0x0002D7D4
	internal static global::$_TypeDescriptor$_extraBytes_33 ??_R0?AV_System_error_category@std@@@8;

	// Token: 0x0400009D RID: 157 RVA: 0x0002FBA4 File Offset: 0x0002D9A4
	internal static global::std._System_error_category ?_System_object@?$_Error_objects@H@std@@2V_System_error_category@2@A;

	// Token: 0x0400009E RID: 158 RVA: 0x000092C0 File Offset: 0x00007EC0
	internal static global::method ?_System_object$initializer$@?$_Error_objects@H@std@@2P6MXXZA;

	// Token: 0x0400009F RID: 159 RVA: 0x0002FBA1 File Offset: 0x0002D9A1
	internal static global::ATL.CAtlReleaseManagedClassFactories _AtlReleaseManagedClassFactories;

	// Token: 0x040000A0 RID: 160 RVA: 0x000092B0 File Offset: 0x00007EB0
	internal static global::method _AtlReleaseManagedClassFactories$initializer$;

	// Token: 0x040000A1 RID: 161 RVA: 0x0002D318 File Offset: 0x0002BF18
	internal static global::$_s__RTTIBaseClassArray$_extraBytes_4 ??_R2error_category@std@@8;

	// Token: 0x040000A2 RID: 162 RVA: 0x0002FBA0 File Offset: 0x0002D9A0
	internal static bool ?isInitialized@CAtlStringMgr@ATL@@0_NA;

	// Token: 0x040000A3 RID: 163 RVA: 0x000092B4 File Offset: 0x00007EB4
	internal static global::method ?isInitialized$initializer$@CAtlStringMgr@ATL@@0P6MXXZA;

	// Token: 0x040000A4 RID: 164 RVA: 0x0002FB9C File Offset: 0x0002D99C
	internal static global::<CppImplementationDetails>.$PTMType$QQtagVARIANT@@PAUIDispatch@@ ?pmField@?$CVarTypeInfo@PAUIDispatch@@@ATL@@2QQtagVARIANT@@PAUIDispatch@@Q3@;

	// Token: 0x040000A5 RID: 165 RVA: 0x00009298 File Offset: 0x00007E98
	internal static global::method ?pmField$initializer$@?$CVarTypeInfo@PAUIDispatch@@@ATL@@2P6MXXZA;

	// Token: 0x040000A6 RID: 166 RVA: 0x0002FB98 File Offset: 0x0002D998
	internal static global::ATL.CTraceCategoryEx<65536,0> atlTraceStencil;

	// Token: 0x040000A7 RID: 167 RVA: 0x00009210 File Offset: 0x00007E10
	internal static global::method atlTraceStencil$initializer$;

	// Token: 0x040000A8 RID: 168 RVA: 0x00009720 File Offset: 0x00008320
	internal static global::_GUID IID_IInternalConnection;

	// Token: 0x040000A9 RID: 169 RVA: 0x0002D604 File Offset: 0x0002C204
	internal static global::$_s__CatchableTypeArray$_extraBytes_4 _CTA1?AVCAtlException@ATL@@;

	// Token: 0x040000AA RID: 170 RVA: 0x0002D3E0 File Offset: 0x0002BFE0
	internal static global::_s__RTTIBaseClassDescriptor2 ??_R1A@?0A@EA@_System_error_category@std@@8;

	// Token: 0x040000AB RID: 171 RVA: 0x0002D3BC File Offset: 0x0002BFBC
	internal static global::_s__RTTIClassHierarchyDescriptor ??_R3_Iostream_error_category@std@@8;

	// Token: 0x040000AC RID: 172 RVA: 0x0002F8FC File Offset: 0x0002D6FC
	internal static global::$_TypeDescriptor$_extraBytes_24 ??_R0?AUIAtlStringMgr@ATL@@@8;

	// Token: 0x040000AD RID: 173 RVA: 0x0002D1CC File Offset: 0x0002BDCC
	internal static global::$_s__RTTIBaseClassArray$_extraBytes_8 ??_R2CWin32Heap@ATL@@8;

	// Token: 0x040000AE RID: 174 RVA: 0x0002FB94 File Offset: 0x0002D994
	internal static global::<CppImplementationDetails>.$PTMType$QQtagVARIANT@@J ?pmField@?$CVarTypeInfo@J@ATL@@2QQtagVARIANT@@JQ3@;

	// Token: 0x040000AF RID: 175 RVA: 0x00009258 File Offset: 0x00007E58
	internal static global::method ?pmField$initializer$@?$CVarTypeInfo@J@ATL@@2P6MXXZA;

	// Token: 0x040000B0 RID: 176 RVA: 0x0002FB90 File Offset: 0x0002D990
	internal static global::<CppImplementationDetails>.$PTMType$QQtagVARIANT@@I ?pmField@?$CVarTypeInfo@I@ATL@@2QQtagVARIANT@@IQ3@;

	// Token: 0x040000B1 RID: 177 RVA: 0x00009250 File Offset: 0x00007E50
	internal static global::method ?pmField$initializer$@?$CVarTypeInfo@I@ATL@@2P6MXXZA;

	// Token: 0x040000B2 RID: 178 RVA: 0x0002F8DC File Offset: 0x0002D6DC
	internal static global::$_TypeDescriptor$_extraBytes_24 ??_R0?AVCAtlStringMgr@ATL@@@8;

	// Token: 0x040000B3 RID: 179 RVA: 0x0002FB8C File Offset: 0x0002D98C
	internal static global::std._Generic_error_category ?_Generic_object@?$_Error_objects@H@std@@2V_Generic_error_category@2@A;

	// Token: 0x040000B4 RID: 180 RVA: 0x000092B8 File Offset: 0x00007EB8
	internal static global::method ?_Generic_object$initializer$@?$_Error_objects@H@std@@2P6MXXZA;

	// Token: 0x040000B5 RID: 181 RVA: 0x0002FB88 File Offset: 0x0002D988
	internal static global::ATL.CTraceCategoryEx<8,0> atlTraceRegistrar;

	// Token: 0x040000B6 RID: 182 RVA: 0x000091DC File Offset: 0x00007DDC
	internal static global::method atlTraceRegistrar$initializer$;

	// Token: 0x040000B7 RID: 183 RVA: 0x0002D298 File Offset: 0x0002BE98
	internal static global::$_s__RTTIBaseClassArray$_extraBytes_4 ??_R2exception@std@@8;

	// Token: 0x040000B8 RID: 184 RVA: 0x0002D27C File Offset: 0x0002BE7C
	internal static global::_s__RTTIBaseClassDescriptor2 ??_R1A@?0A@EA@runtime_error@std@@8;

	// Token: 0x040000B9 RID: 185 RVA: 0x000092E0 File Offset: 0x00007EE0
	internal static global::_GUID IID_IAxWinAmbientDispatch;

	// Token: 0x040000BA RID: 186 RVA: 0x0002FB84 File Offset: 0x0002D984
	internal static global::<CppImplementationDetails>.$PTMType$QQtagVARIANT@@PAG ?pmField@?$CVarTypeInfo@PAG@ATL@@2QQtagVARIANT@@PAGQ3@;

	// Token: 0x040000BB RID: 187 RVA: 0x00009288 File Offset: 0x00007E88
	internal static global::method ?pmField$initializer$@?$CVarTypeInfo@PAG@ATL@@2P6MXXZA;

	// Token: 0x040000BC RID: 188 RVA: 0x0002D2A0 File Offset: 0x0002BEA0
	internal static global::_s__RTTIClassHierarchyDescriptor ??_R3exception@std@@8;

	// Token: 0x040000BD RID: 189 RVA: 0x0002FB80 File Offset: 0x0002D980
	internal static global::<CppImplementationDetails>.$PTMType$QQtagVARIANT@@PAD ?pmField@?$CVarTypeInfo@PAD@ATL@@2QQtagVARIANT@@PADQ3@;

	// Token: 0x040000BE RID: 190 RVA: 0x00009234 File Offset: 0x00007E34
	internal static global::method ?pmField$initializer$@?$CVarTypeInfo@PAD@ATL@@2P6MXXZA;

	// Token: 0x040000BF RID: 191 RVA: 0x0002FB7C File Offset: 0x0002D97C
	internal static global::ATL.CTraceCategoryEx<8192,0> atlTraceException;

	// Token: 0x040000C0 RID: 192 RVA: 0x00009204 File Offset: 0x00007E04
	internal static global::method atlTraceException$initializer$;

	// Token: 0x040000C1 RID: 193 RVA: 0x000097B8 File Offset: 0x000083B8
	internal static global::_GUID IID_IDocHostUIHandlerDispatch;

	// Token: 0x040000C2 RID: 194 RVA: 0x0002FB78 File Offset: 0x0002D978
	internal static global::<CppImplementationDetails>.$PTMType$QQtagVARIANT@@K ?pmField@?$CVarTypeInfo@K@ATL@@2QQtagVARIANT@@KQ3@;

	// Token: 0x040000C3 RID: 195 RVA: 0x00009260 File Offset: 0x00007E60
	internal static global::method ?pmField$initializer$@?$CVarTypeInfo@K@ATL@@2P6MXXZA;

	// Token: 0x040000C4 RID: 196 RVA: 0x0002F0B0 File Offset: 0x0002CEB0
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY06Q6AXXZ ??_7_System_error_category@std@@6B@;

	// Token: 0x040000C5 RID: 197 RVA: 0x0002D4D4 File Offset: 0x0002C0D4
	internal static global::_s__RTTIBaseClassDescriptor2 ??_R1A@?0A@EA@failure@ios_base@std@@8;

	// Token: 0x040000C6 RID: 198 RVA: 0x0002F958 File Offset: 0x0002D758
	internal static global::$_TypeDescriptor$_extraBytes_25 ??_R0?AVerror_category@std@@@8;

	// Token: 0x040000C7 RID: 199 RVA: 0x0002F094 File Offset: 0x0002CE94
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY06Q6AXXZ ??_7_Iostream_error_category@std@@6B@;

	// Token: 0x040000C8 RID: 200 RVA: 0x0002F05C File Offset: 0x0002CE5C
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY06Q6AXXZ ??_7error_category@std@@6B@;

	// Token: 0x040000C9 RID: 201 RVA: 0x0002D41C File Offset: 0x0002C01C
	internal static global::_s__RTTICompleteObjectLocator ??_R4_System_error_category@std@@6B@;

	// Token: 0x040000CA RID: 202 RVA: 0x0002FB74 File Offset: 0x0002D974
	internal static global::<CppImplementationDetails>.$PTMType$QQtagVARIANT@@_J ?pmField@?$CVarTypeInfo@_J@ATL@@2QQtagVARIANT@@_JQ3@;

	// Token: 0x040000CB RID: 203 RVA: 0x00009268 File Offset: 0x00007E68
	internal static global::method ?pmField$initializer$@?$CVarTypeInfo@_J@ATL@@2P6MXXZA;

	// Token: 0x040000CC RID: 204 RVA: 0x0002FB70 File Offset: 0x0002D970
	internal static global::<CppImplementationDetails>.$PTMType$QQtagVARIANT@@H ?pmField@?$CVarTypeInfo@H@ATL@@2QQtagVARIANT@@HQ3@;

	// Token: 0x040000CD RID: 205 RVA: 0x00009248 File Offset: 0x00007E48
	internal static global::method ?pmField$initializer$@?$CVarTypeInfo@H@ATL@@2P6MXXZA;

	// Token: 0x040000CE RID: 206 RVA: 0x0002FB6C File Offset: 0x0002D96C
	internal static global::ATL.CTraceCategoryEx<16384,0> atlTraceTime;

	// Token: 0x040000CF RID: 207 RVA: 0x00009208 File Offset: 0x00007E08
	internal static global::method atlTraceTime$initializer$;

	// Token: 0x040000D0 RID: 208 RVA: 0x0002FB04 File Offset: 0x0002D904
	internal static global::ATL.CAtlStringMgr ?strMgr@?1??GetInstance@CAtlStringMgr@ATL@@SAPAUIAtlStringMgr@3@XZ@4V23@A;

	// Token: 0x040000D1 RID: 209 RVA: 0x0002FB68 File Offset: 0x0002D968
	internal static global::<CppImplementationDetails>.$PTMType$QQtagVARIANT@@D ?pmField@?$CVarTypeInfo@D@ATL@@2QQtagVARIANT@@DQ3@;

	// Token: 0x040000D2 RID: 210 RVA: 0x0000922C File Offset: 0x00007E2C
	internal static global::method ?pmField$initializer$@?$CVarTypeInfo@D@ATL@@2P6MXXZA;

	// Token: 0x040000D3 RID: 211 RVA: 0x0002D548 File Offset: 0x0002C148
	internal static global::$_s__RTTIBaseClassArray$_extraBytes_4 ??_R2CFlexLicenseManager@flex_licensing@@8;

	// Token: 0x040000D4 RID: 212 RVA: 0x000097C8 File Offset: 0x000083C8
	internal static global::_GUID LIBID_ATLLib;

	// Token: 0x040000D5 RID: 213 RVA: 0x0002F97C File Offset: 0x0002D77C
	internal static global::$_TypeDescriptor$_extraBytes_34 ??_R0?AV_Generic_error_category@std@@@8;

	// Token: 0x040000D6 RID: 214 RVA: 0x0002D508 File Offset: 0x0002C108
	internal static global::_s__RTTIClassHierarchyDescriptor ??_R3failure@ios_base@std@@8;

	// Token: 0x040000D7 RID: 215 RVA: 0x0002FB64 File Offset: 0x0002D964
	internal static global::ATL.CTraceCategoryEx<1024,0> atlTraceSnapin;

	// Token: 0x040000D8 RID: 216 RVA: 0x000091F8 File Offset: 0x00007DF8
	internal static global::method atlTraceSnapin$initializer$;

	// Token: 0x040000D9 RID: 217 RVA: 0x0002FB60 File Offset: 0x0002D960
	internal static global::<CppImplementationDetails>.$PTMType$QQtagVARIANT@@N ?pmField@?$CVarTypeInfo@N@ATL@@2QQtagVARIANT@@NQ3@;

	// Token: 0x040000DA RID: 218 RVA: 0x00009280 File Offset: 0x00007E80
	internal static global::method ?pmField$initializer$@?$CVarTypeInfo@N@ATL@@2P6MXXZA;

	// Token: 0x040000DB RID: 219 RVA: 0x0002D45C File Offset: 0x0002C05C
	internal static global::_s__RTTIClassHierarchyDescriptor ??_R3_System_error@std@@8;

	// Token: 0x040000DC RID: 220 RVA: 0x0002FB5C File Offset: 0x0002D95C
	internal static global::<CppImplementationDetails>.$PTMType$QQtagVARIANT@@PAJ ?pmField@?$CVarTypeInfo@PAJ@ATL@@2QQtagVARIANT@@PAJQ3@;

	// Token: 0x040000DD RID: 221 RVA: 0x0000925C File Offset: 0x00007E5C
	internal static global::method ?pmField$initializer$@?$CVarTypeInfo@PAJ@ATL@@2P6MXXZA;

	// Token: 0x040000DE RID: 222 RVA: 0x0002D1A0 File Offset: 0x0002BDA0
	internal static global::_s__RTTIClassHierarchyDescriptor ??_R3IAtlMemMgr@ATL@@8;

	// Token: 0x040000DF RID: 223 RVA: 0x0002FB58 File Offset: 0x0002D958
	internal static global::<CppImplementationDetails>.$PTMType$QQtagVARIANT@@G ?pmField@?$CVarTypeInfo@G@ATL@@2QQtagVARIANT@@GQ3@;

	// Token: 0x040000E0 RID: 224 RVA: 0x00009244 File Offset: 0x00007E44
	internal static global::method ?pmField$initializer$@?$CVarTypeInfo@G@ATL@@2P6MXXZA;

	// Token: 0x040000E1 RID: 225 RVA: 0x0002D218 File Offset: 0x0002BE18
	internal static global::$_s__RTTIBaseClassArray$_extraBytes_4 ??_R2IAtlStringMgr@ATL@@8;

	// Token: 0x040000E2 RID: 226 RVA: 0x0002FB54 File Offset: 0x0002D954
	internal static global::ATL.CTraceCategoryEx<32,0> atlTraceWindowing;

	// Token: 0x040000E3 RID: 227 RVA: 0x000091E4 File Offset: 0x00007DE4
	internal static global::method atlTraceWindowing$initializer$;

	// Token: 0x040000E4 RID: 228 RVA: 0x0002D60C File Offset: 0x0002C20C
	internal static global::_s__ThrowInfo _TI1?AVCAtlException@ATL@@;

	// Token: 0x040000E5 RID: 229 RVA: 0x0002FB50 File Offset: 0x0002D950
	internal static global::<CppImplementationDetails>.$PTMType$QQtagVARIANT@@PAE ?pmField@?$CVarTypeInfo@PAE@ATL@@2QQtagVARIANT@@PAEQ3@;

	// Token: 0x040000E6 RID: 230 RVA: 0x00009238 File Offset: 0x00007E38
	internal static global::method ?pmField$initializer$@?$CVarTypeInfo@PAE@ATL@@2P6MXXZA;

	// Token: 0x040000E7 RID: 231 RVA: 0x0002FB4C File Offset: 0x0002D94C
	internal static global::ATL.CTraceCategoryEx<2048,0> atlTraceNotImpl;

	// Token: 0x040000E8 RID: 232 RVA: 0x000091FC File Offset: 0x00007DFC
	internal static global::method atlTraceNotImpl$initializer$;

	// Token: 0x040000E9 RID: 233 RVA: 0x0002D560 File Offset: 0x0002C160
	internal static global::_s__RTTICompleteObjectLocator ??_R4CFlexLicenseManager@flex_licensing@@6B@;

	// Token: 0x040000EA RID: 234 RVA: 0x00009774 File Offset: 0x00008374
	internal static global::_GUID IID_IRegistrar;

	// Token: 0x040000EB RID: 235 RVA: 0x0002FB48 File Offset: 0x0002D948
	internal static global::<CppImplementationDetails>.$PTMType$QQtagVARIANT@@TtagCY@@ ?pmField@?$CVarTypeInfo@TtagCY@@@ATL@@2QQtagVARIANT@@TtagCY@@Q3@;

	// Token: 0x040000EC RID: 236 RVA: 0x000092A0 File Offset: 0x00007EA0
	internal static global::method ?pmField$initializer$@?$CVarTypeInfo@TtagCY@@@ATL@@2P6MXXZA;

	// Token: 0x040000ED RID: 237 RVA: 0x0002D360 File Offset: 0x0002BF60
	internal static global::$_s__RTTIBaseClassArray$_extraBytes_8 ??_R2_Generic_error_category@std@@8;

	// Token: 0x040000EE RID: 238 RVA: 0x0002D49C File Offset: 0x0002C09C
	internal static global::$_s__RTTIBaseClassArray$_extraBytes_16 ??_R2system_error@std@@8;

	// Token: 0x040000EF RID: 239 RVA: 0x0002FB44 File Offset: 0x0002D944
	internal static global::<CppImplementationDetails>.$PTMType$QQtagVARIANT@@PAPAUIDispatch@@ ?pmField@?$CVarTypeInfo@PAPAUIDispatch@@@ATL@@2QQtagVARIANT@@PAPAUIDispatch@@Q3@;

	// Token: 0x040000F0 RID: 240 RVA: 0x0000929C File Offset: 0x00007E9C
	internal static global::method ?pmField$initializer$@?$CVarTypeInfo@PAPAUIDispatch@@@ATL@@2P6MXXZA;

	// Token: 0x040000F1 RID: 241 RVA: 0x0002D518 File Offset: 0x0002C118
	internal static global::_s__RTTICompleteObjectLocator ??_R4failure@ios_base@std@@6B@;

	// Token: 0x040000F2 RID: 242 RVA: 0x0002FAF8 File Offset: 0x0002D8F8
	internal static global::ATL.CWin32Heap ?strHeap@?1??GetInstance@CAtlStringMgr@ATL@@SAPAUIAtlStringMgr@3@XZ@4VCWin32Heap@3@A;

	// Token: 0x040000F3 RID: 243 RVA: 0x0002D5E8 File Offset: 0x0002C1E8
	internal static global::_s__CatchableType _CT??_R0?AVCAtlException@ATL@@@84;

	// Token: 0x040000F4 RID: 244 RVA: 0x0002FB40 File Offset: 0x0002D940
	internal static global::ATL.CTraceCategoryEx<2097152,0> atlTraceSync;

	// Token: 0x040000F5 RID: 245 RVA: 0x00009224 File Offset: 0x00007E24
	internal static global::method atlTraceSync$initializer$;

	// Token: 0x040000F6 RID: 246 RVA: 0x00009710 File Offset: 0x00008310
	internal static global::_GUID IID_IAxWinAmbientDispatchEx;

	// Token: 0x040000F7 RID: 247 RVA: 0x0002FB3C File Offset: 0x0002D93C
	internal static global::ATL.CTraceCategoryEx<2,0> atlTraceCOM;

	// Token: 0x040000F8 RID: 248 RVA: 0x000091D4 File Offset: 0x00007DD4
	internal static global::method atlTraceCOM$initializer$;

	// Token: 0x040000F9 RID: 249 RVA: 0x0002D46C File Offset: 0x0002C06C
	internal static global::_s__RTTICompleteObjectLocator ??_R4_System_error@std@@6B@;

	// Token: 0x040000FA RID: 250 RVA: 0x0002FA64 File Offset: 0x0002D864
	internal static global::$_TypeDescriptor$_extraBytes_41 ??_R0?AVCFlexLicenseManager@flex_licensing@@@8;

	// Token: 0x040000FB RID: 251 RVA: 0x0002F0CC File Offset: 0x0002CECC
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY02Q6AXXZ ??_7_System_error@std@@6B@;

	// Token: 0x040000FC RID: 252 RVA: 0x00009738 File Offset: 0x00008338
	internal static ushort chLeftBracket;

	// Token: 0x040000FD RID: 253 RVA: 0x0002F000 File Offset: 0x0002CE00
	internal unsafe static void* _pAtlReleaseManagedClassFactories;

	// Token: 0x040000FE RID: 254 RVA: 0x000097B4 File Offset: 0x000083B4
	internal static int ?cbNeverDelete@CRegParser@ATL@@1HB;

	// Token: 0x040000FF RID: 255 RVA: 0x0002FAEC File Offset: 0x0002D8EC
	internal unsafe static global::ATL.IFixedStringLog* ?s_pLog@CFixedStringMgr@ATL@@2PAVIFixedStringLog@2@A;

	// Token: 0x04000100 RID: 256 RVA: 0x0002FAD4 File Offset: 0x0002D8D4
	internal static uint ?ATL_CREATE_OBJECT@CComApartment@ATL@@2IA;

	// Token: 0x04000101 RID: 257 RVA: 0x00009750 File Offset: 0x00008350
	internal unsafe static ushort* szBinaryVal;

	// Token: 0x04000102 RID: 258 RVA: 0x00009744 File Offset: 0x00008344
	internal unsafe static ushort* szStringVal;

	// Token: 0x04000103 RID: 259 RVA: 0x00009758 File Offset: 0x00008358
	internal unsafe static ushort* szForceRemove;

	// Token: 0x04000104 RID: 260 RVA: 0x00009754 File Offset: 0x00008354
	internal unsafe static ushort* szValToken;

	// Token: 0x04000105 RID: 261 RVA: 0x0002D778 File Offset: 0x0002C378
	internal unsafe static global::ATL._ATL_OBJMAP_ENTRY110* __pobjMapEntryLast;

	// Token: 0x04000106 RID: 262 RVA: 0x0002D774 File Offset: 0x0002C374
	internal unsafe static global::ATL._ATL_OBJMAP_ENTRY110* __pobjMapEntryFirst;

	// Token: 0x04000107 RID: 263 RVA: 0x0002FAF0 File Offset: 0x0002D8F0
	internal static bool DllModuleInitialized;

	// Token: 0x04000108 RID: 264 RVA: 0x0002FACD File Offset: 0x0002D8CD
	internal static bool ComModuleInitialized;

	// Token: 0x04000109 RID: 265 RVA: 0x0002FAB0 File Offset: 0x0002D8B0
	internal static global::ATL.<AtlImplementationDetails>.CComModuleHelper ComModuleHelper;

	// Token: 0x0400010A RID: 266 RVA: 0x0002FAF1 File Offset: 0x0002D8F1
	internal static bool ?m_bInitFailed@CAtlBaseModule@ATL@@2_NA;

	// Token: 0x0400010B RID: 267 RVA: 0x00009740 File Offset: 0x00008340
	internal static ushort chEquals;

	// Token: 0x0400010C RID: 268 RVA: 0x0002FADC File Offset: 0x0002D8DC
	internal static global::_GUID ?m_libid@CAtlModule@ATL@@2U_GUID@@A;

	// Token: 0x0400010D RID: 269 RVA: 0x0000975C File Offset: 0x0000835C
	internal unsafe static ushort* szNoRemove;

	// Token: 0x0400010E RID: 270 RVA: 0x0002FB38 File Offset: 0x0002D938
	internal static global::ATL.CTraceCategoryEx<128,0> atlTraceHosting;

	// Token: 0x0400010F RID: 271 RVA: 0x0002FB34 File Offset: 0x0002D934
	internal static global::ATL.CTraceCategoryEx<4194304,0> atlTraceISAPI;

	// Token: 0x04000110 RID: 272 RVA: 0x0002FB30 File Offset: 0x0002D930
	internal static global::<CppImplementationDetails>.$PTMType$QQtagVARIANT@@PAI ?pmField@?$CVarTypeInfo@PAI@ATL@@2QQtagVARIANT@@PAIQ3@;

	// Token: 0x04000111 RID: 273 RVA: 0x0002FAD8 File Offset: 0x0002D8D8
	internal unsafe static global::ATL.CAtlModule* _pAtlModule;

	// Token: 0x04000112 RID: 274 RVA: 0x0002FAC4 File Offset: 0x0002D8C4
	internal static global::method _pPerfRegFunc;

	// Token: 0x04000113 RID: 275 RVA: 0x0000973C File Offset: 0x0000833C
	internal static ushort chQuote;

	// Token: 0x04000114 RID: 276 RVA: 0x0002FACC File Offset: 0x0002D8CC
	internal static bool _AtlRegisterPerUser;

	// Token: 0x04000115 RID: 277 RVA: 0x0000974C File Offset: 0x0000834C
	internal unsafe static ushort* szDwordVal;

	// Token: 0x04000116 RID: 278 RVA: 0x0002FAC8 File Offset: 0x0002D8C8
	internal static global::method _pPerfUnRegFunc;

	// Token: 0x04000117 RID: 279 RVA: 0x0002FAD0 File Offset: 0x0002D8D0
	internal unsafe static global::ATL.CComModule* _pModule;

	// Token: 0x04000118 RID: 280 RVA: 0x00009748 File Offset: 0x00008348
	internal unsafe static ushort* multiszStringVal;

	// Token: 0x04000119 RID: 281 RVA: 0x00009730 File Offset: 0x00008330
	internal static ushort chDirSep;

	// Token: 0x0400011A RID: 282 RVA: 0x0002FB2C File Offset: 0x0002D92C
	internal static global::ATL.CTraceCategoryEx<524288,0> atlTraceUtil;

	// Token: 0x0400011B RID: 283 RVA: 0x0002FB28 File Offset: 0x0002D928
	internal static global::<CppImplementationDetails>.$PTMType$QQtagVARIANT@@_K ?pmField@?$CVarTypeInfo@_K@ATL@@2QQtagVARIANT@@_KQ3@;

	// Token: 0x0400011C RID: 284 RVA: 0x00009734 File Offset: 0x00008334
	internal static ushort chRightBracket;

	// Token: 0x0400011D RID: 285 RVA: 0x00009784 File Offset: 0x00008384
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0M@QBG ?rgszNeverDelete@CRegParser@ATL@@1QBQBGB;

	// Token: 0x0400011E RID: 286 RVA: 0x00009760 File Offset: 0x00008360
	internal unsafe static ushort* szDelete;

	// Token: 0x0400011F RID: 287 RVA: 0x0002FB24 File Offset: 0x0002D924
	internal static global::<CppImplementationDetails>.$PTMType$QQtagVARIANT@@PAH ?pmField@?$CVarTypeInfo@PAH@ATL@@2QQtagVARIANT@@PAHQ3@;

	// Token: 0x04000120 RID: 288 RVA: 0x0002FB20 File Offset: 0x0002D920
	internal static global::<CppImplementationDetails>.$PTMType$QQtagVARIANT@@F ?pmField@?$CVarTypeInfo@F@ATL@@2QQtagVARIANT@@FQ3@;

	// Token: 0x04000121 RID: 289 RVA: 0x0002FAC0 File Offset: 0x0002D8C0
	internal unsafe static global::ATL.IAtlAutoThreadModule* _pAtlAutoThreadModule;

	// Token: 0x04000122 RID: 290 RVA: 0x00009270 File Offset: 0x00007E70
	internal static global::method ?pmField$initializer$@?$CVarTypeInfo@_K@ATL@@2P6MXXZA;

	// Token: 0x04000123 RID: 291 RVA: 0x0000923C File Offset: 0x00007E3C
	internal static global::method ?pmField$initializer$@?$CVarTypeInfo@F@ATL@@2P6MXXZA;

	// Token: 0x04000124 RID: 292 RVA: 0x0002D36C File Offset: 0x0002BF6C
	internal static global::_s__RTTIClassHierarchyDescriptor ??_R3_Generic_error_category@std@@8;

	// Token: 0x04000125 RID: 293 RVA: 0x00009834 File Offset: 0x00008434
	internal static uint ?npos@?$basic_string@DU?$char_traits@D@std@@V?$allocator@D@2@@std@@2IB;

	// Token: 0x04000126 RID: 294 RVA: 0x0002F10C File Offset: 0x0002CF0C
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY02Q6AXXZ ??_7system_error@std@@6B@;

	// Token: 0x04000127 RID: 295 RVA: 0x0000921C File Offset: 0x00007E1C
	internal static global::method atlTraceUtil$initializer$;

	// Token: 0x04000128 RID: 296 RVA: 0x0002D268 File Offset: 0x0002BE68
	internal static global::_s__RTTICompleteObjectLocator ??_R4CAtlStringMgr@ATL@@6B@;

	// Token: 0x04000129 RID: 297 RVA: 0x0002D2E8 File Offset: 0x0002BEE8
	internal static global::_s__RTTICompleteObjectLocator ??_R4runtime_error@std@@6B@;

	// Token: 0x0400012A RID: 298 RVA: 0x0002F87C File Offset: 0x0002D67C
	internal static global::$_TypeDescriptor$_extraBytes_24 ??_R0?AVCAtlException@ATL@@@8;

	// Token: 0x0400012B RID: 299 RVA: 0x000091EC File Offset: 0x00007DEC
	internal static global::method atlTraceHosting$initializer$;

	// Token: 0x0400012C RID: 300 RVA: 0x00009254 File Offset: 0x00007E54
	internal static global::method ?pmField$initializer$@?$CVarTypeInfo@PAI@ATL@@2P6MXXZA;

	// Token: 0x0400012D RID: 301 RVA: 0x0002D4C0 File Offset: 0x0002C0C0
	internal static global::_s__RTTICompleteObjectLocator ??_R4system_error@std@@6B@;

	// Token: 0x0400012E RID: 302 RVA: 0x00009228 File Offset: 0x00007E28
	internal static global::method atlTraceISAPI$initializer$;

	// Token: 0x0400012F RID: 303 RVA: 0x0002D3AC File Offset: 0x0002BFAC
	internal static global::$_s__RTTIBaseClassArray$_extraBytes_12 ??_R2_Iostream_error_category@std@@8;

	// Token: 0x04000130 RID: 304 RVA: 0x0000924C File Offset: 0x00007E4C
	internal static global::method ?pmField$initializer$@?$CVarTypeInfo@PAH@ATL@@2P6MXXZA;

	// Token: 0x04000131 RID: 305 RVA: 0x00009A9C File Offset: 0x0000869C
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY01$$CBG unnamed-global-0;

	// Token: 0x04000132 RID: 306 RVA: 0x00009AA0 File Offset: 0x000086A0
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY01$$CBG unnamed-global-1;

	// Token: 0x04000133 RID: 307 RVA: 0x00009AA4 File Offset: 0x000086A4
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY01$$CBG unnamed-global-2;

	// Token: 0x04000134 RID: 308 RVA: 0x00009AA8 File Offset: 0x000086A8
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY01$$CBG unnamed-global-3;

	// Token: 0x04000135 RID: 309 RVA: 0x00009AAC File Offset: 0x000086AC
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY03$$CBG unnamed-global-4;

	// Token: 0x04000136 RID: 310 RVA: 0x00009AB4 File Offset: 0x000086B4
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0M@$$CBG unnamed-global-5;

	// Token: 0x04000137 RID: 311 RVA: 0x00009ACC File Offset: 0x000086CC
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY08$$CBG unnamed-global-6;

	// Token: 0x04000138 RID: 312 RVA: 0x00009AE0 File Offset: 0x000086E0
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY06$$CBG unnamed-global-7;

	// Token: 0x04000139 RID: 313 RVA: 0x000098D0 File Offset: 0x000084D0
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY05$$CBG unnamed-global-8;

	// Token: 0x0400013A RID: 314 RVA: 0x000098DC File Offset: 0x000084DC
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY05$$CBG unnamed-global-9;

	// Token: 0x0400013B RID: 315 RVA: 0x000098E8 File Offset: 0x000084E8
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0BF@$$CBG unnamed-global-10;

	// Token: 0x0400013C RID: 316 RVA: 0x00009914 File Offset: 0x00008514
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY08$$CBG unnamed-global-11;

	// Token: 0x0400013D RID: 317 RVA: 0x00009928 File Offset: 0x00008528
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY09$$CBG unnamed-global-12;

	// Token: 0x0400013E RID: 318 RVA: 0x0000995C File Offset: 0x0000855C
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY08$$CBG unnamed-global-13;

	// Token: 0x0400013F RID: 319 RVA: 0x00009970 File Offset: 0x00008570
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY04$$CBG unnamed-global-14;

	// Token: 0x04000140 RID: 320 RVA: 0x0000997C File Offset: 0x0000857C
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY03$$CBG unnamed-global-15;

	// Token: 0x04000141 RID: 321 RVA: 0x00009984 File Offset: 0x00008584
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY08$$CBG unnamed-global-16;

	// Token: 0x04000142 RID: 322 RVA: 0x00009998 File Offset: 0x00008598
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY06$$CBG unnamed-global-17;

	// Token: 0x04000143 RID: 323 RVA: 0x000099A8 File Offset: 0x000085A8
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY08$$CBG unnamed-global-18;

	// Token: 0x04000144 RID: 324 RVA: 0x000099BC File Offset: 0x000085BC
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY07$$CBG unnamed-global-19;

	// Token: 0x04000145 RID: 325 RVA: 0x00009AF0 File Offset: 0x000086F0
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0BA@$$CBG unnamed-global-20;

	// Token: 0x04000146 RID: 326 RVA: 0x00009B10 File Offset: 0x00008710
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0M@$$CBG unnamed-global-21;

	// Token: 0x04000147 RID: 327 RVA: 0x00009B28 File Offset: 0x00008728
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0L@$$CBG unnamed-global-22;

	// Token: 0x04000148 RID: 328 RVA: 0x00009B40 File Offset: 0x00008740
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0BC@$$CBG unnamed-global-23;

	// Token: 0x04000149 RID: 329 RVA: 0x00009B64 File Offset: 0x00008764
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0BB@$$CBG unnamed-global-24;

	// Token: 0x0400014A RID: 330 RVA: 0x00009B88 File Offset: 0x00008788
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0BC@$$CBG unnamed-global-25;

	// Token: 0x0400014B RID: 331 RVA: 0x00009BAC File Offset: 0x000087AC
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0BB@$$CBG unnamed-global-26;

	// Token: 0x0400014C RID: 332 RVA: 0x00009BD0 File Offset: 0x000087D0
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0BA@$$CBG unnamed-global-27;

	// Token: 0x0400014D RID: 333 RVA: 0x00009BF0 File Offset: 0x000087F0
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0BB@$$CBG unnamed-global-28;

	// Token: 0x0400014E RID: 334 RVA: 0x00009C14 File Offset: 0x00008814
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0BD@$$CBG unnamed-global-29;

	// Token: 0x0400014F RID: 335 RVA: 0x00009C3C File Offset: 0x0000883C
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0P@$$CBG unnamed-global-30;

	// Token: 0x04000150 RID: 336 RVA: 0x00009C5C File Offset: 0x0000885C
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0BA@$$CBG unnamed-global-31;

	// Token: 0x04000151 RID: 337 RVA: 0x00009C7C File Offset: 0x0000887C
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0BD@$$CBG unnamed-global-32;

	// Token: 0x04000152 RID: 338 RVA: 0x00009CA4 File Offset: 0x000088A4
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0BC@$$CBG unnamed-global-33;

	// Token: 0x04000153 RID: 339 RVA: 0x00009898 File Offset: 0x00008498
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0N@$$CBG unnamed-global-34;

	// Token: 0x04000154 RID: 340 RVA: 0x000098B4 File Offset: 0x000084B4
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0O@$$CBG unnamed-global-35;

	// Token: 0x04000155 RID: 341 RVA: 0x0000993C File Offset: 0x0000853C
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0BA@$$CBG unnamed-global-36;

	// Token: 0x04000156 RID: 342 RVA: 0x000099CC File Offset: 0x000085CC
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0P@$$CBG unnamed-global-37;

	// Token: 0x04000157 RID: 343 RVA: 0x000099FC File Offset: 0x000085FC
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0M@$$CBG unnamed-global-38;

	// Token: 0x04000158 RID: 344 RVA: 0x00009A14 File Offset: 0x00008614
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0N@$$CBG unnamed-global-39;

	// Token: 0x04000159 RID: 345 RVA: 0x00009A40 File Offset: 0x00008640
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0BB@$$CBG unnamed-global-40;

	// Token: 0x0400015A RID: 346 RVA: 0x00009A64 File Offset: 0x00008664
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0N@$$CBG unnamed-global-41;

	// Token: 0x0400015B RID: 347 RVA: 0x00009A80 File Offset: 0x00008680
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0O@$$CBG unnamed-global-42;

	// Token: 0x0400015C RID: 348 RVA: 0x00009CC8 File Offset: 0x000088C8
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0BA@$$CBD ??_C@_0BA@EPIGMDCL@CLicenseManager?$AA@;

	// Token: 0x0400015D RID: 349 RVA: 0x00009CD8 File Offset: 0x000088D8
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0P@$$CBD ??_C@_0P@ONCCLJAL@Flex_Licensing?$AA@;

	// Token: 0x0400015E RID: 350 RVA: 0x00009CE8 File Offset: 0x000088E8
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY02$$CBD ??_C@_02KEGNLNML@?0?5?$AA@;

	// Token: 0x0400015F RID: 351 RVA: 0x00009888 File Offset: 0x00008488
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0BA@$$CBD unnamed-global-43;

	// Token: 0x04000160 RID: 352 RVA: 0x000099EC File Offset: 0x000085EC
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0BA@$$CBD unnamed-global-44;

	// Token: 0x04000161 RID: 353 RVA: 0x00009A30 File Offset: 0x00008630
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0BA@$$CBD unnamed-global-45;

	// Token: 0x04000162 RID: 354 RVA: 0x0000987C File Offset: 0x0000847C
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0M@$$CBD unnamed-global-46;

	// Token: 0x04000163 RID: 355 RVA: 0x0002FCBD File Offset: 0x0002DABD
	internal static global::std.piecewise_construct_t piecewise_construct;

	// Token: 0x04000164 RID: 356 RVA: 0x000092C4 File Offset: 0x00007EC4
	internal static global::method piecewise_construct$initializer$;

	// Token: 0x04000165 RID: 357 RVA: 0x0002FCBC File Offset: 0x0002DABC
	internal static global::std.allocator_arg_t allocator_arg;

	// Token: 0x04000166 RID: 358 RVA: 0x000092C8 File Offset: 0x00007EC8
	internal static global::method allocator_arg$initializer$;

	// Token: 0x04000167 RID: 359 RVA: 0x0000A0E8 File Offset: 0x00008CE8
	internal static global::__s_GUID _GUID_90f1a06e_7712_4762_86b5_7a5eba6bdb02;

	// Token: 0x04000168 RID: 360 RVA: 0x0000A118 File Offset: 0x00008D18
	internal static global::__s_GUID _GUID_cb2f6722_ab3a_11d2_9c40_00c04fa30a3e;

	// Token: 0x04000169 RID: 361 RVA: 0x000092CC File Offset: 0x00007ECC
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY00Q6MPBXXZ __xc_mp_z;

	// Token: 0x0400016A RID: 362
	[global::System.Runtime.CompilerServices.FixedAddressValueType]
	internal static int ?Uninitialized@CurrentDomain@<CrtImplementationDetails>@@$$Q2HA;

	// Token: 0x0400016B RID: 363 RVA: 0x000091A8 File Offset: 0x00007DA8
	internal static global::method ?Uninitialized$initializer$@CurrentDomain@<CrtImplementationDetails>@@$$Q2P6MXXZA;

	// Token: 0x0400016C RID: 364 RVA: 0x000092D0 File Offset: 0x00007ED0
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY00Q6MPBXXZ __xi_vt_a;

	// Token: 0x0400016D RID: 365
	[global::System.Runtime.CompilerServices.FixedAddressValueType]
	internal static global::<CrtImplementationDetails>.Progress.State ?InitializedPerAppDomain@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A;

	// Token: 0x0400016E RID: 366 RVA: 0x000091BC File Offset: 0x00007DBC
	internal static global::method ?InitializedPerAppDomain$initializer$@CurrentDomain@<CrtImplementationDetails>@@$$Q2P6MXXZA;

	// Token: 0x0400016F RID: 367
	[global::System.Runtime.CompilerServices.FixedAddressValueType]
	internal static bool ?IsDefaultDomain@CurrentDomain@<CrtImplementationDetails>@@$$Q2_NA;

	// Token: 0x04000170 RID: 368 RVA: 0x000091AC File Offset: 0x00007DAC
	internal static global::method ?IsDefaultDomain$initializer$@CurrentDomain@<CrtImplementationDetails>@@$$Q2P6MXXZA;

	// Token: 0x04000171 RID: 369 RVA: 0x000091A0 File Offset: 0x00007DA0
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY00Q6MPBXXZ __xc_ma_a;

	// Token: 0x04000172 RID: 370
	[global::System.Runtime.CompilerServices.FixedAddressValueType]
	internal static global::<CrtImplementationDetails>.Progress.State ?InitializedNative@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A;

	// Token: 0x04000173 RID: 371 RVA: 0x000091B4 File Offset: 0x00007DB4
	internal static global::method ?InitializedNative$initializer$@CurrentDomain@<CrtImplementationDetails>@@$$Q2P6MXXZA;

	// Token: 0x04000174 RID: 372
	[global::System.Runtime.CompilerServices.FixedAddressValueType]
	internal static int ?Initialized@CurrentDomain@<CrtImplementationDetails>@@$$Q2HA;

	// Token: 0x04000175 RID: 373 RVA: 0x000091A4 File Offset: 0x00007DA4
	internal static global::method ?Initialized$initializer$@CurrentDomain@<CrtImplementationDetails>@@$$Q2P6MXXZA;

	// Token: 0x04000176 RID: 374 RVA: 0x000091C0 File Offset: 0x00007DC0
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY00Q6MPBXXZ __xc_ma_z;

	// Token: 0x04000177 RID: 375
	[global::System.Runtime.CompilerServices.FixedAddressValueType]
	internal static global::<CrtImplementationDetails>.Progress.State ?InitializedVtables@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A;

	// Token: 0x04000178 RID: 376 RVA: 0x000091B0 File Offset: 0x00007DB0
	internal static global::method ?InitializedVtables$initializer$@CurrentDomain@<CrtImplementationDetails>@@$$Q2P6MXXZA;

	// Token: 0x04000179 RID: 377 RVA: 0x000092D4 File Offset: 0x00007ED4
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY00Q6MPBXXZ __xi_vt_z;

	// Token: 0x0400017A RID: 378 RVA: 0x0000A108 File Offset: 0x00008D08
	internal static global::__s_GUID _GUID_cb2f6723_ab3a_11d2_9c40_00c04fa30a3e;

	// Token: 0x0400017B RID: 379
	[global::System.Runtime.CompilerServices.FixedAddressValueType]
	internal static global::<CrtImplementationDetails>.Progress.State ?InitializedPerProcess@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A;

	// Token: 0x0400017C RID: 380 RVA: 0x000091B8 File Offset: 0x00007DB8
	internal static global::method ?InitializedPerProcess$initializer$@CurrentDomain@<CrtImplementationDetails>@@$$Q2P6MXXZA;

	// Token: 0x0400017D RID: 381 RVA: 0x00030033 File Offset: 0x0002DE33
	internal static bool ?InitializedPerProcess@DefaultDomain@<CrtImplementationDetails>@@2_NA;

	// Token: 0x0400017E RID: 382 RVA: 0x00030030 File Offset: 0x0002DE30
	internal static bool ?Entered@DefaultDomain@<CrtImplementationDetails>@@2_NA;

	// Token: 0x0400017F RID: 383 RVA: 0x00030031 File Offset: 0x0002DE31
	internal static bool ?InitializedNative@DefaultDomain@<CrtImplementationDetails>@@2_NA;

	// Token: 0x04000180 RID: 384 RVA: 0x0003002C File Offset: 0x0002DE2C
	internal static int ?Count@AllDomains@<CrtImplementationDetails>@@2HA;

	// Token: 0x04000181 RID: 385 RVA: 0x00009D00 File Offset: 0x00008900
	internal static uint ?ProcessAttach@NativeDll@<CrtImplementationDetails>@@0IB;

	// Token: 0x04000182 RID: 386 RVA: 0x00009D04 File Offset: 0x00008904
	internal static uint ?ThreadAttach@NativeDll@<CrtImplementationDetails>@@0IB;

	// Token: 0x04000183 RID: 387 RVA: 0x0002F738 File Offset: 0x0002D538
	internal static global::<CrtImplementationDetails>.TriBool.State ?hasNative@DefaultDomain@<CrtImplementationDetails>@@0W4State@TriBool@2@A;

	// Token: 0x04000184 RID: 388 RVA: 0x00009CFC File Offset: 0x000088FC
	internal static uint ?ProcessDetach@NativeDll@<CrtImplementationDetails>@@0IB;

	// Token: 0x04000185 RID: 389 RVA: 0x00009D08 File Offset: 0x00008908
	internal static uint ?ThreadDetach@NativeDll@<CrtImplementationDetails>@@0IB;

	// Token: 0x04000186 RID: 390 RVA: 0x00009D0C File Offset: 0x0000890C
	internal static uint ?ProcessVerifier@NativeDll@<CrtImplementationDetails>@@0IB;

	// Token: 0x04000187 RID: 391 RVA: 0x0002F734 File Offset: 0x0002D534
	internal static global::<CrtImplementationDetails>.TriBool.State ?hasPerProcess@DefaultDomain@<CrtImplementationDetails>@@0W4State@TriBool@2@A;

	// Token: 0x04000188 RID: 392 RVA: 0x00030032 File Offset: 0x0002DE32
	internal static bool ?InitializedNativeFromCCTOR@DefaultDomain@<CrtImplementationDetails>@@2_NA;

	// Token: 0x04000189 RID: 393 RVA: 0x000091C4 File Offset: 0x00007DC4
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY00Q6MPBXXZ __xc_mp_a;

	// Token: 0x0400018A RID: 394 RVA: 0x0000A0F8 File Offset: 0x00008CF8
	internal static global::__s_GUID _GUID_90f1a06c_7712_4762_86b5_7a5eba6bdb02;

	// Token: 0x0400018B RID: 395 RVA: 0x0000A128 File Offset: 0x00008D28
	public unsafe static int** __unep@?DoNothing@DefaultDomain@<CrtImplementationDetails>@@$$FCGJPAX@Z;

	// Token: 0x0400018C RID: 396 RVA: 0x0000A12C File Offset: 0x00008D2C
	public unsafe static int** __unep@?_UninitializeDefaultDomain@LanguageSupport@<CrtImplementationDetails>@@$$FCGJPAX@Z;

	// Token: 0x0400018D RID: 397
	[global::System.Runtime.CompilerServices.FixedAddressValueType]
	internal static uint __exit_list_size_app_domain;

	// Token: 0x0400018E RID: 398
	[global::System.Runtime.CompilerServices.FixedAddressValueType]
	internal unsafe static global::method* __onexitbegin_app_domain;

	// Token: 0x0400018F RID: 399 RVA: 0x00030140 File Offset: 0x0002DF40
	internal static uint __exit_list_size;

	// Token: 0x04000190 RID: 400
	[global::System.Runtime.CompilerServices.FixedAddressValueType]
	internal unsafe static global::method* __onexitend_app_domain;

	// Token: 0x04000191 RID: 401 RVA: 0x00030138 File Offset: 0x0002DF38
	internal unsafe static global::method* __onexitbegin_m;

	// Token: 0x04000192 RID: 402 RVA: 0x0003013C File Offset: 0x0002DF3C
	internal unsafe static global::method* __onexitend_m;

	// Token: 0x04000193 RID: 403
	[global::System.Runtime.CompilerServices.FixedAddressValueType]
	internal unsafe static void* ?_lock@AtExitLock@<CrtImplementationDetails>@@$$Q0PAXA;

	// Token: 0x04000194 RID: 404
	[global::System.Runtime.CompilerServices.FixedAddressValueType]
	internal static int ?_ref_count@AtExitLock@<CrtImplementationDetails>@@$$Q0HA;

	// Token: 0x04000195 RID: 405
	internal static global::_IMAGE_DOS_HEADER __ImageBase;

	// Token: 0x04000196 RID: 406 RVA: 0x00009CF8 File Offset: 0x000088F8
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY01Q6AXXZ ??_7type_info@@6B@;

	// Token: 0x04000197 RID: 407 RVA: 0x0002FFF0 File Offset: 0x0002DDF0
	internal static global::ATL.CAtlBaseModule _AtlBaseModule;

	// Token: 0x04000198 RID: 408 RVA: 0x0000918C File Offset: 0x00007D8C
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0A@P6AXXZ __xc_z;

	// Token: 0x04000199 RID: 409 RVA: 0x00009184 File Offset: 0x00007D84
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0A@P6AXXZ __xc_a;

	// Token: 0x0400019A RID: 410 RVA: 0x00009190 File Offset: 0x00007D90
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0A@P6AHXZ __xi_a;

	// Token: 0x0400019B RID: 411 RVA: 0x00030174 File Offset: 0x0002DF74
	internal static volatile global::__enative_startup_state __native_startup_state;

	// Token: 0x0400019C RID: 412 RVA: 0x0000919C File Offset: 0x00007D9C
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0A@P6AHXZ __xi_z;

	// Token: 0x0400019D RID: 413 RVA: 0x00030170 File Offset: 0x0002DF70
	internal unsafe static volatile void* __native_startup_lock;

	// Token: 0x0400019E RID: 414 RVA: 0x0002F730 File Offset: 0x0002D530
	internal static volatile uint __native_dllmain_reason;
}
