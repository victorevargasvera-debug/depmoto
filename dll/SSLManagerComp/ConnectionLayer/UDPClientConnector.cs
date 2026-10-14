using System;
using System.Net;
using System.Net.Sockets;
using IACustomException;
using SSLMangrComp.Connectors;

namespace SSLMangrComp.ConnectionLayer
{
	// Token: 0x0200000E RID: 14
	public class UDPClientConnector : global::SSLMangrComp.Connectors.IClientWatcher
	{
		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600005B RID: 91 RVA: 0x00003719 File Offset: 0x00001919
		// (set) Token: 0x0600005C RID: 92 RVA: 0x00003721 File Offset: 0x00001921
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

		// Token: 0x0600005D RID: 93 RVA: 0x0000372A File Offset: 0x0000192A
		public void SetTimeOutVal(int secsTime)
		{
			this.m_TimeOutSpan = new global::System.TimeSpan(0, 0, secsTime);
		}

		// Token: 0x14000009 RID: 9
		// (add) Token: 0x0600005E RID: 94 RVA: 0x0000373C File Offset: 0x0000193C
		// (remove) Token: 0x0600005F RID: 95 RVA: 0x00003774 File Offset: 0x00001974
		public event global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle PacketRecived;

		// Token: 0x1400000A RID: 10
		// (add) Token: 0x06000060 RID: 96 RVA: 0x000037AC File Offset: 0x000019AC
		// (remove) Token: 0x06000061 RID: 97 RVA: 0x000037E4 File Offset: 0x000019E4
		public event global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle ErrorReceived;

		// Token: 0x06000062 RID: 98 RVA: 0x00003819 File Offset: 0x00001A19
		public void Connect(global::System.Net.IPAddress pnIPAddress, int portNumber, global::SSLMangrComp.SecureClientConfiguration clientConfig)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00003820 File Offset: 0x00001A20
		public void Connect(global::SSLMangrComp.PNConnectionInfo connInfo)
		{
			global::System.Net.IPAddress pnIp = connInfo.PNConnectionConfig.PnIp;
			int pnPort = connInfo.PNConnectionConfig.PnPort;
			try
			{
				this.ip = pnIp;
				this.port = pnPort;
				if (this.udp == null)
				{
					this.udp = new global::System.Net.Sockets.UdpClient(global::System.Net.Sockets.AddressFamily.InterNetwork);
				}
			}
			catch (global::System.ArgumentException systemException)
			{
				throw new global::IACustomException.IACommonException(global::IACustomException.IACommonErrorCode.SSL_LE_UDPArgumentException, systemException);
			}
			catch (global::System.Net.Sockets.SocketException systemException2)
			{
				throw new global::IACustomException.IACommonException(global::IACustomException.IACommonErrorCode.SSL_LE_UnableToOpenSocket, systemException2);
			}
		}

		// Token: 0x06000064 RID: 100 RVA: 0x000038A0 File Offset: 0x00001AA0
		public void WriteData(byte[] dataToWrite)
		{
			try
			{
				this.udp.Send(dataToWrite, dataToWrite.Length, this.ip.ToString(), this.port);
			}
			catch (global::System.Exception systemException)
			{
				throw new global::IACustomException.IACommonException(global::IACustomException.IACommonErrorCode.SSL_PE_UDPDataSendFail, systemException);
			}
		}

		// Token: 0x06000065 RID: 101 RVA: 0x000038F0 File Offset: 0x00001AF0
		public int getPortNumber()
		{
			return this.myPort;
		}

		// Token: 0x06000066 RID: 102 RVA: 0x000038F8 File Offset: 0x00001AF8
		public void ShutdownClient()
		{
			if (this.udp != null)
			{
				this.udp.Close();
				this.udp = null;
			}
		}

		// Token: 0x0400002B RID: 43
		private global::System.Net.Sockets.UdpClient udp;

		// Token: 0x0400002C RID: 44
		private global::System.Net.IPAddress ip;

		// Token: 0x0400002D RID: 45
		private int port;

		// Token: 0x0400002E RID: 46
		private int myPort;

		// Token: 0x0400002F RID: 47
		private global::System.TimeSpan m_TimeOutSpan;

		// Token: 0x04000030 RID: 48
		private global::SSLMangrComp.PresenceInfo_CallBack m_pCB;

		// Token: 0x04000031 RID: 49
		private global::SSLMangrComp.ReportOnError_CallBack m_eCB;
	}
}
