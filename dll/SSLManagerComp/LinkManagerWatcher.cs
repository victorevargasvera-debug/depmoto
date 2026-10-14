using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using IACustomException;
using SSLMangrComp.ConnectionLayer;
using SSLMangrComp.Connectors;
using SSLMangrComp.Packets;

namespace SSLMangrComp
{
	// Token: 0x02000012 RID: 18
	public class LinkManagerWatcher
	{
		// Token: 0x1400000F RID: 15
		// (add) Token: 0x06000088 RID: 136 RVA: 0x00004990 File Offset: 0x00002B90
		// (remove) Token: 0x06000089 RID: 137 RVA: 0x000049C8 File Offset: 0x00002BC8
		public event global::SSLMangrComp.LinkManagerWatcher.PacketSendOrRecievedHandle PacketSentOrRecived;

		// Token: 0x14000010 RID: 16
		// (add) Token: 0x0600008A RID: 138 RVA: 0x00004A00 File Offset: 0x00002C00
		// (remove) Token: 0x0600008B RID: 139 RVA: 0x00004A38 File Offset: 0x00002C38
		public event global::SSLMangrComp.LinkManagerWatcher.ErrorRecievedHandle ErrorReceived;

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600008C RID: 140 RVA: 0x00004A6D File Offset: 0x00002C6D
		public global::System.Collections.Generic.List<global::SSLMangrComp.Packets.PacketBase> ActiveSubscriptionList
		{
			get
			{
				return this.m_activeSubscriptionList;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600008D RID: 141 RVA: 0x00004A75 File Offset: 0x00002C75
		// (set) Token: 0x0600008E RID: 142 RVA: 0x00004A7D File Offset: 0x00002C7D
		public global::SSLMangrComp.PNConnectionInfo serverInfo { get; set; }

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600008F RID: 143 RVA: 0x00004A86 File Offset: 0x00002C86
		private global::SSLMangrComp.Packets.SubscriptionType Mode
		{
			get
			{
				return this.serverInfo.PNConnectionConfig.SubscriptionMode;
			}
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00004ADD File Offset: 0x00002CDD
		public void shutDownListen()
		{
			this.m_activeSubscriptionList.Clear();
			if (global::SSLMangrComp.LinkManagerWatcher.serverListener != null && global::SSLMangrComp.LinkManagerWatcher.serverListener.IsServerRunning())
			{
				global::SSLMangrComp.LinkManagerWatcher.serverListener.ShutdownServer();
			}
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00004B08 File Offset: 0x00002D08
		public void Subscribe(string events)
		{
			string str = base.GetType().ToString();
			str += ":Subscribe";
			global::SSLMangrComp.ErrorReport errorReport = default(global::SSLMangrComp.ErrorReport);
			global::SSLMangrComp.Packets.SubscriptionPacket packet = this.CreateSubscription(this.serverInfo.PNConnectionConfig, events);
			try
			{
				this.SendSubscription(packet);
			}
			catch (global::System.ArgumentException)
			{
				errorReport.ErrCat = 200U;
				errorReport.ErrorID = 1066U;
				if (this.ErrorReceived != null)
				{
					this.ErrorReceived(errorReport);
				}
			}
			catch (global::System.Net.Sockets.SocketException)
			{
				errorReport.ErrCat = 200U;
				errorReport.ErrorID = 1065U;
				if (this.ErrorReceived != null)
				{
					this.ErrorReceived(errorReport);
				}
			}
			catch (global::System.Exception)
			{
				errorReport.ErrCat = 200U;
				errorReport.ErrorID = 1055U;
				if (this.ErrorReceived != null)
				{
					this.ErrorReceived(errorReport);
				}
			}
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00004C0C File Offset: 0x00002E0C
		private global::SSLMangrComp.Packets.SubscriptionPacket CreateSubscription(global::SSLMangrComp.ConnectionConfig PNInfo, string events)
		{
			global::SSLMangrComp.Packets.SubscriptionPacket subscriptionPacket = new global::SSLMangrComp.Packets.ReliableSubscriptionPacket(this.CreateNewDialogID(), this._PCPortNumber, PNInfo.Expiration, PNInfo.EntityType, PNInfo.EntityValue, events);
			subscriptionPacket.Type = PNInfo.SubscriptionMode;
			this.m_activeSubscriptionList.Add(subscriptionPacket);
			return subscriptionPacket;
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00004C58 File Offset: 0x00002E58
		public void CancelAllSubscriptions()
		{
			global::System.Collections.Generic.List<global::SSLMangrComp.Packets.PacketBase> list = new global::System.Collections.Generic.List<global::SSLMangrComp.Packets.PacketBase>();
			foreach (global::SSLMangrComp.Packets.PacketBase packetBase in this.m_activeSubscriptionList)
			{
				global::SSLMangrComp.Packets.SubscriptionPacket subscriptionPacket = (global::SSLMangrComp.Packets.SubscriptionPacket)packetBase;
				global::SSLMangrComp.Packets.SubscriptionPacket packet = subscriptionPacket.CreateCancelSubscription();
				this.SendSubscription(packet);
				global::System.Threading.Thread.Sleep(1750);
				list.Add(subscriptionPacket);
			}
			foreach (global::SSLMangrComp.Packets.PacketBase packetBase2 in list)
			{
				global::SSLMangrComp.Packets.SubscriptionPacket item = (global::SSLMangrComp.Packets.SubscriptionPacket)packetBase2;
				this.m_activeSubscriptionList.Remove(item);
			}
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00004D18 File Offset: 0x00002F18
		public void CancelExistingSubscription(global::System.Collections.Generic.List<string> RadioList)
		{
			global::System.Collections.Generic.List<global::SSLMangrComp.Packets.PacketBase> list = new global::System.Collections.Generic.List<global::SSLMangrComp.Packets.PacketBase>();
			foreach (global::SSLMangrComp.Packets.PacketBase packetBase in this.m_activeSubscriptionList)
			{
				global::SSLMangrComp.Packets.SubscriptionPacket subscriptionPacket = (global::SSLMangrComp.Packets.SubscriptionPacket)packetBase;
				if (RadioList.Contains(subscriptionPacket.EntityValue))
				{
					global::SSLMangrComp.Packets.SubscriptionPacket packet = ((global::SSLMangrComp.Packets.ReliableSubscriptionPacket)subscriptionPacket).CreateCancelSubscription();
					this.SendSubscription(packet);
					global::System.Threading.Thread.Sleep(1750);
					list.Add(subscriptionPacket);
				}
			}
			foreach (global::SSLMangrComp.Packets.PacketBase packetBase2 in list)
			{
				global::SSLMangrComp.Packets.SubscriptionPacket item = (global::SSLMangrComp.Packets.SubscriptionPacket)packetBase2;
				this.m_activeSubscriptionList.Remove(item);
			}
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00004DEC File Offset: 0x00002FEC
		private void SendSubscription(global::SSLMangrComp.Packets.SubscriptionPacket packet, global::System.Net.IPAddress PNip, int PNport)
		{
			string str = base.GetType().ToString();
			str += ":SendSubscription";
			try
			{
				this.clientConnector.Connect(this.serverInfo);
				this.clientConnector.WriteData(packet.getData());
			}
			catch (global::System.ArgumentException systemException)
			{
				throw new global::IACustomException.IACommonException(global::IACustomException.IACommonErrorCode.SSL_LE_UDPArgumentException, systemException);
			}
			catch (global::System.Net.Sockets.SocketException systemException2)
			{
				throw new global::IACustomException.IACommonException(global::IACustomException.IACommonErrorCode.SSL_LE_UnableToOpenSocket, systemException2);
			}
			finally
			{
				this.clientConnector.ShutdownClient();
			}
			packet.IsPacketRecived = false;
			if (this.PacketSentOrRecived != null)
			{
				this.PacketSentOrRecived(packet);
			}
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00004EA0 File Offset: 0x000030A0
		public void ClientConnect()
		{
			this.clientConnector.Connect(this.serverInfo);
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00004EB3 File Offset: 0x000030B3
		public void ClientClose()
		{
			this.clientConnector.ShutdownClient();
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00004EC0 File Offset: 0x000030C0
		private void SendSubscription(global::SSLMangrComp.Packets.SubscriptionPacket packet)
		{
			this.clientConnector.WriteData(packet.getData());
			packet.IsPacketRecived = false;
			if (this.PacketSentOrRecived != null)
			{
				this.PacketSentOrRecived(packet);
			}
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00004EEE File Offset: 0x000030EE
		private void handleIncomingPacket(global::SSLMangrComp.Packets.PacketBase pb)
		{
			if (this.PacketSentOrRecived != null)
			{
				this.PacketSentOrRecived(pb);
			}
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00004F04 File Offset: 0x00003104
		private void handleIncomingError(global::SSLMangrComp.ErrorReport Er)
		{
			if (this.ErrorReceived != null)
			{
				this.ErrorReceived(Er);
			}
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00004F1C File Offset: 0x0000311C
		public void StartListener()
		{
			if (this.Mode == global::SSLMangrComp.Packets.SubscriptionType.Secure)
			{
				this.clientConnector = new global::SSLMangrComp.ConnectionLayer.TLSClientWatcher();
				if (global::SSLMangrComp.LinkManagerWatcher.serverListener == null || !global::SSLMangrComp.LinkManagerWatcher.serverListener.IsServerRunning())
				{
					global::SSLMangrComp.LinkManagerWatcher.serverListener = new global::SSLMangrComp.ConnectionLayer.TLSServerWatcher();
					global::SSLMangrComp.LinkManagerWatcher.serverListener.RegisterIncomingPacketHandler(new global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle(this.handleIncomingPacket));
					global::SSLMangrComp.LinkManagerWatcher.serverListener.RegisterIncomingErrorHandler(new global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle(this.handleIncomingError));
				}
			}
			else if (this.Mode == global::SSLMangrComp.Packets.SubscriptionType.Reliable)
			{
				this.clientConnector = new global::SSLMangrComp.ConnectionLayer.UDPClientConnector();
				if (global::SSLMangrComp.LinkManagerWatcher.serverListener == null || !global::SSLMangrComp.LinkManagerWatcher.serverListener.IsServerRunning())
				{
					global::SSLMangrComp.LinkManagerWatcher.serverListener = new global::SSLMangrComp.ConnectionLayer.TCPServerListener();
					global::SSLMangrComp.LinkManagerWatcher.serverListener.RegisterIncomingPacketHandler(new global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle(this.handleIncomingPacket));
					global::SSLMangrComp.LinkManagerWatcher.serverListener.RegisterIncomingErrorHandler(new global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle(this.handleIncomingError));
				}
			}
			if (!global::SSLMangrComp.LinkManagerWatcher.serverListener.IsServerRunning())
			{
				global::SSLMangrComp.LinkManagerWatcher.serverListener.StartListener(this.serverInfo);
			}
			this._PCPortNumber = global::SSLMangrComp.LinkManagerWatcher.serverListener.getPortNumber();
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00005014 File Offset: 0x00003214
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

		// Token: 0x04000048 RID: 72
		private global::System.Collections.Generic.List<global::SSLMangrComp.Packets.PacketBase> m_activeSubscriptionList = new global::System.Collections.Generic.List<global::SSLMangrComp.Packets.PacketBase>();

		// Token: 0x04000049 RID: 73
		private global::System.Collections.Generic.List<ushort> m_dialogIDList = new global::System.Collections.Generic.List<ushort>();

		// Token: 0x0400004A RID: 74
		private global::SSLMangrComp.Connectors.IClientWatcher clientConnector;

		// Token: 0x0400004B RID: 75
		private static global::SSLMangrComp.ConnectionLayer.IServerWatcher serverListener;

		// Token: 0x0400004C RID: 76
		private int _PCPortNumber;

		// Token: 0x0400004D RID: 77
		private global::System.Net.IPAddress inboundIPAddress = new global::System.Net.IPAddress(new byte[]
		{
			127,
			0,
			0,
			1
		});

		// Token: 0x02000013 RID: 19
		// (Invoke) Token: 0x060000A0 RID: 160
		public delegate void PacketSendOrRecievedHandle(global::SSLMangrComp.Packets.PacketBase packet);

		// Token: 0x02000014 RID: 20
		// (Invoke) Token: 0x060000A4 RID: 164
		public delegate void ErrorRecievedHandle(global::SSLMangrComp.ErrorReport errorReport);
	}
}
