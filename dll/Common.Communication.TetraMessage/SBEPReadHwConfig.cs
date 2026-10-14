using System;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.Communication.TetraUtility;
using Motorola.Common.LogUtility;

namespace Motorola.Common.Communication
{
	// Token: 0x02000032 RID: 50
	public class SBEPReadHwConfig : global::Motorola.Common.Communication.SBEPBaseRead
	{
		// Token: 0x06000192 RID: 402 RVA: 0x000083BB File Offset: 0x000065BB
		public SBEPReadHwConfig(ushort size)
		{
			base.InternalStartAddress = this.READ_HW_CONFIG_ADDRESS;
			base.ExpectedReadLength = size;
		}

		// Token: 0x06000193 RID: 403 RVA: 0x000083E1 File Offset: 0x000065E1
		public SBEPReadHwConfig(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe transPipe, ushort size)
		{
			base.InternalStartAddress = this.READ_HW_CONFIG_ADDRESS;
			base.ExpectedReadLength = size;
			base.TransportPipe = transPipe;
		}

		// Token: 0x06000194 RID: 404 RVA: 0x0000840E File Offset: 0x0000660E
		public SBEPReadHwConfig(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe transPipe)
		{
			base.InternalStartAddress = this.READ_HW_CONFIG_ADDRESS;
			base.TransportPipe = transPipe;
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000195 RID: 405 RVA: 0x00008434 File Offset: 0x00006634
		// (set) Token: 0x06000196 RID: 406 RVA: 0x0000843C File Offset: 0x0000663C
		public ushort Size
		{
			get
			{
				return base.ExpectedReadLength;
			}
			set
			{
				base.ExpectedReadLength = value;
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000197 RID: 407 RVA: 0x00008445 File Offset: 0x00006645
		public byte[] Data
		{
			get
			{
				return base.ReceivedData;
			}
		}

		// Token: 0x06000198 RID: 408 RVA: 0x0000844D File Offset: 0x0000664D
		public override void ExecuteMessage()
		{
			global::Motorola.Common.LogUtility.LoggerUtil.SetTimeStampLabel("SBEPProtocol.SBEPReadHwConfig");
			base.ExecuteMessage();
			global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.SBEP_PERFORMANCE_LOGGER_NAME).Performance("SBEPProtocol.SBEPReadHwConfig", "");
		}

		// Token: 0x04000087 RID: 135
		private readonly uint READ_HW_CONFIG_ADDRESS = 4294967070U;
	}
}
