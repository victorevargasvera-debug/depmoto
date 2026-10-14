using System;
using System.IO;
using System.Xml;

namespace Motorola.Common.Communication
{
	// Token: 0x02000002 RID: 2
	public class DnsConfig
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000001 RID: 1 RVA: 0x000020D0 File Offset: 0x000002D0
		// (set) Token: 0x06000002 RID: 2 RVA: 0x000020D8 File Offset: 0x000002D8
		public string GroupIP { get; set; }

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000003 RID: 3 RVA: 0x000020E1 File Offset: 0x000002E1
		// (set) Token: 0x06000004 RID: 4 RVA: 0x000020E9 File Offset: 0x000002E9
		public int Port { get; set; }

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000005 RID: 5 RVA: 0x000020F2 File Offset: 0x000002F2
		// (set) Token: 0x06000006 RID: 6 RVA: 0x000020FA File Offset: 0x000002FA
		public string OTAPTCP { get; set; }

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000007 RID: 7 RVA: 0x00002103 File Offset: 0x00000303
		// (set) Token: 0x06000008 RID: 8 RVA: 0x0000210B File Offset: 0x0000030B
		public string PasswordIndex { get; set; }

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000009 RID: 9 RVA: 0x00002114 File Offset: 0x00000314
		// (set) Token: 0x0600000A RID: 10 RVA: 0x0000211C File Offset: 0x0000031C
		public string PID { get; set; }

		// Token: 0x0600000B RID: 11 RVA: 0x00002128 File Offset: 0x00000328
		public void LoadConfig(string configFilePath)
		{
			if (configFilePath == null)
			{
				return;
			}
			try
			{
				using (global::System.IO.FileStream fileStream = new global::System.IO.FileStream(configFilePath, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read))
				{
					global::System.Xml.XmlDocument xmlDocument = new global::System.Xml.XmlDocument();
					xmlDocument.Load(fileStream);
					global::System.Xml.XmlNode xmlNode = xmlDocument.SelectSingleNode("DNSConfig/GroupIP");
					if (xmlNode != null)
					{
						this.GroupIP = xmlNode.InnerText;
					}
					xmlNode = xmlDocument.SelectSingleNode("DNSConfig/Port");
					if (xmlNode != null)
					{
						this.Port = int.Parse(xmlNode.InnerText);
					}
					xmlNode = xmlDocument.SelectSingleNode("DNSConfig/OTAPTCP");
					if (xmlNode != null)
					{
						this.OTAPTCP = xmlNode.InnerText;
					}
					xmlNode = xmlDocument.SelectSingleNode("DNSConfig/PasswordIndex");
					if (xmlNode != null)
					{
						this.PasswordIndex = xmlNode.InnerText;
					}
					xmlNode = xmlDocument.SelectSingleNode("DNSConfig/PID");
					if (xmlNode != null)
					{
						this.PID = xmlNode.InnerText;
					}
				}
			}
			catch
			{
			}
		}
	}
}
