using System;
using System.ServiceModel;
using Motorola.Common.Communication.CommonUtil;

namespace Motorola.Common.Communication.Service
{
	// Token: 0x0200000E RID: 14
	public interface IDiscoveryServiceEvent
	{
		// Token: 0x06000208 RID: 520
		[global::System.ServiceModel.OperationContract(IsOneWay = true)]
		void OnDeviceConnected(global::Motorola.Common.Communication.CommonUtil.DeviceEventArgs args);

		// Token: 0x06000209 RID: 521
		[global::System.ServiceModel.OperationContract(IsOneWay = true)]
		void OnDeviceLost(global::Motorola.Common.Communication.CommonUtil.DeviceEventArgs args);

		// Token: 0x0600020A RID: 522
		[global::System.ServiceModel.OperationContract(IsOneWay = true)]
		void OnMasterSystemLost(global::Motorola.Common.Communication.CommonUtil.DeviceEventArgs args);

		// Token: 0x0600020B RID: 523
		[global::System.ServiceModel.OperationContract(IsOneWay = true)]
		void OnDeviceSwitchOver(global::Motorola.Common.Communication.CommonUtil.SwitchOverEventArgs args);
	}
}
