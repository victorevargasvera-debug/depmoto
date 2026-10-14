using System;

namespace Motorola.Common.Communication.DeviceDiscovery
{
	// Token: 0x02000020 RID: 32
	[global::System.Flags]
	internal enum DeviceConnectionType
	{
		// Token: 0x0400008F RID: 143
		None = 0,
		// Token: 0x04000090 RID: 144
		PM_USB_MODEM = 1,
		// Token: 0x04000091 RID: 145
		PM_MODEM = 2,
		// Token: 0x04000092 RID: 146
		PM_SERIAL_PORT = 4,
		// Token: 0x04000093 RID: 147
		PM_USB_NET = 8
	}
}
