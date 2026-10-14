using System;

namespace Motorola.Common.Communication.SequenceManager
{
	// Token: 0x0200003B RID: 59
	internal enum DeviceType : uint
	{
		// Token: 0x04000109 RID: 265
		Unknown,
		// Token: 0x0400010A RID: 266
		PortablePlain,
		// Token: 0x0400010B RID: 267
		PortableDisplay,
		// Token: 0x0400010C RID: 268
		AndorraPlain = 4U,
		// Token: 0x0400010D RID: 269
		AndorraDisplay = 8U,
		// Token: 0x0400010E RID: 270
		MobilePlain = 16U,
		// Token: 0x0400010F RID: 271
		MobileDisplay = 32U,
		// Token: 0x04000110 RID: 272
		TahitiPlus = 64U,
		// Token: 0x04000111 RID: 273
		Repeater = 128U,
		// Token: 0x04000112 RID: 274
		BanditRepeater = 256U,
		// Token: 0x04000113 RID: 275
		TimorPlain = 512U,
		// Token: 0x04000114 RID: 276
		TongaPlus = 1024U,
		// Token: 0x04000115 RID: 277
		Any = 65535U
	}
}
