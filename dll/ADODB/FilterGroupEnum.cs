using System;
using System.Runtime.InteropServices;

namespace ADODB
{
	// Token: 0x02000014 RID: 20
	[global::System.Runtime.InteropServices.Guid("00000546-0000-0010-8000-00AA006D2EA4")]
	public enum FilterGroupEnum
	{
		// Token: 0x040000A0 RID: 160
		adFilterNone,
		// Token: 0x040000A1 RID: 161
		adFilterPendingRecords,
		// Token: 0x040000A2 RID: 162
		adFilterAffectedRecords,
		// Token: 0x040000A3 RID: 163
		adFilterFetchedRecords,
		// Token: 0x040000A4 RID: 164
		[global::System.Runtime.InteropServices.TypeLibVar(64)]
		adFilterPredicate,
		// Token: 0x040000A5 RID: 165
		adFilterConflictingRecords
	}
}
