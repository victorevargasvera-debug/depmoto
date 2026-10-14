using System;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.Communication.TetraUtility;
using Motorola.Common.LogUtility;

namespace Motorola.Common.Communication
{
	// Token: 0x0200000D RID: 13
	public class ATResetRadioToMassStorage : global::Motorola.Common.Communication.ATBaseMessage
	{
		// Token: 0x0600006D RID: 109 RVA: 0x00003C67 File Offset: 0x00001E67
		public ATResetRadioToMassStorage(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe transPipe)
		{
			base.TransportPipe = transPipe;
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00003C90 File Offset: 0x00001E90
		public override void ExecuteMessage()
		{
			global::Motorola.Common.LogUtility.LoggerUtil.SetTimeStampLabel("ATProtocol.ATResetRadioToMassStoreage");
			bool flag = true;
			global::Motorola.Common.Communication.TetraMsgOpResult tetraMsgOpResult = base.Executor.SendRequest(true, this.AT_RESET_TO_MS_MODE, true, out this._myReplyMessageBuffer);
			if (tetraMsgOpResult != global::Motorola.Common.Communication.TetraMsgOpResult.AT_SUCCESS)
			{
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo((base.TransportPipe as global::Motorola.Common.Communication.CommunicationPipe.TetraCommPipe).PortName, "ATResetRadioToMassStoreage failed in ATExecutor.SendRequest, result code is: " + tetraMsgOpResult.ToString());
				flag = false;
			}
			if (flag)
			{
				tetraMsgOpResult = this.ParseReplyMessage(this._myReplyMessageBuffer);
			}
			base.OperationResult = tetraMsgOpResult;
			global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.RP_PERFORMANCE_LOGGER_NAME).Performance("ATProtocol.ATResetRadioToMassStoreage", "");
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00003D27 File Offset: 0x00001F27
		protected override global::Motorola.Common.Communication.TetraMsgOpResult BuildCommandMessageInternal()
		{
			base.MyCommandBuffer = new byte[this.AT_RESET_TO_MS_MODE.Length];
			global::System.Array.Copy(this.AT_RESET_TO_MS_MODE, base.MyCommandBuffer, this.AT_RESET_TO_MS_MODE.Length);
			return global::Motorola.Common.Communication.TetraMsgOpResult.AT_SUCCESS;
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00003D58 File Offset: 0x00001F58
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

		// Token: 0x0400002B RID: 43
		private readonly byte[] AT_RESET_TO_MS_MODE = new byte[]
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
			50,
			13
		};
	}
}
