using System;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.Communication.TetraUtility;
using Motorola.Common.LogUtility;

namespace Motorola.Common.Communication
{
	// Token: 0x02000041 RID: 65
	public class SBEPStatus : global::Motorola.Common.Communication.SBEPBaseStatus
	{
		// Token: 0x060001EF RID: 495 RVA: 0x000092AA File Offset: 0x000074AA
		public SBEPStatus()
		{
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x000092B2 File Offset: 0x000074B2
		public SBEPStatus(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe transPipe)
		{
			base.TransportPipe = transPipe;
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x000092C1 File Offset: 0x000074C1
		public SBEPStatus(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe transPipe, bool bQuickCheck)
		{
			base.TransportPipe = transPipe;
			this._bQuickCheck = bQuickCheck;
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x060001F2 RID: 498 RVA: 0x000092D7 File Offset: 0x000074D7
		public byte Status
		{
			get
			{
				return base.InternalStatus;
			}
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x000092E0 File Offset: 0x000074E0
		public override void ExecuteMessage()
		{
			int readTimeout = 0;
			global::Motorola.Common.LogUtility.LoggerUtil.SetTimeStampLabel("SBEPProtocol.Status");
			if (this._bQuickCheck)
			{
				readTimeout = (base.TransportPipe as global::Motorola.Common.Communication.CommunicationPipe.TetraCommPipe).ReadTimeout;
				(base.TransportPipe as global::Motorola.Common.Communication.CommunicationPipe.TetraCommPipe).ReadTimeout = global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.SHORT_WAIT_TIME_OUT;
			}
			base.ExecuteMessage();
			if (this._bQuickCheck)
			{
				(base.TransportPipe as global::Motorola.Common.Communication.CommunicationPipe.TetraCommPipe).ReadTimeout = readTimeout;
			}
			global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.SBEP_PERFORMANCE_LOGGER_NAME).Performance("SBEPProtocol.Status", "");
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x060001F4 RID: 500 RVA: 0x0000935F File Offset: 0x0000755F
		protected uint StartAddress
		{
			get
			{
				return base.InternalStartAddress;
			}
		}

		// Token: 0x040000C0 RID: 192
		private bool _bQuickCheck;
	}
}
