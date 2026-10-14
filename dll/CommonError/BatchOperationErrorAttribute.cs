using System;
using System.Runtime.Serialization;

namespace Motorola.Common.CustomException
{
	// Token: 0x02000004 RID: 4
	[global::System.Serializable]
	public sealed class BatchOperationErrorAttribute : global::System.Attribute
	{
		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000013 RID: 19 RVA: 0x00002327 File Offset: 0x00000527
		// (set) Token: 0x06000014 RID: 20 RVA: 0x0000232F File Offset: 0x0000052F
		[global::System.Runtime.Serialization.DataMember]
		public bool IsFatal { get; set; }

		// Token: 0x06000015 RID: 21 RVA: 0x00002338 File Offset: 0x00000538
		public BatchOperationErrorAttribute(bool isFatal = false)
		{
			this.IsFatal = isFatal;
		}
	}
}
