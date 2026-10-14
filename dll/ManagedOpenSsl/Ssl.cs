using System;
using System.Runtime.InteropServices;
using OpenSSL.Core;
using OpenSSL.X509;

namespace OpenSSL
{
	// Token: 0x02000060 RID: 96
	internal class Ssl : global::OpenSSL.Core.Base, global::System.IDisposable
	{
		// Token: 0x060003F4 RID: 1012 RVA: 0x000066F1 File Offset: 0x000048F1
		public Ssl(global::OpenSSL.SslContext ctx) : base(global::OpenSSL.Core.Native.ExpectNonNull(global::OpenSSL.Core.Native.SSL_new(ctx.Handle)), true)
		{
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x0000670A File Offset: 0x0000490A
		internal Ssl(global::System.IntPtr ptr, bool takeOwnership) : base(ptr, takeOwnership)
		{
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060003F6 RID: 1014 RVA: 0x00006714 File Offset: 0x00004914
		// (set) Token: 0x060003F7 RID: 1015 RVA: 0x00006758 File Offset: 0x00004958
		public int State
		{
			get
			{
				int num = (int)global::System.Runtime.InteropServices.Marshal.OffsetOf(typeof(global::OpenSSL.Ssl.ssl_st), "state");
				global::System.IntPtr ptr = new global::System.IntPtr((int)this.ptr + num);
				return global::System.Runtime.InteropServices.Marshal.ReadInt32(ptr);
			}
			set
			{
				int num = (int)global::System.Runtime.InteropServices.Marshal.OffsetOf(typeof(global::OpenSSL.Ssl.ssl_st), "state");
				global::System.IntPtr ptr = new global::System.IntPtr((int)this.ptr + num);
				global::System.Runtime.InteropServices.Marshal.WriteInt32(ptr, value);
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x060003F8 RID: 1016 RVA: 0x0000679A File Offset: 0x0000499A
		public global::OpenSSL.SslCipher CurrentCipher
		{
			get
			{
				return new global::OpenSSL.SslCipher(global::OpenSSL.Core.Native.SSL_get_current_cipher(this.Handle), false);
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x060003F9 RID: 1017 RVA: 0x000067B0 File Offset: 0x000049B0
		// (set) Token: 0x060003FA RID: 1018 RVA: 0x000067D2 File Offset: 0x000049D2
		public global::OpenSSL.Core.Stack<global::OpenSSL.X509.X509Name> CAList
		{
			get
			{
				global::System.IntPtr ptr = global::OpenSSL.Core.Native.SSL_get_client_CA_list(this.ptr);
				return new global::OpenSSL.Core.Stack<global::OpenSSL.X509.X509Name>(ptr, false);
			}
			set
			{
				global::OpenSSL.Core.Native.SSL_set_client_CA_list(this.ptr, value.Handle);
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x060003FB RID: 1019 RVA: 0x000067E8 File Offset: 0x000049E8
		// (set) Token: 0x060003FC RID: 1020 RVA: 0x0000680D File Offset: 0x00004A0D
		public global::OpenSSL.X509.X509Certificate LocalCertificate
		{
			get
			{
				global::System.IntPtr ptr = global::OpenSSL.Core.Native.ExpectNonNull(global::OpenSSL.Core.Native.SSL_get_certificate(this.ptr));
				return new global::OpenSSL.X509.X509Certificate(ptr, false);
			}
			set
			{
				global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.SSL_use_certificate(this.ptr, value.Handle));
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x060003FD RID: 1021 RVA: 0x00006826 File Offset: 0x00004A26
		public global::OpenSSL.X509.X509Certificate RemoteCertificate
		{
			get
			{
				return this.GetPeerCertificate();
			}
		}

		// Token: 0x060003FE RID: 1022 RVA: 0x0000682E File Offset: 0x00004A2E
		public int Accept()
		{
			return global::OpenSSL.Core.Native.SSL_accept(this.ptr);
		}

		// Token: 0x060003FF RID: 1023 RVA: 0x0000683B File Offset: 0x00004A3B
		public int Connect()
		{
			return global::OpenSSL.Core.Native.SSL_connect(this.ptr);
		}

		// Token: 0x06000400 RID: 1024 RVA: 0x00006848 File Offset: 0x00004A48
		public global::OpenSSL.SslError GetError(int ret_code)
		{
			return (global::OpenSSL.SslError)global::OpenSSL.Core.Native.SSL_get_error(this.ptr, ret_code);
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x00006858 File Offset: 0x00004A58
		public global::OpenSSL.X509.X509Certificate GetPeerCertificate()
		{
			global::System.IntPtr ptr = global::OpenSSL.Core.Native.ExpectNonNull(global::OpenSSL.Core.Native.SSL_get_peer_certificate(this.ptr));
			return new global::OpenSSL.X509.X509Certificate(ptr, true);
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x0000687F File Offset: 0x00004A7F
		public global::OpenSSL.VerifyResult GetVerifyResult()
		{
			return (global::OpenSSL.VerifyResult)global::OpenSSL.Core.Native.SSL_get_verify_result(this.ptr);
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x0000688C File Offset: 0x00004A8C
		public void SetVerifyResult(global::OpenSSL.VerifyResult result)
		{
			global::OpenSSL.Core.Native.SSL_set_verify_result(this.ptr, (int)result);
		}

		// Token: 0x06000404 RID: 1028 RVA: 0x0000689B File Offset: 0x00004A9B
		public int Shutdown()
		{
			return global::OpenSSL.Core.Native.SSL_shutdown(this.ptr);
		}

		// Token: 0x06000405 RID: 1029 RVA: 0x000068A8 File Offset: 0x00004AA8
		public int Write(byte[] buf, int len)
		{
			return global::OpenSSL.Core.Native.SSL_write(this.ptr, buf, len);
		}

		// Token: 0x06000406 RID: 1030 RVA: 0x000068B7 File Offset: 0x00004AB7
		public int Read(byte[] buf, int len)
		{
			return global::OpenSSL.Core.Native.SSL_read(this.ptr, buf, len);
		}

		// Token: 0x06000407 RID: 1031 RVA: 0x000068C6 File Offset: 0x00004AC6
		public int SetSessionIdContext(byte[] sid_ctx, uint sid_ctx_len)
		{
			return global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.SSL_set_session_id_context(this.ptr, sid_ctx, sid_ctx_len));
		}

		// Token: 0x06000408 RID: 1032 RVA: 0x000068DA File Offset: 0x00004ADA
		public int Renegotiate()
		{
			return global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.SSL_renegotiate(this.ptr));
		}

		// Token: 0x06000409 RID: 1033 RVA: 0x000068EC File Offset: 0x00004AEC
		public int DoHandshake()
		{
			return global::OpenSSL.Core.Native.SSL_do_handshake(this.ptr);
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x000068F9 File Offset: 0x00004AF9
		public void SetAcceptState()
		{
			global::OpenSSL.Core.Native.SSL_set_accept_state(this.ptr);
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x00006906 File Offset: 0x00004B06
		public void SetConnectState()
		{
			global::OpenSSL.Core.Native.SSL_set_connect_state(this.ptr);
		}

		// Token: 0x0600040C RID: 1036 RVA: 0x00006913 File Offset: 0x00004B13
		public void SetBIO(global::OpenSSL.Core.BIO read, global::OpenSSL.Core.BIO write)
		{
			global::OpenSSL.Core.Native.SSL_set_bio(this.ptr, read.Handle, write.Handle);
		}

		// Token: 0x0600040D RID: 1037 RVA: 0x0000692C File Offset: 0x00004B2C
		public int UseCertificateFile(string filename, global::OpenSSL.SslFileType type)
		{
			return global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.SSL_use_certificate_file(this.ptr, filename, (int)type));
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x00006940 File Offset: 0x00004B40
		public int UsePrivateKeyFile(string filename, global::OpenSSL.SslFileType type)
		{
			return global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.SSL_use_PrivateKey_file(this.ptr, filename, (int)type));
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x00006954 File Offset: 0x00004B54
		public int Clear()
		{
			return global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.SSL_clear(this.ptr));
		}

		// Token: 0x06000410 RID: 1040 RVA: 0x00006966 File Offset: 0x00004B66
		protected override void OnDispose()
		{
			global::OpenSSL.Core.Native.SSL_free(this.Handle);
		}

		// Token: 0x0400028D RID: 653
		internal const int SSL_ST_CONNECT = 4096;

		// Token: 0x0400028E RID: 654
		internal const int SSL_ST_ACCEPT = 8192;

		// Token: 0x02000061 RID: 97
		private struct ssl_st
		{
			// Token: 0x0400028F RID: 655
			public int version;

			// Token: 0x04000290 RID: 656
			public int type;

			// Token: 0x04000291 RID: 657
			public global::System.IntPtr method;

			// Token: 0x04000292 RID: 658
			public global::System.IntPtr rbio;

			// Token: 0x04000293 RID: 659
			public global::System.IntPtr wbio;

			// Token: 0x04000294 RID: 660
			public global::System.IntPtr bbio;

			// Token: 0x04000295 RID: 661
			public int rwstate;

			// Token: 0x04000296 RID: 662
			public int in_handshake;

			// Token: 0x04000297 RID: 663
			public global::System.IntPtr handshake_func;

			// Token: 0x04000298 RID: 664
			public int server;

			// Token: 0x04000299 RID: 665
			public int new_session;

			// Token: 0x0400029A RID: 666
			public int quiet_shutdown;

			// Token: 0x0400029B RID: 667
			public int shutdown;

			// Token: 0x0400029C RID: 668
			public int state;

			// Token: 0x0400029D RID: 669
			public int rstate;

			// Token: 0x0400029E RID: 670
			public global::System.IntPtr init_buf;

			// Token: 0x0400029F RID: 671
			public global::System.IntPtr init_msg;

			// Token: 0x040002A0 RID: 672
			public int init_num;

			// Token: 0x040002A1 RID: 673
			public int init_off;

			// Token: 0x040002A2 RID: 674
			public global::System.IntPtr packet;

			// Token: 0x040002A3 RID: 675
			public uint packet_length;

			// Token: 0x040002A4 RID: 676
			public global::System.IntPtr s2;

			// Token: 0x040002A5 RID: 677
			public global::System.IntPtr s3;

			// Token: 0x040002A6 RID: 678
			public global::System.IntPtr d1;

			// Token: 0x040002A7 RID: 679
			public int read_ahead;

			// Token: 0x040002A8 RID: 680
			public global::System.IntPtr msg_callback;

			// Token: 0x040002A9 RID: 681
			public global::System.IntPtr msg_callback_arg;

			// Token: 0x040002AA RID: 682
			public int hit;

			// Token: 0x040002AB RID: 683
			public global::System.IntPtr param;

			// Token: 0x040002AC RID: 684
			public global::System.IntPtr cipher_list;

			// Token: 0x040002AD RID: 685
			public global::System.IntPtr cipher_list_by_id;

			// Token: 0x040002AE RID: 686
			public int mac_flags;

			// Token: 0x040002AF RID: 687
			public global::System.IntPtr enc_read_ctx;

			// Token: 0x040002B0 RID: 688
			public global::System.IntPtr read_hash;

			// Token: 0x040002B1 RID: 689
			public global::System.IntPtr expand;

			// Token: 0x040002B2 RID: 690
			public global::System.IntPtr enc_write_ctx;

			// Token: 0x040002B3 RID: 691
			public global::System.IntPtr write_hash;

			// Token: 0x040002B4 RID: 692
			public global::System.IntPtr compress;

			// Token: 0x040002B5 RID: 693
			public global::System.IntPtr cert;

			// Token: 0x040002B6 RID: 694
			public uint sid_ctx_length;

			// Token: 0x040002B7 RID: 695
			[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 32)]
			public byte[] sid_ctx;

			// Token: 0x040002B8 RID: 696
			public global::System.IntPtr session;

			// Token: 0x040002B9 RID: 697
			public global::System.IntPtr generate_session_id;

			// Token: 0x040002BA RID: 698
			public int verify_mode;

			// Token: 0x040002BB RID: 699
			public global::System.IntPtr verify_callback;

			// Token: 0x040002BC RID: 700
			public global::System.IntPtr info_callback;

			// Token: 0x040002BD RID: 701
			public int error;

			// Token: 0x040002BE RID: 702
			public int error_code;

			// Token: 0x040002BF RID: 703
			public global::System.IntPtr kssl_ctx;

			// Token: 0x040002C0 RID: 704
			public global::System.IntPtr psk_client_callbackty;

			// Token: 0x040002C1 RID: 705
			public global::System.IntPtr psk_server_callback;

			// Token: 0x040002C2 RID: 706
			public global::System.IntPtr ctx;

			// Token: 0x040002C3 RID: 707
			public int debug;

			// Token: 0x040002C4 RID: 708
			public int verify_result;

			// Token: 0x040002C5 RID: 709
			public global::System.IntPtr ex_data_sk;

			// Token: 0x040002C6 RID: 710
			public int ex_data_dummy;

			// Token: 0x040002C7 RID: 711
			public global::System.IntPtr client_CA;

			// Token: 0x040002C8 RID: 712
			public int references;

			// Token: 0x040002C9 RID: 713
			public uint options;

			// Token: 0x040002CA RID: 714
			public uint mode;

			// Token: 0x040002CB RID: 715
			public int max_cert_list;

			// Token: 0x040002CC RID: 716
			public int first_packet;

			// Token: 0x040002CD RID: 717
			public int client_version;

			// Token: 0x040002CE RID: 718
			public uint max_send_fragment;

			// Token: 0x040002CF RID: 719
			public global::System.IntPtr tlsext_debug_cb;

			// Token: 0x040002D0 RID: 720
			public global::System.IntPtr tlsext_debug_arg;

			// Token: 0x040002D1 RID: 721
			public global::System.IntPtr tlsext_hostname;

			// Token: 0x040002D2 RID: 722
			public int servername_done;

			// Token: 0x040002D3 RID: 723
			public int tlsext_status_type;

			// Token: 0x040002D4 RID: 724
			public int tlsext_status_expected;

			// Token: 0x040002D5 RID: 725
			public global::System.IntPtr tlsext_ocsp_ids;

			// Token: 0x040002D6 RID: 726
			public global::System.IntPtr tlsext_ocsp_exts;

			// Token: 0x040002D7 RID: 727
			public global::System.IntPtr tlsext_ocsp_resp;

			// Token: 0x040002D8 RID: 728
			public int tlsext_ocsp_resplen;

			// Token: 0x040002D9 RID: 729
			public int tlsext_ticket_expected;

			// Token: 0x040002DA RID: 730
			public uint tlsext_ecpointformatlist_length;

			// Token: 0x040002DB RID: 731
			public global::System.IntPtr tlsext_ecpointformatlist;

			// Token: 0x040002DC RID: 732
			public uint tlsext_ellipticcurvelist_length;

			// Token: 0x040002DD RID: 733
			public global::System.IntPtr tlsext_ellipticcurvelist;

			// Token: 0x040002DE RID: 734
			public global::System.IntPtr tlsext_opaque_prf_input;

			// Token: 0x040002DF RID: 735
			public uint tlsext_opaque_prf_input_len;

			// Token: 0x040002E0 RID: 736
			public global::System.IntPtr tlsext_session_ticket;

			// Token: 0x040002E1 RID: 737
			public global::System.IntPtr initial_ctx;
		}
	}
}
