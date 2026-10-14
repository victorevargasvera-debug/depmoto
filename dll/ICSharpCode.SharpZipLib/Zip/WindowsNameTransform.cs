using System;
using System.IO;
using System.Text;
using ICSharpCode.SharpZipLib.Core;

namespace ICSharpCode.SharpZipLib.Zip
{
	// Token: 0x0200004A RID: 74
	public class WindowsNameTransform : global::ICSharpCode.SharpZipLib.Core.INameTransform
	{
		// Token: 0x060002E7 RID: 743 RVA: 0x000103BE File Offset: 0x0000F3BE
		public WindowsNameTransform(string baseDirectory)
		{
			if (baseDirectory == null)
			{
				throw new global::System.ArgumentNullException("baseDirectory", "Directory name is invalid");
			}
			this.BaseDirectory = baseDirectory;
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x000103E8 File Offset: 0x0000F3E8
		public WindowsNameTransform()
		{
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x060002E9 RID: 745 RVA: 0x000103F8 File Offset: 0x0000F3F8
		// (set) Token: 0x060002EA RID: 746 RVA: 0x00010400 File Offset: 0x0000F400
		public string BaseDirectory
		{
			get
			{
				return this.baseDirectory_;
			}
			set
			{
				if (value == null)
				{
					throw new global::System.ArgumentNullException("value");
				}
				this.baseDirectory_ = global::System.IO.Path.GetFullPath(value);
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x060002EB RID: 747 RVA: 0x0001041C File Offset: 0x0000F41C
		// (set) Token: 0x060002EC RID: 748 RVA: 0x00010424 File Offset: 0x0000F424
		public bool TrimIncomingPaths
		{
			get
			{
				return this.trimIncomingPaths_;
			}
			set
			{
				this.trimIncomingPaths_ = value;
			}
		}

		// Token: 0x060002ED RID: 749 RVA: 0x00010430 File Offset: 0x0000F430
		public string TransformDirectory(string name)
		{
			name = this.TransformFile(name);
			if (name.Length > 0)
			{
				while (name.EndsWith("\\"))
				{
					name = name.Remove(name.Length - 1, 1);
				}
				return name;
			}
			throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Cannot have an empty directory name");
		}

		// Token: 0x060002EE RID: 750 RVA: 0x00010480 File Offset: 0x0000F480
		public string TransformFile(string name)
		{
			if (name != null)
			{
				name = global::ICSharpCode.SharpZipLib.Zip.WindowsNameTransform.MakeValidName(name, this.replacementChar_);
				if (this.trimIncomingPaths_)
				{
					name = global::System.IO.Path.GetFileName(name);
				}
				if (this.baseDirectory_ != null)
				{
					name = global::System.IO.Path.Combine(this.baseDirectory_, name);
				}
			}
			else
			{
				name = string.Empty;
			}
			return name;
		}

		// Token: 0x060002EF RID: 751 RVA: 0x000104D0 File Offset: 0x0000F4D0
		public static bool IsValidName(string name)
		{
			return name != null && name.Length <= 260 && string.Compare(name, global::ICSharpCode.SharpZipLib.Zip.WindowsNameTransform.MakeValidName(name, '_')) == 0;
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x00010504 File Offset: 0x0000F504
		static WindowsNameTransform()
		{
			char[] invalidPathChars = global::System.IO.Path.GetInvalidPathChars();
			int num = invalidPathChars.Length + 3;
			global::ICSharpCode.SharpZipLib.Zip.WindowsNameTransform.InvalidEntryChars = new char[num];
			global::System.Array.Copy(invalidPathChars, 0, global::ICSharpCode.SharpZipLib.Zip.WindowsNameTransform.InvalidEntryChars, 0, invalidPathChars.Length);
			global::ICSharpCode.SharpZipLib.Zip.WindowsNameTransform.InvalidEntryChars[num - 1] = '*';
			global::ICSharpCode.SharpZipLib.Zip.WindowsNameTransform.InvalidEntryChars[num - 2] = '?';
			global::ICSharpCode.SharpZipLib.Zip.WindowsNameTransform.InvalidEntryChars[num - 2] = ':';
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x0001055C File Offset: 0x0000F55C
		public static string MakeValidName(string name, char replacement)
		{
			if (name == null)
			{
				throw new global::System.ArgumentNullException("name");
			}
			name = global::ICSharpCode.SharpZipLib.Core.WindowsPathUtils.DropPathRoot(name.Replace("/", "\\"));
			while (name.Length > 0)
			{
				if (name[0] != '\\')
				{
					break;
				}
				name = name.Remove(0, 1);
			}
			while (name.Length > 0 && name[name.Length - 1] == '\\')
			{
				name = name.Remove(name.Length - 1, 1);
			}
			int i;
			for (i = name.IndexOf("\\\\"); i >= 0; i = name.IndexOf("\\\\"))
			{
				name = name.Remove(i, 1);
			}
			i = name.IndexOfAny(global::ICSharpCode.SharpZipLib.Zip.WindowsNameTransform.InvalidEntryChars);
			if (i >= 0)
			{
				global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(name);
				while (i >= 0)
				{
					stringBuilder[i] = replacement;
					if (i >= name.Length)
					{
						i = -1;
					}
					else
					{
						i = name.IndexOfAny(global::ICSharpCode.SharpZipLib.Zip.WindowsNameTransform.InvalidEntryChars, i + 1);
					}
				}
				name = stringBuilder.ToString();
			}
			if (name.Length > 260)
			{
				throw new global::System.IO.PathTooLongException();
			}
			return name;
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x060002F2 RID: 754 RVA: 0x00010661 File Offset: 0x0000F661
		// (set) Token: 0x060002F3 RID: 755 RVA: 0x0001066C File Offset: 0x0000F66C
		public char Replacement
		{
			get
			{
				return this.replacementChar_;
			}
			set
			{
				for (int i = 0; i < global::ICSharpCode.SharpZipLib.Zip.WindowsNameTransform.InvalidEntryChars.Length; i++)
				{
					if (global::ICSharpCode.SharpZipLib.Zip.WindowsNameTransform.InvalidEntryChars[i] == value)
					{
						throw new global::System.ArgumentException("invalid path character");
					}
				}
				if (value == '\\' || value == '/')
				{
					throw new global::System.ArgumentException("invalid replacement character");
				}
				this.replacementChar_ = value;
			}
		}

		// Token: 0x040001E5 RID: 485
		private const int MaxPath = 260;

		// Token: 0x040001E6 RID: 486
		private string baseDirectory_;

		// Token: 0x040001E7 RID: 487
		private bool trimIncomingPaths_;

		// Token: 0x040001E8 RID: 488
		private char replacementChar_ = '_';

		// Token: 0x040001E9 RID: 489
		private static readonly char[] InvalidEntryChars;
	}
}
