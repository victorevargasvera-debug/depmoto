using System;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.Communication.SequenceManager;

namespace Motorola.Common.Communication.CommunicationManager
{
	// Token: 0x0200005B RID: 91
	[global::Motorola.Common.Communication.CommunicationManager.Initializer(global::Motorola.Common.Communication.CommonUtil.ConnectionType.VCOM, global::Motorola.Common.Communication.CommonUtil.ProductFamily.LegacyAppRadio, global::Motorola.Common.Communication.CommonUtil.RadioStorage.Any, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Any)]
	internal class TetraLegacyAppCpsSeqMgrCreator : global::Motorola.Common.Communication.CommunicationManager.ISequenceManagerCreator
	{
		// Token: 0x0600022C RID: 556 RVA: 0x0000C104 File Offset: 0x0000A304
		public global::Motorola.Common.Communication.ICpsSequenceManager Create(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe iCommPipe, global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.CommonUtil.SessionParameter sessionParameter)
		{
			return this.newTetraRPSeqManager(iCommPipe, deviceInfo);
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x0600022D RID: 557 RVA: 0x0000C11B File Offset: 0x0000A31B
		public global::System.Type ExpectedType
		{
			get
			{
				return typeof(global::Motorola.Common.Communication.SequenceManager.TetraRPSeqManager);
			}
		}

		// Token: 0x0600022E RID: 558 RVA: 0x0000C127 File Offset: 0x0000A327
		private global::Motorola.Common.Communication.SequenceManager.TetraRPSeqManager newTetraRPSeqManager(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe transport, global::Motorola.Common.Communication.CommonUtil.DeviceInfo devInfo)
		{
			return new global::Motorola.Common.Communication.SequenceManager.TetraRPSeqManager(transport, devInfo);
		}
	}
}
