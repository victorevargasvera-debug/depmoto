using System;
using System.Collections;
using System.IO;
using ICSharpCode.SharpZipLib.Core;

namespace ICSharpCode.SharpZipLib.Zip
{
	// Token: 0x02000046 RID: 70
	public class FastZip
	{
		// Token: 0x060002C1 RID: 705 RVA: 0x0000FBBA File Offset: 0x0000EBBA
		public FastZip()
		{
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x0000FBD4 File Offset: 0x0000EBD4
		public FastZip(global::ICSharpCode.SharpZipLib.Zip.FastZipEvents events)
		{
			this.events_ = events;
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x060002C3 RID: 707 RVA: 0x0000FBF5 File Offset: 0x0000EBF5
		// (set) Token: 0x060002C4 RID: 708 RVA: 0x0000FBFD File Offset: 0x0000EBFD
		public bool CreateEmptyDirectories
		{
			get
			{
				return this.createEmptyDirectories_;
			}
			set
			{
				this.createEmptyDirectories_ = value;
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x060002C5 RID: 709 RVA: 0x0000FC06 File Offset: 0x0000EC06
		// (set) Token: 0x060002C6 RID: 710 RVA: 0x0000FC0E File Offset: 0x0000EC0E
		public string Password
		{
			get
			{
				return this.password_;
			}
			set
			{
				this.password_ = value;
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x060002C7 RID: 711 RVA: 0x0000FC17 File Offset: 0x0000EC17
		// (set) Token: 0x060002C8 RID: 712 RVA: 0x0000FC24 File Offset: 0x0000EC24
		public global::ICSharpCode.SharpZipLib.Core.INameTransform NameTransform
		{
			get
			{
				return this.entryFactory_.NameTransform;
			}
			set
			{
				this.entryFactory_.NameTransform = value;
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x060002C9 RID: 713 RVA: 0x0000FC32 File Offset: 0x0000EC32
		// (set) Token: 0x060002CA RID: 714 RVA: 0x0000FC3A File Offset: 0x0000EC3A
		public global::ICSharpCode.SharpZipLib.Zip.IEntryFactory EntryFactory
		{
			get
			{
				return this.entryFactory_;
			}
			set
			{
				if (value == null)
				{
					this.entryFactory_ = new global::ICSharpCode.SharpZipLib.Zip.ZipEntryFactory();
					return;
				}
				this.entryFactory_ = value;
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x060002CB RID: 715 RVA: 0x0000FC52 File Offset: 0x0000EC52
		// (set) Token: 0x060002CC RID: 716 RVA: 0x0000FC5A File Offset: 0x0000EC5A
		public global::ICSharpCode.SharpZipLib.Zip.UseZip64 UseZip64
		{
			get
			{
				return this.useZip64_;
			}
			set
			{
				this.useZip64_ = value;
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x060002CD RID: 717 RVA: 0x0000FC63 File Offset: 0x0000EC63
		// (set) Token: 0x060002CE RID: 718 RVA: 0x0000FC6B File Offset: 0x0000EC6B
		public bool RestoreDateTimeOnExtract
		{
			get
			{
				return this.restoreDateTimeOnExtract_;
			}
			set
			{
				this.restoreDateTimeOnExtract_ = value;
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x060002CF RID: 719 RVA: 0x0000FC74 File Offset: 0x0000EC74
		// (set) Token: 0x060002D0 RID: 720 RVA: 0x0000FC7C File Offset: 0x0000EC7C
		public bool RestoreAttributesOnExtract
		{
			get
			{
				return this.restoreAttributesOnExtract_;
			}
			set
			{
				this.restoreAttributesOnExtract_ = value;
			}
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x0000FC85 File Offset: 0x0000EC85
		public void CreateZip(string zipFileName, string sourceDirectory, bool recurse, string fileFilter, string directoryFilter)
		{
			this.CreateZip(global::System.IO.File.Create(zipFileName), sourceDirectory, recurse, fileFilter, directoryFilter);
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x0000FC99 File Offset: 0x0000EC99
		public void CreateZip(string zipFileName, string sourceDirectory, bool recurse, string fileFilter)
		{
			this.CreateZip(global::System.IO.File.Create(zipFileName), sourceDirectory, recurse, fileFilter, null);
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x0000FCAC File Offset: 0x0000ECAC
		public void CreateZip(global::System.IO.Stream outputStream, string sourceDirectory, bool recurse, string fileFilter, string directoryFilter)
		{
			this.NameTransform = new global::ICSharpCode.SharpZipLib.Zip.ZipNameTransform(sourceDirectory);
			this.sourceDirectory_ = sourceDirectory;
			using (this.outputStream_ = new global::ICSharpCode.SharpZipLib.Zip.ZipOutputStream(outputStream))
			{
				if (this.password_ != null)
				{
					this.outputStream_.Password = this.password_;
				}
				this.outputStream_.UseZip64 = this.UseZip64;
				global::ICSharpCode.SharpZipLib.Core.FileSystemScanner fileSystemScanner = new global::ICSharpCode.SharpZipLib.Core.FileSystemScanner(fileFilter, directoryFilter);
				global::ICSharpCode.SharpZipLib.Core.FileSystemScanner fileSystemScanner2 = fileSystemScanner;
				fileSystemScanner2.ProcessFile = (global::ICSharpCode.SharpZipLib.Core.ProcessFileHandler)global::System.Delegate.Combine(fileSystemScanner2.ProcessFile, new global::ICSharpCode.SharpZipLib.Core.ProcessFileHandler(this.ProcessFile));
				if (this.CreateEmptyDirectories)
				{
					global::ICSharpCode.SharpZipLib.Core.FileSystemScanner fileSystemScanner3 = fileSystemScanner;
					fileSystemScanner3.ProcessDirectory = (global::ICSharpCode.SharpZipLib.Core.ProcessDirectoryHandler)global::System.Delegate.Combine(fileSystemScanner3.ProcessDirectory, new global::ICSharpCode.SharpZipLib.Core.ProcessDirectoryHandler(this.ProcessDirectory));
				}
				if (this.events_ != null)
				{
					if (this.events_.FileFailure != null)
					{
						global::ICSharpCode.SharpZipLib.Core.FileSystemScanner fileSystemScanner4 = fileSystemScanner;
						fileSystemScanner4.FileFailure = (global::ICSharpCode.SharpZipLib.Core.FileFailureHandler)global::System.Delegate.Combine(fileSystemScanner4.FileFailure, this.events_.FileFailure);
					}
					if (this.events_.DirectoryFailure != null)
					{
						global::ICSharpCode.SharpZipLib.Core.FileSystemScanner fileSystemScanner5 = fileSystemScanner;
						fileSystemScanner5.DirectoryFailure = (global::ICSharpCode.SharpZipLib.Core.DirectoryFailureHandler)global::System.Delegate.Combine(fileSystemScanner5.DirectoryFailure, this.events_.DirectoryFailure);
					}
				}
				fileSystemScanner.Scan(sourceDirectory, recurse);
			}
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x0000FDE4 File Offset: 0x0000EDE4
		public void ExtractZip(string zipFileName, string targetDirectory, string fileFilter)
		{
			this.ExtractZip(zipFileName, targetDirectory, global::ICSharpCode.SharpZipLib.Zip.FastZip.Overwrite.Always, null, fileFilter, null, this.restoreDateTimeOnExtract_);
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x0000FDF8 File Offset: 0x0000EDF8
		public void ExtractZip(string zipFileName, string targetDirectory, global::ICSharpCode.SharpZipLib.Zip.FastZip.Overwrite overwrite, global::ICSharpCode.SharpZipLib.Zip.FastZip.ConfirmOverwriteDelegate confirmDelegate, string fileFilter, string directoryFilter, bool restoreDateTime)
		{
			if (overwrite == global::ICSharpCode.SharpZipLib.Zip.FastZip.Overwrite.Prompt && confirmDelegate == null)
			{
				throw new global::System.ArgumentNullException("confirmDelegate");
			}
			this.continueRunning_ = true;
			this.overwrite_ = overwrite;
			this.confirmDelegate_ = confirmDelegate;
			this.extractNameTransform_ = new global::ICSharpCode.SharpZipLib.Zip.WindowsNameTransform(targetDirectory);
			this.fileFilter_ = new global::ICSharpCode.SharpZipLib.Core.NameFilter(fileFilter);
			this.directoryFilter_ = new global::ICSharpCode.SharpZipLib.Core.NameFilter(directoryFilter);
			this.restoreDateTimeOnExtract_ = restoreDateTime;
			using (this.zipFile_ = new global::ICSharpCode.SharpZipLib.Zip.ZipFile(zipFileName))
			{
				if (this.password_ != null)
				{
					this.zipFile_.Password = this.password_;
				}
				global::System.Collections.IEnumerator enumerator = this.zipFile_.GetEnumerator();
				while (this.continueRunning_ && enumerator.MoveNext())
				{
					global::ICSharpCode.SharpZipLib.Zip.ZipEntry zipEntry = (global::ICSharpCode.SharpZipLib.Zip.ZipEntry)enumerator.Current;
					if (zipEntry.IsFile)
					{
						if (this.directoryFilter_.IsMatch(global::System.IO.Path.GetDirectoryName(zipEntry.Name)) && this.fileFilter_.IsMatch(zipEntry.Name))
						{
							this.ExtractEntry(zipEntry);
						}
					}
					else if (zipEntry.IsDirectory && this.directoryFilter_.IsMatch(zipEntry.Name) && this.CreateEmptyDirectories)
					{
						this.ExtractEntry(zipEntry);
					}
				}
			}
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x0000FF34 File Offset: 0x0000EF34
		private void ProcessDirectory(object sender, global::ICSharpCode.SharpZipLib.Core.DirectoryEventArgs e)
		{
			if (!e.HasMatchingFiles && this.CreateEmptyDirectories)
			{
				if (this.events_ != null)
				{
					this.events_.OnProcessDirectory(e.Name, e.HasMatchingFiles);
				}
				if (e.ContinueRunning && e.Name != this.sourceDirectory_)
				{
					global::ICSharpCode.SharpZipLib.Zip.ZipEntry entry = this.entryFactory_.MakeDirectoryEntry(e.Name);
					this.outputStream_.PutNextEntry(entry);
				}
			}
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x0000FFAC File Offset: 0x0000EFAC
		private void ProcessFile(object sender, global::ICSharpCode.SharpZipLib.Core.ScanEventArgs e)
		{
			if (this.events_ != null && this.events_.ProcessFile != null)
			{
				this.events_.ProcessFile(sender, e);
			}
			if (e.ContinueRunning)
			{
				using (global::System.IO.FileStream fileStream = global::System.IO.File.OpenRead(e.Name))
				{
					global::ICSharpCode.SharpZipLib.Zip.ZipEntry entry = this.entryFactory_.MakeFileEntry(e.Name);
					this.outputStream_.PutNextEntry(entry);
					this.AddFileContents(e.Name, fileStream);
				}
			}
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x0001003C File Offset: 0x0000F03C
		private void AddFileContents(string name, global::System.IO.Stream stream)
		{
			if (stream == null)
			{
				throw new global::System.ArgumentNullException("stream");
			}
			if (this.buffer_ == null)
			{
				this.buffer_ = new byte[4096];
			}
			if (this.events_ != null && this.events_.Progress != null)
			{
				global::ICSharpCode.SharpZipLib.Core.StreamUtils.Copy(stream, this.outputStream_, this.buffer_, this.events_.Progress, this.events_.ProgressInterval, this, name);
			}
			else
			{
				global::ICSharpCode.SharpZipLib.Core.StreamUtils.Copy(stream, this.outputStream_, this.buffer_);
			}
			if (this.events_ != null)
			{
				this.continueRunning_ = this.events_.OnCompletedFile(name);
			}
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x000100DC File Offset: 0x0000F0DC
		private void ExtractFileEntry(global::ICSharpCode.SharpZipLib.Zip.ZipEntry entry, string targetName)
		{
			bool flag = true;
			if (this.overwrite_ != global::ICSharpCode.SharpZipLib.Zip.FastZip.Overwrite.Always && global::System.IO.File.Exists(targetName))
			{
				flag = (this.overwrite_ == global::ICSharpCode.SharpZipLib.Zip.FastZip.Overwrite.Prompt && this.confirmDelegate_ != null && this.confirmDelegate_(targetName));
			}
			if (flag)
			{
				if (this.events_ != null)
				{
					this.continueRunning_ = this.events_.OnProcessFile(entry.Name);
				}
				if (this.continueRunning_)
				{
					try
					{
						using (global::System.IO.FileStream fileStream = global::System.IO.File.Create(targetName))
						{
							if (this.buffer_ == null)
							{
								this.buffer_ = new byte[4096];
							}
							if (this.events_ != null && this.events_.Progress != null)
							{
								global::ICSharpCode.SharpZipLib.Core.StreamUtils.Copy(this.zipFile_.GetInputStream(entry), fileStream, this.buffer_, this.events_.Progress, this.events_.ProgressInterval, this, entry.Name, entry.Size);
							}
							else
							{
								global::ICSharpCode.SharpZipLib.Core.StreamUtils.Copy(this.zipFile_.GetInputStream(entry), fileStream, this.buffer_);
							}
							if (this.events_ != null)
							{
								this.continueRunning_ = this.events_.OnCompletedFile(entry.Name);
							}
						}
						if (this.restoreDateTimeOnExtract_)
						{
							global::System.IO.File.SetLastWriteTime(targetName, entry.DateTime);
						}
						if (this.RestoreAttributesOnExtract && entry.IsDOSEntry && entry.ExternalFileAttributes != -1)
						{
							global::System.IO.FileAttributes fileAttributes = (global::System.IO.FileAttributes)entry.ExternalFileAttributes;
							fileAttributes &= (global::System.IO.FileAttributes.ReadOnly | global::System.IO.FileAttributes.Hidden | global::System.IO.FileAttributes.Archive | global::System.IO.FileAttributes.Normal);
							global::System.IO.File.SetAttributes(targetName, fileAttributes);
						}
					}
					catch (global::System.Exception e)
					{
						if (this.events_ == null)
						{
							this.continueRunning_ = false;
							throw;
						}
						this.continueRunning_ = this.events_.OnFileFailure(targetName, e);
					}
				}
			}
		}

		// Token: 0x060002DA RID: 730 RVA: 0x0001028C File Offset: 0x0000F28C
		private void ExtractEntry(global::ICSharpCode.SharpZipLib.Zip.ZipEntry entry)
		{
			bool flag = entry.IsCompressionMethodSupported();
			string text = entry.Name;
			if (flag)
			{
				if (entry.IsFile)
				{
					text = this.extractNameTransform_.TransformFile(text);
				}
				else if (entry.IsDirectory)
				{
					text = this.extractNameTransform_.TransformDirectory(text);
				}
				flag = (text != null && text.Length != 0);
			}
			string path = null;
			if (flag)
			{
				if (entry.IsDirectory)
				{
					path = text;
				}
				else
				{
					path = global::System.IO.Path.GetDirectoryName(global::System.IO.Path.GetFullPath(text));
				}
			}
			if (flag && !global::System.IO.Directory.Exists(path))
			{
				if (entry.IsDirectory)
				{
					if (!this.CreateEmptyDirectories)
					{
						goto IL_D9;
					}
				}
				try
				{
					global::System.IO.Directory.CreateDirectory(path);
				}
				catch (global::System.Exception e)
				{
					flag = false;
					if (this.events_ == null)
					{
						this.continueRunning_ = false;
						throw;
					}
					if (entry.IsDirectory)
					{
						this.continueRunning_ = this.events_.OnDirectoryFailure(text, e);
					}
					else
					{
						this.continueRunning_ = this.events_.OnFileFailure(text, e);
					}
				}
			}
			IL_D9:
			if (flag && entry.IsFile)
			{
				this.ExtractFileEntry(entry, text);
			}
		}

		// Token: 0x060002DB RID: 731 RVA: 0x00010398 File Offset: 0x0000F398
		private static int MakeExternalAttributes(global::System.IO.FileInfo info)
		{
			return (int)info.Attributes;
		}

		// Token: 0x060002DC RID: 732 RVA: 0x000103A0 File Offset: 0x0000F3A0
		private static bool NameIsValid(string name)
		{
			return name != null && name.Length > 0 && name.IndexOfAny(global::System.IO.Path.GetInvalidPathChars()) < 0;
		}

		// Token: 0x040001D0 RID: 464
		private bool continueRunning_;

		// Token: 0x040001D1 RID: 465
		private byte[] buffer_;

		// Token: 0x040001D2 RID: 466
		private global::ICSharpCode.SharpZipLib.Zip.ZipOutputStream outputStream_;

		// Token: 0x040001D3 RID: 467
		private global::ICSharpCode.SharpZipLib.Zip.ZipFile zipFile_;

		// Token: 0x040001D4 RID: 468
		private string sourceDirectory_;

		// Token: 0x040001D5 RID: 469
		private global::ICSharpCode.SharpZipLib.Core.NameFilter fileFilter_;

		// Token: 0x040001D6 RID: 470
		private global::ICSharpCode.SharpZipLib.Core.NameFilter directoryFilter_;

		// Token: 0x040001D7 RID: 471
		private global::ICSharpCode.SharpZipLib.Zip.FastZip.Overwrite overwrite_;

		// Token: 0x040001D8 RID: 472
		private global::ICSharpCode.SharpZipLib.Zip.FastZip.ConfirmOverwriteDelegate confirmDelegate_;

		// Token: 0x040001D9 RID: 473
		private bool restoreDateTimeOnExtract_;

		// Token: 0x040001DA RID: 474
		private bool restoreAttributesOnExtract_;

		// Token: 0x040001DB RID: 475
		private bool createEmptyDirectories_;

		// Token: 0x040001DC RID: 476
		private global::ICSharpCode.SharpZipLib.Zip.FastZipEvents events_;

		// Token: 0x040001DD RID: 477
		private global::ICSharpCode.SharpZipLib.Zip.IEntryFactory entryFactory_ = new global::ICSharpCode.SharpZipLib.Zip.ZipEntryFactory();

		// Token: 0x040001DE RID: 478
		private global::ICSharpCode.SharpZipLib.Core.INameTransform extractNameTransform_;

		// Token: 0x040001DF RID: 479
		private global::ICSharpCode.SharpZipLib.Zip.UseZip64 useZip64_ = global::ICSharpCode.SharpZipLib.Zip.UseZip64.Dynamic;

		// Token: 0x040001E0 RID: 480
		private string password_;

		// Token: 0x02000047 RID: 71
		public enum Overwrite
		{
			// Token: 0x040001E2 RID: 482
			Prompt,
			// Token: 0x040001E3 RID: 483
			Never,
			// Token: 0x040001E4 RID: 484
			Always
		}

		// Token: 0x02000048 RID: 72
		// (Invoke) Token: 0x060002DE RID: 734
		public delegate bool ConfirmOverwriteDelegate(string fileName);
	}
}
