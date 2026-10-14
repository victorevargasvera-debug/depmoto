using System;
using System.Runtime.InteropServices;
using OpenSSL.Core;
using OpenSSL.Crypto;

namespace OpenSSL.X509
{
	// Token: 0x02000080 RID: 128
	internal class X509CertificateInfo : global::OpenSSL.Core.BaseReferenceType, global::OpenSSL.Core.IStackable
	{
		// Token: 0x0600053A RID: 1338 RVA: 0x00009CD3 File Offset: 0x00007ED3
		internal X509CertificateInfo(global::OpenSSL.Core.IStack stack, global::System.IntPtr ptr) : base(ptr, true)
		{
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x0600053B RID: 1339 RVA: 0x00009CE0 File Offset: 0x00007EE0
		public global::OpenSSL.X509.X509Certificate Certificate
		{
			get
			{
				global::OpenSSL.X509.X509Certificate x509Certificate = new global::OpenSSL.X509.X509Certificate(this.raw.x509, true);
				x509Certificate.AddRef();
				return x509Certificate;
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x0600053C RID: 1340 RVA: 0x00009D08 File Offset: 0x00007F08
		public global::OpenSSL.Crypto.CryptoKey Key
		{
			get
			{
				global::OpenSSL.Crypto.CryptoKey cryptoKey = new global::OpenSSL.Crypto.CryptoKey(this.raw.x_pkey, true);
				cryptoKey.AddRef();
				return cryptoKey;
			}
		}

		// Token: 0x0600053D RID: 1341 RVA: 0x00009D2E File Offset: 0x00007F2E
		internal override void OnNewHandle(global::System.IntPtr ptr)
		{
			this.raw = (global::OpenSSL.X509.X509CertificateInfo.X509_INFO)global::System.Runtime.InteropServices.Marshal.PtrToStructure(this.ptr, typeof(global::OpenSSL.X509.X509CertificateInfo.X509_INFO));
		}

		// Token: 0x0600053E RID: 1342 RVA: 0x00009D50 File Offset: 0x00007F50
		protected override void OnDispose()
		{
			global::OpenSSL.Core.Native.X509_INFO_free(this.ptr);
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x0600053F RID: 1343 RVA: 0x00009D5D File Offset: 0x00007F5D
		internal override global::OpenSSL.Core.CryptoLockTypes LockType
		{
			get
			{
				return global::OpenSSL.Core.CryptoLockTypes.CRYPTO_LOCK_X509_INFO;
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x06000540 RID: 1344 RVA: 0x00009D60 File Offset: 0x00007F60
		internal override global::System.Type RawReferenceType
		{
			get
			{
				return typeof(global::OpenSSL.X509.X509CertificateInfo.X509_INFO);
			}
		}

		// Token: 0x040003ED RID: 1005
		private global::OpenSSL.X509.X509CertificateInfo.X509_INFO raw;

		// Token: 0x02000081 RID: 129
		private struct X509_INFO
		{
			// Token: 0x040003EE RID: 1006
			public global::System.IntPtr x509;

			// Token: 0x040003EF RID: 1007
			public global::System.IntPtr crl;

			// Token: 0x040003F0 RID: 1008
			public global::System.IntPtr x_pkey;

			// Token: 0x040003F1 RID: 1009
			public global::System.IntPtr cipher;

			// Token: 0x040003F2 RID: 1010
			[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 16)]
			public byte[] iv;

			// Token: 0x040003F3 RID: 1011
			public int enc_len;

			// Token: 0x040003F4 RID: 1012
			public global::System.IntPtr enc_data;

			// Token: 0x040003F5 RID: 1013
			public int references;
		}
	}
}
