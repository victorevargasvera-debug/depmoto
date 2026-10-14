using System;

namespace Motorola.Common.Communication.RUDP
{
	// Token: 0x0200000B RID: 11
	public enum RUDPReplyResult
	{
		// Token: 0x04000048 RID: 72
		RUDPReply_Success,
		// Token: 0x04000049 RID: 73
		RUDPReply_Isconnected,
		// Token: 0x0400004A RID: 74
		RUDPReply_Connecting,
		// Token: 0x0400004B RID: 75
		RUDPReply_ConnectFail,
		// Token: 0x0400004C RID: 76
		RUDPReply_ServerRefusedConnection,
		// Token: 0x0400004D RID: 77
		RUDPReply_Uninitialized,
		// Token: 0x0400004E RID: 78
		RUDPReply_SendFailed,
		// Token: 0x0400004F RID: 79
		RUDPReply_SendTimeout,
		// Token: 0x04000050 RID: 80
		RUDPReply_ReceiveFailed,
		// Token: 0x04000051 RID: 81
		RUDPReply_ReceiveTimeout,
		// Token: 0x04000052 RID: 82
		RUDPReply_CloseFail,
		// Token: 0x04000053 RID: 83
		RUDPReply_CloseInProgress
	}
}
