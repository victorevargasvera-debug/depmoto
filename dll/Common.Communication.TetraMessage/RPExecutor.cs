using System;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.Communication.TetraUtility;
using Motorola.Common.LogUtility;

namespace Motorola.Common.Communication
{
	// Token: 0x02000013 RID: 19
	public class RPExecutor : global::Motorola.Common.Communication.IMessageExecutor, global::System.IDisposable
	{
		// Token: 0x060000AF RID: 175 RVA: 0x0000517F File Offset: 0x0000337F
		public RPExecutor(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe commPipe)
		{
			this.CommPipe = commPipe;
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x0000518E File Offset: 0x0000338E
		public RPExecutor()
		{
			this.CommPipe = null;
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x000051A0 File Offset: 0x000033A0
		~RPExecutor()
		{
			this.Dispose(false);
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x000051D0 File Offset: 0x000033D0
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x000051E0 File Offset: 0x000033E0
		protected virtual void Dispose(bool disposing)
		{
			if (this._disposed)
			{
				return;
			}
			try
			{
			}
			finally
			{
				this._disposed = true;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000B4 RID: 180 RVA: 0x00005214 File Offset: 0x00003414
		// (set) Token: 0x060000B5 RID: 181 RVA: 0x00005226 File Offset: 0x00003426
		public global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe CommPipe
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
				if (value is global::Motorola.Common.Communication.CommunicationPipe.TetraCommPipe)
				{
					this._myCommPipe = (value as global::Motorola.Common.Communication.CommunicationPipe.TetraCommPipe);
					this._bHaveTransport = true;
				}
			}
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00005243 File Offset: 0x00003443
		public virtual void Setup()
		{
			if (this._bHaveTransport)
			{
				this._myCommPipe.OpenPort();
			}
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00005259 File Offset: 0x00003459
		public virtual void TearDown()
		{
			if (this._bHaveTransport)
			{
				this._myCommPipe.ClosePort();
			}
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00005270 File Offset: 0x00003470
		public void SendAndReceiveMessage(global::Motorola.Common.Communication.IMessage msg)
		{
			byte[] array = null;
			byte[] array2 = null;
			int num = msg.BuildCommandMessage(array);
			bool bHaveCommand = num > 0;
			this.SendRequest(bHaveCommand, array, msg.hasReply, out array2);
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x000052A3 File Offset: 0x000034A3
		public void SetRxTimeoutTimer(int timeout)
		{
			if (this._bHaveTransport)
			{
				this._myCommPipe.ReadTimeout = timeout;
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000BA RID: 186 RVA: 0x000052B9 File Offset: 0x000034B9
		// (set) Token: 0x060000BB RID: 187 RVA: 0x000052D0 File Offset: 0x000034D0
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

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000BC RID: 188 RVA: 0x000052E6 File Offset: 0x000034E6
		// (set) Token: 0x060000BD RID: 189 RVA: 0x000052FD File Offset: 0x000034FD
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

		// Token: 0x060000BE RID: 190 RVA: 0x00005313 File Offset: 0x00003513
		public bool OpenPort()
		{
			return this._bHaveTransport && this._myCommPipe.OpenPort();
		}

		// Token: 0x060000BF RID: 191 RVA: 0x0000532A File Offset: 0x0000352A
		public void ClosePort()
		{
			if (this._bHaveTransport)
			{
				this._myCommPipe.ClosePort();
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000C0 RID: 192 RVA: 0x0000533F File Offset: 0x0000353F
		// (set) Token: 0x060000C1 RID: 193 RVA: 0x00005351 File Offset: 0x00003551
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

		// Token: 0x060000C2 RID: 194 RVA: 0x00005364 File Offset: 0x00003564
		public global::Motorola.Common.Communication.TetraMsgOpResult SendAndReceiveMessage(bool bHaveCommand, byte[] sendMsgBuffer, bool bHaveReply, byte[] receiveMsgBuffer)
		{
			return this.SendRequest(bHaveCommand, sendMsgBuffer, bHaveReply, out receiveMsgBuffer);
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00005374 File Offset: 0x00003574
		public global::Motorola.Common.Communication.TetraMsgOpResult SendRequest(bool bHaveCommand, byte[] msgBuffer, bool bHaveReply, out byte[] replyMessage)
		{
			global::Motorola.Common.LogUtility.LoggerUtil.SetTimeStampLabel("RPProtocol.Executor.SendRequest");
			global::Motorola.Common.Communication.TetraMsgOpResult tetraMsgOpResult = global::Motorola.Common.Communication.TetraMsgOpResult.RP_SUCCESS;
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
					tetraMsgOpResult = global::Motorola.Common.Communication.TetraMsgOpResult.RP_WRONG_PARAMETER;
					flag = false;
				}
				if (flag)
				{
					this._myCommPipe.PurgeInputBuffer();
					this._myCommPipe.PurgeOutputBuffer();
				}
				if (flag)
				{
					tetraMsgOpResult = this.SendMessage(msgBuffer, msgBuffer.Length);
					if (tetraMsgOpResult != global::Motorola.Common.Communication.TetraMsgOpResult.RP_SUCCESS)
					{
						flag = false;
					}
				}
			}
			if (flag && bHaveReply)
			{
				tetraMsgOpResult = this.ReceiveMessage(out replyMessage);
			}
			global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.RP_PERFORMANCE_LOGGER_NAME).Performance("RPProtocol.Executor.SendRequest", "");
			return tetraMsgOpResult;
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00005408 File Offset: 0x00003608
		private global::Motorola.Common.Communication.TetraMsgOpResult IsCommandRejected(byte[] data, out bool bRejected, out byte rejectReason)
		{
			global::Motorola.Common.Communication.TetraMsgOpResult result = global::Motorola.Common.Communication.TetraMsgOpResult.Undefined;
			bool flag = true;
			bRejected = false;
			rejectReason = 0;
			if (data == null)
			{
				flag = false;
				result = global::Motorola.Common.Communication.TetraMsgOpResult.RP_WRONG_PARAMETER;
			}
			if (data.Length < 13)
			{
				flag = false;
				result = global::Motorola.Common.Communication.TetraMsgOpResult.RP_WRONG_PARAMETER;
			}
			if (flag)
			{
				int num = 3;
				if (data[num] == 5)
				{
					num = 12;
					rejectReason = data[num];
					bRejected = true;
					result = global::Motorola.Common.Communication.TetraMsgOpResult.RP_SUCCESS;
				}
				else
				{
					result = global::Motorola.Common.Communication.TetraMsgOpResult.RP_SUCCESS;
				}
			}
			return result;
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00005458 File Offset: 0x00003658
		private global::Motorola.Common.Communication.TetraMsgOpResult SendMessage(byte[] data, int nLength)
		{
			global::Motorola.Common.Communication.TetraMsgOpResult result = global::Motorola.Common.Communication.TetraMsgOpResult.Undefined;
			bool flag = true;
			if (data == null)
			{
				flag = false;
				result = global::Motorola.Common.Communication.TetraMsgOpResult.RP_WRONG_PARAMETER;
			}
			if (nLength > data.Length)
			{
				flag = false;
				result = global::Motorola.Common.Communication.TetraMsgOpResult.RP_WRONG_PARAMETER;
			}
			if (!this._bHaveTransport)
			{
				flag = false;
				result = global::Motorola.Common.Communication.TetraMsgOpResult.RP_NONE_COMM_PIPE;
			}
			if (flag && flag)
			{
				int num = this._myCommPipe.SendData(data, 0, nLength);
				if (num != nLength)
				{
					result = ((num < 0) ? global::Motorola.Common.Communication.TetraMsgOpResult.RP_WRITE_COMM_ERROR : global::Motorola.Common.Communication.TetraMsgOpResult.RP_WRITE_TIMEOUT);
				}
				else
				{
					result = global::Motorola.Common.Communication.TetraMsgOpResult.RP_SUCCESS;
				}
			}
			return result;
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x000054B8 File Offset: 0x000036B8
		private global::Motorola.Common.Communication.TetraMsgOpResult ReceiveMessage(out byte[] msgBuffer)
		{
			ushort num = 0;
			int num2 = 0;
			global::Motorola.Common.Communication.TetraMsgOpResult tetraMsgOpResult = global::Motorola.Common.Communication.TetraMsgOpResult.RP_SUCCESS;
			bool flag = true;
			msgBuffer = null;
			bool flag2 = false;
			byte rp_NO_REJECTION = global::Motorola.Common.Communication.RPRejectReason.RP_NO_REJECTION;
			byte[] array = new byte[3];
			if (!this._bHaveTransport)
			{
				flag = false;
				tetraMsgOpResult = global::Motorola.Common.Communication.TetraMsgOpResult.RP_NONE_COMM_PIPE;
			}
			if (flag)
			{
				int num3 = this._myCommPipe.ReceiveData(array, 0, 3);
				if (num3 != 3)
				{
					flag = false;
					if (num3 == 0)
					{
						tetraMsgOpResult = global::Motorola.Common.Communication.TetraMsgOpResult.RP_READ_TIMEOUT;
					}
					else if (num3 < 0)
					{
						tetraMsgOpResult = global::Motorola.Common.Communication.TetraMsgOpResult.RP_RECEIVE_MESSAGE_ERROR;
					}
				}
				if (flag)
				{
					num2 += 3;
				}
				if (flag && array[0] != this.RP_MESSAGE_TYPE)
				{
					flag = false;
					tetraMsgOpResult = global::Motorola.Common.Communication.TetraMsgOpResult.RP_MSG_WRONG_FORMAT;
				}
				if (flag)
				{
					byte[] array2 = new byte[2];
					tetraMsgOpResult = global::Motorola.Common.Communication.SBEPCommon.ReverseBytesAndCopy(array2, 0, array, 1, 2);
					if (tetraMsgOpResult == global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_SUCCESS)
					{
						num = global::System.BitConverter.ToUInt16(array2, 0);
						msgBuffer = new byte[num2 + (int)num];
						global::System.Array.Copy(array, msgBuffer, num2);
						num3 = (this.CommPipe as global::Motorola.Common.Communication.CommunicationPipe.TetraCommPipe).ReceiveData(msgBuffer, num2, (int)num);
						tetraMsgOpResult = global::Motorola.Common.Communication.TetraMsgOpResult.RP_SUCCESS;
					}
					else
					{
						tetraMsgOpResult = global::Motorola.Common.Communication.TetraMsgOpResult.RP_WRONG_PARAMETER;
						flag = false;
					}
				}
				if (flag && num3 != (int)num)
				{
					flag = false;
					if (num3 == 0)
					{
						tetraMsgOpResult = global::Motorola.Common.Communication.TetraMsgOpResult.RP_READ_TIMEOUT;
						flag = false;
					}
					else if (num3 < 0)
					{
						tetraMsgOpResult = global::Motorola.Common.Communication.TetraMsgOpResult.RP_RECEIVE_MESSAGE_ERROR;
						flag = false;
					}
				}
				if (flag && msgBuffer.Length >= 13)
				{
					tetraMsgOpResult = this.IsCommandRejected(msgBuffer, out flag2, out rp_NO_REJECTION);
					if (tetraMsgOpResult != global::Motorola.Common.Communication.TetraMsgOpResult.RP_SUCCESS)
					{
						flag = false;
					}
					if (flag && flag2)
					{
						if (rp_NO_REJECTION == global::Motorola.Common.Communication.RPRejectReason.RP_BAD_BATTERY)
						{
							tetraMsgOpResult = global::Motorola.Common.Communication.TetraMsgOpResult.RP_REJCT_BAD_BATTERY;
						}
						else if (rp_NO_REJECTION == global::Motorola.Common.Communication.RPRejectReason.RP_EMERGENCY)
						{
							tetraMsgOpResult = global::Motorola.Common.Communication.TetraMsgOpResult.RP_REJCT_RP_EMERGENCY;
						}
					}
				}
			}
			return tetraMsgOpResult;
		}

		// Token: 0x0400003E RID: 62
		private global::Motorola.Common.Communication.CommunicationPipe.TetraCommPipe _myCommPipe;

		// Token: 0x0400003F RID: 63
		private bool _bHaveTransport;

		// Token: 0x04000040 RID: 64
		private readonly byte RP_MESSAGE_TYPE;

		// Token: 0x04000041 RID: 65
		private bool _disposed;
	}
}
