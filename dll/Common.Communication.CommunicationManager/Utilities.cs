using System;
using System.Net;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.CommunicationManager
{
	// Token: 0x0200001B RID: 27
	internal static class Utilities
	{
		// Token: 0x060000D3 RID: 211 RVA: 0x00005450 File Offset: 0x00003650
		public static global::System.Net.IPAddress GetIPAddress(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo)
		{
			global::System.Net.IPAddress result;
			if (deviceInfo == null || deviceInfo.ConnectionInfo == null || string.IsNullOrEmpty(deviceInfo.ConnectionInfo.UniqueAddress) || !global::System.Net.IPAddress.TryParse(deviceInfo.ConnectionInfo.UniqueAddress, out result))
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidIPAddress);
			}
			return result;
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00005498 File Offset: 0x00003698
		public static int GetFxPPort(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo)
		{
			int result = global::Motorola.Common.Communication.CommunicationManager.Constants.RadioFxpPort;
			if (deviceInfo != null && deviceInfo.ConnectionInfo != null && deviceInfo.ConnectionInfo.ConnectionType == global::Motorola.Common.Communication.CommonUtil.ConnectionType.WIFI)
			{
				result = global::Motorola.Common.Communication.CommunicationManager.Constants.RadioFxpPCPort;
			}
			return result;
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x000054CC File Offset: 0x000036CC
		public static int GetPort(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo)
		{
			int result;
			if (deviceInfo != null && deviceInfo.ConnectionInfo != null && !string.IsNullOrEmpty(deviceInfo.ConnectionInfo.Location) && deviceInfo.ConnectionInfo.ConnectionType == global::Motorola.Common.Communication.CommonUtil.ConnectionType.WIFI && int.TryParse(deviceInfo.ConnectionInfo.Location, out result))
			{
				return result;
			}
			return global::Motorola.Common.Communication.CommunicationManager.Constants.RadioTCPPort;
		}
	}
}
