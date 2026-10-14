using System;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.DeviceDiscovery;

namespace Motorola.Common.Communication.CommunicationManager
{
	// Token: 0x0200000A RID: 10
	internal class AstroWiFiDevice : global::Motorola.Common.Communication.CommunicationManager.WiFiDevice
	{
		// Token: 0x06000074 RID: 116 RVA: 0x00003788 File Offset: 0x00001988
		public AstroWiFiDevice(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.DeviceDiscovery.RNDISRadioProfile profile) : base(deviceInfo, profile)
		{
			if (profile != null)
			{
				this.instanceID = profile.InstanceId;
			}
		}

		// Token: 0x06000075 RID: 117 RVA: 0x000037A1 File Offset: 0x000019A1
		public override ushort OpenSession(global::Motorola.Common.Communication.CommonUtil.RadioOperation operationType, global::Motorola.Common.Communication.CommonUtil.SessionParameter sessionParameter)
		{
			if (base.RadioProfile != null)
			{
				base.RefreshIPAddress();
			}
			return base.OpenSession(operationType, sessionParameter);
		}

		// Token: 0x04000010 RID: 16
		private uint instanceID;
	}
}
