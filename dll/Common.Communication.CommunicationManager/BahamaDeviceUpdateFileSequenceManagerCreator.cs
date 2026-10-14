using System;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.Communication.SequenceManager;

namespace Motorola.Common.Communication.CommunicationManager
{
	// Token: 0x02000035 RID: 53
	[global::Motorola.Common.Communication.CommunicationManager.Initializer(global::Motorola.Common.Communication.CommonUtil.ConnectionType.NetAdapter, global::Motorola.Common.Communication.CommonUtil.ProductFamily.ParadiseRepeaterRadio, global::Motorola.Common.Communication.CommonUtil.RadioStorage.Any, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Flash)]
	internal class BahamaDeviceUpdateFileSequenceManagerCreator : global::Motorola.Common.Communication.CommunicationManager.ISequenceManagerCreator
	{
		// Token: 0x06000160 RID: 352 RVA: 0x00007650 File Offset: 0x00005850
		public global::Motorola.Common.Communication.ICpsSequenceManager Create(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe iCommPipe, global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.CommonUtil.SessionParameter sessionParameter)
		{
			global::Motorola.Common.Communication.SequenceManager.PcrRcmpMessageExecutor rcmpWrapper = global::Motorola.Common.Communication.CommunicationManager.newMessageExecutor.newPRMessageExecutor(iCommPipe, 20000);
			return new global::Motorola.Common.Communication.SequenceManager.PcrDeviceUpdateFileSequencer(rcmpWrapper, 1000);
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000161 RID: 353 RVA: 0x00007676 File Offset: 0x00005876
		public global::System.Type ExpectedType
		{
			get
			{
				return typeof(global::Motorola.Common.Communication.SequenceManager.PcrDeviceUpdateFileSequencer);
			}
		}
	}
}
