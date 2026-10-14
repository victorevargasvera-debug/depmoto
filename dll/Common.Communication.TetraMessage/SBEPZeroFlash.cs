using System;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.Communication.TetraUtility;
using Motorola.Common.LogUtility;

namespace Motorola.Common.Communication
{
	// Token: 0x02000046 RID: 70
	public class SBEPZeroFlash : global::Motorola.Common.Communication.SBEPBaseZeroFlash
	{
		// Token: 0x0600020F RID: 527 RVA: 0x000096AB File Offset: 0x000078AB
		public SBEPZeroFlash()
		{
		}

		// Token: 0x06000210 RID: 528 RVA: 0x000096B3 File Offset: 0x000078B3
		public SBEPZeroFlash(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe transPipe)
		{
			base.TransportPipe = transPipe;
		}

		// Token: 0x06000211 RID: 529 RVA: 0x000096C2 File Offset: 0x000078C2
		public override void ExecuteMessage()
		{
			global::Motorola.Common.LogUtility.LoggerUtil.SetTimeStampLabel("SBEPProtocol.ZeroFlash");
			base.ExecuteMessage();
			global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.SBEP_PERFORMANCE_LOGGER_NAME).Performance("SBEPProtocol.ZeroFlash", "");
		}
	}
}
