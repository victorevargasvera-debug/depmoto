using System;
using System.Collections.Generic;
using System.ServiceModel;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.CustomException;
using SSLMangrComp;

namespace Motorola.Common.Communication.Service
{
	// Token: 0x02000008 RID: 8
	[global::System.ServiceModel.ServiceContract(SessionMode = global::System.ServiceModel.SessionMode.Required, CallbackContract = typeof(global::Motorola.Common.Communication.Service.IDiscoveryServiceEvent))]
	public interface IDeviceDiscovery : global::System.IDisposable
	{
		// Token: 0x060001CD RID: 461
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		[global::System.ServiceModel.OperationContract]
		global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DeviceInfo> ListConnectedDevices(int deviceConnectionType);

		// Token: 0x060001CE RID: 462
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DeviceInfo> CheckForDevice(int deviceConnectionType, string identifier);

		// Token: 0x060001CF RID: 463
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		[global::System.ServiceModel.OperationContract]
		void RegisterForPresence(global::System.Collections.Generic.List<string> deviceIDs, global::SSLMangrComp.PNConnectionInfo connInfo);

		// Token: 0x060001D0 RID: 464
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		[global::System.ServiceModel.OperationContract]
		void DeregisterForPresence(global::System.Collections.Generic.List<string> deviceIDs, global::SSLMangrComp.PNConnectionInfo connInfo);

		// Token: 0x060001D1 RID: 465
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		[global::System.ServiceModel.OperationContract]
		global::SSLMangrComp.PresenceNotification RetrievePresenceInfo(global::SSLMangrComp.PNConnectionInfo connInfo);

		// Token: 0x060001D2 RID: 466
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		void ClosePN();

		// Token: 0x060001D3 RID: 467
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		[global::System.ServiceModel.OperationContract]
		bool Connect2PCRIPSystem(global::Motorola.Common.Communication.CommonUtil.PCRIPSystemInfo sysConfiguration);

		// Token: 0x060001D4 RID: 468
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		void DisconnectFromPCRIPSystem();

		// Token: 0x060001D5 RID: 469
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		void UpdatePassword(global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.AuthenticationInfo> passwords);

		// Token: 0x060001D6 RID: 470
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonException))]
		[global::System.ServiceModel.OperationContract]
		void DetachDevice(string serialnumber);
	}
}
