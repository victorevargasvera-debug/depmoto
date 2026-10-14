using System;
using System.IO;
using System.Reflection;

namespace Motorola.Common.Communication
{
	// Token: 0x02000003 RID: 3
	public class DnsConfigConstants
	{
		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600000D RID: 13 RVA: 0x00002210 File Offset: 0x00000410
		public static string ConfigFilePath
		{
			get
			{
				string directoryName = global::System.IO.Path.GetDirectoryName(global::System.Reflection.Assembly.GetExecutingAssembly().Location);
				return global::System.IO.Path.Combine(directoryName, global::Motorola.Common.Communication.DnsConfigConstants.DNS_METADATA_FOLDER, global::Motorola.Common.Communication.DnsConfigConstants.DNS_CONFIG_METADATA_FOLDER, global::Motorola.Common.Communication.DnsConfigConstants.DNS_CONFIG_FILE);
			}
		}

		// Token: 0x04000006 RID: 6
		private static string _binDir = string.Empty;

		// Token: 0x04000007 RID: 7
		public static readonly string DNS_CONFIG_METADATA_FOLDER = "DNS";

		// Token: 0x04000008 RID: 8
		public static readonly string DNS_METADATA_FOLDER = "MetaData";

		// Token: 0x04000009 RID: 9
		public static readonly string DNS_CONFIG_FILE = "DNSConfig.xml";

		// Token: 0x0400000A RID: 10
		public static readonly int DNS_BODY_START_INDEX = 12;
	}
}
