using System;
using System.Collections.Generic;
using System.IO;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;
using System.Xml;
using Motorola.Common.CommonLib;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.Pba;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.SequenceManager
{
	// Token: 0x02000028 RID: 40
	public class PcrDeviceUpdateFileSequencer : global::Motorola.Common.Communication.SequenceManager.PcrCpsSequenceManager, global::Motorola.Common.Communication.IFlashSequenceManager
	{
		// Token: 0x06000109 RID: 265 RVA: 0x00009C88 File Offset: 0x00007E88
		public PcrDeviceUpdateFileSequencer(global::Motorola.Common.Communication.IMessageExecutor rcmpWrapper, int maxDataPayload) : base(rcmpWrapper, maxDataPayload)
		{
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(rcmpWrapper, global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
			if (maxDataPayload <= 0)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidArgument);
			}
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00009CB8 File Offset: 0x00007EB8
		public override void CloseSession(ushort sessionID, global::Motorola.Common.Communication.CommonUtil.RadioOperation operation, bool pendingDeploy)
		{
			if (!pendingDeploy)
			{
				if ((operation & global::Motorola.Common.Communication.CommonUtil.RadioOperation.Read) != global::Motorola.Common.Communication.CommonUtil.RadioOperation.Read)
				{
					base.IOController.EnterProgramMode(1, null);
				}
			}
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00009CE9 File Offset: 0x00007EE9
		public void ValidateUpdate()
		{
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.NotImplemented);
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00009CF4 File Offset: 0x00007EF4
		public virtual global::Motorola.Common.Communication.Pba.UpdateDeviceData ReadImage(global::Motorola.Common.Communication.Pba.UpdateDeviceData updateData)
		{
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
				if (pcrFileSystemMemoryImage.PartitionId == 0 || pcrFileSystemMemoryImage.FileType != global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.FILESYSTEM || pcrFileSystemMemoryImage.RadioPathName == string.Empty || pcrFileSystemMemoryImage.RadioPathName == null)
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidArgument);
				}
				global::Motorola.Common.Communication.Pba.FileItem fileItem = new global::Motorola.Common.Communication.Pba.FileItem((ushort)pcrFileSystemMemoryImage.PartitionId, pcrFileSystemMemoryImage.RadioPathName, 0, null, null, null);
				pcrFileSystemMemoryImage.FileSize = base.GetFileOrDirSize(fileItem);
				dictionary.Add(pcrFileSystemMemoryImage, fileItem);
				num2 += pcrFileSystemMemoryImage.FileSize;
			}
			foreach (global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.Pba.PcrFileSystemMemoryImage, global::Motorola.Common.Communication.Pba.FileItem> keyValuePair in dictionary)
			{
				global::Motorola.Common.Communication.Pba.PcrFileSystemMemoryImage pcrFileSystemMemoryImage = keyValuePair.Key;
				global::Motorola.Common.Communication.Pba.FileItem fileItem = keyValuePair.Value;
				byte[] array;
				if (pcrFileSystemMemoryImage.IsDirectory)
				{
					global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileItem> list = base.ReadFilesListInDir(fileItem);
					foreach (global::Motorola.Common.Communication.Pba.FileItem fileItem2 in list)
					{
						global::Motorola.Common.Communication.Pba.FileItem fileItem3 = base.ReadFile(fileItem2);
						fileItem2.FileContent = fileItem3.FileContent;
						fileItem2.FileSize = fileItem3.FileSize;
						num += (double)fileItem2.FileSize;
						if (base.ProgressIndicator != null)
						{
							double percent = num / (double)num2;
							base.ProgressIndicator.UpdateProgress(percent, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.ReadImage);
						}
					}
					global::System.Xml.XmlDocument xmlDocument = global::Motorola.Common.Communication.SequenceManager.PcrFileSystemUpdateFile.CreateUpdateFileXml(pcrFileSystemMemoryImage, list);
					array = global::System.Text.Encoding.UTF8.GetBytes(xmlDocument.OuterXml);
				}
				else
				{
					fileItem = base.ReadFile(fileItem);
					array = fileItem.FileContent;
					num += (double)fileItem.FileSize;
					double percent = num / (double)num2;
					base.ProgressIndicator.UpdateProgress(percent, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.ReadImage);
				}
				try
				{
					using (global::System.IO.FileStream fileStream = new global::System.IO.FileStream(pcrFileSystemMemoryImage.FilePath, global::System.IO.FileMode.OpenOrCreate, global::System.IO.FileAccess.Write))
					{
						fileStream.SetLength(0L);
						fileStream.Write(array, 0, array.Length);
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

		// Token: 0x0600010D RID: 269 RVA: 0x0000A070 File Offset: 0x00008270
		public bool WriteRamdownloader(string filepath)
		{
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.NotImplemented);
		}

		// Token: 0x0600010E RID: 270 RVA: 0x0000A07C File Offset: 0x0000827C
		public virtual void UpdateDevice(global::Motorola.Common.Communication.Pba.PbaObject updateData, ushort sessionID)
		{
			if (base.DeviceInfoFetcher.GetDeviceInfo<bool>(global::Motorola.Common.Communication.SequenceManager.DeviceInfoField.IsLowBattery))
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_Pcr_BatteryLevelLow);
			}
			try
			{
				global::Motorola.Common.Communication.Pba.UpdateDeviceData updateDeviceData;
				if (updateData.PreUpdateData.MemoryImages != null && updateData.PreUpdateData.MemoryImages.Count > 0)
				{
					updateDeviceData = updateData.PreUpdateData;
				}
				else
				{
					updateDeviceData = updateData.UpdateData;
				}
				base.WriteValidation(updateData);
				if (updateDeviceData == null || updateDeviceData.MemoryImages.Count == 0 || updateDeviceData.MemoryImages == null)
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidArgument);
				}
				base.IOController.EnterProgramMode(0, null);
				base.IOController.RadioUpdateControl(global::Motorola.Common.Communication.UpdateControlAction.UpdateStatus);
				if (base.ProgressIndicator != null)
				{
					base.ProgressIndicator.UpdateProgress(0.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.WriteImage);
				}
				global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.RadioImage> memoryImages = updateDeviceData.MemoryImages;
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
				base.IOController.EnterProgramMode(1, null);
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

		// Token: 0x0600010F RID: 271 RVA: 0x0000A2F4 File Offset: 0x000084F4
		public override bool UpdateProgrammingStatus(global::Motorola.Common.Communication.CommonUtil.ProgrammingStatus status, ushort sessionID)
		{
			return base.IOController.UpdateProgrammingStatus(status, sessionID);
		}

		// Token: 0x06000110 RID: 272 RVA: 0x0000A313 File Offset: 0x00008513
		protected virtual void AfterWriteImages()
		{
			base.IOController.RadioUpdateControl(global::Motorola.Common.Communication.UpdateControlAction.CommitUpdate);
		}

		// Token: 0x06000111 RID: 273 RVA: 0x0000A324 File Offset: 0x00008524
		private void WriteUpdateFileXml(string fileName, global::Motorola.Common.Communication.IProgressIndicator progressIndicator)
		{
			this.UpdateMaxDataTransferSize();
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

		// Token: 0x06000112 RID: 274 RVA: 0x0000A37C File Offset: 0x0000857C
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
									base.IOController.FileWrite((ushort)num, fileName2, memoryStream, new global::Motorola.Common.Communication.IteratedProgressIndicator(progressIndicator, progressRate), false);
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06000113 RID: 275 RVA: 0x0000AA78 File Offset: 0x00008C78
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

		// Token: 0x06000114 RID: 276 RVA: 0x0000ACA0 File Offset: 0x00008EA0
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
	}
}
