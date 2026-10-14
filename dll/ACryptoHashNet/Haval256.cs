using System;

namespace Home.Andir.Cryptography
{
	// Token: 0x02000009 RID: 9
	public sealed class Haval256 : global::Home.Andir.Cryptography.HavalBase
	{
		// Token: 0x06000035 RID: 53 RVA: 0x0000518E File Offset: 0x0000418E
		public Haval256() : base(global::Home.Andir.Cryptography.HavalHashSize.HashSize256, global::Home.Andir.Cryptography.HavalPassCount.Pass5)
		{
		}

		// Token: 0x06000036 RID: 54 RVA: 0x0000519C File Offset: 0x0000419C
		public Haval256(global::Home.Andir.Cryptography.HavalPassCount havalPassCount) : base(global::Home.Andir.Cryptography.HavalHashSize.HashSize256, havalPassCount)
		{
		}
	}
}
