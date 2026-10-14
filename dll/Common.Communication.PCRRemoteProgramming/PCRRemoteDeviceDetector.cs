using System;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.DeviceDiscovery;

namespace Motorola.Common.Communication.PCRRemoteProgramming
{
	// Token: 0x02000008 RID: 8
	public class PCRRemoteDeviceDetector : global::Motorola.Common.Communication.DeviceDiscovery.IDeviceDetector
	{
		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000022 RID: 34 RVA: 0x00002C4F File Offset: 0x00000E4F
		public global::Motorola.Common.Communication.DeviceDiscovery.DeviceDetectorType DetectorType
		{
			get
			{
				return this._detectorType;
			}
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002C57 File Offset: 0x00000E57
		public bool Start()
		{
			return true;
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002C5A File Offset: 0x00000E5A
		public void Stop()
		{
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002C5C File Offset: 0x00000E5C
		internal void OnDeviceAdd(global::Motorola.Common.Communication.PCRRemoteProgramming.PCRRemoteDeviceProfile profile)
		{
			string text;
			if (!string.IsNullOrEmpty(profile.PEER.SerialNumber))
			{
				text = string.Format("{0}:{1}:{2}", profile.PEER.ID, profile.PEER.IP, profile.PEER.SerialNumber);
			}
			else
			{
				text = string.Format("{0}:{1}", profile.PEER.ID, profile.PEER.IP);
			}
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("RP: New device<{0}> Added", new object[]
			{
				text
			});
			if (this.deviceAttached != null)
			{
				global::Motorola.Common.Communication.DeviceDiscovery.DeviceMsgEventArgs deviceMsgEventArgs = new global::Motorola.Common.Communication.DeviceDiscovery.DeviceMsgEventArgs();
				deviceMsgEventArgs.PnPAction = global::Motorola.Common.Communication.DeviceDiscovery.DevPnPAction.DeviceAttached;
				deviceMsgEventArgs.RadioInfoSet.Add(profile);
				this.deviceAttached(this, deviceMsgEventArgs);
			}
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002D3C File Offset: 0x00000F3C
		internal void OnDeviceRemove(global::Motorola.Common.Communication.PCRRemoteProgramming.PCRRemoteDeviceProfile profile)
		{
			string text;
			if (!string.IsNullOrEmpty(profile.PEER.SerialNumber))
			{
				text = string.Format("{0}:{1}:{2}", profile.PEER.ID, profile.PEER.IP, profile.PEER.SerialNumber);
			}
			else
			{
				text = string.Format("{0}:{1}", profile.PEER.ID, profile.PEER.IP);
			}
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("RP: Device<{0}> Removed", new object[]
			{
				text
			});
			if (this.deviceDetached != null)
			{
				global::Motorola.Common.Communication.DeviceDiscovery.DeviceMsgEventArgs deviceMsgEventArgs = new global::Motorola.Common.Communication.DeviceDiscovery.DeviceMsgEventArgs();
				deviceMsgEventArgs.PnPAction = global::Motorola.Common.Communication.DeviceDiscovery.DevPnPAction.DeviceDetached;
				deviceMsgEventArgs.RadioInfoSet.Add(profile);
				this.deviceDetached(this, deviceMsgEventArgs);
			}
		}

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x06000027 RID: 39 RVA: 0x00002E1C File Offset: 0x0000101C
		// (remove) Token: 0x06000028 RID: 40 RVA: 0x00002E54 File Offset: 0x00001054
		public event global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler deviceAttached;

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x06000029 RID: 41 RVA: 0x00002E8C File Offset: 0x0000108C
		// (remove) Token: 0x0600002A RID: 42 RVA: 0x00002EC4 File Offset: 0x000010C4
		public event global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler deviceDetached;

		// Token: 0x0600002B RID: 43 RVA: 0x00002EF9 File Offset: 0x000010F9
		public bool DeviceChanged(global::Motorola.Common.Communication.DeviceDiscovery.OriginalPnPMsg pnpMsg)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x04000011 RID: 17
		public static readonly string PCR_REMOTE_REPEATER_PID = "_PCR_Remote_Repeater";

		// Token: 0x04000012 RID: 18
		private global::Motorola.Common.Communication.DeviceDiscovery.DeviceDetectorType _detectorType = global::Motorola.Common.Communication.DeviceDiscovery.DeviceDetectorType.PCRRemoteDeviceDetector;
	}
}
