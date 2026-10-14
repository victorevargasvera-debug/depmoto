using System;

namespace Motorola.Common.Communication.FDT
{
	// Token: 0x0200000A RID: 10
	public class FDTParams
	{
		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000053 RID: 83 RVA: 0x0000370C File Offset: 0x0000190C
		// (set) Token: 0x06000054 RID: 84 RVA: 0x00003714 File Offset: 0x00001914
		public string cpVersion { get; set; }

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000055 RID: 85 RVA: 0x0000371D File Offset: 0x0000191D
		// (set) Token: 0x06000056 RID: 86 RVA: 0x00003725 File Offset: 0x00001925
		public string uniqueModelNumber { get; set; }

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000057 RID: 87 RVA: 0x0000372E File Offset: 0x0000192E
		// (set) Token: 0x06000058 RID: 88 RVA: 0x00003736 File Offset: 0x00001936
		public ushort modelType { get; set; }

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000059 RID: 89 RVA: 0x0000373F File Offset: 0x0000193F
		// (set) Token: 0x0600005A RID: 90 RVA: 0x00003747 File Offset: 0x00001947
		public string serialNumber { get; set; }
	}
}
