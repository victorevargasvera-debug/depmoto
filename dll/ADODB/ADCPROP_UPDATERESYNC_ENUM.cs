using System;
using System.Runtime.InteropServices;

namespace ADODB
{
	// Token: 0x0200002C RID: 44
	[global::System.Runtime.InteropServices.Guid("00000553-0000-0010-8000-00AA006D2EA4")]
	public enum ADCPROP_UPDATERESYNC_ENUM
	{
		// Token: 0x040001B0 RID: 432
		adResyncNone,
		// Token: 0x040001B1 RID: 433
		adResyncAutoIncrement,
		// Token: 0x040001B2 RID: 434
		adResyncConflicts,
		// Token: 0x040001B3 RID: 435
		adResyncUpdates = 4,
		// Token: 0x040001B4 RID: 436
		adResyncInserts = 8,
		// Token: 0x040001B5 RID: 437
		adResyncAll = 15
	}
}
