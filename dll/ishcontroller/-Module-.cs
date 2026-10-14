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
using std;

// Token: 0x02000001 RID: 1
internal class <Module>
{
	// Token: 0x06000001 RID: 1 RVA: 0x00005228 File Offset: 0x00004628
	internal unsafe static void* __vecDelDtor(global::_com_error* A_0, uint A_0)
	{
		void* result;
		if ((A_0 & 2U) != 0U)
		{
			global::<Module>.__ehvec_dtor(A_0, 16U, *(A_0 - 4), ldftn(_com_error.{dtor}));
			if ((A_0 & 1U) != 0U)
			{
				global::<Module>.delete(A_0 - 4);
			}
			result = A_0 - 4;
		}
		else
		{
			global::<Module>._com_error.{dtor}(A_0);
			if ((A_0 & 1U) != 0U)
			{
				global::<Module>.delete(A_0);
			}
			result = A_0;
		}
		return result;
	}

	// Token: 0x06000002 RID: 2 RVA: 0x00005274 File Offset: 0x00004674
	internal unsafe static void {dtor}(global::_com_error* A_0)
	{
		*A_0 = ref global::<Module>.??_7_com_error@@6B@;
		if (*(A_0 + 8) != 0)
		{
			object obj = calli(System.UInt32 modopt(System.Runtime.CompilerServices.IsLong) modopt(System.Runtime.CompilerServices.CallConvStdcall)(System.IntPtr), *(A_0 + 8), *(*(*(A_0 + 8)) + 8));
		}
		if (*(A_0 + 12) != 0)
		{
			global::<Module>.LocalFree(*(A_0 + 12));
		}
	}

	// Token: 0x06000003 RID: 3 RVA: 0x00001400 File Offset: 0x00000800
	internal unsafe static void* @new(uint __unnamed000, void* _Where)
	{
		return _Where;
	}

	// Token: 0x06000004 RID: 4 RVA: 0x000038E4 File Offset: 0x00002CE4
	internal unsafe static void delete(void* A_0, void* A_1)
	{
	}

	// Token: 0x06000005 RID: 5 RVA: 0x00001410 File Offset: 0x00000810
	internal unsafe static uint length(sbyte* _First)
	{
		return (*(sbyte*)_First != 0) ? global::<Module>.strlen(_First) : 0;
	}

	// Token: 0x06000006 RID: 6 RVA: 0x0000142C File Offset: 0x0000082C
	internal unsafe static sbyte* copy(sbyte* _First1, sbyte* _First2, uint _Count)
	{
		return (_Count != 0U) ? global::<Module>.memcpy((void*)_First1, (void*)_First2, _Count) : _First1;
	}

	// Token: 0x06000007 RID: 7 RVA: 0x0000144C File Offset: 0x0000084C
	internal unsafe static sbyte* move(sbyte* _First1, sbyte* _First2, uint _Count)
	{
		return (_Count != 0U) ? global::<Module>.memmove((void*)_First1, (void*)_First2, _Count) : _First1;
	}

	// Token: 0x06000008 RID: 8 RVA: 0x0000146C File Offset: 0x0000086C
	internal unsafe static void assign(sbyte* _Left, sbyte* _Right)
	{
		*_Left = (byte)(*_Right);
	}

	// Token: 0x06000009 RID: 9 RVA: 0x00001000 File Offset: 0x00000400
	internal static void ??__E?A0x719a7106@piecewise_construct@std@@YMXXZ()
	{
		global::std.piecewise_construct_t piecewise_construct_t;
		initblk(ref piecewise_construct_t, 0, 1);
	}

	// Token: 0x0600000A RID: 10 RVA: 0x000038E4 File Offset: 0x00002CE4
	internal unsafe static void _Adopt(global::std._Iterator_base0* A_0, void* A_0)
	{
	}

	// Token: 0x0600000B RID: 11 RVA: 0x00001014 File Offset: 0x00000414
	internal static void ??__E?A0x719a7106@allocator_arg@std@@YMXXZ()
	{
		global::std.allocator_arg_t allocator_arg_t;
		initblk(ref allocator_arg_t, 0, 1);
	}

	// Token: 0x0600000C RID: 12 RVA: 0x00001480 File Offset: 0x00000880
	internal unsafe static void {dtor}(global::IshError* A_0)
	{
		*A_0 = ref global::<Module>.??_7IshError@@6B@;
	}

	// Token: 0x0600000D RID: 13 RVA: 0x00001494 File Offset: 0x00000894
	internal unsafe static void* __vecDelDtor(global::IshError* A_0, uint A_0)
	{
		void* result;
		if ((A_0 & 2U) != 0U)
		{
			global::<Module>.__ehvec_dtor(A_0, 8U, *(A_0 - 4), ldftn(IshError.{dtor}));
			if ((A_0 & 1U) != 0U)
			{
				global::<Module>.delete[](A_0 - 4);
			}
			result = A_0 - 4;
		}
		else
		{
			global::<Module>.IshError.{dtor}(A_0);
			if ((A_0 & 1U) != 0U)
			{
				global::<Module>.delete(A_0);
			}
			result = A_0;
		}
		return result;
	}

	// Token: 0x0600000E RID: 14 RVA: 0x000014E4 File Offset: 0x000008E4
	internal unsafe static void {dtor}(global::IshWorker* A_0)
	{
		*A_0 = ref global::<Module>.??_7IshWorker@@6B@;
		global::<Module>.IshWorker.TerminateISH(A_0);
	}

	// Token: 0x0600000F RID: 15 RVA: 0x00001500 File Offset: 0x00000900
	internal unsafe static void* __vecDelDtor(global::IshWorker* A_0, uint A_0)
	{
		void* result;
		if ((A_0 & 2U) != 0U)
		{
			global::<Module>.__ehvec_dtor(A_0, 4U, *(A_0 - 4), ldftn(IshWorker.{dtor}));
			if ((A_0 & 1U) != 0U)
			{
				global::<Module>.delete[](A_0 - 4);
			}
			result = A_0 - 4;
		}
		else
		{
			global::<Module>.IshWorker.{dtor}(A_0);
			if ((A_0 & 1U) != 0U)
			{
				global::<Module>.delete(A_0);
			}
			result = A_0;
		}
		return result;
	}

	// Token: 0x06000010 RID: 16 RVA: 0x00001028 File Offset: 0x00000428
	internal static void ??__E?pmField@?$CVarTypeInfo@D@ATL@@2QQtagVARIANT@@DQ3@@@YMXXZ()
	{
		global::<CppImplementationDetails>.$PTMType$PQtagVARIANT@@D $PTMType$PQtagVARIANT@@D = 8;
		global::<Module>.?pmField@?$CVarTypeInfo@D@ATL@@2QQtagVARIANT@@DQ3@ = $PTMType$PQtagVARIANT@@D;
	}

	// Token: 0x06000011 RID: 17 RVA: 0x00001040 File Offset: 0x00000440
	internal static void ??__E?pmField@?$CVarTypeInfo@E@ATL@@2QQtagVARIANT@@EQ3@@@YMXXZ()
	{
		global::<CppImplementationDetails>.$PTMType$PQtagVARIANT@@E $PTMType$PQtagVARIANT@@E = 8;
		global::<Module>.?pmField@?$CVarTypeInfo@E@ATL@@2QQtagVARIANT@@EQ3@ = $PTMType$PQtagVARIANT@@E;
	}

	// Token: 0x06000012 RID: 18 RVA: 0x00001058 File Offset: 0x00000458
	internal static void ??__E?pmField@?$CVarTypeInfo@PAD@ATL@@2QQtagVARIANT@@PADQ3@@@YMXXZ()
	{
		global::<CppImplementationDetails>.$PTMType$PQtagVARIANT@@PAD $PTMType$PQtagVARIANT@@PAD = 8;
		global::<Module>.?pmField@?$CVarTypeInfo@PAD@ATL@@2QQtagVARIANT@@PADQ3@ = $PTMType$PQtagVARIANT@@PAD;
	}

	// Token: 0x06000013 RID: 19 RVA: 0x00001070 File Offset: 0x00000470
	internal static void ??__E?pmField@?$CVarTypeInfo@PAE@ATL@@2QQtagVARIANT@@PAEQ3@@@YMXXZ()
	{
		global::<CppImplementationDetails>.$PTMType$PQtagVARIANT@@PAE $PTMType$PQtagVARIANT@@PAE = 8;
		global::<Module>.?pmField@?$CVarTypeInfo@PAE@ATL@@2QQtagVARIANT@@PAEQ3@ = $PTMType$PQtagVARIANT@@PAE;
	}

	// Token: 0x06000014 RID: 20 RVA: 0x00001088 File Offset: 0x00000488
	internal static void ??__E?pmField@?$CVarTypeInfo@F@ATL@@2QQtagVARIANT@@FQ3@@@YMXXZ()
	{
		global::<CppImplementationDetails>.$PTMType$PQtagVARIANT@@F $PTMType$PQtagVARIANT@@F = 8;
		global::<Module>.?pmField@?$CVarTypeInfo@F@ATL@@2QQtagVARIANT@@FQ3@ = $PTMType$PQtagVARIANT@@F;
	}

	// Token: 0x06000015 RID: 21 RVA: 0x000010A0 File Offset: 0x000004A0
	internal static void ??__E?pmField@?$CVarTypeInfo@PAF@ATL@@2QQtagVARIANT@@PAFQ3@@@YMXXZ()
	{
		global::<CppImplementationDetails>.$PTMType$PQtagVARIANT@@PAF $PTMType$PQtagVARIANT@@PAF = 8;
		global::<Module>.?pmField@?$CVarTypeInfo@PAF@ATL@@2QQtagVARIANT@@PAFQ3@ = $PTMType$PQtagVARIANT@@PAF;
	}

	// Token: 0x06000016 RID: 22 RVA: 0x000010B8 File Offset: 0x000004B8
	internal static void ??__E?pmField@?$CVarTypeInfo@G@ATL@@2QQtagVARIANT@@GQ3@@@YMXXZ()
	{
		global::<CppImplementationDetails>.$PTMType$PQtagVARIANT@@G $PTMType$PQtagVARIANT@@G = 8;
		global::<Module>.?pmField@?$CVarTypeInfo@G@ATL@@2QQtagVARIANT@@GQ3@ = $PTMType$PQtagVARIANT@@G;
	}

	// Token: 0x06000017 RID: 23 RVA: 0x000010D0 File Offset: 0x000004D0
	internal static void ??__E?pmField@?$CVarTypeInfo@H@ATL@@2QQtagVARIANT@@HQ3@@@YMXXZ()
	{
		global::<CppImplementationDetails>.$PTMType$PQtagVARIANT@@H $PTMType$PQtagVARIANT@@H = 8;
		global::<Module>.?pmField@?$CVarTypeInfo@H@ATL@@2QQtagVARIANT@@HQ3@ = $PTMType$PQtagVARIANT@@H;
	}

	// Token: 0x06000018 RID: 24 RVA: 0x000010E8 File Offset: 0x000004E8
	internal static void ??__E?pmField@?$CVarTypeInfo@PAH@ATL@@2QQtagVARIANT@@PAHQ3@@@YMXXZ()
	{
		global::<CppImplementationDetails>.$PTMType$PQtagVARIANT@@PAH $PTMType$PQtagVARIANT@@PAH = 8;
		global::<Module>.?pmField@?$CVarTypeInfo@PAH@ATL@@2QQtagVARIANT@@PAHQ3@ = $PTMType$PQtagVARIANT@@PAH;
	}

	// Token: 0x06000019 RID: 25 RVA: 0x00001100 File Offset: 0x00000500
	internal static void ??__E?pmField@?$CVarTypeInfo@I@ATL@@2QQtagVARIANT@@IQ3@@@YMXXZ()
	{
		global::<CppImplementationDetails>.$PTMType$PQtagVARIANT@@I $PTMType$PQtagVARIANT@@I = 8;
		global::<Module>.?pmField@?$CVarTypeInfo@I@ATL@@2QQtagVARIANT@@IQ3@ = $PTMType$PQtagVARIANT@@I;
	}

	// Token: 0x0600001A RID: 26 RVA: 0x00001118 File Offset: 0x00000518
	internal static void ??__E?pmField@?$CVarTypeInfo@PAI@ATL@@2QQtagVARIANT@@PAIQ3@@@YMXXZ()
	{
		global::<CppImplementationDetails>.$PTMType$PQtagVARIANT@@PAI $PTMType$PQtagVARIANT@@PAI = 8;
		global::<Module>.?pmField@?$CVarTypeInfo@PAI@ATL@@2QQtagVARIANT@@PAIQ3@ = $PTMType$PQtagVARIANT@@PAI;
	}

	// Token: 0x0600001B RID: 27 RVA: 0x00001130 File Offset: 0x00000530
	internal static void ??__E?pmField@?$CVarTypeInfo@J@ATL@@2QQtagVARIANT@@JQ3@@@YMXXZ()
	{
		global::<CppImplementationDetails>.$PTMType$PQtagVARIANT@@J $PTMType$PQtagVARIANT@@J = 8;
		global::<Module>.?pmField@?$CVarTypeInfo@J@ATL@@2QQtagVARIANT@@JQ3@ = $PTMType$PQtagVARIANT@@J;
	}

	// Token: 0x0600001C RID: 28 RVA: 0x00001148 File Offset: 0x00000548
	internal static void ??__E?pmField@?$CVarTypeInfo@PAJ@ATL@@2QQtagVARIANT@@PAJQ3@@@YMXXZ()
	{
		global::<CppImplementationDetails>.$PTMType$PQtagVARIANT@@PAJ $PTMType$PQtagVARIANT@@PAJ = 8;
		global::<Module>.?pmField@?$CVarTypeInfo@PAJ@ATL@@2QQtagVARIANT@@PAJQ3@ = $PTMType$PQtagVARIANT@@PAJ;
	}

	// Token: 0x0600001D RID: 29 RVA: 0x00001160 File Offset: 0x00000560
	internal static void ??__E?pmField@?$CVarTypeInfo@K@ATL@@2QQtagVARIANT@@KQ3@@@YMXXZ()
	{
		global::<CppImplementationDetails>.$PTMType$PQtagVARIANT@@K $PTMType$PQtagVARIANT@@K = 8;
		global::<Module>.?pmField@?$CVarTypeInfo@K@ATL@@2QQtagVARIANT@@KQ3@ = $PTMType$PQtagVARIANT@@K;
	}

	// Token: 0x0600001E RID: 30 RVA: 0x00001178 File Offset: 0x00000578
	internal static void ??__E?pmField@?$CVarTypeInfo@PAK@ATL@@2QQtagVARIANT@@PAKQ3@@@YMXXZ()
	{
		global::<CppImplementationDetails>.$PTMType$PQtagVARIANT@@PAK $PTMType$PQtagVARIANT@@PAK = 8;
		global::<Module>.?pmField@?$CVarTypeInfo@PAK@ATL@@2QQtagVARIANT@@PAKQ3@ = $PTMType$PQtagVARIANT@@PAK;
	}

	// Token: 0x0600001F RID: 31 RVA: 0x00001190 File Offset: 0x00000590
	internal static void ??__E?pmField@?$CVarTypeInfo@_J@ATL@@2QQtagVARIANT@@_JQ3@@@YMXXZ()
	{
		global::<CppImplementationDetails>.$PTMType$PQtagVARIANT@@_J $PTMType$PQtagVARIANT@@_J = 8;
		global::<Module>.?pmField@?$CVarTypeInfo@_J@ATL@@2QQtagVARIANT@@_JQ3@ = $PTMType$PQtagVARIANT@@_J;
	}

	// Token: 0x06000020 RID: 32 RVA: 0x000011A8 File Offset: 0x000005A8
	internal static void ??__E?pmField@?$CVarTypeInfo@PA_J@ATL@@2QQtagVARIANT@@PA_JQ3@@@YMXXZ()
	{
		global::<CppImplementationDetails>.$PTMType$PQtagVARIANT@@PA_J $PTMType$PQtagVARIANT@@PA_J = 8;
		global::<Module>.?pmField@?$CVarTypeInfo@PA_J@ATL@@2QQtagVARIANT@@PA_JQ3@ = $PTMType$PQtagVARIANT@@PA_J;
	}

	// Token: 0x06000021 RID: 33 RVA: 0x000011C0 File Offset: 0x000005C0
	internal static void ??__E?pmField@?$CVarTypeInfo@_K@ATL@@2QQtagVARIANT@@_KQ3@@@YMXXZ()
	{
		global::<CppImplementationDetails>.$PTMType$PQtagVARIANT@@_K $PTMType$PQtagVARIANT@@_K = 8;
		global::<Module>.?pmField@?$CVarTypeInfo@_K@ATL@@2QQtagVARIANT@@_KQ3@ = $PTMType$PQtagVARIANT@@_K;
	}

	// Token: 0x06000022 RID: 34 RVA: 0x000011D8 File Offset: 0x000005D8
	internal static void ??__E?pmField@?$CVarTypeInfo@PA_K@ATL@@2QQtagVARIANT@@PA_KQ3@@@YMXXZ()
	{
		global::<CppImplementationDetails>.$PTMType$PQtagVARIANT@@PA_K $PTMType$PQtagVARIANT@@PA_K = 8;
		global::<Module>.?pmField@?$CVarTypeInfo@PA_K@ATL@@2QQtagVARIANT@@PA_KQ3@ = $PTMType$PQtagVARIANT@@PA_K;
	}

	// Token: 0x06000023 RID: 35 RVA: 0x000011F0 File Offset: 0x000005F0
	internal static void ??__E?pmField@?$CVarTypeInfo@M@ATL@@2QQtagVARIANT@@MQ3@@@YMXXZ()
	{
		global::<CppImplementationDetails>.$PTMType$PQtagVARIANT@@M $PTMType$PQtagVARIANT@@M = 8;
		global::<Module>.?pmField@?$CVarTypeInfo@M@ATL@@2QQtagVARIANT@@MQ3@ = $PTMType$PQtagVARIANT@@M;
	}

	// Token: 0x06000024 RID: 36 RVA: 0x00001208 File Offset: 0x00000608
	internal static void ??__E?pmField@?$CVarTypeInfo@PAM@ATL@@2QQtagVARIANT@@PAMQ3@@@YMXXZ()
	{
		global::<CppImplementationDetails>.$PTMType$PQtagVARIANT@@PAM $PTMType$PQtagVARIANT@@PAM = 8;
		global::<Module>.?pmField@?$CVarTypeInfo@PAM@ATL@@2QQtagVARIANT@@PAMQ3@ = $PTMType$PQtagVARIANT@@PAM;
	}

	// Token: 0x06000025 RID: 37 RVA: 0x00001220 File Offset: 0x00000620
	internal static void ??__E?pmField@?$CVarTypeInfo@N@ATL@@2QQtagVARIANT@@NQ3@@@YMXXZ()
	{
		global::<CppImplementationDetails>.$PTMType$PQtagVARIANT@@N $PTMType$PQtagVARIANT@@N = 8;
		global::<Module>.?pmField@?$CVarTypeInfo@N@ATL@@2QQtagVARIANT@@NQ3@ = $PTMType$PQtagVARIANT@@N;
	}

	// Token: 0x06000026 RID: 38 RVA: 0x00001238 File Offset: 0x00000638
	internal static void ??__E?pmField@?$CVarTypeInfo@PAN@ATL@@2QQtagVARIANT@@PANQ3@@@YMXXZ()
	{
		global::<CppImplementationDetails>.$PTMType$PQtagVARIANT@@PAN $PTMType$PQtagVARIANT@@PAN = 8;
		global::<Module>.?pmField@?$CVarTypeInfo@PAN@ATL@@2QQtagVARIANT@@PANQ3@ = $PTMType$PQtagVARIANT@@PAN;
	}

	// Token: 0x06000027 RID: 39 RVA: 0x00001250 File Offset: 0x00000650
	internal static void ??__E?pmField@?$CVarTypeInfo@PAG@ATL@@2QQtagVARIANT@@PAGQ3@@@YMXXZ()
	{
		global::<CppImplementationDetails>.$PTMType$PQtagVARIANT@@PAG $PTMType$PQtagVARIANT@@PAG = 8;
		global::<Module>.?pmField@?$CVarTypeInfo@PAG@ATL@@2QQtagVARIANT@@PAGQ3@ = $PTMType$PQtagVARIANT@@PAG;
	}

	// Token: 0x06000028 RID: 40 RVA: 0x00001268 File Offset: 0x00000668
	internal static void ??__E?pmField@?$CVarTypeInfo@PAPAG@ATL@@2QQtagVARIANT@@PAPAGQ3@@@YMXXZ()
	{
		global::<CppImplementationDetails>.$PTMType$PQtagVARIANT@@PAPAG $PTMType$PQtagVARIANT@@PAPAG = 8;
		global::<Module>.?pmField@?$CVarTypeInfo@PAPAG@ATL@@2QQtagVARIANT@@PAPAGQ3@ = $PTMType$PQtagVARIANT@@PAPAG;
	}

	// Token: 0x06000029 RID: 41 RVA: 0x00001280 File Offset: 0x00000680
	internal static void ??__E?pmField@?$CVarTypeInfo@PAUIUnknown@@@ATL@@2QQtagVARIANT@@PAUIUnknown@@Q3@@@YMXXZ()
	{
		global::<CppImplementationDetails>.$PTMType$PQtagVARIANT@@PAUIUnknown@@ $PTMType$PQtagVARIANT@@PAUIUnknown@@ = 8;
		global::<Module>.?pmField@?$CVarTypeInfo@PAUIUnknown@@@ATL@@2QQtagVARIANT@@PAUIUnknown@@Q3@ = $PTMType$PQtagVARIANT@@PAUIUnknown@@;
	}

	// Token: 0x0600002A RID: 42 RVA: 0x00001298 File Offset: 0x00000698
	internal static void ??__E?pmField@?$CVarTypeInfo@PAPAUIUnknown@@@ATL@@2QQtagVARIANT@@PAPAUIUnknown@@Q3@@@YMXXZ()
	{
		global::<CppImplementationDetails>.$PTMType$PQtagVARIANT@@PAPAUIUnknown@@ $PTMType$PQtagVARIANT@@PAPAUIUnknown@@ = 8;
		global::<Module>.?pmField@?$CVarTypeInfo@PAPAUIUnknown@@@ATL@@2QQtagVARIANT@@PAPAUIUnknown@@Q3@ = $PTMType$PQtagVARIANT@@PAPAUIUnknown@@;
	}

	// Token: 0x0600002B RID: 43 RVA: 0x000012B0 File Offset: 0x000006B0
	internal static void ??__E?pmField@?$CVarTypeInfo@PAUIDispatch@@@ATL@@2QQtagVARIANT@@PAUIDispatch@@Q3@@@YMXXZ()
	{
		global::<CppImplementationDetails>.$PTMType$PQtagVARIANT@@PAUIDispatch@@ $PTMType$PQtagVARIANT@@PAUIDispatch@@ = 8;
		global::<Module>.?pmField@?$CVarTypeInfo@PAUIDispatch@@@ATL@@2QQtagVARIANT@@PAUIDispatch@@Q3@ = $PTMType$PQtagVARIANT@@PAUIDispatch@@;
	}

	// Token: 0x0600002C RID: 44 RVA: 0x000012C8 File Offset: 0x000006C8
	internal static void ??__E?pmField@?$CVarTypeInfo@PAPAUIDispatch@@@ATL@@2QQtagVARIANT@@PAPAUIDispatch@@Q3@@@YMXXZ()
	{
		global::<CppImplementationDetails>.$PTMType$PQtagVARIANT@@PAPAUIDispatch@@ $PTMType$PQtagVARIANT@@PAPAUIDispatch@@ = 8;
		global::<Module>.?pmField@?$CVarTypeInfo@PAPAUIDispatch@@@ATL@@2QQtagVARIANT@@PAPAUIDispatch@@Q3@ = $PTMType$PQtagVARIANT@@PAPAUIDispatch@@;
	}

	// Token: 0x0600002D RID: 45 RVA: 0x000012E0 File Offset: 0x000006E0
	internal static void ??__E?pmField@?$CVarTypeInfo@TtagCY@@@ATL@@2QQtagVARIANT@@TtagCY@@Q3@@@YMXXZ()
	{
		global::<CppImplementationDetails>.$PTMType$PQtagVARIANT@@TtagCY@@ $PTMType$PQtagVARIANT@@TtagCY@@ = 8;
		global::<Module>.?pmField@?$CVarTypeInfo@TtagCY@@@ATL@@2QQtagVARIANT@@TtagCY@@Q3@ = $PTMType$PQtagVARIANT@@TtagCY@@;
	}

	// Token: 0x0600002E RID: 46 RVA: 0x000012F8 File Offset: 0x000006F8
	internal static void ??__E?pmField@?$CVarTypeInfo@PATtagCY@@@ATL@@2QQtagVARIANT@@PATtagCY@@Q3@@@YMXXZ()
	{
		global::<CppImplementationDetails>.$PTMType$PQtagVARIANT@@PATtagCY@@ $PTMType$PQtagVARIANT@@PATtagCY@@ = 8;
		global::<Module>.?pmField@?$CVarTypeInfo@PATtagCY@@@ATL@@2QQtagVARIANT@@PATtagCY@@Q3@ = $PTMType$PQtagVARIANT@@PATtagCY@@;
	}

	// Token: 0x0600002F RID: 47 RVA: 0x00001310 File Offset: 0x00000710
	internal static void ??__E_AtlComModule@ATL@@YMXXZ()
	{
		global::<Module>.ATL.CAtlComModule.{ctor}(ref global::<Module>.ATL._AtlComModule);
		global::<Module>._atexit_m(ldftn(?A0x719a7106.??__F_AtlComModule@ATL@@YMXXZ));
	}

	// Token: 0x06000030 RID: 48 RVA: 0x000076D8 File Offset: 0x00006AD8
	internal static void ??__F_AtlComModule@ATL@@YMXXZ()
	{
		global::<Module>.ATL.CAtlComModule.{dtor}(ref global::<Module>.ATL._AtlComModule);
	}

	// Token: 0x06000031 RID: 49 RVA: 0x00003854 File Offset: 0x00002C54
	internal unsafe static global::ATL.CAtlReleaseManagedClassFactories* {ctor}(global::ATL.CAtlReleaseManagedClassFactories* A_0)
	{
		return A_0;
	}

	// Token: 0x06000032 RID: 50 RVA: 0x00001568 File Offset: 0x00000968
	internal unsafe static void {dtor}(global::ATL.CAtlReleaseManagedClassFactories* A_0)
	{
		global::<Module>.ATL.CAtlComModule.Term(ref global::<Module>.ATL._AtlComModule);
	}

	// Token: 0x06000033 RID: 51 RVA: 0x00001334 File Offset: 0x00000734
	internal static void ??__E_AtlReleaseManagedClassFactories@ATL@@YMXXZ()
	{
		global::<Module>.ATL.CAtlReleaseManagedClassFactories.{ctor}(ref global::<Module>.ATL._AtlReleaseManagedClassFactories);
		global::<Module>._atexit_m(ldftn(?A0x719a7106.??__F_AtlReleaseManagedClassFactories@ATL@@YMXXZ));
	}

	// Token: 0x06000034 RID: 52 RVA: 0x000076F0 File Offset: 0x00006AF0
	internal static void ??__F_AtlReleaseManagedClassFactories@ATL@@YMXXZ()
	{
		global::<Module>.ATL.CAtlReleaseManagedClassFactories.{dtor}(ref global::<Module>.ATL._AtlReleaseManagedClassFactories);
	}

	// Token: 0x06000035 RID: 53 RVA: 0x00001580 File Offset: 0x00000980
	internal unsafe static global::IUnknown* OpenIsh()
	{
		global::IshAdapter* ptr = global::<Module>.@new(16U);
		global::IshAdapter* ptr2;
		try
		{
			ptr2 = ((ptr == null) ? null : global::<Module>.IshAdapter.{ctor}(ptr));
		}
		catch
		{
			global::<Module>.delete((void*)ptr);
			throw;
		}
		global::IshAdapter* ptr3 = ptr2;
		global::IUnknown* ptr4 = (global::IUnknown*)ptr3;
		if (null == ptr4)
		{
			int num = -2147024882;
			global::<Module>._CxxThrowException((void*)(&num), (global::_s__ThrowInfo*)(&global::<Module>._TI1J));
		}
		return ptr4;
	}

	// Token: 0x06000036 RID: 54 RVA: 0x000015E8 File Offset: 0x000009E8
	internal unsafe static global::CIshMemory* {ctor}(global::CIshMemory* A_0)
	{
		byte* ptr = global::<Module>.new[](65535U);
		*(A_0 + 4) = ptr;
		byte* ptr2 = global::<Module>.new[](65535U);
		*A_0 = ptr2;
		return A_0;
	}

	// Token: 0x06000037 RID: 55 RVA: 0x00001614 File Offset: 0x00000A14
	internal unsafe static void {dtor}(global::CIshMemory* A_0)
	{
		if (*A_0 != 0)
		{
			global::<Module>.delete[](*A_0);
		}
		if (*(A_0 + 4) != 0)
		{
			global::<Module>.delete[](*(A_0 + 4));
		}
	}

	// Token: 0x06000038 RID: 56 RVA: 0x0000163C File Offset: 0x00000A3C
	internal unsafe static global::IUnknown* CreateMemory()
	{
		global::CIshMemory* ptr = global::<Module>.@new(8U);
		global::CIshMemory* result;
		try
		{
			result = ((ptr == null) ? null : global::<Module>.CIshMemory.{ctor}(ptr));
		}
		catch
		{
			global::<Module>.delete((void*)ptr);
			throw;
		}
		return result;
	}

	// Token: 0x06000039 RID: 57 RVA: 0x0000168C File Offset: 0x00000A8C
	internal unsafe static global::IUnknown* GetIshMemoryData(global::IUnknown* ishMem)
	{
		return *(int*)ishMem;
	}

	// Token: 0x0600003A RID: 58 RVA: 0x0000270C File Offset: 0x00001B0C
	internal unsafe static void ReleaseIshMemory(global::IUnknown* ishMem)
	{
		if (ishMem != null)
		{
			if (ishMem != null)
			{
				void* ptr = global::<Module>.CIshMemory.__delDtor(ishMem, 1U);
			}
		}
	}

	// Token: 0x0600003B RID: 59 RVA: 0x00003674 File Offset: 0x00002A74
	internal unsafe static void* __delDtor(global::CIshMemory* A_0, uint A_0)
	{
		global::<Module>.CIshMemory.{dtor}(A_0);
		if ((A_0 & 1U) != 0U)
		{
			global::<Module>.delete(A_0);
		}
		return A_0;
	}

	// Token: 0x0600003C RID: 60 RVA: 0x000016A0 File Offset: 0x00000AA0
	internal unsafe static void ReadISH(global::IUnknown* pIsh, ushort ish_type, ushort ish_id, byte** pData, ulong* pData_Size)
	{
		uint num = 65535;
		byte* ptr = global::<Module>.new[](65535U);
		global::<Module>.IshAdapter.ReadISH(pIsh, ish_type, ish_id, ptr, (uint*)(&num));
		byte* ptr2 = global::<Module>.new[](num);
		*pData = ptr2;
		if (*pData == 0)
		{
			int num2 = -2147467259;
			global::<Module>._CxxThrowException((void*)(&num2), (global::_s__ThrowInfo*)(&global::<Module>._TI1J));
		}
		global::<Module>.memcpy(*pData, (void*)ptr, num);
		*pData_Size = (long)num;
	}

	// Token: 0x0600003D RID: 61 RVA: 0x00001700 File Offset: 0x00000B00
	internal unsafe static void WriteISH(global::IUnknown* pIsh, global::IUnknown* ishMem, ushort ish_type, ushort ish_id, ulong data_size)
	{
		byte* ptr = global::<Module>.new[]((uint)data_size);
		if (ptr == null)
		{
			int num = -2147467259;
			global::<Module>._CxxThrowException((void*)(&num), (global::_s__ThrowInfo*)(&global::<Module>._TI1J));
		}
		global::<Module>.memcpy((void*)ptr, *(int*)ishMem, (uint)data_size);
		global::<Module>.IshAdapter.WriteISH(pIsh, ish_type, ref ish_id, ptr, (uint)data_size);
		global::<Module>.delete[]((void*)ptr);
		global::<Module>.memset(*(int*)ishMem, 0, (uint)data_size);
	}

	// Token: 0x0600003E RID: 62 RVA: 0x0000175C File Offset: 0x00000B5C
	internal unsafe static void initByteToWrite(global::IUnknown* ishMem, ulong size)
	{
		global::<Module>.memset(*(int*)ishMem, 0, (uint)size);
	}

	// Token: 0x0600003F RID: 63 RVA: 0x00001778 File Offset: 0x00000B78
	internal unsafe static void copyByteToBuff(global::IUnknown* ishMem, byte* ByteToCopy, int offset)
	{
		global::<Module>.memcpy(*(int*)ishMem + offset, (void*)ByteToCopy, 1U);
	}

	// Token: 0x06000040 RID: 64 RVA: 0x00001794 File Offset: 0x00000B94
	[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
	internal unsafe static bool TerminateISH(global::IUnknown* pIsh)
	{
		return global::<Module>.IshAdapter.TerminateISH(pIsh);
	}

	// Token: 0x06000041 RID: 65 RVA: 0x000017B0 File Offset: 0x00000BB0
	internal unsafe static void ReadVitualMemory(global::IUnknown* pIsh, uint start_address, uint end_address, byte** output)
	{
		byte* ptr = null;
		global::<Module>.IshAdapter.ReadVitualMemory(pIsh, start_address, end_address, ptr);
		global::<Module>.memcpy(*output, (void*)ptr, end_address - start_address);
	}

	// Token: 0x06000042 RID: 66 RVA: 0x000017D8 File Offset: 0x00000BD8
	internal unsafe static void EraseVirtualMemory(global::IUnknown* pIsh, uint start_address, uint end_address)
	{
		global::<Module>.IshAdapter.EraseVirtualMemory(pIsh, start_address, end_address);
	}

	// Token: 0x06000043 RID: 67 RVA: 0x000017F0 File Offset: 0x00000BF0
	internal unsafe static ushort initVirtualFlashMemory(global::IUnknown* pIsh)
	{
		return 1;
	}

	// Token: 0x06000044 RID: 68 RVA: 0x00001800 File Offset: 0x00000C00
	internal unsafe static void initDefaultISHHeaderPartition(global::IUnknown* pIsh, uint start_address)
	{
	}

	// Token: 0x06000045 RID: 69 RVA: 0x00001810 File Offset: 0x00000C10
	internal unsafe static void BuildDefaultISHHeaders(global::IUnknown* pIsh)
	{
		global::<Module>.IshAdapter.BuildDefaultISHHeaders(pIsh);
	}

	// Token: 0x06000046 RID: 70 RVA: 0x00001828 File Offset: 0x00000C28
	internal unsafe static void SetBlockISHVersion(global::IUnknown* pIsh, ulong eblock_address, ulong base_address, ushort ish_version)
	{
		global::<Module>.IshAdapter.SetBlockISHVersion(pIsh, (uint)(eblock_address + base_address), ish_version);
	}

	// Token: 0x06000047 RID: 71 RVA: 0x00001844 File Offset: 0x00000C44
	internal unsafe static void GetBlockISHVersion(global::IUnknown* pIsh, ulong eblock_address, ulong base_address, ushort* ish_version)
	{
		global::<Module>.IshAdapter.GetBlockISHVersion(pIsh, (uint)(eblock_address + base_address), ish_version);
	}

	// Token: 0x06000048 RID: 72 RVA: 0x00001860 File Offset: 0x00000C60
	internal unsafe static void EraseCodeplugVirtualMemory(global::IUnknown* pIsh)
	{
		global::<Module>.IshAdapter.EraseCodeplugVirtualMemory(pIsh);
	}

	// Token: 0x06000049 RID: 73 RVA: 0x00002734 File Offset: 0x00001B34
	internal unsafe static void ReadAllIsh(global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* section_id)
	{
		global::<Module>.std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>.{dtor}(section_id);
	}

	// Token: 0x0600004A RID: 74 RVA: 0x00002748 File Offset: 0x00001B48
	[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
	internal unsafe static bool get_psdt_location(global::IUnknown* pIsh, global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* section_id_str, uint* start_address, uint* end_address)
	{
		bool result;
		try
		{
			uint* ptr = null;
			uint* ptr2 = null;
			if (ptr != null && ptr2 != null)
			{
				global::<Module>.IshAdapter.GetSectionAddress(pIsh, section_id_str, ptr, ptr2);
			}
			*start_address = ptr;
			*end_address = ptr2;
			result = true;
		}
		catch
		{
			global::<Module>.___CxxCallUnwindDtor(ldftn(std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>.{dtor}), (void*)section_id_str);
			throw;
		}
		global::<Module>.std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>.{dtor}(section_id_str);
		return result;
	}

	// Token: 0x0600004B RID: 75 RVA: 0x00001878 File Offset: 0x00000C78
	internal unsafe static void WriteAllISH(global::IUnknown* pIsh, ushort ish_version)
	{
	}

	// Token: 0x0600004C RID: 76 RVA: 0x000027AC File Offset: 0x00001BAC
	[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
	internal unsafe static bool is_in_section(global::IUnknown* pIsh, ushort ISH_Type, global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* part)
	{
		bool result;
		try
		{
			global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020> basic_string<char,std::char_traits<char>,std::allocator<char>_u0020>;
			global::<Module>.std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>.{ctor}(ref basic_string<char,std::char_traits<char>,std::allocator<char>_u0020>, (sbyte*)(&global::<Module>.?A0x719a7106.unnamed-global-43));
			try
			{
				result = (global::<Module>.IshAdapter.IsSectionType(pIsh, part, ISH_Type) != null);
			}
			catch
			{
				global::<Module>.___CxxCallUnwindDtor(ldftn(std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>.{dtor}), (void*)(&basic_string<char,std::char_traits<char>,std::allocator<char>_u0020>));
				throw;
			}
			global::<Module>.std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>.{dtor}(ref basic_string<char,std::char_traits<char>,std::allocator<char>_u0020>);
		}
		catch
		{
			global::<Module>.___CxxCallUnwindDtor(ldftn(std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>.{dtor}), (void*)part);
			throw;
		}
		global::<Module>.std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>.{dtor}(part);
		return result;
	}

	// Token: 0x0600004D RID: 77 RVA: 0x00001888 File Offset: 0x00000C88
	internal unsafe static void Close_Ish(global::IUnknown* pIsh)
	{
		if (pIsh != null)
		{
			global::<Module>.delete((void*)pIsh);
			pIsh = null;
		}
	}

	// Token: 0x0600004E RID: 78 RVA: 0x000029B4 File Offset: 0x00001DB4
	internal unsafe static void read_psdt(global::IUnknown* pIsh, global::method pfAddIshInfo, ulong* CPLGStart, ulong* CPLGEnd, ulong* SECPStart, ulong* SECPEnd, ulong* TUNEStart, ulong* TUNEEnd, ulong* UCLAStart, ulong* UCLAEnd, ulong base_address)
	{
		global::std.vector<PSDT_RECORD\u0020*,std::allocator<PSDT_RECORD\u0020*>\u0020> vector<PSDT_RECORD_u0020*,std::allocator<PSDT_RECORD_u0020*>_u0020>;
		global::<Module>.IshAdapter.ReadPSDTRecord(pIsh, &vector<PSDT_RECORD_u0020*,std::allocator<PSDT_RECORD_u0020*>_u0020>);
		try
		{
			*CPLGStart = 0L;
			*CPLGEnd = 0L;
			*SECPStart = 0L;
			*SECPEnd = 0L;
			*TUNEStart = 0L;
			*TUNEEnd = 0L;
			*UCLAStart = 0L;
			*UCLAEnd = 0L;
			global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020> basic_string<char,std::char_traits<char>,std::allocator<char>_u0020>;
			global::<Module>.std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>.{ctor}(ref basic_string<char,std::char_traits<char>,std::allocator<char>_u0020>, (sbyte*)(&global::<Module>.?A0x719a7106.unnamed-global-44));
			try
			{
				global::std._Vector_const_iterator<std::_Vector_val<std::_Simple_types<PSDT_RECORD\u0020*>\u0020>\u0020> vector_const_iterator<std::_Vector_val<std::_Simple_types<PSDT_RECORD_u0020*>_u0020>_u0020>;
				global::std._Vector_iterator<std::_Vector_val<std::_Simple_types<PSDT_RECORD\u0020*>\u0020>\u0020> vector_iterator<std::_Vector_val<std::_Simple_types<PSDT_RECORD_u0020*>_u0020>_u0020>;
				cpblk(ref vector_const_iterator<std::_Vector_val<std::_Simple_types<PSDT_RECORD_u0020*>_u0020>_u0020>, global::<Module>.std.vector<PSDT_RECORD\u0020*,std::allocator<PSDT_RECORD\u0020*>\u0020>.begin(ref vector<PSDT_RECORD_u0020*,std::allocator<PSDT_RECORD_u0020*>_u0020>, &vector_iterator<std::_Vector_val<std::_Simple_types<PSDT_RECORD_u0020*>_u0020>_u0020>), 4);
				global::std._Vector_iterator<std::_Vector_val<std::_Simple_types<PSDT_RECORD\u0020*>\u0020>\u0020> vector_iterator<std::_Vector_val<std::_Simple_types<PSDT_RECORD_u0020*>_u0020>_u0020>2;
				while (global::<Module>.std._Vector_const_iterator<std::_Vector_val<std::_Simple_types<PSDT_RECORD\u0020*>\u0020>\u0020>.!=(ref vector_const_iterator<std::_Vector_val<std::_Simple_types<PSDT_RECORD_u0020*>_u0020>_u0020>, global::<Module>.std.vector<PSDT_RECORD\u0020*,std::allocator<PSDT_RECORD\u0020*>\u0020>.end(ref vector<PSDT_RECORD_u0020*,std::allocator<PSDT_RECORD_u0020*>_u0020>, &vector_iterator<std::_Vector_val<std::_Simple_types<PSDT_RECORD_u0020*>_u0020>_u0020>2)) != null)
				{
					uint num = *(*global::<Module>.std._Vector_const_iterator<std::_Vector_val<std::_Simple_types<PSDT_RECORD\u0020*>\u0020>\u0020>.*(ref vector_const_iterator<std::_Vector_val<std::_Simple_types<PSDT_RECORD_u0020*>_u0020>_u0020>));
					global::<Module>.IshAdapter.GetSectionID(pIsh, (uint)(base_address + (ulong)(*(*global::<Module>.std._Vector_const_iterator<std::_Vector_val<std::_Simple_types<PSDT_RECORD\u0020*>\u0020>\u0020>.*(ref vector_const_iterator<std::_Vector_val<std::_Simple_types<PSDT_RECORD_u0020*>_u0020>_u0020>) + 4))), ref basic_string<char,std::char_traits<char>,std::allocator<char>_u0020>);
					sbyte* ptr = global::<Module>.std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>.c_str(ref basic_string<char,std::char_traits<char>,std::allocator<char>_u0020>);
					if (global::<Module>.?A0x719a7106.unnamed-global-45 == *(sbyte*)ptr || global::<Module>.?A0x719a7106.unnamed-global-46 == *(sbyte*)ptr)
					{
						sbyte* ptr2 = ref global::<Module>.?A0x719a7106.unnamed-global-45 + 1;
						sbyte* ptr3 = ref global::<Module>.?A0x719a7106.unnamed-global-46 + 1;
						ptr += 1 / sizeof(sbyte);
						if (*(sbyte*)ptr2 == *(sbyte*)ptr || *(sbyte*)ptr3 == *(sbyte*)ptr)
						{
							ptr2 += 1 / sizeof(sbyte);
							ptr3 += 1 / sizeof(sbyte);
							ptr += 1 / sizeof(sbyte);
							if (*(sbyte*)ptr2 == *(sbyte*)ptr || *(sbyte*)ptr3 == *(sbyte*)ptr)
							{
								ptr2 += 1 / sizeof(sbyte);
								ptr3 += 1 / sizeof(sbyte);
								ptr += 1 / sizeof(sbyte);
								if (*(sbyte*)ptr2 == *(sbyte*)ptr || *(sbyte*)ptr3 == *(sbyte*)ptr)
								{
									*CPLGStart = (long)((ulong)(*(*global::<Module>.std._Vector_const_iterator<std::_Vector_val<std::_Simple_types<PSDT_RECORD\u0020*>\u0020>\u0020>.*(ref vector_const_iterator<std::_Vector_val<std::_Simple_types<PSDT_RECORD_u0020*>_u0020>_u0020>) + 4)));
									*CPLGEnd = (long)((ulong)(*(*global::<Module>.std._Vector_const_iterator<std::_Vector_val<std::_Simple_types<PSDT_RECORD\u0020*>\u0020>\u0020>.*(ref vector_const_iterator<std::_Vector_val<std::_Simple_types<PSDT_RECORD_u0020*>_u0020>_u0020>) + 8)));
								}
							}
						}
					}
					if (global::<Module>.?A0x719a7106.unnamed-global-47 == *(sbyte*)ptr || global::<Module>.?A0x719a7106.unnamed-global-48 == *(sbyte*)ptr)
					{
						sbyte* ptr4 = ref global::<Module>.?A0x719a7106.unnamed-global-47 + 1;
						sbyte* ptr5 = ref global::<Module>.?A0x719a7106.unnamed-global-48 + 1;
						ptr += 1 / sizeof(sbyte);
						if (*(sbyte*)ptr4 == *(sbyte*)ptr || *(sbyte*)ptr5 == *(sbyte*)ptr)
						{
							ptr4 += 1 / sizeof(sbyte);
							ptr5 += 1 / sizeof(sbyte);
							ptr += 1 / sizeof(sbyte);
							if (*(sbyte*)ptr4 == *(sbyte*)ptr || *(sbyte*)ptr5 == *(sbyte*)ptr)
							{
								ptr4 += 1 / sizeof(sbyte);
								ptr5 += 1 / sizeof(sbyte);
								ptr += 1 / sizeof(sbyte);
								if (*(sbyte*)ptr4 == *(sbyte*)ptr || *(sbyte*)ptr5 == *(sbyte*)ptr)
								{
									*SECPStart = (long)((ulong)(*(*global::<Module>.std._Vector_const_iterator<std::_Vector_val<std::_Simple_types<PSDT_RECORD\u0020*>\u0020>\u0020>.*(ref vector_const_iterator<std::_Vector_val<std::_Simple_types<PSDT_RECORD_u0020*>_u0020>_u0020>) + 4)));
									*SECPEnd = (long)((ulong)(*(*global::<Module>.std._Vector_const_iterator<std::_Vector_val<std::_Simple_types<PSDT_RECORD\u0020*>\u0020>\u0020>.*(ref vector_const_iterator<std::_Vector_val<std::_Simple_types<PSDT_RECORD_u0020*>_u0020>_u0020>) + 8)));
								}
							}
						}
					}
					if (global::<Module>.?A0x719a7106.unnamed-global-49 == *(sbyte*)ptr || global::<Module>.?A0x719a7106.unnamed-global-50 == *(sbyte*)ptr)
					{
						sbyte* ptr6 = ref global::<Module>.?A0x719a7106.unnamed-global-49 + 1;
						sbyte* ptr7 = ref global::<Module>.?A0x719a7106.unnamed-global-50 + 1;
						ptr += 1 / sizeof(sbyte);
						if (*(sbyte*)ptr6 == *(sbyte*)ptr || *(sbyte*)ptr7 == *(sbyte*)ptr)
						{
							ptr6 += 1 / sizeof(sbyte);
							ptr7 += 1 / sizeof(sbyte);
							ptr += 1 / sizeof(sbyte);
							if (*(sbyte*)ptr6 == *(sbyte*)ptr || *(sbyte*)ptr7 == *(sbyte*)ptr)
							{
								ptr6 += 1 / sizeof(sbyte);
								ptr7 += 1 / sizeof(sbyte);
								ptr += 1 / sizeof(sbyte);
								if (*(sbyte*)ptr6 == *(sbyte*)ptr || *(sbyte*)ptr7 == *(sbyte*)ptr)
								{
									*TUNEStart = (long)((ulong)(*(*global::<Module>.std._Vector_const_iterator<std::_Vector_val<std::_Simple_types<PSDT_RECORD\u0020*>\u0020>\u0020>.*(ref vector_const_iterator<std::_Vector_val<std::_Simple_types<PSDT_RECORD_u0020*>_u0020>_u0020>) + 4)));
									*TUNEEnd = (long)((ulong)(*(*global::<Module>.std._Vector_const_iterator<std::_Vector_val<std::_Simple_types<PSDT_RECORD\u0020*>\u0020>\u0020>.*(ref vector_const_iterator<std::_Vector_val<std::_Simple_types<PSDT_RECORD_u0020*>_u0020>_u0020>) + 8)));
								}
							}
						}
					}
					if (global::<Module>.?A0x719a7106.unnamed-global-51 == *(sbyte*)ptr)
					{
						sbyte* ptr8 = ref global::<Module>.?A0x719a7106.unnamed-global-51 + 1;
						ptr += 1 / sizeof(sbyte);
						if (*(sbyte*)ptr8 == *(sbyte*)ptr)
						{
							ptr8 += 1 / sizeof(sbyte);
							ptr += 1 / sizeof(sbyte);
							if (*(sbyte*)ptr8 == *(sbyte*)ptr)
							{
								ptr8 += 1 / sizeof(sbyte);
								ptr += 1 / sizeof(sbyte);
								if (*(sbyte*)ptr8 == *(sbyte*)ptr)
								{
									*UCLAStart = (long)((ulong)(*(*global::<Module>.std._Vector_const_iterator<std::_Vector_val<std::_Simple_types<PSDT_RECORD\u0020*>\u0020>\u0020>.*(ref vector_const_iterator<std::_Vector_val<std::_Simple_types<PSDT_RECORD_u0020*>_u0020>_u0020>) + 4)));
									*UCLAEnd = (long)((ulong)(*(*global::<Module>.std._Vector_const_iterator<std::_Vector_val<std::_Simple_types<PSDT_RECORD\u0020*>\u0020>\u0020>.*(ref vector_const_iterator<std::_Vector_val<std::_Simple_types<PSDT_RECORD_u0020*>_u0020>_u0020>) + 8)));
								}
							}
						}
					}
					global::<Module>.std._Vector_const_iterator<std::_Vector_val<std::_Simple_types<PSDT_RECORD\u0020*>\u0020>\u0020>.++(ref vector_const_iterator<std::_Vector_val<std::_Simple_types<PSDT_RECORD_u0020*>_u0020>_u0020>);
				}
				global::std._Vector_const_iterator<std::_Vector_val<std::_Simple_types<PSDT_RECORD\u0020*>\u0020>\u0020> vector_const_iterator<std::_Vector_val<std::_Simple_types<PSDT_RECORD_u0020*>_u0020>_u0020>2;
				global::std._Vector_iterator<std::_Vector_val<std::_Simple_types<PSDT_RECORD\u0020*>\u0020>\u0020> vector_iterator<std::_Vector_val<std::_Simple_types<PSDT_RECORD_u0020*>_u0020>_u0020>3;
				cpblk(ref vector_const_iterator<std::_Vector_val<std::_Simple_types<PSDT_RECORD_u0020*>_u0020>_u0020>2, global::<Module>.std.vector<PSDT_RECORD\u0020*,std::allocator<PSDT_RECORD\u0020*>\u0020>.begin(ref vector<PSDT_RECORD_u0020*,std::allocator<PSDT_RECORD_u0020*>_u0020>, &vector_iterator<std::_Vector_val<std::_Simple_types<PSDT_RECORD_u0020*>_u0020>_u0020>3), 4);
				global::std._Vector_iterator<std::_Vector_val<std::_Simple_types<PSDT_RECORD\u0020*>\u0020>\u0020> vector_iterator<std::_Vector_val<std::_Simple_types<PSDT_RECORD_u0020*>_u0020>_u0020>4;
				while (global::<Module>.std._Vector_const_iterator<std::_Vector_val<std::_Simple_types<PSDT_RECORD\u0020*>\u0020>\u0020>.!=(ref vector_const_iterator<std::_Vector_val<std::_Simple_types<PSDT_RECORD_u0020*>_u0020>_u0020>2, global::<Module>.std.vector<PSDT_RECORD\u0020*,std::allocator<PSDT_RECORD\u0020*>\u0020>.end(ref vector<PSDT_RECORD_u0020*,std::allocator<PSDT_RECORD_u0020*>_u0020>, &vector_iterator<std::_Vector_val<std::_Simple_types<PSDT_RECORD_u0020*>_u0020>_u0020>4)) != null)
				{
					global::<Module>.delete(*global::<Module>.std._Vector_const_iterator<std::_Vector_val<std::_Simple_types<PSDT_RECORD\u0020*>\u0020>\u0020>.*(ref vector_const_iterator<std::_Vector_val<std::_Simple_types<PSDT_RECORD_u0020*>_u0020>_u0020>2));
					global::<Module>.std._Vector_const_iterator<std::_Vector_val<std::_Simple_types<PSDT_RECORD\u0020*>\u0020>\u0020>.++(ref vector_const_iterator<std::_Vector_val<std::_Simple_types<PSDT_RECORD_u0020*>_u0020>_u0020>2);
				}
				global::<Module>.std.vector<PSDT_RECORD\u0020*,std::allocator<PSDT_RECORD\u0020*>\u0020>.clear(ref vector<PSDT_RECORD_u0020*,std::allocator<PSDT_RECORD_u0020*>_u0020>);
				if (pfAddIshInfo != null)
				{
					global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020> basic_string<char,std::char_traits<char>,std::allocator<char>_u0020>2;
					global::<Module>.std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>.{ctor}(ref basic_string<char,std::char_traits<char>,std::allocator<char>_u0020>2, (sbyte*)(&global::<Module>.?A0x719a7106.unnamed-global-52));
					try
					{
						global::<Module>.IshAdapter.GetSectionID(pIsh, (uint)(base_address + (ulong)(*CPLGStart)), ref basic_string<char,std::char_traits<char>,std::allocator<char>_u0020>2);
						sbyte* ptr9 = global::<Module>.std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>.c_str(ref basic_string<char,std::char_traits<char>,std::allocator<char>_u0020>2);
						global::std.vector<ISHITEM,std::allocator<ISHITEM>\u0020> vector<ISHITEM,std::allocator<ISHITEM>_u0020>;
						global::<Module>.std.vector<ISHITEM,std::allocator<ISHITEM>\u0020>.{ctor}(ref vector<ISHITEM,std::allocator<ISHITEM>_u0020>);
						try
						{
							global::<Module>.std.vector<ISHITEM,std::allocator<ISHITEM>\u0020>.clear(ref vector<ISHITEM,std::allocator<ISHITEM>_u0020>);
							global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020> basic_string<char,std::char_traits<char>,std::allocator<char>_u0020>3;
							global::<Module>.std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>.{ctor}(ref basic_string<char,std::char_traits<char>,std::allocator<char>_u0020>3, ptr9);
							try
							{
								global::std.vector<ISHITEM,std::allocator<ISHITEM>\u0020> vector<ISHITEM,std::allocator<ISHITEM>_u0020>2;
								global::std.vector<ISHITEM,std::allocator<ISHITEM>\u0020>* right = global::<Module>.IshAdapter.ReadAllISH(pIsh, &vector<ISHITEM,std::allocator<ISHITEM>_u0020>2, ref basic_string<char,std::char_traits<char>,std::allocator<char>_u0020>3);
								try
								{
									global::<Module>.std.vector<ISHITEM,std::allocator<ISHITEM>\u0020>.=(ref vector<ISHITEM,std::allocator<ISHITEM>_u0020>, right);
								}
								catch
								{
									global::<Module>.___CxxCallUnwindDtor(ldftn(std.vector<ISHITEM,std::allocator<ISHITEM>\u0020>.{dtor}), (void*)(&vector<ISHITEM,std::allocator<ISHITEM>_u0020>2));
									throw;
								}
								global::<Module>.std.vector<ISHITEM,std::allocator<ISHITEM>\u0020>.{dtor}(ref vector<ISHITEM,std::allocator<ISHITEM>_u0020>2);
							}
							catch
							{
								global::<Module>.___CxxCallUnwindDtor(ldftn(std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>.{dtor}), (void*)(&basic_string<char,std::char_traits<char>,std::allocator<char>_u0020>3));
								throw;
							}
							global::<Module>.std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>.{dtor}(ref basic_string<char,std::char_traits<char>,std::allocator<char>_u0020>3);
							global::std._Vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020> vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>_u0020>_u0020>;
							global::<Module>.std.vector<ISHITEM,std::allocator<ISHITEM>\u0020>.begin(ref vector<ISHITEM,std::allocator<ISHITEM>_u0020>, &vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>_u0020>_u0020>);
							global::CIshList cishList;
							global::<Module>.CIshList.{ctor}(ref cishList);
							try
							{
								global::<Module>.CIshList.SetPFAddIshInfo(ref cishList, pfAddIshInfo);
								global::std._Vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020> vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>_u0020>_u0020>2;
								while (global::<Module>.std._Vector_const_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020>.!=(ref vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>_u0020>_u0020>, global::<Module>.std.vector<ISHITEM,std::allocator<ISHITEM>\u0020>.end(ref vector<ISHITEM,std::allocator<ISHITEM>_u0020>, &vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>_u0020>_u0020>2)) != null)
								{
									ushort info = *(global::<Module>.std._Vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020>.->(ref vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>_u0020>_u0020>) + 24);
									ushort info2 = *(global::<Module>.std._Vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020>.->(ref vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>_u0020>_u0020>) + 26);
									global::<Module>.CIshList.AddIshInfo(ref cishList, info);
									global::<Module>.CIshList.AddIshInfo(ref cishList, info2);
									global::std._Vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020> vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>_u0020>_u0020>3;
									global::<Module>.std._Vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020>.++(ref vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>_u0020>_u0020>, &vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>_u0020>_u0020>3, 0);
								}
								global::<Module>.std.vector<ISHITEM,std::allocator<ISHITEM>\u0020>.clear(ref vector<ISHITEM,std::allocator<ISHITEM>_u0020>);
								global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020> basic_string<char,std::char_traits<char>,std::allocator<char>_u0020>4;
								global::<Module>.std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>.{ctor}(ref basic_string<char,std::char_traits<char>,std::allocator<char>_u0020>4, (sbyte*)(&global::<Module>.?A0x719a7106.unnamed-global-53));
								try
								{
									global::<Module>.IshAdapter.GetSectionID(pIsh, (uint)(base_address + (ulong)(*TUNEStart)), ref basic_string<char,std::char_traits<char>,std::allocator<char>_u0020>4);
									sbyte* ptr10 = global::<Module>.std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>.c_str(ref basic_string<char,std::char_traits<char>,std::allocator<char>_u0020>4);
									global::std.vector<ISHITEM,std::allocator<ISHITEM>\u0020> vector<ISHITEM,std::allocator<ISHITEM>_u0020>3;
									global::<Module>.std.vector<ISHITEM,std::allocator<ISHITEM>\u0020>.{ctor}(ref vector<ISHITEM,std::allocator<ISHITEM>_u0020>3);
									try
									{
										global::<Module>.std.vector<ISHITEM,std::allocator<ISHITEM>\u0020>.clear(ref vector<ISHITEM,std::allocator<ISHITEM>_u0020>3);
										global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020> basic_string<char,std::char_traits<char>,std::allocator<char>_u0020>5;
										global::<Module>.std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>.{ctor}(ref basic_string<char,std::char_traits<char>,std::allocator<char>_u0020>5, ptr10);
										try
										{
											global::std.vector<ISHITEM,std::allocator<ISHITEM>\u0020> vector<ISHITEM,std::allocator<ISHITEM>_u0020>4;
											global::std.vector<ISHITEM,std::allocator<ISHITEM>\u0020>* right2 = global::<Module>.IshAdapter.ReadAllISH(pIsh, &vector<ISHITEM,std::allocator<ISHITEM>_u0020>4, ref basic_string<char,std::char_traits<char>,std::allocator<char>_u0020>5);
											try
											{
												global::<Module>.std.vector<ISHITEM,std::allocator<ISHITEM>\u0020>.=(ref vector<ISHITEM,std::allocator<ISHITEM>_u0020>3, right2);
											}
											catch
											{
												global::<Module>.___CxxCallUnwindDtor(ldftn(std.vector<ISHITEM,std::allocator<ISHITEM>\u0020>.{dtor}), (void*)(&vector<ISHITEM,std::allocator<ISHITEM>_u0020>4));
												throw;
											}
											global::<Module>.std.vector<ISHITEM,std::allocator<ISHITEM>\u0020>.{dtor}(ref vector<ISHITEM,std::allocator<ISHITEM>_u0020>4);
										}
										catch
										{
											global::<Module>.___CxxCallUnwindDtor(ldftn(std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>.{dtor}), (void*)(&basic_string<char,std::char_traits<char>,std::allocator<char>_u0020>5));
											throw;
										}
										global::<Module>.std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>.{dtor}(ref basic_string<char,std::char_traits<char>,std::allocator<char>_u0020>5);
										global::std._Vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020> vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>_u0020>_u0020>4;
										cpblk(ref vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>_u0020>_u0020>, global::<Module>.std.vector<ISHITEM,std::allocator<ISHITEM>\u0020>.begin(ref vector<ISHITEM,std::allocator<ISHITEM>_u0020>3, &vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>_u0020>_u0020>4), 4);
										global::std._Vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020> vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>_u0020>_u0020>5;
										while (global::<Module>.std._Vector_const_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020>.!=(ref vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>_u0020>_u0020>, global::<Module>.std.vector<ISHITEM,std::allocator<ISHITEM>\u0020>.end(ref vector<ISHITEM,std::allocator<ISHITEM>_u0020>3, &vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>_u0020>_u0020>5)) != null)
										{
											ushort info3 = *(global::<Module>.std._Vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020>.->(ref vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>_u0020>_u0020>) + 24);
											ushort info4 = *(global::<Module>.std._Vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020>.->(ref vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>_u0020>_u0020>) + 26);
											global::<Module>.CIshList.AddIshInfo(ref cishList, info3);
											global::<Module>.CIshList.AddIshInfo(ref cishList, info4);
											global::std._Vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020> vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>_u0020>_u0020>6;
											global::<Module>.std._Vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020>.++(ref vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>_u0020>_u0020>, &vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>_u0020>_u0020>6, 0);
										}
										global::<Module>.std.vector<ISHITEM,std::allocator<ISHITEM>\u0020>.clear(ref vector<ISHITEM,std::allocator<ISHITEM>_u0020>3);
										global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020> basic_string<char,std::char_traits<char>,std::allocator<char>_u0020>6;
										global::<Module>.std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>.{ctor}(ref basic_string<char,std::char_traits<char>,std::allocator<char>_u0020>6, (sbyte*)(&global::<Module>.?A0x719a7106.unnamed-global-54));
										try
										{
											global::<Module>.IshAdapter.GetSectionID(pIsh, (uint)(base_address + (ulong)(*SECPStart)), ref basic_string<char,std::char_traits<char>,std::allocator<char>_u0020>6);
											sbyte* ptr11 = global::<Module>.std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>.c_str(ref basic_string<char,std::char_traits<char>,std::allocator<char>_u0020>6);
											global::std.vector<ISHITEM,std::allocator<ISHITEM>\u0020> vector<ISHITEM,std::allocator<ISHITEM>_u0020>5;
											global::<Module>.std.vector<ISHITEM,std::allocator<ISHITEM>\u0020>.{ctor}(ref vector<ISHITEM,std::allocator<ISHITEM>_u0020>5);
											try
											{
												global::<Module>.std.vector<ISHITEM,std::allocator<ISHITEM>\u0020>.clear(ref vector<ISHITEM,std::allocator<ISHITEM>_u0020>5);
												global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020> basic_string<char,std::char_traits<char>,std::allocator<char>_u0020>7;
												global::<Module>.std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>.{ctor}(ref basic_string<char,std::char_traits<char>,std::allocator<char>_u0020>7, ptr11);
												try
												{
													global::std.vector<ISHITEM,std::allocator<ISHITEM>\u0020> vector<ISHITEM,std::allocator<ISHITEM>_u0020>6;
													global::std.vector<ISHITEM,std::allocator<ISHITEM>\u0020>* right3 = global::<Module>.IshAdapter.ReadAllISH(pIsh, &vector<ISHITEM,std::allocator<ISHITEM>_u0020>6, ref basic_string<char,std::char_traits<char>,std::allocator<char>_u0020>7);
													try
													{
														global::<Module>.std.vector<ISHITEM,std::allocator<ISHITEM>\u0020>.=(ref vector<ISHITEM,std::allocator<ISHITEM>_u0020>5, right3);
													}
													catch
													{
														global::<Module>.___CxxCallUnwindDtor(ldftn(std.vector<ISHITEM,std::allocator<ISHITEM>\u0020>.{dtor}), (void*)(&vector<ISHITEM,std::allocator<ISHITEM>_u0020>6));
														throw;
													}
													global::<Module>.std.vector<ISHITEM,std::allocator<ISHITEM>\u0020>.{dtor}(ref vector<ISHITEM,std::allocator<ISHITEM>_u0020>6);
												}
												catch
												{
													global::<Module>.___CxxCallUnwindDtor(ldftn(std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>.{dtor}), (void*)(&basic_string<char,std::char_traits<char>,std::allocator<char>_u0020>7));
													throw;
												}
												global::<Module>.std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>.{dtor}(ref basic_string<char,std::char_traits<char>,std::allocator<char>_u0020>7);
												global::std._Vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020> vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>_u0020>_u0020>7;
												cpblk(ref vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>_u0020>_u0020>, global::<Module>.std.vector<ISHITEM,std::allocator<ISHITEM>\u0020>.begin(ref vector<ISHITEM,std::allocator<ISHITEM>_u0020>5, &vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>_u0020>_u0020>7), 4);
												global::std._Vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020> vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>_u0020>_u0020>8;
												while (global::<Module>.std._Vector_const_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020>.!=(ref vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>_u0020>_u0020>, global::<Module>.std.vector<ISHITEM,std::allocator<ISHITEM>\u0020>.end(ref vector<ISHITEM,std::allocator<ISHITEM>_u0020>5, &vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>_u0020>_u0020>8)) != null)
												{
													ushort info5 = *(global::<Module>.std._Vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020>.->(ref vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>_u0020>_u0020>) + 24);
													ushort info6 = *(global::<Module>.std._Vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020>.->(ref vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>_u0020>_u0020>) + 26);
													global::<Module>.CIshList.AddIshInfo(ref cishList, info5);
													global::<Module>.CIshList.AddIshInfo(ref cishList, info6);
													global::std._Vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020> vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>_u0020>_u0020>9;
													global::<Module>.std._Vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020>.++(ref vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>_u0020>_u0020>, &vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>_u0020>_u0020>9, 0);
												}
												global::<Module>.std.vector<ISHITEM,std::allocator<ISHITEM>\u0020>.clear(ref vector<ISHITEM,std::allocator<ISHITEM>_u0020>5);
												if (*UCLAStart != 0L)
												{
													if (*UCLAEnd != 0L)
													{
														global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020> basic_string<char,std::char_traits<char>,std::allocator<char>_u0020>8;
														global::<Module>.std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>.{ctor}(ref basic_string<char,std::char_traits<char>,std::allocator<char>_u0020>8, (sbyte*)(&global::<Module>.?A0x719a7106.unnamed-global-55));
														try
														{
															global::<Module>.IshAdapter.GetSectionID(pIsh, (uint)(base_address + (ulong)(*UCLAStart)), ref basic_string<char,std::char_traits<char>,std::allocator<char>_u0020>8);
															sbyte* ptr12 = global::<Module>.std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>.c_str(ref basic_string<char,std::char_traits<char>,std::allocator<char>_u0020>8);
															global::std.vector<ISHITEM,std::allocator<ISHITEM>\u0020> vector<ISHITEM,std::allocator<ISHITEM>_u0020>7;
															global::<Module>.std.vector<ISHITEM,std::allocator<ISHITEM>\u0020>.{ctor}(ref vector<ISHITEM,std::allocator<ISHITEM>_u0020>7);
															try
															{
																global::<Module>.std.vector<ISHITEM,std::allocator<ISHITEM>\u0020>.clear(ref vector<ISHITEM,std::allocator<ISHITEM>_u0020>7);
																global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020> basic_string<char,std::char_traits<char>,std::allocator<char>_u0020>9;
																global::<Module>.std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>.{ctor}(ref basic_string<char,std::char_traits<char>,std::allocator<char>_u0020>9, ptr12);
																try
																{
																	global::std.vector<ISHITEM,std::allocator<ISHITEM>\u0020> vector<ISHITEM,std::allocator<ISHITEM>_u0020>8;
																	global::std.vector<ISHITEM,std::allocator<ISHITEM>\u0020>* right4 = global::<Module>.IshAdapter.ReadAllISH(pIsh, &vector<ISHITEM,std::allocator<ISHITEM>_u0020>8, ref basic_string<char,std::char_traits<char>,std::allocator<char>_u0020>9);
																	try
																	{
																		global::<Module>.std.vector<ISHITEM,std::allocator<ISHITEM>\u0020>.=(ref vector<ISHITEM,std::allocator<ISHITEM>_u0020>7, right4);
																	}
																	catch
																	{
																		global::<Module>.___CxxCallUnwindDtor(ldftn(std.vector<ISHITEM,std::allocator<ISHITEM>\u0020>.{dtor}), (void*)(&vector<ISHITEM,std::allocator<ISHITEM>_u0020>8));
																		throw;
																	}
																	global::<Module>.std.vector<ISHITEM,std::allocator<ISHITEM>\u0020>.{dtor}(ref vector<ISHITEM,std::allocator<ISHITEM>_u0020>8);
																}
																catch
																{
																	global::<Module>.___CxxCallUnwindDtor(ldftn(std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>.{dtor}), (void*)(&basic_string<char,std::char_traits<char>,std::allocator<char>_u0020>9));
																	throw;
																}
																global::<Module>.std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>.{dtor}(ref basic_string<char,std::char_traits<char>,std::allocator<char>_u0020>9);
																global::std._Vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020> vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>_u0020>_u0020>10;
																cpblk(ref vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>_u0020>_u0020>, global::<Module>.std.vector<ISHITEM,std::allocator<ISHITEM>\u0020>.begin(ref vector<ISHITEM,std::allocator<ISHITEM>_u0020>7, &vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>_u0020>_u0020>10), 4);
																global::std._Vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020> vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>_u0020>_u0020>11;
																while (global::<Module>.std._Vector_const_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020>.!=(ref vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>_u0020>_u0020>, global::<Module>.std.vector<ISHITEM,std::allocator<ISHITEM>\u0020>.end(ref vector<ISHITEM,std::allocator<ISHITEM>_u0020>7, &vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>_u0020>_u0020>11)) != null)
																{
																	ushort info7 = *(global::<Module>.std._Vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020>.->(ref vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>_u0020>_u0020>) + 24);
																	ushort info8 = *(global::<Module>.std._Vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020>.->(ref vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>_u0020>_u0020>) + 26);
																	global::<Module>.CIshList.AddIshInfo(ref cishList, info7);
																	global::<Module>.CIshList.AddIshInfo(ref cishList, info8);
																	global::std._Vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020> vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>_u0020>_u0020>12;
																	global::<Module>.std._Vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020>.++(ref vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>_u0020>_u0020>, &vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>_u0020>_u0020>12, 0);
																}
																global::<Module>.std.vector<ISHITEM,std::allocator<ISHITEM>\u0020>.clear(ref vector<ISHITEM,std::allocator<ISHITEM>_u0020>7);
															}
															catch
															{
																global::<Module>.___CxxCallUnwindDtor(ldftn(std.vector<ISHITEM,std::allocator<ISHITEM>\u0020>.{dtor}), (void*)(&vector<ISHITEM,std::allocator<ISHITEM>_u0020>7));
																throw;
															}
															global::<Module>.std.vector<ISHITEM,std::allocator<ISHITEM>\u0020>.{dtor}(ref vector<ISHITEM,std::allocator<ISHITEM>_u0020>7);
														}
														catch
														{
															global::<Module>.___CxxCallUnwindDtor(ldftn(std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>.{dtor}), (void*)(&basic_string<char,std::char_traits<char>,std::allocator<char>_u0020>8));
															throw;
														}
														global::<Module>.std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>.{dtor}(ref basic_string<char,std::char_traits<char>,std::allocator<char>_u0020>8);
													}
												}
											}
											catch
											{
												global::<Module>.___CxxCallUnwindDtor(ldftn(std.vector<ISHITEM,std::allocator<ISHITEM>\u0020>.{dtor}), (void*)(&vector<ISHITEM,std::allocator<ISHITEM>_u0020>5));
												throw;
											}
											global::<Module>.std.vector<ISHITEM,std::allocator<ISHITEM>\u0020>.{dtor}(ref vector<ISHITEM,std::allocator<ISHITEM>_u0020>5);
										}
										catch
										{
											global::<Module>.___CxxCallUnwindDtor(ldftn(std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>.{dtor}), (void*)(&basic_string<char,std::char_traits<char>,std::allocator<char>_u0020>6));
											throw;
										}
										global::<Module>.std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>.{dtor}(ref basic_string<char,std::char_traits<char>,std::allocator<char>_u0020>6);
									}
									catch
									{
										global::<Module>.___CxxCallUnwindDtor(ldftn(std.vector<ISHITEM,std::allocator<ISHITEM>\u0020>.{dtor}), (void*)(&vector<ISHITEM,std::allocator<ISHITEM>_u0020>3));
										throw;
									}
									global::<Module>.std.vector<ISHITEM,std::allocator<ISHITEM>\u0020>.{dtor}(ref vector<ISHITEM,std::allocator<ISHITEM>_u0020>3);
								}
								catch
								{
									global::<Module>.___CxxCallUnwindDtor(ldftn(std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>.{dtor}), (void*)(&basic_string<char,std::char_traits<char>,std::allocator<char>_u0020>4));
									throw;
								}
								global::<Module>.std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>.{dtor}(ref basic_string<char,std::char_traits<char>,std::allocator<char>_u0020>4);
							}
							catch
							{
								global::<Module>.___CxxCallUnwindDtor(ldftn(CIshList.{dtor}), (void*)(&cishList));
								throw;
							}
							global::<Module>.CIshList.{dtor}(ref cishList);
						}
						catch
						{
							global::<Module>.___CxxCallUnwindDtor(ldftn(std.vector<ISHITEM,std::allocator<ISHITEM>\u0020>.{dtor}), (void*)(&vector<ISHITEM,std::allocator<ISHITEM>_u0020>));
							throw;
						}
						global::<Module>.std.vector<ISHITEM,std::allocator<ISHITEM>\u0020>.{dtor}(ref vector<ISHITEM,std::allocator<ISHITEM>_u0020>);
					}
					catch
					{
						global::<Module>.___CxxCallUnwindDtor(ldftn(std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>.{dtor}), (void*)(&basic_string<char,std::char_traits<char>,std::allocator<char>_u0020>2));
						throw;
					}
					global::<Module>.std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>.{dtor}(ref basic_string<char,std::char_traits<char>,std::allocator<char>_u0020>2);
				}
			}
			catch
			{
				global::<Module>.___CxxCallUnwindDtor(ldftn(std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>.{dtor}), (void*)(&basic_string<char,std::char_traits<char>,std::allocator<char>_u0020>));
				throw;
			}
			global::<Module>.std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>.{dtor}(ref basic_string<char,std::char_traits<char>,std::allocator<char>_u0020>);
		}
		catch
		{
			global::<Module>.___CxxCallUnwindDtor(ldftn(std.vector<PSDT_RECORD\u0020*,std::allocator<PSDT_RECORD\u0020*>\u0020>.{dtor}), (void*)(&vector<PSDT_RECORD_u0020*,std::allocator<PSDT_RECORD_u0020*>_u0020>));
			throw;
		}
		global::<Module>.std.vector<PSDT_RECORD\u0020*,std::allocator<PSDT_RECORD\u0020*>\u0020>.{dtor}(ref vector<PSDT_RECORD_u0020*,std::allocator<PSDT_RECORD_u0020*>_u0020>);
	}

	// Token: 0x0600004F RID: 79 RVA: 0x00003330 File Offset: 0x00002730
	internal unsafe static void read_partition(global::IUnknown* pIsh, global::method pfAddIshInfo, ulong* PARTStart, ulong* PARTEnd, sbyte* partitionName, ulong base_address)
	{
		global::std.vector<PSDT_RECORD\u0020*,std::allocator<PSDT_RECORD\u0020*>\u0020> vector<PSDT_RECORD_u0020*,std::allocator<PSDT_RECORD_u0020*>_u0020>;
		global::<Module>.IshAdapter.ReadPSDTRecord(pIsh, &vector<PSDT_RECORD_u0020*,std::allocator<PSDT_RECORD_u0020*>_u0020>);
		try
		{
			global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020> basic_string<char,std::char_traits<char>,std::allocator<char>_u0020>;
			global::<Module>.std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>.{ctor}(ref basic_string<char,std::char_traits<char>,std::allocator<char>_u0020>, (sbyte*)(&global::<Module>.?A0x719a7106.unnamed-global-56));
			try
			{
				global::std._Vector_const_iterator<std::_Vector_val<std::_Simple_types<PSDT_RECORD\u0020*>\u0020>\u0020> vector_const_iterator<std::_Vector_val<std::_Simple_types<PSDT_RECORD_u0020*>_u0020>_u0020>;
				global::std._Vector_iterator<std::_Vector_val<std::_Simple_types<PSDT_RECORD\u0020*>\u0020>\u0020> vector_iterator<std::_Vector_val<std::_Simple_types<PSDT_RECORD_u0020*>_u0020>_u0020>;
				cpblk(ref vector_const_iterator<std::_Vector_val<std::_Simple_types<PSDT_RECORD_u0020*>_u0020>_u0020>, global::<Module>.std.vector<PSDT_RECORD\u0020*,std::allocator<PSDT_RECORD\u0020*>\u0020>.begin(ref vector<PSDT_RECORD_u0020*,std::allocator<PSDT_RECORD_u0020*>_u0020>, &vector_iterator<std::_Vector_val<std::_Simple_types<PSDT_RECORD_u0020*>_u0020>_u0020>), 4);
				global::std._Vector_iterator<std::_Vector_val<std::_Simple_types<PSDT_RECORD\u0020*>\u0020>\u0020> vector_iterator<std::_Vector_val<std::_Simple_types<PSDT_RECORD_u0020*>_u0020>_u0020>2;
				while (global::<Module>.std._Vector_const_iterator<std::_Vector_val<std::_Simple_types<PSDT_RECORD\u0020*>\u0020>\u0020>.!=(ref vector_const_iterator<std::_Vector_val<std::_Simple_types<PSDT_RECORD_u0020*>_u0020>_u0020>, global::<Module>.std.vector<PSDT_RECORD\u0020*,std::allocator<PSDT_RECORD\u0020*>\u0020>.end(ref vector<PSDT_RECORD_u0020*,std::allocator<PSDT_RECORD_u0020*>_u0020>, &vector_iterator<std::_Vector_val<std::_Simple_types<PSDT_RECORD_u0020*>_u0020>_u0020>2)) != null)
				{
					uint num = *(*global::<Module>.std._Vector_const_iterator<std::_Vector_val<std::_Simple_types<PSDT_RECORD\u0020*>\u0020>\u0020>.*(ref vector_const_iterator<std::_Vector_val<std::_Simple_types<PSDT_RECORD_u0020*>_u0020>_u0020>));
					global::<Module>.IshAdapter.GetSectionID(pIsh, (uint)(base_address + (ulong)(*(*global::<Module>.std._Vector_const_iterator<std::_Vector_val<std::_Simple_types<PSDT_RECORD\u0020*>\u0020>\u0020>.*(ref vector_const_iterator<std::_Vector_val<std::_Simple_types<PSDT_RECORD_u0020*>_u0020>_u0020>) + 4))), ref basic_string<char,std::char_traits<char>,std::allocator<char>_u0020>);
					sbyte* ptr = global::<Module>.std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>.c_str(ref basic_string<char,std::char_traits<char>,std::allocator<char>_u0020>);
					if (*(sbyte*)partitionName == *(sbyte*)ptr)
					{
						sbyte* ptr2 = partitionName + 1 / sizeof(sbyte);
						ptr += 1 / sizeof(sbyte);
						if (*(sbyte*)ptr2 == *(sbyte*)ptr)
						{
							ptr2 += 1 / sizeof(sbyte);
							ptr += 1 / sizeof(sbyte);
							if (*(sbyte*)ptr2 == *(sbyte*)ptr)
							{
								ptr2 += 1 / sizeof(sbyte);
								ptr += 1 / sizeof(sbyte);
								if (*(sbyte*)ptr2 == *(sbyte*)ptr)
								{
									*PARTStart = (long)((ulong)(*(*global::<Module>.std._Vector_const_iterator<std::_Vector_val<std::_Simple_types<PSDT_RECORD\u0020*>\u0020>\u0020>.*(ref vector_const_iterator<std::_Vector_val<std::_Simple_types<PSDT_RECORD_u0020*>_u0020>_u0020>) + 4)));
									*PARTEnd = (long)((ulong)(*(*global::<Module>.std._Vector_const_iterator<std::_Vector_val<std::_Simple_types<PSDT_RECORD\u0020*>\u0020>\u0020>.*(ref vector_const_iterator<std::_Vector_val<std::_Simple_types<PSDT_RECORD_u0020*>_u0020>_u0020>) + 8)));
								}
							}
						}
					}
					global::<Module>.std._Vector_const_iterator<std::_Vector_val<std::_Simple_types<PSDT_RECORD\u0020*>\u0020>\u0020>.++(ref vector_const_iterator<std::_Vector_val<std::_Simple_types<PSDT_RECORD_u0020*>_u0020>_u0020>);
				}
				global::std._Vector_const_iterator<std::_Vector_val<std::_Simple_types<PSDT_RECORD\u0020*>\u0020>\u0020> vector_const_iterator<std::_Vector_val<std::_Simple_types<PSDT_RECORD_u0020*>_u0020>_u0020>2;
				global::std._Vector_iterator<std::_Vector_val<std::_Simple_types<PSDT_RECORD\u0020*>\u0020>\u0020> vector_iterator<std::_Vector_val<std::_Simple_types<PSDT_RECORD_u0020*>_u0020>_u0020>3;
				cpblk(ref vector_const_iterator<std::_Vector_val<std::_Simple_types<PSDT_RECORD_u0020*>_u0020>_u0020>2, global::<Module>.std.vector<PSDT_RECORD\u0020*,std::allocator<PSDT_RECORD\u0020*>\u0020>.begin(ref vector<PSDT_RECORD_u0020*,std::allocator<PSDT_RECORD_u0020*>_u0020>, &vector_iterator<std::_Vector_val<std::_Simple_types<PSDT_RECORD_u0020*>_u0020>_u0020>3), 4);
				global::std._Vector_iterator<std::_Vector_val<std::_Simple_types<PSDT_RECORD\u0020*>\u0020>\u0020> vector_iterator<std::_Vector_val<std::_Simple_types<PSDT_RECORD_u0020*>_u0020>_u0020>4;
				while (global::<Module>.std._Vector_const_iterator<std::_Vector_val<std::_Simple_types<PSDT_RECORD\u0020*>\u0020>\u0020>.!=(ref vector_const_iterator<std::_Vector_val<std::_Simple_types<PSDT_RECORD_u0020*>_u0020>_u0020>2, global::<Module>.std.vector<PSDT_RECORD\u0020*,std::allocator<PSDT_RECORD\u0020*>\u0020>.end(ref vector<PSDT_RECORD_u0020*,std::allocator<PSDT_RECORD_u0020*>_u0020>, &vector_iterator<std::_Vector_val<std::_Simple_types<PSDT_RECORD_u0020*>_u0020>_u0020>4)) != null)
				{
					global::<Module>.delete(*global::<Module>.std._Vector_const_iterator<std::_Vector_val<std::_Simple_types<PSDT_RECORD\u0020*>\u0020>\u0020>.*(ref vector_const_iterator<std::_Vector_val<std::_Simple_types<PSDT_RECORD_u0020*>_u0020>_u0020>2));
					global::<Module>.std._Vector_const_iterator<std::_Vector_val<std::_Simple_types<PSDT_RECORD\u0020*>\u0020>\u0020>.++(ref vector_const_iterator<std::_Vector_val<std::_Simple_types<PSDT_RECORD_u0020*>_u0020>_u0020>2);
				}
				global::<Module>.std.vector<PSDT_RECORD\u0020*,std::allocator<PSDT_RECORD\u0020*>\u0020>.clear(ref vector<PSDT_RECORD_u0020*,std::allocator<PSDT_RECORD_u0020*>_u0020>);
				if (pfAddIshInfo != null)
				{
					global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020> basic_string<char,std::char_traits<char>,std::allocator<char>_u0020>2;
					global::<Module>.std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>.{ctor}(ref basic_string<char,std::char_traits<char>,std::allocator<char>_u0020>2, (sbyte*)(&global::<Module>.?A0x719a7106.unnamed-global-57));
					try
					{
						global::<Module>.IshAdapter.GetSectionID(pIsh, (uint)(base_address + (ulong)(*PARTStart)), ref basic_string<char,std::char_traits<char>,std::allocator<char>_u0020>2);
						sbyte* ptr3 = global::<Module>.std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>.c_str(ref basic_string<char,std::char_traits<char>,std::allocator<char>_u0020>2);
						global::std.vector<ISHITEM,std::allocator<ISHITEM>\u0020> vector<ISHITEM,std::allocator<ISHITEM>_u0020>;
						global::<Module>.std.vector<ISHITEM,std::allocator<ISHITEM>\u0020>.{ctor}(ref vector<ISHITEM,std::allocator<ISHITEM>_u0020>);
						try
						{
							global::<Module>.std.vector<ISHITEM,std::allocator<ISHITEM>\u0020>.clear(ref vector<ISHITEM,std::allocator<ISHITEM>_u0020>);
							global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020> basic_string<char,std::char_traits<char>,std::allocator<char>_u0020>3;
							global::<Module>.std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>.{ctor}(ref basic_string<char,std::char_traits<char>,std::allocator<char>_u0020>3, ptr3);
							try
							{
								global::std.vector<ISHITEM,std::allocator<ISHITEM>\u0020> vector<ISHITEM,std::allocator<ISHITEM>_u0020>2;
								global::std.vector<ISHITEM,std::allocator<ISHITEM>\u0020>* right = global::<Module>.IshAdapter.ReadAllISH(pIsh, &vector<ISHITEM,std::allocator<ISHITEM>_u0020>2, ref basic_string<char,std::char_traits<char>,std::allocator<char>_u0020>3);
								try
								{
									global::<Module>.std.vector<ISHITEM,std::allocator<ISHITEM>\u0020>.=(ref vector<ISHITEM,std::allocator<ISHITEM>_u0020>, right);
								}
								catch
								{
									global::<Module>.___CxxCallUnwindDtor(ldftn(std.vector<ISHITEM,std::allocator<ISHITEM>\u0020>.{dtor}), (void*)(&vector<ISHITEM,std::allocator<ISHITEM>_u0020>2));
									throw;
								}
								global::<Module>.std.vector<ISHITEM,std::allocator<ISHITEM>\u0020>.{dtor}(ref vector<ISHITEM,std::allocator<ISHITEM>_u0020>2);
							}
							catch
							{
								global::<Module>.___CxxCallUnwindDtor(ldftn(std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>.{dtor}), (void*)(&basic_string<char,std::char_traits<char>,std::allocator<char>_u0020>3));
								throw;
							}
							global::<Module>.std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>.{dtor}(ref basic_string<char,std::char_traits<char>,std::allocator<char>_u0020>3);
							global::std._Vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020> vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>_u0020>_u0020>;
							global::<Module>.std.vector<ISHITEM,std::allocator<ISHITEM>\u0020>.begin(ref vector<ISHITEM,std::allocator<ISHITEM>_u0020>, &vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>_u0020>_u0020>);
							global::CIshList cishList;
							global::<Module>.CIshList.{ctor}(ref cishList);
							try
							{
								global::<Module>.CIshList.SetPFAddIshInfo(ref cishList, pfAddIshInfo);
								global::std._Vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020> vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>_u0020>_u0020>2;
								while (global::<Module>.std._Vector_const_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020>.!=(ref vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>_u0020>_u0020>, global::<Module>.std.vector<ISHITEM,std::allocator<ISHITEM>\u0020>.end(ref vector<ISHITEM,std::allocator<ISHITEM>_u0020>, &vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>_u0020>_u0020>2)) != null)
								{
									ushort info = *(global::<Module>.std._Vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020>.->(ref vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>_u0020>_u0020>) + 24);
									ushort info2 = *(global::<Module>.std._Vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020>.->(ref vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>_u0020>_u0020>) + 26);
									global::<Module>.CIshList.AddIshInfo(ref cishList, info);
									global::<Module>.CIshList.AddIshInfo(ref cishList, info2);
									global::std._Vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020> vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>_u0020>_u0020>3;
									global::<Module>.std._Vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020>.++(ref vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>_u0020>_u0020>, &vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>_u0020>_u0020>3, 0);
								}
								global::<Module>.std.vector<ISHITEM,std::allocator<ISHITEM>\u0020>.clear(ref vector<ISHITEM,std::allocator<ISHITEM>_u0020>);
							}
							catch
							{
								global::<Module>.___CxxCallUnwindDtor(ldftn(CIshList.{dtor}), (void*)(&cishList));
								throw;
							}
							global::<Module>.CIshList.{dtor}(ref cishList);
						}
						catch
						{
							global::<Module>.___CxxCallUnwindDtor(ldftn(std.vector<ISHITEM,std::allocator<ISHITEM>\u0020>.{dtor}), (void*)(&vector<ISHITEM,std::allocator<ISHITEM>_u0020>));
							throw;
						}
						global::<Module>.std.vector<ISHITEM,std::allocator<ISHITEM>\u0020>.{dtor}(ref vector<ISHITEM,std::allocator<ISHITEM>_u0020>);
					}
					catch
					{
						global::<Module>.___CxxCallUnwindDtor(ldftn(std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>.{dtor}), (void*)(&basic_string<char,std::char_traits<char>,std::allocator<char>_u0020>2));
						throw;
					}
					global::<Module>.std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>.{dtor}(ref basic_string<char,std::char_traits<char>,std::allocator<char>_u0020>2);
				}
			}
			catch
			{
				global::<Module>.___CxxCallUnwindDtor(ldftn(std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>.{dtor}), (void*)(&basic_string<char,std::char_traits<char>,std::allocator<char>_u0020>));
				throw;
			}
			global::<Module>.std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>.{dtor}(ref basic_string<char,std::char_traits<char>,std::allocator<char>_u0020>);
		}
		catch
		{
			global::<Module>.___CxxCallUnwindDtor(ldftn(std.vector<PSDT_RECORD\u0020*,std::allocator<PSDT_RECORD\u0020*>\u0020>.{dtor}), (void*)(&vector<PSDT_RECORD_u0020*,std::allocator<PSDT_RECORD_u0020*>_u0020>));
			throw;
		}
		global::<Module>.std.vector<PSDT_RECORD\u0020*,std::allocator<PSDT_RECORD\u0020*>\u0020>.{dtor}(ref vector<PSDT_RECORD_u0020*,std::allocator<PSDT_RECORD_u0020*>_u0020>);
	}

	// Token: 0x06000050 RID: 80 RVA: 0x00002834 File Offset: 0x00001C34
	internal unsafe static void PutPSDTInMemory(global::IUnknown* pIsh, sbyte* targetFile, uint base_address)
	{
		global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020> basic_string<char,std::char_traits<char>,std::allocator<char>_u0020>;
		global::<Module>.std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>.{ctor}(ref basic_string<char,std::char_traits<char>,std::allocator<char>_u0020>, targetFile);
		try
		{
			global::<Module>.IshAdapter.LoadPSDT(pIsh, ref basic_string<char,std::char_traits<char>,std::allocator<char>_u0020>, base_address);
		}
		catch
		{
			global::<Module>.___CxxCallUnwindDtor(ldftn(std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>.{dtor}), (void*)(&basic_string<char,std::char_traits<char>,std::allocator<char>_u0020>));
			throw;
		}
		global::<Module>.std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>.{dtor}(ref basic_string<char,std::char_traits<char>,std::allocator<char>_u0020>);
	}

	// Token: 0x06000051 RID: 81 RVA: 0x0000288C File Offset: 0x00001C8C
	internal unsafe static void PutCodeplugInMemory(global::IUnknown* pIsh, sbyte* targetFile, global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* section_id, ushort src_ish_version)
	{
		global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020> basic_string<char,std::char_traits<char>,std::allocator<char>_u0020>;
		global::<Module>.std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>.{ctor}(ref basic_string<char,std::char_traits<char>,std::allocator<char>_u0020>, (sbyte*)(&global::<Module>.?A0x719a7106.unnamed-global-58));
		try
		{
			global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020> basic_string<char,std::char_traits<char>,std::allocator<char>_u0020>2;
			global::<Module>.std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>.{ctor}(ref basic_string<char,std::char_traits<char>,std::allocator<char>_u0020>2, targetFile);
			try
			{
				global::<Module>.IshAdapter.LoadCodeplug(pIsh, ref basic_string<char,std::char_traits<char>,std::allocator<char>_u0020>2, ref basic_string<char,std::char_traits<char>,std::allocator<char>_u0020>, src_ish_version);
			}
			catch
			{
				global::<Module>.___CxxCallUnwindDtor(ldftn(std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>.{dtor}), (void*)(&basic_string<char,std::char_traits<char>,std::allocator<char>_u0020>2));
				throw;
			}
			global::<Module>.std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>.{dtor}(ref basic_string<char,std::char_traits<char>,std::allocator<char>_u0020>2);
		}
		catch
		{
			global::<Module>.___CxxCallUnwindDtor(ldftn(std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>.{dtor}), (void*)(&basic_string<char,std::char_traits<char>,std::allocator<char>_u0020>));
			throw;
		}
		global::<Module>.std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>.{dtor}(ref basic_string<char,std::char_traits<char>,std::allocator<char>_u0020>);
	}

	// Token: 0x06000052 RID: 82 RVA: 0x00002920 File Offset: 0x00001D20
	internal unsafe static int WriteIshToSrec(global::IUnknown* pIsh, sbyte* TargetFileName, sbyte* TargetSection)
	{
		global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020> basic_string<char,std::char_traits<char>,std::allocator<char>_u0020>;
		global::<Module>.std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>.{ctor}(ref basic_string<char,std::char_traits<char>,std::allocator<char>_u0020>, TargetSection);
		try
		{
			global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020> basic_string<char,std::char_traits<char>,std::allocator<char>_u0020>2;
			global::<Module>.std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>.{ctor}(ref basic_string<char,std::char_traits<char>,std::allocator<char>_u0020>2, TargetFileName);
			try
			{
				global::<Module>.IshAdapter.SaveCodeplug(pIsh, ref basic_string<char,std::char_traits<char>,std::allocator<char>_u0020>2, ref basic_string<char,std::char_traits<char>,std::allocator<char>_u0020>);
			}
			catch
			{
				global::<Module>.___CxxCallUnwindDtor(ldftn(std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>.{dtor}), (void*)(&basic_string<char,std::char_traits<char>,std::allocator<char>_u0020>2));
				throw;
			}
			global::<Module>.std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>.{dtor}(ref basic_string<char,std::char_traits<char>,std::allocator<char>_u0020>2);
		}
		catch
		{
			global::<Module>.___CxxCallUnwindDtor(ldftn(std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>.{dtor}), (void*)(&basic_string<char,std::char_traits<char>,std::allocator<char>_u0020>));
			throw;
		}
		global::<Module>.std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>.{dtor}(ref basic_string<char,std::char_traits<char>,std::allocator<char>_u0020>);
		return 0;
	}

	// Token: 0x06000053 RID: 83 RVA: 0x000018A4 File Offset: 0x00000CA4
	[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
	internal unsafe static bool GetCheckSum(global::IUnknown* ishMem, int* result, ulong length)
	{
		global::<CppImplementationDetails>.$ArrayType$$$BY0BAA@H $ArrayType$$$BY0BAA@H = 0;
		*(ref $ArrayType$$$BY0BAA@H + 4) = 4129;
		*(ref $ArrayType$$$BY0BAA@H + 8) = 8258;
		*(ref $ArrayType$$$BY0BAA@H + 12) = 12387;
		*(ref $ArrayType$$$BY0BAA@H + 16) = 16516;
		*(ref $ArrayType$$$BY0BAA@H + 20) = 20645;
		*(ref $ArrayType$$$BY0BAA@H + 24) = 24774;
		*(ref $ArrayType$$$BY0BAA@H + 28) = 28903;
		*(ref $ArrayType$$$BY0BAA@H + 32) = 33032;
		*(ref $ArrayType$$$BY0BAA@H + 36) = 37161;
		*(ref $ArrayType$$$BY0BAA@H + 40) = 41290;
		*(ref $ArrayType$$$BY0BAA@H + 44) = 45419;
		*(ref $ArrayType$$$BY0BAA@H + 48) = 49548;
		*(ref $ArrayType$$$BY0BAA@H + 52) = 53677;
		*(ref $ArrayType$$$BY0BAA@H + 56) = 57806;
		*(ref $ArrayType$$$BY0BAA@H + 60) = 61935;
		*(ref $ArrayType$$$BY0BAA@H + 64) = 4657;
		*(ref $ArrayType$$$BY0BAA@H + 68) = 528;
		*(ref $ArrayType$$$BY0BAA@H + 72) = 12915;
		*(ref $ArrayType$$$BY0BAA@H + 76) = 8786;
		*(ref $ArrayType$$$BY0BAA@H + 80) = 21173;
		*(ref $ArrayType$$$BY0BAA@H + 84) = 17044;
		*(ref $ArrayType$$$BY0BAA@H + 88) = 29431;
		*(ref $ArrayType$$$BY0BAA@H + 92) = 25302;
		*(ref $ArrayType$$$BY0BAA@H + 96) = 37689;
		*(ref $ArrayType$$$BY0BAA@H + 100) = 33560;
		*(ref $ArrayType$$$BY0BAA@H + 104) = 45947;
		*(ref $ArrayType$$$BY0BAA@H + 108) = 41818;
		*(ref $ArrayType$$$BY0BAA@H + 112) = 54205;
		*(ref $ArrayType$$$BY0BAA@H + 116) = 50076;
		*(ref $ArrayType$$$BY0BAA@H + 120) = 62463;
		*(ref $ArrayType$$$BY0BAA@H + 124) = 58334;
		*(ref $ArrayType$$$BY0BAA@H + 128) = 9314;
		*(ref $ArrayType$$$BY0BAA@H + 132) = 13379;
		*(ref $ArrayType$$$BY0BAA@H + 136) = 1056;
		*(ref $ArrayType$$$BY0BAA@H + 140) = 5121;
		*(ref $ArrayType$$$BY0BAA@H + 144) = 25830;
		*(ref $ArrayType$$$BY0BAA@H + 148) = 29895;
		*(ref $ArrayType$$$BY0BAA@H + 152) = 17572;
		*(ref $ArrayType$$$BY0BAA@H + 156) = 21637;
		*(ref $ArrayType$$$BY0BAA@H + 160) = 42346;
		*(ref $ArrayType$$$BY0BAA@H + 164) = 46411;
		*(ref $ArrayType$$$BY0BAA@H + 168) = 34088;
		*(ref $ArrayType$$$BY0BAA@H + 172) = 38153;
		*(ref $ArrayType$$$BY0BAA@H + 176) = 58862;
		*(ref $ArrayType$$$BY0BAA@H + 180) = 62927;
		*(ref $ArrayType$$$BY0BAA@H + 184) = 50604;
		*(ref $ArrayType$$$BY0BAA@H + 188) = 54669;
		*(ref $ArrayType$$$BY0BAA@H + 192) = 13907;
		*(ref $ArrayType$$$BY0BAA@H + 196) = 9842;
		*(ref $ArrayType$$$BY0BAA@H + 200) = 5649;
		*(ref $ArrayType$$$BY0BAA@H + 204) = 1584;
		*(ref $ArrayType$$$BY0BAA@H + 208) = 30423;
		*(ref $ArrayType$$$BY0BAA@H + 212) = 26358;
		*(ref $ArrayType$$$BY0BAA@H + 216) = 22165;
		*(ref $ArrayType$$$BY0BAA@H + 220) = 18100;
		*(ref $ArrayType$$$BY0BAA@H + 224) = 46939;
		*(ref $ArrayType$$$BY0BAA@H + 228) = 42874;
		*(ref $ArrayType$$$BY0BAA@H + 232) = 38681;
		*(ref $ArrayType$$$BY0BAA@H + 236) = 34616;
		*(ref $ArrayType$$$BY0BAA@H + 240) = 63455;
		*(ref $ArrayType$$$BY0BAA@H + 244) = 59390;
		*(ref $ArrayType$$$BY0BAA@H + 248) = 55197;
		*(ref $ArrayType$$$BY0BAA@H + 252) = 51132;
		*(ref $ArrayType$$$BY0BAA@H + 256) = 18628;
		*(ref $ArrayType$$$BY0BAA@H + 260) = 22757;
		*(ref $ArrayType$$$BY0BAA@H + 264) = 26758;
		*(ref $ArrayType$$$BY0BAA@H + 268) = 30887;
		*(ref $ArrayType$$$BY0BAA@H + 272) = 2112;
		*(ref $ArrayType$$$BY0BAA@H + 276) = 6241;
		*(ref $ArrayType$$$BY0BAA@H + 280) = 10242;
		*(ref $ArrayType$$$BY0BAA@H + 284) = 14371;
		*(ref $ArrayType$$$BY0BAA@H + 288) = 51660;
		*(ref $ArrayType$$$BY0BAA@H + 292) = 55789;
		*(ref $ArrayType$$$BY0BAA@H + 296) = 59790;
		*(ref $ArrayType$$$BY0BAA@H + 300) = 63919;
		*(ref $ArrayType$$$BY0BAA@H + 304) = 35144;
		*(ref $ArrayType$$$BY0BAA@H + 308) = 39273;
		*(ref $ArrayType$$$BY0BAA@H + 312) = 43274;
		*(ref $ArrayType$$$BY0BAA@H + 316) = 47403;
		*(ref $ArrayType$$$BY0BAA@H + 320) = 23285;
		*(ref $ArrayType$$$BY0BAA@H + 324) = 19156;
		*(ref $ArrayType$$$BY0BAA@H + 328) = 31415;
		*(ref $ArrayType$$$BY0BAA@H + 332) = 27286;
		*(ref $ArrayType$$$BY0BAA@H + 336) = 6769;
		*(ref $ArrayType$$$BY0BAA@H + 340) = 2640;
		*(ref $ArrayType$$$BY0BAA@H + 344) = 14899;
		*(ref $ArrayType$$$BY0BAA@H + 348) = 10770;
		*(ref $ArrayType$$$BY0BAA@H + 352) = 56317;
		*(ref $ArrayType$$$BY0BAA@H + 356) = 52188;
		*(ref $ArrayType$$$BY0BAA@H + 360) = 64447;
		*(ref $ArrayType$$$BY0BAA@H + 364) = 60318;
		*(ref $ArrayType$$$BY0BAA@H + 368) = 39801;
		*(ref $ArrayType$$$BY0BAA@H + 372) = 35672;
		*(ref $ArrayType$$$BY0BAA@H + 376) = 47931;
		*(ref $ArrayType$$$BY0BAA@H + 380) = 43802;
		*(ref $ArrayType$$$BY0BAA@H + 384) = 27814;
		*(ref $ArrayType$$$BY0BAA@H + 388) = 31879;
		*(ref $ArrayType$$$BY0BAA@H + 392) = 19684;
		*(ref $ArrayType$$$BY0BAA@H + 396) = 23749;
		*(ref $ArrayType$$$BY0BAA@H + 400) = 11298;
		*(ref $ArrayType$$$BY0BAA@H + 404) = 15363;
		*(ref $ArrayType$$$BY0BAA@H + 408) = 3168;
		*(ref $ArrayType$$$BY0BAA@H + 412) = 7233;
		*(ref $ArrayType$$$BY0BAA@H + 416) = 60846;
		*(ref $ArrayType$$$BY0BAA@H + 420) = 64911;
		*(ref $ArrayType$$$BY0BAA@H + 424) = 52716;
		*(ref $ArrayType$$$BY0BAA@H + 428) = 56781;
		*(ref $ArrayType$$$BY0BAA@H + 432) = 44330;
		*(ref $ArrayType$$$BY0BAA@H + 436) = 48395;
		*(ref $ArrayType$$$BY0BAA@H + 440) = 36200;
		*(ref $ArrayType$$$BY0BAA@H + 444) = 40265;
		*(ref $ArrayType$$$BY0BAA@H + 448) = 32407;
		*(ref $ArrayType$$$BY0BAA@H + 452) = 28342;
		*(ref $ArrayType$$$BY0BAA@H + 456) = 24277;
		*(ref $ArrayType$$$BY0BAA@H + 460) = 20212;
		*(ref $ArrayType$$$BY0BAA@H + 464) = 15891;
		*(ref $ArrayType$$$BY0BAA@H + 468) = 11826;
		*(ref $ArrayType$$$BY0BAA@H + 472) = 7761;
		*(ref $ArrayType$$$BY0BAA@H + 476) = 3696;
		*(ref $ArrayType$$$BY0BAA@H + 480) = 65439;
		*(ref $ArrayType$$$BY0BAA@H + 484) = 61374;
		*(ref $ArrayType$$$BY0BAA@H + 488) = 57309;
		*(ref $ArrayType$$$BY0BAA@H + 492) = 53244;
		*(ref $ArrayType$$$BY0BAA@H + 496) = 48923;
		*(ref $ArrayType$$$BY0BAA@H + 500) = 44858;
		*(ref $ArrayType$$$BY0BAA@H + 504) = 40793;
		*(ref $ArrayType$$$BY0BAA@H + 508) = 36728;
		*(ref $ArrayType$$$BY0BAA@H + 512) = 37256;
		*(ref $ArrayType$$$BY0BAA@H + 516) = 33193;
		*(ref $ArrayType$$$BY0BAA@H + 520) = 45514;
		*(ref $ArrayType$$$BY0BAA@H + 524) = 41451;
		*(ref $ArrayType$$$BY0BAA@H + 528) = 53516;
		*(ref $ArrayType$$$BY0BAA@H + 532) = 49453;
		*(ref $ArrayType$$$BY0BAA@H + 536) = 61774;
		*(ref $ArrayType$$$BY0BAA@H + 540) = 57711;
		*(ref $ArrayType$$$BY0BAA@H + 544) = 4224;
		*(ref $ArrayType$$$BY0BAA@H + 548) = 161;
		*(ref $ArrayType$$$BY0BAA@H + 552) = 12482;
		*(ref $ArrayType$$$BY0BAA@H + 556) = 8419;
		*(ref $ArrayType$$$BY0BAA@H + 560) = 20484;
		*(ref $ArrayType$$$BY0BAA@H + 564) = 16421;
		*(ref $ArrayType$$$BY0BAA@H + 568) = 28742;
		*(ref $ArrayType$$$BY0BAA@H + 572) = 24679;
		*(ref $ArrayType$$$BY0BAA@H + 576) = 33721;
		*(ref $ArrayType$$$BY0BAA@H + 580) = 37784;
		*(ref $ArrayType$$$BY0BAA@H + 584) = 41979;
		*(ref $ArrayType$$$BY0BAA@H + 588) = 46042;
		*(ref $ArrayType$$$BY0BAA@H + 592) = 49981;
		*(ref $ArrayType$$$BY0BAA@H + 596) = 54044;
		*(ref $ArrayType$$$BY0BAA@H + 600) = 58239;
		*(ref $ArrayType$$$BY0BAA@H + 604) = 62302;
		*(ref $ArrayType$$$BY0BAA@H + 608) = 689;
		*(ref $ArrayType$$$BY0BAA@H + 612) = 4752;
		*(ref $ArrayType$$$BY0BAA@H + 616) = 8947;
		*(ref $ArrayType$$$BY0BAA@H + 620) = 13010;
		*(ref $ArrayType$$$BY0BAA@H + 624) = 16949;
		*(ref $ArrayType$$$BY0BAA@H + 628) = 21012;
		*(ref $ArrayType$$$BY0BAA@H + 632) = 25207;
		*(ref $ArrayType$$$BY0BAA@H + 636) = 29270;
		*(ref $ArrayType$$$BY0BAA@H + 640) = 46570;
		*(ref $ArrayType$$$BY0BAA@H + 644) = 42443;
		*(ref $ArrayType$$$BY0BAA@H + 648) = 38312;
		*(ref $ArrayType$$$BY0BAA@H + 652) = 34185;
		*(ref $ArrayType$$$BY0BAA@H + 656) = 62830;
		*(ref $ArrayType$$$BY0BAA@H + 660) = 58703;
		*(ref $ArrayType$$$BY0BAA@H + 664) = 54572;
		*(ref $ArrayType$$$BY0BAA@H + 668) = 50445;
		*(ref $ArrayType$$$BY0BAA@H + 672) = 13538;
		*(ref $ArrayType$$$BY0BAA@H + 676) = 9411;
		*(ref $ArrayType$$$BY0BAA@H + 680) = 5280;
		*(ref $ArrayType$$$BY0BAA@H + 684) = 1153;
		*(ref $ArrayType$$$BY0BAA@H + 688) = 29798;
		*(ref $ArrayType$$$BY0BAA@H + 692) = 25671;
		*(ref $ArrayType$$$BY0BAA@H + 696) = 21540;
		*(ref $ArrayType$$$BY0BAA@H + 700) = 17413;
		*(ref $ArrayType$$$BY0BAA@H + 704) = 42971;
		*(ref $ArrayType$$$BY0BAA@H + 708) = 47098;
		*(ref $ArrayType$$$BY0BAA@H + 712) = 34713;
		*(ref $ArrayType$$$BY0BAA@H + 716) = 38840;
		*(ref $ArrayType$$$BY0BAA@H + 720) = 59231;
		*(ref $ArrayType$$$BY0BAA@H + 724) = 63358;
		*(ref $ArrayType$$$BY0BAA@H + 728) = 50973;
		*(ref $ArrayType$$$BY0BAA@H + 732) = 55100;
		*(ref $ArrayType$$$BY0BAA@H + 736) = 9939;
		*(ref $ArrayType$$$BY0BAA@H + 740) = 14066;
		*(ref $ArrayType$$$BY0BAA@H + 744) = 1681;
		*(ref $ArrayType$$$BY0BAA@H + 748) = 5808;
		*(ref $ArrayType$$$BY0BAA@H + 752) = 26199;
		*(ref $ArrayType$$$BY0BAA@H + 756) = 30326;
		*(ref $ArrayType$$$BY0BAA@H + 760) = 17941;
		*(ref $ArrayType$$$BY0BAA@H + 764) = 22068;
		*(ref $ArrayType$$$BY0BAA@H + 768) = 55628;
		*(ref $ArrayType$$$BY0BAA@H + 772) = 51565;
		*(ref $ArrayType$$$BY0BAA@H + 776) = 63758;
		*(ref $ArrayType$$$BY0BAA@H + 780) = 59695;
		*(ref $ArrayType$$$BY0BAA@H + 784) = 39368;
		*(ref $ArrayType$$$BY0BAA@H + 788) = 35305;
		*(ref $ArrayType$$$BY0BAA@H + 792) = 47498;
		*(ref $ArrayType$$$BY0BAA@H + 796) = 43435;
		*(ref $ArrayType$$$BY0BAA@H + 800) = 22596;
		*(ref $ArrayType$$$BY0BAA@H + 804) = 18533;
		*(ref $ArrayType$$$BY0BAA@H + 808) = 30726;
		*(ref $ArrayType$$$BY0BAA@H + 812) = 26663;
		*(ref $ArrayType$$$BY0BAA@H + 816) = 6336;
		*(ref $ArrayType$$$BY0BAA@H + 820) = 2273;
		*(ref $ArrayType$$$BY0BAA@H + 824) = 14466;
		*(ref $ArrayType$$$BY0BAA@H + 828) = 10403;
		*(ref $ArrayType$$$BY0BAA@H + 832) = 52093;
		*(ref $ArrayType$$$BY0BAA@H + 836) = 56156;
		*(ref $ArrayType$$$BY0BAA@H + 840) = 60223;
		*(ref $ArrayType$$$BY0BAA@H + 844) = 64286;
		*(ref $ArrayType$$$BY0BAA@H + 848) = 35833;
		*(ref $ArrayType$$$BY0BAA@H + 852) = 39896;
		*(ref $ArrayType$$$BY0BAA@H + 856) = 43963;
		*(ref $ArrayType$$$BY0BAA@H + 860) = 48026;
		*(ref $ArrayType$$$BY0BAA@H + 864) = 19061;
		*(ref $ArrayType$$$BY0BAA@H + 868) = 23124;
		*(ref $ArrayType$$$BY0BAA@H + 872) = 27191;
		*(ref $ArrayType$$$BY0BAA@H + 876) = 31254;
		*(ref $ArrayType$$$BY0BAA@H + 880) = 2801;
		*(ref $ArrayType$$$BY0BAA@H + 884) = 6864;
		*(ref $ArrayType$$$BY0BAA@H + 888) = 10931;
		*(ref $ArrayType$$$BY0BAA@H + 892) = 14994;
		*(ref $ArrayType$$$BY0BAA@H + 896) = 64814;
		*(ref $ArrayType$$$BY0BAA@H + 900) = 60687;
		*(ref $ArrayType$$$BY0BAA@H + 904) = 56684;
		*(ref $ArrayType$$$BY0BAA@H + 908) = 52557;
		*(ref $ArrayType$$$BY0BAA@H + 912) = 48554;
		*(ref $ArrayType$$$BY0BAA@H + 916) = 44427;
		*(ref $ArrayType$$$BY0BAA@H + 920) = 40424;
		*(ref $ArrayType$$$BY0BAA@H + 924) = 36297;
		*(ref $ArrayType$$$BY0BAA@H + 928) = 31782;
		*(ref $ArrayType$$$BY0BAA@H + 932) = 27655;
		*(ref $ArrayType$$$BY0BAA@H + 936) = 23652;
		*(ref $ArrayType$$$BY0BAA@H + 940) = 19525;
		*(ref $ArrayType$$$BY0BAA@H + 944) = 15522;
		*(ref $ArrayType$$$BY0BAA@H + 948) = 11395;
		*(ref $ArrayType$$$BY0BAA@H + 952) = 7392;
		*(ref $ArrayType$$$BY0BAA@H + 956) = 3265;
		*(ref $ArrayType$$$BY0BAA@H + 960) = 61215;
		*(ref $ArrayType$$$BY0BAA@H + 964) = 65342;
		*(ref $ArrayType$$$BY0BAA@H + 968) = 53085;
		*(ref $ArrayType$$$BY0BAA@H + 972) = 57212;
		*(ref $ArrayType$$$BY0BAA@H + 976) = 44955;
		*(ref $ArrayType$$$BY0BAA@H + 980) = 49082;
		*(ref $ArrayType$$$BY0BAA@H + 984) = 36825;
		*(ref $ArrayType$$$BY0BAA@H + 988) = 40952;
		*(ref $ArrayType$$$BY0BAA@H + 992) = 28183;
		*(ref $ArrayType$$$BY0BAA@H + 996) = 32310;
		*(ref $ArrayType$$$BY0BAA@H + 1000) = 20053;
		*(ref $ArrayType$$$BY0BAA@H + 1004) = 24180;
		*(ref $ArrayType$$$BY0BAA@H + 1008) = 11923;
		*(ref $ArrayType$$$BY0BAA@H + 1012) = 16050;
		*(ref $ArrayType$$$BY0BAA@H + 1016) = 3793;
		*(ref $ArrayType$$$BY0BAA@H + 1020) = 7920;
		ushort num = 0;
		byte* ptr = *(int*)ishMem;
		for (;;)
		{
			long num2 = (long)length;
			length -= 1UL;
			if (num2 == 0L)
			{
				break;
			}
			num = (ushort)(*(ref $ArrayType$$$BY0BAA@H + ((num >> 8 ^ (int)(*ptr)) & 255) * 4) ^ (int)num << 8);
			ptr++;
		}
		*result = (int)num;
		return 1;
	}

	// Token: 0x06000054 RID: 84 RVA: 0x00002680 File Offset: 0x00001A80
	internal unsafe static uint GetVirtualFlashMemorySize(global::IUnknown* pIsh)
	{
		return 1;
	}

	// Token: 0x06000055 RID: 85 RVA: 0x00002690 File Offset: 0x00001A90
	internal unsafe static void addChecksumToBuff(global::IUnknown* ishMem, int offset)
	{
	}

	// Token: 0x06000056 RID: 86 RVA: 0x000026A0 File Offset: 0x00001AA0
	internal unsafe static void clearByteBuff(global::IUnknown* ishMem)
	{
		global::<Module>.memset(*(int*)ishMem, 0, 65535U);
	}

	// Token: 0x06000057 RID: 87 RVA: 0x000026C0 File Offset: 0x00001AC0
	internal unsafe static global::CIshList* {ctor}(global::CIshList* A_0)
	{
		*A_0 = 0;
		return A_0;
	}

	// Token: 0x06000058 RID: 88 RVA: 0x000026D4 File Offset: 0x00001AD4
	internal unsafe static void {dtor}(global::CIshList* A_0)
	{
		*A_0 = 0;
	}

	// Token: 0x06000059 RID: 89 RVA: 0x000026E4 File Offset: 0x00001AE4
	internal unsafe static void SetPFAddIshInfo(global::CIshList* A_0, global::method pf)
	{
		*A_0 = pf;
	}

	// Token: 0x0600005A RID: 90 RVA: 0x000026F4 File Offset: 0x00001AF4
	internal unsafe static void AddIshInfo(global::CIshList* A_0, ushort info)
	{
		calli(System.Void modopt(System.Runtime.CompilerServices.CallConvCdecl)(System.UInt16), info, *A_0);
	}

	// Token: 0x0600005B RID: 91 RVA: 0x00004C80 File Offset: 0x00004080
	internal unsafe static global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* {ctor}(global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* A_0, sbyte* _Ptr)
	{
		global::std.allocator<char> allocator<char>;
		global::<Module>.std._String_alloc<0,std::_String_base_types<char,std::allocator<char>\u0020>\u0020>.{ctor}(A_0, global::<Module>.std.allocator<char>.{ctor}(ref allocator<char>));
		global::<Module>.std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>._Tidy(A_0, false, 0U);
		global::<Module>.std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>.assign(A_0, _Ptr);
		return A_0;
	}

	// Token: 0x0600005C RID: 92 RVA: 0x00004724 File Offset: 0x00003B24
	internal unsafe static void {dtor}(global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* A_0)
	{
		global::<Module>.std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>._Tidy(A_0, true, 0U);
	}

	// Token: 0x0600005D RID: 93 RVA: 0x00003FAC File Offset: 0x000033AC
	internal unsafe static sbyte* c_str(global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* A_0)
	{
		return global::<Module>.std._String_val<std::_Simple_types<char>\u0020>._Myptr(A_0);
	}

	// Token: 0x0600005E RID: 94 RVA: 0x0000473C File Offset: 0x00003B3C
	internal unsafe static void {dtor}(global::std.vector<PSDT_RECORD\u0020*,std::allocator<PSDT_RECORD\u0020*>\u0020>* A_0)
	{
		global::<Module>.std.vector<PSDT_RECORD\u0020*,std::allocator<PSDT_RECORD\u0020*>\u0020>._Tidy(A_0);
	}

	// Token: 0x0600005F RID: 95 RVA: 0x00003FC4 File Offset: 0x000033C4
	internal unsafe static global::std._Vector_iterator<std::_Vector_val<std::_Simple_types<PSDT_RECORD\u0020*>\u0020>\u0020>* begin(global::std.vector<PSDT_RECORD\u0020*,std::allocator<PSDT_RECORD\u0020*>\u0020>* A_0, global::std._Vector_iterator<std::_Vector_val<std::_Simple_types<PSDT_RECORD\u0020*>\u0020>\u0020>* A_1)
	{
		global::<Module>.std._Vector_iterator<std::_Vector_val<std::_Simple_types<PSDT_RECORD\u0020*>\u0020>\u0020>.{ctor}(A_1, *A_0, A_0);
		return A_1;
	}

	// Token: 0x06000060 RID: 96 RVA: 0x00003FE0 File Offset: 0x000033E0
	internal unsafe static global::std._Vector_iterator<std::_Vector_val<std::_Simple_types<PSDT_RECORD\u0020*>\u0020>\u0020>* end(global::std.vector<PSDT_RECORD\u0020*,std::allocator<PSDT_RECORD\u0020*>\u0020>* A_0, global::std._Vector_iterator<std::_Vector_val<std::_Simple_types<PSDT_RECORD\u0020*>\u0020>\u0020>* A_1)
	{
		global::<Module>.std._Vector_iterator<std::_Vector_val<std::_Simple_types<PSDT_RECORD\u0020*>\u0020>\u0020>.{ctor}(A_1, *(A_0 + 4), A_0);
		return A_1;
	}

	// Token: 0x06000061 RID: 97 RVA: 0x00004750 File Offset: 0x00003B50
	internal unsafe static void clear(global::std.vector<PSDT_RECORD\u0020*,std::allocator<PSDT_RECORD\u0020*>\u0020>* A_0)
	{
		global::<Module>.std._Container_base0._Orphan_all(A_0);
		global::<Module>.std.vector<PSDT_RECORD\u0020*,std::allocator<PSDT_RECORD\u0020*>\u0020>._Destroy(A_0, *A_0, *(A_0 + 4));
		*(A_0 + 4) = *A_0;
	}

	// Token: 0x06000062 RID: 98 RVA: 0x00003708 File Offset: 0x00002B08
	internal unsafe static global::PSDT_RECORD** *(global::std._Vector_const_iterator<std::_Vector_val<std::_Simple_types<PSDT_RECORD\u0020*>\u0020>\u0020>* A_0)
	{
		return *A_0;
	}

	// Token: 0x06000063 RID: 99 RVA: 0x0000371C File Offset: 0x00002B1C
	internal unsafe static global::std._Vector_const_iterator<std::_Vector_val<std::_Simple_types<PSDT_RECORD\u0020*>\u0020>\u0020>* ++(global::std._Vector_const_iterator<std::_Vector_val<std::_Simple_types<PSDT_RECORD\u0020*>\u0020>\u0020>* A_0)
	{
		*A_0 += 4;
		return A_0;
	}

	// Token: 0x06000064 RID: 100 RVA: 0x00003FFC File Offset: 0x000033FC
	[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
	internal unsafe static bool !=(global::std._Vector_const_iterator<std::_Vector_val<std::_Simple_types<PSDT_RECORD\u0020*>\u0020>\u0020>* A_0, global::std._Vector_const_iterator<std::_Vector_val<std::_Simple_types<PSDT_RECORD\u0020*>\u0020>\u0020>* _Right)
	{
		return (global::<Module>.std._Vector_const_iterator<std::_Vector_val<std::_Simple_types<PSDT_RECORD\u0020*>\u0020>\u0020>.==(A_0, _Right) != null) ? 0 : 1;
	}

	// Token: 0x06000065 RID: 101 RVA: 0x00004018 File Offset: 0x00003418
	internal unsafe static global::std.vector<ISHITEM,std::allocator<ISHITEM>\u0020>* {ctor}(global::std.vector<ISHITEM,std::allocator<ISHITEM>\u0020>* A_0)
	{
		global::std.allocator<ISHITEM> allocator<ISHITEM>;
		global::<Module>.std._Vector_alloc<0,std::_Vec_base_types<ISHITEM,std::allocator<ISHITEM>\u0020>\u0020>.{ctor}(A_0, global::<Module>.std.allocator<ISHITEM>.{ctor}(ref allocator<ISHITEM>));
		return A_0;
	}

	// Token: 0x06000066 RID: 102 RVA: 0x000051E4 File Offset: 0x000045E4
	internal unsafe static global::std.vector<ISHITEM,std::allocator<ISHITEM>\u0020>* =(global::std.vector<ISHITEM,std::allocator<ISHITEM>\u0020>* A_0, global::std.vector<ISHITEM,std::allocator<ISHITEM>\u0020>* _Right)
	{
		if (A_0 != _Right)
		{
			global::<Module>.std.vector<ISHITEM,std::allocator<ISHITEM>\u0020>._Tidy(A_0);
			if (false)
			{
				global::std._Wrap_alloc<std::allocator<ISHITEM>\u0020> wrap_alloc<std::allocator<ISHITEM>_u0020>;
				global::<Module>.std._Vector_alloc<0,std::_Vec_base_types<ISHITEM,std::allocator<ISHITEM>\u0020>\u0020>._Change_alloc(A_0, global::<Module>.std._Vector_alloc<0,std::_Vec_base_types<ISHITEM,std::allocator<ISHITEM>\u0020>\u0020>._Getal(_Right, &wrap_alloc<std::allocator<ISHITEM>_u0020>));
			}
			global::<Module>.std.vector<ISHITEM,std::allocator<ISHITEM>\u0020>._Assign_rv(A_0, global::<Module>.std.forward<class\u0020std::vector<struct\u0020ISHITEM,class\u0020std::allocator<struct\u0020ISHITEM>\u0020>\u0020>(_Right));
		}
		return A_0;
	}

	// Token: 0x06000067 RID: 103 RVA: 0x00004FAC File Offset: 0x000043AC
	internal unsafe static void {dtor}(global::std.vector<ISHITEM,std::allocator<ISHITEM>\u0020>* A_0)
	{
		global::<Module>.std.vector<ISHITEM,std::allocator<ISHITEM>\u0020>._Tidy(A_0);
	}

	// Token: 0x06000068 RID: 104 RVA: 0x00004034 File Offset: 0x00003434
	internal unsafe static global::std._Vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020>* begin(global::std.vector<ISHITEM,std::allocator<ISHITEM>\u0020>* A_0, global::std._Vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020>* A_1)
	{
		global::<Module>.std._Vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020>.{ctor}(A_1, *A_0, A_0);
		return A_1;
	}

	// Token: 0x06000069 RID: 105 RVA: 0x00004050 File Offset: 0x00003450
	internal unsafe static global::std._Vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020>* end(global::std.vector<ISHITEM,std::allocator<ISHITEM>\u0020>* A_0, global::std._Vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020>* A_1)
	{
		global::<Module>.std._Vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020>.{ctor}(A_1, *(A_0 + 4), A_0);
		return A_1;
	}

	// Token: 0x0600006A RID: 106 RVA: 0x00004FC0 File Offset: 0x000043C0
	internal unsafe static void clear(global::std.vector<ISHITEM,std::allocator<ISHITEM>\u0020>* A_0)
	{
		global::<Module>.std._Container_base0._Orphan_all(A_0);
		global::<Module>.std.vector<ISHITEM,std::allocator<ISHITEM>\u0020>._Destroy(A_0, *A_0, *(A_0 + 4));
		*(A_0 + 4) = *A_0;
	}

	// Token: 0x0600006B RID: 107 RVA: 0x0000406C File Offset: 0x0000346C
	internal unsafe static global::ISHITEM* ->(global::std._Vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020>* A_0)
	{
		return global::<Module>.std.pointer_traits<ISHITEM\u0020*>.pointer_to(global::<Module>.std._Vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020>.*(A_0));
	}

	// Token: 0x0600006C RID: 108 RVA: 0x00004088 File Offset: 0x00003488
	internal unsafe static global::std._Vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020>* ++(global::std._Vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020>* A_0, global::std._Vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020>* A_1, int A_0)
	{
		global::std._Vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020> vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>_u0020>_u0020>;
		cpblk(ref vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>_u0020>_u0020>, A_0, 4);
		global::<Module>.std._Vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020>.++(A_0);
		cpblk(A_1, ref vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>_u0020>_u0020>, 4);
		return A_1;
	}

	// Token: 0x0600006D RID: 109 RVA: 0x000040AC File Offset: 0x000034AC
	[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
	internal unsafe static bool !=(global::std._Vector_const_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020>* A_0, global::std._Vector_const_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020>* _Right)
	{
		return (global::<Module>.std._Vector_const_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020>.==(A_0, _Right) != null) ? 0 : 1;
	}

	// Token: 0x0600006E RID: 110 RVA: 0x00004BF4 File Offset: 0x00003FF4
	internal unsafe static global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* assign(global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* A_0, sbyte* _Ptr)
	{
		return global::<Module>.std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>.assign(A_0, _Ptr, global::<Module>.std.char_traits<char>.length(_Ptr));
	}

	// Token: 0x0600006F RID: 111 RVA: 0x0000432C File Offset: 0x0000372C
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

	// Token: 0x06000070 RID: 112 RVA: 0x00003854 File Offset: 0x00002C54
	internal unsafe static global::std.allocator<char>* {ctor}(global::std.allocator<char>* A_0)
	{
		return A_0;
	}

	// Token: 0x06000071 RID: 113 RVA: 0x00003B2C File Offset: 0x00002F2C
	internal unsafe static global::std._String_alloc<0,std::_String_base_types<char,std::allocator<char>\u0020>\u0020>* {ctor}(global::std._String_alloc<0,std::_String_base_types<char,std::allocator<char>\u0020>\u0020>* A_0, global::std.allocator<char>* A_0)
	{
		global::<Module>.std._String_val<std::_Simple_types<char>\u0020>.{ctor}(A_0);
		return A_0;
	}

	// Token: 0x06000072 RID: 114 RVA: 0x00003B44 File Offset: 0x00002F44
	internal unsafe static sbyte* _Myptr(global::std._String_val<std::_Simple_types<char>\u0020>* A_0)
	{
		return (16 > *(A_0 + 20)) ? A_0 : global::<Module>.std.addressof<char>(*A_0);
	}

	// Token: 0x06000073 RID: 115 RVA: 0x00004390 File Offset: 0x00003790
	internal unsafe static void _Destroy(global::std.vector<PSDT_RECORD\u0020*,std::allocator<PSDT_RECORD\u0020*>\u0020>* A_0, global::PSDT_RECORD** _First, global::PSDT_RECORD** _Last)
	{
		global::std._Wrap_alloc<std::allocator<PSDT_RECORD\u0020*>\u0020> wrap_alloc<std::allocator<PSDT_RECORD_u0020*>_u0020>;
		global::<Module>.std._Vector_alloc<0,std::_Vec_base_types<PSDT_RECORD\u0020*,std::allocator<PSDT_RECORD\u0020*>\u0020>\u0020>._Getal(A_0, &wrap_alloc<std::allocator<PSDT_RECORD_u0020*>_u0020>);
		global::<Module>.std._Destroy_range<struct\u0020std::_Wrap_alloc<class\u0020std::allocator<struct\u0020PSDT_RECORD\u0020*>\u0020>\u0020>(_First, _Last, ref wrap_alloc<std::allocator<PSDT_RECORD_u0020*>_u0020>);
	}

	// Token: 0x06000074 RID: 116 RVA: 0x000043B0 File Offset: 0x000037B0
	internal unsafe static void _Tidy(global::std.vector<PSDT_RECORD\u0020*,std::allocator<PSDT_RECORD\u0020*>\u0020>* A_0)
	{
		if (*A_0 != 0)
		{
			global::<Module>.std._Container_base0._Orphan_all(A_0);
			global::<Module>.std.vector<PSDT_RECORD\u0020*,std::allocator<PSDT_RECORD\u0020*>\u0020>._Destroy(A_0, *A_0, *(A_0 + 4));
			global::std._Wrap_alloc<std::allocator<PSDT_RECORD\u0020*>\u0020> wrap_alloc<std::allocator<PSDT_RECORD_u0020*>_u0020>;
			global::<Module>.std._Wrap_alloc<std::allocator<PSDT_RECORD\u0020*>\u0020>.deallocate(global::<Module>.std._Vector_alloc<0,std::_Vec_base_types<PSDT_RECORD\u0020*,std::allocator<PSDT_RECORD\u0020*>\u0020>\u0020>._Getal(A_0, &wrap_alloc<std::allocator<PSDT_RECORD_u0020*>_u0020>), *A_0, (uint)(*(A_0 + 8) - *A_0 >> 2));
			*A_0 = 0;
			*(A_0 + 4) = 0;
			*(A_0 + 8) = 0;
		}
	}

	// Token: 0x06000075 RID: 117 RVA: 0x00003B68 File Offset: 0x00002F68
	[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
	internal unsafe static bool ==(global::std._Vector_const_iterator<std::_Vector_val<std::_Simple_types<PSDT_RECORD\u0020*>\u0020>\u0020>* A_0, global::std._Vector_const_iterator<std::_Vector_val<std::_Simple_types<PSDT_RECORD\u0020*>\u0020>\u0020>* _Right)
	{
		global::<Module>.std._Vector_const_iterator<std::_Vector_val<std::_Simple_types<PSDT_RECORD\u0020*>\u0020>\u0020>._Compat(A_0, _Right);
		return (*A_0 != *_Right) ? 0 : 1;
	}

	// Token: 0x06000076 RID: 118 RVA: 0x00003B88 File Offset: 0x00002F88
	internal unsafe static global::std._Vector_iterator<std::_Vector_val<std::_Simple_types<PSDT_RECORD\u0020*>\u0020>\u0020>* {ctor}(global::std._Vector_iterator<std::_Vector_val<std::_Simple_types<PSDT_RECORD\u0020*>\u0020>\u0020>* A_0, global::PSDT_RECORD** _Parg, global::std._Container_base0* _Pvector)
	{
		global::<Module>.std._Vector_const_iterator<std::_Vector_val<std::_Simple_types<PSDT_RECORD\u0020*>\u0020>\u0020>.{ctor}(A_0, _Parg, _Pvector);
		return A_0;
	}

	// Token: 0x06000077 RID: 119 RVA: 0x000051C4 File Offset: 0x000045C4
	internal unsafe static void _Assign_rv(global::std.vector<ISHITEM,std::allocator<ISHITEM>\u0020>* A_0, global::std.vector<ISHITEM,std::allocator<ISHITEM>\u0020>* _Right)
	{
		global::std.integral_constant<bool,0> _unnamed;
		initblk(ref _unnamed, 0, 1);
		global::<Module>.std.vector<ISHITEM,std::allocator<ISHITEM>\u0020>._Assign_rv(A_0, global::<Module>.std.forward<class\u0020std::vector<struct\u0020ISHITEM,class\u0020std::allocator<struct\u0020ISHITEM>\u0020>\u0020>(_Right), _unnamed);
	}

	// Token: 0x06000078 RID: 120 RVA: 0x00004F1C File Offset: 0x0000431C
	internal unsafe static void _Destroy(global::std.vector<ISHITEM,std::allocator<ISHITEM>\u0020>* A_0, global::ISHITEM* _First, global::ISHITEM* _Last)
	{
		global::std._Wrap_alloc<std::allocator<ISHITEM>\u0020> wrap_alloc<std::allocator<ISHITEM>_u0020>;
		global::<Module>.std._Vector_alloc<0,std::_Vec_base_types<ISHITEM,std::allocator<ISHITEM>\u0020>\u0020>._Getal(A_0, &wrap_alloc<std::allocator<ISHITEM>_u0020>);
		global::<Module>.std._Destroy_range<struct\u0020std::_Wrap_alloc<class\u0020std::allocator<struct\u0020ISHITEM>\u0020>\u0020>(_First, _Last, ref wrap_alloc<std::allocator<ISHITEM>_u0020>);
	}

	// Token: 0x06000079 RID: 121 RVA: 0x00004F3C File Offset: 0x0000433C
	internal unsafe static void _Tidy(global::std.vector<ISHITEM,std::allocator<ISHITEM>\u0020>* A_0)
	{
		if (*A_0 != 0)
		{
			global::<Module>.std._Container_base0._Orphan_all(A_0);
			global::<Module>.std.vector<ISHITEM,std::allocator<ISHITEM>\u0020>._Destroy(A_0, *A_0, *(A_0 + 4));
			global::std._Wrap_alloc<std::allocator<ISHITEM>\u0020> wrap_alloc<std::allocator<ISHITEM>_u0020>;
			global::<Module>.std._Wrap_alloc<std::allocator<ISHITEM>\u0020>.deallocate(global::<Module>.std._Vector_alloc<0,std::_Vec_base_types<ISHITEM,std::allocator<ISHITEM>\u0020>\u0020>._Getal(A_0, &wrap_alloc<std::allocator<ISHITEM>_u0020>), *A_0, (uint)((*(A_0 + 8) - *A_0) / 44));
			*A_0 = 0;
			*(A_0 + 4) = 0;
			*(A_0 + 8) = 0;
		}
	}

	// Token: 0x0600007A RID: 122 RVA: 0x00003854 File Offset: 0x00002C54
	internal unsafe static global::std.allocator<ISHITEM>* {ctor}(global::std.allocator<ISHITEM>* A_0)
	{
		return A_0;
	}

	// Token: 0x0600007B RID: 123 RVA: 0x00003BA0 File Offset: 0x00002FA0
	internal unsafe static global::std._Vector_alloc<0,std::_Vec_base_types<ISHITEM,std::allocator<ISHITEM>\u0020>\u0020>* {ctor}(global::std._Vector_alloc<0,std::_Vec_base_types<ISHITEM,std::allocator<ISHITEM>\u0020>\u0020>* A_0, global::std.allocator<ISHITEM>* A_0)
	{
		global::<Module>.std._Vector_val<std::_Simple_types<ISHITEM>\u0020>.{ctor}(A_0);
		return A_0;
	}

	// Token: 0x0600007C RID: 124 RVA: 0x000038E4 File Offset: 0x00002CE4
	internal unsafe static void _Change_alloc(global::std._Vector_alloc<0,std::_Vec_base_types<ISHITEM,std::allocator<ISHITEM>\u0020>\u0020>* A_0, global::std._Wrap_alloc<std::allocator<ISHITEM>\u0020>* A_0)
	{
	}

	// Token: 0x0600007D RID: 125 RVA: 0x00003BB8 File Offset: 0x00002FB8
	internal unsafe static global::std._Wrap_alloc<std::allocator<ISHITEM>\u0020>* _Getal(global::std._Vector_alloc<0,std::_Vec_base_types<ISHITEM,std::allocator<ISHITEM>\u0020>\u0020>* A_0, global::std._Wrap_alloc<std::allocator<ISHITEM>\u0020>* A_1)
	{
		global::<Module>.std._Wrap_alloc<std::allocator<ISHITEM>\u0020>.{ctor}(A_1);
		return A_1;
	}

	// Token: 0x0600007E RID: 126 RVA: 0x00003BD0 File Offset: 0x00002FD0
	internal unsafe static global::std._Vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020>* {ctor}(global::std._Vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020>* A_0, global::ISHITEM* _Parg, global::std._Container_base0* _Pvector)
	{
		global::<Module>.std._Vector_const_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020>.{ctor}(A_0, _Parg, _Pvector);
		return A_0;
	}

	// Token: 0x0600007F RID: 127 RVA: 0x00003BE8 File Offset: 0x00002FE8
	internal unsafe static global::ISHITEM* *(global::std._Vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020>* A_0)
	{
		return global::<Module>.std._Vector_const_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020>.*(A_0);
	}

	// Token: 0x06000080 RID: 128 RVA: 0x00003C00 File Offset: 0x00003000
	internal unsafe static global::std._Vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020>* ++(global::std._Vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020>* A_0)
	{
		global::<Module>.std._Vector_const_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020>.++(A_0);
		return A_0;
	}

	// Token: 0x06000081 RID: 129 RVA: 0x00003C18 File Offset: 0x00003018
	[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
	internal unsafe static bool ==(global::std._Vector_const_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020>* A_0, global::std._Vector_const_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020>* _Right)
	{
		global::<Module>.std._Vector_const_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020>._Compat(A_0, _Right);
		return (*A_0 != *_Right) ? 0 : 1;
	}

	// Token: 0x06000082 RID: 130 RVA: 0x00003C38 File Offset: 0x00003038
	internal unsafe static global::ISHITEM* pointer_to(global::ISHITEM* _Val)
	{
		return global::<Module>.std.addressof<struct\u0020ISHITEM>(_Val);
	}

	// Token: 0x06000083 RID: 131 RVA: 0x00004B08 File Offset: 0x00003F08
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

	// Token: 0x06000084 RID: 132 RVA: 0x000040C8 File Offset: 0x000034C8
	internal unsafe static void _Eos(global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* A_0, uint _Newsize)
	{
		sbyte b = 0;
		*(A_0 + 16) = (int)_Newsize;
		global::<Module>.std.char_traits<char>.assign(global::<Module>.std._String_val<std::_Simple_types<char>\u0020>._Myptr(A_0) + _Newsize, ref b);
	}

	// Token: 0x06000085 RID: 133 RVA: 0x00003C50 File Offset: 0x00003050
	internal unsafe static global::std._Wrap_alloc<std::allocator<char>\u0020>* _Getal(global::std._String_alloc<0,std::_String_base_types<char,std::allocator<char>\u0020>\u0020>* A_0, global::std._Wrap_alloc<std::allocator<char>\u0020>* A_1)
	{
		global::<Module>.std._Wrap_alloc<std::allocator<char>\u0020>.{ctor}(A_1);
		return A_1;
	}

	// Token: 0x06000086 RID: 134 RVA: 0x00003C68 File Offset: 0x00003068
	internal unsafe static void deallocate(global::std._Wrap_alloc<std::allocator<char>\u0020>* A_0, sbyte* _Ptr, uint _Count)
	{
		global::<Module>.std.allocator<char>.deallocate(A_0, _Ptr, _Count);
	}

	// Token: 0x06000087 RID: 135 RVA: 0x00003734 File Offset: 0x00002B34
	internal unsafe static global::std._String_val<std::_Simple_types<char>\u0020>* {ctor}(global::std._String_val<std::_Simple_types<char>\u0020>* A_0)
	{
		*(A_0 + 16) = 0;
		*(A_0 + 20) = 0;
		return A_0;
	}

	// Token: 0x06000088 RID: 136 RVA: 0x000040EC File Offset: 0x000034EC
	internal unsafe static global::std._Wrap_alloc<std::allocator<PSDT_RECORD\u0020*>\u0020>* _Getal(global::std._Vector_alloc<0,std::_Vec_base_types<PSDT_RECORD\u0020*,std::allocator<PSDT_RECORD\u0020*>\u0020>\u0020>* A_0, global::std._Wrap_alloc<std::allocator<PSDT_RECORD\u0020*>\u0020>* A_1)
	{
		global::<Module>.std._Wrap_alloc<std::allocator<PSDT_RECORD\u0020*>\u0020>.{ctor}(A_1);
		return A_1;
	}

	// Token: 0x06000089 RID: 137 RVA: 0x00003C80 File Offset: 0x00003080
	internal unsafe static void deallocate(global::std._Wrap_alloc<std::allocator<PSDT_RECORD\u0020*>\u0020>* A_0, global::PSDT_RECORD** _Ptr, uint _Count)
	{
		global::<Module>.std.allocator<PSDT_RECORD\u0020*>.deallocate(A_0, _Ptr, _Count);
	}

	// Token: 0x0600008A RID: 138 RVA: 0x00003768 File Offset: 0x00002B68
	internal unsafe static global::std._Vector_const_iterator<std::_Vector_val<std::_Simple_types<PSDT_RECORD\u0020*>\u0020>\u0020>* {ctor}(global::std._Vector_const_iterator<std::_Vector_val<std::_Simple_types<PSDT_RECORD\u0020*>\u0020>\u0020>* A_0, global::PSDT_RECORD** _Parg, global::std._Container_base0* _Pvector)
	{
		*A_0 = _Parg;
		global::<Module>.std._Iterator_base0._Adopt(A_0, (void*)_Pvector);
		return A_0;
	}

	// Token: 0x0600008B RID: 139 RVA: 0x000038E4 File Offset: 0x00002CE4
	internal unsafe static void _Compat(global::std._Vector_const_iterator<std::_Vector_val<std::_Simple_types<PSDT_RECORD\u0020*>\u0020>\u0020>* A_0, global::std._Vector_const_iterator<std::_Vector_val<std::_Simple_types<PSDT_RECORD\u0020*>\u0020>\u0020>* A_0)
	{
	}

	// Token: 0x0600008C RID: 140 RVA: 0x00005150 File Offset: 0x00004550
	internal unsafe static void _Assign_rv(global::std.vector<ISHITEM,std::allocator<ISHITEM>\u0020>* A_0, global::std.vector<ISHITEM,std::allocator<ISHITEM>\u0020>* _Right, global::std.integral_constant<bool,0> __unnamed001)
	{
		global::std.allocator<ISHITEM> allocator<ISHITEM>;
		global::std.allocator<ISHITEM> allocator<ISHITEM>2;
		if (global::<Module>.std.operator==<struct\u0020ISHITEM,struct\u0020ISHITEM>(global::<Module>.std.vector<ISHITEM,std::allocator<ISHITEM>\u0020>.get_allocator(A_0, &allocator<ISHITEM>), global::<Module>.std.vector<ISHITEM,std::allocator<ISHITEM>\u0020>.get_allocator(_Right, &allocator<ISHITEM>2)) != null)
		{
			global::std.integral_constant<bool,1> _unnamed;
			initblk(ref _unnamed, 0, 1);
			global::<Module>.std.vector<ISHITEM,std::allocator<ISHITEM>\u0020>._Assign_rv(A_0, global::<Module>.std.forward<class\u0020std::vector<struct\u0020ISHITEM,class\u0020std::allocator<struct\u0020ISHITEM>\u0020>\u0020>(_Right), _unnamed);
		}
		else
		{
			global::std.move_iterator<std::_Vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020>\u0020> move_iterator<std::_Vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>_u0020>_u0020>_u0020>;
			global::std._Vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020> vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>_u0020>_u0020>;
			global::std.move_iterator<std::_Vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020>\u0020> move_iterator<std::_Vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>_u0020>_u0020>_u0020>2;
			global::std._Vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020> vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>_u0020>_u0020>2;
			global::<Module>.std.vector<ISHITEM,std::allocator<ISHITEM>\u0020>._Construct<class\u0020std::move_iterator<class\u0020std::_Vector_iterator<class\u0020std::_Vector_val<struct\u0020std::_Simple_types<struct\u0020ISHITEM>\u0020>\u0020>\u0020>\u0020>(A_0, *global::<Module>.std.make_move_iterator<class\u0020std::_Vector_iterator<class\u0020std::_Vector_val<struct\u0020std::_Simple_types<struct\u0020ISHITEM>\u0020>\u0020>\u0020>(&move_iterator<std::_Vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>_u0020>_u0020>_u0020>, *global::<Module>.std.vector<ISHITEM,std::allocator<ISHITEM>\u0020>.begin(_Right, &vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>_u0020>_u0020>)), *global::<Module>.std.make_move_iterator<class\u0020std::_Vector_iterator<class\u0020std::_Vector_val<struct\u0020std::_Simple_types<struct\u0020ISHITEM>\u0020>\u0020>\u0020>(&move_iterator<std::_Vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>_u0020>_u0020>_u0020>2, *global::<Module>.std.vector<ISHITEM,std::allocator<ISHITEM>\u0020>.end(_Right, &vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>_u0020>_u0020>2)));
		}
	}

	// Token: 0x0600008D RID: 141 RVA: 0x00003750 File Offset: 0x00002B50
	internal unsafe static global::std._Wrap_alloc<std::allocator<ISHITEM>\u0020>* {ctor}(global::std._Wrap_alloc<std::allocator<ISHITEM>\u0020>* A_0)
	{
		global::<Module>.std.allocator<ISHITEM>.{ctor}(A_0);
		return A_0;
	}

	// Token: 0x0600008E RID: 142 RVA: 0x00003C98 File Offset: 0x00003098
	internal unsafe static void deallocate(global::std._Wrap_alloc<std::allocator<ISHITEM>\u0020>* A_0, global::ISHITEM* _Ptr, uint _Count)
	{
		global::<Module>.std.allocator<ISHITEM>.deallocate(A_0, _Ptr, _Count);
	}

	// Token: 0x0600008F RID: 143 RVA: 0x00003A78 File Offset: 0x00002E78
	internal unsafe static global::std._Vector_val<std::_Simple_types<ISHITEM>\u0020>* {ctor}(global::std._Vector_val<std::_Simple_types<ISHITEM>\u0020>* A_0)
	{
		*A_0 = 0;
		*(A_0 + 4) = 0;
		*(A_0 + 8) = 0;
		return A_0;
	}

	// Token: 0x06000090 RID: 144 RVA: 0x00003768 File Offset: 0x00002B68
	internal unsafe static global::std._Vector_const_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020>* {ctor}(global::std._Vector_const_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020>* A_0, global::ISHITEM* _Parg, global::std._Container_base0* _Pvector)
	{
		*A_0 = _Parg;
		global::<Module>.std._Iterator_base0._Adopt(A_0, (void*)_Pvector);
		return A_0;
	}

	// Token: 0x06000091 RID: 145 RVA: 0x00003780 File Offset: 0x00002B80
	internal unsafe static global::ISHITEM* *(global::std._Vector_const_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020>* A_0)
	{
		return *A_0;
	}

	// Token: 0x06000092 RID: 146 RVA: 0x00003794 File Offset: 0x00002B94
	internal unsafe static global::std._Vector_const_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020>* ++(global::std._Vector_const_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020>* A_0)
	{
		*A_0 += 44;
		return A_0;
	}

	// Token: 0x06000093 RID: 147 RVA: 0x000038E4 File Offset: 0x00002CE4
	internal unsafe static void _Compat(global::std._Vector_const_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020>* A_0, global::std._Vector_const_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020>* A_0)
	{
	}

	// Token: 0x06000094 RID: 148 RVA: 0x00004924 File Offset: 0x00003D24
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

	// Token: 0x06000095 RID: 149 RVA: 0x00004778 File Offset: 0x00003B78
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

	// Token: 0x06000096 RID: 150 RVA: 0x00004104 File Offset: 0x00003504
	[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
	internal unsafe static bool _Inside(global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* A_0, sbyte* _Ptr)
	{
		return _Ptr != null && _Ptr >= global::<Module>.std._String_val<std::_Simple_types<char>\u0020>._Myptr(A_0) && global::<Module>.std._String_val<std::_Simple_types<char>\u0020>._Myptr(A_0) + *(A_0 + 16) != _Ptr;
	}

	// Token: 0x06000097 RID: 151 RVA: 0x000037C4 File Offset: 0x00002BC4
	internal unsafe static void deallocate(global::std.allocator<char>* A_0, sbyte* _Ptr, uint __unnamed001)
	{
		global::<Module>.delete((void*)_Ptr);
	}

	// Token: 0x06000098 RID: 152 RVA: 0x000037AC File Offset: 0x00002BAC
	internal unsafe static global::std._Wrap_alloc<std::allocator<char>\u0020>* {ctor}(global::std._Wrap_alloc<std::allocator<char>\u0020>* A_0)
	{
		global::<Module>.std.allocator<char>.{ctor}(A_0);
		return A_0;
	}

	// Token: 0x06000099 RID: 153 RVA: 0x00003CB0 File Offset: 0x000030B0
	internal unsafe static sbyte* _Myptr(global::std._String_val<std::_Simple_types<char>\u0020>* A_0)
	{
		return (16 > *(A_0 + 20)) ? A_0 : global::<Module>.std.addressof<char>(*A_0);
	}

	// Token: 0x0600009A RID: 154 RVA: 0x000037C4 File Offset: 0x00002BC4
	internal unsafe static void deallocate(global::std.allocator<PSDT_RECORD\u0020*>* A_0, global::PSDT_RECORD** _Ptr, uint __unnamed001)
	{
		global::<Module>.delete((void*)_Ptr);
	}

	// Token: 0x0600009B RID: 155 RVA: 0x00003CD4 File Offset: 0x000030D4
	internal unsafe static global::std._Wrap_alloc<std::allocator<PSDT_RECORD\u0020*>\u0020>* {ctor}(global::std._Wrap_alloc<std::allocator<PSDT_RECORD\u0020*>\u0020>* A_0)
	{
		global::<Module>.std.allocator<PSDT_RECORD\u0020*>.{ctor}(A_0);
		return A_0;
	}

	// Token: 0x0600009C RID: 156 RVA: 0x000037D8 File Offset: 0x00002BD8
	internal unsafe static void _Assign_rv(global::std.vector<ISHITEM,std::allocator<ISHITEM>\u0020>* A_0, global::std.vector<ISHITEM,std::allocator<ISHITEM>\u0020>* _Right, global::std.integral_constant<bool,1> __unnamed001)
	{
		global::<Module>.std._Container_base0._Swap_all(A_0, _Right);
		*A_0 = *_Right;
		*(A_0 + 4) = *(_Right + 4);
		*(A_0 + 8) = *(_Right + 8);
		*_Right = 0;
		*(_Right + 4) = 0;
		*(_Right + 8) = 0;
	}

	// Token: 0x0600009D RID: 157 RVA: 0x00003CEC File Offset: 0x000030EC
	internal unsafe static global::std.allocator<ISHITEM>* get_allocator(global::std.vector<ISHITEM,std::allocator<ISHITEM>\u0020>* A_0, global::std.allocator<ISHITEM>* A_1)
	{
		global::std._Wrap_alloc<std::allocator<ISHITEM>\u0020> wrap_alloc<std::allocator<ISHITEM>_u0020>;
		global::<Module>.std.allocator<ISHITEM>.{ctor}(A_1, global::<Module>.std._Vector_alloc<0,std::_Vec_base_types<ISHITEM,std::allocator<ISHITEM>\u0020>\u0020>._Getal(A_0, &wrap_alloc<std::allocator<ISHITEM>_u0020>));
		return A_1;
	}

	// Token: 0x0600009E RID: 158 RVA: 0x000037C4 File Offset: 0x00002BC4
	internal unsafe static void deallocate(global::std.allocator<ISHITEM>* A_0, global::ISHITEM* _Ptr, uint __unnamed001)
	{
		global::<Module>.delete((void*)_Ptr);
	}

	// Token: 0x0600009F RID: 159 RVA: 0x00004134 File Offset: 0x00003534
	internal unsafe static global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* erase(global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* A_0, uint _Off)
	{
		if (*(A_0 + 16) < (int)_Off)
		{
			global::<Module>.std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>._Xran(A_0);
		}
		global::<Module>.std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>._Eos(A_0, _Off);
		return A_0;
	}

	// Token: 0x060000A0 RID: 160 RVA: 0x0000415C File Offset: 0x0000355C
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

	// Token: 0x060000A1 RID: 161 RVA: 0x00003810 File Offset: 0x00002C10
	internal unsafe static uint size(global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* A_0)
	{
		return *(A_0 + 16);
	}

	// Token: 0x060000A2 RID: 162 RVA: 0x000043F8 File Offset: 0x000037F8
	internal unsafe static uint max_size(global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* A_0)
	{
		global::std._Wrap_alloc<std::allocator<char>\u0020> wrap_alloc<std::allocator<char>_u0020>;
		uint num = global::<Module>.std._Wrap_alloc<std::allocator<char>\u0020>.max_size(global::<Module>.std._String_alloc<0,std::_String_base_types<char,std::allocator<char>\u0020>\u0020>._Getal(A_0, &wrap_alloc<std::allocator<char>_u0020>));
		return (num > 1U) ? (num - 1U) : 1U;
	}

	// Token: 0x060000A3 RID: 163 RVA: 0x00004420 File Offset: 0x00003820
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

	// Token: 0x060000A4 RID: 164 RVA: 0x00003824 File Offset: 0x00002C24
	internal unsafe static void _Xlen(global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* A_0)
	{
		global::<Module>.std._Xlength_error((sbyte*)(&global::<Module>.??_C@_0BA@JFNIOLAK@string?5too?5long?$AA@));
	}

	// Token: 0x060000A5 RID: 165 RVA: 0x0000383C File Offset: 0x00002C3C
	internal unsafe static void _Xran(global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* A_0)
	{
		global::<Module>.std._Xout_of_range((sbyte*)(&global::<Module>.??_C@_0BI@CFPLBAOH@invalid?5string?5position?$AA@));
	}

	// Token: 0x060000A6 RID: 166 RVA: 0x00003854 File Offset: 0x00002C54
	internal unsafe static global::std.allocator<PSDT_RECORD\u0020*>* {ctor}(global::std.allocator<PSDT_RECORD\u0020*>* A_0)
	{
		return A_0;
	}

	// Token: 0x060000A7 RID: 167 RVA: 0x00003854 File Offset: 0x00002C54
	internal unsafe static global::std.allocator<ISHITEM>* {ctor}(global::std.allocator<ISHITEM>* A_0, global::std.allocator<ISHITEM>* A_0)
	{
		return A_0;
	}

	// Token: 0x060000A8 RID: 168 RVA: 0x000041B8 File Offset: 0x000035B8
	internal unsafe static sbyte* allocate(global::std._Wrap_alloc<std::allocator<char>\u0020>* A_0, uint _Count)
	{
		return global::<Module>.std.allocator<char>.allocate(A_0, _Count);
	}

	// Token: 0x060000A9 RID: 169 RVA: 0x000041D0 File Offset: 0x000035D0
	internal unsafe static uint max_size(global::std._Wrap_alloc<std::allocator<char>\u0020>* A_0)
	{
		return global::<Module>.std.allocator_traits<std::allocator<char>\u0020>.max_size(A_0);
	}

	// Token: 0x060000AA RID: 170 RVA: 0x00003D0C File Offset: 0x0000310C
	internal unsafe static sbyte* allocate(global::std.allocator<char>* A_0, uint _Count)
	{
		return global::<Module>.std._Allocate<char>(_Count, null);
	}

	// Token: 0x060000AB RID: 171 RVA: 0x00003D24 File Offset: 0x00003124
	internal unsafe static uint max_size(global::std.allocator<char>* _Al)
	{
		return global::<Module>.std.allocator<char>.max_size(_Al);
	}

	// Token: 0x060000AC RID: 172 RVA: 0x00003A94 File Offset: 0x00002E94
	internal unsafe static uint max_size(global::std.allocator<char>* A_0)
	{
		return -1;
	}

	// Token: 0x060000AD RID: 173 RVA: 0x00003864 File Offset: 0x00002C64
	internal unsafe static global::std.vector<ISHITEM,std::allocator<ISHITEM>\u0020>* forward<class\u0020std::vector<struct\u0020ISHITEM,class\u0020std::allocator<struct\u0020ISHITEM>\u0020>\u0020>(global::std.vector<ISHITEM,std::allocator<ISHITEM>\u0020>* _Arg)
	{
		return _Arg;
	}

	// Token: 0x060000AE RID: 174 RVA: 0x000041E8 File Offset: 0x000035E8
	internal unsafe static void destroy<char\u0020*>(global::std._Wrap_alloc<std::allocator<char>\u0020>* A_0, sbyte** _Ptr)
	{
		global::<Module>.std.allocator_traits<std::allocator<char>\u0020>.destroy<char\u0020*>(A_0, _Ptr);
	}

	// Token: 0x060000AF RID: 175 RVA: 0x00003874 File Offset: 0x00002C74
	internal unsafe static sbyte* addressof<char>(sbyte* _Val)
	{
		return _Val;
	}

	// Token: 0x060000B0 RID: 176 RVA: 0x00003D3C File Offset: 0x0000313C
	internal unsafe static void _Destroy_range<struct\u0020std::_Wrap_alloc<class\u0020std::allocator<struct\u0020PSDT_RECORD\u0020*>\u0020>\u0020>(global::PSDT_RECORD** _First, global::PSDT_RECORD** _Last, global::std._Wrap_alloc<std::allocator<PSDT_RECORD\u0020*>\u0020>* _Al)
	{
		global::std._Scalar_ptr_iterator_tag _unnamed = global::<Module>.std._Ptr_cat<struct\u0020PSDT_RECORD\u0020*,struct\u0020PSDT_RECORD\u0020*>(_First, _Last);
		global::<Module>.std._Destroy_range<struct\u0020std::_Wrap_alloc<class\u0020std::allocator<struct\u0020PSDT_RECORD\u0020*>\u0020>\u0020>(_First, _Last, _Al, _unnamed);
	}

	// Token: 0x060000B1 RID: 177 RVA: 0x00004E00 File Offset: 0x00004200
	internal unsafe static void _Destroy_range<struct\u0020std::_Wrap_alloc<class\u0020std::allocator<struct\u0020ISHITEM>\u0020>\u0020>(global::ISHITEM* _First, global::ISHITEM* _Last, global::std._Wrap_alloc<std::allocator<ISHITEM>\u0020>* _Al)
	{
		global::std._Nonscalar_ptr_iterator_tag _unnamed = global::<Module>.std._Ptr_cat<struct\u0020ISHITEM,struct\u0020ISHITEM>(_First, _Last);
		global::<Module>.std._Destroy_range<struct\u0020std::_Wrap_alloc<class\u0020std::allocator<struct\u0020ISHITEM>\u0020>\u0020>(_First, _Last, _Al, _unnamed);
	}

	// Token: 0x060000B2 RID: 178 RVA: 0x000039E4 File Offset: 0x00002DE4
	internal unsafe static global::ISHITEM* addressof<struct\u0020ISHITEM>(global::ISHITEM* _Val)
	{
		return _Val;
	}

	// Token: 0x060000B3 RID: 179 RVA: 0x00003884 File Offset: 0x00002C84
	[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
	internal unsafe static bool operator==<struct\u0020ISHITEM,struct\u0020ISHITEM>(global::std.allocator<ISHITEM>* A_0, global::std.allocator<ISHITEM>* A_1)
	{
		return 1;
	}

	// Token: 0x060000B4 RID: 180 RVA: 0x00003D5C File Offset: 0x0000315C
	internal unsafe static global::std.move_iterator<std::_Vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020>\u0020>* make_move_iterator<class\u0020std::_Vector_iterator<class\u0020std::_Vector_val<struct\u0020std::_Simple_types<struct\u0020ISHITEM>\u0020>\u0020>\u0020>(global::std.move_iterator<std::_Vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020>\u0020>* A_0, global::std._Vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020> _Iter)
	{
		global::<Module>.std.move_iterator<std::_Vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020>\u0020>.{ctor}(A_0, _Iter);
		return A_0;
	}

	// Token: 0x060000B5 RID: 181 RVA: 0x00005128 File Offset: 0x00004528
	internal unsafe static void _Construct<class\u0020std::move_iterator<class\u0020std::_Vector_iterator<class\u0020std::_Vector_val<struct\u0020std::_Simple_types<struct\u0020ISHITEM>\u0020>\u0020>\u0020>\u0020>(global::std.vector<ISHITEM,std::allocator<ISHITEM>\u0020>* A_0, global::std.move_iterator<std::_Vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020>\u0020> _First, global::std.move_iterator<std::_Vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020>\u0020> _Last)
	{
		global::std.forward_iterator_tag _unnamed;
		global::std.random_access_iterator_tag random_access_iterator_tag;
		cpblk(ref _unnamed, global::<Module>.std._Iter_cat<class\u0020std::move_iterator<class\u0020std::_Vector_iterator<class\u0020std::_Vector_val<struct\u0020std::_Simple_types<struct\u0020ISHITEM>\u0020>\u0020>\u0020>\u0020>(&random_access_iterator_tag, ref _First), 1);
		global::<Module>.std.vector<ISHITEM,std::allocator<ISHITEM>\u0020>._Construct<class\u0020std::move_iterator<class\u0020std::_Vector_iterator<class\u0020std::_Vector_val<struct\u0020std::_Simple_types<struct\u0020ISHITEM>\u0020>\u0020>\u0020>\u0020>(A_0, _First, _Last, _unnamed);
	}

	// Token: 0x060000B6 RID: 182 RVA: 0x000041FC File Offset: 0x000035FC
	internal unsafe static void construct<char\u0020*,char\u0020*\u0020&>(global::std._Wrap_alloc<std::allocator<char>\u0020>* A_0, sbyte** _Ptr, sbyte** <_Args_0>)
	{
		global::<Module>.std.allocator_traits<std::allocator<char>\u0020>.construct<char\u0020*,char\u0020*\u0020&>(A_0, _Ptr, global::<Module>.std.forward<char\u0020*\u0020&>(<_Args_0>));
	}

	// Token: 0x060000B7 RID: 183 RVA: 0x00003894 File Offset: 0x00002C94
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

	// Token: 0x060000B8 RID: 184 RVA: 0x000038C0 File Offset: 0x00002CC0
	internal unsafe static global::std.move_iterator<std::_Vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020>\u0020>* {ctor}(global::std.move_iterator<std::_Vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020>\u0020>* A_0, global::std._Vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020> _Right)
	{
		cpblk(A_0, ref _Right, 4);
		return A_0;
	}

	// Token: 0x060000B9 RID: 185 RVA: 0x00003D74 File Offset: 0x00003174
	internal unsafe static void destroy<char\u0020*>(global::std.allocator<char>* _Al, sbyte** _Ptr)
	{
		global::<Module>.std.allocator<char>.destroy<char\u0020*>(_Al, _Ptr);
	}

	// Token: 0x060000BA RID: 186 RVA: 0x000038D4 File Offset: 0x00002CD4
	internal unsafe static global::std._Scalar_ptr_iterator_tag _Ptr_cat<struct\u0020PSDT_RECORD\u0020*,struct\u0020PSDT_RECORD\u0020*>(global::PSDT_RECORD** A_0, global::PSDT_RECORD** A_1)
	{
		global::std._Scalar_ptr_iterator_tag result;
		return result;
	}

	// Token: 0x060000BB RID: 187 RVA: 0x000038E4 File Offset: 0x00002CE4
	internal unsafe static void _Destroy_range<struct\u0020std::_Wrap_alloc<class\u0020std::allocator<struct\u0020PSDT_RECORD\u0020*>\u0020>\u0020>(global::PSDT_RECORD** _First, global::PSDT_RECORD** _Last, global::std._Wrap_alloc<std::allocator<PSDT_RECORD\u0020*>\u0020>* _Al, global::std._Scalar_ptr_iterator_tag __unnamed003)
	{
	}

	// Token: 0x060000BC RID: 188 RVA: 0x00003A40 File Offset: 0x00002E40
	internal unsafe static global::std._Nonscalar_ptr_iterator_tag _Ptr_cat<struct\u0020ISHITEM,struct\u0020ISHITEM>(global::ISHITEM* A_0, global::ISHITEM* A_1)
	{
		global::std._Nonscalar_ptr_iterator_tag result;
		return result;
	}

	// Token: 0x060000BD RID: 189 RVA: 0x00004DC0 File Offset: 0x000041C0
	internal unsafe static void _Destroy_range<struct\u0020std::_Wrap_alloc<class\u0020std::allocator<struct\u0020ISHITEM>\u0020>\u0020>(global::ISHITEM* _First, global::ISHITEM* _Last, global::std._Wrap_alloc<std::allocator<ISHITEM>\u0020>* _Al, global::std._Nonscalar_ptr_iterator_tag __unnamed003)
	{
		while (_First != _Last)
		{
			global::<Module>.std._Wrap_alloc<std::allocator<ISHITEM>\u0020>.destroy<struct\u0020ISHITEM>(_Al, _First);
			_First += 44 / sizeof(global::ISHITEM);
		}
	}

	// Token: 0x060000BE RID: 190 RVA: 0x000038F4 File Offset: 0x00002CF4
	internal unsafe static global::std.random_access_iterator_tag* _Iter_cat<class\u0020std::move_iterator<class\u0020std::_Vector_iterator<class\u0020std::_Vector_val<struct\u0020std::_Simple_types<struct\u0020ISHITEM>\u0020>\u0020>\u0020>\u0020>(global::std.random_access_iterator_tag* A_0, global::std.move_iterator<std::_Vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020>\u0020>* A_0)
	{
		global::std.random_access_iterator_tag random_access_iterator_tag;
		cpblk(A_0, ref random_access_iterator_tag, 1);
		return A_0;
	}

	// Token: 0x060000BF RID: 191 RVA: 0x0000504C File Offset: 0x0000444C
	internal unsafe static void _Construct<class\u0020std::move_iterator<class\u0020std::_Vector_iterator<class\u0020std::_Vector_val<struct\u0020std::_Simple_types<struct\u0020ISHITEM>\u0020>\u0020>\u0020>\u0020>(global::std.vector<ISHITEM,std::allocator<ISHITEM>\u0020>* A_0, global::std.move_iterator<std::_Vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020>\u0020> _First, global::std.move_iterator<std::_Vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020>\u0020> _Last, global::std.forward_iterator_tag __unnamed002)
	{
		int num = (int)stackalloc byte[global::<Module>.__CxxQueryExceptionSize() * 1];
		if (global::<Module>.std.vector<ISHITEM,std::allocator<ISHITEM>\u0020>._Buy(A_0, global::<Module>.std.distance<class\u0020std::move_iterator<class\u0020std::_Vector_iterator<class\u0020std::_Vector_val<struct\u0020std::_Simple_types<struct\u0020ISHITEM>\u0020>\u0020>\u0020>\u0020>(_First, _Last)) != null)
		{
			uint exceptionCode;
			try
			{
				*(A_0 + 4) = global::<Module>.std.vector<ISHITEM,std::allocator<ISHITEM>\u0020>._Ucopy<class\u0020std::move_iterator<class\u0020std::_Vector_iterator<class\u0020std::_Vector_val<struct\u0020std::_Simple_types<struct\u0020ISHITEM>\u0020>\u0020>\u0020>\u0020>(A_0, _First, _Last, *A_0);
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
						global::<Module>.std.vector<ISHITEM,std::allocator<ISHITEM>\u0020>._Tidy(A_0);
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
		}
	}

	// Token: 0x060000C0 RID: 192 RVA: 0x00003910 File Offset: 0x00002D10
	internal unsafe static sbyte** forward<char\u0020*\u0020&>(sbyte** _Arg)
	{
		return _Arg;
	}

	// Token: 0x060000C1 RID: 193 RVA: 0x00003D88 File Offset: 0x00003188
	internal unsafe static void construct<char\u0020*,char\u0020*\u0020&>(global::std.allocator<char>* _Al, sbyte** _Ptr, sbyte** <_Args_0>)
	{
		global::<Module>.std.allocator<char>.construct<char\u0020*,char\u0020*\u0020&>(_Al, _Ptr, global::<Module>.std.forward<char\u0020*\u0020&>(<_Args_0>));
	}

	// Token: 0x060000C2 RID: 194 RVA: 0x000047E4 File Offset: 0x00003BE4
	[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
	internal unsafe static bool _Buy(global::std.vector<ISHITEM,std::allocator<ISHITEM>\u0020>* A_0, uint _Capacity)
	{
		*A_0 = 0;
		*(A_0 + 4) = 0;
		*(A_0 + 8) = 0;
		bool result;
		if (_Capacity == 0U)
		{
			result = false;
		}
		else
		{
			if (global::<Module>.std.vector<ISHITEM,std::allocator<ISHITEM>\u0020>.max_size(A_0) < _Capacity)
			{
				global::<Module>.std.vector<ISHITEM,std::allocator<ISHITEM>\u0020>._Xlen(A_0);
			}
			else
			{
				global::std._Wrap_alloc<std::allocator<ISHITEM>\u0020> wrap_alloc<std::allocator<ISHITEM>_u0020>;
				*A_0 = global::<Module>.std._Wrap_alloc<std::allocator<ISHITEM>\u0020>.allocate(global::<Module>.std._Vector_alloc<0,std::_Vec_base_types<ISHITEM,std::allocator<ISHITEM>\u0020>\u0020>._Getal(A_0, &wrap_alloc<std::allocator<ISHITEM>_u0020>), _Capacity);
				*(A_0 + 4) = *A_0;
				*(A_0 + 8) = *A_0 + (int)(_Capacity * 44U);
			}
			result = true;
		}
		return result;
	}

	// Token: 0x060000C3 RID: 195 RVA: 0x00004630 File Offset: 0x00003A30
	internal unsafe static uint max_size(global::std.vector<ISHITEM,std::allocator<ISHITEM>\u0020>* A_0)
	{
		global::std._Wrap_alloc<std::allocator<ISHITEM>\u0020> wrap_alloc<std::allocator<ISHITEM>_u0020>;
		return global::<Module>.std._Wrap_alloc<std::allocator<ISHITEM>\u0020>.max_size(global::<Module>.std._Vector_alloc<0,std::_Vec_base_types<ISHITEM,std::allocator<ISHITEM>\u0020>\u0020>._Getal(A_0, &wrap_alloc<std::allocator<ISHITEM>_u0020>));
	}

	// Token: 0x060000C4 RID: 196 RVA: 0x00003920 File Offset: 0x00002D20
	internal unsafe static void _Xlen(global::std.vector<ISHITEM,std::allocator<ISHITEM>\u0020>* A_0)
	{
		global::<Module>.std._Xlength_error((sbyte*)(&global::<Module>.??_C@_0BD@OLBABOEK@vector?$DMT?$DO?5too?5long?$AA@));
	}

	// Token: 0x060000C5 RID: 197 RVA: 0x00004218 File Offset: 0x00003618
	internal unsafe static global::ISHITEM* allocate(global::std._Wrap_alloc<std::allocator<ISHITEM>\u0020>* A_0, uint _Count)
	{
		return global::<Module>.std.allocator<ISHITEM>.allocate(A_0, _Count);
	}

	// Token: 0x060000C6 RID: 198 RVA: 0x00003DA4 File Offset: 0x000031A4
	internal unsafe static global::ISHITEM* allocate(global::std.allocator<ISHITEM>* A_0, uint _Count)
	{
		return global::<Module>.std._Allocate<struct\u0020ISHITEM>(_Count, null);
	}

	// Token: 0x060000C7 RID: 199 RVA: 0x00004230 File Offset: 0x00003630
	internal unsafe static uint max_size(global::std._Wrap_alloc<std::allocator<ISHITEM>\u0020>* A_0)
	{
		return global::<Module>.std.allocator_traits<std::allocator<ISHITEM>\u0020>.max_size(A_0);
	}

	// Token: 0x060000C8 RID: 200 RVA: 0x00003DBC File Offset: 0x000031BC
	internal unsafe static uint max_size(global::std.allocator<ISHITEM>* _Al)
	{
		return global::<Module>.std.allocator<ISHITEM>.max_size(_Al);
	}

	// Token: 0x060000C9 RID: 201 RVA: 0x00003938 File Offset: 0x00002D38
	internal unsafe static uint max_size(global::std.allocator<ISHITEM>* A_0)
	{
		return 97612893;
	}

	// Token: 0x060000CA RID: 202 RVA: 0x000038E4 File Offset: 0x00002CE4
	internal unsafe static void destroy<char\u0020*>(global::std.allocator<char>* A_0, sbyte** _Ptr)
	{
	}

	// Token: 0x060000CB RID: 203 RVA: 0x00004D90 File Offset: 0x00004190
	internal unsafe static void destroy<struct\u0020ISHITEM>(global::std._Wrap_alloc<std::allocator<ISHITEM>\u0020>* A_0, global::ISHITEM* _Ptr)
	{
		global::<Module>.std.allocator_traits<std::allocator<ISHITEM>\u0020>.destroy<struct\u0020ISHITEM>(A_0, _Ptr);
	}

	// Token: 0x060000CC RID: 204 RVA: 0x0000483C File Offset: 0x00003C3C
	internal unsafe static int distance<class\u0020std::move_iterator<class\u0020std::_Vector_iterator<class\u0020std::_Vector_val<struct\u0020std::_Simple_types<struct\u0020ISHITEM>\u0020>\u0020>\u0020>\u0020>(global::std.move_iterator<std::_Vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020>\u0020> _First, global::std.move_iterator<std::_Vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020>\u0020> _Last)
	{
		int result = 0;
		global::std.random_access_iterator_tag random_access_iterator_tag;
		global::<Module>.std._Distance2<class\u0020std::move_iterator<class\u0020std::_Vector_iterator<class\u0020std::_Vector_val<struct\u0020std::_Simple_types<struct\u0020ISHITEM>\u0020>\u0020>\u0020>,int>(_First, _Last, ref result, *global::<Module>.std._Iter_cat<class\u0020std::move_iterator<class\u0020std::_Vector_iterator<class\u0020std::_Vector_val<struct\u0020std::_Simple_types<struct\u0020ISHITEM>\u0020>\u0020>\u0020>\u0020>(&random_access_iterator_tag, ref _First));
		return result;
	}

	// Token: 0x060000CD RID: 205 RVA: 0x00005028 File Offset: 0x00004428
	internal unsafe static global::ISHITEM* _Ucopy<class\u0020std::move_iterator<class\u0020std::_Vector_iterator<class\u0020std::_Vector_val<struct\u0020std::_Simple_types<struct\u0020ISHITEM>\u0020>\u0020>\u0020>\u0020>(global::std.vector<ISHITEM,std::allocator<ISHITEM>\u0020>* A_0, global::std.move_iterator<std::_Vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020>\u0020> _First, global::std.move_iterator<std::_Vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020>\u0020> _Last, global::ISHITEM* _Ptr)
	{
		global::std._Wrap_alloc<std::allocator<ISHITEM>\u0020> wrap_alloc<std::allocator<ISHITEM>_u0020>;
		global::<Module>.std._Vector_alloc<0,std::_Vec_base_types<ISHITEM,std::allocator<ISHITEM>\u0020>\u0020>._Getal(A_0, &wrap_alloc<std::allocator<ISHITEM>_u0020>);
		return global::<Module>.std._Uninitialized_copy<class\u0020std::move_iterator<class\u0020std::_Vector_iterator<class\u0020std::_Vector_val<struct\u0020std::_Simple_types<struct\u0020ISHITEM>\u0020>\u0020>\u0020>,struct\u0020ISHITEM\u0020*,struct\u0020std::_Wrap_alloc<class\u0020std::allocator<struct\u0020ISHITEM>\u0020>\u0020>(_First, _Last, _Ptr, ref wrap_alloc<std::allocator<ISHITEM>_u0020>);
	}

	// Token: 0x060000CE RID: 206 RVA: 0x0000394C File Offset: 0x00002D4C
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

	// Token: 0x060000CF RID: 207 RVA: 0x00003998 File Offset: 0x00002D98
	internal unsafe static global::ISHITEM* _Allocate<struct\u0020ISHITEM>(uint _Count, global::ISHITEM* __unnamed001)
	{
		void* ptr = null;
		if (_Count != 0U)
		{
			if (97612893U >= _Count)
			{
				ptr = global::<Module>.@new(_Count * 44U);
				if (ptr != null)
				{
					return ptr;
				}
			}
			global::<Module>.std._Xbad_alloc();
		}
		return ptr;
	}

	// Token: 0x060000D0 RID: 208 RVA: 0x00004D2C File Offset: 0x0000412C
	internal unsafe static void destroy<struct\u0020ISHITEM>(global::std.allocator<ISHITEM>* _Al, global::ISHITEM* _Ptr)
	{
		global::<Module>.std.allocator<ISHITEM>.destroy<struct\u0020ISHITEM>(_Al, _Ptr);
	}

	// Token: 0x060000D1 RID: 209 RVA: 0x0000464C File Offset: 0x00003A4C
	internal unsafe static void _Distance2<class\u0020std::move_iterator<class\u0020std::_Vector_iterator<class\u0020std::_Vector_val<struct\u0020std::_Simple_types<struct\u0020ISHITEM>\u0020>\u0020>\u0020>,int>(global::std.move_iterator<std::_Vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020>\u0020> _First, global::std.move_iterator<std::_Vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020>\u0020> _Last, int* _Off, global::std.random_access_iterator_tag __unnamed003)
	{
		*_Off += global::<Module>.std.operator-<class\u0020std::_Vector_iterator<class\u0020std::_Vector_val<struct\u0020std::_Simple_types<struct\u0020ISHITEM>\u0020>\u0020>,class\u0020std::_Vector_iterator<class\u0020std::_Vector_val<struct\u0020std::_Simple_types<struct\u0020ISHITEM>\u0020>\u0020>\u0020>(ref _Last, ref _First);
	}

	// Token: 0x060000D2 RID: 210 RVA: 0x00004FE8 File Offset: 0x000043E8
	internal unsafe static global::ISHITEM* _Uninitialized_copy<class\u0020std::move_iterator<class\u0020std::_Vector_iterator<class\u0020std::_Vector_val<struct\u0020std::_Simple_types<struct\u0020ISHITEM>\u0020>\u0020>\u0020>,struct\u0020ISHITEM\u0020*,struct\u0020std::_Wrap_alloc<class\u0020std::allocator<struct\u0020ISHITEM>\u0020>\u0020>(global::std.move_iterator<std::_Vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020>\u0020> _First, global::std.move_iterator<std::_Vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020>\u0020> _Last, global::ISHITEM* _Dest, global::std._Wrap_alloc<std::allocator<ISHITEM>\u0020>* _Al)
	{
		global::std.move_iterator<std::_Vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020>\u0020> move_iterator<std::_Vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>_u0020>_u0020>_u0020>;
		global::std.move_iterator<std::_Vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020>\u0020> move_iterator<std::_Vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>_u0020>_u0020>_u0020>2;
		return *global::<Module>.std._Rechecked<struct\u0020ISHITEM\u0020*,struct\u0020ISHITEM\u0020*>(ref _Dest, global::<Module>.std._Uninit_copy<class\u0020std::move_iterator<class\u0020std::_Vector_iterator<class\u0020std::_Vector_val<struct\u0020std::_Simple_types<struct\u0020ISHITEM>\u0020>\u0020>\u0020>,struct\u0020ISHITEM\u0020*,struct\u0020std::_Wrap_alloc<class\u0020std::allocator<struct\u0020ISHITEM>\u0020>\u0020>(*global::<Module>.std._Unchecked<class\u0020std::move_iterator<class\u0020std::_Vector_iterator<class\u0020std::_Vector_val<struct\u0020std::_Simple_types<struct\u0020ISHITEM>\u0020>\u0020>\u0020>\u0020>(&move_iterator<std::_Vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>_u0020>_u0020>_u0020>, _First), *global::<Module>.std._Unchecked<class\u0020std::move_iterator<class\u0020std::_Vector_iterator<class\u0020std::_Vector_val<struct\u0020std::_Simple_types<struct\u0020ISHITEM>\u0020>\u0020>\u0020>\u0020>(&move_iterator<std::_Vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>_u0020>_u0020>_u0020>2, _Last), global::<Module>.std._Unchecked<struct\u0020ISHITEM\u0020*>(_Dest), _Al));
	}

	// Token: 0x060000D3 RID: 211 RVA: 0x00004CAC File Offset: 0x000040AC
	internal unsafe static void destroy<struct\u0020ISHITEM>(global::std.allocator<ISHITEM>* A_0, global::ISHITEM* _Ptr)
	{
		global::<Module>.ISHITEM.__delDtor(_Ptr, 0U);
	}

	// Token: 0x060000D4 RID: 212 RVA: 0x00004248 File Offset: 0x00003648
	internal unsafe static int operator-<class\u0020std::_Vector_iterator<class\u0020std::_Vector_val<struct\u0020std::_Simple_types<struct\u0020ISHITEM>\u0020>\u0020>,class\u0020std::_Vector_iterator<class\u0020std::_Vector_val<struct\u0020std::_Simple_types<struct\u0020ISHITEM>\u0020>\u0020>\u0020>(global::std.move_iterator<std::_Vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020>\u0020>* _Left, global::std.move_iterator<std::_Vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020>\u0020>* _Right)
	{
		global::std._Vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020> vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>_u0020>_u0020>;
		global::std._Vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020> vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>_u0020>_u0020>2;
		return global::<Module>.std._Vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020>.-(global::<Module>.std.move_iterator<std::_Vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020>\u0020>.base(_Left, &vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>_u0020>_u0020>), global::<Module>.std.move_iterator<std::_Vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020>\u0020>.base(_Right, &vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>_u0020>_u0020>2));
	}

	// Token: 0x060000D5 RID: 213 RVA: 0x000039CC File Offset: 0x00002DCC
	internal unsafe static global::std.move_iterator<std::_Vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020>\u0020>* _Unchecked<class\u0020std::move_iterator<class\u0020std::_Vector_iterator<class\u0020std::_Vector_val<struct\u0020std::_Simple_types<struct\u0020ISHITEM>\u0020>\u0020>\u0020>\u0020>(global::std.move_iterator<std::_Vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020>\u0020>* A_0, global::std.move_iterator<std::_Vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020>\u0020> _Src)
	{
		cpblk(A_0, ref _Src, 4);
		return A_0;
	}

	// Token: 0x060000D6 RID: 214 RVA: 0x000039E4 File Offset: 0x00002DE4
	internal unsafe static global::ISHITEM* _Unchecked<struct\u0020ISHITEM\u0020*>(global::ISHITEM* _Src)
	{
		return _Src;
	}

	// Token: 0x060000D7 RID: 215 RVA: 0x00004F88 File Offset: 0x00004388
	internal unsafe static global::ISHITEM* _Uninit_copy<class\u0020std::move_iterator<class\u0020std::_Vector_iterator<class\u0020std::_Vector_val<struct\u0020std::_Simple_types<struct\u0020ISHITEM>\u0020>\u0020>\u0020>,struct\u0020ISHITEM\u0020*,struct\u0020std::_Wrap_alloc<class\u0020std::allocator<struct\u0020ISHITEM>\u0020>\u0020>(global::std.move_iterator<std::_Vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020>\u0020> _First, global::std.move_iterator<std::_Vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020>\u0020> _Last, global::ISHITEM* _Dest, global::std._Wrap_alloc<std::allocator<ISHITEM>\u0020>* _Al)
	{
		global::std._Nonscalar_ptr_iterator_tag _unnamed = global::<Module>.std._Ptr_cat<class\u0020std::move_iterator<class\u0020std::_Vector_iterator<class\u0020std::_Vector_val<struct\u0020std::_Simple_types<struct\u0020ISHITEM>\u0020>\u0020>\u0020>,struct\u0020ISHITEM\u0020*>(ref _First, ref _Dest);
		return global::<Module>.std._Uninit_copy<class\u0020std::move_iterator<class\u0020std::_Vector_iterator<class\u0020std::_Vector_val<struct\u0020std::_Simple_types<struct\u0020ISHITEM>\u0020>\u0020>\u0020>,struct\u0020ISHITEM\u0020*,class\u0020std::allocator<struct\u0020ISHITEM>\u0020>(_First, _Last, _Dest, _Al, _unnamed);
	}

	// Token: 0x060000D8 RID: 216 RVA: 0x000039F4 File Offset: 0x00002DF4
	internal unsafe static global::ISHITEM** _Rechecked<struct\u0020ISHITEM\u0020*,struct\u0020ISHITEM\u0020*>(global::ISHITEM** _Dest, global::ISHITEM* _Src)
	{
		*_Dest = _Src;
		return _Dest;
	}

	// Token: 0x060000D9 RID: 217 RVA: 0x00004C10 File Offset: 0x00004010
	internal unsafe static void* __delDtor(global::ISHITEM* A_0, uint A_0)
	{
		global::<Module>.ISHITEM.{dtor}(A_0);
		if ((A_0 & 1U) != 0U)
		{
			global::<Module>.delete(A_0);
		}
		return A_0;
	}

	// Token: 0x060000DA RID: 218 RVA: 0x00004B54 File Offset: 0x00003F54
	internal unsafe static void {dtor}(global::ISHITEM* A_0)
	{
		try
		{
			global::<Module>.std.vector<unsigned\u0020char,std::allocator<unsigned\u0020char>\u0020>.{dtor}(A_0 + 32);
		}
		catch
		{
			global::<Module>.___CxxCallUnwindDtor(ldftn(ISHINFORMATION.{dtor}), A_0);
			throw;
		}
		global::<Module>.ISHINFORMATION.{dtor}(A_0);
	}

	// Token: 0x060000DB RID: 219 RVA: 0x00004994 File Offset: 0x00003D94
	internal unsafe static void {dtor}(global::ISHINFORMATION* A_0)
	{
		global::<Module>.ISHITEMNAME.{dtor}(A_0);
	}

	// Token: 0x060000DC RID: 220 RVA: 0x00004868 File Offset: 0x00003C68
	internal unsafe static void {dtor}(global::ISHITEMNAME* A_0)
	{
		global::<Module>.std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>.{dtor}(A_0);
	}

	// Token: 0x060000DD RID: 221 RVA: 0x000049A8 File Offset: 0x00003DA8
	internal unsafe static void {dtor}(global::std.vector<unsigned\u0020char,std::allocator<unsigned\u0020char>\u0020>* A_0)
	{
		global::<Module>.std.vector<unsigned\u0020char,std::allocator<unsigned\u0020char>\u0020>._Tidy(A_0);
	}

	// Token: 0x060000DE RID: 222 RVA: 0x00003DD4 File Offset: 0x000031D4
	internal unsafe static int -(global::std._Vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020>* A_0, global::std._Vector_const_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020>* _Right)
	{
		return global::<Module>.std._Vector_const_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020>.-(A_0, _Right);
	}

	// Token: 0x060000DF RID: 223 RVA: 0x00003A08 File Offset: 0x00002E08
	internal unsafe static global::std._Vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020>* @base(global::std.move_iterator<std::_Vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020>\u0020>* A_0, global::std._Vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020>* A_1)
	{
		cpblk(A_1, A_0, 4);
		return A_1;
	}

	// Token: 0x060000E0 RID: 224 RVA: 0x0000487C File Offset: 0x00003C7C
	internal unsafe static void _Tidy(global::std.vector<unsigned\u0020char,std::allocator<unsigned\u0020char>\u0020>* A_0)
	{
		if (*A_0 != 0)
		{
			global::<Module>.std._Container_base0._Orphan_all(A_0);
			global::<Module>.std.vector<unsigned\u0020char,std::allocator<unsigned\u0020char>\u0020>._Destroy(A_0, *A_0, *(A_0 + 4));
			global::std._Wrap_alloc<std::allocator<unsigned\u0020char>\u0020> wrap_alloc<std::allocator<unsigned_u0020char>_u0020>;
			global::<Module>.std._Wrap_alloc<std::allocator<unsigned\u0020char>\u0020>.deallocate(global::<Module>.std._Vector_alloc<0,std::_Vec_base_types<unsigned\u0020char,std::allocator<unsigned\u0020char>\u0020>\u0020>._Getal(A_0, &wrap_alloc<std::allocator<unsigned_u0020char>_u0020>), *A_0, (uint)(*(A_0 + 8) - *A_0));
			*A_0 = 0;
			*(A_0 + 4) = 0;
			*(A_0 + 8) = 0;
		}
	}

	// Token: 0x060000E1 RID: 225 RVA: 0x00003A20 File Offset: 0x00002E20
	internal unsafe static int -(global::std._Vector_const_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020>* A_0, global::std._Vector_const_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020>* _Right)
	{
		global::<Module>.std._Vector_const_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020>._Compat(A_0, _Right);
		return (*A_0 - *_Right) / 44;
	}

	// Token: 0x060000E2 RID: 226 RVA: 0x00004668 File Offset: 0x00003A68
	internal unsafe static void _Destroy(global::std.vector<unsigned\u0020char,std::allocator<unsigned\u0020char>\u0020>* A_0, byte* _First, byte* _Last)
	{
		global::std._Wrap_alloc<std::allocator<unsigned\u0020char>\u0020> wrap_alloc<std::allocator<unsigned_u0020char>_u0020>;
		global::<Module>.std._Vector_alloc<0,std::_Vec_base_types<unsigned\u0020char,std::allocator<unsigned\u0020char>\u0020>\u0020>._Getal(A_0, &wrap_alloc<std::allocator<unsigned_u0020char>_u0020>);
		global::<Module>.std._Destroy_range<struct\u0020std::_Wrap_alloc<class\u0020std::allocator<unsigned\u0020char>\u0020>\u0020>(_First, _Last, ref wrap_alloc<std::allocator<unsigned_u0020char>_u0020>);
	}

	// Token: 0x060000E3 RID: 227 RVA: 0x0000426C File Offset: 0x0000366C
	internal unsafe static global::std._Wrap_alloc<std::allocator<unsigned\u0020char>\u0020>* _Getal(global::std._Vector_alloc<0,std::_Vec_base_types<unsigned\u0020char,std::allocator<unsigned\u0020char>\u0020>\u0020>* A_0, global::std._Wrap_alloc<std::allocator<unsigned\u0020char>\u0020>* A_1)
	{
		global::<Module>.std._Wrap_alloc<std::allocator<unsigned\u0020char>\u0020>.{ctor}(A_1);
		return A_1;
	}

	// Token: 0x060000E4 RID: 228 RVA: 0x00003DEC File Offset: 0x000031EC
	internal unsafe static void deallocate(global::std._Wrap_alloc<std::allocator<unsigned\u0020char>\u0020>* A_0, byte* _Ptr, uint _Count)
	{
		global::<Module>.std.allocator<unsigned\u0020char>.deallocate(A_0, _Ptr, _Count);
	}

	// Token: 0x060000E5 RID: 229 RVA: 0x000037C4 File Offset: 0x00002BC4
	internal unsafe static void deallocate(global::std.allocator<unsigned\u0020char>* A_0, byte* _Ptr, uint __unnamed001)
	{
		global::<Module>.delete((void*)_Ptr);
	}

	// Token: 0x060000E6 RID: 230 RVA: 0x00003E04 File Offset: 0x00003204
	internal unsafe static global::std._Wrap_alloc<std::allocator<unsigned\u0020char>\u0020>* {ctor}(global::std._Wrap_alloc<std::allocator<unsigned\u0020char>\u0020>* A_0)
	{
		global::<Module>.std.allocator<unsigned\u0020char>.{ctor}(A_0);
		return A_0;
	}

	// Token: 0x060000E7 RID: 231 RVA: 0x00003854 File Offset: 0x00002C54
	internal unsafe static global::std.allocator<unsigned\u0020char>* {ctor}(global::std.allocator<unsigned\u0020char>* A_0)
	{
		return A_0;
	}

	// Token: 0x060000E8 RID: 232 RVA: 0x00003A40 File Offset: 0x00002E40
	internal unsafe static global::std._Nonscalar_ptr_iterator_tag _Ptr_cat<class\u0020std::move_iterator<class\u0020std::_Vector_iterator<class\u0020std::_Vector_val<struct\u0020std::_Simple_types<struct\u0020ISHITEM>\u0020>\u0020>\u0020>,struct\u0020ISHITEM\u0020*>(global::std.move_iterator<std::_Vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020>\u0020>* A_0, global::ISHITEM** A_1)
	{
		global::std._Nonscalar_ptr_iterator_tag result;
		return result;
	}

	// Token: 0x060000E9 RID: 233 RVA: 0x00004E20 File Offset: 0x00004220
	internal unsafe static global::ISHITEM* _Uninit_copy<class\u0020std::move_iterator<class\u0020std::_Vector_iterator<class\u0020std::_Vector_val<struct\u0020std::_Simple_types<struct\u0020ISHITEM>\u0020>\u0020>\u0020>,struct\u0020ISHITEM\u0020*,class\u0020std::allocator<struct\u0020ISHITEM>\u0020>(global::std.move_iterator<std::_Vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020>\u0020> _First, global::std.move_iterator<std::_Vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020>\u0020> _Last, global::ISHITEM* _Dest, global::std._Wrap_alloc<std::allocator<ISHITEM>\u0020>* _Al, global::std._Nonscalar_ptr_iterator_tag __unnamed004)
	{
		int num = (int)stackalloc byte[global::<Module>.__CxxQueryExceptionSize() * 1];
		global::ISHITEM* ptr = _Dest;
		uint exceptionCode;
		try
		{
			while (global::<Module>.std.operator!=<class\u0020std::_Vector_iterator<class\u0020std::_Vector_val<struct\u0020std::_Simple_types<struct\u0020ISHITEM>\u0020>\u0020>,class\u0020std::_Vector_iterator<class\u0020std::_Vector_val<struct\u0020std::_Simple_types<struct\u0020ISHITEM>\u0020>\u0020>\u0020>(ref _First, ref _Last) != null)
			{
				global::<Module>.std._Wrap_alloc<std::allocator<ISHITEM>\u0020>.construct<struct\u0020ISHITEM,struct\u0020ISHITEM>(_Al, _Dest, global::<Module>.std.move_iterator<std::_Vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020>\u0020>.*(ref _First));
				_Dest += 44 / sizeof(global::ISHITEM);
				global::<Module>.std.move_iterator<std::_Vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020>\u0020>.++(ref _First);
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
						global::<Module>.std._Wrap_alloc<std::allocator<ISHITEM>\u0020>.destroy<struct\u0020ISHITEM>(_Al, ptr);
						ptr += 44 / sizeof(global::ISHITEM);
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

	// Token: 0x060000EA RID: 234 RVA: 0x00003E1C File Offset: 0x0000321C
	internal unsafe static void _Destroy_range<struct\u0020std::_Wrap_alloc<class\u0020std::allocator<unsigned\u0020char>\u0020>\u0020>(byte* _First, byte* _Last, global::std._Wrap_alloc<std::allocator<unsigned\u0020char>\u0020>* _Al)
	{
		global::std._Scalar_ptr_iterator_tag _unnamed = global::<Module>.std._Ptr_cat<unsigned\u0020char,unsigned\u0020char>(_First, _Last);
		global::<Module>.std._Destroy_range<struct\u0020std::_Wrap_alloc<class\u0020std::allocator<unsigned\u0020char>\u0020>\u0020>(_First, _Last, _Al, _unnamed);
	}

	// Token: 0x060000EB RID: 235 RVA: 0x00003E3C File Offset: 0x0000323C
	internal unsafe static global::ISHITEM* *(global::std.move_iterator<std::_Vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020>\u0020>* A_0)
	{
		return global::<Module>.std.move<struct\u0020ISHITEM\u0020&>(global::<Module>.std._Vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020>.*(A_0));
	}

	// Token: 0x060000EC RID: 236 RVA: 0x00003E58 File Offset: 0x00003258
	internal unsafe static global::std.move_iterator<std::_Vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020>\u0020>* ++(global::std.move_iterator<std::_Vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020>\u0020>* A_0)
	{
		global::<Module>.std._Vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020>.++(A_0);
		return A_0;
	}

	// Token: 0x060000ED RID: 237 RVA: 0x00004688 File Offset: 0x00003A88
	[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
	internal unsafe static bool operator!=<class\u0020std::_Vector_iterator<class\u0020std::_Vector_val<struct\u0020std::_Simple_types<struct\u0020ISHITEM>\u0020>\u0020>,class\u0020std::_Vector_iterator<class\u0020std::_Vector_val<struct\u0020std::_Simple_types<struct\u0020ISHITEM>\u0020>\u0020>\u0020>(global::std.move_iterator<std::_Vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020>\u0020>* _Left, global::std.move_iterator<std::_Vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020>\u0020>* _Right)
	{
		return (global::<Module>.std.operator==<class\u0020std::_Vector_iterator<class\u0020std::_Vector_val<struct\u0020std::_Simple_types<struct\u0020ISHITEM>\u0020>\u0020>,class\u0020std::_Vector_iterator<class\u0020std::_Vector_val<struct\u0020std::_Simple_types<struct\u0020ISHITEM>\u0020>\u0020>\u0020>(_Left, _Right) != null) ? 0 : 1;
	}

	// Token: 0x060000EE RID: 238 RVA: 0x00004DE4 File Offset: 0x000041E4
	internal unsafe static void construct<struct\u0020ISHITEM,struct\u0020ISHITEM>(global::std._Wrap_alloc<std::allocator<ISHITEM>\u0020>* A_0, global::ISHITEM* _Ptr, global::ISHITEM* <_Args_0>)
	{
		global::<Module>.std.allocator_traits<std::allocator<ISHITEM>\u0020>.construct<struct\u0020ISHITEM,struct\u0020ISHITEM>(A_0, _Ptr, global::<Module>.std.forward<struct\u0020ISHITEM>(<_Args_0>));
	}

	// Token: 0x060000EF RID: 239 RVA: 0x000038D4 File Offset: 0x00002CD4
	internal unsafe static global::std._Scalar_ptr_iterator_tag _Ptr_cat<unsigned\u0020char,unsigned\u0020char>(byte* A_0, byte* A_1)
	{
		global::std._Scalar_ptr_iterator_tag result;
		return result;
	}

	// Token: 0x060000F0 RID: 240 RVA: 0x000038E4 File Offset: 0x00002CE4
	internal unsafe static void _Destroy_range<struct\u0020std::_Wrap_alloc<class\u0020std::allocator<unsigned\u0020char>\u0020>\u0020>(byte* _First, byte* _Last, global::std._Wrap_alloc<std::allocator<unsigned\u0020char>\u0020>* _Al, global::std._Scalar_ptr_iterator_tag __unnamed003)
	{
	}

	// Token: 0x060000F1 RID: 241 RVA: 0x00003A50 File Offset: 0x00002E50
	internal unsafe static global::ISHITEM* move<struct\u0020ISHITEM\u0020&>(global::ISHITEM* _Arg)
	{
		return _Arg;
	}

	// Token: 0x060000F2 RID: 242 RVA: 0x00004284 File Offset: 0x00003684
	[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
	internal unsafe static bool operator==<class\u0020std::_Vector_iterator<class\u0020std::_Vector_val<struct\u0020std::_Simple_types<struct\u0020ISHITEM>\u0020>\u0020>,class\u0020std::_Vector_iterator<class\u0020std::_Vector_val<struct\u0020std::_Simple_types<struct\u0020ISHITEM>\u0020>\u0020>\u0020>(global::std.move_iterator<std::_Vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020>\u0020>* _Left, global::std.move_iterator<std::_Vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020>\u0020>* _Right)
	{
		return global::<Module>.std.move_iterator<std::_Vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020>\u0020>._Equal<class\u0020std::_Vector_iterator<class\u0020std::_Vector_val<struct\u0020std::_Simple_types<struct\u0020ISHITEM>\u0020>\u0020>\u0020>(_Left, _Right);
	}

	// Token: 0x060000F3 RID: 243 RVA: 0x00003A50 File Offset: 0x00002E50
	internal unsafe static global::ISHITEM* forward<struct\u0020ISHITEM>(global::ISHITEM* _Arg)
	{
		return _Arg;
	}

	// Token: 0x060000F4 RID: 244 RVA: 0x00004DA4 File Offset: 0x000041A4
	internal unsafe static void construct<struct\u0020ISHITEM,struct\u0020ISHITEM>(global::std.allocator<ISHITEM>* _Al, global::ISHITEM* _Ptr, global::ISHITEM* <_Args_0>)
	{
		global::<Module>.std.allocator<ISHITEM>.construct<struct\u0020ISHITEM,struct\u0020ISHITEM>(_Al, _Ptr, global::<Module>.std.forward<struct\u0020ISHITEM>(<_Args_0>));
	}

	// Token: 0x060000F5 RID: 245 RVA: 0x00003E70 File Offset: 0x00003270
	[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
	internal unsafe static bool _Equal<class\u0020std::_Vector_iterator<class\u0020std::_Vector_val<struct\u0020std::_Simple_types<struct\u0020ISHITEM>\u0020>\u0020>\u0020>(global::std.move_iterator<std::_Vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020>\u0020>* A_0, global::std.move_iterator<std::_Vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020>\u0020>* _Right)
	{
		global::std._Vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020> vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>_u0020>_u0020>;
		return global::<Module>.std._Vector_const_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020>.==(A_0, global::<Module>.std.move_iterator<std::_Vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>\u0020>\u0020>\u0020>.base(_Right, &vector_iterator<std::_Vector_val<std::_Simple_types<ISHITEM>_u0020>_u0020>));
	}

	// Token: 0x060000F6 RID: 246 RVA: 0x00004D40 File Offset: 0x00004140
	internal unsafe static void construct<struct\u0020ISHITEM,struct\u0020ISHITEM>(global::std.allocator<ISHITEM>* A_0, global::ISHITEM* _Ptr, global::ISHITEM* <_Args_0>)
	{
		global::ISHITEM* ptr = global::<Module>.@new(44U, (void*)_Ptr);
		try
		{
			global::ISHITEM* ptr2 = (ptr == null) ? 0 : global::<Module>.ISHITEM.{ctor}(ptr, global::<Module>.std.forward<struct\u0020ISHITEM>(<_Args_0>));
		}
		catch
		{
			global::<Module>.delete((void*)ptr, (void*)_Ptr);
			throw;
		}
	}

	// Token: 0x060000F7 RID: 247 RVA: 0x00004CC4 File Offset: 0x000040C4
	internal unsafe static global::ISHITEM* {ctor}(global::ISHITEM* A_0, global::ISHITEM* A_0)
	{
		global::<Module>.ISHINFORMATION.{ctor}(A_0, A_0);
		try
		{
			global::<Module>.std.vector<unsigned\u0020char,std::allocator<unsigned\u0020char>\u0020>.{ctor}(A_0 + 32, A_0 + 32);
		}
		catch
		{
			global::<Module>.___CxxCallUnwindDtor(ldftn(ISHINFORMATION.{dtor}), A_0);
			throw;
		}
		return A_0;
	}

	// Token: 0x060000F8 RID: 248 RVA: 0x00004C34 File Offset: 0x00004034
	internal unsafe static global::ISHINFORMATION* {ctor}(global::ISHINFORMATION* A_0, global::ISHINFORMATION* A_0)
	{
		global::<Module>.ISHITEMNAME.{ctor}(A_0, A_0);
		try
		{
			*(A_0 + 28) = *(A_0 + 28);
		}
		catch
		{
			global::<Module>.___CxxCallUnwindDtor(ldftn(ISHITEMNAME.{dtor}), A_0);
			throw;
		}
		return A_0;
	}

	// Token: 0x060000F9 RID: 249 RVA: 0x00004B9C File Offset: 0x00003F9C
	internal unsafe static global::ISHITEMNAME* {ctor}(global::ISHITEMNAME* A_0, global::ISHITEMNAME* A_0)
	{
		global::<Module>.std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>.{ctor}(A_0, A_0);
		try
		{
			*(A_0 + 24) = (short)(*(A_0 + 24));
			*(A_0 + 26) = (short)(*(A_0 + 26));
		}
		catch
		{
			global::<Module>.___CxxCallUnwindDtor(ldftn(std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>.{dtor}), A_0);
			throw;
		}
		return A_0;
	}

	// Token: 0x060000FA RID: 250 RVA: 0x000049BC File Offset: 0x00003DBC
	internal unsafe static global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* {ctor}(global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* A_0, global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* _Right)
	{
		global::std._Wrap_alloc<std::allocator<char>\u0020> wrap_alloc<std::allocator<char>_u0020>;
		global::std._Wrap_alloc<std::allocator<char>\u0020> wrap_alloc<std::allocator<char>_u0020>2;
		global::<Module>.std._String_alloc<0,std::_String_base_types<char,std::allocator<char>\u0020>\u0020>.{ctor}(A_0, global::<Module>.std._Wrap_alloc<std::allocator<char>\u0020>.select_on_container_copy_construction(global::<Module>.std._String_alloc<0,std::_String_base_types<char,std::allocator<char>\u0020>\u0020>._Getal(_Right, &wrap_alloc<std::allocator<char>_u0020>), &wrap_alloc<std::allocator<char>_u0020>2));
		global::<Module>.std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>._Tidy(A_0, false, 0U);
		global::<Module>.std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>.assign(A_0, _Right, 0U, global::<Module>.?npos@?$basic_string@DU?$char_traits@D@std@@V?$allocator@D@2@@std@@2IB);
		return A_0;
	}

	// Token: 0x060000FB RID: 251 RVA: 0x000049F8 File Offset: 0x00003DF8
	internal unsafe static global::std.vector<unsigned\u0020char,std::allocator<unsigned\u0020char>\u0020>* {ctor}(global::std.vector<unsigned\u0020char,std::allocator<unsigned\u0020char>\u0020>* A_0, global::std.vector<unsigned\u0020char,std::allocator<unsigned\u0020char>\u0020>* _Right)
	{
		int num = (int)stackalloc byte[global::<Module>.__CxxQueryExceptionSize() * 1];
		global::std._Wrap_alloc<std::allocator<unsigned\u0020char>\u0020> wrap_alloc<std::allocator<unsigned_u0020char>_u0020>;
		global::std._Wrap_alloc<std::allocator<unsigned\u0020char>\u0020> wrap_alloc<std::allocator<unsigned_u0020char>_u0020>2;
		global::<Module>.std._Vector_alloc<0,std::_Vec_base_types<unsigned\u0020char,std::allocator<unsigned\u0020char>\u0020>\u0020>.{ctor}(A_0, global::<Module>.std._Wrap_alloc<std::allocator<unsigned\u0020char>\u0020>.select_on_container_copy_construction(global::<Module>.std._Vector_alloc<0,std::_Vec_base_types<unsigned\u0020char,std::allocator<unsigned\u0020char>\u0020>\u0020>._Getal(_Right, &wrap_alloc<std::allocator<unsigned_u0020char>_u0020>), &wrap_alloc<std::allocator<unsigned_u0020char>_u0020>2));
		if (global::<Module>.std.vector<unsigned\u0020char,std::allocator<unsigned\u0020char>\u0020>._Buy(A_0, global::<Module>.std.vector<unsigned\u0020char,std::allocator<unsigned\u0020char>\u0020>.size(_Right)) != null)
		{
			uint exceptionCode;
			try
			{
				global::std._Vector_const_iterator<std::_Vector_val<std::_Simple_types<unsigned\u0020char>\u0020>\u0020> vector_const_iterator<std::_Vector_val<std::_Simple_types<unsigned_u0020char>_u0020>_u0020>;
				global::std._Vector_const_iterator<std::_Vector_val<std::_Simple_types<unsigned\u0020char>\u0020>\u0020> vector_const_iterator<std::_Vector_val<std::_Simple_types<unsigned_u0020char>_u0020>_u0020>2;
				*(A_0 + 4) = global::<Module>.std.vector<unsigned\u0020char,std::allocator<unsigned\u0020char>\u0020>._Ucopy<class\u0020std::_Vector_const_iterator<class\u0020std::_Vector_val<struct\u0020std::_Simple_types<unsigned\u0020char>\u0020>\u0020>\u0020>(A_0, *global::<Module>.std.vector<unsigned\u0020char,std::allocator<unsigned\u0020char>\u0020>.begin(_Right, &vector_const_iterator<std::_Vector_val<std::_Simple_types<unsigned_u0020char>_u0020>_u0020>), *global::<Module>.std.vector<unsigned\u0020char,std::allocator<unsigned\u0020char>\u0020>.end(_Right, &vector_const_iterator<std::_Vector_val<std::_Simple_types<unsigned_u0020char>_u0020>_u0020>2), *A_0);
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
						global::<Module>.std.vector<unsigned\u0020char,std::allocator<unsigned\u0020char>\u0020>._Tidy(A_0);
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
		}
		return A_0;
	}

	// Token: 0x060000FC RID: 252 RVA: 0x000046A4 File Offset: 0x00003AA4
	internal unsafe static global::std._Wrap_alloc<std::allocator<char>\u0020>* select_on_container_copy_construction(global::std._Wrap_alloc<std::allocator<char>\u0020>* A_0, global::std._Wrap_alloc<std::allocator<char>\u0020>* A_1)
	{
		global::std.allocator<char> allocator<char>;
		global::<Module>.std._Wrap_alloc<std::allocator<char>\u0020>.{ctor}(A_1, global::<Module>.std.allocator_traits<std::allocator<char>\u0020>.select_on_container_copy_construction(&allocator<char>, A_0));
		return A_1;
	}

	// Token: 0x060000FD RID: 253 RVA: 0x00003E90 File Offset: 0x00003290
	internal unsafe static global::std._Vector_const_iterator<std::_Vector_val<std::_Simple_types<unsigned\u0020char>\u0020>\u0020>* begin(global::std.vector<unsigned\u0020char,std::allocator<unsigned\u0020char>\u0020>* A_0, global::std._Vector_const_iterator<std::_Vector_val<std::_Simple_types<unsigned\u0020char>\u0020>\u0020>* A_1)
	{
		global::<Module>.std._Vector_const_iterator<std::_Vector_val<std::_Simple_types<unsigned\u0020char>\u0020>\u0020>.{ctor}(A_1, *A_0, A_0);
		return A_1;
	}

	// Token: 0x060000FE RID: 254 RVA: 0x00003EAC File Offset: 0x000032AC
	internal unsafe static global::std._Vector_const_iterator<std::_Vector_val<std::_Simple_types<unsigned\u0020char>\u0020>\u0020>* end(global::std.vector<unsigned\u0020char,std::allocator<unsigned\u0020char>\u0020>* A_0, global::std._Vector_const_iterator<std::_Vector_val<std::_Simple_types<unsigned\u0020char>\u0020>\u0020>* A_1)
	{
		global::<Module>.std._Vector_const_iterator<std::_Vector_val<std::_Simple_types<unsigned\u0020char>\u0020>\u0020>.{ctor}(A_1, *(A_0 + 4), A_0);
		return A_1;
	}

	// Token: 0x060000FF RID: 255 RVA: 0x00003A60 File Offset: 0x00002E60
	internal unsafe static uint size(global::std.vector<unsigned\u0020char,std::allocator<unsigned\u0020char>\u0020>* A_0)
	{
		return *(A_0 + 4) - *A_0;
	}

	// Token: 0x06000100 RID: 256 RVA: 0x000048C4 File Offset: 0x00003CC4
	[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
	internal unsafe static bool _Buy(global::std.vector<unsigned\u0020char,std::allocator<unsigned\u0020char>\u0020>* A_0, uint _Capacity)
	{
		*A_0 = 0;
		*(A_0 + 4) = 0;
		*(A_0 + 8) = 0;
		bool result;
		if (_Capacity == 0U)
		{
			result = false;
		}
		else
		{
			if (global::<Module>.std.vector<unsigned\u0020char,std::allocator<unsigned\u0020char>\u0020>.max_size(A_0) < _Capacity)
			{
				global::<Module>.std.vector<unsigned\u0020char,std::allocator<unsigned\u0020char>\u0020>._Xlen(A_0);
			}
			else
			{
				global::std._Wrap_alloc<std::allocator<unsigned\u0020char>\u0020> wrap_alloc<std::allocator<unsigned_u0020char>_u0020>;
				*A_0 = global::<Module>.std._Wrap_alloc<std::allocator<unsigned\u0020char>\u0020>.allocate(global::<Module>.std._Vector_alloc<0,std::_Vec_base_types<unsigned\u0020char,std::allocator<unsigned\u0020char>\u0020>\u0020>._Getal(A_0, &wrap_alloc<std::allocator<unsigned_u0020char>_u0020>), _Capacity);
				*(A_0 + 4) = *A_0;
				*(A_0 + 8) = *A_0 + (int)_Capacity;
			}
			result = true;
		}
		return result;
	}

	// Token: 0x06000101 RID: 257 RVA: 0x00003EC8 File Offset: 0x000032C8
	internal unsafe static global::std._Vector_alloc<0,std::_Vec_base_types<unsigned\u0020char,std::allocator<unsigned\u0020char>\u0020>\u0020>* {ctor}(global::std._Vector_alloc<0,std::_Vec_base_types<unsigned\u0020char,std::allocator<unsigned\u0020char>\u0020>\u0020>* A_0, global::std.allocator<unsigned\u0020char>* A_0)
	{
		global::<Module>.std._Vector_val<std::_Simple_types<unsigned\u0020char>\u0020>.{ctor}(A_0);
		return A_0;
	}

	// Token: 0x06000102 RID: 258 RVA: 0x000046C4 File Offset: 0x00003AC4
	internal unsafe static global::std._Wrap_alloc<std::allocator<unsigned\u0020char>\u0020>* select_on_container_copy_construction(global::std._Wrap_alloc<std::allocator<unsigned\u0020char>\u0020>* A_0, global::std._Wrap_alloc<std::allocator<unsigned\u0020char>\u0020>* A_1)
	{
		global::std.allocator<unsigned\u0020char> allocator<unsigned_u0020char>;
		global::<Module>.std._Wrap_alloc<std::allocator<unsigned\u0020char>\u0020>.{ctor}(A_1, global::<Module>.std.allocator_traits<std::allocator<unsigned\u0020char>\u0020>.select_on_container_copy_construction(&allocator<unsigned_u0020char>, A_0));
		return A_1;
	}

	// Token: 0x06000103 RID: 259 RVA: 0x00003EE0 File Offset: 0x000032E0
	internal unsafe static global::std._Wrap_alloc<std::allocator<char>\u0020>* {ctor}(global::std._Wrap_alloc<std::allocator<char>\u0020>* A_0, global::std.allocator<char>* _Right)
	{
		global::<Module>.std.allocator<char>.{ctor}(A_0, _Right);
		return A_0;
	}

	// Token: 0x06000104 RID: 260 RVA: 0x0000429C File Offset: 0x0000369C
	internal unsafe static global::std.allocator<char>* select_on_container_copy_construction(global::std.allocator<char>* A_0, global::std.allocator<char>* _Al)
	{
		global::<Module>.std.allocator<char>.select_on_container_copy_construction(_Al, A_0);
		return A_0;
	}

	// Token: 0x06000105 RID: 261 RVA: 0x000046E4 File Offset: 0x00003AE4
	internal unsafe static uint max_size(global::std.vector<unsigned\u0020char,std::allocator<unsigned\u0020char>\u0020>* A_0)
	{
		global::std._Wrap_alloc<std::allocator<unsigned\u0020char>\u0020> wrap_alloc<std::allocator<unsigned_u0020char>_u0020>;
		return global::<Module>.std._Wrap_alloc<std::allocator<unsigned\u0020char>\u0020>.max_size(global::<Module>.std._Vector_alloc<0,std::_Vec_base_types<unsigned\u0020char,std::allocator<unsigned\u0020char>\u0020>\u0020>._Getal(A_0, &wrap_alloc<std::allocator<unsigned_u0020char>_u0020>));
	}

	// Token: 0x06000106 RID: 262 RVA: 0x00003920 File Offset: 0x00002D20
	internal unsafe static void _Xlen(global::std.vector<unsigned\u0020char,std::allocator<unsigned\u0020char>\u0020>* A_0)
	{
		global::<Module>.std._Xlength_error((sbyte*)(&global::<Module>.??_C@_0BD@OLBABOEK@vector?$DMT?$DO?5too?5long?$AA@));
	}

	// Token: 0x06000107 RID: 263 RVA: 0x00003EF8 File Offset: 0x000032F8
	internal unsafe static global::std._Wrap_alloc<std::allocator<unsigned\u0020char>\u0020>* {ctor}(global::std._Wrap_alloc<std::allocator<unsigned\u0020char>\u0020>* A_0, global::std.allocator<unsigned\u0020char>* _Right)
	{
		global::<Module>.std.allocator<unsigned\u0020char>.{ctor}(A_0, _Right);
		return A_0;
	}

	// Token: 0x06000108 RID: 264 RVA: 0x000042B4 File Offset: 0x000036B4
	internal unsafe static byte* allocate(global::std._Wrap_alloc<std::allocator<unsigned\u0020char>\u0020>* A_0, uint _Count)
	{
		return global::<Module>.std.allocator<unsigned\u0020char>.allocate(A_0, _Count);
	}

	// Token: 0x06000109 RID: 265 RVA: 0x000042CC File Offset: 0x000036CC
	internal unsafe static global::std.allocator<unsigned\u0020char>* select_on_container_copy_construction(global::std.allocator<unsigned\u0020char>* A_0, global::std.allocator<unsigned\u0020char>* _Al)
	{
		global::<Module>.std.allocator<unsigned\u0020char>.select_on_container_copy_construction(_Al, A_0);
		return A_0;
	}

	// Token: 0x0600010A RID: 266 RVA: 0x00003A78 File Offset: 0x00002E78
	internal unsafe static global::std._Vector_val<std::_Simple_types<unsigned\u0020char>\u0020>* {ctor}(global::std._Vector_val<std::_Simple_types<unsigned\u0020char>\u0020>* A_0)
	{
		*A_0 = 0;
		*(A_0 + 4) = 0;
		*(A_0 + 8) = 0;
		return A_0;
	}

	// Token: 0x0600010B RID: 267 RVA: 0x00003768 File Offset: 0x00002B68
	internal unsafe static global::std._Vector_const_iterator<std::_Vector_val<std::_Simple_types<unsigned\u0020char>\u0020>\u0020>* {ctor}(global::std._Vector_const_iterator<std::_Vector_val<std::_Simple_types<unsigned\u0020char>\u0020>\u0020>* A_0, byte* _Parg, global::std._Container_base0* _Pvector)
	{
		*A_0 = _Parg;
		global::<Module>.std._Iterator_base0._Adopt(A_0, (void*)_Pvector);
		return A_0;
	}

	// Token: 0x0600010C RID: 268 RVA: 0x00003F10 File Offset: 0x00003310
	internal unsafe static global::std.allocator<char>* select_on_container_copy_construction(global::std.allocator<char>* A_0, global::std.allocator<char>* A_1)
	{
		global::<Module>.std.allocator<char>.{ctor}(A_1, A_0);
		return A_1;
	}

	// Token: 0x0600010D RID: 269 RVA: 0x00003854 File Offset: 0x00002C54
	internal unsafe static global::std.allocator<char>* {ctor}(global::std.allocator<char>* A_0, global::std.allocator<char>* A_0)
	{
		return A_0;
	}

	// Token: 0x0600010E RID: 270 RVA: 0x00003F28 File Offset: 0x00003328
	internal unsafe static global::std.allocator<unsigned\u0020char>* select_on_container_copy_construction(global::std.allocator<unsigned\u0020char>* A_0, global::std.allocator<unsigned\u0020char>* A_1)
	{
		global::<Module>.std.allocator<unsigned\u0020char>.{ctor}(A_1, A_0);
		return A_1;
	}

	// Token: 0x0600010F RID: 271 RVA: 0x00003854 File Offset: 0x00002C54
	internal unsafe static global::std.allocator<unsigned\u0020char>* {ctor}(global::std.allocator<unsigned\u0020char>* A_0, global::std.allocator<unsigned\u0020char>* A_0)
	{
		return A_0;
	}

	// Token: 0x06000110 RID: 272 RVA: 0x00003F40 File Offset: 0x00003340
	internal unsafe static byte* allocate(global::std.allocator<unsigned\u0020char>* A_0, uint _Count)
	{
		return global::<Module>.std._Allocate<unsigned\u0020char>(_Count, null);
	}

	// Token: 0x06000111 RID: 273 RVA: 0x000042E4 File Offset: 0x000036E4
	internal unsafe static uint max_size(global::std._Wrap_alloc<std::allocator<unsigned\u0020char>\u0020>* A_0)
	{
		return global::<Module>.std.allocator_traits<std::allocator<unsigned\u0020char>\u0020>.max_size(A_0);
	}

	// Token: 0x06000112 RID: 274 RVA: 0x00003F58 File Offset: 0x00003358
	internal unsafe static uint max_size(global::std.allocator<unsigned\u0020char>* _Al)
	{
		return global::<Module>.std.allocator<unsigned\u0020char>.max_size(_Al);
	}

	// Token: 0x06000113 RID: 275 RVA: 0x00003A94 File Offset: 0x00002E94
	internal unsafe static uint max_size(global::std.allocator<unsigned\u0020char>* A_0)
	{
		return -1;
	}

	// Token: 0x06000114 RID: 276 RVA: 0x00004700 File Offset: 0x00003B00
	internal unsafe static byte* _Ucopy<class\u0020std::_Vector_const_iterator<class\u0020std::_Vector_val<struct\u0020std::_Simple_types<unsigned\u0020char>\u0020>\u0020>\u0020>(global::std.vector<unsigned\u0020char,std::allocator<unsigned\u0020char>\u0020>* A_0, global::std._Vector_const_iterator<std::_Vector_val<std::_Simple_types<unsigned\u0020char>\u0020>\u0020> _First, global::std._Vector_const_iterator<std::_Vector_val<std::_Simple_types<unsigned\u0020char>\u0020>\u0020> _Last, byte* _Ptr)
	{
		global::std._Wrap_alloc<std::allocator<unsigned\u0020char>\u0020> wrap_alloc<std::allocator<unsigned_u0020char>_u0020>;
		global::<Module>.std._Vector_alloc<0,std::_Vec_base_types<unsigned\u0020char,std::allocator<unsigned\u0020char>\u0020>\u0020>._Getal(A_0, &wrap_alloc<std::allocator<unsigned_u0020char>_u0020>);
		return global::<Module>.std._Uninitialized_copy<class\u0020std::_Vector_const_iterator<class\u0020std::_Vector_val<struct\u0020std::_Simple_types<unsigned\u0020char>\u0020>\u0020>,unsigned\u0020char\u0020*,struct\u0020std::_Wrap_alloc<class\u0020std::allocator<unsigned\u0020char>\u0020>\u0020>(_First, _Last, _Ptr, ref wrap_alloc<std::allocator<unsigned_u0020char>_u0020>);
	}

	// Token: 0x06000115 RID: 277 RVA: 0x00003AA4 File Offset: 0x00002EA4
	internal unsafe static byte* _Allocate<unsigned\u0020char>(uint _Count, byte* __unnamed001)
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

	// Token: 0x06000116 RID: 278 RVA: 0x000042FC File Offset: 0x000036FC
	internal unsafe static byte* _Uninitialized_copy<class\u0020std::_Vector_const_iterator<class\u0020std::_Vector_val<struct\u0020std::_Simple_types<unsigned\u0020char>\u0020>\u0020>,unsigned\u0020char\u0020*,struct\u0020std::_Wrap_alloc<class\u0020std::allocator<unsigned\u0020char>\u0020>\u0020>(global::std._Vector_const_iterator<std::_Vector_val<std::_Simple_types<unsigned\u0020char>\u0020>\u0020> _First, global::std._Vector_const_iterator<std::_Vector_val<std::_Simple_types<unsigned\u0020char>\u0020>\u0020> _Last, byte* _Dest, global::std._Wrap_alloc<std::allocator<unsigned\u0020char>\u0020>* _Al)
	{
		return *global::<Module>.std._Rechecked<unsigned\u0020char\u0020*,unsigned\u0020char\u0020*>(ref _Dest, global::<Module>.std._Uninit_copy<unsigned\u0020char\u0020const\u0020*,unsigned\u0020char\u0020*,struct\u0020std::_Wrap_alloc<class\u0020std::allocator<unsigned\u0020char>\u0020>\u0020>(global::<Module>.std._Unchecked<class\u0020std::_Vector_val<struct\u0020std::_Simple_types<unsigned\u0020char>\u0020>\u0020>(_First), global::<Module>.std._Unchecked<class\u0020std::_Vector_val<struct\u0020std::_Simple_types<unsigned\u0020char>\u0020>\u0020>(_Last), global::<Module>.std._Unchecked<unsigned\u0020char\u0020*>(_Dest), _Al));
	}

	// Token: 0x06000117 RID: 279 RVA: 0x00003F70 File Offset: 0x00003370
	internal unsafe static byte* _Unchecked<class\u0020std::_Vector_val<struct\u0020std::_Simple_types<unsigned\u0020char>\u0020>\u0020>(global::std._Vector_const_iterator<std::_Vector_val<std::_Simple_types<unsigned\u0020char>\u0020>\u0020> _Iter)
	{
		return global::<Module>.std._Vector_const_iterator<std::_Vector_val<std::_Simple_types<unsigned\u0020char>\u0020>\u0020>._Unchecked(ref _Iter);
	}

	// Token: 0x06000118 RID: 280 RVA: 0x00003AD0 File Offset: 0x00002ED0
	internal unsafe static byte* _Unchecked<unsigned\u0020char\u0020*>(byte* _Src)
	{
		return _Src;
	}

	// Token: 0x06000119 RID: 281 RVA: 0x00003F88 File Offset: 0x00003388
	internal unsafe static byte* _Uninit_copy<unsigned\u0020char\u0020const\u0020*,unsigned\u0020char\u0020*,struct\u0020std::_Wrap_alloc<class\u0020std::allocator<unsigned\u0020char>\u0020>\u0020>(byte* _First, byte* _Last, byte* _Dest, global::std._Wrap_alloc<std::allocator<unsigned\u0020char>\u0020>* _Al)
	{
		global::std._Scalar_ptr_iterator_tag _unnamed = global::<Module>.std._Ptr_cat<unsigned\u0020char,unsigned\u0020char>(_First, _Dest);
		return global::<Module>.std._Uninit_copy<unsigned\u0020char\u0020const\u0020,unsigned\u0020char>(_First, _Last, _Dest, _Al, _unnamed);
	}

	// Token: 0x0600011A RID: 282 RVA: 0x00003AE0 File Offset: 0x00002EE0
	internal unsafe static byte** _Rechecked<unsigned\u0020char\u0020*,unsigned\u0020char\u0020*>(byte** _Dest, byte* _Src)
	{
		*_Dest = _Src;
		return _Dest;
	}

	// Token: 0x0600011B RID: 283 RVA: 0x00003AF4 File Offset: 0x00002EF4
	internal unsafe static byte* _Unchecked(global::std._Vector_const_iterator<std::_Vector_val<std::_Simple_types<unsigned\u0020char>\u0020>\u0020>* A_0)
	{
		return *A_0;
	}

	// Token: 0x0600011C RID: 284 RVA: 0x000038D4 File Offset: 0x00002CD4
	internal unsafe static global::std._Scalar_ptr_iterator_tag _Ptr_cat<unsigned\u0020char,unsigned\u0020char>(byte* A_0, byte* A_1)
	{
		global::std._Scalar_ptr_iterator_tag result;
		return result;
	}

	// Token: 0x0600011D RID: 285 RVA: 0x00003B08 File Offset: 0x00002F08
	internal unsafe static byte* _Uninit_copy<unsigned\u0020char\u0020const\u0020,unsigned\u0020char>(byte* _First, byte* _Last, byte* _Dest, global::std._Wrap_alloc<std::allocator<unsigned\u0020char>\u0020>* __unnamed003, global::std._Scalar_ptr_iterator_tag __unnamed004)
	{
		uint num = (uint)(_Last - _First);
		return global::<Module>.memmove((void*)_Dest, (void*)_First, num) + num;
	}

	// Token: 0x0600011E RID: 286 RVA: 0x000054F4 File Offset: 0x000048F4
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

	// Token: 0x0600011F RID: 287 RVA: 0x00005CA0 File Offset: 0x000050A0
	internal static void <CrtImplementationDetails>.ThrowNestedModuleLoadException(global::System.Exception innerException, global::System.Exception nestedException)
	{
		throw new global::<CrtImplementationDetails>.ModuleLoadExceptionHandlerException("A nested exception occurred after the primary exception that caused the C++ module to fail to load.\n", innerException, nestedException);
	}

	// Token: 0x06000120 RID: 288 RVA: 0x000056B0 File Offset: 0x00004AB0
	internal static void <CrtImplementationDetails>.ThrowModuleLoadException(string errorMessage)
	{
		throw new global::<CrtImplementationDetails>.ModuleLoadException(errorMessage);
	}

	// Token: 0x06000121 RID: 289 RVA: 0x000056C4 File Offset: 0x00004AC4
	internal static void <CrtImplementationDetails>.ThrowModuleLoadException(string errorMessage, global::System.Exception innerException)
	{
		throw new global::<CrtImplementationDetails>.ModuleLoadException(errorMessage, innerException);
	}

	// Token: 0x06000122 RID: 290 RVA: 0x000057E0 File Offset: 0x00004BE0
	internal static void <CrtImplementationDetails>.RegisterModuleUninitializer(global::System.EventHandler handler)
	{
		global::<CrtImplementationDetails>.ModuleUninitializer._ModuleUninitializer.AddHandler(handler);
	}

	// Token: 0x06000123 RID: 291 RVA: 0x000057F8 File Offset: 0x00004BF8
	[global::System.Security.SecuritySafeCritical]
	internal unsafe static global::System.Guid <CrtImplementationDetails>.FromGUID(global::_GUID* guid)
	{
		global::System.Guid result = new global::System.Guid((uint)(*guid), *(guid + 4), *(guid + 6), *(guid + 8), *(guid + 9), *(guid + 10), *(guid + 11), *(guid + 12), *(guid + 13), *(guid + 14), *(guid + 15));
		return result;
	}

	// Token: 0x06000124 RID: 292 RVA: 0x00005840 File Offset: 0x00004C40
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

	// Token: 0x06000125 RID: 293 RVA: 0x000058C4 File Offset: 0x00004CC4
	internal unsafe static void __release_appdomain(global::IUnknown* ppUnk)
	{
		object obj = calli(System.UInt32 modopt(System.Runtime.CompilerServices.IsLong) modopt(System.Runtime.CompilerServices.CallConvStdcall)(System.IntPtr), ppUnk, *(*(int*)ppUnk + 8));
	}

	// Token: 0x06000126 RID: 294 RVA: 0x000058E0 File Offset: 0x00004CE0
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

	// Token: 0x06000127 RID: 295 RVA: 0x00005940 File Offset: 0x00004D40
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

	// Token: 0x06000128 RID: 296 RVA: 0x000059D0 File Offset: 0x00004DD0
	[global::System.Security.SecuritySafeCritical]
	internal unsafe static int <CrtImplementationDetails>.DefaultDomain.DoNothing(void* cookie)
	{
		global::System.GC.KeepAlive(int.MaxValue);
		return 0;
	}

	// Token: 0x06000129 RID: 297 RVA: 0x000059F0 File Offset: 0x00004DF0
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

	// Token: 0x0600012A RID: 298 RVA: 0x00005A44 File Offset: 0x00004E44
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

	// Token: 0x0600012B RID: 299 RVA: 0x00005AC4 File Offset: 0x00004EC4
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

	// Token: 0x0600012C RID: 300 RVA: 0x00005B00 File Offset: 0x00004F00
	[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
	internal static bool <CrtImplementationDetails>.DefaultDomain.NeedsUninitialization()
	{
		return global::<Module>.?Entered@DefaultDomain@<CrtImplementationDetails>@@2_NA;
	}

	// Token: 0x0600012D RID: 301 RVA: 0x00005B14 File Offset: 0x00004F14
	[global::System.Security.SecurityCritical]
	internal static void <CrtImplementationDetails>.DefaultDomain.Initialize()
	{
		global::<Module>.<CrtImplementationDetails>.DoCallBackInDefaultDomain(global::<Module>.__unep@?DoNothing@DefaultDomain@<CrtImplementationDetails>@@$$FCGJPAX@Z, null);
	}

	// Token: 0x0600012E RID: 302 RVA: 0x00001358 File Offset: 0x00000758
	internal static void ??__E?Initialized@CurrentDomain@<CrtImplementationDetails>@@$$Q2HA@@YMXXZ()
	{
		global::<Module>.?Initialized@CurrentDomain@<CrtImplementationDetails>@@$$Q2HA = 0;
	}

	// Token: 0x0600012F RID: 303 RVA: 0x0000136C File Offset: 0x0000076C
	internal static void ??__E?Uninitialized@CurrentDomain@<CrtImplementationDetails>@@$$Q2HA@@YMXXZ()
	{
		global::<Module>.?Uninitialized@CurrentDomain@<CrtImplementationDetails>@@$$Q2HA = 0;
	}

	// Token: 0x06000130 RID: 304 RVA: 0x00001380 File Offset: 0x00000780
	internal static void ??__E?IsDefaultDomain@CurrentDomain@<CrtImplementationDetails>@@$$Q2_NA@@YMXXZ()
	{
		global::<Module>.?IsDefaultDomain@CurrentDomain@<CrtImplementationDetails>@@$$Q2_NA = false;
	}

	// Token: 0x06000131 RID: 305 RVA: 0x00001394 File Offset: 0x00000794
	internal static void ??__E?InitializedVtables@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A@@YMXXZ()
	{
		global::<Module>.?InitializedVtables@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A = (global::<CrtImplementationDetails>.Progress.State)0;
	}

	// Token: 0x06000132 RID: 306 RVA: 0x000013A8 File Offset: 0x000007A8
	internal static void ??__E?InitializedNative@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A@@YMXXZ()
	{
		global::<Module>.?InitializedNative@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A = (global::<CrtImplementationDetails>.Progress.State)0;
	}

	// Token: 0x06000133 RID: 307 RVA: 0x000013BC File Offset: 0x000007BC
	internal static void ??__E?InitializedPerProcess@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A@@YMXXZ()
	{
		global::<Module>.?InitializedPerProcess@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A = (global::<CrtImplementationDetails>.Progress.State)0;
	}

	// Token: 0x06000134 RID: 308 RVA: 0x000013D0 File Offset: 0x000007D0
	internal static void ??__E?InitializedPerAppDomain@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A@@YMXXZ()
	{
		global::<Module>.?InitializedPerAppDomain@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A = (global::<CrtImplementationDetails>.Progress.State)0;
	}

	// Token: 0x06000135 RID: 309 RVA: 0x00005CF4 File Offset: 0x000050F4
	[global::System.Security.SecurityCritical]
	[global::System.Diagnostics.DebuggerStepThrough]
	internal unsafe static void <CrtImplementationDetails>.LanguageSupport.InitializeVtables(global::<CrtImplementationDetails>.LanguageSupport* A_0)
	{
		global::<Module>.gcroot<System::String\u0020^>.=(A_0, "The C++ module failed to load during vtable initialization.\n");
		global::<Module>.?InitializedVtables@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A = (global::<CrtImplementationDetails>.Progress.State)1;
		global::<Module>._initterm_m((global::method*)(&global::<Module>.?A0xd2508fec.__xi_vt_a), (global::method*)(&global::<Module>.?A0xd2508fec.__xi_vt_z));
		global::<Module>.?InitializedVtables@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A = (global::<CrtImplementationDetails>.Progress.State)2;
	}

	// Token: 0x06000136 RID: 310 RVA: 0x00005D28 File Offset: 0x00005128
	[global::System.Security.SecurityCritical]
	internal unsafe static void <CrtImplementationDetails>.LanguageSupport.InitializeDefaultAppDomain(global::<CrtImplementationDetails>.LanguageSupport* A_0)
	{
		global::<Module>.gcroot<System::String\u0020^>.=(A_0, "The C++ module failed to load while attempting to initialize the default appdomain.\n");
		global::<Module>.<CrtImplementationDetails>.DefaultDomain.Initialize();
	}

	// Token: 0x06000137 RID: 311 RVA: 0x00005D48 File Offset: 0x00005148
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

	// Token: 0x06000138 RID: 312 RVA: 0x00005DE4 File Offset: 0x000051E4
	[global::System.Security.SecurityCritical]
	[global::System.Diagnostics.DebuggerStepThrough]
	internal unsafe static void <CrtImplementationDetails>.LanguageSupport.InitializePerProcess(global::<CrtImplementationDetails>.LanguageSupport* A_0)
	{
		global::<Module>.gcroot<System::String\u0020^>.=(A_0, "The C++ module failed to load during process initialization.\n");
		global::<Module>.?InitializedPerProcess@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A = (global::<CrtImplementationDetails>.Progress.State)1;
		global::<Module>._initatexit_m();
		global::<Module>._initterm_m((global::method*)(&global::<Module>.?A0xd2508fec.__xc_mp_a), (global::method*)(&global::<Module>.?A0xd2508fec.__xc_mp_z));
		global::<Module>.?InitializedPerProcess@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A = (global::<CrtImplementationDetails>.Progress.State)2;
		global::<Module>.?InitializedPerProcess@DefaultDomain@<CrtImplementationDetails>@@2_NA = true;
	}

	// Token: 0x06000139 RID: 313 RVA: 0x00005E24 File Offset: 0x00005224
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

	// Token: 0x0600013A RID: 314 RVA: 0x00005E60 File Offset: 0x00005260
	[global::System.Security.SecurityCritical]
	[global::System.Diagnostics.DebuggerStepThrough]
	internal unsafe static void <CrtImplementationDetails>.LanguageSupport.InitializeUninitializer(global::<CrtImplementationDetails>.LanguageSupport* A_0)
	{
		global::<Module>.gcroot<System::String\u0020^>.=(A_0, "The C++ module failed to load during registration for the unload events.\n");
		global::<Module>.<CrtImplementationDetails>.RegisterModuleUninitializer(new global::System.EventHandler(global::<Module>.<CrtImplementationDetails>.LanguageSupport.DomainUnload));
	}

	// Token: 0x0600013B RID: 315 RVA: 0x00005E8C File Offset: 0x0000528C
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

	// Token: 0x0600013C RID: 316 RVA: 0x00005B2C File Offset: 0x00004F2C
	[global::System.Security.SecurityCritical]
	internal static void <CrtImplementationDetails>.LanguageSupport.UninitializeAppDomain()
	{
		global::<Module>._app_exit_callback();
	}

	// Token: 0x0600013D RID: 317 RVA: 0x00005B40 File Offset: 0x00004F40
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

	// Token: 0x0600013E RID: 318 RVA: 0x00005B7C File Offset: 0x00004F7C
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

	// Token: 0x0600013F RID: 319 RVA: 0x00005BB0 File Offset: 0x00004FB0
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

	// Token: 0x06000140 RID: 320 RVA: 0x00005FB0 File Offset: 0x000053B0
	[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.Success)]
	[global::System.Diagnostics.DebuggerStepThrough]
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

	// Token: 0x06000141 RID: 321 RVA: 0x00006024 File Offset: 0x00005424
	[global::System.Security.SecurityCritical]
	internal unsafe static global::<CrtImplementationDetails>.LanguageSupport* <CrtImplementationDetails>.LanguageSupport.{ctor}(global::<CrtImplementationDetails>.LanguageSupport* A_0)
	{
		global::<Module>.gcroot<System::String\u0020^>.{ctor}(A_0);
		return A_0;
	}

	// Token: 0x06000142 RID: 322 RVA: 0x0000603C File Offset: 0x0000543C
	[global::System.Security.SecurityCritical]
	internal unsafe static void <CrtImplementationDetails>.LanguageSupport.{dtor}(global::<CrtImplementationDetails>.LanguageSupport* A_0)
	{
		global::<Module>.gcroot<System::String\u0020^>.{dtor}(A_0);
	}

	// Token: 0x06000143 RID: 323 RVA: 0x00006050 File Offset: 0x00005450
	[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.Success)]
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.Security.SecurityCritical]
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

	// Token: 0x06000144 RID: 324 RVA: 0x0000610C File Offset: 0x0000550C
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

	// Token: 0x06000145 RID: 325 RVA: 0x00005BEC File Offset: 0x00004FEC
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.Security.SecuritySafeCritical]
	internal unsafe static global::gcroot<System::String\u0020^>* {ctor}(global::gcroot<System::String\u0020^>* A_0)
	{
		*A_0 = ((global::System.IntPtr)global::System.Runtime.InteropServices.GCHandle.Alloc(null)).ToPointer();
		return A_0;
	}

	// Token: 0x06000146 RID: 326 RVA: 0x00005C10 File Offset: 0x00005010
	[global::System.Security.SecurityCritical]
	[global::System.Diagnostics.DebuggerStepThrough]
	internal unsafe static void {dtor}(global::gcroot<System::String\u0020^>* A_0)
	{
		global::System.IntPtr value = new global::System.IntPtr(*A_0);
		((global::System.Runtime.InteropServices.GCHandle)value).Free();
		*A_0 = 0;
	}

	// Token: 0x06000147 RID: 327 RVA: 0x00005C38 File Offset: 0x00005038
	[global::System.Security.SecurityCritical]
	[global::System.Diagnostics.DebuggerStepThrough]
	internal unsafe static global::gcroot<System::String\u0020^>* =(global::gcroot<System::String\u0020^>* A_0, string t)
	{
		global::System.IntPtr value = new global::System.IntPtr(*A_0);
		((global::System.Runtime.InteropServices.GCHandle)value).Target = t;
		return A_0;
	}

	// Token: 0x06000148 RID: 328 RVA: 0x00005C60 File Offset: 0x00005060
	[global::System.Security.SecuritySafeCritical]
	internal unsafe static string P$AAVString@System@@(global::gcroot<System::String\u0020^>* A_0)
	{
		global::System.IntPtr value = new global::System.IntPtr(*A_0);
		return ((global::System.Runtime.InteropServices.GCHandle)value).Target;
	}

	// Token: 0x06000149 RID: 329 RVA: 0x00006200 File Offset: 0x00005600
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

	// Token: 0x0600014A RID: 330 RVA: 0x0000618C File Offset: 0x0000558C
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

	// Token: 0x0600014B RID: 331 RVA: 0x000061AC File Offset: 0x000055AC
	[global::System.Security.SecurityCritical]
	[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.Success)]
	[global::System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
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

	// Token: 0x0600014C RID: 332 RVA: 0x0000625C File Offset: 0x0000565C
	[global::System.Security.SecurityCritical]
	[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.Success)]
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

	// Token: 0x0600014D RID: 333 RVA: 0x000062A0 File Offset: 0x000056A0
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

	// Token: 0x0600014E RID: 334 RVA: 0x00006754 File Offset: 0x00005B54
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.Security.SecurityCritical]
	internal static void <CrtImplementationDetails>.AtExitLock._lock_Construct(object value)
	{
		global::<Module>.?_lock@AtExitLock@<CrtImplementationDetails>@@$$Q0PAXA = null;
		global::<Module>.<CrtImplementationDetails>.AtExitLock._lock_Set(value);
	}

	// Token: 0x0600014F RID: 335 RVA: 0x000062D0 File Offset: 0x000056D0
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

	// Token: 0x06000150 RID: 336 RVA: 0x00006320 File Offset: 0x00005720
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

	// Token: 0x06000151 RID: 337 RVA: 0x00006344 File Offset: 0x00005744
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

	// Token: 0x06000152 RID: 338 RVA: 0x0000636C File Offset: 0x0000576C
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.Security.SecuritySafeCritical]
	[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
	internal static bool <CrtImplementationDetails>.AtExitLock.IsInitialized()
	{
		return (global::<Module>.<CrtImplementationDetails>.AtExitLock._lock_Get() != null) ? 1 : 0;
	}

	// Token: 0x06000153 RID: 339 RVA: 0x00006770 File Offset: 0x00005B70
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

	// Token: 0x06000154 RID: 340 RVA: 0x00006388 File Offset: 0x00005788
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

	// Token: 0x06000155 RID: 341 RVA: 0x000063B0 File Offset: 0x000057B0
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.Security.SecurityCritical]
	internal static void <CrtImplementationDetails>.AtExitLock.Enter()
	{
		global::System.Threading.Monitor.Enter(global::<Module>.<CrtImplementationDetails>.AtExitLock._lock_Get());
	}

	// Token: 0x06000156 RID: 342 RVA: 0x000063C8 File Offset: 0x000057C8
	[global::System.Security.SecurityCritical]
	[global::System.Diagnostics.DebuggerStepThrough]
	internal static void <CrtImplementationDetails>.AtExitLock.Exit()
	{
		global::System.Threading.Monitor.Exit(global::<Module>.<CrtImplementationDetails>.AtExitLock._lock_Get());
	}

	// Token: 0x06000157 RID: 343 RVA: 0x000063E0 File Offset: 0x000057E0
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

	// Token: 0x06000158 RID: 344 RVA: 0x00006400 File Offset: 0x00005800
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

	// Token: 0x06000159 RID: 345 RVA: 0x000067A0 File Offset: 0x00005BA0
	[global::System.Security.SecurityCritical]
	[global::System.Diagnostics.DebuggerStepThrough]
	[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
	internal static bool __alloc_global_lock()
	{
		global::<Module>.<CrtImplementationDetails>.AtExitLock.AddRef();
		return global::<Module>.<CrtImplementationDetails>.AtExitLock.IsInitialized();
	}

	// Token: 0x0600015A RID: 346 RVA: 0x00006420 File Offset: 0x00005820
	[global::System.Security.SecurityCritical]
	[global::System.Diagnostics.DebuggerStepThrough]
	internal static void __dealloc_global_lock()
	{
		global::<Module>.<CrtImplementationDetails>.AtExitLock.RemoveRef();
	}

	// Token: 0x0600015B RID: 347 RVA: 0x00006434 File Offset: 0x00005834
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

	// Token: 0x0600015C RID: 348 RVA: 0x000065B0 File Offset: 0x000059B0
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

	// Token: 0x0600015D RID: 349 RVA: 0x000067B8 File Offset: 0x00005BB8
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.Security.SecurityCritical]
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

	// Token: 0x0600015E RID: 350 RVA: 0x00006654 File Offset: 0x00005A54
	[global::System.Security.SecurityCritical]
	internal unsafe static int _atexit_m(global::method func)
	{
		return global::<Module>._atexit_helper(global::<Module>.EncodePointer(func), &global::<Module>.?A0xe62d03cb.__exit_list_size, &global::<Module>.?A0xe62d03cb.__onexitend_m, &global::<Module>.?A0xe62d03cb.__onexitbegin_m);
	}

	// Token: 0x0600015F RID: 351 RVA: 0x00006800 File Offset: 0x00005C00
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

	// Token: 0x06000160 RID: 352 RVA: 0x0000667C File Offset: 0x00005A7C
	[global::System.Security.SecurityCritical]
	[global::System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
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

	// Token: 0x06000161 RID: 353
	[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.Success)]
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Security.SecurityCritical]
	[global::System.Runtime.InteropServices.DllImport("KERNEL32.dll")]
	public unsafe static extern void* DecodePointer(void* Ptr);

	// Token: 0x06000162 RID: 354
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.Success)]
	[global::System.Security.SecurityCritical]
	[global::System.Runtime.InteropServices.DllImport("KERNEL32.dll")]
	public unsafe static extern void* EncodePointer(void* Ptr);

	// Token: 0x06000163 RID: 355 RVA: 0x00006844 File Offset: 0x00005C44
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.Security.SecurityCritical]
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

	// Token: 0x06000164 RID: 356 RVA: 0x00006874 File Offset: 0x00005C74
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

	// Token: 0x06000165 RID: 357 RVA: 0x0000689C File Offset: 0x00005C9C
	[global::System.Diagnostics.DebuggerStepThrough]
	internal static global::System.ModuleHandle <CrtImplementationDetails>.ThisModule.Handle()
	{
		return typeof(global::<CrtImplementationDetails>.ThisModule).Module.ModuleHandle;
	}

	// Token: 0x06000166 RID: 358 RVA: 0x000068EC File Offset: 0x00005CEC
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

	// Token: 0x06000167 RID: 359 RVA: 0x000068C0 File Offset: 0x00005CC0
	[global::System.Security.SecurityCritical]
	[global::System.Diagnostics.DebuggerStepThrough]
	internal static global::method <CrtImplementationDetails>.ThisModule.ResolveMethod<void\u0020const\u0020*\u0020__clrcall(void)>(global::method methodToken)
	{
		return global::<Module>.<CrtImplementationDetails>.ThisModule.Handle().ResolveMethodHandle(methodToken).GetFunctionPointer().ToPointer();
	}

	// Token: 0x06000168 RID: 360 RVA: 0x00007608 File Offset: 0x00006A08
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern void _Orphan_all(global::std._Container_base0*);

	// Token: 0x06000169 RID: 361 RVA: 0x000075F0 File Offset: 0x000069F0
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern void _Swap_all(global::std._Container_base0*, global::std._Container_base0*);

	// Token: 0x0600016A RID: 362 RVA: 0x00001550 File Offset: 0x00000950
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged | global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]
	internal unsafe static extern int _AtlInitializeCriticalSectionEx(global::_RTL_CRITICAL_SECTION*, uint, uint);

	// Token: 0x0600016B RID: 363 RVA: 0x00005350 File Offset: 0x00004750
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged | global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]
	internal unsafe static extern global::ATL.CAtlComModule* {ctor}(global::ATL.CAtlComModule*);

	// Token: 0x0600016C RID: 364 RVA: 0x000054A0 File Offset: 0x000048A0
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged | global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]
	internal unsafe static extern void {dtor}(global::ATL.CAtlComModule*);

	// Token: 0x0600016D RID: 365 RVA: 0x000052C0 File Offset: 0x000046C0
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged | global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]
	internal unsafe static extern void Term(global::ATL.CAtlComModule*);

	// Token: 0x0600016E RID: 366 RVA: 0x0000749C File Offset: 0x0000689C
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern void* @new(uint);

	// Token: 0x0600016F RID: 367 RVA: 0x000074D2 File Offset: 0x000068D2
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.StdCall, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern void* LocalFree(void*);

	// Token: 0x06000170 RID: 368 RVA: 0x000074A8 File Offset: 0x000068A8
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal static extern int __CxxQueryExceptionSize();

	// Token: 0x06000171 RID: 369 RVA: 0x000074BA File Offset: 0x000068BA
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern int __CxxDetectRethrow(void*);

	// Token: 0x06000172 RID: 370 RVA: 0x00007496 File Offset: 0x00006896
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.StdCall, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern void _CxxThrowException(void*, global::_s__ThrowInfo*);

	// Token: 0x06000173 RID: 371 RVA: 0x000074C0 File Offset: 0x000068C0
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern void __CxxUnregisterExceptionObject(void*, int);

	// Token: 0x06000174 RID: 372 RVA: 0x00006DDE File Offset: 0x000061DE
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern void delete(void*);

	// Token: 0x06000175 RID: 373 RVA: 0x000074AE File Offset: 0x000068AE
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern int __CxxExceptionFilter(void*, void*, int, void*);

	// Token: 0x06000176 RID: 374 RVA: 0x00007490 File Offset: 0x00006890
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern void delete[](void*);

	// Token: 0x06000177 RID: 375 RVA: 0x00007448 File Offset: 0x00006848
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern void* memset(void*, int, uint);

	// Token: 0x06000178 RID: 376 RVA: 0x000074DE File Offset: 0x000068DE
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern global::IshAdapter* {ctor}(global::IshAdapter*);

	// Token: 0x06000179 RID: 377 RVA: 0x00007526 File Offset: 0x00006926
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern ushort LoadPSDT(global::IshAdapter*, global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>*, uint);

	// Token: 0x0600017A RID: 378 RVA: 0x0000752C File Offset: 0x0000692C
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern ushort LoadCodeplug(global::IshAdapter*, global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>*, global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>*, ushort);

	// Token: 0x0600017B RID: 379 RVA: 0x00007502 File Offset: 0x00006902
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern ushort BuildDefaultISHHeaders(global::IshAdapter*);

	// Token: 0x0600017C RID: 380 RVA: 0x00007532 File Offset: 0x00006932
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern ushort SaveCodeplug(global::IshAdapter*, global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>*, global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>*);

	// Token: 0x0600017D RID: 381 RVA: 0x000074E4 File Offset: 0x000068E4
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern ushort ReadISH(global::IshAdapter*, ushort, ushort, byte*, uint*);

	// Token: 0x0600017E RID: 382 RVA: 0x00007544 File Offset: 0x00006944
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern global::std.vector<ISHITEM,std::allocator<ISHITEM>\u0020>* ReadAllISH(global::IshAdapter*, global::std.vector<ISHITEM,std::allocator<ISHITEM>\u0020>*, global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>*);

	// Token: 0x0600017F RID: 383 RVA: 0x000074EA File Offset: 0x000068EA
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern void WriteISH(global::IshAdapter*, ushort, ushort*, byte*, uint);

	// Token: 0x06000180 RID: 384 RVA: 0x000074F0 File Offset: 0x000068F0
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
	internal unsafe static extern bool TerminateISH(global::IshAdapter*);

	// Token: 0x06000181 RID: 385 RVA: 0x000074F6 File Offset: 0x000068F6
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern ushort ReadVitualMemory(global::IshAdapter*, uint, uint, byte*);

	// Token: 0x06000182 RID: 386 RVA: 0x000074FC File Offset: 0x000068FC
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern ushort EraseVirtualMemory(global::IshAdapter*, uint, uint);

	// Token: 0x06000183 RID: 387 RVA: 0x00007514 File Offset: 0x00006914
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern ushort EraseCodeplugVirtualMemory(global::IshAdapter*);

	// Token: 0x06000184 RID: 388 RVA: 0x00007538 File Offset: 0x00006938
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern global::std.vector<PSDT_RECORD\u0020*,std::allocator<PSDT_RECORD\u0020*>\u0020>* ReadPSDTRecord(global::IshAdapter*, global::std.vector<PSDT_RECORD\u0020*,std::allocator<PSDT_RECORD\u0020*>\u0020>*);

	// Token: 0x06000185 RID: 389 RVA: 0x00007508 File Offset: 0x00006908
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern ushort SetBlockISHVersion(global::IshAdapter*, uint, ushort);

	// Token: 0x06000186 RID: 390 RVA: 0x0000750E File Offset: 0x0000690E
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern ushort GetBlockISHVersion(global::IshAdapter*, uint, ushort*);

	// Token: 0x06000187 RID: 391 RVA: 0x0000753E File Offset: 0x0000693E
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern ushort GetSectionID(global::IshAdapter*, uint, global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>*);

	// Token: 0x06000188 RID: 392 RVA: 0x0000751A File Offset: 0x0000691A
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern ushort GetSectionAddress(global::IshAdapter*, global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>*, uint*, uint*);

	// Token: 0x06000189 RID: 393 RVA: 0x00007520 File Offset: 0x00006920
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
	internal unsafe static extern bool IsSectionType(global::IshAdapter*, global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>*, ushort);

	// Token: 0x0600018A RID: 394 RVA: 0x0000754A File Offset: 0x0000694A
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
	internal unsafe static extern bool TerminateISH(global::IshWorker*);

	// Token: 0x0600018B RID: 395 RVA: 0x000074B4 File Offset: 0x000068B4
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern int __CxxRegisterExceptionObject(void*, void*);

	// Token: 0x0600018C RID: 396 RVA: 0x0000747E File Offset: 0x0000687E
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern uint strlen(sbyte*);

	// Token: 0x0600018D RID: 397 RVA: 0x0000716C File Offset: 0x0000656C
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern void free(void*);

	// Token: 0x0600018E RID: 398 RVA: 0x000074A2 File Offset: 0x000068A2
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern void* new[](uint);

	// Token: 0x0600018F RID: 399 RVA: 0x0000748A File Offset: 0x0000688A
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern void* memmove(void*, void*, uint);

	// Token: 0x06000190 RID: 400 RVA: 0x000075F6 File Offset: 0x000069F6
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern void _Xlength_error(sbyte*);

	// Token: 0x06000191 RID: 401 RVA: 0x000075FC File Offset: 0x000069FC
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern void _Xout_of_range(sbyte*);

	// Token: 0x06000192 RID: 402 RVA: 0x00007602 File Offset: 0x00006A02
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal static extern void _Xbad_alloc();

	// Token: 0x06000193 RID: 403 RVA: 0x00007484 File Offset: 0x00006884
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern void* memcpy(void*, void*, uint);

	// Token: 0x06000194 RID: 404 RVA: 0x000059C4 File Offset: 0x00004DC4
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged | global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]
	internal unsafe static extern void* _getFiberPtrId();

	// Token: 0x06000195 RID: 405 RVA: 0x00006F28 File Offset: 0x00006328
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal static extern void _amsg_exit(int);

	// Token: 0x06000196 RID: 406 RVA: 0x00007172 File Offset: 0x00006572
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged | global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]
	internal static extern void __security_init_cookie();

	// Token: 0x06000197 RID: 407 RVA: 0x000074D8 File Offset: 0x000068D8
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.StdCall, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal static extern void Sleep(uint);

	// Token: 0x06000198 RID: 408 RVA: 0x000074C6 File Offset: 0x000068C6
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal static extern void _cexit();

	// Token: 0x06000199 RID: 409 RVA: 0x0000730C File Offset: 0x0000670C
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal static extern void terminate();

	// Token: 0x0600019A RID: 410 RVA: 0x000074CC File Offset: 0x000068CC
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern int __FrameUnwindFilter(global::_EXCEPTION_POINTERS*);

	// Token: 0x04000001 RID: 1 RVA: 0x0000845C File Offset: 0x0000705C
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY01$$CBD unnamed-global-0;

	// Token: 0x04000002 RID: 2 RVA: 0x00008460 File Offset: 0x00007060
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY01$$CBD unnamed-global-1;

	// Token: 0x04000003 RID: 3 RVA: 0x00008464 File Offset: 0x00007064
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY01$$CBD unnamed-global-2;

	// Token: 0x04000004 RID: 4 RVA: 0x00008468 File Offset: 0x00007068
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY01$$CBD unnamed-global-3;

	// Token: 0x04000005 RID: 5 RVA: 0x0000846C File Offset: 0x0000706C
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY03$$CBD unnamed-global-4;

	// Token: 0x04000006 RID: 6 RVA: 0x00008470 File Offset: 0x00007070
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0M@$$CBD unnamed-global-5;

	// Token: 0x04000007 RID: 7 RVA: 0x0000847C File Offset: 0x0000707C
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY08$$CBD unnamed-global-6;

	// Token: 0x04000008 RID: 8 RVA: 0x00008488 File Offset: 0x00007088
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY06$$CBD unnamed-global-7;

	// Token: 0x04000009 RID: 9 RVA: 0x0000828C File Offset: 0x00006E8C
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY05$$CBD unnamed-global-8;

	// Token: 0x0400000A RID: 10 RVA: 0x00008294 File Offset: 0x00006E94
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY05$$CBD unnamed-global-9;

	// Token: 0x0400000B RID: 11 RVA: 0x0000829C File Offset: 0x00006E9C
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0BF@$$CBD unnamed-global-10;

	// Token: 0x0400000C RID: 12 RVA: 0x000082B4 File Offset: 0x00006EB4
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY08$$CBD unnamed-global-11;

	// Token: 0x0400000D RID: 13 RVA: 0x000082C0 File Offset: 0x00006EC0
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY09$$CBD unnamed-global-12;

	// Token: 0x0400000E RID: 14 RVA: 0x000082CC File Offset: 0x00006ECC
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY08$$CBD unnamed-global-13;

	// Token: 0x0400000F RID: 15 RVA: 0x000082D8 File Offset: 0x00006ED8
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY04$$CBD unnamed-global-14;

	// Token: 0x04000010 RID: 16 RVA: 0x000082E0 File Offset: 0x00006EE0
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY03$$CBD unnamed-global-15;

	// Token: 0x04000011 RID: 17 RVA: 0x000082E4 File Offset: 0x00006EE4
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY08$$CBD unnamed-global-16;

	// Token: 0x04000012 RID: 18 RVA: 0x000082F0 File Offset: 0x00006EF0
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY06$$CBD unnamed-global-17;

	// Token: 0x04000013 RID: 19 RVA: 0x000082F8 File Offset: 0x00006EF8
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY08$$CBD unnamed-global-18;

	// Token: 0x04000014 RID: 20 RVA: 0x00008304 File Offset: 0x00006F04
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY07$$CBD unnamed-global-19;

	// Token: 0x04000015 RID: 21 RVA: 0x00008378 File Offset: 0x00006F78
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0BA@$$CBD unnamed-global-20;

	// Token: 0x04000016 RID: 22 RVA: 0x00008388 File Offset: 0x00006F88
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0M@$$CBD unnamed-global-21;

	// Token: 0x04000017 RID: 23 RVA: 0x00008394 File Offset: 0x00006F94
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0L@$$CBD unnamed-global-22;

	// Token: 0x04000018 RID: 24 RVA: 0x000083A0 File Offset: 0x00006FA0
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0BC@$$CBD unnamed-global-23;

	// Token: 0x04000019 RID: 25 RVA: 0x000083B4 File Offset: 0x00006FB4
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0BB@$$CBD unnamed-global-24;

	// Token: 0x0400001A RID: 26 RVA: 0x000083C8 File Offset: 0x00006FC8
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0BC@$$CBD unnamed-global-25;

	// Token: 0x0400001B RID: 27 RVA: 0x000083DC File Offset: 0x00006FDC
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0BB@$$CBD unnamed-global-26;

	// Token: 0x0400001C RID: 28 RVA: 0x000083F0 File Offset: 0x00006FF0
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0BA@$$CBD unnamed-global-27;

	// Token: 0x0400001D RID: 29 RVA: 0x00008400 File Offset: 0x00007000
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0BB@$$CBD unnamed-global-28;

	// Token: 0x0400001E RID: 30 RVA: 0x00008414 File Offset: 0x00007014
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0BD@$$CBD unnamed-global-29;

	// Token: 0x0400001F RID: 31 RVA: 0x00008428 File Offset: 0x00007028
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0P@$$CBD unnamed-global-30;

	// Token: 0x04000020 RID: 32 RVA: 0x00008438 File Offset: 0x00007038
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0BA@$$CBD unnamed-global-31;

	// Token: 0x04000021 RID: 33 RVA: 0x00008448 File Offset: 0x00007048
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0BD@$$CBD unnamed-global-32;

	// Token: 0x04000022 RID: 34 RVA: 0x00008490 File Offset: 0x00007090
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0BC@$$CBD unnamed-global-33;

	// Token: 0x04000023 RID: 35 RVA: 0x000084A4 File Offset: 0x000070A4
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0N@$$CBD unnamed-global-34;

	// Token: 0x04000024 RID: 36 RVA: 0x000084B4 File Offset: 0x000070B4
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0O@$$CBD unnamed-global-35;

	// Token: 0x04000025 RID: 37 RVA: 0x000084C4 File Offset: 0x000070C4
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0BA@$$CBD unnamed-global-36;

	// Token: 0x04000026 RID: 38 RVA: 0x000084D4 File Offset: 0x000070D4
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0P@$$CBD unnamed-global-37;

	// Token: 0x04000027 RID: 39 RVA: 0x000084E4 File Offset: 0x000070E4
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0M@$$CBD unnamed-global-38;

	// Token: 0x04000028 RID: 40 RVA: 0x000084F0 File Offset: 0x000070F0
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0N@$$CBD unnamed-global-39;

	// Token: 0x04000029 RID: 41 RVA: 0x0000830C File Offset: 0x00006F0C
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0BB@$$CBD unnamed-global-40;

	// Token: 0x0400002A RID: 42 RVA: 0x00008320 File Offset: 0x00006F20
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0N@$$CBD unnamed-global-41;

	// Token: 0x0400002B RID: 43 RVA: 0x00008330 File Offset: 0x00006F30
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0O@$$CBD unnamed-global-42;

	// Token: 0x0400002C RID: 44 RVA: 0x0000829B File Offset: 0x00006E9B
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY00$$CBD unnamed-global-43;

	// Token: 0x0400002D RID: 45 RVA: 0x00008288 File Offset: 0x00006E88
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY00$$CBD unnamed-global-44;

	// Token: 0x0400002E RID: 46 RVA: 0x00008340 File Offset: 0x00006F40
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY04$$CBD unnamed-global-45;

	// Token: 0x0400002F RID: 47 RVA: 0x00008348 File Offset: 0x00006F48
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY04$$CBD unnamed-global-46;

	// Token: 0x04000030 RID: 48 RVA: 0x00008350 File Offset: 0x00006F50
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY04$$CBD unnamed-global-47;

	// Token: 0x04000031 RID: 49 RVA: 0x00008358 File Offset: 0x00006F58
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY04$$CBD unnamed-global-48;

	// Token: 0x04000032 RID: 50 RVA: 0x00008360 File Offset: 0x00006F60
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY04$$CBD unnamed-global-49;

	// Token: 0x04000033 RID: 51 RVA: 0x00008368 File Offset: 0x00006F68
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY04$$CBD unnamed-global-50;

	// Token: 0x04000034 RID: 52 RVA: 0x00008370 File Offset: 0x00006F70
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY04$$CBD unnamed-global-51;

	// Token: 0x04000035 RID: 53 RVA: 0x00008293 File Offset: 0x00006E93
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY00$$CBD unnamed-global-52;

	// Token: 0x04000036 RID: 54 RVA: 0x00008289 File Offset: 0x00006E89
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY00$$CBD unnamed-global-53;

	// Token: 0x04000037 RID: 55 RVA: 0x0000828A File Offset: 0x00006E8A
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY00$$CBD unnamed-global-54;

	// Token: 0x04000038 RID: 56 RVA: 0x0000828B File Offset: 0x00006E8B
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY00$$CBD unnamed-global-55;

	// Token: 0x04000039 RID: 57 RVA: 0x00008292 File Offset: 0x00006E92
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY00$$CBD unnamed-global-56;

	// Token: 0x0400003A RID: 58 RVA: 0x0000829A File Offset: 0x00006E9A
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY00$$CBD unnamed-global-57;

	// Token: 0x0400003B RID: 59 RVA: 0x000082B1 File Offset: 0x00006EB1
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY00$$CBD unnamed-global-58;

	// Token: 0x0400003C RID: 60 RVA: 0x00008500 File Offset: 0x00007100
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0BA@$$CBD ??_C@_0BA@JFNIOLAK@string?5too?5long?$AA@;

	// Token: 0x0400003D RID: 61 RVA: 0x00008510 File Offset: 0x00007110
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0BI@$$CBD ??_C@_0BI@CFPLBAOH@invalid?5string?5position?$AA@;

	// Token: 0x0400003E RID: 62 RVA: 0x00008528 File Offset: 0x00007128
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0BD@$$CBD ??_C@_0BD@OLBABOEK@vector?$DMT?$DO?5too?5long?$AA@;

	// Token: 0x0400003F RID: 63 RVA: 0x0001B208 File Offset: 0x00019808
	internal static global::<CppImplementationDetails>.$PTMType$QQtagVARIANT@@PAN ?pmField@?$CVarTypeInfo@PAN@ATL@@2QQtagVARIANT@@PANQ3@;

	// Token: 0x04000040 RID: 64 RVA: 0x00008208 File Offset: 0x00006E08
	internal static global::method ?pmField$initializer$@?$CVarTypeInfo@PAN@ATL@@2P6MXXZA;

	// Token: 0x04000041 RID: 65 RVA: 0x0001B204 File Offset: 0x00019804
	internal static global::<CppImplementationDetails>.$PTMType$QQtagVARIANT@@PAPAG ?pmField@?$CVarTypeInfo@PAPAG@ATL@@2QQtagVARIANT@@PAPAGQ3@;

	// Token: 0x04000042 RID: 66 RVA: 0x00008210 File Offset: 0x00006E10
	internal static global::method ?pmField$initializer$@?$CVarTypeInfo@PAPAG@ATL@@2P6MXXZA;

	// Token: 0x04000043 RID: 67 RVA: 0x0001B200 File Offset: 0x00019800
	internal static global::<CppImplementationDetails>.$PTMType$QQtagVARIANT@@PA_K ?pmField@?$CVarTypeInfo@PA_K@ATL@@2QQtagVARIANT@@PA_KQ3@;

	// Token: 0x04000044 RID: 68 RVA: 0x000081F8 File Offset: 0x00006DF8
	internal static global::method ?pmField$initializer$@?$CVarTypeInfo@PA_K@ATL@@2P6MXXZA;

	// Token: 0x04000045 RID: 69 RVA: 0x0001B1FC File Offset: 0x000197FC
	internal static global::<CppImplementationDetails>.$PTMType$QQtagVARIANT@@PATtagCY@@ ?pmField@?$CVarTypeInfo@PATtagCY@@@ATL@@2QQtagVARIANT@@PATtagCY@@Q3@;

	// Token: 0x04000046 RID: 70 RVA: 0x00008228 File Offset: 0x00006E28
	internal static global::method ?pmField$initializer$@?$CVarTypeInfo@PATtagCY@@@ATL@@2P6MXXZA;

	// Token: 0x04000047 RID: 71 RVA: 0x0001956C File Offset: 0x0001816C
	internal static global::_s__RTTIClassHierarchyDescriptor ??_R3IshError@@8;

	// Token: 0x04000048 RID: 72 RVA: 0x0001B1F8 File Offset: 0x000197F8
	internal static global::<CppImplementationDetails>.$PTMType$QQtagVARIANT@@PAK ?pmField@?$CVarTypeInfo@PAK@ATL@@2QQtagVARIANT@@PAKQ3@;

	// Token: 0x04000049 RID: 73 RVA: 0x000081E8 File Offset: 0x00006DE8
	internal static global::method ?pmField$initializer$@?$CVarTypeInfo@PAK@ATL@@2P6MXXZA;

	// Token: 0x0400004A RID: 74 RVA: 0x0001B1F4 File Offset: 0x000197F4
	internal static global::<CppImplementationDetails>.$PTMType$QQtagVARIANT@@PA_J ?pmField@?$CVarTypeInfo@PA_J@ATL@@2QQtagVARIANT@@PA_JQ3@;

	// Token: 0x0400004B RID: 75 RVA: 0x000081F0 File Offset: 0x00006DF0
	internal static global::method ?pmField$initializer$@?$CVarTypeInfo@PA_J@ATL@@2P6MXXZA;

	// Token: 0x0400004C RID: 76 RVA: 0x0001B1F0 File Offset: 0x000197F0
	internal static global::<CppImplementationDetails>.$PTMType$QQtagVARIANT@@PAPAUIUnknown@@ ?pmField@?$CVarTypeInfo@PAPAUIUnknown@@@ATL@@2QQtagVARIANT@@PAPAUIUnknown@@Q3@;

	// Token: 0x0400004D RID: 77 RVA: 0x00008218 File Offset: 0x00006E18
	internal static global::method ?pmField$initializer$@?$CVarTypeInfo@PAPAUIUnknown@@@ATL@@2P6MXXZA;

	// Token: 0x0400004E RID: 78 RVA: 0x0001B1EC File Offset: 0x000197EC
	internal static global::<CppImplementationDetails>.$PTMType$QQtagVARIANT@@PAF ?pmField@?$CVarTypeInfo@PAF@ATL@@2QQtagVARIANT@@PAFQ3@;

	// Token: 0x0400004F RID: 79 RVA: 0x000081C4 File Offset: 0x00006DC4
	internal static global::method ?pmField$initializer$@?$CVarTypeInfo@PAF@ATL@@2P6MXXZA;

	// Token: 0x04000050 RID: 80 RVA: 0x0001B1E8 File Offset: 0x000197E8
	internal static global::<CppImplementationDetails>.$PTMType$QQtagVARIANT@@E ?pmField@?$CVarTypeInfo@E@ATL@@2QQtagVARIANT@@EQ3@;

	// Token: 0x04000051 RID: 81 RVA: 0x000081B4 File Offset: 0x00006DB4
	internal static global::method ?pmField$initializer$@?$CVarTypeInfo@E@ATL@@2P6MXXZA;

	// Token: 0x04000052 RID: 82 RVA: 0x0001B1E4 File Offset: 0x000197E4
	internal static global::<CppImplementationDetails>.$PTMType$QQtagVARIANT@@PAM ?pmField@?$CVarTypeInfo@PAM@ATL@@2QQtagVARIANT@@PAMQ3@;

	// Token: 0x04000053 RID: 83 RVA: 0x00008200 File Offset: 0x00006E00
	internal static global::method ?pmField$initializer$@?$CVarTypeInfo@PAM@ATL@@2P6MXXZA;

	// Token: 0x04000054 RID: 84 RVA: 0x0001B1BC File Offset: 0x000197BC
	internal static global::ATL.CAtlComModule _AtlComModule;

	// Token: 0x04000055 RID: 85 RVA: 0x0000822C File Offset: 0x00006E2C
	internal static global::method _AtlComModule$initializer$;

	// Token: 0x04000056 RID: 86 RVA: 0x0001B1B1 File Offset: 0x000197B1
	internal static global::std.piecewise_construct_t piecewise_construct;

	// Token: 0x04000057 RID: 87 RVA: 0x000081A8 File Offset: 0x00006DA8
	internal static global::method piecewise_construct$initializer$;

	// Token: 0x04000058 RID: 88 RVA: 0x0001B008 File Offset: 0x00019608
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY01Q6AXXZ ??_7_com_error@@6B@;

	// Token: 0x04000059 RID: 89 RVA: 0x0001B1B8 File Offset: 0x000197B8
	internal static global::<CppImplementationDetails>.$PTMType$QQtagVARIANT@@M ?pmField@?$CVarTypeInfo@M@ATL@@2QQtagVARIANT@@MQ3@;

	// Token: 0x0400005A RID: 90 RVA: 0x000081FC File Offset: 0x00006DFC
	internal static global::method ?pmField$initializer$@?$CVarTypeInfo@M@ATL@@2P6MXXZA;

	// Token: 0x0400005B RID: 91 RVA: 0x0001B0D0 File Offset: 0x000196D0
	internal static global::$_TypeDescriptor$_extraBytes_17 ??_R0?AV_com_error@@@8;

	// Token: 0x0400005C RID: 92 RVA: 0x00019590 File Offset: 0x00018190
	internal static global::_s__RTTIBaseClassDescriptor2 ??_R1A@?0A@EA@IshWorker@@8;

	// Token: 0x0400005D RID: 93 RVA: 0x00019534 File Offset: 0x00018134
	internal static global::_s__RTTICompleteObjectLocator ??_R4_com_error@@6B@;

	// Token: 0x0400005E RID: 94 RVA: 0x0001B1B4 File Offset: 0x000197B4
	internal static global::<CppImplementationDetails>.$PTMType$QQtagVARIANT@@PAUIUnknown@@ ?pmField@?$CVarTypeInfo@PAUIUnknown@@@ATL@@2QQtagVARIANT@@PAUIUnknown@@Q3@;

	// Token: 0x0400005F RID: 95 RVA: 0x00008214 File Offset: 0x00006E14
	internal static global::method ?pmField$initializer$@?$CVarTypeInfo@PAUIUnknown@@@ATL@@2P6MXXZA;

	// Token: 0x04000060 RID: 96 RVA: 0x00019500 File Offset: 0x00018100
	internal static global::_s__RTTIBaseClassDescriptor2 ??_R1A@?0A@EA@_com_error@@8;

	// Token: 0x04000061 RID: 97 RVA: 0x0001B1B0 File Offset: 0x000197B0
	internal static global::std.allocator_arg_t allocator_arg;

	// Token: 0x04000062 RID: 98 RVA: 0x000081AC File Offset: 0x00006DAC
	internal static global::method allocator_arg$initializer$;

	// Token: 0x04000063 RID: 99 RVA: 0x0001957C File Offset: 0x0001817C
	internal static global::_s__RTTICompleteObjectLocator ??_R4IshError@@6B@;

	// Token: 0x04000064 RID: 100 RVA: 0x000195C4 File Offset: 0x000181C4
	internal static global::_s__RTTICompleteObjectLocator ??_R4IshWorker@@6B@;

	// Token: 0x04000065 RID: 101 RVA: 0x0001B190 File Offset: 0x00019790
	internal static global::ATL.CAtlReleaseManagedClassFactories _AtlReleaseManagedClassFactories;

	// Token: 0x04000066 RID: 102 RVA: 0x00008230 File Offset: 0x00006E30
	internal static global::method _AtlReleaseManagedClassFactories$initializer$;

	// Token: 0x04000067 RID: 103 RVA: 0x0001B18C File Offset: 0x0001978C
	internal static global::<CppImplementationDetails>.$PTMType$QQtagVARIANT@@PAUIDispatch@@ ?pmField@?$CVarTypeInfo@PAUIDispatch@@@ATL@@2QQtagVARIANT@@PAUIDispatch@@Q3@;

	// Token: 0x04000068 RID: 104 RVA: 0x0000821C File Offset: 0x00006E1C
	internal static global::method ?pmField$initializer$@?$CVarTypeInfo@PAUIDispatch@@@ATL@@2P6MXXZA;

	// Token: 0x04000069 RID: 105 RVA: 0x0001B188 File Offset: 0x00019788
	internal static global::<CppImplementationDetails>.$PTMType$QQtagVARIANT@@J ?pmField@?$CVarTypeInfo@J@ATL@@2QQtagVARIANT@@JQ3@;

	// Token: 0x0400006A RID: 106 RVA: 0x000081DC File Offset: 0x00006DDC
	internal static global::method ?pmField$initializer$@?$CVarTypeInfo@J@ATL@@2P6MXXZA;

	// Token: 0x0400006B RID: 107 RVA: 0x0001B184 File Offset: 0x00019784
	internal static global::<CppImplementationDetails>.$PTMType$QQtagVARIANT@@I ?pmField@?$CVarTypeInfo@I@ATL@@2QQtagVARIANT@@IQ3@;

	// Token: 0x0400006C RID: 108 RVA: 0x000081D4 File Offset: 0x00006DD4
	internal static global::method ?pmField$initializer$@?$CVarTypeInfo@I@ATL@@2P6MXXZA;

	// Token: 0x0400006D RID: 109 RVA: 0x00019524 File Offset: 0x00018124
	internal static global::_s__RTTIClassHierarchyDescriptor ??_R3_com_error@@8;

	// Token: 0x0400006E RID: 110 RVA: 0x00019640 File Offset: 0x00018240
	internal static global::_s__CatchableType _CT??_R0J@84;

	// Token: 0x0400006F RID: 111 RVA: 0x0001B180 File Offset: 0x00019780
	internal static global::<CppImplementationDetails>.$PTMType$QQtagVARIANT@@PAG ?pmField@?$CVarTypeInfo@PAG@ATL@@2QQtagVARIANT@@PAGQ3@;

	// Token: 0x04000070 RID: 112 RVA: 0x0000820C File Offset: 0x00006E0C
	internal static global::method ?pmField$initializer$@?$CVarTypeInfo@PAG@ATL@@2P6MXXZA;

	// Token: 0x04000071 RID: 113 RVA: 0x0001B17C File Offset: 0x0001977C
	internal static global::<CppImplementationDetails>.$PTMType$QQtagVARIANT@@PAD ?pmField@?$CVarTypeInfo@PAD@ATL@@2QQtagVARIANT@@PADQ3@;

	// Token: 0x04000072 RID: 114 RVA: 0x000081B8 File Offset: 0x00006DB8
	internal static global::method ?pmField$initializer$@?$CVarTypeInfo@PAD@ATL@@2P6MXXZA;

	// Token: 0x04000073 RID: 115 RVA: 0x00019664 File Offset: 0x00018264
	internal static global::_s__ThrowInfo _TI1J;

	// Token: 0x04000074 RID: 116 RVA: 0x000195AC File Offset: 0x000181AC
	internal static global::$_s__RTTIBaseClassArray$_extraBytes_4 ??_R2IshWorker@@8;

	// Token: 0x04000075 RID: 117 RVA: 0x0001B178 File Offset: 0x00019778
	internal static global::<CppImplementationDetails>.$PTMType$QQtagVARIANT@@K ?pmField@?$CVarTypeInfo@K@ATL@@2QQtagVARIANT@@KQ3@;

	// Token: 0x04000076 RID: 118 RVA: 0x000081E4 File Offset: 0x00006DE4
	internal static global::method ?pmField$initializer$@?$CVarTypeInfo@K@ATL@@2P6MXXZA;

	// Token: 0x04000077 RID: 119 RVA: 0x0001B11C File Offset: 0x0001971C
	internal static global::$_TypeDescriptor$_extraBytes_3 ??_R0J@8;

	// Token: 0x04000078 RID: 120 RVA: 0x000195B4 File Offset: 0x000181B4
	internal static global::_s__RTTIClassHierarchyDescriptor ??_R3IshWorker@@8;

	// Token: 0x04000079 RID: 121 RVA: 0x0001B174 File Offset: 0x00019774
	internal static global::<CppImplementationDetails>.$PTMType$QQtagVARIANT@@_J ?pmField@?$CVarTypeInfo@_J@ATL@@2QQtagVARIANT@@_JQ3@;

	// Token: 0x0400007A RID: 122 RVA: 0x000081EC File Offset: 0x00006DEC
	internal static global::method ?pmField$initializer$@?$CVarTypeInfo@_J@ATL@@2P6MXXZA;

	// Token: 0x0400007B RID: 123 RVA: 0x00019548 File Offset: 0x00018148
	internal static global::_s__RTTIBaseClassDescriptor2 ??_R1A@?0A@EA@IshError@@8;

	// Token: 0x0400007C RID: 124 RVA: 0x0001B170 File Offset: 0x00019770
	internal static global::<CppImplementationDetails>.$PTMType$QQtagVARIANT@@H ?pmField@?$CVarTypeInfo@H@ATL@@2QQtagVARIANT@@HQ3@;

	// Token: 0x0400007D RID: 125 RVA: 0x000081CC File Offset: 0x00006DCC
	internal static global::method ?pmField$initializer$@?$CVarTypeInfo@H@ATL@@2P6MXXZA;

	// Token: 0x0400007E RID: 126 RVA: 0x0001B010 File Offset: 0x00019610
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY01Q6AXXZ ??_7IshError@@6B@;

	// Token: 0x0400007F RID: 127 RVA: 0x0001965C File Offset: 0x0001825C
	internal static global::$_s__CatchableTypeArray$_extraBytes_4 _CTA1J;

	// Token: 0x04000080 RID: 128 RVA: 0x0001B16C File Offset: 0x0001976C
	internal static global::<CppImplementationDetails>.$PTMType$QQtagVARIANT@@D ?pmField@?$CVarTypeInfo@D@ATL@@2QQtagVARIANT@@DQ3@;

	// Token: 0x04000081 RID: 129 RVA: 0x000081B0 File Offset: 0x00006DB0
	internal static global::method ?pmField$initializer$@?$CVarTypeInfo@D@ATL@@2P6MXXZA;

	// Token: 0x04000082 RID: 130 RVA: 0x0001B104 File Offset: 0x00019704
	internal static global::$_TypeDescriptor$_extraBytes_16 ??_R0?AVIshWorker@@@8;

	// Token: 0x04000083 RID: 131 RVA: 0x0001B168 File Offset: 0x00019768
	internal static global::<CppImplementationDetails>.$PTMType$QQtagVARIANT@@N ?pmField@?$CVarTypeInfo@N@ATL@@2QQtagVARIANT@@NQ3@;

	// Token: 0x04000084 RID: 132 RVA: 0x00008204 File Offset: 0x00006E04
	internal static global::method ?pmField$initializer$@?$CVarTypeInfo@N@ATL@@2P6MXXZA;

	// Token: 0x04000085 RID: 133 RVA: 0x0001B164 File Offset: 0x00019764
	internal static global::<CppImplementationDetails>.$PTMType$QQtagVARIANT@@PAJ ?pmField@?$CVarTypeInfo@PAJ@ATL@@2QQtagVARIANT@@PAJQ3@;

	// Token: 0x04000086 RID: 134 RVA: 0x000081E0 File Offset: 0x00006DE0
	internal static global::method ?pmField$initializer$@?$CVarTypeInfo@PAJ@ATL@@2P6MXXZA;

	// Token: 0x04000087 RID: 135 RVA: 0x0001B160 File Offset: 0x00019760
	internal static global::<CppImplementationDetails>.$PTMType$QQtagVARIANT@@G ?pmField@?$CVarTypeInfo@G@ATL@@2QQtagVARIANT@@GQ3@;

	// Token: 0x04000088 RID: 136 RVA: 0x000081C8 File Offset: 0x00006DC8
	internal static global::method ?pmField$initializer$@?$CVarTypeInfo@G@ATL@@2P6MXXZA;

	// Token: 0x04000089 RID: 137 RVA: 0x0001951C File Offset: 0x0001811C
	internal static global::$_s__RTTIBaseClassArray$_extraBytes_4 ??_R2_com_error@@8;

	// Token: 0x0400008A RID: 138 RVA: 0x0001B15C File Offset: 0x0001975C
	internal static global::<CppImplementationDetails>.$PTMType$QQtagVARIANT@@PAE ?pmField@?$CVarTypeInfo@PAE@ATL@@2QQtagVARIANT@@PAEQ3@;

	// Token: 0x0400008B RID: 139 RVA: 0x000081BC File Offset: 0x00006DBC
	internal static global::method ?pmField$initializer$@?$CVarTypeInfo@PAE@ATL@@2P6MXXZA;

	// Token: 0x0400008C RID: 140 RVA: 0x0001B158 File Offset: 0x00019758
	internal static global::<CppImplementationDetails>.$PTMType$QQtagVARIANT@@TtagCY@@ ?pmField@?$CVarTypeInfo@TtagCY@@@ATL@@2QQtagVARIANT@@TtagCY@@Q3@;

	// Token: 0x0400008D RID: 141 RVA: 0x00008224 File Offset: 0x00006E24
	internal static global::method ?pmField$initializer$@?$CVarTypeInfo@TtagCY@@@ATL@@2P6MXXZA;

	// Token: 0x0400008E RID: 142 RVA: 0x0001B154 File Offset: 0x00019754
	internal static global::<CppImplementationDetails>.$PTMType$QQtagVARIANT@@PAPAUIDispatch@@ ?pmField@?$CVarTypeInfo@PAPAUIDispatch@@@ATL@@2QQtagVARIANT@@PAPAUIDispatch@@Q3@;

	// Token: 0x0400008F RID: 143 RVA: 0x00008220 File Offset: 0x00006E20
	internal static global::method ?pmField$initializer$@?$CVarTypeInfo@PAPAUIDispatch@@@ATL@@2P6MXXZA;

	// Token: 0x04000090 RID: 144 RVA: 0x0001B0EC File Offset: 0x000196EC
	internal static global::$_TypeDescriptor$_extraBytes_15 ??_R0?AVIshError@@@8;

	// Token: 0x04000091 RID: 145 RVA: 0x0001B000 File Offset: 0x00019600
	internal unsafe static void* _pAtlReleaseManagedClassFactories;

	// Token: 0x04000092 RID: 146 RVA: 0x000197AC File Offset: 0x000183AC
	internal unsafe static global::ATL._ATL_OBJMAP_ENTRY110* __pobjMapEntryLast;

	// Token: 0x04000093 RID: 147 RVA: 0x000197A8 File Offset: 0x000183A8
	internal unsafe static global::ATL._ATL_OBJMAP_ENTRY110* __pobjMapEntryFirst;

	// Token: 0x04000094 RID: 148 RVA: 0x0001B140 File Offset: 0x00019740
	internal static bool ?m_bInitFailed@CAtlBaseModule@ATL@@2_NA;

	// Token: 0x04000095 RID: 149 RVA: 0x0001B150 File Offset: 0x00019750
	internal static global::<CppImplementationDetails>.$PTMType$QQtagVARIANT@@PAI ?pmField@?$CVarTypeInfo@PAI@ATL@@2QQtagVARIANT@@PAIQ3@;

	// Token: 0x04000096 RID: 150 RVA: 0x0001B14C File Offset: 0x0001974C
	internal static global::<CppImplementationDetails>.$PTMType$QQtagVARIANT@@_K ?pmField@?$CVarTypeInfo@_K@ATL@@2QQtagVARIANT@@_KQ3@;

	// Token: 0x04000097 RID: 151 RVA: 0x0001B148 File Offset: 0x00019748
	internal static global::<CppImplementationDetails>.$PTMType$QQtagVARIANT@@PAH ?pmField@?$CVarTypeInfo@PAH@ATL@@2QQtagVARIANT@@PAHQ3@;

	// Token: 0x04000098 RID: 152 RVA: 0x0001B144 File Offset: 0x00019744
	internal static global::<CppImplementationDetails>.$PTMType$QQtagVARIANT@@F ?pmField@?$CVarTypeInfo@F@ATL@@2QQtagVARIANT@@FQ3@;

	// Token: 0x04000099 RID: 153 RVA: 0x0001B01C File Offset: 0x0001961C
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY01Q6AXXZ ??_7IshWorker@@6B@;

	// Token: 0x0400009A RID: 154 RVA: 0x000081F4 File Offset: 0x00006DF4
	internal static global::method ?pmField$initializer$@?$CVarTypeInfo@_K@ATL@@2P6MXXZA;

	// Token: 0x0400009B RID: 155 RVA: 0x000081C0 File Offset: 0x00006DC0
	internal static global::method ?pmField$initializer$@?$CVarTypeInfo@F@ATL@@2P6MXXZA;

	// Token: 0x0400009C RID: 156 RVA: 0x0000853C File Offset: 0x0000713C
	internal static uint ?npos@?$basic_string@DU?$char_traits@D@std@@V?$allocator@D@2@@std@@2IB;

	// Token: 0x0400009D RID: 157 RVA: 0x00019564 File Offset: 0x00018164
	internal static global::$_s__RTTIBaseClassArray$_extraBytes_4 ??_R2IshError@@8;

	// Token: 0x0400009E RID: 158 RVA: 0x000081D8 File Offset: 0x00006DD8
	internal static global::method ?pmField$initializer$@?$CVarTypeInfo@PAI@ATL@@2P6MXXZA;

	// Token: 0x0400009F RID: 159 RVA: 0x000081D0 File Offset: 0x00006DD0
	internal static global::method ?pmField$initializer$@?$CVarTypeInfo@PAH@ATL@@2P6MXXZA;

	// Token: 0x040000A0 RID: 160 RVA: 0x00008540 File Offset: 0x00007140
	internal static global::__s_GUID _GUID_90f1a06e_7712_4762_86b5_7a5eba6bdb02;

	// Token: 0x040000A1 RID: 161 RVA: 0x00008570 File Offset: 0x00007170
	internal static global::__s_GUID _GUID_cb2f6722_ab3a_11d2_9c40_00c04fa30a3e;

	// Token: 0x040000A2 RID: 162 RVA: 0x00008234 File Offset: 0x00006E34
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY00Q6MPBXXZ __xc_mp_z;

	// Token: 0x040000A3 RID: 163
	[global::System.Runtime.CompilerServices.FixedAddressValueType]
	internal static int ?Uninitialized@CurrentDomain@<CrtImplementationDetails>@@$$Q2HA;

	// Token: 0x040000A4 RID: 164 RVA: 0x00008188 File Offset: 0x00006D88
	internal static global::method ?Uninitialized$initializer$@CurrentDomain@<CrtImplementationDetails>@@$$Q2P6MXXZA;

	// Token: 0x040000A5 RID: 165 RVA: 0x00008238 File Offset: 0x00006E38
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY00Q6MPBXXZ __xi_vt_a;

	// Token: 0x040000A6 RID: 166
	[global::System.Runtime.CompilerServices.FixedAddressValueType]
	internal static global::<CrtImplementationDetails>.Progress.State ?InitializedPerAppDomain@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A;

	// Token: 0x040000A7 RID: 167 RVA: 0x0000819C File Offset: 0x00006D9C
	internal static global::method ?InitializedPerAppDomain$initializer$@CurrentDomain@<CrtImplementationDetails>@@$$Q2P6MXXZA;

	// Token: 0x040000A8 RID: 168
	[global::System.Runtime.CompilerServices.FixedAddressValueType]
	internal static bool ?IsDefaultDomain@CurrentDomain@<CrtImplementationDetails>@@$$Q2_NA;

	// Token: 0x040000A9 RID: 169 RVA: 0x0000818C File Offset: 0x00006D8C
	internal static global::method ?IsDefaultDomain$initializer$@CurrentDomain@<CrtImplementationDetails>@@$$Q2P6MXXZA;

	// Token: 0x040000AA RID: 170 RVA: 0x00008180 File Offset: 0x00006D80
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY00Q6MPBXXZ __xc_ma_a;

	// Token: 0x040000AB RID: 171
	[global::System.Runtime.CompilerServices.FixedAddressValueType]
	internal static global::<CrtImplementationDetails>.Progress.State ?InitializedNative@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A;

	// Token: 0x040000AC RID: 172 RVA: 0x00008194 File Offset: 0x00006D94
	internal static global::method ?InitializedNative$initializer$@CurrentDomain@<CrtImplementationDetails>@@$$Q2P6MXXZA;

	// Token: 0x040000AD RID: 173
	[global::System.Runtime.CompilerServices.FixedAddressValueType]
	internal static int ?Initialized@CurrentDomain@<CrtImplementationDetails>@@$$Q2HA;

	// Token: 0x040000AE RID: 174 RVA: 0x00008184 File Offset: 0x00006D84
	internal static global::method ?Initialized$initializer$@CurrentDomain@<CrtImplementationDetails>@@$$Q2P6MXXZA;

	// Token: 0x040000AF RID: 175 RVA: 0x000081A0 File Offset: 0x00006DA0
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY00Q6MPBXXZ __xc_ma_z;

	// Token: 0x040000B0 RID: 176
	[global::System.Runtime.CompilerServices.FixedAddressValueType]
	internal static global::<CrtImplementationDetails>.Progress.State ?InitializedVtables@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A;

	// Token: 0x040000B1 RID: 177 RVA: 0x00008190 File Offset: 0x00006D90
	internal static global::method ?InitializedVtables$initializer$@CurrentDomain@<CrtImplementationDetails>@@$$Q2P6MXXZA;

	// Token: 0x040000B2 RID: 178 RVA: 0x0000823C File Offset: 0x00006E3C
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY00Q6MPBXXZ __xi_vt_z;

	// Token: 0x040000B3 RID: 179 RVA: 0x00008560 File Offset: 0x00007160
	internal static global::__s_GUID _GUID_cb2f6723_ab3a_11d2_9c40_00c04fa30a3e;

	// Token: 0x040000B4 RID: 180
	[global::System.Runtime.CompilerServices.FixedAddressValueType]
	internal static global::<CrtImplementationDetails>.Progress.State ?InitializedPerProcess@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A;

	// Token: 0x040000B5 RID: 181 RVA: 0x00008198 File Offset: 0x00006D98
	internal static global::method ?InitializedPerProcess$initializer$@CurrentDomain@<CrtImplementationDetails>@@$$Q2P6MXXZA;

	// Token: 0x040000B6 RID: 182 RVA: 0x0001B213 File Offset: 0x00019813
	internal static bool ?InitializedPerProcess@DefaultDomain@<CrtImplementationDetails>@@2_NA;

	// Token: 0x040000B7 RID: 183 RVA: 0x0001B210 File Offset: 0x00019810
	internal static bool ?Entered@DefaultDomain@<CrtImplementationDetails>@@2_NA;

	// Token: 0x040000B8 RID: 184 RVA: 0x0001B211 File Offset: 0x00019811
	internal static bool ?InitializedNative@DefaultDomain@<CrtImplementationDetails>@@2_NA;

	// Token: 0x040000B9 RID: 185 RVA: 0x0001B20C File Offset: 0x0001980C
	internal static int ?Count@AllDomains@<CrtImplementationDetails>@@2HA;

	// Token: 0x040000BA RID: 186 RVA: 0x0001B0A8 File Offset: 0x000196A8
	internal static global::<CrtImplementationDetails>.TriBool.State ?hasNative@DefaultDomain@<CrtImplementationDetails>@@0W4State@TriBool@2@A;

	// Token: 0x040000BB RID: 187 RVA: 0x0001B0A4 File Offset: 0x000196A4
	internal static global::<CrtImplementationDetails>.TriBool.State ?hasPerProcess@DefaultDomain@<CrtImplementationDetails>@@0W4State@TriBool@2@A;

	// Token: 0x040000BC RID: 188 RVA: 0x0001B212 File Offset: 0x00019812
	internal static bool ?InitializedNativeFromCCTOR@DefaultDomain@<CrtImplementationDetails>@@2_NA;

	// Token: 0x040000BD RID: 189 RVA: 0x000081A4 File Offset: 0x00006DA4
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY00Q6MPBXXZ __xc_mp_a;

	// Token: 0x040000BE RID: 190 RVA: 0x00008550 File Offset: 0x00007150
	internal static global::__s_GUID _GUID_90f1a06c_7712_4762_86b5_7a5eba6bdb02;

	// Token: 0x040000BF RID: 191 RVA: 0x00008580 File Offset: 0x00007180
	public unsafe static int** __unep@?DoNothing@DefaultDomain@<CrtImplementationDetails>@@$$FCGJPAX@Z;

	// Token: 0x040000C0 RID: 192 RVA: 0x00008584 File Offset: 0x00007184
	public unsafe static int** __unep@?_UninitializeDefaultDomain@LanguageSupport@<CrtImplementationDetails>@@$$FCGJPAX@Z;

	// Token: 0x040000C1 RID: 193
	[global::System.Runtime.CompilerServices.FixedAddressValueType]
	internal static uint __exit_list_size_app_domain;

	// Token: 0x040000C2 RID: 194
	[global::System.Runtime.CompilerServices.FixedAddressValueType]
	internal unsafe static global::method* __onexitbegin_app_domain;

	// Token: 0x040000C3 RID: 195 RVA: 0x0001B320 File Offset: 0x00019920
	internal static uint __exit_list_size;

	// Token: 0x040000C4 RID: 196
	[global::System.Runtime.CompilerServices.FixedAddressValueType]
	internal unsafe static global::method* __onexitend_app_domain;

	// Token: 0x040000C5 RID: 197 RVA: 0x0001B318 File Offset: 0x00019918
	internal unsafe static global::method* __onexitbegin_m;

	// Token: 0x040000C6 RID: 198 RVA: 0x0001B31C File Offset: 0x0001991C
	internal unsafe static global::method* __onexitend_m;

	// Token: 0x040000C7 RID: 199
	[global::System.Runtime.CompilerServices.FixedAddressValueType]
	internal unsafe static void* ?_lock@AtExitLock@<CrtImplementationDetails>@@$$Q0PAXA;

	// Token: 0x040000C8 RID: 200
	[global::System.Runtime.CompilerServices.FixedAddressValueType]
	internal static int ?_ref_count@AtExitLock@<CrtImplementationDetails>@@$$Q0HA;

	// Token: 0x040000C9 RID: 201
	internal static global::_IMAGE_DOS_HEADER __ImageBase;

	// Token: 0x040000CA RID: 202 RVA: 0x0000858C File Offset: 0x0000718C
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY01Q6AXXZ ??_7type_info@@6B@;

	// Token: 0x040000CB RID: 203 RVA: 0x0001B680 File Offset: 0x00019C80
	internal static global::ATL.CAtlBaseModule _AtlBaseModule;

	// Token: 0x040000CC RID: 204 RVA: 0x0000816C File Offset: 0x00006D6C
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0A@P6AXXZ __xc_z;

	// Token: 0x040000CD RID: 205 RVA: 0x00008164 File Offset: 0x00006D64
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0A@P6AXXZ __xc_a;

	// Token: 0x040000CE RID: 206 RVA: 0x00008170 File Offset: 0x00006D70
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0A@P6AHXZ __xi_a;

	// Token: 0x040000CF RID: 207 RVA: 0x0001B6C8 File Offset: 0x00019CC8
	internal static volatile global::__enative_startup_state __native_startup_state;

	// Token: 0x040000D0 RID: 208 RVA: 0x0000817C File Offset: 0x00006D7C
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0A@P6AHXZ __xi_z;

	// Token: 0x040000D1 RID: 209 RVA: 0x0001B6C4 File Offset: 0x00019CC4
	internal unsafe static volatile void* __native_startup_lock;

	// Token: 0x040000D2 RID: 210 RVA: 0x0001B0BC File Offset: 0x000196BC
	internal static volatile uint __native_dllmain_reason;
}
