using System;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.DeviceDiscovery;

namespace Motorola.Common.Communication.CommunicationManager
{
	// Token: 0x02000042 RID: 66
	internal class AstroRadioFactory : global::Motorola.Common.Communication.CommunicationManager.RNDISDeviceFactory
	{
		// Token: 0x06000187 RID: 391 RVA: 0x000079FC File Offset: 0x00005BFC
		public AstroRadioFactory(global::Motorola.Common.Communication.CommonUtil.IObserver observer) : base(observer)
		{
			base.PIDList = new string[]
			{
				"1030",
				"1031",
				"1032",
				"1034",
				"1036",
				"1037",
				"1038",
				"1039",
				"1016",
				"1017",
				"1018",
				"1019",
				"1007",
				"101A",
				"103A",
				"1008",
				"103B",
				"103C",
				"103D",
				"1051",
				"1052",
				"1053",
				"1054",
				"1055"
			};
		}

		// Token: 0x06000188 RID: 392 RVA: 0x00007AF0 File Offset: 0x00005CF0
		protected override global::Motorola.Common.Communication.IMotoDevice CreateRadio(global::Motorola.Common.Communication.DeviceDiscovery.RNDISRadioProfile profile, global::Motorola.Common.Communication.CommonUtil.ConnectionInfo connectionInfo)
		{
			profile.RadioType = global::Motorola.Common.Communication.RadioType.ASTRO;
			return this.newAstroWireDevice(new global::Motorola.Common.Communication.CommonUtil.AstroDeviceInfo
			{
				Family = global::Motorola.Common.Communication.CommonUtil.ProductFamily.AstroRadio,
				ConnectionInfo = connectionInfo
			}, profile);
		}

		// Token: 0x06000189 RID: 393 RVA: 0x00007B20 File Offset: 0x00005D20
		private global::Motorola.Common.Communication.CommunicationManager.AstroWireDevice newAstroWireDevice(global::Motorola.Common.Communication.CommonUtil.DeviceInfo devInfo, global::Motorola.Common.Communication.DeviceDiscovery.RNDISRadioProfile profile)
		{
			return new global::Motorola.Common.Communication.CommunicationManager.AstroWireDevice(devInfo, profile);
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x0600018A RID: 394 RVA: 0x00007B29 File Offset: 0x00005D29
		public override string PAC_Name
		{
			get
			{
				return "ASTRO_";
			}
		}
	}
}
