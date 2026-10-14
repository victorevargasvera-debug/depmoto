using System;

namespace Motorola.Common.Communication
{
	// Token: 0x0200000A RID: 10
	public enum ConnectFunction : byte
	{
		// Token: 0x0400002A RID: 42
		CANConnectivityTest = 1,
		// Token: 0x0400002B RID: 43
		EthernetConnectivityTest,
		// Token: 0x0400002C RID: 44
		RS232ConnectivityTest,
		// Token: 0x0400002D RID: 45
		USBConnectivityTest,
		// Token: 0x0400002E RID: 46
		SDConnectivityTest,
		// Token: 0x0400002F RID: 47
		SSIConnectivityTest,
		// Token: 0x04000030 RID: 48
		BTSSIConnectivityTest,
		// Token: 0x04000031 RID: 49
		BTGPSConnectivityTest,
		// Token: 0x04000032 RID: 50
		FactoryControlHeadConnectivityTest,
		// Token: 0x04000033 RID: 51
		GPSBISTPatchDownload,
		// Token: 0x04000034 RID: 52
		MarvellICTestMode = 12
	}
}
