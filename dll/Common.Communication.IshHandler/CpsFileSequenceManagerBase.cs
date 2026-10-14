using System;
using System.Collections.Generic;
using System.IO;
using Motorola.Common.CommonLib;
using Motorola.Common.Communication.Pba;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.IshHandler
{
	// Token: 0x02000004 RID: 4
	public abstract class CpsFileSequenceManagerBase : global::Motorola.Common.Communication.ICpsFileSequenceManager
	{
		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000021 RID: 33 RVA: 0x00002F73 File Offset: 0x00001173
		// (set) Token: 0x06000022 RID: 34 RVA: 0x00002F7B File Offset: 0x0000117B
		protected global::Motorola.Common.Communication.IshHandler.IOController IOController
		{
			get
			{
				return this._IOController;
			}
			set
			{
				this._IOController = value;
			}
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002F8C File Offset: 0x0000118C
		public global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileItem> ReadFilesListInDir(global::Motorola.Common.Communication.Pba.FileItem dir)
		{
			this.UpdateMaxDataTransferSize();
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileItem> list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileItem>();
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileListItemStruct> list2 = this.IOController.ListDirectoryContents(dir.PartionID, dir.FilePath);
			foreach (global::Motorola.Common.Communication.Pba.FileListItemStruct fileListItemStruct in list2)
			{
				if (fileListItemStruct.FileType == global::Motorola.Common.Communication.Pba.FileListItemStruct.TypeOfFile.File)
				{
					global::Motorola.Common.Communication.Pba.FileItem item = new global::Motorola.Common.Communication.Pba.FileItem(dir.PartionID, dir.FilePath + fileListItemStruct.FileName, fileListItemStruct.FileSize, null, null, null);
					list.Add(item);
				}
			}
			return list;
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00003030 File Offset: 0x00001230
		public void DeleteFile(global::Motorola.Common.Communication.Pba.FileItem file)
		{
			global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
			list.Add(file.FilePath);
			this.IOController.DeleteFilesOrDirectory(file.PartionID, list);
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00003064 File Offset: 0x00001264
		public global::Motorola.Common.Communication.Pba.FileItem ReadFile(global::Motorola.Common.Communication.Pba.FileItem file)
		{
			this.UpdateMaxDataTransferSize();
			global::Motorola.Common.Communication.Pba.FileItem fileItem = new global::Motorola.Common.Communication.Pba.FileItem(file.PartionID, file.FilePath, 0, null, null, null);
			using (global::System.IO.MemoryStream memoryStream = this.IOController.FileRead(file.PartionID, file.FilePath, null))
			{
				fileItem.FileContent = memoryStream.ToArray();
				fileItem.FileSize = (int)memoryStream.Length;
			}
			return fileItem;
		}

		// Token: 0x06000027 RID: 39 RVA: 0x000030DC File Offset: 0x000012DC
		public void WriteFile(global::Motorola.Common.Communication.Pba.FileItem file, global::Motorola.Common.Communication.IProgressIndicator progressIndicator = null)
		{
			this.UpdateMaxDataTransferSize();
			if (file.FileContent != null && file.FileContent.Length != 0)
			{
				using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(file.FileContent))
				{
					this.IOController.FileWrite(file.PartionID, file.FilePath, memoryStream, progressIndicator, false);
					return;
				}
			}
			string path = file.URI;
			string text = file.URI + ".tmp";
			try
			{
				if (global::Motorola.Common.CommonLib.EnDecryptStreamHelper.Instance.IsEncryptedByMe(file.URI))
				{
					global::Motorola.Common.CommonLib.EnDecryptStreamHelper.Instance.DecryptFileToFile(file.URI, text);
					path = text;
				}
				else
				{
					path = file.URI;
				}
				using (global::System.IO.FileStream fileStream = new global::System.IO.FileStream(path, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read, global::System.IO.FileShare.Read))
				{
					this.IOController.FileWrite(file.PartionID, file.FilePath, fileStream, progressIndicator, false);
				}
			}
			catch (global::Motorola.Common.CustomException.CommonException)
			{
				throw;
			}
			catch (global::System.Exception systemException)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.FileIOAccessError, systemException);
			}
			finally
			{
				try
				{
					if (global::System.IO.File.Exists(text))
					{
						global::System.IO.File.Delete(text);
					}
				}
				catch
				{
				}
			}
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00003220 File Offset: 0x00001420
		public long GetFileOrDirSize(global::Motorola.Common.Communication.Pba.FileItem fileOrDir)
		{
			this.UpdateMaxDataTransferSize();
			return this.IOController.GetFileOrDirSize(fileOrDir.PartionID, fileOrDir.FilePath);
		}

		// Token: 0x06000029 RID: 41 RVA: 0x0000323F File Offset: 0x0000143F
		protected virtual void UpdateMaxDataTransferSize()
		{
		}

		// Token: 0x04000003 RID: 3
		private global::Motorola.Common.Communication.IshHandler.IOController _IOController;
	}
}
