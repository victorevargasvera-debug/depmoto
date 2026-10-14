using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using SSLMangrComp.Packets;

namespace SSLMangrComp.ConnectionLayer
{
	// Token: 0x0200000B RID: 11
	public class ServerBase
	{
		// Token: 0x06000042 RID: 66 RVA: 0x00002F91 File Offset: 0x00001191
		public void StartListener(int port)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00002F98 File Offset: 0x00001198
		public bool IsServerRunning()
		{
			return !this.m_stop;
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00002FA4 File Offset: 0x000011A4
		public void SignalCloseStream()
		{
			lock (this.m_shutdownLock)
			{
				this._signalCloseStream = true;
			}
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00002FE8 File Offset: 0x000011E8
		public int getPortNumber()
		{
			if (!this.IsServerRunning())
			{
				return 0;
			}
			if (!(this.m_listener.LocalEndpoint is global::System.Net.IPEndPoint))
			{
				return 0;
			}
			return ((global::System.Net.IPEndPoint)this.m_listener.LocalEndpoint).Port;
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00003020 File Offset: 0x00001220
		public void ShutdownServer()
		{
			lock (this.m_shutdownLock)
			{
				if (this.IsServerRunning())
				{
					this.m_stop = true;
					foreach (global::SSLMangrComp.ConnectionLayer.IServerWorker serverWorker in this.readWorkers)
					{
						if (serverWorker != null)
						{
							serverWorker.Close();
						}
					}
					global::System.Threading.Thread.Sleep(500);
					if (this.m_listener != null)
					{
						this.m_listener.Stop();
					}
					this._lsnrThread = null;
				}
			}
		}

		// Token: 0x04000019 RID: 25
		protected bool m_stop = true;

		// Token: 0x0400001A RID: 26
		protected bool _signalCloseStream;

		// Token: 0x0400001B RID: 27
		protected global::System.Threading.Thread _lsnrThread;

		// Token: 0x0400001C RID: 28
		protected global::System.Net.Sockets.TcpListener m_listener;

		// Token: 0x0400001D RID: 29
		protected global::System.Net.IPAddress m_pnIPAddress;

		// Token: 0x0400001E RID: 30
		protected global::SSLMangrComp.Packets.SubscriptionType m_LMode;

		// Token: 0x0400001F RID: 31
		protected object m_shutdownLock = new object();

		// Token: 0x04000020 RID: 32
		protected object m_listenLock = new object();

		// Token: 0x04000021 RID: 33
		protected object packetLock = new object();

		// Token: 0x04000022 RID: 34
		protected object errorLock = new object();

		// Token: 0x04000023 RID: 35
		protected global::SSLMangrComp.PNConnectionInfo serverInfo;

		// Token: 0x04000024 RID: 36
		protected global::System.Collections.Generic.List<global::SSLMangrComp.ConnectionLayer.IServerWorker> readWorkers = new global::System.Collections.Generic.List<global::SSLMangrComp.ConnectionLayer.IServerWorker>();
	}
}
