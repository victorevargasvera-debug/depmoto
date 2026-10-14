using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using <CppImplementationDetails>;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommunicationPipe;
using msclr;

namespace Motorola.Common.Communication.Security
{
	// Token: 0x02000010 RID: 16
	public class SecurityLayer
	{
		// Token: 0x060000D3 RID: 211 RVA: 0x00020284 File Offset: 0x0001F684
		public unsafe SecurityLayer(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe _commPipe)
		{
			this.m_commPipe = _commPipe;
			global::CommPipeAdapter* ptr = global::<Module>.@new(12U);
			global::CommPipeAdapter* commPipeAdapter;
			try
			{
				if (ptr != null)
				{
					commPipeAdapter = global::<Module>.CommPipeAdapter.{ctor}(ptr, this.m_commPipe);
				}
				else
				{
					commPipeAdapter = 0;
				}
			}
			catch
			{
				global::<Module>.delete((void*)ptr);
				throw;
			}
			this.m_commPipeAdapter = commPipeAdapter;
			this.m_auths = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.Security.AuthenticationMaterials>();
			this.m_ciphers = 0;
			this.m_ssl = null;
			this.m_ssl_ctx = null;
			this.m_ssl_method = null;
			this.m_server_cert = null;
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00020ACC File Offset: 0x0001FECC
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
		public unsafe bool Initialize(global::System.Collections.Generic.List<global::Motorola.Common.Communication.Security.AuthenticationMaterials> cert)
		{
			global::msclr.@lock @lock = null;
			global::msclr.@lock lock2 = new global::msclr.@lock(global::Motorola.Common.Communication.Security.SecurityLayer.sslInitLock);
			try
			{
				@lock = lock2;
				if (global::<Module>.SSL_library_init() > 0)
				{
					goto IL_45;
				}
				object[] args = new object[0];
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("Security: OpenSSL initialize failed.", args);
			}
			catch
			{
				((global::System.IDisposable)@lock).Dispose();
				throw;
			}
			((global::System.IDisposable)@lock).Dispose();
			return false;
			IL_45:
			try
			{
				global::<Module>.OPENSSL_add_all_algorithms_noconf();
				global::<Module>.SSL_load_error_strings();
				global::<Module>.srand((uint)global::<Module>._time64(null));
				int num = 0;
				global::<CppImplementationDetails>.$ArrayType$$$BY0GE@H $ArrayType$$$BY0GE@H;
				do
				{
					*(num * 4 + ref $ArrayType$$$BY0GE@H) = global::<Module>.rand();
					num++;
				}
				while (num < 100);
				global::<Module>.RAND_seed((void*)(&$ArrayType$$$BY0GE@H), 400);
				this.m_auths = cert;
				if (cert != null)
				{
					if (cert.Count > 0)
					{
						if (this.m_auths[0].Mode == global::Motorola.Common.Communication.Security.SecurityEndpointMode.SERVER)
						{
							global::Motorola.Common.Communication.Security.AuthenticationMaterials authenticationMaterials = this.m_auths[0];
							global::ssl_ctx_st* ptr = this.SetupServerCTX(authenticationMaterials);
							this.m_ssl_ctx = ptr;
							this.m_ssl = global::<Module>.SSL_new(ptr);
							global::bio_st* ptr2 = global::<Module>.BIO_new(global::<Module>.BIO_s_rudp());
							global::<Module>.BIO_ctrl(ptr2, 48, 15000, null);
							global::<Module>.BIO_ctrl(ptr2, 50, 0, global::<Module>.CommPipeAdapter.CreatePipeBIO(this.m_commPipeAdapter, true));
							global::<Module>.BIO_ctrl(ptr2, 51, 1, null);
							global::<Module>.BIO_int_ctrl(ptr2, 104, 0, 0);
							global::ssl_st* ssl = this.m_ssl;
							global::bio_st* ptr3 = ptr2;
							global::<Module>.SSL_set_bio(ssl, ptr3, ptr3);
							global::<Module>.SSL_set_accept_state(this.m_ssl);
						}
					}
				}
			}
			catch
			{
				((global::System.IDisposable)@lock).Dispose();
				throw;
			}
			((global::System.IDisposable)@lock).Dispose();
			return true;
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00020C64 File Offset: 0x00020064
		public unsafe int Connect(int secMode)
		{
			if (this.tlsvID == 2)
			{
				this.m_ssl_method = global::<Module>.TLSv1_2_client_method();
			}
			else
			{
				this.m_ssl_method = global::<Module>.TLSv1_client_method();
			}
			this.m_ssl_ctx = global::<Module>.SSL_CTX_new(this.m_ssl_method);
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.Security.AuthenticationMaterials> auths = this.m_auths;
			if (auths != null && auths.Count > 0 && this.m_auths[0].CERTTYPE == global::Motorola.Common.Communication.Security.AuthenType.Certificate)
			{
				if (this.m_auths[0].STREAMTYPE == global::Motorola.Common.Communication.Security.StreamType.TcpStream)
				{
					this.IsStreamTpye = true;
				}
				else
				{
					this.IsStreamTpye = false;
				}
				ref void void& = ref this.m_auths[0].CERTIFICATE_FILE[0];
				try
				{
					void* ptr = ref void&;
					ref void void&2 = ref this.m_auths[0].PUBLIC_KEY[0];
					try
					{
						void* ptr2 = ref void&2;
						ref void void&3 = ref this.m_auths[0].PASSWORD[0];
						try
						{
							void* ptr3 = ref void&3;
							global::<Module>.SSL_CTX_load_verify_locations(this.m_ssl_ctx, (sbyte*)ptr, null);
							global::<Module>.SSL_CTX_set_default_passwd_cb_userdata(this.m_ssl_ctx, ptr3);
							global::<Module>.SSL_CTX_use_certificate_file(this.m_ssl_ctx, (sbyte*)ptr, 1);
							global::<Module>.SSL_CTX_use_PrivateKey_file(this.m_ssl_ctx, (sbyte*)ptr2, 1);
							global::<Module>.SSL_CTX_check_private_key((global::ssl_ctx_st*)this.m_ssl_ctx);
							this.m_ssl = global::<Module>.SSL_new(this.m_ssl_ctx);
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
			else
			{
				global::<Module>.SSL_CTX_set_psk_client_callback(this.m_ssl_ctx, global::<Module>.__unep@?secl_client_callback@@$$FYAIPAUssl_st@@PBDPADIPAEI@Z);
				global::<Module>.SSL_CTX_ctrl(this.m_ssl_ctx, 32, 18432, null);
				this.m_ssl = global::<Module>.SSL_new(this.m_ssl_ctx);
				global::System.IntPtr value = global::<Module>.Motorola.Common.Communication.Security.AuthenticationMaterialsMarshaller.ToPtr(this.m_auths);
				*(int*)(this.m_ssl + 372 / sizeof(global::ssl_st)) = (void*)value;
			}
			this.m_ciphers = secMode;
			sbyte* ptr4;
			if (secMode == 1)
			{
				ptr4 = (sbyte*)(&global::<Module>.??_C@_0BD@IMKOCFAD@PSK?9AES128?9CBC?9SHA?$AA@);
			}
			else if (secMode == 2)
			{
				ptr4 = (sbyte*)(&global::<Module>.??_C@_0N@HKILAJND@PSK?9NULL?9SHA?$AA@);
			}
			else if (secMode == 3)
			{
				ptr4 = (sbyte*)(&global::<Module>.??_C@_0CA@JBILJGGG@PSK?9AES128?9CBC?9SHA?3PSK?9NULL?9SHA?$AA@);
			}
			else
			{
				if (secMode != 4)
				{
					object[] args = new object[0];
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("Security: No specified ciphers ", args);
					goto IL_263;
				}
				ptr4 = (sbyte*)(&global::<Module>.??_C@_0BCI@EOBPDDIH@DHE?9RSA?9AES256?9SHA256?3AES256?9SHA@);
			}
			if (global::<Module>.SSL_set_cipher_list(this.m_ssl, (sbyte*)ptr4) == null)
			{
				object[] args2 = new object[]
				{
					new string((sbyte*)ptr4)
				};
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("Security: set cipher {0} failed.", args2);
				this.Uninitialize();
				return -3;
			}
			object[] args3 = new object[]
			{
				new string((sbyte*)ptr4)
			};
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteSensitive("Security: set cipher to {0} .", args3);
			IL_263:
			global::bio_st* ptr5 = global::<Module>.BIO_new(global::<Module>.BIO_s_rudp());
			global::<Module>.BIO_ctrl(ptr5, 48, 15000, null);
			global::<Module>.BIO_ctrl(ptr5, 50, 0, global::<Module>.CommPipeAdapter.CreatePipeBIO(this.m_commPipeAdapter, this.IsStreamTpye));
			global::<Module>.BIO_ctrl(ptr5, 51, this.IsStreamTpye, null);
			global::<Module>.BIO_int_ctrl(ptr5, 104, 0, 0);
			global::ssl_st* ssl = this.m_ssl;
			global::bio_st* ptr6 = ptr5;
			global::<Module>.SSL_set_bio(ssl, ptr6, ptr6);
			global::<Module>.SSL_set_connect_state(this.m_ssl);
			object[] args4 = new object[0];
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("Security: SSL handshake start...", args4);
			int num = global::<Module>.SSL_do_handshake(this.m_ssl);
			if (num <= 0)
			{
				global::<Module>.is_fatal_ssl_error(this.m_ssl, num);
				object[] args5 = new object[0];
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("Security: SSL handshake failed", args5);
				return -1;
			}
			object[] args6 = new object[0];
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("Security: SSL handshake done...", args6);
			return 1;
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00020330 File Offset: 0x0001F730
		public unsafe void Accept()
		{
			if (global::<Module>.SSL_state((global::ssl_st*)this.m_ssl) != 3)
			{
				do
				{
					new byte[1024];
					int num = global::<Module>.SSL_accept(this.m_ssl);
					int num2 = global::<Module>.SSL_get_error((global::ssl_st*)this.m_ssl, num);
					if (num2 == 2 || num2 == 3 || num2 == 0)
					{
						global::System.Threading.Thread.Sleep(200);
					}
				}
				while (global::<Module>.SSL_state((global::ssl_st*)this.m_ssl) != 3);
			}
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00020394 File Offset: 0x0001F794
		public int SendData(byte[] pBuf, int len)
		{
			if (this.m_ssl != null)
			{
				object[] args = new object[]
				{
					len,
					global::Motorola.Common.Communication.CommonUtil.UtilityMethods.ToHexString(pBuf, 0, len, true)
				};
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteSensitive("Security: SSL Tx: len={0} {1}", args);
				ref void void& = ref pBuf[0];
				int result;
				try
				{
					result = global::<Module>.SSL_write(this.m_ssl, ref void&, len);
				}
				catch
				{
					throw;
				}
				return result;
			}
			return 0;
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00020414 File Offset: 0x0001F814
		public int ReceiveData(byte[] pBuf, int buf_len)
		{
			if (this.m_ssl != null)
			{
				ref void void& = ref pBuf[0];
				int num;
				try
				{
					num = global::<Module>.SSL_read(this.m_ssl, ref void&, buf_len);
					if (num > 0)
					{
						object[] args = new object[]
						{
							num,
							global::Motorola.Common.Communication.CommonUtil.UtilityMethods.ToHexString(pBuf, 0, num, true)
						};
						global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteSensitive("Security: SSL Rx: len={0} {1}", args);
					}
				}
				catch
				{
					throw;
				}
				return num;
			}
			return 0;
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00020498 File Offset: 0x0001F898
		public unsafe void Uninitialize()
		{
			global::ssl_st* ssl = this.m_ssl;
			if (ssl != null)
			{
				global::<Module>.SSL_shutdown(ssl);
				global::<Module>.SSL_free(this.m_ssl);
				this.m_ssl = null;
			}
			global::ssl_ctx_st* ssl_ctx = this.m_ssl_ctx;
			if (ssl_ctx != null)
			{
				global::<Module>.SSL_CTX_free(ssl_ctx);
				this.m_ssl_ctx = null;
			}
		}

		// Token: 0x060000DA RID: 218 RVA: 0x0002031C File Offset: 0x0001F71C
		public void SettlsvID(int tlseID)
		{
			this.tlsvID = tlseID;
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x060000DB RID: 219 RVA: 0x00020180 File Offset: 0x0001F580
		public global::System.ValueType PSK
		{
			get
			{
				return this.m_auths[0];
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x060000DC RID: 220 RVA: 0x000201A0 File Offset: 0x0001F5A0
		public global::System.Collections.Generic.List<global::Motorola.Common.Communication.Security.AuthenticationMaterials> PSKs
		{
			get
			{
				return this.m_auths;
			}
		}

		// Token: 0x060000DD RID: 221 RVA: 0x000204E0 File Offset: 0x0001F8E0
		private unsafe global::ssl_ctx_st* SetupServerCTX(global::System.ValueType cert)
		{
			global::evp_pkey_st* ptr = null;
			global::x509_st* ptr2 = null;
			ref void void& = ref ((global::Motorola.Common.Communication.Security.AuthenticationMaterials)cert).CERT_FILE[0];
			void* ptr3 = ref void&;
			ref void void&2 = ref ((global::Motorola.Common.Communication.Security.AuthenticationMaterials)cert).CERT_PSWD[0];
			void* ptr4 = ref void&2;
			global::bio_st* ptr5 = global::<Module>.BIO_new(global::<Module>.BIO_s_file());
			if (global::<Module>.BIO_ctrl(ptr5, 108, 3, ptr3) != 1)
			{
				return null;
			}
			global::PKCS12* ptr6 = global::<Module>.d2i_PKCS12_bio(ptr5, null);
			if (ptr6 == null)
			{
				global::<Module>.BIO_free(ptr5);
			}
			global::<Module>.BIO_free(ptr5);
			global::<Module>.OPENSSL_add_all_algorithms_noconf();
			ptr = global::<Module>.EVP_PKEY_new();
			if (ptr == null)
			{
				global::<Module>.PKCS12_free(ptr6);
			}
			ptr2 = global::<Module>.X509_new();
			if (ptr2 == null)
			{
				global::<Module>.EVP_PKEY_free(ptr);
				global::<Module>.PKCS12_free(ptr6);
			}
			if (global::<Module>.PKCS12_parse(ptr6, (sbyte*)ptr4, &ptr, &ptr2, null) != 1)
			{
				global::<Module>.X509_free(ptr2);
				global::<Module>.EVP_PKEY_free(ptr);
				global::<Module>.PKCS12_free(ptr6);
				return null;
			}
			global::<Module>.PKCS12_free(ptr6);
			global::ssl_ctx_st* ptr7;
			if (this.tlsvID == 2)
			{
				ptr7 = global::<Module>.SSL_CTX_new(global::<Module>.TLSv1_2_server_method());
			}
			else
			{
				ptr7 = global::<Module>.SSL_CTX_new(global::<Module>.TLSv1_server_method());
			}
			if (ptr7 == null)
			{
				global::<Module>.X509_free(ptr2);
				global::<Module>.EVP_PKEY_free(ptr);
			}
			global::<Module>.SSL_CTX_ctrl(ptr7, 32, -2147480577, null);
			if (global::<Module>.SSL_CTX_set_cipher_list(ptr7, (sbyte*)(&global::<Module>.??_C@_0BDD@BOJFIJEM@AES128?9SHA?3DHE?9RSA?9AES256?9SHA256@)) != 1)
			{
				global::<Module>.X509_free(ptr2);
				global::<Module>.EVP_PKEY_free(ptr);
				return null;
			}
			if (global::<Module>.SSL_CTX_use_certificate(ptr7, ptr2) != 1)
			{
				global::<Module>.X509_free(ptr2);
				global::<Module>.EVP_PKEY_free(ptr);
				return null;
			}
			if (global::<Module>.SSL_CTX_use_PrivateKey(ptr7, ptr) != 1)
			{
				global::<Module>.X509_free(ptr2);
				global::<Module>.EVP_PKEY_free(ptr);
				return null;
			}
			if (global::<Module>.SSL_CTX_check_private_key((global::ssl_ctx_st*)ptr7) != 1)
			{
				global::<Module>.X509_free(ptr2);
				global::<Module>.EVP_PKEY_free(ptr);
				return null;
			}
			global::<Module>.X509_free(ptr2);
			global::<Module>.EVP_PKEY_free(ptr);
			return ptr7;
		}

		// Token: 0x0400006B RID: 107
		public bool IsStreamTpye = false;

		// Token: 0x0400006C RID: 108
		private global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe m_commPipe;

		// Token: 0x0400006D RID: 109
		private unsafe global::CommPipeAdapter* m_commPipeAdapter;

		// Token: 0x0400006E RID: 110
		private global::System.Collections.Generic.List<global::Motorola.Common.Communication.Security.AuthenticationMaterials> m_auths;

		// Token: 0x0400006F RID: 111
		private int m_ciphers;

		// Token: 0x04000070 RID: 112
		private unsafe global::ssl_st* m_ssl;

		// Token: 0x04000071 RID: 113
		private unsafe global::ssl_ctx_st* m_ssl_ctx;

		// Token: 0x04000072 RID: 114
		private unsafe global::ssl_method_st* m_ssl_method;

		// Token: 0x04000073 RID: 115
		private unsafe global::x509_st* m_server_cert;

		// Token: 0x04000074 RID: 116
		private int tlsvID;

		// Token: 0x04000075 RID: 117
		private static object sslInitLock = new object();
	}
}
