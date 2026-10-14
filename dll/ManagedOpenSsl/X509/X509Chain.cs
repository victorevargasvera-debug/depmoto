using System;
using OpenSSL.Core;

namespace OpenSSL.X509
{
	// Token: 0x02000082 RID: 130
	public class X509Chain : global::OpenSSL.Core.Stack<global::OpenSSL.X509.X509Certificate>
	{
		// Token: 0x06000541 RID: 1345 RVA: 0x00009D6C File Offset: 0x00007F6C
		public X509Chain()
		{
		}

		// Token: 0x06000542 RID: 1346 RVA: 0x00009D74 File Offset: 0x00007F74
		public X509Chain(global::OpenSSL.Core.BIO bio)
		{
			global::System.IntPtr ptr = global::OpenSSL.Core.Native.ExpectNonNull(global::OpenSSL.Core.Native.PEM_X509_INFO_read_bio(bio.Handle, global::System.IntPtr.Zero, null, global::System.IntPtr.Zero));
			using (global::OpenSSL.Core.Stack<global::OpenSSL.X509.X509CertificateInfo> stack = new global::OpenSSL.Core.Stack<global::OpenSSL.X509.X509CertificateInfo>(ptr, true))
			{
				while (stack.Count > 0)
				{
					using (global::OpenSSL.X509.X509CertificateInfo x509CertificateInfo = stack.Shift())
					{
						global::OpenSSL.X509.X509Certificate certificate = x509CertificateInfo.Certificate;
						if (certificate != null)
						{
							base.Add(certificate);
						}
					}
				}
			}
		}

		// Token: 0x06000543 RID: 1347 RVA: 0x00009E04 File Offset: 0x00008004
		public X509Chain(string pem) : this(new global::OpenSSL.Core.BIO(pem))
		{
		}

		// Token: 0x06000544 RID: 1348 RVA: 0x00009E14 File Offset: 0x00008014
		public global::OpenSSL.X509.X509Certificate FindByIssuerAndSerial(global::OpenSSL.X509.X509Name issuer, int serial)
		{
			global::OpenSSL.X509.X509Certificate result;
			using (global::OpenSSL.Core.Asn1Integer asn1Integer = new global::OpenSSL.Core.Asn1Integer(serial))
			{
				global::System.IntPtr intPtr = global::OpenSSL.Core.Native.X509_find_by_issuer_and_serial(this.ptr, issuer.Handle, asn1Integer.Handle);
				if (intPtr == global::System.IntPtr.Zero)
				{
					result = null;
				}
				else
				{
					global::OpenSSL.X509.X509Certificate x509Certificate = new global::OpenSSL.X509.X509Certificate(intPtr, true);
					x509Certificate.AddRef();
					result = x509Certificate;
				}
			}
			return result;
		}

		// Token: 0x06000545 RID: 1349 RVA: 0x00009E80 File Offset: 0x00008080
		public global::OpenSSL.X509.X509Certificate FindBySubject(global::OpenSSL.X509.X509Name subject)
		{
			global::System.IntPtr intPtr = global::OpenSSL.Core.Native.X509_find_by_subject(this.ptr, subject.Handle);
			if (intPtr == global::System.IntPtr.Zero)
			{
				return null;
			}
			global::OpenSSL.X509.X509Certificate x509Certificate = new global::OpenSSL.X509.X509Certificate(intPtr, true);
			x509Certificate.AddRef();
			return x509Certificate;
		}
	}
}
