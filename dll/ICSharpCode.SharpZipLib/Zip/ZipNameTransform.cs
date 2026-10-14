using System;
using System.IO;
using System.Text;
using ICSharpCode.SharpZipLib.Core;

namespace ICSharpCode.SharpZipLib.Zip
{
	// Token: 0x0200007A RID: 122
	public class ZipNameTransform : global::ICSharpCode.SharpZipLib.Core.INameTransform
	{
		// Token: 0x060004A9 RID: 1193 RVA: 0x00016D18 File Offset: 0x00015D18
		public ZipNameTransform()
		{
		}

		// Token: 0x060004AA RID: 1194 RVA: 0x00016D20 File Offset: 0x00015D20
		public ZipNameTransform(string trimPrefix)
		{
			this.TrimPrefix = trimPrefix;
		}

		// Token: 0x060004AB RID: 1195 RVA: 0x00016D30 File Offset: 0x00015D30
		static ZipNameTransform()
		{
			char[] invalidPathChars = global::System.IO.Path.GetInvalidPathChars();
			int num = invalidPathChars.Length + 2;
			global::ICSharpCode.SharpZipLib.Zip.ZipNameTransform.InvalidEntryCharsRelaxed = new char[num];
			global::System.Array.Copy(invalidPathChars, 0, global::ICSharpCode.SharpZipLib.Zip.ZipNameTransform.InvalidEntryCharsRelaxed, 0, invalidPathChars.Length);
			global::ICSharpCode.SharpZipLib.Zip.ZipNameTransform.InvalidEntryCharsRelaxed[num - 1] = '*';
			global::ICSharpCode.SharpZipLib.Zip.ZipNameTransform.InvalidEntryCharsRelaxed[num - 2] = '?';
			num = invalidPathChars.Length + 4;
			global::ICSharpCode.SharpZipLib.Zip.ZipNameTransform.InvalidEntryChars = new char[num];
			global::System.Array.Copy(invalidPathChars, 0, global::ICSharpCode.SharpZipLib.Zip.ZipNameTransform.InvalidEntryChars, 0, invalidPathChars.Length);
			global::ICSharpCode.SharpZipLib.Zip.ZipNameTransform.InvalidEntryChars[num - 1] = ':';
			global::ICSharpCode.SharpZipLib.Zip.ZipNameTransform.InvalidEntryChars[num - 2] = '\\';
			global::ICSharpCode.SharpZipLib.Zip.ZipNameTransform.InvalidEntryChars[num - 3] = '*';
			global::ICSharpCode.SharpZipLib.Zip.ZipNameTransform.InvalidEntryChars[num - 4] = '?';
		}

		// Token: 0x060004AC RID: 1196 RVA: 0x00016DC7 File Offset: 0x00015DC7
		public string TransformDirectory(string name)
		{
			name = this.TransformFile(name);
			if (name.Length > 0)
			{
				if (!name.EndsWith("/"))
				{
					name += "/";
				}
				return name;
			}
			throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Cannot have an empty directory name");
		}

		// Token: 0x060004AD RID: 1197 RVA: 0x00016E04 File Offset: 0x00015E04
		public string TransformFile(string name)
		{
			if (name != null)
			{
				string text = name.ToLower();
				if (this.trimPrefix_ != null && text.IndexOf(this.trimPrefix_) == 0)
				{
					name = name.Substring(this.trimPrefix_.Length);
				}
				name = name.Replace("\\", "/");
				name = global::ICSharpCode.SharpZipLib.Core.WindowsPathUtils.DropPathRoot(name);
				while (name.Length > 0)
				{
					if (name[0] != '/')
					{
						break;
					}
					name = name.Remove(0, 1);
				}
				while (name.Length > 0 && name[name.Length - 1] == '/')
				{
					name = name.Remove(name.Length - 1, 1);
				}
				for (int i = name.IndexOf("//"); i >= 0; i = name.IndexOf("//"))
				{
					name = name.Remove(i, 1);
				}
				name = global::ICSharpCode.SharpZipLib.Zip.ZipNameTransform.MakeValidName(name, '_');
			}
			else
			{
				name = string.Empty;
			}
			return name;
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x060004AE RID: 1198 RVA: 0x00016EEB File Offset: 0x00015EEB
		// (set) Token: 0x060004AF RID: 1199 RVA: 0x00016EF3 File Offset: 0x00015EF3
		public string TrimPrefix
		{
			get
			{
				return this.trimPrefix_;
			}
			set
			{
				this.trimPrefix_ = value;
				if (this.trimPrefix_ != null)
				{
					this.trimPrefix_ = this.trimPrefix_.ToLower();
				}
			}
		}

		// Token: 0x060004B0 RID: 1200 RVA: 0x00016F18 File Offset: 0x00015F18
		private static string MakeValidName(string name, char replacement)
		{
			int i = name.IndexOfAny(global::ICSharpCode.SharpZipLib.Zip.ZipNameTransform.InvalidEntryChars);
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
						i = name.IndexOfAny(global::ICSharpCode.SharpZipLib.Zip.ZipNameTransform.InvalidEntryChars, i + 1);
					}
				}
				name = stringBuilder.ToString();
			}
			if (name.Length > 65535)
			{
				throw new global::System.IO.PathTooLongException();
			}
			return name;
		}

		// Token: 0x060004B1 RID: 1201 RVA: 0x00016F84 File Offset: 0x00015F84
		public static bool IsValidName(string name, bool relaxed)
		{
			bool flag = name != null;
			if (flag)
			{
				if (relaxed)
				{
					flag = (name.IndexOfAny(global::ICSharpCode.SharpZipLib.Zip.ZipNameTransform.InvalidEntryCharsRelaxed) < 0);
				}
				else
				{
					flag = (name.IndexOfAny(global::ICSharpCode.SharpZipLib.Zip.ZipNameTransform.InvalidEntryChars) < 0 && name.IndexOf('/') != 0);
				}
			}
			return flag;
		}

		// Token: 0x060004B2 RID: 1202 RVA: 0x00016FD4 File Offset: 0x00015FD4
		public static bool IsValidName(string name)
		{
			return name != null && name.IndexOfAny(global::ICSharpCode.SharpZipLib.Zip.ZipNameTransform.InvalidEntryChars) < 0 && name.IndexOf('/') != 0;
		}

		// Token: 0x040002DF RID: 735
		private string trimPrefix_;

		// Token: 0x040002E0 RID: 736
		private static readonly char[] InvalidEntryChars;

		// Token: 0x040002E1 RID: 737
		private static readonly char[] InvalidEntryCharsRelaxed;
	}
}
