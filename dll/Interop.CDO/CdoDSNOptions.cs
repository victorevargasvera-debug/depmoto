using System;

namespace CDO
{
	// Token: 0x02000007 RID: 7
	public enum CdoDSNOptions
	{
		// Token: 0x0400001F RID: 31
		cdoDSNDefault,
		// Token: 0x04000020 RID: 32
		cdoDSNNever,
		// Token: 0x04000021 RID: 33
		cdoDSNFailure,
		// Token: 0x04000022 RID: 34
		cdoDSNSuccess = 4,
		// Token: 0x04000023 RID: 35
		cdoDSNDelay = 8,
		// Token: 0x04000024 RID: 36
		cdoDSNSuccessFailOrDelay = 14
	}
}
