using System;
using System.IO;

namespace ICSharpCode.SharpZipLib.Zip
{
	// Token: 0x02000072 RID: 114
	public abstract class BaseArchiveStorage : global::ICSharpCode.SharpZipLib.Zip.IArchiveStorage
	{
		// Token: 0x06000451 RID: 1105 RVA: 0x000157BE File Offset: 0x000147BE
		protected BaseArchiveStorage(global::ICSharpCode.SharpZipLib.Zip.FileUpdateMode updateMode)
		{
			this.updateMode_ = updateMode;
		}

		// Token: 0x06000452 RID: 1106
		public abstract global::System.IO.Stream GetTemporaryOutput();

		// Token: 0x06000453 RID: 1107
		public abstract global::System.IO.Stream ConvertTemporaryToFinal();

		// Token: 0x06000454 RID: 1108
		public abstract global::System.IO.Stream MakeTemporaryCopy(global::System.IO.Stream stream);

		// Token: 0x06000455 RID: 1109
		public abstract global::System.IO.Stream OpenForDirectUpdate(global::System.IO.Stream stream);

		// Token: 0x06000456 RID: 1110
		public abstract void Dispose();

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x06000457 RID: 1111 RVA: 0x000157CD File Offset: 0x000147CD
		public global::ICSharpCode.SharpZipLib.Zip.FileUpdateMode UpdateMode
		{
			get
			{
				return this.updateMode_;
			}
		}

		// Token: 0x040002CB RID: 715
		private global::ICSharpCode.SharpZipLib.Zip.FileUpdateMode updateMode_;
	}
}
