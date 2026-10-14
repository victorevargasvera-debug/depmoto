using System;

namespace ICSharpCode.SharpZipLib.Zip
{
	// Token: 0x0200005B RID: 91
	internal interface ITaggedDataFactory
	{
		// Token: 0x0600036E RID: 878
		global::ICSharpCode.SharpZipLib.Zip.ITaggedData Create(short tag, byte[] data, int offset, int count);
	}
}
