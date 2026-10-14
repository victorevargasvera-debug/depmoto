using System;
using System.IO;

namespace Motorola.Common.Communication
{
	// Token: 0x02000006 RID: 6
	public class ResourceRecord
	{
		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000032 RID: 50 RVA: 0x0000239D File Offset: 0x0000059D
		// (set) Token: 0x06000033 RID: 51 RVA: 0x000023A5 File Offset: 0x000005A5
		public string NAME { get; set; }

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000034 RID: 52 RVA: 0x000023AE File Offset: 0x000005AE
		// (set) Token: 0x06000035 RID: 53 RVA: 0x000023B6 File Offset: 0x000005B6
		public ushort TYPE { get; set; }

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000036 RID: 54 RVA: 0x000023BF File Offset: 0x000005BF
		// (set) Token: 0x06000037 RID: 55 RVA: 0x000023C7 File Offset: 0x000005C7
		public ushort CLASS { get; set; }

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000038 RID: 56 RVA: 0x000023D0 File Offset: 0x000005D0
		// (set) Token: 0x06000039 RID: 57 RVA: 0x000023D8 File Offset: 0x000005D8
		public bool IsCacheFlush { get; set; }

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600003A RID: 58 RVA: 0x000023E1 File Offset: 0x000005E1
		// (set) Token: 0x0600003B RID: 59 RVA: 0x000023E9 File Offset: 0x000005E9
		public uint TTL { get; set; }

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600003C RID: 60 RVA: 0x000023F2 File Offset: 0x000005F2
		// (set) Token: 0x0600003D RID: 61 RVA: 0x000023FA File Offset: 0x000005FA
		public ushort RDLENGTH { get; set; }

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600003E RID: 62 RVA: 0x00002403 File Offset: 0x00000603
		// (set) Token: 0x0600003F RID: 63 RVA: 0x0000240B File Offset: 0x0000060B
		public byte[] RDATA { get; set; }

		// Token: 0x06000040 RID: 64 RVA: 0x00002414 File Offset: 0x00000614
		public virtual void Serialize(global::System.IO.Stream stream)
		{
			throw new global::System.NotImplementedException();
		}
	}
}
