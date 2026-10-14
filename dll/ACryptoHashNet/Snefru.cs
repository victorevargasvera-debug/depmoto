using System;

namespace Home.Andir.Cryptography
{
	// Token: 0x02000018 RID: 24
	public sealed class Snefru : global::Home.Andir.Cryptography.SnefruBase
	{
		// Token: 0x0600009F RID: 159 RVA: 0x00010C0F File Offset: 0x0000FC0F
		public Snefru() : base(global::Home.Andir.Cryptography.SnefruOutputSize.Output4)
		{
			this.HashSizeValue = 128;
		}
	}
}
