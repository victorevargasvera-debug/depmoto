using System;
using System.Runtime.InteropServices;

namespace ADODB
{
	// Token: 0x0200000C RID: 12
	[global::System.Runtime.InteropServices.Guid("00000527-0000-0010-8000-00AA006D2EA4")]
	public enum RecordStatusEnum
	{
		// Token: 0x04000072 RID: 114
		adRecOK,
		// Token: 0x04000073 RID: 115
		adRecNew,
		// Token: 0x04000074 RID: 116
		adRecModified,
		// Token: 0x04000075 RID: 117
		adRecDeleted = 4,
		// Token: 0x04000076 RID: 118
		adRecUnmodified = 8,
		// Token: 0x04000077 RID: 119
		adRecInvalid = 16,
		// Token: 0x04000078 RID: 120
		adRecMultipleChanges = 64,
		// Token: 0x04000079 RID: 121
		adRecPendingChanges = 128,
		// Token: 0x0400007A RID: 122
		adRecCanceled = 256,
		// Token: 0x0400007B RID: 123
		adRecCantRelease = 1024,
		// Token: 0x0400007C RID: 124
		adRecConcurrencyViolation = 2048,
		// Token: 0x0400007D RID: 125
		adRecIntegrityViolation = 4096,
		// Token: 0x0400007E RID: 126
		adRecMaxChangesExceeded = 8192,
		// Token: 0x0400007F RID: 127
		adRecObjectOpen = 16384,
		// Token: 0x04000080 RID: 128
		adRecOutOfMemory = 32768,
		// Token: 0x04000081 RID: 129
		adRecPermissionDenied = 65536,
		// Token: 0x04000082 RID: 130
		adRecSchemaViolation = 131072,
		// Token: 0x04000083 RID: 131
		adRecDBDeleted = 262144
	}
}
