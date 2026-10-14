using System;
using System.Runtime.Serialization;

namespace Motorola.Common.Communication
{
	// Token: 0x02000027 RID: 39
	[global::System.Runtime.Serialization.DataContract]
	public class ProvVersion
	{
		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000083 RID: 131 RVA: 0x0000325C File Offset: 0x0000145C
		// (set) Token: 0x06000084 RID: 132 RVA: 0x00003264 File Offset: 0x00001464
		[global::System.Runtime.Serialization.DataMember]
		public string TcVersion { get; set; }

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000085 RID: 133 RVA: 0x0000326D File Offset: 0x0000146D
		// (set) Token: 0x06000086 RID: 134 RVA: 0x00003275 File Offset: 0x00001475
		[global::System.Runtime.Serialization.DataMember]
		public string configSchemaVersion { get; set; }

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000087 RID: 135 RVA: 0x0000327E File Offset: 0x0000147E
		// (set) Token: 0x06000088 RID: 136 RVA: 0x00003286 File Offset: 0x00001486
		[global::System.Runtime.Serialization.DataMember]
		public string configTimestamp { get; set; }

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000089 RID: 137 RVA: 0x0000328F File Offset: 0x0000148F
		// (set) Token: 0x0600008A RID: 138 RVA: 0x00003297 File Offset: 0x00001497
		[global::System.Runtime.Serialization.DataMember]
		public string SACSchemaVersion { get; set; }

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x0600008B RID: 139 RVA: 0x000032A0 File Offset: 0x000014A0
		// (set) Token: 0x0600008C RID: 140 RVA: 0x000032A8 File Offset: 0x000014A8
		[global::System.Runtime.Serialization.DataMember]
		public string SACTimestamp { get; set; }

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x0600008D RID: 141 RVA: 0x000032B1 File Offset: 0x000014B1
		// (set) Token: 0x0600008E RID: 142 RVA: 0x000032B9 File Offset: 0x000014B9
		[global::System.Runtime.Serialization.DataMember]
		public string TGSchemaVersion { get; set; }

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x0600008F RID: 143 RVA: 0x000032C2 File Offset: 0x000014C2
		// (set) Token: 0x06000090 RID: 144 RVA: 0x000032CA File Offset: 0x000014CA
		[global::System.Runtime.Serialization.DataMember]
		public string TGTimestamp { get; set; }

		// Token: 0x06000091 RID: 145 RVA: 0x000032D3 File Offset: 0x000014D3
		public ProvVersion(string tcVersion, string configSchemaVersion, string configTimestamp, string sacSchemaVersion, string sacTimestamp, string tgSchemaVersion, string tgTimestamp)
		{
			this.TcVersion = tcVersion;
			this.configSchemaVersion = configSchemaVersion;
			this.configTimestamp = configTimestamp;
			this.SACSchemaVersion = sacSchemaVersion;
			this.SACTimestamp = sacTimestamp;
			this.TGSchemaVersion = tgSchemaVersion;
			this.TGTimestamp = tgTimestamp;
		}
	}
}
