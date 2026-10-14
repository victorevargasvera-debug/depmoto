using System;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.Communication.TetraUtility;
using Motorola.Common.LogUtility;

namespace Motorola.Common.Communication
{
	// Token: 0x02000003 RID: 3
	public class ATCustomMessage : global::Motorola.Common.Communication.ATBaseMessage
	{
		// Token: 0x06000022 RID: 34 RVA: 0x00002700 File Offset: 0x00000900
		public ATCustomMessage(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe transPipe, byte[] msg)
		{
			base.TransportPipe = transPipe;
			base.MyCommandBuffer = msg;
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002716 File Offset: 0x00000916
		public ATCustomMessage(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe transPipe, string msgStr)
		{
			base.TransportPipe = transPipe;
			base.MyCommandBuffer = base.StringToMsgData(msgStr);
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002732 File Offset: 0x00000932
		public ATCustomMessage(byte[] msg)
		{
			base.MyCommandBuffer = msg;
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002741 File Offset: 0x00000941
		public ATCustomMessage(string msgStr)
		{
			base.MyCommandBuffer = base.StringToMsgData(msgStr);
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000026 RID: 38 RVA: 0x00002756 File Offset: 0x00000956
		public string ReplyStr
		{
			get
			{
				return this._replyStr;
			}
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002760 File Offset: 0x00000960
		public override void ExecuteMessage()
		{
			bool flag = true;
			global::Motorola.Common.LogUtility.LoggerUtil.SetTimeStampLabel("ATProtocol.ATCustomMessage");
			global::Motorola.Common.Communication.TetraMsgOpResult tetraMsgOpResult = base.Executor.SendRequest(base.HasCommand, base.MyCommandBuffer, base.hasReply, out this._myReplyMessageBuffer, 1000);
			if (tetraMsgOpResult != global::Motorola.Common.Communication.TetraMsgOpResult.AT_SUCCESS)
			{
				flag = false;
			}
			if (flag)
			{
				tetraMsgOpResult = this.ParseReplyMessage(this._myReplyMessageBuffer);
			}
			base.OperationResult = tetraMsgOpResult;
			global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.RP_PERFORMANCE_LOGGER_NAME).Performance("ATProtocol.ATCustomMessage", "");
		}

		// Token: 0x06000028 RID: 40 RVA: 0x000027DC File Offset: 0x000009DC
		protected override global::Motorola.Common.Communication.TetraMsgOpResult BuildCommandMessageInternal()
		{
			return global::Motorola.Common.Communication.TetraMsgOpResult.AT_SUCCESS;
		}

		// Token: 0x06000029 RID: 41 RVA: 0x000027E0 File Offset: 0x000009E0
		protected override global::Motorola.Common.Communication.TetraMsgOpResult ParseReplyMessage(byte[] buffer)
		{
			global::Motorola.Common.Communication.TetraMsgOpResult result = global::Motorola.Common.Communication.TetraMsgOpResult.AT_SUCCESS;
			bool flag = true;
			if (buffer == null || buffer.Length == 0)
			{
				result = global::Motorola.Common.Communication.TetraMsgOpResult.AT_RECEIVE_MESSAGE_ERROR;
				flag = false;
			}
			if (flag)
			{
				this._replyStr = base.MsgDataToString(buffer);
				if (string.IsNullOrEmpty(this._replyStr))
				{
					result = global::Motorola.Common.Communication.TetraMsgOpResult.AT_PARSE_REPLY_ERROR;
				}
			}
			return result;
		}

		// Token: 0x0400000F RID: 15
		private string _replyStr;
	}
}
