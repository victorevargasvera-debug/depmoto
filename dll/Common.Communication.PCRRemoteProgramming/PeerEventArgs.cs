using System;

namespace Motorola.Common.Communication.PCRRemoteProgramming
{
	// Token: 0x02000003 RID: 3
	public class PeerEventArgs : global::System.EventArgs
	{
		// Token: 0x06000002 RID: 2 RVA: 0x000020D8 File Offset: 0x000002D8
		internal PeerEventArgs()
		{
			this.peerID = 0U;
		}

		// Token: 0x04000005 RID: 5
		public uint peerID;
	}
}
