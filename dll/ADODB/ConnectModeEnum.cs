using System;
using System.Runtime.InteropServices;

namespace ADODB
{
	// Token: 0x0200001A RID: 26
	[global::System.Runtime.InteropServices.Guid("00000521-0000-0010-8000-00AA006D2EA4")]
	public enum ConnectModeEnum
	{
		// Token: 0x040000B7 RID: 183
		adModeUnknown,
		// Token: 0x040000B8 RID: 184
		adModeRead,
		// Token: 0x040000B9 RID: 185
		adModeWrite,
		// Token: 0x040000BA RID: 186
		adModeReadWrite,
		// Token: 0x040000BB RID: 187
		adModeShareDenyRead,
		// Token: 0x040000BC RID: 188
		adModeShareDenyWrite = 8,
		// Token: 0x040000BD RID: 189
		adModeShareExclusive = 12,
		// Token: 0x040000BE RID: 190
		adModeShareDenyNone = 16,
		// Token: 0x040000BF RID: 191
		adModeRecursive = 4194304
	}
}
