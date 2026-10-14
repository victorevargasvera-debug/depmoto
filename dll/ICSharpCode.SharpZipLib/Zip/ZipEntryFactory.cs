using System;
using System.IO;
using ICSharpCode.SharpZipLib.Core;

namespace ICSharpCode.SharpZipLib.Zip
{
	// Token: 0x02000053 RID: 83
	public class ZipEntryFactory : global::ICSharpCode.SharpZipLib.Zip.IEntryFactory
	{
		// Token: 0x06000335 RID: 821 RVA: 0x00011214 File Offset: 0x00010214
		public ZipEntryFactory()
		{
			this.nameTransform_ = new global::ICSharpCode.SharpZipLib.Zip.ZipNameTransform();
		}

		// Token: 0x06000336 RID: 822 RVA: 0x00011239 File Offset: 0x00010239
		public ZipEntryFactory(global::ICSharpCode.SharpZipLib.Zip.ZipEntryFactory.TimeSetting timeSetting)
		{
			this.timeSetting_ = timeSetting;
			this.nameTransform_ = new global::ICSharpCode.SharpZipLib.Zip.ZipNameTransform();
		}

		// Token: 0x06000337 RID: 823 RVA: 0x00011265 File Offset: 0x00010265
		public ZipEntryFactory(global::System.DateTime time)
		{
			this.timeSetting_ = global::ICSharpCode.SharpZipLib.Zip.ZipEntryFactory.TimeSetting.Fixed;
			this.FixedDateTime = time;
			this.nameTransform_ = new global::ICSharpCode.SharpZipLib.Zip.ZipNameTransform();
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x06000338 RID: 824 RVA: 0x00011298 File Offset: 0x00010298
		// (set) Token: 0x06000339 RID: 825 RVA: 0x000112A0 File Offset: 0x000102A0
		public global::ICSharpCode.SharpZipLib.Core.INameTransform NameTransform
		{
			get
			{
				return this.nameTransform_;
			}
			set
			{
				if (value == null)
				{
					this.nameTransform_ = new global::ICSharpCode.SharpZipLib.Zip.ZipNameTransform();
					return;
				}
				this.nameTransform_ = value;
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x0600033A RID: 826 RVA: 0x000112B8 File Offset: 0x000102B8
		// (set) Token: 0x0600033B RID: 827 RVA: 0x000112C0 File Offset: 0x000102C0
		public global::ICSharpCode.SharpZipLib.Zip.ZipEntryFactory.TimeSetting Setting
		{
			get
			{
				return this.timeSetting_;
			}
			set
			{
				this.timeSetting_ = value;
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x0600033C RID: 828 RVA: 0x000112C9 File Offset: 0x000102C9
		// (set) Token: 0x0600033D RID: 829 RVA: 0x000112D1 File Offset: 0x000102D1
		public global::System.DateTime FixedDateTime
		{
			get
			{
				return this.fixedDateTime_;
			}
			set
			{
				if (value.Year < 1970)
				{
					throw new global::System.ArgumentException("Value is too old to be valid", "value");
				}
				this.fixedDateTime_ = value;
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x0600033E RID: 830 RVA: 0x000112F8 File Offset: 0x000102F8
		// (set) Token: 0x0600033F RID: 831 RVA: 0x00011300 File Offset: 0x00010300
		public int GetAttributes
		{
			get
			{
				return this.getAttributes_;
			}
			set
			{
				this.getAttributes_ = value;
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x06000340 RID: 832 RVA: 0x00011309 File Offset: 0x00010309
		// (set) Token: 0x06000341 RID: 833 RVA: 0x00011311 File Offset: 0x00010311
		public int SetAttributes
		{
			get
			{
				return this.setAttributes_;
			}
			set
			{
				this.setAttributes_ = value;
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x06000342 RID: 834 RVA: 0x0001131A File Offset: 0x0001031A
		// (set) Token: 0x06000343 RID: 835 RVA: 0x00011322 File Offset: 0x00010322
		public bool IsUnicodeText
		{
			get
			{
				return this.isUnicodeText_;
			}
			set
			{
				this.isUnicodeText_ = value;
			}
		}

		// Token: 0x06000344 RID: 836 RVA: 0x0001132B File Offset: 0x0001032B
		public global::ICSharpCode.SharpZipLib.Zip.ZipEntry MakeFileEntry(string fileName)
		{
			return this.MakeFileEntry(fileName, true);
		}

		// Token: 0x06000345 RID: 837 RVA: 0x00011338 File Offset: 0x00010338
		public global::ICSharpCode.SharpZipLib.Zip.ZipEntry MakeFileEntry(string fileName, bool useFileSystem)
		{
			global::ICSharpCode.SharpZipLib.Zip.ZipEntry zipEntry = new global::ICSharpCode.SharpZipLib.Zip.ZipEntry(this.nameTransform_.TransformFile(fileName));
			zipEntry.IsUnicodeText = this.isUnicodeText_;
			int num = 0;
			bool flag = this.setAttributes_ != 0;
			global::System.IO.FileInfo fileInfo = null;
			if (useFileSystem)
			{
				fileInfo = new global::System.IO.FileInfo(fileName);
			}
			if (fileInfo != null && fileInfo.Exists)
			{
				switch (this.timeSetting_)
				{
				case global::ICSharpCode.SharpZipLib.Zip.ZipEntryFactory.TimeSetting.LastWriteTime:
					zipEntry.DateTime = fileInfo.LastWriteTime;
					break;
				case global::ICSharpCode.SharpZipLib.Zip.ZipEntryFactory.TimeSetting.LastWriteTimeUtc:
					zipEntry.DateTime = fileInfo.LastWriteTimeUtc;
					break;
				case global::ICSharpCode.SharpZipLib.Zip.ZipEntryFactory.TimeSetting.CreateTime:
					zipEntry.DateTime = fileInfo.CreationTime;
					break;
				case global::ICSharpCode.SharpZipLib.Zip.ZipEntryFactory.TimeSetting.CreateTimeUtc:
					zipEntry.DateTime = fileInfo.CreationTimeUtc;
					break;
				case global::ICSharpCode.SharpZipLib.Zip.ZipEntryFactory.TimeSetting.LastAccessTime:
					zipEntry.DateTime = fileInfo.LastAccessTime;
					break;
				case global::ICSharpCode.SharpZipLib.Zip.ZipEntryFactory.TimeSetting.LastAccessTimeUtc:
					zipEntry.DateTime = fileInfo.LastAccessTimeUtc;
					break;
				case global::ICSharpCode.SharpZipLib.Zip.ZipEntryFactory.TimeSetting.Fixed:
					zipEntry.DateTime = this.fixedDateTime_;
					break;
				default:
					throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Unhandled time setting in MakeFileEntry");
				}
				zipEntry.Size = fileInfo.Length;
				flag = true;
				num = (int)(fileInfo.Attributes & (global::System.IO.FileAttributes)this.getAttributes_);
			}
			else if (this.timeSetting_ == global::ICSharpCode.SharpZipLib.Zip.ZipEntryFactory.TimeSetting.Fixed)
			{
				zipEntry.DateTime = this.fixedDateTime_;
			}
			if (flag)
			{
				num |= this.setAttributes_;
				zipEntry.ExternalFileAttributes = num;
			}
			return zipEntry;
		}

		// Token: 0x06000346 RID: 838 RVA: 0x00011470 File Offset: 0x00010470
		public global::ICSharpCode.SharpZipLib.Zip.ZipEntry MakeDirectoryEntry(string directoryName)
		{
			return this.MakeDirectoryEntry(directoryName, true);
		}

		// Token: 0x06000347 RID: 839 RVA: 0x0001147C File Offset: 0x0001047C
		public global::ICSharpCode.SharpZipLib.Zip.ZipEntry MakeDirectoryEntry(string directoryName, bool useFileSystem)
		{
			global::ICSharpCode.SharpZipLib.Zip.ZipEntry zipEntry = new global::ICSharpCode.SharpZipLib.Zip.ZipEntry(this.nameTransform_.TransformDirectory(directoryName));
			zipEntry.Size = 0L;
			int num = 0;
			global::System.IO.DirectoryInfo directoryInfo = null;
			if (useFileSystem)
			{
				directoryInfo = new global::System.IO.DirectoryInfo(directoryName);
			}
			if (directoryInfo != null && directoryInfo.Exists)
			{
				switch (this.timeSetting_)
				{
				case global::ICSharpCode.SharpZipLib.Zip.ZipEntryFactory.TimeSetting.LastWriteTime:
					zipEntry.DateTime = directoryInfo.LastWriteTime;
					break;
				case global::ICSharpCode.SharpZipLib.Zip.ZipEntryFactory.TimeSetting.LastWriteTimeUtc:
					zipEntry.DateTime = directoryInfo.LastWriteTimeUtc;
					break;
				case global::ICSharpCode.SharpZipLib.Zip.ZipEntryFactory.TimeSetting.CreateTime:
					zipEntry.DateTime = directoryInfo.CreationTime;
					break;
				case global::ICSharpCode.SharpZipLib.Zip.ZipEntryFactory.TimeSetting.CreateTimeUtc:
					zipEntry.DateTime = directoryInfo.CreationTimeUtc;
					break;
				case global::ICSharpCode.SharpZipLib.Zip.ZipEntryFactory.TimeSetting.LastAccessTime:
					zipEntry.DateTime = directoryInfo.LastAccessTime;
					break;
				case global::ICSharpCode.SharpZipLib.Zip.ZipEntryFactory.TimeSetting.LastAccessTimeUtc:
					zipEntry.DateTime = directoryInfo.LastAccessTimeUtc;
					break;
				case global::ICSharpCode.SharpZipLib.Zip.ZipEntryFactory.TimeSetting.Fixed:
					zipEntry.DateTime = this.fixedDateTime_;
					break;
				default:
					throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Unhandled time setting in MakeDirectoryEntry");
				}
				num = (int)(directoryInfo.Attributes & (global::System.IO.FileAttributes)this.getAttributes_);
			}
			else if (this.timeSetting_ == global::ICSharpCode.SharpZipLib.Zip.ZipEntryFactory.TimeSetting.Fixed)
			{
				zipEntry.DateTime = this.fixedDateTime_;
			}
			num |= (this.setAttributes_ | 16);
			zipEntry.ExternalFileAttributes = num;
			return zipEntry;
		}

		// Token: 0x04000264 RID: 612
		private global::ICSharpCode.SharpZipLib.Core.INameTransform nameTransform_;

		// Token: 0x04000265 RID: 613
		private global::System.DateTime fixedDateTime_ = global::System.DateTime.Now;

		// Token: 0x04000266 RID: 614
		private global::ICSharpCode.SharpZipLib.Zip.ZipEntryFactory.TimeSetting timeSetting_;

		// Token: 0x04000267 RID: 615
		private bool isUnicodeText_;

		// Token: 0x04000268 RID: 616
		private int getAttributes_ = -1;

		// Token: 0x04000269 RID: 617
		private int setAttributes_;

		// Token: 0x02000054 RID: 84
		public enum TimeSetting
		{
			// Token: 0x0400026B RID: 619
			LastWriteTime,
			// Token: 0x0400026C RID: 620
			LastWriteTimeUtc,
			// Token: 0x0400026D RID: 621
			CreateTime,
			// Token: 0x0400026E RID: 622
			CreateTimeUtc,
			// Token: 0x0400026F RID: 623
			LastAccessTime,
			// Token: 0x04000270 RID: 624
			LastAccessTimeUtc,
			// Token: 0x04000271 RID: 625
			Fixed
		}
	}
}
