using System;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.Communication.TetraUtility;
using Motorola.Common.LogUtility;

namespace Motorola.Common.Communication
{
	// Token: 0x02000043 RID: 67
	public class SBEPTurnRadioOff : global::Motorola.Common.Communication.SBEPBaseWrite
	{
		// Token: 0x060001F5 RID: 501 RVA: 0x00009367 File Offset: 0x00007567
		public SBEPTurnRadioOff()
		{
			base.InternalStartAddress = this.EXTENDED_WRITE_ADDRESS;
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x00009382 File Offset: 0x00007582
		public SBEPTurnRadioOff(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe transPipe)
		{
			base.InternalStartAddress = this.EXTENDED_WRITE_ADDRESS;
			base.TransportPipe = transPipe;
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x000093A4 File Offset: 0x000075A4
		public override void ExecuteMessage()
		{
			global::Motorola.Common.LogUtility.LoggerUtil.SetTimeStampLabel("SBEPProtocol.TurnRadioOff");
			this.BuildWriteMessageBuffer();
			base.InternalDataToWrite = base.MyCommandBuffer;
			base.ExecuteMessage();
			global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.SBEP_PERFORMANCE_LOGGER_NAME).Performance("SBEPProtocol.TurnRadioOff", "");
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x000093E4 File Offset: 0x000075E4
		protected override global::Motorola.Common.Communication.TetraMsgOpResult BuildWriteMessageBuffer()
		{
			global::Motorola.Common.Communication.TetraMsgOpResult result = global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_SUCCESS;
			base.MyCommandBuffer = new byte[1];
			base.MyCommandBuffer[0] = 3;
			return result;
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x00009409 File Offset: 0x00007609
		protected override global::Motorola.Common.Communication.TetraMsgOpResult BaseBuildCommandMessage()
		{
			this.BuildWriteMessageBuffer();
			base.InternalDataToWrite = base.MyCommandBuffer;
			return base.BaseBuildCommandMessage();
		}

		// Token: 0x040000C4 RID: 196
		private readonly uint EXTENDED_WRITE_ADDRESS = uint.MaxValue;
	}
}
