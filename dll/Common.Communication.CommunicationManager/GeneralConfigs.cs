using System;
using System.IO;
using System.Reflection;
using System.Xml;

namespace Motorola.Common.Communication.CommunicationManager
{
	// Token: 0x0200001E RID: 30
	internal class GeneralConfigs
	{
		// Token: 0x060000E9 RID: 233 RVA: 0x00005ADC File Offset: 0x00003CDC
		private GeneralConfigs()
		{
			string directoryName = global::System.IO.Path.GetDirectoryName(global::System.Reflection.Assembly.GetExecutingAssembly().Location);
			string configFilePath = global::System.IO.Path.Combine(new string[]
			{
				directoryName,
				"Metadata",
				"PCR",
				"configs",
				"GeneralConfigs.xml"
			});
			this.LoadConfigs(configFilePath);
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000EA RID: 234 RVA: 0x00005B38 File Offset: 0x00003D38
		internal static global::Motorola.Common.Communication.CommunicationManager.GeneralConfigs Instance
		{
			get
			{
				return global::Motorola.Common.Communication.CommunicationManager.GeneralConfigs._self;
			}
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00005B40 File Offset: 0x00003D40
		internal void LoadConfigs(string configFilePath)
		{
			if (global::System.IO.File.Exists(configFilePath))
			{
				try
				{
					using (global::System.IO.FileStream fileStream = new global::System.IO.FileStream(configFilePath, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read))
					{
						global::System.Xml.XmlDocument xmlDocument = new global::System.Xml.XmlDocument();
						xmlDocument.Load(fileStream);
						global::System.Xml.XmlNode xmlNode = xmlDocument.SelectSingleNode("GeneralConfigs/PCRWiFiMaxPacketSize");
						if (xmlNode != null)
						{
							this.PCRWiFiMaxPacketSize = global::System.Convert.ToInt32(xmlNode.InnerText) * 1024;
						}
					}
				}
				catch
				{
				}
			}
			if (this.PCRWiFiMaxPacketSize == 0)
			{
				this.PCRWiFiMaxPacketSize = 10000;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000EC RID: 236 RVA: 0x00005BD4 File Offset: 0x00003DD4
		// (set) Token: 0x060000ED RID: 237 RVA: 0x00005BDC File Offset: 0x00003DDC
		public int PCRWiFiMaxPacketSize { get; set; }

		// Token: 0x04000033 RID: 51
		private const string GeneralConfigFilePath = "GeneralConfigs.xml";

		// Token: 0x04000034 RID: 52
		private static global::Motorola.Common.Communication.CommunicationManager.GeneralConfigs _self = new global::Motorola.Common.Communication.CommunicationManager.GeneralConfigs();
	}
}
