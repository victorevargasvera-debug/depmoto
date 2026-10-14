using System;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.CommunicationManager
{
	// Token: 0x02000015 RID: 21
	[global::Motorola.Common.Communication.CommunicationManager.Initializer(global::Motorola.Common.Communication.CommonUtil.ConnectionType.Otap, global::Motorola.Common.Communication.CommonUtil.ProductFamily.AstroRadio, global::Motorola.Common.Communication.CommonUtil.RadioStorage.FileSystem, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Flash)]
	internal class AstroOTAPFileFlashSequenceManagerCreator : global::Motorola.Common.Communication.CommunicationManager.ISequenceManagerCreator
	{
		// Token: 0x06000094 RID: 148 RVA: 0x00003C84 File Offset: 0x00001E84
		public global::Motorola.Common.Communication.ICpsSequenceManager Create(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe iCommPipe, global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.CommonUtil.SessionParameter sessionParameter)
		{
			int num = (deviceInfo.ConnectionInfo.InactivityTimeout > 0) ? deviceInfo.ConnectionInfo.InactivityTimeout : 180;
			global::Motorola.Common.Communication.AstroOtapRcmpMessageExecutor rcmpWrapper = global::Motorola.Common.Communication.CommunicationManager.newRcmpMessageExecutor.newAstroOtapRMessageExecutor(iCommPipe, num);
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(deviceInfo.ConnectionInfo, global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerCreateSequenceManagerFailure);
			return (sessionParameter != null && sessionParameter.ArchiveSession) ? new global::Motorola.Common.Communication.AstroOTAPManagedFileFlashSeqManager(rcmpWrapper, num, sessionParameter) : new global::Motorola.Common.Communication.AstroOTAPFileFlashSeqManager(rcmpWrapper, num, sessionParameter);
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000095 RID: 149 RVA: 0x00003CE9 File Offset: 0x00001EE9
		public global::System.Type ExpectedType
		{
			get
			{
				return typeof(global::Motorola.Common.Communication.AstroOTAPFileFlashSeqManager);
			}
		}
	}
}
