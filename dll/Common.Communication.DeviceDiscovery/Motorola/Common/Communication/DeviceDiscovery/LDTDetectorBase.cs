using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Motorola.Common.Communication.CommonUtil;

namespace Motorola.Common.Communication.DeviceDiscovery
{
	// Token: 0x02000011 RID: 17
	public class LDTDetectorBase : global::Motorola.Common.Communication.DeviceDiscovery.IDeviceDetector
	{
		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000065 RID: 101 RVA: 0x00002E3C File Offset: 0x0000103C
		public global::Motorola.Common.Communication.DeviceDiscovery.DeviceDetectorType DetectorType
		{
			get
			{
				return this._detectorType;
			}
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00002E44 File Offset: 0x00001044
		public virtual bool Start()
		{
			return true;
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00002E47 File Offset: 0x00001047
		public virtual void Stop()
		{
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00002E4C File Offset: 0x0000104C
		internal void OnDeviceAdd(global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioProfile profile)
		{
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("DNS-SD: New device<{0}> Added", new object[]
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

		// Token: 0x06000069 RID: 105 RVA: 0x00002EA8 File Offset: 0x000010A8
		internal void OnDeviceRemove(global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioProfile profile)
		{
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("DNS-SD: Device<{0}> Removed", new object[]
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

		// Token: 0x0600006A RID: 106 RVA: 0x00002F54 File Offset: 0x00001154
		internal void OnRemove(global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioProfile profile)
		{
			global::Motorola.Common.Communication.DeviceDiscovery.LDTDetectorBase._arrivedDevices.Remove(profile);
			if (profile.ConnectMode == global::Motorola.Common.Communication.DeviceDiscovery.LDTConnectMode.USB)
			{
				if (global::Motorola.Common.Communication.DeviceDiscovery.LDTDetectorBase._arrivedDevices.Count((global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioProfile m) => m.ConnectMode == global::Motorola.Common.Communication.DeviceDiscovery.LDTConnectMode.WIFI && m.IMEI == profile.IMEI) > 0)
				{
					global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioProfile ldtradioProfile = global::Motorola.Common.Communication.DeviceDiscovery.LDTDetectorBase._arrivedDevices.First((global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioProfile m) => m.ConnectMode == global::Motorola.Common.Communication.DeviceDiscovery.LDTConnectMode.WIFI && m.IMEI == profile.IMEI);
					ldtradioProfile.IMEI = null;
					this.OnDeviceAdd(ldtradioProfile);
				}
			}
		}

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x0600006B RID: 107 RVA: 0x00002FD8 File Offset: 0x000011D8
		// (remove) Token: 0x0600006C RID: 108 RVA: 0x00003010 File Offset: 0x00001210
		public event global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler deviceAttached;

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x0600006D RID: 109 RVA: 0x00003048 File Offset: 0x00001248
		// (remove) Token: 0x0600006E RID: 110 RVA: 0x00003080 File Offset: 0x00001280
		public event global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler deviceDetached;

		// Token: 0x0600006F RID: 111 RVA: 0x000030B5 File Offset: 0x000012B5
		public bool DeviceChanged(global::Motorola.Common.Communication.DeviceDiscovery.OriginalPnPMsg pnpMsg)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000070 RID: 112 RVA: 0x000030BC File Offset: 0x000012BC
		public void UpdatePasswords(global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.AuthenticationInfo> psws)
		{
			global::Motorola.Common.Communication.DeviceDiscovery.LDTDetectorBase._passwords.Clear();
			global::Motorola.Common.Communication.DeviceDiscovery.LDTDetectorBase._passwords.AddRange(psws);
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00003114 File Offset: 0x00001314
		public void DetachDevice(string imei)
		{
			if (global::Motorola.Common.Communication.DeviceDiscovery.LDTDetectorBase._arrivedDevices.Count((global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioProfile m) => m.IMEI == imei) > 0)
			{
				this.OnDeviceRemove(global::Motorola.Common.Communication.DeviceDiscovery.LDTDetectorBase._arrivedDevices.First((global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioProfile m) => m.IMEI == imei));
				global::Motorola.Common.Communication.DeviceDiscovery.LDTDetectorBase._arrivedDevices.RemoveAll((global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioProfile m) => m.IMEI == imei);
			}
		}

		// Token: 0x0400002D RID: 45
		public static readonly string LTE_REPEATER_PID = "_LTE_Repeater";

		// Token: 0x0400002E RID: 46
		public global::Motorola.Common.Communication.DeviceDiscovery.DeviceDetectorType _detectorType;

		// Token: 0x0400002F RID: 47
		public static global::System.Collections.Generic.List<global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioProfile> _arrivedDevices = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioProfile>();

		// Token: 0x04000030 RID: 48
		public global::System.Threading.Thread _receiveThread;

		// Token: 0x04000031 RID: 49
		public static global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.AuthenticationInfo> _passwords = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.AuthenticationInfo>();

		// Token: 0x04000032 RID: 50
		public bool _isStopping;
	}
}
