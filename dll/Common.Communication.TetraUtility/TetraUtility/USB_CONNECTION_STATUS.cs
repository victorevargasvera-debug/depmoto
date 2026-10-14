using System;

namespace Motorola.Common.Communication.TetraUtility
{
	// Token: 0x02000083 RID: 131
	public enum USB_CONNECTION_STATUS
	{
		// Token: 0x040003F3 RID: 1011
		NoDeviceConnected,
		// Token: 0x040003F4 RID: 1012
		DeviceConnected,
		// Token: 0x040003F5 RID: 1013
		DeviceFailedEnumeration,
		// Token: 0x040003F6 RID: 1014
		DeviceGeneralFailure,
		// Token: 0x040003F7 RID: 1015
		DeviceCausedOvercurrent,
		// Token: 0x040003F8 RID: 1016
		DeviceNotEnoughPower,
		// Token: 0x040003F9 RID: 1017
		DeviceNotEnoughBandwidth,
		// Token: 0x040003FA RID: 1018
		DeviceHubNestedTooDeeply,
		// Token: 0x040003FB RID: 1019
		DeviceInLegacyHub,
		// Token: 0x040003FC RID: 1020
		DeviceEnumerating,
		// Token: 0x040003FD RID: 1021
		DeviceReset
	}
}
