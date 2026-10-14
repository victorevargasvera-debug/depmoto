using System;
using System.Runtime.InteropServices;

namespace ADODB
{
	// Token: 0x02000025 RID: 37
	[global::System.Runtime.InteropServices.Guid("00000531-0000-0010-8000-00AA006D2EA4")]
	public enum EventReasonEnum
	{
		// Token: 0x0400013D RID: 317
		adRsnAddNew = 1,
		// Token: 0x0400013E RID: 318
		adRsnDelete,
		// Token: 0x0400013F RID: 319
		adRsnUpdate,
		// Token: 0x04000140 RID: 320
		adRsnUndoUpdate,
		// Token: 0x04000141 RID: 321
		adRsnUndoAddNew,
		// Token: 0x04000142 RID: 322
		adRsnUndoDelete,
		// Token: 0x04000143 RID: 323
		adRsnRequery,
		// Token: 0x04000144 RID: 324
		adRsnResynch,
		// Token: 0x04000145 RID: 325
		adRsnClose,
		// Token: 0x04000146 RID: 326
		adRsnMove,
		// Token: 0x04000147 RID: 327
		adRsnFirstChange,
		// Token: 0x04000148 RID: 328
		adRsnMoveFirst,
		// Token: 0x04000149 RID: 329
		adRsnMoveNext,
		// Token: 0x0400014A RID: 330
		adRsnMovePrevious,
		// Token: 0x0400014B RID: 331
		adRsnMoveLast
	}
}
