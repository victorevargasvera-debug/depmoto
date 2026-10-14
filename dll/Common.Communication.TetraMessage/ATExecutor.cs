using System;
using System.Collections.Generic;
using System.Threading;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.Communication.TetraUtility;
using Motorola.Common.LogUtility;

namespace Motorola.Common.Communication
{
	// Token: 0x02000004 RID: 4
	public class ATExecutor : global::Motorola.Common.Communication.IMessageExecutor, global::System.IDisposable
	{
		// Token: 0x0600002A RID: 42 RVA: 0x00002820 File Offset: 0x00000A20
		public ATExecutor(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe commPipe)
		{
			this.CommPipe = commPipe;
			this._bLargeBuffer = false;
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002841 File Offset: 0x00000A41
		public ATExecutor()
		{
			this.CommPipe = null;
		}

		// Token: 0x0600002C RID: 44 RVA: 0x0000285C File Offset: 0x00000A5C
		~ATExecutor()
		{
			this.Dispose(false);
		}

		// Token: 0x0600002D RID: 45 RVA: 0x0000288C File Offset: 0x00000A8C
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x0600002E RID: 46 RVA: 0x0000289C File Offset: 0x00000A9C
		protected virtual void Dispose(bool disposing)
		{
			if (!this._disposed)
			{
				try
				{
				}
				finally
				{
					this._disposed = true;
				}
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600002F RID: 47 RVA: 0x000028D0 File Offset: 0x00000AD0
		// (set) Token: 0x06000030 RID: 48 RVA: 0x000028E2 File Offset: 0x00000AE2
		public global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe CommPipe
		{
			get
			{
				if (this._myCommPipe != null)
				{
					return this._myCommPipe;
				}
				return null;
			}
			set
			{
				if (value is global::Motorola.Common.Communication.CommunicationPipe.TetraCommPipe)
				{
					this._myCommPipe = (value as global::Motorola.Common.Communication.CommunicationPipe.TetraCommPipe);
					this._bHaveTransport = true;
				}
			}
		}

		// Token: 0x06000031 RID: 49 RVA: 0x000028FF File Offset: 0x00000AFF
		public void Setup()
		{
			if (this._bHaveTransport)
			{
				this._myCommPipe.OpenPort();
			}
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002915 File Offset: 0x00000B15
		public void TearDown()
		{
			if (this._bHaveTransport)
			{
				this._myCommPipe.ClosePort();
			}
		}

		// Token: 0x06000033 RID: 51 RVA: 0x0000292C File Offset: 0x00000B2C
		public void SendAndReceiveMessage(global::Motorola.Common.Communication.IMessage msg)
		{
			byte[] array = null;
			byte[] array2 = null;
			int num = msg.BuildCommandMessage(array);
			bool bHaveCommand = num > 0;
			this.SendRequest(bHaveCommand, array, msg.hasReply, out array2, 0);
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00002960 File Offset: 0x00000B60
		public void SetRxTimeoutTimer(int timeout)
		{
			if (this._bHaveTransport)
			{
				this._myCommPipe.ReadTimeout = timeout;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000035 RID: 53 RVA: 0x00002976 File Offset: 0x00000B76
		// (set) Token: 0x06000036 RID: 54 RVA: 0x0000298D File Offset: 0x00000B8D
		public int WriteTimeout
		{
			get
			{
				if (this._bHaveTransport)
				{
					return this._myCommPipe.WriteTimeout;
				}
				return 0;
			}
			set
			{
				if (this._bHaveTransport)
				{
					this._myCommPipe.WriteTimeout = value;
				}
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000037 RID: 55 RVA: 0x000029A3 File Offset: 0x00000BA3
		// (set) Token: 0x06000038 RID: 56 RVA: 0x000029BA File Offset: 0x00000BBA
		public int ReadTimeout
		{
			get
			{
				if (this._bHaveTransport)
				{
					return this._myCommPipe.ReadTimeout;
				}
				return 0;
			}
			set
			{
				if (this._bHaveTransport)
				{
					this._myCommPipe.ReadTimeout = value;
				}
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000039 RID: 57 RVA: 0x000029D0 File Offset: 0x00000BD0
		// (set) Token: 0x0600003A RID: 58 RVA: 0x000029E2 File Offset: 0x00000BE2
		public global::Motorola.Common.Communication.CommunicationPipe.TetraCommPipe TransportPipe
		{
			get
			{
				if (this._bHaveTransport)
				{
					return this._myCommPipe;
				}
				return null;
			}
			set
			{
				this._myCommPipe = value;
				if (value != null)
				{
					this._bHaveTransport = true;
				}
			}
		}

		// Token: 0x0600003B RID: 59 RVA: 0x000029F5 File Offset: 0x00000BF5
		public bool OpenPort()
		{
			return this._bHaveTransport && this._myCommPipe.OpenPort();
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002A0C File Offset: 0x00000C0C
		public void ClosePort()
		{
			if (this._bHaveTransport)
			{
				this._myCommPipe.ClosePort();
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600003D RID: 61 RVA: 0x00002A21 File Offset: 0x00000C21
		// (set) Token: 0x0600003E RID: 62 RVA: 0x00002A29 File Offset: 0x00000C29
		public bool UseLargeBuffer
		{
			get
			{
				return this._bLargeBuffer;
			}
			set
			{
				this._bLargeBuffer = value;
			}
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00002A32 File Offset: 0x00000C32
		public global::Motorola.Common.Communication.TetraMsgOpResult SendAndReceiveMessage(bool bHaveCommand, byte[] sendMsgBuffer, bool bHaveReply, byte[] receiveMsgBuffer)
		{
			return this.SendRequest(bHaveCommand, sendMsgBuffer, bHaveReply, out receiveMsgBuffer);
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00002A3F File Offset: 0x00000C3F
		public global::Motorola.Common.Communication.TetraMsgOpResult SendRequest(bool bHaveCommand, byte[] msgBuffer, bool bHaveReply, out byte[] replyMessage)
		{
			return this.SendRequest(bHaveCommand, msgBuffer, bHaveReply, out replyMessage, 0);
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00002A50 File Offset: 0x00000C50
		public global::Motorola.Common.Communication.TetraMsgOpResult SendRequest(bool bHaveCommand, byte[] msgBuffer, bool bHaveReply, out byte[] replyMessage, int delayTime)
		{
			global::Motorola.Common.LogUtility.LoggerUtil.SetTimeStampLabel("ATExecutor.SendRequest");
			global::Motorola.Common.Communication.TetraMsgOpResult tetraMsgOpResult = global::Motorola.Common.Communication.TetraMsgOpResult.AT_SUCCESS;
			bool flag = true;
			replyMessage = null;
			if (!this._bHaveTransport)
			{
				tetraMsgOpResult = global::Motorola.Common.Communication.TetraMsgOpResult.AT_NONE_COMM_PIPE;
				flag = false;
			}
			if (bHaveCommand)
			{
				if (bHaveCommand && msgBuffer == null)
				{
					tetraMsgOpResult = global::Motorola.Common.Communication.TetraMsgOpResult.AT_WRONG_PARAMETER;
					flag = false;
				}
				if (flag)
				{
					this._myCommPipe.PurgeInputBuffer();
					this._myCommPipe.PurgeOutputBuffer();
				}
				if (flag)
				{
					tetraMsgOpResult = this.SendMessage(msgBuffer, msgBuffer.Length, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.MIN_WAIT_TIME);
					if (tetraMsgOpResult != global::Motorola.Common.Communication.TetraMsgOpResult.AT_SUCCESS)
					{
						flag = false;
					}
				}
			}
			if (flag && bHaveReply)
			{
				global::System.Threading.Thread.Sleep(delayTime);
				tetraMsgOpResult = this.ReceiveMessage(out replyMessage, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.MIN_WAIT_TIME);
			}
			global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.RP_PERFORMANCE_LOGGER_NAME).Performance("ATExecutor.SendRequest", "");
			return tetraMsgOpResult;
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00002AF4 File Offset: 0x00000CF4
		private global::Motorola.Common.Communication.TetraMsgOpResult SendMessage(byte[] data, int nLength, int timeout)
		{
			global::Motorola.Common.Communication.TetraMsgOpResult result = global::Motorola.Common.Communication.TetraMsgOpResult.Undefined;
			bool flag = true;
			if (data == null)
			{
				flag = false;
				result = global::Motorola.Common.Communication.TetraMsgOpResult.AT_WRONG_PARAMETER;
			}
			if (nLength > data.Length)
			{
				flag = false;
				result = global::Motorola.Common.Communication.TetraMsgOpResult.AT_WRONG_PARAMETER;
			}
			if (!this._bHaveTransport)
			{
				flag = false;
				result = global::Motorola.Common.Communication.TetraMsgOpResult.AT_NONE_COMM_PIPE;
			}
			if (flag)
			{
				this._myCommPipe.WriteTimeout = timeout;
				if (flag)
				{
					int num = this._myCommPipe.SendData(data, 0, nLength);
					if (num != nLength)
					{
						result = ((num < 0) ? global::Motorola.Common.Communication.TetraMsgOpResult.AT_WRITE_COMM_ERROR : global::Motorola.Common.Communication.TetraMsgOpResult.AT_WRITE_TIMEOUT);
					}
					else
					{
						result = global::Motorola.Common.Communication.TetraMsgOpResult.AT_SUCCESS;
					}
				}
			}
			return result;
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00002B60 File Offset: 0x00000D60
		private global::Motorola.Common.Communication.TetraMsgOpResult ReceiveMessage(out byte[] msgBuffer, int timeout)
		{
			global::Motorola.Common.Communication.TetraMsgOpResult result = global::Motorola.Common.Communication.TetraMsgOpResult.AT_SUCCESS;
			bool flag = true;
			int default_BUFFER_SIZE = this.DEFAULT_BUFFER_SIZE;
			msgBuffer = new byte[default_BUFFER_SIZE];
			if (!this._bHaveTransport)
			{
				flag = false;
				result = global::Motorola.Common.Communication.TetraMsgOpResult.AT_NONE_COMM_PIPE;
			}
			if (flag)
			{
				this._myCommPipe.ReadTimeout = timeout;
				int num = this._myCommPipe.ReceiveDataOnce(msgBuffer, 0);
				if (num == 0)
				{
					result = global::Motorola.Common.Communication.TetraMsgOpResult.AT_READ_TIMEOUT;
				}
				else if (num < 0)
				{
					result = global::Motorola.Common.Communication.TetraMsgOpResult.AT_RECEIVE_MESSAGE_ERROR;
				}
				else if (this._bLargeBuffer)
				{
					global::System.Collections.Generic.List<byte> list = new global::System.Collections.Generic.List<byte>();
					for (int i = 0; i < num; i++)
					{
						list.Add(msgBuffer[i]);
					}
					for (;;)
					{
						msgBuffer = new byte[default_BUFFER_SIZE];
						num = this._myCommPipe.ReceiveDataOnce(msgBuffer, 0);
						if (num <= 0)
						{
							break;
						}
						for (int j = 0; j < num; j++)
						{
							list.Add(msgBuffer[j]);
						}
					}
					msgBuffer = list.ToArray();
				}
				else if (num < default_BUFFER_SIZE)
				{
					byte[] array = new byte[num];
					global::System.Array.Copy(msgBuffer, array, num);
					msgBuffer = array;
				}
			}
			return result;
		}

		// Token: 0x04000010 RID: 16
		private global::Motorola.Common.Communication.CommunicationPipe.TetraCommPipe _myCommPipe;

		// Token: 0x04000011 RID: 17
		private bool _bHaveTransport;

		// Token: 0x04000012 RID: 18
		private bool _bLargeBuffer;

		// Token: 0x04000013 RID: 19
		private readonly int DEFAULT_BUFFER_SIZE = 2000;

		// Token: 0x04000014 RID: 20
		private bool _disposed;
	}
}
