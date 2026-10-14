using System;

namespace Motorola.Common.Communication
{
	// Token: 0x0200004B RID: 75
	public static class RPRejectReason
	{
		// Token: 0x17000072 RID: 114
		// (get) Token: 0x06000225 RID: 549 RVA: 0x000099CD File Offset: 0x00007BCD
		// (set) Token: 0x06000226 RID: 550 RVA: 0x000099D4 File Offset: 0x00007BD4
		public static byte RP_BAD_BATTERY
		{
			get
			{
				return global::Motorola.Common.Communication.RPRejectReason._RP_BAD_BATTERY;
			}
			set
			{
				global::Motorola.Common.Communication.RPRejectReason._RP_BAD_BATTERY = value;
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x06000227 RID: 551 RVA: 0x000099DC File Offset: 0x00007BDC
		// (set) Token: 0x06000228 RID: 552 RVA: 0x000099E3 File Offset: 0x00007BE3
		public static byte RP_EMERGENCY
		{
			get
			{
				return global::Motorola.Common.Communication.RPRejectReason._RP_EMERGENCY;
			}
			set
			{
				global::Motorola.Common.Communication.RPRejectReason._RP_EMERGENCY = value;
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x06000229 RID: 553 RVA: 0x000099EB File Offset: 0x00007BEB
		// (set) Token: 0x0600022A RID: 554 RVA: 0x000099F2 File Offset: 0x00007BF2
		public static byte RP_NO_REJECTION
		{
			get
			{
				return global::Motorola.Common.Communication.RPRejectReason._RP_NO_REJECTION;
			}
			set
			{
				global::Motorola.Common.Communication.RPRejectReason._RP_NO_REJECTION = value;
			}
		}

		// Token: 0x040000E0 RID: 224
		private static byte _RP_BAD_BATTERY = 1;

		// Token: 0x040000E1 RID: 225
		private static byte _RP_EMERGENCY = 2;

		// Token: 0x040000E2 RID: 226
		private static byte _RP_NO_REJECTION = 0;
	}
}
