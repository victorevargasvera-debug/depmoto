using System;
using Motorola.Common.Communication;

namespace Common.Communication.Simulator
{
	// Token: 0x02000007 RID: 7
	public class VirtualDeviceFactory : global::Motorola.Common.Communication.DeviceFactoryBase
	{
		// Token: 0x0600001B RID: 27 RVA: 0x00002814 File Offset: 0x00000A14
		public VirtualDeviceFactory()
		{
			base.PIDList = new string[]
			{
				"99999",
				"99998",
				"_PBB_VirtualDevice"
			};
		}

		// Token: 0x0600001C RID: 28 RVA: 0x0000284D File Offset: 0x00000A4D
		protected override bool CreateRadio(out global::Motorola.Common.Communication.IMotoDevice radio, global::Motorola.Common.Communication.IRadioProfile hwProfile)
		{
			radio = new global::Common.Communication.Simulator.VirtualMotoDevice(hwProfile);
			return true;
		}
	}
}
