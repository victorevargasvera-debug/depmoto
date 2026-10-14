using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.Communication.DeviceDiscovery;
using Motorola.Common.Communication.IshHandler;
using Motorola.Common.Communication.Pba;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.CommunicationManager
{
	// Token: 0x02000007 RID: 7
	public class MotoDevice : global::Motorola.Common.Communication.IMotoDevice, global::Motorola.Common.Communication.CommonUtil.IObservable, global::System.IDisposable
	{
		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600000E RID: 14 RVA: 0x0000220E File Offset: 0x0000040E
		// (set) Token: 0x0600000F RID: 15 RVA: 0x00002216 File Offset: 0x00000416
		protected global::Motorola.Common.Communication.CommunicationSession ActiveSession { get; set; }

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000010 RID: 16 RVA: 0x0000221F File Offset: 0x0000041F
		// (set) Token: 0x06000011 RID: 17 RVA: 0x00002227 File Offset: 0x00000427
		public global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo ExtendedDeviceInfo { get; set; }

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000012 RID: 18 RVA: 0x00002230 File Offset: 0x00000430
		// (set) Token: 0x06000013 RID: 19 RVA: 0x00002238 File Offset: 0x00000438
		public virtual global::Motorola.Common.Communication.CommonUtil.DeviceInfo DeviceInfo
		{
			get
			{
				return this._basedevInfo;
			}
			set
			{
				this._basedevInfo = value;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000014 RID: 20 RVA: 0x00002241 File Offset: 0x00000441
		// (set) Token: 0x06000015 RID: 21 RVA: 0x00002249 File Offset: 0x00000449
		public bool DifferentialWriteCapableRadio { get; set; }

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000016 RID: 22 RVA: 0x00002252 File Offset: 0x00000452
		// (set) Token: 0x06000017 RID: 23 RVA: 0x0000225A File Offset: 0x0000045A
		public global::Motorola.Common.Communication.IshHandler.IOController IOController { get; set; }

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000018 RID: 24 RVA: 0x00002263 File Offset: 0x00000463
		// (set) Token: 0x06000019 RID: 25 RVA: 0x0000226B File Offset: 0x0000046B
		public virtual bool Active
		{
			get
			{
				return this.active;
			}
			set
			{
				this.active = value;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600001A RID: 26 RVA: 0x00002274 File Offset: 0x00000474
		public global::Motorola.Common.Communication.DeviceDiscovery.RNDISRadioProfile RadioProfile
		{
			get
			{
				return this._radioProfile;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600001C RID: 28 RVA: 0x00002285 File Offset: 0x00000485
		// (set) Token: 0x0600001B RID: 27 RVA: 0x0000227C File Offset: 0x0000047C
		public virtual global::Motorola.Common.Communication.CommonUtil.RadioState radioState
		{
			get
			{
				return this._radioState;
			}
			set
			{
				this.SetRadioState(value);
			}
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002290 File Offset: 0x00000490
		protected void SetRadioState(global::Motorola.Common.Communication.CommonUtil.RadioState newState)
		{
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("Wired Device State Changed from {0} to {1}.", new object[]
			{
				this._radioState.ToString(),
				newState.ToString()
			});
			if (this._radioState != global::Motorola.Common.Communication.CommonUtil.RadioState.Detached)
			{
				this._radioState = newState;
				if (this.DeviceInfo != null)
				{
					this.DeviceInfo.RadioState = this._radioState;
					return;
				}
			}
			else
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("Trying to reactivate a dead radio!", new object[0]);
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600001E RID: 30 RVA: 0x00002314 File Offset: 0x00000514
		protected global::Motorola.Common.Communication.ICpsSequenceManager SequenceManager
		{
			get
			{
				global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(this.ActiveSession, global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerSessionNotOpened);
				return this.ActiveSession.SequenceManager;
			}
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002334 File Offset: 0x00000534
		public MotoDevice(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.DeviceDiscovery.RNDISRadioProfile radioProfile)
		{
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(deviceInfo, global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerNullDeviceInfo);
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(deviceInfo.ConnectionInfo, global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerNullConnectionInfo);
			this._basedevInfo = deviceInfo;
			this.DifferentialWriteCapableRadio = false;
			this._radioState = global::Motorola.Common.Communication.CommonUtil.RadioState.Attached;
			this._radioProfile = radioProfile;
		}

		// Token: 0x06000020 RID: 32 RVA: 0x000023A7 File Offset: 0x000005A7
		public MotoDevice()
		{
		}

		// Token: 0x06000021 RID: 33 RVA: 0x000023D8 File Offset: 0x000005D8
		~MotoDevice()
		{
			this.Dispose(false);
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002408 File Offset: 0x00000608
		public virtual void InitDeviceParams()
		{
			this.ReadDeviceInfo();
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002411 File Offset: 0x00000611
		public virtual void InitDeviceExtendedDeviceParams()
		{
			this.ReadExtendedDeviceInfo();
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002424 File Offset: 0x00000624
		public virtual void Prefetch()
		{
			if (this.radioState == global::Motorola.Common.Communication.CommonUtil.RadioState.Attached)
			{
				this.ChangeRadioState(global::Motorola.Common.Communication.CommonUtil.RadioState.InitializingDevice);
				global::System.Threading.Tasks.Task.Run(delegate()
				{
					this.PrepareDevice();
				});
			}
		}

		// Token: 0x06000025 RID: 37 RVA: 0x0000245C File Offset: 0x0000065C
		private void PrepareDevice()
		{
			while (this.radioState == global::Motorola.Common.Communication.CommonUtil.RadioState.InitializingDevice)
			{
				try
				{
					if (this.RetrieveIPAddress(ref this._radioProfile))
					{
						this.ChangeRadioState(global::Motorola.Common.Communication.CommonUtil.RadioState.Connecting);
						break;
					}
					global::System.Threading.Thread.Sleep(500);
				}
				catch (global::System.Exception ex)
				{
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("RNDIS Device - Error in Retreive IP Address {0} .", new object[]
					{
						ex.Message
					});
					global::System.Threading.Thread.Sleep(1000);
				}
			}
			if (global::Motorola.Common.Communication.CommunicationManager.CommunicationManagerClass.Instance.DiscoveryWorkMode == global::Motorola.Common.Communication.CommonUtil.WorkMode.Active)
			{
				global::System.Threading.Thread.Sleep(1000);
			}
			bool flag = false;
			while (this.radioState == global::Motorola.Common.Communication.CommonUtil.RadioState.Connecting)
			{
				try
				{
					if (this.RetrieveIPAddress(ref this._radioProfile))
					{
						this.OpenSession(global::Motorola.Common.Communication.CommonUtil.RadioOperation.Create, null);
						this.InitDeviceParams();
						flag = true;
					}
				}
				catch (global::System.Exception ex2)
				{
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("RNDIS Device - Error in InitDeviceParams {0} .", new object[]
					{
						ex2.Message
					});
					global::System.Threading.Thread.Sleep(2000);
				}
				finally
				{
					try
					{
						this.CloseSession(true);
					}
					catch (global::System.Exception)
					{
					}
				}
				if (flag)
				{
					this.ChangeRadioState(global::Motorola.Common.Communication.CommonUtil.RadioState.Ready);
					return;
				}
				global::System.Threading.Thread.Sleep(500);
			}
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002594 File Offset: 0x00000794
		public void ChangeRadioState(global::Motorola.Common.Communication.CommonUtil.RadioState _radioState)
		{
			if (this.DeviceInfo == null)
			{
				this.DeviceInfo = new global::Motorola.Common.Communication.CommonUtil.DeviceInfo();
			}
			this.radioState = _radioState;
			if (this.radioState == global::Motorola.Common.Communication.CommonUtil.RadioState.Ready)
			{
				this._deviceReadyEvent.Set();
				this.NotifyObservers(this);
			}
		}

		// Token: 0x06000027 RID: 39 RVA: 0x000025CC File Offset: 0x000007CC
		protected virtual bool RetrieveIPAddress(ref global::Motorola.Common.Communication.DeviceDiscovery.RNDISRadioProfile _radioProfile)
		{
			if (global::Motorola.Common.Communication.DeviceDiscovery.RNDISDetector.RetreiveDeviceIPAddress(ref _radioProfile))
			{
				if (this.DeviceInfo.ConnectionInfo != null && this.DeviceInfo.ConnectionInfo.UniqueAddress != _radioProfile.IPAddress)
				{
					string text = string.Empty;
					if (this.DeviceInfo.ConnectionInfo.UniqueAddress != null)
					{
						text = this.DeviceInfo.ConnectionInfo.UniqueAddress;
					}
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("Get new IP Address {0}=>{1} on Device {2}.", new object[]
					{
						text,
						_radioProfile.IPAddress,
						_radioProfile.RadioIdString
					});
				}
				lock (global::Motorola.Common.Communication.CommunicationManager.MotoDevice.IPLock)
				{
					if (this.ValidateIPAddress(_radioProfile.IPAddress))
					{
						global::Motorola.Common.Communication.CommonUtil.ConnectionInfo connectionInfo = new global::Motorola.Common.Communication.CommonUtil.ConnectionInfo();
						connectionInfo.ConnectionType = global::Motorola.Common.Communication.CommonUtil.ConnectionType.NetAdapter;
						connectionInfo.UniqueAddress = _radioProfile.IPAddress;
						connectionInfo.DeviceInstance = _radioProfile.DeviceInstanceID;
						if (this.DeviceInfo.ConnectionInfo != null)
						{
							connectionInfo.SessionID = this.DeviceInfo.ConnectionInfo.SessionID;
						}
						this.DeviceInfo.ConnectionInfo = connectionInfo;
						return true;
					}
					return false;
				}
			}
			if (this.DeviceInfo.ConnectionInfo != null)
			{
				this.DeviceInfo.ConnectionInfo.UniqueAddress = "";
			}
			return false;
		}

		// Token: 0x06000028 RID: 40 RVA: 0x0000272C File Offset: 0x0000092C
		public bool WaitForReady(int timeout)
		{
			return this.radioState == global::Motorola.Common.Communication.CommonUtil.RadioState.Ready || this.radioState == global::Motorola.Common.Communication.CommonUtil.RadioState.Busy || (this.radioState != global::Motorola.Common.Communication.CommonUtil.RadioState.Removing && this.radioState != global::Motorola.Common.Communication.CommonUtil.RadioState.Detached && this._deviceReadyEvent.WaitOne(timeout));
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002762 File Offset: 0x00000962
		public void Register(global::Motorola.Common.Communication.CommonUtil.IObserver anObserver)
		{
			this._observerContainer.Add(anObserver);
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002770 File Offset: 0x00000970
		public void UnRegister(global::Motorola.Common.Communication.CommonUtil.IObserver anObserver)
		{
			this._observerContainer.Remove(anObserver);
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002780 File Offset: 0x00000980
		private void NotifyObservers(object anObject)
		{
			int num = this._observerContainer.Count - 1;
			for (int i = num; i >= 0; i--)
			{
				global::Motorola.Common.Communication.CommonUtil.IObserver observer = this._observerContainer[i];
				if (observer != null)
				{
					observer.Notify(anObject);
				}
			}
		}

		// Token: 0x0600002C RID: 44 RVA: 0x000027C0 File Offset: 0x000009C0
		private bool ValidateIPAddress(string IPAddr)
		{
			foreach (global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo in global::Motorola.Common.Communication.CommunicationManager.CommunicationManagerClass.Instance.DeviceInfoList)
			{
				if (deviceInfo.ConnectionInfo != null && deviceInfo.ConnectionInfo.UniqueAddress == IPAddr && deviceInfo.RadioID != this.DeviceInfo.RadioID)
				{
					global::Motorola.Common.Communication.CommunicationManager.MotoDevice motoDevice = global::Motorola.Common.Communication.CommunicationManager.CommunicationManagerClass.Instance.GetDevice(deviceInfo.RadioID) as global::Motorola.Common.Communication.CommunicationManager.MotoDevice;
					if (motoDevice != null)
					{
						global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteWarning("Found duplicated IP Address {0} on {1}, validation failed", new object[]
						{
							IPAddr,
							deviceInfo.RadioID
						});
						if (motoDevice.radioState == global::Motorola.Common.Communication.CommonUtil.RadioState.Ready || motoDevice.radioState == global::Motorola.Common.Communication.CommonUtil.RadioState.Busy)
						{
							global::Motorola.Common.Communication.DeviceDiscovery.RNDISRadioProfile rndisradioProfile = new global::Motorola.Common.Communication.DeviceDiscovery.RNDISRadioProfile();
							rndisradioProfile.NetCfgInstanceId = motoDevice.RadioProfile.NetCfgInstanceId;
							global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("Start refreshing IP address for {0} - {1}", new object[]
							{
								IPAddr,
								rndisradioProfile.NetCfgInstanceId
							});
							if (global::Motorola.Common.Communication.DeviceDiscovery.RNDISDetector.RetreiveDeviceIPAddress(ref rndisradioProfile) && IPAddr != rndisradioProfile.IPAddress)
							{
								global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteWarning("The device {0} points to the incorrect IP {1}, which should be {2}", new object[]
								{
									deviceInfo.RadioID,
									IPAddr,
									rndisradioProfile.IPAddress
								});
								global::Motorola.Common.Communication.CommunicationManager.CommunicationManagerClass.Instance.ReDetectDevice(deviceInfo.RadioID);
							}
						}
						global::System.Threading.Thread.Sleep(5000);
						return false;
					}
				}
			}
			return true;
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002964 File Offset: 0x00000B64
		internal void RefreshIPAddress()
		{
			if (!this.RetrieveIPAddress(ref this._radioProfile))
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteWarning("Retrieve IP Address failed after discovered the radio.", new object[0]);
			}
		}

		// Token: 0x0600002E RID: 46 RVA: 0x0000298C File Offset: 0x00000B8C
		public virtual ushort OpenSession(global::Motorola.Common.Communication.CommonUtil.RadioOperation operationType, global::Motorola.Common.Communication.CommonUtil.SessionParameter sessionParameter)
		{
			ushort num = 0;
			lock (this.SessionLock)
			{
				if (this.ActiveSession != null)
				{
					this.DisposeSession();
				}
				if (sessionParameter == null)
				{
					sessionParameter = new global::Motorola.Common.Communication.CommonUtil.SessionParameter(0, false);
				}
				num = ((this.DeviceInfo.ConnectionInfo.SessionID != 0 && this.DeviceInfo.ConnectionInfo.SessionID != sessionParameter.PreviousSessionID) ? this.DeviceInfo.ConnectionInfo.SessionID : global::Motorola.Common.Communication.CommunicationManager.SessionIdGenerator.Instance.GenerateNewUnqiueID(sessionParameter.PreviousSessionID));
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("OpenSession Current Session ID {0} Previous Session ID {1}.", new object[]
				{
					num,
					sessionParameter.PreviousSessionID
				});
				try
				{
					this.CreateSession(num, operationType, sessionParameter);
					this.WaitForRadio();
				}
				catch
				{
					if (this.DeviceInfo.ConnectionInfo.SessionID == 0)
					{
						global::Motorola.Common.Communication.CommunicationManager.SessionIdGenerator.Instance.ReturnID(num);
					}
					throw;
				}
			}
			return num;
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002A9C File Offset: 0x00000C9C
		public virtual void CloseSession(bool pendingDeploy)
		{
			this.ValidateSession();
			this.ClearSession(pendingDeploy);
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002AAC File Offset: 0x00000CAC
		protected virtual void CreateSession(ushort sessionID, global::Motorola.Common.Communication.CommonUtil.RadioOperation operation, global::Motorola.Common.Communication.CommonUtil.SessionParameter sessionParameter)
		{
			global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe communicationPipe = global::Motorola.Common.Communication.CommunicationManager.CommunicationPipeFactory.CreateCommunicationPipe(this.DeviceInfo, operation);
			try
			{
				communicationPipe.OpenPort(-1);
				global::Motorola.Common.Communication.ICpsSequenceManager cpsSequenceManager = global::Motorola.Common.Communication.CommunicationManager.SequenceManagerFactory.CreateSequenceManager(this.DeviceInfo, operation, communicationPipe, sessionParameter);
				cpsSequenceManager.OpenSession(sessionID, operation);
				this.ActiveSession = new global::Motorola.Common.Communication.CommunicationSession(sessionID, operation, communicationPipe, cpsSequenceManager);
				this.DeviceInfo.ConnectionInfo.SessionID = sessionID;
			}
			catch (global::System.Exception)
			{
				communicationPipe.ClosePort();
				throw;
			}
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002B20 File Offset: 0x00000D20
		protected void UpdateSession(global::Motorola.Common.Communication.CommonUtil.RadioOperation operation, global::Motorola.Common.Communication.CommonUtil.SessionParameter sessionParameter)
		{
			try
			{
				global::Motorola.Common.Communication.ICpsSequenceManager cpsSequenceManager = global::Motorola.Common.Communication.CommunicationManager.SequenceManagerFactory.CreateSequenceManager(this.DeviceInfo, operation, this.ActiveSession.CommunicationPipe, sessionParameter);
				if (this.DifferentialWriteCapableRadio)
				{
					cpsSequenceManager.DifferentialWriteCapableRadio = this.DifferentialWriteCapableRadio;
				}
				cpsSequenceManager.OpenSession(this.ActiveSession.ID, operation);
				this.ActiveSession.SequenceManager = cpsSequenceManager;
				this.ActiveSession.OperationType = operation;
			}
			catch (global::System.Exception)
			{
				this.ActiveSession.CommunicationPipe.ClosePort();
				throw;
			}
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002BAC File Offset: 0x00000DAC
		private void ClearSession(bool pendingDeploy)
		{
			this.DeviceInfo.ConnectionInfo.SessionID = 0;
			if (pendingDeploy || this.DeviceInfo.ConnectionInfo.ConnectionType != global::Motorola.Common.Communication.CommonUtil.ConnectionType.Otap || (this.DeviceInfo.Family != global::Motorola.Common.Communication.CommonUtil.ProductFamily.ParadiseRadio && this.DeviceInfo.Family != global::Motorola.Common.Communication.CommonUtil.ProductFamily.ParadiseLightRadio) || this.ActiveSession.OperationType != global::Motorola.Common.Communication.CommonUtil.RadioOperation.Program)
			{
				global::Motorola.Common.Communication.CommunicationManager.SessionIdGenerator.Instance.ReturnID(this.ActiveSession.ID);
			}
			try
			{
				try
				{
					this.SequenceManager.CloseSession(this.ActiveSession.ID, this.ActiveSession.OperationType, pendingDeploy);
				}
				finally
				{
					this.ActiveSession.CommunicationPipe.ClosePort();
				}
			}
			finally
			{
				this.ActiveSession = null;
			}
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002C80 File Offset: 0x00000E80
		protected void DisposeSession()
		{
			if (this.ActiveSession != null)
			{
				global::Motorola.Common.Communication.CommunicationManager.SessionIdGenerator.Instance.ReturnID(this.ActiveSession.ID);
				try
				{
					this.ActiveSession.CommunicationPipe.ClosePort();
				}
				finally
				{
					this.ActiveSession = null;
				}
			}
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00002CD4 File Offset: 0x00000ED4
		public virtual void Init(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.CommonUtil.RadioOperation operation, global::Motorola.Common.Communication.IProgressIndicator progressIndicator)
		{
			this.DeviceInfo.ConnectionInfo.SessionID = deviceInfo.ConnectionInfo.SessionID;
			this.ValidateSession();
			this.ActiveSession.SequenceManager.ProgressIndicator = progressIndicator;
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00002D08 File Offset: 0x00000F08
		protected void ValidateSession()
		{
			if (this.ActiveSession != null)
			{
				global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(this.ActiveSession, global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerSessionNotOpened);
				global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsFalse(this.ActiveSession.ID == this.DeviceInfo.ConnectionInfo.SessionID, global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerSessionNotMatched);
			}
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002D54 File Offset: 0x00000F54
		public virtual void DeviceControl(global::Motorola.Common.Communication.CommonUtil.DeviceControlInputParams inputParams, ref global::Motorola.Common.Communication.CommonUtil.DeviceControlOutputParams outputParams)
		{
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002D56 File Offset: 0x00000F56
		public virtual bool UpdateProgrammingStatus(global::Motorola.Common.Communication.CommonUtil.ProgrammingStatus status, ushort sessionID)
		{
			return this.SequenceManager.UpdateProgrammingStatus(status, sessionID);
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00002D68 File Offset: 0x00000F68
		public virtual global::Motorola.Common.Communication.CommonUtil.DeviceInfo ReadDeviceInfo()
		{
			global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo = this.SequenceManager.ReadDeviceInfo();
			if (string.IsNullOrEmpty(deviceInfo.RadioID))
			{
				deviceInfo.RadioID = this.DeviceInfo.RadioID;
			}
			deviceInfo.ConnectionInfo = this.DeviceInfo.ConnectionInfo;
			deviceInfo.RadioState = global::Motorola.Common.Communication.CommonUtil.RadioState.Ready;
			this.DeviceInfo = deviceInfo;
			return this.DeviceInfo;
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00002DC4 File Offset: 0x00000FC4
		public virtual global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo ReadExtendedDeviceInfo()
		{
			global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo extendedDeviceInfo = this.SequenceManager.ReadExtendedDeviceInfo();
			if (string.IsNullOrEmpty(extendedDeviceInfo.RadioID))
			{
				extendedDeviceInfo.RadioID = this.DeviceInfo.RadioID;
			}
			if (this.DifferentialWriteCapableRadio)
			{
				this.DeviceInfo.RadioStorage = extendedDeviceInfo.RadioStorage;
				this.ExtendedDeviceInfo = extendedDeviceInfo;
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

		// Token: 0x0600003A RID: 58 RVA: 0x00002EC7 File Offset: 0x000010C7
		public global::Motorola.Common.Communication.Pba.PbaObject ReadDevice(global::Motorola.Common.Communication.Pba.PbaObject referencePba)
		{
			return this.SequenceManager.ReadDevice(referencePba, this.ActiveSession.ID);
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002EE0 File Offset: 0x000010E0
		public byte QueryRadioUpdateStatus()
		{
			return this.SequenceManager.QueryRadioUpdateStatus();
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002EED File Offset: 0x000010ED
		public global::Motorola.Common.Communication.Pba.PbaObject ReadBlocks<T>(global::System.Collections.Generic.ICollection<T> blockList)
		{
			return this.SequenceManager.ReadBlocks<T>(blockList);
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00002EFB File Offset: 0x000010FB
		public global::Motorola.Common.Communication.Pba.PbaObject WriteDevice(global::Motorola.Common.Communication.Pba.PbaObject writePBA, string pcrNewPassword)
		{
			if (this.DifferentialWriteCapableRadio)
			{
				this.SequenceManager.ExtendedDeviceInfo = this.ExtendedDeviceInfo;
			}
			return this.SequenceManager.WriteDevice(writePBA, this.ActiveSession.ID, pcrNewPassword);
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002F2E File Offset: 0x0000112E
		public void ForceWriteDevice(global::Motorola.Common.Communication.Pba.PbaObject writePBA)
		{
			((global::Motorola.Common.Communication.IDepotSequenceManager)this.SequenceManager).ForceWriteDevice(writePBA, this.ActiveSession.ID);
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00002F4C File Offset: 0x0000114C
		public void UpdateSerialNumber(string serialNumber)
		{
			((global::Motorola.Common.Communication.IDepotSequenceManager)this.SequenceManager).UpdateSerialNumber(serialNumber);
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00002F5F File Offset: 0x0000115F
		public void UnkillRadio(byte[] authenticationValue)
		{
			((global::Motorola.Common.Communication.IDepotSequenceManager)this.SequenceManager).UnkillRadio(authenticationValue);
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00002F72 File Offset: 0x00001172
		public byte[] ReadUnkillChallengeValue()
		{
			return ((global::Motorola.Common.Communication.IDepotSequenceManager)this.SequenceManager).ReadUnkillChallengeValue();
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00002F84 File Offset: 0x00001184
		public void UpdateMACAddress(byte[] macAddress)
		{
			this.SequenceManager.UpdateMACAddress(macAddress);
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00002F92 File Offset: 0x00001192
		public void SendUpdateIMEType(byte ime)
		{
			((global::Motorola.Common.Communication.IDepotSequenceManager)this.SequenceManager).UpdateIMEType(ime);
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00002FA5 File Offset: 0x000011A5
		public void SendUpdateDateCode(byte[] datecode, ushort source)
		{
			((global::Motorola.Common.Communication.IDepotSequenceManager)this.SequenceManager).UpdateDateCode(datecode, source);
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00002FB9 File Offset: 0x000011B9
		public void CBIProgramme()
		{
			((global::Motorola.Common.Communication.IDepotSequenceManager)this.SequenceManager).CBIProgramme();
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00002FCC File Offset: 0x000011CC
		public virtual void SwitchRadioMode(global::Motorola.Common.Communication.CommonUtil.DeviceMode mode)
		{
			if (mode == global::Motorola.Common.Communication.CommonUtil.DeviceMode.FLASHSTRAP)
			{
				this.SequenceManager.SwitchRadioMode(mode);
				return;
			}
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.NotImplemented);
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00002FF2 File Offset: 0x000011F2
		public virtual void UpdateRadioDisplay()
		{
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(this.SequenceManager, global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerSequenceManagerNotCreated);
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00003004 File Offset: 0x00001204
		public global::Motorola.Common.Communication.Pba.LanguagePackData ReadLanguagePacksInfo()
		{
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(this.SequenceManager, global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerSequenceManagerNotCreated);
			return this.SequenceManager.ReadLanguagePacksInfo();
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00003021 File Offset: 0x00001221
		public void WriteLanguagePacks(global::Motorola.Common.Communication.Pba.LanguagePackData languagePackData)
		{
			this.SequenceManager.WriteLanguagePacks(languagePackData);
		}

		// Token: 0x0600004A RID: 74 RVA: 0x0000302F File Offset: 0x0000122F
		public void DeleteLanguagePacks(global::Motorola.Common.Communication.Pba.LanguagePackData languagePackData)
		{
			this.SequenceManager.DeleteLanguagePacks(languagePackData);
		}

		// Token: 0x0600004B RID: 75 RVA: 0x0000303D File Offset: 0x0000123D
		public global::Motorola.Common.Communication.Pba.LanguagePackData ReadTTSLanguagePacksInfo()
		{
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(this.SequenceManager, global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerSequenceManagerNotCreated);
			return this.SequenceManager.ReadTTSLanguagePacksInfo();
		}

		// Token: 0x0600004C RID: 76 RVA: 0x0000305A File Offset: 0x0000125A
		public void WriteTTSLanguagePacks(global::Motorola.Common.Communication.Pba.LanguagePackData languagePackData)
		{
			this.SequenceManager.WriteTTSLanguagePacks(languagePackData);
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00003068 File Offset: 0x00001268
		public void DeleteTTSLanguagePacks(global::Motorola.Common.Communication.Pba.LanguagePackData languagePackData)
		{
			this.SequenceManager.DeleteTTSLanguagePacks(languagePackData);
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00003078 File Offset: 0x00001278
		public global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileItem> ReadFilesListInDir(global::Motorola.Common.Communication.Pba.FileItem dir)
		{
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(this.SequenceManager, global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerSequenceManagerNotCreated);
			global::Motorola.Common.Communication.ICpsFileSequenceManager cpsFileSequenceManager = this.SequenceManager as global::Motorola.Common.Communication.ICpsFileSequenceManager;
			if (cpsFileSequenceManager != null)
			{
				return cpsFileSequenceManager.ReadFilesListInDir(dir);
			}
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerNotSupportForDevice);
		}

		// Token: 0x0600004F RID: 79 RVA: 0x000030B8 File Offset: 0x000012B8
		public global::Motorola.Common.Communication.Pba.FileItem ReadFile(global::Motorola.Common.Communication.Pba.FileItem file)
		{
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(this.SequenceManager, global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerSequenceManagerNotCreated);
			global::Motorola.Common.Communication.ICpsFileSequenceManager cpsFileSequenceManager = this.SequenceManager as global::Motorola.Common.Communication.ICpsFileSequenceManager;
			if (cpsFileSequenceManager != null)
			{
				return cpsFileSequenceManager.ReadFile(file);
			}
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerNotSupportForDevice);
		}

		// Token: 0x06000050 RID: 80 RVA: 0x000030F8 File Offset: 0x000012F8
		public void WriteFile(global::Motorola.Common.Communication.Pba.FileItem file)
		{
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(this.SequenceManager, global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerSequenceManagerNotCreated);
			global::Motorola.Common.Communication.ICpsFileSequenceManager cpsFileSequenceManager = this.SequenceManager as global::Motorola.Common.Communication.ICpsFileSequenceManager;
			if (cpsFileSequenceManager != null)
			{
				cpsFileSequenceManager.WriteFile(file, null);
				return;
			}
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerNotSupportForDevice);
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00003138 File Offset: 0x00001338
		public void DeleteFile(global::Motorola.Common.Communication.Pba.FileItem file)
		{
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(this.SequenceManager, global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerSequenceManagerNotCreated);
			global::Motorola.Common.Communication.ICpsFileSequenceManager cpsFileSequenceManager = this.SequenceManager as global::Motorola.Common.Communication.ICpsFileSequenceManager;
			if (cpsFileSequenceManager != null)
			{
				cpsFileSequenceManager.DeleteFile(file);
				return;
			}
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerNotSupportForDevice);
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00003178 File Offset: 0x00001378
		public long GetFileOrDirSize(global::Motorola.Common.Communication.Pba.FileItem fileOrDir)
		{
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(this.SequenceManager, global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerSequenceManagerNotCreated);
			global::Motorola.Common.Communication.ICpsFileSequenceManager cpsFileSequenceManager = this.SequenceManager as global::Motorola.Common.Communication.ICpsFileSequenceManager;
			if (cpsFileSequenceManager != null)
			{
				return cpsFileSequenceManager.GetFileOrDirSize(fileOrDir);
			}
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerNotSupportForDevice);
		}

		// Token: 0x06000053 RID: 83 RVA: 0x000031B6 File Offset: 0x000013B6
		private void WaitForRadio()
		{
			if (this.DeviceInfo.Family == global::Motorola.Common.Communication.CommonUtil.ProductFamily.AstroRadio)
			{
				global::System.Threading.Thread.Sleep(5);
			}
		}

		// Token: 0x06000054 RID: 84 RVA: 0x000031CC File Offset: 0x000013CC
		public virtual void UpgradeFlashStrap(global::Motorola.Common.Communication.Pba.PbaObject pbaObject)
		{
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(this.SequenceManager, global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerSequenceManagerNotCreated);
		}

		// Token: 0x06000055 RID: 85 RVA: 0x000031DE File Offset: 0x000013DE
		public virtual void EraseRadio(global::System.Collections.Generic.List<string> sections)
		{
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(this.SequenceManager, global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerSequenceManagerNotCreated);
		}

		// Token: 0x06000056 RID: 86 RVA: 0x000031F0 File Offset: 0x000013F0
		public virtual void EraseRadioFromTo(uint startAddress, uint size)
		{
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(this.SequenceManager, global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerSequenceManagerNotCreated);
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00003202 File Offset: 0x00001402
		public virtual void UpgradeFDT(string destModel, string destCPVersion, string serialNumber)
		{
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(this.SequenceManager, global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerSequenceManagerNotCreated);
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00003214 File Offset: 0x00001414
		public virtual void WriteImage(global::Motorola.Common.Communication.CommonUtil.MemoryImage image)
		{
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(this.SequenceManager, global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerSequenceManagerNotCreated);
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00003226 File Offset: 0x00001426
		public void UpdateDevice(global::Motorola.Common.Communication.Pba.PbaObject updatePBA)
		{
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(this.SequenceManager, global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerSequenceManagerNotCreated);
			((global::Motorola.Common.Communication.IFlashSequenceManager)this.SequenceManager).UpdateDevice(updatePBA, this.ActiveSession.ID);
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00003254 File Offset: 0x00001454
		private void ValidateUpdate()
		{
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(this.SequenceManager, global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerSequenceManagerNotCreated);
			((global::Motorola.Common.Communication.IFlashSequenceManager)this.SequenceManager).ValidateUpdate();
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00003276 File Offset: 0x00001476
		public bool WriteRamdownloader(string filePath)
		{
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(this.SequenceManager, global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerSequenceManagerNotCreated);
			return ((global::Motorola.Common.Communication.IFlashSequenceManager)this.SequenceManager).WriteRamdownloader(filePath);
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00003299 File Offset: 0x00001499
		public global::Motorola.Common.Communication.Pba.UpdateDeviceData ReadImage(global::Motorola.Common.Communication.Pba.UpdateDeviceData updateData)
		{
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(this.SequenceManager, global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerSequenceManagerNotCreated);
			return ((global::Motorola.Common.Communication.IFlashSequenceManager)this.SequenceManager).ReadImage(updateData);
		}

		// Token: 0x0600005D RID: 93 RVA: 0x000032BC File Offset: 0x000014BC
		public virtual global::Motorola.Common.Communication.CommonUtil.MemoryImage ReadImageByAddress(uint startAddress, uint size)
		{
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(this.SequenceManager, global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerSequenceManagerNotCreated);
			return null;
		}

		// Token: 0x0600005E RID: 94 RVA: 0x000032CF File Offset: 0x000014CF
		public void EnableFeature(string fwVersion, string serialNumber, string xmlHashInput, global::System.Collections.Generic.List<byte[]> featureCodeIDs)
		{
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(this.SequenceManager, global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerSequenceManagerNotCreated);
			this.SequenceManager.EnableFeature(fwVersion, serialNumber, xmlHashInput, featureCodeIDs);
		}

		// Token: 0x0600005F RID: 95 RVA: 0x000032F1 File Offset: 0x000014F1
		public string ReadHashInputAndValidate(global::Motorola.Common.Communication.Pba.PbaObject validatePba, global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DataBlockItem> blockList)
		{
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(this.SequenceManager, global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerSequenceManagerNotCreated);
			return this.SequenceManager.ReadHashInputAndValidate(validatePba, blockList);
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00003310 File Offset: 0x00001510
		public virtual void SendFPGAErase(global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType fileType)
		{
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(this.SequenceManager, global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerSequenceManagerNotCreated);
			this.SequenceManager.SendFPGAErase(fileType);
		}

		// Token: 0x06000061 RID: 97 RVA: 0x0000332E File Offset: 0x0000152E
		public virtual void SendFPGAReset(global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType fileType)
		{
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(this.SequenceManager, global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerSequenceManagerNotCreated);
			this.SequenceManager.SendFPGAReset(fileType);
		}

		// Token: 0x06000062 RID: 98 RVA: 0x0000334C File Offset: 0x0000154C
		public virtual global::Motorola.Common.Communication.CommonUtil.PasswordStatus ValidateLocalPassword(string password)
		{
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(this.SequenceManager, global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerSequenceManagerNotCreated);
			return this.SequenceManager.ValidateLocalPassword(password);
		}

		// Token: 0x06000063 RID: 99 RVA: 0x0000336A File Offset: 0x0000156A
		public virtual global::Motorola.Common.Communication.CommonUtil.FDTInfo GetFdtInfo(global::Motorola.Common.Communication.CommonUtil.FDTType fdtType)
		{
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(this.SequenceManager, global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerSequenceManagerNotCreated);
			return null;
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00003380 File Offset: 0x00001580
		public void FreeDeviceStatuse(bool closeConnectWithError)
		{
			if (closeConnectWithError && this.ActiveSession != null)
			{
				this.DeviceInfo.ConnectionInfo.SessionID = 0;
				global::Motorola.Common.Communication.CommunicationManager.SessionIdGenerator.Instance.ReturnID(this.ActiveSession.ID);
				try
				{
					this.ActiveSession.CommunicationPipe.ClosePort();
				}
				finally
				{
					this.ActiveSession = null;
				}
			}
		}

		// Token: 0x06000065 RID: 101 RVA: 0x000033E8 File Offset: 0x000015E8
		public virtual void WaitForCancelReading()
		{
		}

		// Token: 0x06000066 RID: 102 RVA: 0x000033EA File Offset: 0x000015EA
		public virtual void SynPrepareDevice()
		{
		}

		// Token: 0x06000067 RID: 103 RVA: 0x000033EC File Offset: 0x000015EC
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x06000068 RID: 104 RVA: 0x000033FB File Offset: 0x000015FB
		private void Dispose(bool disposing)
		{
			if (!this.disposed)
			{
				if (disposing)
				{
					this.CloseSession(true);
				}
				if (this._deviceReadyEvent != null)
				{
					this._deviceReadyEvent.Dispose();
				}
				this.disposed = true;
			}
		}

		// Token: 0x04000001 RID: 1
		private object SessionLock = new object();

		// Token: 0x04000002 RID: 2
		private bool disposed;

		// Token: 0x04000003 RID: 3
		private bool active = true;

		// Token: 0x04000004 RID: 4
		private static object IPLock = new object();

		// Token: 0x04000005 RID: 5
		protected global::Motorola.Common.Communication.DeviceDiscovery.RNDISRadioProfile _radioProfile;

		// Token: 0x04000006 RID: 6
		private global::Motorola.Common.Communication.CommonUtil.RadioState _radioState;

		// Token: 0x04000007 RID: 7
		private global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IObserver> _observerContainer = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IObserver>();

		// Token: 0x04000008 RID: 8
		private global::System.Threading.ManualResetEvent _deviceReadyEvent = new global::System.Threading.ManualResetEvent(false);

		// Token: 0x04000009 RID: 9
		private global::Motorola.Common.Communication.CommonUtil.DeviceInfo _basedevInfo;
	}
}
