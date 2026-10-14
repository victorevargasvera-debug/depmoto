using System;
using System.Text.RegularExpressions;

namespace Motorola.Common.Communication.SequenceManager
{
	// Token: 0x0200003C RID: 60
	internal class ModelType
	{
		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060001DD RID: 477 RVA: 0x00011254 File Offset: 0x0000F454
		// (set) Token: 0x060001DE RID: 478 RVA: 0x0001126B File Offset: 0x0000F46B
		public global::Motorola.Common.Communication.SequenceManager.DeviceType DeviceType { get; set; }

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060001DF RID: 479 RVA: 0x00011274 File Offset: 0x0000F474
		// (set) Token: 0x060001E0 RID: 480 RVA: 0x0001128B File Offset: 0x0000F48B
		public global::System.Text.RegularExpressions.Regex Regex { get; set; }
	}
}
