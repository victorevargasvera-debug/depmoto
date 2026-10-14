using System;
using System.Net;
using System.Runtime.Serialization;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x02000007 RID: 7
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Serializable]
	public class SecureConnectionInfo
	{
		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600002D RID: 45 RVA: 0x0000287A File Offset: 0x00000A7A
		// (set) Token: 0x0600002E RID: 46 RVA: 0x00002882 File Offset: 0x00000A82
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Net.IPAddress RadioIP { get; set; }

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600002F RID: 47 RVA: 0x0000288B File Offset: 0x00000A8B
		// (set) Token: 0x06000030 RID: 48 RVA: 0x00002893 File Offset: 0x00000A93
		[global::System.Runtime.Serialization.DataMember]
		public ushort RadioPort { get; set; }
	}
}
