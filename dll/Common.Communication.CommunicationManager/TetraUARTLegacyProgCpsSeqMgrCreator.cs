using System;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.Communication.SequenceManager;

namespace Motorola.Common.Communication.CommunicationManager
{
	// Token: 0x02000060 RID: 96
	[global::Motorola.Common.Communication.CommunicationManager.Initializer(global::Motorola.Common.Communication.CommonUtil.ConnectionType.RS232, global::Motorola.Common.Communication.CommonUtil.ProductFamily.LegacyProgRadio, global::Motorola.Common.Communication.CommonUtil.RadioStorage.Any, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Any)]
	internal class TetraUARTLegacyProgCpsSeqMgrCreator : global::Motorola.Common.Communication.CommunicationManager.ISequenceManagerCreator
	{
		// Token: 0x06000240 RID: 576 RVA: 0x0000C208 File Offset: 0x0000A408
		public global::Motorola.Common.Communication.ICpsSequenceManager Create(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe iCommPipe, global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.CommonUtil.SessionParameter sessionParameter)
		{
			return this.newTetraPhysicalAddressSeqMgr(iCommPipe, deviceInfo);
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000241 RID: 577 RVA: 0x0000C21F File Offset: 0x0000A41F
		public global::System.Type ExpectedType
		{
			get
			{
				return typeof(global::Motorola.Common.Communication.SequenceManager.TetraPhysicalAddressSeqMgr);
			}
		}

		// Token: 0x06000242 RID: 578 RVA: 0x0000C22B File Offset: 0x0000A42B
		private global::Motorola.Common.Communication.SequenceManager.TetraPhysicalAddressSeqMgr newTetraPhysicalAddressSeqMgr(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe transport, global::Motorola.Common.Communication.CommonUtil.DeviceInfo devInfo)
		{
			return new global::Motorola.Common.Communication.SequenceManager.TetraPhysicalAddressSeqMgr(transport, devInfo);
		}
	}
}
