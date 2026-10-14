using System;
using System.IO;

namespace ICSharpCode.SharpZipLib.Zip
{
	// Token: 0x02000073 RID: 115
	public class DiskArchiveStorage : global::ICSharpCode.SharpZipLib.Zip.BaseArchiveStorage
	{
		// Token: 0x06000458 RID: 1112 RVA: 0x000157D5 File Offset: 0x000147D5
		public DiskArchiveStorage(global::ICSharpCode.SharpZipLib.Zip.ZipFile file, global::ICSharpCode.SharpZipLib.Zip.FileUpdateMode updateMode) : base(updateMode)
		{
			if (file.Name == null)
			{
				throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Cant handle non file archives");
			}
			this.fileName_ = file.Name;
		}

		// Token: 0x06000459 RID: 1113 RVA: 0x000157FD File Offset: 0x000147FD
		public DiskArchiveStorage(global::ICSharpCode.SharpZipLib.Zip.ZipFile file) : this(file, global::ICSharpCode.SharpZipLib.Zip.FileUpdateMode.Safe)
		{
		}

		// Token: 0x0600045A RID: 1114 RVA: 0x00015808 File Offset: 0x00014808
		public override global::System.IO.Stream GetTemporaryOutput()
		{
			if (this.temporaryName_ != null)
			{
				this.temporaryName_ = global::ICSharpCode.SharpZipLib.Zip.DiskArchiveStorage.GetTempFileName(this.temporaryName_, true);
				this.temporaryStream_ = global::System.IO.File.OpenWrite(this.temporaryName_);
			}
			else
			{
				this.temporaryName_ = global::System.IO.Path.GetTempFileName();
				this.temporaryStream_ = global::System.IO.File.OpenWrite(this.temporaryName_);
			}
			return this.temporaryStream_;
		}

		// Token: 0x0600045B RID: 1115 RVA: 0x00015864 File Offset: 0x00014864
		public override global::System.IO.Stream ConvertTemporaryToFinal()
		{
			if (this.temporaryStream_ == null)
			{
				throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("No temporary stream has been created");
			}
			global::System.IO.Stream result = null;
			string tempFileName = global::ICSharpCode.SharpZipLib.Zip.DiskArchiveStorage.GetTempFileName(this.fileName_, false);
			bool flag = false;
			try
			{
				this.temporaryStream_.Close();
				global::System.IO.File.Move(this.fileName_, tempFileName);
				global::System.IO.File.Move(this.temporaryName_, this.fileName_);
				flag = true;
				global::System.IO.File.Delete(tempFileName);
				result = global::System.IO.File.OpenRead(this.fileName_);
			}
			catch (global::System.Exception)
			{
				result = null;
				if (!flag)
				{
					global::System.IO.File.Move(tempFileName, this.fileName_);
					global::System.IO.File.Delete(this.temporaryName_);
				}
				throw;
			}
			return result;
		}

		// Token: 0x0600045C RID: 1116 RVA: 0x00015904 File Offset: 0x00014904
		public override global::System.IO.Stream MakeTemporaryCopy(global::System.IO.Stream stream)
		{
			stream.Close();
			this.temporaryName_ = global::ICSharpCode.SharpZipLib.Zip.DiskArchiveStorage.GetTempFileName(this.fileName_, true);
			global::System.IO.File.Copy(this.fileName_, this.temporaryName_, true);
			this.temporaryStream_ = new global::System.IO.FileStream(this.temporaryName_, global::System.IO.FileMode.Open, global::System.IO.FileAccess.ReadWrite);
			return this.temporaryStream_;
		}

		// Token: 0x0600045D RID: 1117 RVA: 0x00015954 File Offset: 0x00014954
		public override global::System.IO.Stream OpenForDirectUpdate(global::System.IO.Stream stream)
		{
			global::System.IO.Stream result;
			if (stream == null || !stream.CanWrite)
			{
				if (stream != null)
				{
					stream.Close();
				}
				result = new global::System.IO.FileStream(this.fileName_, global::System.IO.FileMode.Open, global::System.IO.FileAccess.ReadWrite);
			}
			else
			{
				result = stream;
			}
			return result;
		}

		// Token: 0x0600045E RID: 1118 RVA: 0x00015988 File Offset: 0x00014988
		public override void Dispose()
		{
			if (this.temporaryStream_ != null)
			{
				this.temporaryStream_.Close();
			}
		}

		// Token: 0x0600045F RID: 1119 RVA: 0x000159A0 File Offset: 0x000149A0
		private static string GetTempFileName(string original, bool makeTempFile)
		{
			string text = null;
			if (original == null)
			{
				text = global::System.IO.Path.GetTempFileName();
			}
			else
			{
				int num = 0;
				int second = global::System.DateTime.Now.Second;
				while (text == null)
				{
					num++;
					string text2 = string.Format("{0}.{1}{2}.tmp", original, second, num);
					if (!global::System.IO.File.Exists(text2))
					{
						if (makeTempFile)
						{
							try
							{
								using (global::System.IO.File.Create(text2))
								{
								}
								text = text2;
								continue;
							}
							catch
							{
								second = global::System.DateTime.Now.Second;
								continue;
							}
						}
						text = text2;
					}
				}
			}
			return text;
		}

		// Token: 0x040002CC RID: 716
		private global::System.IO.Stream temporaryStream_;

		// Token: 0x040002CD RID: 717
		private string fileName_;

		// Token: 0x040002CE RID: 718
		private string temporaryName_;
	}
}
