using System;
using System.Runtime.InteropServices;
using OpenSSL.Core;

namespace OpenSSL.X509
{
	// Token: 0x02000057 RID: 87
	public class PKCS7 : global::OpenSSL.Core.Base
	{
		// Token: 0x060003B2 RID: 946 RVA: 0x00005E0A File Offset: 0x0000400A
		private PKCS7(global::System.IntPtr ptr) : base(ptr, true)
		{
		}

		// Token: 0x060003B3 RID: 947 RVA: 0x00005E14 File Offset: 0x00004014
		public static global::OpenSSL.X509.PKCS7 FromDER(global::OpenSSL.Core.BIO bio)
		{
			return new global::OpenSSL.X509.PKCS7(global::OpenSSL.Core.Native.ExpectNonNull(global::OpenSSL.Core.Native.d2i_PKCS7_bio(bio.Handle, global::System.IntPtr.Zero)));
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x00005E30 File Offset: 0x00004030
		public static global::OpenSSL.X509.PKCS7 FromPEM(global::OpenSSL.Core.BIO bio)
		{
			return new global::OpenSSL.X509.PKCS7(global::OpenSSL.Core.Native.ExpectNonNull(global::OpenSSL.Core.Native.PEM_read_bio_PKCS7(bio.Handle, global::System.IntPtr.Zero, null, global::System.IntPtr.Zero)));
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060003B5 RID: 949 RVA: 0x00005E54 File Offset: 0x00004054
		public global::OpenSSL.X509.X509Chain Certificates
		{
			get
			{
				if (this.stack == null)
				{
					switch (global::OpenSSL.Core.Native.OBJ_obj2nid(this.raw.type))
					{
					case 22:
						this.stack = this.GetStackFromSigned();
						goto IL_54;
					case 24:
						this.stack = this.GetStackFromSignedAndEnveloped();
						goto IL_54;
					}
					throw new global::System.NotSupportedException();
				}
				IL_54:
				global::OpenSSL.X509.X509Chain x509Chain = null;
				if (this.stack != null)
				{
					x509Chain = new global::OpenSSL.X509.X509Chain();
					foreach (global::OpenSSL.X509.X509Certificate item in this.stack)
					{
						x509Chain.Add(item);
					}
				}
				return x509Chain;
			}
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x00005F0C File Offset: 0x0000410C
		private global::OpenSSL.Core.Stack<global::OpenSSL.X509.X509Certificate> GetStackFromSigned()
		{
			return new global::OpenSSL.Core.Stack<global::OpenSSL.X509.X509Certificate>(((global::OpenSSL.X509.PKCS7.PKCS7_SIGNED)global::System.Runtime.InteropServices.Marshal.PtrToStructure(this.raw.ptr, typeof(global::OpenSSL.X509.PKCS7.PKCS7_SIGNED))).cert, false);
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x00005F48 File Offset: 0x00004148
		private global::OpenSSL.Core.Stack<global::OpenSSL.X509.X509Certificate> GetStackFromSignedAndEnveloped()
		{
			return new global::OpenSSL.Core.Stack<global::OpenSSL.X509.X509Certificate>(((global::OpenSSL.X509.PKCS7.PKCS7_SIGN_ENVELOPE)global::System.Runtime.InteropServices.Marshal.PtrToStructure(this.raw.ptr, typeof(global::OpenSSL.X509.PKCS7.PKCS7_SIGN_ENVELOPE))).cert, false);
		}

		// Token: 0x060003B8 RID: 952 RVA: 0x00005F82 File Offset: 0x00004182
		protected override void OnDispose()
		{
			global::OpenSSL.Core.Native.PKCS7_free(this.ptr);
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x00005F8F File Offset: 0x0000418F
		internal override void OnNewHandle(global::System.IntPtr ptr)
		{
			this.raw = (global::OpenSSL.X509.PKCS7._PKCS7)global::System.Runtime.InteropServices.Marshal.PtrToStructure(ptr, typeof(global::OpenSSL.X509.PKCS7._PKCS7));
		}

		// Token: 0x04000249 RID: 585
		private const int NID_pkcs7_signed = 22;

		// Token: 0x0400024A RID: 586
		private const int NID_pkcs7_signedAndEnveloped = 24;

		// Token: 0x0400024B RID: 587
		private const int PKCS7_S_HEADER = 0;

		// Token: 0x0400024C RID: 588
		private const int PKCS7_S_BODY = 1;

		// Token: 0x0400024D RID: 589
		private const int PKCS7_S_TAIL = 2;

		// Token: 0x0400024E RID: 590
		private global::OpenSSL.X509.PKCS7._PKCS7 raw;

		// Token: 0x0400024F RID: 591
		private global::OpenSSL.Core.Stack<global::OpenSSL.X509.X509Certificate> stack;

		// Token: 0x02000058 RID: 88
		private struct _PKCS7
		{
			// Token: 0x04000250 RID: 592
			public global::System.IntPtr asn1;

			// Token: 0x04000251 RID: 593
			public int length;

			// Token: 0x04000252 RID: 594
			public int state;

			// Token: 0x04000253 RID: 595
			public int detached;

			// Token: 0x04000254 RID: 596
			public global::System.IntPtr type;

			// Token: 0x04000255 RID: 597
			public global::System.IntPtr ptr;
		}

		// Token: 0x02000059 RID: 89
		private struct PKCS7_SIGNED
		{
			// Token: 0x04000256 RID: 598
			public global::System.IntPtr version;

			// Token: 0x04000257 RID: 599
			public global::System.IntPtr md_algs;

			// Token: 0x04000258 RID: 600
			public global::System.IntPtr cert;

			// Token: 0x04000259 RID: 601
			public global::System.IntPtr crl;

			// Token: 0x0400025A RID: 602
			public global::System.IntPtr signer_info;

			// Token: 0x0400025B RID: 603
			public global::System.IntPtr contents;
		}

		// Token: 0x0200005A RID: 90
		private struct PKCS7_SIGN_ENVELOPE
		{
			// Token: 0x0400025C RID: 604
			public global::System.IntPtr version;

			// Token: 0x0400025D RID: 605
			public global::System.IntPtr md_algs;

			// Token: 0x0400025E RID: 606
			public global::System.IntPtr cert;

			// Token: 0x0400025F RID: 607
			public global::System.IntPtr crl;

			// Token: 0x04000260 RID: 608
			public global::System.IntPtr signer_info;

			// Token: 0x04000261 RID: 609
			public global::System.IntPtr enc_data;

			// Token: 0x04000262 RID: 610
			public global::System.IntPtr recipientinfo;
		}
	}
}
