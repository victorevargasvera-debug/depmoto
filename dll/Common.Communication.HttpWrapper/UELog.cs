using System;
using System.Runtime.Serialization;

namespace Motorola.Common.Communication
{
	// Token: 0x02000025 RID: 37
	[global::System.Runtime.Serialization.DataContract]
	public class UELog
	{
		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600007D RID: 125 RVA: 0x0000321C File Offset: 0x0000141C
		// (set) Token: 0x0600007E RID: 126 RVA: 0x00003224 File Offset: 0x00001424
		[global::System.Runtime.Serialization.DataMember]
		public string fileName { get; set; }

		// Token: 0x0600007F RID: 127 RVA: 0x0000322D File Offset: 0x0000142D
		public UELog(string name)
		{
			this.fileName = name;
		}
	}
}
