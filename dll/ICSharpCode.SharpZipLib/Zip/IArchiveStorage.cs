using System;
using System.IO;

namespace ICSharpCode.SharpZipLib.Zip
{
	// Token: 0x02000071 RID: 113
	public interface IArchiveStorage
	{
		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x0600044B RID: 1099
		global::ICSharpCode.SharpZipLib.Zip.FileUpdateMode UpdateMode { get; }

		// Token: 0x0600044C RID: 1100
		global::System.IO.Stream GetTemporaryOutput();

		// Token: 0x0600044D RID: 1101
		global::System.IO.Stream ConvertTemporaryToFinal();

		// Token: 0x0600044E RID: 1102
		global::System.IO.Stream MakeTemporaryCopy(global::System.IO.Stream stream);

		// Token: 0x0600044F RID: 1103
		global::System.IO.Stream OpenForDirectUpdate(global::System.IO.Stream stream);

		// Token: 0x06000450 RID: 1104
		void Dispose();
	}
}
