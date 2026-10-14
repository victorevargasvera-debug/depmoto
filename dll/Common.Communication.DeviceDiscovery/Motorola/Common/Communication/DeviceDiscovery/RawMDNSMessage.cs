using System;
using System.Net;

namespace Motorola.Common.Communication.DeviceDiscovery
{
	// Token: 0x02000013 RID: 19
	public class RawMDNSMessage
	{
		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000088 RID: 136 RVA: 0x000054AE File Offset: 0x000036AE
		// (set) Token: 0x06000089 RID: 137 RVA: 0x000054B6 File Offset: 0x000036B6
		public byte[] Message { get; set; }

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600008A RID: 138 RVA: 0x000054BF File Offset: 0x000036BF
		// (set) Token: 0x0600008B RID: 139 RVA: 0x000054C7 File Offset: 0x000036C7
		public global::System.Net.IPEndPoint RemotePoint { get; set; }
	}
}
