using System;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.Communication.TetraUtility;
using Motorola.Common.LogUtility;

namespace Motorola.Common.Communication
{
	// Token: 0x0200003C RID: 60
	public class SBEPSetReadCPDataParam : global::Motorola.Common.Communication.SBEPBaseWrite
	{
		// Token: 0x060001C9 RID: 457 RVA: 0x00008C36 File Offset: 0x00006E36
		public SBEPSetReadCPDataParam(uint offset, string blockID)
		{
			this._offset = offset;
			this._blockID = blockID;
			base.InternalStartAddress = this.EXTENDED_WRITE_ADDRESS;
		}

		// Token: 0x060001CA RID: 458 RVA: 0x00008C5F File Offset: 0x00006E5F
		public SBEPSetReadCPDataParam(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe transPipe, uint offset, string blockID)
		{
			this._offset = offset;
			this._blockID = blockID;
			base.InternalStartAddress = this.EXTENDED_WRITE_ADDRESS;
			base.TransportPipe = transPipe;
		}

		// Token: 0x060001CB RID: 459 RVA: 0x00008C8F File Offset: 0x00006E8F
		public SBEPSetReadCPDataParam()
		{
			this._offset = 0U;
			base.InternalStartAddress = this.EXTENDED_WRITE_ADDRESS;
		}

		// Token: 0x060001CC RID: 460 RVA: 0x00008CB1 File Offset: 0x00006EB1
		public SBEPSetReadCPDataParam(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe transPipe)
		{
			this._offset = 0U;
			base.InternalStartAddress = this.EXTENDED_WRITE_ADDRESS;
			base.TransportPipe = transPipe;
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060001CD RID: 461 RVA: 0x00008CDA File Offset: 0x00006EDA
		// (set) Token: 0x060001CE RID: 462 RVA: 0x00008CE2 File Offset: 0x00006EE2
		public uint Offset
		{
			get
			{
				return this._offset;
			}
			set
			{
				this._offset = value;
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x060001CF RID: 463 RVA: 0x00008CEB File Offset: 0x00006EEB
		// (set) Token: 0x060001D0 RID: 464 RVA: 0x00008CF3 File Offset: 0x00006EF3
		public string BlockID
		{
			get
			{
				return this._blockID;
			}
			set
			{
				this._blockID = value;
			}
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x00008CFC File Offset: 0x00006EFC
		public override void ExecuteMessage()
		{
			global::Motorola.Common.LogUtility.LoggerUtil.SetTimeStampLabel("SBEPProtocol.SBEPSetReadCPDataParam");
			base.OperationResult = this.BuildWriteMessageBuffer();
			if (base.OperationResult == global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_SUCCESS)
			{
				base.InternalDataToWrite = base.MyCommandBuffer;
				base.ExecuteMessage();
			}
			global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.SBEP_PERFORMANCE_LOGGER_NAME).Performance("SBEPProtocol.SBEPSetReadCPDataParam", "");
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x00008D54 File Offset: 0x00006F54
		protected override global::Motorola.Common.Communication.TetraMsgOpResult BuildWriteMessageBuffer()
		{
			global::Motorola.Common.Communication.TetraMsgOpResult tetraMsgOpResult = global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_SUCCESS;
			if (string.IsNullOrEmpty(this._blockID) || this._blockID.Length != 2)
			{
				tetraMsgOpResult = global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_WRONG_PARAMETER;
			}
			if (tetraMsgOpResult == global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_SUCCESS)
			{
				base.MyCommandBuffer = new byte[7];
				base.MyCommandBuffer[0] = 36;
				base.MyCommandBuffer[1] = (byte)this._blockID[0];
				base.MyCommandBuffer[2] = (byte)this._blockID[1];
				byte[] bytes = global::System.BitConverter.GetBytes(this._offset);
				tetraMsgOpResult = global::Motorola.Common.Communication.SBEPCommon.ReverseBytesAndCopy(base.MyCommandBuffer, 3, bytes, 0, 4);
			}
			return tetraMsgOpResult;
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x00008DE4 File Offset: 0x00006FE4
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

		// Token: 0x040000B2 RID: 178
		private uint _offset;

		// Token: 0x040000B3 RID: 179
		private string _blockID;

		// Token: 0x040000B4 RID: 180
		private readonly uint EXTENDED_WRITE_ADDRESS = uint.MaxValue;
	}
}
