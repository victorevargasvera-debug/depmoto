using System;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.CommunicationManager
{
	// Token: 0x02000014 RID: 20
	[global::Motorola.Common.Communication.CommunicationManager.Initializer(global::Motorola.Common.Communication.CommonUtil.ConnectionType.WIFI, global::Motorola.Common.Communication.CommonUtil.ProductFamily.AstroRadio, global::Motorola.Common.Communication.CommonUtil.RadioStorage.FileSystem, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Flash)]
	internal class AstroWiFiFileFlashSequenceManagerCreator : global::Motorola.Common.Communication.CommunicationManager.ISequenceManagerCreator
	{
		// Token: 0x06000091 RID: 145 RVA: 0x00003C20 File Offset: 0x00001E20
		public global::Motorola.Common.Communication.ICpsSequenceManager Create(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe iCommPipe, global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.CommonUtil.SessionParameter sessionParameter)
		{
			int num = (deviceInfo.ConnectionInfo.InactivityTimeout > 0) ? deviceInfo.ConnectionInfo.InactivityTimeout : 60;
			global::Motorola.Common.Communication.AstroWiFiRcmpMessageExecutor rcmpWrapper = global::Motorola.Common.Communication.CommunicationManager.newRcmpMessageExecutor.newAstroWiFiRMessageExecutor(iCommPipe, num);
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(deviceInfo.ConnectionInfo, global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerCreateSequenceManagerFailure);
			return new global::Motorola.Common.Communication.AstroWiFiManagedFileFlashSequenceManager(rcmpWrapper, num, sessionParameter);
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000092 RID: 146 RVA: 0x00003C6D File Offset: 0x00001E6D
		public global::System.Type ExpectedType
		{
			get
			{
				return typeof(global::Motorola.Common.Communication.AstroWiFiManagedFileFlashSequenceManager);
			}
		}
	}
}
