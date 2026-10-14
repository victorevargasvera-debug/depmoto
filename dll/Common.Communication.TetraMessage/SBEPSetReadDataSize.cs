using System;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.Communication.TetraUtility;
using Motorola.Common.LogUtility;

namespace Motorola.Common.Communication
{
	// Token: 0x0200003D RID: 61
	public class SBEPSetReadDataSize : global::Motorola.Common.Communication.SBEPBaseWrite
	{
		// Token: 0x060001D4 RID: 468 RVA: 0x00008E14 File Offset: 0x00007014
		public SBEPSetReadDataSize(ushort size)
		{
			this._size = size;
			base.InternalStartAddress = this.EXTENDED_WRITE_ADDRESS;
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x00008E36 File Offset: 0x00007036
		public SBEPSetReadDataSize()
		{
			this._size = 0;
			base.InternalStartAddress = this.EXTENDED_WRITE_ADDRESS;
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x00008E58 File Offset: 0x00007058
		public SBEPSetReadDataSize(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe transPipe, ushort size)
		{
			this._size = size;
			base.InternalStartAddress = this.EXTENDED_WRITE_ADDRESS;
			base.TransportPipe = transPipe;
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x00008E81 File Offset: 0x00007081
		public SBEPSetReadDataSize(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe transPipe)
		{
			this._size = 0;
			base.InternalStartAddress = this.EXTENDED_WRITE_ADDRESS;
			base.TransportPipe = transPipe;
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x060001D8 RID: 472 RVA: 0x00008EAA File Offset: 0x000070AA
		// (set) Token: 0x060001D9 RID: 473 RVA: 0x00008EB2 File Offset: 0x000070B2
		public ushort Size
		{
			get
			{
				return this._size;
			}
			set
			{
				this._size = value;
			}
		}

		// Token: 0x060001DA RID: 474 RVA: 0x00008EBC File Offset: 0x000070BC
		public override void ExecuteMessage()
		{
			global::Motorola.Common.LogUtility.LoggerUtil.SetTimeStampLabel("SBEPProtocol.SetReadDataSize");
			base.OperationResult = this.BuildWriteMessageBuffer();
			if (base.OperationResult == global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_SUCCESS)
			{
				base.InternalDataToWrite = base.MyCommandBuffer;
				base.ExecuteMessage();
			}
			global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.SBEP_PERFORMANCE_LOGGER_NAME).Performance("SBEPProtocol.SetReadDataSize", "");
		}

		// Token: 0x060001DB RID: 475 RVA: 0x00008F14 File Offset: 0x00007114
		protected override global::Motorola.Common.Communication.TetraMsgOpResult BuildWriteMessageBuffer()
		{
			base.MyCommandBuffer = new byte[3];
			base.MyCommandBuffer[0] = 24;
			byte[] bytes = global::System.BitConverter.GetBytes(this._size);
			return global::Motorola.Common.Communication.SBEPCommon.ReverseBytesAndCopy(base.MyCommandBuffer, 1, bytes, 0, 2);
		}

		// Token: 0x060001DC RID: 476 RVA: 0x00008F56 File Offset: 0x00007156
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

		// Token: 0x040000B5 RID: 181
		private ushort _size;

		// Token: 0x040000B6 RID: 182
		private readonly uint EXTENDED_WRITE_ADDRESS = uint.MaxValue;
	}
}
