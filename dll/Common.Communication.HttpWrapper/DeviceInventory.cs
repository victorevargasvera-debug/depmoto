using System;
using System.Runtime.Serialization;

namespace Motorola.Common.Communication
{
	// Token: 0x02000023 RID: 35
	[global::System.Runtime.Serialization.DataContract]
	public class DeviceInventory
	{
		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000077 RID: 119 RVA: 0x000031DC File Offset: 0x000013DC
		// (set) Token: 0x06000078 RID: 120 RVA: 0x000031E4 File Offset: 0x000013E4
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.Common.Communication.InnerInventory deviceInventory { get; set; }

		// Token: 0x06000079 RID: 121 RVA: 0x000031ED File Offset: 0x000013ED
		public DeviceInventory(global::Motorola.Common.Communication.InnerInventory inner)
		{
			this.deviceInventory = inner;
		}
	}
}
