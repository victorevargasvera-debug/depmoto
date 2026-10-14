using System;
using System.Runtime.Serialization;

namespace Motorola.Common.Communication
{
	// Token: 0x02000026 RID: 38
	[global::System.Runtime.Serialization.DataContract]
	public class FactoryReset
	{
		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000080 RID: 128 RVA: 0x0000323C File Offset: 0x0000143C
		// (set) Token: 0x06000081 RID: 129 RVA: 0x00003244 File Offset: 0x00001444
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.Common.Communication.ReasonClass factoryReset { get; set; }

		// Token: 0x06000082 RID: 130 RVA: 0x0000324D File Offset: 0x0000144D
		public FactoryReset(global::Motorola.Common.Communication.ReasonClass reason)
		{
			this.factoryReset = reason;
		}
	}
}
