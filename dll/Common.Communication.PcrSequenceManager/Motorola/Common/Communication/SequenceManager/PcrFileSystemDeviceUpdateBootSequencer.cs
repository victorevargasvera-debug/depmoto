using System;
using System.Collections.Generic;
using System.IO;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Xml;
using Motorola.Common.CommonLib;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.Pba;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.SequenceManager
{
	// Token: 0x02000025 RID: 37
	public class PcrFileSystemDeviceUpdateBootSequencer : global::Motorola.Common.Communication.SequenceManager.PcrCpsSequenceManager, global::Motorola.Common.Communication.IFlashSequenceManager
	{
		// Token: 0x060000F5 RID: 245 RVA: 0x00008BB8 File Offset: 0x00006DB8
		public PcrFileSystemDeviceUpdateBootSequencer(global::Motorola.Common.Communication.IMessageExecutor rcmpWrapper, int maxDataPayload) : base(rcmpWrapper, maxDataPayload)
		{
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(rcmpWrapper, global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
			if (maxDataPayload <= 0)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidArgument);
			}
			this.m_maxDataPayload = 9568256;
			this.BootOperations = new global::Motorola.Common.Communication.SequenceManager.PcrFileSystemBootOperations(rcmpWrapper, this.m_maxDataPayload);
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00008C08 File Offset: 0x00006E08
		public override void CloseSession(ushort sessionID, global::Motorola.Common.Communication.CommonUtil.RadioOperation operation, bool pendingDeploy)
		{
			if (!pendingDeploy)
			{
				base.IOController.ResetRadio();
			}
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00008C29 File Offset: 0x00006E29
		public void ValidateUpdate()
		{
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.NotImplemented);
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00008C34 File Offset: 0x00006E34
		public global::Motorola.Common.Communication.Pba.UpdateDeviceData ReadImage(global::Motorola.Common.Communication.Pba.UpdateDeviceData updateData)
		{
			if (updateData == null)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidArgument);
			}
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.RadioImage> memoryImages = updateData.MemoryImages;
			double num = 0.0;
			long num2 = 0L;
			global::System.Collections.Generic.Dictionary<global::Motorola.Common.Communication.Pba.PcrFileSystemMemoryImage, global::Motorola.Common.Communication.Pba.FileItem> dictionary = new global::System.Collections.Generic.Dictionary<global::Motorola.Common.Communication.Pba.PcrFileSystemMemoryImage, global::Motorola.Common.Communication.Pba.FileItem>();
			if (base.ProgressIndicator != null)
			{
				base.ProgressIndicator.UpdateProgress(0.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.ReadImage);
			}
			foreach (global::Motorola.Common.Communication.Pba.RadioImage radioImage in memoryImages)
			{
				global::Motorola.Common.Communication.Pba.PcrFileSystemMemoryImage pcrFileSystemMemoryImage = (global::Motorola.Common.Communication.Pba.PcrFileSystemMemoryImage)radioImage;
				if (!pcrFileSystemMemoryImage.IsDirectory)
				{
					if (pcrFileSystemMemoryImage.PartitionId == 0 || pcrFileSystemMemoryImage.FileType != global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.FILESYSTEM || pcrFileSystemMemoryImage.RadioPathName == string.Empty || pcrFileSystemMemoryImage.RadioPathName == null)
					{
						throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidArgument);
					}
					global::Motorola.Common.Communication.Pba.FileItem fileItem = new global::Motorola.Common.Communication.Pba.FileItem((ushort)pcrFileSystemMemoryImage.PartitionId, pcrFileSystemMemoryImage.RadioPathName, 0, null, null, null);
					pcrFileSystemMemoryImage.FileSize = this.GetFileSize(fileItem);
					dictionary.Add(pcrFileSystemMemoryImage, fileItem);
					num2 += pcrFileSystemMemoryImage.FileSize;
				}
			}
			foreach (global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.Pba.PcrFileSystemMemoryImage, global::Motorola.Common.Communication.Pba.FileItem> keyValuePair in dictionary)
			{
				global::Motorola.Common.Communication.Pba.PcrFileSystemMemoryImage pcrFileSystemMemoryImage = keyValuePair.Key;
				global::Motorola.Common.Communication.Pba.FileItem fileItem = keyValuePair.Value;
				fileItem = this.ReadFileSystem(fileItem);
				byte[] fileContent = fileItem.FileContent;
				num += (double)fileItem.FileSize;
				if (base.ProgressIndicator != null)
				{
					double num3 = num / (double)num2;
					base.ProgressIndicator.UpdateProgress(0.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.ReadImage);
				}
				try
				{
					using (global::System.IO.FileStream fileStream = new global::System.IO.FileStream(pcrFileSystemMemoryImage.FilePath, global::System.IO.FileMode.OpenOrCreate, global::System.IO.FileAccess.Write))
					{
						fileStream.SetLength(0L);
						fileStream.Write(fileContent, 0, fileContent.Length);
					}
					global::System.Security.AccessControl.FileSecurity accessControl = global::System.IO.File.GetAccessControl(pcrFileSystemMemoryImage.FilePath);
					global::System.Security.Principal.SecurityIdentifier identity = new global::System.Security.Principal.SecurityIdentifier(global::System.Security.Principal.WellKnownSidType.WorldSid, null);
					accessControl.AddAccessRule(new global::System.Security.AccessControl.FileSystemAccessRule(identity, global::System.Security.AccessControl.FileSystemRights.ReadData | global::System.Security.AccessControl.FileSystemRights.ReadExtendedAttributes | global::System.Security.AccessControl.FileSystemRights.ReadAttributes | global::System.Security.AccessControl.FileSystemRights.Delete | global::System.Security.AccessControl.FileSystemRights.ReadPermissions, global::System.Security.AccessControl.AccessControlType.Allow));
					global::System.IO.File.SetAccessControl(pcrFileSystemMemoryImage.FilePath, accessControl);
				}
				catch
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.FailedToWriteFile);
				}
			}
			return updateData;
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00008F04 File Offset: 0x00007104
		public bool WriteRamdownloader(string filepath)
		{
			if (string.IsNullOrEmpty(filepath))
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidArgument);
			}
			this.ramdownloaderFile = filepath;
			this.BootOperations.WriteRamDownloader(this.ramdownloaderFile, null);
			return true;
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00008F46 File Offset: 0x00007146
		public void ResetRadioBoot()
		{
			this.BootOperations.ResetRadioBoot();
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00008F55 File Offset: 0x00007155
		public virtual void PreWriteImages()
		{
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00008F58 File Offset: 0x00007158
		public virtual void AfterWriteImages()
		{
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00008F5C File Offset: 0x0000715C
		public void UpdateDevice(global::Motorola.Common.Communication.Pba.PbaObject pbaObject, ushort sessionID)
		{
			try
			{
				if (pbaObject == null)
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidArgument);
				}
				global::Motorola.Common.Communication.Pba.UpdateDeviceData updateData = pbaObject.UpdateData;
				if (updateData == null || updateData.MemoryImages.Count == 0 || updateData.MemoryImages == null)
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidArgument);
				}
				this.PreWriteImages();
				if (base.ProgressIndicator != null)
				{
					base.ProgressIndicator.UpdateProgress(0.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.WriteImage);
				}
				global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.RadioImage> memoryImages = updateData.MemoryImages;
				long num = 0L;
				foreach (global::Motorola.Common.Communication.Pba.RadioImage radioImage in memoryImages)
				{
					global::Motorola.Common.Communication.Pba.PcrFileSystemMemoryImage pcrFileSystemMemoryImage = (global::Motorola.Common.Communication.Pba.PcrFileSystemMemoryImage)radioImage;
					if (!global::System.IO.File.Exists(pcrFileSystemMemoryImage.FilePath))
					{
						throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.UpdateDevice_Pcr_Missing_Update_File);
					}
					global::System.IO.FileInfo fileInfo = new global::System.IO.FileInfo(pcrFileSystemMemoryImage.FilePath);
					pcrFileSystemMemoryImage.FileSize = fileInfo.Length;
					num += fileInfo.Length;
				}
				foreach (global::Motorola.Common.Communication.Pba.RadioImage radioImage2 in memoryImages)
				{
					global::Motorola.Common.Communication.Pba.PcrFileSystemMemoryImage pcrFileSystemMemoryImage = (global::Motorola.Common.Communication.Pba.PcrFileSystemMemoryImage)radioImage2;
					double progressRate = (double)pcrFileSystemMemoryImage.FileSize / (double)num;
					this.WriteUpdateFileXml(pcrFileSystemMemoryImage.FilePath, new global::Motorola.Common.Communication.IteratedProgressIndicator(base.ProgressIndicator, progressRate));
				}
				this.AfterWriteImages();
				base.IOController.ResetRadio();
				if (base.ProgressIndicator != null)
				{
					base.ProgressIndicator.UpdateProgress(1.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.WriteImage);
				}
			}
			finally
			{
				global::System.GC.Collect();
				global::System.GC.WaitForPendingFinalizers();
			}
		}

		// Token: 0x060000FE RID: 254 RVA: 0x0000916C File Offset: 0x0000736C
		private global::Motorola.Common.Communication.Pba.FileItem ReadFileSystem(global::Motorola.Common.Communication.Pba.FileItem file)
		{
			global::Motorola.Common.Communication.Pba.FileItem fileItem = new global::Motorola.Common.Communication.Pba.FileItem(file.PartionID, file.FilePath, 0, null, null, null);
			using (global::System.IO.MemoryStream memoryStream = base.IOController.FileRead(file.PartionID, file.FilePath, null))
			{
				fileItem.FileContent = memoryStream.ToArray();
				fileItem.FileSize = (int)memoryStream.Length;
			}
			return fileItem;
		}

		// Token: 0x060000FF RID: 255 RVA: 0x000091F0 File Offset: 0x000073F0
		private void WriteUpdateFileXml(string fileName, global::Motorola.Common.Communication.IProgressIndicator progressIndicator)
		{
			try
			{
				this.WriteDataToRadio(fileName, progressIndicator, this.GetXmlNodeCount(fileName));
			}
			catch (global::System.OutOfMemoryException)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.UpdateDevice_Pcr_OutOfMemory);
			}
			catch
			{
				throw;
			}
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00009240 File Offset: 0x00007440
		private void WriteDataToRadio(string fileName, global::Motorola.Common.Communication.IProgressIndicator progressIndicator, int nodes)
		{
			bool flag = false;
			bool flag2 = false;
			bool flag3 = false;
			double progressRate = 1.0 / (double)nodes;
			using (global::System.IO.Stream stream = global::Motorola.Common.CommonLib.EnDecryptStreamHelper.Instance.CreateCryptoFlStream(fileName, global::System.IO.FileAccess.Read))
			{
				using (global::System.Xml.XmlTextReader xmlTextReader = new global::System.Xml.XmlTextReader(stream))
				{
					while (xmlTextReader.Read())
					{
						if (xmlTextReader.Name == "Partition")
						{
							if (xmlTextReader.MoveToFirstAttribute())
							{
								if (xmlTextReader.MoveToAttribute("Type") && xmlTextReader.HasValue)
								{
									string value = xmlTextReader.Value;
									if (value != null)
									{
										if (!(value == "FileSystem"))
										{
											if (!(value == "RawNAND"))
											{
												if (value == "FTL")
												{
													flag2 = false;
													flag = true;
													flag3 = false;
												}
											}
											else
											{
												flag2 = false;
												flag = false;
												flag3 = true;
											}
										}
										else
										{
											flag2 = true;
											flag = false;
											flag3 = false;
										}
									}
								}
							}
						}
						else if (xmlTextReader.Name == "Payload" && flag3)
						{
							if (xmlTextReader.MoveToFirstAttribute())
							{
								uint num = 0U;
								uint start_ID = 0U;
								uint end_ID = 0U;
								uint optionFlag = 0U;
								string text = string.Empty;
								byte[] array = null;
								string text2 = string.Empty;
								if (xmlTextReader.MoveToAttribute("ID") && xmlTextReader.HasValue)
								{
									num = global::System.Convert.ToUInt32(xmlTextReader.Value, 16);
								}
								if (xmlTextReader.MoveToAttribute("Start_ID") && xmlTextReader.HasValue)
								{
									start_ID = global::System.Convert.ToUInt32(xmlTextReader.Value, 16);
								}
								if (xmlTextReader.MoveToAttribute("End_ID") && xmlTextReader.HasValue)
								{
									end_ID = global::System.Convert.ToUInt32(xmlTextReader.Value, 16);
								}
								if (xmlTextReader.MoveToAttribute("OptionFlags") && xmlTextReader.HasValue)
								{
									optionFlag = global::System.Convert.ToUInt32(xmlTextReader.Value, 16);
								}
								if (xmlTextReader.MoveToAttribute("MD5_CheckSUM") && xmlTextReader.HasValue)
								{
									text = xmlTextReader.Value;
								}
								if (xmlTextReader.MoveToElement())
								{
									array = this.GetData(fileName, xmlTextReader);
									text2 = global::Motorola.Common.Communication.SequenceManager.PcrFileSystemUpdateFile.GetMd5(array);
								}
								if (!string.Equals(text.ToUpperInvariant(), text2.ToUpperInvariant(), global::System.StringComparison.Ordinal))
								{
									throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.UpdateDevice_Pcr_CheckSumFailure);
								}
								base.IOController.NandDelete((ushort)num, optionFlag, start_ID, end_ID, new global::Motorola.Common.Communication.IteratedProgressIndicator(progressIndicator, progressRate));
								using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(array))
								{
									base.IOController.NandWrite((ushort)num, memoryStream, optionFlag, start_ID, end_ID, new global::Motorola.Common.Communication.IteratedProgressIndicator(progressIndicator, progressRate));
								}
							}
						}
						else if (xmlTextReader.Name == "Payload" && flag)
						{
							if (xmlTextReader.MoveToFirstAttribute())
							{
								uint num = 0U;
								uint start_ID = 0U;
								uint end_ID = 0U;
								uint optionFlag = 0U;
								string text = string.Empty;
								byte[] array = null;
								string text2 = string.Empty;
								if (xmlTextReader.MoveToAttribute("ID") && xmlTextReader.HasValue)
								{
									num = global::System.Convert.ToUInt32(xmlTextReader.Value, 16);
								}
								if (xmlTextReader.MoveToAttribute("Start_ID") && xmlTextReader.HasValue)
								{
									start_ID = global::System.Convert.ToUInt32(xmlTextReader.Value, 16);
								}
								if (xmlTextReader.MoveToAttribute("End_ID") && xmlTextReader.HasValue)
								{
									end_ID = global::System.Convert.ToUInt32(xmlTextReader.Value, 16);
								}
								if (xmlTextReader.MoveToAttribute("OptionFlags") && xmlTextReader.HasValue)
								{
									optionFlag = global::System.Convert.ToUInt32(xmlTextReader.Value, 16);
								}
								if (xmlTextReader.MoveToAttribute("MD5_CheckSUM") && xmlTextReader.HasValue)
								{
									text = xmlTextReader.Value;
								}
								if (xmlTextReader.MoveToElement())
								{
									array = this.GetData(fileName, xmlTextReader);
									text2 = global::Motorola.Common.Communication.SequenceManager.PcrFileSystemUpdateFile.GetMd5(array);
								}
								if (!string.Equals(text.ToUpperInvariant(), text2.ToUpperInvariant(), global::System.StringComparison.Ordinal))
								{
									throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.UpdateDevice_Pcr_CheckSumFailure);
								}
								using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(array))
								{
									base.IOController.FtlWrite((ushort)num, memoryStream, optionFlag, start_ID, end_ID, new global::Motorola.Common.Communication.IteratedProgressIndicator(progressIndicator, progressRate));
								}
							}
						}
						else if (xmlTextReader.Name == "Payload" && flag2)
						{
							if (xmlTextReader.MoveToFirstAttribute())
							{
								uint num = 0U;
								string fileName2 = string.Empty;
								string text = string.Empty;
								byte[] array = null;
								string text2 = string.Empty;
								if (xmlTextReader.MoveToAttribute("ID") && xmlTextReader.HasValue)
								{
									num = global::System.Convert.ToUInt32(xmlTextReader.Value, 16);
								}
								if (xmlTextReader.MoveToAttribute("Path") && xmlTextReader.HasValue)
								{
									fileName2 = xmlTextReader.Value;
								}
								if (xmlTextReader.MoveToAttribute("OptionFlags") && xmlTextReader.HasValue)
								{
									uint optionFlag = global::System.Convert.ToUInt32(xmlTextReader.Value, 16);
								}
								if (xmlTextReader.MoveToAttribute("MD5_CheckSUM") && xmlTextReader.HasValue)
								{
									text = xmlTextReader.Value;
								}
								if (xmlTextReader.MoveToElement())
								{
									array = this.GetData(fileName, xmlTextReader);
									text2 = global::Motorola.Common.Communication.SequenceManager.PcrFileSystemUpdateFile.GetMd5(array);
								}
								if (!string.Equals(text.ToUpperInvariant(), text2.ToUpperInvariant(), global::System.StringComparison.Ordinal))
								{
									throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.UpdateDevice_Pcr_CheckSumFailure);
								}
								using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(array))
								{
									base.IOController.FileDelete((ushort)num, fileName2);
									base.IOController.FileCreate((ushort)num, fileName2);
									base.IOController.FileWrite((ushort)num, fileName2, memoryStream, new global::Motorola.Common.Communication.IteratedProgressIndicator(progressIndicator, progressRate), false);
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00009978 File Offset: 0x00007B78
		private int GetXmlNodeCount(string fileName)
		{
			bool flag = false;
			bool flag2 = false;
			bool flag3 = false;
			int num = 0;
			using (global::System.IO.Stream stream = global::Motorola.Common.CommonLib.EnDecryptStreamHelper.Instance.CreateCryptoFlStream(fileName, global::System.IO.FileAccess.Read))
			{
				using (global::System.Xml.XmlTextReader xmlTextReader = new global::System.Xml.XmlTextReader(stream))
				{
					while (xmlTextReader.Read())
					{
						if (xmlTextReader.Name == "Partition")
						{
							if (xmlTextReader.MoveToFirstAttribute())
							{
								if (xmlTextReader.MoveToAttribute("Type") && xmlTextReader.HasValue)
								{
									string value = xmlTextReader.Value;
									if (value != null)
									{
										if (!(value == "FileSystem"))
										{
											if (!(value == "RawNAND"))
											{
												if (value == "FTL")
												{
													flag2 = false;
													flag = true;
													flag3 = false;
												}
											}
											else
											{
												flag2 = false;
												flag = false;
												flag3 = true;
											}
										}
										else
										{
											flag2 = true;
											flag = false;
											flag3 = false;
										}
									}
								}
							}
						}
						else if (xmlTextReader.Name == "Payload" && flag3)
						{
							if (xmlTextReader.MoveToFirstAttribute())
							{
								num++;
								xmlTextReader.Skip();
							}
						}
						else if (xmlTextReader.Name == "Payload" && flag)
						{
							if (xmlTextReader.MoveToFirstAttribute())
							{
								num++;
								xmlTextReader.Skip();
							}
						}
						else if (xmlTextReader.Name == "Payload" && flag2)
						{
							if (xmlTextReader.MoveToFirstAttribute())
							{
								num++;
								xmlTextReader.Skip();
							}
						}
					}
				}
			}
			return num;
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00009BA0 File Offset: 0x00007DA0
		private byte[] GetData(string fileName, global::System.Xml.XmlTextReader reader)
		{
			long num = new global::System.IO.FileInfo(fileName).Length / 2L;
			byte[] array = new byte[num];
			int num2 = 0;
			int num3;
			do
			{
				num3 = reader.ReadBinHex(array, num2, 1);
				if (num3 == 1)
				{
					num2++;
				}
			}
			while (num3 == 1);
			byte[] array2 = new byte[num2];
			global::System.Array.Copy(array, 0, array2, 0, num2);
			return array2;
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00009C10 File Offset: 0x00007E10
		private long GetFileSize(global::Motorola.Common.Communication.Pba.FileItem file)
		{
			return base.IOController.GetFileOrDirSize(file.PartionID, file.FilePath);
		}

		// Token: 0x040000A2 RID: 162
		protected int m_maxDataPayload;

		// Token: 0x040000A3 RID: 163
		protected global::Motorola.Common.Communication.SequenceManager.PcrFileSystemBootOperations BootOperations;

		// Token: 0x040000A4 RID: 164
		private string ramdownloaderFile;
	}
}
