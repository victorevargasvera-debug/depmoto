using System;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.Communication.TetraUtility;
using Motorola.Common.LogUtility;

namespace Motorola.Common.Communication
{
	// Token: 0x02000029 RID: 41
	public class SBEPGetTEI : global::Motorola.Common.Communication.SBEPBaseRead
	{
		// Token: 0x06000156 RID: 342 RVA: 0x0000759A File Offset: 0x0000579A
		public SBEPGetTEI()
		{
			base.InternalStartAddress = this.TEI_START_ADDRESS;
			base.ExpectedReadLength = this.TEI_LENGTH;
		}

		// Token: 0x06000157 RID: 343 RVA: 0x000075CC File Offset: 0x000057CC
		public SBEPGetTEI(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe transPipe)
		{
			base.InternalStartAddress = this.TEI_START_ADDRESS;
			base.ExpectedReadLength = this.TEI_LENGTH;
			base.TransportPipe = transPipe;
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000158 RID: 344 RVA: 0x00007605 File Offset: 0x00005805
		public byte[] TEI
		{
			get
			{
				return this._myRadioTEI;
			}
		}

		// Token: 0x06000159 RID: 345 RVA: 0x00007610 File Offset: 0x00005810
		public override void ExecuteMessage()
		{
			global::Motorola.Common.LogUtility.LoggerUtil.SetTimeStampLabel("SBEPProtocol.GetTEI");
			base.ExecuteMessage();
			if (base.OperationResult == global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_SUCCESS)
			{
				this._myRadioTEI = base.ReceivedData;
				if (this._myRadioTEI.Length != (int)this.TEI_LENGTH)
				{
					base.OperationResult = global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_ERROR;
				}
			}
			global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.SBEP_PERFORMANCE_LOGGER_NAME).Performance("SBEPProtocol.GetTEI", "");
		}

		// Token: 0x0600015A RID: 346 RVA: 0x00007672 File Offset: 0x00005872
		protected override global::Motorola.Common.Communication.TetraMsgOpResult ParseReplyMessage(byte[] buffer, ushort uOpCode)
		{
			base.ParseReplyMessage(buffer, uOpCode);
			if (base.OperationResult == global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_SUCCESS)
			{
				this._myRadioTEI = base.ReceivedData;
				if (this._myRadioTEI.Length != (int)this.TEI_LENGTH)
				{
					base.OperationResult = global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_ERROR;
				}
			}
			return base.OperationResult;
		}

		// Token: 0x04000073 RID: 115
		private byte[] _myRadioTEI;

		// Token: 0x04000074 RID: 116
		private readonly ushort TEI_LENGTH = 8;

		// Token: 0x04000075 RID: 117
		private readonly uint TEI_START_ADDRESS = 4294967067U;
	}
}
