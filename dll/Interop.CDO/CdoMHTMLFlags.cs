using System;

namespace CDO
{
	// Token: 0x02000010 RID: 16
	public enum CdoMHTMLFlags
	{
		// Token: 0x0400004E RID: 78
		cdoSuppressNone,
		// Token: 0x0400004F RID: 79
		cdoSuppressImages,
		// Token: 0x04000050 RID: 80
		cdoSuppressBGSounds,
		// Token: 0x04000051 RID: 81
		cdoSuppressFrames = 4,
		// Token: 0x04000052 RID: 82
		cdoSuppressObjects = 8,
		// Token: 0x04000053 RID: 83
		cdoSuppressStyleSheets = 16,
		// Token: 0x04000054 RID: 84
		cdoSuppressAll = 31
	}
}
