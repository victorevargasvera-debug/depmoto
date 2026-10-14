using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Motorola.Common.Communication
{
	// Token: 0x02000021 RID: 33
	[global::System.Runtime.Serialization.DataContract]
	public class AppInventory
	{
		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000057 RID: 87 RVA: 0x0000304A File Offset: 0x0000124A
		// (set) Token: 0x06000058 RID: 88 RVA: 0x00003052 File Offset: 0x00001252
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Collections.Generic.List<global::Motorola.Common.Communication.App> appInventory { get; set; }

		// Token: 0x06000059 RID: 89 RVA: 0x0000305B File Offset: 0x0000125B
		public AppInventory()
		{
			this.appInventory = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.App>();
		}
	}
}
