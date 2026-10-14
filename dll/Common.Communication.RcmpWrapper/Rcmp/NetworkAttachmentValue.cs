using System;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x02000043 RID: 67
	public enum NetworkAttachmentValue : byte
	{
		// Token: 0x04000128 RID: 296
		NoDefaultGateway,
		// Token: 0x04000129 RID: 297
		OneG,
		// Token: 0x0400012A RID: 298
		TwoG,
		// Token: 0x0400012B RID: 299
		ThreeG,
		// Token: 0x0400012C RID: 300
		FourG,
		// Token: 0x0400012D RID: 301
		WiFi,
		// Token: 0x0400012E RID: 302
		LMR = 255
	}
}
