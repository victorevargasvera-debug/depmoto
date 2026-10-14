using System;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x0200007D RID: 125
	[global::System.Flags]
	public enum TTSLanguagePackControlOperation : byte
	{
		// Token: 0x0400027F RID: 639
		AddTTSLanguagePackStart = 32,
		// Token: 0x04000280 RID: 640
		AddTTSLanguagePackUnit = 33,
		// Token: 0x04000281 RID: 641
		AddTTSLanguagePackEnd = 34,
		// Token: 0x04000282 RID: 642
		SetDefaultTTSLanguagePack = 35,
		// Token: 0x04000283 RID: 643
		DeleteTTSLanguagePack = 48
	}
}
