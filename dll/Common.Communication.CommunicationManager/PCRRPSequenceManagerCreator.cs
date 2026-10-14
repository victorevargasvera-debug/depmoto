using System;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.Communication.SequenceManager;

namespace Motorola.Common.Communication.CommunicationManager
{
	// Token: 0x02000038 RID: 56
	[global::Motorola.Common.Communication.CommunicationManager.Initializer(global::Motorola.Common.Communication.CommonUtil.ConnectionType.LENetwork | global::Motorola.Common.Communication.CommonUtil.ConnectionType.DMR3Network, (global::Motorola.Common.Communication.CommonUtil.ProductFamily)66, global::Motorola.Common.Communication.CommonUtil.RadioStorage.Any, (global::Motorola.Common.Communication.CommonUtil.RadioOperation)65519UL)]
	internal class PCRRPSequenceManagerCreator : global::Motorola.Common.Communication.CommunicationManager.ISequenceManagerCreator
	{
		// Token: 0x06000169 RID: 361 RVA: 0x00007704 File Offset: 0x00005904
		public global::Motorola.Common.Communication.ICpsSequenceManager Create(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe iCommPipe, global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.CommonUtil.SessionParameter sessionParameter)
		{
			global::Motorola.Common.Communication.SequenceManager.PCRRPRcmpMessageExecutor messageExecutor = global::Motorola.Common.Communication.CommunicationManager.newMessageExecutor.newPCRRPRMessageExecutor(iCommPipe, 10000);
			return (sessionParameter != null && sessionParameter.ArchiveSession) ? new global::Motorola.Common.Communication.SequenceManager.PCRRPFullCPSequenceManager(messageExecutor, 1000) : new global::Motorola.Common.Communication.SequenceManager.PCRRPSequenceManager(messageExecutor, 1000);
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x0600016A RID: 362 RVA: 0x00007742 File Offset: 0x00005942
		public global::System.Type ExpectedType
		{
			get
			{
				return typeof(global::Motorola.Common.Communication.SequenceManager.PCRRPSequenceManager);
			}
		}
	}
}
