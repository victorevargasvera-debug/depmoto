using System;

namespace ICSharpCode.SharpZipLib.Zip
{
	// Token: 0x0200004D RID: 77
	public enum EncryptionAlgorithm
	{
		// Token: 0x040001F5 RID: 501
		None,
		// Token: 0x040001F6 RID: 502
		PkzipClassic,
		// Token: 0x040001F7 RID: 503
		Des = 26113,
		// Token: 0x040001F8 RID: 504
		RC2,
		// Token: 0x040001F9 RID: 505
		TripleDes168,
		// Token: 0x040001FA RID: 506
		TripleDes112 = 26121,
		// Token: 0x040001FB RID: 507
		Aes128 = 26126,
		// Token: 0x040001FC RID: 508
		Aes192,
		// Token: 0x040001FD RID: 509
		Aes256,
		// Token: 0x040001FE RID: 510
		RC2Corrected = 26370,
		// Token: 0x040001FF RID: 511
		Blowfish = 26400,
		// Token: 0x04000200 RID: 512
		Twofish,
		// Token: 0x04000201 RID: 513
		RC4 = 26625,
		// Token: 0x04000202 RID: 514
		Unknown = 65535
	}
}
