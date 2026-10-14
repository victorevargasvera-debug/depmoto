using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;

namespace OpenSSL.Core
{
	// Token: 0x0200003E RID: 62
	internal class Native
	{
		// Token: 0x06000149 RID: 329 RVA: 0x000054F8 File Offset: 0x000036F8
		static Native()
		{
			global::OpenSSL.Core.Version library = global::OpenSSL.Core.Version.Library;
			global::OpenSSL.Core.Version wrapper = global::OpenSSL.Core.Version.Wrapper;
			uint num = library.Raw & 4294963200U;
			if (num != wrapper.Raw)
			{
				throw new global::System.Exception(string.Format("Invalid version of {0}, expecting {1}, got: {2}", "libeay32", wrapper, library));
			}
			if (global::OpenSSL.Core.FIPS.Enabled && global::OpenSSL.Core.Native.FIPS_mode_set(1) == 0)
			{
				throw new global::System.Exception("Failed to initialize FIPS mode");
			}
			global::OpenSSL.Core.Native.ERR_load_crypto_strings();
			global::OpenSSL.Core.Native.SSL_load_error_strings();
			global::OpenSSL.Core.Native.OPENSSL_add_all_algorithms_noconf();
			global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.SSL_library_init());
			byte[] array = new byte[128];
			global::System.Security.Cryptography.RandomNumberGenerator randomNumberGenerator = global::System.Security.Cryptography.RandomNumberGenerator.Create();
			randomNumberGenerator.GetBytes(array);
			global::OpenSSL.Core.Native.RAND_seed(array, array.Length);
		}

		// Token: 0x0600014A RID: 330 RVA: 0x000055EC File Offset: 0x000037EC
		public static void InitializeThreads()
		{
			int num = global::OpenSSL.Core.Native.CRYPTO_num_locks();
			global::OpenSSL.Core.Native.lock_objects = new global::System.Collections.Generic.List<object>(num);
			for (int i = 0; i < num; i++)
			{
				object item = new object();
				global::OpenSSL.Core.Native.lock_objects.Add(item);
			}
			global::OpenSSL.Core.Native.threadIDs = new global::System.Collections.Generic.Stack<uint>();
			global::OpenSSL.Core.Native.CRYPTO_locking_callback_delegate = new global::OpenSSL.Core.Native.CRYPTO_locking_callback(global::OpenSSL.Core.Native.LockingCallback);
			global::OpenSSL.Core.Native.CRYPTO_set_locking_callback(global::OpenSSL.Core.Native.CRYPTO_locking_callback_delegate);
			global::OpenSSL.Core.Native.CRYPTO_id_callback_delegate = new global::OpenSSL.Core.Native.CRYPTO_id_callback(global::OpenSSL.Core.Native.ThreadIDCallback);
			global::OpenSSL.Core.Native.CRYPTO_set_id_callback(global::OpenSSL.Core.Native.CRYPTO_id_callback_delegate);
		}

		// Token: 0x0600014B RID: 331 RVA: 0x00005668 File Offset: 0x00003868
		public static void UninitializeThreads()
		{
			global::OpenSSL.Core.Native.CRYPTO_set_locking_callback(null);
			global::OpenSSL.Core.Native.lock_objects.Clear();
			global::OpenSSL.Core.Native.CRYPTO_set_id_callback(null);
			if (global::OpenSSL.Core.Native.threadIDs != null)
			{
				foreach (uint pid in global::OpenSSL.Core.Native.threadIDs)
				{
					global::OpenSSL.Core.Native.ERR_remove_state(pid);
				}
			}
		}

		// Token: 0x0600014C RID: 332
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern string SSLeay_version(int type);

		// Token: 0x0600014D RID: 333
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern uint SSLeay();

		// Token: 0x0600014E RID: 334
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern string BN_options();

		// Token: 0x0600014F RID: 335
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern string MD2_options();

		// Token: 0x06000150 RID: 336
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern string RC4_options();

		// Token: 0x06000151 RID: 337
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern string DES_options();

		// Token: 0x06000152 RID: 338
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern string idea_options();

		// Token: 0x06000153 RID: 339
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern string BF_options();

		// Token: 0x06000154 RID: 340
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern void CRYPTO_set_id_callback(global::OpenSSL.Core.Native.CRYPTO_id_callback cb);

		// Token: 0x06000155 RID: 341
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern void CRYPTO_set_locking_callback(global::OpenSSL.Core.Native.CRYPTO_locking_callback cb);

		// Token: 0x06000156 RID: 342
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int CRYPTO_num_locks();

		// Token: 0x06000157 RID: 343
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int CRYPTO_add_lock(global::System.IntPtr ptr, int amount, global::OpenSSL.Core.CryptoLockTypes type, string file, int line);

		// Token: 0x06000158 RID: 344 RVA: 0x000056D8 File Offset: 0x000038D8
		public static void LockingCallback(int mode, int type, string file, int line)
		{
			if ((mode & 1) == 1)
			{
				global::System.Threading.Monitor.Enter(global::OpenSSL.Core.Native.lock_objects[type]);
				return;
			}
			global::System.Threading.Monitor.Exit(global::OpenSSL.Core.Native.lock_objects[type]);
		}

		// Token: 0x06000159 RID: 345 RVA: 0x00005704 File Offset: 0x00003904
		public static uint ThreadIDCallback()
		{
			uint managedThreadId = (uint)global::System.Threading.Thread.CurrentThread.ManagedThreadId;
			if (!global::OpenSSL.Core.Native.threadIDs.Contains(managedThreadId))
			{
				global::OpenSSL.Core.Native.threadIDs.Push(managedThreadId);
			}
			return managedThreadId;
		}

		// Token: 0x0600015A RID: 346
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern void OPENSSL_add_all_algorithms_noconf();

		// Token: 0x0600015B RID: 347
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern void OPENSSL_add_all_algorithms_conf();

		// Token: 0x0600015C RID: 348 RVA: 0x00005735 File Offset: 0x00003935
		public static void OPENSSL_free(global::System.IntPtr p)
		{
			global::OpenSSL.Core.Native.CRYPTO_free(p);
		}

		// Token: 0x0600015D RID: 349 RVA: 0x0000573D File Offset: 0x0000393D
		public static global::System.IntPtr OPENSSL_malloc(int cbSize)
		{
			return global::OpenSSL.Core.Native.CRYPTO_malloc(cbSize, global::System.Reflection.Assembly.GetExecutingAssembly().FullName, 0);
		}

		// Token: 0x0600015E RID: 350
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern void CRYPTO_free(global::System.IntPtr p);

		// Token: 0x0600015F RID: 351
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr CRYPTO_malloc(int num, string file, int line);

		// Token: 0x06000160 RID: 352
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr CRYPTO_realloc(global::System.IntPtr ptr, int num, string file, int line);

		// Token: 0x06000161 RID: 353 RVA: 0x00005750 File Offset: 0x00003950
		public static void CRYPTO_malloc_debug_init()
		{
			global::OpenSSL.Core.Native.CRYPTO_set_mem_debug_functions(global::OpenSSL.Core.Native.ptr_CRYPTO_dbg_malloc, global::OpenSSL.Core.Native.ptr_CRYPTO_dbg_realloc, global::OpenSSL.Core.Native.ptr_CRYPTO_dbg_free, global::OpenSSL.Core.Native.ptr_CRYPTO_dbg_set_options, global::OpenSSL.Core.Native.ptr_CRYPTO_dbg_get_options);
		}

		// Token: 0x06000162 RID: 354
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern void CRYPTO_dbg_malloc(global::System.IntPtr addr, int num, global::System.IntPtr file, int line, int before_p);

		// Token: 0x06000163 RID: 355
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern void CRYPTO_dbg_realloc(global::System.IntPtr addr1, global::System.IntPtr addr2, int num, global::System.IntPtr file, int line, int before_p);

		// Token: 0x06000164 RID: 356
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern void CRYPTO_dbg_free(global::System.IntPtr addr, int before_p);

		// Token: 0x06000165 RID: 357
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern void CRYPTO_dbg_set_options(int bits);

		// Token: 0x06000166 RID: 358
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int CRYPTO_dbg_get_options();

		// Token: 0x06000167 RID: 359
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int CRYPTO_set_mem_debug_functions(global::OpenSSL.Core.Native.MallocFunctionPtr m, global::OpenSSL.Core.Native.ReallocFunctionPtr r, global::OpenSSL.Core.Native.FreeFunctionPtr f, global::OpenSSL.Core.Native.SetOptionsFunctionPtr so, global::OpenSSL.Core.Native.GetOptionsFunctionPtr go);

		// Token: 0x06000168 RID: 360
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int CRYPTO_mem_ctrl(int mode);

		// Token: 0x06000169 RID: 361
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern void CRYPTO_cleanup_all_ex_data();

		// Token: 0x0600016A RID: 362
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern void CRYPTO_mem_leaks(global::System.IntPtr bio);

		// Token: 0x0600016B RID: 363
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern void CRYPTO_mem_leaks_cb(global::OpenSSL.Core.CryptoUtil.MemoryLeakHandler cb);

		// Token: 0x0600016C RID: 364
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern void OBJ_NAME_do_all(int type, global::OpenSSL.Core.Native.ObjectNameHandler fn, global::System.IntPtr arg);

		// Token: 0x0600016D RID: 365
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern void OBJ_NAME_do_all_sorted(int type, global::OpenSSL.Core.Native.ObjectNameHandler fn, global::System.IntPtr arg);

		// Token: 0x0600016E RID: 366
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int OBJ_txt2nid(string s);

		// Token: 0x0600016F RID: 367
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr OBJ_nid2obj(int n);

		// Token: 0x06000170 RID: 368
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr OBJ_nid2ln(int n);

		// Token: 0x06000171 RID: 369
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr OBJ_nid2sn(int n);

		// Token: 0x06000172 RID: 370
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int OBJ_obj2nid(global::System.IntPtr o);

		// Token: 0x06000173 RID: 371
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr OBJ_txt2obj(byte[] s, int no_name);

		// Token: 0x06000174 RID: 372
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int OBJ_ln2nid(byte[] s);

		// Token: 0x06000175 RID: 373
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int OBJ_sn2nid(byte[] s);

		// Token: 0x06000176 RID: 374
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr sk_new_null();

		// Token: 0x06000177 RID: 375
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int sk_num(global::System.IntPtr stack);

		// Token: 0x06000178 RID: 376
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int sk_find(global::System.IntPtr stack, global::System.IntPtr data);

		// Token: 0x06000179 RID: 377
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int sk_insert(global::System.IntPtr stack, global::System.IntPtr data, int where);

		// Token: 0x0600017A RID: 378
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr sk_shift(global::System.IntPtr stack);

		// Token: 0x0600017B RID: 379
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int sk_unshift(global::System.IntPtr stack, global::System.IntPtr data);

		// Token: 0x0600017C RID: 380
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int sk_push(global::System.IntPtr stack, global::System.IntPtr data);

		// Token: 0x0600017D RID: 381
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr sk_pop(global::System.IntPtr stack);

		// Token: 0x0600017E RID: 382
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr sk_delete(global::System.IntPtr stack, int loc);

		// Token: 0x0600017F RID: 383
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr sk_delete_ptr(global::System.IntPtr stack, global::System.IntPtr p);

		// Token: 0x06000180 RID: 384
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr sk_value(global::System.IntPtr stack, int index);

		// Token: 0x06000181 RID: 385
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr sk_set(global::System.IntPtr stack, int index, global::System.IntPtr data);

		// Token: 0x06000182 RID: 386
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr sk_dup(global::System.IntPtr stack);

		// Token: 0x06000183 RID: 387
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern void sk_zero(global::System.IntPtr stack);

		// Token: 0x06000184 RID: 388
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern void sk_free(global::System.IntPtr stack);

		// Token: 0x06000185 RID: 389
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr ASN1_INTEGER_new();

		// Token: 0x06000186 RID: 390
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern void ASN1_INTEGER_free(global::System.IntPtr x);

		// Token: 0x06000187 RID: 391
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int ASN1_INTEGER_set(global::System.IntPtr a, int v);

		// Token: 0x06000188 RID: 392
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int ASN1_INTEGER_get(global::System.IntPtr a);

		// Token: 0x06000189 RID: 393
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr ASN1_TIME_set(global::System.IntPtr s, long t);

		// Token: 0x0600018A RID: 394
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int ASN1_UTCTIME_print(global::System.IntPtr bp, global::System.IntPtr a);

		// Token: 0x0600018B RID: 395
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr ASN1_TIME_new();

		// Token: 0x0600018C RID: 396
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern void ASN1_TIME_free(global::System.IntPtr x);

		// Token: 0x0600018D RID: 397
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr ASN1_STRING_type_new(int type);

		// Token: 0x0600018E RID: 398
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr ASN1_STRING_dup(global::System.IntPtr a);

		// Token: 0x0600018F RID: 399
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern void ASN1_STRING_free(global::System.IntPtr a);

		// Token: 0x06000190 RID: 400
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int ASN1_STRING_cmp(global::System.IntPtr a, global::System.IntPtr b);

		// Token: 0x06000191 RID: 401
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int ASN1_STRING_set(global::System.IntPtr str, byte[] data, int len);

		// Token: 0x06000192 RID: 402
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr ASN1_STRING_data(global::System.IntPtr x);

		// Token: 0x06000193 RID: 403
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int ASN1_STRING_length(global::System.IntPtr x);

		// Token: 0x06000194 RID: 404
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern void ASN1_OBJECT_free(global::System.IntPtr obj);

		// Token: 0x06000195 RID: 405
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr X509_REQ_new();

		// Token: 0x06000196 RID: 406
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int X509_REQ_set_version(global::System.IntPtr x, int version);

		// Token: 0x06000197 RID: 407
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int X509_REQ_set_pubkey(global::System.IntPtr x, global::System.IntPtr pkey);

		// Token: 0x06000198 RID: 408
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr X509_REQ_get_pubkey(global::System.IntPtr req);

		// Token: 0x06000199 RID: 409
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int X509_REQ_set_subject_name(global::System.IntPtr x, global::System.IntPtr name);

		// Token: 0x0600019A RID: 410
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int X509_REQ_sign(global::System.IntPtr x, global::System.IntPtr pkey, global::System.IntPtr md);

		// Token: 0x0600019B RID: 411
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int X509_REQ_verify(global::System.IntPtr x, global::System.IntPtr pkey);

		// Token: 0x0600019C RID: 412
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int X509_REQ_digest(global::System.IntPtr data, global::System.IntPtr type, byte[] md, ref uint len);

		// Token: 0x0600019D RID: 413
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern void X509_REQ_free(global::System.IntPtr a);

		// Token: 0x0600019E RID: 414
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr X509_REQ_to_X509(global::System.IntPtr r, int days, global::System.IntPtr pkey);

		// Token: 0x0600019F RID: 415
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int X509_REQ_print_ex(global::System.IntPtr bp, global::System.IntPtr x, uint nmflag, uint cflag);

		// Token: 0x060001A0 RID: 416
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int X509_REQ_print(global::System.IntPtr bp, global::System.IntPtr x);

		// Token: 0x060001A1 RID: 417
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr X509_new();

		// Token: 0x060001A2 RID: 418
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr X509_dup(global::System.IntPtr x509);

		// Token: 0x060001A3 RID: 419
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int X509_cmp(global::System.IntPtr a, global::System.IntPtr b);

		// Token: 0x060001A4 RID: 420
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int X509_sign(global::System.IntPtr x, global::System.IntPtr pkey, global::System.IntPtr md);

		// Token: 0x060001A5 RID: 421
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int X509_check_private_key(global::System.IntPtr x509, global::System.IntPtr pkey);

		// Token: 0x060001A6 RID: 422
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int X509_verify(global::System.IntPtr x, global::System.IntPtr pkey);

		// Token: 0x060001A7 RID: 423
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int X509_pubkey_digest(global::System.IntPtr data, global::System.IntPtr type, byte[] md, ref uint len);

		// Token: 0x060001A8 RID: 424
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int X509_digest(global::System.IntPtr data, global::System.IntPtr type, byte[] md, ref uint len);

		// Token: 0x060001A9 RID: 425
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int X509_set_version(global::System.IntPtr x, int version);

		// Token: 0x060001AA RID: 426
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int X509_set_serialNumber(global::System.IntPtr x, global::System.IntPtr serial);

		// Token: 0x060001AB RID: 427
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr X509_get_serialNumber(global::System.IntPtr x);

		// Token: 0x060001AC RID: 428
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int X509_set_issuer_name(global::System.IntPtr x, global::System.IntPtr name);

		// Token: 0x060001AD RID: 429
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr X509_get_issuer_name(global::System.IntPtr a);

		// Token: 0x060001AE RID: 430
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int X509_set_subject_name(global::System.IntPtr x, global::System.IntPtr name);

		// Token: 0x060001AF RID: 431
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr X509_get_subject_name(global::System.IntPtr a);

		// Token: 0x060001B0 RID: 432
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int X509_set_notBefore(global::System.IntPtr x, global::System.IntPtr tm);

		// Token: 0x060001B1 RID: 433
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int X509_set_notAfter(global::System.IntPtr x, global::System.IntPtr tm);

		// Token: 0x060001B2 RID: 434
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int X509_set_pubkey(global::System.IntPtr x, global::System.IntPtr pkey);

		// Token: 0x060001B3 RID: 435
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr X509_get_pubkey(global::System.IntPtr x);

		// Token: 0x060001B4 RID: 436
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern void X509_free(global::System.IntPtr x);

		// Token: 0x060001B5 RID: 437
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int X509_verify_cert(global::System.IntPtr ctx);

		// Token: 0x060001B6 RID: 438
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr X509_verify_cert_error_string(int n);

		// Token: 0x060001B7 RID: 439
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr X509_to_X509_REQ(global::System.IntPtr x, global::System.IntPtr pkey, global::System.IntPtr md);

		// Token: 0x060001B8 RID: 440
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int X509_print_ex(global::System.IntPtr bp, global::System.IntPtr x, uint nmflag, uint cflag);

		// Token: 0x060001B9 RID: 441
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int X509_print(global::System.IntPtr bp, global::System.IntPtr x);

		// Token: 0x060001BA RID: 442
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr X509_find_by_issuer_and_serial(global::System.IntPtr sk, global::System.IntPtr name, global::System.IntPtr serial);

		// Token: 0x060001BB RID: 443
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr X509_find_by_subject(global::System.IntPtr sk, global::System.IntPtr name);

		// Token: 0x060001BC RID: 444
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int X509_check_trust(global::System.IntPtr x, int id, int flags);

		// Token: 0x060001BD RID: 445
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr X509_time_adj(global::System.IntPtr s, int adj, ref long t);

		// Token: 0x060001BE RID: 446
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr X509_gmtime_adj(global::System.IntPtr s, int adj);

		// Token: 0x060001BF RID: 447
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr d2i_X509_bio(global::System.IntPtr bp, ref global::System.IntPtr x509);

		// Token: 0x060001C0 RID: 448
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int i2d_X509_bio(global::System.IntPtr bp, global::System.IntPtr x509);

		// Token: 0x060001C1 RID: 449
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern void X509_PUBKEY_free(global::System.IntPtr pkey);

		// Token: 0x060001C2 RID: 450
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern void X509_OBJECT_up_ref_count(global::System.IntPtr a);

		// Token: 0x060001C3 RID: 451
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern void X509_OBJECT_free_contents(global::System.IntPtr a);

		// Token: 0x060001C4 RID: 452
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr X509_EXTENSION_new();

		// Token: 0x060001C5 RID: 453
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern void X509_EXTENSION_free(global::System.IntPtr x);

		// Token: 0x060001C6 RID: 454
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr X509_EXTENSION_dup(global::System.IntPtr ex);

		// Token: 0x060001C7 RID: 455
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int X509V3_EXT_print(global::System.IntPtr bio, global::System.IntPtr ext, uint flag, int indent);

		// Token: 0x060001C8 RID: 456
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr X509V3_EXT_get_nid(int nid);

		// Token: 0x060001C9 RID: 457
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int X509_add_ext(global::System.IntPtr x, global::System.IntPtr ex, int loc);

		// Token: 0x060001CA RID: 458
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int X509_add1_ext_i2d(global::System.IntPtr x, int nid, byte[] value, int crit, uint flags);

		// Token: 0x060001CB RID: 459
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr X509V3_EXT_conf_nid(global::System.IntPtr conf, global::System.IntPtr ctx, int ext_nid, string value);

		// Token: 0x060001CC RID: 460
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr X509_EXTENSION_create_by_NID(global::System.IntPtr ex, int nid, int crit, global::System.IntPtr data);

		// Token: 0x060001CD RID: 461
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int X509_EXTENSION_set_critical(global::System.IntPtr ex, int crit);

		// Token: 0x060001CE RID: 462
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int X509_EXTENSION_set_data(global::System.IntPtr ex, global::System.IntPtr data);

		// Token: 0x060001CF RID: 463
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr X509_EXTENSION_get_object(global::System.IntPtr ex);

		// Token: 0x060001D0 RID: 464
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr X509_EXTENSION_get_data(global::System.IntPtr ne);

		// Token: 0x060001D1 RID: 465
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int X509_EXTENSION_get_critical(global::System.IntPtr ex);

		// Token: 0x060001D2 RID: 466
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr X509_STORE_new();

		// Token: 0x060001D3 RID: 467
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int X509_STORE_add_cert(global::System.IntPtr ctx, global::System.IntPtr x);

		// Token: 0x060001D4 RID: 468
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern void X509_STORE_free(global::System.IntPtr x);

		// Token: 0x060001D5 RID: 469
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr X509_STORE_CTX_new();

		// Token: 0x060001D6 RID: 470
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int X509_STORE_CTX_init(global::System.IntPtr ctx, global::System.IntPtr store, global::System.IntPtr x509, global::System.IntPtr chain);

		// Token: 0x060001D7 RID: 471
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern void X509_STORE_CTX_free(global::System.IntPtr x);

		// Token: 0x060001D8 RID: 472
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr X509_STORE_CTX_get_current_cert(global::System.IntPtr x509_store_ctx);

		// Token: 0x060001D9 RID: 473
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int X509_STORE_CTX_get_error_depth(global::System.IntPtr x509_store_ctx);

		// Token: 0x060001DA RID: 474
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int X509_STORE_CTX_get_error(global::System.IntPtr x509_store_ctx);

		// Token: 0x060001DB RID: 475
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern void X509_STORE_CTX_set_error(global::System.IntPtr x509_store_ctx, int error);

		// Token: 0x060001DC RID: 476
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern void X509_INFO_free(global::System.IntPtr a);

		// Token: 0x060001DD RID: 477
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr X509_NAME_new();

		// Token: 0x060001DE RID: 478
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern void X509_NAME_free(global::System.IntPtr a);

		// Token: 0x060001DF RID: 479
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr X509_NAME_dup(global::System.IntPtr xn);

		// Token: 0x060001E0 RID: 480
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int X509_NAME_cmp(global::System.IntPtr a, global::System.IntPtr b);

		// Token: 0x060001E1 RID: 481
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int X509_NAME_entry_count(global::System.IntPtr name);

		// Token: 0x060001E2 RID: 482
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int X509_NAME_add_entry_by_NID(global::System.IntPtr name, int nid, int type, byte[] bytes, int len, int loc, int set);

		// Token: 0x060001E3 RID: 483
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int X509_NAME_add_entry_by_txt(global::System.IntPtr name, byte[] field, int type, byte[] bytes, int len, int loc, int set);

		// Token: 0x060001E4 RID: 484
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int X509_NAME_get_text_by_NID(global::System.IntPtr name, int nid, byte[] buf, int len);

		// Token: 0x060001E5 RID: 485
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr X509_NAME_get_entry(global::System.IntPtr name, int loc);

		// Token: 0x060001E6 RID: 486
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr X509_NAME_delete_entry(global::System.IntPtr name, int loc);

		// Token: 0x060001E7 RID: 487
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int X509_NAME_get_index_by_NID(global::System.IntPtr name, int nid, int lastpos);

		// Token: 0x060001E8 RID: 488
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int X509_NAME_digest(global::System.IntPtr data, global::System.IntPtr type, byte[] md, ref uint len);

		// Token: 0x060001E9 RID: 489
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr X509_NAME_oneline(global::System.IntPtr a, byte[] buf, int size);

		// Token: 0x060001EA RID: 490
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int X509_NAME_print(global::System.IntPtr bp, global::System.IntPtr name, int obase);

		// Token: 0x060001EB RID: 491
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int X509_NAME_print_ex(global::System.IntPtr bp, global::System.IntPtr nm, int indent, uint flags);

		// Token: 0x060001EC RID: 492
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern void RAND_cleanup();

		// Token: 0x060001ED RID: 493
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern void RAND_seed(byte[] buf, int len);

		// Token: 0x060001EE RID: 494
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int RAND_pseudo_bytes(byte[] buf, int len);

		// Token: 0x060001EF RID: 495
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int RAND_bytes(byte[] buf, int num);

		// Token: 0x060001F0 RID: 496
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern void RAND_add(byte[] buf, int num, double entropy);

		// Token: 0x060001F1 RID: 497
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int RAND_load_file(string file, int max_bytes);

		// Token: 0x060001F2 RID: 498
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int RAND_write_file(string file);

		// Token: 0x060001F3 RID: 499
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern string RAND_file_name(byte[] buf, uint num);

		// Token: 0x060001F4 RID: 500
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int RAND_status();

		// Token: 0x060001F5 RID: 501
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int RAND_query_egd_bytes(string path, byte[] buf, int bytes);

		// Token: 0x060001F6 RID: 502
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int RAND_egd(string path);

		// Token: 0x060001F7 RID: 503
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int RAND_egd_bytes(string path, int bytes);

		// Token: 0x060001F8 RID: 504
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int RAND_poll();

		// Token: 0x060001F9 RID: 505
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int BN_rand(global::System.IntPtr rnd, int bits, int top, int bottom);

		// Token: 0x060001FA RID: 506
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int BN_pseudo_rand(global::System.IntPtr rnd, int bits, int top, int bottom);

		// Token: 0x060001FB RID: 507
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int BN_rand_range(global::System.IntPtr rnd, global::System.IntPtr range);

		// Token: 0x060001FC RID: 508
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int BN_pseudo_rand_range(global::System.IntPtr rnd, global::System.IntPtr range);

		// Token: 0x060001FD RID: 509
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int DSA_generate_parameters_ex(global::System.IntPtr dsa, int bits, byte[] seed, int seed_len, out int counter_ret, out int h_ret, global::OpenSSL.Core.Native.bn_gencb_st callback);

		// Token: 0x060001FE RID: 510
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int DSA_generate_key(global::System.IntPtr dsa);

		// Token: 0x060001FF RID: 511
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr DSA_new();

		// Token: 0x06000200 RID: 512
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern void DSA_free(global::System.IntPtr dsa);

		// Token: 0x06000201 RID: 513
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int DSA_size(global::System.IntPtr dsa);

		// Token: 0x06000202 RID: 514
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int DSAparams_print(global::System.IntPtr bp, global::System.IntPtr x);

		// Token: 0x06000203 RID: 515
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int DSA_print(global::System.IntPtr bp, global::System.IntPtr x, int off);

		// Token: 0x06000204 RID: 516
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int DSA_sign(int type, byte[] dgst, int dlen, byte[] sig, out uint siglen, global::System.IntPtr dsa);

		// Token: 0x06000205 RID: 517
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int DSA_verify(int type, byte[] dgst, int dgst_len, byte[] sigbuf, int siglen, global::System.IntPtr dsa);

		// Token: 0x06000206 RID: 518
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr RSA_new();

		// Token: 0x06000207 RID: 519
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern void RSA_free(global::System.IntPtr rsa);

		// Token: 0x06000208 RID: 520
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int RSA_size(global::System.IntPtr rsa);

		// Token: 0x06000209 RID: 521
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int RSA_generate_key_ex(global::System.IntPtr rsa, int bits, global::System.IntPtr e, global::OpenSSL.Core.Native.bn_gencb_st cb);

		// Token: 0x0600020A RID: 522
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int RSA_check_key(global::System.IntPtr rsa);

		// Token: 0x0600020B RID: 523
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int RSA_public_encrypt(int flen, byte[] from, byte[] to, global::System.IntPtr rsa, int padding);

		// Token: 0x0600020C RID: 524
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int RSA_private_encrypt(int flen, byte[] from, byte[] to, global::System.IntPtr rsa, int padding);

		// Token: 0x0600020D RID: 525
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int RSA_public_decrypt(int flen, byte[] from, byte[] to, global::System.IntPtr rsa, int padding);

		// Token: 0x0600020E RID: 526
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int RSA_private_decrypt(int flen, byte[] from, byte[] to, global::System.IntPtr rsa, int padding);

		// Token: 0x0600020F RID: 527
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int RSA_sign(int type, byte[] m, uint m_length, byte[] sigret, out uint siglen, global::System.IntPtr rsa);

		// Token: 0x06000210 RID: 528
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int RSA_verify(int type, byte[] m, uint m_length, byte[] sigbuf, uint siglen, global::System.IntPtr rsa);

		// Token: 0x06000211 RID: 529
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int RSA_print(global::System.IntPtr bp, global::System.IntPtr r, int offset);

		// Token: 0x06000212 RID: 530
		[global::System.Runtime.InteropServices.DllImport("ssleay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern void SSL_CTX_set_tmp_dh_callback(global::System.IntPtr ctx, global::System.IntPtr delegatee);

		// Token: 0x06000213 RID: 531
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr DH_generate_parameters(int prime_len, int generator, global::System.IntPtr callback, global::System.IntPtr cb_arg);

		// Token: 0x06000214 RID: 532
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int DH_generate_parameters_ex(global::System.IntPtr dh, int prime_len, int generator, global::OpenSSL.Core.Native.bn_gencb_st cb);

		// Token: 0x06000215 RID: 533
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int DH_generate_key(global::System.IntPtr dh);

		// Token: 0x06000216 RID: 534
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int DH_compute_key(byte[] key, global::System.IntPtr pub_key, global::System.IntPtr dh);

		// Token: 0x06000217 RID: 535
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr DH_new();

		// Token: 0x06000218 RID: 536
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern void DH_free(global::System.IntPtr dh);

		// Token: 0x06000219 RID: 537
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int DH_check(global::System.IntPtr dh, out int codes);

		// Token: 0x0600021A RID: 538
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int DHparams_print(global::System.IntPtr bp, global::System.IntPtr x);

		// Token: 0x0600021B RID: 539
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int DH_size(global::System.IntPtr dh);

		// Token: 0x0600021C RID: 540
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr BN_value_one();

		// Token: 0x0600021D RID: 541
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr BN_new();

		// Token: 0x0600021E RID: 542
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern void BN_free(global::System.IntPtr a);

		// Token: 0x0600021F RID: 543
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern void BN_init(global::System.IntPtr a);

		// Token: 0x06000220 RID: 544
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr BN_bin2bn(byte[] s, int len, global::System.IntPtr ret);

		// Token: 0x06000221 RID: 545
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int BN_bn2bin(global::System.IntPtr a, byte[] to);

		// Token: 0x06000222 RID: 546
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern void BN_clear_free(global::System.IntPtr a);

		// Token: 0x06000223 RID: 547
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern void BN_clear(global::System.IntPtr a);

		// Token: 0x06000224 RID: 548
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr BN_dup(global::System.IntPtr a);

		// Token: 0x06000225 RID: 549
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr BN_copy(global::System.IntPtr a, global::System.IntPtr b);

		// Token: 0x06000226 RID: 550
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern void BN_swap(global::System.IntPtr a, global::System.IntPtr b);

		// Token: 0x06000227 RID: 551
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int BN_cmp(global::System.IntPtr a, global::System.IntPtr b);

		// Token: 0x06000228 RID: 552
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int BN_sub(global::System.IntPtr r, global::System.IntPtr a, global::System.IntPtr b);

		// Token: 0x06000229 RID: 553
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int BN_add(global::System.IntPtr r, global::System.IntPtr a, global::System.IntPtr b);

		// Token: 0x0600022A RID: 554
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int BN_mul(global::System.IntPtr r, global::System.IntPtr a, global::System.IntPtr b, global::System.IntPtr ctx);

		// Token: 0x0600022B RID: 555
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int BN_num_bits(global::System.IntPtr a);

		// Token: 0x0600022C RID: 556
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int BN_sqr(global::System.IntPtr r, global::System.IntPtr a, global::System.IntPtr ctx);

		// Token: 0x0600022D RID: 557
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int BN_div(global::System.IntPtr dv, global::System.IntPtr rem, global::System.IntPtr m, global::System.IntPtr d, global::System.IntPtr ctx);

		// Token: 0x0600022E RID: 558
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int BN_print(global::System.IntPtr fp, global::System.IntPtr a);

		// Token: 0x0600022F RID: 559
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr BN_bn2hex(global::System.IntPtr a);

		// Token: 0x06000230 RID: 560
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr BN_bn2dec(global::System.IntPtr a);

		// Token: 0x06000231 RID: 561
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int BN_hex2bn(out global::System.IntPtr a, byte[] str);

		// Token: 0x06000232 RID: 562
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int BN_dec2bn(out global::System.IntPtr a, byte[] str);

		// Token: 0x06000233 RID: 563
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern uint BN_mod_word(global::System.IntPtr a, uint w);

		// Token: 0x06000234 RID: 564
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern uint BN_div_word(global::System.IntPtr a, uint w);

		// Token: 0x06000235 RID: 565
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int BN_mul_word(global::System.IntPtr a, uint w);

		// Token: 0x06000236 RID: 566
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int BN_add_word(global::System.IntPtr a, uint w);

		// Token: 0x06000237 RID: 567
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int BN_sub_word(global::System.IntPtr a, uint w);

		// Token: 0x06000238 RID: 568
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int BN_set_word(global::System.IntPtr a, uint w);

		// Token: 0x06000239 RID: 569
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern uint BN_get_word(global::System.IntPtr a);

		// Token: 0x0600023A RID: 570
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr d2i_DHparams(out global::System.IntPtr a, global::System.IntPtr pp, int length);

		// Token: 0x0600023B RID: 571
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int i2d_DHparams(global::System.IntPtr a, global::System.IntPtr pp);

		// Token: 0x0600023C RID: 572
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr ASN1_d2i_bio(global::System.IntPtr xnew, global::System.IntPtr d2i, global::System.IntPtr bp, global::System.IntPtr x);

		// Token: 0x0600023D RID: 573
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int ASN1_i2d_bio(global::System.IntPtr i2d, global::System.IntPtr bp, global::System.IntPtr x);

		// Token: 0x0600023E RID: 574
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int PEM_write_bio_X509(global::System.IntPtr bp, global::System.IntPtr x);

		// Token: 0x0600023F RID: 575
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr PEM_read_bio_X509(global::System.IntPtr bp, global::System.IntPtr x, global::OpenSSL.Core.Native.pem_password_cb cb, global::System.IntPtr u);

		// Token: 0x06000240 RID: 576
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr PEM_read_bio_PKCS7(global::System.IntPtr bp, global::System.IntPtr x, global::OpenSSL.Core.Native.pem_password_cb cb, global::System.IntPtr u);

		// Token: 0x06000241 RID: 577
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr d2i_PKCS7_bio(global::System.IntPtr bp, global::System.IntPtr p7);

		// Token: 0x06000242 RID: 578
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern void PKCS7_free(global::System.IntPtr p7);

		// Token: 0x06000243 RID: 579
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr d2i_PKCS12_bio(global::System.IntPtr bp, global::System.IntPtr p12);

		// Token: 0x06000244 RID: 580
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int i2d_PKCS12_bio(global::System.IntPtr bp, global::System.IntPtr p12);

		// Token: 0x06000245 RID: 581
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr PKCS12_create(string pass, string name, global::System.IntPtr pkey, global::System.IntPtr cert, global::System.IntPtr ca, int nid_key, int nid_cert, int iter, int mac_iter, int keytype);

		// Token: 0x06000246 RID: 582
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int PKCS12_parse(global::System.IntPtr p12, string pass, out global::System.IntPtr pkey, out global::System.IntPtr cert, out global::System.IntPtr ca);

		// Token: 0x06000247 RID: 583
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern void PKCS12_free(global::System.IntPtr p12);

		// Token: 0x06000248 RID: 584
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int PEM_write_bio_PKCS8PrivateKey(global::System.IntPtr bp, global::System.IntPtr evp_pkey, global::System.IntPtr evp_cipher, global::System.IntPtr kstr, int klen, global::OpenSSL.Core.Native.pem_password_cb cb, global::System.IntPtr user_data);

		// Token: 0x06000249 RID: 585
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int PEM_write_bio_X509_INFO(global::System.IntPtr bp, global::System.IntPtr x);

		// Token: 0x0600024A RID: 586
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr PEM_read_bio_X509_INFO(global::System.IntPtr bp, global::System.IntPtr x, global::OpenSSL.Core.Native.pem_password_cb cb, global::System.IntPtr u);

		// Token: 0x0600024B RID: 587
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int PEM_write_bio_X509_AUX(global::System.IntPtr bp, global::System.IntPtr x);

		// Token: 0x0600024C RID: 588
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr PEM_read_bio_X509_AUX(global::System.IntPtr bp, global::System.IntPtr x, global::OpenSSL.Core.Native.pem_password_cb cb, global::System.IntPtr u);

		// Token: 0x0600024D RID: 589
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int PEM_write_bio_X509_REQ(global::System.IntPtr bp, global::System.IntPtr x);

		// Token: 0x0600024E RID: 590
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr PEM_read_bio_X509_REQ(global::System.IntPtr bp, global::System.IntPtr x, global::OpenSSL.Core.Native.pem_password_cb cb, global::System.IntPtr u);

		// Token: 0x0600024F RID: 591
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int PEM_write_bio_X509_REQ_NEW(global::System.IntPtr bp, global::System.IntPtr x);

		// Token: 0x06000250 RID: 592
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr PEM_read_bio_X509_REQ_NEW(global::System.IntPtr bp, global::System.IntPtr x, global::OpenSSL.Core.Native.pem_password_cb cb, global::System.IntPtr u);

		// Token: 0x06000251 RID: 593
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int PEM_write_bio_X509_CRL(global::System.IntPtr bp, global::System.IntPtr x);

		// Token: 0x06000252 RID: 594
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr PEM_read_bio_X509_CRL(global::System.IntPtr bp, global::System.IntPtr x, global::OpenSSL.Core.Native.pem_password_cb cb, global::System.IntPtr u);

		// Token: 0x06000253 RID: 595
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr PEM_X509_INFO_read_bio(global::System.IntPtr bp, global::System.IntPtr sk, global::OpenSSL.Core.Native.pem_password_cb cb, global::System.IntPtr u);

		// Token: 0x06000254 RID: 596
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int PEM_X509_INFO_write_bio(global::System.IntPtr bp, global::System.IntPtr xi, global::System.IntPtr enc, byte[] kstr, int klen, global::System.IntPtr cd, global::System.IntPtr u);

		// Token: 0x06000255 RID: 597
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int PEM_write_bio_DSAPrivateKey(global::System.IntPtr bp, global::System.IntPtr x, global::System.IntPtr enc, byte[] kstr, int klen, global::OpenSSL.Core.Native.pem_password_cb cb, global::System.IntPtr u);

		// Token: 0x06000256 RID: 598
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr PEM_read_bio_DSAPrivateKey(global::System.IntPtr bp, global::System.IntPtr x, global::OpenSSL.Core.Native.pem_password_cb cb, global::System.IntPtr u);

		// Token: 0x06000257 RID: 599
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int PEM_write_bio_DSA_PUBKEY(global::System.IntPtr bp, global::System.IntPtr x);

		// Token: 0x06000258 RID: 600
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr PEM_read_bio_DSA_PUBKEY(global::System.IntPtr bp, global::System.IntPtr x, global::OpenSSL.Core.Native.pem_password_cb cb, global::System.IntPtr u);

		// Token: 0x06000259 RID: 601
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int PEM_write_bio_DSAparams(global::System.IntPtr bp, global::System.IntPtr x);

		// Token: 0x0600025A RID: 602
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr PEM_read_bio_DSAparams(global::System.IntPtr bp, global::System.IntPtr x, global::OpenSSL.Core.Native.pem_password_cb cb, global::System.IntPtr u);

		// Token: 0x0600025B RID: 603
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int PEM_write_bio_RSA_PUBKEY(global::System.IntPtr bp, global::System.IntPtr x);

		// Token: 0x0600025C RID: 604
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr PEM_read_bio_RSA_PUBKEY(global::System.IntPtr bp, global::System.IntPtr x, global::OpenSSL.Core.Native.pem_password_cb cb, global::System.IntPtr u);

		// Token: 0x0600025D RID: 605
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int PEM_write_bio_RSAPrivateKey(global::System.IntPtr bp, global::System.IntPtr x, global::System.IntPtr enc, byte[] kstr, int klen, global::OpenSSL.Core.Native.pem_password_cb cb, global::System.IntPtr u);

		// Token: 0x0600025E RID: 606
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr PEM_read_bio_RSAPrivateKey(global::System.IntPtr bp, global::System.IntPtr x, global::OpenSSL.Core.Native.pem_password_cb cb, global::System.IntPtr u);

		// Token: 0x0600025F RID: 607
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int PEM_write_bio_DHparams(global::System.IntPtr bp, global::System.IntPtr x);

		// Token: 0x06000260 RID: 608
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr PEM_read_bio_DHparams(global::System.IntPtr bp, global::System.IntPtr x, global::OpenSSL.Core.Native.pem_password_cb cb, global::System.IntPtr u);

		// Token: 0x06000261 RID: 609
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr PEM_read_bio_DHparams(global::System.IntPtr bp, global::System.IntPtr x, global::System.IntPtr cb, global::System.IntPtr u);

		// Token: 0x06000262 RID: 610
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int PEM_write_bio_PrivateKey(global::System.IntPtr bp, global::System.IntPtr x, global::System.IntPtr enc, byte[] kstr, int klen, global::OpenSSL.Core.Native.pem_password_cb cb, global::System.IntPtr u);

		// Token: 0x06000263 RID: 611
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr PEM_read_bio_PrivateKey(global::System.IntPtr bp, global::System.IntPtr x, global::OpenSSL.Core.Native.pem_password_cb cb, global::System.IntPtr u);

		// Token: 0x06000264 RID: 612
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int PEM_write_bio_PUBKEY(global::System.IntPtr bp, global::System.IntPtr x);

		// Token: 0x06000265 RID: 613
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr PEM_read_bio_PUBKEY(global::System.IntPtr bp, global::System.IntPtr x, global::OpenSSL.Core.Native.pem_password_cb cb, global::System.IntPtr u);

		// Token: 0x06000266 RID: 614
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr EVP_md_null();

		// Token: 0x06000267 RID: 615
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr EVP_md2();

		// Token: 0x06000268 RID: 616
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr EVP_md4();

		// Token: 0x06000269 RID: 617
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr EVP_md5();

		// Token: 0x0600026A RID: 618
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr EVP_sha();

		// Token: 0x0600026B RID: 619
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr EVP_sha1();

		// Token: 0x0600026C RID: 620
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr EVP_sha224();

		// Token: 0x0600026D RID: 621
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr EVP_sha256();

		// Token: 0x0600026E RID: 622
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr EVP_sha384();

		// Token: 0x0600026F RID: 623
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr EVP_sha512();

		// Token: 0x06000270 RID: 624
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr EVP_dss();

		// Token: 0x06000271 RID: 625
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr EVP_dss1();

		// Token: 0x06000272 RID: 626
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr EVP_mdc2();

		// Token: 0x06000273 RID: 627
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr EVP_ripemd160();

		// Token: 0x06000274 RID: 628
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern void HMAC_CTX_init(global::System.IntPtr ctx);

		// Token: 0x06000275 RID: 629
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern void HMAC_CTX_set_flags(global::System.IntPtr ctx, uint flags);

		// Token: 0x06000276 RID: 630
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern void HMAC_CTX_cleanup(global::System.IntPtr ctx);

		// Token: 0x06000277 RID: 631
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern void HMAC_Init(global::System.IntPtr ctx, byte[] key, int len, global::System.IntPtr md);

		// Token: 0x06000278 RID: 632
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern void HMAC_Init_ex(global::System.IntPtr ctx, byte[] key, int len, global::System.IntPtr md, global::System.IntPtr engine_impl);

		// Token: 0x06000279 RID: 633
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern void HMAC_Update(global::System.IntPtr ctx, byte[] data, int len);

		// Token: 0x0600027A RID: 634
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern void HMAC_Final(global::System.IntPtr ctx, byte[] md, ref uint len);

		// Token: 0x0600027B RID: 635
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr HMAC(global::System.IntPtr evp_md, byte[] key, int key_len, byte[] d, int n, byte[] md, ref uint md_len);

		// Token: 0x0600027C RID: 636
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr EVP_get_cipherbyname(byte[] name);

		// Token: 0x0600027D RID: 637
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr EVP_enc_null();

		// Token: 0x0600027E RID: 638
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr EVP_des_ecb();

		// Token: 0x0600027F RID: 639
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr EVP_des_ede();

		// Token: 0x06000280 RID: 640
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr EVP_des_ede3();

		// Token: 0x06000281 RID: 641
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr EVP_des_ede_ecb();

		// Token: 0x06000282 RID: 642
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr EVP_des_ede3_ecb();

		// Token: 0x06000283 RID: 643
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr EVP_des_cfb64();

		// Token: 0x06000284 RID: 644
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr EVP_des_cfb1();

		// Token: 0x06000285 RID: 645
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr EVP_des_cfb8();

		// Token: 0x06000286 RID: 646
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr EVP_des_ede_cfb64();

		// Token: 0x06000287 RID: 647
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr EVP_des_ede3_cfb64();

		// Token: 0x06000288 RID: 648
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr EVP_des_ede3_cfb1();

		// Token: 0x06000289 RID: 649
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr EVP_des_ede3_cfb8();

		// Token: 0x0600028A RID: 650
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr EVP_des_ofb();

		// Token: 0x0600028B RID: 651
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr EVP_des_ede_ofb();

		// Token: 0x0600028C RID: 652
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr EVP_des_ede3_ofb();

		// Token: 0x0600028D RID: 653
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr EVP_des_cbc();

		// Token: 0x0600028E RID: 654
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr EVP_des_ede_cbc();

		// Token: 0x0600028F RID: 655
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr EVP_des_ede3_cbc();

		// Token: 0x06000290 RID: 656
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr EVP_desx_cbc();

		// Token: 0x06000291 RID: 657
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr EVP_rc4();

		// Token: 0x06000292 RID: 658
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr EVP_rc4_40();

		// Token: 0x06000293 RID: 659
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr EVP_idea_ecb();

		// Token: 0x06000294 RID: 660
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr EVP_idea_cfb64();

		// Token: 0x06000295 RID: 661
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr EVP_idea_ofb();

		// Token: 0x06000296 RID: 662
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr EVP_idea_cbc();

		// Token: 0x06000297 RID: 663
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr EVP_rc2_ecb();

		// Token: 0x06000298 RID: 664
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr EVP_rc2_cbc();

		// Token: 0x06000299 RID: 665
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr EVP_rc2_40_cbc();

		// Token: 0x0600029A RID: 666
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr EVP_rc2_64_cbc();

		// Token: 0x0600029B RID: 667
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr EVP_rc2_cfb64();

		// Token: 0x0600029C RID: 668
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr EVP_rc2_ofb();

		// Token: 0x0600029D RID: 669
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr EVP_bf_ecb();

		// Token: 0x0600029E RID: 670
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr EVP_bf_cbc();

		// Token: 0x0600029F RID: 671
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr EVP_bf_cfb64();

		// Token: 0x060002A0 RID: 672
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr EVP_bf_ofb();

		// Token: 0x060002A1 RID: 673
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr EVP_cast5_ecb();

		// Token: 0x060002A2 RID: 674
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr EVP_cast5_cbc();

		// Token: 0x060002A3 RID: 675
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr EVP_cast5_cfb64();

		// Token: 0x060002A4 RID: 676
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr EVP_cast5_ofb();

		// Token: 0x060002A5 RID: 677
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr EVP_rc5_32_12_16_cbc();

		// Token: 0x060002A6 RID: 678
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr EVP_rc5_32_12_16_ecb();

		// Token: 0x060002A7 RID: 679
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr EVP_rc5_32_12_16_cfb64();

		// Token: 0x060002A8 RID: 680
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr EVP_rc5_32_12_16_ofb();

		// Token: 0x060002A9 RID: 681
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr EVP_aes_128_ecb();

		// Token: 0x060002AA RID: 682
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr EVP_aes_128_cbc();

		// Token: 0x060002AB RID: 683
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr EVP_aes_128_cfb1();

		// Token: 0x060002AC RID: 684
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr EVP_aes_128_cfb8();

		// Token: 0x060002AD RID: 685
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr EVP_aes_128_cfb128();

		// Token: 0x060002AE RID: 686
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr EVP_aes_128_ofb();

		// Token: 0x060002AF RID: 687
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr EVP_aes_192_ecb();

		// Token: 0x060002B0 RID: 688
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr EVP_aes_192_cbc();

		// Token: 0x060002B1 RID: 689
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr EVP_aes_192_cfb1();

		// Token: 0x060002B2 RID: 690
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr EVP_aes_192_cfb8();

		// Token: 0x060002B3 RID: 691
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr EVP_aes_192_cfb128();

		// Token: 0x060002B4 RID: 692
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr EVP_aes_192_ofb();

		// Token: 0x060002B5 RID: 693
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr EVP_aes_256_ecb();

		// Token: 0x060002B6 RID: 694
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr EVP_aes_256_cbc();

		// Token: 0x060002B7 RID: 695
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr EVP_aes_256_cfb1();

		// Token: 0x060002B8 RID: 696
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr EVP_aes_256_cfb8();

		// Token: 0x060002B9 RID: 697
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr EVP_aes_256_cfb128();

		// Token: 0x060002BA RID: 698
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr EVP_aes_256_ofb();

		// Token: 0x060002BB RID: 699
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr EVP_PKEY_new();

		// Token: 0x060002BC RID: 700
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern void EVP_PKEY_free(global::System.IntPtr pkey);

		// Token: 0x060002BD RID: 701
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int EVP_PKEY_cmp(global::System.IntPtr a, global::System.IntPtr b);

		// Token: 0x060002BE RID: 702
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int EVP_PKEY_decrypt(byte[] dec_key, byte[] enc_key, int enc_key_len, global::System.IntPtr private_key);

		// Token: 0x060002BF RID: 703
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int EVP_PKEY_encrypt(byte[] enc_key, byte[] key, int key_len, global::System.IntPtr pub_key);

		// Token: 0x060002C0 RID: 704
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int EVP_PKEY_type(int type);

		// Token: 0x060002C1 RID: 705
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int EVP_PKEY_bits(global::System.IntPtr pkey);

		// Token: 0x060002C2 RID: 706
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int EVP_PKEY_size(global::System.IntPtr pkey);

		// Token: 0x060002C3 RID: 707
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int EVP_PKEY_assign(global::System.IntPtr pkey, int type, byte[] key);

		// Token: 0x060002C4 RID: 708
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int EVP_PKEY_set1_DSA(global::System.IntPtr pkey, global::System.IntPtr key);

		// Token: 0x060002C5 RID: 709
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr EVP_PKEY_get1_DSA(global::System.IntPtr pkey);

		// Token: 0x060002C6 RID: 710
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int EVP_PKEY_set1_RSA(global::System.IntPtr pkey, global::System.IntPtr key);

		// Token: 0x060002C7 RID: 711
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr EVP_PKEY_get1_RSA(global::System.IntPtr pkey);

		// Token: 0x060002C8 RID: 712
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int EVP_PKEY_set1_DH(global::System.IntPtr pkey, global::System.IntPtr key);

		// Token: 0x060002C9 RID: 713
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr EVP_PKEY_get1_DH(global::System.IntPtr pkey);

		// Token: 0x060002CA RID: 714
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int EVP_PKEY_copy_parameters(global::System.IntPtr to, global::System.IntPtr from);

		// Token: 0x060002CB RID: 715
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int EVP_PKEY_missing_parameters(global::System.IntPtr pkey);

		// Token: 0x060002CC RID: 716
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int EVP_PKEY_save_parameters(global::System.IntPtr pkey, int mode);

		// Token: 0x060002CD RID: 717
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int EVP_PKEY_cmp_parameters(global::System.IntPtr a, global::System.IntPtr b);

		// Token: 0x060002CE RID: 718
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern void EVP_CIPHER_CTX_init(global::System.IntPtr a);

		// Token: 0x060002CF RID: 719
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int EVP_CIPHER_CTX_set_padding(global::System.IntPtr x, int padding);

		// Token: 0x060002D0 RID: 720
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int EVP_CIPHER_CTX_set_key_length(global::System.IntPtr x, int keylen);

		// Token: 0x060002D1 RID: 721
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int EVP_CIPHER_CTX_ctrl(global::System.IntPtr ctx, int type, int arg, global::System.IntPtr ptr);

		// Token: 0x060002D2 RID: 722
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int EVP_CIPHER_CTX_cleanup(global::System.IntPtr a);

		// Token: 0x060002D3 RID: 723
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int EVP_CIPHER_type(global::System.IntPtr ctx);

		// Token: 0x060002D4 RID: 724
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int EVP_CipherInit_ex(global::System.IntPtr ctx, global::System.IntPtr type, global::System.IntPtr impl, byte[] key, byte[] iv, int enc);

		// Token: 0x060002D5 RID: 725
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int EVP_CipherUpdate(global::System.IntPtr ctx, byte[] outb, out int outl, byte[] inb, int inl);

		// Token: 0x060002D6 RID: 726
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int EVP_CipherFinal_ex(global::System.IntPtr ctx, byte[] outm, ref int outl);

		// Token: 0x060002D7 RID: 727
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int EVP_OpenInit(global::System.IntPtr ctx, global::System.IntPtr type, byte[] ek, int ekl, byte[] iv, global::System.IntPtr priv);

		// Token: 0x060002D8 RID: 728
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int EVP_OpenFinal(global::System.IntPtr ctx, byte[] outb, out int outl);

		// Token: 0x060002D9 RID: 729
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int EVP_SealInit(global::System.IntPtr ctx, global::System.IntPtr type, byte[][] ek, int[] ekl, byte[] iv, global::System.IntPtr[] pubk, int npubk);

		// Token: 0x060002DA RID: 730
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int EVP_SealFinal(global::System.IntPtr ctx, byte[] outb, out int outl);

		// Token: 0x060002DB RID: 731
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int EVP_DecryptUpdate(global::System.IntPtr ctx, byte[] output, out int outl, byte[] input, int inl);

		// Token: 0x060002DC RID: 732
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int EVP_EncryptUpdate(global::System.IntPtr ctx, byte[] output, out int outl, byte[] input, int inl);

		// Token: 0x060002DD RID: 733
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int EVP_BytesToKey(global::System.IntPtr type, global::System.IntPtr md, byte[] salt, byte[] data, int datal, int count, byte[] key, byte[] iv);

		// Token: 0x060002DE RID: 734
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr EVP_get_digestbyname(byte[] name);

		// Token: 0x060002DF RID: 735
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern void EVP_MD_CTX_init(global::System.IntPtr ctx);

		// Token: 0x060002E0 RID: 736
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int EVP_MD_CTX_cleanup(global::System.IntPtr ctx);

		// Token: 0x060002E1 RID: 737
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr EVP_MD_CTX_create();

		// Token: 0x060002E2 RID: 738
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern void EVP_MD_CTX_destroy(global::System.IntPtr ctx);

		// Token: 0x060002E3 RID: 739
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int EVP_DigestInit_ex(global::System.IntPtr ctx, global::System.IntPtr type, global::System.IntPtr impl);

		// Token: 0x060002E4 RID: 740
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int EVP_DigestUpdate(global::System.IntPtr ctx, byte[] d, uint cnt);

		// Token: 0x060002E5 RID: 741
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int EVP_DigestFinal_ex(global::System.IntPtr ctx, byte[] md, ref uint s);

		// Token: 0x060002E6 RID: 742
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int EVP_Digest(byte[] data, uint count, byte[] md, ref uint size, global::System.IntPtr type, global::System.IntPtr impl);

		// Token: 0x060002E7 RID: 743
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int EVP_SignFinal(global::System.IntPtr ctx, byte[] md, ref uint s, global::System.IntPtr pkey);

		// Token: 0x060002E8 RID: 744
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int EVP_VerifyFinal(global::System.IntPtr ctx, byte[] sigbuf, uint siglen, global::System.IntPtr pkey);

		// Token: 0x060002E9 RID: 745
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr BIO_new_file(string filename, string mode);

		// Token: 0x060002EA RID: 746
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr BIO_new_mem_buf(byte[] buf, int len);

		// Token: 0x060002EB RID: 747
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr BIO_s_mem();

		// Token: 0x060002EC RID: 748
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr BIO_f_md();

		// Token: 0x060002ED RID: 749
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr BIO_f_null();

		// Token: 0x060002EE RID: 750 RVA: 0x00005771 File Offset: 0x00003971
		public static void BIO_set_md(global::System.IntPtr bp, global::System.IntPtr md)
		{
			global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.BIO_ctrl(bp, 111, 0, md));
		}

		// Token: 0x060002EF RID: 751 RVA: 0x00005784 File Offset: 0x00003984
		public static global::System.IntPtr BIO_get_md(global::System.IntPtr bp)
		{
			global::System.IntPtr intPtr = global::System.Runtime.InteropServices.Marshal.AllocHGlobal(4);
			global::System.IntPtr result;
			try
			{
				global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.BIO_ctrl(bp, 112, 0, intPtr));
				result = global::System.Runtime.InteropServices.Marshal.ReadIntPtr(intPtr);
			}
			finally
			{
				global::System.Runtime.InteropServices.Marshal.FreeHGlobal(intPtr);
			}
			return result;
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x000057CC File Offset: 0x000039CC
		public static global::System.IntPtr BIO_get_md_ctx(global::System.IntPtr bp)
		{
			global::System.IntPtr intPtr = global::System.Runtime.InteropServices.Marshal.AllocHGlobal(4);
			global::System.IntPtr result;
			try
			{
				global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.BIO_ctrl(bp, 120, 0, intPtr));
				result = global::System.Runtime.InteropServices.Marshal.ReadIntPtr(intPtr);
			}
			finally
			{
				global::System.Runtime.InteropServices.Marshal.FreeHGlobal(intPtr);
			}
			return result;
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x00005814 File Offset: 0x00003A14
		public static void BIO_set_md_ctx(global::System.IntPtr bp, global::System.IntPtr mdcp)
		{
			global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.BIO_ctrl(bp, 148, 0, mdcp));
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x00005829 File Offset: 0x00003A29
		public static int BIO_set_close(global::System.IntPtr bp, int arg)
		{
			return global::OpenSSL.Core.Native.BIO_ctrl(bp, 9, arg, global::System.IntPtr.Zero);
		}

		// Token: 0x060002F3 RID: 755
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr BIO_push(global::System.IntPtr bp, global::System.IntPtr append);

		// Token: 0x060002F4 RID: 756
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int BIO_ctrl(global::System.IntPtr bp, int cmd, int larg, global::System.IntPtr parg);

		// Token: 0x060002F5 RID: 757
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int BIO_int_ctrl(global::System.IntPtr bp, int cmd, int larg, int parg);

		// Token: 0x060002F6 RID: 758
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr BIO_new(global::System.IntPtr type);

		// Token: 0x060002F7 RID: 759
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int BIO_read(global::System.IntPtr b, byte[] buf, int len);

		// Token: 0x060002F8 RID: 760
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int BIO_write(global::System.IntPtr b, byte[] buf, int len);

		// Token: 0x060002F9 RID: 761
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int BIO_puts(global::System.IntPtr b, byte[] buf);

		// Token: 0x060002FA RID: 762
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int BIO_gets(global::System.IntPtr b, byte[] buf, int len);

		// Token: 0x060002FB RID: 763
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern void BIO_free(global::System.IntPtr bio);

		// Token: 0x060002FC RID: 764
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern uint BIO_number_read(global::System.IntPtr bio);

		// Token: 0x060002FD RID: 765
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern uint BIO_number_written(global::System.IntPtr bio);

		// Token: 0x060002FE RID: 766
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern uint BIO_ctrl_pending(global::System.IntPtr bio);

		// Token: 0x060002FF RID: 767
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern void ERR_load_crypto_strings();

		// Token: 0x06000300 RID: 768
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern uint ERR_get_error();

		// Token: 0x06000301 RID: 769
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern uint ERR_error_string_n(uint e, byte[] buf, int len);

		// Token: 0x06000302 RID: 770
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr ERR_lib_error_string(uint e);

		// Token: 0x06000303 RID: 771
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr ERR_func_error_string(uint e);

		// Token: 0x06000304 RID: 772
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr ERR_reason_error_string(uint e);

		// Token: 0x06000305 RID: 773
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern void ERR_remove_state(uint pid);

		// Token: 0x06000306 RID: 774
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern void ERR_clear_error();

		// Token: 0x06000307 RID: 775
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr NCONF_new(global::System.IntPtr meth);

		// Token: 0x06000308 RID: 776
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern void NCONF_free(global::System.IntPtr conf);

		// Token: 0x06000309 RID: 777
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int NCONF_load(global::System.IntPtr conf, string file, ref int eline);

		// Token: 0x0600030A RID: 778
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr NCONF_get_string(global::System.IntPtr conf, byte[] group, byte[] name);

		// Token: 0x0600030B RID: 779
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern void X509V3_set_ctx(global::System.IntPtr ctx, global::System.IntPtr issuer, global::System.IntPtr subject, global::System.IntPtr req, global::System.IntPtr crl, int flags);

		// Token: 0x0600030C RID: 780
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern void X509V3_set_nconf(global::System.IntPtr ctx, global::System.IntPtr conf);

		// Token: 0x0600030D RID: 781
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int X509V3_EXT_add_nconf(global::System.IntPtr conf, global::System.IntPtr ctx, byte[] section, global::System.IntPtr cert);

		// Token: 0x0600030E RID: 782
		[global::System.Runtime.InteropServices.DllImport("libeay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int FIPS_mode_set(int onoff);

		// Token: 0x0600030F RID: 783
		[global::System.Runtime.InteropServices.DllImport("ssleay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern void SSL_load_error_strings();

		// Token: 0x06000310 RID: 784
		[global::System.Runtime.InteropServices.DllImport("ssleay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int SSL_library_init();

		// Token: 0x06000311 RID: 785
		[global::System.Runtime.InteropServices.DllImport("ssleay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern void ERR_free_strings();

		// Token: 0x06000312 RID: 786
		[global::System.Runtime.InteropServices.DllImport("ssleay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr SSLv2_method();

		// Token: 0x06000313 RID: 787
		[global::System.Runtime.InteropServices.DllImport("ssleay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr SSLv2_server_method();

		// Token: 0x06000314 RID: 788
		[global::System.Runtime.InteropServices.DllImport("ssleay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr SSLv2_client_method();

		// Token: 0x06000315 RID: 789
		[global::System.Runtime.InteropServices.DllImport("ssleay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr SSLv3_method();

		// Token: 0x06000316 RID: 790
		[global::System.Runtime.InteropServices.DllImport("ssleay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr SSLv3_server_method();

		// Token: 0x06000317 RID: 791
		[global::System.Runtime.InteropServices.DllImport("ssleay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr SSLv3_client_method();

		// Token: 0x06000318 RID: 792
		[global::System.Runtime.InteropServices.DllImport("ssleay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr SSLv23_method();

		// Token: 0x06000319 RID: 793
		[global::System.Runtime.InteropServices.DllImport("ssleay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr SSLv23_server_method();

		// Token: 0x0600031A RID: 794
		[global::System.Runtime.InteropServices.DllImport("ssleay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr SSLv23_client_method();

		// Token: 0x0600031B RID: 795
		[global::System.Runtime.InteropServices.DllImport("ssleay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr TLSv1_method();

		// Token: 0x0600031C RID: 796
		[global::System.Runtime.InteropServices.DllImport("ssleay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr TLSv1_client_method();

		// Token: 0x0600031D RID: 797
		[global::System.Runtime.InteropServices.DllImport("ssleay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr TLSv1_server_method();

		// Token: 0x0600031E RID: 798
		[global::System.Runtime.InteropServices.DllImport("ssleay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr DTLSv1_method();

		// Token: 0x0600031F RID: 799
		[global::System.Runtime.InteropServices.DllImport("ssleay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr DTLSv1_client_method();

		// Token: 0x06000320 RID: 800
		[global::System.Runtime.InteropServices.DllImport("ssleay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr DTLSv1_server_method();

		// Token: 0x06000321 RID: 801
		[global::System.Runtime.InteropServices.DllImport("ssleay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr SSL_CTX_new(global::System.IntPtr sslMethod);

		// Token: 0x06000322 RID: 802
		[global::System.Runtime.InteropServices.DllImport("ssleay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern void SSL_CTX_free(global::System.IntPtr ctx);

		// Token: 0x06000323 RID: 803
		[global::System.Runtime.InteropServices.DllImport("ssleay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int SSL_CTX_ctrl(global::System.IntPtr ctx, int cmd, int arg, global::System.IntPtr parg);

		// Token: 0x06000324 RID: 804 RVA: 0x00005839 File Offset: 0x00003A39
		public static int SSL_CTX_set_mode(global::System.IntPtr ctx, int op)
		{
			return global::OpenSSL.Core.Native.SSL_CTX_ctrl(ctx, 33, op, global::System.IntPtr.Zero);
		}

		// Token: 0x06000325 RID: 805 RVA: 0x00005849 File Offset: 0x00003A49
		public static int SSL_CTX_set_options(global::System.IntPtr ctx, int op)
		{
			return global::OpenSSL.Core.Native.SSL_CTX_ctrl(ctx, 32, op, global::System.IntPtr.Zero);
		}

		// Token: 0x06000326 RID: 806 RVA: 0x00005859 File Offset: 0x00003A59
		public static int SSL_CTX_get_mode(global::System.IntPtr ctx)
		{
			return global::OpenSSL.Core.Native.SSL_CTX_ctrl(ctx, 32, 0, global::System.IntPtr.Zero);
		}

		// Token: 0x06000327 RID: 807 RVA: 0x00005869 File Offset: 0x00003A69
		public static int SSL_CTX_get_options(global::System.IntPtr ctx)
		{
			return global::OpenSSL.Core.Native.SSL_CTX_ctrl(ctx, 32, 0, global::System.IntPtr.Zero);
		}

		// Token: 0x06000328 RID: 808
		[global::System.Runtime.InteropServices.DllImport("ssleay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern void SSL_CTX_set_cert_store(global::System.IntPtr ctx, global::System.IntPtr cert_store);

		// Token: 0x06000329 RID: 809
		[global::System.Runtime.InteropServices.DllImport("ssleay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern void SSL_CTX_set_verify(global::System.IntPtr ctx, int mode, global::OpenSSL.Core.Native.VerifyCertCallback callback);

		// Token: 0x0600032A RID: 810
		[global::System.Runtime.InteropServices.DllImport("ssleay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern void SSL_CTX_set_verify_depth(global::System.IntPtr ctx, int depth);

		// Token: 0x0600032B RID: 811
		[global::System.Runtime.InteropServices.DllImport("ssleay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern void SSL_CTX_set_client_CA_list(global::System.IntPtr ctx, global::System.IntPtr name_list);

		// Token: 0x0600032C RID: 812
		[global::System.Runtime.InteropServices.DllImport("ssleay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr SSL_CTX_get_client_CA_list(global::System.IntPtr ctx);

		// Token: 0x0600032D RID: 813
		[global::System.Runtime.InteropServices.DllImport("ssleay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int SSL_CTX_load_verify_locations(global::System.IntPtr ctx, string file, string path);

		// Token: 0x0600032E RID: 814
		[global::System.Runtime.InteropServices.DllImport("ssleay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int SSL_CTX_set_default_verify_paths(global::System.IntPtr ctx);

		// Token: 0x0600032F RID: 815
		[global::System.Runtime.InteropServices.DllImport("ssleay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int SSL_CTX_set_cipher_list(global::System.IntPtr ctx, string cipher_string);

		// Token: 0x06000330 RID: 816
		[global::System.Runtime.InteropServices.DllImport("ssleay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int SSL_CTX_use_certificate_chain_file(global::System.IntPtr ctx, string file);

		// Token: 0x06000331 RID: 817
		[global::System.Runtime.InteropServices.DllImport("ssleay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int SSL_CTX_use_certificate(global::System.IntPtr ctx, global::System.IntPtr cert);

		// Token: 0x06000332 RID: 818
		[global::System.Runtime.InteropServices.DllImport("ssleay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int SSL_CTX_use_PrivateKey(global::System.IntPtr ctx, global::System.IntPtr pkey);

		// Token: 0x06000333 RID: 819
		[global::System.Runtime.InteropServices.DllImport("ssleay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int SSL_CTX_use_PrivateKey_file(global::System.IntPtr ctx, string file, int type);

		// Token: 0x06000334 RID: 820
		[global::System.Runtime.InteropServices.DllImport("ssleay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int SSL_CTX_check_private_key(global::System.IntPtr ctx);

		// Token: 0x06000335 RID: 821
		[global::System.Runtime.InteropServices.DllImport("ssleay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int SSL_CTX_set_session_id_context(global::System.IntPtr ctx, byte[] sid_ctx, uint sid_ctx_len);

		// Token: 0x06000336 RID: 822
		[global::System.Runtime.InteropServices.DllImport("ssleay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern void SSL_CTX_set_default_passwd_cb_userdata(global::System.IntPtr ssl, global::System.IntPtr data);

		// Token: 0x06000337 RID: 823
		[global::System.Runtime.InteropServices.DllImport("ssleay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern void SSL_CTX_set_default_passwd_cb(global::System.IntPtr ssl, global::OpenSSL.Core.Native.pem_password_cb callback);

		// Token: 0x06000338 RID: 824
		[global::System.Runtime.InteropServices.DllImport("ssleay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern void SSL_CTX_set_client_cert_cb(global::System.IntPtr ssl_ctx, global::OpenSSL.Core.Native.client_cert_cb callback);

		// Token: 0x06000339 RID: 825
		[global::System.Runtime.InteropServices.DllImport("ssleay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr SSL_CIPHER_description(global::System.IntPtr ssl_cipher, byte[] buf, int buf_len);

		// Token: 0x0600033A RID: 826
		[global::System.Runtime.InteropServices.DllImport("ssleay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern string SSL_CIPHER_name(global::System.IntPtr ssl_cipher);

		// Token: 0x0600033B RID: 827
		[global::System.Runtime.InteropServices.DllImport("ssleay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int SSL_CIPHER_get_bits(global::System.IntPtr ssl_cipher, out int alg_bits);

		// Token: 0x0600033C RID: 828
		[global::System.Runtime.InteropServices.DllImport("ssleay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr SSL_get_current_cipher(global::System.IntPtr ssl);

		// Token: 0x0600033D RID: 829
		[global::System.Runtime.InteropServices.DllImport("ssleay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int SSL_get_verify_result(global::System.IntPtr ssl);

		// Token: 0x0600033E RID: 830
		[global::System.Runtime.InteropServices.DllImport("ssleay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int SSL_set_verify_result(global::System.IntPtr ssl, int v);

		// Token: 0x0600033F RID: 831
		[global::System.Runtime.InteropServices.DllImport("ssleay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr SSL_get_peer_certificate(global::System.IntPtr ssl);

		// Token: 0x06000340 RID: 832
		[global::System.Runtime.InteropServices.DllImport("ssleay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int SSL_get_error(global::System.IntPtr ssl, int ret_code);

		// Token: 0x06000341 RID: 833
		[global::System.Runtime.InteropServices.DllImport("ssleay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int SSL_accept(global::System.IntPtr ssl);

		// Token: 0x06000342 RID: 834
		[global::System.Runtime.InteropServices.DllImport("ssleay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int SSL_shutdown(global::System.IntPtr ssl);

		// Token: 0x06000343 RID: 835
		[global::System.Runtime.InteropServices.DllImport("ssleay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int SSL_write(global::System.IntPtr ssl, byte[] buf, int len);

		// Token: 0x06000344 RID: 836
		[global::System.Runtime.InteropServices.DllImport("ssleay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int SSL_read(global::System.IntPtr ssl, byte[] buf, int len);

		// Token: 0x06000345 RID: 837
		[global::System.Runtime.InteropServices.DllImport("ssleay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int SSL_renegotiate(global::System.IntPtr ssl);

		// Token: 0x06000346 RID: 838
		[global::System.Runtime.InteropServices.DllImport("ssleay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int SSL_set_session_id_context(global::System.IntPtr ssl, byte[] sid_ctx, uint sid_ctx_len);

		// Token: 0x06000347 RID: 839
		[global::System.Runtime.InteropServices.DllImport("ssleay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int SSL_do_handshake(global::System.IntPtr ssl);

		// Token: 0x06000348 RID: 840
		[global::System.Runtime.InteropServices.DllImport("ssleay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern void SSL_set_connect_state(global::System.IntPtr ssl);

		// Token: 0x06000349 RID: 841
		[global::System.Runtime.InteropServices.DllImport("ssleay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern void SSL_set_accept_state(global::System.IntPtr ssl);

		// Token: 0x0600034A RID: 842
		[global::System.Runtime.InteropServices.DllImport("ssleay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int SSL_connect(global::System.IntPtr ssl);

		// Token: 0x0600034B RID: 843
		[global::System.Runtime.InteropServices.DllImport("ssleay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr SSL_new(global::System.IntPtr ctx);

		// Token: 0x0600034C RID: 844
		[global::System.Runtime.InteropServices.DllImport("ssleay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern void SSL_free(global::System.IntPtr ssl);

		// Token: 0x0600034D RID: 845
		[global::System.Runtime.InteropServices.DllImport("ssleay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern void SSL_set_bio(global::System.IntPtr ssl, global::System.IntPtr read_bio, global::System.IntPtr write_bio);

		// Token: 0x0600034E RID: 846
		[global::System.Runtime.InteropServices.DllImport("ssleay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int SSL_use_certificate_file(global::System.IntPtr ssl, string file, int type);

		// Token: 0x0600034F RID: 847
		[global::System.Runtime.InteropServices.DllImport("ssleay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int SSL_use_PrivateKey_file(global::System.IntPtr ssl, string file, int type);

		// Token: 0x06000350 RID: 848
		[global::System.Runtime.InteropServices.DllImport("ssleay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int SSL_clear(global::System.IntPtr ssl);

		// Token: 0x06000351 RID: 849
		[global::System.Runtime.InteropServices.DllImport("ssleay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr SSL_load_client_CA_file(string file);

		// Token: 0x06000352 RID: 850
		[global::System.Runtime.InteropServices.DllImport("ssleay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr SSL_get_client_CA_list(global::System.IntPtr ssl);

		// Token: 0x06000353 RID: 851
		[global::System.Runtime.InteropServices.DllImport("ssleay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern void SSL_set_client_CA_list(global::System.IntPtr ssl, global::System.IntPtr name_list);

		// Token: 0x06000354 RID: 852
		[global::System.Runtime.InteropServices.DllImport("ssleay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr SSL_get_certificate(global::System.IntPtr ssl);

		// Token: 0x06000355 RID: 853
		[global::System.Runtime.InteropServices.DllImport("ssleay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int SSL_use_certificate(global::System.IntPtr ssl, global::System.IntPtr x509);

		// Token: 0x06000356 RID: 854
		[global::System.Runtime.InteropServices.DllImport("ssleay32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern int SSL_use_PrivateKey(global::System.IntPtr ssl, global::System.IntPtr evp_pkey);

		// Token: 0x06000357 RID: 855 RVA: 0x0000587C File Offset: 0x00003A7C
		public static string PtrToStringAnsi(global::System.IntPtr ptr, bool hasOwnership)
		{
			int num = 0;
			int i = 0;
			while (i < 1024)
			{
				byte b = global::System.Runtime.InteropServices.Marshal.ReadByte(ptr, i);
				if (b == 0)
				{
					break;
				}
				i++;
				num++;
			}
			if (num == 1024)
			{
				return "Invalid string";
			}
			byte[] array = new byte[num];
			global::System.Runtime.InteropServices.Marshal.Copy(ptr, array, 0, num);
			if (hasOwnership)
			{
				global::OpenSSL.Core.Native.OPENSSL_free(ptr);
			}
			return global::System.Text.Encoding.ASCII.GetString(array, 0, num);
		}

		// Token: 0x06000358 RID: 856 RVA: 0x000058DE File Offset: 0x00003ADE
		public static global::System.IntPtr ExpectNonNull(global::System.IntPtr ptr)
		{
			if (ptr == global::System.IntPtr.Zero)
			{
				throw new global::OpenSSL.Core.OpenSslException();
			}
			return ptr;
		}

		// Token: 0x06000359 RID: 857 RVA: 0x000058F4 File Offset: 0x00003AF4
		public static int ExpectSuccess(int ret)
		{
			if (ret <= 0)
			{
				throw new global::OpenSSL.Core.OpenSslException();
			}
			return ret;
		}

		// Token: 0x0600035A RID: 858 RVA: 0x00005904 File Offset: 0x00003B04
		public static int TextToNID(string text)
		{
			int num = global::OpenSSL.Core.Native.OBJ_txt2nid(text);
			if (num == 0)
			{
				throw new global::OpenSSL.Core.OpenSslException();
			}
			return num;
		}

		// Token: 0x040001C0 RID: 448
		private const string DLLNAME = "libeay32";

		// Token: 0x040001C1 RID: 449
		private const string SSLDLLNAME = "ssleay32";

		// Token: 0x040001C2 RID: 450
		public const uint Wrapper = 268435456U;

		// Token: 0x040001C3 RID: 451
		public const int CRYPTO_LOCK = 1;

		// Token: 0x040001C4 RID: 452
		public const int NID_undef = 0;

		// Token: 0x040001C5 RID: 453
		public const int OBJ_undef = 0;

		// Token: 0x040001C6 RID: 454
		public const int OBJ_NAME_TYPE_UNDEF = 0;

		// Token: 0x040001C7 RID: 455
		public const int OBJ_NAME_TYPE_MD_METH = 1;

		// Token: 0x040001C8 RID: 456
		public const int OBJ_NAME_TYPE_CIPHER_METH = 2;

		// Token: 0x040001C9 RID: 457
		public const int OBJ_NAME_TYPE_PKEY_METH = 3;

		// Token: 0x040001CA RID: 458
		public const int OBJ_NAME_TYPE_COMP_METH = 4;

		// Token: 0x040001CB RID: 459
		public const int OBJ_NAME_TYPE_NUM = 5;

		// Token: 0x040001CC RID: 460
		public const int SHA_DIGEST_LENGTH = 20;

		// Token: 0x040001CD RID: 461
		public const int V_ASN1_OCTET_STRING = 4;

		// Token: 0x040001CE RID: 462
		public const int MBSTRING_FLAG = 4096;

		// Token: 0x040001CF RID: 463
		public const int MBSTRING_ASC = 4097;

		// Token: 0x040001D0 RID: 464
		public const int ASN1_STRFLGS_RFC2253 = 791;

		// Token: 0x040001D1 RID: 465
		public const int ASN1_STRFLGS_ESC_2253 = 1;

		// Token: 0x040001D2 RID: 466
		public const int ASN1_STRFLGS_ESC_CTRL = 2;

		// Token: 0x040001D3 RID: 467
		public const int ASN1_STRFLGS_ESC_MSB = 4;

		// Token: 0x040001D4 RID: 468
		public const int ASN1_STRFLGS_ESC_QUOTE = 8;

		// Token: 0x040001D5 RID: 469
		public const int ASN1_STRFLGS_UTF8_CONVERT = 16;

		// Token: 0x040001D6 RID: 470
		public const int ASN1_STRFLGS_DUMP_UNKNOWN = 256;

		// Token: 0x040001D7 RID: 471
		public const int ASN1_STRFLGS_DUMP_DER = 512;

		// Token: 0x040001D8 RID: 472
		public const int XN_FLAG_SEP_COMMA_PLUS = 65536;

		// Token: 0x040001D9 RID: 473
		public const int XN_FLAG_FN_SN = 0;

		// Token: 0x040001DA RID: 474
		public const int EVP_MAX_MD_SIZE = 64;

		// Token: 0x040001DB RID: 475
		public const int EVP_MAX_KEY_LENGTH = 32;

		// Token: 0x040001DC RID: 476
		public const int EVP_MAX_IV_LENGTH = 16;

		// Token: 0x040001DD RID: 477
		public const int EVP_MAX_BLOCK_LENGTH = 32;

		// Token: 0x040001DE RID: 478
		public const int EVP_CIPH_STREAM_CIPHER = 0;

		// Token: 0x040001DF RID: 479
		public const int EVP_CIPH_ECB_MODE = 1;

		// Token: 0x040001E0 RID: 480
		public const int EVP_CIPH_CBC_MODE = 2;

		// Token: 0x040001E1 RID: 481
		public const int EVP_CIPH_CFB_MODE = 3;

		// Token: 0x040001E2 RID: 482
		public const int EVP_CIPH_OFB_MODE = 4;

		// Token: 0x040001E3 RID: 483
		public const int EVP_CIPH_MODE = 983047;

		// Token: 0x040001E4 RID: 484
		public const int EVP_CIPH_VARIABLE_LENGTH = 8;

		// Token: 0x040001E5 RID: 485
		public const int EVP_CIPH_CUSTOM_IV = 16;

		// Token: 0x040001E6 RID: 486
		public const int EVP_CIPH_ALWAYS_CALL_INIT = 32;

		// Token: 0x040001E7 RID: 487
		public const int EVP_CIPH_CTRL_INIT = 64;

		// Token: 0x040001E8 RID: 488
		public const int EVP_CIPH_CUSTOM_KEY_LENGTH = 128;

		// Token: 0x040001E9 RID: 489
		public const int EVP_CIPH_NO_PADDING = 256;

		// Token: 0x040001EA RID: 490
		public const int EVP_CIPH_RAND_KEY = 512;

		// Token: 0x040001EB RID: 491
		public const int EVP_CIPH_FLAG_FIPS = 1024;

		// Token: 0x040001EC RID: 492
		public const int EVP_CIPH_FLAG_NON_FIPS_ALLOW = 2048;

		// Token: 0x040001ED RID: 493
		public const int EVP_CIPH_FLAG_DEFAULT_ASN1 = 4096;

		// Token: 0x040001EE RID: 494
		public const int EVP_CIPH_FLAG_LENGTH_BITS = 8192;

		// Token: 0x040001EF RID: 495
		public const int FIPS_HMAC_MAX_MD_CBLOCK = 128;

		// Token: 0x040001F0 RID: 496
		public const int HMAC_MAX_MD_CBLOCK = 128;

		// Token: 0x040001F1 RID: 497
		private const int BIO_C_SET_FD = 104;

		// Token: 0x040001F2 RID: 498
		private const int BIO_C_SET_MD = 111;

		// Token: 0x040001F3 RID: 499
		private const int BIO_C_GET_MD = 112;

		// Token: 0x040001F4 RID: 500
		private const int BIO_C_GET_MD_CTX = 120;

		// Token: 0x040001F5 RID: 501
		private const int BIO_C_SET_MD_CTX = 148;

		// Token: 0x040001F6 RID: 502
		public const int BIO_NOCLOSE = 0;

		// Token: 0x040001F7 RID: 503
		public const int BIO_CLOSE = 1;

		// Token: 0x040001F8 RID: 504
		private const int BIO_CTRL_SET_CLOSE = 9;

		// Token: 0x040001F9 RID: 505
		public const int SSL_CTRL_OPTIONS = 32;

		// Token: 0x040001FA RID: 506
		public const int SSL_CTRL_MODE = 33;

		// Token: 0x040001FB RID: 507
		public const int SSL_OP_MICROSOFT_SESS_ID_BUG = 1;

		// Token: 0x040001FC RID: 508
		public const int SSL_OP_NETSCAPE_CHALLENGE_BUG = 2;

		// Token: 0x040001FD RID: 509
		public const int SSL_OP_LEGACY_SERVER_CONNECT = 4;

		// Token: 0x040001FE RID: 510
		public const int SSL_OP_NETSCAPE_REUSE_CIPHER_CHANGE_BUG = 8;

		// Token: 0x040001FF RID: 511
		public const int SSL_OP_SSLREF2_REUSE_CERT_TYPE_BUG = 16;

		// Token: 0x04000200 RID: 512
		public const int SSL_OP_MICROSOFT_BIG_SSLV3_BUFFER = 32;

		// Token: 0x04000201 RID: 513
		public const int SSL_OP_MSIE_SSLV2_RSA_PADDING = 64;

		// Token: 0x04000202 RID: 514
		public const int SSL_OP_SSLEAY_080_CLIENT_DH_BUG = 128;

		// Token: 0x04000203 RID: 515
		public const int SSL_OP_TLS_D5_BUG = 256;

		// Token: 0x04000204 RID: 516
		public const int SSL_OP_TLS_BLOCK_PADDING_BUG = 512;

		// Token: 0x04000205 RID: 517
		public const int SSL_OP_DONT_INSERT_EMPTY_FRAGMENTS = 2048;

		// Token: 0x04000206 RID: 518
		public const uint SSL_OP_ALL = 2147487743U;

		// Token: 0x04000207 RID: 519
		public const int SSL_OP_NO_SESSION_RESUMPTION_ON_RENEGOTIATION = 65536;

		// Token: 0x04000208 RID: 520
		public const int SSL_OP_ALLOW_UNSAFE_LEGACY_RENEGOTIATION = 262144;

		// Token: 0x04000209 RID: 521
		public const int SSL_OP_SINGLE_DH_USE = 1048576;

		// Token: 0x0400020A RID: 522
		public const int SSL_OP_EPHEMERAL_RSA = 2097152;

		// Token: 0x0400020B RID: 523
		public const int SSL_OP_CIPHER_SERVER_PREFERENCE = 4194304;

		// Token: 0x0400020C RID: 524
		public const int SSL_OP_TLS_ROLLBACK_BUG = 8388608;

		// Token: 0x0400020D RID: 525
		public const int SSL_OP_NO_SSLv2 = 16777216;

		// Token: 0x0400020E RID: 526
		public const int SSL_OP_NO_SSLv3 = 33554432;

		// Token: 0x0400020F RID: 527
		public const int SSL_OP_NO_TLSv1 = 67108864;

		// Token: 0x04000210 RID: 528
		public const int SSL_OP_PKCS1_CHECK_1 = 134217728;

		// Token: 0x04000211 RID: 529
		public const int SSL_OP_PKCS1_CHECK_2 = 268435456;

		// Token: 0x04000212 RID: 530
		public const int SSL_OP_NETSCAPE_CA_DN_BUG = 536870912;

		// Token: 0x04000213 RID: 531
		public const int SSL_OP_NETSCAPE_DEMO_CIPHER_CHANGE_BUG = 1073741824;

		// Token: 0x04000214 RID: 532
		public const int SSL_OP_NO_TICKET = 16384;

		// Token: 0x04000215 RID: 533
		public const int SSL_MODE_ENABLE_PARTIAL_WRITE = 1;

		// Token: 0x04000216 RID: 534
		public const int SSL_MODE_ACCEPT_MOVING_WRITE_BUFFER = 2;

		// Token: 0x04000217 RID: 535
		public const int SSL_MODE_AUTO_RETRY = 4;

		// Token: 0x04000218 RID: 536
		public const int SSL_MODE_NO_AUTO_CHAIN = 8;

		// Token: 0x04000219 RID: 537
		public const int SSL_MODE_RELEASE_BUFFERS = 16;

		// Token: 0x0400021A RID: 538
		public const int SSL_VERIFY_NONE = 0;

		// Token: 0x0400021B RID: 539
		public const int SSL_VERIFY_PEER = 1;

		// Token: 0x0400021C RID: 540
		public const int SSL_VERIFY_FAIL_IF_NO_PEER_CERT = 2;

		// Token: 0x0400021D RID: 541
		public const int SSL_VERIFY_CLIENT_ONCE = 4;

		// Token: 0x0400021E RID: 542
		public const int SSL_MAX_SID_CTX_LENGTH = 32;

		// Token: 0x0400021F RID: 543
		private static global::System.Collections.Generic.List<object> lock_objects;

		// Token: 0x04000220 RID: 544
		private static global::OpenSSL.Core.Native.CRYPTO_locking_callback CRYPTO_locking_callback_delegate;

		// Token: 0x04000221 RID: 545
		private static global::OpenSSL.Core.Native.CRYPTO_id_callback CRYPTO_id_callback_delegate;

		// Token: 0x04000222 RID: 546
		private static global::System.Collections.Generic.Stack<uint> threadIDs;

		// Token: 0x04000223 RID: 547
		private static global::OpenSSL.Core.Native.MallocFunctionPtr ptr_CRYPTO_dbg_malloc = new global::OpenSSL.Core.Native.MallocFunctionPtr(global::OpenSSL.Core.Native.CRYPTO_dbg_malloc);

		// Token: 0x04000224 RID: 548
		private static global::OpenSSL.Core.Native.ReallocFunctionPtr ptr_CRYPTO_dbg_realloc = new global::OpenSSL.Core.Native.ReallocFunctionPtr(global::OpenSSL.Core.Native.CRYPTO_dbg_realloc);

		// Token: 0x04000225 RID: 549
		private static global::OpenSSL.Core.Native.FreeFunctionPtr ptr_CRYPTO_dbg_free = new global::OpenSSL.Core.Native.FreeFunctionPtr(global::OpenSSL.Core.Native.CRYPTO_dbg_free);

		// Token: 0x04000226 RID: 550
		private static global::OpenSSL.Core.Native.SetOptionsFunctionPtr ptr_CRYPTO_dbg_set_options = new global::OpenSSL.Core.Native.SetOptionsFunctionPtr(global::OpenSSL.Core.Native.CRYPTO_dbg_set_options);

		// Token: 0x04000227 RID: 551
		private static global::OpenSSL.Core.Native.GetOptionsFunctionPtr ptr_CRYPTO_dbg_get_options = new global::OpenSSL.Core.Native.GetOptionsFunctionPtr(global::OpenSSL.Core.Native.CRYPTO_dbg_get_options);

		// Token: 0x0200003F RID: 63
		// (Invoke) Token: 0x0600035D RID: 861
		[global::System.Runtime.InteropServices.UnmanagedFunctionPointer(global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public delegate int pem_password_cb(global::System.IntPtr buf, int size, int rwflag, global::System.IntPtr userdata);

		// Token: 0x02000040 RID: 64
		// (Invoke) Token: 0x06000361 RID: 865
		[global::System.Runtime.InteropServices.UnmanagedFunctionPointer(global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public delegate int GeneratorHandler(int p, int n, global::System.IntPtr arg);

		// Token: 0x02000041 RID: 65
		// (Invoke) Token: 0x06000365 RID: 869
		[global::System.Runtime.InteropServices.UnmanagedFunctionPointer(global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public delegate void ObjectNameHandler(global::System.IntPtr name, global::System.IntPtr arg);

		// Token: 0x02000042 RID: 66
		// (Invoke) Token: 0x06000369 RID: 873
		[global::System.Runtime.InteropServices.UnmanagedFunctionPointer(global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public delegate void CRYPTO_locking_callback(int mode, int type, string file, int line);

		// Token: 0x02000043 RID: 67
		// (Invoke) Token: 0x0600036D RID: 877
		[global::System.Runtime.InteropServices.UnmanagedFunctionPointer(global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public delegate uint CRYPTO_id_callback();

		// Token: 0x02000044 RID: 68
		// (Invoke) Token: 0x06000371 RID: 881
		[global::System.Runtime.InteropServices.UnmanagedFunctionPointer(global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public delegate int VerifyCertCallback(int ok, global::System.IntPtr x509_store_ctx);

		// Token: 0x02000045 RID: 69
		// (Invoke) Token: 0x06000375 RID: 885
		[global::System.Runtime.InteropServices.UnmanagedFunctionPointer(global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public delegate int client_cert_cb(global::System.IntPtr ssl, out global::System.IntPtr x509, out global::System.IntPtr pkey);

		// Token: 0x02000046 RID: 70
		// (Invoke) Token: 0x06000379 RID: 889
		[global::System.Runtime.InteropServices.UnmanagedFunctionPointer(global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public delegate void MallocFunctionPtr(global::System.IntPtr addr, int num, global::System.IntPtr file, int line, int before_p);

		// Token: 0x02000047 RID: 71
		// (Invoke) Token: 0x0600037D RID: 893
		[global::System.Runtime.InteropServices.UnmanagedFunctionPointer(global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public delegate void ReallocFunctionPtr(global::System.IntPtr addr1, global::System.IntPtr addr2, int num, global::System.IntPtr file, int line, int before_p);

		// Token: 0x02000048 RID: 72
		// (Invoke) Token: 0x06000381 RID: 897
		[global::System.Runtime.InteropServices.UnmanagedFunctionPointer(global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public delegate void FreeFunctionPtr(global::System.IntPtr addr, int before_p);

		// Token: 0x02000049 RID: 73
		// (Invoke) Token: 0x06000385 RID: 901
		[global::System.Runtime.InteropServices.UnmanagedFunctionPointer(global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public delegate void SetOptionsFunctionPtr(int bits);

		// Token: 0x0200004A RID: 74
		// (Invoke) Token: 0x06000389 RID: 905
		[global::System.Runtime.InteropServices.UnmanagedFunctionPointer(global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public delegate int GetOptionsFunctionPtr();

		// Token: 0x0200004B RID: 75
		// (Invoke) Token: 0x0600038D RID: 909
		[global::System.Runtime.InteropServices.UnmanagedFunctionPointer(global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public delegate global::System.IntPtr DHCallbackDelegate(global::System.IntPtr ctx, int is_export, int keylength);

		// Token: 0x0200004C RID: 76
		[global::System.Runtime.InteropServices.StructLayout(global::System.Runtime.InteropServices.LayoutKind.Sequential)]
		public class bn_gencb_st
		{
			// Token: 0x04000228 RID: 552
			public uint ver;

			// Token: 0x04000229 RID: 553
			public global::System.IntPtr arg;

			// Token: 0x0400022A RID: 554
			public global::OpenSSL.Core.Native.GeneratorHandler cb;
		}
	}
}
