using System;
using System.Net;
using System.Net.Sockets;
using System.Security;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.CustomException;
using VerifyUtility;

namespace Motorola.Common.Communication.CommunicationPipe
{
	// Token: 0x0200001B RID: 27
	public class UdpCommPipe : global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe, global::System.IDisposable
	{
		// Token: 0x06000176 RID: 374 RVA: 0x000063F4 File Offset: 0x000045F4
		static UdpCommPipe()
		{
			global::VerifyUtility.AssemblyValidator.IsCallerAuthorized();
		}

		// Token: 0x06000177 RID: 375 RVA: 0x000063FC File Offset: 0x000045FC
		public UdpCommPipe(int localPortNumber, int remotePortNumber, global::System.Net.IPAddress remoteIPAddress, int receiveTimeout)
		{
			if (remotePortNumber < 0 || remotePortNumber > 65535)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentOutOfRange);
			}
			if (localPortNumber < 0 || localPortNumber > 65535)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentOutOfRange);
			}
			this.m_localPortNumber = localPortNumber;
			this.m_remotePortNumber = remotePortNumber;
			this.m_remoteIPAddress = remoteIPAddress;
			this.ReceiveTimeout = receiveTimeout;
		}

		// Token: 0x06000178 RID: 376 RVA: 0x00006452 File Offset: 0x00004652
		public UdpCommPipe(int localPortNumber, int remotePortNumber, global::System.Net.IPAddress remoteIPAddress) : this(localPortNumber, remotePortNumber, remoteIPAddress, 2000)
		{
		}

		// Token: 0x06000179 RID: 377 RVA: 0x00006462 File Offset: 0x00004662
		public UdpCommPipe(int remotePortNumber, global::System.Net.IPAddress remoteIPAddress) : this(0, remotePortNumber, remoteIPAddress, 2000)
		{
		}

		// Token: 0x0600017A RID: 378 RVA: 0x00006472 File Offset: 0x00004672
		public UdpCommPipe(int remotePortNumber, global::System.Net.IPAddress remoteIPAddress, int receiveTimeout) : this(0, remotePortNumber, remoteIPAddress, receiveTimeout)
		{
		}

		// Token: 0x0600017B RID: 379 RVA: 0x00006480 File Offset: 0x00004680
		~UdpCommPipe()
		{
			this.Dispose(false);
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x0600017C RID: 380 RVA: 0x000064B0 File Offset: 0x000046B0
		// (set) Token: 0x0600017D RID: 381 RVA: 0x000064B8 File Offset: 0x000046B8
		public int ReceiveTimeout { get; set; }

		// Token: 0x0600017E RID: 382 RVA: 0x000064C4 File Offset: 0x000046C4
		public void OpenPort(int timeout)
		{
			if (this.m_UdpClient != null)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeAlreadyOpened);
			}
			try
			{
				this.m_UdpClient = new global::System.Net.Sockets.UdpClient(this.m_localPortNumber);
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("Open UDP local port for Fxp Comm: " + ((global::System.Net.IPEndPoint)this.m_UdpClient.Client.LocalEndPoint).Port.ToString(), new object[0]);
				if (this.m_remoteIPAddress != global::System.Net.IPAddress.Any)
				{
					this.m_UdpClient.Connect(this.m_remoteIPAddress, this.m_remotePortNumber);
				}
			}
			catch (global::System.Net.Sockets.SocketException systemException)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeOpenFailure, systemException);
			}
			this.IsOpen = true;
		}

		// Token: 0x0600017F RID: 383 RVA: 0x0000657C File Offset: 0x0000477C
		public void ClosePort()
		{
			if (this.m_UdpClient != null)
			{
				this.m_UdpClient.Close();
				this.m_UdpClient = null;
			}
			this.IsOpen = false;
		}

		// Token: 0x06000180 RID: 384 RVA: 0x000065A0 File Offset: 0x000047A0
		public void SendData(byte[] buffer, int start, int length)
		{
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(this.m_UdpClient, global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeNotOpened);
			byte[] array = new byte[length];
			global::System.Buffer.BlockCopy(buffer, start, array, 0, length);
			try
			{
				this.m_UdpClient.Send(array, length);
			}
			catch (global::System.Net.Sockets.SocketException systemException)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeWriteFailure, systemException);
			}
		}

		// Token: 0x06000181 RID: 385 RVA: 0x000065FC File Offset: 0x000047FC
		public void SendDataTo(byte[] buffer, int start, int length, global::System.Net.IPEndPoint targetEndPoint)
		{
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(this.m_UdpClient, global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeNotOpened);
			byte[] array = new byte[length];
			global::System.Buffer.BlockCopy(buffer, start, array, 0, length);
			try
			{
				this.m_UdpClient.Send(array, length, targetEndPoint);
			}
			catch (global::System.Net.Sockets.SocketException systemException)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeWriteFailure, systemException);
			}
		}

		// Token: 0x06000182 RID: 386 RVA: 0x0000665C File Offset: 0x0000485C
		public byte[] ReceiveDataFrom(int timeout, ref global::System.Net.IPEndPoint sourceIPEndPoint)
		{
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(this.m_UdpClient, global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeNotOpened);
			byte[] result = null;
			int receiveTimeout = this.m_UdpClient.Client.ReceiveTimeout;
			try
			{
				this.m_UdpClient.Client.ReceiveTimeout = timeout;
				result = this.m_UdpClient.Receive(ref sourceIPEndPoint);
			}
			catch (global::System.Exception ex)
			{
				global::System.Net.Sockets.SocketException ex2 = ex as global::System.Net.Sockets.SocketException;
				if (ex2 != null && ex2.SocketErrorCode == global::System.Net.Sockets.SocketError.TimedOut)
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeReadTimeout, ex);
				}
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeReadFailure, ex);
			}
			finally
			{
				this.m_UdpClient.Client.ReceiveTimeout = receiveTimeout;
			}
			return result;
		}

		// Token: 0x06000183 RID: 387 RVA: 0x00006710 File Offset: 0x00004910
		public byte[] ReceiveDataFrom(ref global::System.Net.IPEndPoint sourceIPEndPoint)
		{
			byte[] result;
			try
			{
				result = this.m_UdpClient.Receive(ref sourceIPEndPoint);
			}
			catch (global::System.Net.Sockets.SocketException systemException)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeReadFailure, systemException);
			}
			return result;
		}

		// Token: 0x06000184 RID: 388 RVA: 0x0000674C File Offset: 0x0000494C
		public byte[] ReceiveDataFrom(int timeout)
		{
			byte[] result;
			try
			{
				this.m_UdpClient.Client.ReceiveTimeout = timeout;
				global::System.Net.IPEndPoint ipendPoint = new global::System.Net.IPEndPoint(global::System.Net.IPAddress.Any, 0);
				result = this.m_UdpClient.Receive(ref ipendPoint);
			}
			catch (global::System.Net.Sockets.SocketException systemException)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeReadFailure, systemException);
			}
			return result;
		}

		// Token: 0x06000185 RID: 389 RVA: 0x000067A4 File Offset: 0x000049A4
		public byte[] ReceiveData()
		{
			return this.ReceiveData(this.ReceiveTimeout);
		}

		// Token: 0x06000186 RID: 390 RVA: 0x000067B4 File Offset: 0x000049B4
		public byte[] ReceiveData(int timeout)
		{
			global::System.Net.IPEndPoint ipendPoint = new global::System.Net.IPEndPoint(this.m_remoteIPAddress, this.m_remotePortNumber);
			byte[] result = this.ReceiveDataFrom(timeout, ref ipendPoint);
			if (ipendPoint.Address.Equals(this.m_remoteIPAddress) && ipendPoint.Port == this.m_remotePortNumber)
			{
				return result;
			}
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeUnexpectedIncomingData);
		}

		// Token: 0x06000187 RID: 391 RVA: 0x0000680A File Offset: 0x00004A0A
		public int ReceiveData(byte[] buffer, int start)
		{
			return this.ReceiveData(buffer, start, this.ReceiveTimeout);
		}

		// Token: 0x06000188 RID: 392 RVA: 0x0000681C File Offset: 0x00004A1C
		public int ReceiveData(byte[] buffer, int start, int timeout)
		{
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(this.m_UdpClient, global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeNotOpened);
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(buffer, global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
			byte[] array = this.ReceiveData(timeout);
			if (start < 0 || array.Length > buffer.Length - start)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentOutOfRange);
			}
			global::System.Buffer.BlockCopy(array, 0, buffer, start, array.Length);
			return array.Length;
		}

		// Token: 0x06000189 RID: 393 RVA: 0x0000686C File Offset: 0x00004A6C
		public int ReceiveData(byte[] buffer, int start, int timeout, int expectedlength)
		{
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.NotImplemented);
		}

		// Token: 0x0600018A RID: 394 RVA: 0x00006874 File Offset: 0x00004A74
		public byte[] RequestData(byte[] buffer, int start, int length)
		{
			return this.RequestData(buffer, start, length, this.ReceiveTimeout);
		}

		// Token: 0x0600018B RID: 395 RVA: 0x00006885 File Offset: 0x00004A85
		public byte[] RequestData(byte[] buffer, int start, int length, int timeout)
		{
			this.SendData(buffer, start, length);
			return this.ReceiveData(timeout);
		}

		// Token: 0x0600018C RID: 396 RVA: 0x00006898 File Offset: 0x00004A98
		public byte[] PeekData(int length, int timeOut)
		{
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(this.m_UdpClient, global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeNotOpened);
			byte[] result;
			try
			{
				byte[] array = new byte[length];
				this.m_UdpClient.Client.Receive(array, length, global::System.Net.Sockets.SocketFlags.Peek);
				result = array;
			}
			catch (global::System.ArgumentOutOfRangeException systemException)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentOutOfRange, systemException);
			}
			catch (global::System.Net.Sockets.SocketException systemException2)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipePeekFailure, systemException2);
			}
			catch (global::System.Security.SecurityException systemException3)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipePeekFailure, systemException3);
			}
			return result;
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x0600018D RID: 397 RVA: 0x00006924 File Offset: 0x00004B24
		public int AvailableReadBytesCount
		{
			get
			{
				return this.m_UdpClient.Available;
			}
		}

		// Token: 0x0600018E RID: 398 RVA: 0x00006931 File Offset: 0x00004B31
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x0600018F RID: 399 RVA: 0x00006940 File Offset: 0x00004B40
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

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000190 RID: 400 RVA: 0x0000695A File Offset: 0x00004B5A
		// (set) Token: 0x06000191 RID: 401 RVA: 0x00006962 File Offset: 0x00004B62
		public bool IsOpen { get; set; }

		// Token: 0x040000B3 RID: 179
		private int m_localPortNumber;

		// Token: 0x040000B4 RID: 180
		private int m_remotePortNumber;

		// Token: 0x040000B5 RID: 181
		private global::System.Net.IPAddress m_remoteIPAddress;

		// Token: 0x040000B6 RID: 182
		private global::System.Net.Sockets.UdpClient m_UdpClient;

		// Token: 0x040000B7 RID: 183
		private bool m_IsDisposed;
	}
}
