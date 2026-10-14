using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using OpenSSL.Core;
using OpenSSL.Crypto;
using OpenSSL.X509;

namespace OpenSSL
{
	// Token: 0x02000069 RID: 105
	internal class SslContext : global::OpenSSL.Core.Base, global::System.IDisposable
	{
		// Token: 0x06000472 RID: 1138 RVA: 0x0000804C File Offset: 0x0000624C
		public SslContext(global::OpenSSL.SslMethod sslMethod, global::OpenSSL.Crypto.DH dh) : base(global::OpenSSL.Core.Native.ExpectNonNull(global::OpenSSL.Core.Native.SSL_CTX_new(sslMethod.Handle)), true)
		{
			if (dh != null)
			{
				global::OpenSSL.Core.Native.SSL_CTX_ctrl(this.ptr, 3, 0, dh.Handle);
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x06000474 RID: 1140 RVA: 0x0000809B File Offset: 0x0000629B
		// (set) Token: 0x06000473 RID: 1139 RVA: 0x00008087 File Offset: 0x00006287
		public global::OpenSSL.SslOptions Options
		{
			get
			{
				return (global::OpenSSL.SslOptions)global::OpenSSL.Core.Native.SSL_CTX_get_options(this.ptr);
			}
			set
			{
				global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.SSL_CTX_set_options(this.ptr, (int)value));
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x06000476 RID: 1142 RVA: 0x000080BC File Offset: 0x000062BC
		// (set) Token: 0x06000475 RID: 1141 RVA: 0x000080A8 File Offset: 0x000062A8
		public global::OpenSSL.SslMode Mode
		{
			get
			{
				return (global::OpenSSL.SslMode)global::OpenSSL.Core.Native.SSL_CTX_get_mode(this.ptr);
			}
			set
			{
				global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.SSL_CTX_set_mode(this.ptr, (int)value));
			}
		}

		// Token: 0x06000477 RID: 1143 RVA: 0x000080C9 File Offset: 0x000062C9
		public void SetCertificateStore(global::OpenSSL.X509.X509Store store)
		{
			store.IsOwner = false;
			global::OpenSSL.Core.Native.SSL_CTX_set_cert_store(this.ptr, store.Handle);
		}

		// Token: 0x06000478 RID: 1144 RVA: 0x000080E3 File Offset: 0x000062E3
		public void SetVerify(global::OpenSSL.VerifyMode mode, global::OpenSSL.RemoteCertificateValidationHandler callback)
		{
			this._verifyCertCallbackThunk = new global::OpenSSL.SslContext.VerifyCertCallbackThunk(callback);
			global::OpenSSL.Core.Native.SSL_CTX_set_verify(this.ptr, (int)mode, this._verifyCertCallbackThunk.Callback);
		}

		// Token: 0x06000479 RID: 1145 RVA: 0x00008108 File Offset: 0x00006308
		public void SetVerifyDepth(int depth)
		{
			global::OpenSSL.Core.Native.SSL_CTX_set_verify_depth(this.ptr, depth);
		}

		// Token: 0x0600047A RID: 1146 RVA: 0x00008118 File Offset: 0x00006318
		public global::OpenSSL.Core.Stack<global::OpenSSL.X509.X509Name> LoadClientCAFile(string filename)
		{
			global::System.IntPtr ptr = global::OpenSSL.Core.Native.SSL_load_client_CA_file(filename);
			return new global::OpenSSL.Core.Stack<global::OpenSSL.X509.X509Name>(ptr, true);
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x0600047B RID: 1147 RVA: 0x00008138 File Offset: 0x00006338
		// (set) Token: 0x0600047C RID: 1148 RVA: 0x0000815A File Offset: 0x0000635A
		public global::OpenSSL.Core.Stack<global::OpenSSL.X509.X509Name> CAList
		{
			get
			{
				global::System.IntPtr ptr = global::OpenSSL.Core.Native.SSL_CTX_get_client_CA_list(this.ptr);
				return new global::OpenSSL.Core.Stack<global::OpenSSL.X509.X509Name>(ptr, false);
			}
			set
			{
				value.IsOwner = false;
				global::OpenSSL.Core.Native.SSL_CTX_set_client_CA_list(this.ptr, value.Handle);
			}
		}

		// Token: 0x0600047D RID: 1149 RVA: 0x00008174 File Offset: 0x00006374
		public int LoadVerifyLocations(string caFile, string caPath)
		{
			return global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.SSL_CTX_load_verify_locations(this.ptr, caFile, caPath));
		}

		// Token: 0x0600047E RID: 1150 RVA: 0x00008188 File Offset: 0x00006388
		public int SetDefaultVerifyPaths()
		{
			return global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.SSL_CTX_set_default_verify_paths(this.ptr));
		}

		// Token: 0x0600047F RID: 1151 RVA: 0x0000819A File Offset: 0x0000639A
		public int SetCipherList(string cipherList)
		{
			return global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.SSL_CTX_set_cipher_list(this.ptr, cipherList));
		}

		// Token: 0x06000480 RID: 1152 RVA: 0x000081AD File Offset: 0x000063AD
		public int UseCertificate(global::OpenSSL.X509.X509Certificate cert)
		{
			return global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.SSL_CTX_use_certificate(this.ptr, cert.Handle));
		}

		// Token: 0x06000481 RID: 1153 RVA: 0x000081C5 File Offset: 0x000063C5
		public int UseCertificateChainFile(string filename)
		{
			return global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.SSL_CTX_use_certificate_chain_file(this.ptr, filename));
		}

		// Token: 0x06000482 RID: 1154 RVA: 0x000081D8 File Offset: 0x000063D8
		public int UsePrivateKey(global::OpenSSL.Crypto.CryptoKey key)
		{
			return global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.SSL_CTX_use_PrivateKey(this.ptr, key.Handle));
		}

		// Token: 0x06000483 RID: 1155 RVA: 0x000081F0 File Offset: 0x000063F0
		public int UsePrivateKeyFile(string filename, global::OpenSSL.SslFileType type)
		{
			return global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.SSL_CTX_use_PrivateKey_file(this.ptr, filename, (int)type));
		}

		// Token: 0x06000484 RID: 1156 RVA: 0x00008204 File Offset: 0x00006404
		public int CheckPrivateKey()
		{
			return global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.SSL_CTX_check_private_key(this.ptr));
		}

		// Token: 0x06000485 RID: 1157 RVA: 0x00008216 File Offset: 0x00006416
		public int SetSessionIdContext(byte[] sid_ctx)
		{
			return global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.SSL_CTX_set_session_id_context(this.ptr, sid_ctx, (uint)sid_ctx.Length));
		}

		// Token: 0x06000486 RID: 1158 RVA: 0x0000822C File Offset: 0x0000642C
		public void SetClientCertCallback(global::OpenSSL.ClientCertCallbackHandler callback)
		{
			this._clientCertCallbackThunk = new global::OpenSSL.SslContext.ClientCertCallbackThunk(callback);
			global::OpenSSL.Core.Native.SSL_CTX_set_client_cert_cb(this.ptr, this._clientCertCallbackThunk.Callback);
		}

		// Token: 0x06000487 RID: 1159 RVA: 0x00008250 File Offset: 0x00006450
		public global::System.Collections.Generic.List<string> GetCipherList()
		{
			global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
			global::OpenSSL.Core.Stack<global::OpenSSL.SslCipher> stack = new global::OpenSSL.Core.Stack<global::OpenSSL.SslCipher>(((global::OpenSSL.SslContext.SSL_CTX)global::System.Runtime.InteropServices.Marshal.PtrToStructure(this.ptr, typeof(global::OpenSSL.SslContext.SSL_CTX))).cipher_list, false);
			foreach (global::OpenSSL.SslCipher sslCipher in stack)
			{
				global::System.IntPtr intPtr = global::OpenSSL.Core.Native.SSL_CIPHER_description(sslCipher.Handle, null, 0);
				if (intPtr != global::System.IntPtr.Zero)
				{
					string item = global::System.Runtime.InteropServices.Marshal.PtrToStringAnsi(intPtr);
					list.Add(item);
					global::OpenSSL.Core.Native.OPENSSL_free(intPtr);
				}
			}
			return list;
		}

		// Token: 0x06000488 RID: 1160 RVA: 0x000082FC File Offset: 0x000064FC
		protected override void OnDispose()
		{
			if (this.dhparams != global::System.IntPtr.Zero)
			{
				global::OpenSSL.Core.Native.DH_free(this.dhparams);
			}
			global::OpenSSL.Core.Native.SSL_CTX_free(this.ptr);
		}

		// Token: 0x04000356 RID: 854
		private global::OpenSSL.SslContext.VerifyCertCallbackThunk _verifyCertCallbackThunk;

		// Token: 0x04000357 RID: 855
		private global::OpenSSL.SslContext.ClientCertCallbackThunk _clientCertCallbackThunk;

		// Token: 0x04000358 RID: 856
		private global::System.IntPtr dhparams = global::System.IntPtr.Zero;

		// Token: 0x0200006A RID: 106
		private struct SSL_CTX
		{
			// Token: 0x04000359 RID: 857
			public const int SSL_MAX_BUF_FREELIST_LEN_DEFAULT = 32;

			// Token: 0x0400035A RID: 858
			public global::System.IntPtr method;

			// Token: 0x0400035B RID: 859
			public global::System.IntPtr cipher_list;

			// Token: 0x0400035C RID: 860
			public global::System.IntPtr cipher_list_by_id;

			// Token: 0x0400035D RID: 861
			public global::System.IntPtr cert_store;

			// Token: 0x0400035E RID: 862
			public global::System.IntPtr sessions;

			// Token: 0x0400035F RID: 863
			public int session_cache_size;

			// Token: 0x04000360 RID: 864
			public global::System.IntPtr session_cache_head;

			// Token: 0x04000361 RID: 865
			public global::System.IntPtr session_cache_tail;

			// Token: 0x04000362 RID: 866
			public int session_cache_mode;

			// Token: 0x04000363 RID: 867
			public int session_timeout;

			// Token: 0x04000364 RID: 868
			public global::System.IntPtr new_session_cb;

			// Token: 0x04000365 RID: 869
			public global::System.IntPtr remove_session_cb;

			// Token: 0x04000366 RID: 870
			public global::System.IntPtr get_session_cb;

			// Token: 0x04000367 RID: 871
			public int stats_sess_connect;

			// Token: 0x04000368 RID: 872
			public int stats_sess_connect_renegotiate;

			// Token: 0x04000369 RID: 873
			public int stats_sess_connect_good;

			// Token: 0x0400036A RID: 874
			public int stats_sess_accept;

			// Token: 0x0400036B RID: 875
			public int stats_sess_accept_renegotiate;

			// Token: 0x0400036C RID: 876
			public int stats_sess_accept_good;

			// Token: 0x0400036D RID: 877
			public int stats_sess_miss;

			// Token: 0x0400036E RID: 878
			public int stats_sess_timeout;

			// Token: 0x0400036F RID: 879
			public int stats_sess_cache_full;

			// Token: 0x04000370 RID: 880
			public int stats_sess_hit;

			// Token: 0x04000371 RID: 881
			public int stats_sess_cb_hit;

			// Token: 0x04000372 RID: 882
			public int references;

			// Token: 0x04000373 RID: 883
			public global::System.IntPtr app_verify_callback;

			// Token: 0x04000374 RID: 884
			public global::System.IntPtr app_verify_arg;

			// Token: 0x04000375 RID: 885
			public global::System.IntPtr default_passwd_callback;

			// Token: 0x04000376 RID: 886
			public global::System.IntPtr default_passwd_callback_userdata;

			// Token: 0x04000377 RID: 887
			public global::System.IntPtr client_cert_cb;

			// Token: 0x04000378 RID: 888
			public global::System.IntPtr app_gen_cookie_cb;

			// Token: 0x04000379 RID: 889
			public global::System.IntPtr app_verify_cookie_cb;

			// Token: 0x0400037A RID: 890
			public global::System.IntPtr ex_data_sk;

			// Token: 0x0400037B RID: 891
			public int ex_data_dummy;

			// Token: 0x0400037C RID: 892
			public global::System.IntPtr rsa_md5;

			// Token: 0x0400037D RID: 893
			public global::System.IntPtr md5;

			// Token: 0x0400037E RID: 894
			public global::System.IntPtr sha1;

			// Token: 0x0400037F RID: 895
			public global::System.IntPtr extra_certs;

			// Token: 0x04000380 RID: 896
			public global::System.IntPtr comp_methods;

			// Token: 0x04000381 RID: 897
			public global::System.IntPtr info_callback;

			// Token: 0x04000382 RID: 898
			public global::System.IntPtr client_CA;

			// Token: 0x04000383 RID: 899
			public uint options;

			// Token: 0x04000384 RID: 900
			public uint mode;

			// Token: 0x04000385 RID: 901
			public int max_cert_list;

			// Token: 0x04000386 RID: 902
			public global::System.IntPtr cert;

			// Token: 0x04000387 RID: 903
			public int read_ahead;

			// Token: 0x04000388 RID: 904
			public global::System.IntPtr msg_callback;

			// Token: 0x04000389 RID: 905
			public global::System.IntPtr msg_callback_arg;

			// Token: 0x0400038A RID: 906
			public int verify_mode;

			// Token: 0x0400038B RID: 907
			public uint sid_ctx_length;

			// Token: 0x0400038C RID: 908
			[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 32)]
			public byte[] sid_ctx;

			// Token: 0x0400038D RID: 909
			public global::System.IntPtr default_verify_callback;

			// Token: 0x0400038E RID: 910
			public global::System.IntPtr generate_session_id;

			// Token: 0x0400038F RID: 911
			public global::System.IntPtr x509_verify_param_name;

			// Token: 0x04000390 RID: 912
			public long x509_verify_param_check_time;

			// Token: 0x04000391 RID: 913
			public int x509_verify_param_inh_flags;

			// Token: 0x04000392 RID: 914
			public int x509_verify_param_flags;

			// Token: 0x04000393 RID: 915
			public int x509_verify_param_purpose;

			// Token: 0x04000394 RID: 916
			public int x509_verify_param_trust;

			// Token: 0x04000395 RID: 917
			public int x509_verify_param_depth;

			// Token: 0x04000396 RID: 918
			public global::System.IntPtr x509_verify_param_policies;

			// Token: 0x04000397 RID: 919
			public int quiet_shutdown;

			// Token: 0x04000398 RID: 920
			public global::System.IntPtr client_cert_engine;

			// Token: 0x04000399 RID: 921
			public global::System.IntPtr tlsext_servername_callback;

			// Token: 0x0400039A RID: 922
			public global::System.IntPtr tlsext_servername_arg;

			// Token: 0x0400039B RID: 923
			[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 16)]
			public byte[] tlsext_tick_key_name;

			// Token: 0x0400039C RID: 924
			[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 16)]
			public byte[] tlsext_tick_hmac_key;

			// Token: 0x0400039D RID: 925
			[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 16)]
			public global::System.IntPtr tlsext_ticket_key_cb;

			// Token: 0x0400039E RID: 926
			public global::System.IntPtr tlsext_status_cb;

			// Token: 0x0400039F RID: 927
			public global::System.IntPtr tlsext_status_arg;

			// Token: 0x040003A0 RID: 928
			public global::System.IntPtr tlsext_opaque_prf_input_callback;

			// Token: 0x040003A1 RID: 929
			public global::System.IntPtr tlsext_opaque_prf_input_callback_arg;

			// Token: 0x040003A2 RID: 930
			public global::System.IntPtr psk_identity_hint;

			// Token: 0x040003A3 RID: 931
			public global::System.IntPtr psk_client_callback;

			// Token: 0x040003A4 RID: 932
			public global::System.IntPtr psk_server_callback;

			// Token: 0x040003A5 RID: 933
			public uint freelist_max_len;

			// Token: 0x040003A6 RID: 934
			public global::System.IntPtr wbuf_freelist;

			// Token: 0x040003A7 RID: 935
			public global::System.IntPtr ssl3_buf_freelist_st;
		}

		// Token: 0x0200006B RID: 107
		internal class ClientCertCallbackThunk
		{
			// Token: 0x17000093 RID: 147
			// (get) Token: 0x06000489 RID: 1161 RVA: 0x00008326 File Offset: 0x00006526
			public global::OpenSSL.Core.Native.client_cert_cb Callback
			{
				get
				{
					if (this.OnClientCertCallback == null)
					{
						return null;
					}
					if (this.nativeCallback != null)
					{
						return this.nativeCallback;
					}
					this.nativeCallback = new global::OpenSSL.Core.Native.client_cert_cb(this.OnClientCertThunk);
					return this.nativeCallback;
				}
			}

			// Token: 0x0600048A RID: 1162 RVA: 0x00008359 File Offset: 0x00006559
			public ClientCertCallbackThunk(global::OpenSSL.ClientCertCallbackHandler callback)
			{
				this.OnClientCertCallback = callback;
			}

			// Token: 0x0600048B RID: 1163 RVA: 0x00008368 File Offset: 0x00006568
			internal int OnClientCertThunk(global::System.IntPtr ssl_ptr, out global::System.IntPtr cert_ptr, out global::System.IntPtr key_ptr)
			{
				global::OpenSSL.X509.X509Certificate x509Certificate = null;
				global::OpenSSL.Crypto.CryptoKey cryptoKey = null;
				global::OpenSSL.Ssl ssl = new global::OpenSSL.Ssl(ssl_ptr, false);
				cert_ptr = global::System.IntPtr.Zero;
				key_ptr = global::System.IntPtr.Zero;
				int num = this.OnClientCertCallback(ssl, out x509Certificate, out cryptoKey);
				if (num != 0)
				{
					if (x509Certificate != null)
					{
						cert_ptr = x509Certificate.Handle;
					}
					if (cryptoKey != null)
					{
						key_ptr = cryptoKey.Handle;
					}
				}
				return num;
			}

			// Token: 0x040003A8 RID: 936
			private global::OpenSSL.ClientCertCallbackHandler OnClientCertCallback;

			// Token: 0x040003A9 RID: 937
			private global::OpenSSL.Core.Native.client_cert_cb nativeCallback;
		}

		// Token: 0x0200006C RID: 108
		internal class VerifyCertCallbackThunk
		{
			// Token: 0x17000094 RID: 148
			// (get) Token: 0x0600048C RID: 1164 RVA: 0x000083CA File Offset: 0x000065CA
			public global::OpenSSL.Core.Native.VerifyCertCallback Callback
			{
				get
				{
					if (this.OnVerifyCert == null)
					{
						return null;
					}
					if (this.nativeCallback != null)
					{
						return this.nativeCallback;
					}
					this.nativeCallback = new global::OpenSSL.Core.Native.VerifyCertCallback(this.OnVerifyCertThunk);
					return this.nativeCallback;
				}
			}

			// Token: 0x0600048D RID: 1165 RVA: 0x000083FD File Offset: 0x000065FD
			public VerifyCertCallbackThunk(global::OpenSSL.RemoteCertificateValidationHandler callback)
			{
				this.OnVerifyCert = callback;
			}

			// Token: 0x0600048E RID: 1166 RVA: 0x0000840C File Offset: 0x0000660C
			internal int OnVerifyCertThunk(int ok, global::System.IntPtr store_ctx)
			{
				global::OpenSSL.X509.X509StoreContext x509StoreContext = new global::OpenSSL.X509.X509StoreContext(store_ctx, false);
				global::OpenSSL.X509.X509Certificate currentCert = x509StoreContext.CurrentCert;
				int errorDepth = x509StoreContext.ErrorDepth;
				global::OpenSSL.VerifyResult error = (global::OpenSSL.VerifyResult)x509StoreContext.Error;
				global::OpenSSL.X509.X509Store store = x509StoreContext.Store;
				global::OpenSSL.Core.Stack<global::OpenSSL.X509.X509Object> objects = store.Objects;
				global::OpenSSL.X509.X509Chain x509Chain = new global::OpenSSL.X509.X509Chain();
				foreach (global::OpenSSL.X509.X509Object x509Object in objects)
				{
					global::OpenSSL.X509.X509Certificate certificate = x509Object.Certificate;
					if (certificate != null)
					{
						x509Chain.Add(certificate);
					}
				}
				if (this.OnVerifyCert(this, currentCert, x509Chain, errorDepth, error))
				{
					return 1;
				}
				return 0;
			}

			// Token: 0x040003AA RID: 938
			private global::OpenSSL.RemoteCertificateValidationHandler OnVerifyCert;

			// Token: 0x040003AB RID: 939
			private global::OpenSSL.Core.Native.VerifyCertCallback nativeCallback;
		}
	}
}
