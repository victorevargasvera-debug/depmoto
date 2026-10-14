using System;

namespace ICSharpCode.SharpZipLib.Zip
{
	// Token: 0x0200004C RID: 76
	public enum CompressionMethod
	{
		// Token: 0x040001EF RID: 495
		Stored,
		// Token: 0x040001F0 RID: 496
		Deflated = 8,
		// Token: 0x040001F1 RID: 497
		Deflate64,
		// Token: 0x040001F2 RID: 498
		BZip2 = 11,
		// Token: 0x040001F3 RID: 499
		WinZipAES = 99
	}
}
