using System;
using Motorola.Common.Communication.RUDP.Helper;

namespace Motorola.Common.Communication.RUDP
{
	// Token: 0x0200001A RID: 26
	internal abstract class RUDPPayload : global::Motorola.Common.Communication.RUDP.Helper.ObjectSerializer
	{
		// Token: 0x1700005C RID: 92
		// (get) Token: 0x06000132 RID: 306 RVA: 0x000062DB File Offset: 0x000044DB
		// (set) Token: 0x06000133 RID: 307 RVA: 0x000062E3 File Offset: 0x000044E3
		public virtual byte PayloadLen
		{
			get
			{
				return this.payloadLen;
			}
			protected set
			{
				this.payloadLen = value;
			}
		}

		// Token: 0x040000C8 RID: 200
		private byte payloadLen;
	}
}
