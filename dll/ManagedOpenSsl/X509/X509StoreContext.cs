using System;
using System.Runtime.InteropServices;
using OpenSSL.Core;

namespace OpenSSL.X509
{
	// Token: 0x0200008F RID: 143
	public class X509StoreContext : global::OpenSSL.Core.Base
	{
		// Token: 0x060005B7 RID: 1463 RVA: 0x0000AA2A File Offset: 0x00008C2A
		public X509StoreContext() : base(global::OpenSSL.Core.Native.ExpectNonNull(global::OpenSSL.Core.Native.X509_STORE_CTX_new()), true)
		{
		}

		// Token: 0x060005B8 RID: 1464 RVA: 0x0000AA3D File Offset: 0x00008C3D
		internal X509StoreContext(global::System.IntPtr ptr, bool isOwner) : base(ptr, isOwner)
		{
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x060005B9 RID: 1465 RVA: 0x0000AA48 File Offset: 0x00008C48
		public global::OpenSSL.X509.X509Certificate CurrentCert
		{
			get
			{
				global::System.IntPtr ptr = global::OpenSSL.Core.Native.X509_STORE_CTX_get_current_cert(this.ptr);
				return new global::OpenSSL.X509.X509Certificate(ptr, false);
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x060005BA RID: 1466 RVA: 0x0000AA68 File Offset: 0x00008C68
		public int ErrorDepth
		{
			get
			{
				return global::OpenSSL.Core.Native.X509_STORE_CTX_get_error_depth(this.ptr);
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x060005BB RID: 1467 RVA: 0x0000AA75 File Offset: 0x00008C75
		// (set) Token: 0x060005BC RID: 1468 RVA: 0x0000AA82 File Offset: 0x00008C82
		public int Error
		{
			get
			{
				return global::OpenSSL.Core.Native.X509_STORE_CTX_get_error(this.ptr);
			}
			set
			{
				global::OpenSSL.Core.Native.X509_STORE_CTX_set_error(this.ptr, value);
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x060005BD RID: 1469 RVA: 0x0000AA90 File Offset: 0x00008C90
		public global::OpenSSL.X509.X509Store Store
		{
			get
			{
				return new global::OpenSSL.X509.X509Store(this.Raw.ctx, false);
			}
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x060005BE RID: 1470 RVA: 0x0000AAA3 File Offset: 0x00008CA3
		public string ErrorString
		{
			get
			{
				return global::OpenSSL.Core.Native.PtrToStringAnsi(global::OpenSSL.Core.Native.X509_verify_cert_error_string(this.Raw.error), false);
			}
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x060005BF RID: 1471 RVA: 0x0000AABB File Offset: 0x00008CBB
		private global::OpenSSL.X509.X509StoreContext.X509_STORE_CONTEXT Raw
		{
			get
			{
				return (global::OpenSSL.X509.X509StoreContext.X509_STORE_CONTEXT)global::System.Runtime.InteropServices.Marshal.PtrToStructure(this.ptr, typeof(global::OpenSSL.X509.X509StoreContext.X509_STORE_CONTEXT));
			}
		}

		// Token: 0x060005C0 RID: 1472 RVA: 0x0000AAD7 File Offset: 0x00008CD7
		public void Init(global::OpenSSL.X509.X509Store store, global::OpenSSL.X509.X509Certificate cert, global::OpenSSL.X509.X509Chain uchain)
		{
			global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.X509_STORE_CTX_init(this.ptr, store.Handle, (cert != null) ? cert.Handle : global::System.IntPtr.Zero, uchain.Handle));
		}

		// Token: 0x060005C1 RID: 1473 RVA: 0x0000AB08 File Offset: 0x00008D08
		public bool Verify()
		{
			int num = global::OpenSSL.Core.Native.X509_verify_cert(this.ptr);
			if (num < 0)
			{
				throw new global::OpenSSL.Core.OpenSslException();
			}
			return num == 1;
		}

		// Token: 0x060005C2 RID: 1474 RVA: 0x0000AB2F File Offset: 0x00008D2F
		protected override void OnDispose()
		{
			global::OpenSSL.Core.Native.X509_STORE_CTX_free(this.ptr);
		}

		// Token: 0x02000090 RID: 144
		private struct X509_STORE_CONTEXT
		{
			// Token: 0x0400041F RID: 1055
			public global::System.IntPtr ctx;

			// Token: 0x04000420 RID: 1056
			public int current_method;

			// Token: 0x04000421 RID: 1057
			public global::System.IntPtr cert;

			// Token: 0x04000422 RID: 1058
			public global::System.IntPtr untrusted;

			// Token: 0x04000423 RID: 1059
			public global::System.IntPtr crls;

			// Token: 0x04000424 RID: 1060
			public global::System.IntPtr param;

			// Token: 0x04000425 RID: 1061
			public long check_time;

			// Token: 0x04000426 RID: 1062
			public global::System.IntPtr other_ctx;

			// Token: 0x04000427 RID: 1063
			public global::System.IntPtr verify;

			// Token: 0x04000428 RID: 1064
			public global::System.IntPtr verify_cb;

			// Token: 0x04000429 RID: 1065
			public global::System.IntPtr get_issuer;

			// Token: 0x0400042A RID: 1066
			public global::System.IntPtr check_issued;

			// Token: 0x0400042B RID: 1067
			public global::System.IntPtr check_revocation;

			// Token: 0x0400042C RID: 1068
			public global::System.IntPtr get_crl;

			// Token: 0x0400042D RID: 1069
			public global::System.IntPtr check_crl;

			// Token: 0x0400042E RID: 1070
			public global::System.IntPtr cert_crl;

			// Token: 0x0400042F RID: 1071
			public global::System.IntPtr check_policy;

			// Token: 0x04000430 RID: 1072
			public global::System.IntPtr lookup_certs;

			// Token: 0x04000431 RID: 1073
			public global::System.IntPtr lookup_crls;

			// Token: 0x04000432 RID: 1074
			public global::System.IntPtr cleanup;

			// Token: 0x04000433 RID: 1075
			public int depth;

			// Token: 0x04000434 RID: 1076
			public int valid;

			// Token: 0x04000435 RID: 1077
			public int last_untrusted;

			// Token: 0x04000436 RID: 1078
			public global::System.IntPtr chain;

			// Token: 0x04000437 RID: 1079
			public global::System.IntPtr tree;

			// Token: 0x04000438 RID: 1080
			public int explicit_policy;

			// Token: 0x04000439 RID: 1081
			public int error_depth;

			// Token: 0x0400043A RID: 1082
			public int error;

			// Token: 0x0400043B RID: 1083
			public global::System.IntPtr current_cert;

			// Token: 0x0400043C RID: 1084
			public global::System.IntPtr current_issuer;

			// Token: 0x0400043D RID: 1085
			public global::System.IntPtr current_crl;

			// Token: 0x0400043E RID: 1086
			public int current_crl_score;

			// Token: 0x0400043F RID: 1087
			public uint current_reasons;

			// Token: 0x04000440 RID: 1088
			public global::System.IntPtr parent;

			// Token: 0x04000441 RID: 1089
			public global::System.IntPtr ex_data_sk;

			// Token: 0x04000442 RID: 1090
			public int ex_data_dummy;
		}
	}
}
