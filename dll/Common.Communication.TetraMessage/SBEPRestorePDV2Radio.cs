using System;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.Communication.TetraUtility;
using Motorola.Common.LogUtility;

namespace Motorola.Common.Communication
{
	// Token: 0x02000036 RID: 54
	public class SBEPRestorePDV2Radio : global::Motorola.Common.Communication.SBEPBaseWrite
	{
		// Token: 0x060001A2 RID: 418 RVA: 0x000085BB File Offset: 0x000067BB
		public SBEPRestorePDV2Radio(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe transPipe)
		{
			base.InternalStartAddress = this.RESTORE_RADIO_ADDRESS;
			base.TransportPipe = transPipe;
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x000085DD File Offset: 0x000067DD
		public SBEPRestorePDV2Radio()
		{
			base.InternalStartAddress = this.RESTORE_RADIO_ADDRESS;
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x000085F8 File Offset: 0x000067F8
		public override void ExecuteMessage()
		{
			global::Motorola.Common.LogUtility.LoggerUtil.SetTimeStampLabel("SBEPProtocol.BaseHwID");
			base.OperationResult = this.BuildWriteMessageBuffer();
			base.InternalDataToWrite = base.MyCommandBuffer;
			base.ExecuteMessage();
			global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.SBEP_PERFORMANCE_LOGGER_NAME).Performance("SBEPProtocol.BaseHwID", "");
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x00008648 File Offset: 0x00006848
		protected override global::Motorola.Common.Communication.TetraMsgOpResult BuildWriteMessageBuffer()
		{
			global::Motorola.Common.Communication.TetraMsgOpResult result = global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_SUCCESS;
			base.MyCommandBuffer = new byte[1];
			base.MyCommandBuffer[0] = 37;
			return result;
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x0000866E File Offset: 0x0000686E
		protected override global::Motorola.Common.Communication.TetraMsgOpResult BaseBuildCommandMessage()
		{
			this.BuildWriteMessageBuffer();
			base.InternalDataToWrite = base.MyCommandBuffer;
			return base.BaseBuildCommandMessage();
		}

		// Token: 0x040000A3 RID: 163
		private readonly uint RESTORE_RADIO_ADDRESS = uint.MaxValue;
	}
}
