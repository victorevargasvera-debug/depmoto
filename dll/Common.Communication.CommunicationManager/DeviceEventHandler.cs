using System;
using Motorola.Common.Communication.CommonUtil;

namespace Motorola.Common.Communication.CommunicationManager
{
	// Token: 0x02000018 RID: 24
	public class DeviceEventHandler : global::Motorola.Common.Communication.CommunicationManager.IDeviceEventHandler
	{
		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600009F RID: 159 RVA: 0x00003D1F File Offset: 0x00001F1F
		// (set) Token: 0x060000A0 RID: 160 RVA: 0x00003D27 File Offset: 0x00001F27
		public global::System.EventHandler<global::Motorola.Common.Communication.CommonUtil.DeviceEventArgs> DeviceConnectedEventHandler { get; set; }

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x060000A1 RID: 161 RVA: 0x00003D30 File Offset: 0x00001F30
		// (set) Token: 0x060000A2 RID: 162 RVA: 0x00003D38 File Offset: 0x00001F38
		public global::System.EventHandler<global::Motorola.Common.Communication.CommonUtil.DeviceEventArgs> DeviceLostEventHandler { get; set; }

		// Token: 0x060000A3 RID: 163 RVA: 0x00003D41 File Offset: 0x00001F41
		protected virtual void OnDeviceConnected(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo)
		{
			if (this.DeviceConnectedEventHandler != null)
			{
				this.DeviceConnectedEventHandler(this, new global::Motorola.Common.Communication.CommonUtil.DeviceEventArgs(deviceInfo));
			}
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00003D5D File Offset: 0x00001F5D
		protected virtual void OnDeviceLost(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo)
		{
			if (this.DeviceLostEventHandler != null)
			{
				this.DeviceLostEventHandler(this, new global::Motorola.Common.Communication.CommonUtil.DeviceEventArgs(deviceInfo));
			}
		}
	}
}
