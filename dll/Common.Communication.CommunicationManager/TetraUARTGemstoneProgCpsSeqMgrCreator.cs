using System;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.Communication.SequenceManager;

namespace Motorola.Common.Communication.CommunicationManager
{
	// Token: 0x02000062 RID: 98
	[global::Motorola.Common.Communication.CommunicationManager.Initializer(global::Motorola.Common.Communication.CommonUtil.ConnectionType.RS232, (global::Motorola.Common.Communication.CommonUtil.ProductFamily)5120, global::Motorola.Common.Communication.CommonUtil.RadioStorage.Any, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Any)]
	internal class TetraUARTGemstoneProgCpsSeqMgrCreator : global::Motorola.Common.Communication.CommunicationManager.ISequenceManagerCreator
	{
		// Token: 0x06000248 RID: 584 RVA: 0x0000C270 File Offset: 0x0000A470
		public global::Motorola.Common.Communication.ICpsSequenceManager Create(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe iCommPipe, global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.CommonUtil.SessionParameter sessionParameter)
		{
			return this.newTetraBaseVirtualAddressSeqMgr(iCommPipe, deviceInfo);
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x06000249 RID: 585 RVA: 0x0000C287 File Offset: 0x0000A487
		public global::System.Type ExpectedType
		{
			get
			{
				return typeof(global::Motorola.Common.Communication.SequenceManager.TetraBaseVirtualAddressSeqMgr);
			}
		}

		// Token: 0x0600024A RID: 586 RVA: 0x0000C293 File Offset: 0x0000A493
		private global::Motorola.Common.Communication.SequenceManager.TetraBaseVirtualAddressSeqMgr newTetraBaseVirtualAddressSeqMgr(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe transport, global::Motorola.Common.Communication.CommonUtil.DeviceInfo devInfo)
		{
			return new global::Motorola.Common.Communication.SequenceManager.TetraBaseVirtualAddressSeqMgr(transport, devInfo);
		}
	}
}
