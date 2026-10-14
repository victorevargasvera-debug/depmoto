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
using LEAdaptor;
using Motorola.Common.Communication.CommonUtil;
using std;

// Token: 0x02000001 RID: 1
internal class <Module>
{
	// Token: 0x06000001 RID: 1 RVA: 0x00001298 File Offset: 0x00000698
	internal unsafe static global::CallbackCrossAppdomain* {ctor}(global::CallbackCrossAppdomain* A_0, global::CallbackDelegate cb)
	{
		*A_0 = ref global::<Module>.??_7CallbackCrossAppdomain@@6B@;
		global::CallbackCrossAppdomain* ptr = A_0 + 4;
		global::<Module>.gcroot<CallbackDelegate\u0020^>.{ctor}(ptr);
		try
		{
			global::<Module>.gcroot<CallbackDelegate\u0020^>.=(ptr, cb);
			global::System.IntPtr functionPointerForDelegate = global::System.Runtime.InteropServices.Marshal.GetFunctionPointerForDelegate<global::CallbackDelegate>(cb);
			*(A_0 + 8) = functionPointerForDelegate.ToPointer();
		}
		catch
		{
			global::<Module>.___CxxCallUnwindDtor(ldftn(gcroot<CallbackDelegate\u0020^>.{dtor}), A_0 + 4);
			throw;
		}
		return A_0;
	}

	// Token: 0x06000002 RID: 2 RVA: 0x0000131C File Offset: 0x0000071C
	internal unsafe static void* __vecDelDtor(global::CallbackCrossAppdomain* A_0, uint A_0)
	{
		if ((A_0 & 2U) != 0U)
		{
			global::CallbackCrossAppdomain* ptr = A_0 - 4;
			global::<Module>.__ehvec_dtor(A_0, 12U, *ptr, ldftn(CallbackCrossAppdomain.{dtor}));
			if ((A_0 & 1U) != 0U)
			{
				global::<Module>.delete(ptr);
			}
			return ptr;
		}
		*A_0 = ref global::<Module>.??_7CallbackCrossAppdomain@@6B@;
		global::<Module>.gcroot<CallbackDelegate\u0020^>.{dtor}(A_0 + 4);
		if ((A_0 & 1U) != 0U)
		{
			global::<Module>.delete(A_0);
		}
		return A_0;
	}

	// Token: 0x06000003 RID: 3 RVA: 0x00001230 File Offset: 0x00000630
	internal unsafe static void Invoke(global::CallbackCrossAppdomain* A_0, uint args1, uint args2, uint args3)
	{
		calli(System.Void modopt(System.Runtime.CompilerServices.CallConvStdcall)(System.UInt32,System.UInt32,System.UInt32), args1, args2, args3, *(A_0 + 8));
	}

	// Token: 0x06000004 RID: 4 RVA: 0x00001300 File Offset: 0x00000700
	internal unsafe static void {dtor}(global::CallbackCrossAppdomain* A_0)
	{
		*A_0 = ref global::<Module>.??_7CallbackCrossAppdomain@@6B@;
		global::<Module>.gcroot<CallbackDelegate\u0020^>.{dtor}(A_0 + 4);
	}

	// Token: 0x06000005 RID: 5 RVA: 0x0000124C File Offset: 0x0000064C
	[global::System.Security.SecuritySafeCritical]
	[global::System.Diagnostics.DebuggerStepThrough]
	internal unsafe static global::gcroot<CallbackDelegate\u0020^>* {ctor}(global::gcroot<CallbackDelegate\u0020^>* A_0)
	{
		*A_0 = ((global::System.IntPtr)global::System.Runtime.InteropServices.GCHandle.Alloc(null)).ToPointer();
		return A_0;
	}

	// Token: 0x06000006 RID: 6 RVA: 0x000049F0 File Offset: 0x00003DF0
	[global::System.Security.SecurityCritical]
	[global::System.Diagnostics.DebuggerStepThrough]
	internal unsafe static void {dtor}(global::gcroot<CallbackDelegate\u0020^>* A_0)
	{
		global::System.IntPtr value = new global::System.IntPtr(*A_0);
		((global::System.Runtime.InteropServices.GCHandle)value).Free();
		*A_0 = 0;
	}

	// Token: 0x06000007 RID: 7 RVA: 0x00001270 File Offset: 0x00000670
	[global::System.Security.SecurityCritical]
	[global::System.Diagnostics.DebuggerStepThrough]
	internal unsafe static global::gcroot<CallbackDelegate\u0020^>* =(global::gcroot<CallbackDelegate\u0020^>* A_0, global::CallbackDelegate t)
	{
		global::System.IntPtr value = new global::System.IntPtr(*A_0);
		((global::System.Runtime.InteropServices.GCHandle)value).Target = t;
		return A_0;
	}

	// Token: 0x06000008 RID: 8 RVA: 0x00001528 File Offset: 0x00000928
	internal unsafe static uint _Hash_seq(byte* _First, uint _Count)
	{
		uint num = 2166136261U;
		uint num2 = 0U;
		if (0U < _Count)
		{
			do
			{
				num = ((uint)(*(byte*)(num2 / (uint)sizeof(byte) + _First)) ^ num) * 16777619U;
				num2 += 1U;
			}
			while (num2 < _Count);
		}
		return num;
	}

	// Token: 0x06000009 RID: 9 RVA: 0x00001558 File Offset: 0x00000958
	internal unsafe static void delete(void* A_0, void* A_1)
	{
	}

	// Token: 0x0600000A RID: 10 RVA: 0x00001568 File Offset: 0x00000968
	internal unsafe static void {dtor}(global::std.error_category* A_0)
	{
		*A_0 = ref global::<Module>.??_7error_category@std@@6B@;
	}

	// Token: 0x0600000B RID: 11 RVA: 0x000044E8 File Offset: 0x000038E8
	internal unsafe static void* __vecDelDtor(global::std.error_category* A_0, uint A_0)
	{
		if ((A_0 & 2U) != 0U)
		{
			global::std.error_category* ptr = A_0 - 4;
			global::<Module>.__ehvec_dtor(A_0, 4U, *ptr, ldftn(std.error_category.{dtor}));
			if ((A_0 & 1U) != 0U)
			{
				global::<Module>.delete[](ptr);
			}
			return ptr;
		}
		*A_0 = ref global::<Module>.??_7error_category@std@@6B@;
		if ((A_0 & 1U) != 0U)
		{
			global::<Module>.delete(A_0);
		}
		return A_0;
	}

	// Token: 0x0600000C RID: 12 RVA: 0x000045A0 File Offset: 0x000039A0
	[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
	internal unsafe static bool ==(global::std.error_condition* A_0, global::std.error_condition* _Right)
	{
		int num;
		if (((*(A_0 + 4) == *(_Right + 4)) ? 1 : 0) != 0 && *A_0 == *_Right)
		{
			num = 1;
		}
		else
		{
			num = 0;
		}
		return (byte)num;
	}

	// Token: 0x0600000D RID: 13 RVA: 0x00004534 File Offset: 0x00003934
	internal unsafe static global::std.error_condition* default_error_condition(global::std.error_category* A_0, global::std.error_condition* A_1, int _Errval)
	{
		*(int*)A_1 = _Errval;
		*(int*)(A_1 + 4 / sizeof(global::std.error_condition)) = A_0;
		return A_1;
	}

	// Token: 0x0600000E RID: 14 RVA: 0x0000457C File Offset: 0x0000397C
	[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
	internal unsafe static bool equivalent(global::std.error_category* A_0, int _Errval, global::std.error_condition* _Cond)
	{
		global::std.error_condition error_condition;
		return global::<Module>.std.error_condition.==(calli(std.error_condition* modreq(System.Runtime.CompilerServices.IsUdtReturn) modopt(System.Runtime.CompilerServices.CallConvThiscall)(System.IntPtr,std.error_condition*,System.Int32), A_0, ref error_condition, _Errval, *(*A_0 + 12)), _Cond);
	}

	// Token: 0x0600000F RID: 15 RVA: 0x00004550 File Offset: 0x00003950
	[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
	internal unsafe static bool equivalent(global::std.error_category* A_0, global::std.error_code* _Code, int _Errval)
	{
		int num;
		if (((A_0 == *(_Code + 4)) ? 1 : 0) != 0 && *_Code == _Errval)
		{
			num = 1;
		}
		else
		{
			num = 0;
		}
		return (byte)num;
	}

	// Token: 0x06000010 RID: 16 RVA: 0x00004620 File Offset: 0x00003A20
	internal unsafe static sbyte* name(global::std._Generic_error_category* A_0)
	{
		return ref global::<Module>.??_C@_07DCLBNMLN@generic?$AA@;
	}

	// Token: 0x06000011 RID: 17 RVA: 0x00004638 File Offset: 0x00003A38
	internal unsafe static global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* message(global::std._Generic_error_category* A_0, global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* A_1, int _Errcode)
	{
		uint num = 0U;
		sbyte* ptr = global::<Module>.std._Syserror_map(_Errcode);
		sbyte* ptr2 = (ptr != null) ? ptr : ((sbyte*)(&global::<Module>.??_C@_0O@BFJCFAAK@unknown?5error?$AA@));
		global::<Module>.std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>.{ctor}(A_1, ptr2);
		try
		{
			num = 1U;
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

	// Token: 0x06000012 RID: 18 RVA: 0x000045D0 File Offset: 0x000039D0
	internal unsafe static void* __vecDelDtor(global::std._Generic_error_category* A_0, uint A_0)
	{
		if ((A_0 & 2U) != 0U)
		{
			global::std._Generic_error_category* ptr = A_0 - 4;
			global::<Module>.__ehvec_dtor(A_0, 4U, *ptr, ldftn(std._Generic_error_category.{dtor}));
			if ((A_0 & 1U) != 0U)
			{
				global::<Module>.delete[](ptr);
			}
			return ptr;
		}
		*A_0 = ref global::<Module>.??_7error_category@std@@6B@;
		if ((A_0 & 1U) != 0U)
		{
			global::<Module>.delete(A_0);
		}
		return A_0;
	}

	// Token: 0x06000013 RID: 19 RVA: 0x0000157C File Offset: 0x0000097C
	internal unsafe static void {dtor}(global::std._Generic_error_category* A_0)
	{
		*A_0 = ref global::<Module>.??_7error_category@std@@6B@;
	}

	// Token: 0x06000014 RID: 20 RVA: 0x000047CC File Offset: 0x00003BCC
	internal unsafe static sbyte* name(global::std._Iostream_error_category* A_0)
	{
		return ref global::<Module>.??_C@_08LLGCOLLL@iostream?$AA@;
	}

	// Token: 0x06000015 RID: 21 RVA: 0x000047E4 File Offset: 0x00003BE4
	internal unsafe static global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* message(global::std._Iostream_error_category* A_0, global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* A_1, int _Errcode)
	{
		uint num = 0U;
		if (_Errcode == 1)
		{
			global::<Module>.std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>.{ctor}(A_1, (sbyte*)(&global::<Module>.??_C@_0BG@PADBLCHM@iostream?5stream?5error?$AA@));
			try
			{
				num = 1U;
				return A_1;
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
		global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* result;
		try
		{
			num = 1U;
			result = A_1;
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

	// Token: 0x06000016 RID: 22 RVA: 0x0000477C File Offset: 0x00003B7C
	internal unsafe static void* __vecDelDtor(global::std._Iostream_error_category* A_0, uint A_0)
	{
		if ((A_0 & 2U) != 0U)
		{
			global::std._Iostream_error_category* ptr = A_0 - 4;
			global::<Module>.__ehvec_dtor(A_0, 4U, *ptr, ldftn(std._Iostream_error_category.{dtor}));
			if ((A_0 & 1U) != 0U)
			{
				global::<Module>.delete[](ptr);
			}
			return ptr;
		}
		*A_0 = ref global::<Module>.??_7error_category@std@@6B@;
		if ((A_0 & 1U) != 0U)
		{
			global::<Module>.delete(A_0);
		}
		return A_0;
	}

	// Token: 0x06000017 RID: 23 RVA: 0x00001590 File Offset: 0x00000990
	internal unsafe static void {dtor}(global::std._Iostream_error_category* A_0)
	{
		*A_0 = ref global::<Module>.??_7error_category@std@@6B@;
	}

	// Token: 0x06000018 RID: 24 RVA: 0x000048D4 File Offset: 0x00003CD4
	internal unsafe static sbyte* name(global::std._System_error_category* A_0)
	{
		return ref global::<Module>.??_C@_06FHFOAHML@system?$AA@;
	}

	// Token: 0x06000019 RID: 25 RVA: 0x000048EC File Offset: 0x00003CEC
	internal unsafe static global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* message(global::std._System_error_category* A_0, global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* A_1, int _Errcode)
	{
		uint num = 0U;
		sbyte* ptr = global::<Module>.std._Winerror_map(_Errcode);
		sbyte* ptr2 = (ptr != null) ? ptr : ((sbyte*)(&global::<Module>.??_C@_0O@BFJCFAAK@unknown?5error?$AA@));
		global::<Module>.std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>.{ctor}(A_1, ptr2);
		try
		{
			num = 1U;
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

	// Token: 0x0600001A RID: 26 RVA: 0x0000495C File Offset: 0x00003D5C
	internal unsafe static global::std.error_condition* default_error_condition(global::std._System_error_category* A_0, global::std.error_condition* A_1, int _Errval)
	{
		if (global::<Module>.std._Syserror_map(_Errval) != null)
		{
			*(int*)A_1 = _Errval;
			*(int*)(A_1 + 4 / sizeof(global::std.error_condition)) = ref global::<Module>.?_Generic_object@?$_Error_objects@H@std@@2V_Generic_error_category@2@A;
			return A_1;
		}
		*(int*)A_1 = _Errval;
		*(int*)(A_1 + 4 / sizeof(global::std.error_condition)) = ref global::<Module>.?_System_object@?$_Error_objects@H@std@@2V_System_error_category@2@A;
		return A_1;
	}

	// Token: 0x0600001B RID: 27 RVA: 0x00004884 File Offset: 0x00003C84
	internal unsafe static void* __vecDelDtor(global::std._System_error_category* A_0, uint A_0)
	{
		if ((A_0 & 2U) != 0U)
		{
			global::std._System_error_category* ptr = A_0 - 4;
			global::<Module>.__ehvec_dtor(A_0, 4U, *ptr, ldftn(std._System_error_category.{dtor}));
			if ((A_0 & 1U) != 0U)
			{
				global::<Module>.delete[](ptr);
			}
			return ptr;
		}
		*A_0 = ref global::<Module>.??_7error_category@std@@6B@;
		if ((A_0 & 1U) != 0U)
		{
			global::<Module>.delete(A_0);
		}
		return A_0;
	}

	// Token: 0x0600001C RID: 28 RVA: 0x000015A4 File Offset: 0x000009A4
	internal unsafe static void {dtor}(global::std._System_error_category* A_0)
	{
		*A_0 = ref global::<Module>.??_7error_category@std@@6B@;
	}

	// Token: 0x0600001D RID: 29 RVA: 0x00003D7C File Offset: 0x0000317C
	internal unsafe static void* __delDtor(global::std.unordered_map<unsigned\u0020int,ProxyConnectionHandler\u0020*,std::hash<unsigned\u0020int>,std::equal_to<unsigned\u0020int>,std::allocator<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>* A_0, uint A_0)
	{
		try
		{
			global::<Module>.std.vector<std::_List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>,std::_Wrap_alloc<std::allocator<std::_List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>\u0020>\u0020>\u0020>._Tidy(A_0 + 8);
		}
		catch
		{
			global::<Module>.___CxxCallUnwindDtor(ldftn(std.list<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>,std::allocator<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>.{dtor}), A_0);
			throw;
		}
		try
		{
			global::<Module>.std.list<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>,std::allocator<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>.clear(A_0);
		}
		catch
		{
			global::<Module>.___CxxCallUnwindDtor(ldftn(std._List_buy<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>,std::allocator<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>.{dtor}), A_0);
			throw;
		}
		global::<Module>.delete(*A_0);
		if ((A_0 & 1U) != 0U)
		{
			global::<Module>.delete(A_0);
		}
		return A_0;
	}

	// Token: 0x0600001E RID: 30 RVA: 0x0000171C File Offset: 0x00000B1C
	internal unsafe static void onDeviceStatusChanged(void* ctx, void* e)
	{
		int num = (int)stackalloc byte[global::<Module>.__CxxQueryExceptionSize()];
		uint exceptionCode;
		try
		{
			if (ctx != null && e != null)
			{
				global::<Module>.CallbackCrossAppdomain.Invoke(ctx, 0U, (uint)(*(int*)(e + 4 / sizeof(void))), (uint)(*(int*)e));
			}
		}
		catch (global::System.Exception ex)
		{
			object[] args = new object[0];
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(ex.StackTrace, args);
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
					object[] args2 = new object[0];
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("Error occurs!", args2);
					return;
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

	// Token: 0x0600001F RID: 31 RVA: 0x00001830 File Offset: 0x00000C30
	internal unsafe static void onTCStautsChanged(void* ctx, void* e)
	{
		int num = (int)stackalloc byte[global::<Module>.__CxxQueryExceptionSize()];
		uint exceptionCode;
		try
		{
			if (ctx != null && e != null)
			{
				global::<Module>.CallbackCrossAppdomain.Invoke(ctx, 1U, (uint)(*(int*)(e + 4 / sizeof(void))), (uint)(*(int*)e));
			}
		}
		catch (global::System.Exception ex)
		{
			object[] args = new object[0];
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(ex.StackTrace, args);
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
					object[] args2 = new object[0];
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("Error occurs!", args2);
					return;
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

	// Token: 0x06000020 RID: 32 RVA: 0x00001944 File Offset: 0x00000D44
	internal unsafe static void OnRoleAssignment(void* ctx, void* e)
	{
		int num = (int)stackalloc byte[global::<Module>.__CxxQueryExceptionSize()];
		uint exceptionCode;
		try
		{
			if (ctx != null && e != null)
			{
				global::<Module>.CallbackCrossAppdomain.Invoke(ctx, 2U, (uint)(*(int*)e), (uint)(*(int*)(e + 4 / sizeof(void))));
			}
		}
		catch (global::System.Exception ex)
		{
			object[] args = new object[0];
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(ex.StackTrace, args);
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
					object[] args2 = new object[0];
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("Error occurs!", args2);
					return;
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

	// Token: 0x06000021 RID: 33 RVA: 0x00001A58 File Offset: 0x00000E58
	internal unsafe static void OnRRPConnectionResponse(void* ctx, void* e)
	{
		int num = (int)stackalloc byte[global::<Module>.__CxxQueryExceptionSize()];
		uint exceptionCode;
		try
		{
			if (ctx != null && e != null)
			{
				global::<Module>.CallbackCrossAppdomain.Invoke(ctx, 3U, (uint)(*(int*)e), (uint)(*(int*)(e + 4 / sizeof(void))));
			}
		}
		catch (global::System.Exception ex)
		{
			object[] args = new object[0];
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(ex.StackTrace, args);
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
					object[] args2 = new object[0];
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("Error occurs!", args2);
					return;
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

	// Token: 0x06000022 RID: 34 RVA: 0x000046A0 File Offset: 0x00003AA0
	internal unsafe static global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* {ctor}(global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* A_0, sbyte* _Ptr)
	{
		*(A_0 + 16) = 0;
		*(A_0 + 20) = 0;
		global::<Module>.std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>._Tidy(A_0, false, 0U);
		uint count;
		if (*(sbyte*)_Ptr == 0)
		{
			count = 0U;
		}
		else
		{
			sbyte* ptr = _Ptr;
			do
			{
				ptr += 1 / sizeof(sbyte);
			}
			while (*(sbyte*)ptr != 0);
			count = (uint)(ptr - _Ptr);
		}
		global::<Module>.std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>.assign(A_0, _Ptr, count);
		return A_0;
	}

	// Token: 0x06000023 RID: 35 RVA: 0x0000306C File Offset: 0x0000246C
	internal unsafe static void {dtor}(global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* A_0)
	{
		global::<Module>.std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>._Tidy(A_0, true, 0U);
	}

	// Token: 0x06000024 RID: 36 RVA: 0x00004364 File Offset: 0x00003764
	internal unsafe static uint erase(global::std._Hash<std::_Umap_traits<unsigned\u0020int,ProxyConnectionHandler\u0020*,std::_Uhash_compare<unsigned\u0020int,std::hash<unsigned\u0020int>,std::equal_to<unsigned\u0020int>\u0020>,std::allocator<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>,0>\u0020>* A_0, uint* _Keyval)
	{
		global::std.pair<std::_List_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>,std::_List_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>\u0020> pair<std::_List_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020>,std::_List_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020>_u0020>;
		global::<Module>.std._Hash<std::_Umap_traits<unsigned\u0020int,ProxyConnectionHandler\u0020*,std::_Uhash_compare<unsigned\u0020int,std::hash<unsigned\u0020int>,std::equal_to<unsigned\u0020int>\u0020>,std::allocator<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>,0>\u0020>.equal_range(A_0, &pair<std::_List_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020>,std::_List_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020>_u0020>, _Keyval);
		uint num = 0U;
		global::std._List_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020> list_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020>;
		cpblk(ref list_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020>, ref pair<std::_List_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020>,std::_List_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020>_u0020> + 4, 4);
		global::std._List_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020> list_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020>2;
		cpblk(ref list_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020>2, ref pair<std::_List_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020>,std::_List_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020>_u0020>, 4);
		while (((((list_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020>2 == list_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020>) ? 1 : 0) == 0) ? 1 : 0) != 0)
		{
			num += 1U;
			list_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020>2 = *list_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020>2;
		}
		global::std._List_const_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020> last;
		cpblk(ref last, ref pair<std::_List_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020>,std::_List_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020>_u0020> + 4, 4);
		global::std._List_const_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020> first;
		cpblk(ref first, ref pair<std::_List_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020>,std::_List_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020>_u0020>, 4);
		global::std._List_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020> list_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020>3;
		global::<Module>.std._Hash<std::_Umap_traits<unsigned\u0020int,ProxyConnectionHandler\u0020*,std::_Uhash_compare<unsigned\u0020int,std::hash<unsigned\u0020int>,std::equal_to<unsigned\u0020int>\u0020>,std::allocator<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>,0>\u0020>.erase(A_0, &list_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020>3, first, last);
		return num;
	}

	// Token: 0x06000025 RID: 37 RVA: 0x000033F0 File Offset: 0x000027F0
	internal unsafe static global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* assign(global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* A_0, global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* _Right, uint _Roff, uint _Count)
	{
		uint num = (uint)(*(_Right + 16));
		if (num < _Roff)
		{
			global::<Module>.std._Xout_of_range((sbyte*)(&global::<Module>.??_C@_0BI@CFPLBAOH@invalid?5string?5position?$AA@));
		}
		uint num2 = num - _Roff;
		num2 = ((_Count < num2) ? _Count : num2);
		if (A_0 == _Right)
		{
			uint num3 = num2 + _Roff;
			if (*(A_0 + 16) < (int)num3)
			{
				global::<Module>.std._Xout_of_range((sbyte*)(&global::<Module>.??_C@_0BI@CFPLBAOH@invalid?5string?5position?$AA@));
			}
			*(A_0 + 16) = (int)num3;
			*(((16 > *(A_0 + 20)) ? A_0 : (*A_0)) + num3) = 0;
			global::<Module>.std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>.erase(A_0, 0U, _Roff);
		}
		else if (global::<Module>.std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>._Grow(A_0, num2, false) != null)
		{
			sbyte* ptr;
			if (16 <= *(_Right + 20))
			{
				ptr = *_Right;
			}
			else
			{
				ptr = _Right;
			}
			sbyte* ptr2;
			if (16 <= *(A_0 + 20))
			{
				ptr2 = *A_0;
			}
			else
			{
				ptr2 = A_0;
			}
			if (num2 != 0U)
			{
				cpblk(ptr2, ptr + _Roff / (uint)sizeof(sbyte), num2);
			}
			*(A_0 + 16) = (int)num2;
			*(((16 > *(A_0 + 20)) ? A_0 : (*A_0)) + num2) = 0;
		}
		return A_0;
	}

	// Token: 0x06000026 RID: 38 RVA: 0x00002BA8 File Offset: 0x00001FA8
	internal unsafe static void _Tidy(global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* A_0, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)] bool _Built, uint _Newsize)
	{
		if (_Built && 16 <= *(A_0 + 20))
		{
			sbyte* ptr = *A_0;
			if (0U < _Newsize)
			{
				cpblk(A_0, ptr, _Newsize);
			}
			global::<Module>.delete((void*)ptr);
		}
		*(A_0 + 20) = 15;
		*(A_0 + 16) = (int)_Newsize;
		*(_Newsize + A_0) = 0;
	}

	// Token: 0x06000027 RID: 39 RVA: 0x00003EF0 File Offset: 0x000032F0
	internal unsafe static global::std._Hash<std::_Umap_traits<unsigned\u0020int,ProxyConnectionHandler\u0020*,std::_Uhash_compare<unsigned\u0020int,std::hash<unsigned\u0020int>,std::equal_to<unsigned\u0020int>\u0020>,std::allocator<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>,0>\u0020>* {ctor}(global::std._Hash<std::_Umap_traits<unsigned\u0020int,ProxyConnectionHandler\u0020*,std::_Uhash_compare<unsigned\u0020int,std::hash<unsigned\u0020int>,std::equal_to<unsigned\u0020int>\u0020>,std::allocator<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>,0>\u0020>* A_0, global::std._Uhash_compare<unsigned\u0020int,std::hash<unsigned\u0020int>,std::equal_to<unsigned\u0020int>\u0020>* _Parg, global::std.allocator<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>* _Al)
	{
		*A_0 = 0;
		*(A_0 + 4) = 0;
		*A_0 = global::<Module>.std._List_alloc<0,std::_List_base_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>,std::allocator<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>._Buynode0(A_0, null, null);
		try
		{
			global::std.vector<std::_List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>,std::_Wrap_alloc<std::allocator<std::_List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>\u0020>\u0020>\u0020>* ptr = A_0 + 8;
			*ptr = 0;
			*(ptr + 4) = 0;
			*(ptr + 8) = 0;
			try
			{
				*(A_0 + 28) = 1f;
				global::<Module>.std._Hash<std::_Umap_traits<unsigned\u0020int,ProxyConnectionHandler\u0020*,std::_Uhash_compare<unsigned\u0020int,std::hash<unsigned\u0020int>,std::equal_to<unsigned\u0020int>\u0020>,std::allocator<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>,0>\u0020>._Init(A_0, 8U);
			}
			catch
			{
				global::<Module>.___CxxCallUnwindDtor(ldftn(std.vector<std::_List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>,std::_Wrap_alloc<std::allocator<std::_List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>\u0020>\u0020>\u0020>.{dtor}), A_0 + 8);
				throw;
			}
		}
		catch
		{
			global::<Module>.___CxxCallUnwindDtor(ldftn(std.list<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>,std::allocator<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>.{dtor}), A_0);
			throw;
		}
		return A_0;
	}

	// Token: 0x06000028 RID: 40 RVA: 0x0000419C File Offset: 0x0000359C
	internal unsafe static global::std._List_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>* erase(global::std._Hash<std::_Umap_traits<unsigned\u0020int,ProxyConnectionHandler\u0020*,std::_Uhash_compare<unsigned\u0020int,std::hash<unsigned\u0020int>,std::equal_to<unsigned\u0020int>\u0020>,std::allocator<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>,0>\u0020>* A_0, global::std._List_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>* A_1, global::std._List_const_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020> _First, global::std._List_const_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020> _Last)
	{
		int num = *A_0;
		if (((_First == *num) ? 1 : 0) != 0 && ((_Last == num) ? 1 : 0) != 0)
		{
			global::<Module>.std.list<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>,std::allocator<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>.clear(A_0);
			global::<Module>.std._Hash<std::_Umap_traits<unsigned\u0020int,ProxyConnectionHandler\u0020*,std::_Uhash_compare<unsigned\u0020int,std::hash<unsigned\u0020int>,std::equal_to<unsigned\u0020int>\u0020>,std::allocator<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>,0>\u0020>._Init(A_0, 8U);
			*(int*)A_1 = *(*A_0);
			return A_1;
		}
		while (((((_First == _Last) ? 1 : 0) == 0) ? 1 : 0) != 0)
		{
			global::std._List_const_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020> plist = _First;
			_First = *_First;
			global::std._List_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020> list_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020>;
			global::<Module>.std._Hash<std::_Umap_traits<unsigned\u0020int,ProxyConnectionHandler\u0020*,std::_Uhash_compare<unsigned\u0020int,std::hash<unsigned\u0020int>,std::equal_to<unsigned\u0020int>\u0020>,std::allocator<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>,0>\u0020>.erase(A_0, &list_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020>, plist);
		}
		cpblk(A_1, ref _First, 4);
		return A_1;
	}

	// Token: 0x06000029 RID: 41 RVA: 0x00003084 File Offset: 0x00002484
	internal unsafe static global::std._List_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>* lower_bound(global::std._Hash<std::_Umap_traits<unsigned\u0020int,ProxyConnectionHandler\u0020*,std::_Uhash_compare<unsigned\u0020int,std::hash<unsigned\u0020int>,std::equal_to<unsigned\u0020int>\u0020>,std::allocator<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>,0>\u0020>* A_0, global::std._List_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>* A_1, uint* _Keyval)
	{
		uint num = global::<Module>.std._Hash_seq(_Keyval, 4U);
		uint num2 = (uint)(*(A_0 + 20));
		uint num3 = num2 & num;
		if (*(A_0 + 24) <= (int)num3)
		{
			num3 = uint.MaxValue - (num2 >> 1) + num3;
		}
		global::std._List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020> list_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020>;
		cpblk(ref list_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020>, num3 * 8U + (uint)(*(A_0 + 8)), 4);
		for (;;)
		{
			global::std._List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020> list_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020>2;
			global::std._List_unchecked_const_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>,std::_Iterator_base0>* ptr = global::<Module>.std._Hash<std::_Umap_traits<unsigned\u0020int,ProxyConnectionHandler\u0020*,std::_Uhash_compare<unsigned\u0020int,std::hash<unsigned\u0020int>,std::equal_to<unsigned\u0020int>\u0020>,std::allocator<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>,0>\u0020>._End(A_0, &list_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020>2, num3);
			if (((((list_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020> == *ptr) ? 1 : 0) == 0) ? 1 : 0) == 0)
			{
				goto IL_8C;
			}
			if (((((*(list_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020> + 8) == *_Keyval) ? 1 : 0) == 0) ? 1 : 0) == 0)
			{
				break;
			}
			list_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020> = *list_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020>;
		}
		global::std._List_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>* ptr2;
		if (((((*_Keyval == *(list_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020> + 8)) ? 1 : 0) == 0) ? 1 : 0) != 0)
		{
			global::std._List_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020> list_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020> = *A_0;
			ptr2 = &list_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020>;
		}
		else
		{
			global::std._List_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020> list_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020>2 = list_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020>;
			ptr2 = &list_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020>2;
		}
		cpblk(A_1, ptr2, 4);
		return A_1;
		IL_8C:
		*(int*)A_1 = *A_0;
		return A_1;
	}

	// Token: 0x0600002A RID: 42 RVA: 0x00003124 File Offset: 0x00002524
	internal unsafe static global::std.pair<std::_List_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>,std::_List_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>\u0020>* equal_range(global::std._Hash<std::_Umap_traits<unsigned\u0020int,ProxyConnectionHandler\u0020*,std::_Uhash_compare<unsigned\u0020int,std::hash<unsigned\u0020int>,std::equal_to<unsigned\u0020int>\u0020>,std::allocator<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>,0>\u0020>* A_0, global::std.pair<std::_List_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>,std::_List_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>\u0020>* A_1, uint* _Keyval)
	{
		uint num = (uint)(*(A_0 + 20));
		uint num2 = global::<Module>.std._Uhash_compare<unsigned\u0020int,std::hash<unsigned\u0020int>,std::equal_to<unsigned\u0020int>\u0020>.()(A_0, _Keyval) & num;
		if (*(A_0 + 24) <= (int)num2)
		{
			num2 = uint.MaxValue - (num >> 1) + num2;
		}
		global::std._List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020> list_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020>;
		cpblk(ref list_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020>, num2 * 8U + (uint)(*(A_0 + 8)), 4);
		for (;;)
		{
			global::std._List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020> list_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020>2;
			global::std._List_unchecked_const_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>,std::_Iterator_base0>* ptr = global::<Module>.std._Hash<std::_Umap_traits<unsigned\u0020int,ProxyConnectionHandler\u0020*,std::_Uhash_compare<unsigned\u0020int,std::hash<unsigned\u0020int>,std::equal_to<unsigned\u0020int>\u0020>,std::allocator<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>,0>\u0020>._End(A_0, &list_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020>2, num2);
			if (((((list_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020> == *ptr) ? 1 : 0) == 0) ? 1 : 0) == 0)
			{
				goto IL_B2;
			}
			if (((((*(list_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020> + 8) == *_Keyval) ? 1 : 0) == 0) ? 1 : 0) == 0)
			{
				break;
			}
			list_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020> = *list_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020>;
		}
		global::std._List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020> list_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020>3 = list_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020>;
		for (;;)
		{
			global::std._List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020> list_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020>4;
			global::std._List_unchecked_const_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>,std::_Iterator_base0>* ptr2 = global::<Module>.std._Hash<std::_Umap_traits<unsigned\u0020int,ProxyConnectionHandler\u0020*,std::_Uhash_compare<unsigned\u0020int,std::hash<unsigned\u0020int>,std::equal_to<unsigned\u0020int>\u0020>,std::allocator<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>,0>\u0020>._End(A_0, &list_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020>4, num2);
			if (((((list_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020> == *ptr2) ? 1 : 0) == 0) ? 1 : 0) == 0 || ((((*_Keyval == *(list_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020> + 8)) ? 1 : 0) == 0) ? 1 : 0) != 0)
			{
				break;
			}
			list_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020> = *list_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020>;
		}
		if (((list_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020>3 == list_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020>) ? 1 : 0) == 0)
		{
			cpblk(A_1, ref list_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020>3, 4);
			cpblk(A_1 + 4 / sizeof(global::std.pair<std::_List_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>,std::_List_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>\u0020>), ref list_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020>, 4);
			return A_1;
		}
		IL_B2:
		int num3 = *A_0;
		global::std._List_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020> list_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020> = num3;
		global::std._List_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020> list_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020>2 = num3;
		cpblk(A_1, ref list_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020>2, 4);
		cpblk(A_1 + 4 / sizeof(global::std.pair<std::_List_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>,std::_List_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>\u0020>), ref list_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020>, 4);
		return A_1;
	}

	// Token: 0x0600002B RID: 43 RVA: 0x00003618 File Offset: 0x00002A18
	internal unsafe static void {dtor}(global::std.list<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>,std::allocator<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>* A_0)
	{
		try
		{
			global::<Module>.std.list<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>,std::allocator<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>.clear(A_0);
		}
		catch
		{
			global::<Module>.___CxxCallUnwindDtor(ldftn(std._List_buy<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>,std::allocator<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>.{dtor}), A_0);
			throw;
		}
		global::<Module>.delete(*A_0);
	}

	// Token: 0x0600002C RID: 44 RVA: 0x00003914 File Offset: 0x00002D14
	internal unsafe static void {dtor}(global::std.vector<std::_List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>,std::_Wrap_alloc<std::allocator<std::_List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>\u0020>\u0020>\u0020>* A_0)
	{
		global::<Module>.std.vector<std::_List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>,std::_Wrap_alloc<std::allocator<std::_List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>\u0020>\u0020>\u0020>._Tidy(A_0);
	}

	// Token: 0x0600002D RID: 45 RVA: 0x000034AC File Offset: 0x000028AC
	internal unsafe static void {dtor}(global::std._List_buy<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>,std::allocator<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>* A_0)
	{
		global::<Module>.delete(*A_0);
	}

	// Token: 0x0600002E RID: 46 RVA: 0x000046E4 File Offset: 0x00003AE4
	internal unsafe static global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* assign(global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* A_0, sbyte* _Ptr, uint _Count)
	{
		if (_Ptr != null)
		{
			uint num = (uint)(*(A_0 + 20));
			sbyte* ptr;
			if (16U <= num)
			{
				ptr = *A_0;
			}
			else
			{
				ptr = A_0;
			}
			if (_Ptr >= (sbyte*)ptr)
			{
				sbyte* ptr2;
				if (16U <= num)
				{
					ptr2 = *A_0;
				}
				else
				{
					ptr2 = A_0;
				}
				if (*(A_0 + 16) / sizeof(sbyte) + ptr2 != (sbyte*)_Ptr)
				{
					sbyte* ptr3;
					if (16U <= num)
					{
						ptr3 = *A_0;
					}
					else
					{
						ptr3 = A_0;
					}
					return global::<Module>.std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>.assign(A_0, A_0, (uint)(_Ptr - ptr3), _Count);
				}
			}
		}
		if (global::<Module>.std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>._Grow(A_0, _Count, false) != null)
		{
			sbyte* ptr4;
			if (16 <= *(A_0 + 20))
			{
				ptr4 = *A_0;
			}
			else
			{
				ptr4 = A_0;
			}
			if (_Count != 0U)
			{
				cpblk(ptr4, _Ptr, _Count);
			}
			*(A_0 + 16) = (int)_Count;
			*(((16 > *(A_0 + 20)) ? A_0 : (*A_0)) + _Count) = 0;
		}
		return A_0;
	}

	// Token: 0x0600002F RID: 47 RVA: 0x00002BE8 File Offset: 0x00001FE8
	internal unsafe static global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* erase(global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* A_0, uint _Off, uint _Count)
	{
		uint num = (uint)(*(A_0 + 16));
		if (num < _Off)
		{
			global::<Module>.std._Xout_of_range((sbyte*)(&global::<Module>.??_C@_0BI@CFPLBAOH@invalid?5string?5position?$AA@));
		}
		if (num - _Off <= _Count)
		{
			*(A_0 + 16) = (int)_Off;
			*(((16 > *(A_0 + 20)) ? A_0 : (*A_0)) + _Off) = 0;
		}
		else if (0U < _Count)
		{
			sbyte* ptr = ((16 > *(A_0 + 20)) ? A_0 : (*A_0)) + _Off / (uint)sizeof(sbyte);
			uint num2 = num - _Count;
			uint num3 = num2 - _Off;
			if (num3 != 0U)
			{
				sbyte* ptr2 = ptr;
				global::<Module>.memmove((void*)ptr2, (void*)(ptr2 + _Count / (uint)sizeof(sbyte)), num3);
			}
			*(A_0 + 16) = (int)num2;
			*(((16 > *(A_0 + 20)) ? A_0 : (*A_0)) + num2) = 0;
		}
		return A_0;
	}

	// Token: 0x06000030 RID: 48 RVA: 0x00003200 File Offset: 0x00002600
	[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
	internal unsafe static bool _Grow(global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* A_0, uint _Newsize, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)] bool _Trim)
	{
		if (4294967294U < _Newsize)
		{
			global::<Module>.std._Xlength_error((sbyte*)(&global::<Module>.??_C@_0BA@JFNIOLAK@string?5too?5long?$AA@));
		}
		uint num = (uint)(*(A_0 + 20));
		if (num < _Newsize)
		{
			global::<Module>.std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>._Copy(A_0, _Newsize, (uint)(*(A_0 + 16)));
		}
		else if (_Trim && _Newsize < 16U)
		{
			uint num2 = (uint)(*(A_0 + 16));
			uint newsize = (_Newsize < num2) ? _Newsize : num2;
			global::<Module>.std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>._Tidy(A_0, true, newsize);
		}
		else if (_Newsize == 0U)
		{
			*(A_0 + 16) = 0;
			*((16U > num) ? A_0 : (*A_0)) = 0;
			goto IL_67;
		}
		int num3;
		if (0U < _Newsize)
		{
			num3 = 1;
			goto IL_69;
		}
		IL_67:
		num3 = 0;
		IL_69:
		return (byte)num3;
	}

	// Token: 0x06000031 RID: 49 RVA: 0x000034C0 File Offset: 0x000028C0
	internal unsafe static global::std._List_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>* erase(global::std._Hash<std::_Umap_traits<unsigned\u0020int,ProxyConnectionHandler\u0020*,std::_Uhash_compare<unsigned\u0020int,std::hash<unsigned\u0020int>,std::equal_to<unsigned\u0020int>\u0020>,std::allocator<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>,0>\u0020>* A_0, global::std._List_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>* A_1, global::std._List_const_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020> _Plist)
	{
		global::std.pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>* keyval = _Plist + 8;
		uint bucket = global::<Module>.std._Hash<std::_Umap_traits<unsigned\u0020int,ProxyConnectionHandler\u0020*,std::_Uhash_compare<unsigned\u0020int,std::hash<unsigned\u0020int>,std::equal_to<unsigned\u0020int>\u0020>,std::allocator<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>,0>\u0020>._Hashval(A_0, keyval);
		global::std._List_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020> plist_arg = _Plist;
		global::<Module>.std._Hash<std::_Umap_traits<unsigned\u0020int,ProxyConnectionHandler\u0020*,std::_Uhash_compare<unsigned\u0020int,std::hash<unsigned\u0020int>,std::equal_to<unsigned\u0020int>\u0020>,std::allocator<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>,0>\u0020>._Erase_bucket(A_0, plist_arg, bucket);
		global::std._List_const_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020> where = _Plist;
		global::std._List_const_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020> list_const_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020> = *_Plist;
		global::<Module>.delete(global::<Module>.std.list<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>,std::allocator<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>._Unlinknode(A_0, where));
		cpblk(A_1, ref list_const_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020>, 4);
		return A_1;
	}

	// Token: 0x06000032 RID: 50 RVA: 0x00002C70 File Offset: 0x00002070
	internal unsafe static global::std._List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>* _End(global::std._Hash<std::_Umap_traits<unsigned\u0020int,ProxyConnectionHandler\u0020*,std::_Uhash_compare<unsigned\u0020int,std::hash<unsigned\u0020int>,std::equal_to<unsigned\u0020int>\u0020>,std::allocator<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>,0>\u0020>* A_0, global::std._List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>* A_1, uint _Bucket)
	{
		int num = (int)(_Bucket * 8U + (uint)(*(A_0 + 8)));
		uint num2 = (uint)(*A_0);
		if (((*num == (int)num2) ? 1 : 0) != 0)
		{
			*(int*)A_1 = (int)num2;
			return A_1;
		}
		global::std._List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020> list_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020>;
		cpblk(ref list_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020>, num + 4, 4);
		list_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020> = *list_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020>;
		cpblk(A_1, ref list_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020>, 4);
		return A_1;
	}

	// Token: 0x06000033 RID: 51 RVA: 0x00002A10 File Offset: 0x00001E10
	internal unsafe static uint _Hashval(global::std._Hash<std::_Umap_traits<unsigned\u0020int,ProxyConnectionHandler\u0020*,std::_Uhash_compare<unsigned\u0020int,std::hash<unsigned\u0020int>,std::equal_to<unsigned\u0020int>\u0020>,std::allocator<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>,0>\u0020>* A_0, uint* _Keyval)
	{
		uint num = (((((uint)(*_Keyval) ^ 2166136261U) * 16777619U ^ (uint)(*(_Keyval + 1))) * 16777619U ^ (uint)(*(_Keyval + 2))) * 16777619U ^ (uint)(*(_Keyval + 3))) * 16777619U;
		uint num2 = (uint)(*(A_0 + 20));
		uint num3 = num2 & num;
		if (*(A_0 + 24) <= (int)num3)
		{
			num3 = uint.MaxValue - (num2 >> 1) + num3;
		}
		return num3;
	}

	// Token: 0x06000034 RID: 52 RVA: 0x00003E00 File Offset: 0x00003200
	internal unsafe static void _Init(global::std._Hash<std::_Umap_traits<unsigned\u0020int,ProxyConnectionHandler\u0020*,std::_Uhash_compare<unsigned\u0020int,std::hash<unsigned\u0020int>,std::equal_to<unsigned\u0020int>\u0020>,std::allocator<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>,0>\u0020>* A_0, uint _Buckets)
	{
		global::std._List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020> list_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020> = *A_0;
		global::std.vector<std::_List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>,std::_Wrap_alloc<std::allocator<std::_List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>\u0020>\u0020>\u0020>* ptr = A_0 + 8;
		global::<Module>.std.vector<std::_List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>,std::_Wrap_alloc<std::allocator<std::_List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>\u0020>\u0020>\u0020>.clear(ptr);
		global::std._Vector_const_iterator<std::_Vector_val<std::_Simple_types<std::_List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>\u0020>\u0020>\u0020> where = *ptr;
		global::std._Vector_iterator<std::_Vector_val<std::_Simple_types<std::_List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>\u0020>\u0020>\u0020> vector_iterator<std::_Vector_val<std::_Simple_types<std::_List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020>_u0020>_u0020>_u0020>;
		global::<Module>.std.vector<std::_List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>,std::_Wrap_alloc<std::allocator<std::_List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>\u0020>\u0020>\u0020>._Insert_n(ptr, &vector_iterator<std::_Vector_val<std::_Simple_types<std::_List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020>_u0020>_u0020>_u0020>, where, _Buckets << 1, ref list_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020>);
		*(A_0 + 20) = (int)(_Buckets - 1U);
		*(A_0 + 24) = (int)_Buckets;
	}

	// Token: 0x06000035 RID: 53 RVA: 0x000038E8 File Offset: 0x00002CE8
	internal unsafe static void _Tidy(global::std.vector<std::_List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>,std::_Wrap_alloc<std::allocator<std::_List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>\u0020>\u0020>\u0020>* A_0)
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

	// Token: 0x06000036 RID: 54 RVA: 0x00002CAC File Offset: 0x000020AC
	internal unsafe static void _Copy(global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* A_0, uint _Newsize, uint _Oldlen)
	{
		uint num = global::<Module>.__CxxQueryExceptionSize();
		int num2 = (int)stackalloc byte[num << 1];
		uint num3 = _Newsize | 15U;
		if (4294967294U < num3)
		{
			num3 = _Newsize;
		}
		else
		{
			uint num4 = (uint)(*(A_0 + 20));
			uint num5 = num4 >> 1;
			if (num5 > num3 / 3U)
			{
				if (num4 <= 4294967294U - num5)
				{
					num3 = num5 + num4;
				}
				else
				{
					num3 = 4294967294U;
				}
			}
		}
		sbyte* ptr2;
		uint exceptionCode;
		try
		{
			int num6 = (int)(num + (uint)num2);
			uint num7 = num3 + 1U;
			void* ptr = null;
			if (num7 != 0U)
			{
				if (4294967295U >= num7)
				{
					ptr = global::<Module>.@new(num7);
					if (ptr != null)
					{
						goto IL_68;
					}
				}
				global::<Module>.std._Xbad_alloc();
				goto IL_165;
			}
			IL_68:
			ptr2 = (sbyte*)ptr;
		}
		catch when (delegate
		{
			// Failed to create a 'catch-when' expression
			exceptionCode = (uint)global::System.Runtime.InteropServices.Marshal.GetExceptionCode();
			endfilter(global::<Module>.__CxxExceptionFilter(global::System.Runtime.InteropServices.Marshal.GetExceptionPointers(), null, 0, null) != null);
		})
		{
			uint num8 = 0U;
			int num6;
			global::<Module>.__CxxRegisterExceptionObject(global::System.Runtime.InteropServices.Marshal.GetExceptionPointers(), num6);
			try
			{
				try
				{
					num3 = _Newsize;
					uint exceptionCode2;
					try
					{
						uint num9 = _Newsize + 1U;
						void* ptr3 = null;
						if (num9 != 0U)
						{
							if (4294967295U >= num9)
							{
								ptr3 = global::<Module>.@new(num9);
								if (ptr3 != null)
								{
									goto IL_CA;
								}
							}
							global::<Module>.std._Xbad_alloc();
							goto IL_13B;
						}
						IL_CA:
						ptr2 = (sbyte*)ptr3;
					}
					catch when (delegate
					{
						// Failed to create a 'catch-when' expression
						exceptionCode2 = (uint)global::System.Runtime.InteropServices.Marshal.GetExceptionCode();
						endfilter(global::<Module>.__CxxExceptionFilter(global::System.Runtime.InteropServices.Marshal.GetExceptionPointers(), null, 0, null) != null);
					})
					{
						uint num10 = 0U;
						global::<Module>.__CxxRegisterExceptionObject(global::System.Runtime.InteropServices.Marshal.GetExceptionPointers(), num2);
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
								num10 = global::<Module>.__CxxDetectRethrow(global::System.Runtime.InteropServices.Marshal.GetExceptionPointers());
								endfilter(num10 != 0U);
							})
							{
							}
							if (num10 != 0U)
							{
								throw;
							}
						}
						finally
						{
							global::<Module>.__CxxUnregisterExceptionObject(num2, (int)num10);
						}
					}
					IL_13B:
					goto IL_165;
				}
				catch when (delegate
				{
					// Failed to create a 'catch-when' expression
					num8 = global::<Module>.__CxxDetectRethrow(global::System.Runtime.InteropServices.Marshal.GetExceptionPointers());
					endfilter(num8 != 0U);
				})
				{
				}
				if (num8 != 0U)
				{
					throw;
				}
			}
			finally
			{
				global::<Module>.__CxxUnregisterExceptionObject(num6, (int)num8);
			}
		}
		IL_165:
		if (0U < _Oldlen)
		{
			sbyte* ptr4;
			if (16 <= *(A_0 + 20))
			{
				ptr4 = *A_0;
			}
			else
			{
				ptr4 = A_0;
			}
			if (_Oldlen != 0U)
			{
				cpblk(ptr2, ptr4, _Oldlen);
			}
		}
		global::<Module>.std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>._Tidy(A_0, true, 0U);
		try
		{
			if (A_0 != null)
			{
				*A_0 = ptr2;
			}
		}
		catch
		{
			global::<Module>.delete(A_0, A_0);
			throw;
		}
		*(A_0 + 20) = (int)num3;
		*(A_0 + 16) = (int)_Oldlen;
		*(((16U > num3) ? A_0 : (*A_0)) + _Oldlen) = 0;
	}

	// Token: 0x06000037 RID: 55 RVA: 0x00002A68 File Offset: 0x00001E68
	internal unsafe static void _Erase_bucket(global::std._Hash<std::_Umap_traits<unsigned\u0020int,ProxyConnectionHandler\u0020*,std::_Uhash_compare<unsigned\u0020int,std::hash<unsigned\u0020int>,std::equal_to<unsigned\u0020int>\u0020>,std::allocator<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>,0>\u0020>* A_0, global::std._List_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020> _Plist_arg, uint _Bucket)
	{
		int num = (int)(_Bucket * 8U);
		int num2 = *(A_0 + 8) + num;
		if (((*(num2 + 4) == _Plist_arg) ? 1 : 0) != 0)
		{
			if (((*num2 == _Plist_arg) ? 1 : 0) != 0)
			{
				global::std._List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020> list_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020> = *A_0;
				cpblk(num2, ref list_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020>, 4);
				global::std._List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020> list_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020>2 = *A_0;
				cpblk(*(A_0 + 8) + num + 4, ref list_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020>2, 4);
			}
			else
			{
				global::std._List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020> list_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020>3 = *(_Plist_arg + 4);
				cpblk(num2 + 4, ref list_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020>3, 4);
			}
		}
		else if (((*num2 == _Plist_arg) ? 1 : 0) != 0)
		{
			global::std._List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020> list_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020>3 = *_Plist_arg;
			cpblk(num2, ref list_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020>3, 4);
		}
	}

	// Token: 0x06000038 RID: 56 RVA: 0x0000295C File Offset: 0x00001D5C
	internal unsafe static uint ()(global::std._Uhash_compare<unsigned\u0020int,std::hash<unsigned\u0020int>,std::equal_to<unsigned\u0020int>\u0020>* A_0, uint* _Keyval)
	{
		return (((((int)(*_Keyval) ^ -2128831035) * 16777619 ^ (int)(*(_Keyval + 1))) * 16777619 ^ (int)(*(_Keyval + 2))) * 16777619 ^ (int)(*(_Keyval + 3))) * 16777619;
	}

	// Token: 0x06000039 RID: 57 RVA: 0x00003278 File Offset: 0x00002678
	internal unsafe static void clear(global::std.list<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>,std::allocator<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>* A_0)
	{
		int num = *A_0;
		global::std._List_node<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>,void\u0020*>* ptr = *num;
		int num2 = num;
		*num2 = num2;
		int num3 = *A_0;
		*(num3 + 4) = num3;
		*(A_0 + 4) = 0;
		if (ptr != *A_0)
		{
			global::std._List_node<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>,void\u0020*>* ptr2;
			do
			{
				ptr2 = *(int*)ptr;
				global::<Module>.delete((void*)ptr);
				ptr = ptr2;
			}
			while (ptr2 != *A_0);
		}
	}

	// Token: 0x0600003A RID: 58 RVA: 0x00002998 File Offset: 0x00001D98
	internal unsafe static global::std._List_node<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>,void\u0020*>* _Unlinknode(global::std.list<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>,std::allocator<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>* A_0, global::std._List_const_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020> _Where)
	{
		global::std._List_node<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>,void\u0020*>* ptr = _Where;
		int num = _Where + 4;
		*(*num) = *_Where;
		*(*(int*)ptr + 4) = *num;
		*(A_0 + 4) = *(A_0 + 4) + -1;
		return ptr;
	}

	// Token: 0x0600003B RID: 59 RVA: 0x000038CC File Offset: 0x00002CCC
	internal unsafe static void clear(global::std.vector<std::_List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>,std::_Wrap_alloc<std::allocator<std::_List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>\u0020>\u0020>\u0020>* A_0)
	{
		global::<Module>.std._Container_base0._Orphan_all(A_0);
		*(A_0 + 4) = *A_0;
	}

	// Token: 0x0600003C RID: 60 RVA: 0x00001B6C File Offset: 0x00000F6C
	internal unsafe static global::std._List_unchecked_const_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>,std::_Iterator_base0>* {ctor}(global::std._List_unchecked_const_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>,std::_Iterator_base0>* A_0, global::std._List_node<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>,void\u0020*>* _Pnode, global::std._List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>* _Plist)
	{
		*A_0 = _Pnode;
		return A_0;
	}

	// Token: 0x0600003D RID: 61 RVA: 0x00003928 File Offset: 0x00002D28
	internal unsafe static global::std._Vector_iterator<std::_Vector_val<std::_Simple_types<std::_List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>\u0020>\u0020>\u0020>* _Insert_n(global::std.vector<std::_List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>,std::_Wrap_alloc<std::allocator<std::_List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>\u0020>\u0020>\u0020>* A_0, global::std._Vector_iterator<std::_Vector_val<std::_Simple_types<std::_List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>\u0020>\u0020>\u0020>* A_1, global::std._Vector_const_iterator<std::_Vector_val<std::_Simple_types<std::_List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>\u0020>\u0020>\u0020> _Where, uint _Count, global::std._List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>* _Val)
	{
		int num = (int)stackalloc byte[global::<Module>.__CxxQueryExceptionSize()];
		int num2 = *A_0;
		uint num3 = _Where - num2 >> 2;
		if (_Count != 0U)
		{
			int num4 = *(A_0 + 8);
			int num5 = *(A_0 + 4);
			if (num4 - num5 >> 2 < (int)_Count)
			{
				int num6 = num5 - num2 >> 2;
				if (1073741823 - num6 < (int)_Count)
				{
					global::<Module>.std._Xlength_error((sbyte*)(&global::<Module>.??_C@_0BD@OLBABOEK@vector?$DMT?$DO?5too?5long?$AA@));
				}
				uint num7 = (uint)(num6 + (int)_Count);
				uint num8 = (uint)(num4 - num2 >> 2);
				uint num9 = num8 >> 1;
				uint num10;
				if (1073741823U - num9 < num8)
				{
					num10 = 0U;
				}
				else
				{
					num10 = num9 + num8;
				}
				uint num11 = num10;
				num11 = ((num10 < num7) ? num7 : num11);
				uint num12 = num11;
				void* ptr = null;
				if (num11 != 0U)
				{
					if (1073741823U >= num11)
					{
						ptr = global::<Module>.@new(num11 << 2);
						if (ptr != null)
						{
							goto IL_B6;
						}
					}
					global::<Module>.std._Xbad_alloc();
					goto IL_1FF;
				}
				IL_B6:
				global::std._List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>* ptr2 = (global::std._List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>*)ptr;
				uint num13 = _Where - *A_0 >> 2;
				int num14 = 0;
				uint exceptionCode;
				try
				{
					global::std._List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>* first = (global::std._List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>*)(num13 * 4U + (byte*)ptr);
					global::std._Nonscalar_ptr_iterator_tag nonscalar_ptr_iterator_tag;
					global::std._Nonscalar_ptr_iterator_tag _unnamed = nonscalar_ptr_iterator_tag;
					global::std._Wrap_alloc<std::_Wrap_alloc<std::allocator<std::_List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>\u0020>\u0020>\u0020> wrap_alloc<std::_Wrap_alloc<std::allocator<std::_List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020>_u0020>_u0020>_u0020>;
					global::<Module>.std._Uninit_fill_n<class\u0020std::_List_unchecked_iterator<class\u0020std::_List_val<struct\u0020std::_List_simple_types<struct\u0020std::pair<unsigned\u0020int\u0020const\u0020,struct\u0020ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>\u0020*,unsigned\u0020int,class\u0020std::_List_unchecked_iterator<class\u0020std::_List_val<struct\u0020std::_List_simple_types<struct\u0020std::pair<unsigned\u0020int\u0020const\u0020,struct\u0020ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>,struct\u0020std::_Wr(first, _Count, _Val, ref wrap_alloc<std::_Wrap_alloc<std::allocator<std::_List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020>_u0020>_u0020>_u0020>, null, _unnamed);
					num14 = 1;
					global::std._Wrap_alloc<std::_Wrap_alloc<std::allocator<std::_List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>\u0020>\u0020>\u0020> wrap_alloc<std::_Wrap_alloc<std::allocator<std::_List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020>_u0020>_u0020>_u0020>2;
					global::std._List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>* ptr3 = global::<Module>.std._Uninit_move<class\u0020std::_List_unchecked_iterator<class\u0020std::_List_val<struct\u0020std::_List_simple_types<struct\u0020std::pair<unsigned\u0020int\u0020const\u0020,struct\u0020ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>\u0020*,class\u0020std::_List_unchecked_iterator<class\u0020std::_List_val<struct\u0020std::_List_simple_types<struct\u0020std::pair<unsigned\u0020int\u0020const\u0020,struct\u0020ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>\u0020*,struct\u0020std::_Wrap_alloc<stru(*A_0, _Where, (global::std._List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>*)ptr, ref wrap_alloc<std::_Wrap_alloc<std::allocator<std::_List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020>_u0020>_u0020>_u0020>2);
					num14 = 2;
					global::std._List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>* last = *(A_0 + 4);
					global::std._List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>* dest = (global::std._List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>*)((num13 + _Count) * 4U + (byte*)ptr);
					global::std._Wrap_alloc<std::_Wrap_alloc<std::allocator<std::_List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>\u0020>\u0020>\u0020> wrap_alloc<std::_Wrap_alloc<std::allocator<std::_List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020>_u0020>_u0020>_u0020>3;
					dest = global::<Module>.std._Uninit_move<class\u0020std::_List_unchecked_iterator<class\u0020std::_List_val<struct\u0020std::_List_simple_types<struct\u0020std::pair<unsigned\u0020int\u0020const\u0020,struct\u0020ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>\u0020*,class\u0020std::_List_unchecked_iterator<class\u0020std::_List_val<struct\u0020std::_List_simple_types<struct\u0020std::pair<unsigned\u0020int\u0020const\u0020,struct\u0020ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>\u0020*,struct\u0020std::_Wrap_alloc<stru(_Where, last, dest, ref wrap_alloc<std::_Wrap_alloc<std::allocator<std::_List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020>_u0020>_u0020>_u0020>3);
				}
				catch when (delegate
				{
					// Failed to create a 'catch-when' expression
					exceptionCode = (uint)global::System.Runtime.InteropServices.Marshal.GetExceptionCode();
					endfilter(global::<Module>.__CxxExceptionFilter(global::System.Runtime.InteropServices.Marshal.GetExceptionPointers(), null, 0, null) != null);
				})
				{
					uint num15 = 0U;
					global::<Module>.__CxxRegisterExceptionObject(global::System.Runtime.InteropServices.Marshal.GetExceptionPointers(), num);
					try
					{
						try
						{
							if (1 < num14)
							{
								for (global::std._List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>* ptr4 = (global::std._List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>*)ptr; ptr4 != num13 * 4U / (uint)sizeof(global::std._List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>) + ptr2; ptr4 += 4 / sizeof(global::std._List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>))
								{
								}
							}
							if (0 < num14)
							{
								for (global::std._List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>* ptr5 = num13 * 4U / (uint)sizeof(global::std._List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>) + ptr2; ptr5 != (num13 + _Count) * 4U / (uint)sizeof(global::std._List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>) + ptr2; ptr5 += 4 / sizeof(global::std._List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>))
								{
								}
							}
							global::<Module>.delete((void*)ptr2);
							global::<Module>._CxxThrowException(null, null);
						}
						catch when (delegate
						{
							// Failed to create a 'catch-when' expression
							num15 = global::<Module>.__CxxDetectRethrow(global::System.Runtime.InteropServices.Marshal.GetExceptionPointers());
							endfilter(num15 != 0U);
						})
						{
						}
						if (num15 != 0U)
						{
							throw;
						}
					}
					finally
					{
						global::<Module>.__CxxUnregisterExceptionObject(num, (int)num15);
					}
				}
				num2 = *A_0;
				_Count = (uint)((*(A_0 + 4) - num2 >> 2) + (int)_Count);
				if (num2 != 0)
				{
					global::<Module>.delete(num2);
				}
				global::<Module>.std._Container_base0._Orphan_all(A_0);
				*(A_0 + 8) = num12 * 4U / (uint)sizeof(global::std._List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>) + ptr2;
				*(A_0 + 4) = _Count * 4U / (uint)sizeof(global::std._List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>) + ptr2;
				*A_0 = ptr2;
				goto IL_39A;
			}
			IL_1FF:
			if (num5 - _Where >> 2 < _Count)
			{
				global::std._List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020> list_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020>;
				cpblk(ref list_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020>, _Val, 4);
				global::std._List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>* last2 = num5;
				global::std._List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>* dest2 = _Count * 4U + _Where;
				global::std._Wrap_alloc<std::_Wrap_alloc<std::allocator<std::_List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>\u0020>\u0020>\u0020> wrap_alloc<std::_Wrap_alloc<std::allocator<std::_List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020>_u0020>_u0020>_u0020>4;
				global::<Module>.std._Uninit_move<class\u0020std::_List_unchecked_iterator<class\u0020std::_List_val<struct\u0020std::_List_simple_types<struct\u0020std::pair<unsigned\u0020int\u0020const\u0020,struct\u0020ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>\u0020*,class\u0020std::_List_unchecked_iterator<class\u0020std::_List_val<struct\u0020std::_List_simple_types<struct\u0020std::pair<unsigned\u0020int\u0020const\u0020,struct\u0020ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>\u0020*,struct\u0020std::_Wrap_alloc<stru(_Where, last2, dest2, ref wrap_alloc<std::_Wrap_alloc<std::allocator<std::_List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020>_u0020>_u0020>_u0020>4);
				uint exceptionCode;
				try
				{
					num5 = *(A_0 + 4);
					uint count = _Count - (num5 - _Where >> 2);
					global::std._List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>* first2 = num5;
					global::std._Nonscalar_ptr_iterator_tag nonscalar_ptr_iterator_tag2;
					global::std._Nonscalar_ptr_iterator_tag _unnamed2 = nonscalar_ptr_iterator_tag2;
					global::std._Wrap_alloc<std::_Wrap_alloc<std::allocator<std::_List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>\u0020>\u0020>\u0020> wrap_alloc<std::_Wrap_alloc<std::allocator<std::_List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020>_u0020>_u0020>_u0020>5;
					global::<Module>.std._Uninit_fill_n<class\u0020std::_List_unchecked_iterator<class\u0020std::_List_val<struct\u0020std::_List_simple_types<struct\u0020std::pair<unsigned\u0020int\u0020const\u0020,struct\u0020ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>\u0020*,unsigned\u0020int,class\u0020std::_List_unchecked_iterator<class\u0020std::_List_val<struct\u0020std::_List_simple_types<struct\u0020std::pair<unsigned\u0020int\u0020const\u0020,struct\u0020ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>,struct\u0020std::_Wr(first2, count, (global::std._List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>*)(&list_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020>), ref wrap_alloc<std::_Wrap_alloc<std::allocator<std::_List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020>_u0020>_u0020>_u0020>5, null, _unnamed2);
				}
				catch when (delegate
				{
					// Failed to create a 'catch-when' expression
					exceptionCode = (uint)global::System.Runtime.InteropServices.Marshal.GetExceptionCode();
					endfilter(global::<Module>.__CxxExceptionFilter(global::System.Runtime.InteropServices.Marshal.GetExceptionPointers(), null, 0, null) != null);
				})
				{
					uint num15 = 0U;
					global::<Module>.__CxxRegisterExceptionObject(global::System.Runtime.InteropServices.Marshal.GetExceptionPointers(), num);
					try
					{
						try
						{
							int num16 = (int)(_Count * 4U);
							global::std._List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>* ptr6 = *(A_0 + 4) + num16;
							for (global::std._List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>* ptr7 = num16 + _Where; ptr7 != ptr6; ptr7 += 4 / sizeof(global::std._List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>))
							{
							}
							global::<Module>._CxxThrowException(null, null);
						}
						catch when (delegate
						{
							// Failed to create a 'catch-when' expression
							num15 = global::<Module>.__CxxDetectRethrow(global::System.Runtime.InteropServices.Marshal.GetExceptionPointers());
							endfilter(num15 != 0U);
						})
						{
						}
						if (num15 != 0U)
						{
							throw;
						}
					}
					finally
					{
						global::<Module>.__CxxUnregisterExceptionObject(num, (int)num15);
					}
				}
				int num17 = (int)(_Count * 4U);
				*(A_0 + 4) = *(A_0 + 4) + num17;
				global::std._List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>* ptr8 = *(A_0 + 4) - num17;
				global::std._List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>* ptr9 = _Where;
				if (_Where != ptr8)
				{
					do
					{
						cpblk(ptr9, ref list_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020>, 4);
						ptr9 += 4 / sizeof(global::std._List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>);
					}
					while (ptr9 != ptr8);
				}
			}
			else
			{
				global::std._List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020> list_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020>2;
				cpblk(ref list_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020>2, _Val, 4);
				global::std._List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>* ptr10 = num5;
				global::std._List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>* dest3 = num5;
				global::std._Nonscalar_ptr_iterator_tag nonscalar_ptr_iterator_tag3;
				global::std._Nonscalar_ptr_iterator_tag _unnamed3 = nonscalar_ptr_iterator_tag3;
				int num18 = (int)(_Count * 4U);
				global::std._List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>* ptr11 = ptr10 - num18 / sizeof(global::std._List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>);
				global::std._Wrap_alloc<std::_Wrap_alloc<std::allocator<std::_List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>\u0020>\u0020>\u0020> wrap_alloc<std::_Wrap_alloc<std::allocator<std::_List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020>_u0020>_u0020>_u0020>6;
				*(A_0 + 4) = global::<Module>.std._Uninit_move<class\u0020std::_List_unchecked_iterator<class\u0020std::_List_val<struct\u0020std::_List_simple_types<struct\u0020std::pair<unsigned\u0020int\u0020const\u0020,struct\u0020ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>\u0020*,class\u0020std::_List_unchecked_iterator<class\u0020std::_List_val<struct\u0020std::_List_simple_types<struct\u0020std::pair<unsigned\u0020int\u0020const\u0020,struct\u0020ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>\u0020*,struct\u0020std::_Wrap_alloc<clas(ptr11, ptr10, dest3, ref wrap_alloc<std::_Wrap_alloc<std::allocator<std::_List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020>_u0020>_u0020>_u0020>6, null, _unnamed3);
				global::std._List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>* ptr12 = ptr11;
				if (_Where != ptr12)
				{
					global::std._List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>* ptr13 = ptr12 + num18 / sizeof(global::std._List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>);
					do
					{
						ptr12 -= 4 / sizeof(global::std._List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>);
						ptr13 -= 4 / sizeof(global::std._List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>);
						cpblk(ptr13, ptr12, 4);
					}
					while (_Where != ptr12);
				}
				global::std._List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>* ptr14 = _Where;
				if (_Where != num18 + _Where)
				{
					do
					{
						cpblk(ptr14, ref list_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020>2, 4);
						ptr14 += 4 / sizeof(global::std._List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>);
					}
					while (ptr14 != num18 + _Where);
				}
			}
		}
		IL_39A:
		global::std._Vector_iterator<std::_Vector_val<std::_Simple_types<std::_List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>\u0020>\u0020>\u0020> vector_iterator<std::_Vector_val<std::_Simple_types<std::_List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020>_u0020>_u0020>_u0020> = *A_0;
		global::std._Vector_iterator<std::_Vector_val<std::_Simple_types<std::_List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>\u0020>\u0020>\u0020> vector_iterator<std::_Vector_val<std::_Simple_types<std::_List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020>_u0020>_u0020>_u0020>2 = num3 * 4U + vector_iterator<std::_Vector_val<std::_Simple_types<std::_List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020>_u0020>_u0020>_u0020>;
		cpblk(A_1, ref vector_iterator<std::_Vector_val<std::_Simple_types<std::_List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020>_u0020>_u0020>_u0020>2, 4);
		return A_1;
	}

	// Token: 0x0600003E RID: 62 RVA: 0x00002F24 File Offset: 0x00002324
	internal unsafe static global::std._List_node<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>,void\u0020*>* _Buynode0(global::std._List_alloc<0,std::_List_base_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>,std::allocator<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>* A_0, global::std._List_node<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>,void\u0020*>* _Next, global::std._List_node<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>,void\u0020*>* _Prev)
	{
		int num = (int)stackalloc byte[global::<Module>.__CxxQueryExceptionSize()];
		void* ptr = global::<Module>.@new(16U);
		if (ptr == null)
		{
			global::<Module>.std._Xbad_alloc();
		}
		global::std._List_node<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>,void\u0020*>* a_ = (global::std._List_node<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>,void\u0020*>*)ptr;
		if (_Next == null)
		{
			_Next = (global::std._List_node<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>,void\u0020*>*)ptr;
			_Prev = (global::std._List_node<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>,void\u0020*>*)ptr;
		}
		uint exceptionCode;
		try
		{
			global::std._List_node<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>,void\u0020*>** a_2 = (global::std._List_node<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>,void\u0020*>**)ptr;
			try
			{
				*(int*)ptr = _Next;
			}
			catch
			{
				global::<Module>.delete((void*)a_2, (void*)a_);
				throw;
			}
			global::std._List_node<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>,void\u0020*>** ptr2 = (global::std._List_node<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>,void\u0020*>**)((byte*)ptr + 4);
			global::std._List_node<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>,void\u0020*>** a_3 = ptr2;
			try
			{
				if (ptr2 != null)
				{
					*(int*)ptr2 = _Prev;
				}
			}
			catch
			{
				global::<Module>.delete((void*)a_3, (void*)ptr2);
				throw;
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
		return ptr;
	}

	// Token: 0x0600003F RID: 63 RVA: 0x00001000 File Offset: 0x00000400
	internal unsafe static void ??__E?_Generic_object@?$_Error_objects@H@std@@2V_Generic_error_category@2@A@@YMXXZ()
	{
		try
		{
			global::<Module>.?_Generic_object@?$_Error_objects@H@std@@2V_Generic_error_category@2@A = ref global::<Module>.??_7_Generic_error_category@std@@6B@;
		}
		catch
		{
			global::<Module>.___CxxCallUnwindDtor(ldftn(std.error_category.{dtor}), (void*)(&global::<Module>.?_Generic_object@?$_Error_objects@H@std@@2V_Generic_error_category@2@A));
			throw;
		}
		global::<Module>._atexit_m(ldftn(?A0x174d99bf.??__F?_Generic_object@?$_Error_objects@H@std@@2V_Generic_error_category@2@A@@YMXXZ));
	}

	// Token: 0x06000040 RID: 64 RVA: 0x00001054 File Offset: 0x00000454
	internal unsafe static void ??__E?_Iostream_object@?$_Error_objects@H@std@@2V_Iostream_error_category@2@A@@YMXXZ()
	{
		try
		{
			global::<Module>.?_Iostream_object@?$_Error_objects@H@std@@2V_Iostream_error_category@2@A = ref global::<Module>.??_7_Generic_error_category@std@@6B@;
		}
		catch
		{
			global::<Module>.___CxxCallUnwindDtor(ldftn(std.error_category.{dtor}), (void*)(&global::<Module>.?_Iostream_object@?$_Error_objects@H@std@@2V_Iostream_error_category@2@A));
			throw;
		}
		try
		{
			global::<Module>.?_Iostream_object@?$_Error_objects@H@std@@2V_Iostream_error_category@2@A = ref global::<Module>.??_7_Iostream_error_category@std@@6B@;
		}
		catch
		{
			global::<Module>.___CxxCallUnwindDtor(ldftn(std._Generic_error_category.{dtor}), (void*)(&global::<Module>.?_Iostream_object@?$_Error_objects@H@std@@2V_Iostream_error_category@2@A));
			throw;
		}
		global::<Module>._atexit_m(ldftn(?A0x174d99bf.??__F?_Iostream_object@?$_Error_objects@H@std@@2V_Iostream_error_category@2@A@@YMXXZ));
	}

	// Token: 0x06000041 RID: 65 RVA: 0x000010E0 File Offset: 0x000004E0
	internal unsafe static void ??__E?_System_object@?$_Error_objects@H@std@@2V_System_error_category@2@A@@YMXXZ()
	{
		try
		{
			global::<Module>.?_System_object@?$_Error_objects@H@std@@2V_System_error_category@2@A = ref global::<Module>.??_7_Generic_error_category@std@@6B@;
		}
		catch
		{
			global::<Module>.___CxxCallUnwindDtor(ldftn(std.error_category.{dtor}), (void*)(&global::<Module>.?_System_object@?$_Error_objects@H@std@@2V_System_error_category@2@A));
			throw;
		}
		try
		{
			global::<Module>.?_System_object@?$_Error_objects@H@std@@2V_System_error_category@2@A = ref global::<Module>.??_7_System_error_category@std@@6B@;
		}
		catch
		{
			global::<Module>.___CxxCallUnwindDtor(ldftn(std._Generic_error_category.{dtor}), (void*)(&global::<Module>.?_System_object@?$_Error_objects@H@std@@2V_System_error_category@2@A));
			throw;
		}
		global::<Module>._atexit_m(ldftn(?A0x174d99bf.??__F?_System_object@?$_Error_objects@H@std@@2V_System_error_category@2@A@@YMXXZ));
	}

	// Token: 0x06000042 RID: 66 RVA: 0x00004200 File Offset: 0x00003600
	internal unsafe static global::std.pair<std::_List_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>,bool>* emplace<unsigned\u0020int\u0020&,struct\u0020ProxyConnectionHandler\u0020*>(global::std._Hash<std::_Umap_traits<unsigned\u0020int,ProxyConnectionHandler\u0020*,std::_Uhash_compare<unsigned\u0020int,std::hash<unsigned\u0020int>,std::equal_to<unsigned\u0020int>\u0020>,std::allocator<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>,0>\u0020>* A_0, global::std.pair<std::_List_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>,bool>* A_1, uint* <_Val_0>, global::ProxyConnectionHandler** <_Val_1>)
	{
		global::std._List_unchecked_const_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>,std::_Iterator_base0> where = *(*A_0);
		global::<Module>.std.list<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>,std::allocator<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>._Insert<unsigned\u0020int\u0020&,struct\u0020ProxyConnectionHandler\u0020*>(A_0, where, <_Val_0>, <_Val_1>);
		int num = *(*A_0);
		global::std._List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020> pnode = num;
		global::<Module>.std._Hash<std::_Umap_traits<unsigned\u0020int,ProxyConnectionHandler\u0020*,std::_Uhash_compare<unsigned\u0020int,std::hash<unsigned\u0020int>,std::equal_to<unsigned\u0020int>\u0020>,std::allocator<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>,0>\u0020>._Insert<struct\u0020std::pair<unsigned\u0020int\u0020const\u0020,struct\u0020ProxyConnectionHandler\u0020*>\u0020&,class\u0020std::_List_unchecked_iterator<class\u0020std::_List_val<struct\u0020std::_List_simple_types<str(A_0, A_1, num + 8, pnode);
		return A_1;
	}

	// Token: 0x06000043 RID: 67 RVA: 0x0000AB64 File Offset: 0x00009F64
	internal static void ??__F?_System_object@?$_Error_objects@H@std@@2V_System_error_category@2@A@@YMXXZ()
	{
		global::<Module>.?_System_object@?$_Error_objects@H@std@@2V_System_error_category@2@A = ref global::<Module>.??_7error_category@std@@6B@;
	}

	// Token: 0x06000044 RID: 68 RVA: 0x0000AB7C File Offset: 0x00009F7C
	internal static void ??__F?_Iostream_object@?$_Error_objects@H@std@@2V_Iostream_error_category@2@A@@YMXXZ()
	{
		global::<Module>.?_Iostream_object@?$_Error_objects@H@std@@2V_Iostream_error_category@2@A = ref global::<Module>.??_7error_category@std@@6B@;
	}

	// Token: 0x06000045 RID: 69 RVA: 0x0000AB94 File Offset: 0x00009F94
	internal static void ??__F?_Generic_object@?$_Error_objects@H@std@@2V_Generic_error_category@2@A@@YMXXZ()
	{
		global::<Module>.?_Generic_object@?$_Error_objects@H@std@@2V_Generic_error_category@2@A = ref global::<Module>.??_7error_category@std@@6B@;
	}

	// Token: 0x06000046 RID: 70 RVA: 0x0000116C File Offset: 0x0000056C
	internal static void ??__E?id@?$num_put@DV?$back_insert_iterator@V?$basic_string@DU?$char_traits@D@std@@V?$allocator@D@2@@std@@@std@@@std@@2V0locale@2@A@@YMXXZ()
	{
		global::<Module>.std.locale.id.{ctor}(ref global::<Module>.?id@?$num_put@DV?$back_insert_iterator@V?$basic_string@DU?$char_traits@D@std@@V?$allocator@D@2@@std@@@std@@@std@@2V0locale@2@A, 0U);
	}

	// Token: 0x06000047 RID: 71 RVA: 0x00001188 File Offset: 0x00000588
	internal static void ??__E?id@?$num_put@GV?$back_insert_iterator@V?$basic_string@GU?$char_traits@G@std@@V?$allocator@G@2@@std@@@std@@@std@@2V0locale@2@A@@YMXXZ()
	{
		global::<Module>.std.locale.id.{ctor}(ref global::<Module>.?id@?$num_put@GV?$back_insert_iterator@V?$basic_string@GU?$char_traits@G@std@@V?$allocator@G@2@@std@@@std@@@std@@2V0locale@2@A, 0U);
	}

	// Token: 0x06000048 RID: 72 RVA: 0x00003F88 File Offset: 0x00003388
	internal unsafe static global::std.pair<std::_List_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>,bool>* _Insert<struct\u0020std::pair<unsigned\u0020int\u0020const\u0020,struct\u0020ProxyConnectionHandler\u0020*>\u0020&,class\u0020std::_List_unchecked_iterator<class\u0020std::_List_val<struct\u0020std::_List_simple_types<struct\u0020std::pair<unsigned\u0020int\u0020const\u0020,struct\u0020ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>\u0020>(global::std._Hash<std::_Umap_traits<unsigned\u0020int,ProxyConnectionHandler\u0020*,std::_Uhash_compare<unsigned\u0020int,std::hash<unsigned\u0020int>,std::equal_to<unsigned\u0020int>\u0020>,std::allocator<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>,0>\u0020>* A_0, global::std.pair<std::_List_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>,bool>* A_1, global::std.pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>* _Val, global::std._List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020> _Pnode)
	{
		int num = (int)stackalloc byte[global::<Module>.__CxxQueryExceptionSize()];
		global::std._List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020> list_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020> = 0;
		uint num4;
		uint exceptionCode;
		try
		{
			uint num2 = (uint)(*(A_0 + 20));
			uint num3 = global::<Module>.std._Uhash_compare<unsigned\u0020int,std::hash<unsigned\u0020int>,std::equal_to<unsigned\u0020int>\u0020>.()(A_0, _Val) & num2;
			if (*(A_0 + 24) <= (int)num3)
			{
				num3 = uint.MaxValue - (num2 >> 1) + num3;
			}
			num4 = num3;
			global::std._List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020> list_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020>2;
			global::std._List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>* ptr = global::<Module>.std._Hash<std::_Umap_traits<unsigned\u0020int,ProxyConnectionHandler\u0020*,std::_Uhash_compare<unsigned\u0020int,std::hash<unsigned\u0020int>,std::equal_to<unsigned\u0020int>\u0020>,std::allocator<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>,0>\u0020>._End(A_0, &list_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020>2, num3);
			cpblk(ref list_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020>, ptr, 4);
			global::std.pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>* ptr2;
			do
			{
				global::std._List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020> list_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020>3;
				cpblk(ref list_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020>3, num4 * 8U + (uint)(*(A_0 + 8)), 4);
				if (((((list_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020> == list_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020>3) ? 1 : 0) == 0) ? 1 : 0) == 0)
				{
					goto IL_CC;
				}
				list_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020> = *(list_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020> + 4);
				ptr2 = list_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020> + 8;
			}
			while (((((*_Val == *ptr2) ? 1 : 0) == 0) ? 1 : 0) != 0);
			if (((((*(list_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020> + 8) == *_Val) ? 1 : 0) == 0) ? 1 : 0) == 0)
			{
				global::<Module>.std._Hash<std::_Umap_traits<unsigned\u0020int,ProxyConnectionHandler\u0020*,std::_Uhash_compare<unsigned\u0020int,std::hash<unsigned\u0020int>,std::equal_to<unsigned\u0020int>\u0020>,std::allocator<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>,0>\u0020>._Destroy_if_not_nil(A_0, _Pnode);
				global::std._List_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020> list_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020>;
				global::<Module>.std._List_unchecked_const_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>,std::_Iterator_base0>.{ctor}(ref list_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020>, list_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020>, A_0);
				cpblk(A_1, ref list_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020>, 4);
				*(byte*)(A_1 + 4 / sizeof(global::std.pair<std::_List_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>,bool>)) = 0;
				return A_1;
			}
			list_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020> = *list_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020>;
			IL_CC:;
		}
		catch when (delegate
		{
			// Failed to create a 'catch-when' expression
			exceptionCode = (uint)global::System.Runtime.InteropServices.Marshal.GetExceptionCode();
			endfilter(global::<Module>.__CxxExceptionFilter(global::System.Runtime.InteropServices.Marshal.GetExceptionPointers(), null, 0, null) != null);
		})
		{
			uint num5 = 0U;
			global::<Module>.__CxxRegisterExceptionObject(global::System.Runtime.InteropServices.Marshal.GetExceptionPointers(), num);
			try
			{
				try
				{
					global::<Module>.std._Hash<std::_Umap_traits<unsigned\u0020int,ProxyConnectionHandler\u0020*,std::_Uhash_compare<unsigned\u0020int,std::hash<unsigned\u0020int>,std::equal_to<unsigned\u0020int>\u0020>,std::allocator<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>,0>\u0020>._Destroy_if_not_nil(A_0, _Pnode);
					global::<Module>._CxxThrowException(null, null);
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
				global::<Module>.__CxxUnregisterExceptionObject(num, (int)num5);
			}
		}
		global::std._List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020> plist = _Pnode;
		global::std._List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020> list_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020>4 = *_Pnode;
		if (((((list_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020> == list_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020>4) ? 1 : 0) == 0) ? 1 : 0) != 0)
		{
			global::std._List_unchecked_const_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>,std::_Iterator_base0> last = list_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020>4;
			global::std._List_unchecked_const_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>,std::_Iterator_base0> first = _Pnode;
			global::std._List_unchecked_const_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>,std::_Iterator_base0> where = list_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020>;
			global::<Module>.std.list<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>,std::allocator<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>._Unchecked_splice(A_0, where, first, last);
		}
		global::<Module>.std._Hash<std::_Umap_traits<unsigned\u0020int,ProxyConnectionHandler\u0020*,std::_Uhash_compare<unsigned\u0020int,std::hash<unsigned\u0020int>,std::equal_to<unsigned\u0020int>\u0020>,std::allocator<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>,0>\u0020>._Insert_bucket(A_0, plist, list_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020>, num4);
		global::<Module>.std._Hash<std::_Umap_traits<unsigned\u0020int,ProxyConnectionHandler\u0020*,std::_Uhash_compare<unsigned\u0020int,std::hash<unsigned\u0020int>,std::equal_to<unsigned\u0020int>\u0020>,std::allocator<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>,0>\u0020>._Check_size(A_0);
		cpblk(A_1, ref plist, 4);
		*(byte*)(A_1 + 4 / sizeof(global::std.pair<std::_List_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>,bool>)) = 1;
		return A_1;
	}

	// Token: 0x06000049 RID: 73 RVA: 0x00003660 File Offset: 0x00002A60
	internal unsafe static void _Uninit_fill_n<class\u0020std::_List_unchecked_iterator<class\u0020std::_List_val<struct\u0020std::_List_simple_types<struct\u0020std::pair<unsigned\u0020int\u0020const\u0020,struct\u0020ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>\u0020*,unsigned\u0020int,class\u0020std::_List_unchecked_iterator<class\u0020std::_List_val<struct\u0020std::_List_simple_types<struct\u0020std::pair<unsigned\u0020int\u0020const\u0020,struct\u0020ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>,struct\u0020std::_Wrap_a(global::std._List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>* _First, uint _Count, global::std._List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>* _Pval, global::std._Wrap_alloc<std::_Wrap_alloc<std::allocator<std::_List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>\u0020>\u0020>\u0020>* _Al, global::std._List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>* __unnamed004, global::std._Nonscalar_ptr_iterator_tag __unnamed005)
	{
		int num = (int)stackalloc byte[global::<Module>.__CxxQueryExceptionSize()];
		global::std._List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>* ptr = _First;
		uint exceptionCode;
		try
		{
			while (0U < _Count)
			{
				if (_First != null)
				{
					cpblk(_First, _Pval, 4);
				}
				_Count -= 1U;
				_First += 4 / sizeof(global::std._List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>);
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
					while (ptr != _First)
					{
						ptr += 4 / sizeof(global::std._List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>);
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
	}

	// Token: 0x0600004A RID: 74 RVA: 0x000032B0 File Offset: 0x000026B0
	internal unsafe static void _Destroy_if_not_nil(global::std._Hash<std::_Umap_traits<unsigned\u0020int,ProxyConnectionHandler\u0020*,std::_Uhash_compare<unsigned\u0020int,std::hash<unsigned\u0020int>,std::equal_to<unsigned\u0020int>\u0020>,std::allocator<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>,0>\u0020>* A_0, global::std._List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020> _Plist)
	{
		global::<Module>.delete(global::<Module>.std.list<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>,std::allocator<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>._Unlinknode(A_0, _Plist));
	}

	// Token: 0x0600004B RID: 75 RVA: 0x00002AE0 File Offset: 0x00001EE0
	internal unsafe static void _Insert_bucket(global::std._Hash<std::_Umap_traits<unsigned\u0020int,ProxyConnectionHandler\u0020*,std::_Uhash_compare<unsigned\u0020int,std::hash<unsigned\u0020int>,std::equal_to<unsigned\u0020int>\u0020>,std::allocator<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>,0>\u0020>* A_0, global::std._List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020> _Plist, global::std._List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020> _Where, uint _Bucket)
	{
		global::std._List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020> list_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020>;
		global::<Module>.std._List_unchecked_const_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>,std::_Iterator_base0>.{ctor}(ref list_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020>, *A_0, A_0);
		int num = (int)(_Bucket * 8U);
		int num2 = num + *(A_0 + 8);
		uint num3 = (uint)(*num2);
		if (((num3 == list_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020>) ? 1 : 0) != 0)
		{
			cpblk(num2, ref _Plist, 4);
			cpblk(num + *(A_0 + 8) + 4, ref _Plist, 4);
		}
		else if (((num3 == _Where) ? 1 : 0) != 0)
		{
			cpblk(num2, ref _Plist, 4);
		}
		else
		{
			int num4 = *(*(num2 + 4));
			*(num2 + 4) = num4;
			if (((((num4 == _Plist) ? 1 : 0) == 0) ? 1 : 0) != 0)
			{
				int num5 = num + *(A_0 + 8) + 4;
				*num5 = *(*num5 + 4);
			}
		}
	}

	// Token: 0x0600004C RID: 76 RVA: 0x00003E40 File Offset: 0x00003240
	internal unsafe static void _Check_size(global::std._Hash<std::_Umap_traits<unsigned\u0020int,ProxyConnectionHandler\u0020*,std::_Uhash_compare<unsigned\u0020int,std::hash<unsigned\u0020int>,std::equal_to<unsigned\u0020int>\u0020>,std::allocator<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>,0>\u0020>* A_0)
	{
		float num = *(A_0 + 28);
		uint num2 = (uint)(*(A_0 + 24));
		if ((double)num < (double)((float)((double)(*(A_0 + 4)) / (double)num2)))
		{
			uint num3 = num2;
			if (num3 < 512U)
			{
				num3 <<= 3;
			}
			else if (num3 < 536870911U)
			{
				num3 <<= 1;
			}
			global::<Module>.std._Hash<std::_Umap_traits<unsigned\u0020int,ProxyConnectionHandler\u0020*,std::_Uhash_compare<unsigned\u0020int,std::hash<unsigned\u0020int>,std::equal_to<unsigned\u0020int>\u0020>,std::allocator<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>,0>\u0020>._Init(A_0, num3);
			global::<Module>.std._Hash<std::_Umap_traits<unsigned\u0020int,ProxyConnectionHandler\u0020*,std::_Uhash_compare<unsigned\u0020int,std::hash<unsigned\u0020int>,std::equal_to<unsigned\u0020int>\u0020>,std::allocator<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>,0>\u0020>._Reinsert(A_0);
		}
	}

	// Token: 0x0600004D RID: 77 RVA: 0x00001BA8 File Offset: 0x00000FA8
	internal unsafe static void _Unchecked_splice(global::std.list<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>,std::allocator<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>* A_0, global::std._List_unchecked_const_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>,std::_Iterator_base0> _Where, global::std._List_unchecked_const_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>,std::_Iterator_base0> _First, global::std._List_unchecked_const_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>,std::_Iterator_base0> _Last)
	{
		*(*(_First + 4)) = _Last;
		*(*(_Last + 4)) = _Where;
		*(*(_Where + 4)) = _First;
		int num = _Where + 4;
		global::std._List_node<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>,void\u0020*>* ptr = *num;
		*num = *(_Last + 4);
		*(_Last + 4) = *(_First + 4);
		*(_First + 4) = ptr;
	}

	// Token: 0x0600004E RID: 78 RVA: 0x00002B5C File Offset: 0x00001F5C
	internal unsafe static void _Reinsert(global::std._Hash<std::_Umap_traits<unsigned\u0020int,ProxyConnectionHandler\u0020*,std::_Uhash_compare<unsigned\u0020int,std::hash<unsigned\u0020int>,std::equal_to<unsigned\u0020int>\u0020>,std::allocator<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>,0>\u0020>* A_0)
	{
		int num = *A_0;
		global::std._List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020> list_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020> = num;
		if (((((*num == list_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020>) ? 1 : 0) == 0) ? 1 : 0) != 0)
		{
			list_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020> = *(list_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020> + 4);
			byte b;
			do
			{
				global::std._List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020> list_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020>2 = *(*A_0);
				b = ((list_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020>2 == list_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020>) ? 1 : 0);
				global::std.pair<std::_List_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>,bool> pair<std::_List_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020>,bool>;
				global::<Module>.std._Hash<std::_Umap_traits<unsigned\u0020int,ProxyConnectionHandler\u0020*,std::_Uhash_compare<unsigned\u0020int,std::hash<unsigned\u0020int>,std::equal_to<unsigned\u0020int>\u0020>,std::allocator<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>,0>\u0020>._Insert<struct\u0020std::pair<unsigned\u0020int\u0020const\u0020,struct\u0020ProxyConnectionHandler\u0020*>\u0020&,class\u0020std::_List_unchecked_iterator<class\u0020std::_List_val<struct\u0020std::_List_simple_types<str(A_0, &pair<std::_List_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020>,bool>, list_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020>2 + 8, list_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020>2);
			}
			while (b == 0);
		}
	}

	// Token: 0x0600004F RID: 79 RVA: 0x00003504 File Offset: 0x00002904
	internal unsafe static void _Insert<unsigned\u0020int\u0020&,struct\u0020ProxyConnectionHandler\u0020*>(global::std.list<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>,std::allocator<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>* A_0, global::std._List_unchecked_const_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>,std::_Iterator_base0> _Where, uint* <_Val_0>, global::ProxyConnectionHandler** <_Val_1>)
	{
		int num = _Where + 4;
		ref int ptr = num;
		global::std._List_node<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>,void\u0020*>* ptr2 = global::<Module>.std._List_buy<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>,std::allocator<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>._Buynode<unsigned\u0020int\u0020&,struct\u0020ProxyConnectionHandler\u0020*>(A_0, _Where, *num, <_Val_0>, <_Val_1>);
		uint num2 = (uint)(*(A_0 + 4));
		if (268435454U - num2 < 1U)
		{
			global::<Module>.std._Xlength_error((sbyte*)(&global::<Module>.??_C@_0BB@MOGOBHAF@list?$DMT?$DO?5too?5long?$AA@));
		}
		*(A_0 + 4) = (int)(num2 + 1U);
		ptr = ptr2;
		*(*(int*)(ptr2 + 4 / sizeof(global::std._List_node<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>,void\u0020*>))) = ptr2;
	}

	// Token: 0x06000050 RID: 80 RVA: 0x000038B0 File Offset: 0x00002CB0
	internal unsafe static global::std._List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>* _Uninit_move<class\u0020std::_List_unchecked_iterator<class\u0020std::_List_val<struct\u0020std::_List_simple_types<struct\u0020std::pair<unsigned\u0020int\u0020const\u0020,struct\u0020ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>\u0020*,class\u0020std::_List_unchecked_iterator<class\u0020std::_List_val<struct\u0020std::_List_simple_types<struct\u0020std::pair<unsigned\u0020int\u0020const\u0020,struct\u0020ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>\u0020*,struct\u0020std::_Wrap_alloc<struct\u…(global::std._List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>* _First, global::std._List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>* _Last, global::std._List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>* _Dest, global::std._Wrap_alloc<std::_Wrap_alloc<std::allocator<std::_List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>\u0020>\u0020>\u0020>* _Al)
	{
		global::std._Nonscalar_ptr_iterator_tag nonscalar_ptr_iterator_tag;
		global::std._Nonscalar_ptr_iterator_tag _unnamed = nonscalar_ptr_iterator_tag;
		return global::<Module>.std._Uninit_move<class\u0020std::_List_unchecked_iterator<class\u0020std::_List_val<struct\u0020std::_List_simple_types<struct\u0020std::pair<unsigned\u0020int\u0020const\u0020,struct\u0020ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>\u0020*,class\u0020std::_List_unchecked_iterator<class\u0020std::_List_val<struct\u0020std::_List_simple_types<struct\u0020std::pair<unsigned\u0020int\u0020const\u0020,struct\u0020ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>\u0020*,struct\u0020std::_Wrap_alloc<clas(_First, _Last, _Dest, _Al, null, _unnamed);
	}

	// Token: 0x06000051 RID: 81 RVA: 0x000032CC File Offset: 0x000026CC
	internal unsafe static global::std._List_node<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>,void\u0020*>* _Buynode<unsigned\u0020int\u0020&,struct\u0020ProxyConnectionHandler\u0020*>(global::std._List_buy<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>,std::allocator<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>* A_0, global::std._List_node<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>,void\u0020*>* _Next, global::std._List_node<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>,void\u0020*>* _Prev, uint* <_Val_0>, global::ProxyConnectionHandler** <_Val_1>)
	{
		int num = (int)stackalloc byte[global::<Module>.__CxxQueryExceptionSize()];
		global::std._List_node<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>,void\u0020*>* ptr = global::<Module>.std._List_alloc<0,std::_List_base_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>,std::allocator<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>._Buynode0(A_0, _Next, _Prev);
		uint exceptionCode;
		try
		{
			global::std.pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>* ptr2 = (global::std.pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>*)(ptr + 8 / sizeof(global::std._List_node<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>,void\u0020*>));
			global::std.pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>* a_ = ptr2;
			try
			{
				if (ptr2 != null)
				{
					*(int*)ptr2 = *<_Val_0>;
					*(int*)(ptr2 + 4 / sizeof(global::std.pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>)) = *<_Val_1>;
				}
			}
			catch
			{
				global::<Module>.delete((void*)a_, (void*)ptr2);
				throw;
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
					global::<Module>.delete((void*)ptr);
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
		return ptr;
	}

	// Token: 0x06000052 RID: 82 RVA: 0x00003744 File Offset: 0x00002B44
	internal unsafe static global::std._List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>* _Uninit_move<class\u0020std::_List_unchecked_iterator<class\u0020std::_List_val<struct\u0020std::_List_simple_types<struct\u0020std::pair<unsigned\u0020int\u0020const\u0020,struct\u0020ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>\u0020*,class\u0020std::_List_unchecked_iterator<class\u0020std::_List_val<struct\u0020std::_List_simple_types<struct\u0020std::pair<unsigned\u0020int\u0020const\u0020,struct\u0020ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>\u0020*,struct\u0020std::_Wrap_alloc<class\u0…(global::std._List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>* _First, global::std._List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>* _Last, global::std._List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>* _Dest, global::std._Wrap_alloc<std::_Wrap_alloc<std::allocator<std::_List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>\u0020>\u0020>\u0020>* _Al, global::std._List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>* __unnamed004, global::std._Nonscalar_ptr_iterator_tag __unnamed005)
	{
		int num = (int)stackalloc byte[global::<Module>.__CxxQueryExceptionSize()];
		global::std._List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>* ptr = _Dest;
		uint exceptionCode;
		try
		{
			while (_First != _Last)
			{
				global::std._List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>* a_ = _Dest;
				try
				{
					if (_Dest != null)
					{
						cpblk(_Dest, _First, 4);
					}
				}
				catch
				{
					global::<Module>.delete((void*)a_, (void*)_Dest);
					throw;
				}
				_Dest += 4 / sizeof(global::std._List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>);
				_First += 4 / sizeof(global::std._List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>);
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
						ptr += 4 / sizeof(global::std._List_unchecked_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>);
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

	// Token: 0x06000053 RID: 83 RVA: 0x00004A18 File Offset: 0x00003E18
	internal unsafe static global::MCallBack* {ctor}(global::MCallBack* A_0, global::LEAdaptor.MRemoteSystem p)
	{
		*A_0 = ref global::<Module>.??_7MCallBack@@6B@;
		global::MCallBack* ptr = A_0 + 4;
		global::<Module>.gcroot<LEAdaptor::MRemoteSystem\u0020^>.{ctor}(ptr);
		try
		{
			global::<Module>.gcroot<LEAdaptor::MRemoteSystem\u0020^>.=(ptr, p);
		}
		catch
		{
			global::<Module>.___CxxCallUnwindDtor(ldftn(gcroot<LEAdaptor::MRemoteSystem\u0020^>.{dtor}), A_0 + 4);
			throw;
		}
		return A_0;
	}

	// Token: 0x06000054 RID: 84 RVA: 0x00004A70 File Offset: 0x00003E70
	internal unsafe static void OnStatusChange(global::MCallBack* A_0, uint eventType, uint eventID, uint peerID)
	{
		global::<Module>.gcroot<LEAdaptor::MRemoteSystem\u0020^>.->(A_0 + 4).OnInternalEvent(eventType, eventID, peerID);
	}

	// Token: 0x06000055 RID: 85 RVA: 0x0000124C File Offset: 0x0000064C
	[global::System.Security.SecuritySafeCritical]
	[global::System.Diagnostics.DebuggerStepThrough]
	internal unsafe static global::gcroot<LEAdaptor::MRemoteSystem\u0020^>* {ctor}(global::gcroot<LEAdaptor::MRemoteSystem\u0020^>* A_0)
	{
		*A_0 = ((global::System.IntPtr)global::System.Runtime.InteropServices.GCHandle.Alloc(null)).ToPointer();
		return A_0;
	}

	// Token: 0x06000056 RID: 86 RVA: 0x000049F0 File Offset: 0x00003DF0
	[global::System.Security.SecurityCritical]
	[global::System.Diagnostics.DebuggerStepThrough]
	internal unsafe static void {dtor}(global::gcroot<LEAdaptor::MRemoteSystem\u0020^>* A_0)
	{
		global::System.IntPtr value = new global::System.IntPtr(*A_0);
		((global::System.Runtime.InteropServices.GCHandle)value).Free();
		*A_0 = 0;
	}

	// Token: 0x06000057 RID: 87 RVA: 0x00001270 File Offset: 0x00000670
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.Security.SecurityCritical]
	internal unsafe static global::gcroot<LEAdaptor::MRemoteSystem\u0020^>* =(global::gcroot<LEAdaptor::MRemoteSystem\u0020^>* A_0, global::LEAdaptor.MRemoteSystem t)
	{
		global::System.IntPtr value = new global::System.IntPtr(*A_0);
		((global::System.Runtime.InteropServices.GCHandle)value).Target = t;
		return A_0;
	}

	// Token: 0x06000058 RID: 88 RVA: 0x00006644 File Offset: 0x00005A44
	[global::System.Security.SecuritySafeCritical]
	internal unsafe static global::LEAdaptor.MRemoteSystem ->(global::gcroot<LEAdaptor::MRemoteSystem\u0020^>* A_0)
	{
		global::System.IntPtr value = new global::System.IntPtr(*A_0);
		return ((global::System.Runtime.InteropServices.GCHandle)value).Target;
	}

	// Token: 0x06000059 RID: 89 RVA: 0x00005F4C File Offset: 0x0000534C
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

	// Token: 0x0600005A RID: 90 RVA: 0x00006684 File Offset: 0x00005A84
	internal static void <CrtImplementationDetails>.ThrowNestedModuleLoadException(global::System.Exception innerException, global::System.Exception nestedException)
	{
		throw new global::<CrtImplementationDetails>.ModuleLoadExceptionHandlerException("A nested exception occurred after the primary exception that caused the C++ module to fail to load.\n", innerException, nestedException);
	}

	// Token: 0x0600005B RID: 91 RVA: 0x00006108 File Offset: 0x00005508
	internal static void <CrtImplementationDetails>.ThrowModuleLoadException(string errorMessage)
	{
		throw new global::<CrtImplementationDetails>.ModuleLoadException(errorMessage);
	}

	// Token: 0x0600005C RID: 92 RVA: 0x0000611C File Offset: 0x0000551C
	internal static void <CrtImplementationDetails>.ThrowModuleLoadException(string errorMessage, global::System.Exception innerException)
	{
		throw new global::<CrtImplementationDetails>.ModuleLoadException(errorMessage, innerException);
	}

	// Token: 0x0600005D RID: 93 RVA: 0x00006238 File Offset: 0x00005638
	internal static void <CrtImplementationDetails>.RegisterModuleUninitializer(global::System.EventHandler handler)
	{
		global::<CrtImplementationDetails>.ModuleUninitializer._ModuleUninitializer.AddHandler(handler);
	}

	// Token: 0x0600005E RID: 94 RVA: 0x00006250 File Offset: 0x00005650
	[global::System.Security.SecuritySafeCritical]
	internal unsafe static global::System.Guid <CrtImplementationDetails>.FromGUID(global::_GUID* guid)
	{
		global::System.Guid result = new global::System.Guid((uint)(*guid), *(guid + 4), *(guid + 6), *(guid + 8), *(guid + 9), *(guid + 10), *(guid + 11), *(guid + 12), *(guid + 13), *(guid + 14), *(guid + 15));
		return result;
	}

	// Token: 0x0600005F RID: 95 RVA: 0x00006298 File Offset: 0x00005698
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

	// Token: 0x06000060 RID: 96 RVA: 0x0000631C File Offset: 0x0000571C
	internal unsafe static void __release_appdomain(global::IUnknown* ppUnk)
	{
		object obj = calli(System.UInt32 modopt(System.Runtime.CompilerServices.IsLong) modopt(System.Runtime.CompilerServices.CallConvStdcall)(System.IntPtr), ppUnk, *(*(int*)ppUnk + 8));
	}

	// Token: 0x06000061 RID: 97 RVA: 0x00006338 File Offset: 0x00005738
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

	// Token: 0x06000062 RID: 98 RVA: 0x00006398 File Offset: 0x00005798
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

	// Token: 0x06000063 RID: 99 RVA: 0x00006428 File Offset: 0x00005828
	[global::System.Security.SecuritySafeCritical]
	internal unsafe static int <CrtImplementationDetails>.DefaultDomain.DoNothing(void* cookie)
	{
		global::System.GC.KeepAlive(int.MaxValue);
		return 0;
	}

	// Token: 0x06000064 RID: 100 RVA: 0x00006448 File Offset: 0x00005848
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

	// Token: 0x06000065 RID: 101 RVA: 0x0000649C File Offset: 0x0000589C
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

	// Token: 0x06000066 RID: 102 RVA: 0x0000651C File Offset: 0x0000591C
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

	// Token: 0x06000067 RID: 103 RVA: 0x00006558 File Offset: 0x00005958
	[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
	internal static bool <CrtImplementationDetails>.DefaultDomain.NeedsUninitialization()
	{
		return global::<Module>.?Entered@DefaultDomain@<CrtImplementationDetails>@@2_NA;
	}

	// Token: 0x06000068 RID: 104 RVA: 0x0000656C File Offset: 0x0000596C
	[global::System.Security.SecurityCritical]
	internal static void <CrtImplementationDetails>.DefaultDomain.Initialize()
	{
		global::<Module>.<CrtImplementationDetails>.DoCallBackInDefaultDomain(global::<Module>.__unep@?DoNothing@DefaultDomain@<CrtImplementationDetails>@@$$FCGJPAX@Z, null);
	}

	// Token: 0x06000069 RID: 105 RVA: 0x000011A4 File Offset: 0x000005A4
	internal static void ??__E?Initialized@CurrentDomain@<CrtImplementationDetails>@@$$Q2HA@@YMXXZ()
	{
		global::<Module>.?Initialized@CurrentDomain@<CrtImplementationDetails>@@$$Q2HA = 0;
	}

	// Token: 0x0600006A RID: 106 RVA: 0x000011B8 File Offset: 0x000005B8
	internal static void ??__E?Uninitialized@CurrentDomain@<CrtImplementationDetails>@@$$Q2HA@@YMXXZ()
	{
		global::<Module>.?Uninitialized@CurrentDomain@<CrtImplementationDetails>@@$$Q2HA = 0;
	}

	// Token: 0x0600006B RID: 107 RVA: 0x000011CC File Offset: 0x000005CC
	internal static void ??__E?IsDefaultDomain@CurrentDomain@<CrtImplementationDetails>@@$$Q2_NA@@YMXXZ()
	{
		global::<Module>.?IsDefaultDomain@CurrentDomain@<CrtImplementationDetails>@@$$Q2_NA = false;
	}

	// Token: 0x0600006C RID: 108 RVA: 0x000011E0 File Offset: 0x000005E0
	internal static void ??__E?InitializedVtables@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A@@YMXXZ()
	{
		global::<Module>.?InitializedVtables@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A = (global::<CrtImplementationDetails>.Progress.State)0;
	}

	// Token: 0x0600006D RID: 109 RVA: 0x000011F4 File Offset: 0x000005F4
	internal static void ??__E?InitializedNative@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A@@YMXXZ()
	{
		global::<Module>.?InitializedNative@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A = (global::<CrtImplementationDetails>.Progress.State)0;
	}

	// Token: 0x0600006E RID: 110 RVA: 0x00001208 File Offset: 0x00000608
	internal static void ??__E?InitializedPerProcess@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A@@YMXXZ()
	{
		global::<Module>.?InitializedPerProcess@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A = (global::<CrtImplementationDetails>.Progress.State)0;
	}

	// Token: 0x0600006F RID: 111 RVA: 0x0000121C File Offset: 0x0000061C
	internal static void ??__E?InitializedPerAppDomain@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A@@YMXXZ()
	{
		global::<Module>.?InitializedPerAppDomain@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A = (global::<CrtImplementationDetails>.Progress.State)0;
	}

	// Token: 0x06000070 RID: 112 RVA: 0x000066D8 File Offset: 0x00005AD8
	[global::System.Security.SecurityCritical]
	[global::System.Diagnostics.DebuggerStepThrough]
	internal unsafe static void <CrtImplementationDetails>.LanguageSupport.InitializeVtables(global::<CrtImplementationDetails>.LanguageSupport* A_0)
	{
		global::<Module>.gcroot<System::String\u0020^>.=(A_0, "The C++ module failed to load during vtable initialization.\n");
		global::<Module>.?InitializedVtables@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A = (global::<CrtImplementationDetails>.Progress.State)1;
		global::<Module>._initterm_m((global::method*)(&global::<Module>.?A0xd2508fec.__xi_vt_a), (global::method*)(&global::<Module>.?A0xd2508fec.__xi_vt_z));
		global::<Module>.?InitializedVtables@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A = (global::<CrtImplementationDetails>.Progress.State)2;
	}

	// Token: 0x06000071 RID: 113 RVA: 0x0000670C File Offset: 0x00005B0C
	[global::System.Security.SecurityCritical]
	internal unsafe static void <CrtImplementationDetails>.LanguageSupport.InitializeDefaultAppDomain(global::<CrtImplementationDetails>.LanguageSupport* A_0)
	{
		global::<Module>.gcroot<System::String\u0020^>.=(A_0, "The C++ module failed to load while attempting to initialize the default appdomain.\n");
		global::<Module>.<CrtImplementationDetails>.DefaultDomain.Initialize();
	}

	// Token: 0x06000072 RID: 114 RVA: 0x0000672C File Offset: 0x00005B2C
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

	// Token: 0x06000073 RID: 115 RVA: 0x000067C8 File Offset: 0x00005BC8
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

	// Token: 0x06000074 RID: 116 RVA: 0x00006808 File Offset: 0x00005C08
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

	// Token: 0x06000075 RID: 117 RVA: 0x00006844 File Offset: 0x00005C44
	[global::System.Security.SecurityCritical]
	[global::System.Diagnostics.DebuggerStepThrough]
	internal unsafe static void <CrtImplementationDetails>.LanguageSupport.InitializeUninitializer(global::<CrtImplementationDetails>.LanguageSupport* A_0)
	{
		global::<Module>.gcroot<System::String\u0020^>.=(A_0, "The C++ module failed to load during registration for the unload events.\n");
		global::<Module>.<CrtImplementationDetails>.RegisterModuleUninitializer(new global::System.EventHandler(global::<Module>.<CrtImplementationDetails>.LanguageSupport.DomainUnload));
	}

	// Token: 0x06000076 RID: 118 RVA: 0x00006870 File Offset: 0x00005C70
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.Success)]
	[global::System.Security.SecurityCritical]
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

	// Token: 0x06000077 RID: 119 RVA: 0x00006584 File Offset: 0x00005984
	[global::System.Security.SecurityCritical]
	internal static void <CrtImplementationDetails>.LanguageSupport.UninitializeAppDomain()
	{
		global::<Module>._app_exit_callback();
	}

	// Token: 0x06000078 RID: 120 RVA: 0x00006598 File Offset: 0x00005998
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

	// Token: 0x06000079 RID: 121 RVA: 0x000065D4 File Offset: 0x000059D4
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

	// Token: 0x0600007A RID: 122 RVA: 0x00006608 File Offset: 0x00005A08
	[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.Success)]
	[global::System.Security.SecurityCritical]
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

	// Token: 0x0600007B RID: 123 RVA: 0x00006994 File Offset: 0x00005D94
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

	// Token: 0x0600007C RID: 124 RVA: 0x00006A08 File Offset: 0x00005E08
	[global::System.Security.SecurityCritical]
	internal unsafe static global::<CrtImplementationDetails>.LanguageSupport* <CrtImplementationDetails>.LanguageSupport.{ctor}(global::<CrtImplementationDetails>.LanguageSupport* A_0)
	{
		global::<Module>.gcroot<System::String\u0020^>.{ctor}(A_0);
		return A_0;
	}

	// Token: 0x0600007D RID: 125 RVA: 0x00006A20 File Offset: 0x00005E20
	[global::System.Security.SecurityCritical]
	internal unsafe static void <CrtImplementationDetails>.LanguageSupport.{dtor}(global::<CrtImplementationDetails>.LanguageSupport* A_0)
	{
		global::<Module>.gcroot<System::String\u0020^>.{dtor}(A_0);
	}

	// Token: 0x0600007E RID: 126 RVA: 0x00006A34 File Offset: 0x00005E34
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

	// Token: 0x0600007F RID: 127 RVA: 0x00006AF0 File Offset: 0x00005EF0
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

	// Token: 0x06000080 RID: 128 RVA: 0x0000124C File Offset: 0x0000064C
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.Security.SecuritySafeCritical]
	internal unsafe static global::gcroot<System::String\u0020^>* {ctor}(global::gcroot<System::String\u0020^>* A_0)
	{
		*A_0 = ((global::System.IntPtr)global::System.Runtime.InteropServices.GCHandle.Alloc(null)).ToPointer();
		return A_0;
	}

	// Token: 0x06000081 RID: 129 RVA: 0x000049F0 File Offset: 0x00003DF0
	[global::System.Security.SecurityCritical]
	[global::System.Diagnostics.DebuggerStepThrough]
	internal unsafe static void {dtor}(global::gcroot<System::String\u0020^>* A_0)
	{
		global::System.IntPtr value = new global::System.IntPtr(*A_0);
		((global::System.Runtime.InteropServices.GCHandle)value).Free();
		*A_0 = 0;
	}

	// Token: 0x06000082 RID: 130 RVA: 0x00001270 File Offset: 0x00000670
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.Security.SecurityCritical]
	internal unsafe static global::gcroot<System::String\u0020^>* =(global::gcroot<System::String\u0020^>* A_0, string t)
	{
		global::System.IntPtr value = new global::System.IntPtr(*A_0);
		((global::System.Runtime.InteropServices.GCHandle)value).Target = t;
		return A_0;
	}

	// Token: 0x06000083 RID: 131 RVA: 0x00006644 File Offset: 0x00005A44
	[global::System.Security.SecuritySafeCritical]
	internal unsafe static string P$AAVString@System@@(global::gcroot<System::String\u0020^>* A_0)
	{
		global::System.IntPtr value = new global::System.IntPtr(*A_0);
		return ((global::System.Runtime.InteropServices.GCHandle)value).Target;
	}

	// Token: 0x06000084 RID: 132 RVA: 0x00006B70 File Offset: 0x00005F70
	[global::System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
	[global::System.Security.SecurityCritical]
	[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.Success)]
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

	// Token: 0x06000085 RID: 133 RVA: 0x00006C28 File Offset: 0x00006028
	[global::System.Security.SecurityCritical]
	[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.Success)]
	[global::System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
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

	// Token: 0x06000086 RID: 134 RVA: 0x00006BB4 File Offset: 0x00005FB4
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

	// Token: 0x06000087 RID: 135 RVA: 0x00006BD4 File Offset: 0x00005FD4
	[global::System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
	[global::System.Security.SecurityCritical]
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

	// Token: 0x06000088 RID: 136 RVA: 0x00006C84 File Offset: 0x00006084
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.Security.SecurityCritical]
	internal static global::System.ValueType <CrtImplementationDetails>.AtExitLock._handle()
	{
		if (global::<Module>.?_lock@AtExitLock@<CrtImplementationDetails>@@$$Q0PAXA != null)
		{
			global::System.IntPtr value = new global::System.IntPtr(global::<Module>.?_lock@AtExitLock@<CrtImplementationDetails>@@$$Q0PAXA);
			return global::System.Runtime.InteropServices.GCHandle.FromIntPtr(value);
		}
		return null;
	}

	// Token: 0x06000089 RID: 137 RVA: 0x00007138 File Offset: 0x00006538
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.Security.SecurityCritical]
	internal static void <CrtImplementationDetails>.AtExitLock._lock_Construct(object value)
	{
		global::<Module>.?_lock@AtExitLock@<CrtImplementationDetails>@@$$Q0PAXA = null;
		global::<Module>.<CrtImplementationDetails>.AtExitLock._lock_Set(value);
	}

	// Token: 0x0600008A RID: 138 RVA: 0x00006CB4 File Offset: 0x000060B4
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

	// Token: 0x0600008B RID: 139 RVA: 0x00006D04 File Offset: 0x00006104
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

	// Token: 0x0600008C RID: 140 RVA: 0x00006D28 File Offset: 0x00006128
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

	// Token: 0x0600008D RID: 141 RVA: 0x00006D50 File Offset: 0x00006150
	[global::System.Security.SecuritySafeCritical]
	[global::System.Diagnostics.DebuggerStepThrough]
	[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
	internal static bool <CrtImplementationDetails>.AtExitLock.IsInitialized()
	{
		return (global::<Module>.<CrtImplementationDetails>.AtExitLock._lock_Get() != null) ? 1 : 0;
	}

	// Token: 0x0600008E RID: 142 RVA: 0x00007154 File Offset: 0x00006554
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

	// Token: 0x0600008F RID: 143 RVA: 0x00006D6C File Offset: 0x0000616C
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

	// Token: 0x06000090 RID: 144 RVA: 0x00006D94 File Offset: 0x00006194
	[global::System.Security.SecurityCritical]
	[global::System.Diagnostics.DebuggerStepThrough]
	internal static void <CrtImplementationDetails>.AtExitLock.Enter()
	{
		global::System.Threading.Monitor.Enter(global::<Module>.<CrtImplementationDetails>.AtExitLock._lock_Get());
	}

	// Token: 0x06000091 RID: 145 RVA: 0x00006DAC File Offset: 0x000061AC
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.Security.SecurityCritical]
	internal static void <CrtImplementationDetails>.AtExitLock.Exit()
	{
		global::System.Threading.Monitor.Exit(global::<Module>.<CrtImplementationDetails>.AtExitLock._lock_Get());
	}

	// Token: 0x06000092 RID: 146 RVA: 0x00006DC4 File Offset: 0x000061C4
	[global::System.Security.SecurityCritical]
	[global::System.Diagnostics.DebuggerStepThrough]
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

	// Token: 0x06000093 RID: 147 RVA: 0x00006DE4 File Offset: 0x000061E4
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

	// Token: 0x06000094 RID: 148 RVA: 0x00007184 File Offset: 0x00006584
	[global::System.Security.SecurityCritical]
	[global::System.Diagnostics.DebuggerStepThrough]
	[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
	internal static bool __alloc_global_lock()
	{
		global::<Module>.<CrtImplementationDetails>.AtExitLock.AddRef();
		return global::<Module>.<CrtImplementationDetails>.AtExitLock.IsInitialized();
	}

	// Token: 0x06000095 RID: 149 RVA: 0x00006E04 File Offset: 0x00006204
	[global::System.Security.SecurityCritical]
	[global::System.Diagnostics.DebuggerStepThrough]
	internal static void __dealloc_global_lock()
	{
		global::<Module>.<CrtImplementationDetails>.AtExitLock.RemoveRef();
	}

	// Token: 0x06000096 RID: 150 RVA: 0x00006E18 File Offset: 0x00006218
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

	// Token: 0x06000097 RID: 151 RVA: 0x00006F94 File Offset: 0x00006394
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

	// Token: 0x06000098 RID: 152 RVA: 0x0000719C File Offset: 0x0000659C
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

	// Token: 0x06000099 RID: 153 RVA: 0x00007038 File Offset: 0x00006438
	[global::System.Security.SecurityCritical]
	internal unsafe static int _atexit_m(global::method func)
	{
		return global::<Module>._atexit_helper(global::<Module>.EncodePointer(func), &global::<Module>.?A0xe62d03cb.__exit_list_size, &global::<Module>.?A0xe62d03cb.__onexitend_m, &global::<Module>.?A0xe62d03cb.__onexitbegin_m);
	}

	// Token: 0x0600009A RID: 154 RVA: 0x000071E4 File Offset: 0x000065E4
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

	// Token: 0x0600009B RID: 155 RVA: 0x00007060 File Offset: 0x00006460
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

	// Token: 0x0600009C RID: 156
	[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.Success)]
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Security.SecurityCritical]
	[global::System.Runtime.InteropServices.DllImport("KERNEL32.dll")]
	public unsafe static extern void* DecodePointer(void* Ptr);

	// Token: 0x0600009D RID: 157
	[global::System.Security.SecurityCritical]
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.Success)]
	[global::System.Runtime.InteropServices.DllImport("KERNEL32.dll")]
	public unsafe static extern void* EncodePointer(void* Ptr);

	// Token: 0x0600009E RID: 158 RVA: 0x00007228 File Offset: 0x00006628
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

	// Token: 0x0600009F RID: 159 RVA: 0x00007258 File Offset: 0x00006658
	[global::System.Security.SecurityCritical]
	[global::System.Diagnostics.DebuggerStepThrough]
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

	// Token: 0x060000A0 RID: 160 RVA: 0x00007280 File Offset: 0x00006680
	[global::System.Diagnostics.DebuggerStepThrough]
	internal static global::System.ModuleHandle <CrtImplementationDetails>.ThisModule.Handle()
	{
		return typeof(global::<CrtImplementationDetails>.ThisModule).Module.ModuleHandle;
	}

	// Token: 0x060000A1 RID: 161 RVA: 0x000072D0 File Offset: 0x000066D0
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

	// Token: 0x060000A2 RID: 162 RVA: 0x000072A4 File Offset: 0x000066A4
	[global::System.Security.SecurityCritical]
	[global::System.Diagnostics.DebuggerStepThrough]
	internal static global::method <CrtImplementationDetails>.ThisModule.ResolveMethod<void\u0020const\u0020*\u0020__clrcall(void)>(global::method methodToken)
	{
		return global::<Module>.<CrtImplementationDetails>.ThisModule.Handle().ResolveMethodHandle(methodToken).GetFunctionPointer().ToPointer();
	}

	// Token: 0x060000A3 RID: 163 RVA: 0x000059CC File Offset: 0x00004DCC
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern void delete(void*);

	// Token: 0x060000A4 RID: 164 RVA: 0x0000A98A File Offset: 0x00009D8A
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern void _Orphan_all(global::std._Container_base0*);

	// Token: 0x060000A5 RID: 165 RVA: 0x0000A99C File Offset: 0x00009D9C
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern global::std.locale.id* {ctor}(global::std.locale.id*, uint);

	// Token: 0x060000A6 RID: 166 RVA: 0x0000A942 File Offset: 0x00009D42
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern void* @new(uint);

	// Token: 0x060000A7 RID: 167 RVA: 0x00007320 File Offset: 0x00006720
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.StdCall, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern global::ncm_context_s* ncm_context_new(global::ncm_launcher_s*);

	// Token: 0x060000A8 RID: 168 RVA: 0x0000A924 File Offset: 0x00009D24
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal static extern int __CxxQueryExceptionSize();

	// Token: 0x060000A9 RID: 169 RVA: 0x0000A936 File Offset: 0x00009D36
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern int __CxxDetectRethrow(void*);

	// Token: 0x060000AA RID: 170 RVA: 0x0000A9B4 File Offset: 0x00009DB4
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.StdCall, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern int CloseHandle(void*);

	// Token: 0x060000AB RID: 171 RVA: 0x00007344 File Offset: 0x00006744
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.StdCall, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern int ncm_device_id_iterator_has_next(global::ncm_device_id_iterator_s*);

	// Token: 0x060000AC RID: 172 RVA: 0x00007356 File Offset: 0x00006756
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.StdCall, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern uint ncm_device_get_uint_attribute(global::ncm_device_s*, sbyte*);

	// Token: 0x060000AD RID: 173 RVA: 0x0000A948 File Offset: 0x00009D48
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.StdCall, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern void _CxxThrowException(void*, global::_s__ThrowInfo*);

	// Token: 0x060000AE RID: 174 RVA: 0x00007362 File Offset: 0x00006762
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.StdCall, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern uint ncm_device_get_ip(global::ncm_device_s*);

	// Token: 0x060000AF RID: 175 RVA: 0x0000A9A8 File Offset: 0x00009DA8
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.StdCall, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern void* CreateEventW(global::_SECURITY_ATTRIBUTES*, int, int, ushort*);

	// Token: 0x060000B0 RID: 176 RVA: 0x0000735C File Offset: 0x0000675C
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.StdCall, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern void ncm_device_delete(global::ncm_device_s*);

	// Token: 0x060000B1 RID: 177 RVA: 0x0000A93C File Offset: 0x00009D3C
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern void __CxxUnregisterExceptionObject(void*, int);

	// Token: 0x060000B2 RID: 178 RVA: 0x00007332 File Offset: 0x00006732
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.StdCall, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern void ncm_context_delete(global::ncm_context_s*);

	// Token: 0x060000B3 RID: 179 RVA: 0x0000736E File Offset: 0x0000676E
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.StdCall, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern sbyte* ncm_device_get_string_attribute(global::ncm_device_s*, sbyte*);

	// Token: 0x060000B4 RID: 180 RVA: 0x0000732C File Offset: 0x0000672C
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.StdCall, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern int ncm_context_start(global::ncm_context_s*);

	// Token: 0x060000B5 RID: 181 RVA: 0x0000731A File Offset: 0x0000671A
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.StdCall, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern void ncm_launcher_set_uint_param(global::ncm_launcher_s*, sbyte*, uint);

	// Token: 0x060000B6 RID: 182 RVA: 0x0000A92A File Offset: 0x00009D2A
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern int __CxxExceptionFilter(void*, void*, int, void*);

	// Token: 0x060000B7 RID: 183 RVA: 0x0000A94E File Offset: 0x00009D4E
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern void delete[](void*);

	// Token: 0x060000B8 RID: 184 RVA: 0x0000734A File Offset: 0x0000674A
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.StdCall, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern uint ncm_device_id_iterator_get_next(global::ncm_device_id_iterator_s*);

	// Token: 0x060000B9 RID: 185 RVA: 0x00007374 File Offset: 0x00006774
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.StdCall, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern void ncm_device_id_iterator_delete(global::ncm_device_id_iterator_s*);

	// Token: 0x060000BA RID: 186 RVA: 0x0000737A File Offset: 0x0000677A
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.StdCall, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern uint ncm_context_get_local_device_id(global::ncm_context_s*);

	// Token: 0x060000BB RID: 187 RVA: 0x00007350 File Offset: 0x00006750
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.StdCall, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern global::ncm_device_s* ncm_device_new(global::ncm_context_s*, uint);

	// Token: 0x060000BC RID: 188 RVA: 0x00007338 File Offset: 0x00006738
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.StdCall, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern void ncm_launcher_delete(global::ncm_launcher_s*);

	// Token: 0x060000BD RID: 189 RVA: 0x00007380 File Offset: 0x00006780
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.StdCall, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal static extern uint ncm_version();

	// Token: 0x060000BE RID: 190 RVA: 0x0000A930 File Offset: 0x00009D30
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern int __CxxRegisterExceptionObject(void*, void*);

	// Token: 0x060000BF RID: 191 RVA: 0x0000A9A2 File Offset: 0x00009DA2
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.StdCall, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern int SetEvent(void*);

	// Token: 0x060000C0 RID: 192 RVA: 0x00007386 File Offset: 0x00006786
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.StdCall, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern int ncm_context_rrp_connection_request(global::ncm_context_s*, uint, ushort);

	// Token: 0x060000C1 RID: 193 RVA: 0x0000A9AE File Offset: 0x00009DAE
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.StdCall, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern uint WaitForSingleObject(void*, uint);

	// Token: 0x060000C2 RID: 194 RVA: 0x0000733E File Offset: 0x0000673E
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.StdCall, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern global::ncm_device_id_iterator_s* ncm_device_id_iterator_new(global::ncm_context_s*);

	// Token: 0x060000C3 RID: 195 RVA: 0x00007368 File Offset: 0x00006768
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.StdCall, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern int ncm_device_get_bool_attribute(global::ncm_device_s*, sbyte*);

	// Token: 0x060000C4 RID: 196 RVA: 0x00007314 File Offset: 0x00006714
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.StdCall, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern global::ncm_launcher_s* ncm_launcher_new();

	// Token: 0x060000C5 RID: 197 RVA: 0x0000A91E File Offset: 0x00009D1E
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern void* memmove(void*, void*, uint);

	// Token: 0x060000C6 RID: 198 RVA: 0x0000A978 File Offset: 0x00009D78
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern void _Xlength_error(sbyte*);

	// Token: 0x060000C7 RID: 199 RVA: 0x0000A97E File Offset: 0x00009D7E
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern void _Xout_of_range(sbyte*);

	// Token: 0x060000C8 RID: 200 RVA: 0x0000A984 File Offset: 0x00009D84
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal static extern void _Xbad_alloc();

	// Token: 0x060000C9 RID: 201 RVA: 0x0000A990 File Offset: 0x00009D90
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern sbyte* _Syserror_map(int);

	// Token: 0x060000CA RID: 202 RVA: 0x0000A996 File Offset: 0x00009D96
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern sbyte* _Winerror_map(int);

	// Token: 0x060000CB RID: 203 RVA: 0x00007326 File Offset: 0x00006726
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.StdCall, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern int ncm_context_register_callback(global::ncm_context_s*, sbyte*, uint, global::method, void*);

	// Token: 0x060000CC RID: 204 RVA: 0x00007302 File Offset: 0x00006702
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.StdCall, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern sbyte* inet_ntoa(global::in_addr);

	// Token: 0x060000CD RID: 205 RVA: 0x0000730E File Offset: 0x0000670E
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.StdCall, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal static extern uint ntohl(uint);

	// Token: 0x060000CE RID: 206 RVA: 0x00007308 File Offset: 0x00006708
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.StdCall, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal static extern ushort ntohs(ushort);

	// Token: 0x060000CF RID: 207 RVA: 0x0000A954 File Offset: 0x00009D54
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern void* new[](uint);

	// Token: 0x060000D0 RID: 208 RVA: 0x00007390 File Offset: 0x00006790
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged | global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]
	internal unsafe static extern global::PeerManager* {ctor}(global::PeerManager*, global::CommFeedBack*);

	// Token: 0x060000D1 RID: 209 RVA: 0x00007410 File Offset: 0x00006810
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged | global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]
	internal unsafe static extern void {dtor}(global::PeerManager*);

	// Token: 0x060000D2 RID: 210 RVA: 0x00007CE0 File Offset: 0x000070E0
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged | global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]
	internal unsafe static extern int InitPeer(global::PeerManager*, byte, uint, ushort, uint, ushort, ushort, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)] bool, byte*);

	// Token: 0x060000D3 RID: 211 RVA: 0x00008E20 File Offset: 0x00008220
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged | global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]
	internal unsafe static extern int StartLinkEstablishment(global::PeerManager*);

	// Token: 0x060000D4 RID: 212 RVA: 0x00008F30 File Offset: 0x00008330
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged | global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]
	internal unsafe static extern int StopLinkEstablishment(global::PeerManager*);

	// Token: 0x060000D5 RID: 213 RVA: 0x00008B20 File Offset: 0x00007F20
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged | global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]
	internal unsafe static extern int SendDeregistrationToAll(global::PeerManager*);

	// Token: 0x060000D6 RID: 214 RVA: 0x00007C40 File Offset: 0x00007040
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged | global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]
	internal unsafe static extern byte* GetPeerMapData(global::PeerManager*, uint*, byte*, byte*);

	// Token: 0x060000D7 RID: 215 RVA: 0x00007CA0 File Offset: 0x000070A0
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged | global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]
	internal unsafe static extern byte* GetSatelliteMapData(global::PeerManager*, uint*);

	// Token: 0x060000D8 RID: 216 RVA: 0x00007B60 File Offset: 0x00006F60
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged | global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]
	internal unsafe static extern void GetIntermediaryData(global::PeerManager*, uint*, uint*, ushort*, ushort*, uint*);

	// Token: 0x060000D9 RID: 217 RVA: 0x00008B80 File Offset: 0x00007F80
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged | global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]
	internal unsafe static extern int SendProxyConnectRequest(global::PeerManager*, uint, uint, ushort, byte, ushort*);

	// Token: 0x060000DA RID: 218 RVA: 0x0000641C File Offset: 0x0000581C
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged | global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]
	internal unsafe static extern void* _getFiberPtrId();

	// Token: 0x060000DB RID: 219 RVA: 0x000059DE File Offset: 0x00004DDE
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal static extern void _amsg_exit(int);

	// Token: 0x060000DC RID: 220 RVA: 0x00005C2B File Offset: 0x0000502B
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged | global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]
	internal static extern void __security_init_cookie();

	// Token: 0x060000DD RID: 221 RVA: 0x0000A9BA File Offset: 0x00009DBA
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.StdCall, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal static extern void Sleep(uint);

	// Token: 0x060000DE RID: 222 RVA: 0x0000A95A File Offset: 0x00009D5A
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal static extern void _cexit();

	// Token: 0x060000DF RID: 223 RVA: 0x0000A960 File Offset: 0x00009D60
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern int __FrameUnwindFilter(global::_EXCEPTION_POINTERS*);

	// Token: 0x060000E0 RID: 224 RVA: 0x00005DCC File Offset: 0x000051CC
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal static extern void terminate();

	// Token: 0x04000001 RID: 1 RVA: 0x00019F48 File Offset: 0x00018F48
	internal static global::$_s__RTTIBaseClassArray$_extraBytes_4 ??_R2CallbackCrossAppdomain@@8;

	// Token: 0x04000002 RID: 2 RVA: 0x00019F50 File Offset: 0x00018F50
	internal static global::_s__RTTIClassHierarchyDescriptor ??_R3CallbackCrossAppdomain@@8;

	// Token: 0x04000003 RID: 3 RVA: 0x00019F2C File Offset: 0x00018F2C
	internal static global::_s__RTTIBaseClassDescriptor2 ??_R1A@?0A@EA@CallbackCrossAppdomain@@8;

	// Token: 0x04000004 RID: 4 RVA: 0x0001C0FC File Offset: 0x0001A4FC
	internal static global::$_TypeDescriptor$_extraBytes_29 ??_R0?AVCallbackCrossAppdomain@@@8;

	// Token: 0x04000005 RID: 5 RVA: 0x00019F60 File Offset: 0x00018F60
	internal static global::_s__RTTICompleteObjectLocator ??_R4CallbackCrossAppdomain@@6B@;

	// Token: 0x04000006 RID: 6 RVA: 0x0001C004 File Offset: 0x0001A404
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY01Q6AXXZ ??_7CallbackCrossAppdomain@@6B@;

	// Token: 0x04000007 RID: 7 RVA: 0x0000B424 File Offset: 0x0000A424
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY07$$CBD ??_C@_07DCLBNMLN@generic?$AA@;

	// Token: 0x04000008 RID: 8 RVA: 0x0000B42C File Offset: 0x0000A42C
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0O@$$CBD ??_C@_0O@BFJCFAAK@unknown?5error?$AA@;

	// Token: 0x04000009 RID: 9 RVA: 0x0000B43C File Offset: 0x0000A43C
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY08$$CBD ??_C@_08LLGCOLLL@iostream?$AA@;

	// Token: 0x0400000A RID: 10 RVA: 0x0000B448 File Offset: 0x0000A448
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0BG@$$CBD ??_C@_0BG@PADBLCHM@iostream?5stream?5error?$AA@;

	// Token: 0x0400000B RID: 11 RVA: 0x0000B460 File Offset: 0x0000A460
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY06$$CBD ??_C@_06FHFOAHML@system?$AA@;

	// Token: 0x0400000C RID: 12 RVA: 0x0000B2DC File Offset: 0x0000A2DC
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0BA@$$CBD ??_C@_0BA@HGEGKAKG@intermediary_ip?$AA@;

	// Token: 0x0400000D RID: 13 RVA: 0x0000B2EC File Offset: 0x0000A2EC
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0BC@$$CBD ??_C@_0BC@FHCHHMDH@intermediary_port?$AA@;

	// Token: 0x0400000E RID: 14 RVA: 0x0000B300 File Offset: 0x0000A300
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0M@$$CBD ??_C@_0M@KJEGLGCO@device_type?$AA@;

	// Token: 0x0400000F RID: 15 RVA: 0x0000B30C File Offset: 0x0000A30C
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0P@$$CBD ??_C@_0P@KBBLMGIL@device_version?$AA@;

	// Token: 0x04000010 RID: 16 RVA: 0x0000B31C File Offset: 0x0000A31C
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY09$$CBD ??_C@_09ILJBNCDK@system_id?$AA@;

	// Token: 0x04000011 RID: 17 RVA: 0x0000B328 File Offset: 0x0000A328
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY07$$CBD ??_C@_07LCLEEJMB@site_id?$AA@;

	// Token: 0x04000012 RID: 18 RVA: 0x0000B330 File Offset: 0x0000A330
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0BB@$$CBD ??_C@_0BB@GJPEBHLM@redundancy_group?$AA@;

	// Token: 0x04000013 RID: 19 RVA: 0x0000B344 File Offset: 0x0000A344
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY07$$CBD ??_C@_07OBNBLOPK@peer_id?$AA@;

	// Token: 0x04000014 RID: 20 RVA: 0x0000B34C File Offset: 0x0000A34C
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY09$$CBD ??_C@_09CEHJOGG@base_port?$AA@;

	// Token: 0x04000015 RID: 21 RVA: 0x0000B358 File Offset: 0x0000A358
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0N@$$CBD ??_C@_0N@BDFJOGL@device_model?$AA@;

	// Token: 0x04000016 RID: 22 RVA: 0x0000B368 File Offset: 0x0000A368
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0BG@$$CBD ??_C@_0BG@PFOHBEAL@onDeviceStatusChanged?$AA@;

	// Token: 0x04000017 RID: 23 RVA: 0x0000B384 File Offset: 0x0000A384
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0CB@$$CBD ??_C@_0CB@DBMELCLL@onTrunkedControllerStatusChanged@;

	// Token: 0x04000018 RID: 24 RVA: 0x0000B3AC File Offset: 0x0000A3AC
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0BB@$$CBD ??_C@_0BB@FGMHEJBE@onRoleAssignment?$AA@;

	// Token: 0x04000019 RID: 25 RVA: 0x0000B3C4 File Offset: 0x0000A3C4
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0BI@$$CBD ??_C@_0BI@EEJJFHEG@onRRPConnectionResponse?$AA@;

	// Token: 0x0400001A RID: 26 RVA: 0x0000B3E0 File Offset: 0x0000A3E0
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY08$$CBD ??_C@_08ECDLIGGO@ncm_port?$AA@;

	// Token: 0x0400001B RID: 27 RVA: 0x0000B3EC File Offset: 0x0000A3EC
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0BE@$$CBD ??_C@_0BE@HOIBHHNG@active_intermediary?$AA@;

	// Token: 0x0400001C RID: 28 RVA: 0x0000B400 File Offset: 0x0000A400
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0O@$$CBD ??_C@_0O@GDPEAHKI@serial_number?$AA@;

	// Token: 0x0400001D RID: 29 RVA: 0x0000B2A0 File Offset: 0x0000A2A0
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0BA@$$CBD ??_C@_0BA@JFNIOLAK@string?5too?5long?$AA@;

	// Token: 0x0400001E RID: 30 RVA: 0x0000B2B0 File Offset: 0x0000A2B0
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0BI@$$CBD ??_C@_0BI@CFPLBAOH@invalid?5string?5position?$AA@;

	// Token: 0x0400001F RID: 31 RVA: 0x0000B2C8 File Offset: 0x0000A2C8
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0BD@$$CBD ??_C@_0BD@OLBABOEK@vector?$DMT?$DO?5too?5long?$AA@;

	// Token: 0x04000020 RID: 32 RVA: 0x0000B410 File Offset: 0x0000A410
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0BB@$$CBD ??_C@_0BB@MOGOBHAF@list?$DMT?$DO?5too?5long?$AA@;

	// Token: 0x04000021 RID: 33 RVA: 0x00019F98 File Offset: 0x00018F98
	internal static global::_s__RTTIClassHierarchyDescriptor ??_R3error_category@std@@8;

	// Token: 0x04000022 RID: 34 RVA: 0x00019F74 File Offset: 0x00018F74
	internal static global::_s__RTTIBaseClassDescriptor2 ??_R1A@?0A@EA@error_category@std@@8;

	// Token: 0x04000023 RID: 35 RVA: 0x0001A084 File Offset: 0x00019084
	internal static global::_s__RTTIClassHierarchyDescriptor ??_R3_System_error_category@std@@8;

	// Token: 0x04000024 RID: 36 RVA: 0x0001A074 File Offset: 0x00019074
	internal static global::$_s__RTTIBaseClassArray$_extraBytes_12 ??_R2_System_error_category@std@@8;

	// Token: 0x04000025 RID: 37 RVA: 0x0001C02C File Offset: 0x0001A42C
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY06Q6AXXZ ??_7_Generic_error_category@std@@6B@;

	// Token: 0x04000026 RID: 38 RVA: 0x0001C0C8 File Offset: 0x0001A4C8
	internal static global::std._Iostream_error_category ?_Iostream_object@?$_Error_objects@H@std@@2V_Iostream_error_category@2@A;

	// Token: 0x04000027 RID: 39 RVA: 0x0000B1F8 File Offset: 0x0000A1F8
	internal static global::method ?_Iostream_object$initializer$@?$_Error_objects@H@std@@2P6MXXZA;

	// Token: 0x04000028 RID: 40 RVA: 0x0001C853 File Offset: 0x0001AC53
	internal static global::std.piecewise_construct_t piecewise_construct;

	// Token: 0x04000029 RID: 41 RVA: 0x00019FF4 File Offset: 0x00018FF4
	internal static global::_s__RTTICompleteObjectLocator ??_R4_Generic_error_category@std@@6B@;

	// Token: 0x0400002A RID: 42 RVA: 0x0001C174 File Offset: 0x0001A574
	internal static global::$_TypeDescriptor$_extraBytes_35 ??_R0?AV_Iostream_error_category@std@@@8;

	// Token: 0x0400002B RID: 43 RVA: 0x00019FBC File Offset: 0x00018FBC
	internal static global::_s__RTTIBaseClassDescriptor2 ??_R1A@?0A@EA@_Generic_error_category@std@@8;

	// Token: 0x0400002C RID: 44 RVA: 0x0001A008 File Offset: 0x00019008
	internal static global::_s__RTTIBaseClassDescriptor2 ??_R1A@?0A@EA@_Iostream_error_category@std@@8;

	// Token: 0x0400002D RID: 45 RVA: 0x00019FA8 File Offset: 0x00018FA8
	internal static global::_s__RTTICompleteObjectLocator ??_R4error_category@std@@6B@;

	// Token: 0x0400002E RID: 46 RVA: 0x0001A044 File Offset: 0x00019044
	internal static global::_s__RTTICompleteObjectLocator ??_R4_Iostream_error_category@std@@6B@;

	// Token: 0x0400002F RID: 47 RVA: 0x0001C852 File Offset: 0x0001AC52
	internal static global::std.allocator_arg_t allocator_arg;

	// Token: 0x04000030 RID: 48 RVA: 0x0001C854 File Offset: 0x0001AC54
	internal static global::std.locale.id ?id@?$num_put@GV?$back_insert_iterator@V?$basic_string@GU?$char_traits@G@std@@V?$allocator@G@2@@std@@@std@@@std@@2V0locale@2@A;

	// Token: 0x04000031 RID: 49 RVA: 0x0000B204 File Offset: 0x0000A204
	internal static global::method ?id$initializer$@?$num_put@GV?$back_insert_iterator@V?$basic_string@GU?$char_traits@G@std@@V?$allocator@G@2@@std@@@std@@@std@@2P6MXXZA;

	// Token: 0x04000032 RID: 50 RVA: 0x0001C1A0 File Offset: 0x0001A5A0
	internal static global::$_TypeDescriptor$_extraBytes_33 ??_R0?AV_System_error_category@std@@@8;

	// Token: 0x04000033 RID: 51 RVA: 0x0001C0CC File Offset: 0x0001A4CC
	internal static global::std._System_error_category ?_System_object@?$_Error_objects@H@std@@2V_System_error_category@2@A;

	// Token: 0x04000034 RID: 52 RVA: 0x0000B1FC File Offset: 0x0000A1FC
	internal static global::method ?_System_object$initializer$@?$_Error_objects@H@std@@2P6MXXZA;

	// Token: 0x04000035 RID: 53 RVA: 0x0001C851 File Offset: 0x0001AC51
	internal static global::std._Ignore ignore;

	// Token: 0x04000036 RID: 54 RVA: 0x00019F90 File Offset: 0x00018F90
	internal static global::$_s__RTTIBaseClassArray$_extraBytes_4 ??_R2error_category@std@@8;

	// Token: 0x04000037 RID: 55 RVA: 0x0001A058 File Offset: 0x00019058
	internal static global::_s__RTTIBaseClassDescriptor2 ??_R1A@?0A@EA@_System_error_category@std@@8;

	// Token: 0x04000038 RID: 56 RVA: 0x0001A034 File Offset: 0x00019034
	internal static global::_s__RTTIClassHierarchyDescriptor ??_R3_Iostream_error_category@std@@8;

	// Token: 0x04000039 RID: 57 RVA: 0x0001C0C4 File Offset: 0x0001A4C4
	internal static global::std._Generic_error_category ?_Generic_object@?$_Error_objects@H@std@@2V_Generic_error_category@2@A;

	// Token: 0x0400003A RID: 58 RVA: 0x0000B1F4 File Offset: 0x0000A1F4
	internal static global::method ?_Generic_object$initializer$@?$_Error_objects@H@std@@2P6MXXZA;

	// Token: 0x0400003B RID: 59 RVA: 0x0001C064 File Offset: 0x0001A464
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY06Q6AXXZ ??_7_System_error_category@std@@6B@;

	// Token: 0x0400003C RID: 60 RVA: 0x0001C124 File Offset: 0x0001A524
	internal static global::$_TypeDescriptor$_extraBytes_25 ??_R0?AVerror_category@std@@@8;

	// Token: 0x0400003D RID: 61 RVA: 0x0001C048 File Offset: 0x0001A448
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY06Q6AXXZ ??_7_Iostream_error_category@std@@6B@;

	// Token: 0x0400003E RID: 62 RVA: 0x0001C010 File Offset: 0x0001A410
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY06Q6AXXZ ??_7error_category@std@@6B@;

	// Token: 0x0400003F RID: 63 RVA: 0x0001A094 File Offset: 0x00019094
	internal static global::_s__RTTICompleteObjectLocator ??_R4_System_error_category@std@@6B@;

	// Token: 0x04000040 RID: 64 RVA: 0x0001C148 File Offset: 0x0001A548
	internal static global::$_TypeDescriptor$_extraBytes_34 ??_R0?AV_Generic_error_category@std@@@8;

	// Token: 0x04000041 RID: 65 RVA: 0x0001C850 File Offset: 0x0001AC50
	internal static global::std._Tuple_alloc_t _Tuple_alloc;

	// Token: 0x04000042 RID: 66 RVA: 0x0001C490 File Offset: 0x0001A890
	internal static global::std.locale.id ?id@?$num_put@DV?$back_insert_iterator@V?$basic_string@DU?$char_traits@D@std@@V?$allocator@D@2@@std@@@std@@@std@@2V0locale@2@A;

	// Token: 0x04000043 RID: 67 RVA: 0x0000B200 File Offset: 0x0000A200
	internal static global::method ?id$initializer$@?$num_put@DV?$back_insert_iterator@V?$basic_string@DU?$char_traits@D@std@@V?$allocator@D@2@@std@@@std@@@std@@2P6MXXZA;

	// Token: 0x04000044 RID: 68 RVA: 0x00019FD8 File Offset: 0x00018FD8
	internal static global::$_s__RTTIBaseClassArray$_extraBytes_8 ??_R2_Generic_error_category@std@@8;

	// Token: 0x04000045 RID: 69 RVA: 0x00019FE4 File Offset: 0x00018FE4
	internal static global::_s__RTTIClassHierarchyDescriptor ??_R3_Generic_error_category@std@@8;

	// Token: 0x04000046 RID: 70 RVA: 0x0001A024 File Offset: 0x00019024
	internal static global::$_s__RTTIBaseClassArray$_extraBytes_12 ??_R2_Iostream_error_category@std@@8;

	// Token: 0x04000047 RID: 71 RVA: 0x0000B380 File Offset: 0x0000A380
	public unsafe static int** __unep@?onDeviceStatusChanged@?A0x174d99bf@LEAdaptor@@$$FYGXPAXPBX@Z;

	// Token: 0x04000048 RID: 72 RVA: 0x0000B3A8 File Offset: 0x0000A3A8
	public unsafe static int** __unep@?onTCStautsChanged@?A0x174d99bf@LEAdaptor@@$$FYGXPAXPBX@Z;

	// Token: 0x04000049 RID: 73 RVA: 0x0000B3C0 File Offset: 0x0000A3C0
	public unsafe static int** __unep@?OnRoleAssignment@?A0x174d99bf@LEAdaptor@@$$FYGXPAXPBX@Z;

	// Token: 0x0400004A RID: 74 RVA: 0x0000B3DC File Offset: 0x0000A3DC
	public unsafe static int** __unep@?OnRRPConnectionResponse@?A0x174d99bf@LEAdaptor@@$$FYGXPAXPBX@Z;

	// Token: 0x0400004B RID: 75 RVA: 0x0001A0DC File Offset: 0x000190DC
	internal static global::_s__RTTIBaseClassDescriptor2 ??_R1A@?0A@EA@MCallBack@@8;

	// Token: 0x0400004C RID: 76 RVA: 0x0001C9C1 File Offset: 0x0001ADC1
	internal static global::std.piecewise_construct_t piecewise_construct;

	// Token: 0x0400004D RID: 77 RVA: 0x0001C9C0 File Offset: 0x0001ADC0
	internal static global::std.allocator_arg_t allocator_arg;

	// Token: 0x0400004E RID: 78 RVA: 0x0001C0D4 File Offset: 0x0001A4D4
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY01Q6AXXZ ??_7MCallBack@@6B@;

	// Token: 0x0400004F RID: 79 RVA: 0x0001A104 File Offset: 0x00019104
	internal static global::_s__RTTIClassHierarchyDescriptor ??_R3MCallBack@@8;

	// Token: 0x04000050 RID: 80 RVA: 0x0001A0C4 File Offset: 0x000190C4
	internal static global::$_s__RTTIBaseClassArray$_extraBytes_4 ??_R2CommFeedBack@@8;

	// Token: 0x04000051 RID: 81 RVA: 0x0001A0F8 File Offset: 0x000190F8
	internal static global::$_s__RTTIBaseClassArray$_extraBytes_8 ??_R2MCallBack@@8;

	// Token: 0x04000052 RID: 82 RVA: 0x0001A114 File Offset: 0x00019114
	internal static global::_s__RTTICompleteObjectLocator ??_R4MCallBack@@6B@;

	// Token: 0x04000053 RID: 83 RVA: 0x0001C1CC File Offset: 0x0001A5CC
	internal static global::$_TypeDescriptor$_extraBytes_19 ??_R0?AVCommFeedBack@@@8;

	// Token: 0x04000054 RID: 84 RVA: 0x0001C1E8 File Offset: 0x0001A5E8
	internal static global::$_TypeDescriptor$_extraBytes_16 ??_R0?AVMCallBack@@@8;

	// Token: 0x04000055 RID: 85 RVA: 0x0001A0CC File Offset: 0x000190CC
	internal static global::_s__RTTIClassHierarchyDescriptor ??_R3CommFeedBack@@8;

	// Token: 0x04000056 RID: 86 RVA: 0x0001A0A8 File Offset: 0x000190A8
	internal static global::_s__RTTIBaseClassDescriptor2 ??_R1A@?0A@EA@CommFeedBack@@8;

	// Token: 0x04000057 RID: 87 RVA: 0x0001CBB5 File Offset: 0x0001AFB5
	internal static global::std.piecewise_construct_t piecewise_construct;

	// Token: 0x04000058 RID: 88 RVA: 0x0001CBB4 File Offset: 0x0001AFB4
	internal static global::std.allocator_arg_t allocator_arg;

	// Token: 0x04000059 RID: 89 RVA: 0x0001CD05 File Offset: 0x0001B105
	internal static global::std.piecewise_construct_t piecewise_construct;

	// Token: 0x0400005A RID: 90 RVA: 0x0001CD04 File Offset: 0x0001B104
	internal static global::std.allocator_arg_t allocator_arg;

	// Token: 0x0400005B RID: 91 RVA: 0x0000B47C File Offset: 0x0000A47C
	internal static global::__s_GUID _GUID_90f1a06e_7712_4762_86b5_7a5eba6bdb02;

	// Token: 0x0400005C RID: 92 RVA: 0x0000B4AC File Offset: 0x0000A4AC
	internal static global::__s_GUID _GUID_cb2f6722_ab3a_11d2_9c40_00c04fa30a3e;

	// Token: 0x0400005D RID: 93 RVA: 0x0000B208 File Offset: 0x0000A208
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY00Q6MPBXXZ __xc_mp_z;

	// Token: 0x0400005E RID: 94
	[global::System.Runtime.CompilerServices.FixedAddressValueType]
	internal static int ?Uninitialized@CurrentDomain@<CrtImplementationDetails>@@$$Q2HA;

	// Token: 0x0400005F RID: 95 RVA: 0x0000B1D4 File Offset: 0x0000A1D4
	internal static global::method ?Uninitialized$initializer$@CurrentDomain@<CrtImplementationDetails>@@$$Q2P6MXXZA;

	// Token: 0x04000060 RID: 96 RVA: 0x0000B20C File Offset: 0x0000A20C
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY00Q6MPBXXZ __xi_vt_a;

	// Token: 0x04000061 RID: 97
	[global::System.Runtime.CompilerServices.FixedAddressValueType]
	internal static global::<CrtImplementationDetails>.Progress.State ?InitializedPerAppDomain@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A;

	// Token: 0x04000062 RID: 98 RVA: 0x0000B1E8 File Offset: 0x0000A1E8
	internal static global::method ?InitializedPerAppDomain$initializer$@CurrentDomain@<CrtImplementationDetails>@@$$Q2P6MXXZA;

	// Token: 0x04000063 RID: 99
	[global::System.Runtime.CompilerServices.FixedAddressValueType]
	internal static bool ?IsDefaultDomain@CurrentDomain@<CrtImplementationDetails>@@$$Q2_NA;

	// Token: 0x04000064 RID: 100 RVA: 0x0000B1D8 File Offset: 0x0000A1D8
	internal static global::method ?IsDefaultDomain$initializer$@CurrentDomain@<CrtImplementationDetails>@@$$Q2P6MXXZA;

	// Token: 0x04000065 RID: 101 RVA: 0x0000B1CC File Offset: 0x0000A1CC
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY00Q6MPBXXZ __xc_ma_a;

	// Token: 0x04000066 RID: 102
	[global::System.Runtime.CompilerServices.FixedAddressValueType]
	internal static global::<CrtImplementationDetails>.Progress.State ?InitializedNative@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A;

	// Token: 0x04000067 RID: 103 RVA: 0x0000B1E0 File Offset: 0x0000A1E0
	internal static global::method ?InitializedNative$initializer$@CurrentDomain@<CrtImplementationDetails>@@$$Q2P6MXXZA;

	// Token: 0x04000068 RID: 104
	[global::System.Runtime.CompilerServices.FixedAddressValueType]
	internal static int ?Initialized@CurrentDomain@<CrtImplementationDetails>@@$$Q2HA;

	// Token: 0x04000069 RID: 105 RVA: 0x0000B1D0 File Offset: 0x0000A1D0
	internal static global::method ?Initialized$initializer$@CurrentDomain@<CrtImplementationDetails>@@$$Q2P6MXXZA;

	// Token: 0x0400006A RID: 106 RVA: 0x0000B1EC File Offset: 0x0000A1EC
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY00Q6MPBXXZ __xc_ma_z;

	// Token: 0x0400006B RID: 107
	[global::System.Runtime.CompilerServices.FixedAddressValueType]
	internal static global::<CrtImplementationDetails>.Progress.State ?InitializedVtables@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A;

	// Token: 0x0400006C RID: 108 RVA: 0x0000B1DC File Offset: 0x0000A1DC
	internal static global::method ?InitializedVtables$initializer$@CurrentDomain@<CrtImplementationDetails>@@$$Q2P6MXXZA;

	// Token: 0x0400006D RID: 109 RVA: 0x0000B210 File Offset: 0x0000A210
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY00Q6MPBXXZ __xi_vt_z;

	// Token: 0x0400006E RID: 110 RVA: 0x0000B49C File Offset: 0x0000A49C
	internal static global::__s_GUID _GUID_cb2f6723_ab3a_11d2_9c40_00c04fa30a3e;

	// Token: 0x0400006F RID: 111
	[global::System.Runtime.CompilerServices.FixedAddressValueType]
	internal static global::<CrtImplementationDetails>.Progress.State ?InitializedPerProcess@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A;

	// Token: 0x04000070 RID: 112 RVA: 0x0000B1E4 File Offset: 0x0000A1E4
	internal static global::method ?InitializedPerProcess$initializer$@CurrentDomain@<CrtImplementationDetails>@@$$Q2P6MXXZA;

	// Token: 0x04000071 RID: 113 RVA: 0x0001D03F File Offset: 0x0001B43F
	internal static bool ?InitializedPerProcess@DefaultDomain@<CrtImplementationDetails>@@2_NA;

	// Token: 0x04000072 RID: 114 RVA: 0x0001D03C File Offset: 0x0001B43C
	internal static bool ?Entered@DefaultDomain@<CrtImplementationDetails>@@2_NA;

	// Token: 0x04000073 RID: 115 RVA: 0x0001D03D File Offset: 0x0001B43D
	internal static bool ?InitializedNative@DefaultDomain@<CrtImplementationDetails>@@2_NA;

	// Token: 0x04000074 RID: 116 RVA: 0x0001D038 File Offset: 0x0001B438
	internal static int ?Count@AllDomains@<CrtImplementationDetails>@@2HA;

	// Token: 0x04000075 RID: 117 RVA: 0x0001C0F0 File Offset: 0x0001A4F0
	internal static global::<CrtImplementationDetails>.TriBool.State ?hasNative@DefaultDomain@<CrtImplementationDetails>@@0W4State@TriBool@2@A;

	// Token: 0x04000076 RID: 118 RVA: 0x0001C0EC File Offset: 0x0001A4EC
	internal static global::<CrtImplementationDetails>.TriBool.State ?hasPerProcess@DefaultDomain@<CrtImplementationDetails>@@0W4State@TriBool@2@A;

	// Token: 0x04000077 RID: 119 RVA: 0x0001D03E File Offset: 0x0001B43E
	internal static bool ?InitializedNativeFromCCTOR@DefaultDomain@<CrtImplementationDetails>@@2_NA;

	// Token: 0x04000078 RID: 120 RVA: 0x0000B1F0 File Offset: 0x0000A1F0
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY00Q6MPBXXZ __xc_mp_a;

	// Token: 0x04000079 RID: 121 RVA: 0x0000B48C File Offset: 0x0000A48C
	internal static global::__s_GUID _GUID_90f1a06c_7712_4762_86b5_7a5eba6bdb02;

	// Token: 0x0400007A RID: 122 RVA: 0x0000B4BC File Offset: 0x0000A4BC
	public unsafe static int** __unep@?DoNothing@DefaultDomain@<CrtImplementationDetails>@@$$FCGJPAX@Z;

	// Token: 0x0400007B RID: 123 RVA: 0x0000B4C0 File Offset: 0x0000A4C0
	public unsafe static int** __unep@?_UninitializeDefaultDomain@LanguageSupport@<CrtImplementationDetails>@@$$FCGJPAX@Z;

	// Token: 0x0400007C RID: 124
	[global::System.Runtime.CompilerServices.FixedAddressValueType]
	internal static uint __exit_list_size_app_domain;

	// Token: 0x0400007D RID: 125
	[global::System.Runtime.CompilerServices.FixedAddressValueType]
	internal unsafe static global::method* __onexitbegin_app_domain;

	// Token: 0x0400007E RID: 126 RVA: 0x0001D14C File Offset: 0x0001B54C
	internal static uint __exit_list_size;

	// Token: 0x0400007F RID: 127
	[global::System.Runtime.CompilerServices.FixedAddressValueType]
	internal unsafe static global::method* __onexitend_app_domain;

	// Token: 0x04000080 RID: 128 RVA: 0x0001D144 File Offset: 0x0001B544
	internal unsafe static global::method* __onexitbegin_m;

	// Token: 0x04000081 RID: 129 RVA: 0x0001D148 File Offset: 0x0001B548
	internal unsafe static global::method* __onexitend_m;

	// Token: 0x04000082 RID: 130
	[global::System.Runtime.CompilerServices.FixedAddressValueType]
	internal unsafe static void* ?_lock@AtExitLock@<CrtImplementationDetails>@@$$Q0PAXA;

	// Token: 0x04000083 RID: 131
	[global::System.Runtime.CompilerServices.FixedAddressValueType]
	internal static int ?_ref_count@AtExitLock@<CrtImplementationDetails>@@$$Q0HA;

	// Token: 0x04000084 RID: 132 RVA: 0x0000B46C File Offset: 0x0000A46C
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY01Q6AXXZ ??_7type_info@@6B@;

	// Token: 0x04000085 RID: 133 RVA: 0x0000B1B8 File Offset: 0x0000A1B8
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0A@P6AXXZ __xc_z;

	// Token: 0x04000086 RID: 134 RVA: 0x0000B1B4 File Offset: 0x0000A1B4
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0A@P6AXXZ __xc_a;

	// Token: 0x04000087 RID: 135 RVA: 0x0000B1BC File Offset: 0x0000A1BC
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0A@P6AHXZ __xi_a;

	// Token: 0x04000088 RID: 136 RVA: 0x0001D180 File Offset: 0x0001B580
	internal static volatile global::__enative_startup_state __native_startup_state;

	// Token: 0x04000089 RID: 137 RVA: 0x0000B1C8 File Offset: 0x0000A1C8
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0A@P6AHXZ __xi_z;

	// Token: 0x0400008A RID: 138 RVA: 0x0001D17C File Offset: 0x0001B57C
	internal unsafe static volatile void* __native_startup_lock;

	// Token: 0x0400008B RID: 139 RVA: 0x0001C0E0 File Offset: 0x0001A4E0
	internal static volatile uint __native_dllmain_reason;
}
