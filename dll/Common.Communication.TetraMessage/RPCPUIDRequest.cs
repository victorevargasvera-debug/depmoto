using System;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.Communication.TetraUtility;
using Motorola.Common.LogUtility;

namespace Motorola.Common.Communication
{
	// Token: 0x02000012 RID: 18
	public class RPCPUIDRequest : global::Motorola.Common.Communication.RPBaseMessage
	{
		// Token: 0x060000A5 RID: 165 RVA: 0x00004ED4 File Offset: 0x000030D4
		public RPCPUIDRequest(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe transPipe)
		{
			base.TransportPipe = transPipe;
			this._terminalType = global::Motorola.Common.Communication.CommonUtil.RPTerminalType.RP_UNKNOWN_TYPE;
			this._chSN = string.Empty;
			this._chDieID = string.Empty;
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00004F00 File Offset: 0x00003100
		public RPCPUIDRequest()
		{
			this._terminalType = global::Motorola.Common.Communication.CommonUtil.RPTerminalType.RP_UNKNOWN_TYPE;
			this._chSN = string.Empty;
			this._chDieID = string.Empty;
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060000A7 RID: 167 RVA: 0x00004F25 File Offset: 0x00003125
		public global::Motorola.Common.Communication.CommonUtil.RPTerminalType TerminalType
		{
			get
			{
				return this._terminalType;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060000A8 RID: 168 RVA: 0x00004F2D File Offset: 0x0000312D
		public string ControlHeadSN
		{
			get
			{
				return this._chSN;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000A9 RID: 169 RVA: 0x00004F35 File Offset: 0x00003135
		public string ControlHeadDieID
		{
			get
			{
				return this._chDieID;
			}
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00004F40 File Offset: 0x00003140
		public override void ExecuteMessage()
		{
			global::Motorola.Common.LogUtility.LoggerUtil.SetTimeStampLabel("RPProtocol.CPUIDRequest");
			bool flag = true;
			this.BuildCommandMessageInternal();
			global::Motorola.Common.Communication.TetraMsgOpResult tetraMsgOpResult = base.Executor.SendRequest(base.HasCommand, base.MyCommandBuffer, base.hasReply, out this._myReplyMessageBuffer);
			if (tetraMsgOpResult != global::Motorola.Common.Communication.TetraMsgOpResult.RP_SUCCESS)
			{
				flag = false;
			}
			if (flag)
			{
				tetraMsgOpResult = this.ParseReplyMessage(this._myReplyMessageBuffer);
			}
			base.OperationResult = tetraMsgOpResult;
			global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.RP_PERFORMANCE_LOGGER_NAME).Performance("RPProtocol.CPUIDRequest", "");
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00004FBE File Offset: 0x000031BE
		protected override global::Motorola.Common.Communication.TetraMsgOpResult BuildCommandMessageInternal()
		{
			base.MyCommandBuffer = new byte[4];
			base.MyCommandBuffer[0] = 0;
			base.MyCommandBuffer[1] = 0;
			base.MyCommandBuffer[2] = 1;
			base.MyCommandBuffer[3] = 6;
			return global::Motorola.Common.Communication.TetraMsgOpResult.RP_SUCCESS;
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00004FF4 File Offset: 0x000031F4
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
					tetraMsgOpResult = global::Motorola.Common.Communication.TetraMsgOpResult.RP_MSG_WRONG_FORMAT;
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

		// Token: 0x060000AD RID: 173 RVA: 0x000050E8 File Offset: 0x000032E8
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

		// Token: 0x060000AE RID: 174 RVA: 0x00005120 File Offset: 0x00003320
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

		// Token: 0x0400003B RID: 59
		private global::Motorola.Common.Communication.CommonUtil.RPTerminalType _terminalType;

		// Token: 0x0400003C RID: 60
		private string _chSN;

		// Token: 0x0400003D RID: 61
		private string _chDieID;
	}
}
