using System;
using System.Net;
using System.Net.Sockets;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.RUDP
{
	// Token: 0x02000007 RID: 7
	internal class RawSocketWrapper
	{
		// Token: 0x06000023 RID: 35 RVA: 0x000025A4 File Offset: 0x000007A4
		public RawSocketWrapper()
		{
			try
			{
				this._socket = new global::System.Net.Sockets.Socket(global::System.Net.Sockets.AddressFamily.InterNetwork, global::System.Net.Sockets.SocketType.Dgram, global::System.Net.Sockets.ProtocolType.Udp);
				this._socket.DontFragment = true;
				this._socket.SetSocketOption(global::System.Net.Sockets.SocketOptionLevel.Socket, global::System.Net.Sockets.SocketOptionName.ReceiveBuffer, (int)global::Motorola.Common.Communication.RUDP.RUDPConstants.RUDP_RECV_BUFF_SIZE);
				this._socket.SetSocketOption(global::System.Net.Sockets.SocketOptionLevel.Socket, global::System.Net.Sockets.SocketOptionName.SendBuffer, (int)global::Motorola.Common.Communication.RUDP.RUDPConstants.RUDP_SEND_BUFF_SIZE);
			}
			catch (global::System.Exception)
			{
				this._socket.Close();
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RUDP_RawSocketCreationFailed);
			}
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002630 File Offset: 0x00000830
		public int SendTo(byte[] buffer, int offset, int size, global::System.Net.Sockets.SocketFlags socketFlags, global::System.Net.EndPoint remoteEP)
		{
			int result = -1;
			try
			{
				result = this._socket.SendTo(buffer, offset, size, socketFlags, remoteEP);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("RUDP Tx Error: " + ex.Message, new object[0]);
			}
			return result;
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002688 File Offset: 0x00000888
		public int ReceiveFrom(byte[] buffer, int offset, int size, global::System.Net.Sockets.SocketFlags socketFlags, ref global::System.Net.EndPoint remoteEP)
		{
			int result = -1;
			try
			{
				result = this._socket.ReceiveFrom(buffer, offset, size, socketFlags, ref remoteEP);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("RUDP Rx Error: " + ex.Message, new object[0]);
			}
			return result;
		}

		// Token: 0x06000026 RID: 38 RVA: 0x000026E0 File Offset: 0x000008E0
		public global::System.IAsyncResult BeginReceiveFrom(byte[] buffer, int offset, int size, global::System.Net.Sockets.SocketFlags socketFlags, ref global::System.Net.EndPoint remoteEP, global::System.AsyncCallback callback, object state)
		{
			global::System.IAsyncResult result = null;
			try
			{
				result = this._socket.BeginReceiveFrom(buffer, offset, size, socketFlags, ref remoteEP, callback, state);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("RUDP Async Start Rx Error: " + ex.Message, new object[0]);
			}
			return result;
		}

		// Token: 0x06000027 RID: 39 RVA: 0x0000273C File Offset: 0x0000093C
		public int EndReceiveFrom(global::System.IAsyncResult asyncResult, ref global::System.Net.EndPoint endPoint)
		{
			int result = 0;
			try
			{
				result = this._socket.EndReceiveFrom(asyncResult, ref endPoint);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("RUDP Async End Rx Error: " + ex.Message, new object[0]);
			}
			return result;
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002790 File Offset: 0x00000990
		public void Shutdown()
		{
			if (this._socket != null)
			{
				this._socket.Close();
				this._socket.Dispose();
				this._socket = null;
			}
		}

		// Token: 0x04000020 RID: 32
		private global::System.Net.Sockets.Socket _socket;
	}
}
