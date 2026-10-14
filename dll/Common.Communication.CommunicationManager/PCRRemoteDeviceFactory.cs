using System;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.PCRRemoteProgramming;

namespace Motorola.Common.Communication.CommunicationManager
{
	// Token: 0x0200002E RID: 46
	internal class PCRRemoteDeviceFactory : global::Motorola.Common.Communication.DeviceFactoryBase
	{
		// Token: 0x0600014B RID: 331 RVA: 0x0000740C File Offset: 0x0000560C
		public PCRRemoteDeviceFactory(global::Motorola.Common.Communication.CommonUtil.IObserver _observer)
		{
			base.PIDList = new string[]
			{
				global::Motorola.Common.Communication.PCRRemoteProgramming.PCRRemoteDeviceDetector.PCR_REMOTE_REPEATER_PID
			};
			this._observer = _observer;
		}

		// Token: 0x0600014C RID: 332 RVA: 0x0000743C File Offset: 0x0000563C
		protected override bool CreateRadio(out global::Motorola.Common.Communication.IMotoDevice radio, global::Motorola.Common.Communication.IRadioProfile hwProfile)
		{
			bool result = true;
			global::Motorola.Common.Communication.PCRRemoteProgramming.PCRRemoteDeviceProfile profile = (global::Motorola.Common.Communication.PCRRemoteProgramming.PCRRemoteDeviceProfile)hwProfile;
			global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo = global::Motorola.Common.Communication.PCRRemoteProgramming.LEDeviceManager.ConstructRPDeviceInfo(profile);
			radio = new global::Motorola.Common.Communication.CommunicationManager.PCRRemoteDevice(deviceInfo);
			radio.radioState = global::Motorola.Common.Communication.CommonUtil.RadioState.Ready;
			if (radio != null)
			{
				radio.Register(this._observer);
				radio.DeviceInfo.RadioID = hwProfile.RadioIdString;
			}
			return result;
		}

		// Token: 0x0600014D RID: 333 RVA: 0x0000748D File Offset: 0x0000568D
		private static global::Motorola.Common.Communication.CommunicationManager.PCRRemoteDevice CreateBlindPushDevice(global::Motorola.Common.Communication.CommonUtil.DeviceInfo devInfo)
		{
			return new global::Motorola.Common.Communication.CommunicationManager.PCRRemoteDevice(devInfo);
		}

		// Token: 0x0400004B RID: 75
		private global::Motorola.Common.Communication.CommonUtil.IObserver _observer;
	}
}
