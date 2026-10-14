using System;
using System.IO;

namespace SevenZip
{
	// Token: 0x0200000B RID: 11
	public interface ICoder
	{
		// Token: 0x0600003A RID: 58
		void Code(global::System.IO.Stream inStream, global::System.IO.Stream outStream, long inSize, long outSize, global::SevenZip.ICodeProgress progress);
	}
}
