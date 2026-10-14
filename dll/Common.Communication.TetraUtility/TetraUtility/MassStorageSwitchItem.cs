using System;

namespace Motorola.Common.Communication.TetraUtility
{
	// Token: 0x02000025 RID: 37
	public class MassStorageSwitchItem
	{
		// Token: 0x06000127 RID: 295 RVA: 0x00009BCD File Offset: 0x00007DCD
		public MassStorageSwitchItem(string tei, string cpuID, string physicalLocation, string uniqueLocation, string comPath, string diskName)
		{
			this.TEI = tei;
			this.CpuID = cpuID;
			this.PhysicalLocation = physicalLocation;
			this.UniqueLocation = uniqueLocation;
			this.ComPortPath = comPath;
			this.DiskName = diskName;
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000128 RID: 296 RVA: 0x00009C02 File Offset: 0x00007E02
		// (set) Token: 0x06000129 RID: 297 RVA: 0x00009C0A File Offset: 0x00007E0A
		public string TEI { get; set; }

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x0600012A RID: 298 RVA: 0x00009C13 File Offset: 0x00007E13
		// (set) Token: 0x0600012B RID: 299 RVA: 0x00009C1B File Offset: 0x00007E1B
		public string CpuID { get; set; }

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x0600012C RID: 300 RVA: 0x00009C24 File Offset: 0x00007E24
		// (set) Token: 0x0600012D RID: 301 RVA: 0x00009C2C File Offset: 0x00007E2C
		public string PhysicalLocation { get; set; }

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x0600012E RID: 302 RVA: 0x00009C35 File Offset: 0x00007E35
		// (set) Token: 0x0600012F RID: 303 RVA: 0x00009C3D File Offset: 0x00007E3D
		public string UniqueLocation { get; set; }

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000130 RID: 304 RVA: 0x00009C46 File Offset: 0x00007E46
		// (set) Token: 0x06000131 RID: 305 RVA: 0x00009C4E File Offset: 0x00007E4E
		public string ComPortPath { get; set; }

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000132 RID: 306 RVA: 0x00009C57 File Offset: 0x00007E57
		// (set) Token: 0x06000133 RID: 307 RVA: 0x00009C5F File Offset: 0x00007E5F
		public string DiskName { get; set; }
	}
}
