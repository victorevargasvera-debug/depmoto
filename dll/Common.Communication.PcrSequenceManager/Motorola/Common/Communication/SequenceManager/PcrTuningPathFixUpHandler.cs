using System;
using System.Collections.Generic;
using System.IO;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.IshHandler;
using Motorola.Common.Communication.Pba;

namespace Motorola.Common.Communication.SequenceManager
{
	// Token: 0x02000049 RID: 73
	internal class PcrTuningPathFixUpHandler
	{
		// Token: 0x0600024D RID: 589 RVA: 0x00014910 File Offset: 0x00012B10
		public static void PcrTuningPathFixUpSequencer(global::Motorola.Common.Communication.SequenceManager.DeviceInfoFetcher DIFetcher, global::Motorola.Common.Communication.IshHandler.IOController ioController)
		{
			try
			{
				if (DIFetcher.ProductFamily == global::Motorola.Common.Communication.CommonUtil.ProductFamily.ParadiseRadio)
				{
					if (!string.IsNullOrEmpty(DIFetcher.CodeplugVersion) && global::Motorola.Common.Communication.SequenceManager.PcrTuningPathFixUpHandler.IsTuningPathFixupVersions(DIFetcher.CodeplugVersion))
					{
						string empty = string.Empty;
						string empty2 = string.Empty;
						bool flag = global::Motorola.Common.Communication.SequenceManager.PcrTuningPathFixUpHandler.CheckIfTuningPathWrong(DIFetcher, out empty);
						if (flag)
						{
							bool flag2 = global::Motorola.Common.Communication.SequenceManager.PcrTuningPathFixUpHandler.CompareTuningVersionMatched(DIFetcher, empty);
							if (flag2)
							{
								global::Motorola.Common.Communication.SequenceManager.PcrTuningPathFixUpHandler.CopyWrongPathTuningFiles2CorrectPath(ioController);
							}
						}
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x0600024E RID: 590 RVA: 0x000149AC File Offset: 0x00012BAC
		private static bool IsTuningPathFixupVersions(string ver)
		{
			return global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParadiseTuningPathFixupVersions(ver);
		}

		// Token: 0x0600024F RID: 591 RVA: 0x000149C4 File Offset: 0x00012BC4
		private static void CopyWrongPathTuningFiles2CorrectPath(global::Motorola.Common.Communication.IshHandler.IOController ioController)
		{
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileItem> list = global::Motorola.Common.Communication.SequenceManager.PcrTuningPathFixUpHandler.ReadOutTuningFolderFiles(ioController, "/opt/pcr/rel/data/tuning/");
			if (list.Count > 0)
			{
				global::Motorola.Common.Communication.SequenceManager.PcrTuningPathFixUpHandler.DeleteTuningFiles(ioController, "/opt/pcr/rel/data/tuning/app_tuning/");
				global::Motorola.Common.Communication.SequenceManager.PcrTuningPathFixUpHandler.PastCorrectTuningFiles(ioController, list);
				global::Motorola.Common.Communication.SequenceManager.PcrTuningPathFixUpHandler.DeleteTuningFiles(ioController, "/opt/pcr/rel/data/tuning/");
			}
		}

		// Token: 0x06000250 RID: 592 RVA: 0x00014A10 File Offset: 0x00012C10
		private static void PastCorrectTuningFiles(global::Motorola.Common.Communication.IshHandler.IOController ioController, global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileItem> filelist)
		{
			foreach (global::Motorola.Common.Communication.Pba.FileItem fileItem in filelist)
			{
				using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(fileItem.FileContent))
				{
					ioController.FileWrite(0, "/opt/pcr/rel/data/tuning/app_tuning/" + fileItem.Name, memoryStream, null, false);
				}
			}
		}

		// Token: 0x06000251 RID: 593 RVA: 0x00014AA8 File Offset: 0x00012CA8
		private static global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileItem> ReadOutTuningFolderFiles(global::Motorola.Common.Communication.IshHandler.IOController ioController, string folder)
		{
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileItem> list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileItem>();
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileListItemStruct> list2 = ioController.ListDirectoryContents(0, folder);
			foreach (global::Motorola.Common.Communication.Pba.FileListItemStruct fileListItemStruct in list2)
			{
				if ((byte)(fileListItemStruct.FileType & global::Motorola.Common.Communication.Pba.FileListItemStruct.TypeOfFile.File) == 1 && fileListItemStruct.FileName.EndsWith(".cpg", global::System.StringComparison.OrdinalIgnoreCase))
				{
					using (global::System.IO.MemoryStream memoryStream = ioController.FileRead(0, folder + fileListItemStruct.FileName, null))
					{
						byte[] array = memoryStream.ToArray();
						list.Add(new global::Motorola.Common.Communication.Pba.FileItem
						{
							Name = fileListItemStruct.FileName,
							FileContent = array,
							FileSize = array.Length
						});
					}
				}
			}
			return list;
		}

		// Token: 0x06000252 RID: 594 RVA: 0x00014BB8 File Offset: 0x00012DB8
		private static void DeleteTuningFiles(global::Motorola.Common.Communication.IshHandler.IOController ioController, string folder)
		{
			global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileListItemStruct> list2 = ioController.ListDirectoryContents(0, folder);
			foreach (global::Motorola.Common.Communication.Pba.FileListItemStruct fileListItemStruct in list2)
			{
				if ((byte)(fileListItemStruct.FileType & global::Motorola.Common.Communication.Pba.FileListItemStruct.TypeOfFile.File) == 1 && fileListItemStruct.FileName.EndsWith(".cpg", global::System.StringComparison.OrdinalIgnoreCase))
				{
					list.Add(folder + fileListItemStruct.FileName);
				}
			}
			ioController.DeleteFilesOrDirectory(0, list);
		}

		// Token: 0x06000253 RID: 595 RVA: 0x00014C60 File Offset: 0x00012E60
		private static bool CompareTuningVersionMatched(global::Motorola.Common.Communication.SequenceManager.DeviceInfoFetcher difether, string wrongVer)
		{
			global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
			list.Add("0904");
			list.Add("1000");
			string text = string.Empty;
			bool flag = difether.FetchTuningVersionForParadise("/opt/pcr/rel/data/tuning/app_tuning/1069.cpg", out text);
			if (flag)
			{
				string text2 = difether.CodeplugVersion.Substring(0, 4);
				wrongVer = wrongVer.Substring(0, 4);
				text = text.Substring(0, 4);
				if (text2.Equals(wrongVer, global::System.StringComparison.Ordinal) && !text2.Equals(text, global::System.StringComparison.Ordinal) && !wrongVer.Equals(text, global::System.StringComparison.Ordinal) && list.Contains(text) && global::Motorola.Common.Communication.SequenceManager.PcrTuningPathFixUpHandler.IsTuningPathFixupVersions(wrongVer))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000254 RID: 596 RVA: 0x00014D14 File Offset: 0x00012F14
		private static bool CheckIfTuningPathWrong(global::Motorola.Common.Communication.SequenceManager.DeviceInfoFetcher difether, out string wrongfolderVer)
		{
			return difether.FetchTuningVersionForParadise("/opt/pcr/rel/data/tuning/1069.cpg", out wrongfolderVer);
		}

		// Token: 0x0400017E RID: 382
		public const string WRONGTUNINGPATH = "/opt/pcr/rel/data/tuning/";

		// Token: 0x0400017F RID: 383
		public const string CORRECTTUNINGPATH = "/opt/pcr/rel/data/tuning/app_tuning/";

		// Token: 0x04000180 RID: 384
		public const string TUNINGVERSIONFILE = "1069.cpg";

		// Token: 0x04000181 RID: 385
		public const string CODEPLUGFILEEXT = ".cpg";
	}
}
