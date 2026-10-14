using System;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.Communication.TetraUtility;
using Motorola.Common.LogUtility;

namespace Motorola.Common.Communication
{
	// Token: 0x02000028 RID: 40
	public class SBEPGetSessionID : global::Motorola.Common.Communication.SBEPBaseRead
	{
		// Token: 0x06000151 RID: 337 RVA: 0x0000741A File Offset: 0x0000561A
		public SBEPGetSessionID()
		{
			base.InternalStartAddress = this.SESSION_ID_ADDRESS;
			base.ExpectedReadLength = this.SESSION_ID_LENGTH;
			this._mySessionID = 0U;
		}

		// Token: 0x06000152 RID: 338 RVA: 0x00007453 File Offset: 0x00005653
		public SBEPGetSessionID(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe transPipe)
		{
			base.TransportPipe = transPipe;
			base.InternalStartAddress = this.SESSION_ID_ADDRESS;
			base.ExpectedReadLength = this.SESSION_ID_LENGTH;
			this._mySessionID = 0U;
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000153 RID: 339 RVA: 0x00007493 File Offset: 0x00005693
		public uint SessionID
		{
			get
			{
				return this._mySessionID;
			}
		}

		// Token: 0x06000154 RID: 340 RVA: 0x0000749C File Offset: 0x0000569C
		public override void ExecuteMessage()
		{
			global::Motorola.Common.LogUtility.LoggerUtil.SetTimeStampLabel("SBEPProtocol.GetSessionID");
			base.ExecuteMessage();
			if (base.OperationResult == global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_SUCCESS)
			{
				byte[] receivedData = base.ReceivedData;
				if (receivedData.Length == (int)this.SESSION_ID_LENGTH)
				{
					byte[] bytes = global::System.BitConverter.GetBytes(this._mySessionID);
					base.OperationResult = global::Motorola.Common.Communication.SBEPCommon.ReverseBytesAndCopy(bytes, 0, receivedData, 0, 4);
					if (base.OperationResult == global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_SUCCESS)
					{
						this._mySessionID = global::System.BitConverter.ToUInt32(bytes, 0);
					}
				}
				else
				{
					base.OperationResult = global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_ERROR;
				}
			}
			global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.SBEP_PERFORMANCE_LOGGER_NAME).Performance("SBEPProtocol.GetSessionID", "");
		}

		// Token: 0x06000155 RID: 341 RVA: 0x00007528 File Offset: 0x00005728
		protected override global::Motorola.Common.Communication.TetraMsgOpResult ParseReplyMessage(byte[] buffer, ushort uOpCode)
		{
			base.ParseReplyMessage(buffer, uOpCode);
			if (base.OperationResult == global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_SUCCESS)
			{
				byte[] receivedData = base.ReceivedData;
				if (receivedData.Length == (int)this.SESSION_ID_LENGTH)
				{
					byte[] bytes = global::System.BitConverter.GetBytes(this._mySessionID);
					base.OperationResult = global::Motorola.Common.Communication.SBEPCommon.ReverseBytesAndCopy(bytes, 0, receivedData, 0, 4);
					if (base.OperationResult == global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_SUCCESS)
					{
						this._mySessionID = global::System.BitConverter.ToUInt32(bytes, 0);
					}
				}
				else
				{
					base.OperationResult = global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_ERROR;
				}
			}
			return base.OperationResult;
		}

		// Token: 0x04000070 RID: 112
		private readonly uint SESSION_ID_ADDRESS = 4294967066U;

		// Token: 0x04000071 RID: 113
		private readonly ushort SESSION_ID_LENGTH = 8;

		// Token: 0x04000072 RID: 114
		private uint _mySessionID;
	}
}
