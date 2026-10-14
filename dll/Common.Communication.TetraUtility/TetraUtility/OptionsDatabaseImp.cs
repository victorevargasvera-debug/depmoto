using System;
using System.IO;
using System.Xml;
using Motorola.Common.LogUtility;

namespace Motorola.Common.Communication.TetraUtility
{
	// Token: 0x0200006C RID: 108
	internal class OptionsDatabaseImp : global::Motorola.Common.Communication.TetraUtility.IOptionsDatabase
	{
		// Token: 0x14000002 RID: 2
		// (add) Token: 0x0600027B RID: 635 RVA: 0x0000C010 File Offset: 0x0000A210
		// (remove) Token: 0x0600027C RID: 636 RVA: 0x0000C048 File Offset: 0x0000A248
		public event global::System.EventHandler<global::Motorola.Common.Communication.TetraUtility.OptionValueEventArgs> OptionValueChanged;

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x0600027D RID: 637 RVA: 0x0000C07D File Offset: 0x0000A27D
		// (set) Token: 0x0600027E RID: 638 RVA: 0x0000C085 File Offset: 0x0000A285
		public string DatabasePath { get; set; }

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x0600027F RID: 639 RVA: 0x0000C08E File Offset: 0x0000A28E
		private string BackDatabasePath
		{
			get
			{
				return this.DatabasePath + "_bak";
			}
		}

		// Token: 0x06000280 RID: 640 RVA: 0x0000C0A0 File Offset: 0x0000A2A0
		public void Load(bool force_load)
		{
			lock (this.padLock)
			{
				string text;
				if (global::System.IO.File.Exists(this.BackDatabasePath))
				{
					text = this.BackDatabasePath;
					if (global::System.IO.File.Exists(this.DatabasePath))
					{
						global::System.IO.File.Delete(this.DatabasePath);
					}
				}
				else
				{
					text = this.DatabasePath;
				}
				if (global::System.IO.File.Exists(text))
				{
					if (force_load || this.doc == null)
					{
						try
						{
							if (global::Motorola.Common.Communication.TetraUtility.CryptAndZipUtilty.IsXmlFile(text))
							{
								this.doc = new global::System.Xml.XmlDocument();
								this.doc.Load(text);
							}
							else
							{
								this.doc = global::Motorola.Common.Communication.TetraUtility.CryptAndZipUtilty.LoadXmlWhenDebugOrUnmixDecompressXml(text);
							}
							string value = this.GetValue(this.LANGUAGE_SECTION_NAME, this.LANGUAGE_VALUE_NAME);
							this.UpdateLanguageSetingIfNeed(this.LANGUAGE_SECTION_NAME, this.LANGUAGE_VALUE_NAME, value);
						}
						catch (global::System.Xml.XmlException)
						{
							this.doc = null;
						}
					}
				}
			}
		}

		// Token: 0x06000281 RID: 641 RVA: 0x0000C194 File Offset: 0x0000A394
		public string GetValue(string section_name, string value_name, object defaultValue)
		{
			this.Load(false);
			string result;
			lock (this.padLock)
			{
				if (this.doc == null)
				{
					result = defaultValue.ToString();
				}
				else
				{
					string xpath = string.Format("{0}/{1}/{2}", "root", section_name, value_name);
					global::System.Xml.XmlNode xmlNode = this.doc.SelectSingleNode(xpath);
					if (xmlNode == null)
					{
						result = defaultValue.ToString();
					}
					else
					{
						result = xmlNode.InnerText;
					}
				}
			}
			return result;
		}

		// Token: 0x06000282 RID: 642 RVA: 0x0000C21C File Offset: 0x0000A41C
		public string GetValue(string section_name, string value_name)
		{
			return this.GetValue(section_name, value_name, string.Empty);
		}

		// Token: 0x06000283 RID: 643 RVA: 0x0000C22C File Offset: 0x0000A42C
		public void SetValue(string section_name, string value_name, object value)
		{
			if (value == null)
			{
				return;
			}
			this.Load(false);
			lock (this.padLock)
			{
				if (this.doc == null)
				{
					this.doc = new global::System.Xml.XmlDocument();
					global::System.Xml.XmlDeclaration newChild = this.doc.CreateXmlDeclaration("1.0", null, null);
					this.doc.AppendChild(newChild);
					global::System.Xml.XmlNode newChild2 = this.doc.CreateElement("root");
					this.doc.AppendChild(newChild2);
				}
				string xpath = string.Format("{0}/{1}/{2}", "root", section_name, value_name);
				global::System.Xml.XmlNode xmlNode = this.doc.SelectSingleNode(xpath);
				if (xmlNode == null)
				{
					global::System.Xml.XmlNode xmlNode2 = this.doc.SelectSingleNode(string.Format("{0}/{1}", "root", section_name));
					if (xmlNode2 == null)
					{
						xmlNode2 = this.doc.CreateElement(section_name);
						this.doc.DocumentElement.AppendChild(xmlNode2);
					}
					xmlNode = this.doc.CreateElement(value_name);
					xmlNode2.AppendChild(xmlNode);
				}
				xmlNode.InnerText = value.ToString();
				if (this.OptionValueChanged != null)
				{
					this.OptionValueChanged(this, new global::Motorola.Common.Communication.TetraUtility.OptionValueEventArgs(section_name, value_name, value));
				}
			}
		}

		// Token: 0x06000284 RID: 644 RVA: 0x0000C374 File Offset: 0x0000A574
		public void Save()
		{
			lock (this.padLock)
			{
				if (this.doc != null)
				{
					if (string.IsNullOrEmpty(this.DatabasePath))
					{
						throw new global::Motorola.Common.Communication.TetraUtility.CCustomException("empty database path");
					}
					if (global::System.IO.File.Exists(this.DatabasePath))
					{
						if (global::System.IO.File.Exists(this.BackDatabasePath))
						{
							global::System.IO.File.Delete(this.BackDatabasePath);
						}
						global::System.IO.File.Move(this.DatabasePath, this.BackDatabasePath);
					}
					global::Motorola.Common.Communication.TetraUtility.CryptAndZipUtilty.SaveXmlAndCompressMix(this.doc, this.DatabasePath);
					if (global::System.IO.File.Exists(this.BackDatabasePath))
					{
						global::System.IO.File.Delete(this.BackDatabasePath);
					}
				}
			}
		}

		// Token: 0x06000285 RID: 645 RVA: 0x0000C434 File Offset: 0x0000A634
		public bool GetValue2Bool(string section_name, string value_name, bool fallbackValue)
		{
			string value = this.GetValue(section_name, value_name);
			if (string.IsNullOrEmpty(value))
			{
				return fallbackValue;
			}
			bool result;
			try
			{
				result = global::System.Convert.ToBoolean(value);
			}
			catch (global::System.Exception)
			{
				result = fallbackValue;
			}
			return result;
		}

		// Token: 0x06000286 RID: 646 RVA: 0x0000C474 File Offset: 0x0000A674
		private void UpdateLanguageSetingIfNeed(string section_name, string value_name, string selectedLanguage)
		{
			if (section_name != this.LANGUAGE_SECTION_NAME || value_name != this.LANGUAGE_VALUE_NAME || string.IsNullOrEmpty(selectedLanguage))
			{
				return;
			}
			try
			{
				string text = global::System.IO.Path.Combine(global::Motorola.Common.Communication.TetraUtility.FileSystem.BinDir, "_user_language.dat");
				global::System.Xml.XmlDocument xmlDocument;
				if (!global::System.IO.File.Exists(text))
				{
					xmlDocument = new global::System.Xml.XmlDocument();
					global::System.Xml.XmlDeclaration newChild = xmlDocument.CreateXmlDeclaration("1.0", null, null);
					xmlDocument.AppendChild(newChild);
					global::System.Xml.XmlNode newChild2 = xmlDocument.CreateElement("root");
					xmlDocument.AppendChild(newChild2);
					this.SaveLanguageOptionToXmlFile(xmlDocument, section_name, value_name, selectedLanguage);
				}
				else
				{
					xmlDocument = new global::System.Xml.XmlDocument();
					xmlDocument.Load(text);
					this.SaveLanguageOptionToXmlFile(xmlDocument, section_name, value_name, selectedLanguage);
				}
				xmlDocument.Save(text);
			}
			catch (global::System.Exception ex)
			{
				string message = "Met exception during update _user_language.dat, the exception is: " + ex.Message;
				global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(message);
			}
		}

		// Token: 0x06000287 RID: 647 RVA: 0x0000C554 File Offset: 0x0000A754
		private void SaveLanguageOptionToXmlFile(global::System.Xml.XmlDocument xmlDoc, string section_name, string value_name, string selectedLanguage)
		{
			if (xmlDoc == null || string.IsNullOrEmpty(section_name) || string.IsNullOrEmpty(value_name) || string.IsNullOrEmpty(selectedLanguage))
			{
				return;
			}
			string xpath = string.Format("{0}/{1}/{2}", "root", section_name, value_name);
			global::System.Xml.XmlNode xmlNode = xmlDoc.SelectSingleNode(xpath);
			if (xmlNode == null)
			{
				global::System.Xml.XmlNode xmlNode2 = xmlDoc.SelectSingleNode(string.Format("{0}/{1}", "root", section_name));
				if (xmlNode2 == null)
				{
					xmlNode2 = xmlDoc.CreateElement(section_name);
					xmlDoc.DocumentElement.AppendChild(xmlNode2);
				}
				xmlNode = xmlDoc.CreateElement(value_name);
				xmlNode2.AppendChild(xmlNode);
			}
			xmlNode.InnerText = selectedLanguage;
		}

		// Token: 0x040002F5 RID: 757
		private const string ROOT = "root";

		// Token: 0x040002F7 RID: 759
		private object padLock = new object();

		// Token: 0x040002F8 RID: 760
		private global::System.Xml.XmlDocument doc;

		// Token: 0x040002F9 RID: 761
		private readonly string LANGUAGE_SECTION_NAME = "OPTIONS_GENERAL_SECTION";

		// Token: 0x040002FA RID: 762
		private readonly string LANGUAGE_VALUE_NAME = "language_selection_abbr";
	}
}
