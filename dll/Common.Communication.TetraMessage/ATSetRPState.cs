using System;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.Communication.TetraUtility;
using Motorola.Common.LogUtility;

namespace Motorola.Common.Communication
{
	// Token: 0x0200000F RID: 15
	public class ATSetRPState : global::Motorola.Common.Communication.ATBaseMessage
	{
		// Token: 0x06000078 RID: 120 RVA: 0x000040A4 File Offset: 0x000022A4
		public ATSetRPState(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe transPipe, global::Motorola.Common.Communication.CommonUtil.RPDeivceState state)
		{
			base.TransportPipe = transPipe;
			switch (state)
			{
			case global::Motorola.Common.Communication.CommonUtil.RPDeivceState.NORMAL_NO_RP:
				this.AT_MCRPS_SET[9] = 48;
				return;
			case global::Motorola.Common.Communication.CommonUtil.RPDeivceState.GREEN_NO_UPDATE:
				this.AT_MCRPS_SET[9] = 49;
				return;
			case global::Motorola.Common.Communication.CommonUtil.RPDeivceState.WHITE_CHARGING_BATTERY:
				this.AT_MCRPS_SET[9] = 50;
				return;
			case global::Motorola.Common.Communication.CommonUtil.RPDeivceState.RED_PROGRAMMING_FAILED:
				this.AT_MCRPS_SET[9] = 51;
				return;
			case global::Motorola.Common.Communication.CommonUtil.RPDeivceState.ORANGE_SYNCHRONIZING:
				this.AT_MCRPS_SET[9] = 52;
				return;
			default:
				return;
			}
		}

		// Token: 0x06000079 RID: 121 RVA: 0x0000413C File Offset: 0x0000233C
		public ATSetRPState(global::Motorola.Common.Communication.CommonUtil.RPDeivceState state)
		{
			switch (state)
			{
			case global::Motorola.Common.Communication.CommonUtil.RPDeivceState.NORMAL_NO_RP:
				this.AT_MCRPS_SET[9] = 48;
				return;
			case global::Motorola.Common.Communication.CommonUtil.RPDeivceState.GREEN_NO_UPDATE:
				this.AT_MCRPS_SET[9] = 49;
				return;
			case global::Motorola.Common.Communication.CommonUtil.RPDeivceState.WHITE_CHARGING_BATTERY:
				this.AT_MCRPS_SET[9] = 50;
				return;
			case global::Motorola.Common.Communication.CommonUtil.RPDeivceState.RED_PROGRAMMING_FAILED:
				this.AT_MCRPS_SET[9] = 51;
				return;
			case global::Motorola.Common.Communication.CommonUtil.RPDeivceState.ORANGE_SYNCHRONIZING:
				this.AT_MCRPS_SET[9] = 52;
				return;
			default:
				return;
			}
		}

		// Token: 0x0600007A RID: 122 RVA: 0x000041C0 File Offset: 0x000023C0
		public override void ExecuteMessage()
		{
			global::Motorola.Common.LogUtility.LoggerUtil.SetTimeStampLabel("ATProtocol.ATSetRPState");
			bool flag = true;
			global::Motorola.Common.Communication.TetraMsgOpResult tetraMsgOpResult = base.Executor.SendRequest(base.HasCommand, this.AT_MCRPS_SET, base.hasReply, out this._myReplyMessageBuffer, 200);
			if (tetraMsgOpResult != global::Motorola.Common.Communication.TetraMsgOpResult.AT_SUCCESS)
			{
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo((base.TransportPipe as global::Motorola.Common.Communication.CommunicationPipe.TetraCommPipe).PortName, "ATSetRPState failed in ATExecutor.SendRequest, result code is: " + tetraMsgOpResult.ToString());
				flag = false;
			}
			if (flag)
			{
				tetraMsgOpResult = this.ParseReplyMessage(this._myReplyMessageBuffer);
			}
			base.OperationResult = tetraMsgOpResult;
			global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.RP_PERFORMANCE_LOGGER_NAME).Performance("ATProtocol.ATSetRPState", "");
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00004266 File Offset: 0x00002466
		protected override global::Motorola.Common.Communication.TetraMsgOpResult BuildCommandMessageInternal()
		{
			base.MyCommandBuffer = new byte[this.AT_MCRPS_SET.Length];
			global::System.Array.Copy(this.AT_MCRPS_SET, base.MyCommandBuffer, this.AT_MCRPS_SET.Length);
			return global::Motorola.Common.Communication.TetraMsgOpResult.AT_SUCCESS;
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00004298 File Offset: 0x00002498
		protected override global::Motorola.Common.Communication.TetraMsgOpResult ParseReplyMessage(byte[] buffer)
		{
			global::Motorola.Common.Communication.TetraMsgOpResult result = global::Motorola.Common.Communication.TetraMsgOpResult.AT_SUCCESS;
			if (!base.IsATCommandOK(buffer))
			{
				result = base.GetErrorReason(buffer);
			}
			return result;
		}

		// Token: 0x0400002F RID: 47
		private readonly byte[] AT_MCRPS_SET = new byte[]
		{
			65,
			84,
			43,
			77,
			67,
			82,
			80,
			83,
			61,
			120,
			13
		};
	}
}
