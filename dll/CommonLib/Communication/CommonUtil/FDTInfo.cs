using System;
using System.Runtime.Serialization;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x02000045 RID: 69
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Serializable]
	public class FDTInfo
	{
		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x0600025A RID: 602 RVA: 0x00007196 File Offset: 0x00005396
		// (set) Token: 0x0600025B RID: 603 RVA: 0x0000719E File Offset: 0x0000539E
		[global::System.Runtime.Serialization.DataMember]
		public bool HealthState { get; set; }

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x0600025C RID: 604 RVA: 0x000071A7 File Offset: 0x000053A7
		// (set) Token: 0x0600025D RID: 605 RVA: 0x000071AF File Offset: 0x000053AF
		[global::System.Runtime.Serialization.DataMember]
		public string Version { get; set; }

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x0600025E RID: 606 RVA: 0x000071B8 File Offset: 0x000053B8
		// (set) Token: 0x0600025F RID: 607 RVA: 0x000071C0 File Offset: 0x000053C0
		[global::System.Runtime.Serialization.DataMember]
		public ushort ModelType { get; set; }

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x06000260 RID: 608 RVA: 0x000071C9 File Offset: 0x000053C9
		// (set) Token: 0x06000261 RID: 609 RVA: 0x000071D1 File Offset: 0x000053D1
		[global::System.Runtime.Serialization.DataMember]
		public string Info { get; set; }
	}
}
