using System;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.DeviceDiscovery;

namespace Motorola.Common.Communication.CommunicationManager
{
	// Token: 0x02000065 RID: 101
	internal abstract class WiFiDeviceFactory : global::Motorola.Common.Communication.DeviceFactoryBase
	{
		// Token: 0x06000254 RID: 596
		protected abstract global::Motorola.Common.Communication.IMotoDevice CreateRadio(global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioProfile profile, global::Motorola.Common.Communication.CommonUtil.ConnectionInfo connectionInfo);

		// Token: 0x06000255 RID: 597 RVA: 0x0000C30C File Offset: 0x0000A50C
		protected WiFiDeviceFactory(global::Motorola.Common.Communication.CommonUtil.IObserver observer)
		{
			this._observer = observer;
		}

		// Token: 0x06000256 RID: 598 RVA: 0x0000C31C File Offset: 0x0000A51C
		protected override bool CreateRadio(out global::Motorola.Common.Communication.IMotoDevice radio, global::Motorola.Common.Communication.IRadioProfile hwProfile)
		{
			bool result = true;
			global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioProfile ldtradioProfile = hwProfile as global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioProfile;
			if (ldtradioProfile == null)
			{
				radio = null;
				return false;
			}
			if (ldtradioProfile.DeviceInstanceID != null && global::Motorola.Common.Communication.CommunicationManager.CommunicationManagerClass.Instance.ContainWiFiDevice(ldtradioProfile.RadioIdString))
			{
				global::Motorola.Common.Communication.IMotoDevice device = global::Motorola.Common.Communication.CommunicationManager.CommunicationManagerClass.Instance.GetDevice(ldtradioProfile.RadioIdString);
				if (device != null)
				{
					if (device.DeviceInfo.ConnectionInfo.UniqueAddress == ldtradioProfile.IPAddress)
					{
						global::Motorola.Common.Communication.CommunicationManager.CommunicationManagerClass.Instance.Notify(device);
					}
					else
					{
						device.DeviceInfo.ConnectionInfo.UniqueAddress = ldtradioProfile.IPAddress;
						global::Motorola.Common.Communication.CommunicationManager.CommunicationManagerClass.Instance.ReDetectDevice(ldtradioProfile.RadioIdString);
					}
				}
				radio = null;
				result = false;
			}
			else
			{
				radio = this.CreateRadio(ldtradioProfile, new global::Motorola.Common.Communication.CommonUtil.ConnectionInfo
				{
					ConnectionType = global::Motorola.Common.Communication.CommonUtil.ConnectionType.NetAdapter,
					UniqueAddress = ldtradioProfile.IPAddress,
					DeviceInstance = ldtradioProfile.DeviceInstanceID,
					Location = ldtradioProfile.PortName
				});
				if (radio != null)
				{
					if (global::Motorola.Common.Communication.CommunicationManager.CommunicationManagerClass.Instance.DiscoveryWorkMode == global::Motorola.Common.Communication.CommonUtil.WorkMode.Active)
					{
						radio.Prefetch();
					}
					radio.DeviceInfo.RadioID = hwProfile.RadioIdString;
					result = true;
				}
			}
			return result;
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000257 RID: 599
		public abstract string PAC_Name { get; }

		// Token: 0x04000080 RID: 128
		protected global::Motorola.Common.Communication.CommonUtil.IObserver _observer;
	}
}
