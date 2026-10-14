using System;
using System.IO;

namespace ICSharpCode.SharpZipLib.Zip
{
	// Token: 0x0200006E RID: 110
	public interface IDynamicDataSource
	{
		// Token: 0x06000446 RID: 1094
		global::System.IO.Stream GetSource(global::ICSharpCode.SharpZipLib.Zip.ZipEntry entry, string name);
	}
}
