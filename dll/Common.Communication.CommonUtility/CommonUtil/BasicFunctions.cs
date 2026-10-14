using System;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x02000002 RID: 2
	public static class BasicFunctions
	{
		// Token: 0x06000001 RID: 1 RVA: 0x000020D0 File Offset: 0x000002D0
		public static bool IsWiredDevice(global::Motorola.Common.Communication.CommonUtil.DeviceInfo device)
		{
			return device.ConnectionInfo.ConnectionType == global::Motorola.Common.Communication.CommonUtil.ConnectionType.NetAdapter;
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002100 File Offset: 0x00000300
		public static bool IsRRPDevice(global::Motorola.Common.Communication.CommonUtil.DeviceInfo device)
		{
			return device.ConnectionInfo.ConnectionType == global::Motorola.Common.Communication.CommonUtil.ConnectionType.LENetwork || device.ConnectionInfo.ConnectionType == global::Motorola.Common.Communication.CommonUtil.ConnectionType.DMR3Network;
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002144 File Offset: 0x00000344
		public static bool IsOtapDevice(global::Motorola.Common.Communication.CommonUtil.DeviceInfo device)
		{
			return device.ConnectionInfo.ConnectionType == global::Motorola.Common.Communication.CommonUtil.ConnectionType.Otap;
		}
	}
}
