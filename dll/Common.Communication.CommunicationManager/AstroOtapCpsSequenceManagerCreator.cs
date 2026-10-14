using System;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.CommunicationManager
{
	// Token: 0x0200000E RID: 14
	[global::Motorola.Common.Communication.CommunicationManager.Initializer(global::Motorola.Common.Communication.CommonUtil.ConnectionType.Otap, global::Motorola.Common.Communication.CommonUtil.ProductFamily.AstroRadio, global::Motorola.Common.Communication.CommonUtil.RadioStorage.Raw, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Read | global::Motorola.Common.Communication.CommonUtil.RadioOperation.Program)]
	[global::Motorola.Common.Communication.CommunicationManager.Initializer(global::Motorola.Common.Communication.CommonUtil.ConnectionType.Otap, global::Motorola.Common.Communication.CommonUtil.ProductFamily.AstroRadio, global::Motorola.Common.Communication.CommonUtil.RadioStorage.Any, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Create)]
	internal class AstroOtapCpsSequenceManagerCreator : global::Motorola.Common.Communication.CommunicationManager.ISequenceManagerCreator
	{
		// Token: 0x0600007F RID: 127 RVA: 0x000039A4 File Offset: 0x00001BA4
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
			return new global::Motorola.Common.Communication.AstroOtapCpsSequenceManager(rcmpWrapper, num, sessionParameter);
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000080 RID: 128 RVA: 0x00003A27 File Offset: 0x00001C27
		public global::System.Type ExpectedType
		{
			get
			{
				return typeof(global::Motorola.Common.Communication.AstroOtapCpsSequenceManager);
			}
		}
	}
}
