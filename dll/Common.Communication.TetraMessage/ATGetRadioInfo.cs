using System;
using System.Text.RegularExpressions;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.Communication.TetraUtility;
using Motorola.Common.LogUtility;

namespace Motorola.Common.Communication
{
	// Token: 0x02000009 RID: 9
	public class ATGetRadioInfo : global::Motorola.Common.Communication.ATBaseMessage
	{
		// Token: 0x0600005A RID: 90 RVA: 0x000033C4 File Offset: 0x000015C4
		public ATGetRadioInfo(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe transPipe)
		{
			base.TransportPipe = transPipe;
		}

		// Token: 0x0600005B RID: 91 RVA: 0x000033FC File Offset: 0x000015FC
		public ATGetRadioInfo()
		{
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600005C RID: 92 RVA: 0x00003426 File Offset: 0x00001626
		public global::Motorola.Common.Communication.CommonUtil.RadioManuInfo RadioInfo
		{
			get
			{
				return this._radioInfo;
			}
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00003430 File Offset: 0x00001630
		public override void ExecuteMessage()
		{
			global::Motorola.Common.LogUtility.LoggerUtil.SetTimeStampLabel("ATProtocol.ATGetRadioInfo");
			bool flag = true;
			global::Motorola.Common.Communication.TetraMsgOpResult tetraMsgOpResult = base.Executor.SendRequest(base.HasCommand, this.ATI_READ, base.hasReply, out this._myReplyMessageBuffer, 800);
			if (tetraMsgOpResult != global::Motorola.Common.Communication.TetraMsgOpResult.AT_SUCCESS)
			{
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo((base.TransportPipe as global::Motorola.Common.Communication.CommunicationPipe.TetraCommPipe).PortName, "ATGetRadioInfo failed in ATExecutor.SendRequest, result code is: " + tetraMsgOpResult.ToString());
				flag = false;
			}
			if (flag)
			{
				tetraMsgOpResult = this.ParseReplyMessage(this._myReplyMessageBuffer);
			}
			base.OperationResult = tetraMsgOpResult;
			global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.RP_PERFORMANCE_LOGGER_NAME).Performance("ATProtocol.ATGetRadioInfo", "");
		}

		// Token: 0x0600005E RID: 94 RVA: 0x000034D6 File Offset: 0x000016D6
		protected override global::Motorola.Common.Communication.TetraMsgOpResult BuildCommandMessageInternal()
		{
			base.MyCommandBuffer = new byte[this.ATI_READ.Length];
			global::System.Array.Copy(this.ATI_READ, base.MyCommandBuffer, this.ATI_READ.Length);
			return global::Motorola.Common.Communication.TetraMsgOpResult.AT_SUCCESS;
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00003508 File Offset: 0x00001708
		protected override global::Motorola.Common.Communication.TetraMsgOpResult ParseReplyMessage(byte[] buffer)
		{
			global::Motorola.Common.Communication.TetraMsgOpResult result = global::Motorola.Common.Communication.TetraMsgOpResult.AT_SUCCESS;
			string text = base.MsgDataToString(buffer);
			if (base.IsATCommandOK(text))
			{
				global::System.Text.RegularExpressions.Match match = global::System.Text.RegularExpressions.Regex.Match(text, "Manufacturer: ([^<>]*)<CR><LF>");
				if (match.Success && match.Groups.Count == 2)
				{
					this._radioInfo.Manufacturer = match.Groups[1].ToString();
				}
				match = global::System.Text.RegularExpressions.Regex.Match(text, "Model Type: ([^<>]*)<CR><LF>");
				if (match.Success && match.Groups.Count == 2)
				{
					this._radioInfo.ModelType = match.Groups[1].ToString();
				}
				match = global::System.Text.RegularExpressions.Regex.Match(text, "TEI: ([0-9A-Fa-f]{15})<CR><LF>");
				if (match.Success && match.Groups.Count == 2)
				{
					this._radioInfo.TEI = match.Groups[1].ToString();
				}
				match = global::System.Text.RegularExpressions.Regex.Match(text, "(ISSI|ITSI): ([0-9]*)<CR><LF>");
				if (match.Success && match.Groups.Count == 3)
				{
					this._radioInfo.ISSI = match.Groups[2].ToString();
				}
				match = global::System.Text.RegularExpressions.Regex.Match(text, "(GSSI|GTSI): ([0-9]*)<CR><LF>");
				if (match.Success && match.Groups.Count == 3)
				{
					this._radioInfo.GSSI = match.Groups[2].ToString();
				}
				match = global::System.Text.RegularExpressions.Regex.Match(text, "(Radio_Ver|Radio Ver): ([\\.A-Za-z0-9 ]*)<CR><LF>");
				if (match.Success && match.Groups.Count == 3)
				{
					this._radioInfo.swVer = match.Groups[2].ToString();
				}
				match = global::System.Text.RegularExpressions.Regex.Match(text, "Ctrl_Ver: ([\\.A-Za-z0-9]*)<CR><LF>");
				if (match.Success && match.Groups.Count == 2)
				{
					this._radioInfo.chVer = match.Groups[1].ToString();
				}
				match = global::System.Text.RegularExpressions.Regex.Match(text, "(Birth-OPTA|OPTA): ([A-Za-z0-9]*)<CR><LF>");
				if (match.Success && match.Groups.Count == 3)
				{
					this._radioInfo.OPTA = match.Groups[2].ToString();
				}
				match = global::System.Text.RegularExpressions.Regex.Match(text, "(CPU_HW_ID|CPU HW ID): ([A-Za-z0-9]*)<CR><LF>");
				if (match.Success && match.Groups.Count == 3)
				{
					this._radioInfo.cpuID = match.Groups[2].ToString();
				}
			}
			else
			{
				result = base.GetErrorReason(text);
			}
			return result;
		}

		// Token: 0x04000022 RID: 34
		private readonly byte[] ATI_READ = new byte[]
		{
			65,
			84,
			73,
			13
		};

		// Token: 0x04000023 RID: 35
		private global::Motorola.Common.Communication.CommonUtil.RadioManuInfo _radioInfo = new global::Motorola.Common.Communication.CommonUtil.RadioManuInfo();
	}
}
