using System;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.DeviceDiscovery;

namespace Motorola.Common.Communication.CommunicationManager
{
	// Token: 0x02000068 RID: 104
	internal class PBBWiFiRadioFactory : global::Motorola.Common.Communication.CommunicationManager.WiFiDeviceFactory
	{
		// Token: 0x06000260 RID: 608 RVA: 0x0000C500 File Offset: 0x0000A700
		public PBBWiFiRadioFactory(global::Motorola.Common.Communication.CommonUtil.IObserver observer) : base(observer)
		{
			base.PIDList = new string[]
			{
				"WiFi_PBB"
			};
		}

		// Token: 0x06000261 RID: 609 RVA: 0x0000C52C File Offset: 0x0000A72C
		protected override global::Motorola.Common.Communication.IMotoDevice CreateRadio(global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioProfile profile, global::Motorola.Common.Communication.CommonUtil.ConnectionInfo connectionInfo)
		{
			profile.RadioType = global::Motorola.Common.Communication.RadioType.PBB;
			global::Motorola.Common.Communication.IMotoDevice motoDevice = this.newPBBWiFiDevice(new global::Motorola.Common.Communication.CommonUtil.PBBDeviceInfo
			{
				Family = global::Motorola.Common.Communication.CommonUtil.ProductFamily.PBBRadio,
				ConnectionInfo = connectionInfo
			}, profile);
			motoDevice.Register(this._observer);
			return motoDevice;
		}

		// Token: 0x06000262 RID: 610 RVA: 0x0000C56E File Offset: 0x0000A76E
		private global::Motorola.Common.Communication.CommunicationManager.PBBWiFiDevice newPBBWiFiDevice(global::Motorola.Common.Communication.CommonUtil.DeviceInfo devInfo, global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioProfile profile)
		{
			return new global::Motorola.Common.Communication.CommunicationManager.PBBWiFiDevice(devInfo, profile);
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000263 RID: 611 RVA: 0x0000C577 File Offset: 0x0000A777
		public override string PAC_Name
		{
			get
			{
				return "PBB_";
			}
		}
	}
}
