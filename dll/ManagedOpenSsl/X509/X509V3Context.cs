using System;
using System.Runtime.InteropServices;
using OpenSSL.Core;

namespace OpenSSL.X509
{
	// Token: 0x02000026 RID: 38
	internal class X509V3Context : global::OpenSSL.Core.Base
	{
		// Token: 0x060000AA RID: 170 RVA: 0x00003D2D File Offset: 0x00001F2D
		private X509V3Context() : base(global::OpenSSL.Core.Native.OPENSSL_malloc(global::System.Runtime.InteropServices.Marshal.SizeOf(typeof(global::OpenSSL.X509.X509V3Context.X509V3_CTX))), true)
		{
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00003D4C File Offset: 0x00001F4C
		public X509V3Context(global::OpenSSL.X509.X509Certificate issuer, global::OpenSSL.X509.X509Certificate subject, global::OpenSSL.X509.X509Request request) : this()
		{
			global::OpenSSL.Core.Native.X509V3_set_ctx(this.ptr, (issuer != null) ? issuer.Handle : global::System.IntPtr.Zero, (subject != null) ? subject.Handle : global::System.IntPtr.Zero, (request != null) ? request.Handle : global::System.IntPtr.Zero, global::System.IntPtr.Zero, 0);
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00003DA0 File Offset: 0x00001FA0
		public void SetNoDB()
		{
			int num = (int)global::System.Runtime.InteropServices.Marshal.OffsetOf(typeof(global::OpenSSL.X509.X509V3Context.X509V3_CTX), "db");
			global::System.IntPtr ptr = new global::System.IntPtr((int)this.ptr + num);
			global::System.Runtime.InteropServices.Marshal.WriteIntPtr(ptr, global::System.IntPtr.Zero);
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00003DE6 File Offset: 0x00001FE6
		public void SetConfiguration(global::OpenSSL.X509.Configuration cfg)
		{
			global::OpenSSL.Core.Native.X509V3_set_nconf(this.ptr, cfg.Handle);
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00003DF9 File Offset: 0x00001FF9
		protected override void OnDispose()
		{
			global::OpenSSL.Core.Native.OPENSSL_free(this.ptr);
		}

		// Token: 0x02000027 RID: 39
		private struct X509V3_CTX
		{
			// Token: 0x0400011D RID: 285
			public int flags;

			// Token: 0x0400011E RID: 286
			public global::System.IntPtr issuer_cert;

			// Token: 0x0400011F RID: 287
			public global::System.IntPtr subject_cert;

			// Token: 0x04000120 RID: 288
			public global::System.IntPtr subject_req;

			// Token: 0x04000121 RID: 289
			public global::System.IntPtr crl;

			// Token: 0x04000122 RID: 290
			public global::System.IntPtr db_meth;

			// Token: 0x04000123 RID: 291
			public global::System.IntPtr db;
		}
	}
}
