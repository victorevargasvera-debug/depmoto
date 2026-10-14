using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using ICSharpCode.SharpZipLib.Zip;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.Pba;

namespace Motorola.Common.Communication.SequenceManager.PbaFileProcessing
{
	// Token: 0x02000023 RID: 35
	public static class ZipFileUtility
	{
		// Token: 0x060000A0 RID: 160 RVA: 0x00005B38 File Offset: 0x00003D38
		public static byte[] CreateZipFile(string fileName, global::System.Collections.Generic.IEnumerable<string> files)
		{
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("Create zip file on " + fileName, new object[0]);
			if (global::System.IO.File.Exists(fileName))
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("Attention zip file exist!!! " + fileName, new object[0]);
				global::System.IO.File.Delete(fileName);
			}
			using (global::System.IO.Compression.ZipArchive zipArchive = global::System.IO.Compression.ZipFile.Open(fileName, global::System.IO.Compression.ZipArchiveMode.Create))
			{
				foreach (string text in files)
				{
					zipArchive.CreateEntryFromFile(text, global::System.IO.Path.GetFileName(text), global::System.IO.Compression.CompressionLevel.Optimal);
				}
			}
			byte[] bytes = global::System.IO.File.ReadAllBytes(fileName);
			return global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.WiFiUtility.getHashSha256(bytes);
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00005C2C File Offset: 0x00003E2C
		public static byte[] CreateZipFolder(string fileName, string folder)
		{
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("Create zip folder on " + fileName, new object[0]);
			using (global::ICSharpCode.SharpZipLib.Zip.ZipFile zipFile = global::ICSharpCode.SharpZipLib.Zip.ZipFile.Create(fileName))
			{
				zipFile.BeginUpdate();
				global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.ZipFileUtility.addFolderToZip(zipFile, folder, folder);
				zipFile.CommitUpdate();
			}
			byte[] bytes = global::System.IO.File.ReadAllBytes(fileName);
			return global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.WiFiUtility.getHashSha256(bytes);
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00005CAC File Offset: 0x00003EAC
		public static void Unzip(string zipFile, string unzipFolder)
		{
			using (global::System.IO.Compression.ZipArchive zipArchive = global::System.IO.Compression.ZipFile.Open(zipFile, global::System.IO.Compression.ZipArchiveMode.Read))
			{
				zipArchive.ExtractToDirectory(unzipFolder);
			}
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00005CF0 File Offset: 0x00003EF0
		private static void addFolderToZip(global::ICSharpCode.SharpZipLib.Zip.ZipFile f, string root, string folder)
		{
			string text = folder.Substring(root.Length);
			if (text.Length > 0)
			{
				f.AddDirectory(text);
			}
			foreach (string text2 in global::System.IO.Directory.GetFiles(folder))
			{
				text = text2.Substring(root.Length);
				f.Add(text2, text);
			}
			foreach (string folder2 in global::System.IO.Directory.GetDirectories(folder))
			{
				global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.ZipFileUtility.addFolderToZip(f, root, folder2);
			}
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00005D94 File Offset: 0x00003F94
		public static global::System.Collections.Generic.IEnumerable<string> ExtractFilesFromZip(string zipfileName, string folder)
		{
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("Extract Files From Zip " + zipfileName + " to " + folder, new object[0]);
			if (!global::System.IO.Directory.Exists(folder))
			{
				global::System.IO.Directory.CreateDirectory(folder);
			}
			global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
			using (global::System.IO.Compression.ZipArchive zipArchive = global::System.IO.Compression.ZipFile.OpenRead(zipfileName))
			{
				foreach (global::System.IO.Compression.ZipArchiveEntry zipArchiveEntry in zipArchive.Entries)
				{
					string item = global::System.IO.Path.Combine(folder, zipArchiveEntry.Name);
					list.Add(item);
				}
			}
			global::System.IO.Compression.ZipFile.ExtractToDirectory(zipfileName, folder);
			return list;
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00005E7C File Offset: 0x0000407C
		public static global::System.Collections.Generic.IEnumerable<global::Motorola.Common.Communication.Pba.FileItem> ExtractStreamFromZip(global::System.IO.Stream zipfile)
		{
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileItem> list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileItem>();
			using (global::System.IO.Compression.ZipArchive zipArchive = new global::System.IO.Compression.ZipArchive(zipfile))
			{
				foreach (global::System.IO.Compression.ZipArchiveEntry zipArchiveEntry in zipArchive.Entries)
				{
					global::Motorola.Common.Communication.Pba.FileItem fileItem = new global::Motorola.Common.Communication.Pba.FileItem();
					fileItem.Name = zipArchiveEntry.Name;
					fileItem.FileSize = (int)zipArchiveEntry.Length;
					using (global::System.IO.Stream stream = zipArchiveEntry.Open())
					{
						using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream())
						{
							stream.CopyTo(memoryStream);
							fileItem.FileContent = memoryStream.ToArray();
							memoryStream.Close();
						}
						stream.Close();
					}
					list.Add(fileItem);
				}
			}
			return list;
		}
	}
}
