using System;
using System.Runtime.InteropServices;

namespace ADODB
{
	// Token: 0x0200002D RID: 45
	[global::System.Runtime.InteropServices.Guid("00000573-0000-0010-8000-00AA006D2EA4")]
	public enum MoveRecordOptionsEnum
	{
		// Token: 0x040001B7 RID: 439
		adMoveUnspecified = -1,
		// Token: 0x040001B8 RID: 440
		adMoveOverWrite = 1,
		// Token: 0x040001B9 RID: 441
		adMoveDontUpdateLinks,
		// Token: 0x040001BA RID: 442
		adMoveAllowEmulation = 4
	}
}
