using System;
using Motorola.Common.Communication.CommonUtil;

namespace Motorola.Common.Communication.CommunicationManager
{
	// Token: 0x02000008 RID: 8
	internal class AstroOtapDevice : global::Motorola.Common.Communication.CommunicationManager.MotoDevice
	{
		// Token: 0x0600006B RID: 107 RVA: 0x00003435 File Offset: 0x00001635
		public AstroOtapDevice(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo) : base(deviceInfo, null)
		{
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00003440 File Offset: 0x00001640
		public override ushort OpenSession(global::Motorola.Common.Communication.CommonUtil.RadioOperation operationType, global::Motorola.Common.Communication.CommonUtil.SessionParameter sessionParameter)
		{
			ushort num = base.OpenSession(global::Motorola.Common.Communication.CommonUtil.RadioOperation.Create, sessionParameter);
			if (sessionParameter != null)
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("Otap Previous Session ID: " + sessionParameter.PreviousSessionID, new object[0]);
			}
			if (base.SequenceManager.DifferentialWriteSupported(num, operationType))
			{
				base.DifferentialWriteCapableRadio = true;
				this.InitDeviceExtendedDeviceParams();
			}
			else
			{
				this.InitDeviceParams();
			}
			base.UpdateSession(operationType, sessionParameter);
			return num;
		}

		// Token: 0x0600006D RID: 109 RVA: 0x000034AC File Offset: 0x000016AC
		public override global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo ReadExtendedDeviceInfo()
		{
			global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo extendedDeviceInfo = base.SequenceManager.ReadExtendedDeviceInfo();
			if (string.IsNullOrEmpty(extendedDeviceInfo.RadioID))
			{
				extendedDeviceInfo.RadioID = this.DeviceInfo.RadioID;
			}
			if (base.DifferentialWriteCapableRadio)
			{
				this.DeviceInfo.RadioStorage = extendedDeviceInfo.RadioStorage;
				base.ExtendedDeviceInfo = extendedDeviceInfo;
			}
			if (this.DeviceInfo.ConnectionInfo != null && extendedDeviceInfo.ConnectionInfo != null)
			{
				this.DeviceInfo.ConnectionInfo.OtapConnectionType = extendedDeviceInfo.ConnectionInfo.OtapConnectionType;
			}
			extendedDeviceInfo.ConnectionInfo = this.DeviceInfo.ConnectionInfo;
			extendedDeviceInfo.RadioState = global::Motorola.Common.Communication.CommonUtil.RadioState.Ready;
			this.DeviceInfo.CodeplugVersion = extendedDeviceInfo.CodeplugVersion;
			this.DeviceInfo.ModelNumber = extendedDeviceInfo.ModelNumber;
			this.DeviceInfo.SerialNumber = extendedDeviceInfo.SerialNumber;
			this.DeviceInfo.SoftwareVersion = extendedDeviceInfo.SoftwareVersion;
			if ((this.DeviceInfo.ConnectionInfo.ConnectionType == global::Motorola.Common.Communication.CommonUtil.ConnectionType.LENetwork || this.DeviceInfo.ConnectionInfo.ConnectionType == global::Motorola.Common.Communication.CommonUtil.ConnectionType.DMR3Network) && (extendedDeviceInfo.Family == global::Motorola.Common.Communication.CommonUtil.ProductFamily.ParadiseRepeaterRadio || extendedDeviceInfo.Family == global::Motorola.Common.Communication.CommonUtil.ProductFamily.MatrixRepeaterRadio))
			{
				this.DeviceInfo.Family = extendedDeviceInfo.Family;
			}
			return extendedDeviceInfo;
		}
	}
}
