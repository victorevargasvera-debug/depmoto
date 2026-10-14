using System;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.DeviceDiscovery;

namespace Motorola.Common.Communication.CommunicationManager
{
	// Token: 0x02000066 RID: 102
	internal class AstroWiFiRadioFactory : global::Motorola.Common.Communication.CommunicationManager.WiFiDeviceFactory
	{
		// Token: 0x06000258 RID: 600 RVA: 0x0000C428 File Offset: 0x0000A628
		public AstroWiFiRadioFactory(global::Motorola.Common.Communication.CommonUtil.IObserver observer) : base(observer)
		{
			base.PIDList = new string[]
			{
				"WiFi_APX"
			};
		}

		// Token: 0x06000259 RID: 601 RVA: 0x0000C454 File Offset: 0x0000A654
		protected override global::Motorola.Common.Communication.IMotoDevice CreateRadio(global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioProfile profile, global::Motorola.Common.Communication.CommonUtil.ConnectionInfo connectionInfo)
		{
			profile.RadioType = global::Motorola.Common.Communication.RadioType.ASTRO;
			return this.newAstroWiFiDevice(new global::Motorola.Common.Communication.CommonUtil.AstroDeviceInfo
			{
				Family = global::Motorola.Common.Communication.CommonUtil.ProductFamily.AstroRadio,
				ConnectionInfo = connectionInfo
			}, profile);
		}

		// Token: 0x0600025A RID: 602 RVA: 0x0000C484 File Offset: 0x0000A684
		private global::Motorola.Common.Communication.CommunicationManager.AstroWiFiDevice newAstroWiFiDevice(global::Motorola.Common.Communication.CommonUtil.DeviceInfo devInfo, global::Motorola.Common.Communication.DeviceDiscovery.RNDISRadioProfile profile)
		{
			return new global::Motorola.Common.Communication.CommunicationManager.AstroWiFiDevice(devInfo, profile);
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x0600025B RID: 603 RVA: 0x0000C48D File Offset: 0x0000A68D
		public override string PAC_Name
		{
			get
			{
				return "ASTRO_";
			}
		}
	}
}
