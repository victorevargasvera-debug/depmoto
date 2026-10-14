using System;

namespace SevenZip.Compression.LZ
{
	// Token: 0x02000004 RID: 4
	internal interface IMatchFinder : global::SevenZip.Compression.LZ.IInWindowStream
	{
		// Token: 0x0600000F RID: 15
		void Create(uint historySize, uint keepAddBufferBefore, uint matchMaxLen, uint keepAddBufferAfter);

		// Token: 0x06000010 RID: 16
		uint GetMatches(uint[] distances);

		// Token: 0x06000011 RID: 17
		void Skip(uint num);
	}
}
