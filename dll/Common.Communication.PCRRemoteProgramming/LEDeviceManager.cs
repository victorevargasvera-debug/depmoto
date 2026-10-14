using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net;
using System.Threading;
using custom_datatypes;
using LEAdaptor;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.PCRRemoteProgramming
{
	// Token: 0x02000006 RID: 6
	public class LEDeviceManager : global::System.IDisposable
	{
		// Token: 0x14000001 RID: 1
		// (add) Token: 0x0600000B RID: 11 RVA: 0x000020E8 File Offset: 0x000002E8
		// (remove) Token: 0x0600000C RID: 12 RVA: 0x00002120 File Offset: 0x00000320
		public event global::Motorola.Common.Communication.PCRRemoteProgramming.PeerLostHandler OnMasterLost;

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x0600000D RID: 13 RVA: 0x00002158 File Offset: 0x00000358
		// (remove) Token: 0x0600000E RID: 14 RVA: 0x00002190 File Offset: 0x00000390
		public event global::Motorola.Common.Communication.PCRRemoteProgramming.PeerMapUpdateHandler OnPeerMapUpdate;

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600000F RID: 15 RVA: 0x000021C8 File Offset: 0x000003C8
		public string MasterHostNameOrAddress
		{
			get
			{
				string result = string.Empty;
				lock (this._lockObj)
				{
					if (this.m_sysConfiguration != null)
					{
						result = this.m_sysConfiguration.RemoteHostNameOrAddress;
					}
				}
				return result;
			}
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002220 File Offset: 0x00000420
		private LEDeviceManager()
		{
			this.m_bIsOpening = false;
			this.m_bIsOpen = false;
			this.m_bIsCancelled = false;
			this.m_sysConfiguration = null;
			this.connectWaitHandle = new global::System.Threading.AutoResetEvent(false);
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000011 RID: 17 RVA: 0x0000225D File Offset: 0x0000045D
		public static global::Motorola.Common.Communication.PCRRemoteProgramming.LEDeviceManager Instance
		{
			get
			{
				return global::Motorola.Common.Communication.PCRRemoteProgramming.LEDeviceManager.LEDevManager;
			}
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002264 File Offset: 0x00000464
		public global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DeviceInfo> GetRemoteDevicesList()
		{
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DeviceInfo> list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DeviceInfo>();
			if (this.m_bIsOpen)
			{
				global::custom_datatypes.MLEPeer[] array = null;
				this.GetPeerMapData(out array);
				foreach (global::custom_datatypes.MLEPeer peer in array)
				{
					list.Add(global::Motorola.Common.Communication.PCRRemoteProgramming.LEDeviceManager.ConstructRPDeviceInfo(peer));
				}
			}
			return list;
		}

		// Token: 0x06000013 RID: 19 RVA: 0x000022BA File Offset: 0x000004BA
		public global::Motorola.Common.Communication.CommonUtil.RRPWorkMode GetRRPWorkMode()
		{
			if (this.m_sysConfiguration == null)
			{
				return global::Motorola.Common.Communication.CommonUtil.RRPWorkMode.None;
			}
			if (this.m_sysConfiguration.SystemType == global::Motorola.Common.Communication.CommonUtil.PCRIPSystemType.DMR3)
			{
				return global::Motorola.Common.Communication.CommonUtil.RRPWorkMode.DMR3;
			}
			return global::Motorola.Common.Communication.CommonUtil.RRPWorkMode.NonDMR3;
		}

		// Token: 0x06000014 RID: 20 RVA: 0x000022D8 File Offset: 0x000004D8
		private static global::Motorola.Common.Communication.CommonUtil.PCRDeviceInfo ConstructRPDeviceInfo(global::custom_datatypes.MLEPeer peer)
		{
			global::Motorola.Common.Communication.CommonUtil.PCRDeviceInfo pcrdeviceInfo = new global::Motorola.Common.Communication.CommonUtil.PCRDeviceInfo();
			pcrdeviceInfo.ConnectionInfo = new global::Motorola.Common.Communication.CommonUtil.ConnectionInfo();
			pcrdeviceInfo.ConnectionInfo.AuthInfo = new global::Motorola.Common.Communication.CommonUtil.AuthenticationInfo();
			pcrdeviceInfo.DeviceWorkMode = global::Motorola.Common.Communication.PCRRemoteProgramming.LEDeviceManager.Instance.GetRRPWorkMode();
			if (pcrdeviceInfo.DeviceWorkMode == global::Motorola.Common.Communication.CommonUtil.RRPWorkMode.DMR3)
			{
				pcrdeviceInfo.ConnectionInfo.ConnectionType = global::Motorola.Common.Communication.CommonUtil.ConnectionType.DMR3Network;
			}
			else
			{
				pcrdeviceInfo.ConnectionInfo.ConnectionType = global::Motorola.Common.Communication.CommonUtil.ConnectionType.LENetwork;
			}
			pcrdeviceInfo.ConnectionInfo.UniqueAddress = peer.IP;
			pcrdeviceInfo.ConnectionInfo.Location = global::System.Convert.ToString(peer.Port, global::System.Globalization.CultureInfo.InvariantCulture);
			pcrdeviceInfo.RadioID = global::System.Convert.ToString(peer.ID, global::System.Globalization.CultureInfo.InvariantCulture);
			pcrdeviceInfo.SerialNumber = peer.SerialNumber;
			pcrdeviceInfo.Master = peer.Master;
			pcrdeviceInfo.Family = global::Motorola.Common.Communication.CommonUtil.ProductFamily.MatrixRadio;
			pcrdeviceInfo.RadioStorage = global::Motorola.Common.Communication.CommonUtil.RadioStorage.Raw;
			pcrdeviceInfo.RadioState = global::Motorola.Common.Communication.CommonUtil.RadioState.Ready;
			pcrdeviceInfo.VoterID = global::System.Convert.ToString(peer.VoterID, global::System.Globalization.CultureInfo.InvariantCulture);
			return pcrdeviceInfo;
		}

		// Token: 0x06000015 RID: 21 RVA: 0x000023C9 File Offset: 0x000005C9
		public static global::Motorola.Common.Communication.CommonUtil.PCRDeviceInfo ConstructRPDeviceInfo(global::Motorola.Common.Communication.PCRRemoteProgramming.PCRRemoteDeviceProfile profile)
		{
			return global::Motorola.Common.Communication.PCRRemoteProgramming.LEDeviceManager.ConstructRPDeviceInfo(profile.PEER);
		}

		// Token: 0x06000016 RID: 22 RVA: 0x000023D8 File Offset: 0x000005D8
		public void OpenLE(global::Motorola.Common.Communication.CommonUtil.PCRIPSystemInfo sysConfiguration)
		{
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("Enter Open LE", new object[0]);
			lock (this._lockObj)
			{
				this.m_bIsOpening = true;
				this.m_bIsCancelled = false;
				try
				{
					if (this.m_bIsOpen)
					{
						global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("LE is ready openned when try to open it", new object[0]);
						return;
					}
					sysConfiguration.LocalType = global::Motorola.Common.Communication.CommonUtil.RPLocalType.PASSIVE_PEER;
					global::Motorola.Common.Communication.PCRRemoteProgramming.TCPPortManager.Instance.MinPortNumber = (int)sysConfiguration.MinTCPPort;
					global::Motorola.Common.Communication.PCRRemoteProgramming.TCPPortManager.Instance.MaxPortNumber = (int)sysConfiguration.MaxTCPPort;
					if (!this.m_bIsCancelled)
					{
						if (this.multiSiteSystem != null)
						{
							this.multiSiteSystem.Dispose();
							this.multiSiteSystem = null;
						}
						this.multiSiteSystem = global::Motorola.Common.Communication.PCRRemoteProgramming.MRemoteSystemFactory.Create(sysConfiguration);
						this.statusChange = new global::LEAdaptor.StatusChangeHandler(this.ProcessQueueItem);
						this.multiSiteSystem.OnStatusChange += this.statusChange;
						int num = this.multiSiteSystem.Open();
						if (num != global::Motorola.Common.Communication.PCRRemoteProgramming.PCRRPConstants.SUCCESS)
						{
							throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.PCR_RP_LE_OPEN_FAILED);
						}
					}
					bool flag2 = false;
					try
					{
						if (!this.m_bIsCancelled)
						{
							flag2 = this.connectWaitHandle.WaitOne(global::Motorola.Common.Communication.PCRRemoteProgramming.PCRRPConstants.REMOTE_RETRY_TIMEOUT * global::Motorola.Common.Communication.PCRRemoteProgramming.PCRRPConstants.SECONDS);
						}
					}
					finally
					{
						this.m_bIsOpening = false;
					}
					if (this.m_bIsCancelled)
					{
						throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.OperationIsCancelled);
					}
					if (!flag2)
					{
						throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.PCR_RP_REMOTE_CONNECTION_FAILED);
					}
					this.m_bIsOpen = true;
					this.m_sysConfiguration = sysConfiguration;
				}
				catch (global::Motorola.Common.CustomException.CommonException ex)
				{
					this.CleanupEnvironment();
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("Failed to connect to Master<{0}> <{1}>.", new object[]
					{
						sysConfiguration.RemoteHostNameOrAddress,
						ex.Message
					});
					throw;
				}
				catch (global::System.Exception ex2)
				{
					this.CleanupEnvironment();
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("Failed to connect to Master<{0}> <{1}>.", new object[]
					{
						sysConfiguration.RemoteHostNameOrAddress,
						ex2.Message
					});
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.PCR_RP_REMOTE_CONNECTION_FAILED);
				}
				finally
				{
					this.m_bIsOpening = false;
				}
			}
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("Connected to Master<{0}>.", new object[]
			{
				sysConfiguration.RemoteHostNameOrAddress
			});
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002660 File Offset: 0x00000860
		public void CloseLE()
		{
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("Enter close LE", new object[0]);
			string text = string.Empty;
			if (this.m_sysConfiguration != null)
			{
				text = this.m_sysConfiguration.RemoteHostNameOrAddress;
			}
			if (!this.m_bIsOpen && !this.m_bIsOpening)
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("LE is ready closed when close LE", new object[0]);
				return;
			}
			if (this.m_bIsOpening)
			{
				this.m_bIsCancelled = true;
				this.connectWaitHandle.Set();
			}
			lock (this._lockObj)
			{
				try
				{
					this.CleanupEnvironment();
				}
				catch (global::Motorola.Common.CustomException.CommonException)
				{
					throw;
				}
				catch (global::System.Exception)
				{
					throw;
				}
			}
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("Disconnected from Master<{0}>.", new object[]
			{
				text
			});
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002750 File Offset: 0x00000950
		private void CleanupEnvironment()
		{
			if (this.multiSiteSystem != null)
			{
				uint num = (uint)global::Motorola.Common.Communication.PCRRemoteProgramming.PCRRPConstants.SUCCESS;
				try
				{
					num = this.multiSiteSystem.Close();
				}
				catch (global::System.Exception ex)
				{
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("RP: close LE failed: " + ex.Message, new object[0]);
				}
				finally
				{
					this.multiSiteSystem.OnStatusChange -= this.statusChange;
					this.m_bIsOpen = false;
				}
				if (num != (uint)global::Motorola.Common.Communication.PCRRemoteProgramming.PCRRPConstants.SUCCESS)
				{
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("RP: close LE failed.", new object[0]);
				}
			}
			this.m_sysConfiguration = null;
		}

		// Token: 0x06000019 RID: 25 RVA: 0x000027FC File Offset: 0x000009FC
		private void GetPeerMapData(out global::custom_datatypes.MLEPeer[] peerMapData)
		{
			peerMapData = null;
			try
			{
				if (!this.m_bIsOpen)
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.PCR_RP_LE_ISNOT_OPEN);
				}
				if (!this.multiSiteSystem.GetPeerMapData(out peerMapData))
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.PCR_RP_LE_GET_PEER_MAP_FAILED);
				}
			}
			catch (global::Motorola.Common.CustomException.CommonException)
			{
				throw;
			}
			catch (global::System.Exception)
			{
			}
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002860 File Offset: 0x00000A60
		public ushort SendProxyConnectRequest(uint targetPeerID, string sourceIP, uint sourcePort, byte connectionType)
		{
			ushort maxValue = ushort.MaxValue;
			try
			{
				if (!this.m_bIsOpen)
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.PCR_RP_LE_ISNOT_OPEN);
				}
				global::System.Net.IPAddress ipaddress = global::System.Net.IPAddress.Parse(sourceIP);
				uint sourceIP2 = global::System.BitConverter.ToUInt32(ipaddress.GetAddressBytes(), 0);
				uint num = this.multiSiteSystem.SendProxyConnectRequest(targetPeerID, sourceIP2, (ushort)sourcePort, connectionType, out maxValue);
				if (num != (uint)global::Motorola.Common.Communication.PCRRemoteProgramming.PCRRPConstants.SUCCESS)
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.PCR_RP_LE_SEND_PROXY_CONNECTION_REQUEST_FAILED);
				}
			}
			catch (global::Motorola.Common.CustomException.CommonException)
			{
				throw;
			}
			catch (global::System.Exception)
			{
				throw;
			}
			return maxValue;
		}

		// Token: 0x0600001B RID: 27 RVA: 0x000028E8 File Offset: 0x00000AE8
		private void ProcessQueueItem(object sender, global::LEAdaptor.StatusChangeEventArgs e)
		{
			switch (e.eventType)
			{
			case 0U:
				if (e.peer != null)
				{
					if (!this.m_bIsOpen)
					{
						this.m_bIsOpen = true;
						this.connectWaitHandle.Set();
					}
					global::Motorola.Common.Communication.CommonUtil.SingletonBase<global::Motorola.Common.Communication.PCRRemoteProgramming.PCRRemoteDeviceDetector>.Instance().OnDeviceAdd(new global::Motorola.Common.Communication.PCRRemoteProgramming.PCRRemoteDeviceProfile((global::custom_datatypes.MLEPeer)e.peer));
					if (this.OnPeerMapUpdate != null)
					{
						this.OnPeerMapUpdate(this, new global::Motorola.Common.Communication.PCRRemoteProgramming.PeerEventArgs
						{
							peerID = ((global::custom_datatypes.MLEPeer)e.peer).ID
						});
						return;
					}
				}
				break;
			case 1U:
				if (e.peer != null)
				{
					global::Motorola.Common.Communication.CommonUtil.SingletonBase<global::Motorola.Common.Communication.PCRRemoteProgramming.PCRRemoteDeviceDetector>.Instance().OnDeviceRemove(new global::Motorola.Common.Communication.PCRRemoteProgramming.PCRRemoteDeviceProfile((global::custom_datatypes.MLEPeer)e.peer));
					if (this.OnPeerMapUpdate != null)
					{
						this.OnPeerMapUpdate(this, new global::Motorola.Common.Communication.PCRRemoteProgramming.PeerEventArgs
						{
							peerID = ((global::custom_datatypes.MLEPeer)e.peer).ID
						});
						return;
					}
				}
				break;
			case 2U:
				if (e.peer != null && this.OnMasterLost != null)
				{
					this.OnMasterLost(this, new global::Motorola.Common.Communication.PCRRemoteProgramming.PeerEventArgs
					{
						peerID = ((global::custom_datatypes.MLEPeer)e.peer).ID
					});
				}
				break;
			case 3U:
				if (e.peer != null && !this.m_bIsOpen)
				{
					this.m_bIsOpen = true;
					this.connectWaitHandle.Set();
					return;
				}
				break;
			default:
				return;
			}
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002A53 File Offset: 0x00000C53
		protected virtual void Dispose(bool disposing)
		{
			if (disposing)
			{
				if (this.connectWaitHandle != null)
				{
					this.connectWaitHandle.Close();
					this.connectWaitHandle.Dispose();
				}
				if (this.multiSiteSystem != null)
				{
					this.multiSiteSystem.Close();
				}
			}
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002A8A File Offset: 0x00000C8A
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x04000008 RID: 8
		private volatile bool m_bIsOpen;

		// Token: 0x04000009 RID: 9
		private bool m_bIsOpening;

		// Token: 0x0400000A RID: 10
		private bool m_bIsCancelled;

		// Token: 0x0400000B RID: 11
		private global::LEAdaptor.IMRemoteSystem multiSiteSystem;

		// Token: 0x0400000C RID: 12
		private global::LEAdaptor.StatusChangeHandler statusChange;

		// Token: 0x0400000D RID: 13
		private global::System.Threading.AutoResetEvent connectWaitHandle;

		// Token: 0x0400000E RID: 14
		private global::Motorola.Common.Communication.CommonUtil.PCRIPSystemInfo m_sysConfiguration;

		// Token: 0x0400000F RID: 15
		private object _lockObj = new object();

		// Token: 0x04000010 RID: 16
		private static global::Motorola.Common.Communication.PCRRemoteProgramming.LEDeviceManager LEDevManager = new global::Motorola.Common.Communication.PCRRemoteProgramming.LEDeviceManager();
	}
}
