using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x02000022 RID: 34
	public class OBManifest
	{
		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060000E9 RID: 233 RVA: 0x000041DF File Offset: 0x000023DF
		// (set) Token: 0x060000EA RID: 234 RVA: 0x000041E7 File Offset: 0x000023E7
		public string schemaVersion { get; private set; }

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060000EB RID: 235 RVA: 0x000041F0 File Offset: 0x000023F0
		// (set) Token: 0x060000EC RID: 236 RVA: 0x000041F8 File Offset: 0x000023F8
		public string manifestVersion { get; private set; }

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060000ED RID: 237 RVA: 0x00004201 File Offset: 0x00002401
		// (set) Token: 0x060000EE RID: 238 RVA: 0x00004209 File Offset: 0x00002409
		public string packageVersion { get; private set; }

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060000EF RID: 239 RVA: 0x00004212 File Offset: 0x00002412
		// (set) Token: 0x060000F0 RID: 240 RVA: 0x0000421A File Offset: 0x0000241A
		public string packageDescription { get; private set; }

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060000F1 RID: 241 RVA: 0x00004223 File Offset: 0x00002423
		// (set) Token: 0x060000F2 RID: 242 RVA: 0x0000422B File Offset: 0x0000242B
		public global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.componet> components { get; private set; }

		// Token: 0x060000F3 RID: 243 RVA: 0x00004234 File Offset: 0x00002434
		public OBManifest(byte[] manifestFile)
		{
			global::System.Xml.XmlDocument xmlDocument = new global::System.Xml.XmlDocument();
			using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(manifestFile))
			{
				xmlDocument.Load(memoryStream);
				this.AnalyseOBManifist(xmlDocument);
				memoryStream.Close();
			}
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x00004284 File Offset: 0x00002484
		public OBManifest(string manifestFile)
		{
			if (global::System.IO.File.Exists(manifestFile))
			{
				global::System.Xml.XmlDocument xmlDocument = new global::System.Xml.XmlDocument();
				xmlDocument.Load(manifestFile);
				this.AnalyseOBManifist(xmlDocument);
			}
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x000042B4 File Offset: 0x000024B4
		private void AnalyseOBManifist(global::System.Xml.XmlDocument doc)
		{
			global::System.Xml.XmlNode xmlNode = doc.DocumentElement.Attributes.GetNamedItem("schemaVersion");
			if (xmlNode != null)
			{
				this.schemaVersion = xmlNode.Value.Trim();
			}
			xmlNode = doc.DocumentElement.SelectSingleNode("manifestVersion");
			if (xmlNode != null)
			{
				this.manifestVersion = xmlNode.InnerText.Trim();
			}
			xmlNode = doc.DocumentElement.SelectSingleNode("packageVersion");
			if (xmlNode != null)
			{
				this.packageVersion = xmlNode.InnerText.Trim();
			}
			xmlNode = doc.DocumentElement.SelectSingleNode("packageDescription");
			if (xmlNode != null)
			{
				this.packageDescription = xmlNode.InnerText.Trim();
			}
			global::System.Xml.XmlNodeList xmlNodeList = doc.DocumentElement.SelectNodes("component");
			this.components = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.componet>();
			this.components.Clear();
			if (xmlNodeList != null)
			{
				foreach (object obj in xmlNodeList)
				{
					global::System.Xml.XmlNode xmlNode2 = (global::System.Xml.XmlNode)obj;
					global::Motorola.Common.Communication.CommonUtil.componet componet = new global::Motorola.Common.Communication.CommonUtil.componet();
					xmlNode = xmlNode2.SelectSingleNode("sourceFilename");
					if (xmlNode != null)
					{
						componet.sourceFilename = xmlNode.InnerText.Trim();
					}
					xmlNode = xmlNode2.SelectSingleNode("fileType");
					if (xmlNode != null)
					{
						componet.fileType = xmlNode.InnerText.Trim();
					}
					xmlNode = xmlNode2.SelectSingleNode("fileName");
					if (xmlNode != null)
					{
						componet.fileName = xmlNode.InnerText.Trim();
					}
					xmlNode = xmlNode2.SelectSingleNode("targetDir");
					if (xmlNode != null)
					{
						componet.targetDir = xmlNode.InnerText.Trim();
					}
					xmlNode = xmlNode2.SelectSingleNode("fileDescrip");
					if (xmlNode != null)
					{
						componet.fileDescrip = xmlNode.InnerText.Trim();
					}
					this.components.Add(componet);
				}
			}
		}
	}
}
