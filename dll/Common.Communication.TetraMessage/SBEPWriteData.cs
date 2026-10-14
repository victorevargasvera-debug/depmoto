using System;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.Communication.TetraUtility;
using Motorola.Common.LogUtility;

namespace Motorola.Common.Communication
{
	// Token: 0x02000044 RID: 68
	public class SBEPWriteData : global::Motorola.Common.Communication.SBEPBaseWrite
	{
		// Token: 0x060001FA RID: 506 RVA: 0x00009424 File Offset: 0x00007624
		public SBEPWriteData(uint startAddress, byte[] bufferToWrite)
		{
			base.InternalStartAddress = startAddress;
			base.InternalDataToWrite = bufferToWrite;
		}

		// Token: 0x060001FB RID: 507 RVA: 0x0000943A File Offset: 0x0000763A
		public SBEPWriteData(uint startAddress)
		{
			base.InternalStartAddress = startAddress;
		}

		// Token: 0x060001FC RID: 508 RVA: 0x00009449 File Offset: 0x00007649
		public SBEPWriteData()
		{
			base.InternalStartAddress = 0U;
		}

		// Token: 0x060001FD RID: 509 RVA: 0x00009458 File Offset: 0x00007658
		public SBEPWriteData(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe transPipe, uint startAddress, byte[] bufferToWrite)
		{
			base.InternalStartAddress = startAddress;
			base.InternalDataToWrite = bufferToWrite;
			base.TransportPipe = transPipe;
		}

		// Token: 0x060001FE RID: 510 RVA: 0x00009475 File Offset: 0x00007675
		public SBEPWriteData(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe transPipe, uint startAddress)
		{
			base.InternalStartAddress = startAddress;
			base.TransportPipe = transPipe;
		}

		// Token: 0x060001FF RID: 511 RVA: 0x0000948B File Offset: 0x0000768B
		public SBEPWriteData(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe transPipe)
		{
			base.InternalStartAddress = 0U;
			base.TransportPipe = transPipe;
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000200 RID: 512 RVA: 0x000094A1 File Offset: 0x000076A1
		// (set) Token: 0x06000201 RID: 513 RVA: 0x000094A9 File Offset: 0x000076A9
		public uint StartAddress
		{
			get
			{
				return base.InternalStartAddress;
			}
			set
			{
				base.InternalStartAddress = value;
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000202 RID: 514 RVA: 0x000094B2 File Offset: 0x000076B2
		// (set) Token: 0x06000203 RID: 515 RVA: 0x000094BA File Offset: 0x000076BA
		public byte[] DataToWrite
		{
			get
			{
				return base.InternalDataToWrite;
			}
			set
			{
				base.InternalDataToWrite = value;
			}
		}

		// Token: 0x06000204 RID: 516 RVA: 0x000094C3 File Offset: 0x000076C3
		public override void ExecuteMessage()
		{
			global::Motorola.Common.LogUtility.LoggerUtil.SetTimeStampLabel("SBEPProtocol.WriteData");
			base.ExecuteMessage();
			global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.SBEP_PERFORMANCE_LOGGER_NAME).Performance("SBEPProtocol.WriteData", "");
		}

		// Token: 0x06000205 RID: 517 RVA: 0x000094EE File Offset: 0x000076EE
		protected override global::Motorola.Common.Communication.TetraMsgOpResult BuildWriteMessageBuffer()
		{
			base.MyCommandBuffer = this.DataToWrite;
			return global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_SUCCESS;
		}
	}
}
