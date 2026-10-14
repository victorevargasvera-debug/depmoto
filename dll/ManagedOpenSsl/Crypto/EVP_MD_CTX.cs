using System;

namespace OpenSSL.Crypto
{
	// Token: 0x02000039 RID: 57
	internal struct EVP_MD_CTX
	{
		// Token: 0x0400018E RID: 398
		public global::System.IntPtr digest;

		// Token: 0x0400018F RID: 399
		public global::System.IntPtr engine;

		// Token: 0x04000190 RID: 400
		public uint flags;

		// Token: 0x04000191 RID: 401
		public global::System.IntPtr md_data;

		// Token: 0x04000192 RID: 402
		public global::System.IntPtr pctx;

		// Token: 0x04000193 RID: 403
		public global::System.IntPtr update;
	}
}
