using System;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommunicationPipe;

namespace Motorola.Common.Communication.CommunicationManager
{
	// Token: 0x02000012 RID: 18
	[global::Motorola.Common.Communication.CommunicationManager.Initializer(global::Motorola.Common.Communication.CommonUtil.ConnectionType.NetAdapter, global::Motorola.Common.Communication.CommonUtil.ProductFamily.AstroRadio, global::Motorola.Common.Communication.CommonUtil.RadioStorage.FileSystem, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Flash)]
	internal class AstroFileFlashSequenceManagerCreator : global::Motorola.Common.Communication.CommunicationManager.ISequenceManagerCreator
	{
		// Token: 0x0600008B RID: 139 RVA: 0x00003B74 File Offset: 0x00001D74
		public global::Motorola.Common.Communication.ICpsSequenceManager Create(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe iCommPipe, global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.CommonUtil.SessionParameter sessionParameter)
		{
			global::Motorola.Common.Communication.IMessageExecutor rcmpWrapper = global::Motorola.Common.Communication.CommunicationManager.newRcmpMessageExecutor.newRMessageExecutor(iCommPipe);
			return (sessionParameter != null && sessionParameter.ArchiveSession) ? new global::Motorola.Common.Communication.AstroManagedFileFlashSequenceManager(rcmpWrapper, sessionParameter) : new global::Motorola.Common.Communication.AstroFileFlashSequenceManager(rcmpWrapper, sessionParameter);
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600008C RID: 140 RVA: 0x00003BA5 File Offset: 0x00001DA5
		public global::System.Type ExpectedType
		{
			get
			{
				return typeof(global::Motorola.Common.Communication.AstroFileFlashSequenceManager);
			}
		}
	}
}
