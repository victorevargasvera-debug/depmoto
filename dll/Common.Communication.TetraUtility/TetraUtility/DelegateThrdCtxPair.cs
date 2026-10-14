using System;
using System.Threading;

namespace Motorola.Common.Communication.TetraUtility
{
	// Token: 0x02000082 RID: 130
	internal class DelegateThrdCtxPair
	{
		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x06000323 RID: 803 RVA: 0x0000FEAA File Offset: 0x0000E0AA
		// (set) Token: 0x06000324 RID: 804 RVA: 0x0000FEB2 File Offset: 0x0000E0B2
		public global::System.Delegate Delegate { get; set; }

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x06000325 RID: 805 RVA: 0x0000FEBB File Offset: 0x0000E0BB
		// (set) Token: 0x06000326 RID: 806 RVA: 0x0000FEC3 File Offset: 0x0000E0C3
		public global::Motorola.Common.Communication.TetraUtility.WeakDelegate WeakDelegate { get; set; }

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x06000327 RID: 807 RVA: 0x0000FECC File Offset: 0x0000E0CC
		// (set) Token: 0x06000328 RID: 808 RVA: 0x0000FED4 File Offset: 0x0000E0D4
		public global::System.Threading.SynchronizationContext Context { get; set; }
	}
}
