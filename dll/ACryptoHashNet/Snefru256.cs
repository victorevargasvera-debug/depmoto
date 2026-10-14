using System;

namespace Home.Andir.Cryptography
{
	// Token: 0x02000019 RID: 25
	public sealed class Snefru256 : global::Home.Andir.Cryptography.SnefruBase
	{
		// Token: 0x060000A0 RID: 160 RVA: 0x00010C23 File Offset: 0x0000FC23
		public Snefru256() : base(global::Home.Andir.Cryptography.SnefruOutputSize.Output8)
		{
			this.HashSizeValue = 256;
		}
	}
}
