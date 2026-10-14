using System;
using System.Collections.Generic;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.Communication.TetraUtility;
using Motorola.Common.LogUtility;

namespace Motorola.Common.Communication
{
	// Token: 0x0200000B RID: 11
	public class ATEraseDMS : global::Motorola.Common.Communication.ATBaseMessage
	{
		// Token: 0x06000065 RID: 101 RVA: 0x00003954 File Offset: 0x00001B54
		public ATEraseDMS(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe transPipe, string accessCode)
		{
			base.TransportPipe = transPipe;
			global::System.Collections.Generic.List<byte> list = new global::System.Collections.Generic.List<byte>();
			list.AddRange(this.AT_DMSERS);
			foreach (char c in accessCode)
			{
				list.Add((byte)c);
			}
			list.Add(13);
			this.commandMsg = list.ToArray();
		}

		// Token: 0x06000066 RID: 102 RVA: 0x000039D0 File Offset: 0x00001BD0
		public override void ExecuteMessage()
		{
			global::Motorola.Common.LogUtility.LoggerUtil.SetTimeStampLabel("ATProtocol.ATEraseDMS");
			bool flag = true;
			global::Motorola.Common.Communication.TetraMsgOpResult tetraMsgOpResult = base.Executor.SendRequest(true, this.commandMsg, true, out this._myReplyMessageBuffer, 2000);
			if (tetraMsgOpResult != global::Motorola.Common.Communication.TetraMsgOpResult.AT_SUCCESS)
			{
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo((base.TransportPipe as global::Motorola.Common.Communication.CommunicationPipe.TetraCommPipe).PortName, "ATEraseDMS failed in ATExecutor.SendRequest, result code is: " + tetraMsgOpResult.ToString());
				flag = false;
			}
			if (flag)
			{
				tetraMsgOpResult = this.ParseReplyMessage(this._myReplyMessageBuffer);
			}
			base.OperationResult = tetraMsgOpResult;
			global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.RP_PERFORMANCE_LOGGER_NAME).Performance("ATProtocol.ATEraseDMS", "");
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00003A6C File Offset: 0x00001C6C
		protected override global::Motorola.Common.Communication.TetraMsgOpResult BuildCommandMessageInternal()
		{
			global::System.Array.Copy(this.commandMsg, base.MyCommandBuffer, this.commandMsg.Length);
			return global::Motorola.Common.Communication.TetraMsgOpResult.AT_SUCCESS;
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00003A8C File Offset: 0x00001C8C
		protected override global::Motorola.Common.Communication.TetraMsgOpResult ParseReplyMessage(byte[] buffer)
		{
			global::Motorola.Common.Communication.TetraMsgOpResult result = global::Motorola.Common.Communication.TetraMsgOpResult.AT_SUCCESS;
			if (!base.IsATCommandOK(buffer))
			{
				result = base.GetErrorReason(buffer);
			}
			return result;
		}

		// Token: 0x04000027 RID: 39
		private readonly byte[] AT_DMSERS = new byte[]
		{
			65,
			84,
			43,
			77,
			67,
			68,
			77,
			83,
			69,
			82,
			83,
			61
		};

		// Token: 0x04000028 RID: 40
		private byte[] commandMsg;
	}
}
