using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using SSLMangrComp.ConnectionLayer;
using SSLMangrComp.Packets;

namespace SSLMangrComp
{
	// Token: 0x02000016 RID: 22
	public class ConnectionManagerWatcher
	{
		// Token: 0x14000011 RID: 17
		// (add) Token: 0x060000A7 RID: 167 RVA: 0x00005074 File Offset: 0x00003274
		// (remove) Token: 0x060000A8 RID: 168 RVA: 0x000050AC File Offset: 0x000032AC
		private event global::SSLMangrComp.ConnectionManagerWatcher.RadioPresenceNotify radioFound;

		// Token: 0x14000012 RID: 18
		// (add) Token: 0x060000A9 RID: 169 RVA: 0x000050E4 File Offset: 0x000032E4
		// (remove) Token: 0x060000AA RID: 170 RVA: 0x0000511C File Offset: 0x0000331C
		public event global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle PacketReceived;

		// Token: 0x14000013 RID: 19
		// (add) Token: 0x060000AB RID: 171 RVA: 0x00005154 File Offset: 0x00003354
		// (remove) Token: 0x060000AC RID: 172 RVA: 0x0000518C File Offset: 0x0000338C
		public event global::SSLMangrComp.ConnectionManagerWatcher.ErrorReceivedHandle HandleError;

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x060000AD RID: 173 RVA: 0x000051C1 File Offset: 0x000033C1
		// (set) Token: 0x060000AE RID: 174 RVA: 0x000051C9 File Offset: 0x000033C9
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

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x060000B0 RID: 176 RVA: 0x000051DB File Offset: 0x000033DB
		// (set) Token: 0x060000AF RID: 175 RVA: 0x000051D2 File Offset: 0x000033D2
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

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x060000B2 RID: 178 RVA: 0x000051EC File Offset: 0x000033EC
		// (set) Token: 0x060000B1 RID: 177 RVA: 0x000051E3 File Offset: 0x000033E3
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

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x060000B4 RID: 180 RVA: 0x000051FD File Offset: 0x000033FD
		// (set) Token: 0x060000B3 RID: 179 RVA: 0x000051F4 File Offset: 0x000033F4
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

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x060000B5 RID: 181 RVA: 0x00005205 File Offset: 0x00003405
		// (set) Token: 0x060000B6 RID: 182 RVA: 0x0000520D File Offset: 0x0000340D
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

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x060000B7 RID: 183 RVA: 0x00005216 File Offset: 0x00003416
		// (set) Token: 0x060000B8 RID: 184 RVA: 0x0000521E File Offset: 0x0000341E
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

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x060000B9 RID: 185 RVA: 0x00005227 File Offset: 0x00003427
		// (set) Token: 0x060000BA RID: 186 RVA: 0x00005230 File Offset: 0x00003430
		public global::SSLMangrComp.PNConnectionInfo ServerInfo
		{
			get
			{
				return this._PNServerInfo;
			}
			set
			{
				this._PNServerInfo = value;
				if (this._linkManager != null)
				{
					this._linkManager.serverInfo = value;
				}
				if (value.PNConnectionConfig != null)
				{
					this.mMode = this._PNServerInfo.PNConnectionConfig.SubscriptionMode;
					this.mTimeout = this._PNServerInfo.PNConnectionConfig.ConnectionAttemptTimeout.ToString();
				}
			}
		}

		// Token: 0x14000014 RID: 20
		// (add) Token: 0x060000BB RID: 187 RVA: 0x00005294 File Offset: 0x00003494
		// (remove) Token: 0x060000BC RID: 188 RVA: 0x000052AA File Offset: 0x000034AA
		public event global::SSLMangrComp.ConnectionManagerWatcher.RadioPresenceNotify RadioFound
		{
			add
			{
				this.radioFound = null;
				global::System.Runtime.CompilerServices.RuntimeHelpers.PrepareDelegate(value);
				this.radioFound += value;
			}
			remove
			{
				this.radioFound -= value;
			}
		}

		// Token: 0x060000BD RID: 189 RVA: 0x000052B4 File Offset: 0x000034B4
		public ConnectionManagerWatcher()
		{
			this.m_pCB = new global::SSLMangrComp.PresenceInfo_CallBack(this.SetParentDataObjects);
			this.m_eCB = new global::SSLMangrComp.ReportOnError_CallBack(this.SetErrorDataObjects);
			this._linkManager = new global::SSLMangrComp.LinkManagerWatcher();
			this.terminationWatcher = new global::SSLMangrComp.LinkManagerWatcher();
			this.PacketReceived += this.ConnectionManager_PacketReceived;
			this.HandleError += this.ErrorReceived;
			if (this._linkManager != null)
			{
				this._linkManager.PacketSentOrRecived += this.HandlePacket;
				this._linkManager.ErrorReceived += this.ErrorReceived;
			}
		}

		// Token: 0x060000BE RID: 190 RVA: 0x000053CD File Offset: 0x000035CD
		private void ErrorReceived(global::SSLMangrComp.ErrorReport errorReport)
		{
			this.nErrorCategory = (int)errorReport.ErrCat;
			this.nErrorId = (int)errorReport.ErrorID;
			this.m_PacketArrived = true;
		}

		// Token: 0x060000BF RID: 191 RVA: 0x000053F0 File Offset: 0x000035F0
		private void HandlePacket(global::SSLMangrComp.Packets.PacketBase packet)
		{
			if (this._linkManager.ActiveSubscriptionList.Count == 1 && packet.MessageID == 255)
			{
				global::SSLMangrComp.PresenceInfo instance = global::SSLMangrComp.PresenceInfo.Instance;
				global::SSLMangrComp.PresenceNotification presenceNotification = new global::SSLMangrComp.PresenceNotification();
				presenceNotification.DeviceId = this._PNServerInfo.PNConnectionConfig.EntityValue;
				presenceNotification.EntityType = this._PNServerInfo.PNConnectionConfig.EntityType.ToString();
				presenceNotification.PresenceState = global::SSLMangrComp.PresenceState.Absent;
				presenceNotification.EventValue = global::SSLMangrComp.RequestEvent.Unknown;
				if (this.PacketReceived != null)
				{
					this.PacketReceived(packet);
				}
				instance.SendPresenceInfo(this.m_pCB);
				instance.CallPresenceInfoCallback(ref presenceNotification);
				this.m_PacketArrived = true;
				if (this.radioFound != null)
				{
					this.radioFound(presenceNotification);
					return;
				}
			}
			else
			{
				packet.PacketDataTime.ToLongTimeString();
				packet.DialogID.ToString();
				packet.getPacketDescription();
				string packetDescription = packet.getPacketDescription();
				if (packetDescription == "Reliable Notify Message" || packetDescription == "Unreliable Notify Message" || packetDescription.Contains("Cancel"))
				{
					global::SSLMangrComp.PresenceInfo instance2 = global::SSLMangrComp.PresenceInfo.Instance;
					global::SSLMangrComp.PresenceNotification deviceId = new global::SSLMangrComp.PresenceNotification();
					deviceId = instance2.SendPresenceNotification(packet);
					if (this.PacketReceived != null)
					{
						this.PacketReceived(packet);
					}
					instance2.SendPresenceInfo(this.m_pCB);
					instance2.CallPresenceInfoCallback(ref deviceId);
					this.m_PacketArrived = true;
					if (this.radioFound != null)
					{
						this.radioFound(deviceId);
					}
				}
			}
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00005569 File Offset: 0x00003769
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

		// Token: 0x060000C1 RID: 193 RVA: 0x000055A0 File Offset: 0x000037A0
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

		// Token: 0x060000C2 RID: 194 RVA: 0x00005620 File Offset: 0x00003820
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

		// Token: 0x060000C3 RID: 195 RVA: 0x00005675 File Offset: 0x00003875
		public void SetErrorDataObjects(ref global::SSLMangrComp.ErrorReport ErrorRep)
		{
			this.nErrorCategory = (int)ErrorRep.ErrCat;
			this.nErrorId = (int)ErrorRep.ErrorID;
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x0000568F File Offset: 0x0000388F
		private void PrepareForConnection()
		{
			this.ResetParentDataObjects();
			this.m_PI.ResetPresenceNotification();
			this.m_ER.ResetErrorReport();
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x000056AD File Offset: 0x000038AD
		private void ConnectionManager_PacketReceived(global::SSLMangrComp.Packets.PacketBase packet)
		{
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x000056AF File Offset: 0x000038AF
		private void ConnectionManager_ErrorReceived(global::SSLMangrComp.ErrorReport report)
		{
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x000056B4 File Offset: 0x000038B4
		public void RegisterAsWatcher(global::System.Collections.Generic.List<string> RadioList)
		{
			this._linkManager.serverInfo = this.ServerInfo;
			this._linkManager.StartListener();
			this._linkManager.ClientConnect();
			if (this._linkManager.ActiveSubscriptionList.Count > 0)
			{
				this._linkManager.CancelExistingSubscription(RadioList);
				global::System.Threading.Thread.Sleep(4000);
			}
			foreach (string entityValue in RadioList)
			{
				this.ServerInfo.PNConnectionConfig.EntityValue = entityValue;
				this.PrepareForConnection();
				this.SendNotifySubscription();
				global::System.Threading.Thread.Sleep(1750);
			}
			this._linkManager.ClientClose();
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00005780 File Offset: 0x00003980
		public void closePN()
		{
			if (this._PNServerInfo != null && this._linkManager.serverInfo != null)
			{
				if (this._linkManager.ActiveSubscriptionList.Count > 0)
				{
					this._linkManager.StartListener();
					this._linkManager.ClientConnect();
					this._linkManager.CancelAllSubscriptions();
					this._linkManager.ClientClose();
					return;
				}
				this._linkManager.shutDownListen();
			}
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x000057F0 File Offset: 0x000039F0
		public void DeregisterAsWatcher(global::System.Collections.Generic.List<string> RadioList)
		{
			if (this._linkManager.ActiveSubscriptionList.Count > 0)
			{
				this._linkManager.serverInfo = this.ServerInfo;
				this._linkManager.StartListener();
				this._linkManager.ClientConnect();
				this._linkManager.CancelExistingSubscription(RadioList);
				global::System.Threading.Thread.Sleep(4000);
				this._linkManager.ClientClose();
			}
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00005858 File Offset: 0x00003A58
		private void SendNotifySubscription()
		{
			this._linkManager.Subscribe(this.mEvents);
		}

		// Token: 0x04000057 RID: 87
		public global::SSLMangrComp.PresenceInfo_CallBack m_pCB;

		// Token: 0x04000058 RID: 88
		public global::SSLMangrComp.ReportOnError_CallBack m_eCB;

		// Token: 0x04000059 RID: 89
		private global::SSLMangrComp.PresenceInfo m_PI = global::SSLMangrComp.PresenceInfo.Instance;

		// Token: 0x0400005A RID: 90
		private global::SSLMangrComp.ErrorReporter m_ER = global::SSLMangrComp.ErrorReporter.Instance;

		// Token: 0x0400005B RID: 91
		private int mExpire;

		// Token: 0x0400005C RID: 92
		private global::SSLMangrComp.Packets.EntitiesTypes mEntityType = global::SSLMangrComp.Packets.EntitiesTypes.DeviceID;

		// Token: 0x0400005D RID: 93
		private string mEntity = "0";

		// Token: 0x0400005E RID: 94
		private string mEvents = "12";

		// Token: 0x0400005F RID: 95
		private global::SSLMangrComp.Packets.SubscriptionType mMode;

		// Token: 0x04000060 RID: 96
		private string mTimeout = string.Empty;

		// Token: 0x04000061 RID: 97
		public string strRadIP = string.Empty;

		// Token: 0x04000062 RID: 98
		public string strSubState = string.Empty;

		// Token: 0x04000063 RID: 99
		public string strDeviceId = string.Empty;

		// Token: 0x04000064 RID: 100
		public string strEntityType = string.Empty;

		// Token: 0x04000065 RID: 101
		public uint reEventValue = 2U;

		// Token: 0x04000066 RID: 102
		public uint psPresenceState;

		// Token: 0x04000067 RID: 103
		public int nErrorCategory;

		// Token: 0x04000068 RID: 104
		public int nErrorId;

		// Token: 0x04000069 RID: 105
		private global::SSLMangrComp.PNConnectionInfo _PNServerInfo;

		// Token: 0x0400006A RID: 106
		private global::SSLMangrComp.LinkManagerWatcher _linkManager;

		// Token: 0x0400006B RID: 107
		private global::SSLMangrComp.LinkManagerWatcher terminationWatcher;

		// Token: 0x0400006C RID: 108
		private bool isDisconnectFromClient;

		// Token: 0x0400006D RID: 109
		private bool m_PacketArrived;

		// Token: 0x02000017 RID: 23
		// (Invoke) Token: 0x060000CC RID: 204
		public delegate void RadioPresenceNotify(global::SSLMangrComp.PresenceNotification DeviceId);

		// Token: 0x02000018 RID: 24
		// (Invoke) Token: 0x060000D0 RID: 208
		public delegate void ErrorReceivedHandle(global::SSLMangrComp.ErrorReport report);
	}
}
