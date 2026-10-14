using System;
using OpenSSL.Crypto;

namespace OpenSSL.X509
{
	// Token: 0x02000036 RID: 54
	public class Identity
	{
		// Token: 0x06000124 RID: 292 RVA: 0x00004EF6 File Offset: 0x000030F6
		public Identity(global::OpenSSL.Crypto.CryptoKey key)
		{
			this.key = key;
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000125 RID: 293 RVA: 0x00004F05 File Offset: 0x00003105
		public global::OpenSSL.Crypto.CryptoKey PublicKey
		{
			get
			{
				return this.cert.PublicKey;
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000126 RID: 294 RVA: 0x00004F12 File Offset: 0x00003112
		public global::OpenSSL.Crypto.CryptoKey PrivateKey
		{
			get
			{
				return this.key;
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000127 RID: 295 RVA: 0x00004F1A File Offset: 0x0000311A
		public global::OpenSSL.X509.X509Certificate Certificate
		{
			get
			{
				return this.cert;
			}
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00004F22 File Offset: 0x00003122
		public global::OpenSSL.X509.X509Request CreateRequest(string name)
		{
			return this.CreateRequest(name, global::OpenSSL.Crypto.MessageDigest.DSS1);
		}

		// Token: 0x06000129 RID: 297 RVA: 0x00004F30 File Offset: 0x00003130
		public global::OpenSSL.X509.X509Request CreateRequest(string name, global::OpenSSL.Crypto.MessageDigest digest)
		{
			global::OpenSSL.X509.X509Name subject = new global::OpenSSL.X509.X509Name(name);
			global::OpenSSL.X509.X509Request x509Request = new global::OpenSSL.X509.X509Request(2, subject, this.key);
			x509Request.Sign(this.key, digest);
			return x509Request;
		}

		// Token: 0x0600012A RID: 298 RVA: 0x00004F60 File Offset: 0x00003160
		public bool VerifyResponse(global::OpenSSL.X509.X509Chain chain, out string error)
		{
			this.cert = chain[0];
			global::OpenSSL.X509.X509Store x509Store = new global::OpenSSL.X509.X509Store(chain);
			return x509Store.Verify(this.cert, out error);
		}

		// Token: 0x04000170 RID: 368
		private global::OpenSSL.Crypto.CryptoKey key;

		// Token: 0x04000171 RID: 369
		private global::OpenSSL.X509.X509Certificate cert;
	}
}
