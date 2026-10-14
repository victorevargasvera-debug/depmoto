using System;

namespace OpenSSL
{
	// Token: 0x02000023 RID: 35
	internal enum VerifyMode
	{
		// Token: 0x040000D4 RID: 212
		SSL_VERIFY_NONE,
		// Token: 0x040000D5 RID: 213
		SSL_VERIFY_PEER,
		// Token: 0x040000D6 RID: 214
		SSL_VERIFY_FAIL_IF_NO_PEER_CERT,
		// Token: 0x040000D7 RID: 215
		SSL_VERIFY_CLIENT_ONCE = 4
	}
}
