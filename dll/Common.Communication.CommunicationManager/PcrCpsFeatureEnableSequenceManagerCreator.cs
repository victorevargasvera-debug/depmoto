using System;
using fxpcommunication;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.Communication.SequenceManager;

namespace Motorola.Common.Communication.CommunicationManager
{
	// Token: 0x0200003B RID: 59
	[global::Motorola.Common.Communication.CommunicationManager.Initializer(global::Motorola.Common.Communication.CommonUtil.ConnectionType.NetAdapter | global::Motorola.Common.Communication.CommonUtil.ConnectionType.Bluetooth, global::Motorola.Common.Communication.CommonUtil.ProductFamily.PCRRadio, global::Motorola.Common.Communication.CommonUtil.RadioStorage.Any, global::Motorola.Common.Communication.CommonUtil.RadioOperation.ChargingFeature)]
	internal class PcrCpsFeatureEnableSequenceManagerCreator : global::Motorola.Common.Communication.CommunicationManager.ISequenceManagerCreator
	{
		// Token: 0x06000172 RID: 370 RVA: 0x00007814 File Offset: 0x00005A14
		public global::Motorola.Common.Communication.ICpsSequenceManager Create(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe iCommPipe, global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.CommonUtil.SessionParameter sessionParameter)
		{
			global::fxpcommunication.FxpCommunication featureExchange = new global::fxpcommunication.FxpCommunication(deviceInfo.SoftwareVersion, iCommPipe, 1000, 3);
			return new global::Motorola.Common.Communication.SequenceManager.PcrCpsSequenceManager(featureExchange);
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000173 RID: 371 RVA: 0x0000783C File Offset: 0x00005A3C
		public global::System.Type ExpectedType
		{
			get
			{
				return typeof(global::Motorola.Common.Communication.SequenceManager.PcrCpsSequenceManager);
			}
		}
	}
}
