using System;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.Communication.SequenceManager;

namespace Motorola.Common.Communication.CommunicationManager
{
	// Token: 0x0200005E RID: 94
	[global::Motorola.Common.Communication.CommunicationManager.Initializer(global::Motorola.Common.Communication.CommonUtil.ConnectionType.VCOM, global::Motorola.Common.Communication.CommonUtil.ProductFamily.GemstoneBMPMassStorageRadio, global::Motorola.Common.Communication.CommonUtil.RadioStorage.Any, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Any)]
	internal class TetraMassStorageCpsSeqMgrCreator : global::Motorola.Common.Communication.CommunicationManager.ISequenceManagerCreator
	{
		// Token: 0x06000238 RID: 568 RVA: 0x0000C1A0 File Offset: 0x0000A3A0
		public global::Motorola.Common.Communication.ICpsSequenceManager Create(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe iCommPipe, global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.CommonUtil.SessionParameter sessionParameter)
		{
			return this.newTetraMassStorageSeqManager(iCommPipe, deviceInfo);
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000239 RID: 569 RVA: 0x0000C1B7 File Offset: 0x0000A3B7
		public global::System.Type ExpectedType
		{
			get
			{
				return typeof(global::Motorola.Common.Communication.SequenceManager.TetraMassStorageSeqManager);
			}
		}

		// Token: 0x0600023A RID: 570 RVA: 0x0000C1C3 File Offset: 0x0000A3C3
		private global::Motorola.Common.Communication.SequenceManager.TetraMassStorageSeqManager newTetraMassStorageSeqManager(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe transport, global::Motorola.Common.Communication.CommonUtil.DeviceInfo devInfo)
		{
			return new global::Motorola.Common.Communication.SequenceManager.TetraMassStorageSeqManager(transport, devInfo);
		}
	}
}
