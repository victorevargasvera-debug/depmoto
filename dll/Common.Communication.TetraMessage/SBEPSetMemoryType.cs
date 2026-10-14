using System;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.Communication.TetraUtility;
using Motorola.Common.LogUtility;

namespace Motorola.Common.Communication
{
	// Token: 0x0200003A RID: 58
	public class SBEPSetMemoryType : global::Motorola.Common.Communication.SBEPBaseWrite
	{
		// Token: 0x060001C0 RID: 448 RVA: 0x00008AE6 File Offset: 0x00006CE6
		public SBEPSetMemoryType(global::Motorola.Common.Communication.MEMORY_TYPE memType)
		{
			this._memoryType = memType;
			base.InternalStartAddress = this.MEMORY_TYPE_ADDRESS;
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x00008B08 File Offset: 0x00006D08
		public SBEPSetMemoryType(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe transPipe, global::Motorola.Common.Communication.MEMORY_TYPE memType)
		{
			this._memoryType = memType;
			base.InternalStartAddress = this.MEMORY_TYPE_ADDRESS;
			base.TransportPipe = transPipe;
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x00008B31 File Offset: 0x00006D31
		public SBEPSetMemoryType()
		{
			this._memoryType = global::Motorola.Common.Communication.MEMORY_TYPE.MT_FLASH;
			base.InternalStartAddress = this.MEMORY_TYPE_ADDRESS;
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x00008B54 File Offset: 0x00006D54
		public SBEPSetMemoryType(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe transPipe)
		{
			this._memoryType = global::Motorola.Common.Communication.MEMORY_TYPE.MT_FLASH;
			base.InternalStartAddress = this.MEMORY_TYPE_ADDRESS;
			base.TransportPipe = transPipe;
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060001C4 RID: 452 RVA: 0x00008B7E File Offset: 0x00006D7E
		// (set) Token: 0x060001C5 RID: 453 RVA: 0x00008B86 File Offset: 0x00006D86
		public global::Motorola.Common.Communication.MEMORY_TYPE MemoryType
		{
			get
			{
				return this._memoryType;
			}
			set
			{
				this._memoryType = value;
			}
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x00008B90 File Offset: 0x00006D90
		public override void ExecuteMessage()
		{
			global::Motorola.Common.LogUtility.LoggerUtil.SetTimeStampLabel("SBEPProtocol.SetMemoryType");
			base.OperationResult = this.BuildWriteMessageBuffer();
			if (base.OperationResult == global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_SUCCESS)
			{
				base.InternalDataToWrite = base.MyCommandBuffer;
				base.ExecuteMessage();
			}
			global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.SBEP_PERFORMANCE_LOGGER_NAME).Performance("SBEPProtocol.SetMemoryType", "");
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x00008BE8 File Offset: 0x00006DE8
		protected override global::Motorola.Common.Communication.TetraMsgOpResult BuildWriteMessageBuffer()
		{
			global::Motorola.Common.Communication.TetraMsgOpResult result = global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_SUCCESS;
			base.MyCommandBuffer = new byte[2];
			base.MyCommandBuffer[0] = 7;
			base.MyCommandBuffer[1] = (byte)this._memoryType;
			return result;
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x00008C1B File Offset: 0x00006E1B
		protected override global::Motorola.Common.Communication.TetraMsgOpResult BaseBuildCommandMessage()
		{
			this.BuildWriteMessageBuffer();
			base.InternalDataToWrite = base.MyCommandBuffer;
			return base.BaseBuildCommandMessage();
		}

		// Token: 0x040000AB RID: 171
		private global::Motorola.Common.Communication.MEMORY_TYPE _memoryType;

		// Token: 0x040000AC RID: 172
		private readonly uint MEMORY_TYPE_ADDRESS = uint.MaxValue;
	}
}
