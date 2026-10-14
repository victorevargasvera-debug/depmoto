using System;

namespace OpenSSL
{
	// Token: 0x02000020 RID: 32
	internal enum HandshakeState
	{
		// Token: 0x040000AD RID: 173
		None,
		// Token: 0x040000AE RID: 174
		Renegotiate,
		// Token: 0x040000AF RID: 175
		InProcess,
		// Token: 0x040000B0 RID: 176
		RenegotiateInProcess,
		// Token: 0x040000B1 RID: 177
		Complete
	}
}
