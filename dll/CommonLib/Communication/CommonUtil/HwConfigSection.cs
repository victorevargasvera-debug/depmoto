using System;
using System.Runtime.Serialization;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x02000044 RID: 68
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Serializable]
	public class HwConfigSection
	{
		// Token: 0x06000252 RID: 594 RVA: 0x0000713E File Offset: 0x0000533E
		public HwConfigSection()
		{
		}

		// Token: 0x06000253 RID: 595 RVA: 0x00007146 File Offset: 0x00005346
		public HwConfigSection(int sectionType, string value, byte[] rawData)
		{
			this.SectionType = sectionType;
			this.Value = value;
			this.RawData = rawData;
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x06000254 RID: 596 RVA: 0x00007163 File Offset: 0x00005363
		// (set) Token: 0x06000255 RID: 597 RVA: 0x0000716B File Offset: 0x0000536B
		[global::System.Runtime.Serialization.DataMember]
		public int SectionType { get; set; }

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x06000256 RID: 598 RVA: 0x00007174 File Offset: 0x00005374
		// (set) Token: 0x06000257 RID: 599 RVA: 0x0000717C File Offset: 0x0000537C
		[global::System.Runtime.Serialization.DataMember]
		public string Value { get; set; }

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x06000258 RID: 600 RVA: 0x00007185 File Offset: 0x00005385
		// (set) Token: 0x06000259 RID: 601 RVA: 0x0000718D File Offset: 0x0000538D
		[global::System.Runtime.Serialization.DataMember]
		public byte[] RawData { get; set; }
	}
}
