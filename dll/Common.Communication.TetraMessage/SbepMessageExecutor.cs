using System;
using System.Threading;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.Communication.TetraUtility;
using Motorola.Common.LogUtility;

namespace Motorola.Common.Communication
{
	// Token: 0x0200002C RID: 44
	public class SbepMessageExecutor : global::Motorola.Common.Communication.IMessageExecutor
	{
		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000165 RID: 357 RVA: 0x000078A6 File Offset: 0x00005AA6
		// (set) Token: 0x06000166 RID: 358 RVA: 0x000078AE File Offset: 0x00005AAE
		private global::Motorola.Common.Communication.CommunicationPipe.TetraCommPipe InternalCommPipe { get; set; }

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000167 RID: 359 RVA: 0x000078B7 File Offset: 0x00005AB7
		// (set) Token: 0x06000168 RID: 360 RVA: 0x000078C9 File Offset: 0x00005AC9
		public global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe CommPipe
		{
			get
			{
				if (this._bHaveTransport)
				{
					return this.InternalCommPipe;
				}
				return null;
			}
			set
			{
				if (value is global::Motorola.Common.Communication.CommunicationPipe.TetraCommPipe)
				{
					this.InternalCommPipe = (value as global::Motorola.Common.Communication.CommunicationPipe.TetraCommPipe);
					this._bHaveTransport = true;
				}
			}
		}

		// Token: 0x06000169 RID: 361 RVA: 0x000078E6 File Offset: 0x00005AE6
		public virtual void Setup()
		{
			if (this._bHaveTransport)
			{
				this.InternalCommPipe.OpenPort();
			}
		}

		// Token: 0x0600016A RID: 362 RVA: 0x000078FC File Offset: 0x00005AFC
		public virtual void TearDown()
		{
			if (this._bHaveTransport)
			{
				this.InternalCommPipe.ClosePort();
			}
		}

		// Token: 0x0600016B RID: 363 RVA: 0x00007914 File Offset: 0x00005B14
		public void SendAndReceiveMessage(global::Motorola.Common.Communication.IMessage msg)
		{
			byte[] array = null;
			byte[] array2 = null;
			int num = msg.BuildCommandMessage(array);
			bool bHaveCommand = num > 0;
			this.SendRequest(bHaveCommand, array, msg.hasReply, out array2);
		}

		// Token: 0x0600016C RID: 364 RVA: 0x00007947 File Offset: 0x00005B47
		public void SetRxTimeoutTimer(int timeout)
		{
			if (this._bHaveTransport)
			{
				this.InternalCommPipe.ReadTimeout = timeout;
			}
		}

		// Token: 0x0600016D RID: 365 RVA: 0x0000795D File Offset: 0x00005B5D
		public SbepMessageExecutor(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe commPipe)
		{
			this.CommPipe = commPipe;
		}

		// Token: 0x0600016E RID: 366 RVA: 0x00007973 File Offset: 0x00005B73
		public SbepMessageExecutor()
		{
			this.CommPipe = null;
		}

		// Token: 0x0600016F RID: 367 RVA: 0x00007989 File Offset: 0x00005B89
		public bool OpenPort()
		{
			return this._bHaveTransport && this.InternalCommPipe.OpenPort();
		}

		// Token: 0x06000170 RID: 368 RVA: 0x000079A0 File Offset: 0x00005BA0
		public void ClosePort()
		{
			if (this._bHaveTransport)
			{
				this.InternalCommPipe.ClosePort();
			}
		}

		// Token: 0x06000171 RID: 369 RVA: 0x000079B5 File Offset: 0x00005BB5
		public global::Motorola.Common.Communication.TetraMsgOpResult SendAndReceiveMessage(bool bHaveCommand, byte[] sendMsgBuffer, bool bHaveReply, byte[] receiveMsgBuffer)
		{
			return this.SendRequest(bHaveCommand, sendMsgBuffer, bHaveReply, out receiveMsgBuffer);
		}

		// Token: 0x06000172 RID: 370 RVA: 0x000079C4 File Offset: 0x00005BC4
		public global::Motorola.Common.Communication.TetraMsgOpResult SendRequest(bool bHaveCommand, byte[] msgBuffer, bool bHaveReply, out byte[] replyMessage)
		{
			global::Motorola.Common.LogUtility.LoggerUtil.SetTimeStampLabel("SBEPProtocol.Executor.SendRequest");
			global::Motorola.Common.Communication.TetraMsgOpResult tetraMsgOpResult = global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_SUCCESS;
			bool flag = true;
			replyMessage = null;
			if (!this._bHaveTransport)
			{
				tetraMsgOpResult = global::Motorola.Common.Communication.TetraMsgOpResult.AT_NONE_COMM_PIPE;
				flag = false;
			}
			if (bHaveCommand)
			{
				if (msgBuffer == null)
				{
					tetraMsgOpResult = global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_WRONG_PARAMETER;
					flag = false;
				}
				if (flag)
				{
					this.InternalCommPipe.PurgeInputBuffer();
					this.InternalCommPipe.PurgeOutputBuffer();
				}
				if (flag)
				{
					tetraMsgOpResult = this.SendMessage(msgBuffer, msgBuffer.Length);
					if (tetraMsgOpResult != global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_SUCCESS)
					{
						flag = false;
					}
				}
			}
			if (flag && bHaveReply)
			{
				tetraMsgOpResult = this.ReceiveMessage(out replyMessage);
			}
			if (tetraMsgOpResult == global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_READ_TIMEOUT && this.InternalCommPipe.ReadTimeout != global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.SHORT_WAIT_TIME_OUT)
			{
				global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("!!!!!!Get SBEP Reply timeout, will try to close and re-open port");
				this.LogCommand(msgBuffer);
				this.InternalCommPipe.ClosePort();
				global::System.Threading.Thread.Sleep(500);
				this.InternalCommPipe.OpenPort();
				global::System.Threading.Thread.Sleep(500);
				global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("!!!!!! Re-Open port done, try to read reply...");
				byte[] array = null;
				global::Motorola.Common.Communication.TetraMsgOpResult tetraMsgOpResult2 = this.ReceiveMessage(out array);
				if (tetraMsgOpResult2 == global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_SUCCESS)
				{
					string text = "!!!!!! Read reply after re-open port Successful: ";
					foreach (byte b in array)
					{
						text += " ";
						text += b.ToString("X2");
					}
					global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(text);
					global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("!!!!!! Set the command reply to data gotten after reopen...");
					replyMessage = array;
					tetraMsgOpResult = global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_SUCCESS;
				}
				else
				{
					global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("!!!!!! Read reply after re-open port fail: {0}", new object[]
					{
						tetraMsgOpResult2.ToString()
					});
					global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("!!!!!! Try to read out all buffers...");
					global::System.Threading.Thread.Sleep(1000);
					byte[] array3 = new byte[1000];
					int num = this.InternalCommPipe.ReceiveData(array3, 0, 1000);
					string text2 = "!!!!!! Buffer data size: {0}, Buffer data: ";
					for (int j = 0; j < num; j++)
					{
						text2 += " ";
						text2 += array3[j].ToString("X2");
					}
					global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(text2, new object[]
					{
						num
					});
					global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("!!!!!! Re-send last command to radio...");
					global::Motorola.Common.Communication.TetraMsgOpResult tetraMsgOpResult3 = this.SendMessage(msgBuffer, msgBuffer.Length);
					if (tetraMsgOpResult3 == global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_SUCCESS)
					{
						global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("!!!!!! Re-send last command successful, try to get reply...");
						byte[] array4 = null;
						tetraMsgOpResult3 = this.ReceiveMessage(out array4);
						if (tetraMsgOpResult3 == global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_SUCCESS)
						{
							string text3 = "!!!!!! Read reply after re-send last command Successful: ";
							foreach (byte b2 in array4)
							{
								text3 += " ";
								text3 += b2.ToString("X2");
							}
							global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(text3);
							global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("!!!!!! Set the command reply to data gotten after re-send last command...");
							replyMessage = array4;
							tetraMsgOpResult = global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_SUCCESS;
						}
						else
						{
							global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("!!!!!! Read reply after re-send last command fail: {0}", new object[]
							{
								tetraMsgOpResult3.ToString()
							});
						}
					}
					else
					{
						global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("!!!!!! Re-send last command fail: {0}", new object[]
						{
							tetraMsgOpResult3.ToString()
						});
					}
				}
			}
			global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.SBEP_PERFORMANCE_LOGGER_NAME).Performance("SBEPProtocol.Executor.SendRequest", "");
			return tetraMsgOpResult;
		}

		// Token: 0x06000173 RID: 371 RVA: 0x00007D48 File Offset: 0x00005F48
		internal global::Motorola.Common.Communication.TetraMsgOpResult SendMessage(byte[] data, int nLength)
		{
			global::Motorola.Common.LogUtility.LoggerUtil.SetTimeStampLabel("SBEPProtocol.Executor.SendMessage");
			global::Motorola.Common.Communication.TetraMsgOpResult tetraMsgOpResult = global::Motorola.Common.Communication.TetraMsgOpResult.Undefined;
			bool flag = true;
			if (data == null)
			{
				flag = false;
				tetraMsgOpResult = global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_WRONG_PARAMETER;
			}
			if (nLength > data.Length)
			{
				flag = false;
				tetraMsgOpResult = global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_WRONG_PARAMETER;
			}
			if (!this._bHaveTransport)
			{
				flag = false;
				tetraMsgOpResult = global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_NONE_COMM_PIPE;
			}
			if (flag)
			{
				if (this.InternalCommPipe.Reliable)
				{
					int num = this.InternalCommPipe.SendData(data, 0, nLength);
					if (num != nLength)
					{
						tetraMsgOpResult = ((num < 0) ? global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_WRITE_COMM_ERROR : global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_WRITE_TIMEOUT);
					}
					else
					{
						tetraMsgOpResult = global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_SUCCESS;
					}
				}
				else
				{
					int num2 = this.RETRY_COUNTER;
					int num;
					for (;;)
					{
						this.InternalCommPipe.PurgeInputBuffer();
						num = this.InternalCommPipe.SendData(data, 0, nLength);
						if (num != nLength)
						{
							break;
						}
						byte[] array = new byte[1];
						if (this.InternalCommPipe.ReceiveData(array, 0, 1) == 0)
						{
							tetraMsgOpResult = global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_WRITE_NOACKNOWLEDGE;
						}
						else if (array[0] == 80)
						{
							tetraMsgOpResult = global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_SUCCESS;
						}
						else if (array[0] == 96)
						{
							tetraMsgOpResult = global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_WRITE_NACK;
						}
						else
						{
							tetraMsgOpResult = global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_WRITE_NOACKNOWLEDGE;
						}
						num2--;
						if (num2 < 0 || tetraMsgOpResult != global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_WRITE_NACK)
						{
							goto IL_E8;
						}
					}
					tetraMsgOpResult = ((num < 0) ? global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_WRITE_COMM_ERROR : global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_WRITE_TIMEOUT);
				}
			}
			IL_E8:
			global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.SBEP_PERFORMANCE_LOGGER_NAME).Performance("SBEPProtocol.Executor.SendMessage", "");
			return tetraMsgOpResult;
		}

		// Token: 0x06000174 RID: 372 RVA: 0x00007E58 File Offset: 0x00006058
		private global::Motorola.Common.Communication.TetraMsgOpResult ReceiveMessage(out byte[] msgBuffer)
		{
			global::Motorola.Common.LogUtility.LoggerUtil.SetTimeStampLabel("SBEPProtocol.Executor.ReceiveMessage");
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			global::Motorola.Common.Communication.TetraMsgOpResult result = global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_SUCCESS;
			bool flag = true;
			msgBuffer = null;
			byte[] array = new byte[4];
			if (!this._bHaveTransport)
			{
				flag = false;
				result = global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_NONE_COMM_PIPE;
			}
			if (flag)
			{
				num = this.InternalCommPipe.ReceiveData(array, 0, 2);
				if (num != 2)
				{
					flag = false;
					if (num == 0)
					{
						result = global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_READ_TIMEOUT;
					}
					else if (num < 0)
					{
						result = global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_RECEIVE_MESSAGE_ERROR;
					}
				}
			}
			if (flag)
			{
				num4 += 2;
			}
			if (flag && (array[0] & 240) != 240)
			{
				flag = false;
				global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("Invalid message header in SBEPExecutor.ReceiveMessage: {0}, {1}", new object[]
				{
					array[0].ToString(),
					array[1].ToString()
				});
				result = global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_MSG_WRONG_FORMAT;
			}
			if (flag)
			{
				num3 = (int)(array[0] & 15);
				if ((num3 & 15) == 15)
				{
					num = this.InternalCommPipe.ReceiveData(array, 2, 2);
					if (num != 2)
					{
						flag = false;
						if (num == 0)
						{
							result = global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_READ_TIMEOUT;
						}
						else if (num < 0)
						{
							result = global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_RECEIVE_MESSAGE_ERROR;
						}
					}
					if (flag)
					{
						num4 += 2;
						num3 = ((int)array[2] << 8 | (int)array[3]);
					}
				}
				if (flag)
				{
					msgBuffer = new byte[num4 + num3];
					global::System.Array.Copy(array, msgBuffer, num4);
					num = this.InternalCommPipe.ReceiveData(msgBuffer, num4, num3);
				}
			}
			if (flag && num != num3)
			{
				flag = false;
				if (num == 0)
				{
					result = global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_READ_TIMEOUT;
				}
				else if (num < 0)
				{
					result = global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_RECEIVE_MESSAGE_ERROR;
				}
			}
			if (flag)
			{
				for (int i = 0; i < msgBuffer.Length; i++)
				{
					num2 += (int)msgBuffer[i];
				}
				if ((num2 & 255) != 255)
				{
					result = global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_MSG_CHECKSUM_ERROR;
				}
			}
			global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.SBEP_PERFORMANCE_LOGGER_NAME).Performance("SBEPProtocol.Executor.ReceiveMessage", "");
			return result;
		}

		// Token: 0x06000175 RID: 373 RVA: 0x00008008 File Offset: 0x00006208
		private void LogCommand(byte[] msgBuffer)
		{
			string text = "!!!!!!! The SBEP Command is: ";
			for (int i = 0; i < msgBuffer.Length; i++)
			{
				text += " ";
				text += msgBuffer[i].ToString("X2");
				if (i > 20)
				{
					text += " ...";
					break;
				}
			}
			global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(text);
		}

		// Token: 0x0400007B RID: 123
		private bool _bHaveTransport;

		// Token: 0x0400007C RID: 124
		private readonly int RETRY_COUNTER = 3;
	}
}
