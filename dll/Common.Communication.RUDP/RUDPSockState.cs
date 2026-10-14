using System;

namespace Motorola.Common.Communication.RUDP
{
	// Token: 0x02000017 RID: 23
	public enum RUDPSockState
	{
		// Token: 0x040000AE RID: 174
		INIT,
		// Token: 0x040000AF RID: 175
		CLOSE_WAIT,
		// Token: 0x040000B0 RID: 176
		CLOSE,
		// Token: 0x040000B1 RID: 177
		OPEN,
		// Token: 0x040000B2 RID: 178
		LISTEN,
		// Token: 0x040000B3 RID: 179
		BIND,
		// Token: 0x040000B4 RID: 180
		SYN_SENT,
		// Token: 0x040000B5 RID: 181
		SYN_RCVD
	}
}
