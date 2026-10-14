using System;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.DeviceDiscovery;

namespace Motorola.Common.Communication.CommunicationManager
{
	// Token: 0x02000041 RID: 65
	internal abstract class RNDISDeviceFactory : global::Motorola.Common.Communication.DeviceFactoryBase
	{
		// Token: 0x06000183 RID: 387
		protected abstract global::Motorola.Common.Communication.IMotoDevice CreateRadio(global::Motorola.Common.Communication.DeviceDiscovery.RNDISRadioProfile profile, global::Motorola.Common.Communication.CommonUtil.ConnectionInfo connectionInfo);

		// Token: 0x06000184 RID: 388 RVA: 0x0000796C File Offset: 0x00005B6C
		protected RNDISDeviceFactory(global::Motorola.Common.Communication.CommonUtil.IObserver observer)
		{
			this._observer = observer;
		}

		// Token: 0x06000185 RID: 389 RVA: 0x0000797C File Offset: 0x00005B7C
		protected override bool CreateRadio(out global::Motorola.Common.Communication.IMotoDevice radio, global::Motorola.Common.Communication.IRadioProfile hwProfile)
		{
			bool result = true;
			global::Motorola.Common.Communication.DeviceDiscovery.RNDISRadioProfile rndisradioProfile = hwProfile as global::Motorola.Common.Communication.DeviceDiscovery.RNDISRadioProfile;
			radio = this.CreateRadio(rndisradioProfile, new global::Motorola.Common.Communication.CommonUtil.ConnectionInfo
			{
				ConnectionType = global::Motorola.Common.Communication.CommonUtil.ConnectionType.NetAdapter,
				UniqueAddress = rndisradioProfile.IPAddress,
				DeviceInstance = rndisradioProfile.DeviceInstanceID
			});
			if (radio != null)
			{
				radio.Register(this._observer);
				if (global::Motorola.Common.Communication.CommunicationManager.CommunicationManagerClass.Instance.DiscoveryWorkMode == global::Motorola.Common.Communication.CommonUtil.WorkMode.Active)
				{
					radio.Prefetch();
				}
				radio.DeviceInfo.RadioID = hwProfile.RadioIdString;
				result = true;
			}
			return result;
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000186 RID: 390
		public abstract string PAC_Name { get; }

		// Token: 0x0400004E RID: 78
		private global::Motorola.Common.Communication.CommonUtil.IObserver _observer;
	}
}
