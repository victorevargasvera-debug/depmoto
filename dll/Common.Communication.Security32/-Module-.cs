using System;
using System.Collections.Generic;
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
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.Communication.Security;
using std;

// Token: 0x02000001 RID: 1
internal class <Module>
{
	// Token: 0x06000001 RID: 1 RVA: 0x0001F2E4 File Offset: 0x0001E6E4
	internal unsafe static global::bio_method_st* BIO_s_rudp()
	{
		return ref global::<Module>.?A0xc5c9e7d8.methods_rudpp;
	}

	// Token: 0x06000002 RID: 2 RVA: 0x0001F2F8 File Offset: 0x0001E6F8
	internal unsafe static int rudp_new(global::bio_st* b)
	{
		global::bio_rudp_data_st* ptr = global::<Module>.CRYPTO_malloc(28, (sbyte*)(&global::<Module>.??_C@_0BG@LCDFPEM@OpenSSLBioAdapter?4cpp?$AA@), 111);
		if (ptr == null)
		{
			object[] args = new object[0];
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("Security: rudp_new: malloc failed!!", args);
			return 0;
		}
		*(int*)ptr = 0;
		*(int*)(ptr + 4 / sizeof(global::bio_rudp_data_st)) = 0;
		*(int*)(ptr + 12 / sizeof(global::bio_rudp_data_st)) = 0;
		*(int*)(ptr + 8 / sizeof(global::bio_rudp_data_st)) = 0;
		*(int*)(b + 32 / sizeof(global::bio_st)) = ptr;
		*(int*)(b + 12 / sizeof(global::bio_st)) = 0;
		*(int*)(b + 28 / sizeof(global::bio_st)) = 0;
		*(int*)(b + 20 / sizeof(global::bio_st)) = 0;
		object[] args2 = new object[0];
		global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("Security: rudp_new: done", args2);
		return 1;
	}

	// Token: 0x06000003 RID: 3 RVA: 0x0001F37C File Offset: 0x0001E77C
	internal unsafe static int rudp_free(global::bio_st* b)
	{
		if (b == null)
		{
			return 0;
		}
		global::bio_rudp_data_st* ptr = *(int*)(b + 32 / sizeof(global::bio_st));
		if (ptr != null)
		{
			uint num = (uint)(*(int*)ptr);
			if (num != 0U)
			{
				global::<Module>.CRYPTO_free(num);
			}
			global::<Module>.CRYPTO_free((void*)ptr);
		}
		if (*(int*)(b + 16 / sizeof(global::bio_st)) != 0)
		{
			if (*(int*)(b + 12 / sizeof(global::bio_st)) != 0)
			{
				object[] args = new object[0];
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("Security: rudp_free: calling close_pipe", args);
				int num2 = *(int*)(ptr + 20 / sizeof(global::bio_rudp_data_st));
				object obj = calli(System.Int32 modopt(System.Runtime.CompilerServices.CallConvCdecl)(System.Void*), *num2, *(num2 + 16));
			}
			*(int*)(b + 12 / sizeof(global::bio_st)) = 0;
			*(int*)(b + 20 / sizeof(global::bio_st)) = 0;
		}
		return 1;
	}

	// Token: 0x06000004 RID: 4 RVA: 0x0001F3F4 File Offset: 0x0001E7F4
	internal unsafe static int rudp_read(global::bio_st* b, sbyte* @out, int outl)
	{
		global::bio_rudp_data_st* ptr = *(int*)(b + 32 / sizeof(global::bio_st));
		if (@out == null)
		{
			object[] args = new object[0];
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("Security: rudp_read: out == NULL!!\n", args);
			return -1;
		}
		uint num = (uint)(*(int*)(ptr + 8 / sizeof(global::bio_rudp_data_st)));
		if (num != 0U)
		{
			uint num2 = (uint)((outl < (int)num) ? outl : ((int)num));
			cpblk(@out, *(int*)ptr + *(int*)(ptr + 12 / sizeof(global::bio_rudp_data_st)), num2);
			*(int*)(ptr + 8 / sizeof(global::bio_rudp_data_st)) = *(int*)(ptr + 8 / sizeof(global::bio_rudp_data_st)) - (int)num2;
			*(int*)(ptr + 12 / sizeof(global::bio_rudp_data_st)) = *(int*)(ptr + 12 / sizeof(global::bio_rudp_data_st)) + (int)num2;
			object[] args2 = new object[]
			{
				outl,
				(uint)(*(int*)(ptr + 8 / sizeof(global::bio_rudp_data_st))),
				(uint)(*(int*)(ptr + 12 / sizeof(global::bio_rudp_data_st)))
			};
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteSensitive("Security: rudp_read: HasLocalData. outl={0}, rx_len={1}, rx_offset={2}\n", args2);
			return num2;
		}
		int num4;
		if (*(byte*)(ptr + 24 / sizeof(global::bio_rudp_data_st)) != 0)
		{
			int num3 = *(int*)(ptr + 20 / sizeof(global::bio_rudp_data_st));
			num4 = calli(System.Int32 modopt(System.Runtime.CompilerServices.CallConvCdecl)(System.Void*,System.SByte modopt(System.Runtime.CompilerServices.IsSignUnspecifiedByte)*,System.Int32,System.Int32), *num3, *(int*)ptr, outl, 0, *(num3 + 8));
		}
		else
		{
			int num3 = *(int*)(ptr + 20 / sizeof(global::bio_rudp_data_st));
			num4 = calli(System.Int32 modopt(System.Runtime.CompilerServices.CallConvCdecl)(System.Void*,System.SByte modopt(System.Runtime.CompilerServices.IsSignUnspecifiedByte)*,System.Int32,System.Int32), *num3, *(int*)ptr, *(int*)(ptr + 4 / sizeof(global::bio_rudp_data_st)), 0, *(num3 + 8));
		}
		global::<Module>.BIO_clear_flags(b, 15);
		if (num4 > 0)
		{
			*(int*)(ptr + 8 / sizeof(global::bio_rudp_data_st)) = num4;
			*(int*)(ptr + 12 / sizeof(global::bio_rudp_data_st)) = 0;
			int num5 = (outl < num4) ? outl : num4;
			cpblk(@out, *(int*)ptr, num5);
			*(int*)(ptr + 8 / sizeof(global::bio_rudp_data_st)) = *(int*)(ptr + 8 / sizeof(global::bio_rudp_data_st)) - num5;
			*(int*)(ptr + 12 / sizeof(global::bio_rudp_data_st)) = *(int*)(ptr + 12 / sizeof(global::bio_rudp_data_st)) + num5;
			return num5;
		}
		object[] args3 = new object[]
		{
			num4,
			outl
		};
		global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("Security: rudp_read: failed. ret={0}, outl={1}", args3);
		return -1;
	}

	// Token: 0x06000005 RID: 5 RVA: 0x0001FAC4 File Offset: 0x0001EEC4
	internal unsafe static int rudp_write(global::bio_st* b, sbyte* @in, int inl)
	{
		int num = *(int*)(b + 32 / sizeof(global::bio_st));
		global::<Module>.BIO_clear_flags(b, 15);
		int num2 = *(num + 20);
		int num3 = calli(System.Int32 modopt(System.Runtime.CompilerServices.CallConvCdecl)(System.Void*,System.SByte modopt(System.Runtime.CompilerServices.IsSignUnspecifiedByte) modopt(System.Runtime.CompilerServices.IsConst)*,System.Int32,System.Int32), *num2, @in, inl, 0, *(num2 + 4));
		if (num3 == -1)
		{
			object[] args = new object[]
			{
				-1
			};
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("Security: rudp_write: R_write failed. ret={0}", args);
			if (global::<Module>.BIO_rudp_non_fatal_error(global::<Module>.WSAGetLastError()) != null)
			{
				global::<Module>.BIO_set_flags(b, 10);
			}
		}
		return num3;
	}

	// Token: 0x06000006 RID: 6 RVA: 0x0001F554 File Offset: 0x0001E954
	internal unsafe static int rudp_ctrl(global::bio_st* b, int cmd, int num, void* ptr)
	{
		int result = 1;
		switch (cmd)
		{
		case 8:
			return *(int*)(b + 16 / sizeof(global::bio_st));
		case 9:
			*(int*)(b + 16 / sizeof(global::bio_st)) = num;
			return result;
		case 11:
		case 12:
			return 1;
		case 47:
		{
			ref int ptr2 = *(int*)(b + 32 / sizeof(global::bio_st));
			object[] args = new object[0];
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("rudp_ctrl: BIO_CTRL_RUDP_SET_CALLBACK\n", args);
			*(ref ptr2 + 16) = ptr;
			return result;
		}
		case 48:
		{
			global::bio_rudp_data_st* ptr3 = *(int*)(b + 32 / sizeof(global::bio_st));
			if (*(int*)ptr3 != 0)
			{
				object[] args2 = new object[0];
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("rudp_ctrl: BIO_CTRL_RUDP_SET_READ_BUFFER. rx_buffer!=NULL!!?\n", args2);
				return 0;
			}
			global::bio_rudp_data_st* ptr4;
			if (228 < num + 297)
			{
				ptr4 = ptr3 + 4 / sizeof(global::bio_rudp_data_st);
				*(int*)ptr4 = num + 297;
			}
			else
			{
				ptr4 = ptr3 + 4 / sizeof(global::bio_rudp_data_st);
				*(int*)ptr4 = 228;
			}
			void* ptr5 = global::<Module>.CRYPTO_malloc(*(int*)ptr4, (sbyte*)(&global::<Module>.??_C@_0BG@LCDFPEM@OpenSSLBioAdapter?4cpp?$AA@), 361);
			*(int*)ptr3 = ptr5;
			if (ptr5 == null)
			{
				*(int*)ptr4 = 0;
				result = 0;
				object[] args3 = new object[0];
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("rudp_ctrl: BIO_CTRL_RUDP_SET_READ_BUFFER. malloc failed!!?\n", args3);
				return result;
			}
			object[] args4 = new object[]
			{
				(uint)(*(int*)ptr4)
			};
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("rudp_ctrl: BIO_CTRL_RUDP_SET_READ_BUFFER OK. rx_max_len={0}\n", args4);
			return result;
		}
		case 50:
			*(*(int*)(b + 32 / sizeof(global::bio_st)) + 20) = ptr;
			return result;
		case 51:
		{
			ref byte ptr6 = *(int*)(b + 32 / sizeof(global::bio_st));
			bool flag = num != 0;
			*(ref ptr6 + 24) = (flag ? 1 : 0);
			return result;
		}
		case 104:
		{
			object[] args5 = new object[]
			{
				*(int*)ptr
			};
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("rudp_ctrl: BIO_C_SET_FD. fd={0}", args5);
			*(int*)(b + 28 / sizeof(global::bio_st)) = *(int*)ptr;
			*(int*)(b + 16 / sizeof(global::bio_st)) = num;
			*(int*)(b + 12 / sizeof(global::bio_st)) = 1;
			return result;
		}
		case 105:
			if (*(int*)(b + 12 / sizeof(global::bio_st)) != 0)
			{
				if (ptr != null)
				{
					*(int*)ptr = *(int*)(b + 28 / sizeof(global::bio_st));
				}
				return *(int*)(b + 28 / sizeof(global::bio_st));
			}
			return -1;
		}
		result = 0;
		return result;
	}

	// Token: 0x06000007 RID: 7 RVA: 0x0001F870 File Offset: 0x0001EC70
	internal static int BIO_rudp_non_fatal_error(int err)
	{
		switch (err)
		{
		case 4:
		case 11:
		case 103:
		case 112:
		case 126:
		case 134:
		{
			object[] args = new object[0];
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("BIO_rudp_non_fatal_error: non-fatal error\n", args);
			return 1;
		}
		}
		object[] args2 = new object[0];
		global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("BIO_rudp_non_fatal_error: fatal error\n", args2);
		return 0;
	}

	// Token: 0x06000008 RID: 8 RVA: 0x0001FCE8 File Offset: 0x0001F0E8
	internal unsafe static void* app_stdin()
	{
		return global::<Module>.__iob_func();
	}

	// Token: 0x06000009 RID: 9 RVA: 0x0001FCFC File Offset: 0x0001F0FC
	internal unsafe static void* app_stdout()
	{
		return global::<Module>.__iob_func() + 32;
	}

	// Token: 0x0600000A RID: 10 RVA: 0x0001FD14 File Offset: 0x0001F114
	internal unsafe static void* app_stderr()
	{
		return global::<Module>.__iob_func() + 64;
	}

	// Token: 0x0600000B RID: 11 RVA: 0x0001FD2C File Offset: 0x0001F12C
	internal unsafe static int app_feof(global::_iobuf* fp)
	{
		return global::<Module>.feof(fp);
	}

	// Token: 0x0600000C RID: 12 RVA: 0x0001FD40 File Offset: 0x0001F140
	internal unsafe static int app_ferror(global::_iobuf* fp)
	{
		return global::<Module>.ferror(fp);
	}

	// Token: 0x0600000D RID: 13 RVA: 0x0001FD54 File Offset: 0x0001F154
	internal unsafe static void app_clearerr(global::_iobuf* fp)
	{
		global::<Module>.clearerr(fp);
	}

	// Token: 0x0600000E RID: 14 RVA: 0x0001FD68 File Offset: 0x0001F168
	internal unsafe static int app_fileno(global::_iobuf* fp)
	{
		return global::<Module>._fileno(fp);
	}

	// Token: 0x0600000F RID: 15 RVA: 0x0001FD7C File Offset: 0x0001F17C
	internal unsafe static int app_fsetmod(global::_iobuf* fp, sbyte mod)
	{
		int num = (mod == 98) ? 32768 : 16384;
		return global::<Module>._setmode(global::<Module>._fileno(fp), num);
	}

	// Token: 0x06000010 RID: 16 RVA: 0x0001FDA8 File Offset: 0x0001F1A8
	internal unsafe static void** OPENSSL_Applink()
	{
		if (global::<Module>.?A0xc1555744.?once@?1??OPENSSL_Applink@@YAPAPAXXZ@4HA != 0)
		{
			*(ref global::<Module>.?A0xc1555744.?OPENSSL_ApplinkTable@?1??OPENSSL_Applink@@YAPAPAXXZ@4PAPAXA + 4) = global::<Module>.__unep@?app_stdin@?A0xc1555744@@$$FYAPAXXZ;
			*(ref global::<Module>.?A0xc1555744.?OPENSSL_ApplinkTable@?1??OPENSSL_Applink@@YAPAPAXXZ@4PAPAXA + 8) = global::<Module>.__unep@?app_stdout@?A0xc1555744@@$$FYAPAXXZ;
			*(ref global::<Module>.?A0xc1555744.?OPENSSL_ApplinkTable@?1??OPENSSL_Applink@@YAPAPAXXZ@4PAPAXA + 12) = global::<Module>.__unep@?app_stderr@?A0xc1555744@@$$FYAPAXXZ;
			*(ref global::<Module>.?A0xc1555744.?OPENSSL_ApplinkTable@?1??OPENSSL_Applink@@YAPAPAXXZ@4PAPAXA + 16) = global::<Module>.__unep@?fprintf@@$$J0YAHPAU_iobuf@@PBDZZ;
			*(ref global::<Module>.?A0xc1555744.?OPENSSL_ApplinkTable@?1??OPENSSL_Applink@@YAPAPAXXZ@4PAPAXA + 20) = global::<Module>.__unep@?fgets@@$$J0YAPADPADHPAU_iobuf@@@Z;
			*(ref global::<Module>.?A0xc1555744.?OPENSSL_ApplinkTable@?1??OPENSSL_Applink@@YAPAPAXXZ@4PAPAXA + 24) = global::<Module>.__unep@?fread@@$$J0YAIPAXIIPAU_iobuf@@@Z;
			*(ref global::<Module>.?A0xc1555744.?OPENSSL_ApplinkTable@?1??OPENSSL_Applink@@YAPAPAXXZ@4PAPAXA + 28) = global::<Module>.__unep@?fwrite@@$$J0YAIPBXIIPAU_iobuf@@@Z;
			*(ref global::<Module>.?A0xc1555744.?OPENSSL_ApplinkTable@?1??OPENSSL_Applink@@YAPAPAXXZ@4PAPAXA + 32) = global::<Module>.__unep@?app_fsetmod@?A0xc1555744@@$$FYAHPAU_iobuf@@D@Z;
			*(ref global::<Module>.?A0xc1555744.?OPENSSL_ApplinkTable@?1??OPENSSL_Applink@@YAPAPAXXZ@4PAPAXA + 36) = global::<Module>.__unep@?app_feof@?A0xc1555744@@$$FYAHPAU_iobuf@@@Z;
			*(ref global::<Module>.?A0xc1555744.?OPENSSL_ApplinkTable@?1??OPENSSL_Applink@@YAPAPAXXZ@4PAPAXA + 40) = global::<Module>.__unep@?fclose@@$$J0YAHPAU_iobuf@@@Z;
			*(ref global::<Module>.?A0xc1555744.?OPENSSL_ApplinkTable@?1??OPENSSL_Applink@@YAPAPAXXZ@4PAPAXA + 44) = global::<Module>.__unep@?fopen@@$$J0YAPAU_iobuf@@PBD0@Z;
			*(ref global::<Module>.?A0xc1555744.?OPENSSL_ApplinkTable@?1??OPENSSL_Applink@@YAPAPAXXZ@4PAPAXA + 48) = global::<Module>.__unep@?fseek@@$$J0YAHPAU_iobuf@@JH@Z;
			*(ref global::<Module>.?A0xc1555744.?OPENSSL_ApplinkTable@?1??OPENSSL_Applink@@YAPAPAXXZ@4PAPAXA + 52) = global::<Module>.__unep@?ftell@@$$J0YAJPAU_iobuf@@@Z;
			*(ref global::<Module>.?A0xc1555744.?OPENSSL_ApplinkTable@?1??OPENSSL_Applink@@YAPAPAXXZ@4PAPAXA + 56) = global::<Module>.__unep@?fflush@@$$J0YAHPAU_iobuf@@@Z;
			*(ref global::<Module>.?A0xc1555744.?OPENSSL_ApplinkTable@?1??OPENSSL_Applink@@YAPAPAXXZ@4PAPAXA + 60) = global::<Module>.__unep@?app_ferror@?A0xc1555744@@$$FYAHPAU_iobuf@@@Z;
			*(ref global::<Module>.?A0xc1555744.?OPENSSL_ApplinkTable@?1??OPENSSL_Applink@@YAPAPAXXZ@4PAPAXA + 64) = global::<Module>.__unep@?app_clearerr@?A0xc1555744@@$$FYAXPAU_iobuf@@@Z;
			*(ref global::<Module>.?A0xc1555744.?OPENSSL_ApplinkTable@?1??OPENSSL_Applink@@YAPAPAXXZ@4PAPAXA + 68) = global::<Module>.__unep@?app_fileno@?A0xc1555744@@$$FYAHPAU_iobuf@@@Z;
			*(ref global::<Module>.?A0xc1555744.?OPENSSL_ApplinkTable@?1??OPENSSL_Applink@@YAPAPAXXZ@4PAPAXA + 72) = global::<Module>.__unep@?_open@@$$FYAHPBDHH@Z;
			*(ref global::<Module>.?A0xc1555744.?OPENSSL_ApplinkTable@?1??OPENSSL_Applink@@YAPAPAXXZ@4PAPAXA + 76) = global::<Module>.__unep@?_read@@$$J0YAHHPAXI@Z;
			*(ref global::<Module>.?A0xc1555744.?OPENSSL_ApplinkTable@?1??OPENSSL_Applink@@YAPAPAXXZ@4PAPAXA + 80) = global::<Module>.__unep@?_write@@$$J0YAHHPBXI@Z;
			*(ref global::<Module>.?A0xc1555744.?OPENSSL_ApplinkTable@?1??OPENSSL_Applink@@YAPAPAXXZ@4PAPAXA + 84) = global::<Module>.__unep@?_lseek@@$$J0YAJHJH@Z;
			*(ref global::<Module>.?A0xc1555744.?OPENSSL_ApplinkTable@?1??OPENSSL_Applink@@YAPAPAXXZ@4PAPAXA + 88) = global::<Module>.__unep@?_close@@$$J0YAHH@Z;
			global::<Module>.?A0xc1555744.?once@?1??OPENSSL_Applink@@YAPAPAXXZ@4HA = 0;
		}
		return ref global::<Module>.?A0xc1555744.?OPENSSL_ApplinkTable@?1??OPENSSL_Applink@@YAPAPAXXZ@4PAPAXA;
	}

	// Token: 0x06000011 RID: 17 RVA: 0x000200A4 File Offset: 0x0001F4A4
	internal static global::System.IntPtr ToPtr(global::System.Collections.Generic.List<global::Motorola.Common.Communication.Security.AuthenticationMaterials> m_auths)
	{
		int count = m_auths.Count;
		global::System.IntPtr intPtr = global::System.Runtime.InteropServices.Marshal.AllocHGlobal(sizeof(global::Motorola.Common.Communication.Security.AuthenticationMaterials) * count + 4);
		global::System.Runtime.InteropServices.Marshal.WriteInt32(intPtr, 0, count);
		int num = 0;
		if (0 < count)
		{
			do
			{
				global::System.IntPtr ptr = intPtr + 4 + global::System.Runtime.InteropServices.Marshal.SizeOf(typeof(global::Motorola.Common.Communication.Security.AuthenticationMaterials)) * num;
				global::System.Runtime.InteropServices.Marshal.StructureToPtr<global::Motorola.Common.Communication.Security.AuthenticationMaterials>(m_auths[num], ptr, false);
				num++;
			}
			while (num < count);
		}
		return intPtr;
	}

	// Token: 0x06000012 RID: 18 RVA: 0x0002010C File Offset: 0x0001F50C
	internal static global::System.Collections.Generic.List<global::Motorola.Common.Communication.Security.AuthenticationMaterials> FromPtr(global::System.IntPtr ptr)
	{
		global::System.Collections.Generic.List<global::Motorola.Common.Communication.Security.AuthenticationMaterials> list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.Security.AuthenticationMaterials>();
		int num = global::System.Runtime.InteropServices.Marshal.ReadInt32(ptr, 0);
		int num2 = 0;
		if (0 < num)
		{
			do
			{
				global::System.ValueType valueType = (global::Motorola.Common.Communication.Security.AuthenticationMaterials)global::System.Runtime.InteropServices.Marshal.PtrToStructure(ptr + 4 + global::System.Runtime.InteropServices.Marshal.SizeOf(typeof(global::Motorola.Common.Communication.Security.AuthenticationMaterials)) * num2, typeof(global::Motorola.Common.Communication.Security.AuthenticationMaterials));
				list.Add((global::Motorola.Common.Communication.Security.AuthenticationMaterials)valueType);
				num2++;
			}
			while (num2 < num);
		}
		return list;
	}

	// Token: 0x06000013 RID: 19 RVA: 0x0002065C File Offset: 0x0001FA5C
	[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
	internal unsafe static bool seclayer_get_key(global::ssl_st* ssl, uint* key_id_length_ptr, sbyte* key_id_ptr, sbyte* hint, uint* key_length_ptr, byte* psk)
	{
		uint num = (uint)(*(int*)(ssl + 372 / sizeof(global::ssl_st)));
		if (num == 0U)
		{
			sbyte* ptr = ref global::<Module>.default_secl_key_id;
			if (global::<Module>.default_secl_key_id != null)
			{
				do
				{
					ptr++;
				}
				while (*ptr != 0);
			}
			int num2 = ptr - ref global::<Module>.default_secl_key_id;
			*key_id_length_ptr = (uint)num2;
			global::<Module>.strcpy_s(key_id_ptr, (uint)(num2 + 1), (sbyte*)(&global::<Module>.default_secl_key_id));
			return 1;
		}
		global::System.Collections.Generic.List<global::Motorola.Common.Communication.Security.AuthenticationMaterials> list = global::<Module>.Motorola.Common.Communication.Security.AuthenticationMaterialsMarshaller.FromPtr((global::System.IntPtr)num);
		bool result = false;
		int num3 = 0;
		if (0 < list.Count)
		{
			do
			{
				global::Motorola.Common.Communication.Security.AuthenticationMaterials authenticationMaterials = list[num3];
				ref byte byte& = ref authenticationMaterials.PSK_ID[0];
				try
				{
					byte* ptr2 = ref byte&;
					sbyte* ptr3 = hint;
					byte* ptr4 = ptr2;
					sbyte b = *(sbyte*)ptr2;
					sbyte b2 = *(sbyte*)hint;
					if (b >= b2)
					{
						while (b <= b2)
						{
							if (b == 0)
							{
								goto IL_D1;
							}
							ptr4++;
							ptr3 += 1 / sizeof(sbyte);
							b = *(sbyte*)ptr4;
							b2 = *(sbyte*)ptr3;
							if (b < b2)
							{
								break;
							}
						}
					}
				}
				catch
				{
					throw;
				}
				num3++;
			}
			while (num3 < list.Count);
			return result;
			IL_D1:
			try
			{
				global::Motorola.Common.Communication.Security.AuthenticationMaterials authenticationMaterials;
				*key_id_length_ptr = (uint)authenticationMaterials.KEY_ID_LEN;
				ref void void& = ref authenticationMaterials.PSK_ID[0];
				try
				{
					global::<Module>.strcpy_s(key_id_ptr, *key_id_length_ptr + 1U, ref void&);
					*key_length_ptr = (uint)authenticationMaterials.KEY_LEN;
					ref void void&2 = ref authenticationMaterials.PSK_VALUE[0];
					try
					{
						cpblk(psk, ref void&2, *key_length_ptr);
						result = true;
					}
					catch
					{
						throw;
					}
				}
				catch
				{
					throw;
				}
			}
			catch
			{
				throw;
			}
		}
		return result;
	}

	// Token: 0x06000014 RID: 20 RVA: 0x00020804 File Offset: 0x0001FC04
	internal unsafe static uint secl_client_callback(global::ssl_st* ssl, sbyte* hint, sbyte* identity, uint max_identity_len, byte* psk, uint max_psk_len)
	{
		uint result = 16U;
		uint num = max_identity_len;
		if (ssl == null)
		{
			object[] args = new object[0];
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("Security: ssl null pointer", args);
			return 0;
		}
		if (hint == null)
		{
			object[] args2 = new object[0];
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("Security: ssl hint pointer is null", args2);
			return 0;
		}
		object[] args3 = new object[]
		{
			new string((sbyte*)hint),
			max_identity_len,
			max_psk_len
		};
		global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteSensitive("Security: input from openssl: hint from server = {0}, max_identity_len={1}, max_psk_len={2}", args3);
		global::<Module>.seclayer_get_key(ssl, &num, identity, hint, &result, psk);
		*(byte*)(num / (uint)sizeof(sbyte) + identity) = 0;
		sbyte* ptr = identity;
		sbyte b = *(sbyte*)hint;
		sbyte b2 = *(sbyte*)identity;
		if (b >= b2)
		{
			int num2 = (int)(hint - identity);
			while (b <= b2)
			{
				if (b == 0)
				{
					return result;
				}
				ptr += 1 / sizeof(sbyte);
				b = *(sbyte*)(num2 / sizeof(sbyte) + ptr);
				b2 = *(sbyte*)ptr;
				if (b < b2)
				{
					break;
				}
			}
		}
		object[] args4 = new object[0];
		global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("Security: server hint validate failed.", args4);
		return 0;
	}

	// Token: 0x06000015 RID: 21 RVA: 0x000208E8 File Offset: 0x0001FCE8
	internal unsafe static int is_fatal_ssl_error(global::ssl_st* ssl, int rc)
	{
		int result = global::<Module>.SSL_get_error((global::ssl_st*)ssl, rc);
		switch (result)
		{
		case 0:
		{
			object[] args = new object[0];
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("SSL_ERROR_NONE\n", args);
			break;
		}
		case 1:
		{
			object[] args2 = new object[0];
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("SSL_ERROR_SSL\n", args2);
			break;
		}
		case 2:
		{
			object[] args3 = new object[0];
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("SSL_ERROR_WANT_READ\n", args3);
			break;
		}
		case 3:
		{
			object[] args4 = new object[0];
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("SSL_ERROR_WANT_WRITE\n", args4);
			break;
		}
		case 4:
		{
			object[] args5 = new object[0];
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("SSL_ERROR_WANT_X509_LOOKUP\n", args5);
			break;
		}
		case 5:
		{
			object[] args6 = new object[0];
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("SSL_ERROR_SYSCALL\n", args6);
			break;
		}
		case 6:
		{
			object[] args7 = new object[0];
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("SSL_ERROR_ZERO_RETURN\n", args7);
			break;
		}
		case 7:
		{
			object[] args8 = new object[0];
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("SSL_ERROR_WANT_CONNECT\n", args8);
			break;
		}
		case 8:
		{
			object[] args9 = new object[0];
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("SSL_ERROR_WANT_ACCEPT\n", args9);
			break;
		}
		default:
		{
			object[] args10 = new object[0];
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("unknown SSL_ERROR\n", args10);
			break;
		}
		}
		return result;
	}

	// Token: 0x06000016 RID: 22 RVA: 0x000210A0 File Offset: 0x000204A0
	internal unsafe static global::CommPipeAdapter* {ctor}(global::CommPipeAdapter* A_0, global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe _commPipe)
	{
		global::<Module>.gcroot<Motorola::Common::Communication::CommunicationPipe::ICommunicationPipe\u0020^>.{ctor}(A_0);
		try
		{
			*(A_0 + 4) = 0;
			global::<Module>.gcroot<Motorola::Common::Communication::CommunicationPipe::ICommunicationPipe\u0020^>.=(A_0, _commPipe);
		}
		catch
		{
			global::<Module>.___CxxCallUnwindDtor(ldftn(gcroot<Motorola::Common::Communication::CommunicationPipe::ICommunicationPipe\u0020^>.{dtor}), A_0);
			throw;
		}
		return A_0;
	}

	// Token: 0x06000017 RID: 23 RVA: 0x000211D0 File Offset: 0x000205D0
	internal unsafe static global::_comm_pipe_adapter_st* CreatePipeBIO(global::CommPipeAdapter* A_0, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)] bool stream)
	{
		if (*(A_0 + 4) == 0)
		{
			global::_comm_pipe_adapter_st* ptr = global::<Module>.@new(20U);
			global::_comm_pipe_adapter_st* ptr2;
			if (ptr != null)
			{
				initblk(ptr, 0, 20);
				ptr2 = ptr;
			}
			else
			{
				ptr2 = null;
			}
			*(A_0 + 4) = ptr2;
			initblk(ptr2, 0, 20);
			*(*(A_0 + 4)) = A_0;
			*(*(A_0 + 4) + 4) = global::<Module>.__unep@?PipeWrite@?A0x6f6a44a8@@$$J0YAHPAXPBDHH@Z;
			*(*(A_0 + 4) + 8) = global::<Module>.__unep@?PipeRead@?A0x6f6a44a8@@$$J0YAHPAXPADHH@Z;
			*(*(A_0 + 4) + 12) = global::<Module>.__unep@?PipeCreate@?A0x6f6a44a8@@$$J0YAHPAX@Z;
			*(*(A_0 + 4) + 16) = global::<Module>.__unep@?PipeClose@?A0x6f6a44a8@@$$J0YAHPAX@Z;
		}
		*(A_0 + 8) = (stream ? 1 : 0);
		return *(A_0 + 4);
	}

	// Token: 0x06000018 RID: 24 RVA: 0x000210F0 File Offset: 0x000204F0
	internal unsafe static int Write(global::CommPipeAdapter* A_0, sbyte* A_0, int A_1, int A_2)
	{
		byte[] array = new byte[A_1];
		int num = 0;
		if (0 < A_1)
		{
			do
			{
				byte[] array2 = array;
				int num2 = num;
				array2[num2] = (byte)(*(sbyte*)(num2 / sizeof(sbyte) + A_0));
				num++;
			}
			while (num < A_1);
		}
		global::<Module>.gcroot<Motorola::Common::Communication::CommunicationPipe::ICommunicationPipe\u0020^>.->(A_0).SendData(array, 0, A_1);
		return A_1;
	}

	// Token: 0x06000019 RID: 25 RVA: 0x0002112C File Offset: 0x0002052C
	internal unsafe static int Read(global::CommPipeAdapter* A_0, sbyte* A_0, int A_1, int A_2)
	{
		byte[] array;
		int num;
		if (*(A_0 + 8) == 0)
		{
			array = global::<Module>.gcroot<Motorola::Common::Communication::CommunicationPipe::ICommunicationPipe\u0020^>.->(A_0).ReceiveData();
			if (array == null)
			{
				return 0;
			}
			num = array.Length;
		}
		else
		{
			array = new byte[A_1];
			num = global::<Module>.gcroot<Motorola::Common::Communication::CommunicationPipe::ICommunicationPipe\u0020^>.->(A_0).ReceiveData(array, 0, global::<Module>.gcroot<Motorola::Common::Communication::CommunicationPipe::ICommunicationPipe\u0020^>.->(A_0).ReceiveTimeout, A_1);
			if (num == 0)
			{
				return 0;
			}
		}
		if (num > A_1)
		{
			return 0;
		}
		int num2 = 0;
		if (0 < num)
		{
			do
			{
				*(byte*)(num2 / sizeof(sbyte) + A_0) = (byte)((sbyte)array[num2]);
				num2++;
			}
			while (num2 < num);
		}
		return num;
	}

	// Token: 0x0600001A RID: 26 RVA: 0x00021198 File Offset: 0x00020598
	internal unsafe static int PipeWrite(void* pipe_ptr, sbyte* buf, int len, int flag)
	{
		if (pipe_ptr != null)
		{
			return global::<Module>.CommPipeAdapter.Write(pipe_ptr, buf, len, flag);
		}
		return 0;
	}

	// Token: 0x0600001B RID: 27 RVA: 0x000211B4 File Offset: 0x000205B4
	internal unsafe static int PipeRead(void* pipe_ptr, sbyte* buf, int len, int flag)
	{
		if (pipe_ptr != null)
		{
			return global::<Module>.CommPipeAdapter.Read(pipe_ptr, buf, len, flag);
		}
		return 0;
	}

	// Token: 0x0600001C RID: 28 RVA: 0x00021044 File Offset: 0x00020444
	internal unsafe static int PipeCreate(void* pipe_ptr)
	{
		return 0;
	}

	// Token: 0x0600001D RID: 29 RVA: 0x00021054 File Offset: 0x00020454
	internal unsafe static int PipeClose(void* pipe_ptr)
	{
		if (pipe_ptr != null)
		{
			uint num = (uint)(*(int*)((byte*)pipe_ptr + 4));
			if (num != 0U)
			{
				global::<Module>.delete(num);
				*(int*)((byte*)pipe_ptr + 4) = 0;
			}
			return 0;
		}
		return 0;
	}

	// Token: 0x0600001E RID: 30 RVA: 0x00022398 File Offset: 0x00021798
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.Security.SecuritySafeCritical]
	internal unsafe static global::gcroot<Motorola::Common::Communication::CommunicationPipe::ICommunicationPipe\u0020^>* {ctor}(global::gcroot<Motorola::Common::Communication::CommunicationPipe::ICommunicationPipe\u0020^>* A_0)
	{
		*A_0 = ((global::System.IntPtr)global::System.Runtime.InteropServices.GCHandle.Alloc(null)).ToPointer();
		return A_0;
	}

	// Token: 0x0600001F RID: 31 RVA: 0x000223BC File Offset: 0x000217BC
	[global::System.Security.SecurityCritical]
	[global::System.Diagnostics.DebuggerStepThrough]
	internal unsafe static void {dtor}(global::gcroot<Motorola::Common::Communication::CommunicationPipe::ICommunicationPipe\u0020^>* A_0)
	{
		global::System.IntPtr value = new global::System.IntPtr(*A_0);
		((global::System.Runtime.InteropServices.GCHandle)value).Free();
		*A_0 = 0;
	}

	// Token: 0x06000020 RID: 32 RVA: 0x000223E4 File Offset: 0x000217E4
	[global::System.Security.SecurityCritical]
	[global::System.Diagnostics.DebuggerStepThrough]
	internal unsafe static global::gcroot<Motorola::Common::Communication::CommunicationPipe::ICommunicationPipe\u0020^>* =(global::gcroot<Motorola::Common::Communication::CommunicationPipe::ICommunicationPipe\u0020^>* A_0, global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe t)
	{
		global::System.IntPtr value = new global::System.IntPtr(*A_0);
		((global::System.Runtime.InteropServices.GCHandle)value).Target = t;
		return A_0;
	}

	// Token: 0x06000021 RID: 33 RVA: 0x0002107C File Offset: 0x0002047C
	[global::System.Security.SecuritySafeCritical]
	internal unsafe static global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe ->(global::gcroot<Motorola::Common::Communication::CommunicationPipe::ICommunicationPipe\u0020^>* A_0)
	{
		global::System.IntPtr value = new global::System.IntPtr(*A_0);
		return ((global::System.Runtime.InteropServices.GCHandle)value).Target;
	}

	// Token: 0x06000022 RID: 34 RVA: 0x00021CA0 File Offset: 0x000210A0
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

	// Token: 0x06000023 RID: 35 RVA: 0x00022428 File Offset: 0x00021828
	internal static void <CrtImplementationDetails>.ThrowNestedModuleLoadException(global::System.Exception innerException, global::System.Exception nestedException)
	{
		throw new global::<CrtImplementationDetails>.ModuleLoadExceptionHandlerException("A nested exception occurred after the primary exception that caused the C++ module to fail to load.\n", innerException, nestedException);
	}

	// Token: 0x06000024 RID: 36 RVA: 0x00021E5C File Offset: 0x0002125C
	internal static void <CrtImplementationDetails>.ThrowModuleLoadException(string errorMessage)
	{
		throw new global::<CrtImplementationDetails>.ModuleLoadException(errorMessage);
	}

	// Token: 0x06000025 RID: 37 RVA: 0x00021E70 File Offset: 0x00021270
	internal static void <CrtImplementationDetails>.ThrowModuleLoadException(string errorMessage, global::System.Exception innerException)
	{
		throw new global::<CrtImplementationDetails>.ModuleLoadException(errorMessage, innerException);
	}

	// Token: 0x06000026 RID: 38 RVA: 0x00021F8C File Offset: 0x0002138C
	internal static void <CrtImplementationDetails>.RegisterModuleUninitializer(global::System.EventHandler handler)
	{
		global::<CrtImplementationDetails>.ModuleUninitializer._ModuleUninitializer.AddHandler(handler);
	}

	// Token: 0x06000027 RID: 39 RVA: 0x00021FA4 File Offset: 0x000213A4
	[global::System.Security.SecuritySafeCritical]
	internal unsafe static global::System.Guid <CrtImplementationDetails>.FromGUID(global::_GUID* guid)
	{
		global::System.Guid result = new global::System.Guid((uint)(*guid), *(guid + 4), *(guid + 6), *(guid + 8), *(guid + 9), *(guid + 10), *(guid + 11), *(guid + 12), *(guid + 13), *(guid + 14), *(guid + 15));
		return result;
	}

	// Token: 0x06000028 RID: 40 RVA: 0x00021FEC File Offset: 0x000213EC
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

	// Token: 0x06000029 RID: 41 RVA: 0x00022070 File Offset: 0x00021470
	internal unsafe static void __release_appdomain(global::IUnknown* ppUnk)
	{
		object obj = calli(System.UInt32 modopt(System.Runtime.CompilerServices.IsLong) modopt(System.Runtime.CompilerServices.CallConvStdcall)(System.IntPtr), ppUnk, *(*(int*)ppUnk + 8));
	}

	// Token: 0x0600002A RID: 42 RVA: 0x0002208C File Offset: 0x0002148C
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

	// Token: 0x0600002B RID: 43 RVA: 0x000220EC File Offset: 0x000214EC
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

	// Token: 0x0600002C RID: 44 RVA: 0x0002217C File Offset: 0x0002157C
	[global::System.Security.SecuritySafeCritical]
	internal unsafe static int <CrtImplementationDetails>.DefaultDomain.DoNothing(void* cookie)
	{
		global::System.GC.KeepAlive(int.MaxValue);
		return 0;
	}

	// Token: 0x0600002D RID: 45 RVA: 0x0002219C File Offset: 0x0002159C
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

	// Token: 0x0600002E RID: 46 RVA: 0x000221F0 File Offset: 0x000215F0
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

	// Token: 0x0600002F RID: 47 RVA: 0x00022270 File Offset: 0x00021670
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

	// Token: 0x06000030 RID: 48 RVA: 0x000222AC File Offset: 0x000216AC
	[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
	internal static bool <CrtImplementationDetails>.DefaultDomain.NeedsUninitialization()
	{
		return global::<Module>.?Entered@DefaultDomain@<CrtImplementationDetails>@@2_NA;
	}

	// Token: 0x06000031 RID: 49 RVA: 0x000222C0 File Offset: 0x000216C0
	[global::System.Security.SecurityCritical]
	internal static void <CrtImplementationDetails>.DefaultDomain.Initialize()
	{
		global::<Module>.<CrtImplementationDetails>.DoCallBackInDefaultDomain(global::<Module>.__unep@?DoNothing@DefaultDomain@<CrtImplementationDetails>@@$$FCGJPAX@Z, null);
	}

	// Token: 0x06000032 RID: 50 RVA: 0x0001F23C File Offset: 0x0001E63C
	internal static void ??__E?Initialized@CurrentDomain@<CrtImplementationDetails>@@$$Q2HA@@YMXXZ()
	{
		global::<Module>.?Initialized@CurrentDomain@<CrtImplementationDetails>@@$$Q2HA = 0;
	}

	// Token: 0x06000033 RID: 51 RVA: 0x0001F250 File Offset: 0x0001E650
	internal static void ??__E?Uninitialized@CurrentDomain@<CrtImplementationDetails>@@$$Q2HA@@YMXXZ()
	{
		global::<Module>.?Uninitialized@CurrentDomain@<CrtImplementationDetails>@@$$Q2HA = 0;
	}

	// Token: 0x06000034 RID: 52 RVA: 0x0001F264 File Offset: 0x0001E664
	internal static void ??__E?IsDefaultDomain@CurrentDomain@<CrtImplementationDetails>@@$$Q2_NA@@YMXXZ()
	{
		global::<Module>.?IsDefaultDomain@CurrentDomain@<CrtImplementationDetails>@@$$Q2_NA = false;
	}

	// Token: 0x06000035 RID: 53 RVA: 0x0001F278 File Offset: 0x0001E678
	internal static void ??__E?InitializedVtables@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A@@YMXXZ()
	{
		global::<Module>.?InitializedVtables@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A = (global::<CrtImplementationDetails>.Progress.State)0;
	}

	// Token: 0x06000036 RID: 54 RVA: 0x0001F28C File Offset: 0x0001E68C
	internal static void ??__E?InitializedNative@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A@@YMXXZ()
	{
		global::<Module>.?InitializedNative@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A = (global::<CrtImplementationDetails>.Progress.State)0;
	}

	// Token: 0x06000037 RID: 55 RVA: 0x0001F2A0 File Offset: 0x0001E6A0
	internal static void ??__E?InitializedPerProcess@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A@@YMXXZ()
	{
		global::<Module>.?InitializedPerProcess@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A = (global::<CrtImplementationDetails>.Progress.State)0;
	}

	// Token: 0x06000038 RID: 56 RVA: 0x0001F2B4 File Offset: 0x0001E6B4
	internal static void ??__E?InitializedPerAppDomain@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A@@YMXXZ()
	{
		global::<Module>.?InitializedPerAppDomain@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A = (global::<CrtImplementationDetails>.Progress.State)0;
	}

	// Token: 0x06000039 RID: 57 RVA: 0x0002247C File Offset: 0x0002187C
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.Security.SecurityCritical]
	internal unsafe static void <CrtImplementationDetails>.LanguageSupport.InitializeVtables(global::<CrtImplementationDetails>.LanguageSupport* A_0)
	{
		global::<Module>.gcroot<System::String\u0020^>.=(A_0, "The C++ module failed to load during vtable initialization.\n");
		global::<Module>.?InitializedVtables@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A = (global::<CrtImplementationDetails>.Progress.State)1;
		global::<Module>._initterm_m((global::method*)(&global::<Module>.?A0xd2508fec.__xi_vt_a), (global::method*)(&global::<Module>.?A0xd2508fec.__xi_vt_z));
		global::<Module>.?InitializedVtables@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A = (global::<CrtImplementationDetails>.Progress.State)2;
	}

	// Token: 0x0600003A RID: 58 RVA: 0x000224B0 File Offset: 0x000218B0
	[global::System.Security.SecurityCritical]
	internal unsafe static void <CrtImplementationDetails>.LanguageSupport.InitializeDefaultAppDomain(global::<CrtImplementationDetails>.LanguageSupport* A_0)
	{
		global::<Module>.gcroot<System::String\u0020^>.=(A_0, "The C++ module failed to load while attempting to initialize the default appdomain.\n");
		global::<Module>.<CrtImplementationDetails>.DefaultDomain.Initialize();
	}

	// Token: 0x0600003B RID: 59 RVA: 0x000224D0 File Offset: 0x000218D0
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

	// Token: 0x0600003C RID: 60 RVA: 0x0002256C File Offset: 0x0002196C
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

	// Token: 0x0600003D RID: 61 RVA: 0x000225AC File Offset: 0x000219AC
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

	// Token: 0x0600003E RID: 62 RVA: 0x000225E8 File Offset: 0x000219E8
	[global::System.Security.SecurityCritical]
	[global::System.Diagnostics.DebuggerStepThrough]
	internal unsafe static void <CrtImplementationDetails>.LanguageSupport.InitializeUninitializer(global::<CrtImplementationDetails>.LanguageSupport* A_0)
	{
		global::<Module>.gcroot<System::String\u0020^>.=(A_0, "The C++ module failed to load during registration for the unload events.\n");
		global::<Module>.<CrtImplementationDetails>.RegisterModuleUninitializer(new global::System.EventHandler(global::<Module>.<CrtImplementationDetails>.LanguageSupport.DomainUnload));
	}

	// Token: 0x0600003F RID: 63 RVA: 0x00022614 File Offset: 0x00021A14
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

	// Token: 0x06000040 RID: 64 RVA: 0x000222D8 File Offset: 0x000216D8
	[global::System.Security.SecurityCritical]
	internal static void <CrtImplementationDetails>.LanguageSupport.UninitializeAppDomain()
	{
		global::<Module>._app_exit_callback();
	}

	// Token: 0x06000041 RID: 65 RVA: 0x000222EC File Offset: 0x000216EC
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

	// Token: 0x06000042 RID: 66 RVA: 0x00022328 File Offset: 0x00021728
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

	// Token: 0x06000043 RID: 67 RVA: 0x0002235C File Offset: 0x0002175C
	[global::System.Runtime.ConstrainedExecution.PrePrepareMethod]
	[global::System.Security.SecurityCritical]
	[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.Success)]
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

	// Token: 0x06000044 RID: 68 RVA: 0x00022738 File Offset: 0x00021B38
	[global::System.Security.SecurityCritical]
	[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.Success)]
	[global::System.Diagnostics.DebuggerStepThrough]
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

	// Token: 0x06000045 RID: 69 RVA: 0x000227AC File Offset: 0x00021BAC
	[global::System.Security.SecurityCritical]
	internal unsafe static global::<CrtImplementationDetails>.LanguageSupport* <CrtImplementationDetails>.LanguageSupport.{ctor}(global::<CrtImplementationDetails>.LanguageSupport* A_0)
	{
		global::<Module>.gcroot<System::String\u0020^>.{ctor}(A_0);
		return A_0;
	}

	// Token: 0x06000046 RID: 70 RVA: 0x000227C4 File Offset: 0x00021BC4
	[global::System.Security.SecurityCritical]
	internal unsafe static void <CrtImplementationDetails>.LanguageSupport.{dtor}(global::<CrtImplementationDetails>.LanguageSupport* A_0)
	{
		global::<Module>.gcroot<System::String\u0020^>.{dtor}(A_0);
	}

	// Token: 0x06000047 RID: 71 RVA: 0x000227D8 File Offset: 0x00021BD8
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

	// Token: 0x06000048 RID: 72 RVA: 0x00022894 File Offset: 0x00021C94
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

	// Token: 0x06000049 RID: 73 RVA: 0x00022398 File Offset: 0x00021798
	[global::System.Security.SecuritySafeCritical]
	[global::System.Diagnostics.DebuggerStepThrough]
	internal unsafe static global::gcroot<System::String\u0020^>* {ctor}(global::gcroot<System::String\u0020^>* A_0)
	{
		*A_0 = ((global::System.IntPtr)global::System.Runtime.InteropServices.GCHandle.Alloc(null)).ToPointer();
		return A_0;
	}

	// Token: 0x0600004A RID: 74 RVA: 0x000223BC File Offset: 0x000217BC
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.Security.SecurityCritical]
	internal unsafe static void {dtor}(global::gcroot<System::String\u0020^>* A_0)
	{
		global::System.IntPtr value = new global::System.IntPtr(*A_0);
		((global::System.Runtime.InteropServices.GCHandle)value).Free();
		*A_0 = 0;
	}

	// Token: 0x0600004B RID: 75 RVA: 0x000223E4 File Offset: 0x000217E4
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.Security.SecurityCritical]
	internal unsafe static global::gcroot<System::String\u0020^>* =(global::gcroot<System::String\u0020^>* A_0, string t)
	{
		global::System.IntPtr value = new global::System.IntPtr(*A_0);
		((global::System.Runtime.InteropServices.GCHandle)value).Target = t;
		return A_0;
	}

	// Token: 0x0600004C RID: 76 RVA: 0x0002107C File Offset: 0x0002047C
	[global::System.Security.SecuritySafeCritical]
	internal unsafe static string P$AAVString@System@@(global::gcroot<System::String\u0020^>* A_0)
	{
		global::System.IntPtr value = new global::System.IntPtr(*A_0);
		return ((global::System.Runtime.InteropServices.GCHandle)value).Target;
	}

	// Token: 0x0600004D RID: 77 RVA: 0x00022914 File Offset: 0x00021D14
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

	// Token: 0x0600004E RID: 78 RVA: 0x00022958 File Offset: 0x00021D58
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

	// Token: 0x0600004F RID: 79 RVA: 0x00022BF8 File Offset: 0x00021FF8
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.Security.SecurityCritical]
	internal static void <CrtImplementationDetails>.AtExitLock._lock_Construct(object value)
	{
		global::<Module>.?_lock@AtExitLock@<CrtImplementationDetails>@@$$Q0PAXA = null;
		global::<Module>.<CrtImplementationDetails>.AtExitLock._lock_Set(value);
	}

	// Token: 0x06000050 RID: 80 RVA: 0x00022988 File Offset: 0x00021D88
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

	// Token: 0x06000051 RID: 81 RVA: 0x000229D8 File Offset: 0x00021DD8
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

	// Token: 0x06000052 RID: 82 RVA: 0x000229FC File Offset: 0x00021DFC
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

	// Token: 0x06000053 RID: 83 RVA: 0x00022A24 File Offset: 0x00021E24
	[global::System.Security.SecuritySafeCritical]
	[global::System.Diagnostics.DebuggerStepThrough]
	[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
	internal static bool <CrtImplementationDetails>.AtExitLock.IsInitialized()
	{
		return (global::<Module>.<CrtImplementationDetails>.AtExitLock._lock_Get() != null) ? 1 : 0;
	}

	// Token: 0x06000054 RID: 84 RVA: 0x00022C14 File Offset: 0x00022014
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

	// Token: 0x06000055 RID: 85 RVA: 0x00022A40 File Offset: 0x00021E40
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

	// Token: 0x06000056 RID: 86 RVA: 0x00022C44 File Offset: 0x00022044
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.Security.SecurityCritical]
	[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
	internal static bool __alloc_global_lock()
	{
		global::<Module>.<CrtImplementationDetails>.AtExitLock.AddRef();
		return global::<Module>.<CrtImplementationDetails>.AtExitLock.IsInitialized();
	}

	// Token: 0x06000057 RID: 87 RVA: 0x00022A68 File Offset: 0x00021E68
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.Security.SecurityCritical]
	internal static void __dealloc_global_lock()
	{
		global::<Module>.<CrtImplementationDetails>.AtExitLock.RemoveRef();
	}

	// Token: 0x06000058 RID: 88 RVA: 0x00022A7C File Offset: 0x00021E7C
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

	// Token: 0x06000059 RID: 89 RVA: 0x00022C5C File Offset: 0x0002205C
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

	// Token: 0x0600005A RID: 90 RVA: 0x00022CA4 File Offset: 0x000220A4
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

	// Token: 0x0600005B RID: 91 RVA: 0x00022B20 File Offset: 0x00021F20
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

	// Token: 0x0600005C RID: 92
	[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.Success)]
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Security.SecurityCritical]
	[global::System.Runtime.InteropServices.DllImport("KERNEL32.dll")]
	public unsafe static extern void* DecodePointer(void* Ptr);

	// Token: 0x0600005D RID: 93
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Security.SecurityCritical]
	[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.Success)]
	[global::System.Runtime.InteropServices.DllImport("KERNEL32.dll")]
	public unsafe static extern void* EncodePointer(void* Ptr);

	// Token: 0x0600005E RID: 94 RVA: 0x00022CE8 File Offset: 0x000220E8
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

	// Token: 0x0600005F RID: 95 RVA: 0x00022D18 File Offset: 0x00022118
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

	// Token: 0x06000060 RID: 96 RVA: 0x00022D40 File Offset: 0x00022140
	[global::System.Diagnostics.DebuggerStepThrough]
	internal static global::System.ModuleHandle <CrtImplementationDetails>.ThisModule.Handle()
	{
		return typeof(global::<CrtImplementationDetails>.ThisModule).Module.ModuleHandle;
	}

	// Token: 0x06000061 RID: 97 RVA: 0x00022D90 File Offset: 0x00022190
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

	// Token: 0x06000062 RID: 98 RVA: 0x00022D64 File Offset: 0x00022164
	[global::System.Security.SecurityCritical]
	[global::System.Diagnostics.DebuggerStepThrough]
	internal static global::method <CrtImplementationDetails>.ThisModule.ResolveMethod<void\u0020const\u0020*\u0020__clrcall(void)>(global::method methodToken)
	{
		return global::<Module>.<CrtImplementationDetails>.ThisModule.Handle().ResolveMethodHandle(methodToken).GetFunctionPointer().ToPointer();
	}

	// Token: 0x06000063 RID: 99 RVA: 0x00022E90 File Offset: 0x00022290
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged | global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]
	internal unsafe static extern void* CRYPTO_malloc(int, sbyte*, int);

	// Token: 0x06000064 RID: 100 RVA: 0x00023100 File Offset: 0x00022500
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged | global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]
	internal unsafe static extern void BIO_clear_flags(global::bio_st*, int);

	// Token: 0x06000065 RID: 101 RVA: 0x00022E10 File Offset: 0x00022210
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged | global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]
	internal unsafe static extern void CRYPTO_free(void*);

	// Token: 0x06000066 RID: 102 RVA: 0x000BB84C File Offset: 0x000BAC4C
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.StdCall, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal static extern int WSAGetLastError();

	// Token: 0x06000067 RID: 103 RVA: 0x000237F0 File Offset: 0x00022BF0
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged | global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]
	internal unsafe static extern void BIO_set_flags(global::bio_st*, int);

	// Token: 0x06000068 RID: 104 RVA: 0x00090B30 File Offset: 0x0008FF30
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged | global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]
	internal unsafe static extern int SSL_state(global::ssl_st*);

	// Token: 0x06000069 RID: 105 RVA: 0x000BB382 File Offset: 0x000BA782
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern void* @new(uint);

	// Token: 0x0600006A RID: 106 RVA: 0x000BB370 File Offset: 0x000BA770
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern void clearerr(global::_iobuf*);

	// Token: 0x0600006B RID: 107 RVA: 0x000BB358 File Offset: 0x000BA758
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern long _time64(long*);

	// Token: 0x0600006C RID: 108 RVA: 0x00091CB0 File Offset: 0x000910B0
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged | global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]
	internal unsafe static extern int SSL_CTX_use_certificate(global::ssl_ctx_st*, global::x509_st*);

	// Token: 0x0600006D RID: 109 RVA: 0x00090A10 File Offset: 0x0008FE10
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged | global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]
	internal unsafe static extern int SSL_set_cipher_list(global::ssl_st*, sbyte*);

	// Token: 0x0600006E RID: 110 RVA: 0x000241A0 File Offset: 0x000235A0
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged | global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]
	internal unsafe static extern void EVP_PKEY_free(global::evp_pkey_st*);

	// Token: 0x0600006F RID: 111 RVA: 0x00092380 File Offset: 0x00091780
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged | global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]
	internal static extern void SSL_load_error_strings();

	// Token: 0x06000070 RID: 112 RVA: 0x0008F220 File Offset: 0x0008E620
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged | global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]
	internal unsafe static extern int SSL_CTX_check_private_key(global::ssl_ctx_st*);

	// Token: 0x06000071 RID: 113 RVA: 0x00024750 File Offset: 0x00023B50
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged | global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]
	internal unsafe static extern void X509_free(global::x509_st*);

	// Token: 0x06000072 RID: 114 RVA: 0x00023130 File Offset: 0x00022530
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged | global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]
	internal unsafe static extern int BIO_ctrl(global::bio_st*, int, int, void*);

	// Token: 0x06000073 RID: 115 RVA: 0x000BB37C File Offset: 0x000BA77C
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal static extern int _setmode(int, int);

	// Token: 0x06000074 RID: 116 RVA: 0x000909A0 File Offset: 0x0008FDA0
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged | global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]
	internal unsafe static extern void SSL_set_bio(global::ssl_st*, global::bio_st*, global::bio_st*);

	// Token: 0x06000075 RID: 117 RVA: 0x000242C0 File Offset: 0x000236C0
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged | global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]
	internal unsafe static extern global::evp_pkey_st* EVP_PKEY_new();

	// Token: 0x06000076 RID: 118 RVA: 0x000234C0 File Offset: 0x000228C0
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged | global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]
	internal unsafe static extern global::bio_st* BIO_new(global::bio_method_st*);

	// Token: 0x06000077 RID: 119 RVA: 0x000BB36A File Offset: 0x000BA76A
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern int ferror(global::_iobuf*);

	// Token: 0x06000078 RID: 120 RVA: 0x0008FB50 File Offset: 0x0008EF50
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged | global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]
	internal unsafe static extern int SSL_CTX_set_cipher_list(global::ssl_ctx_st*, sbyte*);

	// Token: 0x06000079 RID: 121 RVA: 0x00090930 File Offset: 0x0008FD30
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged | global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]
	internal unsafe static extern void SSL_set_accept_state(global::ssl_st*);

	// Token: 0x0600007A RID: 122 RVA: 0x00091B10 File Offset: 0x00090F10
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged | global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]
	internal unsafe static extern int SSL_CTX_use_PrivateKey(global::ssl_ctx_st*, global::evp_pkey_st*);

	// Token: 0x0600007B RID: 123 RVA: 0x000BB376 File Offset: 0x000BA776
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern int _fileno(global::_iobuf*);

	// Token: 0x0600007C RID: 124 RVA: 0x00024020 File Offset: 0x00023420
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged | global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]
	internal unsafe static extern global::PKCS12* d2i_PKCS12_bio(global::bio_st*, global::PKCS12**);

	// Token: 0x0600007D RID: 125 RVA: 0x000BB388 File Offset: 0x000BA788
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern void delete(void*);

	// Token: 0x0600007E RID: 126 RVA: 0x000921B0 File Offset: 0x000915B0
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged | global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]
	internal static extern int SSL_library_init();

	// Token: 0x0600007F RID: 127 RVA: 0x000BB394 File Offset: 0x000BA794
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal static extern void srand(uint);

	// Token: 0x06000080 RID: 128 RVA: 0x000BB38E File Offset: 0x000BA78E
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern int strcpy_s(sbyte*, uint, sbyte*);

	// Token: 0x06000081 RID: 129 RVA: 0x000BB39A File Offset: 0x000BA79A
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal static extern int rand();

	// Token: 0x06000082 RID: 130 RVA: 0x000247A0 File Offset: 0x00023BA0
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged | global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]
	internal unsafe static extern global::x509_st* X509_new();

	// Token: 0x06000083 RID: 131 RVA: 0x00090A70 File Offset: 0x0008FE70
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged | global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]
	internal unsafe static extern void SSL_set_connect_state(global::ssl_st*);

	// Token: 0x06000084 RID: 132 RVA: 0x000908E0 File Offset: 0x0008FCE0
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged | global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]
	internal unsafe static extern int SSL_read(global::ssl_st*, void*, int);

	// Token: 0x06000085 RID: 133 RVA: 0x0008F510 File Offset: 0x0008E910
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged | global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]
	internal unsafe static extern void SSL_CTX_free(global::ssl_ctx_st*);

	// Token: 0x06000086 RID: 134 RVA: 0x00090020 File Offset: 0x0008F420
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged | global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]
	internal unsafe static extern void SSL_free(global::ssl_st*);

	// Token: 0x06000087 RID: 135 RVA: 0x00090B50 File Offset: 0x0008FF50
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged | global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]
	internal unsafe static extern int SSL_write(global::ssl_st*, void*, int);

	// Token: 0x06000088 RID: 136 RVA: 0x0008F6D0 File Offset: 0x0008EAD0
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged | global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]
	internal unsafe static extern global::ssl_ctx_st* SSL_CTX_new(global::ssl_method_st*);

	// Token: 0x06000089 RID: 137 RVA: 0x00091D20 File Offset: 0x00091120
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged | global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]
	internal unsafe static extern int SSL_CTX_use_certificate_file(global::ssl_ctx_st*, sbyte*, int);

	// Token: 0x0600008A RID: 138 RVA: 0x00024ED0 File Offset: 0x000242D0
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged | global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]
	internal unsafe static extern void RAND_seed(void*, int);

	// Token: 0x0600008B RID: 139 RVA: 0x0008FBB0 File Offset: 0x0008EFB0
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged | global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]
	internal unsafe static extern void SSL_CTX_set_default_passwd_cb_userdata(global::ssl_ctx_st*, void*);

	// Token: 0x0600008C RID: 140 RVA: 0x00024040 File Offset: 0x00023440
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged | global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]
	internal static extern void OPENSSL_add_all_algorithms_noconf();

	// Token: 0x0600008D RID: 141 RVA: 0x00023F40 File Offset: 0x00023340
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged | global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]
	internal unsafe static extern global::bio_method_st* BIO_s_file();

	// Token: 0x0600008E RID: 142 RVA: 0x00091AF0 File Offset: 0x00090EF0
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged | global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]
	internal unsafe static extern global::ssl_method_st* TLSv1_2_server_method();

	// Token: 0x0600008F RID: 143 RVA: 0x00091B80 File Offset: 0x00090F80
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged | global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]
	internal unsafe static extern int SSL_CTX_use_PrivateKey_file(global::ssl_ctx_st*, sbyte*, int);

	// Token: 0x06000090 RID: 144 RVA: 0x0008FBC0 File Offset: 0x0008EFC0
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged | global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]
	internal unsafe static extern void SSL_CTX_set_psk_client_callback(global::ssl_ctx_st*, global::method);

	// Token: 0x06000091 RID: 145 RVA: 0x00090AE0 File Offset: 0x0008FEE0
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged | global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]
	internal unsafe static extern int SSL_shutdown(global::ssl_st*);

	// Token: 0x06000092 RID: 146 RVA: 0x00023490 File Offset: 0x00022890
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged | global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]
	internal unsafe static extern int BIO_int_ctrl(global::bio_st*, int, int, int);

	// Token: 0x06000093 RID: 147 RVA: 0x00024890 File Offset: 0x00023C90
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged | global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]
	internal unsafe static extern int PKCS12_parse(global::PKCS12*, sbyte*, global::evp_pkey_st**, global::x509_st**, global::stack_st_X509**);

	// Token: 0x06000094 RID: 148 RVA: 0x00024610 File Offset: 0x00023A10
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged | global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]
	internal unsafe static extern void PKCS12_free(global::PKCS12*);

	// Token: 0x06000095 RID: 149 RVA: 0x000923E0 File Offset: 0x000917E0
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged | global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]
	internal unsafe static extern global::ssl_method_st* TLSv1_2_client_method();

	// Token: 0x06000096 RID: 150 RVA: 0x000923F0 File Offset: 0x000917F0
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged | global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]
	internal unsafe static extern global::ssl_method_st* TLSv1_client_method();

	// Token: 0x06000097 RID: 151 RVA: 0x00090500 File Offset: 0x0008F900
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged | global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]
	internal unsafe static extern global::ssl_st* SSL_new(global::ssl_ctx_st*);

	// Token: 0x06000098 RID: 152 RVA: 0x000BB35E File Offset: 0x000BA75E
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern global::_iobuf* __iob_func();

	// Token: 0x06000099 RID: 153 RVA: 0x0008F6B0 File Offset: 0x0008EAB0
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged | global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]
	internal unsafe static extern int SSL_CTX_load_verify_locations(global::ssl_ctx_st*, sbyte*, sbyte*);

	// Token: 0x0600009A RID: 154 RVA: 0x0008FFC0 File Offset: 0x0008F3C0
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged | global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]
	internal unsafe static extern int SSL_do_handshake(global::ssl_st*);

	// Token: 0x0600009B RID: 155 RVA: 0x000902D0 File Offset: 0x0008F6D0
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged | global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]
	internal unsafe static extern int SSL_get_error(global::ssl_st*, int);

	// Token: 0x0600009C RID: 156 RVA: 0x000231F0 File Offset: 0x000225F0
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged | global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]
	internal unsafe static extern int BIO_free(global::bio_st*);

	// Token: 0x0600009D RID: 157 RVA: 0x0008FBD0 File Offset: 0x0008EFD0
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged | global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]
	internal unsafe static extern int SSL_accept(global::ssl_st*);

	// Token: 0x0600009E RID: 158 RVA: 0x0008F290 File Offset: 0x0008E690
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged | global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]
	internal unsafe static extern int SSL_CTX_ctrl(global::ssl_ctx_st*, int, int, void*);

	// Token: 0x0600009F RID: 159 RVA: 0x000BB364 File Offset: 0x000BA764
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern int feof(global::_iobuf*);

	// Token: 0x060000A0 RID: 160 RVA: 0x00091B00 File Offset: 0x00090F00
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged | global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]
	internal unsafe static extern global::ssl_method_st* TLSv1_server_method();

	// Token: 0x060000A1 RID: 161 RVA: 0x00022170 File Offset: 0x00021570
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged | global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]
	internal unsafe static extern void* _getFiberPtrId();

	// Token: 0x060000A2 RID: 162 RVA: 0x00021660 File Offset: 0x00020A60
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal static extern void _amsg_exit(int);

	// Token: 0x060000A3 RID: 163 RVA: 0x000218B2 File Offset: 0x00020CB2
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged | global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]
	internal static extern void __security_init_cookie();

	// Token: 0x060000A4 RID: 164 RVA: 0x000BB352 File Offset: 0x000BA752
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.StdCall, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal static extern void Sleep(uint);

	// Token: 0x060000A5 RID: 165 RVA: 0x000BB3A0 File Offset: 0x000BA7A0
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal static extern void _cexit();

	// Token: 0x060000A6 RID: 166 RVA: 0x000BB3A6 File Offset: 0x000BA7A6
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern int __FrameUnwindFilter(global::_EXCEPTION_POINTERS*);

	// Token: 0x04000001 RID: 1 RVA: 0x000BF298 File Offset: 0x000BE098
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0M@$$CBD ??_C@_0M@BCPGCFM@rudp?5socket?$AA@;

	// Token: 0x04000002 RID: 2 RVA: 0x000BF2A4 File Offset: 0x000BE0A4
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0BG@$$CBD ??_C@_0BG@LCDFPEM@OpenSSLBioAdapter?4cpp?$AA@;

	// Token: 0x04000003 RID: 3 RVA: 0x00102000 File Offset: 0x00100A00
	internal static global::bio_method_st methods_rudpp;

	// Token: 0x04000004 RID: 4 RVA: 0x000BF450 File Offset: 0x000BE250
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0BD@$$CBD ??_C@_0BD@IMKOCFAD@PSK?9AES128?9CBC?9SHA?$AA@;

	// Token: 0x04000005 RID: 5 RVA: 0x000BF464 File Offset: 0x000BE264
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0N@$$CBD ??_C@_0N@HKILAJND@PSK?9NULL?9SHA?$AA@;

	// Token: 0x04000006 RID: 6 RVA: 0x000BF474 File Offset: 0x000BE274
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0CA@$$CBD ??_C@_0CA@JBILJGGG@PSK?9AES128?9CBC?9SHA?3PSK?9NULL?9SHA?$AA@;

	// Token: 0x04000007 RID: 7 RVA: 0x000BF498 File Offset: 0x000BE298
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0BCI@$$CBD ??_C@_0BCI@EOBPDDIH@DHE?9RSA?9AES256?9SHA256?3AES256?9SHA@;

	// Token: 0x04000008 RID: 8 RVA: 0x000BF318 File Offset: 0x000BE118
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0BDD@$$CBD ??_C@_0BDD@BOJFIJEM@AES128?9SHA?3DHE?9RSA?9AES256?9SHA256@;

	// Token: 0x04000009 RID: 9 RVA: 0x00102248 File Offset: 0x00100C48
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0IB@D default_secl_key_id;

	// Token: 0x0400000A RID: 10 RVA: 0x001022CC File Offset: 0x00100CCC
	internal static int ?once@?1??OPENSSL_Applink@@YAPAPAXXZ@4HA;

	// Token: 0x0400000B RID: 11 RVA: 0x00102040 File Offset: 0x00100A40
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0CAA@E default_secl_key;

	// Token: 0x0400000C RID: 12 RVA: 0x00102240 File Offset: 0x00100C40
	internal static uint default_secl_key_len;

	// Token: 0x0400000D RID: 13 RVA: 0x001022D0 File Offset: 0x00100CD0
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0BH@PAX ?OPENSSL_ApplinkTable@?1??OPENSSL_Applink@@YAPAPAXXZ@4PAPAXA;

	// Token: 0x0400000E RID: 14 RVA: 0x000BF2BC File Offset: 0x000BE0BC
	public unsafe static int** __unep@?app_stdin@?A0xc1555744@@$$FYAPAXXZ;

	// Token: 0x0400000F RID: 15 RVA: 0x000BF2C0 File Offset: 0x000BE0C0
	public unsafe static int** __unep@?app_stdout@?A0xc1555744@@$$FYAPAXXZ;

	// Token: 0x04000010 RID: 16 RVA: 0x000BF2C4 File Offset: 0x000BE0C4
	public unsafe static int** __unep@?app_stderr@?A0xc1555744@@$$FYAPAXXZ;

	// Token: 0x04000011 RID: 17 RVA: 0x000BF2DC File Offset: 0x000BE0DC
	public unsafe static int** __unep@?app_feof@?A0xc1555744@@$$FYAHPAU_iobuf@@@Z;

	// Token: 0x04000012 RID: 18 RVA: 0x000BF2F4 File Offset: 0x000BE0F4
	public unsafe static int** __unep@?app_ferror@?A0xc1555744@@$$FYAHPAU_iobuf@@@Z;

	// Token: 0x04000013 RID: 19 RVA: 0x000BF2F8 File Offset: 0x000BE0F8
	public unsafe static int** __unep@?app_clearerr@?A0xc1555744@@$$FYAXPAU_iobuf@@@Z;

	// Token: 0x04000014 RID: 20 RVA: 0x000BF2FC File Offset: 0x000BE0FC
	public unsafe static int** __unep@?app_fileno@?A0xc1555744@@$$FYAHPAU_iobuf@@@Z;

	// Token: 0x04000015 RID: 21 RVA: 0x000BF2D8 File Offset: 0x000BE0D8
	public unsafe static int** __unep@?app_fsetmod@?A0xc1555744@@$$FYAHPAU_iobuf@@D@Z;

	// Token: 0x04000016 RID: 22 RVA: 0x000BF2C8 File Offset: 0x000BE0C8
	unsafe static int** __unep@?fprintf@@$$J0YAHPAU_iobuf@@PBDZZ;

	// Token: 0x04000017 RID: 23 RVA: 0x000BF2CC File Offset: 0x000BE0CC
	unsafe static int** __unep@?fgets@@$$J0YAPADPADHPAU_iobuf@@@Z;

	// Token: 0x04000018 RID: 24 RVA: 0x000BF2D0 File Offset: 0x000BE0D0
	unsafe static int** __unep@?fread@@$$J0YAIPAXIIPAU_iobuf@@@Z;

	// Token: 0x04000019 RID: 25 RVA: 0x000BF2D4 File Offset: 0x000BE0D4
	unsafe static int** __unep@?fwrite@@$$J0YAIPBXIIPAU_iobuf@@@Z;

	// Token: 0x0400001A RID: 26 RVA: 0x000BF2E0 File Offset: 0x000BE0E0
	unsafe static int** __unep@?fclose@@$$J0YAHPAU_iobuf@@@Z;

	// Token: 0x0400001B RID: 27 RVA: 0x000BF2E4 File Offset: 0x000BE0E4
	unsafe static int** __unep@?fopen@@$$J0YAPAU_iobuf@@PBD0@Z;

	// Token: 0x0400001C RID: 28 RVA: 0x000BF2E8 File Offset: 0x000BE0E8
	unsafe static int** __unep@?fseek@@$$J0YAHPAU_iobuf@@JH@Z;

	// Token: 0x0400001D RID: 29 RVA: 0x000BF2EC File Offset: 0x000BE0EC
	unsafe static int** __unep@?ftell@@$$J0YAJPAU_iobuf@@@Z;

	// Token: 0x0400001E RID: 30 RVA: 0x000BF2F0 File Offset: 0x000BE0F0
	unsafe static int** __unep@?fflush@@$$J0YAHPAU_iobuf@@@Z;

	// Token: 0x0400001F RID: 31 RVA: 0x000BF300 File Offset: 0x000BE100
	unsafe static int** __unep@?_open@@$$FYAHPBDHH@Z;

	// Token: 0x04000020 RID: 32 RVA: 0x000BF304 File Offset: 0x000BE104
	unsafe static int** __unep@?_read@@$$J0YAHHPAXI@Z;

	// Token: 0x04000021 RID: 33 RVA: 0x000BF308 File Offset: 0x000BE108
	unsafe static int** __unep@?_write@@$$J0YAHHPBXI@Z;

	// Token: 0x04000022 RID: 34 RVA: 0x000BF30C File Offset: 0x000BE10C
	unsafe static int** __unep@?_lseek@@$$J0YAJHJH@Z;

	// Token: 0x04000023 RID: 35 RVA: 0x000BF310 File Offset: 0x000BE110
	unsafe static int** __unep@?_close@@$$J0YAHH@Z;

	// Token: 0x04000024 RID: 36 RVA: 0x000BF44C File Offset: 0x000BE24C
	public unsafe static int** __unep@?secl_client_callback@@$$FYAIPAUssl_st@@PBDPADIPAEI@Z;

	// Token: 0x04000025 RID: 37 RVA: 0x0010AF11 File Offset: 0x00109911
	internal static global::std.piecewise_construct_t piecewise_construct;

	// Token: 0x04000026 RID: 38 RVA: 0x0010AF10 File Offset: 0x00109910
	internal static global::std.allocator_arg_t allocator_arg;

	// Token: 0x04000027 RID: 39 RVA: 0x000BF5C8 File Offset: 0x000BE3C8
	public unsafe static int** __unep@?PipeCreate@?A0x6f6a44a8@@$$J0YAHPAX@Z;

	// Token: 0x04000028 RID: 40 RVA: 0x000BF5CC File Offset: 0x000BE3CC
	public unsafe static int** __unep@?PipeClose@?A0x6f6a44a8@@$$J0YAHPAX@Z;

	// Token: 0x04000029 RID: 41 RVA: 0x000BF5C0 File Offset: 0x000BE3C0
	public unsafe static int** __unep@?PipeWrite@?A0x6f6a44a8@@$$J0YAHPAXPBDHH@Z;

	// Token: 0x0400002A RID: 42 RVA: 0x000BF5C4 File Offset: 0x000BE3C4
	public unsafe static int** __unep@?PipeRead@?A0x6f6a44a8@@$$J0YAHPAXPADHH@Z;

	// Token: 0x0400002B RID: 43 RVA: 0x000BF5DC File Offset: 0x000BE3DC
	internal static global::__s_GUID _GUID_90f1a06e_7712_4762_86b5_7a5eba6bdb02;

	// Token: 0x0400002C RID: 44 RVA: 0x000BF60C File Offset: 0x000BE40C
	internal static global::__s_GUID _GUID_cb2f6722_ab3a_11d2_9c40_00c04fa30a3e;

	// Token: 0x0400002D RID: 45 RVA: 0x000BF244 File Offset: 0x000BE044
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY00Q6MPBXXZ __xc_mp_z;

	// Token: 0x0400002E RID: 46
	[global::System.Runtime.CompilerServices.FixedAddressValueType]
	internal static int ?Uninitialized@CurrentDomain@<CrtImplementationDetails>@@$$Q2HA;

	// Token: 0x0400002F RID: 47 RVA: 0x000BF224 File Offset: 0x000BE024
	internal static global::method ?Uninitialized$initializer$@CurrentDomain@<CrtImplementationDetails>@@$$Q2P6MXXZA;

	// Token: 0x04000030 RID: 48 RVA: 0x000BF248 File Offset: 0x000BE048
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY00Q6MPBXXZ __xi_vt_a;

	// Token: 0x04000031 RID: 49
	[global::System.Runtime.CompilerServices.FixedAddressValueType]
	internal static global::<CrtImplementationDetails>.Progress.State ?InitializedPerAppDomain@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A;

	// Token: 0x04000032 RID: 50 RVA: 0x000BF238 File Offset: 0x000BE038
	internal static global::method ?InitializedPerAppDomain$initializer$@CurrentDomain@<CrtImplementationDetails>@@$$Q2P6MXXZA;

	// Token: 0x04000033 RID: 51
	[global::System.Runtime.CompilerServices.FixedAddressValueType]
	internal static bool ?IsDefaultDomain@CurrentDomain@<CrtImplementationDetails>@@$$Q2_NA;

	// Token: 0x04000034 RID: 52 RVA: 0x000BF228 File Offset: 0x000BE028
	internal static global::method ?IsDefaultDomain$initializer$@CurrentDomain@<CrtImplementationDetails>@@$$Q2P6MXXZA;

	// Token: 0x04000035 RID: 53 RVA: 0x000BF21C File Offset: 0x000BE01C
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY00Q6MPBXXZ __xc_ma_a;

	// Token: 0x04000036 RID: 54
	[global::System.Runtime.CompilerServices.FixedAddressValueType]
	internal static global::<CrtImplementationDetails>.Progress.State ?InitializedNative@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A;

	// Token: 0x04000037 RID: 55 RVA: 0x000BF230 File Offset: 0x000BE030
	internal static global::method ?InitializedNative$initializer$@CurrentDomain@<CrtImplementationDetails>@@$$Q2P6MXXZA;

	// Token: 0x04000038 RID: 56
	[global::System.Runtime.CompilerServices.FixedAddressValueType]
	internal static int ?Initialized@CurrentDomain@<CrtImplementationDetails>@@$$Q2HA;

	// Token: 0x04000039 RID: 57 RVA: 0x000BF220 File Offset: 0x000BE020
	internal static global::method ?Initialized$initializer$@CurrentDomain@<CrtImplementationDetails>@@$$Q2P6MXXZA;

	// Token: 0x0400003A RID: 58 RVA: 0x000BF23C File Offset: 0x000BE03C
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY00Q6MPBXXZ __xc_ma_z;

	// Token: 0x0400003B RID: 59
	[global::System.Runtime.CompilerServices.FixedAddressValueType]
	internal static global::<CrtImplementationDetails>.Progress.State ?InitializedVtables@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A;

	// Token: 0x0400003C RID: 60 RVA: 0x000BF22C File Offset: 0x000BE02C
	internal static global::method ?InitializedVtables$initializer$@CurrentDomain@<CrtImplementationDetails>@@$$Q2P6MXXZA;

	// Token: 0x0400003D RID: 61 RVA: 0x000BF24C File Offset: 0x000BE04C
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY00Q6MPBXXZ __xi_vt_z;

	// Token: 0x0400003E RID: 62 RVA: 0x000BF5FC File Offset: 0x000BE3FC
	internal static global::__s_GUID _GUID_cb2f6723_ab3a_11d2_9c40_00c04fa30a3e;

	// Token: 0x0400003F RID: 63
	[global::System.Runtime.CompilerServices.FixedAddressValueType]
	internal static global::<CrtImplementationDetails>.Progress.State ?InitializedPerProcess@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A;

	// Token: 0x04000040 RID: 64 RVA: 0x000BF234 File Offset: 0x000BE034
	internal static global::method ?InitializedPerProcess$initializer$@CurrentDomain@<CrtImplementationDetails>@@$$Q2P6MXXZA;

	// Token: 0x04000041 RID: 65 RVA: 0x0010B247 File Offset: 0x00109C47
	internal static bool ?InitializedPerProcess@DefaultDomain@<CrtImplementationDetails>@@2_NA;

	// Token: 0x04000042 RID: 66 RVA: 0x0010B244 File Offset: 0x00109C44
	internal static bool ?Entered@DefaultDomain@<CrtImplementationDetails>@@2_NA;

	// Token: 0x04000043 RID: 67 RVA: 0x0010B245 File Offset: 0x00109C45
	internal static bool ?InitializedNative@DefaultDomain@<CrtImplementationDetails>@@2_NA;

	// Token: 0x04000044 RID: 68 RVA: 0x0010B240 File Offset: 0x00109C40
	internal static int ?Count@AllDomains@<CrtImplementationDetails>@@2HA;

	// Token: 0x04000045 RID: 69 RVA: 0x00102380 File Offset: 0x00100D80
	internal static global::<CrtImplementationDetails>.TriBool.State ?hasNative@DefaultDomain@<CrtImplementationDetails>@@0W4State@TriBool@2@A;

	// Token: 0x04000046 RID: 70 RVA: 0x0010237C File Offset: 0x00100D7C
	internal static global::<CrtImplementationDetails>.TriBool.State ?hasPerProcess@DefaultDomain@<CrtImplementationDetails>@@0W4State@TriBool@2@A;

	// Token: 0x04000047 RID: 71 RVA: 0x0010B246 File Offset: 0x00109C46
	internal static bool ?InitializedNativeFromCCTOR@DefaultDomain@<CrtImplementationDetails>@@2_NA;

	// Token: 0x04000048 RID: 72 RVA: 0x000BF240 File Offset: 0x000BE040
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY00Q6MPBXXZ __xc_mp_a;

	// Token: 0x04000049 RID: 73 RVA: 0x000BF5EC File Offset: 0x000BE3EC
	internal static global::__s_GUID _GUID_90f1a06c_7712_4762_86b5_7a5eba6bdb02;

	// Token: 0x0400004A RID: 74 RVA: 0x000BF61C File Offset: 0x000BE41C
	public unsafe static int** __unep@?DoNothing@DefaultDomain@<CrtImplementationDetails>@@$$FCGJPAX@Z;

	// Token: 0x0400004B RID: 75 RVA: 0x000BF620 File Offset: 0x000BE420
	public unsafe static int** __unep@?_UninitializeDefaultDomain@LanguageSupport@<CrtImplementationDetails>@@$$FCGJPAX@Z;

	// Token: 0x0400004C RID: 76
	[global::System.Runtime.CompilerServices.FixedAddressValueType]
	internal static uint __exit_list_size_app_domain;

	// Token: 0x0400004D RID: 77
	[global::System.Runtime.CompilerServices.FixedAddressValueType]
	internal unsafe static global::method* __onexitbegin_app_domain;

	// Token: 0x0400004E RID: 78 RVA: 0x0010B354 File Offset: 0x00109D54
	internal static uint __exit_list_size;

	// Token: 0x0400004F RID: 79
	[global::System.Runtime.CompilerServices.FixedAddressValueType]
	internal unsafe static global::method* __onexitend_app_domain;

	// Token: 0x04000050 RID: 80 RVA: 0x0010B34C File Offset: 0x00109D4C
	internal unsafe static global::method* __onexitbegin_m;

	// Token: 0x04000051 RID: 81 RVA: 0x0010B350 File Offset: 0x00109D50
	internal unsafe static global::method* __onexitend_m;

	// Token: 0x04000052 RID: 82
	[global::System.Runtime.CompilerServices.FixedAddressValueType]
	internal unsafe static void* ?_lock@AtExitLock@<CrtImplementationDetails>@@$$Q0PAXA;

	// Token: 0x04000053 RID: 83
	[global::System.Runtime.CompilerServices.FixedAddressValueType]
	internal static int ?_ref_count@AtExitLock@<CrtImplementationDetails>@@$$Q0HA;

	// Token: 0x04000054 RID: 84 RVA: 0x000BF204 File Offset: 0x000BE004
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0A@P6AXXZ __xc_z;

	// Token: 0x04000055 RID: 85 RVA: 0x000BF1FC File Offset: 0x000BDFFC
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0A@P6AXXZ __xc_a;

	// Token: 0x04000056 RID: 86 RVA: 0x000BF208 File Offset: 0x000BE008
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0A@P6AHXZ __xi_a;

	// Token: 0x04000057 RID: 87 RVA: 0x0010D344 File Offset: 0x0010BD44
	internal static volatile global::__enative_startup_state __native_startup_state;

	// Token: 0x04000058 RID: 88 RVA: 0x000BF218 File Offset: 0x000BE018
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0A@P6AHXZ __xi_z;

	// Token: 0x04000059 RID: 89 RVA: 0x0010D340 File Offset: 0x0010BD40
	internal unsafe static volatile void* __native_startup_lock;

	// Token: 0x0400005A RID: 90 RVA: 0x00102370 File Offset: 0x00100D70
	internal static volatile uint __native_dllmain_reason;
}
