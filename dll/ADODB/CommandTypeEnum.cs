using System;
using System.Runtime.InteropServices;

namespace ADODB
{
	// Token: 0x02000023 RID: 35
	[global::System.Runtime.InteropServices.Guid("0000052E-0000-0010-8000-00AA006D2EA4")]
	public enum CommandTypeEnum
	{
		// Token: 0x0400012F RID: 303
		[global::System.Runtime.InteropServices.TypeLibVar(64)]
		adCmdUnspecified = -1,
		// Token: 0x04000130 RID: 304
		adCmdUnknown = 8,
		// Token: 0x04000131 RID: 305
		adCmdText = 1,
		// Token: 0x04000132 RID: 306
		adCmdTable,
		// Token: 0x04000133 RID: 307
		adCmdStoredProc = 4,
		// Token: 0x04000134 RID: 308
		adCmdFile = 256,
		// Token: 0x04000135 RID: 309
		adCmdTableDirect = 512
	}
}
