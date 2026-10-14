using System;
using System.IO;

namespace ICSharpCode.SharpZipLib.Zip
{
	// Token: 0x02000070 RID: 112
	public class DynamicDiskDataSource : global::ICSharpCode.SharpZipLib.Zip.IDynamicDataSource
	{
		// Token: 0x0600044A RID: 1098 RVA: 0x000157A4 File Offset: 0x000147A4
		public global::System.IO.Stream GetSource(global::ICSharpCode.SharpZipLib.Zip.ZipEntry entry, string name)
		{
			global::System.IO.Stream result = null;
			if (name != null)
			{
				result = global::System.IO.File.OpenRead(name);
			}
			return result;
		}
	}
}
