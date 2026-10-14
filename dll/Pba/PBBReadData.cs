using System;
using System.Collections.Generic;

namespace Motorola.Common.Communication.Pba
{
	// Token: 0x0200000C RID: 12
	[global::System.Serializable]
	public class PBBReadData
	{
		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000035 RID: 53 RVA: 0x000023D1 File Offset: 0x000005D1
		// (set) Token: 0x06000036 RID: 54 RVA: 0x000023D9 File Offset: 0x000005D9
		public global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.PBBApp> Apps { get; set; }

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000037 RID: 55 RVA: 0x000023E2 File Offset: 0x000005E2
		// (set) Token: 0x06000038 RID: 56 RVA: 0x000023EA File Offset: 0x000005EA
		public global::System.Collections.Generic.List<string> License { get; set; }

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000039 RID: 57 RVA: 0x000023F3 File Offset: 0x000005F3
		// (set) Token: 0x0600003A RID: 58 RVA: 0x000023FB File Offset: 0x000005FB
		public string FirmwareVersion { get; set; }

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600003B RID: 59 RVA: 0x00002404 File Offset: 0x00000604
		// (set) Token: 0x0600003C RID: 60 RVA: 0x0000240C File Offset: 0x0000060C
		public string PBBFirmwareVersion { get; set; }

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600003D RID: 61 RVA: 0x00002415 File Offset: 0x00000615
		// (set) Token: 0x0600003E RID: 62 RVA: 0x0000241D File Offset: 0x0000061D
		public string CodeplugVersion { get; set; }

		// Token: 0x0600003F RID: 63 RVA: 0x00002426 File Offset: 0x00000626
		public PBBReadData()
		{
			this.Apps = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.PBBApp>();
			this.License = new global::System.Collections.Generic.List<string>();
			this.FirmwareVersion = null;
			this.PBBFirmwareVersion = null;
			this.CodeplugVersion = null;
		}
	}
}
