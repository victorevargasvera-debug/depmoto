using System;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.DeviceDiscovery;

namespace Motorola.Common.Communication.CommunicationManager
{
	// Token: 0x02000067 RID: 103
	internal class PCRWiFiRadioFactory : global::Motorola.Common.Communication.CommunicationManager.WiFiDeviceFactory
	{
		// Token: 0x0600025C RID: 604 RVA: 0x0000C494 File Offset: 0x0000A694
		public PCRWiFiRadioFactory(global::Motorola.Common.Communication.CommonUtil.IObserver observer) : base(observer)
		{
			base.PIDList = new string[]
			{
				"WiFi_MotoTrbo"
			};
		}

		// Token: 0x0600025D RID: 605 RVA: 0x0000C4C0 File Offset: 0x0000A6C0
		protected override global::Motorola.Common.Communication.IMotoDevice CreateRadio(global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioProfile profile, global::Motorola.Common.Communication.CommonUtil.ConnectionInfo connectionInfo)
		{
			profile.RadioType = global::Motorola.Common.Communication.RadioType.PCR;
			return this.newPcrWiFiDevice(new global::Motorola.Common.Communication.CommonUtil.PCRDeviceInfo
			{
				Family = global::Motorola.Common.Communication.CommonUtil.ProductFamily.ParadiseRadio,
				ConnectionInfo = connectionInfo
			}, profile);
		}

		// Token: 0x0600025E RID: 606 RVA: 0x0000C4F0 File Offset: 0x0000A6F0
		private global::Motorola.Common.Communication.CommunicationManager.PCRWiFiDevice newPcrWiFiDevice(global::Motorola.Common.Communication.CommonUtil.DeviceInfo devInfo, global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioProfile profile)
		{
			return new global::Motorola.Common.Communication.CommunicationManager.PCRWiFiDevice(devInfo, profile);
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x0600025F RID: 607 RVA: 0x0000C4F9 File Offset: 0x0000A6F9
		public override string PAC_Name
		{
			get
			{
				return "PCR_";
			}
		}
	}
}
