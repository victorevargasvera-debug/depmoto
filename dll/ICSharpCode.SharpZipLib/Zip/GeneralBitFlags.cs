using System;

namespace ICSharpCode.SharpZipLib.Zip
{
	// Token: 0x0200004E RID: 78
	[global::System.Flags]
	public enum GeneralBitFlags
	{
		// Token: 0x04000204 RID: 516
		Encrypted = 1,
		// Token: 0x04000205 RID: 517
		Method = 6,
		// Token: 0x04000206 RID: 518
		Descriptor = 8,
		// Token: 0x04000207 RID: 519
		ReservedPKware4 = 16,
		// Token: 0x04000208 RID: 520
		Patched = 32,
		// Token: 0x04000209 RID: 521
		StrongEncryption = 64,
		// Token: 0x0400020A RID: 522
		Unused7 = 128,
		// Token: 0x0400020B RID: 523
		Unused8 = 256,
		// Token: 0x0400020C RID: 524
		Unused9 = 512,
		// Token: 0x0400020D RID: 525
		Unused10 = 1024,
		// Token: 0x0400020E RID: 526
		UnicodeText = 2048,
		// Token: 0x0400020F RID: 527
		EnhancedCompress = 4096,
		// Token: 0x04000210 RID: 528
		HeaderMasked = 8192,
		// Token: 0x04000211 RID: 529
		ReservedPkware14 = 16384,
		// Token: 0x04000212 RID: 530
		ReservedPkware15 = 32768
	}
}
