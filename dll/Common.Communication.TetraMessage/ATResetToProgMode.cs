using System;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.Communication.TetraUtility;
using Motorola.Common.LogUtility;

namespace Motorola.Common.Communication
{
	// Token: 0x0200000E RID: 14
	public class ATResetToProgMode : global::Motorola.Common.Communication.ATBaseMessage
	{
		// Token: 0x06000071 RID: 113 RVA: 0x00003DAF File Offset: 0x00001FAF
		public ATResetToProgMode()
		{
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00003E07 File Offset: 0x00002007
		public ATResetToProgMode(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe transPipe)
		{
			base.TransportPipe = transPipe;
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00003E68 File Offset: 0x00002068
		public ATResetToProgMode(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe transPipe, bool rpProg)
		{
			base.TransportPipe = transPipe;
			this._rpProg = rpProg;
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00003EDF File Offset: 0x000020DF
		public ATResetToProgMode(bool rpProg)
		{
			this._rpProg = rpProg;
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00003F20 File Offset: 0x00002120
		public override void ExecuteMessage()
		{
			global::Motorola.Common.LogUtility.LoggerUtil.SetTimeStampLabel("ATProtocol.ATResetToProgMode");
			bool flag = true;
			global::Motorola.Common.Communication.TetraMsgOpResult tetraMsgOpResult;
			if (this._rpProg)
			{
				tetraMsgOpResult = base.Executor.SendRequest(base.HasCommand, this.AT_RESET_TO_RP_PROG_MODE, base.hasReply, out this._myReplyMessageBuffer);
			}
			else
			{
				tetraMsgOpResult = base.Executor.SendRequest(base.HasCommand, this.AT_RESET_TO_PROG_MODE, base.hasReply, out this._myReplyMessageBuffer);
			}
			if (tetraMsgOpResult != global::Motorola.Common.Communication.TetraMsgOpResult.AT_SUCCESS)
			{
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo((base.TransportPipe as global::Motorola.Common.Communication.CommunicationPipe.TetraCommPipe).PortName, "ATResetToProgMode failed in ATExecutor.SendRequest, result code is: " + tetraMsgOpResult.ToString());
				flag = false;
			}
			if (flag)
			{
				tetraMsgOpResult = this.ParseReplyMessage(this._myReplyMessageBuffer);
			}
			base.OperationResult = tetraMsgOpResult;
			global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.RP_PERFORMANCE_LOGGER_NAME).Performance("ATProtocol.ATResetToProgMode", "");
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00003FF0 File Offset: 0x000021F0
		protected override global::Motorola.Common.Communication.TetraMsgOpResult BuildCommandMessageInternal()
		{
			if (this._rpProg)
			{
				base.MyCommandBuffer = new byte[this.AT_RESET_TO_RP_PROG_MODE.Length];
				global::System.Array.Copy(this.AT_RESET_TO_RP_PROG_MODE, base.MyCommandBuffer, this.AT_RESET_TO_RP_PROG_MODE.Length);
			}
			else
			{
				base.MyCommandBuffer = new byte[this.AT_RESET_TO_PROG_MODE.Length];
				global::System.Array.Copy(this.AT_RESET_TO_PROG_MODE, base.MyCommandBuffer, this.AT_RESET_TO_PROG_MODE.Length);
			}
			return global::Motorola.Common.Communication.TetraMsgOpResult.AT_SUCCESS;
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00004064 File Offset: 0x00002264
		protected override global::Motorola.Common.Communication.TetraMsgOpResult ParseReplyMessage(byte[] buffer)
		{
			global::Motorola.Common.Communication.TetraMsgOpResult tetraMsgOpResult = global::Motorola.Common.Communication.TetraMsgOpResult.AT_SUCCESS;
			if (!base.IsATCommandOK(buffer))
			{
				tetraMsgOpResult = base.GetErrorReason(buffer);
			}
			if (tetraMsgOpResult == global::Motorola.Common.Communication.TetraMsgOpResult.AT_SUCCESS)
			{
				base.Executor.ClosePort();
			}
			return tetraMsgOpResult;
		}

		// Token: 0x0400002C RID: 44
		private readonly byte[] AT_RESET_TO_PROG_MODE = new byte[]
		{
			65,
			84,
			43,
			70,
			67,
			76,
			65,
			83,
			83,
			61,
			49,
			48,
			48,
			48,
			13
		};

		// Token: 0x0400002D RID: 45
		private readonly byte[] AT_RESET_TO_RP_PROG_MODE = new byte[]
		{
			65,
			84,
			43,
			70,
			67,
			76,
			65,
			83,
			83,
			61,
			49,
			57,
			57,
			50,
			13
		};

		// Token: 0x0400002E RID: 46
		private bool _rpProg;
	}
}
