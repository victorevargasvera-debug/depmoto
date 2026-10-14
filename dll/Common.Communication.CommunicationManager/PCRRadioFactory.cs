using System;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.DeviceDiscovery;

namespace Motorola.Common.Communication.CommunicationManager
{
	// Token: 0x02000043 RID: 67
	internal class PCRRadioFactory : global::Motorola.Common.Communication.CommunicationManager.RNDISDeviceFactory
	{
		// Token: 0x0600018B RID: 395 RVA: 0x00007B30 File Offset: 0x00005D30
		public PCRRadioFactory(global::Motorola.Common.Communication.CommonUtil.IObserver observer) : base(observer)
		{
			base.PIDList = new string[]
			{
				"1020",
				"1021",
				"1022",
				"1023",
				"1024",
				"1025",
				"1026",
				"1027",
				"1028",
				"1029",
				"102A",
				"102B",
				"102C"
			};
		}

		// Token: 0x0600018C RID: 396 RVA: 0x00007BC0 File Offset: 0x00005DC0
		protected override global::Motorola.Common.Communication.IMotoDevice CreateRadio(global::Motorola.Common.Communication.DeviceDiscovery.RNDISRadioProfile profile, global::Motorola.Common.Communication.CommonUtil.ConnectionInfo connectionInfo)
		{
			profile.RadioType = global::Motorola.Common.Communication.RadioType.PCR;
			return this.newPcrWireDevice(new global::Motorola.Common.Communication.CommonUtil.PCRDeviceInfo
			{
				Family = global::Motorola.Common.Communication.CommonUtil.ProductFamily.PCRRadio,
				ConnectionInfo = connectionInfo
			}, profile);
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x0600018D RID: 397 RVA: 0x00007BF4 File Offset: 0x00005DF4
		public override string PAC_Name
		{
			get
			{
				return "PCR_";
			}
		}

		// Token: 0x0600018E RID: 398 RVA: 0x00007BFB File Offset: 0x00005DFB
		private global::Motorola.Common.Communication.CommunicationManager.PcrWireDevice newPcrWireDevice(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.DeviceDiscovery.RNDISRadioProfile profile)
		{
			return new global::Motorola.Common.Communication.CommunicationManager.PcrWireDevice(deviceInfo, profile);
		}
	}
}
