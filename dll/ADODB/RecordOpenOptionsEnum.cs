using System;
using System.Runtime.InteropServices;

namespace ADODB
{
	// Token: 0x0200001C RID: 28
	[global::System.Runtime.InteropServices.Guid("00000571-0000-0010-8000-00AA006D2EA4")]
	public enum RecordOpenOptionsEnum
	{
		// Token: 0x040000C8 RID: 200
		adOpenRecordUnspecified = -1,
		// Token: 0x040000C9 RID: 201
		[global::System.Runtime.InteropServices.TypeLibVar(64)]
		adOpenSource = 8388608,
		// Token: 0x040000CA RID: 202
		adOpenOutput = 8388608,
		// Token: 0x040000CB RID: 203
		adOpenAsync = 4096,
		// Token: 0x040000CC RID: 204
		adDelayFetchStream = 16384,
		// Token: 0x040000CD RID: 205
		adDelayFetchFields = 32768,
		// Token: 0x040000CE RID: 206
		adOpenExecuteCommand = 65536
	}
}
