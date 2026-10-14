using System;

namespace Motorola.Common.Communication.Pba
{
	// Token: 0x0200000D RID: 13
	[global::System.Serializable]
	public class DenaliCPValidationInfo
	{
		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000040 RID: 64 RVA: 0x00002459 File Offset: 0x00000659
		// (set) Token: 0x06000041 RID: 65 RVA: 0x00002461 File Offset: 0x00000661
		public string SerialNumber { get; set; }

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000042 RID: 66 RVA: 0x0000246A File Offset: 0x0000066A
		// (set) Token: 0x06000043 RID: 67 RVA: 0x00002472 File Offset: 0x00000672
		public string ModelNumber { get; set; }

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000044 RID: 68 RVA: 0x0000247B File Offset: 0x0000067B
		// (set) Token: 0x06000045 RID: 69 RVA: 0x00002483 File Offset: 0x00000683
		public string RadioUuid { get; set; }

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000046 RID: 70 RVA: 0x0000248C File Offset: 0x0000068C
		// (set) Token: 0x06000047 RID: 71 RVA: 0x00002494 File Offset: 0x00000694
		public string CodeplugVersion { get; set; }

		// Token: 0x06000048 RID: 72 RVA: 0x0000249D File Offset: 0x0000069D
		public DenaliCPValidationInfo()
		{
			this.SerialNumber = null;
			this.ModelNumber = null;
			this.RadioUuid = null;
			this.CodeplugVersion = null;
		}
	}
}
