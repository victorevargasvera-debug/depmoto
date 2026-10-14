using System;
using System.Threading;
using Motorola.Common.Communication.CommonUtil;

namespace Motorola.Common.Communication.DeviceDiscovery
{
	// Token: 0x0200001D RID: 29
	public abstract class UDPDetectorBase : global::Motorola.Common.Communication.DeviceDiscovery.IDeviceDetector
	{
		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000E2 RID: 226 RVA: 0x00005C01 File Offset: 0x00003E01
		public global::Motorola.Common.Communication.DeviceDiscovery.DeviceDetectorType DetectorType
		{
			get
			{
				return this._detectorType;
			}
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00005C09 File Offset: 0x00003E09
		public virtual bool Start()
		{
			this._backgroundThread = new global::System.Threading.Thread(new global::System.Threading.ThreadStart(this.BackgroundThread));
			this._backgroundThread.Start();
			return true;
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00005C2F File Offset: 0x00003E2F
		public virtual void Stop()
		{
			this._isStopping = true;
		}

		// Token: 0x14000008 RID: 8
		// (add) Token: 0x060000E5 RID: 229 RVA: 0x00005C38 File Offset: 0x00003E38
		// (remove) Token: 0x060000E6 RID: 230 RVA: 0x00005C70 File Offset: 0x00003E70
		public event global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler deviceAttached;

		// Token: 0x14000009 RID: 9
		// (add) Token: 0x060000E7 RID: 231 RVA: 0x00005CA8 File Offset: 0x00003EA8
		// (remove) Token: 0x060000E8 RID: 232 RVA: 0x00005CE0 File Offset: 0x00003EE0
		public event global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler deviceDetached;

		// Token: 0x060000E9 RID: 233 RVA: 0x00005D15 File Offset: 0x00003F15
		public bool DeviceChanged(global::Motorola.Common.Communication.DeviceDiscovery.OriginalPnPMsg pnpMsg)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x060000EA RID: 234
		protected abstract void BackgroundThread();

		// Token: 0x060000EB RID: 235 RVA: 0x00005D1C File Offset: 0x00003F1C
		internal void OnDeviceAdd(global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile profile)
		{
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("RP: New device<{0}> Added", new object[]
			{
				profile.IPAddress
			});
			if (this.deviceAttached != null)
			{
				global::Motorola.Common.Communication.DeviceDiscovery.DeviceMsgEventArgs deviceMsgEventArgs = new global::Motorola.Common.Communication.DeviceDiscovery.DeviceMsgEventArgs();
				deviceMsgEventArgs.PnPAction = global::Motorola.Common.Communication.DeviceDiscovery.DevPnPAction.DeviceAttached;
				deviceMsgEventArgs.RadioInfoSet.Add(profile);
				this.deviceAttached(this, deviceMsgEventArgs);
			}
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00005D78 File Offset: 0x00003F78
		internal void OnDeviceRemove(global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile profile)
		{
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("RP: Device<{0}> Removed", new object[]
			{
				profile.IPAddress
			});
			if (this.deviceDetached != null)
			{
				global::Motorola.Common.Communication.DeviceDiscovery.DeviceMsgEventArgs deviceMsgEventArgs = new global::Motorola.Common.Communication.DeviceDiscovery.DeviceMsgEventArgs();
				deviceMsgEventArgs.PnPAction = global::Motorola.Common.Communication.DeviceDiscovery.DevPnPAction.DeviceDetached;
				deviceMsgEventArgs.RadioInfoSet.Add(profile);
				this.deviceDetached(this, deviceMsgEventArgs);
			}
		}

		// Token: 0x04000082 RID: 130
		protected global::Motorola.Common.Communication.DeviceDiscovery.DeviceDetectorType _detectorType;

		// Token: 0x04000083 RID: 131
		protected global::System.Threading.Thread _backgroundThread;

		// Token: 0x04000084 RID: 132
		protected bool _isStopping;
	}
}
