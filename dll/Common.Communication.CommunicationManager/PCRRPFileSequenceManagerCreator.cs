using System;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.Communication.SequenceManager;

namespace Motorola.Common.Communication.CommunicationManager
{
	// Token: 0x02000039 RID: 57
	[global::Motorola.Common.Communication.CommunicationManager.Initializer(global::Motorola.Common.Communication.CommonUtil.ConnectionType.LENetwork | global::Motorola.Common.Communication.CommonUtil.ConnectionType.DMR3Network, global::Motorola.Common.Communication.CommonUtil.ProductFamily.ParadiseRepeaterRadio, global::Motorola.Common.Communication.CommonUtil.RadioStorage.Any, (global::Motorola.Common.Communication.CommonUtil.RadioOperation)65519UL)]
	internal class PCRRPFileSequenceManagerCreator : global::Motorola.Common.Communication.CommunicationManager.ISequenceManagerCreator
	{
		// Token: 0x0600016C RID: 364 RVA: 0x00007758 File Offset: 0x00005958
		public global::Motorola.Common.Communication.ICpsSequenceManager Create(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe iCommPipe, global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.CommonUtil.SessionParameter sessionParameter)
		{
			global::Motorola.Common.Communication.ICpsSequenceManager result;
			using (global::Motorola.Common.Communication.SequenceManager.PCRRPRcmpMessageExecutor pcrrprcmpMessageExecutor = new global::Motorola.Common.Communication.SequenceManager.PCRRPRcmpMessageExecutor(iCommPipe, 10000))
			{
				global::Motorola.Common.Communication.ICpsSequenceManager cpsSequenceManager = (sessionParameter != null && sessionParameter.ArchiveSession) ? new global::Motorola.Common.Communication.SequenceManager.PCRRMRPFileSequenceManager(pcrrprcmpMessageExecutor, 1000) : new global::Motorola.Common.Communication.SequenceManager.PCRRPFileSequenceManager(pcrrprcmpMessageExecutor, 1000);
				result = cpsSequenceManager;
			}
			return result;
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x0600016D RID: 365 RVA: 0x000077B4 File Offset: 0x000059B4
		public global::System.Type ExpectedType
		{
			get
			{
				return typeof(global::Motorola.Common.Communication.SequenceManager.PCRRPFileSequenceManager);
			}
		}
	}
}
