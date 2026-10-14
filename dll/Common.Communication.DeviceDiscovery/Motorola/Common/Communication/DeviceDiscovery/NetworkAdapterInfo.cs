using System;

namespace Motorola.Common.Communication.DeviceDiscovery
{
	// Token: 0x02000022 RID: 34
	internal class NetworkAdapterInfo
	{
		// Token: 0x06000108 RID: 264 RVA: 0x00006CFE File Offset: 0x00004EFE
		public NetworkAdapterInfo(string name, string macAddress, string ipAddress, bool isDhcpEnabled)
		{
			this.Name = name;
			this.MacAddress = macAddress;
			this.IPAddress = ipAddress;
			this.IsDhcpEnabled = isDhcpEnabled;
		}

		// Token: 0x04000099 RID: 153
		public string Name;

		// Token: 0x0400009A RID: 154
		public string MacAddress;

		// Token: 0x0400009B RID: 155
		public string IPAddress;

		// Token: 0x0400009C RID: 156
		public bool IsDhcpEnabled;
	}
}
