using System;
using System.Net;
using System.Runtime.Serialization;
using SSLMangrComp.Packets;

namespace SSLMangrComp
{
	// Token: 0x0200001A RID: 26
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Serializable]
	public class ConnectionConfig
	{
		// Token: 0x1700000E RID: 14
		// (get) Token: 0x060000D4 RID: 212 RVA: 0x00005873 File Offset: 0x00003A73
		// (set) Token: 0x060000D5 RID: 213 RVA: 0x0000587B File Offset: 0x00003A7B
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Net.IPAddress PnIp { get; set; }

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x060000D6 RID: 214 RVA: 0x00005884 File Offset: 0x00003A84
		// (set) Token: 0x060000D7 RID: 215 RVA: 0x0000588C File Offset: 0x00003A8C
		[global::System.Runtime.Serialization.DataMember]
		public int PnPort { get; set; }

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x060000D8 RID: 216 RVA: 0x00005895 File Offset: 0x00003A95
		// (set) Token: 0x060000D9 RID: 217 RVA: 0x0000589D File Offset: 0x00003A9D
		[global::System.Runtime.Serialization.DataMember]
		public int Expiration { get; set; }

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x060000DA RID: 218 RVA: 0x000058A6 File Offset: 0x00003AA6
		// (set) Token: 0x060000DB RID: 219 RVA: 0x000058AE File Offset: 0x00003AAE
		[global::System.Runtime.Serialization.DataMember]
		public global::SSLMangrComp.Packets.SubscriptionType SubscriptionMode { get; set; }

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x060000DC RID: 220 RVA: 0x000058B7 File Offset: 0x00003AB7
		// (set) Token: 0x060000DD RID: 221 RVA: 0x000058BF File Offset: 0x00003ABF
		[global::System.Runtime.Serialization.DataMember]
		public global::SSLMangrComp.Packets.EntitiesTypes EntityType { get; set; }

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x060000DE RID: 222 RVA: 0x000058C8 File Offset: 0x00003AC8
		// (set) Token: 0x060000DF RID: 223 RVA: 0x000058D0 File Offset: 0x00003AD0
		[global::System.Runtime.Serialization.DataMember]
		public string EntityValue { get; set; }

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x060000E0 RID: 224 RVA: 0x000058D9 File Offset: 0x00003AD9
		// (set) Token: 0x060000E1 RID: 225 RVA: 0x000058E1 File Offset: 0x00003AE1
		[global::System.Runtime.Serialization.DataMember]
		public int ConnectionAttemptTimeout { get; set; }
	}
}
