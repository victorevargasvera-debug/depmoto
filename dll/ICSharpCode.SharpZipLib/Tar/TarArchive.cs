using System;
using System.IO;
using System.Text;

namespace ICSharpCode.SharpZipLib.Tar
{
	// Token: 0x0200002F RID: 47
	public class TarArchive : global::System.IDisposable
	{
		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000154 RID: 340 RVA: 0x00008C7C File Offset: 0x00007C7C
		// (remove) Token: 0x06000155 RID: 341 RVA: 0x00008C95 File Offset: 0x00007C95
		public event global::ICSharpCode.SharpZipLib.Tar.ProgressMessageHandler ProgressMessageEvent;

		// Token: 0x06000156 RID: 342 RVA: 0x00008CAE File Offset: 0x00007CAE
		protected virtual void OnProgressMessageEvent(global::ICSharpCode.SharpZipLib.Tar.TarEntry entry, string message)
		{
			if (this.ProgressMessageEvent != null)
			{
				this.ProgressMessageEvent(this, entry, message);
			}
		}

		// Token: 0x06000157 RID: 343 RVA: 0x00008CC6 File Offset: 0x00007CC6
		protected TarArchive()
		{
		}

		// Token: 0x06000158 RID: 344 RVA: 0x00008CE4 File Offset: 0x00007CE4
		protected TarArchive(global::ICSharpCode.SharpZipLib.Tar.TarInputStream stream)
		{
			if (stream == null)
			{
				throw new global::System.ArgumentNullException("stream");
			}
			this.tarIn = stream;
		}

		// Token: 0x06000159 RID: 345 RVA: 0x00008D17 File Offset: 0x00007D17
		protected TarArchive(global::ICSharpCode.SharpZipLib.Tar.TarOutputStream stream)
		{
			if (stream == null)
			{
				throw new global::System.ArgumentNullException("stream");
			}
			this.tarOut = stream;
		}

		// Token: 0x0600015A RID: 346 RVA: 0x00008D4C File Offset: 0x00007D4C
		public static global::ICSharpCode.SharpZipLib.Tar.TarArchive CreateInputTarArchive(global::System.IO.Stream inputStream)
		{
			if (inputStream == null)
			{
				throw new global::System.ArgumentNullException("inputStream");
			}
			global::ICSharpCode.SharpZipLib.Tar.TarInputStream tarInputStream = inputStream as global::ICSharpCode.SharpZipLib.Tar.TarInputStream;
			if (tarInputStream != null)
			{
				return new global::ICSharpCode.SharpZipLib.Tar.TarArchive(tarInputStream);
			}
			return global::ICSharpCode.SharpZipLib.Tar.TarArchive.CreateInputTarArchive(inputStream, 20);
		}

		// Token: 0x0600015B RID: 347 RVA: 0x00008D80 File Offset: 0x00007D80
		public static global::ICSharpCode.SharpZipLib.Tar.TarArchive CreateInputTarArchive(global::System.IO.Stream inputStream, int blockFactor)
		{
			if (inputStream == null)
			{
				throw new global::System.ArgumentNullException("inputStream");
			}
			if (inputStream is global::ICSharpCode.SharpZipLib.Tar.TarInputStream)
			{
				throw new global::System.ArgumentException("TarInputStream not valid");
			}
			return new global::ICSharpCode.SharpZipLib.Tar.TarArchive(new global::ICSharpCode.SharpZipLib.Tar.TarInputStream(inputStream, blockFactor));
		}

		// Token: 0x0600015C RID: 348 RVA: 0x00008DB0 File Offset: 0x00007DB0
		public static global::ICSharpCode.SharpZipLib.Tar.TarArchive CreateOutputTarArchive(global::System.IO.Stream outputStream)
		{
			if (outputStream == null)
			{
				throw new global::System.ArgumentNullException("outputStream");
			}
			global::ICSharpCode.SharpZipLib.Tar.TarOutputStream tarOutputStream = outputStream as global::ICSharpCode.SharpZipLib.Tar.TarOutputStream;
			if (tarOutputStream != null)
			{
				return new global::ICSharpCode.SharpZipLib.Tar.TarArchive(tarOutputStream);
			}
			return global::ICSharpCode.SharpZipLib.Tar.TarArchive.CreateOutputTarArchive(outputStream, 20);
		}

		// Token: 0x0600015D RID: 349 RVA: 0x00008DE4 File Offset: 0x00007DE4
		public static global::ICSharpCode.SharpZipLib.Tar.TarArchive CreateOutputTarArchive(global::System.IO.Stream outputStream, int blockFactor)
		{
			if (outputStream == null)
			{
				throw new global::System.ArgumentNullException("outputStream");
			}
			if (outputStream is global::ICSharpCode.SharpZipLib.Tar.TarOutputStream)
			{
				throw new global::System.ArgumentException("TarOutputStream is not valid");
			}
			return new global::ICSharpCode.SharpZipLib.Tar.TarArchive(new global::ICSharpCode.SharpZipLib.Tar.TarOutputStream(outputStream, blockFactor));
		}

		// Token: 0x0600015E RID: 350 RVA: 0x00008E13 File Offset: 0x00007E13
		public void SetKeepOldFiles(bool keepOldFiles)
		{
			if (this.isDisposed)
			{
				throw new global::System.ObjectDisposedException("TarArchive");
			}
			this.keepOldFiles = keepOldFiles;
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x0600015F RID: 351 RVA: 0x00008E2F File Offset: 0x00007E2F
		// (set) Token: 0x06000160 RID: 352 RVA: 0x00008E4A File Offset: 0x00007E4A
		public bool AsciiTranslate
		{
			get
			{
				if (this.isDisposed)
				{
					throw new global::System.ObjectDisposedException("TarArchive");
				}
				return this.asciiTranslate;
			}
			set
			{
				if (this.isDisposed)
				{
					throw new global::System.ObjectDisposedException("TarArchive");
				}
				this.asciiTranslate = value;
			}
		}

		// Token: 0x06000161 RID: 353 RVA: 0x00008E66 File Offset: 0x00007E66
		[global::System.Obsolete("Use the AsciiTranslate property")]
		public void SetAsciiTranslation(bool asciiTranslate)
		{
			if (this.isDisposed)
			{
				throw new global::System.ObjectDisposedException("TarArchive");
			}
			this.asciiTranslate = asciiTranslate;
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000162 RID: 354 RVA: 0x00008E82 File Offset: 0x00007E82
		// (set) Token: 0x06000163 RID: 355 RVA: 0x00008E9D File Offset: 0x00007E9D
		public string PathPrefix
		{
			get
			{
				if (this.isDisposed)
				{
					throw new global::System.ObjectDisposedException("TarArchive");
				}
				return this.pathPrefix;
			}
			set
			{
				if (this.isDisposed)
				{
					throw new global::System.ObjectDisposedException("TarArchive");
				}
				this.pathPrefix = value;
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000164 RID: 356 RVA: 0x00008EB9 File Offset: 0x00007EB9
		// (set) Token: 0x06000165 RID: 357 RVA: 0x00008ED4 File Offset: 0x00007ED4
		public string RootPath
		{
			get
			{
				if (this.isDisposed)
				{
					throw new global::System.ObjectDisposedException("TarArchive");
				}
				return this.rootPath;
			}
			set
			{
				if (this.isDisposed)
				{
					throw new global::System.ObjectDisposedException("TarArchive");
				}
				this.rootPath = value;
			}
		}

		// Token: 0x06000166 RID: 358 RVA: 0x00008EF0 File Offset: 0x00007EF0
		public void SetUserInfo(int userId, string userName, int groupId, string groupName)
		{
			if (this.isDisposed)
			{
				throw new global::System.ObjectDisposedException("TarArchive");
			}
			this.userId = userId;
			this.userName = userName;
			this.groupId = groupId;
			this.groupName = groupName;
			this.applyUserInfoOverrides = true;
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000167 RID: 359 RVA: 0x00008F29 File Offset: 0x00007F29
		// (set) Token: 0x06000168 RID: 360 RVA: 0x00008F44 File Offset: 0x00007F44
		public bool ApplyUserInfoOverrides
		{
			get
			{
				if (this.isDisposed)
				{
					throw new global::System.ObjectDisposedException("TarArchive");
				}
				return this.applyUserInfoOverrides;
			}
			set
			{
				if (this.isDisposed)
				{
					throw new global::System.ObjectDisposedException("TarArchive");
				}
				this.applyUserInfoOverrides = value;
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000169 RID: 361 RVA: 0x00008F60 File Offset: 0x00007F60
		public int UserId
		{
			get
			{
				if (this.isDisposed)
				{
					throw new global::System.ObjectDisposedException("TarArchive");
				}
				return this.userId;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x0600016A RID: 362 RVA: 0x00008F7B File Offset: 0x00007F7B
		public string UserName
		{
			get
			{
				if (this.isDisposed)
				{
					throw new global::System.ObjectDisposedException("TarArchive");
				}
				return this.userName;
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x0600016B RID: 363 RVA: 0x00008F96 File Offset: 0x00007F96
		public int GroupId
		{
			get
			{
				if (this.isDisposed)
				{
					throw new global::System.ObjectDisposedException("TarArchive");
				}
				return this.groupId;
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x0600016C RID: 364 RVA: 0x00008FB1 File Offset: 0x00007FB1
		public string GroupName
		{
			get
			{
				if (this.isDisposed)
				{
					throw new global::System.ObjectDisposedException("TarArchive");
				}
				return this.groupName;
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x0600016D RID: 365 RVA: 0x00008FCC File Offset: 0x00007FCC
		public int RecordSize
		{
			get
			{
				if (this.isDisposed)
				{
					throw new global::System.ObjectDisposedException("TarArchive");
				}
				if (this.tarIn != null)
				{
					return this.tarIn.RecordSize;
				}
				if (this.tarOut != null)
				{
					return this.tarOut.RecordSize;
				}
				return 10240;
			}
		}

		// Token: 0x0600016E RID: 366 RVA: 0x00009019 File Offset: 0x00008019
		[global::System.Obsolete("Use Close instead")]
		public void CloseArchive()
		{
			this.Close();
		}

		// Token: 0x0600016F RID: 367 RVA: 0x00009024 File Offset: 0x00008024
		public void ListContents()
		{
			if (this.isDisposed)
			{
				throw new global::System.ObjectDisposedException("TarArchive");
			}
			for (;;)
			{
				global::ICSharpCode.SharpZipLib.Tar.TarEntry nextEntry = this.tarIn.GetNextEntry();
				if (nextEntry == null)
				{
					break;
				}
				this.OnProgressMessageEvent(nextEntry, null);
			}
		}

		// Token: 0x06000170 RID: 368 RVA: 0x00009060 File Offset: 0x00008060
		public void ExtractContents(string destinationDirectory)
		{
			if (this.isDisposed)
			{
				throw new global::System.ObjectDisposedException("TarArchive");
			}
			for (;;)
			{
				global::ICSharpCode.SharpZipLib.Tar.TarEntry nextEntry = this.tarIn.GetNextEntry();
				if (nextEntry == null)
				{
					break;
				}
				this.ExtractEntry(destinationDirectory, nextEntry);
			}
		}

		// Token: 0x06000171 RID: 369 RVA: 0x0000909C File Offset: 0x0000809C
		private void ExtractEntry(string destDir, global::ICSharpCode.SharpZipLib.Tar.TarEntry entry)
		{
			this.OnProgressMessageEvent(entry, null);
			string text = entry.Name;
			if (global::System.IO.Path.IsPathRooted(text))
			{
				text = text.Substring(global::System.IO.Path.GetPathRoot(text).Length);
			}
			text = text.Replace('/', global::System.IO.Path.DirectorySeparatorChar);
			string text2 = global::System.IO.Path.Combine(destDir, text);
			if (entry.IsDirectory)
			{
				global::ICSharpCode.SharpZipLib.Tar.TarArchive.EnsureDirectoryExists(text2);
				return;
			}
			string directoryName = global::System.IO.Path.GetDirectoryName(text2);
			global::ICSharpCode.SharpZipLib.Tar.TarArchive.EnsureDirectoryExists(directoryName);
			bool flag = true;
			global::System.IO.FileInfo fileInfo = new global::System.IO.FileInfo(text2);
			if (fileInfo.Exists)
			{
				if (this.keepOldFiles)
				{
					this.OnProgressMessageEvent(entry, "Destination file already exists");
					flag = false;
				}
				else if ((fileInfo.Attributes & global::System.IO.FileAttributes.ReadOnly) != (global::System.IO.FileAttributes)0)
				{
					this.OnProgressMessageEvent(entry, "Destination file already exists, and is read-only");
					flag = false;
				}
			}
			if (flag)
			{
				bool flag2 = false;
				global::System.IO.Stream stream = global::System.IO.File.Create(text2);
				if (this.asciiTranslate)
				{
					flag2 = !global::ICSharpCode.SharpZipLib.Tar.TarArchive.IsBinary(text2);
				}
				global::System.IO.StreamWriter streamWriter = null;
				if (flag2)
				{
					streamWriter = new global::System.IO.StreamWriter(stream);
				}
				byte[] array = new byte[32768];
				for (;;)
				{
					int num = this.tarIn.Read(array, 0, array.Length);
					if (num <= 0)
					{
						break;
					}
					if (flag2)
					{
						int num2 = 0;
						for (int i = 0; i < num; i++)
						{
							if (array[i] == 10)
							{
								string @string = global::System.Text.Encoding.ASCII.GetString(array, num2, i - num2);
								streamWriter.WriteLine(@string);
								num2 = i + 1;
							}
						}
					}
					else
					{
						stream.Write(array, 0, num);
					}
				}
				if (flag2)
				{
					streamWriter.Close();
					return;
				}
				stream.Close();
			}
		}

		// Token: 0x06000172 RID: 370 RVA: 0x0000920C File Offset: 0x0000820C
		public void WriteEntry(global::ICSharpCode.SharpZipLib.Tar.TarEntry sourceEntry, bool recurse)
		{
			if (sourceEntry == null)
			{
				throw new global::System.ArgumentNullException("sourceEntry");
			}
			if (this.isDisposed)
			{
				throw new global::System.ObjectDisposedException("TarArchive");
			}
			try
			{
				if (recurse)
				{
					global::ICSharpCode.SharpZipLib.Tar.TarHeader.SetValueDefaults(sourceEntry.UserId, sourceEntry.UserName, sourceEntry.GroupId, sourceEntry.GroupName);
				}
				this.WriteEntryCore(sourceEntry, recurse);
			}
			finally
			{
				if (recurse)
				{
					global::ICSharpCode.SharpZipLib.Tar.TarHeader.RestoreSetValues();
				}
			}
		}

		// Token: 0x06000173 RID: 371 RVA: 0x00009280 File Offset: 0x00008280
		private void WriteEntryCore(global::ICSharpCode.SharpZipLib.Tar.TarEntry sourceEntry, bool recurse)
		{
			string text = null;
			string text2 = sourceEntry.File;
			global::ICSharpCode.SharpZipLib.Tar.TarEntry tarEntry = (global::ICSharpCode.SharpZipLib.Tar.TarEntry)sourceEntry.Clone();
			if (this.applyUserInfoOverrides)
			{
				tarEntry.GroupId = this.groupId;
				tarEntry.GroupName = this.groupName;
				tarEntry.UserId = this.userId;
				tarEntry.UserName = this.userName;
			}
			this.OnProgressMessageEvent(tarEntry, null);
			if (this.asciiTranslate && !tarEntry.IsDirectory)
			{
				bool flag = !global::ICSharpCode.SharpZipLib.Tar.TarArchive.IsBinary(text2);
				if (flag)
				{
					text = global::System.IO.Path.GetTempFileName();
					using (global::System.IO.StreamReader streamReader = global::System.IO.File.OpenText(text2))
					{
						using (global::System.IO.Stream stream = global::System.IO.File.Create(text))
						{
							for (;;)
							{
								string text3 = streamReader.ReadLine();
								if (text3 == null)
								{
									break;
								}
								byte[] bytes = global::System.Text.Encoding.ASCII.GetBytes(text3);
								stream.Write(bytes, 0, bytes.Length);
								stream.WriteByte(10);
							}
							stream.Flush();
						}
					}
					tarEntry.Size = new global::System.IO.FileInfo(text).Length;
					text2 = text;
				}
			}
			string text4 = null;
			if (this.rootPath != null && tarEntry.Name.StartsWith(this.rootPath))
			{
				text4 = tarEntry.Name.Substring(this.rootPath.Length + 1);
			}
			if (this.pathPrefix != null)
			{
				text4 = ((text4 == null) ? (this.pathPrefix + "/" + tarEntry.Name) : (this.pathPrefix + "/" + text4));
			}
			if (text4 != null)
			{
				tarEntry.Name = text4;
			}
			this.tarOut.PutNextEntry(tarEntry);
			if (tarEntry.IsDirectory)
			{
				if (recurse)
				{
					global::ICSharpCode.SharpZipLib.Tar.TarEntry[] directoryEntries = tarEntry.GetDirectoryEntries();
					for (int i = 0; i < directoryEntries.Length; i++)
					{
						this.WriteEntryCore(directoryEntries[i], recurse);
					}
					return;
				}
			}
			else
			{
				using (global::System.IO.Stream stream2 = global::System.IO.File.OpenRead(text2))
				{
					int num = 0;
					byte[] array = new byte[32768];
					for (;;)
					{
						int num2 = stream2.Read(array, 0, array.Length);
						if (num2 <= 0)
						{
							break;
						}
						this.tarOut.Write(array, 0, num2);
						num += num2;
					}
				}
				if (text != null && text.Length > 0)
				{
					global::System.IO.File.Delete(text);
				}
				this.tarOut.CloseEntry();
			}
		}

		// Token: 0x06000174 RID: 372 RVA: 0x000094E0 File Offset: 0x000084E0
		protected virtual void Dispose(bool disposing)
		{
			if (!this.isDisposed)
			{
				this.isDisposed = true;
				if (disposing)
				{
					if (this.tarOut != null)
					{
						this.tarOut.Flush();
						this.tarOut.Close();
					}
					if (this.tarIn != null)
					{
						this.tarIn.Close();
					}
				}
			}
		}

		// Token: 0x06000175 RID: 373 RVA: 0x00009530 File Offset: 0x00008530
		public virtual void Close()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x06000176 RID: 374 RVA: 0x00009540 File Offset: 0x00008540
		~TarArchive()
		{
			this.Dispose(false);
		}

		// Token: 0x06000177 RID: 375 RVA: 0x00009570 File Offset: 0x00008570
		void global::System.IDisposable.Dispose()
		{
			this.Close();
		}

		// Token: 0x06000178 RID: 376 RVA: 0x00009578 File Offset: 0x00008578
		private static void EnsureDirectoryExists(string directoryName)
		{
			if (!global::System.IO.Directory.Exists(directoryName))
			{
				try
				{
					global::System.IO.Directory.CreateDirectory(directoryName);
				}
				catch (global::System.Exception ex)
				{
					throw new global::ICSharpCode.SharpZipLib.Tar.TarException("Exception creating directory '" + directoryName + "', " + ex.Message, ex);
				}
			}
		}

		// Token: 0x06000179 RID: 377 RVA: 0x000095C4 File Offset: 0x000085C4
		private static bool IsBinary(string filename)
		{
			using (global::System.IO.FileStream fileStream = global::System.IO.File.OpenRead(filename))
			{
				int num = global::System.Math.Min(4096, (int)fileStream.Length);
				byte[] array = new byte[num];
				int num2 = fileStream.Read(array, 0, num);
				for (int i = 0; i < num2; i++)
				{
					byte b = array[i];
					if (b < 8 || (b > 13 && b < 32) || b == 255)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x040000A9 RID: 169
		private bool keepOldFiles;

		// Token: 0x040000AA RID: 170
		private bool asciiTranslate;

		// Token: 0x040000AB RID: 171
		private int userId;

		// Token: 0x040000AC RID: 172
		private string userName = string.Empty;

		// Token: 0x040000AD RID: 173
		private int groupId;

		// Token: 0x040000AE RID: 174
		private string groupName = string.Empty;

		// Token: 0x040000AF RID: 175
		private string rootPath;

		// Token: 0x040000B0 RID: 176
		private string pathPrefix;

		// Token: 0x040000B1 RID: 177
		private bool applyUserInfoOverrides;

		// Token: 0x040000B2 RID: 178
		private global::ICSharpCode.SharpZipLib.Tar.TarInputStream tarIn;

		// Token: 0x040000B3 RID: 179
		private global::ICSharpCode.SharpZipLib.Tar.TarOutputStream tarOut;

		// Token: 0x040000B4 RID: 180
		private bool isDisposed;
	}
}
