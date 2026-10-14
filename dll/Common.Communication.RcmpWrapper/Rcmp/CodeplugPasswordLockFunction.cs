using System;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x02000008 RID: 8
	public enum CodeplugPasswordLockFunction : byte
	{
		// Token: 0x0400001C RID: 28
		RequestStatus,
		// Token: 0x0400001D RID: 29
		VerifyPassword,
		// Token: 0x0400001E RID: 30
		PairDevice,
		// Token: 0x0400001F RID: 31
		UnpairDevice,
		// Token: 0x04000020 RID: 32
		VerifyPair
	}
}
