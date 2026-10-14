using System;
using System.Runtime.InteropServices;

namespace OpenSSL.Core
{
	// Token: 0x02000011 RID: 17
	public class CryptoUtil
	{
		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000071 RID: 113 RVA: 0x000030C4 File Offset: 0x000012C4
		public static string MD2_Options
		{
			get
			{
				return global::OpenSSL.Core.Native.MD2_options();
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000072 RID: 114 RVA: 0x000030CB File Offset: 0x000012CB
		public static string RC4_Options
		{
			get
			{
				return global::OpenSSL.Core.Native.RC4_options();
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000073 RID: 115 RVA: 0x000030D2 File Offset: 0x000012D2
		public static string DES_Options
		{
			get
			{
				return global::OpenSSL.Core.Native.DES_options();
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000074 RID: 116 RVA: 0x000030D9 File Offset: 0x000012D9
		public static string Idea_Options
		{
			get
			{
				return global::OpenSSL.Core.Native.idea_options();
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000075 RID: 117 RVA: 0x000030E0 File Offset: 0x000012E0
		public static string Blowfish_Options
		{
			get
			{
				return global::OpenSSL.Core.Native.BF_options();
			}
		}

		// Token: 0x06000076 RID: 118 RVA: 0x000030E7 File Offset: 0x000012E7
		public static void MallocDebugInit()
		{
			global::OpenSSL.Core.Native.CRYPTO_malloc_debug_init();
		}

		// Token: 0x06000077 RID: 119 RVA: 0x000030EE File Offset: 0x000012EE
		public static void SetDebugOptions(global::OpenSSL.Core.DebugOptions options)
		{
			global::OpenSSL.Core.Native.CRYPTO_dbg_set_options((int)options);
		}

		// Token: 0x06000078 RID: 120 RVA: 0x000030F6 File Offset: 0x000012F6
		public static void SetMemoryCheck(global::OpenSSL.Core.MemoryCheck options)
		{
			global::OpenSSL.Core.Native.CRYPTO_mem_ctrl((int)options);
		}

		// Token: 0x06000079 RID: 121 RVA: 0x000030FF File Offset: 0x000012FF
		public static void Cleanup()
		{
			global::OpenSSL.Core.Native.CRYPTO_cleanup_all_ex_data();
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00003106 File Offset: 0x00001306
		public static void RemoveState(uint value)
		{
			global::OpenSSL.Core.Native.ERR_remove_state(value);
		}

		// Token: 0x0600007B RID: 123 RVA: 0x0000310E File Offset: 0x0000130E
		public static void CheckMemoryLeaks(global::OpenSSL.Core.CryptoUtil.MemoryLeakHandler callback)
		{
			global::OpenSSL.Core.Native.CRYPTO_mem_leaks_cb(callback);
		}

		// Token: 0x02000012 RID: 18
		// (Invoke) Token: 0x0600007E RID: 126
		[global::System.Runtime.InteropServices.UnmanagedFunctionPointer(global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public delegate void MemoryLeakHandler(uint order, global::System.IntPtr file, int line, int num_bytes, global::System.IntPtr addr);
	}
}
