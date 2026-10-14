using System;
using fxpcommunication;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.Communication.SequenceManager;

namespace Motorola.Common.Communication.CommunicationManager
{
	// Token: 0x0200003C RID: 60
	[global::Motorola.Common.Communication.CommunicationManager.Initializer(global::Motorola.Common.Communication.CommonUtil.ConnectionType.WIFI, global::Motorola.Common.Communication.CommonUtil.ProductFamily.PCRRadio, global::Motorola.Common.Communication.CommonUtil.RadioStorage.Any, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Create | global::Motorola.Common.Communication.CommonUtil.RadioOperation.Read | global::Motorola.Common.Communication.CommonUtil.RadioOperation.Program | global::Motorola.Common.Communication.CommonUtil.RadioOperation.Flash | global::Motorola.Common.Communication.CommonUtil.RadioOperation.ChargingFeature)]
	internal class PcrWiFiSequenceManagerCreator : global::Motorola.Common.Communication.CommunicationManager.ISequenceManagerCreator
	{
		// Token: 0x06000175 RID: 373 RVA: 0x00007850 File Offset: 0x00005A50
		public global::Motorola.Common.Communication.ICpsSequenceManager Create(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe iCommPipe, global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.CommonUtil.SessionParameter sessionParameter)
		{
			global::fxpcommunication.FxpCommunication featureEnable = new global::fxpcommunication.FxpCommunication(deviceInfo.SoftwareVersion, iCommPipe, 5000, 10);
			global::Motorola.Common.Communication.SequenceManager.PcrRcmpMessageExecutor messageExecutor = global::Motorola.Common.Communication.CommunicationManager.newMessageExecutor.newWiFiMessageExecutor(iCommPipe, 60000);
			return new global::Motorola.Common.Communication.SequenceManager.PCRWiFiSequenceManager(messageExecutor, global::Motorola.Common.Communication.CommunicationManager.GeneralConfigs.Instance.PCRWiFiMaxPacketSize, featureEnable);
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000176 RID: 374 RVA: 0x00007890 File Offset: 0x00005A90
		public global::System.Type ExpectedType
		{
			get
			{
				return typeof(global::Motorola.Common.Communication.CommunicationManager.PcrWiFiSequenceManagerCreator);
			}
		}
	}
}
