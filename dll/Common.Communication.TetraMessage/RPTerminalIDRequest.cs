using System;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.Communication.TetraUtility;
using Motorola.Common.LogUtility;

namespace Motorola.Common.Communication
{
	// Token: 0x0200004E RID: 78
	public class RPTerminalIDRequest : global::Motorola.Common.Communication.RPBaseMessage
	{
		// Token: 0x06000232 RID: 562 RVA: 0x00009B31 File Offset: 0x00007D31
		public RPTerminalIDRequest()
		{
			this._terminalType = global::Motorola.Common.Communication.CommonUtil.RPTerminalType.RP_UNKNOWN_TYPE;
			this._chSN = string.Empty;
			this._chDieID = null;
		}

		// Token: 0x06000233 RID: 563 RVA: 0x00009B52 File Offset: 0x00007D52
		public RPTerminalIDRequest(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe transPipe)
		{
			base.TransportPipe = transPipe;
			this._terminalType = global::Motorola.Common.Communication.CommonUtil.RPTerminalType.RP_UNKNOWN_TYPE;
			this._chSN = string.Empty;
			this._chDieID = null;
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x06000234 RID: 564 RVA: 0x00009B7A File Offset: 0x00007D7A
		public global::Motorola.Common.Communication.CommonUtil.RPTerminalType TerminalType
		{
			get
			{
				return this._terminalType;
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x06000235 RID: 565 RVA: 0x00009B82 File Offset: 0x00007D82
		public string ControlHeadSN
		{
			get
			{
				return this._chSN;
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06000236 RID: 566 RVA: 0x00009B8A File Offset: 0x00007D8A
		public string ControlHeadDieID
		{
			get
			{
				return this._chDieID;
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000237 RID: 567 RVA: 0x00009B92 File Offset: 0x00007D92
		public byte[] RawData
		{
			get
			{
				return this._rawData;
			}
		}

		// Token: 0x06000238 RID: 568 RVA: 0x00009B9C File Offset: 0x00007D9C
		public override void ExecuteMessage()
		{
			global::Motorola.Common.LogUtility.LoggerUtil.SetTimeStampLabel("RPProtocol.TerminalIDRequest");
			bool flag = true;
			this.BuildCommandMessageInternal();
			global::Motorola.Common.Communication.TetraMsgOpResult tetraMsgOpResult = base.Executor.SendRequest(true, base.MyCommandBuffer, true, out this._myReplyMessageBuffer);
			if (tetraMsgOpResult != global::Motorola.Common.Communication.TetraMsgOpResult.RP_SUCCESS)
			{
				flag = false;
			}
			if (flag)
			{
				this._rawData = new byte[this._myReplyMessageBuffer.Length];
				global::System.Array.Copy(this._myReplyMessageBuffer, this._rawData, this._myReplyMessageBuffer.Length);
				tetraMsgOpResult = this.ParseReplyMessage(this._myReplyMessageBuffer);
			}
			base.OperationResult = tetraMsgOpResult;
			global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.RP_PERFORMANCE_LOGGER_NAME).Performance("RPProtocol.TerminalIDRequest", "");
		}

		// Token: 0x06000239 RID: 569 RVA: 0x00009C3C File Offset: 0x00007E3C
		protected override global::Motorola.Common.Communication.TetraMsgOpResult BuildCommandMessageInternal()
		{
			global::Motorola.Common.Communication.TetraMsgOpResult result = global::Motorola.Common.Communication.TetraMsgOpResult.RP_SUCCESS;
			base.MyCommandBuffer = new byte[4];
			base.MyCommandBuffer[0] = 0;
			base.MyCommandBuffer[1] = 0;
			base.MyCommandBuffer[2] = 1;
			base.MyCommandBuffer[3] = 6;
			return result;
		}

		// Token: 0x0600023A RID: 570 RVA: 0x00009C80 File Offset: 0x00007E80
		protected override global::Motorola.Common.Communication.TetraMsgOpResult ParseReplyMessage(byte[] buffer)
		{
			bool flag = true;
			global::Motorola.Common.Communication.TetraMsgOpResult tetraMsgOpResult = global::Motorola.Common.Communication.TetraMsgOpResult.Undefined;
			if (buffer == null)
			{
				flag = false;
				tetraMsgOpResult = global::Motorola.Common.Communication.TetraMsgOpResult.RP_WRONG_PARAMETER;
			}
			if (flag)
			{
				int num = 3;
				if (buffer[num] != 7)
				{
					flag = false;
					if (buffer[num] == 0)
					{
						tetraMsgOpResult = global::Motorola.Common.Communication.TetraMsgOpResult.RP_RECEIVED_UNEXPECTED_INDICATION;
					}
					else
					{
						tetraMsgOpResult = global::Motorola.Common.Communication.TetraMsgOpResult.RP_MSG_WRONG_FORMAT;
					}
				}
			}
			if (flag)
			{
				int num2 = 12;
				if (buffer[num2] / 2 == 0)
				{
					flag = false;
					tetraMsgOpResult = global::Motorola.Common.Communication.TetraMsgOpResult.RP_UNSUPPORTED_PROTOCOL;
				}
				if (flag)
				{
					try
					{
						this._terminalType = (global::Motorola.Common.Communication.CommonUtil.RPTerminalType)(buffer[num2] % 2);
					}
					catch
					{
						this._terminalType = global::Motorola.Common.Communication.CommonUtil.RPTerminalType.RP_UNKNOWN_TYPE;
					}
					num2++;
					if (this._terminalType == global::Motorola.Common.Communication.CommonUtil.RPTerminalType.RP_TERMINAL_TYPE_MOBILE)
					{
						num2 += 16;
						tetraMsgOpResult = this.GetCHSNString(buffer, num2, out this._chSN);
						if (tetraMsgOpResult != global::Motorola.Common.Communication.TetraMsgOpResult.RP_SUCCESS)
						{
							flag = false;
						}
						if (flag)
						{
							num2 += 8;
							tetraMsgOpResult = this.GetCHDieID(buffer, num2, out this._chDieID);
						}
					}
					else
					{
						this._chDieID = string.Empty;
						for (int i = 13; i < 29; i++)
						{
							this._chDieID += string.Format("{0:X2}", buffer[i]);
						}
						tetraMsgOpResult = global::Motorola.Common.Communication.TetraMsgOpResult.RP_SUCCESS;
					}
				}
			}
			return tetraMsgOpResult;
		}

		// Token: 0x0600023B RID: 571 RVA: 0x00009D80 File Offset: 0x00007F80
		private global::Motorola.Common.Communication.TetraMsgOpResult GetCHDieID(byte[] data, int offset, out string dieID)
		{
			dieID = string.Empty;
			global::Motorola.Common.Communication.TetraMsgOpResult result;
			if (global::Motorola.Common.Communication.RPIDMask.RP_DIE_ID_MASK == (data[offset] & global::Motorola.Common.Communication.RPIDMask.RP_DIE_ID_MASK))
			{
				result = base.GetDieIDFromIndicationID(data, offset, out dieID);
			}
			else
			{
				result = global::Motorola.Common.Communication.TetraMsgOpResult.RP_INVALID_ID_FORMAT;
			}
			return result;
		}

		// Token: 0x0600023C RID: 572 RVA: 0x00009DB8 File Offset: 0x00007FB8
		private global::Motorola.Common.Communication.TetraMsgOpResult GetCHSNString(byte[] data, int offset, out string chSN)
		{
			bool flag = true;
			bool flag2 = true;
			chSN = string.Empty;
			global::Motorola.Common.Communication.TetraMsgOpResult tetraMsgOpResult = base.IsVaildID(data, offset, out flag2);
			if (tetraMsgOpResult != global::Motorola.Common.Communication.TetraMsgOpResult.RP_SUCCESS)
			{
				flag = false;
			}
			if (flag)
			{
				if (!flag2)
				{
					chSN = "FFFFFFFFFFFFFFFF";
					tetraMsgOpResult = global::Motorola.Common.Communication.TetraMsgOpResult.RP_SUCCESS;
				}
				else if (global::Motorola.Common.Communication.RPIDMask.RP_SERIAL_NUMBER_MASK == (data[offset] & global::Motorola.Common.Communication.RPIDMask.RP_ID_SCHEME_MASK))
				{
					tetraMsgOpResult = base.GetSNFromIndicationID(data, offset, out chSN);
				}
				else
				{
					tetraMsgOpResult = global::Motorola.Common.Communication.TetraMsgOpResult.RP_INVALID_ID_FORMAT;
				}
			}
			return tetraMsgOpResult;
		}

		// Token: 0x040000E9 RID: 233
		private global::Motorola.Common.Communication.CommonUtil.RPTerminalType _terminalType;

		// Token: 0x040000EA RID: 234
		private string _chSN;

		// Token: 0x040000EB RID: 235
		private string _chDieID;

		// Token: 0x040000EC RID: 236
		private byte[] _rawData;
	}
}
