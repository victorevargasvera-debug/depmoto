using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using IACustomException;
using SSLMangrComp.ConnectionLayer;
using SSLMangrComp.Connectors;
using SSLMangrComp.Packets;

namespace SSLMangrComp
{
	// Token: 0x02000027 RID: 39
	public class LinkManager
	{
		// Token: 0x14000017 RID: 23
		// (add) Token: 0x06000136 RID: 310 RVA: 0x00006A24 File Offset: 0x00004C24
		// (remove) Token: 0x06000137 RID: 311 RVA: 0x00006A5C File Offset: 0x00004C5C
		public event global::SSLMangrComp.LinkManager.PacketSendOrRecievedHandle PacketSentOrRecived;

		// Token: 0x14000018 RID: 24
		// (add) Token: 0x06000138 RID: 312 RVA: 0x00006A94 File Offset: 0x00004C94
		// (remove) Token: 0x06000139 RID: 313 RVA: 0x00006ACC File Offset: 0x00004CCC
		public event global::SSLMangrComp.LinkManager.ErrorRecievedHandle ErrorReceived;

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x0600013A RID: 314 RVA: 0x00006B01 File Offset: 0x00004D01
		public global::System.Collections.Generic.List<global::SSLMangrComp.Packets.PacketBase> ActiveSubscriptionList
		{
			get
			{
				return this.m_activeSubscriptionList;
			}
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00006B0C File Offset: 0x00004D0C
		public LinkManager()
		{
			this.m_UDPConnector.RegisterIncomingPacketHandler(new global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle(this.handleIncomingPacket));
			this.m_UDPConnector.RegisterIncomingErrorHandler(new global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle(this.handleIncomingError));
			this.m_TLSServerListener.RegisterIncomingPacketHandler(new global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle(this.handleIncomingPacket));
			this.m_TLSServerListener.RegisterIncomingErrorHandler(new global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle(this.handleIncomingError));
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00006BCE File Offset: 0x00004DCE
		public void SetTimeOut(int TimeoutDurationInSeconds, global::SSLMangrComp.ReportOnError_CallBack errorCallBack)
		{
			((global::SSLMangrComp.ConnectionLayer.UDPCConnector)this.m_UDPConnector).ErrorCallback = errorCallBack;
			this.m_UDPConnector.SetTimeOutVal(TimeoutDurationInSeconds);
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00006BF0 File Offset: 0x00004DF0
		public void Subscribe(int expiry, global::SSLMangrComp.Packets.EntitiesTypes entitiesType, string entitieValues, string events, global::SSLMangrComp.Packets.SubscriptionType type, global::System.Net.IPAddress ipAddress, int UDPPort)
		{
			global::SSLMangrComp.Packets.SubscriptionPacket subscriptionPacket = null;
			if (type == global::SSLMangrComp.Packets.SubscriptionType.Unreliable)
			{
				this.m_UDPConnector.StartListner(0);
				subscriptionPacket = new global::SSLMangrComp.Packets.UnreliableSubscriptionPacket(this.CreateNewDialogID(), expiry, entitiesType, entitieValues, events);
			}
			subscriptionPacket.Type = type;
			this.m_activeSubscriptionList.Add(subscriptionPacket);
			try
			{
				this.SendSubscription(subscriptionPacket, ipAddress, UDPPort);
			}
			catch (global::System.ArgumentException systemException)
			{
				throw new global::IACustomException.IACommonException(global::IACustomException.IACommonErrorCode.SSL_LE_UDPArgumentException, systemException);
			}
			catch (global::System.Net.Sockets.SocketException systemException2)
			{
				throw new global::IACustomException.IACommonException(global::IACustomException.IACommonErrorCode.SSL_LE_UnableToOpenSocket, systemException2);
			}
			catch (global::System.Exception systemException3)
			{
				throw new global::IACustomException.IACommonException(global::IACustomException.IACommonErrorCode.SSL_TLSClientInternalFailure, systemException3);
			}
		}

		// Token: 0x0600013E RID: 318 RVA: 0x00006C94 File Offset: 0x00004E94
		public void shutDownListen(global::SSLMangrComp.Packets.SubscriptionType type)
		{
			if (type == global::SSLMangrComp.Packets.SubscriptionType.Secure)
			{
				this.m_TLSServerListener.ShutdownServer();
				return;
			}
			if (type == global::SSLMangrComp.Packets.SubscriptionType.Unreliable)
			{
				this.m_UDPConnector.ShutdownServer();
			}
		}

		// Token: 0x0600013F RID: 319 RVA: 0x00006CB4 File Offset: 0x00004EB4
		public void Subscribe(int expiry, global::SSLMangrComp.Packets.EntitiesTypes entitiesType, string entitieValues, string events, global::SSLMangrComp.Packets.SubscriptionType type, global::System.Net.IPAddress ipAddress, int port, bool isDisconnectClient, global::SSLMangrComp.SecureClientConfiguration secureClientConfig, global::SSLMangrComp.SecureServerConfiguration secureServerConfig)
		{
			string text = base.GetType().ToString();
			text += ":Subscribe";
			global::SSLMangrComp.Packets.SubscriptionPacket subscriptionPacket = null;
			if (type == global::SSLMangrComp.Packets.SubscriptionType.Secure)
			{
				this.inboundIPAddress = ipAddress;
				if (!this.m_TLSServerListener.IsServerRunning())
				{
					this.StartConnection(type, secureServerConfig);
				}
				subscriptionPacket = new global::SSLMangrComp.Packets.ReliableSubscriptionPacket(this.CreateNewDialogID(), this.m_securePortNumber, expiry, entitiesType, entitieValues, events);
			}
			subscriptionPacket.Type = type;
			this.m_activeSubscriptionList.Add(subscriptionPacket);
			try
			{
				this.SendSubscription(subscriptionPacket, ipAddress, port, secureClientConfig, isDisconnectClient);
			}
			catch (global::System.ArgumentException)
			{
				throw new global::IACustomException.IACommonException(global::IACustomException.IACommonErrorCode.SSL_LE_UDPArgumentException)
				{
					Source = text
				};
			}
			catch (global::System.Net.Sockets.SocketException)
			{
				throw new global::IACustomException.IACommonException(global::IACustomException.IACommonErrorCode.SSL_LE_UnableToOpenSocket)
				{
					Source = text
				};
			}
			catch (global::System.Exception)
			{
				throw new global::IACustomException.IACommonException(global::IACustomException.IACommonErrorCode.SSL_TLSClientInternalFailure)
				{
					Source = text
				};
			}
		}

		// Token: 0x06000140 RID: 320 RVA: 0x00006DA4 File Offset: 0x00004FA4
		private void SendSubscription(global::SSLMangrComp.Packets.SubscriptionPacket packet, global::System.Net.IPAddress PNip, int PNport)
		{
			string text = base.GetType().ToString();
			text += ":SendSubscription";
			try
			{
				this.m_UDPConnector.Connect(PNip, PNport);
				this.m_UDPConnector.WriteData(packet.getData());
			}
			catch (global::System.ArgumentException)
			{
				throw new global::IACustomException.IACommonException(global::IACustomException.IACommonErrorCode.SSL_LE_UDPArgumentException)
				{
					Source = text
				};
			}
			catch (global::System.Net.Sockets.SocketException)
			{
				throw new global::IACustomException.IACommonException(global::IACustomException.IACommonErrorCode.SSL_LE_UnableToOpenSocket)
				{
					Source = text
				};
			}
			finally
			{
				this.m_UDPConnector.ShutdownClient();
			}
			packet.IsPacketRecived = false;
			if (this.PacketSentOrRecived != null)
			{
				this.PacketSentOrRecived(packet);
			}
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00006E64 File Offset: 0x00005064
		private void SendSubscription(global::SSLMangrComp.Packets.SubscriptionPacket packet, global::System.Net.IPAddress PNip, int PNport, global::SSLMangrComp.SecureClientConfiguration secureClientConfig, bool disconnectSecureConnection)
		{
			string text = base.GetType().ToString();
			text += ":SendSubscription";
			if (packet.Type == global::SSLMangrComp.Packets.SubscriptionType.Secure && secureClientConfig != null)
			{
				try
				{
					this.m_TLSclientConnector.Connect(PNip, PNport, secureClientConfig);
					this.m_TLSclientConnector.WriteData(packet.getData());
				}
				catch (global::System.Exception)
				{
					throw new global::IACustomException.IACommonException(global::IACustomException.IACommonErrorCode.SSL_TLSClientInternalFailure)
					{
						Source = text
					};
				}
				finally
				{
					this.m_TLSclientConnector.ShutdownClient();
				}
			}
			packet.IsPacketRecived = false;
			if (this.PacketSentOrRecived != null)
			{
				this.PacketSentOrRecived(packet);
			}
		}

		// Token: 0x06000142 RID: 322 RVA: 0x00006F14 File Offset: 0x00005114
		private void handleIncomingPacket(global::SSLMangrComp.Packets.PacketBase pb)
		{
			if (this.PacketSentOrRecived != null)
			{
				this.PacketSentOrRecived(pb);
			}
		}

		// Token: 0x06000143 RID: 323 RVA: 0x00006F2A File Offset: 0x0000512A
		private void handleIncomingError(global::SSLMangrComp.ErrorReport Er)
		{
			if (this.ErrorReceived != null)
			{
				this.ErrorReceived(Er);
			}
		}

		// Token: 0x06000144 RID: 324 RVA: 0x00006F40 File Offset: 0x00005140
		private void StartConnection(global::SSLMangrComp.Packets.SubscriptionType LMMode, global::SSLMangrComp.SecureServerConfiguration secureServerConfig)
		{
			if (secureServerConfig != null)
			{
				this.m_TLSServerListener.StartListner(this.inboundIPAddress, secureServerConfig, LMMode);
			}
			this.m_securePortNumber = this.m_TLSServerListener.getPortNumber();
		}

		// Token: 0x06000145 RID: 325 RVA: 0x00006F6C File Offset: 0x0000516C
		private ushort CreateNewDialogID()
		{
			for (ushort num = 1; num < 65535; num += 1)
			{
				int num2 = 0;
				while (num2 < this.m_activeSubscriptionList.Count && this.m_activeSubscriptionList[num2].DialogID != num)
				{
					num2++;
				}
				if (num2 >= this.m_activeSubscriptionList.Count)
				{
					return num;
				}
			}
			return 0;
		}

		// Token: 0x040000D0 RID: 208
		private global::System.Collections.Generic.List<global::SSLMangrComp.Packets.PacketBase> m_activeSubscriptionList = new global::System.Collections.Generic.List<global::SSLMangrComp.Packets.PacketBase>();

		// Token: 0x040000D1 RID: 209
		private global::System.Collections.Generic.List<ushort> m_dialogIDList = new global::System.Collections.Generic.List<ushort>();

		// Token: 0x040000D2 RID: 210
		private global::SSLMangrComp.Connectors.IClientConnector m_TLSclientConnector = new global::SSLMangrComp.ConnectionLayer.TLSClientConnector();

		// Token: 0x040000D3 RID: 211
		private global::SSLMangrComp.ConnectionLayer.IServerListener m_TLSServerListener = new global::SSLMangrComp.ConnectionLayer.TLSServerListener();

		// Token: 0x040000D4 RID: 212
		private global::SSLMangrComp.ConnectionLayer.IClientServerConnector m_UDPConnector = new global::SSLMangrComp.ConnectionLayer.UDPCConnector();

		// Token: 0x040000D5 RID: 213
		private int m_securePortNumber;

		// Token: 0x040000D6 RID: 214
		private global::System.Net.IPAddress inboundIPAddress = new global::System.Net.IPAddress(new byte[]
		{
			127,
			0,
			0,
			1
		});

		// Token: 0x02000028 RID: 40
		// (Invoke) Token: 0x06000147 RID: 327
		public delegate void PacketSendOrRecievedHandle(global::SSLMangrComp.Packets.PacketBase packet);

		// Token: 0x02000029 RID: 41
		// (Invoke) Token: 0x0600014B RID: 331
		public delegate void ErrorRecievedHandle(global::SSLMangrComp.ErrorReport errorReport);
	}
}
