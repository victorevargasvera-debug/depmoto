using System;
using OpenSSL.X509;

namespace OpenSSL
{
	// Token: 0x0200006D RID: 109
	// (Invoke) Token: 0x06000490 RID: 1168
	public delegate bool RemoteCertificateValidationHandler(object sender, global::OpenSSL.X509.X509Certificate cert, global::OpenSSL.X509.X509Chain chain, int depth, global::OpenSSL.VerifyResult result);
}
