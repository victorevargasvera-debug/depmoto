using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Xml;
using AcpCryptoLib;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication
{
	// Token: 0x02000015 RID: 21
	internal class LanguagePackInfo
	{
		// Token: 0x1700000D RID: 13
		// (get) Token: 0x060000E7 RID: 231 RVA: 0x000082C2 File Offset: 0x000064C2
		public string LangPackXferFolderPath
		{
			get
			{
				return this.langPackXferFolderPath;
			}
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x000082CC File Offset: 0x000064CC
		public LanguagePackInfo(string radioProductName, global::Motorola.Common.Communication.CommonUtil.ModelType modelType, string packageFilePath)
		{
			if (string.IsNullOrEmpty(packageFilePath))
			{
				this.targetLanguage = "English";
				return;
			}
			global::System.Xml.XmlDocument doc = null;
			try
			{
				global::AcpCryptoLib.AcpXMLEncryptDecrypt acpXMLEncryptDecrypt = new global::AcpCryptoLib.AcpXMLEncryptDecrypt();
				doc = acpXMLEncryptDecrypt.DecryptXMLFile(packageFilePath);
			}
			catch (global::System.Exception)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.LanguagePack_Astro_InvalidData);
			}
			this.langPackXferFolderPath = this.langPackXferFolderPath + global::System.Guid.NewGuid().ToString().Replace("-", "") + "\\";
			if (!global::System.IO.Directory.Exists(this.langPackXferFolderPath))
			{
				global::System.IO.Directory.CreateDirectory(this.langPackXferFolderPath);
			}
			this.lpkFilePath = this.langPackXferFolderPath + global::System.IO.Path.GetFileName(packageFilePath);
			if (!global::System.IO.File.Exists(this.lpkFilePath))
			{
				global::System.IO.File.Copy(packageFilePath, this.lpkFilePath);
			}
			this.ReadXMLFile(doc, modelType, radioProductName);
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x000083E4 File Offset: 0x000065E4
		private string WriteManifestFile(string path, string content)
		{
			string result;
			try
			{
				string text = path + "k";
				global::System.Text.UTF8Encoding utf8Encoding = new global::System.Text.UTF8Encoding();
				byte[] bytes = utf8Encoding.GetBytes(content);
				this.WriteFile(bytes, text, true, global::System.IO.FileMode.Create);
				result = text;
			}
			catch
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.LanguagePack_Astro_Write_LangManifestFile_Failed);
			}
			return result;
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00008438 File Offset: 0x00006638
		private void WriteFile(byte[] writeBuffer, string filePath, bool encrypt, global::System.IO.FileMode fileMode)
		{
			new global::System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
			if (writeBuffer == null)
			{
				throw new global::System.ArgumentNullException("writeBuffer");
			}
			try
			{
				using (global::System.IO.FileStream fileStream = new global::System.IO.FileStream(filePath, fileMode, global::System.IO.FileAccess.Write))
				{
					using (global::System.IO.BinaryWriter binaryWriter = new global::System.IO.BinaryWriter(fileStream, global::System.Text.Encoding.UTF8))
					{
						if (encrypt && fileMode != global::System.IO.FileMode.Append)
						{
							binaryWriter.Write(new global::AcpCryptoLib.AcpEncryptDecrypt().Encrypt(writeBuffer));
						}
						else
						{
							binaryWriter.Write(writeBuffer);
						}
					}
				}
			}
			catch (global::System.Exception)
			{
				throw;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x060000EB RID: 235 RVA: 0x000084D8 File Offset: 0x000066D8
		public string TargetLanguage
		{
			get
			{
				return this.targetLanguage;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x060000EC RID: 236 RVA: 0x000084E0 File Offset: 0x000066E0
		public string LpkFilePath
		{
			get
			{
				return this.lpkFilePath;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x060000ED RID: 237 RVA: 0x000084E8 File Offset: 0x000066E8
		public string ManifestFilePath
		{
			get
			{
				return this.manifestFilePath;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x060000EE RID: 238 RVA: 0x000084F0 File Offset: 0x000066F0
		public string ManifestFile
		{
			get
			{
				return this.manifestFile;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x060000EF RID: 239 RVA: 0x000084F8 File Offset: 0x000066F8
		public string NewLPSupportFile
		{
			get
			{
				return this.newLPSupportFile;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x060000F0 RID: 240 RVA: 0x00008500 File Offset: 0x00006700
		public string LangPackLanguageId
		{
			get
			{
				return this.langPackLanguageId;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x060000F1 RID: 241 RVA: 0x00008508 File Offset: 0x00006708
		public bool GlobalCriticalFlag
		{
			get
			{
				return this.globalCriticalFlag;
			}
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00008510 File Offset: 0x00006710
		private void ReadXMLFile(global::System.Xml.XmlDocument doc, global::Motorola.Common.Communication.CommonUtil.ModelType modelType, string radioProductName)
		{
			try
			{
				global::System.Xml.XmlNode documentElement = doc.DocumentElement;
				global::System.Xml.XmlNode xmlNode = documentElement.SelectSingleNode("//lpack/idtag/id");
				if (xmlNode == null || string.IsNullOrEmpty(xmlNode.InnerText))
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.LanguagePack_Astro_One_or_more_files_in_the_RadioLanguagePacks_is_missing);
				}
				this.langPackLanguageId = xmlNode.InnerText;
				string str = string.Empty;
				bool flag = modelType == global::Motorola.Common.Communication.CommonUtil.ModelType.Mobile;
				if (flag)
				{
					str = "mobile";
				}
				else
				{
					str = "portable";
				}
				string xpath = "//lpack/manifest/" + str + "/model";
				global::System.Xml.XmlNodeList xmlNodeList = documentElement.SelectNodes(xpath);
				string a = string.Empty;
				global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
				if (xmlNodeList == null)
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.LanguagePack_Astro_One_or_more_files_in_the_RadioLanguagePacks_is_missing);
				}
				foreach (object obj in xmlNodeList)
				{
					global::System.Xml.XmlNode xmlNode2 = (global::System.Xml.XmlNode)obj;
					a = ((global::System.Xml.XmlElement)xmlNode2).GetAttribute("id");
					if (a == radioProductName)
					{
						using (global::System.Collections.IEnumerator enumerator2 = xmlNode2.ChildNodes.GetEnumerator())
						{
							while (enumerator2.MoveNext())
							{
								object obj2 = enumerator2.Current;
								global::System.Xml.XmlNode xmlNode3 = (global::System.Xml.XmlNode)obj2;
								list.Add(xmlNode3.InnerText);
							}
							break;
						}
					}
				}
				if (list.Count == 0)
				{
					xpath = "//lpack/manifest/" + str + "/model[@id='Default']";
					global::System.Xml.XmlNode xmlNode4 = documentElement.SelectSingleNode(xpath);
					if (xmlNode4 != null)
					{
						foreach (object obj3 in xmlNode4.ChildNodes)
						{
							global::System.Xml.XmlNode xmlNode5 = (global::System.Xml.XmlNode)obj3;
							list.Add(xmlNode5.InnerText);
						}
					}
				}
				if (list.Count == 0)
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.LanguagePack_Astro_One_or_more_files_in_the_RadioLanguagePacks_is_missing);
				}
				this.data = new global::System.Collections.Generic.Dictionary<string, global::Motorola.Common.Communication.LanguagePackInfo.FileData>();
				string text = string.Empty;
				string text2 = string.Empty;
				string text3 = string.Empty;
				int size = 0;
				bool flag2 = false;
				this.globalCriticalFlag = false;
				xmlNodeList = documentElement.SelectNodes("//lpack/data/file");
				foreach (object obj4 in xmlNodeList)
				{
					global::System.Xml.XmlNode xmlNode6 = (global::System.Xml.XmlNode)obj4;
					text3 = ((global::System.Xml.XmlElement)xmlNode6).GetAttribute("id");
					if (list.Contains(text3))
					{
						foreach (object obj5 in xmlNode6.ChildNodes)
						{
							global::System.Xml.XmlNode xmlNode7 = (global::System.Xml.XmlNode)obj5;
							if (xmlNode7.Name == "filename" && !string.IsNullOrEmpty(xmlNode7.InnerText))
							{
								text = xmlNode7.InnerText;
							}
							if (xmlNode7.Name == "size" && !string.IsNullOrEmpty(xmlNode7.InnerText))
							{
								text2 = xmlNode7.InnerText;
								size = global::System.Convert.ToInt32(text2);
							}
							if (xmlNode7.Name == "criticalUpdate" && !string.IsNullOrEmpty(xmlNode7.InnerText))
							{
								string innerText = xmlNode7.InnerText;
								flag2 = global::System.Convert.ToBoolean(innerText);
								if (flag2)
								{
									this.globalCriticalFlag = true;
								}
							}
						}
						if (text == string.Empty || text2 == string.Empty)
						{
							throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.LanguagePack_Astro_One_or_more_files_in_the_RadioLanguagePacks_is_missing);
						}
						global::Motorola.Common.Communication.LanguagePackInfo.FileData value = new global::Motorola.Common.Communication.LanguagePackInfo.FileData(text, size, flag2);
						this.data.Add(text3, value);
					}
				}
				if (this.data.Count == 0 || this.data.Count != list.Count)
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.LanguagePack_Astro_One_or_more_files_in_the_RadioLanguagePacks_is_missing);
				}
				this.manifestFilePath = this.WriteManifestFile(this.langPackXferFolderPath + this.manifestFile, string.Empty);
			}
			catch
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.LanguagePack_Astro_InvalidData);
			}
		}

		// Token: 0x04000076 RID: 118
		private string targetLanguage = string.Empty;

		// Token: 0x04000077 RID: 119
		private string langPackLanguageId;

		// Token: 0x04000078 RID: 120
		private string langPackXferFolderPath = global::System.IO.Path.GetTempPath();

		// Token: 0x04000079 RID: 121
		public global::System.Collections.Generic.Dictionary<string, global::Motorola.Common.Communication.LanguagePackInfo.FileData> data = new global::System.Collections.Generic.Dictionary<string, global::Motorola.Common.Communication.LanguagePackInfo.FileData>();

		// Token: 0x0400007A RID: 122
		private string manifestFilePath;

		// Token: 0x0400007B RID: 123
		private string manifestFile = "lang.mnf";

		// Token: 0x0400007C RID: 124
		private string newLPSupportFile = "lang.new";

		// Token: 0x0400007D RID: 125
		private string lpkFilePath;

		// Token: 0x0400007E RID: 126
		private bool globalCriticalFlag;

		// Token: 0x02000016 RID: 22
		public class FileData
		{
			// Token: 0x060000F3 RID: 243 RVA: 0x0000898C File Offset: 0x00006B8C
			public FileData(string name, int size, bool criticalUpdate)
			{
				this.fileName = name;
				this.fileSize = size;
				this.criticalFlag = criticalUpdate;
			}

			// Token: 0x0400007F RID: 127
			public string fileName;

			// Token: 0x04000080 RID: 128
			public int fileSize;

			// Token: 0x04000081 RID: 129
			private bool criticalFlag;
		}
	}
}
