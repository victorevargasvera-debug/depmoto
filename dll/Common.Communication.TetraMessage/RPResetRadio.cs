using System;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.Communication.TetraUtility;
using Motorola.Common.LogUtility;

namespace Motorola.Common.Communication
{
	// Token: 0x0200004D RID: 77
	public class RPResetRadio : global::Motorola.Common.Communication.RPBaseMessage
	{
		// Token: 0x0600022C RID: 556 RVA: 0x00009A0E File Offset: 0x00007C0E
		public RPResetRadio(byte toMode)
		{
			this._resetMode = toMode;
			base.hasReply = (toMode != 3);
		}

		// Token: 0x0600022D RID: 557 RVA: 0x00009A2B File Offset: 0x00007C2B
		public RPResetRadio(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe transPipe, byte toMode)
		{
			base.TransportPipe = transPipe;
			this._resetMode = toMode;
			base.hasReply = (toMode != 3);
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x0600022E RID: 558 RVA: 0x00009A4F File Offset: 0x00007C4F
		// (set) Token: 0x0600022F RID: 559 RVA: 0x00009A57 File Offset: 0x00007C57
		public byte ToMode
		{
			get
			{
				return this._resetMode;
			}
			set
			{
				this._resetMode = value;
			}
		}

		// Token: 0x06000230 RID: 560 RVA: 0x00009A60 File Offset: 0x00007C60
		public override void ExecuteMessage()
		{
			global::Motorola.Common.LogUtility.LoggerUtil.SetTimeStampLabel("RPProtocol.ResetRadio");
			bool flag = true;
			global::Motorola.Common.Communication.TetraMsgOpResult operationResult = global::Motorola.Common.Communication.TetraMsgOpResult.Undefined;
			if (this._resetMode < 0 || this._resetMode > 3)
			{
				flag = false;
				operationResult = global::Motorola.Common.Communication.TetraMsgOpResult.RP_INVALID_MODE;
			}
			if (flag)
			{
				this.BuildCommandMessageInternal();
				operationResult = base.Executor.SendRequest(base.HasCommand, base.MyCommandBuffer, base.hasReply, out this._myReplyMessageBuffer);
			}
			base.OperationResult = operationResult;
			global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.RP_PERFORMANCE_LOGGER_NAME).Performance("RPProtocol.ResetRadio", "");
		}

		// Token: 0x06000231 RID: 561 RVA: 0x00009AE4 File Offset: 0x00007CE4
		protected override global::Motorola.Common.Communication.TetraMsgOpResult BuildCommandMessageInternal()
		{
			base.MyCommandBuffer = new byte[5];
			base.MyCommandBuffer[0] = 0;
			base.MyCommandBuffer[1] = 0;
			base.MyCommandBuffer[2] = 2;
			base.MyCommandBuffer[3] = 3;
			base.MyCommandBuffer[4] = this._resetMode;
			return global::Motorola.Common.Communication.TetraMsgOpResult.RP_SUCCESS;
		}

		// Token: 0x040000E8 RID: 232
		private byte _resetMode;
	}
}
