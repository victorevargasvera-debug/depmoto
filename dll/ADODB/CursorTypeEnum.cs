using System;
using System.Runtime.InteropServices;

namespace ADODB
{
	// Token: 0x02000002 RID: 2
	[global::System.Runtime.InteropServices.Guid("0000051B-0000-0010-8000-00AA006D2EA4")]
	public enum CursorTypeEnum
	{
		// Token: 0x04000002 RID: 2
		[global::System.Runtime.InteropServices.TypeLibVar(64)]
		adOpenUnspecified = -1,
		// Token: 0x04000003 RID: 3
		adOpenForwardOnly,
		// Token: 0x04000004 RID: 4
		adOpenKeyset,
		// Token: 0x04000005 RID: 5
		adOpenDynamic,
		// Token: 0x04000006 RID: 6
		adOpenStatic
	}
}
