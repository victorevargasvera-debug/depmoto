using System;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using ENCATENCOMPONENTLib;

namespace Motorola.Common.Communication
{
	// Token: 0x02000008 RID: 8
	internal sealed class FlashportUpgradeFile
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600004D RID: 77 RVA: 0x00003EA6 File Offset: 0x000020A6
		// (set) Token: 0x0600004E RID: 78 RVA: 0x00003EAE File Offset: 0x000020AE
		private string UpgradeFilePath
		{
			get
			{
				return this.upgradeFilePath;
			}
			set
			{
				this.upgradeFilePath = value;
			}
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00003EB7 File Offset: 0x000020B7
		private FlashportUpgradeFile()
		{
			this.upgradeFilePath = string.Empty;
			this.encaten = null;
			this.open = false;
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00003EE3 File Offset: 0x000020E3
		public FlashportUpgradeFile(string path)
		{
			this.upgradeFilePath = path;
			this.encaten = (global::ENCATENCOMPONENTLib.Encaten)global::System.Activator.CreateInstance(global::System.Runtime.InteropServices.Marshal.GetTypeFromCLSID(new global::System.Guid("143DF7EB-75CC-4709-B70A-56097EEDED22")));
			this.open = false;
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00003F24 File Offset: 0x00002124
		public bool OpenUpgradeFile()
		{
			bool flag = false;
			if (global::System.IO.File.Exists(this.upgradeFilePath))
			{
				if (this.open)
				{
					return true;
				}
				int num = this.encaten.openAndGetFilePackage(this.upgradeFilePath, "1B7097E8-D9E3-11d5-A3BE-0060B0FB015A", out this.fileContent);
				if (num >= 0)
				{
					this.encaten.getFilePackageEncryptionStatus(out flag);
				}
				if (flag)
				{
					this.open = true;
				}
			}
			return flag;
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00003F84 File Offset: 0x00002184
		private bool CheckFileContentsValid()
		{
			string empty = string.Empty;
			string empty2 = string.Empty;
			string componentName = "HFWS";
			int num = this.selectCurrentFile(componentName);
			if (num < 1)
			{
				componentName = "PDTA";
				num = this.selectCurrentFile(componentName);
				if (num < 1)
				{
					return false;
				}
				componentName = "HFWA";
				num = this.selectCurrentFile(componentName);
				if (num < 1)
				{
					componentName = "HFWC";
					num = this.selectCurrentFile(componentName);
					if (num < 1)
					{
						return false;
					}
				}
				componentName = "DFWA";
				num = this.selectCurrentFile(componentName);
				if (num < 1)
				{
					componentName = "DFWC";
					num = this.selectCurrentFile(componentName);
					if (num < 1)
					{
						return false;
					}
				}
			}
			else
			{
				componentName = "DFWD";
				num = this.selectCurrentFile(componentName);
				if (num < 1)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00004034 File Offset: 0x00002234
		internal int selectCurrentFile(string ComponentName)
		{
			int num = 0;
			using (global::System.IO.StringReader stringReader = new global::System.IO.StringReader(this.fileContent))
			{
				using (global::System.Xml.XmlReader xmlReader = global::System.Xml.XmlReader.Create(stringReader))
				{
					xmlReader.MoveToContent();
					while (xmlReader.Read())
					{
						if (xmlReader.Name == "fileItem" && xmlReader.MoveToFirstAttribute() && xmlReader.MoveToAttribute("fileName") && xmlReader.HasValue && xmlReader.Value == ComponentName)
						{
							num++;
						}
					}
				}
			}
			return num;
		}

		// Token: 0x06000054 RID: 84 RVA: 0x000040E0 File Offset: 0x000022E0
		private bool CheckFileDestinatioInfoValid(string modelNumber)
		{
			bool result = false;
			string text = this.getFilePackageDestinationInfo();
			if (string.IsNullOrEmpty(text))
			{
				text = text.Trim();
				string text2 = modelNumber.Trim();
				if (text2[0] == text[0])
				{
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00004120 File Offset: 0x00002320
		internal string getFilePackageDestinationInfo()
		{
			string result = string.Empty;
			using (global::System.IO.StringReader stringReader = new global::System.IO.StringReader(this.fileContent))
			{
				using (global::System.Xml.XmlReader xmlReader = global::System.Xml.XmlReader.Create(stringReader))
				{
					while (xmlReader.Read())
					{
						if (xmlReader.MoveToFirstAttribute() && xmlReader.MoveToAttribute("filePackageDestinationInfo") && xmlReader.HasValue)
						{
							result = xmlReader.Value;
							break;
						}
					}
				}
			}
			return result;
		}

		// Token: 0x06000056 RID: 86 RVA: 0x000041B8 File Offset: 0x000023B8
		private string GetFileComponentVersion(string componentName, bool noPeriods = true)
		{
			string text = string.Empty;
			string empty = string.Empty;
			int num = this.selectCurrentFile(componentName);
			if (num > 0)
			{
				text = this.getCurrentFileVersion(componentName);
				if (!string.IsNullOrEmpty(text))
				{
					text = text.TrimEnd(new char[0]);
					char[] trimChars = new char[]
					{
						'\0',
						' ',
						'\r',
						'\n'
					};
					text = text.TrimEnd(trimChars);
					if (noPeriods)
					{
						text = text.Replace(".", "");
					}
				}
			}
			return text;
		}

		// Token: 0x06000057 RID: 87 RVA: 0x0000422C File Offset: 0x0000242C
		internal string getCurrentFileVersion(string ComponentName)
		{
			string result = string.Empty;
			using (global::System.IO.StringReader stringReader = new global::System.IO.StringReader(this.fileContent))
			{
				using (global::System.Xml.XmlReader xmlReader = global::System.Xml.XmlReader.Create(stringReader))
				{
					xmlReader.MoveToContent();
					while (xmlReader.Read())
					{
						if (xmlReader.Name == "fileItem" && xmlReader.MoveToFirstAttribute() && xmlReader.MoveToAttribute("fileName") && xmlReader.HasValue && xmlReader.Value == ComponentName && xmlReader.MoveToAttribute("fileVersion") && xmlReader.HasValue)
						{
							result = xmlReader.Value;
							break;
						}
					}
				}
			}
			return result;
		}

		// Token: 0x06000058 RID: 88 RVA: 0x000042F4 File Offset: 0x000024F4
		public void GetComponentData(string componentName, out string data)
		{
			data = string.Empty;
			string empty = string.Empty;
			string empty2 = string.Empty;
			int num = this.selectCurrentFile(componentName);
			if (num > 0)
			{
				data = this.getCurrentFileData(componentName);
			}
		}

		// Token: 0x06000059 RID: 89 RVA: 0x0000432C File Offset: 0x0000252C
		internal string getCurrentFileData(string ComponentName)
		{
			string result = string.Empty;
			global::System.Xml.XmlReaderSettings xmlReaderSettings = new global::System.Xml.XmlReaderSettings();
			xmlReaderSettings.IgnoreWhitespace = true;
			using (global::System.IO.StringReader stringReader = new global::System.IO.StringReader(this.fileContent))
			{
				using (global::System.Xml.XmlReader xmlReader = global::System.Xml.XmlReader.Create(stringReader, xmlReaderSettings))
				{
					xmlReader.MoveToContent();
					while (xmlReader.Read())
					{
						if (xmlReader.Name == "fileItem" && xmlReader.MoveToFirstAttribute() && xmlReader.MoveToAttribute("fileName") && xmlReader.HasValue && xmlReader.Value == ComponentName)
						{
							while (xmlReader.Read())
							{
								if (xmlReader.Name == "fileData")
								{
									global::System.Xml.Linq.XElement xelement = global::System.Xml.Linq.XNode.ReadFrom(xmlReader) as global::System.Xml.Linq.XElement;
									result = xelement.Value.Trim();
									break;
								}
							}
						}
					}
				}
			}
			return result;
		}

		// Token: 0x0600005A RID: 90 RVA: 0x0000441C File Offset: 0x0000261C
		private bool ExtractDataToFile(string componentName, string filePath)
		{
			bool result = true;
			string empty = string.Empty;
			string empty2 = string.Empty;
			int num = this.selectCurrentFile(componentName);
			if (num > 0)
			{
				this.encaten.extractCurrentFileToFile(filePath);
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00004458 File Offset: 0x00002658
		private bool ComponentPresent(string componentName)
		{
			bool result = false;
			string empty = string.Empty;
			string empty2 = string.Empty;
			int num = this.selectCurrentFile(componentName);
			if (num > 0)
			{
				result = true;
			}
			return result;
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00004490 File Offset: 0x00002690
		internal bool CheckFileDestinatioInfoValidForBBF(string modelNumber)
		{
			bool result = false;
			byte[] array = new byte[64];
			string a = string.Empty;
			using (global::System.IO.FileStream fileStream = global::System.IO.File.OpenRead(this.upgradeFilePath))
			{
				long offset = 24L;
				fileStream.Seek(offset, global::System.IO.SeekOrigin.Begin);
				fileStream.Read(array, 0, 64);
			}
			char[] trimChars = new char[]
			{
				'\0',
				' ',
				'\r',
				'\n'
			};
			a = global::System.Text.Encoding.UTF8.GetString(array, 0, array.Length).TrimEnd(trimChars);
			if ((a == "disc_por" && modelNumber[0] == 'H') || (a == "disc_mob" && (modelNumber[0] == 'M' || modelNumber[0] == 'L')))
			{
				result = true;
			}
			return result;
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00004560 File Offset: 0x00002760
		public string GetBBFSuiteVersion()
		{
			string empty = string.Empty;
			byte[] array = new byte[16];
			using (global::System.IO.FileStream fileStream = global::System.IO.File.OpenRead(this.upgradeFilePath))
			{
				long offset = 88L;
				fileStream.Seek(offset, global::System.IO.SeekOrigin.Begin);
				fileStream.Read(array, 0, 16);
			}
			char[] trimChars = new char[]
			{
				'\0',
				' ',
				'\r',
				'\n'
			};
			return global::System.Text.Encoding.UTF8.GetString(array, 0, array.Length).TrimEnd(trimChars);
		}

		// Token: 0x0600005E RID: 94 RVA: 0x000045E8 File Offset: 0x000027E8
		public bool verifyBBFMagicNumber()
		{
			bool result = false;
			byte[] array = new byte[8];
			string b = string.Empty;
			using (global::System.IO.FileStream fileStream = global::System.IO.File.OpenRead(this.upgradeFilePath))
			{
				fileStream.Read(array, 0, 8);
			}
			b = global::System.Text.Encoding.UTF8.GetString(array, 0, array.Length);
			if ("@BBFhdr@" == b)
			{
				result = true;
			}
			return result;
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00004658 File Offset: 0x00002858
		public bool verifyChecksum()
		{
			bool result = false;
			byte[] array = new byte[4];
			byte[] array2 = new byte[4];
			using (global::System.IO.FileStream fileStream = global::System.IO.File.OpenRead(this.upgradeFilePath))
			{
				byte[] buffer = new byte[fileStream.Length - 4L];
				long offset = fileStream.Length - 4L;
				fileStream.Read(buffer, 0, (int)fileStream.Length - 4);
				fileStream.Seek(offset, global::System.IO.SeekOrigin.Begin);
				fileStream.Read(array, 0, 4);
				using (global::Motorola.Common.Communication.Crc32 crc = new global::Motorola.Common.Communication.Crc32())
				{
					int num = 0;
					foreach (byte b in crc.ComputeHash(buffer))
					{
						array2[num] = b;
						num++;
					}
				}
				result = array.SequenceEqual(array2);
			}
			return result;
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00004740 File Offset: 0x00002940
		public byte[] GetBBFFileData()
		{
			return global::System.IO.File.ReadAllBytes(this.upgradeFilePath);
		}

		// Token: 0x04000023 RID: 35
		private const string cstrEncUUID = "1B7097E8-D9E3-11d5-A3BE-0060B0FB015A";

		// Token: 0x04000024 RID: 36
		private const string fileItem = "fileItem";

		// Token: 0x04000025 RID: 37
		private const string fileName = "fileName";

		// Token: 0x04000026 RID: 38
		private const string filePackageDestinationInfo = "filePackageDestinationInfo";

		// Token: 0x04000027 RID: 39
		private const string fileComponentVersion = "fileVersion";

		// Token: 0x04000028 RID: 40
		private const string fileData = "fileData";

		// Token: 0x04000029 RID: 41
		private const string bbfFileMagicNumber = "@BBFhdr@";

		// Token: 0x0400002A RID: 42
		private const string portableBBFBundleName = "disc_por";

		// Token: 0x0400002B RID: 43
		private const string mobileBBFBundleName = "disc_mob";

		// Token: 0x0400002C RID: 44
		private global::ENCATENCOMPONENTLib.Encaten encaten;

		// Token: 0x0400002D RID: 45
		private string upgradeFilePath;

		// Token: 0x0400002E RID: 46
		private bool open;

		// Token: 0x0400002F RID: 47
		private string fileContent = string.Empty;
	}
}
