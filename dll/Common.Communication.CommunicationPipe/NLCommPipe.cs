using System;
using System.Diagnostics;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.CommunicationPipe
{
	// Token: 0x02000012 RID: 18
	public class NLCommPipe : global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe, global::System.IDisposable
	{
		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000109 RID: 265 RVA: 0x00004C84 File Offset: 0x00002E84
		public global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe LowerPipe
		{
			get
			{
				return this.m_CommPipe;
			}
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00004C8C File Offset: 0x00002E8C
		public NLCommPipe(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe commPipe, global::Motorola.Common.Communication.CommunicationPipe.Constants.NLOptions Options, int brdcastTimeout = 100, int defaultTimeout = 100, int additionalAckTimeout = 400, int brdcastPollTimer = 50)
		{
			if (commPipe == null)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_NLWrapper_Invalid_Argument);
			}
			this.m_CommPipe = commPipe;
			this.nlOption = Options;
			if (Options == global::Motorola.Common.Communication.CommunicationPipe.Constants.NLOptions.XNL_TRANSPORT)
			{
				this.m_NL = new global::Motorola.Common.Communication.Xnl();
			}
			else
			{
				if (Options != global::Motorola.Common.Communication.CommunicationPipe.Constants.NLOptions.RNL_TRANSPORT)
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_NLWrapper_InValid_Option);
				}
				this.m_NL = new global::Motorola.Common.Communication.Rnl();
			}
			this.BrdcastTimeout = brdcastTimeout;
			this.DefaultTimeout = defaultTimeout;
			this.AdditionalAckTimeout = additionalAckTimeout;
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00004D18 File Offset: 0x00002F18
		~NLCommPipe()
		{
			this.Dispose(false);
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x0600010C RID: 268 RVA: 0x00004D48 File Offset: 0x00002F48
		// (set) Token: 0x0600010D RID: 269 RVA: 0x00004D55 File Offset: 0x00002F55
		public int ReceiveTimeout
		{
			get
			{
				return this.m_CommPipe.ReceiveTimeout;
			}
			set
			{
				this.m_CommPipe.ReceiveTimeout = value;
			}
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00004D64 File Offset: 0x00002F64
		public void OpenPort(int timeout)
		{
			int num = 0;
			global::Motorola.Common.Communication.Xnl.SetTimer(this.DefaultTimeout, this.AdditionalAckTimeout);
			while (!this.Connected && num < 3)
			{
				try
				{
					this.m_NL.Connect(this.m_CommPipe);
					this.Connected = true;
				}
				catch (global::Motorola.Common.CustomException.CommonException ex)
				{
					if (ex.ErrorCode == global::Motorola.Common.CustomException.CommonErrorCode.CommunicationXnlAlreadyConnected)
					{
						this.Connected = true;
					}
					else
					{
						global::System.Diagnostics.Trace.WriteLine(ex);
						this.m_NL.Disconnect();
						num++;
					}
				}
			}
			if (!this.Connected)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_NLWrapper_Open_Failed);
			}
			this.IsOpen = true;
		}

		// Token: 0x0600010F RID: 271 RVA: 0x00004E04 File Offset: 0x00003004
		public void ClosePort()
		{
			if (this.Connected)
			{
				this.m_NL.Disconnect();
			}
			this.Connected = false;
			this.IsOpen = false;
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00004E27 File Offset: 0x00003027
		public byte[] ReceiveData()
		{
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.NotImplemented);
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00004E2F File Offset: 0x0000302F
		public byte[] ReceiveData(int timeout)
		{
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.NotImplemented);
		}

		// Token: 0x06000112 RID: 274 RVA: 0x00004E37 File Offset: 0x00003037
		public int ReceiveData(byte[] buffer, int start, int timeout)
		{
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.NotImplemented);
		}

		// Token: 0x06000113 RID: 275 RVA: 0x00004E3F File Offset: 0x0000303F
		public byte[] PeekData(int length, int timeOut)
		{
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.NotImplemented);
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000114 RID: 276 RVA: 0x00004E47 File Offset: 0x00003047
		public int AvailableReadBytesCount
		{
			get
			{
				throw new global::System.NotSupportedException();
			}
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00004E4E File Offset: 0x0000304E
		public int ReceiveData(byte[] buffer, int start)
		{
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.NotImplemented);
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00004E56 File Offset: 0x00003056
		public int ReceiveData(byte[] buffer, int start, int timeout, int expectedlength)
		{
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.NotImplemented);
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00004E60 File Offset: 0x00003060
		public byte[] RequestData(byte[] buffer, int start, int length, int timeout)
		{
			if (buffer == null)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_NLWrapper_Invalid_Argument);
			}
			if (length <= 0 || start + length > buffer.Length)
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteWarning("NLCommPipe: buffer length<{0}> error!!!", new object[]
				{
					length
				});
			}
			int num = 0;
			bool flag = false;
			this.XNLTransactionID = 0;
			while (num <= 3 && !flag)
			{
				try
				{
					lock (buffer.SyncRoot)
					{
						this.XNLTransactionID = this.m_NL.SendDataMessage(buffer, length);
						flag = true;
					}
				}
				catch (global::System.Exception arg)
				{
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("Exception in NLWrapper::SendDataMessage: " + arg, new object[0]);
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("Tx: Len={0} {1}", new object[]
					{
						length,
						global::Motorola.Common.Communication.CommonUtil.UtilityMethods.ToHexString(buffer, start, length, false)
					});
					num++;
				}
			}
			if (!flag)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_NLWrapper_Send_Fail);
			}
			lock (this.receiveBuffer.SyncRoot)
			{
				try
				{
					this.receiveBuffer = this.m_NL.ReceiveDataMessage(timeout, this.XNLTransactionID);
				}
				catch (global::System.Exception arg2)
				{
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("Exception in NLWrapper::ReceiveDataMessage: " + arg2, new object[0]);
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("Tx: Len={0} {1}", new object[]
					{
						length,
						global::Motorola.Common.Communication.CommonUtil.UtilityMethods.ToHexString(buffer, start, length, false)
					});
					throw;
				}
			}
			return this.receiveBuffer;
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00005028 File Offset: 0x00003228
		public byte[] RequestData(byte[] buffer, int start, int length)
		{
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.NotImplemented);
		}

		// Token: 0x06000119 RID: 281 RVA: 0x00005030 File Offset: 0x00003230
		public void SendData(byte[] buffer, int start, int length)
		{
			if (buffer == null)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_NLWrapper_Invalid_Argument);
			}
			if (length <= 0 || start + length > buffer.Length)
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteWarning("NLCommPipe: buffer length<{0}> error!!!", new object[]
				{
					length
				});
			}
			int num = 0;
			bool flag = false;
			this.XNLTransactionID = 0;
			while (num <= 3 && !flag)
			{
				try
				{
					lock (buffer.SyncRoot)
					{
						this.XNLTransactionID = this.m_NL.SendBroadcastDataMessage(buffer, length);
						flag = true;
					}
				}
				catch (global::System.Exception arg)
				{
					global::System.Diagnostics.Trace.WriteLine("Exception in NLWrapper::RequestData: " + arg);
					num++;
				}
			}
			if (!flag)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_NLWrapper_Send_Fail);
			}
		}

		// Token: 0x0600011A RID: 282 RVA: 0x00005108 File Offset: 0x00003308
		public void SetBroadcastPollPeriod(int brdcastPollTimer)
		{
			this.BrdcastPollTimer = brdcastPollTimer;
			this.m_NL.SetBroadcastPollPeriod(brdcastPollTimer);
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x0600011B RID: 283 RVA: 0x0000511D File Offset: 0x0000331D
		// (set) Token: 0x0600011C RID: 284 RVA: 0x00005125 File Offset: 0x00003325
		public bool IsOpen { get; set; }

		// Token: 0x0600011D RID: 285 RVA: 0x0000512E File Offset: 0x0000332E
		public bool IsDualBoard()
		{
			return this.m_NL.IsDualBoard();
		}

		// Token: 0x0600011E RID: 286 RVA: 0x0000513B File Offset: 0x0000333B
		public void SetTargetBoard(global::Motorola.Common.Communication.TargetBoard targetBoard)
		{
			this.m_NL.SetTargetBoard(targetBoard);
		}

		// Token: 0x0600011F RID: 287 RVA: 0x00005149 File Offset: 0x00003349
		public void RegisterBroadcastMessageListener(global::Motorola.Common.Communication.RnlBroadcastMessageEventHandler BroadcastDataMessageReceived)
		{
			if (this.nlOption == global::Motorola.Common.Communication.CommunicationPipe.Constants.NLOptions.RNL_TRANSPORT)
			{
				(this.m_NL as global::Motorola.Common.Communication.Rnl).RegisterBroadcastMessageListener(BroadcastDataMessageReceived);
			}
		}

		// Token: 0x06000120 RID: 288 RVA: 0x00005165 File Offset: 0x00003365
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00005174 File Offset: 0x00003374
		protected virtual void Dispose(bool isDisposing)
		{
			if (!this.m_IsDisposed)
			{
				if (isDisposing)
				{
					this.ClosePort();
					global::System.IDisposable nl = this.m_NL;
					if (nl != null)
					{
						nl.Dispose();
					}
				}
				this.m_IsDisposed = true;
			}
		}

		// Token: 0x04000071 RID: 113
		private global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe m_CommPipe;

		// Token: 0x04000072 RID: 114
		private int BrdcastTimeout;

		// Token: 0x04000073 RID: 115
		private int DefaultTimeout;

		// Token: 0x04000074 RID: 116
		private int AdditionalAckTimeout;

		// Token: 0x04000075 RID: 117
		private int BrdcastPollTimer;

		// Token: 0x04000076 RID: 118
		private bool Connected;

		// Token: 0x04000077 RID: 119
		private ushort XNLTransactionID;

		// Token: 0x04000078 RID: 120
		private byte[] receiveBuffer = new byte[65535];

		// Token: 0x04000079 RID: 121
		private global::Motorola.Common.Communication.Xnl m_NL;

		// Token: 0x0400007A RID: 122
		private global::Motorola.Common.Communication.CommunicationPipe.Constants.NLOptions nlOption = global::Motorola.Common.Communication.CommunicationPipe.Constants.NLOptions.XNL_TRANSPORT;

		// Token: 0x0400007B RID: 123
		private bool m_IsDisposed;
	}
}
