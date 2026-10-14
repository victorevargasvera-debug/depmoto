using System;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.Communication.SequenceManager;

namespace Motorola.Common.Communication.CommunicationManager
{
	// Token: 0x02000031 RID: 49
	[global::Motorola.Common.Communication.CommunicationManager.Initializer(global::Motorola.Common.Communication.CommonUtil.ConnectionType.Fudally, (global::Motorola.Common.Communication.CommonUtil.ProductFamily)6, global::Motorola.Common.Communication.CommonUtil.RadioStorage.Any, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Flash | global::Motorola.Common.Communication.CommonUtil.RadioOperation.DepotFlash)]
	internal class PcrDeviceUpdateBootSequenceManagerCreator : global::Motorola.Common.Communication.CommunicationManager.ISequenceManagerCreator
	{
		// Token: 0x06000154 RID: 340 RVA: 0x00007528 File Offset: 0x00005728
		public global::Motorola.Common.Communication.ICpsSequenceManager Create(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe iCommPipe, global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.CommonUtil.SessionParameter sessionParameter)
		{
			global::Motorola.Common.Communication.SequenceManager.PcrRcmpMessageExecutor rcmpWrapper = global::Motorola.Common.Communication.CommunicationManager.newMessageExecutor.newPRMessageExecutor(iCommPipe, 20000);
			return new global::Motorola.Common.Communication.SequenceManager.PcrDeviceUpdateBootSequencer(rcmpWrapper, 1000);
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000155 RID: 341 RVA: 0x0000754E File Offset: 0x0000574E
		public global::System.Type ExpectedType
		{
			get
			{
				return typeof(global::Motorola.Common.Communication.SequenceManager.PcrDeviceUpdateBootSequencer);
			}
		}
	}
}
