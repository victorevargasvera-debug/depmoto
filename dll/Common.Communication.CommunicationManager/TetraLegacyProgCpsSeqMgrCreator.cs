using System;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.Communication.SequenceManager;

namespace Motorola.Common.Communication.CommunicationManager
{
	// Token: 0x0200005A RID: 90
	[global::Motorola.Common.Communication.CommunicationManager.Initializer(global::Motorola.Common.Communication.CommonUtil.ConnectionType.VCOM, global::Motorola.Common.Communication.CommonUtil.ProductFamily.LegacyProgRadio, global::Motorola.Common.Communication.CommonUtil.RadioStorage.Any, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Any)]
	internal class TetraLegacyProgCpsSeqMgrCreator : global::Motorola.Common.Communication.CommunicationManager.ISequenceManagerCreator
	{
		// Token: 0x06000228 RID: 552 RVA: 0x0000C0D0 File Offset: 0x0000A2D0
		public global::Motorola.Common.Communication.ICpsSequenceManager Create(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe iCommPipe, global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.CommonUtil.SessionParameter sessionParameter)
		{
			return this.newTetraPhysicalAddressSeqMgr(iCommPipe, deviceInfo);
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000229 RID: 553 RVA: 0x0000C0E7 File Offset: 0x0000A2E7
		public global::System.Type ExpectedType
		{
			get
			{
				return typeof(global::Motorola.Common.Communication.SequenceManager.TetraPhysicalAddressSeqMgr);
			}
		}

		// Token: 0x0600022A RID: 554 RVA: 0x0000C0F3 File Offset: 0x0000A2F3
		private global::Motorola.Common.Communication.SequenceManager.TetraPhysicalAddressSeqMgr newTetraPhysicalAddressSeqMgr(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe transport, global::Motorola.Common.Communication.CommonUtil.DeviceInfo devInfo)
		{
			return new global::Motorola.Common.Communication.SequenceManager.TetraPhysicalAddressSeqMgr(transport, devInfo);
		}
	}
}
