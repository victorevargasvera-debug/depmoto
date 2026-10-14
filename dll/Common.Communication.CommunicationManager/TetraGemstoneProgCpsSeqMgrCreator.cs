using System;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.Communication.SequenceManager;

namespace Motorola.Common.Communication.CommunicationManager
{
	// Token: 0x0200005C RID: 92
	[global::Motorola.Common.Communication.CommunicationManager.Initializer(global::Motorola.Common.Communication.CommonUtil.ConnectionType.VCOM, (global::Motorola.Common.Communication.CommonUtil.ProductFamily)5120, global::Motorola.Common.Communication.CommonUtil.RadioStorage.Any, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Any)]
	internal class TetraGemstoneProgCpsSeqMgrCreator : global::Motorola.Common.Communication.CommunicationManager.ISequenceManagerCreator
	{
		// Token: 0x06000230 RID: 560 RVA: 0x0000C138 File Offset: 0x0000A338
		public global::Motorola.Common.Communication.ICpsSequenceManager Create(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe iCommPipe, global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.CommonUtil.SessionParameter sessionParameter)
		{
			return this.newTetraBaseVirtualAddressSeqMgr(iCommPipe, deviceInfo);
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x06000231 RID: 561 RVA: 0x0000C14F File Offset: 0x0000A34F
		public global::System.Type ExpectedType
		{
			get
			{
				return typeof(global::Motorola.Common.Communication.SequenceManager.TetraBaseVirtualAddressSeqMgr);
			}
		}

		// Token: 0x06000232 RID: 562 RVA: 0x0000C15B File Offset: 0x0000A35B
		private global::Motorola.Common.Communication.SequenceManager.TetraBaseVirtualAddressSeqMgr newTetraBaseVirtualAddressSeqMgr(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe transport, global::Motorola.Common.Communication.CommonUtil.DeviceInfo devInfo)
		{
			return new global::Motorola.Common.Communication.SequenceManager.TetraBaseVirtualAddressSeqMgr(transport, devInfo);
		}
	}
}
