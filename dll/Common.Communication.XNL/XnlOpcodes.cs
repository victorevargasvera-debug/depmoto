using System;

namespace Motorola.Common.Communication
{
	// Token: 0x0200000F RID: 15
	internal enum XnlOpcodes : ushort
	{
		// Token: 0x04000042 RID: 66
		Reserved,
		// Token: 0x04000043 RID: 67
		MasterPresentBroadcast,
		// Token: 0x04000044 RID: 68
		MasterStatusBroadcast,
		// Token: 0x04000045 RID: 69
		DeviceMasterQuery,
		// Token: 0x04000046 RID: 70
		DeviceAuthKeyRequest,
		// Token: 0x04000047 RID: 71
		DeviceAuthKeyReply,
		// Token: 0x04000048 RID: 72
		DeviceConnectRequest,
		// Token: 0x04000049 RID: 73
		DeviceConnectReply,
		// Token: 0x0400004A RID: 74
		DeviceSysMapRequest,
		// Token: 0x0400004B RID: 75
		DeviceSysMapBroadcast,
		// Token: 0x0400004C RID: 76
		DeviceResetMessage,
		// Token: 0x0400004D RID: 77
		DataMessage,
		// Token: 0x0400004E RID: 78
		DataMessageAck
	}
}
