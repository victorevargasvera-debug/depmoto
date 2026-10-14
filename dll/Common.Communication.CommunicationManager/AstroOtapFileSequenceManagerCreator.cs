using System;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.CommunicationManager
{
	// Token: 0x02000010 RID: 16
	[global::Motorola.Common.Communication.CommunicationManager.Initializer(global::Motorola.Common.Communication.CommonUtil.ConnectionType.Otap, global::Motorola.Common.Communication.CommonUtil.ProductFamily.AstroRadio, global::Motorola.Common.Communication.CommonUtil.RadioStorage.FileSystem, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Read | global::Motorola.Common.Communication.CommonUtil.RadioOperation.Program)]
	internal class AstroOtapFileSequenceManagerCreator : global::Motorola.Common.Communication.CommunicationManager.ISequenceManagerCreator
	{
		// Token: 0x06000085 RID: 133 RVA: 0x00003A94 File Offset: 0x00001C94
		public global::Motorola.Common.Communication.ICpsSequenceManager Create(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe iCommPipe, global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.CommonUtil.SessionParameter sessionParameter)
		{
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(deviceInfo.ConnectionInfo, global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerCreateSequenceManagerFailure);
			int num = (deviceInfo.ConnectionInfo.InactivityTimeout > 0) ? deviceInfo.ConnectionInfo.InactivityTimeout : 180;
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("Astro Otap InactivityTimer is set to [{0}]. - try to set with [{1}]", new object[]
			{
				num,
				deviceInfo.ConnectionInfo.InactivityTimeout
			});
			global::Motorola.Common.Communication.AstroOtapRcmpMessageExecutor rcmpWrapper = global::Motorola.Common.Communication.CommunicationManager.newRcmpMessageExecutor.newAstroOtapRMessageExecutor(iCommPipe, num);
			return (sessionParameter != null && sessionParameter.ArchiveSession) ? new global::Motorola.Common.Communication.AstroManagedOtapFileSeqManager(rcmpWrapper, num, sessionParameter) : new global::Motorola.Common.Communication.AstroOtapFileSeqManager(rcmpWrapper, num, sessionParameter);
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000086 RID: 134 RVA: 0x00003B2C File Offset: 0x00001D2C
		public global::System.Type ExpectedType
		{
			get
			{
				return typeof(global::Motorola.Common.Communication.AstroOtapFileSeqManager);
			}
		}
	}
}
