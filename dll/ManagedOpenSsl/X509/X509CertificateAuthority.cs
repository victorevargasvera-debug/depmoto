using System;
using OpenSSL.Crypto;

namespace OpenSSL.X509
{
	// Token: 0x0200007F RID: 127
	public class X509CertificateAuthority : global::System.IDisposable
	{
		// Token: 0x06000531 RID: 1329 RVA: 0x00009A58 File Offset: 0x00007C58
		public static global::OpenSSL.X509.X509CertificateAuthority SelfSigned(global::OpenSSL.X509.Configuration cfg, global::OpenSSL.X509.ISequenceNumber seq, global::OpenSSL.X509.X509Name subject, global::System.DateTime start, global::System.TimeSpan validity)
		{
			global::OpenSSL.Crypto.CryptoKey cryptoKey;
			using (global::OpenSSL.Crypto.DSA dsa = new global::OpenSSL.Crypto.DSA(true))
			{
				cryptoKey = new global::OpenSSL.Crypto.CryptoKey(dsa);
			}
			global::OpenSSL.X509.X509Certificate x509Certificate = new global::OpenSSL.X509.X509Certificate(seq.Next(), subject, subject, cryptoKey, start, start + validity);
			if (cfg != null)
			{
				cfg.ApplyExtensions("v3_ca", x509Certificate, x509Certificate, null);
			}
			x509Certificate.Sign(cryptoKey, global::OpenSSL.Crypto.MessageDigest.DSS1);
			return new global::OpenSSL.X509.X509CertificateAuthority(x509Certificate, cryptoKey, seq, cfg);
		}

		// Token: 0x06000532 RID: 1330 RVA: 0x00009AD0 File Offset: 0x00007CD0
		public static global::OpenSSL.X509.X509CertificateAuthority SelfSigned(global::OpenSSL.X509.Configuration cfg, global::OpenSSL.X509.ISequenceNumber seq, global::OpenSSL.Crypto.CryptoKey key, global::OpenSSL.Crypto.MessageDigest digest, global::OpenSSL.X509.X509Name subject, global::System.DateTime start, global::System.TimeSpan validity)
		{
			global::OpenSSL.X509.X509Certificate x509Certificate = new global::OpenSSL.X509.X509Certificate(seq.Next(), subject, subject, key, start, start + validity);
			if (cfg != null)
			{
				cfg.ApplyExtensions("v3_ca", x509Certificate, x509Certificate, null);
			}
			x509Certificate.Sign(key, digest);
			return new global::OpenSSL.X509.X509CertificateAuthority(x509Certificate, key, seq, cfg);
		}

		// Token: 0x06000533 RID: 1331 RVA: 0x00009B1C File Offset: 0x00007D1C
		public static global::OpenSSL.X509.X509CertificateAuthority SelfSigned(global::OpenSSL.X509.ISequenceNumber seq, global::OpenSSL.Crypto.CryptoKey key, global::OpenSSL.Crypto.MessageDigest digest, global::OpenSSL.X509.X509Name subject, global::System.DateTime start, global::System.TimeSpan validity, global::OpenSSL.X509.X509V3ExtensionList extensions)
		{
			global::OpenSSL.X509.X509Certificate x509Certificate = new global::OpenSSL.X509.X509Certificate(seq.Next(), subject, subject, key, start, start + validity);
			if (extensions != null)
			{
				foreach (global::OpenSSL.X509.X509V3ExtensionValue x509V3ExtensionValue in extensions)
				{
					global::OpenSSL.X509.X509Extension ext = new global::OpenSSL.X509.X509Extension(x509Certificate, x509Certificate, x509V3ExtensionValue.Name, x509V3ExtensionValue.IsCritical, x509V3ExtensionValue.Value);
					x509Certificate.AddExtension(ext);
				}
			}
			x509Certificate.Sign(key, digest);
			return new global::OpenSSL.X509.X509CertificateAuthority(x509Certificate, key, seq, null);
		}

		// Token: 0x06000534 RID: 1332 RVA: 0x00009BB4 File Offset: 0x00007DB4
		public X509CertificateAuthority(global::OpenSSL.X509.X509Certificate caCert, global::OpenSSL.Crypto.CryptoKey caKey, global::OpenSSL.X509.ISequenceNumber serial, global::OpenSSL.X509.Configuration cfg)
		{
			if (!caCert.CheckPrivateKey(caKey))
			{
				throw new global::System.Exception("The specified CA Private Key does match the specified CA Certificate");
			}
			this.caCert = caCert;
			this.caKey = caKey;
			this.serial = serial;
			this.cfg = cfg;
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x06000535 RID: 1333 RVA: 0x00009BED File Offset: 0x00007DED
		public global::OpenSSL.X509.X509Certificate Certificate
		{
			get
			{
				return this.caCert;
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x06000536 RID: 1334 RVA: 0x00009BF5 File Offset: 0x00007DF5
		public global::OpenSSL.Crypto.CryptoKey Key
		{
			get
			{
				return this.caKey;
			}
		}

		// Token: 0x06000537 RID: 1335 RVA: 0x00009BFD File Offset: 0x00007DFD
		public global::OpenSSL.X509.X509Certificate ProcessRequest(global::OpenSSL.X509.X509Request request, global::System.DateTime startTime, global::System.DateTime endTime)
		{
			return this.ProcessRequest(request, startTime, endTime, global::OpenSSL.Crypto.MessageDigest.DSS1);
		}

		// Token: 0x06000538 RID: 1336 RVA: 0x00009C10 File Offset: 0x00007E10
		public global::OpenSSL.X509.X509Certificate ProcessRequest(global::OpenSSL.X509.X509Request request, global::System.DateTime startTime, global::System.DateTime endTime, global::OpenSSL.Crypto.MessageDigest digest)
		{
			global::OpenSSL.X509.X509Certificate x509Certificate = new global::OpenSSL.X509.X509Certificate(this.serial.Next(), request.Subject, this.caCert.Subject, request.PublicKey, startTime, endTime);
			if (this.cfg != null)
			{
				this.cfg.ApplyExtensions("v3_ca", this.caCert, x509Certificate, request);
			}
			x509Certificate.Sign(this.caKey, digest);
			return x509Certificate;
		}

		// Token: 0x06000539 RID: 1337 RVA: 0x00009C78 File Offset: 0x00007E78
		public void Dispose()
		{
			if (this.caKey != null)
			{
				this.caKey.Dispose();
				this.caKey = null;
			}
			if (this.caCert != null)
			{
				this.caCert.Dispose();
				this.caCert = null;
			}
			if (this.cfg != null)
			{
				this.cfg.Dispose();
				this.cfg = null;
			}
		}

		// Token: 0x040003E9 RID: 1001
		private global::OpenSSL.X509.X509Certificate caCert;

		// Token: 0x040003EA RID: 1002
		private global::OpenSSL.Crypto.CryptoKey caKey;

		// Token: 0x040003EB RID: 1003
		private global::OpenSSL.X509.ISequenceNumber serial;

		// Token: 0x040003EC RID: 1004
		private global::OpenSSL.X509.Configuration cfg;
	}
}
