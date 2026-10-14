using System;
using OpenSSL.Crypto;
using OpenSSL.X509;

namespace OpenSSL
{
	// Token: 0x02000068 RID: 104
	// (Invoke) Token: 0x0600046F RID: 1135
	internal delegate int ClientCertCallbackHandler(global::OpenSSL.Ssl ssl, out global::OpenSSL.X509.X509Certificate cert, out global::OpenSSL.Crypto.CryptoKey key);
}
