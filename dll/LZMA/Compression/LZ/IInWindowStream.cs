using System;
using System.IO;

namespace SevenZip.Compression.LZ
{
	// Token: 0x02000003 RID: 3
	internal interface IInWindowStream
	{
		// Token: 0x06000009 RID: 9
		void SetStream(global::System.IO.Stream inStream);

		// Token: 0x0600000A RID: 10
		void Init();

		// Token: 0x0600000B RID: 11
		void ReleaseStream();

		// Token: 0x0600000C RID: 12
		byte GetIndexByte(int index);

		// Token: 0x0600000D RID: 13
		uint GetMatchLen(int index, uint distance, uint limit);

		// Token: 0x0600000E RID: 14
		uint GetNumAvailableBytes();
	}
}
