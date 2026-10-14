using System;
using System.Runtime.InteropServices;

namespace ADODB
{
	// Token: 0x02000004 RID: 4
	[global::System.Runtime.InteropServices.Guid("0000051D-0000-0010-8000-00AA006D2EA4")]
	public enum LockTypeEnum
	{
		// Token: 0x04000016 RID: 22
		[global::System.Runtime.InteropServices.TypeLibVar(64)]
		adLockUnspecified = -1,
		// Token: 0x04000017 RID: 23
		adLockReadOnly = 1,
		// Token: 0x04000018 RID: 24
		adLockPessimistic,
		// Token: 0x04000019 RID: 25
		adLockOptimistic,
		// Token: 0x0400001A RID: 26
		adLockBatchOptimistic
	}
}
