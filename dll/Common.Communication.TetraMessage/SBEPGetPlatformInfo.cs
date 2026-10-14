using System;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.Communication.TetraUtility;
using Motorola.Common.LogUtility;

namespace Motorola.Common.Communication
{
	// Token: 0x02000027 RID: 39
	public class SBEPGetPlatformInfo : global::Motorola.Common.Communication.SBEPBaseRead
	{
		// Token: 0x0600014E RID: 334 RVA: 0x0000739C File Offset: 0x0000559C
		public SBEPGetPlatformInfo(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe transPipe)
		{
			base.TransportPipe = transPipe;
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x0600014F RID: 335 RVA: 0x000073C1 File Offset: 0x000055C1
		public byte[] Data
		{
			get
			{
				return base.ReceivedData;
			}
		}

		// Token: 0x06000150 RID: 336 RVA: 0x000073CC File Offset: 0x000055CC
		public override void ExecuteMessage()
		{
			global::Motorola.Common.LogUtility.LoggerUtil.SetTimeStampLabel("SBEPProtocol.SBEPGetPlatformInfo");
			base.InternalStartAddress = this.GET_PLATFORM_INFO_ADDRESS;
			base.ExpectedReadLength = this.DATA_LENTH;
			base.ExecuteMessage();
			global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.SBEP_PERFORMANCE_LOGGER_NAME).Performance("SBEPProtocol.SBEPGetPlatformInfo", "");
		}

		// Token: 0x0400006E RID: 110
		private readonly ushort DATA_LENTH = 2000;

		// Token: 0x0400006F RID: 111
		private readonly uint GET_PLATFORM_INFO_ADDRESS = 4294967072U;
	}
}
