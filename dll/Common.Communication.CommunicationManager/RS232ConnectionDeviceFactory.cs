using System;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.DeviceDiscovery;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.CommunicationManager
{
	// Token: 0x02000057 RID: 87
	public static class RS232ConnectionDeviceFactory
	{
		// Token: 0x060001F0 RID: 496 RVA: 0x0000B04C File Offset: 0x0000924C
		public static global::Motorola.Common.Communication.IMotoDevice CreateRadio(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo)
		{
			global::Motorola.Common.Communication.CommunicationManager.RS232ConnectionDeviceFactory._createUtility = new global::Motorola.Common.Communication.CommunicationManager.RadioCreatorUtility();
			if (string.IsNullOrEmpty(deviceInfo.RadioID))
			{
				return null;
			}
			global::Motorola.Common.Communication.CommunicationManager.TetraRS232Device tetraRS232Device = null;
			bool flag = false;
			if (deviceInfo.Family != global::Motorola.Common.Communication.CommonUtil.ProductFamily.TetraRadio || deviceInfo.ConnectionInfo.ConnectionType != global::Motorola.Common.Communication.CommonUtil.ConnectionType.RS232)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerNullDeviceInfo);
			}
			tetraRS232Device = global::Motorola.Common.Communication.CommunicationManager.RS232ConnectionDeviceFactory.newOneTetraRS232Device(deviceInfo);
			if (tetraRS232Device == null)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerNullDeviceInfo);
			}
			bool flag2 = false;
			bool flag3 = false;
			global::Motorola.Common.Communication.DeviceDiscovery.TetraRadioProfile tetraRadioProfile = new global::Motorola.Common.Communication.DeviceDiscovery.TetraRadioProfile();
			tetraRadioProfile.DeviceMode = global::Motorola.Common.Communication.CommonUtil.DeviceMode.UNKNOWN;
			tetraRadioProfile.TetraRadioType = global::Motorola.Common.Communication.CommonUtil.TetraRadioType.UNKNOWN;
			tetraRadioProfile.Path = deviceInfo.ConnectionInfo.Location;
			tetraRadioProfile.UniqueLocation = "UART_PIPE_" + deviceInfo.ConnectionInfo.Location;
			tetraRadioProfile.VID = string.Empty;
			tetraRadioProfile.PID = string.Empty;
			tetraRadioProfile.PhysicalLocation = deviceInfo.ConnectionInfo.Location;
			tetraRadioProfile.PreAttached = false;
			tetraRadioProfile.DevInstanceNum = 0U;
			tetraRadioProfile.ParentDevInstanceNum = 0U;
			try
			{
				flag = global::Motorola.Common.Communication.CommunicationManager.RS232ConnectionDeviceFactory._createUtility.CreateUARTRadio(tetraRS232Device, deviceInfo, tetraRadioProfile, out flag2, out flag3);
			}
			catch (global::System.Exception)
			{
				return null;
			}
			if (flag)
			{
				tetraRS232Device.DeviceInfo.ConnectionInfo.ConnectionType = global::Motorola.Common.Communication.CommonUtil.ConnectionType.RS232;
				tetraRS232Device.DeviceInfo.ConnectionInfo.AuthInfo = new global::Motorola.Common.Communication.CommonUtil.AuthenticationInfo();
				tetraRS232Device.DeviceInfo.Family = global::Motorola.Common.Communication.CommonUtil.ProductFamily.LegacyProgRadio;
				if (flag2)
				{
					tetraRS232Device.DeviceInfo.Family = global::Motorola.Common.Communication.CommonUtil.ProductFamily.FrodoProgRadio;
				}
				if (flag3)
				{
					tetraRS232Device.DeviceInfo.Family = global::Motorola.Common.Communication.CommonUtil.ProductFamily.GemstoneBMPProgRadio;
				}
				tetraRS232Device.Active = true;
				tetraRS232Device.radioState = global::Motorola.Common.Communication.CommonUtil.RadioState.Ready;
			}
			else
			{
				tetraRS232Device.Active = false;
			}
			if (!flag)
			{
				return null;
			}
			return tetraRS232Device;
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x0000B1F4 File Offset: 0x000093F4
		public static bool RemoveRadio(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo)
		{
			if (string.IsNullOrEmpty(deviceInfo.RadioID))
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerNullDeviceInfo);
			}
			global::Motorola.Common.Communication.IMotoDevice device = global::Motorola.Common.Communication.CommunicationManager.CommunicationManagerClass.Instance.GetDevice(deviceInfo.RadioID);
			if (device != null && device.DeviceInfo.ConnectionInfo.ConnectionType == global::Motorola.Common.Communication.CommonUtil.ConnectionType.RS232)
			{
				device.Active = false;
				return true;
			}
			return false;
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x0000B24A File Offset: 0x0000944A
		private static global::Motorola.Common.Communication.CommunicationManager.TetraRS232Device newOneTetraRS232Device(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo)
		{
			return new global::Motorola.Common.Communication.CommunicationManager.TetraRS232Device(deviceInfo);
		}

		// Token: 0x04000071 RID: 113
		private static global::Motorola.Common.Communication.CommunicationManager.RadioCreatorUtility _createUtility;
	}
}
