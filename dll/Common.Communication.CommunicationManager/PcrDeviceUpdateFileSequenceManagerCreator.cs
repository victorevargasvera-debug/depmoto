using System;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.Communication.SequenceManager;

namespace Motorola.Common.Communication.CommunicationManager
{
	// Token: 0x02000037 RID: 55
	[global::Motorola.Common.Communication.CommunicationManager.Initializer(global::Motorola.Common.Communication.CommonUtil.ConnectionType.NetAdapter, (global::Motorola.Common.Communication.CommonUtil.ProductFamily)24, global::Motorola.Common.Communication.CommonUtil.RadioStorage.Any, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Flash | global::Motorola.Common.Communication.CommonUtil.RadioOperation.DepotFlash)]
	internal class PcrDeviceUpdateFileSequenceManagerCreator : global::Motorola.Common.Communication.CommunicationManager.ISequenceManagerCreator
	{
		// Token: 0x06000166 RID: 358 RVA: 0x000076C8 File Offset: 0x000058C8
		public global::Motorola.Common.Communication.ICpsSequenceManager Create(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe iCommPipe, global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.CommonUtil.SessionParameter sessionParameter)
		{
			global::Motorola.Common.Communication.SequenceManager.PcrRcmpMessageExecutor rcmpWrapper = global::Motorola.Common.Communication.CommunicationManager.newMessageExecutor.newPRMessageExecutor(iCommPipe, 20000);
			return new global::Motorola.Common.Communication.SequenceManager.PcrDeviceUpdateFileSequencer(rcmpWrapper, 1000);
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000167 RID: 359 RVA: 0x000076EE File Offset: 0x000058EE
		public global::System.Type ExpectedType
		{
			get
			{
				return typeof(global::Motorola.Common.Communication.SequenceManager.PcrDeviceUpdateFileSequencer);
			}
		}
	}
}
