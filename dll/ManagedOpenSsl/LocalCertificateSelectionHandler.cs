using System;
using OpenSSL.X509;

namespace OpenSSL
{
	// Token: 0x0200006E RID: 110
	// (Invoke) Token: 0x06000494 RID: 1172
	public delegate global::OpenSSL.X509.X509Certificate LocalCertificateSelectionHandler(object sender, string targetHost, global::OpenSSL.X509.X509List localCerts, global::OpenSSL.X509.X509Certificate remoteCert, string[] acceptableIssuers);
}
