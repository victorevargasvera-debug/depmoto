using System;
using System.Net;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.RUDP;
using Motorola.Common.CustomException;
using VerifyUtility;

namespace Motorola.Common.Communication.CommunicationPipe
{
	// Token: 0x0200000C RID: 12
	public class RUDPCommPipe : global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe, global::System.IDisposable
	{
		// Token: 0x0600008B RID: 139 RVA: 0x000036A3 File Offset: 0x000018A3
		static RUDPCommPipe()
		{
			global::VerifyUtility.AssemblyValidator.IsCallerAuthorized();
		}

		// Token: 0x0600008C RID: 140 RVA: 0x000036AC File Offset: 0x000018AC
		public RUDPCommPipe(global::System.Net.IPAddress ipAddress, int portNumber, string configFilePath, int receiveTimeout = 5000)
		{
			if (portNumber < 0 || portNumber > 65535)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentOutOfRange);
			}
			this.m_IPAddress = ipAddress;
			this.m_PortNumber = portNumber;
			this.ReceiveTimeout = receiveTimeout;
			this.m_RudpSocket = new global::Motorola.Common.Communication.RUDP.RUDPSocket();
			this.m_configFilePath = configFilePath;
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600008D RID: 141 RVA: 0x000036FA File Offset: 0x000018FA
		// (set) Token: 0x0600008E RID: 142 RVA: 0x00003702 File Offset: 0x00001902
		public int ReceiveTimeout { get; set; }

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600008F RID: 143 RVA: 0x0000370B File Offset: 0x0000190B
		// (set) Token: 0x06000090 RID: 144 RVA: 0x00003713 File Offset: 0x00001913
		public bool IsOpen { get; set; }

		// Token: 0x06000091 RID: 145 RVA: 0x0000371C File Offset: 0x0000191C
		public void OpenPort(int timeout)
		{
			if (this.m_RudpSocket.State == global::Motorola.Common.Communication.RUDP.RUDPSockState.OPEN)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeAlreadyOpened);
			}
			this.m_rudpConfigParams = new global::Motorola.Common.Communication.RUDP.RUDPConfigParams();
			try
			{
				this.m_rudpConfigParams.LoadConfig(this.m_configFilePath);
				this.m_RudpSocket.SetSocketOpt(this.m_rudpConfigParams);
				this.m_RudpSocket.OpenTimeout = timeout;
				this.m_RudpReply = this.m_RudpSocket.Connect(this.m_IPAddress, this.m_PortNumber);
				if (this.m_RudpReply != global::Motorola.Common.Communication.RUDP.RUDPReplyResult.RUDPReply_Success)
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeOpenComPortFailure);
				}
			}
			catch (global::System.Exception systemException)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeOpenFailure, systemException);
			}
			this.IsOpen = true;
		}

		// Token: 0x06000092 RID: 146 RVA: 0x000037D4 File Offset: 0x000019D4
		public void ClosePort()
		{
			if (this.m_RudpSocket != null)
			{
				this.m_RudpSocket.Close();
				this.m_RudpSocket = null;
			}
			this.IsOpen = false;
		}

		// Token: 0x06000093 RID: 147 RVA: 0x000037F8 File Offset: 0x000019F8
		public void SendData(byte[] buffer, int start, int length)
		{
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(this.m_RudpSocket, global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeNotOpened);
			try
			{
				int num = this.m_RudpSocket.Send(buffer, start, length, out this.m_RudpReply);
				if (num != length || this.m_RudpReply != global::Motorola.Common.Communication.RUDP.RUDPReplyResult.RUDPReply_Success)
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeWriteFailure);
				}
			}
			catch (global::System.Exception systemException)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeWriteFailure, systemException);
			}
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00003860 File Offset: 0x00001A60
		public byte[] ReceiveData()
		{
			byte[] result = this.m_RudpSocket.Receive(out this.m_RudpReply);
			if (this.m_RudpReply != global::Motorola.Common.Communication.RUDP.RUDPReplyResult.RUDPReply_Success)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeReadFailure);
			}
			return result;
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00003894 File Offset: 0x00001A94
		public byte[] ReceiveData(int timeout)
		{
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(this.m_RudpSocket, global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeNotOpened);
			if (this.m_rudpConfigParams.ConnectivityParameters.ReceiveTimeout > timeout)
			{
				this.m_RudpSocket.ReceiveTimeout = this.m_rudpConfigParams.ConnectivityParameters.ReceiveTimeout;
			}
			else
			{
				this.m_RudpSocket.ReceiveTimeout = timeout;
			}
			return this.ReceiveData();
		}

		// Token: 0x06000096 RID: 150 RVA: 0x000038F3 File Offset: 0x00001AF3
		public int ReceiveData(byte[] buffer, int start)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000097 RID: 151 RVA: 0x000038FA File Offset: 0x00001AFA
		public int ReceiveData(byte[] buffer, int start, int timeout)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00003901 File Offset: 0x00001B01
		public int ReceiveData(byte[] buffer, int start, int timeout, int expectedlength)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00003908 File Offset: 0x00001B08
		public byte[] RequestData(byte[] buffer, int start, int length)
		{
			this.SendData(buffer, start, length);
			return this.ReceiveData();
		}

		// Token: 0x0600009A RID: 154 RVA: 0x0000391C File Offset: 0x00001B1C
		public byte[] RequestData(byte[] buffer, int start, int length, int timeout)
		{
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(buffer, global::Motorola.Common.CustomException.CommonErrorCode.InvalidArgument);
			if (this.m_rudpConfigParams.ConnectivityParameters.ReceiveTimeout > timeout)
			{
				this.m_RudpSocket.ReceiveTimeout = this.m_rudpConfigParams.ConnectivityParameters.ReceiveTimeout;
			}
			else
			{
				this.m_RudpSocket.ReceiveTimeout = timeout;
			}
			this.SendData(buffer, start, length);
			return this.ReceiveData();
		}

		// Token: 0x0600009B RID: 155 RVA: 0x0000397D File Offset: 0x00001B7D
		public byte[] PeekData(int length, int timeOut)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600009C RID: 156 RVA: 0x00003984 File Offset: 0x00001B84
		public int AvailableReadBytesCount
		{
			get
			{
				throw new global::System.NotSupportedException();
			}
		}

		// Token: 0x0600009D RID: 157 RVA: 0x0000398B File Offset: 0x00001B8B
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x0600009E RID: 158 RVA: 0x0000399A File Offset: 0x00001B9A
		protected virtual void Dispose(bool isDisposing)
		{
			if (!this.m_IsDisposed)
			{
				if (isDisposing)
				{
					this.ClosePort();
				}
				this.m_IsDisposed = true;
			}
		}

		// Token: 0x0400004A RID: 74
		private global::System.Net.IPAddress m_IPAddress;

		// Token: 0x0400004B RID: 75
		private int m_PortNumber;

		// Token: 0x0400004C RID: 76
		private global::Motorola.Common.Communication.RUDP.RUDPSocket m_RudpSocket;

		// Token: 0x0400004D RID: 77
		private global::Motorola.Common.Communication.RUDP.RUDPReplyResult m_RudpReply;

		// Token: 0x0400004E RID: 78
		private global::Motorola.Common.Communication.RUDP.RUDPConfigParams m_rudpConfigParams;

		// Token: 0x0400004F RID: 79
		private string m_configFilePath;

		// Token: 0x04000050 RID: 80
		private bool m_IsDisposed;
	}
}
