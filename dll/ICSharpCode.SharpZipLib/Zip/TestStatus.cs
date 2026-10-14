using System;

namespace ICSharpCode.SharpZipLib.Zip
{
	// Token: 0x02000060 RID: 96
	public class TestStatus
	{
		// Token: 0x06000393 RID: 915 RVA: 0x000122AA File Offset: 0x000112AA
		public TestStatus(global::ICSharpCode.SharpZipLib.Zip.ZipFile file)
		{
			this.file_ = file;
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x06000394 RID: 916 RVA: 0x000122B9 File Offset: 0x000112B9
		public global::ICSharpCode.SharpZipLib.Zip.TestOperation Operation
		{
			get
			{
				return this.operation_;
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x06000395 RID: 917 RVA: 0x000122C1 File Offset: 0x000112C1
		public global::ICSharpCode.SharpZipLib.Zip.ZipFile File
		{
			get
			{
				return this.file_;
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x06000396 RID: 918 RVA: 0x000122C9 File Offset: 0x000112C9
		public global::ICSharpCode.SharpZipLib.Zip.ZipEntry Entry
		{
			get
			{
				return this.entry_;
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x06000397 RID: 919 RVA: 0x000122D1 File Offset: 0x000112D1
		public int ErrorCount
		{
			get
			{
				return this.errorCount_;
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x06000398 RID: 920 RVA: 0x000122D9 File Offset: 0x000112D9
		public long BytesTested
		{
			get
			{
				return this.bytesTested_;
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x06000399 RID: 921 RVA: 0x000122E1 File Offset: 0x000112E1
		public bool EntryValid
		{
			get
			{
				return this.entryValid_;
			}
		}

		// Token: 0x0600039A RID: 922 RVA: 0x000122E9 File Offset: 0x000112E9
		internal void AddError()
		{
			this.errorCount_++;
			this.entryValid_ = false;
		}

		// Token: 0x0600039B RID: 923 RVA: 0x00012300 File Offset: 0x00011300
		internal void SetOperation(global::ICSharpCode.SharpZipLib.Zip.TestOperation operation)
		{
			this.operation_ = operation;
		}

		// Token: 0x0600039C RID: 924 RVA: 0x00012309 File Offset: 0x00011309
		internal void SetEntry(global::ICSharpCode.SharpZipLib.Zip.ZipEntry entry)
		{
			this.entry_ = entry;
			this.entryValid_ = true;
			this.bytesTested_ = 0L;
		}

		// Token: 0x0600039D RID: 925 RVA: 0x00012321 File Offset: 0x00011321
		internal void SetBytesTested(long value)
		{
			this.bytesTested_ = value;
		}

		// Token: 0x04000290 RID: 656
		private global::ICSharpCode.SharpZipLib.Zip.ZipFile file_;

		// Token: 0x04000291 RID: 657
		private global::ICSharpCode.SharpZipLib.Zip.ZipEntry entry_;

		// Token: 0x04000292 RID: 658
		private bool entryValid_;

		// Token: 0x04000293 RID: 659
		private int errorCount_;

		// Token: 0x04000294 RID: 660
		private long bytesTested_;

		// Token: 0x04000295 RID: 661
		private global::ICSharpCode.SharpZipLib.Zip.TestOperation operation_;
	}
}
