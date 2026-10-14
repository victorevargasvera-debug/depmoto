using System;

namespace Motorola.Common.Communication
{
	// Token: 0x0200000F RID: 15
	public enum TerminationReasonCode
	{
		// Token: 0x04000022 RID: 34
		JobComplete = 10,
		// Token: 0x04000023 RID: 35
		SessionAbort,
		// Token: 0x04000024 RID: 36
		InactivityTimerExpired,
		// Token: 0x04000025 RID: 37
		FactoryReset,
		// Token: 0x04000026 RID: 38
		HaveNoJob
	}
}
