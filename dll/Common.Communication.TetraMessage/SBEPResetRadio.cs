using System;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.Communication.TetraUtility;
using Motorola.Common.LogUtility;

namespace Motorola.Common.Communication
{
	// Token: 0x02000035 RID: 53
	public class SBEPResetRadio : global::Motorola.Common.Communication.SBEPBaseWrite
	{
		// Token: 0x06000199 RID: 409 RVA: 0x00008478 File Offset: 0x00006678
		public SBEPResetRadio(byte mode)
		{
			this._mode = mode;
			base.InternalStartAddress = this.EXTENDED_WRITE_ADDRESS;
		}

		// Token: 0x0600019A RID: 410 RVA: 0x0000849A File Offset: 0x0000669A
		public SBEPResetRadio(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe transPipe, byte mode)
		{
			this._mode = mode;
			base.InternalStartAddress = this.EXTENDED_WRITE_ADDRESS;
			base.TransportPipe = transPipe;
		}

		// Token: 0x0600019B RID: 411 RVA: 0x000084C3 File Offset: 0x000066C3
		public SBEPResetRadio()
		{
			this._mode = 1;
			base.InternalStartAddress = this.EXTENDED_WRITE_ADDRESS;
		}

		// Token: 0x0600019C RID: 412 RVA: 0x000084E5 File Offset: 0x000066E5
		public SBEPResetRadio(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe transPipe)
		{
			this._mode = 1;
			base.InternalStartAddress = this.EXTENDED_WRITE_ADDRESS;
			base.TransportPipe = transPipe;
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x0600019D RID: 413 RVA: 0x0000850E File Offset: 0x0000670E
		// (set) Token: 0x0600019E RID: 414 RVA: 0x00008516 File Offset: 0x00006716
		public byte DeviceMode
		{
			get
			{
				return this._mode;
			}
			set
			{
				this._mode = value;
			}
		}

		// Token: 0x0600019F RID: 415 RVA: 0x00008520 File Offset: 0x00006720
		public override void ExecuteMessage()
		{
			global::Motorola.Common.LogUtility.LoggerUtil.SetTimeStampLabel("SBEPProtocol.ResetRadio");
			base.OperationResult = this.BuildWriteMessageBuffer();
			base.InternalDataToWrite = base.MyCommandBuffer;
			base.hasReply = false;
			base.ExecuteMessage();
			global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.SBEP_PERFORMANCE_LOGGER_NAME).Performance("SBEPProtocol.ResetRadio", "");
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x00008578 File Offset: 0x00006778
		protected override global::Motorola.Common.Communication.TetraMsgOpResult BuildWriteMessageBuffer()
		{
			global::Motorola.Common.Communication.TetraMsgOpResult result = global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_SUCCESS;
			base.MyCommandBuffer = new byte[2];
			base.MyCommandBuffer[0] = 33;
			base.MyCommandBuffer[1] = this._mode;
			return result;
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x000085AC File Offset: 0x000067AC
		protected override global::Motorola.Common.Communication.TetraMsgOpResult BaseBuildCommandMessage()
		{
			this.BuildWriteMessageBuffer();
			return base.BaseBuildCommandMessage();
		}

		// Token: 0x040000A1 RID: 161
		private byte _mode;

		// Token: 0x040000A2 RID: 162
		private readonly uint EXTENDED_WRITE_ADDRESS = uint.MaxValue;
	}
}
