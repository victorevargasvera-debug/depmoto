using System;

namespace Motorola.Common.Communication.TetraUtility
{
	// Token: 0x02000084 RID: 132
	public enum USB_USER_ERROR_CODE
	{
		// Token: 0x040003FF RID: 1023
		UsbUserSuccess,
		// Token: 0x04000400 RID: 1024
		UsbUserNotSupported,
		// Token: 0x04000401 RID: 1025
		UsbUserInvalidRequestCode,
		// Token: 0x04000402 RID: 1026
		UsbUserFeatureDisabled,
		// Token: 0x04000403 RID: 1027
		UsbUserInvalidHeaderParameter,
		// Token: 0x04000404 RID: 1028
		UsbUserInvalidParameter,
		// Token: 0x04000405 RID: 1029
		UsbUserMiniportError,
		// Token: 0x04000406 RID: 1030
		UsbUserBufferTooSmall,
		// Token: 0x04000407 RID: 1031
		UsbUserErrorNotMapped,
		// Token: 0x04000408 RID: 1032
		UsbUserDeviceNotStarted,
		// Token: 0x04000409 RID: 1033
		UsbUserNoDeviceConnected
	}
}
