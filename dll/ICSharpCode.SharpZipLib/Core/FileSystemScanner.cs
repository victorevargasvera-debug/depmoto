using System;
using System.IO;

namespace ICSharpCode.SharpZipLib.Core
{
	// Token: 0x02000017 RID: 23
	public class FileSystemScanner
	{
		// Token: 0x060000AE RID: 174 RVA: 0x00006DB5 File Offset: 0x00005DB5
		public FileSystemScanner(string filter)
		{
			this.fileFilter_ = new global::ICSharpCode.SharpZipLib.Core.PathFilter(filter);
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00006DC9 File Offset: 0x00005DC9
		public FileSystemScanner(string fileFilter, string directoryFilter)
		{
			this.fileFilter_ = new global::ICSharpCode.SharpZipLib.Core.PathFilter(fileFilter);
			this.directoryFilter_ = new global::ICSharpCode.SharpZipLib.Core.PathFilter(directoryFilter);
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00006DE9 File Offset: 0x00005DE9
		public FileSystemScanner(global::ICSharpCode.SharpZipLib.Core.IScanFilter fileFilter)
		{
			this.fileFilter_ = fileFilter;
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00006DF8 File Offset: 0x00005DF8
		public FileSystemScanner(global::ICSharpCode.SharpZipLib.Core.IScanFilter fileFilter, global::ICSharpCode.SharpZipLib.Core.IScanFilter directoryFilter)
		{
			this.fileFilter_ = fileFilter;
			this.directoryFilter_ = directoryFilter;
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00006E10 File Offset: 0x00005E10
		private bool OnDirectoryFailure(string directory, global::System.Exception e)
		{
			global::ICSharpCode.SharpZipLib.Core.DirectoryFailureHandler directoryFailure = this.DirectoryFailure;
			bool flag = directoryFailure != null;
			if (flag)
			{
				global::ICSharpCode.SharpZipLib.Core.ScanFailureEventArgs scanFailureEventArgs = new global::ICSharpCode.SharpZipLib.Core.ScanFailureEventArgs(directory, e);
				directoryFailure(this, scanFailureEventArgs);
				this.alive_ = scanFailureEventArgs.ContinueRunning;
			}
			return flag;
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00006E4C File Offset: 0x00005E4C
		private bool OnFileFailure(string file, global::System.Exception e)
		{
			global::ICSharpCode.SharpZipLib.Core.FileFailureHandler fileFailure = this.FileFailure;
			bool flag = fileFailure != null;
			if (flag)
			{
				global::ICSharpCode.SharpZipLib.Core.ScanFailureEventArgs scanFailureEventArgs = new global::ICSharpCode.SharpZipLib.Core.ScanFailureEventArgs(file, e);
				this.FileFailure(this, scanFailureEventArgs);
				this.alive_ = scanFailureEventArgs.ContinueRunning;
			}
			return flag;
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00006E90 File Offset: 0x00005E90
		private void OnProcessFile(string file)
		{
			global::ICSharpCode.SharpZipLib.Core.ProcessFileHandler processFile = this.ProcessFile;
			if (processFile != null)
			{
				global::ICSharpCode.SharpZipLib.Core.ScanEventArgs scanEventArgs = new global::ICSharpCode.SharpZipLib.Core.ScanEventArgs(file);
				processFile(this, scanEventArgs);
				this.alive_ = scanEventArgs.ContinueRunning;
			}
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00006EC4 File Offset: 0x00005EC4
		private void OnCompleteFile(string file)
		{
			global::ICSharpCode.SharpZipLib.Core.CompletedFileHandler completedFile = this.CompletedFile;
			if (completedFile != null)
			{
				global::ICSharpCode.SharpZipLib.Core.ScanEventArgs scanEventArgs = new global::ICSharpCode.SharpZipLib.Core.ScanEventArgs(file);
				completedFile(this, scanEventArgs);
				this.alive_ = scanEventArgs.ContinueRunning;
			}
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00006EF8 File Offset: 0x00005EF8
		private void OnProcessDirectory(string directory, bool hasMatchingFiles)
		{
			global::ICSharpCode.SharpZipLib.Core.ProcessDirectoryHandler processDirectory = this.ProcessDirectory;
			if (processDirectory != null)
			{
				global::ICSharpCode.SharpZipLib.Core.DirectoryEventArgs directoryEventArgs = new global::ICSharpCode.SharpZipLib.Core.DirectoryEventArgs(directory, hasMatchingFiles);
				processDirectory(this, directoryEventArgs);
				this.alive_ = directoryEventArgs.ContinueRunning;
			}
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00006F2B File Offset: 0x00005F2B
		public void Scan(string directory, bool recurse)
		{
			this.alive_ = true;
			this.ScanDir(directory, recurse);
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00006F3C File Offset: 0x00005F3C
		private void ScanDir(string directory, bool recurse)
		{
			try
			{
				string[] files = global::System.IO.Directory.GetFiles(directory);
				bool flag = false;
				for (int i = 0; i < files.Length; i++)
				{
					if (!this.fileFilter_.IsMatch(files[i]))
					{
						files[i] = null;
					}
					else
					{
						flag = true;
					}
				}
				this.OnProcessDirectory(directory, flag);
				if (this.alive_ && flag)
				{
					foreach (string text in files)
					{
						try
						{
							if (text != null)
							{
								this.OnProcessFile(text);
								if (!this.alive_)
								{
									break;
								}
							}
						}
						catch (global::System.Exception e)
						{
							if (!this.OnFileFailure(text, e))
							{
								throw;
							}
						}
					}
				}
			}
			catch (global::System.Exception e2)
			{
				if (!this.OnDirectoryFailure(directory, e2))
				{
					throw;
				}
			}
			if (this.alive_ && recurse)
			{
				try
				{
					string[] directories = global::System.IO.Directory.GetDirectories(directory);
					foreach (string text2 in directories)
					{
						if (this.directoryFilter_ == null || this.directoryFilter_.IsMatch(text2))
						{
							this.ScanDir(text2, true);
							if (!this.alive_)
							{
								break;
							}
						}
					}
				}
				catch (global::System.Exception e3)
				{
					if (!this.OnDirectoryFailure(directory, e3))
					{
						throw;
					}
				}
			}
		}

		// Token: 0x04000077 RID: 119
		public global::ICSharpCode.SharpZipLib.Core.ProcessDirectoryHandler ProcessDirectory;

		// Token: 0x04000078 RID: 120
		public global::ICSharpCode.SharpZipLib.Core.ProcessFileHandler ProcessFile;

		// Token: 0x04000079 RID: 121
		public global::ICSharpCode.SharpZipLib.Core.CompletedFileHandler CompletedFile;

		// Token: 0x0400007A RID: 122
		public global::ICSharpCode.SharpZipLib.Core.DirectoryFailureHandler DirectoryFailure;

		// Token: 0x0400007B RID: 123
		public global::ICSharpCode.SharpZipLib.Core.FileFailureHandler FileFailure;

		// Token: 0x0400007C RID: 124
		private global::ICSharpCode.SharpZipLib.Core.IScanFilter fileFilter_;

		// Token: 0x0400007D RID: 125
		private global::ICSharpCode.SharpZipLib.Core.IScanFilter directoryFilter_;

		// Token: 0x0400007E RID: 126
		private bool alive_;
	}
}
