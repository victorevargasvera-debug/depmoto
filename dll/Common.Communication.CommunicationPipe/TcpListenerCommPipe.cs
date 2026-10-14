using System;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using Motorola.Common.Communication.PCRRemoteProgramming;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.CommunicationPipe
{
	// Token: 0x0200001A RID: 26
	public class TcpListenerCommPipe : global::Motorola.Common.Communication.CommunicationPipe.TcpCommPipe
	{
		// Token: 0x1700004C RID: 76
		// (get) Token: 0x0600016A RID: 362 RVA: 0x000061DC File Offset: 0x000043DC
		// (set) Token: 0x0600016B RID: 363 RVA: 0x000061E4 File Offset: 0x000043E4
		private global::System.Net.IPAddress LocalIPAddress { get; set; }

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x0600016C RID: 364 RVA: 0x000061ED File Offset: 0x000043ED
		// (set) Token: 0x0600016D RID: 365 RVA: 0x000061F5 File Offset: 0x000043F5
		internal int LocalPortNumber { get; private set; }

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x0600016E RID: 366 RVA: 0x000061FE File Offset: 0x000043FE
		// (set) Token: 0x0600016F RID: 367 RVA: 0x00006206 File Offset: 0x00004406
		private global::System.Net.Sockets.TcpListener TCPListener { get; set; }

		// Token: 0x06000170 RID: 368 RVA: 0x0000620F File Offset: 0x0000440F
		public TcpListenerCommPipe(global::System.Net.IPAddress ipAddress, int portNumber, int receiveTimeout)
		{
			if (portNumber < 0 || portNumber > 65535)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentOutOfRange);
			}
			this.LocalIPAddress = ipAddress;
			this.LocalPortNumber = portNumber;
			base.ReceiveTimeout = receiveTimeout;
		}

		// Token: 0x06000171 RID: 369 RVA: 0x0000623F File Offset: 0x0000443F
		public TcpListenerCommPipe(global::System.Net.IPAddress ipAddress, int portNumber) : this(ipAddress, portNumber, 2000)
		{
		}

		// Token: 0x06000172 RID: 370 RVA: 0x0000624E File Offset: 0x0000444E
		public override void OpenPort(int timeout)
		{
			if (this.TCPListener != null || base.Client != null || base.Stream != null)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeAlreadyOpened);
			}
			this.Listen();
			this.Accept(timeout);
			this.IsOpen = true;
		}

		// Token: 0x06000173 RID: 371 RVA: 0x00006288 File Offset: 0x00004488
		internal void Listen()
		{
			try
			{
				if (this.LocalIPAddress == null)
				{
					this.LocalIPAddress = global::System.Net.IPAddress.Any;
				}
				this.TCPListener = new global::System.Net.Sockets.TcpListener(this.LocalIPAddress, this.LocalPortNumber);
				this.TCPListener.Start();
				global::System.Diagnostics.Trace.WriteLine("TCP Listening Port : " + this.LocalPortNumber);
			}
			catch (global::System.Net.Sockets.SocketException systemException)
			{
				global::Motorola.Common.Communication.PCRRemoteProgramming.TCPPortManager.Instance.Release(this.LocalPortNumber);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeOpenFailure, systemException);
			}
		}

		// Token: 0x06000174 RID: 372 RVA: 0x00006314 File Offset: 0x00004514
		internal void Accept(int timeout)
		{
			try
			{
				global::System.IAsyncResult asyncResult = this.TCPListener.BeginAcceptTcpClient(null, null);
				if (!asyncResult.AsyncWaitHandle.WaitOne(timeout))
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeOpenTimeout);
				}
				base.Client = this.TCPListener.EndAcceptTcpClient(asyncResult);
				base.Stream = base.Client.GetStream();
				global::System.Diagnostics.Trace.WriteLine("TCP Listener Accepted connection.");
			}
			catch (global::System.Net.Sockets.SocketException systemException)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeOpenFailure, systemException);
			}
		}

		// Token: 0x06000175 RID: 373 RVA: 0x00006398 File Offset: 0x00004598
		public override void ClosePort()
		{
			base.ClosePort();
			if (this.TCPListener != null)
			{
				try
				{
					this.TCPListener.Stop();
					global::Motorola.Common.Communication.PCRRemoteProgramming.TCPPortManager.Instance.Release(this.LocalPortNumber);
				}
				catch (global::System.Net.Sockets.SocketException systemException)
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeCloseFailure, systemException);
				}
				this.TCPListener = null;
			}
		}
	}
}
