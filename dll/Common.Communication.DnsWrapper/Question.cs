using System;

namespace Motorola.Common.Communication
{
	// Token: 0x02000005 RID: 5
	public class Question
	{
		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600002B RID: 43 RVA: 0x00002362 File Offset: 0x00000562
		// (set) Token: 0x0600002C RID: 44 RVA: 0x0000236A File Offset: 0x0000056A
		public string QNAME { get; set; }

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600002D RID: 45 RVA: 0x00002373 File Offset: 0x00000573
		// (set) Token: 0x0600002E RID: 46 RVA: 0x0000237B File Offset: 0x0000057B
		public ushort QTYPE { get; set; }

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600002F RID: 47 RVA: 0x00002384 File Offset: 0x00000584
		// (set) Token: 0x06000030 RID: 48 RVA: 0x0000238C File Offset: 0x0000058C
		public ushort QClass { get; set; }
	}
}
