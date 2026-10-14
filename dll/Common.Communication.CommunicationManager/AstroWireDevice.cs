using System;
using System.Text;
using System.Threading;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.DeviceDiscovery;
using Motorola.Common.Communication.TetraUtility;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.CommunicationManager
{
	// Token: 0x0200000B RID: 11
	internal class AstroWireDevice : global::Motorola.Common.Communication.CommunicationManager.MotoDevice
	{
		// Token: 0x06000076 RID: 118 RVA: 0x000037B9 File Offset: 0x000019B9
		public AstroWireDevice(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.DeviceDiscovery.RNDISRadioProfile profile) : base(deviceInfo, profile)
		{
			this.instanceID = profile.InstanceId;
		}

		// Token: 0x06000077 RID: 119 RVA: 0x000037CF File Offset: 0x000019CF
		public override ushort OpenSession(global::Motorola.Common.Communication.CommonUtil.RadioOperation operationType, global::Motorola.Common.Communication.CommonUtil.SessionParameter sessionParameter)
		{
			base.RefreshIPAddress();
			return base.OpenSession(operationType, sessionParameter);
		}

		// Token: 0x06000078 RID: 120 RVA: 0x000037E0 File Offset: 0x000019E0
		public override void CloseSession(bool pendingDeploy)
		{
			base.ValidateSession();
			try
			{
				base.SequenceManager.CloseSession(base.ActiveSession.ID, base.ActiveSession.OperationType, pendingDeploy);
				global::System.Threading.Thread.Sleep(500);
				if (!pendingDeploy && !this.DeviceInfo.ConnectionInfo.DeviceInstance.Contains("WiFi"))
				{
					base.ChangeRadioState(global::Motorola.Common.Communication.CommonUtil.RadioState.Removing);
					if (global::Motorola.Common.Communication.CommunicationManager.CommunicationManagerClass.Instance.DiscoveryWorkMode == global::Motorola.Common.Communication.CommonUtil.WorkMode.Lazy)
					{
						global::System.Threading.Thread.Sleep(1000);
						global::Motorola.Common.Communication.TetraUtility.NativeMethodsForOtherNamSpace.CM_Request_Device_Eject(this.instanceID, global::System.UIntPtr.Zero, global::System.UIntPtr.Zero, 0U, 0U);
					}
				}
			}
			finally
			{
				base.DisposeSession();
			}
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00003890 File Offset: 0x00001A90
		public override global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo ReadExtendedDeviceInfo()
		{
			global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo extendedDeviceInfo = base.SequenceManager.ReadExtendedDeviceInfo();
			if (string.IsNullOrEmpty(extendedDeviceInfo.RadioID))
			{
				extendedDeviceInfo.RadioID = this.DeviceInfo.RadioID;
			}
			extendedDeviceInfo.ConnectionInfo = this.DeviceInfo.ConnectionInfo;
			extendedDeviceInfo.RadioState = global::Motorola.Common.Communication.CommonUtil.RadioState.Ready;
			if (this.DeviceInfo.SerialNumber == extendedDeviceInfo.SerialNumber || this.DeviceInfo.SerialNumber == global::System.Text.Encoding.ASCII.GetString(global::System.Convert.FromBase64String(extendedDeviceInfo.SerialNumber)))
			{
				this.DeviceInfo.CodeplugVersion = extendedDeviceInfo.CodeplugVersion;
				this.DeviceInfo.ModelNumber = extendedDeviceInfo.ModelNumber;
				this.DeviceInfo.SerialNumber = extendedDeviceInfo.SerialNumber;
				this.DeviceInfo.SoftwareVersion = extendedDeviceInfo.SoftwareVersion;
				return extendedDeviceInfo;
			}
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerWireDeviceIdentityMismatched);
		}

		// Token: 0x04000011 RID: 17
		private uint instanceID;
	}
}
