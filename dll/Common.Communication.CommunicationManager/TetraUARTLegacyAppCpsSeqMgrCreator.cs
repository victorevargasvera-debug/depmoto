using System;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.Communication.SequenceManager;

namespace Motorola.Common.Communication.CommunicationManager
{
	// Token: 0x02000061 RID: 97
	[global::Motorola.Common.Communication.CommunicationManager.Initializer(global::Motorola.Common.Communication.CommonUtil.ConnectionType.RS232, global::Motorola.Common.Communication.CommonUtil.ProductFamily.LegacyAppRadio, global::Motorola.Common.Communication.CommonUtil.RadioStorage.Any, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Any)]
	internal class TetraUARTLegacyAppCpsSeqMgrCreator : global::Motorola.Common.Communication.CommunicationManager.ISequenceManagerCreator
	{
		// Token: 0x06000244 RID: 580 RVA: 0x0000C23C File Offset: 0x0000A43C
		public global::Motorola.Common.Communication.ICpsSequenceManager Create(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe iCommPipe, global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.CommonUtil.SessionParameter sessionParameter)
		{
			return this.newTetraRPSeqManager(iCommPipe, deviceInfo);
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000245 RID: 581 RVA: 0x0000C253 File Offset: 0x0000A453
		public global::System.Type ExpectedType
		{
			get
			{
				return typeof(global::Motorola.Common.Communication.SequenceManager.TetraRPSeqManager);
			}
		}

		// Token: 0x06000246 RID: 582 RVA: 0x0000C25F File Offset: 0x0000A45F
		private global::Motorola.Common.Communication.SequenceManager.TetraRPSeqManager newTetraRPSeqManager(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe transport, global::Motorola.Common.Communication.CommonUtil.DeviceInfo devInfo)
		{
			return new global::Motorola.Common.Communication.SequenceManager.TetraRPSeqManager(transport, devInfo);
		}
	}
}
