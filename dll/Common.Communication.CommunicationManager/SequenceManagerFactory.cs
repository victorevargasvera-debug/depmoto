using System;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommunicationPipe;

namespace Motorola.Common.Communication.CommunicationManager
{
	// Token: 0x02000045 RID: 69
	internal static class SequenceManagerFactory
	{
		// Token: 0x06000193 RID: 403 RVA: 0x00007C7C File Offset: 0x00005E7C
		public static global::Motorola.Common.Communication.ICpsSequenceManager CreateSequenceManager(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.CommonUtil.RadioOperation operation, global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe iCommPipe, global::Motorola.Common.Communication.CommonUtil.SessionParameter sessionParameter)
		{
			global::Motorola.Common.Communication.CommunicationManager.ISequenceManagerCreator sequenceManagerCreator = global::Motorola.Common.Communication.CommunicationManager.SequenceManagerFactory.FindSequenceManagerCreator(deviceInfo, operation);
			return sequenceManagerCreator.Create(iCommPipe, deviceInfo, sessionParameter);
		}

		// Token: 0x06000194 RID: 404 RVA: 0x00007C9C File Offset: 0x00005E9C
		private static global::System.Type ExpectedSequenceManageType(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.CommonUtil.RadioOperation operation)
		{
			global::Motorola.Common.Communication.CommunicationManager.ISequenceManagerCreator sequenceManagerCreator = global::Motorola.Common.Communication.CommunicationManager.SequenceManagerFactory.FindSequenceManagerCreator(deviceInfo, operation);
			return sequenceManagerCreator.ExpectedType;
		}

		// Token: 0x06000195 RID: 405 RVA: 0x00007CB8 File Offset: 0x00005EB8
		private static global::Motorola.Common.Communication.CommunicationManager.ISequenceManagerCreator FindSequenceManagerCreator(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.CommonUtil.RadioOperation operation)
		{
			global::Motorola.Common.Communication.CommunicationManager.InitializerAttribute attrToMatch = new global::Motorola.Common.Communication.CommunicationManager.InitializerAttribute(deviceInfo.ConnectionInfo.ConnectionType, deviceInfo.Family, deviceInfo.RadioStorage, operation);
			global::System.Type type = global::Motorola.Common.Communication.CommunicationManager.InitializerAttribute.SearchSingleMatchedClass(typeof(global::Motorola.Common.Communication.CommunicationManager.ISequenceManagerCreator), attrToMatch);
			return global::System.Activator.CreateInstance(type) as global::Motorola.Common.Communication.CommunicationManager.ISequenceManagerCreator;
		}
	}
}
