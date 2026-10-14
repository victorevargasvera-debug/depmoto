using System;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommunicationPipe;

namespace Motorola.Common.Communication.CommunicationManager
{
	// Token: 0x0200001A RID: 26
	internal static class CommunicationPipeFactory
	{
		// Token: 0x060000D0 RID: 208 RVA: 0x000053D0 File Offset: 0x000035D0
		private static global::System.Type ExpectedCommunicationPipeType(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.CommonUtil.RadioOperation operation)
		{
			global::Motorola.Common.Communication.CommunicationManager.ICommunicationPipeCreator communicationPipeCreator = global::Motorola.Common.Communication.CommunicationManager.CommunicationPipeFactory.FindCommunicationPipeCreator(deviceInfo, operation);
			return communicationPipeCreator.ExpectedType;
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x000053EC File Offset: 0x000035EC
		public static global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe CreateCommunicationPipe(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.CommonUtil.RadioOperation operation)
		{
			global::Motorola.Common.Communication.CommunicationManager.ICommunicationPipeCreator communicationPipeCreator = global::Motorola.Common.Communication.CommunicationManager.CommunicationPipeFactory.FindCommunicationPipeCreator(deviceInfo, operation);
			return communicationPipeCreator.Create(deviceInfo);
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00005408 File Offset: 0x00003608
		private static global::Motorola.Common.Communication.CommunicationManager.ICommunicationPipeCreator FindCommunicationPipeCreator(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.CommonUtil.RadioOperation operation)
		{
			global::Motorola.Common.Communication.CommunicationManager.InitializerAttribute attrToMatch = new global::Motorola.Common.Communication.CommunicationManager.InitializerAttribute(deviceInfo.ConnectionInfo.ConnectionType, deviceInfo.Family, deviceInfo.RadioStorage, operation);
			global::System.Type type = global::Motorola.Common.Communication.CommunicationManager.InitializerAttribute.SearchSingleMatchedClass(typeof(global::Motorola.Common.Communication.CommunicationManager.ICommunicationPipeCreator), attrToMatch);
			return global::System.Activator.CreateInstance(type) as global::Motorola.Common.Communication.CommunicationManager.ICommunicationPipeCreator;
		}
	}
}
