using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using IACustomException;
using SSLMangrComp.Connectors;
using SSLMangrComp.Packets;

namespace SSLMangrComp.ConnectionLayer
{
	// Token: 0x02000006 RID: 6
	public class UDPCConnector : global::SSLMangrComp.ConnectionLayer.IClientServerConnector, global::SSLMangrComp.Connectors.IClientConnector, global::SSLMangrComp.ConnectionLayer.IServerListener
	{
		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000010 RID: 16 RVA: 0x000020EF File Offset: 0x000002EF
		// (set) Token: 0x06000011 RID: 17 RVA: 0x000020F7 File Offset: 0x000002F7
		public global::SSLMangrComp.ReportOnError_CallBack ErrorCallback
		{
			get
			{
				return this.m_eCB;
			}
			set
			{
				this.m_eCB = value;
			}
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002100 File Offset: 0x00000300
		public void SetTimeOutVal(int secsTime)
		{
			this.m_TimeOutSpan = new global::System.TimeSpan(0, 0, secsTime);
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000013 RID: 19 RVA: 0x00002110 File Offset: 0x00000310
		// (remove) Token: 0x06000014 RID: 20 RVA: 0x00002148 File Offset: 0x00000348
		public event global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle PacketRecived;

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x06000015 RID: 21 RVA: 0x00002180 File Offset: 0x00000380
		// (remove) Token: 0x06000016 RID: 22 RVA: 0x000021B8 File Offset: 0x000003B8
		public event global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle ErrorReceived;

		// Token: 0x06000017 RID: 23 RVA: 0x000021ED File Offset: 0x000003ED
		public void ShutdownServer()
		{
			this.stop = true;
			if (this.udp != null)
			{
				this.udp.Close();
			}
			this.lsnrThread = null;
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002210 File Offset: 0x00000410
		public void StartListner(global::System.Net.IPAddress pnIPAddress, global::SSLMangrComp.SecureServerConfiguration secureServerConfiguration, global::SSLMangrComp.Packets.SubscriptionType mode)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002218 File Offset: 0x00000418
		public void StartListner(int portNo)
		{
			this.stop = false;
			this.myPort = portNo;
			this.lsnrThread = new global::System.Threading.Thread(new global::System.Threading.ThreadStart(this.Listen));
			this.lsnrThread.Start();
			this.lsnrThread.Name = "UDPPacketListenerThread";
			global::System.Threading.Thread.Sleep(2000);
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002270 File Offset: 0x00000470
		public void HandlePackage(object o)
		{
			global::SSLMangrComp.ErrorReport error = default(global::SSLMangrComp.ErrorReport);
			try
			{
				byte[] data = (byte[])o;
				if (this.PacketRecived != null)
				{
					global::SSLMangrComp.Packets.PacketBase packet = global::SSLMangrComp.Packets.PacketFactory.GetPacket(data, 0);
					packet.IsPacketRecived = true;
					this.PacketRecived(packet);
				}
			}
			catch
			{
				error.ErrCat = 300U;
				error.ErrorID = 1072U;
				if (this.ErrorReceived != null)
				{
					this.ErrorReceived(error);
				}
			}
		}

		// Token: 0x0600001B RID: 27 RVA: 0x000022F0 File Offset: 0x000004F0
		private void Listen()
		{
			global::SSLMangrComp.ErrorReport error = default(global::SSLMangrComp.ErrorReport);
			string text = base.GetType().ToString();
			text += ":Listen";
			new global::System.Threading.AutoResetEvent(false);
			global::System.DateTime now = global::System.DateTime.Now;
			this.udp = new global::System.Net.Sockets.UdpClient(this.myPort);
			global::System.Net.IPEndPoint ipendPoint = new global::System.Net.IPEndPoint(global::System.Net.IPAddress.Any, 0);
			while (!this.stop)
			{
				try
				{
					byte[] o = this.udp.Receive(ref ipendPoint);
					this.HandlePackage(o);
					global::System.TimeSpan t = global::System.DateTime.Now.Subtract(now);
					if (t >= this.m_TimeOutSpan)
					{
						throw new global::IACustomException.IACommonException(global::IACustomException.IACommonErrorCode.SSL_PE_PackageTimeout)
						{
							Source = text
						};
					}
					this.ShutdownServer();
				}
				catch (global::IACustomException.IACommonException)
				{
					error.ErrCat = 300U;
					error.ErrorID = 1073U;
					if (this.ErrorReceived != null)
					{
						this.ErrorReceived(error);
					}
				}
				catch (global::System.Exception)
				{
					error.ErrCat = 300U;
					error.ErrorID = 1072U;
					if (this.ErrorReceived != null)
					{
						this.ErrorReceived(error);
					}
				}
				finally
				{
					this.ShutdownServer();
				}
			}
		}

		// Token: 0x0600001C RID: 28 RVA: 0x0000243C File Offset: 0x0000063C
		public void Connect(global::System.Net.IPAddress pnIPAddress, int portNumber, global::SSLMangrComp.SecureClientConfiguration clientConfig)
		{
			global::SSLMangrComp.ErrorReport error = default(global::SSLMangrComp.ErrorReport);
			string str = base.GetType().ToString();
			str += ":Connect";
			try
			{
				this.Connect(pnIPAddress, portNumber);
			}
			catch (global::System.ArgumentException)
			{
				error.ErrCat = 200U;
				error.ErrorID = 1066U;
				if (this.ErrorReceived != null)
				{
					this.ErrorReceived(error);
				}
			}
			catch (global::System.Net.Sockets.SocketException)
			{
				error.ErrCat = 200U;
				error.ErrorID = 1065U;
				if (this.ErrorReceived != null)
				{
					this.ErrorReceived(error);
				}
			}
		}

		// Token: 0x0600001D RID: 29 RVA: 0x000024F0 File Offset: 0x000006F0
		public void Connect(global::System.Net.IPAddress pnIPAddress, int portNumber)
		{
			global::SSLMangrComp.ErrorReport error = default(global::SSLMangrComp.ErrorReport);
			string str = base.GetType().ToString();
			str += ":Connect";
			try
			{
				this.ip = pnIPAddress;
				this.port = portNumber;
				if (this.udp == null)
				{
					this.udp = new global::System.Net.Sockets.UdpClient(global::System.Net.Sockets.AddressFamily.InterNetwork);
				}
			}
			catch (global::System.ArgumentException)
			{
				error.ErrCat = 200U;
				error.ErrorID = 1066U;
				if (this.ErrorReceived != null)
				{
					this.ErrorReceived(error);
				}
			}
			catch (global::System.Net.Sockets.SocketException)
			{
				error.ErrCat = 200U;
				error.ErrorID = 1065U;
				if (this.ErrorReceived != null)
				{
					this.ErrorReceived(error);
				}
			}
		}

		// Token: 0x0600001E RID: 30 RVA: 0x000025BC File Offset: 0x000007BC
		public void WriteData(byte[] dataToWrite)
		{
			try
			{
				this.udp.Send(dataToWrite, dataToWrite.Length, this.ip.ToString(), this.port);
			}
			catch
			{
				global::SSLMangrComp.ErrorReport error = default(global::SSLMangrComp.ErrorReport);
				error.ErrCat = 300U;
				error.ErrorID = 1071U;
				if (this.ErrorReceived != null)
				{
					this.ErrorReceived(error);
				}
			}
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002634 File Offset: 0x00000834
		public bool IsServerRunning()
		{
			return !this.stop;
		}

		// Token: 0x06000020 RID: 32 RVA: 0x0000263F File Offset: 0x0000083F
		public int getPortNumber()
		{
			return this.myPort;
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002647 File Offset: 0x00000847
		public void ShutdownClient()
		{
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002649 File Offset: 0x00000849
		public void RegisterIncomingPacketHandler(global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle hdl)
		{
			this.PacketRecived += hdl;
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002652 File Offset: 0x00000852
		public void RegisterIncomingErrorHandler(global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle hdl)
		{
			this.ErrorReceived += hdl;
		}

		// Token: 0x04000002 RID: 2
		private global::System.Net.Sockets.UdpClient udp;

		// Token: 0x04000003 RID: 3
		private global::System.Net.IPAddress ip;

		// Token: 0x04000004 RID: 4
		private int port;

		// Token: 0x04000005 RID: 5
		private int myPort;

		// Token: 0x04000006 RID: 6
		private bool stop;

		// Token: 0x04000007 RID: 7
		private global::System.Threading.Thread lsnrThread;

		// Token: 0x04000008 RID: 8
		private global::System.TimeSpan m_TimeOutSpan;

		// Token: 0x04000009 RID: 9
		private global::SSLMangrComp.PresenceInfo_CallBack m_pCB;

		// Token: 0x0400000A RID: 10
		private global::SSLMangrComp.ReportOnError_CallBack m_eCB;
	}
}
