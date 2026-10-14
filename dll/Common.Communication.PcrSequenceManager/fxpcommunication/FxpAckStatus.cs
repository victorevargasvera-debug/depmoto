using System;

namespace fxpcommunication
{
	// Token: 0x02000008 RID: 8
	internal enum FxpAckStatus
	{
		// Token: 0x04000038 RID: 56
		FeatureSessionRequestSuccess = 1,
		// Token: 0x04000039 RID: 57
		FeatureSessionRequestInProgress,
		// Token: 0x0400003A RID: 58
		FeatureCodeTransferSuccess = 1,
		// Token: 0x0400003B RID: 59
		FeatureCodeTransferError,
		// Token: 0x0400003C RID: 60
		FeatureLockUnlockSuccess = 1,
		// Token: 0x0400003D RID: 61
		FeatureLockUnlockError
	}
}
