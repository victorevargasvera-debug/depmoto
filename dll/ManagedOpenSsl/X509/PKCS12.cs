using System;
using OpenSSL.Core;
using OpenSSL.Crypto;

namespace OpenSSL.X509
{
	// Token: 0x02000054 RID: 84
	public class PKCS12 : global::OpenSSL.Core.Base
	{
		// Token: 0x060003A8 RID: 936 RVA: 0x00005BDC File Offset: 0x00003DDC
		public PKCS12(string password, global::OpenSSL.Crypto.CryptoKey key, global::OpenSSL.X509.X509Certificate cert, global::OpenSSL.Core.Stack<global::OpenSSL.X509.X509Certificate> ca) : base(global::OpenSSL.X509.PKCS12.Create(password, null, key, cert, ca, global::OpenSSL.X509.PKCS12.PBE.Default, global::OpenSSL.X509.PKCS12.PBE.Default, 0), true)
		{
			this.Init(password);
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x00005C08 File Offset: 0x00003E08
		public PKCS12(string password, string name, global::OpenSSL.Crypto.CryptoKey key, global::OpenSSL.X509.X509Certificate cert, global::OpenSSL.Core.Stack<global::OpenSSL.X509.X509Certificate> ca, global::OpenSSL.X509.PKCS12.PBE keyPbe, global::OpenSSL.X509.PKCS12.PBE certPbe, int iterations) : base(global::OpenSSL.X509.PKCS12.Create(password, name, key, cert, ca, keyPbe, certPbe, iterations), true)
		{
			this.Init(password);
		}

		// Token: 0x060003AA RID: 938 RVA: 0x00005C38 File Offset: 0x00003E38
		private static global::System.IntPtr Create(string password, string name, global::OpenSSL.Crypto.CryptoKey key, global::OpenSSL.X509.X509Certificate cert, global::OpenSSL.Core.Stack<global::OpenSSL.X509.X509Certificate> ca, global::OpenSSL.X509.PKCS12.PBE keyType, global::OpenSSL.X509.PKCS12.PBE certType, int iterations)
		{
			return global::OpenSSL.Core.Native.ExpectNonNull(global::OpenSSL.Core.Native.PKCS12_create(password, name, key.Handle, cert.Handle, ca.Handle, (int)keyType, (int)certType, iterations, 1, (int)key.Type));
		}

		// Token: 0x060003AB RID: 939 RVA: 0x00005C71 File Offset: 0x00003E71
		public PKCS12(global::OpenSSL.Core.BIO bio, string password) : base(global::OpenSSL.Core.Native.ExpectNonNull(global::OpenSSL.Core.Native.d2i_PKCS12_bio(bio.Handle, global::System.IntPtr.Zero)), true)
		{
			this.Init(password);
		}

		// Token: 0x060003AC RID: 940 RVA: 0x00005C98 File Offset: 0x00003E98
		private void Init(string password)
		{
			global::System.IntPtr intPtr;
			global::System.IntPtr intPtr2;
			global::System.IntPtr intPtr3;
			global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.PKCS12_parse(this.ptr, password, out intPtr, out intPtr2, out intPtr3));
			if (intPtr2 != global::System.IntPtr.Zero)
			{
				this.certificate = new global::OpenSSL.X509.X509Certificate(intPtr2, true);
				if (intPtr != global::System.IntPtr.Zero)
				{
					this.privateKey = new global::OpenSSL.Crypto.CryptoKey(intPtr, true);
					this.certificate.PrivateKey = this.privateKey.CopyRef();
				}
			}
			if (intPtr3 != global::System.IntPtr.Zero)
			{
				this.caCertificates = new global::OpenSSL.Core.Stack<global::OpenSSL.X509.X509Certificate>(intPtr3, true);
				return;
			}
			this.caCertificates = new global::OpenSSL.Core.Stack<global::OpenSSL.X509.X509Certificate>();
		}

		// Token: 0x060003AD RID: 941 RVA: 0x00005D2D File Offset: 0x00003F2D
		public void Write(global::OpenSSL.Core.BIO bio)
		{
			global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.i2d_PKCS12_bio(bio.Handle, this.Handle));
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060003AE RID: 942 RVA: 0x00005D48 File Offset: 0x00003F48
		public global::OpenSSL.X509.X509Certificate Certificate
		{
			get
			{
				if (this.certificate != null)
				{
					global::OpenSSL.X509.X509Certificate x509Certificate = this.certificate.CopyRef();
					if (this.privateKey != null)
					{
						x509Certificate.PrivateKey = this.privateKey.CopyRef();
					}
					return x509Certificate;
				}
				return null;
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060003AF RID: 943 RVA: 0x00005D85 File Offset: 0x00003F85
		public global::OpenSSL.Crypto.CryptoKey PrivateKey
		{
			get
			{
				if (this.privateKey != null)
				{
					return this.privateKey.CopyRef();
				}
				return null;
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060003B0 RID: 944 RVA: 0x00005D9C File Offset: 0x00003F9C
		public global::OpenSSL.Core.Stack<global::OpenSSL.X509.X509Certificate> CACertificates
		{
			get
			{
				return this.caCertificates;
			}
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x00005DA4 File Offset: 0x00003FA4
		protected override void OnDispose()
		{
			if (this.certificate != null)
			{
				this.certificate.Dispose();
				this.certificate = null;
			}
			if (this.privateKey != null)
			{
				this.privateKey.Dispose();
				this.privateKey = null;
			}
			if (this.caCertificates != null)
			{
				this.caCertificates.Dispose();
				this.caCertificates = null;
			}
			global::OpenSSL.Core.Native.PKCS12_free(this.ptr);
		}

		// Token: 0x04000235 RID: 565
		private global::OpenSSL.Crypto.CryptoKey privateKey;

		// Token: 0x04000236 RID: 566
		private global::OpenSSL.X509.X509Certificate certificate;

		// Token: 0x04000237 RID: 567
		private global::OpenSSL.Core.Stack<global::OpenSSL.X509.X509Certificate> caCertificates;

		// Token: 0x02000055 RID: 85
		private struct _PKCS12
		{
			// Token: 0x04000238 RID: 568
			private global::System.IntPtr version;

			// Token: 0x04000239 RID: 569
			private global::System.IntPtr mac;

			// Token: 0x0400023A RID: 570
			private global::System.IntPtr authsafes;
		}

		// Token: 0x02000056 RID: 86
		public enum PBE
		{
			// Token: 0x0400023C RID: 572
			Default,
			// Token: 0x0400023D RID: 573
			MD2_DES = 9,
			// Token: 0x0400023E RID: 574
			MD5_DES,
			// Token: 0x0400023F RID: 575
			MD2_RC2_64 = 168,
			// Token: 0x04000240 RID: 576
			MD5_RC2_64,
			// Token: 0x04000241 RID: 577
			SHA1_DES,
			// Token: 0x04000242 RID: 578
			SHA1_RC2_64 = 68,
			// Token: 0x04000243 RID: 579
			SHA1_RC4_128 = 144,
			// Token: 0x04000244 RID: 580
			SHA1_RC4_40,
			// Token: 0x04000245 RID: 581
			SHA1_3DES,
			// Token: 0x04000246 RID: 582
			SHA1_2DES,
			// Token: 0x04000247 RID: 583
			SHA1_RC2_128,
			// Token: 0x04000248 RID: 584
			SHA1_RC2_40
		}
	}
}
