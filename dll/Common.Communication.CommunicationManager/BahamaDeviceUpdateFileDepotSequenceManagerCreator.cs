using System;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.Communication.SequenceManager;

namespace Motorola.Common.Communication.CommunicationManager
{
	// Token: 0x02000036 RID: 54
	[global::Motorola.Common.Communication.CommunicationManager.Initializer(global::Motorola.Common.Communication.CommonUtil.ConnectionType.NetAdapter, global::Motorola.Common.Communication.CommonUtil.ProductFamily.ParadiseRepeaterRadio, global::Motorola.Common.Communication.CommonUtil.RadioStorage.Any, global::Motorola.Common.Communication.CommonUtil.RadioOperation.DepotFlash)]
	internal class BahamaDeviceUpdateFileDepotSequenceManagerCreator : global::Motorola.Common.Communication.CommunicationManager.ISequenceManagerCreator
	{
		// Token: 0x06000163 RID: 355 RVA: 0x0000768C File Offset: 0x0000588C
		public global::Motorola.Common.Communication.ICpsSequenceManager Create(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe iCommPipe, global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.CommonUtil.SessionParameter sessionParameter)
		{
			global::Motorola.Common.Communication.SequenceManager.PcrRcmpMessageExecutor rcmpWrapper = global::Motorola.Common.Communication.CommunicationManager.newMessageExecutor.newPRMessageExecutor(iCommPipe, 20000);
			return new global::Motorola.Common.Communication.SequenceManager.PcrDeviceUpdateFileDepotSequencer(rcmpWrapper, 1000);
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000164 RID: 356 RVA: 0x000076B2 File Offset: 0x000058B2
		public global::System.Type ExpectedType
		{
			get
			{
				return typeof(global::Motorola.Common.Communication.SequenceManager.PcrDeviceUpdateFileDepotSequencer);
			}
		}
	}
}
