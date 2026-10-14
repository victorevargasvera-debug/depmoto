using System;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.Communication.TetraUtility;
using Motorola.Common.LogUtility;

namespace Motorola.Common.Communication
{
	// Token: 0x0200001E RID: 30
	public class SBEPCleanCorruptFlag : global::Motorola.Common.Communication.SBEPBaseWrite
	{
		// Token: 0x06000117 RID: 279 RVA: 0x00006982 File Offset: 0x00004B82
		public SBEPCleanCorruptFlag()
		{
			base.InternalStartAddress = this.CLEAN_CORRUPT_FLAG_ADDRESS;
		}

		// Token: 0x06000118 RID: 280 RVA: 0x000069A4 File Offset: 0x00004BA4
		public SBEPCleanCorruptFlag(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe transPipe)
		{
			base.TransportPipe = transPipe;
			base.InternalStartAddress = this.CLEAN_CORRUPT_FLAG_ADDRESS;
		}

		// Token: 0x06000119 RID: 281 RVA: 0x000069D0 File Offset: 0x00004BD0
		public override void ExecuteMessage()
		{
			global::Motorola.Common.LogUtility.LoggerUtil.SetTimeStampLabel("SBEPProtocol.CleanCorruptFlag");
			bool flag = true;
			global::Motorola.Common.Communication.TetraMsgOpResult tetraMsgOpResult = this.BuildWriteMessageBuffer();
			if (tetraMsgOpResult != global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_SUCCESS)
			{
				flag = false;
			}
			if (flag)
			{
				base.InternalDataToWrite = base.MyCommandBuffer;
				base.ExecuteMessage();
			}
			global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.SBEP_PERFORMANCE_LOGGER_NAME).Performance("SBEPProtocol.CleanCorruptFlag", "");
		}

		// Token: 0x0600011A RID: 282 RVA: 0x00006A28 File Offset: 0x00004C28
		protected override global::Motorola.Common.Communication.TetraMsgOpResult BuildWriteMessageBuffer()
		{
			global::Motorola.Common.Communication.TetraMsgOpResult tetraMsgOpResult = global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_SUCCESS;
			base.MyCommandBuffer = new byte[this.MESSAGE_LENGTH];
			base.MyCommandBuffer[0] = 38;
			base.OperationResult = tetraMsgOpResult;
			return tetraMsgOpResult;
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00006A5B File Offset: 0x00004C5B
		protected override global::Motorola.Common.Communication.TetraMsgOpResult BaseBuildCommandMessage()
		{
			this.BuildWriteMessageBuffer();
			base.InternalDataToWrite = base.MyCommandBuffer;
			return base.BaseBuildCommandMessage();
		}

		// Token: 0x0400005C RID: 92
		private readonly uint MESSAGE_LENGTH = 1U;

		// Token: 0x0400005D RID: 93
		private readonly uint CLEAN_CORRUPT_FLAG_ADDRESS = uint.MaxValue;
	}
}
