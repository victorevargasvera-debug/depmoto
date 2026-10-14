using System;

namespace Motorola.Common.Communication
{
	// Token: 0x0200004A RID: 74
	public static class RPMessageID
	{
		// Token: 0x040000D8 RID: 216
		public const byte RP_STATUS_INDICATION = 0;

		// Token: 0x040000D9 RID: 217
		public const byte RP_PARAMETER_VERSION_REPORT_REQUEST = 1;

		// Token: 0x040000DA RID: 218
		public const byte RP_PARAMETER_VERSION_REPORT_CONFIRM = 2;

		// Token: 0x040000DB RID: 219
		public const byte RP_RESET_REQUEST = 3;

		// Token: 0x040000DC RID: 220
		public const byte RP_PARAMETER_VERSION_REPORT_REPLY = 4;

		// Token: 0x040000DD RID: 221
		public const byte RP_REJECT_INDICATION = 5;

		// Token: 0x040000DE RID: 222
		public const byte RP_TERMINAL_ID_REQUEST = 6;

		// Token: 0x040000DF RID: 223
		public const byte RP_TERMINAL_ID_CONFIRM = 7;
	}
}
