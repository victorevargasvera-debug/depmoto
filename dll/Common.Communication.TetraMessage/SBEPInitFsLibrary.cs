using System;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.Communication.TetraUtility;
using Motorola.Common.LogUtility;

namespace Motorola.Common.Communication
{
	// Token: 0x0200002B RID: 43
	public class SBEPInitFsLibrary : global::Motorola.Common.Communication.SBEPBaseWrite
	{
		// Token: 0x06000160 RID: 352 RVA: 0x000077C3 File Offset: 0x000059C3
		public SBEPInitFsLibrary()
		{
			base.InternalStartAddress = this.FS_START_ADDRESS;
		}

		// Token: 0x06000161 RID: 353 RVA: 0x000077E5 File Offset: 0x000059E5
		public SBEPInitFsLibrary(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe transPipe)
		{
			base.InternalStartAddress = this.FS_START_ADDRESS;
			base.TransportPipe = transPipe;
		}

		// Token: 0x06000162 RID: 354 RVA: 0x00007810 File Offset: 0x00005A10
		public override void ExecuteMessage()
		{
			global::Motorola.Common.LogUtility.LoggerUtil.SetTimeStampLabel("SBEPProtocol.InitFsLibrary");
			base.OperationResult = this.BuildWriteMessageBuffer();
			base.InternalDataToWrite = base.MyCommandBuffer;
			base.ExecuteMessage();
			global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.SBEP_PERFORMANCE_LOGGER_NAME).Performance("SBEPProtocol.InitFsLibrary", "");
		}

		// Token: 0x06000163 RID: 355 RVA: 0x00007860 File Offset: 0x00005A60
		protected override global::Motorola.Common.Communication.TetraMsgOpResult BuildWriteMessageBuffer()
		{
			global::Motorola.Common.Communication.TetraMsgOpResult result = global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_SUCCESS;
			base.MyCommandBuffer = new byte[(int)this.MESSAGE_LENGTH];
			base.MyCommandBuffer[0] = 17;
			return result;
		}

		// Token: 0x06000164 RID: 356 RVA: 0x0000788B File Offset: 0x00005A8B
		protected override global::Motorola.Common.Communication.TetraMsgOpResult BaseBuildCommandMessage()
		{
			this.BuildWriteMessageBuffer();
			base.InternalDataToWrite = base.MyCommandBuffer;
			return base.BaseBuildCommandMessage();
		}

		// Token: 0x04000079 RID: 121
		private readonly uint FS_START_ADDRESS = uint.MaxValue;

		// Token: 0x0400007A RID: 122
		private readonly ushort MESSAGE_LENGTH = 1;
	}
}
