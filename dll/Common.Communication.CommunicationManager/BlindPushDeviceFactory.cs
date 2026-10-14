using System;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.DeviceDiscovery;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.CommunicationManager
{
	// Token: 0x02000025 RID: 37
	internal static class BlindPushDeviceFactory
	{
		// Token: 0x06000125 RID: 293 RVA: 0x00006D78 File Offset: 0x00004F78
		public static global::Motorola.Common.Communication.IMotoDevice CreateRadio(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo)
		{
			global::Motorola.Common.Communication.IMotoDevice motoDevice = null;
			if (deviceInfo.Family == global::Motorola.Common.Communication.CommonUtil.ProductFamily.AstroRadio)
			{
				if (deviceInfo.ConnectionInfo.ConnectionType == global::Motorola.Common.Communication.CommonUtil.ConnectionType.Bluetooth)
				{
					motoDevice = global::Motorola.Common.Communication.CommunicationManager.BlindPushDeviceFactory.newMotoDevice(deviceInfo, null);
				}
				else if (deviceInfo.ConnectionInfo.ConnectionType == global::Motorola.Common.Communication.CommonUtil.ConnectionType.Otap)
				{
					motoDevice = global::Motorola.Common.Communication.CommunicationManager.BlindPushDeviceFactory.newAstroOtapDevice(deviceInfo);
				}
				else if (deviceInfo.ConnectionInfo.ConnectionType == global::Motorola.Common.Communication.CommonUtil.ConnectionType.WIFI)
				{
					motoDevice = global::Motorola.Common.Communication.CommunicationManager.BlindPushDeviceFactory.newAstroWiFiDevice(deviceInfo);
				}
			}
			else
			{
				if (deviceInfo.Family != (deviceInfo.Family & global::Motorola.Common.Communication.CommonUtil.ProductFamily.PCRRadio))
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerUnknownDeviceFamily);
				}
				if (deviceInfo.ConnectionInfo.ConnectionType != global::Motorola.Common.Communication.CommonUtil.ConnectionType.LENetwork && deviceInfo.ConnectionInfo.ConnectionType != global::Motorola.Common.Communication.CommonUtil.ConnectionType.DMR3Network)
				{
					motoDevice = global::Motorola.Common.Communication.CommunicationManager.BlindPushDeviceFactory.newMotoDevice(deviceInfo, null);
				}
			}
			if (motoDevice != null)
			{
				motoDevice.radioState = global::Motorola.Common.Communication.CommonUtil.RadioState.Ready;
				global::Motorola.Common.Communication.CommunicationManager.CommunicationManagerClass.Instance.AddBlindPushDevice(motoDevice);
			}
			return motoDevice;
		}

		// Token: 0x06000126 RID: 294 RVA: 0x00006E38 File Offset: 0x00005038
		private static global::Motorola.Common.Communication.CommunicationManager.MotoDevice newMotoDevice(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.DeviceDiscovery.RNDISRadioProfile radioProfile)
		{
			return new global::Motorola.Common.Communication.CommunicationManager.MotoDevice(deviceInfo, radioProfile);
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00006E41 File Offset: 0x00005041
		private static global::Motorola.Common.Communication.CommunicationManager.AstroOtapDevice newAstroOtapDevice(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo)
		{
			return new global::Motorola.Common.Communication.CommunicationManager.AstroOtapDevice(deviceInfo);
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00006E49 File Offset: 0x00005049
		private static global::Motorola.Common.Communication.CommunicationManager.AstroWiFiDevice newAstroWiFiDevice(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo)
		{
			return new global::Motorola.Common.Communication.CommunicationManager.AstroWiFiDevice(deviceInfo, null);
		}
	}
}
