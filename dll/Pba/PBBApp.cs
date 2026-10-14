using System;

namespace Motorola.Common.Communication.Pba
{
	// Token: 0x0200000B RID: 11
	[global::System.Serializable]
	public class PBBApp
	{
		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600002C RID: 44 RVA: 0x00002385 File Offset: 0x00000585
		// (set) Token: 0x0600002D RID: 45 RVA: 0x0000238D File Offset: 0x0000058D
		public string Name { get; set; }

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600002E RID: 46 RVA: 0x00002396 File Offset: 0x00000596
		// (set) Token: 0x0600002F RID: 47 RVA: 0x0000239E File Offset: 0x0000059E
		public string VersionName { get; set; }

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000030 RID: 48 RVA: 0x000023A7 File Offset: 0x000005A7
		// (set) Token: 0x06000031 RID: 49 RVA: 0x000023AF File Offset: 0x000005AF
		public int VersionCode { get; set; }

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000032 RID: 50 RVA: 0x000023B8 File Offset: 0x000005B8
		// (set) Token: 0x06000033 RID: 51 RVA: 0x000023C0 File Offset: 0x000005C0
		public string Label { get; set; }
	}
}
