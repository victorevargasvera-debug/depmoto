using System;
using System.IO;

namespace AcpCryptoLib
{
	// Token: 0x02000004 RID: 4
	public interface IAcpCryptoStream
	{
		// Token: 0x0600000B RID: 11
		global::System.IO.Stream GetWriter(global::System.IO.Stream stream);

		// Token: 0x0600000C RID: 12
		global::System.IO.Stream GetReader(global::System.IO.Stream stream);
	}
}
