using System;
using System.Net;
using Motorola.Common.CustomException;

namespace SwitchOverManager
{
	// Token: 0x02000002 RID: 2
	internal class SwitchOverConstants
	{
		// Token: 0x06000001 RID: 1 RVA: 0x000020D0 File Offset: 0x000002D0
		public static global::System.Net.IPAddress GetIPAddress(string ipAddress)
		{
			global::System.Net.IPAddress result;
			if (string.IsNullOrEmpty(ipAddress) || !global::System.Net.IPAddress.TryParse(ipAddress, out result))
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidIPAddress);
			}
			return result;
		}

		// Token: 0x04000001 RID: 1
		public const int PcrRadioSwitchOverUdpPort = 4010;

		// Token: 0x04000002 RID: 2
		public const int PcrSwitchOverAckTimeout = 25000;

		// Token: 0x04000003 RID: 3
		public const int PcrSwitchOverRetries = 2;
	}
}
