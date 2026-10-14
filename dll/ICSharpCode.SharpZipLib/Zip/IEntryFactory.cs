using System;
using ICSharpCode.SharpZipLib.Core;

namespace ICSharpCode.SharpZipLib.Zip
{
	// Token: 0x02000049 RID: 73
	public interface IEntryFactory
	{
		// Token: 0x060002E1 RID: 737
		global::ICSharpCode.SharpZipLib.Zip.ZipEntry MakeFileEntry(string fileName);

		// Token: 0x060002E2 RID: 738
		global::ICSharpCode.SharpZipLib.Zip.ZipEntry MakeFileEntry(string fileName, bool useFileSystem);

		// Token: 0x060002E3 RID: 739
		global::ICSharpCode.SharpZipLib.Zip.ZipEntry MakeDirectoryEntry(string directoryName);

		// Token: 0x060002E4 RID: 740
		global::ICSharpCode.SharpZipLib.Zip.ZipEntry MakeDirectoryEntry(string directoryName, bool useFileSystem);

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x060002E5 RID: 741
		// (set) Token: 0x060002E6 RID: 742
		global::ICSharpCode.SharpZipLib.Core.INameTransform NameTransform { get; set; }
	}
}
