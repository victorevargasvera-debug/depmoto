using System;

namespace Motorola.Common.Communication.DeviceDiscovery
{
	// Token: 0x02000004 RID: 4
	public interface IDeviceDetector
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000009 RID: 9
		global::Motorola.Common.Communication.DeviceDiscovery.DeviceDetectorType DetectorType { get; }

		// Token: 0x0600000A RID: 10
		bool Start();

		// Token: 0x0600000B RID: 11
		void Stop();

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x0600000C RID: 12
		// (remove) Token: 0x0600000D RID: 13
		event global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler deviceAttached;

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x0600000E RID: 14
		// (remove) Token: 0x0600000F RID: 15
		event global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler deviceDetached;

		// Token: 0x06000010 RID: 16
		bool DeviceChanged(global::Motorola.Common.Communication.DeviceDiscovery.OriginalPnPMsg pnpMsg);
	}
}
