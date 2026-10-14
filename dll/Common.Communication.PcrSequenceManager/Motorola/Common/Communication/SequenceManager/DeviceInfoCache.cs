using System;
using Motorola.Common.Communication.CommonUtil;

namespace Motorola.Common.Communication.SequenceManager
{
	// Token: 0x02000036 RID: 54
	internal class DeviceInfoCache
	{
		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060001AE RID: 430 RVA: 0x000100E8 File Offset: 0x0000E2E8
		// (set) Token: 0x060001AF RID: 431 RVA: 0x000100FF File Offset: 0x0000E2FF
		public global::Motorola.Common.Communication.CommonUtil.PCRDeviceInfo DeviceInfo { get; set; }

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060001B0 RID: 432 RVA: 0x00010108 File Offset: 0x0000E308
		// (set) Token: 0x060001B1 RID: 433 RVA: 0x0001011F File Offset: 0x0000E31F
		public bool IsLowBattery { get; set; }
	}
}
