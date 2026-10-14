using System;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Threading;
using Motorola.Common.LogUtility;

namespace Motorola.Common.Communication.TetraUtility
{
	// Token: 0x02000007 RID: 7
	public static class FileSystem
	{
		// Token: 0x06000027 RID: 39 RVA: 0x00004A7D File Offset: 0x00002C7D
		public static global::System.Collections.Specialized.StringCollection SearchDirectory(string directory, string filemask)
		{
			return global::Motorola.Common.Communication.TetraUtility.FileSystem.SearchDirectory(directory, filemask, true);
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00004A88 File Offset: 0x00002C88
		public static global::System.Collections.Specialized.StringCollection SearchDirectory(string directory, string filemask, bool searchSubdirectories)
		{
			global::System.Collections.Specialized.StringCollection stringCollection = new global::System.Collections.Specialized.StringCollection();
			global::Motorola.Common.Communication.TetraUtility.FileSystem.SearchDirectory(directory, filemask, stringCollection, searchSubdirectories);
			return stringCollection;
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00004AA8 File Offset: 0x00002CA8
		public static string GetDirectoryNameWithSeparator(string directoryName)
		{
			if (directoryName.EndsWith(global::System.IO.Path.DirectorySeparatorChar.ToString(), global::System.StringComparison.Ordinal))
			{
				return directoryName;
			}
			return directoryName + global::System.IO.Path.DirectorySeparatorChar;
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600002A RID: 42 RVA: 0x00004AE0 File Offset: 0x00002CE0
		public static string BinDir
		{
			get
			{
				if (!string.IsNullOrEmpty(global::Motorola.Common.Communication.TetraUtility.FileSystem._binDir))
				{
					return global::Motorola.Common.Communication.TetraUtility.FileSystem._binDir;
				}
				if (global::System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName.ToLowerInvariant().Contains("vstesthost.exe"))
				{
					global::System.Text.RegularExpressions.Match match = global::System.Text.RegularExpressions.Regex.Match(global::System.Reflection.Assembly.GetCallingAssembly().Location, "(?<root>.+\\\\)((tetra_newcps)|(tetra_packet)|(tetra_pandacps))(\\\\)");
					if (match.Success)
					{
						global::Motorola.Common.Communication.TetraUtility.FileSystem._binDir = global::System.IO.Path.Combine(match.Groups["root"].Value, "tetra_pandacps\\solution\\pandacps\\release\\bin");
					}
				}
				else
				{
					global::System.Reflection.Assembly assembly = global::System.Reflection.Assembly.GetEntryAssembly();
					if (assembly == null)
					{
						assembly = global::System.Reflection.Assembly.GetCallingAssembly();
					}
					if (assembly == null)
					{
						assembly = global::System.Reflection.Assembly.GetExecutingAssembly();
					}
					if (assembly != null)
					{
						global::Motorola.Common.Communication.TetraUtility.FileSystem._binDir = global::System.IO.Path.GetDirectoryName(assembly.Location);
					}
					else
					{
						global::Motorola.Common.Communication.TetraUtility.FileSystem._binDir = global::System.Diagnostics.Process.GetCurrentProcess().StartInfo.WorkingDirectory;
					}
				}
				return global::Motorola.Common.Communication.TetraUtility.FileSystem._binDir;
			}
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00004BBC File Offset: 0x00002DBC
		public static void DeleteFile(string filePath, bool forece)
		{
			try
			{
				if (global::System.IO.File.Exists(filePath))
				{
					if (forece)
					{
						global::System.IO.File.SetAttributes(filePath, global::System.IO.FileAttributes.Normal);
					}
					global::System.IO.File.Delete(filePath);
				}
			}
			catch (global::System.Exception e)
			{
				global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.LogUtility.LogManager.DefaultLoggerName).Error(e, "DeleteFile() error.");
			}
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00004C14 File Offset: 0x00002E14
		public static void DeleteDirectory(string dirPath, bool force)
		{
			try
			{
				if (global::System.IO.Directory.Exists(dirPath))
				{
					string[] files = global::System.IO.Directory.GetFiles(dirPath);
					foreach (string filePath in files)
					{
						global::Motorola.Common.Communication.TetraUtility.FileSystem.DeleteFile(filePath, force);
					}
					string[] directories = global::System.IO.Directory.GetDirectories(dirPath);
					foreach (string dirPath2 in directories)
					{
						global::Motorola.Common.Communication.TetraUtility.FileSystem.DeleteDirectory(dirPath2, force);
					}
					if (force)
					{
						global::System.IO.DirectoryInfo directoryInfo = new global::System.IO.DirectoryInfo(dirPath);
						directoryInfo.Attributes = global::System.IO.FileAttributes.Normal;
					}
					global::System.IO.Directory.Delete(dirPath);
					int num = 0;
					while (global::System.IO.Directory.Exists(dirPath))
					{
						global::System.Threading.Thread.Sleep(50);
						global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.LogUtility.LogManager.DefaultLoggerName).Error("Directory.Delete({0}) waiting[{1}] ...", new object[]
						{
							dirPath,
							num++
						});
						if (num > 100)
						{
							global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.LogUtility.LogManager.DefaultLoggerName).Error("Directory.Delete({0}) failed.", new object[]
							{
								dirPath
							});
							break;
						}
					}
				}
			}
			catch (global::System.Exception e)
			{
				global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.LogUtility.LogManager.DefaultLoggerName).Error(e, "DeleteDirectory() error.");
			}
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00004D40 File Offset: 0x00002F40
		public static void CopyDirectory(string sourceDirectory, string destDirectory, bool overwrite)
		{
			if (!global::System.IO.Directory.Exists(sourceDirectory))
			{
				throw new global::System.Exception(string.Format("source directory is not exist. [{0}]", sourceDirectory));
			}
			if (overwrite)
			{
				global::Motorola.Common.Communication.TetraUtility.FileSystem.DeleteDirectory(destDirectory, true);
			}
			else if (global::System.IO.Directory.Exists(destDirectory))
			{
				throw new global::System.Exception(string.Format("dest directory is alread exist. [{0}]", destDirectory));
			}
			global::System.IO.Directory.CreateDirectory(destDirectory);
			string[] files = global::System.IO.Directory.GetFiles(sourceDirectory);
			foreach (string text in files)
			{
				global::System.IO.File.Copy(text, global::System.IO.Path.Combine(destDirectory, global::System.IO.Path.GetFileName(text)));
			}
			string[] directories = global::System.IO.Directory.GetDirectories(sourceDirectory);
			foreach (string text2 in directories)
			{
				string text3 = global::System.IO.Path.Combine(destDirectory, global::System.IO.Path.GetFileName(text2));
				global::System.IO.Directory.CreateDirectory(text3);
				global::Motorola.Common.Communication.TetraUtility.FileSystem.CopyDirectory(text2, text3, overwrite);
			}
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00004E0C File Offset: 0x0000300C
		private static void SearchDirectory(string directory, string filemask, global::System.Collections.Specialized.StringCollection collection, bool searchSubdirectories)
		{
			try
			{
				string[] files = global::System.IO.Directory.GetFiles(directory, filemask);
				foreach (string value in files)
				{
					collection.Add(value);
				}
				if (searchSubdirectories)
				{
					string[] directories = global::System.IO.Directory.GetDirectories(directory);
					foreach (string directory2 in directories)
					{
						global::Motorola.Common.Communication.TetraUtility.FileSystem.SearchDirectory(directory2, filemask, collection, searchSubdirectories);
					}
				}
			}
			catch (global::System.Exception)
			{
			}
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00004E8C File Offset: 0x0000308C
		public static void CreateDirectoryIfNotExist(string dirPath)
		{
			if (!global::System.IO.Directory.Exists(dirPath))
			{
				global::System.IO.Directory.CreateDirectory(dirPath);
			}
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00004EA0 File Offset: 0x000030A0
		public static string GetNoneDuplicateFilePath(string filePath)
		{
			string text = filePath;
			int num = 1;
			string directoryName = global::System.IO.Path.GetDirectoryName(text);
			string text2 = global::System.IO.Path.GetFileNameWithoutExtension(text);
			string extension = global::System.IO.Path.GetExtension(text);
			while (global::System.IO.File.Exists(text))
			{
				int length = text2.Length;
				if (length > 2 && text2[length - 2] == '_')
				{
					num = ((num + 1 > 10) ? 1 : (num + 1));
					text2 = text2.Remove(length - 2) + "_" + num.ToString();
				}
				else
				{
					text2 += "_1";
				}
				text = global::System.IO.Path.Combine(directoryName, text2 + extension);
			}
			return text;
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00004F34 File Offset: 0x00003134
		public static bool DeleteFileSafe(string filePath, int retryCount)
		{
			if (!global::System.IO.File.Exists(filePath))
			{
				return true;
			}
			bool flag = false;
			bool flag2 = true;
			do
			{
				try
				{
					global::System.IO.File.Delete(filePath);
					flag = true;
					break;
				}
				catch (global::System.Exception ex)
				{
					flag = false;
					global::System.Threading.Thread.Sleep(500);
					global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.LogUtility.LogManager.DefaultLoggerName).Error("File.Delete() got exception in DeleteFileSafe: " + ex.Message);
				}
				if (!flag && flag2)
				{
					try
					{
						global::System.IO.File.SetAttributes(filePath, global::System.IO.FileAttributes.Normal);
					}
					catch (global::System.Exception ex2)
					{
						global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.LogUtility.LogManager.DefaultLoggerName).Error("File.SetAttributes() got exception in DeleteFileSafe: " + ex2.Message);
					}
					flag2 = false;
				}
			}
			while (retryCount-- > 0);
			return flag;
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00004FE4 File Offset: 0x000031E4
		public static bool DeleteDirectorySafe(string dirPath, bool force)
		{
			try
			{
				if (!global::System.IO.Directory.Exists(dirPath))
				{
					return true;
				}
				string[] files = global::System.IO.Directory.GetFiles(dirPath);
				foreach (string text in files)
				{
					if (!global::Motorola.Common.Communication.TetraUtility.FileSystem.DeleteFileSafe(text, 5))
					{
						global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.LogUtility.LogManager.DefaultLoggerName).Error("DeleteFileSafe() error: {0}", new object[]
						{
							text
						});
						return false;
					}
				}
				string[] directories = global::System.IO.Directory.GetDirectories(dirPath);
				foreach (string text2 in directories)
				{
					if (!global::Motorola.Common.Communication.TetraUtility.FileSystem.DeleteDirectorySafe(text2, force))
					{
						global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.LogUtility.LogManager.DefaultLoggerName).Error("DeleteDirectorySafe() error: {0}", new object[]
						{
							text2
						});
						return false;
					}
				}
				if (force)
				{
					global::System.IO.DirectoryInfo directoryInfo = new global::System.IO.DirectoryInfo(dirPath);
					directoryInfo.Attributes = global::System.IO.FileAttributes.Normal;
				}
				global::System.IO.Directory.Delete(dirPath);
			}
			catch (global::System.Exception e)
			{
				global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.LogUtility.LogManager.DefaultLoggerName).Error(e, "DeleteDirectorySafe() error.");
				return false;
			}
			return true;
		}

		// Token: 0x04000010 RID: 16
		private static string _binDir = string.Empty;
	}
}
