using System;
using System.Runtime.Serialization;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x0200000A RID: 10
	[global::System.Flags]
	[global::System.Runtime.Serialization.DataContract]
	public enum ConnectionType
	{
		// Token: 0x04000027 RID: 39
		[global::System.Runtime.Serialization.EnumMember]
		None = 0,
		// Token: 0x04000028 RID: 40
		[global::System.Runtime.Serialization.EnumMember]
		VCOM = 1,
		// Token: 0x04000029 RID: 41
		[global::System.Runtime.Serialization.EnumMember]
		RS232 = 2,
		// Token: 0x0400002A RID: 42
		[global::System.Runtime.Serialization.EnumMember]
		NetAdapter = 4,
		// Token: 0x0400002B RID: 43
		[global::System.Runtime.Serialization.EnumMember]
		LENetwork = 8,
		// Token: 0x0400002C RID: 44
		[global::System.Runtime.Serialization.EnumMember]
		Otap = 16,
		// Token: 0x0400002D RID: 45
		[global::System.Runtime.Serialization.EnumMember]
		Bluetooth = 32,
		// Token: 0x0400002E RID: 46
		[global::System.Runtime.Serialization.EnumMember]
		WIFI = 64,
		// Token: 0x0400002F RID: 47
		[global::System.Runtime.Serialization.EnumMember]
		Fudally = 128,
		// Token: 0x04000030 RID: 48
		[global::System.Runtime.Serialization.EnumMember]
		Provisioning = 256,
		// Token: 0x04000031 RID: 49
		[global::System.Runtime.Serialization.EnumMember]
		DMR3Network = 512,
		// Token: 0x04000032 RID: 50
		[global::System.Runtime.Serialization.EnumMember]
		VirtualConnection = 1024,
		// Token: 0x04000033 RID: 51
		[global::System.Runtime.Serialization.EnumMember]
		Any = 65535
	}
}
