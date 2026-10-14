using System;
using System.Text.RegularExpressions;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.Communication.TetraUtility;
using Motorola.Common.LogUtility;

namespace Motorola.Common.Communication
{
	// Token: 0x02000008 RID: 8
	public class ATGetEmergencyStatus : global::Motorola.Common.Communication.ATBaseMessage
	{
		// Token: 0x06000053 RID: 83 RVA: 0x000031E1 File Offset: 0x000013E1
		public ATGetEmergencyStatus(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe transPipe)
		{
			base.TransportPipe = transPipe;
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00003211 File Offset: 0x00001411
		public ATGetEmergencyStatus()
		{
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000055 RID: 85 RVA: 0x00003231 File Offset: 0x00001431
		public bool IsEmergencyMode
		{
			get
			{
				return this._bInEmergency;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000056 RID: 86 RVA: 0x00003239 File Offset: 0x00001439
		public bool EmergencyUnsolicEnabled
		{
			get
			{
				return this._bEmergencyUnsolic;
			}
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00003244 File Offset: 0x00001444
		public override void ExecuteMessage()
		{
			global::Motorola.Common.LogUtility.LoggerUtil.SetTimeStampLabel("ATProtocol.ATGetEmergencyStatus");
			bool flag = true;
			global::Motorola.Common.Communication.TetraMsgOpResult tetraMsgOpResult = base.Executor.SendRequest(base.HasCommand, this.AT_READ_EMER, base.hasReply, out this._myReplyMessageBuffer, 200);
			if (tetraMsgOpResult != global::Motorola.Common.Communication.TetraMsgOpResult.AT_SUCCESS)
			{
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo((base.TransportPipe as global::Motorola.Common.Communication.CommunicationPipe.TetraCommPipe).PortName, "ATGetEmergencyStatus failed in ATExecutor.SendRequest, result code is: " + tetraMsgOpResult.ToString());
				flag = false;
			}
			if (flag)
			{
				tetraMsgOpResult = this.ParseReplyMessage(this._myReplyMessageBuffer);
			}
			base.OperationResult = tetraMsgOpResult;
			global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.RP_PERFORMANCE_LOGGER_NAME).Performance("ATProtocol.ATGetEmergencyStatus", "");
		}

		// Token: 0x06000058 RID: 88 RVA: 0x000032EA File Offset: 0x000014EA
		protected override global::Motorola.Common.Communication.TetraMsgOpResult BuildCommandMessageInternal()
		{
			base.MyCommandBuffer = new byte[this.AT_READ_EMER.Length];
			global::System.Array.Copy(this.AT_READ_EMER, base.MyCommandBuffer, this.AT_READ_EMER.Length);
			return global::Motorola.Common.Communication.TetraMsgOpResult.AT_SUCCESS;
		}

		// Token: 0x06000059 RID: 89 RVA: 0x0000331C File Offset: 0x0000151C
		protected override global::Motorola.Common.Communication.TetraMsgOpResult ParseReplyMessage(byte[] buffer)
		{
			global::Motorola.Common.Communication.TetraMsgOpResult result = global::Motorola.Common.Communication.TetraMsgOpResult.AT_SUCCESS;
			string input = base.MsgDataToString(buffer);
			global::System.Text.RegularExpressions.Regex regex = new global::System.Text.RegularExpressions.Regex("<CR><LF>\\+EMER: ([0-9]*),([0-9]*)<CR><LF>");
			global::System.Text.RegularExpressions.Match match = regex.Match(input);
			if (match.Success && match.Groups.Count == 3)
			{
				string a = match.Groups[1].ToString();
				string a2 = match.Groups[2].ToString();
				this._bEmergencyUnsolic = (a == "1");
				this._bInEmergency = (a2 == "1");
			}
			else
			{
				result = global::Motorola.Common.Communication.TetraMsgOpResult.AT_PARSE_REPLY_ERROR;
			}
			return result;
		}

		// Token: 0x0400001F RID: 31
		private readonly byte[] AT_READ_EMER = new byte[]
		{
			65,
			84,
			43,
			69,
			77,
			69,
			82,
			63,
			13
		};

		// Token: 0x04000020 RID: 32
		private bool _bInEmergency;

		// Token: 0x04000021 RID: 33
		private bool _bEmergencyUnsolic;
	}
}
