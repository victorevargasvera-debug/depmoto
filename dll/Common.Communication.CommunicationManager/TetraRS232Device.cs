using System;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.DeviceDiscovery;

namespace Motorola.Common.Communication.CommunicationManager
{
	// Token: 0x02000059 RID: 89
	public class TetraRS232Device : global::Motorola.Common.Communication.CommunicationManager.TetraVComDevice
	{
		// Token: 0x17000057 RID: 87
		// (get) Token: 0x0600021B RID: 539 RVA: 0x0000BCC0 File Offset: 0x00009EC0
		// (set) Token: 0x0600021C RID: 540 RVA: 0x0000BD04 File Offset: 0x00009F04
		public override global::Motorola.Common.Communication.CommonUtil.DeviceInfo DeviceInfo
		{
			get
			{
				global::Motorola.Common.Communication.CommonUtil.DeviceInfo devInfo;
				lock (this._propertyAccessLock)
				{
					devInfo = this._devInfo;
				}
				return devInfo;
			}
			set
			{
				lock (this._propertyAccessLock)
				{
					this._devInfo = (value as global::Motorola.Common.Communication.CommonUtil.TetraDeviceInfo);
				}
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x0600021D RID: 541 RVA: 0x0000BD4C File Offset: 0x00009F4C
		// (set) Token: 0x0600021E RID: 542 RVA: 0x0000BD90 File Offset: 0x00009F90
		public override bool Active
		{
			get
			{
				bool active;
				lock (this._propertyAccessLock)
				{
					active = this._active;
				}
				return active;
			}
			set
			{
				lock (this._propertyAccessLock)
				{
					this._active = value;
				}
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000220 RID: 544 RVA: 0x0000BE30 File Offset: 0x0000A030
		// (set) Token: 0x0600021F RID: 543 RVA: 0x0000BDD4 File Offset: 0x00009FD4
		public override global::Motorola.Common.Communication.CommonUtil.RadioState radioState
		{
			get
			{
				global::Motorola.Common.Communication.CommonUtil.RadioState radioState;
				lock (this._propertyAccessLock)
				{
					radioState = this._radioState;
				}
				return radioState;
			}
			set
			{
				lock (this._propertyAccessLock)
				{
					this._radioState = value;
					if (this.DeviceInfo != null)
					{
						this.DeviceInfo.RadioState = this._radioState;
					}
				}
			}
		}

		// Token: 0x06000221 RID: 545 RVA: 0x0000BE74 File Offset: 0x0000A074
		public string GetRS232PortName()
		{
			if (base.Profile != null)
			{
				return (base.Profile as global::Motorola.Common.Communication.DeviceDiscovery.TetraRadioProfile).Path;
			}
			return null;
		}

		// Token: 0x06000222 RID: 546 RVA: 0x0000BE90 File Offset: 0x0000A090
		public TetraRS232Device(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo)
		{
			this._devInfo = (deviceInfo as global::Motorola.Common.Communication.CommonUtil.TetraDeviceInfo);
			this._radioState = global::Motorola.Common.Communication.CommonUtil.RadioState.None;
		}

		// Token: 0x06000223 RID: 547 RVA: 0x0000BEC8 File Offset: 0x0000A0C8
		public override ushort OpenSession(global::Motorola.Common.Communication.CommonUtil.RadioOperation operationType, global::Motorola.Common.Communication.CommonUtil.SessionParameter sessionParameter)
		{
			ushort result;
			if (this._createState)
			{
				result = base.OpenSession(operationType, sessionParameter);
				(base.SequenceManager as global::Motorola.Common.Communication.ITetraSeqMgrSpecialOperation).Invalidate(false);
				base.InitDeviceParams();
				this.ConstructUARTInfo();
				base.CloseSession(false);
				this._createState = true;
			}
			else
			{
				result = base.OpenSession(operationType, sessionParameter);
			}
			base.CommPipe.OpenPort(10);
			return result;
		}

		// Token: 0x06000224 RID: 548 RVA: 0x0000BF2C File Offset: 0x0000A12C
		private void ConstructUARTInfo()
		{
			global::Motorola.Common.Communication.CommunicationManager.RadioCreatorUtility radioCreatorUtility = new global::Motorola.Common.Communication.CommunicationManager.RadioCreatorUtility();
			global::Motorola.Common.Communication.DeviceDiscovery.TetraRadioProfile tetraRadioProfile = base.Profile as global::Motorola.Common.Communication.DeviceDiscovery.TetraRadioProfile;
			global::Motorola.Common.Communication.CommonUtil.TetraDeviceInfo tetraDeviceInfo = this.DeviceInfo as global::Motorola.Common.Communication.CommonUtil.TetraDeviceInfo;
			string empty = string.Empty;
			if (radioCreatorUtility.GetRS232PortInstanceID(tetraRadioProfile.Path, out empty))
			{
				tetraRadioProfile.UniqueLocation = "UART_PIPE_" + empty;
			}
			else
			{
				tetraRadioProfile.UniqueLocation = "UART_PIPE_" + tetraDeviceInfo.CpuID;
			}
			tetraRadioProfile.PhysicalLocation = tetraRadioProfile.UniqueLocation;
			this.DeviceInfo.RadioID = tetraRadioProfile.UniqueLocation;
			tetraRadioProfile.VID = "0CAD";
			if (this.DeviceInfo.Family == global::Motorola.Common.Communication.CommonUtil.ProductFamily.LegacyProgRadio)
			{
				tetraRadioProfile.PID = "9003";
			}
			else if (this.DeviceInfo.Family == global::Motorola.Common.Communication.CommonUtil.ProductFamily.GemstoneBMPProgRadio || this.DeviceInfo.Family == global::Motorola.Common.Communication.CommonUtil.ProductFamily.FrodoProgRadio)
			{
				tetraRadioProfile.PID = "9010";
			}
			tetraDeviceInfo.PID = tetraRadioProfile.PID;
			tetraDeviceInfo.VID = tetraRadioProfile.VID;
			tetraDeviceInfo.CompositeDeviceLocation = (tetraDeviceInfo.Location = tetraRadioProfile.UniqueLocation);
		}

		// Token: 0x06000225 RID: 549 RVA: 0x0000C03B File Offset: 0x0000A23B
		public override void CloseSession(bool pendingDeploy)
		{
			if (this._createState)
			{
				this._createState = false;
			}
			base.CloseSession(false);
			base.CommPipe.ClosePort();
			if (!this._active)
			{
				global::Motorola.Common.Communication.CommunicationManager.CommunicationManagerClass.Instance.RemoveDevice(this.DeviceInfo.RadioID);
			}
		}

		// Token: 0x06000226 RID: 550 RVA: 0x0000C07C File Offset: 0x0000A27C
		public override void DeviceControl(global::Motorola.Common.Communication.CommonUtil.DeviceControlInputParams inputParams, ref global::Motorola.Common.Communication.CommonUtil.DeviceControlOutputParams outputParams)
		{
			if (inputParams.type != global::Motorola.Common.Communication.CommonUtil.DeviceControlOperationType.RemoveRadio)
			{
				base.DeviceControl(inputParams, ref outputParams);
			}
			if ((inputParams.type == global::Motorola.Common.Communication.CommonUtil.DeviceControlOperationType.TurnOffRadio || inputParams.type == global::Motorola.Common.Communication.CommonUtil.DeviceControlOperationType.RemoveRadio) && this.DeviceInfo.ConnectionInfo.ConnectionType == global::Motorola.Common.Communication.CommonUtil.ConnectionType.RS232)
			{
				this.Active = false;
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000227 RID: 551 RVA: 0x0000C0C8 File Offset: 0x0000A2C8
		public bool CreateState
		{
			get
			{
				return this._createState;
			}
		}

		// Token: 0x0400007B RID: 123
		private bool _active;

		// Token: 0x0400007C RID: 124
		private bool _createState = true;

		// Token: 0x0400007D RID: 125
		private object _propertyAccessLock = new object();

		// Token: 0x0400007E RID: 126
		private global::Motorola.Common.Communication.CommonUtil.TetraDeviceInfo _devInfo = new global::Motorola.Common.Communication.CommonUtil.TetraDeviceInfo();

		// Token: 0x0400007F RID: 127
		private global::Motorola.Common.Communication.CommonUtil.RadioState _radioState;
	}
}
