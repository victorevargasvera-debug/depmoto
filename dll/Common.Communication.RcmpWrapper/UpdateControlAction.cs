using System;

namespace Motorola.Common.Communication
{
	// Token: 0x02000072 RID: 114
	public enum UpdateControlAction : byte
	{
		// Token: 0x04000244 RID: 580
		None,
		// Token: 0x04000245 RID: 581
		RadioFirmwareActive,
		// Token: 0x04000246 RID: 582
		RadioCodeplugActive,
		// Token: 0x04000247 RID: 583
		RadioUpdateFirmware,
		// Token: 0x04000248 RID: 584
		RadioUpdateCodeplug,
		// Token: 0x04000249 RID: 585
		RadioValidateFirmware,
		// Token: 0x0400024A RID: 586
		RadioValidateCodeplug,
		// Token: 0x0400024B RID: 587
		RadioDefaultAddrMode,
		// Token: 0x0400024C RID: 588
		RadioAbsAddrMode,
		// Token: 0x0400024D RID: 589
		StopBGEraser,
		// Token: 0x0400024E RID: 590
		UpdateStatus,
		// Token: 0x0400024F RID: 591
		SetDecomp,
		// Token: 0x04000250 RID: 592
		SetChecksum,
		// Token: 0x04000251 RID: 593
		CHBootAppUpdate,
		// Token: 0x04000252 RID: 594
		OBBootAppUpdate,
		// Token: 0x04000253 RID: 595
		COBootAppUpdate,
		// Token: 0x04000254 RID: 596
		CommitUpdate,
		// Token: 0x04000255 RID: 597
		OverwriteActivePartition = 18
	}
}
