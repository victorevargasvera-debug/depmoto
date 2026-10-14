using System;

namespace Motorola.Common.Communication
{
	// Token: 0x02000005 RID: 5
	public class RnlBrdcstMsgEventArgs : global::System.EventArgs
	{
		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000020 RID: 32 RVA: 0x000026D1 File Offset: 0x000008D1
		// (set) Token: 0x06000021 RID: 33 RVA: 0x000026D9 File Offset: 0x000008D9
		public global::Motorola.Common.Communication.XnlPacket packet { get; internal set; }
	}
}
