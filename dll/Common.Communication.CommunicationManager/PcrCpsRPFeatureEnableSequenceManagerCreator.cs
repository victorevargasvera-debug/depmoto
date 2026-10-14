using System;
using fxpcommunication;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.Communication.SequenceManager;

namespace Motorola.Common.Communication.CommunicationManager
{
	// Token: 0x0200003A RID: 58
	[global::Motorola.Common.Communication.CommunicationManager.Initializer(global::Motorola.Common.Communication.CommonUtil.ConnectionType.LENetwork | global::Motorola.Common.Communication.CommonUtil.ConnectionType.DMR3Network, global::Motorola.Common.Communication.CommonUtil.ProductFamily.PCRRadio, global::Motorola.Common.Communication.CommonUtil.RadioStorage.Any, global::Motorola.Common.Communication.CommonUtil.RadioOperation.ChargingFeature)]
	internal class PcrCpsRPFeatureEnableSequenceManagerCreator : global::Motorola.Common.Communication.CommunicationManager.ISequenceManagerCreator
	{
		// Token: 0x0600016F RID: 367 RVA: 0x000077C8 File Offset: 0x000059C8
		public global::Motorola.Common.Communication.ICpsSequenceManager Create(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe iCommPipe, global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.CommonUtil.SessionParameter sessionParameter)
		{
			global::Motorola.Common.Communication.SequenceManager.PCRRPRcmpMessageExecutor messageExecutor = global::Motorola.Common.Communication.CommunicationManager.newMessageExecutor.newPCRRPRMessageExecutor(iCommPipe, 20000);
			global::fxpcommunication.FxpCommunication rpFeatureEnable = new global::fxpcommunication.FxpCommunication(deviceInfo.SoftwareVersion, iCommPipe, messageExecutor);
			return new global::Motorola.Common.Communication.SequenceManager.PCRRPSequenceManager(messageExecutor, 1000, rpFeatureEnable);
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000170 RID: 368 RVA: 0x000077FD File Offset: 0x000059FD
		public global::System.Type ExpectedType
		{
			get
			{
				return typeof(global::Motorola.Common.Communication.SequenceManager.PCRRPSequenceManager);
			}
		}
	}
}
