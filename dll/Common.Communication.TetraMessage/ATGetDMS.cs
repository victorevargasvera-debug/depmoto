using System;
using System.Collections.Generic;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.Communication.TetraUtility;
using Motorola.Common.LogUtility;

namespace Motorola.Common.Communication
{
	// Token: 0x0200000A RID: 10
	public class ATGetDMS : global::Motorola.Common.Communication.ATBaseMessage
	{
		// Token: 0x06000060 RID: 96 RVA: 0x00003774 File Offset: 0x00001974
		public ATGetDMS(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe transPipe, string accessCode)
		{
			base.TransportPipe = transPipe;
			base.Executor.UseLargeBuffer = true;
			global::System.Collections.Generic.List<byte> list = new global::System.Collections.Generic.List<byte>();
			list.AddRange(this.AT_DMSEXT);
			foreach (char c in accessCode)
			{
				list.Add((byte)c);
			}
			list.Add(13);
			this.commandMsg = list.ToArray();
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000061 RID: 97 RVA: 0x00003806 File Offset: 0x00001A06
		public string DMSData
		{
			get
			{
				return this._dmsData;
			}
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00003810 File Offset: 0x00001A10
		public override void ExecuteMessage()
		{
			global::Motorola.Common.LogUtility.LoggerUtil.SetTimeStampLabel("ATProtocol.ATGetDMS");
			bool flag = true;
			global::Motorola.Common.Communication.TetraMsgOpResult tetraMsgOpResult = base.Executor.SendRequest(true, this.commandMsg, true, out this._myReplyMessageBuffer, 2000);
			if (tetraMsgOpResult != global::Motorola.Common.Communication.TetraMsgOpResult.AT_SUCCESS)
			{
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo((base.TransportPipe as global::Motorola.Common.Communication.CommunicationPipe.TetraCommPipe).PortName, "ATGetDMS failed in ATExecutor.SendRequest, result code is: " + tetraMsgOpResult.ToString());
				flag = false;
			}
			if (flag)
			{
				tetraMsgOpResult = this.ParseReplyMessage(this._myReplyMessageBuffer);
			}
			base.OperationResult = tetraMsgOpResult;
			global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.RP_PERFORMANCE_LOGGER_NAME).Performance("ATProtocol.ATGetDMS", "");
		}

		// Token: 0x06000063 RID: 99 RVA: 0x000038AC File Offset: 0x00001AAC
		protected override global::Motorola.Common.Communication.TetraMsgOpResult BuildCommandMessageInternal()
		{
			global::System.Array.Copy(this.commandMsg, base.MyCommandBuffer, this.commandMsg.Length);
			return global::Motorola.Common.Communication.TetraMsgOpResult.AT_SUCCESS;
		}

		// Token: 0x06000064 RID: 100 RVA: 0x000038CC File Offset: 0x00001ACC
		protected override global::Motorola.Common.Communication.TetraMsgOpResult ParseReplyMessage(byte[] buffer)
		{
			global::Motorola.Common.Communication.TetraMsgOpResult result = global::Motorola.Common.Communication.TetraMsgOpResult.AT_SUCCESS;
			string text = base.MsgDataToString(buffer);
			if (base.IsATCommandOK(text))
			{
				this._dmsData = text.Replace("<CR><LF>OK<CR><LF>", "").Replace("<CR><LF>", "\r\n").Replace("\r\n\r\n", "\r\n").TrimStart(new char[]
				{
					'\r',
					'\n'
				});
			}
			else
			{
				result = base.GetErrorReason(text);
			}
			return result;
		}

		// Token: 0x04000024 RID: 36
		private readonly byte[] AT_DMSEXT = new byte[]
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
			88,
			84,
			61
		};

		// Token: 0x04000025 RID: 37
		private byte[] commandMsg;

		// Token: 0x04000026 RID: 38
		private string _dmsData = string.Empty;
	}
}
