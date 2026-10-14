using System;
using System.IO;

namespace ICSharpCode.SharpZipLib.Zip
{
	// Token: 0x0200006F RID: 111
	public class StaticDiskDataSource : global::ICSharpCode.SharpZipLib.Zip.IStaticDataSource
	{
		// Token: 0x06000447 RID: 1095 RVA: 0x0001577F File Offset: 0x0001477F
		public StaticDiskDataSource(string fileName)
		{
			this.fileName_ = fileName;
		}

		// Token: 0x06000448 RID: 1096 RVA: 0x0001578E File Offset: 0x0001478E
		public global::System.IO.Stream GetSource()
		{
			return global::System.IO.File.OpenRead(this.fileName_);
		}

		// Token: 0x040002CA RID: 714
		private string fileName_;
	}
}
