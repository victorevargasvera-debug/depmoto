using System;
using System.Collections.Generic;
using OpenSSL.Core;

namespace OpenSSL.X509
{
	// Token: 0x02000083 RID: 131
	public class X509List : global::System.Collections.Generic.List<global::OpenSSL.X509.X509Certificate>
	{
		// Token: 0x06000546 RID: 1350 RVA: 0x00009EBD File Offset: 0x000080BD
		public X509List()
		{
		}

		// Token: 0x06000547 RID: 1351 RVA: 0x00009EC8 File Offset: 0x000080C8
		public X509List(global::OpenSSL.Core.BIO bio)
		{
			global::System.IntPtr ptr = global::OpenSSL.Core.Native.ExpectNonNull(global::OpenSSL.Core.Native.PEM_X509_INFO_read_bio(bio.Handle, global::System.IntPtr.Zero, null, global::System.IntPtr.Zero));
			using (global::OpenSSL.Core.Stack<global::OpenSSL.X509.X509CertificateInfo> stack = new global::OpenSSL.Core.Stack<global::OpenSSL.X509.X509CertificateInfo>(ptr, true))
			{
				while (stack.Count > 0)
				{
					using (global::OpenSSL.X509.X509CertificateInfo x509CertificateInfo = stack.Shift())
					{
						if (x509CertificateInfo.Certificate != null)
						{
							base.Add(x509CertificateInfo.Certificate);
						}
					}
				}
			}
		}

		// Token: 0x06000548 RID: 1352 RVA: 0x00009F5C File Offset: 0x0000815C
		public X509List(string pem) : this(new global::OpenSSL.Core.BIO(pem))
		{
		}

		// Token: 0x06000549 RID: 1353 RVA: 0x00009F6C File Offset: 0x0000816C
		public X509List(byte[] der)
		{
			global::OpenSSL.Core.BIO bio = new global::OpenSSL.Core.BIO(der);
			while ((ulong)bio.NumberRead < (ulong)((long)der.Length))
			{
				global::OpenSSL.X509.X509Certificate item = global::OpenSSL.X509.X509Certificate.FromDER(bio);
				base.Add(item);
			}
		}
	}
}
