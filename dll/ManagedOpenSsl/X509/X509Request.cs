using System;
using System.Runtime.InteropServices;
using OpenSSL.Core;
using OpenSSL.Crypto;

namespace OpenSSL.X509
{
	// Token: 0x0200008A RID: 138
	public class X509Request : global::OpenSSL.Core.Base
	{
		// Token: 0x06000595 RID: 1429 RVA: 0x0000A61C File Offset: 0x0000881C
		public X509Request() : base(global::OpenSSL.Core.Native.ExpectNonNull(global::OpenSSL.Core.Native.X509_REQ_new()), true)
		{
		}

		// Token: 0x06000596 RID: 1430 RVA: 0x0000A62F File Offset: 0x0000882F
		internal X509Request(global::System.IntPtr ptr, bool owner) : base(ptr, owner)
		{
		}

		// Token: 0x06000597 RID: 1431 RVA: 0x0000A639 File Offset: 0x00008839
		public X509Request(int version, global::OpenSSL.X509.X509Name subject, global::OpenSSL.Crypto.CryptoKey key) : this()
		{
			this.Version = version;
			this.Subject = subject;
			this.PublicKey = key;
		}

		// Token: 0x06000598 RID: 1432 RVA: 0x0000A656 File Offset: 0x00008856
		public X509Request(global::OpenSSL.Core.BIO bio) : base(global::OpenSSL.Core.Native.ExpectNonNull(global::OpenSSL.Core.Native.PEM_read_bio_X509_REQ(bio.Handle, global::System.IntPtr.Zero, null, global::System.IntPtr.Zero)), true)
		{
		}

		// Token: 0x06000599 RID: 1433 RVA: 0x0000A67A File Offset: 0x0000887A
		public X509Request(string pem) : this(new global::OpenSSL.Core.BIO(pem))
		{
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x0600059A RID: 1434 RVA: 0x0000A688 File Offset: 0x00008888
		private global::OpenSSL.X509.X509Request.X509_REQ Raw
		{
			get
			{
				return (global::OpenSSL.X509.X509Request.X509_REQ)global::System.Runtime.InteropServices.Marshal.PtrToStructure(this.ptr, typeof(global::OpenSSL.X509.X509Request.X509_REQ));
			}
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x0600059B RID: 1435 RVA: 0x0000A6A4 File Offset: 0x000088A4
		private global::OpenSSL.X509.X509Request.X509_REQ_INFO RawInfo
		{
			get
			{
				return (global::OpenSSL.X509.X509Request.X509_REQ_INFO)global::System.Runtime.InteropServices.Marshal.PtrToStructure(this.Raw.req_info, typeof(global::OpenSSL.X509.X509Request.X509_REQ_INFO));
			}
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x0600059C RID: 1436 RVA: 0x0000A6C5 File Offset: 0x000088C5
		// (set) Token: 0x0600059D RID: 1437 RVA: 0x0000A6D7 File Offset: 0x000088D7
		public int Version
		{
			get
			{
				return global::OpenSSL.Core.Native.ASN1_INTEGER_get(this.RawInfo.version);
			}
			set
			{
				global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.X509_REQ_set_version(this.ptr, value));
			}
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x0600059E RID: 1438 RVA: 0x0000A6EB File Offset: 0x000088EB
		// (set) Token: 0x0600059F RID: 1439 RVA: 0x0000A703 File Offset: 0x00008903
		public global::OpenSSL.Crypto.CryptoKey PublicKey
		{
			get
			{
				return new global::OpenSSL.Crypto.CryptoKey(global::OpenSSL.Core.Native.ExpectNonNull(global::OpenSSL.Core.Native.X509_REQ_get_pubkey(this.ptr)), true);
			}
			set
			{
				global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.X509_REQ_set_pubkey(this.ptr, value.Handle));
			}
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x060005A0 RID: 1440 RVA: 0x0000A71C File Offset: 0x0000891C
		// (set) Token: 0x060005A1 RID: 1441 RVA: 0x0000A734 File Offset: 0x00008934
		public global::OpenSSL.X509.X509Name Subject
		{
			get
			{
				return new global::OpenSSL.X509.X509Name(global::OpenSSL.Core.Native.X509_NAME_dup(this.RawInfo.subject), true);
			}
			set
			{
				global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.X509_REQ_set_subject_name(this.ptr, value.Handle));
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x060005A2 RID: 1442 RVA: 0x0000A750 File Offset: 0x00008950
		public string PEM
		{
			get
			{
				string result;
				using (global::OpenSSL.Core.BIO bio = global::OpenSSL.Core.BIO.MemoryBuffer())
				{
					this.Write(bio);
					result = bio.ReadString();
				}
				return result;
			}
		}

		// Token: 0x060005A3 RID: 1443 RVA: 0x0000A790 File Offset: 0x00008990
		public void Sign(global::OpenSSL.Crypto.CryptoKey pkey, global::OpenSSL.Crypto.MessageDigest digest)
		{
			if (global::OpenSSL.Core.Native.X509_REQ_sign(this.ptr, pkey.Handle, digest.Handle) == 0)
			{
				throw new global::OpenSSL.Core.OpenSslException();
			}
		}

		// Token: 0x060005A4 RID: 1444 RVA: 0x0000A7B4 File Offset: 0x000089B4
		public bool Verify(global::OpenSSL.Crypto.CryptoKey pkey)
		{
			int num = global::OpenSSL.Core.Native.X509_REQ_verify(this.ptr, pkey.Handle);
			if (num < 0)
			{
				throw new global::OpenSSL.Core.OpenSslException();
			}
			return num == 1;
		}

		// Token: 0x060005A5 RID: 1445 RVA: 0x0000A7E1 File Offset: 0x000089E1
		public override void Print(global::OpenSSL.Core.BIO bio)
		{
			global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.X509_REQ_print(bio.Handle, this.ptr));
		}

		// Token: 0x060005A6 RID: 1446 RVA: 0x0000A7FA File Offset: 0x000089FA
		public void Write(global::OpenSSL.Core.BIO bio)
		{
			global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.PEM_write_bio_X509_REQ(bio.Handle, this.ptr));
		}

		// Token: 0x060005A7 RID: 1447 RVA: 0x0000A813 File Offset: 0x00008A13
		public global::OpenSSL.X509.X509Certificate CreateCertificate(int days, global::OpenSSL.Crypto.CryptoKey pkey)
		{
			return new global::OpenSSL.X509.X509Certificate(global::OpenSSL.Core.Native.ExpectNonNull(global::OpenSSL.Core.Native.X509_REQ_to_X509(this.ptr, days, pkey.Handle)), true);
		}

		// Token: 0x060005A8 RID: 1448 RVA: 0x0000A832 File Offset: 0x00008A32
		protected override void OnDispose()
		{
			global::OpenSSL.Core.Native.X509_REQ_free(this.ptr);
		}

		// Token: 0x0200008B RID: 139
		private struct X509_REQ_INFO
		{
			// Token: 0x04000401 RID: 1025
			public global::System.IntPtr enc_enc;

			// Token: 0x04000402 RID: 1026
			public int enc_len;

			// Token: 0x04000403 RID: 1027
			public int enc_modified;

			// Token: 0x04000404 RID: 1028
			public global::System.IntPtr version;

			// Token: 0x04000405 RID: 1029
			public global::System.IntPtr subject;

			// Token: 0x04000406 RID: 1030
			public global::System.IntPtr pubkey;

			// Token: 0x04000407 RID: 1031
			public global::System.IntPtr attributes;
		}

		// Token: 0x0200008C RID: 140
		private struct X509_REQ
		{
			// Token: 0x04000408 RID: 1032
			public global::System.IntPtr req_info;

			// Token: 0x04000409 RID: 1033
			public global::System.IntPtr sig_alg;

			// Token: 0x0400040A RID: 1034
			public global::System.IntPtr signature;

			// Token: 0x0400040B RID: 1035
			public int references;
		}
	}
}
