using System;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.Communication.TetraUtility;
using Motorola.Common.LogUtility;

namespace Motorola.Common.Communication
{
	// Token: 0x02000045 RID: 69
	public class SBEPWriteFDTTable : global::Motorola.Common.Communication.SBEPBaseWrite
	{
		// Token: 0x06000206 RID: 518 RVA: 0x000094FD File Offset: 0x000076FD
		public SBEPWriteFDTTable(byte[] fdtData)
		{
			this._myFDTData = fdtData;
			base.InternalStartAddress = this.FDT_START_ADDRESS;
		}

		// Token: 0x06000207 RID: 519 RVA: 0x00009527 File Offset: 0x00007727
		public SBEPWriteFDTTable()
		{
			base.InternalStartAddress = this.FDT_START_ADDRESS;
		}

		// Token: 0x06000208 RID: 520 RVA: 0x0000954A File Offset: 0x0000774A
		public SBEPWriteFDTTable(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe transPipe, byte[] fdtData)
		{
			this._myFDTData = fdtData;
			base.InternalStartAddress = this.FDT_START_ADDRESS;
			base.TransportPipe = transPipe;
		}

		// Token: 0x06000209 RID: 521 RVA: 0x0000957B File Offset: 0x0000777B
		public SBEPWriteFDTTable(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe transPipe)
		{
			base.TransportPipe = transPipe;
			base.InternalStartAddress = this.FDT_START_ADDRESS;
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x0600020A RID: 522 RVA: 0x000095A5 File Offset: 0x000077A5
		// (set) Token: 0x0600020B RID: 523 RVA: 0x000095AD File Offset: 0x000077AD
		public byte[] FDTTableData
		{
			get
			{
				return this._myFDTData;
			}
			set
			{
				this._myFDTData = value;
			}
		}

		// Token: 0x0600020C RID: 524 RVA: 0x000095B8 File Offset: 0x000077B8
		public override void ExecuteMessage()
		{
			global::Motorola.Common.LogUtility.LoggerUtil.SetTimeStampLabel("SBEPProtocol.WriteFDTTable");
			bool flag = true;
			base.OperationResult = this.BuildWriteMessageBuffer();
			if (base.OperationResult != global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_SUCCESS)
			{
				flag = false;
			}
			if (flag)
			{
				base.InternalDataToWrite = base.MyCommandBuffer;
				base.ExecuteMessage();
			}
			global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.SBEP_PERFORMANCE_LOGGER_NAME).Performance("SBEPProtocol.WriteFDTTable", "");
		}

		// Token: 0x0600020D RID: 525 RVA: 0x00009618 File Offset: 0x00007818
		protected override global::Motorola.Common.Communication.TetraMsgOpResult BuildWriteMessageBuffer()
		{
			bool flag = true;
			global::Motorola.Common.Communication.TetraMsgOpResult result = global::Motorola.Common.Communication.TetraMsgOpResult.Undefined;
			if (this._myFDTData.Length != (int)this.FDT_TABLE_LENGTH)
			{
				result = global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_WRONG_PARAMETER;
				flag = false;
			}
			if (flag)
			{
				base.MyCommandBuffer = new byte[(int)(this.FDT_TABLE_LENGTH + 1)];
				base.MyCommandBuffer[0] = 35;
				global::System.Array.Copy(this._myFDTData, 0, base.MyCommandBuffer, 1, (int)this.FDT_TABLE_LENGTH);
				result = global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_SUCCESS;
			}
			return result;
		}

		// Token: 0x0600020E RID: 526 RVA: 0x0000967B File Offset: 0x0000787B
		protected override global::Motorola.Common.Communication.TetraMsgOpResult BaseBuildCommandMessage()
		{
			base.OperationResult = this.BuildWriteMessageBuffer();
			if (base.OperationResult == global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_SUCCESS)
			{
				base.InternalDataToWrite = base.MyCommandBuffer;
				return base.BaseBuildCommandMessage();
			}
			return base.OperationResult;
		}

		// Token: 0x040000C5 RID: 197
		private byte[] _myFDTData;

		// Token: 0x040000C6 RID: 198
		private readonly uint FDT_START_ADDRESS = uint.MaxValue;

		// Token: 0x040000C7 RID: 199
		private readonly ushort FDT_TABLE_LENGTH = 64;
	}
}
