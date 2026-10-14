using System;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.Communication.TetraUtility;
using Motorola.Common.LogUtility;

namespace Motorola.Common.Communication
{
	// Token: 0x02000021 RID: 33
	public class SBEPConfiguration : global::Motorola.Common.Communication.SBEPBaseConfig
	{
		// Token: 0x06000129 RID: 297 RVA: 0x00006CC2 File Offset: 0x00004EC2
		public SBEPConfiguration()
		{
		}

		// Token: 0x0600012A RID: 298 RVA: 0x00006CCA File Offset: 0x00004ECA
		public SBEPConfiguration(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe transPipe)
		{
			base.TransportPipe = transPipe;
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x0600012B RID: 299 RVA: 0x00006CD9 File Offset: 0x00004ED9
		public ushort BufferSize
		{
			get
			{
				return base.InternalBufferSize;
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x0600012C RID: 300 RVA: 0x00006CE1 File Offset: 0x00004EE1
		public byte ReservedParam
		{
			get
			{
				return base.InternalReservedParam;
			}
		}

		// Token: 0x0600012D RID: 301 RVA: 0x00006CE9 File Offset: 0x00004EE9
		public override void ExecuteMessage()
		{
			global::Motorola.Common.LogUtility.LoggerUtil.SetTimeStampLabel("SBEPProtocol.Configuration");
			base.ExecuteMessage();
			global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.SBEP_PERFORMANCE_LOGGER_NAME).Performance("SBEPProtocol.Configuration", "");
		}
	}
}
