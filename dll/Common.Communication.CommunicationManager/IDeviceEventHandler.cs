using System;
using Motorola.Common.Communication.CommonUtil;

namespace Motorola.Common.Communication.CommunicationManager
{
	// Token: 0x02000017 RID: 23
	internal interface IDeviceEventHandler
	{
		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600009B RID: 155
		// (set) Token: 0x0600009C RID: 156
		global::System.EventHandler<global::Motorola.Common.Communication.CommonUtil.DeviceEventArgs> DeviceConnectedEventHandler { get; set; }

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600009D RID: 157
		// (set) Token: 0x0600009E RID: 158
		global::System.EventHandler<global::Motorola.Common.Communication.CommonUtil.DeviceEventArgs> DeviceLostEventHandler { get; set; }
	}
}
