using System;
using Motorola.Common.Communication.CommonUtil;

namespace Motorola.Common.Communication.Service
{
	// Token: 0x0200000B RID: 11
	public class InitializedParameters
	{
		// Token: 0x17000011 RID: 17
		// (get) Token: 0x060001F5 RID: 501 RVA: 0x000072C4 File Offset: 0x000054C4
		// (set) Token: 0x060001F6 RID: 502 RVA: 0x000072CC File Offset: 0x000054CC
		public int deviceFamilySet { get; set; }

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x060001F7 RID: 503 RVA: 0x000072D5 File Offset: 0x000054D5
		// (set) Token: 0x060001F8 RID: 504 RVA: 0x000072DD File Offset: 0x000054DD
		public global::Motorola.Common.Communication.CommonUtil.WorkMode workMode { get; set; }

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x060001F9 RID: 505 RVA: 0x000072E6 File Offset: 0x000054E6
		// (set) Token: 0x060001FA RID: 506 RVA: 0x000072EE File Offset: 0x000054EE
		public string VRFolder { get; set; }

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x060001FB RID: 507 RVA: 0x000072F7 File Offset: 0x000054F7
		// (set) Token: 0x060001FC RID: 508 RVA: 0x000072FF File Offset: 0x000054FF
		public string LogFolder { get; set; }
	}
}
