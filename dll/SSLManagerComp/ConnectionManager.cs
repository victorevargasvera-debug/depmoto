using System;
using System.Threading;
using IACustomException;
using SSLMangrComp.ConnectionLayer;
using SSLMangrComp.Packets;

namespace SSLMangrComp
{
	// Token: 0x02000020 RID: 32
	public class ConnectionManager
	{
		// Token: 0x14000015 RID: 21
		// (add) Token: 0x060000FF RID: 255 RVA: 0x000061E0 File Offset: 0x000043E0
		// (remove) Token: 0x06000100 RID: 256 RVA: 0x00006218 File Offset: 0x00004418
		public event global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle PacketReceived;

		// Token: 0x14000016 RID: 22
		// (add) Token: 0x06000101 RID: 257 RVA: 0x00006250 File Offset: 0x00004450
		// (remove) Token: 0x06000102 RID: 258 RVA: 0x00006288 File Offset: 0x00004488
		public event global::SSLMangrComp.ConnectionManager.ErrorReceivedHandle HandleError;

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000103 RID: 259 RVA: 0x000062BD File Offset: 0x000044BD
		// (set) Token: 0x06000104 RID: 260 RVA: 0x000062C5 File Offset: 0x000044C5
		public int Expire
		{
			get
			{
				return this.mExpire;
			}
			set
			{
				this.mExpire = value;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000106 RID: 262 RVA: 0x000062D7 File Offset: 0x000044D7
		// (set) Token: 0x06000105 RID: 261 RVA: 0x000062CE File Offset: 0x000044CE
		public global::SSLMangrComp.Packets.EntitiesTypes EntityType
		{
			get
			{
				return this.mEntityType;
			}
			set
			{
				this.mEntityType = value;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000108 RID: 264 RVA: 0x000062E8 File Offset: 0x000044E8
		// (set) Token: 0x06000107 RID: 263 RVA: 0x000062DF File Offset: 0x000044DF
		public string Entity
		{
			get
			{
				return this.mEntity;
			}
			set
			{
				this.mEntity = value;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600010A RID: 266 RVA: 0x000062F9 File Offset: 0x000044F9
		// (set) Token: 0x06000109 RID: 265 RVA: 0x000062F0 File Offset: 0x000044F0
		public string subEvents
		{
			get
			{
				return this.mEvents;
			}
			set
			{
				this.mEvents = value;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600010B RID: 267 RVA: 0x00006301 File Offset: 0x00004501
		// (set) Token: 0x0600010C RID: 268 RVA: 0x00006309 File Offset: 0x00004509
		public global::SSLMangrComp.Packets.SubscriptionType Mode
		{
			get
			{
				return this.mMode;
			}
			set
			{
				this.mMode = value;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600010D RID: 269 RVA: 0x00006312 File Offset: 0x00004512
		// (set) Token: 0x0600010E RID: 270 RVA: 0x0000631A File Offset: 0x0000451A
		public string Timeout
		{
			get
			{
				return this.mTimeout;
			}
			set
			{
				this.mTimeout = value;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600010F RID: 271 RVA: 0x00006323 File Offset: 0x00004523
		// (set) Token: 0x06000110 RID: 272 RVA: 0x0000632B File Offset: 0x0000452B
		public global::SSLMangrComp.ConnectionConfig ConnConfig
		{
			get
			{
				return this.PnConnectionConfig;
			}
			set
			{
				this.PnConnectionConfig = value;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000111 RID: 273 RVA: 0x00006334 File Offset: 0x00004534
		// (set) Token: 0x06000112 RID: 274 RVA: 0x0000633C File Offset: 0x0000453C
		public global::SSLMangrComp.SecureClientConfiguration SecureClient
		{
			get
			{
				return this.secureClientConfig;
			}
			set
			{
				this.secureClientConfig = value;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000113 RID: 275 RVA: 0x00006345 File Offset: 0x00004545
		// (set) Token: 0x06000114 RID: 276 RVA: 0x0000634D File Offset: 0x0000454D
		public global::SSLMangrComp.SecureServerConfiguration SecureServer
		{
			get
			{
				return this.secureServerConfig;
			}
			set
			{
				this.secureServerConfig = value;
			}
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00006358 File Offset: 0x00004558
		private ConnectionManager()
		{
			this.m_pCB = new global::SSLMangrComp.PresenceInfo_CallBack(this.SetParentDataObjects);
			this.m_eCB = new global::SSLMangrComp.ReportOnError_CallBack(this.SetErrorDataObjects);
			this._linkManager = new global::SSLMangrComp.LinkManager();
			if (this._linkManager != null)
			{
				this._linkManager.PacketSentOrRecived += this.HandlePacket;
				this._linkManager.ErrorReceived += this.ErrorReceived;
			}
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00006444 File Offset: 0x00004644
		public ConnectionManager(global::SSLMangrComp.PNConnectionInfo pnConnectionInfo, bool disconnectFromClient) : this()
		{
			this.PnConnectionConfig = pnConnectionInfo.PNConnectionConfig;
			this.secureClientConfig = pnConnectionInfo.TLSClientConfig;
			this.secureServerConfig = pnConnectionInfo.TLSServerConfig;
			this.isDisconnectFromClient = disconnectFromClient;
			this.mMode = pnConnectionInfo.PNConnectionConfig.SubscriptionMode;
			this.mTimeout = pnConnectionInfo.PNConnectionConfig.ConnectionAttemptTimeout.ToString();
			global::SSLMangrComp.ConnectionManager.signalPacket = new global::System.Threading.AutoResetEvent(false);
		}

		// Token: 0x06000117 RID: 279 RVA: 0x000064B7 File Offset: 0x000046B7
		private void ErrorReceived(global::SSLMangrComp.ErrorReport errorReport)
		{
			this.nErrorCategory = (int)errorReport.ErrCat;
			this.nErrorId = (int)errorReport.ErrorID;
			this.RemoveHandles();
		}

		// Token: 0x06000118 RID: 280 RVA: 0x000064DC File Offset: 0x000046DC
		private void HandlePacket(global::SSLMangrComp.Packets.PacketBase packet)
		{
			packet.PacketDataTime.ToLongTimeString();
			packet.DialogID.ToString();
			packet.getPacketDescription();
			string packetDescription = packet.getPacketDescription();
			if (packetDescription == "Reliable Notify Message" || packetDescription == "Unreliable Notify Message")
			{
				global::SSLMangrComp.PresenceInfo instance = global::SSLMangrComp.PresenceInfo.Instance;
				global::SSLMangrComp.PresenceNotification presenceNotification = new global::SSLMangrComp.PresenceNotification();
				presenceNotification = instance.SendPresenceNotification(packet);
				if (this.PacketReceived != null)
				{
					this.PacketReceived(packet);
				}
				instance.SendPresenceInfo(this.m_pCB);
				instance.CallPresenceInfoCallback(ref presenceNotification);
				this.RemoveHandles();
				global::SSLMangrComp.ConnectionManager.signalPacket.Set();
			}
		}

		// Token: 0x06000119 RID: 281 RVA: 0x0000657D File Offset: 0x0000477D
		private void RemoveHandles()
		{
			if (this.PacketReceived != null)
			{
				this.PacketReceived -= this.ConnectionManager_PacketReceived;
			}
			if (this.HandleError != null)
			{
				this.HandleError -= this.ConnectionManager_ErrorReceived;
			}
		}

		// Token: 0x0600011A RID: 282 RVA: 0x000065B4 File Offset: 0x000047B4
		public void SetParentDataObjects(ref global::SSLMangrComp.PresenceNotification Pn)
		{
			this.strRadIP = Pn.IPAddr;
			this.strSubState = Pn.SubscriptionState;
			this.strDeviceId = Pn.DeviceId;
			this.strEntityType = Pn.EntityType;
			this.reEventValue = (uint)Pn.EventValue;
			this.psPresenceState = (uint)Pn.PresenceState;
			this.nErrorCategory = (int)this.m_ER.ReportCategory;
			this.nErrorId = (int)this.m_ER.ReportId;
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00006634 File Offset: 0x00004834
		public void ResetParentDataObjects()
		{
			this.strRadIP = string.Empty;
			this.strSubState = string.Empty;
			this.strDeviceId = string.Empty;
			this.strEntityType = string.Empty;
			this.reEventValue = 2U;
			this.psPresenceState = 0U;
			this.nErrorCategory = 0;
			this.nErrorId = 0;
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00006689 File Offset: 0x00004889
		public void SetErrorDataObjects(ref global::SSLMangrComp.ErrorReport ErrorRep)
		{
			this.nErrorCategory = (int)ErrorRep.ErrCat;
			this.nErrorId = (int)ErrorRep.ErrorID;
		}

		// Token: 0x0600011D RID: 285 RVA: 0x000066A4 File Offset: 0x000048A4
		public int InitiateConnection(ref global::SSLMangrComp.PresenceNotification presNot, ref global::SSLMangrComp.ErrorReport err)
		{
			int result = 0;
			bool flag = false;
			try
			{
				this.PrepareForConnection();
			}
			catch (global::IACustomException.IACommonException ex)
			{
				throw ex;
			}
			catch (global::System.Exception)
			{
				flag = true;
				throw new global::IACustomException.IACommonException(global::IACustomException.IACommonErrorCode.SSL_Unknown);
			}
			if (!flag)
			{
				try
				{
					this.PacketReceived += this.ConnectionManager_PacketReceived;
					this.HandleError += this.ErrorReceived;
					if (this.mMode == global::SSLMangrComp.Packets.SubscriptionType.Secure)
					{
						this._linkManager.Subscribe(this.PnConnectionConfig.Expiration, this.PnConnectionConfig.EntityType, this.PnConnectionConfig.EntityValue, this.mEvents, this.PnConnectionConfig.SubscriptionMode, this.PnConnectionConfig.PnIp, this.PnConnectionConfig.PnPort, this.isDisconnectFromClient, this.secureClientConfig, this.secureServerConfig);
					}
					else
					{
						this._linkManager.Subscribe(this.PnConnectionConfig.Expiration, this.PnConnectionConfig.EntityType, this.PnConnectionConfig.EntityValue, this.mEvents, this.PnConnectionConfig.SubscriptionMode, this.PnConnectionConfig.PnIp, this.PnConnectionConfig.PnPort);
					}
					result = this.WaitUntilResultReturnsOrTimout(ref presNot, ref err);
				}
				catch (global::System.Exception ex2)
				{
					if (ex2 is global::IACustomException.IACommonException)
					{
						throw ex2;
					}
					if (ex2 is global::System.TimeoutException)
					{
						throw new global::IACustomException.IACommonException(global::IACustomException.IACommonErrorCode.SSL_PE_PackageTimeout, ex2);
					}
					if (this.m_ER.ReportCategory == 0U)
					{
						throw new global::IACustomException.IACommonException(global::IACustomException.IACommonErrorCode.SSL_UnhandledLinkMgrException, ex2);
					}
				}
			}
			return result;
		}

		// Token: 0x0600011E RID: 286 RVA: 0x00006828 File Offset: 0x00004A28
		public void StopListener()
		{
			this._linkManager.shutDownListen(this.mMode);
		}

		// Token: 0x0600011F RID: 287 RVA: 0x0000683B File Offset: 0x00004A3B
		private void PrepareForConnection()
		{
			this.ResetParentDataObjects();
			this._linkManager.SetTimeOut(this.PnConnectionConfig.ConnectionAttemptTimeout, this.m_eCB);
			this.m_PI.ResetPresenceNotification();
			this.m_ER.ResetErrorReport();
		}

		// Token: 0x06000120 RID: 288 RVA: 0x00006875 File Offset: 0x00004A75
		private void ConnectionManager_PacketReceived(global::SSLMangrComp.Packets.PacketBase packet)
		{
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00006877 File Offset: 0x00004A77
		private void ConnectionManager_ErrorReceived(global::SSLMangrComp.ErrorReport report)
		{
		}

		// Token: 0x06000122 RID: 290 RVA: 0x0000687C File Offset: 0x00004A7C
		private int WaitUntilResultReturnsOrTimout(ref global::SSLMangrComp.PresenceNotification myReturnPn, ref global::SSLMangrComp.ErrorReport myReturnErr)
		{
			int num = -7;
			int num2 = num;
			global::System.DateTime now = global::System.DateTime.Now;
			int.TryParse(this.mTimeout, out num2);
			if (num2 >= 2)
			{
				num2 -= 2;
			}
			global::SSLMangrComp.ConnectionManager.signalPacket.WaitOne(num2 * 1000);
			if (this.PacketReceived == null || this.HandleError == null)
			{
				if (this.psPresenceState == 2U)
				{
					num = 2;
				}
				if (this.psPresenceState == 1U)
				{
					num = 1;
				}
				if (this.psPresenceState == 0U)
				{
					num = 0;
				}
				myReturnPn.DeviceId = this.strDeviceId;
				myReturnPn.EntityType = this.strEntityType;
				myReturnPn.EventValue = (global::SSLMangrComp.RequestEvent)this.reEventValue;
				myReturnPn.IPAddr = this.strRadIP;
				myReturnPn.PresenceState = (global::SSLMangrComp.PresenceState)this.psPresenceState;
				myReturnPn.SubscriptionState = this.strSubState;
				if (this.nErrorCategory != 0)
				{
					throw new global::IACustomException.IACommonException((global::IACustomException.IACommonErrorCode)this.nErrorId);
				}
			}
			if (num == -7)
			{
				this._linkManager.shutDownListen(this.mMode);
			}
			return num;
		}

		// Token: 0x04000081 RID: 129
		private static global::System.Threading.AutoResetEvent signalPacket = new global::System.Threading.AutoResetEvent(false);

		// Token: 0x04000082 RID: 130
		public global::SSLMangrComp.PresenceInfo_CallBack m_pCB;

		// Token: 0x04000083 RID: 131
		public global::SSLMangrComp.ReportOnError_CallBack m_eCB;

		// Token: 0x04000084 RID: 132
		private global::SSLMangrComp.PresenceInfo m_PI = global::SSLMangrComp.PresenceInfo.Instance;

		// Token: 0x04000085 RID: 133
		private global::SSLMangrComp.ErrorReporter m_ER = global::SSLMangrComp.ErrorReporter.Instance;

		// Token: 0x04000086 RID: 134
		private int mExpire;

		// Token: 0x04000087 RID: 135
		private global::SSLMangrComp.Packets.EntitiesTypes mEntityType = global::SSLMangrComp.Packets.EntitiesTypes.DeviceID;

		// Token: 0x04000088 RID: 136
		private string mEntity = "0";

		// Token: 0x04000089 RID: 137
		private string mEvents = "12";

		// Token: 0x0400008A RID: 138
		private global::SSLMangrComp.Packets.SubscriptionType mMode;

		// Token: 0x0400008B RID: 139
		private string mTimeout = string.Empty;

		// Token: 0x0400008C RID: 140
		public string strRadIP = string.Empty;

		// Token: 0x0400008D RID: 141
		public string strSubState = string.Empty;

		// Token: 0x0400008E RID: 142
		public string strDeviceId = string.Empty;

		// Token: 0x0400008F RID: 143
		public string strEntityType = string.Empty;

		// Token: 0x04000090 RID: 144
		public uint reEventValue = 2U;

		// Token: 0x04000091 RID: 145
		public uint psPresenceState;

		// Token: 0x04000092 RID: 146
		public int nErrorCategory;

		// Token: 0x04000093 RID: 147
		public int nErrorId;

		// Token: 0x04000094 RID: 148
		private global::SSLMangrComp.SecureClientConfiguration secureClientConfig;

		// Token: 0x04000095 RID: 149
		private global::SSLMangrComp.SecureServerConfiguration secureServerConfig;

		// Token: 0x04000096 RID: 150
		private global::SSLMangrComp.ConnectionConfig PnConnectionConfig;

		// Token: 0x04000097 RID: 151
		private global::SSLMangrComp.LinkManager _linkManager;

		// Token: 0x04000098 RID: 152
		private bool isDisconnectFromClient;

		// Token: 0x02000021 RID: 33
		// (Invoke) Token: 0x06000125 RID: 293
		public delegate void ErrorReceivedHandle(global::SSLMangrComp.ErrorReport report);
	}
}
