using System;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.Communication.SequenceManager;

namespace Motorola.Common.Communication.CommunicationManager
{
	// Token: 0x0200005F RID: 95
	[global::Motorola.Common.Communication.CommunicationManager.Initializer(global::Motorola.Common.Communication.CommonUtil.ConnectionType.VCOM, global::Motorola.Common.Communication.CommonUtil.ProductFamily.FrodoAppRadio, global::Motorola.Common.Communication.CommonUtil.RadioStorage.Any, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Any)]
	internal class TetraATFrodoSeqMgrCreator : global::Motorola.Common.Communication.CommunicationManager.ISequenceManagerCreator
	{
		// Token: 0x0600023C RID: 572 RVA: 0x0000C1D4 File Offset: 0x0000A3D4
		public global::Motorola.Common.Communication.ICpsSequenceManager Create(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe iCommPipe, global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.CommonUtil.SessionParameter sessionParameter)
		{
			return this.newTetraFrodoATSeqManager(iCommPipe, deviceInfo);
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x0600023D RID: 573 RVA: 0x0000C1EB File Offset: 0x0000A3EB
		public global::System.Type ExpectedType
		{
			get
			{
				return typeof(global::Motorola.Common.Communication.SequenceManager.TetraFrodoATSeqManager);
			}
		}

		// Token: 0x0600023E RID: 574 RVA: 0x0000C1F7 File Offset: 0x0000A3F7
		private global::Motorola.Common.Communication.SequenceManager.TetraFrodoATSeqManager newTetraFrodoATSeqManager(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe transport, global::Motorola.Common.Communication.CommonUtil.DeviceInfo devInfo)
		{
			return new global::Motorola.Common.Communication.SequenceManager.TetraFrodoATSeqManager(transport, devInfo);
		}
	}
}
