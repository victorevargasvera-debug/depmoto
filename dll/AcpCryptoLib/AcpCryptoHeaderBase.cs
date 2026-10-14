using System;

namespace AcpCryptoLib
{
	// Token: 0x02000007 RID: 7
	internal abstract class AcpCryptoHeaderBase
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600001B RID: 27
		internal abstract byte[] Data { get; }

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600001C RID: 28
		internal abstract object Key { get; }
	}
}
