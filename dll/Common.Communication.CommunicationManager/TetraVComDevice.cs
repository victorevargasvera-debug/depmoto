using System;
using System.Collections.Generic;
using System.ComponentModel;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.Communication.DeviceDiscovery;
using Motorola.Common.Communication.Pba;
using Motorola.Common.Communication.TetraUtility;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.CommunicationManager
{
	// Token: 0x02000058 RID: 88
	public class TetraVComDevice : global::Motorola.Common.Communication.CommunicationManager.MotoDevice, global::Motorola.Common.Communication.ITetraDevSpecialOperation, global::System.IDisposable
	{
		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060001F4 RID: 500 RVA: 0x0000B254 File Offset: 0x00009454
		// (set) Token: 0x060001F5 RID: 501 RVA: 0x0000B298 File Offset: 0x00009498
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

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060001F6 RID: 502 RVA: 0x0000B2E0 File Offset: 0x000094E0
		// (set) Token: 0x060001F7 RID: 503 RVA: 0x0000B324 File Offset: 0x00009524
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

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060001F9 RID: 505 RVA: 0x0000B3C4 File Offset: 0x000095C4
		// (set) Token: 0x060001F8 RID: 504 RVA: 0x0000B368 File Offset: 0x00009568
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

		// Token: 0x060001FA RID: 506 RVA: 0x0000B408 File Offset: 0x00009608
		public override ushort OpenSession(global::Motorola.Common.Communication.CommonUtil.RadioOperation operationType, global::Motorola.Common.Communication.CommonUtil.SessionParameter sessionParameter)
		{
			ushort sessionID = 0;
			lock (this._sessionLock)
			{
				this.CreateSession(sessionID, operationType, sessionParameter);
			}
			return 0;
		}

		// Token: 0x060001FB RID: 507 RVA: 0x0000B450 File Offset: 0x00009650
		public override void CloseSession(bool pendingDeploy)
		{
			try
			{
				base.SequenceManager.CloseSession(base.ActiveSession.ID, base.ActiveSession.OperationType, pendingDeploy);
				(base.SequenceManager as global::Motorola.Common.Communication.ITetraSeqMgrSpecialOperation).Dispose();
			}
			catch (global::Motorola.Common.CustomException.CommonException ex)
			{
				if (ex.ErrorCode != global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerSessionNotOpened)
				{
					throw;
				}
			}
			finally
			{
				(base.SequenceManager as global::Motorola.Common.Communication.ITetraSeqMgrSpecialOperation).Dispose();
				base.ActiveSession = null;
			}
		}

		// Token: 0x060001FC RID: 508 RVA: 0x0000B4DC File Offset: 0x000096DC
		public override void Prefetch()
		{
			if (this.radioState == global::Motorola.Common.Communication.CommonUtil.RadioState.Attached)
			{
				base.ChangeRadioState(global::Motorola.Common.Communication.CommonUtil.RadioState.InitializingDevice);
				this._prepareWorker = new global::Motorola.Common.Communication.TetraUtility.CultureSafeBackGroundWorker();
				this._prepareWorker.DoWork += this.AsynPrepareDevice;
				this._prepareWorker.RunWorkerCompleted += this.PrepareRadioCompleted;
				this._prepareWorker.RunWorkerAsync();
			}
		}

		// Token: 0x060001FD RID: 509 RVA: 0x0000B540 File Offset: 0x00009740
		public override void Init(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.CommonUtil.RadioOperation operation, global::Motorola.Common.Communication.IProgressIndicator progressIndicator)
		{
			this._devInfoForForceWrite = (deviceInfo as global::Motorola.Common.Communication.CommonUtil.TetraDeviceInfo);
			this._devInfo.UseCompress = deviceInfo.UseCompress;
			this._devInfo.ForceErase = (deviceInfo as global::Motorola.Common.Communication.CommonUtil.TetraDeviceInfo).ForceErase;
			base.SequenceManager.ProgressIndicator = progressIndicator;
		}

		// Token: 0x060001FE RID: 510 RVA: 0x0000B58C File Offset: 0x0000978C
		public override global::Motorola.Common.Communication.CommonUtil.DeviceInfo ReadDeviceInfo()
		{
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(base.SequenceManager, global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerSequenceManagerNotCreated);
			this.DeviceInfo = base.SequenceManager.ReadDeviceInfo();
			return this.DeviceInfo;
		}

		// Token: 0x060001FF RID: 511 RVA: 0x0000B5B5 File Offset: 0x000097B5
		public override global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo ReadExtendedDeviceInfo()
		{
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(base.SequenceManager, global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerSequenceManagerNotCreated);
			return base.SequenceManager.ReadExtendedDeviceInfo();
		}

		// Token: 0x06000200 RID: 512 RVA: 0x0000B5D4 File Offset: 0x000097D4
		public override void DeviceControl(global::Motorola.Common.Communication.CommonUtil.DeviceControlInputParams inputParams, ref global::Motorola.Common.Communication.CommonUtil.DeviceControlOutputParams outputParams)
		{
			object.Equals(inputParams.family, global::Motorola.Common.Communication.CommonUtil.ProductFamily.TetraRadio);
			outputParams.result = global::Motorola.Common.Communication.CommonUtil.DeviceControlResult.Success;
			switch (inputParams.type)
			{
			case global::Motorola.Common.Communication.CommonUtil.DeviceControlOperationType.TurnOffRadio:
			{
				if (!(base.SequenceManager as global::Motorola.Common.Communication.ITetraSeqMgrSpecialOperation).TurnOffRadio())
				{
					outputParams.result = global::Motorola.Common.Communication.CommonUtil.DeviceControlResult.Failure;
					return;
				}
				global::Motorola.Common.Communication.IRadioProfile profile = (base.SequenceManager as global::Motorola.Common.Communication.ITetraSeqMgrSpecialOperation).Profile;
				if (profile != null)
				{
					global::Motorola.Common.Communication.DeviceDiscovery.TetraRadioProfile tetraRadioProfile = profile as global::Motorola.Common.Communication.DeviceDiscovery.TetraRadioProfile;
					if (tetraRadioProfile != null)
					{
						global::Motorola.Common.Communication.TetraUtility.NGCHDeviceComponent ngchdevicePart = tetraRadioProfile.NGCHDevicePart;
					}
				}
				break;
			}
			case global::Motorola.Common.Communication.CommonUtil.DeviceControlOperationType.LLPIsAvailable:
				if (!(base.SequenceManager as global::Motorola.Common.Communication.ITetraSeqMgrSpecialOperation).IsLLPAvailable())
				{
					outputParams.result = global::Motorola.Common.Communication.CommonUtil.DeviceControlResult.Failure;
					return;
				}
				break;
			default:
				return;
			}
		}

		// Token: 0x06000201 RID: 513 RVA: 0x0000B679 File Offset: 0x00009879
		public override void UpgradeFlashStrap(global::Motorola.Common.Communication.Pba.PbaObject pbaObject)
		{
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(base.SequenceManager, global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerSequenceManagerNotCreated);
			(base.SequenceManager as global::Motorola.Common.Communication.ITetraSeqMgrSpecialOperation).UpgradeFlashStrap(pbaObject, true);
		}

		// Token: 0x06000202 RID: 514 RVA: 0x0000B69D File Offset: 0x0000989D
		public override void EraseRadio(global::System.Collections.Generic.List<string> sections)
		{
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(base.SequenceManager, global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerSequenceManagerNotCreated);
			(base.SequenceManager as global::Motorola.Common.Communication.ITetraSeqMgrSpecialOperation).EraseRadio(sections);
		}

		// Token: 0x06000203 RID: 515 RVA: 0x0000B6C0 File Offset: 0x000098C0
		public override void EraseRadioFromTo(uint startAddress, uint size)
		{
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(base.SequenceManager, global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerSequenceManagerNotCreated);
			(base.SequenceManager as global::Motorola.Common.Communication.ITetraSeqMgrSpecialOperation).EraseRadioFromTo(startAddress, size, this._devInfo.ForceErase);
		}

		// Token: 0x06000204 RID: 516 RVA: 0x0000B6EF File Offset: 0x000098EF
		public override global::Motorola.Common.Communication.CommonUtil.MemoryImage ReadImageByAddress(uint startAddress, uint size)
		{
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(base.SequenceManager, global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerSequenceManagerNotCreated);
			return (base.SequenceManager as global::Motorola.Common.Communication.ITetraSeqMgrSpecialOperation).ReadImageWithProgressUpdate(global::System.Convert.ToString(startAddress), size);
		}

		// Token: 0x06000205 RID: 517 RVA: 0x0000B718 File Offset: 0x00009918
		public override void WriteImage(global::Motorola.Common.Communication.CommonUtil.MemoryImage image)
		{
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(base.SequenceManager, global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerSequenceManagerNotCreated);
			(base.SequenceManager as global::Motorola.Common.Communication.ITetraSeqMgrSpecialOperation).WriteImage(image, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.WriteImage, true);
		}

		// Token: 0x06000206 RID: 518 RVA: 0x0000B73E File Offset: 0x0000993E
		public override void SwitchRadioMode(global::Motorola.Common.Communication.CommonUtil.DeviceMode mode)
		{
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(base.SequenceManager, global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerSequenceManagerNotCreated);
			base.SequenceManager.SwitchRadioMode(mode);
		}

		// Token: 0x06000207 RID: 519 RVA: 0x0000B75C File Offset: 0x0000995C
		public override global::Motorola.Common.Communication.CommonUtil.FDTInfo GetFdtInfo(global::Motorola.Common.Communication.CommonUtil.FDTType fdtType)
		{
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(base.SequenceManager, global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerSequenceManagerNotCreated);
			return (base.SequenceManager as global::Motorola.Common.Communication.ITetraSeqMgrSpecialOperation).GetFdtInfo(fdtType);
		}

		// Token: 0x06000208 RID: 520 RVA: 0x0000B77F File Offset: 0x0000997F
		public override void WaitForCancelReading()
		{
			(base.SequenceManager as global::Motorola.Common.Communication.ITetraSeqMgrSpecialOperation).WaitForCancelReading();
		}

		// Token: 0x06000209 RID: 521 RVA: 0x0000B791 File Offset: 0x00009991
		public override void SynPrepareDevice()
		{
			if (this.IsKernelModeRadio)
			{
				this.PrepareKernelModeDevice();
				return;
			}
			this.PrepareNonkernelModeDevice();
		}

		// Token: 0x0600020A RID: 522 RVA: 0x0000B7A8 File Offset: 0x000099A8
		public void WriteSoftware(string swFilePath)
		{
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(base.SequenceManager, global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerSequenceManagerNotCreated);
			(base.SequenceManager as global::Motorola.Common.Communication.ITetraSeqMgrSpecialOperation).WriteSoftware(swFilePath, true);
		}

		// Token: 0x0600020B RID: 523 RVA: 0x0000B7CC File Offset: 0x000099CC
		public global::Motorola.Common.Communication.Pba.LanguagePackData ReadRadioFirmwareDefinedFlashPacks()
		{
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(base.SequenceManager, global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerSequenceManagerNotCreated);
			return (base.SequenceManager as global::Motorola.Common.Communication.ITetraSeqMgrSpecialOperation).ReadRadioFirmwareDefinedFlashPacks();
		}

		// Token: 0x0600020C RID: 524 RVA: 0x0000B7EE File Offset: 0x000099EE
		public byte[] ReadCPData(string blockID, uint offset, ushort size)
		{
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(base.SequenceManager, global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerSequenceManagerNotCreated);
			return (base.SequenceManager as global::Motorola.Common.Communication.ITetraSeqMgrSpecialOperation).ReadCPData(blockID, offset, size);
		}

		// Token: 0x0600020D RID: 525 RVA: 0x0000B814 File Offset: 0x00009A14
		public void GeneralOperation(global::Motorola.Common.Communication.Pba.PbaObject pbaObject)
		{
			byte[] generalOutputBuffer = null;
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(base.SequenceManager, global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerSequenceManagerNotCreated);
			(base.SequenceManager as global::Motorola.Common.Communication.ITetraSeqMgrSpecialOperation).GeneralOperation(pbaObject.GeneralCommandCode, pbaObject.GeneralInputBuffer, out generalOutputBuffer);
			pbaObject.GeneralOutputBuffer = generalOutputBuffer;
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x0600020E RID: 526 RVA: 0x0000B858 File Offset: 0x00009A58
		// (set) Token: 0x0600020F RID: 527 RVA: 0x0000B89C File Offset: 0x00009A9C
		public global::Motorola.Common.Communication.IRadioProfile Profile
		{
			get
			{
				global::Motorola.Common.Communication.IRadioProfile profile;
				lock (this._propertyAccessLock)
				{
					profile = this._profile;
				}
				return profile;
			}
			set
			{
				lock (this._propertyAccessLock)
				{
					this._profile = (value as global::Motorola.Common.Communication.DeviceDiscovery.TetraRadioProfile);
				}
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000210 RID: 528 RVA: 0x0000B8E4 File Offset: 0x00009AE4
		// (set) Token: 0x06000211 RID: 529 RVA: 0x0000B970 File Offset: 0x00009B70
		public string CpuID
		{
			get
			{
				string result;
				lock (this._propertyAccessLock)
				{
					string text = string.Empty;
					try
					{
						(this.DeviceInfo as global::Motorola.Common.Communication.CommonUtil.TetraDeviceInfo).CpuID = string.Empty;
						this.OpenSession(global::Motorola.Common.Communication.CommonUtil.RadioOperation.Read, null);
						text = (base.SequenceManager as global::Motorola.Common.Communication.ITetraSeqMgrSpecialOperation).CpuID;
					}
					finally
					{
						this.CloseSession(true);
					}
					result = text;
				}
				return result;
			}
			set
			{
				lock (this._propertyAccessLock)
				{
					try
					{
						this.OpenSession(global::Motorola.Common.Communication.CommonUtil.RadioOperation.Read, null);
						(base.SequenceManager as global::Motorola.Common.Communication.ITetraSeqMgrSpecialOperation).CpuID = value;
					}
					finally
					{
						this.CloseSession(true);
					}
				}
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000212 RID: 530 RVA: 0x0000B9DC File Offset: 0x00009BDC
		// (set) Token: 0x06000213 RID: 531 RVA: 0x0000BA20 File Offset: 0x00009C20
		public global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe CommPipe
		{
			get
			{
				global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe pipe;
				lock (this._propertyAccessLock)
				{
					pipe = this._pipe;
				}
				return pipe;
			}
			set
			{
				lock (this._propertyAccessLock)
				{
					this._pipe = value;
				}
			}
		}

		// Token: 0x06000214 RID: 532 RVA: 0x0000BA64 File Offset: 0x00009C64
		protected override void CreateSession(ushort sessionID, global::Motorola.Common.Communication.CommonUtil.RadioOperation operation, global::Motorola.Common.Communication.CommonUtil.SessionParameter sessionParameter)
		{
			global::Motorola.Common.Communication.ICpsSequenceManager cpsSequenceManager = global::Motorola.Common.Communication.CommunicationManager.SequenceManagerFactory.CreateSequenceManager(this.DeviceInfo, operation, this.CommPipe, sessionParameter);
			cpsSequenceManager.OpenSession(sessionID, operation);
			(cpsSequenceManager as global::Motorola.Common.Communication.ITetraSeqMgrSpecialOperation).Profile = this.Profile;
			base.ActiveSession = new global::Motorola.Common.Communication.CommunicationSession(sessionID, operation, this.CommPipe, cpsSequenceManager);
		}

		// Token: 0x06000215 RID: 533 RVA: 0x0000BAB4 File Offset: 0x00009CB4
		private void AsynPrepareDevice(object sender, global::System.ComponentModel.DoWorkEventArgs e)
		{
			if (this.radioState == global::Motorola.Common.Communication.CommonUtil.RadioState.InitializingDevice)
			{
				bool flag = false;
				try
				{
					this.OpenSession(global::Motorola.Common.Communication.CommonUtil.RadioOperation.Create, null);
					flag = true;
					(base.SequenceManager as global::Motorola.Common.Communication.ITetraSeqMgrSpecialOperation).Invalidate(false);
					if (this.DeviceInfo is global::Motorola.Common.Communication.CommonUtil.TetraDeviceInfo)
					{
						(this.DeviceInfo as global::Motorola.Common.Communication.CommonUtil.TetraDeviceInfo).DUP = null;
						(this.DeviceInfo as global::Motorola.Common.Communication.CommonUtil.TetraDeviceInfo).ARP = null;
					}
					this.InitDeviceParams();
					this.CloseSession(true);
					flag = false;
					base.ChangeRadioState(global::Motorola.Common.Communication.CommonUtil.RadioState.Ready);
				}
				finally
				{
					if (flag)
					{
						this.CloseSession(true);
					}
				}
			}
		}

		// Token: 0x06000216 RID: 534 RVA: 0x0000BB4C File Offset: 0x00009D4C
		private void PrepareRadioCompleted(object sender, global::System.ComponentModel.RunWorkerCompletedEventArgs e)
		{
			bool cancelled = e.Cancelled;
		}

		// Token: 0x06000217 RID: 535 RVA: 0x0000BB58 File Offset: 0x00009D58
		private void PrepareKernelModeDevice()
		{
			if (this.radioState == global::Motorola.Common.Communication.CommonUtil.RadioState.Attached)
			{
				bool flag = false;
				try
				{
					this.OpenSession(global::Motorola.Common.Communication.CommonUtil.RadioOperation.Create, null);
					flag = true;
					(base.SequenceManager as global::Motorola.Common.Communication.ITetraSeqMgrSpecialOperation).Invalidate(false);
					if (this.DeviceInfo is global::Motorola.Common.Communication.CommonUtil.TetraDeviceInfo)
					{
						(this.DeviceInfo as global::Motorola.Common.Communication.CommonUtil.TetraDeviceInfo).DUP = null;
						(this.DeviceInfo as global::Motorola.Common.Communication.CommonUtil.TetraDeviceInfo).ARP = null;
					}
					this.InitDeviceParams();
					this.CloseSession(true);
					flag = false;
					this.radioState = global::Motorola.Common.Communication.CommonUtil.RadioState.Ready;
				}
				finally
				{
					if (flag)
					{
						this.CloseSession(true);
					}
				}
			}
		}

		// Token: 0x06000218 RID: 536 RVA: 0x0000BBF0 File Offset: 0x00009DF0
		private void PrepareNonkernelModeDevice()
		{
			if (this.radioState == global::Motorola.Common.Communication.CommonUtil.RadioState.Attached)
			{
				try
				{
					this.OpenSession(global::Motorola.Common.Communication.CommonUtil.RadioOperation.Create, null);
					(base.SequenceManager as global::Motorola.Common.Communication.ITetraSeqMgrSpecialOperation).Invalidate(false);
					this.InitDeviceParams();
					if (this.DeviceInfo == null)
					{
						this.DeviceInfo = new global::Motorola.Common.Communication.CommonUtil.DeviceInfo();
					}
					this.radioState = global::Motorola.Common.Communication.CommonUtil.RadioState.Ready;
				}
				finally
				{
					this.CloseSession(true);
				}
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000219 RID: 537 RVA: 0x0000BC5C File Offset: 0x00009E5C
		private bool IsKernelModeRadio
		{
			get
			{
				return this.DeviceInfo.Family == global::Motorola.Common.Communication.CommonUtil.ProductFamily.FrodoProgRadio || this.DeviceInfo.Family == global::Motorola.Common.Communication.CommonUtil.ProductFamily.GemstoneBMPProgRadio || this.DeviceInfo.Family == global::Motorola.Common.Communication.CommonUtil.ProductFamily.LegacyProgRadio;
			}
		}

		// Token: 0x04000072 RID: 114
		private bool _active;

		// Token: 0x04000073 RID: 115
		private object _sessionLock = new object();

		// Token: 0x04000074 RID: 116
		private object _propertyAccessLock = new object();

		// Token: 0x04000075 RID: 117
		private global::Motorola.Common.Communication.CommonUtil.TetraDeviceInfo _devInfo = new global::Motorola.Common.Communication.CommonUtil.TetraDeviceInfo();

		// Token: 0x04000076 RID: 118
		private global::Motorola.Common.Communication.CommonUtil.TetraDeviceInfo _devInfoForForceWrite;

		// Token: 0x04000077 RID: 119
		private global::Motorola.Common.Communication.CommonUtil.RadioState _radioState;

		// Token: 0x04000078 RID: 120
		private global::Motorola.Common.Communication.DeviceDiscovery.TetraRadioProfile _profile;

		// Token: 0x04000079 RID: 121
		private global::Motorola.Common.Communication.TetraUtility.CultureSafeBackGroundWorker _prepareWorker;

		// Token: 0x0400007A RID: 122
		private global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe _pipe;
	}
}
