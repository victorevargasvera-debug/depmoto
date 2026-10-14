using System;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.Communication.TetraUtility;
using Motorola.Common.LogUtility;

namespace Motorola.Common.Communication
{
	// Token: 0x02000048 RID: 72
	public class RPGetIndication : global::Motorola.Common.Communication.RPBaseMessage
	{
		// Token: 0x06000212 RID: 530 RVA: 0x000096ED File Offset: 0x000078ED
		public RPGetIndication()
		{
			this._myStatus = global::Motorola.Common.Communication.CommonUtil.RPTerminalStatus.RP_STATUS_UNKNOWN;
			base.HasCommand = false;
		}

		// Token: 0x06000213 RID: 531 RVA: 0x00009703 File Offset: 0x00007903
		public RPGetIndication(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe transPipe)
		{
			this._myStatus = global::Motorola.Common.Communication.CommonUtil.RPTerminalStatus.RP_STATUS_UNKNOWN;
			base.TransportPipe = transPipe;
			base.HasCommand = false;
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000214 RID: 532 RVA: 0x00009720 File Offset: 0x00007920
		public global::Motorola.Common.Communication.CommonUtil.RPTerminalStatus TerminalStatus
		{
			get
			{
				return this._myStatus;
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x06000215 RID: 533 RVA: 0x00009728 File Offset: 0x00007928
		public string IndicationID
		{
			get
			{
				return this._myDevID;
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x06000216 RID: 534 RVA: 0x00009730 File Offset: 0x00007930
		public byte[] RawData
		{
			get
			{
				return this._rawData;
			}
		}

		// Token: 0x06000217 RID: 535 RVA: 0x00009738 File Offset: 0x00007938
		public override void ExecuteMessage()
		{
			global::Motorola.Common.LogUtility.LoggerUtil.SetTimeStampLabel("RPProtocol.GetIndication");
			bool flag = true;
			global::Motorola.Common.Communication.TetraMsgOpResult tetraMsgOpResult = global::Motorola.Common.Communication.TetraMsgOpResult.Undefined;
			int readTimeout = base.Executor.ReadTimeout;
			base.Executor.ReadTimeout = 150;
			base.Executor.TransportPipe.SupressTriggerUSBAnalyzer = true;
			try
			{
				tetraMsgOpResult = base.Executor.SendRequest(base.HasCommand, null, true, out this._myReplyMessageBuffer);
			}
			finally
			{
				base.Executor.ReadTimeout = readTimeout;
			}
			if (tetraMsgOpResult != global::Motorola.Common.Communication.TetraMsgOpResult.RP_SUCCESS)
			{
				flag = false;
			}
			if (flag && this._myReplyMessageBuffer.Length < 13)
			{
				flag = false;
				tetraMsgOpResult = global::Motorola.Common.Communication.TetraMsgOpResult.RP_MSG_WRONG_FORMAT;
			}
			if (flag)
			{
				this._rawData = new byte[this._myReplyMessageBuffer.Length];
				global::System.Array.Copy(this._myReplyMessageBuffer, this._rawData, this._myReplyMessageBuffer.Length);
				tetraMsgOpResult = this.ParseReplyMessage(this._myReplyMessageBuffer);
			}
			base.OperationResult = tetraMsgOpResult;
			base.Executor.TransportPipe.SupressTriggerUSBAnalyzer = false;
			global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.RP_PERFORMANCE_LOGGER_NAME).Performance("RPProtocol.GetIndication", "");
		}

		// Token: 0x06000218 RID: 536 RVA: 0x00009844 File Offset: 0x00007A44
		protected override global::Motorola.Common.Communication.TetraMsgOpResult BuildCommandMessageInternal()
		{
			return global::Motorola.Common.Communication.TetraMsgOpResult.RP_SUCCESS;
		}

		// Token: 0x06000219 RID: 537 RVA: 0x00009848 File Offset: 0x00007A48
		protected override global::Motorola.Common.Communication.TetraMsgOpResult ParseReplyMessage(byte[] buffer)
		{
			bool flag = true;
			global::Motorola.Common.Communication.TetraMsgOpResult tetraMsgOpResult = global::Motorola.Common.Communication.TetraMsgOpResult.Undefined;
			bool flag2 = true;
			if (buffer == null)
			{
				tetraMsgOpResult = global::Motorola.Common.Communication.TetraMsgOpResult.RP_WRONG_PARAMETER;
				flag = false;
			}
			if (flag)
			{
				int num = 3;
				if (buffer[num] != 0)
				{
					tetraMsgOpResult = global::Motorola.Common.Communication.TetraMsgOpResult.RP_MSG_WRONG_FORMAT;
					flag = false;
				}
			}
			if (flag)
			{
				tetraMsgOpResult = base.IsVaildID(buffer, 4, out flag2);
				if (tetraMsgOpResult != global::Motorola.Common.Communication.TetraMsgOpResult.RP_SUCCESS)
				{
					flag = false;
				}
				else if (!flag2)
				{
					flag = false;
					tetraMsgOpResult = global::Motorola.Common.Communication.TetraMsgOpResult.RP_INVALID_ID;
				}
			}
			if (flag)
			{
				int num2 = 4;
				if (global::Motorola.Common.Communication.RPIDMask.RP_TEI_5_5_MASK == (buffer[num2] & global::Motorola.Common.Communication.RPIDMask.RP_ID_SCHEME_MASK))
				{
					tetraMsgOpResult = base.GetMR55IndicationID(buffer, 4, out this._myDevID);
				}
				else if (global::Motorola.Common.Communication.RPIDMask.RP_TEI_5_6_MASK == (buffer[num2] & global::Motorola.Common.Communication.RPIDMask.RP_ID_SCHEME_MASK))
				{
					tetraMsgOpResult = base.GetMR56IndicationID(buffer, 4, out this._myDevID);
				}
				else if (global::Motorola.Common.Communication.RPIDMask.RP_SERIAL_NUMBER_MASK == (buffer[num2] & global::Motorola.Common.Communication.RPIDMask.RP_ID_SCHEME_MASK))
				{
					tetraMsgOpResult = base.GetSNFromIndicationID(buffer, 4, out this._myDevID);
				}
				else if (global::Motorola.Common.Communication.RPIDMask.RP_DIE_ID_MASK == (buffer[num2] & global::Motorola.Common.Communication.RPIDMask.RP_DIE_ID_MASK))
				{
					tetraMsgOpResult = base.GetDieIDFromIndicationID(buffer, 4, out this._myDevID);
				}
				else
				{
					flag = false;
					tetraMsgOpResult = global::Motorola.Common.Communication.TetraMsgOpResult.RP_INVALID_ID_FORMAT;
				}
			}
			if (flag)
			{
				try
				{
					this._myStatus = (global::Motorola.Common.Communication.CommonUtil.RPTerminalStatus)buffer[12];
				}
				catch
				{
					this._myStatus = global::Motorola.Common.Communication.CommonUtil.RPTerminalStatus.RP_STATUS_UNKNOWN;
				}
				tetraMsgOpResult = global::Motorola.Common.Communication.TetraMsgOpResult.RP_SUCCESS;
			}
			return tetraMsgOpResult;
		}

		// Token: 0x040000D0 RID: 208
		private string _myDevID;

		// Token: 0x040000D1 RID: 209
		private global::Motorola.Common.Communication.CommonUtil.RPTerminalStatus _myStatus;

		// Token: 0x040000D2 RID: 210
		private byte[] _rawData;
	}
}
