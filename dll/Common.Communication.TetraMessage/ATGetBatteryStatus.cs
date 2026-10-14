using System;
using System.Text.RegularExpressions;
using System.Threading;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.Communication.TetraUtility;
using Motorola.Common.LogUtility;

namespace Motorola.Common.Communication
{
	// Token: 0x02000006 RID: 6
	public class ATGetBatteryStatus : global::Motorola.Common.Communication.ATBaseMessage
	{
		// Token: 0x06000044 RID: 68 RVA: 0x00002C6C File Offset: 0x00000E6C
		public ATGetBatteryStatus(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe transPipe, global::Motorola.Common.Communication.BatteryStatusMode mode)
		{
			base.TransportPipe = transPipe;
			this._mode = mode;
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00002CD4 File Offset: 0x00000ED4
		public ATGetBatteryStatus(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe transPipe)
		{
			base.TransportPipe = transPipe;
			this._mode = global::Motorola.Common.Communication.BatteryStatusMode.VOLUNTARY;
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00002D39 File Offset: 0x00000F39
		public ATGetBatteryStatus(global::Motorola.Common.Communication.BatteryStatusMode mode)
		{
			this._mode = mode;
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00002D89 File Offset: 0x00000F89
		public ATGetBatteryStatus()
		{
			this._mode = global::Motorola.Common.Communication.BatteryStatusMode.VOLUNTARY;
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000048 RID: 72 RVA: 0x00002DC7 File Offset: 0x00000FC7
		public int BCS
		{
			get
			{
				return this._bcs;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000049 RID: 73 RVA: 0x00002DCF File Offset: 0x00000FCF
		public int BCL
		{
			get
			{
				return this._bcl;
			}
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00002DD8 File Offset: 0x00000FD8
		public override void ExecuteMessage()
		{
			global::Motorola.Common.LogUtility.LoggerUtil.SetTimeStampLabel("ATProtocol.ATGetBatteryStatus");
			if (this._mode == global::Motorola.Common.Communication.BatteryStatusMode.VOLUNTARY)
			{
				global::Motorola.Common.Communication.TetraMsgOpResult tetraMsgOpResult = base.Executor.SendRequest(base.HasCommand, this.AT_CBC_READ, base.hasReply, out this._myReplyMessageBuffer, 400);
				if (tetraMsgOpResult == global::Motorola.Common.Communication.TetraMsgOpResult.AT_SUCCESS)
				{
					tetraMsgOpResult = this.ParseReplyMessage(this._myReplyMessageBuffer);
				}
				else
				{
					global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo((base.TransportPipe as global::Motorola.Common.Communication.CommunicationPipe.TetraCommPipe).PortName, "ATGetBatteryStatus failed in ATExecutor.SendRequest, result code is: " + tetraMsgOpResult.ToString());
				}
				base.OperationResult = tetraMsgOpResult;
			}
			else
			{
				bool flag = true;
				global::Motorola.Common.Communication.TetraMsgOpResult tetraMsgOpResult = base.Executor.SendRequest(base.HasCommand, this.AT_CBC_ENABLE_NOTIFICATION, base.hasReply, out this._myReplyMessageBuffer, 200);
				if (tetraMsgOpResult != global::Motorola.Common.Communication.TetraMsgOpResult.AT_SUCCESS)
				{
					flag = false;
				}
				else
				{
					global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo((base.TransportPipe as global::Motorola.Common.Communication.CommunicationPipe.TetraCommPipe).PortName, "ATGetBatteryStatus failed in ATExecutor.SendRequest, result code is: " + tetraMsgOpResult.ToString());
				}
				if (flag && base.IsATCommandOK(this._myReplyMessageBuffer))
				{
					for (;;)
					{
						tetraMsgOpResult = base.Executor.SendRequest(false, null, true, out this._myReplyMessageBuffer);
						if (tetraMsgOpResult == global::Motorola.Common.Communication.TetraMsgOpResult.AT_SUCCESS)
						{
							tetraMsgOpResult = this.ParseReplyMessage(this._myReplyMessageBuffer);
							if (tetraMsgOpResult == global::Motorola.Common.Communication.TetraMsgOpResult.AT_SUCCESS)
							{
								break;
							}
							global::System.Threading.Thread.Sleep(2000);
						}
						else
						{
							global::System.Threading.Thread.Sleep(2000);
						}
					}
				}
				base.OperationResult = tetraMsgOpResult;
			}
			global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.RP_PERFORMANCE_LOGGER_NAME).Performance("ATProtocol.ATGetBatteryStatus", "");
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00002F40 File Offset: 0x00001140
		protected override global::Motorola.Common.Communication.TetraMsgOpResult BuildCommandMessageInternal()
		{
			base.MyCommandBuffer = new byte[this.AT_CBC_READ.Length];
			global::System.Array.Copy(this.AT_CBC_READ, base.MyCommandBuffer, this.AT_CBC_READ.Length);
			return global::Motorola.Common.Communication.TetraMsgOpResult.AT_SUCCESS;
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00002F70 File Offset: 0x00001170
		protected override global::Motorola.Common.Communication.TetraMsgOpResult ParseReplyMessage(byte[] buffer)
		{
			global::Motorola.Common.Communication.TetraMsgOpResult result = global::Motorola.Common.Communication.TetraMsgOpResult.AT_SUCCESS;
			string input = base.MsgDataToString(buffer);
			global::System.Text.RegularExpressions.Regex regex = new global::System.Text.RegularExpressions.Regex("<CR><LF>\\+CBC: ([0-9]*),([0-9]*)<CR><LF>");
			global::System.Text.RegularExpressions.Match match = regex.Match(input);
			if (match.Success && match.Groups.Count == 3)
			{
				string value = match.Groups[1].ToString();
				string value2 = match.Groups[2].ToString();
				this._bcs = global::System.Convert.ToInt32(value);
				this._bcl = global::System.Convert.ToInt32(value2);
			}
			else
			{
				result = global::Motorola.Common.Communication.TetraMsgOpResult.AT_PARSE_REPLY_ERROR;
			}
			return result;
		}

		// Token: 0x04000018 RID: 24
		private readonly byte[] AT_CBC_READ = new byte[]
		{
			65,
			84,
			43,
			67,
			66,
			67,
			63,
			13
		};

		// Token: 0x04000019 RID: 25
		private readonly byte[] AT_CBC_ENABLE_NOTIFICATION = new byte[]
		{
			65,
			84,
			43,
			67,
			66,
			67,
			61,
			49,
			13
		};

		// Token: 0x0400001A RID: 26
		private int _bcs;

		// Token: 0x0400001B RID: 27
		private int _bcl;

		// Token: 0x0400001C RID: 28
		private global::Motorola.Common.Communication.BatteryStatusMode _mode;
	}
}
