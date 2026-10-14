using System;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.Communication.TetraUtility;
using Motorola.Common.LogUtility;

namespace Motorola.Common.Communication
{
	// Token: 0x0200004F RID: 79
	public class RPVerReqReply : global::Motorola.Common.Communication.RPBaseMessage
	{
		// Token: 0x0600023D RID: 573 RVA: 0x00009E17 File Offset: 0x00008017
		public RPVerReqReply()
		{
			base.hasReply = false;
		}

		// Token: 0x0600023E RID: 574 RVA: 0x00009E26 File Offset: 0x00008026
		public RPVerReqReply(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe transPipe)
		{
			base.TransportPipe = transPipe;
			base.hasReply = false;
		}

		// Token: 0x0600023F RID: 575 RVA: 0x00009E3C File Offset: 0x0000803C
		public override void ExecuteMessage()
		{
			global::Motorola.Common.LogUtility.LoggerUtil.SetTimeStampLabel("RPProtocol.RPVerReqReply");
			this.BuildCommandMessageInternal();
			byte[] array;
			global::Motorola.Common.Communication.TetraMsgOpResult operationResult = base.Executor.SendRequest(base.HasCommand, base.MyCommandBuffer, base.hasReply, out array);
			base.OperationResult = operationResult;
			global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.RP_PERFORMANCE_LOGGER_NAME).Performance("RPProtocol.RPVerReqReply", "");
		}

		// Token: 0x06000240 RID: 576 RVA: 0x00009EA0 File Offset: 0x000080A0
		protected override global::Motorola.Common.Communication.TetraMsgOpResult BuildCommandMessageInternal()
		{
			global::Motorola.Common.Communication.TetraMsgOpResult result = global::Motorola.Common.Communication.TetraMsgOpResult.RP_SUCCESS;
			base.MyCommandBuffer = new byte[5];
			base.MyCommandBuffer[0] = 0;
			base.MyCommandBuffer[1] = 0;
			base.MyCommandBuffer[2] = 2;
			base.MyCommandBuffer[3] = 4;
			base.MyCommandBuffer[4] = 0;
			base.hasReply = false;
			return result;
		}
	}
}
