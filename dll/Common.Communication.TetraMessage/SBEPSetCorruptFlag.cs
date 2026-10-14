using System;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.Communication.TetraUtility;
using Motorola.Common.LogUtility;

namespace Motorola.Common.Communication
{
	// Token: 0x02000038 RID: 56
	public class SBEPSetCorruptFlag : global::Motorola.Common.Communication.SBEPBaseWrite
	{
		// Token: 0x060001B0 RID: 432 RVA: 0x000087FB File Offset: 0x000069FB
		public SBEPSetCorruptFlag()
		{
			base.InternalStartAddress = this.SET_CORRUPT_FLAG_ADDRESS;
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x0000881D File Offset: 0x00006A1D
		public SBEPSetCorruptFlag(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe transPipe)
		{
			base.TransportPipe = transPipe;
			base.InternalStartAddress = this.SET_CORRUPT_FLAG_ADDRESS;
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x00008848 File Offset: 0x00006A48
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

		// Token: 0x060001B3 RID: 435 RVA: 0x000088A0 File Offset: 0x00006AA0
		protected override global::Motorola.Common.Communication.TetraMsgOpResult BuildWriteMessageBuffer()
		{
			global::Motorola.Common.Communication.TetraMsgOpResult tetraMsgOpResult = global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_SUCCESS;
			base.MyCommandBuffer = new byte[this.MESSAGE_LENGTH];
			base.MyCommandBuffer[0] = 39;
			base.OperationResult = tetraMsgOpResult;
			return tetraMsgOpResult;
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x000088D3 File Offset: 0x00006AD3
		protected override global::Motorola.Common.Communication.TetraMsgOpResult BaseBuildCommandMessage()
		{
			this.BuildWriteMessageBuffer();
			base.InternalDataToWrite = base.MyCommandBuffer;
			return base.BaseBuildCommandMessage();
		}

		// Token: 0x040000A6 RID: 166
		private readonly uint MESSAGE_LENGTH = 1U;

		// Token: 0x040000A7 RID: 167
		private readonly uint SET_CORRUPT_FLAG_ADDRESS = uint.MaxValue;
	}
}
