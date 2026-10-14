using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using SSLMangrComp.Packets;

namespace SSLMangrComp.ConnectionLayer
{
	// Token: 0x0200000C RID: 12
	internal class TCPServerListener : global::SSLMangrComp.ConnectionLayer.ServerBase, global::SSLMangrComp.ConnectionLayer.IServerWatcher
	{
		// Token: 0x14000005 RID: 5
		// (add) Token: 0x06000048 RID: 72 RVA: 0x00003128 File Offset: 0x00001328
		// (remove) Token: 0x06000049 RID: 73 RVA: 0x00003160 File Offset: 0x00001360
		public event global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle PacketRecived;

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x0600004A RID: 74 RVA: 0x00003198 File Offset: 0x00001398
		// (remove) Token: 0x0600004B RID: 75 RVA: 0x000031D0 File Offset: 0x000013D0
		public event global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle ErrorReceived;

		// Token: 0x0600004C RID: 76 RVA: 0x00003205 File Offset: 0x00001405
		public new void StartListener(int port)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600004D RID: 77 RVA: 0x0000320C File Offset: 0x0000140C
		public void StartListener(global::SSLMangrComp.PNConnectionInfo connInfo)
		{
			this.serverInfo = connInfo;
			base.ShutdownServer();
			this._lsnrThread = new global::System.Threading.Thread(new global::System.Threading.ThreadStart(this.Listen));
			this._lsnrThread.Start();
			global::System.Threading.Thread.Sleep(500);
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00003248 File Offset: 0x00001448
		private void Listen()
		{
			global::SSLMangrComp.ErrorReport error = default(global::SSLMangrComp.ErrorReport);
			string str = base.GetType().ToString();
			str += ":Listen";
			try
			{
				lock (this.m_listenLock)
				{
					this.m_stop = false;
					this.m_listener = new global::System.Net.Sockets.TcpListener(global::System.Net.IPAddress.Any, 0);
					this.m_listener.Start(20);
					while (!this.m_stop)
					{
						global::System.Net.Sockets.TcpClient client = this.m_listener.AcceptTcpClient();
						global::System.Threading.Thread.Sleep(500);
						global::SSLMangrComp.ConnectionLayer.TCPWorker tcpworker = new global::SSLMangrComp.ConnectionLayer.TCPWorker(client);
						tcpworker.ReadPacketReceived += this.OnWorkerPacket;
						global::System.Threading.Thread thread = new global::System.Threading.Thread(new global::System.Threading.ThreadStart(tcpworker.Read));
						thread.Start();
						this.readWorkers.Add(tcpworker);
					}
					this.m_listener.Stop();
				}
			}
			catch (global::System.Exception ex)
			{
				if (ex is global::System.Net.Sockets.SocketException)
				{
					global::System.Net.Sockets.SocketException ex2 = (global::System.Net.Sockets.SocketException)ex;
					if (ex2.ErrorCode == 10004)
					{
						return;
					}
				}
				error.ErrCat = 200U;
				if (this.ErrorReceived != null)
				{
					this.ErrorReceived(error);
				}
				base.ShutdownServer();
			}
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00003394 File Offset: 0x00001594
		public void RegisterIncomingPacketHandler(global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle hdl)
		{
			this.PacketRecived += hdl;
		}

		// Token: 0x06000050 RID: 80 RVA: 0x0000339D File Offset: 0x0000159D
		public void RegisterIncomingErrorHandler(global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle hdl)
		{
			this.ErrorReceived += hdl;
		}

		// Token: 0x06000051 RID: 81 RVA: 0x000033A8 File Offset: 0x000015A8
		protected void OnWorkerPacket(global::SSLMangrComp.Packets.PacketBase packet)
		{
			lock (this.packetLock)
			{
				if (this.PacketRecived != null)
				{
					this.PacketRecived(packet);
				}
			}
		}

		// Token: 0x06000052 RID: 82 RVA: 0x000033F8 File Offset: 0x000015F8
		protected void OnErrorReceived(global::SSLMangrComp.ErrorReport error)
		{
			lock (this.errorLock)
			{
				if (this.ErrorReceived != null)
				{
					this.ErrorReceived(error);
				}
			}
		}
	}
}
