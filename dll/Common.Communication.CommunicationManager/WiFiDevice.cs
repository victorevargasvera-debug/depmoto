using System;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.DeviceDiscovery;

namespace Motorola.Common.Communication.CommunicationManager
{
	// Token: 0x02000009 RID: 9
	internal class WiFiDevice : global::Motorola.Common.Communication.CommunicationManager.MotoDevice
	{
		// Token: 0x0600006E RID: 110 RVA: 0x000035DF File Offset: 0x000017DF
		internal WiFiDevice(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.DeviceDiscovery.RNDISRadioProfile profile) : base(deviceInfo, profile)
		{
		}

		// Token: 0x0600006F RID: 111 RVA: 0x000035F4 File Offset: 0x000017F4
		public override void Prefetch()
		{
			try
			{
				this.RetrieveIPAddress(ref this._radioProfile);
				this.InitDeviceParams();
				base.ChangeRadioState(global::Motorola.Common.Communication.CommonUtil.RadioState.Ready);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("RNDIS Device - Error in WiFi Prefetch {0} .", new object[]
				{
					ex.Message
				});
			}
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00003650 File Offset: 0x00001850
		public override ushort OpenSession(global::Motorola.Common.Communication.CommonUtil.RadioOperation operationType, global::Motorola.Common.Communication.CommonUtil.SessionParameter sessionParameter)
		{
			this.OperationType = operationType;
			return base.OpenSession(operationType, sessionParameter);
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00003664 File Offset: 0x00001864
		public override void CloseSession(bool pendingDeploy)
		{
			base.ValidateSession();
			try
			{
				base.SequenceManager.CloseSession(base.ActiveSession.ID, base.ActiveSession.OperationType, pendingDeploy);
				if (pendingDeploy)
				{
					global::Motorola.Common.Communication.CommunicationManager.CommunicationManagerClass.Instance.RemoveDevice(this.DeviceInfo.RadioID);
				}
			}
			finally
			{
				base.DisposeSession();
			}
		}

		// Token: 0x06000072 RID: 114 RVA: 0x000036CC File Offset: 0x000018CC
		public override void InitDeviceParams()
		{
			this.DeviceInfo.SerialNumber = base.RadioProfile.RadioSerialNumber;
		}

		// Token: 0x06000073 RID: 115 RVA: 0x000036E4 File Offset: 0x000018E4
		protected override bool RetrieveIPAddress(ref global::Motorola.Common.Communication.DeviceDiscovery.RNDISRadioProfile _radioProfile)
		{
			bool result;
			lock (this.IPLock)
			{
				global::Motorola.Common.Communication.CommonUtil.ConnectionInfo connectionInfo = new global::Motorola.Common.Communication.CommonUtil.ConnectionInfo();
				connectionInfo.ConnectionType = global::Motorola.Common.Communication.CommonUtil.ConnectionType.WIFI;
				connectionInfo.UniqueAddress = _radioProfile.IPAddress;
				connectionInfo.DeviceInstance = _radioProfile.DeviceInstanceID;
				connectionInfo.Location = _radioProfile.PortName;
				if (this.DeviceInfo.ConnectionInfo != null)
				{
					connectionInfo.SessionID = this.DeviceInfo.ConnectionInfo.SessionID;
				}
				this.DeviceInfo.ConnectionInfo = connectionInfo;
				result = true;
			}
			return result;
		}

		// Token: 0x0400000E RID: 14
		private object IPLock = new object();

		// Token: 0x0400000F RID: 15
		protected global::Motorola.Common.Communication.CommonUtil.RadioOperation OperationType;
	}
}
