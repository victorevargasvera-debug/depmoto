using System;

namespace fxpcommunication
{
	// Token: 0x0200000B RID: 11
	internal enum OperationEnum : ushort
	{
		// Token: 0x0400004A RID: 74
		eDiscard = 1,
		// Token: 0x0400004B RID: 75
		eDiscardAck,
		// Token: 0x0400004C RID: 76
		eFeatureSessionRequest,
		// Token: 0x0400004D RID: 77
		eFeatureSessionRequestAck,
		// Token: 0x0400004E RID: 78
		eFeatureCodeTransfer,
		// Token: 0x0400004F RID: 79
		eFeatureCodeTransferAck,
		// Token: 0x04000050 RID: 80
		eFeatureLockRequest,
		// Token: 0x04000051 RID: 81
		eFeatureLockRequestAck,
		// Token: 0x04000052 RID: 82
		eFeatureUnlockRequest,
		// Token: 0x04000053 RID: 83
		eFeatureUnlockRequestAck
	}
}
