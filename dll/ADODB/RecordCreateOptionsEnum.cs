using System;
using System.Runtime.InteropServices;

namespace ADODB
{
	// Token: 0x0200001B RID: 27
	[global::System.Runtime.InteropServices.Guid("00000570-0000-0010-8000-00AA006D2EA4")]
	public enum RecordCreateOptionsEnum
	{
		// Token: 0x040000C1 RID: 193
		adCreateCollection = 8192,
		// Token: 0x040000C2 RID: 194
		adCreateStructDoc = -2147483648,
		// Token: 0x040000C3 RID: 195
		adCreateNonCollection = 0,
		// Token: 0x040000C4 RID: 196
		adOpenIfExists = 33554432,
		// Token: 0x040000C5 RID: 197
		adCreateOverwrite = 67108864,
		// Token: 0x040000C6 RID: 198
		adFailIfNotExists = -1
	}
}
