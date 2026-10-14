using System;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.DeviceDiscovery;

namespace Motorola.Common.Communication.CommunicationManager
{
	// Token: 0x02000044 RID: 68
	internal class PBBRadioFactory : global::Motorola.Common.Communication.CommunicationManager.RNDISDeviceFactory
	{
		// Token: 0x0600018F RID: 399 RVA: 0x00007C04 File Offset: 0x00005E04
		public PBBRadioFactory(global::Motorola.Common.Communication.CommonUtil.IObserver observer) : base(observer)
		{
			base.PIDList = new string[]
			{
				global::Motorola.Common.Communication.DeviceDiscovery.PBBDetector.PBB_PID
			};
		}

		// Token: 0x06000190 RID: 400 RVA: 0x00007C30 File Offset: 0x00005E30
		protected override global::Motorola.Common.Communication.IMotoDevice CreateRadio(global::Motorola.Common.Communication.DeviceDiscovery.RNDISRadioProfile profile, global::Motorola.Common.Communication.CommonUtil.ConnectionInfo connectionInfo)
		{
			profile.RadioType = global::Motorola.Common.Communication.RadioType.PBB;
			return this.newPBBDevice(new global::Motorola.Common.Communication.CommonUtil.PBBDeviceInfo
			{
				Family = global::Motorola.Common.Communication.CommonUtil.ProductFamily.PBBRadio,
				ConnectionInfo = connectionInfo
			}, profile as global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile);
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000191 RID: 401 RVA: 0x00007C69 File Offset: 0x00005E69
		public override string PAC_Name
		{
			get
			{
				return "PBB_";
			}
		}

		// Token: 0x06000192 RID: 402 RVA: 0x00007C70 File Offset: 0x00005E70
		private global::Motorola.Common.Communication.CommunicationManager.PBBDevice newPBBDevice(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile profile)
		{
			return new global::Motorola.Common.Communication.CommunicationManager.PBBDevice(deviceInfo, profile);
		}
	}
}
