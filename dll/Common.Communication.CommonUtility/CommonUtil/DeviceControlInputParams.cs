using System;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x02000003 RID: 3
	public class DeviceControlInputParams
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000004 RID: 4 RVA: 0x00002174 File Offset: 0x00000374
		// (set) Token: 0x06000005 RID: 5 RVA: 0x0000218B File Offset: 0x0000038B
		public global::Motorola.Common.Communication.CommonUtil.ProductFamily family { get; set; }

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000006 RID: 6 RVA: 0x00002194 File Offset: 0x00000394
		// (set) Token: 0x06000007 RID: 7 RVA: 0x000021AB File Offset: 0x000003AB
		public global::Motorola.Common.Communication.CommonUtil.DeviceControlOperationType type { get; set; }
	}
}
