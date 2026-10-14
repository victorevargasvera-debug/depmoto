using System;
using System.IO;

namespace ICSharpCode.SharpZipLib.Tar
{
	// Token: 0x02000031 RID: 49
	public class TarEntry : global::System.ICloneable
	{
		// Token: 0x06000192 RID: 402 RVA: 0x00009BE0 File Offset: 0x00008BE0
		private TarEntry()
		{
			this.header = new global::ICSharpCode.SharpZipLib.Tar.TarHeader();
		}

		// Token: 0x06000193 RID: 403 RVA: 0x00009BF3 File Offset: 0x00008BF3
		public TarEntry(byte[] headerBuffer)
		{
			this.header = new global::ICSharpCode.SharpZipLib.Tar.TarHeader();
			this.header.ParseBuffer(headerBuffer);
		}

		// Token: 0x06000194 RID: 404 RVA: 0x00009C12 File Offset: 0x00008C12
		public TarEntry(global::ICSharpCode.SharpZipLib.Tar.TarHeader header)
		{
			if (header == null)
			{
				throw new global::System.ArgumentNullException("header");
			}
			this.header = (global::ICSharpCode.SharpZipLib.Tar.TarHeader)header.Clone();
		}

		// Token: 0x06000195 RID: 405 RVA: 0x00009C3C File Offset: 0x00008C3C
		public object Clone()
		{
			return new global::ICSharpCode.SharpZipLib.Tar.TarEntry
			{
				file = this.file,
				header = (global::ICSharpCode.SharpZipLib.Tar.TarHeader)this.header.Clone(),
				Name = this.Name
			};
		}

		// Token: 0x06000196 RID: 406 RVA: 0x00009C80 File Offset: 0x00008C80
		public static global::ICSharpCode.SharpZipLib.Tar.TarEntry CreateTarEntry(string name)
		{
			global::ICSharpCode.SharpZipLib.Tar.TarEntry tarEntry = new global::ICSharpCode.SharpZipLib.Tar.TarEntry();
			global::ICSharpCode.SharpZipLib.Tar.TarEntry.NameTarHeader(tarEntry.header, name);
			return tarEntry;
		}

		// Token: 0x06000197 RID: 407 RVA: 0x00009CA0 File Offset: 0x00008CA0
		public static global::ICSharpCode.SharpZipLib.Tar.TarEntry CreateEntryFromFile(string fileName)
		{
			global::ICSharpCode.SharpZipLib.Tar.TarEntry tarEntry = new global::ICSharpCode.SharpZipLib.Tar.TarEntry();
			tarEntry.GetFileTarHeader(tarEntry.header, fileName);
			return tarEntry;
		}

		// Token: 0x06000198 RID: 408 RVA: 0x00009CC4 File Offset: 0x00008CC4
		public override bool Equals(object obj)
		{
			global::ICSharpCode.SharpZipLib.Tar.TarEntry tarEntry = obj as global::ICSharpCode.SharpZipLib.Tar.TarEntry;
			return tarEntry != null && this.Name.Equals(tarEntry.Name);
		}

		// Token: 0x06000199 RID: 409 RVA: 0x00009CEE File Offset: 0x00008CEE
		public override int GetHashCode()
		{
			return this.Name.GetHashCode();
		}

		// Token: 0x0600019A RID: 410 RVA: 0x00009CFB File Offset: 0x00008CFB
		public bool IsDescendent(global::ICSharpCode.SharpZipLib.Tar.TarEntry toTest)
		{
			if (toTest == null)
			{
				throw new global::System.ArgumentNullException("toTest");
			}
			return toTest.Name.StartsWith(this.Name);
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x0600019B RID: 411 RVA: 0x00009D1C File Offset: 0x00008D1C
		public global::ICSharpCode.SharpZipLib.Tar.TarHeader TarHeader
		{
			get
			{
				return this.header;
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x0600019C RID: 412 RVA: 0x00009D24 File Offset: 0x00008D24
		// (set) Token: 0x0600019D RID: 413 RVA: 0x00009D31 File Offset: 0x00008D31
		public string Name
		{
			get
			{
				return this.header.Name;
			}
			set
			{
				this.header.Name = value;
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x0600019E RID: 414 RVA: 0x00009D3F File Offset: 0x00008D3F
		// (set) Token: 0x0600019F RID: 415 RVA: 0x00009D4C File Offset: 0x00008D4C
		public int UserId
		{
			get
			{
				return this.header.UserId;
			}
			set
			{
				this.header.UserId = value;
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060001A0 RID: 416 RVA: 0x00009D5A File Offset: 0x00008D5A
		// (set) Token: 0x060001A1 RID: 417 RVA: 0x00009D67 File Offset: 0x00008D67
		public int GroupId
		{
			get
			{
				return this.header.GroupId;
			}
			set
			{
				this.header.GroupId = value;
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060001A2 RID: 418 RVA: 0x00009D75 File Offset: 0x00008D75
		// (set) Token: 0x060001A3 RID: 419 RVA: 0x00009D82 File Offset: 0x00008D82
		public string UserName
		{
			get
			{
				return this.header.UserName;
			}
			set
			{
				this.header.UserName = value;
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060001A4 RID: 420 RVA: 0x00009D90 File Offset: 0x00008D90
		// (set) Token: 0x060001A5 RID: 421 RVA: 0x00009D9D File Offset: 0x00008D9D
		public string GroupName
		{
			get
			{
				return this.header.GroupName;
			}
			set
			{
				this.header.GroupName = value;
			}
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x00009DAB File Offset: 0x00008DAB
		public void SetIds(int userId, int groupId)
		{
			this.UserId = userId;
			this.GroupId = groupId;
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00009DBB File Offset: 0x00008DBB
		public void SetNames(string userName, string groupName)
		{
			this.UserName = userName;
			this.GroupName = groupName;
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060001A8 RID: 424 RVA: 0x00009DCB File Offset: 0x00008DCB
		// (set) Token: 0x060001A9 RID: 425 RVA: 0x00009DD8 File Offset: 0x00008DD8
		public global::System.DateTime ModTime
		{
			get
			{
				return this.header.ModTime;
			}
			set
			{
				this.header.ModTime = value;
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060001AA RID: 426 RVA: 0x00009DE6 File Offset: 0x00008DE6
		public string File
		{
			get
			{
				return this.file;
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060001AB RID: 427 RVA: 0x00009DEE File Offset: 0x00008DEE
		// (set) Token: 0x060001AC RID: 428 RVA: 0x00009DFB File Offset: 0x00008DFB
		public long Size
		{
			get
			{
				return this.header.Size;
			}
			set
			{
				this.header.Size = value;
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060001AD RID: 429 RVA: 0x00009E0C File Offset: 0x00008E0C
		public bool IsDirectory
		{
			get
			{
				if (this.file != null)
				{
					return global::System.IO.Directory.Exists(this.file);
				}
				return this.header != null && (this.header.TypeFlag == 53 || this.Name.EndsWith("/"));
			}
		}

		// Token: 0x060001AE RID: 430 RVA: 0x00009E5C File Offset: 0x00008E5C
		public void GetFileTarHeader(global::ICSharpCode.SharpZipLib.Tar.TarHeader header, string file)
		{
			if (header == null)
			{
				throw new global::System.ArgumentNullException("header");
			}
			if (file == null)
			{
				throw new global::System.ArgumentNullException("file");
			}
			this.file = file;
			string text = file;
			if (text.IndexOf(global::System.Environment.CurrentDirectory) == 0)
			{
				text = text.Substring(global::System.Environment.CurrentDirectory.Length);
			}
			text = text.Replace(global::System.IO.Path.DirectorySeparatorChar, '/');
			while (text.StartsWith("/"))
			{
				text = text.Substring(1);
			}
			header.LinkName = string.Empty;
			header.Name = text;
			if (global::System.IO.Directory.Exists(file))
			{
				header.Mode = 1003;
				header.TypeFlag = 53;
				if (header.Name.Length == 0 || header.Name[header.Name.Length - 1] != '/')
				{
					header.Name += "/";
				}
				header.Size = 0L;
			}
			else
			{
				header.Mode = 33216;
				header.TypeFlag = 48;
				header.Size = new global::System.IO.FileInfo(file.Replace('/', global::System.IO.Path.DirectorySeparatorChar)).Length;
			}
			header.ModTime = global::System.IO.File.GetLastWriteTime(file.Replace('/', global::System.IO.Path.DirectorySeparatorChar)).ToUniversalTime();
			header.DevMajor = 0;
			header.DevMinor = 0;
		}

		// Token: 0x060001AF RID: 431 RVA: 0x00009FA8 File Offset: 0x00008FA8
		public global::ICSharpCode.SharpZipLib.Tar.TarEntry[] GetDirectoryEntries()
		{
			if (this.file == null || !global::System.IO.Directory.Exists(this.file))
			{
				return new global::ICSharpCode.SharpZipLib.Tar.TarEntry[0];
			}
			string[] fileSystemEntries = global::System.IO.Directory.GetFileSystemEntries(this.file);
			global::ICSharpCode.SharpZipLib.Tar.TarEntry[] array = new global::ICSharpCode.SharpZipLib.Tar.TarEntry[fileSystemEntries.Length];
			for (int i = 0; i < fileSystemEntries.Length; i++)
			{
				array[i] = global::ICSharpCode.SharpZipLib.Tar.TarEntry.CreateEntryFromFile(fileSystemEntries[i]);
			}
			return array;
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x0000A000 File Offset: 0x00009000
		public void WriteEntryHeader(byte[] outBuffer)
		{
			this.header.WriteHeader(outBuffer);
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x0000A010 File Offset: 0x00009010
		public static void AdjustEntryName(byte[] buffer, string newName)
		{
			int offset = 0;
			global::ICSharpCode.SharpZipLib.Tar.TarHeader.GetNameBytes(newName, buffer, offset, 100);
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x0000A02C File Offset: 0x0000902C
		public static void NameTarHeader(global::ICSharpCode.SharpZipLib.Tar.TarHeader header, string name)
		{
			if (header == null)
			{
				throw new global::System.ArgumentNullException("header");
			}
			if (name == null)
			{
				throw new global::System.ArgumentNullException("name");
			}
			bool flag = name.EndsWith("/");
			header.Name = name;
			header.Mode = (flag ? 1003 : 33216);
			header.UserId = 0;
			header.GroupId = 0;
			header.Size = 0L;
			header.ModTime = global::System.DateTime.UtcNow;
			header.TypeFlag = (flag ? 53 : 48);
			header.LinkName = string.Empty;
			header.UserName = string.Empty;
			header.GroupName = string.Empty;
			header.DevMajor = 0;
			header.DevMinor = 0;
		}

		// Token: 0x040000BF RID: 191
		private string file;

		// Token: 0x040000C0 RID: 192
		private global::ICSharpCode.SharpZipLib.Tar.TarHeader header;
	}
}
