using System;
using System.Collections.Generic;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.Communication.TetraUtility;
using Motorola.Common.LogUtility;

namespace Motorola.Common.Communication
{
	// Token: 0x0200000C RID: 12
	public class ATChangeDMSAccessCode : global::Motorola.Common.Communication.ATBaseMessage
	{
		// Token: 0x06000069 RID: 105 RVA: 0x00003AC0 File Offset: 0x00001CC0
		public ATChangeDMSAccessCode(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe transPipe, string accessCode, string defaultAccessCode)
		{
			base.TransportPipe = transPipe;
			global::System.Collections.Generic.List<byte> list = new global::System.Collections.Generic.List<byte>();
			list.AddRange(this.AT_DMSCHCOD);
			foreach (char c in defaultAccessCode)
			{
				list.Add((byte)c);
			}
			list.Add(44);
			foreach (char c2 in accessCode)
			{
				list.Add((byte)c2);
			}
			list.Add(13);
			this.commandMsg = list.ToArray();
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00003B74 File Offset: 0x00001D74
		public override void ExecuteMessage()
		{
			global::Motorola.Common.LogUtility.LoggerUtil.SetTimeStampLabel("ATProtocol.ATChangeDMSAccessCode");
			bool flag = true;
			global::Motorola.Common.Communication.TetraMsgOpResult tetraMsgOpResult = base.Executor.SendRequest(true, this.commandMsg, true, out this._myReplyMessageBuffer, 1000);
			if (tetraMsgOpResult != global::Motorola.Common.Communication.TetraMsgOpResult.AT_SUCCESS)
			{
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo((base.TransportPipe as global::Motorola.Common.Communication.CommunicationPipe.TetraCommPipe).PortName, "ATChangeDMSAccessCode failed in ATExecutor.SendRequest, result code is: " + tetraMsgOpResult.ToString());
				flag = false;
			}
			if (flag)
			{
				tetraMsgOpResult = this.ParseReplyMessage(this._myReplyMessageBuffer);
			}
			base.OperationResult = tetraMsgOpResult;
			global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.RP_PERFORMANCE_LOGGER_NAME).Performance("ATProtocol.ATChangeDMSAccessCode", "");
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00003C10 File Offset: 0x00001E10
		protected override global::Motorola.Common.Communication.TetraMsgOpResult BuildCommandMessageInternal()
		{
			global::System.Array.Copy(this.commandMsg, base.MyCommandBuffer, this.commandMsg.Length);
			return global::Motorola.Common.Communication.TetraMsgOpResult.AT_SUCCESS;
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00003C30 File Offset: 0x00001E30
		protected override global::Motorola.Common.Communication.TetraMsgOpResult ParseReplyMessage(byte[] buffer)
		{
			global::Motorola.Common.Communication.TetraMsgOpResult result = global::Motorola.Common.Communication.TetraMsgOpResult.AT_SUCCESS;
			if (!base.IsATCommandOK(buffer))
			{
				result = base.GetErrorReason(buffer);
			}
			return result;
		}

		// Token: 0x04000029 RID: 41
		private readonly byte[] AT_DMSCHCOD = new byte[]
		{
			65,
			84,
			43,
			77,
			67,
			68,
			77,
			83,
			67,
			72,
			67,
			79,
			68,
			61
		};

		// Token: 0x0400002A RID: 42
		private byte[] commandMsg;
	}
}
