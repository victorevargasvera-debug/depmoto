using System;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.Communication.TetraUtility;
using Motorola.Common.LogUtility;

namespace Motorola.Common.Communication
{
	// Token: 0x0200003F RID: 63
	public class SBEPSetVerifyFlag : global::Motorola.Common.Communication.SBEPBaseWrite
	{
		// Token: 0x060001E6 RID: 486 RVA: 0x0000914C File Offset: 0x0000734C
		public SBEPSetVerifyFlag(bool bVerify)
		{
			this.bNeedVerify = bVerify;
			base.InternalStartAddress = this.FLAG_START_ADDRESS;
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x00009175 File Offset: 0x00007375
		public SBEPSetVerifyFlag(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe transPipe, bool bVerify)
		{
			this.bNeedVerify = bVerify;
			base.InternalStartAddress = this.FLAG_START_ADDRESS;
			base.TransportPipe = transPipe;
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x000091A5 File Offset: 0x000073A5
		public SBEPSetVerifyFlag()
		{
			base.InternalStartAddress = this.FLAG_START_ADDRESS;
			this.bNeedVerify = false;
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x000091CE File Offset: 0x000073CE
		public SBEPSetVerifyFlag(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe transPipe)
		{
			this.bNeedVerify = false;
			base.InternalStartAddress = this.FLAG_START_ADDRESS;
			base.TransportPipe = transPipe;
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x060001EA RID: 490 RVA: 0x000091FE File Offset: 0x000073FE
		// (set) Token: 0x060001EB RID: 491 RVA: 0x00009206 File Offset: 0x00007406
		public bool NeedVerify
		{
			get
			{
				return this.bNeedVerify;
			}
			set
			{
				this.bNeedVerify = value;
			}
		}

		// Token: 0x060001EC RID: 492 RVA: 0x0000920F File Offset: 0x0000740F
		public override void ExecuteMessage()
		{
			global::Motorola.Common.LogUtility.LoggerUtil.SetTimeStampLabel("SBEPProtocol.SetVerifyFlag");
			this.BuildWriteMessageBuffer();
			base.InternalDataToWrite = base.MyCommandBuffer;
			base.ExecuteMessage();
			global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.SBEP_PERFORMANCE_LOGGER_NAME).Performance("SBEPProtocol.SetVerifyFlag", "");
		}

		// Token: 0x060001ED RID: 493 RVA: 0x00009250 File Offset: 0x00007450
		protected override global::Motorola.Common.Communication.TetraMsgOpResult BuildWriteMessageBuffer()
		{
			global::Motorola.Common.Communication.TetraMsgOpResult result = global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_SUCCESS;
			base.MyCommandBuffer = new byte[(int)this.MESSAGE_LENGTH];
			base.MyCommandBuffer[0] = 6;
			base.MyCommandBuffer[1] = (this.bNeedVerify ? 1 : 0);
			return result;
		}

		// Token: 0x060001EE RID: 494 RVA: 0x0000928F File Offset: 0x0000748F
		protected override global::Motorola.Common.Communication.TetraMsgOpResult BaseBuildCommandMessage()
		{
			this.BuildWriteMessageBuffer();
			base.InternalDataToWrite = base.MyCommandBuffer;
			return base.BaseBuildCommandMessage();
		}

		// Token: 0x040000BA RID: 186
		private bool bNeedVerify;

		// Token: 0x040000BB RID: 187
		private readonly ushort MESSAGE_LENGTH = 2;

		// Token: 0x040000BC RID: 188
		private readonly uint FLAG_START_ADDRESS = uint.MaxValue;
	}
}
