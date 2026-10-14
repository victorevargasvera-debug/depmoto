using System;
using System.Text.RegularExpressions;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.Communication.TetraUtility;
using Motorola.Common.LogUtility;

namespace Motorola.Common.Communication
{
	// Token: 0x02000007 RID: 7
	public class ATGetDeviceMode : global::Motorola.Common.Communication.ATBaseMessage
	{
		// Token: 0x0600004D RID: 77 RVA: 0x00003001 File Offset: 0x00001201
		public ATGetDeviceMode(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe transPipe)
		{
			base.TransportPipe = transPipe;
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00003039 File Offset: 0x00001239
		public ATGetDeviceMode()
		{
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600004F RID: 79 RVA: 0x00003060 File Offset: 0x00001260
		public global::Motorola.Common.Communication.CommonUtil.DeviceMode DevMode
		{
			get
			{
				return this._devMode;
			}
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00003068 File Offset: 0x00001268
		public override void ExecuteMessage()
		{
			global::Motorola.Common.LogUtility.LoggerUtil.SetTimeStampLabel("ATProtocol.ATGetRadioMode");
			bool flag = true;
			global::Motorola.Common.Communication.TetraMsgOpResult tetraMsgOpResult = base.Executor.SendRequest(base.HasCommand, this.AT_CFUN_READ, base.hasReply, out this._myReplyMessageBuffer, 200);
			if (tetraMsgOpResult != global::Motorola.Common.Communication.TetraMsgOpResult.AT_SUCCESS)
			{
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo((base.TransportPipe as global::Motorola.Common.Communication.CommunicationPipe.TetraCommPipe).PortName, "ATGetDeviceMode failed in ATExecutor.SendRequest, result code is: " + tetraMsgOpResult.ToString());
				flag = false;
			}
			if (flag)
			{
				tetraMsgOpResult = this.ParseReplyMessage(this._myReplyMessageBuffer);
			}
			base.OperationResult = tetraMsgOpResult;
			global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.RP_PERFORMANCE_LOGGER_NAME).Performance("ATProtocol.ATGetRadioMode", "");
		}

		// Token: 0x06000051 RID: 81 RVA: 0x0000310E File Offset: 0x0000130E
		protected override global::Motorola.Common.Communication.TetraMsgOpResult BuildCommandMessageInternal()
		{
			base.MyCommandBuffer = new byte[this.AT_CFUN_READ.Length];
			global::System.Array.Copy(this.AT_CFUN_READ, base.MyCommandBuffer, this.AT_CFUN_READ.Length);
			return global::Motorola.Common.Communication.TetraMsgOpResult.AT_SUCCESS;
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00003140 File Offset: 0x00001340
		protected override global::Motorola.Common.Communication.TetraMsgOpResult ParseReplyMessage(byte[] buffer)
		{
			global::Motorola.Common.Communication.TetraMsgOpResult result = global::Motorola.Common.Communication.TetraMsgOpResult.AT_SUCCESS;
			string input = base.MsgDataToString(buffer);
			global::System.Text.RegularExpressions.Regex regex = new global::System.Text.RegularExpressions.Regex("<CR><LF>\\+CFUN: ([0-9]*)<CR><LF>");
			global::System.Text.RegularExpressions.Match match = regex.Match(input);
			if (match.Success && match.Groups.Count == 2)
			{
				string text = match.Groups[1].ToString();
				string a;
				if ((a = text) != null)
				{
					if (a == "1")
					{
						this._devMode = global::Motorola.Common.Communication.CommonUtil.DeviceMode.NORMAL;
						return result;
					}
					if (a == "5")
					{
						this._devMode = global::Motorola.Common.Communication.CommonUtil.DeviceMode.CHARGING;
						return result;
					}
				}
				this._devMode = global::Motorola.Common.Communication.CommonUtil.DeviceMode.UNKNOWN;
			}
			else
			{
				result = global::Motorola.Common.Communication.TetraMsgOpResult.AT_PARSE_REPLY_ERROR;
			}
			return result;
		}

		// Token: 0x0400001D RID: 29
		private readonly byte[] AT_CFUN_READ = new byte[]
		{
			65,
			84,
			43,
			67,
			70,
			85,
			78,
			63,
			13
		};

		// Token: 0x0400001E RID: 30
		private global::Motorola.Common.Communication.CommonUtil.DeviceMode _devMode = global::Motorola.Common.Communication.CommonUtil.DeviceMode.UNKNOWN;
	}
}
