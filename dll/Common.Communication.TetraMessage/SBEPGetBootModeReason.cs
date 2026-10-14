using System;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.Communication.TetraUtility;
using Motorola.Common.LogUtility;

namespace Motorola.Common.Communication
{
	// Token: 0x02000025 RID: 37
	public class SBEPGetBootModeReason : global::Motorola.Common.Communication.SBEPBaseRead
	{
		// Token: 0x06000143 RID: 323 RVA: 0x000070C5 File Offset: 0x000052C5
		public SBEPGetBootModeReason(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe transPipe)
		{
			base.InternalStartAddress = this.BOOT_REASON_START_ADDRESS;
			base.ExpectedReadLength = this.BOOT_REASON_LENGTH;
			base.TransportPipe = transPipe;
		}

		// Token: 0x06000144 RID: 324 RVA: 0x00007105 File Offset: 0x00005305
		public SBEPGetBootModeReason()
		{
			base.InternalStartAddress = this.BOOT_REASON_START_ADDRESS;
			base.ExpectedReadLength = this.BOOT_REASON_LENGTH;
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000145 RID: 325 RVA: 0x0000713E File Offset: 0x0000533E
		public int BootReason
		{
			get
			{
				return this._bootReason;
			}
		}

		// Token: 0x06000146 RID: 326 RVA: 0x00007148 File Offset: 0x00005348
		public override void ExecuteMessage()
		{
			global::Motorola.Common.LogUtility.LoggerUtil.SetTimeStampLabel("SBEPProtocol.GetBootModeReason");
			base.ExecuteMessage();
			if (base.OperationResult == global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_SUCCESS)
			{
				this._bootReason = (int)base.ReceivedData[0];
			}
			global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.SBEP_PERFORMANCE_LOGGER_NAME).Performance("SBEPProtocol.GetBootModeReason", "");
		}

		// Token: 0x06000147 RID: 327 RVA: 0x00007195 File Offset: 0x00005395
		protected override global::Motorola.Common.Communication.TetraMsgOpResult ParseReplyMessage(byte[] buffer, ushort uOpCode)
		{
			base.ParseReplyMessage(buffer, uOpCode);
			if (base.OperationResult == global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_SUCCESS)
			{
				this._bootReason = (int)base.ReceivedData[0];
			}
			return base.OperationResult;
		}

		// Token: 0x04000066 RID: 102
		private readonly ushort BOOT_REASON_LENGTH = 6;

		// Token: 0x04000067 RID: 103
		private readonly uint BOOT_REASON_START_ADDRESS = 4294967071U;

		// Token: 0x04000068 RID: 104
		private int _bootReason = -1;
	}
}
