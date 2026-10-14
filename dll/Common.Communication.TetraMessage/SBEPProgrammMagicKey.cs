using System;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.Communication.TetraUtility;
using Motorola.Common.LogUtility;

namespace Motorola.Common.Communication
{
	// Token: 0x0200002E RID: 46
	public class SBEPProgrammMagicKey : global::Motorola.Common.Communication.SBEPBaseWrite
	{
		// Token: 0x06000176 RID: 374 RVA: 0x00008070 File Offset: 0x00006270
		public SBEPProgrammMagicKey()
		{
			base.InternalStartAddress = this.MAGIC_KEY_ADDRESS;
		}

		// Token: 0x06000177 RID: 375 RVA: 0x00008092 File Offset: 0x00006292
		public SBEPProgrammMagicKey(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe transPipe)
		{
			base.InternalStartAddress = this.MAGIC_KEY_ADDRESS;
			base.TransportPipe = transPipe;
		}

		// Token: 0x06000178 RID: 376 RVA: 0x000080BB File Offset: 0x000062BB
		public override void ExecuteMessage()
		{
			global::Motorola.Common.LogUtility.LoggerUtil.SetTimeStampLabel("SBEPProtocol.ProgrammMagicKey");
			this.BuildWriteMessageBuffer();
			base.InternalDataToWrite = base.MyCommandBuffer;
			base.ExecuteMessage();
			global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.SBEP_PERFORMANCE_LOGGER_NAME).Performance("SBEPProtocol.ProgrammMagicKey", "");
		}

		// Token: 0x06000179 RID: 377 RVA: 0x000080F9 File Offset: 0x000062F9
		protected override global::Motorola.Common.Communication.TetraMsgOpResult BuildWriteMessageBuffer()
		{
			base.MyCommandBuffer = new byte[(int)this.MESSAGE_LENGTH];
			base.MyCommandBuffer[0] = 18;
			return global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_SUCCESS;
		}

		// Token: 0x0600017A RID: 378 RVA: 0x00008117 File Offset: 0x00006317
		protected override global::Motorola.Common.Communication.TetraMsgOpResult BaseBuildCommandMessage()
		{
			this.BuildWriteMessageBuffer();
			base.InternalDataToWrite = base.MyCommandBuffer;
			return base.BaseBuildCommandMessage();
		}

		// Token: 0x04000082 RID: 130
		private readonly uint MAGIC_KEY_ADDRESS = uint.MaxValue;

		// Token: 0x04000083 RID: 131
		private readonly ushort MESSAGE_LENGTH = 1;
	}
}
