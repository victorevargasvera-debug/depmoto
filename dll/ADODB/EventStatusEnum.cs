using System;
using System.Runtime.InteropServices;

namespace ADODB
{
	// Token: 0x02000024 RID: 36
	[global::System.Runtime.InteropServices.Guid("00000530-0000-0010-8000-00AA006D2EA4")]
	public enum EventStatusEnum
	{
		// Token: 0x04000137 RID: 311
		adStatusOK = 1,
		// Token: 0x04000138 RID: 312
		adStatusErrorsOccurred,
		// Token: 0x04000139 RID: 313
		adStatusCantDeny,
		// Token: 0x0400013A RID: 314
		adStatusCancel,
		// Token: 0x0400013B RID: 315
		adStatusUnwantedEvent
	}
}
