using System;

namespace Motorola.Common.Communication.DeviceDiscovery
{
	// Token: 0x02000015 RID: 21
	public enum DeviceDetectorType
	{
		// Token: 0x04000055 RID: 85
		Unknown,
		// Token: 0x04000056 RID: 86
		VCOMDetector,
		// Token: 0x04000057 RID: 87
		RNDISDetector,
		// Token: 0x04000058 RID: 88
		PCRRemoteDeviceDetector,
		// Token: 0x04000059 RID: 89
		PBBDeviceDetector,
		// Token: 0x0400005A RID: 90
		DNSSDDetector,
		// Token: 0x0400005B RID: 91
		LTEDetector,
		// Token: 0x0400005C RID: 92
		VirtualDeviceDetector = 255
	}
}
