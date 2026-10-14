using System;

namespace Home.Andir.Cryptography
{
	// Token: 0x02000007 RID: 7
	public sealed class Haval192 : global::Home.Andir.Cryptography.HavalBase
	{
		// Token: 0x06000031 RID: 49 RVA: 0x00005156 File Offset: 0x00004156
		public Haval192() : base(global::Home.Andir.Cryptography.HavalHashSize.HashSize192, global::Home.Andir.Cryptography.HavalPassCount.Pass5)
		{
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00005164 File Offset: 0x00004164
		public Haval192(global::Home.Andir.Cryptography.HavalPassCount havalPassCount) : base(global::Home.Andir.Cryptography.HavalHashSize.HashSize192, havalPassCount)
		{
		}
	}
}
