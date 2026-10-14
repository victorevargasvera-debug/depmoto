using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.ServiceModel;
using System.Threading.Tasks;
using Common.Communication.Simulator;
using IACustomException;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommunicationManager;
using Motorola.Common.Communication.PCRRemoteProgramming;
using Motorola.Common.CustomException;
using SSLMangrComp;

namespace Motorola.Common.Communication.Service
{
	// Token: 0x02000009 RID: 9
	[global::System.ServiceModel.ServiceBehavior(ConcurrencyMode = global::System.ServiceModel.ConcurrencyMode.Multiple, InstanceContextMode = global::System.ServiceModel.InstanceContextMode.PerSession)]
	public class DeviceDiscovery : global::Motorola.Common.Communication.Service.IDeviceDiscovery, global::System.IDisposable
	{
		// Token: 0x060001D7 RID: 471 RVA: 0x0000623C File Offset: 0x0000443C
		public DeviceDiscovery()
		{
			global::Motorola.Common.Communication.CommunicationManager.CommunicationManagerClass instance = global::Motorola.Common.Communication.CommunicationManager.CommunicationManagerClass.Instance;
			instance.DeviceConnectedEventHandler = (global::System.EventHandler<global::Motorola.Common.Communication.CommonUtil.DeviceEventArgs>)global::System.Delegate.Combine(instance.DeviceConnectedEventHandler, new global::System.EventHandler<global::Motorola.Common.Communication.CommonUtil.DeviceEventArgs>(this.DeviceConnected));
			global::Motorola.Common.Communication.CommunicationManager.CommunicationManagerClass instance2 = global::Motorola.Common.Communication.CommunicationManager.CommunicationManagerClass.Instance;
			instance2.DeviceLostEventHandler = (global::System.EventHandler<global::Motorola.Common.Communication.CommonUtil.DeviceEventArgs>)global::System.Delegate.Combine(instance2.DeviceLostEventHandler, new global::System.EventHandler<global::Motorola.Common.Communication.CommonUtil.DeviceEventArgs>(this.DeviceLost));
			this.discoveryServiceEvent = global::System.ServiceModel.OperationContext.Current.GetCallbackChannel<global::Motorola.Common.Communication.Service.IDiscoveryServiceEvent>();
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("New Client of DeviceDiscovery arrived!", new object[0]);
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x000062D8 File Offset: 0x000044D8
		public DeviceDiscovery(int deviceFamilySet, global::Motorola.Common.Communication.CommonUtil.WorkMode workMode, global::Motorola.Common.Communication.Service.IDiscoveryServiceEvent discoveryServiceEventCallback)
		{
			if (discoveryServiceEventCallback != null)
			{
				global::Motorola.Common.Communication.CommunicationManager.CommunicationManagerClass instance = global::Motorola.Common.Communication.CommunicationManager.CommunicationManagerClass.Instance;
				instance.DeviceConnectedEventHandler = (global::System.EventHandler<global::Motorola.Common.Communication.CommonUtil.DeviceEventArgs>)global::System.Delegate.Combine(instance.DeviceConnectedEventHandler, new global::System.EventHandler<global::Motorola.Common.Communication.CommonUtil.DeviceEventArgs>(this.DeviceConnected));
				global::Motorola.Common.Communication.CommunicationManager.CommunicationManagerClass instance2 = global::Motorola.Common.Communication.CommunicationManager.CommunicationManagerClass.Instance;
				instance2.DeviceLostEventHandler = (global::System.EventHandler<global::Motorola.Common.Communication.CommonUtil.DeviceEventArgs>)global::System.Delegate.Combine(instance2.DeviceLostEventHandler, new global::System.EventHandler<global::Motorola.Common.Communication.CommonUtil.DeviceEventArgs>(this.DeviceLost));
				this.discoveryServiceEvent = discoveryServiceEventCallback;
			}
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("New Device Discovery Service Created.", new object[0]);
			this._deviceFamilySet = deviceFamilySet;
			this._workMode = workMode;
			if (deviceFamilySet > 0)
			{
				global::Motorola.Common.Communication.CommunicationManager.CommunicationManagerClass.Instance.Start(deviceFamilySet, workMode);
			}
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x0000638C File Offset: 0x0000458C
		public global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DeviceInfo> ListConnectedDevices(int deviceConnectionType)
		{
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DeviceInfo> devList = global::Motorola.Common.Communication.CommunicationManager.CommunicationManagerClass.Instance.ListConnectedDevices(this._deviceFamilySet, deviceConnectionType);
			return this.CopyDeviceInfo(devList);
		}

		// Token: 0x060001DA RID: 474 RVA: 0x000063B4 File Offset: 0x000045B4
		public global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DeviceInfo> CheckForDevice(int deviceConnectionType, string identifier)
		{
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DeviceInfo> devList = global::Motorola.Common.Communication.CommunicationManager.CommunicationManagerClass.Instance.CheckForDevice(this._deviceFamilySet, deviceConnectionType, identifier);
			return this.CopyDeviceInfo(devList);
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x060001DB RID: 475 RVA: 0x000063DB File Offset: 0x000045DB
		// (set) Token: 0x060001DC RID: 476 RVA: 0x000063E3 File Offset: 0x000045E3
		public global::System.EventHandler<global::Motorola.Common.Communication.CommonUtil.DeviceEventArgs> DeviceConnectedEventHandler { get; set; }

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x060001DD RID: 477 RVA: 0x000063EC File Offset: 0x000045EC
		// (set) Token: 0x060001DE RID: 478 RVA: 0x000063F4 File Offset: 0x000045F4
		public global::System.EventHandler<global::Motorola.Common.Communication.CommonUtil.DeviceEventArgs> DeviceLostEventHandler { get; set; }

		// Token: 0x060001DF RID: 479 RVA: 0x00006400 File Offset: 0x00004600
		private void PNNotificationReceived(global::SSLMangrComp.PresenceNotification DeviceId)
		{
			try
			{
				string deviceId = DeviceId.DeviceId;
				string subscriptionState = DeviceId.SubscriptionState;
				global::SSLMangrComp.PresenceState presenceState = DeviceId.PresenceState;
				global::System.Console.WriteLine(string.Concat(new string[]
				{
					"notification received: Device: ",
					deviceId,
					" subscription: ",
					subscriptionState,
					" Presence: ",
					presenceState.ToString()
				}));
				if (presenceState == global::SSLMangrComp.PresenceState.Present || presenceState == global::SSLMangrComp.PresenceState.Absent)
				{
					lock (this._connLock)
					{
						if (this.discoveryServiceEvent != null)
						{
							global::Motorola.Common.Communication.CommonUtil.DeviceEventArgs args = new global::Motorola.Common.Communication.CommonUtil.DeviceEventArgs(new global::Motorola.Common.Communication.CommonUtil.DeviceInfo
							{
								ConnectionInfo = new global::Motorola.Common.Communication.CommonUtil.ConnectionInfo(),
								ConnectionInfo = 
								{
									ConnectionType = global::Motorola.Common.Communication.CommonUtil.ConnectionType.Otap,
									UniqueAddress = DeviceId.IPAddr
								},
								RadioID = DeviceId.DeviceId
							});
							if (presenceState == global::SSLMangrComp.PresenceState.Present)
							{
								this.discoveryServiceEvent.OnDeviceConnected(args);
							}
							else
							{
								this.discoveryServiceEvent.OnDeviceLost(args);
							}
						}
					}
				}
			}
			catch (global::Motorola.Common.CustomException.CommonException exception)
			{
				global::Motorola.Common.Communication.Service.DeviceDiscovery.ThrowFaultException(exception);
			}
			catch (global::IACustomException.IACommonException exception2)
			{
				global::Motorola.Common.Communication.Service.DeviceDiscovery.ThrowIAException(exception2);
			}
			catch (global::System.Exception systemException)
			{
				global::Motorola.Common.Communication.Service.DeviceDiscovery.ThrowFaultException(new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.GenericError, systemException));
			}
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x00006560 File Offset: 0x00004760
		public void DeregisterForPresence(global::System.Collections.Generic.List<string> deviceIDs, global::SSLMangrComp.PNConnectionInfo connInfo)
		{
			try
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("DeregisterForPresence...<{0}:{1}>...Start", new object[]
				{
					connInfo.PNConnectionConfig.PnIp,
					connInfo.PNConnectionConfig.PnPort
				});
				lock (this._connLock)
				{
					global::Motorola.Common.Communication.CommunicationManager.CommunicationManagerClass.Instance.PNManager.ServerInfo = connInfo;
					global::Motorola.Common.Communication.CommunicationManager.CommunicationManagerClass.Instance.PNManager.DeregisterAsWatcher(deviceIDs);
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("DeregisterForPresence...<{0}:{1}>...Done", new object[]
					{
						connInfo.PNConnectionConfig.PnIp,
						connInfo.PNConnectionConfig.PnPort
					});
				}
			}
			catch (global::Motorola.Common.CustomException.CommonException exception)
			{
				global::Motorola.Common.Communication.Service.DeviceDiscovery.ThrowFaultException(exception);
			}
			catch (global::System.Exception systemException)
			{
				global::Motorola.Common.Communication.Service.DeviceDiscovery.ThrowFaultException(new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.GenericError, systemException));
			}
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x00006664 File Offset: 0x00004864
		public void RegisterForPresence(global::System.Collections.Generic.List<string> deviceIDs, global::SSLMangrComp.PNConnectionInfo connInfo)
		{
			try
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("RegisterForPresence...<{0}:{1}>...Start", new object[]
				{
					connInfo.PNConnectionConfig.PnIp,
					connInfo.PNConnectionConfig.PnPort
				});
				lock (this._connLock)
				{
					global::Motorola.Common.Communication.CommunicationManager.CommunicationManagerClass.Instance.PNManager.RadioFound -= this.PNNotificationReceived;
					global::Motorola.Common.Communication.CommunicationManager.CommunicationManagerClass.Instance.PNManager.RadioFound += this.PNNotificationReceived;
					connInfo.PNConnectionConfig.Expiration = 2144448000;
					global::Motorola.Common.Communication.CommunicationManager.CommunicationManagerClass.Instance.PNManager.ServerInfo = connInfo;
					global::Motorola.Common.Communication.CommunicationManager.CommunicationManagerClass.Instance.PNManager.RegisterAsWatcher(deviceIDs);
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("RegisterForPresence...<{0}:{1}>...Done", new object[]
					{
						connInfo.PNConnectionConfig.PnIp,
						connInfo.PNConnectionConfig.PnPort
					});
				}
			}
			catch (global::Motorola.Common.CustomException.CommonException exception)
			{
				global::Motorola.Common.Communication.Service.DeviceDiscovery.ThrowFaultException(exception);
			}
			catch (global::IACustomException.IACommonException exception2)
			{
				global::Motorola.Common.Communication.Service.DeviceDiscovery.ThrowIAException(exception2);
			}
			catch (global::System.Exception systemException)
			{
				global::Motorola.Common.Communication.Service.DeviceDiscovery.ThrowFaultException(new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.GenericError, systemException));
			}
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x000067C8 File Offset: 0x000049C8
		public void ClosePN()
		{
			try
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("Closing PN......", new object[0]);
				lock (this._connLock)
				{
					global::Motorola.Common.Communication.CommunicationManager.CommunicationManagerClass.Instance.PNManager.closePN();
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("Closd PN.", new object[0]);
				}
			}
			catch (global::Motorola.Common.CustomException.CommonException exception)
			{
				global::Motorola.Common.Communication.Service.DeviceDiscovery.ThrowFaultException(exception);
			}
			catch (global::System.Exception systemException)
			{
				global::Motorola.Common.Communication.Service.DeviceDiscovery.ThrowFaultException(new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.GenericError, systemException));
			}
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x00006870 File Offset: 0x00004A70
		public global::SSLMangrComp.PresenceNotification RetrievePresenceInfo(global::SSLMangrComp.PNConnectionInfo connInfo)
		{
			global::SSLMangrComp.ConnectionManager connectionManager = null;
			global::SSLMangrComp.PresenceNotification result = new global::SSLMangrComp.PresenceNotification();
			try
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("RetrievePresenceInfo...<{0}:{1}>...Start", new object[]
				{
					connInfo.PNConnectionConfig.PnIp,
					connInfo.PNConnectionConfig.PnPort
				});
				global::SSLMangrComp.ErrorReport errorReport = default(global::SSLMangrComp.ErrorReport);
				if (connInfo != null)
				{
					connectionManager = new global::SSLMangrComp.ConnectionManager(connInfo, false);
					connectionManager.InitiateConnection(ref result, ref errorReport);
				}
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("RetrievePresenceInfo...<{0}:{1}>...Done", new object[]
				{
					connInfo.PNConnectionConfig.PnIp,
					connInfo.PNConnectionConfig.PnPort
				});
			}
			catch (global::Motorola.Common.CustomException.CommonException exception)
			{
				global::Motorola.Common.Communication.Service.DeviceDiscovery.ThrowFaultException(exception);
			}
			catch (global::IACustomException.IACommonException exception2)
			{
				global::Motorola.Common.Communication.Service.DeviceDiscovery.ThrowIAException(exception2);
			}
			catch (global::System.Exception systemException)
			{
				global::Motorola.Common.Communication.Service.DeviceDiscovery.ThrowFaultException(new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.GenericError, systemException));
			}
			finally
			{
				if (connectionManager != null)
				{
					try
					{
						connectionManager.StopListener();
					}
					catch (global::System.AccessViolationException ex)
					{
						global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("AccessViolationException in StopListener " + ex.Message, new object[0]);
					}
					catch (global::System.Exception ex2)
					{
						global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("Exception in StopListener " + ex2.Message, new object[0]);
					}
				}
			}
			return result;
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x000069E8 File Offset: 0x00004BE8
		public bool Connect2PCRIPSystem(global::Motorola.Common.Communication.CommonUtil.PCRIPSystemInfo sysConfiguration)
		{
			bool result = true;
			try
			{
				if (!global::Common.Communication.Simulator.VirtualLeManager.Instance.OpenVirtualLE(sysConfiguration))
				{
					global::Motorola.Common.Communication.PCRRemoteProgramming.LEDeviceManager.Instance.OpenLE(sysConfiguration);
					global::Motorola.Common.Communication.PCRRemoteProgramming.LEDeviceManager.Instance.OnMasterLost += this.IPSystemLostHandler;
				}
			}
			catch (global::Motorola.Common.CustomException.CommonException exception)
			{
				global::Motorola.Common.Communication.Service.DeviceDiscovery.ThrowFaultException(exception);
			}
			catch (global::System.Exception)
			{
				result = false;
				global::Motorola.Common.Communication.Service.DeviceDiscovery.ThrowFaultException(new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.PCR_RP_LE_OPEN_FAILED));
			}
			return result;
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x00006A64 File Offset: 0x00004C64
		public void DisconnectFromPCRIPSystem()
		{
			try
			{
				global::Motorola.Common.Communication.PCRRemoteProgramming.LEDeviceManager.Instance.OnMasterLost -= this.IPSystemLostHandler;
				global::Motorola.Common.Communication.PCRRemoteProgramming.LEDeviceManager.Instance.CloseLE();
			}
			catch (global::Motorola.Common.CustomException.CommonException exception)
			{
				global::Motorola.Common.Communication.Service.DeviceDiscovery.ThrowFaultException(exception);
			}
			catch (global::System.Exception)
			{
				global::Motorola.Common.Communication.Service.DeviceDiscovery.ThrowFaultException(new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.PCR_RP_LE_OPEN_FAILED));
			}
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x00006B2C File Offset: 0x00004D2C
		private void DeviceConnected(object obj, global::Motorola.Common.Communication.CommonUtil.DeviceEventArgs args)
		{
			try
			{
				if (this.discoveryServiceEvent != null && (args.DeviceInfo.Family & (global::Motorola.Common.Communication.CommonUtil.ProductFamily)this._deviceFamilySet) > global::Motorola.Common.Communication.CommonUtil.ProductFamily.None)
				{
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteInfo("Wired Device Discovery Notification: {0} connected", new object[]
					{
						args.DeviceInfo.RadioID
					});
					if ((args.DeviceInfo.Family & global::Motorola.Common.Communication.CommonUtil.ProductFamily.TetraRadio) > global::Motorola.Common.Communication.CommonUtil.ProductFamily.None)
					{
						try
						{
							this.discoveryServiceEvent.OnDeviceConnected(args);
							goto IL_D9;
						}
						catch (global::System.Exception ex)
						{
							global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("Exception on callback DeviceConnected - " + ex.Message, new object[0]);
							goto IL_D9;
						}
					}
					global::System.Threading.Tasks.Task.Run(delegate()
					{
						try
						{
							this.discoveryServiceEvent.OnDeviceConnected(args);
						}
						catch (global::System.Exception ex4)
						{
							global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("Exception on callback DeviceConnected - " + ex4.Message, new object[0]);
						}
					});
				}
				IL_D9:;
			}
			catch (global::System.ServiceModel.CommunicationObjectAbortedException)
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("Client Abort Connection!", new object[0]);
				this.discoveryServiceEvent = null;
			}
			catch (global::System.ServiceModel.CommunicationException)
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("Client Abort Connection!", new object[0]);
				this.discoveryServiceEvent = null;
			}
			catch (global::System.ObjectDisposedException ex2)
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("Client Abort Connection? - " + ex2.Message, new object[0]);
				this.discoveryServiceEvent = null;
			}
			catch (global::System.Exception ex3)
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("DeviceConnected exception - " + ex3.Message, new object[0]);
			}
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x00006D44 File Offset: 0x00004F44
		private void DeviceLost(object obj, global::Motorola.Common.Communication.CommonUtil.DeviceEventArgs args)
		{
			try
			{
				if (this.discoveryServiceEvent != null && (args.DeviceInfo.Family & (global::Motorola.Common.Communication.CommonUtil.ProductFamily)this._deviceFamilySet) > global::Motorola.Common.Communication.CommonUtil.ProductFamily.None)
				{
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteInfo("Wired Device Discovery Notification: {0} disconnected", new object[]
					{
						args.DeviceInfo.RadioID
					});
					if ((args.DeviceInfo.Family & global::Motorola.Common.Communication.CommonUtil.ProductFamily.TetraRadio) > global::Motorola.Common.Communication.CommonUtil.ProductFamily.None)
					{
						try
						{
							this.discoveryServiceEvent.OnDeviceLost(args);
							goto IL_D9;
						}
						catch (global::System.Exception ex)
						{
							global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("Exception on callback DeviceLost - " + ex.Message, new object[0]);
							goto IL_D9;
						}
					}
					global::System.Threading.Tasks.Task.Run(delegate()
					{
						try
						{
							this.discoveryServiceEvent.OnDeviceLost(args);
						}
						catch (global::System.Exception ex4)
						{
							global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("Exception on callback DeviceLost - " + ex4.Message, new object[0]);
						}
					});
				}
				IL_D9:;
			}
			catch (global::System.ServiceModel.CommunicationObjectAbortedException)
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("Client Abort Connection!", new object[0]);
				this.discoveryServiceEvent = null;
			}
			catch (global::System.ServiceModel.CommunicationException)
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("Client Abort Connection!", new object[0]);
				this.discoveryServiceEvent = null;
			}
			catch (global::System.ObjectDisposedException ex2)
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("Client Abort Connection? - " + ex2.Message, new object[0]);
				this.discoveryServiceEvent = null;
			}
			catch (global::System.Exception ex3)
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("DeviceLost exception - " + ex3.Message, new object[0]);
			}
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x00006EFC File Offset: 0x000050FC
		private void IPSystemLostHandler(object sender, global::Motorola.Common.Communication.PCRRemoteProgramming.PeerEventArgs eventArgs)
		{
			try
			{
				if (this.discoveryServiceEvent != null)
				{
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteInfo("RP Master Device Discovery Notification: {0} disconnected", new object[]
					{
						eventArgs.peerID.ToString()
					});
					global::Motorola.Common.Communication.PCRRemoteProgramming.LEDeviceManager.Instance.OnMasterLost -= this.IPSystemLostHandler;
					if (!string.IsNullOrEmpty(global::Motorola.Common.Communication.PCRRemoteProgramming.LEDeviceManager.Instance.MasterHostNameOrAddress))
					{
						global::Motorola.Common.Communication.CommonUtil.DeviceEventArgs deviceEventArgs = new global::Motorola.Common.Communication.CommonUtil.DeviceEventArgs(new global::Motorola.Common.Communication.CommonUtil.DeviceInfo());
						deviceEventArgs.DeviceInfo.RadioID = global::System.Convert.ToString(eventArgs.peerID.ToString());
						deviceEventArgs.DeviceInfo.MasterHostNameOrAddress = global::Motorola.Common.Communication.PCRRemoteProgramming.LEDeviceManager.Instance.MasterHostNameOrAddress;
						deviceEventArgs.DeviceInfo.ConnectionInfo = new global::Motorola.Common.Communication.CommonUtil.ConnectionInfo();
						if (global::Motorola.Common.Communication.PCRRemoteProgramming.LEDeviceManager.Instance.GetRRPWorkMode() == global::Motorola.Common.Communication.CommonUtil.RRPWorkMode.DMR3)
						{
							deviceEventArgs.DeviceInfo.ConnectionInfo.ConnectionType = global::Motorola.Common.Communication.CommonUtil.ConnectionType.DMR3Network;
						}
						else
						{
							deviceEventArgs.DeviceInfo.ConnectionInfo.ConnectionType = global::Motorola.Common.Communication.CommonUtil.ConnectionType.LENetwork;
						}
						this.discoveryServiceEvent.OnMasterSystemLost(deviceEventArgs);
					}
				}
			}
			catch (global::System.ServiceModel.CommunicationObjectAbortedException)
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("Client Abort Connection!", new object[0]);
				this.discoveryServiceEvent = null;
			}
			catch (global::System.ServiceModel.CommunicationException)
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("Client Abort Connection!", new object[0]);
				this.discoveryServiceEvent = null;
			}
			catch (global::System.ObjectDisposedException ex)
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("Client Abort Connection? - " + ex.Message, new object[0]);
				this.discoveryServiceEvent = null;
			}
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x00007084 File Offset: 0x00005284
		private void DeviceSwitchOver(object obj, global::Motorola.Common.Communication.CommonUtil.SwitchOverEventArgs args)
		{
			try
			{
				global::Motorola.Common.Communication.CommunicationManager.SessionIdGenerator.Instance.ReturnID(args.SessionID);
				if (this.discoveryServiceEvent != null && (args.DeviceInfo.Family & (global::Motorola.Common.Communication.CommonUtil.ProductFamily)this._deviceFamilySet) > global::Motorola.Common.Communication.CommonUtil.ProductFamily.None)
				{
					global::System.Diagnostics.Trace.WriteLine(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "Device {0} session {1} switchover status {2}", new object[]
					{
						(args.DeviceInfo == null) ? string.Empty : args.DeviceInfo.RadioID,
						args.SessionID,
						args.Status
					}));
					this.discoveryServiceEvent.OnDeviceSwitchOver(args);
				}
			}
			catch (global::System.ServiceModel.CommunicationObjectAbortedException)
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("Client Abort Connection!", new object[0]);
				this.discoveryServiceEvent = null;
			}
			catch (global::System.ServiceModel.CommunicationException)
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("Client Abort Connection!", new object[0]);
				this.discoveryServiceEvent = null;
			}
			catch (global::System.ObjectDisposedException ex)
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("Client Abort Connection? - " + ex.Message, new object[0]);
				this.discoveryServiceEvent = null;
			}
		}

		// Token: 0x060001EA RID: 490 RVA: 0x000071B4 File Offset: 0x000053B4
		private static void ThrowFaultException(global::Motorola.Common.CustomException.CommonException exception)
		{
			throw exception;
		}

		// Token: 0x060001EB RID: 491 RVA: 0x000071B7 File Offset: 0x000053B7
		private static void ThrowIAException(global::IACustomException.IACommonException exception)
		{
			throw new global::Motorola.Common.CustomException.CommonException((global::Motorola.Common.CustomException.CommonErrorCode)exception.ErrorCode);
		}

		// Token: 0x060001EC RID: 492 RVA: 0x000071C4 File Offset: 0x000053C4
		private global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DeviceInfo> CopyDeviceInfo(global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DeviceInfo> devList)
		{
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DeviceInfo> list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DeviceInfo>();
			foreach (global::Motorola.Common.Communication.CommonUtil.DeviceInfo devInfo in devList)
			{
				global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo = devInfo.Copy();
				if (deviceInfo != null)
				{
					list.Add(deviceInfo);
				}
			}
			return list;
		}

		// Token: 0x060001ED RID: 493 RVA: 0x00007224 File Offset: 0x00005424
		public void UpdatePassword(global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.AuthenticationInfo> passwords)
		{
			global::Motorola.Common.Communication.CommunicationManager.CommunicationManagerClass.Instance.UpdatePasswords(passwords);
		}

		// Token: 0x060001EE RID: 494 RVA: 0x00007231 File Offset: 0x00005431
		public void DetachDevice(string serialnumber)
		{
			global::Motorola.Common.Communication.CommunicationManager.CommunicationManagerClass.Instance.DetachDevice(serialnumber);
		}

		// Token: 0x060001EF RID: 495 RVA: 0x0000723E File Offset: 0x0000543E
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x00007250 File Offset: 0x00005450
		protected virtual void Dispose(bool disposing)
		{
			if (this.discoveryServiceEvent != null)
			{
				global::Motorola.Common.Communication.CommunicationManager.CommunicationManagerClass instance = global::Motorola.Common.Communication.CommunicationManager.CommunicationManagerClass.Instance;
				instance.DeviceConnectedEventHandler = (global::System.EventHandler<global::Motorola.Common.Communication.CommonUtil.DeviceEventArgs>)global::System.Delegate.Remove(instance.DeviceConnectedEventHandler, new global::System.EventHandler<global::Motorola.Common.Communication.CommonUtil.DeviceEventArgs>(this.DeviceConnected));
				global::Motorola.Common.Communication.CommunicationManager.CommunicationManagerClass instance2 = global::Motorola.Common.Communication.CommunicationManager.CommunicationManagerClass.Instance;
				instance2.DeviceLostEventHandler = (global::System.EventHandler<global::Motorola.Common.Communication.CommonUtil.DeviceEventArgs>)global::System.Delegate.Remove(instance2.DeviceLostEventHandler, new global::System.EventHandler<global::Motorola.Common.Communication.CommonUtil.DeviceEventArgs>(this.DeviceLost));
			}
			if (this._deviceFamilySet > 0)
			{
				global::Motorola.Common.Communication.CommunicationManager.CommunicationManagerClass.Instance.Stop();
			}
		}

		// Token: 0x0400001E RID: 30
		private global::Motorola.Common.Communication.Service.IDiscoveryServiceEvent discoveryServiceEvent;

		// Token: 0x0400001F RID: 31
		private int _deviceFamilySet = 65535;

		// Token: 0x04000020 RID: 32
		private global::Motorola.Common.Communication.CommonUtil.WorkMode _workMode;

		// Token: 0x04000021 RID: 33
		private object _connLock = new object();

		// Token: 0x0200000A RID: 10
		// (Invoke) Token: 0x060001F2 RID: 498
		private delegate void _eventCallBackFunc(global::Motorola.Common.Communication.CommonUtil.DeviceEventArgs args);
	}
}
