using System;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x0200007B RID: 123
	[global::System.Flags]
	public enum LanguagePackControlOperation : byte
	{
		// Token: 0x04000275 RID: 629
		AddLanguagePackStart = 0,
		// Token: 0x04000276 RID: 630
		AddLanguagePackUnit = 1,
		// Token: 0x04000277 RID: 631
		AddLanguagePackEnd = 2,
		// Token: 0x04000278 RID: 632
		SetDefaultLanguagePack = 3,
		// Token: 0x04000279 RID: 633
		DeleteLanguagePack = 16
	}
}
