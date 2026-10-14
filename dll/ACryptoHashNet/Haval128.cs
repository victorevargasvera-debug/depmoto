using System;

namespace Home.Andir.Cryptography
{
	// Token: 0x02000005 RID: 5
	public sealed class Haval128 : global::Home.Andir.Cryptography.HavalBase
	{
		// Token: 0x0600002D RID: 45 RVA: 0x0000511E File Offset: 0x0000411E
		public Haval128() : base(global::Home.Andir.Cryptography.HavalHashSize.HashSize128, global::Home.Andir.Cryptography.HavalPassCount.Pass5)
		{
		}

		// Token: 0x0600002E RID: 46 RVA: 0x0000512C File Offset: 0x0000412C
		public Haval128(global::Home.Andir.Cryptography.HavalPassCount havalPassCount) : base(global::Home.Andir.Cryptography.HavalHashSize.HashSize128, havalPassCount)
		{
		}
	}
}
