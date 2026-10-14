using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;
using fxpcommunication;
using Motorola.Common.CommonLib;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.IshHandler;
using Motorola.Common.Communication.Pba;
using Motorola.Common.Communication.SequenceManager.PbaFileProcessing;
using Motorola.Common.Communication.SequenceManager.TTS_Unpack;

namespace Motorola.Common.Communication.SequenceManager
{
	// Token: 0x0200004A RID: 74
	public class PCRWiFiSequenceManager : global::Motorola.Common.Communication.SequenceManager.PcrOtapCpsSequenceManager, global::Motorola.Common.Communication.IFlashSequenceManager
	{
		// Token: 0x06000256 RID: 598 RVA: 0x00014D3C File Offset: 0x00012F3C
		public PCRWiFiSequenceManager(global::Motorola.Common.Communication.IMessageExecutor messageExecutor, int maxPacketSize, global::fxpcommunication.FxpCommunication featureEnable) : base(messageExecutor, maxPacketSize)
		{
			this.featureEnable = featureEnable;
			this.radioCommand = base.IOController;
		}

		// Token: 0x06000257 RID: 599 RVA: 0x00014D68 File Offset: 0x00012F68
		public override global::Motorola.Common.Communication.Pba.PbaObject ReadDevice(global::Motorola.Common.Communication.Pba.PbaObject referencePba, ushort sessionID)
		{
			global::Motorola.Common.Communication.SequenceManager.PcrTuningPathFixUpHandler.PcrTuningPathFixUpSequencer(base.DeviceInfoFetcher, base.IOController);
			global::Motorola.Common.Communication.Pba.PbaObject pbaObject = this.sequenceManagerHelper.ReadDevice(referencePba, sessionID);
			int maxDataTransferSize = base.IOController.MaxDataTransferSize;
			int maxPacketSize = base.IshHandler.MaxPacketSize;
			try
			{
				global::Motorola.Common.Communication.CommonUtil.IshItemCollection codeplugInIshItemCollection = pbaObject.GetCodeplugInIshItemCollection();
				global::System.Collections.Generic.List<byte> list = new global::System.Collections.Generic.List<byte>
				{
					130
				};
				this.SetSafeMaxPacketSize();
				base.IshHandler.ReadIshPartions(codeplugInIshItemCollection, list.ToArray(), new global::Motorola.Common.Communication.IteratedProgressIndicator(base.ProgressIndicator, 0.7), null);
				pbaObject.SetCodeplug(codeplugInIshItemCollection);
				global::Motorola.Common.Communication.Pba.LanguagePackData languagePackData = base.ReadLanguagePacksInfo();
				global::Motorola.Common.Communication.Pba.LanguagePackData languagePackData2 = null;
				try
				{
					languagePackData2 = base.ReadTTSLanguagePacksInfo();
				}
				catch (global::System.Exception)
				{
				}
				pbaObject.LanguagePackData = languagePackData;
				if (languagePackData2 != null)
				{
					pbaObject.TTSLanguagePackData = languagePackData2;
				}
				double subProgressRate = 0.05;
				base.ReadFileItems(pbaObject, referencePba, subProgressRate);
			}
			finally
			{
				base.IOController.MaxDataTransferSize = maxDataTransferSize;
				base.IshHandler.MaxPacketSize = maxPacketSize;
			}
			return pbaObject;
		}

		// Token: 0x06000258 RID: 600 RVA: 0x00014EA0 File Offset: 0x000130A0
		public override global::Motorola.Common.Communication.Pba.PbaObject WriteDevice(global::Motorola.Common.Communication.Pba.PbaObject writePBA, ushort sessionID, string pcrNewPassword)
		{
			global::Motorola.Common.Communication.SequenceManager.PcrTuningPathFixUpHandler.PcrTuningPathFixUpSequencer(base.DeviceInfoFetcher, base.IOController);
			global::Motorola.Common.Communication.Pba.PbaObject result = null;
			int maxDataTransferSize = base.IOController.MaxDataTransferSize;
			int maxPacketSize = base.IshHandler.MaxPacketSize;
			try
			{
				this.SetSafeMaxPacketSize();
				result = this.sequenceManagerHelper.WriteDevice(writePBA, sessionID);
				global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileItem> fileListBySetName = writePBA.GetFileListBySetName("WelcomeBitmap");
				if (fileListBySetName != null && fileListBySetName.Count == 0)
				{
					base.WriteWelcomeBitmap(fileListBySetName);
				}
			}
			finally
			{
				base.IOController.MaxDataTransferSize = maxDataTransferSize;
				base.IshHandler.MaxPacketSize = maxPacketSize;
			}
			this.UpdateDeviceInternal(writePBA, sessionID, true);
			base.IOController.CommitOtapSession(sessionID);
			return result;
		}

		// Token: 0x06000259 RID: 601 RVA: 0x00014F70 File Offset: 0x00013170
		public void UpdateDevice(global::Motorola.Common.Communication.Pba.PbaObject writePBA, ushort sessionID)
		{
			this.UpdateDeviceInternal(writePBA, sessionID, false);
		}

		// Token: 0x0600025A RID: 602 RVA: 0x00014F80 File Offset: 0x00013180
		public void UpdateDeviceInternal(global::Motorola.Common.Communication.Pba.PbaObject writePBA, ushort sessionID, bool opened)
		{
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.WifiFileItem> list = this.GenerateFileList(writePBA);
			this.UpdateProgress(0.1, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.PrepareData);
			if (!opened)
			{
				this.radioCommand.StartOtapSession(sessionID, sessionID, false);
			}
			this.UpdateProgress(0.2, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.PrepareData);
			if (base.ProgressIndicator != null)
			{
				base.ProgressIndicator.SetCurrentScope(21, 80);
			}
			foreach (global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.WifiFileItem wifiFileItem in list)
			{
				using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream())
				{
					using (global::System.IO.FileStream fileStream = new global::System.IO.FileStream(wifiFileItem.LocalFilePath, global::System.IO.FileMode.Open))
					{
						fileStream.CopyTo(memoryStream);
						string fileName = "/opt/pcr/rel/data/otap_upgrade/" + wifiFileItem.FileName;
						this.radioCommand.FileWrite(0, fileName, memoryStream, base.ProgressIndicator, false);
					}
				}
			}
			this.UpdateProgress(0.85, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.UpgradeRadio);
			this.radioCommand.CommitWiFiSession(sessionID);
			this.UpdateProgress(1.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.UpgradeRadio);
		}

		// Token: 0x0600025B RID: 603 RVA: 0x000150F8 File Offset: 0x000132F8
		public override void CloseSession(ushort sessionID, global::Motorola.Common.Communication.CommonUtil.RadioOperation operation, bool pendingDeploy)
		{
			if (operation != global::Motorola.Common.Communication.CommonUtil.RadioOperation.Create)
			{
				if (operation == global::Motorola.Common.Communication.CommonUtil.RadioOperation.Flash || operation == global::Motorola.Common.Communication.CommonUtil.RadioOperation.Program)
				{
					if (!pendingDeploy)
					{
						ushort num;
						ushort num2;
						base.IOController.ComponentSession(32, sessionID, out num, out num2);
					}
				}
				else if (operation == global::Motorola.Common.Communication.CommonUtil.RadioOperation.Read)
				{
					this.sequenceManagerHelper.CloseSession(sessionID, operation, pendingDeploy);
				}
			}
		}

		// Token: 0x0600025C RID: 604 RVA: 0x00015164 File Offset: 0x00013364
		public bool WifiFileFilter(global::Motorola.Common.Communication.Pba.PbaObject pba, global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.ManifestObject obj)
		{
			if (obj.FileType == global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.FileType.PSMARKER)
			{
				string text = pba.CodeplugData.CPVersion;
				if (!string.IsNullOrEmpty(text))
				{
					text = text.Replace(".", "").Substring(0, 4);
					if (text.CompareTo(this.PSMARKER_SUPPORT_VER) < 0)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x0600025D RID: 605 RVA: 0x000151FC File Offset: 0x000133FC
		private global::System.Collections.Generic.List<global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.WifiFileItem> GenerateFileList(global::Motorola.Common.Communication.Pba.PbaObject testPba)
		{
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.WifiFileItem> list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.WifiFileItem>();
			global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.ManifestFile manifestFile = global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.WiFiFileProcessor.Instance.GenerateManifestFileContent(testPba, new global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.WiFiFileProcessor.WifiFileFilter(this.WifiFileFilter));
			string path = string.Empty;
			foreach (global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.ManifestObject manifestObject in manifestFile.MOList)
			{
				global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.WifiFileItem wifiFileItem = new global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.WifiFileItem();
				uint optionFlag = 0U;
				if (manifestObject.FileType == global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.FileType.FW)
				{
					manifestObject.FileNum = 1;
					using (global::System.IO.Stream stream = global::Motorola.Common.CommonLib.EnDecryptStreamHelper.Instance.CreateCryptoFlStream(manifestObject.LocalPaths[0], global::System.IO.FileAccess.Read))
					{
						global::System.Xml.XmlDocument xmlDocument = new global::System.Xml.XmlDocument();
						xmlDocument.Load(stream);
						global::System.Xml.XmlNodeList xmlNodeList = xmlDocument.SelectNodes("root/Partition/Payload");
						if (xmlNodeList != null && xmlNodeList.Count > 0)
						{
							global::System.Xml.XmlNode xmlNode = xmlNodeList[0];
							global::System.Xml.XmlAttribute xmlAttribute = xmlNode.Attributes["OptionFlags"];
							if (xmlAttribute != null)
							{
								optionFlag = global::System.Convert.ToUInt32(xmlAttribute.Value, 16);
							}
							string text = global::System.IO.Path.GetDirectoryName(manifestObject.LocalPaths[0]);
							string text2 = global::System.IO.Path.Combine(text, manifestObject.ObjectPath);
							string text3 = text2.Replace(".dat", ".img");
							using (global::System.IO.FileStream fileStream = new global::System.IO.FileStream(text3, global::System.IO.FileMode.Create))
							{
								byte[] array = global::Motorola.Common.Communication.SequenceManager.PCRWiFiSequenceManager.StringToByteArrayFastest(xmlNode.InnerText);
								fileStream.Write(array, 0, array.Length);
							}
							path = text;
							manifestObject.MessageDigest = global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.ZipFileUtility.CreateZipFile(text2, new global::System.Collections.Generic.List<string>
							{
								text3
							});
							global::System.IO.File.Delete(text3);
							wifiFileItem.LocalFilePath = text2;
							wifiFileItem.FileName = manifestObject.ObjectPath;
						}
					}
				}
				else if (manifestObject.FileType == global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.FileType.CP)
				{
					using (global::System.IO.Stream stream = global::Motorola.Common.CommonLib.EnDecryptStreamHelper.Instance.CreateCryptoFlStream(manifestObject.LocalPaths[0], global::System.IO.FileAccess.Read))
					{
						global::System.Xml.XmlDocument xmlDocument = new global::System.Xml.XmlDocument();
						xmlDocument.Load(stream);
						string text = global::System.IO.Path.GetDirectoryName(manifestObject.LocalPaths[0]);
						path = text;
						global::System.Xml.XmlNodeList xmlNodeList = xmlDocument.SelectNodes("root/Partition/Payload");
						if (xmlNodeList != null && xmlNodeList.Count > 0)
						{
							global::System.Collections.Generic.List<string> list2 = new global::System.Collections.Generic.List<string>();
							foreach (object obj in xmlNodeList)
							{
								global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
								global::System.Xml.XmlAttribute xmlAttribute = xmlNode.Attributes["OptionFlags"];
								if (xmlAttribute != null)
								{
									optionFlag = global::System.Convert.ToUInt32(xmlAttribute.Value, 16);
								}
								global::System.Xml.XmlAttribute xmlAttribute2 = xmlNode.Attributes["Path"];
								if (xmlAttribute2 != null)
								{
									string fileName = global::System.IO.Path.GetFileName(xmlAttribute2.Value);
									using (global::System.IO.FileStream fileStream = new global::System.IO.FileStream(global::System.IO.Path.Combine(text, fileName), global::System.IO.FileMode.Create))
									{
										byte[] array = global::Motorola.Common.Communication.SequenceManager.PCRWiFiSequenceManager.StringToByteArrayFastest(xmlNode.InnerText);
										fileStream.Write(array, 0, array.Length);
									}
									list2.Add(global::System.IO.Path.Combine(text, fileName));
								}
							}
							string text4 = global::System.Convert.ToString((long)((ulong)manifestObject.ObjectID), 16).PadLeft(8, '0') + ".dat";
							manifestObject.MessageDigest = global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.ZipFileUtility.CreateZipFile(global::System.IO.Path.Combine(text, text4), list2);
							list2.ForEach(delegate(string s)
							{
								global::System.IO.File.Delete(s);
							});
							manifestObject.FileNum = (ushort)list2.Count<string>();
							wifiFileItem.LocalFilePath = global::System.IO.Path.Combine(text, text4);
							wifiFileItem.FileName = text4;
						}
					}
				}
				else if (manifestObject.FileType == global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.FileType.MMI || manifestObject.FileType == global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.FileType.CH || manifestObject.FileType == global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.FileType.WC)
				{
					string text4 = global::System.Convert.ToString((long)((ulong)manifestObject.ObjectID), 16).PadLeft(8, '0').ToUpperInvariant() + ".dat";
					using (global::System.IO.Stream stream = global::Motorola.Common.CommonLib.EnDecryptStreamHelper.Instance.CreateCryptoFlStream(manifestObject.LocalPaths[0], global::System.IO.FileAccess.Read))
					{
						global::System.Xml.XmlDocument xmlDocument = new global::System.Xml.XmlDocument();
						xmlDocument.Load(stream);
						string text = global::System.IO.Path.GetDirectoryName(manifestObject.LocalPaths[0]);
						path = text;
						global::System.Xml.XmlNodeList xmlNodeList = xmlDocument.SelectNodes("root/Partition/Payload");
						if (xmlNodeList != null && xmlNodeList.Count > 0)
						{
							global::System.Collections.Generic.List<string> list2 = new global::System.Collections.Generic.List<string>();
							foreach (object obj2 in xmlNodeList)
							{
								global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj2;
								global::System.Xml.XmlAttribute xmlAttribute = xmlNode.Attributes["OptionFlags"];
								if (xmlAttribute != null)
								{
									optionFlag = global::System.Convert.ToUInt32(xmlAttribute.Value, 16);
								}
								global::System.Xml.XmlAttribute xmlAttribute2 = xmlNode.Attributes["Path"];
								if (xmlAttribute2 != null && xmlAttribute2.Value.StartsWith(manifestObject.ObjectPath, global::System.StringComparison.OrdinalIgnoreCase))
								{
									string fileName = global::System.IO.Path.GetFileName(xmlAttribute2.Value);
									using (global::System.IO.FileStream fileStream = new global::System.IO.FileStream(global::System.IO.Path.Combine(text, fileName), global::System.IO.FileMode.Create))
									{
										byte[] array = global::Motorola.Common.Communication.SequenceManager.PCRWiFiSequenceManager.StringToByteArrayFastest(xmlNode.InnerText);
										fileStream.Write(array, 0, array.Length);
									}
									list2.Add(global::System.IO.Path.Combine(text, fileName));
								}
							}
							if (manifestObject.FileType == global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.FileType.MMI)
							{
								global::Motorola.Common.Communication.Pba.FileSet fileSetBySet = testPba.GetFileSetBySet("WelcomeBitmap");
								if (fileSetBySet != null && fileSetBySet.FileItemsList.Count<global::Motorola.Common.Communication.Pba.FileItem>() > 0)
								{
									string fileName2 = global::System.IO.Path.GetFileName(fileSetBySet.FileItemsList[0].FilePath);
									global::System.IO.File.WriteAllBytes(global::System.IO.Path.Combine(text, fileName2), fileSetBySet.FileItemsList[0].FileContent);
									list2.Add(global::System.IO.Path.Combine(text, fileName2));
								}
							}
							if (list2.Count<string>() > 0)
							{
								manifestObject.MessageDigest = global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.ZipFileUtility.CreateZipFile(global::System.IO.Path.Combine(text, text4), list2);
								list2.ForEach(delegate(string s)
								{
									global::System.IO.File.Delete(s);
								});
							}
							manifestObject.FileNum = (ushort)list2.Count<string>();
							wifiFileItem.LocalFilePath = global::System.IO.Path.Combine(text, text4);
							wifiFileItem.FileName = text4;
						}
					}
				}
				else if (manifestObject.FileType == global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.FileType.PSMARKER)
				{
					string text4 = global::System.Convert.ToString((long)((ulong)manifestObject.ObjectID), 16).PadLeft(8, '0').ToUpperInvariant() + ".dat";
					global::System.Collections.Generic.List<string> list3 = new global::System.Collections.Generic.List<string>();
					foreach (string path2 in manifestObject.LocalPaths)
					{
						using (global::System.IO.Stream stream = global::Motorola.Common.CommonLib.EnDecryptStreamHelper.Instance.CreateCryptoFlStream(path2, global::System.IO.FileAccess.Read))
						{
							global::System.Xml.XmlDocument xmlDocument = new global::System.Xml.XmlDocument();
							xmlDocument.Load(stream);
							string text = global::System.IO.Path.GetDirectoryName(path2);
							path = text;
							global::System.Xml.XmlNodeList xmlNodeList = xmlDocument.SelectNodes("root/Partition/Payload");
							if (xmlNodeList != null && xmlNodeList.Count > 0)
							{
								foreach (object obj3 in xmlNodeList)
								{
									global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj3;
									global::System.Xml.XmlAttribute xmlAttribute = xmlNode.Attributes["OptionFlags"];
									if (xmlAttribute != null)
									{
										optionFlag = global::System.Convert.ToUInt32(xmlAttribute.Value, 16);
									}
									global::System.Xml.XmlAttribute xmlAttribute2 = xmlNode.Attributes["Path"];
									if (xmlAttribute2 != null && xmlAttribute2.Value.StartsWith(manifestObject.ObjectPath, global::System.StringComparison.OrdinalIgnoreCase))
									{
										string fileName = global::System.IO.Path.GetFileName(xmlAttribute2.Value);
										using (global::System.IO.FileStream fileStream = new global::System.IO.FileStream(global::System.IO.Path.Combine(text, fileName), global::System.IO.FileMode.Create))
										{
											byte[] array = global::Motorola.Common.Communication.SequenceManager.PCRWiFiSequenceManager.StringToByteArrayFastest(xmlNode.InnerText);
											fileStream.Write(array, 0, array.Length);
										}
										list3.Add(global::System.IO.Path.Combine(text, fileName));
									}
								}
							}
						}
					}
					if (list3.Count<string>() > 0)
					{
						manifestObject.MessageDigest = global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.ZipFileUtility.CreateZipFile(global::System.IO.Path.Combine(path, text4), list3);
						list3.ForEach(delegate(string s)
						{
							global::System.IO.File.Delete(s);
						});
					}
					manifestObject.FileNum = (ushort)list3.Count<string>();
					wifiFileItem.LocalFilePath = global::System.IO.Path.Combine(path, text4);
					wifiFileItem.FileName = text4;
				}
				else
				{
					string text = string.Empty;
					if (manifestObject.LocalPaths.Count<string>() > 0)
					{
						text = global::System.IO.Path.GetDirectoryName(manifestObject.LocalPaths[0]);
					}
					else
					{
						text = global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.SharedUtility.GetTempFolder();
					}
					path = text;
					global::System.Collections.Generic.List<string> list4 = new global::System.Collections.Generic.List<string>();
					if (manifestObject.FileType == global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.FileType.OB)
					{
						if (manifestObject.LocalPaths.Count<string>() > 0)
						{
							string obFilePath = manifestObject.LocalPaths[0];
							list4 = global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.OBUtility.UnpackOBFiles(obFilePath, text);
						}
					}
					else if (manifestObject.FileType == global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.FileType.TTS)
					{
						string filePath = null;
						if (manifestObject.LocalPaths.Count<string>() > 0)
						{
							filePath = manifestObject.LocalPaths[0];
						}
						list4 = global::Motorola.Common.Communication.SequenceManager.TTS_Unpack.TTSUnpackUtility.UnpackSubPack(filePath, text);
					}
					else if (manifestObject.FileType == global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.FileType.WB)
					{
						global::Motorola.Common.Communication.Pba.FileSet fileSetBySet = testPba.GetFileSetBySet("WelcomeBitmap");
						if (fileSetBySet != null && fileSetBySet.FileItemsList.Count<global::Motorola.Common.Communication.Pba.FileItem>() > 0)
						{
							list4.Add(manifestObject.LocalPaths[0]);
						}
					}
					else
					{
						for (int i = 0; i < manifestObject.LocalPaths.Count<string>(); i++)
						{
							string path3 = manifestObject.LocalPaths[i];
							string text5 = global::System.IO.Path.Combine(text, manifestObject.RemotePaths[i]);
							using (global::System.IO.Stream stream = global::Motorola.Common.CommonLib.EnDecryptStreamHelper.Instance.CreateCryptoFlStream(path3, global::System.IO.FileAccess.Read))
							{
								using (global::System.IO.FileStream fileStream2 = new global::System.IO.FileStream(text5, global::System.IO.FileMode.Create, global::System.IO.FileAccess.Write))
								{
									stream.CopyTo(fileStream2);
								}
							}
							list4.Add(text5);
						}
					}
					string text4 = global::System.Convert.ToString((long)((ulong)manifestObject.ObjectID), 16).PadLeft(8, '0') + ".dat";
					if (manifestObject.FileType == global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.FileType.TTS)
					{
						manifestObject.MessageDigest = global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.ZipFileUtility.CreateZipFolder(global::System.IO.Path.Combine(text, text4), global::System.IO.Path.Combine(text, "tts"));
					}
					else
					{
						manifestObject.MessageDigest = global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.ZipFileUtility.CreateZipFile(global::System.IO.Path.Combine(text, text4), list4);
						list4.ForEach(delegate(string s)
						{
							global::System.IO.File.Delete(s);
						});
					}
					manifestObject.FileNum = (ushort)manifestObject.LocalPaths.Count<string>();
					wifiFileItem.LocalFilePath = global::System.IO.Path.Combine(text, text4);
					wifiFileItem.FileName = text4;
				}
				manifestObject.OptionFlag = optionFlag;
				if (!manifestObject.IsEmpty())
				{
					list.Add(wifiFileItem);
				}
			}
			if (list.Count<global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.WifiFileItem>() > 0)
			{
				byte[] bytes = manifestFile.GenereateFileContent();
				global::System.IO.File.WriteAllBytes(global::System.IO.Path.Combine(path, "manifest"), bytes);
				list.Insert(0, new global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.WifiFileItem
				{
					FileName = "manifest",
					LocalFilePath = global::System.IO.Path.Combine(path, "manifest")
				});
			}
			return list;
		}

		// Token: 0x0600025E RID: 606 RVA: 0x0001608C File Offset: 0x0001428C
		public static byte[] StringToByteArrayFastest(string hex)
		{
			hex = hex.Replace("\r", "").Replace("\n", "");
			if (hex.Length % 2 == 1)
			{
				throw new global::System.Exception("The binary key cannot have an odd number of digits");
			}
			byte[] array = new byte[hex.Length >> 1];
			int count = 0;
			for (int i = 0; i < hex.Length >> 1; i++)
			{
				array[count++] = (byte)((global::Motorola.Common.Communication.SequenceManager.PCRWiFiSequenceManager.GetHexVal(hex[i << 1]) << 4) + global::Motorola.Common.Communication.SequenceManager.PCRWiFiSequenceManager.GetHexVal(hex[(i << 1) + 1]));
			}
			return array.Take(count).ToArray<byte>();
		}

		// Token: 0x0600025F RID: 607 RVA: 0x00016140 File Offset: 0x00014340
		public static int GetHexVal(char hex)
		{
			return (int)(hex - ((hex < ':') ? '0' : ((hex < 'a') ? '7' : 'W')));
		}

		// Token: 0x06000260 RID: 608 RVA: 0x0001616C File Offset: 0x0001436C
		private global::Motorola.Common.Communication.Pba.PbaObject WriteDeviceInternal(global::Motorola.Common.Communication.Pba.PbaObject writePBA, ushort sessionID)
		{
			global::Motorola.Common.Communication.Pba.PackedRadioData packedRadioData = null;
			if (base.IsParadiseOrLightFamilies(base.ProductFamily.Family))
			{
				if (base.ProgressIndicator != null)
				{
					base.ProgressIndicator.SetCurrentScope(0, 40);
				}
				packedRadioData = this.SyncCodeplug(writePBA);
				if (base.ProgressIndicator != null)
				{
					base.ProgressIndicator.SetCurrentScope(41, 100);
				}
			}
			global::Motorola.Common.Communication.Pba.PbaObject pbaObject = base.WriteDeviceInLegacyWay(writePBA, sessionID);
			if (packedRadioData != null)
			{
				pbaObject.CodeplugData = packedRadioData;
			}
			double num = base.ProgressIndicator.CurrentProgress;
			this.SyncLanguangePack(pbaObject, new global::Motorola.Common.Communication.IteratedProgressIndicator(base.ProgressIndicator, 0.12));
			num -= 0.12;
			this.SyncVoiceAnnouncementFiles(pbaObject, new global::Motorola.Common.Communication.IteratedProgressIndicator(base.ProgressIndicator, 0.08));
			num -= 0.08;
			this.SyncTTSLanguangePack(pbaObject, new global::Motorola.Common.Communication.IteratedProgressIndicator(base.ProgressIndicator, 0.05));
			num -= 0.05;
			return pbaObject;
		}

		// Token: 0x06000261 RID: 609 RVA: 0x000162D8 File Offset: 0x000144D8
		private global::Motorola.Common.Communication.Pba.PackedRadioData SyncCodeplug(global::Motorola.Common.Communication.Pba.PbaObject writePba)
		{
			global::Motorola.Common.Communication.CommonUtil.IshItemCollection radioIshItems = new global::Motorola.Common.Communication.CommonUtil.IshItemCollection();
			base.IshHandler.ReadIshPartions(radioIshItems, base.ProductFamily.ReadPartitions.ToArray(), base.ProgressIndicator, null);
			global::Motorola.Common.Communication.CommonUtil.IshItemCollection codeplugInIshItemCollection = writePba.GetCodeplugInIshItemCollection();
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IshHeader> ishTypeIDPariSetInRadio = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IshHeader>();
			radioIshItems.Headers.ToList<global::Motorola.Common.Communication.CommonUtil.IshHeader>().ForEach(delegate(global::Motorola.Common.Communication.CommonUtil.IshHeader header)
			{
				if (header.PartitionNumber == 128)
				{
					ishTypeIDPariSetInRadio.Add(header);
				}
			});
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IshHeader> ishItemsToDelete = base.GetIshItemsToDelete(writePba, ishTypeIDPariSetInRadio);
			ishItemsToDelete.ForEach(delegate(global::Motorola.Common.Communication.CommonUtil.IshHeader s)
			{
				radioIshItems.Remove(s);
			});
			foreach (global::Motorola.Common.Communication.CommonUtil.IshHeader ishHeader in codeplugInIshItemCollection.Headers)
			{
				if (ishHeader.PartitionNumber == 128)
				{
					global::Motorola.Common.Communication.CommonUtil.IshItem item = codeplugInIshItemCollection[ishHeader];
					if (radioIshItems.ContainsHeader(ishHeader))
					{
						radioIshItems.Update(ishHeader, item);
					}
					else
					{
						radioIshItems.Add(ishHeader, item);
					}
				}
			}
			global::Motorola.Common.Communication.Pba.PackedRadioData packedRadioData = new global::Motorola.Common.Communication.Pba.PackedRadioData();
			packedRadioData.Initialize(radioIshItems);
			packedRadioData.CPVersion = base.DeviceInfoFetcher.CodeplugVersion;
			return packedRadioData;
		}

		// Token: 0x06000262 RID: 610 RVA: 0x00016458 File Offset: 0x00014658
		private void SyncLanguangePack(global::Motorola.Common.Communication.Pba.PbaObject writePBA, global::Motorola.Common.Communication.IProgressIndicator subProgress)
		{
			if (base.DeviceInfoFetcher.IsInfoSupported(global::Motorola.Common.Communication.SequenceManager.DeviceInfoField.LanguagePackInfo))
			{
				global::Motorola.Common.Communication.Pba.LanguagePackData languagePackData = writePBA.LanguagePackData;
				if (languagePackData == null || languagePackData.LanguagePacks == null)
				{
					writePBA.LanguagePackData = base.ReadLanguagePacksInfo();
				}
				else
				{
					global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo> list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo>();
					foreach (global::Motorola.Common.Communication.Pba.LanguagePackBase languagePackBase in languagePackData.LanguagePacks)
					{
						global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo pcrLanguagePackInfo = languagePackBase as global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo;
						if (pcrLanguagePackInfo != null)
						{
							list.Add(pcrLanguagePackInfo);
						}
					}
					bool isBigEndianForPackID = base.IsParadiseOrLightFamilies(base.ProductFamily.Family);
					global::Motorola.Common.Communication.SequenceManager.PcrLanguageHelper pcrLanguageHelper = new global::Motorola.Common.Communication.SequenceManager.PcrLanguageHelper(base.IOController, isBigEndianForPackID);
					global::Motorola.Common.Communication.IshHandler.ContentSyncer<global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo> contentSyncer = new global::Motorola.Common.Communication.IshHandler.ContentSyncer<global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo>(pcrLanguageHelper);
					contentSyncer.Excute(list, subProgress);
					writePBA.LanguagePackData.AvailableSpace = pcrLanguageHelper.AvailabeSpace;
				}
			}
		}

		// Token: 0x06000263 RID: 611 RVA: 0x00016564 File Offset: 0x00014764
		private void SyncVoiceAnnouncementFiles(global::Motorola.Common.Communication.Pba.PbaObject writePBA, global::Motorola.Common.Communication.IProgressIndicator subProgress)
		{
			if (base.IsParadiseOrLightFamilies(base.ProductFamily.Family))
			{
				global::Motorola.Common.Communication.Pba.FileSet fileSetBySet = writePBA.GetFileSetBySet("VoiceAnnouncement");
				if (fileSetBySet == null || fileSetBySet.FileItemsList == null)
				{
					if (fileSetBySet != null)
					{
						writePBA.FileSetList.Remove(fileSetBySet);
					}
					global::Motorola.Common.Communication.Pba.FileSet fileSet = base.ReadVoiceAnnouncementFilesList(base.ProductFamily.ReadFileLists);
					if (fileSet != null)
					{
						writePBA.FileSetList.Add(fileSet);
					}
				}
				else
				{
					global::Motorola.Common.Communication.IshHandler.IContentHelper<global::Motorola.Common.Communication.Pba.FileItem> helper = new global::Motorola.Common.Communication.SequenceManager.VoiceAnnouncementFileHelper(this, base.ProductFamily.ReadFileLists);
					global::Motorola.Common.Communication.IshHandler.ContentSyncer<global::Motorola.Common.Communication.Pba.FileItem> contentSyncer = new global::Motorola.Common.Communication.IshHandler.ContentSyncer<global::Motorola.Common.Communication.Pba.FileItem>(helper);
					contentSyncer.Excute(fileSetBySet.FileItemsList, subProgress);
				}
			}
		}

		// Token: 0x06000264 RID: 612 RVA: 0x00016628 File Offset: 0x00014828
		private void SyncTTSLanguangePack(global::Motorola.Common.Communication.Pba.PbaObject writePBA, global::Motorola.Common.Communication.IProgressIndicator subProgress)
		{
			if (base.DeviceInfoFetcher.IsInfoSupported(global::Motorola.Common.Communication.SequenceManager.DeviceInfoField.TTSLanguagePackInfo))
			{
				global::Motorola.Common.Communication.Pba.LanguagePackData ttslanguagePackData = writePBA.TTSLanguagePackData;
				if (ttslanguagePackData == null || ttslanguagePackData.LanguagePacks == null)
				{
					writePBA.TTSLanguagePackData = base.ReadTTSLanguagePacksInfo();
				}
				else
				{
					global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.TTSLanguagePackInfo> list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.TTSLanguagePackInfo>();
					foreach (global::Motorola.Common.Communication.Pba.LanguagePackBase languagePackBase in ttslanguagePackData.LanguagePacks)
					{
						global::Motorola.Common.Communication.Pba.TTSLanguagePackInfo ttslanguagePackInfo = languagePackBase as global::Motorola.Common.Communication.Pba.TTSLanguagePackInfo;
						if (ttslanguagePackInfo != null)
						{
							list.Add(ttslanguagePackInfo);
						}
					}
					bool isBigEndianForPackID = base.IsParadiseOrLightFamilies(base.ProductFamily.Family);
					global::Motorola.Common.Communication.SequenceManager.TTSLanguageHelper ttslanguageHelper = new global::Motorola.Common.Communication.SequenceManager.TTSLanguageHelper(base.IOController, isBigEndianForPackID);
					global::Motorola.Common.Communication.IshHandler.ContentSyncer<global::Motorola.Common.Communication.Pba.TTSLanguagePackInfo> contentSyncer = new global::Motorola.Common.Communication.IshHandler.ContentSyncer<global::Motorola.Common.Communication.Pba.TTSLanguagePackInfo>(ttslanguageHelper);
					contentSyncer.Excute(list, subProgress);
					writePBA.TTSLanguagePackData.AvailableSpace = ttslanguageHelper.AvailabeSpace;
				}
			}
		}

		// Token: 0x06000265 RID: 613 RVA: 0x00016734 File Offset: 0x00014934
		private void SetSafeMaxPacketSize()
		{
			base.IshHandler.MaxPacketSize = 1000;
			base.IOController.MaxDataTransferSize = 1000;
		}

		// Token: 0x06000266 RID: 614 RVA: 0x00016759 File Offset: 0x00014959
		public void ValidateUpdate()
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000267 RID: 615 RVA: 0x00016761 File Offset: 0x00014961
		public bool WriteRamdownloader(string filepath)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000268 RID: 616 RVA: 0x00016769 File Offset: 0x00014969
		public global::Motorola.Common.Communication.Pba.UpdateDeviceData ReadImage(global::Motorola.Common.Communication.Pba.UpdateDeviceData images)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000269 RID: 617 RVA: 0x00016774 File Offset: 0x00014974
		private void UpdateProgress(double progress, global::Motorola.Common.Communication.CommonUtil.ProgressStatus status)
		{
			if (base.ProgressIndicator != null)
			{
				base.ProgressIndicator.UpdateProgress(progress, status);
			}
		}

		// Token: 0x04000182 RID: 386
		private const int safeMaxPacketSize = 1000;

		// Token: 0x04000183 RID: 387
		private global::Motorola.Common.Communication.IshHandler.IRadioCommand radioCommand;

		// Token: 0x04000184 RID: 388
		private string PSMARKER_SUPPORT_VER = "1005";
	}
}
