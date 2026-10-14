using System;

namespace Motorola.Common.Communication.TetraUtility
{
	// Token: 0x02000004 RID: 4
	internal class CodeAllowPair
	{
		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600001A RID: 26 RVA: 0x000047D7 File Offset: 0x000029D7
		// (set) Token: 0x0600001B RID: 27 RVA: 0x000047DF File Offset: 0x000029DF
		public ushort Code { get; set; }

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600001C RID: 28 RVA: 0x000047E8 File Offset: 0x000029E8
		// (set) Token: 0x0600001D RID: 29 RVA: 0x000047F0 File Offset: 0x000029F0
		public bool IsInputable { get; set; }
	}
}
