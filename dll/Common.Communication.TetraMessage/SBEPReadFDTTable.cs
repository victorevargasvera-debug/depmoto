using System;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.Communication.TetraUtility;
using Motorola.Common.LogUtility;

namespace Motorola.Common.Communication
{
	// Token: 0x02000031 RID: 49
	public class SBEPReadFDTTable : global::Motorola.Common.Communication.SBEPBaseRead
	{
		// Token: 0x0600018D RID: 397 RVA: 0x000082BD File Offset: 0x000064BD
		public SBEPReadFDTTable()
		{
			base.InternalStartAddress = this.FDT_START_ADDRESS;
			base.ExpectedReadLength = this.MAX_FDT_TABLE_SIZE;
		}

		// Token: 0x0600018E RID: 398 RVA: 0x000082F3 File Offset: 0x000064F3
		public SBEPReadFDTTable(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe transPipe)
		{
			base.TransportPipe = transPipe;
			base.InternalStartAddress = this.FDT_START_ADDRESS;
			base.ExpectedReadLength = this.MAX_FDT_TABLE_SIZE;
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x0600018F RID: 399 RVA: 0x00008330 File Offset: 0x00006530
		public byte[] FDTTable
		{
			get
			{
				return base.ReceivedData;
			}
		}

		// Token: 0x06000190 RID: 400 RVA: 0x00008338 File Offset: 0x00006538
		public override void ExecuteMessage()
		{
			global::Motorola.Common.LogUtility.LoggerUtil.SetTimeStampLabel("SBEPProtocol.ReadFDTTable");
			base.ExecuteMessage();
			if (base.OperationResult == global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_SUCCESS && base.InternalStartAddress != this.FDT_START_ADDRESS)
			{
				base.OperationResult = global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_ERROR;
			}
			global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.SBEP_PERFORMANCE_LOGGER_NAME).Performance("SBEPProtocol.ReadFDTTable", "");
		}

		// Token: 0x06000191 RID: 401 RVA: 0x0000838C File Offset: 0x0000658C
		protected override global::Motorola.Common.Communication.TetraMsgOpResult ParseReplyMessage(byte[] buffer, ushort uOpCode)
		{
			base.ParseReplyMessage(buffer, uOpCode);
			if (base.OperationResult == global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_SUCCESS && base.InternalStartAddress != this.FDT_START_ADDRESS)
			{
				base.OperationResult = global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_ERROR;
			}
			return base.OperationResult;
		}

		// Token: 0x04000085 RID: 133
		private readonly uint FDT_START_ADDRESS = 4294967068U;

		// Token: 0x04000086 RID: 134
		private readonly ushort MAX_FDT_TABLE_SIZE = 1000;
	}
}
