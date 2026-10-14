using System;
using System.Runtime.Serialization;

namespace Motorola.Common.Communication
{
	// Token: 0x02000024 RID: 36
	[global::System.Runtime.Serialization.DataContract]
	public class FileCollection
	{
		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600007A RID: 122 RVA: 0x000031FC File Offset: 0x000013FC
		// (set) Token: 0x0600007B RID: 123 RVA: 0x00003204 File Offset: 0x00001404
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.Common.Communication.UELog fileCollection { get; set; }

		// Token: 0x0600007C RID: 124 RVA: 0x0000320D File Offset: 0x0000140D
		public FileCollection(global::Motorola.Common.Communication.UELog log)
		{
			this.fileCollection = log;
		}
	}
}
