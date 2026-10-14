using System;
using System.Net;

namespace Motorola.Common.Communication.RUDP
{
	// Token: 0x0200001F RID: 31
	public class RUDPSocket : global::System.IDisposable
	{
		// Token: 0x06000166 RID: 358 RVA: 0x0000679F File Offset: 0x0000499F
		public RUDPSocket()
		{
			this._rudpConnection = new global::Motorola.Common.Communication.RUDP.RUDPConnection(this);
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06000167 RID: 359 RVA: 0x000067B3 File Offset: 0x000049B3
		public global::Motorola.Common.Communication.RUDP.RUDPSockState State
		{
			get
			{
				return this._rudpConnection.SockState;
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000168 RID: 360 RVA: 0x000067C0 File Offset: 0x000049C0
		// (set) Token: 0x06000169 RID: 361 RVA: 0x000067CD File Offset: 0x000049CD
		private int SendTimeout
		{
			get
			{
				return this._rudpConnection.SendTimeout;
			}
			set
			{
				this._rudpConnection.SendTimeout = value;
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x0600016A RID: 362 RVA: 0x000067DB File Offset: 0x000049DB
		// (set) Token: 0x0600016B RID: 363 RVA: 0x000067E8 File Offset: 0x000049E8
		public int ReceiveTimeout
		{
			private get
			{
				return this._rudpConnection.ReceiveTimeout;
			}
			set
			{
				this._rudpConnection.ReceiveTimeout = value;
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x0600016C RID: 364 RVA: 0x000067F6 File Offset: 0x000049F6
		// (set) Token: 0x0600016D RID: 365 RVA: 0x00006803 File Offset: 0x00004A03
		public int OpenTimeout
		{
			private get
			{
				return this._rudpConnection.OpenTimeout;
			}
			set
			{
				this._rudpConnection.OpenTimeout = value;
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x0600016E RID: 366 RVA: 0x00006811 File Offset: 0x00004A11
		// (set) Token: 0x0600016F RID: 367 RVA: 0x0000681E File Offset: 0x00004A1E
		private int CloseTimeout
		{
			get
			{
				return this._rudpConnection.CloseTimeout;
			}
			set
			{
				this._rudpConnection.CloseTimeout = value;
			}
		}

		// Token: 0x06000170 RID: 368 RVA: 0x0000682C File Offset: 0x00004A2C
		private static int Listen()
		{
			return 1;
		}

		// Token: 0x06000171 RID: 369 RVA: 0x0000682F File Offset: 0x00004A2F
		private static int Bind()
		{
			return 1;
		}

		// Token: 0x06000172 RID: 370 RVA: 0x00006832 File Offset: 0x00004A32
		private static int Accept()
		{
			return 1;
		}

		// Token: 0x06000173 RID: 371 RVA: 0x00006838 File Offset: 0x00004A38
		public global::Motorola.Common.Communication.RUDP.RUDPReplyResult Connect(global::System.Net.IPAddress ipAddr, int port)
		{
			if (this._rudpConnection != null)
			{
				global::System.IAsyncResult result = this._rudpConnection.BeginConnect(ipAddr, port, null, null);
				return this._rudpConnection.EndConnect(result);
			}
			return global::Motorola.Common.Communication.RUDP.RUDPReplyResult.RUDPReply_Uninitialized;
		}

		// Token: 0x06000174 RID: 372 RVA: 0x00006870 File Offset: 0x00004A70
		public int Send(byte[] buffer, int offset, int size, out global::Motorola.Common.Communication.RUDP.RUDPReplyResult result)
		{
			int result2 = 0;
			result = global::Motorola.Common.Communication.RUDP.RUDPReplyResult.RUDPReply_Success;
			if (this._rudpConnection != null)
			{
				try
				{
					global::System.IAsyncResult result3 = this._rudpConnection.BeginSend(buffer, offset, size, null, null);
					return this._rudpConnection.EndSend(result3);
				}
				catch (global::System.Exception)
				{
					result = global::Motorola.Common.Communication.RUDP.RUDPReplyResult.RUDPReply_SendFailed;
					return result2;
				}
			}
			result = global::Motorola.Common.Communication.RUDP.RUDPReplyResult.RUDPReply_Uninitialized;
			return result2;
		}

		// Token: 0x06000175 RID: 373 RVA: 0x000068C8 File Offset: 0x00004AC8
		public byte[] Receive(out global::Motorola.Common.Communication.RUDP.RUDPReplyResult result)
		{
			byte[] result2 = null;
			result = global::Motorola.Common.Communication.RUDP.RUDPReplyResult.RUDPReply_Success;
			if (this._rudpConnection != null)
			{
				try
				{
					global::System.IAsyncResult result3 = this._rudpConnection.BeginReceive(null, null);
					object obj = this._rudpConnection.EndReceive(result3);
					byte[] array;
					if (obj is int)
					{
						result = global::Motorola.Common.Communication.RUDP.RUDPReplyResult.RUDPReply_ReceiveTimeout;
					}
					else if ((array = (obj as byte[])) != null)
					{
						result2 = array;
					}
					return result2;
				}
				catch (global::System.Exception)
				{
					result = global::Motorola.Common.Communication.RUDP.RUDPReplyResult.RUDPReply_ReceiveFailed;
					return result2;
				}
			}
			result = global::Motorola.Common.Communication.RUDP.RUDPReplyResult.RUDPReply_Uninitialized;
			return result2;
		}

		// Token: 0x06000176 RID: 374 RVA: 0x00006934 File Offset: 0x00004B34
		private int Receive(byte[] buffer, int offset, int size, out global::Motorola.Common.Communication.RUDP.RUDPReplyResult result)
		{
			int result2 = 0;
			result = global::Motorola.Common.Communication.RUDP.RUDPReplyResult.RUDPReply_Success;
			if (this._rudpConnection != null)
			{
				try
				{
					global::System.IAsyncResult result3 = this._rudpConnection.BeginReceive(buffer, offset, size, null, null);
					return (int)this._rudpConnection.EndReceive(result3);
				}
				catch (global::System.Exception)
				{
					result = global::Motorola.Common.Communication.RUDP.RUDPReplyResult.RUDPReply_ReceiveFailed;
					return result2;
				}
			}
			result = global::Motorola.Common.Communication.RUDP.RUDPReplyResult.RUDPReply_Uninitialized;
			return result2;
		}

		// Token: 0x06000177 RID: 375 RVA: 0x00006990 File Offset: 0x00004B90
		public global::Motorola.Common.Communication.RUDP.RUDPReplyResult Close()
		{
			if (this._rudpConnection != null)
			{
				global::Motorola.Common.Communication.RUDP.RUDPReplyResult result;
				if (this.State == global::Motorola.Common.Communication.RUDP.RUDPSockState.CLOSE)
				{
					result = global::Motorola.Common.Communication.RUDP.RUDPReplyResult.RUDPReply_Success;
				}
				else if (this.State == global::Motorola.Common.Communication.RUDP.RUDPSockState.CLOSE_WAIT)
				{
					result = global::Motorola.Common.Communication.RUDP.RUDPReplyResult.RUDPReply_CloseInProgress;
				}
				else
				{
					global::System.IAsyncResult result2 = this._rudpConnection.BeginClose(null, null);
					result = this._rudpConnection.EndClose(result2);
				}
				return result;
			}
			return global::Motorola.Common.Communication.RUDP.RUDPReplyResult.RUDPReply_Uninitialized;
		}

		// Token: 0x06000178 RID: 376 RVA: 0x000069E2 File Offset: 0x00004BE2
		public global::Motorola.Common.Communication.RUDP.RUDPReplyResult SetSocketOpt(global::Motorola.Common.Communication.RUDP.RUDPConfigParams configParams)
		{
			if (this._rudpConnection != null)
			{
				return this._rudpConnection.SetRUDPSocketOpt(configParams);
			}
			return global::Motorola.Common.Communication.RUDP.RUDPReplyResult.RUDPReply_Uninitialized;
		}

		// Token: 0x06000179 RID: 377 RVA: 0x000069FA File Offset: 0x00004BFA
		private global::Motorola.Common.Communication.RUDP.RUDPConfigParams GetSocketOpt()
		{
			return this._rudpConnection.ConfigParams;
		}

		// Token: 0x0600017A RID: 378 RVA: 0x00006A07 File Offset: 0x00004C07
		protected virtual void Dispose(bool disposing)
		{
			if (!this.m_IsDisposed)
			{
				this.m_IsDisposed = true;
			}
		}

		// Token: 0x0600017B RID: 379 RVA: 0x00006A1A File Offset: 0x00004C1A
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x040000D7 RID: 215
		private global::Motorola.Common.Communication.RUDP.RUDPConnection _rudpConnection;

		// Token: 0x040000D8 RID: 216
		private bool m_IsDisposed;
	}
}
