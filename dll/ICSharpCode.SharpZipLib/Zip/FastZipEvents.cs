using System;
using ICSharpCode.SharpZipLib.Core;

namespace ICSharpCode.SharpZipLib.Zip
{
	// Token: 0x02000045 RID: 69
	public class FastZipEvents
	{
		// Token: 0x060002B9 RID: 697 RVA: 0x0000FA88 File Offset: 0x0000EA88
		public bool OnDirectoryFailure(string directory, global::System.Exception e)
		{
			bool result = false;
			global::ICSharpCode.SharpZipLib.Core.DirectoryFailureHandler directoryFailure = this.DirectoryFailure;
			if (directoryFailure != null)
			{
				global::ICSharpCode.SharpZipLib.Core.ScanFailureEventArgs scanFailureEventArgs = new global::ICSharpCode.SharpZipLib.Core.ScanFailureEventArgs(directory, e);
				directoryFailure(this, scanFailureEventArgs);
				result = scanFailureEventArgs.ContinueRunning;
			}
			return result;
		}

		// Token: 0x060002BA RID: 698 RVA: 0x0000FABC File Offset: 0x0000EABC
		public bool OnFileFailure(string file, global::System.Exception e)
		{
			global::ICSharpCode.SharpZipLib.Core.FileFailureHandler fileFailure = this.FileFailure;
			bool flag = fileFailure != null;
			if (flag)
			{
				global::ICSharpCode.SharpZipLib.Core.ScanFailureEventArgs scanFailureEventArgs = new global::ICSharpCode.SharpZipLib.Core.ScanFailureEventArgs(file, e);
				fileFailure(this, scanFailureEventArgs);
				flag = scanFailureEventArgs.ContinueRunning;
			}
			return flag;
		}

		// Token: 0x060002BB RID: 699 RVA: 0x0000FAF4 File Offset: 0x0000EAF4
		public bool OnProcessFile(string file)
		{
			bool result = true;
			global::ICSharpCode.SharpZipLib.Core.ProcessFileHandler processFile = this.ProcessFile;
			if (processFile != null)
			{
				global::ICSharpCode.SharpZipLib.Core.ScanEventArgs scanEventArgs = new global::ICSharpCode.SharpZipLib.Core.ScanEventArgs(file);
				this.ProcessFile(this, scanEventArgs);
				result = scanEventArgs.ContinueRunning;
			}
			return result;
		}

		// Token: 0x060002BC RID: 700 RVA: 0x0000FB2C File Offset: 0x0000EB2C
		public bool OnCompletedFile(string file)
		{
			bool result = true;
			global::ICSharpCode.SharpZipLib.Core.CompletedFileHandler completedFile = this.CompletedFile;
			if (completedFile != null)
			{
				global::ICSharpCode.SharpZipLib.Core.ScanEventArgs scanEventArgs = new global::ICSharpCode.SharpZipLib.Core.ScanEventArgs(file);
				completedFile(this, scanEventArgs);
				result = scanEventArgs.ContinueRunning;
			}
			return result;
		}

		// Token: 0x060002BD RID: 701 RVA: 0x0000FB5C File Offset: 0x0000EB5C
		public bool OnProcessDirectory(string directory, bool hasMatchingFiles)
		{
			bool result = true;
			global::ICSharpCode.SharpZipLib.Core.ProcessDirectoryHandler processDirectory = this.ProcessDirectory;
			if (processDirectory != null)
			{
				global::ICSharpCode.SharpZipLib.Core.DirectoryEventArgs directoryEventArgs = new global::ICSharpCode.SharpZipLib.Core.DirectoryEventArgs(directory, hasMatchingFiles);
				processDirectory(this, directoryEventArgs);
				result = directoryEventArgs.ContinueRunning;
			}
			return result;
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x060002BE RID: 702 RVA: 0x0000FB8D File Offset: 0x0000EB8D
		// (set) Token: 0x060002BF RID: 703 RVA: 0x0000FB95 File Offset: 0x0000EB95
		public global::System.TimeSpan ProgressInterval
		{
			get
			{
				return this.progressInterval_;
			}
			set
			{
				this.progressInterval_ = value;
			}
		}

		// Token: 0x040001C9 RID: 457
		public global::ICSharpCode.SharpZipLib.Core.ProcessDirectoryHandler ProcessDirectory;

		// Token: 0x040001CA RID: 458
		public global::ICSharpCode.SharpZipLib.Core.ProcessFileHandler ProcessFile;

		// Token: 0x040001CB RID: 459
		public global::ICSharpCode.SharpZipLib.Core.ProgressHandler Progress;

		// Token: 0x040001CC RID: 460
		public global::ICSharpCode.SharpZipLib.Core.CompletedFileHandler CompletedFile;

		// Token: 0x040001CD RID: 461
		public global::ICSharpCode.SharpZipLib.Core.DirectoryFailureHandler DirectoryFailure;

		// Token: 0x040001CE RID: 462
		public global::ICSharpCode.SharpZipLib.Core.FileFailureHandler FileFailure;

		// Token: 0x040001CF RID: 463
		private global::System.TimeSpan progressInterval_ = global::System.TimeSpan.FromSeconds(3.0);
	}
}
