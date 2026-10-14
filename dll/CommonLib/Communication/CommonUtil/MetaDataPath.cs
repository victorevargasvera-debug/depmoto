using System;
using System.Runtime.Serialization;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x02000051 RID: 81
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Serializable]
	public class MetaDataPath
	{
		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x06000276 RID: 630 RVA: 0x000072F2 File Offset: 0x000054F2
		// (set) Token: 0x06000277 RID: 631 RVA: 0x000072FA File Offset: 0x000054FA
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.Common.Communication.CommonUtil.MetaDataPathType Type { get; set; }

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x06000278 RID: 632 RVA: 0x00007303 File Offset: 0x00005503
		// (set) Token: 0x06000279 RID: 633 RVA: 0x0000730B File Offset: 0x0000550B
		[global::System.Runtime.Serialization.DataMember]
		public string Path { get; set; }
	}
}
