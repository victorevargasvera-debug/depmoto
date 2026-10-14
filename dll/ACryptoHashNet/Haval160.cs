using System;

namespace Home.Andir.Cryptography
{
	// Token: 0x02000006 RID: 6
	public sealed class Haval160 : global::Home.Andir.Cryptography.HavalBase
	{
		// Token: 0x0600002F RID: 47 RVA: 0x0000513A File Offset: 0x0000413A
		public Haval160() : base(global::Home.Andir.Cryptography.HavalHashSize.HashSize160, global::Home.Andir.Cryptography.HavalPassCount.Pass5)
		{
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00005148 File Offset: 0x00004148
		public Haval160(global::Home.Andir.Cryptography.HavalPassCount havalPassCount) : base(global::Home.Andir.Cryptography.HavalHashSize.HashSize160, havalPassCount)
		{
		}
	}
}
