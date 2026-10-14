using System;

namespace Home.Andir.Cryptography
{
	// Token: 0x02000008 RID: 8
	public sealed class Haval224 : global::Home.Andir.Cryptography.HavalBase
	{
		// Token: 0x06000033 RID: 51 RVA: 0x00005172 File Offset: 0x00004172
		public Haval224() : base(global::Home.Andir.Cryptography.HavalHashSize.HashSize224, global::Home.Andir.Cryptography.HavalPassCount.Pass5)
		{
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00005180 File Offset: 0x00004180
		public Haval224(global::Home.Andir.Cryptography.HavalPassCount havalPassCount) : base(global::Home.Andir.Cryptography.HavalHashSize.HashSize224, havalPassCount)
		{
		}
	}
}
