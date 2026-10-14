using System;

namespace Motorola.Common.Communication
{
	// Token: 0x02000071 RID: 113
	public enum PsdtAccessAction : byte
	{
		// Token: 0x0400023B RID: 571
		None,
		// Token: 0x0400023C RID: 572
		GetStartAddress,
		// Token: 0x0400023D RID: 573
		GetEndAddress,
		// Token: 0x0400023E RID: 574
		Lock,
		// Token: 0x0400023F RID: 575
		Unlock,
		// Token: 0x04000240 RID: 576
		Erase,
		// Token: 0x04000241 RID: 577
		Copy,
		// Token: 0x04000242 RID: 578
		ImageReorg
	}
}
