using System;

namespace Motorola.Common.Communication.CommunicationManager
{
	// Token: 0x0200001C RID: 28
	public static class Constants
	{
		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060000D6 RID: 214 RVA: 0x00005520 File Offset: 0x00003720
		public static int RadioTCPPort
		{
			get
			{
				return 8002;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060000D7 RID: 215 RVA: 0x00005527 File Offset: 0x00003727
		public static int RadioFxpPort
		{
			get
			{
				return 4070;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060000D8 RID: 216 RVA: 0x0000552E File Offset: 0x0000372E
		public static int RadioFxpPCPort
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000D9 RID: 217 RVA: 0x00005531 File Offset: 0x00003731
		public static int AstroRadioOtapPort
		{
			get
			{
				return 8003;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000DA RID: 218 RVA: 0x00005538 File Offset: 0x00003738
		public static int RadioOtapPort
		{
			get
			{
				return 4009;
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000DB RID: 219 RVA: 0x0000553F File Offset: 0x0000373F
		public static int AstroRadioWifiPort
		{
			get
			{
				return 52010;
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000DC RID: 220 RVA: 0x00005546 File Offset: 0x00003746
		public static int PcrRadioWifiPort
		{
			get
			{
				return 8003;
			}
		}

		// Token: 0x04000020 RID: 32
		public const int PcrWireTimeout = 20000;

		// Token: 0x04000021 RID: 33
		public const int PcrWiFiTimeout = 60000;

		// Token: 0x04000022 RID: 34
		public const int PcrRPReadTimeout = 10000;

		// Token: 0x04000023 RID: 35
		public const int PcrOtapTimeout = 15000;

		// Token: 0x04000024 RID: 36
		public const int PcrWireMaxPacketSize = 1000;

		// Token: 0x04000025 RID: 37
		public const int PcrWifiMaxPacketSize = 10000;

		// Token: 0x04000026 RID: 38
		public const int PcrOtapMaxPacketSize = 1973;

		// Token: 0x04000027 RID: 39
		public const int WiredTcpOpenTimeout = -1;

		// Token: 0x04000028 RID: 40
		public const int AstroOtapInactivityTimeout = 180;

		// Token: 0x04000029 RID: 41
		public const int AstroWifiInactivityTimeout = 60;

		// Token: 0x0400002A RID: 42
		public const int FXPWiredTimeout = 1000;

		// Token: 0x0400002B RID: 43
		public const int FXPWiFiTimeout = 5000;

		// Token: 0x0400002C RID: 44
		public const int FXPWiFiRetryTimes = 10;

		// Token: 0x0400002D RID: 45
		public const int PcrWiFiXnlBroadcastPollPeriod = 1000;
	}
}
