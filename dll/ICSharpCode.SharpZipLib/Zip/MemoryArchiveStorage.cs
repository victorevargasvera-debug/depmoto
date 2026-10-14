using System;
using System.IO;
using ICSharpCode.SharpZipLib.Core;

namespace ICSharpCode.SharpZipLib.Zip
{
	// Token: 0x02000074 RID: 116
	public class MemoryArchiveStorage : global::ICSharpCode.SharpZipLib.Zip.BaseArchiveStorage
	{
		// Token: 0x06000460 RID: 1120 RVA: 0x00015A44 File Offset: 0x00014A44
		public MemoryArchiveStorage() : base(global::ICSharpCode.SharpZipLib.Zip.FileUpdateMode.Direct)
		{
		}

		// Token: 0x06000461 RID: 1121 RVA: 0x00015A4D File Offset: 0x00014A4D
		public MemoryArchiveStorage(global::ICSharpCode.SharpZipLib.Zip.FileUpdateMode updateMode) : base(updateMode)
		{
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x06000462 RID: 1122 RVA: 0x00015A56 File Offset: 0x00014A56
		public global::System.IO.MemoryStream FinalStream
		{
			get
			{
				return this.finalStream_;
			}
		}

		// Token: 0x06000463 RID: 1123 RVA: 0x00015A5E File Offset: 0x00014A5E
		public override global::System.IO.Stream GetTemporaryOutput()
		{
			this.temporaryStream_ = new global::System.IO.MemoryStream();
			return this.temporaryStream_;
		}

		// Token: 0x06000464 RID: 1124 RVA: 0x00015A71 File Offset: 0x00014A71
		public override global::System.IO.Stream ConvertTemporaryToFinal()
		{
			if (this.temporaryStream_ == null)
			{
				throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("No temporary stream has been created");
			}
			this.finalStream_ = new global::System.IO.MemoryStream(this.temporaryStream_.ToArray());
			return this.finalStream_;
		}

		// Token: 0x06000465 RID: 1125 RVA: 0x00015AA2 File Offset: 0x00014AA2
		public override global::System.IO.Stream MakeTemporaryCopy(global::System.IO.Stream stream)
		{
			this.temporaryStream_ = new global::System.IO.MemoryStream();
			stream.Position = 0L;
			global::ICSharpCode.SharpZipLib.Core.StreamUtils.Copy(stream, this.temporaryStream_, new byte[4096]);
			return this.temporaryStream_;
		}

		// Token: 0x06000466 RID: 1126 RVA: 0x00015AD4 File Offset: 0x00014AD4
		public override global::System.IO.Stream OpenForDirectUpdate(global::System.IO.Stream stream)
		{
			global::System.IO.Stream stream2;
			if (stream == null || !stream.CanWrite)
			{
				stream2 = new global::System.IO.MemoryStream();
				if (stream != null)
				{
					stream.Position = 0L;
					global::ICSharpCode.SharpZipLib.Core.StreamUtils.Copy(stream, stream2, new byte[4096]);
					stream.Close();
				}
			}
			else
			{
				stream2 = stream;
			}
			return stream2;
		}

		// Token: 0x06000467 RID: 1127 RVA: 0x00015B19 File Offset: 0x00014B19
		public override void Dispose()
		{
			if (this.temporaryStream_ != null)
			{
				this.temporaryStream_.Close();
			}
		}

		// Token: 0x040002CF RID: 719
		private global::System.IO.MemoryStream temporaryStream_;

		// Token: 0x040002D0 RID: 720
		private global::System.IO.MemoryStream finalStream_;
	}
}
