using System;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.Communication.SequenceManager;

namespace Motorola.Common.Communication.CommunicationManager
{
	// Token: 0x02000064 RID: 100
	[global::Motorola.Common.Communication.CommunicationManager.Initializer(global::Motorola.Common.Communication.CommonUtil.ConnectionType.RS232, global::Motorola.Common.Communication.CommonUtil.ProductFamily.FrodoAppRadio, global::Motorola.Common.Communication.CommonUtil.RadioStorage.Any, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Any)]
	internal class TetraUARTATFrodoSeqMgrCreator : global::Motorola.Common.Communication.CommunicationManager.ISequenceManagerCreator
	{
		// Token: 0x06000250 RID: 592 RVA: 0x0000C2D8 File Offset: 0x0000A4D8
		public global::Motorola.Common.Communication.ICpsSequenceManager Create(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe iCommPipe, global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.CommonUtil.SessionParameter sessionParameter)
		{
			return this.newTetraFrodoATSeqManager(iCommPipe, deviceInfo);
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x06000251 RID: 593 RVA: 0x0000C2EF File Offset: 0x0000A4EF
		public global::System.Type ExpectedType
		{
			get
			{
				return typeof(global::Motorola.Common.Communication.SequenceManager.TetraFrodoATSeqManager);
			}
		}

		// Token: 0x06000252 RID: 594 RVA: 0x0000C2FB File Offset: 0x0000A4FB
		private global::Motorola.Common.Communication.SequenceManager.TetraFrodoATSeqManager newTetraFrodoATSeqManager(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe transport, global::Motorola.Common.Communication.CommonUtil.DeviceInfo devInfo)
		{
			return new global::Motorola.Common.Communication.SequenceManager.TetraFrodoATSeqManager(transport, devInfo);
		}
	}
}
