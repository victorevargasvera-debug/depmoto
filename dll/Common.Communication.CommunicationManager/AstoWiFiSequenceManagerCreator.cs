using System;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.CommunicationManager
{
	// Token: 0x02000013 RID: 19
	[global::Motorola.Common.Communication.CommunicationManager.Initializer(global::Motorola.Common.Communication.CommonUtil.ConnectionType.WIFI, global::Motorola.Common.Communication.CommonUtil.ProductFamily.AstroRadio, global::Motorola.Common.Communication.CommonUtil.RadioStorage.FileSystem, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Read | global::Motorola.Common.Communication.CommonUtil.RadioOperation.Program | global::Motorola.Common.Communication.CommonUtil.RadioOperation.CBIProgram)]
	[global::Motorola.Common.Communication.CommunicationManager.Initializer(global::Motorola.Common.Communication.CommonUtil.ConnectionType.WIFI, global::Motorola.Common.Communication.CommonUtil.ProductFamily.AstroRadio, global::Motorola.Common.Communication.CommonUtil.RadioStorage.Any, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Create)]
	internal class AstoWiFiSequenceManagerCreator : global::Motorola.Common.Communication.CommunicationManager.ISequenceManagerCreator
	{
		// Token: 0x0600008E RID: 142 RVA: 0x00003BBC File Offset: 0x00001DBC
		public global::Motorola.Common.Communication.ICpsSequenceManager Create(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe iCommPipe, global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.CommonUtil.SessionParameter sessionParameter)
		{
			int num = (deviceInfo.ConnectionInfo.InactivityTimeout > 0) ? deviceInfo.ConnectionInfo.InactivityTimeout : 60;
			global::Motorola.Common.Communication.AstroWiFiRcmpMessageExecutor rcmpWrapper = global::Motorola.Common.Communication.CommunicationManager.newRcmpMessageExecutor.newAstroWiFiRMessageExecutor(iCommPipe, num);
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(deviceInfo.ConnectionInfo, global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerCreateSequenceManagerFailure);
			return new global::Motorola.Common.Communication.AstroWifiFileSeqManager(rcmpWrapper, num, sessionParameter);
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600008F RID: 143 RVA: 0x00003C09 File Offset: 0x00001E09
		public global::System.Type ExpectedType
		{
			get
			{
				return typeof(global::Motorola.Common.Communication.AstroWifiFileSeqManager);
			}
		}
	}
}
