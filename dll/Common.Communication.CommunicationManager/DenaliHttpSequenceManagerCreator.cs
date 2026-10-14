using System;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommunicationPipe;

namespace Motorola.Common.Communication.CommunicationManager
{
	// Token: 0x02000023 RID: 35
	[global::Motorola.Common.Communication.CommunicationManager.Initializer(global::Motorola.Common.Communication.CommonUtil.ConnectionType.NetAdapter, global::Motorola.Common.Communication.CommonUtil.ProductFamily.DenaliRadio, global::Motorola.Common.Communication.CommonUtil.RadioStorage.Any, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Create | global::Motorola.Common.Communication.CommonUtil.RadioOperation.Read | global::Motorola.Common.Communication.CommonUtil.RadioOperation.Program)]
	internal class DenaliHttpSequenceManagerCreator : global::Motorola.Common.Communication.CommunicationManager.ISequenceManagerCreator
	{
		// Token: 0x06000111 RID: 273 RVA: 0x000065A0 File Offset: 0x000047A0
		public global::Motorola.Common.Communication.ICpsSequenceManager Create(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe iCommPipe, global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.CommonUtil.SessionParameter sessionParameter)
		{
			global::Motorola.Common.Communication.IMessageExecutor executor = this.newHttpMessageExecutor(iCommPipe);
			return new global::Motorola.Common.Communication.DenaliSequenceManager(executor);
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000112 RID: 274 RVA: 0x000065BD File Offset: 0x000047BD
		public global::System.Type ExpectedType
		{
			get
			{
				return typeof(global::Motorola.Common.Communication.DenaliSequenceManager);
			}
		}

		// Token: 0x06000113 RID: 275 RVA: 0x000065C9 File Offset: 0x000047C9
		private global::Motorola.Common.Communication.HttpMessageExecutor newHttpMessageExecutor(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe commPipe)
		{
			return new global::Motorola.Common.Communication.HttpMessageExecutor(commPipe);
		}
	}
}
